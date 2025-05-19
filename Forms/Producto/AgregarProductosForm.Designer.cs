namespace InventarioPED
{
    partial class AgregarProductosForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            dgvUltimosProductos = new DataGridView();
            txtNombre = new TextBox();
            lbNombreProducto = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            label1 = new Label();
            cmbCategoria = new ComboBox();
            lblProveedor = new Label();
            cmbProveedor = new ComboBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvUltimosProductos).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(27, 418);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += BtnAgregar_ClickAsync;
            // 
            // dgvUltimosProductos
            // 
            dgvUltimosProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimosProductos.Location = new Point(21, 38);
            dgvUltimosProductos.Name = "dgvUltimosProductos";
            dgvUltimosProductos.Size = new Size(780, 367);
            dgvUltimosProductos.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(27, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(226, 23);
            txtNombre.TabIndex = 2;
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Location = new Point(27, 56);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(51, 15);
            lbNombreProducto.TabIndex = 5;
            lbNombreProducto.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(27, 121);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(226, 82);
            txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(27, 103);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripción";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(27, 237);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 8;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(27, 219);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(213, 219);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(213, 237);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 281);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 12;
            label1.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { " Tecnología" });
            cmbCategoria.Location = new Point(27, 299);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(191, 23);
            cmbCategoria.TabIndex = 13;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(27, 340);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(61, 15);
            lblProveedor.TabIndex = 15;
            lblProveedor.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Items.AddRange(new object[] { " Tecnología" });
            cmbProveedor.Location = new Point(27, 358);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(191, 23);
            cmbProveedor.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(13, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 446);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Producto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvUltimosProductos);
            groupBox2.Location = new Point(384, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(826, 445);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ultimos productos agregados";
            // 
            // AgregarProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 506);
            Controls.Add(cmbProveedor);
            Controls.Add(lblProveedor);
            Controls.Add(cmbCategoria);
            Controls.Add(label1);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lbNombreProducto);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "AgregarProductosForm";
            Text = "AgregarProductos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUltimosProductos).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private DataGridView dgvUltimosProductos;
        private TextBox txtNombre;
        private Label lbNombreProducto;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label label1;
        private ComboBox cmbCategoria;
        private Label lblProveedor;
        private ComboBox cmbProveedor;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
