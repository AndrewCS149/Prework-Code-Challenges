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
    }
}
