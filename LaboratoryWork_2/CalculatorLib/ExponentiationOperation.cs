using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLib
{
    public class ExponentiationOperation : IOperation
    {
        public string OperatorCode => "^";

        public int Apply(int operand1, int operand2)
        {
            for (int i = 1; i < operand2; i += 1)
            {
                operand1 *= operand1;
            }
            return operand1;
        }
    }
}
