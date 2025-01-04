using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN_Calculator
{
    public class RpnInputManager
    {
        private Stack<float> inputValues; //inputed numbers
        private string operation; //current operation

        public RpnInputManager() 
        {
            inputValues = new Stack<float>();
            operation = "";
        }

        public string ClearStack()
        {
            inputValues.Clear();

            return "Calculations cleared!";
        }

        //takes user input and pushes numbers to the inputValues stack
        //if not a number, sets it as the current operation and calls CalculateResult
        public string ProcessInput(string userInput)
        {
            string result = "";
            string[] inputs = userInput.Split(' ');

            try
            {
                foreach (string input in inputs)
                {
                    if (float.TryParse(input, out float value))
                    {
                        inputValues.Push(value);
                        result = value.ToString();
                    }
                    else if(input != "")
                    {
                        operation = input;
                        result = CalculateResult();
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }

        //if there are 2 values in inputValues, pops them and calls PerfomOperations to get the result
        private string CalculateResult()
        {
            float value1, value2, result;
            string resultReturn = "";

            if (inputValues.Count < 2)
            {
                throw new Exception("Calculations need to be between at least 2 values.");
            }
            else
            {
                value2 = inputValues.Pop();
                value1 = inputValues.Pop();

                result = RpnOperations.PerformOperation(value1, value2, operation);
                inputValues.Push(result);

                resultReturn = result.ToString();
            }

            return resultReturn;
        }

        //prints remaining values in stack
        //private string RemainingValues()
        //{
        //    string values = "";

        //    foreach(float input in inputValues.Reverse())
        //    {
        //        values += input + " ";
        //    }

        //    return values;
        //}
    }
}
