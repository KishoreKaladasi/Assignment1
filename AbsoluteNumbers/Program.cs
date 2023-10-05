using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double absoluteDifference = Math.Abs(num1 - num2);
             

            if (num1 > num2)
            {
                double result = 2 * absoluteDifference;
                Console.WriteLine($"Double the absolute difference: {result}");
            }
            else
            {
                Console.WriteLine($"Absolute difference: {absoluteDifference}");
                Console.Read();
            }
            Console.ReadLine();
        }
    }
}
