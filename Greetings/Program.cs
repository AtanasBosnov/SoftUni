using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name here : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name} !");
        }
    }
}
