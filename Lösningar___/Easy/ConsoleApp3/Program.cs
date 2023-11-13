using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int.TryParse(input.Split(' ')[0], out int numOfSticks);
            int.TryParse(input.Split(' ')[1], out int numOfConditions);

            List<int> weighted = new List<int>();
            for (int i = 0; i < numOfSticks; i++)
            {
                weighted.Add(0);
            }

            for (int i = 0; i < numOfConditions; i++)
            {
                input = Console.ReadLine();
                int.TryParse(input.Split(' ')[1], out int underStick);
                weighted[underStick]++;
            }

            int number = 0;
            while (weighted.Count > 0)
            {
                int index = weighted.IndexOf(number);
                if (index != -1)
                {
                    Console.WriteLine(index+1);
                    weighted.RemoveAt(index);
                }
                else number++;
            }
            Console.ReadKey();
        }
    }
}
