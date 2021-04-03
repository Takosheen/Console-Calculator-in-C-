using ConsoleCalculatorProject.ConsolePublisher;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorMidterm2
{
    public class InputProcessor
    {

        Calculator _calculator = new Calculator();

        Calculation calc = new Calculation();

        public void Start()
        {

            var pub = new ConsolePub();
            Console.WriteLine("Please choose an operation(+,-,/,*,>/ for square root, ^2 for squaring the number), or view the history of calculations with 'History'");
            // pub.PubOp(calc);
          /*  string userInput="end";
          try
            {*/
                string userInput = Console.ReadLine();
                var sub = new ConsoleSub(userInput, pub); 
            //  userInput = calc.GetOperation();
            //change cases to call methods in pub
            // Console.WriteLine(e.Message);
            /*    }
                catch(Exception e)
                {
                    pub.PubFailed(e);
                }*/

            switch (userInput)
                {
                    case "+":
                        calc.SetOperation(userInput);
                        pub.PubAdd(getInput(calc), userInput);
                        return;
                    case "-":
                        calc.SetOperation(userInput);
                        pub.PubSub(getInput(calc), userInput);
                        return;
                    case "/":
                        calc.SetOperation(userInput);
                        pub.PubDiv(getInput(calc), userInput);
                        return;
                    case "*":
                        calc.SetOperation(userInput);
                        pub.PubMult(getInput(calc), userInput);
                        return;
                    case ">/":
                        calc.SetOperation(userInput);
                        pub.PubSqrt(getInput(calc), userInput);
                        return;
                    case "^2":
                        calc.SetOperation(userInput);
                        pub.PubPow(getInput(calc), userInput);
                        return;
                    case "History":
                        //pub.PubHist(calc, userInput);
                        InputHistory.GetInstance().ViewHistory();
                        return;
                    case "end":
                        System.Environment.Exit(1);
                        return;
                    default:
                        Console.WriteLine("Invalid operation. Enter a valid operation");
                        return;
                }

            
        }
        public Calculation getInput(Calculation calc)
        {
            Console.WriteLine(calc.GetOperation());

            if (calc.GetOperation() == ">/" || calc.GetOperation() == "^2")
            {
                Console.WriteLine("Enter the number: ");
                double a = Double.Parse(Console.ReadLine());
                calc.SetInputA(a);
            }
            else
            {
                Console.WriteLine("Enter two numbers, one at a time: ");
                double a = Double.Parse(Console.ReadLine());
                calc.SetInputA(a);
                Console.WriteLine("Enter the last number: ");
                double b = Double.Parse(Console.ReadLine());
                calc.SetInputB(b);

            }

            return calc;
        }
        public void Calculate(Calculation calc)
        {
            
            try
            {
                Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
