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
    public static partial class ILUT
    {
        ///////////////////////////////////////////////////////////////////////
        // DevIL/ILUT v1.7.8 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        //---------------------------------------------------------------------
        // ImageLib Utility Toolkit Functions
        //---------------------------------------------------------------------
        // ILAPI ILboolean	ILAPIENTRY ilutDisable(ILenum Mode);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutDisable(ILenum Mode);

        // ILAPI ILboolean	ILAPIENTRY ilutEnable(ILenum Mode);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutEnable(ILenum Mode);

        // ILAPI ILboolean	ILAPIENTRY ilutGetBoolean(ILenum Mode);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutGetBoolean(ILenum Mode);

        // ILAPI void       ILAPIENTRY ilutGetBooleanv(ILenum Mode, ILboolean *Param);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern void ilutGetBooleanv(ILenum Mode, ILboolean* Param);

        // ILAPI ILint		ILAPIENTRY ilutGetInteger(ILenum Mode);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILint ilutGetInteger(ILenum Mode);

        // ILAPI void       ILAPIENTRY ilutGetIntegerv(ILenum Mode, ILint *Param);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern void ilutGetIntegerv(ILenum Mode, ILint* Param);

        // ILAPI ILstring   ILAPIENTRY ilutGetString(ILenum StringName);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern ILchar* ilutGetString(ILenum StringName);

        // ILAPI void       ILAPIENTRY ilutInit(void);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void ilutInit();

        // ILAPI ILboolean  ILAPIENTRY ilutIsDisabled(ILenum Mode);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutIsDisabled(ILenum Mode);

        // ILAPI ILboolean  ILAPIENTRY ilutIsEnabled(ILenum Mode);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutIsEnabled(ILenum Mode);

        // ILAPI void       ILAPIENTRY ilutPopAttrib(void);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void ilutPopAttrib();

        // ILAPI void       ILAPIENTRY ilutPushAttrib(ILuint Bits);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void ilutPushAttrib(ILuint Bits);

        // ILAPI void       ILAPIENTRY ilutSetInteger(ILenum Mode, ILint Param);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void ilutSetInteger(ILenum Mode, ILint Param);

        // ILAPI ILboolean  ILAPIENTRY ilutRenderer(ILenum Renderer);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutRenderer(ILenum Renderer);

        //---------------------------------------------------------------------
        // ImageLib Utility Toolkit's OpenGL Functions
        //---------------------------------------------------------------------
        // ILAPI GLuint	    ILAPIENTRY ilutGLBindTexImage();
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILuint ilutGLBindTexImage();

        // ILAPI GLuint	    ILAPIENTRY ilutGLBindMipmaps(void);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILuint ilutGLBindMipmaps();

        // ILAPI ILboolean	ILAPIENTRY ilutGLBuildMipmaps(void);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutGLBuildMipmaps();

        // ILAPI GLuint	    ILAPIENTRY ilutGLLoadImage(ILstring FileName);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern ILuint ilutGLLoadImage(ILstring FileName);

        // ILAPI ILboolean	ILAPIENTRY ilutGLScreen(void);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutGLScreen();

        // ILAPI ILboolean	ILAPIENTRY ilutGLScreenie(void);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutGLScreenie();

        // ILAPI ILboolean	ILAPIENTRY ilutGLSaveImage(ILstring FileName, GLuint TexID);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern ILboolean ilutGLSaveImage(ILstring FileName, ILuint TexID);
        
        // ILAPI ILboolean  ILAPIENTRY ilutGLSubTex2D(GLuint TexID, ILuint XOff, ILuint YOff);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutGLSubTex2D(ILuint TexID, ILuint XOff, ILuint YOff);
        
        // ILAPI ILboolean  ILAPIENTRY ilutGLSubTex3D(GLuint TexID, ILuint XOff, ILuint YOff, ILuint ZOff);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutGLSubTex3D(ILuint TexID, ILuint XOff, ILuint YOff, ILuint ZOff);
        
        // ILAPI ILboolean	ILAPIENTRY ilutGLSetTex2D(GLuint TexID);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutGLSetTex2D(ILuint TexID);

        // ILAPI ILboolean	ILAPIENTRY ilutGLSetTex3D(GLuint TexID);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutGLSetTex3D(ILuint TexID);

        // ILAPI ILboolean	ILAPIENTRY ilutGLTexImage(GLuint Level);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutGLTexImage(ILuint Level);
  
        // ILAPI ILboolean	ILAPIENTRY ilutGLSetTex(GLuint TexID);  // Deprecated - use ilutGLSetTex2D.
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutGLSetTex(ILuint TexID);
        
        // ILAPI ILboolean  ILAPIENTRY ilutGLSubTex(GLuint TexID, ILuint XOff, ILuint YOff);  // Use ilutGLSubTex2D.
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutGLSubTex(ILuint TexID, ILuint XOff, ILuint YOff);
        
        //---------------------------------------------------------------------
        // ImageLib Utility Toolkit's Win32 GDI Functions
        //---------------------------------------------------------------------
        // ILAPI HBITMAP	ILAPIENTRY ilutConvertToHBitmap(HDC hDC);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr ilutConvertToHBitmap(IntPtr hDC);

        // ILAPI HBITMAP	ILAPIENTRY ilutConvertSliceToHBitmap(HDC hDC, ILuint slice);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr ilutConvertSliceToHBitmap(IntPtr hDC, ILuint slice);

        // ILAPI void	    ILAPIENTRY ilutFreePaddedData(ILubyte *Data);
		[DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void ilutFreePaddedData(IntPtr Data);

        // ILAPI void	    ILAPIENTRY ilutGetBmpInfo(BITMAPINFO *Info);
		[DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void ilutGetBmpInfo([MarshalAs(UnmanagedType.LPStruct)] BITMAPINFO Info);

        // ILAPI HPALETTE	ILAPIENTRY ilutGetHPal(void);
		[DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr ilutGetHPal();

        // ILAPI ILubyte*	ILAPIENTRY ilutGetPaddedData(void);
		[DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr ilutGetPaddedData();

        // ILAPI ILboolean	ILAPIENTRY ilutGetWinClipboard(void);
		[DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutGetWinClipboard();

        // ILAPI ILboolean	ILAPIENTRY ilutLoadResource(HINSTANCE hInst, ILint ID, ILstring ResourceType, ILenum Type);
		[DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern ILboolean ilutLoadResource(IntPtr hInstance, ILint ID, ILstring ResourceType, ILenum Type);

        // ILAPI ILboolean	ILAPIENTRY ilutSetHBitmap(HBITMAP Bitmap);
		[DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutSetHBitmap(IntPtr BitMap);

        // ILAPI ILboolean	ILAPIENTRY ilutSetHPal(HPALETTE Pal);
		[DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutSetHPal(IntPtr Pal);

        // ILAPI ILboolean	ILAPIENTRY ilutSetWinClipboard(void);
		[DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutSetWinClipboard();

        // ILAPI HBITMAP	ILAPIENTRY ilutWinLoadImage(ILstring FileName, HDC hDC);
		[DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern IntPtr ilutWinLoadImage(ILstring FileName, IntPtr hDC);

        // ILAPI ILboolean	ILAPIENTRY ilutWinLoadUrl(ILstring Url);
		[DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern ILboolean ilutWinLoadUrl(ILstring Url);

        // ILAPI ILboolean  ILAPIENTRY ilutWinPrint(ILuint XPos, ILuint YPos, ILuint Width, ILuint Height, HDC hDC);
		[DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern ILboolean ilutWinPrint(ILuint XPos, ILuint YPos, ILuint Width, ILuint Height, IntPtr hDC);

        // ILAPI ILboolean	ILAPIENTRY ilutWinSaveImage(ILstring FileName, HBITMAP Bitmap);
        [DllImport("ILUT.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern ILboolean ilutWinSaveImage(ILstring FileName, IntPtr Bitmap);
    }
}
