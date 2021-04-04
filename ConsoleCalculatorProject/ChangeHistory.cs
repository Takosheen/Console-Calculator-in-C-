using ConsoleCalculatorMidterm2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleCalculatorProject
{
    public class ChangeHistory
    {
        public void CHistory(int count)
        {
            try
            {
                List<Calculation> CalcList = InputHistory.GetInstance().GetHistory();
                Console.WriteLine("Enter Change(default to 0, or first object in the list), Next, Previous, First, or Last");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "Change":
                        Change(CalcList, count);
                        break;
                    case "Next":
                        count++;
                        Next(CalcList, count);
                        break;
                    case "Previous":
                        count--;
                        Previous(CalcList, count);
                        break;
                    case "First":
                        count = 0;
                        First(CalcList, count);
                        break;
                    case "Last":
                        Last(CalcList, count);
                        count = CalcList.Count();
                        break;
                    default:
                        break;
                }
            } 
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                CHistory(count);
            }

        }
        public static void Change(List<Calculation> calcList, int count)
        {
            Console.WriteLine("Enter what you would like to change(Input1, Input2, Operation, Result): ");
            string userInput = Console.ReadLine();
            Calculation tempCalc = calcList[count];

            switch (userInput)
            {
                case "Input1":
                    Console.WriteLine("Enter input: ");
                    double a = Double.Parse(Console.ReadLine());
                    tempCalc.SetInputA(a);
                    Calculator.GetResult(tempCalc);
                    InputHistory.GetInstance().InsertHistory(tempCalc,count);
                    break;
                case "Input2":
                    Console.WriteLine("Enter input: ");
                    double b = Double.Parse(Console.ReadLine());
                    tempCalc.SetInputB(b);
                    Calculator.GetResult(tempCalc);
                    InputHistory.GetInstance().InsertHistory(tempCalc, count);
                    break;
                case "Operation":
                    Console.WriteLine("Enter input: ");
                    string op = Console.ReadLine();
                    tempCalc.SetOperation(op);
                    Calculator.GetResult(tempCalc);
                    InputHistory.GetInstance().InsertHistory(tempCalc, count);
                    break;
                case "Result":
                    Console.WriteLine("Enter input: ");
                    double res = Double.Parse(Console.ReadLine());
                    tempCalc.SetResult(res);
                    Calculator.GetResult(tempCalc);
                    InputHistory.GetInstance().InsertHistory(tempCalc, count);
                    break;
                default:
                    break;
            }
            
        }
        public void Next(List<Calculation> CalcList, int count)
        {
            Console.WriteLine(CalcList[count]);
            CHistory(count);
        }
        public void Previous(List<Calculation> CalcList, int count)
        {
            Console.WriteLine(CalcList[count]);
            CHistory(count);
        }
        public void First(List<Calculation> CalcList, int count)
        {
            Console.WriteLine(CalcList.First());
            CHistory(count);
        }
        public void Last(List<Calculation> CalcList,int count)
        {
            Console.WriteLine(CalcList.Last());
            CHistory(count);
        }

    }
}
