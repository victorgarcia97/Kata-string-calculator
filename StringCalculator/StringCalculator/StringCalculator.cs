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

            var defaultDelimiters = new char[] { ',', '\n' };

            CheckForNewDelimiters(ref numbers, ref defaultDelimiters);

            return Sum(numbers.ToCharArray(), defaultDelimiters);
        }

        private static void CheckForNewDelimiters(ref string numbers, ref char[] defaultDelimiters)
        {
            if (numbers.StartsWith("\\"))
            {
                var splitNumbers = numbers.Split('\n');
                defaultDelimiters = splitNumbers[0].Substring(1, 1).ToCharArray();
                numbers = splitNumbers[1];
            }
        }

        private static int Sum(char[] numbersList, char[] defaultDelimiters)
        {
            var sum = 0;
            foreach (var number in numbersList)
            {
                if (defaultDelimiters.Any(d => d == number)) continue;
                sum += int.Parse(number.ToString());
            }

            return sum;
        }
    }
}
