namespace Gestione_Posti_Auto_Scuola_2
{
    internal class PostoAuto
    {
        private int IdPostoAuto; //<100
        private int Tipo;
        private bool StatoDiOccupazione;//true-> libero, false->occupato
        private string? Occupante;
        /*private List<bool> SlotAssegnati;//true-> libero, false->occupato
        private int numeroslot;*/

        public int IDPOSTOAUTO
        {
            get { return IdPostoAuto; }
            set { IdPostoAuto = value; }
        }
        public int TIPO
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
        public bool STATODIOCCUPAZIONE
        {
            get { return StatoDiOccupazione; }
            set { StatoDiOccupazione = value; }

        }
        public string? OCCUPANTE
        {
            get { return OCCUPANTE; }
            set { OCCUPANTE = value; }
        }
        public bool[] SLOTASSEGNATI
        {
            get { return SLOTASSEGNATI; }
            set { SLOTASSEGNATI = value; }
        }

        public PostoAuto()
        {
            IdPostoAuto = 0; Tipo = 0; StatoDiOccupazione = false;
            Occupante = null; /*SlotAssegnati = new List<bool>();*/
        }
        public PostoAuto(int idpa, int tp, bool sdo, string? oc)
        {
            IdPostoAuto = idpa;
            Tipo = tp;
            StatoDiOccupazione = sdo;
            Occupante = oc;
        }
        ~PostoAuto() {;}
    }
}
