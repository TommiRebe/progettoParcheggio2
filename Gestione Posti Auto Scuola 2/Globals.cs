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
        public static string pathPosti = @"./../../../../../";
        public static string namePosti = "Posti.txt";
        public static bool filecreato = false;
        public static bool entraLog = false;
        public static int id = 1;
        public static string record = "";

        public static void CreaFile(string p, string n)
        {
            Files.CreaFile(p, n);
        }
        //r è la string con username e password, le username + password nel file sono separate tra loro con un ;
        public static void AggiungiUtente(string p, string n, string r)
        {
            Files.InserisciRecord(p, n, r);
        }

        public static bool CercaUtente(string n, string p, string r)
        {
            string record = "";
            char sep = ';';
            string[] records;

            using (StreamReader srd = new StreamReader(p + n))
            {
                while (!srd.EndOfStream)
                {
                    record = srd.ReadLine();
                    records = Str.Tokenizer(record, sep);

                    if (records != null)
                    {
                        for (int i = 0; i < records.Length; i++)
                        {
                            if (records[i] != null && records[i] == r)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }
    }
}
