using System;
using OpenGLDotNet;

namespace OpenGLDemos
{
    // Demo #02: Simple objects
    public static class OpenGLDemo02
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

        public static void Keyboard(byte key, int x, int y)
        {
            Console.WriteLine("[KEYBOARD] key={0}, x={1}, y={2}", key, x, y);

            if (key == 81 || key == 113)                 // 'Q' key presseda
            {
                SpinIncrement += 0.25f;
                Console.WriteLine("[SPIN] {0}", SpinIncrement);
            }

            if (key == 90 || key == 122)                // 'Z' key pressed
            {
                SpinIncrement -= 0.25f;
                Console.WriteLine("[SPIN] {0}", SpinIncrement);
            }

            if (key == 70 || key == 102)                // 'F' key pressed
            {
                GLUT.FullScreen();
            }

            if (key >= 49 && key <= 53)                 // '1','2','3','4','5' key pressed
            {
                key -= 48;
                DrawObject = (ObjectNames)key;
            }

            if (key == 65 || key == 97)                 // 'A' key pressed
            {
                GL.MatrixMode(GL.GL_PROJECTION);
                GL.Translatef(-1.0f, 0.0f, 0.0f);
                GL.MatrixMode(GL.GL_MODELVIEW);
            }

            if (key == 83 || key == 115)                // 'S' key pressed
            {
                GL.MatrixMode(GL.GL_PROJECTION);
                GL.Translatef(0.0f, -1.0f, 0.0f);
                GL.MatrixMode(GL.GL_MODELVIEW);
            }

            if (key == 68 || key == 100)                // 'D' key pressed
            {
                GL.MatrixMode(GL.GL_PROJECTION);
                GL.Translatef(+1.0f, 0.0f, 0.0f);
                GL.MatrixMode(GL.GL_MODELVIEW);
            }

            if (key == 87 || key == 119)                // 'W' key pressed
            {
                GL.MatrixMode(GL.GL_PROJECTION);
                GL.Translatef(0.0f, +1.0f, 0.0f);
                GL.MatrixMode(GL.GL_MODELVIEW);
            }

            if (key == 27)                              // Escape key pressed, so exit the program
            {
                RotateAroundX = false;
                RotateAroundY = false;
                RotateAroundZ = false;

                GLUT.KeyboardFunc(null);
                GLUT.MouseFunc(null);
                GLUT.IdleFunc(null);
                GLUT.ReshapeFunc(null);
                GLUT.MotionFunc(null);
                GLUT.DestroyWindow(GLUT.GetWindow());
            }
        }

        public static void Mouse(int button, int state, int x, int y)
        {
            Console.WriteLine("[MOUSE] button={0}, state={1}, x={2}, y={3}", button, state, x, y);

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

        public static void Idle()
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

        public static void Reshape(int width, int height)
        {
            float ratio = 0;
            float ortho = 30;

            Console.WriteLine("[RESHAPE] {0}x{1}", width, height);

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

        public static void Motion(int x, int y)
        {
            Console.WriteLine("[MOTION] ({0},{1})", x, y);
        }

        public static void SetupGL()
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Color3f(1.0f, 1.0f, 1.0f);
            GL.ShadeModel(GL.GL_FLAT);
        }

        public static void Display()
        {
            ulong StartTime = CPUInfo.ReadTSC();

            GL.Clear(GL.GL_COLOR_BUFFER_BIT);
            GL.PushMatrix();

            GL.Rotatef(SpinAroundX, 1.0f, 0.0f, 0.0f);
            GL.Rotatef(SpinAroundY, 0.0f, 1.0f, 0.0f);
            GL.Rotatef(SpinAroundZ, 0.0f, 0.0f, 1.0f);

            switch (DrawObject)
            {
                case ObjectNames.Teapot:
                    GLUT.WireTeapot(15.0);
                    break;
                case ObjectNames.Cube:
                    GLUT.WireCube(15.0);
                    break;
                case ObjectNames.Sphere:
                    GLUT.WireSphere(15.0, 25, 25);
                    break;
                case ObjectNames.Torus:
                    GLUT.WireTorus(7.5, 15.0, 25, 25);
                    break;
                case ObjectNames.Cone:
                    GLUT.WireCone(15.0, 15.0, 25, 25);
                    break;
            }

            GL.PopMatrix();

            GLUT.SwapBuffers();

            ulong FinishTime = CPUInfo.ReadTSC();
            double Interval = Math.Round((double)(FinishTime - StartTime) / (double)(CPUInfo.CPUSpeed * 1000000), 3);
            double fps = Math.Round(1 / Interval, 3);
            //Console.WriteLine("[FRAME_INFO] {0} ms", Interval);
        }

        public static void Main(string[] args)
        {
            // First, setup the console window
            Console.Title = "OpenGLDotNet v1.1.0";

            // After that, setup OpenGL window and OpenGL itself
            GLConfig.Init(0, 0, "Demo #02 - Simple Objects", 25, 25, 1024, 768);
            GL.Init(true);

            // Normally we can pass the functions directly to GLUT or FREEGLUT, but then stupid GC collects them unpredictably.
            // So, when we declare them as variables, and pass variables to the GLUT or FREEGLUT, there is no problem. 
            // Stupid GC doesn't collect them.
            GLUT.TCALLBACKglutKeyboardProc KeyboardProc = Keyboard;
            GLUT.TCALLBACKglutMouseProc MouseProc = Mouse;
            GLUT.TCALLBACKglutIdleProc IdleProc = Idle;
            GLUT.TCALLBACKglutReshapeProc ReshapeProc = Reshape;
            GLUT.TCALLBACKglutMotionProc MotionProc = Motion;
            GLUT.TCALLBACKglutDisplayProc DisplayProc = Display;

            GLUT.KeyboardFunc(KeyboardProc);
            GLUT.MouseFunc(MouseProc);
            GLUT.IdleFunc(IdleProc);
            GLUT.ReshapeFunc(ReshapeProc);
            GLUT.MotionFunc(MotionProc);
            GLUT.DisplayFunc(DisplayProc);

            SetupGL();
            GLUT.MainLoop();
        }
    }
}

