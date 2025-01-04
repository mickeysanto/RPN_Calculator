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
                    result = value1 / value2;
                    break;

                default:
                    throw new Exception("Invalid operator: " + operation + ". Please use one of the valid operators: + - * / and re-enter your equation.");
            }

            return result;
        }
    }
}
