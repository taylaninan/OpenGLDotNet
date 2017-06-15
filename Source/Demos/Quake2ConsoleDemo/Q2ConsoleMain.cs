// ----------------------------------------------------------------------------
// FILE		: q2consolemain.cs
// VERSION	: 1.1.1
// COMMENT	: This file is part of Quake 2 Console Demo. The Q2ConsoleMain is the
//			  main file, which initializes OpenGL and starts the console demo.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2017
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;
using OpenGLDotNet;

namespace Quake2DotNet
{
    public static class Quake2Main
    {
        private static bool RotateAroundX = false;
        private static bool RotateAroundY = false;
        private static bool RotateAroundZ = true;

        private static float SpinAroundX = 0;
        private static float SpinAroundY = 0;
        private static float SpinAroundZ = 0;
        private static float SpinIncrement = 1.0f;

        private enum ObjectNames : byte
        {
            Teapot = 1,
            Cube = 2,
            Sphere = 3,
            Torus = 4,
            Cone = 5
        }

        private static ObjectNames DrawObject = ObjectNames.Teapot;

        public static void Init()
        {
            if (ConsoleVarManager.GetValueToString("Q2ConsoleInit") == "true")
            {
                // Init FreeGlut
                int[] argc = new int[1]; argc[0] = 0; string[] argv = null;
                FG.Init(argc, argv);

                FG.InitDisplayMode(FG.GLUT_RGBA | FG.GLUT_DOUBLE | FG.GLUT_DEPTH);
                FG.InitWindowPosition(25, 25);
                FG.InitWindowSize(1024, 768);
                FG.InitContextVersion(2, 1);
                FG.InitContextFlags((int)FG.GLUT_FORWARD_COMPATIBLE);
                FG.InitContextProfile((int)FG.GLUT_COMPATIBILITY_PROFILE);
                int hWindow = FG.CreateWindow(ConsoleVarManager.GetValueToString("VersionLong"));

                // Setup OpenGL window and OpenGL itself
                GL.Init(true);

                // Init DevIL -> Developers Image Libary
                IL.Init();
                ILU.Init();
                ILUT.Init();
                ILUT.Renderer(ILUT.ILUT_OPENGL);
            }

            SetupGL();                  // Each time ScreenSize changes, this must be called

            ConsoleManager.Init();      // Each time ScreenSize changed, this must be called

            if (ConsoleVarManager.GetValueToString("Q2ConsoleInit") == "true")
            {
                string[] OpenGLDotNetInitLog = GLConfig.LogDumpToString();
                foreach (string Line in OpenGLDotNetInitLog)
                {
                    ConsoleManager.WriteLine(Line);
                }
            }

            if (ConsoleVarManager.GetValueToString("Q2ConsoleInit") == "true")
            {
                // We don't want to Init and Add commands each time ScreenSize changes
                CommandManager.Init();

                CommandManager.ExecuteCommand("openglinfo");
                CommandManager.ExecuteCommand("help");

                // Normally we can pass the functions directly to GLUT or FREEGLUT, but then stupid GC collects them unpredictably.
                // So, when we declare them as variables, and pass variables to the GLUT or FREEGLUT, there is no problem. 
                // Stupid GC doesn't collect them.
                FG.TCALLBACKglutIdleProc IdleProc = Idle;
                FG.TCALLBACKglutKeyboardProc KeyboardProc = Keyboard;
                FG.TCALLBACKglutMouseProc MouseProc = Mouse;
                FG.TCALLBACKglutReshapeProc ReshapeProc = Reshape;
                FG.TCALLBACKglutDisplayProc DisplayProc = Display;

                FG.IdleFunc(IdleProc);
                FG.KeyboardFunc(KeyboardProc);
                FG.MouseFunc(MouseProc);
                FG.ReshapeFunc(ReshapeProc);
                FG.DisplayFunc(DisplayProc);

                GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);
                FG.SwapBuffers();

                // Before entering FG.MainLoop(), we must set the variable
                ConsoleVarManager.Set("Q2ConsoleInit", "false");

                FG.SetOption(FG.GLUT_ACTION_ON_WINDOW_CLOSE, (int)FG.GLUT_ACTION_GLUTMAINLOOP_RETURNS);
                FG.MainLoop();
            }
        }


