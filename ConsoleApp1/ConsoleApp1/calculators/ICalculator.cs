using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ICalculator
    {
        string Name { get; }

        int Id { get; }

        double getIntegralValue(IFunction function, double rangeFrom, double rangeTo);
    }
}
