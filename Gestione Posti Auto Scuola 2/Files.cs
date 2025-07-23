using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lib
{
    //*****************************************
    // libreria per la gestione dei file
    // by 3G - V0.3 9/05/2024
    // note:
    //*****************************************
    internal class Files
    {
        // ====================== metodi di livello 1 =======================

        // metodo che cancella un record di un file
        // specificando l'ID

        public static void CancellaRecord(string p, string n, string id)
        {
            const char SEP = ' ';
            const int ID = 0;
            bool append = false;
            StreamReader srd = new StreamReader(p + n);
            StreamWriter swr = new StreamWriter(p + "tmp.txt", append);
            string[] tk;
            string record = "";

            while (srd.EndOfStream == false) // fino che arriva alla fine del file
            {
                record = srd.ReadLine(); // legge una riga(record) del file
                tk = Str.Tokenizer(record, SEP);
                if (tk[ID] != id) // se non è l'id lo copio
                    swr.WriteLine(record); // copio la riga(record) che non è l'id
            }
            swr.Close();
            srd.Close();

            // copiare il file tmp con il nome del file originale
            Files.CopiaFile(p, "tmp.txt", p, n);
            // e poi eliminare il file tmp
            Files.CancellaFile(p, "tmp.txt");
        }

        // ====================== metodi di livello 0 ==================

        // metodo che crea una copia del file
        // il percorso del file e il suo nome sono specificati come parametri

        public static void CopiaFile(string p, string n, string pcpy, string ncpy)
        {
            bool append = false;
            StreamReader srd = new StreamReader(p + n);
            StreamWriter swr = new StreamWriter(pcpy + ncpy, append);

            string record = "";

            while (srd.EndOfStream == false) // fino che arriva alla fine del file
            {
                record = srd.ReadLine(); // legge una riga(record) del file
                swr.WriteLine(record); // copio la riga(record)
            }

            swr.Close();
            srd.Close();
        }

        // metodo che crea un backup del file
        // il percorso del file e il suo nome sono specificati come parametri

        public static void BackupFile(string p, string n, string pbk, string nbk)
        {
            bool append = false;// il file di buckup deve essere ricreato
            StreamReader srd = new StreamReader(p + n);
            StreamWriter swr = new StreamWriter(pbk + nbk, append);

            string record = "";

            while (srd.EndOfStream == false) // fino che arriva alla fine del file
            {
                record = srd.ReadLine(); // legge una riga(record) del file
                swr.WriteLine(record); // copio la riga(record)
            }

            swr.Close();
            srd.Close();
        }

        // metodo che cancella il contenuto di un file 
        // il percorso del file e il suo nome sono specificati come parametri
        public static void CancellaFile(string p, string n)
        {
            bool append = false; // con append = true aggiungo al file già esistente (in coda)
                                 // con append = false elimino il file già esistente
                                 // o lo creo nel caso non ci sia
            StreamWriter swr = new StreamWriter(p + n, append); // per creare un file si usa StremWriter

            swr.Close();
        }

        // metodo che aggiunge un record al file
        // il percorso del file e il suo nome sono specificati come parametri
        public static void InserisciRecord(string p, string n, string r)
        {
            bool append = true; // con append = true aggiungo al file già esistente (in coda)
                                 // con append = false elimino il file già esistente
                                 // o lo creo nel caso non ci sia
            StreamWriter swr = new StreamWriter(p + n, append); // per creare un file si usa StremWriter
            swr.WriteLine(r); // scrivo il record nel file
                              // aggiungo in coda al vecchio contenuto del file
                              // il nuovo record

            swr.Close();
        }

        //metodo che permette di creare un file
        // il percorso del file e il suo nome sono specificati come parametri
        public static void CreaFile(string p, string n)
        {
            bool append = false; // con append = true aggiungo al file già esistente (in coda)
                                // con append = false elimino il file già esistente
                                // o lo creo nel caso non ci sia
            StreamWriter swr = new StreamWriter(p + n, append); // per creare un file si usa StremWriter

            swr.Close();
        }

        // metodo che visualizza tutto il contenuto di un file
        // il percorso del file e il suo nome sono specificati come parametri
        public static void VisualizzaFile(string p, string n)
        {
            StreamReader srd = new StreamReader(p + n);

            string record = "";

            while (srd.EndOfStream == false) // fino che arriva alla fine del file
            {
                record = srd.ReadLine(); // legge una riga(record) del file
                Console.WriteLine(record); // stampo la riga(record)
            }

            srd.Close();
        }

        // metodo che restituisce il numero di record presenti in un file
        // il percorso del file e il suo nome sono specificati come parametri
        public static int NumeroRecord(string p, string n)
        {
            StreamReader srd = new StreamReader(p + n);

            int nr = 0;
            string record = "";

            // leggo tutto il file e lo memorizzo nella stringa
            while (!srd.EndOfStream)
            {
                record = srd.ReadLine(); // legge una riga(record) del file
                nr++;
            }

            return nr;
        }
    }
}
