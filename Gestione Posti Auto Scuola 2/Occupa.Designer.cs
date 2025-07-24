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
            ((System.ComponentModel.ISupportInitialize)imgOccupa).BeginInit();
            SuspendLayout();
            // 
            // btnOccupa
            // 
            btnOccupa.Location = new Point(50, 305);
            btnOccupa.Name = "btnOccupa";
            btnOccupa.Size = new Size(286, 44);
            btnOccupa.TabIndex = 0;
            btnOccupa.Text = "Occupa";
            btnOccupa.UseVisualStyleBackColor = true;
            btnOccupa.Click += btnOccupa_Click;
            // 
            // cmbFila
            // 
            cmbFila.FormattingEnabled = true;
            cmbFila.Location = new Point(131, 202);
            cmbFila.Name = "cmbFila";
            cmbFila.Size = new Size(205, 23);
            cmbFila.TabIndex = 1;
            // 
            // cmbNumero
            // 
            cmbNumero.FormattingEnabled = true;
            cmbNumero.Location = new Point(131, 249);
            cmbNumero.Name = "cmbNumero";
            cmbNumero.Size = new Size(205, 23);
            cmbNumero.TabIndex = 2;
            // 
            // imgOccupa
            // 
            imgOccupa.Location = new Point(50, 12);
            imgOccupa.Name = "imgOccupa";
            imgOccupa.Size = new Size(286, 153);
            imgOccupa.TabIndex = 3;
            imgOccupa.TabStop = false;
            // 
            // lblFila
            // 
            lblFila.AutoSize = true;
            lblFila.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFila.Location = new Point(50, 202);
            lblFila.Name = "lblFila";
            lblFila.Size = new Size(41, 25);
            lblFila.TabIndex = 4;
            lblFila.Text = "Fila";
            // 
            // lblPosti
            // 
            lblPosti.AutoSize = true;
            lblPosti.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosti.Location = new Point(50, 244);
            lblPosti.Name = "lblPosti";
            lblPosti.Size = new Size(58, 25);
            lblPosti.TabIndex = 5;
            lblPosti.Text = "Posto";
            // 
            // frmOccupa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(lblPosti);
            Controls.Add(lblFila);
            Controls.Add(imgOccupa);
            Controls.Add(cmbNumero);
            Controls.Add(cmbFila);
            Controls.Add(btnOccupa);
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
    }
}