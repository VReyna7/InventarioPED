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
            if (!ValidarCamposProducto(out decimal precio, out int cantidad))
                return;

            var producto = new Producto
            {
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = precio,
                Cantidad = cantidad,
                CategoriaId = (int)cmbCategoria.SelectedValue,
                ProveedorId = (int)cmbProveedor.SelectedValue
            };

            var service = new ProductoService();
            string resultado = await service.AgregarProductoAsync(producto);

            if (resultado == "OK")
            {
                MessageBox.Show("Producto registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarProductosDesdeBD(arbol);
                CargarDatosEnGrid(arbol, dgvUltimosProductos);
            }
            else
            {
                MessageBox.Show("Error: " + resultado, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarCamposProducto(out decimal precio, out int cantidad)
        {
            precio = 0;
            cantidad = 0;

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), out precio))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtCantidad.Text.Trim(), out cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbCategoria.SelectedItem == null || cmbProveedor.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoría y un proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            string proveedor = txtProveedor.Text;
            if(proveedor.Length > 0)
            {
                AgregarProveedor(proveedor);
                txtProveedor.Text = "";

                var proveedorService = new ProveedorService();
                var proveedores = proveedorService.ObtenerTodos();

                cmbProveedor.DataSource = proveedores;
                cmbProveedor.DisplayMember = "Nombre";
                cmbProveedor.ValueMember = "Id";

            }
            
            
        }

        //METODO PARA AGREGAR UN NUEVO PROVEEDOR
        public void AgregarProveedor(string proveedor)
        {
            using (var contexto = new InventarioDBContext())
            {
                Proveedor nuevaProveedor = new Proveedor
                {
                    Nombre = proveedor,
                };

                contexto.Proveedores.Add(nuevaProveedor);
                contexto.SaveChanges();
                MessageBox.Show($"✅ Proveedor '{proveedor}' registrada correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
