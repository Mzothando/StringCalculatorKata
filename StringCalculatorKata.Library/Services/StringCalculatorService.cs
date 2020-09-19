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
                var delimiters = new string[] { "\n", "," };
                var numbers = GetNumberFromString(stringNumbers, delimiters);

                return numbers.Sum();
            }

            return 0;
        }

        private List<int> GetNumberFromString(string stringNumbers, string[] delimiters)
        {
            var numbers = stringNumbers
                            .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                            .Select(number => int.Parse(number))
                            .ToList();

            return numbers;
        }
    }
}
