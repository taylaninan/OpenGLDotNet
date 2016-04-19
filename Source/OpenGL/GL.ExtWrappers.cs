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
    public static partial class GL
    {
        ///////////////////////////////////////////////////////////////////////
        // OPENGL EXTENSION WRAPPERS
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_3DFX_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_3DFX_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_3DFX_texture_compression_FXT1 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_3DFX_multisample (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_3DFX_tbuffer
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTbufferMask3DFX (GLuint mask);
        public static void TbufferMask3DFX(GLuint mask)
        {
            if (glTbufferMask3DFX != null)
            {
                glTbufferMask3DFX(mask);
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_AMD_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_performance_monitor
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetPerfMonitorGroupsAMD (GLint *numGroups, GLsizei groupsSize, GLuint *groups);
        public unsafe static void GetPerfMonitorGroupsAMD(GLint[] numGroups, GLsizei groupsSize, GLuint[] groups)
        {
            if (glGetPerfMonitorGroupsAMD != null)
            {
                fixed (GLint* ptr_numGroups = numGroups)
                {
                    fixed (GLuint* ptr_groups = groups)
                    {
                        glGetPerfMonitorGroupsAMD(ptr_numGroups, groupsSize, ptr_groups);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetPerfMonitorCountersAMD (GLuint group, GLint *numCounters, GLint *maxActiveCounters, GLsizei counterSize, GLuint *counters);
        public unsafe static void GetPerfMonitorCountersAMD(GLuint group, GLint[] numCounters, GLint[] maxActiveCounters, GLsizei counterSize, GLuint[] counters)
        {
            if (glGetPerfMonitorCountersAMD != null)
            {
                fixed (GLint* ptr_numCounters = numCounters)
                {
                    fixed (GLint* ptr_maxActiveCounters = maxActiveCounters)
                    {
                        fixed (GLuint* ptr_c = counters)
                        {
                            glGetPerfMonitorCountersAMD(group, ptr_numCounters, ptr_maxActiveCounters, counterSize, ptr_c);
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetPerfMonitorGroupStringAMD (GLuint group, GLsizei bufSize, GLsizei *length, GLchar *groupString);
        public unsafe static void GetPerfMonitorGroupStringAMD(GLuint group, GLsizei bufSize, GLsizei[] length, GLchar[] groupString)
        {
            if (glGetPerfMonitorGroupStringAMD != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_groupString = groupString)
                    {
                        glGetPerfMonitorGroupStringAMD(group, bufSize, ptr_length, ptr_groupString);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetPerfMonitorCounterStringAMD (GLuint group, GLuint counter, GLsizei bufSize, GLsizei *length, GLchar *counterString);
        public unsafe static void GetPerfMonitorCounterStringAMD(GLuint group, GLuint counter, GLsizei bufSize, GLsizei[] length, GLchar[] counterString)
        {
            if (glGetPerfMonitorCounterStringAMD != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_counterString = counterString)
                    {
                        glGetPerfMonitorCounterStringAMD(group, counter, bufSize, ptr_length, ptr_counterString);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetPerfMonitorCounterInfoAMD (GLuint group, GLuint counter, GLenum pname, GLvoid *data);
        public unsafe static void GetPerfMonitorCounterInfoAMD(GLuint group, GLuint counter, GLenum pname, IntPtr data)
        {
            if (glGetPerfMonitorCounterInfoAMD != null)
            {
                glGetPerfMonitorCounterInfoAMD(group, counter, pname, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGenPerfMonitorsAMD (GLsizei n, GLuint *monitors);
        public unsafe static void GenPerfMonitorsAMD(GLsizei n, GLuint[] monitors)
        {
            if (glGenPerfMonitorsAMD != null)
            {
                fixed (GLuint* ptr_monitors = monitors)
                {
                    glGenPerfMonitorsAMD(n, ptr_monitors);
                }
            }
        }

        // GLAPI void APIENTRY glDeletePerfMonitorsAMD (GLsizei n, GLuint *monitors);
        public unsafe static void DeletePerfMonitorsAMD(GLsizei n, GLuint[] monitors)
        {
            if (glDeletePerfMonitorsAMD != null)
            {
                fixed (GLuint* ptr_monitors = monitors)
                {
                    glDeletePerfMonitorsAMD(n, ptr_monitors);
                }
            }
        }

        // GLAPI void APIENTRY glSelectPerfMonitorCountersAMD (GLuint monitor, GLboolean enable, GLuint group, GLint numCounters, GLuint *counterList);
        public unsafe static void SelectPerfMonitorCountersAMD(GLuint monitor, GLboolean enable, GLuint group, GLint numCounters, GLuint[] counterList)
        {
            fixed (GLuint* ptr_counterList = counterList)
            {
                glSelectPerfMonitorCountersAMD(monitor, enable, group, numCounters, ptr_counterList);
            }
        }

        // GLAPI void APIENTRY glBeginPerfMonitorAMD (GLuint monitor);
        public static void BeginPerfMonitorAMD(GLuint monitor)
        {
            if (glBeginPerfMonitorAMD != null)
            {
                glBeginPerfMonitorAMD(monitor);
            }
        }

        // GLAPI void APIENTRY glEndPerfMonitorAMD (GLuint monitor);
        public static void EndPerfMonitorAMD(GLuint monitor)
        {
            if (glEndPerfMonitorAMD != null)
            {
                glEndPerfMonitorAMD(monitor);
            }
        }

        // GLAPI void APIENTRY glGetPerfMonitorCounterDataAMD (GLuint monitor, GLenum pname, GLsizei dataSize, GLuint *data, GLint *bytesWritten);
        public unsafe static void GetPerfMonitorCounterDataAMD(GLuint monitor, GLenum pname, GLsizei dataSize, GLuint[] data, GLint[] bytesWritten)
        {
            if (glGetPerfMonitorCounterDataAMD != null)
            {
                fixed (GLuint* ptr_data = data)
                {
                    fixed (GLint* ptr_bytesWritten = bytesWritten)
                    {
                        glGetPerfMonitorCounterDataAMD(monitor, pname, dataSize, ptr_data, ptr_bytesWritten);
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_texture_texture4 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_vertex_shader_tessellator
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTessellationFactorAMD (GLfloat factor);
        public static void TessellationFactorAMD(GLfloat factor)
        {
            if (glTessellationFactorAMD != null)
            {
                glTessellationFactorAMD(factor);
            }
        }

        // GLAPI void APIENTRY glTessellationModeAMD (GLenum mode);
        public static void TessellationModeAMD(GLenum mode)
        {
            if (glTessellationModeAMD != null)
            {
                glTessellationModeAMD(mode);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_draw_buffers_blend
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendFuncIndexedAMD (GLuint buf, GLenum src, GLenum dst);
        public static void BlendFuncIndexedAMD(GLuint buf, GLenum src, GLenum dst)
        {
            if (glBlendFuncIndexedAMD != null)
            {
                glBlendFuncIndexedAMD(buf, src, dst);
            }
        }

        // GLAPI void APIENTRY glBlendFuncSeparateIndexedAMD (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);
        public static void BlendFuncSeparateIndexedAMD(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha)
        {
            if (glBlendFuncSeparateIndexedAMD != null)
            {
                glBlendFuncSeparateIndexedAMD(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
            }
        }

        // GLAPI void APIENTRY glBlendEquationIndexedAMD (GLuint buf, GLenum mode);
        public static void BlendEquationIndexedAMD(GLuint buf, GLenum mode)
        {
            if (glBlendEquationIndexedAMD != null)
            {
                glBlendEquationIndexedAMD(buf, mode);
            }
        }

        // GLAPI void APIENTRY glBlendEquationSeparateIndexedAMD (GLuint buf, GLenum modeRGB, GLenum modeAlpha);
        public static void BlendEquationSeparateIndexedAMD(GLuint buf, GLenum modeRGB, GLenum modeAlpha)
        {
            if (glBlendEquationSeparateIndexedAMD != null)
            {
                glBlendEquationSeparateIndexedAMD(buf, modeRGB, modeAlpha);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_shader_stencil_export (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_seamless_cubemap_per_texture (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_conservative_depth (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_name_gen_delete
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGenNamesAMD (GLenum identifier, GLuint num, GLuint *names);
        public unsafe static void GenNamesAMD(GLenum identifier, GLuint num, GLuint[] names)
        {
            if (glGenNamesAMD != null)
            {
                fixed (GLuint* ptr_names = names)
                {
                    glGenNamesAMD(identifier, num, ptr_names);
                }
            }
        }

        // GLAPI void APIENTRY glDeleteNamesAMD (GLenum identifier, GLuint num, const GLuint *names);
        public unsafe static void DeleteNamesAMD(GLenum identifier, GLuint num, GLuint[] names)
        {
            if (glDeleteNamesAMD != null)
            {
                fixed (GLuint* ptr_names = names)
                {
                    glDeleteNamesAMD(identifier, num, ptr_names);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsNameAMD (GLenum identifier, GLuint name);
        public static GLboolean IsNameAMD(GLenum identifier, GLuint name)
        {
            if (glIsNameAMD != null)
            {
                return glIsNameAMD(identifier, name);
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_debug_output
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDebugMessageEnableAMD (GLenum category, GLenum severity, GLsizei count, const GLuint *ids, GLboolean enabled);
        public unsafe static void DebugMessageEnableAMD(GLenum category, GLenum severity, GLsizei count, GLuint[] ids, GLboolean enabled)
        {
            if (glDebugMessageEnableAMD != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glDebugMessageEnableAMD(category, severity, count, ptr_ids, enabled);
                }
            }
        }

        // GLAPI void APIENTRY glDebugMessageInsertAMD (GLenum category, GLenum severity, GLuint id, GLsizei length, const GLchar *buf);
        public unsafe static void DebugMessageInsertAMD(GLenum category, GLenum severity, GLuint id, GLsizei length, string buf)
        {
            if (glDebugMessageInsertAMD != null)
            {
                glDebugMessageInsertAMD(category, severity, id, length, buf);
            }
        }

        // GLAPI void APIENTRY glDebugMessageCallbackAMD (GLDEBUGPROCAMD callback, GLvoid *userParam);
        public unsafe static void DebugMessageCallbackAMD(TCALLBACKglDebugProcAMD callback, IntPtr userParam)
        {
            if (glDebugMessageCallbackAMD != null)
            {
                glDebugMessageCallbackAMD(callback, userParam.ToPointer());
            }
        }

        // GLAPI GLuint APIENTRY glGetDebugMessageLogAMD (GLuint count, GLsizei bufsize, GLenum *categories, GLuint *severities, GLuint *ids, GLsizei *lengths, GLchar *message);
        public unsafe static GLuint GetDebugMessageLogAMD(GLuint count, GLsizei bufsize, GLenum[] categories, GLuint[] severities, GLuint[] ids, GLsizei[] lengths, GLchar[] message)
        {
            if (glGetDebugMessageLogAMD != null)
            {
                fixed (GLenum* ptr_categories = categories)
                {
                    fixed (GLuint* ptr_severities = severities)
                    {
                        fixed (GLuint* ptr_ids = ids)
                        {
                            fixed (GLsizei* ptr_lengths = lengths)
                            {
                                fixed (GLchar* ptr_message = message)
                                {
                                    return glGetDebugMessageLogAMD(count, bufsize, ptr_categories, ptr_severities, ptr_ids, ptr_lengths, ptr_message);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                return 0;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_transform_feedback3_lines_triangles (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_depth_clamp_separate (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_blend_minmax_factor (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_sample_positions
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glSetMultisamplefvAMD (GLenum pname, GLuint index, const GLfloat *val);
        public unsafe static void SetMultisamplefvAMD(GLenum pname, GLuint index, GLfloat[] val)
        {
            if (glSetMultisamplefvAMD != null)
            {
                fixed (GLfloat* ptr_val = val)
                {
                    glSetMultisamplefvAMD(pname, index, ptr_val);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_multi_draw_indirect
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMultiDrawArraysIndirectAMD (GLenum mode, const GLvoid *indirect, GLsizei primcount, GLsizei stride);
        public unsafe static void MultiDrawArraysIndirectAMD(GLenum mode, IntPtr indirect, GLsizei primcount, GLsizei stride)
        {
            if (glMultiDrawArraysIndirectAMD != null)
            {
                glMultiDrawArraysIndirectAMD(mode, indirect.ToPointer(), primcount, stride);
            }
        }

        // GLAPI void APIENTRY glMultiDrawElementsIndirectAMD (GLenum mode, GLenum type, const GLvoid *indirect, GLsizei primcount, GLsizei stride);
        public unsafe static void MultiDrawElementsIndirectAMD(GLenum mode, GLenum type, IntPtr indirect, GLsizei primcount, GLsizei stride)
        {
            if (glMultiDrawElementsIndirectAMD != null)
            {
                glMultiDrawElementsIndirectAMD(mode, type, indirect.ToPointer(), primcount, stride);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_pinned_memory (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_stencil_operation_extended
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glStencilOpValueAMD (GLenum face, GLuint value);
        public static void StencilOpValueAMD(GLenum face, GLuint value)
        {
            if (glStencilOpValueAMD != null)
            {
                glStencilOpValueAMD(face, value);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_vertex_shader_viewport_index (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_vertex_shader_layer (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_query_buffer_object (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_sparse_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexStorageSparseAMD (GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags);
        public static void TexStorageSparseAMD(GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags)
        {
            if (glTexStorageSparseAMD != null)
            {
                glTexStorageSparseAMD(target, internalFormat, width, height, depth, layers, flags);
            }
        }

        // GLAPI void APIENTRY glTextureStorageSparseAMD (GLuint texture, GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags);
        public static void TextureStorageSparseAMD(GLuint texture, GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags)
        {
            if (glTextureStorageSparseAMD != null)
            {
                glTextureStorageSparseAMD(texture, target, internalFormat, width, height, depth, layers, flags);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_shader_atomic_counter_ops (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_shader_trinary_minmax (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_interleaved_elements
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexAttribParameteriAMD (GLuint index, GLenum pname, GLint param);
        public static void VertexAttribParameteriAMD(GLuint index, GLenum pname, GLint param)
        {
            if (glVertexAttribParameteriAMD != null)
            {
                glVertexAttribParameteriAMD(index, pname, param);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_occlusion_query_event
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glQueryObjectParameteruiAMD (GLenum target, GLuint id, GLenum pname, GLuint param);
        public static void QueryObjectParameteruiAMD(GLenum target, GLuint id, GLenum pname, GLuint param)
        {
            if (glQueryObjectParameteruiAMD != null)
            {
                glQueryObjectParameteruiAMD(target, id, pname, param);
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_AMDX_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_AMDX_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_vertex_shader_tessellator
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTessellationFactorAMDX (GLfloat factor);
        public static void TessellationFactorAMDX(GLfloat factor)
        {
            if (glTessellationFactorAMDX != null)
            {
                glTessellationFactorAMDX(factor);
            }
        }

        // GLAPI void APIENTRY glTessellationModeAMDX (GLenum mode);
        public static void TessellationModeAMDX(GLenum mode)
        {
            if (glTessellationModeAMDX != null)
            {
                glTessellationModeAMDX(mode);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_debug_output
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDebugMessageEnableAMDX (GLenum category, GLenum severity, GLsizei count, const GLuint *ids, GLboolean enabled);
        public unsafe static void DebugMessageEnableAMDX(GLenum category, GLenum severity, GLsizei count, GLuint[] ids, GLboolean enabled)
        {
            if (glDebugMessageEnableAMDX != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glDebugMessageEnableAMDX(category, severity, count, ptr_ids, enabled);
                }
            }
        }

        // GLAPI void APIENTRY glDebugMessageInsertAMDX (GLenum category, GLenum severity, GLuint id, GLsizei length, const GLchar *buf);
        public unsafe static void DebugMessageInsertAMDX(GLenum category, GLenum severity, GLuint id, GLsizei length, string buf)
        {
            if (glDebugMessageInsertAMDX != null)
            {
                glDebugMessageInsertAMDX(category, severity, id, length, buf);
            }
        }

        // GLAPI void APIENTRY glDebugMessageCallbackAMDX (GLDEBUGPROCAMD callback, GLvoid *userParam);
        public unsafe static void DebugMessageCallbackAMDX(TCALLBACKglDebugProcAMD callback, IntPtr userParam)
        {
            if (glDebugMessageCallbackAMDX != null)
            {
                glDebugMessageCallbackAMDX(callback, userParam.ToPointer());
            }
        }

        // GLAPI GLuint APIENTRY glGetDebugMessageLogAMDX (GLuint count, GLsizei bufsize, GLenum *categories, GLuint *severities, GLuint *ids, GLsizei *lengths, GLchar *message);
        public unsafe static GLuint GetDebugMessageLogAMDX(GLuint count, GLsizei bufsize, GLenum[] categories, GLuint[] severities, GLuint[] ids, GLsizei[] lengths, GLchar[] message)
        {
            if (glGetDebugMessageLogAMDX != null)
            {
                fixed (GLenum* ptr_categories = categories)
                {
                    fixed (GLuint* ptr_severities = severities)
                    {
                        fixed (GLuint* ptr_ids = ids)
                        {
                            fixed (GLsizei* ptr_lengths = lengths)
                            {
                                fixed (GLchar* ptr_message = message)
                                {
                                    return glGetDebugMessageLogAMDX(count, bufsize, ptr_categories, ptr_severities, ptr_ids, ptr_lengths, ptr_message);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                return 0;
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_APPLE_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_specular_vector (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_transform_hint (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_client_storage (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_element_array
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glElementPointerAPPLE (GLenum type, const GLvoid *pointer);
        public unsafe static void ElementPointerAPPLE(GLenum type, IntPtr pointer)
        {
            if (glElementPointerAPPLE != null)
            {
                glElementPointerAPPLE(type, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glDrawElementArrayAPPLE (GLenum mode, GLint first, GLsizei count);
        public static void DrawElementArrayAPPLE(GLenum mode, GLint first, GLsizei count)
        {
            if (glDrawElementArrayAPPLE != null)
            {
                glDrawElementArrayAPPLE(mode, first, count);
            }
        }

        // GLAPI void APIENTRY glDrawRangeElementArrayAPPLE (GLenum mode, GLuint start, GLuint end, GLint first, GLsizei count);
        public static void DrawRangeElementArrayAPPLE(GLenum mode, GLuint start, GLuint end, GLint first, GLsizei count)
        {
            if (glDrawRangeElementArrayAPPLE != null)
            {
                glDrawRangeElementArrayAPPLE(mode, start, end, first, count);
            }
        }

        // GLAPI void APIENTRY glMultiDrawElementArrayAPPLE (GLenum mode, const GLint *first, const GLsizei *count, GLsizei primcount);
        public unsafe static void MultiDrawElementArrayAPPLE(GLenum mode, GLint[] first, GLsizei[] count, GLsizei primcount)
        {
            if (glMultiDrawElementArrayAPPLE != null)
            {
                fixed (GLint* ptr_first = first)
                {
                    fixed (GLsizei* ptr_count = count)
                    {
                        glMultiDrawElementArrayAPPLE(mode, ptr_first, ptr_count, primcount);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glMultiDrawRangeElementArrayAPPLE (GLenum mode, GLuint start, GLuint end, const GLint *first, const GLsizei *count, GLsizei primcount);
        public unsafe static void MultiDrawRangeElementArrayAPPLE(GLenum mode, GLuint start, GLuint end, GLint[] first, GLsizei[] count, GLsizei primcount)
        {
            if (glMultiDrawRangeElementArrayAPPLE != null)
            {
                fixed (GLint* ptr_first = first)
                {
                    fixed (GLsizei* ptr_count = count)
                    {
                        glMultiDrawRangeElementArrayAPPLE(mode, start, end, ptr_first, ptr_count, primcount);
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_fence
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGenFencesAPPLE (GLsizei n, GLuint *fences);
        public unsafe static void GenFencesAPPLE(GLsizei n, GLuint[] fences)
        {
            if (glGenFencesAPPLE != null)
            {
                fixed (GLuint* ptr_fences = fences)
                {
                    glGenFencesAPPLE(n, ptr_fences);
                }
            }
        }

        // GLAPI void APIENTRY glDeleteFencesAPPLE (GLsizei n, const GLuint *fences);
        public unsafe static void DeleteFencesAPPLE(GLsizei n, GLuint[] fences)
        {
            if (glDeleteFencesAPPLE != null)
            {
                fixed (GLuint* ptr_fences = fences)
                {
                    glDeleteFencesAPPLE(n, ptr_fences);
                }
            }
        }

        // GLAPI void APIENTRY glSetFenceAPPLE (GLuint fence);
        public static void SetFenceAPPLE(GLuint fence)
        {
            if (glSetFenceAPPLE != null)
            {
                glSetFenceAPPLE(fence);
            }
        }

        // GLAPI GLboolean APIENTRY glIsFenceAPPLE (GLuint fence);
        public static GLboolean IsFenceAPPLE(GLuint fence)
        {
            if (glIsFenceAPPLE != null)
            {
                return glIsFenceAPPLE(fence);
            }
            else
            {
                return false;
            }
        }

        // GLAPI GLboolean APIENTRY glTestFenceAPPLE (GLuint fence);
        public static GLboolean TestFenceAPPLE(GLuint fence)
        {
            if (glTestFenceAPPLE != null)
            {
                return glTestFenceAPPLE(fence);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glFinishFenceAPPLE (GLuint fence);
        public static void FinishFenceAPPLE(GLuint fence)
        {
            if (glFinishFenceAPPLE != null)
            {
                glFinishFenceAPPLE(fence);
            }
        }

        // GLAPI GLboolean APIENTRY glTestObjectAPPLE (GLenum object, GLuint name);
        public static GLboolean TestObjectAPPLE (GLenum obj, GLuint name)
        {
            if (glTestObjectAPPLE != null)
            {
                return glTestObjectAPPLE(obj, name);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glFinishObjectAPPLE (GLenum object, GLint name);
        public static void FinishObjectAPPLE(GLenum obj, GLint name)
        {
            if (glFinishObjectAPPLE != null)
            {
                glFinishObjectAPPLE(obj, name);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_vertex_array_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBindVertexArrayAPPLE (GLuint array);
        public static void BindVertexArrayAPPLE(GLuint array)
        {
            if (glBindVertexArrayAPPLE != null)
            {
                glBindVertexArrayAPPLE(array);
            }
        }

        // GLAPI void APIENTRY glDeleteVertexArraysAPPLE (GLsizei n, const GLuint *arrays);
        public unsafe static void DeleteVertexArraysAPPLE(GLsizei n, GLuint[] arrays)
        {
            if (glDeleteVertexArraysAPPLE != null)
            {
                fixed (GLuint* ptr_arrays = arrays)
                {
                    glDeleteVertexArraysAPPLE(n, ptr_arrays);
                }
            }
        }

        // GLAPI void APIENTRY glGenVertexArraysAPPLE (GLsizei n, GLuint *arrays);
        public unsafe static void GenVertexArraysAPPLE(GLsizei n, GLuint[] arrays)
        {
            if (glGenVertexArraysAPPLE != null)
            {
                fixed (GLuint* ptr_arrays = arrays)
                {
                    glGenVertexArraysAPPLE(n, ptr_arrays);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsVertexArrayAPPLE (GLuint array);
        public static GLboolean IsVertexArrayAPPLE(GLuint array)
        {
            if (glIsVertexArrayAPPLE != null)
            {
                return glIsVertexArrayAPPLE(array);
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_vertex_array_range
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexArrayRangeAPPLE (GLsizei length, GLvoid *pointer);
        public unsafe static void VertexArrayRangeAPPLE(GLsizei length, IntPtr pointer)
        {
            if (glVertexArrayRangeAPPLE != null)
            {
                glVertexArrayRangeAPPLE(length, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glFlushVertexArrayRangeAPPLE (GLsizei length, GLvoid *pointer);
        public unsafe static void FlushVertexArrayRangeAPPLE(GLsizei length, IntPtr pointer)
        {
            if (glFlushVertexArrayRangeAPPLE != null)
            {
                glFlushVertexArrayRangeAPPLE(length, pointer.ToPointer());
            }
        }
        
        // GLAPI void APIENTRY glVertexArrayParameteriAPPLE (GLenum pname, GLint param);
        public static void VertexArrayParameteriAPPLE(GLenum pname, GLint param)
        {
            if (glVertexArrayParameteriAPPLE != null)
            {
                glVertexArrayParameteriAPPLE(pname, param);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_ycbcr_422 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_flush_buffer_range
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBufferParameteriAPPLE (GLenum target, GLenum pname, GLint param);
        public static void BufferParameteriAPPLE(GLenum target, GLenum pname, GLint param)
        {
            if (glBufferParameteriAPPLE != null)
            {
                glBufferParameteriAPPLE(target, pname, param);
            }
        }

        // GLAPI void APIENTRY glFlushMappedBufferRangeAPPLE (GLenum target, GLintptr offset, GLsizeiptr size);
        public static void FlushMappedBufferRangeAPPLE(GLenum target, GLintptr offset, GLsizeiptr size)
        {
            if (glFlushMappedBufferRangeAPPLE != null)
            {
                glFlushMappedBufferRangeAPPLE(target, offset, size);
            }
        }

        ///////////////////////////////FlushVertexArrayRangeAPPLE ////////////////////////////////////////
        // GL_APPLE_texture_range
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTextureRangeAPPLE (GLenum target, GLsizei length, const GLvoid *pointer);
        public unsafe static void TextureRangeAPPLE(GLenum target, GLsizei length, IntPtr pointer)
        {
            if (glTextureRangeAPPLE != null)
            {
                glTextureRangeAPPLE(target, length, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetTexParameterPointervAPPLE (GLenum target, GLenum pname, GLvoid* *params);
        public unsafe static void GetTexParameterPointervAPPLE(GLenum target, GLenum pname, IntPtr[] parameters)
        {
            if (glGetTexParameterPointervAPPLE != null)
            {
                fixed (IntPtr* ptr_parameters = parameters)
                {
                    glGetTexParameterPointervAPPLE(target, pname, (void**)ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_float_pixels (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_vertex_program_evaluators
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glEnableVertexAttribAPPLE (GLuint index, GLenum pname);
        public static void EnableVertexAttribAPPLE(GLuint index, GLenum pname)
        {
            if (glEnableVertexAttribAPPLE != null)
            {
                glEnableVertexAttribAPPLE(index, pname);
            }
        }

        // GLAPI void APIENTRY glDisableVertexAttribAPPLE (GLuint index, GLenum pname);
        public static void DisableVertexAttribAPPLE(GLuint index, GLenum pname)
        {
            if (glDisableVertexAttribAPPLE != null)
            {
                glDisableVertexAttribAPPLE(index, pname);
            }
        }

        // GLAPI GLboolean APIENTRY glIsVertexAttribEnabledAPPLE (GLuint index, GLenum pname);
        public static GLboolean IsVertexAttribEnabledAPPLE(GLuint index, GLenum pname)
        {
            if (glIsVertexAttribEnabledAPPLE != null)
            {
                return glIsVertexAttribEnabledAPPLE(index, pname);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glMapVertexAttrib1dAPPLE (GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint stride, GLint order, const GLdouble *points);
        public unsafe static void MapVertexAttrib1dAPPLE(GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble[] points)
        {
            if (glMapVertexAttrib1dAPPLE != null)
            {
                fixed (GLdouble* ptr_points = points)
                {
                    glMapVertexAttrib1dAPPLE(index, size, u1, u2, stride, order, ptr_points);
                }
            }
        }

        // GLAPI void APIENTRY glMapVertexAttrib1fAPPLE (GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint stride, GLint order, const GLfloat *points);
        public unsafe static void MapVertexAttrib1fAPPLE(GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat[] points)
        {
            if (glMapVertexAttrib1fAPPLE != null)
            {
                fixed (GLfloat* ptr_points = points)
                {
                    glMapVertexAttrib1fAPPLE(index, size, u1, u2, stride, order, ptr_points);
                }
            }
        }

        // GLAPI void APIENTRY glMapVertexAttrib2dAPPLE (GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, const GLdouble *points);
        public unsafe static void MapVertexAttrib2dAPPLE(GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble[] points)
        {
            if (glMapVertexAttrib2dAPPLE != null)
            {
                fixed (GLdouble* ptr_points = points)
                {
                    glMapVertexAttrib2dAPPLE(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ptr_points);
                }
            }
        }

        // GLAPI void APIENTRY glMapVertexAttrib2fAPPLE (GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, const GLfloat *points);
        public unsafe static void MapVertexAttrib2fAPPLE(GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat[] points)
        {
            if (glMapVertexAttrib2fAPPLE != null)
            {
                fixed (GLfloat* ptr_points = points)
                {
                    glMapVertexAttrib2fAPPLE(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ptr_points);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_aux_depth_stencil (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_object_purgeable
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLenum APIENTRY glObjectPurgeableAPPLE (GLenum objectType, GLuint name, GLenum option);
        public static GLenum ObjectPurgeableAPPLE(GLenum objectType, GLuint name, GLenum option)
        {
            if (glObjectPurgeableAPPLE != null)
            {
                return glObjectPurgeableAPPLE(objectType, name, option);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLenum APIENTRY glObjectUnpurgeableAPPLE (GLenum objectType, GLuint name, GLenum option);
        public static GLenum ObjectUnpurgeableAPPLE(GLenum objectType, GLuint name, GLenum option)
        {
            if (glObjectUnpurgeableAPPLE != null)
            {
                return glObjectUnpurgeableAPPLE(objectType, name, option);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glGetObjectParameterivAPPLE (GLenum objectType, GLuint name, GLenum pname, GLint *params);
        public unsafe static void GetObjectParameterivAPPLE(GLenum objectType, GLuint name, GLenum pname, GLint[] parameters)
        {
            if (glGetObjectParameterivAPPLE != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetObjectParameterivAPPLE(objectType, name, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_row_bytes (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_rgb_422 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_ARB_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_imaging
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 1.2: GL_ARB_imaging section */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_occlusion_query2 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_multitexture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glActiveTextureARB (GLenum texture);
        public static void ActiveTextureARB(GLenum texture)
        {
            if (glActiveTextureARB != null)
            {
                glActiveTextureARB(texture);
            }
        }

        // GLAPI void APIENTRY glClientActiveTextureARB (GLenum texture);
        public static void ClientActiveTextureARB(GLenum texture)
        {
            if (glClientActiveTextureARB != null)
            {
                glClientActiveTextureARB(texture);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord1dARB (GLenum target, GLdouble s);
        public static void MultiTexCoord1dARB(GLenum target, GLdouble s)
        {
            if (glMultiTexCoord1dARB != null)
            {
                glMultiTexCoord1dARB(target, s);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord1dvARB (GLenum target, const GLdouble *v);
        public unsafe static void MultiTexCoord1dvARB(GLenum target, GLdouble[] v)
        {
            if (glMultiTexCoord1dvARB != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glMultiTexCoord1dvARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord1fARB (GLenum target, GLfloat s);
        public static void MultiTexCoord1fARB(GLenum target, GLfloat s)
        {
            if (glMultiTexCoord1fARB != null)
            {
                glMultiTexCoord1fARB(target, s);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord1fvARB (GLenum target, const GLfloat *v);
        public unsafe static void MultiTexCoord1fvARB(GLenum target, GLfloat[] v)
        {
            if (glMultiTexCoord1fvARB != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glMultiTexCoord1fvARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord1iARB (GLenum target, GLint s);
        public static void MultiTexCoord1iARB(GLenum target, GLint s)
        {
            if (glMultiTexCoord1iARB != null)
            {
                glMultiTexCoord1iARB(target, s);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord1ivARB (GLenum target, const GLint *v);
        public unsafe static void MultiTexCoord1ivARB(GLenum target, GLint[] v)
        {
            if (glMultiTexCoord1ivARB != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glMultiTexCoord1ivARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord1sARB (GLenum target, GLshort s);
        public static void MultiTexCoord1sARB(GLenum target, GLshort s)
        {
            if (glMultiTexCoord1sARB != null)
            {
                glMultiTexCoord1sARB(target, s);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord1svARB (GLenum target, const GLshort *v);
        public unsafe static void MultiTexCoord1svARB(GLenum target, GLshort[] v)
        {
            if (glMultiTexCoord1svARB != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glMultiTexCoord1svARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2dARB (GLenum target, GLdouble s, GLdouble t);
        public static void MultiTexCoord2dARB(GLenum target, GLdouble s, GLdouble t)
        {
            if (glMultiTexCoord2dARB != null)
            {
                glMultiTexCoord2dARB(target, s, t);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2dvARB (GLenum target, const GLdouble *v);
        public unsafe static void MultiTexCoord2dvARB(GLenum target, GLdouble[] v)
        {
            if (glMultiTexCoord2dvARB != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glMultiTexCoord2dvARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2fARB (GLenum target, GLfloat s, GLfloat t);
        public static void MultiTexCoord2fARB(GLenum target, GLfloat s, GLfloat t)
        {
            if (glMultiTexCoord2fARB != null)
            {
                glMultiTexCoord2fARB(target, s, t);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2fvARB (GLenum target, const GLfloat *v);
        public unsafe static void MultiTexCoord2fvARB(GLenum target, GLfloat[] v)
        {
            if (glMultiTexCoord2fvARB != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glMultiTexCoord2fvARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2iARB (GLenum target, GLint s, GLint t);
        public static void MultiTexCoord2iARB(GLenum target, GLint s, GLint t)
        {
            if (glMultiTexCoord2iARB != null)
            {
                glMultiTexCoord2iARB(target, s, t);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2ivARB (GLenum target, const GLint *v);
        public unsafe static void MultiTexCoord2ivARB(GLenum target, GLint[] v)
        {
            if (glMultiTexCoord2ivARB != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glMultiTexCoord2ivARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2sARB (GLenum target, GLshort s, GLshort t);
        public static void MultiTexCoord2sARB(GLenum target, GLshort s, GLshort t)
        {
            if (glMultiTexCoord2sARB != null)
            {
                glMultiTexCoord2sARB(target, s, t);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2svARB (GLenum target, const GLshort *v);
        public unsafe static void MultiTexCoord2svARB(GLenum target, GLshort[] v)
        {
            if (glMultiTexCoord2svARB != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glMultiTexCoord2svARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3dARB (GLenum target, GLdouble s, GLdouble t, GLdouble r);
        public static void MultiTexCoord3dARB(GLenum target, GLdouble s, GLdouble t, GLdouble r)
        {
            if (glMultiTexCoord3dARB != null)
            {
                glMultiTexCoord3dARB(target, s, t, r);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3dvARB (GLenum target, const GLdouble *v);
        public unsafe static void MultiTexCoord3dvARB(GLenum target, GLdouble[] v)
        {
            if (glMultiTexCoord3dvARB != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glMultiTexCoord3dvARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3fARB (GLenum target, GLfloat s, GLfloat t, GLfloat r);
        public static void MultiTexCoord3fARB(GLenum target, GLfloat s, GLfloat t, GLfloat r)
        {
            if (glMultiTexCoord3fARB != null)
            {
                glMultiTexCoord3fARB(target, s, t, r);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3fvARB (GLenum target, const GLfloat *v);
        public unsafe static void MultiTexCoord3fvARB(GLenum target, GLfloat[] v)
        {
            if (glMultiTexCoord3fvARB != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glMultiTexCoord3fvARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3iARB (GLenum target, GLint s, GLint t, GLint r);
        public static void MultiTexCoord3iARB(GLenum target, GLint s, GLint t, GLint r)
        {
            if (glMultiTexCoord3iARB != null)
            {
                glMultiTexCoord3iARB(target, s, t, r);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3ivARB (GLenum target, const GLint *v);
        public unsafe static void MultiTexCoord3ivARB (GLenum target, GLint[] v)
        {
            if (glMultiTexCoord3ivARB != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glMultiTexCoord3ivARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3sARB (GLenum target, GLshort s, GLshort t, GLshort r);
        public static void MultiTexCoord3sARB(GLenum target, GLshort s, GLshort t, GLshort r)
        {
            if (glMultiTexCoord3sARB != null)
            {
                glMultiTexCoord3sARB(target, s, t, r);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3svARB (GLenum target, const GLshort *v);
        public unsafe static void MultiTexCoord3svARB(GLenum target, GLshort[] v)
        {
            if (glMultiTexCoord3svARB != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glMultiTexCoord3svARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4dARB (GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
        public static void MultiTexCoord4dARB(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q)
        {
            if (glMultiTexCoord4dARB != null)
            {
                glMultiTexCoord4dARB(target, s, t, r, q);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4dvARB (GLenum target, const GLdouble *v);
        public unsafe static void MultiTexCoord4dvARB(GLenum target, GLdouble[] v)
        {
            if (glMultiTexCoord4dvARB != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glMultiTexCoord4dvARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4fARB (GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
        public static void MultiTexCoord4fARB(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q)
        {
            if (glMultiTexCoord4fARB != null)
            {
                glMultiTexCoord4fARB(target, s, t, r, q);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4fvARB (GLenum target, const GLfloat *v);
        public unsafe static void MultiTexCoord4fvARB(GLenum target, GLfloat[] v)
        {
            if (glMultiTexCoord4fvARB != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glMultiTexCoord4fvARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4iARB (GLenum target, GLint s, GLint t, GLint r, GLint q);
        public static void MultiTexCoord4iARB(GLenum target, GLint s, GLint t, GLint r, GLint q)
        {
            if (glMultiTexCoord4iARB != null)
            {
                glMultiTexCoord4iARB(target, s, t, r, q);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4ivARB (GLenum target, const GLint *v);
        public unsafe static void MultiTexCoord4ivARB(GLenum target, GLint[] v)
        {
            if (glMultiTexCoord4ivARB != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glMultiTexCoord4ivARB(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4sARB (GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);
        public static void MultiTexCoord4sARB(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q)
        {
            if (glMultiTexCoord4sARB != null)
            {
                glMultiTexCoord4sARB(target, s, t, r, q);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4svARB (GLenum target, const GLshort *v);
        public unsafe static void MultiTexCoord4svARB(GLenum target, GLshort[] v)
        {
            if (glMultiTexCoord4svARB != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glMultiTexCoord4svARB(target, ptr_v);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_transpose_matrix
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glLoadTransposeMatrixfARB (const GLfloat *m);
        public unsafe static void LoadTransposeMatrixfARB(GLfloat[] m)
        {
            if (glLoadTransposeMatrixfARB != null)
            {
                fixed (GLfloat* ptr_m = m)
                {
                    glLoadTransposeMatrixfARB(ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glLoadTransposeMatrixdARB (const GLdouble *m);
        public unsafe static void LoadTransposeMatrixdARB(GLdouble[] m)
        {
            if (glLoadTransposeMatrixdARB != null)
            {
                fixed (GLdouble* ptr_m = m)
                {
                    glLoadTransposeMatrixdARB(ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glMultTransposeMatrixfARB (const GLfloat *m);
        public unsafe static void MultTransposeMatrixfARB(GLfloat[] m)
        {
            if (glMultTransposeMatrixfARB != null)
            {
                fixed (GLfloat* ptr_m = m)
                {
                    glMultTransposeMatrixfARB(ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glMultTransposeMatrixdARB (const GLdouble *m);
        public unsafe static void MultTransposeMatrixdARB(GLdouble[] m)
        {
            if (glMultTransposeMatrixdARB != null)
            {
                fixed (GLdouble* ptr_m = m)
                {
                    glMultTransposeMatrixdARB(ptr_m);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_multisample
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glSampleCoverageARB (GLfloat value, GLboolean invert);
        public static void SampleCoverageARB(GLfloat value, GLboolean invert)
        {
            if (glSampleCoverageARB != null)
            {
                glSampleCoverageARB(value, invert);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_env_add (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_cube_map (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_compression
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCompressedTexImage3DARB (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, const GLvoid *data);
        public unsafe static void CompressedTexImage3DARB (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTexImage3DARB != null)
            {
                glCompressedTexImage3DARB(target, level, internalformat, width, height, depth, border, imageSize, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedTexImage2DARB (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, const GLvoid *data);
        public unsafe static void CompressedTexImage2DARB(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTexImage2DARB != null)
            {
                glCompressedTexImage2DARB(target, level, internalformat, width, height, border, imageSize, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedTexImage1DARB (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, const GLvoid *data);
        public unsafe static void CompressedTexImage1DARB(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTexImage1DARB != null)
            {
                glCompressedTexImage1DARB(target, level, internalformat, width, border, imageSize, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedTexSubImage3DARB (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const GLvoid *data);
        public unsafe static void CompressedTexSubImage3DARB(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTexSubImage3DARB != null)
            {
                glCompressedTexSubImage3DARB(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedTexSubImage2DARB (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const GLvoid *data);
        public unsafe static void CompressedTexSubImage2DARB (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTexSubImage2DARB != null)
            {
                glCompressedTexSubImage2DARB(target, level, xoffset, yoffset, width, height, format, imageSize, data.ToPointer());
            }
        }
        
        // GLAPI void APIENTRY glCompressedTexSubImage1DARB (GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, const GLvoid *data);
        public unsafe static void CompressedTexSubImage1DARB(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTexSubImage1DARB != null)
            {
                glCompressedTexSubImage1DARB(target, level, xoffset, width, format, imageSize, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetCompressedTexImageARB (GLenum target, GLint level, GLvoid *img);
        public unsafe static void GetCompressedTexImageARB(GLenum target, GLint level, IntPtr img)
        {
            if (glGetCompressedTexImageARB != null)
            {
                glGetCompressedTexImageARB(target, level, img.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_border_clamp (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_point_parameters
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPointParameterfARB (GLenum pname, GLfloat param);
        public static void PointParameterfARB(GLenum pname, GLfloat param)
        {
            if (glPointParameterfARB != null)
            {
                glPointParameterfARB(pname, param);
            }
        }

        // GLAPI void APIENTRY glPointParameterfvARB (GLenum pname, const GLfloat *params);
        public unsafe static void PointParameterfvARB(GLenum pname, GLfloat[] parameters)
        {
            if (glPointParameterfvARB != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glPointParameterfvARB(pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_precision (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_blend
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glWeightbvARB (GLint size, const GLbyte *weights);
        public unsafe static void WeightbvARB(GLint size, GLbyte[] weights)
        {
            if (glWeightbvARB != null)
            {
                fixed (GLbyte* ptr_weights = weights)
                {
                    glWeightbvARB(size, ptr_weights);
                }
            }
        }

        // GLAPI void APIENTRY glWeightsvARB (GLint size, const GLshort *weights);
        public unsafe static void WeightsvARB(GLint size, GLshort[] weights)
        {
            if (glWeightsvARB != null)
            {
                fixed (GLshort* ptr_weights = weights)
                {
                    glWeightsvARB(size, ptr_weights);
                }
            }
        }

        // GLAPI void APIENTRY glWeightivARB (GLint size, const GLint *weights);
        public unsafe static void WeightivARB(GLint size, GLint[] weights)
        {
            if (glWeightivARB != null)
            {
                fixed (GLint* ptr_weights = weights)
                {
                    glWeightivARB(size, ptr_weights);
                }
            }
        }

        // GLAPI void APIENTRY glWeightfvARB (GLint size, const GLfloat *weights);
        public unsafe static void WeightfvARB(GLint size, GLfloat[] weights)
        {
            if (glWeightfvARB != null)
            {
                fixed (GLfloat* ptr_weights = weights)
                {
                    glWeightfvARB(size, ptr_weights);
                }
            }
        }

        // GLAPI void APIENTRY glWeightdvARB (GLint size, const GLdouble *weights);
        public unsafe static void WeightdvARB(GLint size, GLdouble[] weights)
        {
            if (glWeightdvARB != null)
            {
                fixed (GLdouble* ptr_weights = weights)
                {
                    glWeightdvARB(size, ptr_weights);
                }
            }
        }

        // GLAPI void APIENTRY glWeightubvARB (GLint size, const GLubyte *weights);
        public unsafe static void WeightubvARB(GLint size, GLubyte[] weights)
        {
            if (glWeightubvARB != null)
            {
                fixed (GLubyte* ptr_weights = weights)
                {
                    glWeightubvARB(size, ptr_weights);
                }
            }
        }

        // GLAPI void APIENTRY glWeightusvARB (GLint size, const GLushort *weights);
        public unsafe static void WeightusvARB(GLint size, GLushort[] weights)
        {
            if (glWeightusvARB != null)
            {
                fixed (GLushort* ptr_weights = weights)
                {
                    glWeightusvARB(size, ptr_weights);
                }
            }
        }

        // GLAPI void APIENTRY glWeightuivARB (GLint size, const GLuint *weights);
        public unsafe static void WeightuivARB(GLint size, GLuint[] weights)
        {
            if (glWeightuivARB != null)
            {
                fixed (GLuint* ptr_weights = weights)
                {
                    glWeightuivARB(size, ptr_weights);
                }
            }
        }

        // GLAPI void APIENTRY glWeightPointerARB (GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        public unsafe static void WeightPointerARB(GLint size, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glWeightPointerARB != null)
            {
                glWeightPointerARB(size, type, stride, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glVertexBlendARB (GLint count);
        public static void VertexBlendARB(GLint count)
        {
            if (glVertexBlendARB != null)
            {
                glVertexBlendARB(count);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_matrix_palette
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCurrentPaletteMatrixARB (GLint index);
        public static void CurrentPaletteMatrixARB(GLint index)
        {
            if (glCurrentPaletteMatrixARB != null)
            {
                glCurrentPaletteMatrixARB(index);
            }
        }

        // GLAPI void APIENTRY glMatrixIndexubvARB (GLint size, const GLubyte *indices);
        public unsafe static void MatrixIndexubvARB(GLint size, GLubyte[] indices)
        {
            if (glMatrixIndexubvARB != null)
            {
                fixed (GLubyte* ptr_indices = indices)
                {
                    glMatrixIndexubvARB(size, ptr_indices);
                }
            }
        }

        // GLAPI void APIENTRY glMatrixIndexusvARB (GLint size, const GLushort *indices);
        public unsafe static void MatrixIndexusvARB(GLint size, GLushort[] indices)
        {
            if (glMatrixIndexusvARB != null)
            {
                fixed (GLushort* ptr_indices = indices)
                {
                    glMatrixIndexusvARB(size, ptr_indices);
                }
            }
        }

        // GLAPI void APIENTRY glMatrixIndexuivARB (GLint size, const GLuint *indices);
        public unsafe static void MatrixIndexuivARB(GLint size, GLuint[] indices)
        {
            if (glMatrixIndexuivARB != null)
            {
                fixed (GLuint* ptr_indices = indices)
                {
                    glMatrixIndexuivARB(size, ptr_indices);
                }
            }
        }

        // GLAPI void APIENTRY glMatrixIndexPointerARB (GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        public unsafe static void MatrixIndexPointerARB(GLint size, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glMatrixIndexPointerARB != null)
            {
                glMatrixIndexPointerARB(size, type, stride, pointer.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_env_combine (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_env_crossbar (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_env_dot3 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_mirrored_repeat (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_depth_texture (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shadow (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shadow_ambient (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_window_pos
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glWindowPos2dARB (GLdouble x, GLdouble y);
        public static void WindowPos2dARB(GLdouble x, GLdouble y)
        {
            if (glWindowPos2dARB != null)
            {
                glWindowPos2dARB(x, y);
            }
        }

        // GLAPI void APIENTRY glWindowPos2dvARB (const GLdouble *v);
        public unsafe static void WindowPos2dvARB(GLdouble[] v)
        {
            if (glWindowPos2dvARB != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glWindowPos2dvARB(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos2fARB (GLfloat x, GLfloat y);
        public static void WindowPos2fARB(GLfloat x, GLfloat y)
        {
            if (glWindowPos2fARB != null)
            {
                glWindowPos2fARB(x, y);
            }
        }

        // GLAPI void APIENTRY glWindowPos2fvARB (const GLfloat *v);
        public unsafe static void WindowPos2fvARB(GLfloat[] v)
        {
            if (glWindowPos2fvARB != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glWindowPos2fvARB(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos2iARB (GLint x, GLint y);
        public static void WindowPos2iARB(GLint x, GLint y)
        {
            if (glWindowPos2iARB != null)
            {
                glWindowPos2iARB(x, y);
            }
        }

        // GLAPI void APIENTRY glWindowPos2ivARB (const GLint *v);
        public unsafe static void WindowPos2ivARB(GLint[] v)
        {
            if (glWindowPos2ivARB != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glWindowPos2ivARB(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos2sARB (GLshort x, GLshort y);
        public static void WindowPos2sARB(GLshort x, GLshort y)
        {
            if (glWindowPos2sARB != null)
            {
                glWindowPos2sARB(x, y);
            }
        }

        // GLAPI void APIENTRY glWindowPos2svARB (const GLshort *v);
        public unsafe static void WindowPos2svARB(GLshort[] v)
        {
            if (glWindowPos2svARB != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glWindowPos2svARB(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos3dARB (GLdouble x, GLdouble y, GLdouble z);
        public static void WindowPos3dARB(GLdouble x, GLdouble y, GLdouble z)
        {
            if (glWindowPos3dARB != null)
            {
                glWindowPos3dARB(x, y, z);
            }
        }

        // GLAPI void APIENTRY glWindowPos3dvARB (const GLdouble *v);
        public unsafe static void WindowPos3dvARB(GLdouble[] v)
        {
            if (glWindowPos3dvARB != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glWindowPos3dvARB(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos3fARB (GLfloat x, GLfloat y, GLfloat z);
        public static void WindowPos3fARB(GLfloat x, GLfloat y, GLfloat z)
        {
            if (glWindowPos3fARB != null)
            {
                glWindowPos3fARB(x, y, z);
            }
        }

        // GLAPI void APIENTRY glWindowPos3fvARB (const GLfloat *v);
        public unsafe static void WindowPos3fvARB(GLfloat[] v)
        {
            if (glWindowPos3fvARB != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glWindowPos3fvARB(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos3iARB (GLint x, GLint y, GLint z);
        public static void WindowPos3iARB(GLint x, GLint y, GLint z)
        {
            if (glWindowPos3iARB != null)
            {
                glWindowPos3iARB(x, y, z);
            }
        }

        // GLAPI void APIENTRY glWindowPos3ivARB (const GLint *v);
        public unsafe static void WindowPos3ivARB(GLint[] v)
        {
            if (glWindowPos3ivARB != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glWindowPos3ivARB(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos3sARB (GLshort x, GLshort y, GLshort z);
        public static void WindowPos3sARB(GLshort x, GLshort y, GLshort z)
        {
            if (glWindowPos3sARB != null)
            {
                glWindowPos3sARB(x, y, z);
            }
        }

        // GLAPI void APIENTRY glWindowPos3svARB (const GLshort *v);
        public unsafe static void WindowPos3svARB(GLshort[] v)
        {
            if (glWindowPos3svARB != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glWindowPos3svARB(ptr_v);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_program
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexAttrib1dARB (GLuint index, GLdouble x);
        public static void VertexAttrib1dARB(GLuint index, GLdouble x)
        {
            if (glVertexAttrib1dARB != null)
            {
                glVertexAttrib1dARB(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1dvARB (GLuint index, const GLdouble *v);
        public unsafe static void VertexAttrib1dvARB(GLuint index, GLdouble[] v)
        {
            if (glVertexAttrib1dvARB != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttrib1dvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1fARB (GLuint index, GLfloat x);
        public static void VertexAttrib1fARB(GLuint index, GLfloat x)
        {
            if (glVertexAttrib1fARB != null)
            {
                glVertexAttrib1fARB(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1fvARB (GLuint index, const GLfloat *v);
        public unsafe static void VertexAttrib1fvARB(GLuint index, GLfloat[] v)
        {
            if (glVertexAttrib1fvARB != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertexAttrib1fvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1sARB (GLuint index, GLshort x);
        public static void VertexAttrib1sARB(GLuint index, GLshort x)
        {
            if (glVertexAttrib1sARB != null)
            {
                glVertexAttrib1sARB(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1svARB (GLuint index, const GLshort *v);
        public unsafe static void VertexAttrib1svARB(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib1svARB != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttrib1svARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2dARB (GLuint index, GLdouble x, GLdouble y);
        public static void VertexAttrib2dARB(GLuint index, GLdouble x, GLdouble y)
        {
            if (glVertexAttrib2dARB != null)
            {
                glVertexAttrib2dARB(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2dvARB (GLuint index, const GLdouble *v);
        public unsafe static void VertexAttrib2dvARB(GLuint index, GLdouble[] v)
        {
            if (glVertexAttrib2dvARB != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttrib2dvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2fARB (GLuint index, GLfloat x, GLfloat y);
        public static void VertexAttrib2fARB(GLuint index, GLfloat x, GLfloat y)
        {
            if (glVertexAttrib2fARB != null)
            {
                glVertexAttrib2fARB(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2fvARB (GLuint index, const GLfloat *v);
        public unsafe static void VertexAttrib2fvARB(GLuint index, GLfloat[] v)
        {
            if (glVertexAttrib2fvARB != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertexAttrib2fvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2sARB (GLuint index, GLshort x, GLshort y);
        public static void VertexAttrib2sARB(GLuint index, GLshort x, GLshort y)
        {
            if (glVertexAttrib2sARB != null)
            {
                glVertexAttrib2sARB(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2svARB (GLuint index, const GLshort *v);
        public unsafe static void VertexAttrib2svARB(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib2svARB != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttrib2svARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3dARB (GLuint index, GLdouble x, GLdouble y, GLdouble z);
        public static void VertexAttrib3dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z)
        {
            if (glVertexAttrib3dARB != null)
            {
                glVertexAttrib3dARB(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3dvARB (GLuint index, const GLdouble *v);
        public unsafe static void VertexAttrib3dvARB(GLuint index, GLdouble[] v)
        {
            if (glVertexAttrib3dvARB != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttrib3dvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3fARB (GLuint index, GLfloat x, GLfloat y, GLfloat z);
        public static void VertexAttrib3fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glVertexAttrib3fARB != null)
            {
                glVertexAttrib3fARB(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3fvARB (GLuint index, const GLfloat *v);
        public unsafe static void VertexAttrib3fvARB(GLuint index, GLfloat[] v)
        {
            if (glVertexAttrib3fvARB != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertexAttrib3fvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3sARB (GLuint index, GLshort x, GLshort y, GLshort z);
        public static void VertexAttrib3sARB(GLuint index, GLshort x, GLshort y, GLshort z)
        {
            if (glVertexAttrib3sARB != null)
            {
                glVertexAttrib3sARB(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3svARB (GLuint index, const GLshort *v);
        public unsafe static void VertexAttrib3svARB(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib3svARB != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttrib3svARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4NbvARB (GLuint index, const GLbyte *v);
        public unsafe static void VertexAttrib4NbvARB(GLuint index, GLbyte[] v)
        {
            if (glVertexAttrib4NbvARB != null)
            {
                fixed (GLbyte* ptr_v = v)
                {
                    glVertexAttrib4NbvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4NivARB (GLuint index, const GLint *v);
        public unsafe static void VertexAttrib4NivARB(GLuint index, GLint[] v)
        {
            if (glVertexAttrib4NivARB != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertexAttrib4NivARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4NsvARB (GLuint index, const GLshort *v);
        public unsafe static void VertexAttrib4NsvARB(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib4NsvARB != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttrib4NsvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4NubARB (GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        public static void VertexAttrib4NubARB(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
        {
            if (glVertexAttrib4NubARB != null)
            {
                glVertexAttrib4NubARB(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4NubvARB (GLuint index, const GLubyte *v);
        public unsafe static void VertexAttrib4NubvARB(GLuint index, GLubyte[] v)
        {
            if (glVertexAttrib4NubvARB != null)
            {
                fixed (GLubyte* ptr_v = v)
                {
                    glVertexAttrib4NubvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4NuivARB (GLuint index, const GLuint *v);
        public unsafe static void VertexAttrib4NuivARB(GLuint index, GLuint[] v)
        {
            if (glVertexAttrib4NuivARB != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glVertexAttrib4NuivARB(index, ptr_v);
                }
            }
        }
        
        // GLAPI void APIENTRY glVertexAttrib4NusvARB (GLuint index, const GLushort *v);
        public unsafe static void VertexAttrib4NusvARB(GLuint index, GLushort[] v)
        {
            if (glVertexAttrib4NusvARB != null)
            {
                fixed (GLushort* ptr_v = v)
                {
                    glVertexAttrib4NusvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4bvARB (GLuint index, const GLbyte *v);
        public unsafe static void VertexAttrib4bvARB(GLuint index, GLbyte[] v)
        {
            if (glVertexAttrib4bvARB != null)
            {
                fixed (GLbyte* ptr_v = v)
                {
                    glVertexAttrib4bvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4dARB (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        public static void VertexAttrib4dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glVertexAttrib4dARB != null)
            {
                glVertexAttrib4dARB(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4dvARB (GLuint index, const GLdouble *v);
        public unsafe static void VertexAttrib4dvARB(GLuint index, GLdouble[] v)
        {
            if (glVertexAttrib4dvARB != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttrib4dvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4fARB (GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        public static void VertexAttrib4fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glVertexAttrib4fARB != null)
            {
                glVertexAttrib4fARB(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4fvARB (GLuint index, const GLfloat *v);
        public unsafe static void VertexAttrib4fvARB(GLuint index, GLfloat[] v)
        {
            if (glVertexAttrib4fvARB != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertexAttrib4fvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4ivARB (GLuint index, const GLint *v);
        public unsafe static void VertexAttrib4ivARB(GLuint index, GLint[] v)
        {
            if (glVertexAttrib4ivARB != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertexAttrib4ivARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4sARB (GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        public static void VertexAttrib4sARB(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
        {
            if (glVertexAttrib4sARB != null)
            {
                glVertexAttrib4sARB(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4svARB (GLuint index, const GLshort *v);
        public unsafe static void VertexAttrib4svARB(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib4svARB != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttrib4svARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4ubvARB (GLuint index, const GLubyte *v);
        public unsafe static void VertexAttrib4ubvARB(GLuint index, GLubyte[] v)
        {
            if (glVertexAttrib4ubvARB != null)
            {
                fixed (GLubyte* ptr_v = v)
                {
                    glVertexAttrib4ubvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4uivARB (GLuint index, const GLuint *v);
        public unsafe static void VertexAttrib4uivARB(GLuint index, GLuint[] v)
        {
            if (glVertexAttrib4uivARB != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glVertexAttrib4uivARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4usvARB (GLuint index, const GLushort *v);
        public unsafe static void VertexAttrib4usvARB(GLuint index, GLushort[] v)
        {
            if (glVertexAttrib4usvARB != null)
            {
                fixed (GLushort* ptr_v = v)
                {
                    glVertexAttrib4usvARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribPointerARB (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, const GLvoid *pointer);
        public unsafe static void VertexAttribPointerARB(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, IntPtr pointer)
        {
            if (glVertexAttribPointerARB != null)
            {
                glVertexAttribPointerARB(index, size, type, normalized, stride, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glEnableVertexAttribArrayARB (GLuint index);
        public static void EnableVertexAttribArrayARB(GLuint index)
        {
            if (glEnableVertexAttribArrayARB != null)
            {
                glEnableVertexAttribArrayARB(index);
            }
        }

        // GLAPI void APIENTRY glDisableVertexAttribArrayARB (GLuint index);
        public static void DisableVertexAttribArrayARB(GLuint index)
        {
            if (glDisableVertexAttribArrayARB != null)
            {
                glDisableVertexAttribArrayARB(index);
            }
        }

        // GLAPI void APIENTRY glProgramStringARB (GLenum target, GLenum format, GLsizei len, const GLvoid *string);
        public unsafe static void ProgramStringARB(GLenum target, GLenum format, GLsizei len, IntPtr programstring)
        {
            if (glProgramStringARB != null)
            {
                glProgramStringARB(target, format, len, programstring.ToPointer());
            }
        }

        // GLAPI void APIENTRY glBindProgramARB (GLenum target, GLuint program);
        public static void BindProgramARB(GLenum target, GLuint program)
        {
            if (glBindProgramARB != null)
            {
                glBindProgramARB(target, program);
            }
        }

        // GLAPI void APIENTRY glDeleteProgramsARB (GLsizei n, const GLuint *programs);
        public unsafe static void DeleteProgramsARB(GLsizei n, GLuint[] programs)
        {
            if (glDeleteProgramsARB != null)
            {
                fixed (GLuint* ptr_programs = programs)
                {
                    glDeleteProgramsARB(n, ptr_programs);
                }
            }
        }

        // GLAPI void APIENTRY glGenProgramsARB (GLsizei n, GLuint *programs);
        public unsafe static void GenProgramsARB(GLsizei n, GLuint[] programs)
        {
            if (glGenProgramsARB != null)
            {
                fixed (GLuint* ptr_programs = programs)
                {
                    glGenProgramsARB(n, ptr_programs);
                }
            }
        }

        // GLAPI void APIENTRY glProgramEnvParameter4dARB (GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        public static void ProgramEnvParameter4dARB(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glProgramEnvParameter4dARB != null)
            {
                glProgramEnvParameter4dARB(target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glProgramEnvParameter4dvARB (GLenum target, GLuint index, const GLdouble *params);
        public unsafe static void ProgramEnvParameter4dvARB(GLenum target, GLuint index, GLdouble[] parameters)
        {
            if (glProgramEnvParameter4dvARB != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glProgramEnvParameter4dvARB(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramEnvParameter4fARB (GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        public static void ProgramEnvParameter4fARB(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glProgramEnvParameter4fARB != null)
            {
                glProgramEnvParameter4fARB(target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glProgramEnvParameter4fvARB (GLenum target, GLuint index, const GLfloat *params);
        public unsafe static void ProgramEnvParameter4fvARB(GLenum target, GLuint index, GLfloat[] parameters)
        {
            if (glProgramEnvParameter4fvARB != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glProgramEnvParameter4fvARB(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramLocalParameter4dARB (GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        public static void ProgramLocalParameter4dARB(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glProgramLocalParameter4dARB != null)
            {
                glProgramLocalParameter4dARB(target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glProgramLocalParameter4dvARB (GLenum target, GLuint index, const GLdouble *params);
        public unsafe static void ProgramLocalParameter4dvARB(GLenum target, GLuint index, GLdouble[] parameters)
        {
            if (glProgramLocalParameter4dvARB != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glProgramLocalParameter4dvARB(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramLocalParameter4fARB (GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        public static void ProgramLocalParameter4fARB(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glProgramLocalParameter4fARB != null)
            {
                glProgramLocalParameter4fARB(target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glProgramLocalParameter4fvARB (GLenum target, GLuint index, const GLfloat *params);
        public unsafe static void ProgramLocalParameter4fvARB(GLenum target, GLuint index, GLfloat[] parameters)
        {
            if (glProgramLocalParameter4fvARB != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glProgramLocalParameter4fvARB(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramEnvParameterdvARB (GLenum target, GLuint index, GLdouble *params);
        public unsafe static void GetProgramEnvParameterdvARB(GLenum target, GLuint index, GLdouble[] parameters)
        {
            if (glGetProgramEnvParameterdvARB != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetProgramEnvParameterdvARB(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramEnvParameterfvARB (GLenum target, GLuint index, GLfloat *params);
        public unsafe static void GetProgramEnvParameterfvARB(GLenum target, GLuint index, GLfloat[] parameters)
        {
            if (glGetProgramEnvParameterfvARB != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetProgramEnvParameterfvARB(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramLocalParameterdvARB (GLenum target, GLuint index, GLdouble *params);
        public unsafe static void GetProgramLocalParameterdvARB(GLenum target, GLuint index, GLdouble[] parameters)
        {
            if (glGetProgramLocalParameterdvARB != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetProgramLocalParameterdvARB(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramLocalParameterfvARB (GLenum target, GLuint index, GLfloat *params);
        public unsafe static void GetProgramLocalParameterfvARB(GLenum target, GLuint index, GLfloat[] parameters)
        {
            if (glGetProgramLocalParameterfvARB != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetProgramLocalParameterfvARB(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramivARB (GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetProgramivARB(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetProgramivARB != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetProgramivARB(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramStringARB (GLenum target, GLenum pname, GLvoid *string);
        public unsafe static void GetProgramStringARB(GLenum target, GLenum pname, IntPtr programstring)
        {
            if (glGetProgramStringARB != null)
            {
                glGetProgramStringARB(target, pname, programstring.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribdvARB (GLuint index, GLenum pname, GLdouble *params);
        public unsafe static void GetVertexAttribdvARB(GLuint index, GLenum pname, GLdouble[] parameters)
        {
            if (glGetVertexAttribdvARB != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetVertexAttribdvARB(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribfvARB (GLuint index, GLenum pname, GLfloat *params);
        public unsafe static void GetVertexAttribfvARB(GLuint index, GLenum pname, GLfloat[] parameters)
        {
            if (glGetVertexAttribfvARB != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetVertexAttribfvARB(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribivARB (GLuint index, GLenum pname, GLint *params);
        public unsafe static void GetVertexAttribivARB(GLuint index, GLenum pname, GLint[] parameters)
        {
            if (glGetVertexAttribivARB != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetVertexAttribivARB(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribPointervARB (GLuint index, GLenum pname, GLvoid* *pointer);
        public unsafe static void GetVertexAttribPointervARB(GLuint index, GLenum pname, IntPtr[] pointer)
        {
            if (glGetVertexAttribPointervARB != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glGetVertexAttribPointervARB(index, pname, (void**)ptr_pointer);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsProgramARB (GLuint program);
        public static GLboolean IsProgramARB(GLuint program)
        {
            if (glIsProgramARB != null)
            {
                return glIsProgramARB(program);
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_program
        ///////////////////////////////////////////////////////////////////////
        /* All ARB_fragment_program entry points are shared with ARB_vertex_program. */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_buffer_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBindBufferARB (GLenum target, GLuint buffer);
        public static void BindBufferARB(GLenum target, GLuint buffer)
        {
            if (glBindBufferARB != null)
            {
                glBindBufferARB(target, buffer);
            }
        }

        // GLAPI void APIENTRY glDeleteBuffersARB (GLsizei n, const GLuint *buffers);
        public unsafe static void DeleteBuffersARB(GLsizei n, GLuint[] buffers)
        {
            if (glDeleteBuffersARB != null)
            {
                fixed (GLuint* ptr_buffers = buffers)
                {
                    glDeleteBuffersARB(n, ptr_buffers);
                }
            }
        }

        // GLAPI void APIENTRY glGenBuffersARB (GLsizei n, GLuint *buffers);
        public unsafe static void GenBuffersARB(GLsizei n, GLuint[] buffers)
        {
            if (glGenBuffersARB != null)
            {
                fixed (GLuint* ptr_buffers = buffers)
                {
                    glGenBuffersARB(n, ptr_buffers);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsBufferARB (GLuint buffer);
        public static GLboolean IsBufferARB(GLuint buffer)
        {
            if (glIsBufferARB != null)
            {
                return glIsBufferARB(buffer);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glBufferDataARB (GLenum target, GLsizeiptrARB size, const GLvoid *data, GLenum usage);
        public unsafe static void BufferDataARB(GLenum target, GLsizeiptr size, IntPtr data, GLenum usage)
        {
            if (glBufferDataARB != null)
            {
                glBufferDataARB(target, size, data.ToPointer(), usage);
            }
        }

        // GLAPI void APIENTRY glBufferSubDataARB (GLenum target, GLintptrARB offset, GLsizeiptrARB size, const GLvoid *data);
        public unsafe static void BufferSubDataARB(GLenum target, GLintptr offset, GLsizeiptr size, IntPtr data)
        {
            if (glBufferSubDataARB != null)
            {
                glBufferSubDataARB(target, offset, size, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetBufferSubDataARB (GLenum target, GLintptrARB offset, GLsizeiptrARB size, GLvoid *data);
        public unsafe static void GetBufferSubDataARB(GLenum target, GLintptr offset, GLsizeiptr size, IntPtr data)
        {
            if (glGetBufferSubDataARB != null)
            {
                glGetBufferSubDataARB(target, offset, size, data.ToPointer());
            }
        }

        // GLAPI GLvoid* APIENTRY glMapBufferARB (GLenum target, GLenum access);
        public unsafe static IntPtr MapBufferARB(GLenum target, GLenum access)
        {
            if (glMapBufferARB != null)
            {
                return (IntPtr)glMapBufferARB(target, access);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // GLAPI GLboolean APIENTRY glUnmapBufferARB (GLenum target);
        public static GLboolean UnmapBufferARB(GLenum target)
        {
            if (glUnmapBufferARB != null)
            {
                return glUnmapBufferARB(target);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glGetBufferParameterivARB (GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetBufferParameterivARB(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetBufferParameterivARB != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetBufferParameterivARB(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetBufferPointervARB (GLenum target, GLenum pname, GLvoid* *params);
        public unsafe static void GetBufferPointervARB(GLenum target, GLenum pname, IntPtr[] parameters)
        {
            if (glGetBufferPointervARB != null)
            {
                fixed (IntPtr* ptr_parameters = parameters)
                {
                    glGetBufferPointervARB(target, pname, (void**)ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_occlusion_query
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGenQueriesARB (GLsizei n, GLuint *ids);
        public unsafe static void GenQueriesARB (GLsizei n, GLuint[] ids)
        {
            if (glGenQueriesARB != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glGenQueriesARB(n, ptr_ids);
                }
            }
        }

        // GLAPI void APIENTRY glDeleteQueriesARB (GLsizei n, const GLuint *ids);
        public unsafe static void DeleteQueriesARB(GLsizei n, GLuint[] ids)
        {
            if (glDeleteQueriesARB != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glDeleteQueriesARB(n, ptr_ids);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsQueryARB (GLuint id);
        public static GLboolean IsQueryARB(GLuint id)
        {
            if (glIsQueryARB != null)
            {
                return glIsQueryARB(id);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glBeginQueryARB (GLenum target, GLuint id);
        public static void BeginQueryARB(GLenum target, GLuint id)
        {
            if (glBeginQueryARB != null)
            {
                glBeginQueryARB(target, id);
            }
        }

        // GLAPI void APIENTRY glEndQueryARB (GLenum target);
        public static void EndQueryARB(GLenum target)
        {
            if (glEndQueryARB != null)
            {
                glEndQueryARB(target);
            }
        }

        // GLAPI void APIENTRY glGetQueryivARB (GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetQueryivARB(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetQueryivARB != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetQueryivARB(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetQueryObjectivARB (GLuint id, GLenum pname, GLint *params);
        public unsafe static void GetQueryObjectivARB(GLuint id, GLenum pname, GLint[] parameters)
        {
            if (glGetQueryObjectivARB != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetQueryObjectivARB(id, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetQueryObjectuivARB (GLuint id, GLenum pname, GLuint *params);
        public unsafe static void GetQueryObjectuivARB(GLuint id, GLenum pname, GLuint[] parameters)
        {
            if (glGetQueryObjectuivARB != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetQueryObjectuivARB(id, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_objects
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDeleteObjectARB (GLhandleARB obj);
        public static void DeleteObjectARB(GLhandle obj)
        {
            if (glDeleteObjectARB != null)
            {
                glDeleteObjectARB(obj);
            }
        }

        // GLAPI GLhandleARB APIENTRY glGetHandleARB (GLenum pname);
        public static GLhandle GetHandleARB(GLenum pname)
        {
            if (glGetHandleARB != null)
            {
                return glGetHandleARB(pname);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glDetachObjectARB (GLhandleARB containerObj, GLhandleARB attachedObj);
        public static void DetachObjectARB(GLhandle containerObj, GLhandle attachedObj)
        {
            if (glDetachObjectARB != null)
            {
                glDetachObjectARB(containerObj, attachedObj);
            }
        }

        // GLAPI GLhandleARB APIENTRY glCreateShaderObjectARB (GLenum shaderType);
        public static GLhandle CreateShaderObjectARB(GLenum shaderType)
        {
            if (glCreateShaderObjectARB != null)
            {
                return glCreateShaderObjectARB(shaderType);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glShaderSourceARB (GLhandleARB shaderObj, GLsizei count, const GLcharARB* *string, const GLint *length);
        public unsafe static void ShaderSourceARB(GLhandle shaderObj, GLsizei count, string[] strings, GLint[] length)
        {
            if (glShaderSourceARB != null)
            {
                IntPtr strptrtable = BuildStringIntPtrTable(strings);

                fixed (GLint* ptr_length = length)
                {
                    glShaderSource(shaderObj, count, (GLchar**)strptrtable, ptr_length);
                }

                Marshal.FreeHGlobal(strptrtable);
            }
        }

        // GLAPI void APIENTRY glCompileShaderARB (GLhandleARB shaderObj);
        public static void CompileShaderARB (GLhandle shaderObj)
        {
            if (glCompileShaderARB != null)
            {
                glCompileShaderARB(shaderObj);
            }
        }

        // GLAPI GLhandleARB APIENTRY glCreateProgramObjectARB (void);
        public static GLhandle CreateProgramObjectARB()
        {
            if (glCreateProgramObjectARB != null)
            {
                return glCreateProgramObjectARB();
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glAttachObjectARB (GLhandleARB containerObj, GLhandleARB obj);
        public static void AttachObjectARB(GLhandle containerObj, GLhandle obj)
        {
            if (glAttachObjectARB != null)
            {
                glAttachObjectARB(containerObj, obj);
            }
        }

        // GLAPI void APIENTRY glLinkProgramARB (GLhandleARB programObj);
        public static void LinkProgramARB(GLhandle programObj)
        {
            if (glLinkProgramARB != null)
            {
                glLinkProgramARB(programObj);
            }
        }

        // GLAPI void APIENTRY glUseProgramObjectARB (GLhandleARB programObj);
        public static void UseProgramObjectARB(GLhandle programObj)
        {
            if (glUseProgramObjectARB != null)
            {
                glUseProgramObjectARB(programObj);
            }
        }

        // GLAPI void APIENTRY glValidateProgramARB (GLhandleARB programObj);
        public static void ValidateProgramARB(GLhandle programObj)
        {
            if (glValidateProgramARB != null)
            {
                glValidateProgramARB(programObj);
            }
        }

        // GLAPI void APIENTRY glUniform1fARB (GLint location, GLfloat v0);
        public static void Uniform1fARB(GLint location, GLfloat v0)
        {
            if (glUniform1fARB != null)
            {
                glUniform1fARB(location, v0);
            }
        }

        // GLAPI void APIENTRY glUniform2fARB (GLint location, GLfloat v0, GLfloat v1);
        public static void Uniform2fARB(GLint location, GLfloat v0, GLfloat v1)
        {
            if (glUniform2fARB != null)
            {
                glUniform2fARB(location, v0, v1);
            }
        }

        // GLAPI void APIENTRY glUniform3fARB (GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        public static void Uniform3fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
        {
            if (glUniform3fARB != null)
            {
                glUniform3fARB(location, v0, v1, v2);
            }
        }

        // GLAPI void APIENTRY glUniform4fARB (GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        public static void Uniform4fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
        {
            if (glUniform4fARB != null)
            {
                glUniform4fARB(location, v0, v1, v2, v3);
            }
        }

        // GLAPI void APIENTRY glUniform1iARB (GLint location, GLint v0);
        public static void Uniform1iARB(GLint location, GLint v0)
        {
            if (glUniform1iARB != null)
            {
                glUniform1iARB(location, v0);
            }
        }

        // GLAPI void APIENTRY glUniform2iARB (GLint location, GLint v0, GLint v1);
        public static void Uniform2iARB(GLint location, GLint v0, GLint v1)
        {
            if (glUniform2iARB != null)
            {
                glUniform2iARB(location, v0, v1);
            }
        }

        // GLAPI void APIENTRY glUniform3iARB (GLint location, GLint v0, GLint v1, GLint v2);
        public static void Uniform3iARB(GLint location, GLint v0, GLint v1, GLint v2)
        {
            if (glUniform3iARB != null)
            {
                glUniform3iARB(location, v0, v1, v2);
            }
        }

        // GLAPI void APIENTRY glUniform4iARB (GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        public static void Uniform4iARB(GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
        {
            if (glUniform4iARB != null)
            {
                glUniform4iARB(location, v0, v1, v2, v3);
            }
        }

        // GLAPI void APIENTRY glUniform1fvARB (GLint location, GLsizei count, const GLfloat *value);
        public unsafe static void Uniform1fvARB(GLint location, GLsizei count, GLfloat[] value)
        {
            if (glUniform1fvARB != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniform1fvARB(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform2fvARB (GLint location, GLsizei count, const GLfloat *value);
        public unsafe static void Uniform2fvARB(GLint location, GLsizei count, GLfloat[] value)
        {
            if (glUniform2fvARB != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniform2fvARB(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform3fvARB (GLint location, GLsizei count, const GLfloat *value);
        public unsafe static void Uniform3fvARB(GLint location, GLsizei count, GLfloat[] value)
        {
            if (glUniform3fvARB != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniform3fvARB(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform4fvARB (GLint location, GLsizei count, const GLfloat *value);
        public unsafe static void Uniform4fvARB(GLint location, GLsizei count, GLfloat[] value)
        {
            if (glUniform4fvARB != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniform4fvARB(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform1ivARB (GLint location, GLsizei count, const GLint *value);
        public unsafe static void Uniform1ivARB(GLint location, GLsizei count, GLint[] value)
        {
            if (glUniform1ivARB != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glUniform1ivARB(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform2ivARB (GLint location, GLsizei count, const GLint *value);
        public unsafe static void Uniform2ivARB(GLint location, GLsizei count, GLint[] value)
        {
            if (glUniform2ivARB != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glUniform2ivARB(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform3ivARB (GLint location, GLsizei count, const GLint *value);
        public unsafe static void Uniform3ivARB(GLint location, GLsizei count, GLint[] value)
        {
            if (glUniform3ivARB != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glUniform3ivARB(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform4ivARB (GLint location, GLsizei count, const GLint *value);
        public unsafe static void Uniform4ivARB(GLint location, GLsizei count, GLint[] value)
        {
            if (glUniform4ivARB != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glUniform4ivARB(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix2fvARB (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        public unsafe static void UniformMatrix2fvARB(GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glUniformMatrix2fvARB != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniformMatrix2fvARB(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix3fvARB (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        public unsafe static void UniformMatrix3fvARB(GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glUniformMatrix3fvARB != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniformMatrix3fvARB(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix4fvARB (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        public unsafe static void UniformMatrix4fvARB(GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glUniformMatrix4fvARB != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniformMatrix4fvARB(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glGetObjectParameterfvARB (GLhandleARB obj, GLenum pname, GLfloat *params);
        public unsafe static void GetObjectParameterfvARB(GLhandle obj, GLenum pname, GLfloat[] parameters)
        {
            if (glGetObjectParameterfvARB != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetObjectParameterfvARB(obj, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetObjectParameterivARB (GLhandleARB obj, GLenum pname, GLint *params);
        public unsafe static void GetObjectParameterivARB(GLhandle obj, GLenum pname, GLint[] parameters)
        {
            if (glGetObjectParameterivARB != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetObjectParameterivARB(obj, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetInfoLogARB (GLhandleARB obj, GLsizei maxLength, GLsizei *length, GLcharARB *infoLog);
        public unsafe static void GetInfoLogARB(GLhandle obj, GLsizei maxLength, GLsizei[] length, GLchar[] infoLog)
        {
            if (glGetInfoLogARB != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_infoLog = infoLog)
                    {
                        glGetInfoLogARB(obj, maxLength, ptr_length, ptr_infoLog);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetAttachedObjectsARB (GLhandleARB containerObj, GLsizei maxCount, GLsizei *count, GLhandleARB *obj);
        public unsafe static void GetAttachedObjectsARB(GLhandle containerObj, GLsizei maxCount, GLsizei[] count, GLhandle[] obj)
        {
            if (glGetAttachedObjectsARB != null)
            {
                fixed (GLsizei* ptr_count = count)
                {
                    fixed (GLhandle* ptr_obj = obj)
                    {
                        glGetAttachedObjectsARB(containerObj, maxCount, ptr_count, ptr_obj);
                    }
                }
            }
        }

        // GLAPI GLint APIENTRY glGetUniformLocationARB (GLhandleARB programObj, const GLcharARB *name);
        public static GLint GetUniformLocationARB(GLhandle programObj, string name)
        {
            if (glGetUniformLocationARB != null)
            {
                return glGetUniformLocationARB(programObj, name);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glGetActiveUniformARB (GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei *length, GLint *size, GLenum *type, GLcharARB *name);
        public unsafe static void GetActiveUniformARB(GLhandle programObj, GLuint index, GLsizei maxLength, GLsizei[] length, GLint[] size, GLenum[] type, GLchar[] name)
        {
            if (glGetActiveUniformARB != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLint* ptr_size = size)
                    {
                        fixed (GLenum* ptr_type = type)
                        {
                            fixed (GLchar* ptr_name = name)
                            {
                                glGetActiveUniformARB(programObj, index, maxLength, ptr_length, ptr_size, ptr_type, ptr_name);
                            }
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetUniformfvARB (GLhandleARB programObj, GLint location, GLfloat *params);
        public unsafe static void GetUniformfvARB(GLhandle programObj, GLint location, GLfloat[] parameters)
        {
            if (glGetUniformfvARB != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetUniformfvARB(programObj, location, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetUniformivARB (GLhandleARB programObj, GLint location, GLint *params);
        public unsafe static void GetUniformivARB(GLhandle programObj, GLint location, GLint[] parameters)
        {
            if (glGetUniformivARB != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetUniformivARB(programObj, location, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetShaderSourceARB (GLhandleARB obj, GLsizei maxLength, GLsizei *length, GLcharARB *source);
        public unsafe static void GetShaderSourceARB(GLhandle obj, GLsizei maxLength, GLsizei[] length, GLchar[] source)
        {
            if (glGetShaderSourceARB != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_source = source)
                    {
                        glGetShaderSourceARB(obj, maxLength, ptr_length, ptr_source);
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_shader
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBindAttribLocationARB (GLhandleARB programObj, GLuint index, const GLcharARB *name);
        public unsafe static void BindAttribLocationARB(GLhandle programObj, GLuint index, string name)
        {
            if (glBindAttribLocationARB != null)
            {
                glBindAttribLocationARB(programObj, index, name);
            }
        }

        // GLAPI void APIENTRY glGetActiveAttribARB (GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei *length, GLint *size, GLenum *type, GLcharARB *name);
        public unsafe static void GetActiveAttribARB(GLhandle programObj, GLuint index, GLsizei maxLength, GLsizei[] length, GLint[] size, GLenum[] type, GLchar[] name)
        {
            if (glGetActiveAttribARB != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLint* ptr_size = size)
                    {
                        fixed (GLenum* ptr_type = type)
                        {
                            fixed (GLchar* ptr_name = name)
                            {
                                glGetActiveAttribARB(programObj, index, maxLength, ptr_length, ptr_size, ptr_type, ptr_name);
                            }
                        }
                    }
                }
            }
        }

        // GLAPI GLint APIENTRY glGetAttribLocationARB (GLhandleARB programObj, const GLcharARB *name);
        public static GLint GetAttribLocationARB(GLhandle programObj, string name)
        {
            if (glGetAttribLocationARB != null)
            {
                return glGetAttribLocationARB(programObj, name);
            }
            else
            {
                return 0;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_shader (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shading_language_100 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_non_power_of_two (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_point_sprite (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_program_shadow (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_draw_buffers 
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDrawBuffersARB (GLsizei n, const GLenum *bufs);
        public unsafe static void DrawBuffersARB(GLsizei n, GLenum[] bufs)
        {
            if (glDrawBuffersARB != null)
            {
                fixed (GLenum* ptr_bufs = bufs)
                {
                    glDrawBuffersARB(n, ptr_bufs);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_rectangle (no function entry points) 
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_color_buffer_float
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glClampColorARB (GLenum target, GLenum clamp);
        public static void ClampColorARB(GLenum target, GLenum clamp)
        {
            if (glClampColorARB != null)
            {
                glClampColorARB(target, clamp);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_half_float_pixel (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_float (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_pixel_buffer_object (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_depth_buffer_float (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_draw_instanced
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDrawArraysInstancedARB (GLenum mode, GLint first, GLsizei count, GLsizei primcount);
        public static void DrawArraysInstancedARB(GLenum mode, GLint first, GLsizei count, GLsizei primcount)
        {
            if (glDrawArraysInstancedARB != null)
            {
                glDrawArraysInstancedARB(mode, first, count, primcount);
            }
        }

        // GLAPI void APIENTRY glDrawElementsInstancedARB (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLsizei primcount);
        public unsafe static void DrawElementsInstancedARB(GLenum mode, GLsizei count, GLenum type, IntPtr indices, GLsizei primcount)
        {
            if (glDrawElementsInstancedARB != null)
            {
                glDrawElementsInstancedARB(mode, count, type, indices.ToPointer(), primcount);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_framebuffer_object
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL v3.0 - No delegates defined */
        // GLAPI GLboolean APIENTRY glIsRenderbuffer (GLuint renderbuffer);
        // GLAPI void APIENTRY glBindRenderbuffer (GLenum target, GLuint renderbuffer);
        // GLAPI void APIENTRY glDeleteRenderbuffers (GLsizei n, const GLuint *renderbuffers);
        // GLAPI void APIENTRY glGenRenderbuffers (GLsizei n, GLuint *renderbuffers);
        // GLAPI void APIENTRY glRenderbufferStorage (GLenum target, GLenum internalformat, GLsizei width, GLsizei height);
        // GLAPI void APIENTRY glGetRenderbufferParameteriv (GLenum target, GLenum pname, GLint *params);
        // GLAPI GLboolean APIENTRY glIsFramebuffer (GLuint framebuffer);
        // GLAPI void APIENTRY glBindFramebuffer (GLenum target, GLuint framebuffer);
        // GLAPI void APIENTRY glDeleteFramebuffers (GLsizei n, const GLuint *framebuffers);
        // GLAPI void APIENTRY glGenFramebuffers (GLsizei n, GLuint *framebuffers);
        // GLAPI GLenum APIENTRY glCheckFramebufferStatus (GLenum target);
        // GLAPI void APIENTRY glFramebufferTexture1D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        // GLAPI void APIENTRY glFramebufferTexture2D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        // GLAPI void APIENTRY glFramebufferTexture3D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);
        // GLAPI void APIENTRY glFramebufferRenderbuffer (GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
        // GLAPI void APIENTRY glGetFramebufferAttachmentParameteriv (GLenum target, GLenum attachment, GLenum pname, GLint *params);
        // GLAPI void APIENTRY glGenerateMipmap (GLenum target);
        // GLAPI void APIENTRY glBlitFramebuffer (GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);
        // GLAPI void APIENTRY glRenderbufferStorageMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
        // GLAPI void APIENTRY glFramebufferTextureLayer (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_framebuffer_sRGB (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_geometry_shader4
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glProgramParameteriARB (GLuint program, GLenum pname, GLint value);
        public static void ProgramParameteriARB(GLuint program, GLenum pname, GLint value)
        {
            if (glProgramParameteriARB != null)
            {
                glProgramParameteriARB(program, pname, value);
            }
        }

        // GLAPI void APIENTRY glFramebufferTextureARB (GLenum target, GLenum attachment, GLuint texture, GLint level);
        public static void FramebufferTextureARB(GLenum target, GLenum attachment, GLuint texture, GLint level)
        {
            if (glFramebufferTextureARB != null)
            {
                glFramebufferTextureARB(target, attachment, texture, level);
            }
        }

        // GLAPI void APIENTRY glFramebufferTextureLayerARB (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);
        public static void FramebufferTextureLayerARB(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)
        {
            if (glFramebufferTextureLayerARB != null)
            {
                glFramebufferTextureLayerARB(target, attachment, texture, level, layer);
            }
        }

        // GLAPI void APIENTRY glFramebufferTextureFaceARB (GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face);
        public static void FramebufferTextureFaceARB(GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face)
        {
            if (glFramebufferTextureFaceARB != null)
            {
                glFramebufferTextureFaceARB(target, attachment, texture, level, face);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_half_float_vertex (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_instanced_arrays
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexAttribDivisorARB (GLuint index, GLuint divisor);
        public static void VertexAttribDivisorARB(GLuint index, GLuint divisor)
        {
            if (glVertexAttribDivisorARB != null)
            {
                glVertexAttribDivisorARB(index, divisor);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_map_buffer_range
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.0 - No delegates defined */
        // GLAPI GLvoid* APIENTRY glMapBufferRange (GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access);
        // GLAPI void APIENTRY glFlushMappedBufferRange (GLenum target, GLintptr offset, GLsizeiptr length);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_buffer_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexBufferARB (GLenum target, GLenum internalformat, GLuint buffer);
        public static void TexBufferARB(GLenum target, GLenum internalformat, GLuint buffer)
        {
            if (glTexBufferARB != null)
            {
                glTexBufferARB(target, internalformat, buffer);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_compression_rgtc (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_rg (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_array_object
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.0 - No delegates defined */
        // GLAPI void APIENTRY glBindVertexArray (GLuint array);
        // GLAPI void APIENTRY glDeleteVertexArrays (GLsizei n, const GLuint *arrays);
        // GLAPI void APIENTRY glGenVertexArrays (GLsizei n, GLuint *arrays);
        // GLAPI GLboolean APIENTRY glIsVertexArray (GLuint array);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_uniform_buffer_object
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.1 - No delegates defined */
        // GLAPI void APIENTRY glGetUniformIndices (GLuint program, GLsizei uniformCount, const GLchar* const *uniformNames, GLuint *uniformIndices);
        // GLAPI void APIENTRY glGetActiveUniformsiv (GLuint program, GLsizei uniformCount, const GLuint *uniformIndices, GLenum pname, GLint *params);
        // GLAPI void APIENTRY glGetActiveUniformName (GLuint program, GLuint uniformIndex, GLsizei bufSize, GLsizei *length, GLchar *uniformName);
        // GLAPI GLuint APIENTRY glGetUniformBlockIndex (GLuint program, const GLchar *uniformBlockName);
        // GLAPI void APIENTRY glGetActiveUniformBlockiv (GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint *params);
        // GLAPI void APIENTRY glGetActiveUniformBlockName (GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei *length, GLchar *uniformBlockName);
        // GLAPI void APIENTRY glUniformBlockBinding (GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_compatibility (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_copy_buffer
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.1 - No delegates defined */
        // GLAPI void APIENTRY glCopyBufferSubData (GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_texture_lod (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_depth_clamp (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_draw_elements_base_vertex
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.2 - No delegates defined */
        // GLAPI void APIENTRY glDrawElementsBaseVertex (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLint basevertex);
        // GLAPI void APIENTRY glDrawRangeElementsBaseVertex (GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, const GLvoid *indices, GLint basevertex);
        // GLAPI void APIENTRY glDrawElementsInstancedBaseVertex (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLsizei instancecount, GLint basevertex);
        // GLAPI void APIENTRY glMultiDrawElementsBaseVertex (GLenum mode, const GLsizei *count, GLenum type, const GLvoid* const *indices, GLsizei drawcount, const GLint *basevertex);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_coord_conventions (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_provoking_vertex
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.2 - No delegates defined */
        // GLAPI void APIENTRY glProvokingVertex (GLenum mode);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_seamless_cube_map (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sync
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.2 - No delegates defined */
        // GLAPI GLsync APIENTRY glFenceSync (GLenum condition, GLbitfield flags);
        // GLAPI GLboolean APIENTRY glIsSync (GLsync sync);
        // GLAPI void APIENTRY glDeleteSync (GLsync sync);
        // GLAPI GLenum APIENTRY glClientWaitSync (GLsync sync, GLbitfield flags, GLuint64 timeout);
        // GLAPI void APIENTRY glWaitSync (GLsync sync, GLbitfield flags, GLuint64 timeout);
        // GLAPI void APIENTRY glGetInteger64v (GLenum pname, GLint64 *params);
        // GLAPI void APIENTRY glGetSynciv (GLsync sync, GLenum pname, GLsizei bufSize, GLsizei *length, GLint *values);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_multisample
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.2 - No delegates defined */
        // GLAPI void APIENTRY glTexImage2DMultisample (GLenum target, GLsizei samples, GLint internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);
        // GLAPI void APIENTRY glTexImage3DMultisample (GLenum target, GLsizei samples, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);
        // GLAPI void APIENTRY glGetMultisamplefv (GLenum pname, GLuint index, GLfloat *val);
        // GLAPI void APIENTRY glSampleMaski (GLuint index, GLbitfield mask);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_array_bgra (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_draw_buffers_blend
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendEquationiARB (GLuint buf, GLenum mode);
        public static void BlendEquationiARB(GLuint buf, GLenum mode)
        {
            if (glBlendEquationiARB != null)
            {
                glBlendEquationiARB(buf, mode);
            }
        }

        // GLAPI void APIENTRY glBlendEquationSeparateiARB (GLuint buf, GLenum modeRGB, GLenum modeAlpha);
        public static void BlendEquationSeparateiARB(GLuint buf, GLenum modeRGB, GLenum modeAlpha)
        {
            if (glBlendEquationSeparateiARB != null)
            {
                glBlendEquationSeparateiARB(buf, modeRGB, modeAlpha);
            }
        }

        // GLAPI void APIENTRY glBlendFunciARB (GLuint buf, GLenum src, GLenum dst);
        public static void BlendFunciARB(GLuint buf, GLenum src, GLenum dst)
        {
            if (glBlendFunciARB != null)
            {
                glBlendFunciARB(buf, src, dst);
            }
        }

        // GLAPI void APIENTRY glBlendFuncSeparateiARB (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);
        public static void BlendFuncSeparateiARB(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha)
        {
            if (glBlendFuncSeparateiARB != null)
            {
                glBlendFuncSeparateiARB(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sample_shading
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMinSampleShadingARB (GLfloat value);
        public static void MinSampleShadingARB(GLfloat value)
        {
            if (glMinSampleShadingARB != null)
            {
                glMinSampleShadingARB(value);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_cube_map_array (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_gather (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_query_lod (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shading_language_include
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glNamedStringARB (GLenum type, GLint namelen, const GLchar *name, GLint stringlen, const GLchar *string);
        public static void NamedStringARB (GLenum type, GLint namelen, string name, GLint stringlen, string str)
        {
            if (glNamedStringARB != null)
            {
                glNamedStringARB(type, namelen, name, stringlen, str);
            }
        }

        // GLAPI void APIENTRY glDeleteNamedStringARB (GLint namelen, const GLchar *name);
        public static void DeleteNamedStringARB (GLint namelen, string name)
        {
            if (glDeleteNamedStringARB != null)
            {
                glDeleteNamedStringARB(namelen, name);
            }
        }

        // GLAPI void APIENTRY glCompileShaderIncludeARB (GLuint shader, GLsizei count, const GLchar* *path, const GLint *length);
        public unsafe static void CompileShaderIncludeARB (GLuint shader, GLsizei count, string[] path, GLint[] length)
        {
            if (glCompileShaderIncludeARB != null)
            {
                IntPtr strptrtable = BuildStringIntPtrTable(path);

                fixed (GLint* ptr_length = length)
                {
                    glCompileShaderIncludeARB(shader, count, (GLchar**)strptrtable, ptr_length);
                }

                Marshal.FreeHGlobal(strptrtable);
            }
        }

        // GLAPI GLboolean APIENTRY glIsNamedStringARB (GLint namelen, const GLchar *name);
        public static GLboolean IsNamedStringARB (GLint namelen, string name)
        {
            if (glIsNamedStringARB != null)
            {
                return glIsNamedStringARB(namelen, name);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glGetNamedStringARB (GLint namelen, const GLchar *name, GLsizei bufSize, GLint *stringlen, GLchar *string);
        public unsafe static void GetNamedStringARB (GLint namelen, string name, GLsizei bufSize, GLint[] stringlen, GLchar[] str)
        {
            if (glGetNamedStringARB != null)
            {
                fixed (GLint* ptr_stringlen = stringlen)
                {
                    fixed (GLchar* ptr_str = str)
                    {
                        glGetNamedStringARB(namelen, name, bufSize, ptr_stringlen, ptr_str);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetNamedStringivARB (GLint namelen, const GLchar *name, GLenum pname, GLint *params);
        public unsafe static void GetNamedStringivARB (GLint namelen, string name, GLenum pname, GLint[] parameters)
        {
            if (glGetNamedStringivARB != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetNamedStringivARB(namelen, name, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_compression_bptc (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_blend_func_extended
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3 - No delegates defined */
        // GLAPI void APIENTRY glBindFragDataLocationIndexed (GLuint program, GLuint colorNumber, GLuint index, const GLchar *name);
        // GLAPI GLint APIENTRY glGetFragDataIndex (GLuint program, const GLchar *name);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_explicit_attrib_location (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_blend_func_extended (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sampler_objects
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3 - No delegates defined */
        // GLAPI void APIENTRY glGenSamplers (GLsizei count, GLuint *samplers);
        // GLAPI void APIENTRY glDeleteSamplers (GLsizei count, const GLuint *samplers);
        // GLAPI GLboolean APIENTRY glIsSampler (GLuint sampler);
        // GLAPI void APIENTRY glBindSampler (GLuint unit, GLuint sampler);
        // GLAPI void APIENTRY glSamplerParameteri (GLuint sampler, GLenum pname, GLint param);
        // GLAPI void APIENTRY glSamplerParameteriv (GLuint sampler, GLenum pname, const GLint *param);
        // GLAPI void APIENTRY glSamplerParameterf (GLuint sampler, GLenum pname, GLfloat param);
        // GLAPI void APIENTRY glSamplerParameterfv (GLuint sampler, GLenum pname, const GLfloat *param);
        // GLAPI void APIENTRY glSamplerParameterIiv (GLuint sampler, GLenum pname, const GLint *param);
        // GLAPI void APIENTRY glSamplerParameterIuiv (GLuint sampler, GLenum pname, const GLuint *param);
        // GLAPI void APIENTRY glGetSamplerParameteriv (GLuint sampler, GLenum pname, GLint *params);
        // GLAPI void APIENTRY glGetSamplerParameterIiv (GLuint sampler, GLenum pname, GLint *params);
        // GLAPI void APIENTRY glGetSamplerParameterfv (GLuint sampler, GLenum pname, GLfloat *params);
        // GLAPI void APIENTRY glGetSamplerParameterIuiv (GLuint sampler, GLenum pname, GLuint *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_bit_encoding (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_rgb10_a2ui (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_swizzle (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_timer_query
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3 - No delegates defined */
        // GLAPI void APIENTRY glQueryCounter (GLuint id, GLenum target);
        // GLAPI void APIENTRY glGetQueryObjecti64v (GLuint id, GLenum pname, GLint64 *params);
        // GLAPI void APIENTRY glGetQueryObjectui64v (GLuint id, GLenum pname, GLuint64 *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_type_2_10_10_10_rev
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3 - No delegates defined */
        // GLAPI void APIENTRY glVertexP2ui (GLenum type, GLuint value);
        // GLAPI void APIENTRY glVertexP2uiv (GLenum type, const GLuint *value);
        // GLAPI void APIENTRY glVertexP3ui (GLenum type, GLuint value);
        // GLAPI void APIENTRY glVertexP3uiv (GLenum type, const GLuint *value);
        // GLAPI void APIENTRY glVertexP4ui (GLenum type, GLuint value);
        // GLAPI void APIENTRY glVertexP4uiv (GLenum type, const GLuint *value);
        // GLAPI void APIENTRY glTexCoordP1ui (GLenum type, GLuint coords);
        // GLAPI void APIENTRY glTexCoordP1uiv (GLenum type, const GLuint *coords);
        // GLAPI void APIENTRY glTexCoordP2ui (GLenum type, GLuint coords);
        // GLAPI void APIENTRY glTexCoordP2uiv (GLenum type, const GLuint *coords);
        // GLAPI void APIENTRY glTexCoordP3ui (GLenum type, GLuint coords);
        // GLAPI void APIENTRY glTexCoordP3uiv (GLenum type, const GLuint *coords);
        // GLAPI void APIENTRY glTexCoordP4ui (GLenum type, GLuint coords);
        // GLAPI void APIENTRY glTexCoordP4uiv (GLenum type, const GLuint *coords);
        // GLAPI void APIENTRY glMultiTexCoordP1ui (GLenum texture, GLenum type, GLuint coords);
        // GLAPI void APIENTRY glMultiTexCoordP1uiv (GLenum texture, GLenum type, const GLuint *coords);
        // GLAPI void APIENTRY glMultiTexCoordP2ui (GLenum texture, GLenum type, GLuint coords);
        // GLAPI void APIENTRY glMultiTexCoordP2uiv (GLenum texture, GLenum type, const GLuint *coords);
        // GLAPI void APIENTRY glMultiTexCoordP3ui (GLenum texture, GLenum type, GLuint coords);
        // GLAPI void APIENTRY glMultiTexCoordP3uiv (GLenum texture, GLenum type, const GLuint *coords);
        // GLAPI void APIENTRY glMultiTexCoordP4ui (GLenum texture, GLenum type, GLuint coords);
        // GLAPI void APIENTRY glMultiTexCoordP4uiv (GLenum texture, GLenum type, const GLuint *coords);
        // GLAPI void APIENTRY glNormalP3ui (GLenum type, GLuint coords);
        // GLAPI void APIENTRY glNormalP3uiv (GLenum type, const GLuint *coords);
        // GLAPI void APIENTRY glColorP3ui (GLenum type, GLuint color);
        // GLAPI void APIENTRY glColorP3uiv (GLenum type, const GLuint *color);
        // GLAPI void APIENTRY glColorP4ui (GLenum type, GLuint color);
        // GLAPI void APIENTRY glColorP4uiv (GLenum type, const GLuint *color);
        // GLAPI void APIENTRY glSecondaryColorP3ui (GLenum type, GLuint color);
        // GLAPI void APIENTRY glSecondaryColorP3uiv (GLenum type, const GLuint *color);
        // GLAPI void APIENTRY glVertexAttribP1ui (GLuint index, GLenum type, GLboolean normalized, GLuint value);
        // GLAPI void APIENTRY glVertexAttribP1uiv (GLuint index, GLenum type, GLboolean normalized, const GLuint *value);
        // GLAPI void APIENTRY glVertexAttribP2ui (GLuint index, GLenum type, GLboolean normalized, GLuint value);
        // GLAPI void APIENTRY glVertexAttribP2uiv (GLuint index, GLenum type, GLboolean normalized, const GLuint *value);
        // GLAPI void APIENTRY glVertexAttribP3ui (GLuint index, GLenum type, GLboolean normalized, GLuint value);
        // GLAPI void APIENTRY glVertexAttribP3uiv (GLuint index, GLenum type, GLboolean normalized, const GLuint *value);
        // GLAPI void APIENTRY glVertexAttribP4ui (GLuint index, GLenum type, GLboolean normalized, GLuint value);
        // GLAPI void APIENTRY glVertexAttribP4uiv (GLuint index, GLenum type, GLboolean normalized, const GLuint *value);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_draw_indirect
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0 - No delegates defined */
        // GLAPI void APIENTRY glDrawArraysIndirect (GLenum mode, const GLvoid *indirect);
        // GLAPI void APIENTRY glDrawElementsIndirect (GLenum mode, GLenum type, const GLvoid *indirect);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_gpu_shader5 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_gpu_shader_fp64 (no function entry points)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0 - No delegates defined */
        // GLAPI void APIENTRY glUniform1d (GLint location, GLdouble x);
        // GLAPI void APIENTRY glUniform2d (GLint location, GLdouble x, GLdouble y);
        // GLAPI void APIENTRY glUniform3d (GLint location, GLdouble x, GLdouble y, GLdouble z);
        // GLAPI void APIENTRY glUniform4d (GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        // GLAPI void APIENTRY glUniform1dv (GLint location, GLsizei count, const GLdouble *value);
        // GLAPI void APIENTRY glUniform2dv (GLint location, GLsizei count, const GLdouble *value);
        // GLAPI void APIENTRY glUniform3dv (GLint location, GLsizei count, const GLdouble *value);
        // GLAPI void APIENTRY glUniform4dv (GLint location, GLsizei count, const GLdouble *value);
        // GLAPI void APIENTRY glUniformMatrix2dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glUniformMatrix3dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glUniformMatrix4dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glUniformMatrix2x3dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glUniformMatrix2x4dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glUniformMatrix3x2dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glUniformMatrix3x4dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glUniformMatrix4x2dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glUniformMatrix4x3dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glGetUniformdv (GLuint program, GLint location, GLdouble *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_subroutine
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0 - No delegates defined */
        // GLAPI GLint APIENTRY glGetSubroutineUniformLocation (GLuint program, GLenum shadertype, const GLchar *name);
        // GLAPI GLuint APIENTRY glGetSubroutineIndex (GLuint program, GLenum shadertype, const GLchar *name);
        // GLAPI void APIENTRY glGetActiveSubroutineUniformiv (GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint *values);
        // GLAPI void APIENTRY glGetActiveSubroutineUniformName (GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei *length, GLchar *name);
        // GLAPI void APIENTRY glGetActiveSubroutineName (GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei *length, GLchar *name);
        // GLAPI void APIENTRY glUniformSubroutinesuiv (GLenum shadertype, GLsizei count, const GLuint *indices);
        // GLAPI void APIENTRY glGetUniformSubroutineuiv (GLenum shadertype, GLint location, GLuint *params);
        // GLAPI void APIENTRY glGetProgramStageiv (GLuint program, GLenum shadertype, GLenum pname, GLint *values);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_tessellation_shader
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0 - No delegates defined */
        // GLAPI void APIENTRY glPatchParameteri (GLenum pname, GLint value);
        // GLAPI void APIENTRY glPatchParameterfv (GLenum pname, const GLfloat *values);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_buffer_object_rgb32
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_transform_feedback2
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0 - No delegates defined */
        // GLAPI void APIENTRY glBindTransformFeedback (GLenum target, GLuint id);
        // GLAPI void APIENTRY glDeleteTransformFeedbacks (GLsizei n, const GLuint *ids);
        // GLAPI void APIENTRY glGenTransformFeedbacks (GLsizei n, GLuint *ids);
        // GLAPI GLboolean APIENTRY glIsTransformFeedback (GLuint id);
        // GLAPI void APIENTRY glPauseTransformFeedback (void);
        // GLAPI void APIENTRY glResumeTransformFeedback (void);
        // GLAPI void APIENTRY glDrawTransformFeedback (GLenum mode, GLuint id);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_transform_feedback3
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0 - No delegates defined */
        // GLAPI void APIENTRY glDrawTransformFeedbackStream (GLenum mode, GLuint id, GLuint stream);
        // GLAPI void APIENTRY glBeginQueryIndexed (GLenum target, GLuint index, GLuint id);
        // GLAPI void APIENTRY glEndQueryIndexed (GLenum target, GLuint index);
        // GLAPI void APIENTRY glGetQueryIndexediv (GLenum target, GLuint index, GLenum pname, GLint *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_ES2_compatibility
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1 - No delegates defined */
        // GLAPI void APIENTRY glReleaseShaderCompiler (void);
        // GLAPI void APIENTRY glShaderBinary (GLsizei count, const GLuint *shaders, GLenum binaryformat, const GLvoid *binary, GLsizei length);
        // GLAPI void APIENTRY glGetShaderPrecisionFormat (GLenum shadertype, GLenum precisiontype, GLint *range, GLint *precision);
        // GLAPI void APIENTRY glDepthRangef (GLfloat n, GLfloat f);
        // GLAPI void APIENTRY glClearDepthf (GLfloat d);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_get_program_binary
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1 - No delegates defined */
        // GLAPI void APIENTRY glGetProgramBinary (GLuint program, GLsizei bufSize, GLsizei *length, GLenum *binaryFormat, GLvoid *binary);
        // GLAPI void APIENTRY glProgramBinary (GLuint program, GLenum binaryFormat, const GLvoid *binary, GLsizei length);
        // GLAPI void APIENTRY glProgramParameteri (GLuint program, GLenum pname, GLint value);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_separate_shader_objects
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1 - No delegates defined */
        // GLAPI void APIENTRY glUseProgramStages (GLuint pipeline, GLbitfield stages, GLuint program);
        // GLAPI void APIENTRY glActiveShaderProgram (GLuint pipeline, GLuint program);
        // GLAPI GLuint APIENTRY glCreateShaderProgramv (GLenum type, GLsizei count, const GLchar* const *strings);
        // GLAPI void APIENTRY glBindProgramPipeline (GLuint pipeline);
        // GLAPI void APIENTRY glDeleteProgramPipelines (GLsizei n, const GLuint *pipelines);
        // GLAPI void APIENTRY glGenProgramPipelines (GLsizei n, GLuint *pipelines);
        // GLAPI GLboolean APIENTRY glIsProgramPipeline (GLuint pipeline);
        // GLAPI void APIENTRY glGetProgramPipelineiv (GLuint pipeline, GLenum pname, GLint *params);
        // GLAPI void APIENTRY glProgramUniform1i (GLuint program, GLint location, GLint v0);
        // GLAPI void APIENTRY glProgramUniform1iv (GLuint program, GLint location, GLsizei count, const GLint *value);
        // GLAPI void APIENTRY glProgramUniform1f (GLuint program, GLint location, GLfloat v0);
        // GLAPI void APIENTRY glProgramUniform1fv (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        // GLAPI void APIENTRY glProgramUniform1d (GLuint program, GLint location, GLdouble v0);
        // GLAPI void APIENTRY glProgramUniform1dv (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        // GLAPI void APIENTRY glProgramUniform1ui (GLuint program, GLint location, GLuint v0);
        // GLAPI void APIENTRY glProgramUniform1uiv (GLuint program, GLint location, GLsizei count, const GLuint *value);
        // GLAPI void APIENTRY glProgramUniform2i (GLuint program, GLint location, GLint v0, GLint v1);
        // GLAPI void APIENTRY glProgramUniform2iv (GLuint program, GLint location, GLsizei count, const GLint *value);
        // GLAPI void APIENTRY glProgramUniform2f (GLuint program, GLint location, GLfloat v0, GLfloat v1);
        // GLAPI void APIENTRY glProgramUniform2fv (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        // GLAPI void APIENTRY glProgramUniform2d (GLuint program, GLint location, GLdouble v0, GLdouble v1);
        // GLAPI void APIENTRY glProgramUniform2dv (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        // GLAPI void APIENTRY glProgramUniform2ui (GLuint program, GLint location, GLuint v0, GLuint v1);
        // GLAPI void APIENTRY glProgramUniform2uiv (GLuint program, GLint location, GLsizei count, const GLuint *value);
        // GLAPI void APIENTRY glProgramUniform3i (GLuint program, GLint location, GLint v0, GLint v1, GLint v2);
        // GLAPI void APIENTRY glProgramUniform3iv (GLuint program, GLint location, GLsizei count, const GLint *value);
        // GLAPI void APIENTRY glProgramUniform3f (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        // GLAPI void APIENTRY glProgramUniform3fv (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        // GLAPI void APIENTRY glProgramUniform3d (GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2);
        // GLAPI void APIENTRY glProgramUniform3dv (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        // GLAPI void APIENTRY glProgramUniform3ui (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2);
        // GLAPI void APIENTRY glProgramUniform3uiv (GLuint program, GLint location, GLsizei count, const GLuint *value);
        // GLAPI void APIENTRY glProgramUniform4i (GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        // GLAPI void APIENTRY glProgramUniform4iv (GLuint program, GLint location, GLsizei count, const GLint *value);
        // GLAPI void APIENTRY glProgramUniform4f (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        // GLAPI void APIENTRY glProgramUniform4fv (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        // GLAPI void APIENTRY glProgramUniform4d (GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2, GLdouble v3);
        // GLAPI void APIENTRY glProgramUniform4dv (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        // GLAPI void APIENTRY glProgramUniform4ui (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
        // GLAPI void APIENTRY glProgramUniform4uiv (GLuint program, GLint location, GLsizei count, const GLuint *value);
        // GLAPI void APIENTRY glProgramUniformMatrix2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        // GLAPI void APIENTRY glProgramUniformMatrix3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        // GLAPI void APIENTRY glProgramUniformMatrix4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        // GLAPI void APIENTRY glProgramUniformMatrix2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glProgramUniformMatrix3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glProgramUniformMatrix4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glProgramUniformMatrix2x3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        // GLAPI void APIENTRY glProgramUniformMatrix3x2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        // GLAPI void APIENTRY glProgramUniformMatrix2x4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        // GLAPI void APIENTRY glProgramUniformMatrix4x2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        // GLAPI void APIENTRY glProgramUniformMatrix3x4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        // GLAPI void APIENTRY glProgramUniformMatrix4x3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        // GLAPI void APIENTRY glProgramUniformMatrix2x3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glProgramUniformMatrix3x2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glProgramUniformMatrix2x4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glProgramUniformMatrix4x2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glProgramUniformMatrix3x4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glProgramUniformMatrix4x3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        // GLAPI void APIENTRY glValidateProgramPipeline (GLuint pipeline);
        // GLAPI void APIENTRY glGetProgramPipelineInfoLog (GLuint pipeline, GLsizei bufSize, GLsizei *length, GLchar *infoLog);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_attrib_64bit
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1 - No delegates defined */
        // GLAPI void APIENTRY glVertexAttribL1d (GLuint index, GLdouble x);
        // GLAPI void APIENTRY glVertexAttribL2d (GLuint index, GLdouble x, GLdouble y);
        // GLAPI void APIENTRY glVertexAttribL3d (GLuint index, GLdouble x, GLdouble y, GLdouble z);
        // GLAPI void APIENTRY glVertexAttribL4d (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        // GLAPI void APIENTRY glVertexAttribL1dv (GLuint index, const GLdouble *v);
        // GLAPI void APIENTRY glVertexAttribL2dv (GLuint index, const GLdouble *v);
        // GLAPI void APIENTRY glVertexAttribL3dv (GLuint index, const GLdouble *v);
        // GLAPI void APIENTRY glVertexAttribL4dv (GLuint index, const GLdouble *v);
        // GLAPI void APIENTRY glVertexAttribLPointer (GLuint index, GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        // GLAPI void APIENTRY glGetVertexAttribLdv (GLuint index, GLenum pname, GLdouble *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_viewport_array
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1 - No delegates defined */
        // GLAPI void APIENTRY glViewportArrayv (GLuint first, GLsizei count, const GLfloat *v);
        // GLAPI void APIENTRY glViewportIndexedf (GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h);
        // GLAPI void APIENTRY glViewportIndexedfv (GLuint index, const GLfloat *v);
        // GLAPI void APIENTRY glScissorArrayv (GLuint first, GLsizei count, const GLint *v);
        // GLAPI void APIENTRY glScissorIndexed (GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height);
        // GLAPI void APIENTRY glScissorIndexedv (GLuint index, const GLint *v);
        // GLAPI void APIENTRY glDepthRangeArrayv (GLuint first, GLsizei count, const GLdouble *v);
        // GLAPI void APIENTRY glDepthRangeIndexed (GLuint index, GLdouble n, GLdouble f);
        // GLAPI void APIENTRY glGetFloati_v (GLenum target, GLuint index, GLfloat *data);
        // GLAPI void APIENTRY glGetDoublei_v (GLenum target, GLuint index, GLdouble *data);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_cl_event
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLsync APIENTRY glCreateSyncFromCLeventARB (struct _cl_context * context, struct _cl_event * event, GLbitfield flags);
        public unsafe static GLsync CreateSyncFromCLeventARB(IntPtr cl_context, IntPtr cl_event, GLbitfield flags)
        {
            if (glCreateSyncFromCLeventARB != null)
            {
                return glCreateSyncFromCLeventARB(cl_context.ToPointer(), cl_event.ToPointer(), flags);
            }
            else
            {
                return 0;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_debug_output
        ///////////////////////////////////////////////////////////////////////
        // typedef void (APIENTRY *GLDEBUGPROCARB)(GLenum source,GLenum type,GLuint id,GLenum severity,GLsizei length,const GLchar *message,GLvoid *userParam);
        // GLAPI void APIENTRY glDebugMessageControlARB (GLenum source, GLenum type, GLenum severity, GLsizei count, const GLuint *ids, GLboolean enabled);
        public unsafe static void DebugMessageControlARB(GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint[] ids, GLboolean enabled)
        {
            if (glDebugMessageControlARB != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glDebugMessageControlARB(source, type, severity, count, ptr_ids, enabled);
                }
            }
        }

        // GLAPI void APIENTRY glDebugMessageInsertARB (GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, const GLchar *buf);
        public static void DebugMessageInsertARB(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, string buf)
        {
            if (glDebugMessageInsertARB != null)
            {
                glDebugMessageInsertARB(source, type, id, severity, length, buf);
            }
        }

        // GLAPI void APIENTRY glDebugMessageCallbackARB (GLDEBUGPROCARB callback, const GLvoid *userParam);
        public unsafe static void DebugMessageCallbackARB(TCALLBACKglDebugProcARB callback, IntPtr userParam)
        {
            if (glDebugMessageCallbackARB != null)
            {
                glDebugMessageCallbackARB(callback, userParam.ToPointer());
            }
        }

        // GLAPI GLuint APIENTRY glGetDebugMessageLogARB (GLuint count, GLsizei bufsize, GLenum *sources, GLenum *types, GLuint *ids, GLenum *severities, GLsizei *lengths, GLchar *messageLog);
        public unsafe static GLuint GetDebugMessageLogARB(GLuint count, GLsizei bufsize, GLenum[] sources, GLenum[] types, GLuint[] ids, GLenum[] severities, GLsizei[] lengths, GLchar[] messagelog)
        {
            if (glGetDebugMessageLogARB != null)
            {
                fixed (GLenum* ptr_sources = sources)
                {
                    fixed (GLenum* ptr_types = types)
                    {
                        fixed (GLuint* ptr_ids = ids)
                        {
                            fixed (GLenum* ptr_severities = severities)
                            {
                                fixed (GLsizei* ptr_lengths = lengths)
                                {
                                    fixed (GLchar* ptr_messagelog = messagelog)
                                    {
                                        return glGetDebugMessageLogARB(count, bufsize, ptr_sources, ptr_types, ptr_ids, ptr_severities, ptr_lengths, ptr_messagelog);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                return 0;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_robustness
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLenum APIENTRY glGetGraphicsResetStatusARB (void);
        public static GLenum GetGraphicsResetStatusARB()
        {
            if (glGetGraphicsResetStatusARB != null)
            {
                return glGetGraphicsResetStatusARB();
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glGetnMapdvARB (GLenum target, GLenum query, GLsizei bufSize, GLdouble *v);
        public unsafe static void GetnMapdvARB(GLenum target, GLenum query, GLsizei bufSize, GLdouble[] v)
        {
            if (glGetnMapdvARB != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glGetnMapdvARB(target, query, bufSize, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glGetnMapfvARB (GLenum target, GLenum query, GLsizei bufSize, GLfloat *v);
        public unsafe static void GetnMapfvARB(GLenum target, GLenum query, GLsizei bufSize, GLfloat[] v)
        {
            if (glGetnMapfvARB != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glGetnMapfvARB(target, query, bufSize, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glGetnMapivARB (GLenum target, GLenum query, GLsizei bufSize, GLint *v);
        public unsafe static void GetnMapivARB(GLenum target, GLenum query, GLsizei bufSize, GLint[] v)
        {
            if (glGetnMapivARB != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glGetnMapivARB(target, query, bufSize, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glGetnPixelMapfvARB (GLenum map, GLsizei bufSize, GLfloat *values);
        public unsafe static void GetnPixelMapfvARB(GLenum map, GLsizei bufSize, GLfloat[] values)
        {
            if (glGetnPixelMapfvARB != null)
            {
                fixed (GLfloat* ptr_v = values)
                {
                    glGetnPixelMapfvARB(map, bufSize, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glGetnPixelMapuivARB (GLenum map, GLsizei bufSize, GLuint *values);
        public unsafe static void GetnPixelMapuivARB(GLenum map, GLsizei bufSize, GLuint[] values)
        {
            if (glGetnPixelMapuivARB != null)
            {
                fixed (GLuint* ptr_v = values)
                {
                    glGetnPixelMapuivARB(map, bufSize, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glGetnPixelMapusvARB (GLenum map, GLsizei bufSize, GLushort *values);
        public unsafe static void GetnPixelMapusvARB(GLenum map, GLsizei bufSize, GLushort[] values)
        {
            if (glGetnPixelMapusvARB != null)
            {
                fixed (GLushort* ptr_v = values)
                {
                    glGetnPixelMapusvARB(map, bufSize, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glGetnPolygonStippleARB (GLsizei bufSize, GLubyte *pattern);
        public unsafe static void GetnPolygonStippleARB(GLsizei bufSize, GLubyte[] pattern)
        {
            if (glGetnPolygonStippleARB != null)
            {
                fixed (GLubyte* ptr_pattern = pattern)
                {
                    glGetnPolygonStippleARB(bufSize, ptr_pattern);
                }
            }
        }

        // GLAPI void APIENTRY glGetnColorTableARB (GLenum target, GLenum format, GLenum type, GLsizei bufSize, GLvoid *table);
        public unsafe static void GetnColorTableARB(GLenum target, GLenum format, GLenum type, GLsizei bufSize, IntPtr table)
        {
            if (glGetnColorTableARB != null)
            {
                glGetnColorTableARB(target, format, type, bufSize, table.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetnConvolutionFilterARB (GLenum target, GLenum format, GLenum type, GLsizei bufSize, GLvoid *image);
        public unsafe static void GetnConvolutionFilterARB(GLenum target, GLenum format, GLenum type, GLsizei bufSize, IntPtr image)
        {
            if (glGetnConvolutionFilterARB != null)
            {
                glGetnConvolutionFilterARB(target, format, type, bufSize, image.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetnSeparableFilterARB (GLenum target, GLenum format, GLenum type, GLsizei rowBufSize, GLvoid *row, GLsizei columnBufSize, GLvoid *column, GLvoid *span);
        public unsafe static void GetnSeparableFilterARB(GLenum target, GLenum format, GLenum type, GLsizei rowBufSize, IntPtr row, GLsizei columnBufSize, IntPtr column, IntPtr span)
        {
            if (glGetnSeparableFilterARB != null)
            {
                glGetnSeparableFilterARB(target, format, type, rowBufSize, row.ToPointer(), columnBufSize, column.ToPointer(), span.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetnHistogramARB (GLenum target, GLboolean reset, GLenum format, GLenum type, GLsizei bufSize, GLvoid *values);
        public unsafe static void GetnHistogramARB(GLenum target, GLboolean reset, GLenum format, GLenum type, GLsizei bufSize, IntPtr values)
        {
            if (glGetnHistogramARB != null)
            {
                glGetnHistogramARB(target, reset, format, type, bufSize, values.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetnMinmaxARB (GLenum target, GLboolean reset, GLenum format, GLenum type, GLsizei bufSize, GLvoid *values);
        public unsafe static void GetnMinmaxARB(GLenum target, GLboolean reset, GLenum format, GLenum type, GLsizei bufSize, IntPtr values)
        {
            if (glGetnMinmaxARB != null)
            {
                glGetnMinmaxARB(target, reset, format, type, bufSize, values.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetnTexImageARB (GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, GLvoid *img);
        public unsafe static void GetnTexImageARB(GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, IntPtr img)
        {
            if (glGetnTexImageARB != null)
            {
                glGetnTexImageARB(target, level, format, type, bufSize, img.ToPointer());
            }
        }

        // GLAPI void APIENTRY glReadnPixelsARB (GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, GLvoid *data);
        public unsafe static void ReadnPixelsARB(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, IntPtr data)
        {
            if (glReadnPixelsARB != null)
            {
                glReadnPixelsARB(x, y, width, height, format, type, bufSize, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetnCompressedTexImageARB (GLenum target, GLint lod, GLsizei bufSize, GLvoid *img);
        public unsafe static void GetnCompressedTexImageARB(GLenum target, GLint lod, GLsizei bufSize, IntPtr img)
        {
            if (glGetnCompressedTexImageARB != null)
            {
                glGetnCompressedTexImageARB(target, lod, bufSize, img.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetnUniformfvARB (GLuint program, GLint location, GLsizei bufSize, GLfloat *params);
        public unsafe static void GetnUniformfvARB(GLuint program, GLint location, GLsizei bufSize, GLfloat[] parameters)
        {
            if (glGetnUniformfvARB != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetnUniformfvARB(program, location, bufSize, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetnUniformivARB (GLuint program, GLint location, GLsizei bufSize, GLint *params);
        public unsafe static void GetnUniformivARB(GLuint program, GLint location, GLsizei bufSize, GLint[] parameters)
        {
            if (glGetnUniformivARB != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetnUniformivARB(program, location, bufSize, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetnUniformuivARB (GLuint program, GLint location, GLsizei bufSize, GLuint *params);
        public unsafe static void GetnUniformuivARB(GLuint program, GLint location, GLsizei bufSize, GLuint[] parameters)
        {
            if (glGetnUniformuivARB != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetnUniformuivARB(program, location, bufSize, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetnUniformdvARB (GLuint program, GLint location, GLsizei bufSize, GLdouble *params);
        public unsafe static void GetnUniformdvARB(GLuint program, GLint location, GLsizei bufSize, GLdouble[] parameters)
        {
            if (glGetnUniformdvARB != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetnUniformdvARB(program, location, bufSize, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_stencil_export (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_base_instance
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 - No delegates defined */
        // GLAPI void APIENTRY glDrawArraysInstancedBaseInstance (GLenum mode, GLint first, GLsizei count, GLsizei instancecount, GLuint baseinstance);
        // GLAPI void APIENTRY glDrawElementsInstancedBaseInstance (GLenum mode, GLsizei count, GLenum type, const void *indices, GLsizei instancecount, GLuint baseinstance);
        // GLAPI void APIENTRY glDrawElementsInstancedBaseVertexBaseInstance (GLenum mode, GLsizei count, GLenum type, const void *indices, GLsizei instancecount, GLint basevertex, GLuint baseinstance);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shading_language_420pack (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_transform_feedback_instanced
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 - No delegates defined */
        // GLAPI void APIENTRY glDrawTransformFeedbackInstanced (GLenum mode, GLuint id, GLsizei instancecount);
        // GLAPI void APIENTRY glDrawTransformFeedbackStreamInstanced (GLenum mode, GLuint id, GLuint stream, GLsizei instancecount);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_compressed_texture_pixel_storage (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_conservative_depth (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_internalformat_query
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 - No delegates defined */
        // GLAPI void APIENTRY glGetInternalformativ (GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_map_buffer_alignment (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_atomic_counters
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 - No delegates defined */
        // GLAPI void APIENTRY glGetActiveAtomicCounterBufferiv (GLuint program, GLuint bufferIndex, GLenum pname, GLint *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_image_load_store
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 - No delegates defined */
        // GLAPI void APIENTRY glBindImageTexture (GLuint unit, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLenum format);
        // GLAPI void APIENTRY glMemoryBarrier (GLbitfield barriers);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shading_language_packing (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_storage
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 - No delegates defined */
        // GLAPI void APIENTRY glTexStorage1D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);
        // GLAPI void APIENTRY glTexStorage2D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        // GLAPI void APIENTRY glTexStorage3D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
        // GLAPI void APIENTRY glTextureStorage1DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);
        // GLAPI void APIENTRY glTextureStorage2DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        // GLAPI void APIENTRY glTextureStorage3DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_arrays_of_arrays (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_clear_buffer_object
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glClearBufferData (GLenum target, GLenum internalformat, GLenum format, GLenum type, const void *data);
        // GLAPI void APIENTRY glClearBufferSubData (GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, const void *data);
        // GLAPI void APIENTRY glClearNamedBufferDataEXT (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, const void *data);
        // GLAPI void APIENTRY glClearNamedBufferSubDataEXT (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, GLsizeiptr offset, GLsizeiptr size, const void *data);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_compute_shader
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glDispatchCompute (GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z);
        // GLAPI void APIENTRY glDispatchComputeIndirect (GLintptr indirect);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_copy_image
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glCopyImageSubData (GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_view
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glTextureView (GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_attrib_binding
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glBindVertexBuffer (GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);
        // GLAPI void APIENTRY glVertexAttribFormat (GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);
        // GLAPI void APIENTRY glVertexAttribIFormat (GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        // GLAPI void APIENTRY glVertexAttribLFormat (GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        // GLAPI void APIENTRY glVertexAttribBinding (GLuint attribindex, GLuint bindingindex);
        // GLAPI void APIENTRY glVertexBindingDivisor (GLuint bindingindex, GLuint divisor);
        // GLAPI void APIENTRY glVertexArrayBindVertexBufferEXT (GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);
        // GLAPI void APIENTRY glVertexArrayVertexAttribFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);
        // GLAPI void APIENTRY glVertexArrayVertexAttribIFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        // GLAPI void APIENTRY glVertexArrayVertexAttribLFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        // GLAPI void APIENTRY glVertexArrayVertexAttribBindingEXT (GLuint vaobj, GLuint attribindex, GLuint bindingindex);
        // GLAPI void APIENTRY glVertexArrayVertexBindingDivisorEXT (GLuint vaobj, GLuint bindingindex, GLuint divisor);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_robustness_isolation (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_ES3_compatibility (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_explicit_uniform_location (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_layer_viewport (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_framebuffer_no_attachments
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glFramebufferParameteri (GLenum target, GLenum pname, GLint param);
        // GLAPI void APIENTRY glGetFramebufferParameteriv (GLenum target, GLenum pname, GLint *params);
        // GLAPI void APIENTRY glNamedFramebufferParameteriEXT (GLuint framebuffer, GLenum pname, GLint param);
        // GLAPI void APIENTRY glGetNamedFramebufferParameterivEXT (GLuint framebuffer, GLenum pname, GLint *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_internalformat_query2
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glGetInternalformati64v (GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint64 *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_invalidate_subdata
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glInvalidateTexSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth);
        // GLAPI void APIENTRY glInvalidateTexImage (GLuint texture, GLint level);
        // GLAPI void APIENTRY glInvalidateBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr length);
        // GLAPI void APIENTRY glInvalidateBufferData (GLuint buffer);
        // GLAPI void APIENTRY glInvalidateFramebuffer (GLenum target, GLsizei numAttachments, const GLenum *attachments);
        // GLAPI void APIENTRY glInvalidateSubFramebuffer (GLenum target, GLsizei numAttachments, const GLenum *attachments, GLint x, GLint y, GLsizei width, GLsizei height);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_multi_draw_indirect
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glMultiDrawArraysIndirect (GLenum mode, const void *indirect, GLsizei drawcount, GLsizei stride);
        // GLAPI void APIENTRY glMultiDrawElementsIndirect (GLenum mode, GLenum type, const void *indirect, GLsizei drawcount, GLsizei stride);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_program_interface_query
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glGetProgramInterfaceiv (GLuint program, GLenum programInterface, GLenum pname, GLint *params);
        // GLAPI GLuint APIENTRY glGetProgramResourceIndex (GLuint program, GLenum programInterface, const GLchar *name);
        // GLAPI void APIENTRY glGetProgramResourceName (GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei *length, GLchar *name);
        // GLAPI void APIENTRY glGetProgramResourceiv (GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, const GLenum *props, GLsizei bufSize, GLsizei *length, GLint *params);
        // GLAPI GLint APIENTRY glGetProgramResourceLocation (GLuint program, GLenum programInterface, const GLchar *name);
        // GLAPI GLint APIENTRY glGetProgramResourceLocationIndex (GLuint program, GLenum programInterface, const GLchar *name);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_robust_buffer_access_behavior (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_image_size (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_storage_buffer_object
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glShaderStorageBlockBinding (GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_stencil_texturing (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_buffer_range
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glTexBufferRange (GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);
        // GLAPI void APIENTRY glTextureBufferRangeEXT (GLuint texture, GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_query_levels (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_storage_multisample
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glTexStorage2DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);
        // GLAPI void APIENTRY glTexStorage3DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);
        // GLAPI void APIENTRY glTextureStorage2DMultisampleEXT (GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);
        // GLAPI void APIENTRY glTextureStorage3DMultisampleEXT (GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_buffer_storage (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_clear_texture (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_multi_bind (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_query_buffer_object (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_seamless_cubemap_per_texture (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_draw_parameters (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_group_vote (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_mirror_clamp_to_edge (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_stencil8 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_type_10f_11f_11f_rev (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_bindless_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLuint64 APIENTRY glGetTextureHandleARB (GLuint texture);
        public static GLuint64 GetTextureHandleARB(GLuint texture)
        {
            if (glGetTextureHandleARB != null)
            {
                return glGetTextureHandleARB(texture);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLuint64 APIENTRY glGetTextureSamplerHandleARB (GLuint texture, GLuint sampler);
        public static GLuint64 GetTextureSamplerHandleARB(GLuint texture, GLuint sampler)
        {
            if (glGetTextureSamplerHandleARB != null)
            {
                return GetTextureSamplerHandleARB(texture, sampler);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glMakeTextureHandleResidentARB (GLuint64 handle);
        public static void MakeTextureHandleResidentARB(GLuint64 handle)
        {
            if (glMakeTextureHandleResidentARB != null)
            {
                glMakeTextureHandleResidentARB(handle);
            }
        }

        // GLAPI void APIENTRY glMakeTextureHandleNonResidentARB (GLuint64 handle);
        public static void MakeTextureHandleNonResidentARB(GLuint64 handle)
        {
            if (glMakeTextureHandleNonResidentARB != null)
            {
                glMakeTextureHandleNonResidentARB(handle);
            }
        }

        // GLAPI GLuint64 APIENTRY glGetImageHandleARB (GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format);
        public static GLuint64 GetImageHandleARB(GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format)
        {
            if (glGetImageHandleARB != null)
            {
                return glGetImageHandleARB(texture, level, layered, layer, format);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glMakeImageHandleResidentARB (GLuint64 handle, GLenum access);
        public static void MakeImageHandleResidentARB(GLuint64 handle, GLenum access)
        {
            if (glMakeImageHandleResidentARB != null)
            {
                glMakeImageHandleResidentARB(handle, access);
            }
        }

        // GLAPI void APIENTRY glMakeImageHandleNonResidentARB (GLuint64 handle);
        public static void MakeImageHandleNonResidentARB(GLuint64 handle)
        {
            if (glMakeImageHandleNonResidentARB != null)
            {
                glMakeImageHandleNonResidentARB(handle);
            }
        }

        // GLAPI void APIENTRY glUniformHandleui64ARB (GLint location, GLuint64 value);
        public static void UniformHandleui64ARB(GLint location, GLuint64 value)
        {
            if (glUniformHandleui64ARB != null)
            {
                glUniformHandleui64ARB(location, value);
            }
        }

        // GLAPI void APIENTRY glUniformHandleui64vARB (GLint location, GLsizei count, const GLuint64 *value);
        public unsafe static void UniformHandleui64vARB(GLint location, GLsizei count, GLuint64[] value)
        {
            if (glUniformHandleui64vARB != null)
            {
                fixed (GLuint64* ptr_value = value)
                {
                    glUniformHandleui64vARB(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformHandleui64ARB (GLuint program, GLint location, GLuint64 value);
        public static void ProgramUniformHandleui64ARB(GLuint program, GLint location, GLuint64 value)
        {
            if (glProgramUniformHandleui64ARB != null)
            {
                glProgramUniformHandleui64ARB(program, location, value);
            }
        }

        // GLAPI void APIENTRY glProgramUniformHandleui64vARB (GLuint program, GLint location, GLsizei count, const GLuint64 *values);
        public unsafe static void ProgramUniformHandleui64vARB(GLuint program, GLint location, GLsizei count, GLuint64[] values)
        {
            if (glProgramUniformHandleui64vARB != null)
            {
                fixed (GLuint64* ptr_values = values)
                {
                    glProgramUniformHandleui64vARB(program, location, count, ptr_values);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsTextureHandleResidentARB (GLuint64 handle);
        public static GLboolean IsTextureHandleResidentARB(GLuint64 handle)
        {
            if (glIsTextureHandleResidentARB != null)
            {
                return glIsTextureHandleResidentARB(handle);
            }
            else
            {
                return false;
            }
        }

        // GLAPI GLboolean APIENTRY glIsImageHandleResidentARB (GLuint64 handle);
        public static GLboolean IsImageHandleResidentARB(GLuint64 handle)
        {
            if (glIsImageHandleResidentARB != null)
            {
                return glIsImageHandleResidentARB(handle);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glVertexAttribL1ui64ARB (GLuint index, GLuint64EXT x);
        public static void VertexAttribL1ui64ARB(GLuint index, GLuint64 x)
        {
            if (glVertexAttribL1ui64ARB != null)
            {
                glVertexAttribL1ui64ARB(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL1ui64vARB (GLuint index, const GLuint64EXT *v);
        public unsafe static void VertexAttribL1ui64vARB(GLuint index, GLuint64[] v)
        {
            if (glVertexAttribL1ui64vARB != null)
            {
                fixed (GLuint64* ptr_v = v)
                {
                    glVertexAttribL1ui64vARB(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribLui64vARB (GLuint index, GLenum pname, GLuint64EXT *params);
        public unsafe static void GetVertexAttribLui64vARB(GLuint index, GLenum pname, GLuint64[] parameters)
        {
            if (glGetVertexAttribLui64vARB != null)
            {
                fixed (GLuint64* ptr_parameters = parameters)
                {
                    glGetVertexAttribLui64vARB(index, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_compute_variable_group_size
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDispatchComputeGroupSizeARB (GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z, GLuint group_size_x, GLuint group_size_y, GLuint group_size_z);
        public static void DispatchComputeGroupSizeARB(GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z, GLuint group_size_x, GLuint group_size_y, GLuint group_size_z)
        {
            if (glDispatchComputeGroupSizeARB != null)
            {
                glDispatchComputeGroupSizeARB(num_groups_x, num_groups_y, num_groups_z, group_size_x, group_size_y, group_size_z);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_indirect_parameters
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMultiDrawArraysIndirectCountARB (GLenum mode, GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride);
        public static void MultiDrawArraysIndirectCountARB(GLenum mode, GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride)
        {
            if (glMultiDrawArraysIndirectCountARB != null)
            {
                glMultiDrawArraysIndirectCountARB(mode, indirect, drawcount, maxdrawcount, stride);
            }
        }

        // GLAPI void APIENTRY glMultiDrawElementsIndirectCountARB (GLenum mode, GLenum type, GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride);
        public static void MultiDrawElementsIndirectCountARB(GLenum mode, GLenum type, GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride)
        {
            if (glMultiDrawElementsIndirectCountARB != null)
            {
                glMultiDrawElementsIndirectCountARB(mode, type, indirect, drawcount, maxdrawcount, stride);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sparse_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexPageCommitmentARB (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLboolean resident);
        public static void TexPageCommitmentARB(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLboolean resident)
        {
            if (glTexPageCommitmentARB != null)
            {
                glTexPageCommitmentARB(target, level, xoffset, yoffset, zoffset, width, height, depth, resident);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_enhanced_layouts (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_ES3_1_compatibility (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_clip_control (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_conditional_render_inverted (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_cull_distance (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_derivative_control (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_direct_state_access (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_get_texture_sub_image (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_pipeline_statistics_query (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_texture_image_samples (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sparse_buffer
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBufferPageCommitmentARB (GLenum target, GLintptr offset, GLsizeiptr size, GLboolean commit);
        public static void BufferPageCommitmentARB(GLenum target, GLintptr offset, GLsizeiptr size, GLboolean commit)
        {
            if (glBufferPageCommitmentARB != null)
            {
                glBufferPageCommitmentARB(target, offset, size, commit);
            }
        }

        // GLAPI void APIENTRY glNamedBufferPageCommitmentEXT (GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit);
        public static void NamedBufferPageCommitmentEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit)
        {
            if (glNamedBufferPageCommitmentEXT != null)
            {
                glNamedBufferPageCommitmentEXT(buffer, offset, size, commit);
            }
        }

        // GLAPI void APIENTRY glNamedBufferPageCommitmentARB (GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit);
        public static void NamedBufferPageCommitmentARB(GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit)
        {
            if (glNamedBufferPageCommitmentARB != null)
            {
                glNamedBufferPageCommitmentARB(buffer, offset, size, commit);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_barrier (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_transform_feedback_overflow_query (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_ES3_2_compatibility
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPrimitiveBoundingBoxARB (GLfloat minX, GLfloat minY, GLfloat minZ, GLfloat minW, GLfloat maxX, GLfloat maxY, GLfloat maxZ, GLfloat maxW);
        public static void PrimitiveBoundingBoxARB(GLfloat minX, GLfloat minY, GLfloat minZ, GLfloat minW, GLfloat maxX, GLfloat maxY, GLfloat maxZ, GLfloat maxW)
        {
            if (glPrimitiveBoundingBoxARB != null)
            {
                glPrimitiveBoundingBoxARB(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_shader_interlock (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_ATI_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_texture_mirror_once (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_envmap_bumpmap
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexBumpParameterivATI (GLenum pname, const GLint *param);
        public unsafe static void TexBumpParameterivATI(GLenum pname, GLint[] param)
        {
            if (glTexBumpParameterivATI != null)
            {
                fixed (GLint* ptr_param = param)
                {
                    glTexBumpParameterivATI(pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glTexBumpParameterfvATI (GLenum pname, const GLfloat *param);
        public unsafe static void TexBumpParameterfvATI(GLenum pname, GLfloat[] param)
        {
            if (glTexBumpParameterfvATI != null)
            {
                fixed (GLfloat* ptr_param = param)
                {
                    glTexBumpParameterfvATI(pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glGetTexBumpParameterivATI (GLenum pname, GLint *param);
        public unsafe static void GetTexBumpParameterivATI(GLenum pname, GLint[] param)
        {
            if (glGetTexBumpParameterivATI != null)
            {
                fixed (GLint* ptr_param = param)
                {
                    glGetTexBumpParameterivATI(pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glGetTexBumpParameterfvATI (GLenum pname, GLfloat *param);
        public unsafe static void GetTexBumpParameterfvATI(GLenum pname, GLfloat[] param)
        {
            if (glGetTexBumpParameterfvATI != null)
            {
                fixed (GLfloat* ptr_param = param)
                {
                    glGetTexBumpParameterfvATI(pname, ptr_param);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_fragment_shader
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLuint APIENTRY glGenFragmentShadersATI (GLuint range);
        public static GLuint GenFragmentShadersATI(GLuint range)
        {
            if (glGenFragmentShadersATI != null)
            {
                return glGenFragmentShadersATI(range);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glBindFragmentShaderATI (GLuint id);
        public static void BindFragmentShaderATI(GLuint id)
        {
            if (glBindFragmentShaderATI != null)
            {
                glBindFragmentShaderATI(id);
            }
        }

        // GLAPI void APIENTRY glDeleteFragmentShaderATI (GLuint id);
        public static void DeleteFragmentShaderATI(GLuint id)
        {
            if (glDeleteFragmentShaderATI != null)
            {
                glDeleteFragmentShaderATI(id);
            }
        }

        // GLAPI void APIENTRY glBeginFragmentShaderATI (void);
        public static void BeginFragmentShaderATI()
        {
            if (glBeginFragmentShaderATI != null)
            {
                glBeginFragmentShaderATI();
            }
        }
        
        // GLAPI void APIENTRY glEndFragmentShaderATI (void);
        public static void EndFragmentShaderATI()
        {
            if (glEndFragmentShaderATI != null)
            {
                glEndFragmentShaderATI();
            }
        }

        // GLAPI void APIENTRY glPassTexCoordATI (GLuint dst, GLuint coord, GLenum swizzle);
        public static void PassTexCoordATI(GLuint dst, GLuint coord, GLenum swizzle)
        {
            if (glPassTexCoordATI != null)
            {
                glPassTexCoordATI(dst, coord, swizzle);
            }
        }

        // GLAPI void APIENTRY glSampleMapATI (GLuint dst, GLuint interp, GLenum swizzle);
        public static void SampleMapATI(GLuint dst, GLuint interp, GLenum swizzle)
        {
            if (glSampleMapATI != null)
            {
                glSampleMapATI(dst, interp, swizzle);
            }
        }

        // GLAPI void APIENTRY glColorFragmentOp1ATI (GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);
        public static void ColorFragmentOp1ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod)
        {
            if (glColorFragmentOp1ATI != null)
            {
                glColorFragmentOp1ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod);
            }
        }

        // GLAPI void APIENTRY glColorFragmentOp2ATI (GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);
        public static void ColorFragmentOp2ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod)
        {
            if (glColorFragmentOp2ATI != null)
            {
                glColorFragmentOp2ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
            }
        }

        // GLAPI void APIENTRY glColorFragmentOp3ATI (GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);
        public static void ColorFragmentOp3ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod)
        {
            if (glColorFragmentOp3ATI != null)
            {
                glColorFragmentOp3ATI(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
            }
        }

        // GLAPI void APIENTRY glAlphaFragmentOp1ATI (GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);
        public static void AlphaFragmentOp1ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod)
        {
            if (glAlphaFragmentOp1ATI != null)
            {
                glAlphaFragmentOp1ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod);
            }
        }

        // GLAPI void APIENTRY glAlphaFragmentOp2ATI (GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);
        public static void AlphaFragmentOp2ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod)
        {
            if (glAlphaFragmentOp2ATI != null)
            {
                glAlphaFragmentOp2ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
            }
        }

        // GLAPI void APIENTRY glAlphaFragmentOp3ATI (GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);
        public static void AlphaFragmentOp3ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod)
        {
            if (glAlphaFragmentOp3ATI != null)
            {
                glAlphaFragmentOp3ATI(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
            }
        }

        // GLAPI void APIENTRY glSetFragmentShaderConstantATI (GLuint dst, const GLfloat *value);
        public unsafe static void SetFragmentShaderConstantATI(GLuint dst, GLfloat[] value)
        {
            if (glSetFragmentShaderConstantATI != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glSetFragmentShaderConstantATI(dst, ptr_value);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_pn_triangles
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPNTrianglesiATI (GLenum pname, GLint param);
        public static void PNTrianglesiATI(GLenum pname, GLint param)
        {
            if (glPNTrianglesiATI != null)
            {
                glPNTrianglesiATI(pname, param);
            }
        }

        // GLAPI void APIENTRY glPNTrianglesfATI (GLenum pname, GLfloat param);
        public static void PNTrianglesfATI(GLenum pname, GLfloat param)
        {
            if (glPNTrianglesfATI != null)
            {
                glPNTrianglesfATI(pname, param);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_vertex_array_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLuint APIENTRY glNewObjectBufferATI (GLsizei size, const GLvoid *pointer, GLenum usage);
        public unsafe static GLuint NewObjectBufferATI(GLsizei size, IntPtr pointer, GLenum usage)
        {
            if (glNewObjectBufferATI != null)
            {
                return glNewObjectBufferATI(size, pointer.ToPointer(), usage);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLboolean APIENTRY glIsObjectBufferATI (GLuint buffer);
        public static GLboolean IsObjectBufferATI(GLuint buffer)
        {
            if (glIsObjectBufferATI != null)
            {
                return glIsObjectBufferATI(buffer);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glUpdateObjectBufferATI (GLuint buffer, GLuint offset, GLsizei size, const GLvoid *pointer, GLenum preserve);
        public unsafe static void UpdateObjectBufferATI(GLuint buffer, GLuint offset, GLsizei size, IntPtr pointer, GLenum preserve)
        {
            if (glUpdateObjectBufferATI != null)
            {
                glUpdateObjectBufferATI(buffer, offset, size, pointer.ToPointer(), preserve);
            }
        }

        // GLAPI void APIENTRY glGetObjectBufferfvATI (GLuint buffer, GLenum pname, GLfloat *params);
        public unsafe static void GetObjectBufferfvATI(GLuint buffer, GLenum pname, GLfloat[] parameters)
        {
            if (glGetObjectBufferfvATI != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetObjectBufferfvATI(buffer, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetObjectBufferivATI (GLuint buffer, GLenum pname, GLint *params);
        public unsafe static void GetObjectBufferivATI(GLuint buffer, GLenum pname, GLint[] parameters)
        {
            if (glGetObjectBufferivATI != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetObjectBufferivATI(buffer, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glFreeObjectBufferATI (GLuint buffer);
        public static void FreeObjectBufferATI(GLuint buffer)
        {
            if (glFreeObjectBufferATI != null)
            {
                glFreeObjectBufferATI(buffer);
            }
        }

        // GLAPI void APIENTRY glArrayObjectATI (GLenum array, GLint size, GLenum type, GLsizei stride, GLuint buffer, GLuint offset);
        public static void ArrayObjectATI(GLenum array, GLint size, GLenum type, GLsizei stride, GLuint buffer, GLuint offset)
        {
            if (glArrayObjectATI != null)
            {
                glArrayObjectATI(array, size, type, stride, buffer, offset);
            }
        }

        // GLAPI void APIENTRY glGetArrayObjectfvATI (GLenum array, GLenum pname, GLfloat *params);
        public unsafe static void GetArrayObjectfvATI(GLenum array, GLenum pname, GLfloat[] parameters)
        {
            if (glGetArrayObjectfvATI != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetArrayObjectfvATI(array, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetArrayObjectivATI (GLenum array, GLenum pname, GLint *params);
        public unsafe static void GetArrayObjectivATI(GLenum array, GLenum pname, GLint[] parameters)
        {
            if (glGetArrayObjectivATI != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetArrayObjectivATI(array, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glVariantArrayObjectATI (GLuint id, GLenum type, GLsizei stride, GLuint buffer, GLuint offset);
        public static void VariantArrayObjectATI(GLuint id, GLenum type, GLsizei stride, GLuint buffer, GLuint offset)
        {
            if (glVariantArrayObjectATI != null)
            {
                glVariantArrayObjectATI(id, type, stride, buffer, offset);
            }
        }

        // GLAPI void APIENTRY glGetVariantArrayObjectfvATI (GLuint id, GLenum pname, GLfloat *params);
        public unsafe static void GetVariantArrayObjectfvATI(GLuint id, GLenum pname, GLfloat[] parameters)
        {
            if (glGetVariantArrayObjectfvATI != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetVariantArrayObjectfvATI(id, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVariantArrayObjectivATI (GLuint id, GLenum pname, GLint *params);
        public unsafe static void GetVariantArrayObjectivATI(GLuint id, GLenum pname, GLint[] parameters)
        {
            if (glGetVariantArrayObjectivATI != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetVariantArrayObjectivATI(id, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_vertex_streams
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexStream1sATI (GLenum stream, GLshort x);
        public static void VertexStream1sATI(GLenum stream, GLshort x)
        {
            if (glVertexStream1sATI != null)
            {
                glVertexStream1sATI(stream, x);
            }
        }

        // GLAPI void APIENTRY glVertexStream1svATI (GLenum stream, const GLshort *coords);
        public unsafe static void VertexStream1svATI(GLenum stream, GLshort[] coords)
        {
            if (glVertexStream1svATI != null)
            {
                fixed (GLshort* ptr_coords = coords)
                {
                    glVertexStream1svATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream1iATI (GLenum stream, GLint x);
        public static void VertexStream1iATI(GLenum stream, GLint x)
        {
            if (glVertexStream1iATI != null)
            {
                glVertexStream1iATI(stream, x);
            }
        }

        // GLAPI void APIENTRY glVertexStream1ivATI (GLenum stream, const GLint *coords);
        public unsafe static void VertexStream1ivATI(GLenum stream, GLint[] coords)
        {
            if (glVertexStream1ivATI != null)
            {
                fixed (GLint* ptr_coords = coords)
                {
                    glVertexStream1ivATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream1fATI (GLenum stream, GLfloat x);
        public static void VertexStream1fATI(GLenum stream, GLfloat x)
        {
            if (glVertexStream1fATI != null)
            {
                glVertexStream1fATI(stream, x);
            }
        }

        // GLAPI void APIENTRY glVertexStream1fvATI (GLenum stream, const GLfloat *coords);
        public unsafe static void VertexStream1fvATI(GLenum stream, GLfloat[] coords)
        {
            if (glVertexStream1fvATI != null)
            {
                fixed (GLfloat* ptr_coords = coords)
                {
                    glVertexStream1fvATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream1dATI (GLenum stream, GLdouble x);
        public static void VertexStream1dATI(GLenum stream, GLdouble x)
        {
            if (glVertexStream1dATI != null)
            {
                glVertexStream1dATI(stream, x);
            }
        }

        // GLAPI void APIENTRY glVertexStream1dvATI (GLenum stream, const GLdouble *coords);
        public unsafe static void VertexStream1dvATI(GLenum stream, GLdouble[] coords)
        {
            if (glVertexStream1dvATI != null)
            {
                fixed (GLdouble* ptr_coords = coords)
                {
                    glVertexStream1dvATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream2sATI (GLenum stream, GLshort x, GLshort y);
        public static void VertexStream2sATI(GLenum stream, GLshort x, GLshort y)
        {
            if (glVertexStream2sATI != null)
            {
                glVertexStream2sATI(stream, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexStream2svATI (GLenum stream, const GLshort *coords);
        public unsafe static void VertexStream2svATI(GLenum stream, GLshort[] coords)
        {
            if (glVertexStream2svATI != null)
            {
                fixed (GLshort* ptr_coords = coords)
                {
                    glVertexStream2svATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream2iATI (GLenum stream, GLint x, GLint y);
        public static void VertexStream2iATI(GLenum stream, GLint x, GLint y)
        {
            if (glVertexStream2iATI != null)
            {
                glVertexStream2iATI(stream, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexStream2ivATI (GLenum stream, const GLint *coords);
        public unsafe static void VertexStream2ivATI(GLenum stream, GLint[] coords)
        {
            if (glVertexStream2ivATI != null)
            {
                fixed (GLint* ptr_coords = coords)
                {
                    glVertexStream2ivATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream2fATI (GLenum stream, GLfloat x, GLfloat y);
        public static void VertexStream2fATI(GLenum stream, GLfloat x, GLfloat y)
        {
            if (glVertexStream2fATI != null)
            {
                glVertexStream2fATI(stream, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexStream2fvATI (GLenum stream, const GLfloat *coords);
        public unsafe static void VertexStream2fvATI(GLenum stream, GLfloat[] coords)
        {
            if (glVertexStream2fvATI != null)
            {
                fixed (GLfloat* ptr_coords = coords)
                {
                    glVertexStream2fvATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream2dATI (GLenum stream, GLdouble x, GLdouble y);
        public static void VertexStream2dATI(GLenum stream, GLdouble x, GLdouble y)
        {
            if (glVertexStream2dATI != null)
            {
                glVertexStream2dATI(stream, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexStream2dvATI (GLenum stream, const GLdouble *coords);
        public unsafe static void VertexStream2dvATI(GLenum stream, GLdouble[] coords)
        {
            if (glVertexStream2dvATI != null)
            {
                fixed (GLdouble* ptr_coords = coords)
                {
                    glVertexStream2dvATI (stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream3sATI (GLenum stream, GLshort x, GLshort y, GLshort z);
        public static void VertexStream3sATI(GLenum stream, GLshort x, GLshort y, GLshort z)
        {
            if (glVertexStream3sATI != null)
            {
                glVertexStream3sATI(stream, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexStream3svATI (GLenum stream, const GLshort *coords);
        public unsafe static void VertexStream3svATI(GLenum stream, GLshort[] coords)
        {
            if (glVertexStream3svATI != null)
            {
                fixed (GLshort* ptr_coords = coords)
                {
                    glVertexStream3svATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream3iATI (GLenum stream, GLint x, GLint y, GLint z);
        public static void VertexStream3iATI(GLenum stream, GLint x, GLint y, GLint z)
        {
            if (glVertexStream3iATI != null)
            {
                glVertexStream3iATI(stream, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexStream3ivATI (GLenum stream, const GLint *coords);
        public unsafe static void VertexStream3ivATI(GLenum stream, GLint[] coords)
        {
            if (glVertexStream3ivATI != null)
            {
                fixed (GLint* ptr_coords = coords)
                {
                    glVertexStream3ivATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream3fATI (GLenum stream, GLfloat x, GLfloat y, GLfloat z);
        public static void VertexStream3fATI(GLenum stream, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glVertexStream3fATI != null)
            {
                glVertexStream3fATI(stream, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexStream3fvATI (GLenum stream, const GLfloat *coords);
        public unsafe static void VertexStream3fvATI(GLenum stream, GLfloat[] coords)
        {
            if (glVertexStream3fvATI != null)
            {
                fixed (GLfloat* ptr_coords = coords)
                {
                    glVertexStream3fvATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream3dATI (GLenum stream, GLdouble x, GLdouble y, GLdouble z);
        public static void VertexStream3dATI(GLenum stream, GLdouble x, GLdouble y, GLdouble z)
        {
            if (glVertexStream3dATI != null)
            {
                glVertexStream3dATI(stream, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexStream3dvATI (GLenum stream, const GLdouble *coords);
        public unsafe static void VertexStream3dvATI(GLenum stream, GLdouble[] coords)
        {
            if (glVertexStream3dvATI != null)
            {
                fixed (GLdouble* ptr_coords = coords)
                {
                    glVertexStream3dvATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream4sATI (GLenum stream, GLshort x, GLshort y, GLshort z, GLshort w);
        public static void VertexStream4sATI(GLenum stream, GLshort x, GLshort y, GLshort z, GLshort w)
        {
            if (glVertexStream4sATI != null)
            {
                glVertexStream4sATI(stream, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexStream4svATI (GLenum stream, const GLshort *coords);
        public unsafe static void VertexStream4svATI(GLenum stream, GLshort[] coords)
        {
            if (glVertexStream4svATI != null)
            {
                fixed (GLshort* ptr_coords = coords)
                {
                    glVertexStream4svATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream4iATI (GLenum stream, GLint x, GLint y, GLint z, GLint w);
        public static void VertexStream4iATI(GLenum stream, GLint x, GLint y, GLint z, GLint w)
        {
            if (glVertexStream4iATI != null)
            {
                glVertexStream4iATI(stream, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexStream4ivATI (GLenum stream, const GLint *coords);
        public unsafe static void VertexStream4ivATI(GLenum stream, GLint[] coords)
        {
            if (glVertexStream4ivATI != null)
            {
                fixed (GLint* ptr_coords = coords)
                {
                    glVertexStream4ivATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream4fATI (GLenum stream, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        public static void VertexStream4fATI(GLenum stream, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glVertexStream4fATI != null)
            {
                glVertexStream4fATI(stream, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexStream4fvATI (GLenum stream, const GLfloat *coords);
        public unsafe static void VertexStream4fvATI(GLenum stream, GLfloat[] coords)
        {
            if (glVertexStream4fvATI != null)
            {
                fixed (GLfloat* ptr_coords = coords)
                {
                    glVertexStream4fvATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertexStream4dATI (GLenum stream, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        public static void VertexStream4dATI(GLenum stream, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glVertexStream4dATI != null)
            {
                glVertexStream4dATI(stream, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexStream4dvATI (GLenum stream, const GLdouble *coords);
        public unsafe static void VertexStream4dvATI(GLenum stream, GLdouble[] coords)
        {
            if (glVertexStream4dvATI != null)
            {
                fixed (GLdouble* ptr_coords = coords)
                {
                    glVertexStream4dvATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glNormalStream3bATI (GLenum stream, GLbyte nx, GLbyte ny, GLbyte nz);
        public static void NormalStream3bATI(GLenum stream, GLbyte nx, GLbyte ny, GLbyte nz)
        {
            if (glNormalStream3bATI != null)
            {
                glNormalStream3bATI(stream, nx, ny, nz);
            }
        }

        // GLAPI void APIENTRY glNormalStream3bvATI (GLenum stream, const GLbyte *coords);
        public unsafe static void NormalStream3bvATI(GLenum stream, GLbyte[] coords)
        {
            if (glNormalStream3bvATI != null)
            {
                fixed (GLbyte* ptr_coords = coords)
                {
                    glNormalStream3bvATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glNormalStream3sATI (GLenum stream, GLshort nx, GLshort ny, GLshort nz);
        public static void NormalStream3sATI(GLenum stream, GLshort nx, GLshort ny, GLshort nz)
        {
            if (glNormalStream3sATI != null)
            {
                glNormalStream3sATI(stream, nx, ny, nz);
            }
        }

        // GLAPI void APIENTRY glNormalStream3svATI (GLenum stream, const GLshort *coords);
        public unsafe static void NormalStream3svATI(GLenum stream, GLshort[] coords)
        {
            if (glNormalStream3svATI != null)
            {
                fixed (GLshort* ptr_coords = coords)
                {
                    glNormalStream3svATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glNormalStream3iATI (GLenum stream, GLint nx, GLint ny, GLint nz);
        public static void NormalStream3iATI(GLenum stream, GLint nx, GLint ny, GLint nz)
        {
            if (glNormalStream3iATI != null)
            {
                glNormalStream3iATI(stream, nx, ny, nz);
            }
        }

        // GLAPI void APIENTRY glNormalStream3ivATI (GLenum stream, const GLint *coords);
        public unsafe static void NormalStream3ivATI(GLenum stream, GLint[] coords)
        {
            if (glNormalStream3ivATI != null)
            {
                fixed (GLint* ptr_coords = coords)
                {
                    glNormalStream3ivATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glNormalStream3fATI (GLenum stream, GLfloat nx, GLfloat ny, GLfloat nz);
        public static void NormalStream3fATI(GLenum stream, GLfloat nx, GLfloat ny, GLfloat nz)
        {
            if (glNormalStream3fATI != null)
            {
                glNormalStream3fATI(stream, nx, ny, nz);
            }
        }

        // GLAPI void APIENTRY glNormalStream3fvATI (GLenum stream, const GLfloat *coords);
        public unsafe static void NormalStream3fvATI(GLenum stream, GLfloat[] coords)
        {
            if (glNormalStream3fvATI != null)
            {
                fixed (GLfloat* ptr_coords = coords)
                {
                    glNormalStream3fvATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glNormalStream3dATI (GLenum stream, GLdouble nx, GLdouble ny, GLdouble nz);
        public static void NormalStream3dATI(GLenum stream, GLdouble nx, GLdouble ny, GLdouble nz)
        {
            if (glNormalStream3dATI != null)
            {
                glNormalStream3dATI(stream, nx, ny, nz);
            }
        }

        // GLAPI void APIENTRY glNormalStream3dvATI (GLenum stream, const GLdouble *coords);
        public unsafe static void NormalStream3dvATI(GLenum stream, GLdouble[] coords)
        {
            if (glNormalStream3dvATI != null)
            {
                fixed (GLdouble* ptr_coords = coords)
                {
                    glNormalStream3dvATI(stream, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glClientActiveVertexStreamATI (GLenum stream);
        public static void ClientActiveVertexStreamATI(GLenum stream)
        {
            if (glClientActiveVertexStreamATI != null)
            {
                glClientActiveVertexStreamATI(stream);
            }
        }

        // GLAPI void APIENTRY glVertexBlendEnviATI (GLenum pname, GLint param);
        public static void VertexBlendEnviATI(GLenum pname, GLint param)
        {
            if (glVertexBlendEnviATI != null)
            {
                glVertexBlendEnviATI(pname, param);
            }
        }

        // GLAPI void APIENTRY glVertexBlendEnvfATI (GLenum pname, GLfloat param);
        public static void VertexBlendEnvfATI(GLenum pname, GLfloat param)
        {
            if (glVertexBlendEnvfATI != null)
            {
                glVertexBlendEnvfATI(pname, param);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_element_array
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glElementPointerATI (GLenum type, const GLvoid *pointer);
        public unsafe static void ElementPointerATI(GLenum type, IntPtr pointer)
        {
            if (glElementPointerATI != null)
            {
                glElementPointerATI(type, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glDrawElementArrayATI (GLenum mode, GLsizei count);
        public static void DrawElementArrayATI(GLenum mode, GLsizei count)
        {
            if (glDrawElementArrayATI != null)
            {
                glDrawElementArrayATI(mode, count);
            }
        }

        // GLAPI void APIENTRY glDrawRangeElementArrayATI (GLenum mode, GLuint start, GLuint end, GLsizei count);
        public static void DrawRangeElementArrayATI(GLenum mode, GLuint start, GLuint end, GLsizei count)
        {
            if (glDrawRangeElementArrayATI != null)
            {
                glDrawRangeElementArrayATI(mode, start, end, count);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_text_fragment_shader (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_draw_buffers
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDrawBuffersATI (GLsizei n, const GLenum *bufs);
        public unsafe static void DrawBuffersATI(GLsizei n, GLenum[] bufs)
        {
            if (glDrawBuffersATI != null)
            {
                fixed (GLenum* ptr_bufs = bufs)
                {
                    glDrawBuffersATI(n, ptr_bufs);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_pixel_format_float
        ///////////////////////////////////////////////////////////////////////
        /* No delegates defined
         * This is really a WGL extension, but defines some associated GL enums.
         * ATI does not export "GL_ATI_pixel_format_float" in the GL_EXTENSIONS string.
         */

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_texture_env_combine3 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_texture_float (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_map_object_buffer
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLvoid* APIENTRY glMapObjectBufferATI (GLuint buffer);
        public unsafe static IntPtr MapObjectBufferATI(GLuint buffer)
        {
            if (glMapObjectBufferATI != null)
            {
                return (IntPtr)glMapObjectBufferATI(buffer);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // GLAPI void APIENTRY glUnmapObjectBufferATI (GLuint buffer);
        public static void UnmapObjectBufferATI(GLuint buffer)
        {
            if (glUnmapObjectBufferATI != null)
            {
                glUnmapObjectBufferATI(buffer);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_separate_stencil
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glStencilOpSeparateATI (GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass);
        public static void StencilOpSeparateATI(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass)
        {
            if (glStencilOpSeparateATI != null)
            {
                glStencilOpSeparateATI(face, sfail, dpfail, dppass);
            }
        }

        // GLAPI void APIENTRY glStencilFuncSeparateATI (GLenum frontfunc, GLenum backfunc, GLint ref, GLuint mask);
        public static void StencilFuncSeparateATI(GLenum frontfunc, GLenum backfunc, GLint reference, GLuint mask)
        {
            if (glStencilFuncSeparateATI != null)
            {
                glStencilFuncSeparateATI(frontfunc, backfunc, reference, mask);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_vertex_attrib_array_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexAttribArrayObjectATI (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLuint buffer, GLuint offset);
        public static void VertexAttribArrayObjectATI(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLuint buffer, GLuint offset)
        {
            if (glVertexAttribArrayObjectATI != null)
            {
                glVertexAttribArrayObjectATI(index, size, type, normalized, stride, buffer, offset);
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribArrayObjectfvATI (GLuint index, GLenum pname, GLfloat *params);
        public unsafe static void GetVertexAttribArrayObjectfvATI(GLuint index, GLenum pname, GLfloat[] parameters)
        {
            if (glGetVertexAttribArrayObjectfvATI != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetVertexAttribArrayObjectfvATI(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribArrayObjectivATI (GLuint index, GLenum pname, GLint *params);
        public unsafe static void GetVertexAttribArrayObjectivATI(GLuint index, GLenum pname, GLint[] parameters)
        {
            if (glGetVertexAttribArrayObjectivATI != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetVertexAttribArrayObjectivATI(index, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_meminfo (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_texture_compression_3dc (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_EXT_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_abgr (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_color
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendColorEXT (GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
        public static void BlendColorEXT(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
        {
            if (glBlendColorEXT != null)
            {
                glBlendColorEXT(red, green, blue, alpha);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_polygon_offset
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPolygonOffsetEXT (GLfloat factor, GLfloat bias);
        public static void PolygonOffsetEXT(GLfloat factor, GLfloat bias)
        {
            if (glPolygonOffsetEXT != null)
            {
                glPolygonOffsetEXT(factor, bias);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_compression_dxt1 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_compression_s3tc (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_cube_map (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture3D
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexImage3DEXT (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void TexImage3DEXT(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTexImage3DEXT != null)
            {
                glTexImage3DEXT(target, level, internalformat, width, height, depth, border, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glTexSubImage3DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void TexSubImage3DEXT(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTexSubImage3DEXT != null)
            {
                glTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_subtexture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexSubImage1DEXT (GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void TexSubImage1DEXT(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTexSubImage1DEXT != null)
            {
                glTexSubImage1DEXT(target, level, xoffset, width, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glTexSubImage2DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void TexSubImage2DEXT(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTexSubImage2DEXT != null)
            {
                glTexSubImage2DEXT(target, level, xoffset, yoffset, width, height, format, type, pixels.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_copy_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCopyTexImage1DEXT (GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);
        public static void CopyTexImage1DEXT(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border)
        {
            if (glCopyTexImage1DEXT != null)
            {
                glCopyTexImage1DEXT(target, level, internalformat, x, y, width, border);
            }
        }

        // GLAPI void APIENTRY glCopyTexImage2DEXT (GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        public static void CopyTexImage2DEXT(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
        {
            if (glCopyTexImage2DEXT != null)
            {
                glCopyTexImage2DEXT(target, level, internalformat, x, y, width, height, border);
            }
        }

        // GLAPI void APIENTRY glCopyTexSubImage1DEXT (GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        public static void CopyTexSubImage1DEXT(GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
        {
            if (glCopyTexSubImage1DEXT != null)
            {
                glCopyTexSubImage1DEXT(target, level, xoffset, x, y, width);
            }
        }

        // GLAPI void APIENTRY glCopyTexSubImage2DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        public static void CopyTexSubImage2DEXT(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glCopyTexSubImage2DEXT != null)
            {
                glCopyTexSubImage2DEXT(target, level, xoffset, yoffset, x, y, width, height);
            }
        }

        // GLAPI void APIENTRY glCopyTexSubImage3DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        public static void CopyTexSubImage3DEXT(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glCopyTexSubImage3DEXT != null)
            {
                glCopyTexSubImage3DEXT(target, level, xoffset, yoffset, zoffset, x, y, width, height);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_histogram
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetHistogramEXT (GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid *values);
        public unsafe static void GetHistogramEXT(GLenum target, GLboolean reset, GLenum format, GLenum type, IntPtr values)
        {
            if (glGetHistogramEXT != null)
            {
                glGetHistogramEXT(target, reset, format, type, values.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetHistogramParameterfvEXT (GLenum target, GLenum pname, GLfloat *params);
        public unsafe static void GetHistogramParameterfvEXT(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetHistogramParameterfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetHistogramParameterfvEXT(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetHistogramParameterivEXT (GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetHistogramParameterivEXT(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetHistogramParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetHistogramParameterivEXT(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMinmaxEXT (GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid *values);
        public unsafe static void GetMinmaxEXT(GLenum target, GLboolean reset, GLenum format, GLenum type, IntPtr values)
        {
            if (glGetMinmaxEXT != null)
            {
                glGetMinmaxEXT(target, reset, format, type, values.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetMinmaxParameterfvEXT (GLenum target, GLenum pname, GLfloat *params);
        public unsafe static void GetMinmaxParameterfvEXT(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetMinmaxParameterfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetMinmaxParameterfvEXT(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMinmaxParameterivEXT (GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetMinmaxParameterivEXT(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetMinmaxParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetMinmaxParameterivEXT(target, pname, ptr_parameters);
                }
            }
        }
        
        // GLAPI void APIENTRY glHistogramEXT (GLenum target, GLsizei width, GLenum internalformat, GLboolean sink);
        public static void HistogramEXT(GLenum target, GLsizei width, GLenum internalformat, GLboolean sink)
        {
            if (glHistogramEXT != null)
            {
                glHistogramEXT(target, width, internalformat, sink);
            }
        }
    
        // GLAPI void APIENTRY glMinmaxEXT (GLenum target, GLenum internalformat, GLboolean sink);
        public static void MinmaxEXT(GLenum target, GLenum internalformat, GLboolean sink)
        {
            if (glMinmaxEXT != null)
            {
                glMinmaxEXT(target, internalformat, sink);
            }
        }

        // GLAPI void APIENTRY glResetHistogramEXT (GLenum target);
        public static void ResetHistogramEXT(GLenum target)
        {
            if (glResetHistogramEXT != null)
            {
                ResetHistogramEXT(target);
            }
        }

        // GLAPI void APIENTRY glResetMinmaxEXT (GLenum target);
        public static void ResetMinmaxEXT(GLenum target)
        {
            if (glResetMinmaxEXT != null)
            {
                glResetMinmaxEXT(target);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_convolution
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glConvolutionFilter1DEXT (GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, const GLvoid *image);
        public unsafe static void ConvolutionFilter1DEXT(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, IntPtr image)
        {
            if (glConvolutionFilter1DEXT != null)
            {
                glConvolutionFilter1DEXT(target, internalformat, width, format, type, image.ToPointer());
            }
        }

        // GLAPI void APIENTRY glConvolutionFilter2DEXT (GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *image);
        public unsafe static void ConvolutionFilter2DEXT(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, IntPtr image)
        {
            if (glConvolutionFilter2DEXT != null)
            {
                glConvolutionFilter2DEXT(target, internalformat, width, height, format, type, image.ToPointer());
            }
        }

        // GLAPI void APIENTRY glConvolutionParameterfEXT (GLenum target, GLenum pname, GLfloat params);
        public static void ConvolutionParameterfEXT(GLenum target, GLenum pname, GLfloat parameters)
        {
            if (glConvolutionParameterfEXT != null)
            {
                glConvolutionParameterfEXT(target, pname, parameters);
            }
        }

        // GLAPI void APIENTRY glConvolutionParameterfvEXT (GLenum target, GLenum pname, const GLfloat *params);
        public unsafe static void ConvolutionParameterfvEXT(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glConvolutionParameterfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glConvolutionParameterfvEXT(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glConvolutionParameteriEXT (GLenum target, GLenum pname, GLint params);
        public static void ConvolutionParameteriEXT(GLenum target, GLenum pname, GLint parameters)
        {
            if (glConvolutionParameteriEXT != null)
            {
                glConvolutionParameteriEXT(target, pname, parameters);
            }
        }

        // GLAPI void APIENTRY glConvolutionParameterivEXT (GLenum target, GLenum pname, const GLint *params);
        public unsafe static void ConvolutionParameterivEXT(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glConvolutionParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glConvolutionParameterivEXT(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glCopyConvolutionFilter1DEXT (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
        public static void CopyConvolutionFilter1DEXT(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width)
        {
            if (glCopyConvolutionFilter1DEXT != null)
            {
                glCopyConvolutionFilter1DEXT(target, internalformat, x, y, width);
            }
        }

        // GLAPI void APIENTRY glCopyConvolutionFilter2DEXT (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
        public static void CopyConvolutionFilter2DEXT(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glCopyConvolutionFilter2DEXT != null)
            {
                glCopyConvolutionFilter2DEXT(target, internalformat, x, y, width, height);
            }
        }

        // GLAPI void APIENTRY glGetConvolutionFilterEXT (GLenum target, GLenum format, GLenum type, GLvoid *image);
        public unsafe static void GetConvolutionFilterEXT(GLenum target, GLenum format, GLenum type, IntPtr image)
        {
            if (glGetConvolutionFilterEXT != null)
            {
                glGetConvolutionFilterEXT(target, format, type, image.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetConvolutionParameterfvEXT (GLenum target, GLenum pname, GLfloat *params);
        public unsafe static void GetConvolutionParameterfvEXT(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetConvolutionParameterfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetConvolutionParameterfvEXT(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetConvolutionParameterivEXT (GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetConvolutionParameterivEXT(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetConvolutionParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetConvolutionParameterivEXT(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetSeparableFilterEXT (GLenum target, GLenum format, GLenum type, GLvoid *row, GLvoid *column, GLvoid *span);
        public unsafe static void GetSeparableFilterEXT(GLenum target, GLenum format, GLenum type, IntPtr row, IntPtr column, IntPtr span)
        {
            if (glGetSeparableFilterEXT != null)
            {
                glGetSeparableFilterEXT(target, format, type, row.ToPointer(), column.ToPointer(), span.ToPointer());
            }
        }

        // GLAPI void APIENTRY glSeparableFilter2DEXT (GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *row, const GLvoid *column);
        public unsafe static void SeparableFilter2DEXT(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, IntPtr row, IntPtr column)
        {
            if (glSeparableFilter2DEXT != null)
            {
                glSeparableFilter2DEXT(target, internalformat, width, height, format, type, row.ToPointer(), column.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_cmyka (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLboolean APIENTRY glAreTexturesResidentEXT (GLsizei n, const GLuint *textures, GLboolean *residences);
        public unsafe static GLboolean AreTexturesResidentEXT(GLsizei n, GLuint[] textures, GLboolean[] residences)
        {
            if (glAreTexturesResidentEXT != null)
            {
                fixed (GLuint* ptr_textures = textures)
                {
                    fixed (GLboolean* ptr_residences = residences)
                    {
                        return glAreTexturesResidentEXT(n, ptr_textures, ptr_residences);
                    }
                }
            }
            else
            {
                return false;
            }
        }
        
        // GLAPI void APIENTRY glBindTextureEXT (GLenum target, GLuint texture);
        public static void BindTextureEXT(GLenum target, GLuint texture)
        {
            if (glBindTextureEXT != null)
            {
                glBindTextureEXT(target, texture);
            }
        }

        // GLAPI void APIENTRY glDeleteTexturesEXT (GLsizei n, const GLuint *textures);
        public unsafe static void DeleteTexturesEXT(GLsizei n, GLuint[] textures)
        {
            if (glDeleteTexturesEXT != null)
            {
                fixed (GLuint* ptr_textures = textures)
                {
                    glDeleteTexturesEXT(n, ptr_textures);
                }
            }
        }

        // GLAPI void APIENTRY glGenTexturesEXT (GLsizei n, GLuint *textures);
        public unsafe static void GenTexturesEXT(GLsizei n, GLuint[] textures)
        {
            if (glGenTexturesEXT != null)
            {
                fixed (GLuint* ptr_textures = textures)
                {
                    glGenTexturesEXT(n, ptr_textures);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsTextureEXT (GLuint texture);
        public static GLboolean IsTextureEXT(GLuint texture)
        {
            if (glIsTextureEXT != null)
            {
                return glIsTextureEXT(texture);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glPrioritizeTexturesEXT (GLsizei n, const GLuint *textures, const GLclampf *priorities);
        public unsafe static void PrioritizeTexturesEXT(GLsizei n, GLuint[] textures, GLclampf[] priorities)
        {
            if (glPrioritizeTexturesEXT != null)
            {
                fixed (GLuint* ptr_textures = textures)
                {
                    fixed (GLclampf* ptr_priorities = priorities)
                    {
                        glPrioritizeTexturesEXT(n, ptr_textures, ptr_priorities);
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_packed_pixels (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_rescale_normal (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_vertex_array
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glArrayElementEXT (GLint i);
        public static void ArrayElementEXT(GLint i)
        {
            if (glArrayElementEXT != null)
            {
                glArrayElementEXT(i);
            }
        }

        // GLAPI void APIENTRY glColorPointerEXT (GLint size, GLenum type, GLsizei stride, GLsizei count, const GLvoid *pointer);
        public unsafe static void ColorPointerEXT(GLint size, GLenum type, GLsizei stride, GLsizei count, IntPtr pointer)
        {
            if (glColorPointerEXT != null)
            {
                glColorPointerEXT(size, type, stride, count, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glDrawArraysEXT (GLenum mode, GLint first, GLsizei count);
        public static void DrawArraysEXT(GLenum mode, GLint first, GLsizei count)
        {
            if (glDrawArraysEXT != null)
            {
                glDrawArraysEXT(mode, first, count);
            }
        }

        // GLAPI void APIENTRY glEdgeFlagPointerEXT (GLsizei stride, GLsizei count, const GLboolean *pointer);
        public unsafe static void EdgeFlagPointerEXT(GLsizei stride, GLsizei count, GLboolean[] pointer)
        {
            if (glEdgeFlagPointerEXT != null)
            {
                fixed (GLboolean* ptr_pointer = pointer)
                {
                    glEdgeFlagPointerEXT(stride, count, ptr_pointer);
                }
            }
        }

        // GLAPI void APIENTRY glGetPointervEXT (GLenum pname, GLvoid* *params);
        public unsafe static void GetPointervEXT(GLenum pname, IntPtr[] parameters)
        {
            if (glGetPointervEXT != null)
            {
                fixed (IntPtr* ptr_parameters = parameters)
                {
                    glGetPointervEXT(pname, (void**)ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glIndexPointerEXT (GLenum type, GLsizei stride, GLsizei count, const GLvoid *pointer);
        public unsafe static void IndexPointerEXT(GLenum type, GLsizei stride, GLsizei count, IntPtr pointer)
        {
            if (glIndexPointerEXT != null)
            {
                glIndexPointerEXT(type, stride, count, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glNormalPointerEXT (GLenum type, GLsizei stride, GLsizei count, const GLvoid *pointer);
        public unsafe static void NormalPointerEXT(GLenum type, GLsizei stride, GLsizei count, IntPtr pointer)
        {
            if (glNormalPointerEXT != null)
            {
                glNormalPointerEXT(type, stride, count, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glTexCoordPointerEXT (GLint size, GLenum type, GLsizei stride, GLsizei count, const GLvoid *pointer);
        public unsafe static void TexCoordPointerEXT(GLint size, GLenum type, GLsizei stride, GLsizei count, IntPtr pointer)
        {
            if (glTexCoordPointerEXT != null)
            {
                glTexCoordPointerEXT(size, type, stride, count, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glVertexPointerEXT (GLint size, GLenum type, GLsizei stride, GLsizei count, const GLvoid *pointer);
        public unsafe static void VertexPointerEXT(GLint size, GLenum type, GLsizei stride, GLsizei count, IntPtr pointer)
        {
            if (glVertexPointerEXT != null)
            {
                glVertexPointerEXT(size, type, stride, count, pointer.ToPointer());
            }
        }
        
        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_misc_attribute (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_minmax
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendEquationEXT (GLenum mode);
        public static void BlendEquationEXT(GLenum mode)
        {
            if (glBlendEquationEXT != null)
            {
                glBlendEquationEXT(mode);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_subtract (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_logic_op (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_point_parameters
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPointParameterfEXT (GLenum pname, GLfloat param);
        public static void PointParameterfEXT (GLenum pname, GLfloat param)
        {
            if (glPointParameterfEXT != null) 
            {
                glPointParameterfEXT (pname, param);
            }
        }
        
        // GLAPI void APIENTRY glPointParameterfvEXT (GLenum pname, const GLfloat *params);
        public unsafe static void PointParameterfvEXT (GLenum pname, GLfloat[] parameters)
        {
            if (glPointParameterfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glPointParameterfvEXT (pname, ptr_parameters);
                }
            }
        }
        
        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_color_subtable
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glColorSubTableEXT (GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, const GLvoid *data);
        public unsafe static void ColorSubTableEXT (GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, IntPtr data)
        {
            if (glColorSubTableEXT != null)
            {
                glColorSubTableEXT (target, start, count, format, type, data.ToPointer());
            }
        }
        
        // GLAPI void APIENTRY glCopyColorSubTableEXT (GLenum target, GLsizei start, GLint x, GLint y, GLsizei width);
        public static void CopyColorSubTableEXT (GLenum target, GLsizei start, GLint x, GLint y, GLsizei width)
        {
            if (glCopyColorSubTableEXT != null)
            {
                glCopyColorSubTableEXT (target, start, x, y, width);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_paletted_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glColorTableEXT (GLenum target, GLenum internalFormat, GLsizei width, GLenum format, GLenum type, const GLvoid *table);
        public unsafe static void ColorTableEXT (GLenum target, GLenum internalFormat, GLsizei width, GLenum format, GLenum type, IntPtr table)
        {
            if (glColorTableEXT != null) 
            {
                glColorTableEXT (target, internalFormat, width, format, type, table.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetColorTableEXT (GLenum target, GLenum format, GLenum type, GLvoid *data);
        public unsafe static void GetColorTableEXT (GLenum target, GLenum format, GLenum type, IntPtr data)
        {
            if (glGetColorTableEXT != null)
            {
            glGetColorTableEXT (target, format, type, data.ToPointer());
            }
        }
        
        // GLAPI void APIENTRY glGetColorTableParameterivEXT (GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetColorTableParameterivEXT (GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetColorTableParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetColorTableParameterivEXT (target, pname, ptr_parameters);
                }
            }
        }
        
        // GLAPI void APIENTRY glGetColorTableParameterfvEXT (GLenum target, GLenum pname, GLfloat *params);
        public unsafe static void GetColorTableParameterfvEXT (GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetColorTableParameterfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetColorTableParameterfvEXT (target, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_clip_volume_hint (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_index_texture (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_index_material
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glIndexMaterialEXT (GLenum face, GLenum mode);
        public static void IndexMaterialEXT(GLenum face, GLenum mode)
        {
            if (glIndexMaterialEXT != null)
            {
                glIndexMaterialEXT(face, mode);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_index_func
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glIndexFuncEXT (GLenum func, GLclampf ref);
        public static void IndexFuncEXT(GLenum func, GLclampf reference)
        {
            if (glIndexFuncEXT != null)
            {
                glIndexFuncEXT(func, reference);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_index_array_formats (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_compiled_vertex_array
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glLockArraysEXT (GLint first, GLsizei count);
        public static void LockArraysEXT (GLint first, GLsizei count)
        {
            if (glLockArraysEXT != null)
            {
                glLockArraysEXT (first, count);
            }
        }
        
        // GLAPI void APIENTRY glUnlockArraysEXT (void);
        public static void UnlockArraysEXT ()
        {
            if (glUnlockArraysEXT != null)
            {
                glUnlockArraysEXT ();
            }
        }
        
        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_cull_vertex
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCullParameterdvEXT (GLenum pname, GLdouble *params);
        public unsafe static void CullParameterdvEXT (GLenum pname, GLdouble[] parameters)
        {
            if (glCullParameterdvEXT != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glCullParameterdvEXT (pname, ptr_parameters);
                }
            }
        }
        
        // GLAPI void APIENTRY glCullParameterfvEXT (GLenum pname, GLfloat *params);
        public unsafe static void CullParameterfvEXT (GLenum pname, GLfloat[] parameters)
        {
            if (glCullParameterfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glCullParameterfvEXT (pname, ptr_parameters);
                }
            }
        }
        
        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_draw_range_elements
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDrawRangeElementsEXT (GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, const GLvoid *indices);
        public unsafe static void DrawRangeElementsEXT (GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, IntPtr indices)
        {
            if (glDrawRangeElementsEXT != null)
            {
                glDrawRangeElementsEXT (mode, start, end, count, type, indices.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_light_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glApplyTextureEXT (GLenum mode);
        public static void ApplyTextureEXT (GLenum mode)
        {
            if (glApplyTextureEXT != null)
            {
                glApplyTextureEXT (mode);
            }
        }
        
        // GLAPI void APIENTRY glTextureLightEXT (GLenum pname);
        public static void TextureLightEXT (GLenum pname)
        {
            if (glTextureLightEXT != null)
            {
                glTextureLightEXT (pname);
            }
        }
        
        // GLAPI void APIENTRY glTextureMaterialEXT (GLenum face, GLenum mode);
        public static void TextureMaterialEXT (GLenum face, GLenum mode)
        {
            if (glTextureMaterialEXT != null)
            {
                glTextureMaterialEXT (face, mode);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_bgra (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_pixel_transform
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPixelTransformParameteriEXT (GLenum target, GLenum pname, GLint param);
        public static void PixelTransformParameteriEXT (GLenum target, GLenum pname, GLint param)
        {
            if (glPixelTransformParameteriEXT != null)
            {
                glPixelTransformParameteriEXT (target, pname, param);
            }
        }
        
        // GLAPI void APIENTRY glPixelTransformParameterfEXT (GLenum target, GLenum pname, GLfloat param);
        public static void PixelTransformParameterfEXT (GLenum target, GLenum pname, GLfloat param)
        {
            if (glPixelTransformParameterfEXT != null)
            {
                glPixelTransformParameterfEXT (target, pname, param);
            }
        }
        
        // GLAPI void APIENTRY glPixelTransformParameterivEXT (GLenum target, GLenum pname, const GLint *params);
        public unsafe static void PixelTransformParameterivEXT (GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glPixelTransformParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glPixelTransformParameterivEXT (target, pname, ptr_parameters);
                }
            }
        }
        
        // GLAPI void APIENTRY glPixelTransformParameterfvEXT (GLenum target, GLenum pname, const GLfloat *params);
        public unsafe static void PixelTransformParameterfvEXT (GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glPixelTransformParameterfvEXT != null)
            {
                fixed(GLfloat* ptr_parameters = parameters)
                {
                    glPixelTransformParameterfvEXT (target, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_pixel_transform_color_table (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_shared_texture_palette (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_separate_specular_color (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_secondary_color
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glSecondaryColor3bEXT (GLbyte red, GLbyte green, GLbyte blue);
        public static void SecondaryColor3bEXT (GLbyte red, GLbyte green, GLbyte blue)
        {
            if (glSecondaryColor3bEXT != null)
            {
                glSecondaryColor3bEXT (red, green, blue);
            }
        }
        
        // GLAPI void APIENTRY glSecondaryColor3bvEXT (const GLbyte *v);
        public unsafe static void SecondaryColor3bvEXT (GLbyte[] v)
        {
            if (glSecondaryColor3bvEXT != null)
            {
                fixed (GLbyte* ptr_v = v)
                {
                    glSecondaryColor3bvEXT (ptr_v);
                }
            }
        }
        
        // GLAPI void APIENTRY glSecondaryColor3dEXT (GLdouble red, GLdouble green, GLdouble blue);
        public static void SecondaryColor3dEXT (GLdouble red, GLdouble green, GLdouble blue)
        {
            if (glSecondaryColor3dEXT != null)
            {
                glSecondaryColor3dEXT (red, green, blue);
            }
        }
        
        // GLAPI void APIENTRY glSecondaryColor3dvEXT (const GLdouble *v);
        public unsafe static void SecondaryColor3dvEXT (GLdouble[] v)
        {
            if (glSecondaryColor3dvEXT != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glSecondaryColor3dvEXT (ptr_v);
                }
            }
        }
        
        // GLAPI void APIENTRY glSecondaryColor3fEXT (GLfloat red, GLfloat green, GLfloat blue);
        public static void SecondaryColor3fEXT (GLfloat red, GLfloat green, GLfloat blue)
        {
            if (glSecondaryColor3fEXT != null)
            {
                glSecondaryColor3fEXT (red, green, blue);
            }
        }
        
        // GLAPI void APIENTRY glSecondaryColor3fvEXT (const GLfloat *v);
        public unsafe static void SecondaryColor3fvEXT (GLfloat[] v)
        {
            if (glSecondaryColor3fvEXT != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glSecondaryColor3fvEXT (ptr_v);
                }
            }
        }
        
        // GLAPI void APIENTRY glSecondaryColor3iEXT (GLint red, GLint green, GLint blue);
        public static void SecondaryColor3iEXT (GLint red, GLint green, GLint blue)
        {
            if (glSecondaryColor3iEXT != null)
            {
                glSecondaryColor3iEXT (red, green, blue);
            }
        }
        
        // GLAPI void APIENTRY glSecondaryColor3ivEXT (const GLint *v);
        public unsafe static void SecondaryColor3ivEXT (GLint[] v)
        {
            if (glSecondaryColor3ivEXT != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glSecondaryColor3ivEXT(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3sEXT (GLshort red, GLshort green, GLshort blue);
        public static void SecondaryColor3sEXT (GLshort red, GLshort green, GLshort blue)
        {
            if (glSecondaryColor3sEXT != null)
            {
                glSecondaryColor3sEXT(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3svEXT (const GLshort *v);
        public unsafe static void SecondaryColor3svEXT (GLshort[] v)
        {
            if (glSecondaryColor3svEXT != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glSecondaryColor3svEXT(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3ubEXT (GLubyte red, GLubyte green, GLubyte blue);
        public static void SecondaryColor3ubEXT (GLubyte red, GLubyte green, GLubyte blue)
        {
            if (glSecondaryColor3ubEXT != null)
            {
                glSecondaryColor3ubEXT(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3ubvEXT (const GLubyte *v);
        public unsafe static void SecondaryColor3ubvEXT (GLubyte[] v)
        {
            if (glSecondaryColor3ubvEXT != null)
            {
                fixed (GLubyte* ptr_v = v)
                {
                    glSecondaryColor3ubvEXT(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3uiEXT (GLuint red, GLuint green, GLuint blue);
        public static void SecondaryColor3uiEXT (GLuint red, GLuint green, GLuint blue)
        {
            if (glSecondaryColor3uiEXT != null)
            {
                glSecondaryColor3uiEXT(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3uivEXT (const GLuint *v);
        public unsafe static void SecondaryColor3uivEXT (GLuint[] v)
        {
            if (glSecondaryColor3uivEXT != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glSecondaryColor3uivEXT(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3usEXT (GLushort red, GLushort green, GLushort blue);
        public static void SecondaryColor3usEXT (GLushort red, GLushort green, GLushort blue)
        {
            if (glSecondaryColor3usEXT != null)
            {
                glSecondaryColor3usEXT(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3usvEXT (const GLushort *v);
        public unsafe static void SecondaryColor3usvEXT (GLushort[] v)
        {
            if (glSecondaryColor3usvEXT != null)
            {
                fixed (GLushort* ptr_v = v)
                {
                    glSecondaryColor3usvEXT(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColorPointerEXT (GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        public unsafe static void SecondaryColorPointerEXT (GLint size, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glSecondaryColorPointerEXT != null)
            {
                glSecondaryColorPointerEXT(size, type, stride, pointer.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_perturb_normal
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTextureNormalEXT (GLenum mode);
        public static void TextureNormalEXT (GLenum mode)
        {
            if (glTextureNormalEXT != null)
            {
                glTextureNormalEXT(mode);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_multi_draw_arrays
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMultiDrawArraysEXT (GLenum mode, const GLint *first, const GLsizei *count, GLsizei primcount);
        public unsafe static void MultiDrawArraysEXT (GLenum mode, GLint[] first, GLsizei[] count, GLsizei primcount)
        {
            if (glMultiDrawArraysEXT != null)
            {
                fixed (GLint* ptr_first = first)
                {
                    fixed(GLsizei* ptr_count = count)
                    {
                        glMultiDrawArraysEXT(mode, ptr_first, ptr_count, primcount);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glMultiDrawElementsEXT (GLenum mode, const GLsizei *count, GLenum type, const GLvoid* *indices, GLsizei primcount);
        public unsafe static void MultiDrawElementsEXT(GLenum mode, GLsizei[] count, GLenum type, IntPtr[] indices, GLsizei primcount)
        {
            if (glMultiDrawElementsEXT != null)
            {
                fixed (GLsizei* ptr_count = count)
                {
                    fixed (IntPtr* ptr_indices = indices)
                    {
                        glMultiDrawElementsEXT(mode, ptr_count, type, (void**)ptr_indices, primcount);
                    }
                }
            }
        }
             

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_fog_coord
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFogCoordfEXT (GLfloat coord);
        public static void FogCoordfEXT (GLfloat coord)
        {
            if (glFogCoordfEXT != null)
            {
                glFogCoordfEXT(coord);
            }
        }

        // GLAPI void APIENTRY glFogCoordfvEXT (const GLfloat *coord);
        public unsafe static void FogCoordfvEXT (GLfloat[] coord)
        {
            if (glFogCoordfvEXT != null)
            {
                fixed (GLfloat* ptr_coord = coord)
                {
                    glFogCoordfvEXT(ptr_coord);
                }
            }
        }
        
        // GLAPI void APIENTRY glFogCoorddEXT (GLdouble coord);
        public static void FogCoorddEXT(GLdouble coord)
        {
            if (glFogCoorddEXT != null)
            {
                glFogCoorddEXT(coord);
            }
        }

        // GLAPI void APIENTRY glFogCoorddvEXT (const GLdouble *coord);
        public unsafe static void FogCoorddvEXT (GLdouble[] coord)
        {
            if (glFogCoorddvEXT != null)
            {
                fixed (GLdouble* ptr_coord = coord)
                {
                    glFogCoorddvEXT(ptr_coord);
                }
            }
        }

        // GLAPI void APIENTRY glFogCoordPointerEXT (GLenum type, GLsizei stride, const GLvoid *pointer);
        public unsafe static void FogCoordPointerEXT (GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glFogCoordPointerEXT != null)
            {
                glFogCoordPointerEXT(type, stride, pointer.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_coordinate_frame
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTangent3bEXT (GLbyte tx, GLbyte ty, GLbyte tz);
        public static void Tangent3bEXT(GLbyte tx, GLbyte ty, GLbyte tz)
        {
            if (glTangent3bEXT != null)
            {
                glTangent3bEXT(tx, ty, tz);
            }
        }

        // GLAPI void APIENTRY glTangent3bvEXT (const GLbyte *v);
        public unsafe static void Tangent3bvEXT(GLbyte[] v)
        {
            if (glTangent3bvEXT != null)
            {
                fixed (GLbyte* ptr_v = v)
                {
                    glTangent3bvEXT(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glTangent3dEXT (GLdouble tx, GLdouble ty, GLdouble tz);
        public static void Tangent3dEXT(GLdouble tx, GLdouble ty, GLdouble tz)
        {
            if (glTangent3dEXT != null)
            {
                glTangent3dEXT(tx, ty, tz);
            }
        }

        // GLAPI void APIENTRY glTangent3dvEXT (const GLdouble *v);
        public unsafe static void Tangent3dvEXT(GLdouble[] v)
        {
            if (glTangent3dvEXT != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glTangent3dvEXT(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glTangent3fEXT (GLfloat tx, GLfloat ty, GLfloat tz);
        public static void Tangent3fEXT(GLfloat tx, GLfloat ty, GLfloat tz)
        {
            if (glTangent3fEXT != null)
            {
                glTangent3fEXT(tx, ty, tz);
            }
        }

        // GLAPI void APIENTRY glTangent3fvEXT (const GLfloat *v);
        public unsafe static void Tangent3fvEXT(GLfloat[] v)
        {
            if (glTangent3fvEXT != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glTangent3fvEXT(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glTangent3iEXT (GLint tx, GLint ty, GLint tz);
        public static void Tangent3iEXT(GLint tx, GLint ty, GLint tz)
        {
            if (glTangent3iEXT != null)
            {
                glTangent3iEXT(tx, ty, tz);
            }
        }

        // GLAPI void APIENTRY glTangent3ivEXT (const GLint *v);
        public unsafe static void Tangent3ivEXT(GLint[] v)
        {
            if (glTangent3ivEXT != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glTangent3ivEXT(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glTangent3sEXT (GLshort tx, GLshort ty, GLshort tz);
        public static void Tangent3sEXT(GLshort tx, GLshort ty, GLshort tz)
        {
            if (glTangent3sEXT != null)
            {
                glTangent3sEXT(tx, ty, tz);
            }
        }

        // GLAPI void APIENTRY glTangent3svEXT (const GLshort *v);
        public unsafe static void Tangent3svEXT(GLshort[] v)
        {
            if (glTangent3svEXT != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glTangent3svEXT(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glBinormal3bEXT (GLbyte bx, GLbyte by, GLbyte bz);
        public static void Binormal3bEXT(GLbyte bx, GLbyte by, GLbyte bz)
        {
            if (glBinormal3bEXT != null)
            {
                glBinormal3bEXT(bx, by, bz);
            }
        }

        // GLAPI void APIENTRY glBinormal3bvEXT (const GLbyte *v);
        public unsafe static void Binormal3bvEXT(GLbyte[] v)
        {
            if (glBinormal3bvEXT != null)
            {
                fixed (GLbyte* ptr_v = v)
                {
                    glBinormal3bvEXT(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glBinormal3dEXT (GLdouble bx, GLdouble by, GLdouble bz);
        public static void Binormal3dEXT(GLdouble bx, GLdouble by, GLdouble bz)
        {
            if (glBinormal3dEXT != null)
            {
                glBinormal3dEXT(bx, by, bz);
            }
        }
        
        // GLAPI void APIENTRY glBinormal3dvEXT (const GLdouble *v);
        public unsafe static void Binormal3dvEXT(GLdouble[] v)
        {
            if (glBinormal3dvEXT != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glBinormal3dvEXT(ptr_v);
                }
            }
        }
        
        // GLAPI void APIENTRY glBinormal3fEXT (GLfloat bx, GLfloat by, GLfloat bz);
        public static void Binormal3fEXT(GLfloat bx, GLfloat by, GLfloat bz)
        {
            if (glBinormal3fEXT != null)
            {
                glBinormal3fEXT(bx, by, bz);
            }
        }
        
        // GLAPI void APIENTRY glBinormal3fvEXT (const GLfloat *v);
        public unsafe static void Binormal3fvEXT(GLfloat[] v)
        {
            if (glBinormal3fvEXT != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glBinormal3fvEXT(ptr_v);
                }
            }
        }
        
        // GLAPI void APIENTRY glBinormal3iEXT (GLint bx, GLint by, GLint bz);
        public static void Binormal3iEXT(GLint bx, GLint by, GLint bz)
        {
            if (glBinormal3iEXT != null)
            {
                glBinormal3iEXT(bx, by, bz);
            }
        }
        
        // GLAPI void APIENTRY glBinormal3ivEXT (const GLint *v);
        public unsafe static void Binormal3ivEXT(GLint[] v)
        {
            if (glBinormal3ivEXT != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glBinormal3ivEXT(ptr_v);
                }
            }
        }
        
        // GLAPI void APIENTRY glBinormal3sEXT (GLshort bx, GLshort by, GLshort bz);
        public static void Binormal3sEXT(GLshort bx, GLshort by, GLshort bz)
        {
            if (glBinormal3sEXT != null)
            {
                glBinormal3sEXT(bx, by, bz);
            }
        }
        
        // GLAPI void APIENTRY glBinormal3svEXT (const GLshort *v);
        public unsafe static void Binormal3svEXT(GLshort[] v)
        {
            if (glBinormal3svEXT != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glBinormal3svEXT(ptr_v);
                }
            }
        }
        
        // GLAPI void APIENTRY glTangentPointerEXT (GLenum type, GLsizei stride, const GLvoid *pointer);
        public unsafe static void TangentPointerEXT(GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glTangentPointerEXT != null)
            {
                glTangentPointerEXT(type, stride, pointer.ToPointer());
            }
        }
        
        // GLAPI void APIENTRY glBinormalPointerEXT (GLenum type, GLsizei stride, const GLvoid *pointer);
        public unsafe static void BinormalPointerEXT(GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glBinormalPointerEXT != null)
            {
                glBinormalPointerEXT(type, stride, pointer.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_env_combine (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_func_separate
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendFuncSeparateEXT (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
        public static void BlendFuncSeparateEXT (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)
        {
            if (glBlendFuncSeparateEXT != null)
            {
                glBlendFuncSeparateEXT(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_stencil_wrap (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_422_pixels (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_env_add (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_lod_bias (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_filter_anisotropic (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_vertex_weighting
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexWeightfEXT (GLfloat weight);
        public static void VertexWeightfEXT(GLfloat weight)
        {
            if (glVertexWeightfEXT != null)
            {
                glVertexWeightfEXT(weight);
            }
        }

        // GLAPI void APIENTRY glVertexWeightfvEXT (const GLfloat *weight);
        public unsafe static void VertexWeightfvEXT(GLfloat[] weight)
        {
            if (glVertexWeightfvEXT != null)
            {
                fixed (GLfloat* ptr_weight = weight)
                {
                    glVertexWeightfvEXT(ptr_weight);
                }
            }
        }
        
        // GLAPI void APIENTRY glVertexWeightPointerEXT (GLsizei size, GLenum type, GLsizei stride, const GLvoid *pointer);
        public unsafe static void VertexWeightPointerEXT(GLsizei size, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glVertexWeightPointerEXT != null)
            {
                glVertexWeightPointerEXT(size, type, stride, pointer.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_multisample
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glSampleMaskEXT (GLclampf value, GLboolean invert);
        public static void SampleMaskEXT(GLclampf value, GLboolean invert)
        {
            if (glSampleMaskEXT != null)
            {
                glSampleMaskEXT(value, invert);
            }
        }

        // GLAPI void APIENTRY glSamplePatternEXT (GLenum pattern);
        public static void SamplePatternEXT(GLenum pattern)
        {
            if (glSamplePatternEXT != null)
            {
                glSamplePatternEXT(pattern);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_env_dot3 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_vertex_shader
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginVertexShaderEXT (void);
        public static void BeginVertexShaderEXT()
        {
            if (glBeginVertexShaderEXT != null)
            {
                glBeginVertexShaderEXT();
            }
        }

        // GLAPI void APIENTRY glEndVertexShaderEXT (void);
        public static void EndVertexShaderEXT()
        {
            if (glEndVertexShaderEXT != null)
            {
                glEndVertexShaderEXT();
            }
        }

        // GLAPI void APIENTRY glBindVertexShaderEXT (GLuint id);
        public static void BindVertexShaderEXT(GLuint id)
        {
            if (glBindVertexShaderEXT != null)
            {
                glBindVertexShaderEXT(id);
            }
        }

        // GLAPI GLuint APIENTRY glGenVertexShadersEXT (GLuint range);
        public static GLuint GenVertexShadersEXT(GLuint range)
        {
            if (glGenVertexShadersEXT != null)
            {
                return glGenVertexShadersEXT(range);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glDeleteVertexShaderEXT (GLuint id);
        public static void DeleteVertexShaderEXT(GLuint id)
        {
            if (glDeleteVertexShaderEXT != null)
            {
                glDeleteVertexShaderEXT(id);
            }
        }

        // GLAPI void APIENTRY glShaderOp1EXT (GLenum op, GLuint res, GLuint arg1);
        public static void ShaderOp1EXT(GLenum op, GLuint res, GLuint arg1)
        {
            if (glShaderOp1EXT != null)
            {
                glShaderOp1EXT(op, res, arg1);
            }
        }

        // GLAPI void APIENTRY glShaderOp2EXT (GLenum op, GLuint res, GLuint arg1, GLuint arg2);
        public static void ShaderOp2EXT(GLenum op, GLuint res, GLuint arg1, GLuint arg2)
        {
            if (glShaderOp2EXT != null)
            {
                glShaderOp2EXT(op, res, arg1, arg2);
            }
        }

        // GLAPI void APIENTRY glShaderOp3EXT (GLenum op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3);
        public static void ShaderOp3EXT(GLenum op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3)
        {
            if (glShaderOp3EXT != null)
            {
                glShaderOp3EXT(op, res, arg1, arg2, arg3);
            }
        }

        // GLAPI void APIENTRY glSwizzleEXT (GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);
        public static void SwizzleEXT(GLuint res, GLuint inParam, GLenum outX, GLenum outY, GLenum outZ, GLenum outW)
        {
            if (glSwizzleEXT != null)
            {
                glSwizzleEXT (res, inParam, outX, outY, outZ, outW);
            }
        }

        // GLAPI void APIENTRY glWriteMaskEXT (GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);
        public static void WriteMaskEXT(GLuint res, GLuint inParam, GLenum outX, GLenum outY, GLenum outZ, GLenum outW)
        {
            if (glWriteMaskEXT != null)
            {
                glWriteMaskEXT(res, inParam, outX, outY, outZ, outW);
            }
        }

        // GLAPI void APIENTRY glInsertComponentEXT (GLuint res, GLuint src, GLuint num);
        public static void InsertComponentEXT(GLuint res, GLuint src, GLuint num)
        {
            if (glInsertComponentEXT != null)
            {
                glInsertComponentEXT(res, src, num);
            }
        }

        // GLAPI void APIENTRY glExtractComponentEXT (GLuint res, GLuint src, GLuint num);
        public static void ExtractComponentEXT(GLuint res, GLuint src, GLuint num)
        {
            if (glExtractComponentEXT != null)
            {
                glExtractComponentEXT(res, src, num);
            }
        }

        // GLAPI GLuint APIENTRY glGenSymbolsEXT (GLenum datatype, GLenum storagetype, GLenum range, GLuint components);
        public static GLuint GenSymbolsEXT(GLenum datatype, GLenum storagetype, GLenum range, GLuint components)
        {
            if (glGenSymbolsEXT != null)
            {
                return glGenSymbolsEXT(datatype, storagetype, range, components);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glSetInvariantEXT (GLuint id, GLenum type, const GLvoid *addr);
        public unsafe static void SetInvariantEXT(GLuint id, GLenum type, IntPtr addr)
        {
            if (glSetInvariantEXT != null)
            {
                glSetInvariantEXT(id, type, addr.ToPointer());
            }
        }

        // GLAPI void APIENTRY glSetLocalConstantEXT (GLuint id, GLenum type, const GLvoid *addr);
        public unsafe static void SetLocalConstantEXT(GLuint id, GLenum type, IntPtr addr)
        {
            if (glSetLocalConstantEXT != null)
            {
                glSetLocalConstantEXT(id, type, addr.ToPointer());
            }
        }

        // GLAPI void APIENTRY glVariantbvEXT (GLuint id, const GLbyte *addr);
        public unsafe static void VariantbvEXT(GLuint id, GLbyte[] addr)
        {
            if (glVariantbvEXT != null)
            {
                fixed (GLbyte* ptr_addr = addr)
                {
                    glVariantbvEXT(id, ptr_addr);
                }
            }
        }

        // GLAPI void APIENTRY glVariantsvEXT (GLuint id, const GLshort *addr);
        public unsafe static void VariantsvEXT(GLuint id, GLshort[] addr)
        {
            if (glVariantsvEXT != null)
            {
                fixed (GLshort* ptr_addr = addr)
                {
                    glVariantsvEXT(id, ptr_addr);
                }
            }
        }

        // GLAPI void APIENTRY glVariantivEXT (GLuint id, const GLint *addr);
        public unsafe static void VariantivEXT(GLuint id, GLint[] addr)
        {
            if (glVariantivEXT != null)
            {
                fixed (GLint* ptr_addr = addr)
                {
                    glVariantivEXT(id, ptr_addr);
                }
            }
        }

        // GLAPI void APIENTRY glVariantfvEXT (GLuint id, const GLfloat *addr);
        public unsafe static void VariantfvEXT(GLuint id, GLfloat[] addr)
        {
            if (glVariantfvEXT != null)
            {
                fixed (GLfloat* ptr_addr = addr)
                {
                    glVariantfvEXT(id, ptr_addr);
                }
            }
        }

        // GLAPI void APIENTRY glVariantdvEXT (GLuint id, const GLdouble *addr);
        public unsafe static void VariantdvEXT(GLuint id, GLdouble[] addr)
        {
            if (glVariantdvEXT != null)
            {
                fixed (GLdouble* ptr_addr = addr)
                {
                    glVariantdvEXT(id, ptr_addr);
                }
            }
        }

        // GLAPI void APIENTRY glVariantubvEXT (GLuint id, const GLubyte *addr);
        public unsafe static void VariantubvEXT(GLuint id, GLubyte[] addr)
        {
            if (glVariantubvEXT != null)
            {
                fixed (GLubyte* ptr_addr = addr)
                {
                    glVariantubvEXT(id, ptr_addr);
                }
            }
        }

        // GLAPI void APIENTRY glVariantusvEXT (GLuint id, const GLushort *addr);
        public unsafe static void VariantusvEXT(GLuint id, GLushort[] addr)
        {
            if (glVariantusvEXT != null)
            {
                fixed (GLushort* ptr_addr = addr)
                {
                    glVariantusvEXT(id, ptr_addr);
                }
            }
        }

        // GLAPI void APIENTRY glVariantuivEXT (GLuint id, const GLuint *addr);
        public unsafe static void VariantuivEXT(GLuint id, GLuint[] addr)
        {
            if (glVariantuivEXT != null)
            {
                fixed (GLuint* ptr_addr = addr)
                {
                    glVariantuivEXT(id, ptr_addr);
                }
            }
        }

        // GLAPI void APIENTRY glVariantPointerEXT (GLuint id, GLenum type, GLuint stride, const GLvoid *addr);
        public unsafe static void VariantPointerEXT(GLuint id, GLenum type, GLuint stride, IntPtr addr)
        {
            if (glVariantPointerEXT != null)
            {
                glVariantPointerEXT(id, type, stride, addr.ToPointer());
            }
        }

        // GLAPI void APIENTRY glEnableVariantClientStateEXT (GLuint id);
        public static void EnableVariantClientStateEXT(GLuint id)
        {
            if (glEnableVariantClientStateEXT != null)
            {
                glEnableVariantClientStateEXT(id);
            }
        }

        // GLAPI void APIENTRY glDisableVariantClientStateEXT (GLuint id);
        public static void DisableVariantClientStateEXT(GLuint id)
        {
            if (glDisableVariantClientStateEXT != null)
            {
                glDisableVariantClientStateEXT(id);
            }
        }

        // GLAPI GLuint APIENTRY glBindLightParameterEXT (GLenum light, GLenum value);
        public static GLuint BindLightParameterEXT(GLenum light, GLenum value)
        {
            if (glBindLightParameterEXT != null)
            {
                return glBindLightParameterEXT(light, value);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLuint APIENTRY glBindMaterialParameterEXT (GLenum face, GLenum value);
        public static GLuint BindMaterialParameterEXT(GLenum face, GLenum value)
        {
            if (glBindMaterialParameterEXT != null)
            {
                return glBindMaterialParameterEXT(face, value);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLuint APIENTRY glBindTexGenParameterEXT (GLenum unit, GLenum coord, GLenum value);
        public static GLuint BindTexGenParameterEXT(GLenum unit, GLenum coord, GLenum value)
        {
            if (glBindTexGenParameterEXT != null)
            {
                return glBindTexGenParameterEXT(unit, coord, value);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLuint APIENTRY glBindTextureUnitParameterEXT (GLenum unit, GLenum value);
        public static GLuint BindTextureUnitParameterEXT(GLenum unit, GLenum value)
        {
            if (glBindTextureUnitParameterEXT != null)
            {
                return glBindTextureUnitParameterEXT(unit, value);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLuint APIENTRY glBindParameterEXT (GLenum value);
        public static GLuint BindParameterEXT(GLenum value)
        {
            if (glBindParameterEXT != null)
            {
                return glBindParameterEXT(value);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLboolean APIENTRY glIsVariantEnabledEXT (GLuint id, GLenum cap);
        public static GLboolean IsVariantEnabledEXT(GLuint id, GLenum cap)
        {
            if (glIsVariantEnabledEXT != null)
            {
                return glIsVariantEnabledEXT(id, cap);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glGetVariantBooleanvEXT (GLuint id, GLenum value, GLboolean *data);
        public unsafe static void GetVariantBooleanvEXT(GLuint id, GLenum value, GLboolean[] data)
        {
            if (glGetVariantBooleanvEXT != null)
            {
                fixed (GLboolean* ptr_data = data)
                {
                    glGetVariantBooleanvEXT(id, value, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetVariantIntegervEXT (GLuint id, GLenum value, GLint *data);
        public unsafe static void GetVariantIntegervEXT(GLuint id, GLenum value, GLint[] data)
        {
            if (glGetVariantIntegervEXT != null)
            {
                fixed (GLint* ptr_data = data)
                {
                    glGetVariantIntegervEXT(id, value, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetVariantFloatvEXT (GLuint id, GLenum value, GLfloat *data);
        public unsafe static void GetVariantFloatvEXT(GLuint id, GLenum value, GLfloat[] data)
        {
            if (glGetVariantFloatvEXT != null)
            {
                fixed (GLfloat* ptr_data = data)
                {
                    glGetVariantFloatvEXT(id, value, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetVariantPointervEXT (GLuint id, GLenum value, GLvoid* *data);
        public unsafe static void GetVariantPointervEXT(GLuint id, GLenum value, IntPtr[] data)
        {
            if (glGetVariantPointervEXT != null)
            {
                fixed (IntPtr* ptr_data = data)
                {
                    glGetVariantPointervEXT(id, value, (void**)ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetInvariantBooleanvEXT (GLuint id, GLenum value, GLboolean *data);
        public unsafe static void GetInvariantBooleanvEXT(GLuint id, GLenum value, GLboolean[] data)
        {
            if (glGetInvariantBooleanvEXT != null)
            {
                fixed (GLboolean* ptr_data = data)
                {
                    glGetInvariantBooleanvEXT(id, value, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetInvariantIntegervEXT (GLuint id, GLenum value, GLint *data);
        public unsafe static void GetInvariantIntegervEXT(GLuint id, GLenum value, GLint[] data)
        {
            if (glGetInvariantIntegervEXT != null)
            {
                fixed (GLint* ptr_data = data)
                {
                    glGetInvariantIntegervEXT(id, value, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetInvariantFloatvEXT (GLuint id, GLenum value, GLfloat *data);
        public unsafe static void GetInvariantFloatvEXT(GLuint id, GLenum value, GLfloat[] data)
        {
            if (glGetInvariantFloatvEXT != null)
            {
                fixed (GLfloat* ptr_data = data)
                {
                    glGetInvariantFloatvEXT(id, value, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetLocalConstantBooleanvEXT (GLuint id, GLenum value, GLboolean *data);
        public unsafe static void GetLocalConstantBooleanvEXT(GLuint id, GLenum value, GLboolean[] data)
        {
            if (glGetLocalConstantBooleanvEXT != null)
            {
                fixed (GLboolean* ptr_data = data)
                {
                    glGetLocalConstantBooleanvEXT(id, value, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetLocalConstantIntegervEXT (GLuint id, GLenum value, GLint *data);
        public unsafe static void GetLocalConstantIntegervEXT(GLuint id, GLenum value, GLint[] data)
        {
            if (glGetLocalConstantIntegervEXT != null)
            {
                fixed (GLint* ptr_data = data)
                {
                    glGetLocalConstantIntegervEXT(id, value, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetLocalConstantFloatvEXT (GLuint id, GLenum value, GLfloat *data);
        public unsafe static void GetLocalConstantFloatvEXT(GLuint id, GLenum value, GLfloat[] data)
        {
            if (glGetLocalConstantFloatvEXT != null)
            {
                fixed (GLfloat* ptr_data = data)
                {
                    glGetLocalConstantFloatvEXT(id, value, ptr_data);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_shadow_funcs (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_stencil_two_side (no function entry points)
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glActiveStencilFaceEXT (GLenum face);
        public static void ActiveStencilFaceEXT(GLenum face)
        {
            if (glActiveStencilFaceEXT != null)
            {
                glActiveStencilFaceEXT(face);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_depth_bounds_test
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDepthBoundsEXT (GLclampd zmin, GLclampd zmax);
        public static void DepthBoundsEXT(GLclampd zmin, GLclampd zmax)
        {
            if (glDepthBoundsEXT != null)
            {
                glDepthBoundsEXT(zmin, zmax);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_mirror_clamp (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_equation_separate
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendEquationSeparateEXT (GLenum modeRGB, GLenum modeAlpha);
        public static void BlendEquationSeparateEXT(GLenum modeRGB, GLenum modeAlpha)
        {
            if (glBlendEquationSeparateEXT != null)
            {
                glBlendEquationSeparateEXT(modeRGB, modeAlpha);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_pixel_buffer_object (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_framebuffer_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLboolean APIENTRY glIsRenderbufferEXT (GLuint renderbuffer);
        public static GLboolean IsRenderbufferEXT (GLuint renderbuffer)
        {
            if (glIsRenderbufferEXT != null)
            {
                return glIsRenderbufferEXT(renderbuffer);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glBindRenderbufferEXT (GLenum target, GLuint renderbuffer);
        public static void BindRenderbufferEXT (GLenum target, GLuint renderbuffer)
        {
            if (glBindRenderbufferEXT != null)
            {
                glBindRenderbufferEXT(target, renderbuffer);
            }
        }

        // GLAPI void APIENTRY glDeleteRenderbuffersEXT (GLsizei n, const GLuint *renderbuffers);
        public unsafe static void DeleteRenderbuffersEXT (GLsizei n, GLuint[] renderbuffers)
        {
            if (glDeleteRenderbuffersEXT != null)
            {
                fixed(GLuint* ptr_renderbuffers = renderbuffers)
                {
                    glDeleteRenderbuffersEXT(n, ptr_renderbuffers);
                }
            }
        }
        
        // GLAPI void APIENTRY glGenRenderbuffersEXT (GLsizei n, GLuint *renderbuffers);
        public unsafe static void GenRenderbuffersEXT(GLsizei n, GLuint[] renderbuffers)
        {
            if (glGenRenderbuffersEXT != null)
            {
                fixed (GLuint* ptr_renderbuffers = renderbuffers)
                {
                    glGenRenderbuffersEXT(n, ptr_renderbuffers);
                }
            }
        }
        
        // GLAPI void APIENTRY glRenderbufferStorageEXT (GLenum target, GLenum internalformat, GLsizei width, GLsizei height);
        public static void RenderbufferStorageEXT (GLenum target, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glRenderbufferStorageEXT != null)
            {
                glRenderbufferStorageEXT(target, internalformat, width, height);
            }
        }

        // GLAPI void APIENTRY glGetRenderbufferParameterivEXT (GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetRenderbufferParameterivEXT (GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetRenderbufferParameterivEXT != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glGetRenderbufferParameterivEXT(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsFramebufferEXT (GLuint framebuffer);
        public static GLboolean IsFramebufferEXT (GLuint framebuffer)
        {
            if (glIsFramebufferEXT != null)
            {
                return glIsFramebufferEXT(framebuffer);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glBindFramebufferEXT (GLenum target, GLuint framebuffer);
        public static void BindFramebufferEXT (GLenum target, GLuint framebuffer)
        {
            if (glBindFramebufferEXT != null)
            {
                glBindFramebufferEXT(target, framebuffer);
            }
        }
        
        // GLAPI void APIENTRY glDeleteFramebuffersEXT (GLsizei n, const GLuint *framebuffers);
        public unsafe static void DeleteFramebuffersEXT (GLsizei n, GLuint[] framebuffers)
        {
            if (glDeleteFramebuffersEXT != null)
            {
                fixed(GLuint* ptr_framebuffers = framebuffers)
                {
                    glDeleteFramebuffersEXT(n, ptr_framebuffers);
                }
            }
        }
        
        // GLAPI void APIENTRY glGenFramebuffersEXT (GLsizei n, GLuint *framebuffers);
        public unsafe static void GenFramebuffersEXT (GLsizei n, GLuint[] framebuffers)
        {
            if (glGenFramebuffersEXT != null)
            {
                fixed(GLuint* ptr_framebuffers = framebuffers)
                {
                    glGenFramebuffersEXT(n, ptr_framebuffers);
                }
            }
        }
        
        // GLAPI GLenum APIENTRY glCheckFramebufferStatusEXT (GLenum target);
        public static GLenum CheckFramebufferStatusEXT (GLenum target)
        {
            if (glCheckFramebufferStatusEXT != null)
            {
                return glCheckFramebufferStatusEXT(target);
            }
            else
            {
                return 0;
            }
        }
        
        // GLAPI void APIENTRY glFramebufferTexture1DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        public static void FramebufferTexture1DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
        {
            if (glFramebufferTexture1DEXT != null)
            {
                glFramebufferTexture1DEXT(target, attachment, textarget, texture, level);
            }
        }
        
        // GLAPI void APIENTRY glFramebufferTexture2DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        public static void FramebufferTexture2DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
        {
            if (glFramebufferTexture2DEXT != null)
            {
                glFramebufferTexture2DEXT(target, attachment, textarget, texture, level);
            }
        }
        
        // GLAPI void APIENTRY glFramebufferTexture3DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);
        public static void FramebufferTexture3DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset)
        {
            if (glFramebufferTexture3DEXT != null)
            {
                glFramebufferTexture3DEXT(target, attachment, textarget, texture, level, zoffset);
            }
        }
        
        // GLAPI void APIENTRY glFramebufferRenderbufferEXT (GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
        public static void FramebufferRenderbufferEXT (GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)
        {
            if (glFramebufferRenderbufferEXT != null)
            {
                glFramebufferRenderbufferEXT(target, attachment, renderbuffertarget, renderbuffer);
            }
        }
        
        // GLAPI void APIENTRY glGetFramebufferAttachmentParameterivEXT (GLenum target, GLenum attachment, GLenum pname, GLint *params);
        public unsafe static void GetFramebufferAttachmentParameterivEXT (GLenum target, GLenum attachment, GLenum pname, GLint[] parameters)
        {
            if (glGetFramebufferAttachmentParameterivEXT != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glGetFramebufferAttachmentParameterivEXT(target, attachment, pname, ptr_parameters);
                }
            }
        }
        
        // GLAPI void APIENTRY glGenerateMipmapEXT (GLenum target);
        public static void GenerateMipmapEXT (GLenum target)
        {
            if (glGenerateMipmapEXT != null)
            {
                glGenerateMipmapEXT(target);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_packed_depth_stencil (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_stencil_clear_tag
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glStencilClearTagEXT (GLsizei stencilTagBits, GLuint stencilClearTag);
        public static void StencilClearTagEXT(GLsizei stencilTagBits, GLuint stencilClearTag)
        {
            if (glStencilClearTagEXT != null)
            {
                glStencilClearTagEXT(stencilTagBits, stencilClearTag);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_sRGB (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_framebuffer_blit
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlitFramebufferEXT (GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);
        public static void BlitFramebufferEXT(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)
        {
            if (glBlitFramebufferEXT != null)
            {
                glBlitFramebufferEXT(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_framebuffer_multisample
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glRenderbufferStorageMultisampleEXT (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
        public static void RenderbufferStorageMultisampleEXT(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glRenderbufferStorageMultisampleEXT != null)
            {
                glRenderbufferStorageMultisampleEXT(target, samples, internalformat, width, height);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_timer_query
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetQueryObjecti64vEXT (GLuint id, GLenum pname, GLint64EXT *params);
        public unsafe static void GetQueryObjecti64vEXT(GLuint id, GLenum pname, GLint64[] parameters)
        {
            if (glGetQueryObjecti64vEXT != null)
            {
                fixed (GLint64* ptr_parameters = parameters)
                {
                    glGetQueryObjecti64vEXT(id, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetQueryObjectui64vEXT (GLuint id, GLenum pname, GLuint64EXT *params);
        public unsafe static void GetQueryObjectui64vEXT(GLuint id, GLenum pname, GLuint64[] parameters)
        {
            if (glGetQueryObjectui64vEXT != null)
            {
                fixed (GLuint64* ptr_parameters = parameters)
                {
                    glGetQueryObjectui64vEXT(id, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_gpu_program_parameters
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glProgramEnvParameters4fvEXT (GLenum target, GLuint index, GLsizei count, const GLfloat *params);
        public unsafe static void ProgramEnvParameters4fvEXT (GLenum target, GLuint index, GLsizei count, GLfloat[] parameters)
        {
            if (glProgramEnvParameters4fvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glProgramEnvParameters4fvEXT(target, index, count, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramLocalParameters4fvEXT (GLenum target, GLuint index, GLsizei count, const GLfloat *params);
        public unsafe static void ProgramLocalParameters4fvEXT(GLenum target, GLuint index, GLsizei count, GLfloat[] parameters)
        {
            if (glProgramLocalParameters4fvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glProgramLocalParameters4fvEXT(target, index, count, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_geometry_shader4
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glProgramParameteriEXT (GLuint program, GLenum pname, GLint value);
        public static void ProgramParameteriEXT (GLuint program, GLenum pname, GLint value)
        {
            if (glProgramParameteriEXT != null)
            {
                glProgramParameteriEXT(program, pname, value);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_gpu_shader4
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetUniformuivEXT (GLuint program, GLint location, GLuint *params);
        public unsafe static void GetUniformuivEXT (GLuint program, GLint location, GLuint[] parameters)
        {
            if (glGetUniformuivEXT != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetUniformuivEXT(program, location, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glBindFragDataLocationEXT (GLuint program, GLuint color, const GLchar *name);
        public static void BindFragDataLocationEXT(GLuint program, GLuint color, string name)
        {
            if (glBindFragDataLocationEXT != null)
            {
                glBindFragDataLocationEXT(program, color, name);
            }
        }

        // GLAPI GLint APIENTRY glGetFragDataLocationEXT (GLuint program, const GLchar *name);
        public static GLint GetFragDataLocationEXT (GLuint program, string name)
        {
            if (glGetFragDataLocationEXT != null)
            {
                return glGetFragDataLocationEXT(program, name);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glUniform1uiEXT (GLint location, GLuint v0);
        public static void Uniform1uiEXT (GLint location, GLuint v0)
        {
            if (glUniform1uiEXT != null)
            {
                glUniform1uiEXT(location, v0);
            }
        }

        // GLAPI void APIENTRY glUniform2uiEXT (GLint location, GLuint v0, GLuint v1);
        public static void Uniform2uiEXT(GLint location, GLuint v0, GLuint v1)
        {
            if (glUniform2uiEXT != null)
            {
                glUniform2uiEXT(location, v0, v1);
            }
        }

        // GLAPI void APIENTRY glUniform3uiEXT (GLint location, GLuint v0, GLuint v1, GLuint v2);
        public static void Uniform3uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2)
        {
            if (glUniform3uiEXT != null)
            {
                glUniform3uiEXT(location, v0, v1, v2);
            }
        }

        // GLAPI void APIENTRY glUniform4uiEXT (GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
        public static void Uniform4uiEXT (GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
        {
            if (glUniform4uiEXT != null)
            {
                glUniform4uiEXT(location, v0, v1, v2, v3);
            }
        }

        // GLAPI void APIENTRY glUniform1uivEXT (GLint location, GLsizei count, const GLuint *value);
        public unsafe static void Uniform1uivEXT (GLint location, GLsizei count, GLuint[] value)
        {
            if (glUniform1uivEXT != null)
            {
                fixed(GLuint* ptr_value = value)
                {
                    glUniform1uivEXT(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform2uivEXT (GLint location, GLsizei count, const GLuint *value);
        public unsafe static void Uniform2uivEXT (GLint location, GLsizei count, GLuint[] value)
        {
            if (glUniform2uivEXT != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glUniform2uivEXT(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform3uivEXT (GLint location, GLsizei count, const GLuint *value);
        public unsafe static void Uniform3uivEXT (GLint location, GLsizei count, GLuint[] value)
        {
            if (glUniform3uivEXT != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glUniform3uivEXT(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform4uivEXT (GLint location, GLsizei count, const GLuint *value);
        public unsafe static void Uniform4uivEXT (GLint location, GLsizei count, GLuint[] value)
        {
            if (glUniform4uivEXT != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glUniform4uivEXT(location, count, ptr_value);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_draw_instanced
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDrawArraysInstancedEXT (GLenum mode, GLint start, GLsizei count, GLsizei primcount);
        public static void DrawArraysInstancedEXT(GLenum mode, GLint start, GLsizei count, GLsizei primcount)
        {
            if (glDrawArraysInstancedEXT != null)
            {
                glDrawArraysInstancedEXT(mode, start, count, primcount);
            }
        }

        // GLAPI void APIENTRY glDrawElementsInstancedEXT (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLsizei primcount);
        public unsafe static void DrawElementsInstancedEXT(GLenum mode, GLsizei count, GLenum type, IntPtr indices, GLsizei primcount)
        {
            if (glDrawElementsInstancedEXT != null)
            {
                glDrawElementsInstancedEXT(mode, count, type, indices.ToPointer(), primcount);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_packed_float (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_array (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_buffer_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexBufferEXT (GLenum target, GLenum internalformat, GLuint buffer);
        public static void TexBufferEXT (GLenum target, GLenum internalformat, GLuint buffer)
        {
            if (glTexBufferEXT != null)
            {
                glTexBufferEXT(target, internalformat, buffer);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_compression_latc (no function entry point)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_compression_rgtc (no function entry point)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_shared_exponent (no function entry point)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_framebuffer_sRGB (no function entry point)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_draw_buffers2
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glColorMaskIndexedEXT (GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);
        public static void ColorMaskIndexedEXT(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a)
        {
            if (glColorMaskIndexedEXT != null)
            {
                glColorMaskIndexedEXT(index, r, g, b, a);
            }
        }

        // GLAPI void APIENTRY glGetBooleanIndexedvEXT (GLenum target, GLuint index, GLboolean *data);
        public unsafe static void GetBooleanIndexedvEXT(GLenum target, GLuint index, GLboolean[] data)
        {
            if (glGetBooleanIndexedvEXT != null)
            {
                fixed (GLboolean* ptr_data = data)
                {
                    glGetBooleanIndexedvEXT(target, index, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetIntegerIndexedvEXT (GLenum target, GLuint index, GLint *data);
        public unsafe static void GetIntegerIndexedvEXT(GLenum target, GLuint index, GLint[] data)
        {
            if (glGetIntegerIndexedvEXT != null)
            {
                fixed (GLint* ptr_data = data)
                {
                    glGetIntegerIndexedvEXT(target, index, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glEnableIndexedEXT (GLenum target, GLuint index);
        public static void EnableIndexedEXT(GLenum target, GLuint index)
        {
            if (glEnableIndexedEXT != null)
            {
                glEnableIndexedEXT(target, index);
            }
        }

        // GLAPI void APIENTRY glDisableIndexedEXT (GLenum target, GLuint index);
        public static void DisableIndexedEXT(GLenum target, GLuint index)
        {
            if (glDisableIndexedEXT != null)
            {
                glDisableIndexedEXT(target, index);
            }
        }

        // GLAPI GLboolean APIENTRY glIsEnabledIndexedEXT (GLenum target, GLuint index);
        public static GLboolean IsEnabledIndexedEXT(GLenum target, GLuint index)
        {
            if (glIsEnabledIndexedEXT != null)
            {
                return glIsEnabledIndexedEXT(target, index);
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_bindable_uniform
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glUniformBufferEXT (GLuint program, GLint location, GLuint buffer);
        public static void UniformBufferEXT(GLuint program, GLint location, GLuint buffer)
        {
            if (glUniformBufferEXT != null)
            {
                glUniformBufferEXT(program, location, buffer);
            }
        }

        // GLAPI GLint APIENTRY glGetUniformBufferSizeEXT (GLuint program, GLint location);
        public static GLint GetUniformBufferSizeEXT(GLuint program, GLint location)
        {
            if (glGetUniformBufferSizeEXT != null)
            {
                return glGetUniformBufferSizeEXT(program, location);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLintptr APIENTRY glGetUniformOffsetEXT (GLuint program, GLint location);
        public static GLintptr GetUniformOffsetEXT(GLuint program, GLint location)
        {
            if (glGetUniformOffsetEXT != null)
            {
                return glGetUniformOffsetEXT(program, location);
            }
            else
            {
                return 0;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_integer
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexParameterIivEXT (GLenum target, GLenum pname, const GLint *params);
        public unsafe static void TexParameterIivEXT(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glTexParameterIivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glTexParameterIivEXT(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glTexParameterIuivEXT (GLenum target, GLenum pname, const GLuint *params);
        public unsafe static void TexParameterIuivEXT(GLenum target, GLenum pname, GLuint[] parameters)
        {
            if (glTexParameterIuivEXT != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glTexParameterIuivEXT(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTexParameterIivEXT (GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetTexParameterIivEXT(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetTexParameterIivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetTexParameterIivEXT(target, pname, ptr_parameters);
                }
            }
        }
        
        // GLAPI void APIENTRY glGetTexParameterIuivEXT (GLenum target, GLenum pname, GLuint *params);
        public unsafe static void GetTexParameterIuivEXT(GLenum target, GLenum pname, GLuint[] parameters)
        {
            if (glGetTexParameterIuivEXT != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetTexParameterIuivEXT(target, pname, ptr_parameters);
                }
            }
        }
        
        // GLAPI void APIENTRY glClearColorIiEXT (GLint red, GLint green, GLint blue, GLint alpha);
        public static void ClearColorIiEXT(GLint red, GLint green, GLint blue, GLint alpha)
        {
            if (glClearColorIiEXT != null)
            {
                glClearColorIiEXT(red, green, blue, alpha);
            }
        }
        
        // GLAPI void APIENTRY glClearColorIuiEXT (GLuint red, GLuint green, GLuint blue, GLuint alpha);
        public static void ClearColorIuiEXT(GLuint red, GLuint green, GLuint blue, GLuint alpha)
        {
            if (glClearColorIuiEXT != null)
            {
                glClearColorIuiEXT(red, green, blue, alpha);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_transform_feedback
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginTransformFeedbackEXT (GLenum primitiveMode);
        public static void BeginTransformFeedbackEXT(GLenum primitiveMode)
        {
            if (glBeginTransformFeedbackEXT != null)
            {
                glBeginTransformFeedbackEXT(primitiveMode);
            }
        }

        // GLAPI void APIENTRY glEndTransformFeedbackEXT (void);
        public static void EndTransformFeedbackEXT()
        {
            if (glEndTransformFeedbackEXT != null)
            {
                glEndTransformFeedbackEXT();
            }
        }

        // GLAPI void APIENTRY glBindBufferRangeEXT (GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
        public static void BindBufferRangeEXT(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
        {
            if (glBindBufferRangeEXT != null)
            {
                glBindBufferRangeEXT(target, index, buffer, offset, size);
            }
        }

        // GLAPI void APIENTRY glBindBufferOffsetEXT (GLenum target, GLuint index, GLuint buffer, GLintptr offset);
        public static void BindBufferOffsetEXT(GLenum target, GLuint index, GLuint buffer, GLintptr offset)
        {
            if (glBindBufferOffsetEXT != null)
            {
                glBindBufferOffsetEXT(target, index, buffer, offset);
            }
        }

        // GLAPI void APIENTRY glBindBufferBaseEXT (GLenum target, GLuint index, GLuint buffer);
        public static void BindBufferBaseEXT(GLenum target, GLuint index, GLuint buffer)
        {
            if (glBindBufferBaseEXT != null)
            {
                glBindBufferBaseEXT(target, index, buffer);
            }
        }

        // GLAPI void APIENTRY glTransformFeedbackVaryingsEXT (GLuint program, GLsizei count, const GLchar* *varyings, GLenum bufferMode);
        public unsafe static void TransformFeedbackVaryingsEXT(GLuint program, GLsizei count, string[] varyings, GLenum bufferMode)
        {
            if (glTransformFeedbackVaryingsEXT != null)
            {
                IntPtr strptrtable = BuildStringIntPtrTable(varyings);

                glTransformFeedbackVaryingsEXT(program, count, (GLchar**)strptrtable, bufferMode);

                Marshal.FreeHGlobal(strptrtable);
            }
        }

        // GLAPI void APIENTRY glGetTransformFeedbackVaryingEXT (GLuint program, GLuint index, GLsizei bufSize, GLsizei *length, GLsizei *size, GLenum *type, GLchar *name);
        public unsafe static void GetTransformFeedbackVaryingEXT(GLuint program, GLuint index, GLsizei bufSize, GLsizei[] length, GLsizei[] size, GLenum[] type, GLchar[] name)
        {
            if (glGetTransformFeedbackVaryingEXT != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLsizei* ptr_size = size)
                    {
                        fixed (GLenum* ptr_type = type)
                        {
                            fixed (GLchar* ptr_name = name)
                            {
                                glGetTransformFeedbackVaryingEXT(program, index, bufSize, ptr_length, ptr_size, ptr_type, ptr_name);
                            }
                        }
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_direct_state_access
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glClientAttribDefaultEXT (GLbitfield mask);
        public static void ClientAttribDefaultEXT(GLbitfield mask)
        {
            if (glClientAttribDefaultEXT != null)
            {
                glClientAttribDefaultEXT(mask);
            }
        }

        // GLAPI void APIENTRY glPushClientAttribDefaultEXT (GLbitfield mask);
        public static void PushClientAttribDefaultEXT(GLbitfield mask)
        {
            if (glPushClientAttribDefaultEXT != null)
            {
                glPushClientAttribDefaultEXT(mask);
            }
        }

        // GLAPI void APIENTRY glMatrixLoadfEXT (GLenum mode, const GLfloat *m);
        public unsafe static void MatrixLoadfEXT(GLenum mode, GLfloat[] m)
        {
            if (glMatrixLoadfEXT != null)
            {
                fixed (GLfloat* ptr_m = m)
                {
                    glMatrixLoadfEXT(mode, ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glMatrixLoaddEXT (GLenum mode, const GLdouble *m);
        public unsafe static void MatrixLoaddEXT(GLenum mode, GLdouble[] m)
        {
            if (glMatrixLoaddEXT != null)
            {
                fixed (GLdouble* ptr_m = m)
                {
                    glMatrixLoaddEXT(mode, ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glMatrixMultfEXT (GLenum mode, const GLfloat *m);
        public unsafe static void MatrixMultfEXT(GLenum mode, GLfloat[] m)
        {
            if (glMatrixMultfEXT != null)
            {
                fixed (GLfloat* ptr_m = m)
                {
                    glMatrixMultfEXT(mode, ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glMatrixMultdEXT (GLenum mode, const GLdouble *m);
        public unsafe static void MatrixMultdEXT(GLenum mode, GLdouble[] m)
        {
            if (glMatrixMultdEXT != null)
            {
                fixed (GLdouble* ptr_m = m)
                {
                    glMatrixMultdEXT(mode, ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glMatrixLoadIdentityEXT (GLenum mode);
        public static void MatrixLoadIdentityEXT(GLenum mode)
        {
            if (glMatrixLoadIdentityEXT != null)
            {
                glMatrixLoadIdentityEXT(mode);
            }
        }

        // GLAPI void APIENTRY glMatrixRotatefEXT (GLenum mode, GLfloat angle, GLfloat x, GLfloat y, GLfloat z);
        public static void MatrixRotatefEXT(GLenum mode, GLfloat angle, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glMatrixRotatefEXT != null)
            {
                glMatrixRotatefEXT(mode, angle, x, y, z);
            }
        }

        // GLAPI void APIENTRY glMatrixRotatedEXT (GLenum mode, GLdouble angle, GLdouble x, GLdouble y, GLdouble z);
        public static void MatrixRotatedEXT(GLenum mode, GLdouble angle, GLdouble x, GLdouble y, GLdouble z)
        {
            if (glMatrixRotatedEXT != null)
            {
                glMatrixRotatedEXT(mode, angle, x, y, z);
            }
        }

        // GLAPI void APIENTRY glMatrixScalefEXT (GLenum mode, GLfloat x, GLfloat y, GLfloat z);
        public static void MatrixScalefEXT(GLenum mode, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glMatrixScalefEXT != null)
            {
                glMatrixScalefEXT(mode, x, y, z);
            }
        }

        // GLAPI void APIENTRY glMatrixScaledEXT (GLenum mode, GLdouble x, GLdouble y, GLdouble z);
        public static void MatrixScaledEXT(GLenum mode, GLdouble x, GLdouble y, GLdouble z)
        {
            if (glMatrixScaledEXT != null)
            {
                glMatrixScaledEXT(mode, x, y, z);
            }
        }

        // GLAPI void APIENTRY glMatrixTranslatefEXT (GLenum mode, GLfloat x, GLfloat y, GLfloat z);
        public static void MatrixTranslatefEXT(GLenum mode, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glMatrixTranslatefEXT != null)
            {
                glMatrixTranslatefEXT(mode, x, y, z);
            }
        }

        // GLAPI void APIENTRY glMatrixTranslatedEXT (GLenum mode, GLdouble x, GLdouble y, GLdouble z);
        public static void MatrixTranslatedEXT(GLenum mode, GLdouble x, GLdouble y, GLdouble z)
        {
            if (glMatrixTranslatedEXT != null)
            {
                glMatrixTranslatedEXT(mode, x, y, z);
            }
        }

        // GLAPI void APIENTRY glMatrixFrustumEXT (GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
        public static void MatrixFrustumEXT(GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)
        {
            if (glMatrixFrustumEXT != null)
            {
                glMatrixFrustumEXT(mode, left, right, bottom, top, zNear, zFar);
            }
        }

        // GLAPI void APIENTRY glMatrixOrthoEXT (GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
        public static void MatrixOrthoEXT(GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)
        {
            if (glMatrixOrthoEXT != null)
            {
                glMatrixOrthoEXT(mode, left, right, bottom, top, zNear, zFar);
            }
        }

        // GLAPI void APIENTRY glMatrixPopEXT (GLenum mode);
        public static void MatrixPopEXT(GLenum mode)
        {
            if (glMatrixPopEXT != null)
            {
                glMatrixPopEXT(mode);
            }
        }

        // GLAPI void APIENTRY glMatrixPushEXT (GLenum mode);
        public static void MatrixPushEXT(GLenum mode)
        {
            if (glMatrixPushEXT != null)
            {
                glMatrixPushEXT(mode);
            }
        }

        // GLAPI void APIENTRY glMatrixLoadTransposefEXT (GLenum mode, const GLfloat *m);
        public unsafe static void MatrixLoadTransposefEXT(GLenum mode, GLfloat[] m)
        {
            if (glMatrixLoadTransposefEXT != null)
            {
                fixed (GLfloat* ptr_m = m)
                {
                    glMatrixLoadTransposefEXT(mode, ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glMatrixLoadTransposedEXT (GLenum mode, const GLdouble *m);
        public unsafe static void MatrixLoadTransposedEXT(GLenum mode, GLdouble[] m)
        {
            if (glMatrixLoadTransposedEXT != null)
            {
                fixed (GLdouble* ptr_m = m)
                {
                    glMatrixLoadTransposedEXT(mode, ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glMatrixMultTransposefEXT (GLenum mode, const GLfloat *m);
        public unsafe static void MatrixMultTransposefEXT(GLenum mode, GLfloat[] m)
        {
            if (glMatrixMultTransposefEXT != null)
            {
                fixed (GLfloat* ptr_m = m)
                {
                    glMatrixMultTransposefEXT(mode, ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glMatrixMultTransposedEXT (GLenum mode, const GLdouble *m);
        public unsafe static void MatrixMultTransposedEXT(GLenum mode, GLdouble[] m)
        {
            if (glMatrixMultTransposedEXT != null)
            {
                fixed (GLdouble* ptr_m = m)
                {
                    glMatrixMultTransposedEXT(mode, ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glTextureParameterfEXT (GLuint texture, GLenum target, GLenum pname, GLfloat param);
        public static void TextureParameterfEXT(GLuint texture, GLenum target, GLenum pname, GLfloat param)
        {
            if (glTextureParameterfEXT != null)
            {
                glTextureParameterfEXT(texture, target, pname, param);
            }
        }

        // GLAPI void APIENTRY glTextureParameterfvEXT (GLuint texture, GLenum target, GLenum pname, const GLfloat *params);
        public unsafe static void TextureParameterfvEXT(GLuint texture, GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glTextureParameterfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glTextureParameterfvEXT(texture, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glTextureParameteriEXT (GLuint texture, GLenum target, GLenum pname, GLint param);
        public static void TextureParameteriEXT(GLuint texture, GLenum target, GLenum pname, GLint param)
        {
            if (glTextureParameteriEXT != null)
            {
                glTextureParameteriEXT(texture, target, pname, param);
            }
        }

        // GLAPI void APIENTRY glTextureParameterivEXT (GLuint texture, GLenum target, GLenum pname, const GLint *params);
        public unsafe static void TextureParameterivEXT(GLuint texture, GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glTextureParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glTextureParameterivEXT(texture, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glTextureImage1DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void TextureImage1DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTextureImage1DEXT != null)
            {
                glTextureImage1DEXT(texture, target, level, internalformat, width, border, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glTextureImage2DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void TextureImage2DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTextureImage2DEXT != null)
            {
                glTextureImage2DEXT(texture, target, level, internalformat, width, height, border, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glTextureSubImage1DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void TextureSubImage1DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTextureSubImage1DEXT != null)
            {
                glTextureSubImage1DEXT(texture, target, level, xoffset, width, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glTextureSubImage2DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void TextureSubImage2DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTextureSubImage2DEXT != null)
            {
                glTextureSubImage2DEXT(texture, target, level, xoffset, yoffset, width, height, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCopyTextureImage1DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);
        public static void CopyTextureImage1DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border)
        {
            if (glCopyTextureImage1DEXT != null)
            {
                glCopyTextureImage1DEXT(texture, target, level, internalformat, x, y, width, border);
            }
        }

        // GLAPI void APIENTRY glCopyTextureImage2DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        public static void CopyTextureImage2DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
        {
            if (glCopyTextureImage2DEXT != null)
            {
                glCopyTextureImage2DEXT(texture, target, level, internalformat, x, y, width, height, border);
            }
        }

        // GLAPI void APIENTRY glCopyTextureSubImage1DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        public static void CopyTextureSubImage1DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
        {
            if (glCopyTextureSubImage1DEXT != null)
            {
                glCopyTextureSubImage1DEXT(texture, target, level, xoffset, x, y, width);
            }
        }

        // GLAPI void APIENTRY glCopyTextureSubImage2DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        public static void CopyTextureSubImage2DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glCopyTextureSubImage2DEXT != null)
            {
                glCopyTextureSubImage2DEXT(texture, target, level, xoffset, yoffset, x, y, width, height);
            }
        }

        // GLAPI void APIENTRY glGetTextureImageEXT (GLuint texture, GLenum target, GLint level, GLenum format, GLenum type, GLvoid *pixels);
        public unsafe static void GetTextureImageEXT(GLuint texture, GLenum target, GLint level, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glGetTextureImageEXT != null)
            {
                glGetTextureImageEXT(texture, target, level, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetTextureParameterfvEXT (GLuint texture, GLenum target, GLenum pname, GLfloat *params);
        public unsafe static void GetTextureParameterfvEXT(GLuint texture, GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetTextureParameterfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetTextureParameterfvEXT(texture, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTextureParameterivEXT (GLuint texture, GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetTextureParameterivEXT(GLuint texture, GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetTextureParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetTextureParameterivEXT(texture, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTextureLevelParameterfvEXT (GLuint texture, GLenum target, GLint level, GLenum pname, GLfloat *params);
        public unsafe static void GetTextureLevelParameterfvEXT(GLuint texture, GLenum target, GLint level, GLenum pname, GLfloat[] parameters)
        {
            if (glGetTextureLevelParameterfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetTextureLevelParameterfvEXT(texture, target, level, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTextureLevelParameterivEXT (GLuint texture, GLenum target, GLint level, GLenum pname, GLint *params);
        public unsafe static void GetTextureLevelParameterivEXT(GLuint texture, GLenum target, GLint level, GLenum pname, GLint[] parameters)
        {
            if (glGetTextureLevelParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetTextureLevelParameterivEXT(texture, target, level, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glTextureImage3DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void TextureImage3DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTextureImage3DEXT != null)
            {
                glTextureImage3DEXT(texture, target, level, internalformat, width, height, depth, border, format, type, pixels.ToPointer());
            }
        }
        
        // GLAPI void APIENTRY glTextureSubImage3DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void TextureSubImage3DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTextureSubImage3DEXT != null)
            {
                glTextureSubImage3DEXT(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCopyTextureSubImage3DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        public static void CopyTextureSubImage3DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glCopyTextureSubImage3DEXT != null)
            {
                glCopyTextureSubImage3DEXT(texture, target, level, xoffset, yoffset, zoffset, x, y, width, height);
            }
        }

        // GLAPI void APIENTRY glMultiTexParameterfEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat param);
        public static void MultiTexParameterfEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat param)
        {
            if (glMultiTexParameterfEXT != null)
            {
                glMultiTexParameterfEXT(texunit, target, pname, param);
            }
        }

        // GLAPI void APIENTRY glMultiTexParameterfvEXT (GLenum texunit, GLenum target, GLenum pname, const GLfloat *params);
        public unsafe static void MultiTexParameterfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glMultiTexParameterfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glMultiTexParameterfvEXT(texunit, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexParameteriEXT (GLenum texunit, GLenum target, GLenum pname, GLint param);
        public static void MultiTexParameteriEXT(GLenum texunit, GLenum target, GLenum pname, GLint param)
        {
            if (glMultiTexParameteriEXT != null)
            {
                glMultiTexParameteriEXT(texunit, target, pname, param);
            }
        }

        // GLAPI void APIENTRY glMultiTexParameterivEXT (GLenum texunit, GLenum target, GLenum pname, const GLint *params);
        public unsafe static void MultiTexParameterivEXT(GLenum texunit, GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glMultiTexParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glMultiTexParameterivEXT(texunit, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexImage1DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void MultiTexImage1DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glMultiTexImage1DEXT != null)
            {
                glMultiTexImage1DEXT(texunit, target, level, internalformat, width, border, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glMultiTexImage2DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void MultiTexImage2DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glMultiTexImage2DEXT != null)
            {
                glMultiTexImage2DEXT(texunit, target, level, internalformat, width, height, border, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glMultiTexSubImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void MultiTexSubImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glMultiTexSubImage1DEXT != null)
            {
                glMultiTexSubImage1DEXT(texunit, target, level, xoffset, width, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glMultiTexSubImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void MultiTexSubImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glMultiTexSubImage2DEXT != null)
            {
                glMultiTexSubImage2DEXT(texunit, target, level, xoffset, yoffset, width, height, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCopyMultiTexImage1DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);
        public static void CopyMultiTexImage1DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border)
        {
            if (glCopyMultiTexImage1DEXT != null)
            {
                glCopyMultiTexImage1DEXT(texunit, target, level, internalformat, x, y, width, border);
            }
        }

        // GLAPI void APIENTRY glCopyMultiTexImage2DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        public static void CopyMultiTexImage2DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
        {
            if (glCopyMultiTexImage2DEXT != null)
            {
                glCopyMultiTexImage2DEXT(texunit, target, level, internalformat, x, y, width, height, border);
            }
        }

        // GLAPI void APIENTRY glCopyMultiTexSubImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        public static void CopyMultiTexSubImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
        {
            if (glCopyMultiTexSubImage1DEXT != null)
            {
                glCopyMultiTexSubImage1DEXT(texunit, target, level, xoffset, x, y, width);
            }
        }

        // GLAPI void APIENTRY glCopyMultiTexSubImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        public static void CopyMultiTexSubImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glCopyMultiTexSubImage2DEXT != null)
            {
                glCopyMultiTexSubImage2DEXT(texunit, target, level, xoffset, yoffset, x, y, width, height);
            }
        }

        // GLAPI void APIENTRY glGetMultiTexImageEXT (GLenum texunit, GLenum target, GLint level, GLenum format, GLenum type, GLvoid *pixels);
        public unsafe static void GetMultiTexImageEXT(GLenum texunit, GLenum target, GLint level, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glGetMultiTexImageEXT != null)
            {
                glGetMultiTexImageEXT(texunit, target, level, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetMultiTexParameterfvEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat *params);
        public unsafe static void GetMultiTexParameterfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetMultiTexParameterfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetMultiTexParameterfvEXT(texunit, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMultiTexParameterivEXT (GLenum texunit, GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetMultiTexParameterivEXT(GLenum texunit, GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetMultiTexParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetMultiTexParameterivEXT(texunit, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMultiTexLevelParameterfvEXT (GLenum texunit, GLenum target, GLint level, GLenum pname, GLfloat *params);
        public unsafe static void GetMultiTexLevelParameterfvEXT(GLenum texunit, GLenum target, GLint level, GLenum pname, GLfloat[] parameters)
        {
            if (glGetMultiTexLevelParameterfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetMultiTexLevelParameterfvEXT(texunit, target, level, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMultiTexLevelParameterivEXT (GLenum texunit, GLenum target, GLint level, GLenum pname, GLint *params);
        public unsafe static void GetMultiTexLevelParameterivEXT(GLenum texunit, GLenum target, GLint level, GLenum pname, GLint[] parameters)
        {
            if (glGetMultiTexLevelParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetMultiTexLevelParameterivEXT(texunit, target, level, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexImage3DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void MultiTexImage3DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glMultiTexImage3DEXT != null)
            {
                glMultiTexImage3DEXT(texunit, target, level, internalformat, width, height, depth, border, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glMultiTexSubImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void MultiTexSubImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glMultiTexSubImage3DEXT != null)
            {
                glMultiTexSubImage3DEXT(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCopyMultiTexSubImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        public static void CopyMultiTexSubImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glCopyMultiTexSubImage3DEXT != null)
            {
                glCopyMultiTexSubImage3DEXT(texunit, target, level, xoffset, yoffset, zoffset, x, y, width, height);
            }
        }

        // GLAPI void APIENTRY glBindMultiTextureEXT (GLenum texunit, GLenum target, GLuint texture);
        public static void BindMultiTextureEXT(GLenum texunit, GLenum target, GLuint texture)
        {
            if (glBindMultiTextureEXT != null)
            {
                glBindMultiTextureEXT(texunit, target, texture);
            }
        }

        // GLAPI void APIENTRY glEnableClientStateIndexedEXT (GLenum array, GLuint index);
        public static void EnableClientStateIndexedEXT(GLenum array, GLuint index)
        {
            if (glEnableClientStateIndexedEXT != null)
            {
                glEnableClientStateIndexedEXT(array, index);
            }
        }

        // GLAPI void APIENTRY glDisableClientStateIndexedEXT (GLenum array, GLuint index);
        public static void DisableClientStateIndexedEXT(GLenum array, GLuint index)
        {
            if (glDisableClientStateIndexedEXT != null)
            {
                glDisableClientStateIndexedEXT(array, index);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoordPointerEXT (GLenum texunit, GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        public unsafe static void MultiTexCoordPointerEXT(GLenum texunit, GLint size, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glMultiTexCoordPointerEXT != null)
            {
                glMultiTexCoordPointerEXT(texunit, size, type, stride, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glMultiTexEnvfEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat param);
        public static void MultiTexEnvfEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat param)
        {
            if (glMultiTexEnvfEXT != null)
            {
                glMultiTexEnvfEXT(texunit, target, pname, param);
            }
        }

        // GLAPI void APIENTRY glMultiTexEnvfvEXT (GLenum texunit, GLenum target, GLenum pname, const GLfloat *params);
        public unsafe static void MultiTexEnvfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glMultiTexEnvfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glMultiTexEnvfvEXT(texunit, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexEnviEXT (GLenum texunit, GLenum target, GLenum pname, GLint param);
        public static void MultiTexEnviEXT(GLenum texunit, GLenum target, GLenum pname, GLint param)
        {
            if (glMultiTexEnviEXT != null)
            {
                glMultiTexEnviEXT(texunit, target, pname, param);
            }
        }

        // GLAPI void APIENTRY glMultiTexEnvivEXT (GLenum texunit, GLenum target, GLenum pname, const GLint *params);
        public unsafe static void MultiTexEnvivEXT(GLenum texunit, GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glMultiTexEnvivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glMultiTexEnvivEXT(texunit, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexGendEXT (GLenum texunit, GLenum coord, GLenum pname, GLdouble param);
        public static void MultiTexGendEXT(GLenum texunit, GLenum coord, GLenum pname, GLdouble param)
        {
            if (glMultiTexGendEXT != null)
            {
                glMultiTexGendEXT(texunit, coord, pname, param);
            }
        }

        // GLAPI void APIENTRY glMultiTexGendvEXT (GLenum texunit, GLenum coord, GLenum pname, const GLdouble *params);
        public unsafe static void MultiTexGendvEXT(GLenum texunit, GLenum coord, GLenum pname, GLdouble[] parameters)
        {
            if (glMultiTexGendvEXT != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glMultiTexGendvEXT(texunit, coord, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexGenfEXT (GLenum texunit, GLenum coord, GLenum pname, GLfloat param);
        public static void MultiTexGenfEXT (GLenum texunit, GLenum coord, GLenum pname, GLfloat param)
        {
            if (glMultiTexGenfEXT != null)
            {
                glMultiTexGenfEXT(texunit, coord, pname, param);
            }
        }

        // GLAPI void APIENTRY glMultiTexGenfvEXT (GLenum texunit, GLenum coord, GLenum pname, const GLfloat *params);
        public unsafe static void MultiTexGenfvEXT(GLenum texunit, GLenum coord, GLenum pname, GLfloat[] parameters)
        {
            if (glMultiTexGenfvEXT != null)
            {
                fixed(GLfloat* ptr_parameters = parameters)
                {
                    glMultiTexGenfvEXT(texunit, coord, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexGeniEXT (GLenum texunit, GLenum coord, GLenum pname, GLint param);
        public static void MultiTexGeniEXT(GLenum texunit, GLenum coord, GLenum pname, GLint param)
        {
            if (glMultiTexGeniEXT != null)
            {
                glMultiTexGeniEXT(texunit, coord, pname, param);
            }
        }

        // GLAPI void APIENTRY glMultiTexGenivEXT (GLenum texunit, GLenum coord, GLenum pname, const GLint *params);
        public unsafe static void MultiTexGenivEXT(GLenum texunit, GLenum coord, GLenum pname, GLint[] parameters)
        {
            if (glMultiTexGenivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glMultiTexGenivEXT(texunit, coord, pname, ptr_parameters);
                }
            }
        }
        // GLAPI void APIENTRY glGetMultiTexEnvfvEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat *params);
        public unsafe static void GetMultiTexEnvfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetMultiTexEnvfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetMultiTexEnvfvEXT (texunit, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMultiTexEnvivEXT (GLenum texunit, GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetMultiTexEnvivEXT(GLenum texunit, GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetMultiTexEnvivEXT != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glGetMultiTexEnvivEXT(texunit, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMultiTexGendvEXT (GLenum texunit, GLenum coord, GLenum pname, GLdouble *params);
        public unsafe static void GetMultiTexGendvEXT(GLenum texunit, GLenum coord, GLenum pname, GLdouble[] parameters)
        {
            if (glGetMultiTexGendvEXT != null)
            {
                fixed(GLdouble* ptr_parameters = parameters)
                {
                    glGetMultiTexGendvEXT(texunit, coord, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMultiTexGenfvEXT (GLenum texunit, GLenum coord, GLenum pname, GLfloat *params);
        public unsafe static void GetMultiTexGenfvEXT(GLenum texunit, GLenum coord, GLenum pname, GLfloat[] parameters)
        {
            if (glGetMultiTexGenfvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetMultiTexGenfvEXT(texunit, coord, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMultiTexGenivEXT (GLenum texunit, GLenum coord, GLenum pname, GLint *params);
        public unsafe static void GetMultiTexGenivEXT(GLenum texunit, GLenum coord, GLenum pname, GLint[] parameters)
        {
            if (glGetMultiTexGenivEXT != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glGetMultiTexGenivEXT(texunit, coord, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetFloatIndexedvEXT (GLenum target, GLuint index, GLfloat *data);
        public unsafe static void GetFloatIndexedvEXT(GLenum target, GLuint index, GLfloat[] data)
        {
            if (glGetFloatIndexedvEXT != null)
            {
                fixed (GLfloat* ptr_data = data)
                {
                    glGetFloatIndexedvEXT(target, index, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetDoubleIndexedvEXT (GLenum target, GLuint index, GLdouble *data);
        public unsafe static void GetDoubleIndexedvEXT(GLenum target, GLuint index, GLdouble[] data)
        {
            if (glGetDoubleIndexedvEXT != null)
            {
                fixed (GLdouble* ptr_data = data)
                {
                    glGetDoubleIndexedvEXT(target, index, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetPointerIndexedvEXT (GLenum target, GLuint index, GLvoid* *data);
        public unsafe static void GetPointerIndexedvEXT(GLenum target, GLuint index, IntPtr[] data)
        {
            if (glGetPointerIndexedvEXT != null)
            {
                fixed(IntPtr* ptr_data = data)
                {
                    glGetPointerIndexedvEXT(target, index, (void**)ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glCompressedTextureImage3DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, const GLvoid *bits);
        public unsafe static void CompressedTextureImage3DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, IntPtr bits)
        {
            if (glCompressedTextureImage3DEXT != null)
            {
                glCompressedTextureImage3DEXT(texture, target, level, internalformat, width, height, depth, border, imageSize, bits.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedTextureImage2DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, const GLvoid *bits);
        public unsafe static void CompressedTextureImage2DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, IntPtr bits)
        {
            if (glCompressedTextureImage2DEXT != null)
            {
                glCompressedTextureImage2DEXT(texture, target, level, internalformat, width, height, border, imageSize, bits.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedTextureImage1DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, const GLvoid *bits);
        public unsafe static void CompressedTextureImage1DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, IntPtr bits)
        {
            if (glCompressedTextureImage1DEXT != null)
            {
                glCompressedTextureImage1DEXT(texture, target, level, internalformat, width, border, imageSize, bits.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedTextureSubImage3DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const GLvoid *bits);
        public unsafe static void CompressedTextureSubImage3DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, IntPtr bits)
        {
            if (glCompressedTextureSubImage3DEXT != null)
            {
                glCompressedTextureSubImage3DEXT(texture, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedTextureSubImage2DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const GLvoid *bits);
        public unsafe static void CompressedTextureSubImage2DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, IntPtr bits)
        {
            if (glCompressedTextureSubImage2DEXT != null)
            {
                glCompressedTextureSubImage2DEXT(texture, target, level, xoffset, yoffset, width, height, format, imageSize, bits.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedTextureSubImage1DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, const GLvoid *bits);
        public unsafe static void CompressedTextureSubImage1DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, IntPtr bits)
        {
            if (glCompressedTextureSubImage1DEXT != null)
            {
                glCompressedTextureSubImage1DEXT(texture, target, level, xoffset, width, format, imageSize, bits.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetCompressedTextureImageEXT (GLuint texture, GLenum target, GLint lod, GLvoid *img);
        public unsafe static void GetCompressedTextureImageEXT(GLuint texture, GLenum target, GLint lod, IntPtr img)
        {
            if (glGetCompressedTextureImageEXT != null)
            {
                glGetCompressedTextureImageEXT(texture, target, lod, img.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedMultiTexImage3DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, const GLvoid *bits);
        public unsafe static void CompressedMultiTexImage3DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, IntPtr bits)
        {
            if (glCompressedMultiTexImage3DEXT != null)
            {
                glCompressedMultiTexImage3DEXT(texunit, target, level, internalformat, width, height, depth, border, imageSize, bits.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedMultiTexImage2DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, const GLvoid *bits);
        public unsafe static void CompressedMultiTexImage2DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, IntPtr bits)
        {
            if (glCompressedMultiTexImage2DEXT != null)
            {
                glCompressedMultiTexImage2DEXT(texunit, target, level, internalformat, width, height, border, imageSize, bits.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedMultiTexImage1DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, const GLvoid *bits);
        public unsafe static void CompressedMultiTexImage1DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, IntPtr bits)
        {
            if (glCompressedMultiTexImage1DEXT != null)
            {
                glCompressedMultiTexImage1DEXT(texunit, target, level, internalformat, width, border, imageSize, bits.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedMultiTexSubImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const GLvoid *bits);
        public unsafe static void CompressedMultiTexSubImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, IntPtr bits)
        {
            if (glCompressedMultiTexSubImage3DEXT != null)
            {
                glCompressedMultiTexSubImage3DEXT(texunit, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, bits.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedMultiTexSubImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const GLvoid *bits);
        public unsafe static void CompressedMultiTexSubImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, IntPtr bits)
        {
            if (glCompressedMultiTexSubImage2DEXT != null)
            {
                glCompressedMultiTexSubImage2DEXT(texunit, target, level, xoffset, yoffset, width, height, format, imageSize, bits.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedMultiTexSubImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, const GLvoid *bits);
        public unsafe static void CompressedMultiTexSubImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, IntPtr bits)
        {
            if (glCompressedMultiTexSubImage1DEXT != null)
            {
                glCompressedMultiTexSubImage1DEXT(texunit, target, level, xoffset, width, format, imageSize, bits.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetCompressedMultiTexImageEXT (GLenum texunit, GLenum target, GLint lod, GLvoid *img);
        public unsafe static void GetCompressedMultiTexImageEXT(GLenum texunit, GLenum target, GLint lod, IntPtr img)
        {
            if (glGetCompressedMultiTexImageEXT != null)
            {
                glGetCompressedMultiTexImageEXT(texunit, target, lod, img.ToPointer());
            }
        }

        // GLAPI void APIENTRY glNamedProgramStringEXT (GLuint program, GLenum target, GLenum format, GLsizei len, const GLvoid *string);
        public unsafe static void NamedProgramStringEXT(GLuint program, GLenum target, GLenum format, GLsizei len, IntPtr str)
        {
            if (glNamedProgramStringEXT != null)
            {
                glNamedProgramStringEXT(program, target, format, len, str.ToPointer());
            }
        }

        // GLAPI void APIENTRY glNamedProgramLocalParameter4dEXT (GLuint program, GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        public static void NamedProgramLocalParameter4dEXT(GLuint program, GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glNamedProgramLocalParameter4dEXT != null)
            {
                glNamedProgramLocalParameter4dEXT(program, target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glNamedProgramLocalParameter4dvEXT (GLuint program, GLenum target, GLuint index, const GLdouble *params);
        public unsafe static void NamedProgramLocalParameter4dvEXT(GLuint program, GLenum target, GLuint index, GLdouble[] parameters)
        {
            if (glNamedProgramLocalParameter4dvEXT != null)
            {
                fixed(GLdouble* ptr_parameters = parameters)
                {
                    glNamedProgramLocalParameter4dvEXT(program, target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glNamedProgramLocalParameter4fEXT (GLuint program, GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        public static void NamedProgramLocalParameter4fEXT(GLuint program, GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glNamedProgramLocalParameter4fEXT != null)
            {
                glNamedProgramLocalParameter4fEXT(program, target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glNamedProgramLocalParameter4fvEXT (GLuint program, GLenum target, GLuint index, const GLfloat *params);
        public unsafe static void NamedProgramLocalParameter4fvEXT(GLuint program, GLenum target, GLuint index, GLfloat[] parameters)
        {
            if (glNamedProgramLocalParameter4fvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glNamedProgramLocalParameter4fvEXT(program, target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetNamedProgramLocalParameterdvEXT (GLuint program, GLenum target, GLuint index, GLdouble *params);
        public unsafe static void GetNamedProgramLocalParameterdvEXT(GLuint program, GLenum target, GLuint index, GLdouble[] parameters)
        {
            if (glGetNamedProgramLocalParameterdvEXT != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetNamedProgramLocalParameterdvEXT(program, target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetNamedProgramLocalParameterfvEXT (GLuint program, GLenum target, GLuint index, GLfloat *params);
        public unsafe static void GetNamedProgramLocalParameterfvEXT(GLuint program, GLenum target, GLuint index, GLfloat[] parameters)
        {
            if (glGetNamedProgramLocalParameterfvEXT != null)
            {
                fixed(GLfloat* ptr_parameters = parameters)
                {
                    glGetNamedProgramLocalParameterfvEXT(program, target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetNamedProgramivEXT (GLuint program, GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetNamedProgramivEXT(GLuint program, GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetNamedProgramivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetNamedProgramivEXT(program, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetNamedProgramStringEXT (GLuint program, GLenum target, GLenum pname, GLvoid *string);
        public unsafe static void GetNamedProgramStringEXT(GLuint program, GLenum target, GLenum pname, IntPtr str)
        {
            if (glGetNamedProgramStringEXT != null)
            {
                glGetNamedProgramStringEXT(program, target, pname, str.ToPointer());
            }
        }

        // GLAPI void APIENTRY glNamedProgramLocalParameters4fvEXT (GLuint program, GLenum target, GLuint index, GLsizei count, const GLfloat *params);
        public unsafe static void NamedProgramLocalParameters4fvEXT(GLuint program, GLenum target, GLuint index, GLsizei count, GLfloat[] parameters)
        {
            if (glNamedProgramLocalParameters4fvEXT != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glNamedProgramLocalParameters4fvEXT(program, target, index, count, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glNamedProgramLocalParameterI4iEXT (GLuint program, GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);
        public static void NamedProgramLocalParameterI4iEXT(GLuint program, GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w)
        {
            if (glNamedProgramLocalParameterI4iEXT != null)
            {
                glNamedProgramLocalParameterI4iEXT(program, target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glNamedProgramLocalParameterI4ivEXT (GLuint program, GLenum target, GLuint index, const GLint *params);
        public unsafe static void NamedProgramLocalParameterI4ivEXT(GLuint program, GLenum target, GLuint index, GLint[] parameters)
        {
            if (glNamedProgramLocalParameterI4ivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glNamedProgramLocalParameterI4ivEXT(program, target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glNamedProgramLocalParametersI4ivEXT (GLuint program, GLenum target, GLuint index, GLsizei count, const GLint *params);
        public unsafe static void NamedProgramLocalParametersI4ivEXT(GLuint program, GLenum target, GLuint index, GLsizei count, GLint[] parameters)
        {
            if (glNamedProgramLocalParametersI4ivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glNamedProgramLocalParametersI4ivEXT(program, target, index, count, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glNamedProgramLocalParameterI4uiEXT (GLuint program, GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        public static void NamedProgramLocalParameterI4uiEXT(GLuint program, GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
        {
            if (glNamedProgramLocalParameterI4uiEXT != null)
            {
                glNamedProgramLocalParameterI4uiEXT(program, target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glNamedProgramLocalParameterI4uivEXT (GLuint program, GLenum target, GLuint index, const GLuint *params);
        public unsafe static void NamedProgramLocalParameterI4uivEXT(GLuint program, GLenum target, GLuint index, GLuint[] parameters)
        {
            if (glNamedProgramLocalParameterI4uivEXT != null)
            {
                fixed(GLuint* ptr_parameters = parameters)
                {
                    glNamedProgramLocalParameterI4uivEXT(program, target, index, ptr_parameters);
                }
            }
        }
        
        // GLAPI void APIENTRY glNamedProgramLocalParametersI4uivEXT (GLuint program, GLenum target, GLuint index, GLsizei count, const GLuint *params);
        public unsafe static void NamedProgramLocalParametersI4uivEXT(GLuint program, GLenum target, GLuint index, GLsizei count, GLuint[] parameters)
        {
            if (glNamedProgramLocalParametersI4uivEXT != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glNamedProgramLocalParametersI4uivEXT(program, target, index, count, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetNamedProgramLocalParameterIivEXT (GLuint program, GLenum target, GLuint index, GLint *params);
        public unsafe static void GetNamedProgramLocalParameterIivEXT(GLuint program, GLenum target, GLuint index, GLint[] parameters)
        {
            if (glGetNamedProgramLocalParameterIivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetNamedProgramLocalParameterIivEXT(program, target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetNamedProgramLocalParameterIuivEXT (GLuint program, GLenum target, GLuint index, GLuint *params);
        public unsafe static void GetNamedProgramLocalParameterIuivEXT(GLuint program, GLenum target, GLuint index, GLuint[] parameters)
        {
            if (glGetNamedProgramLocalParameterIuivEXT != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetNamedProgramLocalParameterIuivEXT(program, target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glTextureParameterIivEXT (GLuint texture, GLenum target, GLenum pname, const GLint *params);
        public unsafe static void TextureParameterIivEXT(GLuint texture, GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glTextureParameterIivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glTextureParameterIivEXT(texture, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glTextureParameterIuivEXT (GLuint texture, GLenum target, GLenum pname, const GLuint *params);
        public unsafe static void TextureParameterIuivEXT(GLuint texture, GLenum target, GLenum pname, GLuint[] parameters)
        {
            if (glTextureParameterIuivEXT != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glTextureParameterIuivEXT(texture, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTextureParameterIivEXT (GLuint texture, GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetTextureParameterIivEXT(GLuint texture, GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetTextureParameterIivEXT != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glGetTextureParameterIivEXT(texture, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTextureParameterIuivEXT (GLuint texture, GLenum target, GLenum pname, GLuint *params);
        public unsafe static void GetTextureParameterIuivEXT(GLuint texture, GLenum target, GLenum pname, GLuint[] parameters)
        {
            if (glGetTextureParameterIuivEXT != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetTextureParameterIuivEXT(texture, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexParameterIivEXT (GLenum texunit, GLenum target, GLenum pname, const GLint *params);
        public unsafe static void MultiTexParameterIivEXT(GLenum texunit, GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glMultiTexParameterIivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glMultiTexParameterIivEXT(texunit, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexParameterIuivEXT (GLenum texunit, GLenum target, GLenum pname, const GLuint *params);
        public unsafe static void MultiTexParameterIuivEXT(GLenum texunit, GLenum target, GLenum pname, GLuint[] parameters)
        {
            if (glMultiTexParameterIuivEXT != null)
            {
                fixed(GLuint* ptr_parameters = parameters)
                {
                    glMultiTexParameterIuivEXT(texunit, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMultiTexParameterIivEXT (GLenum texunit, GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetMultiTexParameterIivEXT(GLenum texunit, GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetMultiTexParameterIivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetMultiTexParameterIivEXT(texunit, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMultiTexParameterIuivEXT (GLenum texunit, GLenum target, GLenum pname, GLuint *params);
        public unsafe static void GetMultiTexParameterIuivEXT(GLenum texunit, GLenum target, GLenum pname, GLuint[] parameters)
        {
            if (glGetMultiTexParameterIuivEXT != null)
            {
                fixed(GLuint* ptr_parameters = parameters)
                {
                    glGetMultiTexParameterIuivEXT(texunit, target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform1fEXT (GLuint program, GLint location, GLfloat v0);
        public static void ProgramUniform1fEXT(GLuint program, GLint location, GLfloat v0)
        {
            if (glProgramUniform1fEXT != null)
            {
                glProgramUniform1fEXT(program, location, v0);
            }
        }

        // GLAPI void APIENTRY glProgramUniform2fEXT (GLuint program, GLint location, GLfloat v0, GLfloat v1);
        public static void ProgramUniform2fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1)
        {
            if (glProgramUniform2fEXT != null)
            {
                glProgramUniform2fEXT(program, location, v0, v1);
            }
        }

        // GLAPI void APIENTRY glProgramUniform3fEXT (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        public static void ProgramUniform3fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
        {
            if (glProgramUniform3fEXT != null)
            {
                glProgramUniform3fEXT(program, location, v0, v1, v2);
            }
        }

        // GLAPI void APIENTRY glProgramUniform4fEXT (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        public static void ProgramUniform4fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
        {
            if (glProgramUniform4fEXT != null)
            {
                glProgramUniform4fEXT(program, location, v0, v1, v2, v3);
            }
        }

        // GLAPI void APIENTRY glProgramUniform1iEXT (GLuint program, GLint location, GLint v0);
        public static void ProgramUniform1iEXT(GLuint program, GLint location, GLint v0)
        {
            if (glProgramUniform1iEXT != null)
            {
                glProgramUniform1iEXT(program, location, v0);
            }
        }

        // GLAPI void APIENTRY glProgramUniform2iEXT (GLuint program, GLint location, GLint v0, GLint v1);
        public static void ProgramUniform2iEXT(GLuint program, GLint location, GLint v0, GLint v1)
        {
            if (glProgramUniform2iEXT != null)
            {
                glProgramUniform2iEXT(program, location, v0, v1);
            }
        }

        // GLAPI void APIENTRY glProgramUniform3iEXT (GLuint program, GLint location, GLint v0, GLint v1, GLint v2);
        public static void ProgramUniform3iEXT(GLuint program, GLint location, GLint v0, GLint v1, GLint v2)
        {
            if (glProgramUniform3iEXT != null)
            {
                glProgramUniform3iEXT(program, location, v0, v1, v2);
            }
        }

        // GLAPI void APIENTRY glProgramUniform4iEXT (GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        public static void ProgramUniform4iEXT(GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
        {
            if (glProgramUniform4iEXT != null)
            {
                glProgramUniform4iEXT(program, location, v0, v1, v2, v3);
            }
        }

        // GLAPI void APIENTRY glProgramUniform1fvEXT (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        public unsafe static void ProgramUniform1fvEXT(GLuint program, GLint location, GLsizei count, GLfloat[] value)
        {
            if (glProgramUniform1fvEXT != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniform1fvEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform2fvEXT (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        public unsafe static void ProgramUniform2fvEXT(GLuint program, GLint location, GLsizei count, GLfloat[] value)
        {
            if (glProgramUniform2fvEXT != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniform2fvEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform3fvEXT (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        public unsafe static void ProgramUniform3fvEXT(GLuint program, GLint location, GLsizei count, GLfloat[] value)
        {
            if (glProgramUniform3fvEXT != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniform3fvEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform4fvEXT (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        public unsafe static void ProgramUniform4fvEXT(GLuint program, GLint location, GLsizei count, GLfloat[] value)
        {
            if (glProgramUniform4fvEXT != null)
            {
                fixed(GLfloat* ptr_value = value)
                {
                    glProgramUniform4fvEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform1ivEXT (GLuint program, GLint location, GLsizei count, const GLint *value);
        public unsafe static void ProgramUniform1ivEXT(GLuint program, GLint location, GLsizei count, GLint[] value)
        {
            if (glProgramUniform1ivEXT != null)
            {
                fixed(GLint* ptr_value = value)
                {
                    glProgramUniform1ivEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform2ivEXT (GLuint program, GLint location, GLsizei count, const GLint *value);
        public unsafe static void ProgramUniform2ivEXT(GLuint program, GLint location, GLsizei count, GLint[] value)
        {
            if (glProgramUniform2ivEXT != null)
            {
                fixed(GLint* ptr_value = value)
                {
                    glProgramUniform2ivEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform3ivEXT (GLuint program, GLint location, GLsizei count, const GLint *value);
        public unsafe static void ProgramUniform3ivEXT(GLuint program, GLint location, GLsizei count, GLint[] value)
        {
            if (glProgramUniform3ivEXT != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glProgramUniform3ivEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform4ivEXT (GLuint program, GLint location, GLsizei count, const GLint *value);
        public unsafe static void ProgramUniform4ivEXT(GLuint program, GLint location, GLsizei count, GLint[] value)
        {
            if (glProgramUniform4ivEXT != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glProgramUniform4ivEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix2fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        public unsafe static void ProgramUniformMatrix2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix2fvEXT != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix2fvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix3fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        public unsafe static void ProgramUniformMatrix3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix3fvEXT != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix3fvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix4fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        public unsafe static void ProgramUniformMatrix4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix4fvEXT != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix4fvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix2x3fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        public unsafe static void ProgramUniformMatrix2x3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix2x3fvEXT != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix2x3fvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix3x2fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        public unsafe static void ProgramUniformMatrix3x2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix3x2fvEXT != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix3x2fvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix2x4fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        public unsafe static void ProgramUniformMatrix2x4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix2x4fvEXT != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix2x4fvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix4x2fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        public unsafe static void ProgramUniformMatrix4x2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix4x2fvEXT != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix4x2fvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix3x4fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        public unsafe static void ProgramUniformMatrix3x4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix3x4fvEXT != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix3x4fvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix4x3fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        public unsafe static void ProgramUniformMatrix4x3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix4x3fvEXT != null)
            {
                fixed(GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix4x3fvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform1uiEXT (GLuint program, GLint location, GLuint v0);
        public static void ProgramUniform1uiEXT(GLuint program, GLint location, GLuint v0)
        {
            if (glProgramUniform1uiEXT != null)
            {
                glProgramUniform1uiEXT(program, location, v0);
            }
        }

        // GLAPI void APIENTRY glProgramUniform2uiEXT (GLuint program, GLint location, GLuint v0, GLuint v1);
        public static void ProgramUniform2uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1)
        {
            if (glProgramUniform2uiEXT != null)
            {
                glProgramUniform2uiEXT(program, location, v0, v1);
            }
        }

        // GLAPI void APIENTRY glProgramUniform3uiEXT (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2);
        public static void ProgramUniform3uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2)
        {
            if (glProgramUniform3uiEXT != null)
            {
                glProgramUniform3uiEXT(program, location, v0, v1, v2);
            }
        }

        // GLAPI void APIENTRY glProgramUniform4uiEXT (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
        public static void ProgramUniform4uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
        {
            if (glProgramUniform4uiEXT != null)
            {
                glProgramUniform4uiEXT(program, location, v0, v1, v2, v3);
            }
        }

        // GLAPI void APIENTRY glProgramUniform1uivEXT (GLuint program, GLint location, GLsizei count, const GLuint *value);
        public unsafe static void ProgramUniform1uivEXT(GLuint program, GLint location, GLsizei count, GLuint[] value)
        {
            if (glProgramUniform1uivEXT != null)
            {
                fixed(GLuint* ptr_value = value)
                {
                    glProgramUniform1uivEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform2uivEXT (GLuint program, GLint location, GLsizei count, const GLuint *value);
        public unsafe static void ProgramUniform2uivEXT(GLuint program, GLint location, GLsizei count, GLuint[] value)
        {
            if (glProgramUniform2uivEXT != null)
            {
                fixed(GLuint* ptr_value = value)
                {
                    glProgramUniform2uivEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform3uivEXT (GLuint program, GLint location, GLsizei count, const GLuint *value);
        public unsafe static void ProgramUniform3uivEXT(GLuint program, GLint location, GLsizei count, GLuint[] value)
        {
            if (glProgramUniform3uivEXT != null)
            {
                fixed(GLuint* ptr_value = value)
                {
                    glProgramUniform3uivEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform4uivEXT (GLuint program, GLint location, GLsizei count, const GLuint *value);
        public unsafe static void ProgramUniform4uivEXT(GLuint program, GLint location, GLsizei count, GLuint[] value)
        {
            if (glProgramUniform4uivEXT != null)
            {
                fixed(GLuint* ptr_value = value)
                {
                    glProgramUniform4uivEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glNamedBufferDataEXT (GLuint buffer, GLsizeiptr size, const GLvoid *data, GLenum usage);
        public unsafe static void NamedBufferDataEXT(GLuint buffer, GLsizeiptr size, IntPtr data, GLenum usage)
        {
            if (glNamedBufferDataEXT != null)
            {
                glNamedBufferDataEXT(buffer, size, data.ToPointer(), usage);
            }
        }

        // GLAPI void APIENTRY glNamedBufferSubDataEXT (GLuint buffer, GLintptr offset, GLsizeiptr size, const GLvoid *data);
        public unsafe static void NamedBufferSubDataEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, IntPtr data)
        {
            if (glNamedBufferSubDataEXT != null)
            {
                glNamedBufferSubDataEXT(buffer, offset, size, data.ToPointer());
            }
        }

        // GLAPI GLvoid* APIENTRY glMapNamedBufferEXT (GLuint buffer, GLenum access);
        public unsafe static IntPtr MapNamedBufferEXT (GLuint buffer, GLenum access)
        {
            if (glMapNamedBufferEXT != null)
            {
                return (IntPtr)glMapNamedBufferEXT(buffer, access);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // GLAPI GLboolean APIENTRY glUnmapNamedBufferEXT (GLuint buffer);
        public static GLboolean UnmapNamedBufferEXT (GLuint buffer)
        {
            if (glUnmapNamedBufferEXT != null)
            {
                return glUnmapNamedBufferEXT(buffer);
            }
            else
            {
                return false;
            }
        }

        // GLAPI GLvoid* APIENTRY glMapNamedBufferRangeEXT (GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access);
        public unsafe static IntPtr MapNamedBufferRangeEXT(GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access)
        {
            if (glMapNamedBufferRangeEXT != null)
            {
                return (IntPtr)glMapNamedBufferRangeEXT(buffer, offset, length, access);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // GLAPI void APIENTRY glFlushMappedNamedBufferRangeEXT (GLuint buffer, GLintptr offset, GLsizeiptr length);
        public static void FlushMappedNamedBufferRangeEXT(GLuint buffer, GLintptr offset, GLsizeiptr length)
        {
            if (glFlushMappedNamedBufferRangeEXT != null)
            {
                glFlushMappedNamedBufferRangeEXT(buffer, offset, length);
            }
        }

        // GLAPI void APIENTRY glNamedCopyBufferSubDataEXT (GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);
        public static void NamedCopyBufferSubDataEXT(GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size)
        {
            if (glNamedCopyBufferSubDataEXT != null)
            {
                glNamedCopyBufferSubDataEXT(readBuffer, writeBuffer, readOffset, writeOffset, size);
            }
        }

        // GLAPI void APIENTRY glGetNamedBufferParameterivEXT (GLuint buffer, GLenum pname, GLint *params);
        public unsafe static void GetNamedBufferParameterivEXT(GLuint buffer, GLenum pname, GLint[] parameters)
        {
            if (glGetNamedBufferParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetNamedBufferParameterivEXT(buffer, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetNamedBufferPointervEXT (GLuint buffer, GLenum pname, GLvoid* *params);
        public unsafe static void GetNamedBufferPointervEXT(GLuint buffer, GLenum pname, IntPtr[] parameters)
        {
            if (glGetNamedBufferPointervEXT != null)
            {
                fixed (IntPtr* ptr_parameters = parameters)
                {
                    glGetNamedBufferPointervEXT(buffer, pname, (void**)ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetNamedBufferSubDataEXT (GLuint buffer, GLintptr offset, GLsizeiptr size, GLvoid *data);
        public unsafe static void GetNamedBufferSubDataEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, IntPtr data)
        {
            if (glGetNamedBufferSubDataEXT != null)
            {
                glGetNamedBufferSubDataEXT(buffer, offset, size, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glTextureBufferEXT (GLuint texture, GLenum target, GLenum internalformat, GLuint buffer);
        public static void TextureBufferEXT(GLuint texture, GLenum target, GLenum internalformat, GLuint buffer)
        {
            if (glTextureBufferEXT != null)
            {
                glTextureBufferEXT(texture, target, internalformat, buffer);
            }
        }

        // GLAPI void APIENTRY glMultiTexBufferEXT (GLenum texunit, GLenum target, GLenum internalformat, GLuint buffer);
        public static void MultiTexBufferEXT(GLenum texunit, GLenum target, GLenum internalformat, GLuint buffer)
        {
            if (glMultiTexBufferEXT != null)
            {
                glMultiTexBufferEXT(texunit, target, internalformat, buffer);
            }
        }

        // GLAPI void APIENTRY glNamedRenderbufferStorageEXT (GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height);
        public static void NamedRenderbufferStorageEXT(GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glNamedRenderbufferStorageEXT != null)
            {
                glNamedRenderbufferStorageEXT(renderbuffer, internalformat, width, height);
            }
        }
            
        // GLAPI void APIENTRY glGetNamedRenderbufferParameterivEXT (GLuint renderbuffer, GLenum pname, GLint *params);
        public unsafe static void GetNamedRenderbufferParameterivEXT(GLuint renderbuffer, GLenum pname, GLint[] parameters)
        {
            if (glGetNamedRenderbufferParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetNamedRenderbufferParameterivEXT(renderbuffer, pname, ptr_parameters);
                }
            }
        }

        // GLAPI GLenum APIENTRY glCheckNamedFramebufferStatusEXT (GLuint framebuffer, GLenum target);
        public static GLenum CheckNamedFramebufferStatusEXT(GLuint framebuffer, GLenum target)
        {
            if (glCheckNamedFramebufferStatusEXT != null)
            {
                return glCheckNamedFramebufferStatusEXT(framebuffer, target);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferTexture1DEXT (GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        public static void NamedFramebufferTexture1DEXT(GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
        {
            if (glNamedFramebufferTexture1DEXT != null)
            {
                glNamedFramebufferTexture1DEXT(framebuffer, attachment, textarget, texture, level);
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferTexture2DEXT (GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        public static void NamedFramebufferTexture2DEXT(GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
        {
            if (glNamedFramebufferTexture2DEXT != null)
            {
                glNamedFramebufferTexture2DEXT(framebuffer, attachment, textarget, texture, level);
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferTexture3DEXT (GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);
        public static void NamedFramebufferTexture3DEXT(GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset)
        {
            if (glNamedFramebufferTexture3DEXT != null)
            {
                glNamedFramebufferTexture3DEXT(framebuffer, attachment, textarget, texture, level, zoffset);
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferRenderbufferEXT (GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
        public static void NamedFramebufferRenderbufferEXT(GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)
        {
            if (glNamedFramebufferRenderbufferEXT != null)
            {
                glNamedFramebufferRenderbufferEXT(framebuffer, attachment, renderbuffertarget, renderbuffer);
            }
        }

        // GLAPI void APIENTRY glGetNamedFramebufferAttachmentParameterivEXT (GLuint framebuffer, GLenum attachment, GLenum pname, GLint *params);
        public unsafe static void GetNamedFramebufferAttachmentParameterivEXT(GLuint framebuffer, GLenum attachment, GLenum pname, GLint[] parameters)
        {
            if (glGetNamedFramebufferAttachmentParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetNamedFramebufferAttachmentParameterivEXT(framebuffer, attachment, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGenerateTextureMipmapEXT (GLuint texture, GLenum target);
        public static void GenerateTextureMipmapEXT(GLuint texture, GLenum target)
        {
            if (glGenerateTextureMipmapEXT != null)
            {
                glGenerateTextureMipmapEXT(texture, target);
            }
        }

        // GLAPI void APIENTRY glGenerateMultiTexMipmapEXT (GLenum texunit, GLenum target);
        public static void GenerateMultiTexMipmapEXT(GLenum texunit, GLenum target)
        {
            if (glGenerateMultiTexMipmapEXT != null)
            {
                glGenerateMultiTexMipmapEXT(texunit, target);
            }
        }

        // GLAPI void APIENTRY glFramebufferDrawBufferEXT (GLuint framebuffer, GLenum mode);
        public static void FramebufferDrawBufferEXT(GLuint framebuffer, GLenum mode)
        {
            if (glFramebufferDrawBufferEXT != null)
            {
                glFramebufferDrawBufferEXT(framebuffer, mode);
            }
        }

        // GLAPI void APIENTRY glFramebufferDrawBuffersEXT (GLuint framebuffer, GLsizei n, const GLenum *bufs);
        public unsafe static void FramebufferDrawBuffersEXT(GLuint framebuffer, GLsizei n, GLenum[] bufs)
        {
            if (glFramebufferDrawBuffersEXT != null)
            {
                fixed (GLenum* ptr_bufs = bufs)
                {
                    glFramebufferDrawBuffersEXT(framebuffer, n, ptr_bufs);
                }
            }
        }

        // GLAPI void APIENTRY glFramebufferReadBufferEXT (GLuint framebuffer, GLenum mode);
        public static void FramebufferReadBufferEXT(GLuint framebuffer, GLenum mode)
        {
            if (glFramebufferReadBufferEXT != null)
            {
                glFramebufferReadBufferEXT(framebuffer, mode);
            }
        }

        // GLAPI void APIENTRY glGetFramebufferParameterivEXT (GLuint framebuffer, GLenum pname, GLint *params);
        public unsafe static void GetFramebufferParameterivEXT(GLuint framebuffer, GLenum pname, GLint[] parameters)
        {
            if (glGetFramebufferParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetFramebufferParameterivEXT(framebuffer, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glNamedRenderbufferStorageMultisampleEXT (GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
        public static void NamedRenderbufferStorageMultisampleEXT(GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glNamedRenderbufferStorageMultisampleEXT != null)
            {
                glNamedRenderbufferStorageMultisampleEXT(renderbuffer, samples, internalformat, width, height);
            }
        }

        // GLAPI void APIENTRY glNamedRenderbufferStorageMultisampleCoverageEXT (GLuint renderbuffer, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height);
        public static void NamedRenderbufferStorageMultisampleCoverageEXT(GLuint renderbuffer, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glNamedRenderbufferStorageMultisampleCoverageEXT != null)
            {
                glNamedRenderbufferStorageMultisampleCoverageEXT(renderbuffer, coverageSamples, colorSamples, internalformat, width, height);
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferTextureEXT (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level);
        public static void NamedFramebufferTextureEXT(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level)
        {
            if (glNamedFramebufferTextureEXT != null)
            {
                glNamedFramebufferTextureEXT(framebuffer, attachment, texture, level);
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferTextureLayerEXT (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer);
        public static void NamedFramebufferTextureLayerEXT(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer)
        {
            if (glNamedFramebufferTextureLayerEXT != null)
            {
                glNamedFramebufferTextureLayerEXT(framebuffer, attachment, texture, level, layer);
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferTextureFaceEXT (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLenum face);
        public static void NamedFramebufferTextureFaceEXT(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLenum face)
        {
            if (glNamedFramebufferTextureFaceEXT != null)
            {
                glNamedFramebufferTextureFaceEXT(framebuffer, attachment, texture, level, face);
            }
        }

        // GLAPI void APIENTRY glTextureRenderbufferEXT (GLuint texture, GLenum target, GLuint renderbuffer);
        public static void TextureRenderbufferEXT(GLuint texture, GLenum target, GLuint renderbuffer)
        {
            if (glTextureRenderbufferEXT != null)
            {
                glTextureRenderbufferEXT(texture, target, renderbuffer);
            }
        }

        // GLAPI void APIENTRY glMultiTexRenderbufferEXT (GLenum texunit, GLenum target, GLuint renderbuffer);
        public static void MultiTexRenderbufferEXT(GLenum texunit, GLenum target, GLuint renderbuffer)
        {
            if (glMultiTexRenderbufferEXT != null)
            {
                glMultiTexRenderbufferEXT(texunit, target, renderbuffer);
            }
        }

        // GLAPI void APIENTRY glProgramUniform1dEXT (GLuint program, GLint location, GLdouble x);
        public static void ProgramUniform1dEXT(GLuint program, GLint location, GLdouble x)
        {
            if (glProgramUniform1dEXT != null)
            {
                glProgramUniform1dEXT(program, location, x);
            }
        }

        // GLAPI void APIENTRY glProgramUniform2dEXT (GLuint program, GLint location, GLdouble x, GLdouble y);
        public static void ProgramUniform2dEXT(GLuint program, GLint location, GLdouble x, GLdouble y)
        {
            if (glProgramUniform2dEXT != null)
            {
                glProgramUniform2dEXT(program, location, x, y);
            }
        }

        // GLAPI void APIENTRY glProgramUniform3dEXT (GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z);
        public static void ProgramUniform3dEXT(GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z)
        {
            if (glProgramUniform3dEXT != null)
            {
                glProgramUniform3dEXT(program, location, x, y, z);
            }
        }

        // GLAPI void APIENTRY glProgramUniform4dEXT (GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        public static void ProgramUniform4dEXT(GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glProgramUniform4dEXT != null)
            {
                glProgramUniform4dEXT(program, location, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glProgramUniform1dvEXT (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        public unsafe static void ProgramUniform1dvEXT(GLuint program, GLint location, GLsizei count, GLdouble[] value)
        {
            if (glProgramUniform1dvEXT != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniform1dvEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform2dvEXT (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        public unsafe static void ProgramUniform2dvEXT(GLuint program, GLint location, GLsizei count, GLdouble[] value)
        {
            if (glProgramUniform2dvEXT != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniform2dvEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform3dvEXT (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        public unsafe static void ProgramUniform3dvEXT(GLuint program, GLint location, GLsizei count, GLdouble[] value)
        {
            if (glProgramUniform3dvEXT != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniform3dvEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform4dvEXT (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        public unsafe static void ProgramUniform4dvEXT(GLuint program, GLint location, GLsizei count, GLdouble[] value)
        {
            if (glProgramUniform4dvEXT != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniform4dvEXT(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix2dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        public unsafe static void ProgramUniformMatrix2dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix2dvEXT != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix2dvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix3dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        public unsafe static void ProgramUniformMatrix3dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix3dvEXT != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix3dvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix4dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        public unsafe static void ProgramUniformMatrix4dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix4dvEXT != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix4dvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix2x3dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        public unsafe static void ProgramUniformMatrix2x3dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix2x3dvEXT != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix2x3dvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix2x4dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        public unsafe static void ProgramUniformMatrix2x4dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix2x4dvEXT != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix2x4dvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix3x2dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        public unsafe static void ProgramUniformMatrix3x2dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix3x2dvEXT != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix3x2dvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix3x4dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        public unsafe static void ProgramUniformMatrix3x4dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix3x4dvEXT != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix3x4dvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix4x2dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        public unsafe static void ProgramUniformMatrix4x2dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix4x2dvEXT != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix4x2dvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix4x3dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        public unsafe static void ProgramUniformMatrix4x3dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix4x3dvEXT != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix4x3dvEXT(program, location, count, transpose, ptr_value);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_vertex_array_bgra (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_swizzle (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_type_2_10_10_10_REV (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_provoking_vertex
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glProvokingVertexEXT (GLenum mode);
        public static void ProvokingVertexEXT(GLenum mode)
        {
            if (glProvokingVertexEXT != null)
            {
                glProvokingVertexEXT(mode);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_snorm (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_separate_shader_objects
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glUseShaderProgramEXT (GLenum type, GLuint program);
        public static void UseShaderProgramEXT(GLenum type, GLuint program)
        {
            if (glUseShaderProgramEXT != null)
            {
                glUseShaderProgramEXT(type, program);
            }
        }

        // GLAPI void APIENTRY glActiveProgramEXT (GLuint program);
        public static void ActiveProgramEXT(GLuint program)
        {
            if (glActiveProgramEXT != null)
            {
                glActiveProgramEXT(program);
            }
        }

        // GLAPI GLuint APIENTRY glCreateShaderProgramEXT (GLenum type, const GLchar *string);
        public static GLuint CreateShaderProgramEXT(GLenum type, string str)
        {
            if (glCreateShaderProgramEXT != null)
            {
                return glCreateShaderProgramEXT(type, str);
            }
            else
            {
                return 0;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_shader_image_load_store
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBindImageTextureEXT (GLuint index, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLint format);
        public static void BindImageTextureEXT(GLuint index, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLint format)
        {
            if (glBindImageTextureEXT != null)
            {
                glBindImageTextureEXT(index, texture, level, layered, layer, access, format);
            }
        }

        // GLAPI void APIENTRY glMemoryBarrierEXT (GLbitfield barriers);
        public static void MemoryBarrierEXT(GLbitfield barriers)
        {
            glMemoryBarrierEXT(barriers);
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_vertex_attrib_64bit
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexAttribL1dEXT (GLuint index, GLdouble x);
        public static void VertexAttribL1dEXT(GLuint index, GLdouble x)
        {
            if (glVertexAttribL1dEXT != null)
            {
                glVertexAttribL1dEXT(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL2dEXT (GLuint index, GLdouble x, GLdouble y);
        public static void VertexAttribL2dEXT(GLuint index, GLdouble x, GLdouble y)
        {
            if (glVertexAttribL2dEXT != null)
            {
                glVertexAttribL2dEXT(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL3dEXT (GLuint index, GLdouble x, GLdouble y, GLdouble z);
        public static void VertexAttribL3dEXT(GLuint index, GLdouble x, GLdouble y, GLdouble z)
        {
            if (glVertexAttribL3dEXT != null)
            {
                glVertexAttribL3dEXT(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL4dEXT (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        public static void VertexAttribL4dEXT(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glVertexAttribL4dEXT != null)
            {
                glVertexAttribL4dEXT(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL1dvEXT (GLuint index, const GLdouble *v);
        public unsafe static void VertexAttribL1dvEXT(GLuint index, GLdouble[] v)
        {
            if (glVertexAttribL1dvEXT != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttribL1dvEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribL2dvEXT (GLuint index, const GLdouble *v);
        public unsafe static void VertexAttribL2dvEXT(GLuint index, GLdouble[] v)
        {
            if (glVertexAttribL2dvEXT != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttribL2dvEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribL3dvEXT (GLuint index, const GLdouble *v);
        public unsafe static void VertexAttribL3dvEXT(GLuint index, GLdouble[] v)
        {
            if (glVertexAttribL3dvEXT != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttribL3dvEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribL4dvEXT (GLuint index, const GLdouble *v);
        public unsafe static void VertexAttribL4dvEXT(GLuint index, GLdouble[] v)
        {
            if (glVertexAttribL4dvEXT != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttribL4dvEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribLPointerEXT (GLuint index, GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        public unsafe static void VertexAttribLPointerEXT(GLuint index, GLint size, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glVertexAttribLPointerEXT != null)
            {
                glVertexAttribLPointerEXT(index, size, type, stride, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribLdvEXT (GLuint index, GLenum pname, GLdouble *params);
        public unsafe static void GetVertexAttribLdvEXT(GLuint index, GLenum pname, GLdouble[] parameters)
        {
            if (glGetVertexAttribLdvEXT != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetVertexAttribLdvEXT(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glVertexArrayVertexAttribLOffsetEXT (GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset);
        public static void VertexArrayVertexAttribLOffsetEXT(GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset)
        {
            if (glVertexArrayVertexAttribLOffsetEXT != null)
            {
                glVertexArrayVertexAttribLOffsetEXT(vaobj, buffer, index, size, type, stride, offset);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_sRGB_decode (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_x11_sync_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLsync APIENTRY glImportSyncEXT (GLenum external_sync_type, GLintptr external_sync, GLbitfield flags);
        public static GLsync ImportSyncEXT(GLenum external_sync_type, GLintptr external_sync, GLbitfield flags)
        {
            if (glImportSyncEXT != null)
            {
                return glImportSyncEXT(external_sync_type, external_sync, flags);
            }
            else
            {
                return 0;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_framebuffer_multisample_blit_scaled (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_shader_integer_mix (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_debug_label
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glLabelObjectEXT (GLenum type, GLuint object, GLsizei length, const GLchar *label);
        public static void LabelObjectEXT(GLenum type, GLuint obj, GLsizei length, string label)
        {
            if (glLabelObjectEXT != null)
            {
                glLabelObjectEXT(type, obj, length, label);
            }
        }

        // GLAPI void APIENTRY glGetObjectLabelEXT (GLenum type, GLuint object, GLsizei bufSize, GLsizei *length, GLchar *label);
        public unsafe static void GetObjectLabelEXT(GLenum type, GLuint obj, GLsizei bufSize, GLsizei[] length, GLchar[] label)
        {
            if (glGetObjectLabelEXT != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_label = label)
                    {
                        glGetObjectLabelEXT(type, obj, bufSize, ptr_length, ptr_label);
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_debug_marker
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glInsertEventMarkerEXT (GLsizei length, const GLchar *marker);
        public static void InsertEventMarkerEXT(GLsizei length, string marker)
        {
            if (glInsertEventMarkerEXT != null)
            {
                glInsertEventMarkerEXT(length, marker);
            }
        }

        // GLAPI void APIENTRY glPushGroupMarkerEXT (GLsizei length, const GLchar *marker);
        public static void PushGroupMarkerEXT(GLsizei length, string marker)
        {
            if (glPushGroupMarkerEXT != null)
            {
                glPushGroupMarkerEXT(length, marker);
            }
        }

        // GLAPI void APIENTRY glPopGroupMarkerEXT (void);
        public static void PopGroupMarkerEXT()
        {
            if (glPopGroupMarkerEXT != null)
            {
                glPopGroupMarkerEXT();
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_Cg_shader (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_edge_clamp (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_rectangle (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_storage
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexStorage1DEXT (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);
        public static void TexStorage1DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width)
        {
            if (glTexStorage1DEXT != null)
            {
                glTexStorage1DEXT(target, levels, internalformat, width);
            }
        }

        // GLAPI void APIENTRY glTexStorage2DEXT (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        public static void TexStorage2DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glTexStorage2DEXT != null)
            {
                glTexStorage2DEXT(target, levels, internalformat, width, height);
            }
        }

        // GLAPI void APIENTRY glTexStorage3DEXT (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
        public static void TexStorage3DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)
        {
            if (glTexStorage3DEXT != null)
            {
                glTexStorage3DEXT(target, levels, internalformat, width, height, depth);
            }
        }

        // GLAPI void APIENTRY glTextureStorage1DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);
        public static void TextureStorage1DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width)
        {
            if (glTextureStorage1DEXT != null)
            {
                glTextureStorage1DEXT(texture, target, levels, internalformat, width);
            }
        }

        // GLAPI void APIENTRY glTextureStorage2DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        public static void TextureStorage2DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glTextureStorage2DEXT != null)
            {
                glTextureStorage2DEXT(texture, target, levels, internalformat, width, height);
            }
        }

        // GLAPI void APIENTRY glTextureStorage3DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
        public static void TextureStorage3DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)
        {
            if (glTextureStorage3DEXT != null)
            {
                glTextureStorage3DEXT(texture, target, levels, internalformat, width, height, depth);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_transform_feedback2 
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBindTransformFeedbackEXT (GLenum target, GLuint id);
        public static void BindTransformFeedbackEXT(GLenum target, GLuint id)
        {
            if (glBindTransformFeedbackEXT != null)
            {
                glBindTransformFeedbackEXT(target, id);
            }
        }

        // GLAPI void APIENTRY glDeleteTransformFeedbacksEXT (GLsizei n, const GLuint *ids);
        public unsafe static void DeleteTransformFeedbacksEXT (GLsizei n, GLuint[] ids)
        {
            if (glDeleteTransformFeedbacksEXT != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glDeleteTransformFeedbacksEXT(n, ptr_ids);
                }
            }
        }

        // GLAPI void APIENTRY glGenTransformFeedbacksEXT (GLsizei n, GLuint *ids);
        public unsafe static void GenTransformFeedbacksEXT(GLsizei n, GLuint[] ids)
        {
            if (glGenTransformFeedbacksEXT != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glGenTransformFeedbacksEXT(n, ptr_ids);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsTransformFeedbackEXT (GLuint id);
        public static GLboolean IsTransformFeedbackEXT(GLuint id)
        {
            if (glIsTransformFeedbackEXT != null)
            {
                return glIsTransformFeedbackEXT(id);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glPauseTransformFeedbackEXT (void);
        public static void PauseTransformFeedbackEXT()
        {
            if (glPauseTransformFeedbackEXT != null)
            {
                glPauseTransformFeedbackEXT();
            }
        }

        // GLAPI void APIENTRY glResumeTransformFeedbackEXT (void);
        public static void ResumeTransformFeedbackEXT ()
        {
            if (glResumeTransformFeedbackEXT != null)
            {
                glResumeTransformFeedbackEXT();
            }
        }

        // GLAPI void APIENTRY glDrawTransformFeedbackEXT (GLenum mode, GLuint id);
        public static void DrawTransformFeedbackEXT(GLenum mode, GLuint id)
        {
            if (glDrawTransformFeedbackEXT != null)
            {
                glDrawTransformFeedbackEXT(mode, id);
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_GREMEDY_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_GREMEDY_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_GREMEDY_string_marker
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glStringMarkerGREMEDY (GLsizei len, const GLvoid *string);
        public unsafe static void StringMarkerGREMEDY(GLsizei len, IntPtr str)
        {
            if (glStringMarkerGREMEDY != null)
            {
                glStringMarkerGREMEDY(len, str.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_GREMEDY_frame_terminator
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFrameTerminatorGREMEDY (void);
        public static void FrameTerminatorGREMEDY()
        {
            if (glFrameTerminatorGREMEDY != null)
            {
                glFrameTerminatorGREMEDY();
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_HP_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_HP_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_HP_image_transform
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glImageTransformParameteriHP (GLenum target, GLenum pname, GLint param);
        public static void ImageTransformParameteriHP(GLenum target, GLenum pname, GLint param)
        {
            if (glImageTransformParameteriHP != null)
            {
                glImageTransformParameteriHP(target, pname, param);
            }
        }

        // GLAPI void APIENTRY glImageTransformParameterfHP (GLenum target, GLenum pname, GLfloat param);
        public static void ImageTransformParameterfHP(GLenum target, GLenum pname, GLfloat param)
        {
            if (glImageTransformParameterfHP != null)
            {
                glImageTransformParameterfHP(target, pname, param);
            }
        }

        // GLAPI void APIENTRY glImageTransformParameterivHP (GLenum target, GLenum pname, const GLint *params);
        public unsafe static void ImageTransformParameterivHP(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glImageTransformParameterivHP != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glImageTransformParameterivHP(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glImageTransformParameterfvHP (GLenum target, GLenum pname, const GLfloat *params);
        public unsafe static void ImageTransformParameterfvHP(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glImageTransformParameterfvHP != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glImageTransformParameterfvHP(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetImageTransformParameterivHP (GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetImageTransformParameterivHP(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetImageTransformParameterivHP != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetImageTransformParameterivHP(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetImageTransformParameterfvHP (GLenum target, GLenum pname, GLfloat *params);
        public unsafe static void GetImageTransformParameterfvHP(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetImageTransformParameterfvHP != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetImageTransformParameterfvHP(target, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_HP_convolution_border_modes (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_HP_texture_lighting (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_HP_occlusion_test (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_IBM_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_rasterpos_clip (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_cull_vertex (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_multimode_draw_arrays
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMultiModeDrawArraysIBM (const GLenum *mode, const GLint *first, const GLsizei *count, GLsizei primcount, GLint modestride);
        public unsafe static void MultiModeDrawArraysIBM(GLenum[] mode, GLint[] first, GLsizei[] count, GLsizei primcount, GLint modestride)
        {
            if (glMultiModeDrawArraysIBM != null)
            {
                fixed (GLenum* ptr_mode = mode)
                {
                    fixed (GLint* ptr_first = first)
                    {
                        fixed (GLsizei* ptr_count = count)
                        {
                            glMultiModeDrawArraysIBM(ptr_mode, ptr_first, ptr_count, primcount, modestride);
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glMultiModeDrawElementsIBM (const GLenum *mode, const GLsizei *count, GLenum type, const GLvoid* const *indices, GLsizei primcount, GLint modestride);
        public unsafe static void MultiModeDrawElementsIBM(GLenum[] mode, GLsizei[] count, GLenum type, IntPtr[] indices, GLsizei primcount, GLint modestride)
        {
            if (glMultiModeDrawElementsIBM != null)
            {
                fixed (GLenum* ptr_mode = mode)
                {
                    fixed (GLsizei* ptr_count = count)
                    {
                        fixed (IntPtr* ptr_indices = indices)
                        {
                            glMultiModeDrawElementsIBM(ptr_mode, ptr_count, type, (void**)ptr_indices, primcount, modestride);
                        }
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_vertex_array_lists
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glColorPointerListIBM (GLint size, GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        public unsafe static void ColorPointerListIBM(GLint size, GLenum type, GLint stride, IntPtr[] pointer, GLint ptrstride)
        {
            if (glColorPointerListIBM != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glColorPointerListIBM(size, type, stride, (void**)ptr_pointer, ptrstride);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColorPointerListIBM (GLint size, GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        public unsafe static void SecondaryColorPointerListIBM(GLint size, GLenum type, GLint stride, IntPtr[] pointer, GLint ptrstride)
        {
            if (glSecondaryColorPointerListIBM != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glSecondaryColorPointerListIBM(size, type, stride, (void**)ptr_pointer, ptrstride);
                }
            }
        }

        // GLAPI void APIENTRY glEdgeFlagPointerListIBM (GLint stride, const GLboolean* *pointer, GLint ptrstride);
        public unsafe static void EdgeFlagPointerListIBM(GLint stride, GLboolean*[] pointer, GLint ptrstride)
        {
            if (glEdgeFlagPointerListIBM != null)
            {
                fixed (GLboolean** ptr_pointer = pointer)
                {
                    glEdgeFlagPointerListIBM(stride, ptr_pointer, ptrstride);
                }
            }
        }

        // GLAPI void APIENTRY glFogCoordPointerListIBM (GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        public unsafe static void FogCoordPointerListIBM(GLenum type, GLint stride, IntPtr[] pointer, GLint ptrstride)
        {
            if (glFogCoordPointerListIBM != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glFogCoordPointerListIBM(type, stride, (void**)ptr_pointer, ptrstride);
                }
            }
        }

        // GLAPI void APIENTRY glIndexPointerListIBM (GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        public unsafe static void IndexPointerListIBM(GLenum type, GLint stride, IntPtr[] pointer, GLint ptrstride)
        {
            if (glIndexPointerListIBM != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glIndexPointerListIBM(type, stride, (void**)ptr_pointer, ptrstride);
                }
            }
        }

        // GLAPI void APIENTRY glNormalPointerListIBM (GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        public unsafe static void NormalPointerListIBM(GLenum type, GLint stride, IntPtr[] pointer, GLint ptrstride)
        {
            if (glNormalPointerListIBM != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glNormalPointerListIBM(type, stride, (void**)ptr_pointer, ptrstride);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoordPointerListIBM (GLint size, GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        public unsafe static void TexCoordPointerListIBM(GLint size, GLenum type, GLint stride, IntPtr[] pointer, GLint ptrstride)
        {
            if (glTexCoordPointerListIBM != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glTexCoordPointerListIBM(size, type, stride, (void**)ptr_pointer, ptrstride);
                }
            }
        }

        // GLAPI void APIENTRY glVertexPointerListIBM (GLint size, GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        public unsafe static void VertexPointerListIBM(GLint size, GLenum type, GLint stride, IntPtr[] pointer, GLint ptrstride)
        {
            if (glVertexPointerListIBM != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glVertexPointerListIBM(size, type, stride, (void**)ptr_pointer, ptrstride);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_texture_mirrored_repeat (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_INGR_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_INGR_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_INGR_blend_func_separate
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendFuncSeparateINGR (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
        public static void BlendFuncSeparateINGR(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)
        {
            if (glBlendFuncSeparateINGR != null)
            {
                BlendFuncSeparateINGR(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_INGR_color_clamp (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_INGR_interlace_read (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_INGR_palette_buffer (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_INTEL_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_parallel_arrays
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexPointervINTEL (GLint size, GLenum type, const GLvoid* *pointer);
        public unsafe static void VertexPointervINTEL(GLint size, GLenum type, IntPtr[] pointer)
        {
            if (glVertexPointervINTEL != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glVertexPointervINTEL(size, type, (void**)ptr_pointer);
                }
            }
        }

        // GLAPI void APIENTRY glNormalPointervINTEL (GLenum type, const GLvoid* *pointer);
        public unsafe static void NormalPointervINTEL(GLenum type, IntPtr[] pointer)
        {
            if (glNormalPointervINTEL != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glNormalPointervINTEL(type, (void**)ptr_pointer);
                }
            }
        }

        // GLAPI void APIENTRY glColorPointervINTEL (GLint size, GLenum type, const GLvoid* *pointer);
        public unsafe static void ColorPointervINTEL(GLint size, GLenum type, IntPtr[] pointer)
        {
            if (glColorPointervINTEL != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glColorPointervINTEL(size, type, (void**)ptr_pointer);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoordPointervINTEL (GLint size, GLenum type, const GLvoid* *pointer);
        public unsafe static void TexCoordPointervINTEL(GLint size, GLenum type, IntPtr[] pointer)
        {
            if (glTexCoordPointervINTEL != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glTexCoordPointervINTEL(size, type, (void**)ptr_pointer);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_fragment_shader_ordering (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_map_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glSyncTextureINTEL (GLuint texture);
        public static void SyncTextureINTEL(GLuint texture)
        {
            if (glSyncTextureINTEL != null)
            {
                glSyncTextureINTEL(texture);
            }
        }

        // GLAPI void APIENTRY glUnmapTexture2DINTEL (GLuint texture, GLint level);
        public static void UnmapTexture2DINTEL(GLuint texture, GLint level)
        {
            if (glUnmapTexture2DINTEL != null)
            {
                glUnmapTexture2DINTEL(texture, level);
            }
        }

        // GLAPI void *APIENTRY glMapTexture2DINTEL (GLuint texture, GLint level, GLbitfield access, GLint *stride, GLenum *layout);
        public unsafe static IntPtr MapTexture2DINTEL(GLuint texture, GLint level, GLbitfield access, GLint[] stride, GLenum[] layout)
        {
            if (glMapTexture2DINTEL != null)
            {
                fixed (GLint* ptr_stride = stride)
                {
                    fixed (GLenum* ptr_layout = layout)
                    {
                        return (IntPtr)glMapTexture2DINTEL(texture, level, access, ptr_stride, ptr_layout);
                    }
                }
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_performance_query
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginPerfQueryINTEL (GLuint queryHandle);
        public static void BeginPerfQueryINTEL(GLuint queryHandle)
        {
            if (glBeginPerfQueryINTEL != null)
            {
                glBeginPerfQueryINTEL(queryHandle);
            }
        }

        // GLAPI void APIENTRY glCreatePerfQueryINTEL (GLuint queryId, GLuint *queryHandle);
        public unsafe static void CreatePerfQueryINTEL(GLuint queryId, GLuint[] queryHandle)
        {
            if (glCreatePerfQueryINTEL != null)
            {
                fixed (GLuint* ptr_queryHandle = queryHandle)
                {
                    glCreatePerfQueryINTEL(queryId, ptr_queryHandle);
                }
            }
        }

        // GLAPI void APIENTRY glDeletePerfQueryINTEL (GLuint queryHandle);
        public static void DeletePerfQueryINTEL(GLuint queryHandle)
        {
            if (glDeletePerfQueryINTEL != null)
            {
                glDeletePerfQueryINTEL(queryHandle);
            }
        }

        // GLAPI void APIENTRY glEndPerfQueryINTEL (GLuint queryHandle);
        public static void EndPerfQueryINTEL(GLuint queryHandle)
        {
            if (glEndPerfQueryINTEL != null)
            {
                glEndPerfQueryINTEL(queryHandle);
            }
        }

        // GLAPI void APIENTRY glGetFirstPerfQueryIdINTEL (GLuint *queryId);
        public unsafe static void GetFirstPerfQueryIdINTEL(GLuint[] queryId)
        {
            if (glGetFirstPerfQueryIdINTEL != null)
            {
                fixed (GLuint* ptr_queryId = queryId)
                {
                    glGetFirstPerfQueryIdINTEL(ptr_queryId);
                }
            }
        }

        // GLAPI void APIENTRY glGetNextPerfQueryIdINTEL (GLuint queryId, GLuint *nextQueryId);
        public unsafe static void GetNextPerfQueryIdINTEL(GLuint queryId, GLuint[] nextQueryId)
        {
            if (glGetNextPerfQueryIdINTEL != null)
            {
                fixed (GLuint* ptr_nextQueryId = nextQueryId)
                {
                    glGetNextPerfQueryIdINTEL(queryId, ptr_nextQueryId);
                }
            }
        }

        // GLAPI void APIENTRY glGetPerfCounterInfoINTEL (GLuint queryId, GLuint counterId, GLuint counterNameLength, GLchar *counterName, GLuint counterDescLength, GLchar *counterDesc, GLuint *counterOffset, GLuint *counterDataSize, GLuint *counterTypeEnum, GLuint *counterDataTypeEnum, GLuint64 *rawCounterMaxValue);
        public unsafe static void GetPerfCounterInfoINTEL(GLuint queryId, GLuint counterId, GLuint counterNameLength, GLchar[] counterName, GLuint counterDescLength, GLchar[] counterDesc, GLuint[] counterOffset, GLuint[] counterDataSize, GLuint[] counterTypeEnum, GLuint[] counterDataTypeEnum, GLuint64[] rawCounterMaxValue)
        {
            if (glGetPerfCounterInfoINTEL != null)
            {
                fixed (GLchar* ptr_counterName = counterName)
                {
                    fixed (GLchar* ptr_counterDesc = counterDesc)
                    {
                        fixed (GLuint* ptr_counterOffset = counterOffset)
                        {
                            fixed (GLuint* ptr_counterDataSize = counterDataSize)
                            {
                                fixed (GLuint* ptr_counterTypeEnum = counterTypeEnum)
                                {
                                    fixed (GLuint* ptr_counterDataTypeEnum = counterDataTypeEnum)
                                    {
                                        fixed (GLuint64* ptr_rawCounterMaxValue = rawCounterMaxValue)
                                        {
                                            glGetPerfCounterInfoINTEL(queryId, counterId, counterNameLength, ptr_counterName, counterDescLength, ptr_counterDesc, ptr_counterOffset, ptr_counterDataSize, ptr_counterTypeEnum, ptr_counterDataTypeEnum, ptr_rawCounterMaxValue);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetPerfQueryDataINTEL (GLuint queryHandle, GLuint flags, GLsizei dataSize, GLvoid *data, GLuint *bytesWritten);
        public unsafe static void GetPerfQueryDataINTEL(GLuint queryHandle, GLuint flags, GLsizei dataSize, IntPtr data, GLuint[] bytesWritten)
        {
            if (glGetPerfQueryDataINTEL != null)
            {
                fixed (GLuint* ptr_bytesWritten = bytesWritten)
                {
                    glGetPerfQueryDataINTEL(queryHandle, flags, dataSize, data.ToPointer(), ptr_bytesWritten);
                }
            }
        }

        // GLAPI void APIENTRY glGetPerfQueryIdByNameINTEL (GLchar *queryName, GLuint *queryId);
        public unsafe static void GetPerfQueryIdByNameINTEL(GLchar[] queryName, GLuint[] queryId)
        {
            if (glGetPerfQueryIdByNameINTEL != null)
            {
                fixed (GLchar* ptr_queryName = queryName)
                {
                    fixed (GLuint* ptr_queryId = queryId)
                    {
                        glGetPerfQueryIdByNameINTEL(ptr_queryName, ptr_queryId);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetPerfQueryInfoINTEL (GLuint queryId, GLuint queryNameLength, GLchar *queryName, GLuint *dataSize, GLuint *noCounters, GLuint *noInstances, GLuint *capsMask);
        public unsafe static void GetPerfQueryInfoINTEL(GLuint queryId, GLuint queryNameLength, GLchar[] queryName, GLuint[] dataSize, GLuint[] noCounters, GLuint[] noInstances, GLuint[] capsMask)
        {
            if (glGetPerfQueryInfoINTEL != null)
            {
                fixed (GLchar* ptr_queryName = queryName)
                {
                    fixed (GLuint* ptr_dataSize = dataSize)
                    {
                        fixed (GLuint* ptr_noCounters = noCounters)
                        {
                            fixed (GLuint* ptr_noInstances = noInstances)
                            {
                                fixed (GLuint* ptr_capsMask = capsMask)
                                {
                                    glGetPerfQueryInfoINTEL(queryId, queryNameLength, ptr_queryName, ptr_dataSize, ptr_noCounters, ptr_noInstances, ptr_capsMask);
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_KHR_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_context_flush_control (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_debug
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 - No delegates defined */
        // GLAPI void APIENTRY glDebugMessageControl (GLenum source, GLenum type, GLenum severity, GLsizei count, const GLuint *ids, GLboolean enabled);
        // GLAPI void APIENTRY glDebugMessageInsert (GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, const GLchar *buf);
        // GLAPI void APIENTRY glDebugMessageCallback (GLDEBUGPROC callback, const void *userParam);
        // GLAPI GLuint APIENTRY glGetDebugMessageLog (GLuint count, GLsizei bufsize, GLenum *sources, GLenum *types, GLuint *ids, GLenum *severities, GLsizei *lengths, GLchar *messageLog);
        // GLAPI void APIENTRY glPushDebugGroup (GLenum source, GLuint id, GLsizei length, const GLchar *message);
        // GLAPI void APIENTRY glPopDebugGroup (void);
        // GLAPI void APIENTRY glObjectLabel (GLenum identifier, GLuint name, GLsizei length, const GLchar *label);
        // GLAPI void APIENTRY glGetObjectLabel (GLenum identifier, GLuint name, GLsizei bufSize, GLsizei *length, GLchar *label);
        // GLAPI void APIENTRY glObjectPtrLabel (const void *ptr, GLsizei length, const GLchar *label);
        // GLAPI void APIENTRY glGetObjectPtrLabel (const void *ptr, GLsizei bufSize, GLsizei *length, GLchar *label);

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_no_error (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_robust_buffer_access_behavior (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_robustness (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_texture_compression_astc_hdr (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_texture_compression_astc_ldr (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_texture_compression_astc_sliced_3d (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_KTX_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_KTX_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_KTX_buffer_region
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLuint APIENTRY glBufferRegionEnabled (void);
        public static GLuint BufferRegionEnabled()
        {
            if (glBufferRegionEnabled != null)
            {
                return glBufferRegionEnabled();
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glDeleteBufferRegion (GLenum region);
        public static void DeleteBufferRegion(GLenum region)
        {
            if (glDeleteBufferRegion != null)
            {
                glDeleteBufferRegion(region);
            }
        }

        // GLAPI void APIENTRY glDrawBufferRegion (GLuint region, GLint x, GLint y, GLsizei width, GLsizei height, GLint xDest, GLint yDest);
        public static void DrawBufferRegion(GLuint region, GLint x, GLint y, GLsizei width, GLsizei height, GLint xDest, GLint yDest)
        {
            if (glDrawBufferRegion != null)
            {
                glDrawBufferRegion(region, x, y, width, height, xDest, yDest);
            }
        }

        // GLAPI GLuint APIENTRY glNewBufferRegion (GLenum region);
        public static GLuint NewBufferRegion(GLenum region)
        {
            if (glNewBufferRegion != null)
            {
                return glNewBufferRegion(region);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glReadBufferRegion (GLuint region, GLint x, GLint y, GLsizei width, GLsizei height);
        public static void ReadBufferRegion(GLuint region, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glReadBufferRegion != null)
            {
                glReadBufferRegion(region, x, y, width, height);
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_MESA_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_resize_buffers
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glResizeBuffersMESA (void);
        public static void ResizeBuffersMESA()
        {
            if (glResizeBuffersMESA != null)
            {
                glResizeBuffersMESA();
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_window_pos
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glWindowPos2dMESA (GLdouble x, GLdouble y);
        public static void WindowPos2dMESA(GLdouble x, GLdouble y)
        {
            if (glWindowPos2dMESA != null)
            {
                glWindowPos2dMESA(x, y);
            }
        }

        // GLAPI void APIENTRY glWindowPos2dvMESA (const GLdouble *v);
        public unsafe static void WindowPos2dvMESA(GLdouble[] v)
        {
            if (glWindowPos2dvMESA != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glWindowPos2dvMESA(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos2fMESA (GLfloat x, GLfloat y);
        public static void WindowPos2fMESA(GLfloat x, GLfloat y)
        {
            if (glWindowPos2fMESA != null)
            {
                glWindowPos2fMESA(x, y);
            }
        }

        // GLAPI void APIENTRY glWindowPos2fvMESA (const GLfloat *v);
        public unsafe static void WindowPos2fvMESA(GLfloat[] v)
        {
            if (glWindowPos2fvMESA != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glWindowPos2fvMESA(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos2iMESA (GLint x, GLint y);
        public static void WindowPos2iMESA(GLint x, GLint y)
        {
            if (glWindowPos2iMESA != null)
            {
                glWindowPos2iMESA(x, y);
            }
        }

        // GLAPI void APIENTRY glWindowPos2ivMESA (const GLint *v);
        public unsafe static void WindowPos2ivMESA(GLint[] v)
        {
            if (glWindowPos2ivMESA != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glWindowPos2ivMESA(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos2sMESA (GLshort x, GLshort y);
        public static void WindowPos2sMESA(GLshort x, GLshort y)
        {
            if (glWindowPos2sMESA != null)
            {
                glWindowPos2sMESA(x, y);
            }
        }

        // GLAPI void APIENTRY glWindowPos2svMESA (const GLshort *v);
        public unsafe static void WindowPos2svMESA(GLshort[] v)
        {
            if (glWindowPos2svMESA != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glWindowPos2svMESA(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos3dMESA (GLdouble x, GLdouble y, GLdouble z);
        public static void WindowPos3dMESA(GLdouble x, GLdouble y, GLdouble z)
        {
            if (glWindowPos3dMESA != null)
            {
                glWindowPos3dMESA(x, y, z);
            }
        }

        // GLAPI void APIENTRY glWindowPos3dvMESA (const GLdouble *v);
        public unsafe static void WindowPos3dvMESA(GLdouble[] v)
        {
            if (glWindowPos3dvMESA != null)
            {
                fixed(GLdouble* ptr_v = v)
                {
                    glWindowPos3dvMESA(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos3fMESA (GLfloat x, GLfloat y, GLfloat z);
        public static void WindowPos3fMESA(GLfloat x, GLfloat y, GLfloat z)
        {
            if (glWindowPos3fMESA != null)
            {
                glWindowPos3fMESA(x, y, z);
            }
        }

        // GLAPI void APIENTRY glWindowPos3fvMESA (const GLfloat *v);
        public unsafe static void WindowPos3fvMESA(GLfloat[] v)
        {
            if (glWindowPos3fvMESA != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glWindowPos3fvMESA(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos3iMESA (GLint x, GLint y, GLint z);
        public static void WindowPos3iMESA(GLint x, GLint y, GLint z)
        {
            if (glWindowPos3iMESA != null)
            {
                glWindowPos3iMESA(x, y, z);
            }
        }

        // GLAPI void APIENTRY glWindowPos3ivMESA (const GLint *v);
        public unsafe static void WindowPos3ivMESA(GLint[] v)
        {
            if (glWindowPos3ivMESA != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glWindowPos3ivMESA(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos3sMESA (GLshort x, GLshort y, GLshort z);
        public static void WindowPos3sMESA(GLshort x, GLshort y, GLshort z)
        {
            if (glWindowPos3sMESA != null)
            {
                glWindowPos3sMESA(x, y, z);
            }
        }

        // GLAPI void APIENTRY glWindowPos3svMESA (const GLshort *v);
        public unsafe static void WindowPos3svMESA(GLshort[] v)
        {
            if (glWindowPos3svMESA != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glWindowPos3svMESA(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos4dMESA (GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        public static void WindowPos4dMESA(GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glWindowPos4dMESA != null)
            {
                glWindowPos4dMESA(x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glWindowPos4dvMESA (const GLdouble *v);
        public unsafe static void WindowPos4dvMESA(GLdouble[] v)
        {
            if (glWindowPos4dvMESA != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glWindowPos4dvMESA(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos4fMESA (GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        public static void WindowPos4fMESA(GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glWindowPos4fMESA != null)
            {
                glWindowPos4fMESA(x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glWindowPos4fvMESA (const GLfloat *v);
        public unsafe static void WindowPos4fvMESA(GLfloat[] v)
        {
            if (glWindowPos4fvMESA != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glWindowPos4fvMESA(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos4iMESA (GLint x, GLint y, GLint z, GLint w);
        public static void WindowPos4iMESA(GLint x, GLint y, GLint z, GLint w)
        {
            if (glWindowPos4iMESA != null)
            {
                glWindowPos4iMESA(x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glWindowPos4ivMESA (const GLint *v);
        public unsafe static void WindowPos4ivMESA(GLint[] v)
        {
            if (glWindowPos4ivMESA != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glWindowPos4ivMESA(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos4sMESA (GLshort x, GLshort y, GLshort z, GLshort w);
        public static void WindowPos4sMESA(GLshort x, GLshort y, GLshort z, GLshort w)
        {
            if (glWindowPos4sMESA != null)
            {
                glWindowPos4sMESA(x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glWindowPos4svMESA (const GLshort *v);
        public unsafe static void WindowPos4svMESA(GLshort[] v)
        {
            if (glWindowPos4svMESA != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glWindowPos4svMESA(ptr_v);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_pack_invert (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_ycbcr_texture (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_MESAX_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_MESAX_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_MESAX_texture_stack (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_NV_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texgen_reflection (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_light_max_exponent (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_array_range
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFlushVertexArrayRangeNV (void);
        public static void FlushVertexArrayRangeNV()
        {
            if (glFlushVertexArrayRangeNV != null)
            {
                glFlushVertexArrayRangeNV();
            }
        }

        // GLAPI void APIENTRY glVertexArrayRangeNV (GLsizei length, const GLvoid *pointer);
        public unsafe static void VertexArrayRangeNV(GLsizei length, IntPtr pointer)
        {
            if (glVertexArrayRangeNV != null)
            {
                glVertexArrayRangeNV(length, pointer.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_register_combiners
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCombinerParameterfvNV (GLenum pname, const GLfloat *params);
        public unsafe static void CombinerParameterfvNV(GLenum pname, GLfloat[] parameters)
        {
            if (glCombinerParameterfvNV != null)
            {
                fixed(GLfloat* ptr_parameters = parameters)
                {
                    glCombinerParameterfvNV(pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glCombinerParameterfNV (GLenum pname, GLfloat param);
        public static void CombinerParameterfNV(GLenum pname, GLfloat param)
        {
            if (glCombinerParameterfNV != null)
            {
                glCombinerParameterfNV(pname, param);
            }
        }

        // GLAPI void APIENTRY glCombinerParameterivNV (GLenum pname, const GLint *params);
        public unsafe static void CombinerParameterivNV(GLenum pname, GLint[] parameters)
        {
            if (glCombinerParameterivNV != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glCombinerParameterivNV(pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glCombinerParameteriNV (GLenum pname, GLint param);
        public static void CombinerParameteriNV (GLenum pname, GLint param)
        {
            if (glCombinerParameteriNV != null)
            {
                glCombinerParameteriNV(pname, param);
            }
        }

        // GLAPI void APIENTRY glCombinerInputNV (GLenum stage, GLenum portion, GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage);
        public static void CombinerInputNV(GLenum stage, GLenum portion, GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage)
        {
            if (glCombinerInputNV != null)
            {
                glCombinerInputNV(stage, portion, variable, input, mapping, componentUsage);
            }
        }
         
        // GLAPI void APIENTRY glCombinerOutputNV (GLenum stage, GLenum portion, GLenum abOutput, GLenum cdOutput, GLenum sumOutput, GLenum scale, GLenum bias, GLboolean abDotProduct, GLboolean cdDotProduct, GLboolean muxSum);
        public static void CombinerOutputNV(GLenum stage, GLenum portion, GLenum abOutput, GLenum cdOutput, GLenum sumOutput, GLenum scale, GLenum bias, GLboolean abDotProduct, GLboolean cdDotProduct, GLboolean muxSum)
        {
            if (glCombinerOutputNV != null)
            {
                glCombinerOutputNV(stage, portion, abOutput, cdOutput, sumOutput, scale, bias, abDotProduct, cdDotProduct, muxSum);
            }
        }

        // GLAPI void APIENTRY glFinalCombinerInputNV (GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage);
        public static void FinalCombinerInputNV(GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage)
        {
            if (glFinalCombinerInputNV != null)
            {
                glFinalCombinerInputNV(variable, input, mapping, componentUsage);
            }
        }

        // GLAPI void APIENTRY glGetCombinerInputParameterfvNV (GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLfloat *params);
        public unsafe static void GetCombinerInputParameterfvNV(GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLfloat[] parameters)
        {
            if (glGetCombinerInputParameterfvNV != null)
            {
                fixed(GLfloat* ptr_parameters = parameters)
                {
                    glGetCombinerInputParameterfvNV(stage, portion, variable, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetCombinerInputParameterivNV (GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLint *params);
        public unsafe static void GetCombinerInputParameterivNV(GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLint[] parameters)
        {
            if (glGetCombinerInputParameterivNV != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glGetCombinerInputParameterivNV(stage, portion, variable, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetCombinerOutputParameterfvNV (GLenum stage, GLenum portion, GLenum pname, GLfloat *params);
        public unsafe static void GetCombinerOutputParameterfvNV(GLenum stage, GLenum portion, GLenum pname, GLfloat[] parameters)
        {
            if (glGetCombinerOutputParameterfvNV != null)
            {
                fixed(GLfloat* ptr_parameters = parameters)
                {
                    glGetCombinerOutputParameterfvNV(stage, portion, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetCombinerOutputParameterivNV (GLenum stage, GLenum portion, GLenum pname, GLint *params);
        public unsafe static void GetCombinerOutputParameterivNV(GLenum stage, GLenum portion, GLenum pname, GLint[] parameters)
        {
            if (glGetCombinerOutputParameterivNV != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glGetCombinerOutputParameterivNV(stage, portion, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetFinalCombinerInputParameterfvNV (GLenum variable, GLenum pname, GLfloat *params);
        public unsafe static void GetFinalCombinerInputParameterfvNV(GLenum variable, GLenum pname, GLfloat[] parameters)
        {
            if (glGetFinalCombinerInputParameterfvNV != null)
            {
                fixed(GLfloat* ptr_parameters = parameters)
                {
                    glGetFinalCombinerInputParameterfvNV(variable, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetFinalCombinerInputParameterivNV (GLenum variable, GLenum pname, GLint *params);
        public unsafe static void GetFinalCombinerInputParameterivNV(GLenum variable, GLenum pname, GLint[] parameters)
        {
            if (glGetFinalCombinerInputParameterivNV != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glGetFinalCombinerInputParameterivNV(variable, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fog_distance (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texgen_emboss (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_blend_square (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_env_combine4 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fbo_color_attachments (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fence
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDeleteFencesNV (GLsizei n, const GLuint *fences);
        public unsafe static void DeleteFencesNV (GLsizei n, GLuint[] fences)
        {
            if (glDeleteFencesNV != null)
            {
                fixed(GLuint* ptr_fences = fences)
                {
                    glDeleteFencesNV(n, ptr_fences);
                }
            }
        }

        // GLAPI void APIENTRY glGenFencesNV (GLsizei n, GLuint *fences);
        public unsafe static void GenFencesNV (GLsizei n, GLuint[] fences)
        {
            if (glGenFencesNV != null)
            {
                fixed (GLuint* ptr_fences = fences)
                {
                    glGenFencesNV(n, ptr_fences);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsFenceNV (GLuint fence);
        public static GLboolean IsFenceNV(GLuint fence)
        {
            if (glIsFenceNV != null)
            {
                return glIsFenceNV(fence);
            }
            else
            {
                return false;
            }
        }

        // GLAPI GLboolean APIENTRY glTestFenceNV (GLuint fence);
        public static GLboolean TestFenceNV(GLuint fence)
        {
            if (glTestFenceNV != null)
            {
                return glTestFenceNV(fence);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glGetFenceivNV (GLuint fence, GLenum pname, GLint *params);
        public unsafe static void GetFenceivNV(GLuint fence, GLenum pname, GLint[] parameters)
        {
            if (glGetFenceivNV != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glGetFenceivNV(fence, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glFinishFenceNV (GLuint fence);
        public static void FinishFenceNV(GLuint fence)
        {
            if (glFinishFenceNV != null)
            {
                glFinishFenceNV(fence);
            }
        }

        // GLAPI void APIENTRY glSetFenceNV (GLuint fence, GLenum condition);
        public static void SetFenceNV (GLuint fence, GLenum condition)
        {
            if (glSetFenceNV != null)
            {
                glSetFenceNV(fence, condition);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_evaluators
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMapControlPointsNV (GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLint uorder, GLint vorder, GLboolean packed, const GLvoid *points);
        public unsafe static void MapControlPointsNV(GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLint uorder, GLint vorder, GLboolean packed, IntPtr points)
        {
            if (glMapControlPointsNV != null)
            {
                glMapControlPointsNV(target, index, type, ustride, vstride, uorder, vorder, packed, points.ToPointer());
            }
        }

        // GLAPI void APIENTRY glMapParameterivNV (GLenum target, GLenum pname, const GLint *params);
        public unsafe static void MapParameterivNV(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glMapParameterivNV != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glMapParameterivNV(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glMapParameterfvNV (GLenum target, GLenum pname, const GLfloat *params);
        public unsafe static void MapParameterfvNV(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glMapParameterfvNV != null)
            {
                fixed(GLfloat* ptr_parameters = parameters)
                {
                    glMapParameterfvNV(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMapControlPointsNV (GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLboolean packed, GLvoid *points);
        public unsafe static void GetMapControlPointsNV(GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLboolean packed, IntPtr points)
        {
            if (glGetMapControlPointsNV != null)
            {
                glGetMapControlPointsNV(target, index, type, ustride, vstride, packed, points.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetMapParameterivNV (GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetMapParameterivNV(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetMapParameterivNV != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glGetMapParameterivNV(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMapParameterfvNV (GLenum target, GLenum pname, GLfloat *params);
        public unsafe static void GetMapParameterfvNV(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetMapParameterfvNV != null)
            {
                fixed(GLfloat* ptr_parameters = parameters)
                {
                    glGetMapParameterfvNV(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMapAttribParameterivNV (GLenum target, GLuint index, GLenum pname, GLint *params);
        public unsafe static void GetMapAttribParameterivNV(GLenum target, GLuint index, GLenum pname, GLint[] parameters)
        {
            if (glGetMapAttribParameterivNV != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glGetMapAttribParameterivNV(target, index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMapAttribParameterfvNV (GLenum target, GLuint index, GLenum pname, GLfloat *params);
        public unsafe static void GetMapAttribParameterfvNV(GLenum target, GLuint index, GLenum pname, GLfloat[] parameters)
        {
            if (glGetMapAttribParameterfvNV != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetMapAttribParameterfvNV(target, index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glEvalMapsNV (GLenum target, GLenum mode);
        public static void EvalMapsNV(GLenum target, GLenum mode)
        {
            if (glEvalMapsNV != null)
            {
                glEvalMapsNV(target, mode);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_packed_depth_stencil (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_register_combiners2
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCombinerStageParameterfvNV (GLenum stage, GLenum pname, const GLfloat *params);
        public unsafe static void CombinerStageParameterfvNV(GLenum stage, GLenum pname, GLfloat[] parameters)
        {
            if (glCombinerStageParameterfvNV != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glCombinerStageParameterfvNV(stage, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetCombinerStageParameterfvNV (GLenum stage, GLenum pname, GLfloat *params);
        public unsafe static void GetCombinerStageParameterfvNV(GLenum stage, GLenum pname, GLfloat[] parameters)
        {
            if (glGetCombinerStageParameterfvNV != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetCombinerStageParameterfvNV(stage, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_compression_vtc (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_rectangle (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_shader (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_shader2 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_array_range2 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_program
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLboolean APIENTRY glAreProgramsResidentNV (GLsizei n, const GLuint *programs, GLboolean *residences);
        public unsafe static GLboolean AreProgramsResidentNV(GLsizei n, GLuint[] programs, GLboolean[] residences)
        {
            if (glAreProgramsResidentNV != null)
            {
                fixed (GLuint* ptr_programs = programs)
                {
                    fixed (GLboolean* ptr_residences = residences)
                    {
                        return glAreProgramsResidentNV(n, ptr_programs, ptr_residences);
                    }
                }
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glBindProgramNV (GLenum target, GLuint id);
        public static void BindProgramNV(GLenum target, GLuint id)
        {
            if (glBindProgramNV != null)
            {
                glBindProgramNV(target, id);
            }
        }

        // GLAPI void APIENTRY glDeleteProgramsNV (GLsizei n, const GLuint *programs);
        public unsafe static void DeleteProgramsNV(GLsizei n, GLuint[] programs)
        {
            if (glDeleteProgramsNV != null)
            {
                fixed (GLuint* ptr_programs = programs)
                {
                    glDeleteProgramsNV(n, ptr_programs);
                }
            }
        }

        // GLAPI void APIENTRY glExecuteProgramNV (GLenum target, GLuint id, const GLfloat *params);
        public unsafe static void ExecuteProgramNV(GLenum target, GLuint id, GLfloat[] parameters)
        {
            if (glExecuteProgramNV != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glExecuteProgramNV(target, id, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGenProgramsNV (GLsizei n, GLuint *programs);
        public unsafe static void GenProgramsNV(GLsizei n, GLuint[] programs)
        {
            if (glGenProgramsNV != null)
            {
                fixed (GLuint* ptr_programs = programs)
                {
                    glGenProgramsNV(n, ptr_programs);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramParameterdvNV (GLenum target, GLuint index, GLenum pname, GLdouble *params);
        public unsafe static void GetProgramParameterdvNV(GLenum target, GLuint index, GLenum pname, GLdouble[] parameters)
        {
            if (glGetProgramParameterdvNV != null)
            {
                fixed(GLdouble* ptr_parameters = parameters)
                {
                    glGetProgramParameterdvNV(target, index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramParameterfvNV (GLenum target, GLuint index, GLenum pname, GLfloat *params);
        public unsafe static void GetProgramParameterfvNV(GLenum target, GLuint index, GLenum pname, GLfloat[] parameters)
        {
            if (glGetProgramParameterfvNV != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetProgramParameterfvNV(target, index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramivNV (GLuint id, GLenum pname, GLint *params);
        public unsafe static void GetProgramivNV(GLuint id, GLenum pname, GLint[] parameters)
        {
            if (glGetProgramivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetProgramivNV(id, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramStringNV (GLuint id, GLenum pname, GLubyte *program);
        public unsafe static void GetProgramStringNV(GLuint id, GLenum pname, GLubyte[] program)
        {
            if (glGetProgramStringNV != null)
            {
                fixed(GLubyte* ptr_program = program)
                {
                    glGetProgramStringNV(id, pname, ptr_program);
                }
            }
        }

        // GLAPI void APIENTRY glGetTrackMatrixivNV (GLenum target, GLuint address, GLenum pname, GLint *params);
        public unsafe static void GetTrackMatrixivNV(GLenum target, GLuint address, GLenum pname, GLint[] parameters)
        {
            if (glGetTrackMatrixivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetTrackMatrixivNV(target, address, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribdvNV (GLuint index, GLenum pname, GLdouble *params);
        public unsafe static void GetVertexAttribdvNV(GLuint index, GLenum pname, GLdouble[] parameters)
        {
            if (glGetVertexAttribdvNV != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetVertexAttribdvNV(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribfvNV (GLuint index, GLenum pname, GLfloat *params);
        public unsafe static void GetVertexAttribfvNV(GLuint index, GLenum pname, GLfloat[] parameters)
        {
            if (glGetVertexAttribfvNV != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetVertexAttribfvNV(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribivNV (GLuint index, GLenum pname, GLint *params);
        public unsafe static void GetVertexAttribivNV(GLuint index, GLenum pname, GLint[] parameters)
        {
            if (glGetVertexAttribivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetVertexAttribivNV(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribPointervNV (GLuint index, GLenum pname, GLvoid* *pointer);
        public unsafe static void GetVertexAttribPointervNV(GLuint index, GLenum pname, IntPtr[] pointer)
        {
            if (glGetVertexAttribPointervNV != null)
            {
                fixed(IntPtr* ptr_pointer = pointer)
                {
                    glGetVertexAttribPointervNV(index, pname, (void**)ptr_pointer);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsProgramNV (GLuint id);
        public static GLboolean IsProgramNV(GLuint id)
        {
            if (glIsProgramNV != null)
            {
                return glIsProgramNV(id);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glLoadProgramNV (GLenum target, GLuint id, GLsizei len, const GLubyte *program);
        public unsafe static void LoadProgramNV(GLenum target, GLuint id, GLsizei len, GLubyte[] program)
        {
            if (glLoadProgramNV != null)
            {
                fixed (GLubyte* ptr_program = program)
                {
                    glLoadProgramNV(target, id, len, ptr_program);
                }
            }
        }

        // GLAPI void APIENTRY glProgramParameter4dNV (GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        public static void ProgramParameter4dNV(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glProgramParameter4dNV != null)
            {
                glProgramParameter4dNV(target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glProgramParameter4dvNV (GLenum target, GLuint index, const GLdouble *v);
        public unsafe static void ProgramParameter4dvNV(GLenum target, GLuint index, GLdouble[] v)
        {
            if (glProgramParameter4dvNV != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glProgramParameter4dvNV(target, index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glProgramParameter4fNV (GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        public static void ProgramParameter4fNV(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glProgramParameter4fNV != null)
            {
                glProgramParameter4fNV(target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glProgramParameter4fvNV (GLenum target, GLuint index, const GLfloat *v);
        public unsafe static void ProgramParameter4fvNV(GLenum target, GLuint index, GLfloat[] v)
        {
            if (glProgramParameter4fvNV != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glProgramParameter4fvNV(target, index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glProgramParameters4dvNV (GLenum target, GLuint index, GLsizei count, const GLdouble *v);
        public unsafe static void ProgramParameters4dvNV(GLenum target, GLuint index, GLsizei count, GLdouble[] v)
        {
            if (glProgramParameters4dvNV != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glProgramParameters4dvNV(target, index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glProgramParameters4fvNV (GLenum target, GLuint index, GLsizei count, const GLfloat *v);
        public unsafe static void ProgramParameters4fvNV(GLenum target, GLuint index, GLsizei count, GLfloat[] v)
        {
            if (glProgramParameters4fvNV != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glProgramParameters4fvNV(target, index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glRequestResidentProgramsNV (GLsizei n, const GLuint *programs);
        public unsafe static void RequestResidentProgramsNV(GLsizei n, GLuint[] programs)
        {
            if (glRequestResidentProgramsNV != null)
            {
                fixed (GLuint* ptr_programs = programs)
                {
                    glRequestResidentProgramsNV(n, ptr_programs);
                }
            }
        }

        // GLAPI void APIENTRY glTrackMatrixNV (GLenum target, GLuint address, GLenum matrix, GLenum transform);
        public static void TrackMatrixNV(GLenum target, GLuint address, GLenum matrix, GLenum transform)
        {
            if (glTrackMatrixNV != null)
            {
                glTrackMatrixNV(target, address, matrix, transform);
            }
        }

        // GLAPI void APIENTRY glVertexAttribPointerNV (GLuint index, GLint fsize, GLenum type, GLsizei stride, const GLvoid *pointer);
        public unsafe static void VertexAttribPointerNV(GLuint index, GLint fsize, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glVertexAttribPointerNV != null)
            {
                glVertexAttribPointerNV(index, fsize, type, stride, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1dNV (GLuint index, GLdouble x);
        public static void VertexAttrib1dNV(GLuint index, GLdouble x)
        {
            if (glVertexAttrib1dNV != null)
            {
                glVertexAttrib1dNV(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1dvNV (GLuint index, const GLdouble *v);
        public unsafe static void VertexAttrib1dvNV(GLuint index, GLdouble[] v)
        {
            if (glVertexAttrib1dvNV != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttrib1dvNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1fNV (GLuint index, GLfloat x);
        public static void VertexAttrib1fNV(GLuint index, GLfloat x)
        {
            if (glVertexAttrib1fNV != null)
            {
                glVertexAttrib1fNV(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1fvNV (GLuint index, const GLfloat *v);
        public unsafe static void VertexAttrib1fvNV(GLuint index, GLfloat[] v)
        {
            if (glVertexAttrib1fvNV != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertexAttrib1fvNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1sNV (GLuint index, GLshort x);
        public static void VertexAttrib1sNV(GLuint index, GLshort x)
        {
            if (glVertexAttrib1sNV != null)
            {
                glVertexAttrib1sNV(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1svNV (GLuint index, const GLshort *v);
        public unsafe static void VertexAttrib1svNV(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib1svNV != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttrib1svNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2dNV (GLuint index, GLdouble x, GLdouble y);
        public static void VertexAttrib2dNV (GLuint index, GLdouble x, GLdouble y)
        {
            if (glVertexAttrib2dNV != null)
            {
                glVertexAttrib2dNV(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2dvNV (GLuint index, const GLdouble *v);
        public unsafe static void VertexAttrib2dvNV(GLuint index, GLdouble[] v)
        {
            if (glVertexAttrib2dvNV != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttrib2dvNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2fNV (GLuint index, GLfloat x, GLfloat y);
        public static void VertexAttrib2fNV(GLuint index, GLfloat x, GLfloat y)
        {
            if (glVertexAttrib2fNV != null)
            {
                glVertexAttrib2fNV(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2fvNV (GLuint index, const GLfloat *v);
        public unsafe static void VertexAttrib2fvNV(GLuint index, GLfloat[] v)
        {
            if (glVertexAttrib2fvNV != null)
            {
                fixed(GLfloat* ptr_v = v)
                {
                    glVertexAttrib2fvNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2sNV (GLuint index, GLshort x, GLshort y);
        public static void VertexAttrib2sNV(GLuint index, GLshort x, GLshort y)
        {
            if (glVertexAttrib2sNV != null)
            {
                glVertexAttrib2sNV(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2svNV (GLuint index, const GLshort *v);
        public unsafe static void VertexAttrib2svNV(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib2svNV != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttrib2svNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3dNV (GLuint index, GLdouble x, GLdouble y, GLdouble z);
        public static void VertexAttrib3dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z)
        {
            if (glVertexAttrib3dNV != null)
            {
                glVertexAttrib3dNV(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3dvNV (GLuint index, const GLdouble *v);
        public unsafe static void VertexAttrib3dvNV (GLuint index, GLdouble[] v)
        {
            if (glVertexAttrib3dvNV != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttrib3dvNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3fNV (GLuint index, GLfloat x, GLfloat y, GLfloat z);
        public static void VertexAttrib3fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glVertexAttrib3fNV != null)
            {
                glVertexAttrib3fNV(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3fvNV (GLuint index, const GLfloat *v);
        public unsafe static void VertexAttrib3fvNV(GLuint index, GLfloat[] v)
        {
            if (glVertexAttrib3fvNV != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertexAttrib3fvNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3sNV (GLuint index, GLshort x, GLshort y, GLshort z);
        public static void VertexAttrib3sNV(GLuint index, GLshort x, GLshort y, GLshort z)
        {
            if (glVertexAttrib3sNV != null)
            {
                glVertexAttrib3sNV(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3svNV (GLuint index, const GLshort *v);
        public unsafe static void VertexAttrib3svNV(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib3svNV != null)
            {
                fixed(GLshort* ptr_v = v)
                {
                    glVertexAttrib3svNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4dNV (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        public static void VertexAttrib4dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glVertexAttrib4dNV != null)
            {
                glVertexAttrib4dNV(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4dvNV (GLuint index, const GLdouble *v);
        public unsafe static void VertexAttrib4dvNV(GLuint index, GLdouble[] v)
        {
            if (glVertexAttrib4dvNV != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttrib4dvNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4fNV (GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        public static void VertexAttrib4fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glVertexAttrib4fNV != null)
            {
                glVertexAttrib4fNV(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4fvNV (GLuint index, const GLfloat *v);
        public unsafe static void VertexAttrib4fvNV(GLuint index, GLfloat[] v)
        {
            if (glVertexAttrib4fvNV != null)
            {
                fixed(GLfloat* ptr_v = v)
                {
                    glVertexAttrib4fvNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4sNV (GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        public static void VertexAttrib4sNV(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
        {
            if (glVertexAttrib4sNV != null)
            {
                glVertexAttrib4sNV(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4svNV (GLuint index, const GLshort *v);
        public unsafe static void VertexAttrib4svNV(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib4svNV != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttrib4svNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4ubNV (GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        public static void VertexAttrib4ubNV(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
        {
            if (glVertexAttrib4ubNV != null)
            {
                glVertexAttrib4ubNV(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4ubvNV (GLuint index, const GLubyte *v);
        public unsafe static void VertexAttrib4ubvNV (GLuint index, GLubyte[] v)
        {
            if (glVertexAttrib4ubvNV != null)
            {
                fixed(GLubyte* ptr_v = v)
                {
                    glVertexAttrib4ubvNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs1dvNV (GLuint index, GLsizei count, const GLdouble *v);
        public unsafe static void VertexAttribs1dvNV(GLuint index, GLsizei count, GLdouble[] v)
        {
            if (glVertexAttribs1dvNV != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttribs1dvNV(index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs1fvNV (GLuint index, GLsizei count, const GLfloat *v);
        public unsafe static void VertexAttribs1fvNV(GLuint index, GLsizei count, GLfloat[] v)
        {
            if (glVertexAttribs1fvNV != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertexAttribs1fvNV(index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs1svNV (GLuint index, GLsizei count, const GLshort *v);
        public unsafe static void VertexAttribs1svNV(GLuint index, GLsizei count, GLshort[] v)
        {
            if (glVertexAttribs1svNV != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttribs1svNV(index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs2dvNV (GLuint index, GLsizei count, const GLdouble *v);
        public unsafe static void VertexAttribs2dvNV(GLuint index, GLsizei count, GLdouble[] v)
        {
            if (glVertexAttribs2dvNV != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttribs2dvNV(index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs2fvNV (GLuint index, GLsizei count, const GLfloat *v);
        public unsafe static void VertexAttribs2fvNV(GLuint index, GLsizei count, GLfloat[] v)
        {
            if (glVertexAttribs2fvNV != null)
            {
                fixed(GLfloat* ptr_v = v)
                {
                    glVertexAttribs2fvNV(index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs2svNV (GLuint index, GLsizei count, const GLshort *v);
        public unsafe static void VertexAttribs2svNV(GLuint index, GLsizei count, GLshort[] v)
        {
            if (glVertexAttribs2svNV != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttribs2svNV(index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs3dvNV (GLuint index, GLsizei count, const GLdouble *v);
        public unsafe static void VertexAttribs3dvNV(GLuint index, GLsizei count, GLdouble[] v)
        {
            if (glVertexAttribs3dvNV != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttribs3dvNV(index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs3fvNV (GLuint index, GLsizei count, const GLfloat *v);
        public unsafe static void VertexAttribs3fvNV(GLuint index, GLsizei count, GLfloat[] v)
        {
            if (glVertexAttribs3fvNV != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertexAttribs3fvNV(index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs3svNV (GLuint index, GLsizei count, const GLshort *v);
        public unsafe static void VertexAttribs3svNV(GLuint index, GLsizei count, GLshort[] v)
        {
            if (glVertexAttribs3svNV != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttribs3svNV(index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs4dvNV (GLuint index, GLsizei count, const GLdouble *v);
        public unsafe static void VertexAttribs4dvNV(GLuint index, GLsizei count, GLdouble[] v)
        {
            if (glVertexAttribs4dvNV != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttribs4dvNV(index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs4fvNV (GLuint index, GLsizei count, const GLfloat *v);
        public unsafe static void VertexAttribs4fvNV(GLuint index, GLsizei count, GLfloat[] v)
        {
            if (glVertexAttribs4fvNV != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertexAttribs4fvNV(index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs4svNV (GLuint index, GLsizei count, const GLshort *v);
        public unsafe static void VertexAttribs4svNV(GLuint index, GLsizei count, GLshort[] v)
        {
            if (glVertexAttribs4svNV != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttribs4svNV(index, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs4ubvNV (GLuint index, GLsizei count, const GLubyte *v);
        public unsafe static void VertexAttribs4ubvNV(GLuint index, GLsizei count, GLubyte[] v)
        {
            if (glVertexAttribs4ubvNV != null)
            {
                fixed (GLubyte* ptr_v = v)
                {
                    glVertexAttribs4ubvNV(index, count, ptr_v);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_copy_depth_to_color (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_multisample_filter_hint (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_depth_clamp (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_occlusion_query
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGenOcclusionQueriesNV (GLsizei n, GLuint *ids);
        public unsafe static void GenOcclusionQueriesNV(GLsizei n, GLuint[] ids)
        {
            if (glGenOcclusionQueriesNV != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glGenOcclusionQueriesNV(n, ptr_ids);
                }
            }
        }

        // GLAPI void APIENTRY glDeleteOcclusionQueriesNV (GLsizei n, const GLuint *ids);
        public unsafe static void DeleteOcclusionQueriesNV(GLsizei n, GLuint[] ids)
        {
            if (glDeleteOcclusionQueriesNV != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glDeleteOcclusionQueriesNV(n, ptr_ids);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsOcclusionQueryNV (GLuint id);
        public static GLboolean IsOcclusionQueryNV(GLuint id)
        {
            if (glIsOcclusionQueryNV != null)
            {
                return glIsOcclusionQueryNV(id);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glBeginOcclusionQueryNV (GLuint id);
        public static void BeginOcclusionQueryNV(GLuint id)
        {
            if (glBeginOcclusionQueryNV != null)
            {
                glBeginOcclusionQueryNV(id);
            }
        }

        // GLAPI void APIENTRY glEndOcclusionQueryNV (void);
        public static void EndOcclusionQueryNV()
        {
            if (glEndOcclusionQueryNV != null)
            {
                glEndOcclusionQueryNV();
            }
        }

        // GLAPI void APIENTRY glGetOcclusionQueryivNV (GLuint id, GLenum pname, GLint *params);
        public unsafe static void GetOcclusionQueryivNV(GLuint id, GLenum pname, GLint[] parameters)
        {
            if (glGetOcclusionQueryivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetOcclusionQueryivNV(id, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetOcclusionQueryuivNV (GLuint id, GLenum pname, GLuint *params);
        public unsafe static void GetOcclusionQueryuivNV(GLuint id, GLenum pname, GLuint[] parameters)
        {
            if (glGetOcclusionQueryuivNV != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetOcclusionQueryuivNV(id, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_point_sprite
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPointParameteriNV (GLenum pname, GLint param);
        public static void PointParameteriNV(GLenum pname, GLint param)
        {
            if (glPointParameteriNV != null)
            {
                glPointParameteriNV(pname, param);
            }
        }

        // GLAPI void APIENTRY glPointParameterivNV (GLenum pname, const GLint *params);
        public unsafe static void PointParameterivNV(GLenum pname, GLint[] parameters)
        {
            if (glPointParameterivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glPointParameterivNV(pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_shader3 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_program1_1 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_float_buffer (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fragment_program
        ///////////////////////////////////////////////////////////////////////
        /* Some NV_fragment_program entry points are shared with ARB_vertex_program. */
        // GLAPI void APIENTRY glProgramNamedParameter4fNV (GLuint id, GLsizei len, const GLubyte *name, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        public unsafe static void ProgramNamedParameter4fNV(GLuint id, GLsizei len, GLubyte[] name, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glProgramNamedParameter4fNV != null)
            {
                fixed (GLubyte* ptr_name = name)
                {
                    glProgramNamedParameter4fNV(id, len, ptr_name, x, y, z, w);
                }
            }
        }

        // GLAPI void APIENTRY glProgramNamedParameter4dNV (GLuint id, GLsizei len, const GLubyte *name, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        public unsafe static void ProgramNamedParameter4dNV(GLuint id, GLsizei len, GLubyte[] name, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glProgramNamedParameter4dNV != null)
            {
                fixed (GLubyte* ptr_name = name)
                {
                    glProgramNamedParameter4dNV(id, len, ptr_name, x, y, z, w);
                }
            }
        }

        // GLAPI void APIENTRY glProgramNamedParameter4fvNV (GLuint id, GLsizei len, const GLubyte *name, const GLfloat *v);
        public unsafe static void ProgramNamedParameter4fvNV(GLuint id, GLsizei len, GLubyte[] name, GLfloat[] v)
        {
            if (glProgramNamedParameter4fvNV != null)
            {
                fixed (GLubyte* ptr_name = name)
                {
                    fixed (GLfloat* ptr_v = v)
                    {
                        glProgramNamedParameter4fvNV(id, len, ptr_name, ptr_v);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glProgramNamedParameter4dvNV (GLuint id, GLsizei len, const GLubyte *name, const GLdouble *v);
        public unsafe static void ProgramNamedParameter4dvNV(GLuint id, GLsizei len, GLubyte[] name, GLdouble[] v)
        {
            if (glProgramNamedParameter4dvNV != null)
            {
                fixed (GLubyte* ptr_name = name)
                {
                    fixed (GLdouble* ptr_v = v)
                    {
                        glProgramNamedParameter4dvNV(id, len, ptr_name, ptr_v);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramNamedParameterfvNV (GLuint id, GLsizei len, const GLubyte *name, GLfloat *params);
        public unsafe static void GetProgramNamedParameterfvNV(GLuint id, GLsizei len, GLubyte[] name, GLfloat[] parameters)
        {
            if (glGetProgramNamedParameterfvNV != null)
            {
                fixed (GLubyte* ptr_name = name)
                {
                    fixed (GLfloat* ptr_parameters = parameters)
                    {
                        glGetProgramNamedParameterfvNV(id, len, ptr_name, ptr_parameters);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramNamedParameterdvNV (GLuint id, GLsizei len, const GLubyte *name, GLdouble *params);
        public unsafe static void GetProgramNamedParameterdvNV(GLuint id, GLsizei len, GLubyte[] name, GLdouble[] parameters)
        {
            if (glGetProgramNamedParameterdvNV != null)
            {
                fixed (GLubyte* ptr_name = name)
                {
                    fixed (GLdouble* ptr_parameters = parameters)
                    {
                        glGetProgramNamedParameterdvNV(id, len, ptr_name, ptr_parameters);
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_half_float
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertex2hNV (GLhalfNV x, GLhalfNV y);
        public static void Vertex2hNV(GLhalf x, GLhalf y)
        {
            if (glVertex2hNV != null)
            {
                glVertex2hNV(x, y);
            }
        }

        // GLAPI void APIENTRY glVertex2hvNV (const GLhalfNV *v);
        public unsafe static void Vertex2hvNV(GLhalf[] v)
        {
            if (glVertex2hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glVertex2hvNV(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertex3hNV (GLhalfNV x, GLhalfNV y, GLhalfNV z);
        public static void Vertex3hNV(GLhalf x, GLhalf y, GLhalf z)
        {
            if (glVertex3hNV != null)
            {
                glVertex3hNV(x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertex3hvNV (const GLhalfNV *v);
        public unsafe static void Vertex3hvNV(GLhalf[] v)
        {
            if (glVertex3hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glVertex3hvNV(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertex4hNV (GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w);
        public static void Vertex4hNV(GLhalf x, GLhalf y, GLhalf z, GLhalf w)
        {
            if (glVertex4hNV != null)
            {
                glVertex4hNV(x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertex4hvNV (const GLhalfNV *v);
        public unsafe static void Vertex4hvNV(GLhalf[] v)
        {
            if (glVertex4hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glVertex4hvNV(ptr_v);
                }
            }
        }
        
        // GLAPI void APIENTRY glNormal3hNV (GLhalfNV nx, GLhalfNV ny, GLhalfNV nz);
        public static void Normal3hNV(GLhalf nx, GLhalf ny, GLhalf nz)
        {
            if (glNormal3hNV != null)
            {
                glNormal3hNV(nx, ny, nz);
            }
        }

        // GLAPI void APIENTRY glNormal3hvNV (const GLhalfNV *v);
        public unsafe static void Normal3hvNV(GLhalf[] v)
        {
            if (glNormal3hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glNormal3hvNV(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glColor3hNV (GLhalfNV red, GLhalfNV green, GLhalfNV blue);
        public static void Color3hNV(GLhalf red, GLhalf green, GLhalf blue)
        {
            if (glColor3hNV != null)
            {
                glColor3hNV(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glColor3hvNV (const GLhalfNV *v);
        public unsafe static void Color3hvNV(GLhalf[] v)
        {
            if (glColor3hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glColor3hvNV(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glColor4hNV (GLhalfNV red, GLhalfNV green, GLhalfNV blue, GLhalfNV alpha);
        public static void Color4hNV(GLhalf red, GLhalf green, GLhalf blue, GLhalf alpha)
        {
            if (glColor4hNV != null)
            {
                glColor4hNV(red, green, blue, alpha);
            }
        }

        // GLAPI void APIENTRY glColor4hvNV (const GLhalfNV *v);
        public unsafe static void Color4hvNV(GLhalf[] v)
        {
            if (glColor4hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glColor4hvNV(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord1hNV (GLhalfNV s);
        public static void TexCoord1hNV(GLhalf s)
        {
            if (glTexCoord1hNV != null)
            {
                glTexCoord1hNV(s);
            }
        }

        // GLAPI void APIENTRY glTexCoord1hvNV (const GLhalfNV *v);
        public unsafe static void TexCoord1hvNV(GLhalf[] v)
        {
            if (glTexCoord1hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glTexCoord1hvNV(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord2hNV (GLhalfNV s, GLhalfNV t);
        public static void TexCoord2hNV(GLhalf s, GLhalf t)
        {
            if (glTexCoord2hNV != null)
            {
                glTexCoord2hNV(s, t);
            }
        }

        // GLAPI void APIENTRY glTexCoord2hvNV (const GLhalfNV *v);
        public unsafe static void TexCoord2hvNV(GLhalf[] v)
        {
            if (glTexCoord2hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glTexCoord2hvNV(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord3hNV (GLhalfNV s, GLhalfNV t, GLhalfNV r);
        public static void TexCoord3hNV(GLhalf s, GLhalf t, GLhalf r)
        {
            if (glTexCoord3hNV != null)
            {
                glTexCoord3hNV(s, t, r);
            }
        }

        // GLAPI void APIENTRY glTexCoord3hvNV (const GLhalfNV *v);
        public unsafe static void TexCoord3hvNV(GLhalf[] v)
        {
            if (glTexCoord3hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glTexCoord3hvNV(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord4hNV (GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q);
        public static void TexCoord4hNV(GLhalf s, GLhalf t, GLhalf r, GLhalf q)
        {
            if (glTexCoord4hNV != null)
            {
                glTexCoord4hNV(s, t, r, q);
            }
        }

        // GLAPI void APIENTRY glTexCoord4hvNV (const GLhalfNV *v);
        public unsafe static void TexCoord4hvNV(GLhalf[] v)
        {
            if (glTexCoord4hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glTexCoord4hvNV(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord1hNV (GLenum target, GLhalfNV s);
        public static void MultiTexCoord1hNV(GLenum target, GLhalf s)
        {
            if (glMultiTexCoord1hNV != null)
            {
                glMultiTexCoord1hNV(target, s);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord1hvNV (GLenum target, const GLhalfNV *v);
        public unsafe static void MultiTexCoord1hvNV(GLenum target, GLhalf[] v)
        {
            if (glMultiTexCoord1hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glMultiTexCoord1hvNV(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2hNV (GLenum target, GLhalfNV s, GLhalfNV t);
        public static void MultiTexCoord2hNV(GLenum target, GLhalf s, GLhalf t)
        {
            if (glMultiTexCoord2hNV != null)
            {
                glMultiTexCoord2hNV(target, s, t);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2hvNV (GLenum target, const GLhalfNV *v);
        public unsafe static void MultiTexCoord2hvNV(GLenum target, GLhalf[] v)
        {
            if (glMultiTexCoord2hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glMultiTexCoord2hvNV(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3hNV (GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r);
        public static void MultiTexCoord3hNV(GLenum target, GLhalf s, GLhalf t, GLhalf r)
        {
            if (glMultiTexCoord3hNV != null)
            {
                glMultiTexCoord3hNV(target, s, t, r);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3hvNV (GLenum target, const GLhalfNV *v);
        public unsafe static void MultiTexCoord3hvNV(GLenum target, GLhalf[] v)
        {
            if (glMultiTexCoord3hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glMultiTexCoord3hvNV(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4hNV (GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q);
        public static void MultiTexCoord4hNV(GLenum target, GLhalf s, GLhalf t, GLhalf r, GLhalf q)
        {
            if (glMultiTexCoord4hNV != null)
            {
                glMultiTexCoord4hNV(target, s, t, r, q);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4hvNV (GLenum target, const GLhalfNV *v);
        public unsafe static void MultiTexCoord4hvNV(GLenum target, GLhalf[] v)
        {
            if (glMultiTexCoord4hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glMultiTexCoord4hvNV(target, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glFogCoordhNV (GLhalfNV fog);
        public static void FogCoordhNV(GLhalf fog)
        {
            if (glFogCoordhNV != null)
            {
                glFogCoordhNV(fog);
            }
        }

        // GLAPI void APIENTRY glFogCoordhvNV (const GLhalfNV *fog);
        public unsafe static void FogCoordhvNV(GLhalf[] fog)
        {
            if (glFogCoordhvNV != null)
            {
                fixed (GLhalf* ptr_fog = fog)
                {
                    glFogCoordhvNV(ptr_fog);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3hNV (GLhalfNV red, GLhalfNV green, GLhalfNV blue);
        public static void SecondaryColor3hNV(GLhalf red, GLhalf green, GLhalf blue)
        {
            if (glSecondaryColor3hNV != null)
            {
                glSecondaryColor3hNV(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3hvNV (const GLhalfNV *v);
        public unsafe static void SecondaryColor3hvNV(GLhalf[] v)
        {
            if (glSecondaryColor3hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glSecondaryColor3hvNV(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexWeighthNV (GLhalfNV weight);
        public static void VertexWeighthNV(GLhalf weight)
        {
            if (glVertexWeighthNV != null)
            {
                glVertexWeighthNV(weight);
            }
        }

        // GLAPI void APIENTRY glVertexWeighthvNV (const GLhalfNV *weight);
        public unsafe static void VertexWeighthvNV(GLhalf[] weight)
        {
            if (glVertexWeighthvNV != null)
            {
                fixed (GLhalf* ptr_weight = weight)
                {
                    glVertexWeighthvNV(ptr_weight);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1hNV (GLuint index, GLhalfNV x);
        public static void VertexAttrib1hNV(GLuint index, GLhalf x)
        {
            if (glVertexAttrib1hNV != null)
            {
                glVertexAttrib1hNV(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1hvNV (GLuint index, const GLhalfNV *v);
        public unsafe static void VertexAttrib1hvNV(GLuint index, GLhalf[] v)
        {
            if (glVertexAttrib1hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glVertexAttrib1hvNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2hNV (GLuint index, GLhalfNV x, GLhalfNV y);
        public static void VertexAttrib2hNV(GLuint index, GLhalf x, GLhalf y)
        {
            if (glVertexAttrib2hNV != null)
            {
                glVertexAttrib2hNV(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2hvNV (GLuint index, const GLhalfNV *v);
        public unsafe static void VertexAttrib2hvNV(GLuint index, GLhalf[] v)
        {
            if (glVertexAttrib2hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glVertexAttrib2hvNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3hNV (GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z);
        public static void VertexAttrib3hNV(GLuint index, GLhalf x, GLhalf y, GLhalf z)
        {
            if (glVertexAttrib3hNV != null)
            {
                glVertexAttrib3hNV(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3hvNV (GLuint index, const GLhalfNV *v);
        public unsafe static void VertexAttrib3hvNV(GLuint index, GLhalf[] v)
        {
            if (glVertexAttrib3hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glVertexAttrib3hvNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4hNV (GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w);
        public static void VertexAttrib4hNV(GLuint index, GLhalf x, GLhalf y, GLhalf z, GLhalf w)
        {
            if (glVertexAttrib4hNV != null)
            {
                glVertexAttrib4hNV(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4hvNV (GLuint index, const GLhalfNV *v);
        public unsafe static void VertexAttrib4hvNV(GLuint index, GLhalf[] v)
        {
            if (glVertexAttrib4hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glVertexAttrib4hvNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs1hvNV (GLuint index, GLsizei n, const GLhalfNV *v);
        public unsafe static void VertexAttribs1hvNV(GLuint index, GLsizei n, GLhalf[] v)
        {
            if (glVertexAttribs1hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glVertexAttribs1hvNV(index, n, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs2hvNV (GLuint index, GLsizei n, const GLhalfNV *v);
        public unsafe static void VertexAttribs2hvNV(GLuint index, GLsizei n, GLhalf[] v)
        {
            if (glVertexAttribs2hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glVertexAttribs2hvNV(index, n, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs3hvNV (GLuint index, GLsizei n, const GLhalfNV *v);
        public unsafe static void VertexAttribs3hvNV(GLuint index, GLsizei n, GLhalf[] v)
        {
            if (glVertexAttribs3hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glVertexAttribs3hvNV(index, n, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribs4hvNV (GLuint index, GLsizei n, const GLhalfNV *v);
        public unsafe static void VertexAttribs4hvNV(GLuint index, GLsizei n, GLhalf[] v)
        {
            if (glVertexAttribs4hvNV != null)
            {
                fixed (GLhalf* ptr_v = v)
                {
                    glVertexAttribs4hvNV(index, n, ptr_v);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_pixel_data_range
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPixelDataRangeNV (GLenum target, GLsizei length, const GLvoid *pointer);
        public unsafe static void PixelDataRangeNV(GLenum target, GLsizei length, IntPtr pointer)
        {
            if (glPixelDataRangeNV != null)
            {
                glPixelDataRangeNV(target, length, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glFlushPixelDataRangeNV (GLenum target);
        public static void FlushPixelDataRangeNV(GLenum target)
        {
            if (glFlushPixelDataRangeNV != null)
            {
                glFlushPixelDataRangeNV(target);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_primitive_restart
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPrimitiveRestartNV (void);
        public static void PrimitiveRestartNV()
        {
            if (glPrimitiveRestartNV != null)
            {
                glPrimitiveRestartNV();
            }
        }

        // GLAPI void APIENTRY glPrimitiveRestartIndexNV (GLuint index);
        public static void PrimitiveRestartIndexNV(GLuint index)
        {
            if (glPrimitiveRestartIndexNV != null)
            {
                glPrimitiveRestartIndexNV(index);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_expand_normal (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_program2 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fragment_program_option (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fragment_program2 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_program2_option (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_program3 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_gpu_program4
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glProgramLocalParameterI4iNV (GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);
        public static void ProgramLocalParameterI4iNV(GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w)
        {
            if (glProgramLocalParameterI4iNV != null)
            {
                glProgramLocalParameterI4iNV(target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glProgramLocalParameterI4ivNV (GLenum target, GLuint index, const GLint *params);
        public unsafe static void ProgramLocalParameterI4ivNV(GLenum target, GLuint index, GLint[] parameters)
        {
            if (glProgramLocalParameterI4ivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glProgramLocalParameterI4ivNV(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramLocalParametersI4ivNV (GLenum target, GLuint index, GLsizei count, const GLint *params);
        public unsafe static void ProgramLocalParametersI4ivNV(GLenum target, GLuint index, GLsizei count, GLint[] parameters)
        {
            if (glProgramLocalParametersI4ivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glProgramLocalParametersI4ivNV(target, index, count, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramLocalParameterI4uiNV (GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        public static void ProgramLocalParameterI4uiNV(GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
        {
            if (glProgramLocalParameterI4uiNV != null)
            {
                glProgramLocalParameterI4uiNV(target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glProgramLocalParameterI4uivNV (GLenum target, GLuint index, const GLuint *params);
        public unsafe static void ProgramLocalParameterI4uivNV(GLenum target, GLuint index, GLuint[] parameters)
        {
            if (glProgramLocalParameterI4uivNV != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glProgramLocalParameterI4uivNV(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramLocalParametersI4uivNV (GLenum target, GLuint index, GLsizei count, const GLuint *params);
        public unsafe static void ProgramLocalParametersI4uivNV(GLenum target, GLuint index, GLsizei count, GLuint[] parameters)
        {
            if (glProgramLocalParametersI4uivNV != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glProgramLocalParametersI4uivNV(target, index, count, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramEnvParameterI4iNV (GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);
        public static void ProgramEnvParameterI4iNV(GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w)
        {
            if (glProgramEnvParameterI4iNV != null)
            {
                glProgramEnvParameterI4iNV(target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glProgramEnvParameterI4ivNV (GLenum target, GLuint index, const GLint *params);
        public unsafe static void ProgramEnvParameterI4ivNV(GLenum target, GLuint index, GLint[] parameters)
        {
            if (glProgramEnvParameterI4ivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glProgramEnvParameterI4ivNV(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramEnvParametersI4ivNV (GLenum target, GLuint index, GLsizei count, const GLint *params);
        public unsafe static void ProgramEnvParametersI4ivNV(GLenum target, GLuint index, GLsizei count, GLint[] parameters)
        {
            if (glProgramEnvParametersI4ivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glProgramEnvParametersI4ivNV(target, index, count, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramEnvParameterI4uiNV (GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        public static void ProgramEnvParameterI4uiNV(GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
        {
            if (glProgramEnvParameterI4uiNV != null)
            {
                glProgramEnvParameterI4uiNV(target, index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glProgramEnvParameterI4uivNV (GLenum target, GLuint index, const GLuint *params);
        public unsafe static void ProgramEnvParameterI4uivNV(GLenum target, GLuint index, GLuint[] parameters)
        {
            if (glProgramEnvParameterI4uivNV != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glProgramEnvParameterI4uivNV(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramEnvParametersI4uivNV (GLenum target, GLuint index, GLsizei count, const GLuint *params);
        public unsafe static void ProgramEnvParametersI4uivNV(GLenum target, GLuint index, GLsizei count, GLuint[] parameters)
        {
            if (glProgramEnvParametersI4uivNV != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glProgramEnvParametersI4uivNV(target, index, count, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramLocalParameterIivNV (GLenum target, GLuint index, GLint *params);
        public unsafe static void GetProgramLocalParameterIivNV(GLenum target, GLuint index, GLint[] parameters)
        {
            if (glGetProgramLocalParameterIivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetProgramLocalParameterIivNV(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramLocalParameterIuivNV (GLenum target, GLuint index, GLuint *params);
        public unsafe static void GetProgramLocalParameterIuivNV(GLenum target, GLuint index, GLuint[] parameters)
        {
            if (glGetProgramLocalParameterIuivNV != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetProgramLocalParameterIuivNV(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramEnvParameterIivNV (GLenum target, GLuint index, GLint *params);
        public unsafe static void GetProgramEnvParameterIivNV(GLenum target, GLuint index, GLint[] parameters)
        {
            if (glGetProgramEnvParameterIivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetProgramEnvParameterIivNV(target, index, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramEnvParameterIuivNV (GLenum target, GLuint index, GLuint *params);
        public unsafe static void GetProgramEnvParameterIuivNV(GLenum target, GLuint index, GLuint[] parameters)
        {
            if (glGetProgramEnvParameterIuivNV != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetProgramEnvParameterIuivNV(target, index, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_geometry_program4
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glProgramVertexLimitNV (GLenum target, GLint limit);
        public static void ProgramVertexLimitNV(GLenum target, GLint limit)
        {
            if (glProgramVertexLimitNV != null)
            {
                glProgramVertexLimitNV(target, limit);
            }
        }

        // GLAPI void APIENTRY glFramebufferTextureEXT (GLenum target, GLenum attachment, GLuint texture, GLint level);
        public static void FramebufferTextureEXT(GLenum target, GLenum attachment, GLuint texture, GLint level)
        {
            if (glFramebufferTextureEXT != null)
            {
                glFramebufferTextureEXT(target, attachment, texture, level);
            }
        }

        // GLAPI void APIENTRY glFramebufferTextureLayerEXT (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);
        public static void FramebufferTextureLayerEXT(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)
        {
            if (glFramebufferTextureLayerEXT != null)
            {
                glFramebufferTextureLayerEXT(target, attachment, texture, level, layer);
            }
        }

        // GLAPI void APIENTRY glFramebufferTextureFaceEXT (GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face);
        public static void FramebufferTextureFaceEXT(GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face)
        {
            if (glFramebufferTextureFaceEXT != null)
            {
                glFramebufferTextureFaceEXT(target, attachment, texture, level, face);
            }
        }
        
        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_program4
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexAttribI1iEXT (GLuint index, GLint x);
        public static void VertexAttribI1iEXT(GLuint index, GLint x)
        {
            if (glVertexAttribI1iEXT != null)
            {
                glVertexAttribI1iEXT(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI2iEXT (GLuint index, GLint x, GLint y);
        public static void VertexAttribI2iEXT(GLuint index, GLint x, GLint y)
        {
            if (glVertexAttribI2iEXT != null)
            {
                glVertexAttribI2iEXT(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI3iEXT (GLuint index, GLint x, GLint y, GLint z);
        public static void VertexAttribI3iEXT(GLuint index, GLint x, GLint y, GLint z)
        {
            if (glVertexAttribI3iEXT != null)
            {
                glVertexAttribI3iEXT(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4iEXT (GLuint index, GLint x, GLint y, GLint z, GLint w);
        public static void VertexAttribI4iEXT(GLuint index, GLint x, GLint y, GLint z, GLint w)
        {
            if (glVertexAttribI4iEXT != null)
            {
                glVertexAttribI4iEXT(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI1uiEXT (GLuint index, GLuint x);
        public static void VertexAttribI1uiEXT(GLuint index, GLuint x)
        {
            if (glVertexAttribI1uiEXT != null)
            {
                glVertexAttribI1uiEXT(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI2uiEXT (GLuint index, GLuint x, GLuint y);
        public static void VertexAttribI2uiEXT(GLuint index, GLuint x, GLuint y)
        {
            if (glVertexAttribI2uiEXT != null)
            {
                glVertexAttribI2uiEXT(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI3uiEXT (GLuint index, GLuint x, GLuint y, GLuint z);
        public static void VertexAttribI3uiEXT(GLuint index, GLuint x, GLuint y, GLuint z)
        {
            if (glVertexAttribI3uiEXT != null)
            {
                glVertexAttribI3uiEXT(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4uiEXT (GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        public static void VertexAttribI4uiEXT(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
        {
            if (glVertexAttribI4uiEXT != null)
            {
                glVertexAttribI4uiEXT(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI1ivEXT (GLuint index, const GLint *v);
        public unsafe static void VertexAttribI1ivEXT(GLuint index, GLint[] v)
        {
            if (glVertexAttribI1ivEXT != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertexAttribI1ivEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI2ivEXT (GLuint index, const GLint *v);
        public unsafe static void VertexAttribI2ivEXT(GLuint index, GLint[] v)
        {
            if (glVertexAttribI2ivEXT != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertexAttribI2ivEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI3ivEXT (GLuint index, const GLint *v);
        public unsafe static void VertexAttribI3ivEXT(GLuint index, GLint[] v)
        {
            if (glVertexAttribI3ivEXT != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertexAttribI3ivEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4ivEXT (GLuint index, const GLint *v);
        public unsafe static void VertexAttribI4ivEXT(GLuint index, GLint[] v)
        {
            if (glVertexAttribI4ivEXT != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertexAttribI4ivEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI1uivEXT (GLuint index, const GLuint *v);
        public unsafe static void VertexAttribI1uivEXT(GLuint index, GLuint[] v)
        {
            if (glVertexAttribI1uivEXT != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glVertexAttribI1uivEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI2uivEXT (GLuint index, const GLuint *v);
        public unsafe static void VertexAttribI2uivEXT(GLuint index, GLuint[] v)
        {
            if (glVertexAttribI2uivEXT != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glVertexAttribI2uivEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI3uivEXT (GLuint index, const GLuint *v);
        public unsafe static void VertexAttribI3uivEXT(GLuint index, GLuint[] v)
        {
            if (glVertexAttribI3uivEXT != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glVertexAttribI3uivEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4uivEXT (GLuint index, const GLuint *v);
        public unsafe static void VertexAttribI4uivEXT(GLuint index, GLuint[] v)
        {
            if (glVertexAttribI4uivEXT != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glVertexAttribI4uivEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4bvEXT (GLuint index, const GLbyte *v);
        public unsafe static void VertexAttribI4bvEXT(GLuint index, GLbyte[] v)
        {
            if (glVertexAttribI4bvEXT != null)
            {
                fixed (GLbyte* ptr_v = v)
                {
                    glVertexAttribI4bvEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4svEXT (GLuint index, const GLshort *v);
        public unsafe static void VertexAttribI4svEXT(GLuint index, GLshort[] v)
        {
            if (glVertexAttribI4svEXT != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttribI4svEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4ubvEXT (GLuint index, const GLubyte *v);
        public unsafe static void VertexAttribI4ubvEXT(GLuint index, GLubyte[] v)
        {
            if (glVertexAttribI4ubvEXT != null)
            {
                fixed (GLubyte* ptr_v = v)
                {
                    glVertexAttribI4ubvEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4usvEXT (GLuint index, const GLushort *v);
        public unsafe static void VertexAttribI4usvEXT(GLuint index, GLushort[] v)
        {
            if (glVertexAttribI4usvEXT != null)
            {
                fixed (GLushort* ptr_v = v)
                {
                    glVertexAttribI4usvEXT(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribIPointerEXT (GLuint index, GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        public unsafe static void VertexAttribIPointerEXT(GLuint index, GLint size, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glVertexAttribIPointerEXT != null)
            {
                glVertexAttribIPointerEXT(index, size, type, stride, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribIivEXT (GLuint index, GLenum pname, GLint *params);
        public unsafe static void GetVertexAttribIivEXT(GLuint index, GLenum pname, GLint[] parameters)
        {
            if (glGetVertexAttribIivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetVertexAttribIivEXT(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribIuivEXT (GLuint index, GLenum pname, GLuint *params);
        public unsafe static void GetVertexAttribIuivEXT(GLuint index, GLenum pname, GLuint[] parameters)
        {
            if (glGetVertexAttribIuivEXT != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetVertexAttribIuivEXT(index, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_depth_buffer_float
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDepthRangedNV (GLdouble zNear, GLdouble zFar);
        public static void DepthRangedNV(GLdouble zNear, GLdouble zFar)
        {
            if (glDepthRangedNV != null)
            {
                glDepthRangedNV(zNear, zFar);
            }
        }

        // GLAPI void APIENTRY glClearDepthdNV (GLdouble depth);
        public static void ClearDepthdNV(GLdouble depth)
        {
            if (glClearDepthdNV != null)
            {
                glClearDepthdNV(depth);
            }
        }

        // GLAPI void APIENTRY glDepthBoundsdNV (GLdouble zmin, GLdouble zmax);
        public static void DepthBoundsdNV(GLdouble zmin, GLdouble zmax)
        {
            if (glDepthBoundsdNV != null)
            {
                glDepthBoundsdNV(zmin, zmax);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fragment_program4 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_framebuffer_multisample_coverage
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glRenderbufferStorageMultisampleCoverageNV (GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height);
        public static void RenderbufferStorageMultisampleCoverageNV(GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glRenderbufferStorageMultisampleCoverageNV != null)
            {
                glRenderbufferStorageMultisampleCoverageNV(target, coverageSamples, colorSamples, internalformat, width, height);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_geometry_shader4 (no function entry point)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_parameter_buffer_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glProgramBufferParametersfvNV (GLenum target, GLuint buffer, GLuint index, GLsizei count, const GLfloat *params);
        public unsafe static void ProgramBufferParametersfvNV(GLenum target, GLuint buffer, GLuint index, GLsizei count, GLfloat[] parameters)
        {
            if (glProgramBufferParametersfvNV != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glProgramBufferParametersfvNV(target, buffer, index, count, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramBufferParametersIivNV (GLenum target, GLuint buffer, GLuint index, GLsizei count, const GLint *params);
        public unsafe static void ProgramBufferParametersIivNV(GLenum target, GLuint buffer, GLuint index, GLsizei count, GLint[] parameters)
        {
            if (glProgramBufferParametersIivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glProgramBufferParametersIivNV(target, buffer, index, count, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramBufferParametersIuivNV (GLenum target, GLuint buffer, GLuint index, GLsizei count, const GLuint *params);
        public unsafe static void ProgramBufferParametersIuivNV(GLenum target, GLuint buffer, GLuint index, GLsizei count, GLuint[] parameters)
        {
            if (glProgramBufferParametersIuivNV != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glProgramBufferParametersIuivNV(target, buffer, index, count, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_transform_feedback
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginTransformFeedbackNV (GLenum primitiveMode);
        public static void BeginTransformFeedbackNV(GLenum primitiveMode)
        {
            if (glBeginTransformFeedbackNV != null)
            {
                glBeginTransformFeedbackNV(primitiveMode);
            }
        }

        // GLAPI void APIENTRY glEndTransformFeedbackNV (void);
        public static void EndTransformFeedbackNV()
        {
            if (glEndTransformFeedbackNV != null)
            {
                glEndTransformFeedbackNV();
            }
        }

        // GLAPI void APIENTRY glTransformFeedbackAttribsNV (GLuint count, const GLint *attribs, GLenum bufferMode);
        public unsafe static void TransformFeedbackAttribsNV(GLuint count, GLint[] attribs, GLenum bufferMode)
        {
            if (glTransformFeedbackAttribsNV != null)
            {
                fixed (GLint* ptr_attribs = attribs)
                {
                    glTransformFeedbackAttribsNV(count, ptr_attribs, bufferMode);
                }
            }
        }

        // GLAPI void APIENTRY glBindBufferRangeNV (GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
        public static void BindBufferRangeNV(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
        {
            if (glBindBufferRangeNV != null)
            {
                glBindBufferRangeNV(target, index, buffer, offset, size);
            }
        }

        // GLAPI void APIENTRY glBindBufferOffsetNV (GLenum target, GLuint index, GLuint buffer, GLintptr offset);
        public static void BindBufferOffsetNV(GLenum target, GLuint index, GLuint buffer, GLintptr offset)
        {
            if (glBindBufferOffsetNV != null)
            {
                glBindBufferOffsetNV(target, index, buffer, offset);
            }
        }

        // GLAPI void APIENTRY glBindBufferBaseNV (GLenum target, GLuint index, GLuint buffer);
        public static void BindBufferBaseNV(GLenum target, GLuint index, GLuint buffer)
        {
            if (glBindBufferBaseNV != null)
            {
                glBindBufferBaseNV(target, index, buffer);
            }
        }

        // GLAPI void APIENTRY glTransformFeedbackVaryingsNV (GLuint program, GLsizei count, const GLint *locations, GLenum bufferMode);
        public unsafe static void TransformFeedbackVaryingsNV(GLuint program, GLsizei count, GLint[] locations, GLenum bufferMode)
        {
            if (glTransformFeedbackVaryingsNV != null)
            {
                fixed (GLint* ptr_locations = locations)
                {
                    glTransformFeedbackVaryingsNV(program, count, ptr_locations, bufferMode);
                }
            }
        }

        // GLAPI void APIENTRY glActiveVaryingNV (GLuint program, const GLchar *name);
        public static void ActiveVaryingNV(GLuint program, string name)
        {
            if (glActiveVaryingNV != null)
            {
                glActiveVaryingNV(program, name);
            }
        }

        // GLAPI GLint APIENTRY glGetVaryingLocationNV (GLuint program, const GLchar *name);
        public static GLint GetVaryingLocationNV(GLuint program, string name)
        {
            if (glGetVaryingLocationNV != null)
            {
                return glGetVaryingLocationNV(program, name);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glGetActiveVaryingNV (GLuint program, GLuint index, GLsizei bufSize, GLsizei *length, GLsizei *size, GLenum *type, GLchar *name);
        public unsafe static void GetActiveVaryingNV(GLuint program, GLuint index, GLsizei bufSize, GLsizei[] length, GLsizei[] size, GLenum[] type, GLchar[] name)
        {
            if (glGetActiveVaryingNV != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLsizei* ptr_size = size)
                    {
                        fixed (GLenum* ptr_type = type)
                        {
                            fixed (GLchar* ptr_name = name)
                            {
                                glGetActiveVaryingNV(program, index, bufSize, ptr_length, ptr_size, ptr_type, ptr_name);
                            }
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetTransformFeedbackVaryingNV (GLuint program, GLuint index, GLint *location);
        public unsafe static void GetTransformFeedbackVaryingNV(GLuint program, GLuint index, GLint[] location)
        {
            if (glGetTransformFeedbackVaryingNV != null)
            {
                fixed (GLint* ptr_location = location)
                {
                    glGetTransformFeedbackVaryingNV(program, index, ptr_location);
                }
            }
        }

        // GLAPI void APIENTRY glTransformFeedbackStreamAttribsNV (GLsizei count, const GLint *attribs, GLsizei nbuffers, const GLint *bufstreams, GLenum bufferMode);
        public unsafe static void TransformFeedbackStreamAttribsNV(GLsizei count, GLint[] attribs, GLsizei nbuffers, GLint[] bufstreams, GLenum bufferMode)
        {
            if (glTransformFeedbackStreamAttribsNV != null)
            {
                fixed (GLint* ptr_attribs = attribs)
                {
                    fixed (GLint* ptr_bufstreams = bufstreams)
                    {
                        glTransformFeedbackStreamAttribsNV(count, ptr_attribs, nbuffers, ptr_bufstreams, bufferMode);
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_conditional_render
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginConditionalRenderNV (GLuint id, GLenum mode);
        public static void BeginConditionalRenderNV(GLuint id, GLenum mode)
        {
            if (glBeginConditionalRenderNV != null)
            {
                glBeginConditionalRenderNV(id, mode);
            }
        }

        // GLAPI void APIENTRY glEndConditionalRenderNV (void);
        public static void EndConditionalRenderNV()
        {
            if (glEndConditionalRenderNV != null)
            {
                glEndConditionalRenderNV();
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_present_video
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPresentFrameKeyedNV (GLuint video_slot, GLuint64EXT minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLuint key0, GLenum target1, GLuint fill1, GLuint key1);
        public static void PresentFrameKeyedNV(GLuint video_slot, GLuint64 minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLuint key0, GLenum target1, GLuint fill1, GLuint key1)
        {
            if (glPresentFrameKeyedNV != null)
            {
                glPresentFrameKeyedNV(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, key0, target1, fill1, key1);
            }
        }

        // GLAPI void APIENTRY glPresentFrameDualFillNV (GLuint video_slot, GLuint64EXT minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLenum target1, GLuint fill1, GLenum target2, GLuint fill2, GLenum target3, GLuint fill3);
        public static void PresentFrameDualFillNV(GLuint video_slot, GLuint64 minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLenum target1, GLuint fill1, GLenum target2, GLuint fill2, GLenum target3, GLuint fill3)
        {
            if (glPresentFrameDualFillNV != null)
            {
                glPresentFrameDualFillNV(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, target1, fill1, target2, fill2, target3, fill3);
            }
        }

        // GLAPI void APIENTRY glGetVideoivNV (GLuint video_slot, GLenum pname, GLint *params);
        public unsafe static void GetVideoivNV(GLuint video_slot, GLenum pname, GLint[] parameters)
        {
            if (glGetVideoivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetVideoivNV(video_slot, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVideouivNV (GLuint video_slot, GLenum pname, GLuint *params);
        public unsafe static void GetVideouivNV(GLuint video_slot, GLenum pname, GLuint[] parameters)
        {
            if (glGetVideouivNV != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetVideouivNV(video_slot, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVideoi64vNV (GLuint video_slot, GLenum pname, GLint64EXT *params);
        public unsafe static void GetVideoi64vNV(GLuint video_slot, GLenum pname, GLint64[] parameters)
        {
            if (glGetVideoi64vNV != null)
            {
                fixed (GLint64* ptr_parameters = parameters)
                {
                    glGetVideoi64vNV(video_slot, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVideoui64vNV (GLuint video_slot, GLenum pname, GLuint64EXT *params);
        public unsafe static void GetVideoui64vNV(GLuint video_slot, GLenum pname, GLuint64[] parameters)
        {
            if (glGetVideoui64vNV != null)
            {
                fixed (GLuint64* ptr_parameters = parameters)
                {
                    glGetVideoui64vNV(video_slot, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_explicit_multisample
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetMultisamplefvNV (GLenum pname, GLuint index, GLfloat *val);
        public unsafe static void GetMultisamplefvNV(GLenum pname, GLuint index, GLfloat[] val)
        {
            if (glGetMultisamplefvNV != null)
            {
                fixed (GLfloat* ptr_val = val)
                {
                    glGetMultisamplefvNV(pname, index, ptr_val);
                }
            }
        }

        // GLAPI void APIENTRY glSampleMaskIndexedNV (GLuint index, GLbitfield mask);
        public static void SampleMaskIndexedNV(GLuint index, GLbitfield mask)
        {
            if (glSampleMaskIndexedNV != null)
            {
                glSampleMaskIndexedNV(index, mask);
            }
        }

        // GLAPI void APIENTRY glTexRenderbufferNV (GLenum target, GLuint renderbuffer);
        public static void TexRenderbufferNV(GLenum target, GLuint renderbuffer)
        {
            if (glTexRenderbufferNV != null)
            {
                glTexRenderbufferNV(target, renderbuffer);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_transform_feedback2
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBindTransformFeedbackNV (GLenum target, GLuint id);
        public static void BindTransformFeedbackNV(GLenum target, GLuint id)
        {
            if (glBindTransformFeedbackNV != null)
            {
                glBindTransformFeedbackNV(target, id);
            }
        }

        // GLAPI void APIENTRY glDeleteTransformFeedbacksNV (GLsizei n, const GLuint *ids);
        public unsafe static void DeleteTransformFeedbacksNV(GLsizei n, GLuint[] ids)
        {
            if (glDeleteTransformFeedbacksNV != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glDeleteTransformFeedbacksNV(n, ptr_ids);
                }
            }
        }

        // GLAPI void APIENTRY glGenTransformFeedbacksNV (GLsizei n, GLuint *ids);
        public unsafe static void GenTransformFeedbacksNV(GLsizei n, GLuint[] ids)
        {
            if (glGenTransformFeedbacksNV != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glGenTransformFeedbacksNV(n, ptr_ids);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsTransformFeedbackNV (GLuint id);
        public static GLboolean IsTransformFeedbackNV(GLuint id)
        {
            if (glIsTransformFeedbackNV != null)
            {
                return glIsTransformFeedbackNV(id);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glPauseTransformFeedbackNV (void);
        public static void PauseTransformFeedbackNV()
        {
            if (glPauseTransformFeedbackNV != null)
            {
                glPauseTransformFeedbackNV();
            }
        }

        // GLAPI void APIENTRY glResumeTransformFeedbackNV (void);
        public static void ResumeTransformFeedbackNV()
        {
            if (glResumeTransformFeedbackNV != null)
            {
                glResumeTransformFeedbackNV();
            }
        }

        // GLAPI void APIENTRY glDrawTransformFeedbackNV (GLenum mode, GLuint id);
        public static void DrawTransformFeedbackNV(GLenum mode, GLuint id)
        {
            if (glDrawTransformFeedbackNV != null)
            {
                glDrawTransformFeedbackNV(mode, id);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_video_capture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginVideoCaptureNV (GLuint video_capture_slot);
        public static void BeginVideoCaptureNV(GLuint video_capture_slot)
        {
            if (glBeginVideoCaptureNV != null)
            {
                glBeginVideoCaptureNV(video_capture_slot);
            }
        }

        // GLAPI void APIENTRY glBindVideoCaptureStreamBufferNV (GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLintptrARB offset);
        public static void BindVideoCaptureStreamBufferNV(GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLintptr offset)
        {
            if (glBindVideoCaptureStreamBufferNV != null)
            {
                glBindVideoCaptureStreamBufferNV(video_capture_slot, stream, frame_region, offset);
            }
        }

        // GLAPI void APIENTRY glBindVideoCaptureStreamTextureNV (GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLenum target, GLuint texture);
        public static void BindVideoCaptureStreamTextureNV(GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLenum target, GLuint texture)
        {
            if (glBindVideoCaptureStreamTextureNV != null)
            {
                glBindVideoCaptureStreamTextureNV(video_capture_slot, stream, frame_region, target, texture);
            }
        }

        // GLAPI void APIENTRY glEndVideoCaptureNV (GLuint video_capture_slot);
        public static void EndVideoCaptureNV(GLuint video_capture_slot)
        {
            if (glEndVideoCaptureNV != null)
            {
                glEndVideoCaptureNV(video_capture_slot);
            }
        }

        // GLAPI void APIENTRY glGetVideoCaptureivNV (GLuint video_capture_slot, GLenum pname, GLint *params);
        public unsafe static void GetVideoCaptureivNV(GLuint video_capture_slot, GLenum pname, GLint[] parameters)
        {
            if (glGetVideoCaptureivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetVideoCaptureivNV(video_capture_slot, pname, ptr_parameters);
                }
            }
        }
        
        // GLAPI void APIENTRY glGetVideoCaptureStreamivNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLint *params);
        public unsafe static void GetVideoCaptureStreamivNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLint[] parameters)
        {
            if (glGetVideoCaptureStreamivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetVideoCaptureStreamivNV(video_capture_slot, stream, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVideoCaptureStreamfvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat *params);
        public unsafe static void GetVideoCaptureStreamfvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat[] parameters)
        {
            if (glGetVideoCaptureStreamfvNV != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetVideoCaptureStreamfvNV(video_capture_slot, stream, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVideoCaptureStreamdvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble *params);
        public unsafe static void GetVideoCaptureStreamdvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble[] parameters)
        {
            if (glGetVideoCaptureStreamdvNV != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetVideoCaptureStreamdvNV(video_capture_slot, stream, pname, ptr_parameters);
                }
            }
        }

        // GLAPI GLenum APIENTRY glVideoCaptureNV (GLuint video_capture_slot, GLuint *sequence_num, GLuint64EXT *capture_time);
        public unsafe static GLenum VideoCaptureNV(GLuint video_capture_slot, GLuint[] sequence_num, GLuint64[] capture_time)
        {
            if (glVideoCaptureNV != null)
            {
                fixed (GLuint* ptr_sequence_num = sequence_num)
                {
                    fixed (GLuint64* ptr_capture_time = capture_time)
                    {
                        return glVideoCaptureNV(video_capture_slot, ptr_sequence_num, ptr_capture_time);
                    }
                }
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glVideoCaptureStreamParameterivNV (GLuint video_capture_slot, GLuint stream, GLenum pname, const GLint *params);
        public unsafe static void VideoCaptureStreamParameterivNV(GLuint video_caprure_slot, GLuint stream, GLenum pname, GLint[] parameters)
        {
            if (glVideoCaptureStreamParameterivNV != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glVideoCaptureStreamParameterivNV(video_caprure_slot, stream, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glVideoCaptureStreamParameterfvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, const GLfloat *params);
        public unsafe static void VideoCaptureStreamParameterfvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat[] parameters)
        {
            if (glVideoCaptureStreamParameterfvNV != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glVideoCaptureStreamParameterfvNV(video_capture_slot, stream, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glVideoCaptureStreamParameterdvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, const GLdouble *params);
        public unsafe static void VideoCaptureStreamParameterdvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble[] parameters)
        {
            if (glVideoCaptureStreamParameterdvNV != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glVideoCaptureStreamParameterdvNV(video_capture_slot, stream, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_copy_image
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCopyImageSubDataNV (GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth);
        public static void CopyImageSubDataNV(GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth)
        {
            if (glCopyImageSubDataNV != null)
            {
                glCopyImageSubDataNV(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_parameter_buffer_object2 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_buffer_load
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMakeBufferResidentNV (GLenum target, GLenum access);
        public static void MakeBufferResidentNV(GLenum target, GLenum access)
        {
            if (glMakeBufferResidentNV != null)
            {
                glMakeBufferResidentNV(target, access);
            }
        }

        // GLAPI void APIENTRY glMakeBufferNonResidentNV (GLenum target);
        public static void MakeBufferNonResidentNV(GLenum target)
        {
            if (glMakeBufferNonResidentNV != null)
            {
                glMakeBufferNonResidentNV(target);
            }
        }

        // GLAPI GLboolean APIENTRY glIsBufferResidentNV (GLenum target);
        public static GLboolean IsBufferResidentNV(GLenum target)
        {
            if (glIsBufferResidentNV != null)
            {
                return glIsBufferResidentNV(target);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glMakeNamedBufferResidentNV (GLuint buffer, GLenum access);
        public static void MakeNamedBufferResidentNV(GLuint buffer, GLenum access)
        {
            if (glMakeNamedBufferResidentNV != null)
            {
                glMakeNamedBufferResidentNV(buffer, access);
            }
        }

        // GLAPI void APIENTRY glMakeNamedBufferNonResidentNV (GLuint buffer);
        public static void MakeNamedBufferNonResidentNV(GLuint buffer)
        {
            if (glMakeNamedBufferNonResidentNV != null)
            {
                glMakeNamedBufferNonResidentNV(buffer);
            }
        }

        // GLAPI GLboolean APIENTRY glIsNamedBufferResidentNV (GLuint buffer);
        public static GLboolean IsNamedBufferResidentNV(GLuint buffer)
        {
            if (glIsNamedBufferResidentNV != null)
            {
                return glIsNamedBufferResidentNV(buffer);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glGetBufferParameterui64vNV (GLenum target, GLenum pname, GLuint64EXT *params);
        public unsafe static void GetBufferParameterui64vNV(GLenum target, GLenum pname, GLuint64[] parameters)
        {
            if (glGetBufferParameterui64vNV != null)
            {
                fixed (GLuint64* ptr_parameters = parameters)
                {
                    glGetBufferParameterui64vNV(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetNamedBufferParameterui64vNV (GLuint buffer, GLenum pname, GLuint64EXT *params);
        public unsafe static void GetNamedBufferParameterui64vNV(GLuint buffer, GLenum pname, GLuint64[] parameters)
        {
            if (glGetNamedBufferParameterui64vNV != null)
            {
                fixed (GLuint64* ptr_parameters = parameters)
                {
                    glGetNamedBufferParameterui64vNV(buffer, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetIntegerui64vNV (GLenum value, GLuint64EXT *result);
        public unsafe static void GetIntegerui64vNV(GLenum value, GLuint64[] result)
        {
            if (glGetIntegerui64vNV != null)
            {
                fixed (GLuint64* ptr_result = result)
                {
                    glGetIntegerui64vNV(value, ptr_result);
                }
            }
        }

        // GLAPI void APIENTRY glUniformui64NV (GLint location, GLuint64EXT value);
        public static void Uniformui64NV(GLint location, GLuint64 value)
        {
            if (glUniformui64NV != null)
            {
                glUniformui64NV(location, value);
            }
        }

        // GLAPI void APIENTRY glUniformui64vNV (GLint location, GLsizei count, const GLuint64EXT *value);
        public unsafe static void Uniformui64vNV(GLint location, GLsizei count, GLuint64[] value)
        {
            if (glUniformui64vNV != null)
            {
                fixed (GLuint64* ptr_value = value)
                {
                    glUniformui64vNV(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glGetUniformui64vNV (GLuint program, GLint location, GLuint64EXT *params);
        public unsafe static void GetUniformui64vNV(GLuint program, GLint location, GLuint64[] parameters)
        {
            if (glGetUniformui64vNV != null)
            {
                fixed (GLuint64* ptr_parameters = parameters)
                {
                    glGetUniformui64vNV(program, location, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformui64NV (GLuint program, GLint location, GLuint64EXT value);
        public static void ProgramUniformui64NV(GLuint program, GLint location, GLuint64 value)
        {
            if (glProgramUniformui64NV != null)
            {
                glProgramUniformui64NV(program, location, value);
            }
        }

        // GLAPI void APIENTRY glProgramUniformui64vNV (GLuint program, GLint location, GLsizei count, const GLuint64EXT *value);
        public unsafe static void ProgramUniformui64vNV(GLuint program, GLint location, GLsizei count, GLuint64[] value)
        {
            if (glProgramUniformui64vNV != null)
            {
                fixed (GLuint64* ptr_value = value)
                {
                    glProgramUniformui64vNV(program, location, count, ptr_value);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_buffer_unified_memory
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBufferAddressRangeNV (GLenum pname, GLuint index, GLuint64EXT address, GLsizeiptr length);
        public static void BufferAddressRangeNV(GLenum pname, GLuint index, GLuint64 address, GLsizeiptr length)
        {
            if (glBufferAddressRangeNV != null)
            {
                glBufferAddressRangeNV(pname, index, address, length);
            }
        }

        // GLAPI void APIENTRY glVertexFormatNV (GLint size, GLenum type, GLsizei stride);
        public static void VertexFormatNV(GLint size, GLenum type, GLsizei stride)
        {
            if (glVertexFormatNV != null)
            {
                glVertexFormatNV(size, type, stride);
            }
        }

        // GLAPI void APIENTRY glNormalFormatNV (GLenum type, GLsizei stride);
        public static void NormalFormatNV(GLenum type, GLsizei stride)
        {
            if (glNormalFormatNV != null)
            {
                glNormalFormatNV(type, stride);
            }
        }

        // GLAPI void APIENTRY glColorFormatNV (GLint size, GLenum type, GLsizei stride);
        public static void ColorFormatNV(GLint size, GLenum type, GLsizei stride)
        {
            if (glColorFormatNV != null)
            {
                glColorFormatNV(size, type, stride);
            }
        }

        // GLAPI void APIENTRY glIndexFormatNV (GLenum type, GLsizei stride);
        public static void IndexFormatNV(GLenum type, GLsizei stride)
        {
            if (glIndexFormatNV != null)
            {
                glIndexFormatNV(type, stride);
            }
        }

        // GLAPI void APIENTRY glTexCoordFormatNV (GLint size, GLenum type, GLsizei stride);
        public static void TexCoordFormatNV(GLint size, GLenum type, GLsizei stride)
        {
            if (glTexCoordFormatNV != null)
            {
                glTexCoordFormatNV(size, type, stride);
            }
        }

        // GLAPI void APIENTRY glEdgeFlagFormatNV (GLsizei stride);
        public static void EdgeFlagFormatNV(GLsizei stride)
        {
            if (glEdgeFlagFormatNV != null)
            {
                glEdgeFlagFormatNV(stride);
            }
        }

        // GLAPI void APIENTRY glSecondaryColorFormatNV (GLint size, GLenum type, GLsizei stride);
        public static void SecondaryColorFormatNV(GLint size, GLenum type, GLsizei stride)
        {
            if (glSecondaryColorFormatNV != null)
            {
                glSecondaryColorFormatNV(size, type, stride);
            }
        }

        // GLAPI void APIENTRY glFogCoordFormatNV (GLenum type, GLsizei stride);
        public static void FogCoordFormatNV(GLenum type, GLsizei stride)
        {
            if (glFogCoordFormatNV != null)
            {
                glFogCoordFormatNV(type, stride);
            }
        }

        // GLAPI void APIENTRY glVertexAttribFormatNV (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride);
        public static void VertexAttribFormatNV(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride)
        {
            if (glVertexAttribFormatNV != null)
            {
                glVertexAttribFormatNV(index, size, type, normalized, stride);
            }
        }

        // GLAPI void APIENTRY glVertexAttribIFormatNV (GLuint index, GLint size, GLenum type, GLsizei stride);
        public static void VertexAttribIFormatNV(GLuint index, GLint size, GLenum type, GLsizei stride)
        {
            if (glVertexAttribIFormatNV != null)
            {
                glVertexAttribIFormatNV(index, size, type, stride);
            }
        }

        // GLAPI void APIENTRY glGetIntegerui64i_vNV (GLenum value, GLuint index, GLuint64EXT *result);
        public unsafe static void GetIntegerui64i_vNV(GLenum value, GLuint index, GLuint64[] result)
        {
            if (glGetIntegerui64i_vNV != null)
            {
                fixed (GLuint64* ptr_result = result)
                {
                    glGetIntegerui64i_vNV(value, index, ptr_result);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_barrier
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTextureBarrierNV (void);
        public static void TextureBarrierNV()
        {
            if (glTextureBarrierNV != null)
            {
                glTextureBarrierNV();
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_gpu_program5
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glProgramSubroutineParametersuivNV (GLenum target, GLsizei count, const GLuint *params);
        public unsafe static void ProgramSubroutineParametersuivNV(GLenum target, GLsizei count, GLuint[] parameters)
        {
            if (glProgramSubroutineParametersuivNV != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glProgramSubroutineParametersuivNV(target, count, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramSubroutineParameteruivNV (GLenum target, GLuint index, GLuint *param);
        public unsafe static void GetProgramSubroutineParameteruivNV(GLenum target, GLuint index, GLuint[] param)
        {
            if (glGetProgramSubroutineParameteruivNV != null)
            {
                fixed (GLuint* ptr_param = param)
                {
                    glGetProgramSubroutineParameteruivNV(target, index, ptr_param);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_gpu_shader5
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glUniform1i64NV (GLint location, GLint64EXT x);
        public static void Uniform1i64NV(GLint location, GLint64 x)
        {
            if (glUniform1i64NV != null)
            {
                glUniform1i64NV(location, x);
            }
        }

        // GLAPI void APIENTRY glUniform2i64NV (GLint location, GLint64EXT x, GLint64EXT y);
        public static void Uniform2i64NV(GLint location, GLint64 x, GLint64 y)
        {
            if (glUniform2i64NV != null)
            {
                glUniform2i64NV(location, x, y);
            }
        }

        // GLAPI void APIENTRY glUniform3i64NV (GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z);
        public static void Uniform3i64NV(GLint location, GLint64 x, GLint64 y, GLint64 z)
        {
            if (glUniform3i64NV != null)
            {
                glUniform3i64NV(location, x, y, z);
            }
        }

        // GLAPI void APIENTRY glUniform4i64NV (GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w);
        public static void Uniform4i64NV(GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w)
        {
            if (glUniform4i64NV != null)
            {
                glUniform4i64NV(location, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glUniform1i64vNV (GLint location, GLsizei count, const GLint64EXT *value);
        public unsafe static void Uniform1i64vNV(GLint location, GLsizei count, GLint64[] value)
        {
            if (glUniform1i64vNV != null)
            {
                fixed (GLint64* ptr_value = value)
                {
                    glUniform1i64vNV(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform2i64vNV (GLint location, GLsizei count, const GLint64EXT *value);
        public unsafe static void Uniform2i64vNV(GLint location, GLsizei count, GLint64[] value)
        {
            if (glUniform2i64vNV != null)
            {
                fixed (GLint64* ptr_value = value)
                {
                    glUniform2i64vNV(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform3i64vNV (GLint location, GLsizei count, const GLint64EXT *value);
        public unsafe static void Uniform3i64vNV(GLint location, GLsizei count, GLint64[] value)
        {
            if (glUniform3i64vNV != null)
            {
                fixed (GLint64* ptr_value = value)
                {
                    glUniform3i64vNV(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform4i64vNV (GLint location, GLsizei count, const GLint64EXT *value);
        public unsafe static void Uniform4i64vNV(GLint location, GLsizei count, GLint64[] value)
        {
            if (glUniform4i64vNV != null)
            {
                fixed (GLint64* ptr_value = value)
                {
                    glUniform4i64vNV(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform1ui64NV (GLint location, GLuint64EXT x);
        public static void Uniform1ui64NV(GLint location, GLuint64 x)
        {
            if (glUniform1ui64NV != null)
            {
                glUniform1ui64NV(location, x);
            }
        }

        // GLAPI void APIENTRY glUniform2ui64NV (GLint location, GLuint64EXT x, GLuint64EXT y);
        public static void Uniform2ui64NV(GLint location, GLuint64 x, GLuint64 y)
        {
            if (glUniform2ui64NV != null)
            {
                glUniform2ui64NV(location, x, y);
            }
        }

        // GLAPI void APIENTRY glUniform3ui64NV (GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z);
        public static void Uniform3ui64NV(GLint location, GLuint64 x, GLuint64 y, GLuint64 z)
        {
            if (glUniform3ui64NV != null)
            {
                glUniform3ui64NV(location, x, y, z);
            }
        }

        // GLAPI void APIENTRY glUniform4ui64NV (GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w);
        public static void Uniform4ui64NV(GLint location, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w)
        {
            if (glUniform4ui64NV != null)
            {
                glUniform4ui64NV(location, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glUniform1ui64vNV (GLint location, GLsizei count, const GLuint64EXT *value);
        public unsafe static void Uniform1ui64vNV(GLint location, GLsizei count, GLuint64[] value)
        {
            if (glUniform1ui64vNV != null)
            {
                fixed (GLuint64* ptr_value = value)
                {
                    glUniform1ui64vNV(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform2ui64vNV (GLint location, GLsizei count, const GLuint64EXT *value);
        public unsafe static void Uniform2ui64vNV(GLint location, GLsizei count, GLuint64[] value)
        {
            if (glUniform2ui64vNV != null)
            {
                fixed (GLuint64* ptr_value = value)
                {
                    glUniform2ui64vNV(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform3ui64vNV (GLint location, GLsizei count, const GLuint64EXT *value);
        public unsafe static void Uniform3ui64vNV(GLint location, GLsizei count, GLuint64[] value)
        {
            if (glUniform3ui64vNV != null)
            {
                fixed (GLuint64* ptr_value = value)
                {
                    glUniform3ui64vNV(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform4ui64vNV (GLint location, GLsizei count, const GLuint64EXT *value);
        public unsafe static void Uniform4ui64vNV(GLint location, GLsizei count, GLuint64[] value)
        {
            if (glUniform4ui64vNV != null)
            {
                fixed (GLuint64* ptr_value = value)
                {
                    glUniform4ui64vNV(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glGetUniformi64vNV (GLuint program, GLint location, GLint64EXT *params);
        public unsafe static void GetUniformi64vNV(GLuint program, GLint location, GLint64[] parameters)
        {
            if (glGetUniformi64vNV != null)
            {
                fixed (GLint64* ptr_parameters = parameters)
                {
                    glGetUniformi64vNV(program, location, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform1i64NV (GLuint program, GLint location, GLint64EXT x);
        public static void ProgramUniform1i64NV(GLuint program, GLint location, GLint64 x)
        {
            if (glProgramUniform1i64NV != null)
            {
                glProgramUniform1i64NV(program, location, x);
            }
        }

        // GLAPI void APIENTRY glProgramUniform2i64NV (GLuint program, GLint location, GLint64EXT x, GLint64EXT y);
        public static void ProgramUniform2i64NV(GLuint program, GLint location, GLint64 x, GLint64 y)
        {
            if (glProgramUniform2i64NV != null)
            {
                glProgramUniform2i64NV(program, location, x, y);
            }
        }

        // GLAPI void APIENTRY glProgramUniform3i64NV (GLuint program, GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z);
        public static void ProgramUniform3i64NV(GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z)
        {
            if (glProgramUniform3i64NV != null)
            {
                glProgramUniform3i64NV(program, location, x, y, z);
            }
        }

        // GLAPI void APIENTRY glProgramUniform4i64NV (GLuint program, GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w);
        public static void ProgramUniform4i64NV(GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w)
        {
            if (glProgramUniform4i64NV != null)
            {
                glProgramUniform4i64NV(program, location, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glProgramUniform1i64vNV (GLuint program, GLint location, GLsizei count, const GLint64EXT *value);
        public unsafe static void ProgramUniform1i64vNV(GLuint program, GLint location, GLsizei count, GLint64[] value)
        {
            if (glProgramUniform1i64vNV != null)
            {
                fixed (GLint64* ptr_value = value)
                {
                    glProgramUniform1i64vNV(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform2i64vNV (GLuint program, GLint location, GLsizei count, const GLint64EXT *value);
        public unsafe static void ProgramUniform2i64vNV(GLuint program, GLint location, GLsizei count, GLint64[] value)
        {
            if (glProgramUniform2i64vNV != null)
            {
                fixed (GLint64* ptr_value = value)
                {
                    glProgramUniform2i64vNV(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform3i64vNV (GLuint program, GLint location, GLsizei count, const GLint64EXT *value);
        public unsafe static void ProgramUniform3i64vNV(GLuint program, GLint location, GLsizei count, GLint64[] value)
        {
            if (glProgramUniform3i64vNV != null)
            {
                fixed (GLint64* ptr_value = value)
                {
                    glProgramUniform3i64vNV(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform4i64vNV (GLuint program, GLint location, GLsizei count, const GLint64EXT *value);
        public unsafe static void ProgramUniform4i64vNV(GLuint program, GLint location, GLsizei count, GLint64[] value)
        {
            if (glProgramUniform4i64vNV != null)
            {
                fixed (GLint64* ptr_value = value)
                {
                    glProgramUniform4i64vNV(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform1ui64NV (GLuint program, GLint location, GLuint64EXT x);
        public static void ProgramUniform1ui64NV(GLuint program, GLint location, GLuint64 x)
        {
            if (glProgramUniform1ui64NV != null)
            {
                glProgramUniform1ui64NV(program, location, x);
            }
        }

        // GLAPI void APIENTRY glProgramUniform2ui64NV (GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y);
        public static void ProgramUniform2ui64NV(GLuint program, GLint location, GLuint64 x, GLuint64 y)
        {
            if (glProgramUniform2ui64NV != null)
            {
                glProgramUniform2ui64NV(program, location, x, y);
            }
        }

        // GLAPI void APIENTRY glProgramUniform3ui64NV (GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z);
        public static void ProgramUniform3ui64NV(GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint64 z)
        {
            if (glProgramUniform3ui64NV != null)
            {
                glProgramUniform3ui64NV(program, location, x, y, z);
            }
        }

        // GLAPI void APIENTRY glProgramUniform4ui64NV (GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w);
        public static void ProgramUniform4ui64NV(GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint z, GLuint w)
        {
            if (glProgramUniform4ui64NV != null)
            {
                glProgramUniform4ui64NV(program, location, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glProgramUniform1ui64vNV (GLuint program, GLint location, GLsizei count, const GLuint64EXT *value);
        public unsafe static void ProgramUniform1ui64vNV(GLuint program, GLint location, GLsizei count, GLuint64[] value)
        {
            if (glProgramUniform1ui64vNV != null)
            {
                fixed (GLuint64* ptr_value = value)
                {
                    glProgramUniform1ui64vNV(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform2ui64vNV (GLuint program, GLint location, GLsizei count, const GLuint64EXT *value);
        public unsafe static void ProgramUniform2ui64vNV(GLuint program, GLint location, GLsizei count, GLuint64[] value)
        {
            if (glProgramUniform2ui64vNV != null)
            {
                fixed (GLuint64* ptr_value = value)
                {
                    glProgramUniform2ui64vNV(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform3ui64vNV (GLuint program, GLint location, GLsizei count, const GLuint64EXT *value);
        public unsafe static void ProgramUniform3ui64vNV(GLuint program, GLint location, GLsizei count, GLuint64[] value)
        {
            if (glProgramUniform3ui64vNV != null)
            {
                fixed (GLuint64* ptr_value = value)
                {
                    glProgramUniform3ui64vNV(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform4ui64vNV (GLuint program, GLint location, GLsizei count, const GLuint64EXT *value);
        public unsafe static void ProgramUniform4ui64vNV(GLuint program, GLint location, GLsizei count, GLuint64[] value)
        {
            if (glProgramUniform4ui64vNV != null)
            {
                fixed (GLuint64* ptr_value = value)
                {
                    glProgramUniform4ui64vNV(program, location, count, ptr_value);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_buffer_store (no function entry point)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_tessellation_program5 (no function entry point)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_attrib_integer_64bit
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexAttribL1i64NV (GLuint index, GLint64EXT x);
        public static void VertexAttribL1i64NV(GLuint index, GLint64 x)
        {
            if (glVertexAttribL1i64NV != null)
            {
                glVertexAttribL1i64NV(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL2i64NV (GLuint index, GLint64EXT x, GLint64EXT y);
        public static void VertexAttribL2i64NV(GLuint index, GLint64 x, GLint64 y)
        {
            if (glVertexAttribL2i64NV != null)
            {
                glVertexAttribL2i64NV(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL3i64NV (GLuint index, GLint64EXT x, GLint64EXT y, GLint64EXT z);
        public static void VertexAttribL3i64NV(GLuint index, GLint64 x, GLint64 y, GLint64 z)
        {
            if (glVertexAttribL3i64NV != null)
            {
                glVertexAttribL3i64NV(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL4i64NV (GLuint index, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w);
        public static void VertexAttribL4i64NV(GLuint index, GLint64 x, GLint64 y, GLint64 z, GLint64 w)
        {
            if (glVertexAttribL4i64NV != null)
            {
                glVertexAttribL4i64NV(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL1i64vNV (GLuint index, const GLint64EXT *v);
        public unsafe static void VertexAttribL1i64vNV(GLuint index, GLint64[] v)
        {
            if (glVertexAttribL1i64vNV != null)
            {
                fixed (GLint64* ptr_v = v)
                {
                    glVertexAttribL1i64vNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribL2i64vNV (GLuint index, const GLint64EXT *v);
        public unsafe static void VertexAttribL2i64vNV(GLuint index, GLint64[] v)
        {
            if (glVertexAttribL2i64vNV != null)
            {
                fixed (GLint64* ptr_v = v)
                {
                    glVertexAttribL2i64vNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribL3i64vNV (GLuint index, const GLint64EXT *v);
        public unsafe static void VertexAttribL3i64vNV(GLuint index, GLint64[] v)
        {
            if (glVertexAttribL3i64vNV != null)
            {
                fixed (GLint64* ptr_v = v)
                {
                    glVertexAttribL3i64vNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribL4i64vNV (GLuint index, const GLint64EXT *v);
        public unsafe static void VertexAttribL4i64vNV(GLuint index, GLint64[] v)
        {
            if (glVertexAttribL4i64vNV != null)
            {
                fixed (GLint64* ptr_v = v)
                {
                    glVertexAttribL4i64vNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribL1ui64NV (GLuint index, GLuint64EXT x);
        public static void VertexAttribL1ui64NV(GLuint index, GLuint64 x)
        {
            if (glVertexAttribL1ui64NV != null)
            {
                glVertexAttribL1ui64NV(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL2ui64NV (GLuint index, GLuint64EXT x, GLuint64EXT y);
        public static void VertexAttribL2ui64NV(GLuint index, GLuint64 x, GLuint64 y)
        {
            if (glVertexAttribL2ui64NV != null)
            {
                glVertexAttribL2ui64NV(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL3ui64NV (GLuint index, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z);
        public static void VertexAttribL3ui64NV(GLuint index, GLuint64 x, GLuint64 y, GLuint64 z)
        {
            if (glVertexAttribL3ui64NV != null)
            {
                glVertexAttribL3ui64NV(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL4ui64NV (GLuint index, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w);
        public static void VertexAttribL4ui64NV(GLuint index, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w)
        {
            if (glVertexAttribL4ui64NV != null)
            {
                glVertexAttribL4ui64NV(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL1ui64vNV (GLuint index, const GLuint64EXT *v);
        public unsafe static void VertexAttribL1ui64vNV(GLuint index, GLuint64[] v)
        {
            if (glVertexAttribL1ui64vNV != null)
            {
                fixed (GLuint64* ptr_v = v)
                {
                    glVertexAttribL1ui64vNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribL2ui64vNV (GLuint index, const GLuint64EXT *v);
        public unsafe static void VertexAttribL2ui64vNV(GLuint index, GLuint64[] v)
        {
            if (glVertexAttribL2ui64vNV != null)
            {
                fixed (GLuint64* ptr_v = v)
                {
                    glVertexAttribL2ui64vNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribL3ui64vNV (GLuint index, const GLuint64EXT *v);
        public unsafe static void VertexAttribL3ui64vNV(GLuint index, GLuint64[] v)
        {
            if (glVertexAttribL3ui64vNV != null)
            {
                fixed (GLuint64* ptr_v = v)
                {
                    glVertexAttribL3ui64vNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribL4ui64vNV (GLuint index, const GLuint64EXT *v);
        public unsafe static void VertexAttribL4ui64vNV(GLuint index, GLuint64[] v)
        {
            if (glVertexAttribL4ui64vNV != null)
            {
                fixed (GLuint64* ptr_v = v)
                {
                    glVertexAttribL4ui64vNV(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribLi64vNV (GLuint index, GLenum pname, GLint64EXT *params);
        public unsafe static void GetVertexAttribLi64vNV(GLuint index, GLenum pname, GLint64[] parameters)
        {
            if (glGetVertexAttribLi64vNV != null)
            {
                fixed (GLint64* ptr_parameters = parameters)
                {
                    glGetVertexAttribLi64vNV(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribLui64vNV (GLuint index, GLenum pname, GLuint64EXT *params);
        public unsafe static void GetVertexAttribLui64vNV(GLuint index, GLenum pname, GLuint64[] parameters)
        {
            if (glGetVertexAttribLui64vNV != null)
            {
                fixed (GLuint64* ptr_parameters = parameters)
                {
                    glGetVertexAttribLui64vNV(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribLFormatNV (GLuint index, GLint size, GLenum type, GLsizei stride);
        public static void VertexAttribLFormatNV(GLuint index, GLint size, GLenum type, GLsizei stride)
        {
            if (glVertexAttribLFormatNV != null)
            {
                glVertexAttribLFormatNV(index, size, type, stride);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_multisample_coverage (no function entry point)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vdpau_interop
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVDPAUInitNV (const GLvoid *vdpDevice, const GLvoid *getProcAddress);
        public unsafe static void VDPAUInitNV(IntPtr vdpDevice, IntPtr getProcAddress)
        {
            if (glVDPAUInitNV != null)
            {
                glVDPAUInitNV(vdpDevice.ToPointer(), getProcAddress.ToPointer());
            }
        }

        // GLAPI void APIENTRY glVDPAUFiniNV (void);
        public static void VDPAUFiniNV()
        {
            if (glVDPAUFiniNV != null)
            {
                glVDPAUFiniNV();
            }
        }

        // GLAPI GLvdpauSurfaceNV APIENTRY glVDPAURegisterVideoSurfaceNV (GLvoid *vdpSurface, GLenum target, GLsizei numTextureNames, const GLuint *textureNames);
        public unsafe static GLvdpauSurface VDPAURegisterVideoSurfaceNV(IntPtr vdpSurface, GLenum target, GLsizei numTextureNames, GLuint[] textureNames)
        {
            if (glVDPAURegisterVideoSurfaceNV != null)
            {
                fixed (GLuint* ptr_textureNames = textureNames)
                {
                    return glVDPAURegisterVideoSurfaceNV(vdpSurface.ToPointer(), target, numTextureNames, ptr_textureNames);
                }
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLvdpauSurfaceNV APIENTRY glVDPAURegisterOutputSurfaceNV (GLvoid *vdpSurface, GLenum target, GLsizei numTextureNames, const GLuint *textureNames);
        public unsafe static GLvdpauSurface VDPAURegisterOutputSurfaceNV(IntPtr vdpSurface, GLenum target, GLsizei numTextureNames, GLuint[] textureNames)
        {
            if (glVDPAURegisterOutputSurfaceNV != null)
            {
                fixed (GLuint* ptr_textureNames = textureNames)
                {
                    return glVDPAURegisterOutputSurfaceNV(vdpSurface.ToPointer(), target, numTextureNames, ptr_textureNames);
                }
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glVDPAUIsSurfaceNV (GLvdpauSurfaceNV surface);
        public static void VDPAUIsSurfaceNV(GLvdpauSurface surface)
        {
            if (glVDPAUIsSurfaceNV != null)
            {
                glVDPAUIsSurfaceNV(surface);
            }
        }

        // GLAPI void APIENTRY glVDPAUUnregisterSurfaceNV (GLvdpauSurfaceNV surface);
        public static void VDPAUUnregisterSurfaceNV(GLvdpauSurface surface)
        {
            if (glVDPAUUnregisterSurfaceNV != null)
            {
                glVDPAUUnregisterSurfaceNV(surface);
            }
        }

        // GLAPI void APIENTRY glVDPAUGetSurfaceivNV (GLvdpauSurfaceNV surface, GLenum pname, GLsizei bufSize, GLsizei *length, GLint *values);
        public unsafe static void VDPAUGetSurfaceivNV(GLvdpauSurface surface, GLenum pname, GLsizei bufSize, GLsizei[] length, GLint[] values)
        {
            if (glVDPAUGetSurfaceivNV != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLint* ptr_values = values)
                    {
                        glVDPAUGetSurfaceivNV(surface, pname, bufSize, ptr_length, ptr_values);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glVDPAUSurfaceAccessNV (GLvdpauSurfaceNV surface, GLenum access);
        public static void VDPAUSurfaceAccessNV(GLvdpauSurface surface, GLenum access)
        {
            if (glVDPAUSurfaceAccessNV != null)
            {
                glVDPAUSurfaceAccessNV(surface, access);
            }
        }

        // GLAPI void APIENTRY glVDPAUMapSurfacesNV (GLsizei numSurfaces, const GLvdpauSurfaceNV *surfaces);
        public unsafe static void VDPAUMapSurfacesNV(GLsizei numSurfaces, GLvdpauSurface[] surfaces)
        {
            if (glVDPAUMapSurfacesNV != null)
            {
                fixed (GLvdpauSurface* ptr_surfaces = surfaces)
                {
                    glVDPAUMapSurfacesNV(numSurfaces, ptr_surfaces);
                }
            }
        }

        // GLAPI void APIENTRY glVDPAUUnmapSurfacesNV (GLsizei numSurface, const GLvdpauSurfaceNV *surfaces);
        public unsafe static void VDPAUUnmapSurfacesNV(GLsizei numSurface, GLvdpauSurface[] surfaces)
        {
            if (glVDPAUUnmapSurfacesNV != null)
            {
                fixed (GLvdpauSurface* ptr_surfaces = surfaces)
                {
                    glVDPAUUnmapSurfacesNV(numSurface, ptr_surfaces);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_multisample
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexImage2DMultisampleCoverageNV (GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations);
        public static void TexImage2DMultisampleCoverageNV(GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations)
        {
            if (glTexImage2DMultisampleCoverageNV != null)
            {
                glTexImage2DMultisampleCoverageNV(target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
            }
        }

        // GLAPI void APIENTRY glTexImage3DMultisampleCoverageNV (GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations);
        public static void TexImage3DMultisampleCoverageNV(GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations)
        {
            if (glTexImage3DMultisampleCoverageNV != null)
            {
                glTexImage3DMultisampleCoverageNV(target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
            }
        }

        // GLAPI void APIENTRY glTextureImage2DMultisampleNV (GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations);
        public static void TextureImage2DMultisampleNV(GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations)
        {
            if (glTextureImage2DMultisampleNV != null)
            {
                glTextureImage2DMultisampleNV(texture, target, samples, internalFormat, width, height, fixedSampleLocations);
            }
        }

        // GLAPI void APIENTRY glTextureImage3DMultisampleNV (GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations);
        public static void TextureImage3DMultisampleNV(GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations)
        {
            if (glTextureImage3DMultisampleNV != null)
            {
                glTextureImage3DMultisampleNV(texture, target, samples, internalFormat, width, height, depth, fixedSampleLocations);
            }
        }

        // GLAPI void APIENTRY glTextureImage2DMultisampleCoverageNV (GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations);
        public static void TextureImage2DMultisampleCoverageNV(GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations)
        {
            if (glTextureImage2DMultisampleCoverageNV != null)
            {
                glTextureImage2DMultisampleCoverageNV(texture, target, coverageSamples, colorSamples, internalFormat, width, height, fixedSampleLocations);
            }
        }

        // GLAPI void APIENTRY glTextureImage3DMultisampleCoverageNV (GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations);
        public static void TextureImage3DMultisampleCoverageNV(GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations)
        {
            if (glTextureImage3DMultisampleCoverageNV != null)
            {
                glTextureImage3DMultisampleCoverageNV(texture, target, coverageSamples, colorSamples, internalFormat, width, height, depth, fixedSampleLocations);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_path_rendering
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLuint APIENTRY glGenPathsNV (GLsizei range);
        public static GLuint GenPathsNV(GLsizei range)
        {
            if (glGenPathsNV != null)
            {
                return glGenPathsNV(range);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glDeletePathsNV (GLuint path, GLsizei range);
        public static void DeletePathsNV(GLuint path, GLsizei range)
        {
            if (glDeletePathsNV != null)
            {
                glDeletePathsNV(path, range);
            }
        }
        
        // GLAPI GLboolean APIENTRY glIsPathNV (GLuint path);
        public static GLboolean IsPathNV(GLuint path)
        {
            if (glIsPathNV != null)
            {
                return glIsPathNV(path);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glPathCommandsNV (GLuint path, GLsizei numCommands, const GLubyte *commands, GLsizei numCoords, GLenum coordType, const GLvoid *coords);
        public unsafe static void PathCommandsNV(GLuint path, GLsizei numCommands, GLubyte[] commands, GLsizei numCoords, GLenum coordType, IntPtr coords)
        {
            if (glPathCommandsNV != null)
            {
                fixed (GLubyte* ptr_commands = commands)
                {
                    glPathCommandsNV(path, numCommands, ptr_commands, numCoords, coordType, coords.ToPointer());
                }
            }
        }

        // GLAPI void APIENTRY glPathCoordsNV (GLuint path, GLsizei numCoords, GLenum coordType, const GLvoid *coords);
        public unsafe static void PathCoordsNV(GLuint path, GLsizei numCoords, GLenum coordType, IntPtr coords)
        {
            if (glPathCoordsNV != null)
            {
                glPathCoordsNV(path, numCoords, coordType, coords.ToPointer());
            }
        }

        // GLAPI void APIENTRY glPathSubCommandsNV (GLuint path, GLsizei commandStart, GLsizei commandsToDelete, GLsizei numCommands, const GLubyte *commands, GLsizei numCoords, GLenum coordType, const GLvoid *coords);
        public unsafe static void PathSubCommandsNV(GLuint path, GLsizei commandStart, GLsizei commandsToDelete, GLsizei numCommands, GLubyte[] commands, GLsizei numCoords, GLenum coordType, IntPtr coords)
        {
            if (glPathSubCommandsNV != null)
            {
                fixed (GLubyte* ptr_commands = commands)
                {
                    glPathSubCommandsNV(path, commandStart, commandsToDelete, numCommands, ptr_commands, numCoords, coordType, coords.ToPointer());
                }
            }
        }

        // GLAPI void APIENTRY glPathSubCoordsNV (GLuint path, GLsizei coordStart, GLsizei numCoords, GLenum coordType, const GLvoid *coords);
        public unsafe static void PathSubCoordsNV(GLuint path, GLsizei coordStart, GLsizei numCoords, GLenum coordType, IntPtr coords)
        {
            if (glPathSubCoordsNV != null)
            {
                glPathSubCoordsNV(path, coordStart, numCoords, coordType, coords.ToPointer());
            }
        }

        // GLAPI void APIENTRY glPathStringNV (GLuint path, GLenum format, GLsizei length, const GLvoid *pathString);
        public unsafe static void PathStringNV(GLuint path, GLenum format, GLsizei length, IntPtr pathString)
        {
            if (glPathStringNV != null)
            {
                glPathStringNV(path, format, length, pathString.ToPointer());
            }
        }

        // GLAPI void APIENTRY glPathGlyphsNV (GLuint firstPathName, GLenum fontTarget, const GLvoid *fontName, GLbitfield fontStyle, GLsizei numGlyphs, GLenum type, const GLvoid *charcodes, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale);
        public unsafe static void PathGlyphsNV(GLuint firstPathName, GLenum fontTarget, IntPtr fontName, GLbitfield fontStyle, GLsizei numGlyphs, GLenum type, IntPtr charcodes, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale)
        {
            if (glPathGlyphsNV != null)
            {
                glPathGlyphsNV(firstPathName, fontTarget, fontName.ToPointer(), fontStyle, numGlyphs, type, charcodes.ToPointer(), handleMissingGlyphs, pathParameterTemplate, emScale);
            }
        }

        // GLAPI void APIENTRY glPathGlyphRangeNV (GLuint firstPathName, GLenum fontTarget, const GLvoid *fontName, GLbitfield fontStyle, GLuint firstGlyph, GLsizei numGlyphs, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale);
        public unsafe static void PathGlyphRangeNV(GLuint firstPathName, GLenum fontTarget, IntPtr fontName, GLbitfield fontStyle, GLuint firstGlyph, GLsizei numGlyphs, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale)
        {
            if (glPathGlyphRangeNV != null)
            {
                glPathGlyphRangeNV(firstPathName, fontTarget, fontName.ToPointer(), fontStyle, firstGlyph, numGlyphs, handleMissingGlyphs, pathParameterTemplate, emScale);
            }
        }

        // GLAPI void APIENTRY glWeightPathsNV (GLuint resultPath, GLsizei numPaths, const GLuint *paths, const GLfloat *weights);
        public unsafe static void WeightPathsNV(GLuint resultPath, GLsizei numPaths, GLuint[] paths, GLfloat[] weights)
        {
            if (glWeightPathsNV != null)
            {
                fixed (GLuint* ptr_paths = paths)
                {
                    fixed (GLfloat* ptr_weights = weights)
                    {
                        glWeightPathsNV(resultPath, numPaths, ptr_paths, ptr_weights);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glCopyPathNV (GLuint resultPath, GLuint srcPath);
        public static void CopyPathNV(GLuint resultPath, GLuint srcPath)
        {
            if (glCopyPathNV != null)
            {
                glCopyPathNV(resultPath, srcPath);
            }
        }

        // GLAPI void APIENTRY glInterpolatePathsNV (GLuint resultPath, GLuint pathA, GLuint pathB, GLfloat weight);
        public static void InterpolatePathsNV(GLuint resultPath, GLuint pathA, GLuint pathB, GLfloat weight)
        {
            if (glInterpolatePathsNV != null)
            {
                glInterpolatePathsNV(resultPath, pathA, pathB, weight);
            }
        }

        // GLAPI void APIENTRY glTransformPathNV (GLuint resultPath, GLuint srcPath, GLenum transformType, const GLfloat *transformValues);
        public unsafe static void TransformPathNV(GLuint resultPath, GLuint srcPath, GLenum transformType, GLfloat[] transformValues)
        {
            if (glTransformPathNV != null)
            {
                fixed (GLfloat* ptr_transformValues = transformValues)
                {
                    glTransformPathNV(resultPath, srcPath, transformType, ptr_transformValues);
                }
            }
        }

        // GLAPI void APIENTRY glPathParameterivNV (GLuint path, GLenum pname, const GLint *value);
        public unsafe static void PathParameterivNV(GLuint path, GLenum pname, GLint[] value)
        {
            if (glPathParameterivNV != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glPathParameterivNV(path, pname, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glPathParameteriNV (GLuint path, GLenum pname, GLint value);
        public static void PathParameteriNV(GLuint path, GLenum pname, GLint value)
        {
            if (glPathParameteriNV != null)
            {
                glPathParameteriNV(path, pname, value);
            }
        }

        // GLAPI void APIENTRY glPathParameterfvNV (GLuint path, GLenum pname, const GLfloat *value);
        public unsafe static void PathParameterfvNV(GLuint path, GLenum pname, GLfloat[] value)
        {
            if (glPathParameterfvNV != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glPathParameterfvNV(path, pname, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glPathParameterfNV (GLuint path, GLenum pname, GLfloat value);
        public static void PathParameterfNV(GLuint path, GLenum pname, GLfloat value)
        {
            if (glPathParameterfNV != null)
            {
                glPathParameterfNV(path, pname, value);
            }
        }

        // GLAPI void APIENTRY glPathDashArrayNV (GLuint path, GLsizei dashCount, const GLfloat *dashArray);
        public unsafe static void PathDashArrayNV(GLuint path, GLsizei dashCount, GLfloat[] dashArray)
        {
            if (glPathDashArrayNV != null)
            {
                fixed (GLfloat* ptr_dashArray = dashArray)
                {
                    glPathDashArrayNV(path, dashCount, ptr_dashArray);
                }
            }
        }

        // GLAPI void APIENTRY glPathStencilFuncNV (GLenum func, GLint ref, GLuint mask);
        public static void PathStencilFuncNV(GLenum func, GLint reference, GLuint mask)
        {
            if (glPathStencilFuncNV != null)
            {
                glPathStencilFuncNV(func, reference, mask);
            }
        }

        // GLAPI void APIENTRY glPathStencilDepthOffsetNV (GLfloat factor, GLfloat units);
        public static void PathStencilDepthOffsetNV(GLfloat factor, GLfloat units)
        {
            if (glPathStencilDepthOffsetNV != null)
            {
                glPathStencilDepthOffsetNV(factor, units);
            }
        }

        // GLAPI void APIENTRY glStencilFillPathNV (GLuint path, GLenum fillMode, GLuint mask);
        public static void StencilFillPathNV(GLuint path, GLenum fillMode, GLuint mask)
        {
            if (glStencilFillPathNV != null)
            {
                glStencilFillPathNV(path, fillMode, mask);
            }
        }

        // GLAPI void APIENTRY glStencilStrokePathNV (GLuint path, GLint reference, GLuint mask);
        public static void StencilStrokePathNV(GLuint path, GLint reference, GLuint mask)
        {
            if (glStencilStrokePathNV != null)
            {
                glStencilStrokePathNV(path, reference, mask);
            }
        }

        // GLAPI void APIENTRY glStencilFillPathInstancedNV (GLsizei numPaths, GLenum pathNameType, const GLvoid *paths, GLuint pathBase, GLenum fillMode, GLuint mask, GLenum transformType, const GLfloat *transformValues);
        public unsafe static void StencilFillPathInstancedNV(GLsizei numPaths, GLenum pathNameType, IntPtr paths, GLuint pathBase, GLenum fillMode, GLuint mask, GLenum transformType, GLfloat[] transformValues)
        {
            if (glStencilFillPathInstancedNV != null)
            {
                fixed (GLfloat* ptr_transformValues = transformValues)
                {
                    glStencilFillPathInstancedNV(numPaths, pathNameType, paths.ToPointer(), pathBase, fillMode, mask, transformType, ptr_transformValues);
                }
            }
        }

        // GLAPI void APIENTRY glStencilStrokePathInstancedNV (GLsizei numPaths, GLenum pathNameType, const GLvoid *paths, GLuint pathBase, GLint reference, GLuint mask, GLenum transformType, const GLfloat *transformValues);
        public unsafe static void StencilStrokePathInstancedNV(GLsizei numPaths, GLenum pathNameType, IntPtr paths, GLuint pathBase, GLint reference, GLuint mask, GLenum transformType, GLfloat[] transformValues)
        {
            if (glStencilStrokePathInstancedNV != null)
            {
                fixed (GLfloat* ptr_transformValues = transformValues)
                {
                    glStencilStrokePathInstancedNV(numPaths, pathNameType, paths.ToPointer(), pathBase, reference, mask, transformType, ptr_transformValues);
                }
            }
        }

        // GLAPI void APIENTRY glPathCoverDepthFuncNV (GLenum func);
        public static void PathCoverDepthFuncNV(GLenum func)
        {
            if (glPathCoverDepthFuncNV != null)
            {
                glPathCoverDepthFuncNV(func);
            }
        }

        // GLAPI void APIENTRY glPathColorGenNV (GLenum color, GLenum genMode, GLenum colorFormat, const GLfloat *coeffs);
        public unsafe static void PathColorGenNV(GLenum color, GLenum genMode, GLenum colorFormat, GLfloat[] coeffs)
        {
            if (glPathColorGenNV != null)
            {
                fixed (GLfloat* ptr_coeffs = coeffs)
                {
                    glPathColorGenNV(color, genMode, colorFormat, ptr_coeffs);
                }
            }
        }

        // GLAPI void APIENTRY glPathTexGenNV (GLenum texCoordSet, GLenum genMode, GLint components, const GLfloat *coeffs);
        public unsafe static void PathTexGenNV(GLenum texCoordSet, GLenum genMode, GLint components, GLfloat[] coeffs)
        {
            if (glPathTexGenNV != null)
            {
                fixed (GLfloat* ptr_coeffs = coeffs)
                {
                    glPathTexGenNV(texCoordSet, genMode, components, ptr_coeffs);
                }
            }
        }

        // GLAPI void APIENTRY glPathFogGenNV (GLenum genMode);
        public static void PathFogGenNV(GLenum genMode)
        {
            if (glPathFogGenNV != null)
            {
                glPathFogGenNV(genMode);
            }
        }

        // GLAPI void APIENTRY glCoverFillPathNV (GLuint path, GLenum coverMode);
        public static void CoverFillPathNV(GLuint path, GLenum coverMode)
        {
            if (glCoverFillPathNV != null)
            {
                glCoverFillPathNV(path, coverMode);
            }
        }

        // GLAPI void APIENTRY glCoverStrokePathNV (GLuint path, GLenum coverMode);
        public static void CoverStrokePathNV(GLuint path, GLenum coverMode)
        {
            if (glCoverStrokePathNV != null)
            {
                glCoverStrokePathNV(path, coverMode);
            }
        }

        // GLAPI void APIENTRY glCoverFillPathInstancedNV (GLsizei numPaths, GLenum pathNameType, const GLvoid *paths, GLuint pathBase, GLenum coverMode, GLenum transformType, const GLfloat *transformValues);
        public unsafe static void CoverFillPathInstancedNV(GLsizei numPaths, GLenum pathNameType, IntPtr paths, GLuint pathBase, GLenum coverMode, GLenum transformType, GLfloat[] transformValues)
        {
            if (glCoverFillPathInstancedNV != null)
            {
                fixed (GLfloat* ptr_transformValues = transformValues)
                {
                    glCoverFillPathInstancedNV(numPaths, pathNameType, paths.ToPointer(), pathBase, coverMode, transformType, ptr_transformValues);
                }
            }
        }

        // GLAPI void APIENTRY glCoverStrokePathInstancedNV (GLsizei numPaths, GLenum pathNameType, const GLvoid *paths, GLuint pathBase, GLenum coverMode, GLenum transformType, const GLfloat *transformValues);
        public unsafe static void CoverStrokePathInstancedNV(GLsizei numPaths, GLenum pathNameType, IntPtr paths, GLuint pathBase, GLenum coverMode, GLenum transformType, GLfloat[] transformValues)
        {
            if (glCoverStrokePathInstancedNV != null)
            {
                fixed (GLfloat* ptr_transformValues = transformValues)
                {
                    glCoverStrokePathInstancedNV(numPaths, pathNameType, paths.ToPointer(), pathBase, coverMode, transformType, ptr_transformValues);
                }
            }
        }

        // GLAPI void APIENTRY glGetPathParameterivNV (GLuint path, GLenum pname, GLint *value);
        public unsafe static void GetPathParameterivNV(GLuint path, GLenum pname, GLint[] value)
        {
            if (glGetPathParameterivNV != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glGetPathParameterivNV(path, pname, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glGetPathParameterfvNV (GLuint path, GLenum pname, GLfloat *value);
        public unsafe static void GetPathParameterfvNV(GLuint path, GLenum pname, GLfloat[] value)
        {
            if (glGetPathParameterfvNV != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glGetPathParameterfvNV(path, pname, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glGetPathCommandsNV (GLuint path, GLubyte *commands);
        public unsafe static void GetPathCommandsNV(GLuint path, GLubyte[] commands)
        {
            if (glGetPathCommandsNV != null)
            {
                fixed (GLubyte* ptr_commands = commands)
                {
                    glGetPathCommandsNV(path, ptr_commands);
                }
            }
        }

        // GLAPI void APIENTRY glGetPathCoordsNV (GLuint path, GLfloat *coords);
        public unsafe static void GetPathCoordsNV(GLuint path, GLfloat[] coords)
        {
            if (glGetPathCoordsNV != null)
            {
                fixed (GLfloat* ptr_coords = coords)
                {
                    glGetPathCoordsNV(path, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glGetPathDashArrayNV (GLuint path, GLfloat *dashArray);
        public unsafe static void GetPathDashArrayNV(GLuint path, GLfloat[] dashArray)
        {
            if (glGetPathDashArrayNV != null)
            {
                fixed (GLfloat* ptr_dashArray = dashArray)
                {
                    glGetPathDashArrayNV(path, ptr_dashArray);
                }
            }
        }

        // GLAPI void APIENTRY glGetPathMetricsNV (GLbitfield metricQueryMask, GLsizei numPaths, GLenum pathNameType, const GLvoid *paths, GLuint pathBase, GLsizei stride, GLfloat *metrics);
        public unsafe static void GetPathMetricsNV(GLbitfield metricQueryMask, GLsizei numPaths, GLenum pathNameType, IntPtr paths, GLuint pathBase, GLsizei stride, GLfloat[] metrics)
        {
            if (glGetPathMetricsNV != null)
            {
                fixed (GLfloat* ptr_metrics = metrics)
                {
                    glGetPathMetricsNV(metricQueryMask, numPaths, pathNameType, paths.ToPointer(), pathBase, stride, ptr_metrics);
                }
            }
        }

        // GLAPI void APIENTRY glGetPathMetricRangeNV (GLbitfield metricQueryMask, GLuint firstPathName, GLsizei numPaths, GLsizei stride, GLfloat *metrics);
        public unsafe static void GetPathMetricRangeNV(GLbitfield metricQueryMask, GLuint firstPathName, GLsizei numPaths, GLsizei stride, GLfloat[] metrics)
        {
            if (glGetPathMetricRangeNV != null)
            {
                fixed (GLfloat* ptr_metrics = metrics)
                {
                    glGetPathMetricRangeNV(metricQueryMask, firstPathName, numPaths, stride, ptr_metrics);
                }
            }
        }

        // GLAPI void APIENTRY glGetPathSpacingNV (GLenum pathListMode, GLsizei numPaths, GLenum pathNameType, const GLvoid *paths, GLuint pathBase, GLfloat advanceScale, GLfloat kerningScale, GLenum transformType, GLfloat *returnedSpacing);
        public unsafe static void GetPathSpacingNV(GLenum pathListMode, GLsizei numPaths, GLenum pathNameType, IntPtr paths, GLuint pathBase, GLfloat advanceScale, GLfloat kerningScale, GLenum transformType, GLfloat[] returnedSpacing)
        {
            if (glGetPathSpacingNV != null)
            {
                fixed (GLfloat* ptr_returnedSpacing = returnedSpacing)
                {
                    glGetPathSpacingNV(pathListMode, numPaths, pathNameType, paths.ToPointer(), pathBase, advanceScale, kerningScale, transformType, ptr_returnedSpacing);
                }
            }
        }

        // GLAPI void APIENTRY glGetPathColorGenivNV (GLenum color, GLenum pname, GLint *value);
        public unsafe static void GetPathColorGenivNV(GLenum color, GLenum pname, GLint[] value)
        {
            if (glGetPathColorGenivNV != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glGetPathColorGenivNV(color, pname, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glGetPathColorGenfvNV (GLenum color, GLenum pname, GLfloat *value);
        public unsafe static void GetPathColorGenfvNV(GLenum color, GLenum pname, GLfloat[] value)
        {
            if (glGetPathColorGenfvNV != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glGetPathColorGenfvNV(color, pname, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glGetPathTexGenivNV (GLenum texCoordSet, GLenum pname, GLint *value);
        public unsafe static void GetPathTexGenivNV(GLenum texCoordSet, GLenum pname, GLint[] value)
        {
            if (glGetPathTexGenivNV != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glGetPathTexGenivNV(texCoordSet, pname, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glGetPathTexGenfvNV (GLenum texCoordSet, GLenum pname, GLfloat *value);
        public unsafe static void GetPathTexGenfvNV(GLenum texCoordSet, GLenum pname, GLfloat[] value)
        {
            if (glGetPathTexGenfvNV != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glGetPathTexGenfvNV(texCoordSet, pname, ptr_value);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsPointInFillPathNV (GLuint path, GLuint mask, GLfloat x, GLfloat y);
        public static GLboolean IsPointInFillPathNV(GLuint path, GLuint mask, GLfloat x, GLfloat y)
        {
            if (glIsPointInFillPathNV != null)
            {
                return glIsPointInFillPathNV(path, mask, x, y);
            }
            else
            {
                return false;
            }
        }

        // GLAPI GLboolean APIENTRY glIsPointInStrokePathNV (GLuint path, GLfloat x, GLfloat y);
        public static GLboolean IsPointInStrokePathNV(GLuint path, GLfloat x, GLfloat y)
        {
            if (glIsPointInStrokePathNV != null)
            {
                return glIsPointInStrokePathNV(path, x, y);
            }
            else
            {
                return false;
            }
        }

        // GLAPI GLfloat APIENTRY glGetPathLengthNV (GLuint path, GLsizei startSegment, GLsizei numSegments);
        public static GLfloat GetPathLengthNV(GLuint path, GLsizei startSegment, GLsizei numSegments)
        {
            if (glGetPathLengthNV != null)
            {
                return glGetPathLengthNV(path, startSegment, numSegments);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLboolean APIENTRY glPointAlongPathNV (GLuint path, GLsizei startSegment, GLsizei numSegments, GLfloat distance, GLfloat *x, GLfloat *y, GLfloat *tangentX, GLfloat *tangentY);
        public unsafe static void PointAlongPathNV(GLuint path, GLsizei startSegment, GLsizei numSegments, GLfloat distance, GLfloat[] x, GLfloat[] y, GLfloat[] tangentX, GLfloat[] tangentY)
        {
            if (glPointAlongPathNV != null)
            {
                fixed (GLfloat* ptr_x = x)
                {
                    fixed (GLfloat* ptr_y = y)
                    {
                        fixed (GLfloat* ptr_tangentX = tangentX)
                        {
                            fixed (GLfloat* ptr_tangentY = tangentY)
                            {
                                glPointAlongPathNV(path, startSegment, numSegments, distance, ptr_x, ptr_y, ptr_tangentX, ptr_tangentY);
                            }
                        }
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_bindless_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLuint64 APIENTRY glGetTextureHandleNV (GLuint texture);
        public static GLuint64 GetTextureHandleNV(GLuint texture)
        {
            if (glGetTextureHandleNV != null)
            {
                return glGetTextureHandleNV(texture);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLuint64 APIENTRY glGetTextureSamplerHandleNV (GLuint texture, GLuint sampler);
        public static GLuint64 GetTextureSamplerHandleNV(GLuint texture, GLuint sampler)
        {
            if (glGetTextureSamplerHandleNV != null)
            {
                return glGetTextureSamplerHandleNV(texture, sampler);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glMakeTextureHandleResidentNV (GLuint64 handle);
        public static void MakeTextureHandleResidentNV(GLuint64 handle)
        {
            if (glMakeTextureHandleResidentNV != null)
            {
                glMakeTextureHandleResidentNV(handle);
            }
        }

        // GLAPI void APIENTRY glMakeTextureHandleNonResidentNV (GLuint64 handle);
        public static void MakeTextureHandleNonResidentNV(GLuint64 handle)
        {
            if (glMakeTextureHandleNonResidentNV != null)
            {
                glMakeTextureHandleNonResidentNV(handle);
            }
        }

        // GLAPI GLuint64 APIENTRY glGetImageHandleNV (GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format);
        public static GLuint64 GetImageHandleNV(GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format)
        {
            if (glGetImageHandleNV != null)
            {
                return glGetImageHandleNV(texture, level, layered, layer, format);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glMakeImageHandleResidentNV (GLuint64 handle, GLenum access);
        public static void MakeImageHandleResidentNV(GLuint64 handle, GLenum access)
        {
            if (glMakeImageHandleResidentNV != null)
            {
                glMakeImageHandleResidentNV(handle, access);
            }
        }

        // GLAPI void APIENTRY glMakeImageHandleNonResidentNV (GLuint64 handle);
        public static void MakeImageHandleNonResidentNV(GLuint64 handle)
        {
            if (glMakeImageHandleNonResidentNV != null)
            {
                glMakeImageHandleNonResidentNV(handle);
            }
        }

        // GLAPI void APIENTRY glUniformHandleui64NV (GLint location, GLuint64 value);
        public static void UniformHandleui64NV(GLint location, GLuint64 value)
        {
            if (glUniformHandleui64NV != null)
            {
                glUniformHandleui64NV(location, value);
            }
        }

        // GLAPI void APIENTRY glUniformHandleui64vNV (GLint location, GLsizei count, const GLuint64 *value);
        public unsafe static void UniformHandleui64vNV(GLint location, GLsizei count, GLuint64[] value)
        {
            if (glUniformHandleui64vNV != null)
            {
                fixed (GLuint64* ptr_value = value)
                {
                    glUniformHandleui64vNV(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformHandleui64NV (GLuint program, GLint location, GLuint64 value);
        public static void ProgramUniformHandleui64NV(GLuint program, GLint location, GLuint64 value)
        {
            if (glProgramUniformHandleui64NV != null)
            {
                glProgramUniformHandleui64NV(program, location, value);
            }
        }

        // GLAPI void APIENTRY glProgramUniformHandleui64vNV (GLuint program, GLint location, GLsizei count, const GLuint64 *values);
        public unsafe static void ProgramUniformHandleui64vNV(GLuint program, GLint location, GLsizei count, GLuint64[] values)
        {
            if (glProgramUniformHandleui64vNV != null)
            {
                fixed (GLuint64* ptr_values = values)
                {
                    glProgramUniformHandleui64vNV(program, location, count, ptr_values);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsTextureHandleResidentNV (GLuint64 handle);
        public static GLboolean IsTextureHandleResidentNV(GLuint64 handle)
        {
            if (glIsTextureHandleResidentNV != null)
            {
                return glIsTextureHandleResidentNV(handle);
            }
            else
            {
                return false;
            }
        }

        // GLAPI GLboolean APIENTRY glIsImageHandleResidentNV (GLuint64 handle);
        public static GLboolean IsImageHandleResidentNV(GLuint64 handle)
        {
            if (glIsImageHandleResidentNV != null)
            {
                return glIsImageHandleResidentNV(handle);
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_atomic_float (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_gpu_program5_mem_extended (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_atomic_counters (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_storage_buffer_object (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_bindless_multi_draw_indirect
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMultiDrawArraysIndirectBindlessNV (GLenum mode, const void *indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount);
        public unsafe static void MultiDrawArraysIndirectBindlessNV(GLenum mode, IntPtr indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount)
        {
            if (glMultiDrawArraysIndirectBindlessNV != null)
            {
                glMultiDrawArraysIndirectBindlessNV(mode, indirect.ToPointer(), drawCount, stride, vertexBufferCount);
            }
        }

        // GLAPI void APIENTRY glMultiDrawElementsIndirectBindlessNV (GLenum mode, GLenum type, const void *indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount);
        public unsafe static void MultiDrawElementsIndirectBindlessNV(GLenum mode, GLenum type, IntPtr indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount)
        {
            if (glMultiDrawElementsIndirectBindlessNV != null)
            {
                glMultiDrawElementsIndirectBindlessNV(mode, type, indirect.ToPointer(), drawCount, stride, vertexBufferCount);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_blend_equation_advanced
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendParameteriNV (GLenum pname, GLint value);
        public static void BlendParameteriNV(GLenum pname, GLint value)
        {
            if (glBlendParameteriNV != null)
            {
                glBlendParameteriNV(pname, value);
            }
        }

        // GLAPI void APIENTRY glBlendBarrierNV (void);
        public static void BlendBarrierNV()
        {
            if (glBlendBarrierNV != null)
            {
                glBlendBarrierNV();
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_blend_equation_advanced_coherent (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_compute_program5 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_deep_texture3D (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_draw_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDrawTextureNV (GLuint texture, GLuint sampler, GLfloat x0, GLfloat y0, GLfloat x1, GLfloat y1, GLfloat z, GLfloat s0, GLfloat t0, GLfloat s1, GLfloat t1);
        public static void DrawTextureNV(GLuint texture, GLuint sampler, GLfloat x0, GLfloat y0, GLfloat x1, GLfloat y1, GLfloat z, GLfloat s0, GLfloat t0, GLfloat s1, GLfloat t1)
        {
            if (glDrawTextureNV != null)
            {
                glDrawTextureNV(texture, sampler, x0, y0, x1, y1, z, s0, t0, s1, t1);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_gpu_program_fp64 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_NVX_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_NVX_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_NVX_gpu_memory_info (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NVX_conditional_render
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginConditionalRenderNVX (GLuint id);
        public static void BeginConditionalRenderNVX(GLuint id)
        {
            if (glBeginConditionalRenderNVX != null)
            {
                glBeginConditionalRenderNVX(id);
            }
        }

        // GLAPI void APIENTRY glEndConditionalRenderNVX (void);
        public static void EndConditionalRenderNVX()
        {
            if (glEndConditionalRenderNVX != null)
            {
                glEndConditionalRenderNVX();
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_OES_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_OES_compressed_paletted_texture (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_read_format (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_query_matrix
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLbitfield APIENTRY glQueryMatrixxOES (GLfixed *mantissa, GLint *exponent);
        public unsafe static GLbitfield QueryMatrixxOES(GLfixed[] mantissa, GLint[] exponent)
        {
            if (glQueryMatrixxOES != null)
            {
                fixed (GLfixed* ptr_mantissa = mantissa)
                {
                    fixed (GLint* ptr_exponent = exponent)
                    {
                        return glQueryMatrixxOES(ptr_mantissa, ptr_exponent);
                    }
                }
            }
            else
            {
                return 0;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_single_precision
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glClearDepthfOES (GLclampf depth);
        public static void ClearDepthfOES(GLclampf depth)
        {
            if (glClearDepthfOES != null)
            {
                glClearDepthfOES(depth);
            }
        }

        // GLAPI void APIENTRY glClipPlanefOES (GLenum plane, const GLfloat *equation);
        public unsafe static void ClipPlanefOES(GLenum plane, GLfloat[] equation)
        {
            if (glClipPlanefOES != null)
            {
                fixed (GLfloat* ptr_equation = equation)
                {
                    glClipPlanefOES(plane, ptr_equation);
                }
            }
        }

        // GLAPI void APIENTRY glDepthRangefOES (GLclampf n, GLclampf f);
        public static void DepthRangefOES(GLclampf n, GLclampf f)
        {
            if (glDepthRangefOES != null)
            {
                glDepthRangefOES(n, f);
            }
        }

        // GLAPI void APIENTRY glFrustumfOES (GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);
        public static void FrustumfOES(GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f)
        {
            if (glFrustumfOES != null)
            {
                glFrustumfOES(l, r, b, t, n, f);
            }
        }

        // GLAPI void APIENTRY glGetClipPlanefOES (GLenum plane, GLfloat *equation);
        public unsafe static void GetClipPlanefOES(GLenum plane, GLfloat[] equation)
        {
            if (glGetClipPlanefOES != null)
            {
                fixed (GLfloat* ptr_equation = equation)
                {
                    glGetClipPlanefOES(plane, ptr_equation);
                }
            }
        }

        // GLAPI void APIENTRY glOrthofOES (GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);
        public static void OrthofOES(GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f)
        {
            if (glOrthofOES != null)
            {
                glOrthofOES(l, r, b, t, n, f);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_byte_coordinates
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMultiTexCoord1bOES (GLenum texture, GLbyte s);
        public static void MultiTexCoord1bOES(GLenum texture, GLbyte s)
        {
            if (glMultiTexCoord1bOES != null)
            {
                glMultiTexCoord1bOES(texture, s);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord1bvOES (GLenum texture, const GLbyte *coords);
        public unsafe static void MultiTexCoord1bvOES(GLenum texture, GLbyte[] coords)
        {
            if (glMultiTexCoord1bvOES != null)
            {
                fixed (GLbyte* ptr_coords = coords)
                {
                    glMultiTexCoord1bvOES(texture, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2bOES (GLenum texture, GLbyte s, GLbyte t);
        public static void MultiTexCoord2bOES(GLenum texture, GLbyte s, GLbyte t)
        {
            if (glMultiTexCoord2bOES != null)
            {
                glMultiTexCoord2bOES(texture, s, t);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2bvOES (GLenum texture, const GLbyte *coords);
        public unsafe static void MultiTexCoord2bvOES(GLenum texture, GLbyte[] coords)
        {
            if (glMultiTexCoord2bvOES != null)
            {
                fixed (GLbyte* ptr_coords = coords)
                {
                    glMultiTexCoord2bvOES(texture, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3bOES (GLenum texture, GLbyte s, GLbyte t, GLbyte r);
        public static void MultiTexCoord3bOES(GLenum texture, GLbyte s, GLbyte t, GLbyte r)
        {
            if (glMultiTexCoord3bOES != null)
            {
                glMultiTexCoord3bOES(texture, s, t, r);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3bvOES (GLenum texture, const GLbyte *coords);
        public unsafe static void MultiTexCoord3bvOES(GLenum texture, GLbyte[] coords)
        {
            if (glMultiTexCoord3bvOES != null)
            {
                fixed (GLbyte* ptr_coords = coords)
                {
                    glMultiTexCoord3bvOES(texture, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4bOES (GLenum texture, GLbyte s, GLbyte t, GLbyte r, GLbyte q);
        public static void MultiTexCoord4bOES(GLenum texture, GLbyte s, GLbyte t, GLbyte r, GLbyte q)
        {
            if (glMultiTexCoord4bOES != null)
            {
                glMultiTexCoord4bOES(texture, s, t, r, q);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4bvOES (GLenum texture, const GLbyte *coords);
        public unsafe static void MultiTexCoord4bvOES(GLenum texture, GLbyte[] coords)
        {
            if (glMultiTexCoord4bvOES != null)
            {
                fixed (GLbyte* ptr_coords = coords)
                {
                    glMultiTexCoord4bvOES(texture, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord1bOES (GLbyte s);
        public static void TexCoord1bOES(GLbyte s)
        {
            if (glTexCoord1bOES != null)
            {
                glTexCoord1bOES(s);
            }
        }

        // GLAPI void APIENTRY glTexCoord1bvOES (const GLbyte *coords);
        public unsafe static void TexCoord1bvOES(GLbyte[] coords)
        {
            if (glTexCoord1bvOES != null)
            {
                fixed (GLbyte* ptr_coords = coords)
                {
                    glTexCoord1bvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord2bOES (GLbyte s, GLbyte t);
        public static void TexCoord2bOES(GLbyte s, GLbyte t)
        {
            if (glTexCoord2bOES != null)
            {
                glTexCoord2bOES(s, t);
            }
        }

        // GLAPI void APIENTRY glTexCoord2bvOES (const GLbyte *coords);
        public unsafe static void TexCoord2bvOES(GLbyte[] coords)
        {
            if (glTexCoord2bvOES != null)
            {
                fixed (GLbyte* ptr_coords = coords)
                {
                    glTexCoord2bvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord3bOES (GLbyte s, GLbyte t, GLbyte r);
        public static void TexCoord3bOES(GLbyte s, GLbyte t, GLbyte r)
        {
            if (glTexCoord3bOES != null)
            {
                glTexCoord3bOES(s, t, r);
            }
        }

        // GLAPI void APIENTRY glTexCoord3bvOES (const GLbyte *coords);
        public unsafe static void TexCoord3bvOES(GLbyte[] coords)
        {
            if (glTexCoord3bvOES != null)
            {
                fixed (GLbyte* ptr_coords = coords)
                {
                    glTexCoord3bvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord4bOES (GLbyte s, GLbyte t, GLbyte r, GLbyte q);
        public static void TexCoord4bOES(GLbyte s, GLbyte t, GLbyte r, GLbyte q)
        {
            if (glTexCoord4bOES != null)
            {
                glTexCoord4bOES(s, t, r, q);
            }
        }

        // GLAPI void APIENTRY glTexCoord4bvOES (const GLbyte *coords);
        public unsafe static void TexCoord4bvOES(GLbyte[] coords)
        {
            if (glTexCoord4bvOES != null)
            {
                fixed (GLbyte* ptr_coords = coords)
                {
                    glTexCoord4bvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertex2bOES (GLbyte x);
        public static void Vertex2bOES(GLbyte x)
        {
            if (glVertex2bOES != null)
            {
                glVertex2bOES(x);
            }
        }

        // GLAPI void APIENTRY glVertex2bvOES (const GLbyte *coords);
        public unsafe static void Vertex2bvOES(GLbyte[] coords)
        {
            if (glVertex2bvOES != null)
            {
                fixed (GLbyte* ptr_coords = coords)
                {
                    glVertex2bvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertex3bOES (GLbyte x, GLbyte y);
        public static void Vertex3bOES(GLbyte x, GLbyte y)
        {
            if (glVertex3bOES != null)
            {
                glVertex3bOES(x, y);
            }
        }

        // GLAPI void APIENTRY glVertex3bvOES (const GLbyte *coords);
        public unsafe static void Vertex3bvOES(GLbyte[] coords)
        {
            if (glVertex3bvOES != null)
            {
                fixed (GLbyte* ptr_coords = coords)
                {
                    glVertex3bvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertex4bOES (GLbyte x, GLbyte y, GLbyte z);
        public static void Vertex4bOES(GLbyte x, GLbyte y, GLbyte z)
        {
            if (glVertex4bOES != null)
            {
                glVertex4bOES(x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertex4bvOES (const GLbyte *coords);
        public unsafe static void Vertex4bvOES(GLbyte[] coords)
        {
            if (glVertex4bvOES != null)
            {
                fixed (GLbyte* ptr_coords = coords)
                {
                    glVertex4bvOES(ptr_coords);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_fixed_point
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glAlphaFuncxOES (GLenum func, GLfixed ref);
        public static void AlphaFuncxOES(GLenum func, GLfixed reference)
        {
            if (glAlphaFuncxOES != null)
            {
                glAlphaFuncxOES(func, reference);
            }
        }

        // GLAPI void APIENTRY glClearColorxOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
        public static void ClearColorxOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)
        {
            if (glClearColorxOES != null)
            {
                glClearColorxOES(red, green, blue, alpha);
            }
        }

        // GLAPI void APIENTRY glClearDepthxOES (GLfixed depth);
        public static void ClearDepthxOES(GLfixed depth)
        {
            if (glClearDepthxOES != null)
            {
                glClearDepthxOES(depth);
            }
        }

        // GLAPI void APIENTRY glClipPlanexOES (GLenum plane, const GLfixed *equation);
        public unsafe static void ClipPlanexOES(GLenum plane, GLfixed[] equation)
        {
            if (glClipPlanexOES != null)
            {
                fixed (GLfixed* ptr_equation = equation)
                {
                    glClipPlanexOES(plane, ptr_equation);
                }
            }
        }

        // GLAPI void APIENTRY glColor4xOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
        public static void Color4xOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)
        {
            if (glColor4xOES != null)
            {
                glColor4xOES(red, green, blue, alpha);
            }
        }

        // GLAPI void APIENTRY glDepthRangexOES (GLfixed n, GLfixed f);
        public static void DepthRangexOES(GLfixed n, GLfixed f)
        {
            if (glDepthRangexOES != null)
            {
                glDepthRangexOES(n, f);
            }
        }

        // GLAPI void APIENTRY glFogxOES (GLenum pname, GLfixed param);
        public static void FogxOES(GLenum pname, GLfixed param)
        {
            if (glFogxOES != null)
            {
                glFogxOES(pname, param);
            }
        }

        // GLAPI void APIENTRY glFogxvOES (GLenum pname, const GLfixed *param);
        public unsafe static void FogxvOES(GLenum pname, GLfixed[] param)
        {
            if (glFogxvOES != null)
            {
                fixed (GLfixed* ptr_param = param)
                {
                    glFogxvOES(pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glFrustumxOES (GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);
        public static void FrustumxOES(GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f)
        {
            if (glFrustumxOES != null)
            {
                glFrustumxOES(l, r, b, t, n, f);
            }
        }

        // GLAPI void APIENTRY glGetClipPlanexOES (GLenum plane, GLfixed *equation);
        public unsafe static void GetClipPlanexOES(GLenum plane, GLfixed[] equation)
        {
            if (glGetClipPlanexOES != null)
            {
                fixed (GLfixed* ptr_equation = equation)
                {
                    glGetClipPlanexOES(plane, ptr_equation);
                }
            }
        }

        // GLAPI void APIENTRY glGetFixedvOES (GLenum pname, GLfixed *params);
        public unsafe static void GetFixedvOES(GLenum pname, GLfixed[] parameters)
        {
            if (glGetFixedvOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glGetFixedvOES(pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTexEnvxvOES (GLenum target, GLenum pname, GLfixed *params);
        public unsafe static void GetTexEnvxvOES(GLenum target, GLenum pname, GLfixed[] parameters)
        {
            if (glGetTexEnvxvOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glGetTexEnvxvOES(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTexParameterxvOES (GLenum target, GLenum pname, GLfixed *params);
        public unsafe static void GetTexParameterxvOES(GLenum target, GLenum pname, GLfixed[] parameters)
        {
            if (glGetTexParameterxvOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glGetTexParameterxvOES(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glLightModelxOES (GLenum pname, GLfixed param);
        public static void LightModelxOES(GLenum pname, GLfixed param)
        {
            if (glLightModelxOES != null)
            {
                glLightModelxOES(pname, param);
            }
        }

        // GLAPI void APIENTRY glLightModelxvOES (GLenum pname, const GLfixed *param);
        public unsafe static void LightModelxvOES(GLenum pname, GLfixed[] param)
        {
            if (glLightModelxvOES != null)
            {
                fixed (GLfixed* ptr_param = param)
                {
                    glLightModelxvOES(pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glLightxOES (GLenum light, GLenum pname, GLfixed param);
        public static void LightxOES(GLenum light, GLenum pname, GLfixed param)
        {
            if (glLightxOES != null)
            {
                glLightxOES(light, pname, param);
            }
        }

        // GLAPI void APIENTRY glLightxvOES (GLenum light, GLenum pname, const GLfixed *params);
        public unsafe static void LightxvOES(GLenum light, GLenum pname, GLfixed[] parameters)
        {
            if (glLightxvOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glLightxvOES(light, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glLineWidthxOES (GLfixed width);
        public static void LineWidthxOES(GLfixed width)
        {
            if (glLineWidthxOES != null)
            {
                glLineWidthxOES(width);
            }
        }

        // GLAPI void APIENTRY glLoadMatrixxOES (const GLfixed *m);
        public unsafe static void LoadMatrixxOES(GLfixed[] m)
        {
            if (glLoadMatrixxOES != null)
            {
                fixed (GLfixed* ptr_m = m)
                {
                    glLoadMatrixxOES(ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glMaterialxOES (GLenum face, GLenum pname, GLfixed param);
        public static void MaterialxOES(GLenum face, GLenum pname, GLfixed param)
        {
            if (glMaterialxOES != null)
            {
                glMaterialxOES(face, pname, param);
            }
        }

        // GLAPI void APIENTRY glMaterialxvOES (GLenum face, GLenum pname, const GLfixed *param);
        public unsafe static void MaterialxvOES(GLenum face, GLenum pname, GLfixed[] param)
        {
            if (glMaterialxvOES != null)
            {
                fixed (GLfixed* ptr_param = param)
                {
                    glMaterialxvOES(face, pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glMultMatrixxOES (const GLfixed *m);
        public unsafe static void MultMatrixxOES(GLfixed[] m)
        {
            if (glMultMatrixxOES != null)
            {
                fixed (GLfixed* ptr_m = m)
                {
                    glMultMatrixxOES(ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4xOES (GLenum texture, GLfixed s, GLfixed t, GLfixed r, GLfixed q);
        public static void MultiTexCoord4xOES(GLenum texture, GLfixed s, GLfixed t, GLfixed r, GLfixed q)
        {
            if (glMultiTexCoord4xOES != null)
            {
                glMultiTexCoord4xOES(texture, s, t, r, q);
            }
        }

        // GLAPI void APIENTRY glNormal3xOES (GLfixed nx, GLfixed ny, GLfixed nz);
        public static void Normal3xOES(GLfixed nx, GLfixed ny, GLfixed nz)
        {
            if (glNormal3xOES != null)
            {
                glNormal3xOES(nx, ny, nz);
            }
        }

        // GLAPI void APIENTRY glOrthoxOES (GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);
        public static void OrthoxOES(GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f)
        {
            if (glOrthoxOES != null)
            {
                glOrthoxOES(l, r, b, t, n, f);
            }
        }

        // GLAPI void APIENTRY glPointParameterxvOES (GLenum pname, const GLfixed *params);
        public unsafe static void PointParameterxvOES(GLenum pname, GLfixed[] parameters)
        {
            if (glPointParameterxvOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glPointParameterxvOES(pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glPointSizexOES (GLfixed size);
        public static void PointSizexOES(GLfixed size)
        {
            if (glPointSizexOES != null)
            {
                glPointSizexOES(size);
            }
        }

        // GLAPI void APIENTRY glPolygonOffsetxOES (GLfixed factor, GLfixed units);
        public static void PolygonOffsetxOES(GLfixed factor, GLfixed units)
        {
            if (glPolygonOffsetxOES != null)
            {
                glPolygonOffsetxOES(factor, units);
            }
        }

        // GLAPI void APIENTRY glRotatexOES (GLfixed angle, GLfixed x, GLfixed y, GLfixed z);
        public static void RotatexOES(GLfixed angle, GLfixed x, GLfixed y, GLfixed z)
        {
            if (glRotatexOES != null)
            {
                glRotatexOES(angle, x, y, z);
            }
        }

        // GLAPI void APIENTRY glSampleCoverageOES (GLfixed value, GLboolean invert);
        public static void SampleCoverageOES(GLfixed value, GLboolean invert)
        {
            if (glSampleCoverageOES != null)
            {
                glSampleCoverageOES(value, invert);
            }
        }

        // GLAPI void APIENTRY glScalexOES (GLfixed x, GLfixed y, GLfixed z);
        public static void ScalexOES(GLfixed x, GLfixed y, GLfixed z)
        {
            if (glScalexOES != null)
            {
                glScalexOES(x, y, z);
            }
        }

        // GLAPI void APIENTRY glTexEnvxOES (GLenum target, GLenum pname, GLfixed param);
        public static void TexEnvxOES(GLenum target, GLenum pname, GLfixed param)
        {
            if (glTexEnvxOES != null)
            {
                glTexEnvxOES(target, pname, param);
            }
        }

        // GLAPI void APIENTRY glTexEnvxvOES (GLenum target, GLenum pname, const GLfixed *params);
        public unsafe static void TexEnvxvOES(GLenum target, GLenum pname, GLfixed[] parameters)
        {
            if (glTexEnvxvOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glTexEnvxvOES(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glTexParameterxOES (GLenum target, GLenum pname, GLfixed param);
        public static void TexParameterxOES(GLenum target, GLenum pname, GLfixed param)
        {
            if (glTexParameterxOES != null)
            {
                glTexParameterxOES(target, pname, param);
            }
        }

        // GLAPI void APIENTRY glTexParameterxvOES (GLenum target, GLenum pname, const GLfixed *params);
        public unsafe static void TexParameterxvOES(GLenum target, GLenum pname, GLfixed[] parameters)
        {
            if (glTexParameterxvOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glTexParameterxvOES(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glTranslatexOES (GLfixed x, GLfixed y, GLfixed z);
        public static void TranslatexOES(GLfixed x, GLfixed y, GLfixed z)
        {
            if (glTranslatexOES != null)
            {
                glTranslatexOES(x, y, z);
            }
        }

        // GLAPI void APIENTRY glAccumxOES (GLenum op, GLfixed value);
        public static void AccumxOES(GLenum op, GLfixed value)
        {
            if (glAccumxOES != null)
            {
                glAccumxOES(op, value);
            }
        }

        // GLAPI void APIENTRY glBitmapxOES (GLsizei width, GLsizei height, GLfixed xorig, GLfixed yorig, GLfixed xmove, GLfixed ymove, const GLubyte *bitmap);
        public unsafe static void BitmapxOES(GLsizei width, GLsizei height, GLfixed xorig, GLfixed yorig, GLfixed xmove, GLfixed ymove, GLubyte[] bitmap)
        {
            if (glBitmapxOES != null)
            {
                fixed (GLubyte* ptr_bitmap = bitmap)
                {
                    glBitmapxOES(width, height, xorig, yorig, xmove, ymove, ptr_bitmap);
                }
            }
        }

        // GLAPI void APIENTRY glBlendColorxOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
        public static void BlendColorxOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)
        {
            if (glBlendColorxOES != null)
            {
                glBlendColorxOES(red, green, blue, alpha);
            }
        }

        // GLAPI void APIENTRY glClearAccumxOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
        public static void ClearAccumxOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha)
        {
            if (glClearAccumxOES != null)
            {
                glClearAccumxOES(red, green, blue, alpha);
            }
        }

        // GLAPI void APIENTRY glColor3xOES (GLfixed red, GLfixed green, GLfixed blue);
        public static void Color3xOES(GLfixed red, GLfixed green, GLfixed blue)
        {
            if (glColor3xOES != null)
            {
                glColor3xOES(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glColor3xvOES (const GLfixed *components);
        public unsafe static void Color3xvOES(GLfixed[] components)
        {
            if (glColor3xvOES != null)
            {
                fixed (GLfixed* ptr_components = components)
                {
                    glColor3xvOES(ptr_components);
                }
            }
        }

        // GLAPI void APIENTRY glColor4xvOES (const GLfixed *components);
        public unsafe static void Color4xvOES(GLfixed[] components)
        {
            if (glColor4xvOES != null)
            {
                fixed (GLfixed* ptr_components = components)
                {
                    glColor4xvOES(ptr_components);
                }
            }
        }

        // GLAPI void APIENTRY glConvolutionParameterxOES (GLenum target, GLenum pname, GLfixed param);
        public static void ConvolutionParameterxOES(GLenum target, GLenum pname, GLfixed param)
        {
            if (glConvolutionParameterxOES != null)
            {
                glConvolutionParameterxOES(target, pname, param);
            }
        }

        // GLAPI void APIENTRY glConvolutionParameterxvOES (GLenum target, GLenum pname, const GLfixed *params);
        public unsafe static void ConvolutionParameterxvOES(GLenum target, GLenum pname, GLfixed[] parameters)
        {
            if (glConvolutionParameterxvOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glConvolutionParameterxvOES(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glEvalCoord1xOES (GLfixed u);
        public static void EvalCoord1xOES(GLfixed u)
        {
            if (glEvalCoord1xOES != null)
            {
                glEvalCoord1xOES(u);
            }
        }

        // GLAPI void APIENTRY glEvalCoord1xvOES (const GLfixed *coords);
        public unsafe static void EvalCoord1xvOES(GLfixed[] coords)
        {
            if (glEvalCoord1xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glEvalCoord1xvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glEvalCoord2xOES (GLfixed u, GLfixed v);
        public static void EvalCoord2xOES(GLfixed u, GLfixed v)
        {
            if (glEvalCoord2xOES != null)
            {
                glEvalCoord2xOES(u, v);
            }
        }

        // GLAPI void APIENTRY glEvalCoord2xvOES (const GLfixed *coords);
        public unsafe static void EvalCoord2xvOES(GLfixed[] coords)
        {
            if (glEvalCoord2xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glEvalCoord2xvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glFeedbackBufferxOES (GLsizei n, GLenum type, const GLfixed *buffer);
        public unsafe static void FeedbackBufferxOES(GLsizei n, GLenum type, GLfixed[] buffer)
        {
            if (glFeedbackBufferxOES != null)
            {
                fixed (GLfixed* ptr_buffer = buffer)
                {
                    glFeedbackBufferxOES(n, type, ptr_buffer);
                }
            }
        }

        // GLAPI void APIENTRY glGetConvolutionParameterxvOES (GLenum target, GLenum pname, GLfixed *params);
        public unsafe static void GetConvolutionParameterxvOES(GLenum target, GLenum pname, GLfixed[] parameters)
        {
            if (glGetConvolutionParameterxvOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glGetConvolutionParameterxvOES(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetHistogramParameterxvOES (GLenum target, GLenum pname, GLfixed *params);
        public unsafe static void GetHistogramParameterxvOES(GLenum target, GLenum pname, GLfixed[] parameters)
        {
            if (glGetHistogramParameterxvOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glGetHistogramParameterxvOES(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetLightxOES (GLenum light, GLenum pname, GLfixed *params);
        public unsafe static void GetLightxOES(GLenum light, GLenum pname, GLfixed[] parameters)
        {
            if (glGetLightxOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glGetLightxOES(light, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetMapxvOES (GLenum target, GLenum query, GLfixed *v);
        public unsafe static void GetMapxvOES(GLenum target, GLenum query, GLfixed[] v)
        {
            if (glGetMapxvOES != null)
            {
                fixed (GLfixed* ptr_v = v)
                {
                    glGetMapxvOES(target, query, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glGetMaterialxOES (GLenum face, GLenum pname, GLfixed param);
        public static void GetMaterialxOES(GLenum face, GLenum pname, GLfixed param)
        {
            if (glGetMaterialxOES != null)
            {
                glGetMaterialxOES(face, pname, param);
            }
        }

        // GLAPI void APIENTRY glGetPixelMapxv (GLenum map, GLint size, GLfixed *values);
        public unsafe static void GetPixelMapxv(GLenum map, GLint size, GLfixed[] values)
        {
            if (glGetPixelMapxv != null)
            {
                fixed (GLfixed* ptr_values = values)
                {
                    glGetPixelMapxv(map, size, ptr_values);
                }
            }
        }

        // GLAPI void APIENTRY glGetTexGenxvOES (GLenum coord, GLenum pname, GLfixed *params);
        public unsafe static void GetTexGenxvOES(GLenum coord, GLenum pname, GLfixed[] parameters)
        {
            if (glGetTexGenxvOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glGetTexGenxvOES(coord, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTexLevelParameterxvOES (GLenum target, GLint level, GLenum pname, GLfixed *params);
        public unsafe static void GetTexLevelParameterxvOES(GLenum target, GLint level, GLenum pname, GLfixed[] parameters)
        {
            if (glGetTexLevelParameterxvOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glGetTexLevelParameterxvOES(target, level, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glIndexxOES (GLfixed component);
        public static void IndexxOES(GLfixed component)
        {
            if (glIndexxOES != null)
            {
                glIndexxOES(component);
            }
        }

        // GLAPI void APIENTRY glIndexxvOES (const GLfixed *component);
        public unsafe static void IndexxvOES(GLfixed[] component)
        {
            if (glIndexxvOES != null)
            {
                fixed (GLfixed* ptr_component = component)
                {
                    glIndexxvOES(ptr_component);
                }
            }
        }

        // GLAPI void APIENTRY glLoadTransposeMatrixxOES (const GLfixed *m);
        public unsafe static void LoadTransposeMatrixxOES(GLfixed[] m)
        {
            if (glLoadTransposeMatrixxOES != null)
            {
                fixed (GLfixed* ptr_m = m)
                {
                    glLoadTransposeMatrixxOES(ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glMap1xOES (GLenum target, GLfixed u1, GLfixed u2, GLint stride, GLint order, GLfixed points);
        public static void Map1xOES(GLenum target, GLfixed u1, GLfixed u2, GLint stride, GLint order, GLfixed points)
        {
            if (glMap1xOES != null)
            {
                glMap1xOES(target, u1, u2, stride, order, points);
            }
        }

        // GLAPI void APIENTRY glMap2xOES (GLenum target, GLfixed u1, GLfixed u2, GLint ustride, GLint uorder, GLfixed v1, GLfixed v2, GLint vstride, GLint vorder, GLfixed points);
        public static void Map2xOES(GLenum target, GLfixed u1, GLfixed u2, GLint ustride, GLint uorder, GLfixed v1, GLfixed v2, GLint vstride, GLint vorder, GLfixed points)
        {
            if (glMap2xOES != null)
            {
                glMap2xOES(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
            }
        }

        // GLAPI void APIENTRY glMapGrid1xOES (GLint n, GLfixed u1, GLfixed u2);
        public static void MapGrid1xOES(GLint n, GLfixed u1, GLfixed u2)
        {
            if (glMapGrid1xOES != null)
            {
                glMapGrid1xOES(n, u1, u2);
            }
        }

        // GLAPI void APIENTRY glMapGrid2xOES (GLint n, GLfixed u1, GLfixed u2, GLfixed v1, GLfixed v2);
        public static void MapGrid2xOES(GLint n, GLfixed u1, GLfixed u2, GLfixed v1, GLfixed v2)
        {
            if (glMapGrid2xOES != null)
            {
                glMapGrid2xOES(n, u1, u2, v1, v2);
            }
        }

        // GLAPI void APIENTRY glMultTransposeMatrixxOES (const GLfixed *m);
        public unsafe static void MultTransposeMatrixxOES(GLfixed[] m)
        {
            if (glMultTransposeMatrixxOES != null)
            {
                fixed (GLfixed* ptr_m = m)
                {
                    glMultTransposeMatrixxOES(ptr_m);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord1xOES (GLenum texture, GLfixed s);
        public static void MultiTexCoord1xOES(GLenum texture, GLfixed s)
        {
            if (glMultiTexCoord1xOES != null)
            {
                glMultiTexCoord1xOES(texture, s);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord1xvOES (GLenum texture, const GLfixed *coords);
        public unsafe static void MultiTexCoord1xvOES(GLenum texture, GLfixed[] coords)
        {
            if (glMultiTexCoord1xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glMultiTexCoord1xvOES(texture, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2xOES (GLenum texture, GLfixed s, GLfixed t);
        public static void MultiTexCoord2xOES(GLenum texture, GLfixed s, GLfixed t)
        {
            if (glMultiTexCoord2xOES != null)
            {
                glMultiTexCoord2xOES(texture, s, t);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord2xvOES (GLenum texture, const GLfixed *coords);
        public unsafe static void MultiTexCoord2xvOES(GLenum texture, GLfixed[] coords)
        {
            if (glMultiTexCoord2xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glMultiTexCoord2xvOES(texture, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3xOES (GLenum texture, GLfixed s, GLfixed t, GLfixed r);
        public static void MultiTexCoord3xOES(GLenum texture, GLfixed s, GLfixed t, GLfixed r)
        {
            if (glMultiTexCoord3xOES != null)
            {
                glMultiTexCoord3xOES(texture, s, t, r);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord3xvOES (GLenum texture, const GLfixed *coords);
        public unsafe static void MultiTexCoord3xvOES(GLenum texture, GLfixed[] coords)
        {
            if (glMultiTexCoord3xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glMultiTexCoord3xvOES(texture, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoord4xvOES (GLenum texture, const GLfixed *coords);
        public unsafe static void MultiTexCoord4xvOES(GLenum texture, GLfixed[] coords)
        {
            if (glMultiTexCoord4xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glMultiTexCoord4xvOES(texture, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glNormal3xvOES (const GLfixed *coords);
        public unsafe static void Normal3xvOES(GLfixed[] coords)
        {
            if (glNormal3xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glNormal3xvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glPassThroughxOES (GLfixed token);
        public static void PassThroughxOES(GLfixed token)
        {
            if (glPassThroughxOES != null)
            {
                glPassThroughxOES(token);
            }
        }

        // GLAPI void APIENTRY glPixelMapx (GLenum map, GLint size, const GLfixed *values);
        public unsafe static void PixelMapx(GLenum map, GLint size, GLfixed[] values)
        {
            if (glPixelMapx != null)
            {
                fixed (GLfixed* ptr_values = values)
                {
                    glPixelMapx(map, size, ptr_values);
                }
            }
        }

        // GLAPI void APIENTRY glPixelStorex (GLenum pname, GLfixed param);
        public static void PixelStorex(GLenum pname, GLfixed param)
        {
            if (glPixelStorex != null)
            {
                glPixelStorex(pname, param);
            }
        }

        // GLAPI void APIENTRY glPixelTransferxOES (GLenum pname, GLfixed param);
        public static void PixelTransferxOES(GLenum pname, GLfixed param)
        {
            if (glPixelTransferxOES != null)
            {
                glPixelTransferxOES(pname, param);
            }
        }

        // GLAPI void APIENTRY glPixelZoomxOES (GLfixed xfactor, GLfixed yfactor);
        public static void PixelZoomxOES(GLfixed xfactor, GLfixed yfactor)
        {
            if (glPixelZoomxOES != null)
            {
                glPixelZoomxOES(xfactor, yfactor);
            }
        }

        // GLAPI void APIENTRY glPrioritizeTexturesxOES (GLsizei n, const GLuint *textures, const GLfixed *priorities);
        public unsafe static void PrioritizeTexturesxOES(GLsizei n, GLuint[] textures, GLfixed[] priorities)
        {
            if (glPrioritizeTexturesxOES != null)
            {
                fixed (GLuint* ptr_textures = textures)
                {
                    fixed (GLfixed* ptr_priorities = priorities)
                    {
                        glPrioritizeTexturesxOES(n, ptr_textures, ptr_priorities);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glRasterPos2xOES (GLfixed x, GLfixed y);
        public static void RasterPos2xOES(GLfixed x, GLfixed y)
        {
            if (glRasterPos2xOES != null)
            {
                glRasterPos2xOES(x, y);
            }
        }

        // GLAPI void APIENTRY glRasterPos2xvOES (const GLfixed *coords);
        public unsafe static void RasterPos2xvOES(GLfixed[] coords)
        {
            if (glRasterPos2xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glRasterPos2xvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glRasterPos3xOES (GLfixed x, GLfixed y, GLfixed z);
        public static void RasterPos3xOES(GLfixed x, GLfixed y, GLfixed z)
        {
            if (glRasterPos3xOES != null)
            {
                glRasterPos3xOES(x, y, z);
            }
        }

        // GLAPI void APIENTRY glRasterPos3xvOES (const GLfixed *coords);
        public unsafe static void RasterPos3xvOES(GLfixed[] coords)
        {
            if (glRasterPos3xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glRasterPos3xvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glRasterPos4xOES (GLfixed x, GLfixed y, GLfixed z, GLfixed w);
        public static void RasterPos4xOES(GLfixed x, GLfixed y, GLfixed z, GLfixed w)
        {
            if (glRasterPos4xOES != null)
            {
                glRasterPos4xOES(x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glRasterPos4xvOES (const GLfixed *coords);
        public unsafe static void RasterPos4xvOES(GLfixed[] coords)
        {
            if (glRasterPos4xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glRasterPos4xvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glRectxOES (GLfixed x1, GLfixed y1, GLfixed x2, GLfixed y2);
        public static void RectxOES(GLfixed x1, GLfixed y1, GLfixed x2, GLfixed y2)
        {
            if (glRectxOES != null)
            {
                glRectxOES(x1, y1, x2, y2);
            }
        }

        // GLAPI void APIENTRY glRectxvOES (const GLfixed *v1, const GLfixed *v2);
        public unsafe static void RectxvOES(GLfixed[] v1, GLfixed[] v2)
        {
            if (glRectxvOES != null)
            {
                fixed (GLfixed* ptr_v1 = v1)
                {
                    fixed (GLfixed* ptr_v2 = v2)
                    {
                        glRectxvOES(ptr_v1, ptr_v2);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord1xOES (GLfixed s);
        public static void TexCoord1xOES(GLfixed s)
        {
            if (glTexCoord1xOES != null)
            {
                glTexCoord1xOES(s);
            }
        }

        // GLAPI void APIENTRY glTexCoord1xvOES (const GLfixed *coords);
        public unsafe static void TexCoord1xvOES(GLfixed[] coords)
        {
            if (glTexCoord1xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glTexCoord1xvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord2xOES (GLfixed s, GLfixed t);
        public static void TexCoord2xOES(GLfixed s, GLfixed t)
        {
            if (glTexCoord2xOES != null)
            {
                glTexCoord2xOES(s, t);
            }
        }

        // GLAPI void APIENTRY glTexCoord2xvOES (const GLfixed *coords);
        public unsafe static void TexCoord2xvOES(GLfixed[] coords)
        {
            if (glTexCoord2xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glTexCoord2xvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord3xOES (GLfixed s, GLfixed t, GLfixed r);
        public static void TexCoord3xOES(GLfixed s, GLfixed t, GLfixed r)
        {
            if (glTexCoord3xOES != null)
            {
                glTexCoord3xOES(s, t, r);
            }
        }

        // GLAPI void APIENTRY glTexCoord3xvOES (const GLfixed *coords);
        public unsafe static void TexCoord3xvOES(GLfixed[] coords)
        {
            if (glTexCoord3xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glTexCoord3xvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord4xOES (GLfixed s, GLfixed t, GLfixed r, GLfixed q);
        public static void TexCoord4xOES(GLfixed s, GLfixed t, GLfixed r, GLfixed q)
        {
            if (glTexCoord4xOES != null)
            {
                glTexCoord4xOES(s, t, r, q);
            }
        }

        // GLAPI void APIENTRY glTexCoord4xvOES (const GLfixed *coords);
        public unsafe static void TexCoord4xvOES(GLfixed[] coords)
        {
            if (glTexCoord4xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glTexCoord4xvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glTexGenxOES (GLenum coord, GLenum pname, GLfixed param);
        public static void TexGenxOES(GLenum coord, GLenum pname, GLfixed param)
        {
            if (glTexGenxOES != null)
            {
                glTexGenxOES(coord, pname, param);
            }
        }

        // GLAPI void APIENTRY glTexGenxvOES (GLenum coord, GLenum pname, const GLfixed *params);
        public unsafe static void TexGenxvOES(GLenum coord, GLenum pname, GLfixed[] parameters)
        {
            if (glTexGenxvOES != null)
            {
                fixed (GLfixed* ptr_parameters = parameters)
                {
                    glTexGenxvOES(coord, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glVertex2xOES (GLfixed x);
        public static void Vertex2xOES(GLfixed x)
        {
            if (glVertex2xOES != null)
            {
                glVertex2xOES(x);
            }
        }

        // GLAPI void APIENTRY glVertex2xvOES (const GLfixed *coords);
        public unsafe static void Vertex2xvOES(GLfixed[] coords)
        {
            if (glVertex2xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glVertex2xvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertex3xOES (GLfixed x, GLfixed y);
        public static void Vertex3xOES(GLfixed x, GLfixed y)
        {
            if (glVertex3xOES != null)
            {
                glVertex3xOES(x, y);
            }
        }

        // GLAPI void APIENTRY glVertex3xvOES (const GLfixed *coords);
        public unsafe static void Vertex3xvOES(GLfixed[] coords)
        {
            if (glVertex3xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glVertex3xvOES(ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glVertex4xOES (GLfixed x, GLfixed y, GLfixed z);
        public static void Vertex4xOES(GLfixed x, GLfixed y, GLfixed z)
        {
            if (glVertex4xOES != null)
            {
                glVertex4xOES(x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertex4xvOES (const GLfixed *coords);
        public unsafe static void Vertex4xvOES(GLfixed[] coords)
        {
            if (glVertex4xvOES != null)
            {
                fixed (GLfixed* ptr_coords = coords)
                {
                    glVertex4xvOES(ptr_coords);
                }
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_OML_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_OML_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_OML_interlace (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_OML_subsample (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_OML_resample (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_PGI_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_PGI_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_PGI_vertex_hints (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_PGI_misc_hints
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glHintPGI (GLenum target, GLint mode);
        public static void HintPGI(GLenum target, GLint mode)
        {
            if (glHintPGI != null)
            {
                glHintPGI(target, mode);
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_REND_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_REND_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_REND_screen_coordinates (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_S3_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_S3_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_S3_s3tc (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SGI_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_color_matrix (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_color_table
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glColorTableSGI (GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, const GLvoid *table);
        public unsafe static void ColorTableSGI(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, IntPtr table)
        {
            if (glColorTableSGI != null)
            {
                glColorTableSGI(target, internalformat, width, format, type, table.ToPointer());
            }
        }

        // GLAPI void APIENTRY glColorTableParameterfvSGI (GLenum target, GLenum pname, const GLfloat *params);
        public unsafe static void ColorTableParameterfvSGI(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glColorTableParameterfvSGI != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glColorTableParameterfvSGI(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glColorTableParameterivSGI (GLenum target, GLenum pname, const GLint *params);
        public unsafe static void ColorTableParameterivSGI(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glColorTableParameterivSGI != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glColorTableParameterivSGI(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glCopyColorTableSGI (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
        public static void CopyColorTableSGI(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width)
        {
            if (glCopyColorTableSGI != null)
            {
                glCopyColorTableSGI(target, internalformat, x, y, width);
            }
        }

        // GLAPI void APIENTRY glGetColorTableSGI (GLenum target, GLenum format, GLenum type, GLvoid *table);
        public unsafe static void GetColorTableSGI(GLenum target, GLenum format, GLenum type, IntPtr table)
        {
            if (glGetColorTableSGI != null)
            {
                glGetColorTableSGI(target, format, type, table.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetColorTableParameterfvSGI (GLenum target, GLenum pname, GLfloat *params);
        public unsafe static void GetColorTableParameterfvSGI(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetColorTableParameterfvSGI != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetColorTableParameterfvSGI(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetColorTableParameterivSGI (GLenum target, GLenum pname, GLint *params);
        public unsafe static void GetColorTableParameterivSGI(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetColorTableParameterivSGI != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetColorTableParameterivSGI(target, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_depth_pass_instrument (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_texture_color_table (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SGIS_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_filter4
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetTexFilterFuncSGIS (GLenum target, GLenum filter, GLfloat *weights);
        public unsafe static void GetTexFilterFuncSGIS(GLenum target, GLenum filter, GLfloat[] weights)
        {
            if (glGetTexFilterFuncSGIS != null)
            {
                fixed (GLfloat* ptr_weights = weights)
                {
                    glGetTexFilterFuncSGIS(target, filter, ptr_weights);
                }
            }
        }

        // GLAPI void APIENTRY glTexFilterFuncSGIS (GLenum target, GLenum filter, GLsizei n, const GLfloat *weights);
        public unsafe static void TexFilterFuncSGIS(GLenum target, GLenum filter, GLsizei n, GLfloat[] weights)
        {
            if (glTexFilterFuncSGIS != null)
            {
                fixed (GLfloat* ptr_weights = weights)
                {
                    glTexFilterFuncSGIS(target, filter, n, ptr_weights);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_pixel_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPixelTexGenParameteriSGIS (GLenum pname, GLint param);
        public static void PixelTexGenParameteriSGIS(GLenum pname, GLint param)
        {
            if (glPixelTexGenParameteriSGIS != null)
            {
                glPixelTexGenParameteriSGIS(pname, param);
            }
        }

        // GLAPI void APIENTRY glPixelTexGenParameterivSGIS (GLenum pname, const GLint *params);
        public unsafe static void PixelTexGenParameterivSGIS(GLenum pname, GLint[] parameters)
        {
            if (glPixelTexGenParameterivSGIS != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glPixelTexGenParameterivSGIS(pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glPixelTexGenParameterfSGIS (GLenum pname, GLfloat param);
        public static void PixelTexGenParameterfSGIS(GLenum pname, GLfloat param)
        {
            if (glPixelTexGenParameterfSGIS != null)
            {
                glPixelTexGenParameterfSGIS(pname, param);
            }
        }

        // GLAPI void APIENTRY glPixelTexGenParameterfvSGIS (GLenum pname, const GLfloat *params);
        public unsafe static void PixelTexGenParameterfvSGIS(GLenum pname, GLfloat[] parameters)
        {
            if (glPixelTexGenParameterfvSGIS != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glPixelTexGenParameterfvSGIS(pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetPixelTexGenParameterivSGIS (GLenum pname, GLint *params);
        public unsafe static void GetPixelTexGenParameterivSGIS(GLenum pname, GLint[] parameters)
        {
            if (glGetPixelTexGenParameterivSGIS != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetPixelTexGenParameterivSGIS(pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetPixelTexGenParameterfvSGIS (GLenum pname, GLfloat *params);
        public unsafe static void GetPixelTexGenParameterfvSGIS(GLenum pname, GLfloat[] parameters)
        {
            if (glGetPixelTexGenParameterfvSGIS != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetPixelTexGenParameterfvSGIS(pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture4D
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexImage4DSGIS (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void TexImage4DSGIS(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLint border, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTexImage4DSGIS != null)
            {
                glTexImage4DSGIS(target, level, internalformat, width, height, depth, size4d, border, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glTexSubImage4DSGIS (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint woffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLenum format, GLenum type, const GLvoid *pixels);
        public unsafe static void TexSubImage4DSGIS(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint woffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTexSubImage4DSGIS != null)
            {
                glTexSubImage4DSGIS(target, level, xoffset, yoffset, zoffset, woffset, width, height, depth, size4d, format, type, pixels.ToPointer());
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_detail_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDetailTexFuncSGIS (GLenum target, GLsizei n, const GLfloat *points);
        public unsafe static void DetailTexFuncSGIS(GLenum target, GLsizei n, GLfloat[] points)
        {
            if (glDetailTexFuncSGIS != null)
            {
                fixed (GLfloat* ptr_points = points)
                {
                    glDetailTexFuncSGIS(target, n, ptr_points);
                }
            }
        }

        // GLAPI void APIENTRY glGetDetailTexFuncSGIS (GLenum target, GLfloat *points);
        public unsafe static void GetDetailTexFuncSGIS(GLenum target, GLfloat[] points)
        {
            if (glGetDetailTexFuncSGIS != null)
            {
                fixed (GLfloat* ptr_points = points)
                {
                    glGetDetailTexFuncSGIS(target, ptr_points);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_sharpen_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glSharpenTexFuncSGIS (GLenum target, GLsizei n, const GLfloat *points);
        public unsafe static void SharpenTexFuncSGIS(GLenum target, GLsizei n, GLfloat[] points)
        {
            if (glSharpenTexFuncSGIS != null)
            {
                fixed (GLfloat* ptr_points = points)
                {
                    glSharpenTexFuncSGIS(target, n, ptr_points);
                }
            }
        }

        // GLAPI void APIENTRY glGetSharpenTexFuncSGIS (GLenum target, GLfloat *points);
        public unsafe static void GetSharpenTexFuncSGIS(GLenum target, GLfloat[] points)
        {
            if (glGetSharpenTexFuncSGIS != null)
            {
                fixed (GLfloat* ptr_points = points)
                {
                    glGetSharpenTexFuncSGIS(target, ptr_points);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_lod (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_select (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_multisample
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glSampleMaskSGIS (GLclampf value, GLboolean invert);
        public static void SampleMaskSGIS(GLclampf value, GLboolean invert)
        {
            if (glSampleMaskSGIS != null)
            {
                glSampleMaskSGIS(value, invert);
            }
        }

        // GLAPI void APIENTRY glSamplePatternSGIS (GLenum pattern);
        public static void SamplePatternSGIS(GLenum pattern)
        {
            if (glSamplePatternSGIS != null)
            {
                glSamplePatternSGIS(pattern);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_generate_mipmap (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_edge_clamp (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_border_clamp (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_fog_function
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFogFuncSGIS (GLsizei n, const GLfloat *points);
        public unsafe static void FogFuncSGIS(GLsizei n, GLfloat[] points)
        {
            if (glFogFuncSGIS != null)
            {
                fixed (GLfloat* ptr_points = points)
                {
                    glFogFuncSGIS(n, ptr_points);
                }
            }
        }

        // GLAPI void APIENTRY glGetFogFuncSGIS (GLfloat *points);
        public unsafe static void GetFogFuncSGIS(GLfloat[] points)
        {
            if (glGetFogFuncSGIS != null)
            {
                fixed (GLfloat* ptr_points = points)
                {
                    glGetFogFuncSGIS(ptr_points);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_point_parameters
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPointParameterfSGIS (GLenum pname, GLfloat param);
        public static void PointParameterfSGIS(GLenum pname, GLfloat param)
        {
            if (glPointParameterfSGIS != null)
            {
                glPointParameterfSGIS(pname, param);
            }
        }

        // GLAPI void APIENTRY glPointParameterfvSGIS (GLenum pname, const GLfloat *params);
        public unsafe static void PointParameterfvSGIS(GLenum pname, GLfloat[] parameters)
        {
            if (glPointParameterfvSGIS != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glPointParameterfvSGIS(pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_point_line_texgen (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_color_mask
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTextureColorMaskSGIS (GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);
        public static void TextureColorMaskSGIS(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha)
        {
            if (glTextureColorMaskSGIS != null)
            {
                glTextureColorMaskSGIS(red, green, blue, alpha);
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SGIX_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_pixel_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPixelTexGenSGIX (GLenum mode);
        public static void PixelTexGenSGIX(GLenum mode)
        {
            if (glPixelTexGenSGIX != null)
            {
                glPixelTexGenSGIX(mode);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_FfdMaskSGIX (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_clipmap (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_shadow (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_interlace (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_pixel_tiles (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_select (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_sprite
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glSpriteParameterfSGIX (GLenum pname, GLfloat param);
        public static void SpriteParameterfSGIX(GLenum pname, GLfloat param)
        {
            if (glSpriteParameterfSGIX != null)
            {
                glSpriteParameterfSGIX(pname, param);
            }
        }

        // GLAPI void APIENTRY glSpriteParameterfvSGIX (GLenum pname, const GLfloat *params);
        public unsafe static void SpriteParameterfvSGIX(GLenum pname, GLfloat[] parameters)
        {
            if (glSpriteParameterfvSGIX != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glSpriteParameterfvSGIX(pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glSpriteParameteriSGIX (GLenum pname, GLint param);
        public static void SpriteParameteriSGIX(GLenum pname, GLint param)
        {
            if (glSpriteParameteriSGIX != null)
            {
                glSpriteParameteriSGIX(pname, param);
            }
        }

        // GLAPI void APIENTRY glSpriteParameterivSGIX (GLenum pname, const GLint *params);
        public unsafe static void SpriteParameterivSGIX(GLenum pname, GLint[] parameters)
        {
            if (glSpriteParameterivSGIX != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glSpriteParameterivSGIX(pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_multi_buffer (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_instruments
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLint APIENTRY glGetInstrumentsSGIX (void);
        public static GLint GetInstrumentsSGIX()
        {
            if (glGetInstrumentsSGIX != null)
            {
                return glGetInstrumentsSGIX();
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glInstrumentsBufferSGIX (GLsizei size, GLint *buffer);
        public unsafe static void InstrumentsBufferSGIX(GLsizei size, GLint[] buffer)
        {
            if (glInstrumentsBufferSGIX != null)
            {
                fixed (GLint* ptr_buffer = buffer)
                {
                    glInstrumentsBufferSGIX(size, ptr_buffer);
                }
            }
        }

        // GLAPI GLint APIENTRY glPollInstrumentsSGIX (GLint *marker_p);
        public unsafe static GLint PollInstrumentsSGIX(GLint[] marker_p)
        {
            if (glPollInstrumentsSGIX != null)
            {
                fixed (GLint* ptr_marker_p = marker_p)
                {
                    return glPollInstrumentsSGIX(ptr_marker_p);
                }
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glReadInstrumentsSGIX (GLint marker);
        public static void ReadInstrumentsSGIX(GLint marker)
        {
            if (glReadInstrumentsSGIX != null)
            {
                glReadInstrumentsSGIX(marker);
            }
        }

        // GLAPI void APIENTRY glStartInstrumentsSGIX (void);
        public static void StartInstrumentsSGIX()
        {
            if (glStartInstrumentsSGIX != null)
            {
                glStartInstrumentsSGIX();
            }
        }

        // GLAPI void APIENTRY glStopInstrumentsSGIX (GLint marker);
        public static void StopInstrumentsSGIX(GLint marker)
        {
            if (glStopInstrumentsSGIX != null)
            {
                glStopInstrumentsSGIX(marker);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_scale_bias
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_framezoom
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFrameZoomSGIX (GLint factor);
        public static void FrameZoomSGIX(GLint factor)
        {
            if (glFrameZoomSGIX != null)
            {
                glFrameZoomSGIX(factor);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_tag_sample_buffer
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTagSampleBufferSGIX (void);
        public static void TagSampleBufferSGIX()
        {
            if (glTagSampleBufferSGIX != null)
            {
                glTagSampleBufferSGIX();
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_polynomial_ffd
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDeformationMap3dSGIX (GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble w1, GLdouble w2, GLint wstride, GLint worder, const GLdouble *points);
        public unsafe static void DeformationMap3dSGIX(GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble w1, GLdouble w2, GLint wstride, GLint worder, GLdouble[] points)
        {
            if (glDeformationMap3dSGIX != null)
            {
                fixed (GLdouble* ptr_points = points)
                {
                    glDeformationMap3dSGIX(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, ptr_points);
                }
            }
        }

        // GLAPI void APIENTRY glDeformationMap3fSGIX (GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat w1, GLfloat w2, GLint wstride, GLint worder, const GLfloat *points);
        public unsafe static void DeformationMap3fSGIX(GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat w1, GLfloat w2, GLint wstride, GLint worder, GLfloat[] points)
        {
            if (glDeformationMap3fSGIX != null)
            {
                fixed (GLfloat* ptr_points = points)
                {
                    glDeformationMap3fSGIX(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, ptr_points);
                }
            }
        }

        // GLAPI void APIENTRY glDeformSGIX (GLbitfield mask);
        public static void DeformSGIX(GLbitfield mask)
        {
            if (glDeformSGIX != null)
            {
                glDeformSGIX(mask);
            }
        }

        // GLAPI void APIENTRY glLoadIdentityDeformationMapSGIX (GLbitfield mask);
        public static void LoadIdentityDeformationMapSGIX(GLbitfield mask)
        {
            if (glLoadIdentityDeformationMapSGIX != null)
            {
                glLoadIdentityDeformationMapSGIX(mask);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_reference_plane
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glReferencePlaneSGIX (const GLdouble *equation);
        public unsafe static void ReferencePlaneSGIX(GLdouble[] equation)
        {
            if (glReferencePlaneSGIX != null)
            {
                fixed (GLdouble* ptr_equation = equation)
                {
                    glReferencePlaneSGIX(ptr_equation);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_flush_raster
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFlushRasterSGIX (void);
        public static void FlushRasterSGIX()
        {
            if (glFlushRasterSGIX != null)
            {
                glFlushRasterSGIX();
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_depth_texture (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_fog_offset (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_add_env (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_list_priority
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetListParameterfvSGIX (GLuint list, GLenum pname, GLfloat *params);
        public unsafe static void GetListParameterfvSGIX(GLuint list, GLenum pname, GLfloat[] parameters)
        {
            if (glGetListParameterfvSGIX != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetListParameterfvSGIX(list, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetListParameterivSGIX (GLuint list, GLenum pname, GLint *params);
        public unsafe static void GetListParameterivSGIX(GLuint list, GLenum pname, GLint[] parameters)
        {
            if (glGetListParameterivSGIX != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetListParameterivSGIX(list, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glListParameterfSGIX (GLuint list, GLenum pname, GLfloat param);
        public static void ListParameterfSGIX(GLuint list, GLenum pname, GLfloat param)
        {
            if (glListParameterfSGIX != null)
            {
                glListParameterfSGIX(list, pname, param);
            }
        }

        // GLAPI void APIENTRY glListParameterfvSGIX (GLuint list, GLenum pname, const GLfloat *params);
        public unsafe static void ListParameterfvSGIX(GLuint list, GLenum pname, GLfloat[] parameters)
        {
            if (glListParameterfvSGIX != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glListParameterfvSGIX(list, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glListParameteriSGIX (GLuint list, GLenum pname, GLint param);
        public static void ListParameteriSGIX(GLuint list, GLenum pname, GLint param)
        {
            if (glListParameteriSGIX != null)
            {
                glListParameteriSGIX(list, pname, param);
            }
        }

        // GLAPI void APIENTRY glListParameterivSGIX (GLuint list, GLenum pname, const GLint *params);
        public unsafe static void ListParameterivSGIX(GLuint list, GLenum pname, GLint[] parameters)
        {
            if (glListParameterivSGIX != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glListParameterivSGIX(list, pname, ptr_parameters);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_ir_instrument1 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_calligraphic_fragment (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_lod_bias (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_shadow_ambient (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_ycrcb (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_fragment_lighting
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFragmentColorMaterialSGIX (GLenum face, GLenum mode);
        public static void FragmentColorMaterialSGIX(GLenum face, GLenum mode)
        {
            if (glFragmentColorMaterialSGIX != null)
            {
                glFragmentColorMaterialSGIX(face, mode);
            }
        }

        // GLAPI void APIENTRY glFragmentLightfSGIX (GLenum light, GLenum pname, GLfloat param);
        public static void FragmentLightfSGIX(GLenum light, GLenum pname, GLfloat param)
        {
            if (glFragmentLightfSGIX != null)
            {
                glFragmentLightfSGIX(light, pname, param);
            }
        }

        // GLAPI void APIENTRY glFragmentLightfvSGIX (GLenum light, GLenum pname, const GLfloat *params);
        public unsafe static void FragmentLightfvSGIX(GLenum light, GLenum pname, GLfloat[] parameters)
        {
            if (glFragmentLightfvSGIX != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glFragmentLightfvSGIX(light, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glFragmentLightiSGIX (GLenum light, GLenum pname, GLint param);
        public static void FragmentLightiSGIX(GLenum light, GLenum pname, GLint param)
        {
            if (glFragmentLightiSGIX != null)
            {
                glFragmentLightiSGIX(light, pname, param);
            }
        }

        // GLAPI void APIENTRY glFragmentLightivSGIX (GLenum light, GLenum pname, const GLint *params);
        public unsafe static void FragmentLightivSGIX(GLenum light, GLenum pname, GLint[] parameters)
        {
            if (glFragmentLightivSGIX != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glFragmentLightivSGIX(light, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glFragmentLightModelfSGIX (GLenum pname, GLfloat param);
        public static void FragmentLightModelfSGIX(GLenum pname, GLfloat param)
        {
            if (glFragmentLightModelfSGIX != null)
            {
                glFragmentLightModelfSGIX(pname, param);
            }
        }

        // GLAPI void APIENTRY glFragmentLightModelfvSGIX (GLenum pname, const GLfloat *params);
        public unsafe static void FragmentLightModelfvSGIX(GLenum pname, GLfloat[] parameters)
        {
            if (glFragmentLightModelfvSGIX != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glFragmentLightModelfvSGIX(pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glFragmentLightModeliSGIX (GLenum pname, GLint param);
        public static void FragmentLightModeliSGIX(GLenum pname, GLint param)
        {
            if (glFragmentLightModeliSGIX != null)
            {
                glFragmentLightModeliSGIX(pname, param);
            }
        }

        // GLAPI void APIENTRY glFragmentLightModelivSGIX (GLenum pname, const GLint *params);
        public unsafe static void FragmentLightModelivSGIX(GLenum pname, GLint[] parameters)
        {
            if (glFragmentLightModelivSGIX != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glFragmentLightModelivSGIX(pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glFragmentMaterialfSGIX (GLenum face, GLenum pname, GLfloat param);
        public static void FragmentMaterialfSGIX(GLenum face, GLenum pname, GLfloat param)
        {
            if (glFragmentMaterialfSGIX != null)
            {
                glFragmentMaterialfSGIX(face, pname, param);
            }
        }

        // GLAPI void APIENTRY glFragmentMaterialfvSGIX (GLenum face, GLenum pname, const GLfloat *params);
        public unsafe static void FragmentMaterialfvSGIX(GLenum face, GLenum pname, GLfloat[] parameters)
        {
            if (glFragmentMaterialfvSGIX != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glFragmentMaterialfvSGIX(face, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glFragmentMaterialiSGIX (GLenum face, GLenum pname, GLint param);
        public static void FragmentMaterialiSGIX(GLenum face, GLenum pname, GLint param)
        {
            if (glFragmentMaterialiSGIX != null)
            {
                glFragmentMaterialiSGIX(face, pname, param);
            }
        }

        // GLAPI void APIENTRY glFragmentMaterialivSGIX (GLenum face, GLenum pname, const GLint *params);
        public unsafe static void FragmentMaterialivSGIX(GLenum face, GLenum pname, GLint[] parameters)
        {
            if (glFragmentMaterialivSGIX != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glFragmentMaterialivSGIX(face, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetFragmentLightfvSGIX (GLenum light, GLenum pname, GLfloat *params);
        public unsafe static void GetFragmentLightfvSGIX(GLenum light, GLenum pname, GLfloat[] parameters)
        {
            if (glGetFragmentLightfvSGIX != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetFragmentLightfvSGIX(light, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetFragmentLightivSGIX (GLenum light, GLenum pname, GLint *params);
        public unsafe static void GetFragmentLightivSGIX(GLenum light, GLenum pname, GLint[] parameters)
        {
            if (glGetFragmentLightivSGIX != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetFragmentLightivSGIX(light, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetFragmentMaterialfvSGIX (GLenum face, GLenum pname, GLfloat *params);
        public unsafe static void GetFragmentMaterialfvSGIX(GLenum face, GLenum pname, GLfloat[] parameters)
        {
            if (glGetFragmentMaterialfvSGIX != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetFragmentMaterialfvSGIX(face, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetFragmentMaterialivSGIX (GLenum face, GLenum pname, GLint *params);
        public unsafe static void GetFragmentMaterialivSGIX(GLenum face, GLenum pname, GLint[] parameters)
        {
            if (glGetFragmentMaterialivSGIX != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetFragmentMaterialivSGIX(face, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glLightEnviSGIX (GLenum pname, GLint param);
        public static void LightEnviSGIX(GLenum pname, GLint param)
        {
            if (glLightEnviSGIX != null)
            {
                glLightEnviSGIX(pname, param);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_blend_alpha_minmax (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_async
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glAsyncMarkerSGIX (GLuint marker);
        public static void AsyncMarkerSGIX(GLuint marker)
        {
            if (glAsyncMarkerSGIX != null)
            {
                glAsyncMarkerSGIX(marker);
            }
        }

        // GLAPI GLint APIENTRY glFinishAsyncSGIX (GLuint *markerp);
        public unsafe static GLint FinishAsyncSGIX(GLuint[] markerp)
        {
            if (glFinishAsyncSGIX != null)
            {
                fixed (GLuint* ptr_markerp = markerp)
                {
                    return glFinishAsyncSGIX(ptr_markerp);
                }
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLint APIENTRY glPollAsyncSGIX (GLuint *markerp);
        public unsafe static GLint PollAsyncSGIX(GLuint[] markerp)
        {
            if (glPollAsyncSGIX != null)
            {
                fixed (GLuint* ptr_markerp = markerp)
                {
                    return glPollAsyncSGIX(ptr_markerp);
                }
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLuint APIENTRY glGenAsyncMarkersSGIX (GLsizei range);
        public static GLuint GenAsyncMarkersSGIX(GLsizei range)
        {
            if (glGenAsyncMarkersSGIX != null)
            {
                return glGenAsyncMarkersSGIX(range);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glDeleteAsyncMarkersSGIX (GLuint marker, GLsizei range);
        public static void DeleteAsyncMarkersSGIX(GLuint marker, GLsizei range)
        {
            if (glDeleteAsyncMarkersSGIX != null)
            {
                glDeleteAsyncMarkersSGIX(marker, range);
            }
        }

        // GLAPI GLboolean APIENTRY glIsAsyncMarkerSGIX (GLuint marker);
        public static GLboolean IsAsyncMarkerSGIX(GLuint marker)
        {
            if (glIsAsyncMarkerSGIX != null)
            {
                return glIsAsyncMarkerSGIX(marker);
            }
            else
            {
                return false;
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_async_pixel (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_async_histogram (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_fog_scale (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_subsample (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_ycrcba (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_ycrcb_subsample (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_depth_pass_instrument (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_vertex_preclip (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_convolution_accuracy (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_resample (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_coordinate_clamp (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_scalebias_hint (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_igloo_interface
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glIglooInterfaceSGIX (GLenum pname, const GLvoid *params);
        public unsafe static void IglooInterfaceSGIX(GLenum pname, IntPtr parameters)
        {
            if (glIglooInterfaceSGIX != null)
            {
                glIglooInterfaceSGIX(pname, parameters.ToPointer());
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SUN_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_multi_draw_arrays
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMultiDrawArraysSUN (GLenum mode, const GLint *first, const GLsizei *count, GLsizei primcount);
        public unsafe static void MultiDrawArraysSUN(GLenum mode, GLint[] first, GLsizei[] count, GLsizei primcount)
        {
            if (glMultiDrawArraysSUN != null)
            {
                fixed (GLint* ptr_first = first)
                {
                    fixed (GLsizei* ptr_count = count)
                    {
                        glMultiDrawArraysSUN(mode, ptr_first, ptr_count, primcount);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glMultiDrawElementsSUN (GLenum mode, const GLsizei *count, GLenum type, const GLvoid* *indices, GLsizei primcount);
        public unsafe static void MultiDrawElementsSUN(GLenum mode, GLsizei[] count, GLenum type, IntPtr[] indices, GLsizei primcount)
        {
            if (glMultiDrawElementsSUN != null)
            {
                fixed (GLsizei* ptr_count = count)
                {
                    fixed (IntPtr* ptr_indices = indices)
                    {
                        glMultiDrawElementsSUN(mode, ptr_count, type, (void**)ptr_indices, primcount);
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_global_alpha
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGlobalAlphaFactorbSUN (GLbyte factor);
        public static void GlobalAlphaFactorbSUN(GLbyte factor)
        {
            if (glGlobalAlphaFactorbSUN != null)
            {
                glGlobalAlphaFactorbSUN(factor);
            }
        }

        // GLAPI void APIENTRY glGlobalAlphaFactorsSUN (GLshort factor);
        public static void GlobalAlphaFactorsSUN(GLshort factor)
        {
            if (glGlobalAlphaFactorsSUN != null)
            {
                glGlobalAlphaFactorsSUN(factor);
            }
        }

        // GLAPI void APIENTRY glGlobalAlphaFactoriSUN (GLint factor);
        public static void GlobalAlphaFactoriSUN(GLint factor)
        {
            if (glGlobalAlphaFactoriSUN != null)
            {
                glGlobalAlphaFactoriSUN(factor);
            }
        }

        // GLAPI void APIENTRY glGlobalAlphaFactorfSUN (GLfloat factor);
        public static void GlobalAlphaFactorfSUN(GLfloat factor)
        {
            if (glGlobalAlphaFactorfSUN != null)
            {
                glGlobalAlphaFactorfSUN(factor);
            }
        }

        // GLAPI void APIENTRY glGlobalAlphaFactordSUN (GLdouble factor);
        public static void GlobalAlphaFactordSUN(GLdouble factor)
        {
            if (glGlobalAlphaFactordSUN != null)
            {
                glGlobalAlphaFactordSUN(factor);
            }
        }

        // GLAPI void APIENTRY glGlobalAlphaFactorubSUN (GLubyte factor);
        public static void GlobalAlphaFactorubSUN(GLubyte factor)
        {
            if (glGlobalAlphaFactorubSUN != null)
            {
                glGlobalAlphaFactorubSUN(factor);
            }
        }

        // GLAPI void APIENTRY glGlobalAlphaFactorusSUN (GLushort factor);
        public static void GlobalAlphaFactorusSUN(GLushort factor)
        {
            if (glGlobalAlphaFactorusSUN != null)
            {
                glGlobalAlphaFactorusSUN(factor);
            }
        }

        // GLAPI void APIENTRY glGlobalAlphaFactoruiSUN (GLuint factor);
        public static void GlobalAlphaFactoruiSUN(GLuint factor)
        {
            if (glGlobalAlphaFactoruiSUN != null)
            {
                glGlobalAlphaFactoruiSUN(factor);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_triangle_list
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glReplacementCodeuiSUN (GLuint code);
        public static void ReplacementCodeuiSUN(GLuint code)
        {
            if (glReplacementCodeuiSUN != null)
            {
                glReplacementCodeuiSUN(code);
            }
        }

        // GLAPI void APIENTRY glReplacementCodeusSUN (GLushort code);
        public static void ReplacementCodeusSUN(GLushort code)
        {
            if (glReplacementCodeusSUN != null)
            {
                glReplacementCodeusSUN(code);
            }
        }

        // GLAPI void APIENTRY glReplacementCodeubSUN (GLubyte code);
        public static void ReplacementCodeubSUN(GLubyte code)
        {
            if (glReplacementCodeubSUN != null)
            {
                glReplacementCodeubSUN(code);
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuivSUN (const GLuint *code);
        public unsafe static void ReplacementCodeuivSUN(GLuint[] code)
        {
            if (glReplacementCodeuivSUN != null)
            {
                fixed (GLuint* ptr_code = code)
                {
                    glReplacementCodeuivSUN(ptr_code);
                }
            }
        }

        // GLAPI void APIENTRY glReplacementCodeusvSUN (const GLushort *code);
        public unsafe static void ReplacementCodeusvSUN(GLushort[] code)
        {
            if (glReplacementCodeusvSUN != null)
            {
                fixed (GLushort* ptr_code = code)
                {
                    glReplacementCodeusvSUN(ptr_code);
                }
            }
        }

        // GLAPI void APIENTRY glReplacementCodeubvSUN (const GLubyte *code);
        public unsafe static void ReplacementCodeubvSUN(GLubyte[] code)
        {
            if (glReplacementCodeubvSUN != null)
            {
                fixed (GLubyte* ptr_code = code)
                {
                    glReplacementCodeubvSUN(ptr_code);
                }
            }
        }

        // GLAPI void APIENTRY glReplacementCodePointerSUN (GLenum type, GLsizei stride, const GLvoid* *pointer);
        public unsafe static void ReplacementCodePointerSUN(GLenum type, GLsizei stride, IntPtr[] pointer)
        {
            if (glReplacementCodePointerSUN != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glReplacementCodePointerSUN(type, stride, (void**)ptr_pointer);
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_vertex
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glColor4ubVertex2fSUN (GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y);
        public static void Color4ubVertex2fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y)
        {
            if (glColor4ubVertex2fSUN != null)
            {
                glColor4ubVertex2fSUN(r, g, b, a, x, y);
            }
        }

        // GLAPI void APIENTRY glColor4ubVertex2fvSUN (const GLubyte *c, const GLfloat *v);
        public unsafe static void Color4ubVertex2fvSUN(GLubyte[] c, GLfloat[] v)
        {
            if (glColor4ubVertex2fvSUN != null)
            {
                fixed (GLubyte* ptr_c = c)
                {
                    fixed (GLfloat* ptr_v = v)
                    {
                        glColor4ubVertex2fvSUN(ptr_c, ptr_v);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glColor4ubVertex3fSUN (GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        public static void Color4ubVertex3fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glColor4ubVertex3fSUN != null)
            {
                glColor4ubVertex3fSUN(r, g, b, a, x, y, z);
            }
        }

        // GLAPI void APIENTRY glColor4ubVertex3fvSUN (const GLubyte *c, const GLfloat *v);
        public unsafe static void Color4ubVertex3fvSUN(GLubyte[] c, GLfloat[] v)
        {
            if (glColor4ubVertex3fvSUN != null)
            {
                fixed (GLubyte* ptr_c = c)
                {
                    fixed (GLfloat* ptr_v = v)
                    {
                        glColor4ubVertex3fvSUN(ptr_c, ptr_v);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glColor3fVertex3fSUN (GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        public static void Color3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glColor3fVertex3fSUN != null)
            {
                glColor3fVertex3fSUN(r, g, b, x, y, z);
            }
        }

        // GLAPI void APIENTRY glColor3fVertex3fvSUN (const GLfloat *c, const GLfloat *v);
        public unsafe static void Color3fVertex3fvSUN(GLfloat[] c, GLfloat[] v)
        {
            if (glColor3fVertex3fvSUN != null)
            {
                fixed (GLfloat* ptr_c = c)
                {
                    fixed (GLfloat* ptr_v = v)
                    {
                        glColor3fVertex3fvSUN(ptr_c, ptr_v);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glNormal3fVertex3fSUN (GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        public static void Normal3fVertex3fSUN(GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glNormal3fVertex3fSUN != null)
            {
                glNormal3fVertex3fSUN(nx, ny, nz, x, y, z);
            }
        }

        // GLAPI void APIENTRY glNormal3fVertex3fvSUN (const GLfloat *n, const GLfloat *v);
        public unsafe static void Normal3fVertex3fvSUN(GLfloat[] n, GLfloat[] v)
        {
            if (glNormal3fVertex3fvSUN != null)
            {
                fixed (GLfloat* ptr_n = n)
                {
                    fixed (GLfloat* ptr_v = v)
                    {
                        glNormal3fVertex3fvSUN(ptr_n, ptr_v);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glColor4fNormal3fVertex3fSUN (GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        public static void Color4fNormal3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glColor4fNormal3fVertex3fSUN != null)
            {
                glColor4fNormal3fVertex3fSUN(r, g, b, a, nx, ny, nz, x, y, z);
            }
        }

        // GLAPI void APIENTRY glColor4fNormal3fVertex3fvSUN (const GLfloat *c, const GLfloat *n, const GLfloat *v);
        public unsafe static void Color4fNormal3fVertex3fvSUN (GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            if (glColor4fNormal3fVertex3fvSUN != null) 
            {
                fixed(GLfloat* ptr_c = c) 
                {
                    fixed (GLfloat* ptr_n = n) 
                    {
                        fixed (GLfloat* ptr_v = v) 
                        {
                            glColor4fNormal3fVertex3fvSUN(ptr_c, ptr_n, ptr_v);
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord2fVertex3fSUN (GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);
        public static void TexCoord2fVertex3fSUN(GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glTexCoord2fVertex3fSUN != null)
            {
                glTexCoord2fVertex3fSUN(s, t, x, y, z);
            }
        }

        // GLAPI void APIENTRY glTexCoord2fVertex3fvSUN (const GLfloat *tc, const GLfloat *v);
        public unsafe static void TexCoord2fVertex3fvSUN(GLfloat[] tc, GLfloat[] v)
        {
            if (glTexCoord2fVertex3fvSUN != null)
            {
                fixed (GLfloat* ptr_tc = tc)
                {
                    fixed (GLfloat* ptr_v = v)
                    {
                        glTexCoord2fVertex3fvSUN(ptr_tc, ptr_v);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord4fVertex4fSUN (GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        public static void TexCoord4fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glTexCoord4fVertex4fSUN != null)
            {
                glTexCoord4fVertex4fSUN(s, t, p, q, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glTexCoord4fVertex4fvSUN (const GLfloat *tc, const GLfloat *v);
        public unsafe static void TexCoord4fVertex4fvSUN(GLfloat[] tc, GLfloat[] v)
        {
            if (glTexCoord4fVertex4fvSUN != null)
            {
                fixed (GLfloat* ptr_tc = tc)
                {
                    fixed (GLfloat* ptr_v = v)
                    {
                        glTexCoord4fVertex4fvSUN(ptr_tc, ptr_v);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord2fColor4ubVertex3fSUN (GLfloat s, GLfloat t, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        public static void TexCoord2fColor4ubVertex3fSUN(GLfloat s, GLfloat t, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glTexCoord2fColor4ubVertex3fSUN != null)
            {
                glTexCoord2fColor4ubVertex3fSUN(s, t, r, g, b, a, x, y, z);
            }
        }

        // GLAPI void APIENTRY glTexCoord2fColor4ubVertex3fvSUN (const GLfloat *tc, const GLubyte *c, const GLfloat *v);
        public unsafe static void TexCoord2fColor4ubVertex3fvSUN(GLfloat[] tc, GLubyte[] c, GLfloat[] v)
        {
            if (glTexCoord2fColor4ubVertex3fvSUN != null)
            {
                fixed (GLfloat* ptr_tc = tc)
                {
                    fixed (GLubyte* ptr_c = c)
                    {
                        fixed (GLfloat* ptr_v = v)
                        {
                            glTexCoord2fColor4ubVertex3fvSUN(ptr_tc, ptr_c, ptr_v);
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord2fColor3fVertex3fSUN (GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        public static void TexCoord2fColor3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glTexCoord2fColor3fVertex3fSUN != null)
            {
                glTexCoord2fColor3fVertex3fSUN(s, t, r, g, b, x, y, z);
            }
        }

        // GLAPI void APIENTRY glTexCoord2fColor3fVertex3fvSUN (const GLfloat *tc, const GLfloat *c, const GLfloat *v);
        public unsafe static void TexCoord2fColor3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat[] v)
        {
            if (glTexCoord2fColor3fVertex3fvSUN != null)
            {
                fixed (GLfloat* ptr_tc = tc)
                {
                    fixed (GLfloat* ptr_c = c)
                    {
                        fixed (GLfloat* ptr_v = v)
                        {
                            glTexCoord2fColor3fVertex3fvSUN(ptr_tc, ptr_c, ptr_v);
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord2fNormal3fVertex3fSUN (GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        public static void TexCoord2fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glTexCoord2fNormal3fVertex3fSUN != null)
            {
                glTexCoord2fNormal3fVertex3fSUN(s, t, nx, ny, nz, x, y, z);
            }
        }

        // GLAPI void APIENTRY glTexCoord2fNormal3fVertex3fvSUN (const GLfloat *tc, const GLfloat *n, const GLfloat *v);
        public unsafe static void TexCoord2fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] n, GLfloat[] v)
        {
            if (glTexCoord2fNormal3fVertex3fvSUN != null)
            {
                fixed (GLfloat* ptr_tc = tc)
                {
                    fixed (GLfloat* ptr_n = n)
                    {
                        fixed (GLfloat* ptr_v = v)
                        {
                            glTexCoord2fNormal3fVertex3fvSUN(ptr_tc, ptr_n, ptr_v);
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord2fColor4fNormal3fVertex3fSUN (GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        public static void TexCoord2fColor4fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glTexCoord2fColor4fNormal3fVertex3fSUN != null)
            {
                glTexCoord2fColor4fNormal3fVertex3fSUN(s, t, r, g, b, a, nx, ny, nz, x, y, z);
            }
        }

        // GLAPI void APIENTRY glTexCoord2fColor4fNormal3fVertex3fvSUN (const GLfloat *tc, const GLfloat *c, const GLfloat *n, const GLfloat *v);
        public unsafe static void TexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            if (glTexCoord2fColor4fNormal3fVertex3fvSUN != null)
            {
                fixed (GLfloat* ptr_tc = tc)
                {
                    fixed (GLfloat* ptr_c = c)
                    {
                        fixed (GLfloat* ptr_n = n)
                        {
                            fixed (GLfloat* ptr_v = v)
                            {
                                glTexCoord2fColor4fNormal3fVertex3fvSUN(ptr_tc, ptr_c, ptr_n, ptr_v);
                            }
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glTexCoord4fColor4fNormal3fVertex4fSUN (GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        public static void TexCoord4fColor4fNormal3fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glTexCoord4fColor4fNormal3fVertex4fSUN != null)
            {
                glTexCoord4fColor4fNormal3fVertex4fSUN(s, t, p, q, r, g, b, a, nx, ny, nz, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glTexCoord4fColor4fNormal3fVertex4fvSUN (const GLfloat *tc, const GLfloat *c, const GLfloat *n, const GLfloat *v);
        public unsafe static void TexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat[] tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            if (glTexCoord4fColor4fNormal3fVertex4fvSUN != null)
            {
                fixed (GLfloat* ptr_tc = tc)
                {
                    fixed (GLfloat* ptr_c = c)
                    {
                        fixed (GLfloat* ptr_n = n)
                        {
                            fixed (GLfloat* ptr_v = v)
                            {
                                glTexCoord4fColor4fNormal3fVertex4fvSUN(ptr_tc, ptr_c, ptr_n, ptr_v);
                            }
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiVertex3fSUN (GLuint rc, GLfloat x, GLfloat y, GLfloat z);
        public static void ReplacementCodeuiVertex3fSUN(GLuint rc, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glReplacementCodeuiVertex3fSUN != null)
            {
                glReplacementCodeuiVertex3fSUN(rc, x, y, z);
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiVertex3fvSUN (const GLuint *rc, const GLfloat *v);
        public unsafe static void ReplacementCodeuiVertex3fvSUN(GLuint[] rc, GLfloat[] v)
        {
            if (glReplacementCodeuiVertex3fvSUN != null)
            {
                fixed (GLuint* ptr_rc = rc)
                {
                    fixed (GLfloat* ptr_v = v)
                    {
                        glReplacementCodeuiVertex3fvSUN(ptr_rc, ptr_v);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiColor4ubVertex3fSUN (GLuint rc, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        public static void ReplacementCodeuiColor4ubVertex3fSUN(GLuint rc, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glReplacementCodeuiColor4ubVertex3fSUN != null)
            {
                glReplacementCodeuiColor4ubVertex3fSUN(rc, r, g, b, a, x, y, z);
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiColor4ubVertex3fvSUN (const GLuint *rc, const GLubyte *c, const GLfloat *v);
        public unsafe static void ReplacementCodeuiColor4ubVertex3fvSUN(GLuint[] rc, GLubyte[] c, GLfloat[] v)
        {
            if (glReplacementCodeuiColor4ubVertex3fvSUN != null)
            {
                fixed (GLuint* ptr_rc = rc)
                {
                    fixed (GLubyte* ptr_c = c)
                    {
                        fixed (GLfloat* ptr_v = v)
                        {
                            glReplacementCodeuiColor4ubVertex3fvSUN(ptr_rc, ptr_c, ptr_v);
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiColor3fVertex3fSUN (GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        public static void ReplacementCodeuiColor3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glReplacementCodeuiColor3fVertex3fSUN != null)
            {
                glReplacementCodeuiColor3fVertex3fSUN(rc, r, g, b, x, y, z);
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiColor3fVertex3fvSUN (const GLuint *rc, const GLfloat *c, const GLfloat *v);
        public unsafe static void ReplacementCodeuiColor3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, GLfloat[] v)
        {
            if (glReplacementCodeuiColor3fVertex3fvSUN != null)
            {
                fixed (GLuint* ptr_rc = rc)
                {
                    fixed (GLfloat* ptr_c = c)
                    {
                        fixed (GLfloat* ptr_v = v)
                        {
                            glReplacementCodeuiColor3fVertex3fvSUN(ptr_rc, ptr_c, ptr_v);
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiNormal3fVertex3fSUN (GLuint rc, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        public static void ReplacementCodeuiNormal3fVertex3fSUN(GLuint rc, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glReplacementCodeuiNormal3fVertex3fSUN != null)
            {
                glReplacementCodeuiNormal3fVertex3fSUN(rc, nx, ny, nz, x, y, z);
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiNormal3fVertex3fvSUN (const GLuint *rc, const GLfloat *n, const GLfloat *v);
        public unsafe static void ReplacementCodeuiNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] n, GLfloat[] v)
        {
            if (glReplacementCodeuiNormal3fVertex3fvSUN != null)
            {
                fixed (GLuint* ptr_rc = rc)
                {
                    fixed (GLfloat* ptr_n = n)
                    {
                        fixed (GLfloat* ptr_v = v)
                        {
                            glReplacementCodeuiNormal3fVertex3fvSUN(ptr_rc, ptr_n, ptr_v);
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiColor4fNormal3fVertex3fSUN (GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        public static void ReplacementCodeuiColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glReplacementCodeuiColor4fNormal3fVertex3fSUN != null)
            {
                glReplacementCodeuiColor4fNormal3fVertex3fSUN(rc, r, g, b, a, nx, ny, nz, x, y, z);
            }
        }
        // GLAPI void APIENTRY glReplacementCodeuiColor4fNormal3fVertex3fvSUN (const GLuint *rc, const GLfloat *c, const GLfloat *n, const GLfloat *v);
        public unsafe static void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            if (glReplacementCodeuiColor4fNormal3fVertex3fvSUN != null)
            {
                fixed (GLuint* ptr_rc = rc)
                {
                    fixed (GLfloat* ptr_c = c)
                    {
                        fixed (GLfloat* ptr_n = n)
                        {
                            fixed (GLfloat* ptr_v = v)
                            {
                                glReplacementCodeuiColor4fNormal3fVertex3fvSUN(ptr_rc, ptr_c, ptr_n, ptr_v);
                            }
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiTexCoord2fVertex3fSUN (GLuint rc, GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);
        public static void ReplacementCodeuiTexCoord2fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glReplacementCodeuiTexCoord2fVertex3fSUN != null)
            {
                glReplacementCodeuiTexCoord2fVertex3fSUN(rc, s, t, x, y, z);
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiTexCoord2fVertex3fvSUN (const GLuint *rc, const GLfloat *tc, const GLfloat *v);
        public unsafe static void ReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] v)
        {
            if (glReplacementCodeuiTexCoord2fVertex3fvSUN != null)
            {
                fixed (GLuint* ptr_rc = rc)
                {
                    fixed (GLfloat* ptr_tc = tc)
                    {
                        fixed (GLfloat* ptr_v = v)
                        {
                            glReplacementCodeuiTexCoord2fVertex3fvSUN(ptr_rc, ptr_tc, ptr_v);
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN (GLuint rc, GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        public static void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN != null)
            {
                glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(rc, s, t, nx, ny, nz, x, y, z);
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN (const GLuint *rc, const GLfloat *tc, const GLfloat *n, const GLfloat *v);
        public unsafe static void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] n, GLfloat[] v)
        {
            if (glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN != null)
            {
                fixed (GLuint* ptr_rc = rc)
                {
                    fixed (GLfloat* ptr_tc = tc)
                    {
                        fixed (GLfloat* ptr_n = n)
                        {
                            fixed (GLfloat* ptr_v = v)
                            {
                                glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(ptr_rc, ptr_tc, ptr_n, ptr_v);
                            }
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN (GLuint rc, GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        public static void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN != null)
            {
                glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(rc, s, t, r, g, b, a, nx, ny, nz, x, y, z);
            }
        }

        // GLAPI void APIENTRY glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN (const GLuint *rc, const GLfloat *tc, const GLfloat *c, const GLfloat *n, const GLfloat *v);
        public unsafe static void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint[] rc, GLfloat[] tc, GLfloat[] c, GLfloat[] n, GLfloat[] v)
        {
            if (glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN != null)
            {
                fixed (GLuint* ptr_rc = rc)
                {
                    fixed (GLfloat* ptr_tc = tc)
                    {
                        fixed (GLfloat* ptr_c = c)
                        {
                            fixed (GLfloat* ptr_n = n)
                            {
                                fixed (GLfloat* ptr_v = v)
                                {
                                    glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(ptr_rc, ptr_tc, ptr_c, ptr_n, ptr_v);
                                }
                            }
                        }
                    }
                }
            }
        }


        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_convolution_border_modes (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_mesh_array
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDrawMeshArraysSUN (GLenum mode, GLint first, GLsizei count, GLsizei width);
        public static void DrawMeshArraysSUN(GLenum mode, GLint first, GLsizei count, GLsizei width)
        {
            if (glDrawMeshArraysSUN != null)
            {
                glDrawMeshArraysSUN(mode, first, count, width);
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_slice_accum (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SUNX_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SUNX_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SUNX_constant_data
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFinishTextureSUNX (void);
        public static void FinishTextureSUNX()
        {
            if (glFinishTextureSUNX != null)
            {
                glFinishTextureSUNX();
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_WIN_xxx WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region GL_WIN_xxx WRAPPERS...
        ///////////////////////////////////////////////////////////////////////
        // GL_WIN_phong_shading (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_WIN_specular_fog (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_WIN_swap_hint
        ///////////////////////////////////////////////////////////////////////
        // void glAddSwapHintRectWIN (GLint x, GLint y, GLsizei width, GLsizei height);
        public static void AddSwapHintRectWIN(GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glAddSwapHintRectWIN != null)
            {
                glAddSwapHintRectWIN(x, y, width, height);
            }
        }

        #endregion
    }
}
