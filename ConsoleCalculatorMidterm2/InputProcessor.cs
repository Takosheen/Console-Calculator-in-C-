﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorMidterm2
{
    public class InputProcessor
    {
        Calculation _calculation = new Calculation();
        Calculator _calculator = new Calculator();
        InputHistory _history = new InputHistory();
        public void Start()
        {
            Console.WriteLine("Please choose an operation(+,-,/,*,>/ for square root, ^2 for squaring the number), or view the history of calculations with 'H'");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "+":
                    _calculation.SetOperation(userInput);
                    Calculate();
                    return;
                case "-":
                    _calculation.SetOperation(userInput);
                    Calculate();
                    return;
                case "/":
                    _calculation.SetOperation(userInput);
                    Calculate();
                    return;
                case "*":
                    _calculation.SetOperation(userInput);
                    Calculate();
                    return;
                case ">/":
                    _calculation.SetOperation(userInput);
                    Calculate();
                    return;
                case "^2":
                    _calculation.SetOperation(userInput);
                    Calculate();
                    return;
                case "H":
                    ViewHistory();
                    return;
                case "end":
                    return;
                default:
                    Console.WriteLine("Enter valid operation");
                    return;
            }

        }
        public void Calculate()
        {
            try
            {

                Console.WriteLine("Enter two numbers, one at a time: ");
                double a = Double.Parse(Console.ReadLine());
                _calculation.SetInputA(a);
                Console.WriteLine("Enter the last number: ");
                double b = Double.Parse(Console.ReadLine());
                _calculation.SetInputB(b);
                _calculator.GetResult(_calculation);
                _history.AddHistory(_calculation);
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
