using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vengine_Lib
{
    public class Vector3 : Vector2
    {
        public double z = 0;
        public Vector3() : base()
        {
            z = 0;
        }
        public Vector3(double x, double y, double z) : base(x,y)
        {
            this.z = z;
        }
        public double length3
        {
            get
            {
                return Math.Sqrt(x * x + y * y + z * z);
            }
        }
        public static explicit operator SharpDX.Vector3(Vector3 v)
        {
            return new SharpDX.Vector3((float)v.x, (float)v.y, (float)v.z);
        }
        public static explicit operator OpenTK.Vector3(Vector3 v)
        {
            return new OpenTK.Vector3((float)v.x, (float)v.y, (float)v.z);
        }
    }
}
