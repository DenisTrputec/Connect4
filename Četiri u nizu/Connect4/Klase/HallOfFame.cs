using System;

namespace Connect4.Klase
{
    public class HallOfFame
    {
        private string ime;
        private int odigrano;
        private int pobjede;
        private int nerjesene;
        private int porazi;
        private float postotakPobjeda;

        public HallOfFame() : this("", 0, 0, 0)
        {
        }

        public HallOfFame(string ime, int pobjede, int nerjesene, int porazi)
        {
            this.ime = ime;
            this.pobjede = pobjede;
            this.nerjesene = nerjesene;
            this.porazi = porazi;
            this.odigrano = pobjede + nerjesene + porazi;
            this.postotakPobjeda = (float)pobjede / odigrano * 100;
            Math.Round(postotakPobjeda, 2);
        }

        //get i set
        #region
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public int Odigrano
        {
            get { return odigrano; }
            set { odigrano = value; }
        }

        public int Pobjede
        {
            get { return pobjede; }
            set { pobjede = value; }
        }

        public int Nerjesene
        {
            get { return nerjesene; }
            set { nerjesene = value; }
        }

        public int Porazi
        {
            get { return porazi; }
            set { porazi = value; }
        }

        public float PostotakPobjeda
        {
            get { return postotakPobjeda; }
            set { postotakPobjeda = value; }
        }
        #endregion

        public override string ToString()
        {
            return Ime + "," + Pobjede + "," + Nerjesene + "," + Porazi;
        }
    }
}
