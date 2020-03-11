using System;
using System.Collections.Generic;
using System.Linq;

namespace FactorialAndFibonacciLINQ
{
    class Program
    {
        static void Main()
        {
            string userInput;
            for (; ; )
            {
                Console.Clear();
                Console.Write(@"Find Factorial
Input number: ");
                userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out int result))
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
                Console.Write(@"Number Fibonacci
Input number: ");
                userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out int result2))
                {
                    var numbers = Fibonacci(result2);
                    foreach (var item in numbers)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    continue;
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
        public static IEnumerable<int> Fibonacci(int n)
        {
            int current = 0;
            int next = 1;
            for (int i = 0; i < n; i++)
            {
                yield return current;
                int temp = next;
                next = current + next;
                current = temp;
            }
        }
    }
}
