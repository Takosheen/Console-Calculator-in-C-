using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorMidterm2
{
    public class Operations
    {
        public static Func<double, double, double> Sum = (a, b) => a + b;
        public static Func<double, double, double> Difference = (a, b) => a - b;
        public static Func<double, double, double> Multiplication = (a, b) => a * b;
        public static Func<double, double, double> Division = (a, b) => a / b;
        public static Func<double, double> Squared = (a) => Math.Pow(a, 2);
        public static Func<double, double> Sqrt = (a) => Math.Sqrt(a);
        public static Func<double, double, double> Unassigned = (a, b) => 0;
    }
}
