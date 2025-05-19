namespace InventarioPED.Forms.Producto
{
    partial class ProductosForm
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
            ToolStripAdminisProduc = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            ToolStripAgregarProduc = new ToolStripLabel();
            panelEnviosForm = new Panel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { ToolStripAdminisProduc, toolStripSeparator1, ToolStripAgregarProduc });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(4);
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(180, 673);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // ToolStripAdminisProduc
            // 
            ToolStripAdminisProduc.Name = "ToolStripAdminisProduc";
            ToolStripAdminisProduc.Padding = new Padding(4);
            ToolStripAdminisProduc.Size = new Size(163, 23);
            ToolStripAdminisProduc.Text = "Administración de productos ";
            ToolStripAdminisProduc.Click += ToolStripAdminisProduc_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(163, 6);
            // 
            // ToolStripAgregarProduc
            // 
            ToolStripAgregarProduc.Name = "ToolStripAgregarProduc";
            ToolStripAgregarProduc.Padding = new Padding(2);
            ToolStripAgregarProduc.Size = new Size(163, 19);
            ToolStripAgregarProduc.Text = "Agregar productos";
            ToolStripAgregarProduc.Click += ToolStripAgregarProduc_Click;
            // 
            // panelEnviosForm
            // 
            panelEnviosForm.Location = new Point(186, 0);
            panelEnviosForm.Name = "panelEnviosForm";
            panelEnviosForm.Size = new Size(1228, 661);
            panelEnviosForm.TabIndex = 1;
            // 
            // ProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 673);
            Controls.Add(panelEnviosForm);
            Controls.Add(toolStrip1);
            Name = "ProductosForm";
            Text = "EnviosForm";
            Load += EnviosForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel ToolStripAdminisProduc;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel ToolStripAgregarProduc;
        private Panel panelEnviosForm;
    }
}