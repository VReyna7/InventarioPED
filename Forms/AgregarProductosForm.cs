using InventarioPED.Data;
using InventarioPED.Models;
using InventarioPED.Services;
using InventarioPED.Utils;

namespace InventarioPED
{
    public partial class AgregarProductosForm : Form
    {
        public AgregarProductosForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void BtnAgregar_ClickAsync(object sender, EventArgs e)
        {
            var producto = new Producto
            {
                Nombre = txtNombre.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                Precio = decimal.Parse(txtPrecio.Text),
                Cantidad = int.Parse(txtCantidad.Text),
                Categoria = cmbCategoria.SelectedItem?.ToString(),
                Proveedor = txtProveedor.Text.Trim()
            };

            var service = new ProductoService();
            string resultado = await service.AgregarProductoAsync(producto);

            if (resultado == "OK")
            {
                MessageBox.Show("Producto guardado con éxito.");
                LimpiarFormulario(); 
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
            txtProveedor.Clear();

            // Restablece el ComboBox a la primera opción
            if (cmbCategoria.Items.Count > 0)
                cmbCategoria.SelectedIndex = 0;

            // if (cmbProveedor.Items.Count > 0)
            //     cmbProveedor.SelectedIndex = 0;

            txtNombre.Focus(); // Vuelve a enfocar al primer campo
        }
    }
}
