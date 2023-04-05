using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise_7_14_2021
{
    class Program
    {
        static void Main()
        {
            Encoding();
        }
        private static void Encoding()
        {
            string userInput;
            Write("Enter a phrase: ");  //request user input
            userInput = ReadLine();
            var replacement = ("");
            for (int i = 0; i < userInput.Length; ++i)  //keeps loop within length of input
            {
                replacement = userInput.Replace("a", "4").Replace("e", "3").Replace("i", "1");
            }
            WriteLine(replacement);
        }
    }
}
