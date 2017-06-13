// ----------------------------------------------------------------------------
// FILE		: wgl.corewrappers.cs
// VERSION	: 1.1.1
// COMMENT	: "Windows" specific OpenGL Core low level function wrappers.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2017
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
        // OPENGL WGL WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL WGL WRAPPERS...
        // int WINAPI wglChoosePixelFormat( HDC hdc, const PIXELFORMATDESCRIPTOR *ppfd);
        public static int ChoosePixelFormat(IntPtr hDC, ref PIXELFORMATDESCRIPTOR ppfd)
        {
            if (wglChoosePixelFormat != null)
            {
                return wglChoosePixelFormat(hDC, ref ppfd);
            }
            else
            {
                return 0;
            }
        }

        // int WINAPI wglDescribePixelFormat( HDC hdc, int iPixelFormat, UINT nBytes, LPPIXELFORMATDESCRIPTOR ppfd);
        public static int DescribePixelFormat(IntPtr hDC, int iPixelFormat, uint nBytes, ref PIXELFORMATDESCRIPTOR ppfd)
        {
            if (wglDescribePixelFormat != null)
            {
                return wglDescribePixelFormat(hDC, iPixelFormat, nBytes, ref ppfd);
            }
            else
            {
                return 0;
            }
        }

        // int WINAPI wglGetPixelFormat( HDC hdc );
        public static int GetPixelFormat(IntPtr hdc)
        {
            if (wglGetPixelFormat != null)
            {
                return wglGetPixelFormat(hdc);
            }
            else
            {
                return 0;
            }
        }

        // BOOL WINAPI wglSetPixelFormat( HDC hdc, int iPixelFormat, const PIXELFORMATDESCRIPTOR *ppfd);
        public static bool SetPixelFormat(IntPtr hdc, int iPixelFormat, ref PIXELFORMATDESCRIPTOR ppfd)
        {
            if (wglSetPixelFormat != null)
            {
                return wglSetPixelFormat(hdc, iPixelFormat, ref ppfd);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglSwapBuffers( HDC hdc );
        public static bool SwapBuffers(IntPtr hdc)
        {
            if (wglSwapBuffers != null)
            {
                return wglSwapBuffers(hdc);
            }
            else
            {
                return false;
            }
        }

        // HGLRC WINAPI wglCreateContext( HDC hdc );
        public static IntPtr CreateContext(IntPtr hdc)
        {
            if (wglCreateContext != null)
            {
                return wglCreateContext(hdc);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // HGLRC WINAPI wglCreateLayerContext( HDC hdc, int iLayerPlane );
        public static IntPtr CreateLayerContext(IntPtr hdc, int iLayerPlane)
        {
            if (wglCreateLayerContext != null)
            {
                return wglCreateLayerContext(hdc, iLayerPlane);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // BOOL WINAPI wglCopyContext( HGLRC hglrcSrc, HGLRC hglrcDst, UINT mask );
        public static bool CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, uint mask)
        {
            if (wglCopyContext != null)
            {
                return wglCopyContext(hglrcSrc, hglrcDst, mask);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglDeleteContext( HGLRC hglrc );
        public static bool DeleteContext(IntPtr hglrc)
        {
            if (wglDeleteContext != null)
            {
                return wglDeleteContext(hglrc);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglDescribeLayerPlane( HDC hdc, int iPixelFormat, int iLayerPlane, UINT nBytes, LPLAYERPLANEDESCRIPTOR plpd );
        public static bool DescribeLayerPlane(IntPtr hDC, int iPixelFormat, int iLayerPlane, uint nBytes, LAYERPLANEDESCRIPTOR plpd)
        {
            if (wglDescribeLayerPlane != null)
            {
                return wglDescribeLayerPlane(hDC, iPixelFormat, iLayerPlane, nBytes, ref plpd);
            }
            else
            {
                return false;
            }
        }

        // HGLRC WINAPI wglGetCurrentContext(void);
        public static IntPtr GetCurrentContext()
        {
            if (wglGetCurrentContext != null)
            {
                return wglGetCurrentContext();
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // HDC WINAPI wglGetCurrentDC(void);
        public static IntPtr GetCurrentDC()
        {
            if (wglGetCurrentDC != null)
            {
                return wglGetCurrentDC();
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // int WINAPI wglGetLayerPaletteEntries( HDC hdc, int iLayerPlane, int iStart, int cEntries, COLORREF *pcr);
        public static int GetLayerPaletteEntries(IntPtr hDC, int iLayerPlane, int iStart, int cEntries, ref COLORREF pcr)
        {
            if (wglGetLayerPaletteEntries != null)
            {
                return wglGetLayerPaletteEntries(hDC, iLayerPlane, iStart, cEntries, ref pcr);
            }
            else
            {
                return 0;
            }
        }

        // PROC WINAPI wglGetProcAddress( LPCSTR lpszProc );
        public static IntPtr GetProcAddress(string procname)
        {
            if (wglGetProcAddress != null)
            {
                return wglGetProcAddress(procname);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // BOOL WINAPI wglMakeCurrent( HDC hdc, HGLRC hglrc);
        public static bool MakeCurrent(IntPtr hdc, IntPtr hglrc)
        {
            if (wglMakeCurrent != null)
            {
                return wglMakeCurrent(hdc, hglrc);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglRealizeLayerPalette( HDC hdc, int iLayerPlane, BOOL bRealize );
        public static bool RealizeLayerPalette(IntPtr hdc, int iLayerPlane, bool bRealize)
        {
            if (wglRealizeLayerPalette != null)
            {
                return wglRealizeLayerPalette(hdc, iLayerPlane, bRealize);
            }
            else
            {
                return false;
            }
        }

        // int WINAPI wglSetLayerPaletteEntries( HDC hdc, int iLayerPlane, int iStart, int cEntries, const COLORREF *pcr );
        public static int SetLayerPaletteEntries(IntPtr hDC, int iLayerPlane, int iStart, int cEntries, ref COLORREF pcr)
        {
            if (wglSetLayerPaletteEntries != null)
            {
                return wglSetLayerPaletteEntries(hDC, iLayerPlane, iStart, cEntries, ref pcr);
            }
            else
            {
                return 0;
            }
        }

        // BOOL WINAPI wglShareLists( HGLRC hglrc1, HGLRC hglrc2);
        public static bool ShareLists(IntPtr hglrc1, IntPtr hglrc2)
        {
            if (wglShareLists != null)
            {
                return wglShareLists(hglrc1, hglrc2);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglSwapLayerBuffers( HDC hdc, UINT fuPlanes);
        public static bool SwapLayerBuffers(IntPtr hdc, uint fuPlanes)
        {
            if (wglSwapLayerBuffers != null)
            {
                return wglSwapLayerBuffers(hdc, fuPlanes);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglUseFontBitmaps( HDC hdc, DWORD first, DWORD count, DWORD listBase );
        public static bool UseFontBitmaps(IntPtr hdc, uint first, uint count, uint listBase)
        {
            if (wglUseFontBitmaps != null)
            {
                return wglUseFontBitmaps(hdc, first, count, listBase);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglUseFontOutlines( HDC hdc, DWORD first, DWORD count, DWORD listBase, FLOAT deviation, FLOAT extrusion, int format, LPGLYPHMETRICSFLOAT lpgmf);
        public static bool UseFontOutlines(IntPtr hDC, uint first, uint count, uint listBase, float deviation, float extrusion, int format, ref GLYPHMETRICSFLOAT lpgmf)
        {
            if (wglUseFontOutlines != null)
            {
                return wglUseFontOutlines(hDC, first, count, listBase, deviation, extrusion, format, ref lpgmf);
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}