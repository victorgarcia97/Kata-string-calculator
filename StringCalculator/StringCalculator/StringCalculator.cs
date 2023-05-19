using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            if (numbers == "") return 0;

            var defaultDelimiter = ",";

            CheckForNewDelimiters(ref numbers, ref defaultDelimiter);

            return Sum(numbers, defaultDelimiter);
        }

        private static void CheckForNewDelimiters(ref string numbers, ref string defaultDelimiters)
        {
            if (numbers.StartsWith("\\"))
            {
                var splitNumbers = numbers.Split('\n');
                defaultDelimiters = splitNumbers[0].Substring(1, 1);
                numbers = splitNumbers[1];
            }
        }

        private static int Sum(string numbers, string defaultDelimiter)
        {
            var sum = 0;
            var negatives = new List<int>();
            var numbersList = numbers.Replace("\n", defaultDelimiter).Split(defaultDelimiter);

            foreach (var stringNumber in numbersList)
            {
                var number = int.Parse(stringNumber);
                if (number < 0)
                {
                    negatives.Add(number);
                    continue;
                }

                sum += number;
            }

            if (negatives.Count > 0)
            {
                var join = string.Join(", ", negatives);
                throw new InvalidOperationException(join);
            }

            return sum;
        }
    }
}
