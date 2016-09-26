// ----------------------------------------------------------------------------
// FILE		: wgl.extwrappers.cs
// VERSION	: 1.1.0
// COMMENT	: "Windows" specific OpenGL Extension wrappers for low level functions
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2016
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
        // WGL EXTENSION WRAPPERS
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_3DFX_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_3DFX_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_3DFX_multisample (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_3DL_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_3DL_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_3DL_stereo_control
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglSetStereoEmitterState3DL (HDC hDC, UINT uState);
        public static bool SetStereoEmitterState3DL(IntPtr hDC, uint uState)
        {
            if (wglSetStereoEmitterState3DL != null)
            {
                return wglSetStereoEmitterState3DL(hDC, uState);
            }
            else
            {
                return false;
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_AMD_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_AMD_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_AMD_gpu_association
        ///////////////////////////////////////////////////////////////////////
        // UINT  WINAPI wglGetGPUIDsAMD (UINT maxCount, UINT *ids);
        public unsafe static uint GetGPUIDsAMD(uint maxCount, uint[] ids)
        {
            if (wglGetGPUIDsAMD != null)
            {
                fixed (uint* ptr_ids = ids)
                {
                    return wglGetGPUIDsAMD(maxCount, ptr_ids);
                }
            }
            else
            {
                return 0;
            }
        }

        // INT   WINAPI wglGetGPUInfoAMD (UINT id, int property, GLenum dataType, UINT size, void *data);
        public unsafe static int GetGPUInfoAMD(uint id, int property, GLenum dataType, uint size, IntPtr data)
        {
            if (wglGetGPUInfoAMD != null)
            {
                return wglGetGPUInfoAMD(id, property, dataType, size, data.ToPointer());
            }
            else
            {
                return 0;
            }
        }

        // UINT  WINAPI wglGetContextGPUIDAMD (HGLRC hglrc);
        public static uint GetContextGPUIDAMD(IntPtr hglrc)
        {
            if (wglGetContextGPUIDAMD != null)
            {
                return wglGetContextGPUIDAMD(hglrc);
            }
            else
            {
                return 0;
            }
        }

        // HGLRC WINAPI wglCreateAssociatedContextAMD (UINT id);
        public static IntPtr CreateAssociatedContextAMD(uint id)
        {
            if (wglCreateAssociatedContextAMD != null)
            {
                return wglCreateAssociatedContextAMD(id);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // HGLRC WINAPI wglCreateAssociatedContextAttribsAMD (UINT id, HGLRC hShareContext, const int *attribList);
        public unsafe static IntPtr CreateAssociatedContextAttribsAMD(uint id, IntPtr hShareContext, int[] attribList)
        {
            if (wglCreateAssociatedContextAttribsAMD != null)
            {
                fixed (int* ptr_attribList = attribList)
                {
                    return wglCreateAssociatedContextAttribsAMD(id, hShareContext, ptr_attribList);
                }
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // BOOL  WINAPI wglDeleteAssociatedContextAMD (HGLRC hglrc);
        public static bool DeleteAssociatedContextAMD(IntPtr hglrc)
        {
            if (wglDeleteAssociatedContextAMD != null)
            {
                return wglDeleteAssociatedContextAMD(hglrc);
            }
            else
            {
                return false;
            }
        }

        // BOOL  WINAPI wglMakeAssociatedContextCurrentAMD (HGLRC hglrc);
        public static bool MakeAssociatedContextCurrentAMD(IntPtr hglrc)
        {
            if (wglMakeAssociatedContextCurrentAMD != null)
            {
                return wglMakeAssociatedContextCurrentAMD(hglrc);
            }
            else
            {
                return false;
            }
        }

        // HGLRC WINAPI wglGetCurrentAssociatedContextAMD (void);
        public static IntPtr GetCurrentAssociatedContextAMD()
        {
            if (wglGetCurrentAssociatedContextAMD != null)
            {
                return wglGetCurrentAssociatedContextAMD();
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // VOID  WINAPI wglBlitContextFramebufferAMD (HGLRC dstCtx, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);
        public static void BlitContextFramebufferAMD(IntPtr dstCtx, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)
        {
            if (wglBlitContextFramebufferAMD != null)
            {
                wglBlitContextFramebufferAMD(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_ARB_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_buffer_region
        ///////////////////////////////////////////////////////////////////////
        // HANDLE WINAPI wglCreateBufferRegionARB (HDC hDC, int iLayerPlane, UINT uType);
        public static IntPtr CreateBufferRegionARB(IntPtr hDC, int iLayerPlane, uint uType)
        {
            if (wglCreateBufferRegionARB != null)
            {
                return wglCreateBufferRegionARB(hDC, iLayerPlane, uType);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // VOID WINAPI wglDeleteBufferRegionARB (HANDLE hRegion);
        public static void DeleteBufferRegionARB(IntPtr hRegion)
        {
            if (wglDeleteBufferRegionARB != null)
            {
                wglDeleteBufferRegionARB(hRegion);
            }
        }

        // BOOL WINAPI wglSaveBufferRegionARB (HANDLE hRegion, int x, int y, int width, int height);
        public static bool SaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height)
        {
            if (wglSaveBufferRegionARB != null)
            {
                return wglSaveBufferRegionARB(hRegion, x, y, width, height);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglRestoreBufferRegionARB (HANDLE hRegion, int x, int y, int width, int height, int xSrc, int ySrc);
        public static bool RestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc)
        {
            if (wglRestoreBufferRegionARB != null)
            {
                return wglRestoreBufferRegionARB(hRegion, x, y, width, height, xSrc, ySrc);
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_context_flush_control (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_create_context
        ///////////////////////////////////////////////////////////////////////
        // HGLRC WINAPI wglCreateContextAttribsARB (HDC hDC, HGLRC hShareContext, const int *attribList);
        public unsafe static IntPtr CreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int[] attribList)
        {
            if (wglCreateContextAttribsARB != null)
            {
                fixed (int* ptr_attribList = attribList)
                {
                    return wglCreateContextAttribsARB(hDC, hShareContext, ptr_attribList);
                }
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_create_context_profile (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_create_context_robustness (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_extensions_string
        ///////////////////////////////////////////////////////////////////////
        //const char *WINAPI wglGetExtensionsStringARB (HDC hdc);   
        public unsafe static string GetExtensionsStringARB(IntPtr hdc)
        {
            if (wglGetExtensionsStringARB != null)
            {
                return new string((sbyte*)wglGetExtensionsStringARB(hdc));
            }
            else
            {
                return null;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_framebuffer_sRGB (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_make_current_read
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglMakeContextCurrentARB (HDC hDrawDC, HDC hReadDC, HGLRC hglrc);
        public static bool MakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
        {
            if (wglMakeContextCurrentARB != null)
            {
                return wglMakeContextCurrentARB(hDrawDC, hReadDC, hglrc);
            }
            else
            {
                return false;
            }
        }

        // HDC WINAPI wglGetCurrentReadDCARB (void);
        public static IntPtr GetCurrentReadDCARB()
        {
            if (wglGetCurrentReadDCARB != null)
            {
                return wglGetCurrentReadDCARB();
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_multisample (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_pbuffer
        ///////////////////////////////////////////////////////////////////////
        // HPBUFFERARB WINAPI wglCreatePbufferARB (HDC hDC, int iPixelFormat, int iWidth, int iHeight, const int *piAttribList);
        public unsafe static IntPtr CreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
        {
            if (wglCreatePbufferARB != null)
            {
                fixed (int* ptr_piAttribList = piAttribList)
                {
                    return wglCreatePbufferARB(hDC, iPixelFormat, iWidth, iHeight, ptr_piAttribList);
                }
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // HDC WINAPI wglGetPbufferDCARB (HPBUFFERARB hPbuffer);
        public static IntPtr GetPbufferDCARB(IntPtr hPbuffer)
        {
            if (wglGetPbufferDCARB != null)
            {
                return wglGetPbufferDCARB(hPbuffer);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // int WINAPI wglReleasePbufferDCARB (HPBUFFERARB hPbuffer, HDC hDC);
        public static int ReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC)
        {
            if (wglReleasePbufferDCARB != null)
            {
                return wglReleasePbufferDCARB(hPbuffer, hDC);
            }
            else
            {
                return 0;
            }
        }

        // BOOL WINAPI wglDestroyPbufferARB (HPBUFFERARB hPbuffer);
        public static bool DestroyPbufferARB(IntPtr hPbuffer)
        {
            if (wglDestroyPbufferARB != null)
            {
                return wglDestroyPbufferARB(hPbuffer);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglQueryPbufferARB (HPBUFFERARB hPbuffer, int iAttribute, int *piValue);
        public unsafe static bool QueryPbufferARB(IntPtr hPbuffer, int iAttribute, int[] piValue)
        {
            if (wglQueryPbufferARB != null)
            {
                fixed (int* ptr_piValue = piValue)
                {
                    return wglQueryPbufferARB(hPbuffer, iAttribute, ptr_piValue);
                }
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_pixel_format
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglGetPixelFormatAttribivARB (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, const int *piAttributes, int *piValues);
        public unsafe static bool GetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int[] piAttributes, int[] piValues)
        {
            if (wglGetPixelFormatAttribivARB != null)
            {
                fixed (int* ptr_piAttributes = piAttributes)
                {
                    fixed (int* ptr_piValues = piValues)
                    {
                        return wglGetPixelFormatAttribivARB(hdc, iPixelFormat, iLayerPlane, nAttributes, ptr_piAttributes, ptr_piValues);
                    }
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglGetPixelFormatAttribfvARB (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, const int *piAttributes, FLOAT *pfValues);
        public unsafe static bool GetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int[] piAttributes, float[] pfValues)
        {
            if (wglGetPixelFormatAttribfvARB != null)
            {
                fixed (int* ptr_piAttributes = piAttributes)
                {
                    fixed (float* ptr_pfValues = pfValues)
                    {
                        return wglGetPixelFormatAttribfvARB(hdc, iPixelFormat, iLayerPlane, nAttributes, ptr_piAttributes, ptr_pfValues);
                    }
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglChoosePixelFormatARB (HDC hdc, const int *piAttribIList, const FLOAT *pfAttribFList, UINT nMaxFormats, int *piFormats, UINT *nNumFormats);
        public unsafe static bool ChoosePixelFormatARB(IntPtr hdc, int[] piAttribIList, float[] pfAttribFList, uint nMaxFormats, int[] piFormats, uint[] nNumFormats)
        {
            if (wglChoosePixelFormatARB != null)
            {
                fixed (int* ptr_piAttribIList = piAttribIList)
                {
                    fixed (float* ptr_pfAttribFList = pfAttribFList)
                    {
                        fixed (int* ptr_piFormats = piFormats)
                        {
                            fixed (uint* ptr_nNumFormats = nNumFormats)
                            {
                                return wglChoosePixelFormatARB(hdc, ptr_piAttribIList, ptr_pfAttribFList, nMaxFormats, ptr_piFormats, ptr_nNumFormats);
                            }
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_pixel_format_float (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_render_texture
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglBindTexImageARB (HPBUFFERARB hPbuffer, int iBuffer);
        public static bool BindTexImageARB(IntPtr hPbuffer, int iBuffer)
        {
            if (wglBindTexImageARB != null)
            {
                return wglBindTexImageARB(hPbuffer, iBuffer);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglReleaseTexImageARB (HPBUFFERARB hPbuffer, int iBuffer);
        public static bool ReleaseTexImageARB(IntPtr hPbuffer, int iBuffer)
        {
            if (wglReleaseTexImageARB != null)
            {
                return wglReleaseTexImageARB(hPbuffer, iBuffer);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglSetPbufferAttribARB (HPBUFFERARB hPbuffer, const int *piAttribList);
        public unsafe static bool SetPbufferAttribARB(IntPtr hPbuffer, int[] piAttribList)
        {
            if (wglSetPbufferAttribARB != null)
            {
                fixed (int* ptr_piAttribList = piAttribList)
                {
                    return wglSetPbufferAttribARB(hPbuffer, ptr_piAttribList);
                }
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_robustness_application_isolation (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_robustness_share_group_isolation (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_ATI_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_ATI_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_ATI_pixel_format_float (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_EXT_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_create_context_es_profile (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_create_context_es2_profile (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_depth_float (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_display_color_table
        ///////////////////////////////////////////////////////////////////////
        // GLboolean WINAPI wglCreateDisplayColorTableEXT (GLushort id);
        public static GLboolean CreateDisplayColorTableEXT(GLushort id)
        {
            if (wglCreateDisplayColorTableEXT != null)
            {
                return wglCreateDisplayColorTableEXT(id);
            }
            else
            {
                return false;
            }
        }

        // GLboolean WINAPI wglLoadDisplayColorTableEXT (const GLushort *table, GLuint length);
        public unsafe static GLboolean LoadDisplayColorTableEXT (GLushort[] table, GLuint length)
        {
            if (wglLoadDisplayColorTableEXT != null)
            {
                fixed (GLushort* ptr_table = table)
                {
                    return wglLoadDisplayColorTableEXT(ptr_table, length);
                }
            }
            else
            {
                return false;
            }
        }

        // GLboolean WINAPI wglBindDisplayColorTableEXT (GLushort id);
        public static GLboolean BindDisplayColorTableEXT (GLushort id)
        {
            if (wglBindDisplayColorTableEXT != null)
            {
                return wglBindDisplayColorTableEXT(id);
            }
            else
            {
                return false;
            }
        }

        // VOID WINAPI wglDestroyDisplayColorTableEXT (GLushort id);
        public static void DestroyDisplayColorTableEXT (GLushort id)
        {
            if (wglDestroyDisplayColorTableEXT != null)
            {
                wglDestroyDisplayColorTableEXT(id);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_extensions_string
        ///////////////////////////////////////////////////////////////////////
        // const char *WINAPI wglGetExtensionsStringEXT (void);
        public unsafe static string GetExtensionsStringEXT()
        {
            return new string((sbyte*)wglGetExtensionsStringEXT());
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_framebuffer_sRGB (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_make_current_read
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglMakeContextCurrentEXT (HDC hDrawDC, HDC hReadDC, HGLRC hglrc);
        public static bool MakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
        {
            if (wglMakeContextCurrentEXT != null)
            {
                return wglMakeContextCurrentEXT(hDrawDC, hReadDC, hglrc);
            }
            else
            {
                return false;
            }
        }

        // HDC WINAPI wglGetCurrentReadDCEXT (void);
        public static IntPtr GetCurrentReadDCEXT()
        {
            if (wglGetCurrentReadDCEXT != null)
            {
                return wglGetCurrentReadDCEXT();
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_multisample (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_pbuffer
        ///////////////////////////////////////////////////////////////////////
        // HPBUFFEREXT WINAPI wglCreatePbufferEXT (HDC hDC, int iPixelFormat, int iWidth, int iHeight, const int *piAttribList);
        public unsafe static IntPtr CreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
        {
            if (wglCreatePbufferEXT != null)
            {
                fixed (int* ptr_piAttribList = piAttribList)
                {
                    return wglCreatePbufferEXT(hDC, iPixelFormat, iWidth, iHeight, ptr_piAttribList);
                }
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // HDC WINAPI wglGetPbufferDCEXT (HPBUFFEREXT hPbuffer);
        public static IntPtr GetPbufferDCEXT(IntPtr hPbuffer)
        {
            if (wglGetPbufferDCEXT != null)
            {
                return wglGetPbufferDCEXT(hPbuffer);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // int WINAPI wglReleasePbufferDCEXT (HPBUFFEREXT hPbuffer, HDC hDC);
        public static int ReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC)
        {
            if (wglReleasePbufferDCEXT != null)
            {
                return wglReleasePbufferDCEXT(hPbuffer, hDC);
            }
            else
            {
                return 0;
            }
        }

        // BOOL WINAPI wglDestroyPbufferEXT (HPBUFFEREXT hPbuffer);
        public static bool DestroyPbufferEXT(IntPtr hPbuffer)
        {
            if (wglDestroyPbufferEXT != null)
            {
                return wglDestroyPbufferEXT(hPbuffer);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglQueryPbufferEXT (HPBUFFEREXT hPbuffer, int iAttribute, int *piValue);
        public unsafe static bool QueryPbufferEXT(IntPtr hPbuffer, int iAttribute, int[] piValue)
        {
            if (wglQueryPbufferEXT != null)
            {
                fixed (int* ptr_piValue = piValue)
                {
                    return wglQueryPbufferEXT(hPbuffer, iAttribute, ptr_piValue);
                }
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_pixel_format
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglGetPixelFormatAttribivEXT (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, int *piAttributes, int *piValues);
        public unsafe static bool GetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int[] piAttributes, int[] piValues)
        {
            if (wglGetPixelFormatAttribivEXT != null)
            {
                fixed (int* ptr_piAttributes = piAttributes)
                {
                    fixed (int* ptr_piValues = piValues)
                    {
                        return wglGetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, ptr_piAttributes, ptr_piValues);
                    }
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglGetPixelFormatAttribfvEXT (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, int *piAttributes, FLOAT *pfValues);
        public unsafe static bool GetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int[] piAtrributes, float[] pfValues)
        {
            if (wglGetPixelFormatAttribfvEXT != null)
            {
                fixed (int* ptr_piAttributes = piAtrributes)
                {
                    fixed (float* ptr_pfValues = pfValues)
                    {
                        return wglGetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, ptr_piAttributes, ptr_pfValues);
                    }
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglChoosePixelFormatEXT (HDC hdc, const int *piAttribIList, const FLOAT *pfAttribFList, UINT nMaxFormats, int *piFormats, UINT *nNumFormats);
        public unsafe static bool ChoosePixelFormatEXT(IntPtr hdc, int[] piAttribIList, float[] pfAttribFList, uint nMaxFormats, int[] piFormats, uint[] nNumFormats)
        {
            if (wglChoosePixelFormatEXT != null)
            {
                fixed (int* ptr_piAttribIList = piAttribIList)
                {
                    fixed (float* ptr_pfAttribFList = pfAttribFList)
                    {
                        fixed (int* ptr_piFormats = piFormats)
                        {
                            fixed (uint* ptr_nNumFormats = nNumFormats)
                            {
                                return wglChoosePixelFormatEXT(hdc, ptr_piAttribIList, ptr_pfAttribFList, nMaxFormats, ptr_piFormats, ptr_nNumFormats);
                            }
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_pixel_format_packed_float (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_swap_control
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglSwapIntervalEXT (int interval);
        public static bool SwapIntervalEXT(int interval)
        {
            if (wglSwapIntervalEXT != null)
            {
                return wglSwapIntervalEXT(interval);
            }
            else
            {
                return false;
            }
        }

        // int WINAPI wglGetSwapIntervalEXT (void);
        public static int GetSwapIntervalEXT()
        {
            if (wglGetSwapIntervalEXT != null)
            {
                return wglGetSwapIntervalEXT();
            }
            else
            {
                return 0;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_swap_control_tear (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_I3D_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_digital_video_control
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglGetDigitalVideoParametersI3D (HDC hDC, int iAttribute, int *piValue);
        public unsafe static bool GetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int[] piValue)
        {
            if (wglGetDigitalVideoParametersI3D != null)
            {
                fixed (int* ptr_piValue = piValue)
                {
                    return wglGetDigitalVideoParametersI3D(hDC, iAttribute, ptr_piValue);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglSetDigitalVideoParametersI3D (HDC hDC, int iAttribute, const int *piValue);
        public unsafe static bool SetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int[] piValue)
        {
            if (wglSetDigitalVideoParametersI3D != null)
            {
                fixed (int* ptr_piValue = piValue)
                {
                    return wglSetDigitalVideoParametersI3D(hDC, iAttribute, ptr_piValue);
                }
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_gamma
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglGetGammaTableParametersI3D (HDC hDC, int iAttribute, int *piValue);
        public unsafe static bool GetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int[] piValue)
        {
            if (wglGetGammaTableParametersI3D != null)
            {
                fixed (int* ptr_piValue = piValue)
                {
                    return wglGetGammaTableParametersI3D(hDC, iAttribute, ptr_piValue);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglSetGammaTableParametersI3D (HDC hDC, int iAttribute, const int *piValue);
        public unsafe static bool SetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int[] piValue)
        {
            if (wglSetGammaTableParametersI3D != null)
            {
                fixed (int* ptr_piValue = piValue)
                {
                    return wglSetGammaTableParametersI3D(hDC, iAttribute, ptr_piValue);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglGetGammaTableI3D (HDC hDC, int iEntries, USHORT *puRed, USHORT *puGreen, USHORT *puBlue);
        public unsafe static bool GetGammaTableI3D(IntPtr hDC, int iEntries, ushort[] puRed, ushort[] puGreen, ushort[] puBlue)
        {
            if (wglGetGammaTableI3D != null)
            {
                fixed (ushort* ptr_puRed = puRed)
                {
                    fixed (ushort* ptr_puGreen = puGreen)
                    {
                        fixed (ushort* ptr_puBlue = puBlue)
                        {
                            return wglGetGammaTableI3D(hDC, iEntries, ptr_puRed, ptr_puGreen, ptr_puBlue);
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglSetGammaTableI3D (HDC hDC, int iEntries, const USHORT *puRed, const USHORT *puGreen, const USHORT *puBlue);
        public unsafe static bool SetGammaTableI3D(IntPtr hDC, int iEntries, ushort[] puRed, ushort[] puGreen, ushort[] puBlue)
        {
            if (wglSetGammaTableI3D != null)
            {
                fixed (ushort* ptr_puRed = puRed)
                {
                    fixed (ushort* ptr_puGreen = puGreen)
                    {
                        fixed (ushort* ptr_puBlue = puBlue)
                        {
                            return wglSetGammaTableI3D(hDC, iEntries, ptr_puRed, ptr_puGreen, ptr_puBlue);
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_genlock
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglEnableGenlockI3D (HDC hDC);
        public static bool EnableGenlockI3D(IntPtr hDC)
        {
            if (wglEnableGenlockI3D != null)
            {
                return wglEnableGenlockI3D(hDC);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglDisableGenlockI3D (HDC hDC);
        public static bool DisableGenlockI3D (IntPtr hDC)
        {
            if (wglDisableGenlockI3D != null)
            {
                return wglDisableGenlockI3D(hDC);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglIsEnabledGenlockI3D (HDC hDC, BOOL *pFlag);
        public unsafe static bool IsEnabledGenlockI3D (IntPtr hDC, bool[] pFlag)
        {
            if (wglIsEnabledGenlockI3D != null)
            {
                fixed (bool* ptr_pFlag = pFlag)
                {
                    return wglIsEnabledGenlockI3D(hDC, ptr_pFlag);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglGenlockSourceI3D (HDC hDC, UINT uSource);
        public static bool GenlockSourceI3D (IntPtr hDC, uint uSource)
        {
            if (wglGenlockSourceI3D != null)
            {
                return wglGenlockSourceI3D(hDC, uSource);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglGetGenlockSourceI3D (HDC hDC, UINT *uSource);
        public unsafe static bool GetGenlockSourceI3D (IntPtr hDC, uint[] uSource)
        {
            if (wglGetGenlockSourceI3D != null)
            {
                fixed (uint* ptr_uSource = uSource)
                {
                    return wglGetGenlockSourceI3D(hDC, ptr_uSource);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglGenlockSourceEdgeI3D (HDC hDC, UINT uEdge);
        public static bool GenlockSourceEdgeI3D (IntPtr hDC, uint uEdge)
        {
            if (wglGenlockSourceEdgeI3D != null)
            {
                return wglGenlockSourceEdgeI3D(hDC, uEdge);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglGetGenlockSourceEdgeI3D (HDC hDC, UINT *uEdge);
        public unsafe static bool GetGenlockSourceEdgeI3D (IntPtr hDC, uint[] uEdge)
        {
            if (wglGetGenlockSourceEdgeI3D != null)
            {
                fixed(uint* ptr_uEdge = uEdge)
                {
                    return wglGetGenlockSourceEdgeI3D(hDC, ptr_uEdge);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglGenlockSampleRateI3D (HDC hDC, UINT uRate);
        public static bool GenlockSampleRateI3D (IntPtr hDC, uint uRate)
        {
            if (wglGenlockSampleRateI3D != null)
            {
                return wglGenlockSampleRateI3D(hDC, uRate);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglGetGenlockSampleRateI3D (HDC hDC, UINT *uRate);
        public unsafe static bool GetGenlockSampleRateI3D (IntPtr hDC, uint[] uRate)
        {
            if (wglGetGenlockSampleRateI3D != null)
            {
                fixed (uint* ptr_uRate = uRate)
                {
                    return wglGetGenlockSampleRateI3D(hDC, ptr_uRate);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglGenlockSourceDelayI3D (HDC hDC, UINT uDelay);
        public static bool GenlockSourceDelayI3D(IntPtr hDC, uint uDelay)
        {
            if (wglGenlockSourceDelayI3D != null)
            {
                return wglGenlockSourceDelayI3D(hDC, uDelay);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglGetGenlockSourceDelayI3D (HDC hDC, UINT *uDelay);
        public unsafe static bool GetGenlockSourceDelayI3D (IntPtr hDC, uint[] uDelay)
        {
            if (wglGetGenlockSourceDelayI3D != null)
            {
                fixed (uint* ptr_uDelay = uDelay)
                {
                    return wglGetGenlockSourceDelayI3D(hDC, ptr_uDelay);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglQueryGenlockMaxSourceDelayI3D (HDC hDC, UINT *uMaxLineDelay, UINT *uMaxPixelDelay);
        public unsafe static bool QueryGenlockMaxSourceDelayI3D (IntPtr hDC, uint[] uMaxLineDelay, uint[] uMaxPixelDelay)
        {
            if (wglQueryGenlockMaxSourceDelayI3D != null)
            {
                fixed (uint* ptr_uMaxLineDelay = uMaxLineDelay)
                {
                    fixed (uint* ptr_uMaxPixelDelay = uMaxPixelDelay)
                    {
                        return wglQueryGenlockMaxSourceDelayI3D(hDC, ptr_uMaxLineDelay, ptr_uMaxPixelDelay);
                    }
                }
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_image_buffer
        ///////////////////////////////////////////////////////////////////////
        // LPVOID WINAPI wglCreateImageBufferI3D (HDC hDC, DWORD dwSize, UINT uFlags);
        public unsafe static IntPtr CreateImageBufferI3D(IntPtr hDC, uint dwSize, uint uFlags)
        {
            if (wglCreateImageBufferI3D != null)
            {
                return (IntPtr)wglCreateImageBufferI3D(hDC, dwSize, uFlags);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // BOOL WINAPI wglDestroyImageBufferI3D (HDC hDC, LPVOID pAddress);
        public unsafe static bool DestroyImageBufferI3D(IntPtr hDC, IntPtr pAddress)
        {
            if (wglDestroyImageBufferI3D != null)
            {
                return wglDestroyImageBufferI3D(hDC, pAddress.ToPointer());
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglAssociateImageBufferEventsI3D (HDC hDC, const HANDLE *pEvent, const LPVOID *pAddress, const DWORD *pSize, UINT count);
        public unsafe static bool AssociateImageBufferEventsI3D(IntPtr hDC, IntPtr[] pEvent, IntPtr[] pAddress, uint[] pSize, uint count)
        {
            if (wglAssociateImageBufferEventsI3D != null)
            {
                fixed (IntPtr* ptr_pEvent = pEvent)
                {
                    fixed (IntPtr* ptr_pAddress = pAddress)
                    {
                        fixed (uint* ptr_pSize = pSize)
                        {
                            return wglAssociateImageBufferEventsI3D(hDC, ptr_pEvent, (void**)ptr_pAddress, ptr_pSize, count);
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglReleaseImageBufferEventsI3D (HDC hDC, const LPVOID *pAddress, UINT count);
        public unsafe static bool ReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr[] pAddress, uint count)
        {
            if (wglReleaseImageBufferEventsI3D != null)
            {
                fixed (IntPtr* ptr_pAddress = pAddress)
                {
                    return wglReleaseImageBufferEventsI3D(hDC, (void**)ptr_pAddress, count);
                }
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_swap_frame_lock
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglEnableFrameLockI3D (void);
        public static bool EnableFrameLockI3D()
        {
            if (wglEnableFrameLockI3D != null)
            {
                return wglEnableFrameLockI3D();
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglDisableFrameLockI3D (void);
        public static bool DisableFrameLockI3D()
        {
            if (wglDisableFrameLockI3D != null)
            {
                return wglDisableFrameLockI3D();
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglIsEnabledFrameLockI3D (BOOL *pFlag);
        public unsafe static bool IsEnabledFrameLockI3D(bool[] pFlag)
        {
            if (wglIsEnabledFrameLockI3D != null)
            {
                fixed (bool* ptr_pFlag = pFlag)
                {
                    return wglIsEnabledFrameLockI3D(ptr_pFlag);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglQueryFrameLockMasterI3D (BOOL *pFlag);
        public unsafe static bool QueryFrameLockMasterI3D(bool[] pFlag)
        {
            if (wglQueryFrameLockMasterI3D != null)
            {
                fixed (bool* ptr_pFlag = pFlag)
                {
                    return wglQueryFrameLockMasterI3D(ptr_pFlag);
                }
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_swap_frame_usage
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglGetFrameUsageI3D (float *pUsage);
        public unsafe static bool GetFrameUsageI3D(float[] pUsage)
        {
            if (wglGetFrameUsageI3D != null)
            {
                fixed (float* ptr_pUsage = pUsage)
                {
                    return wglGetFrameUsageI3D(ptr_pUsage);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglBeginFrameTrackingI3D (void);
        public static bool BeginFrameTrackingI3D()
        {
            if (wglBeginFrameTrackingI3D != null)
            {
                return wglBeginFrameTrackingI3D();
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglEndFrameTrackingI3D (void);
        public static bool EndFrameTrackingI3D()
        {
            if (wglEndFrameTrackingI3D != null)
            {
                return wglEndFrameTrackingI3D();
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglQueryFrameTrackingI3D (DWORD *pFrameCount, DWORD *pMissedFrames, float *pLastMissedUsage);
        public unsafe static bool QueryFrameTrackingI3D(uint[] pFrameCount, uint[] pMissedFrames, float[] pLastMissedUsage)
        {
            if (wglQueryFrameTrackingI3D != null)
            {
                fixed (uint* ptr_pFrameCount = pFrameCount)
                {
                    fixed (uint* ptr_pMissedFrames = pMissedFrames)
                    {
                        fixed (float* ptr_pLastMissedUsage = pLastMissedUsage)
                        {
                            return wglQueryFrameTrackingI3D(ptr_pFrameCount, ptr_pMissedFrames, ptr_pLastMissedUsage);
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_NV_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_copy_image
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglCopyImageSubDataNV (HGLRC hSrcRC, GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, HGLRC hDstRC, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth);
        public static bool CopyImageSubDataNV(IntPtr hSrcRC, GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, IntPtr hDstRC, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth)
        {
            if (wglCopyImageSubDataNV != null)
            {
                return wglCopyImageSubDataNV(hSrcRC, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, hDstRC, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_delay_before_swap
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglDelayBeforeSwapNV (HDC hDC, GLfloat seconds);
        public static bool DelayBeforeSwapNV(IntPtr hDC, GLfloat seconds)
        {
            if (wglDelayBeforeSwapNV != null)
            {
                return wglDelayBeforeSwapNV(hDC, seconds);
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_DX_interop
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglDXSetResourceShareHandleNV (void *dxObject, HANDLE shareHandle);
        public unsafe static bool DXSetResourceShareHandleNV(IntPtr dxObject, IntPtr shareHandle)
        {
            if (wglDXSetResourceShareHandleNV != null)
            {
                return wglDXSetResourceShareHandleNV(dxObject.ToPointer(), shareHandle);
            }
            else
            {
                return false;
            }
        }

        // HANDLE WINAPI wglDXOpenDeviceNV (void *dxDevice);
        public unsafe static IntPtr DXOpenDeviceNV(IntPtr dxDevice)
        {
            if (wglDXOpenDeviceNV != null)
            {
                return wglDXOpenDeviceNV(dxDevice.ToPointer());
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // BOOL WINAPI wglDXCloseDeviceNV (HANDLE hDevice);
        public static bool DXCloseDeviceNV(IntPtr hDevice)
        {
            if (wglDXCloseDeviceNV != null)
            {
                return wglDXCloseDeviceNV(hDevice);
            }
            else
            {
                return false;
            }
        }

        // HANDLE WINAPI wglDXRegisterObjectNV (HANDLE hDevice, void *dxObject, GLuint name, GLenum type, GLenum access);
        public unsafe static IntPtr DXRegisterObjectNV(IntPtr hDevice, IntPtr dxObject, GLuint name, GLenum type, GLenum access)
        {
            if (wglDXRegisterObjectNV != null)
            {
                return wglDXRegisterObjectNV(hDevice, dxObject.ToPointer(), name, type, access);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // BOOL WINAPI wglDXUnregisterObjectNV (HANDLE hDevice, HANDLE hObject);
        public static bool DXUnregisterObjectNV(IntPtr hDevice, IntPtr hObject)
        {
            if (wglDXUnregisterObjectNV != null)
            {
                return wglDXUnregisterObjectNV(hDevice, hObject);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglDXObjectAccessNV (HANDLE hObject, GLenum access);
        public static bool DXObjectAccessNV(IntPtr hObject, GLenum access)
        {
            if (wglDXObjectAccessNV != null)
            {
                return wglDXObjectAccessNV(hObject, access);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglDXLockObjectsNV (HANDLE hDevice, GLint count, HANDLE *hObjects);
        public unsafe static bool DXLockObjectsNV(IntPtr hDevice, GLint count, IntPtr[] hObjects)
        {
            if (wglDXLockObjectsNV != null)
            {
                fixed (IntPtr* ptr_hObjects = hObjects)
                {
                    return wglDXLockObjectsNV(hDevice, count, ptr_hObjects);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglDXUnlockObjectsNV (HANDLE hDevice, GLint count, HANDLE *hObjects);
        public unsafe static bool DXUnlockObjectsNV(IntPtr hDevice, GLint count, IntPtr[] hObjects)
        {
            if (wglDXUnlockObjectsNV != null)
            {
                fixed (IntPtr* ptr_hObjects = hObjects)
                {
                    return wglDXUnlockObjectsNV(hDevice, count, ptr_hObjects);
                }
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_DX_interop2 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_float_buffer (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_gpu_affinity (TODO: SKIPPED FOR NOW!!!)
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglEnumGpusNV(UINT iGpuIndex, HGPUNV* phGpu);
        // BOOL WINAPI wglEnumGpuDevicesNV(HGPUNV hGpu, UINT iDeviceIndex, PGPU_DEVICE lpGpuDevice);
        // HDC WINAPI wglCreateAffinityDCNV(const HGPUNV* phGpuList);
        // BOOL WINAPI wglEnumGpusFromAffinityDCNV(HDC hAffinityDC, UINT iGpuIndex, HGPUNV* hGpu);
        // BOOL WINAPI wglDeleteDCNV(HDC hdc);

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_multisample_coverage (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_present_video
        ///////////////////////////////////////////////////////////////////////
        // int WINAPI wglEnumerateVideoDevicesNV (HDC hDC, HVIDEOOUTPUTDEVICENV *phDeviceList);
        public unsafe static int EnumerateVideoDevicesNV(IntPtr hDC, IntPtr[] phDeviceList)
        {
            if (wglEnumerateVideoDevicesNV != null)
            {
                fixed (IntPtr* ptr_phDeviceList = phDeviceList)
                {
                    return wglEnumerateVideoDevicesNV(hDC, ptr_phDeviceList);
                }
            }
            else
            {
                return 0;
            }
        }

        // BOOL WINAPI wglBindVideoDeviceNV (HDC hDC, unsigned int uVideoSlot, HVIDEOOUTPUTDEVICENV hVideoDevice, const int *piAttribList);
        public unsafe static bool BindVideoDeviceNV(IntPtr hDC, uint uVideoSlot, IntPtr hVideoDevice, int[] piAttribList)
        {
            if (wglBindVideoDeviceNV != null)
            {
                fixed (int* ptr_piAttribList = piAttribList)
                {
                    return wglBindVideoDeviceNV(hDC, uVideoSlot, hVideoDevice, ptr_piAttribList);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglQueryCurrentContextNV (int iAttribute, int *piValue);
        public unsafe static bool QueryCurrentContextNV(int iAttribute, int[] piValue)
        {
            if (wglQueryCurrentContextNV != null)
            {
                fixed (int* ptr_piValue = piValue)
                {
                    return wglQueryCurrentContextNV(iAttribute, ptr_piValue);
                }
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_render_depth_texture (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_render_texture_rectangle (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_swap_group
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglJoinSwapGroupNV (HDC hDC, GLuint group);
        public static bool JoinSwapGroupNV(IntPtr hDC, GLuint group)
        {
            if (wglJoinSwapGroupNV != null)
            {
                return wglJoinSwapGroupNV(hDC, group);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglBindSwapBarrierNV (GLuint group, GLuint barrier);
        public static bool BindSwapBarrierNV(GLuint group, GLuint barrier)
        {
            if (wglBindSwapBarrierNV != null)
            {
                return wglBindSwapBarrierNV(group, barrier);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglQuerySwapGroupNV (HDC hDC, GLuint *group, GLuint *barrier);
        public unsafe static bool QuerySwapGroupNV(IntPtr hDC, GLuint[] group, GLuint[] barrier)
        {
            if (wglQuerySwapGroupNV != null)
            {
                fixed (GLuint* ptr_group = group)
                {
                    fixed (GLuint* ptr_barrier = barrier)
                    {
                        return wglQuerySwapGroupNV(hDC, ptr_group, ptr_barrier);
                    }
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglQueryMaxSwapGroupsNV (HDC hDC, GLuint *maxGroups, GLuint *maxBarriers);
        public unsafe static bool QueryMaxSwapGroupsNV(IntPtr hDC, GLuint[] maxGroups, GLuint[] maxBarriers)
        {
            if (wglQueryMaxSwapGroupsNV != null)
            {
                fixed (GLuint* ptr_maxGroups = maxGroups)
                {
                    fixed (GLuint* ptr_maxBarriers = maxBarriers)
                    {
                        return wglQueryMaxSwapGroupsNV(hDC, ptr_maxGroups, ptr_maxBarriers);
                    }
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglQueryFrameCountNV (HDC hDC, GLuint *count);
        public unsafe static bool QueryFrameCountNV(IntPtr hDC, GLuint[] count)
        {
            if (wglQueryFrameCountNV != null)
            {
                fixed (GLuint* ptr_count = count)
                {
                    return wglQueryFrameCountNV(hDC, ptr_count);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglResetFrameCountNV (HDC hDC);
        public static bool ResetFrameCountNV(IntPtr hDC)
        {
            if (wglResetFrameCountNV != null)
            {
                return wglResetFrameCountNV(hDC);
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_vertex_array_range
        ///////////////////////////////////////////////////////////////////////
        // void *WINAPI wglAllocateMemoryNV (GLsizei size, GLfloat readfreq, GLfloat writefreq, GLfloat priority);
        public unsafe static IntPtr AllocateMemoryNV(GLsizei size, GLfloat readfreq, GLfloat writefreq, GLfloat priority)
        {
            if (wglAllocateMemoryNV != null)
            {
                return (IntPtr)wglAllocateMemoryNV(size, readfreq, writefreq, priority);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // void WINAPI wglFreeMemoryNV (void *pointer);
        public unsafe static void FreeMemoryNV(IntPtr pointer)
        {
            if (wglFreeMemoryNV != null)
            {
                wglFreeMemoryNV(pointer.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_video_capture
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglBindVideoCaptureDeviceNV (UINT uVideoSlot, HVIDEOINPUTDEVICENV hDevice);
        public static bool BindVideoCaptureDeviceNV(uint uVideoSlot, IntPtr hDevice)
        {
            if (wglBindVideoCaptureDeviceNV != null)
            {
                return wglBindVideoCaptureDeviceNV(uVideoSlot, hDevice);
            }
            else
            {
                return false;
            }
        }

        // UINT WINAPI wglEnumerateVideoCaptureDevicesNV (HDC hDc, HVIDEOINPUTDEVICENV *phDeviceList);
        public unsafe static uint EnumerateVideoCaptureDevicesNV(IntPtr hDC, IntPtr[] phDeviceList)
        {
            if (wglEnumerateVideoCaptureDevicesNV != null)
            {
                fixed (IntPtr* ptr_phDeviceList = phDeviceList)
                {
                    return wglEnumerateVideoCaptureDevicesNV(hDC, ptr_phDeviceList);
                }
            }
            else
            {
                return 0;
            }
        }

        // BOOL WINAPI wglLockVideoCaptureDeviceNV (HDC hDc, HVIDEOINPUTDEVICENV hDevice);
        public static bool LockVideoCaptureDeviceNV(IntPtr hDC, IntPtr hDevice)
        {
            if (wglLockVideoCaptureDeviceNV != null)
            {
                return wglLockVideoCaptureDeviceNV(hDC, hDevice);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglQueryVideoCaptureDeviceNV (HDC hDc, HVIDEOINPUTDEVICENV hDevice, int iAttribute, int *piValue);
        public unsafe static bool QueryVideoCaptureDeviceNV(IntPtr hDC, IntPtr hDevice, int iAttribute, int[] piValue)
        {
            if (wglQueryVideoCaptureDeviceNV != null)
            {
                fixed (int* ptr_piValue = piValue)
                {
                    return wglQueryVideoCaptureDeviceNV(hDC, hDevice, iAttribute, ptr_piValue);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglReleaseVideoCaptureDeviceNV (HDC hDc, HVIDEOINPUTDEVICENV hDevice);
        public static bool ReleaseVideoCaptureDeviceNV(IntPtr hDC, IntPtr hDevice)
        {
            if (wglReleaseVideoCaptureDeviceNV != null)
            {
                return wglReleaseVideoCaptureDeviceNV(hDC, hDevice);
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_video_output
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglGetVideoDeviceNV (HDC hDC, int numDevices, HPVIDEODEV *hVideoDevice);
        public unsafe static bool GetVideoDeviceNV(IntPtr hDC, int numDevices, IntPtr[] hVideoDevice)
        {
            if (wglGetVideoDeviceNV != null)
            {
                fixed (IntPtr* ptr_hVideoDevice = hVideoDevice)
                {
                    return wglGetVideoDeviceNV(hDC, numDevices, ptr_hVideoDevice);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglReleaseVideoDeviceNV (HPVIDEODEV hVideoDevice);
        public static bool ReleaseVideoDeviceNV(IntPtr hVideoDevice)
        {
            if (wglReleaseVideoDeviceNV != null)
            {
                return wglReleaseVideoDeviceNV(hVideoDevice);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglBindVideoImageNV (HPVIDEODEV hVideoDevice, HPBUFFERARB hPbuffer, int iVideoBuffer);
        public static bool BindVideoImageNV(IntPtr hVideoDevice, IntPtr hPbuffer, int iVideoBuffer)
        {
            if (wglBindVideoImageNV != null)
            {
                return wglBindVideoImageNV(hVideoDevice, hPbuffer, iVideoBuffer);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglReleaseVideoImageNV (HPBUFFERARB hPbuffer, int iVideoBuffer);
        public static bool ReleaseVideoImageNV(IntPtr hPbuffer, int iVideoBuffer)
        {
            if (wglReleaseVideoImageNV != null)
            {
                return wglReleaseVideoImageNV(hPbuffer, iVideoBuffer);
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglSendPbufferToVideoNV (HPBUFFERARB hPbuffer, int iBufferType, unsigned long *pulCounterPbuffer, BOOL bBlock);
        public unsafe static bool SendPbufferToVideoNV(IntPtr hPbuffer, int iBufferType, uint[] pulCounterPbuffer, bool bBlock)
        {
            if (wglSendPbufferToVideoNV != null)
            {
                fixed (uint* ptr_pulCounterPbuffer = pulCounterPbuffer)
                {
                    return wglSendPbufferToVideoNV(hPbuffer, iBufferType, ptr_pulCounterPbuffer, bBlock);
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglGetVideoInfoNV (HPVIDEODEV hpVideoDevice, unsigned long *pulCounterOutputPbuffer, unsigned long *pulCounterOutputVideo);
        public unsafe static bool GetVideoInfoNV(IntPtr hpVideoDevice, uint[] pulCounterOutputPbuffer, uint[] pulCounterOutputVideo)
        {
            if (wglGetVideoInfoNV != null)
            {
                fixed (uint* ptr_pulCounterOutputPbuffer = pulCounterOutputPbuffer)
                {
                    fixed (uint* ptr_pulCounterOutputVideo = pulCounterOutputVideo)
                    {
                        return wglGetVideoInfoNV(hpVideoDevice, ptr_pulCounterOutputPbuffer, ptr_pulCounterOutputVideo);
                    }
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_OML_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_OML_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_OML_sync_control
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglGetSyncValuesOML (HDC hdc, INT64 *ust, INT64 *msc, INT64 *sbc);
        public unsafe static bool GetSyncValuesOML(IntPtr hdc, Int64[] ust, Int64[] msc, Int64[] sbc)
        {
            if (wglGetSyncValuesOML != null)
            {
                fixed (Int64* ptr_ust = ust)
                {
                    fixed (Int64* ptr_msc = msc)
                    {
                        fixed (Int64* ptr_sbc = sbc)
                        {
                            return wglGetSyncValuesOML(hdc, ptr_ust, ptr_msc, ptr_sbc);
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglGetMscRateOML (HDC hdc, INT32 *numerator, INT32 *denominator);
        public unsafe static bool GetMscRateOML(IntPtr hdc, Int32[] numerator, Int32[] denominator)
        {
            if (wglGetMscRateOML != null)
            {
                fixed (Int32* ptr_numerator = numerator)
                {
                    fixed (Int32* ptr_denominator = denominator)
                    {
                        return wglGetMscRateOML(hdc, ptr_numerator, ptr_denominator);
                    }
                }
            }
            else
            {
                return false;
            }
        }

        // INT64 WINAPI wglSwapBuffersMscOML (HDC hdc, INT64 target_msc, INT64 divisor, INT64 remainder);
        public static Int64 SwapBuffersMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder)
        {
            if (wglSwapBuffersMscOML != null)
            {
                return wglSwapBuffersMscOML(hdc, target_msc, divisor, remainder);
            }
            else
            {
                return 0;
            }
        }

        // INT64 WINAPI wglSwapLayerBuffersMscOML (HDC hdc, int fuPlanes, INT64 target_msc, INT64 divisor, INT64 remainder);
        public static Int64 SwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder)
        {
            if (wglSwapLayerBuffersMscOML != null)
            {
                return wglSwapLayerBuffersMscOML(hdc, fuPlanes, target_msc, divisor, remainder);
            }
            else
            {
                return 0;
            }
        }

        // BOOL WINAPI wglWaitForMscOML (HDC hdc, INT64 target_msc, INT64 divisor, INT64 remainder, INT64 *ust, INT64 *msc, INT64 *sbc);
        public unsafe static bool WaitForMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, Int64[] ust, Int64[] msc, Int64[] sbc)
        {
            if (wglWaitForMscOML != null)
            {
                fixed (Int64* ptr_ust = ust)
                {
                    fixed (Int64* ptr_msc = msc)
                    {
                        fixed (Int64* ptr_sbc = sbc)
                        {
                            return wglWaitForMscOML(hdc, target_msc, divisor, remainder, ptr_ust, ptr_msc, ptr_sbc);
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        }

        // BOOL WINAPI wglWaitForSbcOML (HDC hdc, INT64 target_sbc, INT64 *ust, INT64 *msc, INT64 *sbc);
        public unsafe static bool WaitForSbcOML(IntPtr hdc, Int64 target_sbc, Int64[] ust, Int64[] msc, Int64[] sbc)
        {
            if (wglWaitForSbcOML != null)
            {
                fixed (Int64* ptr_ust = ust)
                {
                    fixed (Int64* ptr_msc = msc)
                    {
                        fixed (Int64* ptr_sbc = sbc)
                        {
                            return wglWaitForSbcOML(hdc, target_sbc, ptr_ust, ptr_msc, ptr_sbc);
                        }
                    }
                }
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
