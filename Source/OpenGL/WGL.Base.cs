// ----------------------------------------------------------------------------
// FILE		: wgl.base.cs
// VERSION	: 1.1.3
// DATE     : 26 April 2018
// COMMENT	: "Windows" specific OpenGL library loading, extension linking and 
//            loading shared functions.
// WEB      : https://github.com/carmack78/opengldotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : taylaninan@yahoo.com 
// DATE     : 2014-2018
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

namespace OpenGLDotNet
{
    public static partial class WGL
    {
        ///////////////////////////////////////////////////////////////////////
        // VARIABLES
        ///////////////////////////////////////////////////////////////////////
        private static uint wglLib = 0;
        private static uint wglFuncAddr = 0;
        private static string wglFuncName = null;
        private static string wglLastExtName = null;
        private static bool wglDisableExtensions = true;

        ///////////////////////////////////////////////////////////////////////
        // INIT
        ///////////////////////////////////////////////////////////////////////
        public unsafe static void Init(bool DisableExtensionsWhichHaveMissingFunctions = true)
        {
            wglLib = Windows.LoadLibrary("opengl32.dll");

            if (wglLib == 0)
            {
                GLConfig.LogWriteLine("[ERROR] 'OPENGL32.DLL' not found!");
            }
            else
            {
                wglDisableExtensions = DisableExtensionsWhichHaveMissingFunctions;

                wglFuncAddr = Windows.GetProcAddress(wglLib, "wglGetProcAddress");
                wglGetProcAddress = (TwglGetProcAddress)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetProcAddress));

                // Link OpenGL Core WGL Functions
                WGL.LinkLibWGLCore();

                // Link WGL Extensions
                WGL.LinkLibWGLEXT();
            }
        }

        private static bool LinkProcWGL(string FunctionName)
        {
            wglFuncName = FunctionName;
            wglFuncAddr = Windows.GetProcAddress(wglLib, wglFuncName);

            if (wglFuncAddr == 0 && wglGetProcAddress != null)
            {
                wglFuncAddr = (uint)wglGetProcAddress(wglFuncName);
            }

            if (wglFuncAddr == 0)
            {
                GLConfig.LogWriteLine("[WARNING] OpenGL function missing: " + wglFuncName);
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool LinkProcWGLEXT(string FunctionName)
        {
            wglFuncName = FunctionName;
            wglFuncAddr = (uint)wglGetProcAddress(wglFuncName);

            if (wglFuncAddr == 0)
            {
                if (wglDisableExtensions && GLConfig.IsExtensionSupported(wglLastExtName))
                {
                    GLConfig.LogWriteLine("[ INFO  ] Disabling Extension       : " + wglLastExtName);
                    GLConfig.DisableExtension(wglLastExtName);
                }

                GLConfig.LogWriteLine("[WARNING] Extension function missing: " + wglFuncName);

                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool LinkWGLEXT(string ExtensionName)
        {
            wglLastExtName = ExtensionName.Trim();

            if (GLConfig.IsExtensionSupported(wglLastExtName))
            {
                return true;
            }
            else
            {
                wglLastExtName = null;
                return false;
            }
        }
    }
}
