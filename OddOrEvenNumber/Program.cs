using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number (integer) and I will decide if it is EVEN or ODD : ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number you entered is EVEN! :) ");
            }
            else
            {
                Console.WriteLine("The number you entered is ODD! :) ");
            }
            
        }
    }
}
