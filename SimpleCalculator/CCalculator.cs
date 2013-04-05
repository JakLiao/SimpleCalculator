using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCalculator
{
    class CCalculator
    {
        private string displayText = string.Empty;
        private string resultText = string.Empty;

        private char Opr;

        private double result;
        private double num1;
        private double num2;

        private bool first;

        public string Back()
        {
            if (displayText.Length > 0)
            {
                displayText = displayText.Remove(displayText.Length - 1);
            }
            return displayText;
        }

        public string Clear()
        {
            displayText = string.Empty;
            return displayText;
        }

        public string NumberKey(string num)
        {
            displayText += num;
            return displayText;
        }

        public string Calc()
        {
            switch (Opr)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            resultText = result.ToString();
            return resultText;
        }
    }
}
