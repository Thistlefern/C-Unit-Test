using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix4
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;
        private float v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16;

        public static Matrix4 operator * (Matrix4 lhs, Matrix4 rhs) // for multiplying two Matrix3s together
        {
            return new Matrix4(
                // 1   2   3   4
                // 5   6   7   8
                // 9   10  11  12
                // 13  14  15  16

                lhs.m1 * rhs.m1 + lhs.m5 * rhs.m2 + lhs.m9 * rhs.m3 + lhs.m13 * rhs.m4,         // new m1
                lhs.m2 * rhs.m1 + lhs.m6 * rhs.m2 + lhs.m10 * rhs.m3 + lhs.m14 * rhs.m4,        // new m2
                lhs.m3 * rhs.m1 + lhs.m7 * rhs.m2 + lhs.m11 * rhs.m3 + lhs.m15 * rhs.m4,        // new m3
                lhs.m4 * rhs.m1 + lhs.m8 * rhs.m2 + lhs.m12 * rhs.m3 + lhs.m16 * rhs.m4,        // new m4

                lhs.m1 * rhs.m5 + lhs.m5 * rhs.m6 + lhs.m9 * rhs.m7 + lhs.m13 * rhs.m8,         // new m5
                lhs.m2 * rhs.m5 + lhs.m6 * rhs.m6 + lhs.m10 * rhs.m7 + lhs.m14 * rhs.m8,        // new m6
                lhs.m3 * rhs.m5 + lhs.m7 * rhs.m6 + lhs.m11 * rhs.m7 + lhs.m15 * rhs.m8,        // new m7
                lhs.m4 * rhs.m5 + lhs.m8 * rhs.m6 + lhs.m12 * rhs.m7 + lhs.m16 * rhs.m8,        // new m8

                lhs.m1 * rhs.m9 + lhs.m5 * rhs.m10 + lhs.m9 * rhs.m11 + lhs.m13 * rhs.m12,      // new m9
                lhs.m2 * rhs.m9 + lhs.m6 * rhs.m10 + lhs.m10 * rhs.m11 + lhs.m14 * rhs.m12,     // new m10
                lhs.m3 * rhs.m9 + lhs.m7 * rhs.m10 + lhs.m11 * rhs.m11 + lhs.m15 * rhs.m12,     // new m11
                lhs.m4 * rhs.m9 + lhs.m8 * rhs.m10 + lhs.m12 * rhs.m11 + lhs.m16 * rhs.m12,     // new m12

                lhs.m1 * rhs.m13 + lhs.m5 * rhs.m14 + lhs.m9 * rhs.m15 + lhs.m13 * rhs.m16,     // new m13
                lhs.m2 * rhs.m13 + lhs.m6 * rhs.m14 + lhs.m10 * rhs.m15 + lhs.m14 * rhs.m16,    // new m14
                lhs.m3 * rhs.m13 + lhs.m7 * rhs.m14 + lhs.m11 * rhs.m15 + lhs.m15 * rhs.m16,    // new m15
                lhs.m4 * rhs.m13 + lhs.m8 * rhs.m14 + lhs.m12 * rhs.m15 + lhs.m16 * rhs.m16);   // new m16
        }

        public Matrix4()
        {
            m1 = 1; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = 1; m7 = 0; m8 = 0;
            m9 = 0; m10= 0; m11= 1; m12= 0;
            m13= 0; m14= 0; m15= 0; m16= 1;
        }

        public Matrix4(float _v1, float _v2, float _v3, float _v4, float _v5, float _v6, float _v7, float _v8, float _v9, float _v10, float _v11, float _v12, float _v13, float _v14, float _v15, float _v16)
        {
            v1 = _v1;
            v2 = _v2;
            v3 = _v3;
            v4 = _v4;
            v5 = _v5;
            v6 = _v6;
            v7 = _v7;
            v8 = _v8;
            v9 = _v9;
            v10 = _v10;
            v11 = _v11;
            v12 = _v12;
            v13 = _v13;
            v14 = _v14;
            v15 = _v15;
            v16 = _v16;
        }

        public void Set(float _m1, float _m2, float _m3, float _m4, float _m5, float _m6, float _m7, float _m8, float _m9, float _m10, float _m11, float _m12, float _m13, float _m14, float _m15, float _m16)
        {
            m1 = _m1; m2 = _m2; m3 = _m3; m4 = _m4;
            m5 = _m5; m6 = _m6; m7 = _m7; m8 = _m8;
            m9 = _m9; m10 = _m10; m11 = _m11; m12 = _m12;
            m13 = _m13; m14 = _m14; m15 = _m15; m16 = _m16;
        }
        public void Set(Matrix4 other)
        {
            this.m1 = other.m1;
            this.m2 = other.m2;
            this.m3 = other.m3;
            this.m4 = other.m4;
            this.m5 = other.m5;
            this.m6 = other.m6;
            this.m7 = other.m7;
            this.m8 = other.m8;
            this.m9 = other.m9;
            this.m10 = other.m10;
            this.m11 = other.m11;
            this.m12 = other.m12;
            this.m13 = other.m13;
            this.m14 = other.m14;
            this.m15 = other.m15;
            this.m16 = other.m16;
        }

        public void SetRotateX(double radians)
        {
            Set(1, 0, 0, 0,
                0, (float)Math.Cos(radians), (float)-Math.Sin(radians), 0,
                0, (float)Math.Sin(radians), (float)Math.Cos(radians), 0,
                0, 0, 0, 1);
        }
        public void RotateX(double radiansX)
        {
            Matrix4 rotate = new Matrix4();
            rotate.SetRotateX(radiansX);
            Set(this * rotate);
        }

        public void SetRotateY(double radians)
        {
            Set((float)Math.Cos(radians), 0, (float)Math.Sin(radians), 0,
                0, 1, 0, 0,
                (float)-Math.Sin(radians), 0, (float)Math.Cos(radians), 0,
                0, 0, 0, 1);
        }
        public void RotateY(double radiansY)
        {
            Matrix4 rotate = new Matrix4();
            rotate.SetRotateY(radiansY);
            Set(this * rotate);
        }

        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), (float)-Math.Sin(radians), 0, 0,
                (float)Math.Sin(radians), (float)Math.Cos(radians), 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1);
        }
        public void RotateZ(double radiansZ)
        {
            Matrix4 rotate = new Matrix4();
            rotate.SetRotateZ(radiansZ);
            Set(this * rotate);
        }
    }
}
