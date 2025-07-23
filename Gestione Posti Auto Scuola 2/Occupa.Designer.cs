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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // btnOccupa
            // 
            btnOccupa.Location = new Point(283, 100);
            btnOccupa.Name = "btnOccupa";
            btnOccupa.Size = new Size(200, 23);
            btnOccupa.TabIndex = 0;
            btnOccupa.Text = "Occupa";
            btnOccupa.UseVisualStyleBackColor = true;
            btnOccupa.Click += btnOccupa_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(616, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(616, 132);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 2;
            // 
            // frmOccupa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(btnOccupa);
            Name = "frmOccupa";
            Text = "Occupa";
            Load += frmOccupa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOccupa;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}