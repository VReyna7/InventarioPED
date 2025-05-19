using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioPED.Forms.EnvioForms;
using InventarioPED.Forms.Producto;

namespace InventarioPED.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            panelContenedor.Controls.Clear();  // Limpia contenido anterior

            formHijo.TopLevel = false;         // Esto es clave: desactiva el comportamiento de ventana
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;    // Se adapta al tamaño del panel

            panelContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void toolStripAgregarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ProductosForm());
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ProductosForm());
        }

        private void toolTipEnvio_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new Envios());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
