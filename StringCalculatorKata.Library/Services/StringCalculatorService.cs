using StringCalculatorKata.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculatorKata.Library.Services
{
    public class StringCalculatorService : IStringCalculatorService
    {
        public int Add(string stringNumbers)
        {
            if (!string.IsNullOrWhiteSpace(stringNumbers))
            {
                var numbers = GetNumbers(stringNumbers);

                return numbers.Sum();
            }

            return 0;
        }

        private int[] GetNumbers(string stringNumbers)
        {
            var stringOfNumbers = stringNumbers.Split(',', StringSplitOptions.RemoveEmptyEntries);
            var numbers = stringOfNumbers.Select(number => int.Parse(number)).ToArray();

            return numbers;
        }
    }
}
