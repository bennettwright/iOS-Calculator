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
            //split string based on operator

            string[] numbers = equation.Split(delimiters);
            decimal num1 = Decimal.Parse(numbers[0]);
           // throw new FormatException(numbers[0]);
            decimal num2 = Decimal.Parse(numbers[1]);

            char operation = ' ';

            if (equation.Contains("*"))
                operation = '*';

            else if (equation.Contains("/"))
                operation = '/';

            else if (equation.Contains("+"))
                operation = '+';

            else if (equation.Contains("-"))
                operation = '-';
            //throw new FormatException(operation);
            //now perform operation depending on the operator
            switch(operation)
            {
                case '*':
                    return num1 * num2;

                case'/':
                    return num1 / num2;

                case '+':
                    return num1 + num2;
                
                case '-':
                    return num1 - num2;

            }

            throw new FormatException("input is invalid");
        }
    }
}
