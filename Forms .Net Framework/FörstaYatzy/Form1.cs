using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FörstaYatzy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnKasta_Click(object sender, EventArgs e)
        {
            
            // Generera nya tärningsnummer
            Random nyttSlag = new Random();
            int[] slag = new int[5];

            for (int i = 0; i < slag.Length; i++)
            {
                slag[i] = nyttSlag.Next(1, 7);
            }


            // Definera grafiken till tärningsnummrena
            PictureBox[] tärningsBoxar = {pc1, pc2, pc3, pc4, pc5};
            Image[] tärningsBilder = { tärningsGrafik.d0, tärningsGrafik.d1, tärningsGrafik.d2, tärningsGrafik.d3, tärningsGrafik.d4, tärningsGrafik.d5, tärningsGrafik.d6 };

            for (int i = 0; i < tärningsBoxar.Length; i++)
            {
                tärningsBoxar[i].Image = tärningsBilder[slag[i]];
            }


            // Definerar variabler som behövs till resultatet.
            int antalPar = 0;
            bool triss = false;
            bool fyrtal = false;
            bool yatzy = false;
            int poäng = 0;


            // Kollar för varje sida på en tärning
            for (int i = 1; i <= 6; i++) 
            {
                int partal = 0;
                for (int j = 0; j < 5; j++) // Kollar alla slagna tärningar om dem är lika med en sida^^
                {
                    if (i == slag[j]) partal++;
                    else continue;
                }
                // Ger oss svar om antal lika ger ett par, triss, fyrtal eller yatzy
                if (partal == 2) { antalPar++; poäng += i * 2; }
                else if (partal == 3) { triss = true; poäng += i * 3; }
                else if (partal == 4) { fyrtal = true; poäng += i * 4; }
                else if (partal == 5) { yatzy = true; poäng += 50; }

            }
            
            /* Denna säger vad för resultat som ska visas, så om yatzy = true så kommer också
               fytal = true, Men vi vill skriva ut högsta. Detta löser vi genom att hoppa över
               allting annat om yatzy är sann. 
            */
            if (yatzy) lblResultat.Text = "YATZY :" + poäng;
            else if (fyrtal) lblResultat.Text = "Fyrtal :" + poäng;
            else if (triss && antalPar == 1) lblResultat.Text = "Kåk :" + poäng;
            else if (triss) lblResultat.Text = "Triss :" + poäng;
            else if (antalPar > 1) lblResultat.Text = "Två par :" + poäng;
            else if (antalPar == 1) lblResultat.Text = "Par :" + poäng;
            else if (!slag.Contains(6)) lblResultat.Text = "Liten stege :" + 15;
            else if (!slag.Contains(1)) lblResultat.Text = "Stor stege :" + 20;
            else lblResultat.Text = "Inga poäng";
        }
    }
}
