using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3___Meddelande
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int antalRader);
            int.TryParse(Console.ReadLine(), out int antalKolumner);

            List<string> rader = new List<string>();

            for (int i = 0; i < antalRader; i++)
            {
                rader.Add(Console.ReadLine());
            }

            bool kör = true;
            int kol = 0;
            int rad = 0;
            string utdata = "";
             

            while (kör)
            {
                for (int i = kol; i < antalKolumner; i++)
                {
                    if (rader[rad][i] != '.')
                    {
                        utdata += rader[rad][i];

                        kol = i;
                    }
                }

                if (rad == antalRader-1) kör = false;
                rad++;
            }
            Console.WriteLine(utdata);
            Console.ReadKey();
        }
    }
}
