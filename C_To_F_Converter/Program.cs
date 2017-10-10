using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _C_To__F_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Celsius degrees : ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine("The temperature in Fahrenheit is : {0}", (celsius * 1.8) + 32);
        }
    }
}
