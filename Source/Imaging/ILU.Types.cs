// ----------------------------------------------------------------------------
// FILE		: ilu.types.cs
// VERSION	: 1.1.2
// COMMENT	: Image Library Utility (ILU). This "imported header" (from C/C++) 
//            defines required types for use with ILU.
// WEB      : https://github.com/carmack78/opengldotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : taylaninan@yahoo.com 
// DATE     : 2014-2018
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

using ILenum = System.UInt32;
using ILboolean = System.Boolean;
using ILbitfield = System.UInt32;
using ILbyte = System.SByte;
using ILshort = System.Int16;
using ILint = System.Int32;
using ILsizei = System.UInt32;
using ILubyte = System.Byte;
using ILushort = System.UInt16;
using ILuint = System.UInt32;
using ILfloat = System.Single;
using ILclampf = System.Single;
using ILdouble = System.Double;
using ILclampd = System.Double;
using ILint64 = System.Int64;
using ILuint64 = System.UInt64;
using ILchar = System.Byte;
using ILstring = System.String;
using ILconst_string = System.String;
using ILhandle = System.IntPtr;

namespace OpenGLDotNet
{
    public static partial class ILU
    {
        ///////////////////////////////////////////////////////////////////////
        // DevIL/ILU v1.7.8 TYPES
        ///////////////////////////////////////////////////////////////////////
        [StructLayout(LayoutKind.Sequential)]
        public class ILInfo
        {
	        ILuint      Id;         // the image's id
	        ILhandle    Data;       // the image's data
	        ILuint      Width;      // the image's width
	        ILuint      Height;     // the image's height
	        ILuint      Depth;      // the image's depth
	        ILubyte     Bpp;        // bytes per pixel (not bits) of the image
	        ILuint      SizeOfData; // the total size of the data (in bytes)
	        ILenum      Format;     // image format (in IL enum style)
	        ILenum      Type;       // image type (in IL enum style)
	        ILenum      Origin;     // origin of the image
	        ILhandle    Palette;    // the image's palette
	        ILenum      PalType;    // palette type
	        ILuint      PalSize;    // palette size
	        ILenum      CubeFlags;  // flags for what cube map sides are present
	        ILuint      NumNext;    // number of images following
	        ILuint      NumMips;    // number of mipmaps
	        ILuint      NumLayers;  // number of layers
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ILPointf
        {
            ILfloat x;
            ILfloat y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ILPointi
        {
            ILint x;
            ILint y;
        }
    }
}
