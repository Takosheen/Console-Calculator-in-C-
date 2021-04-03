using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorMidterm2
{
    public class Calculator
    {
        public static double GetResult(Calculation Calc)
        {

            switch (Calc.GetOperation())
            {
                case "+":
                    Calc.SetResult(Operations.Sum(Calc.GetInputA(), Calc.GetInputB()));
                    Console.WriteLine("The Result is: " + Calc.GetResult());
                    return Calc.GetResult();
                case "-":
                    Calc.SetResult(Operations.Difference(Calc.GetInputA(), Calc.GetInputB()));
                    Console.WriteLine("The Result is: " + Calc.GetResult());
                    return Calc.GetResult();
                case "/":
                    Calc.SetResult(Operations.Division(Calc.GetInputA(), Calc.GetInputB()));
                    Console.WriteLine("The Result is: " + Calc.GetResult());
                    return Calc.GetResult();
                case "*":
                    Calc.SetResult(Operations.Multiplication(Calc.GetInputA(), Calc.GetInputB()));
                    Console.WriteLine("The Result is: " + Calc.GetResult());
                    return Calc.GetResult();
                case ">/":
                    Calc.SetResult(Operations.Sqrt(Calc.GetInputA()));
                    Console.WriteLine("The Result is: " + Calc.GetResult());
                    return Calc.GetResult();
                case "^2":
                    Calc.SetResult(Operations.Squared(Calc.GetInputA()));
                    Console.WriteLine("The Result is: " + Calc.GetResult());
                    return Calc.GetResult();
                default:
                    double _result = Operations.Unassigned(Calc.GetInputA(), Calc.GetInputB());
                    Console.WriteLine("Operation unassigned. Enter a valid operation.");
                    return _result;


                                   /* case "+":
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
                case "History":
                    InputHistory _proc = new InputHistory();
                    Console.WriteLine(_proc.GetHistory());
                    return;
                default:
                    _result = Operations.Unassigned(Calc.GetInputA(),Calc.GetInputB());
                    Console.WriteLine("Operation unassigned. Enter a valid operation.");
                    return _result;
                */
            }


        }
    }
}
