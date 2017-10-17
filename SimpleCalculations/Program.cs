using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the side lenght of the square : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("The face of the square is : {0}", a * a);
        }
    }
}
