namespace InventarioPED.Forms.EnvioForms
{
    partial class Envios
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
            ToolStripMain = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            ToolStripAgregar = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            panelContenedorEnvio = new Panel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMain, toolStripSeparator1, ToolStripAgregar, toolStripSeparator2, toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(6);
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(176, 484);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripMain
            // 
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Padding = new Padding(6);
            ToolStripMain.Size = new Size(151, 27);
            ToolStripMain.Text = "Administración de envios";
            ToolStripMain.Click += ToolStripMain_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(151, 6);
            // 
            // ToolStripAgregar
            // 
            ToolStripAgregar.Name = "ToolStripAgregar";
            ToolStripAgregar.Padding = new Padding(4);
            ToolStripAgregar.Size = new Size(151, 23);
            ToolStripAgregar.Text = "Agregar envios";
            ToolStripAgregar.Click += ToolStripAgregar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(151, 6);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Padding = new Padding(4);
            toolStripLabel1.Size = new Size(151, 23);
            toolStripLabel1.Text = "Ordenamiento por Prioridad";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // panelContenedorEnvio
            // 
            panelContenedorEnvio.Location = new Point(161, 12);
            panelContenedorEnvio.Name = "panelContenedorEnvio";
            panelContenedorEnvio.Size = new Size(1231, 460);
            panelContenedorEnvio.TabIndex = 1;
            // 
            // Envios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 484);
            Controls.Add(panelContenedorEnvio);
            Controls.Add(toolStrip1);
            Name = "Envios";
            Text = "Envio";
            Load += Envios_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel ToolStripAgregar;
        private ToolStripContainer toolStripContainer1;
        private ToolStripLabel ToolStripMain;
        private ToolStripSeparator toolStripSeparator1;
        private Panel panelContenedorEnvio;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel1;
    }
}