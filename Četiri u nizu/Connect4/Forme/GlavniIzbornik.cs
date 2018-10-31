using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Connect4.Klase;
using Connect4.Forme;
using Connect4.Properties;

namespace Connect4
{
    public partial class GlavniIzbornik : Form
    {
        public GlavniIzbornik()
        {
            InitializeComponent();

            Button_Zvuk.BackgroundImage = Resources.sound_on;
            Button_Zvuk.BackgroundImageLayout = ImageLayout.Stretch;
            Zvuk.Izbornik_Pokreni();
        }

        private void Button_1igrac_Click(object sender, EventArgs e)
        {
            JedanIgrac p1 = new JedanIgrac();

            p1.Show();
            p1.FormClosed += (a, aa) => 
            {
                Show();
                Button_Zvuk.BackgroundImage = Zvuk.UkljucenZvuk() ? Resources.sound_on : Resources.sound_off;
                Button_Zvuk.BackgroundImageLayout = ImageLayout.Stretch;
            };
            Hide();
        }

        private void Button_2igraca_Click(object sender, EventArgs e)
        {
            DvaIgraca p2 = new DvaIgraca();

            p2.Show();
            p2.FormClosed += (a, aa) => 
            {
                Show();
                Button_Zvuk.BackgroundImage = Zvuk.UkljucenZvuk() ? Resources.sound_on : Resources.sound_off;
                Button_Zvuk.BackgroundImageLayout = ImageLayout.Stretch;
            };
            Hide();
        }

        private void Button_Statistika_Click(object sender, EventArgs e)
        {
            Statistika stats = new Statistika();

            stats.Show();
            stats.FormClosed += (a, aa) => { Show(); };
            Hide();
        }

        private void Button_Pravila_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.pravila_igre, "Pravila");
        }

        private void Button_Zvuk_Click(object sender, EventArgs e)
        {
            Zvuk.Ukljuci_Iskljuci();

            if (Zvuk.UkljucenZvuk())
                Zvuk.Izbornik_Pokreni();
            else
                Zvuk.Izbornik_Zaustavi();

            Button_Zvuk.BackgroundImage = Zvuk.UkljucenZvuk() ? Resources.sound_on : Resources.sound_off;
            Button_Zvuk.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
