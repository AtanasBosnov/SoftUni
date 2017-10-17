using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingANumberEqualToTheSumOfAllTheNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a console program calculating the inputed count of number by summing them and then comparing
            // whether the biggest number is equal to the sum excluding the biggest number from it 
            //(( biggest number - (sum - biggest number)) == 0

            Console.WriteLine("Enter the count of the numbers : ");
            int count = int.Parse(Console.ReadLine());

            int sum = 0;
            int biggestNum = 0;

            for(int i = 0; i <count; i ++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;
                if(currentNum>biggestNum)
                {
                    biggestNum = currentNum;
                }

            }
            if (((biggestNum*2) - sum)==0)
            {
                Console.WriteLine("Yes , there is a number equal to the sum of all the numbers which is : " + biggestNum);
                Console.WriteLine("The sum is : " + sum);
            }
            else
            {
                Console.WriteLine("No , there isn't a number equal to the sum of all the numbers!" );
                Console.WriteLine("The sum is : " + sum);

            }
        }
    }
}
