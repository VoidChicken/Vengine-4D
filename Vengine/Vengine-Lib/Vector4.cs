using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vengine_Lib
{
    public class Vector4 : Vector3
    {
        public double w;
        public Vector4(double x, double y, double z, double w) : base(x,y,z)
        {
            this.w = w;
        }
        public double length4
        {
            get
            {
                return Math.Sqrt(x * x + y * y + z * z + w * w);
            }
        }
        public static explicit operator SharpDX.Vector4(Vector4 v)
        {
            return new SharpDX.Vector4((float)v.x, (float)v.y, (float) v.z, (float)v.w);
        }
        public static explicit operator OpenTK.Vector4(Vector4 v)
        {
            return new OpenTK.Vector4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        }
    }
}
