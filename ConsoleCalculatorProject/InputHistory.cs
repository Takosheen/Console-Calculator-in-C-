using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorMidterm2
{
    public class InputHistory
    {
        List<Calculation> CalcList = new List<Calculation>();
        private static InputHistory _instance;


        private InputHistory()
        {
            CalcList = new List<Calculation>();
        }
        public static InputHistory GetInstance()
        {
            if(_instance == null)
            {
                _instance = new InputHistory();
            }
            return _instance;
        }
        public void AddHistory(Calculation calc)
        {
            CalcList.Add(calc);
        }
        public List<Calculation> GetHistory()
        {
            return CalcList;
        }
        public void ViewHistory()
        {
            Calculation[] calcArray = CalcList.ToArray();
            Console.WriteLine("View History");
            for (int i = 0; i < calcArray.Length; i++)
            {
                Console.WriteLine(calcArray[i].ToString());
            }

        }

    }
}
