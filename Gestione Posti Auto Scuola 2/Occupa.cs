﻿using Lib;
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
     * un professore può occupare ma non paga, gli studenti pagano
     * non più di un posto a utente
     * Ogni persona ha un utente della scuola con user e password. 
     * I posti sono associati alle persone
     */
    public partial class frmOccupa : Form
    {
        public frmOccupa()
        {
            InitializeComponent();
        }

        private void frmOccupa_Load(object sender, EventArgs e)
        {
            foreach (string fila in G.File)
                cmbFila.Items.Add(fila);
            foreach (int numero in G.Numeri)
                cmbNumero.Items.Add(numero);

            imgOccupa.Image = Image.FromFile("C:\\Prova\\progettoParcheggio2\\Gestione Posti Auto Scuola 2\\Image\\fotoparcheggio.png");
            imgOccupa.SizeMode = PictureBoxSizeMode.Zoom;
            btnOccupa.BackColor = Color.FromArgb(0, 123, 255);
            btnOccupa.ForeColor = Color.White;
            btnHome.BackColor = Color.FromArgb(0, 123, 255);
            btnHome.ForeColor = Color.White;

        }

        private void btnOccupa_Click(object sender, EventArgs e)
        {
            string posto = cmbFila.Text + cmbNumero.Text;

            if (G.CercaUtenteList(G.record) >= 0 && G.CercaPosto(posto)==true)
            {
                G.utenti[G.CercaUtenteList(G.record)].POSTO = posto;
                MessageBox.Show("Posto Occupato!");
            }
            else if (!G.CercaPosto(posto))
                MessageBox.Show("Posto già Occupato!");

            if (G.CercaUtenteList(G.record) == -1)
                MessageBox.Show("errore nel login!");
            //Cosi apre la home 2 volte
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Cosi apre la home 2 volte
            //frmMain frmMain = new frmMain();
            //frmMain.Show();
            this.Close();
        }
    }
}
