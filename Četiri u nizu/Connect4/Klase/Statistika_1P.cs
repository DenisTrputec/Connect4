using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Connect4.Klase
{
    class Statistika_1P
    {
        private static List<HallOfFame> listaIgraca;  //koristi se u cijeloj klasi, ali se stvara svaki put nova lista kad se izvrsi Ucitaj()

        public static List<HallOfFame> Ucitaj(int razina)
        {
            listaIgraca = new List<HallOfFame>();
            string[] zapis;  //tu se sprema što je pročitano iz datoteke

            // čita sve linije iz txt datoteka, ako ne postoje baca grešku
            if (razina == 1)
            {
                try
                {
                    zapis = File.ReadAllLines("txt/Kuca slavnih 1-Lako.txt");
                }
                catch (Exception)
                {
                    return listaIgraca;
                }
            }
            else if (razina == 2)
            {
                try
                {
                    zapis = File.ReadAllLines("txt/Kuca slavnih 1-Srednje.txt");
                }
                catch (Exception)
                {
                    return listaIgraca;
                }
            }
            else
            {
                try
                {
                    zapis = File.ReadAllLines("txt/Kuca slavnih 1-Tesko.txt");
                }
                catch (Exception)
                {
                    return listaIgraca;
                }
            }

            foreach (var linija in zapis)  //čitanje liniju po liniju
            {
                var strArray = linija.Split(',');  //kad naiđe na zarez, odvoji i spremi pod novim indeksom u polju
                HallOfFame hof = new HallOfFame(strArray[0], int.Parse(strArray[1]), int.Parse(strArray[2]), int.Parse(strArray[3]));
                listaIgraca.Add(hof);
            }

            listaIgraca.Sort((prviIgrac, drugiIgrac) => drugiIgrac.PostotakPobjeda.CompareTo(prviIgrac.PostotakPobjeda));

            return listaIgraca;
        }

        public static void Spremi(Igrac igrac,int razina, int rezultat)
        {
            Ucitaj(razina);

            HallOfFame hofIgrac = new HallOfFame();

            foreach (var hof in listaIgraca)
            {
                if (hof.Ime == igrac.Ime)  //ako vec postoji igrac u listi
                    hofIgrac = hof;
            }

            hofIgrac.Ime = igrac.Ime;  //moguce da vec je

            if (rezultat == 1)
            {
                hofIgrac.Pobjede++;
            }
            else if (rezultat == 2)
            {
                hofIgrac.Porazi++;
            }
            else
            {
                hofIgrac.Nerjesene++;
            }

            if (!listaIgraca.Contains(hofIgrac))  //ako ga nema u listi, dodaj ga
                listaIgraca.Add(hofIgrac);

            string temp = "";
            foreach (var hof in listaIgraca)
                temp += hof.ToString() + Environment.NewLine;

            if (razina == 1)
                File.WriteAllText("txt/Kuca slavnih 1-Lako.txt", temp);
            else if (razina == 2)
                File.WriteAllText("txt/Kuca slavnih 1-Srednje.txt", temp);
            else
                File.WriteAllText("txt/Kuca slavnih 1-Tesko.txt", temp);
        }     

        public static void Ispisi(int razina)
        {
            List<HallOfFame> statistika = new List<HallOfFame>();
            statistika = Ucitaj(razina);

            string hallOfFame = "Ime \t\t M \t W \t D \t L \t W(%)" + Environment.NewLine;

            foreach (var hof in statistika)
            {
                hof.Odigrano = hof.Pobjede + hof.Nerjesene + hof.Porazi;
                hof.PostotakPobjeda = (float)hof.Pobjede / hof.Odigrano * 100;
                hof.PostotakPobjeda = (float)Math.Round(hof.PostotakPobjeda, 2);
                hallOfFame += hof.Ime + "\t\t  " + hof.Odigrano + "\t  " + hof.Pobjede + "\t " + hof.Nerjesene + "\t " + hof.Porazi + "\t  " + hof.PostotakPobjeda + Environment.NewLine;
            }

            if (statistika.Count == 0)
                hallOfFame = "Nema odigranih partija!";

            MessageBox.Show(hallOfFame, "Statistika");
        }
    }
}
