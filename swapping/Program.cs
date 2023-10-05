using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"numbers before swapping x={x},y= {y}");

            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"numbers After swapping x={x},y= {y}");


            Console.ReadLine();
           


              

        }
    }
}
