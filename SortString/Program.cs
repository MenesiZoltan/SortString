using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "My name is Luballo Lubido lulugan of the Lulen people.";
            string[] words = testString.Split(' ');

            ArrayPrinter(words);

            Array.Sort(words);

            ArrayPrinter(words);

            string s = string.Join(" ", words);

            Console.WriteLine("\n" + s);

            Console.ReadLine();

            
        }

        public static void ArrayPrinter(string[] words) {

            Console.WriteLine("\n");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
           


        }
    }
}
