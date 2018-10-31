using System;
using System.Windows.Forms;
using Connect4.Klase;

namespace Connect4.Forme
{
    public partial class Statistika_1P_Razine : Form
    {
        public Statistika_1P_Razine()
        {
            InitializeComponent();
        }

        private void Button_Lako_Click(object sender, EventArgs e)
        {
            Statistika_1P.Ispisi(1);
        }

        private void Button_Srednje_Click(object sender, EventArgs e)
        {
            Statistika_1P.Ispisi(2);
        }

        private void Button_Tesko_Click(object sender, EventArgs e)
        {
            Statistika_1P.Ispisi(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
