using System;
using System.Linq;

namespace FizzBuzz.Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                PrintMenu();
                PrintResult(GetUserInput());
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("Enter an integer between 1 and 300");
        }

        public static int GetUserInput()
        {
            return ValidateInput(Console.ReadLine());
        }

        public static void PrintResult(int input)
        {
            if (input == -1)
            {
                Console.WriteLine("Input must be an integer between 1 and 300");
                return;
            }

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(GetOutput(i));
            }

        }

        public static string GetOutput(int input)
        {
            if (input == 42)
                return "Answer to the Ultimate Question of Life, the Universe, and Everything";
            if (input % 3 == 0 && input % 5 == 0)
                return "FizzBuzz";
            if (input % 3 == 0)
                return "Fizz";
            if (input % 5 == 0)
                return "Buzz";

            return input.ToString();
        }

        public static int ValidateInput(string input)
        {
            const int failedValidationCode = -1;

            if (!int.TryParse(input, out var parsedInput)) 
                return failedValidationCode;

            if (parsedInput < 1 || parsedInput > 300)
                return failedValidationCode;

            return parsedInput;
        }
    }
}
