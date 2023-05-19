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

            if (numbers.StartsWith("\\"))
            {
                var splitNumbers = numbers.Split('\n');
                defaultDelimiters = splitNumbers[0].Substring(1, 1).ToCharArray();
                numbers = splitNumbers[1];
            }

            var numbersList = numbers.ToCharArray();
            var sum = 0;

            foreach (var number in numbersList)
            {
                if(defaultDelimiters.Any(d => d == number)) continue;
                sum += int.Parse(number.ToString());
            }

            return sum;
        }
    }
}
