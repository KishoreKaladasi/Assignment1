using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int x = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i % 2 == 0)
                        Console.Write($"{x} ");
                   
                }
                if (i % 2 == 1)
                {
                    Console.Write($"{x}{x}{x}{x}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
