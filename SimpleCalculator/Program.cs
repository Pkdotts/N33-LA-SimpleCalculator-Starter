using System;
using System.Text;
using CalculatorDLLThing;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();


                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("enter your operation (add, subtract, divide, multiply");
                string operation = Console.ReadLine();
                
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                StringBuilder build = new StringBuilder();

                if (operation == "+" || operation.ToLower() == "add")
                {
                    build.AppendFormat("The value {0:F2} plus the value {1:F2} is equal to {2:F2}", firstNumber, secondNumber, result);
                }
                else if (operation == "-" || operation.ToLower() == "minus")
                {
                    build.AppendFormat("The value {0:F2} minus the value {1:F2} is equal to {2:F2}", firstNumber, secondNumber, result);
                }
                else if (operation == "*" || operation.ToLower() == "times")
                {
                    build.AppendFormat("The value {0:F2} times the value {1:F2} is equal to {2:F2}", firstNumber, secondNumber, result);
                }
                else if (operation == "/" || operation.ToLower() == "divided")
                {
                    build.AppendFormat("The value {0:F2} divided by the value {1:F2} is equal to {2:F2}", firstNumber, secondNumber, result);
                }


                Console.WriteLine(build.ToString());
                Console.WriteLine("Press Enter to End.");
                string haha = Console.ReadLine();
            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
