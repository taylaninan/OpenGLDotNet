// ----------------------------------------------------------------------------
// FILE		: il.wrappers.cs
// VERSION	: 1.1.0
// COMMENT	: Image Library (IL). This "imported header" (from C/C++) provides 
//            wrappers for low delegates and functions, which are defined in 
//            il.functions.cs file.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2016
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
        // DevIL/IL v1.7.8 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        //---------------------------------------------------------------------
        // ImageLib functions
        //---------------------------------------------------------------------
        // ILAPI ILboolean ILAPIENTRY ilActiveFace(ILuint Number);
        public static ILboolean ActiveFace(ILuint Number)
        {
            return ilActiveFace(Number);
        }

        // ILAPI ILboolean ILAPIENTRY ilActiveImage(ILuint Number);
        public static ILboolean ActiveImage(ILuint Number)
        {
            return ilActiveImage(Number);
        }

        // ILAPI ILboolean ILAPIENTRY ilActiveLayer(ILuint Number);
        public static ILboolean ActiveLayer(ILuint Number)
        {
            return ilActiveLayer(Number);
        }

        // ILAPI ILboolean ILAPIENTRY ilActiveMipmap(ILuint Number);
        public static ILboolean ActiveMipmap(ILuint Number)
        {
            return ilActiveMipmap(Number);
        }

        // ILAPI ILboolean ILAPIENTRY ilApplyPal(ILconst_string FileName);
        public static ILboolean ApplyPal(ILconst_string FileName)
        {
            return ilApplyPal(FileName);
        }

        // ILAPI ILboolean ILAPIENTRY ilApplyProfile(ILstring InProfile, ILstring OutProfile);
        public static ILboolean ApplyProfile(ILstring InProfile, ILstring OutProfile)
        {
            return ilApplyProfile(InProfile, OutProfile);
        }

        // ILAPI void		ILAPIENTRY ilBindImage(ILuint Image);
        public static void BindImage(ILuint Image)
        {
            ilBindImage(Image);
        }

        // ILAPI ILboolean ILAPIENTRY ilBlit(ILuint Source, ILint DestX, ILint DestY, ILint DestZ, ILuint SrcX, ILuint SrcY, ILuint SrcZ, ILuint Width, ILuint Height, ILuint Depth);
        public static ILboolean Blit(ILuint Source, ILint DestX, ILint DestY, ILint DestZ, ILuint SrcX, ILuint SrcY, ILuint SrcZ, ILuint Width, ILuint Height, ILuint Depth)
        {
            return ilBlit(Source, DestX, DestY, DestZ, SrcX, SrcY, SrcZ, Width, Height, Depth);
        }

        // ILAPI ILboolean ILAPIENTRY ilClampNTSC(void);
        public static ILboolean ClampNTSC()
        {
            return ilClampNTSC();
        }

        // ILAPI void		ILAPIENTRY ilClearColour(ILclampf Red, ILclampf Green, ILclampf Blue, ILclampf Alpha);
        public static void ClearColour (ILclampf Red, ILclampf Green, ILclampf Blue, ILclampf Alpha)
        {
            ilClearColour(Red, Green, Blue, Alpha);
        }

        // ILAPI ILboolean ILAPIENTRY ilClearImage(void);
        public static ILboolean ClearImage()
        {
            return ilClearImage();
        }

        // ILAPI ILuint    ILAPIENTRY ilCloneCurImage(void);
        public static ILuint CloneCurImage()
        {
            return ilCloneCurImage();
        }

        // ILAPI ILubyte*	ILAPIENTRY ilCompressDXT(ILubyte *Data, ILuint Width, ILuint Height, ILuint Depth, ILenum DXTCFormat, ILuint *DXTCSize);
        public static IntPtr CompressDXT(IntPtr Data, ILuint Width, ILuint Height, ILuint Depth, ILenum DXTCFormat, out ILuint DXTCSize)
        {
            return ilCompressDXT(Data, Width, Height, Depth, DXTCFormat, out DXTCSize);
        }

        // ILAPI ILboolean ILAPIENTRY ilCompressFunc(ILenum Mode);
        public static ILboolean CompressFunc(ILenum Mode)
        {
            return ilCompressFunc(Mode);
        }

        // ILAPI ILboolean ILAPIENTRY ilConvertImage(ILenum DestFormat, ILenum DestType);
        public static ILboolean ConvertImage(ILenum DestFormat, ILenum DestType)
        {
            return ilConvertImage(DestFormat, DestType);
        }

        // ILAPI ILboolean ILAPIENTRY ilConvertPal(ILenum DestFormat);
        public static ILboolean ConvertPal(ILenum DestFormat)
        {
            return ilConvertPal(DestFormat);
        }

        // ILAPI ILboolean ILAPIENTRY ilCopyImage(ILuint Src);
        public static ILboolean CopyImage(ILuint Src)
        {
            return ilCopyImage(Src);
        }

        // ILAPI ILuint    ILAPIENTRY ilCopyPixels(ILuint XOff, ILuint YOff, ILuint ZOff, ILuint Width, ILuint Height, ILuint Depth, ILenum Format, ILenum Type, void *Data);
        public static ILuint CopyPixels(ILuint XOff, ILuint YOff, ILuint ZOff, ILuint Width, ILuint Height, ILuint Depth, ILenum Format, ILenum Type, IntPtr Data)
        {
            return ilCopyPixels(XOff, YOff, ZOff, Width, Height, Depth, Format, Type, Data);
        }

        // ILAPI ILuint    ILAPIENTRY ilCreateSubImage(ILenum Type, ILuint Num);
        public static ILuint CreateSubImage(ILenum Type, ILuint Num)
        {
            return ilCreateSubImage(Type, Num);
        }

        // ILAPI ILboolean ILAPIENTRY ilDefaultImage(void);
        public static ILboolean DefaultImage()
        {
            return ilDefaultImage();
        }

        // ILAPI void		ILAPIENTRY ilDeleteImage(const ILuint Num);
        public static void DeleteImage(ILuint Num)
        {
            ilDeleteImage(Num);
        }

        // ILAPI void      ILAPIENTRY ilDeleteImages(ILsizei Num, const ILuint *Images);
        public unsafe static void DeleteImages(ILsizei Num, ILuint[] Images)
        {
            fixed(ILuint* ptr_Images = Images)
            {
                ilDeleteImages(Num, ptr_Images);
            }
        }

        // ILAPI ILenum	ILAPIENTRY ilDetermineType(ILconst_string FileName);
        public static ILenum DetermineType(ILconst_string FileName)
        {
            return ilDetermineType(FileName);
        }

        // ILAPI ILenum	ILAPIENTRY ilDetermineTypeF(ILHANDLE File);
        public static ILenum DetermineTypeF(ILhandle File)
        {
            return ilDetermineTypeF(File);
        }

        // ILAPI ILenum	ILAPIENTRY ilDetermineTypeL(const void *Lump, ILuint Size);
        public static ILenum DetermineTypeL(IntPtr Lump, ILuint Size)
        {
            return ilDetermineTypeL(Lump, Size);
        }

        // ILAPI ILboolean ILAPIENTRY ilDisable(ILenum Mode);
        public static ILboolean Disable(ILenum Mode)
        {
            return ilDisable(Mode);
        }

        // ILAPI ILboolean ILAPIENTRY ilDxtcDataToImage(void);
        public static ILboolean DxtcDataToImage()
        {
            return ilDxtcDataToImage();
        }

        // ILAPI ILboolean ILAPIENTRY ilDxtcDataToSurface(void);
        public static ILboolean DxtcDataToSurface()
        {
            return ilDxtcDataToSurface();
        }

        // ILAPI ILboolean ILAPIENTRY ilEnable(ILenum Mode);
        public static ILboolean Enable(ILenum Mode)
        {
            return ilEnable(Mode);
        }

        // ILAPI void		ILAPIENTRY ilFlipSurfaceDxtcData(void);
        public static void FlipSurfaceDxtcData()
        {
            ilFlipSurfaceDxtcData();
        }

        // ILAPI ILboolean ILAPIENTRY ilFormatFunc(ILenum Mode);
        public static ILboolean FormatFunc(ILenum Mode)
        {
            return ilFormatFunc(Mode);
        }

        // ILAPI void	    ILAPIENTRY ilGenImages(ILsizei Num, ILuint *Images);
        public unsafe static void GenImages(ILsizei Num, ILuint[] Images)
        {
            fixed(ILuint* ptr_Images = Images)
            {
                ilGenImages(Num, ptr_Images);
            }
        }

        // ILAPI ILuint	ILAPIENTRY ilGenImage(void);
        public static ILuint GenImage()
        {
            return ilGenImage();
        }

        // ILAPI ILubyte*  ILAPIENTRY ilGetAlpha(ILenum Type);
        public static IntPtr GetAlpha (ILenum Type)
        {
            return ilGetAlpha(Type);
        }

        // ILAPI ILboolean ILAPIENTRY ilGetBoolean(ILenum Mode);
        public static ILboolean GetBoolean(ILenum Mode)
        {
            return ilGetBoolean(Mode);
        }

        // ILAPI void      ILAPIENTRY ilGetBooleanv(ILenum Mode, ILboolean *Param);
        public unsafe static void GetBooleanv(ILenum Mode, ILboolean[] Param)
        {
            fixed(ILboolean* ptr_Param = Param)
            {
                ilGetBooleanv(Mode, ptr_Param);
            }
        }

        // ILAPI ILubyte*  ILAPIENTRY ilGetData(void);
        public static IntPtr GetData()
        {
            return ilGetData();
        }

        // ILAPI ILuint    ILAPIENTRY ilGetDXTCData(void *Buffer, ILuint BufferSize, ILenum DXTCFormat);
        public static ILuint GetDXTCData(IntPtr Buffer, ILuint BufferSize, ILenum DXTCFormat)
        {
            return ilGetDXTCData(Buffer, BufferSize, DXTCFormat);
        }

        // ILAPI ILenum    ILAPIENTRY ilGetError(void);
        public static ILenum GetError()
        {
            return ilGetError();
        }

        // ILAPI ILint     ILAPIENTRY ilGetInteger(ILenum Mode);
        public static ILint GetInteger(ILenum Mode)
        {
            return ilGetInteger(Mode);
        }

        // ILAPI void      ILAPIENTRY ilGetIntegerv(ILenum Mode, ILint *Param);
        public unsafe static void GetIntegerv(ILenum Mode, ILint[] Param)
        {
            fixed(ILint* ptr_Param = Param)
            {
                ilGetIntegerv(Mode, ptr_Param);
            }
        }

        // ILAPI ILuint    ILAPIENTRY ilGetLumpPos(void);
        public static ILuint GetLumpPos()
        {
            return ilGetLumpPos();
        }

        // ILAPI ILubyte*  ILAPIENTRY ilGetPalette(void);
        public static IntPtr GetPalette()
        {
            return ilGetPalette();
        }

        // ILAPI ILconst_string  ILAPIENTRY ilGetString(ILenum StringName);
        public unsafe static string GetString(ILenum StringName)
        {
            return new string((sbyte*)ilGetString(StringName));
        }

        // ILAPI void      ILAPIENTRY ilHint(ILenum Target, ILenum Mode);
        public static void Hint(ILenum Target, ILenum Mode)
        {
            ilHint(Target, Mode);
        }

        // ILAPI ILboolean	ILAPIENTRY ilInvertSurfaceDxtcDataAlpha(void);
        public static ILboolean InvertSurfaceDxtcDataAlpha()
        {
            return ilInvertSurfaceDxtcDataAlpha();
        }

        // ILAPI void      ILAPIENTRY ilInit(void);
        public static void Init()
        {
            ilInit();
        }

        // ILAPI ILboolean ILAPIENTRY ilImageToDxtcData(ILenum Format);
        public static ILboolean ImageToDxtcData(ILenum Format)
        {
            return ilImageToDxtcData(Format);
        }

        // ILAPI ILboolean ILAPIENTRY ilIsDisabled(ILenum Mode);
        public static ILboolean IsDisabled(ILenum Mode)
        {
            return ilIsDisabled(Mode);
        }

        // ILAPI ILboolean ILAPIENTRY ilIsEnabled(ILenum Mode);
        public static ILboolean IsEnabled(ILenum Mode)
        {
            return ilIsEnabled(Mode);
        }

        // ILAPI ILboolean ILAPIENTRY ilIsImage(ILuint Image);
        public static ILboolean IsImage(ILuint Image)
        {
            return ilIsImage(Image);
        }

        // ILAPI ILboolean ILAPIENTRY ilIsValid(ILenum Type, ILconst_string FileName);
        public static ILboolean IsValid(ILenum Type, ILconst_string FileName)
        {
            return ilIsValid(Type, FileName);
        }

        // ILAPI ILboolean ILAPIENTRY ilIsValidF(ILenum Type, ILHANDLE File);
        public static ILboolean IsValidF(ILenum Type, ILhandle File)
        {
            return ilIsValidF(Type, File);
        }

        // ILAPI ILboolean ILAPIENTRY ilIsValidL(ILenum Type, void *Lump, ILuint Size);
        public static ILboolean IsValidL(ILenum Type, IntPtr Lump, ILuint Size)
        {
            return ilIsValidL(Type, Lump, Size);
        }

        // ILAPI void      ILAPIENTRY ilKeyColour(ILclampf Red, ILclampf Green, ILclampf Blue, ILclampf Alpha);
        public static void KeyColour(ILclampf Red, ILclampf Green, ILclampf Blue, ILclampf Alpha)
        {
            ilKeyColour(Red, Green, Blue, Alpha);
        }

        // ILAPI ILboolean ILAPIENTRY ilLoad(ILenum Type, ILconst_string FileName);
        public static ILboolean Load(ILenum Type, ILconst_string FileName)
        {
            return ilLoad(Type, FileName);
        }

        // ILAPI ILboolean ILAPIENTRY ilLoadF(ILenum Type, ILHANDLE File);
        public static ILboolean LoadF(ILenum Type, ILhandle File)
        {
            return ilLoadF(Type, File);
        }

        // ILAPI ILboolean ILAPIENTRY ilLoadImage(ILconst_string FileName);
        public static ILboolean LoadImage(ILconst_string FileName)
        {
            return ilLoadImage(FileName);
        }

        // ILAPI ILboolean ILAPIENTRY ilLoadL(ILenum Type, const void *Lump, ILuint Size);
        public static ILboolean LoadL(ILenum Type, IntPtr Lump, ILuint Size)
        {
            return ilLoadL(Type, Lump, Size);
        }

        // ILAPI ILboolean ILAPIENTRY ilLoadPal(ILconst_string FileName);
        public static ILboolean LoadPal(ILconst_string FileName)
        {
            return ilLoadPal(FileName);
        }

        // ILAPI void      ILAPIENTRY ilModAlpha(ILdouble AlphaValue);
        public static void ModAlpha(ILdouble AlphaValue)
        {
            ilModAlpha(AlphaValue);
        }

        // ILAPI ILboolean ILAPIENTRY ilOriginFunc(ILenum Mode);
        public static ILboolean OriginFunc(ILenum Mode)
        {
            return ilOriginFunc(Mode);
        }

        // ILAPI ILboolean ILAPIENTRY ilOverlayImage(ILuint Source, ILint XCoord, ILint YCoord, ILint ZCoord);
        public static ILboolean OverlayImage(ILuint Source, ILint XCoord, ILint YCoord, ILint ZCoord)
        {
            return ilOverlayImage(Source, XCoord, YCoord, ZCoord);
        }

        // ILAPI void      ILAPIENTRY ilPopAttrib(void);
        public static void PopAttrib()
        {
            ilPopAttrib();
        }

        // ILAPI void      ILAPIENTRY ilPushAttrib(ILuint Bits);
        public static void PushAttrib(ILuint Bits)
        {
            ilPushAttrib(Bits);
        }

        // ILAPI void      ILAPIENTRY ilRegisterFormat(ILenum Format);
        public static void RegisterFormat(ILenum Format)
        {
            ilRegisterFormat(Format);
        }

        // ILAPI ILboolean ILAPIENTRY ilRegisterLoad(ILconst_string Ext, IL_LOADPROC Load);
        public static ILboolean RegisterLoad(ILconst_string Ext, TCALLBACKIL_LOADPROC Load)
        {
            return ilRegisterLoad(Ext, Load);
        }

        // ILAPI ILboolean ILAPIENTRY ilRegisterMipNum(ILuint Num);
        public static ILboolean RegisterMipNum (ILuint Num)
        {
            return ilRegisterMipNum(Num);
        }

        // ILAPI ILboolean ILAPIENTRY ilRegisterNumFaces(ILuint Num);
        public static ILboolean RegisterNumFaces(ILuint Num)
        {
            return ilRegisterNumFaces(Num);
        }

        // ILAPI ILboolean ILAPIENTRY ilRegisterNumImages(ILuint Num);
        public static ILboolean RegisterNumImages(ILuint Num)
        {
            return ilRegisterNumImages(Num);
        }

        // ILAPI void      ILAPIENTRY ilRegisterOrigin(ILenum Origin);
        public static void RegisterOrigin(ILenum Origin)
        {
            ilRegisterOrigin(Origin);
        }

        // ILAPI void      ILAPIENTRY ilRegisterPal(void *Pal, ILuint Size, ILenum Type);
        public static void RegisterPal(IntPtr Pal, ILuint Size, ILenum Type)
        {
            ilRegisterPal(Pal, Size, Type);
        }

        // ILAPI ILboolean ILAPIENTRY ilRegisterSave(ILconst_string Ext, IL_SAVEPROC Save);
        public static ILboolean RegisterSave(ILconst_string Ext, TCALLBACKIL_SAVEPROC Save)
        {
            return ilRegisterSave(Ext, Save);
        }

        // ILAPI void      ILAPIENTRY ilRegisterType(ILenum Type);
        public static void RegisterType(ILenum Type)
        {
            ilRegisterType(Type);
        }

        // ILAPI ILboolean ILAPIENTRY ilRemoveLoad(ILconst_string Ext);
        public static ILboolean RemoveLoad(ILconst_string Ext)
        {
            return ilRemoveLoad(Ext);
        }

        // ILAPI ILboolean ILAPIENTRY ilRemoveSave(ILconst_string Ext);
        public static ILboolean RemoveSave(ILconst_string Ext)
        {
            return ilRemoveSave(Ext);
        }

        // ILAPI void      ILAPIENTRY ilResetMemory(void); // Deprecated
        public static void ResetMemory()
        {
            ilResetMemory();
        }

        // ILAPI void      ILAPIENTRY ilResetRead(void);
        public static void ResetRead()
        {
            ilResetRead();
        }

        // ILAPI void      ILAPIENTRY ilResetWrite(void);
        public static void ResetWrite()
        {
            ilResetWrite();
        }

        // ILAPI ILboolean ILAPIENTRY ilSave(ILenum Type, ILconst_string FileName);
        public static ILboolean Save(ILenum Type, ILconst_string FileName)
        {
            return ilSave(Type, FileName);
        }

        // ILAPI ILuint    ILAPIENTRY ilSaveF(ILenum Type, ILHANDLE File);
        public static ILuint SaveF(ILenum Type, ILhandle File)
        {
            return ilSaveF(Type, File);
        }

        // ILAPI ILboolean ILAPIENTRY ilSaveImage(ILconst_string FileName);
        public static ILboolean SaveImage(ILconst_string FileName)
        {
            return ilSaveImage(FileName);
        }

        // ILAPI ILuint    ILAPIENTRY ilSaveL(ILenum Type, void *Lump, ILuint Size);
        public static ILuint SaveL(ILenum Type, IntPtr Lump, ILuint Size)
        {
            return ilSaveL(Type, Lump, Size);
        }

        // ILAPI ILboolean ILAPIENTRY ilSavePal(ILconst_string FileName);
        public static ILboolean SavePal(ILconst_string FileName)
        {
            return ilSavePal(FileName);
        }

        // ILAPI ILboolean ILAPIENTRY ilSetAlpha(ILdouble AlphaValue);
        public static ILboolean SetAlpha(ILdouble AlphaValue)
        {
            return ilSetAlpha(AlphaValue);
        }

        // ILAPI ILboolean ILAPIENTRY ilSetData(void *Data);
        public static ILboolean SetData(IntPtr Data)
        {
            return ilSetData(Data);
        }

        // ILAPI ILboolean ILAPIENTRY ilSetDuration(ILuint Duration);
        public static ILboolean SetDuration(ILuint Duration)
        {
            return ilSetDuration(Duration);
        }

        // ILAPI void      ILAPIENTRY ilSetInteger(ILenum Mode, ILint Param);
        public static void SetInteger(ILenum Mode, ILint Param)
        {
            ilSetInteger(Mode, Param);
        }

        // ILAPI void      ILAPIENTRY ilSetMemory(mAlloc, mFree);
        public static void SetMemory(TCALLBACKmAlloc mAlloc, TCALLBACKmFree mFree)
        {
            ilSetMemory(mAlloc, mFree);
        }

        // ILAPI void      ILAPIENTRY ilSetPixels(ILint XOff, ILint YOff, ILint ZOff, ILuint Width, ILuint Height, ILuint Depth, ILenum Format, ILenum Type, void *Data);
        public static void SetPixels(ILint XOff, ILint YOff, ILint ZOff, ILuint Width, ILuint Height, ILuint Depth, ILenum Format, ILenum Type, IntPtr Data)
        {
            ilSetPixels(XOff, YOff, ZOff, Width, Height, Depth, Format, Type, Data);
        }

        // ILAPI void      ILAPIENTRY ilSetRead(fOpenRProc Open, fCloseRProc Close, fEofProc Eof , fGetcProc Getc, fReadProc Read, fSeekRProc Seek, fTellRProc Tell);
        public static void SetRead(TCALLBACKfOpenRProc Open, TCALLBACKfCloseRProc Close, TCALLBACKfEofProc Eof, TCALLBACKfGetcProc Getc, TCALLBACKfReadProc Read, TCALLBACKfSeekRProc Seek, TCALLBACKfTellRProc Tell)
        {
            ilSetRead(Open, Close, Eof, Getc, Read, Seek, Tell);
        }

        // ILAPI void      ILAPIENTRY ilSetString(ILenum Mode, const char *String);
        public static void SetString(ILenum Mode, ILconst_string String)
        {
            ilSetString(Mode, String);
        }

        // ILAPI void      ILAPIENTRY ilSetWrite(fOpenWProc Open, fCloseWProc Close, fPutcProc Putc, fSeekWProc Seek, fTellWProc Tell, fWriteProc Write);
        public static void SetWrite (TCALLBACKfOpenWProc Open, TCALLBACKfCloseWProc Close, TCALLBACKfPutcProc Putc, TCALLBACKfSeekWProc Seek, TCALLBACKfTellWProc Tell, TCALLBACKfWriteProc Write)
        {
            ilSetWrite(Open, Close, Putc, Seek, Tell, Write);
        }

        // ILAPI void      ILAPIENTRY ilShutDown(void);
        public static void ShutDown()
        {
            ilShutDown();
        }

        // ILAPI ILboolean ILAPIENTRY ilSurfaceToDxtcData(ILenum Format);
        public static ILboolean SurfaceToDxtcData(ILenum Format)
        {
            return ilSurfaceToDxtcData(Format);
        }

        // ILAPI ILboolean ILAPIENTRY ilTexImage(ILuint Width, ILuint Height, ILuint Depth, ILubyte NumChannels, ILenum Format, ILenum Type, void *Data);
        public static ILboolean TexImage(ILuint Width, ILuint Height, ILuint Depth, ILubyte NumChannels, ILenum Format, ILenum Type, IntPtr Data)
        {
            return ilTexImage(Width, Height, Depth, NumChannels, Format, Type, Data);
        }

        // ILAPI ILboolean ILAPIENTRY ilTexImageDxtc(ILint w, ILint h, ILint d, ILenum DxtFormat, const ILubyte* data);
        public static ILboolean TexImageDxtc(ILint w, ILint h, ILint d, ILenum DxtFormat, IntPtr Data)
        {
            return ilTexImageDxtc(w, h, d, DxtFormat, Data);
        }

        // ILAPI ILenum    ILAPIENTRY ilTypeFromExt(ILconst_string FileName);
        public static ILenum TypeFromExt(ILconst_string FileName)
        {
            return ilTypeFromExt(FileName);
        }

        // ILAPI ILboolean ILAPIENTRY ilTypeFunc(ILenum Mode);
        public static ILboolean TypeFunc(ILenum Mode)
        {
            return ilTypeFunc(Mode);
        }

        // ILAPI ILboolean ILAPIENTRY ilLoadData(ILconst_string FileName, ILuint Width, ILuint Height, ILuint Depth, ILubyte Bpp);
        public static ILboolean LoadData(ILconst_string FileName, ILuint Width, ILuint Height, ILuint Depth, ILubyte Bpp)
        {
            return ilLoadData(FileName, Width, Height, Depth, Bpp);
        }

        // ILAPI ILboolean ILAPIENTRY ilLoadDataF(ILHANDLE File, ILuint Width, ILuint Height, ILuint Depth, ILubyte Bpp);
        public static ILboolean LoadDataF(ILhandle File, ILuint Width, ILuint Height, ILuint Depth, ILubyte Bpp)
        {
            return ilLoadDataF(File, Width, Height, Depth, Bpp);
        }

        // ILAPI ILboolean ILAPIENTRY ilLoadDataL(void *Lump, ILuint Size, ILuint Width, ILuint Height, ILuint Depth, ILubyte Bpp);
        public static ILboolean LoadDataL(IntPtr Lump, ILuint Size, ILuint Width, ILuint Height, ILuint Depth, ILubyte Bpp)
        {
            return ilLoadDataL(Lump, Size, Width, Height, Depth, Bpp);
        }

        // ILAPI ILboolean ILAPIENTRY ilSaveData(ILconst_string FileName);
        public static ILboolean SaveData(ILconst_string FileName)
        {
            return ilSaveData(FileName);
        }
    }
}
