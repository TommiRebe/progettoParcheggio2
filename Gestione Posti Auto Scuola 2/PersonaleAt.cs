namespace Gestione_Posti_Auto_Scuola_2
{
    class Personale : Persona
    {
        private int IDunivoco; //>=1000

        public int IDUNIVOCO
        {
            get { return IDunivoco; }
            set { IDunivoco = value; }
        }
        public Personale() : base()
        { 
            IDunivoco = 0; 
        }

        public Personale(string nm, string cg, int id) : base(nm, cg)
        { 
            IDunivoco = id; 
        }

        ~Personale() {;}
    }
}
