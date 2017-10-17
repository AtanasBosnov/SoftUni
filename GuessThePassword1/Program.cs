using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            // HINT: The password is : p@ssword
            Console.WriteLine("Try to guess my password :) ");
            string enteredWord = Console.ReadLine();
            while (!enteredWord.Equals("p@ssword"))
            {
                Console.WriteLine("WRONG PASSWORD! TRY AGAIN!");
                enteredWord = Console.ReadLine();
            }

            Console.WriteLine(" ^ _ ^ YOU WON BIG! YOU GUESSED THE PASSWORD! ^ _ ^ ");

        }
    }
}
