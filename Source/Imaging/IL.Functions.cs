// ----------------------------------------------------------------------------
// FILE		: il.functions.cs
// VERSION	: 1.1.2
// COMMENT	: Image Library (IL). This "imported header" (from C/C++) provides 
//            low level (as close as C/C++) function and delegate declarations.
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
    public static partial class IL
    {
        ///////////////////////////////////////////////////////////////////////
        // DevIL/IL v1.7.8 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        //---------------------------------------------------------------------
        // Callback functions for file reading
        //---------------------------------------------------------------------
        // typedef void      (ILAPIENTRY *fCloseRProc)(ILHANDLE Handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKfCloseRProc(ILhandle Handle);

        // typedef ILboolean (ILAPIENTRY *fEofProc)   (ILHANDLE Handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ILboolean TCALLBACKfEofProc(ILhandle Handle);

        // typedef ILint     (ILAPIENTRY *fGetcProc)  (ILHANDLE Handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ILint TCALLBACKfGetcProc(ILhandle Handle);

        // typedef ILHANDLE  (ILAPIENTRY *fOpenRProc) (ILconst_string FileName);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate ILhandle TCALLBACKfOpenRProc(ILconst_string FileName);

        // typedef ILint     (ILAPIENTRY *fReadProc)  (void* Buffer, ILuint Size, ILuint Number, ILHANDLE Handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ILint TCALLBACKfReadProc(IntPtr Buffer, ILuint Size, ILuint Number, ILhandle Handle);

        // typedef ILint     (ILAPIENTRY *fSeekRProc) (ILHANDLE Handle, ILint Offset, ILint Mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ILint TCALLBACKfSeekRProc(ILhandle Handle, ILint Offset, ILint Mode);

        // typedef ILint     (ILAPIENTRY *fTellRProc) (ILHANDLE Handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ILint TCALLBACKfTellRProc(ILhandle Handle);

        //---------------------------------------------------------------------
        // Callback functions for file writing
        //---------------------------------------------------------------------
        // typedef void     (ILAPIENTRY *fCloseWProc)(ILHANDLE Handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKfCloseWProc(ILhandle Handle);

        // typedef ILHANDLE (ILAPIENTRY *fOpenWProc) (ILconst_string FileName);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate ILhandle TCALLBACKfOpenWProc(ILconst_string FileName);

        // typedef ILint    (ILAPIENTRY *fPutcProc)  (ILubyte Char, ILHANDLE Handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ILint TCALLBACKfPutcProc(ILubyte Char, ILhandle Handle);

        // typedef ILint    (ILAPIENTRY *fSeekWProc) (ILHANDLE Handle, ILint Offset, ILint Mode);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ILint TCALLBACKfSeekWProc(ILhandle Handle, ILint Offset, ILint Mode);

        // typedef ILint    (ILAPIENTRY *fTellWProc) (ILHANDLE Handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ILint TCALLBACKfTellWProc(ILhandle Handle);

        // typedef ILint    (ILAPIENTRY *fWriteProc) (const void* Buffer, ILuint Size, ILuint Number, ILHANDLE Handle);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate ILint TCALLBACKfWriteProc(IntPtr Buffer, ILuint Size, ILuint Number, ILhandle Handle);

        //---------------------------------------------------------------------
        // Callback functions for allocation and deallocation
        //---------------------------------------------------------------------
        // typedef void* (ILAPIENTRY *mAlloc)(const ILsizei Size);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate IntPtr TCALLBACKmAlloc(ILsizei Size);

        // typedef void  (ILAPIENTRY *mFree) (const void* CONST_RESTRICT ptr);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKmFree(IntPtr Ptr);

        //---------------------------------------------------------------------
        // Registered format procedures
        //---------------------------------------------------------------------
        // typedef ILenum (ILAPIENTRY *IL_LOADPROC)(ILconst_string FileName);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate ILenum TCALLBACKIL_LOADPROC(ILconst_string FileName);

        // typedef ILenum (ILAPIENTRY *IL_SAVEPROC)(ILconst_string FileName);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public delegate ILenum TCALLBACKIL_SAVEPROC(ILconst_string FileName);            

        //---------------------------------------------------------------------
        // ImageLib functions
        //---------------------------------------------------------------------
        // ILAPI ILboolean ILAPIENTRY ilActiveFace(ILuint Number);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilActiveFace(ILuint Number);

        // ILAPI ILboolean ILAPIENTRY ilActiveImage(ILuint Number);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilActiveImage(ILuint Number);

        // ILAPI ILboolean ILAPIENTRY ilActiveLayer(ILuint Number);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilActiveLayer(ILuint Number);

        // ILAPI ILboolean ILAPIENTRY ilActiveMipmap(ILuint Number);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilActiveMipmap(ILuint Number);

        // ILAPI ILboolean ILAPIENTRY ilApplyPal(ILconst_string FileName);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilApplyPal(ILconst_string FileName);

        // ILAPI ILboolean ILAPIENTRY ilApplyProfile(ILstring InProfile, ILstring OutProfile);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilApplyProfile(ILstring InProfile, ILstring OutProfile);

        // ILAPI void		ILAPIENTRY ilBindImage(ILuint Image);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilBindImage(ILuint Image);

        // ILAPI ILboolean ILAPIENTRY ilBlit(ILuint Source, ILint DestX, ILint DestY, ILint DestZ, ILuint SrcX, ILuint SrcY, ILuint SrcZ, ILuint Width, ILuint Height, ILuint Depth);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilBlit(ILuint Source, ILint DestX, ILint DestY, ILint DestZ, ILuint SrcX, ILuint SrcY, ILuint SrcZ, ILuint Width, ILuint Height, ILuint Depth);

        // ILAPI ILboolean ILAPIENTRY ilClampNTSC(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilClampNTSC();

        // ILAPI void		ILAPIENTRY ilClearColour(ILclampf Red, ILclampf Green, ILclampf Blue, ILclampf Alpha);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilClearColour(ILclampf Red, ILclampf Green, ILclampf Blue, ILclampf Alpha);

        // ILAPI ILboolean ILAPIENTRY ilClearImage(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilClearImage();

        // ILAPI ILuint    ILAPIENTRY ilCloneCurImage(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILuint ilCloneCurImage();

        // ILAPI ILubyte*	ILAPIENTRY ilCompressDXT(ILubyte *Data, ILuint Width, ILuint Height, ILuint Depth, ILenum DXTCFormat, ILuint *DXTCSize);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern IntPtr ilCompressDXT(IntPtr Data, ILuint Width, ILuint Height, ILuint Depth, ILenum DXTCFormat, out ILuint DXTCSize);

        // ILAPI ILboolean ILAPIENTRY ilCompressFunc(ILenum Mode);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilCompressFunc(ILenum Mode);

        // ILAPI ILboolean ILAPIENTRY ilConvertImage(ILenum DestFormat, ILenum DestType);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilConvertImage(ILenum DestFormat, ILenum DestType);

        // ILAPI ILboolean ILAPIENTRY ilConvertPal(ILenum DestFormat);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilConvertPal(ILenum DestFormat);

        // ILAPI ILboolean ILAPIENTRY ilCopyImage(ILuint Src);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilCopyImage(ILuint Src);

        // ILAPI ILuint    ILAPIENTRY ilCopyPixels(ILuint XOff, ILuint YOff, ILuint ZOff, ILuint Width, ILuint Height, ILuint Depth, ILenum Format, ILenum Type, void *Data);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILuint ilCopyPixels(ILuint XOff, ILuint YOff, ILuint ZOff, ILuint Width, ILuint Height, ILuint Depth, ILenum Format, ILenum Type, IntPtr Data);

        // ILAPI ILuint    ILAPIENTRY ilCreateSubImage(ILenum Type, ILuint Num);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILuint ilCreateSubImage(ILenum Type, ILuint Num);

        // ILAPI ILboolean ILAPIENTRY ilDefaultImage(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilDefaultImage();

        // ILAPI void		ILAPIENTRY ilDeleteImage(const ILuint Num);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilDeleteImage(ILuint Num);

        // ILAPI void      ILAPIENTRY ilDeleteImages(ILsizei Num, const ILuint *Images);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern void ilDeleteImages(ILsizei Num, ILuint* Images);

        // ILAPI ILenum	ILAPIENTRY ilDetermineType(ILconst_string FileName);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILenum ilDetermineType(ILconst_string FileName);

        // ILAPI ILenum	ILAPIENTRY ilDetermineTypeF(ILHANDLE File);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILenum ilDetermineTypeF(ILhandle File);

        // ILAPI ILenum	ILAPIENTRY ilDetermineTypeL(const void *Lump, ILuint Size);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILenum ilDetermineTypeL(IntPtr Lump, ILuint Size);

        // ILAPI ILboolean ILAPIENTRY ilDisable(ILenum Mode);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilDisable(ILenum Mode);

        // ILAPI ILboolean ILAPIENTRY ilDxtcDataToImage(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilDxtcDataToImage();

        // ILAPI ILboolean ILAPIENTRY ilDxtcDataToSurface(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilDxtcDataToSurface();

        // ILAPI ILboolean ILAPIENTRY ilEnable(ILenum Mode);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilEnable(ILenum Mode);

        // ILAPI void		ILAPIENTRY ilFlipSurfaceDxtcData(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilFlipSurfaceDxtcData();

        // ILAPI ILboolean ILAPIENTRY ilFormatFunc(ILenum Mode);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilFormatFunc(ILenum Mode);

        // ILAPI void	    ILAPIENTRY ilGenImages(ILsizei Num, ILuint *Images);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern void ilGenImages(ILsizei Num, ILuint* Images);

        // ILAPI ILuint	ILAPIENTRY ilGenImage(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILuint ilGenImage();

        // ILAPI ILubyte*  ILAPIENTRY ilGetAlpha(ILenum Type);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern IntPtr ilGetAlpha(ILenum Type);

        // ILAPI ILboolean ILAPIENTRY ilGetBoolean(ILenum Mode);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilGetBoolean(ILenum Mode);

        // ILAPI void      ILAPIENTRY ilGetBooleanv(ILenum Mode, ILboolean *Param);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern void ilGetBooleanv(ILenum Mode, ILboolean* Param);

        // ILAPI ILubyte*  ILAPIENTRY ilGetData(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern IntPtr ilGetData();

        // ILAPI ILuint    ILAPIENTRY ilGetDXTCData(void *Buffer, ILuint BufferSize, ILenum DXTCFormat);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILuint ilGetDXTCData(IntPtr Buffer, ILuint BufferSize, ILenum DXTCFormat);

        // ILAPI ILenum    ILAPIENTRY ilGetError(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILenum ilGetError();

        // ILAPI ILint     ILAPIENTRY ilGetInteger(ILenum Mode);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILint ilGetInteger(ILenum Mode);

        // ILAPI void      ILAPIENTRY ilGetIntegerv(ILenum Mode, ILint *Param);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern void ilGetIntegerv(ILenum Mode, ILint* Param);

        // ILAPI ILuint    ILAPIENTRY ilGetLumpPos(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILuint ilGetLumpPos();

        // ILAPI ILubyte*  ILAPIENTRY ilGetPalette(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern IntPtr ilGetPalette();

        // ILAPI ILconst_string  ILAPIENTRY ilGetString(ILenum StringName);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern ILchar* ilGetString(ILenum StringName);

        // ILAPI void      ILAPIENTRY ilHint(ILenum Target, ILenum Mode);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilHint(ILenum Target, ILenum Mode);

        // ILAPI ILboolean	ILAPIENTRY ilInvertSurfaceDxtcDataAlpha(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilInvertSurfaceDxtcDataAlpha();

        // ILAPI void      ILAPIENTRY ilInit(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilInit();

        // ILAPI ILboolean ILAPIENTRY ilImageToDxtcData(ILenum Format);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilImageToDxtcData(ILenum Format);

        // ILAPI ILboolean ILAPIENTRY ilIsDisabled(ILenum Mode);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilIsDisabled(ILenum Mode);

        // ILAPI ILboolean ILAPIENTRY ilIsEnabled(ILenum Mode);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilIsEnabled(ILenum Mode);

        // ILAPI ILboolean ILAPIENTRY ilIsImage(ILuint Image);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilIsImage(ILuint Image);

        // ILAPI ILboolean ILAPIENTRY ilIsValid(ILenum Type, ILconst_string FileName);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilIsValid(ILenum Type, ILconst_string FileName);

        // ILAPI ILboolean ILAPIENTRY ilIsValidF(ILenum Type, ILHANDLE File);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilIsValidF(ILenum Type, ILhandle File);

        // ILAPI ILboolean ILAPIENTRY ilIsValidL(ILenum Type, void *Lump, ILuint Size);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilIsValidL(ILenum Type, IntPtr Lump, ILuint Size);

        // ILAPI void      ILAPIENTRY ilKeyColour(ILclampf Red, ILclampf Green, ILclampf Blue, ILclampf Alpha);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilKeyColour(ILclampf Red, ILclampf Green, ILclampf Blue, ILclampf Alpha);

        // ILAPI ILboolean ILAPIENTRY ilLoad(ILenum Type, ILconst_string FileName);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilLoad(ILenum Type, ILconst_string FileName);

        // ILAPI ILboolean ILAPIENTRY ilLoadF(ILenum Type, ILHANDLE File);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilLoadF(ILenum Type, ILhandle File);

        // ILAPI ILboolean ILAPIENTRY ilLoadImage(ILconst_string FileName);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilLoadImage(ILconst_string FileName);

        // ILAPI ILboolean ILAPIENTRY ilLoadL(ILenum Type, const void *Lump, ILuint Size);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilLoadL(ILenum Type, IntPtr Lump, ILuint Size);

        // ILAPI ILboolean ILAPIENTRY ilLoadPal(ILconst_string FileName);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilLoadPal(ILconst_string FileName);

        // ILAPI void      ILAPIENTRY ilModAlpha(ILdouble AlphaValue);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilModAlpha(ILdouble AlphaValue);

        // ILAPI ILboolean ILAPIENTRY ilOriginFunc(ILenum Mode);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilOriginFunc(ILenum Mode);

        // ILAPI ILboolean ILAPIENTRY ilOverlayImage(ILuint Source, ILint XCoord, ILint YCoord, ILint ZCoord);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilOverlayImage(ILuint Source, ILint XCoord, ILint YCoord, ILint ZCoord);

        // ILAPI void      ILAPIENTRY ilPopAttrib(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilPopAttrib();

        // ILAPI void      ILAPIENTRY ilPushAttrib(ILuint Bits);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilPushAttrib(ILuint Bits);

        // ILAPI void      ILAPIENTRY ilRegisterFormat(ILenum Format);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilRegisterFormat(ILenum format);

        // ILAPI ILboolean ILAPIENTRY ilRegisterLoad(ILconst_string Ext, IL_LOADPROC Load);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilRegisterLoad(ILconst_string Ext, TCALLBACKIL_LOADPROC Load);

        // ILAPI ILboolean ILAPIENTRY ilRegisterMipNum(ILuint Num);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilRegisterMipNum(ILuint Num);

        // ILAPI ILboolean ILAPIENTRY ilRegisterNumFaces(ILuint Num);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilRegisterNumFaces(ILuint Num);

        // ILAPI ILboolean ILAPIENTRY ilRegisterNumImages(ILuint Num);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilRegisterNumImages(ILuint Num);

        // ILAPI void      ILAPIENTRY ilRegisterOrigin(ILenum Origin);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilRegisterOrigin(ILenum Origin);

        // ILAPI void      ILAPIENTRY ilRegisterPal(void *Pal, ILuint Size, ILenum Type);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilRegisterPal(IntPtr Pal, ILuint Size, ILenum Type);

        // ILAPI ILboolean ILAPIENTRY ilRegisterSave(ILconst_string Ext, IL_SAVEPROC Save);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilRegisterSave(ILconst_string Ext, TCALLBACKIL_SAVEPROC Save);

        // ILAPI void      ILAPIENTRY ilRegisterType(ILenum Type);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilRegisterType(ILenum Type);

        // ILAPI ILboolean ILAPIENTRY ilRemoveLoad(ILconst_string Ext);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet =  CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilRemoveLoad(ILconst_string Ext);

        // ILAPI ILboolean ILAPIENTRY ilRemoveSave(ILconst_string Ext);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilRemoveSave(ILconst_string Ext);

        // ILAPI void      ILAPIENTRY ilResetMemory(void); // Deprecated
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilResetMemory();

        // ILAPI void      ILAPIENTRY ilResetRead(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilResetRead();

        // ILAPI void      ILAPIENTRY ilResetWrite(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilResetWrite();

        // ILAPI ILboolean ILAPIENTRY ilSave(ILenum Type, ILconst_string FileName);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilSave(ILenum Type, ILconst_string FileName);

        // ILAPI ILuint    ILAPIENTRY ilSaveF(ILenum Type, ILHANDLE File);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILuint ilSaveF(ILenum Type, ILhandle File);

        // ILAPI ILboolean ILAPIENTRY ilSaveImage(ILconst_string FileName);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilSaveImage(ILconst_string FileName);

        // ILAPI ILuint    ILAPIENTRY ilSaveL(ILenum Type, void *Lump, ILuint Size);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILuint ilSaveL(ILenum Type, IntPtr Lump, ILuint Size);

        // ILAPI ILboolean ILAPIENTRY ilSavePal(ILconst_string FileName);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilSavePal(ILconst_string FileName);

        // ILAPI ILboolean ILAPIENTRY ilSetAlpha(ILdouble AlphaValue);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilSetAlpha(ILdouble AlphaValue);

        // ILAPI ILboolean ILAPIENTRY ilSetData(void *Data);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilSetData(IntPtr Data);

        // ILAPI ILboolean ILAPIENTRY ilSetDuration(ILuint Duration);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilSetDuration(ILuint Duration);

        // ILAPI void      ILAPIENTRY ilSetInteger(ILenum Mode, ILint Param);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilSetInteger(ILenum Mode, ILint Param);

        // ILAPI void      ILAPIENTRY ilSetMemory(mAlloc, mFree);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilSetMemory(TCALLBACKmAlloc mAlloc, TCALLBACKmFree mFree);

        // ILAPI void      ILAPIENTRY ilSetPixels(ILint XOff, ILint YOff, ILint ZOff, ILuint Width, ILuint Height, ILuint Depth, ILenum Format, ILenum Type, void *Data);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilSetPixels(ILint XOff, ILint YOff, ILint ZOff, ILuint Width, ILuint Height, ILuint Depth, ILenum Format, ILenum Type, IntPtr Data);

        // ILAPI void      ILAPIENTRY ilSetRead(fOpenRProc Open, fCloseRProc Close, fEofProc Eof , fGetcProc Getc, fReadProc Read, fSeekRProc Seek, fTellRProc Tell);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilSetRead(TCALLBACKfOpenRProc Open, TCALLBACKfCloseRProc Close, TCALLBACKfEofProc Eof, TCALLBACKfGetcProc Getc, TCALLBACKfReadProc Read, TCALLBACKfSeekRProc Seek, TCALLBACKfTellRProc Tell);

        // ILAPI void      ILAPIENTRY ilSetString(ILenum Mode, const char *String);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilSetString(ILenum Mode, ILconst_string String);

        // ILAPI void      ILAPIENTRY ilSetWrite(fOpenWProc Open, fCloseWProc Close, fPutcProc Putc, fSeekWProc Seek, fTellWProc Tell, fWriteProc Write);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilSetWrite(TCALLBACKfOpenWProc Open, TCALLBACKfCloseWProc Close, TCALLBACKfPutcProc Putc, TCALLBACKfSeekWProc Seek, TCALLBACKfTellWProc Tell, TCALLBACKfWriteProc Write);

        // ILAPI void      ILAPIENTRY ilShutDown(void);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void ilShutDown();

        // ILAPI ILboolean ILAPIENTRY ilSurfaceToDxtcData(ILenum Format);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilSurfaceToDxtcData(ILenum Format);

        // ILAPI ILboolean ILAPIENTRY ilTexImage(ILuint Width, ILuint Height, ILuint Depth, ILubyte NumChannels, ILenum Format, ILenum Type, void *Data);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilTexImage(ILuint Width, ILuint Height, ILuint Depth, ILubyte NumChannels, ILenum Format, ILenum Type, IntPtr Data);

        // ILAPI ILboolean ILAPIENTRY ilTexImageDxtc(ILint w, ILint h, ILint d, ILenum DxtFormat, const ILubyte* data);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilTexImageDxtc(ILint w, ILint h, ILint d, ILenum DxtFormat, IntPtr Data);

        // ILAPI ILenum    ILAPIENTRY ilTypeFromExt(ILconst_string FileName);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILenum ilTypeFromExt(ILconst_string FileName);

        // ILAPI ILboolean ILAPIENTRY ilTypeFunc(ILenum Mode);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilTypeFunc(ILenum Mode);

        // ILAPI ILboolean ILAPIENTRY ilLoadData(ILconst_string FileName, ILuint Width, ILuint Height, ILuint Depth, ILubyte Bpp);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilLoadData(ILconst_string FileName, ILuint Width, ILuint Height, ILuint Depth, ILubyte Bpp);

        // ILAPI ILboolean ILAPIENTRY ilLoadDataF(ILHANDLE File, ILuint Width, ILuint Height, ILuint Depth, ILubyte Bpp);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilLoadDataF(ILhandle File, ILuint Width, ILuint Height, ILuint Depth, ILubyte Bpp);

        // ILAPI ILboolean ILAPIENTRY ilLoadDataL(void *Lump, ILuint Size, ILuint Width, ILuint Height, ILuint Depth, ILubyte Bpp);
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilLoadDataL(IntPtr Lump, ILuint Size, ILuint Width, ILuint Height, ILuint Depth, ILubyte Bpp);

        // ILAPI ILboolean ILAPIENTRY ilSaveData(ILconst_string FileName);    
        [DllImport("DevIL.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern ILboolean ilSaveData(ILconst_string FileName);
    }
}
