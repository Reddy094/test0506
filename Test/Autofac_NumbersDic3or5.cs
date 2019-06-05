using System;
using Autofac;
using System.Globalization;

namespace AvivaCode
{
    public class Autofac_NumbersDic3or5
    {
        public Autofac_NumbersDic3or5()
        {
            //registering interface with class that implemented
            var builder = new ContainerBuilder();
            builder.RegisterType<NumberType>().As<InumberTypes>();

            //Resolving inteface with autofac
            var container = builder.Build();
            var printService = container.Resolve<InumberTypes>();

        }
    }
}


public interface InumberTypes
{
    string GetNumbers(int number);
    string GetFizzBuzzResult(int number);
    string GetBuzzResult(int number);
    string GetFizzResult(int number);
    string GetNumbers(string resultFizzBuzz);
    string PrintFizzBuzz();
    string PrintFizzBuzz(int number);
    void CanThrowArgumentExceptionWhenNumberNotInRule(int number);
}

public class NumberType : InumberTypes
{
    private readonly InumberTypes _numberTypes;

    public NumberType(InumberTypes numbertypes)
    {
        _numberTypes = numbertypes;
    }

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

    public string GetBuzzResult(int number)
    {
        string result = null;
        if (IsBuzz(number)) result = "Buzz";
        return result;
}   

    public string GetFizzBuzzResult(int number)
    {
        string result = null;
        if (IsFizz(number) && IsBuzz(number)) result = "FizzBuzz";
        return result;
    }

    public string GetFizzResult(int number)
    {
        string result = null;
        if (IsFizz(number)) result = "Fizz";
        return result;
    }

    public string GetNumbers(int number)
    {
        throw new NotImplementedException();
    }

    public string GetNumbers(string resultFizzBuzz)
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

    public string PrintFizzBuzz()
    {
        var resultFizzBuzz = string.Empty;
        resultFizzBuzz = GetNumbers(resultFizzBuzz);
        return resultFizzBuzz;
    }

    public string PrintFizzBuzz(int number)
    {
        CanThrowArgumentExceptionWhenNumberNotInRule(number);

        var result = GetFizzBuzzResult(number);

        if (string.IsNullOrEmpty(result))
            result = GetFizzResult(number);
        if (string.IsNullOrEmpty(result))
            result = GetBuzzResult(number);

        //return string.IsNullOrEmpty(result) ? number.ToString(CultureInfo.InvariantCulture) : result;

        return result;
    }

    public void CanThrowArgumentExceptionWhenNumberNotInRule(int number)
    {
        if (number > 100 || number < 1)
            throw new ArgumentException(
                string.Format(
                    "entered number is [{0}], which does not meet rule, entered number should be between 1 to 100.", number));
    }
}
