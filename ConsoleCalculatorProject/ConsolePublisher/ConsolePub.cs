using System;
using System.Collections.Generic;
using System.Text;
using ConsoleCalculatorMidterm2;


namespace ConsoleCalculatorProject.ConsolePublisher
{
    public class ConsolePub
    {

        public event EventHandler<CalculationArgs> RaiseCalcEvent;
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
            _proc.Calculate(calc);
        }
        public void PubMult(Calculation calc, String operation)
        {
            InputProcessor _proc = new InputProcessor();
            calc.SetOperation(operation);
            _proc.Calculate(calc);
        }
        public void PubDiv(Calculation calc, String operation)
        {
            InputProcessor _proc = new InputProcessor();
            calc.SetOperation(operation);
            _proc.Calculate(calc);
        }
        public void PubPow(Calculation calc, String operation)
        {
            InputProcessor _proc = new InputProcessor();
            calc.SetOperation(operation);
            _proc.Calculate(calc);
        }
        public void PubSqrt(Calculation calc, String operation)
        {
            InputProcessor _proc = new InputProcessor();
            calc.SetOperation(operation);
            _proc.Calculate(calc);
        }
        public void PubHist(Calculation calc)
        {
            InputProcessor _proc = new InputProcessor();
            _proc.ViewHistory(calc);
        }

        protected virtual void OnAddition(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseCalcEvent;
            calcEvent(this, c);
        }
        protected virtual void OnSubtraction(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseCalcEvent;
            calcEvent(this, c);
        }
        protected virtual void OnMultiplication(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseCalcEvent;
            calcEvent(this, c);
        }
        protected virtual void OnDivision(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseCalcEvent;
            calcEvent(this, c);
        }
        protected virtual void OnPower(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseCalcEvent;
            calcEvent(this, c);
        }
        protected virtual void OnSqrt(CalculationArgs c)
        {
            EventHandler<CalculationArgs> calcEvent = RaiseCalcEvent;
            calcEvent(this, c);
        }
    }
}
