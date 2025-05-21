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
using Microsoft.EntityFrameworkCore;

namespace InventarioPED.Forms.EnvioForms
{
    public partial class EnvioAdministracion : Form
    {
        ArbolBinarioEnvio arbol = new ArbolBinarioEnvio();
        public EnvioAdministracion()
        {
            InitializeComponent();
        }



        private void EnvioAdministracion_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView(dtgvTodosEnvios);
            CargarEnviosDesdeBD(arbol);
            CargarEnviosEnGrid(arbol, dtgvTodosEnvios);
            LlenarComboBoxDesdeArbol(arbol, cmbElimEnv);
            LlenarComboBoxDesdeArbol(arbol, cmbIdEnv);
            LlenarComboBoxDesdeArbol(arbol, cmbEditEnv);
            LlenarComboBoxConEstado(cmbEstadoEnv);
            LlenarComboBoxConPrioridad(cmbPrioridadEnv);

        }


        private void CargarEnviosDesdeBD(ArbolBinarioEnvio arbol)
        {
            arbol.Raiz = null;

            using (var contexto = new InventarioDBContext())
            {
                var envios = contexto.Envios
                    .Include(e => e.Estado)
                    .Include(e => e.Prioridad).Include(e => e.Producto)
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
                        envio.CreatedAt,      // tu propiedad ya viene de BD o del inicializador
                        envio.Producto.Nombre
                    );

                    arbol.Insertar(nodo);
                }
            }
        }

        private void ConfigurarDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Nombre", "Nombre");
            dataGridView.Columns.Add("Direccion", "Dirección");
            dataGridView.Columns.Add("Peso", "Peso");
            dataGridView.Columns.Add("Estado", "Estado");
            dataGridView.Columns.Add("Prioridad", "Prioridad");
            dataGridView.Columns.Add("Nombre Producto", "Nombre Producto");
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
                    nodo.Estado,
                    nodo.Prioridad,
                    nodo.IdProducto
                );
            }
        }

        private void LlenarComboBoxDesdeArbol(ArbolBinarioEnvio arbol, ComboBox comboBox)
        {
            List<string> listaIds = new List<string>();
            ObtenerIdsEnOrden(arbol.Raiz, listaIds);

            comboBox.Items.Clear();
            comboBox.Items.AddRange(listaIds.ToArray());
        }

        private void ObtenerIdsEnOrden(NodoEnvio nodo, List<string> lista)
        {
            if (nodo != null)
            {
                ObtenerIdsEnOrden(nodo.Izquierdo, lista);
                lista.Add(nodo.Id); // Agrega el ID del producto al listado
                ObtenerIdsEnOrden(nodo.Derecho, lista);
            }
        }

        private void LlenarComboBoxConEstado(ComboBox comboBox)
        {
            HashSet<string> Estado = ObtenerEstadoDesdeBD();

            comboBox.Items.Clear();
            comboBox.Items.AddRange(Estado.ToArray());
        }

        private void LlenarComboBoxConPrioridad(ComboBox comboBox)
        {
            HashSet<string> Prioridad = ObtenerPrioridadDesdeBD();

            comboBox.Items.Clear();
            comboBox.Items.AddRange(Prioridad.ToArray());
        }


        private HashSet<string> ObtenerEstadoDesdeBD()
        {
            HashSet<string> estadosunicos = new HashSet<string>();

            using (var contexto = new InventarioDBContext())
            {
                var categorias = contexto.Estados.Select(c => c.Nombre).Distinct().ToList();

                foreach (var categoria in categorias)
                {
                    estadosunicos.Add(categoria);
                }
            }

            return estadosunicos;
        }

        private HashSet<string> ObtenerPrioridadDesdeBD()
        {
            HashSet<string> prioridadUnicas = new HashSet<string>();

            using (var contexto = new InventarioDBContext())
            {
                var categorias = contexto.Prioridades.Select(c => c.Nombre).Distinct().ToList();

                foreach (var categoria in categorias)
                {
                    prioridadUnicas.Add(categoria);
                }
            }

            return prioridadUnicas;
        }

        private void cmbPrioridadEnv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEditEnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idSeleccionado = cmbEditEnv.Text;

            // Limpia los ComboBoxes antes de llenarlos
            cmbEditEstado.Items.Clear();
            cmbEditPrioridad.Items.Clear();

            CargarEstadosCmbs(cmbEditEstado);
            CargarPrioridadCmbs(cmbEditPrioridad);

            if (!string.IsNullOrEmpty(idSeleccionado))
            {
                NodoEnvio producto = arbol.BuscarPorId(idSeleccionado);

                if (producto != null)
                {
                    // Llenar los campos con los datos del producto obtenido del árbol
                    txtEnvioNombre.Text = producto.Nombre;
                    txtDireccion.Text = producto.Direccion;
                    cmbEditEstado.SelectedItem = producto.Estado;
                    cmbEditPrioridad.SelectedItem = producto.Prioridad;

                    //LlenarComboBoxConCategorias(cmbCatEditProd);
                    //LlenarComboBoxConProveedores(cmbProveedorProdEdit);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado en el árbol.", "Error");
                }
            }
        }

        public void CargarEstadosCmbs(ComboBox cmb)
        {
            using (var contexto = new InventarioDBContext())
            {
                var estados = contexto.Estados.ToList();
                foreach (var estado in estados)
                {
                    cmb.Items.Add(estado.Nombre);
                }
            }
        }

        public void CargarPrioridadCmbs(ComboBox cmb)
        {
            using (var contexto = new InventarioDBContext())
            {
                var Prioridades = contexto.Prioridades.ToList();
                foreach (var Prioridad in Prioridades)
                {
                    cmb.Items.Add(Prioridad.Nombre);
                }
            }
        }

        private void btnBusquedaEstado_Click(object sender, EventArgs e)
        {
            string EstadoBuscado = cmbEstadoEnv.Text;
            List<NodoEnvio> EnvioEstados = arbol.BuscarPorEstado(EstadoBuscado);

            if (EnvioEstados.Count > 0)
            {
                dtgvTodosEnvios.Rows.Clear();
                foreach (var envios in EnvioEstados)
                {
                    dtgvTodosEnvios.Rows.Add(envios.Id, envios.Nombre, envios.Direccion, envios.Peso, envios.Estado, envios.Prioridad);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron estados en los envios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBusquedaPrioridad_Click(object sender, EventArgs e)
        {
            string EstadoBuscado = cmbPrioridadEnv.Text;
            List<NodoEnvio> EnvioPrioridad = arbol.BuscarPorPrioridad(EstadoBuscado);

            if (EnvioPrioridad.Count > 0)
            {
                dtgvTodosEnvios.Rows.Clear();
                foreach (var prioridad in EnvioPrioridad)
                {
                    dtgvTodosEnvios.Rows.Add(prioridad.Id, prioridad.Nombre, prioridad.Direccion, prioridad.Peso, prioridad.Estado, prioridad.Prioridad);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron estados en los envios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBusquedaId_Click(object sender, EventArgs e)
        {
            string idBuscado = cmbIdEnv.Text;
            NodoEnvio producto = arbol.BuscarPorId(idBuscado);

            if (producto != null)
            {
                dtgvTodosEnvios.Rows.Clear();
                dtgvTodosEnvios.Rows.Add(producto.Id, producto.Nombre, producto.Direccion, producto.Peso, producto.Estado, producto.Prioridad);
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            arbol.Raiz = null;

            string idEnvio = cmbElimEnv.Text;
            NodoEnvio env = arbol.BuscarPorId(idEnvio);
            EliminarEnvios(idEnvio);


            dtgvTodosEnvios.Rows.Clear(); // También vacía el DataGridView

            CargarEnviosDesdeBD(arbol);
            CargarEnviosEnGrid(arbol, dtgvTodosEnvios);

            //LLENANDO LOS CMB CORRESPONDIENTES
            LlenarComboBoxDesdeArbol(arbol, cmbIdEnv);
            LlenarComboBoxDesdeArbol(arbol, cmbElimEnv);
        }

        private void btnVistaGeneralEnvios_Click(object sender, EventArgs e)
        {
            CargarEnviosEnGrid(arbol, dtgvTodosEnvios);
        }

        public void EliminarEnvios(string idEnv)
        {
            using (var contexto = new InventarioDBContext())
            {
                // Buscar la categoría en la BD
                var Envios = contexto.Envios.FirstOrDefault(c => c.Id == idEnv);

                if (Envios != null)
                {
                    contexto.Envios.Remove(Envios);
                    contexto.SaveChanges();
                    Console.WriteLine($"✅ Producto '{idEnv}' eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine($"❌ Producto '{Envios}' no existe en la BD.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idEnv = cmbEditEnv.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(idEnv))
            {
                NodoEnvio env = arbol.BuscarPorId(idEnv);

                if (env != null)
                {
                    // Modificar datos en el árbol
                    env.Nombre = txtEnvioNombre.Text.Trim();
                    env.Direccion = txtDireccion.Text.Trim();
                    env.Estado = cmbEditEstado.SelectedItem.ToString();
                    env.Prioridad = cmbEditPrioridad.SelectedItem.ToString();

                    MessageBox.Show($"✅ Producto actualizado en el árbol: {env.Id}");
                    ActualizarProductoEnBD(idEnv);
                }
                else
                {
                    MessageBox.Show("Error: No se encontró el producto en el árbol.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar DataGridView
                CargarEnviosEnGrid(arbol, dtgvTodosEnvios);
            }
        }


        private void ActualizarProductoEnBD(string idEnv)
        {
            using (var contexto = new InventarioDBContext())
            {
                var EnvBD = contexto.Envios.FirstOrDefault(p => p.Id == idEnv);

                if (EnvBD != null)
                {
                    EnvBD.Nombre = txtEnvioNombre.Text.Trim();
                    EnvBD.Direccion = txtDireccion.Text.Trim();

                    // Obtener ID de la categoría y proveedor desde el ComboBox
                    EnvBD.EstadoId = cmbEditEstado.SelectedIndex + 1;
                    EnvBD.PrioridadId = cmbEditPrioridad.SelectedIndex + 1;

                    contexto.SaveChanges();  // Guarda cambios en la BD
                    MessageBox.Show($"✅ Producto '{idEnv}' actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("❌ Error: El producto no existe en la base de datos.", "Validación");
                }
            }

        }

        
    }
}
