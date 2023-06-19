using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Charge
{
    class Courier
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Distance in Kilometer : ");
            string distance = Console.ReadLine();
            int dist = Int32.Parse(distance);

            Console.WriteLine("Weight in Kg : ");
            string weight = Console.ReadLine();
            int wt = Int32.Parse(weight);

            int rate = 0;
            if (dist < 100)
                rate = 50;
            else if (dist < 200)
                rate = 65;
            else if (dist < 300)
                rate = 90;
            else 
                rate = 120;

            int totalCost = wt * rate;
            Console.WriteLine("charges : " + totalCost);
            Console.ReadLine(); 
        }
    }
}