using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileProviderMonthyTax
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here we will try to calculate a monthly fee for a mobile provider based on the data provided:
            // "S" package = 9.98(1y)/8.58(2y)
            // "M" package = 18.99(1y)/17.09(2y)
            // "L" package = 25.98(1y)/23.59(2y)
            //"XL" package = 35.99(1y)/31.79(2y)

            // OTHER CONDITIONS:

            // With INTERNET :
            // (Monthly fee <= 10.00) + 5.50/month
            // (Monthly fee <= 30.00) + 4.35/month
            // (Monthly fee > 30.00)  + 3.85/month

            //If contract is for 2 years , the total monthly fee ( including internet) is reduced by 3.75%!

            //Entering and reading the input

            Console.Write("Enter contract period ( one/two) : ");
            string period = Console.ReadLine();
            Console.Write("Enter contract type ( s/m/l/xl) : ");
            string type = Console.ReadLine();
            Console.Write("Enable Internet ( y/n) : ");
            string internet = Console.ReadLine();

            //LOGIC

            double fee = 0;

            if (period == "one")
            {
                switch (type)
                {
                    case "s": fee = 9.98; break;
                    case "m": fee = 18.99; break;
                    case "l": fee = 25.98; break;
                    case "xl": fee = 35.99; break;
                    default: fee = -10000000; break; // not 0 because we need to see if it went to the right case
                }
            }

            else if (period == "two")
            {
                switch (type)
                {
                    case "s": fee = 8.58; break;
                    case "m": fee = 17.09; break;
                    case "l": fee = 23.59; break;
                    case "xl": fee = 31.79; break;
                    default: fee = -10000000; break; // not 0 because we need to see if it went to the right case
                }

            }

            if(internet == "y")
            {
                if (period =="one" && fee <= 10.00) { fee = fee + 5.50; }
                else if (period == "one" && fee > 10 && fee <= 30.00) { fee = fee + 4.35; }
                else if (period == "one" && fee > 30.00) { fee = fee + 3.85; }
                else if (period == "two" && fee <= 10.00)
                {
                    fee = (fee + 5.50) - (fee + 5.50) *0.0375 ;
                }
                else if (period == "two" && fee > 10 && fee <= 30.00)
                {
                    fee = (fee + 4.35) - (fee + 5.50) * 0.0375;
                }
                else if (period == "two" && fee > 30.00)
                {
                    fee = (fee + 3.85) - (fee + 5.50) * 0.0375;
                }
            }


            Console.WriteLine(" Your monthly fee is : " + fee);

        }
    }
}
