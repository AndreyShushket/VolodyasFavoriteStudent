using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionTask
{
    enum Operation
    {
        Add,
        Substract,
        Multiply,
        Divide
    }
    static class Calculator
    {
        public static void Calculate(double x, double y, Operation operation)
        {
            double result = 0.0;

            switch(operation)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Substract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }
        }
    }
}
