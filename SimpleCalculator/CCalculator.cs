using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCalculator
{
    class CCalculator
    {
        private string displayStr = string.Empty;

        public string DisplayStr
        {
            get { return displayStr; }
            set { displayStr = value; }
        }
        private string resultStr = string.Empty;

        public string ResultStr
        {
            get { return resultStr; }
            set { resultStr = value; }
        }

        private char opr;

        public char Opr
        {
            get { return opr; }
            set { opr = value; }
        }

        private double result;

        public double Result
        {
            get { return result; }
            set { result = value; }
        }
        private double num1;
        private double num2;

        private bool first;

        public string Back()
        {
            if (resultStr.Length > 0)
            {
                resultStr = resultStr.Remove(resultStr.Length - 1);
            }
            else
            {
                resultStr = "0";
            }
            return resultStr;
        }

        public string Clear()
        {
            displayStr = string.Empty;
            return displayStr;
        }

        public string RClear()
        {
            resultStr = "0";
            return resultStr;
        }

        public string NumberKey(string num)
        {
            displayStr += num;
            return displayStr;
        }

        public string Calc()
        {
            NumChange();
            switch (opr)
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
            resultStr = result.ToString();
            return resultStr;
        }

        public string SetOperatorByLetter(string btnopr)
        {
            switch (btnopr)
            {
                case "+":
                    this.opr = '+';
                    break;
                case "-":
                    this.opr = '-';
                    break;
                case "*":
                    this.opr = '*';
                    break;
                case "/":
                    this.opr = '/';
                    break;
            }
            NumChange();

            return opr.ToString();
        }

        public void NumChange()
        {
            if (!first)
            {
                num1 = this.result;
            }
            else
            {
                num2 = this.result;
            }
            first = !first;
        }

        public int DotUsed()
        {
            return displayStr.IndexOf(".");
        }
    }
}
