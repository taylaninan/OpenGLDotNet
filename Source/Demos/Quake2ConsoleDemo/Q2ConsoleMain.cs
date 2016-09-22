using System;
using OpenGLDotNet;

namespace Quake2DotNet
{
    public static class Quake2Main
    {
        public static void Init()
        {
            if (ConsoleVarManager.GetValueToString("Quake2DotNetInit") == "true")
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
                int hWindow = FG.CreateWindow("Quake 2 - OpenGL Console Demo");

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

            if (ConsoleVarManager.GetValueToString("Quake2DotNetInit") == "true")
            {
                string[] OpenGLDotNetInitLog = GLConfig.LogDumpToString();
                foreach (string Line in OpenGLDotNetInitLog)
                {
                    ConsoleManager.WriteLine(Line);
                }
            }

            if (ConsoleVarManager.GetValueToString("Quake2DotNetInit") == "true")
            {
                // We don't want to Init and Add commands each time ScreenSize changes
                CommandManager.Init();

                // Normally we can pass the functions directly to GLUT or FREEGLUT, but then stupid GC collects them unpredictably.
                // So, when we declare them as variables, and pass variables to the GLUT or FREEGLUT, there is no problem. Stupid GC doesn't collect them.
                FG.TCALLBACKglutIdleProc IdleProc = Idle;
                FG.TCALLBACKglutKeyboardProc KeyboardProc = Keyboard;
                FG.TCALLBACKglutDisplayProc DisplayProc = Display;

                FG.IdleFunc(IdleProc);
                FG.KeyboardFunc(KeyboardProc);
                FG.DisplayFunc(DisplayProc);
                
                GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);
                FG.SwapBuffers();

                // Before entering FG.MainLoop(), we must set the variable
                ConsoleVarManager.Set("Quake2DotNetInit", "false");

                FG.SetOption(FG.GLUT_ACTION_ON_WINDOW_CLOSE, (int)FG.GLUT_ACTION_GLUTMAINLOOP_RETURNS);
                FG.MainLoop();
            }
        }

        public static void SetupGL()
        {
            WGL.SwapIntervalEXT(1);                                         // 60 fps is enough for us :)

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

            GL.MatrixMode(GL.GL_PROJECTION);
            GL.LoadIdentity();

            GL.Ortho(0, ConsoleVarManager.GetValueToUShort("ScreenWidth"), ConsoleVarManager.GetValueToUShort("ScreenHeight"), 0, -4096, 4096);

            GL.MatrixMode(GL.GL_MODELVIEW);
            GL.LoadIdentity();
        }

        public static void Idle()
        {
            if (ConsoleManager.IsOpen)
            {
                ConsoleManager.AnimateCursor();
            }
        }

        public static void Display()
        {
        }

        public unsafe static void Keyboard(byte key, int x, int y)
        {
            Console.WriteLine("Key = " + key);

            // If console is open...
            if (ConsoleManager.IsOpen)
            {
                switch (key)
                {
                    case 96:    // "~" key pressed
                    case 126:
                        ConsoleManager.Close();
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
            // If console is closed
            else
            {
                switch (key)
                {
                    case 96:
                    case 126:
                        ConsoleManager.Open();
                        break;
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
