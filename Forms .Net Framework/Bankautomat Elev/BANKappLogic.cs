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
            if ((läge == Läge.Inloggning) && (inmatat.Length == 4))
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
            }
            else
            {
                inmatat = "";
                msg = "Felaktig PIN";
                return false;
            }
            
        }
        private void Insättning(int värde) {
            saldo += värde;
        }
        private bool Uttag(int värde) {
            if (saldo > värde)
            {
                saldo -= värde;
                return true;
            }
            else return false;
        }
        private bool KontrolleraPinkod(int inmatat) {
            return (inmatat == 1234 || inmatat == 9876 || inmatat == 1337) ? true : false;
        }
    }
}
