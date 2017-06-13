// ----------------------------------------------------------------------------
// FILE		: ilu.functions.cs
// VERSION	: 1.1.1
// COMMENT	: Image Library Utility (ILU). This "imported header" (from C/C++) 
//            defines low level delegates and functions as close to C/C++.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2017
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
        // DevIL/ILU v1.7.8 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        // ILAPI ILboolean      ILAPIENTRY iluAlienify(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluAlienify();

        // ILAPI ILboolean      ILAPIENTRY iluBlurAvg(ILuint Iter);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluBlurAvg(ILuint Iter);

        // ILAPI ILboolean      ILAPIENTRY iluBlurGaussian(ILuint Iter);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluBlurGaussian(ILuint Iter);

        // ILAPI ILboolean      ILAPIENTRY iluBuildMipmaps(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluBuildMipmaps();

        // ILAPI ILuint         ILAPIENTRY iluColoursUsed(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILuint iluColoursUsed();

        // ILAPI ILboolean      ILAPIENTRY iluCompareImage(ILuint Comp);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluCompareImage(ILuint Comp);

        // ILAPI ILboolean      ILAPIENTRY iluContrast(ILfloat Contrast);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluContrast(ILfloat Contrast);

        // ILAPI ILboolean      ILAPIENTRY iluCrop(ILuint XOff, ILuint YOff, ILuint ZOff, ILuint Width, ILuint Height, ILuint Depth);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluCrop(ILuint XOff, ILuint YOff, ILuint ZOff, ILuint Width, ILuint Height, ILuint Depth);

        // ILAPI void           ILAPIENTRY iluDeleteImage(ILuint Id); // Deprecated
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void iluDeleteImage(ILuint Id);

        // ILAPI ILboolean      ILAPIENTRY iluEdgeDetectE(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluEdgeDetectE();

        // ILAPI ILboolean      ILAPIENTRY iluEdgeDetectP(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluEdgeDetectP();

        // ILAPI ILboolean      ILAPIENTRY iluEdgeDetectS(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluEdgeDetectS();

        // ILAPI ILboolean      ILAPIENTRY iluEmboss(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluEmboss();

        // ILAPI ILboolean      ILAPIENTRY iluEnlargeCanvas(ILuint Width, ILuint Height, ILuint Depth);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluEnlargeCanvas(ILuint Width, ILuint Height, ILuint Depth);

        // ILAPI ILboolean      ILAPIENTRY iluEnlargeImage(ILfloat XDim, ILfloat YDim, ILfloat ZDim);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluEnlargeImage(ILfloat XDim, ILfloat YDim, ILfloat ZDim);
        
        // ILAPI ILboolean      ILAPIENTRY iluEqualize(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluEqualize();

        // ILAPI ILconst_string ILAPIENTRY iluErrorString(ILenum Error);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern ILchar* iluErrorString(ILenum Error);

        // ILAPI ILboolean      ILAPIENTRY iluConvolution(ILint *matrix, ILint scale, ILint bias);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern ILboolean iluConvolution(ILint* matrix, ILint scale, ILint bias);

        // ILAPI ILboolean      ILAPIENTRY iluFlipImage(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluFlipImage();

        // ILAPI ILboolean      ILAPIENTRY iluGammaCorrect(ILfloat Gamma);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluGammaCorrect(ILfloat Gamma);

        // ILAPI ILuint         ILAPIENTRY iluGenImage(void); // Deprecated
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILuint iluGenImage();

        // ILAPI void           ILAPIENTRY iluGetImageInfo(ILinfo *Info);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void iluGetImageInfo([MarshalAs(UnmanagedType.LPStruct)] ILInfo Info);

        // ILAPI ILint          ILAPIENTRY iluGetInteger(ILenum Mode);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILint iluGetInteger(ILenum Mode);

        // ILAPI void           ILAPIENTRY iluGetIntegerv(ILenum Mode, ILint *Param);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern void iluGetIntegerv(ILenum Mode, ILint* Param);

        // ILAPI ILstring 		ILAPIENTRY iluGetString(ILenum StringName);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern ILchar* iluGetString(ILenum StringName);

        // ILAPI void           ILAPIENTRY iluImageParameter(ILenum PName, ILenum Param);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void iluImageParameter(ILenum PName, ILenum Param);

        // ILAPI void           ILAPIENTRY iluInit(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void iluInit();

        // ILAPI ILboolean      ILAPIENTRY iluInvertAlpha(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluInvertAlpha();

        // ILAPI ILuint         ILAPIENTRY iluLoadImage(ILconst_string FileName);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILuint iluLoadImage(ILconst_string FileName);

        // ILAPI ILboolean      ILAPIENTRY iluMirror(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluMirror();

        // ILAPI ILboolean      ILAPIENTRY iluNegative(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluNegative();

        // ILAPI ILboolean      ILAPIENTRY iluNoisify(ILclampf Tolerance);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluNoisify(ILclampf Tolerance);

        // ILAPI ILboolean      ILAPIENTRY iluPixelize(ILuint PixSize);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluPixelize(ILuint PixSize);

        // ILAPI void           ILAPIENTRY iluRegionfv(ILpointf *Points, ILuint n);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern void iluRegionfv(ILPointf* Points, ILuint n);

        // ILAPI void           ILAPIENTRY iluRegioniv(ILpointi *Points, ILuint n);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern void iluRegioniv(ILPointi* Points, ILuint n);

        // ILAPI ILboolean      ILAPIENTRY iluReplaceColour(ILubyte Red, ILubyte Green, ILubyte Blue, ILfloat Tolerance);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluReplaceColour(ILubyte Red, ILubyte Green, ILubyte Blue, ILfloat Tolerance);

        // ILAPI ILboolean      ILAPIENTRY iluRotate(ILfloat Angle);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluRotate(ILfloat Angle);

        // ILAPI ILboolean      ILAPIENTRY iluRotate3D(ILfloat x, ILfloat y, ILfloat z, ILfloat Angle);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluRotate3D(ILfloat x, ILfloat y, ILfloat z, ILfloat Angle);

        // ILAPI ILboolean      ILAPIENTRY iluSaturate1f(ILfloat Saturation);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluSaturate1f(ILfloat Saturation);

        // ILAPI ILboolean      ILAPIENTRY iluSaturate4f(ILfloat r, ILfloat g, ILfloat b, ILfloat Saturation);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluSaturate4f(ILfloat r, ILfloat g, ILfloat b, ILfloat Saturation);

        // ILAPI ILboolean      ILAPIENTRY iluScale(ILuint Width, ILuint Height, ILuint Depth);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluScale(ILuint Width, ILuint Height, ILuint Depth);

        // ILAPI ILboolean      ILAPIENTRY iluScaleAlpha(ILfloat scale);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluScaleAlpha(ILfloat Scale);

        // ILAPI ILboolean      ILAPIENTRY iluScaleColours(ILfloat r, ILfloat g, ILfloat b);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluScaleColours(ILfloat r, ILfloat g, ILfloat b);

        // ILAPI ILboolean      ILAPIENTRY iluSetLanguage(ILenum Language);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluSetLanguage(ILenum Language);

        // ILAPI ILboolean      ILAPIENTRY iluSharpen(ILfloat Factor, ILuint Iter);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluSharpen(ILfloat Factor, ILuint Iter);

        // ILAPI ILboolean      ILAPIENTRY iluSwapColours(void);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluSwapColours();

        // ILAPI ILboolean      ILAPIENTRY iluWave(ILfloat Angle);
        [DllImport("ILU.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean iluWave(ILfloat Angle);
    }
}
