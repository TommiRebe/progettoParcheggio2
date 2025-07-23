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
                for(int i=0; i<4; i++)
                    for (int y = 0; y < 9; y++)
                    {
                        switch (i)
                        {
                            case 0:
                                post = $"A{y}";
                                break;
                            case 1:
                                post = $"B{y}";
                                break;
                            case 2:
                                post = $"C{y}";
                                break;
                            case 3:
                                post = $"D{y}";
                                break;
                            default:
                                break;
                        }
                        G.CercaUtente(G.namePosti, G.pathPosti, post);
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
