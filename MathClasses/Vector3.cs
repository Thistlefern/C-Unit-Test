using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector3
    {
        public float x, y, z;

        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Vector3(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public float Dot(Vector3 b)
        {
            return (x * b.x) + (y * b.y) + (z * b.z);
        }

        public Vector3 Cross(Vector3 b)
        {
            return new Vector3(
                (y * b.z) - (z * b.y),
                (z * b.x) - (x * b.z),
                (x * b.y) - (y * b.x));
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y) + (z * z));
        }

        public void Normalize()
        {
            float m = Magnitude();
            x /= m;
            y /= m;
            z /= m;
        }

        // Define an operator for converting from MathLibrary.Vector3 to System.Numerics.Vector3
        // ie from our type to Raylib's type
        public static implicit operator System.Numerics.Vector3(Vector3 source)
        {
            return new System.Numerics.Vector3(source.x, source.y, source.z);
        }

        // Define an operator for converting from System.Numerics.Vector3 MathLibrary.Vector3
        // ie from Raylib's type to our type
        public static implicit operator Vector3(System.Numerics.Vector3 source)
        {
            return new Vector3(source.X, source.Y, source.Z);
        }
    }
}
