using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_5___Pickle_Clicker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int antalByggnader);
            int.TryParse(Console.ReadLine(), out int kostnadMegapickle);

            List<int> proHastighet = new List<int>();
            List<int> prisByggnad = new List<int>();
            for (int i = 0; i < antalByggnader; i++)
            {
                string byggnad = Console.ReadLine();
                int.TryParse(byggnad.Split(' ')[0], out int hast);
                int.TryParse(byggnad.Split(' ')[0], out int pris);
                proHastighet[i] = hast;
                prisByggnad[i] = pris;
            }

            int pengar = 0;
            int tjänarPerSekund = 0;
            List<int> byggnaderÄgda = new List<int>();
            byggnaderÄgda[0] = 1;

            Console.WriteLine(tjänarPerSekund);
            Console.ReadKey();

        }
    }
}
