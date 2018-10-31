using System;
using System.Windows.Forms;
using Connect4.Klase;

namespace Connect4.Forme
{
    public partial class Statistika : Form
    {
        public Statistika()
        {
            InitializeComponent();
        }

        private void Button_1igrac_Click(object sender, EventArgs e)
        {
            Statistika_1P_Razine stat_1P = new Statistika_1P_Razine();

            stat_1P.Show();
            stat_1P.FormClosed += (a, aa) => { Show(); };
            Hide();
        }

        private void Button_2igraca_Click(object sender, EventArgs e)
        {
            Statistika_2P.Ispisi();
        }

        private void Button_Nazad_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
