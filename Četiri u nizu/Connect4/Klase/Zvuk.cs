using Connect4.Properties;

namespace Connect4.Klase
{
    public class Zvuk
    {
        private static System.Media.SoundPlayer zeton = new System.Media.SoundPlayer(Resources.ubacivanje_zetona);
        private static System.Media.SoundPlayer pljesak = new System.Media.SoundPlayer(Resources.clapping);
        private static System.Media.SoundPlayer slavlje = new System.Media.SoundPlayer(Resources.cheer);
        private static System.Media.SoundPlayer buu = new System.Media.SoundPlayer(Resources.boo);
        private static System.Media.SoundPlayer izbornik = new System.Media.SoundPlayer(Resources.paradox);

        private static bool ukljucenZvuk = true;

        public static bool UkljucenZvuk()
        {
            return ukljucenZvuk;
        }

        public static void Ukljuci_Iskljuci()
        {
            ukljucenZvuk = (ukljucenZvuk == true) ? false : true;
        }

        public static void Zeton()
        {
            if(ukljucenZvuk)
                zeton.Play();
        }

        public static void Pljesak()
        {
            if (ukljucenZvuk)
                pljesak.Play();
        }

        public static void Slavlje()
        {
            if (ukljucenZvuk)
                slavlje.Play();
        }

        public static void Buu()
        {
            if (ukljucenZvuk)
                buu.Play();
        }

        public static void Izbornik_Pokreni()
        {
            izbornik.PlayLooping();
        }

        public static void Izbornik_Zaustavi()
        {
            izbornik.Stop();
        }

    }
}
