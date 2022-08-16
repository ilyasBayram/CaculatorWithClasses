using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculatorWithClasses
{
    public class Multiply
    {
        public double Mul(Variables multiply)
        {
            multiply.Result = multiply.ValueFirst * multiply.ValueSecond;

            return multiply.Result;
        }
    }
}
