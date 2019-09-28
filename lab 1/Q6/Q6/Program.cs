using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    //6.	Write a program that takes two numbers as input and an operator as input.Using the switch statement,
    //      the program should calculate the result when the operator is applied on the two input numbers.
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;
            string o;
            Console.WriteLine("enter first number ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the operater ");
            o = Console.ReadLine();
            switch (o)
            {
                case "+":
                    Console.WriteLine("answer of " + (n1 + n2));
                    break;
                case "-":
                    Console.WriteLine("answer of " + (n1 - n2));
                    break;
                case "*":
                    Console.WriteLine("answer of " + (n1 * n2));
                    break;
                case "/":
                    Console.WriteLine("answer of " + (n1 / n2));
                    break;
                default:
                    Console.WriteLine("try again");
                    break;
            }
        }
    }
}
