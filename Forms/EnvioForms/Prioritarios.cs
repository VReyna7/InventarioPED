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
using Microsoft.EntityFrameworkCore;
using InventarioPED.Models;

namespace InventarioPED.Forms.EnvioForms
{
    public partial class Prioritarios : Form
    {
        private PriorityQueue<NodoEnvio, (int nivel, DateTime fecha)> colaPrioridad;


        public Prioritarios()
        {
            InitializeComponent();
            colaPrioridad = new PriorityQueue<NodoEnvio, (int, DateTime)>();
            ConfigurarDataGridView(dtgvPrioritarios);
            CargarEnviosYConstruirCola();
            MostrarTopPrioritarios(colaPrioridad.Count);
        }
        public Prioritarios(PriorityQueue<NodoEnvio, (int nivel, DateTime fecha)> colaPrioridad)
        {
            InitializeComponent();
            this.colaPrioridad = colaPrioridad;
            ConfigurarDataGridView(dtgvPrioritarios);
            MostrarTopPrioritarios(colaPrioridad.Count);
        }

        private void CargarEnviosYConstruirCola()
        {
            colaPrioridad.Clear();
            using (var contexto = new InventarioDBContext())
            {
                var envios = contexto.Envios
                    .Include(e => e.Estado)
                    .Include(e => e.Prioridad)
                    .ToList();

                foreach (var envio in envios)
                {
                    var nodo = new NodoEnvio(
                        envio.Id,
                        envio.Nombre,
                        envio.Direccion,
                        envio.Peso,
                        envio.Prioridad.Nombre,
                        envio.Estado.Nombre,
                        envio.CreatedAt
                    );
                    colaPrioridad.Enqueue(nodo, (nodo.NivelPrioridad, nodo.CreadoEn));
                }
            }
        }

        private void MostrarTopPrioritarios(int topN)
        {
            dtgvPrioritarios.Rows.Clear();
            var aux = new PriorityQueue<NodoEnvio, (int nivel, DateTime fecha)>();
            for (int i = 0; i < topN && colaPrioridad.Count > 0; i++)
            {
                var nodo = colaPrioridad.Dequeue();
                dtgvPrioritarios.Rows.Add(
                    nodo.Id,
                    nodo.Nombre,
                    nodo.Direccion,
                    nodo.Peso,
                    nodo.Estado,
                    nodo.Prioridad,
                    nodo.CreadoEn.ToString("g")
                );
                aux.Enqueue(nodo, (nodo.NivelPrioridad, nodo.CreadoEn));
            }
            while (aux.Count > 0)
            {
                var n = aux.Dequeue();
                colaPrioridad.Enqueue(n, (n.NivelPrioridad, n.CreadoEn));
            }
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
            dataGridView.Columns.Add("Creado en", "Creado En");
        }

        private void BtnMostar10_Click(object sender, EventArgs e)
        {
            MostrarTopPrioritarios(10);
        }

        private void BtnMostrar25_Click(object sender, EventArgs e)
        {
            MostrarTopPrioritarios(25);
        }

        private void btnVistGeneral_Click(object sender, EventArgs e)
        {
            MostrarTopPrioritarios(colaPrioridad.Count);
        }
    }
}
