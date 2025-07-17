namespace Gestione_Posti_Auto_Scuola_2
{
    abstract class Persona
    {
        protected string nome;
        protected string cognome;

        public string NOME
        {
            get { return nome; }
            set { nome = value; }
        }
        public string COGNOME
        {
            get { return cognome; }
            set { cognome = value; }
        }

        public Persona() { nome = ""; cognome = ""; }
        public Persona(string nm, string cg)
        {
            nome = nm;
            cognome = cg;
        }
        ~Persona() {;}
    }
}
