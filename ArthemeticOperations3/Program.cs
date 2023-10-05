using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthemeticOperations3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = (a+b);

            if (a == b)
            {
                Console.WriteLine($"the entered two integers are same then triple of the sum of two integers {3*c}"); 
            }
            else
            {
                Console.WriteLine(c);
            }
            Console.WriteLine($"the sum of the two integers is {c}");
            Console.ReadLine();
        }
    }
}
