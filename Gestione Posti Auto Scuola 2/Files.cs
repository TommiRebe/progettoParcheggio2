using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Lib
{
    // By 3G - V 0.2 03/05/2024
    // Note: 
    // ****************************
    internal class Files
    {
        // ======================== METODI DI LIVELLO 0 ============================

        // Metodo per aggiungere un record al file
        // Il percorso del file e del suo nome sono specificati come parametri
        public static void InserisciRecord(string p, string n, string r) // r = record
        {
            bool append = true; // con appned = true, il file aggiunge o "accoda" quello che scrivo
                                // con append = false, il file viene eliminato 
            StreamWriter swr = new StreamWriter(p + n, append); // per creare un file si usa StreamWriter

            swr.WriteLine(r); // scrivo record nel file
                              // aggiungo in coda il record al vecchio file
            swr.Close(); 

        }//Fine Metodo

        // Metodo che permette di creare un file
        // Il percorso del file e del suo nome sono specificati come parametri
        public static void CreaFile(string p, string n)
        {
            bool append = false; // con appned = true, il file aggiunge o "accoda" quello che scrivo
                                // con append = false, il file viene eliminato 
            StreamWriter swr = new StreamWriter(p + n, append); // per creare un file si usa StreamWriter

            swr.Close(); // chiudo il file

        }// Fine Main

        // Metodo che visualizza tutto il contenuto del file
        // Il percorso del file e del suo nome sono specificati come parametri
        public static void VisualizzaFile(string p, string n)
        {
            StreamReader srd = new StreamReader(p + n);

            string record = "";

            while (!srd.EndOfStream)
            {
                record = srd.ReadLine(); // leggo 1 riga (record) alla volta 
                Console.WriteLine(record);
            }

            srd.Close();

        }// Fine Metodo

        //Metodo che restituisce il numero di record presenti in un file 
        // Il percorso del file e del suo nome sono specificati come parametri
        public static int NumeroRecord(string p, string n)
        {
            StreamReader srd = new StreamReader(p + n);

            int nr = 0;
            string record = "";

            while (!srd.EndOfStream) // fintanto che non finisce il file
            {
                record = srd.ReadLine();
                nr++; // ogni volta che leggo lo incremento 
            }

            srd.Close();

            return nr;

        }// Fine Metodo

        

    }
}
