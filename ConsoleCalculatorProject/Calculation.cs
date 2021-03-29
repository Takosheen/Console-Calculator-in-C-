using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorMidterm2
{
    public class Calculation
    {

        double a;
        double b;
        string operation;
        double result;
        public double GetInputA()
        {
            return a;
        }
        public double GetInputB()
        {
            return b;
        }
        public string GetOperation()
        {
            return operation;
        }
        public double GetResult()
        {
            return result;
        }
        public void SetInputA(double inputA)
        {
            a = inputA;
        }
        public void SetInputB(double inputB)
        {
            b = inputB;
        }
        public void SetOperation(string op)
        {
            operation = op;
        }
        public void SetResult(double _result)
        {
            result = _result;
        }
        public override string ToString()
        {
            return a + " " +b + " " + operation + " " + result + " ";
        }
    }
}
