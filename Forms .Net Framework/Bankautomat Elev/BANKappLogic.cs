using System.Collections.Generic;
using System.Windows.Forms;

namespace Bankautomat
{
    public class BANKappLogic
    {
        //  Medlemsvariabler
        string inmatat = "";
        int saldo = 0;

        //  Metoder
        public string HämtaInmatat() {
            return inmatat;
        }
        public void Inmatning(Läge läge, int inmatning) {
            if (inmatning < 0 && inmatat.Length > 0)
            {
                inmatat = inmatat.Remove(inmatat.Length - 1);
            }
            else if (läge != Läge.Inloggning) 
            {
                inmatat += (inmatning == 0 && inmatat == "") ? "" : inmatning.ToString();
            }
            else if (läge == Läge.Inloggning && inmatat.Length < 4)
            {
                inmatat += inmatning.ToString();
            }
            else if (inmatat.Length == 4)
            {
                // Kom tillbaka hit sen

            }
        }
        public bool Bekräfta(Läge läge, out string msg) {
            switch (läge) {
                case Läge.Inloggning:
                    if (inmatat.Length == 4 && KontrolleraPinkod(int.Parse(inmatat)))
                    {
                        inmatat = "";
                        msg = "PIN ok";
                        return true;
                    }
                    else
                    {
                        inmatat = "";
                        msg = "Felaktig PIN";
                        return false;
                    }
                case Läge.Insättning:
                    {
                        Insättning(int.Parse(inmatat));
                        msg = "Insättning: " + inmatat + "kr";
                        inmatat = "";
                        return true;
                    }
                case Läge.Uttag:
                    {
                        bool lyckat = Uttag(int.Parse(inmatat));
                        if (lyckat)
                        {
                            msg = "Uttag: " + inmatat + "kr";
                            return true;
                        }
                        else
                        {
                            msg = "Otillräckligt saldo";
                            return false;
                        }
                    }
                default:
                    msg = "";
                    return true;

            }
            /*if ((läge == Läge.Inloggning) && (inmatat.Length == 4))
            {
                if (KontrolleraPinkod(int.Parse(inmatat)))
                {
                    inmatat = "";
                    msg = "PIN ok";
                    return true;
                }
                else if (inmatat == "")
                {
                    msg = "";
                    return true;
                }
            else if (läge == Läge.Insättning)
                {
                    Insättning(int.Parse(inmatat));
                    msg = "Insättning: " + inmatat + "kr";
                    inmatat = "";
                    return true;
                }
            else if (läge == Läge.Uttag)
                {
                    bool lyckat = Uttag(int.Parse(inmatat));
                    if (lyckat)
                    {
                        msg = "Uttag: " + inmatat + "kr";
                        return true;
                    }
                    else
                    {
                        msg = "Otillräckligt saldo";
                        return false;
                    }
                }
                else 
                { 
                    msg = ""; 
                    return true; 
                }
            }
            else
            {
                inmatat = "";
                msg = "Felaktig PIN";
                return false;
            }*/
            
        }
        private void Insättning(int värde) {
            saldo += värde;
        }
        private bool Uttag(int värde) {
            if (saldo >= värde)
            {
                saldo -= värde;
                return true;
            }
            else return false;
        }
        private bool KontrolleraPinkod(int inmatat) {
            return (inmatat == 1234 || inmatat == 9876 || inmatat == 1337) ? true : false;
        }
        public string VisaSaldo(Läge läge) {
            return (läge == Läge.Inloggning) ? "" : "Saldo: " + saldo + "kr";
        }
        public bool Avbryt() {
            if (MessageBox.Show("Är du säker?", "Avsluta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                saldo = 0;
                inmatat = "";
                return true;
            }
            else return false;
        }
    }
}
