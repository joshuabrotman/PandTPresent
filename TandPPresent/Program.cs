using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TandPPresent
{
    class Program
    {
        static void Main(string[] args)
        {

            int t = 0;
            int p = 0;
            Console.WriteLine("Please enter a string containing p and t characters.");
            string userInput = Console.ReadLine();

            foreach(char i in userInput)
            {
                if (i == 't') { t++; }
                if (i == 'p') { p++; }
            }

            Console.WriteLine("Total T's:" + t);
            Console.WriteLine("Total P's:" + p);
            Console.ReadKey();

        }
    }
}
