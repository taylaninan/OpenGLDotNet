using System;
using OpenGLDotNet;

namespace OpenGLDemos
{
    // Demo #04: Texturing
    public static class OpenGLDemo04
    {
        private static bool RotateAroundX = false;
        private static bool RotateAroundY = false;
        private static bool RotateAroundZ = false;

        private static float SpinAroundX = 0;
        private static float SpinAroundY = 0;
        private static float SpinAroundZ = 0;
        private static float SpinIncrement = 0.5f;

        public static void Keyboard(byte key, int x, int y)
        {
            Console.WriteLine("[KEYBOARD] key={0}, x={1}, y={2}", key, x, y);

            if (key == 82 || key == 114)                // 'R' key pressed
            {
                RotateAroundX = false;
                RotateAroundY = false;
                RotateAroundZ = false;

                SpinAroundX = 0;
                SpinAroundY = 0;
                SpinAroundZ = 0;
                SpinIncrement = 0.5f;
            }

            if (key == 81 || key == 113)                // 'Q' key pressed
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

            if (key == 65 || key == 97)                 // 'A' key pressed
            {
                GL.MatrixMode(GL.GL_PROJECTION);
                GL.Translatef(-1.0f, 0.0f, 0.0f);
                GL.MatrixMode(GL.GL_MODELVIEW);
            }

            if (key == 83 || key == 115)                // 'S' key pressed
            {
                GL.MatrixMode(GL.GL_PROJECTION);
                GL.Translatef(0.0f, 0.0f, -1.0f);
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
                GL.Translatef(0.0f, 0.0f, 1.0f);
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
            Console.WriteLine("[RESHAPE] {0}x{1}", width, height);

            GL.Viewport(0, 0, width, height);
            
            GL.MatrixMode(GL.GL_PROJECTION);
            GL.LoadIdentity();

            //GL.Rotatef(-90.0f, 1.0f, 0.0f, 0.0f);   // Put Z-Axis Up
            //GL.Rotatef(180.0f, 0.0f, 0.0f, 1.0f);   // Put Y-Axis Forward

            GLU.Perspective(90.0, (double)width / (double)height, 1.0, 4096.0);
            
            GL.MatrixMode(GL.GL_MODELVIEW);
            GL.LoadIdentity();
        }

        public static void Motion(int x, int y)
        {
            Console.WriteLine("[MOTION] ({0},{1})", x, y);
        }

        public unsafe static IntPtr GetData()
        {
            byte[] Image = new byte[256*256*4];
            byte[] PalConverter = new byte[1024];

            IntPtr Pal = IL.GetPalette();
            IntPtr Data = IL.GetData();
            
            byte* ptrPal = (byte*)Pal;
            byte* ptrData = (byte*)Data;

            // Prepare the Palette
            for (uint counter = 0; counter < 256; counter++)
            {
                PalConverter[counter * 4 + 0] = *ptrPal;    // Red
                ptrPal++;
                PalConverter[counter * 4 + 1] = *ptrPal;    // Green
                ptrPal++;
                PalConverter[counter * 4 + 2] = *ptrPal;    // Blue;
                ptrPal++;
                PalConverter[counter * 4 + 3] = 255;        // Alpha;
            }

            // Prepare the Image
            for (uint counter = 0; counter < 256 * 256; counter++)
            {
                byte Pixel = *ptrData;

                Image[counter * 4 + 0] = PalConverter[Pixel * 4 + 0];
                Image[counter * 4 + 1] = PalConverter[Pixel * 4 + 1];
                Image[counter * 4 + 2] = PalConverter[Pixel * 4 + 2];
                Image[counter * 4 + 3] = PalConverter[Pixel * 4 + 3];

                ptrData++;
            }

            fixed (byte* ptr_image = Image)
            {
                return (IntPtr)ptr_image;
            }
        }

        public static void SetupGL()
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Color3f(1.0f, 1.0f, 1.0f);

            GL.Enable(GL.GL_DEPTH_TEST);
            GL.DepthFunc(GL.GL_LEQUAL);
            GL.ShadeModel(GL.GL_FLAT);

            GL.PixelStorei(GL.GL_UNPACK_ALIGNMENT, 1);
            
            GL.TexImage2D(GL.GL_TEXTURE_2D, 0, 4, 256, 256, 0, GL.GL_RGBA, GL.GL_UNSIGNED_BYTE, IL.GetData());

            GL.TexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_WRAP_S, (int)GL.GL_CLAMP_TO_EDGE);
            GL.TexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_WRAP_T, (int)GL.GL_CLAMP_TO_EDGE);
            GL.TexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MAG_FILTER, (int)GL.GL_LINEAR);
            GL.TexParameteri(GL.GL_TEXTURE_2D, GL.GL_TEXTURE_MIN_FILTER, (int)GL.GL_LINEAR);
            GL.TexEnvi(GL.GL_TEXTURE_ENV, GL.GL_TEXTURE_ENV_MODE, (int)GL.GL_DECAL);

            GL.Enable(GL.GL_TEXTURE_2D);

            GL.Hint(GL.GL_PERSPECTIVE_CORRECTION_HINT, GL.GL_NICEST);
            GL.Disable(GL.GL_DITHER);
        }

        public static void Display()
        {
            ulong StartTime = CPUInfo.ReadTSC();

            GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);

            GL.MatrixMode(GL.GL_MODELVIEW);
            GL.LoadIdentity();

            GLU.LookAt(0, 0, +2, 0, 0, -1, 0, 1, 0);

            GL.Rotatef(SpinAroundX, 1.0f, 0.0f, 0.0f);
            GL.Rotatef(SpinAroundY, 0.0f, 1.0f, 0.0f);
            GL.Rotatef(SpinAroundZ, 0.0f, 0.0f, 1.0f);

            GL.Begin(GL.GL_QUADS);
            {
                GL.TexCoord3f(0.0f, 0.0f, 0.0f); GL.Vertex3f(0.0f, 0.0f, 0.0f);
                GL.TexCoord3f(1.0f, 0.0f, 0.0f); GL.Vertex3f(2.0f, 0.0f, 0.0f);
                GL.TexCoord3f(1.0f, 1.0f, 0.0f); GL.Vertex3f(2.0f, 2.0f, 0.0f);
                GL.TexCoord3f(0.0f, 1.0f, 0.0f); GL.Vertex3f(0.0f, 2.0f, 0.0f);
            }
            GL.End();

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
            GLConfig.Init(2, 0, "Demo #04 - Texturing", 25, 25, 1024, 768);
            GL.Init(true);

            GLConfig.LogWriteToConsole();

            IL.Init();
            ILU.Init();
            ILUT.Init();
            ILUT.Renderer(ILUT.ILUT_OPENGL);

            if (!IL.Load(IL.IL_PCX, @".\data\unit6_bk.pcx"))
            {
                Console.WriteLine("Texture loading failed!");
            }
            else
            {
                if (!IL.LoadPal(@".\data\colormap.pcx"))
                {
                    Console.WriteLine("Palette loading failed!");
                }

                // Convert & Save
                IL.ConvertImage(IL.IL_RGBA, IL.IL_UNSIGNED_BYTE);
                IL.Save(IL.IL_TGA, @".\data\unit6_bk.tga");

                // Reload
                IL.Load(IL.IL_TGA, @".\data\unit6_bk.tga");
                IL.Save(IL.IL_PNG, @".\data\unit6_bk.png");
                
                // Convert again before showing
                IL.ConvertImage(IL.IL_RGBA, IL.IL_UNSIGNED_BYTE);
                
                Console.WriteLine("Width         : {0}", IL.GetInteger(IL.IL_IMAGE_WIDTH));
                Console.WriteLine("Height        : {0}", IL.GetInteger(IL.IL_IMAGE_HEIGHT));
                Console.WriteLine("Bits/Pixel    : {0}", IL.GetInteger(IL.IL_IMAGE_BITS_PER_PIXEL));
                Console.WriteLine("Size of Data  : {0}", IL.GetInteger(IL.IL_IMAGE_SIZE_OF_DATA));
                Console.WriteLine("Image Format  : 0x{0:x}", IL.GetInteger(IL.IL_IMAGE_FORMAT));
                Console.WriteLine("Image Type    : 0x{0:x}", IL.GetInteger(IL.IL_IMAGE_TYPE));
                Console.WriteLine("Palette Type  : 0x{0:x}", IL.GetInteger(IL.IL_PALETTE_TYPE));
                Console.WriteLine("Palette Size  : {0}", IL.GetInteger(IL.IL_PALETTE_SIZE));
                Console.WriteLine("Palette Colors: {0}", IL.GetInteger(IL.IL_PALETTE_NUM_COLS));
                Console.WriteLine("Palette Byes/Pixel: {0}", IL.GetInteger(IL.IL_PALETTE_BPP));
                Console.WriteLine("Palette Base Type: 0x{0:x}", IL.GetInteger(IL.IL_PALETTE_BASE_TYPE));
            }

            SetupGL();

            GLUT.KeyboardFunc(Keyboard);
            GLUT.MouseFunc(Mouse);
            GLUT.IdleFunc(Idle);
            GLUT.ReshapeFunc(Reshape);
            GLUT.MotionFunc(Motion);
            GLUT.DisplayFunc(Display);

            GLUT.MainLoop();
        }
    }
}
