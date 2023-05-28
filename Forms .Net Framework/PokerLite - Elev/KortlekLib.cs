using System;
using System.Collections.Generic;
using System.Drawing;
using System.Collections;
using System.Resources;

namespace PokerLite
{
    class KortlekLib
    {
        /*  Denna metod tar in grafik ordnat i ResourceSet-objekt.
            Den går igenom grafiken, sorterar bort baksidan och
            den tomma grafiken och lägger till resten i en lista.   */
        public List<string> SkapaKortlek(ResourceSet kortGrafik)
        {
            List<string> kortlek = new List<string>();

            foreach (DictionaryEntry grafik in kortGrafik)
            {
                if (grafik.Key.ToString() != "back" && grafik.Key.ToString() != "empty")
                    kortlek.Add(grafik.Key.ToString());
            }

            //  Listan blandas innan den skickas tillbaka
            kortlek = BlandaKortlek(kortlek, new Random());

            return kortlek;
        }

        /*  Detta är en blandare. Den är gjord för att blanda listor 
            oavsett innehåll men har här getts ett specifikt namn för
            tydlighets skull. <T> betyder att det kan vara vilken typ 
            som helst. Mycket användbart! */
        public List<T> BlandaKortlek<T>(List<T> list, Random rand)
        {
            for (int i = list.Count; i > 0; i--)
                list = Byt(list, i - 1, rand.Next(0, i));

            return list;
        }

        /*  Denna metod används av blandaren ovan och har som uppgift 
            att byta plats på två kort (eller vad nu listan innehåller).
            Här ser du ytterligare exempel på användbarheten av <T>, även
            om det faller väl utanför den här kursens innehåll.  */
        private List<T> Byt<T>(List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;

            return list;
        }

        /*  Här är metoden som parar ihop kortsträngen med rätt grafik.
            Den returnerar en Image som kan läggas i en picturebox. */
        public Image HämtaGrafik(string kort, ResourceSet kortGrafik)
        {
            foreach (DictionaryEntry grafik in kortGrafik)
                if (grafik.Key.ToString() == kort)
                    return (Image)grafik.Value;
            
            return KortGrafik.empty;
        }
    }
}
