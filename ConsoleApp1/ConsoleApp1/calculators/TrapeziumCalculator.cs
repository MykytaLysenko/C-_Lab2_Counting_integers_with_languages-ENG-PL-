using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TrapeziumCalculator : ICalculator
    {
        LanguageService langService = LanguageService.getInstance();

        public string Name { get => langService.translate("KALKULATOR_TRAPEZOW"); } 

        public int Id { get => 2; }

        public double getIntegralValue(IFunction function, double rangeFrom, double rangeTo)
        {
            double h = (rangeTo - rangeFrom) / 10;
            double x;

            double res = (function.getY(rangeFrom) + function.getY(rangeTo)) / 2;

            for (x = rangeFrom + h; x < rangeTo; x += h)
            {
                res += function.getY(x);
            }

            res = res * h;

            return res;
        }
    }
}
