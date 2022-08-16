using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculatorWithClasses
{
    public class Subtract
    {
        public double Sub(Variables subtract)
        {
            subtract.Result = Math.Abs(subtract.ValueFirst - subtract.ValueSecond);

            return subtract.Result;
        }

    }
}
