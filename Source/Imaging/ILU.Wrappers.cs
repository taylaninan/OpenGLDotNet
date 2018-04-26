// ----------------------------------------------------------------------------
// FILE		: ilu.wrappers.cs
// VERSION	: 1.1.3
// DATE     : 26 April 2018
// COMMENT	: Image Library Utility (ILU). This "imported header" (from C/C++) 
//            defines wrappers for low level delegates and functions.
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
        // DevIL/ILU v1.7.8 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        // ILAPI ILboolean      ILAPIENTRY iluAlienify(void);
        public static ILboolean Alienify()
        {
            return iluAlienify();
        }

        // ILAPI ILboolean      ILAPIENTRY iluBlurAvg(ILuint Iter);
        public static ILboolean BlurAvg(ILuint Iter)
        {
            return iluBlurAvg(Iter);
        }

        // ILAPI ILboolean      ILAPIENTRY iluBlurGaussian(ILuint Iter);
        public static ILboolean BlurGaussian(ILuint Iter)
        {
            return iluBlurGaussian(Iter);
        }

        // ILAPI ILboolean      ILAPIENTRY iluBuildMipmaps(void);
        public static ILboolean BuildMipMaps()
        {
            return iluBuildMipmaps();
        }

        // ILAPI ILuint         ILAPIENTRY iluColoursUsed(void);
        public static ILuint ColoursUsed()
        {
            return iluColoursUsed();
        }

        // ILAPI ILboolean      ILAPIENTRY iluCompareImage(ILuint Comp);
        public static ILboolean CompareImage(ILuint Comp)
        {
            return iluCompareImage(Comp);
        }

        // ILAPI ILboolean      ILAPIENTRY iluContrast(ILfloat Contrast);
        public static ILboolean Contrast(ILfloat Contrast)
        {
            return iluContrast(Contrast);
        }

        // ILAPI ILboolean      ILAPIENTRY iluCrop(ILuint XOff, ILuint YOff, ILuint ZOff, ILuint Width, ILuint Height, ILuint Depth);
        public static ILboolean Crop(ILuint XOff, ILuint YOff, ILuint ZOff, ILuint Width, ILuint Height, ILuint Depth)
        {
            return iluCrop(XOff, YOff, ZOff, Width, Height, Depth);
        }

        // ILAPI void           ILAPIENTRY iluDeleteImage(ILuint Id); // Deprecated
        public static void DeleteImage(ILuint Id)
        {
            iluDeleteImage(Id);
        }

        // ILAPI ILboolean      ILAPIENTRY iluEdgeDetectE(void);
        public static ILboolean EdgeDetectE()
        {
            return iluEdgeDetectE();
        }

        // ILAPI ILboolean      ILAPIENTRY iluEdgeDetectP(void);
        public static ILboolean EdgeDetectP()
        {
            return iluEdgeDetectP();
        }

        // ILAPI ILboolean      ILAPIENTRY iluEdgeDetectS(void);
        public static ILboolean EdgeDetectS()
        {
            return iluEdgeDetectS();
        }

        // ILAPI ILboolean      ILAPIENTRY iluEmboss(void);
        public static ILboolean Emboss()
        {
            return iluEmboss();
        }

        // ILAPI ILboolean      ILAPIENTRY iluEnlargeCanvas(ILuint Width, ILuint Height, ILuint Depth);
        public static ILboolean EnlargeCanvas(ILuint Width, ILuint Height, ILuint Depth)
        {
            return iluEnlargeCanvas(Width, Height, Depth);
        }

        // ILAPI ILboolean      ILAPIENTRY iluEnlargeImage(ILfloat XDim, ILfloat YDim, ILfloat ZDim);
        public static ILboolean EnlargeImage(ILfloat XDim, ILfloat YDim, ILfloat ZDim)
        {
            return iluEnlargeImage(XDim, YDim, ZDim);
        }

        // ILAPI ILboolean      ILAPIENTRY iluEqualize(void);
        public static ILboolean Equalize()
        {
            return iluEqualize();
        }

        // ILAPI ILconst_string ILAPIENTRY iluErrorString(ILenum Error);
        public unsafe static string ErrorString(ILenum Error)
        {
            return new string((sbyte*)iluErrorString(Error));
        }

        // ILAPI ILboolean      ILAPIENTRY iluConvolution(ILint *matrix, ILint scale, ILint bias);
        public unsafe static ILboolean Convolution(ILint[] matrix, ILint scale, ILint bias)
        {
            fixed (ILint* ptr_matrix = matrix)
            {
                return iluConvolution(ptr_matrix, scale, bias);
            }
        }

        // ILAPI ILboolean      ILAPIENTRY iluFlipImage(void);
        public static ILboolean FlipImage()
        {
            return iluFlipImage();
        }

        // ILAPI ILboolean      ILAPIENTRY iluGammaCorrect(ILfloat Gamma);
        public static ILboolean GammaCorrect(ILfloat Gamma)
        {
            return iluGammaCorrect(Gamma);
        }

        // ILAPI ILuint         ILAPIENTRY iluGenImage(void); // Deprecated
        public static ILuint GenImage()
        {
            return iluGenImage();
        }

        // ILAPI void           ILAPIENTRY iluGetImageInfo(ILinfo *Info);
        public static void GetImageInfo(ILInfo Info)
        {
            iluGetImageInfo(Info);
        }

        // ILAPI ILint          ILAPIENTRY iluGetInteger(ILenum Mode);
        public static ILint GetInteger(ILenum Mode)
        {
            return iluGetInteger(Mode);
        }

        // ILAPI void           ILAPIENTRY iluGetIntegerv(ILenum Mode, ILint *Param);
        public unsafe static void GetIntegerv(ILenum Mode, ILint[] Param)
        {
            fixed (ILint* ptr_Param = Param)
            {
                iluGetIntegerv(Mode, ptr_Param);
            }
        }

        // ILAPI ILstring 		ILAPIENTRY iluGetString(ILenum StringName);
        public unsafe static string GetString(ILenum StringName)
        {
            return new string((sbyte*)iluGetString(StringName));
        }

        // ILAPI void           ILAPIENTRY iluImageParameter(ILenum PName, ILenum Param);
        public static void ImageParameter(ILenum PName, ILenum Param)
        {
            iluImageParameter(PName, Param);
        }

        // ILAPI void           ILAPIENTRY iluInit(void);
        public static void Init()
        {
            iluInit();
        }

        // ILAPI ILboolean      ILAPIENTRY iluInvertAlpha(void);
        public static ILboolean InvertAlpha()
        {
            return iluInvertAlpha();
        }

        // ILAPI ILuint         ILAPIENTRY iluLoadImage(ILconst_string FileName);
        public static ILuint LoadImage(ILconst_string FileName)
        {
            return iluLoadImage(FileName);
        }

        // ILAPI ILboolean      ILAPIENTRY iluMirror(void);
        public static ILboolean Mirror()
        {
            return iluMirror();
        }

        // ILAPI ILboolean      ILAPIENTRY iluNegative(void);
        public static ILboolean Negative()
        {
            return iluNegative();
        }

        // ILAPI ILboolean      ILAPIENTRY iluNoisify(ILclampf Tolerance);
        public static ILboolean Noisify(ILclampf Tolerance)
        {
            return iluNoisify(Tolerance);
        }

        // ILAPI ILboolean      ILAPIENTRY iluPixelize(ILuint PixSize);
        public static ILboolean Pixelize(ILuint PixSize)
        {
            return iluPixelize(PixSize);
        }

        // ILAPI void           ILAPIENTRY iluRegionfv(ILpointf *Points, ILuint n);
        public unsafe static void Regionfv(ILPointf[] Points, ILuint n)
        {
            fixed (ILPointf* ptr_Points = Points)
            {
                iluRegionfv(ptr_Points, n);
            }
        }

        // ILAPI void           ILAPIENTRY iluRegioniv(ILpointi *Points, ILuint n);
        public unsafe static void Regioniv(ILPointi[] Points, ILuint n)
        {
            fixed (ILPointi* ptr_Points = Points)
            {
                iluRegioniv(ptr_Points, n);
            }
        }

        // ILAPI ILboolean      ILAPIENTRY iluReplaceColour(ILubyte Red, ILubyte Green, ILubyte Blue, ILfloat Tolerance);
        public static ILboolean ReplaceColour(ILubyte Red, ILubyte Green, ILubyte Blue, ILfloat Tolerance)
        {
            return iluReplaceColour(Red, Green, Blue, Tolerance);
        }

        // ILAPI ILboolean      ILAPIENTRY iluRotate(ILfloat Angle);
        public static ILboolean Rotate(ILfloat Angle)
        {
            return iluRotate(Angle);
        }

        // ILAPI ILboolean      ILAPIENTRY iluRotate3D(ILfloat x, ILfloat y, ILfloat z, ILfloat Angle);
        public static ILboolean Rotate3D(ILfloat x, ILfloat y, ILfloat z, ILfloat Angle)
        {
            return iluRotate3D(x, y, z, Angle);
        }

        // ILAPI ILboolean      ILAPIENTRY iluSaturate1f(ILfloat Saturation);
        public static ILboolean Saturate1f(ILfloat Saturation)
        {
            return iluSaturate1f(Saturation);
        }

        // ILAPI ILboolean      ILAPIENTRY iluSaturate4f(ILfloat r, ILfloat g, ILfloat b, ILfloat Saturation);
        public static ILboolean Saturate4f(ILfloat r, ILfloat g, ILfloat b, ILfloat Saturation)
        {
            return iluSaturate4f(r, g, b, Saturation);
        }

        // ILAPI ILboolean      ILAPIENTRY iluScale(ILuint Width, ILuint Height, ILuint Depth);
        public static ILboolean Scale(ILuint Width, ILuint Height, ILuint Depth)
        {
            return iluScale(Width, Height, Depth);
        }

        // ILAPI ILboolean      ILAPIENTRY iluScaleAlpha(ILfloat scale);
        public static ILboolean ScaleAlpha(ILfloat scale)
        {
            return iluScaleAlpha(scale);
        }

        // ILAPI ILboolean      ILAPIENTRY iluScaleColours(ILfloat r, ILfloat g, ILfloat b);
        public static ILboolean ScaleColours(ILfloat r, ILfloat g, ILfloat b)
        {
            return iluScaleColours(r, g, b);
        }

        // ILAPI ILboolean      ILAPIENTRY iluSetLanguage(ILenum Language);
        public static ILboolean SetLanguage(ILenum Language)
        {
            return iluSetLanguage(Language);
        }

        // ILAPI ILboolean      ILAPIENTRY iluSharpen(ILfloat Factor, ILuint Iter);
        public static ILboolean Sharpen(ILfloat Factor, ILuint Iter)
        {
            return iluSharpen(Factor, Iter);
        }

        // ILAPI ILboolean      ILAPIENTRY iluSwapColours(void);
        public static ILboolean SwapColours()
        {
            return iluSwapColours();
        }

        // ILAPI ILboolean      ILAPIENTRY iluWave(ILfloat Angle);
        public static ILboolean Wave(ILfloat Angle)
        {
            return iluWave(Angle);
        }
    }
}
