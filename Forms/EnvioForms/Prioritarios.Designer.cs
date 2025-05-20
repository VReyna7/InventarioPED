namespace InventarioPED.Forms.EnvioForms
{
    partial class Prioritarios
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
            dtgvPrioritarios = new DataGridView();
            BtnMostar10 = new Button();
            BtnMostrar25 = new Button();
            btnVistGeneral = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvPrioritarios).BeginInit();
            SuspendLayout();
            // 
            // dtgvPrioritarios
            // 
            dtgvPrioritarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPrioritarios.Location = new Point(24, 21);
            dtgvPrioritarios.Name = "dtgvPrioritarios";
            dtgvPrioritarios.Size = new Size(505, 417);
            dtgvPrioritarios.TabIndex = 0;
            // 
            // BtnMostar10
            // 
            BtnMostar10.Location = new Point(602, 52);
            BtnMostar10.Name = "BtnMostar10";
            BtnMostar10.Size = new Size(100, 40);
            BtnMostar10.TabIndex = 1;
            BtnMostar10.Text = "Mostar 10";
            BtnMostar10.UseVisualStyleBackColor = true;
            BtnMostar10.Click += BtnMostar10_Click;
            // 
            // BtnMostrar25
            // 
            BtnMostrar25.Location = new Point(602, 135);
            BtnMostrar25.Name = "BtnMostrar25";
            BtnMostrar25.Size = new Size(100, 40);
            BtnMostrar25.TabIndex = 2;
            BtnMostrar25.Text = "Mostar 25";
            BtnMostrar25.UseVisualStyleBackColor = true;
            BtnMostrar25.Click += BtnMostrar25_Click;
            // 
            // btnVistGeneral
            // 
            btnVistGeneral.Location = new Point(602, 215);
            btnVistGeneral.Name = "btnVistGeneral";
            btnVistGeneral.Size = new Size(100, 40);
            btnVistGeneral.TabIndex = 3;
            btnVistGeneral.Text = "Vista General";
            btnVistGeneral.UseVisualStyleBackColor = true;
            btnVistGeneral.Click += btnVistGeneral_Click;
            // 
            // Prioritarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVistGeneral);
            Controls.Add(BtnMostrar25);
            Controls.Add(BtnMostar10);
            Controls.Add(dtgvPrioritarios);
            Name = "Prioritarios";
            Text = "Prioritarios";
            ((System.ComponentModel.ISupportInitialize)dtgvPrioritarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvPrioritarios;
        private Button BtnMostar10;
        private Button BtnMostrar25;
        private Button btnVistGeneral;
    }
}