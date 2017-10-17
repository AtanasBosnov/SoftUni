using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCentimetersCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the inches you want to convert into centimeters : ");
            double inches = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} inches = {1} centimeters", inches, inches * 2.54);
        }
    }
}
