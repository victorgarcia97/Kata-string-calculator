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

            var numbersList = numbers.ToCharArray();
            var sum = 0;

            foreach (var number in numbersList)
            {
                if(number == ',' || number == '\n') continue;
                sum += int.Parse(number.ToString());
            }

            return sum;
        }
    }
}
