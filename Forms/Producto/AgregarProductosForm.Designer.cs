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
            groupBox3 = new GroupBox();
            label2 = new Label();
            txtProveedor = new TextBox();
            btnAgregarProv = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUltimosProductos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(89, 277);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(162, 39);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += BtnAgregar_ClickAsync;
            // 
            // dgvUltimosProductos
            // 
            dgvUltimosProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimosProductos.Location = new Point(21, 22);
            dgvUltimosProductos.Name = "dgvUltimosProductos";
            dgvUltimosProductos.Size = new Size(786, 436);
            dgvUltimosProductos.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(71, 25);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 23);
            txtNombre.TabIndex = 2;
            // 
            // lbNombreProducto
            // 
            lbNombreProducto.AutoSize = true;
            lbNombreProducto.Location = new Point(14, 28);
            lbNombreProducto.Name = "lbNombreProducto";
            lbNombreProducto.Size = new Size(54, 15);
            lbNombreProducto.TabIndex = 5;
            lbNombreProducto.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(89, 66);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(242, 82);
            txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(14, 69);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(60, 167);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(54, 23);
            txtPrecio.TabIndex = 8;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(14, 170);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(182, 175);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(242, 169);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(52, 23);
            txtCantidad.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 213);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 12;
            label1.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { " Tecnología" });
            cmbCategoria.Location = new Point(14, 236);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(140, 23);
            cmbCategoria.TabIndex = 13;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(177, 218);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(64, 15);
            lblProveedor.TabIndex = 15;
            lblProveedor.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Items.AddRange(new object[] { " Tecnología" });
            cmbProveedor.Location = new Point(176, 236);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(155, 23);
            cmbProveedor.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(cmbProveedor);
            groupBox1.Controls.Add(lbNombreProducto);
            groupBox1.Controls.Add(lblProveedor);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(lblDescripcion);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(lblCantidad);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Location = new Point(13, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 329);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Producto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvUltimosProductos);
            groupBox2.Location = new Point(384, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(826, 476);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ultimos productos agregados";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAgregarProv);
            groupBox3.Controls.Add(txtProveedor);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(13, 350);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(351, 144);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Registrar Proveedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 46);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 0;
            label2.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(89, 43);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(204, 23);
            txtProveedor.TabIndex = 1;
            // 
            // btnAgregarProv
            // 
            btnAgregarProv.Location = new Point(90, 86);
            btnAgregarProv.Name = "btnAgregarProv";
            btnAgregarProv.Size = new Size(167, 40);
            btnAgregarProv.TabIndex = 2;
            btnAgregarProv.Text = "Registrar Proveedor";
            btnAgregarProv.UseVisualStyleBackColor = true;
            btnAgregarProv.Click += btnAgregarProv_Click;
            // 
            // AgregarProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 506);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "AgregarProductosForm";
            Text = "AgregarProductos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUltimosProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox3;
        private Button btnAgregarProv;
        private TextBox txtProveedor;
        private Label label2;
    }
}