        public static void SetupGL()
        {
            WGL.SwapIntervalEXT(1);                                         // 60 fps is enough for us :)

            if (ConsoleManager.IsOpen)
            {
                GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
                GL.Color3f(1.0f, 1.0f, 1.0f);

                GL.Enable(GL.GL_DEPTH_TEST);
                GL.DepthFunc(GL.GL_LEQUAL);
                GL.ShadeModel(GL.GL_SMOOTH);

                GL.PixelStorei(GL.GL_UNPACK_ALIGNMENT, 1);
                GL.Enable(GL.GL_TEXTURE_2D);

                GL.Hint(GL.GL_PERSPECTIVE_CORRECTION_HINT, GL.GL_NICEST);
                GL.Disable(GL.GL_DITHER);                                       // Actually we shouldn't have DITHERING in RGBA mode, but anyway...
                GL.Enable(GL.GL_BLEND);
                GL.BlendFunc(GL.GL_ONE, GL.GL_ONE);
            }
            else
            {
                if (ConsoleVarManager.GetValueToByte("DemoFreeglut") == 1)
                {
                    GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
                    GL.Color3f(1.0f, 1.0f, 1.0f);

                    GL.Disable(GL.GL_DEPTH_TEST);
                    GL.ShadeModel(GL.GL_FLAT);

                    GL.Disable(GL.GL_TEXTURE_2D);

                    GL.Hint(GL.GL_PERSPECTIVE_CORRECTION_HINT, GL.GL_NICEST);
                    GL.Disable(GL.GL_DITHER);
                    GL.Disable(GL.GL_BLEND);
                }
            }
        }

        public static void Idle()
        {
            if (ConsoleManager.IsOpen)
            {
                ConsoleManager.AnimateCursor();
            }
            else
            {
                if (ConsoleVarManager.GetValueToByte("DemoFreeglut") == 1)
                {
                    if (RotateAroundX)
                    {
                        SpinAroundX += SpinIncrement;
                        if (SpinAroundX >= 360)
                        {
                            SpinAroundX -= 360;
                        }
                    }

                    if (RotateAroundY)
                    {
                        SpinAroundY += SpinIncrement;
                        if (SpinAroundY >= 360)
                        {
                            SpinAroundY -= 360;
                        }
                    }

                    if (RotateAroundZ)
                    {
                        SpinAroundZ += SpinIncrement;
                        if (SpinAroundZ >= 360)
                        {
                            SpinAroundZ -= 360;
                        }
                    }

                    if (RotateAroundX || RotateAroundY || RotateAroundZ)
                    {
                        Display();
                    }
                }
            }
        }

        public static void Reshape(int width, int height)
        {
            Console.WriteLine("Reshape: {0}x{1}", width, height);

            ConsoleVarManager.SetOrCreate("ScreenWidth", width.ToString(), 0);
            ConsoleVarManager.SetOrCreate("ScreenHeight", height.ToString(), 0);
            ConsoleManager.Init();

            if (ConsoleManager.IsOpen)
            {
                SetupGL();

                GL.Viewport(0, 0, width, height);

                GL.MatrixMode(GL.GL_PROJECTION);
                GL.LoadIdentity();

                GL.Ortho(0, width, height, 0, -4096, 4096);

                GL.MatrixMode(GL.GL_MODELVIEW);
                GL.LoadIdentity();
            }
            else
            {
                if (ConsoleVarManager.GetValueToByte("DemoFreeglut") == 1)
                {
                    SetupGL();

                    float ratio = 0;
                    float ortho = 30;

                    GL.Viewport(0, 0, width, height);

                    GL.MatrixMode(GL.GL_PROJECTION);
                    GL.LoadIdentity();

                    if (width >= height)
                    {
                        ratio = (float)width / (float)height;
                        GL.Ortho(-ortho * ratio, ortho * ratio, -ortho, ortho, -ortho, ortho);
                    }
                    else
                    {
                        ratio = (float)height / (float)width;
                        GL.Ortho(-ortho, ortho, -ortho * ratio, ortho * ratio, -ortho, ortho);
                    }

                    GL.MatrixMode(GL.GL_MODELVIEW);
                    GL.LoadIdentity();
                }
            }
        }

