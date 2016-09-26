// ----------------------------------------------------------------------------
// FILE		: wgl.coredelegates.cs
// VERSION	: 1.1.0
// COMMENT	: "Windows" specific OpenGL Core low level functions dynamic linker.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2016
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

namespace OpenGLDotNet
{
    public static partial class WGL
    {
        private static void LinkLibWGLCore()
        {
            ///////////////////////////////////////////////////////////////////
            // OPENGL WGL FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core WGL functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE WGL FUNCTIONS...
            if (LinkProcWGL("wglChoosePixelFormat"))
            {
                wglChoosePixelFormat = (TwglChoosePixelFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglChoosePixelFormat));
            }

            if (LinkProcWGL("wglDescribePixelFormat"))
            {
                wglDescribePixelFormat = (TwglDescribePixelFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDescribePixelFormat));
            }

            if (LinkProcWGL("wglGetPixelFormat"))
            {
                wglGetPixelFormat = (TwglGetPixelFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetPixelFormat));
            }

            if (LinkProcWGL("wglSetPixelFormat"))
            {
                wglSetPixelFormat = (TwglSetPixelFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSetPixelFormat));
            }

            if (LinkProcWGL("wglSwapBuffers"))
            {
                wglSwapBuffers = (TwglSwapBuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSwapBuffers));
            }

            if (LinkProcWGL("wglCreateContext"))
            {
                wglCreateContext = (TwglCreateContext)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglCreateContext));
            }

            if (LinkProcWGL("wglCreateLayerContext"))
            {
                wglCreateLayerContext = (TwglCreateLayerContext)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglCreateLayerContext));
            }

            if (LinkProcWGL("wglCopyContext"))
            {
                wglCopyContext = (TwglCopyContext)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglCopyContext));
            }

            if (LinkProcWGL("wglDeleteContext"))
            {
                wglDeleteContext = (TwglDeleteContext)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDeleteContext));
            }

            if (LinkProcWGL("wglDescribeLayerPlane"))
            {
                wglDescribeLayerPlane = (TwglDescribeLayerPlane)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDescribeLayerPlane));
            }

            if (LinkProcWGL("wglGetCurrentContext"))
            {
                wglGetCurrentContext = (TwglGetCurrentContext)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetCurrentContext));
            }

            if (LinkProcWGL("wglGetCurrentDC"))
            {
                wglGetCurrentDC = (TwglGetCurrentDC)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetCurrentDC));
            }

            if (LinkProcWGL("wglGetLayerPaletteEntries"))
            {
                wglGetLayerPaletteEntries = (TwglGetLayerPaletteEntries)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetLayerPaletteEntries));
            }

            if (LinkProcWGL("wglGetProcAddress"))
            {
                wglGetProcAddress = (TwglGetProcAddress)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetProcAddress));
            }

            if (LinkProcWGL("wglMakeCurrent"))
            {
                wglMakeCurrent = (TwglMakeCurrent)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglMakeCurrent));
            }

            if (LinkProcWGL("wglRealizeLayerPalette"))
            {
                wglRealizeLayerPalette = (TwglRealizeLayerPalette)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglRealizeLayerPalette));
            }

            if (LinkProcWGL("wglSetLayerPaletteEntries"))
            {
                wglSetLayerPaletteEntries = (TwglSetLayerPaletteEntries)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSetLayerPaletteEntries));
            }

            if (LinkProcWGL("wglShareLists"))
            {
                wglShareLists = (TwglShareLists)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglShareLists));
            }

            if (LinkProcWGL("wglSwapLayerBuffers"))
            {
                wglSwapLayerBuffers = (TwglSwapLayerBuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSwapLayerBuffers));
            }

            if (LinkProcWGL("wglUseFontBitmapsW"))
            {
                wglUseFontBitmaps = (TwglUseFontBitmaps)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglUseFontBitmaps));
            }

            if (LinkProcWGL("wglUseFontOutlinesW"))
            {
                wglUseFontOutlines = (TwglUseFontOutlines)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglUseFontOutlines));
            }
            #endregion
        }
    }
}
