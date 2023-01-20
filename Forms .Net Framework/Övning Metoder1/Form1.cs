using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_Metoder1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int[] tal = HämtaData();
            lblResultat.Text = "Resultat: " + Beräkna(tal[0], tal[1], '+');
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int[] tal = HämtaData();
            lblResultat.Text = "Resultat: " + Beräkna(tal[0], tal[1], '*');
        }

        void Skrivut(string utdata) {
            Break;
        }


        int[] HämtaData() {
            int[] h = { int.Parse(tbxTal1.Text), int.Parse(tbxTal2.Text) };
            return h;
        }

        int Beräkna(int tal1, int tal2, char räknesätt) {
            switch (räknesätt) {
                case '+':
                    return tal1 + tal2;
                case '*':
                    return tal1 * tal2;
                default:
                    return 0;
            }
        }
    }
}
