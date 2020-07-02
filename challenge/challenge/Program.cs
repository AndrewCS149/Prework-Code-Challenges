using System;

namespace challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Challenge 2 tests
            //Console.WriteLine(isLeapYear(1997));
            //Console.WriteLine(isLeapYear(1996));
            //Console.WriteLine(isLeapYear(1900));
            //Console.WriteLine(isLeapYear(2000));

            // challenge 3 tests
            //Console.WriteLine(isPerfectSequence(new[] { 1, 2, 3 }));
            //Console.WriteLine(isPerfectSequence(new[] { 0, 0, 0, 0 }));
            //Console.WriteLine(isPerfectSequence(new[] { 2, 2 }));
            //Console.WriteLine(isPerfectSequence(new[] { 4, 5, 6 }));
            //Console.WriteLine(isPerfectSequence(new[] { 0, 2, -2 }));

            // challenge 4 tests
            //int[,] nums = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            //Console.WriteLine(sumOfArrays(nums));            
        }

        // challenge 2
        public static string isLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 == 0)
                    return $"{year} is a leap year";
                else if (year % 100 == 0)
                    return $"{year} is not a leap year";
                else
                    return $"{year} is a leap year";
            }
            return $"{year} is not a leap year";
        }

        // challenge 3
        public static string isPerfectSequence(int[] nums)
        {
            int sum = 0;
            int product = 1;
            foreach (int num in nums)
            {
                if (num < 0)
                    return "No";
                sum += num;
                product *= num;
            }
            return sum == product ? "Yes" : "No";
        }

        // challenge 4
        public static int[] sumOfArrays(int[,] numArrays)
        {
            int rows = numArrays.GetLength(0);
            int columns = numArrays.GetLength(1);
            int[] sums = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int k = 0; k < columns; k++)
                {
                    sum += numArrays[i, k];

                }
                sums[i] = sum;
            }
            // print out array and return 
            Console.WriteLine(string.Join(", ", sums));
            return sums;
        }
    }
}
