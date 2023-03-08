using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Function4 : IFunction
    {
        public int Id { get => 4; }

        public string Name { get => "y = 3x^2 + 2x + 3"; }

        public double getY(double x)
        {
            return 2 * Math.Pow(x,2) + 2*x + 3;
        }

    }
}
