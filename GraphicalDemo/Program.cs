/*******************************************************************************************
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

namespace Examples
{
    public class Core_basic_window
    {
        public static int Main()
        {
            // Initialization
            //--------------------------------------------------------------------------------------
            const int screenWidth = 800;
            const int screenHeight = 450;

            InitWindow(screenWidth, screenHeight, "Graphical Demo - Tank");

            Player player = new Player();
            player.Init(@"res\tankGreen_outline.png", @"res\barrelGreen_outline.png");
            player.tankPos = new System.Numerics.Vector2(50, 50); // TODO make rotate from center, not top left
                                                                // TODO after barrel is fixed, start center
            player.barrelPos = new System.Numerics.Vector2(player.tank.width / 2, player.tank.height / 2); // TODO make rotate from center, not top left
            
            SetTargetFPS(60);
            //--------------------------------------------------------------------------------------

            // Main game loop
            while (!WindowShouldClose())    // Detect window close button or ESC key
            {
                // Update
                //----------------------------------------------------------------------------------
                player.Update();
                //----------------------------------------------------------------------------------

                // Draw
                //----------------------------------------------------------------------------------
                BeginDrawing();

                ClearBackground(RAYWHITE);

                player.Draw();

                EndDrawing();
                //----------------------------------------------------------------------------------
            }

            // De-Initialization
            //--------------------------------------------------------------------------------------
            CloseWindow();        // Close window and OpenGL context
            //--------------------------------------------------------------------------------------

            return 0;
        }
    }
}