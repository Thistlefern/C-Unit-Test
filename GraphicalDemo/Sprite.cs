using System;
using System.Collections.Generic;
using System.Text;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using MathClasses;
using System.Numerics;

namespace GraphicalDemo
{
    class Sprite
    {
        public Vector2 tankPos = new Vector2();
        public Vector2 barrelPos = new Vector2();
        public bool active = true;
    }
}
