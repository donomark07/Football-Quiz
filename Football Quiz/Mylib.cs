using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Quiz.funzioni
{
    public struct giocatori
    {
        public string giocatore;
        public int punteggio;
        
    }


    public partial class Mylib
    {

        
            
        


        public static int cercainserisci(giocatori[] ele, int n, string dato)
        {
            int x = 0;
            while (x < n)
            {
                if (ele[x].giocatore == dato)
                {
                    return x;

                }

                x++;
            }
            return -1;
        }

        public static int cancella(giocatori[] ele, ref int n, string dato)
        {
            int x = 0;
            int c = 0;
            while (x < n)
            {
                if (ele[x].giocatore == dato)
                {
                    ele[x] = ele[n - 1];
                    n = n - 1;
                    c = c + 1;
                    x = x - 1;
                }
                x++;
            }
            return c;
        }

        public static void salva(giocatori[] ele, int n)
        {
            StreamWriter mioFile;


            mioFile = new StreamWriter("giocatore.txt");
            int x = 0;
            while (x < n)
            {
                giocatori tmpGiocatore = ele[x];
                mioFile.WriteLine(tmpGiocatore.giocatore);
                mioFile.WriteLine(tmpGiocatore.punteggio);
                
                x++;
            }

            mioFile.Close();
        }

        public static void leggi(giocatori[] ele, ref int n)
        {
            StreamReader miofile;
            miofile = new StreamReader("giocatore.txt");
            while (n < 10000 && miofile.EndOfStream == false)
            {
                giocatori nuovoGiocatore = default;
                nuovoGiocatore.giocatore = miofile.ReadLine();
                nuovoGiocatore.punteggio = Convert.ToInt32(miofile.ReadLine());
               
                ele[n] = nuovoGiocatore;
                n++;
            }
            miofile.Close();

        }
    }

}
