using ConsoleCalculatorMidterm2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorProject.ConsolePublisher
{
    public class ConsoleSub
    {

        public ConsoleSub(ConsolePub pub)
        {

            pub.RaiseAddition += HandleAddition;
            pub.RaiseSubtraction += HandleDifference;
            pub.RaiseMultiplication += HandleMultiplication;
            pub.RaiseDivision += HandleDivision;
            pub.RaiseSquare += HandleSquare;
            pub.RaiseSqrt += HandleSqrt;
            pub.RaiseCalcEvent += HandleUnassigned;
            pub.RaiseCalcEvent += HandleHistory;
            /*pub.RaiseCalcEvent += HandleOperation;
            pub.RaiseCalcEvent += HandleInput1;
            pub.RaiseCalcEvent += HandleInput2;*/
            pub.RaiseCalcEvent += HandleError;
        }
        void HandleError(object sender, CalculationArgs e)
        {
            Console.WriteLine(e.GetException);
        }
       /* void HandleOperation(object sender, CalculationArgs e)
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

        }*/
        void HandleException(object sender, CalculationArgs e)
        {
            Console.WriteLine("Calculation failed. Error thrown.");
        }
        void HandleAddition(object sender, CalculationArgs e)
        {
            Calculator.GetResult(e.GetCalculation);
            InputHistory.GetInstance().AddHistory(e.GetCalculation);
        }
        void HandleDifference(object sender, CalculationArgs e)
        {
            Calculator.GetResult(e.GetCalculation);
            InputHistory.GetInstance().AddHistory(e.GetCalculation);

        }
        void HandleMultiplication(object sender, CalculationArgs e)
        {
            Calculator.GetResult(e.GetCalculation);
            InputHistory.GetInstance().AddHistory(e.GetCalculation);

        }
        void HandleDivision(object sender, CalculationArgs e)
        {
            Calculator.GetResult(e.GetCalculation);
            InputHistory.GetInstance().AddHistory(e.GetCalculation);

        }
        void HandleSquare(object sender, CalculationArgs e)
        {
            Calculator.GetResult(e.GetCalculation);
            InputHistory.GetInstance().AddHistory(e.GetCalculation);

        }
        void HandleSqrt(object sender, CalculationArgs e)
        {
            Calculator.GetResult(e.GetCalculation);
            InputHistory.GetInstance().AddHistory(e.GetCalculation);

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
