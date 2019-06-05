using System;
using Autofac;

namespace Test
{
    public interface InumberTypes
    {
        string GetNumbers(string resultFizzBuzz);
        string GetFizzBuzzResult(string resultFizzBuzz);
        string GetBuzzResult(string resultFizzBuzz);
        string GetFizzResult(string resultFizzBuzz);
    }

    public class NumberType : InumberTypes
    {
        public string GetBuzzResult(string resultFizzBuzz)
        {
            throw new NotImplementedException();
        }

        public string GetFizzBuzzResult(string resultFizzBuzz)
        {
            throw new NotImplementedException();
        }

        public string GetFizzResult(string resultFizzBuzz)
        {
            throw new NotImplementedException();
        }

        public string GetNumbers(string resultFizzBuzz)
        {
            throw new NotImplementedException();
        }
    }
}
