using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthemeticOperations
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operation (+, -, *, /, %): ");
            char operation = Convert.ToChar(Console.ReadLine());

            

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                case '%':
                    Console.WriteLine($"{num1} mod {num2} = {num1 % num2}");
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
            Console.ReadLine();
        }
        


    }
}
 
