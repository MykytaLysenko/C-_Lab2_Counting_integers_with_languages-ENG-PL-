using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CalculatorFactory
    {
        public ICalculator getCalculator(int calcId)
        {
            switch (calcId)
            {
                case 1:
                    return new RectangleCalculator();
                    break;
                case 2:
                    return new TrapeziumCalculator();
            }
            return null;
        }
    }
}
