using System;
namespace AliSalmeh_ProjectWeek5_FindMaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Finding Maximum and Minimum

            Console.Clear();
            Console.WriteLine("Enter numbers: ");
            Console.WriteLine("\"ATTENTION\": you can only enter five numbers!");

            var numbers = GetNumbersArray(5);

            double maximum = FindMaximum(numbers);
            double minimum = FindMinimum(numbers);

            Console.WriteLine($"maximum number is: {maximum}");
            Console.WriteLine($"minimum number is: {minimum}");
        }

        static int[] GetNumbersArray(int size)
        {
            var number = new int[size];

            for (int i = 0; i < size; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            return number;
        }

        private static double FindMaximum(int[] myNumber)
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

        private static double FindMinimum(int[] myNumber)
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