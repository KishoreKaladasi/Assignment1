using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxAndMinNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your first number here");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your second number here");
            int b = Convert.ToInt32(Console.ReadLine());

            int maximumNumber = Math.Max(a,b);
            int minimumNumber = Math.Min(a,b);

            Console.WriteLine($"Maximum number: {maximumNumber}");
            Console.WriteLine($"Minimum number: {minimumNumber}");
            Console.Read();

        }
    }
}
