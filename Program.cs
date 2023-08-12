using System;
using System.Collections.Generic;
using System.Linq;

namespace AliSalmeh_ProjectWeek5.FindMaxMin_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Finding Maximum and Minimum
            // First Solution

            Console.WriteLine();
            Console.WriteLine("Enter your numbers: ");
            Console.WriteLine("\"WARNING\": you can just enter five number!");
            var number = new int[5];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"maximum number is: {FindMaximum(number)}");
            Console.WriteLine($"minimum number is: {FindMinimum(number)}");

            Console.ReadLine();
            Console.Clear();

            // Second Solution

            Console.WriteLine();
            Console.WriteLine("Enter \"999\" to close your input's list.");
            Console.WriteLine("Enter your array list: ");
            var numbers = new List<int>();

            while (true)
            {
                var input = Convert.ToInt32(Console.ReadLine());

                if (input == 999)
                {
                    break;
                }
                numbers.Add(input);
            }

            Console.WriteLine($"maximum number is: {numbers.Max()}");
            Console.WriteLine($"minimum number is: {numbers.Min()}");
        }

        private static int FindMaximum(int[] myNumber)
        {
            var max = myNumber[0];
            foreach (var num in myNumber)
            {
                if (max < num)
                {
                    max = num;
                }
            }
            return max;
        }

        private static int FindMinimum(int[] myNumber)
        {
            var min = myNumber[0];
            foreach (var num in myNumber)
            {
                if (min > num)
                {
                    min = num;
                }
            }
            return min;
        }
    }
}