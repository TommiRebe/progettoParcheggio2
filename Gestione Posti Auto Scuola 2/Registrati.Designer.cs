﻿namespace Gestione_Posti_Auto_Scuola_2
{
    partial class Registrati
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
            btnRegistrati = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            pctPass = new PictureBox();
            pctUser = new PictureBox();
            pct1 = new PictureBox();
            btnRitorna = new Button();
            ((System.ComponentModel.ISupportInitialize)pctPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrati
            // 
            btnRegistrati.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrati.Location = new Point(203, 447);
            btnRegistrati.Name = "btnRegistrati";
            btnRegistrati.Size = new Size(359, 54);
            btnRegistrati.TabIndex = 7;
            btnRegistrati.Text = "Registrati";
            btnRegistrati.UseVisualStyleBackColor = true;
            btnRegistrati.Click += btnRegistrati_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(203, 364);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(358, 48);
            txtPass.TabIndex = 6;
            txtPass.Text = "Password";
            txtPass.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(203, 293);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(358, 48);
            txtUser.TabIndex = 5;
            txtUser.Text = "Username";
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // pctPass
            // 
            pctPass.Location = new Point(152, 364);
            pctPass.Name = "pctPass";
            pctPass.Size = new Size(56, 48);
            pctPass.TabIndex = 9;
            pctPass.TabStop = false;
            // 
            // pctUser
            // 
            pctUser.Location = new Point(152, 293);
            pctUser.Name = "pctUser";
            pctUser.Size = new Size(56, 48);
            pctUser.TabIndex = 8;
            pctUser.TabStop = false;
            // 
            // pct1
            // 
            pct1.Location = new Point(203, 43);
            pct1.Name = "pct1";
            pct1.Size = new Size(312, 213);
            pct1.TabIndex = 10;
            pct1.TabStop = false;
            // 
            // btnRitorna
            // 
            btnRitorna.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRitorna.Location = new Point(203, 540);
            btnRitorna.Name = "btnRitorna";
            btnRitorna.Size = new Size(359, 54);
            btnRitorna.TabIndex = 11;
            btnRitorna.Text = "Torna al login";
            btnRitorna.UseVisualStyleBackColor = true;
            btnRitorna.Click += btnRitorna_Click;
            // 
            // Registrati
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 667);
            Controls.Add(btnRitorna);
            Controls.Add(pct1);
            Controls.Add(pctPass);
            Controls.Add(pctUser);
            Controls.Add(btnRegistrati);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "Registrati";
            Text = "Registrati";
            Load += Registrati_Load;
            ((System.ComponentModel.ISupportInitialize)pctPass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrati;
        private TextBox txtPass;
        private TextBox txtUser;
        private PictureBox pctPass;
        private PictureBox pctUser;
        private PictureBox pct1;
        private Button btnRitorna;
    }
}