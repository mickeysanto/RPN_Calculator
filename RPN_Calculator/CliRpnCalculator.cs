using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN_Calculator
{
    //Command Line Reverse Polish Notation Calculator
    internal class CliRpnCalculator
    {
        #region Commands

        private const string Clear = "c";
        private const string Quit = "q";

        #endregion

        static void Main()
        {
            Console.WriteLine("RPN Calculator Commands: ");
            Console.WriteLine("Clear Calculations: " + Clear);
            Console.WriteLine("Quit Calculator: " + Quit + " or Ctrl + z");
            Console.WriteLine();

            RunCalculator();
        }

        //gathers user input and displays output to the console
        private static void RunCalculator()
        {
            RpnInputManager inputManager = new RpnInputManager();
            string userInput = "";
            string output = "";

            do
            {
                Console.Write("> ");
                userInput = Console.ReadLine();

                if(userInput == null) //EOF (Ctrl + z)
                {
                    break;
                }

                if (userInput.Trim() == Clear) //clears current calculations
                {
                    output = inputManager.ClearStack();
                }
                else if (userInput.Trim() == Quit) //quits program
                {
                    output = "Quitting Application.";
                }
                else
                {
                    output = inputManager.ProcessInput(userInput);
                }

                Console.WriteLine(output);

            } while (userInput != Quit);
        }
    }
}
