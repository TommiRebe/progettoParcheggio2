namespace Gestione_Posti_Auto_Scuola_2
{
    class Persona
    {
        private string user;
        private string password;
        private string posto;
        private bool personale;
        private bool studente;


        public string USER
        {
            get { return user; }
            set { user = value; }
        }
        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }

        public string POSTO
        {
            get { return posto; }
            set { posto = value; }
        }

        public bool PERSONALE
        {
            get { return personale; }
            set { personale = value; }
        }
        public bool STUDENTE
        {
            get { return studente; }
            set { studente = value; }
        }

        public Persona() { user = ""; password = ""; posto = ""; personale = false; studente = false; }
        public Persona(string nm, string cg, string p, bool pe, bool s)
        {
            user = nm;
            password = cg;
            posto = p;
            personale = pe;
            studente = s;
        }
        ~Persona() {; }

        public double CostoParcheggio(int tempo)
        {
            if (personale == true)
                return 0.0;
            
            if(studente == true)
                return 1 + 0.5 * tempo;

            return 0.0;
        }
    }
}
