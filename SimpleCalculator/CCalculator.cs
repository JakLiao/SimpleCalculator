using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCalculator
{
    class CCalculator
    {
        /// <summary>expression of the calculation </summary>
        private string displayStr = string.Empty;
        /// <summary>input of the calculation </summary>
        private string resultStr = "0";

        public string ResultStr
        {
            get { return resultStr; }
            set { resultStr = value; }
        }
        /// <summary>
        /// operation "+-*/"
        /// </summary>
        private char opr;

        public char Opr
        {
            get { return opr; }
            set { opr = value; }
        }
        /// <summary>
        /// result of the calculation
        /// </summary>
        private double result;

        public double Result
        {
            get { return result; }
            set { result = value; }
        }
        private double num1;
        private double num2;
        /// <summary>
        /// to judge it's leftarg or rightarg
        /// </summary>
        private bool first;
        /// <summary>
        /// cancel once input
        /// </summary>
        /// <returns>original input</returns>
        public string Back()
        {
            if (resultStr.Length > 0)
            {
                resultStr = resultStr.Remove(resultStr.Length - 1);//remove the last character of the input string
            }
            else
            {
                resultStr = "0";
            }
            return resultStr;
        }
        /// <summary>
        /// clear all display state of the calculator
        /// </summary>
        /// <returns>diaplay text</returns>
        public string Clear()
        {
            displayStr = string.Empty;
            return displayStr;
        }
        /// <summary>
        /// clear all result state of the calculator
        /// </summary>
        /// <returns>result text</returns>
        public string RClear()
        {
            result = 0;
            resultStr = "0";
            return resultStr;
        }

        #region arithmetic operation
        /// <summary>
        /// To perform the arithmetic operation of addition.
        /// </summary>
        /// <param name="leftArg">left addend</param>
        /// <param name="rightArg">right addend</param>
        /// <returns></returns>
        public double Add(double leftArg, double rightArg)
        {
            return leftArg + rightArg;
        }
        /// <summary>
        /// To perform the arithmetic operation of subtraction.
        /// </summary>
        /// <param name="leftArg">minuend</param>
        /// <param name="rightArg">subtrahend</param>
        /// <returns></returns>
        public double Subtract(double leftArg, double rightArg)
        {
            return leftArg - rightArg;
        }
        /// <summary>
        /// To perform the arithmetic operation of multiplication
        /// </summary>
        /// <param name="leftArg">left multiplier</param>
        /// <param name="rightArg">right multiplier</param>
        /// <returns></returns>
        public double Multiply(double leftArg, double rightArg)
        {
            return leftArg * rightArg;
        }
        /// <summary>
        /// To perform the arithmetic operation of divisiton.
        /// </summary>
        /// <param name="leftArg">dividend</param>
        /// <param name="rightArg">divisor</param>
        /// <returns></returns>
        public double Divide(double leftArg, double rightArg)
        {
            if (Math.Abs(rightArg) < 10e-9)
                throw new DivideByZeroException(("Error: Division by zero was performed!"));
            return leftArg / rightArg;
        }
        #endregion
        /// <summary>
        /// calculate the result of the expression On Normal Mode
        /// </summary>
        /// <returns></returns>
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
                    result = Multiply(num1 , num2);
                    break;
                case '/':
                    try
                    {
                        result = Divide(num1 , num2);
                    }
                    catch (DivideByZeroException ex)//DivideByZeroException may occur
                    {
                        resultStr = "divisor can't be 0";
                        return resultStr;
                    }
                    break;
            }
            resultStr = result.ToString();
            return resultStr;
        }
        /// <summary>
        /// set the operator of the expression 
        /// </summary>
        /// <param name="btnopr">+ or - or * or /</param>
        /// <returns></returns>
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
        /// <summary>
        /// change the right or left number
        /// </summary>
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
        /// <summary>
        /// the number of the numberkey
        /// </summary>
        /// <param name="num">the number of the presskey</param>
        /// <returns></returns>
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
        /// <summary>
        /// judge whether "." is used or not
        /// </summary>
        /// <returns>index of the "."</returns>
        public int DotUsed()
        {
            return resultStr.IndexOf(".");
        }
    }
}
