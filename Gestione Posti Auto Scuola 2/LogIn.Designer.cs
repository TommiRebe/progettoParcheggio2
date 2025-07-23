namespace Gestione_Posti_Auto_Scuola_2
{
    partial class frmLogIn
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
            pct1 = new PictureBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            pctUser = new PictureBox();
            pctPass = new PictureBox();
            lblregistrati = new Label();
            btnRegistrati = new Button();
            ((System.ComponentModel.ISupportInitialize)pct1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPass).BeginInit();
            SuspendLayout();
            // 
            // pct1
            // 
            pct1.Location = new Point(131, 23);
            pct1.Margin = new Padding(3, 2, 3, 2);
            pct1.Name = "pct1";
            pct1.Size = new Size(273, 160);
            pct1.TabIndex = 0;
            pct1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(131, 224);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(311, 37);
            txtUser.TabIndex = 2;
            txtUser.Text = "Username";
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(131, 278);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(311, 37);
            txtPass.TabIndex = 3;
            txtPass.Text = "Password";
            txtPass.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(131, 350);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(311, 44);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pctUser
            // 
            pctUser.Location = new Point(85, 224);
            pctUser.Margin = new Padding(3, 2, 3, 2);
            pctUser.Name = "pctUser";
            pctUser.Size = new Size(49, 36);
            pctUser.TabIndex = 5;
            pctUser.TabStop = false;
            // 
            // pctPass
            // 
            pctPass.Location = new Point(85, 278);
            pctPass.Margin = new Padding(3, 2, 3, 2);
            pctPass.Name = "pctPass";
            pctPass.Size = new Size(49, 36);
            pctPass.TabIndex = 6;
            pctPass.TabStop = false;
            // 
            // lblregistrati
            // 
            lblregistrati.AutoSize = true;
            lblregistrati.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblregistrati.Location = new Point(154, 396);
            lblregistrati.Name = "lblregistrati";
            lblregistrati.Size = new Size(52, 21);
            lblregistrati.TabIndex = 7;
            lblregistrati.Text = "label1";
            lblregistrati.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRegistrati
            // 
            btnRegistrati.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrati.Location = new Point(131, 451);
            btnRegistrati.Margin = new Padding(3, 2, 3, 2);
            btnRegistrati.Name = "btnRegistrati";
            btnRegistrati.Size = new Size(311, 41);
            btnRegistrati.TabIndex = 8;
            btnRegistrati.Text = "Registrati";
            btnRegistrati.UseVisualStyleBackColor = true;
            btnRegistrati.Click += btnRegistrati_Click;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 503);
            Controls.Add(btnRegistrati);
            Controls.Add(lblregistrati);
            Controls.Add(pctPass);
            Controls.Add(pctUser);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(pct1);
            Name = "frmLogIn";
            Text = "Log In";
            Load += frmLogIn_Load;
            ((System.ComponentModel.ISupportInitialize)pct1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pct1;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private PictureBox pctUser;
        private PictureBox pctPass;
        private Label lblregistrati;
        private Button btnRegistrati;
    }
}