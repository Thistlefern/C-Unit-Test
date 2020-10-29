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

        public static Vector3 operator + (Vector3 lhs, Vector3 rhs) // vec3 + vec3
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }
        public static Vector3 operator - (Vector3 lhs, Vector3 rhs) // vec3 - vec3
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }
        public static Vector3 operator * (Vector3 lhs, float rhs) // vec3 * float
        {
            return new Vector3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        }
        public static Vector3 operator * (float lhs, Vector3 rhs) // float * vec3
        {
            return new Vector3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        }
        public static Vector3 operator * (Matrix3 lhs, Vector3 rhs) // mat3 * vec3
        {
            return new Vector3((lhs.m1 * rhs.x) + (lhs.m4 * rhs.y) + (lhs.m7 * rhs.z),
                               (lhs.m2 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m8 * rhs.z),
                               (lhs.m3 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m9 * rhs.z));
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

        public float Distance(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
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
