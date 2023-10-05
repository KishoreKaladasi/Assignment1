using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysWeeksYears
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of days: ");
            int totalDays = int.Parse(Console.ReadLine());

            int years = totalDays / 365;
            int weeks = (totalDays % 365) / 7;
            int days = (totalDays % 365) % 7;

            Console.WriteLine("Years: " + years);
            Console.WriteLine("Weeks: " + weeks);
            Console.WriteLine("Days: " + days);
            Console.Read();
        }
    }
}
