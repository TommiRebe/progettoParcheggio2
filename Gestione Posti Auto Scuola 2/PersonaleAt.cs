namespace Gestione_Posti_Auto_Scuola_2
{
    class PersonaleATA : PersonaleGenerico
    {
        private int IDunivoco; //>=1000

        public int IDUNIVOCO
        {
            get { return IDunivoco; }
            set { IDunivoco = value; }
        }
        public PersonaleATA() : base()
        { IDunivoco = 0; }

        public PersonaleATA(string nm, string cg, int id) : base(nm, cg)
        { IDunivoco = id; }

        ~PersonaleATA() {; }
    }
}
