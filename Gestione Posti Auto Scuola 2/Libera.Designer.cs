namespace Gestione_Posti_Auto_Scuola_2
{
    partial class frmLibera
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
            btnHome = new Button();
            lblPosti = new Label();
            imgOccupa = new PictureBox();
            cmbNumero = new ComboBox();
            btnLibera = new Button();
            ((System.ComponentModel.ISupportInitialize)imgOccupa).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(41, 366);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(286, 44);
            btnHome.TabIndex = 13;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // lblPosti
            // 
            lblPosti.AutoSize = true;
            lblPosti.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosti.Location = new Point(41, 255);
            lblPosti.Name = "lblPosti";
            lblPosti.Size = new Size(66, 30);
            lblPosti.TabIndex = 12;
            lblPosti.Text = "Posto";
            // 
            // imgOccupa
            // 
            imgOccupa.Location = new Point(41, 23);
            imgOccupa.Name = "imgOccupa";
            imgOccupa.Size = new Size(286, 153);
            imgOccupa.TabIndex = 10;
            imgOccupa.TabStop = false;
            // 
            // cmbNumero
            // 
            cmbNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbNumero.FormattingEnabled = true;
            cmbNumero.Location = new Point(122, 260);
            cmbNumero.Name = "cmbNumero";
            cmbNumero.Size = new Size(205, 29);
            cmbNumero.TabIndex = 9;
            // 
            // btnLibera
            // 
            btnLibera.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLibera.Location = new Point(41, 316);
            btnLibera.Name = "btnLibera";
            btnLibera.Size = new Size(286, 44);
            btnLibera.TabIndex = 7;
            btnLibera.Text = "Libera";
            btnLibera.UseVisualStyleBackColor = true;
            btnLibera.Click += btnLibera_Click;
            // 
            // frmLibera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 442);
            Controls.Add(btnHome);
            Controls.Add(lblPosti);
            Controls.Add(imgOccupa);
            Controls.Add(cmbNumero);
            Controls.Add(btnLibera);
            Name = "frmLibera";
            Text = "Libera";
            Load += frmLibera_Load;
            ((System.ComponentModel.ISupportInitialize)imgOccupa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private Label lblPosti;
        private PictureBox imgOccupa;
        private ComboBox cmbNumero;
        private Button btnLibera;
    }
}