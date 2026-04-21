using System;
using System.Collections.Generic;
using System.Text;

namespace Laskentaa
{
    public class Laskenta
    {
        public static int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Number must be non-negative");

            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        public static int SumOfDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number); // handle negative numbers

            while (number > 0)
            {
                sum += number % 10; // get last digit
                number /= 10;       // remove last digit
            }

            return sum;
        }
    }
}
