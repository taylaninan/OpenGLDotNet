using System;
using System.Runtime.InteropServices;

namespace OpenGLDotNet
{
    public static partial class GL
    {
        private static void LinkLibGLEXT()
        {
            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking Supported (GPU+LIB) OpenGL Extension functions...");
            GLConfig.LogWriteLine("============================================================");

            ///////////////////////////////////////////////////////////////////////
            // GL_3DFX_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_3DFX_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_3DFX_multisample (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_3DFX_multisample"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_3DFX_tbuffer
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_3DFX_tbuffer"))
            {
                if (GL.LinkProcGLEXT("glTbufferMask3DFX"))
                {
                    GL.glTbufferMask3DFX = (TglTbufferMask3DFX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTbufferMask3DFX));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_3DFX_texture_compression_FXT1 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_3DFX_texture_compression_FXT1"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_AMD_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_performance_monitor
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_performance_monitor"))
            {
                if (GL.LinkProcGLEXT("glGetPerfMonitorGroupsAMD"))
                {
                    GL.glGetPerfMonitorGroupsAMD = (TglGetPerfMonitorGroupsAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPerfMonitorGroupsAMD));
                }

                if (GL.LinkProcGLEXT("glGetPerfMonitorCountersAMD"))
                {
                    GL.glGetPerfMonitorCountersAMD = (TglGetPerfMonitorCountersAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPerfMonitorCountersAMD));
                }

                if (GL.LinkProcGLEXT("glGetPerfMonitorGroupStringAMD"))
                {
                    GL.glGetPerfMonitorGroupStringAMD = (TglGetPerfMonitorGroupStringAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPerfMonitorGroupStringAMD));
                }

                if (GL.LinkProcGLEXT("glGetPerfMonitorCounterStringAMD"))
                {
                    GL.glGetPerfMonitorCounterStringAMD = (TglGetPerfMonitorCounterStringAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPerfMonitorCounterStringAMD));
                }

                if (GL.LinkProcGLEXT("glGetPerfMonitorCounterInfoAMD"))
                {
                    GL.glGetPerfMonitorCounterInfoAMD = (TglGetPerfMonitorCounterInfoAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPerfMonitorCounterInfoAMD));
                }

                if (GL.LinkProcGLEXT("glGenPerfMonitorsAMD"))
                {
                    GL.glGenPerfMonitorsAMD = (TglGenPerfMonitorsAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenPerfMonitorsAMD));
                }

                if (GL.LinkProcGLEXT("glDeletePerfMonitorsAMD"))
                {
                    GL.glDeletePerfMonitorsAMD = (TglDeletePerfMonitorsAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeletePerfMonitorsAMD));
                }

                if (GL.LinkProcGLEXT("glSelectPerfMonitorCountersAMD"))
                {
                    GL.glSelectPerfMonitorCountersAMD = (TglSelectPerfMonitorCountersAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSelectPerfMonitorCountersAMD));
                }

                if (GL.LinkProcGLEXT("glBeginPerfMonitorAMD"))
                {
                    GL.glBeginPerfMonitorAMD = (TglBeginPerfMonitorAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginPerfMonitorAMD));
                }

                if (GL.LinkProcGLEXT("glEndPerfMonitorAMD"))
                {
                    GL.glEndPerfMonitorAMD = (TglEndPerfMonitorAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndPerfMonitorAMD));
                }

                if (GL.LinkProcGLEXT("glGetPerfMonitorCounterDataAMD"))
                {
                    GL.glGetPerfMonitorCounterDataAMD = (TglGetPerfMonitorCounterDataAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPerfMonitorCounterDataAMD));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_texture_texture4 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_texture_texture4"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_vertex_shader_tessellator
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_vertex_shader_tessellator"))
            {
                if (GL.LinkProcGLEXT("glTessellationFactorAMD"))
                {
                    GL.glTessellationFactorAMD = (TglTessellationFactorAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTessellationFactorAMD));
                }

                if (GL.LinkProcGLEXT("glTessellationModeAMD"))
                {
                    GL.glTessellationModeAMD = (TglTessellationModeAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTessellationModeAMD));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_draw_buffers_blend
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_draw_buffers_blend"))
            {
                if (GL.LinkProcGLEXT("glBlendFuncIndexedAMD"))
                {
                    GL.glBlendFuncIndexedAMD = (TglBlendFuncIndexedAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendFuncIndexedAMD));
                }

                if (GL.LinkProcGLEXT("glBlendFuncSeparateIndexedAMD"))
                {
                    GL.glBlendFuncSeparateIndexedAMD = (TglBlendFuncSeparateIndexedAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendFuncSeparateIndexedAMD));
                }

                if (GL.LinkProcGLEXT("glBlendEquationIndexedAMD"))
                {
                    GL.glBlendEquationIndexedAMD = (TglBlendEquationIndexedAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendEquationIndexedAMD));
                }

                if (GL.LinkProcGLEXT("glBlendEquationSeparateIndexedAMD"))
                {
                    GL.glBlendEquationSeparateIndexedAMD = (TglBlendEquationSeparateIndexedAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendEquationSeparateIndexedAMD));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_shader_stencil_export (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_shader_stencil_export"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_seamless_cubemap_per_texture (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_seamless_cubemap_per_texture"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_conservative_depth (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_conservative_depth"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_name_gen_delete
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_name_gen_delete"))
            {
                if (GL.LinkProcGLEXT("glGenNamesAMD"))
                {
                    GL.glGenNamesAMD = (TglGenNamesAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenNamesAMD));
                }

                if (GL.LinkProcGLEXT("glDeleteNamesAMD"))
                {
                    GL.glDeleteNamesAMD = (TglDeleteNamesAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteNamesAMD));
                }

                if (GL.LinkProcGLEXT("glIsNameAMD"))
                {
                    GL.glIsNameAMD = (TglIsNameAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsNameAMD));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_debug_output
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_debug_output"))
            {
                if (GL.LinkProcGLEXT("glDebugMessageEnableAMD"))
                {
                    GL.glDebugMessageEnableAMD = (TglDebugMessageEnableAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageEnableAMD));
                }

                if (GL.LinkProcGLEXT("glDebugMessageInsertAMD"))
                {
                    GL.glDebugMessageInsertAMD = (TglDebugMessageInsertAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageInsertAMD));
                }

                if (GL.LinkProcGLEXT("glDebugMessageCallbackAMD"))
                {
                    GL.glDebugMessageCallbackAMD = (TglDebugMessageCallbackAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageCallbackAMD));
                }

                if (GL.LinkProcGLEXT("glGetDebugMessageLogAMD"))
                {
                    GL.glGetDebugMessageLogAMD = (TglGetDebugMessageLogAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetDebugMessageLogAMD));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_transform_feedback3_lines_triangles (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_transform_feedback3_lines_triangles"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_depth_clamp_separate (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_depth_clamp_separate"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_blend_minmax_factor (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_blend_minmax_factor"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_sample_positions
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_sample_positions"))
            {
                if (GL.LinkProcGLEXT("glSetMultisamplefvAMD"))
                {
                    GL.glSetMultisamplefvAMD = (TglSetMultisamplefvAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSetMultisamplefvAMD));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_multi_draw_indirect
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_multi_draw_indirect"))
            {
                if (GL.LinkProcGLEXT("glMultiDrawArraysIndirectAMD"))
                {
                    GL.glMultiDrawArraysIndirectAMD = (TglMultiDrawArraysIndirectAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawArraysIndirectAMD));
                }

                if (GL.LinkProcGLEXT("glMultiDrawElementsIndirectAMD"))
                {
                    GL.glMultiDrawElementsIndirectAMD = (TglMultiDrawElementsIndirectAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawElementsIndirectAMD));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_pinned_memory (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_pinned_memory"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_stencil_operation_extended
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_stencil_operation_extended"))
            {
                if (GL.LinkProcGLEXT("glStencilOpValueAMD"))
                {
                    GL.glStencilOpValueAMD = (TglStencilOpValueAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilOpValueAMD));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_vertex_shader_viewport_index (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_vertex_shader_viewport_index"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_vertex_shader_layer (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_vertex_shader_layer"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_query_buffer_object (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_query_buffer_object"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_sparse_texture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_sparse_texture"))
            {
                if (GL.LinkProcGLEXT("glTexStorageSparseAMD"))
                {
                    GL.glTexStorageSparseAMD = (TglTexStorageSparseAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorageSparseAMD));
                }

                if (GL.LinkProcGLEXT("glTextureStorageSparseAMD"))
                {
                    GL.glTextureStorageSparseAMD = (TglTextureStorageSparseAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureStorageSparseAMD));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_shader_atomic_counter_ops (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_shader_atomic_counter_ops"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_shader_trinary_minmax (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_shader_trinary_minmax"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_interleaved_elements
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_interleaved_elements"))
            {
                if (GL.LinkProcGLEXT("glVertexAttribParameteriAMD"))
                {
                    GL.glVertexAttribParameteriAMD = (TglVertexAttribParameteriAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribParameteriAMD));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_occlusion_query_event
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMD_occlusion_query_event"))
            {
                if (GL.LinkProcGLEXT("glQueryObjectParameteruiAMD"))
                {
                    GL.glQueryObjectParameteruiAMD = (TglQueryObjectParameteruiAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglQueryObjectParameteruiAMD));
                }
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_AMDX_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_AMD_vertex_shader_tessellator
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMDX_vertex_shader_tessellator"))
            {
                if (GL.LinkProcGLEXT("glTessellationFactorAMDX"))
                {
                    GL.glTessellationFactorAMDX = (TglTessellationFactorAMDX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTessellationFactorAMDX));
                }

                if (GL.LinkProcGLEXT("glTessellationModeAMDX"))
                {
                    GL.glTessellationModeAMDX = (TglTessellationModeAMDX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTessellationModeAMDX));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_AMDX_debug_output
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_AMDX_debug_output"))
            {
                if (GL.LinkProcGLEXT("glDebugMessageEnableAMDX"))
                {
                    GL.glDebugMessageEnableAMD = (TglDebugMessageEnableAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageEnableAMD));
                }

                if (GL.LinkProcGLEXT("glDebugMessageInsertAMDX"))
                {
                    GL.glDebugMessageInsertAMD = (TglDebugMessageInsertAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageInsertAMD));
                }

                if (GL.LinkProcGLEXT("glDebugMessageCallbackAMDX"))
                {
                    GL.glDebugMessageCallbackAMD = (TglDebugMessageCallbackAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageCallbackAMD));
                }

                if (GL.LinkProcGLEXT("glGetDebugMessageLogAMDX"))
                {
                    GL.glGetDebugMessageLogAMD = (TglGetDebugMessageLogAMD)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetDebugMessageLogAMD));
                }
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_APPLE_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_specular_vector (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_specular_vector"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_transform_hint (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_transform_hint"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_client_storage (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_client_storage"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_element_array
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_element_array"))
            {
                if (GL.LinkProcGLEXT("glElementPointerAPPLE"))
                {
                    GL.glElementPointerAPPLE = (TglElementPointerAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglElementPointerAPPLE));
                }

                if (GL.LinkProcGLEXT("glDrawElementArrayAPPLE"))
                {
                    GL.glDrawElementArrayAPPLE = (TglDrawElementArrayAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementArrayAPPLE));
                }

                if (GL.LinkProcGLEXT("glDrawRangeElementArrayAPPLE"))
                {
                    GL.glDrawRangeElementArrayAPPLE = (TglDrawRangeElementArrayAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawRangeElementArrayAPPLE));
                }

                if (GL.LinkProcGLEXT("glMultiDrawElementArrayAPPLE"))
                {
                    GL.glMultiDrawElementArrayAPPLE = (TglMultiDrawElementArrayAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawElementArrayAPPLE));
                }

                if (GL.LinkProcGLEXT("glMultiDrawRangeElementArrayAPPLE"))
                {
                    GL.glMultiDrawRangeElementArrayAPPLE = (TglMultiDrawRangeElementArrayAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawRangeElementArrayAPPLE));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_fence
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_fence"))
            {
                if (GL.LinkProcGLEXT("glGenFencesAPPLE"))
                {
                    GL.glGenFencesAPPLE = (TglGenFencesAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenFencesAPPLE));
                }

                if (GL.LinkProcGLEXT("glDeleteFencesAPPLE"))
                {
                    GL.glDeleteFencesAPPLE = (TglDeleteFencesAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteFencesAPPLE));
                }

                if (GL.LinkProcGLEXT("glSetFenceAPPLE"))
                {
                    GL.glSetFenceAPPLE = (TglSetFenceAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSetFenceAPPLE));
                }

                if (GL.LinkProcGLEXT("glIsFenceAPPLE"))
                {
                    GL.glIsFenceAPPLE = (TglIsFenceAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsFenceAPPLE));
                }

                if (GL.LinkProcGLEXT("glTestFenceAPPLE"))
                {
                    GL.glTestFenceAPPLE = (TglTestFenceAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTestFenceAPPLE));
                }

                if (GL.LinkProcGLEXT("glFinishFenceAPPLE"))
                {
                    GL.glFinishFenceAPPLE = (TglFinishFenceAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFinishFenceAPPLE));
                }

                if (GL.LinkProcGLEXT("glTestObjectAPPLE"))
                {
                    GL.glTestObjectAPPLE = (TglTestObjectAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTestObjectAPPLE));
                }

                if (GL.LinkProcGLEXT("glFinishObjectAPPLE"))
                {
                    GL.glFinishObjectAPPLE = (TglFinishObjectAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFinishObjectAPPLE));
                }

            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_vertex_array_object
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_vertex_array_object"))
            {
                if (GL.LinkProcGLEXT("glBindVertexArrayAPPLE"))
                {
                    GL.glBindVertexArrayAPPLE = (TglBindVertexArrayAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindVertexArrayAPPLE));
                }

                if (GL.LinkProcGLEXT("glDeleteVertexArraysAPPLE"))
                {
                    GL.glDeleteVertexArraysAPPLE = (TglDeleteVertexArraysAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteVertexArraysAPPLE));
                }

                if (GL.LinkProcGLEXT("glGenVertexArraysAPPLE"))
                {
                    GL.glGenVertexArraysAPPLE = (TglGenVertexArraysAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenVertexArraysAPPLE));
                }

                if (GL.LinkProcGLEXT("glIsVertexArrayAPPLE"))
                {
                    GL.glIsVertexArrayAPPLE = (TglIsVertexArrayAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsVertexArrayAPPLE));
                }

            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_vertex_array_range
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_vertex_array_range"))
            {
                if (GL.LinkProcGLEXT("glVertexArrayRangeAPPLE"))
                {
                    GL.glVertexArrayRangeAPPLE = (TglVertexArrayRangeAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayRangeAPPLE));
                }

                if (GL.LinkProcGLEXT("glFlushVertexArrayRangeAPPLE"))
                {
                    GL.glFlushVertexArrayRangeAPPLE = (TglFlushVertexArrayRangeAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFlushVertexArrayRangeAPPLE));
                }

                if (GL.LinkProcGLEXT("glVertexArrayParameteriAPPLE"))
                {
                    GL.glVertexArrayParameteriAPPLE = (TglVertexArrayParameteriAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayParameteriAPPLE));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_ycbcr_422 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_ycbcr_422"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_flush_buffer_range
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_flush_buffer_range"))
            {
                if (GL.LinkProcGLEXT("glBufferParameteriAPPLE"))
                {
                    GL.glBufferParameteriAPPLE = (TglBufferParameteriAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBufferParameteriAPPLE));
                }

                if (GL.LinkProcGLEXT("glFlushMappedBufferRangeAPPLE"))
                {
                    GL.glFlushMappedBufferRangeAPPLE = (TglFlushMappedBufferRangeAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFlushMappedBufferRangeAPPLE));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_texture_range
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_texture_range"))
            {
                if (GL.LinkProcGLEXT("glTextureRangeAPPLE"))
                {
                    GL.glTextureRangeAPPLE = (TglTextureRangeAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureRangeAPPLE));
                }

                if (GL.LinkProcGLEXT("glGetTexParameterPointervAPPLE"))
                {
                    GL.glGetTexParameterPointervAPPLE = (TglGetTexParameterPointervAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexParameterPointervAPPLE));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_float_pixels (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_float_pixels"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_vertex_program_evaluators
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_vertex_program_evaluators"))
            {
                if (GL.LinkProcGLEXT("glEnableVertexAttribAPPLE"))
                {
                    GL.glEnableVertexAttribAPPLE = (TglEnableVertexAttribAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEnableVertexAttribAPPLE));
                }

                if (GL.LinkProcGLEXT("glDisableVertexAttribAPPLE"))
                {
                    GL.glDisableVertexAttribAPPLE = (TglDisableVertexAttribAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDisableVertexAttribAPPLE));
                }

                if (GL.LinkProcGLEXT("glIsVertexAttribEnabledAPPLE"))
                {
                    GL.glIsVertexAttribEnabledAPPLE = (TglIsVertexAttribEnabledAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsVertexAttribEnabledAPPLE));
                }

                if (GL.LinkProcGLEXT("glMapVertexAttrib1dAPPLE"))
                {
                    GL.glMapVertexAttrib1dAPPLE = (TglMapVertexAttrib1dAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapVertexAttrib1dAPPLE));
                }

                if (GL.LinkProcGLEXT("glMapVertexAttrib1fAPPLE"))
                {
                    GL.glMapVertexAttrib1fAPPLE = (TglMapVertexAttrib1fAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapVertexAttrib1fAPPLE));
                }

                if (GL.LinkProcGLEXT("glMapVertexAttrib2dAPPLE"))
                {
                    GL.glMapVertexAttrib2dAPPLE = (TglMapVertexAttrib2dAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapVertexAttrib2dAPPLE));
                }

                if (GL.LinkProcGLEXT("glMapVertexAttrib2fAPPLE"))
                {
                    GL.glMapVertexAttrib2fAPPLE = (TglMapVertexAttrib2fAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapVertexAttrib2fAPPLE));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_aux_depth_stencil (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_aux_depth_stencil"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_object_purgeable
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_object_purgeable"))
            {
                if (GL.LinkProcGLEXT("glObjectPurgeableAPPLE"))
                {
                    GL.glObjectPurgeableAPPLE = (TglObjectPurgeableAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglObjectPurgeableAPPLE));
                }

                if (GL.LinkProcGLEXT("glObjectUnpurgeableAPPLE"))
                {
                    GL.glObjectUnpurgeableAPPLE = (TglObjectUnpurgeableAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglObjectUnpurgeableAPPLE));
                }

                if (GL.LinkProcGLEXT("glGetObjectParameterivAPPLE"))
                {
                    GL.glGetObjectParameterivAPPLE = (TglGetObjectParameterivAPPLE)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetObjectParameterivAPPLE));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_row_bytes (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_row_bytes"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_APPLE_rgb_422 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_APPLE_rgb_422"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_ARB_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_imaging
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 1.2: GL_ARB_imaging section */
            if (GL.LinkGLEXT("GL_ARB_imaging"))
            {
                if (GL.LinkProcGLEXT("glBlendColor"))
                {
                    GL.glBlendColor = (TglBlendColor)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendColor));
                }

                if (GL.LinkProcGLEXT("glBlendEquation"))
                {
                    GL.glBlendEquation = (TglBlendEquation)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendEquation));
                }

                if (GL.LinkProcGLEXT("glColorSubTable"))
                {
                    GL.glColorSubTable = (TglColorSubTable)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorSubTable));
                }

                if (GL.LinkProcGLEXT("glCopyColorSubTable"))
                {
                    GL.glCopyColorSubTable = (TglCopyColorSubTable)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyColorSubTable));
                }

                if (GL.LinkProcGLEXT("glColorTable"))
                {
                    GL.glColorTable = (TglColorTable)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorTable));
                }

                if (GL.LinkProcGLEXT("glCopyColorTable"))
                {
                    GL.glCopyColorTable = (TglCopyColorTable)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyColorTable));
                }

                if (GL.LinkProcGLEXT("glColorTableParameteriv"))
                {
                    GL.glColorTableParameteriv = (TglColorTableParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorTableParameteriv));
                }

                if (GL.LinkProcGLEXT("glColorTableParameterfv"))
                {
                    GL.glColorTableParameterfv = (TglColorTableParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorTableParameterfv));
                }

                if (GL.LinkProcGLEXT("glGetColorTable"))
                {
                    GL.glGetColorTable = (TglGetColorTable)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetColorTable));
                }

                if (GL.LinkProcGLEXT("glGetColorTableParameteriv"))
                {
                    GL.glGetColorTableParameteriv = (TglGetColorTableParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetColorTableParameteriv));
                }

                if (GL.LinkProcGLEXT("glGetColorTableParameterfv"))
                {
                    GL.glGetColorTableParameterfv = (TglGetColorTableParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetColorTableParameterfv));
                }

                if (GL.LinkProcGLEXT("glConvolutionFilter1D"))
                {
                    GL.glConvolutionFilter1D = (TglConvolutionFilter1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionFilter1D));
                }

                if (GL.LinkProcGLEXT("glConvolutionFilter2D"))
                {
                    GL.glConvolutionFilter2D = (TglConvolutionFilter2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionFilter2D));
                }

                if (GL.LinkProcGLEXT("glCopyConvolutionFilter1D"))
                {
                    GL.glCopyConvolutionFilter1D = (TglCopyConvolutionFilter1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyConvolutionFilter1D));
                }

                if (GL.LinkProcGLEXT("glCopyConvolutionFilter2D"))
                {
                    GL.glCopyConvolutionFilter2D = (TglCopyConvolutionFilter2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyConvolutionFilter2D));
                }

                if (GL.LinkProcGLEXT("glGetConvolutionFilter"))
                {
                    GL.glGetConvolutionFilter = (TglGetConvolutionFilter)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetConvolutionFilter));
                }

                if (GL.LinkProcGLEXT("glSeparableFilter2D"))
                {
                    GL.glSeparableFilter2D = (TglSeparableFilter2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSeparableFilter2D));
                }

                if (GL.LinkProcGLEXT("glGetSeparableFilter"))
                {
                    GL.glGetSeparableFilter = (TglGetSeparableFilter)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSeparableFilter));
                }

                if (GL.LinkProcGLEXT("glConvolutionParameteri"))
                {
                    GL.glConvolutionParameteri = (TglConvolutionParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameteri));
                }

                if (GL.LinkProcGLEXT("glConvolutionParameteriv"))
                {
                    GL.glConvolutionParameteriv = (TglConvolutionParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameteriv));
                }

                if (GL.LinkProcGLEXT("glConvolutionParameterf"))
                {
                    GL.glConvolutionParameterf = (TglConvolutionParameterf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameterf));
                }

                if (GL.LinkProcGLEXT("glConvolutionParameterfv"))
                {
                    GL.glConvolutionParameterfv = (TglConvolutionParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameterfv));
                }

                if (GL.LinkProcGLEXT("glGetConvolutionParameteriv"))
                {
                    GL.glGetConvolutionParameteriv = (TglGetConvolutionParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetConvolutionParameteriv));
                }

                if (GL.LinkProcGLEXT("glGetConvolutionParameterfv"))
                {
                    GL.glGetConvolutionParameterfv = (TglGetConvolutionParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetConvolutionParameterfv));
                }

                if (GL.LinkProcGLEXT("glHistogram"))
                {
                    GL.glHistogram = (TglHistogram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglHistogram));
                }

                if (GL.LinkProcGLEXT("glResetHistogram"))
                {
                    GL.glResetHistogram = (TglResetHistogram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglResetHistogram));
                }

                if (GL.LinkProcGLEXT("glGetHistogram"))
                {
                    GL.glGetHistogram = (TglGetHistogram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetHistogram));
                }

                if (GL.LinkProcGLEXT("glGetHistogramParameteriv"))
                {
                    GL.glGetHistogramParameteriv = (TglGetHistogramParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetHistogramParameteriv));
                }

                if (GL.LinkProcGLEXT("glGetHistogramParameterfv"))
                {
                    GL.glGetHistogramParameterfv = (TglGetHistogramParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetHistogramParameterfv));
                }

                if (GL.LinkProcGLEXT("glMinmax"))
                {
                    GL.glMinmax = (TglMinmax)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMinmax));
                }

                if (GL.LinkProcGLEXT("glResetMinmax"))
                {
                    GL.glResetMinmax = (TglResetMinmax)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglResetMinmax));
                }

                if (GL.LinkProcGLEXT("glGetMinmax"))
                {
                    GL.glGetMinmax = (TglGetMinmax)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMinmax));
                }

                if (GL.LinkProcGLEXT("glGetMinmaxParameteriv"))
                {
                    GL.glGetMinmaxParameteriv = (TglGetMinmaxParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMinmaxParameteriv));
                }

                if (GL.LinkProcGLEXT("glGetMinmaxParameterfv"))
                {
                    GL.glGetMinmaxParameterfv = (TglGetMinmaxParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMinmaxParameterfv));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_occlusion_query2 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_occlusion_query2"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_multitexture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_multitexture"))
            {
                if (GL.LinkProcGLEXT("glActiveTextureARB"))
                {
                    GL.glActiveTextureARB = (TglActiveTextureARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglActiveTextureARB));
                }

                if (GL.LinkProcGLEXT("glClientActiveTextureARB"))
                {
                    GL.glClientActiveTextureARB = (TglClientActiveTextureARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClientActiveTextureARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord1dARB"))
                {
                    GL.glMultiTexCoord1dARB = (TglMultiTexCoord1dARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1dARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord1dvARB"))
                {
                    GL.glMultiTexCoord1dvARB = (TglMultiTexCoord1dvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1dvARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord1fARB"))
                {
                    GL.glMultiTexCoord1fARB = (TglMultiTexCoord1fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1fARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord1fvARB"))
                {
                    GL.glMultiTexCoord1fvARB = (TglMultiTexCoord1fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1fvARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord1iARB"))
                {
                    GL.glMultiTexCoord1iARB = (TglMultiTexCoord1iARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1iARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord1ivARB"))
                {
                    GL.glMultiTexCoord1ivARB = (TglMultiTexCoord1ivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1ivARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord1sARB"))
                {
                    GL.glMultiTexCoord1sARB = (TglMultiTexCoord1sARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1sARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord1svARB"))
                {
                    GL.glMultiTexCoord1svARB = (TglMultiTexCoord1svARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1svARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2dARB"))
                {
                    GL.glMultiTexCoord2dARB = (TglMultiTexCoord2dARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2dARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2dvARB"))
                {
                    GL.glMultiTexCoord2dvARB = (TglMultiTexCoord2dvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2dvARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2fARB"))
                {
                    GL.glMultiTexCoord2fARB = (TglMultiTexCoord2fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2fARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2fvARB"))
                {
                    GL.glMultiTexCoord2fvARB = (TglMultiTexCoord2fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2fvARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2iARB"))
                {
                    GL.glMultiTexCoord2iARB = (TglMultiTexCoord2iARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2iARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2ivARB"))
                {
                    GL.glMultiTexCoord2ivARB = (TglMultiTexCoord2ivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2ivARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2sARB"))
                {
                    GL.glMultiTexCoord2sARB = (TglMultiTexCoord2sARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2sARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2svARB"))
                {
                    GL.glMultiTexCoord2svARB = (TglMultiTexCoord2svARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2svARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3dARB"))
                {
                    GL.glMultiTexCoord3dARB = (TglMultiTexCoord3dARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3dARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3dvARB"))
                {
                    GL.glMultiTexCoord3dvARB = (TglMultiTexCoord3dvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3dvARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3fARB"))
                {
                    GL.glMultiTexCoord3fARB = (TglMultiTexCoord3fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3fARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3fvARB"))
                {
                    GL.glMultiTexCoord3fvARB = (TglMultiTexCoord3fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3fvARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3iARB"))
                {
                    GL.glMultiTexCoord3iARB = (TglMultiTexCoord3iARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3iARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3ivARB"))
                {
                    GL.glMultiTexCoord3ivARB = (TglMultiTexCoord3ivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3ivARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3sARB"))
                {
                    GL.glMultiTexCoord3sARB = (TglMultiTexCoord3sARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3sARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3svARB"))
                {
                    GL.glMultiTexCoord3svARB = (TglMultiTexCoord3svARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3svARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4dARB"))
                {
                    GL.glMultiTexCoord4dARB = (TglMultiTexCoord4dARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4dARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4dvARB"))
                {
                    GL.glMultiTexCoord4dvARB = (TglMultiTexCoord4dvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4dvARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4fARB"))
                {
                    GL.glMultiTexCoord4fARB = (TglMultiTexCoord4fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4fARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4fvARB"))
                {
                    GL.glMultiTexCoord4fvARB = (TglMultiTexCoord4fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4fvARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4iARB"))
                {
                    GL.glMultiTexCoord4iARB = (TglMultiTexCoord4iARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4iARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4ivARB"))
                {
                    GL.glMultiTexCoord4ivARB = (TglMultiTexCoord4ivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4ivARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4sARB"))
                {
                    GL.glMultiTexCoord4sARB = (TglMultiTexCoord4sARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4sARB));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4svARB"))
                {
                    GL.glMultiTexCoord4svARB = (TglMultiTexCoord4svARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4svARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_transpose_matrix
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_transpose_matrix"))
            {
                if (GL.LinkProcGLEXT("glLoadTransposeMatrixfARB"))
                {
                    GL.glLoadTransposeMatrixfARB = (TglLoadTransposeMatrixfARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLoadTransposeMatrixfARB));
                }

                if (GL.LinkProcGLEXT("glLoadTransposeMatrixdARB"))
                {
                    GL.glLoadTransposeMatrixdARB = (TglLoadTransposeMatrixdARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLoadTransposeMatrixdARB));
                }

                if (GL.LinkProcGLEXT("glMultTransposeMatrixfARB"))
                {
                    GL.glMultTransposeMatrixfARB = (TglMultTransposeMatrixfARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultTransposeMatrixfARB));
                }

                if (GL.LinkProcGLEXT("glMultTransposeMatrixdARB"))
                {
                    GL.glMultTransposeMatrixdARB = (TglMultTransposeMatrixdARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultTransposeMatrixdARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_multisample
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_multisample"))
            {
                if (GL.LinkProcGLEXT("glSampleCoverageARB"))
                {
                    GL.glSampleCoverageARB = (TglSampleCoverageARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSampleCoverageARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_env_add (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_env_add"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_cube_map (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_cube_map"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_compression
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_compression"))
            {
                if (GL.LinkProcGLEXT("glCompressedTexImage3DARB"))
                {
                    GL.glCompressedTexImage3DARB = (TglCompressedTexImage3DARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTexImage3DARB));
                }

                if (GL.LinkProcGLEXT("glCompressedTexImage2DARB"))
                {
                    GL.glCompressedTexImage2DARB = (TglCompressedTexImage2DARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTexImage2DARB));
                }

                if (GL.LinkProcGLEXT("glCompressedTexImage1DARB"))
                {
                    GL.glCompressedTexImage1DARB = (TglCompressedTexImage1DARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTexImage1DARB));
                }

                if (GL.LinkProcGLEXT("glCompressedTexSubImage3DARB"))
                {
                    GL.glCompressedTexSubImage3DARB = (TglCompressedTexSubImage3DARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTexSubImage3DARB));
                }

                if (GL.LinkProcGLEXT("glCompressedTexSubImage2DARB"))
                {
                    GL.glCompressedTexSubImage2DARB = (TglCompressedTexSubImage2DARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTexSubImage2DARB));
                }

                if (GL.LinkProcGLEXT("glCompressedTexSubImage1DARB"))
                {
                    GL.glCompressedTexSubImage1DARB = (TglCompressedTexSubImage1DARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTexSubImage1DARB));
                }

                if (GL.LinkProcGLEXT("glGetCompressedTexImageARB"))
                {
                    GL.glGetCompressedTexImageARB = (TglGetCompressedTexImageARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetCompressedTexImageARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_border_clamp (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_border_clamp"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_point_parameters
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_point_parameters"))
            {
                if (GL.LinkProcGLEXT("glPointParameterfARB"))
                {
                    GL.glPointParameterfARB = (TglPointParameterfARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointParameterfARB));
                }

                if (GL.LinkProcGLEXT("glPointParameterfvARB"))
                {
                    GL.glPointParameterfvARB = (TglPointParameterfvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointParameterfvARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shader_precision (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shader_precision"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_vertex_blend
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_vertex_blend"))
            {
                if (GL.LinkProcGLEXT("glWeightbvARB"))
                {
                    GL.glWeightbvARB = (TglWeightbvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWeightbvARB));
                }

                if (GL.LinkProcGLEXT("glWeightsvARB"))
                {
                    GL.glWeightsvARB = (TglWeightsvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWeightsvARB));
                }

                if (GL.LinkProcGLEXT("glWeightivARB"))
                {
                    GL.glWeightivARB = (TglWeightivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWeightivARB));
                }

                if (GL.LinkProcGLEXT("glWeightfvARB"))
                {
                    GL.glWeightfvARB = (TglWeightfvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWeightfvARB));
                }

                if (GL.LinkProcGLEXT("glWeightdvARB"))
                {
                    GL.glWeightdvARB = (TglWeightdvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWeightdvARB));
                }

                if (GL.LinkProcGLEXT("glWeightubvARB"))
                {
                    GL.glWeightubvARB = (TglWeightubvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWeightubvARB));
                }

                if (GL.LinkProcGLEXT("glWeightusvARB"))
                {
                    GL.glWeightusvARB = (TglWeightusvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWeightusvARB));
                }

                if (GL.LinkProcGLEXT("glWeightuivARB"))
                {
                    GL.glWeightuivARB = (TglWeightuivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWeightuivARB));
                }

                if (GL.LinkProcGLEXT("glWeightPointerARB"))
                {
                    GL.glWeightPointerARB = (TglWeightPointerARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWeightPointerARB));
                }

                if (GL.LinkProcGLEXT("glVertexBlendARB"))
                {
                    GL.glVertexBlendARB = (TglVertexBlendARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexBlendARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_matrix_palette
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_matrix_palette"))
            {
                if (GL.LinkProcGLEXT("glCurrentPaletteMatrixARB"))
                {
                    GL.glCurrentPaletteMatrixARB = (TglCurrentPaletteMatrixARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCurrentPaletteMatrixARB));
                }

                if (GL.LinkProcGLEXT("glMatrixIndexubvARB"))
                {
                    GL.glMatrixIndexubvARB = (TglMatrixIndexubvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixIndexubvARB));
                }

                if (GL.LinkProcGLEXT("glMatrixIndexusvARB"))
                {
                    GL.glMatrixIndexusvARB = (TglMatrixIndexusvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixIndexusvARB));
                }

                if (GL.LinkProcGLEXT("glMatrixIndexuivARB"))
                {
                    GL.glMatrixIndexuivARB = (TglMatrixIndexuivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixIndexuivARB));
                }

                if (GL.LinkProcGLEXT("glMatrixIndexPointerARB"))
                {
                    GL.glMatrixIndexPointerARB = (TglMatrixIndexPointerARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixIndexPointerARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_env_combine (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_env_combine"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_env_crossbar (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_env_crossbar"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_env_dot3 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_env_dot3"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_mirrored_repeat (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_mirrored_repeat"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_depth_texture (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_depth_texture"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shadow (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shadow"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shadow_ambient (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shadow_ambient"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_window_pos
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_window_pos"))
            {
                if (GL.LinkProcGLEXT("glWindowPos2dARB"))
                {
                    GL.glWindowPos2dARB = (TglWindowPos2dARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2dARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos2dvARB"))
                {
                    GL.glWindowPos2dvARB = (TglWindowPos2dvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2dvARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos2fARB"))
                {
                    GL.glWindowPos2fARB = (TglWindowPos2fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2fARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos2fvARB"))
                {
                    GL.glWindowPos2fvARB = (TglWindowPos2fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2fvARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos2iARB"))
                {
                    GL.glWindowPos2iARB = (TglWindowPos2iARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2iARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos2ivARB"))
                {
                    GL.glWindowPos2ivARB = (TglWindowPos2ivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2ivARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos2sARB"))
                {
                    GL.glWindowPos2sARB = (TglWindowPos2sARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2sARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos2svARB"))
                {
                    GL.glWindowPos2svARB = (TglWindowPos2svARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2svARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos3dARB"))
                {
                    GL.glWindowPos3dARB = (TglWindowPos3dARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3dARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos3dvARB"))
                {
                    GL.glWindowPos3dvARB = (TglWindowPos3dvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3dvARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos3fARB"))
                {
                    GL.glWindowPos3fARB = (TglWindowPos3fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3fARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos3fvARB"))
                {
                    GL.glWindowPos3fvARB = (TglWindowPos3fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3fvARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos3iARB"))
                {
                    GL.glWindowPos3iARB = (TglWindowPos3iARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3iARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos3ivARB"))
                {
                    GL.glWindowPos3ivARB = (TglWindowPos3ivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3ivARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos3sARB"))
                {
                    GL.glWindowPos3sARB = (TglWindowPos3sARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3sARB));
                }

                if (GL.LinkProcGLEXT("glWindowPos3svARB"))
                {
                    GL.glWindowPos3svARB = (TglWindowPos3svARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3svARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_vertex_program
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_vertex_program"))
            {
                if (GL.LinkProcGLEXT("glVertexAttrib1dARB"))
                {
                    GL.glVertexAttrib1dARB = (TglVertexAttrib1dARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1dARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib1dvARB"))
                {
                    GL.glVertexAttrib1dvARB = (TglVertexAttrib1dvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1dvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib1fARB"))
                {
                    GL.glVertexAttrib1fARB = (TglVertexAttrib1fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1fARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib1fvARB"))
                {
                    GL.glVertexAttrib1fvARB = (TglVertexAttrib1fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1fvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib1sARB"))
                {
                    GL.glVertexAttrib1sARB = (TglVertexAttrib1sARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1sARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib1svARB"))
                {
                    GL.glVertexAttrib1svARB = (TglVertexAttrib1svARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1svARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2dARB"))
                {
                    GL.glVertexAttrib2dARB = (TglVertexAttrib2dARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2dARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2dvARB"))
                {
                    GL.glVertexAttrib2dvARB = (TglVertexAttrib2dvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2dvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2fARB"))
                {
                    GL.glVertexAttrib2fARB = (TglVertexAttrib2fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2fARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2fvARB"))
                {
                    GL.glVertexAttrib2fvARB = (TglVertexAttrib2fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2fvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2sARB"))
                {
                    GL.glVertexAttrib2sARB = (TglVertexAttrib2sARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2sARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2svARB"))
                {
                    GL.glVertexAttrib2svARB = (TglVertexAttrib2svARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2svARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3dARB"))
                {
                    GL.glVertexAttrib3dARB = (TglVertexAttrib3dARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3dARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3dvARB"))
                {
                    GL.glVertexAttrib3dvARB = (TglVertexAttrib3dvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3dvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3fARB"))
                {
                    GL.glVertexAttrib3fARB = (TglVertexAttrib3fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3fARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3fvARB"))
                {
                    GL.glVertexAttrib3fvARB = (TglVertexAttrib3fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3fvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3sARB"))
                {
                    GL.glVertexAttrib3sARB = (TglVertexAttrib3sARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3sARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3svARB"))
                {
                    GL.glVertexAttrib3svARB = (TglVertexAttrib3svARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3svARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4NbvARB"))
                {
                    GL.glVertexAttrib4NbvARB = (TglVertexAttrib4NbvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4NbvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4NivARB"))
                {
                    GL.glVertexAttrib4NivARB = (TglVertexAttrib4NivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4NivARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4NsvARB"))
                {
                    GL.glVertexAttrib4NsvARB = (TglVertexAttrib4NsvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4NsvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4NubARB"))
                {
                    GL.glVertexAttrib4NubARB = (TglVertexAttrib4NubARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4NubARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4NubvARB"))
                {
                    GL.glVertexAttrib4NubvARB = (TglVertexAttrib4NubvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4NubvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4NuivARB"))
                {
                    GL.glVertexAttrib4NuivARB = (TglVertexAttrib4NuivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4NuivARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4NusvARB"))
                {
                    GL.glVertexAttrib4NusvARB = (TglVertexAttrib4NusvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4NusvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4bvARB"))
                {
                    GL.glVertexAttrib4bvARB = (TglVertexAttrib4bvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4bvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4dARB"))
                {
                    GL.glVertexAttrib4dARB = (TglVertexAttrib4dARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4dARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4dvARB"))
                {
                    GL.glVertexAttrib4dvARB = (TglVertexAttrib4dvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4dvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4fARB"))
                {
                    GL.glVertexAttrib4fARB = (TglVertexAttrib4fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4fARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4fvARB"))
                {
                    GL.glVertexAttrib4fvARB = (TglVertexAttrib4fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4fvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4ivARB"))
                {
                    GL.glVertexAttrib4ivARB = (TglVertexAttrib4ivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4ivARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4sARB"))
                {
                    GL.glVertexAttrib4sARB = (TglVertexAttrib4sARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4sARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4svARB"))
                {
                    GL.glVertexAttrib4svARB = (TglVertexAttrib4svARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4svARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4ubvARB"))
                {
                    GL.glVertexAttrib4ubvARB = (TglVertexAttrib4ubvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4ubvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4uivARB"))
                {
                    GL.glVertexAttrib4uivARB = (TglVertexAttrib4uivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4uivARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4usvARB"))
                {
                    GL.glVertexAttrib4usvARB = (TglVertexAttrib4usvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4usvARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttribPointerARB"))
                {
                    GL.glVertexAttribPointerARB = (TglVertexAttribPointerARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribPointerARB));
                }

                if (GL.LinkProcGLEXT("glEnableVertexAttribArrayARB"))
                {
                    GL.glEnableVertexAttribArrayARB = (TglEnableVertexAttribArrayARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEnableVertexAttribArrayARB));
                }

                if (GL.LinkProcGLEXT("glDisableVertexAttribArrayARB"))
                {
                    GL.glDisableVertexAttribArrayARB = (TglDisableVertexAttribArrayARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDisableVertexAttribArrayARB));
                }

                if (GL.LinkProcGLEXT("glProgramStringARB"))
                {
                    GL.glProgramStringARB = (TglProgramStringARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramStringARB));
                }

                if (GL.LinkProcGLEXT("glBindProgramARB"))
                {
                    GL.glBindProgramARB = (TglBindProgramARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindProgramARB));
                }

                if (GL.LinkProcGLEXT("glDeleteProgramsARB"))
                {
                    GL.glDeleteProgramsARB = (TglDeleteProgramsARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteProgramsARB));
                }

                if (GL.LinkProcGLEXT("glGenProgramsARB"))
                {
                    GL.glGenProgramsARB = (TglGenProgramsARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenProgramsARB));
                }

                if (GL.LinkProcGLEXT("glProgramEnvParameter4dARB"))
                {
                    GL.glProgramEnvParameter4dARB = (TglProgramEnvParameter4dARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramEnvParameter4dARB));
                }

                if (GL.LinkProcGLEXT("glProgramEnvParameter4dvARB"))
                {
                    GL.glProgramEnvParameter4dvARB = (TglProgramEnvParameter4dvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramEnvParameter4dvARB));
                }

                if (GL.LinkProcGLEXT("glProgramEnvParameter4fARB"))
                {
                    GL.glProgramEnvParameter4fARB = (TglProgramEnvParameter4fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramEnvParameter4fARB));
                }

                if (GL.LinkProcGLEXT("glProgramEnvParameter4fvARB"))
                {
                    GL.glProgramEnvParameter4fvARB = (TglProgramEnvParameter4fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramEnvParameter4fvARB));
                }

                if (GL.LinkProcGLEXT("glProgramLocalParameter4dARB"))
                {
                    GL.glProgramLocalParameter4dARB = (TglProgramLocalParameter4dARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramLocalParameter4dARB));
                }

                if (GL.LinkProcGLEXT("glProgramLocalParameter4dvARB"))
                {
                    GL.glProgramLocalParameter4dvARB = (TglProgramLocalParameter4dvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramLocalParameter4dvARB));
                }

                if (GL.LinkProcGLEXT("glProgramLocalParameter4fARB"))
                {
                    GL.glProgramLocalParameter4fARB = (TglProgramLocalParameter4fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramLocalParameter4fARB));
                }

                if (GL.LinkProcGLEXT("glProgramLocalParameter4fvARB"))
                {
                    GL.glProgramLocalParameter4fvARB = (TglProgramLocalParameter4fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramLocalParameter4fvARB));
                }

                if (GL.LinkProcGLEXT("glGetProgramEnvParameterdvARB"))
                {
                    GL.glGetProgramEnvParameterdvARB = (TglGetProgramEnvParameterdvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramEnvParameterdvARB));
                }

                if (GL.LinkProcGLEXT("glGetProgramEnvParameterfvARB"))
                {
                    GL.glGetProgramEnvParameterfvARB = (TglGetProgramEnvParameterfvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramEnvParameterfvARB));
                }

                if (GL.LinkProcGLEXT("glGetProgramLocalParameterdvARB"))
                {
                    GL.glGetProgramLocalParameterdvARB = (TglGetProgramLocalParameterdvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramLocalParameterdvARB));
                }

                if (GL.LinkProcGLEXT("glGetProgramLocalParameterfvARB"))
                {
                    GL.glGetProgramLocalParameterfvARB = (TglGetProgramLocalParameterfvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramLocalParameterfvARB));
                }

                if (GL.LinkProcGLEXT("glGetProgramivARB"))
                {
                    GL.glGetProgramivARB = (TglGetProgramivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramivARB));
                }

                if (GL.LinkProcGLEXT("glGetProgramStringARB"))
                {
                    GL.glGetProgramStringARB = (TglGetProgramStringARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramStringARB));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribdvARB"))
                {
                    GL.glGetVertexAttribdvARB = (TglGetVertexAttribdvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribdvARB));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribfvARB"))
                {
                    GL.glGetVertexAttribfvARB = (TglGetVertexAttribfvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribfvARB));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribivARB"))
                {
                    GL.glGetVertexAttribivARB = (TglGetVertexAttribivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribivARB));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribPointervARB"))
                {
                    GL.glGetVertexAttribPointervARB = (TglGetVertexAttribPointervARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribPointervARB));
                }

                if (GL.LinkProcGLEXT("glIsProgramARB"))
                {
                    GL.glIsProgramARB = (TglIsProgramARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsProgramARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_fragment_program
            ///////////////////////////////////////////////////////////////////////
            /* All ARB_fragment_program entry points are shared with ARB_vertex_program. */
            if (GL.LinkGLEXT("GL_ARB_fragment_program"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_vertex_buffer_object
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_vertex_buffer_object"))
            {
                if (GL.LinkProcGLEXT("glBindBufferARB"))
                {
                    GL.glBindBufferARB = (TglBindBufferARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindBufferARB));
                }

                if (GL.LinkProcGLEXT("glDeleteBuffersARB"))
                {
                    GL.glDeleteBuffersARB = (TglDeleteBuffersARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteBuffersARB));
                }

                if (GL.LinkProcGLEXT("glGenBuffersARB"))
                {
                    GL.glGenBuffersARB = (TglGenBuffersARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenBuffersARB));
                }

                if (GL.LinkProcGLEXT("glIsBufferARB"))
                {
                    GL.glIsBufferARB = (TglIsBufferARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsBufferARB));
                }

                if (GL.LinkProcGLEXT("glBufferDataARB"))
                {
                    GL.glBufferDataARB = (TglBufferDataARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBufferDataARB));
                }

                if (GL.LinkProcGLEXT("glBufferSubDataARB"))
                {
                    GL.glBufferSubDataARB = (TglBufferSubDataARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBufferSubDataARB));
                }

                if (GL.LinkProcGLEXT("glGetBufferSubDataARB"))
                {
                    GL.glGetBufferSubDataARB = (TglGetBufferSubDataARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetBufferSubDataARB));
                }

                if (GL.LinkProcGLEXT("glMapBufferARB"))
                {
                    GL.glMapBufferARB = (TglMapBufferARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapBufferARB));
                }

                if (GL.LinkProcGLEXT("glUnmapBufferARB"))
                {
                    GL.glUnmapBufferARB = (TglUnmapBufferARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUnmapBufferARB));
                }

                if (GL.LinkProcGLEXT("glGetBufferParameterivARB"))
                {
                    GL.glGetBufferParameterivARB = (TglGetBufferParameterivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetBufferParameterivARB));
                }

                if (GL.LinkProcGLEXT("glGetBufferPointervARB"))
                {
                    GL.glGetBufferPointervARB = (TglGetBufferPointervARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetBufferPointervARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_occlusion_query
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_occlusion_query"))
            {
                if (GL.LinkProcGLEXT("glGenQueriesARB"))
                {
                    GL.glGenQueriesARB = (TglGenQueriesARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenQueriesARB));
                }

                if (GL.LinkProcGLEXT("glDeleteQueriesARB"))
                {
                    GL.glDeleteQueriesARB = (TglDeleteQueriesARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteQueriesARB));
                }

                if (GL.LinkProcGLEXT("glIsQueryARB"))
                {
                    GL.glIsQueryARB = (TglIsQueryARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsQueryARB));
                }

                if (GL.LinkProcGLEXT("glBeginQueryARB"))
                {
                    GL.glBeginQueryARB = (TglBeginQueryARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginQueryARB));
                }

                if (GL.LinkProcGLEXT("glEndQueryARB"))
                {
                    GL.glEndQueryARB = (TglEndQueryARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndQueryARB));
                }

                if (GL.LinkProcGLEXT("glGetQueryivARB"))
                {
                    GL.glGetQueryivARB = (TglGetQueryivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryivARB));
                }

                if (GL.LinkProcGLEXT("glGetQueryObjectivARB"))
                {
                    GL.glGetQueryObjectivARB = (TglGetQueryObjectivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryObjectivARB));
                }

                if (GL.LinkProcGLEXT("glGetQueryObjectuivARB"))
                {
                    GL.glGetQueryObjectuivARB = (TglGetQueryObjectuivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryObjectuivARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shader_objects
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shader_objects"))
            {
                if (GL.LinkProcGLEXT("glDeleteObjectARB"))
                {
                    GL.glDeleteObjectARB = (TglDeleteObjectARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteObjectARB));
                }

                if (GL.LinkProcGLEXT("glGetHandleARB"))
                {
                    GL.glGetHandleARB = (TglGetHandleARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetHandleARB));
                }

                if (GL.LinkProcGLEXT("glDetachObjectARB"))
                {
                    GL.glDetachObjectARB = (TglDetachObjectARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDetachObjectARB));
                }

                if (GL.LinkProcGLEXT("glCreateShaderObjectARB"))
                {
                    GL.glCreateShaderObjectARB = (TglCreateShaderObjectARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateShaderObjectARB));
                }

                if (GL.LinkProcGLEXT("glShaderSourceARB"))
                {
                    GL.glShaderSourceARB = (TglShaderSourceARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglShaderSourceARB));
                }

                if (GL.LinkProcGLEXT("glCompileShaderARB"))
                {
                    GL.glCompileShaderARB = (TglCompileShaderARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompileShaderARB));
                }

                if (GL.LinkProcGLEXT("glCreateProgramObjectARB"))
                {
                    GL.glCreateProgramObjectARB = (TglCreateProgramObjectARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateProgramObjectARB));
                }

                if (GL.LinkProcGLEXT("glAttachObjectARB"))
                {
                    GL.glAttachObjectARB = (TglAttachObjectARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAttachObjectARB));
                }

                if (GL.LinkProcGLEXT("glLinkProgramARB"))
                {
                    GL.glLinkProgramARB = (TglLinkProgramARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLinkProgramARB));
                }

                if (GL.LinkProcGLEXT("glUseProgramObjectARB"))
                {
                    GL.glUseProgramObjectARB = (TglUseProgramObjectARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUseProgramObjectARB));
                }

                if (GL.LinkProcGLEXT("glValidateProgramARB"))
                {
                    GL.glValidateProgramARB = (TglValidateProgramARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglValidateProgramARB));
                }

                if (GL.LinkProcGLEXT("glUniform1fARB"))
                {
                    GL.glUniform1fARB = (TglUniform1fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1fARB));
                }

                if (GL.LinkProcGLEXT("glUniform2fARB"))
                {
                    GL.glUniform2fARB = (TglUniform2fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2fARB));
                }

                if (GL.LinkProcGLEXT("glUniform3fARB"))
                {
                    GL.glUniform3fARB = (TglUniform3fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3fARB));
                }

                if (GL.LinkProcGLEXT("glUniform4fARB"))
                {
                    GL.glUniform4fARB = (TglUniform4fARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4fARB));
                }

                if (GL.LinkProcGLEXT("glUniform1iARB"))
                {
                    GL.glUniform1iARB = (TglUniform1iARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1iARB));
                }

                if (GL.LinkProcGLEXT("glUniform2iARB"))
                {
                    GL.glUniform2iARB = (TglUniform2iARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2iARB));
                }

                if (GL.LinkProcGLEXT("glUniform3iARB"))
                {
                    GL.glUniform3iARB = (TglUniform3iARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3iARB));
                }

                if (GL.LinkProcGLEXT("glUniform4iARB"))
                {
                    GL.glUniform4iARB = (TglUniform4iARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4iARB));
                }

                if (GL.LinkProcGLEXT("glUniform1fvARB"))
                {
                    GL.glUniform1fvARB = (TglUniform1fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1fvARB));
                }

                if (GL.LinkProcGLEXT("glUniform2fvARB"))
                {
                    GL.glUniform2fvARB = (TglUniform2fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2fvARB));
                }

                if (GL.LinkProcGLEXT("glUniform3fvARB"))
                {
                    GL.glUniform3fvARB = (TglUniform3fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3fvARB));
                }

                if (GL.LinkProcGLEXT("glUniform4fvARB"))
                {
                    GL.glUniform4fvARB = (TglUniform4fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4fvARB));
                }

                if (GL.LinkProcGLEXT("glUniform1ivARB"))
                {
                    GL.glUniform1ivARB = (TglUniform1ivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1ivARB));
                }

                if (GL.LinkProcGLEXT("glUniform2ivARB"))
                {
                    GL.glUniform2ivARB = (TglUniform2ivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2ivARB));
                }

                if (GL.LinkProcGLEXT("glUniform3ivARB"))
                {
                    GL.glUniform3ivARB = (TglUniform3ivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3ivARB));
                }

                if (GL.LinkProcGLEXT("glUniform4ivARB"))
                {
                    GL.glUniform4ivARB = (TglUniform4ivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4ivARB));
                }

                if (GL.LinkProcGLEXT("glUniformMatrix2fvARB"))
                {
                    GL.glUniformMatrix2fvARB = (TglUniformMatrix2fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix2fvARB));
                }

                if (GL.LinkProcGLEXT("glUniformMatrix3fvARB"))
                {
                    GL.glUniformMatrix3fvARB = (TglUniformMatrix3fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix3fvARB));
                }

                if (GL.LinkProcGLEXT("glUniformMatrix4fvARB"))
                {
                    GL.glUniformMatrix4fvARB = (TglUniformMatrix4fvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix4fvARB));
                }

                if (GL.LinkProcGLEXT("glGetObjectParameterfvARB"))
                {
                    GL.glGetObjectParameterfvARB = (TglGetObjectParameterfvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetObjectParameterfvARB));
                }

                if (GL.LinkProcGLEXT("glGetObjectParameterivARB"))
                {
                    GL.glGetObjectParameterivARB = (TglGetObjectParameterivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetObjectParameterivARB));
                }

                if (GL.LinkProcGLEXT("glGetInfoLogARB"))
                {
                    GL.glGetInfoLogARB = (TglGetInfoLogARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetInfoLogARB));
                }

                if (GL.LinkProcGLEXT("glGetAttachedObjectsARB"))
                {
                    GL.glGetAttachedObjectsARB = (TglGetAttachedObjectsARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetAttachedObjectsARB));
                }

                if (GL.LinkProcGLEXT("glGetUniformLocationARB"))
                {
                    GL.glGetUniformLocationARB = (TglGetUniformLocationARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformLocationARB));
                }

                if (GL.LinkProcGLEXT("glGetActiveUniformARB"))
                {
                    GL.glGetActiveUniformARB = (TglGetActiveUniformARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveUniformARB));
                }

                if (GL.LinkProcGLEXT("glGetUniformfvARB"))
                {
                    GL.glGetUniformfvARB = (TglGetUniformfvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformfvARB));
                }

                if (GL.LinkProcGLEXT("glGetUniformivARB"))
                {
                    GL.glGetUniformivARB = (TglGetUniformivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformivARB));
                }

                if (GL.LinkProcGLEXT("glGetShaderSourceARB"))
                {
                    GL.glGetShaderSourceARB = (TglGetShaderSourceARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetShaderSourceARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_vertex_shader
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_vertex_shader"))
            {
                if (GL.LinkProcGLEXT("glBindAttribLocationARB"))
                {
                    GL.glBindAttribLocationARB = (TglBindAttribLocationARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindAttribLocationARB));
                }

                if (GL.LinkProcGLEXT("glGetActiveAttribARB"))
                {
                    GL.glGetActiveAttribARB = (TglGetActiveAttribARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveAttribARB));
                }

                if (GL.LinkProcGLEXT("glGetAttribLocationARB"))
                {
                    GL.glGetAttribLocationARB = (TglGetAttribLocationARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetAttribLocationARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_fragment_shader (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_fragment_shader"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shading_language_100 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shading_language_100"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_non_power_of_two (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_non_power_of_two"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_point_sprite (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_point_sprite"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_fragment_program_shadow (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_fragment_program_shadow"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_draw_buffers 
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_draw_buffers"))
            {
                if (GL.LinkProcGLEXT("glDrawBuffersARB"))
                {
                    GL.glDrawBuffersARB = (TglDrawBuffersARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawBuffersARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_rectangle (no function entry points) 
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_rectangle"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_color_buffer_float
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_color_buffer_float"))
            {
                if (GL.LinkProcGLEXT("glClampColorARB"))
                {
                    GL.glClampColorARB = (TglClampColorARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClampColorARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_half_float_pixel (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_half_float_pixel"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_float (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_float"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_pixel_buffer_object (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_pixel_buffer_object"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_depth_buffer_float (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_depth_buffer_float"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_draw_instanced
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_draw_instanced"))
            {
                if (GL.LinkProcGLEXT("glDrawArraysInstancedARB"))
                {
                    GL.glDrawArraysInstancedARB = (TglDrawArraysInstancedARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawArraysInstancedARB));
                }

                if (GL.LinkProcGLEXT("glDrawElementsInstancedARB"))
                {
                    GL.glDrawElementsInstancedARB = (TglDrawElementsInstancedARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementsInstancedARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_framebuffer_object
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL v3.0 */
            if (GL.LinkGLEXT("GL_ARB_framebuffer_object"))
            {
                if (GL.LinkProcGLEXT("glIsRenderbuffer"))
                {
                    GL.glIsRenderbuffer = (TglIsRenderbuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsRenderbuffer));
                }

                if (GL.LinkProcGLEXT("glBindRenderbuffer"))
                {
                    GL.glBindRenderbuffer = (TglBindRenderbuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindRenderbuffer));
                }

                if (GL.LinkProcGLEXT("glDeleteRenderbuffers"))
                {
                    GL.glDeleteRenderbuffers = (TglDeleteRenderbuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteRenderbuffers));
                }

                if (GL.LinkProcGLEXT("glGenRenderbuffers"))
                {
                    GL.glGenRenderbuffers = (TglGenRenderbuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenRenderbuffers));
                }

                if (GL.LinkProcGLEXT("glRenderbufferStorage"))
                {
                    GL.glRenderbufferStorage = (TglRenderbufferStorage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRenderbufferStorage));
                }

                if (GL.LinkProcGLEXT("glGetRenderbufferParameteriv"))
                {
                    GL.glGetRenderbufferParameteriv = (TglGetRenderbufferParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetRenderbufferParameteriv));
                }

                if (GL.LinkProcGLEXT("glIsFramebuffer"))
                {
                    GL.glIsFramebuffer = (TglIsFramebuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsFramebuffer));
                }

                if (GL.LinkProcGLEXT("glBindFramebuffer"))
                {
                    GL.glBindFramebuffer = (TglBindFramebuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindFramebuffer));
                }

                if (GL.LinkProcGLEXT("glDeleteFramebuffers"))
                {
                    GL.glDeleteFramebuffers = (TglDeleteFramebuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteFramebuffers));
                }

                if (GL.LinkProcGLEXT("glGenFramebuffers"))
                {
                    GL.glGenFramebuffers = (TglGenFramebuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenFramebuffers));
                }

                if (GL.LinkProcGLEXT("glCheckFramebufferStatus"))
                {
                    GL.glCheckFramebufferStatus = (TglCheckFramebufferStatus)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCheckFramebufferStatus));
                }

                if (GL.LinkProcGLEXT("glFramebufferTexture1D"))
                {
                    GL.glFramebufferTexture1D = (TglFramebufferTexture1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTexture1D));
                }

                if (GL.LinkProcGLEXT("glFramebufferTexture2D"))
                {
                    GL.glFramebufferTexture2D = (TglFramebufferTexture2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTexture2D));
                }

                if (GL.LinkProcGLEXT("glFramebufferTexture3D"))
                {
                    GL.glFramebufferTexture3D = (TglFramebufferTexture3D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTexture3D));
                }

                if (GL.LinkProcGLEXT("glFramebufferRenderbuffer"))
                {
                    GL.glFramebufferRenderbuffer = (TglFramebufferRenderbuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferRenderbuffer));
                }

                if (GL.LinkProcGLEXT("glGetFramebufferAttachmentParameteriv"))
                {
                    GL.glGetFramebufferAttachmentParameteriv = (TglGetFramebufferAttachmentParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFramebufferAttachmentParameteriv));
                }

                if (GL.LinkProcGLEXT("glGenerateMipmap"))
                {
                    GL.glGenerateMipmap = (TglGenerateMipmap)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenerateMipmap));
                }

                if (GL.LinkProcGLEXT("glBlitFramebuffer"))
                {
                    GL.glBlitFramebuffer = (TglBlitFramebuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlitFramebuffer));
                }

                if (GL.LinkProcGLEXT("glRenderbufferStorageMultisample"))
                {
                    GL.glRenderbufferStorageMultisample = (TglRenderbufferStorageMultisample)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRenderbufferStorageMultisample));
                }

                if (GL.LinkProcGLEXT("glFramebufferTextureLayer"))
                {
                    GL.glFramebufferTextureLayer = (TglFramebufferTextureLayer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTextureLayer));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_framebuffer_sRGB (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_framebuffer_sRGB"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_geometry_shader4
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_geometry_shader4"))
            {
                if (GL.LinkProcGLEXT("glProgramParameteriARB"))
                {
                    GL.glProgramParameteriARB = (TglProgramParameteriARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramParameteriARB));
                }

                if (GL.LinkProcGLEXT("glFramebufferTextureARB"))
                {
                    GL.glFramebufferTextureARB = (TglFramebufferTextureARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTextureARB));
                }

                if (GL.LinkProcGLEXT("glFramebufferTextureLayerARB"))
                {
                    GL.glFramebufferTextureLayerARB = (TglFramebufferTextureLayerARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTextureLayerARB));
                }

                if (GL.LinkProcGLEXT("glFramebufferTextureFaceARB"))
                {
                    GL.glFramebufferTextureFaceARB = (TglFramebufferTextureFaceARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTextureFaceARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_half_float_vertex (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_half_float_vertex"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_instanced_arrays
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_instanced_arrays"))
            {
                if (GL.LinkProcGLEXT("glVertexAttribDivisorARB"))
                {
                    GL.glVertexAttribDivisorARB = (TglVertexAttribDivisorARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribDivisorARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_map_buffer_range
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 3.0 */
            if (GL.LinkGLEXT("GL_ARB_map_buffer_range"))
            {
                if (GL.LinkProcGLEXT("glMapBufferRange"))
                {
                    GL.glMapBufferRange = (TglMapBufferRange)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapBufferRange));
                }

                if (GL.LinkProcGLEXT("glFlushMappedBufferRange"))
                {
                    GL.glFlushMappedBufferRange = (TglFlushMappedBufferRange)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFlushMappedBufferRange));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_buffer_object
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_buffer_object"))
            {
                if (GL.LinkProcGLEXT("glTexBufferARB"))
                {
                    GL.glTexBufferARB = (TglTexBufferARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexBufferARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_compression_rgtc (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_compression_rgtc"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_rg (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_rg"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_vertex_array_object
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 3.0 */
            if (GL.LinkGLEXT("GL_ARB_vertex_array_object"))
            {
                if (GL.LinkProcGLEXT("glBindVertexArray"))
                {
                    GL.glBindVertexArray = (TglBindVertexArray)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindVertexArray));
                }

                if (GL.LinkProcGLEXT("glDeleteVertexArrays"))
                {
                    GL.glDeleteVertexArrays = (TglDeleteVertexArrays)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteVertexArrays));
                }

                if (GL.LinkProcGLEXT("glGenVertexArrays"))
                {
                    GL.glGenVertexArrays = (TglGenVertexArrays)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenVertexArrays));
                }

                if (GL.LinkProcGLEXT("glIsVertexArray"))
                {
                    GL.glIsVertexArray = (TglIsVertexArray)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsVertexArray));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_uniform_buffer_object
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 3.1 */
            if (GL.LinkGLEXT("GL_ARB_uniform_buffer_object"))
            {
                if (GL.LinkProcGLEXT("glGetUniformIndices"))
                {
                    GL.glGetUniformIndices = (TglGetUniformIndices)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformIndices));
                }

                if (GL.LinkProcGLEXT("glGetActiveUniformsiv"))
                {
                    GL.glGetActiveUniformsiv = (TglGetActiveUniformsiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveUniformsiv));
                }

                if (GL.LinkProcGLEXT("glGetActiveUniformName"))
                {
                    GL.glGetActiveUniformName = (TglGetActiveUniformName)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveUniformName));
                }

                if (GL.LinkProcGLEXT("glGetUniformBlockIndex"))
                {
                    GL.glGetUniformBlockIndex = (TglGetUniformBlockIndex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformBlockIndex));
                }

                if (GL.LinkProcGLEXT("glGetActiveUniformBlockiv"))
                {
                    GL.glGetActiveUniformBlockiv = (TglGetActiveUniformBlockiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveUniformBlockiv));
                }

                if (GL.LinkProcGLEXT("glGetActiveUniformBlockName"))
                {
                    GL.glGetActiveUniformBlockName = (TglGetActiveUniformBlockName)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveUniformBlockName));
                }

                if (GL.LinkProcGLEXT("glUniformBlockBinding"))
                {
                    GL.glUniformBlockBinding = (TglUniformBlockBinding)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformBlockBinding));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_compatibility (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_compatibility"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_copy_buffer
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 3.1 */
            if (GL.LinkGLEXT("GL_ARB_copy_buffer"))
            {
                if (GL.LinkProcGLEXT("glCopyBufferSubData"))
                {
                    GL.glCopyBufferSubData = (TglCopyBufferSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyBufferSubData));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shader_texture_lod (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shader_texture_lod"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_depth_clamp (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_depth_clamp"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_draw_elements_base_vertex
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 3.2 */
            if (GL.LinkGLEXT("GL_ARB_draw_elements_base_vertex"))
            {
                if (GL.LinkProcGLEXT("glDrawElementsBaseVertex"))
                {
                    GL.glDrawElementsBaseVertex = (TglDrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementsBaseVertex));
                }

                if (GL.LinkProcGLEXT("glDrawRangeElementsBaseVertex"))
                {
                    GL.glDrawRangeElementsBaseVertex = (TglDrawRangeElementsBaseVertex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawRangeElementsBaseVertex));
                }

                if (GL.LinkProcGLEXT("glDrawElementsInstancedBaseVertex"))
                {
                    GL.glDrawElementsInstancedBaseVertex = (TglDrawElementsInstancedBaseVertex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementsInstancedBaseVertex));
                }

                if (GL.LinkProcGLEXT("glMultiDrawElementsBaseVertex"))
                {
                    GL.glMultiDrawElementsBaseVertex = (TglMultiDrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawElementsBaseVertex));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_fragment_coord_conventions (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_fragment_coord_conventions"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_provoking_vertex
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 3.2 */
            if (GL.LinkGLEXT("GL_ARB_provoking_vertex"))
            {
                if (GL.LinkProcGLEXT("glProvokingVertex"))
                {
                    GL.glProvokingVertex = (TglProvokingVertex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProvokingVertex));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_seamless_cube_map (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_seamless_cube_map"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_sync
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 3.2 */
            if (GL.LinkGLEXT("GL_ARB_sync"))
            {
                if (GL.LinkProcGLEXT("glFenceSync"))
                {
                    GL.glFenceSync = (TglFenceSync)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFenceSync));
                }

                if (GL.LinkProcGLEXT("glIsSync"))
                {
                    GL.glIsSync = (TglIsSync)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsSync));
                }

                if (GL.LinkProcGLEXT("glDeleteSync"))
                {
                    GL.glDeleteSync = (TglDeleteSync)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteSync));
                }

                if (GL.LinkProcGLEXT("glClientWaitSync"))
                {
                    GL.glClientWaitSync = (TglClientWaitSync)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClientWaitSync));
                }

                if (GL.LinkProcGLEXT("glWaitSync"))
                {
                    GL.glWaitSync = (TglWaitSync)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWaitSync));
                }

                if (GL.LinkProcGLEXT("glGetInteger64v"))
                {
                    GL.glGetInteger64v = (TglGetInteger64v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetInteger64v));
                }

                if (GL.LinkProcGLEXT("glGetSynciv"))
                {
                    GL.glGetSynciv = (TglGetSynciv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSynciv));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_multisample
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 3.2 */
            if (GL.LinkGLEXT("GL_ARB_texture_multisample"))
            {
                if (GL.LinkProcGLEXT("glTexImage2DMultisample"))
                {
                    GL.glTexImage2DMultisample = (TglTexImage2DMultisample)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexImage2DMultisample));
                }

                if (GL.LinkProcGLEXT("glTexImage3DMultisample"))
                {
                    GL.glTexImage3DMultisample = (TglTexImage3DMultisample)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexImage3DMultisample));
                }

                if (GL.LinkProcGLEXT("glGetMultisamplefv"))
                {
                    GL.glGetMultisamplefv = (TglGetMultisamplefv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultisamplefv));
                }

                if (GL.LinkProcGLEXT("glSampleMaski"))
                {
                    GL.glSampleMaski = (TglSampleMaski)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSampleMaski));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_vertex_array_bgra (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_vertex_array_bgra"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_draw_buffers_blend
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_draw_buffers_blend"))
            {
                if (GL.LinkProcGLEXT("glBlendEquationiARB"))
                {
                    GL.glBlendEquationiARB = (TglBlendEquationiARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendEquationiARB));
                }

                if (GL.LinkProcGLEXT("glBlendEquationSeparateiARB"))
                {
                    GL.glBlendEquationSeparateiARB = (TglBlendEquationSeparateiARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendEquationSeparateiARB));
                }

                if (GL.LinkProcGLEXT("glBlendFunciARB"))
                {
                    GL.glBlendFunciARB = (TglBlendFunciARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendFunciARB));
                }

                if (GL.LinkProcGLEXT("glBlendFuncSeparateiARB"))
                {
                    GL.glBlendFuncSeparateiARB = (TglBlendFuncSeparateiARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendFuncSeparateiARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_sample_shading
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_sample_shading"))
            {
                if (GL.LinkProcGLEXT("glMinSampleShadingARB"))
                {
                    GL.glMinSampleShadingARB = (TglMinSampleShadingARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMinSampleShadingARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_cube_map_array (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_cube_map_array"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_gather (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_gather"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_query_lod (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_query_lod"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shading_language_include
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shading_language_include"))
            {
                if (GL.LinkProcGLEXT("glNamedStringARB"))
                {
                    GL.glNamedStringARB = (TglNamedStringARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedStringARB));
                }

                if (GL.LinkProcGLEXT("glDeleteNamedStringARB"))
                {
                    GL.glDeleteNamedStringARB = (TglDeleteNamedStringARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteNamedStringARB));
                }

                if (GL.LinkProcGLEXT("glCompileShaderIncludeARB"))
                {
                    GL.glCompileShaderIncludeARB = (TglCompileShaderIncludeARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompileShaderIncludeARB));
                }

                if (GL.LinkProcGLEXT("glIsNamedStringARB"))
                {
                    GL.glIsNamedStringARB = (TglIsNamedStringARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsNamedStringARB));
                }

                if (GL.LinkProcGLEXT("glGetNamedStringARB"))
                {
                    GL.glGetNamedStringARB = (TglGetNamedStringARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedStringARB));
                }

                if (GL.LinkProcGLEXT("glGetNamedStringivARB"))
                {
                    GL.glGetNamedStringivARB = (TglGetNamedStringivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedStringivARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_compression_bptc (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_compression_bptc"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_blend_func_extended
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 3.3 */
            if (GL.LinkGLEXT("GL_ARB_blend_func_extended"))
            {
                if (GL.LinkProcGLEXT("glBindFragDataLocationIndexed"))
                {
                    GL.glBindFragDataLocationIndexed = (TglBindFragDataLocationIndexed)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindFragDataLocationIndexed));
                }

                if (GL.LinkProcGLEXT("glGetFragDataIndex"))
                {
                    GL.glGetFragDataIndex = (TglGetFragDataIndex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFragDataIndex));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_explicit_attrib_location (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_explicit_attrib_location"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_sampler_objects
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 3.3 */
            if (GL.LinkGLEXT("GL_ARB_sampler_objects"))
            {
                if (GL.LinkProcGLEXT("glGenSamplers"))
                {
                    GL.glGenSamplers = (TglGenSamplers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenSamplers));
                }

                if (GL.LinkProcGLEXT("glDeleteSamplers"))
                {
                    GL.glDeleteSamplers = (TglDeleteSamplers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteSamplers));
                }

                if (GL.LinkProcGLEXT("glIsSampler"))
                {
                    GL.glIsSampler = (TglIsSampler)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsSampler));
                }

                if (GL.LinkProcGLEXT("glBindSampler"))
                {
                    GL.glBindSampler = (TglBindSampler)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindSampler));
                }

                if (GL.LinkProcGLEXT("glSamplerParameteri"))
                {
                    GL.glSamplerParameteri = (TglSamplerParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplerParameteri));
                }

                if (GL.LinkProcGLEXT("glSamplerParameteriv"))
                {
                    GL.glSamplerParameteriv = (TglSamplerParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplerParameteriv));
                }

                if (GL.LinkProcGLEXT("glSamplerParameterf"))
                {
                    GL.glSamplerParameterf = (TglSamplerParameterf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplerParameterf));
                }

                if (GL.LinkProcGLEXT("glSamplerParameterfv"))
                {
                    GL.glSamplerParameterfv = (TglSamplerParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplerParameterfv));
                }

                if (GL.LinkProcGLEXT("glSamplerParameterIiv"))
                {
                    GL.glSamplerParameterIiv = (TglSamplerParameterIiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplerParameterIiv));
                }

                if (GL.LinkProcGLEXT("glSamplerParameterIuiv"))
                {
                    GL.glSamplerParameterIuiv = (TglSamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplerParameterIuiv));
                }

                if (GL.LinkProcGLEXT("glGetSamplerParameteriv"))
                {
                    GL.glGetSamplerParameteriv = (TglGetSamplerParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSamplerParameteriv));
                }

                if (GL.LinkProcGLEXT("glGetSamplerParameterIiv"))
                {
                    GL.glGetSamplerParameterIiv = (TglGetSamplerParameterIiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSamplerParameterIiv));
                }

                if (GL.LinkProcGLEXT("glGetSamplerParameterfv"))
                {
                    GL.glGetSamplerParameterfv = (TglGetSamplerParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSamplerParameterfv));
                }

                if (GL.LinkProcGLEXT("glGetSamplerParameterIuiv"))
                {
                    GL.glGetSamplerParameterIuiv = (TglGetSamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSamplerParameterIuiv));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shader_bit_encoding (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shader_bit_encoding"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_rgb10_a2ui (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_rgb10_a2ui"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_swizzle (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_swizzle"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_timer_query
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 3.3 */
            if (GL.LinkGLEXT("GL_ARB_timer_query"))
            {
                if (GL.LinkProcGLEXT("glQueryCounter"))
                {
                    GL.glQueryCounter = (TglQueryCounter)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglQueryCounter));
                }

                if (GL.LinkProcGLEXT("glGetQueryObjecti64v"))
                {
                    GL.glGetQueryObjecti64v = (TglGetQueryObjecti64v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryObjecti64v));
                }

                if (GL.LinkProcGLEXT("glGetQueryObjectui64v"))
                {
                    GL.glGetQueryObjectui64v = (TglGetQueryObjectui64v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryObjectui64v));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_vertex_type_2_10_10_10_rev
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 3.3 */
            if (GL.LinkGLEXT("GL_ARB_vertex_type_2_10_10_10_rev"))
            {
                if (GL.LinkProcGLEXT("glVertexP2ui"))
                {
                    GL.glVertexP2ui = (TglVertexP2ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexP2ui));
                }

                if (GL.LinkProcGLEXT("glVertexP2uiv"))
                {
                    GL.glVertexP2uiv = (TglVertexP2uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexP2uiv));
                }

                if (GL.LinkProcGLEXT("glVertexP3ui"))
                {
                    GL.glVertexP3ui = (TglVertexP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexP3ui));
                }

                if (GL.LinkProcGLEXT("glVertexP3uiv"))
                {
                    GL.glVertexP3uiv = (TglVertexP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexP3uiv));
                }

                if (GL.LinkProcGLEXT("glVertexP4ui"))
                {
                    GL.glVertexP4ui = (TglVertexP4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexP4ui));
                }

                if (GL.LinkProcGLEXT("glVertexP4uiv"))
                {
                    GL.glVertexP4uiv = (TglVertexP4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexP4uiv));
                }

                if (GL.LinkProcGLEXT("glTexCoordP1ui"))
                {
                    GL.glTexCoordP1ui = (TglTexCoordP1ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP1ui));
                }

                if (GL.LinkProcGLEXT("glTexCoordP1uiv"))
                {
                    GL.glTexCoordP1uiv = (TglTexCoordP1uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP1uiv));
                }

                if (GL.LinkProcGLEXT("glTexCoordP2ui"))
                {
                    GL.glTexCoordP2ui = (TglTexCoordP2ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP2ui));
                }

                if (GL.LinkProcGLEXT("glTexCoordP2uiv"))
                {
                    GL.glTexCoordP2uiv = (TglTexCoordP2uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP2uiv));
                }

                if (GL.LinkProcGLEXT("glTexCoordP3ui"))
                {
                    GL.glTexCoordP3ui = (TglTexCoordP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP3ui));
                }

                if (GL.LinkProcGLEXT("glTexCoordP3uiv"))
                {
                    GL.glTexCoordP3uiv = (TglTexCoordP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP3uiv));
                }

                if (GL.LinkProcGLEXT("glTexCoordP4ui"))
                {
                    GL.glTexCoordP4ui = (TglTexCoordP4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP4ui));
                }

                if (GL.LinkProcGLEXT("glTexCoordP4uiv"))
                {
                    GL.glTexCoordP4uiv = (TglTexCoordP4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP4uiv));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoordP1ui"))
                {
                    GL.glMultiTexCoordP1ui = (TglMultiTexCoordP1ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP1ui));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoordP1uiv"))
                {
                    GL.glMultiTexCoordP1uiv = (TglMultiTexCoordP1uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP1uiv));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoordP2ui"))
                {
                    GL.glMultiTexCoordP2ui = (TglMultiTexCoordP2ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP2ui));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoordP2uiv"))
                {
                    GL.glMultiTexCoordP2uiv = (TglMultiTexCoordP2uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP2uiv));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoordP3ui"))
                {
                    GL.glMultiTexCoordP3ui = (TglMultiTexCoordP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP3ui));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoordP3uiv"))
                {
                    GL.glMultiTexCoordP3uiv = (TglMultiTexCoordP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP3uiv));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoordP4ui"))
                {
                    GL.glMultiTexCoordP4ui = (TglMultiTexCoordP4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP4ui));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoordP4uiv"))
                {
                    GL.glMultiTexCoordP4uiv = (TglMultiTexCoordP4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP4uiv));
                }

                if (GL.LinkProcGLEXT("glNormalP3ui"))
                {
                    GL.glNormalP3ui = (TglNormalP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalP3ui));
                }

                if (GL.LinkProcGLEXT("glNormalP3uiv"))
                {
                    GL.glNormalP3uiv = (TglNormalP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalP3uiv));
                }

                if (GL.LinkProcGLEXT("glColorP3ui"))
                {
                    GL.glColorP3ui = (TglColorP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorP3ui));
                }

                if (GL.LinkProcGLEXT("glColorP3uiv"))
                {
                    GL.glColorP3uiv = (TglColorP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorP3uiv));
                }

                if (GL.LinkProcGLEXT("glColorP4ui"))
                {
                    GL.glColorP4ui = (TglColorP4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorP4ui));
                }

                if (GL.LinkProcGLEXT("glColorP4uiv"))
                {
                    GL.glColorP4uiv = (TglColorP4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorP4uiv));
                }

                if (GL.LinkProcGLEXT("glSecondaryColorP3ui"))
                {
                    GL.glSecondaryColorP3ui = (TglSecondaryColorP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColorP3ui));
                }

                if (GL.LinkProcGLEXT("glSecondaryColorP3uiv"))
                {
                    GL.glSecondaryColorP3uiv = (TglSecondaryColorP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColorP3uiv));
                }

                if (GL.LinkProcGLEXT("glVertexAttribP1ui"))
                {
                    GL.glVertexAttribP1ui = (TglVertexAttribP1ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP1ui));
                }

                if (GL.LinkProcGLEXT("glVertexAttribP1uiv"))
                {
                    GL.glVertexAttribP1uiv = (TglVertexAttribP1uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP1uiv));
                }

                if (GL.LinkProcGLEXT("glVertexAttribP2ui"))
                {
                    GL.glVertexAttribP2ui = (TglVertexAttribP2ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP2ui));
                }

                if (GL.LinkProcGLEXT("glVertexAttribP2uiv"))
                {
                    GL.glVertexAttribP2uiv = (TglVertexAttribP2uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP2uiv));
                }

                if (GL.LinkProcGLEXT("glVertexAttribP3ui"))
                {
                    GL.glVertexAttribP3ui = (TglVertexAttribP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP3ui));
                }

                if (GL.LinkProcGLEXT("glVertexAttribP3uiv"))
                {
                    GL.glVertexAttribP3uiv = (TglVertexAttribP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP3uiv));
                }

                if (GL.LinkProcGLEXT("glVertexAttribP4ui"))
                {
                    GL.glVertexAttribP4ui = (TglVertexAttribP4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP4ui));
                }

                if (GL.LinkProcGLEXT("glVertexAttribP4uiv"))
                {
                    GL.glVertexAttribP4uiv = (TglVertexAttribP4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP4uiv));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_draw_indirect
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.0 */
            if (GL.LinkGLEXT("GL_ARB_draw_indirect"))
            {
                if (GL.LinkProcGLEXT("glDrawArraysIndirect"))
                {
                    GL.glDrawArraysIndirect = (TglDrawArraysIndirect)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawArraysIndirect));
                }

                if (GL.LinkProcGLEXT("glDrawElementsIndirect"))
                {
                    GL.glDrawElementsIndirect = (TglDrawElementsIndirect)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementsIndirect));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_gpu_shader5 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_gpu_shader5"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_gpu_shader_fp64 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.0 */
            if (GL.LinkGLEXT("GL_ARB_gpu_shader_fp64"))
            {
                if (GL.LinkProcGLEXT("glUniform1d"))
                {
                    GL.glUniform1d = (TglUniform1d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1d));
                }

                if (GL.LinkProcGLEXT("glUniform2d"))
                {
                    GL.glUniform2d = (TglUniform2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2d));
                }

                if (GL.LinkProcGLEXT("glUniform3d"))
                {
                    GL.glUniform3d = (TglUniform3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3d));
                }

                if (GL.LinkProcGLEXT("glUniform4d"))
                {
                    GL.glUniform4d = (TglUniform4d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4d));
                }

                if (GL.LinkProcGLEXT("glUniform1dv"))
                {
                    GL.glUniform1dv = (TglUniform1dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1dv));
                }

                if (GL.LinkProcGLEXT("glUniform2dv"))
                {
                    GL.glUniform2dv = (TglUniform2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2dv));
                }

                if (GL.LinkProcGLEXT("glUniform3dv"))
                {
                    GL.glUniform3dv = (TglUniform3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3dv));
                }

                if (GL.LinkProcGLEXT("glUniform4dv"))
                {
                    GL.glUniform4dv = (TglUniform4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4dv));
                }

                if (GL.LinkProcGLEXT("glUniformMatrix2dv"))
                {
                    GL.glUniformMatrix2dv = (TglUniformMatrix2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix2dv));
                }

                if (GL.LinkProcGLEXT("glUniformMatrix3dv"))
                {
                    GL.glUniformMatrix3dv = (TglUniformMatrix3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix3dv));
                }

                if (GL.LinkProcGLEXT("glUniformMatrix4dv"))
                {
                    GL.glUniformMatrix4dv = (TglUniformMatrix4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix4dv));
                }

                if (GL.LinkProcGLEXT("glUniformMatrix2x3dv"))
                {
                    GL.glUniformMatrix2x3dv = (TglUniformMatrix2x3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix2x3dv));
                }

                if (GL.LinkProcGLEXT("glUniformMatrix2x4dv"))
                {
                    GL.glUniformMatrix2x4dv = (TglUniformMatrix2x4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix2x4dv));
                }

                if (GL.LinkProcGLEXT("glUniformMatrix3x2dv"))
                {
                    GL.glUniformMatrix3x2dv = (TglUniformMatrix3x2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix3x2dv));
                }

                if (GL.LinkProcGLEXT("glUniformMatrix3x4dv"))
                {
                    GL.glUniformMatrix3x4dv = (TglUniformMatrix3x4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix3x4dv));
                }

                if (GL.LinkProcGLEXT("glUniformMatrix4x2dv"))
                {
                    GL.glUniformMatrix4x2dv = (TglUniformMatrix4x2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix4x2dv));
                }

                if (GL.LinkProcGLEXT("glUniformMatrix4x3dv"))
                {
                    GL.glUniformMatrix4x3dv = (TglUniformMatrix4x3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix4x3dv));
                }

                if (GL.LinkProcGLEXT("glGetUniformdv"))
                {
                    GL.glGetUniformdv = (TglGetUniformdv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformdv));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shader_subroutine
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.0 */
            if (GL.LinkGLEXT("GL_ARB_shader_subroutine"))
            {
                if (GL.LinkProcGLEXT("glGetSubroutineUniformLocation"))
                {
                    GL.glGetSubroutineUniformLocation = (TglGetSubroutineUniformLocation)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSubroutineUniformLocation));
                }

                if (GL.LinkProcGLEXT("glGetSubroutineIndex"))
                {
                    GL.glGetSubroutineIndex = (TglGetSubroutineIndex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSubroutineIndex));
                }

                if (GL.LinkProcGLEXT("glGetActiveSubroutineUniformiv"))
                {
                    GL.glGetActiveSubroutineUniformiv = (TglGetActiveSubroutineUniformiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveSubroutineUniformiv));
                }

                if (GL.LinkProcGLEXT("glGetActiveSubroutineUniformName"))
                {
                    GL.glGetActiveSubroutineUniformName = (TglGetActiveSubroutineUniformName)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveSubroutineUniformName));
                }

                if (GL.LinkProcGLEXT("glGetActiveSubroutineName"))
                {
                    GL.glGetActiveSubroutineName = (TglGetActiveSubroutineName)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveSubroutineName));
                }

                if (GL.LinkProcGLEXT("glUniformSubroutinesuiv"))
                {
                    GL.glUniformSubroutinesuiv = (TglUniformSubroutinesuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformSubroutinesuiv));
                }

                if (GL.LinkProcGLEXT("glGetUniformSubroutineuiv"))
                {
                    GL.glGetUniformSubroutineuiv = (TglGetUniformSubroutineuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformSubroutineuiv));
                }

                if (GL.LinkProcGLEXT("glGetProgramStageiv"))
                {
                    GL.glGetProgramStageiv = (TglGetProgramStageiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramStageiv));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_tessellation_shader
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.0 */
            if (GL.LinkGLEXT("GL_ARB_tessellation_shader"))
            {
                if (GL.LinkProcGLEXT("glPatchParameteri"))
                {
                    GL.glPatchParameteri = (TglPatchParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPatchParameteri));
                }

                if (GL.LinkProcGLEXT("glPatchParameterfv"))
                {
                    GL.glPatchParameterfv = (TglPatchParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPatchParameterfv));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_buffer_object_rgb32
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_buffer_object_rgb32"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_transform_feedback2
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.0 */
            if (GL.LinkGLEXT("GL_ARB_transform_feedback2"))
            {
                if (GL.LinkProcGLEXT("glBindTransformFeedback"))
                {
                    GL.glBindTransformFeedback = (TglBindTransformFeedback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindTransformFeedback));
                }

                if (GL.LinkProcGLEXT("glDeleteTransformFeedbacks"))
                {
                    GL.glDeleteTransformFeedbacks = (TglDeleteTransformFeedbacks)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteTransformFeedbacks));
                }

                if (GL.LinkProcGLEXT("glGenTransformFeedbacks"))
                {
                    GL.glGenTransformFeedbacks = (TglGenTransformFeedbacks)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenTransformFeedbacks));
                }

                if (GL.LinkProcGLEXT("glIsTransformFeedback"))
                {
                    GL.glIsTransformFeedback = (TglIsTransformFeedback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsTransformFeedback));
                }

                if (GL.LinkProcGLEXT("glPauseTransformFeedback"))
                {
                    GL.glPauseTransformFeedback = (TglPauseTransformFeedback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPauseTransformFeedback));
                }

                if (GL.LinkProcGLEXT("glResumeTransformFeedback"))
                {
                    GL.glResumeTransformFeedback = (TglResumeTransformFeedback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglResumeTransformFeedback));
                }

                if (GL.LinkProcGLEXT("glDrawTransformFeedback"))
                {
                    GL.glDrawTransformFeedback = (TglDrawTransformFeedback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawTransformFeedback));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_transform_feedback3
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.0 */
            if (GL.LinkGLEXT("GL_ARB_transform_feedback3"))
            {
                if (GL.LinkProcGLEXT("glDrawTransformFeedbackStream"))
                {
                    GL.glDrawTransformFeedbackStream = (TglDrawTransformFeedbackStream)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawTransformFeedbackStream));
                }

                if (GL.LinkProcGLEXT("glBeginQueryIndexed"))
                {
                    GL.glBeginQueryIndexed = (TglBeginQueryIndexed)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginQueryIndexed));
                }

                if (GL.LinkProcGLEXT("glEndQueryIndexed"))
                {
                    GL.glEndQueryIndexed = (TglEndQueryIndexed)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndQueryIndexed));
                }

                if (GL.LinkProcGLEXT("glGetQueryIndexediv"))
                {
                    GL.glGetQueryIndexediv = (TglGetQueryIndexediv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryIndexediv));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_ES2_compatibility
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.1 */
            if (GL.LinkGLEXT("GL_ARB_ES2_compatibility"))
            {
                if (GL.LinkProcGLEXT("glReleaseShaderCompiler"))
                {
                    GL.glReleaseShaderCompiler = (TglReleaseShaderCompiler)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReleaseShaderCompiler));
                }

                if (GL.LinkProcGLEXT("glShaderBinary"))
                {
                    GL.glShaderBinary = (TglShaderBinary)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglShaderBinary));
                }

                if (GL.LinkProcGLEXT("glGetShaderPrecisionFormat"))
                {
                    GL.glGetShaderPrecisionFormat = (TglGetShaderPrecisionFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetShaderPrecisionFormat));
                }

                if (GL.LinkProcGLEXT("glDepthRangef"))
                {
                    GL.glDepthRangef = (TglDepthRangef)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthRangef));
                }

                if (GL.LinkProcGLEXT("glClearDepthf"))
                {
                    GL.glClearDepthf = (TglClearDepthf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearDepthf));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_get_program_binary
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.1 */
            if (GL.LinkGLEXT("GL_ARB_get_program_binary"))
            {
                if (GL.LinkProcGLEXT("glGetProgramBinary"))
                {
                    GL.glGetProgramBinary = (TglGetProgramBinary)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramBinary));
                }

                if (GL.LinkProcGLEXT("glProgramBinary"))
                {
                    GL.glProgramBinary = (TglProgramBinary)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramBinary));
                }

                if (GL.LinkProcGLEXT("glProgramParameteri"))
                {
                    GL.glProgramParameteri = (TglProgramParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramParameteri));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_separate_shader_objects
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.1 */
            if (GL.LinkGLEXT("GL_ARB_separate_shader_objects"))
            {
                if (GL.LinkProcGLEXT("glUseProgramStages"))
                {
                    GL.glUseProgramStages = (TglUseProgramStages)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUseProgramStages));
                }

                if (GL.LinkProcGLEXT("glActiveShaderProgram"))
                {
                    GL.glActiveShaderProgram = (TglActiveShaderProgram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglActiveShaderProgram));
                }

                if (GL.LinkProcGLEXT("glCreateShaderProgramv"))
                {
                    GL.glCreateShaderProgramv = (TglCreateShaderProgramv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateShaderProgramv));
                }

                if (GL.LinkProcGLEXT("glBindProgramPipeline"))
                {
                    GL.glBindProgramPipeline = (TglBindProgramPipeline)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindProgramPipeline));
                }

                if (GL.LinkProcGLEXT("glDeleteProgramPipelines"))
                {
                    GL.glDeleteProgramPipelines = (TglDeleteProgramPipelines)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteProgramPipelines));
                }

                if (GL.LinkProcGLEXT("glGenProgramPipelines"))
                {
                    GL.glGenProgramPipelines = (TglGenProgramPipelines)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenProgramPipelines));
                }

                if (GL.LinkProcGLEXT("glIsProgramPipeline"))
                {
                    GL.glIsProgramPipeline = (TglIsProgramPipeline)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsProgramPipeline));
                }

                if (GL.LinkProcGLEXT("glGetProgramPipelineiv"))
                {
                    GL.glGetProgramPipelineiv = (TglGetProgramPipelineiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramPipelineiv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1i"))
                {
                    GL.glProgramUniform1i = (TglProgramUniform1i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1i));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1iv"))
                {
                    GL.glProgramUniform1iv = (TglProgramUniform1iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1iv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1f"))
                {
                    GL.glProgramUniform1f = (TglProgramUniform1f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1f));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1fv"))
                {
                    GL.glProgramUniform1fv = (TglProgramUniform1fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1fv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1d"))
                {
                    GL.glProgramUniform1d = (TglProgramUniform1d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1d));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1dv"))
                {
                    GL.glProgramUniform1dv = (TglProgramUniform1dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1dv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1ui"))
                {
                    GL.glProgramUniform1ui = (TglProgramUniform1ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1ui));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1uiv"))
                {
                    GL.glProgramUniform1uiv = (TglProgramUniform1uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1uiv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2i"))
                {
                    GL.glProgramUniform2i = (TglProgramUniform2i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2i));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2iv"))
                {
                    GL.glProgramUniform2iv = (TglProgramUniform2iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2iv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2f"))
                {
                    GL.glProgramUniform2f = (TglProgramUniform2f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2f));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2fv"))
                {
                    GL.glProgramUniform2fv = (TglProgramUniform2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2fv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2d"))
                {
                    GL.glProgramUniform2d = (TglProgramUniform2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2d));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2dv"))
                {
                    GL.glProgramUniform2dv = (TglProgramUniform2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2dv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2ui"))
                {
                    GL.glProgramUniform2ui = (TglProgramUniform2ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2ui));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2uiv"))
                {
                    GL.glProgramUniform2uiv = (TglProgramUniform2uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2uiv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3i"))
                {
                    GL.glProgramUniform3i = (TglProgramUniform3i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3i));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3iv"))
                {
                    GL.glProgramUniform3iv = (TglProgramUniform3iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3iv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3f"))
                {
                    GL.glProgramUniform3f = (TglProgramUniform3f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3f));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3fv"))
                {
                    GL.glProgramUniform3fv = (TglProgramUniform3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3fv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3d"))
                {
                    GL.glProgramUniform3d = (TglProgramUniform3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3d));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3dv"))
                {
                    GL.glProgramUniform3dv = (TglProgramUniform3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3dv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3ui"))
                {
                    GL.glProgramUniform3ui = (TglProgramUniform3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3ui));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3uiv"))
                {
                    GL.glProgramUniform3uiv = (TglProgramUniform3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3uiv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4i"))
                {
                    GL.glProgramUniform4i = (TglProgramUniform4i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4i));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4iv"))
                {
                    GL.glProgramUniform4iv = (TglProgramUniform4iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4iv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4f"))
                {
                    GL.glProgramUniform4f = (TglProgramUniform4f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4f));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4fv"))
                {
                    GL.glProgramUniform4fv = (TglProgramUniform4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4fv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4d"))
                {
                    GL.glProgramUniform4d = (TglProgramUniform4d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4d));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4dv"))
                {
                    GL.glProgramUniform4dv = (TglProgramUniform4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4dv));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4ui"))
                {
                    GL.glProgramUniform4ui = (TglProgramUniform4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4ui));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4uiv"))
                {
                    GL.glProgramUniform4uiv = (TglProgramUniform4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4uiv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix2fv"))
                {
                    GL.glProgramUniformMatrix2fv = (TglProgramUniformMatrix2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2fv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix3fv"))
                {
                    GL.glProgramUniformMatrix3fv = (TglProgramUniformMatrix3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3fv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix4fv"))
                {
                    GL.glProgramUniformMatrix4fv = (TglProgramUniformMatrix4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4fv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix2dv"))
                {
                    GL.glProgramUniformMatrix2dv = (TglProgramUniformMatrix2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2dv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix3dv"))
                {
                    GL.glProgramUniformMatrix3dv = (TglProgramUniformMatrix3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3dv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix4dv"))
                {
                    GL.glProgramUniformMatrix4dv = (TglProgramUniformMatrix4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4dv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix2x3fv"))
                {
                    GL.glProgramUniformMatrix2x3fv = (TglProgramUniformMatrix2x3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2x3fv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix3x2fv"))
                {
                    GL.glProgramUniformMatrix3x2fv = (TglProgramUniformMatrix3x2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3x2fv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix2x4fv"))
                {
                    GL.glProgramUniformMatrix2x4fv = (TglProgramUniformMatrix2x4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2x4fv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix4x2fv"))
                {
                    GL.glProgramUniformMatrix4x2fv = (TglProgramUniformMatrix4x2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4x2fv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix3x4fv"))
                {
                    GL.glProgramUniformMatrix3x4fv = (TglProgramUniformMatrix3x4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3x4fv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix4x3fv"))
                {
                    GL.glProgramUniformMatrix4x3fv = (TglProgramUniformMatrix4x3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4x3fv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix2x3dv"))
                {
                    GL.glProgramUniformMatrix2x3dv = (TglProgramUniformMatrix2x3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2x3dv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix3x2dv"))
                {
                    GL.glProgramUniformMatrix3x2dv = (TglProgramUniformMatrix3x2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3x2dv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix2x4dv"))
                {
                    GL.glProgramUniformMatrix2x4dv = (TglProgramUniformMatrix2x4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2x4dv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix4x2dv"))
                {
                    GL.glProgramUniformMatrix4x2dv = (TglProgramUniformMatrix4x2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4x2dv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix3x4dv"))
                {
                    GL.glProgramUniformMatrix3x4dv = (TglProgramUniformMatrix3x4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3x4dv));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix4x3dv"))
                {
                    GL.glProgramUniformMatrix4x3dv = (TglProgramUniformMatrix4x3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4x3dv));
                }

                if (GL.LinkProcGLEXT("glValidateProgramPipeline"))
                {
                    GL.glValidateProgramPipeline = (TglValidateProgramPipeline)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglValidateProgramPipeline));
                }

                if (GL.LinkProcGLEXT("glGetProgramPipelineInfoLog"))
                {
                    GL.glGetProgramPipelineInfoLog = (TglGetProgramPipelineInfoLog)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramPipelineInfoLog));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_vertex_attrib_64bit
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.1 */
            if (GL.LinkGLEXT("GL_ARB_vertex_attrib_64bit"))
            {
                if (GL.LinkProcGLEXT("glVertexAttribL1d"))
                {
                    GL.glVertexAttribL1d = (TglVertexAttribL1d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL1d));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL2d"))
                {
                    GL.glVertexAttribL2d = (TglVertexAttribL2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL2d));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL3d"))
                {
                    GL.glVertexAttribL3d = (TglVertexAttribL3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL3d));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL4d"))
                {
                    GL.glVertexAttribL4d = (TglVertexAttribL4d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL4d));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL1dv"))
                {
                    GL.glVertexAttribL1dv = (TglVertexAttribL1dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL1dv));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL2dv"))
                {
                    GL.glVertexAttribL2dv = (TglVertexAttribL2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL2dv));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL3dv"))
                {
                    GL.glVertexAttribL3dv = (TglVertexAttribL3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL3dv));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL4dv"))
                {
                    GL.glVertexAttribL4dv = (TglVertexAttribL4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL4dv));
                }

                if (GL.LinkProcGLEXT("glVertexAttribLPointer"))
                {
                    GL.glVertexAttribLPointer = (TglVertexAttribLPointer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribLPointer));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribLdv"))
                {
                    GL.glGetVertexAttribLdv = (TglGetVertexAttribLdv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribLdv));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_viewport_array
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.1 */
            if (GL.LinkGLEXT("GL_ARB_viewport_array"))
            {
                if (GL.LinkProcGLEXT("glViewportArrayv"))
                {
                    GL.glViewportArrayv = (TglViewportArrayv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglViewportArrayv));
                }

                if (GL.LinkProcGLEXT("glViewportIndexedf"))
                {
                    GL.glViewportIndexedf = (TglViewportIndexedf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglViewportIndexedf));
                }

                if (GL.LinkProcGLEXT("glViewportIndexedfv"))
                {
                    GL.glViewportIndexedfv = (TglViewportIndexedfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglViewportIndexedfv));
                }

                if (GL.LinkProcGLEXT("glScissorArrayv"))
                {
                    GL.glScissorArrayv = (TglScissorArrayv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglScissorArrayv));
                }

                if (GL.LinkProcGLEXT("glScissorIndexed"))
                {
                    GL.glScissorIndexed = (TglScissorIndexed)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglScissorIndexed));
                }

                if (GL.LinkProcGLEXT("glScissorIndexedv"))
                {
                    GL.glScissorIndexedv = (TglScissorIndexedv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglScissorIndexedv));
                }

                if (GL.LinkProcGLEXT("glDepthRangeArrayv"))
                {
                    GL.glDepthRangeArrayv = (TglDepthRangeArrayv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthRangeArrayv));
                }

                if (GL.LinkProcGLEXT("glDepthRangeIndexed"))
                {
                    GL.glDepthRangeIndexed = (TglDepthRangeIndexed)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthRangeIndexed));
                }

                if (GL.LinkProcGLEXT("glGetFloati_v"))
                {
                    GL.glGetFloati_v = (TglGetFloati_v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFloati_v));
                }

                if (GL.LinkProcGLEXT("glGetDoublei_v"))
                {
                    GL.glGetDoublei_v = (TglGetDoublei_v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetDoublei_v));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_cl_event
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_cl_event"))
            {
                if (GL.LinkProcGLEXT("glCreateSyncFromCLeventARB"))
                {
                    GL.glCreateSyncFromCLeventARB = (TglCreateSyncFromCLeventARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateSyncFromCLeventARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_debug_output
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_debug_output"))
            {
                if (GL.LinkProcGLEXT("glDebugMessageControlARB"))
                {
                    GL.glDebugMessageControlARB = (TglDebugMessageControlARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageControlARB));
                }

                if (GL.LinkProcGLEXT("glDebugMessageInsertARB"))
                {
                    GL.glDebugMessageInsertARB = (TglDebugMessageInsertARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageInsertARB));
                }

                if (GL.LinkProcGLEXT("glDebugMessageCallbackARB"))
                {
                    GL.glDebugMessageCallbackARB = (TglDebugMessageCallbackARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageCallbackARB));
                }

                if (GL.LinkProcGLEXT("glGetDebugMessageLogARB"))
                {
                    GL.glGetDebugMessageLogARB = (TglGetDebugMessageLogARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetDebugMessageLogARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_robustness
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_robustness"))
            {
                if (GL.LinkProcGLEXT("glGetGraphicsResetStatusARB"))
                {
                    GL.glGetGraphicsResetStatusARB = (TglGetGraphicsResetStatusARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetGraphicsResetStatusARB));
                }

                if (GL.LinkProcGLEXT("glGetnMapdvARB"))
                {
                    GL.glGetnMapdvARB = (TglGetnMapdvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnMapdvARB));
                }

                if (GL.LinkProcGLEXT("glGetnMapfvARB"))
                {
                    GL.glGetnMapfvARB = (TglGetnMapfvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnMapfvARB));
                }

                if (GL.LinkProcGLEXT("glGetnMapivARB"))
                {
                    GL.glGetnMapivARB = (TglGetnMapivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnMapivARB));
                }

                if (GL.LinkProcGLEXT("glGetnPixelMapfvARB"))
                {
                    GL.glGetnPixelMapfvARB = (TglGetnPixelMapfvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnPixelMapfvARB));
                }

                if (GL.LinkProcGLEXT("glGetnPixelMapuivARB"))
                {
                    GL.glGetnPixelMapuivARB = (TglGetnPixelMapuivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnPixelMapuivARB));
                }

                if (GL.LinkProcGLEXT("glGetnPixelMapusvARB"))
                {
                    GL.glGetnPixelMapusvARB = (TglGetnPixelMapusvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnPixelMapusvARB));
                }

                if (GL.LinkProcGLEXT("glGetnPolygonStippleARB"))
                {
                    GL.glGetnPolygonStippleARB = (TglGetnPolygonStippleARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnPolygonStippleARB));
                }

                if (GL.LinkProcGLEXT("glGetnColorTableARB"))
                {
                    GL.glGetnColorTableARB = (TglGetnColorTableARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnColorTableARB));
                }

                if (GL.LinkProcGLEXT("glGetnConvolutionFilterARB"))
                {
                    GL.glGetnConvolutionFilterARB = (TglGetnConvolutionFilterARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnConvolutionFilterARB));
                }

                if (GL.LinkProcGLEXT("glGetnSeparableFilterARB"))
                {
                    GL.glGetnSeparableFilterARB = (TglGetnSeparableFilterARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnSeparableFilterARB));
                }

                if (GL.LinkProcGLEXT("glGetnHistogramARB"))
                {
                    GL.glGetnHistogramARB = (TglGetnHistogramARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnHistogramARB));
                }

                if (GL.LinkProcGLEXT("glGetnMinmaxARB"))
                {
                    GL.glGetnMinmaxARB = (TglGetnMinmaxARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnMinmaxARB));
                }

                if (GL.LinkProcGLEXT("glGetnTexImageARB"))
                {
                    GL.glGetnTexImageARB = (TglGetnTexImageARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnTexImageARB));
                }

                if (GL.LinkProcGLEXT("glReadnPixelsARB"))
                {
                    GL.glReadnPixelsARB = (TglReadnPixelsARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReadnPixelsARB));
                }

                if (GL.LinkProcGLEXT("glGetnCompressedTexImageARB"))
                {
                    GL.glGetnCompressedTexImageARB = (TglGetnCompressedTexImageARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnCompressedTexImageARB));
                }

                if (GL.LinkProcGLEXT("glGetnUniformfvARB"))
                {
                    GL.glGetnUniformfvARB = (TglGetnUniformfvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnUniformfvARB));
                }

                if (GL.LinkProcGLEXT("glGetnUniformivARB"))
                {
                    GL.glGetnUniformivARB = (TglGetnUniformivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnUniformivARB));
                }

                if (GL.LinkProcGLEXT("glGetnUniformuivARB"))
                {
                    GL.glGetnUniformuivARB = (TglGetnUniformuivARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnUniformuivARB));
                }

                if (GL.LinkProcGLEXT("glGetnUniformdvARB"))
                {
                    GL.glGetnUniformdvARB = (TglGetnUniformdvARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnUniformdvARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shader_stencil_export (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shader_stencil_export"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_base_instance
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.2 */
            if (GL.LinkGLEXT("GL_ARB_base_instance"))
            {
                if (GL.LinkProcGLEXT("glDrawArraysInstancedBaseInstance"))
                {
                    GL.glDrawArraysInstancedBaseInstance = (TglDrawArraysInstancedBaseInstance)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawArraysInstancedBaseInstance));
                }

                if (GL.LinkProcGLEXT("glDrawElementsInstancedBaseInstance"))
                {
                    GL.glDrawElementsInstancedBaseInstance = (TglDrawElementsInstancedBaseInstance)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementsInstancedBaseInstance));
                }

                if (GL.LinkProcGLEXT("glDrawElementsInstancedBaseVertexBaseInstance"))
                {
                    GL.glDrawElementsInstancedBaseVertexBaseInstance = (TglDrawElementsInstancedBaseVertexBaseInstance)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementsInstancedBaseVertexBaseInstance));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shading_language_420pack (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shading_language_420pack"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_transform_feedback_instanced
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.2 */
            if (GL.LinkGLEXT("GL_ARB_transform_feedback_instanced"))
            {
                if (GL.LinkProcGLEXT("glDrawTransformFeedbackInstanced"))
                {
                    GL.glDrawTransformFeedbackInstanced = (TglDrawTransformFeedbackInstanced)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawTransformFeedbackInstanced));
                }

                if (GL.LinkProcGLEXT("glDrawTransformFeedbackStreamInstanced"))
                {
                    GL.glDrawTransformFeedbackStreamInstanced = (TglDrawTransformFeedbackStreamInstanced)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawTransformFeedbackStreamInstanced));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_compressed_texture_pixel_storage (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_compressed_texture_pixel_storage"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_conservative_depth (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_conservative_depth"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_internalformat_query
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.2 */
            if (GL.LinkGLEXT("GL_ARB_internalformat_query"))
            {
                if (GL.LinkProcGLEXT("glGetInternalformativ"))
                {
                    GL.glGetInternalformativ = (TglGetInternalformativ)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetInternalformativ));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_map_buffer_alignment (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_map_buffer_alignment"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shader_atomic_counters
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.2 */
            if (GL.LinkGLEXT("GL_ARB_shader_atomic_counters"))
            {
                if (GL.LinkProcGLEXT("glGetActiveAtomicCounterBufferiv"))
                {
                    GL.glGetActiveAtomicCounterBufferiv = (TglGetActiveAtomicCounterBufferiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveAtomicCounterBufferiv));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shader_image_load_store
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.2 */
            if (GL.LinkGLEXT("GL_ARB_shader_image_load_store"))
            {
                if (GL.LinkProcGLEXT("glBindImageTexture"))
                {
                    GL.glBindImageTexture = (TglBindImageTexture)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindImageTexture));
                }

                if (GL.LinkProcGLEXT("glMemoryBarrier"))
                {
                    GL.glMemoryBarrier = (TglMemoryBarrier)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMemoryBarrier));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shading_language_packing (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shading_language_packing"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_storage
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.2 */
            if (GL.LinkGLEXT("GL_ARB_texture_storage"))
            {
                if (GL.LinkProcGLEXT("glTexStorage1D"))
                {
                    GL.glTexStorage1D = (TglTexStorage1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorage1D));
                }

                if (GL.LinkProcGLEXT("glTexStorage2D"))
                {
                    GL.glTexStorage2D = (TglTexStorage2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorage2D));
                }

                if (GL.LinkProcGLEXT("glTexStorage3D"))
                {
                    GL.glTexStorage3D = (TglTexStorage3D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorage3D));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_arrays_of_arrays (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_arrays_of_arrays"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_clear_buffer_object
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_ARB_clear_buffer_object"))
            {
                if (GL.LinkProcGLEXT("glClearBufferData"))
                {
                    GL.glClearBufferData = (TglClearBufferData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearBufferData));
                }

                if (GL.LinkProcGLEXT("glClearBufferSubData"))
                {
                    GL.glClearBufferSubData = (TglClearBufferSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearBufferSubData));
                }

                if (GL.LinkProcGLEXT("glClearNamedBufferDataEXT"))
                {
                    GL.glClearNamedBufferDataEXT = (TglClearNamedBufferDataEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearNamedBufferDataEXT));
                }

                if (GL.LinkProcGLEXT("glClearNamedBufferSubDataEXT"))
                {
                    GL.glClearNamedBufferSubDataEXT = (TglClearNamedBufferSubDataEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearNamedBufferSubDataEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_compute_shader
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_ARB_compute_shader"))
            {
                if (GL.LinkProcGLEXT("glDispatchCompute"))
                {
                    GL.glDispatchCompute = (TglDispatchCompute)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDispatchCompute));
                }

                if (GL.LinkProcGLEXT("glDispatchComputeIndirect"))
                {
                    GL.glDispatchComputeIndirect = (TglDispatchComputeIndirect)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDispatchComputeIndirect));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_copy_image
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_ARB_copy_image"))
            {
                if (GL.LinkProcGLEXT("glCopyImageSubData"))
                {
                    GL.glCopyImageSubData = (TglCopyImageSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyImageSubData));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_view
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_ARB_texture_view"))
            {
                if (GL.LinkProcGLEXT("glTextureView"))
                {
                    GL.glTextureView = (TglTextureView)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureView));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_vertex_attrib_binding
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_ARB_vertex_attrib_binding"))
            {
                if (GL.LinkProcGLEXT("glBindVertexBuffer"))
                {
                    GL.glBindVertexBuffer = (TglBindVertexBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindVertexBuffer));
                }

                if (GL.LinkProcGLEXT("glVertexAttribFormat"))
                {
                    GL.glVertexAttribFormat = (TglVertexAttribFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribFormat));
                }

                if (GL.LinkProcGLEXT("glVertexAttribIFormat"))
                {
                    GL.glVertexAttribIFormat = (TglVertexAttribIFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribIFormat));
                }

                if (GL.LinkProcGLEXT("glVertexAttribLFormat"))
                {
                    GL.glVertexAttribLFormat = (TglVertexAttribLFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribLFormat));
                }

                if (GL.LinkProcGLEXT("glVertexAttribBinding"))
                {
                    GL.glVertexAttribBinding = (TglVertexAttribBinding)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribBinding));
                }

                if (GL.LinkProcGLEXT("glVertexBindingDivisor"))
                {
                    GL.glVertexBindingDivisor = (TglVertexBindingDivisor)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexBindingDivisor));
                }

                if (GL.LinkProcGLEXT("glVertexArrayBindVertexBufferEXT"))
                {
                    GL.glVertexArrayBindVertexBufferEXT = (TglVertexArrayBindVertexBufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayBindVertexBufferEXT));
                }

                if (GL.LinkProcGLEXT("glVertexArrayVertexAttribFormatEXT"))
                {
                    GL.glVertexArrayVertexAttribFormatEXT = (TglVertexArrayVertexAttribFormatEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayVertexAttribFormatEXT));
                }

                if (GL.LinkProcGLEXT("glVertexArrayVertexAttribIFormatEXT"))
                {
                    GL.glVertexArrayVertexAttribIFormatEXT = (TglVertexArrayVertexAttribIFormatEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayVertexAttribIFormatEXT));
                }

                if (GL.LinkProcGLEXT("glVertexArrayVertexAttribLFormatEXT"))
                {
                    GL.glVertexArrayVertexAttribLFormatEXT = (TglVertexArrayVertexAttribLFormatEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayVertexAttribLFormatEXT));
                }

                if (GL.LinkProcGLEXT("glVertexArrayVertexAttribBindingEXT"))
                {
                    GL.glVertexArrayVertexAttribBindingEXT = (TglVertexArrayVertexAttribBindingEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayVertexAttribBindingEXT));
                }

                if (GL.LinkProcGLEXT("glVertexArrayVertexBindingDivisorEXT"))
                {
                    GL.glVertexArrayVertexBindingDivisorEXT = (TglVertexArrayVertexBindingDivisorEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayVertexBindingDivisorEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_robustness_isolation (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_robustness_isolation"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_ES3_compatibility (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_ES3_compatibility"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_explicit_uniform_location (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_explicit_uniform_location"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_fragment_layer_viewport (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_fragment_layer_viewport"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_framebuffer_no_attachments
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_ARB_framebuffer_no_attachments"))
            {
                if (GL.LinkProcGLEXT("glFramebufferParameteri"))
                {
                    GL.glFramebufferParameteri = (TglFramebufferParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferParameteri));
                }

                if (GL.LinkProcGLEXT("glGetFramebufferParameteriv"))
                {
                    GL.glGetFramebufferParameteriv = (TglGetFramebufferParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFramebufferParameteriv));
                }

                if (GL.LinkProcGLEXT("glNamedFramebufferParameteriEXT"))
                {
                    GL.glNamedFramebufferParameteriEXT = (TglNamedFramebufferParameteriEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferParameteriEXT));
                }

                if (GL.LinkProcGLEXT("glGetNamedFramebufferParameterivEXT"))
                {
                    GL.glGetNamedFramebufferParameterivEXT = (TglGetNamedFramebufferParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedFramebufferParameterivEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_internalformat_query2
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_ARB_internalformat_query2"))
            {
                if (GL.LinkProcGLEXT("glGetInternalformati64v"))
                {
                    GL.glGetInternalformati64v = (TglGetInternalformati64v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetInternalformati64v));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_invalidate_subdata
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_ARB_invalidate_subdata"))
            {
                if (GL.LinkProcGLEXT("glInvalidateTexSubImage"))
                {
                    GL.glInvalidateTexSubImage = (TglInvalidateTexSubImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateTexSubImage));
                }

                if (GL.LinkProcGLEXT("glInvalidateTexImage"))
                {
                    GL.glInvalidateTexImage = (TglInvalidateTexImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateTexImage));
                }

                if (GL.LinkProcGLEXT("glInvalidateBufferSubData"))
                {
                    GL.glInvalidateBufferSubData = (TglInvalidateBufferSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateBufferSubData));
                }

                if (GL.LinkProcGLEXT("glInvalidateBufferData"))
                {
                    GL.glInvalidateBufferData = (TglInvalidateBufferData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateBufferData));
                }

                if (GL.LinkProcGLEXT("glInvalidateFramebuffer"))
                {
                    GL.glInvalidateFramebuffer = (TglInvalidateFramebuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateFramebuffer));
                }

                if (GL.LinkProcGLEXT("glInvalidateSubFramebuffer"))
                {
                    GL.glInvalidateSubFramebuffer = (TglInvalidateSubFramebuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateSubFramebuffer));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_multi_draw_indirect
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_ARB_multi_draw_indirect"))
            {
                if (GL.LinkProcGLEXT("glMultiDrawArraysIndirect"))
                {
                    GL.glMultiDrawArraysIndirect = (TglMultiDrawArraysIndirect)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawArraysIndirect));
                }

                if (GL.LinkProcGLEXT("glMultiDrawElementsIndirect"))
                {
                    GL.glMultiDrawElementsIndirect = (TglMultiDrawElementsIndirect)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawElementsIndirect));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_program_interface_query
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_ARB_program_interface_query"))
            {
                if (GL.LinkProcGLEXT("glGetProgramInterfaceiv"))
                {
                    GL.glGetProgramInterfaceiv = (TglGetProgramInterfaceiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramInterfaceiv));
                }

                if (GL.LinkProcGLEXT("glGetProgramResourceIndex"))
                {
                    GL.glGetProgramResourceIndex = (TglGetProgramResourceIndex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramResourceIndex));
                }

                if (GL.LinkProcGLEXT("glGetProgramResourceName"))
                {
                    GL.glGetProgramResourceName = (TglGetProgramResourceName)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramResourceName));
                }

                if (GL.LinkProcGLEXT("glGetProgramResourceiv"))
                {
                    GL.glGetProgramResourceiv = (TglGetProgramResourceiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramResourceiv));
                }

                if (GL.LinkProcGLEXT("glGetProgramResourceLocation"))
                {
                    GL.glGetProgramResourceLocation = (TglGetProgramResourceLocation)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramResourceLocation));
                }

                if (GL.LinkProcGLEXT("glGetProgramResourceLocationIndex"))
                {
                    GL.glGetProgramResourceLocationIndex = (TglGetProgramResourceLocationIndex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramResourceLocationIndex));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_robust_buffer_access_behavior (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_robust_buffer_access_behavior"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shader_image_size (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shader_image_size"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shader_storage_buffer_object
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_ARB_shader_storage_buffer_object"))
            {
                if (GL.LinkProcGLEXT("glShaderStorageBlockBinding"))
                {
                    GL.glShaderStorageBlockBinding = (TglShaderStorageBlockBinding)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglShaderStorageBlockBinding));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_stencil_texturing (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_stencil_texturing"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_buffer_range
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_ARB_texture_buffer_range"))
            {
                if (GL.LinkProcGLEXT("glTexBufferRange"))
                {
                    GL.glTexBufferRange = (TglTexBufferRange)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexBufferRange));
                }

                if (GL.LinkProcGLEXT("glTextureBufferRangeEXT"))
                {
                    GL.glTextureBufferRangeEXT = (TglTextureBufferRangeEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureBufferRangeEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_query_levels (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_query_levels"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_storage_multisample
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_ARB_texture_storage_multisample"))
            {
                if (GL.LinkProcGLEXT("glTexStorage2DMultisample"))
                {
                    GL.glTexStorage2DMultisample = (TglTexStorage2DMultisample)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorage2DMultisample));
                }

                if (GL.LinkProcGLEXT("glTexStorage3DMultisample"))
                {
                    GL.glTexStorage3DMultisample = (TglTexStorage3DMultisample)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorage3DMultisample));
                }

                if (GL.LinkProcGLEXT("glTextureStorage2DMultisampleEXT"))
                {
                    GL.glTextureStorage2DMultisampleEXT = (TglTextureStorage2DMultisampleEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureStorage2DMultisampleEXT));
                }

                if (GL.LinkProcGLEXT("glTextureStorage3DMultisampleEXT"))
                {
                    GL.glTextureStorage3DMultisampleEXT = (TglTextureStorage3DMultisampleEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureStorage3DMultisampleEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_buffer_storage (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_buffer_storage"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_clear_texture (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_clear_texture"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_multi_bind (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_multi_bind"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_query_buffer_object (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_query_buffer_object"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_seamless_cubemap_per_texture (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_seamless_cubemap_per_texture"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shader_draw_parameters (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shader_draw_parameters"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shader_group_vote (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shader_group_vote"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_mirror_clamp_to_edge (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_mirror_clamp_to_edge"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_stencil8 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_stencil8"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_vertex_type_10f_11f_11f_rev (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_vertex_type_10f_11f_11f_rev"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_bindless_texture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_bindless_texture"))
            {
                if (GL.LinkProcGLEXT("glGetTextureHandleARB"))
                {
                    GL.glGetTextureHandleARB = (TglGetTextureHandleARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureHandleARB));
                }

                if (GL.LinkProcGLEXT("glGetTextureSamplerHandleARB"))
                {
                    GL.glGetTextureSamplerHandleARB = (TglGetTextureSamplerHandleARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureSamplerHandleARB));
                }

                if (GL.LinkProcGLEXT("glMakeTextureHandleResidentARB"))
                {
                    GL.glMakeTextureHandleResidentARB = (TglMakeTextureHandleResidentARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMakeTextureHandleResidentARB));
                }

                if (GL.LinkProcGLEXT("glMakeTextureHandleNonResidentARB"))
                {
                    GL.glMakeTextureHandleNonResidentARB = (TglMakeTextureHandleNonResidentARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMakeTextureHandleNonResidentARB));
                }

                if (GL.LinkProcGLEXT("glGetImageHandleARB"))
                {
                    GL.glGetImageHandleARB = (TglGetImageHandleARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetImageHandleARB));
                }

                if (GL.LinkProcGLEXT("glMakeImageHandleResidentARB"))
                {
                    GL.glMakeImageHandleResidentARB = (TglMakeImageHandleResidentARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMakeImageHandleResidentARB));
                }

                if (GL.LinkProcGLEXT("glMakeImageHandleNonResidentARB"))
                {
                    GL.glMakeImageHandleNonResidentARB = (TglMakeImageHandleNonResidentARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMakeImageHandleNonResidentARB));
                }

                if (GL.LinkProcGLEXT("glUniformHandleui64ARB"))
                {
                    GL.glUniformHandleui64ARB = (TglUniformHandleui64ARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformHandleui64ARB));
                }

                if (GL.LinkProcGLEXT("glUniformHandleui64vARB"))
                {
                    GL.glUniformHandleui64vARB = (TglUniformHandleui64vARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformHandleui64vARB));
                }

                if (GL.LinkProcGLEXT("glProgramUniformHandleui64ARB"))
                {
                    GL.glProgramUniformHandleui64ARB = (TglProgramUniformHandleui64ARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformHandleui64ARB));
                }

                if (GL.LinkProcGLEXT("glProgramUniformHandleui64vARB"))
                {
                    GL.glProgramUniformHandleui64vARB = (TglProgramUniformHandleui64vARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformHandleui64vARB));
                }

                if (GL.LinkProcGLEXT("glIsTextureHandleResidentARB"))
                {
                    GL.glIsTextureHandleResidentARB = (TglIsTextureHandleResidentARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsTextureHandleResidentARB));
                }

                if (GL.LinkProcGLEXT("glIsImageHandleResidentARB"))
                {
                    GL.glIsImageHandleResidentARB = (TglIsImageHandleResidentARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsImageHandleResidentARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL1ui64ARB"))
                {
                    GL.glVertexAttribL1ui64ARB = (TglVertexAttribL1ui64ARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL1ui64ARB));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL1ui64vARB"))
                {
                    GL.glVertexAttribL1ui64vARB = (TglVertexAttribL1ui64vARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL1ui64vARB));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribLui64vARB"))
                {
                    GL.glGetVertexAttribLui64vARB = (TglGetVertexAttribLui64vARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribLui64vARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_compute_variable_group_size
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_compute_variable_group_size"))
            {
                if (GL.LinkProcGLEXT("glDispatchComputeGroupSizeARB"))
                {
                    GL.glDispatchComputeGroupSizeARB = (TglDispatchComputeGroupSizeARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDispatchComputeGroupSizeARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_indirect_parameters
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_indirect_parameters"))
            {
                if (GL.LinkProcGLEXT("glMultiDrawArraysIndirectCountARB"))
                {
                    GL.glMultiDrawArraysIndirectCountARB = (TglMultiDrawArraysIndirectCountARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawArraysIndirectCountARB));
                }

                if (GL.LinkProcGLEXT("glMultiDrawElementsIndirectCountARB"))
                {
                    GL.glMultiDrawElementsIndirectCountARB = (TglMultiDrawElementsIndirectCountARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawElementsIndirectCountARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_sparse_texture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_sparse_texture"))
            {
                if (GL.LinkProcGLEXT("glTexPageCommitmentARB"))
                {
                    GL.glTexPageCommitmentARB = (TglTexPageCommitmentARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexPageCommitmentARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_enhanced_layouts (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_enhanced_layouts"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_ES3_1_compatibility (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_ES3_1_compatibility"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_clip_control (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_clip_control"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_conditional_render_inverted (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_conditional_render_inverted"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_cull_distance (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_cull_distance"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_derivative_control (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_derivative_control"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_direct_state_access (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_direct_state_access"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_get_texture_sub_image (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_get_texture_sub_image"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_pipeline_statistics_query (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_pipeline_statistics_query"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_shader_texture_image_samples (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_shader_texture_image_samples"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_sparse_buffer
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_sparse_buffer"))
            {
                if (GL.LinkProcGLEXT("glBufferPageCommitmentARB"))
                {
                    GL.glBufferPageCommitmentARB = (TglBufferPageCommitmentARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBufferPageCommitmentARB));
                }
                
                if (GL.LinkProcGLEXT("glNamedBufferPageCommitmentEXT"))
                {
                    GL.glNamedBufferPageCommitmentEXT = (TglNamedBufferPageCommitmentEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedBufferPageCommitmentEXT));
                }

                if (GL.LinkProcGLEXT("glNamedBufferPageCommitmentARB"))
                {
                    GL.glNamedBufferPageCommitmentARB = (TglNamedBufferPageCommitmentARB)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedBufferPageCommitmentARB));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_texture_barrier (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_texture_barrier"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ARB_transform_feedback_overflow_query (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ARB_transform_feedback_overflow_query"))
            {
            }
            
            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_ATI_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_texture_mirror_once (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_texture_mirror_once"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_envmap_bumpmap
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_envmap_bumpmap"))
            {
                if (GL.LinkProcGLEXT("glTexBumpParameterivATI"))
                {
                    GL.glTexBumpParameterivATI = (TglTexBumpParameterivATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexBumpParameterivATI));
                }

                if (GL.LinkProcGLEXT("glTexBumpParameterfvATI"))
                {
                    GL.glTexBumpParameterfvATI = (TglTexBumpParameterfvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexBumpParameterfvATI));
                }

                if (GL.LinkProcGLEXT("glGetTexBumpParameterivATI"))
                {
                    GL.glGetTexBumpParameterivATI = (TglGetTexBumpParameterivATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexBumpParameterivATI));
                }

                if (GL.LinkProcGLEXT("glGetTexBumpParameterfvATI"))
                {
                    GL.glGetTexBumpParameterfvATI = (TglGetTexBumpParameterfvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexBumpParameterfvATI));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_fragment_shader
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_fragment_shader"))
            {
                if (GL.LinkProcGLEXT("glGenFragmentShadersATI"))
                {
                    GL.glGenFragmentShadersATI = (TglGenFragmentShadersATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenFragmentShadersATI));
                }

                if (GL.LinkProcGLEXT("glBindFragmentShaderATI"))
                {
                    GL.glBindFragmentShaderATI = (TglBindFragmentShaderATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindFragmentShaderATI));
                }

                if (GL.LinkProcGLEXT("glDeleteFragmentShaderATI"))
                {
                    GL.glDeleteFragmentShaderATI = (TglDeleteFragmentShaderATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteFragmentShaderATI));
                }

                if (GL.LinkProcGLEXT("glBeginFragmentShaderATI"))
                {
                    GL.glBeginFragmentShaderATI = (TglBeginFragmentShaderATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginFragmentShaderATI));
                }

                if (GL.LinkProcGLEXT("glEndFragmentShaderATI"))
                {
                    GL.glEndFragmentShaderATI = (TglEndFragmentShaderATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndFragmentShaderATI));
                }

                if (GL.LinkProcGLEXT("glPassTexCoordATI"))
                {
                    GL.glPassTexCoordATI = (TglPassTexCoordATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPassTexCoordATI));
                }

                if (GL.LinkProcGLEXT("glSampleMapATI"))
                {
                    GL.glSampleMapATI = (TglSampleMapATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSampleMapATI));
                }

                if (GL.LinkProcGLEXT("glColorFragmentOp1ATI"))
                {
                    GL.glColorFragmentOp1ATI = (TglColorFragmentOp1ATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorFragmentOp1ATI));
                }

                if (GL.LinkProcGLEXT("glColorFragmentOp2ATI"))
                {
                    GL.glColorFragmentOp2ATI = (TglColorFragmentOp2ATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorFragmentOp2ATI));
                }

                if (GL.LinkProcGLEXT("glColorFragmentOp3ATI"))
                {
                    GL.glColorFragmentOp3ATI = (TglColorFragmentOp3ATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorFragmentOp3ATI));
                }

                if (GL.LinkProcGLEXT("glAlphaFragmentOp1ATI"))
                {
                    GL.glAlphaFragmentOp1ATI = (TglAlphaFragmentOp1ATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAlphaFragmentOp1ATI));
                }

                if (GL.LinkProcGLEXT("glAlphaFragmentOp2ATI"))
                {
                    GL.glAlphaFragmentOp2ATI = (TglAlphaFragmentOp2ATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAlphaFragmentOp2ATI));
                }

                if (GL.LinkProcGLEXT("glAlphaFragmentOp3ATI"))
                {
                    GL.glAlphaFragmentOp3ATI = (TglAlphaFragmentOp3ATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAlphaFragmentOp3ATI));
                }

                if (GL.LinkProcGLEXT("glSetFragmentShaderConstantATI"))
                {
                    GL.glSetFragmentShaderConstantATI = (TglSetFragmentShaderConstantATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSetFragmentShaderConstantATI));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_pn_triangles
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_pn_triangles"))
            {
                if (GL.LinkProcGLEXT("glPNTrianglesiATI"))
                {
                    GL.glPNTrianglesiATI = (TglPNTrianglesiATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPNTrianglesiATI));
                }

                if (GL.LinkProcGLEXT("glPNTrianglesfATI"))
                {
                    GL.glPNTrianglesfATI = (TglPNTrianglesfATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPNTrianglesfATI));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_vertex_array_object
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_vertex_array_object"))
            {
                if (GL.LinkProcGLEXT("glNewObjectBufferATI"))
                {
                    GL.glNewObjectBufferATI = (TglNewObjectBufferATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNewObjectBufferATI));
                }

                if (GL.LinkProcGLEXT("glIsObjectBufferATI"))
                {
                    GL.glIsObjectBufferATI = (TglIsObjectBufferATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsObjectBufferATI));
                }

                if (GL.LinkProcGLEXT("glUpdateObjectBufferATI"))
                {
                    GL.glUpdateObjectBufferATI = (TglUpdateObjectBufferATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUpdateObjectBufferATI));
                }

                if (GL.LinkProcGLEXT("glGetObjectBufferfvATI"))
                {
                    GL.glGetObjectBufferfvATI = (TglGetObjectBufferfvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetObjectBufferfvATI));
                }

                if (GL.LinkProcGLEXT("glGetObjectBufferivATI"))
                {
                    GL.glGetObjectBufferivATI = (TglGetObjectBufferivATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetObjectBufferivATI));
                }

                if (GL.LinkProcGLEXT("glFreeObjectBufferATI"))
                {
                    GL.glFreeObjectBufferATI = (TglFreeObjectBufferATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFreeObjectBufferATI));
                }

                if (GL.LinkProcGLEXT("glArrayObjectATI"))
                {
                    GL.glArrayObjectATI = (TglArrayObjectATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglArrayObjectATI));
                }

                if (GL.LinkProcGLEXT("glGetArrayObjectfvATI"))
                {
                    GL.glGetArrayObjectfvATI = (TglGetArrayObjectfvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetArrayObjectfvATI));
                }

                if (GL.LinkProcGLEXT("glGetArrayObjectivATI"))
                {
                    GL.glGetArrayObjectivATI = (TglGetArrayObjectivATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetArrayObjectivATI));
                }

                if (GL.LinkProcGLEXT("glVariantArrayObjectATI"))
                {
                    GL.glVariantArrayObjectATI = (TglVariantArrayObjectATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVariantArrayObjectATI));
                }

                if (GL.LinkProcGLEXT("glGetVariantArrayObjectfvATI"))
                {
                    GL.glGetVariantArrayObjectfvATI = (TglGetVariantArrayObjectfvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVariantArrayObjectfvATI));
                }

                if (GL.LinkProcGLEXT("glGetVariantArrayObjectivATI"))
                {
                    GL.glGetVariantArrayObjectivATI = (TglGetVariantArrayObjectivATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVariantArrayObjectivATI));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_vertex_streams
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_vertex_streams"))
            {
                if (GL.LinkProcGLEXT("glVertexStream1sATI"))
                {
                    GL.glVertexStream1sATI = (TglVertexStream1sATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream1sATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream1svATI"))
                {
                    GL.glVertexStream1svATI = (TglVertexStream1svATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream1svATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream1iATI"))
                {
                    GL.glVertexStream1iATI = (TglVertexStream1iATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream1iATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream1ivATI"))
                {
                    GL.glVertexStream1ivATI = (TglVertexStream1ivATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream1ivATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream1fATI"))
                {
                    GL.glVertexStream1fATI = (TglVertexStream1fATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream1fATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream1fvATI"))
                {
                    GL.glVertexStream1fvATI = (TglVertexStream1fvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream1fvATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream1dATI"))
                {
                    GL.glVertexStream1dATI = (TglVertexStream1dATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream1dATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream1dvATI"))
                {
                    GL.glVertexStream1dvATI = (TglVertexStream1dvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream1dvATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream2sATI"))
                {
                    GL.glVertexStream2sATI = (TglVertexStream2sATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream2sATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream2svATI"))
                {
                    GL.glVertexStream2svATI = (TglVertexStream2svATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream2svATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream2iATI"))
                {
                    GL.glVertexStream2iATI = (TglVertexStream2iATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream2iATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream2ivATI"))
                {
                    GL.glVertexStream2ivATI = (TglVertexStream2ivATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream2ivATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream2fATI"))
                {
                    GL.glVertexStream2fATI = (TglVertexStream2fATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream2fATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream2fvATI"))
                {
                    GL.glVertexStream2fvATI = (TglVertexStream2fvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream2fvATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream2dATI"))
                {
                    GL.glVertexStream2dATI = (TglVertexStream2dATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream2dATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream2dvATI"))
                {
                    GL.glVertexStream2dvATI = (TglVertexStream2dvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream2dvATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream3sATI"))
                {
                    GL.glVertexStream3sATI = (TglVertexStream3sATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream3sATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream3svATI"))
                {
                    GL.glVertexStream3svATI = (TglVertexStream3svATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream3svATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream3iATI"))
                {
                    GL.glVertexStream3iATI = (TglVertexStream3iATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream3iATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream3ivATI"))
                {
                    GL.glVertexStream3ivATI = (TglVertexStream3ivATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream3ivATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream3fATI"))
                {
                    GL.glVertexStream3fATI = (TglVertexStream3fATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream3fATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream3fvATI"))
                {
                    GL.glVertexStream3fvATI = (TglVertexStream3fvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream3fvATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream3dATI"))
                {
                    GL.glVertexStream3dATI = (TglVertexStream3dATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream3dATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream3dvATI"))
                {
                    GL.glVertexStream3dvATI = (TglVertexStream3dvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream3dvATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream4sATI"))
                {
                    GL.glVertexStream4sATI = (TglVertexStream4sATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream4sATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream4svATI"))
                {
                    GL.glVertexStream4svATI = (TglVertexStream4svATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream4svATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream4iATI"))
                {
                    GL.glVertexStream4iATI = (TglVertexStream4iATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream4iATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream4ivATI"))
                {
                    GL.glVertexStream4ivATI = (TglVertexStream4ivATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream4ivATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream4fATI"))
                {
                    GL.glVertexStream4fATI = (TglVertexStream4fATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream4fATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream4fvATI"))
                {
                    GL.glVertexStream4fvATI = (TglVertexStream4fvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream4fvATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream4dATI"))
                {
                    GL.glVertexStream4dATI = (TglVertexStream4dATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream4dATI));
                }

                if (GL.LinkProcGLEXT("glVertexStream4dvATI"))
                {
                    GL.glVertexStream4dvATI = (TglVertexStream4dvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexStream4dvATI));
                }

                if (GL.LinkProcGLEXT("glNormalStream3bATI"))
                {
                    GL.glNormalStream3bATI = (TglNormalStream3bATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalStream3bATI));
                }

                if (GL.LinkProcGLEXT("glNormalStream3bvATI"))
                {
                    GL.glNormalStream3bvATI = (TglNormalStream3bvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalStream3bvATI));
                }

                if (GL.LinkProcGLEXT("glNormalStream3sATI"))
                {
                    GL.glNormalStream3sATI = (TglNormalStream3sATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalStream3sATI));
                }

                if (GL.LinkProcGLEXT("glNormalStream3svATI"))
                {
                    GL.glNormalStream3svATI = (TglNormalStream3svATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalStream3svATI));
                }

                if (GL.LinkProcGLEXT("glNormalStream3iATI"))
                {
                    GL.glNormalStream3iATI = (TglNormalStream3iATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalStream3iATI));
                }

                if (GL.LinkProcGLEXT("glNormalStream3ivATI"))
                {
                    GL.glNormalStream3ivATI = (TglNormalStream3ivATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalStream3ivATI));
                }

                if (GL.LinkProcGLEXT("glNormalStream3fATI"))
                {
                    GL.glNormalStream3fATI = (TglNormalStream3fATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalStream3fATI));
                }

                if (GL.LinkProcGLEXT("glNormalStream3fvATI"))
                {
                    GL.glNormalStream3fvATI = (TglNormalStream3fvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalStream3fvATI));
                }

                if (GL.LinkProcGLEXT("glNormalStream3dATI"))
                {
                    GL.glNormalStream3dATI = (TglNormalStream3dATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalStream3dATI));
                }

                if (GL.LinkProcGLEXT("glNormalStream3dvATI"))
                {
                    GL.glNormalStream3dvATI = (TglNormalStream3dvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalStream3dvATI));
                }

                if (GL.LinkProcGLEXT("glClientActiveVertexStreamATI"))
                {
                    GL.glClientActiveVertexStreamATI = (TglClientActiveVertexStreamATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClientActiveVertexStreamATI));
                }

                if (GL.LinkProcGLEXT("glVertexBlendEnviATI"))
                {
                    GL.glVertexBlendEnviATI = (TglVertexBlendEnviATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexBlendEnviATI));
                }

                if (GL.LinkProcGLEXT("glVertexBlendEnvfATI"))
                {
                    GL.glVertexBlendEnvfATI = (TglVertexBlendEnvfATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexBlendEnvfATI));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_element_array
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_element_array"))
            {
                if (GL.LinkProcGLEXT("glElementPointerATI"))
                {
                    GL.glElementPointerATI = (TglElementPointerATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglElementPointerATI));
                }

                if (GL.LinkProcGLEXT("glDrawElementArrayATI"))
                {
                    GL.glDrawElementArrayATI = (TglDrawElementArrayATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementArrayATI));
                }

                if (GL.LinkProcGLEXT("glDrawRangeElementArrayATI"))
                {
                    GL.glDrawRangeElementArrayATI = (TglDrawRangeElementArrayATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawRangeElementArrayATI));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_text_fragment_shader (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_text_fragment_shader"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_draw_buffers
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_draw_buffers"))
            {
                if (GL.LinkProcGLEXT("glDrawBuffersATI"))
                {
                    GL.glDrawBuffersATI = (TglDrawBuffersATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawBuffersATI));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_pixel_format_float
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_pixel_format_float"))
            {
            }
            /* This is really a WGL extension, but defines some associated GL enums.
             * ATI does not export "GL_ATI_pixel_format_float" in the GL_EXTENSIONS string.
             */

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_texture_env_combine3 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_texture_env_combine3"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_texture_float (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_texture_float"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_map_object_buffer
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_map_object_buffer"))
            {
                if (GL.LinkProcGLEXT("glMapObjectBufferATI"))
                {
                    GL.glMapObjectBufferATI = (TglMapObjectBufferATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapObjectBufferATI));
                }

                if (GL.LinkProcGLEXT("glUnmapObjectBufferATI"))
                {
                    GL.glUnmapObjectBufferATI = (TglUnmapObjectBufferATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUnmapObjectBufferATI));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_separate_stencil
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_separate_stencil"))
            {
                if (GL.LinkProcGLEXT("glStencilOpSeparateATI"))
                {
                    GL.glStencilOpSeparateATI = (TglStencilOpSeparateATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilOpSeparateATI));
                }

                if (GL.LinkProcGLEXT("glStencilFuncSeparateATI"))
                {
                    GL.glStencilFuncSeparateATI = (TglStencilFuncSeparateATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilFuncSeparateATI));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_vertex_attrib_array_object
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_vertex_attrib_array_object"))
            {
                if (GL.LinkProcGLEXT("glVertexAttribArrayObjectATI"))
                {
                    GL.glVertexAttribArrayObjectATI = (TglVertexAttribArrayObjectATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribArrayObjectATI));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribArrayObjectfvATI"))
                {
                    GL.glGetVertexAttribArrayObjectfvATI = (TglGetVertexAttribArrayObjectfvATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribArrayObjectfvATI));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribArrayObjectivATI"))
                {
                    GL.glGetVertexAttribArrayObjectivATI = (TglGetVertexAttribArrayObjectivATI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribArrayObjectivATI));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_meminfo (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_meminfo"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_ATI_texture_compression_3dc (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_ATI_texture_compression_3dc"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_EXT_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_abgr (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_abgr"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_blend_color
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_blend_color"))
            {
                if (GL.LinkProcGLEXT("glBlendColorEXT"))
                {
                    GL.glBlendColorEXT = (TglBlendColorEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendColorEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_polygon_offset
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_polygon_offset"))
            {
                if (GL.LinkProcGLEXT("glPolygonOffsetEXT"))
                {
                    GL.glPolygonOffsetEXT = (TglPolygonOffsetEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPolygonOffsetEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_compression_dxt1 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_compression_dxt1"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_compression_s3tc (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_compression_s3tc"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_cube_map (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_cube_map"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture3D
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture3D"))
            {
                if (GL.LinkProcGLEXT("glTexImage3DEXT"))
                {
                    GL.glTexImage3DEXT = (TglTexImage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexImage3DEXT));
                }

                if (GL.LinkProcGLEXT("glTexSubImage3DEXT"))
                {
                    GL.glTexSubImage3DEXT = (TglTexSubImage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexSubImage3DEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_subtexture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_subtexture"))
            {
                if (GL.LinkProcGLEXT("glTexSubImage1DEXT"))
                {
                    GL.glTexSubImage1DEXT = (TglTexSubImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexSubImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glTexSubImage2DEXT"))
                {
                    GL.glTexSubImage2DEXT = (TglTexSubImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexSubImage2DEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_copy_texture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_copy_texture"))
            {
                if (GL.LinkProcGLEXT("glCopyTexImage1DEXT"))
                {
                    GL.glCopyTexImage1DEXT = (TglCopyTexImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTexImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyTexImage2DEXT"))
                {
                    GL.glCopyTexImage2DEXT = (TglCopyTexImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTexImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyTexSubImage1DEXT"))
                {
                    GL.glCopyTexSubImage1DEXT = (TglCopyTexSubImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTexSubImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyTexSubImage2DEXT"))
                {
                    GL.glCopyTexSubImage2DEXT = (TglCopyTexSubImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTexSubImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyTexSubImage3DEXT"))
                {
                    GL.glCopyTexSubImage3DEXT = (TglCopyTexSubImage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTexSubImage3DEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_histogram
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_histogram"))
            {
                if (GL.LinkProcGLEXT("glGetHistogramEXT"))
                {
                    GL.glGetHistogramEXT = (TglGetHistogramEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetHistogramEXT));
                }

                if (GL.LinkProcGLEXT("glGetHistogramParameterfvEXT"))
                {
                    GL.glGetHistogramParameterfvEXT = (TglGetHistogramParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetHistogramParameterfvEXT));
                }

                if (GL.LinkProcGLEXT("glGetHistogramParameterivEXT"))
                {
                    GL.glGetHistogramParameterivEXT = (TglGetHistogramParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetHistogramParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glGetMinmaxEXT"))
                {
                    GL.glGetMinmaxEXT = (TglGetMinmaxEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMinmaxEXT));
                }

                if (GL.LinkProcGLEXT("glGetMinmaxParameterfvEXT"))
                {
                    GL.glGetMinmaxParameterfvEXT = (TglGetMinmaxParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMinmaxParameterfvEXT));
                }

                if (GL.LinkProcGLEXT("glGetMinmaxParameterivEXT"))
                {
                    GL.glGetMinmaxParameterivEXT = (TglGetMinmaxParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMinmaxParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glHistogramEXT"))
                {
                    GL.glHistogramEXT = (TglHistogramEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglHistogramEXT));
                }

                if (GL.LinkProcGLEXT("glMinmaxEXT"))
                {
                    GL.glMinmaxEXT = (TglMinmaxEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMinmaxEXT));
                }

                if (GL.LinkProcGLEXT("glResetHistogramEXT"))
                {
                    GL.glResetHistogramEXT = (TglResetHistogramEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglResetHistogramEXT));
                }

                if (GL.LinkProcGLEXT("glResetMinmaxEXT"))
                {
                    GL.glResetMinmaxEXT = (TglResetMinmaxEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglResetMinmaxEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_convolution
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_convolution"))
            {
                if (GL.LinkProcGLEXT("glConvolutionFilter1DEXT"))
                {
                    GL.glConvolutionFilter1DEXT = (TglConvolutionFilter1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionFilter1DEXT));
                }

                if (GL.LinkProcGLEXT("glConvolutionFilter2DEXT"))
                {
                    GL.glConvolutionFilter2DEXT = (TglConvolutionFilter2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionFilter2DEXT));
                }

                if (GL.LinkProcGLEXT("glConvolutionParameterfEXT"))
                {
                    GL.glConvolutionParameterfEXT = (TglConvolutionParameterfEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameterfEXT));
                }

                if (GL.LinkProcGLEXT("glConvolutionParameterfvEXT"))
                {
                    GL.glConvolutionParameterfvEXT = (TglConvolutionParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameterfvEXT));
                }

                if (GL.LinkProcGLEXT("glConvolutionParameteriEXT"))
                {
                    GL.glConvolutionParameteriEXT = (TglConvolutionParameteriEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameteriEXT));
                }

                if (GL.LinkProcGLEXT("glConvolutionParameterivEXT"))
                {
                    GL.glConvolutionParameterivEXT = (TglConvolutionParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glCopyConvolutionFilter1DEXT"))
                {
                    GL.glCopyConvolutionFilter1DEXT = (TglCopyConvolutionFilter1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyConvolutionFilter1DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyConvolutionFilter2DEXT"))
                {
                    GL.glCopyConvolutionFilter2DEXT = (TglCopyConvolutionFilter2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyConvolutionFilter2DEXT));
                }

                if (GL.LinkProcGLEXT("glGetConvolutionFilterEXT"))
                {
                    GL.glGetConvolutionFilterEXT = (TglGetConvolutionFilterEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetConvolutionFilterEXT));
                }

                if (GL.LinkProcGLEXT("glGetConvolutionParameterfvEXT"))
                {
                    GL.glGetConvolutionParameterfvEXT = (TglGetConvolutionParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetConvolutionParameterfvEXT));
                }

                if (GL.LinkProcGLEXT("glGetConvolutionParameterivEXT"))
                {
                    GL.glGetConvolutionParameterivEXT = (TglGetConvolutionParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetConvolutionParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glGetSeparableFilterEXT"))
                {
                    GL.glGetSeparableFilterEXT = (TglGetSeparableFilterEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSeparableFilterEXT));
                }

                if (GL.LinkProcGLEXT("glSeparableFilter2DEXT"))
                {
                    GL.glSeparableFilter2DEXT = (TglSeparableFilter2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSeparableFilter2DEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_cmyka (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_cmyka"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_object
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_object"))
            {
                if (GL.LinkProcGLEXT("glAreTexturesResidentEXT"))
                {
                    GL.glAreTexturesResidentEXT = (TglAreTexturesResidentEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAreTexturesResidentEXT));
                }

                if (GL.LinkProcGLEXT("glBindTextureEXT"))
                {
                    GL.glBindTextureEXT = (TglBindTextureEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindTextureEXT));
                }

                if (GL.LinkProcGLEXT("glDeleteTexturesEXT"))
                {
                    GL.glDeleteTexturesEXT = (TglDeleteTexturesEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteTexturesEXT));
                }

                if (GL.LinkProcGLEXT("glGenTexturesEXT"))
                {
                    GL.glGenTexturesEXT = (TglGenTexturesEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenTexturesEXT));
                }

                if (GL.LinkProcGLEXT("glIsTextureEXT"))
                {
                    GL.glIsTextureEXT = (TglIsTextureEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsTextureEXT));
                }

                if (GL.LinkProcGLEXT("glPrioritizeTexturesEXT"))
                {
                    GL.glPrioritizeTexturesEXT = (TglPrioritizeTexturesEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPrioritizeTexturesEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_packed_pixels (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_packed_pixels"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_rescale_normal (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_rescale_normal"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_vertex_array
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_vertex_array"))
            {
                if (GL.LinkProcGLEXT("glArrayElementEXT"))
                {
                    GL.glArrayElementEXT = (TglArrayElementEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglArrayElementEXT));
                }

                if (GL.LinkProcGLEXT("glColorPointerEXT"))
                {
                    GL.glColorPointerEXT = (TglColorPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorPointerEXT));
                }

                if (GL.LinkProcGLEXT("glDrawArraysEXT"))
                {
                    GL.glDrawArraysEXT = (TglDrawArraysEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawArraysEXT));
                }

                if (GL.LinkProcGLEXT("glEdgeFlagPointerEXT"))
                {
                    GL.glEdgeFlagPointerEXT = (TglEdgeFlagPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEdgeFlagPointerEXT));
                }

                if (GL.LinkProcGLEXT("glGetPointervEXT"))
                {
                    GL.glGetPointervEXT = (TglGetPointervEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPointervEXT));
                }

                if (GL.LinkProcGLEXT("glIndexPointerEXT"))
                {
                    GL.glIndexPointerEXT = (TglIndexPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexPointerEXT));
                }

                if (GL.LinkProcGLEXT("glNormalPointerEXT"))
                {
                    GL.glNormalPointerEXT = (TglNormalPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalPointerEXT));
                }

                if (GL.LinkProcGLEXT("glTexCoordPointerEXT"))
                {
                    GL.glTexCoordPointerEXT = (TglTexCoordPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordPointerEXT));
                }

                if (GL.LinkProcGLEXT("glVertexPointerEXT"))
                {
                    GL.glVertexPointerEXT = (TglVertexPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexPointerEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_misc_attribute (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_misc_attribute"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_blend_minmax
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_blend_minmax"))
            {
                if (GL.LinkProcGLEXT("glBlendEquationEXT"))
                {
                    GL.glBlendEquationEXT = (TglBlendEquationEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendEquationEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_blend_subtract (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_blend_subtract"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_blend_logic_op (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_blend_logic_op"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_point_parameters
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_point_parameters"))
            {
                if (GL.LinkProcGLEXT("glPointParameterfEXT"))
                {
                    GL.glPointParameterfEXT = (TglPointParameterfEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointParameterfEXT));
                }

                if (GL.LinkProcGLEXT("glPointParameterfvEXT"))
                {
                    GL.glPointParameterfvEXT = (TglPointParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointParameterfvEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_color_subtable
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_color_subtable"))
            {
                if (GL.LinkProcGLEXT("glColorSubTableEXT"))
                {
                    GL.glColorSubTableEXT = (TglColorSubTableEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorSubTableEXT));
                }

                if (GL.LinkProcGLEXT("glCopyColorSubTableEXT"))
                {
                    GL.glCopyColorSubTableEXT = (TglCopyColorSubTableEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyColorSubTableEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_paletted_texture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_paletted_texture"))
            {
                if (GL.LinkProcGLEXT("glColorTableEXT"))
                {
                    GL.glColorTableEXT = (TglColorTableEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorTableEXT));
                }

                if (GL.LinkProcGLEXT("glGetColorTableEXT"))
                {
                    GL.glGetColorTableEXT = (TglGetColorTableEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetColorTableEXT));
                }

                if (GL.LinkProcGLEXT("glGetColorTableParameterivEXT"))
                {
                    GL.glGetColorTableParameterivEXT = (TglGetColorTableParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetColorTableParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glGetColorTableParameterfvEXT"))
                {
                    GL.glGetColorTableParameterfvEXT = (TglGetColorTableParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetColorTableParameterfvEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_clip_volume_hint (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_clip_volume_hint"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_index_texture (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_index_texture"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_index_material
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_index_material"))
            {
                if (GL.LinkProcGLEXT("glIndexMaterialEXT"))
                {
                    GL.glIndexMaterialEXT = (TglIndexMaterialEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexMaterialEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_index_func
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_index_func"))
            {
                if (GL.LinkProcGLEXT("glIndexFuncEXT"))
                {
                    GL.glIndexFuncEXT = (TglIndexFuncEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexFuncEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_index_array_formats (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_index_array_formats"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_compiled_vertex_array
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_compiled_vertex_array"))
            {
                if (GL.LinkProcGLEXT("glLockArraysEXT"))
                {
                    GL.glLockArraysEXT = (TglLockArraysEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLockArraysEXT));
                }

                if (GL.LinkProcGLEXT("glUnlockArraysEXT"))
                {
                    GL.glUnlockArraysEXT = (TglUnlockArraysEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUnlockArraysEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_cull_vertex
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_cull_vertex"))
            {
                if (GL.LinkProcGLEXT("glCullParameterdvEXT"))
                {
                    GL.glCullParameterdvEXT = (TglCullParameterdvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCullParameterdvEXT));
                }

                if (GL.LinkProcGLEXT("glCullParameterfvEXT"))
                {
                    GL.glCullParameterfvEXT = (TglCullParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCullParameterfvEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_draw_range_elements
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_draw_range_elements"))
            {
                if (GL.LinkProcGLEXT("glDrawRangeElementsEXT"))
                {
                    GL.glDrawRangeElementsEXT = (TglDrawRangeElementsEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawRangeElementsEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_light_texture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_light_texture"))
            {
                if (GL.LinkProcGLEXT("glApplyTextureEXT"))
                {
                    GL.glApplyTextureEXT = (TglApplyTextureEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglApplyTextureEXT));
                }

                if (GL.LinkProcGLEXT("glTextureLightEXT"))
                {
                    GL.glTextureLightEXT = (TglTextureLightEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureLightEXT));
                }

                if (GL.LinkProcGLEXT("glTextureMaterialEXT"))
                {
                    GL.glTextureMaterialEXT = (TglTextureMaterialEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureMaterialEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_bgra (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_bgra"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_pixel_transform
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_pixel_transform"))
            {
                if (GL.LinkProcGLEXT("glPixelTransformParameteriEXT"))
                {
                    GL.glPixelTransformParameteriEXT = (TglPixelTransformParameteriEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelTransformParameteriEXT));
                }

                if (GL.LinkProcGLEXT("glPixelTransformParameterfEXT"))
                {
                    GL.glPixelTransformParameterfEXT = (TglPixelTransformParameterfEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelTransformParameterfEXT));
                }

                if (GL.LinkProcGLEXT("glPixelTransformParameterivEXT"))
                {
                    GL.glPixelTransformParameterivEXT = (TglPixelTransformParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelTransformParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glPixelTransformParameterfvEXT"))
                {
                    GL.glPixelTransformParameterfvEXT = (TglPixelTransformParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelTransformParameterfvEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_pixel_transform_color_table (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_pixel_transform_color_table"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_shared_texture_palette (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_shared_texture_palette"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_separate_specular_color (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_separate_specular_color"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_secondary_color
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_secondary_color"))
            {
                if (GL.LinkProcGLEXT("glSecondaryColor3bEXT"))
                {
                    GL.glSecondaryColor3bEXT = (TglSecondaryColor3bEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3bEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3bvEXT"))
                {
                    GL.glSecondaryColor3bvEXT = (TglSecondaryColor3bvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3bvEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3dEXT"))
                {
                    GL.glSecondaryColor3dEXT = (TglSecondaryColor3dEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3dEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3dvEXT"))
                {
                    GL.glSecondaryColor3dvEXT = (TglSecondaryColor3dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3dvEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3fEXT"))
                {
                    GL.glSecondaryColor3fEXT = (TglSecondaryColor3fEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3fEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3fvEXT"))
                {
                    GL.glSecondaryColor3fvEXT = (TglSecondaryColor3fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3fvEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3iEXT"))
                {
                    GL.glSecondaryColor3iEXT = (TglSecondaryColor3iEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3iEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3ivEXT"))
                {
                    GL.glSecondaryColor3ivEXT = (TglSecondaryColor3ivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3ivEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3sEXT"))
                {
                    GL.glSecondaryColor3sEXT = (TglSecondaryColor3sEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3sEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3svEXT"))
                {
                    GL.glSecondaryColor3svEXT = (TglSecondaryColor3svEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3svEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3ubEXT"))
                {
                    GL.glSecondaryColor3ubEXT = (TglSecondaryColor3ubEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3ubEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3ubvEXT"))
                {
                    GL.glSecondaryColor3ubvEXT = (TglSecondaryColor3ubvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3ubvEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3uiEXT"))
                {
                    GL.glSecondaryColor3uiEXT = (TglSecondaryColor3uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3uiEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3uivEXT"))
                {
                    GL.glSecondaryColor3uivEXT = (TglSecondaryColor3uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3uivEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3usEXT"))
                {
                    GL.glSecondaryColor3usEXT = (TglSecondaryColor3usEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3usEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3usvEXT"))
                {
                    GL.glSecondaryColor3usvEXT = (TglSecondaryColor3usvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3usvEXT));
                }

                if (GL.LinkProcGLEXT("glSecondaryColorPointerEXT"))
                {
                    GL.glSecondaryColorPointerEXT = (TglSecondaryColorPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColorPointerEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_perturb_normal
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_perturb_normal"))
            {
                if (GL.LinkProcGLEXT("glTextureNormalEXT"))
                {
                    GL.glTextureNormalEXT = (TglTextureNormalEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureNormalEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_multi_draw_arrays
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_multi_draw_arrays"))
            {
                if (GL.LinkProcGLEXT("glMultiDrawArraysEXT"))
                {
                    GL.glMultiDrawArraysEXT = (TglMultiDrawArraysEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawArraysEXT));
                }

                if (GL.LinkProcGLEXT("glMultiDrawElementsEXT"))
                {
                    GL.glMultiDrawElementsEXT = (TglMultiDrawElementsEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawElementsEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_fog_coord
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_fog_coord"))
            {
                if (GL.LinkProcGLEXT("glFogCoordfEXT"))
                {
                    GL.glFogCoordfEXT = (TglFogCoordfEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoordfEXT));
                }

                if (GL.LinkProcGLEXT("glFogCoordfvEXT"))
                {
                    GL.glFogCoordfvEXT = (TglFogCoordfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoordfvEXT));
                }

                if (GL.LinkProcGLEXT("glFogCoorddEXT"))
                {
                    GL.glFogCoorddEXT = (TglFogCoorddEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoorddEXT));
                }

                if (GL.LinkProcGLEXT("glFogCoorddvEXT"))
                {
                    GL.glFogCoorddvEXT = (TglFogCoorddvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoorddvEXT));
                }

                if (GL.LinkProcGLEXT("glFogCoordPointerEXT"))
                {
                    GL.glFogCoordPointerEXT = (TglFogCoordPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoordPointerEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_coordinate_frame
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_coordinate_frame"))
            {
                if (GL.LinkProcGLEXT("glTangent3bEXT"))
                {
                    GL.glTangent3bEXT = (TglTangent3bEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTangent3bEXT));
                }

                if (GL.LinkProcGLEXT("glTangent3bvEXT"))
                {
                    GL.glTangent3bvEXT = (TglTangent3bvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTangent3bvEXT));
                }

                if (GL.LinkProcGLEXT("glTangent3dEXT"))
                {
                    GL.glTangent3dEXT = (TglTangent3dEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTangent3dEXT));
                }

                if (GL.LinkProcGLEXT("glTangent3dvEXT"))
                {
                    GL.glTangent3dvEXT = (TglTangent3dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTangent3dvEXT));
                }

                if (GL.LinkProcGLEXT("glTangent3fEXT"))
                {
                    GL.glTangent3fEXT = (TglTangent3fEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTangent3fEXT));
                }

                if (GL.LinkProcGLEXT("glTangent3fvEXT"))
                {
                    GL.glTangent3fvEXT = (TglTangent3fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTangent3fvEXT));
                }

                if (GL.LinkProcGLEXT("glTangent3iEXT"))
                {
                    GL.glTangent3iEXT = (TglTangent3iEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTangent3iEXT));
                }

                if (GL.LinkProcGLEXT("glTangent3ivEXT"))
                {
                    GL.glTangent3ivEXT = (TglTangent3ivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTangent3ivEXT));
                }

                if (GL.LinkProcGLEXT("glTangent3sEXT"))
                {
                    GL.glTangent3sEXT = (TglTangent3sEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTangent3sEXT));
                }

                if (GL.LinkProcGLEXT("glTangent3svEXT"))
                {
                    GL.glTangent3svEXT = (TglTangent3svEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTangent3svEXT));
                }

                if (GL.LinkProcGLEXT("glBinormal3bEXT"))
                {
                    GL.glBinormal3bEXT = (TglBinormal3bEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBinormal3bEXT));
                }

                if (GL.LinkProcGLEXT("glBinormal3bvEXT"))
                {
                    GL.glBinormal3bvEXT = (TglBinormal3bvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBinormal3bvEXT));
                }

                if (GL.LinkProcGLEXT("glBinormal3dEXT"))
                {
                    GL.glBinormal3dEXT = (TglBinormal3dEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBinormal3dEXT));
                }

                if (GL.LinkProcGLEXT("glBinormal3dvEXT"))
                {
                    GL.glBinormal3dvEXT = (TglBinormal3dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBinormal3dvEXT));
                }

                if (GL.LinkProcGLEXT("glBinormal3fEXT"))
                {
                    GL.glBinormal3fEXT = (TglBinormal3fEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBinormal3fEXT));
                }

                if (GL.LinkProcGLEXT("glBinormal3fvEXT"))
                {
                    GL.glBinormal3fvEXT = (TglBinormal3fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBinormal3fvEXT));
                }

                if (GL.LinkProcGLEXT("glBinormal3iEXT"))
                {
                    GL.glBinormal3iEXT = (TglBinormal3iEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBinormal3iEXT));
                }

                if (GL.LinkProcGLEXT("glBinormal3ivEXT"))
                {
                    GL.glBinormal3ivEXT = (TglBinormal3ivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBinormal3ivEXT));
                }

                if (GL.LinkProcGLEXT("glBinormal3sEXT"))
                {
                    GL.glBinormal3sEXT = (TglBinormal3sEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBinormal3sEXT));
                }

                if (GL.LinkProcGLEXT("glBinormal3svEXT"))
                {
                    GL.glBinormal3svEXT = (TglBinormal3svEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBinormal3svEXT));
                }

                if (GL.LinkProcGLEXT("glTangentPointerEXT"))
                {
                    GL.glTangentPointerEXT = (TglTangentPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTangentPointerEXT));
                }

                if (GL.LinkProcGLEXT("glBinormalPointerEXT"))
                {
                    GL.glBinormalPointerEXT = (TglBinormalPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBinormalPointerEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_env_combine (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_env_combine"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_blend_func_separate
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_blend_func_separate"))
            {
                if (GL.LinkProcGLEXT("glBlendFuncSeparateEXT"))
                {
                    GL.glBlendFuncSeparateEXT = (TglBlendFuncSeparateEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendFuncSeparateEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_stencil_wrap (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_stencil_wrap"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_422_pixels (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_422_pixels"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_env_add (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_env_add"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_lod_bias (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_lod_bias"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_filter_anisotropic (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_filter_anisotropic"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_vertex_weighting
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_vertex_weighting"))
            {
                if (GL.LinkProcGLEXT("glVertexWeightfEXT"))
                {
                    GL.glVertexWeightfEXT = (TglVertexWeightfEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexWeightfEXT));
                }

                if (GL.LinkProcGLEXT("glVertexWeightfvEXT"))
                {
                    GL.glVertexWeightfvEXT = (TglVertexWeightfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexWeightfvEXT));
                }

                if (GL.LinkProcGLEXT("glVertexWeightPointerEXT"))
                {
                    GL.glVertexWeightPointerEXT = (TglVertexWeightPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexWeightPointerEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_multisample
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_multisample"))
            {
                if (GL.LinkProcGLEXT("glSampleMaskEXT"))
                {
                    GL.glSampleMaskEXT = (TglSampleMaskEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSampleMaskEXT));
                }

                if (GL.LinkProcGLEXT("glSamplePatternEXT"))
                {
                    GL.glSamplePatternEXT = (TglSamplePatternEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplePatternEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_env_dot3 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_env_dot3"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_vertex_shader
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_vertex_shader"))
            {
                if (GL.LinkProcGLEXT("glBeginVertexShaderEXT"))
                {
                    GL.glBeginVertexShaderEXT = (TglBeginVertexShaderEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginVertexShaderEXT));
                }

                if (GL.LinkProcGLEXT("glEndVertexShaderEXT"))
                {
                    GL.glEndVertexShaderEXT = (TglEndVertexShaderEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndVertexShaderEXT));
                }

                if (GL.LinkProcGLEXT("glBindVertexShaderEXT"))
                {
                    GL.glBindVertexShaderEXT = (TglBindVertexShaderEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindVertexShaderEXT));
                }

                if (GL.LinkProcGLEXT("glGenVertexShadersEXT"))
                {
                    GL.glGenVertexShadersEXT = (TglGenVertexShadersEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenVertexShadersEXT));
                }

                if (GL.LinkProcGLEXT("glDeleteVertexShaderEXT"))
                {
                    GL.glDeleteVertexShaderEXT = (TglDeleteVertexShaderEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteVertexShaderEXT));
                }

                if (GL.LinkProcGLEXT("glShaderOp1EXT"))
                {
                    GL.glShaderOp1EXT = (TglShaderOp1EXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglShaderOp1EXT));
                }

                if (GL.LinkProcGLEXT("glShaderOp2EXT"))
                {
                    GL.glShaderOp2EXT = (TglShaderOp2EXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglShaderOp2EXT));
                }

                if (GL.LinkProcGLEXT("glShaderOp3EXT"))
                {
                    GL.glShaderOp3EXT = (TglShaderOp3EXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglShaderOp3EXT));
                }

                if (GL.LinkProcGLEXT("glSwizzleEXT"))
                {
                    GL.glSwizzleEXT = (TglSwizzleEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSwizzleEXT));
                }

                if (GL.LinkProcGLEXT("glWriteMaskEXT"))
                {
                    GL.glWriteMaskEXT = (TglWriteMaskEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWriteMaskEXT));
                }

                if (GL.LinkProcGLEXT("glInsertComponentEXT"))
                {
                    GL.glInsertComponentEXT = (TglInsertComponentEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInsertComponentEXT));
                }

                if (GL.LinkProcGLEXT("glExtractComponentEXT"))
                {
                    GL.glExtractComponentEXT = (TglExtractComponentEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglExtractComponentEXT));
                }

                if (GL.LinkProcGLEXT("glGenSymbolsEXT"))
                {
                    GL.glGenSymbolsEXT = (TglGenSymbolsEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenSymbolsEXT));
                }

                if (GL.LinkProcGLEXT("glSetInvariantEXT"))
                {
                    GL.glSetInvariantEXT = (TglSetInvariantEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSetInvariantEXT));
                }

                if (GL.LinkProcGLEXT("glSetLocalConstantEXT"))
                {
                    GL.glSetLocalConstantEXT = (TglSetLocalConstantEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSetLocalConstantEXT));
                }

                if (GL.LinkProcGLEXT("glVariantbvEXT"))
                {
                    GL.glVariantbvEXT = (TglVariantbvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVariantbvEXT));
                }

                if (GL.LinkProcGLEXT("glVariantsvEXT"))
                {
                    GL.glVariantsvEXT = (TglVariantsvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVariantsvEXT));
                }

                if (GL.LinkProcGLEXT("glVariantivEXT"))
                {
                    GL.glVariantivEXT = (TglVariantivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVariantivEXT));
                }

                if (GL.LinkProcGLEXT("glVariantfvEXT"))
                {
                    GL.glVariantfvEXT = (TglVariantfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVariantfvEXT));
                }

                if (GL.LinkProcGLEXT("glVariantdvEXT"))
                {
                    GL.glVariantdvEXT = (TglVariantdvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVariantdvEXT));
                }

                if (GL.LinkProcGLEXT("glVariantubvEXT"))
                {
                    GL.glVariantubvEXT = (TglVariantubvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVariantubvEXT));
                }

                if (GL.LinkProcGLEXT("glVariantusvEXT"))
                {
                    GL.glVariantusvEXT = (TglVariantusvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVariantusvEXT));
                }

                if (GL.LinkProcGLEXT("glVariantuivEXT"))
                {
                    GL.glVariantuivEXT = (TglVariantuivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVariantuivEXT));
                }

                if (GL.LinkProcGLEXT("glVariantPointerEXT"))
                {
                    GL.glVariantPointerEXT = (TglVariantPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVariantPointerEXT));
                }

                if (GL.LinkProcGLEXT("glEnableVariantClientStateEXT"))
                {
                    GL.glEnableVariantClientStateEXT = (TglEnableVariantClientStateEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEnableVariantClientStateEXT));
                }

                if (GL.LinkProcGLEXT("glDisableVariantClientStateEXT"))
                {
                    GL.glDisableVariantClientStateEXT = (TglDisableVariantClientStateEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDisableVariantClientStateEXT));
                }

                if (GL.LinkProcGLEXT("glBindLightParameterEXT"))
                {
                    GL.glBindLightParameterEXT = (TglBindLightParameterEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindLightParameterEXT));
                }

                if (GL.LinkProcGLEXT("glBindMaterialParameterEXT"))
                {
                    GL.glBindMaterialParameterEXT = (TglBindMaterialParameterEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindMaterialParameterEXT));
                }

                if (GL.LinkProcGLEXT("glBindTexGenParameterEXT"))
                {
                    GL.glBindTexGenParameterEXT = (TglBindTexGenParameterEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindTexGenParameterEXT));
                }

                if (GL.LinkProcGLEXT("glBindTextureUnitParameterEXT"))
                {
                    GL.glBindTextureUnitParameterEXT = (TglBindTextureUnitParameterEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindTextureUnitParameterEXT));
                }

                if (GL.LinkProcGLEXT("glBindParameterEXT"))
                {
                    GL.glBindParameterEXT = (TglBindParameterEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindParameterEXT));
                }

                if (GL.LinkProcGLEXT("glIsVariantEnabledEXT"))
                {
                    GL.glIsVariantEnabledEXT = (TglIsVariantEnabledEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsVariantEnabledEXT));
                }

                if (GL.LinkProcGLEXT("glGetVariantBooleanvEXT"))
                {
                    GL.glGetVariantBooleanvEXT = (TglGetVariantBooleanvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVariantBooleanvEXT));
                }

                if (GL.LinkProcGLEXT("glGetVariantIntegervEXT"))
                {
                    GL.glGetVariantIntegervEXT = (TglGetVariantIntegervEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVariantIntegervEXT));
                }

                if (GL.LinkProcGLEXT("glGetVariantFloatvEXT"))
                {
                    GL.glGetVariantFloatvEXT = (TglGetVariantFloatvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVariantFloatvEXT));
                }

                if (GL.LinkProcGLEXT("glGetVariantPointervEXT"))
                {
                    GL.glGetVariantPointervEXT = (TglGetVariantPointervEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVariantPointervEXT));
                }

                if (GL.LinkProcGLEXT("glGetInvariantBooleanvEXT"))
                {
                    GL.glGetInvariantBooleanvEXT = (TglGetInvariantBooleanvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetInvariantBooleanvEXT));
                }

                if (GL.LinkProcGLEXT("glGetInvariantIntegervEXT"))
                {
                    GL.glGetInvariantIntegervEXT = (TglGetInvariantIntegervEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetInvariantIntegervEXT));
                }

                if (GL.LinkProcGLEXT("glGetInvariantFloatvEXT"))
                {
                    GL.glGetInvariantFloatvEXT = (TglGetInvariantFloatvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetInvariantFloatvEXT));
                }

                if (GL.LinkProcGLEXT("glGetLocalConstantBooleanvEXT"))
                {
                    GL.glGetLocalConstantBooleanvEXT = (TglGetLocalConstantBooleanvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetLocalConstantBooleanvEXT));
                }

                if (GL.LinkProcGLEXT("glGetLocalConstantIntegervEXT"))
                {
                    GL.glGetLocalConstantIntegervEXT = (TglGetLocalConstantIntegervEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetLocalConstantIntegervEXT));
                }

                if (GL.LinkProcGLEXT("glGetLocalConstantFloatvEXT"))
                {
                    GL.glGetLocalConstantFloatvEXT = (TglGetLocalConstantFloatvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetLocalConstantFloatvEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_shadow_funcs (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_shadow_funcs"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_stencil_two_side (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_stencil_two_side"))
            {
                if (GL.LinkProcGLEXT("glActiveStencilFaceEXT"))
                {
                    GL.glActiveStencilFaceEXT = (TglActiveStencilFaceEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglActiveStencilFaceEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_depth_bounds_test
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_depth_bounds_test"))
            {
                if (GL.LinkProcGLEXT("glDepthBoundsEXT"))
                {
                    GL.glDepthBoundsEXT = (TglDepthBoundsEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthBoundsEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_mirror_clamp (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_mirror_clamp"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_blend_equation_separate
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_blend_equation_separate"))
            {
                if (GL.LinkProcGLEXT("glBlendEquationSeparateEXT"))
                {
                    GL.glBlendEquationSeparateEXT = (TglBlendEquationSeparateEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendEquationSeparateEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_pixel_buffer_object (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_pixel_buffer_object"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_framebuffer_object
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_framebuffer_object"))
            {
                if (GL.LinkProcGLEXT("glIsRenderbufferEXT"))
                {
                    GL.glIsRenderbufferEXT = (TglIsRenderbufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsRenderbufferEXT));
                }

                if (GL.LinkProcGLEXT("glBindRenderbufferEXT"))
                {
                    GL.glBindRenderbufferEXT = (TglBindRenderbufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindRenderbufferEXT));
                }

                if (GL.LinkProcGLEXT("glDeleteRenderbuffersEXT"))
                {
                    GL.glDeleteRenderbuffersEXT = (TglDeleteRenderbuffersEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteRenderbuffersEXT));
                }

                if (GL.LinkProcGLEXT("glGenRenderbuffersEXT"))
                {
                    GL.glGenRenderbuffersEXT = (TglGenRenderbuffersEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenRenderbuffersEXT));
                }

                if (GL.LinkProcGLEXT("glRenderbufferStorageEXT"))
                {
                    GL.glRenderbufferStorageEXT = (TglRenderbufferStorageEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRenderbufferStorageEXT));
                }

                if (GL.LinkProcGLEXT("glGetRenderbufferParameterivEXT"))
                {
                    GL.glGetRenderbufferParameterivEXT = (TglGetRenderbufferParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetRenderbufferParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glIsFramebufferEXT"))
                {
                    GL.glIsFramebufferEXT = (TglIsFramebufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsFramebufferEXT));
                }

                if (GL.LinkProcGLEXT("glBindFramebufferEXT"))
                {
                    GL.glBindFramebufferEXT = (TglBindFramebufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindFramebufferEXT));
                }

                if (GL.LinkProcGLEXT("glDeleteFramebuffersEXT"))
                {
                    GL.glDeleteFramebuffersEXT = (TglDeleteFramebuffersEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteFramebuffersEXT));
                }

                if (GL.LinkProcGLEXT("glGenFramebuffersEXT"))
                {
                    GL.glGenFramebuffersEXT = (TglGenFramebuffersEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenFramebuffersEXT));
                }

                if (GL.LinkProcGLEXT("glCheckFramebufferStatusEXT"))
                {
                    GL.glCheckFramebufferStatusEXT = (TglCheckFramebufferStatusEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCheckFramebufferStatusEXT));
                }

                if (GL.LinkProcGLEXT("glFramebufferTexture1DEXT"))
                {
                    GL.glFramebufferTexture1DEXT = (TglFramebufferTexture1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTexture1DEXT));
                }

                if (GL.LinkProcGLEXT("glFramebufferTexture2DEXT"))
                {
                    GL.glFramebufferTexture2DEXT = (TglFramebufferTexture2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTexture2DEXT));
                }

                if (GL.LinkProcGLEXT("glFramebufferTexture3DEXT"))
                {
                    GL.glFramebufferTexture3DEXT = (TglFramebufferTexture3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTexture3DEXT));
                }

                if (GL.LinkProcGLEXT("glFramebufferRenderbufferEXT"))
                {
                    GL.glFramebufferRenderbufferEXT = (TglFramebufferRenderbufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferRenderbufferEXT));
                }

                if (GL.LinkProcGLEXT("glGetFramebufferAttachmentParameterivEXT"))
                {
                    GL.glGetFramebufferAttachmentParameterivEXT = (TglGetFramebufferAttachmentParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFramebufferAttachmentParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glGenerateMipmapEXT"))
                {
                    GL.glGenerateMipmapEXT = (TglGenerateMipmapEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenerateMipmapEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_packed_depth_stencil (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_packed_depth_stencil"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_stencil_clear_tag
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_stencil_clear_tag"))
            {
                if (GL.LinkProcGLEXT("glStencilClearTagEXT"))
                {
                    GL.glStencilClearTagEXT = (TglStencilClearTagEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilClearTagEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_sRGB (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_sRGB"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_framebuffer_blit
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_framebuffer_blit"))
            {
                if (GL.LinkProcGLEXT("glBlitFramebufferEXT"))
                {
                    GL.glBlitFramebufferEXT = (TglBlitFramebufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlitFramebufferEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_framebuffer_multisample
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_framebuffer_multisample"))
            {
                if (GL.LinkProcGLEXT("glRenderbufferStorageMultisampleEXT"))
                {
                    GL.glRenderbufferStorageMultisampleEXT = (TglRenderbufferStorageMultisampleEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRenderbufferStorageMultisampleEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_timer_query
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_timer_query"))
            {
                if (GL.LinkProcGLEXT("glGetQueryObjecti64vEXT"))
                {
                    GL.glGetQueryObjecti64vEXT = (TglGetQueryObjecti64vEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryObjecti64vEXT));
                }

                if (GL.LinkProcGLEXT("glGetQueryObjectui64vEXT"))
                {
                    GL.glGetQueryObjectui64vEXT = (TglGetQueryObjectui64vEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryObjectui64vEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_gpu_program_parameters
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_gpu_program_parameters"))
            {
                if (GL.LinkProcGLEXT("glProgramEnvParameters4fvEXT"))
                {
                    GL.glProgramEnvParameters4fvEXT = (TglProgramEnvParameters4fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramEnvParameters4fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramLocalParameters4fvEXT"))
                {
                    GL.glProgramLocalParameters4fvEXT = (TglProgramLocalParameters4fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramLocalParameters4fvEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_geometry_shader4
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_geometry_shader4"))
            {
                if (GL.LinkProcGLEXT("glProgramParameteriEXT"))
                {
                    GL.glProgramParameteriEXT = (TglProgramParameteriEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramParameteriEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_gpu_shader4
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_gpu_shader4"))
            {
                if (GL.LinkProcGLEXT("glGetUniformuivEXT"))
                {
                    GL.glGetUniformuivEXT = (TglGetUniformuivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformuivEXT));
                }

                if (GL.LinkProcGLEXT("glBindFragDataLocationEXT"))
                {
                    GL.glBindFragDataLocationEXT = (TglBindFragDataLocationEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindFragDataLocationEXT));
                }

                if (GL.LinkProcGLEXT("glGetFragDataLocationEXT"))
                {
                    GL.glGetFragDataLocationEXT = (TglGetFragDataLocationEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFragDataLocationEXT));
                }

                if (GL.LinkProcGLEXT("glUniform1uiEXT"))
                {
                    GL.glUniform1uiEXT = (TglUniform1uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1uiEXT));
                }

                if (GL.LinkProcGLEXT("glUniform2uiEXT"))
                {
                    GL.glUniform2uiEXT = (TglUniform2uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2uiEXT));
                }

                if (GL.LinkProcGLEXT("glUniform3uiEXT"))
                {
                    GL.glUniform3uiEXT = (TglUniform3uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3uiEXT));
                }

                if (GL.LinkProcGLEXT("glUniform4uiEXT"))
                {
                    GL.glUniform4uiEXT = (TglUniform4uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4uiEXT));
                }

                if (GL.LinkProcGLEXT("glUniform1uivEXT"))
                {
                    GL.glUniform1uivEXT = (TglUniform1uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1uivEXT));
                }

                if (GL.LinkProcGLEXT("glUniform2uivEXT"))
                {
                    GL.glUniform2uivEXT = (TglUniform2uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2uivEXT));
                }

                if (GL.LinkProcGLEXT("glUniform3uivEXT"))
                {
                    GL.glUniform3uivEXT = (TglUniform3uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3uivEXT));
                }

                if (GL.LinkProcGLEXT("glUniform4uivEXT"))
                {
                    GL.glUniform4uivEXT = (TglUniform4uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4uivEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_draw_instanced
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_draw_instanced"))
            {
                if (GL.LinkProcGLEXT("glDrawArraysInstancedEXT"))
                {
                    GL.glDrawArraysInstancedEXT = (TglDrawArraysInstancedEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawArraysInstancedEXT));
                }

                if (GL.LinkProcGLEXT("glDrawElementsInstancedEXT"))
                {
                    GL.glDrawElementsInstancedEXT = (TglDrawElementsInstancedEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementsInstancedEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_packed_float (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_packed_float"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_array (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_array"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_buffer_object
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_buffer_object"))
            {
                if (GL.LinkProcGLEXT("glTexBufferEXT"))
                {
                    GL.glTexBufferEXT = (TglTexBufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexBufferEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_compression_latc (no function entry point)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_compression_latc"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_compression_rgtc (no function entry point)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_compression_rgtc"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_shared_exponent (no function entry point)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_shared_exponent"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_framebuffer_sRGB (no function entry point)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_framebuffer_sRGB"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_draw_buffers2
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_draw_buffers2"))
            {
                if (GL.LinkProcGLEXT("glColorMaskIndexedEXT"))
                {
                    GL.glColorMaskIndexedEXT = (TglColorMaskIndexedEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorMaskIndexedEXT));
                }

                if (GL.LinkProcGLEXT("glGetBooleanIndexedvEXT"))
                {
                    GL.glGetBooleanIndexedvEXT = (TglGetBooleanIndexedvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetBooleanIndexedvEXT));
                }

                if (GL.LinkProcGLEXT("glGetIntegerIndexedvEXT"))
                {
                    GL.glGetIntegerIndexedvEXT = (TglGetIntegerIndexedvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetIntegerIndexedvEXT));
                }

                if (GL.LinkProcGLEXT("glEnableIndexedEXT"))
                {
                    GL.glEnableIndexedEXT = (TglEnableIndexedEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEnableIndexedEXT));
                }

                if (GL.LinkProcGLEXT("glDisableIndexedEXT"))
                {
                    GL.glDisableIndexedEXT = (TglDisableIndexedEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDisableIndexedEXT));
                }

                if (GL.LinkProcGLEXT("glIsEnabledIndexedEXT"))
                {
                    GL.glIsEnabledIndexedEXT = (TglIsEnabledIndexedEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsEnabledIndexedEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_bindable_uniform
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_bindable_uniform"))
            {
                if (GL.LinkProcGLEXT("glUniformBufferEXT"))
                {
                    GL.glUniformBufferEXT = (TglUniformBufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformBufferEXT));
                }

                if (GL.LinkProcGLEXT("glGetUniformBufferSizeEXT"))
                {
                    GL.glGetUniformBufferSizeEXT = (TglGetUniformBufferSizeEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformBufferSizeEXT));
                }

                if (GL.LinkProcGLEXT("glGetUniformOffsetEXT"))
                {
                    GL.glGetUniformOffsetEXT = (TglGetUniformOffsetEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformOffsetEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_integer
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_integer"))
            {
                if (GL.LinkProcGLEXT("glTexParameterIivEXT"))
                {
                    GL.glTexParameterIivEXT = (TglTexParameterIivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexParameterIivEXT));
                }

                if (GL.LinkProcGLEXT("glTexParameterIuivEXT"))
                {
                    GL.glTexParameterIuivEXT = (TglTexParameterIuivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexParameterIuivEXT));
                }

                if (GL.LinkProcGLEXT("glGetTexParameterIivEXT"))
                {
                    GL.glGetTexParameterIivEXT = (TglGetTexParameterIivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexParameterIivEXT));
                }

                if (GL.LinkProcGLEXT("glGetTexParameterIuivEXT"))
                {
                    GL.glGetTexParameterIuivEXT = (TglGetTexParameterIuivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexParameterIuivEXT));
                }

                if (GL.LinkProcGLEXT("glClearColorIiEXT"))
                {
                    GL.glClearColorIiEXT = (TglClearColorIiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearColorIiEXT));
                }

                if (GL.LinkProcGLEXT("glClearColorIuiEXT"))
                {
                    GL.glClearColorIuiEXT = (TglClearColorIuiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearColorIuiEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_transform_feedback
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_transform_feedback"))
            {
                if (GL.LinkProcGLEXT("glBeginTransformFeedbackEXT"))
                {
                    GL.glBeginTransformFeedbackEXT = (TglBeginTransformFeedbackEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginTransformFeedbackEXT));
                }

                if (GL.LinkProcGLEXT("glEndTransformFeedbackEXT"))
                {
                    GL.glEndTransformFeedbackEXT = (TglEndTransformFeedbackEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndTransformFeedbackEXT));
                }

                if (GL.LinkProcGLEXT("glBindBufferRangeEXT"))
                {
                    GL.glBindBufferRangeEXT = (TglBindBufferRangeEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindBufferRangeEXT));
                }

                if (GL.LinkProcGLEXT("glBindBufferOffsetEXT"))
                {
                    GL.glBindBufferOffsetEXT = (TglBindBufferOffsetEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindBufferOffsetEXT));
                }

                if (GL.LinkProcGLEXT("glBindBufferBaseEXT"))
                {
                    GL.glBindBufferBaseEXT = (TglBindBufferBaseEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindBufferBaseEXT));
                }

                if (GL.LinkProcGLEXT("glTransformFeedbackVaryingsEXT"))
                {
                    GL.glTransformFeedbackVaryingsEXT = (TglTransformFeedbackVaryingsEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTransformFeedbackVaryingsEXT));
                }

                if (GL.LinkProcGLEXT("glGetTransformFeedbackVaryingEXT"))
                {
                    GL.glGetTransformFeedbackVaryingEXT = (TglGetTransformFeedbackVaryingEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTransformFeedbackVaryingEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_direct_state_access
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_direct_state_access"))
            {
                if (GL.LinkProcGLEXT("glClientAttribDefaultEXT"))
                {
                    GL.glClientAttribDefaultEXT = (TglClientAttribDefaultEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClientAttribDefaultEXT));
                }

                if (GL.LinkProcGLEXT("glPushClientAttribDefaultEXT"))
                {
                    GL.glPushClientAttribDefaultEXT = (TglPushClientAttribDefaultEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPushClientAttribDefaultEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixLoadfEXT"))
                {
                    GL.glMatrixLoadfEXT = (TglMatrixLoadfEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixLoadfEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixLoaddEXT"))
                {
                    GL.glMatrixLoaddEXT = (TglMatrixLoaddEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixLoaddEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixMultfEXT"))
                {
                    GL.glMatrixMultfEXT = (TglMatrixMultfEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixMultfEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixMultdEXT"))
                {
                    GL.glMatrixMultdEXT = (TglMatrixMultdEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixMultdEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixLoadIdentityEXT"))
                {
                    GL.glMatrixLoadIdentityEXT = (TglMatrixLoadIdentityEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixLoadIdentityEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixRotatefEXT"))
                {
                    GL.glMatrixRotatefEXT = (TglMatrixRotatefEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixRotatefEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixRotatedEXT"))
                {
                    GL.glMatrixRotatedEXT = (TglMatrixRotatedEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixRotatedEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixScalefEXT"))
                {
                    GL.glMatrixScalefEXT = (TglMatrixScalefEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixScalefEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixScaledEXT"))
                {
                    GL.glMatrixScaledEXT = (TglMatrixScaledEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixScaledEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixTranslatefEXT"))
                {
                    GL.glMatrixTranslatefEXT = (TglMatrixTranslatefEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixTranslatefEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixTranslatedEXT"))
                {
                    GL.glMatrixTranslatedEXT = (TglMatrixTranslatedEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixTranslatedEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixFrustumEXT"))
                {
                    GL.glMatrixFrustumEXT = (TglMatrixFrustumEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixFrustumEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixOrthoEXT"))
                {
                    GL.glMatrixOrthoEXT = (TglMatrixOrthoEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixOrthoEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixPopEXT"))
                {
                    GL.glMatrixPopEXT = (TglMatrixPopEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixPopEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixPushEXT"))
                {
                    GL.glMatrixPushEXT = (TglMatrixPushEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixPushEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixLoadTransposefEXT"))
                {
                    GL.glMatrixLoadTransposefEXT = (TglMatrixLoadTransposefEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixLoadTransposefEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixLoadTransposedEXT"))
                {
                    GL.glMatrixLoadTransposedEXT = (TglMatrixLoadTransposedEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixLoadTransposedEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixMultTransposefEXT"))
                {
                    GL.glMatrixMultTransposefEXT = (TglMatrixMultTransposefEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixMultTransposefEXT));
                }

                if (GL.LinkProcGLEXT("glMatrixMultTransposedEXT"))
                {
                    GL.glMatrixMultTransposedEXT = (TglMatrixMultTransposedEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixMultTransposedEXT));
                }

                if (GL.LinkProcGLEXT("glTextureParameterfEXT"))
                {
                    GL.glTextureParameterfEXT = (TglTextureParameterfEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureParameterfEXT));
                }

                if (GL.LinkProcGLEXT("glTextureParameterfvEXT"))
                {
                    GL.glTextureParameterfvEXT = (TglTextureParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureParameterfvEXT));
                }

                if (GL.LinkProcGLEXT("glTextureParameteriEXT"))
                {
                    GL.glTextureParameteriEXT = (TglTextureParameteriEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureParameteriEXT));
                }

                if (GL.LinkProcGLEXT("glTextureParameterivEXT"))
                {
                    GL.glTextureParameterivEXT = (TglTextureParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glTextureImage1DEXT"))
                {
                    GL.glTextureImage1DEXT = (TglTextureImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glTextureImage2DEXT"))
                {
                    GL.glTextureImage2DEXT = (TglTextureImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glTextureSubImage1DEXT"))
                {
                    GL.glTextureSubImage1DEXT = (TglTextureSubImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureSubImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glTextureSubImage2DEXT"))
                {
                    GL.glTextureSubImage2DEXT = (TglTextureSubImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureSubImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyTextureImage1DEXT"))
                {
                    GL.glCopyTextureImage1DEXT = (TglCopyTextureImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTextureImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyTextureImage2DEXT"))
                {
                    GL.glCopyTextureImage2DEXT = (TglCopyTextureImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTextureImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyTextureSubImage1DEXT"))
                {
                    GL.glCopyTextureSubImage1DEXT = (TglCopyTextureSubImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTextureSubImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyTextureSubImage2DEXT"))
                {
                    GL.glCopyTextureSubImage2DEXT = (TglCopyTextureSubImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTextureSubImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glGetTextureImageEXT"))
                {
                    GL.glGetTextureImageEXT = (TglGetTextureImageEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureImageEXT));
                }

                if (GL.LinkProcGLEXT("glGetTextureParameterfvEXT"))
                {
                    GL.glGetTextureParameterfvEXT = (TglGetTextureParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureParameterfvEXT));
                }

                if (GL.LinkProcGLEXT("glGetTextureParameterivEXT"))
                {
                    GL.glGetTextureParameterivEXT = (TglGetTextureParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glGetTextureLevelParameterfvEXT"))
                {
                    GL.glGetTextureLevelParameterfvEXT = (TglGetTextureLevelParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureLevelParameterfvEXT));
                }

                if (GL.LinkProcGLEXT("glGetTextureLevelParameterivEXT"))
                {
                    GL.glGetTextureLevelParameterivEXT = (TglGetTextureLevelParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureLevelParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glTextureImage3DEXT"))
                {
                    GL.glTextureImage3DEXT = (TglTextureImage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureImage3DEXT));
                }

                if (GL.LinkProcGLEXT("glTextureSubImage3DEXT"))
                {
                    GL.glTextureSubImage3DEXT = (TglTextureSubImage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureSubImage3DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyTextureSubImage3DEXT"))
                {
                    GL.glCopyTextureSubImage3DEXT = (TglCopyTextureSubImage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTextureSubImage3DEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexParameterfEXT"))
                {
                    GL.glMultiTexParameterfEXT = (TglMultiTexParameterfEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexParameterfEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexParameterfvEXT"))
                {
                    GL.glMultiTexParameterfvEXT = (TglMultiTexParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexParameterfvEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexParameteriEXT"))
                {
                    GL.glMultiTexParameteriEXT = (TglMultiTexParameteriEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexParameteriEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexParameterivEXT"))
                {
                    GL.glMultiTexParameterivEXT = (TglMultiTexParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexImage1DEXT"))
                {
                    GL.glMultiTexImage1DEXT = (TglMultiTexImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexImage2DEXT"))
                {
                    GL.glMultiTexImage2DEXT = (TglMultiTexImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexSubImage1DEXT"))
                {
                    GL.glMultiTexSubImage1DEXT = (TglMultiTexSubImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexSubImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexSubImage2DEXT"))
                {
                    GL.glMultiTexSubImage2DEXT = (TglMultiTexSubImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexSubImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyMultiTexImage1DEXT"))
                {
                    GL.glCopyMultiTexImage1DEXT = (TglCopyMultiTexImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyMultiTexImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyMultiTexImage2DEXT"))
                {
                    GL.glCopyMultiTexImage2DEXT = (TglCopyMultiTexImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyMultiTexImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyMultiTexSubImage1DEXT"))
                {
                    GL.glCopyMultiTexSubImage1DEXT = (TglCopyMultiTexSubImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyMultiTexSubImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyMultiTexSubImage2DEXT"))
                {
                    GL.glCopyMultiTexSubImage2DEXT = (TglCopyMultiTexSubImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyMultiTexSubImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glGetMultiTexImageEXT"))
                {
                    GL.glGetMultiTexImageEXT = (TglGetMultiTexImageEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultiTexImageEXT));
                }

                if (GL.LinkProcGLEXT("glGetMultiTexParameterfvEXT"))
                {
                    GL.glGetMultiTexParameterfvEXT = (TglGetMultiTexParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultiTexParameterfvEXT));
                }

                if (GL.LinkProcGLEXT("glGetMultiTexParameterivEXT"))
                {
                    GL.glGetMultiTexParameterivEXT = (TglGetMultiTexParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultiTexParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glGetMultiTexLevelParameterfvEXT"))
                {
                    GL.glGetMultiTexLevelParameterfvEXT = (TglGetMultiTexLevelParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultiTexLevelParameterfvEXT));
                }

                if (GL.LinkProcGLEXT("glGetMultiTexLevelParameterivEXT"))
                {
                    GL.glGetMultiTexLevelParameterivEXT = (TglGetMultiTexLevelParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultiTexLevelParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexImage3DEXT"))
                {
                    GL.glMultiTexImage3DEXT = (TglMultiTexImage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexImage3DEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexSubImage3DEXT"))
                {
                    GL.glMultiTexSubImage3DEXT = (TglMultiTexSubImage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexSubImage3DEXT));
                }

                if (GL.LinkProcGLEXT("glCopyMultiTexSubImage3DEXT"))
                {
                    GL.glCopyMultiTexSubImage3DEXT = (TglCopyMultiTexSubImage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyMultiTexSubImage3DEXT));
                }

                if (GL.LinkProcGLEXT("glBindMultiTextureEXT"))
                {
                    GL.glBindMultiTextureEXT = (TglBindMultiTextureEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindMultiTextureEXT));
                }

                if (GL.LinkProcGLEXT("glEnableClientStateIndexedEXT"))
                {
                    GL.glEnableClientStateIndexedEXT = (TglEnableClientStateIndexedEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEnableClientStateIndexedEXT));
                }

                if (GL.LinkProcGLEXT("glDisableClientStateIndexedEXT"))
                {
                    GL.glDisableClientStateIndexedEXT = (TglDisableClientStateIndexedEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDisableClientStateIndexedEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoordPointerEXT"))
                {
                    GL.glMultiTexCoordPointerEXT = (TglMultiTexCoordPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordPointerEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexEnvfEXT"))
                {
                    GL.glMultiTexEnvfEXT = (TglMultiTexEnvfEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexEnvfEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexEnvfvEXT"))
                {
                    GL.glMultiTexEnvfvEXT = (TglMultiTexEnvfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexEnvfvEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexEnviEXT"))
                {
                    GL.glMultiTexEnviEXT = (TglMultiTexEnviEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexEnviEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexEnvivEXT"))
                {
                    GL.glMultiTexEnvivEXT = (TglMultiTexEnvivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexEnvivEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexGendEXT"))
                {
                    GL.glMultiTexGendEXT = (TglMultiTexGendEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexGendEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexGendvEXT"))
                {
                    GL.glMultiTexGendvEXT = (TglMultiTexGendvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexGendvEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexGenfEXT"))
                {
                    GL.glMultiTexGenfEXT = (TglMultiTexGenfEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexGenfEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexGenfvEXT"))
                {
                    GL.glMultiTexGenfvEXT = (TglMultiTexGenfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexGenfvEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexGeniEXT"))
                {
                    GL.glMultiTexGeniEXT = (TglMultiTexGeniEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexGeniEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexGenivEXT"))
                {
                    GL.glMultiTexGenivEXT = (TglMultiTexGenivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexGenivEXT));
                }

                if (GL.LinkProcGLEXT("glGetMultiTexEnvfvEXT"))
                {
                    GL.glGetMultiTexEnvfvEXT = (TglGetMultiTexEnvfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultiTexEnvfvEXT));
                }

                if (GL.LinkProcGLEXT("glGetMultiTexEnvivEXT"))
                {
                    GL.glGetMultiTexEnvivEXT = (TglGetMultiTexEnvivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultiTexEnvivEXT));
                }

                if (GL.LinkProcGLEXT("glGetMultiTexGendvEXT"))
                {
                    GL.glGetMultiTexGendvEXT = (TglGetMultiTexGendvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultiTexGendvEXT));
                }

                if (GL.LinkProcGLEXT("glGetMultiTexGenfvEXT"))
                {
                    GL.glGetMultiTexGenfvEXT = (TglGetMultiTexGenfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultiTexGenfvEXT));
                }

                if (GL.LinkProcGLEXT("glGetMultiTexGenivEXT"))
                {
                    GL.glGetMultiTexGenivEXT = (TglGetMultiTexGenivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultiTexGenivEXT));
                }

                if (GL.LinkProcGLEXT("glGetFloatIndexedvEXT"))
                {
                    GL.glGetFloatIndexedvEXT = (TglGetFloatIndexedvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFloatIndexedvEXT));
                }

                if (GL.LinkProcGLEXT("glGetDoubleIndexedvEXT"))
                {
                    GL.glGetDoubleIndexedvEXT = (TglGetDoubleIndexedvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetDoubleIndexedvEXT));
                }

                if (GL.LinkProcGLEXT("glGetPointerIndexedvEXT"))
                {
                    GL.glGetPointerIndexedvEXT = (TglGetPointerIndexedvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPointerIndexedvEXT));
                }

                if (GL.LinkProcGLEXT("glCompressedTextureImage3DEXT"))
                {
                    GL.glCompressedTextureImage3DEXT = (TglCompressedTextureImage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTextureImage3DEXT));
                }

                if (GL.LinkProcGLEXT("glCompressedTextureImage2DEXT"))
                {
                    GL.glCompressedTextureImage2DEXT = (TglCompressedTextureImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTextureImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glCompressedTextureImage1DEXT"))
                {
                    GL.glCompressedTextureImage1DEXT = (TglCompressedTextureImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTextureImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glCompressedTextureSubImage3DEXT"))
                {
                    GL.glCompressedTextureSubImage3DEXT = (TglCompressedTextureSubImage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTextureSubImage3DEXT));
                }

                if (GL.LinkProcGLEXT("glCompressedTextureSubImage2DEXT"))
                {
                    GL.glCompressedTextureSubImage2DEXT = (TglCompressedTextureSubImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTextureSubImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glCompressedTextureSubImage1DEXT"))
                {
                    GL.glCompressedTextureSubImage1DEXT = (TglCompressedTextureSubImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTextureSubImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glGetCompressedTextureImageEXT"))
                {
                    GL.glGetCompressedTextureImageEXT = (TglGetCompressedTextureImageEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetCompressedTextureImageEXT));
                }

                if (GL.LinkProcGLEXT("glCompressedMultiTexImage3DEXT"))
                {
                    GL.glCompressedMultiTexImage3DEXT = (TglCompressedMultiTexImage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedMultiTexImage3DEXT));
                }

                if (GL.LinkProcGLEXT("glCompressedMultiTexImage2DEXT"))
                {
                    GL.glCompressedMultiTexImage2DEXT = (TglCompressedMultiTexImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedMultiTexImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glCompressedMultiTexImage1DEXT"))
                {
                    GL.glCompressedMultiTexImage1DEXT = (TglCompressedMultiTexImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedMultiTexImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glCompressedMultiTexSubImage3DEXT"))
                {
                    GL.glCompressedMultiTexSubImage3DEXT = (TglCompressedMultiTexSubImage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedMultiTexSubImage3DEXT));
                }

                if (GL.LinkProcGLEXT("glCompressedMultiTexSubImage2DEXT"))
                {
                    GL.glCompressedMultiTexSubImage2DEXT = (TglCompressedMultiTexSubImage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedMultiTexSubImage2DEXT));
                }

                if (GL.LinkProcGLEXT("glCompressedMultiTexSubImage1DEXT"))
                {
                    GL.glCompressedMultiTexSubImage1DEXT = (TglCompressedMultiTexSubImage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedMultiTexSubImage1DEXT));
                }

                if (GL.LinkProcGLEXT("glGetCompressedMultiTexImageEXT"))
                {
                    GL.glGetCompressedMultiTexImageEXT = (TglGetCompressedMultiTexImageEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetCompressedMultiTexImageEXT));
                }

                if (GL.LinkProcGLEXT("glNamedProgramStringEXT"))
                {
                    GL.glNamedProgramStringEXT = (TglNamedProgramStringEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedProgramStringEXT));
                }

                if (GL.LinkProcGLEXT("glNamedProgramLocalParameter4dEXT"))
                {
                    GL.glNamedProgramLocalParameter4dEXT = (TglNamedProgramLocalParameter4dEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedProgramLocalParameter4dEXT));
                }

                if (GL.LinkProcGLEXT("glNamedProgramLocalParameter4dvEXT"))
                {
                    GL.glNamedProgramLocalParameter4dvEXT = (TglNamedProgramLocalParameter4dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedProgramLocalParameter4dvEXT));
                }

                if (GL.LinkProcGLEXT("glNamedProgramLocalParameter4fEXT"))
                {
                    GL.glNamedProgramLocalParameter4fEXT = (TglNamedProgramLocalParameter4fEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedProgramLocalParameter4fEXT));
                }

                if (GL.LinkProcGLEXT("glNamedProgramLocalParameter4fvEXT"))
                {
                    GL.glNamedProgramLocalParameter4fvEXT = (TglNamedProgramLocalParameter4fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedProgramLocalParameter4fvEXT));
                }

                if (GL.LinkProcGLEXT("glGetNamedProgramLocalParameterdvEXT"))
                {
                    GL.glGetNamedProgramLocalParameterdvEXT = (TglGetNamedProgramLocalParameterdvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedProgramLocalParameterdvEXT));
                }

                if (GL.LinkProcGLEXT("glGetNamedProgramLocalParameterfvEXT"))
                {
                    GL.glGetNamedProgramLocalParameterfvEXT = (TglGetNamedProgramLocalParameterfvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedProgramLocalParameterfvEXT));
                }

                if (GL.LinkProcGLEXT("glGetNamedProgramivEXT"))
                {
                    GL.glGetNamedProgramivEXT = (TglGetNamedProgramivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedProgramivEXT));
                }

                if (GL.LinkProcGLEXT("glGetNamedProgramStringEXT"))
                {
                    GL.glGetNamedProgramStringEXT = (TglGetNamedProgramStringEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedProgramStringEXT));
                }

                if (GL.LinkProcGLEXT("glNamedProgramLocalParameters4fvEXT"))
                {
                    GL.glNamedProgramLocalParameters4fvEXT = (TglNamedProgramLocalParameters4fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedProgramLocalParameters4fvEXT));
                }

                if (GL.LinkProcGLEXT("glNamedProgramLocalParameterI4iEXT"))
                {
                    GL.glNamedProgramLocalParameterI4iEXT = (TglNamedProgramLocalParameterI4iEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedProgramLocalParameterI4iEXT));
                }

                if (GL.LinkProcGLEXT("glNamedProgramLocalParameterI4ivEXT"))
                {
                    GL.glNamedProgramLocalParameterI4ivEXT = (TglNamedProgramLocalParameterI4ivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedProgramLocalParameterI4ivEXT));
                }

                if (GL.LinkProcGLEXT("glNamedProgramLocalParametersI4ivEXT"))
                {
                    GL.glNamedProgramLocalParametersI4ivEXT = (TglNamedProgramLocalParametersI4ivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedProgramLocalParametersI4ivEXT));
                }

                if (GL.LinkProcGLEXT("glNamedProgramLocalParameterI4uiEXT"))
                {
                    GL.glNamedProgramLocalParameterI4uiEXT = (TglNamedProgramLocalParameterI4uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedProgramLocalParameterI4uiEXT));
                }

                if (GL.LinkProcGLEXT("glNamedProgramLocalParameterI4uivEXT"))
                {
                    GL.glNamedProgramLocalParameterI4uivEXT = (TglNamedProgramLocalParameterI4uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedProgramLocalParameterI4uivEXT));
                }

                if (GL.LinkProcGLEXT("glNamedProgramLocalParametersI4uivEXT"))
                {
                    GL.glNamedProgramLocalParametersI4uivEXT = (TglNamedProgramLocalParametersI4uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedProgramLocalParametersI4uivEXT));
                }

                if (GL.LinkProcGLEXT("glGetNamedProgramLocalParameterIivEXT"))
                {
                    GL.glGetNamedProgramLocalParameterIivEXT = (TglGetNamedProgramLocalParameterIivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedProgramLocalParameterIivEXT));
                }

                if (GL.LinkProcGLEXT("glGetNamedProgramLocalParameterIuivEXT"))
                {
                    GL.glGetNamedProgramLocalParameterIuivEXT = (TglGetNamedProgramLocalParameterIuivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedProgramLocalParameterIuivEXT));
                }

                if (GL.LinkProcGLEXT("glTextureParameterIivEXT"))
                {
                    GL.glTextureParameterIivEXT = (TglTextureParameterIivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureParameterIivEXT));
                }

                if (GL.LinkProcGLEXT("glTextureParameterIuivEXT"))
                {
                    GL.glTextureParameterIuivEXT = (TglTextureParameterIuivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureParameterIuivEXT));
                }

                if (GL.LinkProcGLEXT("glGetTextureParameterIivEXT"))
                {
                    GL.glGetTextureParameterIivEXT = (TglGetTextureParameterIivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureParameterIivEXT));
                }

                if (GL.LinkProcGLEXT("glGetTextureParameterIuivEXT"))
                {
                    GL.glGetTextureParameterIuivEXT = (TglGetTextureParameterIuivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureParameterIuivEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexParameterIivEXT"))
                {
                    GL.glMultiTexParameterIivEXT = (TglMultiTexParameterIivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexParameterIivEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexParameterIuivEXT"))
                {
                    GL.glMultiTexParameterIuivEXT = (TglMultiTexParameterIuivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexParameterIuivEXT));
                }

                if (GL.LinkProcGLEXT("glGetMultiTexParameterIivEXT"))
                {
                    GL.glGetMultiTexParameterIivEXT = (TglGetMultiTexParameterIivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultiTexParameterIivEXT));
                }

                if (GL.LinkProcGLEXT("glGetMultiTexParameterIuivEXT"))
                {
                    GL.glGetMultiTexParameterIuivEXT = (TglGetMultiTexParameterIuivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultiTexParameterIuivEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1fEXT"))
                {
                    GL.glProgramUniform1fEXT = (TglProgramUniform1fEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1fEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2fEXT"))
                {
                    GL.glProgramUniform2fEXT = (TglProgramUniform2fEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2fEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3fEXT"))
                {
                    GL.glProgramUniform3fEXT = (TglProgramUniform3fEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3fEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4fEXT"))
                {
                    GL.glProgramUniform4fEXT = (TglProgramUniform4fEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4fEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1iEXT"))
                {
                    GL.glProgramUniform1iEXT = (TglProgramUniform1iEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1iEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2iEXT"))
                {
                    GL.glProgramUniform2iEXT = (TglProgramUniform2iEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2iEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3iEXT"))
                {
                    GL.glProgramUniform3iEXT = (TglProgramUniform3iEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3iEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4iEXT"))
                {
                    GL.glProgramUniform4iEXT = (TglProgramUniform4iEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4iEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1fvEXT"))
                {
                    GL.glProgramUniform1fvEXT = (TglProgramUniform1fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2fvEXT"))
                {
                    GL.glProgramUniform2fvEXT = (TglProgramUniform2fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3fvEXT"))
                {
                    GL.glProgramUniform3fvEXT = (TglProgramUniform3fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4fvEXT"))
                {
                    GL.glProgramUniform4fvEXT = (TglProgramUniform4fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1ivEXT"))
                {
                    GL.glProgramUniform1ivEXT = (TglProgramUniform1ivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1ivEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2ivEXT"))
                {
                    GL.glProgramUniform2ivEXT = (TglProgramUniform2ivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2ivEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3ivEXT"))
                {
                    GL.glProgramUniform3ivEXT = (TglProgramUniform3ivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3ivEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4ivEXT"))
                {
                    GL.glProgramUniform4ivEXT = (TglProgramUniform4ivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4ivEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix2fvEXT"))
                {
                    GL.glProgramUniformMatrix2fvEXT = (TglProgramUniformMatrix2fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix3fvEXT"))
                {
                    GL.glProgramUniformMatrix3fvEXT = (TglProgramUniformMatrix3fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix4fvEXT"))
                {
                    GL.glProgramUniformMatrix4fvEXT = (TglProgramUniformMatrix4fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix2x3fvEXT"))
                {
                    GL.glProgramUniformMatrix2x3fvEXT = (TglProgramUniformMatrix2x3fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2x3fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix3x2fvEXT"))
                {
                    GL.glProgramUniformMatrix3x2fvEXT = (TglProgramUniformMatrix3x2fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3x2fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix2x4fvEXT"))
                {
                    GL.glProgramUniformMatrix2x4fvEXT = (TglProgramUniformMatrix2x4fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2x4fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix4x2fvEXT"))
                {
                    GL.glProgramUniformMatrix4x2fvEXT = (TglProgramUniformMatrix4x2fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4x2fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix3x4fvEXT"))
                {
                    GL.glProgramUniformMatrix3x4fvEXT = (TglProgramUniformMatrix3x4fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3x4fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix4x3fvEXT"))
                {
                    GL.glProgramUniformMatrix4x3fvEXT = (TglProgramUniformMatrix4x3fvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4x3fvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1uiEXT"))
                {
                    GL.glProgramUniform1uiEXT = (TglProgramUniform1uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1uiEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2uiEXT"))
                {
                    GL.glProgramUniform2uiEXT = (TglProgramUniform2uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2uiEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3uiEXT"))
                {
                    GL.glProgramUniform3uiEXT = (TglProgramUniform3uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3uiEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4uiEXT"))
                {
                    GL.glProgramUniform4uiEXT = (TglProgramUniform4uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4uiEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1uivEXT"))
                {
                    GL.glProgramUniform1uivEXT = (TglProgramUniform1uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1uivEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2uivEXT"))
                {
                    GL.glProgramUniform2uivEXT = (TglProgramUniform2uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2uivEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3uivEXT"))
                {
                    GL.glProgramUniform3uivEXT = (TglProgramUniform3uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3uivEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4uivEXT"))
                {
                    GL.glProgramUniform4uivEXT = (TglProgramUniform4uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4uivEXT));
                }

                if (GL.LinkProcGLEXT("glNamedBufferDataEXT"))
                {
                    GL.glNamedBufferDataEXT = (TglNamedBufferDataEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedBufferDataEXT));
                }

                if (GL.LinkProcGLEXT("glNamedBufferSubDataEXT"))
                {
                    GL.glNamedBufferSubDataEXT = (TglNamedBufferSubDataEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedBufferSubDataEXT));
                }

                if (GL.LinkProcGLEXT("glMapNamedBufferEXT"))
                {
                    GL.glMapNamedBufferEXT = (TglMapNamedBufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapNamedBufferEXT));
                }

                if (GL.LinkProcGLEXT("glUnmapNamedBufferEXT"))
                {
                    GL.glUnmapNamedBufferEXT = (TglUnmapNamedBufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUnmapNamedBufferEXT));
                }

                if (GL.LinkProcGLEXT("glMapNamedBufferRangeEXT"))
                {
                    GL.glMapNamedBufferRangeEXT = (TglMapNamedBufferRangeEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapNamedBufferRangeEXT));
                }

                if (GL.LinkProcGLEXT("glFlushMappedNamedBufferRangeEXT"))
                {
                    GL.glFlushMappedNamedBufferRangeEXT = (TglFlushMappedNamedBufferRangeEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFlushMappedNamedBufferRangeEXT));
                }

                if (GL.LinkProcGLEXT("glNamedCopyBufferSubDataEXT"))
                {
                    GL.glNamedCopyBufferSubDataEXT = (TglNamedCopyBufferSubDataEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedCopyBufferSubDataEXT));
                }

                if (GL.LinkProcGLEXT("glGetNamedBufferParameterivEXT"))
                {
                    GL.glGetNamedBufferParameterivEXT = (TglGetNamedBufferParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedBufferParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glGetNamedBufferPointervEXT"))
                {
                    GL.glGetNamedBufferPointervEXT = (TglGetNamedBufferPointervEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedBufferPointervEXT));
                }

                if (GL.LinkProcGLEXT("glGetNamedBufferSubDataEXT"))
                {
                    GL.glGetNamedBufferSubDataEXT = (TglGetNamedBufferSubDataEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedBufferSubDataEXT));
                }

                if (GL.LinkProcGLEXT("glTextureBufferEXT"))
                {
                    GL.glTextureBufferEXT = (TglTextureBufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureBufferEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexBufferEXT"))
                {
                    GL.glMultiTexBufferEXT = (TglMultiTexBufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexBufferEXT));
                }

                if (GL.LinkProcGLEXT("glNamedRenderbufferStorageEXT"))
                {
                    GL.glNamedRenderbufferStorageEXT = (TglNamedRenderbufferStorageEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedRenderbufferStorageEXT));
                }

                if (GL.LinkProcGLEXT("glGetNamedRenderbufferParameterivEXT"))
                {
                    GL.glGetNamedRenderbufferParameterivEXT = (TglGetNamedRenderbufferParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedRenderbufferParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glCheckNamedFramebufferStatusEXT"))
                {
                    GL.glCheckNamedFramebufferStatusEXT = (TglCheckNamedFramebufferStatusEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCheckNamedFramebufferStatusEXT));
                }

                if (GL.LinkProcGLEXT("glNamedFramebufferTexture1DEXT"))
                {
                    GL.glNamedFramebufferTexture1DEXT = (TglNamedFramebufferTexture1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferTexture1DEXT));
                }

                if (GL.LinkProcGLEXT("glNamedFramebufferTexture2DEXT"))
                {
                    GL.glNamedFramebufferTexture2DEXT = (TglNamedFramebufferTexture2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferTexture2DEXT));
                }

                if (GL.LinkProcGLEXT("glNamedFramebufferTexture3DEXT"))
                {
                    GL.glNamedFramebufferTexture3DEXT = (TglNamedFramebufferTexture3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferTexture3DEXT));
                }

                if (GL.LinkProcGLEXT("glNamedFramebufferRenderbufferEXT"))
                {
                    GL.glNamedFramebufferRenderbufferEXT = (TglNamedFramebufferRenderbufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferRenderbufferEXT));
                }

                if (GL.LinkProcGLEXT("glGetNamedFramebufferAttachmentParameterivEXT"))
                {
                    GL.glGetNamedFramebufferAttachmentParameterivEXT = (TglGetNamedFramebufferAttachmentParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedFramebufferAttachmentParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glGenerateTextureMipmapEXT"))
                {
                    GL.glGenerateTextureMipmapEXT = (TglGenerateTextureMipmapEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenerateTextureMipmapEXT));
                }

                if (GL.LinkProcGLEXT("glGenerateMultiTexMipmapEXT"))
                {
                    GL.glGenerateMultiTexMipmapEXT = (TglGenerateMultiTexMipmapEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenerateMultiTexMipmapEXT));
                }

                if (GL.LinkProcGLEXT("glFramebufferDrawBufferEXT"))
                {
                    GL.glFramebufferDrawBufferEXT = (TglFramebufferDrawBufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferDrawBufferEXT));
                }

                if (GL.LinkProcGLEXT("glFramebufferDrawBuffersEXT"))
                {
                    GL.glFramebufferDrawBuffersEXT = (TglFramebufferDrawBuffersEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferDrawBuffersEXT));
                }

                if (GL.LinkProcGLEXT("glFramebufferReadBufferEXT"))
                {
                    GL.glFramebufferReadBufferEXT = (TglFramebufferReadBufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferReadBufferEXT));
                }

                if (GL.LinkProcGLEXT("glGetFramebufferParameterivEXT"))
                {
                    GL.glGetFramebufferParameterivEXT = (TglGetFramebufferParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFramebufferParameterivEXT));
                }

                if (GL.LinkProcGLEXT("glNamedRenderbufferStorageMultisampleEXT"))
                {
                    GL.glNamedRenderbufferStorageMultisampleEXT = (TglNamedRenderbufferStorageMultisampleEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedRenderbufferStorageMultisampleEXT));
                }

                if (GL.LinkProcGLEXT("glNamedRenderbufferStorageMultisampleCoverageEXT"))
                {
                    GL.glNamedRenderbufferStorageMultisampleCoverageEXT = (TglNamedRenderbufferStorageMultisampleCoverageEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedRenderbufferStorageMultisampleCoverageEXT));
                }

                if (GL.LinkProcGLEXT("glNamedFramebufferTextureEXT"))
                {
                    GL.glNamedFramebufferTextureEXT = (TglNamedFramebufferTextureEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferTextureEXT));
                }

                if (GL.LinkProcGLEXT("glNamedFramebufferTextureLayerEXT"))
                {
                    GL.glNamedFramebufferTextureLayerEXT = (TglNamedFramebufferTextureLayerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferTextureLayerEXT));
                }

                if (GL.LinkProcGLEXT("glNamedFramebufferTextureFaceEXT"))
                {
                    GL.glNamedFramebufferTextureFaceEXT = (TglNamedFramebufferTextureFaceEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferTextureFaceEXT));
                }

                if (GL.LinkProcGLEXT("glTextureRenderbufferEXT"))
                {
                    GL.glTextureRenderbufferEXT = (TglTextureRenderbufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureRenderbufferEXT));
                }

                if (GL.LinkProcGLEXT("glMultiTexRenderbufferEXT"))
                {
                    GL.glMultiTexRenderbufferEXT = (TglMultiTexRenderbufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexRenderbufferEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1dEXT"))
                {
                    GL.glProgramUniform1dEXT = (TglProgramUniform1dEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1dEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2dEXT"))
                {
                    GL.glProgramUniform2dEXT = (TglProgramUniform2dEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2dEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3dEXT"))
                {
                    GL.glProgramUniform3dEXT = (TglProgramUniform3dEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3dEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4dEXT"))
                {
                    GL.glProgramUniform4dEXT = (TglProgramUniform4dEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4dEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1dvEXT"))
                {
                    GL.glProgramUniform1dvEXT = (TglProgramUniform1dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1dvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2dvEXT"))
                {
                    GL.glProgramUniform2dvEXT = (TglProgramUniform2dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2dvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3dvEXT"))
                {
                    GL.glProgramUniform3dvEXT = (TglProgramUniform3dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3dvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4dvEXT"))
                {
                    GL.glProgramUniform4dvEXT = (TglProgramUniform4dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4dvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix2dvEXT"))
                {
                    GL.glProgramUniformMatrix2dvEXT = (TglProgramUniformMatrix2dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2dvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix3dvEXT"))
                {
                    GL.glProgramUniformMatrix3dvEXT = (TglProgramUniformMatrix3dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3dvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix4dvEXT"))
                {
                    GL.glProgramUniformMatrix4dvEXT = (TglProgramUniformMatrix4dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4dvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix2x3dvEXT"))
                {
                    GL.glProgramUniformMatrix2x3dvEXT = (TglProgramUniformMatrix2x3dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2x3dvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix2x4dvEXT"))
                {
                    GL.glProgramUniformMatrix2x4dvEXT = (TglProgramUniformMatrix2x4dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2x4dvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix3x2dvEXT"))
                {
                    GL.glProgramUniformMatrix3x2dvEXT = (TglProgramUniformMatrix3x2dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3x2dvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix3x4dvEXT"))
                {
                    GL.glProgramUniformMatrix3x4dvEXT = (TglProgramUniformMatrix3x4dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3x4dvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix4x2dvEXT"))
                {
                    GL.glProgramUniformMatrix4x2dvEXT = (TglProgramUniformMatrix4x2dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4x2dvEXT));
                }

                if (GL.LinkProcGLEXT("glProgramUniformMatrix4x3dvEXT"))
                {
                    GL.glProgramUniformMatrix4x3dvEXT = (TglProgramUniformMatrix4x3dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4x3dvEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_vertex_array_bgra (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_vertex_array_bgra"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_swizzle (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_swizzle"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_type_2_10_10_10_REV (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_type_2_10_10_10_REV"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_provoking_vertex
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_provoking_vertex"))
            {
                if (GL.LinkProcGLEXT("glProvokingVertexEXT"))
                {
                    GL.glProvokingVertexEXT = (TglProvokingVertexEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProvokingVertexEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_snorm (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_snorm"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_separate_shader_objects
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_separate_shader_objects"))
            {
                if (GL.LinkProcGLEXT("glUseShaderProgramEXT"))
                {
                    GL.glUseShaderProgramEXT = (TglUseShaderProgramEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUseShaderProgramEXT));
                }

                if (GL.LinkProcGLEXT("glActiveProgramEXT"))
                {
                    GL.glActiveProgramEXT = (TglActiveProgramEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglActiveProgramEXT));
                }

                if (GL.LinkProcGLEXT("glCreateShaderProgramEXT"))
                {
                    GL.glCreateShaderProgramEXT = (TglCreateShaderProgramEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateShaderProgramEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_shader_image_load_store
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_shader_image_load_store"))
            {
                if (GL.LinkProcGLEXT("glBindImageTextureEXT"))
                {
                    GL.glBindImageTextureEXT = (TglBindImageTextureEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindImageTextureEXT));
                }

                if (GL.LinkProcGLEXT("glMemoryBarrierEXT"))
                {
                    GL.glMemoryBarrierEXT = (TglMemoryBarrierEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMemoryBarrierEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_vertex_attrib_64bit
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_vertex_attrib_64bit"))
            {
                if (GL.LinkProcGLEXT("glVertexAttribL1dEXT"))
                {
                    GL.glVertexAttribL1dEXT = (TglVertexAttribL1dEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL1dEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL2dEXT"))
                {
                    GL.glVertexAttribL2dEXT = (TglVertexAttribL2dEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL2dEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL3dEXT"))
                {
                    GL.glVertexAttribL3dEXT = (TglVertexAttribL3dEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL3dEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL4dEXT"))
                {
                    GL.glVertexAttribL4dEXT = (TglVertexAttribL4dEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL4dEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL1dvEXT"))
                {
                    GL.glVertexAttribL1dvEXT = (TglVertexAttribL1dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL1dvEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL2dvEXT"))
                {
                    GL.glVertexAttribL2dvEXT = (TglVertexAttribL2dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL2dvEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL3dvEXT"))
                {
                    GL.glVertexAttribL3dvEXT = (TglVertexAttribL3dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL3dvEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL4dvEXT"))
                {
                    GL.glVertexAttribL4dvEXT = (TglVertexAttribL4dvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL4dvEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribLPointerEXT"))
                {
                    GL.glVertexAttribLPointerEXT = (TglVertexAttribLPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribLPointerEXT));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribLdvEXT"))
                {
                    GL.glGetVertexAttribLdvEXT = (TglGetVertexAttribLdvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribLdvEXT));
                }

                if (GL.LinkProcGLEXT("glVertexArrayVertexAttribLOffsetEXT"))
                {
                    GL.glVertexArrayVertexAttribLOffsetEXT = (TglVertexArrayVertexAttribLOffsetEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayVertexAttribLOffsetEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_sRGB_decode (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_sRGB_decode"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_x11_sync_object
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_x11_sync_object"))
            {
                if (GL.LinkProcGLEXT("glImportSyncEXT"))
                {
                    GL.glImportSyncEXT = (TglImportSyncEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglImportSyncEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_framebuffer_multisample_blit_scaled (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_framebuffer_multisample_blit_scaled"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_shader_integer_mix (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_shader_integer_mix"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_debug_label
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_debug_label"))
            {
                if (GL.LinkProcGLEXT("glLabelObjectEXT"))
                {
                    GL.glLabelObjectEXT = (TglLabelObjectEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLabelObjectEXT));
                }

                if (GL.LinkProcGLEXT("glGetObjectLabelEXT"))
                {
                    GL.glGetObjectLabelEXT = (TglGetObjectLabelEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetObjectLabelEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_debug_marker
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_debug_marker"))
            {
                if (GL.LinkProcGLEXT("glInsertEventMarkerEXT"))
                {
                    GL.glInsertEventMarkerEXT = (TglInsertEventMarkerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInsertEventMarkerEXT));
                }

                if (GL.LinkProcGLEXT("glPushGroupMarkerEXT"))
                {
                    GL.glPushGroupMarkerEXT = (TglPushGroupMarkerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPushGroupMarkerEXT));
                }

                if (GL.LinkProcGLEXT("glPopGroupMarkerEXT"))
                {
                    GL.glPopGroupMarkerEXT = (TglPopGroupMarkerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPopGroupMarkerEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_Cg_shader (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_Cg_shader"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_edge_clamp (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_edge_clamp"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_rectangle (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_rectangle"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_texture_storage
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_texture_storage"))
            {
                if (GL.LinkProcGLEXT("glTexStorage1DEXT"))
                {
                    GL.glTexStorage1DEXT = (TglTexStorage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorage1DEXT));
                }

                if (GL.LinkProcGLEXT("glTexStorage2DEXT"))
                {
                    GL.glTexStorage2DEXT = (TglTexStorage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorage2DEXT));
                }

                if (GL.LinkProcGLEXT("glTexStorage3DEXT"))
                {
                    GL.glTexStorage3DEXT = (TglTexStorage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorage3DEXT));
                }

                if (GL.LinkProcGLEXT("glTextureStorage1DEXT"))
                {
                    GL.glTextureStorage1DEXT = (TglTextureStorage1DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureStorage1DEXT));
                }

                if (GL.LinkProcGLEXT("glTextureStorage2DEXT"))
                {
                    GL.glTextureStorage2DEXT = (TglTextureStorage2DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureStorage2DEXT));
                }

                if (GL.LinkProcGLEXT("glTextureStorage3DEXT"))
                {
                    GL.glTextureStorage3DEXT = (TglTextureStorage3DEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureStorage3DEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_EXT_transform_feedback2 
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_EXT_transform_feedback2"))
            {
                if (GL.LinkProcGLEXT("glBindTransformFeedbackEXT"))
                {
                    GL.glBindTransformFeedbackEXT = (TglBindTransformFeedbackEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindTransformFeedbackEXT));
                }

                if (GL.LinkProcGLEXT("glDeleteTransformFeedbacksEXT"))
                {
                    GL.glDeleteTransformFeedbacksEXT = (TglDeleteTransformFeedbacksEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteTransformFeedbacksEXT));
                }

                if (GL.LinkProcGLEXT("glGenTransformFeedbacksEXT"))
                {
                    GL.glGenTransformFeedbacksEXT = (TglGenTransformFeedbacksEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenTransformFeedbacksEXT));
                }

                if (GL.LinkProcGLEXT("glIsTransformFeedbackEXT"))
                {
                    GL.glIsTransformFeedbackEXT = (TglIsTransformFeedbackEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsTransformFeedbackEXT));
                }

                if (GL.LinkProcGLEXT("glPauseTransformFeedbackEXT"))
                {
                    GL.glPauseTransformFeedbackEXT = (TglPauseTransformFeedbackEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPauseTransformFeedbackEXT));
                }

                if (GL.LinkProcGLEXT("glResumeTransformFeedbackEXT"))
                {
                    GL.glResumeTransformFeedbackEXT = (TglResumeTransformFeedbackEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglResumeTransformFeedbackEXT));
                }

                if (GL.LinkProcGLEXT("glDrawTransformFeedbackEXT"))
                {
                    GL.glDrawTransformFeedbackEXT = (TglDrawTransformFeedbackEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawTransformFeedbackEXT));
                }
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_GREMEDY_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_GREMEDY_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_GREMEDY_string_marker
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_GREMEDY_string_marker"))
            {
                if (GL.LinkProcGLEXT("glStringMarkerGREMEDY"))
                {
                    GL.glStringMarkerGREMEDY = (TglStringMarkerGREMEDY)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStringMarkerGREMEDY));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_GREMEDY_frame_terminator
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_GREMEDY_frame_terminator"))
            {
                if (GL.LinkProcGLEXT("glFrameTerminatorGREMEDY"))
                {
                    GL.glFrameTerminatorGREMEDY = (TglFrameTerminatorGREMEDY)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFrameTerminatorGREMEDY));
                }
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_HP_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_HP_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_HP_image_transform
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_HP_image_transform"))
            {
                if (GL.LinkProcGLEXT("glImageTransformParameteriHP"))
                {
                    GL.glImageTransformParameteriHP = (TglImageTransformParameteriHP)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglImageTransformParameteriHP));
                }

                if (GL.LinkProcGLEXT("glImageTransformParameterfHP"))
                {
                    GL.glImageTransformParameterfHP = (TglImageTransformParameterfHP)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglImageTransformParameterfHP));
                }

                if (GL.LinkProcGLEXT("glImageTransformParameterivHP"))
                {
                    GL.glImageTransformParameterivHP = (TglImageTransformParameterivHP)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglImageTransformParameterivHP));
                }

                if (GL.LinkProcGLEXT("glImageTransformParameterfvHP"))
                {
                    GL.glImageTransformParameterfvHP = (TglImageTransformParameterfvHP)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglImageTransformParameterfvHP));
                }

                if (GL.LinkProcGLEXT("glGetImageTransformParameterivHP"))
                {
                    GL.glGetImageTransformParameterivHP = (TglGetImageTransformParameterivHP)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetImageTransformParameterivHP));
                }

                if (GL.LinkProcGLEXT("glGetImageTransformParameterfvHP"))
                {
                    GL.glGetImageTransformParameterfvHP = (TglGetImageTransformParameterfvHP)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetImageTransformParameterfvHP));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_HP_convolution_border_modes (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_HP_convolution_border_modes"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_HP_texture_lighting (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_HP_texture_lighting"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_HP_occlusion_test (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_HP_occlusion_test"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_IBM_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_IBM_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_IBM_rasterpos_clip (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_IBM_rasterpos_clip"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_IBM_cull_vertex (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_IBM_cull_vertex"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_IBM_multimode_draw_arrays
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_IBM_multimode_draw_arrays"))
            {
                if (GL.LinkProcGLEXT("glMultiModeDrawArraysIBM"))
                {
                    GL.glMultiModeDrawArraysIBM = (TglMultiModeDrawArraysIBM)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiModeDrawArraysIBM));
                }

                if (GL.LinkProcGLEXT("glMultiModeDrawElementsIBM"))
                {
                    GL.glMultiModeDrawElementsIBM = (TglMultiModeDrawElementsIBM)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiModeDrawElementsIBM));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_IBM_vertex_array_lists
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_IBM_vertex_array_lists"))
            {
                if (GL.LinkProcGLEXT("glColorPointerListIBM"))
                {
                    GL.glColorPointerListIBM = (TglColorPointerListIBM)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorPointerListIBM));
                }

                if (GL.LinkProcGLEXT("glSecondaryColorPointerListIBM"))
                {
                    GL.glSecondaryColorPointerListIBM = (TglSecondaryColorPointerListIBM)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColorPointerListIBM));
                }

                if (GL.LinkProcGLEXT("glEdgeFlagPointerListIBM"))
                {
                    GL.glEdgeFlagPointerListIBM = (TglEdgeFlagPointerListIBM)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEdgeFlagPointerListIBM));
                }

                if (GL.LinkProcGLEXT("glFogCoordPointerListIBM"))
                {
                    GL.glFogCoordPointerListIBM = (TglFogCoordPointerListIBM)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoordPointerListIBM));
                }

                if (GL.LinkProcGLEXT("glIndexPointerListIBM"))
                {
                    GL.glIndexPointerListIBM = (TglIndexPointerListIBM)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexPointerListIBM));
                }

                if (GL.LinkProcGLEXT("glNormalPointerListIBM"))
                {
                    GL.glNormalPointerListIBM = (TglNormalPointerListIBM)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalPointerListIBM));
                }

                if (GL.LinkProcGLEXT("glTexCoordPointerListIBM"))
                {
                    GL.glTexCoordPointerListIBM = (TglTexCoordPointerListIBM)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordPointerListIBM));
                }

                if (GL.LinkProcGLEXT("glVertexPointerListIBM"))
                {
                    GL.glVertexPointerListIBM = (TglVertexPointerListIBM)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexPointerListIBM));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_IBM_texture_mirrored_repeat (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_IBM_texture_mirrored_repeat"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_INGR_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_INGR_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_INGR_blend_func_separate
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_INGR_blend_func_separate"))
            {
                if (GL.LinkProcGLEXT("glBlendFuncSeparateINGR"))
                {
                    GL.glBlendFuncSeparateINGR = (TglBlendFuncSeparateINGR)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendFuncSeparateINGR));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_INGR_color_clamp (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_INGR_color_clamp"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_INGR_interlace_read (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_INGR_interlace_read"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_INGR_palette_buffer (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_INGR_palette_buffer"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_INTEL_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_INTEL_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_INTEL_parallel_arrays
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_INTEL_parallel_arrays"))
            {
                if (GL.LinkProcGLEXT("glVertexPointervINTEL"))
                {
                    GL.glVertexPointervINTEL = (TglVertexPointervINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexPointervINTEL));
                }

                if (GL.LinkProcGLEXT("glNormalPointervINTEL"))
                {
                    GL.glNormalPointervINTEL = (TglNormalPointervINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalPointervINTEL));
                }

                if (GL.LinkProcGLEXT("glColorPointervINTEL"))
                {
                    GL.glColorPointervINTEL = (TglColorPointervINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorPointervINTEL));
                }

                if (GL.LinkProcGLEXT("glTexCoordPointervINTEL"))
                {
                    GL.glTexCoordPointervINTEL = (TglTexCoordPointervINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordPointervINTEL));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_INTEL_fragment_shader_ordering (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_INTEL_fragment_shader_ordering"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_INTEL_map_texture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_INTEL_map_texture"))
            {
                if (GL.LinkProcGLEXT("glSyncTextureINTEL"))
                {
                    GL.glSyncTextureINTEL = (TglSyncTextureINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSyncTextureINTEL));
                }

                if (GL.LinkProcGLEXT("glUnmapTexture2DINTEL"))
                {
                    GL.glUnmapTexture2DINTEL = (TglUnmapTexture2DINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUnmapTexture2DINTEL));
                }

                if (GL.LinkProcGLEXT("glMapTexture2DINTEL"))
                {
                    GL.glMapTexture2DINTEL = (TglMapTexture2DINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapTexture2DINTEL));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_INTEL_performance_query
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_INTEL_performance_query"))
            {
                if (GL.LinkProcGLEXT("glBeginPerfQueryINTEL"))
                {
                    GL.glBeginPerfQueryINTEL = (TglBeginPerfQueryINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginPerfQueryINTEL));
                }

                if (GL.LinkProcGLEXT("glCreatePerfQueryINTEL"))
                {
                    GL.glCreatePerfQueryINTEL = (TglCreatePerfQueryINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreatePerfQueryINTEL));
                }

                if (GL.LinkProcGLEXT("glDeletePerfQueryINTEL"))
                {
                    GL.glDeletePerfQueryINTEL = (TglDeletePerfQueryINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeletePerfQueryINTEL));
                }

                if (GL.LinkProcGLEXT("glEndPerfQueryINTEL"))
                {
                    GL.glEndPerfQueryINTEL = (TglEndPerfQueryINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndPerfQueryINTEL));
                }

                if (GL.LinkProcGLEXT("glGetFirstPerfQueryIdINTEL"))
                {
                    GL.glGetFirstPerfQueryIdINTEL = (TglGetFirstPerfQueryIdINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFirstPerfQueryIdINTEL));
                }

                if (GL.LinkProcGLEXT("glGetNextPerfQueryIdINTEL"))
                {
                    GL.glGetNextPerfQueryIdINTEL = (TglGetNextPerfQueryIdINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNextPerfQueryIdINTEL));
                }

                if (GL.LinkProcGLEXT("glGetPerfCounterInfoINTEL"))
                {
                    GL.glGetPerfCounterInfoINTEL = (TglGetPerfCounterInfoINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPerfCounterInfoINTEL));
                }

                if (GL.LinkProcGLEXT("glGetPerfQueryDataINTEL"))
                {
                    GL.glGetPerfQueryDataINTEL = (TglGetPerfQueryDataINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPerfQueryDataINTEL));
                }

                if (GL.LinkProcGLEXT("glGetPerfQueryIdByNameINTEL"))
                {
                    GL.glGetPerfQueryIdByNameINTEL = (TglGetPerfQueryIdByNameINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPerfQueryIdByNameINTEL));
                }

                if (GL.LinkProcGLEXT("glGetPerfQueryInfoINTEL"))
                {
                    GL.glGetPerfQueryInfoINTEL = (TglGetPerfQueryInfoINTEL)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPerfQueryInfoINTEL));
                }
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_KHR_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_KHR_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_KHR_context_flush_control (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_KHR_context_flush_control"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_KHR_debug
            ///////////////////////////////////////////////////////////////////////
            /* Defined in OpenGL 4.3 */
            if (GL.LinkGLEXT("GL_KHR_debug"))
            {
                if (GL.LinkProcGLEXT("glDebugMessageControl"))
                {
                    GL.glDebugMessageControl = (TglDebugMessageControl)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageControl));
                }

                if (GL.LinkProcGLEXT("glDebugMessageInsert"))
                {
                    GL.glDebugMessageInsert = (TglDebugMessageInsert)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageInsert));
                }

                if (GL.LinkProcGLEXT("glDebugMessageCallback"))
                {
                    GL.glDebugMessageCallback = (TglDebugMessageCallback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageCallback));
                }

                if (GL.LinkProcGLEXT("glGetDebugMessageLog"))
                {
                    GL.glGetDebugMessageLog = (TglGetDebugMessageLog)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetDebugMessageLog));
                }

                if (GL.LinkProcGLEXT("glPushDebugGroup"))
                {
                    GL.glPushDebugGroup = (TglPushDebugGroup)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPushDebugGroup));
                }

                if (GL.LinkProcGLEXT("glPopDebugGroup"))
                {
                    GL.glPopDebugGroup = (TglPopDebugGroup)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPopDebugGroup));
                }

                if (GL.LinkProcGLEXT("glObjectLabel"))
                {
                    GL.glObjectLabel = (TglObjectLabel)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglObjectLabel));
                }

                if (GL.LinkProcGLEXT("glGetObjectLabel"))
                {
                    GL.glGetObjectLabel = (TglGetObjectLabel)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetObjectLabel));
                }

                if (GL.LinkProcGLEXT("glObjectPtrLabel"))
                {
                    GL.glObjectPtrLabel = (TglObjectPtrLabel)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglObjectPtrLabel));
                }

                if (GL.LinkProcGLEXT("glGetObjectPtrLabel"))
                {
                    GL.glGetObjectPtrLabel = (TglGetObjectPtrLabel)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetObjectPtrLabel));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_KHR_no_error (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_KHR_no_error"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_KHR_robust_buffer_access_behavior (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_KHR_robust_buffer_access_behavior"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_KHR_robustness (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_KHR_robustness"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_KHR_texture_compression_astc_hdr (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_KHR_texture_compression_astc_hdr"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_KHR_texture_compression_astc_ldr (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_KHR_texture_compression_astc_ldr"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_KHR_texture_compression_astc_sliced_3d (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_KHR_texture_compression_astc_sliced_3d"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_KTX_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_KTX_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_KTX_buffer_region
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_KTX_buffer_region"))
            {
                if (GL.LinkProcGLEXT("glBufferRegionEnabled"))
                {
                    GL.glBufferRegionEnabled = (TglBufferRegionEnabled)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBufferRegionEnabled));
                }

                if (GL.LinkProcGLEXT("glDeleteBufferRegion"))
                {
                    GL.glDeleteBufferRegion = (TglDeleteBufferRegion)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteBufferRegion));
                }

                if (GL.LinkProcGLEXT("glDrawBufferRegion"))
                {
                    GL.glDrawBufferRegion = (TglDrawBufferRegion)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawBufferRegion));
                }

                if (GL.LinkProcGLEXT("glNewBufferRegion"))
                {
                    GL.glNewBufferRegion = (TglNewBufferRegion)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNewBufferRegion));
                }

                if (GL.LinkProcGLEXT("glReadBufferRegion"))
                {
                    GL.glReadBufferRegion = (TglReadBufferRegion)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReadBufferRegion));
                }
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_MESA_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_MESA_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_MESA_resize_buffers
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_MESA_resize_buffers"))
            {
                if (GL.LinkProcGLEXT("glResizeBuffersMESA"))
                {
                    GL.glResizeBuffersMESA = (TglResizeBuffersMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglResizeBuffersMESA));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_MESA_window_pos
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_MESA_window_pos"))
            {
                if (GL.LinkProcGLEXT("glWindowPos2dMESA"))
                {
                    GL.glWindowPos2dMESA = (TglWindowPos2dMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2dMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos2dvMESA"))
                {
                    GL.glWindowPos2dvMESA = (TglWindowPos2dvMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2dvMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos2fMESA"))
                {
                    GL.glWindowPos2fMESA = (TglWindowPos2fMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2fMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos2fvMESA"))
                {
                    GL.glWindowPos2fvMESA = (TglWindowPos2fvMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2fvMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos2iMESA"))
                {
                    GL.glWindowPos2iMESA = (TglWindowPos2iMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2iMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos2ivMESA"))
                {
                    GL.glWindowPos2ivMESA = (TglWindowPos2ivMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2ivMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos2sMESA"))
                {
                    GL.glWindowPos2sMESA = (TglWindowPos2sMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2sMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos2svMESA"))
                {
                    GL.glWindowPos2svMESA = (TglWindowPos2svMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2svMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos3dMESA"))
                {
                    GL.glWindowPos3dMESA = (TglWindowPos3dMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3dMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos3dvMESA"))
                {
                    GL.glWindowPos3dvMESA = (TglWindowPos3dvMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3dvMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos3fMESA"))
                {
                    GL.glWindowPos3fMESA = (TglWindowPos3fMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3fMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos3fvMESA"))
                {
                    GL.glWindowPos3fvMESA = (TglWindowPos3fvMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3fvMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos3iMESA"))
                {
                    GL.glWindowPos3iMESA = (TglWindowPos3iMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3iMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos3ivMESA"))
                {
                    GL.glWindowPos3ivMESA = (TglWindowPos3ivMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3ivMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos3sMESA"))
                {
                    GL.glWindowPos3sMESA = (TglWindowPos3sMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3sMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos3svMESA"))
                {
                    GL.glWindowPos3svMESA = (TglWindowPos3svMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3svMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos4dMESA"))
                {
                    GL.glWindowPos4dMESA = (TglWindowPos4dMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos4dMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos4dvMESA"))
                {
                    GL.glWindowPos4dvMESA = (TglWindowPos4dvMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos4dvMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos4fMESA"))
                {
                    GL.glWindowPos4fMESA = (TglWindowPos4fMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos4fMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos4fvMESA"))
                {
                    GL.glWindowPos4fvMESA = (TglWindowPos4fvMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos4fvMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos4iMESA"))
                {
                    GL.glWindowPos4iMESA = (TglWindowPos4iMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos4iMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos4ivMESA"))
                {
                    GL.glWindowPos4ivMESA = (TglWindowPos4ivMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos4ivMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos4sMESA"))
                {
                    GL.glWindowPos4sMESA = (TglWindowPos4sMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos4sMESA));
                }

                if (GL.LinkProcGLEXT("glWindowPos4svMESA"))
                {
                    GL.glWindowPos4svMESA = (TglWindowPos4svMESA)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos4svMESA));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_MESA_pack_invert (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_MESA_pack_invert"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_MESA_ycbcr_texture (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_MESA_ycbcr_texture"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_MESAX_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_MESAX_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_MESAX_texture_stack (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_MESAX_texture_stack"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_NV_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            // GL_NV_texgen_reflection (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_texgen_reflection"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_light_max_exponent (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_light_max_exponent"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_vertex_array_range
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_vertex_array_range"))
            {
                if (GL.LinkProcGLEXT("glFlushVertexArrayRangeNV"))
                {
                    GL.glFlushVertexArrayRangeNV = (TglFlushVertexArrayRangeNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFlushVertexArrayRangeNV));
                }

                if (GL.LinkProcGLEXT("glVertexArrayRangeNV"))
                {
                    GL.glVertexArrayRangeNV = (TglVertexArrayRangeNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayRangeNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_register_combiners
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_register_combiners"))
            {
                if (GL.LinkProcGLEXT("glCombinerParameterfvNV"))
                {
                    GL.glCombinerParameterfvNV = (TglCombinerParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCombinerParameterfvNV));
                }

                if (GL.LinkProcGLEXT("glCombinerParameterfNV"))
                {
                    GL.glCombinerParameterfNV = (TglCombinerParameterfNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCombinerParameterfNV));
                }

                if (GL.LinkProcGLEXT("glCombinerParameterivNV"))
                {
                    GL.glCombinerParameterivNV = (TglCombinerParameterivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCombinerParameterivNV));
                }

                if (GL.LinkProcGLEXT("glCombinerParameteriNV"))
                {
                    GL.glCombinerParameteriNV = (TglCombinerParameteriNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCombinerParameteriNV));
                }

                if (GL.LinkProcGLEXT("glCombinerInputNV"))
                {
                    GL.glCombinerInputNV = (TglCombinerInputNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCombinerInputNV));
                }

                if (GL.LinkProcGLEXT("glCombinerOutputNV"))
                {
                    GL.glCombinerOutputNV = (TglCombinerOutputNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCombinerOutputNV));
                }

                if (GL.LinkProcGLEXT("glFinalCombinerInputNV"))
                {
                    GL.glFinalCombinerInputNV = (TglFinalCombinerInputNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFinalCombinerInputNV));
                }

                if (GL.LinkProcGLEXT("glGetCombinerInputParameterfvNV"))
                {
                    GL.glGetCombinerInputParameterfvNV = (TglGetCombinerInputParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetCombinerInputParameterfvNV));
                }

                if (GL.LinkProcGLEXT("glGetCombinerInputParameterivNV"))
                {
                    GL.glGetCombinerInputParameterivNV = (TglGetCombinerInputParameterivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetCombinerInputParameterivNV));
                }

                if (GL.LinkProcGLEXT("glGetCombinerOutputParameterfvNV"))
                {
                    GL.glGetCombinerOutputParameterfvNV = (TglGetCombinerOutputParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetCombinerOutputParameterfvNV));
                }

                if (GL.LinkProcGLEXT("glGetCombinerOutputParameterivNV"))
                {
                    GL.glGetCombinerOutputParameterivNV = (TglGetCombinerOutputParameterivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetCombinerOutputParameterivNV));
                }

                if (GL.LinkProcGLEXT("glGetFinalCombinerInputParameterfvNV"))
                {
                    GL.glGetFinalCombinerInputParameterfvNV = (TglGetFinalCombinerInputParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFinalCombinerInputParameterfvNV));
                }

                if (GL.LinkProcGLEXT("glGetFinalCombinerInputParameterivNV"))
                {
                    GL.glGetFinalCombinerInputParameterivNV = (TglGetFinalCombinerInputParameterivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFinalCombinerInputParameterivNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_fog_distance (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_fog_distance"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_texgen_emboss (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_texgen_emboss"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_blend_square (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_blend_square"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_texture_env_combine4 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_texture_env_combine4"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_fbo_color_attachments (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_fbo_color_attachments"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_fence
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_fence"))
            {
                if (GL.LinkProcGLEXT("glDeleteFencesNV"))
                {
                    GL.glDeleteFencesNV = (TglDeleteFencesNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteFencesNV));
                }

                if (GL.LinkProcGLEXT("glGenFencesNV"))
                {
                    GL.glGenFencesNV = (TglGenFencesNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenFencesNV));
                }

                if (GL.LinkProcGLEXT("glIsFenceNV"))
                {
                    GL.glIsFenceNV = (TglIsFenceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsFenceNV));
                }

                if (GL.LinkProcGLEXT("glTestFenceNV"))
                {
                    GL.glTestFenceNV = (TglTestFenceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTestFenceNV));
                }

                if (GL.LinkProcGLEXT("glGetFenceivNV"))
                {
                    GL.glGetFenceivNV = (TglGetFenceivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFenceivNV));
                }

                if (GL.LinkProcGLEXT("glFinishFenceNV"))
                {
                    GL.glFinishFenceNV = (TglFinishFenceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFinishFenceNV));
                }

                if (GL.LinkProcGLEXT("glSetFenceNV"))
                {
                    GL.glSetFenceNV = (TglSetFenceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSetFenceNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_evaluators
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_evaluators"))
            {
                if (GL.LinkProcGLEXT("glMapControlPointsNV"))
                {
                    GL.glMapControlPointsNV = (TglMapControlPointsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapControlPointsNV));
                }

                if (GL.LinkProcGLEXT("glMapParameterivNV"))
                {
                    GL.glMapParameterivNV = (TglMapParameterivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapParameterivNV));
                }

                if (GL.LinkProcGLEXT("glMapParameterfvNV"))
                {
                    GL.glMapParameterfvNV = (TglMapParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapParameterfvNV));
                }

                if (GL.LinkProcGLEXT("glGetMapControlPointsNV"))
                {
                    GL.glGetMapControlPointsNV = (TglGetMapControlPointsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMapControlPointsNV));
                }

                if (GL.LinkProcGLEXT("glGetMapParameterivNV"))
                {
                    GL.glGetMapParameterivNV = (TglGetMapParameterivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMapParameterivNV));
                }

                if (GL.LinkProcGLEXT("glGetMapParameterfvNV"))
                {
                    GL.glGetMapParameterfvNV = (TglGetMapParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMapParameterfvNV));
                }

                if (GL.LinkProcGLEXT("glGetMapAttribParameterivNV"))
                {
                    GL.glGetMapAttribParameterivNV = (TglGetMapAttribParameterivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMapAttribParameterivNV));
                }

                if (GL.LinkProcGLEXT("glGetMapAttribParameterfvNV"))
                {
                    GL.glGetMapAttribParameterfvNV = (TglGetMapAttribParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMapAttribParameterfvNV));
                }

                if (GL.LinkProcGLEXT("glEvalMapsNV"))
                {
                    GL.glEvalMapsNV = (TglEvalMapsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalMapsNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_packed_depth_stencil (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_packed_depth_stencil"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_register_combiners2
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_register_combiners2"))
            {
                if (GL.LinkProcGLEXT("glCombinerStageParameterfvNV"))
                {
                    GL.glCombinerStageParameterfvNV = (TglCombinerStageParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCombinerStageParameterfvNV));
                }

                if (GL.LinkProcGLEXT("glGetCombinerStageParameterfvNV"))
                {
                    GL.glGetCombinerStageParameterfvNV = (TglGetCombinerStageParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetCombinerStageParameterfvNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_texture_compression_vtc (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_texture_compression_vtc"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_texture_rectangle (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_texture_rectangle"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_texture_shader (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_texture_shader"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_texture_shader2 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_texture_shader2"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_vertex_array_range2 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_vertex_array_range2"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_vertex_program
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_vertex_program"))
            {
                if (GL.LinkProcGLEXT("glAreProgramsResidentNV"))
                {
                    GL.glAreProgramsResidentNV = (TglAreProgramsResidentNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAreProgramsResidentNV));
                }

                if (GL.LinkProcGLEXT("glBindProgramNV"))
                {
                    GL.glBindProgramNV = (TglBindProgramNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindProgramNV));
                }

                if (GL.LinkProcGLEXT("glDeleteProgramsNV"))
                {
                    GL.glDeleteProgramsNV = (TglDeleteProgramsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteProgramsNV));
                }

                if (GL.LinkProcGLEXT("glExecuteProgramNV"))
                {
                    GL.glExecuteProgramNV = (TglExecuteProgramNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglExecuteProgramNV));
                }

                if (GL.LinkProcGLEXT("glGenProgramsNV"))
                {
                    GL.glGenProgramsNV = (TglGenProgramsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenProgramsNV));
                }

                if (GL.LinkProcGLEXT("glGetProgramParameterdvNV"))
                {
                    GL.glGetProgramParameterdvNV = (TglGetProgramParameterdvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramParameterdvNV));
                }

                if (GL.LinkProcGLEXT("glGetProgramParameterfvNV"))
                {
                    GL.glGetProgramParameterfvNV = (TglGetProgramParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramParameterfvNV));
                }

                if (GL.LinkProcGLEXT("glGetProgramivNV"))
                {
                    GL.glGetProgramivNV = (TglGetProgramivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramivNV));
                }

                if (GL.LinkProcGLEXT("glGetProgramStringNV"))
                {
                    GL.glGetProgramStringNV = (TglGetProgramStringNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramStringNV));
                }

                if (GL.LinkProcGLEXT("glGetTrackMatrixivNV"))
                {
                    GL.glGetTrackMatrixivNV = (TglGetTrackMatrixivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTrackMatrixivNV));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribdvNV"))
                {
                    GL.glGetVertexAttribdvNV = (TglGetVertexAttribdvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribdvNV));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribfvNV"))
                {
                    GL.glGetVertexAttribfvNV = (TglGetVertexAttribfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribfvNV));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribivNV"))
                {
                    GL.glGetVertexAttribivNV = (TglGetVertexAttribivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribivNV));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribPointervNV"))
                {
                    GL.glGetVertexAttribPointervNV = (TglGetVertexAttribPointervNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribPointervNV));
                }

                if (GL.LinkProcGLEXT("glIsProgramNV"))
                {
                    GL.glIsProgramNV = (TglIsProgramNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsProgramNV));
                }

                if (GL.LinkProcGLEXT("glLoadProgramNV"))
                {
                    GL.glLoadProgramNV = (TglLoadProgramNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLoadProgramNV));
                }

                if (GL.LinkProcGLEXT("glProgramParameter4dNV"))
                {
                    GL.glProgramParameter4dNV = (TglProgramParameter4dNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramParameter4dNV));
                }

                if (GL.LinkProcGLEXT("glProgramParameter4dvNV"))
                {
                    GL.glProgramParameter4dvNV = (TglProgramParameter4dvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramParameter4dvNV));
                }

                if (GL.LinkProcGLEXT("glProgramParameter4fNV"))
                {
                    GL.glProgramParameter4fNV = (TglProgramParameter4fNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramParameter4fNV));
                }

                if (GL.LinkProcGLEXT("glProgramParameter4fvNV"))
                {
                    GL.glProgramParameter4fvNV = (TglProgramParameter4fvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramParameter4fvNV));
                }

                if (GL.LinkProcGLEXT("glProgramParameters4dvNV"))
                {
                    GL.glProgramParameters4dvNV = (TglProgramParameters4dvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramParameters4dvNV));
                }

                if (GL.LinkProcGLEXT("glProgramParameters4fvNV"))
                {
                    GL.glProgramParameters4fvNV = (TglProgramParameters4fvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramParameters4fvNV));
                }

                if (GL.LinkProcGLEXT("glRequestResidentProgramsNV"))
                {
                    GL.glRequestResidentProgramsNV = (TglRequestResidentProgramsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRequestResidentProgramsNV));
                }

                if (GL.LinkProcGLEXT("glTrackMatrixNV"))
                {
                    GL.glTrackMatrixNV = (TglTrackMatrixNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTrackMatrixNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribPointerNV"))
                {
                    GL.glVertexAttribPointerNV = (TglVertexAttribPointerNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribPointerNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib1dNV"))
                {
                    GL.glVertexAttrib1dNV = (TglVertexAttrib1dNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1dNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib1dvNV"))
                {
                    GL.glVertexAttrib1dvNV = (TglVertexAttrib1dvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1dvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib1fNV"))
                {
                    GL.glVertexAttrib1fNV = (TglVertexAttrib1fNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1fNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib1fvNV"))
                {
                    GL.glVertexAttrib1fvNV = (TglVertexAttrib1fvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1fvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib1sNV"))
                {
                    GL.glVertexAttrib1sNV = (TglVertexAttrib1sNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1sNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib1svNV"))
                {
                    GL.glVertexAttrib1svNV = (TglVertexAttrib1svNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1svNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2dNV"))
                {
                    GL.glVertexAttrib2dNV = (TglVertexAttrib2dNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2dNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2dvNV"))
                {
                    GL.glVertexAttrib2dvNV = (TglVertexAttrib2dvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2dvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2fNV"))
                {
                    GL.glVertexAttrib2fNV = (TglVertexAttrib2fNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2fNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2fvNV"))
                {
                    GL.glVertexAttrib2fvNV = (TglVertexAttrib2fvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2fvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2sNV"))
                {
                    GL.glVertexAttrib2sNV = (TglVertexAttrib2sNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2sNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2svNV"))
                {
                    GL.glVertexAttrib2svNV = (TglVertexAttrib2svNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2svNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3dNV"))
                {
                    GL.glVertexAttrib3dNV = (TglVertexAttrib3dNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3dNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3dvNV"))
                {
                    GL.glVertexAttrib3dvNV = (TglVertexAttrib3dvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3dvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3fNV"))
                {
                    GL.glVertexAttrib3fNV = (TglVertexAttrib3fNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3fNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3fvNV"))
                {
                    GL.glVertexAttrib3fvNV = (TglVertexAttrib3fvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3fvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3sNV"))
                {
                    GL.glVertexAttrib3sNV = (TglVertexAttrib3sNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3sNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3svNV"))
                {
                    GL.glVertexAttrib3svNV = (TglVertexAttrib3svNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3svNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4dNV"))
                {
                    GL.glVertexAttrib4dNV = (TglVertexAttrib4dNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4dNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4dvNV"))
                {
                    GL.glVertexAttrib4dvNV = (TglVertexAttrib4dvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4dvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4fNV"))
                {
                    GL.glVertexAttrib4fNV = (TglVertexAttrib4fNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4fNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4fvNV"))
                {
                    GL.glVertexAttrib4fvNV = (TglVertexAttrib4fvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4fvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4sNV"))
                {
                    GL.glVertexAttrib4sNV = (TglVertexAttrib4sNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4sNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4svNV"))
                {
                    GL.glVertexAttrib4svNV = (TglVertexAttrib4svNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4svNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4ubNV"))
                {
                    GL.glVertexAttrib4ubNV = (TglVertexAttrib4ubNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4ubNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4ubvNV"))
                {
                    GL.glVertexAttrib4ubvNV = (TglVertexAttrib4ubvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4ubvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs1dvNV"))
                {
                    GL.glVertexAttribs1dvNV = (TglVertexAttribs1dvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs1dvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs1fvNV"))
                {
                    GL.glVertexAttribs1fvNV = (TglVertexAttribs1fvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs1fvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs1svNV"))
                {
                    GL.glVertexAttribs1svNV = (TglVertexAttribs1svNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs1svNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs2dvNV"))
                {
                    GL.glVertexAttribs2dvNV = (TglVertexAttribs2dvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs2dvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs2fvNV"))
                {
                    GL.glVertexAttribs2fvNV = (TglVertexAttribs2fvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs2fvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs2svNV"))
                {
                    GL.glVertexAttribs2svNV = (TglVertexAttribs2svNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs2svNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs3dvNV"))
                {
                    GL.glVertexAttribs3dvNV = (TglVertexAttribs3dvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs3dvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs3fvNV"))
                {
                    GL.glVertexAttribs3fvNV = (TglVertexAttribs3fvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs3fvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs3svNV"))
                {
                    GL.glVertexAttribs3svNV = (TglVertexAttribs3svNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs3svNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs4dvNV"))
                {
                    GL.glVertexAttribs4dvNV = (TglVertexAttribs4dvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs4dvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs4fvNV"))
                {
                    GL.glVertexAttribs4fvNV = (TglVertexAttribs4fvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs4fvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs4svNV"))
                {
                    GL.glVertexAttribs4svNV = (TglVertexAttribs4svNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs4svNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs4ubvNV"))
                {
                    GL.glVertexAttribs4ubvNV = (TglVertexAttribs4ubvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs4ubvNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_copy_depth_to_color (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_copy_depth_to_color"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_multisample_filter_hint (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_multisample_filter_hint"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_depth_clamp (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_depth_clamp"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_occlusion_query (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_occlusion_query"))
            {
                if (GL.LinkProcGLEXT("glGenOcclusionQueriesNV"))
                {
                    GL.glGenOcclusionQueriesNV = (TglGenOcclusionQueriesNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenOcclusionQueriesNV));
                }

                if (GL.LinkProcGLEXT("glDeleteOcclusionQueriesNV"))
                {
                    GL.glDeleteOcclusionQueriesNV = (TglDeleteOcclusionQueriesNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteOcclusionQueriesNV));
                }

                if (GL.LinkProcGLEXT("glIsOcclusionQueryNV"))
                {
                    GL.glIsOcclusionQueryNV = (TglIsOcclusionQueryNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsOcclusionQueryNV));
                }

                if (GL.LinkProcGLEXT("glBeginOcclusionQueryNV"))
                {
                    GL.glBeginOcclusionQueryNV = (TglBeginOcclusionQueryNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginOcclusionQueryNV));
                }

                if (GL.LinkProcGLEXT("glEndOcclusionQueryNV"))
                {
                    GL.glEndOcclusionQueryNV = (TglEndOcclusionQueryNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndOcclusionQueryNV));
                }

                if (GL.LinkProcGLEXT("glGetOcclusionQueryivNV"))
                {
                    GL.glGetOcclusionQueryivNV = (TglGetOcclusionQueryivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetOcclusionQueryivNV));
                }

                if (GL.LinkProcGLEXT("glGetOcclusionQueryuivNV"))
                {
                    GL.glGetOcclusionQueryuivNV = (TglGetOcclusionQueryuivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetOcclusionQueryuivNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_point_sprite
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_point_sprite"))
            {
                if (GL.LinkProcGLEXT("glPointParameteriNV"))
                {
                    GL.glPointParameteriNV = (TglPointParameteriNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointParameteriNV));
                }

                if (GL.LinkProcGLEXT("glPointParameterivNV"))
                {
                    GL.glPointParameterivNV = (TglPointParameterivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointParameterivNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_texture_shader3 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_texture_shader3"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_vertex_program1_1 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_vertex_program1_1"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_float_buffer (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_float_buffer"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_fragment_program
            ///////////////////////////////////////////////////////////////////////
            /* Some NV_fragment_program entry points are shared with ARB_vertex_program. */
            if (GL.LinkGLEXT("GL_NV_fragment_program"))
            {
                if (GL.LinkProcGLEXT("glProgramNamedParameter4fNV"))
                {
                    GL.glProgramNamedParameter4fNV = (TglProgramNamedParameter4fNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramNamedParameter4fNV));
                }

                if (GL.LinkProcGLEXT("glProgramNamedParameter4dNV"))
                {
                    GL.glProgramNamedParameter4dNV = (TglProgramNamedParameter4dNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramNamedParameter4dNV));
                }

                if (GL.LinkProcGLEXT("glProgramNamedParameter4fvNV"))
                {
                    GL.glProgramNamedParameter4fvNV = (TglProgramNamedParameter4fvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramNamedParameter4fvNV));
                }

                if (GL.LinkProcGLEXT("glProgramNamedParameter4dvNV"))
                {
                    GL.glProgramNamedParameter4dvNV = (TglProgramNamedParameter4dvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramNamedParameter4dvNV));
                }

                if (GL.LinkProcGLEXT("glGetProgramNamedParameterfvNV"))
                {
                    GL.glGetProgramNamedParameterfvNV = (TglGetProgramNamedParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramNamedParameterfvNV));
                }

                if (GL.LinkProcGLEXT("glGetProgramNamedParameterdvNV"))
                {
                    GL.glGetProgramNamedParameterdvNV = (TglGetProgramNamedParameterdvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramNamedParameterdvNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_half_float
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_half_float"))
            {
                if (GL.LinkProcGLEXT("glVertex2hNV"))
                {
                    GL.glVertex2hNV = (TglVertex2hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2hNV));
                }

                if (GL.LinkProcGLEXT("glVertex2hvNV"))
                {
                    GL.glVertex2hvNV = (TglVertex2hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2hvNV));
                }

                if (GL.LinkProcGLEXT("glVertex3hNV"))
                {
                    GL.glVertex3hNV = (TglVertex3hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3hNV));
                }

                if (GL.LinkProcGLEXT("glVertex3hvNV"))
                {
                    GL.glVertex3hvNV = (TglVertex3hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3hvNV));
                }

                if (GL.LinkProcGLEXT("glVertex4hNV"))
                {
                    GL.glVertex4hNV = (TglVertex4hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4hNV));
                }

                if (GL.LinkProcGLEXT("glVertex4hvNV"))
                {
                    GL.glVertex4hvNV = (TglVertex4hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4hvNV));
                }

                if (GL.LinkProcGLEXT("glNormal3hNV"))
                {
                    GL.glNormal3hNV = (TglNormal3hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3hNV));
                }

                if (GL.LinkProcGLEXT("glNormal3hvNV"))
                {
                    GL.glNormal3hvNV = (TglNormal3hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3hvNV));
                }

                if (GL.LinkProcGLEXT("glColor3hNV"))
                {
                    GL.glColor3hNV = (TglColor3hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3hNV));
                }

                if (GL.LinkProcGLEXT("glColor3hvNV"))
                {
                    GL.glColor3hvNV = (TglColor3hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3hvNV));
                }

                if (GL.LinkProcGLEXT("glColor4hNV"))
                {
                    GL.glColor4hNV = (TglColor4hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4hNV));
                }

                if (GL.LinkProcGLEXT("glColor4hvNV"))
                {
                    GL.glColor4hvNV = (TglColor4hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4hvNV));
                }

                if (GL.LinkProcGLEXT("glTexCoord1hNV"))
                {
                    GL.glTexCoord1hNV = (TglTexCoord1hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1hNV));
                }

                if (GL.LinkProcGLEXT("glTexCoord1hvNV"))
                {
                    GL.glTexCoord1hvNV = (TglTexCoord1hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1hvNV));
                }

                if (GL.LinkProcGLEXT("glTexCoord2hNV"))
                {
                    GL.glTexCoord2hNV = (TglTexCoord2hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2hNV));
                }

                if (GL.LinkProcGLEXT("glTexCoord2hvNV"))
                {
                    GL.glTexCoord2hvNV = (TglTexCoord2hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2hvNV));
                }

                if (GL.LinkProcGLEXT("glTexCoord3hNV"))
                {
                    GL.glTexCoord3hNV = (TglTexCoord3hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3hNV));
                }

                if (GL.LinkProcGLEXT("glTexCoord3hvNV"))
                {
                    GL.glTexCoord3hvNV = (TglTexCoord3hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3hvNV));
                }

                if (GL.LinkProcGLEXT("glTexCoord4hNV"))
                {
                    GL.glTexCoord4hNV = (TglTexCoord4hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4hNV));
                }

                if (GL.LinkProcGLEXT("glTexCoord4hvNV"))
                {
                    GL.glTexCoord4hvNV = (TglTexCoord4hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4hvNV));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord1hNV"))
                {
                    GL.glMultiTexCoord1hNV = (TglMultiTexCoord1hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1hNV));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord1hvNV"))
                {
                    GL.glMultiTexCoord1hvNV = (TglMultiTexCoord1hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1hvNV));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2hNV"))
                {
                    GL.glMultiTexCoord2hNV = (TglMultiTexCoord2hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2hNV));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2hvNV"))
                {
                    GL.glMultiTexCoord2hvNV = (TglMultiTexCoord2hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2hvNV));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3hNV"))
                {
                    GL.glMultiTexCoord3hNV = (TglMultiTexCoord3hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3hNV));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3hvNV"))
                {
                    GL.glMultiTexCoord3hvNV = (TglMultiTexCoord3hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3hvNV));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4hNV"))
                {
                    GL.glMultiTexCoord4hNV = (TglMultiTexCoord4hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4hNV));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4hvNV"))
                {
                    GL.glMultiTexCoord4hvNV = (TglMultiTexCoord4hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4hvNV));
                }

                if (GL.LinkProcGLEXT("glFogCoordhNV"))
                {
                    GL.glFogCoordhNV = (TglFogCoordhNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoordhNV));
                }

                if (GL.LinkProcGLEXT("glFogCoordhvNV"))
                {
                    GL.glFogCoordhvNV = (TglFogCoordhvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoordhvNV));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3hNV"))
                {
                    GL.glSecondaryColor3hNV = (TglSecondaryColor3hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3hNV));
                }

                if (GL.LinkProcGLEXT("glSecondaryColor3hvNV"))
                {
                    GL.glSecondaryColor3hvNV = (TglSecondaryColor3hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3hvNV));
                }

                if (GL.LinkProcGLEXT("glVertexWeighthNV"))
                {
                    GL.glVertexWeighthNV = (TglVertexWeighthNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexWeighthNV));
                }

                if (GL.LinkProcGLEXT("glVertexWeighthvNV"))
                {
                    GL.glVertexWeighthvNV = (TglVertexWeighthvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexWeighthvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib1hNV"))
                {
                    GL.glVertexAttrib1hNV = (TglVertexAttrib1hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1hNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib1hvNV"))
                {
                    GL.glVertexAttrib1hvNV = (TglVertexAttrib1hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1hvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2hNV"))
                {
                    GL.glVertexAttrib2hNV = (TglVertexAttrib2hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2hNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib2hvNV"))
                {
                    GL.glVertexAttrib2hvNV = (TglVertexAttrib2hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2hvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3hNV"))
                {
                    GL.glVertexAttrib3hNV = (TglVertexAttrib3hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3hNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib3hvNV"))
                {
                    GL.glVertexAttrib3hvNV = (TglVertexAttrib3hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3hvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4hNV"))
                {
                    GL.glVertexAttrib4hNV = (TglVertexAttrib4hNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4hNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttrib4hvNV"))
                {
                    GL.glVertexAttrib4hvNV = (TglVertexAttrib4hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4hvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs1hvNV"))
                {
                    GL.glVertexAttribs1hvNV = (TglVertexAttribs1hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs1hvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs2hvNV"))
                {
                    GL.glVertexAttribs2hvNV = (TglVertexAttribs2hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs2hvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs3hvNV"))
                {
                    GL.glVertexAttribs3hvNV = (TglVertexAttribs3hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs3hvNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribs4hvNV"))
                {
                    GL.glVertexAttribs4hvNV = (TglVertexAttribs4hvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribs4hvNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_pixel_data_range
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_pixel_data_range"))
            {
                if (GL.LinkProcGLEXT("glPixelDataRangeNV"))
                {
                    GL.glPixelDataRangeNV = (TglPixelDataRangeNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelDataRangeNV));
                }

                if (GL.LinkProcGLEXT("glFlushPixelDataRangeNV"))
                {
                    GL.glFlushPixelDataRangeNV = (TglFlushPixelDataRangeNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFlushPixelDataRangeNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_primitive_restart
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_primitive_restart"))
            {
                if (GL.LinkProcGLEXT("glPrimitiveRestartNV"))
                {
                    GL.glPrimitiveRestartNV = (TglPrimitiveRestartNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPrimitiveRestartNV));
                }

                if (GL.LinkProcGLEXT("glPrimitiveRestartIndexNV"))
                {
                    GL.glPrimitiveRestartIndexNV = (TglPrimitiveRestartIndexNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPrimitiveRestartIndexNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_texture_expand_normal (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_texture_expand_normal"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_vertex_program2 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_vertex_program2"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_fragment_program_option (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_fragment_program_option"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_fragment_program2 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_fragment_program2"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_vertex_program2_option (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_vertex_program2_option"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_vertex_program3 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_vertex_program3"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_gpu_program4
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_gpu_program4"))
            {
                if (GL.LinkProcGLEXT("glProgramLocalParameterI4iNV"))
                {
                    GL.glProgramLocalParameterI4iNV = (TglProgramLocalParameterI4iNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramLocalParameterI4iNV));
                }

                if (GL.LinkProcGLEXT("glProgramLocalParameterI4ivNV"))
                {
                    GL.glProgramLocalParameterI4ivNV = (TglProgramLocalParameterI4ivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramLocalParameterI4ivNV));
                }

                if (GL.LinkProcGLEXT("glProgramLocalParametersI4ivNV"))
                {
                    GL.glProgramLocalParametersI4ivNV = (TglProgramLocalParametersI4ivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramLocalParametersI4ivNV));
                }

                if (GL.LinkProcGLEXT("glProgramLocalParameterI4uiNV"))
                {
                    GL.glProgramLocalParameterI4uiNV = (TglProgramLocalParameterI4uiNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramLocalParameterI4uiNV));
                }

                if (GL.LinkProcGLEXT("glProgramLocalParameterI4uivNV"))
                {
                    GL.glProgramLocalParameterI4uivNV = (TglProgramLocalParameterI4uivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramLocalParameterI4uivNV));
                }

                if (GL.LinkProcGLEXT("glProgramLocalParametersI4uivNV"))
                {
                    GL.glProgramLocalParametersI4uivNV = (TglProgramLocalParametersI4uivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramLocalParametersI4uivNV));
                }

                if (GL.LinkProcGLEXT("glProgramEnvParameterI4iNV"))
                {
                    GL.glProgramEnvParameterI4iNV = (TglProgramEnvParameterI4iNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramEnvParameterI4iNV));
                }

                if (GL.LinkProcGLEXT("glProgramEnvParameterI4ivNV"))
                {
                    GL.glProgramEnvParameterI4ivNV = (TglProgramEnvParameterI4ivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramEnvParameterI4ivNV));
                }

                if (GL.LinkProcGLEXT("glProgramEnvParametersI4ivNV"))
                {
                    GL.glProgramEnvParametersI4ivNV = (TglProgramEnvParametersI4ivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramEnvParametersI4ivNV));
                }

                if (GL.LinkProcGLEXT("glProgramEnvParameterI4uiNV"))
                {
                    GL.glProgramEnvParameterI4uiNV = (TglProgramEnvParameterI4uiNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramEnvParameterI4uiNV));
                }

                if (GL.LinkProcGLEXT("glProgramEnvParameterI4uivNV"))
                {
                    GL.glProgramEnvParameterI4uivNV = (TglProgramEnvParameterI4uivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramEnvParameterI4uivNV));
                }

                if (GL.LinkProcGLEXT("glProgramEnvParametersI4uivNV"))
                {
                    GL.glProgramEnvParametersI4uivNV = (TglProgramEnvParametersI4uivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramEnvParametersI4uivNV));
                }

                if (GL.LinkProcGLEXT("glGetProgramLocalParameterIivNV"))
                {
                    GL.glGetProgramLocalParameterIivNV = (TglGetProgramLocalParameterIivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramLocalParameterIivNV));
                }

                if (GL.LinkProcGLEXT("glGetProgramLocalParameterIuivNV"))
                {
                    GL.glGetProgramLocalParameterIuivNV = (TglGetProgramLocalParameterIuivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramLocalParameterIuivNV));
                }

                if (GL.LinkProcGLEXT("glGetProgramEnvParameterIivNV"))
                {
                    GL.glGetProgramEnvParameterIivNV = (TglGetProgramEnvParameterIivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramEnvParameterIivNV));
                }

                if (GL.LinkProcGLEXT("glGetProgramEnvParameterIuivNV"))
                {
                    GL.glGetProgramEnvParameterIuivNV = (TglGetProgramEnvParameterIuivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramEnvParameterIuivNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_geometry_program4
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_geometry_program4"))
            {
                if (GL.LinkProcGLEXT("glProgramVertexLimitNV"))
                {
                    GL.glProgramVertexLimitNV = (TglProgramVertexLimitNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramVertexLimitNV));
                }

                if (GL.LinkProcGLEXT("glFramebufferTextureEXT"))
                {
                    GL.glFramebufferTextureEXT = (TglFramebufferTextureEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTextureEXT));
                }

                if (GL.LinkProcGLEXT("glFramebufferTextureLayerEXT"))
                {
                    GL.glFramebufferTextureLayerEXT = (TglFramebufferTextureLayerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTextureLayerEXT));
                }

                if (GL.LinkProcGLEXT("glFramebufferTextureFaceEXT"))
                {
                    GL.glFramebufferTextureFaceEXT = (TglFramebufferTextureFaceEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTextureFaceEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_vertex_program4
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_vertex_program4"))
            {
                if (GL.LinkProcGLEXT("glVertexAttribI1iEXT"))
                {
                    GL.glVertexAttribI1iEXT = (TglVertexAttribI1iEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI1iEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI2iEXT"))
                {
                    GL.glVertexAttribI2iEXT = (TglVertexAttribI2iEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI2iEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI3iEXT"))
                {
                    GL.glVertexAttribI3iEXT = (TglVertexAttribI3iEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI3iEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI4iEXT"))
                {
                    GL.glVertexAttribI4iEXT = (TglVertexAttribI4iEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4iEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI1uiEXT"))
                {
                    GL.glVertexAttribI1uiEXT = (TglVertexAttribI1uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI1uiEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI2uiEXT"))
                {
                    GL.glVertexAttribI2uiEXT = (TglVertexAttribI2uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI2uiEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI3uiEXT"))
                {
                    GL.glVertexAttribI3uiEXT = (TglVertexAttribI3uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI3uiEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI4uiEXT"))
                {
                    GL.glVertexAttribI4uiEXT = (TglVertexAttribI4uiEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4uiEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI1ivEXT"))
                {
                    GL.glVertexAttribI1ivEXT = (TglVertexAttribI1ivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI1ivEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI2ivEXT"))
                {
                    GL.glVertexAttribI2ivEXT = (TglVertexAttribI2ivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI2ivEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI3ivEXT"))
                {
                    GL.glVertexAttribI3ivEXT = (TglVertexAttribI3ivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI3ivEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI4ivEXT"))
                {
                    GL.glVertexAttribI4ivEXT = (TglVertexAttribI4ivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4ivEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI1uivEXT"))
                {
                    GL.glVertexAttribI1uivEXT = (TglVertexAttribI1uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI1uivEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI2uivEXT"))
                {
                    GL.glVertexAttribI2uivEXT = (TglVertexAttribI2uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI2uivEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI3uivEXT"))
                {
                    GL.glVertexAttribI3uivEXT = (TglVertexAttribI3uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI3uivEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI4uivEXT"))
                {
                    GL.glVertexAttribI4uivEXT = (TglVertexAttribI4uivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4uivEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI4bvEXT"))
                {
                    GL.glVertexAttribI4bvEXT = (TglVertexAttribI4bvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4bvEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI4svEXT"))
                {
                    GL.glVertexAttribI4svEXT = (TglVertexAttribI4svEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4svEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI4ubvEXT"))
                {
                    GL.glVertexAttribI4ubvEXT = (TglVertexAttribI4ubvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4ubvEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribI4usvEXT"))
                {
                    GL.glVertexAttribI4usvEXT = (TglVertexAttribI4usvEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4usvEXT));
                }

                if (GL.LinkProcGLEXT("glVertexAttribIPointerEXT"))
                {
                    GL.glVertexAttribIPointerEXT = (TglVertexAttribIPointerEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribIPointerEXT));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribIivEXT"))
                {
                    GL.glGetVertexAttribIivEXT = (TglGetVertexAttribIivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribIivEXT));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribIuivEXT"))
                {
                    GL.glGetVertexAttribIuivEXT = (TglGetVertexAttribIuivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribIuivEXT));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_depth_buffer_float
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_depth_buffer_float"))
            {
                if (GL.LinkProcGLEXT("glDepthRangedNV"))
                {
                    GL.glDepthRangedNV = (TglDepthRangedNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthRangedNV));
                }

                if (GL.LinkProcGLEXT("glClearDepthdNV"))
                {
                    GL.glClearDepthdNV = (TglClearDepthdNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearDepthdNV));
                }

                if (GL.LinkProcGLEXT("glDepthBoundsdNV"))
                {
                    GL.glDepthBoundsdNV = (TglDepthBoundsdNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthBoundsdNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_fragment_program4 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_fragment_program4"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_framebuffer_multisample_coverage
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_framebuffer_multisample_coverage"))
            {
                if (GL.LinkProcGLEXT("glRenderbufferStorageMultisampleCoverageNV"))
                {
                    GL.glRenderbufferStorageMultisampleCoverageNV = (TglRenderbufferStorageMultisampleCoverageNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRenderbufferStorageMultisampleCoverageNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_geometry_shader4 (no function entry point)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_geometry_shader4"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_parameter_buffer_object
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_parameter_buffer_object"))
            {
                if (GL.LinkProcGLEXT("glProgramBufferParametersfvNV"))
                {
                    GL.glProgramBufferParametersfvNV = (TglProgramBufferParametersfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramBufferParametersfvNV));
                }

                if (GL.LinkProcGLEXT("glProgramBufferParametersIivNV"))
                {
                    GL.glProgramBufferParametersIivNV = (TglProgramBufferParametersIivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramBufferParametersIivNV));
                }

                if (GL.LinkProcGLEXT("glProgramBufferParametersIuivNV"))
                {
                    GL.glProgramBufferParametersIuivNV = (TglProgramBufferParametersIuivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramBufferParametersIuivNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_transform_feedback
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_transform_feedback"))
            {
                if (GL.LinkProcGLEXT("glBeginTransformFeedbackNV"))
                {
                    GL.glBeginTransformFeedbackNV = (TglBeginTransformFeedbackNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginTransformFeedbackNV));
                }

                if (GL.LinkProcGLEXT("glEndTransformFeedbackNV"))
                {
                    GL.glEndTransformFeedbackNV = (TglEndTransformFeedbackNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndTransformFeedbackNV));
                }

                if (GL.LinkProcGLEXT("glTransformFeedbackAttribsNV"))
                {
                    GL.glTransformFeedbackAttribsNV = (TglTransformFeedbackAttribsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTransformFeedbackAttribsNV));
                }

                if (GL.LinkProcGLEXT("glBindBufferRangeNV"))
                {
                    GL.glBindBufferRangeNV = (TglBindBufferRangeNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindBufferRangeNV));
                }

                if (GL.LinkProcGLEXT("glBindBufferOffsetNV"))
                {
                    GL.glBindBufferOffsetNV = (TglBindBufferOffsetNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindBufferOffsetNV));
                }

                if (GL.LinkProcGLEXT("glBindBufferBaseNV"))
                {
                    GL.glBindBufferBaseNV = (TglBindBufferBaseNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindBufferBaseNV));
                }

                if (GL.LinkProcGLEXT("glTransformFeedbackVaryingsNV"))
                {
                    GL.glTransformFeedbackVaryingsNV = (TglTransformFeedbackVaryingsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTransformFeedbackVaryingsNV));
                }

                if (GL.LinkProcGLEXT("glActiveVaryingNV"))
                {
                    GL.glActiveVaryingNV = (TglActiveVaryingNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglActiveVaryingNV));
                }

                if (GL.LinkProcGLEXT("glGetVaryingLocationNV"))
                {
                    GL.glGetVaryingLocationNV = (TglGetVaryingLocationNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVaryingLocationNV));
                }

                if (GL.LinkProcGLEXT("glGetActiveVaryingNV"))
                {
                    GL.glGetActiveVaryingNV = (TglGetActiveVaryingNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveVaryingNV));
                }

                if (GL.LinkProcGLEXT("glGetTransformFeedbackVaryingNV"))
                {
                    GL.glGetTransformFeedbackVaryingNV = (TglGetTransformFeedbackVaryingNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTransformFeedbackVaryingNV));
                }

                if (GL.LinkProcGLEXT("glTransformFeedbackStreamAttribsNV"))
                {
                    GL.glTransformFeedbackStreamAttribsNV = (TglTransformFeedbackStreamAttribsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTransformFeedbackStreamAttribsNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_conditional_render
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_conditional_render"))
            {
                if (GL.LinkProcGLEXT("glBeginConditionalRenderNV"))
                {
                    GL.glBeginConditionalRenderNV = (TglBeginConditionalRenderNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginConditionalRenderNV));
                }

                if (GL.LinkProcGLEXT("glEndConditionalRenderNV"))
                {
                    GL.glEndConditionalRenderNV = (TglEndConditionalRenderNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndConditionalRenderNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_present_video
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_present_video"))
            {
                if (GL.LinkProcGLEXT("glPresentFrameKeyedNV"))
                {
                    GL.glPresentFrameKeyedNV = (TglPresentFrameKeyedNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPresentFrameKeyedNV));
                }

                if (GL.LinkProcGLEXT("glPresentFrameDualFillNV"))
                {
                    GL.glPresentFrameDualFillNV = (TglPresentFrameDualFillNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPresentFrameDualFillNV));
                }

                if (GL.LinkProcGLEXT("glGetVideoivNV"))
                {
                    GL.glGetVideoivNV = (TglGetVideoivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVideoivNV));
                }

                if (GL.LinkProcGLEXT("glGetVideouivNV"))
                {
                    GL.glGetVideouivNV = (TglGetVideouivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVideouivNV));
                }

                if (GL.LinkProcGLEXT("glGetVideoi64vNV"))
                {
                    GL.glGetVideoi64vNV = (TglGetVideoi64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVideoi64vNV));
                }

                if (GL.LinkProcGLEXT("glGetVideoui64vNV"))
                {
                    GL.glGetVideoui64vNV = (TglGetVideoui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVideoui64vNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_explicit_multisample
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_explicit_multisample"))
            {
                if (GL.LinkProcGLEXT("glGetMultisamplefvNV"))
                {
                    GL.glGetMultisamplefvNV = (TglGetMultisamplefvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultisamplefvNV));
                }

                if (GL.LinkProcGLEXT("glSampleMaskIndexedNV"))
                {
                    GL.glSampleMaskIndexedNV = (TglSampleMaskIndexedNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSampleMaskIndexedNV));
                }

                if (GL.LinkProcGLEXT("glTexRenderbufferNV"))
                {
                    GL.glTexRenderbufferNV = (TglTexRenderbufferNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexRenderbufferNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_transform_feedback2
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_transform_feedback2"))
            {
                if (GL.LinkProcGLEXT("glBindTransformFeedbackNV"))
                {
                    GL.glBindTransformFeedbackNV = (TglBindTransformFeedbackNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindTransformFeedbackNV));
                }

                if (GL.LinkProcGLEXT("glDeleteTransformFeedbacksNV"))
                {
                    GL.glDeleteTransformFeedbacksNV = (TglDeleteTransformFeedbacksNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteTransformFeedbacksNV));
                }

                if (GL.LinkProcGLEXT("glGenTransformFeedbacksNV"))
                {
                    GL.glGenTransformFeedbacksNV = (TglGenTransformFeedbacksNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenTransformFeedbacksNV));
                }

                if (GL.LinkProcGLEXT("glIsTransformFeedbackNV"))
                {
                    GL.glIsTransformFeedbackNV = (TglIsTransformFeedbackNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsTransformFeedbackNV));
                }

                if (GL.LinkProcGLEXT("glPauseTransformFeedbackNV"))
                {
                    GL.glPauseTransformFeedbackNV = (TglPauseTransformFeedbackNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPauseTransformFeedbackNV));
                }

                if (GL.LinkProcGLEXT("glResumeTransformFeedbackNV"))
                {
                    GL.glResumeTransformFeedbackNV = (TglResumeTransformFeedbackNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglResumeTransformFeedbackNV));
                }

                if (GL.LinkProcGLEXT("glDrawTransformFeedbackNV"))
                {
                    GL.glDrawTransformFeedbackNV = (TglDrawTransformFeedbackNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawTransformFeedbackNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_video_capture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_video_capture"))
            {
                if (GL.LinkProcGLEXT("glBeginVideoCaptureNV"))
                {
                    GL.glBeginVideoCaptureNV = (TglBeginVideoCaptureNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginVideoCaptureNV));
                }

                if (GL.LinkProcGLEXT("glBindVideoCaptureStreamBufferNV"))
                {
                    GL.glBindVideoCaptureStreamBufferNV = (TglBindVideoCaptureStreamBufferNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindVideoCaptureStreamBufferNV));
                }

                if (GL.LinkProcGLEXT("glBindVideoCaptureStreamTextureNV"))
                {
                    GL.glBindVideoCaptureStreamTextureNV = (TglBindVideoCaptureStreamTextureNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindVideoCaptureStreamTextureNV));
                }

                if (GL.LinkProcGLEXT("glEndVideoCaptureNV"))
                {
                    GL.glEndVideoCaptureNV = (TglEndVideoCaptureNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndVideoCaptureNV));
                }

                if (GL.LinkProcGLEXT("glGetVideoCaptureivNV"))
                {
                    GL.glGetVideoCaptureivNV = (TglGetVideoCaptureivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVideoCaptureivNV));
                }

                if (GL.LinkProcGLEXT("glGetVideoCaptureStreamivNV"))
                {
                    GL.glGetVideoCaptureStreamivNV = (TglGetVideoCaptureStreamivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVideoCaptureStreamivNV));
                }

                if (GL.LinkProcGLEXT("glGetVideoCaptureStreamfvNV"))
                {
                    GL.glGetVideoCaptureStreamfvNV = (TglGetVideoCaptureStreamfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVideoCaptureStreamfvNV));
                }

                if (GL.LinkProcGLEXT("glGetVideoCaptureStreamdvNV"))
                {
                    GL.glGetVideoCaptureStreamdvNV = (TglGetVideoCaptureStreamdvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVideoCaptureStreamdvNV));
                }

                if (GL.LinkProcGLEXT("glVideoCaptureNV"))
                {
                    GL.glVideoCaptureNV = (TglVideoCaptureNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVideoCaptureNV));
                }

                if (GL.LinkProcGLEXT("glVideoCaptureStreamParameterivNV"))
                {
                    GL.glVideoCaptureStreamParameterivNV = (TglVideoCaptureStreamParameterivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVideoCaptureStreamParameterivNV));
                }

                if (GL.LinkProcGLEXT("glVideoCaptureStreamParameterfvNV"))
                {
                    GL.glVideoCaptureStreamParameterfvNV = (TglVideoCaptureStreamParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVideoCaptureStreamParameterfvNV));
                }

                if (GL.LinkProcGLEXT("glVideoCaptureStreamParameterdvNV"))
                {
                    GL.glVideoCaptureStreamParameterdvNV = (TglVideoCaptureStreamParameterdvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVideoCaptureStreamParameterdvNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_copy_image
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_copy_image"))
            {
                if (GL.LinkProcGLEXT("glCopyImageSubDataNV"))
                {
                    GL.glCopyImageSubDataNV = (TglCopyImageSubDataNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyImageSubDataNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_parameter_buffer_object2 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_parameter_buffer_object2"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_shader_buffer_load
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_shader_buffer_load"))
            {
                if (GL.LinkProcGLEXT("glMakeBufferResidentNV"))
                {
                    GL.glMakeBufferResidentNV = (TglMakeBufferResidentNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMakeBufferResidentNV));
                }

                if (GL.LinkProcGLEXT("glMakeBufferNonResidentNV"))
                {
                    GL.glMakeBufferNonResidentNV = (TglMakeBufferNonResidentNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMakeBufferNonResidentNV));
                }

                if (GL.LinkProcGLEXT("glIsBufferResidentNV"))
                {
                    GL.glIsBufferResidentNV = (TglIsBufferResidentNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsBufferResidentNV));
                }

                if (GL.LinkProcGLEXT("glMakeNamedBufferResidentNV"))
                {
                    GL.glMakeNamedBufferResidentNV = (TglMakeNamedBufferResidentNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMakeNamedBufferResidentNV));
                }

                if (GL.LinkProcGLEXT("glMakeNamedBufferNonResidentNV"))
                {
                    GL.glMakeNamedBufferNonResidentNV = (TglMakeNamedBufferNonResidentNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMakeNamedBufferNonResidentNV));
                }

                if (GL.LinkProcGLEXT("glIsNamedBufferResidentNV"))
                {
                    GL.glIsNamedBufferResidentNV = (TglIsNamedBufferResidentNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsNamedBufferResidentNV));
                }

                if (GL.LinkProcGLEXT("glGetBufferParameterui64vNV"))
                {
                    GL.glGetBufferParameterui64vNV = (TglGetBufferParameterui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetBufferParameterui64vNV));
                }

                if (GL.LinkProcGLEXT("glGetNamedBufferParameterui64vNV"))
                {
                    GL.glGetNamedBufferParameterui64vNV = (TglGetNamedBufferParameterui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedBufferParameterui64vNV));
                }

                if (GL.LinkProcGLEXT("glGetIntegerui64vNV"))
                {
                    GL.glGetIntegerui64vNV = (TglGetIntegerui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetIntegerui64vNV));
                }

                if (GL.LinkProcGLEXT("glUniformui64NV"))
                {
                    GL.glUniformui64NV = (TglUniformui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformui64NV));
                }

                if (GL.LinkProcGLEXT("glUniformui64vNV"))
                {
                    GL.glUniformui64vNV = (TglUniformui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformui64vNV));
                }

                if (GL.LinkProcGLEXT("glGetUniformui64vNV"))
                {
                    GL.glGetUniformui64vNV = (TglGetUniformui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformui64vNV));
                }

                if (GL.LinkProcGLEXT("glProgramUniformui64NV"))
                {
                    GL.glProgramUniformui64NV = (TglProgramUniformui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformui64NV));
                }

                if (GL.LinkProcGLEXT("glProgramUniformui64vNV"))
                {
                    GL.glProgramUniformui64vNV = (TglProgramUniformui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformui64vNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_vertex_buffer_unified_memory
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_vertex_buffer_unified_memory"))
            {
                if (GL.LinkProcGLEXT("glBufferAddressRangeNV"))
                {
                    GL.glBufferAddressRangeNV = (TglBufferAddressRangeNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBufferAddressRangeNV));
                }

                if (GL.LinkProcGLEXT("glVertexFormatNV"))
                {
                    GL.glVertexFormatNV = (TglVertexFormatNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexFormatNV));
                }

                if (GL.LinkProcGLEXT("glNormalFormatNV"))
                {
                    GL.glNormalFormatNV = (TglNormalFormatNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalFormatNV));
                }

                if (GL.LinkProcGLEXT("glColorFormatNV"))
                {
                    GL.glColorFormatNV = (TglColorFormatNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorFormatNV));
                }

                if (GL.LinkProcGLEXT("glIndexFormatNV"))
                {
                    GL.glIndexFormatNV = (TglIndexFormatNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexFormatNV));
                }

                if (GL.LinkProcGLEXT("glTexCoordFormatNV"))
                {
                    GL.glTexCoordFormatNV = (TglTexCoordFormatNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordFormatNV));
                }

                if (GL.LinkProcGLEXT("glEdgeFlagFormatNV"))
                {
                    GL.glEdgeFlagFormatNV = (TglEdgeFlagFormatNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEdgeFlagFormatNV));
                }

                if (GL.LinkProcGLEXT("glSecondaryColorFormatNV"))
                {
                    GL.glSecondaryColorFormatNV = (TglSecondaryColorFormatNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColorFormatNV));
                }

                if (GL.LinkProcGLEXT("glFogCoordFormatNV"))
                {
                    GL.glFogCoordFormatNV = (TglFogCoordFormatNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoordFormatNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribFormatNV"))
                {
                    GL.glVertexAttribFormatNV = (TglVertexAttribFormatNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribFormatNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribIFormatNV"))
                {
                    GL.glVertexAttribIFormatNV = (TglVertexAttribIFormatNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribIFormatNV));
                }

                if (GL.LinkProcGLEXT("glGetIntegerui64i_vNV"))
                {
                    GL.glGetIntegerui64i_vNV = (TglGetIntegerui64i_vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetIntegerui64i_vNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_texture_barrier
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_texture_barrier"))
            {
                if (GL.LinkProcGLEXT("glTextureBarrierNV"))
                {
                    GL.glTextureBarrierNV = (TglTextureBarrierNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureBarrierNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_gpu_program5
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_gpu_program5"))
            {
                if (GL.LinkProcGLEXT("glProgramSubroutineParametersuivNV"))
                {
                    GL.glProgramSubroutineParametersuivNV = (TglProgramSubroutineParametersuivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramSubroutineParametersuivNV));
                }

                if (GL.LinkProcGLEXT("glGetProgramSubroutineParameteruivNV"))
                {
                    GL.glGetProgramSubroutineParameteruivNV = (TglGetProgramSubroutineParameteruivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramSubroutineParameteruivNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_gpu_shader5
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_gpu_shader5"))
            {
                if (GL.LinkProcGLEXT("glUniform1i64NV"))
                {
                    GL.glUniform1i64NV = (TglUniform1i64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1i64NV));
                }

                if (GL.LinkProcGLEXT("glUniform2i64NV"))
                {
                    GL.glUniform2i64NV = (TglUniform2i64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2i64NV));
                }

                if (GL.LinkProcGLEXT("glUniform3i64NV"))
                {
                    GL.glUniform3i64NV = (TglUniform3i64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3i64NV));
                }

                if (GL.LinkProcGLEXT("glUniform4i64NV"))
                {
                    GL.glUniform4i64NV = (TglUniform4i64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4i64NV));
                }

                if (GL.LinkProcGLEXT("glUniform1i64vNV"))
                {
                    GL.glUniform1i64vNV = (TglUniform1i64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1i64vNV));
                }

                if (GL.LinkProcGLEXT("glUniform2i64vNV"))
                {
                    GL.glUniform2i64vNV = (TglUniform2i64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2i64vNV));
                }

                if (GL.LinkProcGLEXT("glUniform3i64vNV"))
                {
                    GL.glUniform3i64vNV = (TglUniform3i64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3i64vNV));
                }

                if (GL.LinkProcGLEXT("glUniform4i64vNV"))
                {
                    GL.glUniform4i64vNV = (TglUniform4i64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4i64vNV));
                }

                if (GL.LinkProcGLEXT("glUniform1ui64NV"))
                {
                    GL.glUniform1ui64NV = (TglUniform1ui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1ui64NV));
                }

                if (GL.LinkProcGLEXT("glUniform2ui64NV"))
                {
                    GL.glUniform2ui64NV = (TglUniform2ui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2ui64NV));
                }

                if (GL.LinkProcGLEXT("glUniform3ui64NV"))
                {
                    GL.glUniform3ui64NV = (TglUniform3ui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3ui64NV));
                }

                if (GL.LinkProcGLEXT("glUniform4ui64NV"))
                {
                    GL.glUniform4ui64NV = (TglUniform4ui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4ui64NV));
                }

                if (GL.LinkProcGLEXT("glUniform1ui64vNV"))
                {
                    GL.glUniform1ui64vNV = (TglUniform1ui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1ui64vNV));
                }

                if (GL.LinkProcGLEXT("glUniform2ui64vNV"))
                {
                    GL.glUniform2ui64vNV = (TglUniform2ui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2ui64vNV));
                }

                if (GL.LinkProcGLEXT("glUniform3ui64vNV"))
                {
                    GL.glUniform3ui64vNV = (TglUniform3ui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3ui64vNV));
                }

                if (GL.LinkProcGLEXT("glUniform4ui64vNV"))
                {
                    GL.glUniform4ui64vNV = (TglUniform4ui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4ui64vNV));
                }

                if (GL.LinkProcGLEXT("glGetUniformi64vNV"))
                {
                    GL.glGetUniformi64vNV = (TglGetUniformi64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformi64vNV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1i64NV"))
                {
                    GL.glProgramUniform1i64NV = (TglProgramUniform1i64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1i64NV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2i64NV"))
                {
                    GL.glProgramUniform2i64NV = (TglProgramUniform2i64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2i64NV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3i64NV"))
                {
                    GL.glProgramUniform3i64NV = (TglProgramUniform3i64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3i64NV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4i64NV"))
                {
                    GL.glProgramUniform4i64NV = (TglProgramUniform4i64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4i64NV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1i64vNV"))
                {
                    GL.glProgramUniform1i64vNV = (TglProgramUniform1i64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1i64vNV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2i64vNV"))
                {
                    GL.glProgramUniform2i64vNV = (TglProgramUniform2i64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2i64vNV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3i64vNV"))
                {
                    GL.glProgramUniform3i64vNV = (TglProgramUniform3i64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3i64vNV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4i64vNV"))
                {
                    GL.glProgramUniform4i64vNV = (TglProgramUniform4i64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4i64vNV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1ui64NV"))
                {
                    GL.glProgramUniform1ui64NV = (TglProgramUniform1ui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1ui64NV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2ui64NV"))
                {
                    GL.glProgramUniform2ui64NV = (TglProgramUniform2ui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2ui64NV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3ui64NV"))
                {
                    GL.glProgramUniform3ui64NV = (TglProgramUniform3ui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3ui64NV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4ui64NV"))
                {
                    GL.glProgramUniform4ui64NV = (TglProgramUniform4ui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4ui64NV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform1ui64vNV"))
                {
                    GL.glProgramUniform1ui64vNV = (TglProgramUniform1ui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1ui64vNV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform2ui64vNV"))
                {
                    GL.glProgramUniform2ui64vNV = (TglProgramUniform2ui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2ui64vNV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform3ui64vNV"))
                {
                    GL.glProgramUniform3ui64vNV = (TglProgramUniform3ui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3ui64vNV));
                }

                if (GL.LinkProcGLEXT("glProgramUniform4ui64vNV"))
                {
                    GL.glProgramUniform4ui64vNV = (TglProgramUniform4ui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4ui64vNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_shader_buffer_store (no function entry point)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_shader_buffer_store"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_tessellation_program5 (no function entry point)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_tessellation_program5"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_vertex_attrib_integer_64bit
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_vertex_attrib_integer_64bit"))
            {
                if (GL.LinkProcGLEXT("glVertexAttribL1i64NV"))
                {
                    GL.glVertexAttribL1i64NV = (TglVertexAttribL1i64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL1i64NV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL2i64NV"))
                {
                    GL.glVertexAttribL2i64NV = (TglVertexAttribL2i64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL2i64NV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL3i64NV"))
                {
                    GL.glVertexAttribL3i64NV = (TglVertexAttribL3i64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL3i64NV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL4i64NV"))
                {
                    GL.glVertexAttribL4i64NV = (TglVertexAttribL4i64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL4i64NV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL1i64vNV"))
                {
                    GL.glVertexAttribL1i64vNV = (TglVertexAttribL1i64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL1i64vNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL2i64vNV"))
                {
                    GL.glVertexAttribL2i64vNV = (TglVertexAttribL2i64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL2i64vNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL3i64vNV"))
                {
                    GL.glVertexAttribL3i64vNV = (TglVertexAttribL3i64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL3i64vNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL4i64vNV"))
                {
                    GL.glVertexAttribL4i64vNV = (TglVertexAttribL4i64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL4i64vNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL1ui64NV"))
                {
                    GL.glVertexAttribL1ui64NV = (TglVertexAttribL1ui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL1ui64NV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL2ui64NV"))
                {
                    GL.glVertexAttribL2ui64NV = (TglVertexAttribL2ui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL2ui64NV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL3ui64NV"))
                {
                    GL.glVertexAttribL3ui64NV = (TglVertexAttribL3ui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL3ui64NV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL4ui64NV"))
                {
                    GL.glVertexAttribL4ui64NV = (TglVertexAttribL4ui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL4ui64NV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL1ui64vNV"))
                {
                    GL.glVertexAttribL1ui64vNV = (TglVertexAttribL1ui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL1ui64vNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL2ui64vNV"))
                {
                    GL.glVertexAttribL2ui64vNV = (TglVertexAttribL2ui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL2ui64vNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL3ui64vNV"))
                {
                    GL.glVertexAttribL3ui64vNV = (TglVertexAttribL3ui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL3ui64vNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribL4ui64vNV"))
                {
                    GL.glVertexAttribL4ui64vNV = (TglVertexAttribL4ui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL4ui64vNV));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribLi64vNV"))
                {
                    GL.glGetVertexAttribLi64vNV = (TglGetVertexAttribLi64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribLi64vNV));
                }

                if (GL.LinkProcGLEXT("glGetVertexAttribLui64vNV"))
                {
                    GL.glGetVertexAttribLui64vNV = (TglGetVertexAttribLui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribLui64vNV));
                }

                if (GL.LinkProcGLEXT("glVertexAttribLFormatNV"))
                {
                    GL.glVertexAttribLFormatNV = (TglVertexAttribLFormatNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribLFormatNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_multisample_coverage (no function entry point)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_multisample_coverage"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_vdpau_interop
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_vdpau_interop"))
            {
                if (GL.LinkProcGLEXT("glVDPAUInitNV"))
                {
                    GL.glVDPAUInitNV = (TglVDPAUInitNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVDPAUInitNV));
                }

                if (GL.LinkProcGLEXT("glVDPAUFiniNV"))
                {
                    GL.glVDPAUFiniNV = (TglVDPAUFiniNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVDPAUFiniNV));
                }

                if (GL.LinkProcGLEXT("glVDPAURegisterVideoSurfaceNV"))
                {
                    GL.glVDPAURegisterVideoSurfaceNV = (TglVDPAURegisterVideoSurfaceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVDPAURegisterVideoSurfaceNV));
                }

                if (GL.LinkProcGLEXT("glVDPAURegisterOutputSurfaceNV"))
                {
                    GL.glVDPAURegisterOutputSurfaceNV = (TglVDPAURegisterOutputSurfaceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVDPAURegisterOutputSurfaceNV));
                }

                if (GL.LinkProcGLEXT("glVDPAUIsSurfaceNV"))
                {
                    GL.glVDPAUIsSurfaceNV = (TglVDPAUIsSurfaceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVDPAUIsSurfaceNV));
                }

                if (GL.LinkProcGLEXT("glVDPAUUnregisterSurfaceNV"))
                {
                    GL.glVDPAUUnregisterSurfaceNV = (TglVDPAUUnregisterSurfaceNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVDPAUUnregisterSurfaceNV));
                }

                if (GL.LinkProcGLEXT("glVDPAUGetSurfaceivNV"))
                {
                    GL.glVDPAUGetSurfaceivNV = (TglVDPAUGetSurfaceivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVDPAUGetSurfaceivNV));
                }

                if (GL.LinkProcGLEXT("glVDPAUSurfaceAccessNV"))
                {
                    GL.glVDPAUSurfaceAccessNV = (TglVDPAUSurfaceAccessNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVDPAUSurfaceAccessNV));
                }

                if (GL.LinkProcGLEXT("glVDPAUMapSurfacesNV"))
                {
                    GL.glVDPAUMapSurfacesNV = (TglVDPAUMapSurfacesNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVDPAUMapSurfacesNV));
                }

                if (GL.LinkProcGLEXT("glVDPAUUnmapSurfacesNV"))
                {
                    GL.glVDPAUUnmapSurfacesNV = (TglVDPAUUnmapSurfacesNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVDPAUUnmapSurfacesNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_texture_multisample
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_texture_multisample"))
            {
                if (GL.LinkProcGLEXT("glTexImage2DMultisampleCoverageNV"))
                {
                    GL.glTexImage2DMultisampleCoverageNV = (TglTexImage2DMultisampleCoverageNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexImage2DMultisampleCoverageNV));
                }

                if (GL.LinkProcGLEXT("glTexImage3DMultisampleCoverageNV"))
                {
                    GL.glTexImage3DMultisampleCoverageNV = (TglTexImage3DMultisampleCoverageNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexImage3DMultisampleCoverageNV));
                }

                if (GL.LinkProcGLEXT("glTextureImage2DMultisampleNV"))
                {
                    GL.glTextureImage2DMultisampleNV = (TglTextureImage2DMultisampleNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureImage2DMultisampleNV));
                }

                if (GL.LinkProcGLEXT("glTextureImage3DMultisampleNV"))
                {
                    GL.glTextureImage3DMultisampleNV = (TglTextureImage3DMultisampleNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureImage3DMultisampleNV));
                }

                if (GL.LinkProcGLEXT("glTextureImage2DMultisampleCoverageNV"))
                {
                    GL.glTextureImage2DMultisampleCoverageNV = (TglTextureImage2DMultisampleCoverageNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureImage2DMultisampleCoverageNV));
                }

                if (GL.LinkProcGLEXT("glTextureImage3DMultisampleCoverageNV"))
                {
                    GL.glTextureImage3DMultisampleCoverageNV = (TglTextureImage3DMultisampleCoverageNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureImage3DMultisampleCoverageNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_path_rendering
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_path_rendering"))
            {
                if (GL.LinkProcGLEXT("glGenPathsNV"))
                {
                    GL.glGenPathsNV = (TglGenPathsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenPathsNV));
                }

                if (GL.LinkProcGLEXT("glDeletePathsNV"))
                {
                    GL.glDeletePathsNV = (TglDeletePathsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeletePathsNV));
                }

                if (GL.LinkProcGLEXT("glIsPathNV"))
                {
                    GL.glIsPathNV = (TglIsPathNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsPathNV));
                }

                if (GL.LinkProcGLEXT("glPathCommandsNV"))
                {
                    GL.glPathCommandsNV = (TglPathCommandsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathCommandsNV));
                }

                if (GL.LinkProcGLEXT("glPathCoordsNV"))
                {
                    GL.glPathCoordsNV = (TglPathCoordsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathCoordsNV));
                }

                if (GL.LinkProcGLEXT("glPathSubCommandsNV"))
                {
                    GL.glPathSubCommandsNV = (TglPathSubCommandsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathSubCommandsNV));
                }

                if (GL.LinkProcGLEXT("glPathSubCoordsNV"))
                {
                    GL.glPathSubCoordsNV = (TglPathSubCoordsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathSubCoordsNV));
                }

                if (GL.LinkProcGLEXT("glPathStringNV"))
                {
                    GL.glPathStringNV = (TglPathStringNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathStringNV));
                }

                if (GL.LinkProcGLEXT("glPathGlyphsNV"))
                {
                    GL.glPathGlyphsNV = (TglPathGlyphsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathGlyphsNV));
                }

                if (GL.LinkProcGLEXT("glPathGlyphRangeNV"))
                {
                    GL.glPathGlyphRangeNV = (TglPathGlyphRangeNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathGlyphRangeNV));
                }

                if (GL.LinkProcGLEXT("glWeightPathsNV"))
                {
                    GL.glWeightPathsNV = (TglWeightPathsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWeightPathsNV));
                }

                if (GL.LinkProcGLEXT("glCopyPathNV"))
                {
                    GL.glCopyPathNV = (TglCopyPathNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyPathNV));
                }

                if (GL.LinkProcGLEXT("glInterpolatePathsNV"))
                {
                    GL.glInterpolatePathsNV = (TglInterpolatePathsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInterpolatePathsNV));
                }

                if (GL.LinkProcGLEXT("glTransformPathNV"))
                {
                    GL.glTransformPathNV = (TglTransformPathNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTransformPathNV));
                }

                if (GL.LinkProcGLEXT("glPathParameterivNV"))
                {
                    GL.glPathParameterivNV = (TglPathParameterivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathParameterivNV));
                }

                if (GL.LinkProcGLEXT("glPathParameteriNV"))
                {
                    GL.glPathParameteriNV = (TglPathParameteriNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathParameteriNV));
                }

                if (GL.LinkProcGLEXT("glPathParameterfvNV"))
                {
                    GL.glPathParameterfvNV = (TglPathParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathParameterfvNV));
                }

                if (GL.LinkProcGLEXT("glPathParameterfNV"))
                {
                    GL.glPathParameterfNV = (TglPathParameterfNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathParameterfNV));
                }

                if (GL.LinkProcGLEXT("glPathDashArrayNV"))
                {
                    GL.glPathDashArrayNV = (TglPathDashArrayNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathDashArrayNV));
                }

                if (GL.LinkProcGLEXT("glPathStencilFuncNV"))
                {
                    GL.glPathStencilFuncNV = (TglPathStencilFuncNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathStencilFuncNV));
                }

                if (GL.LinkProcGLEXT("glPathStencilDepthOffsetNV"))
                {
                    GL.glPathStencilDepthOffsetNV = (TglPathStencilDepthOffsetNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathStencilDepthOffsetNV));
                }

                if (GL.LinkProcGLEXT("glStencilFillPathNV"))
                {
                    GL.glStencilFillPathNV = (TglStencilFillPathNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilFillPathNV));
                }

                if (GL.LinkProcGLEXT("glStencilStrokePathNV"))
                {
                    GL.glStencilStrokePathNV = (TglStencilStrokePathNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilStrokePathNV));
                }

                if (GL.LinkProcGLEXT("glStencilFillPathInstancedNV"))
                {
                    GL.glStencilFillPathInstancedNV = (TglStencilFillPathInstancedNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilFillPathInstancedNV));
                }

                if (GL.LinkProcGLEXT("glStencilStrokePathInstancedNV"))
                {
                    GL.glStencilStrokePathInstancedNV = (TglStencilStrokePathInstancedNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilStrokePathInstancedNV));
                }

                if (GL.LinkProcGLEXT("glPathCoverDepthFuncNV"))
                {
                    GL.glPathCoverDepthFuncNV = (TglPathCoverDepthFuncNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathCoverDepthFuncNV));
                }

                if (GL.LinkProcGLEXT("glPathColorGenNV"))
                {
                    GL.glPathColorGenNV = (TglPathColorGenNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathColorGenNV));
                }

                if (GL.LinkProcGLEXT("glPathTexGenNV"))
                {
                    GL.glPathTexGenNV = (TglPathTexGenNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathTexGenNV));
                }

                if (GL.LinkProcGLEXT("glPathFogGenNV"))
                {
                    GL.glPathFogGenNV = (TglPathFogGenNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPathFogGenNV));
                }

                if (GL.LinkProcGLEXT("glCoverFillPathNV"))
                {
                    GL.glCoverFillPathNV = (TglCoverFillPathNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCoverFillPathNV));
                }

                if (GL.LinkProcGLEXT("glCoverStrokePathNV"))
                {
                    GL.glCoverStrokePathNV = (TglCoverStrokePathNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCoverStrokePathNV));
                }

                if (GL.LinkProcGLEXT("glCoverFillPathInstancedNV"))
                {
                    GL.glCoverFillPathInstancedNV = (TglCoverFillPathInstancedNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCoverFillPathInstancedNV));
                }

                if (GL.LinkProcGLEXT("glCoverStrokePathInstancedNV"))
                {
                    GL.glCoverStrokePathInstancedNV = (TglCoverStrokePathInstancedNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCoverStrokePathInstancedNV));
                }

                if (GL.LinkProcGLEXT("glGetPathParameterivNV"))
                {
                    GL.glGetPathParameterivNV = (TglGetPathParameterivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPathParameterivNV));
                }

                if (GL.LinkProcGLEXT("glGetPathParameterfvNV"))
                {
                    GL.glGetPathParameterfvNV = (TglGetPathParameterfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPathParameterfvNV));
                }

                if (GL.LinkProcGLEXT("glGetPathCommandsNV"))
                {
                    GL.glGetPathCommandsNV = (TglGetPathCommandsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPathCommandsNV));
                }

                if (GL.LinkProcGLEXT("glGetPathCoordsNV"))
                {
                    GL.glGetPathCoordsNV = (TglGetPathCoordsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPathCoordsNV));
                }

                if (GL.LinkProcGLEXT("glGetPathDashArrayNV"))
                {
                    GL.glGetPathDashArrayNV = (TglGetPathDashArrayNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPathDashArrayNV));
                }

                if (GL.LinkProcGLEXT("glGetPathMetricsNV"))
                {
                    GL.glGetPathMetricsNV = (TglGetPathMetricsNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPathMetricsNV));
                }

                if (GL.LinkProcGLEXT("glGetPathMetricRangeNV"))
                {
                    GL.glGetPathMetricRangeNV = (TglGetPathMetricRangeNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPathMetricRangeNV));
                }

                if (GL.LinkProcGLEXT("glGetPathSpacingNV"))
                {
                    GL.glGetPathSpacingNV = (TglGetPathSpacingNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPathSpacingNV));
                }

                if (GL.LinkProcGLEXT("glGetPathColorGenivNV"))
                {
                    GL.glGetPathColorGenivNV = (TglGetPathColorGenivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPathColorGenivNV));
                }

                if (GL.LinkProcGLEXT("glGetPathColorGenfvNV"))
                {
                    GL.glGetPathColorGenfvNV = (TglGetPathColorGenfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPathColorGenfvNV));
                }

                if (GL.LinkProcGLEXT("glGetPathTexGenivNV"))
                {
                    GL.glGetPathTexGenivNV = (TglGetPathTexGenivNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPathTexGenivNV));
                }

                if (GL.LinkProcGLEXT("glGetPathTexGenfvNV"))
                {
                    GL.glGetPathTexGenfvNV = (TglGetPathTexGenfvNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPathTexGenfvNV));
                }

                if (GL.LinkProcGLEXT("glIsPointInFillPathNV"))
                {
                    GL.glIsPointInFillPathNV = (TglIsPointInFillPathNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsPointInFillPathNV));
                }

                if (GL.LinkProcGLEXT("glIsPointInStrokePathNV"))
                {
                    GL.glIsPointInStrokePathNV = (TglIsPointInStrokePathNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsPointInStrokePathNV));
                }

                if (GL.LinkProcGLEXT("glGetPathLengthNV"))
                {
                    GL.glGetPathLengthNV = (TglGetPathLengthNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPathLengthNV));
                }

                if (GL.LinkProcGLEXT("glPointAlongPathNV"))
                {
                    GL.glPointAlongPathNV = (TglPointAlongPathNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointAlongPathNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_bindless_texture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_bindless_texture"))
            {
                if (GL.LinkProcGLEXT("glGetTextureHandleNV"))
                {
                    GL.glGetTextureHandleNV = (TglGetTextureHandleNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureHandleNV));
                }

                if (GL.LinkProcGLEXT("glGetTextureSamplerHandleNV"))
                {
                    GL.glGetTextureSamplerHandleNV = (TglGetTextureSamplerHandleNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureSamplerHandleNV));
                }

                if (GL.LinkProcGLEXT("glMakeTextureHandleResidentNV"))
                {
                    GL.glMakeTextureHandleResidentNV = (TglMakeTextureHandleResidentNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMakeTextureHandleResidentNV));
                }

                if (GL.LinkProcGLEXT("glMakeTextureHandleNonResidentNV"))
                {
                    GL.glMakeTextureHandleNonResidentNV = (TglMakeTextureHandleNonResidentNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMakeTextureHandleNonResidentNV));
                }

                if (GL.LinkProcGLEXT("glGetImageHandleNV"))
                {
                    GL.glGetImageHandleNV = (TglGetImageHandleNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetImageHandleNV));
                }

                if (GL.LinkProcGLEXT("glMakeImageHandleResidentNV"))
                {
                    GL.glMakeImageHandleResidentNV = (TglMakeImageHandleResidentNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMakeImageHandleResidentNV));
                }

                if (GL.LinkProcGLEXT("glMakeImageHandleNonResidentNV"))
                {
                    GL.glMakeImageHandleNonResidentNV = (TglMakeImageHandleNonResidentNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMakeImageHandleNonResidentNV));
                }

                if (GL.LinkProcGLEXT("glUniformHandleui64NV"))
                {
                    GL.glUniformHandleui64NV = (TglUniformHandleui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformHandleui64NV));
                }

                if (GL.LinkProcGLEXT("glUniformHandleui64vNV"))
                {
                    GL.glUniformHandleui64vNV = (TglUniformHandleui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformHandleui64vNV));
                }

                if (GL.LinkProcGLEXT("glProgramUniformHandleui64NV"))
                {
                    GL.glProgramUniformHandleui64NV = (TglProgramUniformHandleui64NV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformHandleui64NV));
                }

                if (GL.LinkProcGLEXT("glProgramUniformHandleui64vNV"))
                {
                    GL.glProgramUniformHandleui64vNV = (TglProgramUniformHandleui64vNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformHandleui64vNV));
                }

                if (GL.LinkProcGLEXT("glIsTextureHandleResidentNV"))
                {
                    GL.glIsTextureHandleResidentNV = (TglIsTextureHandleResidentNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsTextureHandleResidentNV));
                }

                if (GL.LinkProcGLEXT("glIsImageHandleResidentNV"))
                {
                    GL.glIsImageHandleResidentNV = (TglIsImageHandleResidentNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsImageHandleResidentNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_shader_atomic_float (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_shader_atomic_float"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_gpu_program5_mem_extended (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_gpu_program5_mem_extended"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_shader_atomic_counters (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_shader_atomic_counters"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_shader_storage_buffer_object (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_shader_storage_buffer_object"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_bindless_multi_draw_indirect
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_bindless_multi_draw_indirect"))
            {
                if (GL.LinkProcGLEXT("glMultiDrawArraysIndirectBindlessNV"))
                {
                    GL.glMultiDrawArraysIndirectBindlessNV = (TglMultiDrawArraysIndirectBindlessNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawArraysIndirectBindlessNV));
                }

                if (GL.LinkProcGLEXT("glMultiDrawElementsIndirectBindlessNV"))
                {
                    GL.glMultiDrawElementsIndirectBindlessNV = (TglMultiDrawElementsIndirectBindlessNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawElementsIndirectBindlessNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_blend_equation_advanced
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_blend_equation_advanced"))
            {
                if (GL.LinkProcGLEXT("glBlendParameteriNV"))
                {
                    GL.glBlendParameteriNV = (TglBlendParameteriNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendParameteriNV));
                }

                if (GL.LinkProcGLEXT("glBlendBarrierNV"))
                {
                    GL.glBlendBarrierNV = (TglBlendBarrierNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendBarrierNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_blend_equation_advanced_coherent (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_blend_equation_advanced_coherent"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_compute_program5 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_compute_program5"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_deep_texture3D (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_deep_texture3D"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_draw_texture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_draw_texture"))
            {
                if (GL.LinkProcGLEXT("glDrawTextureNV"))
                {
                    GL.glDrawTextureNV = (TglDrawTextureNV)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawTextureNV));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NV_gpu_program_fp64 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NV_gpu_program_fp64"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_NVX_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_NVX_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_NVX_gpu_memory_info (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NVX_gpu_memory_info"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_NVX_conditional_render
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_NVX_conditional_render"))
            {
                if (GL.LinkProcGLEXT("glBeginConditionalRenderNVX"))
                {
                    GL.glBeginConditionalRenderNVX = (TglBeginConditionalRenderNVX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginConditionalRenderNVX));
                }

                if (GL.LinkProcGLEXT("glEndConditionalRenderNVX"))
                {
                    GL.glEndConditionalRenderNVX = (TglEndConditionalRenderNVX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndConditionalRenderNVX));
                }
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_OES_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_OES_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_OES_compressed_paletted_texture (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_OES_compressed_paletted_texture"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_OES_read_format (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_OES_read_format"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_OES_query_matrix
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_OES_query_matrix"))
            {
                if (GL.LinkProcGLEXT("glQueryMatrixxOES"))
                {
                    GL.glQueryMatrixxOES = (TglQueryMatrixxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglQueryMatrixxOES));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_OES_single_precision
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_OES_single_precision"))
            {
                if (GL.LinkProcGLEXT("glClearDepthfOES"))
                {
                    GL.glClearDepthfOES = (TglClearDepthfOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearDepthfOES));
                }

                if (GL.LinkProcGLEXT("glClipPlanefOES"))
                {
                    GL.glClipPlanefOES = (TglClipPlanefOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClipPlanefOES));
                }

                if (GL.LinkProcGLEXT("glDepthRangefOES"))
                {
                    GL.glDepthRangefOES = (TglDepthRangefOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthRangefOES));
                }

                if (GL.LinkProcGLEXT("glFrustumfOES"))
                {
                    GL.glFrustumfOES = (TglFrustumfOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFrustumfOES));
                }

                if (GL.LinkProcGLEXT("glGetClipPlanefOES"))
                {
                    GL.glGetClipPlanefOES = (TglGetClipPlanefOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetClipPlanefOES));
                }

                if (GL.LinkProcGLEXT("glOrthofOES"))
                {
                    GL.glOrthofOES = (TglOrthofOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglOrthofOES));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_OES_byte_coordinates
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_OES_byte_coordinates"))
            {
                if (GL.LinkProcGLEXT("glMultiTexCoord1bOES"))
                {
                    GL.glMultiTexCoord1bOES = (TglMultiTexCoord1bOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1bOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord1bvOES"))
                {
                    GL.glMultiTexCoord1bvOES = (TglMultiTexCoord1bvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1bvOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2bOES"))
                {
                    GL.glMultiTexCoord2bOES = (TglMultiTexCoord2bOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2bOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2bvOES"))
                {
                    GL.glMultiTexCoord2bvOES = (TglMultiTexCoord2bvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2bvOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3bOES"))
                {
                    GL.glMultiTexCoord3bOES = (TglMultiTexCoord3bOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3bOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3bvOES"))
                {
                    GL.glMultiTexCoord3bvOES = (TglMultiTexCoord3bvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3bvOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4bOES"))
                {
                    GL.glMultiTexCoord4bOES = (TglMultiTexCoord4bOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4bOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4bvOES"))
                {
                    GL.glMultiTexCoord4bvOES = (TglMultiTexCoord4bvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4bvOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord1bOES"))
                {
                    GL.glTexCoord1bOES = (TglTexCoord1bOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1bOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord1bvOES"))
                {
                    GL.glTexCoord1bvOES = (TglTexCoord1bvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1bvOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord2bOES"))
                {
                    GL.glTexCoord2bOES = (TglTexCoord2bOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2bOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord2bvOES"))
                {
                    GL.glTexCoord2bvOES = (TglTexCoord2bvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2bvOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord3bOES"))
                {
                    GL.glTexCoord3bOES = (TglTexCoord3bOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3bOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord3bvOES"))
                {
                    GL.glTexCoord3bvOES = (TglTexCoord3bvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3bvOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord4bOES"))
                {
                    GL.glTexCoord4bOES = (TglTexCoord4bOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4bOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord4bvOES"))
                {
                    GL.glTexCoord4bvOES = (TglTexCoord4bvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4bvOES));
                }

                if (GL.LinkProcGLEXT("glVertex2bOES"))
                {
                    GL.glVertex2bOES = (TglVertex2bOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2bOES));
                }

                if (GL.LinkProcGLEXT("glVertex2bvOES"))
                {
                    GL.glVertex2bvOES = (TglVertex2bvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2bvOES));
                }

                if (GL.LinkProcGLEXT("glVertex3bOES"))
                {
                    GL.glVertex3bOES = (TglVertex3bOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3bOES));
                }

                if (GL.LinkProcGLEXT("glVertex3bvOES"))
                {
                    GL.glVertex3bvOES = (TglVertex3bvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3bvOES));
                }

                if (GL.LinkProcGLEXT("glVertex4bOES"))
                {
                    GL.glVertex4bOES = (TglVertex4bOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4bOES));
                }

                if (GL.LinkProcGLEXT("glVertex4bvOES"))
                {
                    GL.glVertex4bvOES = (TglVertex4bvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4bvOES));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_OES_fixed_point
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_OES_fixed_point"))
            {
                if (GL.LinkProcGLEXT("glAlphaFuncxOES"))
                {
                    GL.glAlphaFuncxOES = (TglAlphaFuncxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAlphaFuncxOES));
                }

                if (GL.LinkProcGLEXT("glClearColorxOES"))
                {
                    GL.glClearColorxOES = (TglClearColorxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearColorxOES));
                }

                if (GL.LinkProcGLEXT("glClearDepthxOES"))
                {
                    GL.glClearDepthxOES = (TglClearDepthxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearDepthxOES));
                }

                if (GL.LinkProcGLEXT("glClipPlanexOES"))
                {
                    GL.glClipPlanexOES = (TglClipPlanexOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClipPlanexOES));
                }

                if (GL.LinkProcGLEXT("glColor4xOES"))
                {
                    GL.glColor4xOES = (TglColor4xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4xOES));
                }

                if (GL.LinkProcGLEXT("glDepthRangexOES"))
                {
                    GL.glDepthRangexOES = (TglDepthRangexOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthRangexOES));
                }

                if (GL.LinkProcGLEXT("glFogxOES"))
                {
                    GL.glFogxOES = (TglFogxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogxOES));
                }

                if (GL.LinkProcGLEXT("glFogxvOES"))
                {
                    GL.glFogxvOES = (TglFogxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogxvOES));
                }

                if (GL.LinkProcGLEXT("glFrustumxOES"))
                {
                    GL.glFrustumxOES = (TglFrustumxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFrustumxOES));
                }

                if (GL.LinkProcGLEXT("glGetClipPlanexOES"))
                {
                    GL.glGetClipPlanexOES = (TglGetClipPlanexOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetClipPlanexOES));
                }

                if (GL.LinkProcGLEXT("glGetFixedvOES"))
                {
                    GL.glGetFixedvOES = (TglGetFixedvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFixedvOES));
                }

                if (GL.LinkProcGLEXT("glGetTexEnvxvOES"))
                {
                    GL.glGetTexEnvxvOES = (TglGetTexEnvxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexEnvxvOES));
                }

                if (GL.LinkProcGLEXT("glGetTexParameterxvOES"))
                {
                    GL.glGetTexParameterxvOES = (TglGetTexParameterxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexParameterxvOES));
                }

                if (GL.LinkProcGLEXT("glLightModelxOES"))
                {
                    GL.glLightModelxOES = (TglLightModelxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLightModelxOES));
                }

                if (GL.LinkProcGLEXT("glLightModelxvOES"))
                {
                    GL.glLightModelxvOES = (TglLightModelxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLightModelxvOES));
                }

                if (GL.LinkProcGLEXT("glLightxOES"))
                {
                    GL.glLightxOES = (TglLightxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLightxOES));
                }

                if (GL.LinkProcGLEXT("glLightxvOES"))
                {
                    GL.glLightxvOES = (TglLightxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLightxvOES));
                }

                if (GL.LinkProcGLEXT("glLineWidthxOES"))
                {
                    GL.glLineWidthxOES = (TglLineWidthxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLineWidthxOES));
                }

                if (GL.LinkProcGLEXT("glLoadMatrixxOES"))
                {
                    GL.glLoadMatrixxOES = (TglLoadMatrixxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLoadMatrixxOES));
                }

                if (GL.LinkProcGLEXT("glMaterialxOES"))
                {
                    GL.glMaterialxOES = (TglMaterialxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMaterialxOES));
                }

                if (GL.LinkProcGLEXT("glMaterialxvOES"))
                {
                    GL.glMaterialxvOES = (TglMaterialxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMaterialxvOES));
                }

                if (GL.LinkProcGLEXT("glMultMatrixxOES"))
                {
                    GL.glMultMatrixxOES = (TglMultMatrixxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultMatrixxOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4xOES"))
                {
                    GL.glMultiTexCoord4xOES = (TglMultiTexCoord4xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4xOES));
                }

                if (GL.LinkProcGLEXT("glNormal3xOES"))
                {
                    GL.glNormal3xOES = (TglNormal3xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3xOES));
                }

                if (GL.LinkProcGLEXT("glOrthoxOES"))
                {
                    GL.glOrthoxOES = (TglOrthoxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglOrthoxOES));
                }

                if (GL.LinkProcGLEXT("glPointParameterxvOES"))
                {
                    GL.glPointParameterxvOES = (TglPointParameterxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointParameterxvOES));
                }

                if (GL.LinkProcGLEXT("glPointSizexOES"))
                {
                    GL.glPointSizexOES = (TglPointSizexOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointSizexOES));
                }

                if (GL.LinkProcGLEXT("glPolygonOffsetxOES"))
                {
                    GL.glPolygonOffsetxOES = (TglPolygonOffsetxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPolygonOffsetxOES));
                }

                if (GL.LinkProcGLEXT("glRotatexOES"))
                {
                    GL.glRotatexOES = (TglRotatexOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRotatexOES));
                }

                if (GL.LinkProcGLEXT("glSampleCoverageOES"))
                {
                    GL.glSampleCoverageOES = (TglSampleCoverageOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSampleCoverageOES));
                }

                if (GL.LinkProcGLEXT("glScalexOES"))
                {
                    GL.glScalexOES = (TglScalexOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglScalexOES));
                }

                if (GL.LinkProcGLEXT("glTexEnvxOES"))
                {
                    GL.glTexEnvxOES = (TglTexEnvxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexEnvxOES));
                }

                if (GL.LinkProcGLEXT("glTexEnvxvOES"))
                {
                    GL.glTexEnvxvOES = (TglTexEnvxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexEnvxvOES));
                }

                if (GL.LinkProcGLEXT("glTexParameterxOES"))
                {
                    GL.glTexParameterxOES = (TglTexParameterxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexParameterxOES));
                }

                if (GL.LinkProcGLEXT("glTexParameterxvOES"))
                {
                    GL.glTexParameterxvOES = (TglTexParameterxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexParameterxvOES));
                }

                if (GL.LinkProcGLEXT("glTranslatexOES"))
                {
                    GL.glTranslatexOES = (TglTranslatexOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTranslatexOES));
                }

                if (GL.LinkProcGLEXT("glAccumxOES"))
                {
                    GL.glAccumxOES = (TglAccumxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAccumxOES));
                }

                if (GL.LinkProcGLEXT("glBitmapxOES"))
                {
                    GL.glBitmapxOES = (TglBitmapxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBitmapxOES));
                }

                if (GL.LinkProcGLEXT("glBlendColorxOES"))
                {
                    GL.glBlendColorxOES = (TglBlendColorxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendColorxOES));
                }

                if (GL.LinkProcGLEXT("glClearAccumxOES"))
                {
                    GL.glClearAccumxOES = (TglClearAccumxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearAccumxOES));
                }

                if (GL.LinkProcGLEXT("glColor3xOES"))
                {
                    GL.glColor3xOES = (TglColor3xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3xOES));
                }

                if (GL.LinkProcGLEXT("glColor3xvOES"))
                {
                    GL.glColor3xvOES = (TglColor3xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3xvOES));
                }

                if (GL.LinkProcGLEXT("glColor4xvOES"))
                {
                    GL.glColor4xvOES = (TglColor4xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4xvOES));
                }

                if (GL.LinkProcGLEXT("glConvolutionParameterxOES"))
                {
                    GL.glConvolutionParameterxOES = (TglConvolutionParameterxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameterxOES));
                }

                if (GL.LinkProcGLEXT("glConvolutionParameterxvOES"))
                {
                    GL.glConvolutionParameterxvOES = (TglConvolutionParameterxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameterxvOES));
                }

                if (GL.LinkProcGLEXT("glEvalCoord1xOES"))
                {
                    GL.glEvalCoord1xOES = (TglEvalCoord1xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalCoord1xOES));
                }

                if (GL.LinkProcGLEXT("glEvalCoord1xvOES"))
                {
                    GL.glEvalCoord1xvOES = (TglEvalCoord1xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalCoord1xvOES));
                }

                if (GL.LinkProcGLEXT("glEvalCoord2xOES"))
                {
                    GL.glEvalCoord2xOES = (TglEvalCoord2xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalCoord2xOES));
                }

                if (GL.LinkProcGLEXT("glEvalCoord2xvOES"))
                {
                    GL.glEvalCoord2xvOES = (TglEvalCoord2xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalCoord2xvOES));
                }

                if (GL.LinkProcGLEXT("glFeedbackBufferxOES"))
                {
                    GL.glFeedbackBufferxOES = (TglFeedbackBufferxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFeedbackBufferxOES));
                }

                if (GL.LinkProcGLEXT("glGetConvolutionParameterxvOES"))
                {
                    GL.glGetConvolutionParameterxvOES = (TglGetConvolutionParameterxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetConvolutionParameterxvOES));
                }

                if (GL.LinkProcGLEXT("glGetHistogramParameterxvOES"))
                {
                    GL.glGetHistogramParameterxvOES = (TglGetHistogramParameterxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetHistogramParameterxvOES));
                }

                if (GL.LinkProcGLEXT("glGetLightxOES"))
                {
                    GL.glGetLightxOES = (TglGetLightxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetLightxOES));
                }

                if (GL.LinkProcGLEXT("glGetMapxvOES"))
                {
                    GL.glGetMapxvOES = (TglGetMapxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMapxvOES));
                }

                if (GL.LinkProcGLEXT("glGetMaterialxOES"))
                {
                    GL.glGetMaterialxOES = (TglGetMaterialxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMaterialxOES));
                }

                if (GL.LinkProcGLEXT("glGetPixelMapxv"))
                {
                    GL.glGetPixelMapxv = (TglGetPixelMapxv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPixelMapxv));
                }

                if (GL.LinkProcGLEXT("glGetTexGenxvOES"))
                {
                    GL.glGetTexGenxvOES = (TglGetTexGenxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexGenxvOES));
                }

                if (GL.LinkProcGLEXT("glGetTexLevelParameterxvOES"))
                {
                    GL.glGetTexLevelParameterxvOES = (TglGetTexLevelParameterxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexLevelParameterxvOES));
                }

                if (GL.LinkProcGLEXT("glIndexxOES"))
                {
                    GL.glIndexxOES = (TglIndexxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexxOES));
                }

                if (GL.LinkProcGLEXT("glIndexxvOES"))
                {
                    GL.glIndexxvOES = (TglIndexxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexxvOES));
                }

                if (GL.LinkProcGLEXT("glLoadTransposeMatrixxOES"))
                {
                    GL.glLoadTransposeMatrixxOES = (TglLoadTransposeMatrixxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLoadTransposeMatrixxOES));
                }

                if (GL.LinkProcGLEXT("glMap1xOES"))
                {
                    GL.glMap1xOES = (TglMap1xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMap1xOES));
                }

                if (GL.LinkProcGLEXT("glMap2xOES"))
                {
                    GL.glMap2xOES = (TglMap2xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMap2xOES));
                }

                if (GL.LinkProcGLEXT("glMapGrid1xOES"))
                {
                    GL.glMapGrid1xOES = (TglMapGrid1xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapGrid1xOES));
                }

                if (GL.LinkProcGLEXT("glMapGrid2xOES"))
                {
                    GL.glMapGrid2xOES = (TglMapGrid2xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapGrid2xOES));
                }

                if (GL.LinkProcGLEXT("glMultTransposeMatrixxOES"))
                {
                    GL.glMultTransposeMatrixxOES = (TglMultTransposeMatrixxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultTransposeMatrixxOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord1xOES"))
                {
                    GL.glMultiTexCoord1xOES = (TglMultiTexCoord1xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1xOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord1xvOES"))
                {
                    GL.glMultiTexCoord1xvOES = (TglMultiTexCoord1xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1xvOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2xOES"))
                {
                    GL.glMultiTexCoord2xOES = (TglMultiTexCoord2xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2xOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord2xvOES"))
                {
                    GL.glMultiTexCoord2xvOES = (TglMultiTexCoord2xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2xvOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3xOES"))
                {
                    GL.glMultiTexCoord3xOES = (TglMultiTexCoord3xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3xOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord3xvOES"))
                {
                    GL.glMultiTexCoord3xvOES = (TglMultiTexCoord3xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3xvOES));
                }

                if (GL.LinkProcGLEXT("glMultiTexCoord4xvOES"))
                {
                    GL.glMultiTexCoord4xvOES = (TglMultiTexCoord4xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4xvOES));
                }

                if (GL.LinkProcGLEXT("glNormal3xvOES"))
                {
                    GL.glNormal3xvOES = (TglNormal3xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3xvOES));
                }

                if (GL.LinkProcGLEXT("glPassThroughxOES"))
                {
                    GL.glPassThroughxOES = (TglPassThroughxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPassThroughxOES));
                }

                if (GL.LinkProcGLEXT("glPixelMapx"))
                {
                    GL.glPixelMapx = (TglPixelMapx)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelMapx));
                }

                if (GL.LinkProcGLEXT("glPixelStorex"))
                {
                    GL.glPixelStorex = (TglPixelStorex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelStorex));
                }

                if (GL.LinkProcGLEXT("glPixelTransferxOES"))
                {
                    GL.glPixelTransferxOES = (TglPixelTransferxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelTransferxOES));
                }

                if (GL.LinkProcGLEXT("glPixelZoomxOES"))
                {
                    GL.glPixelZoomxOES = (TglPixelZoomxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelZoomxOES));
                }

                if (GL.LinkProcGLEXT("glPrioritizeTexturesxOES"))
                {
                    GL.glPrioritizeTexturesxOES = (TglPrioritizeTexturesxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPrioritizeTexturesxOES));
                }

                if (GL.LinkProcGLEXT("glRasterPos2xOES"))
                {
                    GL.glRasterPos2xOES = (TglRasterPos2xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos2xOES));
                }

                if (GL.LinkProcGLEXT("glRasterPos2xvOES"))
                {
                    GL.glRasterPos2xvOES = (TglRasterPos2xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos2xvOES));
                }

                if (GL.LinkProcGLEXT("glRasterPos3xOES"))
                {
                    GL.glRasterPos3xOES = (TglRasterPos3xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos3xOES));
                }

                if (GL.LinkProcGLEXT("glRasterPos3xvOES"))
                {
                    GL.glRasterPos3xvOES = (TglRasterPos3xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos3xvOES));
                }

                if (GL.LinkProcGLEXT("glRasterPos4xOES"))
                {
                    GL.glRasterPos4xOES = (TglRasterPos4xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos4xOES));
                }

                if (GL.LinkProcGLEXT("glRasterPos4xvOES"))
                {
                    GL.glRasterPos4xvOES = (TglRasterPos4xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos4xvOES));
                }

                if (GL.LinkProcGLEXT("glRectxOES"))
                {
                    GL.glRectxOES = (TglRectxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRectxOES));
                }

                if (GL.LinkProcGLEXT("glRectxvOES"))
                {
                    GL.glRectxvOES = (TglRectxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRectxvOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord1xOES"))
                {
                    GL.glTexCoord1xOES = (TglTexCoord1xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1xOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord1xvOES"))
                {
                    GL.glTexCoord1xvOES = (TglTexCoord1xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1xvOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord2xOES"))
                {
                    GL.glTexCoord2xOES = (TglTexCoord2xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2xOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord2xvOES"))
                {
                    GL.glTexCoord2xvOES = (TglTexCoord2xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2xvOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord3xOES"))
                {
                    GL.glTexCoord3xOES = (TglTexCoord3xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3xOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord3xvOES"))
                {
                    GL.glTexCoord3xvOES = (TglTexCoord3xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3xvOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord4xOES"))
                {
                    GL.glTexCoord4xOES = (TglTexCoord4xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4xOES));
                }

                if (GL.LinkProcGLEXT("glTexCoord4xvOES"))
                {
                    GL.glTexCoord4xvOES = (TglTexCoord4xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4xvOES));
                }

                if (GL.LinkProcGLEXT("glTexGenxOES"))
                {
                    GL.glTexGenxOES = (TglTexGenxOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexGenxOES));
                }

                if (GL.LinkProcGLEXT("glTexGenxvOES"))
                {
                    GL.glTexGenxvOES = (TglTexGenxvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexGenxvOES));
                }

                if (GL.LinkProcGLEXT("glVertex2xOES"))
                {
                    GL.glVertex2xOES = (TglVertex2xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2xOES));
                }

                if (GL.LinkProcGLEXT("glVertex2xvOES"))
                {
                    GL.glVertex2xvOES = (TglVertex2xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2xvOES));
                }

                if (GL.LinkProcGLEXT("glVertex3xOES"))
                {
                    GL.glVertex3xOES = (TglVertex3xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3xOES));
                }

                if (GL.LinkProcGLEXT("glVertex3xvOES"))
                {
                    GL.glVertex3xvOES = (TglVertex3xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3xvOES));
                }

                if (GL.LinkProcGLEXT("glVertex4xOES"))
                {
                    GL.glVertex4xOES = (TglVertex4xOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4xOES));
                }

                if (GL.LinkProcGLEXT("glVertex4xvOES"))
                {
                    GL.glVertex4xvOES = (TglVertex4xvOES)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4xvOES));
                }
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_OML_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_OML_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_OML_interlace (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_OML_interlace"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_OML_subsample (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_OML_subsample"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_OML_resample (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_OML_resample"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_PGI_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_PGI_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_PGI_vertex_hints (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_PGI_vertex_hints"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_PGI_misc_hints
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_PGI_misc_hints"))
            {
                if (GL.LinkProcGLEXT("glHintPGI"))
                {
                    GL.glHintPGI = (TglHintPGI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglHintPGI));
                }
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_REND_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_REND_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_REND_screen_coordinates (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_REND_screen_coordinates"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_S3_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_S3_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_S3_s3tc (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_S3_s3tc"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_SGI_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_SGI_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_SGI_color_matrix (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGI_color_matrix"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGI_color_table
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGI_color_table"))
            {
                if (GL.LinkProcGLEXT("glColorTableSGI"))
                {
                    GL.glColorTableSGI = (TglColorTableSGI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorTableSGI));
                }

                if (GL.LinkProcGLEXT("glColorTableParameterfvSGI"))
                {
                    GL.glColorTableParameterfvSGI = (TglColorTableParameterfvSGI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorTableParameterfvSGI));
                }

                if (GL.LinkProcGLEXT("glColorTableParameterivSGI"))
                {
                    GL.glColorTableParameterivSGI = (TglColorTableParameterivSGI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorTableParameterivSGI));
                }

                if (GL.LinkProcGLEXT("glCopyColorTableSGI"))
                {
                    GL.glCopyColorTableSGI = (TglCopyColorTableSGI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyColorTableSGI));
                }

                if (GL.LinkProcGLEXT("glGetColorTableSGI"))
                {
                    GL.glGetColorTableSGI = (TglGetColorTableSGI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetColorTableSGI));
                }

                if (GL.LinkProcGLEXT("glGetColorTableParameterfvSGI"))
                {
                    GL.glGetColorTableParameterfvSGI = (TglGetColorTableParameterfvSGI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetColorTableParameterfvSGI));
                }

                if (GL.LinkProcGLEXT("glGetColorTableParameterivSGI"))
                {
                    GL.glGetColorTableParameterivSGI = (TglGetColorTableParameterivSGI)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetColorTableParameterivSGI));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGI_depth_pass_instrument (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGI_depth_pass_instrument"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGI_texture_color_table (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGI_texture_color_table"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_SGIS_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_texture_filter4
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_texture_filter4"))
            {
                if (GL.LinkProcGLEXT("glGetTexFilterFuncSGIS"))
                {
                    GL.glGetTexFilterFuncSGIS = (TglGetTexFilterFuncSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexFilterFuncSGIS));
                }

                if (GL.LinkProcGLEXT("glTexFilterFuncSGIS"))
                {
                    GL.glTexFilterFuncSGIS = (TglTexFilterFuncSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexFilterFuncSGIS));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_pixel_texture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_pixel_texture"))
            {
                if (GL.LinkProcGLEXT("glPixelTexGenParameteriSGIS"))
                {
                    GL.glPixelTexGenParameteriSGIS = (TglPixelTexGenParameteriSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelTexGenParameteriSGIS));
                }

                if (GL.LinkProcGLEXT("glPixelTexGenParameterivSGIS"))
                {
                    GL.glPixelTexGenParameterivSGIS = (TglPixelTexGenParameterivSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelTexGenParameterivSGIS));
                }

                if (GL.LinkProcGLEXT("glPixelTexGenParameterfSGIS"))
                {
                    GL.glPixelTexGenParameterfSGIS = (TglPixelTexGenParameterfSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelTexGenParameterfSGIS));
                }

                if (GL.LinkProcGLEXT("glPixelTexGenParameterfvSGIS"))
                {
                    GL.glPixelTexGenParameterfvSGIS = (TglPixelTexGenParameterfvSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelTexGenParameterfvSGIS));
                }

                if (GL.LinkProcGLEXT("glGetPixelTexGenParameterivSGIS"))
                {
                    GL.glGetPixelTexGenParameterivSGIS = (TglGetPixelTexGenParameterivSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPixelTexGenParameterivSGIS));
                }

                if (GL.LinkProcGLEXT("glGetPixelTexGenParameterfvSGIS"))
                {
                    GL.glGetPixelTexGenParameterfvSGIS = (TglGetPixelTexGenParameterfvSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPixelTexGenParameterfvSGIS));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_texture4D
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_texture4D"))
            {
                if (GL.LinkProcGLEXT("glTexImage4DSGIS"))
                {
                    GL.glTexImage4DSGIS = (TglTexImage4DSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexImage4DSGIS));
                }

                if (GL.LinkProcGLEXT("glTexSubImage4DSGIS"))
                {
                    GL.glTexSubImage4DSGIS = (TglTexSubImage4DSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexSubImage4DSGIS));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_detail_texture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_detail_texture"))
            {
                if (GL.LinkProcGLEXT("glDetailTexFuncSGIS"))
                {
                    GL.glDetailTexFuncSGIS = (TglDetailTexFuncSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDetailTexFuncSGIS));
                }

                if (GL.LinkProcGLEXT("glGetDetailTexFuncSGIS"))
                {
                    GL.glGetDetailTexFuncSGIS = (TglGetDetailTexFuncSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetDetailTexFuncSGIS));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_sharpen_texture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_sharpen_texture"))
            {
                if (GL.LinkProcGLEXT("glSharpenTexFuncSGIS"))
                {
                    GL.glSharpenTexFuncSGIS = (TglSharpenTexFuncSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSharpenTexFuncSGIS));
                }

                if (GL.LinkProcGLEXT("glGetSharpenTexFuncSGIS"))
                {
                    GL.glGetSharpenTexFuncSGIS = (TglGetSharpenTexFuncSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSharpenTexFuncSGIS));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_texture_lod (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_texture_lod"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_texture_select (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_texture_select"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_multisample
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_multisample"))
            {
                if (GL.LinkProcGLEXT("glSampleMaskSGIS"))
                {
                    GL.glSampleMaskSGIS = (TglSampleMaskSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSampleMaskSGIS));
                }

                if (GL.LinkProcGLEXT("glSamplePatternSGIS"))
                {
                    GL.glSamplePatternSGIS = (TglSamplePatternSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplePatternSGIS));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_generate_mipmap (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_generate_mipmap"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_texture_edge_clamp (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_texture_edge_clamp"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_texture_border_clamp (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_texture_border_clamp"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_fog_function
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_fog_function"))
            {
                if (GL.LinkProcGLEXT("glFogFuncSGIS"))
                {
                    GL.glFogFuncSGIS = (TglFogFuncSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogFuncSGIS));
                }

                if (GL.LinkProcGLEXT("glGetFogFuncSGIS"))
                {
                    GL.glGetFogFuncSGIS = (TglGetFogFuncSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFogFuncSGIS));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_point_parameters
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_point_parameters"))
            {
                if (GL.LinkProcGLEXT("glPointParameterfSGIS"))
                {
                    GL.glPointParameterfSGIS = (TglPointParameterfSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointParameterfSGIS));
                }

                if (GL.LinkProcGLEXT("glPointParameterfvSGIS"))
                {
                    GL.glPointParameterfvSGIS = (TglPointParameterfvSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointParameterfvSGIS));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_point_line_texgen (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_point_line_texgen"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIS_texture_color_mask
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIS_texture_color_mask"))
            {
                if (GL.LinkProcGLEXT("glTextureColorMaskSGIS"))
                {
                    GL.glTextureColorMaskSGIS = (TglTextureColorMaskSGIS)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureColorMaskSGIS));
                }
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_SGIX_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_pixel_texture
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_pixel_texture"))
            {
                if (GL.LinkProcGLEXT("glPixelTexGenSGIX"))
                {
                    GL.glPixelTexGenSGIX = (TglPixelTexGenSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelTexGenSGIX));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_FfdMaskSGIX (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_FfdMaskSGIX"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_clipmap (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_clipmap"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_shadow (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_shadow"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_interlace (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_interlace"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_pixel_tiles (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_pixel_tiles"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_texture_select (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_texture_select"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_sprite
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_sprite"))
            {
                if (GL.LinkProcGLEXT("glSpriteParameterfSGIX"))
                {
                    GL.glSpriteParameterfSGIX = (TglSpriteParameterfSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSpriteParameterfSGIX));
                }

                if (GL.LinkProcGLEXT("glSpriteParameterfvSGIX"))
                {
                    GL.glSpriteParameterfvSGIX = (TglSpriteParameterfvSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSpriteParameterfvSGIX));
                }

                if (GL.LinkProcGLEXT("glSpriteParameteriSGIX"))
                {
                    GL.glSpriteParameteriSGIX = (TglSpriteParameteriSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSpriteParameteriSGIX));
                }

                if (GL.LinkProcGLEXT("glSpriteParameterivSGIX"))
                {
                    GL.glSpriteParameterivSGIX = (TglSpriteParameterivSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSpriteParameterivSGIX));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_texture_multi_buffer (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_texture_multi_buffer"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_instruments
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_instruments"))
            {
                if (GL.LinkProcGLEXT("glGetInstrumentsSGIX"))
                {
                    GL.glGetInstrumentsSGIX = (TglGetInstrumentsSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetInstrumentsSGIX));
                }

                if (GL.LinkProcGLEXT("glInstrumentsBufferSGIX"))
                {
                    GL.glInstrumentsBufferSGIX = (TglInstrumentsBufferSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInstrumentsBufferSGIX));
                }

                if (GL.LinkProcGLEXT("glPollInstrumentsSGIX"))
                {
                    GL.glPollInstrumentsSGIX = (TglPollInstrumentsSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPollInstrumentsSGIX));
                }

                if (GL.LinkProcGLEXT("glReadInstrumentsSGIX"))
                {
                    GL.glReadInstrumentsSGIX = (TglReadInstrumentsSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReadInstrumentsSGIX));
                }

                if (GL.LinkProcGLEXT("glStartInstrumentsSGIX"))
                {
                    GL.glStartInstrumentsSGIX = (TglStartInstrumentsSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStartInstrumentsSGIX));
                }

                if (GL.LinkProcGLEXT("glStopInstrumentsSGIX"))
                {
                    GL.glStopInstrumentsSGIX = (TglStopInstrumentsSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStopInstrumentsSGIX));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_texture_scale_bias
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_texture_scale_bias"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_framezoom
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_framezoom"))
            {
                if (GL.LinkProcGLEXT("glFrameZoomSGIX"))
                {
                    GL.glFrameZoomSGIX = (TglFrameZoomSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFrameZoomSGIX));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_tag_sample_buffer
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_tag_sample_buffer"))
            {
                if (GL.LinkProcGLEXT("glTagSampleBufferSGIX"))
                {
                    GL.glTagSampleBufferSGIX = (TglTagSampleBufferSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTagSampleBufferSGIX));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_polynomial_ffd
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_polynomial_ffd"))
            {
                if (GL.LinkProcGLEXT("glDeformationMap3dSGIX"))
                {
                    GL.glDeformationMap3dSGIX = (TglDeformationMap3dSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeformationMap3dSGIX));
                }

                if (GL.LinkProcGLEXT("glDeformationMap3fSGIX"))
                {
                    GL.glDeformationMap3fSGIX = (TglDeformationMap3fSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeformationMap3fSGIX));
                }

                if (GL.LinkProcGLEXT("glDeformSGIX"))
                {
                    GL.glDeformSGIX = (TglDeformSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeformSGIX));
                }

                if (GL.LinkProcGLEXT("glLoadIdentityDeformationMapSGIX"))
                {
                    GL.glLoadIdentityDeformationMapSGIX = (TglLoadIdentityDeformationMapSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLoadIdentityDeformationMapSGIX));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_reference_plane
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_reference_plane"))
            {
                if (GL.LinkProcGLEXT("glReferencePlaneSGIX"))
                {
                    GL.glReferencePlaneSGIX = (TglReferencePlaneSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReferencePlaneSGIX));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_flush_raster
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_flush_raster"))
            {
                if (GL.LinkProcGLEXT("glFlushRasterSGIX"))
                {
                    GL.glFlushRasterSGIX = (TglFlushRasterSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFlushRasterSGIX));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_depth_texture (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_depth_texture"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_fog_offset (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_fog_offset"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_texture_add_env (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_texture_add_env"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_list_priority
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_list_priority"))
            {
                if (GL.LinkProcGLEXT("glGetListParameterfvSGIX"))
                {
                    GL.glGetListParameterfvSGIX = (TglGetListParameterfvSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetListParameterfvSGIX));
                }

                if (GL.LinkProcGLEXT("glGetListParameterivSGIX"))
                {
                    GL.glGetListParameterivSGIX = (TglGetListParameterivSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetListParameterivSGIX));
                }

                if (GL.LinkProcGLEXT("glListParameterfSGIX"))
                {
                    GL.glListParameterfSGIX = (TglListParameterfSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglListParameterfSGIX));
                }

                if (GL.LinkProcGLEXT("glListParameterfvSGIX"))
                {
                    GL.glListParameterfvSGIX = (TglListParameterfvSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglListParameterfvSGIX));
                }

                if (GL.LinkProcGLEXT("glListParameteriSGIX"))
                {
                    GL.glListParameteriSGIX = (TglListParameteriSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglListParameteriSGIX));
                }

                if (GL.LinkProcGLEXT("glListParameterivSGIX"))
                {
                    GL.glListParameterivSGIX = (TglListParameterivSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglListParameterivSGIX));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_ir_instrument1 (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_ir_instrument1"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_calligraphic_fragment (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_calligraphic_fragment"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_texture_lod_bias (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_texture_lod_bias"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_shadow_ambient (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_shadow_ambient"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_ycrcb (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_ycrcb"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_fragment_lighting
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_fragment_lighting"))
            {
                if (GL.LinkProcGLEXT("glFragmentColorMaterialSGIX"))
                {
                    GL.glFragmentColorMaterialSGIX = (TglFragmentColorMaterialSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFragmentColorMaterialSGIX));
                }

                if (GL.LinkProcGLEXT("glFragmentLightfSGIX"))
                {
                    GL.glFragmentLightfSGIX = (TglFragmentLightfSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFragmentLightfSGIX));
                }

                if (GL.LinkProcGLEXT("glFragmentLightfvSGIX"))
                {
                    GL.glFragmentLightfvSGIX = (TglFragmentLightfvSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFragmentLightfvSGIX));
                }

                if (GL.LinkProcGLEXT("glFragmentLightiSGIX"))
                {
                    GL.glFragmentLightiSGIX = (TglFragmentLightiSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFragmentLightiSGIX));
                }

                if (GL.LinkProcGLEXT("glFragmentLightivSGIX"))
                {
                    GL.glFragmentLightivSGIX = (TglFragmentLightivSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFragmentLightivSGIX));
                }

                if (GL.LinkProcGLEXT("glFragmentLightModelfSGIX"))
                {
                    GL.glFragmentLightModelfSGIX = (TglFragmentLightModelfSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFragmentLightModelfSGIX));
                }

                if (GL.LinkProcGLEXT("glFragmentLightModelfvSGIX"))
                {
                    GL.glFragmentLightModelfvSGIX = (TglFragmentLightModelfvSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFragmentLightModelfvSGIX));
                }

                if (GL.LinkProcGLEXT("glFragmentLightModeliSGIX"))
                {
                    GL.glFragmentLightModeliSGIX = (TglFragmentLightModeliSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFragmentLightModeliSGIX));
                }

                if (GL.LinkProcGLEXT("glFragmentLightModelivSGIX"))
                {
                    GL.glFragmentLightModelivSGIX = (TglFragmentLightModelivSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFragmentLightModelivSGIX));
                }

                if (GL.LinkProcGLEXT("glFragmentMaterialfSGIX"))
                {
                    GL.glFragmentMaterialfSGIX = (TglFragmentMaterialfSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFragmentMaterialfSGIX));
                }

                if (GL.LinkProcGLEXT("glFragmentMaterialfvSGIX"))
                {
                    GL.glFragmentMaterialfvSGIX = (TglFragmentMaterialfvSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFragmentMaterialfvSGIX));
                }

                if (GL.LinkProcGLEXT("glFragmentMaterialiSGIX"))
                {
                    GL.glFragmentMaterialiSGIX = (TglFragmentMaterialiSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFragmentMaterialiSGIX));
                }

                if (GL.LinkProcGLEXT("glFragmentMaterialivSGIX"))
                {
                    GL.glFragmentMaterialivSGIX = (TglFragmentMaterialivSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFragmentMaterialivSGIX));
                }

                if (GL.LinkProcGLEXT("glGetFragmentLightfvSGIX"))
                {
                    GL.glGetFragmentLightfvSGIX = (TglGetFragmentLightfvSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFragmentLightfvSGIX));
                }

                if (GL.LinkProcGLEXT("glGetFragmentLightivSGIX"))
                {
                    GL.glGetFragmentLightivSGIX = (TglGetFragmentLightivSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFragmentLightivSGIX));
                }

                if (GL.LinkProcGLEXT("glGetFragmentMaterialfvSGIX"))
                {
                    GL.glGetFragmentMaterialfvSGIX = (TglGetFragmentMaterialfvSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFragmentMaterialfvSGIX));
                }

                if (GL.LinkProcGLEXT("glGetFragmentMaterialivSGIX"))
                {
                    GL.glGetFragmentMaterialivSGIX = (TglGetFragmentMaterialivSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFragmentMaterialivSGIX));
                }

                if (GL.LinkProcGLEXT("glLightEnviSGIX"))
                {
                    GL.glLightEnviSGIX = (TglLightEnviSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLightEnviSGIX));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_blend_alpha_minmax (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_blend_alpha_minmax"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_async
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_async"))
            {
                if (GL.LinkProcGLEXT("glAsyncMarkerSGIX"))
                {
                    GL.glAsyncMarkerSGIX = (TglAsyncMarkerSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAsyncMarkerSGIX));
                }

                if (GL.LinkProcGLEXT("glFinishAsyncSGIX"))
                {
                    GL.glFinishAsyncSGIX = (TglFinishAsyncSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFinishAsyncSGIX));
                }

                if (GL.LinkProcGLEXT("glPollAsyncSGIX"))
                {
                    GL.glPollAsyncSGIX = (TglPollAsyncSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPollAsyncSGIX));
                }

                if (GL.LinkProcGLEXT("glGenAsyncMarkersSGIX"))
                {
                    GL.glGenAsyncMarkersSGIX = (TglGenAsyncMarkersSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenAsyncMarkersSGIX));
                }

                if (GL.LinkProcGLEXT("glDeleteAsyncMarkersSGIX"))
                {
                    GL.glDeleteAsyncMarkersSGIX = (TglDeleteAsyncMarkersSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteAsyncMarkersSGIX));
                }

                if (GL.LinkProcGLEXT("glIsAsyncMarkerSGIX"))
                {
                    GL.glIsAsyncMarkerSGIX = (TglIsAsyncMarkerSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsAsyncMarkerSGIX));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_async_pixel (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_async_pixel"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_async_histogram (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_async_histogram"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_fog_scale (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_fog_scale"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_subsample (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_subsample"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_ycrcba (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_ycrcba"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_ycrcb_subsample (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_ycrcb_subsample"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_depth_pass_instrument (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_depth_pass_instrument"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_vertex_preclip (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_vertex_preclip"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_convolution_accuracy (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_convolution_accuracy"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_resample (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_resample"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_texture_coordinate_clamp (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_texture_coordinate_clamp"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_scalebias_hint (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_scalebias_hint"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SGIX_igloo_interface
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SGIX_igloo_interface"))
            {
                if (GL.LinkProcGLEXT("glIglooInterfaceSGIX"))
                {
                    GL.glIglooInterfaceSGIX = (TglIglooInterfaceSGIX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIglooInterfaceSGIX));
                }
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_SUN_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_SUN_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_SUN_multi_draw_arrays
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SUN_multi_draw_arrays"))
            {
                if (GL.LinkProcGLEXT("glMultiDrawArraysSUN"))
                {
                    GL.glMultiDrawArraysSUN = (TglMultiDrawArraysSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawArraysSUN));
                }

                if (GL.LinkProcGLEXT("glMultiDrawElementsSUN"))
                {
                    GL.glMultiDrawElementsSUN = (TglMultiDrawElementsSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawElementsSUN));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SUN_global_alpha
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SUN_global_alpha"))
            {
                if (GL.LinkProcGLEXT("glGlobalAlphaFactorbSUN"))
                {
                    GL.glGlobalAlphaFactorbSUN = (TglGlobalAlphaFactorbSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGlobalAlphaFactorbSUN));
                }

                if (GL.LinkProcGLEXT("glGlobalAlphaFactorsSUN"))
                {
                    GL.glGlobalAlphaFactorsSUN = (TglGlobalAlphaFactorsSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGlobalAlphaFactorsSUN));
                }

                if (GL.LinkProcGLEXT("glGlobalAlphaFactoriSUN"))
                {
                    GL.glGlobalAlphaFactoriSUN = (TglGlobalAlphaFactoriSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGlobalAlphaFactoriSUN));
                }

                if (GL.LinkProcGLEXT("glGlobalAlphaFactorfSUN"))
                {
                    GL.glGlobalAlphaFactorfSUN = (TglGlobalAlphaFactorfSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGlobalAlphaFactorfSUN));
                }

                if (GL.LinkProcGLEXT("glGlobalAlphaFactordSUN"))
                {
                    GL.glGlobalAlphaFactordSUN = (TglGlobalAlphaFactordSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGlobalAlphaFactordSUN));
                }

                if (GL.LinkProcGLEXT("glGlobalAlphaFactorubSUN"))
                {
                    GL.glGlobalAlphaFactorubSUN = (TglGlobalAlphaFactorubSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGlobalAlphaFactorubSUN));
                }

                if (GL.LinkProcGLEXT("glGlobalAlphaFactorusSUN"))
                {
                    GL.glGlobalAlphaFactorusSUN = (TglGlobalAlphaFactorusSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGlobalAlphaFactorusSUN));
                }

                if (GL.LinkProcGLEXT("glGlobalAlphaFactoruiSUN"))
                {
                    GL.glGlobalAlphaFactoruiSUN = (TglGlobalAlphaFactoruiSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGlobalAlphaFactoruiSUN));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SUN_triangle_list
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SUN_triangle_list"))
            {
                if (GL.LinkProcGLEXT("glReplacementCodeuiSUN"))
                {
                    GL.glReplacementCodeuiSUN = (TglReplacementCodeuiSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeusSUN"))
                {
                    GL.glReplacementCodeusSUN = (TglReplacementCodeusSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeusSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeubSUN"))
                {
                    GL.glReplacementCodeubSUN = (TglReplacementCodeubSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeubSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuivSUN"))
                {
                    GL.glReplacementCodeuivSUN = (TglReplacementCodeuivSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuivSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeusvSUN"))
                {
                    GL.glReplacementCodeusvSUN = (TglReplacementCodeusvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeusvSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeubvSUN"))
                {
                    GL.glReplacementCodeubvSUN = (TglReplacementCodeubvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeubvSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodePointerSUN"))
                {
                    GL.glReplacementCodePointerSUN = (TglReplacementCodePointerSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodePointerSUN));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SUN_vertex
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SUN_vertex"))
            {
                if (GL.LinkProcGLEXT("glColor4ubVertex2fSUN"))
                {
                    GL.glColor4ubVertex2fSUN = (TglColor4ubVertex2fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4ubVertex2fSUN));
                }

                if (GL.LinkProcGLEXT("glColor4ubVertex2fvSUN"))
                {
                    GL.glColor4ubVertex2fvSUN = (TglColor4ubVertex2fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4ubVertex2fvSUN));
                }

                if (GL.LinkProcGLEXT("glColor4ubVertex3fSUN"))
                {
                    GL.glColor4ubVertex3fSUN = (TglColor4ubVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4ubVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glColor4ubVertex3fvSUN"))
                {
                    GL.glColor4ubVertex3fvSUN = (TglColor4ubVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4ubVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glColor3fVertex3fSUN"))
                {
                    GL.glColor3fVertex3fSUN = (TglColor3fVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3fVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glColor3fVertex3fvSUN"))
                {
                    GL.glColor3fVertex3fvSUN = (TglColor3fVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3fVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glNormal3fVertex3fSUN"))
                {
                    GL.glNormal3fVertex3fSUN = (TglNormal3fVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3fVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glNormal3fVertex3fvSUN"))
                {
                    GL.glNormal3fVertex3fvSUN = (TglNormal3fVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3fVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glColor4fNormal3fVertex3fSUN"))
                {
                    GL.glColor4fNormal3fVertex3fSUN = (TglColor4fNormal3fVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4fNormal3fVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glColor4fNormal3fVertex3fvSUN"))
                {
                    GL.glColor4fNormal3fVertex3fvSUN = (TglColor4fNormal3fVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4fNormal3fVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord2fVertex3fSUN"))
                {
                    GL.glTexCoord2fVertex3fSUN = (TglTexCoord2fVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2fVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord2fVertex3fvSUN"))
                {
                    GL.glTexCoord2fVertex3fvSUN = (TglTexCoord2fVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2fVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord4fVertex4fSUN"))
                {
                    GL.glTexCoord4fVertex4fSUN = (TglTexCoord4fVertex4fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4fVertex4fSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord4fVertex4fvSUN"))
                {
                    GL.glTexCoord4fVertex4fvSUN = (TglTexCoord4fVertex4fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4fVertex4fvSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord2fColor4ubVertex3fSUN"))
                {
                    GL.glTexCoord2fColor4ubVertex3fSUN = (TglTexCoord2fColor4ubVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2fColor4ubVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord2fColor4ubVertex3fvSUN"))
                {
                    GL.glTexCoord2fColor4ubVertex3fvSUN = (TglTexCoord2fColor4ubVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2fColor4ubVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord2fColor3fVertex3fSUN"))
                {
                    GL.glTexCoord2fColor3fVertex3fSUN = (TglTexCoord2fColor3fVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2fColor3fVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord2fColor3fVertex3fvSUN"))
                {
                    GL.glTexCoord2fColor3fVertex3fvSUN = (TglTexCoord2fColor3fVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2fColor3fVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord2fNormal3fVertex3fSUN"))
                {
                    GL.glTexCoord2fNormal3fVertex3fSUN = (TglTexCoord2fNormal3fVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2fNormal3fVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord2fNormal3fVertex3fvSUN"))
                {
                    GL.glTexCoord2fNormal3fVertex3fvSUN = (TglTexCoord2fNormal3fVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2fNormal3fVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord2fColor4fNormal3fVertex3fSUN"))
                {
                    GL.glTexCoord2fColor4fNormal3fVertex3fSUN = (TglTexCoord2fColor4fNormal3fVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2fColor4fNormal3fVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord2fColor4fNormal3fVertex3fvSUN"))
                {
                    GL.glTexCoord2fColor4fNormal3fVertex3fvSUN = (TglTexCoord2fColor4fNormal3fVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2fColor4fNormal3fVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord4fColor4fNormal3fVertex4fSUN"))
                {
                    GL.glTexCoord4fColor4fNormal3fVertex4fSUN = (TglTexCoord4fColor4fNormal3fVertex4fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4fColor4fNormal3fVertex4fSUN));
                }

                if (GL.LinkProcGLEXT("glTexCoord4fColor4fNormal3fVertex4fvSUN"))
                {
                    GL.glTexCoord4fColor4fNormal3fVertex4fvSUN = (TglTexCoord4fColor4fNormal3fVertex4fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4fColor4fNormal3fVertex4fvSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiVertex3fSUN"))
                {
                    GL.glReplacementCodeuiVertex3fSUN = (TglReplacementCodeuiVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiVertex3fvSUN"))
                {
                    GL.glReplacementCodeuiVertex3fvSUN = (TglReplacementCodeuiVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiColor4ubVertex3fSUN"))
                {
                    GL.glReplacementCodeuiColor4ubVertex3fSUN = (TglReplacementCodeuiColor4ubVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiColor4ubVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiColor4ubVertex3fvSUN"))
                {
                    GL.glReplacementCodeuiColor4ubVertex3fvSUN = (TglReplacementCodeuiColor4ubVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiColor4ubVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiColor3fVertex3fSUN"))
                {
                    GL.glReplacementCodeuiColor3fVertex3fSUN = (TglReplacementCodeuiColor3fVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiColor3fVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiColor3fVertex3fvSUN"))
                {
                    GL.glReplacementCodeuiColor3fVertex3fvSUN = (TglReplacementCodeuiColor3fVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiColor3fVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiNormal3fVertex3fSUN"))
                {
                    GL.glReplacementCodeuiNormal3fVertex3fSUN = (TglReplacementCodeuiNormal3fVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiNormal3fVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiNormal3fVertex3fvSUN"))
                {
                    GL.glReplacementCodeuiNormal3fVertex3fvSUN = (TglReplacementCodeuiNormal3fVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiNormal3fVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiColor4fNormal3fVertex3fSUN"))
                {
                    GL.glReplacementCodeuiColor4fNormal3fVertex3fSUN = (TglReplacementCodeuiColor4fNormal3fVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiColor4fNormal3fVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiColor4fNormal3fVertex3fvSUN"))
                {
                    GL.glReplacementCodeuiColor4fNormal3fVertex3fvSUN = (TglReplacementCodeuiColor4fNormal3fVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiColor4fNormal3fVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiTexCoord2fVertex3fSUN"))
                {
                    GL.glReplacementCodeuiTexCoord2fVertex3fSUN = (TglReplacementCodeuiTexCoord2fVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiTexCoord2fVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiTexCoord2fVertex3fvSUN"))
                {
                    GL.glReplacementCodeuiTexCoord2fVertex3fvSUN = (TglReplacementCodeuiTexCoord2fVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiTexCoord2fVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN"))
                {
                    GL.glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN = (TglReplacementCodeuiTexCoord2fNormal3fVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiTexCoord2fNormal3fVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN"))
                {
                    GL.glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN = (TglReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN"))
                {
                    GL.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN = (TglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN));
                }

                if (GL.LinkProcGLEXT("glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN"))
                {
                    GL.glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN = (TglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SUN_convolution_border_modes (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SUN_convolution_border_modes"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SUN_mesh_array
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SUN_mesh_array"))
            {
                if (GL.LinkProcGLEXT("glDrawMeshArraysSUN"))
                {
                    GL.glDrawMeshArraysSUN = (TglDrawMeshArraysSUN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawMeshArraysSUN));
                }
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_SUN_slice_accum (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SUN_slice_accum"))
            {
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_SUNX_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_SUNX_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_SUNX_constant_data
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_SUNX_constant_data"))
            {
                if (GL.LinkProcGLEXT("glFinishTextureSUNX"))
                {
                    GL.glFinishTextureSUNX = (TglFinishTextureSUNX)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFinishTextureSUNX));
                }
            }

            #endregion

            ///////////////////////////////////////////////////////////////////////
            // GL_WIN_xxx FUNCTIONS
            ///////////////////////////////////////////////////////////////////////
            #region GL_WIN_xxx FUNCTIONS...
            ///////////////////////////////////////////////////////////////////////
            // GL_WIN_phong_shading (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_WIN_phong_shading"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_WIN_specular_fog (no function entry points)
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_WIN_specular_fog"))
            {
            }

            ///////////////////////////////////////////////////////////////////////
            // GL_WIN_swap_hint
            ///////////////////////////////////////////////////////////////////////
            if (GL.LinkGLEXT("GL_WIN_swap_hint"))
            {
                if (GL.LinkProcGLEXT("glAddSwapHintRectWIN"))
                {
                    GL.glAddSwapHintRectWIN = (TglAddSwapHintRectWIN)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAddSwapHintRectWIN));
                }
            }

            #endregion
        }
    }
}
