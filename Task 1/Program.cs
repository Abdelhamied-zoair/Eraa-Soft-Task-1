using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // welcome message for user 
            Console.WriteLine("Welcome To Islam laundry For Carpets");
            Console.WriteLine("There is a 6% state-imposed sales tax rate for 30 days");
            Console.WriteLine("Please Enter The Count Of Small Carpets");
            /* counter the varibale hold the value for the small carpet*/
            int Counter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Counter} " + " The price per for small carpet is 25$ ");
            int price = 25; // Price variable holds the value of one small Carpet
            int cost = price * Counter; // cost is a Variable calculates the number of carpets * its price
            Console.WriteLine($"Carpet Washing Cost Is {cost}");
            /* counter2 the varibale hold the value for the large carpet */
            Console.WriteLine("Please Enter The Count Of Large Carpets");
            int Counter2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Counter2} " + " The price per for Large carpet is 35$ ");
            int price2 = 35; // Price2 variable holds the value of one large Carpet
            int cost2 = price2 * Counter2; // cost2 is a Variable calculates the number of carpets * its price
            Console.WriteLine($"Carpet Washing Cost Is {cost2}");
            int totalcost = cost + cost2; // totalcost variable calculate the price of cost1 , cost2 
            double tax;
            tax = 0.06;   // tax varibale hold the 6% state-imposed sales tax rate for 30 days 
            Console.WriteLine($"The Total Estimate Is {totalcost  + tax}");
        }
    }
}