        public static void Display()
        {
            if (!ConsoleManager.IsOpen)
            {
                ulong StartTime = CPUInfo.ReadTSC();

                if (ConsoleVarManager.GetValueToByte("DemoFreeglut") == 1)
                {
                    GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);
                    GL.PushMatrix();

                    GL.Rotatef(SpinAroundX, 1.0f, 0.0f, 0.0f);
                    GL.Rotatef(SpinAroundY, 0.0f, 1.0f, 0.0f);
                    GL.Rotatef(SpinAroundZ, 0.0f, 0.0f, 1.0f);

                    switch (DrawObject)
                    {
                        case ObjectNames.Teapot:
                            FG.WireTeapot(15.0);
                            break;
                        case ObjectNames.Cube:
                            FG.WireCube(15.0);
                            break;
                        case ObjectNames.Sphere:
                            FG.WireSphere(15.0, 25, 25);
                            break;
                        case ObjectNames.Torus:
                            FG.WireTorus(7.5, 15.0, 25, 25);
                            break;
                        case ObjectNames.Cone:
                            FG.WireCone(15.0, 15.0, 25, 25);
                            break;
                    }

                    GL.PopMatrix();

                    FG.SwapBuffers();
                }

                ulong FinishTime = CPUInfo.ReadTSC();
                double Interval = Math.Round((double)(FinishTime - StartTime) / (double)(CPUInfo.CPUSpeed * 1000000), 3);
                double fps = Math.Round(1 / Interval, 3);
                //Console.WriteLine("[FRAME_INFO] {0} FPS", fps);
            }
        }

        public unsafe static void Keyboard(byte key, int x, int y)
        {
            Console.WriteLine("Key = " + key);

            if (ConsoleManager.IsOpen)
            {	// If console is open...
                switch (key)
                {
                    case 96:    // "~" key pressed
                    case 126:
                        ConsoleManager.Close();
                        Reshape(ConsoleVarManager.GetValueToUShort("ScreenWidth"), ConsoleVarManager.GetValueToUShort("ScreenHeight"));
                        break;
                    case 8:     // Backspace key pressed
                    case 127:   // Del key pressed
                        ConsoleLogManager.DeleteBufferChar();
                        break;
                    case 9:     // Tab key pressed; do nothing
                    case 27:    // Escape key pressed; do nothing
                        break;
                    case 13:    // Enter key pressed
                        string Command = ConsoleLogManager.ReadBuffer();
                        // Flush the buffer
                        ConsoleManager.WriteLine();
                        // Execute command
                        CommandManager.ExecuteCommand(Command);
                        // Redisplay the console
                        ConsoleManager.Open();
                        break;
                    default:
                        byte* keyptr = &key;
                        ConsoleManager.Write(new string((sbyte*)keyptr));
                        break;
                }
            }
            else
            {   // If console is closed
                switch(key)
                {
                    case 96:    // "~" key pressed
                    case 126:
                        ConsoleManager.Open();
                        Reshape(ConsoleVarManager.GetValueToUShort("ScreenWidth"), ConsoleVarManager.GetValueToUShort("ScreenHeight"));
                        break;
                }

                if (ConsoleVarManager.GetValueToByte("DemoFreeglut") == 1)
                {
                    switch (key)
                    {
                        case 81:    // 'Q' key pressed
                        case 113:
                            SpinIncrement += 0.25f;
                            break;

                        case 90:    // 'Z' key pressed
                        case 122:
                            SpinIncrement -= 0.25f;
                            break;

                        case 70:    // 'F' key pressed
                        case 102:
                            FG.FullScreenToggle();
                            break;

                        case 49:    // '1', '2', '3', '4', '5' key pressed
                        case 50:
                        case 51:
                        case 52:
                        case 53:
                            key -= 48;
                            DrawObject = (ObjectNames)key;
                            break;

                        case 65:    // 'A' key pressed
                        case 97:
                            GL.MatrixMode(GL.GL_PROJECTION);
                            GL.Translatef(-1.0f, 0.0f, 0.0f);
                            GL.MatrixMode(GL.GL_MODELVIEW);
                            break;

                        case 83:    // 'S' key pressed
                        case 115:
                            GL.MatrixMode(GL.GL_PROJECTION);
                            GL.Translatef(0.0f, -1.0f, 0.0f);
                            GL.MatrixMode(GL.GL_MODELVIEW);
                            break;

                        case 68:    // 'D' key pressed
                        case 100:
                            GL.MatrixMode(GL.GL_PROJECTION);
                            GL.Translatef(+1.0f, 0.0f, 0.0f);
                            GL.MatrixMode(GL.GL_MODELVIEW);
                            break;

                        case 87:    // 'W' key pressed
                        case 119:
                            GL.MatrixMode(GL.GL_PROJECTION);
                            GL.Translatef(0.0f, +1.0f, 0.0f);
                            GL.MatrixMode(GL.GL_MODELVIEW);
                            break;

                        case 27:    // ESCAPE key pressed, so exit the program 
                            RotateAroundX = false;
                            RotateAroundY = false;
                            RotateAroundZ = false;

                            FG.IdleFunc(null);
                            FG.KeyboardFunc(null);
                            FG.MouseFunc(null);
                            FG.ReshapeFunc(null);
                            FG.DestroyWindow(FG.GetWindow());
                            break;
                    }
                }
            }
        }

        public static void Mouse(int button, int state, int x, int y)
        {
            if (ConsoleVarManager.GetValueToByte("DemoFreeglut") == 1)
            {
                if (button == 0 && state == 0)          // Left mouse button clicked
                {
                    RotateAroundZ = !RotateAroundZ;
                }

                if (button == 1 && state == 0)          // Middle mouse button clicked
                {
                    RotateAroundY = !RotateAroundY;
                }

                if (button == 2 && state == 0)          // Right mouse button clicked
                {
                    RotateAroundX = !RotateAroundX;
                }
            }
        }

        public static void Main(string[] args)
        {
            // First and Most Importantly: Initialize Variables
            ConsoleVarManager.Init();

            // First, setup the console window
            Console.Title = ConsoleVarManager.GetValueToString("VersionLong");

            Init();

            IL.ShutDown();
        }
    }
}
