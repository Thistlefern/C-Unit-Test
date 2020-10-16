using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
        public float x, y, z, w;

        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }

        public Vector4(float _x, float _y, float _z, float _w)
        {
            x = _x;
            y = _y;
            z = _z;
            w = _w;
        }

        public float Dot(Vector4 b)
        {
            return (x * b.x) + (y * b.y) + (z * b.z) + (w * b.w);
        }

        public Vector4 Cross(Vector4 b)
        {
            return new Vector4(
                (y * b.z) - (z * b.y),
                (z * b.w) - (w * b.z),
                (w * b.x) - (x * b.w),
                (x * b.y) - (y * b.x));
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
        }

        public void Normalize()
        {
            float m = Magnitude();
            x /= m;
            y /= m;
            z /= m;
            w /= m;
        }
    }
}
