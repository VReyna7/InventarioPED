namespace InventarioPED.Forms.EnvioForms
{
    partial class EnvioAdministracion
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
            groupBox7 = new GroupBox();
            cmbProveedorProdEdit = new ComboBox();
            cmbCatEditProd = new ComboBox();
            cmbProdEdit = new ComboBox();
            txtProdDescrpt = new TextBox();
            txtProdName = new TextBox();
            button2 = new Button();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox5 = new GroupBox();
            groupBox4 = new GroupBox();
            btnBusquedaCategoria = new Button();
            cmbCatProd = new ComboBox();
            label4 = new Label();
            groupBox3 = new GroupBox();
            btnBusquedaId = new Button();
            cmbIdProd = new ComboBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            cmbElimProd = new ComboBox();
            button3 = new Button();
            label3 = new Label();
            groupBox7.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cmbProveedorProdEdit);
            groupBox7.Controls.Add(cmbCatEditProd);
            groupBox7.Controls.Add(cmbProdEdit);
            groupBox7.Controls.Add(txtProdDescrpt);
            groupBox7.Controls.Add(txtProdName);
            groupBox7.Controls.Add(button2);
            groupBox7.Controls.Add(label12);
            groupBox7.Controls.Add(label11);
            groupBox7.Controls.Add(label8);
            groupBox7.Controls.Add(label7);
            groupBox7.Controls.Add(label6);
            groupBox7.Location = new Point(954, 12);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(275, 454);
            groupBox7.TabIndex = 16;
            groupBox7.TabStop = false;
            groupBox7.Text = "Editar Envio";
            // 
            // cmbProveedorProdEdit
            // 
            cmbProveedorProdEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedorProdEdit.FormattingEnabled = true;
            cmbProveedorProdEdit.Location = new Point(84, 280);
            cmbProveedorProdEdit.Name = "cmbProveedorProdEdit";
            cmbProveedorProdEdit.Size = new Size(175, 23);
            cmbProveedorProdEdit.TabIndex = 17;
            // 
            // cmbCatEditProd
            // 
            cmbCatEditProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCatEditProd.FormattingEnabled = true;
            cmbCatEditProd.Location = new Point(77, 220);
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
            // 
            // txtProdDescrpt
            // 
            txtProdDescrpt.Location = new Point(77, 133);
            txtProdDescrpt.Multiline = true;
            txtProdDescrpt.Name = "txtProdDescrpt";
            txtProdDescrpt.Size = new Size(181, 55);
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
            button2.Location = new Point(63, 337);
            button2.Name = "button2";
            button2.Size = new Size(177, 33);
            button2.TabIndex = 7;
            button2.Text = "Editar envio";
            button2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 283);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 6;
            label12.Text = "Prioridad:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 223);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 5;
            label11.Text = "Estado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 133);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 2;
            label8.Text = "Dirección:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 83);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 1;
            label7.Text = "Nombre:";
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
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox4);
            groupBox5.Controls.Add(groupBox3);
            groupBox5.Controls.Add(dataGridView1);
            groupBox5.Location = new Point(343, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(593, 454);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "Busqueda por Filtros";
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
            groupBox4.Text = "Busqueda por prioridad";
            // 
            // btnBusquedaCategoria
            // 
            btnBusquedaCategoria.Location = new Point(77, 60);
            btnBusquedaCategoria.Name = "btnBusquedaCategoria";
            btnBusquedaCategoria.Size = new Size(121, 32);
            btnBusquedaCategoria.TabIndex = 2;
            btnBusquedaCategoria.Text = "Buscar";
            btnBusquedaCategoria.UseVisualStyleBackColor = true;
            // 
            // cmbCatProd
            // 
            cmbCatProd.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCatProd.FormattingEnabled = true;
            cmbCatProd.Location = new Point(122, 25);
            cmbCatProd.Name = "cmbCatProd";
            cmbCatProd.Size = new Size(146, 23);
            cmbCatProd.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 27);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 0;
            label4.Text = "Nivel de prioridad:";
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
            label2.Size = new Size(53, 15);
            label2.TabIndex = 0;
            label2.Text = "ID envio:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(559, 285);
            dataGridView1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbElimProd);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 109);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar Envio";
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
            // EnvioAdministracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 491);
            Controls.Add(groupBox7);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Name = "EnvioAdministracion";
            Text = "EnvioAdministracion";
            Load += EnvioAdministracion_Load;
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox7;
        private ComboBox cmbProveedorProdEdit;
        private ComboBox cmbCatEditProd;
        private ComboBox cmbProdEdit;
        private TextBox txtProdDescrpt;
        private TextBox txtProdName;
        private Button button2;
        private Label label12;
        private Label label11;
        private Label label8;
        private Label label7;
        private Label label6;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Button btnBusquedaCategoria;
        private ComboBox cmbCatProd;
        private Label label4;
        private GroupBox groupBox3;
        private Button btnBusquedaId;
        private ComboBox cmbIdProd;
        private Label label2;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private ComboBox cmbElimProd;
        private Button button3;
        private Label label3;
    }
}