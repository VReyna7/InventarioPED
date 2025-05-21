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
            cmbEditPrioridad = new ComboBox();
            cmbEditEstado = new ComboBox();
            cmbEditEnv = new ComboBox();
            txtDireccion = new TextBox();
            txtEnvioNombre = new TextBox();
            button2 = new Button();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox5 = new GroupBox();
            btnVistaGeneralEnvios = new Button();
            groupBox1 = new GroupBox();
            cmbPrioridadEnv = new ComboBox();
            btnBusquedaPrioridad = new Button();
            label1 = new Label();
            groupBox4 = new GroupBox();
            btnBusquedaEstado = new Button();
            cmbEstadoEnv = new ComboBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            cmbElimEnv = new ComboBox();
            button3 = new Button();
            label3 = new Label();
            groupBox3 = new GroupBox();
            btnBusquedaId = new Button();
            cmbIdEnv = new ComboBox();
            label2 = new Label();
            dtgvTodosEnvios = new DataGridView();
            groupBox7.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTodosEnvios).BeginInit();
            SuspendLayout();
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cmbEditPrioridad);
            groupBox7.Controls.Add(cmbEditEstado);
            groupBox7.Controls.Add(cmbEditEnv);
            groupBox7.Controls.Add(txtDireccion);
            groupBox7.Controls.Add(txtEnvioNombre);
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
            // cmbEditPrioridad
            // 
            cmbEditPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditPrioridad.FormattingEnabled = true;
            cmbEditPrioridad.Location = new Point(84, 280);
            cmbEditPrioridad.Name = "cmbEditPrioridad";
            cmbEditPrioridad.Size = new Size(175, 23);
            cmbEditPrioridad.TabIndex = 17;
            // 
            // cmbEditEstado
            // 
            cmbEditEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditEstado.FormattingEnabled = true;
            cmbEditEstado.Location = new Point(77, 220);
            cmbEditEstado.Name = "cmbEditEstado";
            cmbEditEstado.Size = new Size(174, 23);
            cmbEditEstado.TabIndex = 16;
            // 
            // cmbEditEnv
            // 
            cmbEditEnv.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditEnv.FormattingEnabled = true;
            cmbEditEnv.Location = new Point(42, 31);
            cmbEditEnv.Name = "cmbEditEnv";
            cmbEditEnv.Size = new Size(216, 23);
            cmbEditEnv.TabIndex = 15;
            cmbEditEnv.SelectedIndexChanged += cmbEditEnv_SelectedIndexChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(77, 133);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(181, 55);
            txtDireccion.TabIndex = 10;
            // 
            // txtEnvioNombre
            // 
            txtEnvioNombre.Location = new Point(76, 78);
            txtEnvioNombre.Name = "txtEnvioNombre";
            txtEnvioNombre.Size = new Size(182, 23);
            txtEnvioNombre.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(63, 337);
            button2.Name = "button2";
            button2.Size = new Size(177, 33);
            button2.TabIndex = 7;
            button2.Text = "Editar envio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            groupBox5.Controls.Add(btnVistaGeneralEnvios);
            groupBox5.Controls.Add(groupBox1);
            groupBox5.Controls.Add(groupBox4);
            groupBox5.Controls.Add(groupBox2);
            groupBox5.Controls.Add(groupBox3);
            groupBox5.Controls.Add(dtgvTodosEnvios);
            groupBox5.Location = new Point(12, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(925, 454);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "Busqueda por Filtros";
            // 
            // btnVistaGeneralEnvios
            // 
            btnVistaGeneralEnvios.Location = new Point(596, 284);
            btnVistaGeneralEnvios.Margin = new Padding(3, 2, 3, 2);
            btnVistaGeneralEnvios.Name = "btnVistaGeneralEnvios";
            btnVistaGeneralEnvios.Size = new Size(313, 45);
            btnVistaGeneralEnvios.TabIndex = 18;
            btnVistaGeneralEnvios.Text = "Vista General de Envios";
            btnVistaGeneralEnvios.UseVisualStyleBackColor = true;
            btnVistaGeneralEnvios.Click += btnVistaGeneralEnvios_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPrioridadEnv);
            groupBox1.Controls.Add(btnBusquedaPrioridad);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(593, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 109);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda por prioridad";
            // 
            // cmbPrioridadEnv
            // 
            cmbPrioridadEnv.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrioridadEnv.FormattingEnabled = true;
            cmbPrioridadEnv.Location = new Point(88, 26);
            cmbPrioridadEnv.Name = "cmbPrioridadEnv";
            cmbPrioridadEnv.Size = new Size(159, 23);
            cmbPrioridadEnv.TabIndex = 3;
            cmbPrioridadEnv.SelectedIndexChanged += cmbPrioridadEnv_SelectedIndexChanged;
            // 
            // btnBusquedaPrioridad
            // 
            btnBusquedaPrioridad.Location = new Point(79, 54);
            btnBusquedaPrioridad.Name = "btnBusquedaPrioridad";
            btnBusquedaPrioridad.Size = new Size(119, 33);
            btnBusquedaPrioridad.TabIndex = 2;
            btnBusquedaPrioridad.Text = "Buscar";
            btnBusquedaPrioridad.UseVisualStyleBackColor = true;
            btnBusquedaPrioridad.Click += btnBusquedaPrioridad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 29);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Prioridad:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnBusquedaEstado);
            groupBox4.Controls.Add(cmbEstadoEnv);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(291, 24);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(285, 108);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Busqueda por estado";
            // 
            // btnBusquedaEstado
            // 
            btnBusquedaEstado.Location = new Point(77, 60);
            btnBusquedaEstado.Name = "btnBusquedaEstado";
            btnBusquedaEstado.Size = new Size(121, 32);
            btnBusquedaEstado.TabIndex = 2;
            btnBusquedaEstado.Text = "Buscar";
            btnBusquedaEstado.UseVisualStyleBackColor = true;
            btnBusquedaEstado.Click += btnBusquedaEstado_Click;
            // 
            // cmbEstadoEnv
            // 
            cmbEstadoEnv.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoEnv.FormattingEnabled = true;
            cmbEstadoEnv.Location = new Point(122, 25);
            cmbEstadoEnv.Name = "cmbEstadoEnv";
            cmbEstadoEnv.Size = new Size(146, 23);
            cmbEstadoEnv.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 27);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 0;
            label4.Text = "Estado:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbElimEnv);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(593, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 109);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar Envio";
            // 
            // cmbElimEnv
            // 
            cmbElimEnv.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbElimEnv.FormattingEnabled = true;
            cmbElimEnv.Location = new Point(88, 26);
            cmbElimEnv.Name = "cmbElimEnv";
            cmbElimEnv.Size = new Size(159, 23);
            cmbElimEnv.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(79, 58);
            button3.Name = "button3";
            button3.Size = new Size(119, 33);
            button3.TabIndex = 2;
            button3.Text = "Eliminar Envio";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 29);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 0;
            label3.Text = "ID Envio:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnBusquedaId);
            groupBox3.Controls.Add(cmbIdEnv);
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
            // cmbIdEnv
            // 
            cmbIdEnv.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdEnv.FormattingEnabled = true;
            cmbIdEnv.Location = new Point(88, 25);
            cmbIdEnv.Name = "cmbIdEnv";
            cmbIdEnv.Size = new Size(162, 23);
            cmbIdEnv.TabIndex = 1;
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
            // dtgvTodosEnvios
            // 
            dtgvTodosEnvios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTodosEnvios.Location = new Point(17, 147);
            dtgvTodosEnvios.Name = "dtgvTodosEnvios";
            dtgvTodosEnvios.RowHeadersWidth = 51;
            dtgvTodosEnvios.Size = new Size(559, 285);
            dtgvTodosEnvios.TabIndex = 3;
            // 
            // EnvioAdministracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1266, 459);
            Controls.Add(groupBox7);
            Controls.Add(groupBox5);
            Name = "EnvioAdministracion";
            Text = "EnvioAdministracion";
            Load += EnvioAdministracion_Load;
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTodosEnvios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox7;
        private ComboBox cmbEditPrioridad;
        private ComboBox cmbEditEstado;
        private ComboBox cmbEditEnv;
        private TextBox txtDireccion;
        private TextBox txtEnvioNombre;
        private Button button2;
        private Label label12;
        private Label label11;
        private Label label8;
        private Label label7;
        private Label label6;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private Button btnBusquedaEstado;
        private ComboBox cmbEstadoEnv;
        private Label label4;
        private GroupBox groupBox3;
        private Button btnBusquedaId;
        private ComboBox cmbIdEnv;
        private Label label2;
        private DataGridView dtgvTodosEnvios;
        private GroupBox groupBox2;
        private ComboBox cmbElimEnv;
        private Button button3;
        private Label label3;
        private GroupBox groupBox1;
        private ComboBox cmbPrioridadEnv;
        private Button btnBusquedaPrioridad;
        private Label label1;
        private Button btnVistaGeneralEnvios;
    }
}