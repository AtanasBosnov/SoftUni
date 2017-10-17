using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeekSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input a number from 1 to 7 included and the corresponding day of the week will appear in a string.
            Console.Write("Enter a number between 1 and 7 and the corresponding day of the week will appear in letters! : ");
            int dayOfWeek = int.Parse(Console.ReadLine());

            switch(dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("You didn't enter a number between 1 and 7. Exit and try again!");
                    break;

            }
        }
    }
}
