using FizzBuzz.classes;
using System;
using System.Collections.Generic;


namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>(1500);

            for (int i = 1; i <= 1500; i++)
            {
                numbers.Add(i);
            }

            var fizzer = new FizzBuzzer(numbers);
            
            Console.WriteLine(fizzer.DoFizzBuzz());
            Console.ReadKey();
        } 
    }
}
