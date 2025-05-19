using InventarioPED.Data;
using InventarioPED.Models;
using InventarioPED.Services;
using InventarioPED.Utils;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace InventarioPED
{
    public partial class AgregarProductosForm : Form
    {
        ArbolBinario arbol = new ArbolBinario();

        public AgregarProductosForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView(dgvUltimosProductos);

            // Cargar productos desde la base de datos
            CargarProductosDesdeBD(arbol);

            var categoriaService = new CategoriaService();
            var categorias = categoriaService.ObtenerTodas();

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";

            var proveedorService = new ProveedorService();
            var proveedores = proveedorService.ObtenerTodos();

            cmbProveedor.DataSource = proveedores;
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Id";

            if (arbol.Raiz == null)
            {
                MessageBox.Show("El árbol binario está vacío después de cargar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar en DataGridView
            CargarDatosEnGrid(arbol, dgvUltimosProductos);
        }

        private async void BtnAgregar_ClickAsync(object sender, EventArgs e)
        {
            var producto = new Producto
            {
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = decimal.Parse(txtPrecio.Text),
                Cantidad = int.Parse(txtCantidad.Text),
                CategoriaId = (int)cmbCategoria.SelectedValue,
                ProveedorId = (int)cmbProveedor.SelectedValue
            };

            var service = new ProductoService();
            string resultado = await service.AgregarProductoAsync(producto);

            if (resultado == "OK")
            {
                MessageBox.Show("Producto guardado con éxito.");
                LimpiarFormulario();
                CargarProductosDesdeBD(arbol);
                CargarDatosEnGrid(arbol, dgvUltimosProductos);
            }
            else
            {
                MessageBox.Show("Error: " + resultado, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();

            if (cmbProveedor.Items.Count > 0)
                cmbProveedor.SelectedIndex = 0;

            if (cmbCategoria.Items.Count > 0)
                cmbCategoria.SelectedIndex = 0;

            txtNombre.Focus(); // Vuelve a enfocar al primer campo
        }

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


        private void CargarProductosDesdeBD(ArbolBinario arbol)
        {
            using (var contexto = new InventarioDBContext())
            {
                var productos = contexto.Productos
                .Include(p => p.Categoria)
                .Include(p => p.Proveedor)
                .ToList();

                foreach (var producto in productos)
                {
                    // Verificar si el ID ya existe en el árbol antes de insertarlo
                    if (arbol.BuscarPorId(producto.Id) == null)
                    {
                        arbol.Insertar(
                            producto.Id,
                            producto.Nombre,
                            producto.Descripcion,
                            producto.Precio,
                            producto.Cantidad,
                            producto.Categoria.Nombre,
                            producto.Proveedor.Nombre
                        );
                    }

                }
            }
        }

        private void ToolStripAgregarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
