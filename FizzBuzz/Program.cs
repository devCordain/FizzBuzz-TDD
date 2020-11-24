using System;

namespace FizzBuzz.Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string GetFizzBuzz(int input)
        {
            if (input % 3 == 0)
                return "Fizz";
            throw new Exception();
        }
    }
}
