using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicePlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblAvrg_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void setDice_ValueChanged(object sender, EventArgs e)
        {
            lblDice.Text = setDice.Value.ToString();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int runs = 0; //Thrown Dice
            int totalout = 0; //Total dice output
            int[] totals; // Totals of the different possible outputs
            while (runs != ((int)setThrows.Value)) {
                runs++;
                lblThrows.Text = runs.ToString();   //Keep track of thrown dices

                //throws and generates a random number between 0 and [setDice]
                int

            }
        }
    }
}
