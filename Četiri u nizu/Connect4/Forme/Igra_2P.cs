using System;
using System.Drawing;
using System.Windows.Forms;
using Connect4.Klase;

namespace Connect4
{
    public partial class Igra_2P : Form
    {
        private Ploca ploca;
        private Igrac igrac1;
        private Igrac igrac2;
        private bool naPotezu;

        Graphics krug;

        private int zadnjiX;
        private int zadnjiY;
        private bool omogućenUndo;

        private int brojPobjeda1 = 0;
        private int brojPobjeda2 = 0;
        private bool prviJeIgrao;
        private int zeton;    //da znamo kojeg igraca provjeravamo (1 ili 2)

        public Igra_2P(Ploca ploca, Igrac igrac1, Igrac igrac2, bool naPotezu)
        {
            InitializeComponent();

            this.igrac1 = igrac1;
            this.igrac2 = igrac2;
            this.naPotezu = naPotezu;
            this.ploca = ploca;

            this.krug = pictureBox1.CreateGraphics();

            zadnjiX = -1;
            zadnjiY = -1;
            omogućenUndo = false;
        }

        private void Igra_2P_Shown(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            PostaviIgru();
        }


        private void CrtajKrug(int i, int j)
        {
            if (naPotezu == true)
                krug.FillEllipse(new SolidBrush(igrac1.Boja), i * 100 + 5, 505 - j * 100, 90, 90);
            else
                krug.FillEllipse(new SolidBrush(igrac2.Boja), i * 100 + 5, 505 - j * 100, 90, 90);
        }

        private void ObrisiKrug(int i, int j)
        {
            krug.FillEllipse(new SolidBrush(Color.White), i * 100 + 5, 505 - j * 100, 90, 90);
        }


        private void PostaviIgru()
        {
            label_Rezultat.Text = igrac1.Ime + " - " + igrac2.Ime + "  " + brojPobjeda1 + ":" + brojPobjeda2;
            Button_Zvuk.Text = Zvuk.UkljucenZvuk() ? "Zvuk: uključen" : "Zvuk: isključen";

            ploca.BrojacPoteza = 0;

            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 6; j++)
                {
                    ploca.Polje[i, j] = 0;
                    ObrisiKrug(i, j);
                }

            Button0.Enabled = true;
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button5.Enabled = true;
            Button6.Enabled = true;

            prviJeIgrao = naPotezu;
            Potez(naPotezu);
        }

        private void Potez(bool naPotezu)
        {
            ploca.BrojacPoteza++;
            label_BrojPoteza.Text = "Potez:" + ploca.BrojacPoteza.ToString();
            label_NaPotezu.Text = (naPotezu) ? ("Na potezu: " + igrac1.Ime) : ("Na potezu: " + igrac2.Ime);
            label_NaPotezu.Refresh();

            if (ploca.Polje[0, 5] > 0)
                Button0.Enabled = false;
            if (ploca.Polje[1, 5] > 0)
                Button1.Enabled = false;
            if (ploca.Polje[2, 5] > 0)
                Button2.Enabled = false;
            if (ploca.Polje[3, 5] > 0)
                Button3.Enabled = false;
            if (ploca.Polje[4, 5] > 0)
                Button4.Enabled = false;
            if (ploca.Polje[5, 5] > 0)
                Button5.Enabled = false;
            if (ploca.Polje[6, 5] > 0)
                Button6.Enabled = false;

            if (naPotezu)
            {
                Button0.BackColor = igrac1.Boja;
                Button1.BackColor = igrac1.Boja;
                Button2.BackColor = igrac1.Boja;
                Button3.BackColor = igrac1.Boja;
                Button4.BackColor = igrac1.Boja;
                Button5.BackColor = igrac1.Boja;
                Button6.BackColor = igrac1.Boja;
            }
            else
            {
                Button0.BackColor = igrac2.Boja;
                Button1.BackColor = igrac2.Boja;
                Button2.BackColor = igrac2.Boja;
                Button3.BackColor = igrac2.Boja;
                Button4.BackColor = igrac2.Boja;
                Button5.BackColor = igrac2.Boja;
                Button6.BackColor = igrac2.Boja;
            }
        }


