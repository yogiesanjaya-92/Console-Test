using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecialNumber
{
    public class Program
    {
        /// <summary>
        /// Special Number
        /// Special Number is list of non-negative integer that is constructed from non-negative integer
        /// Special Number has two operations, Special Summation and Special Multiplication
        /// 
        /// You must implement SpecialSummation and Special Multiplication Method
        /// See explanation for each method below
        /// 
        /// DO NOT CHANGE THE CODE IN MAIN
        /// </summary>
        static void Main(string[] args)
        {
            TestResult(6, SpecialSummation(123));
            TestResult(9, SpecialSummation(567));
            TestResult(1, SpecialSummation(469));

            TestResult(6, SpecialMultiplication(123));
            TestResult(0, SpecialMultiplication(567));
            TestResult(4, SpecialMultiplication(333));

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        /**
         * PLEASE DO NOT CHANGE THE CODE OF THIS METHODO
         **/
        private static void TestResult(int expected, int actual)
        {
            if (expected == actual)
            {
                Console.WriteLine("Answer is correct");
            }
            else
            {
                Console.WriteLine("Answer is wrong. Expected level is {0} but your result is {1}", expected, actual);
            }
        }

        /// <summary>
        /// SpecialSummation is sums of all digit in Special Number
        /// Example:
        /// >>> SpecialSummation(123)
        /// >>> 6   (from 1+2+3)
        /// 
        /// >>> SpecialSummation(567)
        /// >>> 9   (from 5+6+7 = 18 then 1+8 = 9)
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Summation of Special Number</returns>
        private static int SpecialSummation(int number)
        {
            // AMEND YOUR CODE BELOW THIS LINE
            List<int> digits = new List<int>();
            while (number > 0)
            {
                int digit;
                number = Math.DivRem(number, 10, out digit);
                digits.Add(digit);
            }

            int result = digits[0];
            for (int i = 1; i < digits.Count(); i++)
            {
                result += digits[i];
            }

            if (result > 9)
            {
                return SpecialSummation(result);
            }
            else
            {
                return result;
            }

            throw new NotImplementedException();
            // AMEND YOUR CODE ABOVE THIS LINE
        }

        /// <summary>
        /// SpecialMultiplication is multiplication of all digit in Special Number
        /// Example:
        /// >>> SpecialMultiplication(123)
        /// >>> 6   (from 1*2*3)
        /// 
        /// >>> SpecialMultiplication(567)
        /// >>> 0   (from 5*6*7 = 210 then 2*1*0 = 0)
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Multiplication of Special Number</returns>
        private static int SpecialMultiplication(int number)
        {
            // AMEND YOUR CODE BELOW THIS LINE
            List<int> digits = new List<int>();
            while (number > 0)
            {
                int digit;
                number = Math.DivRem(number, 10, out digit);
                digits.Add(digit);
            }

            int result = digits[0];
            for (int i = 1; i < digits.Count(); i++)
            {
                result *= digits[i];
            }

            if (result > 9)
            {
                return SpecialMultiplication(result);
            }
            else
            {
                return result;
            }

            throw new NotImplementedException();
            // AMEND YOUR CODE ABOVE THIS LINE
        }
    }
}