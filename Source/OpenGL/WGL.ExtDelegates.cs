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
        // WGL EXTENSION FUNCTIONS
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_3DFX_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_3DFX_xxx FUNCTIONS...
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglSetStereoEmitterState3DL(IntPtr hDC, uint uState);
        private static TwglSetStereoEmitterState3DL wglSetStereoEmitterState3DL = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_AMD_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_AMD_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_AMD_gpu_association
        ///////////////////////////////////////////////////////////////////////
        // UINT  WINAPI wglGetGPUIDsAMD (UINT maxCount, UINT *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate uint TwglGetGPUIDsAMD(uint maxCount, uint* ids);
        private static TwglGetGPUIDsAMD wglGetGPUIDsAMD = null;

        // INT   WINAPI wglGetGPUInfoAMD (UINT id, int property, GLenum dataType, UINT size, void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate int TwglGetGPUInfoAMD(uint id, int property, GLenum dataType, uint size, void* data);
        private static TwglGetGPUInfoAMD wglGetGPUInfoAMD = null;

        // UINT  WINAPI wglGetContextGPUIDAMD (HGLRC hglrc);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate uint TwglGetContextGPUIDAMD(IntPtr hglrc);
        private static TwglGetContextGPUIDAMD wglGetContextGPUIDAMD = null;

        // HGLRC WINAPI wglCreateAssociatedContextAMD (UINT id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr TwglCreateAssociatedContextAMD(uint id);
        private static TwglCreateAssociatedContextAMD wglCreateAssociatedContextAMD = null;

        // HGLRC WINAPI wglCreateAssociatedContextAttribsAMD (UINT id, HGLRC hShareContext, const int *attribList);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate IntPtr TwglCreateAssociatedContextAttribsAMD(uint id, IntPtr hShareContext, int* attribList);
        private static TwglCreateAssociatedContextAttribsAMD wglCreateAssociatedContextAttribsAMD = null;

        // BOOL  WINAPI wglDeleteAssociatedContextAMD (HGLRC hglrc);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglDeleteAssociatedContextAMD(IntPtr hglrc);
        private static TwglDeleteAssociatedContextAMD wglDeleteAssociatedContextAMD = null;

        // BOOL  WINAPI wglMakeAssociatedContextCurrentAMD (HGLRC hglrc);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglMakeAssociatedContextCurrentAMD(IntPtr hglrc);
        private static TwglMakeAssociatedContextCurrentAMD wglMakeAssociatedContextCurrentAMD = null;

        // HGLRC WINAPI wglGetCurrentAssociatedContextAMD (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr TwglGetCurrentAssociatedContextAMD();
        private static TwglGetCurrentAssociatedContextAMD wglGetCurrentAssociatedContextAMD = null;

        // VOID  WINAPI wglBlitContextFramebufferAMD (HGLRC dstCtx, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void TwglBlitContextFramebufferAMD(IntPtr dstCtx, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);
        private static TwglBlitContextFramebufferAMD wglBlitContextFramebufferAMD = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_ARB_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_buffer_region
        ///////////////////////////////////////////////////////////////////////
        // HANDLE WINAPI wglCreateBufferRegionARB (HDC hDC, int iLayerPlane, UINT uType);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr TwglCreateBufferRegionARB(IntPtr hDC, int iLayerPlane, uint uType);
        private static TwglCreateBufferRegionARB wglCreateBufferRegionARB = null;

        // VOID WINAPI wglDeleteBufferRegionARB (HANDLE hRegion);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void TwglDeleteBufferRegionARB(IntPtr hRegion);
        private static TwglDeleteBufferRegionARB wglDeleteBufferRegionARB = null;

        // BOOL WINAPI wglSaveBufferRegionARB (HANDLE hRegion, int x, int y, int width, int height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglSaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height);
        private static TwglSaveBufferRegionARB wglSaveBufferRegionARB = null;

        // BOOL WINAPI wglRestoreBufferRegionARB (HANDLE hRegion, int x, int y, int width, int height, int xSrc, int ySrc);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglRestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc);
        private static TwglRestoreBufferRegionARB wglRestoreBufferRegionARB = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_create_context
        ///////////////////////////////////////////////////////////////////////
        // HGLRC WINAPI wglCreateContextAttribsARB (HDC hDC, HGLRC hShareContext, const int *attribList);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate IntPtr TwglCreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int* attribList);
        private static TwglCreateContextAttribsARB wglCreateContextAttribsARB = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate byte* TwglGetExtensionsStringARB(IntPtr hdc);
        private static TwglGetExtensionsStringARB wglGetExtensionsStringARB = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_framebuffer_sRGB (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_make_current_read
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglMakeContextCurrentARB (HDC hDrawDC, HDC hReadDC, HGLRC hglrc);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglMakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
        private static TwglMakeContextCurrentARB wglMakeContextCurrentARB = null;

        // HDC WINAPI wglGetCurrentReadDCARB (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr TwglGetCurrentReadDCARB();
        private static TwglGetCurrentReadDCARB wglGetCurrentReadDCARB = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_multisample (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_pbuffer
        ///////////////////////////////////////////////////////////////////////
        // HPBUFFERARB WINAPI wglCreatePbufferARB (HDC hDC, int iPixelFormat, int iWidth, int iHeight, const int *piAttribList);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate IntPtr TwglCreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
        private static TwglCreatePbufferARB wglCreatePbufferARB = null;

        // HDC WINAPI wglGetPbufferDCARB (HPBUFFERARB hPbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr TwglGetPbufferDCARB(IntPtr hPbuffer);
        private static TwglGetPbufferDCARB wglGetPbufferDCARB = null;

        // int WINAPI wglReleasePbufferDCARB (HPBUFFERARB hPbuffer, HDC hDC);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int TwglReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);
        private static TwglReleasePbufferDCARB wglReleasePbufferDCARB = null;

        // BOOL WINAPI wglDestroyPbufferARB (HPBUFFERARB hPbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglDestroyPbufferARB(IntPtr hPbuffer);
        private static TwglDestroyPbufferARB wglDestroyPbufferARB = null;

        // BOOL WINAPI wglQueryPbufferARB (HPBUFFERARB hPbuffer, int iAttribute, int *piValue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglQueryPbufferARB(IntPtr hPbuffer, int iAttribute, int* piValue);
        private static TwglQueryPbufferARB wglQueryPbufferARB = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_pixel_format
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglGetPixelFormatAttribivARB (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, const int *piAttributes, int *piValues);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, int* piValues);
        private static TwglGetPixelFormatAttribivARB wglGetPixelFormatAttribivARB = null;

        // BOOL WINAPI wglGetPixelFormatAttribfvARB (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, const int *piAttributes, FLOAT *pfValues);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, float* pfValues);
        private static TwglGetPixelFormatAttribfvARB wglGetPixelFormatAttribfvARB = null;

        // BOOL WINAPI wglChoosePixelFormatARB (HDC hdc, const int *piAttribIList, const FLOAT *pfAttribFList, UINT nMaxFormats, int *piFormats, UINT *nNumFormats);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglChoosePixelFormatARB(IntPtr hdc, int* piAttribIList, float* pfAttribFList, uint nMaxFormats, int* piFormats, uint* nNumFormats);
        private static TwglChoosePixelFormatARB wglChoosePixelFormatARB = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_pixel_format_float (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_render_texture
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglBindTexImageARB (HPBUFFERARB hPbuffer, int iBuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglBindTexImageARB(IntPtr hPbuffer, int iBuffer);
        private static TwglBindTexImageARB wglBindTexImageARB = null;

        // BOOL WINAPI wglReleaseTexImageARB (HPBUFFERARB hPbuffer, int iBuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);
        private static TwglReleaseTexImageARB wglReleaseTexImageARB = null;

        // BOOL WINAPI wglSetPbufferAttribARB (HPBUFFERARB hPbuffer, const int *piAttribList);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglSetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);
        private static TwglSetPbufferAttribARB wglSetPbufferAttribARB = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate GLboolean TwglCreateDisplayColorTableEXT(GLushort id);
        private static TwglCreateDisplayColorTableEXT wglCreateDisplayColorTableEXT = null;

        // GLboolean WINAPI wglLoadDisplayColorTableEXT (const GLushort *table, GLuint length);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate GLboolean TwglLoadDisplayColorTableEXT(GLushort* table, GLuint length);
        private static TwglLoadDisplayColorTableEXT wglLoadDisplayColorTableEXT = null;

        // GLboolean WINAPI wglBindDisplayColorTableEXT (GLushort id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate GLboolean TwglBindDisplayColorTableEXT(GLushort id);
        private static TwglBindDisplayColorTableEXT wglBindDisplayColorTableEXT = null;

        // VOID WINAPI wglDestroyDisplayColorTableEXT (GLushort id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void TwglDestroyDisplayColorTableEXT(GLushort id);
        private static TwglDestroyDisplayColorTableEXT wglDestroyDisplayColorTableEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_extensions_string
        ///////////////////////////////////////////////////////////////////////
        // const char *WINAPI wglGetExtensionsStringEXT (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate byte* TwglGetExtensionsStringEXT();
        private static TwglGetExtensionsStringEXT wglGetExtensionsStringEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_framebuffer_sRGB (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_make_current_read
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglMakeContextCurrentEXT (HDC hDrawDC, HDC hReadDC, HGLRC hglrc);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglMakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
        private static TwglMakeContextCurrentEXT wglMakeContextCurrentEXT = null;

        // HDC WINAPI wglGetCurrentReadDCEXT (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr TwglGetCurrentReadDCEXT();
        private static TwglGetCurrentReadDCEXT wglGetCurrentReadDCEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_multisample (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_pbuffer
        ///////////////////////////////////////////////////////////////////////
        // HPBUFFEREXT WINAPI wglCreatePbufferEXT (HDC hDC, int iPixelFormat, int iWidth, int iHeight, const int *piAttribList);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate IntPtr TwglCreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
        private static TwglCreatePbufferEXT wglCreatePbufferEXT = null;

        // HDC WINAPI wglGetPbufferDCEXT (HPBUFFEREXT hPbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr TwglGetPbufferDCEXT(IntPtr hPbuffer);
        private static TwglGetPbufferDCEXT wglGetPbufferDCEXT = null;

        // int WINAPI wglReleasePbufferDCEXT (HPBUFFEREXT hPbuffer, HDC hDC);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int TwglReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC);
        private static TwglReleasePbufferDCEXT wglReleasePbufferDCEXT = null;

        // BOOL WINAPI wglDestroyPbufferEXT (HPBUFFEREXT hPbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglDestroyPbufferEXT(IntPtr hPbuffer);
        private static TwglDestroyPbufferEXT wglDestroyPbufferEXT = null;

        // BOOL WINAPI wglQueryPbufferEXT (HPBUFFEREXT hPbuffer, int iAttribute, int *piValue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglQueryPbufferEXT(IntPtr hPbuffer, int iAttribute, int* piValue);
        private static TwglQueryPbufferEXT wglQueryPbufferEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_pixel_format
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglGetPixelFormatAttribivEXT (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, int *piAttributes, int *piValues);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, int* piValues);
        private static TwglGetPixelFormatAttribivEXT wglGetPixelFormatAttribivEXT = null;

        // BOOL WINAPI wglGetPixelFormatAttribfvEXT (HDC hdc, int iPixelFormat, int iLayerPlane, UINT nAttributes, int *piAttributes, FLOAT *pfValues);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes, int* piAttributes, float* pfValues);
        private static TwglGetPixelFormatAttribfvEXT wglGetPixelFormatAttribfvEXT = null;

        // BOOL WINAPI wglChoosePixelFormatEXT (HDC hdc, const int *piAttribIList, const FLOAT *pfAttribFList, UINT nMaxFormats, int *piFormats, UINT *nNumFormats);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, float* pfAttribFList, uint nMaxFormats, int* piFormats, uint* nNumFormats);
        private static TwglChoosePixelFormatEXT wglChoosePixelFormatEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_pixel_format_packed_float (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_swap_control
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglSwapIntervalEXT (int interval);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglSwapIntervalEXT(int interval);
        private static TwglSwapIntervalEXT wglSwapIntervalEXT = null;

        // int WINAPI wglGetSwapIntervalEXT (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int TwglGetSwapIntervalEXT();
        private static TwglGetSwapIntervalEXT wglGetSwapIntervalEXT = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
        private static TwglGetDigitalVideoParametersI3D wglGetDigitalVideoParametersI3D = null;

        // BOOL WINAPI wglSetDigitalVideoParametersI3D (HDC hDC, int iAttribute, const int *piValue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglSetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
        private static TwglSetDigitalVideoParametersI3D wglSetDigitalVideoParametersI3D = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_gamma
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglGetGammaTableParametersI3D (HDC hDC, int iAttribute, int *piValue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
        private static TwglGetGammaTableParametersI3D wglGetGammaTableParametersI3D = null;

        // BOOL WINAPI wglSetGammaTableParametersI3D (HDC hDC, int iAttribute, const int *piValue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglSetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
        private static TwglSetGammaTableParametersI3D wglSetGammaTableParametersI3D = null;

        // BOOL WINAPI wglGetGammaTableI3D (HDC hDC, int iEntries, USHORT *puRed, USHORT *puGreen, USHORT *puBlue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetGammaTableI3D(IntPtr hDC, int iEntries, ushort* puRed, ushort* puGreen, ushort* puBlue);
        private static TwglGetGammaTableI3D wglGetGammaTableI3D = null;

        // BOOL WINAPI wglSetGammaTableI3D (HDC hDC, int iEntries, const USHORT *puRed, const USHORT *puGreen, const USHORT *puBlue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglSetGammaTableI3D(IntPtr hDC, int iEntries, ushort* puRed, ushort* puGreen, ushort* puBlue);
        private static TwglSetGammaTableI3D wglSetGammaTableI3D = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_genlock
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglEnableGenlockI3D (HDC hDC);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglEnableGenlockI3D(IntPtr hDC);
        private static TwglEnableGenlockI3D wglEnableGenlockI3D = null;

        // BOOL WINAPI wglDisableGenlockI3D (HDC hDC);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglDisableGenlockI3D(IntPtr hDC);
        private static TwglDisableGenlockI3D wglDisableGenlockI3D = null;

        // BOOL WINAPI wglIsEnabledGenlockI3D (HDC hDC, BOOL *pFlag);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglIsEnabledGenlockI3D(IntPtr hDC, bool* pFlag);
        private static TwglIsEnabledGenlockI3D wglIsEnabledGenlockI3D = null;

        // BOOL WINAPI wglGenlockSourceI3D (HDC hDC, UINT uSource);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglGenlockSourceI3D(IntPtr hDC, uint uSource);
        private static TwglGenlockSourceI3D wglGenlockSourceI3D = null;

        // BOOL WINAPI wglGetGenlockSourceI3D (HDC hDC, UINT *uSource);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetGenlockSourceI3D(IntPtr hDC, uint* uSource);
        private static TwglGetGenlockSourceI3D wglGetGenlockSourceI3D = null;

        // BOOL WINAPI wglGenlockSourceEdgeI3D (HDC hDC, UINT uEdge);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglGenlockSourceEdgeI3D(IntPtr hDC, uint uEdge);
        private static TwglGenlockSourceEdgeI3D wglGenlockSourceEdgeI3D = null;

        // BOOL WINAPI wglGetGenlockSourceEdgeI3D (HDC hDC, UINT *uEdge);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetGenlockSourceEdgeI3D(IntPtr hDC, uint* uEdge);
        private static TwglGetGenlockSourceEdgeI3D wglGetGenlockSourceEdgeI3D = null;

        // BOOL WINAPI wglGenlockSampleRateI3D (HDC hDC, UINT uRate);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglGenlockSampleRateI3D(IntPtr hDC, uint uRate);
        private static TwglGenlockSampleRateI3D wglGenlockSampleRateI3D = null;

        // BOOL WINAPI wglGetGenlockSampleRateI3D (HDC hDC, UINT *uRate);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetGenlockSampleRateI3D(IntPtr hDC, uint* uRate);
        private static TwglGetGenlockSampleRateI3D wglGetGenlockSampleRateI3D = null;

        // BOOL WINAPI wglGenlockSourceDelayI3D (HDC hDC, UINT uDelay);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglGenlockSourceDelayI3D(IntPtr hDC, uint uDelay);
        private static TwglGenlockSourceDelayI3D wglGenlockSourceDelayI3D = null;

        // BOOL WINAPI wglGetGenlockSourceDelayI3D (HDC hDC, UINT *uDelay);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetGenlockSourceDelayI3D(IntPtr hDC, uint* uDelay);
        private static TwglGetGenlockSourceDelayI3D wglGetGenlockSourceDelayI3D = null;

        // BOOL WINAPI wglQueryGenlockMaxSourceDelayI3D (HDC hDC, UINT *uMaxLineDelay, UINT *uMaxPixelDelay);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglQueryGenlockMaxSourceDelayI3D(IntPtr hDC, uint* uMaxLineDelay, uint* uMaxPixelDelay);
        private static TwglQueryGenlockMaxSourceDelayI3D wglQueryGenlockMaxSourceDelayI3D = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_image_buffer
        ///////////////////////////////////////////////////////////////////////
        // LPVOID WINAPI wglCreateImageBufferI3D (HDC hDC, DWORD dwSize, UINT uFlags);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate void* TwglCreateImageBufferI3D(IntPtr hDC, uint dwSize, uint uFlags);
        private static TwglCreateImageBufferI3D wglCreateImageBufferI3D = null;

        // BOOL WINAPI wglDestroyImageBufferI3D (HDC hDC, LPVOID pAddress);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglDestroyImageBufferI3D(IntPtr hDC, void* pAddress);
        private static TwglDestroyImageBufferI3D wglDestroyImageBufferI3D = null;

        // BOOL WINAPI wglAssociateImageBufferEventsI3D (HDC hDC, const HANDLE *pEvent, const LPVOID *pAddress, const DWORD *pSize, UINT count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr* pEvent, void** pAddress, uint* pSize, uint count);
        private static TwglAssociateImageBufferEventsI3D wglAssociateImageBufferEventsI3D = null;

        // BOOL WINAPI wglReleaseImageBufferEventsI3D (HDC hDC, const LPVOID *pAddress, UINT count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglReleaseImageBufferEventsI3D(IntPtr hDC, void** pAddress, uint count);
        private static TwglReleaseImageBufferEventsI3D wglReleaseImageBufferEventsI3D = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_swap_frame_lock
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglEnableFrameLockI3D (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglEnableFrameLockI3D();
        private static TwglEnableFrameLockI3D wglEnableFrameLockI3D = null;

        // BOOL WINAPI wglDisableFrameLockI3D (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglDisableFrameLockI3D();
        private static TwglDisableFrameLockI3D wglDisableFrameLockI3D = null;

        // BOOL WINAPI wglIsEnabledFrameLockI3D (BOOL *pFlag);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglIsEnabledFrameLockI3D(bool* pFlag);
        private static TwglIsEnabledFrameLockI3D wglIsEnabledFrameLockI3D = null;

        // BOOL WINAPI wglQueryFrameLockMasterI3D (BOOL *pFlag);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglQueryFrameLockMasterI3D(bool* pFlag);
        private static TwglQueryFrameLockMasterI3D wglQueryFrameLockMasterI3D = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_swap_frame_usage
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglGetFrameUsageI3D (float *pUsage);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetFrameUsageI3D(float* pUsage);
        private static TwglGetFrameUsageI3D wglGetFrameUsageI3D = null;

        // BOOL WINAPI wglBeginFrameTrackingI3D (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglBeginFrameTrackingI3D();
        private static TwglBeginFrameTrackingI3D wglBeginFrameTrackingI3D = null;

        // BOOL WINAPI wglEndFrameTrackingI3D (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglEndFrameTrackingI3D();
        private static TwglEndFrameTrackingI3D wglEndFrameTrackingI3D = null;

        // BOOL WINAPI wglQueryFrameTrackingI3D (DWORD *pFrameCount, DWORD *pMissedFrames, float *pLastMissedUsage);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglQueryFrameTrackingI3D(uint* pFrameCount, uint* pMissedFrames, float* pLastMissedUsage);
        private static TwglQueryFrameTrackingI3D wglQueryFrameTrackingI3D = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_NV_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_copy_image
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglCopyImageSubDataNV (HGLRC hSrcRC, GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, HGLRC hDstRC, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglCopyImageSubDataNV(IntPtr hSrcRC, GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, IntPtr hDstRC, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth);
        private static TwglCopyImageSubDataNV wglCopyImageSubDataNV = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_delay_before_swap
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglDelayBeforeSwapNV (HDC hDC, GLfloat seconds);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglDelayBeforeSwapNV(IntPtr hDC, GLfloat seconds);
        private static TwglDelayBeforeSwapNV wglDelayBeforeSwapNV = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_DX_interop
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglDXSetResourceShareHandleNV (void *dxObject, HANDLE shareHandle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglDXSetResourceShareHandleNV(void* dxObject, IntPtr shareHandle);
        private static TwglDXSetResourceShareHandleNV wglDXSetResourceShareHandleNV = null;

        // HANDLE WINAPI wglDXOpenDeviceNV (void *dxDevice);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate IntPtr TwglDXOpenDeviceNV(void* dxDevice);
        private static TwglDXOpenDeviceNV wglDXOpenDeviceNV = null;

        // BOOL WINAPI wglDXCloseDeviceNV (HANDLE hDevice);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglDXCloseDeviceNV(IntPtr hDevice);
        private static TwglDXCloseDeviceNV wglDXCloseDeviceNV = null;

        // HANDLE WINAPI wglDXRegisterObjectNV (HANDLE hDevice, void *dxObject, GLuint name, GLenum type, GLenum access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate IntPtr TwglDXRegisterObjectNV(IntPtr hDevice, void* dxObject, GLuint name, GLenum type, GLenum access);
        private static TwglDXRegisterObjectNV wglDXRegisterObjectNV = null;

        // BOOL WINAPI wglDXUnregisterObjectNV (HANDLE hDevice, HANDLE hObject);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglDXUnregisterObjectNV(IntPtr hDevice, IntPtr hObject);
        private static TwglDXUnregisterObjectNV wglDXUnregisterObjectNV = null;

        // BOOL WINAPI wglDXObjectAccessNV (HANDLE hObject, GLenum access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglDXObjectAccessNV(IntPtr hObject, GLenum access);
        private static TwglDXObjectAccessNV wglDXObjectAccessNV = null;

        // BOOL WINAPI wglDXLockObjectsNV (HANDLE hDevice, GLint count, HANDLE *hObjects);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglDXLockObjectsNV(IntPtr hDevice, GLint count, IntPtr* hObjects);
        private static TwglDXLockObjectsNV wglDXLockObjectsNV = null;

        // BOOL WINAPI wglDXUnlockObjectsNV (HANDLE hDevice, GLint count, HANDLE *hObjects);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglDXUnlockObjectsNV(IntPtr hDevice, GLint count, IntPtr* hObjects);
        private static TwglDXUnlockObjectsNV wglDXUnlockObjectsNV = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_DX_interop2 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_float_buffer (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_multisample_coverage (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_present_video
        ///////////////////////////////////////////////////////////////////////
        // int WINAPI wglEnumerateVideoDevicesNV (HDC hDC, HVIDEOOUTPUTDEVICENV *phDeviceList);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate int TwglEnumerateVideoDevicesNV(IntPtr hDC, IntPtr* phDeviceList);
        private static TwglEnumerateVideoDevicesNV wglEnumerateVideoDevicesNV = null;

        // BOOL WINAPI wglBindVideoDeviceNV (HDC hDC, unsigned int uVideoSlot, HVIDEOOUTPUTDEVICENV hVideoDevice, const int *piAttribList);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglBindVideoDeviceNV(IntPtr hDC, uint uVideoSlot, IntPtr hVideoDevice, int* piAttribList);
        private static TwglBindVideoDeviceNV wglBindVideoDeviceNV = null;

        // BOOL WINAPI wglQueryCurrentContextNV (int iAttribute, int *piValue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglQueryCurrentContextNV(int iAttribute, int* piValue);
        private static TwglQueryCurrentContextNV wglQueryCurrentContextNV = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglJoinSwapGroupNV(IntPtr hDC, GLuint group);
        private static TwglJoinSwapGroupNV wglJoinSwapGroupNV = null;

        // BOOL WINAPI wglBindSwapBarrierNV (GLuint group, GLuint barrier);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglBindSwapBarrierNV(GLuint group, GLuint barrier);
        private static TwglBindSwapBarrierNV wglBindSwapBarrierNV = null;

        // BOOL WINAPI wglQuerySwapGroupNV (HDC hDC, GLuint *group, GLuint *barrier);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglQuerySwapGroupNV(IntPtr hDC, GLuint* group, GLuint* barrier);
        private static TwglQuerySwapGroupNV wglQuerySwapGroupNV = null;

        // BOOL WINAPI wglQueryMaxSwapGroupsNV (HDC hDC, GLuint *maxGroups, GLuint *maxBarriers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglQueryMaxSwapGroupsNV(IntPtr hDC, GLuint* maxGroups, GLuint* maxBarriers);
        private static TwglQueryMaxSwapGroupsNV wglQueryMaxSwapGroupsNV = null;

        // BOOL WINAPI wglQueryFrameCountNV (HDC hDC, GLuint *count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglQueryFrameCountNV(IntPtr hDC, GLuint* count);
        private static TwglQueryFrameCountNV wglQueryFrameCountNV = null;

        // BOOL WINAPI wglResetFrameCountNV (HDC hDC);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglResetFrameCountNV(IntPtr hDC);
        private static TwglResetFrameCountNV wglResetFrameCountNV = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_vertex_array_range
        ///////////////////////////////////////////////////////////////////////
        // void *WINAPI wglAllocateMemoryNV (GLsizei size, GLfloat readfreq, GLfloat writefreq, GLfloat priority);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate void* TwglAllocateMemoryNV(GLsizei size, GLfloat readfreq, GLfloat writefreq, GLfloat priority);
        private static TwglAllocateMemoryNV wglAllocateMemoryNV = null;

        // void WINAPI wglFreeMemoryNV (void *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate void TwglFreeMemoryNV(void* pointer);
        private static TwglFreeMemoryNV wglFreeMemoryNV = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_video_capture
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglBindVideoCaptureDeviceNV (UINT uVideoSlot, HVIDEOINPUTDEVICENV hDevice);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglBindVideoCaptureDeviceNV(uint uVideoSlot, IntPtr hDevice);
        private static TwglBindVideoCaptureDeviceNV wglBindVideoCaptureDeviceNV = null;

        // UINT WINAPI wglEnumerateVideoCaptureDevicesNV (HDC hDc, HVIDEOINPUTDEVICENV *phDeviceList);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate uint TwglEnumerateVideoCaptureDevicesNV(IntPtr hDC, IntPtr* phDeviceList);
        private static TwglEnumerateVideoCaptureDevicesNV wglEnumerateVideoCaptureDevicesNV = null;

        // BOOL WINAPI wglLockVideoCaptureDeviceNV (HDC hDc, HVIDEOINPUTDEVICENV hDevice);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglLockVideoCaptureDeviceNV(IntPtr hDC, IntPtr hDevice);
        private static TwglLockVideoCaptureDeviceNV wglLockVideoCaptureDeviceNV = null;

        // BOOL WINAPI wglQueryVideoCaptureDeviceNV (HDC hDc, HVIDEOINPUTDEVICENV hDevice, int iAttribute, int *piValue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglQueryVideoCaptureDeviceNV(IntPtr hDC, IntPtr hDevice, int iAttribute, int* piValue);
        private static TwglQueryVideoCaptureDeviceNV wglQueryVideoCaptureDeviceNV = null;

        // BOOL WINAPI wglReleaseVideoCaptureDeviceNV (HDC hDc, HVIDEOINPUTDEVICENV hDevice);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglReleaseVideoCaptureDeviceNV(IntPtr hDC, IntPtr hDevice);
        private static TwglReleaseVideoCaptureDeviceNV wglReleaseVideoCaptureDeviceNV = null;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_video_output
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglGetVideoDeviceNV (HDC hDC, int numDevices, HPVIDEODEV *hVideoDevice);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetVideoDeviceNV(IntPtr hDC, int numDevices, IntPtr* hVideoDevice);
        private static TwglGetVideoDeviceNV wglGetVideoDeviceNV = null;

        // BOOL WINAPI wglReleaseVideoDeviceNV (HPVIDEODEV hVideoDevice);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglReleaseVideoDeviceNV(IntPtr hVideoDevice);
        private static TwglReleaseVideoDeviceNV wglReleaseVideoDeviceNV = null;

        // BOOL WINAPI wglBindVideoImageNV (HPVIDEODEV hVideoDevice, HPBUFFERARB hPbuffer, int iVideoBuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglBindVideoImageNV(IntPtr hVideoDevice, IntPtr hPbuffer, int iVideoBuffer);
        private static TwglBindVideoImageNV wglBindVideoImageNV = null;

        // BOOL WINAPI wglReleaseVideoImageNV (HPBUFFERARB hPbuffer, int iVideoBuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglReleaseVideoImageNV(IntPtr hPbuffer, int iVideoBuffer);
        private static TwglReleaseVideoImageNV wglReleaseVideoImageNV = null;

        // BOOL WINAPI wglSendPbufferToVideoNV (HPBUFFERARB hPbuffer, int iBufferType, unsigned long *pulCounterPbuffer, BOOL bBlock);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglSendPbufferToVideoNV(IntPtr hPbuffer, int iBufferType, uint* pulCounterPbuffer, bool bBlock);
        private static TwglSendPbufferToVideoNV wglSendPbufferToVideoNV = null;

        // BOOL WINAPI wglGetVideoInfoNV (HPVIDEODEV hpVideoDevice, unsigned long *pulCounterOutputPbuffer, unsigned long *pulCounterOutputVideo);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetVideoInfoNV(IntPtr hpVideoDevice, uint* pulCounterOutputPbuffer, uint* pulCounterOutputVideo);
        private static TwglGetVideoInfoNV wglGetVideoInfoNV = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_OML_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_OML_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_OML_sync_control
        ///////////////////////////////////////////////////////////////////////
        // BOOL WINAPI wglGetSyncValuesOML (HDC hdc, INT64 *ust, INT64 *msc, INT64 *sbc);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetSyncValuesOML(IntPtr hdc, Int64* ust, Int64* msc, Int64* sbc);
        private static TwglGetSyncValuesOML wglGetSyncValuesOML = null;

        // BOOL WINAPI wglGetMscRateOML (HDC hdc, INT32 *numerator, INT32 *denominator);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglGetMscRateOML(IntPtr hdc, Int32* numerator, Int32* denominator);
        private static TwglGetMscRateOML wglGetMscRateOML = null;

        // INT64 WINAPI wglSwapBuffersMscOML (HDC hdc, INT64 target_msc, INT64 divisor, INT64 remainder);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate Int64 TwglSwapBuffersMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder);
        private static TwglSwapBuffersMscOML wglSwapBuffersMscOML = null;

        // INT64 WINAPI wglSwapLayerBuffersMscOML (HDC hdc, int fuPlanes, INT64 target_msc, INT64 divisor, INT64 remainder);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate Int64 TwglSwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder);
        private static TwglSwapLayerBuffersMscOML wglSwapLayerBuffersMscOML = null;

        // BOOL WINAPI wglWaitForMscOML (HDC hdc, INT64 target_msc, INT64 divisor, INT64 remainder, INT64 *ust, INT64 *msc, INT64 *sbc);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglWaitForMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, Int64* ust, Int64* msc, Int64* sbc);
        private static TwglWaitForMscOML wglWaitForMscOML = null;

        // BOOL WINAPI wglWaitForSbcOML (HDC hdc, INT64 target_sbc, INT64 *ust, INT64 *msc, INT64 *sbc);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate bool TwglWaitForSbcOML(IntPtr hdc, Int64 target_sbc, Int64* ust, Int64* msc, Int64* sbc);
        private static TwglWaitForSbcOML wglWaitForSbcOML = null;

        #endregion
    }
}
