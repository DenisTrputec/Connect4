using System;
using System.Drawing;
using System.Windows.Forms;
using Connect4.Klase;
using System.IO;

namespace Connect4
{
    public partial class DvaIgraca : Form
    {
        private string imeIgraca1 = "";
        private string imeIgraca2 = "";

        public DvaIgraca()
        {
            InitializeComponent();
            TextBox_ImeIgraca1.Text = "Igrač 1";
            TextBox_ImeIgraca2.Text = "Igrač 2";
            radioButton_PrviIgraIgrac1.Text = "Igrač 1";
            radioButton_PrviIgraIgrac2.Text = "Igrač 2";
            radioButton_Crvena1.Checked = true;
            radioButton_Zuta2.Checked = true;
            radioButton_PrviIgraIgrac1.Checked = true;

            StvoriListu();
        }

        private void OdabirBoje(object sender, EventArgs e)
        {
            radioButton_Crvena1.Enabled = !radioButton_Crvena2.Checked;
            radioButton_Crvena2.Enabled = !radioButton_Crvena1.Checked;
            radioButton_Plava1.Enabled = !radioButton_Plava2.Checked;
            radioButton_Plava2.Enabled = !radioButton_Plava1.Checked;
            radioButton_Zuta1.Enabled = !radioButton_Zuta2.Checked;
            radioButton_Zuta2.Enabled = !radioButton_Zuta1.Checked;
            radioButton_Zelena1.Enabled = !radioButton_Zelena2.Checked;
            radioButton_Zelena2.Enabled = !radioButton_Zelena1.Checked;
        }

        private void Button_Povratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Zapocni_Click(object sender, EventArgs e)
        {
            Color bojaIgraca1;
            Color bojaIgraca2;
            bool prviIgra = true;

            imeIgraca1 = TextBox_ImeIgraca1.Text;
            imeIgraca2 = TextBox_ImeIgraca2.Text;

            if (radioButton_Crvena1.Checked)
                bojaIgraca1 = Color.Red;
            else if (radioButton_Plava1.Checked)
                bojaIgraca1 = Color.Blue;
            else if (radioButton_Zuta1.Checked)
                bojaIgraca1 = Color.Yellow;
            else
                bojaIgraca1 = Color.Green;

            if (radioButton_Crvena2.Checked)
                bojaIgraca2 = Color.Red;
            else if (radioButton_Plava2.Checked)
                bojaIgraca2 = Color.Blue;
            else if (radioButton_Zuta2.Checked)
                bojaIgraca2 = Color.Yellow;
            else
                bojaIgraca2 = Color.Green;

            if (radioButton_PrviIgraIgrac2.Checked)
                prviIgra = false;

            if (ProvjeraImena())
            {
                Igrac igrac1 = new Igrac(imeIgraca1, bojaIgraca1);
                Igrac igrac2 = new Igrac(imeIgraca2, bojaIgraca2);

                int[,] polje = new int[7, 6];
                for (int i = 0; i < 7; i++)
                    for (int j = 0; j < 6; j++)
                    {
                        polje[i, j] = 0;
                    }
                Ploca ploca = new Ploca(polje, 0);

                Igra_2P i2p = new Igra_2P(ploca, igrac1, igrac2, prviIgra);
                i2p.FormClosed += (a, aa) => { Close(); };
                i2p.Show();
                Hide();

                Zvuk.Izbornik_Zaustavi();
            }
            else
                MessageBox.Show("Ime mora sadržavati od 1 do 8 znakova!\nImena ne smiju biti ista!", "Pozor!");
        }

        private bool ProvjeraImena()
        {
            if (imeIgraca1.Length > 0 && imeIgraca1.Length < 9 && imeIgraca2.Length > 0 && imeIgraca2.Length < 9 && (imeIgraca1 != imeIgraca2))
                return true;
            return false;

        }


        private void StvoriListu()
        {
            string[] zapis = File.ReadAllLines("txt/Kuca slavnih 2.txt");
            foreach (var linija in zapis)
            {
                var strArray = linija.Split(',');
                if (!ComboBox1.Items.Contains(strArray[0].ToString()))
                {
                    ComboBox1.Items.Add(strArray[0].ToString());
                    ComboBox2.Items.Add(strArray[0].ToString());
                }
            }
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox_ImeIgraca1.Text = ComboBox1.SelectedItem.ToString();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox_ImeIgraca2.Text = ComboBox2.SelectedItem.ToString();
        }

        private void TextBox_ImeIgraca1_Click(object sender, EventArgs e)
        {
            ComboBox1.Text = "";
        }

        private void TextBox_ImeIgraca2_Click(object sender, EventArgs e)
        {
            ComboBox2.Text = "";
        }
    }
}
