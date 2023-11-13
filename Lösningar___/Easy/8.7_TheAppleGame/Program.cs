using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._7_TheAppleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int value = int.Parse(input) / 2;
            if (value % 2 == 0) Console.WriteLine("alf");
            else Console.WriteLine("beata");
            Console.ReadKey();
        }
    }
}
