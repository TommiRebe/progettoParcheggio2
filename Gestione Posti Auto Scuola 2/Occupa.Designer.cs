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
            SuspendLayout();
            // 
            // btnOccupa
            // 
            btnOccupa.Location = new Point(323, 133);
            btnOccupa.Margin = new Padding(3, 4, 3, 4);
            btnOccupa.Name = "btnOccupa";
            btnOccupa.Size = new Size(229, 31);
            btnOccupa.TabIndex = 0;
            btnOccupa.Text = "Occupa";
            btnOccupa.UseVisualStyleBackColor = true;
            btnOccupa.Click += btnOccupa_Click;
            // 
            // cmbFila
            // 
            cmbFila.FormattingEnabled = true;
            cmbFila.Location = new Point(704, 137);
            cmbFila.Margin = new Padding(3, 4, 3, 4);
            cmbFila.Name = "cmbFila";
            cmbFila.Size = new Size(138, 28);
            cmbFila.TabIndex = 1;
            // 
            // cmbNumero
            // 
            cmbNumero.FormattingEnabled = true;
            cmbNumero.Location = new Point(704, 176);
            cmbNumero.Margin = new Padding(3, 4, 3, 4);
            cmbNumero.Name = "cmbNumero";
            cmbNumero.Size = new Size(138, 28);
            cmbNumero.TabIndex = 2;
            // 
            // frmOccupa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cmbNumero);
            Controls.Add(cmbFila);
            Controls.Add(btnOccupa);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOccupa";
            Text = "Occupa";
            Load += frmOccupa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOccupa;
        private ComboBox cmbFila;
        private ComboBox cmbNumero;
    }
}