using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.classes
{
    public class FizzBuzzer {

        private readonly List<int> _numbers;

        public FizzBuzzer(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentNullException(nameof(numbers), "Numbers cannot empty :(");
            }

            _numbers = numbers;
        }

        public string DoFizzBuzz()
        {
            var stringBuilder = new StringBuilder();

            foreach(var x in _numbers)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    stringBuilder.Append("FizzBuzz");
                }

                else if (x % 3 == 0)
                {
                    stringBuilder.Append("Fizz");
                }

                else if (x % 5 == 0)
                {
                    stringBuilder.Append("Buzz");
                }

                else
                {
                    stringBuilder.Append(x);
                } 

                stringBuilder.Append(",");
            }

            return stringBuilder.ToString().Remove(stringBuilder.Length - 1);
        }
    }
}