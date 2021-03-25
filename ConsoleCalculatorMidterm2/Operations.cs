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
        public static Func<double, double, double> Squared = (a, b) => Math.Pow(a, 2);
        public static Func<double, double, double> Sqrt = (a, b) => Math.Sqrt(a);
        public static Func<double, double, double> Unassigned = (a, b) => 0;
    }
}
