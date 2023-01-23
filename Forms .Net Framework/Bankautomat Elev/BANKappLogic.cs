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
            if (läge == Läge.Inloggning)
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
                    msg = "PIN ok";
                    return true;
                }
                else 
                {
                    msg = "Felaktig PIN";
                    return false;
                }
            }
            
            msg = "";
            return true;
        }
        private bool KontrolleraPinkod(int inmatat) {
            return (inmatat == 1234 || inmatat == 9876 || inmatat == 1337) ? true : false;
        }
    }
}
