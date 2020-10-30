using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
using System.Diagnostics;
using MathClasses;
using static Raylib_cs.Raylib;  // core methods (InitWindow, BeginDrawing())
using static Raylib_cs.Color;
using GraphicalDemo;

namespace GraphicalDemo
{
    class SpriteObject : SceneObject
    {
        Texture2D texture = new Texture2D();
        Image image = new Image();
        public float Width
        {
            get { return texture.width; }
        }
        public float Height
        {
            get { return texture.height; }
        }
        public SpriteObject()
        {
        }
        public void Load(string filename)
        {
            Image img = LoadImage(filename);
            texture = LoadTextureFromImage(img);
        }
        protected override void OnDraw()
        {

            float rotation = (float)Math.Atan2(
           globalTransform.m2, globalTransform.m1);
            Raylib.DrawTextureEx(
            texture,
            new System.Numerics.Vector2(globalTransform.m7, globalTransform.m8),
            rotation * (float)(180.0f / Math.PI),
            1, WHITE);

            base.OnDraw();
        }
    }

}
