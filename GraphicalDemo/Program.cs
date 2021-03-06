﻿/*******************************************************************************************
*
*   raylib [core] example - Basic window
*
*   Welcome to raylib!
*
*   To test examples, just press F6 and execute raylib_compile_execute script
*   Note that compiled executable is placed in the same folder as .c file
*
*   You can find all basic examples on C:\raylib\raylib\examples folder or
*
*   Enjoy using raylib. :)
*
*   This example has been created using raylib-cs 3.0 (www.raylib.com)
*   raylib is licensed under an unmodified zlib/libpng license (View raylib.h for details)
*
*   This example was lightly modified to provide additional 'using' directives to make
*   common math types and utilities readily available, though they are not using in this sample.
*
*   Copyright (c) 2019-2020 Academy of Interactive Entertainment (@aie_usa)
*   Copyright (c) 2013-2016 Ramon Santamaria (@raysan5)
*
********************************************************************************************/

using static Raylib_cs.Raylib;  // core methods (InitWindow, BeginDrawing())
using static Raylib_cs.Color;   // color (RAYWHITE, MAROON, etc.)
using MathClasses;              // my mathmatics classes
using GraphicalDemo;

namespace GraphicalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            
            SetTargetFPS(60);
            InitWindow(1280, 960, "Tank Goodness Math for Games is DONE!");
            game.Init();
            while (!WindowShouldClose())
            {
                game.Update();
                game.Draw();
            }
            game.Shutdown();
            CloseWindow();
        }
    }
}