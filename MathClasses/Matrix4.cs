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
        private float v1;
        private float v2;
        private float v3;
        private float v4;
        private float v5;
        private float v6;
        private float v7;
        private float v8;
        private float v9;
        private float v10;
        private float v11;
        private float v12;
        private float v13;
        private float v14;
        private float v15;
        private float v16;

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
    }
}
