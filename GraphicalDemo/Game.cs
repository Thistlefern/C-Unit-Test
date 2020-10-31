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
    class Game
    {
        Stopwatch stopwatch = new Stopwatch();
        private long currentTime = 0;
        private long lastTime = 0;
        private float timer = 0;
        private int fps = 1;
        private int frames;
        private float deltaTime = 0.005f;

        SceneObject bulletObject = new SceneObject();
        SceneObject tankObject = new SceneObject();
        SceneObject turretObject = new SceneObject();
        SpriteObject bulletSprite = new SpriteObject();
        SpriteObject tankSprite = new SpriteObject();
        SpriteObject turretSprite = new SpriteObject();

        bool bulletActive = false;


        public void Init()
        {
            stopwatch.Start();
            lastTime = stopwatch.ElapsedMilliseconds;

            bulletSprite.Load(@"res\bulletGreenSilver_outline.png");

            tankSprite.Load(@"res\tankGreen_outline.png");
            tankSprite.SetPosition(-tankSprite.Width / 2.0f, -tankSprite.Height / 2.0f); // sets an offset for the base, so it rotates around the centre
            
            turretSprite.Load(@"res\barrelGreen_outline.png");
            turretSprite.SetPosition(0, -turretSprite.Height / 2.0f); // set the turret offset from the tank base


            // set up the scene object hierarchy - parent the turret to the base,
            // then the base to the tank sceneObject

            bulletObject.AddChild(bulletSprite);
            turretObject.AddChild(turretSprite);
            tankObject.AddChild(tankSprite);
            tankObject.AddChild(turretObject);
            // having an empty object for the tank parent means we can set the
            // position/rotation of the tank without
            // affecting the offset of the base sprite
            bulletObject.SetPosition(GetScreenWidth() / 2.0f, GetScreenHeight() / 2.0f);
            tankObject.SetPosition(GetScreenWidth() / 2.0f, GetScreenHeight() / 2.0f);
        }
        public void Shutdown()
        { }
        public void Update()
        {
            currentTime = stopwatch.ElapsedMilliseconds;
            deltaTime = (currentTime - lastTime) / 1000.0f;
            timer += deltaTime;
            if (timer >= 1)
            {
                fps = frames;
                frames = 0;
                timer -= 1;
            }
            frames++;

            if (IsKeyDown(KeyboardKey.KEY_A))
            {
                tankObject.Rotate(deltaTime);
                if (bulletActive == false)
                {
                    bulletObject.Rotate(deltaTime);
                }
            }
            if (IsKeyDown(KeyboardKey.KEY_D))
            {
                tankObject.Rotate(-deltaTime);
                if (bulletActive == false)
                {
                    bulletObject.Rotate(-deltaTime);
                }
            }
            if (IsKeyDown(KeyboardKey.KEY_W))
            {
                Vector3 facing = new Vector3(
                    tankObject.LocalTransform.m1,
                    tankObject.LocalTransform.m2, 1) * deltaTime * 100;
                    tankObject.Translate(facing.x, facing.y);

                if (bulletActive == false)
                {
                    Vector3 bulletFacing = new Vector3(
                    bulletObject.LocalTransform.m1,
                    bulletObject.LocalTransform.m2, 1) * deltaTime * 100;
                    bulletObject.Translate(bulletFacing.x, bulletFacing.y);
                }
            }
            if (IsKeyDown(KeyboardKey.KEY_S))
            {
                Vector3 facing = new Vector3(
                    tankObject.LocalTransform.m1,
                    tankObject.LocalTransform.m2, 1) * deltaTime * -100;
                    tankObject.Translate(facing.x, facing.y);

                if (bulletActive == false)
                {
                    Vector3 bulletFacing = new Vector3(
                    bulletObject.LocalTransform.m1,
                    bulletObject.LocalTransform.m2, 1) * deltaTime * -100;
                    bulletObject.Translate(bulletFacing.x, bulletFacing.y);
                }
            }
            if (IsKeyDown(KeyboardKey.KEY_Q))
            {
                turretObject.Rotate(deltaTime);
                if(bulletActive == false)
                {
                    bulletObject.Rotate(deltaTime);
                }
            }
            if (IsKeyDown(KeyboardKey.KEY_E))
            {
                turretObject.Rotate(-deltaTime);
                if (bulletActive == false)
                {
                    bulletObject.Rotate(-deltaTime);
                }
            }
            if (IsKeyPressed(KeyboardKey.KEY_SPACE))
            {
                if(bulletActive == false)
                {
                    bulletActive = true;
                }
            }

            if (bulletActive == true)
            {
                for (int i = 0; i < 20; i++)
                {
                    Vector3 facing = new Vector3(
                        bulletObject.LocalTransform.m1,
                        bulletObject.LocalTransform.m2,
                        1) * deltaTime * 50;
                    bulletObject.Translate(facing.x, facing.y);
                }
            }

            tankObject.Update(deltaTime);

            lastTime = currentTime;
        }
        public void Draw()
        {
            BeginDrawing();

            ClearBackground(WHITE);

            bulletObject.Draw();
            tankObject.Draw();
            DrawText("Bullet fired: " + bulletActive.ToString(), 20, 20, 20, BLUE);

            EndDrawing();
        }
    }
}