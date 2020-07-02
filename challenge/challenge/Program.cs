using System;

namespace challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(isLeapYear(1997));
            Console.WriteLine(isLeapYear(1996));
            Console.WriteLine(isLeapYear(1900));
            Console.WriteLine(isLeapYear(2000));
        }

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
    }
}
