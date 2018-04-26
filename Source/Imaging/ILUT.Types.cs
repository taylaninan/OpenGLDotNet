// ----------------------------------------------------------------------------
// FILE		: ilut.types.cs
// VERSION	: 1.1.3
// DATE     : 26 April 2018
// COMMENT	: Image Library Utility Toolkit(ILUT). This "imported header" (from C/C++) 
//            defines required types for use with ILUT.
// WEB      : https://github.com/carmack78/opengldotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : taylaninan@yahoo.com 
// DATE     : 2014-2018
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

using BYTE = System.Byte;
using WORD = System.UInt16;
using DWORD = System.UInt32;
using LONG = System.Int32;

namespace OpenGLDotNet
{
    public static partial class ILUT
    {
        ///////////////////////////////////////////////////////////////////////
        // DevIL/ILUT v1.7.8 TYPES
        ///////////////////////////////////////////////////////////////////////
        [StructLayout(LayoutKind.Sequential)]
        public struct BITMAPINFOHEADER
        {
            DWORD biSize;
            LONG biWidth;
            LONG biHeight;
            WORD biPlanes;
            WORD biBitCount;
            DWORD biCompression;
            DWORD biSizeImage;
            LONG biXPelsPerMeter;
            LONG biYPelsPerMeter;
            DWORD biClrUsed;
            DWORD biClrImportant;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RGBQUAD
        {
            BYTE rgbBlue;
            BYTE rgbGreen;
            BYTE rgbRed;
            BYTE rgbReserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class BITMAPINFO
        {
            BITMAPINFOHEADER bmiHeader;
            RGBQUAD bmiColors;
        }
    }
}
