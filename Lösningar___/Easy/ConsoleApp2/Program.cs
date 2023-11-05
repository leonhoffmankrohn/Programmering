using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Vikingahackare, vi får in definitioner till binära tal och 
             * sedan en fras som vi ska översätta med hälp av definitionerna
             * 
             * första input kommer att vara hur många definitioner vi vet
             * sen kommer definitionerna
             * sen kommer frasen som vi ska översätta
             * 
             */

            // Nu är aplha och definitioners index motsvarande.
            Begin(out char[] alpha, out string[] definitions);

            // Hämtar antalet definitioner som vi vet om från början
            bool clear = int.TryParse(Console.ReadLine(), out int numDefs);
            if (!clear) Environment.Exit(0);

            // Här hämtar vi definitionerna till definitions arrayen
            GetDefinitions(numDefs, alpha, definitions);

            // Här gör vi en översättning av strängen
            string translation = Translate(alpha, definitions);

            // Här skriver vi ut translerade meddelandet:
            Console.WriteLine(translation);
            Console.ReadKey();
        }
        static string Translate(char[] alpha, string[] definitions)
        {
            string input = Console.ReadLine();
            string output = "";
            int lengthOfFrase = input.ToString().Length / 4;
            for (int i = 0; i < lengthOfFrase; i++)
            {
                int index = Array.IndexOf(definitions, input.Substring(i * 4, 4));
                if (index == -1) output += "?";
                else output += alpha[index];
            }
            return output;
        }
        static void GetDefinitions(int numberOfDefs, char[] alpha, string[] definitions)
        {
            for (int i = 0; i < numberOfDefs; i++)
            {
                string input = Console.ReadLine();
                char alphakey = input[0];
                int index = Array.IndexOf(alpha, alphakey);
                definitions[index] = input.Substring(2);
            }
        }
        static void Begin(out char[] a, out string[] b)
        {
            string alphabethstring = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            a = alphabethstring.ToCharArray();
            b = new string[alphabethstring.Length];
        }
    }
}
