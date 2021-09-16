using System;
using System.Collections.Generic;
using System.Text;

namespace CalcSSS
{
    public static class MOperator
    {
        public static double Calculate(double firstNum , double secondNum, string mathOperator)
        {
            double result = 0;
            
                 switch (mathOperator)
            {
                case "÷":
                        result = firstNum / secondNum;
                    break;

                case "*":
                    result = firstNum * secondNum;
                    break;
                case "+":
                        result = firstNum + secondNum;
                    break;
                case "-":
                        result = firstNum - secondNum;
                    break;
            }
            return result;
        }
    }
}
