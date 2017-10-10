using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading the input from the console and saving it into variables

            Console.Write("Enter your current currency : ");
            string from = Console.ReadLine();
            Console.Write("Enter the amount of it : ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the currency you want to convert in : ");
            string to = Console.ReadLine();
           
            //Logic

            var uriString= string.Format("http://finance.yahoo.com/d/quotes.csv?s={0}{1}=X&f=l1", from, to);
            string response = new WebClient().DownloadString(uriString);
            decimal rating = decimal.Parse(response, System.Globalization.CultureInfo.InvariantCulture);
            decimal finalResult = rating*amount;
            
            // Printing final result

            Console.WriteLine("" + finalResult);

        }

       
    }
}
