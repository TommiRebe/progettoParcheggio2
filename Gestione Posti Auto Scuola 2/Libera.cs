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
     * libera un posto
     */
    public partial class frmLibera : Form
    {
        public frmLibera()
        {
            InitializeComponent();
        }

        private void frmLibera_Load(object sender, EventArgs e)
        {
            

            cmbNumero.Items.Add(G.utenti[G.CercaUtenteList(G.record)].POSTO);

            //imgOccupa.Image = Image.FromFile("C:\\Prova\\progettoParcheggio2\\Gestione Posti Auto Scuola 2\\Image\\fotoparcheggio.png");
            imgOccupa.SizeMode = PictureBoxSizeMode.Zoom;
            btnLibera.BackColor = Color.FromArgb(0, 123, 255);
            btnLibera.ForeColor = Color.White;
            btnHome.BackColor = Color.FromArgb(0, 123, 255);
            btnHome.ForeColor = Color.White;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void btnLibera_Click(object sender, EventArgs e)
        {
            string posto = cmbNumero.Text;

            if (G.CercaUtenteList(G.record) >= 0 && G.CercaPosto(posto) == false)
            {
                G.utenti[G.CercaUtenteList(G.record)].POSTO = "";
                MessageBox.Show("Posto Liberato!");
            }
            else if (!G.CercaPosto(posto))
                MessageBox.Show("Posto già Liberato!");

            if (G.CercaUtenteList(G.record) == -1)
                MessageBox.Show("errore nel login!");

            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
