using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusKelvin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, kelvin, fahrenheit;

            Console.Write("Enter the amount of Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            // Convert Celsius to Kelvin
            kelvin = celsius + 273;

            // Convert Celsius to Fahrenheit
            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"celsius {celsius}");
            Console.WriteLine($"kelvin {kelvin}");
            Console.WriteLine($"fahrenheit {fahrenheit}");
            Console.Read();
        }
    }
}
