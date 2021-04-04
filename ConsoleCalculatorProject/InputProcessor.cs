using ConsoleCalculatorProject.ConsolePublisher;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleCalculatorProject;

namespace ConsoleCalculatorMidterm2
{
    public class InputProcessor
    {

        Calculator _calculator = new Calculator();

        

        public void Start()
        {

            // pub.PubOp(calc);
            /*  string userInput="end";
            try
              {*/

            var pub = new ConsolePub();
            var sub = new ConsoleSub(pub);
            while (true)
            {
                Console.WriteLine("Please choose an operation(+,-,/,*,>/ for square root, ^2 for squaring the number), or view the history of calculations with 'History', and change the history with 'Modify History'");
                string userInput = Console.ReadLine();
                int count = 0;
                //  userInput = calc.GetOperation();
                //change cases to call methods in pub
                // Console.WriteLine(e.Message);
                /*    }
                    catch(Exception e)
                    {
                        pub.PubFailed(e);
                    }*/

                Calculation calc = new Calculation();

                switch (userInput)
                    {
                        case "+":
                            calc.SetOperation(userInput);
                            pub.PubAdd(getInput(calc), userInput);
                            break;
                        case "-":
                            calc.SetOperation(userInput);
                            pub.PubSub(getInput(calc), userInput);
                            break;
                        case "/":
                            calc.SetOperation(userInput);
                            pub.PubDiv(getInput(calc), userInput);
                            break;
                        case "*":
                            calc.SetOperation(userInput);
                            pub.PubMult(getInput(calc), userInput);
                            break;
                        case ">/":
                            calc.SetOperation(userInput);
                            pub.PubSqrt(getInput(calc), userInput);
                            break;
                        case "^2":
                            calc.SetOperation(userInput);
                            pub.PubPow(getInput(calc), userInput);
                            break;
                        case "History":
                            //pub.PubHist(calc, userInput);
                            InputHistory.GetInstance().ViewHistory();
                            break;
                        case "Modify History":
                            ChangeHistory hist = new ChangeHistory();
                            hist.CHistory(count);
                            break;
                        case "end":
                            System.Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("Invalid operation. Enter a valid operation");
                            break;
                }
            }


        }
        public Calculation getInput(Calculation calc)
        {

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
