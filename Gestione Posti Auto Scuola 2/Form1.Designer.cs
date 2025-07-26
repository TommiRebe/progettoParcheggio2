namespace Gestione_Posti_Auto_Scuola_2
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitolo = new Label();
            rdbGrafico = new RadioButton();
            rdbOccupa = new RadioButton();
            rdbLibera = new RadioButton();
            btnEsegui = new Button();
            btnLogOut = new Button();
            tmrTempo = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTitolo
            // 
            lblTitolo.AutoSize = true;
            lblTitolo.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitolo.Location = new Point(132, 7);
            lblTitolo.Name = "lblTitolo";
            lblTitolo.Size = new Size(362, 50);
            lblTitolo.TabIndex = 0;
            lblTitolo.Text = "Gestione parcheggio";
            // 
            // rdbGrafico
            // 
            rdbGrafico.AutoSize = true;
            rdbGrafico.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbGrafico.Location = new Point(132, 81);
            rdbGrafico.Name = "rdbGrafico";
            rdbGrafico.Size = new Size(187, 29);
            rdbGrafico.TabIndex = 1;
            rdbGrafico.TabStop = true;
            rdbGrafico.Text = "Grafico occupanza";
            rdbGrafico.UseVisualStyleBackColor = true;
            // 
            // rdbOccupa
            // 
            rdbOccupa.AutoSize = true;
            rdbOccupa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbOccupa.Location = new Point(132, 123);
            rdbOccupa.Name = "rdbOccupa";
            rdbOccupa.Size = new Size(173, 29);
            rdbOccupa.TabIndex = 2;
            rdbOccupa.TabStop = true;
            rdbOccupa.Text = "Occupa un posto";
            rdbOccupa.UseVisualStyleBackColor = true;
            // 
            // rdbLibera
            // 
            rdbLibera.AutoSize = true;
            rdbLibera.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbLibera.Location = new Point(132, 166);
            rdbLibera.Name = "rdbLibera";
            rdbLibera.Size = new Size(161, 29);
            rdbLibera.TabIndex = 3;
            rdbLibera.TabStop = true;
            rdbLibera.Text = "Libera un posto";
            rdbLibera.UseVisualStyleBackColor = true;
            // 
            // btnEsegui
            // 
            btnEsegui.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEsegui.Location = new Point(132, 228);
            btnEsegui.Name = "btnEsegui";
            btnEsegui.Size = new Size(403, 42);
            btnEsegui.TabIndex = 4;
            btnEsegui.Text = "Esegui opzione";
            btnEsegui.UseVisualStyleBackColor = true;
            btnEsegui.Click += btnEsegui_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(132, 276);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(403, 42);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 362);
            Controls.Add(btnLogOut);
            Controls.Add(btnEsegui);
            Controls.Add(rdbLibera);
            Controls.Add(rdbOccupa);
            Controls.Add(rdbGrafico);
            Controls.Add(lblTitolo);
            Name = "frmMain";
            Text = "Gestione parcheggio";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitolo;
        private RadioButton rdbGrafico;
        private RadioButton rdbOccupa;
        private RadioButton rdbLibera;
        private Button btnEsegui;
        private Button btnLogOut;
        private System.Windows.Forms.Timer tmrTempo;
    }
}
