using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingSecondsToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 Runners do a sprint . The sprint is short so everyone is doing it in seconds. 
            //Add their times and display the result in minutes.

            Console.WriteLine("Enter the 3 runners times : ");
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int totalTime = time1 + time2 + time3;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;
            if (seconds < 10)
            {
                Console.WriteLine("The total time of the runners is {0}:0{1}", minutes, seconds);
            }
            else
            {
                Console.WriteLine("The total time of the runners is {0}:{1}", minutes, seconds);
            }

        }
    }
}
