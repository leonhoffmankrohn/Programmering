using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_2___Tre_i_rad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double begränsning);

            int antalTreiga = 0;


            bool kör = true;
            double i = 1;
            while ( kör)
            {
                double svar = ((i) * (i + 1) * (i + 2));
                if (svar < begränsning)
                {
                    antalTreiga++;
                    i++;
                }
                else kör = false;
            }
            Console.WriteLine(antalTreiga);
            Console.ReadKey();
        }
    }
}
