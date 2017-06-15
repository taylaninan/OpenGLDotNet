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
            Console.Title = "OpenGLDotNet v1.1.1 Demos";

            Console.WriteLine("Starting OpenGLDotNet v1.1.1 - Quake 2 Console Demo ...");

            Quake2Main.Main(args);
        }
    }
}