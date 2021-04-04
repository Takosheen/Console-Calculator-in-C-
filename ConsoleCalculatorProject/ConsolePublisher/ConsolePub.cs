using System;
using System.Collections.Generic;
using System.Text;
using ConsoleCalculatorMidterm2;


namespace ConsoleCalculatorProject.ConsolePublisher
{
    public class ConsolePub
    {
        public event EventHandler<CalculationArgs> RaiseCalcEvent;
        public event EventHandler<CalculationArgs> RaiseAddition;
        public event EventHandler<CalculationArgs> RaiseSubtraction;
        public event EventHandler<CalculationArgs> RaiseMultiplication;
        public event EventHandler<CalculationArgs> RaiseDivision;
        public event EventHandler<CalculationArgs> RaiseSquare;
        public event EventHandler<CalculationArgs> RaiseSqrt;

        public void PubAdd(Calculation calc, String operation)
        {
            /*InputProcessor _proc = new InputProcessor();
            OnAddition(calc);*/
            
            calc.SetOperation(operation);
            CalculationArgs calcArgs = new CalculationArgs(calc, operation);
            OnAddition(calcArgs);
        }
        public void PubSub(Calculation calc, String operation)
        {
            InputProcessor _proc = new InputProcessor();
            calc.SetOperation(operation);
            CalculationArgs calcArgs = new CalculationArgs(calc, operation);
            OnSubtraction(calcArgs);

        }
        public void PubMult(Calculation calc, String operation)
        {
            InputProcessor _proc = new InputProcessor();
            calc.SetOperation(operation);
            CalculationArgs calcArgs = new CalculationArgs(calc, operation);
            OnMultiplication(calcArgs);
        }
        public void PubDiv(Calculation calc, String operation)
        {
            InputProcessor _proc = new InputProcessor();
            calc.SetOperation(operation);
            CalculationArgs calcArgs = new CalculationArgs(calc, operation);
            OnSubtraction(calcArgs);
        }
        public void PubPow(Calculation calc, String operation)
        {
            InputProcessor _proc = new InputProcessor();
            calc.SetOperation(operation);
            CalculationArgs calcArgs = new CalculationArgs(calc, operation);
            OnPower(calcArgs);
        }
        public void PubSqrt(Calculation calc, String operation)
        {
            InputProcessor _proc = new InputProcessor();
            calc.SetOperation(operation);
            CalculationArgs calcArgs = new CalculationArgs(calc, operation);
            OnSqrt(calcArgs);

        }
        public void PubHist(Calculation calc, String operation)
        {
            CalculationArgs calcArgs = new CalculationArgs(calc, operation);
            OnHist(calcArgs);

        }

        public void PubOp(Calculation calc)
        {
            string userInput = Console.ReadLine();
            calc.SetOperation(userInput);
            Console.WriteLine("Operation Received");
            Console.WriteLine(userInput);
            CalculationArgs calcArgs = new CalculationArgs(calc, userInput);
            OnOperation(calcArgs);

        }
        public void PubInput1(Calculation calc)
        {
            
            double Input1 = Double.Parse(Console.ReadLine());
            calc.SetInputA(Input1);
            Console.WriteLine("Input Received");
            Console.WriteLine(Input1);
            String s = "";
            CalculationArgs calcArgs = new CalculationArgs(calc, s);
            OnOperation(calcArgs);



        }
        public void PubInput2(Calculation calc)
        {
            double Input2 = Double.Parse(Console.ReadLine());
            calc.SetInputB(Input2);
            Console.WriteLine("Input Received");
            Console.WriteLine(Input2);
            String s = "";
            CalculationArgs calcArgs = new CalculationArgs(calc, s);
            OnOperation(calcArgs);

        }
        protected virtual void OnOperation(CalculationArgs c)
        {

            EventHandler<CalculationArgs> calcEvent = RaiseCalcEvent;
            calcEvent(this, c);
        }
        protected virtual void OnInput1(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseCalcEvent;
            calcEvent(this, c);
        }

        protected virtual void OnInput2(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseCalcEvent;
            calcEvent(this, c);
        }
       /* public void PubFailed(CalculationArgs e)
        {
            OnFailure(e);
        }
        protected virtual void OnFailure(CalculationArgs e)
        {
            if (e != null)
            {
                EventHandler<CalculationArgs> calcEvent = RaiseCalcEvent;
                calcEvent(this, e);
            }
            Console.WriteLine("Calc Args is not null. Moving on.");
        }*/
        protected virtual void OnAddition(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseAddition;
            calcEvent(this, c);
        }
        protected virtual void OnSubtraction(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseSubtraction;
            calcEvent(this, c);
        }
        protected virtual void OnMultiplication(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseMultiplication;
            calcEvent(this, c);
        }
        protected virtual void OnDivision(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseDivision;
            calcEvent(this, c);
        }
        protected virtual void OnPower(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseSquare;
            calcEvent(this, c);
        }
        protected virtual void OnSqrt(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseSqrt;
            calcEvent(this, c);
        }
        protected virtual void OnHist(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseCalcEvent;
            calcEvent(this, c);
        }
    }
}
