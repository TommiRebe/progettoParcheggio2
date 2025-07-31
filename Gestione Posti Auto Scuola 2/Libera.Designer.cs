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
            imgLibera = new PictureBox();
            cmbNumero = new ComboBox();
            btnLibera = new Button();
            ((System.ComponentModel.ISupportInitialize)imgLibera).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(47, 488);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(327, 59);
            btnHome.TabIndex = 13;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // lblPosti
            // 
            lblPosti.AutoSize = true;
            lblPosti.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosti.Location = new Point(47, 340);
            lblPosti.Name = "lblPosti";
            lblPosti.Size = new Size(85, 38);
            lblPosti.TabIndex = 12;
            lblPosti.Text = "Posto";
            // 
            // imgLibera
            // 
            imgLibera.Location = new Point(47, 31);
            imgLibera.Margin = new Padding(3, 4, 3, 4);
            imgLibera.Name = "imgLibera";
            imgLibera.Size = new Size(327, 204);
            imgLibera.TabIndex = 10;
            imgLibera.TabStop = false;
            // 
            // cmbNumero
            // 
            cmbNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbNumero.FormattingEnabled = true;
            cmbNumero.Location = new Point(139, 347);
            cmbNumero.Margin = new Padding(3, 4, 3, 4);
            cmbNumero.Name = "cmbNumero";
            cmbNumero.Size = new Size(234, 36);
            cmbNumero.TabIndex = 9;
            // 
            // btnLibera
            // 
            btnLibera.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLibera.Location = new Point(47, 421);
            btnLibera.Margin = new Padding(3, 4, 3, 4);
            btnLibera.Name = "btnLibera";
            btnLibera.Size = new Size(327, 59);
            btnLibera.TabIndex = 7;
            btnLibera.Text = "Libera";
            btnLibera.UseVisualStyleBackColor = true;
            btnLibera.Click += btnLibera_Click;
            // 
            // frmLibera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 589);
            Controls.Add(btnHome);
            Controls.Add(lblPosti);
            Controls.Add(imgLibera);
            Controls.Add(cmbNumero);
            Controls.Add(btnLibera);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLibera";
            Text = "Libera";
            Load += frmLibera_Load;
            ((System.ComponentModel.ISupportInitialize)imgLibera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private Label lblPosti;
        private PictureBox imgLibera;
        private ComboBox cmbNumero;
        private Button btnLibera;
    }
}