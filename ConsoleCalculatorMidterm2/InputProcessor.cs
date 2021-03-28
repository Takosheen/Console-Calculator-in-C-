using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorMidterm2
{
    public class InputProcessor
    {

        Calculator _calculator = new Calculator();
        InputHistory _history = new InputHistory();
        public class CalculationArgs : EventArgs
        {
            public CalculationArgs(Calculation c, string op)
            {
                GetOperation = op;
                GetCalculation = c;
            }
            public string GetOperation { get; set; }
            public Calculation GetCalculation { get; set; }
   
        }
        public class Publisher
        {

            public event EventHandler<CalculationArgs> RaiseCalcEvent;
            public void PubAdd(Calculation calc,String operation)
            {
                /*InputProcessor _proc = new InputProcessor();
                OnAddition(calc);*/

                calc.SetOperation(operation);
                CalculationArgs calcArgs = new CalculationArgs(calc,operation);
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
                calcEvent(this,c);
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

        //Class that subscribes to an event
        public class Subscriber
        {
            private readonly string _operation;

            public Subscriber(string operation, Publisher pub)
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
        }
        public void Start()
        {
            var pub = new Publisher();
            Calculation calc = new Calculation();
            Console.WriteLine("Please choose an operation(+,-,/,*,>/ for square root, ^2 for squaring the number), or view the history of calculations with 'H'");
            string userInput = Console.ReadLine();
            var sub = new Subscriber(userInput, pub);
            Console.WriteLine("Enter two numbers, one at a time: ");
            double a = Double.Parse(Console.ReadLine());
            calc.SetInputA(a);
            Console.WriteLine("Enter the last number: ");
            double b = Double.Parse(Console.ReadLine());
            calc.SetInputB(b);

            //change cases to call methods in pub
           // Console.WriteLine(e.Message);
            switch (userInput)
            {
                case "+":
                    pub.PubAdd(calc,userInput);
                    return;
                case "-":
                    pub.PubSub(calc, userInput);
                    return;
                case "/":
                    pub.PubDiv(calc, userInput);
                    return;
                case "*":
                    pub.PubMult(calc, userInput);
                    return;
                case ">/":
                    pub.PubSqrt(calc, userInput);
                    return;
                case "^2":
                    pub.PubPow(calc, userInput);
                    return;
                case "H":
                    pub.PubHist(calc);
                    return;
                case "end":
                    return;
                default:
                    Console.WriteLine("Invalid operation. Enter a valid operation");
                    return;
            }
        }
        public void Calculate(Calculation calc)
        {
            try
            {

                _calculator.GetResult(calc);
                _history.AddHistory(calc);
                Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void ViewHistory(Calculation calc)
        {
            List<Calculation> calcList = _history.GetHistory();
            Calculation[] calcArray = calcList.ToArray();
            for(int i = 0; i < calcArray.Length; i++)
            {
                Console.WriteLine(calcArray[i].ToString());
            }
           
        }

    }
}
