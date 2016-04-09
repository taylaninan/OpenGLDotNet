using System;
using System.Runtime.InteropServices;

namespace OpenGLDotNet
{
    public static partial class WGL
    {
        private static void LinkLibWGLEXT()
        {
            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking Supported (GPU+LIB) WGL Extension functions...");
            GLConfig.LogWriteLine("============================================================");

            ///////////////////////////////////////////////////////////////////////
            // WGL_3DFX_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region WGL_3DFX_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // WGL_3DFX_multisample (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_3DFX_multisample"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // WGL_3DL_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region WGL_3DL_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // WGL_3DL_stereo_control
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_3DL_stereo_control"))
            {
                if (LinkProcWGLEXT("wglSetStereoEmitterState3DL"))
                {
                    wglSetStereoEmitterState3DL = (TwglSetStereoEmitterState3DL)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSetStereoEmitterState3DL));
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
            if (LinkWGLEXT("WGL_AMD_gpu_association"))
            {
                if (LinkProcWGLEXT("wglGetGPUIDsAMD"))
                {
                    wglGetGPUIDsAMD = (TwglGetGPUIDsAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetGPUIDsAMD));
                }

                if (LinkProcWGLEXT("wglGetGPUInfoAMD"))
                {
                    wglGetGPUInfoAMD = (TwglGetGPUInfoAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetGPUInfoAMD));
                }

                if (LinkProcWGLEXT("wglGetContextGPUIDAMD"))
                {
                    wglGetContextGPUIDAMD = (TwglGetContextGPUIDAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetContextGPUIDAMD));
                }

