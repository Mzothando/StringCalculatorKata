using StringCalculatorKata.Library.Services;
using System;

namespace StringCalculatorKata.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers separated by comma:");
            var numbers = Console.ReadLine();
            var stringCalculatorService = new StringCalculatorService();
            var sum = stringCalculatorService.Add(numbers);
            Console.WriteLine($"Sum of '{numbers}': {sum}");
            Console.Read();
        }
    }
}
