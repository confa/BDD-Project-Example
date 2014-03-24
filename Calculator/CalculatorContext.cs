using System;
using System.Collections.Generic;

namespace Calculator
{
    public class CalculatorContext
    {
        public CalculatorContext()
        {
            Lets = new CalculatorCore();
            Values = new List<double>();
        }

        public List<double> Values { get; set; }
        public ICalculatorCore Lets { get; set; }
        public double Result { get; set; }
        public Exception Exception { get; set; }
    }
}