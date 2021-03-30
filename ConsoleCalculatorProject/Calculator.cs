using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorMidterm2
{
    public class Calculator
    {
        public double GetResult(Calculation Calc)
        {
            double _result;
            switch (Calc.GetOperation())
            {
                case "+":
                   _result = Operations.Sum(Calc.GetInputA(),Calc.GetInputB());
                    Console.WriteLine("The Result is: "+_result);
                    return _result;
                case "-":
                    _result = Operations.Difference(Calc.GetInputA(), Calc.GetInputB());
                    Console.WriteLine("The Result is: " + _result);
                    return _result;
                case "/":
                    _result = Operations.Division(Calc.GetInputA(), Calc.GetInputB());
                    Console.WriteLine("The Result is: " + _result);
                    return _result;
                case "*":
                    _result = Operations.Multiplication(Calc.GetInputA(), Calc.GetInputB());
                    Console.WriteLine("The Result is: " + _result);
                    return _result;
                case ">/":
                    _result = Operations.Sqrt(Calc.GetInputA());
                    Console.WriteLine("The Result is: " + _result);
                    return _result;
                case "^2":
                    _result = Operations.Squared(Calc.GetInputA());
                    Console.WriteLine("The Result is: " + _result);
                    return _result;
                default:
                    _result = Operations.Unassigned(Calc.GetInputA(),Calc.GetInputB());
                    Console.WriteLine("Operation unassigned. Enter a valid operation.");
                    return _result;
            }
                

        }
    }
}
