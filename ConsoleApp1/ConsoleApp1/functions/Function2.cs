using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Function2 : IFunction
    {
        public int Id { get => 2; } 

        public string Name { get => "y = 2x^2"; }

        public double getY(double x)
        {
            return 2 * Math.Pow(x,2);
        }

    }
}
