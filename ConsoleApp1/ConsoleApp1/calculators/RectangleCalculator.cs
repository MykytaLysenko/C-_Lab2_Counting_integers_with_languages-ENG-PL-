using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RectangleCalculator : ICalculator
    {
        LanguageService langService = LanguageService.getInstance();

        public string Name { get => langService.translate("KALKULATOR_PROSTOKATOW"); }

        public int Id { get => 1; } 

        public double getIntegralValue(IFunction function, double rangeFrom, double rangeTo)
        {
            double res = 0.0;
            double x;
            double h = (rangeTo - rangeFrom) / 10;

            for (x = rangeFrom + h / 2; x < rangeTo; x += h)
            {
                res += function.getY(x) * h;
            }

            return res;
        }
    }
}
