using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Connect4.Klase
{
    public static class Statistika_2P
    {
        private static List<HallOfFame> listaIgraca;

        public static List<HallOfFame> Ucitaj()
        {
            listaIgraca = new List<HallOfFame>();
            string[] zapis;

            try
            {
                zapis = File.ReadAllLines("txt/Kuca slavnih 2.txt");
            }
            catch (Exception)
            {
                return listaIgraca;
            }

            foreach (var linija in zapis)
            {
                var strArray = linija.Split(',');
                HallOfFame hof = new HallOfFame(strArray[0], int.Parse(strArray[1]), int.Parse(strArray[2]), int.Parse(strArray[3]));
                listaIgraca.Add(hof);
            }

            listaIgraca.Sort((prviIgrac, drugiIgrac) => drugiIgrac.PostotakPobjeda.CompareTo(prviIgrac.PostotakPobjeda));

            return listaIgraca;
        }

        public static void Spremi(Igrac pobjednik, Igrac gubitnik, bool nerjeseno)
        {
            if (listaIgraca == null)
                Ucitaj();

            HallOfFame hofPobjednik = new HallOfFame();
            HallOfFame hofGubitnik = new HallOfFame();

            foreach (var hof in listaIgraca)
            {
                if (hof.Ime == pobjednik.Ime)
                    hofPobjednik = hof;
                if (hof.Ime == gubitnik.Ime)
                    hofGubitnik = hof;
            }

            hofPobjednik.Ime = pobjednik.Ime;
            hofGubitnik.Ime = gubitnik.Ime;

            if (!nerjeseno)
            {
                hofPobjednik.Pobjede++;
                hofGubitnik.Porazi++;
            }
            else
            {
                hofPobjednik.Nerjesene++;
                hofGubitnik.Nerjesene++;
            }

            if (!listaIgraca.Contains(hofPobjednik))
                listaIgraca.Add(hofPobjednik);
            if (!listaIgraca.Contains(hofGubitnik))
                listaIgraca.Add(hofGubitnik);

            string temp = "";
            foreach (var hof in listaIgraca)
                temp += hof.ToString() + Environment.NewLine;
            File.WriteAllText("txt/Kuca slavnih 2.txt", temp);
        }

        public static void Ispisi()
        {
            List<HallOfFame> statistika = new List<HallOfFame>();
            statistika = Ucitaj();
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
