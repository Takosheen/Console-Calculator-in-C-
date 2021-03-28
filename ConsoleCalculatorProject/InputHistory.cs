using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculatorMidterm2
{
    public class InputHistory
    {
        List<Calculation> CalcList = new List<Calculation>();
        public void AddHistory(Calculation calc)
        {
            CalcList.Add(calc);
        }
        public List<Calculation> GetHistory()
        {
            return CalcList;
        }

    }
}
