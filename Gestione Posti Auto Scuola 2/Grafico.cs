using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;

namespace Gestione_Posti_Auto_Scuola_2
{
    /*
     * qua ci metti il grafico: verde per libero e rosso per occupato
     */
    public partial class frmGrafico : Form
    {
        public frmGrafico()
        {
            InitializeComponent();
        }

        private void frmGrafico_Load(object sender, EventArgs e)
        {
            btnPostoA1.BackColor = Color.Green;
            btnPostoA2.BackColor = Color.Green;
            btnPostoA3.BackColor = Color.Green;
            btnPostoA4.BackColor = Color.Green;
            btnPostoA5.BackColor = Color.Green;
            btnPostoB1.BackColor = Color.Green;
            btnPostoB2.BackColor = Color.Green;
            btnPostoB3.BackColor = Color.Green;
            btnPostoB4.BackColor = Color.Green;
            btnPostoB5.BackColor = Color.Green;
            btnPostoC1.BackColor = Color.Green;
            btnPostoC2.BackColor = Color.Green;
            btnPostoC3.BackColor = Color.Green;
            btnPostoC4.BackColor = Color.Green;
            btnPostoC5.BackColor = Color.Green;
            btnPostoD1.BackColor = Color.Green;
            btnPostoD2.BackColor = Color.Green;
            btnPostoD3.BackColor = Color.Green;
            btnPostoD4.BackColor = Color.Green;
            btnPostoD5.BackColor = Color.Green;

        }

        private void btnTornaHome_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void btnPostoA1_Paint(object sender, PaintEventArgs e)
        {
            btnPostoA1.BackColor = Color.Red;
        }
    }
}
