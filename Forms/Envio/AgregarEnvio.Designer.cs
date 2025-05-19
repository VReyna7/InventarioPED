namespace InventarioPED.Forms.Envio
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
            lblAgregarEnvio = new Label();
            lblNombreEnvio = new Label();
            txtNombreEnvio = new TextBox();
            lblDireccion = new Label();
            textBox1 = new TextBox();
            lblPesoEnvio = new Label();
            txtPeso = new TextBox();
            cmbEstado = new ComboBox();
            lblEstado = new Label();
            lblPrioridad = new Label();
            cmbPrioridad = new ComboBox();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            lblUltimosEnvios = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblAgregarEnvio
            // 
            lblAgregarEnvio.AutoSize = true;
            lblAgregarEnvio.Location = new Point(49, 38);
            lblAgregarEnvio.Name = "lblAgregarEnvio";
            lblAgregarEnvio.Size = new Size(81, 15);
            lblAgregarEnvio.TabIndex = 0;
            lblAgregarEnvio.Text = "Agregar envio";
            // 
            // lblNombreEnvio
            // 
            lblNombreEnvio.AutoSize = true;
            lblNombreEnvio.Location = new Point(52, 84);
            lblNombreEnvio.Name = "lblNombreEnvio";
            lblNombreEnvio.Size = new Size(51, 15);
            lblNombreEnvio.TabIndex = 1;
            lblNombreEnvio.Text = "Nombre";
            // 
            // txtNombreEnvio
            // 
            txtNombreEnvio.Location = new Point(52, 102);
            txtNombreEnvio.Name = "txtNombreEnvio";
            txtNombreEnvio.Size = new Size(205, 23);
            txtNombreEnvio.TabIndex = 2;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(53, 137);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "Dirección";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 161);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 74);
            textBox1.TabIndex = 4;
            // 
            // lblPesoEnvio
            // 
            lblPesoEnvio.AutoSize = true;
            lblPesoEnvio.Location = new Point(56, 251);
            lblPesoEnvio.Name = "lblPesoEnvio";
            lblPesoEnvio.Size = new Size(32, 15);
            lblPesoEnvio.TabIndex = 5;
            lblPesoEnvio.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(56, 272);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 6;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(56, 339);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 7;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(56, 322);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado";
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Location = new Point(60, 383);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(55, 15);
            lblPrioridad.TabIndex = 9;
            lblPrioridad.Text = "Prioridad";
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.FormattingEnabled = true;
            cmbPrioridad.Location = new Point(60, 401);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(121, 23);
            cmbPrioridad.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(60, 470);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(343, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(549, 391);
            dataGridView1.TabIndex = 12;
            // 
            // lblUltimosEnvios
            // 
            lblUltimosEnvios.AutoSize = true;
            lblUltimosEnvios.Location = new Point(343, 70);
            lblUltimosEnvios.Name = "lblUltimosEnvios";
            lblUltimosEnvios.Size = new Size(85, 15);
            lblUltimosEnvios.TabIndex = 13;
            lblUltimosEnvios.Text = "Ultimos envios";
            // 
            // AgregarEnvio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 539);
            Controls.Add(lblUltimosEnvios);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregar);
            Controls.Add(cmbPrioridad);
            Controls.Add(lblPrioridad);
            Controls.Add(lblEstado);
            Controls.Add(cmbEstado);
            Controls.Add(txtPeso);
            Controls.Add(lblPesoEnvio);
            Controls.Add(textBox1);
            Controls.Add(lblDireccion);
            Controls.Add(txtNombreEnvio);
            Controls.Add(lblNombreEnvio);
            Controls.Add(lblAgregarEnvio);
            Name = "AgregarEnvio";
            Text = "AgregarEnvio";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgregarEnvio;
        private Label lblNombreEnvio;
        private TextBox txtNombreEnvio;
        private Label lblDireccion;
        private TextBox textBox1;
        private Label lblPesoEnvio;
        private TextBox txtPeso;
        private ComboBox cmbEstado;
        private Label lblEstado;
        private Label lblPrioridad;
        private ComboBox cmbPrioridad;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private Label lblUltimosEnvios;
    }
}