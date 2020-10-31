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
    class Tank : SpriteObject
    {
        // create uninitialized tank

        public Tank()
        {
            // ...
        }
        
        // load sprites and attach turret
        public Tank(string tankImageFilePath, string turretImageFilePath)
        {
            
        }
        
        // unload images
        ~Tank()
        {
            // ...
        }
        
        // load sprites and attach turret
        public void Setup(string tankImageFilePath, string turretImageFilePath)
        {
            // ...
        }
        
        // update tank/turret movement
        public virtual void OnUpdate(float deltaTime)
        {
            // ...
        }
        
        private SpriteObject m_turret;
        
        // add speed variables
    }
}
