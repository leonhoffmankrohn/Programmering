using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bankautomat
{
    public partial class Form1 : Form
    {
        void StängAvOchSättPåFunktioner(Metod metod, out int count, out bool avbryt, out string msg)
        {
            count = 0;
            avbryt = false;
            msg = "";

            // Metoder del 3:

            /*  TA BORT DENNA RAD NÄR DU SKA SKRIVA Avbryt OCH VisaSaldo
            
            if (metod == Metod.Avbryt)
                avbryt = uppgift.Avbryt();
            else if (metod == Metod.Saldo)
                msg = uppgift.VisaSaldo(läge);

            */  // OCH DENNA RAD (hint, använd CTRL+X)


            /* TA BORT DENNA RAD NÄR DU SKA BÖRJA MED SAMLINGAR
            
            switch (metod)
            {
                case Metod.Enstaka:
                    uppgift.TaBortEnstaka(lbHistorik);
                    break;
                case Metod.Rensa:
                    uppgift.RensaListbox(lbHistorik);
                    break;
                case Metod.HistorikCount:
                    count = uppgift.HämtaHistorikInfoCount();
                    break;
                case Metod.TaBortAlla:
                    uppgift.TaBortAlla(lbHistorik);
                    break;
                case Metod.Historik:
                    uppgift.VisaHistorik(lbHistorik);
                    break;
                case Metod.Avbryt:
                    uppgift.TaBortAlla(lbHistorik);
                    break;
            }
            
             */ // TA ÄVEN BORT DENNA RAD NÄR DU BÖRJAR MED SAMLINGAR
        }




        private BANKappLogic uppgift;
        private Läge läge;

        public Form1()
        {
            InitializeComponent();
            uppgift = new BANKappLogic();
            SättVal(Läge.Inloggning);
            UppdateraDisplay();
            NollställMsg();
        }

        private void Inmatning(int värde)
        {
            NollställMsg();
            if (läge == Läge.Historik)
                StängAvOchSättPåFunktioner(Metod.Enstaka, out int count, out bool avbryt, out string msg);
            else
                uppgift.Inmatning(läge, värde);

            UppdateraDisplay();
        }

        private void Bekräfta()
        {
            bool pinOK = uppgift.Bekräfta(läge, out string msg);
            
            
            if (pinOK && läge == Läge.Inloggning)
            {
                btnInsättning.Enabled = true;
                btnUttag.Enabled = true;
                SättVal(Läge.Insättning);
            }
            else if (läge == Läge.Historik)
            {
                StängAvOchSättPåFunktioner(Metod.Rensa, out int count, out bool avbryt, out string msg1);
                btnInsättning.Enabled = true;
                btnUttag.Enabled = true;
                btnSaldo.Enabled = true;
                btnHistorik.Enabled = true;
                SättVal(Läge.Insättning);
            }
            else
            {
                StängAvOchSättPåFunktioner(Metod.HistorikCount, out int count, out bool avbryt, out string msg2);
                if (count > 0)
                    btnHistorik.Enabled = true;
                else
                    btnHistorik.Enabled = false;

                if (läge != Läge.Inloggning)
                    btnSaldo.Enabled = true;
    
                lblMsg.Text = msg;
            }
            UppdateraDisplay();
        }

        private void UppdateraDisplay()
        {
            if (läge == Läge.Inloggning)
            {
                lblInmatning.Text = "Ange PIN-kod:\r\n";
                for (int i = 0; i < uppgift.HämtaInmatat().Length; i++)
                    lblInmatning.Text += "*";
            }
            else if (läge == Läge.Historik)
            {
                lblInmatning.Text = "";
            }
            else
            {
                lblInmatning.Text = "Belopp:\r\n" + uppgift.HämtaInmatat();
            }
        }

        private void NollställMsg()
        {
            lblMsg.Text = "";
        }

        private void SättVal(Läge nyttVal)
        {
            läge = nyttVal;
            lblVal.Text = nyttVal.ToString();
            UppdateraDisplay();
        }

        private void Avbryt()
        {
            if (läge == Läge.Historik)
            {
                StängAvOchSättPåFunktioner(Metod.TaBortAlla, out int count, out bool avbryt, out string msg);
                btnInsättning.Enabled = true;
                btnUttag.Enabled = true;
                btnSaldo.Enabled = true;
                läge = Läge.Insättning;
            }
            else
            {
                StängAvOchSättPåFunktioner(Metod.Avbryt, out int count, out bool avbryt, out string msg1);
                if (avbryt)
                {
                    SättVal(Läge.Inloggning);
                    NollställMsg();
                }
                UppdateraDisplay();
            }
        }

        private void VisaSaldo()
        {
            StängAvOchSättPåFunktioner(Metod.Saldo, out int count, out bool avbryt, out string msg);
            lblMsg.Text = msg;
        }

        // UPPGIFT 2

        private void Historik()
        {
            btnInsättning.Enabled = false;
            btnHistorik.Enabled = false;
            btnInsättning.Enabled = false;
            btnUttag.Enabled = false;
            btnSaldo.Enabled = false;
            lblInmatning.Text = "";
            SättVal(Läge.Historik);
            StängAvOchSättPåFunktioner(Metod.Historik,out int count, out bool avbryt, out string msg);
        }

        #region Klickhändelser
        private void btn1_Click(object sender, EventArgs e)
        {
            Inmatning(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Inmatning(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Inmatning(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Inmatning(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Inmatning(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Inmatning(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Inmatning(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Inmatning(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Inmatning(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Inmatning(0);
        }

        private void btnBacka_Click(object sender, EventArgs e)
        {
            Inmatning(-1);
        }

        private void btnKlar_Click(object sender, EventArgs e)
        {
            Bekräfta();
        }

        private void btnInsättning_Click(object sender, EventArgs e)
        {
            if (läge != Läge.Inloggning)
                SättVal(Läge.Insättning);
        }

        private void btnUttag_Click(object sender, EventArgs e)
        {
            if (läge != Läge.Inloggning)
                SättVal(Läge.Uttag);
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            VisaSaldo();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
            switch (e.KeyChar)
            {
                case '0': Inmatning(0); break;
                case '1': Inmatning(1); break;
                case '2': Inmatning(2); break;
                case '3': Inmatning(3); break;
                case '4': Inmatning(4); break;
                case '5': Inmatning(5); break;
                case '6': Inmatning(6); break;
                case '7': Inmatning(7); break;
                case '8': Inmatning(8); break;
                case '9': Inmatning(9); break;
                case (char)Keys.Back: Inmatning(-1); break;
                case (char)Keys.Escape: Avbryt(); break;
            }
        }


        private void btnStopp_Click(object sender, EventArgs e)
        {
            Avbryt();
        }

        private void btnHistorik_Click(object sender, EventArgs e)
        {
            Historik();
        }

        private void lbHistorik_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.DarkBlue);//Choose the color

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(lbHistorik.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
        #endregion
    }
}
