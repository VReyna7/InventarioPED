using InventarioPED.Data;
using InventarioPED.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioPED.Forms
{
    public partial class Productos : Form
    {
        private ArbolBinario arbol = new ArbolBinario();
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView(dataGridView1);

            // Cargar los productos en el árbol desde la BD (solo una vez)
            CargarProductosEnArbol(arbol);

            // Mostrar en DataGridView
            CargarDatosEnGrid(arbol, dataGridView1);

            // Llenar el ComboBox con los IDs de los productos registrados
            LlenarComboBoxDesdeArbol(arbol, cmbIdProd);

            // Llenar el ComboBox con las categorias de los productos registrados
            LlenarComboBoxConCategorias(arbol, cmbCatProd);
        }

        private void btnBusquedaId_Click(object sender, EventArgs e)
        {
            string idBuscado = cmbIdProd.Text;
            Nodo producto = arbol.BuscarPorId(idBuscado);

            if (producto != null)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add(producto.Id, producto.Nombre, producto.Descripcion, producto.Precio, producto.Cantidad, producto.Categoria, producto.Proveedor);
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBusquedaCategoria_Click(object sender, EventArgs e)
        {
            string categoriaBuscada = cmbCatProd.Text;
            List<Nodo> productosCategoria = arbol.BuscarPorCategoria(categoriaBuscada);

            if (productosCategoria.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (var producto in productosCategoria)
                {
                    dataGridView1.Rows.Add(producto.Id, producto.Nombre, producto.Descripcion, producto.Precio, producto.Cantidad, producto.Categoria, producto.Proveedor);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron productos en esta categoría.", "Aviso");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Mostrar en DataGridView
            CargarDatosEnGrid(arbol, dataGridView1);
        }

        //FUNCION PARA CARGAR LOS PRODUCTOS DE LA BDD EN EL ARBOL
        private void CargarProductosEnArbol(ArbolBinario arbol)
        {
            using (var contexto = new InventarioDBContext())
            {
                var productos = contexto.Productos.ToList();

                foreach (var producto in productos)
                {
                    arbol.Insertar(
                        producto.Id,
                        producto.Nombre,
                        producto.Descripcion,
                        producto.Precio,
                        producto.Cantidad,
                        producto.Categoria,
                        producto.Proveedor
                    );
                }
            }
        }


        //FUNCION PARA CARGAR LOS DATOS EN EL GRID
        private void CargarDatosEnGrid(ArbolBinario arbol, DataGridView dataGridView)
        {
            List<Nodo> lista = new List<Nodo>();
            arbol.RecorridoEnOrden(lista);

            dataGridView.Rows.Clear();

            if (lista.Count == 0)
            {
                MessageBox.Show("No hay productos en el árbol binario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var nodo in lista)
            {
                dataGridView.Rows.Add(nodo.Id, nodo.Nombre, nodo.Descripcion, nodo.Precio, nodo.Cantidad, nodo.Categoria, nodo.Proveedor);
            }
        }

        //FUNCION PARA CONFIGURAR EL DATA GRID VIEW
        private void ConfigurarDataGridView(DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("Nombre", "Nombre");
            dataGridView.Columns.Add("Descripcion", "Descripción");
            dataGridView.Columns.Add("Precio", "Precio");
            dataGridView.Columns.Add("Cantidad", "Cantidad");
            dataGridView.Columns.Add("Categoria", "Categoría");
            dataGridView.Columns.Add("Proveedor", "Proveedor");
        }

        //METODO PARA LLLENAR EL COMBOBOX CON LOS IDS DE LOS PRODUCTOS REGISTRADOS ALMACENADOS EN EL ARBOL
        private void LlenarComboBoxDesdeArbol(ArbolBinario arbol, ComboBox comboBox)
        {
            List<string> listaIds = new List<string>();
            ObtenerIdsEnOrden(arbol.Raiz, listaIds);

            comboBox.Items.Clear();
            comboBox.Items.AddRange(listaIds.ToArray());
        }

        // Método auxiliar para recorrer el árbol en orden y extraer los IDs
        private void ObtenerIdsEnOrden(Nodo nodo, List<string> lista)
        {
            if (nodo != null)
            {
                ObtenerIdsEnOrden(nodo.Izquierdo, lista);
                lista.Add(nodo.Id); // Agrega el ID del producto al listado
                ObtenerIdsEnOrden(nodo.Derecho, lista);
            }
        }

        //METODO PARA LLENAR EL COMBOBOX CON LAS CATEGORIAS DE LOS PRODUCTOS REGISTRADOS ALMACENADOS EN EL ARBOL
        private void LlenarComboBoxConCategorias(ArbolBinario arbol, ComboBox comboBox)
        {
            HashSet<string> categoriasUnicas = new HashSet<string>(); // Evita duplicados
            ObtenerCategorias(arbol.Raiz, categoriasUnicas);

            comboBox.Items.Clear();
            comboBox.Items.AddRange(categoriasUnicas.ToArray());
        }

        // Método auxiliar para recorrer el árbol y extraer categorías
        private void ObtenerCategorias(Nodo nodo, HashSet<string> lista)
        {
            if (nodo != null)
            {
                lista.Add(nodo.Categoria); // Agregar la categoría (HashSet evita duplicados)
                ObtenerCategorias(nodo.Izquierdo, lista);
                ObtenerCategorias(nodo.Derecho, lista);
            }
        }
    }
}
