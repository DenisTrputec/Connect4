using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4.Klase
{
    public class Ploca
    {
        private int[,] polje = new int[7, 6];
        private int brojacPoteza;

        //Konstruktori
        #region
        public Ploca(int[,] polje, int brojacPoteza)
        {
            this.polje = polje;
            this.brojacPoteza = brojacPoteza;
        }

        public int[,] Polje
        {
            get { return polje; }
            set { polje = value; }
        }
        public int BrojacPoteza
        {
            get { return brojacPoteza; }
            set { brojacPoteza = value; }
        }
        #endregion


        public bool ProvjeraPobjede(int a, int stupac, int redak)
        {
            // funkcija prima koji se igrac provjerava (a), i lokaciju gdje se nalazi ubačeni žeton
            // a==1 za igrac/igrac1
            // a==2 za ai/igrac2

            //okomito
            if (redak > 2)
                if (polje[stupac, redak - 1] == a && polje[stupac, redak - 2] == a && polje[stupac, redak - 3] == a)
                {
                    return true;
                }

            //horizontalno
            int br = 0;
            for (int i = stupac - 3; i <= stupac + 3; i++)
            {
                if (i >= 0 && i <= 6 && i != stupac)
                {
                    if (polje[i, redak] == a)
                        br++;
                    else
                        br = 0;
                    if (br == 3)
                    {
                        return true;
                    }
                }
            }

            //dijagonalno prema gore
            br = 0;
            int j = redak - 3;    // Ne mogu se u for petlji inicijalizirati 2 varijable
            for (int i = stupac - 3; i <= stupac + 3; i++, j++)
            {
                if (i >= 0 && i <= 6 && i != stupac && j >= 0 && j <= 5)
                {
                    if (polje[i, j] == a)
                        br++;
                    else
                        br = 0;
                    if (br == 3)
                    {
                        return true;
                    }
                }
            }

            //dijagonalno prema dolje
            br = 0;
            j = redak + 3;
            for (int i = stupac - 3; i <= stupac + 3; i++, j--)
            {
                if (i >= 0 && i <= 6 && i != stupac && j >= 0 && j <= 5)
                {
                    if (polje[i, j] == a)
                        br++;
                    else
                        br = 0;
                    if (br == 3)
                    {
                        return true;
                    }
                }
            }

            return false; 
        }


        public bool ProvjeraNerjesenog()
        {
            if (brojacPoteza == 42)
                return true;
            return false;
        }

    }
}
