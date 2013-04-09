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
        private string resultStr = "0";

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
            result = 0;
            resultStr = "0";
            return resultStr;
        }

        #region arithmetic operation
        public double Add(double leftArg, double rightArg)
        {
            return leftArg + rightArg;
        }

        public double Subtract(double leftArg, double rightArg)
        {
            return leftArg - rightArg;
        }

        public double Myltiply(double leftArg, double rightArg)
        {
            return leftArg * rightArg;
        }

        public double Divide(double leftArg, double rightArg)
        {
            if (Math.Abs(rightArg) < 10e-9)
                throw new DivideByZeroException(("Error: Division by zero was performed!"));
            return leftArg / rightArg;
        }
        #endregion

        public string Calc()
        {
            NumChange();
            switch (opr)
            {
                case '+':
                    result = Add(num1 , num2);
                    break;
                case '-':
                    result = Subtract(num1 , num2);
                    break;
                case '*':
                    result = Myltiply(num1 , num2);
                    break;
                case '/':
                    try
                    {
                        result = Divide(num1 , num2);
                    }
                    catch(DivideByZeroException exception)
                    {
                        resultStr = "divisor can't be 0";
                        return resultStr;
                    }
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

        public string NumberKey(string num)
        {
            if (resultStr.Equals("0"))
            {
                resultStr = num;
            }
            else
            {
                resultStr += num;
            }
            return resultStr;
        }

        public int DotUsed()
        {
            return resultStr.IndexOf(".");
        }
    }
}
