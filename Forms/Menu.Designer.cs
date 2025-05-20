namespace InventarioPED.Forms
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            toolStripAgregarProducto = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolTipEnvio = new ToolStripLabel();
            panelContenedor = new Panel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripAgregarProducto, toolStripSeparator1, toolTipEnvio });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(120, 25);
            toolStrip1.TabIndex = 0;
            // 
            // toolStripAgregarProducto
            // 
            toolStripAgregarProducto.Name = "toolStripAgregarProducto";
            toolStripAgregarProducto.Size = new Size(61, 22);
            toolStripAgregarProducto.Text = "Productos";
            toolStripAgregarProducto.Click += toolStripAgregarProducto_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolTipEnvio
            // 
            toolTipEnvio.Name = "toolTipEnvio";
            toolTipEnvio.Size = new Size(41, 22);
            toolTipEnvio.Text = "Envios";
            toolTipEnvio.Click += toolTipEnvio_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(12, 28);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1411, 505);
            panelContenedor.TabIndex = 1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 550);
            Controls.Add(panelContenedor);
            Controls.Add(toolStrip1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripAgregarProducto;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolTipEnvio;
        private Panel panelContenedor;
    }
}