using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorMidterm2
{
    public class InputProcessor
    {
        Calculation _calculation = new Calculation();
        Calculator _calculator = new Calculator();
        public void Start()
        {

            try
            {
                Console.WriteLine("Please choose an operation(+,-,/,*,>/ for square root, ^2 for squaring the number), or view the history of calculations with 'H'");
                string operation = Console.ReadLine();
                _calculation.SetOperation(operation);
                Console.WriteLine("Enter two numbers, one at a time: ");
                double a = Double.Parse(Console.ReadLine());
                _calculation.SetInputA(a);
                Console.WriteLine("Enter the last number: ");
                double b = Double.Parse(Console.ReadLine());
                _calculation.SetInputB(b);
                _calculator.getResult(a, b, operation);
                Start();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        

    }
}
