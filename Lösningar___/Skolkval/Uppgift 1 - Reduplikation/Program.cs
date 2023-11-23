using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1___Reduplikation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ordet = Console.ReadLine();
            int.TryParse(Console.ReadLine(), out int antalUpprepningar);

            string utdata = "";

            for (int i = 0; i < antalUpprepningar; i++)
            {
                utdata += ordet;
            }

            Console.WriteLine(utdata);
            Console.ReadKey();
        }
    }
}
