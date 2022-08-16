using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculatorWithClasses
{
    public class Addition
    {
        public double Add (Variables addition)
        {
            addition.Result = addition.ValueFirst + addition.ValueSecond;

            return addition.Result;
        }
    }
}
