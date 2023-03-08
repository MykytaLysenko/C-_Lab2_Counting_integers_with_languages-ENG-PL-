using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FunctionFactory
    {
        public IFunction getFunction(int functionId)
        {
            switch (functionId)
            {
                case 1:
                    return new Function1();
                    break;
                case 2:
                    return new Function2();
                    break;
                case 3:
                    return new Function3();
                    break;
                case 4:
                    return new Function4();
                    break;
            }
            return null;
        }
    }
}
