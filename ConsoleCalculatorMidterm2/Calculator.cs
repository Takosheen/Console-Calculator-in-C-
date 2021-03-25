using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorMidterm2
{
    public class Calculator
    {
        public double getResult(double a, double b, string op)
        {
            double _result;
            switch (op)
            {
                case "+":
                   _result = Operations.Sum(a,b);
                    Console.WriteLine(_result);
                    return _result;
          
                default:
                    return 3;
            }
                

        }
    }
}
