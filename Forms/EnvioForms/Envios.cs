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

namespace InventarioPED.Forms.EnvioForms
{
    public partial class Envios : Form
    {
        public Envios()
        {
            InitializeComponent();
        }

        private void ToolStripMain_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new EnvioAdministracion());
        }

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            panelContenedorEnvio.Controls.Clear();  // Limpia contenido anterior

            formHijo.TopLevel = false;         // Esto es clave: desactiva el comportamiento de ventana
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;    // Se adapta al tamaño del panel

            panelContenedorEnvio.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void ToolStripAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new AgregarEnvio());
        }

        private void Envios_Load(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new EnvioAdministracion());
        }
    }
}
