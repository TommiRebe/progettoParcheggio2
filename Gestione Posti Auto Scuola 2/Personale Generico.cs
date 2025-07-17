namespace Gestione_Posti_Auto_Scuola_2
{
    abstract class PersonaleGenerico
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

        public PersonaleGenerico() { nome = ""; cognome = ""; }
        public PersonaleGenerico(string nm, string cg)
        {
            nome = nm;
            cognome = cg;
        }
        ~PersonaleGenerico() {; }
    }
}
