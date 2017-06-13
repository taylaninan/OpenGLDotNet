// ----------------------------------------------------------------------------
// FILE		: gldemomain.cs
// VERSION	: 1.1.1
// COMMENT	: This file displays the main menu of OpenGL demos and starts the
//            correct demo
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2017
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;
using Quake2DotNet;

namespace OpenGLDemos
{
    public class OpenGLDemos
    {
        public static void Main(string[] args)
        {
            // First, setup the console window
            Console.Title = "OpenGLDotNet v1.1.0 Demos";

            Console.WriteLine(" 1.) Quake 2 OpenGL Console Demo");
            Console.WriteLine(" 2.) OpenGL Demo #01 - Orientation");
            Console.WriteLine(" 3.) OpenGL Demo #02 - [Glut] Simple Objects");
            Console.WriteLine(" 4.) OpenGL Demo #03 - [FreeGlut] Simple Objects");
            Console.WriteLine(" 5.) OpenGL Demo #04 - Texturing");
            Console.WriteLine();
            Console.WriteLine(" Q.) Quit");
            Console.WriteLine();
            Console.WriteLine("                       _____ PLEASE SELECT A DEMO _____");
            Console.WriteLine();

            ConsoleKeyInfo Key = Console.ReadKey(true);

            while (Key.Key != ConsoleKey.D1 && Key.Key != ConsoleKey.D2 && Key.Key != ConsoleKey.D3 && Key.Key != ConsoleKey.D4 && Key.Key != ConsoleKey.D5 && Key.Key != ConsoleKey.Q)
            {
                Key = Console.ReadKey(true);
            }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      

            switch (Key.Key)
            {
                case ConsoleKey.D1:
                    Quake2Main.Main(args);
                    break;
                case ConsoleKey.D2:
                    OpenGLDemo01.Main(args);
                    break;
                case ConsoleKey.D3:
                    OpenGLDemo02.Main(args);
                    break;
                case ConsoleKey.D4:
                    OpenGLDemo03.Main(args);
                    break;
                case ConsoleKey.D5:
                    OpenGLDemo04.Main(args);
                    break;
            }
        }
    }
}