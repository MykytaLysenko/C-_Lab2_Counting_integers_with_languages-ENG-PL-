using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Function3 : IFunction
    {
        public int Id { get => 3; }

        public string Name { get => "y = 2x -3"; } 
 
        public double getY(double x)
        {
            return 2 * x - 3;
        }
    }
}
