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
            Console.WriteLine("Event raised.");
            _operation = operation;
            pub.RaiseCalcEvent += HandleAddition;
            pub.RaiseCalcEvent += HandleDifference;
            pub.RaiseCalcEvent += HandleMultiplication;
            pub.RaiseCalcEvent += HandleDivision;
            pub.RaiseCalcEvent += HandleSquare;
            pub.RaiseCalcEvent += HandleSqrt;
            pub.RaiseCalcEvent += HandleUnassigned;
            pub.RaiseCalcEvent += HandleOperation;
            pub.RaiseCalcEvent += HandleHistory;
            pub.RaiseCalcEvent += HandleInput1;
            pub.RaiseCalcEvent += HandleInput2;
            pub.RaiseCalcEvent += HandleError;
        }
        void HandleError(object sender, CalculationArgs e)
        {
            Console.WriteLine(e.GetException);
        }
        void HandleOperation(object sender, CalculationArgs e)
        {
            Console.WriteLine("Operation Handled.");
        }
        void HandleInput1(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            _proc.Calculate(e.GetCalculation);

        }
        void HandleInput2(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            _proc.Calculate(e.GetCalculation);

        }
        void HandleException(object sender, CalculationArgs e)
        {
            Console.WriteLine("Calculation failed. Error thrown.");
        }
        void HandleAddition(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            Calculator.GetResult(e.GetCalculation);
            InputHistory.GetInstance().AddHistory(e.GetCalculation);
            _proc.Calculate(e.GetCalculation);
        }
        void HandleDifference(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            Calculator.GetResult(e.GetCalculation);
            InputHistory.GetInstance().AddHistory(e.GetCalculation);
            _proc.Calculate(e.GetCalculation);
        }
        void HandleMultiplication(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            Calculator.GetResult(e.GetCalculation);
            InputHistory.GetInstance().AddHistory(e.GetCalculation);
            _proc.Calculate(e.GetCalculation);
        }
        void HandleDivision(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            Calculator.GetResult(e.GetCalculation);
            InputHistory.GetInstance().AddHistory(e.GetCalculation);
            _proc.Calculate(e.GetCalculation);
        }
        void HandleSquare(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            Calculator.GetResult(e.GetCalculation);
            InputHistory.GetInstance().AddHistory(e.GetCalculation);
            _proc.Calculate(e.GetCalculation);
        }
        void HandleSqrt(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            Calculator.GetResult(e.GetCalculation);
            InputHistory.GetInstance().AddHistory(e.GetCalculation);
            _proc.Calculate(e.GetCalculation);
        }
        void HandleUnassigned(object sender, CalculationArgs e)
        {
            InputProcessor _proc = new InputProcessor();
            _proc.Calculate(e.GetCalculation);
        }
        void HandleHistory(object sender, CalculationArgs e)
        {

            InputHistory.GetInstance().ViewHistory();
            
        }
    }
}
