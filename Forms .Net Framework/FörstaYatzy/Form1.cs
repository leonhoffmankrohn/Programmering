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

            //
        }
    }
}
