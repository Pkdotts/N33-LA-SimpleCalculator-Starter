using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            bool hurray = false;
            do
            {
                try
                {
                    Convert.ToDouble(argTextInput);
                    hurray = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Try Again!");
                    argTextInput = Console.ReadLine();
                }
            } while (!hurray);
            return Convert.ToDouble(argTextInput);
        }
    }
}
