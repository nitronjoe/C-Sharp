using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double n1 = 0;
            double n2 = 0;
            double answer = 0;
            Console.WriteLine("What is n1: ");
            n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("What is n2: ");
            n2 = Double.Parse(Console.ReadLine());
            answer = n1 / n2;
            Console.WriteLine("The answer is {0:0.00000}", answer);

            string message = "School of Computer Science";
            string str1 = " ";
            string str2 = " ";
            string trimmedMessage = message.Replace(str1, str2);
            Console.WriteLine(message);
            Console.WriteLine(trimmedMessage);

            int result = FindSumMultiples();
            int fibonacciSum = EvenTermsFibonacci();
            Console.WriteLine($"The sum of the even terms of Fibonacci sequence is: {fibonacciSum}");
            Console.WriteLine($"The sum of the natural numbers being multiples of 3 or 5 is: {result}");
            Console.WriteLine($"The number of letters in the string {trimmedMessage} is {trimmedMessage.Length}");
            Console.ReadKey();
        }
        static int EvenTermsFibonacci()
        {
            int limit = 4000000;
            int sum = 0;

            int fib1 = 1;
            int fib2 = 2;

            while (fib2 < limit)
            {
                if (fib2 % 2 == 0)
                {
                    sum += fib2;
                }
                int nextFib = fib1 + fib2;
                fib2 = nextFib;
            }
            return sum;
        }
        static int FindSumMultiples()
        {
            {
                int limit = 1000;
                int sum = 0;
                for (int i = 1; i < limit; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
        }
    }
}
