using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vengine_Lib
{
    public class Vector1
    {
        public double x;
        public Vector1()
        {
            x = 0;
        }
        public Vector1(double x)
        {
            this.x = x;
        }
        public double length1 { get { return Math.Abs(x); } }
        
    }
}