        //Button0 -> Button6
        #region
        private void Button0_Click(object sender, EventArgs e)
        {
            UbaciZeton(0);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UbaciZeton(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UbaciZeton(2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UbaciZeton(3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            UbaciZeton(4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            UbaciZeton(5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            UbaciZeton(6);          
        }
        #endregion

        private void UbaciZeton(int stupac)
        {
            Zvuk.Zeton();

            int redak;
            for (redak = 0; redak < 6; redak++)
                if (ploca.Polje[stupac, redak] == 0)
                {
                    if (naPotezu)
                    {
                        ploca.Polje[stupac, redak] = 1;
                        zeton = 1;
                    }
                    else
                    {
                        ploca.Polje[stupac, redak] = 2;
                        zeton = 2;
                    }
                    break;
                }

            CrtajKrug(stupac, redak);

            //Za Undo
            zadnjiX = stupac;
            zadnjiY = redak;
            omogućenUndo = true;

            //Provjera je li gotova igra
            if (ploca.ProvjeraPobjede(zeton, stupac, redak))
                KrajIgre(zeton);
            else if (ploca.ProvjeraNerjesenog())
                KrajIgre(0);
            else
            {
                naPotezu = !naPotezu;
                Potez(naPotezu);
            }
        }

        private void KrajIgre(int pobjednik)
        {
            Zvuk.Pljesak();

            DialogResult odgovor;
            if(pobjednik == 1)
            {
                brojPobjeda1++;
                Statistika_2P.Spremi(igrac1, igrac2, false);
                odgovor = MessageBox.Show("Kraj igre! \nPobjednik je " + igrac1.Ime + "\nŽelite li igrati ponovno?", "KRAJ!", MessageBoxButtons.YesNo);
            }
            else if(pobjednik == 2)
            {
                brojPobjeda2++;
                Statistika_2P.Spremi(igrac2, igrac1, false);
                odgovor = MessageBox.Show("Kraj igre! \nPobjednik je " + igrac2.Ime + "\nŽelite li igrati ponovno?", "KRAJ!", MessageBoxButtons.YesNo);
            }
            else
            {
                Statistika_2P.Spremi(igrac1, igrac2, true);
                odgovor = MessageBox.Show("Kraj igre! Završilo je neodlučeno \nŽelite li igrati ponovno?", "KRAJ!", MessageBoxButtons.YesNo);
            }


            if (odgovor == DialogResult.Yes)
            {
                if (prviJeIgrao == naPotezu)
                    naPotezu = !naPotezu;
                PostaviIgru();
            }
            else
                Close();
        }

        private void Undo(int stupac, int redak)
        {
            ploca.BrojacPoteza--;
            label_BrojPoteza.Text = "Potez:" + ploca.BrojacPoteza.ToString();

            ploca.Polje[stupac, redak] = 0;
            ObrisiKrug(stupac, redak);

            if(redak == 5)
            {
                switch (stupac)
                {
                    case 0:
                        Button0.Enabled = true;
                        break;
                    case 1:
                        Button1.Enabled = true;
                        break;
                    case 2:
                        Button2.Enabled = true;
                        break;
                    case 3:
                        Button3.Enabled = true;
                        break;
                    case 4:
                        Button4.Enabled = true;
                        break;
                    case 5:
                        Button5.Enabled = true;
                        break;
                    case 6:
                        Button6.Enabled = true;
                        break;
                    default:
                        break;
                }
            }

            naPotezu = !naPotezu;
            label_NaPotezu.Text = (naPotezu) ? ("Na potezu: " + igrac1.Ime) : ("Na potezu: " + igrac2.Ime);

            if (naPotezu)
            {
                Button0.BackColor = igrac1.Boja;
                Button1.BackColor = igrac1.Boja;
                Button2.BackColor = igrac1.Boja;
                Button3.BackColor = igrac1.Boja;
                Button4.BackColor = igrac1.Boja;
                Button5.BackColor = igrac1.Boja;
                Button6.BackColor = igrac1.Boja;
            }
            else
            {
                Button0.BackColor = igrac2.Boja;
                Button1.BackColor = igrac2.Boja;
                Button2.BackColor = igrac2.Boja;
                Button3.BackColor = igrac2.Boja;
                Button4.BackColor = igrac2.Boja;
                Button5.BackColor = igrac2.Boja;
                Button6.BackColor = igrac2.Boja;
            }

            omogućenUndo = false;
        }


        private void Button_Zvuk_Click(object sender, EventArgs e)
        {
            Zvuk.Ukljuci_Iskljuci();
            Button_Zvuk.Text = Zvuk.UkljucenZvuk() ? "Zvuk: uključen" : "Zvuk: isključen";
        }

        private void Igra_2P_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Zvuk.UkljucenZvuk())
                Zvuk.Izbornik_Pokreni();
        }
    }
}
