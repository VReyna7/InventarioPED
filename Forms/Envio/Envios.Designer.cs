namespace InventarioPED.Forms
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
            toolStripSeparator3 = new ToolStripSeparator();
            ToolStripEliminar = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            ToolStripEditar = new ToolStripLabel();
            panelContenedorEnvio = new Panel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMain, toolStripSeparator1, ToolStripAgregar, toolStripSeparator3, ToolStripEliminar, toolStripSeparator2, ToolStripEditar });
            toolStrip1.Location = new Point(9, 9);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(260, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripMain
            // 
            ToolStripMain.Name = "ToolStripMain";
            ToolStripMain.Size = new Size(94, 22);
            ToolStripMain.Text = "Todos los envios";
            ToolStripMain.Click += ToolStripMain_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // ToolStripAgregar
            // 
            ToolStripAgregar.Name = "ToolStripAgregar";
            ToolStripAgregar.Size = new Size(49, 22);
            ToolStripAgregar.Text = "Agregar";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // ToolStripEliminar
            // 
            ToolStripEliminar.Name = "ToolStripEliminar";
            ToolStripEliminar.Size = new Size(50, 22);
            ToolStripEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // ToolStripEditar
            // 
            ToolStripEditar.Name = "ToolStripEditar";
            ToolStripEditar.Size = new Size(37, 22);
            ToolStripEditar.Text = "Editar";
            // 
            // panelContenedorEnvio
            // 
            panelContenedorEnvio.Location = new Point(10, 35);
            panelContenedorEnvio.Name = "panelContenedorEnvio";
            panelContenedorEnvio.Size = new Size(861, 368);
            panelContenedorEnvio.TabIndex = 1;
            // 
            // Envio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 415);
            Controls.Add(panelContenedorEnvio);
            Controls.Add(toolStrip1);
            Name = "Envio";
            Text = "Envio";
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
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel ToolStripEliminar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel ToolStripEditar;
        private Panel panelContenedorEnvio;
    }
}