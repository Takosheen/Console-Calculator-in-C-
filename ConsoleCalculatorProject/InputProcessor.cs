using ConsoleCalculatorProject.ConsolePublisher;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorMidterm2
{
    public class InputProcessor
    {

        Calculator _calculator = new Calculator();
        InputHistory _history = new InputHistory();

        public void Start()
        {
            var pub = new ConsolePub();
            Calculation calc = new Calculation();
            Console.WriteLine("Please choose an operation(+,-,/,*,>/ for square root, ^2 for squaring the number), or view the history of calculations with 'H'");
            string userInput = Console.ReadLine();
            
            Console.WriteLine("Enter two numbers, one at a time: ");
            double a = Double.Parse(Console.ReadLine());
            calc.SetInputA(a);

            Console.WriteLine("Enter the last number: ");
            double b = Double.Parse(Console.ReadLine());
            calc.SetInputB(b);
            var sub = new ConsoleSub(userInput, pub);

            //change cases to call methods in pub
            // Console.WriteLine(e.Message);

                switch (userInput)
                {
                    case "+":
                        pub.PubAdd(calc, userInput);
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
                        pub.PubHist(calc, userInput);
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
        public void ViewHistory()
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
