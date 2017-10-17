using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings1stAndLastName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your FIRST name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your LAST name : ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your hometown : ");
            string town = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {lastName} , {age} years old from {town}.");


        }
    }
}
