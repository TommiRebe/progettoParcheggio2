using Lib;
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
        }

        private void btnOccupa_Click(object sender, EventArgs e)
        {
            StreamReader srd = new StreamReader(G.path + G.name);
            string[] records;
            string vecchio = "";
            string[] vecc;

            vecchio = G.record;
            vecc= Str.Tokenizer(G.record, ' ');

            while (!srd.EndOfStream)
            {
                records = Str.Tokenizer(srd.ReadLine(), ' ');

                if (records[0] == vecc[0] && records[1] == vecc[1])
                {
                    G.record = records[0] + records[1] + ' ' + cmbFila.SelectedItem + cmbNumero.SelectedItem;
                    Files.CancellaRecord(G.path, G.name, vecchio);
                    Files.InserisciRecord(G.path, G.name, G.record);

                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                    this.Hide();
                }
                
                
            }

            srd.Close();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
