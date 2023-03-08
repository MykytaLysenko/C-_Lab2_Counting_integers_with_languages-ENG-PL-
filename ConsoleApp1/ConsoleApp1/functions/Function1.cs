using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Function1 : IFunction
    {
        public int Id { get => 1; } 

        public string Name { get => "y = 2x + 2x^2"; } 

        public double getY(double x)
        {
            return 2*x + Math.Pow(x, 2);
        }
    }
}
