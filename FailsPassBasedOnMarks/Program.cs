using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FailsPassBasedOnMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your maths marks here");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your  English marks here");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your  science marks here");
            int z = Convert.ToInt32(Console.ReadLine());

            int total = (x + y + z);
            double percentage = (total/300.0) * 100;
            Console.WriteLine($"total marks is {total}");
            Console.WriteLine($"percentage of marks is {percentage}");

            if (percentage < 35)
            {
                Console.WriteLine("you are failed in the exams");
            } 
            else if (percentage >35 && percentage < 45)
            {
                Console.WriteLine("you are passed and you got thirdclass");
            }
            else if (percentage > 45 && percentage < 60)
            {
                Console.WriteLine("you are passed and you got secondclass");
            }
            else
            {
                Console.WriteLine("you are passed and you got  firstclass");
            }

            Console.ReadLine();

        }
    }
}
