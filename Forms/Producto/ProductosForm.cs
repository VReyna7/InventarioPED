using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioPED.Forms.Producto
{
    public partial class ProductosForm : Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            panelEnviosForm.Controls.Clear();  // Limpia contenido anterior

            formHijo.TopLevel = false;         // Esto es clave: desactiva el comportamiento de ventana
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;    // Se adapta al tamaño del panel

            panelEnviosForm.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void EnviosForm_Load(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ProductosAdministracion());
        }

        private void ToolStripAdminisProduc_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ProductosAdministracion());
        }

        private void ToolStripAgregarProduc_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new AgregarProductosForm());
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
