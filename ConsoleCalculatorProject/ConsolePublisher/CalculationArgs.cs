using ConsoleCalculatorMidterm2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorProject.ConsolePublisher
{
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
}
