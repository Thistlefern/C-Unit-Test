using System;
using System.Collections.Generic;
using System.Text;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using MathClasses;

namespace GraphicalDemo
{
    class Sprite
    {
        public Vector3 tankPos;
        public Vector3 barrelPos = new Vector3();
        public Matrix3 tankRotation;
        public Matrix3 barrelRotation;
        public float degreesOfRotation = 180;
        public bool active = true;
    }
}
