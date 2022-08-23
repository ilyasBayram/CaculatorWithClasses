using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculatorWithClasses
{
    public class Subtract:ICalculation
    {
       
        public double  Calculate(Variables math)
        {
          return math.Result = Math.Abs(math.ValueFirst - math.ValueSecond);
        }

    }
}
