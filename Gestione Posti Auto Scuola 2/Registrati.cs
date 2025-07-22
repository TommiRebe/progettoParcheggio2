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
    public partial class Registrati : Form
    {
        public Registrati()
        {
            InitializeComponent();
        }

        private void Registrati_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            pct1.Image = Image.FromFile("C:\\Prova\\progettoParcheggio2\\Gestione Posti Auto Scuola 2\\Image\\fotologin.png");
            pct1.SizeMode = PictureBoxSizeMode.Zoom;
            pctUser.Image = Image.FromFile("C:\\Prova\\progettoParcheggio2\\Gestione Posti Auto Scuola 2\\Image\\user.png");
            pctUser.SizeMode = PictureBoxSizeMode.Zoom;
            pctPass.Image = Image.FromFile("C:\\Prova\\progettoParcheggio2\\Gestione Posti Auto Scuola 2\\Image\\pass.png");
            pctPass.SizeMode = PictureBoxSizeMode.Zoom;
            txtUser.BorderStyle = BorderStyle.None;
            btnRegistrati.BackColor = Color.FromArgb(0, 123, 255);
            btnRegistrati.ForeColor = Color.White;
            btnRitorna.BackColor = Color.FromArgb(0, 123, 255);
            btnRitorna.ForeColor = Color.White;
            txtUser.ForeColor = ColorTranslator.FromHtml("#1E90FF");
            txtUser.BackColor = ColorTranslator.FromHtml("#E6F2FF");
            txtPass.BackColor = ColorTranslator.FromHtml("#E6F2FF");
            txtPass.ForeColor = ColorTranslator.FromHtml("#1E90FF");
        }

        private void btnRitorna_Click(object sender, EventArgs e)
        {
            frmLogIn login = new frmLogIn();
            login.Show();
            this.Hide();
        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            G.AggiungiUtente(G.path, G.name, txtUser.Text + txtPass.Text +';');
            MessageBox.Show("Utente registrato correttamente!");
        }
    }
}
