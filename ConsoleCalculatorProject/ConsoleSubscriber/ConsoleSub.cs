using ConsoleCalculatorMidterm2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorProject.ConsolePublisher
{
    public class ConsoleSub
    {
        private readonly string _operation;

        public ConsoleSub(string operation, ConsolePub pub)
        {
            _operation = operation;
            pub.RaiseCalcEvent += HandleAddition;
            pub.RaiseCalcEvent += HandleDifference;
            pub.RaiseCalcEvent += HandleMultiplication;
            pub.RaiseCalcEvent += HandleDivision;
            pub.RaiseCalcEvent += HandleSquare;
            pub.RaiseCalcEvent += HandleSqrt;
            pub.RaiseCalcEvent += HandleUnassigned;
        }
        void HandleAddition(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            _proc.Calculate(e.GetCalculation);
        }
        void HandleDifference(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            _proc.Calculate(e.GetCalculation);
        }
        void HandleMultiplication(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            _proc.Calculate(e.GetCalculation);
        }
        void HandleDivision(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            _proc.Calculate(e.GetCalculation);
        }
        void HandleSquare(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            _proc.Calculate(e.GetCalculation);
        }
        void HandleSqrt(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            _proc.Calculate(e.GetCalculation);
        }
        void HandleUnassigned(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            _proc.Calculate(e.GetCalculation);
        }
        void HandleHistory(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            _proc.ViewHistory();
        }
    }
}
