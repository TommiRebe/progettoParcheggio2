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
            string post = "";

            StreamReader srd = new StreamReader(G.path + G.name);

            while (!srd.EndOfStream)
            {
                for (int i = 0; i < 4; i++)
                    for (int y = 0; y < 5; y++)
                    {
                        switch (i)
                        {
                            case 0:
                                post = $"A{y}";
                                switch (y)
                                {
                                    case 0:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoA1.BackColor = Color.Green;
                                        else
                                            btnPostoA1.BackColor = Color.Red;
                                        break;
                                    case 1:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoA2.BackColor = Color.Green;
                                        else
                                            btnPostoA2.BackColor = Color.Red;
                                        break;
                                    case 2:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoA3.BackColor = Color.Green;
                                        else
                                            btnPostoA3.BackColor = Color.Red;
                                        break;
                                    case 3:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoA4.BackColor = Color.Green;
                                        else
                                            btnPostoA4.BackColor = Color.Red;
                                        break;
                                    case 4:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoA5.BackColor = Color.Green;
                                        else
                                            btnPostoA5.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 1:
                                post = $"B{y}";
                                switch (y)
                                {
                                    case 0:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoB1.BackColor = Color.Green;
                                        else
                                            btnPostoB1.BackColor = Color.Red;
                                        break;
                                    case 1:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoB2.BackColor = Color.Green;
                                        else
                                            btnPostoB2.BackColor = Color.Red;
                                        break;
                                    case 2:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoB3.BackColor = Color.Green;
                                        else
                                            btnPostoB3.BackColor = Color.Red;
                                        break;
                                    case 3:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoB4.BackColor = Color.Green;
                                        else
                                            btnPostoB4.BackColor = Color.Red;
                                        break;
                                    case 4:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoB5.BackColor = Color.Green;
                                        else
                                            btnPostoB5.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 2:
                                post = $"C{y}";
                                switch (y)
                                {
                                    case 0:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoC1.BackColor = Color.Green;
                                        else
                                            btnPostoC1.BackColor = Color.Red;
                                        break;
                                    case 1:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoC2.BackColor = Color.Green;
                                        else
                                            btnPostoC2.BackColor = Color.Red;
                                        break;
                                    case 2:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoC3.BackColor = Color.Green;
                                        else
                                            btnPostoC3.BackColor = Color.Red;
                                        break;
                                    case 3:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoC4.BackColor = Color.Green;
                                        else
                                            btnPostoC4.BackColor = Color.Red;
                                        break;
                                    case 4:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoC5.BackColor = Color.Green;
                                        else
                                            btnPostoC5.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case 3:
                                post = $"D{y}";
                                switch (y)
                                {
                                    case 0:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoD1.BackColor = Color.Green;
                                        else
                                            btnPostoD1.BackColor = Color.Red;
                                        break;
                                    case 1:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoD2.BackColor = Color.Green;
                                        else
                                            btnPostoD2.BackColor = Color.Red;
                                        break;
                                    case 2:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoD3.BackColor = Color.Green;
                                        else
                                            btnPostoD3.BackColor = Color.Red;
                                        break;
                                    case 3:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoD4.BackColor = Color.Green;
                                        else
                                            btnPostoD4.BackColor = Color.Red;
                                        break;
                                    case 4:
                                        if (G.CercaPosto(G.name, G.path, post) == true)
                                            btnPostoD5.BackColor = Color.Green;
                                        else
                                            btnPostoD5.BackColor = Color.Red;
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            default:
                                break;
                        }


                    }

            }
        }

        private void btnTornaHome_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
