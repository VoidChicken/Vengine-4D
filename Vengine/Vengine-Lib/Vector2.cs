using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vengine_Lib
{
    public class Vector2 : Vector1
    {
        public double y = 0;
        public Vector2() : base() { y = 0; }
        public Vector2(double x, double y) : base(x)
        {
            this.y = y;
        }
        public double length2
        {
            get
            {
                return Math.Sqrt(x * x + y * y);
            }

        }
        public static explicit operator SharpDX.Vector2(Vector2 v)
        {
            return new SharpDX.Vector2((float)v.x,(float)v.y);
        }
        public static explicit operator OpenTK.Vector2(Vector2 v)
        {
            return new OpenTK.Vector2((float)v.x, (float)v.y);
        }
    }
}
