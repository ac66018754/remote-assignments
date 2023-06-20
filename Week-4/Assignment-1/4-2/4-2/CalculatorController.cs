using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2
{
    public class CalculatorController
    {
        private readonly ICalculator _calculator; //接實現類別的實例
        private readonly string _calculatorType; //接加減法

        //建構式注入，注入:  1.不同方式實現的計算器(結果一樣、過程不一樣)、2.加減法
        public CalculatorController(ICalculator calculator, string calculatorType)
        {
            _calculator = calculator;
            _calculatorType = calculatorType;
        }

        public int Calculate(int a, int b)
        {
            return _calculatorType == "Add" ? _calculator.Add(a, b) : _calculator.Subtract(a, b);
        }
    }
}