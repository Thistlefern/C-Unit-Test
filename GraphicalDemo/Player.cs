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
                           new Rectangle(0, 0, tank.width, tank.height),                    // upper left
                           new Rectangle(tankPos.x, tankPos.y, tank.width, tank.height),    // lower right
                           new System.Numerics.Vector2(tank.width / 2, tank.height / 2),    // point of origin
                           degreesOfRotation,                                               // rotation
                           WHITE);                                                          // color
            DrawTexturePro(barrel,                                                              // texture 
                           new Rectangle(0, 0, barrel.width, barrel.height),                    // upper left
                           new Rectangle(0, 0, barrel.width, barrel.height),                    // lower right
                           new System.Numerics.Vector2(barrel.width / 2, barrel.height / 2),    // point of origin
                           0,                                                                   // rotation
                           WHITE);                                                              // color
        }
        public void Update()
        {
            if (IsKeyDown(KeyboardKey.KEY_W))
            {
                tankPos.x++;
            }
            if (IsKeyDown(KeyboardKey.KEY_S))
            {
                
            }
            if (IsKeyDown(KeyboardKey.KEY_A))
            {
                degreesOfRotation--;
                tankRotation.SetRotateX(degreesOfRotation);
            }
            if (IsKeyDown(KeyboardKey.KEY_D))
            {
                degreesOfRotation++;
                tankRotation.SetRotateX(degreesOfRotation);
            }
            if(IsKeyDown(KeyboardKey.KEY_Q))
            {
                
            }
            if (IsKeyDown(KeyboardKey.KEY_E))
            {
                
            }
        }
    }
}
