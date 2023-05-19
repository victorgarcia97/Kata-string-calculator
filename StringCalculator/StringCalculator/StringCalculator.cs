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

            var numberList = numbers.Split(',');

            var firstNumber = int.Parse(numberList[0]);
            var secondNumber = int.Parse(numberList[1]);


            return  firstNumber + secondNumber;
        }
    }
}
