using System;
using System.Drawing;

namespace Connect4.Klase
{
    public class AI
    {
        private string ime;
        private short razina;
        private Color boja;

        //Konstruktori
        #region
        public AI(short razina, Color boja)
        {
            this.razina = razina;
            this.boja = boja;

            if (razina == 1)
                ime = "Lako";
            else if (razina == 2)
                ime = "Srednje";
            else if (razina == 3)
                ime = "Teško";
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public short Razina
        {
            get { return razina; }
            set { razina = value; }
        }

        public Color Boja
        {
            get { return boja; }
            set { boja = value; }
        }
        #endregion

        public int RazinaLako(Ploca ploca)
        {
            int stupac = OsnovniPotezi(ploca);
            if (stupac != -1)
                return stupac;

            return RandomUbaci(ploca);
        }

        public int RazinaSrednje(Ploca ploca)
        {
            int stupac = OsnovniPotezi(ploca);
            if (stupac != -1)
                return stupac;

            stupac = SprijeciDvostrukiNapad_Vodoravno(ploca);
            if (stupac != -1)
                return stupac;
            
            stupac = PametnijeRandomUbaci(ploca);
            if (stupac != -1)
                return stupac; 

            return RandomUbaci(ploca);
        }

        public int RazinaTesko(Ploca ploca)
        {
            if (ploca.BrojacPoteza == 1) //ako je prvi na redu, baci u sredinu
                return 3;

            int stupac = OsnovniPotezi(ploca);
            if (stupac != -1)
                return stupac;

            stupac = StvoriSedmicu(ploca);
            if (stupac != -1)
                return stupac;

            stupac = NapadniSedmicom(ploca);
            if (stupac != -1)
                return stupac;

            stupac = SprijeciDvostrukiNapad_Vodoravno(ploca);
            if (stupac != -1)
                return stupac;

            stupac = SprijeciDvostrukiNapad_Dijagonalno(ploca);
            if (stupac != -1)
                return stupac;

            stupac = UbaciUSredinu(ploca);
            if (stupac != -1)
                return stupac;

            stupac = PametnijeRandomUbaci(ploca);
            if (stupac != -1)
                return stupac;         

            return RandomUbaci(ploca);
        }


        private int VratiRedak(int[,] polje, int stupac)  //Funkcija vraća redni broj prvog slobodnog retka u stupcu, ako nema mjesta vraća -1
        {
            for (int redak = 0; redak < 6; redak++)
                if (polje[stupac, redak] == 0)
                    return redak;
            return -1;
        }

        private int VratiStupac(Random rand)  //Vraća random stupac
        {
            int stupac = -1;
            int a = rand.Next(0, 22); //u a se nalazi broj u intervalu [0,21]

            if (a > 6 && a < 15) stupac = 3;  // 8/22
            else if (a > 2 && a < 7) stupac = 2;  // 4/22
            else if (a > 14 && a < 19) stupac = 4;  
            else if (a > 0 && a < 3) stupac = 1;   // 2/22
            else if (a > 18 && a < 21) stupac = 5;  
            else if (a == 0) stupac = 0;   // 1/22
            else if (a == 21) stupac = 6;   

            return stupac;
        }  


        private int OsnovniPotezi(Ploca ploca)
        {
            for (int stupac = 0; stupac <= 6; stupac++)
            {
                int redak = VratiRedak(ploca.Polje, stupac);
                if (redak != -1)
                {
                    if (ploca.ProvjeraPobjede(2, stupac, redak)) //Pobjednički potez
                        return stupac;
                    else if (ploca.ProvjeraPobjede(1, stupac, redak)) //Sprječavanje pobjede
                        return stupac;
                }
            }
            return -1;
        }

        private int RandomUbaci(Ploca ploca)
        {
            Random rand = new Random();
            while (true)
            {
                int stupac = VratiStupac(rand);
                if (ploca.Polje[stupac, 5] == 0)  //ako ima mjesta u stupcu
                    return stupac;
            }
        }


        private int PametnijeRandomUbaci(Ploca ploca)
        {
            Random rand = new Random();
            int pokusaj = 0;

            while (pokusaj < 30)
            {
                int stupac = VratiStupac(rand);
                int redak = VratiRedak(ploca.Polje, stupac);
                if (redak != -1)
                {
                    if (redak > 4 || ploca.ProvjeraPobjede(1, stupac, redak + 1) == false)
                        return stupac;
                    else
                        pokusaj++;
                }
            }
            return -1;
        }

        private int SprijeciDvostrukiNapad_Vodoravno(Ploca ploca)
        {
            #region
            /*
                    kombinacija 1: _ _ X X _ - -

                    kombinacija 2: - _ _ X X _ - 
                    
                    kombinacija 3: - - _ _ X X _ 
                    
                    kombinacija 4: _ X _ X _ - -
                    
                    kombinacija 5: - _ X _ X _ - 
                    
                    kombinacija 6: - - _ X _X  _ 

                    kombinacija 7: _ X X _ _ - -
                    
                    kombinacija 8: - _ X X _ _ - 
                    
                    kombinacija 9: - - _ X X _ _ 
                   
            */
            #endregion
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    // Uspoređuje sa 1 jer je vrijednost Ai žetona uvijek 2
                    // kombinacije 1-3
                    if (ploca.Polje[i, j] == 0 && ploca.Polje[i + 1, j] == 0 && ploca.Polje[i + 2, j] == 1 && ploca.Polje[i + 3, j] == 1 && ploca.Polje[i + 4, j] == 0)
                    {
                        if ((j == 0) || (j > 0 && ploca.Polje[i, j - 1] != 0 && ploca.Polje[i + 1, j - 1] != 0 && ploca.Polje[i + 4, j - 1] != 0))
                            return i + 1;
                    }

                    // kombinacije 4-6
                    if (ploca.Polje[i, j] == 0 && ploca.Polje[i + 1, j] == 1 && ploca.Polje[i + 2, j] == 0 && ploca.Polje[i + 3, j] == 1 && ploca.Polje[i + 4, j] == 0)
                    {
                        if ((j == 0) || (j > 0 && ploca.Polje[i, j - 1] != 0 && ploca.Polje[i + 2, j - 1] != 0 && ploca.Polje[i + 4, j - 1] != 0))
                            return i + 2;
                    }

                    // kombinacije 7-9
                    if (ploca.Polje[i, j] == 0 && ploca.Polje[i + 1, j] == 1 && ploca.Polje[i + 2, j] == 1 && ploca.Polje[i + 3, j] == 0 && ploca.Polje[i + 4, j] == 0)
                    {
                        if ((j == 0) || (j > 0 && ploca.Polje[i, j - 1] != 0 && ploca.Polje[i + 3, j - 1] != 0 && ploca.Polje[i + 4, j - 1] != 0))
                            return i + 3;
                    }
                }
            }
            return -1;
        }


