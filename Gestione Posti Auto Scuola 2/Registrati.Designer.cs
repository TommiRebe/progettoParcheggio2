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
            rdbPersonale = new RadioButton();
            rdbStudente = new RadioButton();
            lblRuolo = new Label();
            ((System.ComponentModel.ISupportInitialize)pctPass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrati
            // 
            btnRegistrati.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrati.Location = new Point(184, 410);
            btnRegistrati.Margin = new Padding(3, 2, 3, 2);
            btnRegistrati.Name = "btnRegistrati";
            btnRegistrati.Size = new Size(314, 40);
            btnRegistrati.TabIndex = 7;
            btnRegistrati.Text = "Registrati";
            btnRegistrati.UseVisualStyleBackColor = true;
            btnRegistrati.Click += btnRegistrati_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(178, 273);
            txtPass.Margin = new Padding(3, 2, 3, 2);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(314, 37);
            txtPass.TabIndex = 6;
            txtPass.Text = "Password";
            txtPass.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(178, 220);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(314, 37);
            txtUser.TabIndex = 5;
            txtUser.Text = "Username";
            txtUser.TextAlign = HorizontalAlignment.Center;
            // 
            // pctPass
            // 
            pctPass.Location = new Point(133, 273);
            pctPass.Margin = new Padding(3, 2, 3, 2);
            pctPass.Name = "pctPass";
            pctPass.Size = new Size(49, 36);
            pctPass.TabIndex = 9;
            pctPass.TabStop = false;
            // 
            // pctUser
            // 
            pctUser.Location = new Point(133, 220);
            pctUser.Margin = new Padding(3, 2, 3, 2);
            pctUser.Name = "pctUser";
            pctUser.Size = new Size(49, 36);
            pctUser.TabIndex = 8;
            pctUser.TabStop = false;
            // 
            // pct1
            // 
            pct1.Location = new Point(178, 32);
            pct1.Margin = new Padding(3, 2, 3, 2);
            pct1.Name = "pct1";
            pct1.Size = new Size(273, 160);
            pct1.TabIndex = 10;
            pct1.TabStop = false;
            // 
            // btnRitorna
            // 
            btnRitorna.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRitorna.Location = new Point(184, 471);
            btnRitorna.Margin = new Padding(3, 2, 3, 2);
            btnRitorna.Name = "btnRitorna";
            btnRitorna.Size = new Size(314, 40);
            btnRitorna.TabIndex = 11;
            btnRitorna.Text = "Torna al login";
            btnRitorna.UseVisualStyleBackColor = true;
            btnRitorna.Click += btnRitorna_Click;
            // 
            // rdbPersonale
            // 
            rdbPersonale.AutoSize = true;
            rdbPersonale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbPersonale.Location = new Point(362, 334);
            rdbPersonale.Name = "rdbPersonale";
            rdbPersonale.Size = new Size(95, 25);
            rdbPersonale.TabIndex = 12;
            rdbPersonale.TabStop = true;
            rdbPersonale.Text = "Personale";
            rdbPersonale.UseVisualStyleBackColor = true;
            // 
            // rdbStudente
            // 
            rdbStudente.AutoSize = true;
            rdbStudente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbStudente.Location = new Point(362, 365);
            rdbStudente.Name = "rdbStudente";
            rdbStudente.Size = new Size(89, 25);
            rdbStudente.TabIndex = 13;
            rdbStudente.TabStop = true;
            rdbStudente.Text = "Studente";
            rdbStudente.UseVisualStyleBackColor = true;
            // 
            // lblRuolo
            // 
            lblRuolo.AutoSize = true;
            lblRuolo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRuolo.Location = new Point(184, 343);
            lblRuolo.Name = "lblRuolo";
            lblRuolo.Size = new Size(155, 30);
            lblRuolo.TabIndex = 14;
            lblRuolo.Text = "Seleziona ruolo";
            // 
            // Registrati
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 573);
            Controls.Add(lblRuolo);
            Controls.Add(rdbStudente);
            Controls.Add(rdbPersonale);
            Controls.Add(btnRitorna);
            Controls.Add(pct1);
            Controls.Add(pctPass);
            Controls.Add(pctUser);
            Controls.Add(btnRegistrati);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Margin = new Padding(3, 2, 3, 2);
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
        private RadioButton rdbPersonale;
        private RadioButton rdbStudente;
        private Label lblRuolo;
    }
}