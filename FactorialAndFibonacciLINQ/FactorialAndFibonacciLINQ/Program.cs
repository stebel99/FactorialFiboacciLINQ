using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialAndFibonacciLINQ
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
