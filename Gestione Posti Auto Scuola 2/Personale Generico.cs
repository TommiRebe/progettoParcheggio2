namespace Gestione_Posti_Auto_Scuola_2
{
    abstract class Persona
    {
        protected string user;
        protected string password;

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

        public Persona() { user = ""; password = ""; }
        public Persona(string nm, string cg)
        {
            user = nm;
            password = cg;
        }
        ~Persona() {;}
    }
}
