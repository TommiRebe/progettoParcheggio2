namespace Gestione_Posti_Auto_Scuola_2
{
    partial class frmOccupa
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
            btnOccupa = new Button();
            cmbFila = new ComboBox();
            cmbNumero = new ComboBox();
            imgOccupa = new PictureBox();
            lblFila = new Label();
            lblPosti = new Label();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)imgOccupa).BeginInit();
            SuspendLayout();
            // 
            // btnOccupa
            // 
            btnOccupa.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOccupa.Location = new Point(57, 407);
            btnOccupa.Margin = new Padding(3, 4, 3, 4);
            btnOccupa.Name = "btnOccupa";
            btnOccupa.Size = new Size(327, 59);
            btnOccupa.TabIndex = 0;
            btnOccupa.Text = "Occupa";
            btnOccupa.UseVisualStyleBackColor = true;
            btnOccupa.Click += btnOccupa_Click;
            // 
            // cmbFila
            // 
            cmbFila.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFila.FormattingEnabled = true;
            cmbFila.Location = new Point(150, 269);
            cmbFila.Margin = new Padding(3, 4, 3, 4);
            cmbFila.Name = "cmbFila";
            cmbFila.Size = new Size(234, 36);
            cmbFila.TabIndex = 1;
            // 
            // cmbNumero
            // 
            cmbNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbNumero.FormattingEnabled = true;
            cmbNumero.Location = new Point(150, 332);
            cmbNumero.Margin = new Padding(3, 4, 3, 4);
            cmbNumero.Name = "cmbNumero";
            cmbNumero.Size = new Size(234, 36);
            cmbNumero.TabIndex = 2;
            // 
            // imgOccupa
            // 
            imgOccupa.Location = new Point(57, 16);
            imgOccupa.Margin = new Padding(3, 4, 3, 4);
            imgOccupa.Name = "imgOccupa";
            imgOccupa.Size = new Size(327, 204);
            imgOccupa.TabIndex = 3;
            imgOccupa.TabStop = false;
            // 
            // lblFila
            // 
            lblFila.AutoSize = true;
            lblFila.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFila.Location = new Point(57, 269);
            lblFila.Name = "lblFila";
            lblFila.Size = new Size(59, 38);
            lblFila.TabIndex = 4;
            lblFila.Text = "Fila";
            // 
            // lblPosti
            // 
            lblPosti.AutoSize = true;
            lblPosti.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosti.Location = new Point(57, 325);
            lblPosti.Name = "lblPosti";
            lblPosti.Size = new Size(85, 38);
            lblPosti.TabIndex = 5;
            lblPosti.Text = "Posto";
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(57, 473);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(327, 59);
            btnHome.TabIndex = 6;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // frmOccupa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 540);
            Controls.Add(btnHome);
            Controls.Add(lblPosti);
            Controls.Add(lblFila);
            Controls.Add(imgOccupa);
            Controls.Add(cmbNumero);
            Controls.Add(cmbFila);
            Controls.Add(btnOccupa);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOccupa";
            Text = "Occupa";
            Load += frmOccupa_Load;
            ((System.ComponentModel.ISupportInitialize)imgOccupa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOccupa;
        private ComboBox cmbFila;
        private ComboBox cmbNumero;
        private PictureBox imgOccupa;
        private Label lblFila;
        private Label lblPosti;
        private Button btnHome;
    }
}