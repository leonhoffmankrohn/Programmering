using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            tabAllt.SelectedTab = tabPYatzy;
        }

        // Varsitt index är en tärning
        bool[] behåll = new bool[5];
        Image[] grafik = { Tärningsgrafik.d0, Tärningsgrafik.d1, Tärningsgrafik.d2, Tärningsgrafik.d3, Tärningsgrafik.d4, Tärningsgrafik.d5, Tärningsgrafik.d6 };
        int[] slag = new int[5];
        Random generator = new Random();
        int kastKvar = 3;
        int speladeSpel = 13;
        int[] resultatVärden = new int[14]; // ettor, tvåor, treor, fyror, femor, sexor, par, två-par, triss, kåk, liten-stege, stor-stege, yatzy
        int[] tagnaSvar = new int[14]; // ""--""
        bool dator = false;

        private void btnSlå_Click(object sender, EventArgs e)
        {
            PictureBox[] ramar = { pc1, pc2, pc3, pc4, pc5 };
            if (kastKvar > 0) // Kollar först om vi har något kast kvar för att kasta
            {
                // Slår tärningarna som inte vi har valt att behålla
                for (int i = 0; i < 5; i++) 
                {
                    if (!behåll[i]) slag[i] = generator.Next(1, 7);
                    ramar[i].Image = grafik[slag[i]];
                }
                kastKvar--;
                prbarKastkvar.PerformStep();
            }

            // Sätter igång resultatberäkning
            bool visaResultat = (kastKvar == 0) ? true : false;

            // Värden som ger oss resultatet
            int antalPar = 0;

            // Nollställer alla möjliga resultatvärden
            for (int i = 0; i < resultatVärden.Length; i++) resultatVärden[i] = 0;


            // Visar bara resultat om personen har slagit 3 ggr
            if (visaResultat)
            {
                // Du kan inte slå mer men du får välja och använda resultatrutan
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
                        if (i == slag[j]) lika++;
                    }

                    // Sparar antal för (1 -> 6)
                    resultatVärden[i-1] = lika * i;

                    // Detta segment kollar bara antalet lika och säger vad det innebär
                    if (lika >= 2) // Här kollar den om det finns ett par på nummer i
                    {
                        antalPar++;
                        if (antalPar == 2) { resultatVärden[7] = resultatVärden[6] + i * 2; };// Två par 
                        resultatVärden[6] = i * 2; // Största par
                    }
                    if (lika >= 3) { resultatVärden[8] = i * 3;} //Triss
                    if (lika >= 4) { resultatVärden[12] = i * 4;} // Fyrtal
                    if (lika == 5) { resultatVärden[13] = 50;  } // Yatzy
                    
                }

                // Utanför loopen eftersom de inte beror direkt på antalet lika eller nuvarande sida på tärningen.
                // Detta till hänsyn till prestanda för att skapa vana till större projekt
                if (!slag.Contains(1) && antalPar == 0) resultatVärden[11] = 20; // Stor stege
                else if(!slag.Contains(6) && antalPar == 0) resultatVärden[10] = 15; // Liten stege
                if (antalPar == 2 && resultatVärden[8] != 0) resultatVärden[9] = resultatVärden[7] - 2 * resultatVärden[8] / 3 + resultatVärden[8]; // Kåk.


                // Uppdatera grafiken för resultaten
                for (int i = 0; i < resultatVärden.Length; i++)
                {
                    lbxMöjligRes.Items[i] = resultatVärden[i];
                }
            }
        }
        private void btnVälj_Click(object sender, EventArgs e)
        {
            if (lbxVälj.SelectedIndex != -1 && int.Parse(lbxMöjligRes.Items[lbxVälj.SelectedIndex].ToString()) != 0)
            {
                // Spara valda resultat
                int index = lbxVälj.SelectedIndex;
                tagnaSvar[index] = resultatVärden[index];

                // Uppdatera grafik för lbxValdRes
                for (int i = 0; i < tagnaSvar.Length; i++) lbxValdRes.Items[i] = tagnaSvar[i];

                // Nollställ värden och tärningar
                for (int i = 0; i < resultatVärden.Length; i++)
                {
                    resultatVärden[i] = 0;
                    lbxMöjligRes.Items[i] = 0;
                }
                lbxVälj.ClearSelected();

                kastKvar = 3;
                prbarKastkvar.Value = 3;
                btnSlå.Enabled = true;
                btnVälj.Enabled = false;
                gbxResultat.Enabled = false;

                // Nollställer värdena och grafiken för tärningarna
                PictureBox[] ramar = { pc1, pc2, pc3, pc4, pc5 };
                for (int i = 0; i < slag.Length; i++)
                {
                    slag[i] = 0;
                    ramar[i].Image = grafik[0];
                    ramar[i].BorderStyle = BorderStyle.None;
                    behåll[i] = false;

                }

                speladeSpel++;
                if (speladeSpel == 14)
                {
                    dator = true;
                    tabAllt.SelectTab(1);

                    // Visa grön skärm och resultat
                    int resultat = tagnaSvar.Sum();
                    lblTotala.Text = "Grattis!\r\n" + "Du samlade totalt ihop " + resultat + " poäng!";
                    lbxAndraFörsök.Items.Add(resultat);

                    // Rensa poäng
                    for (int i = 0; i < tagnaSvar.Length; i++)
                    {
                        tagnaSvar[i] = 0;
                        lbxValdRes.Items[i] = 0;
                    }
                }

                lblOmgångar.Text = "Omgångar kvar: " + (14 - speladeSpel);
            }
            else // Varnar om man inte valt ett resultat
            {
                MessageBox.Show("Sorry, men du måste välja ett resultat att spara...");

            }
        }

        private void tabAllt_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //Tillåter inte att spelaren byter tabb
            e.Cancel = (speladeSpel == 14 && dator) ? false : true;
            dator = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            //      Ändra visible på allt till true
            dator = true;
            tabAllt.SelectTab(0);
            speladeSpel = 0;

            lblOmgångar.Text = "Omgångar kvar: 14";
        }

        private void btnStäng_Click(object sender, EventArgs e)
        {
            Close();
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
