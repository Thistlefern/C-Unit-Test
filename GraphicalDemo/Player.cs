using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using MathClasses;
namespace GraphicalDemo
{
    class Player : Sprite
    {
        public Texture2D tank;
        public Texture2D barrel;
        float rotation;

        public void Init(string tankFile, string barrelFile)
        {
            tank = LoadTexture(tankFile);
            barrel = LoadTexture(barrelFile);
        }
        public void Draw()
        {
            if (active != true) return;
            DrawTextureEx(tank, tankPos, rotation, 1f, WHITE);
            DrawTextureEx(barrel, barrelPos, rotation, 1f, WHITE);
        }
        public void Update()
        {
            if (IsKeyDown(KeyboardKey.KEY_W))
            {
                tankPos.Y -= 2;
                barrelPos.Y -= 2;
            }
            if (IsKeyDown(KeyboardKey.KEY_S))
            {
                tankPos.Y += 2;
                barrelPos.Y += 2;
            }
            if (IsKeyDown(KeyboardKey.KEY_A))
            {
                rotation += 1f;
            }
            if (IsKeyDown(KeyboardKey.KEY_D))
            {
                rotation -= 1f;
            }
            if(IsKeyDown(KeyboardKey.KEY_Q))
            {
                barrelPos.X += 1;
            }
            if (IsKeyDown(KeyboardKey.KEY_E))
            {
                barrelPos.X -= 1;
                
            }
        }
    }
}
