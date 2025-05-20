using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioPED.Data;
using InventarioPED.Models;
using InventarioPED.Services;
using Microsoft.EntityFrameworkCore;

namespace InventarioPED.Forms.EnvioForms
{
    public partial class AgregarEnvio : Form
    {
        ArbolBinarioEnvio arbol = new ArbolBinarioEnvio();
        private PriorityQueue<NodoEnvio, (int nivel, DateTime fecha)> colaPrioridad;
        public AgregarEnvio()
        {
            InitializeComponent();
            colaPrioridad = new PriorityQueue<NodoEnvio, (int, DateTime)>();
        }

        private void ConfigurarDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Nombre", "Nombre");
            dataGridView.Columns.Add("Dirección", "Dirección");
            dataGridView.Columns.Add("Peso", "Peso");
            dataGridView.Columns.Add("Estado", "Estado");
            dataGridView.Columns.Add("Prioridad", "Prioridad");
        }

        private void AgregarEnvio_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView(dtvgUltimosEnvios);
            CargarEnviosDesdeBD(arbol);
            CargarEnviosEnGrid(arbol, dtvgUltimosEnvios);

            var estadoService = new EstadoService();
            var estados = estadoService.ObtenerTodas();

            cmbEstado.DataSource = estados;
            cmbEstado.DisplayMember = "Nombre";
            cmbEstado.ValueMember = "Id";

            var prioridadService = new PrioridadService();
            var prioridades = prioridadService.ObtenerTodas();
            cmbPrioridad.DataSource = prioridades;
            cmbPrioridad.DisplayMember = "Nombre";
            cmbPrioridad.ValueMember = "Id";
        }

        private void CargarEnviosDesdeBD(ArbolBinarioEnvio arbol)
        {
            arbol.Raiz = null;
            colaPrioridad.Clear();

            using (var contexto = new InventarioDBContext())
            {
                var envios = contexto.Envios
                    .Include(e => e.Estado)
                    .Include(e => e.Prioridad)
                    .ToList();

                foreach (var envio in envios)
                {
                    string idStr = envio.Id;
                    if (arbol.BuscarPorId(idStr) == null)
                    {
                        var creado = envio.CreatedAt;
                        var nodo = new NodoEnvio(
                            idStr,
                            envio.Nombre,
                            envio.Direccion,
                            envio.Peso,
                            envio.Prioridad.Nombre,
                            envio.Estado.Nombre,
                            creado
                        );

                        arbol.Insertar(nodo);
                        colaPrioridad.Enqueue(nodo, (nodo.NivelPrioridad, nodo.CreadoEn));
                    }
                }
            }
        }

        private void CargarEnviosEnGrid(ArbolBinarioEnvio arbol, DataGridView dataGridView)
        {
            List<NodoEnvio> lista = new List<NodoEnvio>();
            arbol.RecorridoEnOrden(lista);

            dataGridView.Rows.Clear();

            if (lista.Count == 0)
            {
                MessageBox.Show("No hay envíos en el árbol binario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var nodo in lista)
            {
                dataGridView.Rows.Add(
                    nodo.Id,
                    nodo.Nombre,
                    nodo.Direccion,
                    nodo.Peso,
                    nodo.Prioridad,
                    nodo.Estado
                );
            }
        }

        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            var envioEnt = new Envio
            {
                Nombre = txtNombreEnvio.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Peso = float.Parse(txtPeso.Text),
                EstadoId = (int)cmbEstado.SelectedValue,
                PrioridadId = (int)cmbPrioridad.SelectedValue,
                //CreatedAt = DateTime.Now  // <-- asigna aquí la fecha
            };

            var servicio = new EnvioService();
            var resultado = await servicio.AgregarEnvioAsync(envioEnt);

            if (resultado == "OK")
            {
                MessageBox.Show("Producto guardado con éxito.");
                LimpiarFormulario();

                CargarEnviosDesdeBD(arbol);
                CargarEnviosEnGrid(arbol, dtvgUltimosEnvios); 
            }
            else
            {
                MessageBox.Show("Error: " + resultado, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombreEnvio.Clear();
            txtDireccion.Clear();
            txtPeso.Clear();

            if (cmbEstado.Items.Count > 0)
                cmbEstado.SelectedIndex = 0;

            if (cmbPrioridad.Items.Count > 0)
                cmbPrioridad.SelectedIndex = 0;

            txtNombreEnvio.Focus(); // Vuelve a enfocar al primer campo
        }
    }
}