        private int SprijeciDvostrukiNapad_Dijagonalno(Ploca ploca)
        {
            for (int j = 0; j <= 1; j++)  //Prema gore
                for (int i = 0; i <= 2; i++)
                {
                    if (ploca.Polje[i, j] == 0 && ploca.Polje[i + 1, j + 1] == 0 && ploca.Polje[i + 2, j + 2] == 1 && ploca.Polje[i + 3, j + 3] == 1 && ploca.Polje[i + 4, j + 4] == 0)
                    {
                        if (j == 0 && ploca.Polje[i + 1, j] != 0 && ploca.Polje[i + 4, j + 3] != 0)
                            return i + 1;
                        else if (j > 0 && ploca.Polje[i, j - 1] != 0 && ploca.Polje[i + 1, j] != 0 && ploca.Polje[i + 4, j + 3] != 0)
                            return i + 1;
                    }
                    if (ploca.Polje[i, j] == 0 && ploca.Polje[i + 1, j + 1] == 1 && ploca.Polje[i + 2, j + 2] == 0 && ploca.Polje[i + 3, j + 3] == 1 && ploca.Polje[i + 4, j + 4] == 0)
                    {
                        if (j == 0 && ploca.Polje[i + 2, j + 1] != 0 && ploca.Polje[i + 4, j + 3] != 0)
                            return i + 2;
                        else if (j > 0 && ploca.Polje[i, j - 1] != 0 && ploca.Polje[i + 2, j + 1] != 0 && ploca.Polje[i + 4, j + 3] != 0)
                            return i + 2;
                    }
                    if (ploca.Polje[i, j] == 0 && ploca.Polje[i + 1, j + 1] == 1 && ploca.Polje[i + 2, j + 2] == 1 && ploca.Polje[i + 3, j + 3] == 0 && ploca.Polje[i + 4, j + 4] == 0)
                    {
                        if (j == 0 && ploca.Polje[i + 3, j + 2] != 0 && ploca.Polje[i + 4, j + 3] != 0)
                            return i + 3;
                        else if (j > 0 && ploca.Polje[i, j - 1] != 0 && ploca.Polje[i + 3, j + 2] != 0 && ploca.Polje[i + 4, j + 3] != 0)
                            return i + 3;
                    }
                }
            for (int j = 5; j >= 4; j--)  //Prema dolje
                for (int i = 0; i <= 2; i++)
                {
                    if (ploca.Polje[i, j] == 0 && ploca.Polje[i + 1, j - 1] == 0 && ploca.Polje[i + 2, j - 2] == 1 && ploca.Polje[i + 3, j - 3] == 1 && ploca.Polje[i + 4, j - 4] == 0)
                    {
                        if (j == 5 && ploca.Polje[i, j - 1] != 0 && ploca.Polje[i + 1, j - 2] != 0 && ploca.Polje[i + 4, j - 5] != 0)
                            return i + 1;
                        else if (j == 4 && ploca.Polje[i, j - 1] != 0 && ploca.Polje[i + 1, j - 2] != 0)
                            return i + 1;
                    }
                    if (ploca.Polje[i, j] == 0 && ploca.Polje[i + 1, j - 1] == 1 && ploca.Polje[i + 2, j - 2] == 0 && ploca.Polje[i + 3, j - 3] == 1 && ploca.Polje[i + 4, j - 4] == 0)
                    {
                        if (j == 5 && ploca.Polje[i, j - 1] != 0 && ploca.Polje[i + 2, j - 3] != 0 && ploca.Polje[i + 4, j - 5] != 0)
                            return i + 2;
                        else if (j == 4 && ploca.Polje[i, j - 1] != 0 && ploca.Polje[i + 2, j - 3] != 0)
                            return i + 2;
                    }
                    if (ploca.Polje[i, j] == 0 && ploca.Polje[i + 1, j - 1] == 1 && ploca.Polje[i + 2, j - 2] == 1 && ploca.Polje[i + 3, j - 3] == 0 && ploca.Polje[i + 4, j - 4] == 0)
                    {
                        if (j == 5 && ploca.Polje[i, j - 1] != 0 && ploca.Polje[i + 3, j - 4] != 0 && ploca.Polje[i + 4, j - 5] != 0)
                            return i + 3;
                        else if (j == 4 && ploca.Polje[i, j - 1] != 0 && ploca.Polje[i + 3, j - 4] != 0)
                            return i + 3;
                    }
                }

            return -1;
        }

