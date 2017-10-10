using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreYouGettingScolarship
{
    class Program
    {
        static void Main(string[] args)
        {
            //Are you getting Scolarship? There are 2 types : Social and Excellence Scolarship.
            //To get Social Scolarship (35% of the minimum salary): Your income should be below the minimum salary
            //and you need grade higher than 4.5
            //To get Excellence Scolarship(25* the grade) : Grade >= 5.5 
            //The currency is in EUR ( for example)

            Console.Write("Enter your income : ");
            double income = double.Parse(Console.ReadLine());

            Console.Write("Enter your grade : ");
            double grade = double.Parse(Console.ReadLine());

            Console.Write("Enter the minimum salary : ");
            double minSalary = double.Parse(Console.ReadLine());

            if (grade >= 5.5)
            {
                double scolarship = grade * 25;
                Console.WriteLine("You get EXCELLENCE Scolarship in the amount of : " + scolarship + " EUR.");
            }
           else if (grade > 4.5 && income < minSalary)
            {
                double scolarship = minSalary * 0.35;
                Console.WriteLine("You get SOCIAL Scolarship in the amount of : " + scolarship + " EUR.");
            }
            else
            {
                Console.WriteLine("Sorry , you are not entitled to a scolarship.");
            }

        }
    }
}
