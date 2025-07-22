using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    internal class Str
    {
        // ************  Libreria per la gestione delle stringhe *********
        // ************  Versione 3G ufficiale 2024              *********
        // last revisor: Diego Grazioli
        // ***************************************************************
        // Versione 1.1 - data 10/04/2024
        // # metodi implementati : 12
        // ***************************************************************
        // 
        // **************** Metodi di livello 2 **********************
        // public static string EliminaSpaziCoda(string s)

        // **************** Metodi di livello 1 **********************
        // public static string EliminaSpaziTesta(string s)

        // **************** metodi di livello 0 **********************
        // public static string Sottostringa(string s, int start, int numcar)
        // public static bool SeNumerica(string s)
        // public static bool SeAlfabetica(string s)
        // public static string EliminaCaratteri(string stringa, string chars)
        // public static int ContaCaratteri(string stringa)
        // public static string EliminaCarattere(string stringa, char c)
        // public static string EliminaSpaziTesta(string stringa)
        // public static string EliminaSpaziCoda(string stringa)
        // public static string Inverti(string s)
        // public static string[] Tokenizer(string s, char sep)

        // **************** Metodi di livello 2 **********************
      
        // Metodo che toglie tutti gli spazi che si trovano
        // alla fine della stringa passata come parametro
        public static string EliminaSpaziCoda(string s)
        {
            // z = Inverti(s);
            // z = EliminaSpaziTesta(z)
            // z = Inverti(z);

            return Inverti(EliminaSpaziTesta(Inverti(s)));
        }


        // **************** Metodi di livello 1 **********************

        // Metodo che toglie tutti gli spazi che si trovano
        // all'inizio della stringa passata come parametro
        public static string EliminaSpaziTesta(string s)
        {
            int i = 0;

            for (i = 0; i < s.Length; i++)
                if (s[i] != ' ')
                    break;

            return Sottostringa(s, i, s.Length - i);
        }


        // **************** Metodi di livello 0 **********************

        // definiamo metodi di livello zero metodi che per funzionare non richiamano altri metodi della libreria
        // definiamo metodi di livello uno metodi che per funzionare richiamano almeno un metodo di livello zero della libreria
        // definiamo metodi di livello due metodi che per funzionare richiamano almeno un metodo di livello uno o zero della libreria

        // Metodo che estrae da una stringa passata come parametro un certo numero di caratteri a partire
        // da un carattere specificato come parametro da un indice di posizione
        // "ciao mamma" --2,3--> "ao "
        // "ciao mamma" --1,1--> "i"
        // "ciao mamma" -- 0,8 --> "ciao mam"
        //                                              \/ indice  primo carattere da estrarre
        //                                                          \/ numero di caratteri da estrarre
        public static string Sottostringa(string s, int start, int numcar)
        {
            string z = "";

            for (int i = start; i < start + numcar; i++)
            {
                z = z + s[i];
            }

            return z;
        }

        // Metodo che stabilisce se nella stringa passata come parametro
        // sono presenti solo cifre numeriche
        // Restiruisce true o false a seconda dei casi
        // "123" --> true   "1a3" --> false
        public static bool SeNumerica(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if ((s[i] < 48) || (s[i] > 57))
                    return false; // Carattere non numerico

            return true;
        }

        // Metodo che stabilisce se nella stringa passata come parametro
        // sono presenti solo caratteri alfabetici
        public static bool SeAlfabetica(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                // Se NON è un carattere dell'alfabeto maiuscolo o minuscolo
                if (!
                    (
                     ((s[i] >= 65) && (s[i] <= 90)) ||
                     ((s[i] >= 97) && (s[i] <= 122))
                    )
                   )
                {
                    return false;
                }
            }
            return true;
        }

        // Metodo che elimina dalla stringa specificata come parametro
        // tutti i caratteri contenuti nella stringa  chars
        public static string EliminaCaratteri(string s, string chars)
        {
            string z = "";
            bool trovato = false;

            for (int i = 0; i < s.Length; i++)
            {
                trovato = false;

                for (int j = 0; j < chars.Length; j++)
                {
                    if (s[i] == chars[j])
                    {
                        trovato = true;
                        break;
                    }
                }

                if (trovato == false)
                    z = z + s[i];
            }

            return z;
        }

        // Metodo per contare quanti caratteri ci sono in una  stringa
        // Equivale all'uso della proprietà Length di una stringa
        public static int ContaCaratteri(string s)
        {
            int cont = 0;

            for (int i = 0; i < s.Length; i++)
                cont++;

            return cont;
        }

        // Metodo che elimina da una stringa
        // il carattere specificato come secondo parametro
        public static string EliminaCarattere(string s, char c)
        {
            string z = "";

            for (int i = 0; i < s.Length; i++)
                if (s[i] != c)
                    z = z + s[i];

            return z;
        }

        // Metodo che restituisce la stringa specificata come parametro
        // ma privata dagli eventuali spazi
        // ES: "ci a o" --> "ciao"
        public static string EliminaSpazi(string s)
        {
            // + operatore di concatenazione tra stringhe unisce in un'unica stringa
            // le due stringhe specifiche come operandi

            string z = "";

            for (int i = 0; i < s.Length; i++)
                if (s[i] != ' ')
                    z = z + s[i];

            return z;
        }

       

        // Metodo che inverte gli elementi della stringa specificata come argomento
        public static string Inverti(string s)
        {
            string z = "";

            for (int i = 0; i < s.Length; i++)
                z = s[i] + z;

            return z;
        }



        // Metodo che restituisce un array di stringhe
        // a partire da una stringa passata come parametro
        // tenendo conto di un separatore passato come parametro
        // ------|token|
        // s --> "12:00 13:00 14:00"
        // tk --> "12:00" "13:00" "14:00"
        // in una stringa che ha N singoli separatori ha N+1 token "ntoken = numsep + 1"
        public static string[] Tokenizer(string s, char sep)
        {
            string[] tk;
            int numsep = 0;
            int ntoken = 0;
            int indtk = 0;

            // trovare quanti token ci sono nella stringa
            // conto il numero di separatori
            for (int i = 0; i < s.Length; i++)
                if (s[i] == sep)
                    numsep++;

            ntoken = numsep + 1;

            // dimensionare opportunamente l'aray di token (tk)

            tk = new string[ntoken];

            // ricavare i singoli token memorizzandoli in tk
            // tk[0] --> 12:00
            // tk[1] --> 13:00
            // tk[2] --> 14:00
            for (int i = 0; i < s.Length; i++)
                if (s[i] != sep)
                    tk[indtk] = tk[indtk] + s[i];
                else
                    indtk++;

            return tk;
        }
    }
}
