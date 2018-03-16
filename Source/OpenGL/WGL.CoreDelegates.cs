// ----------------------------------------------------------------------------
// FILE		: wgl.coredelegates.cs
// VERSION	: 1.1.2
// COMMENT	: "Windows" specific OpenGL Core low level delegates and functions.
// WEB      : https://github.com/carmack78/opengldotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : taylaninan@yahoo.com 
// DATE     : 2014-2018
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

using GLboolean = System.Boolean;
using GLenum = System.UInt32;
using GLbitfield = System.UInt32;
using GLintptr = System.Int32;
using GLsizeiptr = System.Int32;
using GLsync = System.UInt32;
using GLhandle = System.UInt32;
using GLhalf = System.UInt16;
using GLvdpauSurface = System.Int32;
using GLfixed = System.Int32;

using GLchar = System.Byte;         // 1 byte
using GLbyte = System.SByte;        // 1 byte
using GLubyte = System.Byte;        // 1 byte
using GLshort = System.Int16;       // 2 bytes
using GLushort = System.UInt16;     // 2 bytes
using GLsizei = System.Int32;       // 4 bytes
using GLint = System.Int32;         // 4 bytes
using GLuint = System.UInt32;       // 4 bytes
using GLint64 = System.Int64;       // 8 bytes
using GLuint64 = System.UInt64;     // 8 bytes
using GLclampf = System.Single;     // single precision float in [0,1]
using GLclampd = System.Double;     // double precision float in [0,1]
using GLfloat = System.Single;      // 4 bytes
using GLdouble = System.Double;     // 8 bytes

namespace OpenGLDotNet
{
    public static partial class WGL
    {
        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE WGL FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE WGL FUNCTIONS...
        // int WINAPI wglChoosePixelFormat( HDC hdc, const PIXELFORMATDESCRIPTOR *ppfd);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate int TwglChoosePixelFormat(IntPtr hDC, ref PIXELFORMATDESCRIPTOR ppfd);
        private static TwglChoosePixelFormat wglChoosePixelFormat = null;

        // int WINAPI wglDescribePixelFormat( HDC hdc, int iPixelFormat, UINT nBytes, LPPIXELFORMATDESCRIPTOR ppfd);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate int TwglDescribePixelFormat(IntPtr hDC, int iPixelFormat, uint nBytes, ref PIXELFORMATDESCRIPTOR ppfd);
        private static TwglDescribePixelFormat wglDescribePixelFormat = null;

        // int WINAPI wglGetPixelFormat( HDC hdc );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate int TwglGetPixelFormat(IntPtr hdc);
        private static TwglGetPixelFormat wglGetPixelFormat = null;

        // BOOL WINAPI wglSetPixelFormat( HDC hdc, int iPixelFormat, const PIXELFORMATDESCRIPTOR *ppfd);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate bool TwglSetPixelFormat(IntPtr hdc, int iPixelFormat, ref PIXELFORMATDESCRIPTOR ppfd);
        private static TwglSetPixelFormat wglSetPixelFormat = null;

        // BOOL WINAPI wglSwapBuffers( HDC hdc );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate bool TwglSwapBuffers(IntPtr hdc);
        private static TwglSwapBuffers wglSwapBuffers = null;

        // HGLRC WINAPI wglCreateContext( HDC hdc );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate IntPtr TwglCreateContext(IntPtr hdc);
        private static TwglCreateContext wglCreateContext = null;

        // HGLRC WINAPI wglCreateLayerContext( HDC hdc, int iLayerPlane );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate IntPtr TwglCreateLayerContext(IntPtr hdc, int iLayerPlane);
        private static TwglCreateLayerContext wglCreateLayerContext = null;

        // BOOL WINAPI wglCopyContext( HGLRC hglrcSrc, HGLRC hglrcDst, UINT mask );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate bool TwglCopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, uint mask);
        private static TwglCopyContext wglCopyContext = null;

