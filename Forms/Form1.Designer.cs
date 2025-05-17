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
            lblAgregarProducto = new Label();
            lblUltimosProductos = new Label();
            lbNombreProducto = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            label1 = new Label();
            cmbCategoria = new ComboBox();
            txtProveedor = new TextBox();
            lblProveedor = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUltimosProductos).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(41, 422);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_ClickAsync;
            // 
            // dgvUltimosProductos
            // 
            dgvUltimosProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimosProductos.Location = new Point(380, 74);
            dgvUltimosProductos.Name = "dgvUltimosProductos";
            dgvUltimosProductos.Size = new Size(269, 371);
            dgvUltimosProductos.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(226, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblAgregarProducto
            // 
            lblAgregarProducto.AutoSize = true;
            lblAgregarProducto.Location = new Point(41, 35);
            lblAgregarProducto.Name = "lblAgregarProducto";
            lblAgregarProducto.Size = new Size(101, 15);
            lblAgregarProducto.TabIndex = 3;
            lblAgregarProducto.Text = "Agregar producto";
            // 
            // lblUltimosProductos
            // 
            lblUltimosProductos.AutoSize = true;
            lblUltimosProductos.Location = new Point(380, 35);
            lblUltimosProductos.Name = "lblUltimosProductos";
            lblUltimosProductos.Size = new Size(165, 15);
            lblUltimosProductos.TabIndex = 4;
            lblUltimosProductos.Text = "Ultimos Productos Agregados";
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Location = new Point(41, 74);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(51, 15);
            lbNombreProducto.TabIndex = 5;
            lbNombreProducto.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(41, 139);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(226, 82);
            txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(41, 121);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripción";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(41, 255);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 8;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(41, 237);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(227, 237);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(227, 255);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 299);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 12;
            label1.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(41, 317);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 13;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(41, 376);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(272, 23);
            txtProveedor.TabIndex = 14;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(41, 358);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(58, 15);
            lblProveedor.TabIndex = 15;
            lblProveedor.Text = "Categoria";
            // 
            // AgregarProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 468);
            Controls.Add(lblProveedor);
            Controls.Add(txtProveedor);
            Controls.Add(cmbCategoria);
            Controls.Add(label1);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lbNombreProducto);
            Controls.Add(lblUltimosProductos);
            Controls.Add(lblAgregarProducto);
            Controls.Add(txtNombre);
            Controls.Add(dgvUltimosProductos);
            Controls.Add(btnAgregar);
            Name = "AgregarProductosForm";
            Text = "AgregarProductos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUltimosProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private DataGridView dgvUltimosProductos;
        private TextBox txtNombre;
        private Label lblAgregarProducto;
        private Label lblUltimosProductos;
        private Label lbNombreProducto;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label label1;
        private ComboBox cmbCategoria;
        private TextBox txtProveedor;
        private Label lblProveedor;
    }
}
