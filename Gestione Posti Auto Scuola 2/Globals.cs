using Lib;
namespace Gestione_Posti_Auto_Scuola_2
{
    /*
     * Classe globale con dentro i metodi per la gestione file
     */
    class G
    {
        public static string path = @"./../../../../../";
        public static string name = "Credenziali.txt";
        public static bool filecreato = false;
        public static int id = 1;
        public static string record = "";
        public static string[] File = new string[] { "A", "B", "C", "D" };
        public static int[] Numeri = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static int costoFisso = 1;
        public static List<Persona> utenti = new List<Persona>();

        public static void CreaFile(string p, string n)
        {
            Files.CreaFile(p, n);
        }
        //r è la string con username e password, le username + password nel file sono separate tra loro con un ;
        public static void AggiungiUtente(string p, string n, string r)
        {
            Files.InserisciRecord(p, n, r);
        }

        public static bool CercaUtenteFile(string n, string p, string user, string pass)
        {
            string record = "";
            char sep = ' ';
            string[] records;

            using (StreamReader srd = new StreamReader(p + n))
            {
                while (!srd.EndOfStream)
                {
                    record = srd.ReadLine();
                    records = Str.Tokenizer(record, sep);

                    if (records != null)

                        if (records[0] == user && records[1] == pass)
                            return true;
                }
            }

            return false;
        }

        public static bool CercaPosto(string n, string p, string posto)
        {
            string record = "";
            char sep = ' ';
            string[] records;

            using (StreamReader srd = new StreamReader(p + n))
            {
                while (!srd.EndOfStream)
                {
                    record = srd.ReadLine();
                    records = Str.Tokenizer(record, sep);

                    if (records != null)
                        if (records[2] == posto)
                            return true;
                }
            }

            return false;
        }
    }
}
