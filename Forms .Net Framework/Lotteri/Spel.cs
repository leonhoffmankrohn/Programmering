using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lotteri
{
    internal class Spel
    {
        List<Lottorad> dragdaLotter = new();
        Lottorad inskrivenLottorad;
        int målDragningar = 0;
        public int antalLika = 0;

        public Spel(int _dragningar, Lottorad _inskrivenLottorad)
        {
            målDragningar = _dragningar;
            inskrivenLottorad = _inskrivenLottorad;
            KörDragningar();
            KollaLika();
        }
        private void KörDragningar()
        {
            for (int i = 0; i < målDragningar; i++)
            {
                dragdaLotter.Add(new Lottorad(new int[1]));
            }
        }
        private void KollaLika()
        {
            for (int i = 0; i < dragdaLotter.Count; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (inskrivenLottorad.nummer[j] == dragdaLotter[i].nummer[j]) dragdaLotter[j].antalLika++;
                }
            }
            /* för allt i listan av lottorader(i )
            {
                för 7 gånger(j)
           {
                    Kolla om skrivenrad[j] är samma nummer som lottorader[i][j]
                  antalLika++;
                }
            }*/
        }
    }
    internal class Lottorad
    {
        public int[] nummer = new int[7];
        Random slumpare = new Random();
        public int antalLika = 0;
        public Lottorad(int[] _lottorad)
        {
            if (_lottorad.Length == 1)
            {
                for (int i = 0; i < 7; i++)
                {
                    nummer[i] = RandomNummer();
                }
            }
            else nummer = _lottorad;
        }
        public override string ToString()
        {
            string utsträng = "";
            for (int i = 0; i < nummer.Length; i++)
            {
                utsträng += nummer[i].ToString() + " ";
            }
            utsträng += "AntalLika : " + antalLika.ToString();
            return utsträng;
        }
        private int RandomNummer()
        {
            return slumpare.Next(35);
        }
    }
}
