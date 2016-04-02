using System;
using OpenGLDotNet;
using Common;

namespace OpenGLDemos
{
    class OpenGLDemos
    {
        public static void Main(string[] args)
        {
            // First, setup the console window
            Console.Title = "OpenGLDotNet v1.1.0";

            Console.WriteLine(" 0.) OpenGL and CPU Information Demo");
            Console.WriteLine(" 1.) OpenGL Demo #01 - Orientation");
            Console.WriteLine(" 2.) OpenGL Demo #02 - Simple Objects");
            Console.WriteLine(" 3.) OpenGL Demo #03 - FreeGlut Test");
            Console.WriteLine(" 4.) OpenGL Demo #04 - Texturing");
            Console.WriteLine();
            Console.WriteLine(" Q.) Quit");
            Console.WriteLine();
            Console.WriteLine("                       _____ PLEASE SELECT A DEMO _____");
            Console.WriteLine();

            ConsoleKeyInfo Key = Console.ReadKey(true);

            while (Key.Key != ConsoleKey.D0 && Key.Key != ConsoleKey.D1 && Key.Key != ConsoleKey.D2 && Key.Key != ConsoleKey.D3 && Key.Key != ConsoleKey.D4 && Key.Key != ConsoleKey.Q)
            {
                Key = Console.ReadKey(true);
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      

            switch (Key.Key)
            {
                case ConsoleKey.D0:
                    OpenGLInfo.Main(args);
                    break;
                case ConsoleKey.D1:
                    OpenGLDemo01.Main(args);
                    break;
                case ConsoleKey.D2:
                    OpenGLDemo02.Main(args);
                    break;
                case ConsoleKey.D3:
                    OpenGLDemo03.Main(args);
                    break;
                case ConsoleKey.D4:
                    OpenGLDemo04.Main(args);
                    break;
            }
        }
    }
}
