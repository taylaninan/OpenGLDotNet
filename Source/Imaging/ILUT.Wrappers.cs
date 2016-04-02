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
        // DevIL/ILUT v1.7.8 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        //---------------------------------------------------------------------
        // ImageLib Utility Toolkit Functions
        //---------------------------------------------------------------------
        // ILAPI ILboolean	ILAPIENTRY ilutDisable(ILenum Mode);
        public static ILboolean Disable(ILenum Mode)
        {
            return ilutDisable(Mode);
        }

        // ILAPI ILboolean	ILAPIENTRY ilutEnable(ILenum Mode);
        public static ILboolean Enable(ILenum Mode)
        {
            return ilutEnable(Mode);
        }

        // ILAPI ILboolean	ILAPIENTRY ilutGetBoolean(ILenum Mode);
        public static ILboolean GetBoolean(ILenum Mode)
        {
            return ilutGetBoolean(Mode);
        }

        // ILAPI void       ILAPIENTRY ilutGetBooleanv(ILenum Mode, ILboolean *Param);
        public unsafe static void GetBooleanv(ILenum Mode, ILboolean[] Param)
        {
            fixed (ILboolean* ptr_Param = Param)
            {
                ilutGetBooleanv(Mode, ptr_Param);
            }
        }

        // ILAPI ILint		ILAPIENTRY ilutGetInteger(ILenum Mode);
        public static ILint GetInteger(ILenum Mode)
        {
            return ilutGetInteger(Mode);
        }

        // ILAPI void       ILAPIENTRY ilutGetIntegerv(ILenum Mode, ILint *Param);
        public unsafe static void GetIntegerv(ILenum Mode, ILint[] Param)
        {
            fixed (ILint* ptr_Param = Param)
            {
                ilutGetIntegerv(Mode, ptr_Param);
            }
        }

        // ILAPI ILstring   ILAPIENTRY ilutGetString(ILenum StringName);
        public unsafe static string GetString(ILenum StringName)
        {
            return new string((sbyte*)ilutGetString(StringName));
        }

        // ILAPI void       ILAPIENTRY ilutInit(void);
        public static void Init()
        {
            ilutInit();
        }

        // ILAPI ILboolean  ILAPIENTRY ilutIsDisabled(ILenum Mode);
        public static ILboolean IsDisabled(ILenum Mode)
        {
            return ilutIsDisabled(Mode);
        }

        // ILAPI ILboolean  ILAPIENTRY ilutIsEnabled(ILenum Mode);
        public static ILboolean IsEnabled(ILenum Mode)
        {
            return ilutIsEnabled(Mode);
        }

        // ILAPI void       ILAPIENTRY ilutPopAttrib(void);
        public static void PopAttrib()
        {
            ilutPopAttrib();
        }

        // ILAPI void       ILAPIENTRY ilutPushAttrib(ILuint Bits);
        public static void PushAttrib(ILuint Bits)
        {
            ilutPushAttrib(Bits);
        }

        // ILAPI void       ILAPIENTRY ilutSetInteger(ILenum Mode, ILint Param);
        public static void SetInteger(ILenum Mode, ILint Param)
        {
            ilutSetInteger(Mode, Param);
        }

        // ILAPI ILboolean  ILAPIENTRY ilutRenderer(ILenum Renderer);
        public static void Renderer(ILenum Renderer)
        {
            ilutRenderer(Renderer);
        }

        //---------------------------------------------------------------------
        // ImageLib Utility Toolkit's OpenGL Functions
        //---------------------------------------------------------------------
        // ILAPI GLuint	    ILAPIENTRY ilutGLBindTexImage();
        public static ILuint GLBindTexImage()
        {
            return ilutGLBindTexImage();
        }

        // ILAPI GLuint	    ILAPIENTRY ilutGLBindMipmaps(void);
        public static ILuint GLBindMipmaps()
        {
            return ilutGLBindMipmaps();
        }

        // ILAPI ILboolean	ILAPIENTRY ilutGLBuildMipmaps(void);
        public static ILboolean GLBuildMipmaps()
        {
            return ilutGLBuildMipmaps();
        }

        // ILAPI GLuint	    ILAPIENTRY ilutGLLoadImage(ILstring FileName);
        public static ILuint GLLoadImage(ILstring FileName)
        {
            return ilutGLLoadImage(FileName);
        }

        // ILAPI ILboolean	ILAPIENTRY ilutGLScreen(void);
        public static ILboolean GLScreen()
        {
            return ilutGLScreen();
        }

        // ILAPI ILboolean	ILAPIENTRY ilutGLScreenie(void);
        public static ILboolean GLScreenie()
        {
            return ilutGLScreenie();
        }

        // ILAPI ILboolean	ILAPIENTRY ilutGLSaveImage(ILstring FileName, GLuint TexID);
        public static ILboolean GLSaveImage(ILstring FileName, ILuint TexID)
        {
            return ilutGLSaveImage(FileName, TexID);
        }

        // ILAPI ILboolean  ILAPIENTRY ilutGLSubTex2D(GLuint TexID, ILuint XOff, ILuint YOff);
        public static ILboolean GLSubTex2D(ILuint TexID, ILuint XOff, ILuint YOff)
        {
            return ilutGLSubTex2D(TexID, XOff, YOff);
        }

        // ILAPI ILboolean  ILAPIENTRY ilutGLSubTex3D(GLuint TexID, ILuint XOff, ILuint YOff, ILuint ZOff);
        public static ILboolean GLSubTex3D(ILuint TexID, ILuint XOff, ILuint YOff, ILuint ZOff)
        {
            return ilutGLSubTex3D(TexID, XOff, YOff, ZOff);
        }

        // ILAPI ILboolean	ILAPIENTRY ilutGLSetTex2D(GLuint TexID);
        public static ILboolean GLSetTex2D(ILuint TexID)
        {
            return ilutGLSetTex2D(TexID);
        }

        // ILAPI ILboolean	ILAPIENTRY ilutGLSetTex3D(GLuint TexID);
        public static ILboolean GLSetTex3D(ILuint TexID)
        {
            return ilutGLSetTex3D(TexID);
        }

        // ILAPI ILboolean	ILAPIENTRY ilutGLTexImage(GLuint Level);
        public static ILboolean GLTexImage(ILuint Level)
        {
            return ilutGLTexImage(Level);
        }

        // ILAPI ILboolean	ILAPIENTRY ilutGLSetTex(GLuint TexID);  // Deprecated - use ilutGLSetTex2D.
        public static ILboolean GLSetTex(ILuint TexID)
        {
            return ilutGLSetTex(TexID);
        }

        // ILAPI ILboolean  ILAPIENTRY ilutGLSubTex(GLuint TexID, ILuint XOff, ILuint YOff);  // Use ilutGLSubTex2D.
        public static ILboolean GLSubTex(ILuint TexID, ILuint XOff, ILuint YOff)
        {
            return ilutGLSubTex(TexID, XOff, YOff);
        }

        //---------------------------------------------------------------------
        // ImageLib Utility Toolkit's Win32 GDI Functions
        //---------------------------------------------------------------------
        // ILAPI HBITMAP	ILAPIENTRY ilutConvertToHBitmap(HDC hDC);
        public static IntPtr ConvertToHBitmap(IntPtr hDC)
        {
            return ilutConvertToHBitmap(hDC);
        }

        // ILAPI HBITMAP	ILAPIENTRY ilutConvertSliceToHBitmap(HDC hDC, ILuint slice);
        public static IntPtr ConvertSliceToHBitmap(IntPtr hDC, ILuint slice)
        {
            return ilutConvertSliceToHBitmap(hDC, slice);
        }

        // ILAPI void	    ILAPIENTRY ilutFreePaddedData(ILubyte *Data);
        public static void FreePaddedData(IntPtr Data)
        {
            ilutFreePaddedData(Data);
        }

        // ILAPI void	    ILAPIENTRY ilutGetBmpInfo(BITMAPINFO *Info);
        public static void GetBmpInfo(BITMAPINFO Info)
        {
            ilutGetBmpInfo(Info);
        }

        // ILAPI HPALETTE	ILAPIENTRY ilutGetHPal(void);
        public static IntPtr GetHPal()
        {
            return ilutGetHPal();
        }

        // ILAPI ILubyte*	ILAPIENTRY ilutGetPaddedData(void);
        public static IntPtr GetPaddedData()
        {
            return ilutGetPaddedData();
        }

        // ILAPI ILboolean	ILAPIENTRY ilutGetWinClipboard(void);
        public static ILboolean GetWinClipboard()
        {
            return ilutGetWinClipboard();
        }

        // ILAPI ILboolean	ILAPIENTRY ilutLoadResource(HINSTANCE hInst, ILint ID, ILstring ResourceType, ILenum Type);
        public static ILboolean LoadResource(IntPtr hInstance, ILint ID, ILstring ResourceType, ILenum Type)
        {
            return ilutLoadResource(hInstance, ID, ResourceType, Type);
        }

        // ILAPI ILboolean	ILAPIENTRY ilutSetHBitmap(HBITMAP Bitmap);
        public static ILboolean SetHBitmap(IntPtr Bitmap)
        {
            return ilutSetHBitmap(Bitmap);
        }

        // ILAPI ILboolean	ILAPIENTRY ilutSetHPal(HPALETTE Pal);
        public static ILboolean SetHPal(IntPtr Pal)
        {
            return ilutSetHPal(Pal);
        }

        // ILAPI ILboolean	ILAPIENTRY ilutSetWinClipboard(void);
        public static ILboolean SetWinClipboard()
        {
            return ilutSetWinClipboard();
        }

        // ILAPI HBITMAP	ILAPIENTRY ilutWinLoadImage(ILstring FileName, HDC hDC);
        public static IntPtr WinLoadImage(ILstring FileName, IntPtr hDC)
        {
            return ilutWinLoadImage(FileName, hDC);
        }

        // ILAPI ILboolean	ILAPIENTRY ilutWinLoadUrl(ILstring Url);
        public static ILboolean WinLoadUrl(ILstring Url)
        {
            return ilutWinLoadUrl(Url);
        }

        // ILAPI ILboolean  ILAPIENTRY ilutWinPrint(ILuint XPos, ILuint YPos, ILuint Width, ILuint Height, HDC hDC);
        public static ILboolean WinPrint(ILuint XPos, ILuint YPos, ILuint Width, ILuint Height, IntPtr hDC)
        {
            return ilutWinPrint(XPos, YPos, Width, Height, hDC);
        }

        // ILAPI ILboolean	ILAPIENTRY ilutWinSaveImage(ILstring FileName, HBITMAP Bitmap);
        public static ILboolean WinSaveImage(ILstring FileName, IntPtr Bitmap)
        {
            return ilutWinSaveImage(FileName, Bitmap);
        }
    }
}
