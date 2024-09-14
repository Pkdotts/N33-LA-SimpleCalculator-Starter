using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDLLThing
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            bool yippie = false;

            do
            {
                if (argOperation == "+" || argOperation.ToLower() == "add")
                {
                    result = argFirstNumber + argSecondNumber;
                    yippie = true;
                }
                else if (argOperation == "-" || argOperation.ToLower() == "sub")
                {
                    result = argFirstNumber - argSecondNumber;
                    yippie = true;
                }
                else if (argOperation == "*" || argOperation.ToLower() == "multiply")
                {
                    result = argFirstNumber * argSecondNumber;
                    yippie = true;
                }
                else if (argOperation == "-" || argOperation.ToLower() == "divide")
                {
                    result = argFirstNumber / argSecondNumber;
                    yippie = true;
                }
                else if (argOperation == "%" || argOperation.ToLower() == "modulus")
                {
                    result = argFirstNumber % argSecondNumber;
                    yippie = true;
                }
                else
                {
                    Console.WriteLine("Enter the Operator again (+, -, *, /, %)");
                    argOperation = Console.ReadLine();
                }
            } while (!yippie);

            return result;
        }
    }
}