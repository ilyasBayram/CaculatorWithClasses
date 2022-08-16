using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaculatorWithClasses
{
    public class Division
    {
        public double Div(Variables division)
        {
            division.Result = division.ValueFirst / division.ValueSecond;

            return division.Result;
        }
    }
}
