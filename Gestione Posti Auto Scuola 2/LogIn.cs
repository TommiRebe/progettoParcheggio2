﻿using Lib;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_Posti_Auto_Scuola_2
{
    /*
     * qua si esegue il log in e la terminazione del programma
     * con il login si lavora su un file.txt dove l'utente può registrarsi 
     * (con le credenziali, username e password)
     * ed effettuare l'accesso
     */
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            if(G.filecreato == false)
            {
                G.CreaFile(G.path, G.name);
                G.filecreato = true;
            }
            this.BackColor = Color.LightBlue;
            lblregistrati.Text = "Non hai ancora un account?\nRegistrati!";
            pct1.Image = Image.FromFile("C:\\Prova\\progettoParcheggio2\\Gestione Posti Auto Scuola 2\\Image\\fotologin.png");
            pct1.SizeMode = PictureBoxSizeMode.Zoom;
            pctUser.Image = Image.FromFile("C:\\Prova\\progettoParcheggio2\\Gestione Posti Auto Scuola 2\\Image\\user.png");
            pctUser.SizeMode = PictureBoxSizeMode.Zoom;
            pctPass.Image = Image.FromFile("C:\\Prova\\progettoParcheggio2\\Gestione Posti Auto Scuola 2\\Image\\pass.png");
            pctPass.SizeMode = PictureBoxSizeMode.Zoom;
            txtUser.BorderStyle = BorderStyle.None;
            btnLogin.BackColor = Color.FromArgb(0, 123, 255);
            btnLogin.ForeColor = Color.White;
            btnRegistrati.BackColor = Color.FromArgb(0, 123, 255);
            btnRegistrati.ForeColor = Color.White;
            btnTermina.BackColor = Color.FromArgb(0, 123, 255);
            btnTermina.ForeColor = Color.White;
            txtUser.ForeColor = ColorTranslator.FromHtml("#1E90FF");
            txtUser.BackColor = ColorTranslator.FromHtml("#E6F2FF");
            txtPass.BackColor = ColorTranslator.FromHtml("#E6F2FF");
            txtPass.ForeColor = ColorTranslator.FromHtml("#1E90FF");

            /*string s = "";
            string[] a;
            int i = 0;
            Persona p = new Persona();
            StreamReader srd = new StreamReader(G.path + G.name);

            
            while (!srd.EndOfStream)
            {
                s = srd.ReadLine();
                a = Str.Tokenizer(s, ' ');

                p.USER = a[0];
                p.PASSWORD = a[1];
                p.PERSONALE = Convert.ToBoolean(a[2]);
                p.STUDENTE = Convert.ToBoolean(a[3]);

                G.utenti.Add(p);

                i++;
            }

            srd.Close();
            */
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            G.record = txtUser.Text + ' ' + txtPass.Text;

            if (G.CercaUtenteFile(G.path, G.name, txtUser.Text, txtPass.Text) == true)
            {
                MessageBox.Show("Login effettuato con successo!");
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenziali errate!");
            }
        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            if (G.filecreato == false)
            {
                G.CreaFile(G.path, G.name);
                G.filecreato = true;

            }
            Registrati registrati = new Registrati();
            registrati.Show();
            this.Hide();
        }

        private void btnTermina_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
