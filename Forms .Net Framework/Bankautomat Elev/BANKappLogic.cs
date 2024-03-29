﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace Bankautomat
{
    public class BANKappLogic
    {
        //  Medlemsvariabler
        string inmatat = "";
        int saldo = 0;
        
        public List<string> historikInfo = new List<string>();

        //  Metoder
        //Denna metod hämtar inmatat
        public string HämtaInmatat() {
            return inmatat;
        }

        // Körs för varje interaktion, med _inmatning_ och _läge_ anser vi vad som ska hända
        public void Inmatning(Läge läge, int inmatning) {

            if (inmatning < 0 && inmatat.Length > 0)
            {
                inmatat = inmatat.Remove(inmatat.Length - 1);
            }
            else if (inmatning < 0)
            {
                inmatat = "";
                inmatning = 0; 
            }
            else if (läge != Läge.Inloggning)
            {
                inmatat += (inmatning == 0 && inmatat == "") ? "" : inmatning.ToString();
            }
            else if (läge == Läge.Inloggning && inmatat.Length < 4)
            {
                inmatat += inmatning.ToString();
            }
        }

        // Här bekräftar(bool) vi att det vi vill göra kan göras rätt till de olika lägena och skickar ut ett meddelande i msg.
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
                        if (inmatat != "")
                        {
                            Insättning(int.Parse(inmatat));
                            msg = "Insättning: " + inmatat + "kr";
                            SparaInfo(msg);
                            inmatat = "";
                            return true;
                        }
                        else { msg = ""; return true; }
                    }
                case Läge.Uttag:
                    {
                        if (inmatat == "") 
                        {
                            msg = "";
                            return true;
                        }
                        else if (Uttag(int.Parse(inmatat)))
                        {
                            msg = "Uttag: " + inmatat + "kr";
                            SparaInfo(msg);
                            inmatat = "";
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

            
        }

        // Bara lägger till värde till vårat saldo
        private void Insättning(int värde) {
            saldo += värde;
        }

        // Om vi har tillräckligt saldo så tar vi bort värde
        private bool Uttag(int värde) {
            if (saldo >= värde)
            {
                saldo -= värde;
                return true;
            }
            else return false;
        }

        // Returnerar true om inmatat stämmer med någon av pinkoderna
        private bool KontrolleraPinkod(int inmatat) {
            return (inmatat == 1234 || inmatat == 9876 || inmatat == 1337) ? true : false;
        }

        // Visar saldo om läget inte är inloggning
        public string VisaSaldo(Läge läge) {
            return (läge == Läge.Inloggning) ? "" : "Saldo: " + saldo + "kr";
        }

        //Nollställer applikationen om användaren svarar ja på att avsluta.
        public bool Avbryt() {

            if (MessageBox.Show("Är du säker?", "Avsluta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                saldo = 0;
                inmatat = "";
                return true;
            }
            else return false;
        }

        // Returnerar längden på medlemsvariablen historikInfo
        public int HämtaHistorikInfoCount() {
            return historikInfo.Count;
        }

        // Denna metod ska ta in en sträng och lägga till den i medlemsvariabeln historikInfo.
        private void SparaInfo(string Info) { 
            historikInfo.Add(Info);
        }

        // Denna metod skriver ut historiken.
        public void VisaHistorik(ListBox lbHistorik) {
            lbHistorik.Items.Clear();
            for (int i = 0; i < historikInfo.Count; i++)
            {
                lbHistorik.Items.Add(historikInfo[i]);
            }
        }

        // Metoden ska ta bort det som är markerat i listboxen
        public void TaBortEnstaka(ListBox lbHistorik) {
            if (lbHistorik.SelectedIndices.Count != 0) {
                historikInfo.RemoveAt(lbHistorik.SelectedIndex);
                VisaHistorik(lbHistorik);
            }
        }

        // Metoden ska nollställa historikInfo.
        public void TaBortAlla(ListBox lbHistorik) { 
            historikInfo = new List<string>(); 
            VisaHistorik(lbHistorik);
        }

        // tillåta att andra delar av programmet ska kunna rensa listboxen.
        public void RensaListbox(ListBox lbHistorik) {
            lbHistorik.Items.Clear();
        }

    }
}
