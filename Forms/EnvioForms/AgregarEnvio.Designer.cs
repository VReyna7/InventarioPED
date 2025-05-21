namespace InventarioPED.Forms.EnvioForms
{
    partial class AgregarEnvio
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
            lblNombreEnvio = new Label();
            txtNombreEnvio = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblPesoEnvio = new Label();
            txtPeso = new TextBox();
            cmbEstado = new ComboBox();
            lblEstado = new Label();
            lblPrioridad = new Label();
            cmbPrioridad = new ComboBox();
            btnAgregar = new Button();
            dtvgUltimosEnvios = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cmbProducto = new ComboBox();
            lblProducto = new Label();
            ((System.ComponentModel.ISupportInitialize)dtvgUltimosEnvios).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreEnvio
            // 
            lblNombreEnvio.AutoSize = true;
            lblNombreEnvio.Location = new Point(52, 57);
            lblNombreEnvio.Name = "lblNombreEnvio";
            lblNombreEnvio.Size = new Size(51, 15);
            lblNombreEnvio.TabIndex = 1;
            lblNombreEnvio.Text = "Nombre";
            // 
            // txtNombreEnvio
            // 
            txtNombreEnvio.Location = new Point(49, 56);
            txtNombreEnvio.Name = "txtNombreEnvio";
            txtNombreEnvio.Size = new Size(286, 23);
            txtNombreEnvio.TabIndex = 2;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(53, 110);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(18, 126);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(285, 74);
            txtDireccion.TabIndex = 4;
            // 
            // lblPesoEnvio
            // 
            lblPesoEnvio.AutoSize = true;
            lblPesoEnvio.Location = new Point(56, 224);
            lblPesoEnvio.Name = "lblPesoEnvio";
            lblPesoEnvio.Size = new Size(56, 15);
            lblPesoEnvio.TabIndex = 5;
            lblPesoEnvio.Text = "Peso (lb):";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(56, 245);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 6;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(182, 243);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 7;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(182, 222);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado:";
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Location = new Point(60, 310);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(58, 15);
            lblPrioridad.TabIndex = 9;
            lblPrioridad.Text = "Prioridad:";
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.FormattingEnabled = true;
            cmbPrioridad.Location = new Point(60, 339);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(121, 23);
            cmbPrioridad.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(60, 390);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += BtnAgregar_Click;
            // 
            // dtvgUltimosEnvios
            // 
            dtvgUltimosEnvios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvgUltimosEnvios.Location = new Point(18, 36);
            dtvgUltimosEnvios.Name = "dtvgUltimosEnvios";
            dtvgUltimosEnvios.Size = new Size(797, 356);
            dtvgUltimosEnvios.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblProducto);
            groupBox1.Controls.Add(cmbProducto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbEstado);
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Location = new Point(32, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 427);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Envio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtvgUltimosEnvios);
            groupBox2.Location = new Point(392, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(841, 428);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ultimos envios";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(182, 337);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(121, 23);
            cmbProducto.TabIndex = 17;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(182, 308);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 16;
            lblProducto.Text = "Producto";
            // 
            // AgregarEnvio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 455);
            Controls.Add(btnAgregar);
            Controls.Add(cmbPrioridad);
            Controls.Add(lblPrioridad);
            Controls.Add(txtPeso);
            Controls.Add(lblPesoEnvio);
            Controls.Add(lblDireccion);
            Controls.Add(txtNombreEnvio);
            Controls.Add(lblNombreEnvio);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "AgregarEnvio";
            Text = "AgregarEnvio";
            Load += AgregarEnvio_Load;
            ((System.ComponentModel.ISupportInitialize)dtvgUltimosEnvios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombreEnvio;
        private TextBox txtNombreEnvio;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblPesoEnvio;
        private TextBox txtPeso;
        private ComboBox cmbEstado;
        private Label lblEstado;
        private Label lblPrioridad;
        private ComboBox cmbPrioridad;
        private Button btnAgregar;
        private DataGridView dtvgUltimosEnvios;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label lblProducto;
        private ComboBox cmbProducto;
    }
}