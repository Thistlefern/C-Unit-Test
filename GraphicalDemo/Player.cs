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

        public void Init(string tankFile, string barrelFile)
        {
            tank = LoadTexture(tankFile);
            barrel = LoadTexture(barrelFile);
        }
        public void Draw()
        {
            if (active != true) return;
            DrawTexturePro(tank,                                                            // texture 
                           new Rectangle(0,0,tank.width, tank.height),                      // upper left
                           new Rectangle(tankPos.X, tankPos.Y, tank.width, tank.height),    // lower right
                           new System.Numerics.Vector2(tank.width / 2, tank.height / 2),    // point of origin
                           rotation,                                                            // rotation
                           WHITE);                                                          // color
            DrawTexturePro(barrel,                                                                  // texture 
                           new Rectangle(0, 0, barrel.width, barrel.height),                        // upper left
                           new Rectangle(barrelPos.X, barrelPos.Y, barrel.width, barrel.height),    // lower right
                           new System.Numerics.Vector2(barrel.width / 2, barrel.height / 2),        // point of origin
                           rotation,                                                                    // rotation
                           WHITE);                                                                  // color
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
                rotation -= 1;
            }
            if (IsKeyDown(KeyboardKey.KEY_D))
            {
                rotation += 1;
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