                if (LinkProcWGLEXT("wglCreateAssociatedContextAMD"))
                {
                    wglCreateAssociatedContextAMD = (TwglCreateAssociatedContextAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglCreateAssociatedContextAMD));
                }

                if (LinkProcWGLEXT("wglCreateAssociatedContextAttribsAMD"))
                {
                    wglCreateAssociatedContextAttribsAMD = (TwglCreateAssociatedContextAttribsAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglCreateAssociatedContextAttribsAMD));
                }

                if (LinkProcWGLEXT("wglDeleteAssociatedContextAMD"))
                {
                    wglDeleteAssociatedContextAMD = (TwglDeleteAssociatedContextAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDeleteAssociatedContextAMD));
                }

                if (LinkProcWGLEXT("wglMakeAssociatedContextCurrentAMD"))
                {
                    wglMakeAssociatedContextCurrentAMD = (TwglMakeAssociatedContextCurrentAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglMakeAssociatedContextCurrentAMD));
                }

                if (LinkProcWGLEXT("wglGetCurrentAssociatedContextAMD"))
                {
                    wglGetCurrentAssociatedContextAMD = (TwglGetCurrentAssociatedContextAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetCurrentAssociatedContextAMD));
                }

                if (LinkProcWGLEXT("wglBlitContextFramebufferAMD"))
                {
                    wglBlitContextFramebufferAMD = (TwglBlitContextFramebufferAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglBlitContextFramebufferAMD));
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
            if (LinkWGLEXT("WGL_ARB_buffer_region"))
            {
                if (LinkProcWGLEXT("wglCreateBufferRegionARB"))
                {
                    wglCreateBufferRegionARB = (TwglCreateBufferRegionARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglCreateBufferRegionARB));
                }

                if (LinkProcWGLEXT("wglDeleteBufferRegionARB"))
                {
                    wglDeleteBufferRegionARB = (TwglDeleteBufferRegionARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDeleteBufferRegionARB));
                }

                if (LinkProcWGLEXT("wglSaveBufferRegionARB"))
                {
                    wglSaveBufferRegionARB = (TwglSaveBufferRegionARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSaveBufferRegionARB));
                }

                if (LinkProcWGLEXT("wglRestoreBufferRegionARB"))
                {
                    wglRestoreBufferRegionARB = (TwglRestoreBufferRegionARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglRestoreBufferRegionARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_context_flush_control (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_context_flush_control"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_create_context
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_create_context"))
            {
                if (LinkProcWGLEXT("wglCreateContextAttribsARB"))
                {
                    wglCreateContextAttribsARB = (TwglCreateContextAttribsARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglCreateContextAttribsARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_create_context_profile (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_create_context_profile"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_create_context_robustness (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_create_context_robustness"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_extensions_string
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_extensions_string"))
            {
                if (LinkProcWGLEXT("wglGetExtensionsStringARB"))
                {
                    wglGetExtensionsStringARB = (TwglGetExtensionsStringARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetExtensionsStringARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_framebuffer_sRGB (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_framebuffer_sRGB"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_make_current_read
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_make_current_read"))
            {
                if (LinkProcWGLEXT("wglMakeContextCurrentARB"))
                {
                    wglMakeContextCurrentARB = (TwglMakeContextCurrentARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglMakeContextCurrentARB));
                }

                if (LinkProcWGLEXT("wglGetCurrentReadDCARB"))
                {
                    wglGetCurrentReadDCARB = (TwglGetCurrentReadDCARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetCurrentReadDCARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_multisample (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_multisample"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_pbuffer
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_pbuffer"))
            {
                if (LinkProcWGLEXT("wglCreatePbufferARB"))
                {
                    wglCreatePbufferARB = (TwglCreatePbufferARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglCreatePbufferARB));
                }

                if (LinkProcWGLEXT("wglGetPbufferDCARB"))
                {
                    wglGetPbufferDCARB = (TwglGetPbufferDCARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetPbufferDCARB));
                }

                if (LinkProcWGLEXT("wglReleasePbufferDCARB"))
                {
                    wglReleasePbufferDCARB = (TwglReleasePbufferDCARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglReleasePbufferDCARB));
                }

                if (LinkProcWGLEXT("wglDestroyPbufferARB"))
                {
                    wglDestroyPbufferARB = (TwglDestroyPbufferARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDestroyPbufferARB));
                }

                if (LinkProcWGLEXT("wglQueryPbufferARB"))
                {
                    wglQueryPbufferARB = (TwglQueryPbufferARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglQueryPbufferARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_pixel_format
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_pixel_format"))
            {
                if (LinkProcWGLEXT("wglGetPixelFormatAttribivARB"))
                {
                    wglGetPixelFormatAttribivARB = (TwglGetPixelFormatAttribivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetPixelFormatAttribivARB));
                }

                if (LinkProcWGLEXT("wglGetPixelFormatAttribfvARB"))
                {
                    wglGetPixelFormatAttribfvARB = (TwglGetPixelFormatAttribfvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetPixelFormatAttribfvARB));
                }

                if (LinkProcWGLEXT("wglChoosePixelFormatARB"))
                {
                    wglChoosePixelFormatARB = (TwglChoosePixelFormatARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglChoosePixelFormatARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_pixel_format_float (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_pixel_format_float"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_render_texture
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_render_texture"))
            {
                if (LinkProcWGLEXT("wglBindTexImageARB"))
                {
                    wglBindTexImageARB = (TwglBindTexImageARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglBindTexImageARB));
                }

                if (LinkProcWGLEXT("wglReleaseTexImageARB"))
                {
                    wglReleaseTexImageARB = (TwglReleaseTexImageARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglReleaseTexImageARB));
                }

                if (LinkProcWGLEXT("wglSetPbufferAttribARB"))
                {
                    wglSetPbufferAttribARB = (TwglSetPbufferAttribARB)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSetPbufferAttribARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_robustness_application_isolation (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_robustness_application_isolation"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_ARB_robustness_share_group_isolation (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ARB_robustness_share_group_isolation"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // WGL_ATI_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region WGL_ATI_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // WGL_ATI_pixel_format_float (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_ATI_pixel_format_float"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region WGL_EXT_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_create_context_es_profile (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_EXT_create_context_es_profile"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_create_context_es_profile (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_EXT_create_context_es2_profile"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_depth_float (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_EXT_depth_float"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_display_color_table
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_EXT_display_color_table"))
            {
                if (LinkProcWGLEXT("wglCreateDisplayColorTableEXT"))
                {
                    wglCreateDisplayColorTableEXT = (TwglCreateDisplayColorTableEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglCreateDisplayColorTableEXT));
                }

                if (LinkProcWGLEXT("wglLoadDisplayColorTableEXT"))
                {
                    wglLoadDisplayColorTableEXT = (TwglLoadDisplayColorTableEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglLoadDisplayColorTableEXT));
                }

                if (LinkProcWGLEXT("wglBindDisplayColorTableEXT"))
                {
                    wglBindDisplayColorTableEXT = (TwglBindDisplayColorTableEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglBindDisplayColorTableEXT));
                }

                if (LinkProcWGLEXT("wglDestroyDisplayColorTableEXT"))
                {
                    wglDestroyDisplayColorTableEXT = (TwglDestroyDisplayColorTableEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDestroyDisplayColorTableEXT));
                }

            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_extensions_string
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_EXT_extensions_string"))
            {
                if (LinkProcWGLEXT("wglGetExtensionsStringEXT"))
                {
                    wglGetExtensionsStringEXT = (TwglGetExtensionsStringEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetExtensionsStringEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_framebuffer_sRGB (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_EXT_framebuffer_sRGB"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_make_current_read
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_EXT_make_current_read"))
            {
                if (LinkProcWGLEXT("wglMakeContextCurrentEXT"))
                {
                    wglMakeContextCurrentEXT = (TwglMakeContextCurrentEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglMakeContextCurrentEXT));
                }

                if (LinkProcWGLEXT("wglGetCurrentReadDCEXT"))
                {
                    wglGetCurrentReadDCEXT = (TwglGetCurrentReadDCEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetCurrentReadDCEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_multisample (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_EXT_multisample"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_pbuffer
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_EXT_pbuffer"))
            {
                if (LinkProcWGLEXT("wglCreatePbufferEXT"))
                {
                    wglCreatePbufferEXT = (TwglCreatePbufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglCreatePbufferEXT));
                }

                if (LinkProcWGLEXT("wglGetPbufferDCEXT"))
                {
                    wglGetPbufferDCEXT = (TwglGetPbufferDCEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetPbufferDCEXT));
                }

                if (LinkProcWGLEXT("wglReleasePbufferDCEXT"))
                {
                    wglReleasePbufferDCEXT = (TwglReleasePbufferDCEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglReleasePbufferDCEXT));
                }

                if (LinkProcWGLEXT("wglDestroyPbufferEXT"))
                {
                    wglDestroyPbufferEXT = (TwglDestroyPbufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDestroyPbufferEXT));
                }

                if (LinkProcWGLEXT("wglQueryPbufferEXT"))
                {
                    wglQueryPbufferEXT = (TwglQueryPbufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglQueryPbufferEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_pixel_format
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_EXT_pixel_format"))
            {
                if (LinkProcWGLEXT("wglGetPixelFormatAttribivEXT"))
                {
                    wglGetPixelFormatAttribivEXT = (TwglGetPixelFormatAttribivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetPixelFormatAttribivEXT));
                }

                if (LinkProcWGLEXT("wglGetPixelFormatAttribfvEXT"))
                {
                    wglGetPixelFormatAttribfvEXT = (TwglGetPixelFormatAttribfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetPixelFormatAttribfvEXT));
                }

                if (LinkProcWGLEXT("wglChoosePixelFormatEXT"))
                {
                    wglChoosePixelFormatEXT = (TwglChoosePixelFormatEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglChoosePixelFormatEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_pixel_format_packed_float (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_EXT_pixel_format_packed_float"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_swap_control
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_EXT_swap_control"))
            {
                if (LinkProcWGLEXT("wglSwapIntervalEXT"))
                {
                    wglSwapIntervalEXT = (TwglSwapIntervalEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSwapIntervalEXT));
                }

                if (LinkProcWGLEXT("wglGetSwapIntervalEXT"))
                {
                    wglGetSwapIntervalEXT = (TwglGetSwapIntervalEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetSwapIntervalEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_EXT_swap_control_tear (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_EXT_swap_control_tear"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // WGL_I3D_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region WGL_I3D_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // WGL_I3D_digital_video_control
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_I3D_digital_video_control"))
            {
                if (LinkProcWGLEXT("wglGetDigitalVideoParametersI3D"))
                {
                    wglGetDigitalVideoParametersI3D = (TwglGetDigitalVideoParametersI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetDigitalVideoParametersI3D));
                }

                if (LinkProcWGLEXT("wglSetDigitalVideoParametersI3D"))
                {
                    wglSetDigitalVideoParametersI3D = (TwglSetDigitalVideoParametersI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSetDigitalVideoParametersI3D));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_I3D_gamma
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_I3D_gamma"))
            {
                if (LinkProcWGLEXT("wglGetGammaTableParametersI3D"))
                {
                    wglGetGammaTableParametersI3D = (TwglGetGammaTableParametersI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetGammaTableParametersI3D));
                }

                if (LinkProcWGLEXT("wglSetGammaTableParametersI3D"))
                {
                    wglSetGammaTableParametersI3D = (TwglSetGammaTableParametersI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSetGammaTableParametersI3D));
                }

                if (LinkProcWGLEXT("wglGetGammaTableI3D"))
                {
                    wglGetGammaTableI3D = (TwglGetGammaTableI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetGammaTableI3D));
                }

                if (LinkProcWGLEXT("wglSetGammaTableI3D"))
                {
                    wglSetGammaTableI3D = (TwglSetGammaTableI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSetGammaTableI3D));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_I3D_genlock
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_I3D_genlock"))
            {
                if (LinkProcWGLEXT("wglEnableGenlockI3D"))
                {
                    wglEnableGenlockI3D = (TwglEnableGenlockI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglEnableGenlockI3D));
                }

                if (LinkProcWGLEXT("wglDisableGenlockI3D"))
                {
                    wglDisableGenlockI3D = (TwglDisableGenlockI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDisableGenlockI3D));
                }

                if (LinkProcWGLEXT("wglIsEnabledGenlockI3D"))
                {
                    wglIsEnabledGenlockI3D = (TwglIsEnabledGenlockI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglIsEnabledGenlockI3D));
                }

                if (LinkProcWGLEXT("wglGenlockSourceI3D"))
                {
                    wglGenlockSourceI3D = (TwglGenlockSourceI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGenlockSourceI3D));
                }

                if (LinkProcWGLEXT("wglGetGenlockSourceI3D"))
                {
                    wglGetGenlockSourceI3D = (TwglGetGenlockSourceI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetGenlockSourceI3D));
                }

                if (LinkProcWGLEXT("wglGenlockSourceEdgeI3D"))
                {
                    wglGenlockSourceEdgeI3D = (TwglGenlockSourceEdgeI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGenlockSourceEdgeI3D));
                }

                if (LinkProcWGLEXT("wglGetGenlockSourceEdgeI3D"))
                {
                    wglGetGenlockSourceEdgeI3D = (TwglGetGenlockSourceEdgeI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetGenlockSourceEdgeI3D));
                }

                if (LinkProcWGLEXT("wglGenlockSampleRateI3D"))
                {
                    wglGenlockSampleRateI3D = (TwglGenlockSampleRateI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGenlockSampleRateI3D));
                }

                if (LinkProcWGLEXT("wglGetGenlockSampleRateI3D"))
                {
                    wglGetGenlockSampleRateI3D = (TwglGetGenlockSampleRateI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetGenlockSampleRateI3D));
                }

                if (LinkProcWGLEXT("wglGenlockSourceDelayI3D"))
                {
                    wglGenlockSourceDelayI3D = (TwglGenlockSourceDelayI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGenlockSourceDelayI3D));
                }

                if (LinkProcWGLEXT("wglGetGenlockSourceDelayI3D"))
                {
                    wglGetGenlockSourceDelayI3D = (TwglGetGenlockSourceDelayI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetGenlockSourceDelayI3D));
                }

                if (LinkProcWGLEXT("wglQueryGenlockMaxSourceDelayI3D"))
                {
                    wglQueryGenlockMaxSourceDelayI3D = (TwglQueryGenlockMaxSourceDelayI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglQueryGenlockMaxSourceDelayI3D));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_I3D_image_buffer
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_I3D_image_buffer"))
            {
                if (LinkProcWGLEXT("wglCreateImageBufferI3D"))
                {
                    wglCreateImageBufferI3D = (TwglCreateImageBufferI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglCreateImageBufferI3D));
                }

                if (LinkProcWGLEXT("wglDestroyImageBufferI3D"))
                {
                    wglDestroyImageBufferI3D = (TwglDestroyImageBufferI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDestroyImageBufferI3D));
                }

                if (LinkProcWGLEXT("wglAssociateImageBufferEventsI3D"))
                {
                    wglAssociateImageBufferEventsI3D = (TwglAssociateImageBufferEventsI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglAssociateImageBufferEventsI3D));
                }

                if (LinkProcWGLEXT("wglReleaseImageBufferEventsI3D"))
                {
                    wglReleaseImageBufferEventsI3D = (TwglReleaseImageBufferEventsI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglReleaseImageBufferEventsI3D));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_I3D_swap_frame_lock
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_I3D_swap_frame_lock"))
            {
                if (LinkProcWGLEXT("wglEnableFrameLockI3D"))
                {
                    wglEnableFrameLockI3D = (TwglEnableFrameLockI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglEnableFrameLockI3D));
                }

                if (LinkProcWGLEXT("wglDisableFrameLockI3D"))
                {
                    wglDisableFrameLockI3D = (TwglDisableFrameLockI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDisableFrameLockI3D));
                }

                if (LinkProcWGLEXT("wglIsEnabledFrameLockI3D"))
                {
                    wglIsEnabledFrameLockI3D = (TwglIsEnabledFrameLockI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglIsEnabledFrameLockI3D));
                }

                if (LinkProcWGLEXT("wglQueryFrameLockMasterI3D"))
                {
                    wglQueryFrameLockMasterI3D = (TwglQueryFrameLockMasterI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglQueryFrameLockMasterI3D));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_I3D_swap_frame_usage
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_I3D_swap_frame_usage"))
            {
                if (LinkProcWGLEXT("wglGetFrameUsageI3D"))
                {
                    wglGetFrameUsageI3D = (TwglGetFrameUsageI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetFrameUsageI3D));
                }

                if (LinkProcWGLEXT("wglBeginFrameTrackingI3D"))
                {
                    wglBeginFrameTrackingI3D = (TwglBeginFrameTrackingI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglBeginFrameTrackingI3D));
                }

                if (LinkProcWGLEXT("wglEndFrameTrackingI3D"))
                {
                    wglEndFrameTrackingI3D = (TwglEndFrameTrackingI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglEndFrameTrackingI3D));
                }

                if (LinkProcWGLEXT("wglQueryFrameTrackingI3D"))
                {
                    wglQueryFrameTrackingI3D = (TwglQueryFrameTrackingI3D)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglQueryFrameTrackingI3D));
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
            if (LinkWGLEXT("WGL_NV_copy_image"))
            {
                if (LinkProcWGLEXT("wglCopyImageSubDataNV"))
                {
                    wglCopyImageSubDataNV = (TwglCopyImageSubDataNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglCopyImageSubDataNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_NV_delay_before_swap
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_NV_delay_before_swap"))
            {
                if (LinkProcWGLEXT("wglDelayBeforeSwapNV"))
                {
                    wglDelayBeforeSwapNV = (TwglDelayBeforeSwapNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDelayBeforeSwapNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_NV_DX_interop
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_NV_DX_interop"))
            {
                if (LinkProcWGLEXT("wglDXSetResourceShareHandleNV"))
                {
                    wglDXSetResourceShareHandleNV = (TwglDXSetResourceShareHandleNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDXSetResourceShareHandleNV));
                }

                if (LinkProcWGLEXT("wglDXOpenDeviceNV"))
                {
                    wglDXOpenDeviceNV = (TwglDXOpenDeviceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDXOpenDeviceNV));
                }

                if (LinkProcWGLEXT("wglDXCloseDeviceNV"))
                {
                    wglDXCloseDeviceNV = (TwglDXCloseDeviceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDXCloseDeviceNV));
                }

                if (LinkProcWGLEXT("wglDXRegisterObjectNV"))
                {
                    wglDXRegisterObjectNV = (TwglDXRegisterObjectNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDXRegisterObjectNV));
                }

                if (LinkProcWGLEXT("wglDXUnregisterObjectNV"))
                {
                    wglDXUnregisterObjectNV = (TwglDXUnregisterObjectNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDXUnregisterObjectNV));
                }

                if (LinkProcWGLEXT("wglDXObjectAccessNV"))
                {
                    wglDXObjectAccessNV = (TwglDXObjectAccessNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDXObjectAccessNV));
                }

                if (LinkProcWGLEXT("wglDXLockObjectsNV"))
                {
                    wglDXLockObjectsNV = (TwglDXLockObjectsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDXLockObjectsNV));
                }

                if (LinkProcWGLEXT("wglDXUnlockObjectsNV"))
                {
                    wglDXUnlockObjectsNV = (TwglDXUnlockObjectsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglDXUnlockObjectsNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_NV_DX_interop2 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_NV_DX_interop2"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_NV_float_buffer (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_NV_float_buffer"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_NV_gpu_affinity (TODO: SKIPPED FOR NOW!!!)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_NV_gpu_affinity"))
            {
                // BOOL WINAPI wglEnumGpusNV(UINT iGpuIndex, HGPUNV* phGpu);
                // BOOL WINAPI wglEnumGpuDevicesNV(HGPUNV hGpu, UINT iDeviceIndex, PGPU_DEVICE lpGpuDevice);
                // HDC WINAPI wglCreateAffinityDCNV(const HGPUNV* phGpuList);
                // BOOL WINAPI wglEnumGpusFromAffinityDCNV(HDC hAffinityDC, UINT iGpuIndex, HGPUNV* hGpu);
                // BOOL WINAPI wglDeleteDCNV(HDC hdc);
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_NV_multisample_coverage (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_NV_multisample_coverage"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_NV_present_video
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_NV_present_video"))
            {
                if (LinkProcWGLEXT("wglEnumerateVideoDevicesNV"))
                {
                    wglEnumerateVideoDevicesNV = (TwglEnumerateVideoDevicesNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglEnumerateVideoDevicesNV));
                }

                if (LinkProcWGLEXT("wglBindVideoDeviceNV"))
                {
                    wglBindVideoDeviceNV = (TwglBindVideoDeviceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglBindVideoDeviceNV));
                }

                if (LinkProcWGLEXT("wglQueryCurrentContextNV"))
                {
                    wglQueryCurrentContextNV = (TwglQueryCurrentContextNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglQueryCurrentContextNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_NV_render_depth_texture (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_NV_render_depth_texture"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_NV_render_texture_rectangle (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_NV_render_texture_rectangle"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_NV_swap_group
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_NV_swap_group"))
            {
                if (LinkProcWGLEXT("wglJoinSwapGroupNV"))
                {
                    wglJoinSwapGroupNV = (TwglJoinSwapGroupNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglJoinSwapGroupNV));
                }

                if (LinkProcWGLEXT("wglBindSwapBarrierNV"))
                {
                    wglBindSwapBarrierNV = (TwglBindSwapBarrierNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglBindSwapBarrierNV));
                }

                if (LinkProcWGLEXT("wglQuerySwapGroupNV"))
                {
                    wglQuerySwapGroupNV = (TwglQuerySwapGroupNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglQuerySwapGroupNV));
                }

                if (LinkProcWGLEXT("wglQueryMaxSwapGroupsNV"))
                {
                    wglQueryMaxSwapGroupsNV = (TwglQueryMaxSwapGroupsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglQueryMaxSwapGroupsNV));
                }

                if (LinkProcWGLEXT("wglQueryFrameCountNV"))
                {
                    wglQueryFrameCountNV = (TwglQueryFrameCountNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglQueryFrameCountNV));
                }

                if (LinkProcWGLEXT("wglResetFrameCountNV"))
                {
                    wglResetFrameCountNV = (TwglResetFrameCountNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglResetFrameCountNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_NV_vertex_array_range
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_NV_vertex_array_range"))
            {
                if (LinkProcWGLEXT("wglAllocateMemoryNV"))
                {
                    wglAllocateMemoryNV = (TwglAllocateMemoryNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglAllocateMemoryNV));
                }

                if (LinkProcWGLEXT("wglFreeMemoryNV"))
                {
                    wglFreeMemoryNV = (TwglFreeMemoryNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglFreeMemoryNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_NV_video_capture
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_NV_video_capture"))
            {
                if (LinkProcWGLEXT("wglBindVideoCaptureDeviceNV"))
                {
                    wglBindVideoCaptureDeviceNV = (TwglBindVideoCaptureDeviceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglBindVideoCaptureDeviceNV));
                }

                if (LinkProcWGLEXT("wglEnumerateVideoCaptureDevicesNV"))
                {
                    wglEnumerateVideoCaptureDevicesNV = (TwglEnumerateVideoCaptureDevicesNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglEnumerateVideoCaptureDevicesNV));
                }

                if (LinkProcWGLEXT("wglLockVideoCaptureDeviceNV"))
                {
                    wglLockVideoCaptureDeviceNV = (TwglLockVideoCaptureDeviceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglLockVideoCaptureDeviceNV));
                }

                if (LinkProcWGLEXT("wglQueryVideoCaptureDeviceNV"))
                {
                    wglQueryVideoCaptureDeviceNV = (TwglQueryVideoCaptureDeviceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglQueryVideoCaptureDeviceNV));
                }

                if (LinkProcWGLEXT("wglReleaseVideoCaptureDeviceNV"))
                {
                    wglReleaseVideoCaptureDeviceNV = (TwglReleaseVideoCaptureDeviceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglReleaseVideoCaptureDeviceNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // WGL_NV_video_output
            ///////////////////////////////////////////////////////////////////////
            if (LinkWGLEXT("WGL_NV_video_capture"))
            {
                if (LinkProcWGLEXT("wglGetVideoDeviceNV"))
                {
                    wglGetVideoDeviceNV = (TwglGetVideoDeviceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetVideoDeviceNV));
                }

                if (LinkProcWGLEXT("wglReleaseVideoDeviceNV"))
                {
                    wglReleaseVideoDeviceNV = (TwglReleaseVideoDeviceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglReleaseVideoDeviceNV));
                }

                if (LinkProcWGLEXT("wglBindVideoImageNV"))
                {
                    wglBindVideoImageNV = (TwglBindVideoImageNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglBindVideoImageNV));
                }

                if (LinkProcWGLEXT("wglReleaseVideoImageNV"))
                {
                    wglReleaseVideoImageNV = (TwglReleaseVideoImageNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglReleaseVideoImageNV));
                }

                if (LinkProcWGLEXT("wglSendPbufferToVideoNV"))
                {
                    wglSendPbufferToVideoNV = (TwglSendPbufferToVideoNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSendPbufferToVideoNV));
                }

                if (LinkProcWGLEXT("wglGetVideoInfoNV"))
                {
                    wglGetVideoInfoNV = (TwglGetVideoInfoNV)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetVideoInfoNV));
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
            if (LinkWGLEXT("WGL_OML_sync_control"))
            {
                if (LinkProcWGLEXT("wglGetSyncValuesOML"))
                {
                    wglGetSyncValuesOML = (TwglGetSyncValuesOML)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetSyncValuesOML));
                }

                if (LinkProcWGLEXT("wglGetMscRateOML"))
                {
                    wglGetMscRateOML = (TwglGetMscRateOML)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglGetMscRateOML));
                }

                if (LinkProcWGLEXT("wglSwapBuffersMscOML"))
                {
                    wglSwapBuffersMscOML = (TwglSwapBuffersMscOML)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSwapBuffersMscOML));
                }

                if (LinkProcWGLEXT("wglSwapLayerBuffersMscOML"))
                {
                    wglSwapLayerBuffersMscOML = (TwglSwapLayerBuffersMscOML)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglSwapLayerBuffersMscOML));
                }

                if (LinkProcWGLEXT("wglWaitForMscOML"))
                {
                    wglWaitForMscOML = (TwglWaitForMscOML)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglWaitForMscOML));
                }

                if (LinkProcWGLEXT("wglWaitForSbcOML"))
                {
                    wglWaitForSbcOML = (TwglWaitForSbcOML)Marshal.GetDelegateForFunctionPointer((IntPtr)wglFuncAddr, typeof(TwglWaitForSbcOML));
                }
            }

            #endregion
        }
    }
}