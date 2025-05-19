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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textBox2 = new TextBox();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 97);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Categorias";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(79, 53);
            button1.Name = "button1";
            button1.Size = new Size(119, 34);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
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
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(26, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 109);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar Producto";
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
            // textBox2
            // 
            textBox2.Location = new Point(88, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 1;
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
            groupBox3.Location = new Point(26, 220);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(266, 108);
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
            cmbIdProd.FormattingEnabled = true;
            cmbIdProd.Location = new Point(88, 25);
            cmbIdProd.Name = "cmbIdProd";
            cmbIdProd.Size = new Size(159, 23);
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
            dataGridView1.Location = new Point(316, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(457, 372);
            dataGridView1.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnBusquedaCategoria);
            groupBox4.Controls.Add(cmbCatProd);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(26, 329);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(266, 108);
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
            cmbCatProd.FormattingEnabled = true;
            cmbCatProd.Location = new Point(88, 25);
            cmbCatProd.Name = "cmbCatProd";
            cmbCatProd.Size = new Size(159, 23);
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
            button5.Location = new Point(316, 396);
            button5.Name = "button5";
            button5.Size = new Size(220, 41);
            button5.TabIndex = 5;
            button5.Text = "Vista General de Productos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(542, 396);
            button6.Name = "button6";
            button6.Size = new Size(231, 41);
            button6.TabIndex = 6;
            button6.Text = "Volver al Menu Principal";
            button6.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(groupBox4);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox2;
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
    }
}