﻿using System;
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

        }
    }
}
