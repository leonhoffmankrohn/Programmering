using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndraYatzy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Varsitt index är en tärning
        bool[] behåll = new bool[5];
        Image[] grafik = { Tärningsgrafik.d0, Tärningsgrafik.d1, Tärningsgrafik.d2, Tärningsgrafik.d3, Tärningsgrafik.d4, Tärningsgrafik.d5, Tärningsgrafik.d6 };
        int[] slag = new int[5];
        Random generator = new Random();
        int kastKvar = 3;

        private void btnSlå_Click(object sender, EventArgs e)
        {
            if (kastKvar > 0) // Kollar först om vi har något kast kvar för att kasta
            {
                // Slår tärningarna som inte vi har valt att behålla
                for (int i = 0; i < 5; i++) 
                {
                    if (!behåll[i]) slag[i] = generator.Next(1, 7);
                }
                kastKvar--;
            }

            // Sätter igång resultatberäkning
            bool visaResultat = (kastKvar == 0) ? true : false; 

            // Värden som ger oss resultatet
            bool[] nummerFinns = new bool[7];
            int antalPar = 0;
            bool triss = false;
            bool fytal = false;
            bool yatzy = false;
            int poäng = 0;


            /* !!!### FIXA SÅ ATT VARJE POÄNG HAR ETT INDEX SOM MOTSVARAR EN LISTBOX-ITEM ###!!! */
            if (visaResultat)
            {
                btnSlå.Enabled = false;
                gbxResultat.Enabled = true;
                btnVälj.Enabled = true;

                // Loopar för varje möjlig sida
                for (int i = 1; i <= 6; i++) 
                {
                    int lika = 0;

                    // loopar de tärningar vi har för att se om de matchar
                    for (int j = 0; j < slag.Length; j++) 
                    {
                        // Kollar om det slagits ett speciellt nummer
                        nummerFinns[i] = (slag[j] == i) ? true : false; 
                        if (i == slag[j]) lika++; 
                    }

                    // Detta segment kollar bara antalet lika och säger vad det innebär
                    if (lika == 2) { antalPar++; poäng += i * 2; }
                    else if (lika == 3) { triss = true; poäng += i * 3; }
                    else if (lika == 4) { fytal = true; poäng += i * 4; }
                    else if (lika == 5) { yatzy = true; poäng += 50; }
                }
            }

            // Beräkna alla olika möjliga resultat

            /* siffrapoäng[], kåk, triss, tvåpar, fyrtal, par, yatzy
             * 
             */

            // Uppdaterar grafiken
            PictureBox[] ramar = { pc1, pc2, pc3, pc4, pc5 };
            for (int i = 0; i < slag.Length; i++)
            {
                ramar[i].Image = grafik[slag[i]];
            }
        }

        // Här kommer alla olika tärningar och hur vi sparar dem till nästa slag 
        private void pc1_Click(object sender, EventArgs e)
        {
            if (pc1.BorderStyle == BorderStyle.None && kastKvar < 3)
            {
                behåll[0] = true;
                pc1.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                behåll[0] = false;
                pc1.BorderStyle = BorderStyle.None;
            }
        }

        private void pc2_Click(object sender, EventArgs e)
        {
            if (pc2.BorderStyle == BorderStyle.None && kastKvar < 3)
            {
                behåll[1] = true;
                pc2.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                behåll[1] = false;
                pc2.BorderStyle = BorderStyle.None;
            }
        }

        private void pc3_Click(object sender, EventArgs e)
        {
            if (pc3.BorderStyle == BorderStyle.None && kastKvar < 3)
            {
                behåll[2] = true;
                pc3.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                behåll[2] = false;
                pc3.BorderStyle = BorderStyle.None;
            }
        }

        private void pc4_Click(object sender, EventArgs e)
        {
            if (pc4.BorderStyle == BorderStyle.None && kastKvar < 3)
            {
                behåll[3] = true;
                pc4.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                behåll[3] = false;
                pc4.BorderStyle = BorderStyle.None;
            }
        }

        private void pc5_Click(object sender, EventArgs e)
        {
            if (pc5.BorderStyle == BorderStyle.None && kastKvar < 3)
            {
                behåll[4] = true;
                pc5.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                behåll[4] = false;
                pc5.BorderStyle = BorderStyle.None;
            }
        }

    }
}
