namespace InventarioPED.Forms
{
    partial class Productos
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
            groupBox1 = new GroupBox();
            txtCategoria = new TextBox();
            button1 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cmbElimProd = new ComboBox();
            button3 = new Button();
            label3 = new Label();
            groupBox3 = new GroupBox();
            btnBusquedaId = new Button();
            cmbIdProd = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            btnBusquedaCategoria = new Button();
            cmbCatProd = new ComboBox();
            label4 = new Label();
            button5 = new Button();
            button6 = new Button();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            btnElimCat = new Button();
            cmbCatElim = new ComboBox();
            label5 = new Label();
            groupBox7 = new GroupBox();
            cmbProveedorProdEdit = new ComboBox();
            cmbCatEditProd = new ComboBox();
            cmbProdEdit = new ComboBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            txtProdDescrpt = new TextBox();
            txtProdName = new TextBox();
            button2 = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 97);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Categorias";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(79, 24);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(168, 23);
            txtCategoria.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(79, 53);
            button1.Name = "button1";
            button1.Size = new Size(119, 34);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbElimProd);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(13, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 109);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar Producto";
            // 
            // cmbElimProd
            // 
            cmbElimProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbElimProd.FormattingEnabled = true;
            cmbElimProd.Location = new Point(88, 26);
            cmbElimProd.Name = "cmbElimProd";
            cmbElimProd.Size = new Size(159, 23);
            cmbElimProd.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(79, 58);
            button3.Name = "button3";
            button3.Size = new Size(119, 33);
            button3.TabIndex = 2;
            button3.Text = "Eliminar Producto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 29);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 0;
            label3.Text = "ID Producto:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnBusquedaId);
            groupBox3.Controls.Add(cmbIdProd);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(17, 23);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(268, 108);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Busqueda por ID";
            // 
            // btnBusquedaId
            // 
            btnBusquedaId.Location = new Point(77, 60);
            btnBusquedaId.Name = "btnBusquedaId";
            btnBusquedaId.Size = new Size(121, 32);
            btnBusquedaId.TabIndex = 2;
            btnBusquedaId.Text = "Buscar";
            btnBusquedaId.UseVisualStyleBackColor = true;
            btnBusquedaId.Click += btnBusquedaId_Click;
            // 
            // cmbIdProd
            // 
            cmbIdProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdProd.FormattingEnabled = true;
            cmbIdProd.Location = new Point(88, 25);
            cmbIdProd.Name = "cmbIdProd";
            cmbIdProd.Size = new Size(162, 23);
            cmbIdProd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "ID Producto:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(559, 285);
            dataGridView1.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnBusquedaCategoria);
            groupBox4.Controls.Add(cmbCatProd);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(291, 24);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(285, 108);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Busqueda por Categoria";
            // 
            // btnBusquedaCategoria
            // 
            btnBusquedaCategoria.Location = new Point(77, 60);
            btnBusquedaCategoria.Name = "btnBusquedaCategoria";
            btnBusquedaCategoria.Size = new Size(121, 32);
            btnBusquedaCategoria.TabIndex = 2;
            btnBusquedaCategoria.Text = "Buscar";
            btnBusquedaCategoria.UseVisualStyleBackColor = true;
            btnBusquedaCategoria.Click += btnBusquedaCategoria_Click;
            // 
            // cmbCatProd
            // 
            cmbCatProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCatProd.FormattingEnabled = true;
            cmbCatProd.Location = new Point(88, 25);
            cmbCatProd.Name = "cmbCatProd";
            cmbCatProd.Size = new Size(180, 23);
            cmbCatProd.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 27);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 0;
            label4.Text = "Categoria:";
            // 
            // button5
            // 
            button5.Location = new Point(15, 355);
            button5.Name = "button5";
            button5.Size = new Size(264, 49);
            button5.TabIndex = 5;
            button5.Text = "Vista General de Productos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(15, 418);
            button6.Name = "button6";
            button6.Size = new Size(264, 48);
            button6.TabIndex = 6;
            button6.Text = "Volver al Menu Principal";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox4);
            groupBox5.Controls.Add(groupBox3);
            groupBox5.Controls.Add(dataGridView1);
            groupBox5.Location = new Point(305, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(593, 454);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Busqueda por Filtros";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnElimCat);
            groupBox6.Controls.Add(cmbCatElim);
            groupBox6.Controls.Add(label5);
            groupBox6.Location = new Point(15, 233);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(264, 107);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Eliminar Categoria";
            // 
            // btnElimCat
            // 
            btnElimCat.Location = new Point(75, 59);
            btnElimCat.Name = "btnElimCat";
            btnElimCat.Size = new Size(121, 32);
            btnElimCat.TabIndex = 3;
            btnElimCat.Text = "Eliminar";
            btnElimCat.UseVisualStyleBackColor = true;
            btnElimCat.Click += btnElimCat_Click;
            // 
            // cmbCatElim
            // 
            cmbCatElim.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCatElim.FormattingEnabled = true;
            cmbCatElim.Location = new Point(86, 26);
            cmbCatElim.Name = "cmbCatElim";
            cmbCatElim.Size = new Size(159, 23);
            cmbCatElim.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 29);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 1;
            label5.Text = "Categoria:";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cmbProveedorProdEdit);
            groupBox7.Controls.Add(cmbCatEditProd);
            groupBox7.Controls.Add(cmbProdEdit);
            groupBox7.Controls.Add(txtCantidad);
            groupBox7.Controls.Add(txtPrecio);
            groupBox7.Controls.Add(txtProdDescrpt);
            groupBox7.Controls.Add(txtProdName);
            groupBox7.Controls.Add(button2);
            groupBox7.Controls.Add(label12);
            groupBox7.Controls.Add(label11);
            groupBox7.Controls.Add(label10);
            groupBox7.Controls.Add(label9);
            groupBox7.Controls.Add(label8);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(label6);
            groupBox7.Location = new Point(920, 12);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(275, 454);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            groupBox7.Text = "Editar Producto";
            // 
            // cmbProveedorProdEdit
            // 
            cmbProveedorProdEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedorProdEdit.FormattingEnabled = true;
            cmbProveedorProdEdit.Location = new Point(83, 368);
            cmbProveedorProdEdit.Name = "cmbProveedorProdEdit";
            cmbProveedorProdEdit.Size = new Size(175, 23);
            cmbProveedorProdEdit.TabIndex = 17;
            // 
            // cmbCatEditProd
            // 
            cmbCatEditProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCatEditProd.FormattingEnabled = true;
            cmbCatEditProd.Location = new Point(84, 304);
            cmbCatEditProd.Name = "cmbCatEditProd";
            cmbCatEditProd.Size = new Size(174, 23);
            cmbCatEditProd.TabIndex = 16;
            // 
            // cmbProdEdit
            // 
            cmbProdEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProdEdit.FormattingEnabled = true;
            cmbProdEdit.Location = new Point(42, 31);
            cmbProdEdit.Name = "cmbProdEdit";
            cmbProdEdit.Size = new Size(216, 23);
            cmbProdEdit.TabIndex = 15;
            cmbProdEdit.SelectedIndexChanged += cmbProdEdit_SelectedIndexChanged;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(154, 236);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(104, 23);
            txtCantidad.TabIndex = 12;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(15, 235);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(99, 23);
            txtPrecio.TabIndex = 11;
            // 
            // txtProdDescrpt
            // 
            txtProdDescrpt.Location = new Point(91, 136);
            txtProdDescrpt.Multiline = true;
            txtProdDescrpt.Name = "txtProdDescrpt";
            txtProdDescrpt.Size = new Size(167, 52);
            txtProdDescrpt.TabIndex = 10;
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(76, 78);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(182, 23);
            txtProdName.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(66, 406);
            button2.Name = "button2";
            button2.Size = new Size(177, 33);
            button2.TabIndex = 7;
            button2.Text = "Editar Producto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 367);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 6;
            label12.Text = "Proveedor:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 303);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 5;
            label11.Text = "Categoria:";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(149, 217);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 4;
            label10.Text = "Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 217);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 3;
            label9.Text = "Precio:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 133);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 2;
            label8.Text = "Descripcion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 83);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 1;
            label7.Text = "Producto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 32);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 0;
            label6.Text = "ID:";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 486);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCategoria;
        private Button button1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label3;
        private Button btnBusquedaId;
        private ComboBox cmbIdProd;
        private Label label2;
        private Button button3;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private Button btnBusquedaCategoria;
        private ComboBox cmbCatProd;
        private Label label4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Button btnElimCat;
        private ComboBox cmbCatElim;
        private Label label5;
        private ComboBox cmbElimProd;
        private GroupBox groupBox7;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private TextBox txtProdDescrpt;
        private TextBox txtProdName;
        private Button button2;
        private Label label12;
        private Label label11;
        private ComboBox cmbProdEdit;
        private ComboBox cmbCatEditProd;
        private ComboBox cmbProveedorProdEdit;
    }
}