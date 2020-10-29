using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix3
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;

        public Matrix3()
        {
            m1 = 1; m2 = 0; m3 = 0;
            m4 = 0; m5 = 1; m6 = 0;
            m7 = 0; m8 = 0; m9 = 1;
        }

        public Matrix3(float _m1, float _m2, float _m3, float _m4, float _m5, float _m6, float _m7, float _m8, float _m9)
        {
            m1 = _m1;
            m2 = _m2;
            m3 = _m3;
            m4 = _m4;
            m5 = _m5;
            m6 = _m6;
            m7 = _m7;
            m8 = _m8;
            m9 = _m9;
        }

        public static Matrix3 operator * (Matrix3 lhs, Matrix3 rhs) // for multiplying two Matrix3s together
        {
            return new Matrix3(
                // 1   2   3
                // 4   5   6
                // 7   8   9
                lhs.m1 * rhs.m1 + lhs.m4 * rhs.m2 + lhs.m7 * rhs.m3,    // new m1
                lhs.m2 * rhs.m1 + lhs.m5 * rhs.m2 + lhs.m8 * rhs.m3,    // new m2
                lhs.m3 * rhs.m1 + lhs.m6 * rhs.m2 + lhs.m9 * rhs.m3,    // new m3

                lhs.m1 * rhs.m4 + lhs.m4 * rhs.m5 + lhs.m7 * rhs.m6,    // new m4
                lhs.m2 * rhs.m4 + lhs.m5 * rhs.m5 + lhs.m8 * rhs.m6,    // new m5
                lhs.m3 * rhs.m4 + lhs.m6 * rhs.m5 + lhs.m9 * rhs.m6,    // new m6

                lhs.m1 * rhs.m7 + lhs.m4 * rhs.m8 + lhs.m7 * rhs.m9,    // new m7
                lhs.m2 * rhs.m7 + lhs.m5 * rhs.m8 + lhs.m8 * rhs.m9,    // new m8
                lhs.m3 * rhs.m7 + lhs.m6 * rhs.m8 + lhs.m9 * rhs.m9);   // new m9
        }

        public void Set(float _m1, float _m2, float _m3, float _m4, float _m5, float _m6, float _m7, float _m8, float _m9)
        {
            m1 = _m1; m2 = _m2; m3 = _m3;
            m4 = _m4; m5 = _m5; m6 = _m6;
            m7 = _m7; m8 = _m8; m9 = _m9;
        }

        public void Set(Matrix3 other)
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
        }

        public void SetRotateX(double radians)
        {
            Set(1, 0, 0,
                0, (float)Math.Cos(radians), (float)-Math.Sin(radians),
                0, (float)Math.Sin(radians), (float)Math.Cos(radians));
        }
        public void RotateX(double radiansX)
        {
            Matrix3 rotate = new Matrix3();
            rotate.SetRotateX(radiansX);
            Set(this * rotate);
        }

        public void SetRotateY(double radians)
        {
            Set((float)Math.Cos(radians), 0, (float)Math.Sin(radians),
                0, 1, 0,
                (float)-Math.Sin(radians), 0, (float)Math.Cos(radians));
        }
        public void RotateY(double radiansY)
        {
            Matrix3 rotate = new Matrix3();
            rotate.SetRotateY(radiansY);
            Set(this * rotate);
        }

        public void SetRotateZ(double radians)
        {
            Set((float)Math.Cos(radians), (float)-Math.Sin(radians), 0,
                (float)Math.Sin(radians), (float)Math.Cos(radians), 0,
                0, 0, 1);
        }
        public void RotateZ(double radiansZ)
        {
            Matrix3 rotate = new Matrix3();
            rotate.SetRotateZ(radiansZ);
            Set(this * rotate);
        }
    }
}