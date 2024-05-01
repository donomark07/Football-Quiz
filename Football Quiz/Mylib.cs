using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Quiz
{
    public struct giocatori
    {
        public string giocatore;
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
    }
}
