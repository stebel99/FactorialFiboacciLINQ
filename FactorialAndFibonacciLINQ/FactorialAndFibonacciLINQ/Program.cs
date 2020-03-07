using System;
using System.Collections.Generic;
using System.Linq;

namespace FactorialAndFibonacciLINQ
{
    class Program
    {
        static void Main()
        {
            string input = "";
            for (; ; )
            {
                Console.Clear();
                Console.Write(@"Find Factorial
Input number: ");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out int result))
                {
                    Console.WriteLine($@"{result}! = {Factorial(result)}");
                    Console.Write("Press any key...");
                    Console.ReadKey();
                }
                else
                {
                    continue;
                }
                Console.Clear();
                Console.WriteLine("Number Fibonacci");
                var numbers = Fibonacci().TakeWhile(x=>x<= 701408733);
                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }
                Console.Write("Again (Y)/(N):");
                string again = Console.ReadLine();
                if (again.ToUpper() == "Y")
                {
                    continue;
                }
                else 
                {
                    break;
                }
            }
        }

        public static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            int[] numbers = new int[number];
            for (int i = 0; i < number; i++)
            {
                numbers[i] = i + 1;
            }
            var result = numbers.Aggregate((x, y) => x * y);
            return result;
        }
        public static IEnumerable<int> Fibonacci()
        {
            int current = 0;
            int next = 1;
            for (int i = 0; i < 50; i++)
            {
                yield return current;
                int temp = next;
                next = current + next;
                current = temp;
            }
        }
    }
}
