using System;
using System.Globalization;

namespace MainCode
{
    public class NumberDiv3or5
    {
        private static bool IsNumber(string printNumber)
        {
            return String.IsNullOrEmpty(printNumber);
        }

        private static bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }

        private static bool IsFizz(int i)
        {
            return i % 3 == 0;
        }

        private static string GetNumbers(string resultFizzBuzz)
        {

            for (var i = 1; i <= 100; i++)
            {
                var printNumber = string.Empty;
                if (IsFizz(i)) printNumber += "Fizz";
                if (IsBuzz(i)) printNumber += "Buzz";
                if (IsNumber(printNumber))
                    printNumber = (i).ToString(CultureInfo.InvariantCulture);
                resultFizzBuzz += " " + printNumber;
            }
            return resultFizzBuzz.Trim();
        }

        private static string GetFizzBuzzResult(int number)
        {
            string result = null;
            if (IsFizz(number) && IsBuzz(number)) result = "FizzBuzz";
            return result;
        }

        private static string GetBuzzResult(int number)
        {
            string result = null;
            if (IsBuzz(number)) result = "Buzz";
            return result;
        }

        private static string GetFizzResult(int number)
        {
            string result = null;
            if (IsFizz(number)) result = "Fizz";
            return result;
        }
        public static string PrintFizzBuzz()
        {
            var resultFizzBuzz = string.Empty;
            resultFizzBuzz = GetNumbers(resultFizzBuzz);
            return resultFizzBuzz;
        }

        //printing fizz,Buzz,FizzBuzz based in the input number.
        public static string PrintFizzBuzz(int number)
        {

            var result = GetFizzBuzzResult(number);

            if (string.IsNullOrEmpty(result))
                result = GetFizzResult(number);
            if (string.IsNullOrEmpty(result))
                result = GetBuzzResult(number);

            //return string.IsNullOrEmpty(result) ? number.ToString(CultureInfo.InvariantCulture) : result;

            return result;
        }
    }
}
