using System.Drawing;

namespace Connect4.Klase
{
    public class Igrac
    {
        private string ime;
        private Color boja;

        public Igrac(string ime, Color boja)
        {
            this.ime = ime;
            this.boja = boja;
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public Color Boja
        {
            get { return boja; }
            set { boja = value; }
        }
    }
}
