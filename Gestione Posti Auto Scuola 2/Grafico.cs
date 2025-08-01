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
            btnTornaHome.BackColor = Color.FromArgb(0, 123, 255);
            btnTornaHome.ForeColor = Color.White;
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

            foreach (Persona persona in G.utenti)
            {
                switch (persona.POSTO)
                {
                    case "A1":
                        btnPostoA1.BackColor = Color.Red;
                        break;
                    case "A2":
                        btnPostoA2.BackColor = Color.Red;
                        break;
                    case "A3":
                        btnPostoA3.BackColor = Color.Red;
                        break;
                    case "A4":
                        btnPostoA4.BackColor = Color.Red;
                        break;
                    case "A5":
                        btnPostoA5.BackColor = Color.Red;
                        break;
                    case "B1":
                        btnPostoB1.BackColor = Color.Red;
                        break;
                    case "B2":
                        btnPostoB2.BackColor = Color.Red;
                        break;
                    case "B3":
                        btnPostoB3.BackColor = Color.Red;
                        break;
                    case "B4":
                        btnPostoB4.BackColor = Color.Red;
                        break;
                    case "B5":
                        btnPostoB5.BackColor = Color.Red;
                        break;
                    case "C1":
                        btnPostoC1.BackColor = Color.Red;
                        break;
                    case "C2":
                        btnPostoC2.BackColor = Color.Red;
                        break;
                    case "C3":
                        btnPostoC3.BackColor = Color.Red;
                        break;
                    case "C4":
                        btnPostoC4.BackColor = Color.Red;
                        break;
                    case "C5":
                        btnPostoC5.BackColor = Color.Red;
                        break;
                    case "D1":
                        btnPostoD1.BackColor = Color.Red;
                        break;
                    case "D2":
                        btnPostoD2.BackColor = Color.Red;
                        break;
                    case "D3":
                        btnPostoD3.BackColor = Color.Red;
                        break;
                    case "D4":
                        btnPostoD4.BackColor = Color.Red;
                        break;
                    case "D5":
                        btnPostoD5.BackColor = Color.Red;
                        break;
                    default:

                        break;

                }
            }
            //Nel caso è stato liberato un posto
            switch (G.postoliberato)
            {
                case "A1":
                    btnPostoA1.BackColor = Color.Green;
                    break;
                case "A2":
                    btnPostoA2.BackColor = Color.Green;
                    break;
                case "A3":
                    btnPostoA3.BackColor = Color.Green;
                    break;
                case "A4":
                    btnPostoA4.BackColor = Color.Green;
                    break;
                case "A5":
                    btnPostoA5.BackColor = Color.Green;
                    break;
                case "B1":
                    btnPostoB1.BackColor = Color.Green;
                    break;
                case "B2":
                    btnPostoB2.BackColor = Color.Green;
                    break;
                case "B3":
                    btnPostoB3.BackColor = Color.Green;
                    break;
                case "B4":
                    btnPostoB4.BackColor = Color.Green;
                    break;
                case "B5":
                    btnPostoB5.BackColor = Color.Green;
                    break;
                case "C1":
                    btnPostoC1.BackColor = Color.Green;
                    break;
                case "C2":
                    btnPostoC2.BackColor = Color.Green;
                    break;
                case "C3":
                    btnPostoC3.BackColor = Color.Green;
                    break;
                case "C4":
                    btnPostoC4.BackColor = Color.Green;
                    break;
                case "C5":
                    btnPostoC5.BackColor = Color.Green;
                    break;
                case "D1":
                    btnPostoD1.BackColor = Color.Green;
                    break;
                case "D2":
                    btnPostoD2.BackColor = Color.Green;
                    break;
                case "D3":
                    btnPostoD3.BackColor = Color.Green;
                    break;
                case "D4":
                    btnPostoD4.BackColor = Color.Green;
                    break;
                case "D5":
                    btnPostoD5.BackColor = Color.Green;
                    break;
                default:

                    break;
            }

        }

        private void btnTornaHome_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void btnPostoA1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPostoD1_Click(object sender, EventArgs e)
        {

        }
    }
}
