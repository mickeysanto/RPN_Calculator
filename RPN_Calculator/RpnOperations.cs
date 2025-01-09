using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN_Calculator
{
    internal static class RpnOperations
    {
        #region Arithmetic Operators

        private const string AdditionOperator = "+";
        private const string SubtractionOperator = "-";
        private const string MultiplicationOperator = "*";
        private const string DivisionOperator = "/";

        public const string SqrtOperator = "sqrt";

        #endregion

        //Performs arithmetic and returns result given a valid operator symbol
        public static float PerformOperation(float value1, float value2, string operation)
        {
            float result;

            switch(operation)
            {
                case AdditionOperator:
                    result = value1 + value2;
                    break;

                case SubtractionOperator:
                    result = value1 - value2;
                    break;

                case MultiplicationOperator:
                    result = value1 * value2;
                    break;

                case DivisionOperator:
                    result = Divide(value1, value2);
                    break;
                case SqrtOperator:
                    result = Sqrt(value1);
                    break;

                default:
                    throw new Exception("Invalid operator: " + operation + ". Please use one of the valid operators: + - * / and re-enter your equation.");
            }

            return result;
        }

        private static float Divide(float value1, float value2)
        {
            if (value2 == 0)
            {
                throw new Exception("Cannot divide by 0.");
            }

            return value1 / value2;
        }

        private static float Sqrt(float value)
        {
            if(value < 0)
            {
                throw new Exception("Cannot take the square root of a negtive.");
            }

            return (float)Math.Sqrt(value);
        }
    }
}
