/*
 * ho finito questo form. Però non mi piace 
 * il layaut. se vuoi pensaci tu. 
 * Poi inizia a fare i file: ci aggiungi i record e 
 * copia le librerie che abbiamo fatto in 3
 * 
 */

using Microsoft.VisualBasic.Logging;

namespace Gestione_Posti_Auto_Scuola_2
{
    public partial class frmMain : Form
    {
        const string TIT = "Gestione parcheggio";


        public frmMain()
        {
            InitializeComponent();

            lblTitolo.Text = TIT;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            btnEsegui.BackColor = Color.FromArgb(0, 123, 255);
            btnEsegui.ForeColor = Color.White;
            btnLogOut.BackColor = Color.FromArgb(0, 123, 255);
            btnLogOut.ForeColor = Color.White;

            tmrTempo.Interval = 1000;
            tmrTempo.Start();
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            frmGrafico formG = new frmGrafico();
            frmLibera formL = new frmLibera();
            frmOccupa formO = new frmOccupa();
            frmScontrino formS = new frmScontrino();


            if (rdbGrafico.Checked)
                formG.Show();
            if (rdbLibera.Checked)
                formL.Show();
            if (rdbOccupa.Checked)
                formO.Show();
            if (rdbCalcolaTotale.Checked)
                formS.Show();
            if (rdbOccupa.Checked || rdbLibera.Checked || rdbGrafico.Checked || rdbCalcolaTotale.Checked)
                this.Close();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogIn formLog = new frmLogIn();
            formLog.Show();
            this.Close();
        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            G.temp++;
        }
    }
}
