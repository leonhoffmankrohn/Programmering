using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangelarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double.TryParse(input.Split(' ')[0], out double bas);
            double.TryParse(input.Split(' ')[1], out double höjd);
            Console.WriteLine(bas * höjd / 2);
        }
    }
}
