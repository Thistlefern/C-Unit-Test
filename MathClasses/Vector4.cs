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
        {                       // 13.5f, -48.23f, 862, 0);
            return new Vector4( // (5, 3.99f, -12, 1);
                                // (-2860.62011719f, 4472.00000000f, 295.01498413f, 0)));
                (y * b.z) - (z * b.y),
                (z * b.x) - (x * b.z),
                (x * b.y) - (y * b.x),
                0);
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
        public float Distance(Vector4 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            float diffW = w - other.w;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ + diffW * diffW);
        }

    }
}