        private int UbaciUSredinu(Ploca ploca)
        {
            int br_Igrac = 0; int br_AI = 0;  //br1 broji igračeve žetone u srednjem stupcu, br2 broji AI-ove

            for (int j = 0; j <= 5; j++)
            {
                if (ploca.Polje[3, j] == 1)
                    br_Igrac++;
                else if (ploca.Polje[3, j] == 2)
                    br_AI++;
            }
            if (br_Igrac >= br_AI)
            {
                int redak = VratiRedak(ploca.Polje, 3);
                if (redak != -1 && (redak == 5 || ploca.ProvjeraPobjede(1, 3, redak + 1) == false))  //Pametno bacanje kao i u PametnijeRandomUbaci()
                    return 3;
            }
            return -1;
        }

        private int StvoriSedmicu(Ploca ploca)  //Pokusaj zamke "Sedam"
        {
            if (((ploca.Polje[3,1] != 1) && (ploca.Polje[3,2] != 1) && (ploca.Polje[2,2] != 1) && (ploca.Polje[4,2] != 1)) && ((ploca.Polje[2,0] != 1) || ploca.Polje[4,0] != 1))
            {
                if ((ploca.Polje[3, 1] == 0) && (ploca.Polje[3, 0] != 0) && !(ploca.ProvjeraPobjede(1, 3, 2)))
                    return 3;
                else if ((ploca.Polje[2, 0] == 0) && !(ploca.ProvjeraPobjede(1, 2, 1)))
                    return 2;
                else if ((ploca.Polje[4, 0] == 0) && !(ploca.ProvjeraPobjede(1, 4, 1)))
                    return 4;
                else if ((ploca.Polje[3, 2] == 0) && (ploca.Polje[3, 1] == 2) && !(ploca.ProvjeraPobjede(1, 3, 3)))
                    return 3;
                else if ((ploca.Polje[2, 2] == 0) && (ploca.Polje[2, 1] != 0) && !(ploca.ProvjeraPobjede(1, 2, 3)))
                    return 2;
                else if ((ploca.Polje[4, 2] == 0) && (ploca.Polje[4, 1] != 0) && !(ploca.ProvjeraPobjede(1, 4, 3)))
                    return 4;
            }
            return -1;
        }

        private int NapadniSedmicom(Ploca ploca)
        {
            if (ploca.Polje[3,1] == 2 && ploca.Polje[2,0] == 2 && ploca.Polje[3, 2] == 2 && ploca.Polje[2,2] == 2  && ploca.Polje[4,2] == 2 && ploca.Polje[5,3] == 0)
            {
                return 5;
            }
            else if (ploca.Polje[3, 1] == 2 && ploca.Polje[4, 0] == 2 && ploca.Polje[3, 2] == 2 && ploca.Polje[2, 2] == 2 && ploca.Polje[4, 2] == 2 && ploca.Polje[1, 3] == 0)
            {
                return 1;
            }
            return -1;
        }       
    }
}
