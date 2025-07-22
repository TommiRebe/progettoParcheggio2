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
            btnRitorna = new Button();
            ((System.ComponentModel.ISupportInitialize)pct1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPass).BeginInit();
            SuspendLayout();
            // 
            // pct1
            // 
            pct1.Location = new Point(150, 31);
            pct1.Name = "pct1";
            pct1.Size = new Size(312, 214);
            pct1.TabIndex = 0;
            pct1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(150, 299);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(355, 48);
            txtUser.TabIndex = 2;
            txtUser.Text = "Username";
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(150, 370);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(355, 48);
            txtPass.TabIndex = 3;
            txtPass.Text = "Password";
            txtPass.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(150, 467);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(312, 48);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pctUser
            // 
            pctUser.Location = new Point(97, 299);
            pctUser.Name = "pctUser";
            pctUser.Size = new Size(56, 48);
            pctUser.TabIndex = 5;
            pctUser.TabStop = false;
            // 
            // pctPass
            // 
            pctPass.Location = new Point(97, 370);
            pctPass.Name = "pctPass";
            pctPass.Size = new Size(56, 48);
            pctPass.TabIndex = 6;
            pctPass.TabStop = false;
            // 
            // lblregistrati
            // 
            lblregistrati.AutoSize = true;
            lblregistrati.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblregistrati.Location = new Point(176, 528);
            lblregistrati.Name = "lblregistrati";
            lblregistrati.Size = new Size(65, 28);
            lblregistrati.TabIndex = 7;
            lblregistrati.Text = "label1";
            lblregistrati.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRegistrati
            // 
            btnRegistrati.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrati.Location = new Point(150, 601);
            btnRegistrati.Name = "btnRegistrati";
            btnRegistrati.Size = new Size(312, 48);
            btnRegistrati.TabIndex = 8;
            btnRegistrati.Text = "Registrati";
            btnRegistrati.UseVisualStyleBackColor = true;
            btnRegistrati.Click += btnRegistrati_Click;
            // 
            // btnRitorna
            // 
            btnRitorna.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRitorna.Location = new Point(150, 675);
            btnRitorna.Name = "btnRitorna";
            btnRitorna.Size = new Size(312, 48);
            btnRitorna.TabIndex = 9;
            btnRitorna.Text = "Home";
            btnRitorna.UseVisualStyleBackColor = true;
            btnRitorna.Click += btnRitorna_Click;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 747);
            Controls.Add(btnRitorna);
            Controls.Add(btnRegistrati);
            Controls.Add(lblregistrati);
            Controls.Add(pctPass);
            Controls.Add(pctUser);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(pct1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnRitorna;
    }
}