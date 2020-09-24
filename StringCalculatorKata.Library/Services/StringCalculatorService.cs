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
                var delimiters = GetDelimiters(stringNumbers); ;
                if (stringNumbers.Contains("//"))
                {
                    stringNumbers = stringNumbers.Split("\n")[1];
                }

                var numbers = GetNumberFromString(stringNumbers, delimiters);

                return numbers.Sum();
            }

            return 0;
        }

        private static string[] GetDelimiters(string stringNumbers)
        {
            var supportedDelimiters = new List<string> { "\n", "," };
            if (stringNumbers.Contains("//"))
            {
                var listOfDelimiterAndNumbers = stringNumbers.Split("\n");
                var delimiter = listOfDelimiterAndNumbers[0].Replace("//", "");
                supportedDelimiters.Add(delimiter);
            }

            return supportedDelimiters.ToArray();
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
