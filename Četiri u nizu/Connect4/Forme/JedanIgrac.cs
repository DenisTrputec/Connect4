using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Connect4.Klase;

namespace Connect4
{
    public partial class JedanIgrac : Form
    {
        private string imeIgraca = "";
        private string bojaPloce = "cyan";  

        public JedanIgrac()
        {
            InitializeComponent();

            TextBox_ImeIgraca.Text = "Igrač";
            radioButton_Crvena1.Checked = true;
            radioButton_Zuta2.Checked = true;
            radioButton_PrviIgraIgrac.Checked = true;
            radioButton_Razina2.Checked = true;

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

        private void OdabirTezine(object sender, EventArgs e)
        {
            if (radioButton_Razina1.Checked)
            {
                label_ImeAI.Text = "Lako";
            }
            if (radioButton_Razina2.Checked)
            {
                label_ImeAI.Text = "Srednje";
            }
            if (radioButton_Razina3.Checked)
            {
                label_ImeAI.Text = "Teško";
            }
        }

        private void Button_Povratak_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Zapocni_Click(object sender, EventArgs e)
        {
            Color bojaIgraca;
            short razinaTezine;
            Color bojaAI;
            bool prviIgra = true;

            imeIgraca = TextBox_ImeIgraca.Text;

            if (radioButton_Crvena1.Checked)
                bojaIgraca = Color.Red;
            else if (radioButton_Plava1.Checked)
                bojaIgraca = Color.Blue;
            else if (radioButton_Zuta1.Checked)
                bojaIgraca = Color.Yellow;
            else
                bojaIgraca = Color.Green;

            if (radioButton_Crvena2.Checked)
                bojaAI = Color.Red;
            else if (radioButton_Plava2.Checked)
                bojaAI = Color.Blue;
            else if (radioButton_Zuta2.Checked)
                bojaAI = Color.Yellow;
            else
                bojaAI = Color.Green;

            if (radioButton_Razina1.Checked)
                razinaTezine = 1;
            else if (radioButton_Razina2.Checked)
                razinaTezine = 2;
            else
                razinaTezine = 3;

            if (radioButton_PrviIgraAI.Checked)
                prviIgra = false;

            if (ProvjeraImena())
            {
                Igrac igrac = new Igrac(imeIgraca, bojaIgraca);
                AI ai = new AI(razinaTezine, bojaAI);

                int[,] polje = new int[7, 6];
                for (int i = 0; i < 7; i++)
                    for (int j = 0; j < 6; j++)
                    {
                        polje[i, j] = 0;
                    }
                Ploca ploca = new Ploca(polje, 0);

                Igra_1P i1p = new Igra_1P(ploca, igrac, ai, prviIgra, bojaPloce);
                i1p.FormClosed += (a, aa) => { Close(); };
                i1p.Show();
                Hide();

                Zvuk.Izbornik_Zaustavi();
            }
            else
            {
                MessageBox.Show("Ime mora sadržavati od 1 do 8 znakova!", "Pozor!");
            }
        }

        private bool ProvjeraImena()
        {
            if (imeIgraca.Length > 0 && imeIgraca.Length < 9)
                return true;
            return false;

        }


        private void StvoriListu()
        {
            string[] zapis = File.ReadAllLines("txt/Kuca slavnih 1-Lako.txt");
            Dodaj(zapis);
            zapis = File.ReadAllLines("txt/Kuca slavnih 1-Srednje.txt");
            Dodaj(zapis);
            zapis = File.ReadAllLines("txt/Kuca slavnih 1-Tesko.txt");
            Dodaj(zapis);
        }

        private void Dodaj(string[] zapis)
        {
            foreach (var linija in zapis)
            {
                var strArray = linija.Split(',');
                if (!ComboBox.Items.Contains(strArray[0].ToString()))   //Property sorted je u true kako bi itemi bili sortirani
                    ComboBox.Items.Add(strArray[0].ToString());
            }
        }


        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox_ImeIgraca.Text = ComboBox.SelectedItem.ToString();
        }

        private void TextBox_ImeIgraca_Click(object sender, EventArgs e)
        {
            ComboBox.Text="";
        }

        private void PromijeniBojuPloce()
        {
            if ((!radioButton_Plava1.Checked) && (!radioButton_Plava2.Checked))
                bojaPloce = "blue";
            else if (radioButton_Crvena1.Checked == false && radioButton_Crvena2.Checked == false)
                bojaPloce = "red";
            else
                bojaPloce = "green";
        }
    }
}
