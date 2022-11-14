using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzy___miniprojektet
{
    public partial class Yatzy : Form
    {
        // Här kommer fördefinerade grejer som ska kunna användas och justeras från flera olika platser i programmet:
        Random generator = new Random();
        Image[] tärning = { diceGUI.d0, diceGUI.d1, diceGUI.d2, diceGUI.d3, diceGUI.d4, diceGUI.d5, diceGUI.d6 };
        bool[] behåll = new bool[5];
        int[] prickar = new int[5];
        int[] poäng = new int[16];
        int antalSlag = 0;
        public Yatzy()
        {
            InitializeComponent();
            pc1.Image = tärning[0];
            pc2.Image = tärning[0];
            pc3.Image = tärning[0];
            pc4.Image = tärning[0];
            pc5.Image = tärning[0];
        }
        int HurMånga(int siffra) {
            int x = 0;
            for (int i = 0; i < prickar.Length; i++)
            {
                x += (prickar[i] == siffra) ? 1 : 0;
            }

            return x;
        }
        private void pc1_Click(object sender, EventArgs e)
        {
            if (pc1.BorderStyle == BorderStyle.None && pc1.Image != tärning[0])
            {
                pc1.BorderStyle = BorderStyle.FixedSingle;
                behåll[0] = true;

            }else
            {
                pc1.BorderStyle = BorderStyle.None;
            }
        }

        private void pc2_Click(object sender, EventArgs e)
        {
            if (pc2.BorderStyle == BorderStyle.None && pc2.Image != tärning[0])
            {
                pc2.BorderStyle = BorderStyle.FixedSingle;
                behåll[1] = true;

            }
            else
            {
                pc2.BorderStyle = BorderStyle.None;
            }
        }

        private void pc3_Click(object sender, EventArgs e)
        {
            if (pc3.BorderStyle == BorderStyle.None && pc3.Image != tärning[0])
            {
                pc3.BorderStyle = BorderStyle.FixedSingle;
                behåll[2] = true;

            }
            else
            {
                pc3.BorderStyle = BorderStyle.None;
            }
        }

        private void pc4_Click(object sender, EventArgs e)
        {
            if (pc4.BorderStyle == BorderStyle.None && pc4.Image != tärning[0])
            {
                pc4.BorderStyle = BorderStyle.FixedSingle;
                behåll[3] = true;

            }
            else
            {
                pc4.BorderStyle = BorderStyle.None;
            }
        }

        private void pc5_Click(object sender, EventArgs e)
        {
            if (pc5.BorderStyle == BorderStyle.None && pc5.Image != tärning[0])
            {
                pc5.BorderStyle = BorderStyle.FixedSingle;
                behåll[4] = true;

            }
            else
            {
                pc5.BorderStyle = BorderStyle.None;
            }
        }

        private void btnSlag_Click(object sender, EventArgs e)
        {
            if (antalSlag < 3)
            {
                for (int i = 0; i < prickar.Length; i++) {
                    if (!behåll[i]) prickar[i] = generator.Next(1, 6);
                }

                pc1.Image = tärning[prickar[0]];
                pc2.Image = tärning[prickar[1]];
                pc3.Image = tärning[prickar[2]];
                pc4.Image = tärning[prickar[3]];
                pc5.Image = tärning[prickar[4]];

                antalSlag++;

                if (antalSlag == 3)
                {
                    gbxResultat.Enabled = true;
                    btnSlag.Enabled = false;
                }
            }
        }

        private void btnVälj_Click(object sender, EventArgs e)
        {
            int indexet = lbxAlternativ.SelectedIndex;
            switch (lbxAlternativ.SelectedItem.ToString())
            {
                case "Ettor:":
                    lbxSumma.Items[indexet] = poäng[indexet] = HurMånga(1) * 1;
                    break;
                case "Tvåor:":
                    lbxSumma.Items[indexet] = poäng[indexet] = HurMånga(2) * 2;
                    break;
                case "Treor:":
                    lbxSumma.Items[indexet] = poäng[indexet] = HurMånga(3) * 3;
                    break;
                case "Fyror:":
                    lbxSumma.Items[indexet] = poäng[indexet] = HurMånga(4) * 4;
                    break;
                case "Femor:":
                    lbxSumma.Items[indexet] = poäng[indexet] = HurMånga(5) * 5;
                    break;
                case "Sexor:":
                    lbxSumma.Items[indexet] = poäng[indexet] = HurMånga(6) * 6;
                    break;
                default:
                    Console.WriteLine("Something went wrong there buddy!");
                    break;
            }
            Console.WriteLine(poäng[indexet]);
        }
    }
}
