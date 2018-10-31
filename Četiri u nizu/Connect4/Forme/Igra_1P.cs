using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Connect4.Klase;
using Connect4.Properties;

namespace Connect4
{
    public partial class Igra_1P : Form
    {
        private Ploca ploca;
        private Igrac igrac;
        private AI ai;
        private bool naPotezu;
        private string bojaPloce;
     
        Graphics krug;

        private int zadnjiX;
        private int zadnjiY;
        private int predzadnjiX;
        private int predzadnjiY;
        private bool omogucenUndo;

        private int brojPobjeda1 = 0;
        private int brojPobjeda2 = 0;
        private bool prviJeIgrao;  //true za igraca, false za AI
        private int zeton;  //1 za igraca, 2 za AI


        public Igra_1P(Ploca ploca, Igrac igrac, AI ai, bool naPotezu, string bojaPloce)
        {
            InitializeComponent();

            this.ploca = ploca;
            this.igrac = igrac;
            this.ai = ai;
            this.naPotezu = naPotezu;
            this.bojaPloce = bojaPloce;

            this.krug = pictureBox1.CreateGraphics();

            // Undo
            zadnjiX = -1;
            zadnjiY = -1;
            predzadnjiX = -1;
            predzadnjiY = -1;
            omogucenUndo = false;
        }

        private void Igra_1P_Shown(object sender, EventArgs e)
        {
            if (bojaPloce == "blue")
                pictureBox1.BackgroundImage = Resources.board_blue;
            else if(bojaPloce == "red")
                pictureBox1.BackgroundImage = Resources.board_red;
            else if(bojaPloce == "green")
                pictureBox1.BackgroundImage = Resources.board_green;
            pictureBox1.Refresh();
            PostaviIgru();
        }


        private void CrtajKrug(int i, int j)
        {
            if (naPotezu == true)
                krug.FillEllipse(new SolidBrush(igrac.Boja), i * 100 + 5, 505 - j * 100, 90, 90);
            else
                krug.FillEllipse(new SolidBrush(ai.Boja), i * 100 + 5, 505 - j * 100, 90, 90);
        }

        private void ObrisiKrug(int i, int j)
        {
            krug.FillEllipse(new SolidBrush(Color.White), i * 100 + 5, 505 - j * 100, 90, 90);
        }


        private void PostaviIgru()
        {
            label_Rezultat.Text = igrac.Ime + " - " + ai.Ime + "  " + brojPobjeda1 + ":" + brojPobjeda2;
            Button_Zvuk.Text = Zvuk.UkljucenZvuk() ? "Zvuk: uključen" : "Zvuk: isključen";

            ploca.BrojacPoteza = 0;
            
            //Brisanje igrace ploče
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 6; j++)
                {
                    ploca.Polje[i, j] = 0;
                    ObrisiKrug(i, j);
                }

            prviJeIgrao = naPotezu;
            Potez(naPotezu);
        }

        private void Potez(bool naPotezu)
        {
            ploca.BrojacPoteza++;

            label_BrojPoteza.Text = "Potez:" + ploca.BrojacPoteza.ToString();
            label_BrojPoteza.Refresh();
            label_Rezultat.Refresh();
            label_NaPotezu.Text = (naPotezu) ? ("Na potezu: " + igrac.Ime) : ("Na potezu: " + ai.Ime);
            label_NaPotezu.Refresh();

            if (naPotezu)
            {
                Button0.BackColor = igrac.Boja;
                Button1.BackColor = igrac.Boja;
                Button2.BackColor = igrac.Boja;
                Button3.BackColor = igrac.Boja;
                Button4.BackColor = igrac.Boja;
                Button5.BackColor = igrac.Boja;
                Button6.BackColor = igrac.Boja;

                if (ploca.Polje[0, 5] == 0)
                    Button0.Enabled = true;
                if (ploca.Polje[1, 5] == 0)
                    Button1.Enabled = true;
                if (ploca.Polje[2, 5] == 0)
                    Button2.Enabled = true;
                if (ploca.Polje[3, 5] == 0)
                    Button3.Enabled = true;
                if (ploca.Polje[4, 5] == 0)
                    Button4.Enabled = true;
                if (ploca.Polje[5, 5] == 0)
                    Button5.Enabled = true;
                if (ploca.Polje[6, 5] == 0)
                    Button6.Enabled = true;
            }
            else
            {
                Button0.BackColor = ai.Boja;
                Button1.BackColor = ai.Boja;
                Button2.BackColor = ai.Boja;
                Button3.BackColor = ai.Boja;
                Button4.BackColor = ai.Boja;
                Button5.BackColor = ai.Boja;
                Button6.BackColor = ai.Boja;

                Button0.Enabled = false;
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                Button5.Enabled = false;
                Button6.Enabled = false; 

                AI_Logika();  
            } 
        }

        private void AI_Logika()
        {
            Thread.Sleep(500);

            int stupac;
            if (ai.Razina == 1)
                stupac = ai.RazinaLako(ploca);
            else if (ai.Razina == 2)
                stupac = ai.RazinaSrednje(ploca);
            else
                stupac = ai.RazinaTesko(ploca);

            UbaciZeton(stupac);
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

            //Undo
            predzadnjiX = zadnjiX;
            predzadnjiY = zadnjiY;
            zadnjiX = stupac;
            zadnjiY = redak;
            omogucenUndo = true;

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
            DialogResult odgovor;
            if (pobjednik == 1)
            {
                Zvuk.Slavlje();
                brojPobjeda1++;
                Statistika_1P.Spremi(igrac, ai.Razina, 1);
                odgovor = MessageBox.Show("Pobjeda! :D \nŽelite li igrati ponovno?", "KRAJ!", MessageBoxButtons.YesNo);
            }
            else if (pobjednik == 2)
            {
                Zvuk.Buu();
                brojPobjeda2++;
                Statistika_1P.Spremi(igrac, ai.Razina, 2);
                odgovor = MessageBox.Show("Poraz... :( \nŽelite li pokušati ponovno?", "KRAJ!", MessageBoxButtons.YesNo);
            }
            else
            {
                Zvuk.Pljesak();
                Statistika_1P.Spremi(igrac, ai.Razina, 0);
                odgovor = MessageBox.Show("Nerješeno! \nŽelite li igrati ponovno?", "KRAJ!", MessageBoxButtons.YesNo);
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

        private void Undo(int i, int j, int i2, int j2)
        {
            ploca.BrojacPoteza -= 2;
            label_BrojPoteza.Text = "Potez:" + ploca.BrojacPoteza.ToString();

            ploca.Polje[i, j] = 0;
            ObrisiKrug(i, j);
            ploca.Polje[i2, j2] = 0;
            ObrisiKrug(i2, j2);

            omogucenUndo = false;
        }


        private void Button_Zvuk_Click(object sender, EventArgs e)
        {
            Zvuk.Ukljuci_Iskljuci();
            Button_Zvuk.Text = Zvuk.UkljucenZvuk() ? "Zvuk: uključen" : "Zvuk: isključen";
        }

        private void Igra_1P_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Zvuk.UkljucenZvuk())
                Zvuk.Izbornik_Pokreni();
        }      
    }
}



 