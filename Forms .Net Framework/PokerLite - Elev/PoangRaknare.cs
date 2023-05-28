using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerLite
{
    /*  Denna klass innehåller flera egenskaper (dessa lär
        du dig mer om i nästa kapitel) som kan hämtas till andra
        klasser (men ej ändras). Dessa får sina värden från en 
        väldigt lång metodkedja som analyserar spelarens hand.   */
    class PoängRäknare
    {
        public string Namn { get; }
        public string PokerHandStr { get; }
        public int[] Resultat { get; }
        public int Poäng { get; }

        /*  Detta är en konstruktör (mer i nästa kapitel) som körs
            när en poängräknare skapas. Den tar in ett namn ("spelare 1" eller
            "spelare 2" nu, men kan bytas ut mot angivna namn i framtiden) och
            sätter igång mastodontmetoden AnalyseraHand() som ger värde åt Poäng,
            Resultat och PokerHandStr (som är en sträng som beskriver uppnådd hand) */
        public PoängRäknare(string namn, string[] hand)
        {
            Namn = namn;
            Poäng = AnalyseraHand(hand, out int[] resultat, out string pokerHand);
            Resultat = resultat;
            PokerHandStr = pokerHand;
        }

        /*  Varje kort representeras av en bokstav och ett värde. Bokstaven representerar färg (suite)
            och siffran dess värde (1-13). */
        private int AnalyseraHand(string[] hand, out int[] resultat, out string pokerHand)
        {
            // Först tas bokstaven bort från varje kort vilket lämnar en lista med kortens värden.
            resultat = TaBortKortetsFärg(hand);

            // Här letar den par eller träffar och sparar dessa i en ny lista. Samt skickar ut hur många
            // träffar som hittades.
            List<int> träffar = RäknaPar(resultat, out bool fyrtal, out bool triss, out int partal);

            // Här analyseras resultatet (hur många träffar, färg eller stege)
            int poäng = BeräknaPoäng(out pokerHand, ref resultat, hand, fyrtal, triss, partal);

            // Här läggs "träffar" och "resultat" ihop så allt hamnar i rätt ordning och med rätt värde.
            resultat = OrdnaResultat(pokerHand, träffar, resultat);

            return poäng;
        }

        //  En lista med strängar av kortens namn kommer in och en lista med värden kommer ut
        int[] TaBortKortetsFärg(string[] hand)
        {
            int[] resultat = new int[5];

            // Tar bort första tecknet (bokstaven)
            for (int i = 0; i < hand.Length; i++)
                resultat[i] = int.Parse(hand[i].Substring(1));

            // Sortering - Högt till lågt
            resultat = resultat.OrderByDescending(c => c).ToArray();

            return resultat;
        }

        //  Värdena kontrolleras och eventuella träffar skickas ut
        //  tillsammans med användbara variabler
        List<int> RäknaPar(int[] resultat, out bool fyrtal, out bool triss, out int partal)
        {
            List<int> träffar = new List<int>();
            partal = 0;
            fyrtal = false;
            triss = false;

            foreach (var res in resultat)
            {
                int par = 0;
                foreach (var övriga in resultat)
                    if (res == övriga)
                        par++;

                switch (par)
                {
                    case 4:
                        fyrtal = true;
                        träffar.Add(res);
                        break;
                    case 3:
                        triss = true;
                        träffar.Add(res);
                        break;
                    case 2:
                        partal++;
                        träffar.Add(res);
                        break;
                }
            }

            return träffar;
        }

        //  Här kontrolleras vad som uppnåddes och det skickas tillbaka i form av poäng och en sträng
        int BeräknaPoäng(out string pokerHand, ref int[] resultat, string[] hand, bool fyrtal, bool triss, int partal)
        {
            int poäng = 0;
            pokerHand = PokerHand.högt;

            //  Först kontrolleras om några par hittades och i så fall delas poäng ut
            if (fyrtal)
            {
                poäng = 7;
                pokerHand = PokerHand.Fyrtal;
            }
            else if (triss && partal > 0)
            {
                poäng = 6;
                pokerHand = PokerHand.Kåk;
            }
            else if (triss)
            {
                poäng = 3;
                pokerHand = PokerHand.Triss;
            }
            else if (partal > 2)
            {
                poäng = 2;
                pokerHand = PokerHand.Tvåpar;
            }
            else if (partal > 1)
            {
                poäng = 1;
                pokerHand = PokerHand.Par;
            }
            else
            {
                //  Om inga par hittades kan det vara stege, färg eller båda.
                bool färg = KollaOmFärg(hand);

                bool stege = KollaOmStege(ref resultat);

                if (färg && stege)
                {
                    pokerHand = KollaOmFärgstege(ref poäng, resultat);
                }
                else if (färg)
                {
                    poäng = 5;
                    pokerHand = PokerHand.Färg;
                }
                else if (stege)
                {
                    poäng = 4;
                    pokerHand = PokerHand.Stege;
                }
            }

            return poäng;
        }

        bool KollaOmFärg(string[] hand)
        {
            bool färg = true;

            // Här tas istället värdet bort och bokstaven (färg/suite) jämförs
            // med nästkommande. Om alla är samma är det färg.
            for (int i = 0; i < hand.Length - 1; i++)
                if (hand[i].Substring(0, 1) != hand[i + 1].Substring(0, 1))
                    färg = false;

            return färg;
        }

        bool KollaOmStege(ref int[] resultat)
        {
            //  Om skillnaden mellan högsta och lägsta kortet är fyra, är det en stege
            bool stege = false;
            if (resultat[0] - resultat[4] == 4)
                stege = true;
            //  Problemet är att ess kan vara 1 eller 14, så nu görs essen om till 14,
            //  korten sorteras, och samma kontroll genomförs igen. Ett ess som är del
            //  av en låg stege, ska fortsatt ha värdet 1. 
            else if (Array.Find(resultat, x => x == 1) == 1)
            {
                resultat[4] = 14;
                resultat = resultat.OrderByDescending(c => c).ToArray();
                if (resultat[0] - resultat[4] == 4)
                    stege = true;
            }
            return stege;
        }

        /*  Om det är både färg och en stege kontrollerar denna metod om det rör
            sig om en simpel färgstege eller en Royal Straight Flush (färgstege 
            med högt ess)    */
        string KollaOmFärgstege(ref int poäng, int[] resultat)
        {
            string pokerHand;

            if (resultat[0] == 14)
            {
                poäng = 9;
                pokerHand = PokerHand.RST;
            }
            else
            {
                poäng = 8;
                pokerHand = PokerHand.Färgstege;
            }

            return pokerHand;
        }

        /*  Här sammanställs resultatet så allt kommer i rätt ordning. Först ska
            alla värden som ingår i en träff av något slag komma (i storleksordning),
            följt av övriga värden (i storleksordning)    */
        int[] OrdnaResultat(string pokerHand, List<int> träffar, int[] ejTräffar)
        {
            int[] resultat = ejTräffar;
            //  Om denna är true innebär det att det inte hittats färg eller stege
            if (pokerHand != PokerHand.Stege ||
                pokerHand != PokerHand.Färg ||
                pokerHand != PokerHand.Färgstege ||
                pokerHand != PokerHand.RST)
            {
                //  Här får alla eventuella Ess, som ingår i en träff, dess rätta värde: 14
                for (int i = 0; i < träffar.Count; i++)
                    if (träffar[i] == 1)
                        träffar[i] = 14;

                //  Sorteras högt till lågt
                träffar = träffar.OrderByDescending(c => c).ToList();

                //  Här får alla eventuella Ess, som ej ingår i en träff, dess rätta värde: 14
                for (int i = 0; i < ejTräffar.Length; i++)
                    if (ejTräffar[i] == 1)
                        ejTräffar[i] = 14;

                // Sorteras högt till lågt
                ejTräffar = ejTräffar.OrderByDescending(c => c).ToArray();

                // Här läggs de värden, som ej ingår i träffar, till bakom de värden som ingår
                // i träffar.
                foreach (var värde in ejTräffar)
                    if (!träffar.Contains(värde))
                        träffar.Add(värde);

                // Här läggs allt i "träffar" (nu i rätt ordning) till "resultat"
                for (int i = 0; i < resultat.Length; i++)
                    resultat[i] = träffar[i];
            }

            return resultat;
        }
    }
}