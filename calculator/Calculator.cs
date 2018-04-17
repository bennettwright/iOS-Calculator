using System;
namespace calculator
{
    public class Calculator
    {
        public Calculator()
        {
        }

        private static char[] delimiters = { '*', '/', '+', '-' };

        public static decimal getAnswer(string equation)
        {
            decimal result = -1;
            //split string based on operator
            string[] numbers = equation.Split(delimiters);
            decimal num1 = Decimal.Parse(numbers[0]);
            decimal num2 = Decimal.Parse(numbers[1]);

            char operation = numbers[1][0];
            //now perform operation depending on the operator
            switch(numbers[1])
            {
                case "*":
                    result = num1 * num2;
                    break;
                case"/":
                    result = num1 / num2;
                    break;
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
            }

            return result;
        }
    }
}