        // BOOL WINAPI wglDeleteContext( HGLRC hglrc );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate bool TwglDeleteContext(IntPtr hglrc);
        private static TwglDeleteContext wglDeleteContext = null;

        // BOOL WINAPI wglDescribeLayerPlane( HDC hdc, int iPixelFormat, int iLayerPlane, UINT nBytes, LPLAYERPLANEDESCRIPTOR plpd );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate bool TwglDescribeLayerPlane(IntPtr hDC, int iPixelFormat, int iLayerPlane, uint nBytes, ref LAYERPLANEDESCRIPTOR plpd);
        private static TwglDescribeLayerPlane wglDescribeLayerPlane = null;

        // HGLRC WINAPI wglGetCurrentContext(void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate IntPtr TwglGetCurrentContext();
        private static TwglGetCurrentContext wglGetCurrentContext = null;

        // HDC WINAPI wglGetCurrentDC(void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate IntPtr TwglGetCurrentDC();
        private static TwglGetCurrentDC wglGetCurrentDC = null;

        // int WINAPI wglGetLayerPaletteEntries( HDC hdc, int iLayerPlane, int iStart, int cEntries, COLORREF *pcr);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate int TwglGetLayerPaletteEntries(IntPtr hDC, int iLayerPlane, int iStart, int cEntries, ref COLORREF pcr);
        private static TwglGetLayerPaletteEntries wglGetLayerPaletteEntries = null;

        // PROC WINAPI wglGetProcAddress( LPCSTR lpszProc );
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate IntPtr TwglGetProcAddress(string procname);
        private static TwglGetProcAddress wglGetProcAddress = null;

        // BOOL WINAPI wglMakeCurrent( HDC hdc, HGLRC hglrc);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate bool TwglMakeCurrent(IntPtr hdc, IntPtr hglrc);
        private static TwglMakeCurrent wglMakeCurrent = null;

        // BOOL WINAPI wglRealizeLayerPalette( HDC hdc, int iLayerPlane, BOOL bRealize );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate bool TwglRealizeLayerPalette(IntPtr hdc, int iLayerPlane, bool bRealize);
        private static TwglRealizeLayerPalette wglRealizeLayerPalette = null;

        // int WINAPI wglSetLayerPaletteEntries( HDC hdc, int iLayerPlane, int iStart, int cEntries, const COLORREF *pcr );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate int TwglSetLayerPaletteEntries(IntPtr hDC, int iLayerPlane, int iStart, int cEntries, ref COLORREF pcr);
        private static TwglSetLayerPaletteEntries wglSetLayerPaletteEntries = null;

        // BOOL WINAPI wglShareLists( HGLRC hglrc1, HGLRC hglrc2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate bool TwglShareLists(IntPtr hglrc1, IntPtr hglrc2);
        private static TwglShareLists wglShareLists = null;

        // BOOL WINAPI wglSwapLayerBuffers( HDC hdc, UINT fuPlanes);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate bool TwglSwapLayerBuffers(IntPtr hdc, uint fuPlanes);
        private static TwglSwapLayerBuffers wglSwapLayerBuffers = null;

        // BOOL WINAPI wglUseFontBitmaps( HDC hdc, DWORD first, DWORD count, DWORD listBase );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate bool TwglUseFontBitmaps(IntPtr hdc, uint first, uint count, uint listBase);
        private static TwglUseFontBitmaps wglUseFontBitmaps = null;

        // BOOL WINAPI wglUseFontOutlines( HDC hdc, DWORD first, DWORD count, DWORD listBase, FLOAT deviation, FLOAT extrusion, int format, LPGLYPHMETRICSFLOAT lpgmf);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate bool TwglUseFontOutlines(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, int format, ref GLYPHMETRICSFLOAT lpgmf);
        private static TwglUseFontOutlines wglUseFontOutlines = null;

        #endregion
    }
}
