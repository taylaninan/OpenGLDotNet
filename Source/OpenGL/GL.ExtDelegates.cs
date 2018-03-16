// ----------------------------------------------------------------------------
// FILE		: gl.extdelegates.cs
// VERSION	: 1.1.2
// COMMENT	: OpenGL Extensions low level delegates and functions.
// WEB      : https://github.com/carmack78/opengldotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : taylaninan@yahoo.com 
// DATE     : 2014-2018
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
    public static partial class GL
    {
        ///////////////////////////////////////////////////////////////////////
        // OPENGL EXTENSION FUNCTIONS
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_3DFX_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_3DFX_xxx FUNCTIONS...
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTbufferMask3DFX(GLuint mask);
        private static TglTbufferMask3DFX glTbufferMask3DFX = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_AMD_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_performance_monitor
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetPerfMonitorGroupsAMD (GLint *numGroups, GLsizei groupsSize, GLuint *groups);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPerfMonitorGroupsAMD(GLint* numGroups, GLsizei groupsSize, GLuint* groups);
        private static TglGetPerfMonitorGroupsAMD glGetPerfMonitorGroupsAMD = null;

        // GLAPI void APIENTRY glGetPerfMonitorCountersAMD (GLuint group, GLint *numCounters, GLint *maxActiveCounters, GLsizei counterSize, GLuint *counters);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPerfMonitorCountersAMD(GLuint group, GLint* numCounters, GLint* maxActiveCounters, GLsizei counterSize, GLuint* counters);
        private static TglGetPerfMonitorCountersAMD glGetPerfMonitorCountersAMD = null;

        // GLAPI void APIENTRY glGetPerfMonitorGroupStringAMD (GLuint group, GLsizei bufSize, GLsizei *length, GLchar *groupString);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPerfMonitorGroupStringAMD(GLuint group, GLsizei bufSize, GLsizei* length, GLchar* groupString);
        private static TglGetPerfMonitorGroupStringAMD glGetPerfMonitorGroupStringAMD = null;

        // GLAPI void APIENTRY glGetPerfMonitorCounterStringAMD (GLuint group, GLuint counter, GLsizei bufSize, GLsizei *length, GLchar *counterString);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPerfMonitorCounterStringAMD(GLuint group, GLuint counter, GLsizei bufSize, GLsizei* length, GLchar* counterString);
        private static TglGetPerfMonitorCounterStringAMD glGetPerfMonitorCounterStringAMD = null;

        // GLAPI void APIENTRY glGetPerfMonitorCounterInfoAMD (GLuint group, GLuint counter, GLenum pname, GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPerfMonitorCounterInfoAMD(GLuint group, GLuint counter, GLenum pname, void* data);
        private static TglGetPerfMonitorCounterInfoAMD glGetPerfMonitorCounterInfoAMD = null;

        // GLAPI void APIENTRY glGenPerfMonitorsAMD (GLsizei n, GLuint *monitors);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenPerfMonitorsAMD(GLsizei n, GLuint* monitors);
        private static TglGenPerfMonitorsAMD glGenPerfMonitorsAMD = null;

        // GLAPI void APIENTRY glDeletePerfMonitorsAMD (GLsizei n, GLuint *monitors);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeletePerfMonitorsAMD(GLsizei n, GLuint* monitors);
        private static TglDeletePerfMonitorsAMD glDeletePerfMonitorsAMD = null;

        // GLAPI void APIENTRY glSelectPerfMonitorCountersAMD (GLuint monitor, GLboolean enable, GLuint group, GLint numCounters, GLuint *counterList);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSelectPerfMonitorCountersAMD(GLuint monitor, GLboolean enable, GLuint group, GLint numCounters, GLuint* counterList);
        private static TglSelectPerfMonitorCountersAMD glSelectPerfMonitorCountersAMD = null;

        // GLAPI void APIENTRY glBeginPerfMonitorAMD (GLuint monitor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginPerfMonitorAMD(GLuint monitor);
        private static TglBeginPerfMonitorAMD glBeginPerfMonitorAMD = null;

        // GLAPI void APIENTRY glEndPerfMonitorAMD (GLuint monitor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndPerfMonitorAMD(GLuint monitor);
        private static TglEndPerfMonitorAMD glEndPerfMonitorAMD = null;

        // GLAPI void APIENTRY glGetPerfMonitorCounterDataAMD (GLuint monitor, GLenum pname, GLsizei dataSize, GLuint *data, GLint *bytesWritten);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPerfMonitorCounterDataAMD(GLuint monitor, GLenum pname, GLsizei dataSize, GLuint* data, GLint* bytesWritten);
        private static TglGetPerfMonitorCounterDataAMD glGetPerfMonitorCounterDataAMD = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_texture_texture4 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_vertex_shader_tessellator
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTessellationFactorAMD (GLfloat factor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTessellationFactorAMD(GLfloat factor);
        private static TglTessellationFactorAMD glTessellationFactorAMD = null;

        // GLAPI void APIENTRY glTessellationModeAMD (GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTessellationModeAMD(GLenum mode);
        private static TglTessellationModeAMD glTessellationModeAMD = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_draw_buffers_blend
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendFuncIndexedAMD (GLuint buf, GLenum src, GLenum dst);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendFuncIndexedAMD(GLuint buf, GLenum src, GLenum dst);
        private static TglBlendFuncIndexedAMD glBlendFuncIndexedAMD = null;

        // GLAPI void APIENTRY glBlendFuncSeparateIndexedAMD (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendFuncSeparateIndexedAMD(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);
        private static TglBlendFuncSeparateIndexedAMD glBlendFuncSeparateIndexedAMD = null;

        // GLAPI void APIENTRY glBlendEquationIndexedAMD (GLuint buf, GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendEquationIndexedAMD(GLuint buf, GLenum mode);
        private static TglBlendEquationIndexedAMD glBlendEquationIndexedAMD = null;

        // GLAPI void APIENTRY glBlendEquationSeparateIndexedAMD (GLuint buf, GLenum modeRGB, GLenum modeAlpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendEquationSeparateIndexedAMD(GLuint buf, GLenum modeRGB, GLenum modeAlpha);
        private static TglBlendEquationSeparateIndexedAMD glBlendEquationSeparateIndexedAMD = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenNamesAMD(GLenum identifier, GLuint num, GLuint* names);
        private static TglGenNamesAMD glGenNamesAMD = null;

        // GLAPI void APIENTRY glDeleteNamesAMD (GLenum identifier, GLuint num, const GLuint *names);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteNamesAMD(GLenum identifier, GLuint num, GLuint* names);
        private static TglDeleteNamesAMD glDeleteNamesAMD = null;

        // GLAPI GLboolean APIENTRY glIsNameAMD (GLenum identifier, GLuint name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsNameAMD(GLenum identifier, GLuint name);
        private static TglIsNameAMD glIsNameAMD = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_debug_output
        ///////////////////////////////////////////////////////////////////////
        // typedef void (APIENTRY *GLDEBUGPROCAMD)(GLuint id,GLenum category,GLenum severity,GLsizei length,const GLchar *message,GLvoid *userParam);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void TCALLBACKglDebugProcAMD(GLuint id, GLenum category, GLenum severity, GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string message, void* userParam);

        // GLAPI void APIENTRY glDebugMessageEnableAMD (GLenum category, GLenum severity, GLsizei count, const GLuint *ids, GLboolean enabled);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDebugMessageEnableAMD(GLenum category, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled);
        private static TglDebugMessageEnableAMD glDebugMessageEnableAMD = null;

        // GLAPI void APIENTRY glDebugMessageInsertAMD (GLenum category, GLenum severity, GLuint id, GLsizei length, const GLchar *buf);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDebugMessageInsertAMD(GLenum category, GLenum severity, GLuint id, GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string buf);
        private static TglDebugMessageInsertAMD glDebugMessageInsertAMD = null;

        // GLAPI void APIENTRY glDebugMessageCallbackAMD (GLDEBUGPROCAMD callback, GLvoid *userParam);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDebugMessageCallbackAMD(TCALLBACKglDebugProcAMD callback, void* userParam);
        private static TglDebugMessageCallbackAMD glDebugMessageCallbackAMD = null;

        // GLAPI GLuint APIENTRY glGetDebugMessageLogAMD (GLuint count, GLsizei bufsize, GLenum *categories, GLuint *severities, GLuint *ids, GLsizei *lengths, GLchar *message);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLuint TglGetDebugMessageLogAMD(GLuint count, GLsizei bufsize, GLenum* categories, GLuint* severities, GLuint* ids, GLsizei* lengths, GLchar* message);
        private static TglGetDebugMessageLogAMD glGetDebugMessageLogAMD = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSetMultisamplefvAMD(GLenum pname, GLuint index, GLfloat* val);
        private static TglSetMultisamplefvAMD glSetMultisamplefvAMD = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_multi_draw_indirect
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMultiDrawArraysIndirectAMD (GLenum mode, const GLvoid *indirect, GLsizei primcount, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawArraysIndirectAMD(GLenum mode, void* indirect, GLsizei primcount, GLsizei stride);
        private static TglMultiDrawArraysIndirectAMD glMultiDrawArraysIndirectAMD = null;

        // GLAPI void APIENTRY glMultiDrawElementsIndirectAMD (GLenum mode, GLenum type, const GLvoid *indirect, GLsizei primcount, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawElementsIndirectAMD(GLenum mode, GLenum type, void* indirect, GLsizei primcount, GLsizei stride);
        private static TglMultiDrawElementsIndirectAMD glMultiDrawElementsIndirectAMD = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_pinned_memory (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_stencil_operation_extended
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glStencilOpValueAMD (GLenum face, GLuint value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStencilOpValueAMD(GLenum face, GLuint value);
        private static TglStencilOpValueAMD glStencilOpValueAMD = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexStorageSparseAMD(GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags);
        private static TglTexStorageSparseAMD glTexStorageSparseAMD = null;

        // GLAPI void APIENTRY glTextureStorageSparseAMD (GLuint texture, GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureStorageSparseAMD(GLuint texture, GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLsizei layers, GLbitfield flags);
        private static TglTextureStorageSparseAMD glTextureStorageSparseAMD = null;
        
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribParameteriAMD(GLuint index, GLenum pname, GLint param);
        private static TglVertexAttribParameteriAMD glVertexAttribParameteriAMD = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_occlusion_query_event
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glQueryObjectParameteruiAMD (GLenum target, GLuint id, GLenum pname, GLuint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglQueryObjectParameteruiAMD(GLenum target, GLuint id, GLenum pname, GLuint param);
        private static TglQueryObjectParameteruiAMD glQueryObjectParameteruiAMD = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_gcn_shader (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_gpu_shader_int64
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glUniform1i64NV (GLint location, GLint64EXT x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform1i64NV(GLint location, GLint64 x);
        private static TglUniform1i64NV glUniform1i64NV = null;

        // GLAPI void APIENTRY glUniform2i64NV (GLint location, GLint64EXT x, GLint64EXT y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform2i64NV(GLint location, GLint64 x, GLint64 y);
        private static TglUniform2i64NV glUniform2i64NV = null;
        
        // GLAPI void APIENTRY glUniform3i64NV (GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform3i64NV(GLint location, GLint64 x, GLint64 y, GLint64 z);
        private static TglUniform3i64NV glUniform3i64NV = null;

        // GLAPI void APIENTRY glUniform4i64NV (GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform4i64NV(GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w);
        private static TglUniform4i64NV glUniform4i64NV = null;

        // GLAPI void APIENTRY glUniform1i64vNV (GLint location, GLsizei count, const GLint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform1i64vNV(GLint location, GLsizei count, GLint64* value);
        private static TglUniform1i64vNV glUniform1i64vNV = null;

        // GLAPI void APIENTRY glUniform2i64vNV (GLint location, GLsizei count, const GLint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform2i64vNV(GLint location, GLsizei count, GLint64* value);
        private static TglUniform2i64vNV glUniform2i64vNV = null;

        // GLAPI void APIENTRY glUniform3i64vNV (GLint location, GLsizei count, const GLint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform3i64vNV(GLint location, GLsizei count, GLint64* value);
        private static TglUniform3i64vNV glUniform3i64vNV = null;

        // GLAPI void APIENTRY glUniform4i64vNV (GLint location, GLsizei count, const GLint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform4i64vNV(GLint location, GLsizei count, GLint64* value);
        private static TglUniform4i64vNV glUniform4i64vNV = null;

        // GLAPI void APIENTRY glUniform1ui64NV (GLint location, GLuint64EXT x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform1ui64NV(GLint location, GLuint64 x);
        private static TglUniform1ui64NV glUniform1ui64NV = null;

        // GLAPI void APIENTRY glUniform2ui64NV (GLint location, GLuint64EXT x, GLuint64EXT y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform2ui64NV(GLint location, GLuint64 x, GLuint64 y);
        private static TglUniform2ui64NV glUniform2ui64NV = null;

        // GLAPI void APIENTRY glUniform3ui64NV (GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform3ui64NV(GLint location, GLuint64 x, GLuint64 y, GLuint64 z);
        private static TglUniform3ui64NV glUniform3ui64NV = null;
        
        // GLAPI void APIENTRY glUniform4ui64NV (GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform4ui64NV(GLint location, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w);
        private static TglUniform4ui64NV glUniform4ui64NV = null;
        
        // GLAPI void APIENTRY glUniform1ui64vNV (GLint location, GLsizei count, const GLuint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform1ui64vNV(GLint location, GLsizei count, GLuint64* value);
        private static TglUniform1ui64vNV glUniform1ui64vNV = null;

        // GLAPI void APIENTRY glUniform2ui64vNV (GLint location, GLsizei count, const GLuint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform2ui64vNV(GLint location, GLsizei count, GLuint64* value);
        private static TglUniform2ui64vNV glUniform2ui64vNV = null;
        
        // GLAPI void APIENTRY glUniform3ui64vNV (GLint location, GLsizei count, const GLuint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform3ui64vNV(GLint location, GLsizei count, GLuint64* value);
        private static TglUniform3ui64vNV glUniform3ui64vNV = null;

        // GLAPI void APIENTRY glUniform4ui64vNV (GLint location, GLsizei count, const GLuint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform4ui64vNV(GLint location, GLsizei count, GLuint64* value);
        private static TglUniform4ui64vNV glUniform4ui64vNV = null;
        
        // GLAPI void APIENTRY glGetUniformi64vNV (GLuint program, GLint location, GLint64EXT *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformi64vNV(GLuint program, GLint location, GLint64* parameters);
        private static TglGetUniformi64vNV glGetUniformi64vNV = null;
        
        // GLAPI void APIENTRY glGetUniformui64vNV (GLuint program, GLint location, GLuint64EXT *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformui64vNV(GLuint program, GLint location, GLuint64* parameters);
        private static TglGetUniformui64vNV glGetUniformui64vNV = null;
        
        // GLAPI void APIENTRY glProgramUniform1i64NV (GLuint program, GLint location, GLint64EXT x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform1i64NV(GLuint program, GLint location, GLint64 x);
        private static TglProgramUniform1i64NV glProgramUniform1i64NV = null;
        
        // GLAPI void APIENTRY glProgramUniform2i64NV (GLuint program, GLint location, GLint64EXT x, GLint64EXT y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform2i64NV(GLuint program, GLint location, GLint64 x, GLint64 y);
        private static TglProgramUniform2i64NV glProgramUniform2i64NV = null;
        
        // GLAPI void APIENTRY glProgramUniform3i64NV (GLuint program, GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform3i64NV(GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z);
        private static TglProgramUniform3i64NV glProgramUniform3i64NV = null;

        // GLAPI void APIENTRY glProgramUniform4i64NV (GLuint program, GLint location, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform4i64NV(GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w);
        private static TglProgramUniform4i64NV glProgramUniform4i64NV = null;

        // GLAPI void APIENTRY glProgramUniform1i64vNV (GLuint program, GLint location, GLsizei count, const GLint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform1i64vNV(GLuint program, GLint location, GLsizei count, GLint64* value);
        private static TglProgramUniform1i64vNV glProgramUniform1i64vNV = null;

        // GLAPI void APIENTRY glProgramUniform2i64vNV (GLuint program, GLint location, GLsizei count, const GLint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform2i64vNV(GLuint program, GLint location, GLsizei count, GLint64* value);
        private static TglProgramUniform2i64vNV glProgramUniform2i64vNV = null;
        
        // GLAPI void APIENTRY glProgramUniform3i64vNV (GLuint program, GLint location, GLsizei count, const GLint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform3i64vNV(GLuint program, GLint location, GLsizei count, GLint64* value);
        private static TglProgramUniform3i64vNV glProgramUniform3i64vNV = null;
        
        // GLAPI void APIENTRY glProgramUniform4i64vNV (GLuint program, GLint location, GLsizei count, const GLint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform4i64vNV(GLuint program, GLint location, GLsizei count, GLint64* value);
        private static TglProgramUniform4i64vNV glProgramUniform4i64vNV = null;
        
        // GLAPI void APIENTRY glProgramUniform1ui64NV (GLuint program, GLint location, GLuint64EXT x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform1ui64NV(GLuint program, GLint location, GLuint64 x);
        private static TglProgramUniform1ui64NV glProgramUniform1ui64NV = null;
        
        // GLAPI void APIENTRY glProgramUniform2ui64NV (GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform2ui64NV(GLuint program, GLint location, GLuint64 x, GLuint64 y);
        private static TglProgramUniform2ui64NV glProgramUniform2ui64NV = null;
        
        // GLAPI void APIENTRY glProgramUniform3ui64NV (GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform3ui64NV(GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint64 z);
        private static TglProgramUniform3ui64NV glProgramUniform3ui64NV = null;
        
        // GLAPI void APIENTRY glProgramUniform4ui64NV (GLuint program, GLint location, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform4ui64NV(GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w);
        private static TglProgramUniform4ui64NV glProgramUniform4ui64NV = null;
        
        // GLAPI void APIENTRY glProgramUniform1ui64vNV (GLuint program, GLint location, GLsizei count, const GLuint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform1ui64vNV(GLuint program, GLint location, GLsizei count, GLuint64* value);
        private static TglProgramUniform1ui64vNV glProgramUniform1ui64vNV = null;

        // GLAPI void APIENTRY glProgramUniform2ui64vNV (GLuint program, GLint location, GLsizei count, const GLuint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform2ui64vNV(GLuint program, GLint location, GLsizei count, GLuint64* value);
        private static TglProgramUniform2ui64vNV glProgramUniform2ui64vNV = null;

        // GLAPI void APIENTRY glProgramUniform3ui64vNV (GLuint program, GLint location, GLsizei count, const GLuint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform3ui64vNV(GLuint program, GLint location, GLsizei count, GLuint64* value);
        private static TglProgramUniform3ui64vNV glProgramUniform3ui64vNV = null;
        
        // GLAPI void APIENTRY glProgramUniform4ui64vNV (GLuint program, GLint location, GLsizei count, const GLuint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform4ui64vNV(GLuint program, GLint location, GLsizei count, GLuint64* value);
        private static TglProgramUniform4ui64vNV glProgramUniform4ui64vNV = null;

		///////////////////////////////////////////////////////////////////////
		// GL_AMD_transform_feedback4 (no function entry points)
		///////////////////////////////////////////////////////////////////////
		
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_AMDX_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_AMDX_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_AMDX_vertex_shader_tessellator
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTessellationFactorAMDX (GLfloat factor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTessellationFactorAMDX(GLfloat factor);
        private static TglTessellationFactorAMDX glTessellationFactorAMDX = null;

        // GLAPI void APIENTRY glTessellationModeAMDX (GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTessellationModeAMDX(GLenum mode);
        private static TglTessellationModeAMDX glTessellationModeAMDX = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMDX_debug_output
        ///////////////////////////////////////////////////////////////////////
        // typedef void (APIENTRY *GLDEBUGPROCAMDX)(GLuint id,GLenum category,GLenum severity,GLsizei length,const GLchar *message,GLvoid *userParam);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void TCALLBACKglDebugProcAMDX(GLuint id, GLenum category, GLenum severity, GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string message, void* userParam);

        // GLAPI void APIENTRY glDebugMessageEnableAMDX (GLenum category, GLenum severity, GLsizei count, const GLuint *ids, GLboolean enabled);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDebugMessageEnableAMDX(GLenum category, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled);
        private static TglDebugMessageEnableAMDX glDebugMessageEnableAMDX = null;

        // GLAPI void APIENTRY glDebugMessageInsertAMDX (GLenum category, GLenum severity, GLuint id, GLsizei length, const GLchar *buf);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDebugMessageInsertAMDX(GLenum category, GLenum severity, GLuint id, GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string buf);
        private static TglDebugMessageInsertAMDX glDebugMessageInsertAMDX = null;

        // GLAPI void APIENTRY glDebugMessageCallbackAMDX (GLDEBUGPROCAMD callback, GLvoid *userParam);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDebugMessageCallbackAMDX(TCALLBACKglDebugProcAMD callback, void* userParam);
        private static TglDebugMessageCallbackAMDX glDebugMessageCallbackAMDX = null;

        // GLAPI GLuint APIENTRY glGetDebugMessageLogAMDX (GLuint count, GLsizei bufsize, GLenum *categories, GLuint *severities, GLuint *ids, GLsizei *lengths, GLchar *message);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLuint TglGetDebugMessageLogAMDX(GLuint count, GLsizei bufsize, GLenum* categories, GLuint* severities, GLuint* ids, GLsizei* lengths, GLchar* message);
        private static TglGetDebugMessageLogAMDX glGetDebugMessageLogAMDX = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_APPLE_xxx FUNCTIONS...
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglElementPointerAPPLE(GLenum type, void* pointer);
        private static TglElementPointerAPPLE glElementPointerAPPLE = null;

        // GLAPI void APIENTRY glDrawElementArrayAPPLE (GLenum mode, GLint first, GLsizei count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawElementArrayAPPLE(GLenum mode, GLint first, GLsizei count);
        private static TglDrawElementArrayAPPLE glDrawElementArrayAPPLE = null;

        // GLAPI void APIENTRY glDrawRangeElementArrayAPPLE (GLenum mode, GLuint start, GLuint end, GLint first, GLsizei count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawRangeElementArrayAPPLE(GLenum mode, GLuint start, GLuint end, GLint first, GLsizei count);
        private static TglDrawRangeElementArrayAPPLE glDrawRangeElementArrayAPPLE = null;

        // GLAPI void APIENTRY glMultiDrawElementArrayAPPLE (GLenum mode, const GLint *first, const GLsizei *count, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawElementArrayAPPLE(GLenum mode, GLint* first, GLsizei* count, GLsizei primcount);
        private static TglMultiDrawElementArrayAPPLE glMultiDrawElementArrayAPPLE = null;

        // GLAPI void APIENTRY glMultiDrawRangeElementArrayAPPLE (GLenum mode, GLuint start, GLuint end, const GLint *first, const GLsizei *count, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawRangeElementArrayAPPLE(GLenum mode, GLuint start, GLuint end, GLint* first, GLsizei* count, GLsizei primcount);
        private static TglMultiDrawRangeElementArrayAPPLE glMultiDrawRangeElementArrayAPPLE = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_fence
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGenFencesAPPLE (GLsizei n, GLuint *fences);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenFencesAPPLE(GLsizei n, GLuint* fences);
        private static TglGenFencesAPPLE glGenFencesAPPLE = null;

        // GLAPI void APIENTRY glDeleteFencesAPPLE (GLsizei n, const GLuint *fences);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteFencesAPPLE(GLsizei n, GLuint* fences);
        private static TglDeleteFencesAPPLE glDeleteFencesAPPLE = null;

        // GLAPI void APIENTRY glSetFenceAPPLE (GLuint fence);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSetFenceAPPLE(GLuint fence);
        private static TglSetFenceAPPLE glSetFenceAPPLE = null;

        // GLAPI GLboolean APIENTRY glIsFenceAPPLE (GLuint fence);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsFenceAPPLE(GLuint fence);
        private static TglIsFenceAPPLE glIsFenceAPPLE = null;

        // GLAPI GLboolean APIENTRY glTestFenceAPPLE (GLuint fence);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglTestFenceAPPLE(GLuint fence);
        private static TglTestFenceAPPLE glTestFenceAPPLE = null;

        // GLAPI void APIENTRY glFinishFenceAPPLE (GLuint fence);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFinishFenceAPPLE(GLuint fence);
        private static TglFinishFenceAPPLE glFinishFenceAPPLE = null;

        // GLAPI GLboolean APIENTRY glTestObjectAPPLE (GLenum object, GLuint name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglTestObjectAPPLE(GLenum obj, GLuint name);
        private static TglTestObjectAPPLE glTestObjectAPPLE = null;

        // GLAPI void APIENTRY glFinishObjectAPPLE (GLenum object, GLint name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFinishObjectAPPLE(GLenum obj, GLint name);
        private static TglFinishObjectAPPLE glFinishObjectAPPLE = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_vertex_array_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBindVertexArrayAPPLE (GLuint array);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindVertexArrayAPPLE(GLuint array);
        private static TglBindVertexArrayAPPLE glBindVertexArrayAPPLE = null;

        // GLAPI void APIENTRY glDeleteVertexArraysAPPLE (GLsizei n, const GLuint *arrays);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteVertexArraysAPPLE(GLsizei n, GLuint* arrays);
        private static TglDeleteVertexArraysAPPLE glDeleteVertexArraysAPPLE = null;

        // GLAPI void APIENTRY glGenVertexArraysAPPLE (GLsizei n, GLuint *arrays);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenVertexArraysAPPLE(GLsizei n, GLuint* arrays);
        private static TglGenVertexArraysAPPLE glGenVertexArraysAPPLE = null;

        // GLAPI GLboolean APIENTRY glIsVertexArrayAPPLE (GLuint array);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsVertexArrayAPPLE(GLuint array);
        private static TglIsVertexArrayAPPLE glIsVertexArrayAPPLE = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_vertex_array_range
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexArrayRangeAPPLE (GLsizei length, GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexArrayRangeAPPLE(GLsizei length, void* pointer);
        private static TglVertexArrayRangeAPPLE glVertexArrayRangeAPPLE = null;

        // GLAPI void APIENTRY glFlushVertexArrayRangeAPPLE (GLsizei length, GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFlushVertexArrayRangeAPPLE(GLsizei length, void* pointer);
        private static TglFlushVertexArrayRangeAPPLE glFlushVertexArrayRangeAPPLE = null;

        // GLAPI void APIENTRY glVertexArrayParameteriAPPLE (GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayParameteriAPPLE(GLenum pname, GLint param);
        private static TglVertexArrayParameteriAPPLE glVertexArrayParameteriAPPLE = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_ycbcr_422 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_flush_buffer_range
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBufferParameteriAPPLE (GLenum target, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBufferParameteriAPPLE(GLenum target, GLenum pname, GLint param);
        private static TglBufferParameteriAPPLE glBufferParameteriAPPLE = null;

        // GLAPI void APIENTRY glFlushMappedBufferRangeAPPLE (GLenum target, GLintptr offset, GLsizeiptr size);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFlushMappedBufferRangeAPPLE(GLenum target, GLintptr offset, GLsizeiptr size);
        private static TglFlushMappedBufferRangeAPPLE glFlushMappedBufferRangeAPPLE = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_texture_range
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTextureRangeAPPLE (GLenum target, GLsizei length, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureRangeAPPLE(GLenum target, GLsizei length, void* pointer);
        private static TglTextureRangeAPPLE glTextureRangeAPPLE = null;

        // GLAPI void APIENTRY glGetTexParameterPointervAPPLE (GLenum target, GLenum pname, GLvoid* *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexParameterPointervAPPLE(GLenum target, GLenum pname, void** parameters);
        private static TglGetTexParameterPointervAPPLE glGetTexParameterPointervAPPLE = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_float_pixels (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_vertex_program_evaluators
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glEnableVertexAttribAPPLE (GLuint index, GLenum pname);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEnableVertexAttribAPPLE(GLuint index, GLenum pname);
        private static TglEnableVertexAttribAPPLE glEnableVertexAttribAPPLE = null;

        // GLAPI void APIENTRY glDisableVertexAttribAPPLE (GLuint index, GLenum pname);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDisableVertexAttribAPPLE(GLuint index, GLenum pname);
        private static TglDisableVertexAttribAPPLE glDisableVertexAttribAPPLE = null;

        // GLAPI GLboolean APIENTRY glIsVertexAttribEnabledAPPLE (GLuint index, GLenum pname);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsVertexAttribEnabledAPPLE(GLuint index, GLenum pname);
        private static TglIsVertexAttribEnabledAPPLE glIsVertexAttribEnabledAPPLE = null;

        // GLAPI void APIENTRY glMapVertexAttrib1dAPPLE (GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint stride, GLint order, const GLdouble *points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMapVertexAttrib1dAPPLE(GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble* points);
        private static TglMapVertexAttrib1dAPPLE glMapVertexAttrib1dAPPLE = null;

        // GLAPI void APIENTRY glMapVertexAttrib1fAPPLE (GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint stride, GLint order, const GLfloat *points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMapVertexAttrib1fAPPLE(GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat* points);
        private static TglMapVertexAttrib1fAPPLE glMapVertexAttrib1fAPPLE = null;

        // GLAPI void APIENTRY glMapVertexAttrib2dAPPLE (GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, const GLdouble *points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMapVertexAttrib2dAPPLE(GLuint index, GLuint size, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble* points);
        private static TglMapVertexAttrib2dAPPLE glMapVertexAttrib2dAPPLE = null;

        // GLAPI void APIENTRY glMapVertexAttrib2fAPPLE (GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, const GLfloat *points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMapVertexAttrib2fAPPLE(GLuint index, GLuint size, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat* points);
        private static TglMapVertexAttrib2fAPPLE glMapVertexAttrib2fAPPLE = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_aux_depth_stencil (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_object_purgeable
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLenum APIENTRY glObjectPurgeableAPPLE (GLenum objectType, GLuint name, GLenum option);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLenum TglObjectPurgeableAPPLE(GLenum objectType, GLuint name, GLenum option);
        private static TglObjectPurgeableAPPLE glObjectPurgeableAPPLE = null;

        // GLAPI GLenum APIENTRY glObjectUnpurgeableAPPLE (GLenum objectType, GLuint name, GLenum option);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLenum TglObjectUnpurgeableAPPLE(GLenum objectType, GLuint name, GLenum option);
        private static TglObjectUnpurgeableAPPLE glObjectUnpurgeableAPPLE = null;

        // GLAPI void APIENTRY glGetObjectParameterivAPPLE (GLenum objectType, GLuint name, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetObjectParameterivAPPLE(GLenum objectType, GLuint name, GLenum pname, GLint* parameters);
        private static TglGetObjectParameterivAPPLE glGetObjectParameterivAPPLE = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_row_bytes (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_rgb_422 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_ARB_xxx FUNCTIONS...
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglActiveTextureARB(GLenum texture);
        private static TglActiveTextureARB glActiveTextureARB = null;

        // GLAPI void APIENTRY glClientActiveTextureARB (GLenum texture);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClientActiveTextureARB(GLenum texture);
        private static TglClientActiveTextureARB glClientActiveTextureARB = null;

        // GLAPI void APIENTRY glMultiTexCoord1dARB (GLenum target, GLdouble s);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord1dARB(GLenum target, GLdouble s);
        private static TglMultiTexCoord1dARB glMultiTexCoord1dARB = null;

        // GLAPI void APIENTRY glMultiTexCoord1dvARB (GLenum target, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord1dvARB(GLenum target, GLdouble* v);
        private static TglMultiTexCoord1dvARB glMultiTexCoord1dvARB = null;

        // GLAPI void APIENTRY glMultiTexCoord1fARB (GLenum target, GLfloat s);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord1fARB(GLenum target, GLfloat s);
        private static TglMultiTexCoord1fARB glMultiTexCoord1fARB = null;

        // GLAPI void APIENTRY glMultiTexCoord1fvARB (GLenum target, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord1fvARB(GLenum target, GLfloat* v);
        private static TglMultiTexCoord1fvARB glMultiTexCoord1fvARB = null;

        // GLAPI void APIENTRY glMultiTexCoord1iARB (GLenum target, GLint s);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord1iARB(GLenum target, GLint s);
        private static TglMultiTexCoord1iARB glMultiTexCoord1iARB = null;

        // GLAPI void APIENTRY glMultiTexCoord1ivARB (GLenum target, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord1ivARB(GLenum target, GLint* v);
        private static TglMultiTexCoord1ivARB glMultiTexCoord1ivARB = null;

        // GLAPI void APIENTRY glMultiTexCoord1sARB (GLenum target, GLshort s);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord1sARB(GLenum target, GLshort s);
        private static TglMultiTexCoord1sARB glMultiTexCoord1sARB = null;

        // GLAPI void APIENTRY glMultiTexCoord1svARB (GLenum target, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord1svARB(GLenum target, GLshort* v);
        private static TglMultiTexCoord1svARB glMultiTexCoord1svARB = null;

        // GLAPI void APIENTRY glMultiTexCoord2dARB (GLenum target, GLdouble s, GLdouble t);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord2dARB(GLenum target, GLdouble s, GLdouble t);
        private static TglMultiTexCoord2dARB glMultiTexCoord2dARB = null;

        // GLAPI void APIENTRY glMultiTexCoord2dvARB (GLenum target, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord2dvARB(GLenum target, GLdouble* v);
        private static TglMultiTexCoord2dvARB glMultiTexCoord2dvARB = null;

        // GLAPI void APIENTRY glMultiTexCoord2fARB (GLenum target, GLfloat s, GLfloat t);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord2fARB(GLenum target, GLfloat s, GLfloat t);
        private static TglMultiTexCoord2fARB glMultiTexCoord2fARB = null;

        // GLAPI void APIENTRY glMultiTexCoord2fvARB (GLenum target, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord2fvARB(GLenum target, GLfloat* v);
        private static TglMultiTexCoord2fvARB glMultiTexCoord2fvARB = null;

        // GLAPI void APIENTRY glMultiTexCoord2iARB (GLenum target, GLint s, GLint t);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord2iARB(GLenum target, GLint s, GLint t);
        private static TglMultiTexCoord2iARB glMultiTexCoord2iARB = null;

        // GLAPI void APIENTRY glMultiTexCoord2ivARB (GLenum target, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord2ivARB(GLenum target, GLint* v);
        private static TglMultiTexCoord2ivARB glMultiTexCoord2ivARB = null;

        // GLAPI void APIENTRY glMultiTexCoord2sARB (GLenum target, GLshort s, GLshort t);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord2sARB(GLenum target, GLshort s, GLshort t);
        private static TglMultiTexCoord2sARB glMultiTexCoord2sARB = null;

        // GLAPI void APIENTRY glMultiTexCoord2svARB (GLenum target, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord2svARB(GLenum target, GLshort* v);
        private static TglMultiTexCoord2svARB glMultiTexCoord2svARB = null;

        // GLAPI void APIENTRY glMultiTexCoord3dARB (GLenum target, GLdouble s, GLdouble t, GLdouble r);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord3dARB(GLenum target, GLdouble s, GLdouble t, GLdouble r);
        private static TglMultiTexCoord3dARB glMultiTexCoord3dARB = null;

        // GLAPI void APIENTRY glMultiTexCoord3dvARB (GLenum target, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord3dvARB(GLenum target, GLdouble* v);
        private static TglMultiTexCoord3dvARB glMultiTexCoord3dvARB = null;

        // GLAPI void APIENTRY glMultiTexCoord3fARB (GLenum target, GLfloat s, GLfloat t, GLfloat r);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord3fARB(GLenum target, GLfloat s, GLfloat t, GLfloat r);
        private static TglMultiTexCoord3fARB glMultiTexCoord3fARB = null;

        // GLAPI void APIENTRY glMultiTexCoord3fvARB (GLenum target, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord3fvARB(GLenum target, GLfloat* v);
        private static TglMultiTexCoord3fvARB glMultiTexCoord3fvARB = null;

        // GLAPI void APIENTRY glMultiTexCoord3iARB (GLenum target, GLint s, GLint t, GLint r);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord3iARB(GLenum target, GLint s, GLint t, GLint r);
        private static TglMultiTexCoord3iARB glMultiTexCoord3iARB = null;

        // GLAPI void APIENTRY glMultiTexCoord3ivARB (GLenum target, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord3ivARB(GLenum target, GLint* v);
        private static TglMultiTexCoord3ivARB glMultiTexCoord3ivARB = null;

        // GLAPI void APIENTRY glMultiTexCoord3sARB (GLenum target, GLshort s, GLshort t, GLshort r);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord3sARB(GLenum target, GLshort s, GLshort t, GLshort r);
        private static TglMultiTexCoord3sARB glMultiTexCoord3sARB = null;

        // GLAPI void APIENTRY glMultiTexCoord3svARB (GLenum target, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord3svARB(GLenum target, GLshort* v);
        private static TglMultiTexCoord3svARB glMultiTexCoord3svARB = null;

        // GLAPI void APIENTRY glMultiTexCoord4dARB (GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord4dARB(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
        private static TglMultiTexCoord4dARB glMultiTexCoord4dARB = null;

        // GLAPI void APIENTRY glMultiTexCoord4dvARB (GLenum target, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord4dvARB(GLenum target, GLdouble* v);
        private static TglMultiTexCoord4dvARB glMultiTexCoord4dvARB = null;

        // GLAPI void APIENTRY glMultiTexCoord4fARB (GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord4fARB(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
        private static TglMultiTexCoord4fARB glMultiTexCoord4fARB = null;

        // GLAPI void APIENTRY glMultiTexCoord4fvARB (GLenum target, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord4fvARB(GLenum target, GLfloat* v);
        private static TglMultiTexCoord4fvARB glMultiTexCoord4fvARB = null;

        // GLAPI void APIENTRY glMultiTexCoord4iARB (GLenum target, GLint s, GLint t, GLint r, GLint q);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord4iARB(GLenum target, GLint s, GLint t, GLint r, GLint q);
        private static TglMultiTexCoord4iARB glMultiTexCoord4iARB = null;

        // GLAPI void APIENTRY glMultiTexCoord4ivARB (GLenum target, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord4ivARB(GLenum target, GLint* v);
        private static TglMultiTexCoord4ivARB glMultiTexCoord4ivARB = null;

        // GLAPI void APIENTRY glMultiTexCoord4sARB (GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord4sARB(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);
        private static TglMultiTexCoord4sARB glMultiTexCoord4sARB = null;

        // GLAPI void APIENTRY glMultiTexCoord4svARB (GLenum target, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord4svARB(GLenum target, GLshort* v);
        private static TglMultiTexCoord4svARB glMultiTexCoord4svARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_transpose_matrix
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glLoadTransposeMatrixfARB (const GLfloat *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLoadTransposeMatrixfARB(GLfloat* m);
        private static TglLoadTransposeMatrixfARB glLoadTransposeMatrixfARB = null;

        // GLAPI void APIENTRY glLoadTransposeMatrixdARB (const GLdouble *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLoadTransposeMatrixdARB(GLdouble* m);
        private static TglLoadTransposeMatrixdARB glLoadTransposeMatrixdARB = null;

        // GLAPI void APIENTRY glMultTransposeMatrixfARB (const GLfloat *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultTransposeMatrixfARB(GLfloat* m);
        private static TglMultTransposeMatrixfARB glMultTransposeMatrixfARB = null;

        // GLAPI void APIENTRY glMultTransposeMatrixdARB (const GLdouble *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultTransposeMatrixdARB(GLdouble* m);
        private static TglMultTransposeMatrixdARB glMultTransposeMatrixdARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_multisample
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glSampleCoverageARB (GLfloat value, GLboolean invert);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSampleCoverageARB(GLfloat value, GLboolean invert);
        private static TglSampleCoverageARB glSampleCoverageARB = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTexImage3DARB(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data);
        private static TglCompressedTexImage3DARB glCompressedTexImage3DARB = null;

        // GLAPI void APIENTRY glCompressedTexImage2DARB (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, const GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTexImage2DARB(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data);
        private static TglCompressedTexImage2DARB glCompressedTexImage2DARB = null;

        // GLAPI void APIENTRY glCompressedTexImage1DARB (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, const GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTexImage1DARB(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data);
        private static TglCompressedTexImage1DARB glCompressedTexImage1DARB = null;

        // GLAPI void APIENTRY glCompressedTexSubImage3DARB (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTexSubImage3DARB(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei hegiht, GLsizei depth, GLenum format, GLsizei imageSize, void* data);
        private static TglCompressedTexSubImage3DARB glCompressedTexSubImage3DARB = null;

        // GLAPI void APIENTRY glCompressedTexSubImage2DARB (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTexSubImage2DARB(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data);
        private static TglCompressedTexSubImage2DARB glCompressedTexSubImage2DARB = null;

        // GLAPI void APIENTRY glCompressedTexSubImage1DARB (GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, const GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTexSubImage1DARB(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data);
        private static TglCompressedTexSubImage1DARB glCompressedTexSubImage1DARB = null;

        // GLAPI void APIENTRY glGetCompressedTexImageARB (GLenum target, GLint level, GLvoid *img);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetCompressedTexImageARB(GLenum target, GLint level, void* img);
        private static TglGetCompressedTexImageARB glGetCompressedTexImageARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_border_clamp (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_point_parameters
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPointParameterfARB (GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPointParameterfARB(GLenum pname, GLfloat param);
        private static TglPointParameterfARB glPointParameterfARB = null;

        // GLAPI void APIENTRY glPointParameterfvARB (GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPointParameterfvARB(GLenum pname, GLfloat* paramaters);
        private static TglPointParameterfvARB glPointParameterfvARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_precision (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_blend
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glWeightbvARB (GLint size, const GLbyte *weights);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWeightbvARB(GLint size, GLbyte* weights);
        private static TglWeightbvARB glWeightbvARB = null;

        // GLAPI void APIENTRY glWeightsvARB (GLint size, const GLshort *weights);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWeightsvARB(GLint size, GLshort* weights);
        private static TglWeightsvARB glWeightsvARB = null;

        // GLAPI void APIENTRY glWeightivARB (GLint size, const GLint *weights);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWeightivARB(GLint size, GLint* weights);
        private static TglWeightivARB glWeightivARB = null;

        // GLAPI void APIENTRY glWeightfvARB (GLint size, const GLfloat *weights);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWeightfvARB(GLint size, GLfloat* weights);
        private static TglWeightfvARB glWeightfvARB = null;

        // GLAPI void APIENTRY glWeightdvARB (GLint size, const GLdouble *weights);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWeightdvARB(GLint size, GLdouble* weights);
        private static TglWeightdvARB glWeightdvARB = null;

        // GLAPI void APIENTRY glWeightubvARB (GLint size, const GLubyte *weights);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWeightubvARB(GLint size, GLubyte* weights);
        private static TglWeightubvARB glWeightubvARB = null;

        // GLAPI void APIENTRY glWeightusvARB (GLint size, const GLushort *weights);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWeightusvARB(GLint size, GLushort* weights);
        private static TglWeightusvARB glWeightusvARB = null;

        // GLAPI void APIENTRY glWeightuivARB (GLint size, const GLuint *weights);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWeightuivARB(GLint size, GLuint* weights);
        private static TglWeightuivARB glWeightuivARB = null;

        // GLAPI void APIENTRY glWeightPointerARB (GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWeightPointerARB(GLint size, GLenum type, GLsizei stride, void* pointer);
        private static TglWeightPointerARB glWeightPointerARB = null;

        // GLAPI void APIENTRY glVertexBlendARB (GLint count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexBlendARB(GLint count);
        private static TglVertexBlendARB glVertexBlendARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_matrix_palette
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCurrentPaletteMatrixARB (GLint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCurrentPaletteMatrixARB(GLint index);
        private static TglCurrentPaletteMatrixARB glCurrentPaletteMatrixARB = null;

        // GLAPI void APIENTRY glMatrixIndexubvARB (GLint size, const GLubyte *indices);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMatrixIndexubvARB(GLint size, GLubyte* indices);
        private static TglMatrixIndexubvARB glMatrixIndexubvARB = null;

        // GLAPI void APIENTRY glMatrixIndexusvARB (GLint size, const GLushort *indices);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMatrixIndexusvARB(GLint size, GLushort* indices);
        private static TglMatrixIndexusvARB glMatrixIndexusvARB = null;

        // GLAPI void APIENTRY glMatrixIndexuivARB (GLint size, const GLuint *indices);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMatrixIndexuivARB(GLint size, GLuint* indices);
        private static TglMatrixIndexuivARB glMatrixIndexuivARB = null;

        // GLAPI void APIENTRY glMatrixIndexPointerARB (GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMatrixIndexPointerARB(GLint size, GLenum type, GLsizei stride, void* pointer);
        private static TglMatrixIndexPointerARB glMatrixIndexPointerARB = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos2dARB(GLdouble x, GLdouble y);
        private static TglWindowPos2dARB glWindowPos2dARB = null;

        // GLAPI void APIENTRY glWindowPos2dvARB (const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos2dvARB(GLdouble* v);
        private static TglWindowPos2dvARB glWindowPos2dvARB = null;

        // GLAPI void APIENTRY glWindowPos2fARB (GLfloat x, GLfloat y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos2fARB(GLfloat x, GLfloat y);
        private static TglWindowPos2fARB glWindowPos2fARB = null;

        // GLAPI void APIENTRY glWindowPos2fvARB (const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos2fvARB(GLfloat* v);
        private static TglWindowPos2fvARB glWindowPos2fvARB = null;

        // GLAPI void APIENTRY glWindowPos2iARB (GLint x, GLint y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos2iARB(GLint x, GLint y);
        private static TglWindowPos2iARB glWindowPos2iARB = null;

        // GLAPI void APIENTRY glWindowPos2ivARB (const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos2ivARB(GLint* v);
        private static TglWindowPos2ivARB glWindowPos2ivARB = null;

        // GLAPI void APIENTRY glWindowPos2sARB (GLshort x, GLshort y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos2sARB(GLshort x, GLshort y);
        private static TglWindowPos2sARB glWindowPos2sARB = null;

        // GLAPI void APIENTRY glWindowPos2svARB (const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos2svARB(GLshort* v);
        private static TglWindowPos2svARB glWindowPos2svARB = null;

        // GLAPI void APIENTRY glWindowPos3dARB (GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos3dARB(GLdouble x, GLdouble y, GLdouble z);
        private static TglWindowPos3dARB glWindowPos3dARB = null;

        // GLAPI void APIENTRY glWindowPos3dvARB (const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos3dvARB(GLdouble* v);
        private static TglWindowPos3dvARB glWindowPos3dvARB = null;

        // GLAPI void APIENTRY glWindowPos3fARB (GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos3fARB(GLfloat x, GLfloat y, GLfloat z);
        private static TglWindowPos3fARB glWindowPos3fARB = null;

        // GLAPI void APIENTRY glWindowPos3fvARB (const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos3fvARB(GLfloat* v);
        private static TglWindowPos3fvARB glWindowPos3fvARB = null;

        // GLAPI void APIENTRY glWindowPos3iARB (GLint x, GLint y, GLint z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos3iARB(GLint x, GLint y, GLint z);
        private static TglWindowPos3iARB glWindowPos3iARB = null;

        // GLAPI void APIENTRY glWindowPos3ivARB (const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos3ivARB(GLint* v);
        private static TglWindowPos3ivARB glWindowPos3ivARB = null;

        // GLAPI void APIENTRY glWindowPos3sARB (GLshort x, GLshort y, GLshort z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos3sARB(GLshort x, GLshort y, GLshort z);
        private static TglWindowPos3sARB glWindowPos3sARB = null;

        // GLAPI void APIENTRY glWindowPos3svARB (const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos3svARB(GLshort* v);
        private static TglWindowPos3svARB glWindowPos3svARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_program
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexAttrib1dARB (GLuint index, GLdouble x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib1dARB(GLuint index, GLdouble x);
        private static TglVertexAttrib1dARB glVertexAttrib1dARB = null;

        // GLAPI void APIENTRY glVertexAttrib1dvARB (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib1dvARB(GLuint index, GLdouble* v);
        private static TglVertexAttrib1dvARB glVertexAttrib1dvARB = null;

        // GLAPI void APIENTRY glVertexAttrib1fARB (GLuint index, GLfloat x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib1fARB(GLuint index, GLfloat x);
        private static TglVertexAttrib1fARB glVertexAttrib1fARB = null;

        // GLAPI void APIENTRY glVertexAttrib1fvARB (GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib1fvARB(GLuint index, GLfloat* v);
        private static TglVertexAttrib1fvARB glVertexAttrib1fvARB = null;

        // GLAPI void APIENTRY glVertexAttrib1sARB (GLuint index, GLshort x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib1sARB(GLuint index, GLshort x);
        private static TglVertexAttrib1sARB glVertexAttrib1sARB = null;

        // GLAPI void APIENTRY glVertexAttrib1svARB (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib1svARB(GLuint index, GLshort* v);
        private static TglVertexAttrib1svARB glVertexAttrib1svARB = null;

        // GLAPI void APIENTRY glVertexAttrib2dARB (GLuint index, GLdouble x, GLdouble y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib2dARB(GLuint index, GLdouble x, GLdouble y);
        private static TglVertexAttrib2dARB glVertexAttrib2dARB = null;

        // GLAPI void APIENTRY glVertexAttrib2dvARB (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib2dvARB(GLuint index, GLdouble* v);
        private static TglVertexAttrib2dvARB glVertexAttrib2dvARB = null;

        // GLAPI void APIENTRY glVertexAttrib2fARB (GLuint index, GLfloat x, GLfloat y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib2fARB(GLuint index, GLfloat x, GLfloat y);
        private static TglVertexAttrib2fARB glVertexAttrib2fARB = null;

        // GLAPI void APIENTRY glVertexAttrib2fvARB (GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib2fvARB(GLuint index, GLfloat* v);
        private static TglVertexAttrib2fvARB glVertexAttrib2fvARB = null;

        // GLAPI void APIENTRY glVertexAttrib2sARB (GLuint index, GLshort x, GLshort y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib2sARB(GLuint index, GLshort x, GLshort y);
        private static TglVertexAttrib2sARB glVertexAttrib2sARB = null;

        // GLAPI void APIENTRY glVertexAttrib2svARB (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib2svARB(GLuint index, GLshort* v);
        private static TglVertexAttrib2svARB glVertexAttrib2svARB = null;

        // GLAPI void APIENTRY glVertexAttrib3dARB (GLuint index, GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib3dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z);
        private static TglVertexAttrib3dARB glVertexAttrib3dARB = null;

        // GLAPI void APIENTRY glVertexAttrib3dvARB (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib3dvARB(GLuint index, GLdouble* v);
        private static TglVertexAttrib3dvARB glVertexAttrib3dvARB = null;

        // GLAPI void APIENTRY glVertexAttrib3fARB (GLuint index, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib3fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z);
        private static TglVertexAttrib3fARB glVertexAttrib3fARB = null;

        // GLAPI void APIENTRY glVertexAttrib3fvARB (GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib3fvARB(GLuint index, GLfloat* v);
        private static TglVertexAttrib3fvARB glVertexAttrib3fvARB = null;

        // GLAPI void APIENTRY glVertexAttrib3sARB (GLuint index, GLshort x, GLshort y, GLshort z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib3sARB(GLuint index, GLshort x, GLshort y, GLshort z);
        private static TglVertexAttrib3sARB glVertexAttrib3sARB = null;

        // GLAPI void APIENTRY glVertexAttrib3svARB (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib3svARB(GLuint index, GLshort* v);
        private static TglVertexAttrib3svARB glVertexAttrib3svARB = null;

        // GLAPI void APIENTRY glVertexAttrib4NbvARB (GLuint index, const GLbyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4NbvARB(GLuint index, GLbyte* v);
        private static TglVertexAttrib4NbvARB glVertexAttrib4NbvARB = null;

        // GLAPI void APIENTRY glVertexAttrib4NivARB (GLuint index, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4NivARB(GLuint index, GLint* v);
        private static TglVertexAttrib4NivARB glVertexAttrib4NivARB = null;

        // GLAPI void APIENTRY glVertexAttrib4NsvARB (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4NsvARB(GLuint index, GLshort* v);
        private static TglVertexAttrib4NsvARB glVertexAttrib4NsvARB = null;

        // GLAPI void APIENTRY glVertexAttrib4NubARB (GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib4NubARB(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        private static TglVertexAttrib4NubARB glVertexAttrib4NubARB = null;

        // GLAPI void APIENTRY glVertexAttrib4NubvARB (GLuint index, const GLubyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4NubvARB(GLuint index, GLubyte* v);
        private static TglVertexAttrib4NubvARB glVertexAttrib4NubvARB = null;

        // GLAPI void APIENTRY glVertexAttrib4NuivARB (GLuint index, const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4NuivARB(GLuint index, GLuint* v);
        private static TglVertexAttrib4NuivARB glVertexAttrib4NuivARB = null;

        // GLAPI void APIENTRY glVertexAttrib4NusvARB (GLuint index, const GLushort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4NusvARB(GLuint index, GLushort* v);
        private static TglVertexAttrib4NusvARB glVertexAttrib4NusvARB = null;

        // GLAPI void APIENTRY glVertexAttrib4bvARB (GLuint index, const GLbyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4bvARB(GLuint index, GLbyte* v);
        private static TglVertexAttrib4bvARB glVertexAttrib4bvARB = null;

        // GLAPI void APIENTRY glVertexAttrib4dARB (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib4dARB(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglVertexAttrib4dARB glVertexAttrib4dARB = null;

        // GLAPI void APIENTRY glVertexAttrib4dvARB (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4dvARB(GLuint index, GLdouble* v);
        private static TglVertexAttrib4dvARB glVertexAttrib4dvARB = null;

        // GLAPI void APIENTRY glVertexAttrib4fARB (GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib4fARB(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglVertexAttrib4fARB glVertexAttrib4fARB = null;

        // GLAPI void APIENTRY glVertexAttrib4fvARB (GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4fvARB(GLuint index, GLfloat* v);
        private static TglVertexAttrib4fvARB glVertexAttrib4fvARB = null;

        // GLAPI void APIENTRY glVertexAttrib4ivARB (GLuint index, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4ivARB(GLuint index, GLint* v);
        private static TglVertexAttrib4ivARB glVertexAttrib4ivARB = null;

        // GLAPI void APIENTRY glVertexAttrib4sARB (GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib4sARB(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        private static TglVertexAttrib4sARB glVertexAttrib4sARB = null;

        // GLAPI void APIENTRY glVertexAttrib4svARB (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4svARB(GLuint index, GLshort* v);
        private static TglVertexAttrib4svARB glVertexAttrib4svARB = null;

        // GLAPI void APIENTRY glVertexAttrib4ubvARB (GLuint index, const GLubyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4ubvARB(GLuint index, GLubyte* v);
        private static TglVertexAttrib4ubvARB glVertexAttrib4ubvARB = null;

        // GLAPI void APIENTRY glVertexAttrib4uivARB (GLuint index, const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4uivARB(GLuint index, GLuint* v);
        private static TglVertexAttrib4uivARB glVertexAttrib4uivARB = null;

        // GLAPI void APIENTRY glVertexAttrib4usvARB (GLuint index, const GLushort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4usvARB(GLuint index, GLushort* v);
        private static TglVertexAttrib4usvARB glVertexAttrib4usvARB = null;

        // GLAPI void APIENTRY glVertexAttribPointerARB (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribPointerARB(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, void* pointer);
        private static TglVertexAttribPointerARB glVertexAttribPointerARB = null;

        // GLAPI void APIENTRY glEnableVertexAttribArrayARB (GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEnableVertexAttribArrayARB(GLuint index);
        private static TglEnableVertexAttribArrayARB glEnableVertexAttribArrayARB = null;

        // GLAPI void APIENTRY glDisableVertexAttribArrayARB (GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDisableVertexAttribArrayARB(GLuint index);
        private static TglDisableVertexAttribArrayARB glDisableVertexAttribArrayARB = null;

        // GLAPI void APIENTRY glProgramStringARB (GLenum target, GLenum format, GLsizei len, const GLvoid *string);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramStringARB(GLenum target, GLenum format, GLsizei len, void* programstring);
        private static TglProgramStringARB glProgramStringARB = null;

        // GLAPI void APIENTRY glBindProgramARB (GLenum target, GLuint program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindProgramARB(GLenum target, GLuint program);
        private static TglBindProgramARB glBindProgramARB = null;

        // GLAPI void APIENTRY glDeleteProgramsARB (GLsizei n, const GLuint *programs);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteProgramsARB(GLsizei n, GLuint* programs);
        private static TglDeleteProgramsARB glDeleteProgramsARB = null;

        // GLAPI void APIENTRY glGenProgramsARB (GLsizei n, GLuint *programs);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenProgramsARB(GLsizei n, GLuint* programs);
        private static TglGenProgramsARB glGenProgramsARB = null;

        // GLAPI void APIENTRY glProgramEnvParameter4dARB (GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramEnvParameter4dARB(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglProgramEnvParameter4dARB glProgramEnvParameter4dARB = null;

        // GLAPI void APIENTRY glProgramEnvParameter4dvARB (GLenum target, GLuint index, const GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramEnvParameter4dvARB(GLenum target, GLuint index, GLdouble* parameters);
        private static TglProgramEnvParameter4dvARB glProgramEnvParameter4dvARB = null;

        // GLAPI void APIENTRY glProgramEnvParameter4fARB (GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramEnvParameter4fARB(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglProgramEnvParameter4fARB glProgramEnvParameter4fARB = null;

        // GLAPI void APIENTRY glProgramEnvParameter4fvARB (GLenum target, GLuint index, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramEnvParameter4fvARB(GLenum target, GLuint index, GLfloat* parameters);
        private static TglProgramEnvParameter4fvARB glProgramEnvParameter4fvARB = null;

        // GLAPI void APIENTRY glProgramLocalParameter4dARB (GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramLocalParameter4dARB(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglProgramLocalParameter4dARB glProgramLocalParameter4dARB = null;

        // GLAPI void APIENTRY glProgramLocalParameter4dvARB (GLenum target, GLuint index, const GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramLocalParameter4dvARB(GLenum target, GLuint index, GLdouble* parameters);
        private static TglProgramLocalParameter4dvARB glProgramLocalParameter4dvARB = null;

        // GLAPI void APIENTRY glProgramLocalParameter4fARB (GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramLocalParameter4fARB(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglProgramLocalParameter4fARB glProgramLocalParameter4fARB = null;

        // GLAPI void APIENTRY glProgramLocalParameter4fvARB (GLenum target, GLuint index, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramLocalParameter4fvARB(GLenum target, GLuint index, GLfloat* parameters);
        private static TglProgramLocalParameter4fvARB glProgramLocalParameter4fvARB = null;

        // GLAPI void APIENTRY glGetProgramEnvParameterdvARB (GLenum target, GLuint index, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramEnvParameterdvARB(GLenum target, GLuint index, GLdouble* parameters);
        private static TglGetProgramEnvParameterdvARB glGetProgramEnvParameterdvARB = null;

        // GLAPI void APIENTRY glGetProgramEnvParameterfvARB (GLenum target, GLuint index, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramEnvParameterfvARB(GLenum target, GLuint index, GLfloat* parameters);
        private static TglGetProgramEnvParameterfvARB glGetProgramEnvParameterfvARB = null;

        // GLAPI void APIENTRY glGetProgramLocalParameterdvARB (GLenum target, GLuint index, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramLocalParameterdvARB(GLenum target, GLuint index, GLdouble* parameters);
        private static TglGetProgramLocalParameterdvARB glGetProgramLocalParameterdvARB = null;

        // GLAPI void APIENTRY glGetProgramLocalParameterfvARB (GLenum target, GLuint index, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramLocalParameterfvARB(GLenum target, GLuint index, GLfloat* parameters);
        private static TglGetProgramLocalParameterfvARB glGetProgramLocalParameterfvARB = null;

        // GLAPI void APIENTRY glGetProgramivARB (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramivARB(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetProgramivARB glGetProgramivARB = null;

        // GLAPI void APIENTRY glGetProgramStringARB (GLenum target, GLenum pname, GLvoid *string);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramStringARB(GLenum target, GLenum pname, void* programstring);
        private static TglGetProgramStringARB glGetProgramStringARB = null;

        // GLAPI void APIENTRY glGetVertexAttribdvARB (GLuint index, GLenum pname, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribdvARB(GLuint index, GLenum pname, GLdouble* parameters);
        private static TglGetVertexAttribdvARB glGetVertexAttribdvARB = null;

        // GLAPI void APIENTRY glGetVertexAttribfvARB (GLuint index, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribfvARB(GLuint index, GLenum pname, GLfloat* parameters);
        private static TglGetVertexAttribfvARB glGetVertexAttribfvARB = null;

        // GLAPI void APIENTRY glGetVertexAttribivARB (GLuint index, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribivARB(GLuint index, GLenum pname, GLint* parameters);
        private static TglGetVertexAttribivARB glGetVertexAttribivARB = null;

        // GLAPI void APIENTRY glGetVertexAttribPointervARB (GLuint index, GLenum pname, GLvoid* *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribPointervARB(GLuint index, GLenum pname, void** pointer);
        private static TglGetVertexAttribPointervARB glGetVertexAttribPointervARB = null;

        // GLAPI GLboolean APIENTRY glIsProgramARB (GLuint program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsProgramARB(GLuint program);
        private static TglIsProgramARB glIsProgramARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_program
        ///////////////////////////////////////////////////////////////////////
        /* All ARB_fragment_program entry points are shared with ARB_vertex_program. */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_buffer_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBindBufferARB (GLenum target, GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindBufferARB(GLenum target, GLuint buffer);
        private static TglBindBufferARB glBindBufferARB = null;

        // GLAPI void APIENTRY glDeleteBuffersARB (GLsizei n, const GLuint *buffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteBuffersARB(GLsizei n, GLuint* buffers);
        private static TglDeleteBuffersARB glDeleteBuffersARB = null;

        // GLAPI void APIENTRY glGenBuffersARB (GLsizei n, GLuint *buffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenBuffersARB(GLsizei n, GLuint* buffers);
        private static TglGenBuffersARB glGenBuffersARB = null;

        // GLAPI GLboolean APIENTRY glIsBufferARB (GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsBufferARB(GLuint buffer);
        private static TglIsBufferARB glIsBufferARB = null;

        // GLAPI void APIENTRY glBufferDataARB (GLenum target, GLsizeiptrARB size, const GLvoid *data, GLenum usage);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBufferDataARB(GLenum target, GLsizeiptr size, void* data, GLenum usage);
        private static TglBufferDataARB glBufferDataARB = null;

        // GLAPI void APIENTRY glBufferSubDataARB (GLenum target, GLintptrARB offset, GLsizeiptrARB size, const GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBufferSubDataARB(GLenum target, GLintptr offset, GLsizeiptr size, void* data);
        private static TglBufferSubDataARB glBufferSubDataARB = null;

        // GLAPI void APIENTRY glGetBufferSubDataARB (GLenum target, GLintptrARB offset, GLsizeiptrARB size, GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetBufferSubDataARB(GLenum target, GLintptr offset, GLsizeiptr size, void* data);
        private static TglGetBufferSubDataARB glGetBufferSubDataARB = null;

        // GLAPI GLvoid* APIENTRY glMapBufferARB (GLenum target, GLenum access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void* TglMapBufferARB(GLenum target, GLenum access);
        private static TglMapBufferARB glMapBufferARB = null;

        // GLAPI GLboolean APIENTRY glUnmapBufferARB (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglUnmapBufferARB(GLenum target);
        private static TglUnmapBufferARB glUnmapBufferARB = null;

        // GLAPI void APIENTRY glGetBufferParameterivARB (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetBufferParameterivARB(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetBufferParameterivARB glGetBufferParameterivARB = null;

        // GLAPI void APIENTRY glGetBufferPointervARB (GLenum target, GLenum pname, GLvoid* *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetBufferPointervARB(GLenum target, GLenum pname, void** parameters);
        private static TglGetBufferPointervARB glGetBufferPointervARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_occlusion_query
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGenQueriesARB (GLsizei n, GLuint *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenQueriesARB(GLsizei n, GLuint* ids);
        private static TglGenQueriesARB glGenQueriesARB = null;

        // GLAPI void APIENTRY glDeleteQueriesARB (GLsizei n, const GLuint *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteQueriesARB(GLsizei n, GLuint* ids);
        private static TglDeleteQueriesARB glDeleteQueriesARB = null;

        // GLAPI GLboolean APIENTRY glIsQueryARB (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsQueryARB(GLuint id);
        private static TglIsQueryARB glIsQueryARB = null;

        // GLAPI void APIENTRY glBeginQueryARB (GLenum target, GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginQueryARB(GLenum target, GLuint id);
        private static TglBeginQueryARB glBeginQueryARB = null;

        // GLAPI void APIENTRY glEndQueryARB (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndQueryARB(GLenum target);
        private static TglEndQueryARB glEndQueryARB = null;

        // GLAPI void APIENTRY glGetQueryivARB (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetQueryivARB(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetQueryivARB glGetQueryivARB = null;

        // GLAPI void APIENTRY glGetQueryObjectivARB (GLuint id, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetQueryObjectivARB(GLuint id, GLenum pname, GLint* parameters);
        private static TglGetQueryObjectivARB glGetQueryObjectivARB = null;

        // GLAPI void APIENTRY glGetQueryObjectuivARB (GLuint id, GLenum pname, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetQueryObjectuivARB(GLuint id, GLenum pname, GLuint* parameters);
        private static TglGetQueryObjectuivARB glGetQueryObjectuivARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_objects
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDeleteObjectARB (GLhandleARB obj);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDeleteObjectARB(GLhandle obj);
        private static TglDeleteObjectARB glDeleteObjectARB = null;

        // GLAPI GLhandleARB APIENTRY glGetHandleARB (GLenum pname);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLhandle TglGetHandleARB(GLenum pname);
        private static TglGetHandleARB glGetHandleARB = null;

        // GLAPI void APIENTRY glDetachObjectARB (GLhandleARB containerObj, GLhandleARB attachedObj);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDetachObjectARB(GLhandle containerObj, GLhandle attachedObj);
        private static TglDetachObjectARB glDetachObjectARB = null;

        // GLAPI GLhandleARB APIENTRY glCreateShaderObjectARB (GLenum shaderType);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLhandle TglCreateShaderObjectARB(GLenum shaderType);
        private static TglCreateShaderObjectARB glCreateShaderObjectARB = null;

        // GLAPI void APIENTRY glShaderSourceARB (GLhandleARB shaderObj, GLsizei count, const GLcharARB* *string, const GLint *length);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglShaderSourceARB(GLhandle shaderObj, GLsizei count, GLchar** strings, GLint* length);
        private static TglShaderSourceARB glShaderSourceARB = null;

        // GLAPI void APIENTRY glCompileShaderARB (GLhandleARB shaderObj);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCompileShaderARB(GLhandle shaderObj);
        private static TglCompileShaderARB glCompileShaderARB = null;

        // GLAPI GLhandleARB APIENTRY glCreateProgramObjectARB (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLhandle TglCreateProgramObjectARB();
        private static TglCreateProgramObjectARB glCreateProgramObjectARB = null;

        // GLAPI void APIENTRY glAttachObjectARB (GLhandleARB containerObj, GLhandleARB obj);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglAttachObjectARB(GLhandle containerObj, GLhandle obj);
        private static TglAttachObjectARB glAttachObjectARB = null;

        // GLAPI void APIENTRY glLinkProgramARB (GLhandleARB programObj);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLinkProgramARB(GLhandle programObj);
        private static TglLinkProgramARB glLinkProgramARB = null;

        // GLAPI void APIENTRY glUseProgramObjectARB (GLhandleARB programObj);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUseProgramObjectARB(GLhandle programObj);
        private static TglUseProgramObjectARB glUseProgramObjectARB = null;

        // GLAPI void APIENTRY glValidateProgramARB (GLhandleARB programObj);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglValidateProgramARB(GLhandle programObj);
        private static TglValidateProgramARB glValidateProgramARB = null;

        // GLAPI void APIENTRY glUniform1fARB (GLint location, GLfloat v0);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform1fARB(GLint location, GLfloat v0);
        private static TglUniform1fARB glUniform1fARB = null;

        // GLAPI void APIENTRY glUniform2fARB (GLint location, GLfloat v0, GLfloat v1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform2fARB(GLint location, GLfloat v0, GLfloat v1);
        private static TglUniform2fARB glUniform2fARB = null;

        // GLAPI void APIENTRY glUniform3fARB (GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform3fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        private static TglUniform3fARB glUniform3fARB = null;

        // GLAPI void APIENTRY glUniform4fARB (GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform4fARB(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        private static TglUniform4fARB glUniform4fARB = null;

        // GLAPI void APIENTRY glUniform1iARB (GLint location, GLint v0);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform1iARB(GLint location, GLint v0);
        private static TglUniform1iARB glUniform1iARB = null;

        // GLAPI void APIENTRY glUniform2iARB (GLint location, GLint v0, GLint v1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform2iARB(GLint location, GLint v0, GLint v1);
        private static TglUniform2iARB glUniform2iARB = null;

        // GLAPI void APIENTRY glUniform3iARB (GLint location, GLint v0, GLint v1, GLint v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform3iARB(GLint location, GLint v0, GLint v1, GLint v2);
        private static TglUniform3iARB glUniform3iARB = null;

        // GLAPI void APIENTRY glUniform4iARB (GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform4iARB(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        private static TglUniform4iARB glUniform4iARB = null;

        // GLAPI void APIENTRY glUniform1fvARB (GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform1fvARB(GLint location, GLsizei count, GLfloat* value);
        private static TglUniform1fvARB glUniform1fvARB = null;

        // GLAPI void APIENTRY glUniform2fvARB (GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform2fvARB(GLint location, GLsizei count, GLfloat* value);
        private static TglUniform2fvARB glUniform2fvARB = null;

        // GLAPI void APIENTRY glUniform3fvARB (GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform3fvARB(GLint location, GLsizei count, GLfloat* value);
        private static TglUniform3fvARB glUniform3fvARB = null;

        // GLAPI void APIENTRY glUniform4fvARB (GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform4fvARB(GLint location, GLsizei count, GLfloat* value);
        private static TglUniform4fvARB glUniform4fvARB = null;

        // GLAPI void APIENTRY glUniform1ivARB (GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform1ivARB(GLint location, GLsizei count, GLint* value);
        private static TglUniform1ivARB glUniform1ivARB = null;

        // GLAPI void APIENTRY glUniform2ivARB (GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform2ivARB(GLint location, GLsizei count, GLint* value);
        private static TglUniform2ivARB glUniform2ivARB = null;

        // GLAPI void APIENTRY glUniform3ivARB (GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform3ivARB(GLint location, GLsizei count, GLint* value);
        private static TglUniform3ivARB glUniform3ivARB = null;

        // GLAPI void APIENTRY glUniform4ivARB (GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform4ivARB(GLint location, GLsizei count, GLint* value);
        private static TglUniform4ivARB glUniform4ivARB = null;

        // GLAPI void APIENTRY glUniformMatrix2fvARB (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix2fvARB(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglUniformMatrix2fvARB glUniformMatrix2fvARB = null;

        // GLAPI void APIENTRY glUniformMatrix3fvARB (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix3fvARB(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglUniformMatrix3fvARB glUniformMatrix3fvARB = null;

        // GLAPI void APIENTRY glUniformMatrix4fvARB (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix4fvARB(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglUniformMatrix4fvARB glUniformMatrix4fvARB = null;

        // GLAPI void APIENTRY glGetObjectParameterfvARB (GLhandleARB obj, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetObjectParameterfvARB(GLhandle obj, GLenum pname, GLfloat* parameters);
        private static TglGetObjectParameterfvARB glGetObjectParameterfvARB = null;

        // GLAPI void APIENTRY glGetObjectParameterivARB (GLhandleARB obj, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetObjectParameterivARB(GLhandle obj, GLenum pname, GLint* parameters);
        private static TglGetObjectParameterivARB glGetObjectParameterivARB = null;

        // GLAPI void APIENTRY glGetInfoLogARB (GLhandleARB obj, GLsizei maxLength, GLsizei *length, GLcharARB *infoLog);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetInfoLogARB(GLhandle obj, GLsizei maxLength, GLsizei* length, GLchar* infoLog);
        private static TglGetInfoLogARB glGetInfoLogARB = null;

        // GLAPI void APIENTRY glGetAttachedObjectsARB (GLhandleARB containerObj, GLsizei maxCount, GLsizei *count, GLhandleARB *obj);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetAttachedObjectsARB(GLhandle containerObj, GLsizei maxCount, GLsizei* count, GLhandle* obj);
        private static TglGetAttachedObjectsARB glGetAttachedObjectsARB = null;

        // GLAPI GLint APIENTRY glGetUniformLocationARB (GLhandleARB programObj, const GLcharARB *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLint TglGetUniformLocationARB(GLhandle programObj, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglGetUniformLocationARB glGetUniformLocationARB = null;

        // GLAPI void APIENTRY glGetActiveUniformARB (GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei *length, GLint *size, GLenum *type, GLcharARB *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetActiveUniformARB(GLhandle programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GLenum* type, GLchar* name);
        private static TglGetActiveUniformARB glGetActiveUniformARB = null;

        // GLAPI void APIENTRY glGetUniformfvARB (GLhandleARB programObj, GLint location, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformfvARB(GLhandle programObj, GLint location, GLfloat* parameters);
        private static TglGetUniformfvARB glGetUniformfvARB = null;

        // GLAPI void APIENTRY glGetUniformivARB (GLhandleARB programObj, GLint location, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformivARB(GLhandle programObj, GLint location, GLint* parameters);
        private static TglGetUniformivARB glGetUniformivARB = null;

        // GLAPI void APIENTRY glGetShaderSourceARB (GLhandleARB obj, GLsizei maxLength, GLsizei *length, GLcharARB *source);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetShaderSourceARB(GLhandle obj, GLsizei maxLength, GLsizei* length, GLchar* source);
        private static TglGetShaderSourceARB glGetShaderSourceARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_shader
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBindAttribLocationARB (GLhandleARB programObj, GLuint index, const GLcharARB *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindAttribLocationARB(GLhandle programObj, GLuint index, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglBindAttribLocationARB glBindAttribLocationARB = null;

        // GLAPI void APIENTRY glGetActiveAttribARB (GLhandleARB programObj, GLuint index, GLsizei maxLength, GLsizei *length, GLint *size, GLenum *type, GLcharARB *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetActiveAttribARB(GLhandle programObj, GLuint index, GLsizei maxLength, GLsizei* length, GLint* size, GLenum* type, GLchar* name);
        private static TglGetActiveAttribARB glGetActiveAttribARB = null;

        // GLAPI GLint APIENTRY glGetAttribLocationARB (GLhandleARB programObj, const GLcharARB *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLint TglGetAttribLocationARB(GLhandle programObj, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglGetAttribLocationARB glGetAttribLocationARB = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawBuffersARB(GLsizei n, GLenum* bufs);
        private static TglDrawBuffersARB glDrawBuffersARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_rectangle (no function entry points) 
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_color_buffer_float
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glClampColorARB (GLenum target, GLenum clamp);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClampColorARB(GLenum target, GLenum clamp);
        private static TglClampColorARB glClampColorARB = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawArraysInstancedARB(GLenum mode, GLint first, GLsizei count, GLsizei primcount);
        private static TglDrawArraysInstancedARB glDrawArraysInstancedARB = null;
        
        // GLAPI void APIENTRY glDrawElementsInstancedARB (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawElementsInstancedARB(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount);
        private static TglDrawElementsInstancedARB glDrawElementsInstancedARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_framebuffer_object
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL v3.0 */
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramParameteriARB(GLuint program, GLenum pname, GLint value);
        private static TglProgramParameteriARB glProgramParameteriARB = null;

        // GLAPI void APIENTRY glFramebufferTextureARB (GLenum target, GLenum attachment, GLuint texture, GLint level);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTextureARB(GLenum target, GLenum attachment, GLuint texture, GLint level);
        private static TglFramebufferTextureARB glFramebufferTextureARB = null;

        // GLAPI void APIENTRY glFramebufferTextureLayerARB (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTextureLayerARB(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);
        private static TglFramebufferTextureLayerARB glFramebufferTextureLayerARB = null;

        // GLAPI void APIENTRY glFramebufferTextureFaceARB (GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTextureFaceARB(GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face);
        private static TglFramebufferTextureFaceARB glFramebufferTextureFaceARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_half_float_vertex (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_instanced_arrays
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexAttribDivisorARB (GLuint index, GLuint divisor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribDivisorARB(GLuint index, GLuint divisor);
        private static TglVertexAttribDivisorARB glVertexAttribDivisorARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_map_buffer_range
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.0 */
        // GLAPI GLvoid* APIENTRY glMapBufferRange (GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access);
        // GLAPI void APIENTRY glFlushMappedBufferRange (GLenum target, GLintptr offset, GLsizeiptr length);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_buffer_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexBufferARB (GLenum target, GLenum internalformat, GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexBufferARB(GLenum target, GLenum internalformat, GLuint buffer);
        private static TglTexBufferARB glTexBufferARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_compression_rgtc (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_rg (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_array_object
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.0 */
        // GLAPI void APIENTRY glBindVertexArray (GLuint array);
        // GLAPI void APIENTRY glDeleteVertexArrays (GLsizei n, const GLuint *arrays);
        // GLAPI void APIENTRY glGenVertexArrays (GLsizei n, GLuint *arrays);
        // GLAPI GLboolean APIENTRY glIsVertexArray (GLuint array);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_uniform_buffer_object
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.1 */
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
        /* Defined in OpenGL 3.1 */
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
        /* Defined in OpenGL 3.2 */
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
        /* Defined in OpenGL 3.2 */
        // GLAPI void APIENTRY glProvokingVertex (GLenum mode);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_seamless_cube_map (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sync
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.2 */
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
        /* Defined in OpenGL 3.2 */
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendEquationiARB(GLuint buf, GLenum mode);
        private static TglBlendEquationiARB glBlendEquationiARB = null;

        // GLAPI void APIENTRY glBlendEquationSeparateiARB (GLuint buf, GLenum modeRGB, GLenum modeAlpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendEquationSeparateiARB(GLuint buf, GLenum modeRGB, GLenum modeAlpha);
        private static TglBlendEquationSeparateiARB glBlendEquationSeparateiARB = null;

        // GLAPI void APIENTRY glBlendFunciARB (GLuint buf, GLenum src, GLenum dst);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendFunciARB(GLuint buf, GLenum src, GLenum dst);
        private static TglBlendFunciARB glBlendFunciARB = null;

        // GLAPI void APIENTRY glBlendFuncSeparateiARB (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendFuncSeparateiARB(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);
        private static TglBlendFuncSeparateiARB glBlendFuncSeparateiARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sample_shading
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMinSampleShadingARB (GLfloat value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMinSampleShadingARB(GLfloat value);
        private static TglMinSampleShadingARB glMinSampleShadingARB = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedStringARB(GLenum type, GLint namelen, [MarshalAs(UnmanagedType.LPStr)] string name, GLint stringlen, [MarshalAs(UnmanagedType.LPStr)] string str);
        private static TglNamedStringARB glNamedStringARB = null;

        // GLAPI void APIENTRY glDeleteNamedStringARB (GLint namelen, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDeleteNamedStringARB(GLint namelen, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglDeleteNamedStringARB glDeleteNamedStringARB = null;

        // GLAPI void APIENTRY glCompileShaderIncludeARB (GLuint shader, GLsizei count, const GLchar* *path, const GLint *length);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompileShaderIncludeARB(GLuint shader, GLsizei count, GLchar** path, GLint* length);
        private static TglCompileShaderIncludeARB glCompileShaderIncludeARB = null;

        // GLAPI GLboolean APIENTRY glIsNamedStringARB (GLint namelen, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsNamedStringARB(GLint namelen, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglIsNamedStringARB glIsNamedStringARB = null;

        // GLAPI void APIENTRY glGetNamedStringARB (GLint namelen, const GLchar *name, GLsizei bufSize, GLint *stringlen, GLchar *string);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedStringARB(GLint namelen, [MarshalAs(UnmanagedType.LPStr)] string name, GLsizei bufSize, GLint* stringlen, GLchar* str);
        private static TglGetNamedStringARB glGetNamedStringARB = null;

        // GLAPI void APIENTRY glGetNamedStringivARB (GLint namelen, const GLchar *name, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedStringivARB(GLint namelen, [MarshalAs(UnmanagedType.LPStr)] string name, GLenum pname, GLint* parameters);
        private static TglGetNamedStringivARB glGetNamedStringivARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_compression_bptc (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_blend_func_extended
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3 */
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
        /* Defined in OpenGL 3.3 */
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
        /* Defined in OpenGL 3.3 */
        // GLAPI void APIENTRY glQueryCounter (GLuint id, GLenum target);
        // GLAPI void APIENTRY glGetQueryObjecti64v (GLuint id, GLenum pname, GLint64 *params);
        // GLAPI void APIENTRY glGetQueryObjectui64v (GLuint id, GLenum pname, GLuint64 *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_type_2_10_10_10_rev
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3 */
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
        /* Defined in OpenGL 4.0 */
        // GLAPI void APIENTRY glDrawArraysIndirect (GLenum mode, const GLvoid *indirect);
        // GLAPI void APIENTRY glDrawElementsIndirect (GLenum mode, GLenum type, const GLvoid *indirect);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_gpu_shader5 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_gpu_shader_fp64 (no function entry points)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0 */
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
        /* Defined in OpenGL 4.0 */
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
        /* Defined in OpenGL 4.0 */
        // GLAPI void APIENTRY glPatchParameteri (GLenum pname, GLint value);
        // GLAPI void APIENTRY glPatchParameterfv (GLenum pname, const GLfloat *values);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_buffer_object_rgb32 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_transform_feedback2
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0 */
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
        /* Defined in OpenGL 4.0 */
        // GLAPI void APIENTRY glDrawTransformFeedbackStream (GLenum mode, GLuint id, GLuint stream);
        // GLAPI void APIENTRY glBeginQueryIndexed (GLenum target, GLuint index, GLuint id);
        // GLAPI void APIENTRY glEndQueryIndexed (GLenum target, GLuint index);
        // GLAPI void APIENTRY glGetQueryIndexediv (GLenum target, GLuint index, GLenum pname, GLint *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_ES2_compatibility
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1 */
        // GLAPI void APIENTRY glReleaseShaderCompiler (void);
        // GLAPI void APIENTRY glShaderBinary (GLsizei count, const GLuint *shaders, GLenum binaryformat, const GLvoid *binary, GLsizei length);
        // GLAPI void APIENTRY glGetShaderPrecisionFormat (GLenum shadertype, GLenum precisiontype, GLint *range, GLint *precision);
        // GLAPI void APIENTRY glDepthRangef (GLfloat n, GLfloat f);
        // GLAPI void APIENTRY glClearDepthf (GLfloat d);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_get_program_binary
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1 */
        // GLAPI void APIENTRY glGetProgramBinary (GLuint program, GLsizei bufSize, GLsizei *length, GLenum *binaryFormat, GLvoid *binary);
        // GLAPI void APIENTRY glProgramBinary (GLuint program, GLenum binaryFormat, const GLvoid *binary, GLsizei length);
        // GLAPI void APIENTRY glProgramParameteri (GLuint program, GLenum pname, GLint value);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_separate_shader_objects
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1 */
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
        /* Defined in OpenGL 4.1 */
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
        /* Defined in OpenGL 4.1 */
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLsync TglCreateSyncFromCLeventARB(void* cl_context, void* cl_event, GLbitfield flags);
        private static TglCreateSyncFromCLeventARB glCreateSyncFromCLeventARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_debug_output
        ///////////////////////////////////////////////////////////////////////
        // typedef void (APIENTRY *GLDEBUGPROCARB)(GLenum source,GLenum type,GLuint id,GLenum severity,GLsizei length,const GLchar *message,GLvoid *userParam);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void TCALLBACKglDebugProcARB(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string message, void* userParam);

        // GLAPI void APIENTRY glDebugMessageControlARB (GLenum source, GLenum type, GLenum severity, GLsizei count, const GLuint *ids, GLboolean enabled);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDebugMessageControlARB(GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled);
        private static TglDebugMessageControlARB glDebugMessageControlARB = null;

        // GLAPI void APIENTRY glDebugMessageInsertARB (GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, const GLchar *buf);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDebugMessageInsertARB(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string buf);
        private static TglDebugMessageInsertARB glDebugMessageInsertARB = null;

        // GLAPI void APIENTRY glDebugMessageCallbackARB (GLDEBUGPROCARB callback, const GLvoid *userParam);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDebugMessageCallbackARB(TCALLBACKglDebugProcARB callback, void* userParam);
        private static TglDebugMessageCallbackARB glDebugMessageCallbackARB = null;

        // GLAPI GLuint APIENTRY glGetDebugMessageLogARB (GLuint count, GLsizei bufsize, GLenum *sources, GLenum *types, GLuint *ids, GLenum *severities, GLsizei *lengths, GLchar *messageLog);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLuint TglGetDebugMessageLogARB(GLuint count, GLsizei bufsize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog);
        private static TglGetDebugMessageLogARB glGetDebugMessageLogARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_robustness
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLenum APIENTRY glGetGraphicsResetStatusARB (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLenum TglGetGraphicsResetStatusARB();
        private static TglGetGraphicsResetStatusARB glGetGraphicsResetStatusARB = null;

        // GLAPI void APIENTRY glGetnMapdvARB (GLenum target, GLenum query, GLsizei bufSize, GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnMapdvARB(GLenum target, GLenum query, GLsizei bufSize, GLdouble* v);
        private static TglGetnMapdvARB glGetnMapdvARB = null;

        // GLAPI void APIENTRY glGetnMapfvARB (GLenum target, GLenum query, GLsizei bufSize, GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnMapfvARB(GLenum target, GLenum query, GLsizei bufSize, GLfloat* v);
        private static TglGetnMapfvARB glGetnMapfvARB = null;

        // GLAPI void APIENTRY glGetnMapivARB (GLenum target, GLenum query, GLsizei bufSize, GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnMapivARB(GLenum target, GLenum query, GLsizei bufSize, GLint* v);
        private static TglGetnMapivARB glGetnMapivARB = null;

        // GLAPI void APIENTRY glGetnPixelMapfvARB (GLenum map, GLsizei bufSize, GLfloat *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnPixelMapfvARB(GLenum map, GLsizei bufSize, GLfloat* values);
        private static TglGetnPixelMapfvARB glGetnPixelMapfvARB = null;

        // GLAPI void APIENTRY glGetnPixelMapuivARB (GLenum map, GLsizei bufSize, GLuint *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnPixelMapuivARB(GLenum map, GLsizei bufSize, GLuint* values);
        private static TglGetnPixelMapuivARB glGetnPixelMapuivARB = null;

        // GLAPI void APIENTRY glGetnPixelMapusvARB (GLenum map, GLsizei bufSize, GLushort *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnPixelMapusvARB(GLenum map, GLsizei bufSize, GLushort* values);
        private static TglGetnPixelMapusvARB glGetnPixelMapusvARB = null;

        // GLAPI void APIENTRY glGetnPolygonStippleARB (GLsizei bufSize, GLubyte *pattern);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnPolygonStippleARB(GLsizei bufSize, GLubyte* pattern);
        private static TglGetnPolygonStippleARB glGetnPolygonStippleARB = null;

        // GLAPI void APIENTRY glGetnColorTableARB (GLenum target, GLenum format, GLenum type, GLsizei bufSize, GLvoid *table);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnColorTableARB(GLenum target, GLenum format, GLenum type, GLsizei bufSize, void* table);
        private static TglGetnColorTableARB glGetnColorTableARB = null;

        // GLAPI void APIENTRY glGetnConvolutionFilterARB (GLenum target, GLenum format, GLenum type, GLsizei bufSize, GLvoid *image);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnConvolutionFilterARB(GLenum target, GLenum format, GLenum type, GLsizei bufSize, void* image);
        private static TglGetnConvolutionFilterARB glGetnConvolutionFilterARB = null;

        // GLAPI void APIENTRY glGetnSeparableFilterARB (GLenum target, GLenum format, GLenum type, GLsizei rowBufSize, GLvoid *row, GLsizei columnBufSize, GLvoid *column, GLvoid *span);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnSeparableFilterARB(GLenum target, GLenum format, GLenum type, GLsizei rowBufSize, void* row, GLsizei columnBufSize, void* column, void* span);
        private static TglGetnSeparableFilterARB glGetnSeparableFilterARB = null;

        // GLAPI void APIENTRY glGetnHistogramARB (GLenum target, GLboolean reset, GLenum format, GLenum type, GLsizei bufSize, GLvoid *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnHistogramARB(GLenum target, GLboolean reset, GLenum format, GLenum type, GLsizei bufSize, void* values);
        private static TglGetnHistogramARB glGetnHistogramARB = null;

        // GLAPI void APIENTRY glGetnMinmaxARB (GLenum target, GLboolean reset, GLenum format, GLenum type, GLsizei bufSize, GLvoid *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnMinmaxARB(GLenum target, GLboolean reset, GLenum format, GLenum type, GLsizei bufSize, void* values);
        private static TglGetnMinmaxARB glGetnMinmaxARB = null;

        // GLAPI void APIENTRY glGetnTexImageARB (GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, GLvoid *img);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnTexImageARB(GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* img);
        private static TglGetnTexImageARB glGetnTexImageARB = null;

        // GLAPI void APIENTRY glReadnPixelsARB (GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReadnPixelsARB(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data);
        private static TglReadnPixelsARB glReadnPixelsARB = null;

        // GLAPI void APIENTRY glGetnCompressedTexImageARB (GLenum target, GLint lod, GLsizei bufSize, GLvoid *img);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnCompressedTexImageARB(GLenum target, GLint lod, GLsizei bufSize, void* img);
        private static TglGetnCompressedTexImageARB glGetnCompressedTexImageARB = null;

        // GLAPI void APIENTRY glGetnUniformfvARB (GLuint program, GLint location, GLsizei bufSize, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnUniformfvARB(GLuint program, GLint location, GLsizei bufSize, GLfloat* parameters);
        private static TglGetnUniformfvARB glGetnUniformfvARB = null;

        // GLAPI void APIENTRY glGetnUniformivARB (GLuint program, GLint location, GLsizei bufSize, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnUniformivARB(GLuint program, GLint location, GLsizei bufSize, GLint* parameters);
        private static TglGetnUniformivARB glGetnUniformivARB = null;

        // GLAPI void APIENTRY glGetnUniformuivARB (GLuint program, GLint location, GLsizei bufSize, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnUniformuivARB(GLuint program, GLint location, GLsizei bufSize, GLuint* parameters);
        private static TglGetnUniformuivARB glGetnUniformuivARB = null;

        // GLAPI void APIENTRY glGetnUniformdvARB (GLuint program, GLint location, GLsizei bufSize, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnUniformdvARB(GLuint program, GLint location, GLsizei bufSize, GLdouble* parameters);
        private static TglGetnUniformdvARB glGetnUniformdvARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_stencil_export (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_base_instance
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 */
        // GLAPI void APIENTRY glDrawArraysInstancedBaseInstance (GLenum mode, GLint first, GLsizei count, GLsizei instancecount, GLuint baseinstance);
        // GLAPI void APIENTRY glDrawElementsInstancedBaseInstance (GLenum mode, GLsizei count, GLenum type, const void *indices, GLsizei instancecount, GLuint baseinstance);
        // GLAPI void APIENTRY glDrawElementsInstancedBaseVertexBaseInstance (GLenum mode, GLsizei count, GLenum type, const void *indices, GLsizei instancecount, GLint basevertex, GLuint baseinstance);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shading_language_420pack (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_transform_feedback_instanced
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 */
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
        /* Defined in OpenGL 4.2 */
        // GLAPI void APIENTRY glGetInternalformativ (GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_map_buffer_alignment (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_atomic_counters
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 */
        // GLAPI void APIENTRY glGetActiveAtomicCounterBufferiv (GLuint program, GLuint bufferIndex, GLenum pname, GLint *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_image_load_store
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 */
        // GLAPI void APIENTRY glBindImageTexture (GLuint unit, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLenum format);
        // GLAPI void APIENTRY glMemoryBarrier (GLbitfield barriers);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shading_language_packing (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_storage
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 */
        // GLAPI void APIENTRY glTexStorage1D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);
        // GLAPI void APIENTRY glTexStorage2D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        // GLAPI void APIENTRY glTexStorage3D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
        // GLAPI void APIENTRY glTextureStorage1D (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);
        // GLAPI void APIENTRY glTextureStorage2D (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        // GLAPI void APIENTRY glTextureStorage3D (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_arrays_of_arrays (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_clear_buffer_object
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */
        // GLAPI void APIENTRY glClearBufferData (GLenum target, GLenum internalformat, GLenum format, GLenum type, const void *data);
        // GLAPI void APIENTRY glClearBufferSubData (GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, const void *data);
        // GLAPI void APIENTRY glClearNamedBufferDataEXT (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, const void *data);
        // GLAPI void APIENTRY glClearNamedBufferSubDataEXT (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, GLsizeiptr offset, GLsizeiptr size, const void *data);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_compute_shader
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */
        // GLAPI void APIENTRY glDispatchCompute (GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z);
        // GLAPI void APIENTRY glDispatchComputeIndirect (GLintptr indirect);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_copy_image
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */
        // GLAPI void APIENTRY glCopyImageSubData (GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_view
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */
        // GLAPI void APIENTRY glTextureView (GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_attrib_binding
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */
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
        /* Defined in OpenGL 4.3 */
        // GLAPI void APIENTRY glFramebufferParameteri (GLenum target, GLenum pname, GLint param);
        // GLAPI void APIENTRY glGetFramebufferParameteriv (GLenum target, GLenum pname, GLint *params);
        // GLAPI void APIENTRY glNamedFramebufferParameteriEXT (GLuint framebuffer, GLenum pname, GLint param);
        // GLAPI void APIENTRY glGetNamedFramebufferParameterivEXT (GLuint framebuffer, GLenum pname, GLint *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_internalformat_query2
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */
        // GLAPI void APIENTRY glGetInternalformati64v (GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint64 *params);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_invalidate_subdata
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */
        // GLAPI void APIENTRY glInvalidateTexSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth);
        // GLAPI void APIENTRY glInvalidateTexImage (GLuint texture, GLint level);
        // GLAPI void APIENTRY glInvalidateBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr length);
        // GLAPI void APIENTRY glInvalidateBufferData (GLuint buffer);
        // GLAPI void APIENTRY glInvalidateFramebuffer (GLenum target, GLsizei numAttachments, const GLenum *attachments);
        // GLAPI void APIENTRY glInvalidateSubFramebuffer (GLenum target, GLsizei numAttachments, const GLenum *attachments, GLint x, GLint y, GLsizei width, GLsizei height);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_multi_draw_indirect
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */
        // GLAPI void APIENTRY glMultiDrawArraysIndirect (GLenum mode, const void *indirect, GLsizei drawcount, GLsizei stride);
        // GLAPI void APIENTRY glMultiDrawElementsIndirect (GLenum mode, GLenum type, const void *indirect, GLsizei drawcount, GLsizei stride);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_program_interface_query
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */
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
        /* Defined in OpenGL 4.3 */
        // GLAPI void APIENTRY glShaderStorageBlockBinding (GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_stencil_texturing (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_buffer_range
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */
        // GLAPI void APIENTRY glTexBufferRange (GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);
        // GLAPI void APIENTRY glTextureBufferRangeEXT (GLuint texture, GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_query_levels (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_storage_multisample
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint64 TglGetTextureHandleARB(GLuint texture);
        private static TglGetTextureHandleARB glGetTextureHandleARB = null;

        // GLAPI GLuint64 APIENTRY glGetTextureSamplerHandleARB (GLuint texture, GLuint sampler);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint64 TglGetTextureSamplerHandleARB(GLuint texture, GLuint sampler);
        private static TglGetTextureSamplerHandleARB glGetTextureSamplerHandleARB = null;

        // GLAPI void APIENTRY glMakeTextureHandleResidentARB (GLuint64 handle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMakeTextureHandleResidentARB(GLuint64 handle);
        private static TglMakeTextureHandleResidentARB glMakeTextureHandleResidentARB = null;
        
        // GLAPI void APIENTRY glMakeTextureHandleNonResidentARB (GLuint64 handle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMakeTextureHandleNonResidentARB(GLuint64 handle);
        private static TglMakeTextureHandleNonResidentARB glMakeTextureHandleNonResidentARB = null;

        // GLAPI GLuint64 APIENTRY glGetImageHandleARB (GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint64 TglGetImageHandleARB(GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format);
        private static TglGetImageHandleARB glGetImageHandleARB = null;
        
        // GLAPI void APIENTRY glMakeImageHandleResidentARB (GLuint64 handle, GLenum access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMakeImageHandleResidentARB(GLuint64 handle, GLenum access);
        private static TglMakeImageHandleResidentARB glMakeImageHandleResidentARB = null;

        // GLAPI void APIENTRY glMakeImageHandleNonResidentARB (GLuint64 handle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMakeImageHandleNonResidentARB(GLuint64 handle);
        private static TglMakeImageHandleNonResidentARB glMakeImageHandleNonResidentARB = null;
        
        // GLAPI void APIENTRY glUniformHandleui64ARB (GLint location, GLuint64 value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniformHandleui64ARB(GLint location, GLuint64 value);
        private static TglUniformHandleui64ARB glUniformHandleui64ARB = null;

        // GLAPI void APIENTRY glUniformHandleui64vARB (GLint location, GLsizei count, const GLuint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformHandleui64vARB(GLint location, GLsizei count, GLuint64* value);
        private static TglUniformHandleui64vARB glUniformHandleui64vARB = null;

        // GLAPI void APIENTRY glProgramUniformHandleui64ARB (GLuint program, GLint location, GLuint64 value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniformHandleui64ARB(GLuint program, GLint location, GLuint64 value);
        private static TglProgramUniformHandleui64ARB glProgramUniformHandleui64ARB = null;
        
        // GLAPI void APIENTRY glProgramUniformHandleui64vARB (GLuint program, GLint location, GLsizei count, const GLuint64 *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformHandleui64vARB(GLuint program, GLint location, GLsizei count, GLuint64* values);
        private static TglProgramUniformHandleui64vARB glProgramUniformHandleui64vARB = null;
        
        // GLAPI GLboolean APIENTRY glIsTextureHandleResidentARB (GLuint64 handle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsTextureHandleResidentARB(GLuint64 handle);
        private static TglIsTextureHandleResidentARB glIsTextureHandleResidentARB = null;
        
        // GLAPI GLboolean APIENTRY glIsImageHandleResidentARB (GLuint64 handle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsImageHandleResidentARB(GLuint64 handle);
        private static TglIsImageHandleResidentARB glIsImageHandleResidentARB = null;

        // GLAPI void APIENTRY glVertexAttribL1ui64ARB (GLuint index, GLuint64EXT x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL1ui64ARB(GLuint index, GLuint64 x);
        private static TglVertexAttribL1ui64ARB glVertexAttribL1ui64ARB = null;

        // GLAPI void APIENTRY glVertexAttribL1ui64vARB (GLuint index, const GLuint64EXT *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL1ui64vARB(GLuint index, GLuint64* v);
        private static TglVertexAttribL1ui64vARB glVertexAttribL1ui64vARB = null;

        // GLAPI void APIENTRY glGetVertexAttribLui64vARB (GLuint index, GLenum pname, GLuint64EXT *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribLui64vARB(GLuint index, GLenum pname, GLuint64* parameters);
        private static TglGetVertexAttribLui64vARB glGetVertexAttribLui64vARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_compute_variable_group_size
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDispatchComputeGroupSizeARB (GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z, GLuint group_size_x, GLuint group_size_y, GLuint group_size_z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDispatchComputeGroupSizeARB(GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z, GLuint group_size_x, GLuint group_size_y, GLuint group_size_z);
        private static TglDispatchComputeGroupSizeARB glDispatchComputeGroupSizeARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_indirect_parameters
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMultiDrawArraysIndirectCountARB (GLenum mode, GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiDrawArraysIndirectCountARB(GLenum mode, GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride);
        private static TglMultiDrawArraysIndirectCountARB glMultiDrawArraysIndirectCountARB = null;

        // GLAPI void APIENTRY glMultiDrawElementsIndirectCountARB (GLenum mode, GLenum type, GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiDrawElementsIndirectCountARB(GLenum mode, GLenum type, GLintptr indirect, GLintptr drawcount, GLsizei maxdrawcount, GLsizei stride);
        private static TglMultiDrawElementsIndirectCountARB glMultiDrawElementsIndirectCountARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sparse_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexPageCommitmentARB (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLboolean resident);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexPageCommitmentARB(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLboolean resident);
        private static TglTexPageCommitmentARB glTexPageCommitmentARB = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBufferPageCommitmentARB(GLenum target, GLintptr offset, GLsizeiptr size, GLboolean commit);
        private static TglBufferPageCommitmentARB glBufferPageCommitmentARB = null;

        // GLAPI void APIENTRY glNamedBufferPageCommitmentEXT (GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedBufferPageCommitmentEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit);
        private static TglNamedBufferPageCommitmentEXT glNamedBufferPageCommitmentEXT = null;

        // GLAPI void APIENTRY glNamedBufferPageCommitmentARB (GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedBufferPageCommitmentARB(GLuint buffer, GLintptr offset, GLsizeiptr size, GLboolean commit);
        private static TglNamedBufferPageCommitmentARB glNamedBufferPageCommitmentARB = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPrimitiveBoundingBoxARB(GLfloat minX, GLfloat minY, GLfloat minZ, GLfloat minW, GLfloat maxX, GLfloat maxY, GLfloat maxZ, GLfloat maxW);
        private static TglPrimitiveBoundingBoxARB glPrimitiveBoundingBoxARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_shader_interlock (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_gpu_shader_int64
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glUniform1i64ARB (GLint location, GLint64 x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform1i64ARB(GLint location, GLint64 x);
        private static TglUniform1i64ARB glUniform1i64ARB = null;

        // GLAPI void APIENTRY glUniform2i64ARB (GLint location, GLint64 x, GLint64 y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform2i64ARB(GLint location, GLint64 x, GLint64 y);
        private static TglUniform2i64ARB glUniform2i64ARB = null;

        // GLAPI void APIENTRY glUniform3i64ARB (GLint location, GLint64 x, GLint64 y, GLint64 z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform3i64ARB(GLint location, GLint64 x, GLint64 y, GLint64 z);
        private static TglUniform3i64ARB glUniform3i64ARB = null;

        // GLAPI void APIENTRY glUniform4i64ARB (GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform4i64ARB(GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w);
        private static TglUniform4i64ARB glUniform4i64ARB = null;

        // GLAPI void APIENTRY glUniform1i64vARB (GLint location, GLsizei count, const GLint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform1i64vARB(GLint location, GLsizei count, GLint64* value);
        private static TglUniform1i64vARB glUniform1i64vARB = null;

        // GLAPI void APIENTRY glUniform2i64vARB (GLint location, GLsizei count, const GLint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform2i64vARB(GLint location, GLsizei count, GLint64* value);
        private static TglUniform2i64vARB glUniform2i64vARB = null;

        // GLAPI void APIENTRY glUniform3i64vARB (GLint location, GLsizei count, const GLint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform3i64vARB(GLint location, GLsizei count, GLint64* value);
        private static TglUniform3i64vARB glUniform3i64vARB = null;

        // GLAPI void APIENTRY glUniform4i64vARB (GLint location, GLsizei count, const GLint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform4i64vARB(GLint location, GLsizei count, GLint64* value);
        private static TglUniform4i64vARB glUniform4i64vARB = null;

        // GLAPI void APIENTRY glUniform1ui64ARB (GLint location, GLuint64 x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform1ui64ARB(GLint location, GLuint64 x);
        private static TglUniform1ui64ARB glUniform1ui64ARB = null;

        // GLAPI void APIENTRY glUniform2ui64ARB (GLint location, GLuint64 x, GLuint64 y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform2ui64ARB(GLint location, GLuint64 x, GLuint64 y);
        private static TglUniform2ui64ARB glUniform2ui64ARB = null;

        // GLAPI void APIENTRY glUniform3ui64ARB (GLint location, GLuint64 x, GLuint64 y, GLuint64 z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform3ui64ARB(GLint location, GLuint64 x, GLuint64 y, GLuint64 z);
        private static TglUniform3ui64ARB glUniform3ui64ARB = null;

        // GLAPI void APIENTRY glUniform4ui64ARB (GLint location, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform4ui64ARB(GLint location, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w);
        private static TglUniform4ui64ARB glUniform4ui64ARB = null;

        // GLAPI void APIENTRY glUniform1ui64vARB (GLint location, GLsizei count, const GLuint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform1ui64vARB(GLint location, GLsizei count, GLuint64* value);
        private static TglUniform1ui64vARB glUniform1ui64vARB = null;

        // GLAPI void APIENTRY glUniform2ui64vARB (GLint location, GLsizei count, const GLuint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform2ui64vARB(GLint location, GLsizei count, GLuint64* value);
        private static TglUniform2ui64vARB glUniform2ui64vARB = null;

        // GLAPI void APIENTRY glUniform3ui64vARB (GLint location, GLsizei count, const GLuint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform3ui64vARB(GLint location, GLsizei count, GLuint64* value);
        private static TglUniform3ui64vARB glUniform3ui64vARB = null;

        // GLAPI void APIENTRY glUniform4ui64vARB (GLint location, GLsizei count, const GLuint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform4ui64vARB(GLint location, GLsizei count, GLuint64* value);
        private static TglUniform4ui64vARB glUniform4ui64vARB = null;

        // GLAPI void APIENTRY glGetUniformi64vARB (GLuint program, GLint location, GLint64 *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformi64vARB(GLuint program, GLint location, GLint64* parameters);
        private static TglGetUniformi64vARB glGetUniformi64vARB = null;

        // GLAPI void APIENTRY glGetUniformui64vARB (GLuint program, GLint location, GLuint64 *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformui64vARB(GLuint program, GLint location, GLuint64* parameters);
        private static TglGetUniformui64vARB glGetUniformui64vARB = null;

        // GLAPI void APIENTRY glGetnUniformi64vARB (GLuint program, GLint location, GLsizei bufSize, GLint64 *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnUniformi64vARB(GLuint program, GLint location, GLsizei bufSize, GLint64* parameters);
        private static TglGetnUniformi64vARB glGetnUniformi64vARB = null;

        // GLAPI void APIENTRY glGetnUniformui64vARB (GLuint program, GLint location, GLsizei bufSize, GLuint64 *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnUniformui64vARB(GLuint program, GLint location, GLsizei bufSize, GLuint64* parameters);
        private static TglGetnUniformui64vARB glGetnUniformui64vARB = null;

        // GLAPI void APIENTRY glProgramUniform1i64ARB (GLuint program, GLint location, GLint64 x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform1i64ARB(GLuint program, GLint location, GLint64 x);
        private static TglProgramUniform1i64ARB glProgramUniform1i64ARB = null;

        // GLAPI void APIENTRY glProgramUniform2i64ARB (GLuint program, GLint location, GLint64 x, GLint64 y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform2i64ARB(GLuint program, GLint location, GLint64 x, GLint64 y);
        private static TglProgramUniform2i64ARB glProgramUniform2i64ARB = null;

        // GLAPI void APIENTRY glProgramUniform3i64ARB (GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform3i64ARB(GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z);
        private static TglProgramUniform3i64ARB glProgramUniform3i64ARB = null;

        // GLAPI void APIENTRY glProgramUniform4i64ARB (GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform4i64ARB(GLuint program, GLint location, GLint64 x, GLint64 y, GLint64 z, GLint64 w);
        private static TglProgramUniform4i64ARB glProgramUniform4i64ARB = null;

        // GLAPI void APIENTRY glProgramUniform1i64vARB (GLuint program, GLint location, GLsizei count, const GLint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform1i64vARB(GLuint program, GLint location, GLsizei count, GLint64* value);
        private static TglProgramUniform1i64vARB glProgramUniform1i64vARB = null;

        // GLAPI void APIENTRY glProgramUniform2i64vARB (GLuint program, GLint location, GLsizei count, const GLint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform2i64vARB(GLuint program, GLint location, GLsizei count, GLint64* value);
        private static TglProgramUniform2i64vARB glProgramUniform2i64vARB = null;

        // GLAPI void APIENTRY glProgramUniform3i64vARB (GLuint program, GLint location, GLsizei count, const GLint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform3i64vARB(GLuint program, GLint location, GLsizei count, GLint64* value);
        private static TglProgramUniform3i64vARB glProgramUniform3i64vARB = null;

        // GLAPI void APIENTRY glProgramUniform4i64vARB (GLuint program, GLint location, GLsizei count, const GLint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform4i64vARB(GLuint program, GLint location, GLsizei count, GLint64* value);
        private static TglProgramUniform4i64vARB glProgramUniform4i64vARB = null;

        // GLAPI void APIENTRY glProgramUniform1ui64ARB (GLuint program, GLint location, GLuint64 x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform1ui64ARB(GLuint program, GLint location, GLuint64 x);
        private static TglProgramUniform1ui64ARB glProgramUniform1ui64ARB = null;

        // GLAPI void APIENTRY glProgramUniform2ui64ARB (GLuint program, GLint location, GLuint64 x, GLuint64 y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform2ui64ARB(GLuint program, GLint location, GLuint64 x, GLuint64 y);
        private static TglProgramUniform2ui64ARB glProgramUniform2ui64ARB = null;

        // GLAPI void APIENTRY glProgramUniform3ui64ARB (GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint64 z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform3ui64ARB(GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint64 z);
        private static TglProgramUniform3ui64ARB glProgramUniform3ui64ARB = null;

        // GLAPI void APIENTRY glProgramUniform4ui64ARB (GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform4ui64ARB(GLuint program, GLint location, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w);
        private static TglProgramUniform4ui64ARB glProgramUniform4ui64ARB = null;

        // GLAPI void APIENTRY glProgramUniform1ui64vARB (GLuint program, GLint location, GLsizei count, const GLuint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform1ui64vARB(GLuint program, GLint location, GLsizei count, GLuint64* value);
        private static TglProgramUniform1ui64vARB glProgramUniform1ui64vARB = null;

        // GLAPI void APIENTRY glProgramUniform2ui64vARB (GLuint program, GLint location, GLsizei count, const GLuint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform2ui64vARB(GLuint program, GLint location, GLsizei count, GLuint64* value);
        private static TglProgramUniform2ui64vARB glProgramUniform2ui64vARB = null;

        // GLAPI void APIENTRY glProgramUniform3ui64vARB (GLuint program, GLint location, GLsizei count, const GLuint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform3ui64vARB(GLuint program, GLint location, GLsizei count, GLuint64* value);
        private static TglProgramUniform3ui64vARB glProgramUniform3ui64vARB = null;

        // GLAPI void APIENTRY glProgramUniform4ui64vARB (GLuint program, GLint location, GLsizei count, const GLuint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform4ui64vARB(GLuint program, GLint location, GLsizei count, GLuint64* value);
        private static TglProgramUniform4ui64vARB glProgramUniform4ui64vARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_parallel_shader_compile
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMaxShaderCompilerThreadsARB (GLuint count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMaxShaderCompilerThreadsARB(GLuint count);
        private static TglMaxShaderCompilerThreadsARB glMaxShaderCompilerThreadsARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_post_depth_coverage (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sample_locations
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFramebufferSampleLocationsfvARB (GLenum target, GLuint start, GLsizei count, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFramebufferSampleLocationsfvARB(GLenum target, GLuint start, GLsizei count, GLfloat* v);
        private static TglFramebufferSampleLocationsfvARB glFramebufferSampleLocationsfvARB = null;

        // GLAPI void APIENTRY glNamedFramebufferSampleLocationsfvARB (GLuint framebuffer, GLuint start, GLsizei count, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedFramebufferSampleLocationsfvARB(GLuint framebuffer, GLuint start, GLsizei count, GLfloat* v);
        private static TglNamedFramebufferSampleLocationsfvARB glNamedFramebufferSampleLocationsfvARB = null;

        // GLAPI void APIENTRY glEvaluateDepthValuesARB (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEvaluateDepthValuesARB();
        private static TglEvaluateDepthValuesARB glEvaluateDepthValuesARB = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_atomic_counter_ops (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_ballot (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_clock (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_viewport_layer_array (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sparse_texture2 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sparse_texture_clamp (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_filter_minmax (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_ATI_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_texture_mirror_once (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_envmap_bumpmap
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexBumpParameterivATI (GLenum pname, const GLint *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexBumpParameterivATI(GLenum pname, GLint* param);
        private static TglTexBumpParameterivATI glTexBumpParameterivATI = null;

        // GLAPI void APIENTRY glTexBumpParameterfvATI (GLenum pname, const GLfloat *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexBumpParameterfvATI(GLenum pname, GLfloat* param);
        private static TglTexBumpParameterfvATI glTexBumpParameterfvATI = null;

        // GLAPI void APIENTRY glGetTexBumpParameterivATI (GLenum pname, GLint *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexBumpParameterivATI(GLenum pname, GLint* param);
        private static TglGetTexBumpParameterivATI glGetTexBumpParameterivATI = null;

        // GLAPI void APIENTRY glGetTexBumpParameterfvATI (GLenum pname, GLfloat *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexBumpParameterfvATI(GLenum pname, GLfloat* param);
        private static TglGetTexBumpParameterfvATI glGetTexBumpParameterfvATI = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_fragment_shader
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLuint APIENTRY glGenFragmentShadersATI (GLuint range);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglGenFragmentShadersATI(GLuint range);
        private static TglGenFragmentShadersATI glGenFragmentShadersATI = null;

        // GLAPI void APIENTRY glBindFragmentShaderATI (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindFragmentShaderATI(GLuint id);
        private static TglBindFragmentShaderATI glBindFragmentShaderATI = null;

        // GLAPI void APIENTRY glDeleteFragmentShaderATI (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDeleteFragmentShaderATI(GLuint id);
        private static TglDeleteFragmentShaderATI glDeleteFragmentShaderATI = null;

        // GLAPI void APIENTRY glBeginFragmentShaderATI (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginFragmentShaderATI();
        private static TglBeginFragmentShaderATI glBeginFragmentShaderATI = null;

        // GLAPI void APIENTRY glEndFragmentShaderATI (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndFragmentShaderATI();
        private static TglEndFragmentShaderATI glEndFragmentShaderATI = null;

        // GLAPI void APIENTRY glPassTexCoordATI (GLuint dst, GLuint coord, GLenum swizzle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPassTexCoordATI(GLuint dst, GLuint coord, GLenum swizzle);
        private static TglPassTexCoordATI glPassTexCoordATI = null;

        // GLAPI void APIENTRY glSampleMapATI (GLuint dst, GLuint interp, GLenum swizzle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSampleMapATI(GLuint dst, GLuint interp, GLenum swizzle);
        private static TglSampleMapATI glSampleMapATI = null;

        // GLAPI void APIENTRY glColorFragmentOp1ATI (GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColorFragmentOp1ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);
        private static TglColorFragmentOp1ATI glColorFragmentOp1ATI = null;

        // GLAPI void APIENTRY glColorFragmentOp2ATI (GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColorFragmentOp2ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);
        private static TglColorFragmentOp2ATI glColorFragmentOp2ATI = null;

        // GLAPI void APIENTRY glColorFragmentOp3ATI (GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColorFragmentOp3ATI(GLenum op, GLuint dst, GLuint dstMask, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);
        private static TglColorFragmentOp3ATI glColorFragmentOp3ATI = null;

        // GLAPI void APIENTRY glAlphaFragmentOp1ATI (GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglAlphaFragmentOp1ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod);
        private static TglAlphaFragmentOp1ATI glAlphaFragmentOp1ATI = null;

        // GLAPI void APIENTRY glAlphaFragmentOp2ATI (GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglAlphaFragmentOp2ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod);
        private static TglAlphaFragmentOp2ATI glAlphaFragmentOp2ATI = null;

        // GLAPI void APIENTRY glAlphaFragmentOp3ATI (GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglAlphaFragmentOp3ATI(GLenum op, GLuint dst, GLuint dstMod, GLuint arg1, GLuint arg1Rep, GLuint arg1Mod, GLuint arg2, GLuint arg2Rep, GLuint arg2Mod, GLuint arg3, GLuint arg3Rep, GLuint arg3Mod);
        private static TglAlphaFragmentOp3ATI glAlphaFragmentOp3ATI = null;

        // GLAPI void APIENTRY glSetFragmentShaderConstantATI (GLuint dst, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSetFragmentShaderConstantATI(GLuint dst, GLfloat* value);
        private static TglSetFragmentShaderConstantATI glSetFragmentShaderConstantATI = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_pn_triangles
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPNTrianglesiATI (GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPNTrianglesiATI(GLenum pname, GLint param);
        private static TglPNTrianglesiATI glPNTrianglesiATI = null;

        // GLAPI void APIENTRY glPNTrianglesfATI (GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPNTrianglesfATI(GLenum pname, GLfloat param);
        private static TglPNTrianglesfATI glPNTrianglesfATI = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_vertex_array_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLuint APIENTRY glNewObjectBufferATI (GLsizei size, const GLvoid *pointer, GLenum usage);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLuint TglNewObjectBufferATI(GLsizei size, void* pointer, GLenum usage);
        private static TglNewObjectBufferATI glNewObjectBufferATI = null;

        // GLAPI GLboolean APIENTRY glIsObjectBufferATI (GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsObjectBufferATI(GLuint buffer);
        private static TglIsObjectBufferATI glIsObjectBufferATI = null;

        // GLAPI void APIENTRY glUpdateObjectBufferATI (GLuint buffer, GLuint offset, GLsizei size, const GLvoid *pointer, GLenum preserve);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUpdateObjectBufferATI(GLuint buffer, GLuint offset, GLsizei size, void* pointer, GLenum preserve);
        private static TglUpdateObjectBufferATI glUpdateObjectBufferATI = null;

        // GLAPI void APIENTRY glGetObjectBufferfvATI (GLuint buffer, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetObjectBufferfvATI(GLuint buffer, GLenum pname, GLfloat* parameters);
        private static TglGetObjectBufferfvATI glGetObjectBufferfvATI = null;

        // GLAPI void APIENTRY glGetObjectBufferivATI (GLuint buffer, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetObjectBufferivATI(GLuint buffer, GLenum pname, GLint* parameters);
        private static TglGetObjectBufferivATI glGetObjectBufferivATI = null;

        // GLAPI void APIENTRY glFreeObjectBufferATI (GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFreeObjectBufferATI(GLuint buffer);
        private static TglFreeObjectBufferATI glFreeObjectBufferATI = null;

        // GLAPI void APIENTRY glArrayObjectATI (GLenum array, GLint size, GLenum type, GLsizei stride, GLuint buffer, GLuint offset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglArrayObjectATI(GLenum array, GLint size, GLenum type, GLsizei stride, GLuint buffer, GLuint offset);
        private static TglArrayObjectATI glArrayObjectATI = null;

        // GLAPI void APIENTRY glGetArrayObjectfvATI (GLenum array, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetArrayObjectfvATI(GLenum array, GLenum pname, GLfloat* parameters);
        private static TglGetArrayObjectfvATI glGetArrayObjectfvATI = null;

        // GLAPI void APIENTRY glGetArrayObjectivATI (GLenum array, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetArrayObjectivATI(GLenum array, GLenum pname, GLint* parameters);
        private static TglGetArrayObjectivATI glGetArrayObjectivATI = null;

        // GLAPI void APIENTRY glVariantArrayObjectATI (GLuint id, GLenum type, GLsizei stride, GLuint buffer, GLuint offset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVariantArrayObjectATI(GLuint id, GLenum type, GLsizei stride, GLuint buffer, GLuint offset);
        private static TglVariantArrayObjectATI glVariantArrayObjectATI = null;

        // GLAPI void APIENTRY glGetVariantArrayObjectfvATI (GLuint id, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVariantArrayObjectfvATI(GLuint id, GLenum pname, GLfloat* parameters);
        private static TglGetVariantArrayObjectfvATI glGetVariantArrayObjectfvATI = null;

        // GLAPI void APIENTRY glGetVariantArrayObjectivATI (GLuint id, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVariantArrayObjectivATI(GLuint id, GLenum pname, GLint* parameters);
        private static TglGetVariantArrayObjectivATI glGetVariantArrayObjectivATI = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_vertex_streams
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexStream1sATI (GLenum stream, GLshort x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream1sATI(GLenum stream, GLshort x);
        private static TglVertexStream1sATI glVertexStream1sATI = null;

        // GLAPI void APIENTRY glVertexStream1svATI (GLenum stream, const GLshort *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream1svATI(GLenum stream, GLshort* coords);
        private static TglVertexStream1svATI glVertexStream1svATI = null;

        // GLAPI void APIENTRY glVertexStream1iATI (GLenum stream, GLint x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream1iATI(GLenum stream, GLint x);
        private static TglVertexStream1iATI glVertexStream1iATI = null;

        // GLAPI void APIENTRY glVertexStream1ivATI (GLenum stream, const GLint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream1ivATI(GLenum stream, GLint* coords);
        private static TglVertexStream1ivATI glVertexStream1ivATI = null;

        // GLAPI void APIENTRY glVertexStream1fATI (GLenum stream, GLfloat x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream1fATI(GLenum stream, GLfloat x);
        private static TglVertexStream1fATI glVertexStream1fATI = null;

        // GLAPI void APIENTRY glVertexStream1fvATI (GLenum stream, const GLfloat *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream1fvATI(GLenum stream, GLfloat* coords);
        private static TglVertexStream1fvATI glVertexStream1fvATI = null;

        // GLAPI void APIENTRY glVertexStream1dATI (GLenum stream, GLdouble x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream1dATI(GLenum stream, GLdouble x);
        private static TglVertexStream1dATI glVertexStream1dATI = null;

        // GLAPI void APIENTRY glVertexStream1dvATI (GLenum stream, const GLdouble *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream1dvATI(GLenum stream, GLdouble* coords);
        private static TglVertexStream1dvATI glVertexStream1dvATI = null;

        // GLAPI void APIENTRY glVertexStream2sATI (GLenum stream, GLshort x, GLshort y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream2sATI(GLenum stream, GLshort x, GLshort y);
        private static TglVertexStream2sATI glVertexStream2sATI = null;

        // GLAPI void APIENTRY glVertexStream2svATI (GLenum stream, const GLshort *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream2svATI(GLenum stream, GLshort* coords);
        private static TglVertexStream2svATI glVertexStream2svATI = null;

        // GLAPI void APIENTRY glVertexStream2iATI (GLenum stream, GLint x, GLint y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream2iATI(GLenum stream, GLint x, GLint y);
        private static TglVertexStream2iATI glVertexStream2iATI = null;

        // GLAPI void APIENTRY glVertexStream2ivATI (GLenum stream, const GLint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream2ivATI(GLenum stream, GLint* coords);
        private static TglVertexStream2ivATI glVertexStream2ivATI = null;

        // GLAPI void APIENTRY glVertexStream2fATI (GLenum stream, GLfloat x, GLfloat y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream2fATI(GLenum stream, GLfloat x, GLfloat y);
        private static TglVertexStream2fATI glVertexStream2fATI = null;

        // GLAPI void APIENTRY glVertexStream2fvATI (GLenum stream, const GLfloat *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream2fvATI(GLenum stream, GLfloat* coords);
        private static TglVertexStream2fvATI glVertexStream2fvATI = null;

        // GLAPI void APIENTRY glVertexStream2dATI (GLenum stream, GLdouble x, GLdouble y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream2dATI(GLenum stream, GLdouble x, GLdouble y);
        private static TglVertexStream2dATI glVertexStream2dATI = null;

        // GLAPI void APIENTRY glVertexStream2dvATI (GLenum stream, const GLdouble *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream2dvATI(GLenum stream, GLdouble* coords);
        private static TglVertexStream2dvATI glVertexStream2dvATI = null;

        // GLAPI void APIENTRY glVertexStream3sATI (GLenum stream, GLshort x, GLshort y, GLshort z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream3sATI(GLenum stream, GLshort x, GLshort y, GLshort z);
        private static TglVertexStream3sATI glVertexStream3sATI = null;

        // GLAPI void APIENTRY glVertexStream3svATI (GLenum stream, const GLshort *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream3svATI(GLenum stream, GLshort* coords);
        private static TglVertexStream3svATI glVertexStream3svATI = null;

        // GLAPI void APIENTRY glVertexStream3iATI (GLenum stream, GLint x, GLint y, GLint z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream3iATI(GLenum stream, GLint x, GLint y, GLint z);
        private static TglVertexStream3iATI glVertexStream3iATI = null;

        // GLAPI void APIENTRY glVertexStream3ivATI (GLenum stream, const GLint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream3ivATI(GLenum stream, GLint* coords);
        private static TglVertexStream3ivATI glVertexStream3ivATI = null;

        // GLAPI void APIENTRY glVertexStream3fATI (GLenum stream, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream3fATI(GLenum stream, GLfloat x, GLfloat y, GLfloat z);
        private static TglVertexStream3fATI glVertexStream3fATI = null;

        // GLAPI void APIENTRY glVertexStream3fvATI (GLenum stream, const GLfloat *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream3fvATI(GLenum stream, GLfloat* coords);
        private static TglVertexStream3fvATI glVertexStream3fvATI = null;

        // GLAPI void APIENTRY glVertexStream3dATI (GLenum stream, GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream3dATI(GLenum stream, GLdouble x, GLdouble y, GLdouble z);
        private static TglVertexStream3dATI glVertexStream3dATI = null;

        // GLAPI void APIENTRY glVertexStream3dvATI (GLenum stream, const GLdouble *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream3dvATI(GLenum stream, GLdouble* coords);
        private static TglVertexStream3dvATI glVertexStream3dvATI = null;

        // GLAPI void APIENTRY glVertexStream4sATI (GLenum stream, GLshort x, GLshort y, GLshort z, GLshort w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream4sATI(GLenum stream, GLshort x, GLshort y, GLshort z, GLshort w);
        private static TglVertexStream4sATI glVertexStream4sATI = null;

        // GLAPI void APIENTRY glVertexStream4svATI (GLenum stream, const GLshort *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream4svATI(GLenum stream, GLshort* coords);
        private static TglVertexStream4svATI glVertexStream4svATI = null;

        // GLAPI void APIENTRY glVertexStream4iATI (GLenum stream, GLint x, GLint y, GLint z, GLint w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream4iATI(GLenum stream, GLint x, GLint y, GLint z, GLint w);
        private static TglVertexStream4iATI glVertexStream4iATI = null;

        // GLAPI void APIENTRY glVertexStream4ivATI (GLenum stream, const GLint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream4ivATI(GLenum stream, GLint* coords);
        private static TglVertexStream4ivATI glVertexStream4ivATI = null;

        // GLAPI void APIENTRY glVertexStream4fATI (GLenum stream, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream4fATI(GLenum stream, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglVertexStream4fATI glVertexStream4fATI = null;

        // GLAPI void APIENTRY glVertexStream4fvATI (GLenum stream, const GLfloat *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream4fvATI(GLenum stream, GLfloat* coords);
        private static TglVertexStream4fvATI glVertexStream4fvATI = null;

        // GLAPI void APIENTRY glVertexStream4dATI (GLenum stream, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexStream4dATI(GLenum stream, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglVertexStream4dATI glVertexStream4dATI = null;

        // GLAPI void APIENTRY glVertexStream4dvATI (GLenum stream, const GLdouble *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexStream4dvATI(GLenum stream, GLdouble* coords);
        private static TglVertexStream4dvATI glVertexStream4dvATI = null;

        // GLAPI void APIENTRY glNormalStream3bATI (GLenum stream, GLbyte nx, GLbyte ny, GLbyte nz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormalStream3bATI(GLenum stream, GLbyte nx, GLbyte ny, GLbyte nz);
        private static TglNormalStream3bATI glNormalStream3bATI = null;

        // GLAPI void APIENTRY glNormalStream3bvATI (GLenum stream, const GLbyte *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormalStream3bvATI(GLenum stream, GLbyte* coords);
        private static TglNormalStream3bvATI glNormalStream3bvATI = null;

        // GLAPI void APIENTRY glNormalStream3sATI (GLenum stream, GLshort nx, GLshort ny, GLshort nz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormalStream3sATI(GLenum stream, GLshort nx, GLshort ny, GLshort nz);
        private static TglNormalStream3sATI glNormalStream3sATI = null;

        // GLAPI void APIENTRY glNormalStream3svATI (GLenum stream, const GLshort *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormalStream3svATI(GLenum stream, GLshort* coords);
        private static TglNormalStream3svATI glNormalStream3svATI = null;

        // GLAPI void APIENTRY glNormalStream3iATI (GLenum stream, GLint nx, GLint ny, GLint nz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormalStream3iATI(GLenum stream, GLint nx, GLint ny, GLint nz);
        private static TglNormalStream3iATI glNormalStream3iATI = null;

        // GLAPI void APIENTRY glNormalStream3ivATI (GLenum stream, const GLint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormalStream3ivATI(GLenum stream, GLint* coords);
        private static TglNormalStream3ivATI glNormalStream3ivATI = null;

        // GLAPI void APIENTRY glNormalStream3fATI (GLenum stream, GLfloat nx, GLfloat ny, GLfloat nz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormalStream3fATI(GLenum stream, GLfloat nx, GLfloat ny, GLfloat nz);
        private static TglNormalStream3fATI glNormalStream3fATI = null;

        // GLAPI void APIENTRY glNormalStream3fvATI (GLenum stream, const GLfloat *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormalStream3fvATI(GLenum stream, GLfloat* coords);
        private static TglNormalStream3fvATI glNormalStream3fvATI = null;

        // GLAPI void APIENTRY glNormalStream3dATI (GLenum stream, GLdouble nx, GLdouble ny, GLdouble nz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormalStream3dATI(GLenum stream, GLdouble nx, GLdouble ny, GLdouble nz);
        private static TglNormalStream3dATI glNormalStream3dATI = null;

        // GLAPI void APIENTRY glNormalStream3dvATI (GLenum stream, const GLdouble *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormalStream3dvATI(GLenum stream, GLdouble* coords);
        private static TglNormalStream3dvATI glNormalStream3dvATI = null;

        // GLAPI void APIENTRY glClientActiveVertexStreamATI (GLenum stream);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClientActiveVertexStreamATI(GLenum stream);
        private static TglClientActiveVertexStreamATI glClientActiveVertexStreamATI = null;

        // GLAPI void APIENTRY glVertexBlendEnviATI (GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexBlendEnviATI(GLenum pname, GLint param);
        private static TglVertexBlendEnviATI glVertexBlendEnviATI = null;

        // GLAPI void APIENTRY glVertexBlendEnvfATI (GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexBlendEnvfATI(GLenum pname, GLfloat param);
        private static TglVertexBlendEnvfATI glVertexBlendEnvfATI = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_element_array
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glElementPointerATI (GLenum type, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglElementPointerATI(GLenum type, void* pointer);
        private static TglElementPointerATI glElementPointerATI = null;

        // GLAPI void APIENTRY glDrawElementArrayATI (GLenum mode, GLsizei count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawElementArrayATI(GLenum mode, GLsizei count);
        private static TglDrawElementArrayATI glDrawElementArrayATI = null;

        // GLAPI void APIENTRY glDrawRangeElementArrayATI (GLenum mode, GLuint start, GLuint end, GLsizei count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawRangeElementArrayATI(GLenum mode, GLuint start, GLuint end, GLsizei count);
        private static TglDrawRangeElementArrayATI glDrawRangeElementArrayATI = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_text_fragment_shader (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_draw_buffers
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDrawBuffersATI (GLsizei n, const GLenum *bufs);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawBuffersATI(GLsizei n, GLenum* bufs);
        private static TglDrawBuffersATI glDrawBuffersATI = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_pixel_format_float
        ///////////////////////////////////////////////////////////////////////
        /* This is really a WGL extension, but defines some associated GL enums.
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void* TglMapObjectBufferATI(GLuint buffer);
        private static TglMapObjectBufferATI glMapObjectBufferATI = null;

        // GLAPI void APIENTRY glUnmapObjectBufferATI (GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUnmapObjectBufferATI(GLuint buffer);
        private static TglUnmapObjectBufferATI glUnmapObjectBufferATI = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_separate_stencil
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glStencilOpSeparateATI (GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStencilOpSeparateATI (GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass);
        private static TglStencilOpSeparateATI glStencilOpSeparateATI = null;

        // GLAPI void APIENTRY glStencilFuncSeparateATI (GLenum frontfunc, GLenum backfunc, GLint ref, GLuint mask);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStencilFuncSeparateATI(GLenum frontfunc, GLenum backfunc, GLint reference, GLuint mask);
        private static TglStencilFuncSeparateATI glStencilFuncSeparateATI = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_vertex_attrib_array_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexAttribArrayObjectATI (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLuint buffer, GLuint offset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribArrayObjectATI(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, GLuint buffer, GLuint offset);
        private static TglVertexAttribArrayObjectATI glVertexAttribArrayObjectATI = null;

        // GLAPI void APIENTRY glGetVertexAttribArrayObjectfvATI (GLuint index, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribArrayObjectfvATI(GLuint index, GLenum pname, GLfloat* parameters);
        private static TglGetVertexAttribArrayObjectfvATI glGetVertexAttribArrayObjectfvATI = null;

        // GLAPI void APIENTRY glGetVertexAttribArrayObjectivATI (GLuint index, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribArrayObjectivATI(GLuint index, GLenum pname, GLint* parameters);
        private static TglGetVertexAttribArrayObjectivATI glGetVertexAttribArrayObjectivATI = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_meminfo (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_texture_compression_3dc (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_EXT_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_abgr (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_color
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendColorEXT (GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendColorEXT(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
        private static TglBlendColorEXT glBlendColorEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_polygon_offset
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPolygonOffsetEXT (GLfloat factor, GLfloat bias);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPolygonOffsetEXT(GLfloat factor, GLfloat bias);
        private static TglPolygonOffsetEXT glPolygonOffsetEXT = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexImage3DEXT(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels);
        private static TglTexImage3DEXT glTexImage3DEXT = null;

        // GLAPI void APIENTRY glTexSubImage3DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexSubImage3DEXT(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels);
        private static TglTexSubImage3DEXT glTexSubImage3DEXT = null;
        
        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_subtexture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexSubImage1DEXT (GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexSubImage1DEXT(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);
        private static TglTexSubImage1DEXT glTexSubImage1DEXT = null;

        // GLAPI void APIENTRY glTexSubImage2DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexSubImage2DEXT(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);
        private static TglTexSubImage2DEXT glTexSubImage2DEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_copy_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCopyTexImage1DEXT (GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTexImage1DEXT(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);
        private static TglCopyTexImage1DEXT glCopyTexImage1DEXT = null;

        // GLAPI void APIENTRY glCopyTexImage2DEXT (GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTexImage2DEXT(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        private static TglCopyTexImage2DEXT glCopyTexImage2DEXT = null;

        // GLAPI void APIENTRY glCopyTexSubImage1DEXT (GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTexSubImage1DEXT(GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        private static TglCopyTexSubImage1DEXT glCopyTexSubImage1DEXT = null;

        // GLAPI void APIENTRY glCopyTexSubImage2DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTexSubImage2DEXT(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglCopyTexSubImage2DEXT glCopyTexSubImage2DEXT = null;

        // GLAPI void APIENTRY glCopyTexSubImage3DEXT (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTexSubImage3DEXT(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglCopyTexSubImage3DEXT glCopyTexSubImage3DEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_histogram
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetHistogramEXT (GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetHistogramEXT(GLenum target, GLboolean reset, GLenum format, GLenum type, void* values);
        private static TglGetHistogramEXT glGetHistogramEXT = null;

        // GLAPI void APIENTRY glGetHistogramParameterfvEXT (GLenum target, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetHistogramParameterfvEXT(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetHistogramParameterfvEXT glGetHistogramParameterfvEXT = null;

        // GLAPI void APIENTRY glGetHistogramParameterivEXT (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetHistogramParameterivEXT(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetHistogramParameterivEXT glGetHistogramParameterivEXT = null;

        // GLAPI void APIENTRY glGetMinmaxEXT (GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMinmaxEXT(GLenum target, GLboolean reset, GLenum format, GLenum type, void* values);
        private static TglGetMinmaxEXT glGetMinmaxEXT = null;

        // GLAPI void APIENTRY glGetMinmaxParameterfvEXT (GLenum target, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMinmaxParameterfvEXT(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetMinmaxParameterfvEXT glGetMinmaxParameterfvEXT = null;

        // GLAPI void APIENTRY glGetMinmaxParameterivEXT (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMinmaxParameterivEXT(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetMinmaxParameterivEXT glGetMinmaxParameterivEXT = null;

        // GLAPI void APIENTRY glHistogramEXT (GLenum target, GLsizei width, GLenum internalformat, GLboolean sink);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglHistogramEXT(GLenum target, GLsizei width, GLenum internalformat, GLboolean sink);
        private static TglHistogramEXT glHistogramEXT = null;

        // GLAPI void APIENTRY glMinmaxEXT (GLenum target, GLenum internalformat, GLboolean sink);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMinmaxEXT(GLenum target, GLenum internalformat, GLboolean sink);
        private static TglMinmaxEXT glMinmaxEXT = null;

        // GLAPI void APIENTRY glResetHistogramEXT (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglResetHistogramEXT(GLenum target);
        private static TglResetHistogramEXT glResetHistogramEXT = null;

        // GLAPI void APIENTRY glResetMinmaxEXT (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglResetMinmaxEXT(GLenum target);
        private static TglResetMinmaxEXT glResetMinmaxEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_convolution
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glConvolutionFilter1DEXT (GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, const GLvoid *image);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglConvolutionFilter1DEXT(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, void* image);
        private static TglConvolutionFilter1DEXT glConvolutionFilter1DEXT = null;

        // GLAPI void APIENTRY glConvolutionFilter2DEXT (GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *image);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglConvolutionFilter2DEXT(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, void* image);
        private static TglConvolutionFilter2DEXT glConvolutionFilter2DEXT = null;

        // GLAPI void APIENTRY glConvolutionParameterfEXT (GLenum target, GLenum pname, GLfloat params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglConvolutionParameterfEXT(GLenum target, GLenum pname, GLfloat parameters);
        private static TglConvolutionParameterfEXT glConvolutionParameterfEXT = null;

        // GLAPI void APIENTRY glConvolutionParameterfvEXT (GLenum target, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglConvolutionParameterfvEXT(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglConvolutionParameterfvEXT glConvolutionParameterfvEXT = null;

        // GLAPI void APIENTRY glConvolutionParameteriEXT (GLenum target, GLenum pname, GLint params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglConvolutionParameteriEXT(GLenum target, GLenum pname, GLint parameters);
        private static TglConvolutionParameteriEXT glConvolutionParameteriEXT = null;

        // GLAPI void APIENTRY glConvolutionParameterivEXT (GLenum target, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglConvolutionParameterivEXT(GLenum target, GLenum pname, GLint* parameters);
        private static TglConvolutionParameterivEXT glConvolutionParameterivEXT = null;

        // GLAPI void APIENTRY glCopyConvolutionFilter1DEXT (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyConvolutionFilter1DEXT(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
        private static TglCopyConvolutionFilter1DEXT glCopyConvolutionFilter1DEXT = null;

        // GLAPI void APIENTRY glCopyConvolutionFilter2DEXT (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyConvolutionFilter2DEXT(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglCopyConvolutionFilter2DEXT glCopyConvolutionFilter2DEXT = null;

        // GLAPI void APIENTRY glGetConvolutionFilterEXT (GLenum target, GLenum format, GLenum type, GLvoid *image);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetConvolutionFilterEXT(GLenum target, GLenum format, GLenum type, void* image);
        private static TglGetConvolutionFilterEXT glGetConvolutionFilterEXT = null;

        // GLAPI void APIENTRY glGetConvolutionParameterfvEXT (GLenum target, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetConvolutionParameterfvEXT(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetConvolutionParameterfvEXT glGetConvolutionParameterfvEXT = null;

        // GLAPI void APIENTRY glGetConvolutionParameterivEXT (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetConvolutionParameterivEXT(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetConvolutionParameterivEXT glGetConvolutionParameterivEXT = null;

        // GLAPI void APIENTRY glGetSeparableFilterEXT (GLenum target, GLenum format, GLenum type, GLvoid *row, GLvoid *column, GLvoid *span);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetSeparableFilterEXT(GLenum target, GLenum format, GLenum type, void* row, void* column, void* span);
        private static TglGetSeparableFilterEXT glGetSeparableFilterEXT = null;

        // GLAPI void APIENTRY glSeparableFilter2DEXT (GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *row, const GLvoid *column);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSeparableFilter2DEXT(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, void* row, void* column);
        private static TglSeparableFilter2DEXT glSeparableFilter2DEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_cmyka (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLboolean APIENTRY glAreTexturesResidentEXT (GLsizei n, const GLuint *textures, GLboolean *residences);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLboolean TglAreTexturesResidentEXT(GLsizei n, GLuint* textures, GLboolean* residences);
        private static TglAreTexturesResidentEXT glAreTexturesResidentEXT = null;

        // GLAPI void APIENTRY glBindTextureEXT (GLenum target, GLuint texture);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindTextureEXT(GLenum target, GLuint texture);
        private static TglBindTextureEXT glBindTextureEXT = null;

        // GLAPI void APIENTRY glDeleteTexturesEXT (GLsizei n, const GLuint *textures);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteTexturesEXT(GLsizei n, GLuint* textures);
        private static TglDeleteTexturesEXT glDeleteTexturesEXT = null;

        // GLAPI void APIENTRY glGenTexturesEXT (GLsizei n, GLuint *textures);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate void TglGenTexturesEXT(GLsizei n, GLuint* textures);
        private static TglGenTexturesEXT glGenTexturesEXT = null;

        // GLAPI GLboolean APIENTRY glIsTextureEXT (GLuint texture);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsTextureEXT(GLuint texture);
        private static TglIsTextureEXT glIsTextureEXT = null;

        // GLAPI void APIENTRY glPrioritizeTexturesEXT (GLsizei n, const GLuint *textures, const GLclampf *priorities);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPrioritizeTexturesEXT(GLsizei n, GLuint* textures, GLclampf* priorities);
        private static TglPrioritizeTexturesEXT glPrioritizeTexturesEXT = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglArrayElementEXT(GLint i);
        private static TglArrayElementEXT glArrayElementEXT = null;

        // GLAPI void APIENTRY glColorPointerEXT (GLint size, GLenum type, GLsizei stride, GLsizei count, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorPointerEXT(GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer);
        private static TglColorPointerEXT glColorPointerEXT = null;

        // GLAPI void APIENTRY glDrawArraysEXT (GLenum mode, GLint first, GLsizei count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawArraysEXT(GLenum mode, GLint first, GLsizei count);
        private static TglDrawArraysEXT glDrawArraysEXT = null;

        // GLAPI void APIENTRY glEdgeFlagPointerEXT (GLsizei stride, GLsizei count, const GLboolean *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglEdgeFlagPointerEXT(GLsizei stride, GLsizei count, GLboolean* pointer);
        private static TglEdgeFlagPointerEXT glEdgeFlagPointerEXT = null;

        // GLAPI void APIENTRY glGetPointervEXT (GLenum pname, GLvoid* *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPointervEXT(GLenum pname, void** parameters);
        private static TglGetPointervEXT glGetPointervEXT = null;

        // GLAPI void APIENTRY glIndexPointerEXT (GLenum type, GLsizei stride, GLsizei count, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglIndexPointerEXT(GLenum type, GLsizei stride, GLsizei count, void* pointer);
        private static TglIndexPointerEXT glIndexPointerEXT = null;

        // GLAPI void APIENTRY glNormalPointerEXT (GLenum type, GLsizei stride, GLsizei count, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormalPointerEXT(GLenum type, GLsizei stride, GLsizei count, void* pointer);
        private static TglNormalPointerEXT glNormalPointerEXT = null;

        // GLAPI void APIENTRY glTexCoordPointerEXT (GLint size, GLenum type, GLsizei stride, GLsizei count, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoordPointerEXT(GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer);
        private static TglTexCoordPointerEXT glTexCoordPointerEXT = null;

        // GLAPI void APIENTRY glVertexPointerEXT (GLint size, GLenum type, GLsizei stride, GLsizei count, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexPointerEXT(GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer);
        private static TglVertexPointerEXT glVertexPointerEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_misc_attribute (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_minmax
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendEquationEXT (GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendEquationEXT(GLenum mode);
        private static TglBlendEquationEXT glBlendEquationEXT = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPointParameterfEXT(GLenum pname, GLfloat param);
        private static TglPointParameterfEXT glPointParameterfEXT = null;

        // GLAPI void APIENTRY glPointParameterfvEXT (GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPointParameterfvEXT(GLenum pname, GLfloat* parameters);
        private static TglPointParameterfvEXT glPointParameterfvEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_color_subtable
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glColorSubTableEXT (GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, const GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorSubTableEXT(GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, void* data);
        private static TglColorSubTableEXT glColorSubTableEXT = null;

        // GLAPI void APIENTRY glCopyColorSubTableEXT (GLenum target, GLsizei start, GLint x, GLint y, GLsizei width);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyColorSubTableEXT(GLenum target, GLsizei start, GLint x, GLint y, GLsizei width);
        private static TglCopyColorSubTableEXT glCopyColorSubTableEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_paletted_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glColorTableEXT (GLenum target, GLenum internalFormat, GLsizei width, GLenum format, GLenum type, const GLvoid *table);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorTableEXT(GLenum target, GLenum internalFormat, GLsizei width, GLenum format, GLenum type, void* table);
        private static TglColorTableEXT glColorTableEXT = null;

        // GLAPI void APIENTRY glGetColorTableEXT (GLenum target, GLenum format, GLenum type, GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetColorTableEXT(GLenum target, GLenum format, GLenum type, void* data);
        private static TglGetColorTableEXT glGetColorTableEXT = null;

        // GLAPI void APIENTRY glGetColorTableParameterivEXT (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetColorTableParameterivEXT(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetColorTableParameterivEXT glGetColorTableParameterivEXT = null;

        // GLAPI void APIENTRY glGetColorTableParameterfvEXT (GLenum target, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetColorTableParameterfvEXT(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetColorTableParameterfvEXT glGetColorTableParameterfvEXT = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglIndexMaterialEXT(GLenum face, GLenum mode);
        private static TglIndexMaterialEXT glIndexMaterialEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_index_func
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glIndexFuncEXT (GLenum func, GLclampf ref);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglIndexFuncEXT(GLenum func, GLclampf reference);
        private static TglIndexFuncEXT glIndexFuncEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_index_array_formats (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_compiled_vertex_array
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glLockArraysEXT (GLint first, GLsizei count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLockArraysEXT(GLint first, GLsizei count);
        private static TglLockArraysEXT glLockArraysEXT = null;

        // GLAPI void APIENTRY glUnlockArraysEXT (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUnlockArraysEXT();
        private static TglUnlockArraysEXT glUnlockArraysEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_cull_vertex
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCullParameterdvEXT (GLenum pname, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCullParameterdvEXT(GLenum pname, GLdouble* parameters);
        private static TglCullParameterdvEXT glCullParameterdvEXT = null;

        // GLAPI void APIENTRY glCullParameterfvEXT (GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCullParameterfvEXT(GLenum pname, GLfloat* parameters);
        private static TglCullParameterfvEXT glCullParameterfvEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_draw_range_elements
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDrawRangeElementsEXT (GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, const GLvoid *indices);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawRangeElementsEXT(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices);
        private static TglDrawRangeElementsEXT glDrawRangeElementsEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_light_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glApplyTextureEXT (GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglApplyTextureEXT(GLenum mode);
        private static TglApplyTextureEXT glApplyTextureEXT = null;

        // GLAPI void APIENTRY glTextureLightEXT (GLenum pname);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureLightEXT(GLenum pname);
        private static TglTextureLightEXT glTextureLightEXT = null;

        // GLAPI void APIENTRY glTextureMaterialEXT (GLenum face, GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureMaterialEXT(GLenum face, GLenum mode);
        private static TglTextureMaterialEXT glTextureMaterialEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_bgra (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_pixel_transform
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPixelTransformParameteriEXT (GLenum target, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPixelTransformParameteriEXT(GLenum target, GLenum pname, GLint param);
        private static TglPixelTransformParameteriEXT glPixelTransformParameteriEXT = null;

        // GLAPI void APIENTRY glPixelTransformParameterfEXT (GLenum target, GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPixelTransformParameterfEXT(GLenum target, GLenum pname, GLfloat param);
        private static TglPixelTransformParameterfEXT glPixelTransformParameterfEXT = null;

        // GLAPI void APIENTRY glPixelTransformParameterivEXT (GLenum target, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPixelTransformParameterivEXT(GLenum target, GLenum pname, GLint* parameters);
        private unsafe static TglPixelTransformParameterivEXT glPixelTransformParameterivEXT = null;

        // GLAPI void APIENTRY glPixelTransformParameterfvEXT (GLenum target, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPixelTransformParameterfvEXT(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglPixelTransformParameterfvEXT glPixelTransformParameterfvEXT = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3bEXT(GLbyte red, GLbyte green, GLbyte blue);
        private static TglSecondaryColor3bEXT glSecondaryColor3bEXT = null;
        
        // GLAPI void APIENTRY glSecondaryColor3bvEXT (const GLbyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3bvEXT(GLbyte* v);
        private static TglSecondaryColor3bvEXT glSecondaryColor3bvEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3dEXT (GLdouble red, GLdouble green, GLdouble blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3dEXT(GLdouble red, GLdouble green, GLdouble blue);
        private static TglSecondaryColor3dEXT glSecondaryColor3dEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3dvEXT (const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3dvEXT(GLdouble* v);
        private static TglSecondaryColor3dvEXT glSecondaryColor3dvEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3fEXT (GLfloat red, GLfloat green, GLfloat blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3fEXT(GLfloat red, GLfloat green, GLfloat blue);
        private static TglSecondaryColor3fEXT glSecondaryColor3fEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3fvEXT (const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3fvEXT(GLfloat* v);
        private static TglSecondaryColor3fvEXT glSecondaryColor3fvEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3iEXT (GLint red, GLint green, GLint blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3iEXT(GLint red, GLint green, GLint blue);
        private static TglSecondaryColor3iEXT glSecondaryColor3iEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3ivEXT (const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3ivEXT(GLint* v);
        private static TglSecondaryColor3ivEXT glSecondaryColor3ivEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3sEXT (GLshort red, GLshort green, GLshort blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3sEXT(GLshort red, GLshort green, GLshort blue);
        private static TglSecondaryColor3sEXT glSecondaryColor3sEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3svEXT (const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3svEXT(GLshort* v);
        private static TglSecondaryColor3svEXT glSecondaryColor3svEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3ubEXT (GLubyte red, GLubyte green, GLubyte blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3ubEXT(GLubyte red, GLubyte green, GLubyte blue);
        private static TglSecondaryColor3ubEXT glSecondaryColor3ubEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3ubvEXT (const GLubyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3ubvEXT(GLubyte* v);
        private static TglSecondaryColor3ubvEXT glSecondaryColor3ubvEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3uiEXT (GLuint red, GLuint green, GLuint blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3uiEXT(GLuint red, GLuint green, GLuint blue);
        private static TglSecondaryColor3uiEXT glSecondaryColor3uiEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3uivEXT (const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3uivEXT(GLuint* v);
        private static TglSecondaryColor3uivEXT glSecondaryColor3uivEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3usEXT (GLushort red, GLushort green, GLushort blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3usEXT(GLushort red, GLushort green, GLushort blue);
        private static TglSecondaryColor3usEXT glSecondaryColor3usEXT = null;

        // GLAPI void APIENTRY glSecondaryColor3usvEXT (const GLushort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3usvEXT(GLushort* v);
        private static TglSecondaryColor3usvEXT glSecondaryColor3usvEXT = null;

        // GLAPI void APIENTRY glSecondaryColorPointerEXT (GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColorPointerEXT(GLint size, GLenum type, GLsizei stride, void* pointer);
        private static TglSecondaryColorPointerEXT glSecondaryColorPointerEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_perturb_normal
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTextureNormalEXT (GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureNormalEXT(GLenum mode);
        private static TglTextureNormalEXT glTextureNormalEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_multi_draw_arrays
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMultiDrawArraysEXT (GLenum mode, const GLint *first, const GLsizei *count, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawArraysEXT(GLenum mode, GLint* first, GLsizei* count, GLsizei primcount);
        private static TglMultiDrawArraysEXT glMultiDrawArraysEXT = null;

        // GLAPI void APIENTRY glMultiDrawElementsEXT (GLenum mode, const GLsizei *count, GLenum type, const GLvoid* *indices, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawElementsEXT(GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei primcount);
        private static TglMultiDrawElementsEXT glMultiDrawElementsEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_fog_coord
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFogCoordfEXT (GLfloat coord);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFogCoordfEXT(GLfloat coord);
        private static TglFogCoordfEXT glFogCoordfEXT = null;

        // GLAPI void APIENTRY glFogCoordfvEXT (const GLfloat *coord);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFogCoordfvEXT(GLfloat* coord);
        private static TglFogCoordfvEXT glFogCoordfvEXT = null;

        // GLAPI void APIENTRY glFogCoorddEXT (GLdouble coord);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFogCoorddEXT(GLdouble coord);
        private static TglFogCoorddEXT glFogCoorddEXT = null;

        // GLAPI void APIENTRY glFogCoorddvEXT (const GLdouble *coord);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFogCoorddvEXT(GLdouble* coord);
        private static TglFogCoorddvEXT glFogCoorddvEXT = null;

        // GLAPI void APIENTRY glFogCoordPointerEXT (GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFogCoordPointerEXT(GLenum type, GLsizei stride, void* pointer);
        private static TglFogCoordPointerEXT glFogCoordPointerEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_coordinate_frame
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTangent3bEXT (GLbyte tx, GLbyte ty, GLbyte tz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTangent3bEXT(GLbyte tx, GLbyte ty, GLbyte tz);
        private static TglTangent3bEXT glTangent3bEXT = null;

        // GLAPI void APIENTRY glTangent3bvEXT (const GLbyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTangent3bvEXT(GLbyte* v);
        private static TglTangent3bvEXT glTangent3bvEXT = null;

        // GLAPI void APIENTRY glTangent3dEXT (GLdouble tx, GLdouble ty, GLdouble tz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTangent3dEXT(GLdouble tx, GLdouble ty, GLdouble tz);
        private static TglTangent3dEXT glTangent3dEXT = null;

        // GLAPI void APIENTRY glTangent3dvEXT (const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTangent3dvEXT(GLdouble* v);
        private static TglTangent3dvEXT glTangent3dvEXT = null;

        // GLAPI void APIENTRY glTangent3fEXT (GLfloat tx, GLfloat ty, GLfloat tz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTangent3fEXT(GLfloat tx, GLfloat ty, GLfloat tz);
        private static TglTangent3fEXT glTangent3fEXT = null;

        // GLAPI void APIENTRY glTangent3fvEXT (const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTangent3fvEXT(GLfloat* v);
        private static TglTangent3fvEXT glTangent3fvEXT = null;

        // GLAPI void APIENTRY glTangent3iEXT (GLint tx, GLint ty, GLint tz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTangent3iEXT(GLint tx, GLint ty, GLint tz);
        private static TglTangent3iEXT glTangent3iEXT = null;

        // GLAPI void APIENTRY glTangent3ivEXT (const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTangent3ivEXT(GLint* v);
        private static TglTangent3ivEXT glTangent3ivEXT = null;

        // GLAPI void APIENTRY glTangent3sEXT (GLshort tx, GLshort ty, GLshort tz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTangent3sEXT(GLshort tx, GLshort ty, GLshort tz);
        private static TglTangent3sEXT glTangent3sEXT = null;

        // GLAPI void APIENTRY glTangent3svEXT (const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTangent3svEXT(GLshort* v);
        private static TglTangent3svEXT glTangent3svEXT = null;

        // GLAPI void APIENTRY glBinormal3bEXT (GLbyte bx, GLbyte by, GLbyte bz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBinormal3bEXT(GLbyte bx, GLbyte by, GLbyte bz);
        private static TglBinormal3bEXT glBinormal3bEXT = null;

        // GLAPI void APIENTRY glBinormal3bvEXT (const GLbyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBinormal3bvEXT(GLbyte* v);
        private static TglBinormal3bvEXT glBinormal3bvEXT = null;

        // GLAPI void APIENTRY glBinormal3dEXT (GLdouble bx, GLdouble by, GLdouble bz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBinormal3dEXT(GLdouble bx, GLdouble by, GLdouble bz);
        private static TglBinormal3dEXT glBinormal3dEXT = null;

        // GLAPI void APIENTRY glBinormal3dvEXT (const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBinormal3dvEXT(GLdouble* v);
        private static TglBinormal3dvEXT glBinormal3dvEXT = null;

        // GLAPI void APIENTRY glBinormal3fEXT (GLfloat bx, GLfloat by, GLfloat bz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBinormal3fEXT(GLfloat bx, GLfloat by, GLfloat bz);
        private static TglBinormal3fEXT glBinormal3fEXT = null;

        // GLAPI void APIENTRY glBinormal3fvEXT (const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBinormal3fvEXT(GLfloat* v);
        private static TglBinormal3fvEXT glBinormal3fvEXT = null;

        // GLAPI void APIENTRY glBinormal3iEXT (GLint bx, GLint by, GLint bz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBinormal3iEXT(GLint bx, GLint by, GLint bz);
        private static TglBinormal3iEXT glBinormal3iEXT = null;

        // GLAPI void APIENTRY glBinormal3ivEXT (const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBinormal3ivEXT(GLint* v);
        private static TglBinormal3ivEXT glBinormal3ivEXT = null;

        // GLAPI void APIENTRY glBinormal3sEXT (GLshort bx, GLshort by, GLshort bz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBinormal3sEXT(GLshort bx, GLshort by, GLshort bz);
        private static TglBinormal3sEXT glBinormal3sEXT = null;

        // GLAPI void APIENTRY glBinormal3svEXT (const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBinormal3svEXT(GLshort* v);
        private static TglBinormal3svEXT glBinormal3svEXT = null;

        // GLAPI void APIENTRY glTangentPointerEXT (GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTangentPointerEXT(GLenum type, GLsizei stride, void* pointer);
        private static TglTangentPointerEXT glTangentPointerEXT = null;

        // GLAPI void APIENTRY glBinormalPointerEXT (GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBinormalPointerEXT(GLenum type, GLsizei stride, void* pointer);
        private static TglBinormalPointerEXT glBinormalPointerEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_env_combine (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_func_separate
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendFuncSeparateEXT (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendFuncSeparateEXT(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
        private static TglBlendFuncSeparateEXT glBlendFuncSeparateEXT = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexWeightfEXT(GLfloat weight);
        private static TglVertexWeightfEXT glVertexWeightfEXT = null;

        // GLAPI void APIENTRY glVertexWeightfvEXT (const GLfloat *weight);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexWeightfvEXT(GLfloat* weight);
        private static TglVertexWeightfvEXT glVertexWeightfvEXT = null;

        // GLAPI void APIENTRY glVertexWeightPointerEXT (GLsizei size, GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexWeightPointerEXT(GLsizei size, GLenum type, GLsizei stride, void* pointer);
        private static TglVertexWeightPointerEXT glVertexWeightPointerEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_multisample
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glSampleMaskEXT (GLclampf value, GLboolean invert);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSampleMaskEXT(GLclampf value, GLboolean invert);
        private static TglSampleMaskEXT glSampleMaskEXT = null;

        // GLAPI void APIENTRY glSamplePatternEXT (GLenum pattern);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSamplePatternEXT(GLenum pattern);
        private static TglSamplePatternEXT glSamplePatternEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_env_dot3 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_vertex_shader
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginVertexShaderEXT (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginVertexShaderEXT();
        private static TglBeginVertexShaderEXT glBeginVertexShaderEXT = null;

        // GLAPI void APIENTRY glEndVertexShaderEXT (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndVertexShaderEXT();
        private static TglEndVertexShaderEXT glEndVertexShaderEXT = null;

        // GLAPI void APIENTRY glBindVertexShaderEXT (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindVertexShaderEXT(GLuint id);
        private static TglBindVertexShaderEXT glBindVertexShaderEXT = null;

        // GLAPI GLuint APIENTRY glGenVertexShadersEXT (GLuint range);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglGenVertexShadersEXT(GLuint range);
        private static TglGenVertexShadersEXT glGenVertexShadersEXT = null;

        // GLAPI void APIENTRY glDeleteVertexShaderEXT (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDeleteVertexShaderEXT(GLuint id);
        private static TglDeleteVertexShaderEXT glDeleteVertexShaderEXT = null;

        // GLAPI void APIENTRY glShaderOp1EXT (GLenum op, GLuint res, GLuint arg1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglShaderOp1EXT(GLenum op, GLuint res, GLuint arg1);
        private static TglShaderOp1EXT glShaderOp1EXT = null;

        // GLAPI void APIENTRY glShaderOp2EXT (GLenum op, GLuint res, GLuint arg1, GLuint arg2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglShaderOp2EXT(GLenum op, GLuint res, GLuint arg1, GLuint arg2);
        private static TglShaderOp2EXT glShaderOp2EXT = null;

        // GLAPI void APIENTRY glShaderOp3EXT (GLenum op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglShaderOp3EXT(GLenum op, GLuint res, GLuint arg1, GLuint arg2, GLuint arg3);
        private static TglShaderOp3EXT glShaderOp3EXT = null;

        // GLAPI void APIENTRY glSwizzleEXT (GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSwizzleEXT(GLuint res, GLuint inParam, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);
        private static TglSwizzleEXT glSwizzleEXT = null;

        // GLAPI void APIENTRY glWriteMaskEXT (GLuint res, GLuint in, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWriteMaskEXT(GLuint res, GLuint inParam, GLenum outX, GLenum outY, GLenum outZ, GLenum outW);
        private static TglWriteMaskEXT glWriteMaskEXT = null;

        // GLAPI void APIENTRY glInsertComponentEXT (GLuint res, GLuint src, GLuint num);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglInsertComponentEXT(GLuint res, GLuint src, GLuint num);
        private static TglInsertComponentEXT glInsertComponentEXT = null;

        // GLAPI void APIENTRY glExtractComponentEXT (GLuint res, GLuint src, GLuint num);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglExtractComponentEXT(GLuint res, GLuint src, GLuint num);
        private static TglExtractComponentEXT glExtractComponentEXT = null;

        // GLAPI GLuint APIENTRY glGenSymbolsEXT (GLenum datatype, GLenum storagetype, GLenum range, GLuint components);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglGenSymbolsEXT(GLenum datatype, GLenum storagetype, GLenum range, GLuint components);
        private static TglGenSymbolsEXT glGenSymbolsEXT = null;

        // GLAPI void APIENTRY glSetInvariantEXT (GLuint id, GLenum type, const GLvoid *addr);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSetInvariantEXT(GLuint id, GLenum type, void* addr);
        private static TglSetInvariantEXT glSetInvariantEXT = null;

        // GLAPI void APIENTRY glSetLocalConstantEXT (GLuint id, GLenum type, const GLvoid *addr);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSetLocalConstantEXT(GLuint id, GLenum type, void* addr);
        private static TglSetLocalConstantEXT glSetLocalConstantEXT = null;

        // GLAPI void APIENTRY glVariantbvEXT (GLuint id, const GLbyte *addr);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVariantbvEXT(GLuint id, GLbyte* addr);
        private static TglVariantbvEXT glVariantbvEXT = null;

        // GLAPI void APIENTRY glVariantsvEXT (GLuint id, const GLshort *addr);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVariantsvEXT(GLuint id, GLshort* addr);
        private static TglVariantsvEXT glVariantsvEXT = null;

        // GLAPI void APIENTRY glVariantivEXT (GLuint id, const GLint *addr);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVariantivEXT(GLuint id, GLint* addr);
        private static TglVariantivEXT glVariantivEXT = null;

        // GLAPI void APIENTRY glVariantfvEXT (GLuint id, const GLfloat *addr);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVariantfvEXT(GLuint id, GLfloat* addr);
        private static TglVariantfvEXT glVariantfvEXT = null;

        // GLAPI void APIENTRY glVariantdvEXT (GLuint id, const GLdouble *addr);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVariantdvEXT(GLuint id, GLdouble* addr);
        private static TglVariantdvEXT glVariantdvEXT = null;

        // GLAPI void APIENTRY glVariantubvEXT (GLuint id, const GLubyte *addr);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVariantubvEXT(GLuint id, GLubyte* addr);
        private static TglVariantubvEXT glVariantubvEXT = null;

        // GLAPI void APIENTRY glVariantusvEXT (GLuint id, const GLushort *addr);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVariantusvEXT(GLuint id, GLushort* addr);
        private static TglVariantusvEXT glVariantusvEXT = null;

        // GLAPI void APIENTRY glVariantuivEXT (GLuint id, const GLuint *addr);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVariantuivEXT(GLuint id, GLuint* addr);
        private static TglVariantuivEXT glVariantuivEXT = null;

        // GLAPI void APIENTRY glVariantPointerEXT (GLuint id, GLenum type, GLuint stride, const GLvoid *addr);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVariantPointerEXT(GLuint id, GLenum type, GLuint stride, void* addr);
        private static TglVariantPointerEXT glVariantPointerEXT = null;

        // GLAPI void APIENTRY glEnableVariantClientStateEXT (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEnableVariantClientStateEXT(GLuint id);
        private static TglEnableVariantClientStateEXT glEnableVariantClientStateEXT = null;

        // GLAPI void APIENTRY glDisableVariantClientStateEXT (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDisableVariantClientStateEXT(GLuint id);
        private static TglDisableVariantClientStateEXT glDisableVariantClientStateEXT = null;

        // GLAPI GLuint APIENTRY glBindLightParameterEXT (GLenum light, GLenum value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglBindLightParameterEXT(GLenum light, GLenum value);
        private static TglBindLightParameterEXT glBindLightParameterEXT = null;

        // GLAPI GLuint APIENTRY glBindMaterialParameterEXT (GLenum face, GLenum value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglBindMaterialParameterEXT(GLenum face, GLenum value);
        private static TglBindMaterialParameterEXT glBindMaterialParameterEXT = null;

        // GLAPI GLuint APIENTRY glBindTexGenParameterEXT (GLenum unit, GLenum coord, GLenum value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglBindTexGenParameterEXT(GLenum unit, GLenum coord, GLenum value);
        private static TglBindTexGenParameterEXT glBindTexGenParameterEXT = null;

        // GLAPI GLuint APIENTRY glBindTextureUnitParameterEXT (GLenum unit, GLenum value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglBindTextureUnitParameterEXT(GLenum unit, GLenum value);
        private static TglBindTextureUnitParameterEXT glBindTextureUnitParameterEXT = null;

        // GLAPI GLuint APIENTRY glBindParameterEXT (GLenum value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglBindParameterEXT(GLenum value);
        private static TglBindParameterEXT glBindParameterEXT = null;

        // GLAPI GLboolean APIENTRY glIsVariantEnabledEXT (GLuint id, GLenum cap);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsVariantEnabledEXT(GLuint id, GLenum cap);
        private static TglIsVariantEnabledEXT glIsVariantEnabledEXT = null;

        // GLAPI void APIENTRY glGetVariantBooleanvEXT (GLuint id, GLenum value, GLboolean *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVariantBooleanvEXT(GLuint id, GLenum value, GLboolean* data);
        private static TglGetVariantBooleanvEXT glGetVariantBooleanvEXT = null;

        // GLAPI void APIENTRY glGetVariantIntegervEXT (GLuint id, GLenum value, GLint *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVariantIntegervEXT(GLuint id, GLenum value, GLint* data);
        private static TglGetVariantIntegervEXT glGetVariantIntegervEXT = null;

        // GLAPI void APIENTRY glGetVariantFloatvEXT (GLuint id, GLenum value, GLfloat *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVariantFloatvEXT(GLuint id, GLenum value, GLfloat* data);
        private static TglGetVariantFloatvEXT glGetVariantFloatvEXT = null;

        // GLAPI void APIENTRY glGetVariantPointervEXT (GLuint id, GLenum value, GLvoid* *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVariantPointervEXT(GLuint id, GLenum value, void** data);
        private static TglGetVariantPointervEXT glGetVariantPointervEXT = null;

        // GLAPI void APIENTRY glGetInvariantBooleanvEXT (GLuint id, GLenum value, GLboolean *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetInvariantBooleanvEXT(GLuint id, GLenum value, GLboolean* data);
        private static TglGetInvariantBooleanvEXT glGetInvariantBooleanvEXT = null;

        // GLAPI void APIENTRY glGetInvariantIntegervEXT (GLuint id, GLenum value, GLint *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetInvariantIntegervEXT(GLuint id, GLenum value, GLint* data);
        private static TglGetInvariantIntegervEXT glGetInvariantIntegervEXT = null;

        // GLAPI void APIENTRY glGetInvariantFloatvEXT (GLuint id, GLenum value, GLfloat *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetInvariantFloatvEXT(GLuint id, GLenum value, GLfloat* data);
        private static TglGetInvariantFloatvEXT glGetInvariantFloatvEXT = null;

        // GLAPI void APIENTRY glGetLocalConstantBooleanvEXT (GLuint id, GLenum value, GLboolean *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetLocalConstantBooleanvEXT(GLuint id, GLenum value, GLboolean* data);
        private static TglGetLocalConstantBooleanvEXT glGetLocalConstantBooleanvEXT = null;

        // GLAPI void APIENTRY glGetLocalConstantIntegervEXT (GLuint id, GLenum value, GLint *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetLocalConstantIntegervEXT(GLuint id, GLenum value, GLint* data);
        private static TglGetLocalConstantIntegervEXT glGetLocalConstantIntegervEXT = null;

        // GLAPI void APIENTRY glGetLocalConstantFloatvEXT (GLuint id, GLenum value, GLfloat *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetLocalConstantFloatvEXT(GLuint id, GLenum value, GLfloat* data);
        private static TglGetLocalConstantFloatvEXT glGetLocalConstantFloatvEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_shadow_funcs (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_stencil_two_side (no function entry points)
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glActiveStencilFaceEXT (GLenum face);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglActiveStencilFaceEXT(GLenum face);
        private static TglActiveStencilFaceEXT glActiveStencilFaceEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_depth_bounds_test
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDepthBoundsEXT (GLclampd zmin, GLclampd zmax);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDepthBoundsEXT(GLclampd zmin, GLclampd zmax);
        private static TglDepthBoundsEXT glDepthBoundsEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_mirror_clamp (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_equation_separate
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendEquationSeparateEXT (GLenum modeRGB, GLenum modeAlpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendEquationSeparateEXT(GLenum modeRGB, GLenum modeAlpha);
        private static TglBlendEquationSeparateEXT glBlendEquationSeparateEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_pixel_buffer_object (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_framebuffer_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLboolean APIENTRY glIsRenderbufferEXT (GLuint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsRenderbufferEXT(GLuint renderbuffer);
        private static TglIsRenderbufferEXT glIsRenderbufferEXT = null;

        // GLAPI void APIENTRY glBindRenderbufferEXT (GLenum target, GLuint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindRenderbufferEXT(GLenum target, GLuint renderbuffer);
        private static TglBindRenderbufferEXT glBindRenderbufferEXT = null;

        // GLAPI void APIENTRY glDeleteRenderbuffersEXT (GLsizei n, const GLuint *renderbuffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteRenderbuffersEXT(GLsizei n, GLuint* renderbuffers);
        private static TglDeleteRenderbuffersEXT glDeleteRenderbuffersEXT = null;

        // GLAPI void APIENTRY glGenRenderbuffersEXT (GLsizei n, GLuint *renderbuffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenRenderbuffersEXT(GLsizei n, GLuint* renderbuffers);
        private static TglGenRenderbuffersEXT glGenRenderbuffersEXT = null;

        // GLAPI void APIENTRY glRenderbufferStorageEXT (GLenum target, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRenderbufferStorageEXT(GLenum target, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglRenderbufferStorageEXT glRenderbufferStorageEXT = null;

        // GLAPI void APIENTRY glGetRenderbufferParameterivEXT (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetRenderbufferParameterivEXT(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetRenderbufferParameterivEXT glGetRenderbufferParameterivEXT = null;

        // GLAPI GLboolean APIENTRY glIsFramebufferEXT (GLuint framebuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsFramebufferEXT(GLuint framebuffer);
        private static TglIsFramebufferEXT glIsFramebufferEXT = null;

        // GLAPI void APIENTRY glBindFramebufferEXT (GLenum target, GLuint framebuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindFramebufferEXT(GLenum target, GLuint framebuffer);
        private static TglBindFramebufferEXT glBindFramebufferEXT = null;

        // GLAPI void APIENTRY glDeleteFramebuffersEXT (GLsizei n, const GLuint *framebuffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteFramebuffersEXT(GLsizei n, GLuint* framebuffers);
        private static TglDeleteFramebuffersEXT glDeleteFramebuffersEXT = null;

        // GLAPI void APIENTRY glGenFramebuffersEXT (GLsizei n, GLuint *framebuffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenFramebuffersEXT(GLsizei n, GLuint* framebuffers);
        private static TglGenFramebuffersEXT glGenFramebuffersEXT = null;

        // GLAPI GLenum APIENTRY glCheckFramebufferStatusEXT (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLenum TglCheckFramebufferStatusEXT(GLenum target);
        private static TglCheckFramebufferStatusEXT glCheckFramebufferStatusEXT = null;

        // GLAPI void APIENTRY glFramebufferTexture1DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTexture1DEXT(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        private static TglFramebufferTexture1DEXT glFramebufferTexture1DEXT = null;

        // GLAPI void APIENTRY glFramebufferTexture2DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTexture2DEXT(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        private static TglFramebufferTexture2DEXT glFramebufferTexture2DEXT = null;

        // GLAPI void APIENTRY glFramebufferTexture3DEXT (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTexture3DEXT(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);
        private static TglFramebufferTexture3DEXT glFramebufferTexture3DEXT = null;

        // GLAPI void APIENTRY glFramebufferRenderbufferEXT (GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferRenderbufferEXT(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
        private static TglFramebufferRenderbufferEXT glFramebufferRenderbufferEXT = null;

        // GLAPI void APIENTRY glGetFramebufferAttachmentParameterivEXT (GLenum target, GLenum attachment, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFramebufferAttachmentParameterivEXT(GLenum target, GLenum attachment, GLenum pname, GLint* parameters);
        private static TglGetFramebufferAttachmentParameterivEXT glGetFramebufferAttachmentParameterivEXT = null;

        // GLAPI void APIENTRY glGenerateMipmapEXT (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGenerateMipmapEXT(GLenum target);
        private static TglGenerateMipmapEXT glGenerateMipmapEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_packed_depth_stencil (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_stencil_clear_tag
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glStencilClearTagEXT (GLsizei stencilTagBits, GLuint stencilClearTag);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStencilClearTagEXT(GLsizei stencilTagBits, GLuint stencilClearTag);
        private static TglStencilClearTagEXT glStencilClearTagEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_sRGB (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_framebuffer_blit
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlitFramebufferEXT (GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlitFramebufferEXT(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);
        private static TglBlitFramebufferEXT glBlitFramebufferEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_framebuffer_multisample
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glRenderbufferStorageMultisampleEXT (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRenderbufferStorageMultisampleEXT(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglRenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_timer_query
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetQueryObjecti64vEXT (GLuint id, GLenum pname, GLint64EXT *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetQueryObjecti64vEXT(GLuint id, GLenum pname, GLint64* parameters);
        private static TglGetQueryObjecti64vEXT glGetQueryObjecti64vEXT = null;

        // GLAPI void APIENTRY glGetQueryObjectui64vEXT (GLuint id, GLenum pname, GLuint64EXT *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetQueryObjectui64vEXT(GLuint id, GLenum pname, GLuint64* parameters);
        private static TglGetQueryObjectui64vEXT glGetQueryObjectui64vEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_gpu_program_parameters
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glProgramEnvParameters4fvEXT (GLenum target, GLuint index, GLsizei count, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramEnvParameters4fvEXT(GLenum target, GLuint index, GLsizei count, GLfloat* parameters);
        private static TglProgramEnvParameters4fvEXT glProgramEnvParameters4fvEXT = null;

        // GLAPI void APIENTRY glProgramLocalParameters4fvEXT (GLenum target, GLuint index, GLsizei count, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramLocalParameters4fvEXT(GLenum target, GLuint index, GLsizei count, GLfloat* parameters);
        private static TglProgramLocalParameters4fvEXT glProgramLocalParameters4fvEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_geometry_shader4
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glProgramParameteriEXT (GLuint program, GLenum pname, GLint value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramParameteriEXT(GLuint program, GLenum pname, GLint value);
        private static TglProgramParameteriEXT glProgramParameteriEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_gpu_shader4
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetUniformuivEXT (GLuint program, GLint location, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformuivEXT(GLuint program, GLint location, GLuint* parameters);
        private static TglGetUniformuivEXT glGetUniformuivEXT = null;

        // GLAPI void APIENTRY glBindFragDataLocationEXT (GLuint program, GLuint color, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindFragDataLocationEXT(GLuint program, GLuint color, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglBindFragDataLocationEXT glBindFragDataLocationEXT = null;

        // GLAPI GLint APIENTRY glGetFragDataLocationEXT (GLuint program, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLint TglGetFragDataLocationEXT(GLuint program, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglGetFragDataLocationEXT glGetFragDataLocationEXT = null;

        // GLAPI void APIENTRY glUniform1uiEXT (GLint location, GLuint v0);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform1uiEXT(GLint location, GLuint v0);
        private static TglUniform1uiEXT glUniform1uiEXT = null;

        // GLAPI void APIENTRY glUniform2uiEXT (GLint location, GLuint v0, GLuint v1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform2uiEXT(GLint location, GLuint v0, GLuint v1);
        private static TglUniform2uiEXT glUniform2uiEXT = null;

        // GLAPI void APIENTRY glUniform3uiEXT (GLint location, GLuint v0, GLuint v1, GLuint v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform3uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2);
        private static TglUniform3uiEXT glUniform3uiEXT = null;

        // GLAPI void APIENTRY glUniform4uiEXT (GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform4uiEXT(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
        private static TglUniform4uiEXT glUniform4uiEXT = null;

        // GLAPI void APIENTRY glUniform1uivEXT (GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform1uivEXT(GLint location, GLsizei count, GLuint* value);
        private static TglUniform1uivEXT glUniform1uivEXT = null;

        // GLAPI void APIENTRY glUniform2uivEXT (GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform2uivEXT(GLint location, GLsizei count, GLuint* value);
        private static TglUniform2uivEXT glUniform2uivEXT = null;

        // GLAPI void APIENTRY glUniform3uivEXT (GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform3uivEXT(GLint location, GLsizei count, GLuint* value);
        private static TglUniform3uivEXT glUniform3uivEXT = null;

        // GLAPI void APIENTRY glUniform4uivEXT (GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform4uivEXT(GLint location, GLsizei count, GLuint* value);
        private static TglUniform4uivEXT glUniform4uivEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_draw_instanced
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDrawArraysInstancedEXT (GLenum mode, GLint start, GLsizei count, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawArraysInstancedEXT(GLenum mode, GLint start, GLsizei count, GLsizei primcount);
        private static TglDrawArraysInstancedEXT glDrawArraysInstancedEXT = null;

        // GLAPI void APIENTRY glDrawElementsInstancedEXT (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawElementsInstancedEXT(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount);
        private static TglDrawElementsInstancedEXT glDrawElementsInstancedEXT = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexBufferEXT(GLenum target, GLenum internalformat, GLuint buffer);
        private static TglTexBufferEXT glTexBufferEXT = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColorMaskIndexedEXT(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);
        private static TglColorMaskIndexedEXT glColorMaskIndexedEXT = null;

        // GLAPI void APIENTRY glGetBooleanIndexedvEXT (GLenum target, GLuint index, GLboolean *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetBooleanIndexedvEXT(GLenum target, GLuint index, GLboolean* data);
        private static TglGetBooleanIndexedvEXT glGetBooleanIndexedvEXT = null;

        // GLAPI void APIENTRY glGetIntegerIndexedvEXT (GLenum target, GLuint index, GLint *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetIntegerIndexedvEXT(GLenum target, GLuint index, GLint* data);
        private static TglGetIntegerIndexedvEXT glGetIntegerIndexedvEXT = null;

        // GLAPI void APIENTRY glEnableIndexedEXT (GLenum target, GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEnableIndexedEXT(GLenum target, GLuint index);
        private static TglEnableIndexedEXT glEnableIndexedEXT = null;

        // GLAPI void APIENTRY glDisableIndexedEXT (GLenum target, GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDisableIndexedEXT(GLenum target, GLuint index);
        private static TglDisableIndexedEXT glDisableIndexedEXT = null;

        // GLAPI GLboolean APIENTRY glIsEnabledIndexedEXT (GLenum target, GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsEnabledIndexedEXT(GLenum target, GLuint index);
        private static TglIsEnabledIndexedEXT glIsEnabledIndexedEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_bindable_uniform
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glUniformBufferEXT (GLuint program, GLint location, GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniformBufferEXT(GLuint program, GLint location, GLuint buffer);
        private static TglUniformBufferEXT glUniformBufferEXT = null;

        // GLAPI GLint APIENTRY glGetUniformBufferSizeEXT (GLuint program, GLint location);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLint TglGetUniformBufferSizeEXT(GLuint program, GLint location);
        private static TglGetUniformBufferSizeEXT glGetUniformBufferSizeEXT = null;

        // GLAPI GLintptr APIENTRY glGetUniformOffsetEXT (GLuint program, GLint location);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLintptr TglGetUniformOffsetEXT(GLuint program, GLint location);
        private static TglGetUniformOffsetEXT glGetUniformOffsetEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_integer
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexParameterIivEXT (GLenum target, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexParameterIivEXT(GLenum target, GLenum pname, GLint* parameters);
        private static TglTexParameterIivEXT glTexParameterIivEXT = null;

        // GLAPI void APIENTRY glTexParameterIuivEXT (GLenum target, GLenum pname, const GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexParameterIuivEXT(GLenum target, GLenum pname, GLuint* parameters);
        private static TglTexParameterIuivEXT glTexParameterIuivEXT = null;

        // GLAPI void APIENTRY glGetTexParameterIivEXT (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexParameterIivEXT(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetTexParameterIivEXT glGetTexParameterIivEXT = null;

        // GLAPI void APIENTRY glGetTexParameterIuivEXT (GLenum target, GLenum pname, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexParameterIuivEXT(GLenum target, GLenum pname, GLuint* parameters);
        private static TglGetTexParameterIuivEXT glGetTexParameterIuivEXT = null;

        // GLAPI void APIENTRY glClearColorIiEXT (GLint red, GLint green, GLint blue, GLint alpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearColorIiEXT(GLint red, GLint green, GLint blue, GLint alpha);
        private static TglClearColorIiEXT glClearColorIiEXT = null;

        // GLAPI void APIENTRY glClearColorIuiEXT (GLuint red, GLuint green, GLuint blue, GLuint alpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearColorIuiEXT(GLuint red, GLuint green, GLuint blue, GLuint alpha);
        private static TglClearColorIuiEXT glClearColorIuiEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_transform_feedback
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginTransformFeedbackEXT (GLenum primitiveMode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginTransformFeedbackEXT(GLenum primitiveMode);
        private static TglBeginTransformFeedbackEXT glBeginTransformFeedbackEXT = null;

        // GLAPI void APIENTRY glEndTransformFeedbackEXT (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndTransformFeedbackEXT();
        private static TglEndTransformFeedbackEXT glEndTransformFeedbackEXT = null;

        // GLAPI void APIENTRY glBindBufferRangeEXT (GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindBufferRangeEXT(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
        private static TglBindBufferRangeEXT glBindBufferRangeEXT = null;

        // GLAPI void APIENTRY glBindBufferOffsetEXT (GLenum target, GLuint index, GLuint buffer, GLintptr offset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindBufferOffsetEXT(GLenum target, GLuint index, GLuint buffer, GLintptr offset);
        private static TglBindBufferOffsetEXT glBindBufferOffsetEXT = null;

        // GLAPI void APIENTRY glBindBufferBaseEXT (GLenum target, GLuint index, GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindBufferBaseEXT(GLenum target, GLuint index, GLuint buffer);
        private static TglBindBufferBaseEXT glBindBufferBaseEXT = null;

        // GLAPI void APIENTRY glTransformFeedbackVaryingsEXT (GLuint program, GLsizei count, const GLchar* *varyings, GLenum bufferMode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTransformFeedbackVaryingsEXT(GLuint program, GLsizei count, GLchar** varyings, GLenum bufferMode);
        private static TglTransformFeedbackVaryingsEXT glTransformFeedbackVaryingsEXT = null;

        // GLAPI void APIENTRY glGetTransformFeedbackVaryingEXT (GLuint program, GLuint index, GLsizei bufSize, GLsizei *length, GLsizei *size, GLenum *type, GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTransformFeedbackVaryingEXT(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name);
        private static TglGetTransformFeedbackVaryingEXT glGetTransformFeedbackVaryingEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_direct_state_access
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glClientAttribDefaultEXT (GLbitfield mask);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClientAttribDefaultEXT(GLbitfield mask);
        private static TglClientAttribDefaultEXT glClientAttribDefaultEXT = null;

        // GLAPI void APIENTRY glPushClientAttribDefaultEXT (GLbitfield mask);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPushClientAttribDefaultEXT(GLbitfield mask);
        private static TglPushClientAttribDefaultEXT glPushClientAttribDefaultEXT = null;

        // GLAPI void APIENTRY glMatrixLoadfEXT (GLenum mode, const GLfloat *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMatrixLoadfEXT(GLenum mode, GLfloat* m);
        private static TglMatrixLoadfEXT glMatrixLoadfEXT = null;

        // GLAPI void APIENTRY glMatrixLoaddEXT (GLenum mode, const GLdouble *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMatrixLoaddEXT(GLenum mode, GLdouble* m);
        private static TglMatrixLoaddEXT glMatrixLoaddEXT = null;

        // GLAPI void APIENTRY glMatrixMultfEXT (GLenum mode, const GLfloat *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMatrixMultfEXT(GLenum mode, GLfloat* m);
        private static TglMatrixMultfEXT glMatrixMultfEXT = null;

        // GLAPI void APIENTRY glMatrixMultdEXT (GLenum mode, const GLdouble *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMatrixMultdEXT(GLenum mode, GLdouble* m);
        private static TglMatrixMultdEXT glMatrixMultdEXT = null;

        // GLAPI void APIENTRY glMatrixLoadIdentityEXT (GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMatrixLoadIdentityEXT(GLenum mode);
        private static TglMatrixLoadIdentityEXT glMatrixLoadIdentityEXT = null;

        // GLAPI void APIENTRY glMatrixRotatefEXT (GLenum mode, GLfloat angle, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMatrixRotatefEXT(GLenum mode, GLfloat angle, GLfloat x, GLfloat y, GLfloat z);
        private static TglMatrixRotatefEXT glMatrixRotatefEXT = null;

        // GLAPI void APIENTRY glMatrixRotatedEXT (GLenum mode, GLdouble angle, GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMatrixRotatedEXT(GLenum mode, GLdouble angle, GLdouble x, GLdouble y, GLdouble z);
        private static TglMatrixRotatedEXT glMatrixRotatedEXT = null;

        // GLAPI void APIENTRY glMatrixScalefEXT (GLenum mode, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMatrixScalefEXT(GLenum mode, GLfloat x, GLfloat y, GLfloat z);
        private static TglMatrixScalefEXT glMatrixScalefEXT = null;

        // GLAPI void APIENTRY glMatrixScaledEXT (GLenum mode, GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMatrixScaledEXT(GLenum mode, GLdouble x, GLdouble y, GLdouble z);
        private static TglMatrixScaledEXT glMatrixScaledEXT = null;

        // GLAPI void APIENTRY glMatrixTranslatefEXT (GLenum mode, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMatrixTranslatefEXT(GLenum mode, GLfloat x, GLfloat y, GLfloat z);
        private static TglMatrixTranslatefEXT glMatrixTranslatefEXT = null;

        // GLAPI void APIENTRY glMatrixTranslatedEXT (GLenum mode, GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMatrixTranslatedEXT(GLenum mode, GLdouble x, GLdouble y, GLdouble z);
        private static TglMatrixTranslatedEXT glMatrixTranslatedEXT = null;

        // GLAPI void APIENTRY glMatrixFrustumEXT (GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMatrixFrustumEXT(GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
        private static TglMatrixFrustumEXT glMatrixFrustumEXT = null;

        // GLAPI void APIENTRY glMatrixOrthoEXT (GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMatrixOrthoEXT(GLenum mode, GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
        private static TglMatrixOrthoEXT glMatrixOrthoEXT = null;

        // GLAPI void APIENTRY glMatrixPopEXT (GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMatrixPopEXT(GLenum mode);
        private static TglMatrixPopEXT glMatrixPopEXT = null;

        // GLAPI void APIENTRY glMatrixPushEXT (GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMatrixPushEXT(GLenum mode);
        private static TglMatrixPushEXT glMatrixPushEXT = null;

        // GLAPI void APIENTRY glMatrixLoadTransposefEXT (GLenum mode, const GLfloat *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMatrixLoadTransposefEXT(GLenum mode, GLfloat* m);
        private static TglMatrixLoadTransposefEXT glMatrixLoadTransposefEXT = null;

        // GLAPI void APIENTRY glMatrixLoadTransposedEXT (GLenum mode, const GLdouble *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMatrixLoadTransposedEXT(GLenum mode, GLdouble* m);
        private static TglMatrixLoadTransposedEXT glMatrixLoadTransposedEXT = null;

        // GLAPI void APIENTRY glMatrixMultTransposefEXT (GLenum mode, const GLfloat *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMatrixMultTransposefEXT(GLenum mode, GLfloat* m);
        private static TglMatrixMultTransposefEXT glMatrixMultTransposefEXT = null;

        // GLAPI void APIENTRY glMatrixMultTransposedEXT (GLenum mode, const GLdouble *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMatrixMultTransposedEXT(GLenum mode, GLdouble* m);
        private static TglMatrixMultTransposedEXT glMatrixMultTransposedEXT = null;

        // GLAPI void APIENTRY glTextureParameterfEXT (GLuint texture, GLenum target, GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureParameterfEXT(GLuint texture, GLenum target, GLenum pname, GLfloat param);
        private static TglTextureParameterfEXT glTextureParameterfEXT = null;

        // GLAPI void APIENTRY glTextureParameterfvEXT (GLuint texture, GLenum target, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureParameterfvEXT(GLuint texture, GLenum target, GLenum pname, GLfloat* parameters);
        private static TglTextureParameterfvEXT glTextureParameterfvEXT = null;

        // GLAPI void APIENTRY glTextureParameteriEXT (GLuint texture, GLenum target, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureParameteriEXT(GLuint texture, GLenum target, GLenum pname, GLint param);
        private static TglTextureParameteriEXT glTextureParameteriEXT = null;

        // GLAPI void APIENTRY glTextureParameterivEXT (GLuint texture, GLenum target, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureParameterivEXT(GLuint texture, GLenum target, GLenum pname, GLint* parameters);
        private static TglTextureParameterivEXT glTextureParameterivEXT = null;

        // GLAPI void APIENTRY glTextureImage1DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureImage1DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels);
        private static TglTextureImage1DEXT glTextureImage1DEXT = null;

        // GLAPI void APIENTRY glTextureImage2DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureImage2DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels);
        private static TglTextureImage2DEXT glTextureImage2DEXT = null;

        // GLAPI void APIENTRY glTextureSubImage1DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureSubImage1DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);
        private static TglTextureSubImage1DEXT glTextureSubImage1DEXT = null;

        // GLAPI void APIENTRY glTextureSubImage2DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureSubImage2DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);
        private static TglTextureSubImage2DEXT glTextureSubImage2DEXT = null;

        // GLAPI void APIENTRY glCopyTextureImage1DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTextureImage1DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);
        private static TglCopyTextureImage1DEXT glCopyTextureImage1DEXT = null;

        // GLAPI void APIENTRY glCopyTextureImage2DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTextureImage2DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        private static TglCopyTextureImage2DEXT glCopyTextureImage2DEXT = null;

        // GLAPI void APIENTRY glCopyTextureSubImage1DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTextureSubImage1DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        private static TglCopyTextureSubImage1DEXT glCopyTextureSubImage1DEXT = null;

        // GLAPI void APIENTRY glCopyTextureSubImage2DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTextureSubImage2DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglCopyTextureSubImage2DEXT glCopyTextureSubImage2DEXT = null;

        // GLAPI void APIENTRY glGetTextureImageEXT (GLuint texture, GLenum target, GLint level, GLenum format, GLenum type, GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureImageEXT(GLuint texture, GLenum target, GLint level, GLenum format, GLenum type, void* pixels);
        private static TglGetTextureImageEXT glGetTextureImageEXT = null;

        // GLAPI void APIENTRY glGetTextureParameterfvEXT (GLuint texture, GLenum target, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureParameterfvEXT(GLuint texture, GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetTextureParameterfvEXT glGetTextureParameterfvEXT = null;

        // GLAPI void APIENTRY glGetTextureParameterivEXT (GLuint texture, GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureParameterivEXT(GLuint texture, GLenum target, GLenum pname, GLint* parameters);
        private static TglGetTextureParameterivEXT glGetTextureParameterivEXT = null;

        // GLAPI void APIENTRY glGetTextureLevelParameterfvEXT (GLuint texture, GLenum target, GLint level, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureLevelParameterfvEXT(GLuint texture, GLenum target, GLint level, GLenum pname, GLfloat* parameters);
        private static TglGetTextureLevelParameterfvEXT glGetTextureLevelParameterfvEXT = null;

        // GLAPI void APIENTRY glGetTextureLevelParameterivEXT (GLuint texture, GLenum target, GLint level, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureLevelParameterivEXT(GLuint texture, GLenum target, GLint level, GLenum pname, GLint* parameters);
        private static TglGetTextureLevelParameterivEXT glGetTextureLevelParameterivEXT = null;

        // GLAPI void APIENTRY glTextureImage3DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureImage3DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels);
        private static TglTextureImage3DEXT glTextureImage3DEXT = null;

        // GLAPI void APIENTRY glTextureSubImage3DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureSubImage3DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels);
        private static TglTextureSubImage3DEXT glTextureSubImage3DEXT = null;

        // GLAPI void APIENTRY glCopyTextureSubImage3DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTextureSubImage3DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglCopyTextureSubImage3DEXT glCopyTextureSubImage3DEXT = null;

        // GLAPI void APIENTRY glMultiTexParameterfEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexParameterfEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat param);
        private static TglMultiTexParameterfEXT glMultiTexParameterfEXT = null;

        // GLAPI void APIENTRY glMultiTexParameterfvEXT (GLenum texunit, GLenum target, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexParameterfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat* parameters);
        private static TglMultiTexParameterfvEXT glMultiTexParameterfvEXT = null;

        // GLAPI void APIENTRY glMultiTexParameteriEXT (GLenum texunit, GLenum target, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexParameteriEXT(GLenum texunit, GLenum target, GLenum pname, GLint param);
        private static TglMultiTexParameteriEXT glMultiTexParameteriEXT = null;

        // GLAPI void APIENTRY glMultiTexParameterivEXT (GLenum texunit, GLenum target, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexParameterivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* parameters);
        private static TglMultiTexParameterivEXT glMultiTexParameterivEXT = null;

        // GLAPI void APIENTRY glMultiTexImage1DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexImage1DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels);
        private static TglMultiTexImage1DEXT glMultiTexImage1DEXT = null;

        // GLAPI void APIENTRY glMultiTexImage2DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexImage2DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels);
        private static TglMultiTexImage2DEXT glMultiTexImage2DEXT = null;

        // GLAPI void APIENTRY glMultiTexSubImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexSubImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);
        private static TglMultiTexSubImage1DEXT glMultiTexSubImage1DEXT = null;

        // GLAPI void APIENTRY glMultiTexSubImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexSubImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);
        private static TglMultiTexSubImage2DEXT glMultiTexSubImage2DEXT = null;

        // GLAPI void APIENTRY glCopyMultiTexImage1DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyMultiTexImage1DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);
        private static TglCopyMultiTexImage1DEXT glCopyMultiTexImage1DEXT = null;

        // GLAPI void APIENTRY glCopyMultiTexImage2DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyMultiTexImage2DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        private static TglCopyMultiTexImage2DEXT glCopyMultiTexImage2DEXT = null;

        // GLAPI void APIENTRY glCopyMultiTexSubImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyMultiTexSubImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        private static TglCopyMultiTexSubImage1DEXT glCopyMultiTexSubImage1DEXT = null;

        // GLAPI void APIENTRY glCopyMultiTexSubImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyMultiTexSubImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglCopyMultiTexSubImage2DEXT glCopyMultiTexSubImage2DEXT = null;

        // GLAPI void APIENTRY glGetMultiTexImageEXT (GLenum texunit, GLenum target, GLint level, GLenum format, GLenum type, GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultiTexImageEXT(GLenum texunit, GLenum target, GLint level, GLenum format, GLenum type, void* pixels);
        private static TglGetMultiTexImageEXT glGetMultiTexImageEXT = null;

        // GLAPI void APIENTRY glGetMultiTexParameterfvEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultiTexParameterfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetMultiTexParameterfvEXT glGetMultiTexParameterfvEXT = null;

        // GLAPI void APIENTRY glGetMultiTexParameterivEXT (GLenum texunit, GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultiTexParameterivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* parameters);
        private static TglGetMultiTexParameterivEXT glGetMultiTexParameterivEXT = null;

        // GLAPI void APIENTRY glGetMultiTexLevelParameterfvEXT (GLenum texunit, GLenum target, GLint level, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultiTexLevelParameterfvEXT(GLenum texunit, GLenum target, GLint level, GLenum pname, GLfloat* parameters);
        private static TglGetMultiTexLevelParameterfvEXT glGetMultiTexLevelParameterfvEXT = null;

        // GLAPI void APIENTRY glGetMultiTexLevelParameterivEXT (GLenum texunit, GLenum target, GLint level, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultiTexLevelParameterivEXT(GLenum texunit, GLenum target, GLint level, GLenum pname, GLint* parameters);
        private static TglGetMultiTexLevelParameterivEXT glGetMultiTexLevelParameterivEXT = null;

        // GLAPI void APIENTRY glMultiTexImage3DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexImage3DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels);
        private static TglMultiTexImage3DEXT glMultiTexImage3DEXT = null;

        // GLAPI void APIENTRY glMultiTexSubImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexSubImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels);
        private static TglMultiTexSubImage3DEXT glMultiTexSubImage3DEXT = null;

        // GLAPI void APIENTRY glCopyMultiTexSubImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyMultiTexSubImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglCopyMultiTexSubImage3DEXT glCopyMultiTexSubImage3DEXT = null;

        // GLAPI void APIENTRY glBindMultiTextureEXT (GLenum texunit, GLenum target, GLuint texture);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindMultiTextureEXT(GLenum texunit, GLenum target, GLuint texture);
        private static TglBindMultiTextureEXT glBindMultiTextureEXT = null;

        // GLAPI void APIENTRY glEnableClientStateIndexedEXT (GLenum array, GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEnableClientStateIndexedEXT(GLenum array, GLuint index);
        private static TglEnableClientStateIndexedEXT glEnableClientStateIndexedEXT = null;

        // GLAPI void APIENTRY glDisableClientStateIndexedEXT (GLenum array, GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDisableClientStateIndexedEXT(GLenum array, GLuint index);
        private static TglDisableClientStateIndexedEXT glDisableClientStateIndexedEXT = null;

        // GLAPI void APIENTRY glMultiTexCoordPointerEXT (GLenum texunit, GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoordPointerEXT(GLenum texunit, GLint size, GLenum type, GLsizei stride, void* pointer);
        private static TglMultiTexCoordPointerEXT glMultiTexCoordPointerEXT = null;

        // GLAPI void APIENTRY glMultiTexEnvfEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexEnvfEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat param);
        private static TglMultiTexEnvfEXT glMultiTexEnvfEXT = null;

        // GLAPI void APIENTRY glMultiTexEnvfvEXT (GLenum texunit, GLenum target, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexEnvfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat* parameters);
        private static TglMultiTexEnvfvEXT glMultiTexEnvfvEXT = null;

        // GLAPI void APIENTRY glMultiTexEnviEXT (GLenum texunit, GLenum target, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexEnviEXT(GLenum texunit, GLenum target, GLenum pname, GLint param);
        private static TglMultiTexEnviEXT glMultiTexEnviEXT = null;

        // GLAPI void APIENTRY glMultiTexEnvivEXT (GLenum texunit, GLenum target, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexEnvivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* parameters);
        private static TglMultiTexEnvivEXT glMultiTexEnvivEXT = null;

        // GLAPI void APIENTRY glMultiTexGendEXT (GLenum texunit, GLenum coord, GLenum pname, GLdouble param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexGendEXT(GLenum texunit, GLenum coord, GLenum pname, GLdouble param);
        private static TglMultiTexGendEXT glMultiTexGendEXT = null;

        // GLAPI void APIENTRY glMultiTexGendvEXT (GLenum texunit, GLenum coord, GLenum pname, const GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexGendvEXT(GLenum texunit, GLenum coord, GLenum pname, GLdouble* parameters);
        private static TglMultiTexGendvEXT glMultiTexGendvEXT = null;

        // GLAPI void APIENTRY glMultiTexGenfEXT (GLenum texunit, GLenum coord, GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexGenfEXT(GLenum texunit, GLenum coord, GLenum pname, GLfloat param);
        private static TglMultiTexGenfEXT glMultiTexGenfEXT = null;

        // GLAPI void APIENTRY glMultiTexGenfvEXT (GLenum texunit, GLenum coord, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexGenfvEXT(GLenum texunit, GLenum coord, GLenum pname, GLfloat* parameters);
        private static TglMultiTexGenfvEXT glMultiTexGenfvEXT = null;

        // GLAPI void APIENTRY glMultiTexGeniEXT (GLenum texunit, GLenum coord, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexGeniEXT(GLenum texunit, GLenum coord, GLenum pname, GLint param);
        private static TglMultiTexGeniEXT glMultiTexGeniEXT = null;

        // GLAPI void APIENTRY glMultiTexGenivEXT (GLenum texunit, GLenum coord, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexGenivEXT(GLenum texunit, GLenum coord, GLenum pname, GLint* parameters);
        private static TglMultiTexGenivEXT glMultiTexGenivEXT = null;

        // GLAPI void APIENTRY glGetMultiTexEnvfvEXT (GLenum texunit, GLenum target, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultiTexEnvfvEXT(GLenum texunit, GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetMultiTexEnvfvEXT glGetMultiTexEnvfvEXT = null;

        // GLAPI void APIENTRY glGetMultiTexEnvivEXT (GLenum texunit, GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultiTexEnvivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* parameters);
        private static TglGetMultiTexEnvivEXT glGetMultiTexEnvivEXT = null;

        // GLAPI void APIENTRY glGetMultiTexGendvEXT (GLenum texunit, GLenum coord, GLenum pname, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultiTexGendvEXT(GLenum texunit, GLenum coord, GLenum pname, GLdouble* parameters);
        private static TglGetMultiTexGendvEXT glGetMultiTexGendvEXT = null;

        // GLAPI void APIENTRY glGetMultiTexGenfvEXT (GLenum texunit, GLenum coord, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultiTexGenfvEXT(GLenum texunit, GLenum coord, GLenum pname, GLfloat* parameters);
        private static TglGetMultiTexGenfvEXT glGetMultiTexGenfvEXT = null;

        // GLAPI void APIENTRY glGetMultiTexGenivEXT (GLenum texunit, GLenum coord, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultiTexGenivEXT(GLenum texunit, GLenum coord, GLenum pname, GLint* parameters);
        private static TglGetMultiTexGenivEXT glGetMultiTexGenivEXT = null;

        // GLAPI void APIENTRY glGetFloatIndexedvEXT (GLenum target, GLuint index, GLfloat *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFloatIndexedvEXT(GLenum target, GLuint index, GLfloat* data);
        private static TglGetFloatIndexedvEXT glGetFloatIndexedvEXT = null;

        // GLAPI void APIENTRY glGetDoubleIndexedvEXT (GLenum target, GLuint index, GLdouble *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetDoubleIndexedvEXT(GLenum target, GLuint index, GLdouble* data);
        private static TglGetDoubleIndexedvEXT glGetDoubleIndexedvEXT = null;

        // GLAPI void APIENTRY glGetPointerIndexedvEXT (GLenum target, GLuint index, GLvoid* *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPointerIndexedvEXT(GLenum target, GLuint index, void** data);
        private static TglGetPointerIndexedvEXT glGetPointerIndexedvEXT = null;

        // GLAPI void APIENTRY glCompressedTextureImage3DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, const GLvoid *bits);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTextureImage3DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* bits);
        private static TglCompressedTextureImage3DEXT glCompressedTextureImage3DEXT = null;

        // GLAPI void APIENTRY glCompressedTextureImage2DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, const GLvoid *bits);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTextureImage2DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* bits);
        private static TglCompressedTextureImage2DEXT glCompressedTextureImage2DEXT = null;

        // GLAPI void APIENTRY glCompressedTextureImage1DEXT (GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, const GLvoid *bits);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTextureImage1DEXT(GLuint texture, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* bits);
        private static TglCompressedTextureImage1DEXT glCompressedTextureImage1DEXT = null;

        // GLAPI void APIENTRY glCompressedTextureSubImage3DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const GLvoid *bits);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTextureSubImage3DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* bits);
        private static TglCompressedTextureSubImage3DEXT glCompressedTextureSubImage3DEXT = null;

        // GLAPI void APIENTRY glCompressedTextureSubImage2DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const GLvoid *bits);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTextureSubImage2DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* bits);
        private static TglCompressedTextureSubImage2DEXT glCompressedTextureSubImage2DEXT = null;

        // GLAPI void APIENTRY glCompressedTextureSubImage1DEXT (GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, const GLvoid *bits);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTextureSubImage1DEXT(GLuint texture, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* bits);
        private static TglCompressedTextureSubImage1DEXT glCompressedTextureSubImage1DEXT = null;

        // GLAPI void APIENTRY glGetCompressedTextureImageEXT (GLuint texture, GLenum target, GLint lod, GLvoid *img);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetCompressedTextureImageEXT(GLuint texture, GLenum target, GLint lod, void* img);
        private static TglGetCompressedTextureImageEXT glGetCompressedTextureImageEXT = null;

        // GLAPI void APIENTRY glCompressedMultiTexImage3DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, const GLvoid *bits);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedMultiTexImage3DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* bits);
        private static TglCompressedMultiTexImage3DEXT glCompressedMultiTexImage3DEXT = null;

        // GLAPI void APIENTRY glCompressedMultiTexImage2DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, const GLvoid *bits);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedMultiTexImage2DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* bits);
        private static TglCompressedMultiTexImage2DEXT glCompressedMultiTexImage2DEXT = null;

        // GLAPI void APIENTRY glCompressedMultiTexImage1DEXT (GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, const GLvoid *bits);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedMultiTexImage1DEXT(GLenum texunit, GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* bits);
        private static TglCompressedMultiTexImage1DEXT glCompressedMultiTexImage1DEXT = null;

        // GLAPI void APIENTRY glCompressedMultiTexSubImage3DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const GLvoid *bits);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedMultiTexSubImage3DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* bits);
        private static TglCompressedMultiTexSubImage3DEXT glCompressedMultiTexSubImage3DEXT = null;

        // GLAPI void APIENTRY glCompressedMultiTexSubImage2DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const GLvoid *bits);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedMultiTexSubImage2DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* bits);
        private static TglCompressedMultiTexSubImage2DEXT glCompressedMultiTexSubImage2DEXT = null;

        // GLAPI void APIENTRY glCompressedMultiTexSubImage1DEXT (GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, const GLvoid *bits);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedMultiTexSubImage1DEXT(GLenum texunit, GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* bits);
        private static TglCompressedMultiTexSubImage1DEXT glCompressedMultiTexSubImage1DEXT = null;

        // GLAPI void APIENTRY glGetCompressedMultiTexImageEXT (GLenum texunit, GLenum target, GLint lod, GLvoid *img);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetCompressedMultiTexImageEXT(GLenum texunit, GLenum target, GLint lod, void* img);
        private static TglGetCompressedMultiTexImageEXT glGetCompressedMultiTexImageEXT = null;

        // GLAPI void APIENTRY glNamedProgramStringEXT (GLuint program, GLenum target, GLenum format, GLsizei len, const GLvoid *string);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedProgramStringEXT(GLuint program, GLenum target, GLenum format, GLsizei len, void* str);
        private static TglNamedProgramStringEXT glNamedProgramStringEXT = null;

        // GLAPI void APIENTRY glNamedProgramLocalParameter4dEXT (GLuint program, GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedProgramLocalParameter4dEXT(GLuint program, GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglNamedProgramLocalParameter4dEXT glNamedProgramLocalParameter4dEXT = null;

        // GLAPI void APIENTRY glNamedProgramLocalParameter4dvEXT (GLuint program, GLenum target, GLuint index, const GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedProgramLocalParameter4dvEXT(GLuint program, GLenum target, GLuint index, GLdouble* parameters);
        private static TglNamedProgramLocalParameter4dvEXT glNamedProgramLocalParameter4dvEXT = null;

        // GLAPI void APIENTRY glNamedProgramLocalParameter4fEXT (GLuint program, GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedProgramLocalParameter4fEXT(GLuint program, GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglNamedProgramLocalParameter4fEXT glNamedProgramLocalParameter4fEXT = null;

        // GLAPI void APIENTRY glNamedProgramLocalParameter4fvEXT (GLuint program, GLenum target, GLuint index, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedProgramLocalParameter4fvEXT(GLuint program, GLenum target, GLuint index, GLfloat* parameters);
        private static TglNamedProgramLocalParameter4fvEXT glNamedProgramLocalParameter4fvEXT = null;

        // GLAPI void APIENTRY glGetNamedProgramLocalParameterdvEXT (GLuint program, GLenum target, GLuint index, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedProgramLocalParameterdvEXT(GLuint program, GLenum target, GLuint index, GLdouble* parameters);
        private static TglGetNamedProgramLocalParameterdvEXT glGetNamedProgramLocalParameterdvEXT = null;

        // GLAPI void APIENTRY glGetNamedProgramLocalParameterfvEXT (GLuint program, GLenum target, GLuint index, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedProgramLocalParameterfvEXT(GLuint program, GLenum target, GLuint index, GLfloat* parameters);
        private static TglGetNamedProgramLocalParameterfvEXT glGetNamedProgramLocalParameterfvEXT = null;

        // GLAPI void APIENTRY glGetNamedProgramivEXT (GLuint program, GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedProgramivEXT(GLuint program, GLenum target, GLenum pname, GLint* parameters);
        private static TglGetNamedProgramivEXT glGetNamedProgramivEXT = null;

        // GLAPI void APIENTRY glGetNamedProgramStringEXT (GLuint program, GLenum target, GLenum pname, GLvoid *string);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedProgramStringEXT(GLuint program, GLenum target, GLenum pname, void* str);
        private static TglGetNamedProgramStringEXT glGetNamedProgramStringEXT = null;

        // GLAPI void APIENTRY glNamedProgramLocalParameters4fvEXT (GLuint program, GLenum target, GLuint index, GLsizei count, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedProgramLocalParameters4fvEXT(GLuint program, GLenum target, GLuint index, GLsizei count, GLfloat* parameters);
        private static TglNamedProgramLocalParameters4fvEXT glNamedProgramLocalParameters4fvEXT = null;

        // GLAPI void APIENTRY glNamedProgramLocalParameterI4iEXT (GLuint program, GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedProgramLocalParameterI4iEXT(GLuint program, GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);
        private static TglNamedProgramLocalParameterI4iEXT glNamedProgramLocalParameterI4iEXT = null;

        // GLAPI void APIENTRY glNamedProgramLocalParameterI4ivEXT (GLuint program, GLenum target, GLuint index, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedProgramLocalParameterI4ivEXT(GLuint program, GLenum target, GLuint index, GLint* parameters);
        private static TglNamedProgramLocalParameterI4ivEXT glNamedProgramLocalParameterI4ivEXT = null;

        // GLAPI void APIENTRY glNamedProgramLocalParametersI4ivEXT (GLuint program, GLenum target, GLuint index, GLsizei count, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedProgramLocalParametersI4ivEXT(GLuint program, GLenum target, GLuint index, GLsizei count, GLint* parameters);
        private static TglNamedProgramLocalParametersI4ivEXT glNamedProgramLocalParametersI4ivEXT = null;

        // GLAPI void APIENTRY glNamedProgramLocalParameterI4uiEXT (GLuint program, GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedProgramLocalParameterI4uiEXT(GLuint program, GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        private static TglNamedProgramLocalParameterI4uiEXT glNamedProgramLocalParameterI4uiEXT = null;

        // GLAPI void APIENTRY glNamedProgramLocalParameterI4uivEXT (GLuint program, GLenum target, GLuint index, const GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedProgramLocalParameterI4uivEXT(GLuint program, GLenum target, GLuint index, GLuint* parameters);
        private static TglNamedProgramLocalParameterI4uivEXT glNamedProgramLocalParameterI4uivEXT = null;

        // GLAPI void APIENTRY glNamedProgramLocalParametersI4uivEXT (GLuint program, GLenum target, GLuint index, GLsizei count, const GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedProgramLocalParametersI4uivEXT(GLuint program, GLenum target, GLuint index, GLsizei count, GLuint* parameters);
        private static TglNamedProgramLocalParametersI4uivEXT glNamedProgramLocalParametersI4uivEXT = null;

        // GLAPI void APIENTRY glGetNamedProgramLocalParameterIivEXT (GLuint program, GLenum target, GLuint index, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedProgramLocalParameterIivEXT(GLuint program, GLenum target, GLuint index, GLint* parameters);
        private static TglGetNamedProgramLocalParameterIivEXT glGetNamedProgramLocalParameterIivEXT = null;

        // GLAPI void APIENTRY glGetNamedProgramLocalParameterIuivEXT (GLuint program, GLenum target, GLuint index, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedProgramLocalParameterIuivEXT(GLuint program, GLenum target, GLuint index, GLuint* parameters);
        private static TglGetNamedProgramLocalParameterIuivEXT glGetNamedProgramLocalParameterIuivEXT = null;

        // GLAPI void APIENTRY glTextureParameterIivEXT (GLuint texture, GLenum target, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureParameterIivEXT(GLuint texture, GLenum target, GLenum pname, GLint* parameters);
        private static TglTextureParameterIivEXT glTextureParameterIivEXT = null;

        // GLAPI void APIENTRY glTextureParameterIuivEXT (GLuint texture, GLenum target, GLenum pname, const GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureParameterIuivEXT(GLuint texture, GLenum target, GLenum pname, GLuint* parameters);
        private static TglTextureParameterIuivEXT glTextureParameterIuivEXT = null;

        // GLAPI void APIENTRY glGetTextureParameterIivEXT (GLuint texture, GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureParameterIivEXT(GLuint texture, GLenum target, GLenum pname, GLint* parameters);
        private static TglGetTextureParameterIivEXT glGetTextureParameterIivEXT = null;

        // GLAPI void APIENTRY glGetTextureParameterIuivEXT (GLuint texture, GLenum target, GLenum pname, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureParameterIuivEXT(GLuint texture, GLenum target, GLenum pname, GLuint* parameters);
        private static TglGetTextureParameterIuivEXT glGetTextureParameterIuivEXT = null;

        // GLAPI void APIENTRY glMultiTexParameterIivEXT (GLenum texunit, GLenum target, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexParameterIivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* parameters);
        private static TglMultiTexParameterIivEXT glMultiTexParameterIivEXT = null;

        // GLAPI void APIENTRY glMultiTexParameterIuivEXT (GLenum texunit, GLenum target, GLenum pname, const GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexParameterIuivEXT(GLenum texunit, GLenum target, GLenum pname, GLuint* parameters);
        private static TglMultiTexParameterIuivEXT glMultiTexParameterIuivEXT = null;

        // GLAPI void APIENTRY glGetMultiTexParameterIivEXT (GLenum texunit, GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultiTexParameterIivEXT(GLenum texunit, GLenum target, GLenum pname, GLint* parameters);
        private static TglGetMultiTexParameterIivEXT glGetMultiTexParameterIivEXT = null;

        // GLAPI void APIENTRY glGetMultiTexParameterIuivEXT (GLenum texunit, GLenum target, GLenum pname, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultiTexParameterIuivEXT(GLenum texunit, GLenum target, GLenum pname, GLuint* parameters);
        private static TglGetMultiTexParameterIuivEXT glGetMultiTexParameterIuivEXT = null;

        // GLAPI void APIENTRY glProgramUniform1fEXT (GLuint program, GLint location, GLfloat v0);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform1fEXT(GLuint program, GLint location, GLfloat v0);
        private static TglProgramUniform1fEXT glProgramUniform1fEXT = null;

        // GLAPI void APIENTRY glProgramUniform2fEXT (GLuint program, GLint location, GLfloat v0, GLfloat v1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform2fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1);
        private static TglProgramUniform2fEXT glProgramUniform2fEXT = null;

        // GLAPI void APIENTRY glProgramUniform3fEXT (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform3fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        private static TglProgramUniform3fEXT glProgramUniform3fEXT = null;

        // GLAPI void APIENTRY glProgramUniform4fEXT (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform4fEXT(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        private static TglProgramUniform4fEXT glProgramUniform4fEXT = null;

        // GLAPI void APIENTRY glProgramUniform1iEXT (GLuint program, GLint location, GLint v0);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform1iEXT(GLuint program, GLint location, GLint v0);
        private static TglProgramUniform1iEXT glProgramUniform1iEXT = null;

        // GLAPI void APIENTRY glProgramUniform2iEXT (GLuint program, GLint location, GLint v0, GLint v1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform2iEXT(GLuint program, GLint location, GLint v0, GLint v1);
        private static TglProgramUniform2iEXT glProgramUniform2iEXT = null;

        // GLAPI void APIENTRY glProgramUniform3iEXT (GLuint program, GLint location, GLint v0, GLint v1, GLint v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform3iEXT(GLuint program, GLint location, GLint v0, GLint v1, GLint v2);
        private static TglProgramUniform3iEXT glProgramUniform3iEXT = null;

        // GLAPI void APIENTRY glProgramUniform4iEXT (GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform4iEXT(GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        private static TglProgramUniform4iEXT glProgramUniform4iEXT = null;

        // GLAPI void APIENTRY glProgramUniform1fvEXT (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform1fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);
        private static TglProgramUniform1fvEXT glProgramUniform1fvEXT = null;

        // GLAPI void APIENTRY glProgramUniform2fvEXT (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform2fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);
        private static TglProgramUniform2fvEXT glProgramUniform2fvEXT = null;

        // GLAPI void APIENTRY glProgramUniform3fvEXT (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform3fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);
        private static TglProgramUniform3fvEXT glProgramUniform3fvEXT = null;

        // GLAPI void APIENTRY glProgramUniform4fvEXT (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform4fvEXT(GLuint program, GLint location, GLsizei count, GLfloat* value);
        private static TglProgramUniform4fvEXT glProgramUniform4fvEXT = null;

        // GLAPI void APIENTRY glProgramUniform1ivEXT (GLuint program, GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform1ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);
        private static TglProgramUniform1ivEXT glProgramUniform1ivEXT = null;

        // GLAPI void APIENTRY glProgramUniform2ivEXT (GLuint program, GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform2ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);
        private static TglProgramUniform2ivEXT glProgramUniform2ivEXT = null;

        // GLAPI void APIENTRY glProgramUniform3ivEXT (GLuint program, GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform3ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);
        private static TglProgramUniform3ivEXT glProgramUniform3ivEXT = null;

        // GLAPI void APIENTRY glProgramUniform4ivEXT (GLuint program, GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform4ivEXT(GLuint program, GLint location, GLsizei count, GLint* value);
        private static TglProgramUniform4ivEXT glProgramUniform4ivEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix2fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix2fvEXT glProgramUniformMatrix2fvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix3fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix3fvEXT glProgramUniformMatrix3fvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix4fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix4fvEXT glProgramUniformMatrix4fvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix2x3fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix2x3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix2x3fvEXT glProgramUniformMatrix2x3fvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix3x2fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix3x2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix3x2fvEXT glProgramUniformMatrix3x2fvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix2x4fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix2x4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix2x4fvEXT glProgramUniformMatrix2x4fvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix4x2fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix4x2fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix4x2fvEXT glProgramUniformMatrix4x2fvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix3x4fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix3x4fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix3x4fvEXT glProgramUniformMatrix3x4fvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix4x3fvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix4x3fvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix4x3fvEXT glProgramUniformMatrix4x3fvEXT = null;

        // GLAPI void APIENTRY glProgramUniform1uiEXT (GLuint program, GLint location, GLuint v0);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform1uiEXT(GLuint program, GLint location, GLuint v0);
        private static TglProgramUniform1uiEXT glProgramUniform1uiEXT = null;

        // GLAPI void APIENTRY glProgramUniform2uiEXT (GLuint program, GLint location, GLuint v0, GLuint v1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform2uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1);
        private static TglProgramUniform2uiEXT glProgramUniform2uiEXT = null;

        // GLAPI void APIENTRY glProgramUniform3uiEXT (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform3uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2);
        private static TglProgramUniform3uiEXT glProgramUniform3uiEXT = null;

        // GLAPI void APIENTRY glProgramUniform4uiEXT (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform4uiEXT(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
        private static TglProgramUniform4uiEXT glProgramUniform4uiEXT = null;

        // GLAPI void APIENTRY glProgramUniform1uivEXT (GLuint program, GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform1uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);
        private static TglProgramUniform1uivEXT glProgramUniform1uivEXT = null;

        // GLAPI void APIENTRY glProgramUniform2uivEXT (GLuint program, GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform2uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);
        private static TglProgramUniform2uivEXT glProgramUniform2uivEXT = null;

        // GLAPI void APIENTRY glProgramUniform3uivEXT (GLuint program, GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform3uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);
        private static TglProgramUniform3uivEXT glProgramUniform3uivEXT = null;

        // GLAPI void APIENTRY glProgramUniform4uivEXT (GLuint program, GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform4uivEXT(GLuint program, GLint location, GLsizei count, GLuint* value);
        private static TglProgramUniform4uivEXT glProgramUniform4uivEXT = null;

        // GLAPI void APIENTRY glNamedBufferDataEXT (GLuint buffer, GLsizeiptr size, const GLvoid *data, GLenum usage);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedBufferDataEXT(GLuint buffer, GLsizeiptr size, void* data, GLenum usage);
        private static TglNamedBufferDataEXT glNamedBufferDataEXT = null;

        // GLAPI void APIENTRY glNamedBufferSubDataEXT (GLuint buffer, GLintptr offset, GLsizeiptr size, const GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedBufferSubDataEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);
        private static TglNamedBufferSubDataEXT glNamedBufferSubDataEXT = null;

        // GLAPI GLvoid* APIENTRY glMapNamedBufferEXT (GLuint buffer, GLenum access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void* TglMapNamedBufferEXT(GLuint buffer, GLenum access);
        private static TglMapNamedBufferEXT glMapNamedBufferEXT = null;

        // GLAPI GLboolean APIENTRY glUnmapNamedBufferEXT (GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglUnmapNamedBufferEXT(GLuint buffer);
        private static TglUnmapNamedBufferEXT glUnmapNamedBufferEXT = null;

        // GLAPI GLvoid* APIENTRY glMapNamedBufferRangeEXT (GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void* TglMapNamedBufferRangeEXT(GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access);
        private static TglMapNamedBufferRangeEXT glMapNamedBufferRangeEXT = null;

        // GLAPI void APIENTRY glFlushMappedNamedBufferRangeEXT (GLuint buffer, GLintptr offset, GLsizeiptr length);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFlushMappedNamedBufferRangeEXT(GLuint buffer, GLintptr offset, GLsizeiptr length);
        private static TglFlushMappedNamedBufferRangeEXT glFlushMappedNamedBufferRangeEXT = null;

        // GLAPI void APIENTRY glNamedCopyBufferSubDataEXT (GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedCopyBufferSubDataEXT(GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);
        private static TglNamedCopyBufferSubDataEXT glNamedCopyBufferSubDataEXT = null;

        // GLAPI void APIENTRY glGetNamedBufferParameterivEXT (GLuint buffer, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedBufferParameterivEXT(GLuint buffer, GLenum pname, int* parameters);
        private static TglGetNamedBufferParameterivEXT glGetNamedBufferParameterivEXT = null;

        // GLAPI void APIENTRY glGetNamedBufferPointervEXT (GLuint buffer, GLenum pname, GLvoid* *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedBufferPointervEXT(GLuint buffer, GLenum pname, void** parameters);
        private static TglGetNamedBufferPointervEXT glGetNamedBufferPointervEXT = null;

        // GLAPI void APIENTRY glGetNamedBufferSubDataEXT (GLuint buffer, GLintptr offset, GLsizeiptr size, GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedBufferSubDataEXT(GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);
        private static TglGetNamedBufferSubDataEXT glGetNamedBufferSubDataEXT = null;

        // GLAPI void APIENTRY glTextureBufferEXT (GLuint texture, GLenum target, GLenum internalformat, GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureBufferEXT(GLuint texture, GLenum target, GLenum internalformat, GLuint buffer);
        private static TglTextureBufferEXT glTextureBufferEXT = null;

        // GLAPI void APIENTRY glMultiTexBufferEXT (GLenum texunit, GLenum target, GLenum internalformat, GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexBufferEXT(GLenum texunit, GLenum target, GLenum internalformat, GLuint buffer);
        private static TglMultiTexBufferEXT glMultiTexBufferEXT = null;

        // GLAPI void APIENTRY glNamedRenderbufferStorageEXT (GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedRenderbufferStorageEXT(GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglNamedRenderbufferStorageEXT glNamedRenderbufferStorageEXT = null;

        // GLAPI void APIENTRY glGetNamedRenderbufferParameterivEXT (GLuint renderbuffer, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedRenderbufferParameterivEXT(GLuint renderbuffer, GLenum pname, GLint* parameters);
        private static TglGetNamedRenderbufferParameterivEXT glGetNamedRenderbufferParameterivEXT = null;

        // GLAPI GLenum APIENTRY glCheckNamedFramebufferStatusEXT (GLuint framebuffer, GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLenum TglCheckNamedFramebufferStatusEXT(GLuint framebuffer, GLenum target);
        private static TglCheckNamedFramebufferStatusEXT glCheckNamedFramebufferStatusEXT = null;

        // GLAPI void APIENTRY glNamedFramebufferTexture1DEXT (GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferTexture1DEXT(GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        private static TglNamedFramebufferTexture1DEXT glNamedFramebufferTexture1DEXT = null;

        // GLAPI void APIENTRY glNamedFramebufferTexture2DEXT (GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferTexture2DEXT(GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        private static TglNamedFramebufferTexture2DEXT glNamedFramebufferTexture2DEXT = null;

        // GLAPI void APIENTRY glNamedFramebufferTexture3DEXT (GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferTexture3DEXT(GLuint framebuffer, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);
        private static TglNamedFramebufferTexture3DEXT glNamedFramebufferTexture3DEXT = null;

        // GLAPI void APIENTRY glNamedFramebufferRenderbufferEXT (GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferRenderbufferEXT(GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
        private static TglNamedFramebufferRenderbufferEXT glNamedFramebufferRenderbufferEXT = null;

        // GLAPI void APIENTRY glGetNamedFramebufferAttachmentParameterivEXT (GLuint framebuffer, GLenum attachment, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedFramebufferAttachmentParameterivEXT(GLuint framebuffer, GLenum attachment, GLenum pname, GLint* parameters);
        private static TglGetNamedFramebufferAttachmentParameterivEXT glGetNamedFramebufferAttachmentParameterivEXT = null;

        // GLAPI void APIENTRY glGenerateTextureMipmapEXT (GLuint texture, GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGenerateTextureMipmapEXT(GLuint texture, GLenum target);
        private static TglGenerateTextureMipmapEXT glGenerateTextureMipmapEXT = null;

        // GLAPI void APIENTRY glGenerateMultiTexMipmapEXT (GLenum texunit, GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGenerateMultiTexMipmapEXT(GLenum texunit, GLenum target);
        private static TglGenerateMultiTexMipmapEXT glGenerateMultiTexMipmapEXT = null;

        // GLAPI void APIENTRY glFramebufferDrawBufferEXT (GLuint framebuffer, GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferDrawBufferEXT(GLuint framebuffer, GLenum mode);
        private static TglFramebufferDrawBufferEXT glFramebufferDrawBufferEXT = null;

        // GLAPI void APIENTRY glFramebufferDrawBuffersEXT (GLuint framebuffer, GLsizei n, const GLenum *bufs);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFramebufferDrawBuffersEXT(GLuint framebuffer, GLsizei n, GLenum* bufs);
        private static TglFramebufferDrawBuffersEXT glFramebufferDrawBuffersEXT = null;

        // GLAPI void APIENTRY glFramebufferReadBufferEXT (GLuint framebuffer, GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferReadBufferEXT(GLuint framebuffer, GLenum mode);
        private static TglFramebufferReadBufferEXT glFramebufferReadBufferEXT = null;

        // GLAPI void APIENTRY glGetFramebufferParameterivEXT (GLuint framebuffer, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFramebufferParameterivEXT(GLuint framebuffer, GLenum pname, GLint* parameters);
        private static TglGetFramebufferParameterivEXT glGetFramebufferParameterivEXT = null;

        // GLAPI void APIENTRY glNamedRenderbufferStorageMultisampleEXT (GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedRenderbufferStorageMultisampleEXT(GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglNamedRenderbufferStorageMultisampleEXT glNamedRenderbufferStorageMultisampleEXT = null;

        // GLAPI void APIENTRY glNamedRenderbufferStorageMultisampleCoverageEXT (GLuint renderbuffer, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedRenderbufferStorageMultisampleCoverageEXT(GLuint renderbuffer, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglNamedRenderbufferStorageMultisampleCoverageEXT glNamedRenderbufferStorageMultisampleCoverageEXT = null;

        // GLAPI void APIENTRY glNamedFramebufferTextureEXT (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferTextureEXT(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level);
        private static TglNamedFramebufferTextureEXT glNamedFramebufferTextureEXT = null;

        // GLAPI void APIENTRY glNamedFramebufferTextureLayerEXT (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferTextureLayerEXT(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer);
        private static TglNamedFramebufferTextureLayerEXT glNamedFramebufferTextureLayerEXT = null;

        // GLAPI void APIENTRY glNamedFramebufferTextureFaceEXT (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLenum face);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferTextureFaceEXT(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLenum face);
        private static TglNamedFramebufferTextureFaceEXT glNamedFramebufferTextureFaceEXT = null;

        // GLAPI void APIENTRY glTextureRenderbufferEXT (GLuint texture, GLenum target, GLuint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureRenderbufferEXT(GLuint texture, GLenum target, GLuint renderbuffer);
        private static TglTextureRenderbufferEXT glTextureRenderbufferEXT = null;

        // GLAPI void APIENTRY glMultiTexRenderbufferEXT (GLenum texunit, GLenum target, GLuint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexRenderbufferEXT(GLenum texunit, GLenum target, GLuint renderbuffer);
        private static TglMultiTexRenderbufferEXT glMultiTexRenderbufferEXT = null;

        // GLAPI void APIENTRY glProgramUniform1dEXT (GLuint program, GLint location, GLdouble x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform1dEXT(GLuint program, GLint location, GLdouble x);
        private static TglProgramUniform1dEXT glProgramUniform1dEXT = null;

        // GLAPI void APIENTRY glProgramUniform2dEXT (GLuint program, GLint location, GLdouble x, GLdouble y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform2dEXT(GLuint program, GLint location, GLdouble x, GLdouble y);
        private static TglProgramUniform2dEXT glProgramUniform2dEXT = null;

        // GLAPI void APIENTRY glProgramUniform3dEXT (GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform3dEXT(GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z);
        private static TglProgramUniform3dEXT glProgramUniform3dEXT = null;

        // GLAPI void APIENTRY glProgramUniform4dEXT (GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform4dEXT(GLuint program, GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglProgramUniform4dEXT glProgramUniform4dEXT = null;

        // GLAPI void APIENTRY glProgramUniform1dvEXT (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform1dvEXT(GLuint program, GLint location, GLsizei count, GLdouble* value);
        private static TglProgramUniform1dvEXT glProgramUniform1dvEXT = null;

        // GLAPI void APIENTRY glProgramUniform2dvEXT (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform2dvEXT(GLuint program, GLint location, GLsizei count, GLdouble* value);
        private static TglProgramUniform2dvEXT glProgramUniform2dvEXT = null;

        // GLAPI void APIENTRY glProgramUniform3dvEXT (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform3dvEXT(GLuint program, GLint location, GLsizei count, GLdouble* value);
        private static TglProgramUniform3dvEXT glProgramUniform3dvEXT = null;

        // GLAPI void APIENTRY glProgramUniform4dvEXT (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform4dvEXT(GLuint program, GLint location, GLsizei count, GLdouble* value);
        private static TglProgramUniform4dvEXT glProgramUniform4dvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix2dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix2dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix2dvEXT glProgramUniformMatrix2dvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix3dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix3dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix3dvEXT glProgramUniformMatrix3dvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix4dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix4dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix4dvEXT glProgramUniformMatrix4dvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix2x3dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix2x3dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix2x3dvEXT glProgramUniformMatrix2x3dvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix2x4dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix2x4dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix2x4dvEXT glProgramUniformMatrix2x4dvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix3x2dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix3x2dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix3x2dvEXT glProgramUniformMatrix3x2dvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix3x4dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix3x4dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix3x4dvEXT glProgramUniformMatrix3x4dvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix4x2dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix4x2dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix4x2dvEXT glProgramUniformMatrix4x2dvEXT = null;

        // GLAPI void APIENTRY glProgramUniformMatrix4x3dvEXT (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix4x3dvEXT(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix4x3dvEXT glProgramUniformMatrix4x3dvEXT = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProvokingVertexEXT(GLenum mode);
        private static TglProvokingVertexEXT glProvokingVertexEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_snorm (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_separate_shader_objects
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glUseShaderProgramEXT (GLenum type, GLuint program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUseShaderProgramEXT(GLenum type, GLuint program);
        private static TglUseShaderProgramEXT glUseShaderProgramEXT = null;

        // GLAPI void APIENTRY glActiveProgramEXT (GLuint program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglActiveProgramEXT(GLuint program);
        private static TglActiveProgramEXT glActiveProgramEXT = null;

        // GLAPI GLuint APIENTRY glCreateShaderProgramEXT (GLenum type, const GLchar *string);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglCreateShaderProgramEXT(GLenum type, [MarshalAs(UnmanagedType.LPStr)] string str);
        private static TglCreateShaderProgramEXT glCreateShaderProgramEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_shader_image_load_store
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBindImageTextureEXT (GLuint index, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLint format);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindImageTextureEXT(GLuint index, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLint format);
        private static TglBindImageTextureEXT glBindImageTextureEXT = null;

        // GLAPI void APIENTRY glMemoryBarrierEXT (GLbitfield barriers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMemoryBarrierEXT(GLbitfield barriers);
        private static TglMemoryBarrierEXT glMemoryBarrierEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_vertex_attrib_64bit
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexAttribL1dEXT (GLuint index, GLdouble x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL1dEXT(GLuint index, GLdouble x);
        private static TglVertexAttribL1dEXT glVertexAttribL1dEXT = null;

        // GLAPI void APIENTRY glVertexAttribL2dEXT (GLuint index, GLdouble x, GLdouble y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL2dEXT(GLuint index, GLdouble x, GLdouble y);
        private static TglVertexAttribL2dEXT glVertexAttribL2dEXT = null;

        // GLAPI void APIENTRY glVertexAttribL3dEXT (GLuint index, GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL3dEXT(GLuint index, GLdouble x, GLdouble y, GLdouble z);
        private static TglVertexAttribL3dEXT glVertexAttribL3dEXT = null;

        // GLAPI void APIENTRY glVertexAttribL4dEXT (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL4dEXT(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglVertexAttribL4dEXT glVertexAttribL4dEXT = null;

        // GLAPI void APIENTRY glVertexAttribL1dvEXT (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL1dvEXT(GLuint index, GLdouble* v);
        private static TglVertexAttribL1dvEXT glVertexAttribL1dvEXT = null;

        // GLAPI void APIENTRY glVertexAttribL2dvEXT (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL2dvEXT(GLuint index, GLdouble* v);
        private static TglVertexAttribL2dvEXT glVertexAttribL2dvEXT = null;

        // GLAPI void APIENTRY glVertexAttribL3dvEXT (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL3dvEXT(GLuint index, GLdouble* v);
        private static TglVertexAttribL3dvEXT glVertexAttribL3dvEXT = null;

        // GLAPI void APIENTRY glVertexAttribL4dvEXT (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL4dvEXT(GLuint index, GLdouble* v);
        private static TglVertexAttribL4dvEXT glVertexAttribL4dvEXT = null;

        // GLAPI void APIENTRY glVertexAttribLPointerEXT (GLuint index, GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribLPointerEXT(GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer);
        private static TglVertexAttribLPointerEXT glVertexAttribLPointerEXT = null;

        // GLAPI void APIENTRY glGetVertexAttribLdvEXT (GLuint index, GLenum pname, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribLdvEXT(GLuint index, GLenum pname, GLdouble* parameters);
        private static TglGetVertexAttribLdvEXT glGetVertexAttribLdvEXT = null;

        // GLAPI void APIENTRY glVertexArrayVertexAttribLOffsetEXT (GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayVertexAttribLOffsetEXT(GLuint vaobj, GLuint buffer, GLuint index, GLint size, GLenum type, GLsizei stride, GLintptr offset);
        private static TglVertexArrayVertexAttribLOffsetEXT glVertexArrayVertexAttribLOffsetEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_sRGB_decode (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_x11_sync_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLsync APIENTRY glImportSyncEXT (GLenum external_sync_type, GLintptr external_sync, GLbitfield flags);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLsync TglImportSyncEXT(GLenum external_sync_type, GLintptr external_sync, GLbitfield flags);
        private static TglImportSyncEXT glImportSyncEXT = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLabelObjectEXT(GLenum type, GLuint obj, GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string label);
        private static TglLabelObjectEXT glLabelObjectEXT = null;

        // GLAPI void APIENTRY glGetObjectLabelEXT (GLenum type, GLuint object, GLsizei bufSize, GLsizei *length, GLchar *label);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetObjectLabelEXT(GLenum type, GLuint obj, GLsizei bufSize, GLsizei* length, GLchar* label);
        private static TglGetObjectLabelEXT glGetObjectLabelEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_debug_marker
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glInsertEventMarkerEXT (GLsizei length, const GLchar *marker);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglInsertEventMarkerEXT(GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string marker);
        private static TglInsertEventMarkerEXT glInsertEventMarkerEXT = null;

        // GLAPI void APIENTRY glPushGroupMarkerEXT (GLsizei length, const GLchar *marker);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPushGroupMarkerEXT(GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string marker);
        private static TglPushGroupMarkerEXT glPushGroupMarkerEXT = null;

        // GLAPI void APIENTRY glPopGroupMarkerEXT (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPopGroupMarkerEXT();
        private static TglPopGroupMarkerEXT glPopGroupMarkerEXT = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexStorage1DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);
        private static TglTexStorage1DEXT glTexStorage1DEXT = null;

        // GLAPI void APIENTRY glTexStorage2DEXT (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexStorage2DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglTexStorage2DEXT glTexStorage2DEXT = null;

        // GLAPI void APIENTRY glTexStorage3DEXT (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexStorage3DEXT(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
        private static TglTexStorage3DEXT glTexStorage3DEXT = null;

        // GLAPI void APIENTRY glTextureStorage1DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureStorage1DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);
        private static TglTextureStorage1DEXT glTextureStorage1DEXT = null;

        // GLAPI void APIENTRY glTextureStorage2DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureStorage2DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglTextureStorage2DEXT glTextureStorage2DEXT = null;

        // GLAPI void APIENTRY glTextureStorage3DEXT (GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureStorage3DEXT(GLuint texture, GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
        private static TglTextureStorage3DEXT glTextureStorage3DEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_transform_feedback2 
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBindTransformFeedbackEXT(GLenum target, GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindTransformFeedbackEXT(GLenum target, GLuint id);
        private static TglBindTransformFeedbackEXT glBindTransformFeedbackEXT = null;

        // GLAPI void APIENTRY glDeleteTransformFeedbacksEXT(GLsizei n, const GLuint *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteTransformFeedbacksEXT(GLsizei n, GLuint* ids);
        private static TglDeleteTransformFeedbacksEXT glDeleteTransformFeedbacksEXT = null;

        // GLAPI void APIENTRY glGenTransformFeedbacksEXT(GLsizei n, GLuint *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenTransformFeedbacksEXT(GLsizei n, GLuint* ids);
        private static TglGenTransformFeedbacksEXT glGenTransformFeedbacksEXT = null;

        // GLAPI GLboolean APIENTRY glIsTransformFeedbackEXT(GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsTransformFeedbackEXT(GLuint id);
        private static TglIsTransformFeedbackEXT glIsTransformFeedbackEXT = null;

        // GLAPI void APIENTRY glPauseTransformFeedbackEXT(void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPauseTransformFeedbackEXT();
        private static TglPauseTransformFeedbackEXT glPauseTransformFeedbackEXT = null;

        // GLAPI void APIENTRY glResumeTransformFeedbackEXT(void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglResumeTransformFeedbackEXT();
        private static TglResumeTransformFeedbackEXT glResumeTransformFeedbackEXT = null;

        // GLAPI void APIENTRY glDrawTransformFeedbackEXT(GLenum mode, GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawTransformFeedbackEXT(GLenum mode, GLuint id);
        private static TglDrawTransformFeedbackEXT glDrawTransformFeedbackEXT = null;

		///////////////////////////////////////////////////////////////////////
		// GL_EXT_polygon_offset_clamp
		///////////////////////////////////////////////////////////////////////
		// GLAPI void APIENTRY glPolygonOffsetClampEXT (GLfloat factor, GLfloat units, GLfloat clamp);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPolygonOffsetClampEXT(GLfloat factor, GLfloat units, GLfloat clamp);
		private static TglPolygonOffsetClampEXT glPolygonOffsetClampEXT = null;
		
		///////////////////////////////////////////////////////////////////////
		// GL_EXT_post_depth_coverage (no function entry points)
		///////////////////////////////////////////////////////////////////////
		
		///////////////////////////////////////////////////////////////////////
		// GL_EXT_raster_multisample
		///////////////////////////////////////////////////////////////////////
		// GLAPI void APIENTRY glRasterSamplesEXT (GLuint samples, GLboolean fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterSamplesEXT(GLuint samples, GLboolean fixedsamplelocations);
		private static TglRasterSamplesEXT glRasterSamplesEXT = null;
		
		///////////////////////////////////////////////////////////////////////
		// GL_EXT_shader_image_load_formatted (no function entry points)
		///////////////////////////////////////////////////////////////////////
		
        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_sparse_texture2 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
		// GL_EXT_texture_filter_minmax	(no function entry points)
        ///////////////////////////////////////////////////////////////////////
		
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_GREMEDY_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_GREMEDY_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_GREMEDY_string_marker
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glStringMarkerGREMEDY (GLsizei len, const GLvoid *string);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglStringMarkerGREMEDY(GLsizei len, void* str);
        private static TglStringMarkerGREMEDY glStringMarkerGREMEDY = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_GREMEDY_frame_terminator
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFrameTerminatorGREMEDY (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFrameTerminatorGREMEDY();
        private static TglFrameTerminatorGREMEDY glFrameTerminatorGREMEDY = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_HP_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_HP_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_HP_image_transform
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glImageTransformParameteriHP (GLenum target, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglImageTransformParameteriHP(GLenum target, GLenum pname, GLint param);
        private static TglImageTransformParameteriHP glImageTransformParameteriHP = null;

        // GLAPI void APIENTRY glImageTransformParameterfHP (GLenum target, GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglImageTransformParameterfHP(GLenum target, GLenum pname, GLfloat param);
        private static TglImageTransformParameterfHP glImageTransformParameterfHP = null;

        // GLAPI void APIENTRY glImageTransformParameterivHP (GLenum target, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglImageTransformParameterivHP(GLenum target, GLenum pname, GLint* parameters);
        private static TglImageTransformParameterivHP glImageTransformParameterivHP = null;

        // GLAPI void APIENTRY glImageTransformParameterfvHP (GLenum target, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglImageTransformParameterfvHP(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglImageTransformParameterfvHP glImageTransformParameterfvHP = null;

        // GLAPI void APIENTRY glGetImageTransformParameterivHP (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetImageTransformParameterivHP(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetImageTransformParameterivHP glGetImageTransformParameterivHP = null;

        // GLAPI void APIENTRY glGetImageTransformParameterfvHP (GLenum target, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetImageTransformParameterfvHP(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetImageTransformParameterfvHP glGetImageTransformParameterfvHP = null;

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
        // GL_IBM_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_IBM_xxx FUNCTIONS...
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiModeDrawArraysIBM(GLenum* mode, GLint* first, GLsizei* count, GLsizei primcount, GLint modestride);
        private static TglMultiModeDrawArraysIBM glMultiModeDrawArraysIBM = null;

        // GLAPI void APIENTRY glMultiModeDrawElementsIBM (const GLenum *mode, const GLsizei *count, GLenum type, const GLvoid* const *indices, GLsizei primcount, GLint modestride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiModeDrawElementsIBM(GLenum* mode, GLsizei* count, GLenum type, void** indices, GLsizei primcount, GLint modestride);
        private static TglMultiModeDrawElementsIBM glMultiModeDrawElementsIBM = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_vertex_array_lists
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glColorPointerListIBM (GLint size, GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorPointerListIBM(GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride);
        private static TglColorPointerListIBM glColorPointerListIBM = null;

        // GLAPI void APIENTRY glSecondaryColorPointerListIBM (GLint size, GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColorPointerListIBM(GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride);
        private static TglSecondaryColorPointerListIBM glSecondaryColorPointerListIBM = null;

        // GLAPI void APIENTRY glEdgeFlagPointerListIBM (GLint stride, const GLboolean* *pointer, GLint ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglEdgeFlagPointerListIBM(GLint stride, GLboolean** pointer, GLint ptrstride);
        private static TglEdgeFlagPointerListIBM glEdgeFlagPointerListIBM = null;

        // GLAPI void APIENTRY glFogCoordPointerListIBM (GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFogCoordPointerListIBM(GLenum type, GLint stride, void** pointer, GLint ptrstride);
        private static TglFogCoordPointerListIBM glFogCoordPointerListIBM = null;

        // GLAPI void APIENTRY glIndexPointerListIBM (GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglIndexPointerListIBM(GLenum type, GLint stride, void** pointer, GLint ptrstride);
        private static TglIndexPointerListIBM glIndexPointerListIBM = null;

        // GLAPI void APIENTRY glNormalPointerListIBM (GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormalPointerListIBM(GLenum type, GLint stride, void** pointer, GLint ptrstride);
        private static TglNormalPointerListIBM glNormalPointerListIBM = null;

        // GLAPI void APIENTRY glTexCoordPointerListIBM (GLint size, GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoordPointerListIBM(GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride);
        private static TglTexCoordPointerListIBM glTexCoordPointerListIBM = null;

        // GLAPI void APIENTRY glVertexPointerListIBM (GLint size, GLenum type, GLint stride, const GLvoid* *pointer, GLint ptrstride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexPointerListIBM(GLint size, GLenum type, GLint stride, void** pointer, GLint ptrstride);
        private static TglVertexPointerListIBM glVertexPointerListIBM = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_texture_mirrored_repeat (no function entry points)
        ///////////////////////////////////////////////////////////////////////

		///////////////////////////////////////////////////////////////////////
		// GL_IBM_static_data
		///////////////////////////////////////////////////////////////////////
		// GLAPI void APIENTRY glFlushStaticDataIBM (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFlushStaticDataIBM(GLenum target);
		private static TglFlushStaticDataIBM glFlushStaticDataIBM = null;
		
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_INGR_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_INGR_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_INGR_blend_func_separate
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendFuncSeparateINGR (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendFuncSeparateINGR(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
        private static TglBlendFuncSeparateINGR glBlendFuncSeparateINGR = null;

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
        // GL_INTEL_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_INTEL_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_parallel_arrays
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexPointervINTEL (GLint size, GLenum type, const GLvoid* *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexPointervINTEL(GLint size, GLenum type, void** pointer);
        private static TglVertexPointervINTEL glVertexPointervINTEL = null;

        // GLAPI void APIENTRY glNormalPointervINTEL (GLenum type, const GLvoid* *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormalPointervINTEL(GLenum type, void** pointer);
        private static TglNormalPointervINTEL glNormalPointervINTEL = null;

        // GLAPI void APIENTRY glColorPointervINTEL (GLint size, GLenum type, const GLvoid* *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorPointervINTEL(GLint size, GLenum type, void** pointer);
        private static TglColorPointervINTEL glColorPointervINTEL = null;

        // GLAPI void APIENTRY glTexCoordPointervINTEL (GLint size, GLenum type, const GLvoid* *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoordPointervINTEL(GLint size, GLenum type, void** pointer);
        private static TglTexCoordPointervINTEL glTexCoordPointervINTEL = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_fragment_shader_ordering (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_map_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glSyncTextureINTEL (GLuint texture);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSyncTextureINTEL(GLuint texture);
        private static TglSyncTextureINTEL glSyncTextureINTEL = null;

        // GLAPI void APIENTRY glUnmapTexture2DINTEL (GLuint texture, GLint level);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUnmapTexture2DINTEL(GLuint texture, GLint level);
        private static TglUnmapTexture2DINTEL glUnmapTexture2DINTEL = null;

        // GLAPI void *APIENTRY glMapTexture2DINTEL (GLuint texture, GLint level, GLbitfield access, GLint *stride, GLenum *layout);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void* TglMapTexture2DINTEL(GLuint texture, GLint level, GLbitfield access, GLint* stride, GLenum* layout);
        private static TglMapTexture2DINTEL glMapTexture2DINTEL = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_performance_query
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginPerfQueryINTEL (GLuint queryHandle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginPerfQueryINTEL(GLuint queryHandle);
        private static TglBeginPerfQueryINTEL glBeginPerfQueryINTEL = null;

        // GLAPI void APIENTRY glCreatePerfQueryINTEL (GLuint queryId, GLuint *queryHandle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCreatePerfQueryINTEL(GLuint queryId, GLuint* queryHandle);
        private static TglCreatePerfQueryINTEL glCreatePerfQueryINTEL = null;

        // GLAPI void APIENTRY glDeletePerfQueryINTEL (GLuint queryHandle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDeletePerfQueryINTEL(GLuint queryHandle);
        private static TglDeletePerfQueryINTEL glDeletePerfQueryINTEL = null;

        // GLAPI void APIENTRY glEndPerfQueryINTEL (GLuint queryHandle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndPerfQueryINTEL(GLuint queryHandle);
        private static TglEndPerfQueryINTEL glEndPerfQueryINTEL = null;

        // GLAPI void APIENTRY glGetFirstPerfQueryIdINTEL (GLuint *queryId);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFirstPerfQueryIdINTEL(GLuint* queryId);
        private static TglGetFirstPerfQueryIdINTEL glGetFirstPerfQueryIdINTEL = null;

        // GLAPI void APIENTRY glGetNextPerfQueryIdINTEL (GLuint queryId, GLuint *nextQueryId);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNextPerfQueryIdINTEL(GLuint queryId, GLuint* nextQueryId);
        private static TglGetNextPerfQueryIdINTEL glGetNextPerfQueryIdINTEL = null;

        // GLAPI void APIENTRY glGetPerfCounterInfoINTEL (GLuint queryId, GLuint counterId, GLuint counterNameLength, GLchar *counterName, GLuint counterDescLength, GLchar *counterDesc, GLuint *counterOffset, GLuint *counterDataSize, GLuint *counterTypeEnum, GLuint *counterDataTypeEnum, GLuint64 *rawCounterMaxValue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPerfCounterInfoINTEL(GLuint queryId, GLuint counterId, GLuint counterNameLength, GLchar* counterName, GLuint counterDescLength, GLchar* counterDesc, GLuint* counterOffset, GLuint* counterDataSize, GLuint* counterTypeEnum, GLuint* counterDataTypeEnum, GLuint64* rawCounterMaxValue);
        private static TglGetPerfCounterInfoINTEL glGetPerfCounterInfoINTEL = null;

        // GLAPI void APIENTRY glGetPerfQueryDataINTEL (GLuint queryHandle, GLuint flags, GLsizei dataSize, GLvoid *data, GLuint *bytesWritten);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPerfQueryDataINTEL(GLuint queryHandle, GLuint flags, GLsizei dataSize, void* data, GLuint* bytesWritten);
        private static TglGetPerfQueryDataINTEL glGetPerfQueryDataINTEL = null;

        // GLAPI void APIENTRY glGetPerfQueryIdByNameINTEL (GLchar *queryName, GLuint *queryId);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPerfQueryIdByNameINTEL(GLchar* queryName, GLuint* queryId);
        private static TglGetPerfQueryIdByNameINTEL glGetPerfQueryIdByNameINTEL = null;

        // GLAPI void APIENTRY glGetPerfQueryInfoINTEL (GLuint queryId, GLuint queryNameLength, GLchar *queryName, GLuint *dataSize, GLuint *noCounters, GLuint *noInstances, GLuint *capsMask);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPerfQueryInfoINTEL(GLuint queryId, GLuint queryNameLength, GLchar* queryName, GLuint* dataSize, GLuint* noCounters, GLuint* noInstances, GLuint* capsMask);
        private static TglGetPerfQueryInfoINTEL glGetPerfQueryInfoINTEL = null;

		///////////////////////////////////////////////////////////////////////
		// GL_INTEL_framebuffer_CMAA
		///////////////////////////////////////////////////////////////////////
		// GLAPI void APIENTRY glApplyFramebufferAttachmentCMAAINTEL (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglApplyFramebufferAttachmentCMAAINTEL();
		private static TglApplyFramebufferAttachmentCMAAINTEL glApplyFramebufferAttachmentCMAAINTEL = null;
		
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_KHR_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_context_flush_control (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_debug
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */
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

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_blend_equation_advanced
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendBarrierKHR (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendBarrierKHR();
        private static TglBlendBarrierKHR glBlendBarrierKHR = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_blend_equation_advanced_coherent (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_KTX_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_KTX_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_KTX_buffer_region
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLuint APIENTRY glBufferRegionEnabled (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglBufferRegionEnabled();
        private static TglBufferRegionEnabled glBufferRegionEnabled = null;

        // GLAPI void APIENTRY glDeleteBufferRegion (GLenum region);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDeleteBufferRegion(GLenum region);
        private static TglDeleteBufferRegion glDeleteBufferRegion = null;

        // GLAPI void APIENTRY glDrawBufferRegion (GLuint region, GLint x, GLint y, GLsizei width, GLsizei height, GLint xDest, GLint yDest);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawBufferRegion(GLuint region, GLint x, GLint y, GLsizei width, GLsizei height, GLint xDest, GLint yDest);
        private static TglDrawBufferRegion glDrawBufferRegion = null;

        // GLAPI GLuint APIENTRY glNewBufferRegion (GLenum region);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglNewBufferRegion(GLenum region);
        private static TglNewBufferRegion glNewBufferRegion = null;

        // GLAPI void APIENTRY glReadBufferRegion (GLuint region, GLint x, GLint y, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReadBufferRegion(GLuint region, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglReadBufferRegion glReadBufferRegion = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_MESA_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_resize_buffers
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glResizeBuffersMESA (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglResizeBuffersMESA();
        private static TglResizeBuffersMESA glResizeBuffersMESA = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_window_pos
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glWindowPos2dMESA (GLdouble x, GLdouble y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos2dMESA(GLdouble x, GLdouble y);
        private static TglWindowPos2dMESA glWindowPos2dMESA = null;

        // GLAPI void APIENTRY glWindowPos2dvMESA (const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos2dvMESA(GLdouble* v);
        private static TglWindowPos2dvMESA glWindowPos2dvMESA = null;

        // GLAPI void APIENTRY glWindowPos2fMESA (GLfloat x, GLfloat y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos2fMESA(GLfloat x, GLfloat y);
        private static TglWindowPos2fMESA glWindowPos2fMESA = null;

        // GLAPI void APIENTRY glWindowPos2fvMESA (const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos2fvMESA(GLfloat* v);
        private static TglWindowPos2fvMESA glWindowPos2fvMESA = null;

        // GLAPI void APIENTRY glWindowPos2iMESA (GLint x, GLint y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos2iMESA(GLint x, GLint y);
        private static TglWindowPos2iMESA glWindowPos2iMESA = null;

        // GLAPI void APIENTRY glWindowPos2ivMESA (const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos2ivMESA(GLint* v);
        private static TglWindowPos2ivMESA glWindowPos2ivMESA = null;

        // GLAPI void APIENTRY glWindowPos2sMESA (GLshort x, GLshort y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos2sMESA(GLshort x, GLshort y);
        private static TglWindowPos2sMESA glWindowPos2sMESA = null;

        // GLAPI void APIENTRY glWindowPos2svMESA (const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos2svMESA(GLshort* v);
        private static TglWindowPos2svMESA glWindowPos2svMESA = null;

        // GLAPI void APIENTRY glWindowPos3dMESA (GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos3dMESA(GLdouble x, GLdouble y, GLdouble z);
        private static TglWindowPos3dMESA glWindowPos3dMESA = null;

        // GLAPI void APIENTRY glWindowPos3dvMESA (const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos3dvMESA(GLdouble* v);
        private static TglWindowPos3dvMESA glWindowPos3dvMESA = null;

        // GLAPI void APIENTRY glWindowPos3fMESA (GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos3fMESA(GLfloat x, GLfloat y, GLfloat z);
        private static TglWindowPos3fMESA glWindowPos3fMESA = null;

        // GLAPI void APIENTRY glWindowPos3fvMESA (const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos3fvMESA(GLfloat* v);
        private static TglWindowPos3fvMESA glWindowPos3fvMESA = null;

        // GLAPI void APIENTRY glWindowPos3iMESA (GLint x, GLint y, GLint z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos3iMESA(GLint x, GLint y, GLint z);
        private static TglWindowPos3iMESA glWindowPos3iMESA = null;

        // GLAPI void APIENTRY glWindowPos3ivMESA (const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos3ivMESA(GLint* v);
        private static TglWindowPos3ivMESA glWindowPos3ivMESA = null;

        // GLAPI void APIENTRY glWindowPos3sMESA (GLshort x, GLshort y, GLshort z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos3sMESA(GLshort x, GLshort y, GLshort z);
        private static TglWindowPos3sMESA glWindowPos3sMESA = null;

        // GLAPI void APIENTRY glWindowPos3svMESA (const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos3svMESA(GLshort* v);
        private static TglWindowPos3svMESA glWindowPos3svMESA = null;

        // GLAPI void APIENTRY glWindowPos4dMESA (GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos4dMESA(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglWindowPos4dMESA glWindowPos4dMESA = null;

        // GLAPI void APIENTRY glWindowPos4dvMESA (const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos4dvMESA(GLdouble* v);
        private static TglWindowPos4dvMESA glWindowPos4dvMESA = null;

        // GLAPI void APIENTRY glWindowPos4fMESA (GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos4fMESA(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglWindowPos4fMESA glWindowPos4fMESA = null;

        // GLAPI void APIENTRY glWindowPos4fvMESA (const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos4fvMESA(GLfloat* v);
        private static TglWindowPos4fvMESA glWindowPos4fvMESA = null;

        // GLAPI void APIENTRY glWindowPos4iMESA (GLint x, GLint y, GLint z, GLint w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos4iMESA(GLint x, GLint y, GLint z, GLint w);
        private static TglWindowPos4iMESA glWindowPos4iMESA = null;

        // GLAPI void APIENTRY glWindowPos4ivMESA (const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos4ivMESA(GLint* v);
        private static TglWindowPos4ivMESA glWindowPos4ivMESA = null;

        // GLAPI void APIENTRY glWindowPos4sMESA (GLshort x, GLshort y, GLshort z, GLshort w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos4sMESA(GLshort x, GLshort y, GLshort z, GLshort w);
        private static TglWindowPos4sMESA glWindowPos4sMESA = null;

        // GLAPI void APIENTRY glWindowPos4svMESA (const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos4svMESA(GLshort* v);
        private static TglWindowPos4svMESA glWindowPos4svMESA = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_pack_invert (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_ycbcr_texture (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_MESAX_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_MESAX_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_MESAX_texture_stack (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_NV_xxx FUNCTIONS...
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFlushVertexArrayRangeNV();
        private static TglFlushVertexArrayRangeNV glFlushVertexArrayRangeNV = null;

        // GLAPI void APIENTRY glVertexArrayRangeNV (GLsizei length, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexArrayRangeNV(GLsizei length, void* pointer);
        private static TglVertexArrayRangeNV glVertexArrayRangeNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_register_combiners
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCombinerParameterfvNV (GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCombinerParameterfvNV(GLenum pname, GLfloat* parameters);
        private static TglCombinerParameterfvNV glCombinerParameterfvNV = null;

        // GLAPI void APIENTRY glCombinerParameterfNV (GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCombinerParameterfNV(GLenum pname, GLfloat param);
        private static TglCombinerParameterfNV glCombinerParameterfNV = null;

        // GLAPI void APIENTRY glCombinerParameterivNV (GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCombinerParameterivNV(GLenum pname, GLint* parameters);
        private static TglCombinerParameterivNV glCombinerParameterivNV = null;

        // GLAPI void APIENTRY glCombinerParameteriNV (GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCombinerParameteriNV(GLenum pname, GLint param);
        private static TglCombinerParameteriNV glCombinerParameteriNV = null;

        // GLAPI void APIENTRY glCombinerInputNV (GLenum stage, GLenum portion, GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCombinerInputNV(GLenum stage, GLenum portion, GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage);
        private static TglCombinerInputNV glCombinerInputNV = null;

        // GLAPI void APIENTRY glCombinerOutputNV (GLenum stage, GLenum portion, GLenum abOutput, GLenum cdOutput, GLenum sumOutput, GLenum scale, GLenum bias, GLboolean abDotProduct, GLboolean cdDotProduct, GLboolean muxSum);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCombinerOutputNV(GLenum stage, GLenum portion, GLenum abOutput, GLenum cdOutput, GLenum sumOutput, GLenum scale, GLenum bias, GLboolean abDotProduct, GLboolean cdDotProduct, GLboolean muxSum);
        private static TglCombinerOutputNV glCombinerOutputNV = null;

        // GLAPI void APIENTRY glFinalCombinerInputNV (GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFinalCombinerInputNV(GLenum variable, GLenum input, GLenum mapping, GLenum componentUsage);
        private static TglFinalCombinerInputNV glFinalCombinerInputNV = null;

        // GLAPI void APIENTRY glGetCombinerInputParameterfvNV (GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetCombinerInputParameterfvNV(GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLfloat* parameters);
        private static TglGetCombinerInputParameterfvNV glGetCombinerInputParameterfvNV = null;

        // GLAPI void APIENTRY glGetCombinerInputParameterivNV (GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetCombinerInputParameterivNV(GLenum stage, GLenum portion, GLenum variable, GLenum pname, GLint* parameters);
        private static TglGetCombinerInputParameterivNV glGetCombinerInputParameterivNV = null;

        // GLAPI void APIENTRY glGetCombinerOutputParameterfvNV (GLenum stage, GLenum portion, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetCombinerOutputParameterfvNV(GLenum stage, GLenum portion, GLenum pname, GLfloat* parameters);
        private static TglGetCombinerOutputParameterfvNV glGetCombinerOutputParameterfvNV = null;

        // GLAPI void APIENTRY glGetCombinerOutputParameterivNV (GLenum stage, GLenum portion, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetCombinerOutputParameterivNV(GLenum stage, GLenum portion, GLenum pname, GLint* parameters);
        private static TglGetCombinerOutputParameterivNV glGetCombinerOutputParameterivNV = null;

        // GLAPI void APIENTRY glGetFinalCombinerInputParameterfvNV (GLenum variable, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFinalCombinerInputParameterfvNV(GLenum variable, GLenum pname, GLfloat* parameters);
        private static TglGetFinalCombinerInputParameterfvNV glGetFinalCombinerInputParameterfvNV = null;

        // GLAPI void APIENTRY glGetFinalCombinerInputParameterivNV (GLenum variable, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFinalCombinerInputParameterivNV(GLenum variable, GLenum pname, GLint* parameters);
        private static TglGetFinalCombinerInputParameterivNV glGetFinalCombinerInputParameterivNV = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteFencesNV(GLsizei n, GLuint* fences);
        private static TglDeleteFencesNV glDeleteFencesNV = null;

        // GLAPI void APIENTRY glGenFencesNV (GLsizei n, GLuint *fences);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenFencesNV(GLsizei n, GLuint* fences);
        private static TglGenFencesNV glGenFencesNV = null;

        // GLAPI GLboolean APIENTRY glIsFenceNV (GLuint fence);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsFenceNV(GLuint fence);
        private static TglIsFenceNV glIsFenceNV = null;

        // GLAPI GLboolean APIENTRY glTestFenceNV (GLuint fence);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglTestFenceNV(GLuint fence);
        private static TglTestFenceNV glTestFenceNV = null;

        // GLAPI void APIENTRY glGetFenceivNV (GLuint fence, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFenceivNV(GLuint fence, GLenum pname, GLint* parameters);
        private static TglGetFenceivNV glGetFenceivNV = null;

        // GLAPI void APIENTRY glFinishFenceNV (GLuint fence);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFinishFenceNV(GLuint fence);
        private static TglFinishFenceNV glFinishFenceNV = null;

        // GLAPI void APIENTRY glSetFenceNV (GLuint fence, GLenum condition);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSetFenceNV(GLuint fence, GLenum condition);
        private static TglSetFenceNV glSetFenceNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_evaluators
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMapControlPointsNV (GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLint uorder, GLint vorder, GLboolean packed, const GLvoid *points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMapControlPointsNV(GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLint uorder, GLint vorder, GLboolean packed, void* points);
        private static TglMapControlPointsNV glMapControlPointsNV = null;

        // GLAPI void APIENTRY glMapParameterivNV (GLenum target, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMapParameterivNV(GLenum target, GLenum pname, GLint* parameters);
        private static TglMapParameterivNV glMapParameterivNV = null;

        // GLAPI void APIENTRY glMapParameterfvNV (GLenum target, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMapParameterfvNV(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglMapParameterfvNV glMapParameterfvNV = null;

        // GLAPI void APIENTRY glGetMapControlPointsNV (GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLboolean packed, GLvoid *points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMapControlPointsNV(GLenum target, GLuint index, GLenum type, GLsizei ustride, GLsizei vstride, GLboolean packed, void* points);
        private static TglGetMapControlPointsNV glGetMapControlPointsNV = null;

        // GLAPI void APIENTRY glGetMapParameterivNV (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMapParameterivNV(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetMapParameterivNV glGetMapParameterivNV = null;

        // GLAPI void APIENTRY glGetMapParameterfvNV (GLenum target, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMapParameterfvNV(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetMapParameterfvNV glGetMapParameterfvNV = null;

        // GLAPI void APIENTRY glGetMapAttribParameterivNV (GLenum target, GLuint index, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMapAttribParameterivNV(GLenum target, GLuint index, GLenum pname, GLint* parameters);
        private static TglGetMapAttribParameterivNV glGetMapAttribParameterivNV = null;

        // GLAPI void APIENTRY glGetMapAttribParameterfvNV (GLenum target, GLuint index, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMapAttribParameterfvNV(GLenum target, GLuint index, GLenum pname, GLfloat* parameters);
        private static TglGetMapAttribParameterfvNV glGetMapAttribParameterfvNV = null;

        // GLAPI void APIENTRY glEvalMapsNV (GLenum target, GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEvalMapsNV(GLenum target, GLenum mode);
        private static TglEvalMapsNV glEvalMapsNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_packed_depth_stencil (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_register_combiners2
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCombinerStageParameterfvNV (GLenum stage, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCombinerStageParameterfvNV(GLenum stage, GLenum pname, GLfloat* parameters);
        private static TglCombinerStageParameterfvNV glCombinerStageParameterfvNV = null;

        // GLAPI void APIENTRY glGetCombinerStageParameterfvNV (GLenum stage, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetCombinerStageParameterfvNV(GLenum stage, GLenum pname, GLfloat* parameters);
        private static TglGetCombinerStageParameterfvNV glGetCombinerStageParameterfvNV = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLboolean TglAreProgramsResidentNV(GLsizei n, GLuint* programs, GLboolean* residences);
        private static TglAreProgramsResidentNV glAreProgramsResidentNV = null;

        // GLAPI void APIENTRY glBindProgramNV (GLenum target, GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindProgramNV(GLenum target, GLuint id);
        private static TglBindProgramNV glBindProgramNV = null;

        // GLAPI void APIENTRY glDeleteProgramsNV (GLsizei n, const GLuint *programs);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteProgramsNV(GLsizei n, GLuint* programs);
        private static TglDeleteProgramsNV glDeleteProgramsNV = null;

        // GLAPI void APIENTRY glExecuteProgramNV (GLenum target, GLuint id, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglExecuteProgramNV(GLenum target, GLuint id, GLfloat* parameters);
        private static TglExecuteProgramNV glExecuteProgramNV = null;

        // GLAPI void APIENTRY glGenProgramsNV (GLsizei n, GLuint *programs);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenProgramsNV(GLsizei n, GLuint* programs);
        private static TglGenProgramsNV glGenProgramsNV = null;

        // GLAPI void APIENTRY glGetProgramParameterdvNV (GLenum target, GLuint index, GLenum pname, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramParameterdvNV(GLenum target, GLuint index, GLenum pname, GLdouble* parameters);
        private static TglGetProgramParameterdvNV glGetProgramParameterdvNV = null;

        // GLAPI void APIENTRY glGetProgramParameterfvNV (GLenum target, GLuint index, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramParameterfvNV(GLenum target, GLuint index, GLenum pname, GLfloat* parameters);
        private static TglGetProgramParameterfvNV glGetProgramParameterfvNV = null;

        // GLAPI void APIENTRY glGetProgramivNV (GLuint id, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramivNV(GLuint id, GLenum pname, GLint* parameters);
        private static TglGetProgramivNV glGetProgramivNV = null;

        // GLAPI void APIENTRY glGetProgramStringNV (GLuint id, GLenum pname, GLubyte *program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramStringNV(GLuint id, GLenum pname, GLubyte* program);
        private static TglGetProgramStringNV glGetProgramStringNV = null;

        // GLAPI void APIENTRY glGetTrackMatrixivNV (GLenum target, GLuint address, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTrackMatrixivNV(GLenum target, GLuint address, GLenum pname, GLint* parameters);
        private static TglGetTrackMatrixivNV glGetTrackMatrixivNV = null;

        // GLAPI void APIENTRY glGetVertexAttribdvNV (GLuint index, GLenum pname, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribdvNV(GLuint index, GLenum pname, GLdouble* parameters);
        private static TglGetVertexAttribdvNV glGetVertexAttribdvNV = null;

        // GLAPI void APIENTRY glGetVertexAttribfvNV (GLuint index, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribfvNV(GLuint index, GLenum pname, GLfloat* parameters);
        private static TglGetVertexAttribfvNV glGetVertexAttribfvNV = null;

        // GLAPI void APIENTRY glGetVertexAttribivNV (GLuint index, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribivNV(GLuint index, GLenum pname, GLint* parameters);
        private static TglGetVertexAttribivNV glGetVertexAttribivNV = null;

        // GLAPI void APIENTRY glGetVertexAttribPointervNV (GLuint index, GLenum pname, GLvoid* *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribPointervNV(GLuint index, GLenum pname, void** pointer);
        private static TglGetVertexAttribPointervNV glGetVertexAttribPointervNV = null;

        // GLAPI GLboolean APIENTRY glIsProgramNV (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsProgramNV(GLuint id);
        private static TglIsProgramNV glIsProgramNV = null;

        // GLAPI void APIENTRY glLoadProgramNV (GLenum target, GLuint id, GLsizei len, const GLubyte *program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLoadProgramNV(GLenum target, GLuint id, GLsizei len, GLubyte* program);
        private static TglLoadProgramNV glLoadProgramNV = null;

        // GLAPI void APIENTRY glProgramParameter4dNV (GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramParameter4dNV(GLenum target, GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglProgramParameter4dNV glProgramParameter4dNV = null;

        // GLAPI void APIENTRY glProgramParameter4dvNV (GLenum target, GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramParameter4dvNV(GLenum target, GLuint index, GLdouble* v);
        private static TglProgramParameter4dvNV glProgramParameter4dvNV = null;

        // GLAPI void APIENTRY glProgramParameter4fNV (GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramParameter4fNV(GLenum target, GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglProgramParameter4fNV glProgramParameter4fNV = null;

        // GLAPI void APIENTRY glProgramParameter4fvNV (GLenum target, GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramParameter4fvNV(GLenum target, GLuint index, GLfloat* v);
        private static TglProgramParameter4fvNV glProgramParameter4fvNV = null;

        // GLAPI void APIENTRY glProgramParameters4dvNV (GLenum target, GLuint index, GLsizei count, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramParameters4dvNV(GLenum target, GLuint index, GLsizei count, GLdouble* v);
        private static TglProgramParameters4dvNV glProgramParameters4dvNV = null;

        // GLAPI void APIENTRY glProgramParameters4fvNV (GLenum target, GLuint index, GLsizei count, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramParameters4fvNV(GLenum target, GLuint index, GLsizei count, GLfloat* v);
        private static TglProgramParameters4fvNV glProgramParameters4fvNV = null;

        // GLAPI void APIENTRY glRequestResidentProgramsNV (GLsizei n, const GLuint *programs);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRequestResidentProgramsNV(GLsizei n, GLuint* programs);
        private static TglRequestResidentProgramsNV glRequestResidentProgramsNV = null;

        // GLAPI void APIENTRY glTrackMatrixNV (GLenum target, GLuint address, GLenum matrix, GLenum transform);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTrackMatrixNV(GLenum target, GLuint address, GLenum matrix, GLenum transform);
        private static TglTrackMatrixNV glTrackMatrixNV = null;

        // GLAPI void APIENTRY glVertexAttribPointerNV (GLuint index, GLint fsize, GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribPointerNV(GLuint index, GLint fsize, GLenum type, GLsizei stride, void* pointer);
        private static TglVertexAttribPointerNV glVertexAttribPointerNV = null;

        // GLAPI void APIENTRY glVertexAttrib1dNV (GLuint index, GLdouble x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib1dNV(GLuint index, GLdouble x);
        private static TglVertexAttrib1dNV glVertexAttrib1dNV = null;

        // GLAPI void APIENTRY glVertexAttrib1dvNV (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib1dvNV(GLuint index, GLdouble* v);
        private static TglVertexAttrib1dvNV glVertexAttrib1dvNV = null;

        // GLAPI void APIENTRY glVertexAttrib1fNV (GLuint index, GLfloat x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib1fNV(GLuint index, GLfloat x);
        private static TglVertexAttrib1fNV glVertexAttrib1fNV = null;

        // GLAPI void APIENTRY glVertexAttrib1fvNV (GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib1fvNV(GLuint index, GLfloat* v);
        private static TglVertexAttrib1fvNV glVertexAttrib1fvNV = null;

        // GLAPI void APIENTRY glVertexAttrib1sNV (GLuint index, GLshort x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib1sNV(GLuint index, GLshort x);
        private static TglVertexAttrib1sNV glVertexAttrib1sNV = null;

        // GLAPI void APIENTRY glVertexAttrib1svNV (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib1svNV(GLuint index, GLshort* v);
        private static TglVertexAttrib1svNV glVertexAttrib1svNV = null;

        // GLAPI void APIENTRY glVertexAttrib2dNV (GLuint index, GLdouble x, GLdouble y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib2dNV(GLuint index, GLdouble x, GLdouble y);
        private static TglVertexAttrib2dNV glVertexAttrib2dNV = null;

        // GLAPI void APIENTRY glVertexAttrib2dvNV (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib2dvNV(GLuint index, GLdouble* v);
        private static TglVertexAttrib2dvNV glVertexAttrib2dvNV = null;

        // GLAPI void APIENTRY glVertexAttrib2fNV (GLuint index, GLfloat x, GLfloat y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib2fNV(GLuint index, GLfloat x, GLfloat y);
        private static TglVertexAttrib2fNV glVertexAttrib2fNV = null;

        // GLAPI void APIENTRY glVertexAttrib2fvNV (GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib2fvNV(GLuint index, GLfloat* v);
        private static TglVertexAttrib2fvNV glVertexAttrib2fvNV = null;

        // GLAPI void APIENTRY glVertexAttrib2sNV (GLuint index, GLshort x, GLshort y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib2sNV(GLuint index, GLshort x, GLshort y);
        private static TglVertexAttrib2sNV glVertexAttrib2sNV = null;

        // GLAPI void APIENTRY glVertexAttrib2svNV (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib2svNV(GLuint index, GLshort* v);
        private static TglVertexAttrib2svNV glVertexAttrib2svNV = null;

        // GLAPI void APIENTRY glVertexAttrib3dNV (GLuint index, GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib3dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z);
        private static TglVertexAttrib3dNV glVertexAttrib3dNV = null;

        // GLAPI void APIENTRY glVertexAttrib3dvNV (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib3dvNV(GLuint index, GLdouble* v);
        private static TglVertexAttrib3dvNV glVertexAttrib3dvNV = null;

        // GLAPI void APIENTRY glVertexAttrib3fNV (GLuint index, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib3fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z);
        private static TglVertexAttrib3fNV glVertexAttrib3fNV = null;

        // GLAPI void APIENTRY glVertexAttrib3fvNV (GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib3fvNV(GLuint index, GLfloat* v);
        private static TglVertexAttrib3fvNV glVertexAttrib3fvNV = null;
        
        // GLAPI void APIENTRY glVertexAttrib3sNV (GLuint index, GLshort x, GLshort y, GLshort z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib3sNV(GLuint index, GLshort x, GLshort y, GLshort z);
        private static TglVertexAttrib3sNV glVertexAttrib3sNV = null;

        // GLAPI void APIENTRY glVertexAttrib3svNV (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib3svNV(GLuint index, GLshort* v);
        private static TglVertexAttrib3svNV glVertexAttrib3svNV = null;

        // GLAPI void APIENTRY glVertexAttrib4dNV (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib4dNV(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglVertexAttrib4dNV glVertexAttrib4dNV = null;

        // GLAPI void APIENTRY glVertexAttrib4dvNV (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4dvNV(GLuint index, GLdouble* v);
        private static TglVertexAttrib4dvNV glVertexAttrib4dvNV = null;

        // GLAPI void APIENTRY glVertexAttrib4fNV (GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib4fNV(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglVertexAttrib4fNV glVertexAttrib4fNV = null;

        // GLAPI void APIENTRY glVertexAttrib4fvNV (GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4fvNV(GLuint index, GLfloat* v);
        private static TglVertexAttrib4fvNV glVertexAttrib4fvNV = null;

        // GLAPI void APIENTRY glVertexAttrib4sNV (GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib4sNV(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        private static TglVertexAttrib4sNV glVertexAttrib4sNV = null;

        // GLAPI void APIENTRY glVertexAttrib4svNV (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4svNV(GLuint index, GLshort* v);
        private static TglVertexAttrib4svNV glVertexAttrib4svNV = null;

        // GLAPI void APIENTRY glVertexAttrib4ubNV (GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib4ubNV(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        private static TglVertexAttrib4ubNV glVertexAttrib4ubNV = null;

        // GLAPI void APIENTRY glVertexAttrib4ubvNV (GLuint index, const GLubyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4ubvNV(GLuint index, GLubyte* v);
        private static TglVertexAttrib4ubvNV glVertexAttrib4ubvNV = null;

        // GLAPI void APIENTRY glVertexAttribs1dvNV (GLuint index, GLsizei count, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs1dvNV(GLuint index, GLsizei count, GLdouble* v);
        private static TglVertexAttribs1dvNV glVertexAttribs1dvNV = null;

        // GLAPI void APIENTRY glVertexAttribs1fvNV (GLuint index, GLsizei count, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs1fvNV(GLuint index, GLsizei count, GLfloat* v);
        private static TglVertexAttribs1fvNV glVertexAttribs1fvNV = null;

        // GLAPI void APIENTRY glVertexAttribs1svNV (GLuint index, GLsizei count, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs1svNV(GLuint index, GLsizei count, GLshort* v);
        private static TglVertexAttribs1svNV glVertexAttribs1svNV = null;

        // GLAPI void APIENTRY glVertexAttribs2dvNV (GLuint index, GLsizei count, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs2dvNV(GLuint index, GLsizei count, GLdouble* v);
        private static TglVertexAttribs2dvNV glVertexAttribs2dvNV = null;

        // GLAPI void APIENTRY glVertexAttribs2fvNV (GLuint index, GLsizei count, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs2fvNV(GLuint index, GLsizei count, GLfloat* v);
        private static TglVertexAttribs2fvNV glVertexAttribs2fvNV = null;

        // GLAPI void APIENTRY glVertexAttribs2svNV (GLuint index, GLsizei count, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs2svNV(GLuint index, GLsizei count, GLshort* v);
        private static TglVertexAttribs2svNV glVertexAttribs2svNV = null;

        // GLAPI void APIENTRY glVertexAttribs3dvNV (GLuint index, GLsizei count, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs3dvNV(GLuint index, GLsizei count, GLdouble* v);
        private static TglVertexAttribs3dvNV glVertexAttribs3dvNV = null;

        // GLAPI void APIENTRY glVertexAttribs3fvNV (GLuint index, GLsizei count, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs3fvNV(GLuint index, GLsizei count, GLfloat* v);
        private static TglVertexAttribs3fvNV glVertexAttribs3fvNV = null;

        // GLAPI void APIENTRY glVertexAttribs3svNV (GLuint index, GLsizei count, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs3svNV(GLuint index, GLsizei count, GLshort* v);
        private static TglVertexAttribs3svNV glVertexAttribs3svNV = null;

        // GLAPI void APIENTRY glVertexAttribs4dvNV (GLuint index, GLsizei count, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs4dvNV(GLuint index, GLsizei count, GLdouble* v);
        private static TglVertexAttribs4dvNV glVertexAttribs4dvNV = null;

        // GLAPI void APIENTRY glVertexAttribs4fvNV (GLuint index, GLsizei count, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs4fvNV(GLuint index, GLsizei count, GLfloat* v);
        private static TglVertexAttribs4fvNV glVertexAttribs4fvNV = null;

        // GLAPI void APIENTRY glVertexAttribs4svNV (GLuint index, GLsizei count, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs4svNV(GLuint index, GLsizei count, GLshort* v);
        private static TglVertexAttribs4svNV glVertexAttribs4svNV = null;

        // GLAPI void APIENTRY glVertexAttribs4ubvNV (GLuint index, GLsizei count, const GLubyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs4ubvNV(GLuint index, GLsizei count, GLubyte* v);
        private static TglVertexAttribs4ubvNV glVertexAttribs4ubvNV = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenOcclusionQueriesNV(GLsizei n, GLuint* ids);
        private static TglGenOcclusionQueriesNV glGenOcclusionQueriesNV = null;

        // GLAPI void APIENTRY glDeleteOcclusionQueriesNV (GLsizei n, const GLuint *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteOcclusionQueriesNV(GLsizei n, GLuint* ids);
        private static TglDeleteOcclusionQueriesNV glDeleteOcclusionQueriesNV = null;

        // GLAPI GLboolean APIENTRY glIsOcclusionQueryNV (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsOcclusionQueryNV(GLuint id);
        private static TglIsOcclusionQueryNV glIsOcclusionQueryNV = null;

        // GLAPI void APIENTRY glBeginOcclusionQueryNV (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginOcclusionQueryNV(GLuint id);
        private static TglBeginOcclusionQueryNV glBeginOcclusionQueryNV = null;

        // GLAPI void APIENTRY glEndOcclusionQueryNV (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndOcclusionQueryNV();
        private static TglEndOcclusionQueryNV glEndOcclusionQueryNV = null;

        // GLAPI void APIENTRY glGetOcclusionQueryivNV (GLuint id, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetOcclusionQueryivNV(GLuint id, GLenum pname, GLint* parameters);
        private static TglGetOcclusionQueryivNV glGetOcclusionQueryivNV = null;

        // GLAPI void APIENTRY glGetOcclusionQueryuivNV (GLuint id, GLenum pname, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetOcclusionQueryuivNV(GLuint id, GLenum pname, GLuint* parameters);
        private static TglGetOcclusionQueryuivNV glGetOcclusionQueryuivNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_point_sprite
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPointParameteriNV (GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPointParameteriNV(GLenum pname, GLint param);
        private static TglPointParameteriNV glPointParameteriNV = null;

        // GLAPI void APIENTRY glPointParameterivNV (GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPointParameterivNV(GLenum pname, GLint* parameters);
        private static TglPointParameterivNV glPointParameterivNV = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramNamedParameter4fNV(GLuint id, GLsizei len, GLubyte* name, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglProgramNamedParameter4fNV glProgramNamedParameter4fNV = null;

        // GLAPI void APIENTRY glProgramNamedParameter4dNV (GLuint id, GLsizei len, const GLubyte *name, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramNamedParameter4dNV(GLuint id, GLsizei len, GLubyte* name, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglProgramNamedParameter4dNV glProgramNamedParameter4dNV = null;

        // GLAPI void APIENTRY glProgramNamedParameter4fvNV (GLuint id, GLsizei len, const GLubyte *name, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramNamedParameter4fvNV(GLuint id, GLsizei len, GLubyte* name, GLfloat* v);
        private static TglProgramNamedParameter4fvNV glProgramNamedParameter4fvNV = null;

        // GLAPI void APIENTRY glProgramNamedParameter4dvNV (GLuint id, GLsizei len, const GLubyte *name, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramNamedParameter4dvNV(GLuint id, GLsizei len, GLubyte* name, GLdouble* v);
        private static TglProgramNamedParameter4dvNV glProgramNamedParameter4dvNV = null;

        // GLAPI void APIENTRY glGetProgramNamedParameterfvNV (GLuint id, GLsizei len, const GLubyte *name, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramNamedParameterfvNV(GLuint id, GLsizei len, GLubyte* name, GLfloat* parameters);
        private static TglGetProgramNamedParameterfvNV glGetProgramNamedParameterfvNV = null;

        // GLAPI void APIENTRY glGetProgramNamedParameterdvNV (GLuint id, GLsizei len, const GLubyte *name, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramNamedParameterdvNV(GLuint id, GLsizei len, GLubyte* name, GLdouble* parameters);
        private static TglGetProgramNamedParameterdvNV glGetProgramNamedParameterdvNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_half_float
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertex2hNV (GLhalfNV x, GLhalfNV y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex2hNV(GLhalf x, GLhalf y);
        private static TglVertex2hNV glVertex2hNV = null;

        // GLAPI void APIENTRY glVertex2hvNV (const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex2hvNV(GLhalf* v);
        private static TglVertex2hvNV glVertex2hvNV = null;

        // GLAPI void APIENTRY glVertex3hNV (GLhalfNV x, GLhalfNV y, GLhalfNV z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex3hNV(GLhalf x, GLhalf y, GLhalf z);
        private static TglVertex3hNV glVertex3hNV = null;

        // GLAPI void APIENTRY glVertex3hvNV (const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex3hvNV(GLhalf* v);
        private static TglVertex3hvNV glVertex3hvNV = null;

        // GLAPI void APIENTRY glVertex4hNV (GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex4hNV(GLhalf x, GLhalf y, GLhalf z, GLhalf w);
        private static TglVertex4hNV glVertex4hNV = null;

        // GLAPI void APIENTRY glVertex4hvNV (const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex4hvNV(GLhalf* v);
        private static TglVertex4hvNV glVertex4hvNV = null;

        // GLAPI void APIENTRY glNormal3hNV (GLhalfNV nx, GLhalfNV ny, GLhalfNV nz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormal3hNV(GLhalf nx, GLhalf ny, GLhalf nz);
        private static TglNormal3hNV glNormal3hNV = null;

        // GLAPI void APIENTRY glNormal3hvNV (const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormal3hvNV(GLhalf* v);
        private static TglNormal3hvNV glNormal3hvNV = null;

        // GLAPI void APIENTRY glColor3hNV (GLhalfNV red, GLhalfNV green, GLhalfNV blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor3hNV(GLhalf red, GLhalf green, GLhalf blue);
        private static TglColor3hNV glColor3hNV = null;

        // GLAPI void APIENTRY glColor3hvNV (const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor3hvNV(GLhalf* v);
        private static TglColor3hvNV glColor3hvNV = null;

        // GLAPI void APIENTRY glColor4hNV (GLhalfNV red, GLhalfNV green, GLhalfNV blue, GLhalfNV alpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor4hNV(GLhalf red, GLhalf green, GLhalf blue, GLhalf alpha);
        private static TglColor4hNV glColor4hNV = null;

        // GLAPI void APIENTRY glColor4hvNV (const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor4hvNV(GLhalf* v);
        private static TglColor4hvNV glColor4hvNV = null;

        // GLAPI void APIENTRY glTexCoord1hNV (GLhalfNV s);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord1hNV(GLhalf s);
        private static TglTexCoord1hNV glTexCoord1hNV = null;

        // GLAPI void APIENTRY glTexCoord1hvNV (const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord1hvNV(GLhalf* nv);
        private static TglTexCoord1hvNV glTexCoord1hvNV = null;

        // GLAPI void APIENTRY glTexCoord2hNV (GLhalfNV s, GLhalfNV t);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord2hNV(GLhalf s, GLhalf t);
        private static TglTexCoord2hNV glTexCoord2hNV = null;

        // GLAPI void APIENTRY glTexCoord2hvNV (const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord2hvNV(GLhalf* v);
        private static TglTexCoord2hvNV glTexCoord2hvNV = null;

        // GLAPI void APIENTRY glTexCoord3hNV (GLhalfNV s, GLhalfNV t, GLhalfNV r);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord3hNV(GLhalf s, GLhalf t, GLhalf r);
        private static TglTexCoord3hNV glTexCoord3hNV = null;

        // GLAPI void APIENTRY glTexCoord3hvNV (const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord3hvNV(GLhalf* v);
        private static TglTexCoord3hvNV glTexCoord3hvNV = null;

        // GLAPI void APIENTRY glTexCoord4hNV (GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord4hNV(GLhalf s, GLhalf t, GLhalf r, GLhalf q);
        private static TglTexCoord4hNV glTexCoord4hNV = null;

        // GLAPI void APIENTRY glTexCoord4hvNV (const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord4hvNV(GLhalf* v);
        private static TglTexCoord4hvNV glTexCoord4hvNV = null;

        // GLAPI void APIENTRY glMultiTexCoord1hNV (GLenum target, GLhalfNV s);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord1hNV(GLenum target, GLhalf s);
        private static TglMultiTexCoord1hNV glMultiTexCoord1hNV = null;

        // GLAPI void APIENTRY glMultiTexCoord1hvNV (GLenum target, const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord1hvNV(GLenum target, GLhalf* v);
        private static TglMultiTexCoord1hvNV glMultiTexCoord1hvNV = null;

        // GLAPI void APIENTRY glMultiTexCoord2hNV (GLenum target, GLhalfNV s, GLhalfNV t);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord2hNV(GLenum target, GLhalf s, GLhalf t);
        private static TglMultiTexCoord2hNV glMultiTexCoord2hNV = null;

        // GLAPI void APIENTRY glMultiTexCoord2hvNV (GLenum target, const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord2hvNV(GLenum target, GLhalf* v);
        private static TglMultiTexCoord2hvNV glMultiTexCoord2hvNV = null;

        // GLAPI void APIENTRY glMultiTexCoord3hNV (GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord3hNV(GLenum target, GLhalf s, GLhalf t, GLhalf r);
        private static TglMultiTexCoord3hNV glMultiTexCoord3hNV = null;

        // GLAPI void APIENTRY glMultiTexCoord3hvNV (GLenum target, const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord3hvNV(GLenum target, GLhalf* v);
        private static TglMultiTexCoord3hvNV glMultiTexCoord3hvNV = null;

        // GLAPI void APIENTRY glMultiTexCoord4hNV (GLenum target, GLhalfNV s, GLhalfNV t, GLhalfNV r, GLhalfNV q);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord4hNV(GLenum target, GLhalf s, GLhalf t, GLhalf r, GLhalf q);
        private static TglMultiTexCoord4hNV glMultiTexCoord4hNV = null;

        // GLAPI void APIENTRY glMultiTexCoord4hvNV (GLenum target, const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord4hvNV(GLenum target, GLhalf* v);
        private static TglMultiTexCoord4hvNV glMultiTexCoord4hvNV = null;

        // GLAPI void APIENTRY glFogCoordhNV (GLhalfNV fog);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFogCoordhNV(GLhalf fog);
        private static TglFogCoordhNV glFogCoordhNV = null;

        // GLAPI void APIENTRY glFogCoordhvNV (const GLhalfNV *fog);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFogCoordhvNV(GLhalf* fog);
        private static TglFogCoordhvNV glFogCoordhvNV = null;

        // GLAPI void APIENTRY glSecondaryColor3hNV (GLhalfNV red, GLhalfNV green, GLhalfNV blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3hNV(GLhalf red, GLhalf green, GLhalf blue);
        private static TglSecondaryColor3hNV glSecondaryColor3hNV = null;

        // GLAPI void APIENTRY glSecondaryColor3hvNV (const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3hvNV(GLhalf* v);
        private static TglSecondaryColor3hvNV glSecondaryColor3hvNV = null;

        // GLAPI void APIENTRY glVertexWeighthNV (GLhalfNV weight);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexWeighthNV(GLhalf weight);
        private static TglVertexWeighthNV glVertexWeighthNV = null;

        // GLAPI void APIENTRY glVertexWeighthvNV (const GLhalfNV *weight);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexWeighthvNV(GLhalf* weight);
        private static TglVertexWeighthvNV glVertexWeighthvNV = null;

        // GLAPI void APIENTRY glVertexAttrib1hNV (GLuint index, GLhalfNV x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib1hNV(GLuint index, GLhalf x);
        private static TglVertexAttrib1hNV glVertexAttrib1hNV = null;

        // GLAPI void APIENTRY glVertexAttrib1hvNV (GLuint index, const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib1hvNV(GLuint index, GLhalf* v);
        private static TglVertexAttrib1hvNV glVertexAttrib1hvNV = null;

        // GLAPI void APIENTRY glVertexAttrib2hNV (GLuint index, GLhalfNV x, GLhalfNV y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib2hNV(GLuint index, GLhalf x, GLhalf y);
        private static TglVertexAttrib2hNV glVertexAttrib2hNV = null;

        // GLAPI void APIENTRY glVertexAttrib2hvNV (GLuint index, const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib2hvNV(GLuint index, GLhalf* v);
        private static TglVertexAttrib2hvNV glVertexAttrib2hvNV = null;

        // GLAPI void APIENTRY glVertexAttrib3hNV (GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib3hNV(GLuint index, GLhalf x, GLhalf y, GLhalf z);
        private static TglVertexAttrib3hNV glVertexAttrib3hNV = null;

        // GLAPI void APIENTRY glVertexAttrib3hvNV (GLuint index, const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib3hvNV(GLuint index, GLhalf* v);
        private static TglVertexAttrib3hvNV glVertexAttrib3hvNV = null;

        // GLAPI void APIENTRY glVertexAttrib4hNV (GLuint index, GLhalfNV x, GLhalfNV y, GLhalfNV z, GLhalfNV w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib4hNV(GLuint index, GLhalf x, GLhalf y, GLhalf z, GLhalf w);
        private static TglVertexAttrib4hNV glVertexAttrib4hNV = null;

        // GLAPI void APIENTRY glVertexAttrib4hvNV (GLuint index, const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4hvNV(GLuint index, GLhalf* v);
        private static TglVertexAttrib4hvNV glVertexAttrib4hvNV = null;

        // GLAPI void APIENTRY glVertexAttribs1hvNV (GLuint index, GLsizei n, const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs1hvNV(GLuint index, GLsizei n, GLhalf* v);
        private static TglVertexAttribs1hvNV glVertexAttribs1hvNV = null;

        // GLAPI void APIENTRY glVertexAttribs2hvNV (GLuint index, GLsizei n, const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs2hvNV(GLuint index, GLsizei n, GLhalf* v);
        private static TglVertexAttribs2hvNV glVertexAttribs2hvNV = null;

        // GLAPI void APIENTRY glVertexAttribs3hvNV (GLuint index, GLsizei n, const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs3hvNV(GLuint index, GLsizei n, GLhalf* v);
        private static TglVertexAttribs3hvNV glVertexAttribs3hvNV = null;

        // GLAPI void APIENTRY glVertexAttribs4hvNV (GLuint index, GLsizei n, const GLhalfNV *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribs4hvNV(GLuint index, GLsizei n, GLhalf* v);
        private static TglVertexAttribs4hvNV glVertexAttribs4hvNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_pixel_data_range
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPixelDataRangeNV (GLenum target, GLsizei length, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPixelDataRangeNV(GLenum target, GLsizei length, void* pointer);
        private static TglPixelDataRangeNV glPixelDataRangeNV = null;

        // GLAPI void APIENTRY glFlushPixelDataRangeNV (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFlushPixelDataRangeNV(GLenum target);
        private static TglFlushPixelDataRangeNV glFlushPixelDataRangeNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_primitive_restart
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPrimitiveRestartNV (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPrimitiveRestartNV();
        private static TglPrimitiveRestartNV glPrimitiveRestartNV = null;

        // GLAPI void APIENTRY glPrimitiveRestartIndexNV (GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPrimitiveRestartIndexNV(GLuint index);
        private static TglPrimitiveRestartIndexNV glPrimitiveRestartIndexNV = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramLocalParameterI4iNV(GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);
        private static TglProgramLocalParameterI4iNV glProgramLocalParameterI4iNV = null;

        // GLAPI void APIENTRY glProgramLocalParameterI4ivNV (GLenum target, GLuint index, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramLocalParameterI4ivNV(GLenum target, GLuint index, GLint* parameters);
        private static TglProgramLocalParameterI4ivNV glProgramLocalParameterI4ivNV = null;

        // GLAPI void APIENTRY glProgramLocalParametersI4ivNV (GLenum target, GLuint index, GLsizei count, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramLocalParametersI4ivNV(GLenum target, GLuint index, GLsizei count, GLint* parameters);
        private static TglProgramLocalParametersI4ivNV glProgramLocalParametersI4ivNV = null;

        // GLAPI void APIENTRY glProgramLocalParameterI4uiNV (GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramLocalParameterI4uiNV(GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        private static TglProgramLocalParameterI4uiNV glProgramLocalParameterI4uiNV = null;

        // GLAPI void APIENTRY glProgramLocalParameterI4uivNV (GLenum target, GLuint index, const GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramLocalParameterI4uivNV(GLenum target, GLuint index, GLuint* parameters);
        private static TglProgramLocalParameterI4uivNV glProgramLocalParameterI4uivNV = null;

        // GLAPI void APIENTRY glProgramLocalParametersI4uivNV (GLenum target, GLuint index, GLsizei count, const GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramLocalParametersI4uivNV(GLenum target, GLuint index, GLsizei count, GLuint* parameters);
        private static TglProgramLocalParametersI4uivNV glProgramLocalParametersI4uivNV = null;

        // GLAPI void APIENTRY glProgramEnvParameterI4iNV (GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramEnvParameterI4iNV(GLenum target, GLuint index, GLint x, GLint y, GLint z, GLint w);
        private static TglProgramEnvParameterI4iNV glProgramEnvParameterI4iNV = null;

        // GLAPI void APIENTRY glProgramEnvParameterI4ivNV (GLenum target, GLuint index, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramEnvParameterI4ivNV(GLenum target, GLuint index, GLint* parameters);
        private static TglProgramEnvParameterI4ivNV glProgramEnvParameterI4ivNV = null;

        // GLAPI void APIENTRY glProgramEnvParametersI4ivNV (GLenum target, GLuint index, GLsizei count, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramEnvParametersI4ivNV(GLenum target, GLuint index, GLsizei count, GLint* parameters);
        private static TglProgramEnvParametersI4ivNV glProgramEnvParametersI4ivNV = null;

        // GLAPI void APIENTRY glProgramEnvParameterI4uiNV (GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramEnvParameterI4uiNV(GLenum target, GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        private static TglProgramEnvParameterI4uiNV glProgramEnvParameterI4uiNV = null;

        // GLAPI void APIENTRY glProgramEnvParameterI4uivNV (GLenum target, GLuint index, const GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramEnvParameterI4uivNV(GLenum target, GLuint index, GLuint* parameters);
        private static TglProgramEnvParameterI4uivNV glProgramEnvParameterI4uivNV = null;

        // GLAPI void APIENTRY glProgramEnvParametersI4uivNV (GLenum target, GLuint index, GLsizei count, const GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramEnvParametersI4uivNV(GLenum target, GLuint index, GLsizei count, GLuint* parameters);
        private static TglProgramEnvParametersI4uivNV glProgramEnvParametersI4uivNV = null;

        // GLAPI void APIENTRY glGetProgramLocalParameterIivNV (GLenum target, GLuint index, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramLocalParameterIivNV(GLenum target, GLuint index, GLint* parameters);
        private static TglGetProgramLocalParameterIivNV glGetProgramLocalParameterIivNV = null;

        // GLAPI void APIENTRY glGetProgramLocalParameterIuivNV (GLenum target, GLuint index, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramLocalParameterIuivNV(GLenum target, GLuint index, GLuint* parameters);
        private static TglGetProgramLocalParameterIuivNV glGetProgramLocalParameterIuivNV = null;

        // GLAPI void APIENTRY glGetProgramEnvParameterIivNV (GLenum target, GLuint index, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramEnvParameterIivNV(GLenum target, GLuint index, GLint* parameters);
        private static TglGetProgramEnvParameterIivNV glGetProgramEnvParameterIivNV = null;

        // GLAPI void APIENTRY glGetProgramEnvParameterIuivNV (GLenum target, GLuint index, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramEnvParameterIuivNV(GLenum target, GLuint index, GLuint* parameters);
        private static TglGetProgramEnvParameterIuivNV glGetProgramEnvParameterIuivNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_geometry_program4
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glProgramVertexLimitNV (GLenum target, GLint limit);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramVertexLimitNV(GLenum target, GLint limit);
        private static TglProgramVertexLimitNV glProgramVertexLimitNV = null;

        // GLAPI void APIENTRY glFramebufferTextureEXT (GLenum target, GLenum attachment, GLuint texture, GLint level);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTextureEXT(GLenum target, GLenum attachment, GLuint texture, GLint level);
        private static TglFramebufferTextureEXT glFramebufferTextureEXT = null;

        // GLAPI void APIENTRY glFramebufferTextureLayerEXT (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTextureLayerEXT(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);
        private static TglFramebufferTextureLayerEXT glFramebufferTextureLayerEXT = null;

        // GLAPI void APIENTRY glFramebufferTextureFaceEXT (GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTextureFaceEXT(GLenum target, GLenum attachment, GLuint texture, GLint level, GLenum face);
        private static TglFramebufferTextureFaceEXT glFramebufferTextureFaceEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_program4
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVertexAttribI1iEXT (GLuint index, GLint x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI1iEXT(GLuint index, GLint x);
        private static TglVertexAttribI1iEXT glVertexAttribI1iEXT = null;

        // GLAPI void APIENTRY glVertexAttribI2iEXT (GLuint index, GLint x, GLint y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI2iEXT(GLuint index, GLint x, GLint y);
        private static TglVertexAttribI2iEXT glVertexAttribI2iEXT = null;

        // GLAPI void APIENTRY glVertexAttribI3iEXT (GLuint index, GLint x, GLint y, GLint z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI3iEXT(GLuint index, GLint x, GLint y, GLint z);
        private static TglVertexAttribI3iEXT glVertexAttribI3iEXT = null;

        // GLAPI void APIENTRY glVertexAttribI4iEXT (GLuint index, GLint x, GLint y, GLint z, GLint w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI4iEXT(GLuint index, GLint x, GLint y, GLint z, GLint w);
        private static TglVertexAttribI4iEXT glVertexAttribI4iEXT = null;

        // GLAPI void APIENTRY glVertexAttribI1uiEXT (GLuint index, GLuint x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI1uiEXT(GLuint index, GLuint x);
        private static TglVertexAttribI1uiEXT glVertexAttribI1uiEXT = null;

        // GLAPI void APIENTRY glVertexAttribI2uiEXT (GLuint index, GLuint x, GLuint y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI2uiEXT(GLuint index, GLuint x, GLuint y);
        private static TglVertexAttribI2uiEXT glVertexAttribI2uiEXT = null;

        // GLAPI void APIENTRY glVertexAttribI3uiEXT (GLuint index, GLuint x, GLuint y, GLuint z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI3uiEXT(GLuint index, GLuint x, GLuint y, GLuint z);
        private static TglVertexAttribI3uiEXT glVertexAttribI3uiEXT = null;

        // GLAPI void APIENTRY glVertexAttribI4uiEXT (GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI4uiEXT(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        private static TglVertexAttribI4uiEXT glVertexAttribI4uiEXT = null;

        // GLAPI void APIENTRY glVertexAttribI1ivEXT (GLuint index, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI1ivEXT(GLuint index, GLint* v);
        private static TglVertexAttribI1ivEXT glVertexAttribI1ivEXT = null;

        // GLAPI void APIENTRY glVertexAttribI2ivEXT (GLuint index, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI2ivEXT(GLuint index, GLint* v);
        private static TglVertexAttribI2ivEXT glVertexAttribI2ivEXT = null;

        // GLAPI void APIENTRY glVertexAttribI3ivEXT (GLuint index, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI3ivEXT(GLuint index, GLint* v);
        private static TglVertexAttribI3ivEXT glVertexAttribI3ivEXT = null;

        // GLAPI void APIENTRY glVertexAttribI4ivEXT (GLuint index, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI4ivEXT(GLuint index, GLint* v);
        private static TglVertexAttribI4ivEXT glVertexAttribI4ivEXT = null;

        // GLAPI void APIENTRY glVertexAttribI1uivEXT (GLuint index, const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI1uivEXT(GLuint index, GLuint* v);
        private static TglVertexAttribI1uivEXT glVertexAttribI1uivEXT = null;

        // GLAPI void APIENTRY glVertexAttribI2uivEXT (GLuint index, const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI2uivEXT(GLuint index, GLuint* v);
        private static TglVertexAttribI2uivEXT glVertexAttribI2uivEXT = null;

        // GLAPI void APIENTRY glVertexAttribI3uivEXT (GLuint index, const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI3uivEXT(GLuint index, GLuint* v);
        private static TglVertexAttribI3uivEXT glVertexAttribI3uivEXT = null;

        // GLAPI void APIENTRY glVertexAttribI4uivEXT (GLuint index, const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI4uivEXT(GLuint index, GLuint* v);
        private static TglVertexAttribI4uivEXT glVertexAttribI4uivEXT = null;

        // GLAPI void APIENTRY glVertexAttribI4bvEXT (GLuint index, const GLbyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI4bvEXT(GLuint index, GLbyte* v);
        private static TglVertexAttribI4bvEXT glVertexAttribI4bvEXT = null;

        // GLAPI void APIENTRY glVertexAttribI4svEXT (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI4svEXT(GLuint index, GLshort* v);
        private static TglVertexAttribI4svEXT glVertexAttribI4svEXT = null;

        // GLAPI void APIENTRY glVertexAttribI4ubvEXT (GLuint index, const GLubyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI4ubvEXT(GLuint index, GLubyte* v);
        private static TglVertexAttribI4ubvEXT glVertexAttribI4ubvEXT = null;

        // GLAPI void APIENTRY glVertexAttribI4usvEXT (GLuint index, const GLushort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI4usvEXT(GLuint index, GLushort* v);
        private static TglVertexAttribI4usvEXT glVertexAttribI4usvEXT = null;

        // GLAPI void APIENTRY glVertexAttribIPointerEXT (GLuint index, GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribIPointerEXT(GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer);
        private static TglVertexAttribIPointerEXT glVertexAttribIPointerEXT = null;

        // GLAPI void APIENTRY glGetVertexAttribIivEXT (GLuint index, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribIivEXT(GLuint index, GLenum pname, GLint* parameters);
        private static TglGetVertexAttribIivEXT glGetVertexAttribIivEXT = null;

        // GLAPI void APIENTRY glGetVertexAttribIuivEXT (GLuint index, GLenum pname, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribIuivEXT(GLuint index, GLenum pname, GLuint* parameters);
        private static TglGetVertexAttribIuivEXT glGetVertexAttribIuivEXT = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_depth_buffer_float
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDepthRangedNV (GLdouble zNear, GLdouble zFar);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDepthRangedNV(GLdouble zNear, GLdouble zFar);
        private static TglDepthRangedNV glDepthRangedNV = null;

        // GLAPI void APIENTRY glClearDepthdNV (GLdouble depth);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearDepthdNV(GLdouble depth);
        private static TglClearDepthdNV glClearDepthdNV = null;

        // GLAPI void APIENTRY glDepthBoundsdNV (GLdouble zmin, GLdouble zmax);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDepthBoundsdNV(GLdouble zmin, GLdouble zmax);
        private static TglDepthBoundsdNV glDepthBoundsdNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fragment_program4 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_framebuffer_multisample_coverage
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glRenderbufferStorageMultisampleCoverageNV (GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRenderbufferStorageMultisampleCoverageNV(GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglRenderbufferStorageMultisampleCoverageNV glRenderbufferStorageMultisampleCoverageNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_geometry_shader4 (no function entry point)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_parameter_buffer_object
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glProgramBufferParametersfvNV (GLenum target, GLuint buffer, GLuint index, GLsizei count, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramBufferParametersfvNV(GLenum target, GLuint buffer, GLuint index, GLsizei count, GLfloat* parameters);
        private static TglProgramBufferParametersfvNV glProgramBufferParametersfvNV = null;

        // GLAPI void APIENTRY glProgramBufferParametersIivNV (GLenum target, GLuint buffer, GLuint index, GLsizei count, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramBufferParametersIivNV(GLenum target, GLuint buffer, GLuint index, GLsizei count, GLint* parameters);
        private static TglProgramBufferParametersIivNV glProgramBufferParametersIivNV = null;

        // GLAPI void APIENTRY glProgramBufferParametersIuivNV (GLenum target, GLuint buffer, GLuint index, GLsizei count, const GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramBufferParametersIuivNV(GLenum target, GLuint buffer, GLuint index, GLsizei count, GLuint* parameters);
        private static TglProgramBufferParametersIuivNV glProgramBufferParametersIuivNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_transform_feedback
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginTransformFeedbackNV (GLenum primitiveMode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginTransformFeedbackNV(GLenum primitiveMode);
        private static TglBeginTransformFeedbackNV glBeginTransformFeedbackNV = null;

        // GLAPI void APIENTRY glEndTransformFeedbackNV (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndTransformFeedbackNV();
        private static TglEndTransformFeedbackNV glEndTransformFeedbackNV = null;

        // GLAPI void APIENTRY glTransformFeedbackAttribsNV (GLuint count, const GLint *attribs, GLenum bufferMode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTransformFeedbackAttribsNV(GLuint count, GLint* attribs, GLenum bufferMode);
        private static TglTransformFeedbackAttribsNV glTransformFeedbackAttribsNV = null;

        // GLAPI void APIENTRY glBindBufferRangeNV (GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindBufferRangeNV(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
        private static TglBindBufferRangeNV glBindBufferRangeNV = null;

        // GLAPI void APIENTRY glBindBufferOffsetNV (GLenum target, GLuint index, GLuint buffer, GLintptr offset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindBufferOffsetNV(GLenum target, GLuint index, GLuint buffer, GLintptr offset);
        private static TglBindBufferOffsetNV glBindBufferOffsetNV = null;

        // GLAPI void APIENTRY glBindBufferBaseNV (GLenum target, GLuint index, GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindBufferBaseNV(GLenum target, GLuint index, GLuint buffer);
        private static TglBindBufferBaseNV glBindBufferBaseNV = null;

        // GLAPI void APIENTRY glTransformFeedbackVaryingsNV (GLuint program, GLsizei count, const GLint *locations, GLenum bufferMode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTransformFeedbackVaryingsNV(GLuint program, GLsizei count, GLint* locations, GLenum bufferMode);
        private static TglTransformFeedbackVaryingsNV glTransformFeedbackVaryingsNV = null;

        // GLAPI void APIENTRY glActiveVaryingNV (GLuint program, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglActiveVaryingNV(GLuint program, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglActiveVaryingNV glActiveVaryingNV = null;

        // GLAPI GLint APIENTRY glGetVaryingLocationNV (GLuint program, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLint TglGetVaryingLocationNV(GLuint program, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglGetVaryingLocationNV glGetVaryingLocationNV = null;

        // GLAPI void APIENTRY glGetActiveVaryingNV (GLuint program, GLuint index, GLsizei bufSize, GLsizei *length, GLsizei *size, GLenum *type, GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetActiveVaryingNV(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name);
        private static TglGetActiveVaryingNV glGetActiveVaryingNV = null;

        // GLAPI void APIENTRY glGetTransformFeedbackVaryingNV (GLuint program, GLuint index, GLint *location);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTransformFeedbackVaryingNV(GLuint program, GLuint index, GLint* location);
        private static TglGetTransformFeedbackVaryingNV glGetTransformFeedbackVaryingNV = null;

        // GLAPI void APIENTRY glTransformFeedbackStreamAttribsNV (GLsizei count, const GLint *attribs, GLsizei nbuffers, const GLint *bufstreams, GLenum bufferMode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTransformFeedbackStreamAttribsNV(GLsizei count, GLint* attribs, GLsizei nbuffers, GLint* bufstreams, GLenum bufferMode);
        private static TglTransformFeedbackStreamAttribsNV glTransformFeedbackStreamAttribsNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_conditional_render
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginConditionalRenderNV (GLuint id, GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginConditionalRenderNV(GLuint id, GLenum mode);
        private static TglBeginConditionalRenderNV glBeginConditionalRenderNV = null;

        // GLAPI void APIENTRY glEndConditionalRenderNV (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndConditionalRenderNV();
        private static TglEndConditionalRenderNV glEndConditionalRenderNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_present_video
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPresentFrameKeyedNV (GLuint video_slot, GLuint64EXT minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLuint key0, GLenum target1, GLuint fill1, GLuint key1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPresentFrameKeyedNV(GLuint video_slot, GLuint64 minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLuint key0, GLenum target1, GLuint fill1, GLuint key1);
        private static TglPresentFrameKeyedNV glPresentFrameKeyedNV = null;

        // GLAPI void APIENTRY glPresentFrameDualFillNV (GLuint video_slot, GLuint64EXT minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLenum target1, GLuint fill1, GLenum target2, GLuint fill2, GLenum target3, GLuint fill3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPresentFrameDualFillNV(GLuint video_slot, GLuint64 minPresentTime, GLuint beginPresentTimeId, GLuint presentDurationId, GLenum type, GLenum target0, GLuint fill0, GLenum target1, GLuint fill1, GLenum target2, GLuint fill2, GLenum target3, GLuint fill3);
        private static TglPresentFrameDualFillNV glPresentFrameDualFillNV = null;

        // GLAPI void APIENTRY glGetVideoivNV (GLuint video_slot, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVideoivNV(GLuint video_slot, GLenum pname, GLint* parameters);
        private static TglGetVideoivNV glGetVideoivNV = null;

        // GLAPI void APIENTRY glGetVideouivNV (GLuint video_slot, GLenum pname, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVideouivNV(GLuint video_slot, GLenum pname, GLuint* parameters);
        private static TglGetVideouivNV glGetVideouivNV = null;

        // GLAPI void APIENTRY glGetVideoi64vNV (GLuint video_slot, GLenum pname, GLint64EXT *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVideoi64vNV(GLuint video_slot, GLenum pname, GLint64* parameters);
        private static TglGetVideoi64vNV glGetVideoi64vNV = null;

        // GLAPI void APIENTRY glGetVideoui64vNV (GLuint video_slot, GLenum pname, GLuint64EXT *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVideoui64vNV(GLuint video_slot, GLenum pname, GLuint64* parameters);
        private static TglGetVideoui64vNV glGetVideoui64vNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_explicit_multisample
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetMultisamplefvNV (GLenum pname, GLuint index, GLfloat *val);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultisamplefvNV(GLenum pname, GLuint index, GLfloat* val);
        private static TglGetMultisamplefvNV glGetMultisamplefvNV = null;

        // GLAPI void APIENTRY glSampleMaskIndexedNV (GLuint index, GLbitfield mask);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSampleMaskIndexedNV(GLuint index, GLbitfield mask);
        private static TglSampleMaskIndexedNV glSampleMaskIndexedNV = null;

        // GLAPI void APIENTRY glTexRenderbufferNV (GLenum target, GLuint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexRenderbufferNV(GLenum target, GLuint renderbuffer);
        private static TglTexRenderbufferNV glTexRenderbufferNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_transform_feedback2
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBindTransformFeedbackNV (GLenum target, GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindTransformFeedbackNV(GLenum target, GLuint id);
        private static TglBindTransformFeedbackNV glBindTransformFeedbackNV = null;

        // GLAPI void APIENTRY glDeleteTransformFeedbacksNV (GLsizei n, const GLuint *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteTransformFeedbacksNV(GLsizei n, GLuint* ids);
        private static TglDeleteTransformFeedbacksNV glDeleteTransformFeedbacksNV = null;

        // GLAPI void APIENTRY glGenTransformFeedbacksNV (GLsizei n, GLuint *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenTransformFeedbacksNV(GLsizei n, GLuint* ids);
        private static TglGenTransformFeedbacksNV glGenTransformFeedbacksNV = null;

        // GLAPI GLboolean APIENTRY glIsTransformFeedbackNV (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsTransformFeedbackNV(GLuint id);
        private static TglIsTransformFeedbackNV glIsTransformFeedbackNV = null;

        // GLAPI void APIENTRY glPauseTransformFeedbackNV (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPauseTransformFeedbackNV();
        private static TglPauseTransformFeedbackNV glPauseTransformFeedbackNV = null;

        // GLAPI void APIENTRY glResumeTransformFeedbackNV (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglResumeTransformFeedbackNV();
        private static TglResumeTransformFeedbackNV glResumeTransformFeedbackNV = null;

        // GLAPI void APIENTRY glDrawTransformFeedbackNV (GLenum mode, GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawTransformFeedbackNV(GLenum mode, GLuint id);
        private static TglDrawTransformFeedbackNV glDrawTransformFeedbackNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_video_capture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginVideoCaptureNV (GLuint video_capture_slot);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginVideoCaptureNV(GLuint video_capture_slot);
        private static TglBeginVideoCaptureNV glBeginVideoCaptureNV = null;

        // GLAPI void APIENTRY glBindVideoCaptureStreamBufferNV (GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLintptrARB offset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindVideoCaptureStreamBufferNV(GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLintptr offset);
        private static TglBindVideoCaptureStreamBufferNV glBindVideoCaptureStreamBufferNV = null;

        // GLAPI void APIENTRY glBindVideoCaptureStreamTextureNV (GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLenum target, GLuint texture);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindVideoCaptureStreamTextureNV(GLuint video_capture_slot, GLuint stream, GLenum frame_region, GLenum target, GLuint texture);
        private static TglBindVideoCaptureStreamTextureNV glBindVideoCaptureStreamTextureNV = null;

        // GLAPI void APIENTRY glEndVideoCaptureNV (GLuint video_capture_slot);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndVideoCaptureNV(GLuint video_capture_slot);
        private static TglEndVideoCaptureNV glEndVideoCaptureNV = null;

        // GLAPI void APIENTRY glGetVideoCaptureivNV (GLuint video_capture_slot, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVideoCaptureivNV(GLuint video_capture_slot, GLenum pname, GLint* parameters);
        private static TglGetVideoCaptureivNV glGetVideoCaptureivNV = null;

        // GLAPI void APIENTRY glGetVideoCaptureStreamivNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVideoCaptureStreamivNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLint* parameters);
        private static TglGetVideoCaptureStreamivNV glGetVideoCaptureStreamivNV = null;

        // GLAPI void APIENTRY glGetVideoCaptureStreamfvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVideoCaptureStreamfvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat* parameters);
        private static TglGetVideoCaptureStreamfvNV glGetVideoCaptureStreamfvNV = null;

        // GLAPI void APIENTRY glGetVideoCaptureStreamdvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVideoCaptureStreamdvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble* parameters);
        private static TglGetVideoCaptureStreamdvNV glGetVideoCaptureStreamdvNV = null;

        // GLAPI GLenum APIENTRY glVideoCaptureNV (GLuint video_capture_slot, GLuint *sequence_num, GLuint64EXT *capture_time);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLenum TglVideoCaptureNV(GLuint video_capture_slot, GLuint* sequence_num, GLuint64* capture_time);
        private static TglVideoCaptureNV glVideoCaptureNV = null;

        // GLAPI void APIENTRY glVideoCaptureStreamParameterivNV (GLuint video_capture_slot, GLuint stream, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVideoCaptureStreamParameterivNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLint* parameters);
        private static TglVideoCaptureStreamParameterivNV glVideoCaptureStreamParameterivNV = null;

        // GLAPI void APIENTRY glVideoCaptureStreamParameterfvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVideoCaptureStreamParameterfvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLfloat* parameters);
        private static TglVideoCaptureStreamParameterfvNV glVideoCaptureStreamParameterfvNV = null;

        // GLAPI void APIENTRY glVideoCaptureStreamParameterdvNV (GLuint video_capture_slot, GLuint stream, GLenum pname, const GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVideoCaptureStreamParameterdvNV(GLuint video_capture_slot, GLuint stream, GLenum pname, GLdouble* parameters);
        private static TglVideoCaptureStreamParameterdvNV glVideoCaptureStreamParameterdvNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_copy_image
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCopyImageSubDataNV (GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyImageSubDataNV(GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei width, GLsizei height, GLsizei depth);
        private static TglCopyImageSubDataNV glCopyImageSubDataNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_parameter_buffer_object2 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_buffer_load
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMakeBufferResidentNV (GLenum target, GLenum access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMakeBufferResidentNV(GLenum target, GLenum access);
        private static TglMakeBufferResidentNV glMakeBufferResidentNV = null;

        // GLAPI void APIENTRY glMakeBufferNonResidentNV (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMakeBufferNonResidentNV(GLenum target);
        private static TglMakeBufferNonResidentNV glMakeBufferNonResidentNV = null;

        // GLAPI GLboolean APIENTRY glIsBufferResidentNV (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsBufferResidentNV(GLenum target);
        private static TglIsBufferResidentNV glIsBufferResidentNV = null;

        // GLAPI void APIENTRY glMakeNamedBufferResidentNV (GLuint buffer, GLenum access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMakeNamedBufferResidentNV(GLuint buffer, GLenum access);
        private static TglMakeNamedBufferResidentNV glMakeNamedBufferResidentNV = null;

        // GLAPI void APIENTRY glMakeNamedBufferNonResidentNV (GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMakeNamedBufferNonResidentNV(GLuint buffer);
        private static TglMakeNamedBufferNonResidentNV glMakeNamedBufferNonResidentNV = null;

        // GLAPI GLboolean APIENTRY glIsNamedBufferResidentNV (GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsNamedBufferResidentNV(GLuint buffer);
        private static TglIsNamedBufferResidentNV glIsNamedBufferResidentNV = null;

        // GLAPI void APIENTRY glGetBufferParameterui64vNV (GLenum target, GLenum pname, GLuint64EXT *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetBufferParameterui64vNV(GLenum target, GLenum pname, GLuint64* parameters);
        private static TglGetBufferParameterui64vNV glGetBufferParameterui64vNV = null;

        // GLAPI void APIENTRY glGetNamedBufferParameterui64vNV (GLuint buffer, GLenum pname, GLuint64EXT *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedBufferParameterui64vNV(GLuint buffer, GLenum pname, GLuint64* parameters);
        private static TglGetNamedBufferParameterui64vNV glGetNamedBufferParameterui64vNV = null;

        // GLAPI void APIENTRY glGetIntegerui64vNV (GLenum value, GLuint64EXT *result);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetIntegerui64vNV(GLenum value, GLuint64* result);
        private static TglGetIntegerui64vNV glGetIntegerui64vNV = null;

        // GLAPI void APIENTRY glUniformui64NV (GLint location, GLuint64EXT value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniformui64NV(GLint location, GLuint64 value);
        private static TglUniformui64NV glUniformui64NV = null;

        // GLAPI void APIENTRY glUniformui64vNV (GLint location, GLsizei count, const GLuint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformui64vNV(GLint location, GLsizei count, GLuint64* value);
        private static TglUniformui64vNV glUniformui64vNV = null;

        // GLAPI void APIENTRY glProgramUniformui64NV (GLuint program, GLint location, GLuint64EXT value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniformui64NV(GLuint program, GLint location, GLuint64 value);
        private static TglProgramUniformui64NV glProgramUniformui64NV = null;

        // GLAPI void APIENTRY glProgramUniformui64vNV (GLuint program, GLint location, GLsizei count, const GLuint64EXT *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformui64vNV(GLuint program, GLint location, GLsizei count, GLuint64* value);
        private static TglProgramUniformui64vNV glProgramUniformui64vNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_buffer_unified_memory
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBufferAddressRangeNV (GLenum pname, GLuint index, GLuint64EXT address, GLsizeiptr length);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBufferAddressRangeNV(GLenum pname, GLuint index, GLuint64 address, GLsizeiptr length);
        private static TglBufferAddressRangeNV glBufferAddressRangeNV = null;

        // GLAPI void APIENTRY glVertexFormatNV (GLint size, GLenum type, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexFormatNV(GLint size, GLenum type, GLsizei stride);
        private static TglVertexFormatNV glVertexFormatNV = null;

        // GLAPI void APIENTRY glNormalFormatNV (GLenum type, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormalFormatNV(GLenum type, GLsizei stride);
        private static TglNormalFormatNV glNormalFormatNV = null;

        // GLAPI void APIENTRY glColorFormatNV (GLint size, GLenum type, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColorFormatNV(GLint size, GLenum type, GLsizei stride);
        private static TglColorFormatNV glColorFormatNV = null;

        // GLAPI void APIENTRY glIndexFormatNV (GLenum type, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglIndexFormatNV(GLenum type, GLsizei stride);
        private static TglIndexFormatNV glIndexFormatNV = null;

        // GLAPI void APIENTRY glTexCoordFormatNV (GLint size, GLenum type, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoordFormatNV(GLint size, GLenum type, GLsizei stride);
        private static TglTexCoordFormatNV glTexCoordFormatNV = null;

        // GLAPI void APIENTRY glEdgeFlagFormatNV (GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEdgeFlagFormatNV(GLsizei stride);
        private static TglEdgeFlagFormatNV glEdgeFlagFormatNV = null;

        // GLAPI void APIENTRY glSecondaryColorFormatNV (GLint size, GLenum type, GLsizei stride);
        [System.Security.SuppressUnmanagedCodeSecurity()]
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void TglSecondaryColorFormatNV(GLint size, GLenum type, GLsizei stride);
        private static TglSecondaryColorFormatNV glSecondaryColorFormatNV = null;

        // GLAPI void APIENTRY glFogCoordFormatNV (GLenum type, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFogCoordFormatNV(GLenum type, GLsizei stride);
        private static TglFogCoordFormatNV glFogCoordFormatNV = null;

        // GLAPI void APIENTRY glVertexAttribFormatNV (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribFormatNV(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride);
        private static TglVertexAttribFormatNV glVertexAttribFormatNV = null;

        // GLAPI void APIENTRY glVertexAttribIFormatNV (GLuint index, GLint size, GLenum type, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribIFormatNV(GLuint index, GLint size, GLenum type, GLsizei stride);
        private static TglVertexAttribIFormatNV glVertexAttribIFormatNV = null;

        // GLAPI void APIENTRY glGetIntegerui64i_vNV (GLenum value, GLuint index, GLuint64EXT *result);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetIntegerui64i_vNV(GLenum value, GLuint index, GLuint64* result);
        private static TglGetIntegerui64i_vNV glGetIntegerui64i_vNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_barrier
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTextureBarrierNV (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureBarrierNV();
        private static TglTextureBarrierNV glTextureBarrierNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_gpu_program5
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glProgramSubroutineParametersuivNV (GLenum target, GLsizei count, const GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramSubroutineParametersuivNV(GLenum target, GLsizei count, GLuint* parameters);
        private static TglProgramSubroutineParametersuivNV glProgramSubroutineParametersuivNV = null;

        // GLAPI void APIENTRY glGetProgramSubroutineParameteruivNV (GLenum target, GLuint index, GLuint *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramSubroutineParameteruivNV(GLenum target, GLuint index, GLuint* parameters);
        private static TglGetProgramSubroutineParameteruivNV glGetProgramSubroutineParameteruivNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_gpu_shader5 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL1i64NV(GLuint index, GLint64 x);
        private static TglVertexAttribL1i64NV glVertexAttribL1i64NV = null;

        // GLAPI void APIENTRY glVertexAttribL2i64NV (GLuint index, GLint64EXT x, GLint64EXT y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL2i64NV(GLuint index, GLint64 x, GLint64 y);
        private static TglVertexAttribL2i64NV glVertexAttribL2i64NV = null;

        // GLAPI void APIENTRY glVertexAttribL3i64NV (GLuint index, GLint64EXT x, GLint64EXT y, GLint64EXT z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL3i64NV(GLuint index, GLint64 x, GLint64 y, GLint64 z);
        private static TglVertexAttribL3i64NV glVertexAttribL3i64NV = null;

        // GLAPI void APIENTRY glVertexAttribL4i64NV (GLuint index, GLint64EXT x, GLint64EXT y, GLint64EXT z, GLint64EXT w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL4i64NV(GLuint index, GLint64 x, GLint64 y, GLint64 z, GLint64 w);
        private static TglVertexAttribL4i64NV glVertexAttribL4i64NV = null;

        // GLAPI void APIENTRY glVertexAttribL1i64vNV (GLuint index, const GLint64EXT *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL1i64vNV(GLuint index, GLint64* v);
        private static TglVertexAttribL1i64vNV glVertexAttribL1i64vNV = null;

        // GLAPI void APIENTRY glVertexAttribL2i64vNV (GLuint index, const GLint64EXT *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL2i64vNV(GLuint index, GLint64* v);
        private static TglVertexAttribL2i64vNV glVertexAttribL2i64vNV = null;

        // GLAPI void APIENTRY glVertexAttribL3i64vNV (GLuint index, const GLint64EXT *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL3i64vNV(GLuint index, GLint64* v);
        private static TglVertexAttribL3i64vNV glVertexAttribL3i64vNV = null;

        // GLAPI void APIENTRY glVertexAttribL4i64vNV (GLuint index, const GLint64EXT *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL4i64vNV(GLuint index, GLint64* v);
        private static TglVertexAttribL4i64vNV glVertexAttribL4i64vNV = null;

        // GLAPI void APIENTRY glVertexAttribL1ui64NV (GLuint index, GLuint64EXT x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL1ui64NV(GLuint index, GLuint64 x);
        private static TglVertexAttribL1ui64NV glVertexAttribL1ui64NV = null;

        // GLAPI void APIENTRY glVertexAttribL2ui64NV (GLuint index, GLuint64EXT x, GLuint64EXT y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL2ui64NV(GLuint index, GLuint64 x, GLuint64 y);
        private static TglVertexAttribL2ui64NV glVertexAttribL2ui64NV = null;

        // GLAPI void APIENTRY glVertexAttribL3ui64NV (GLuint index, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL3ui64NV(GLuint index, GLuint64 x, GLuint64 y, GLuint64 z);
        private static TglVertexAttribL3ui64NV glVertexAttribL3ui64NV = null;

        // GLAPI void APIENTRY glVertexAttribL4ui64NV (GLuint index, GLuint64EXT x, GLuint64EXT y, GLuint64EXT z, GLuint64EXT w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL4ui64NV(GLuint index, GLuint64 x, GLuint64 y, GLuint64 z, GLuint64 w);
        private static TglVertexAttribL4ui64NV glVertexAttribL4ui64NV = null;

        // GLAPI void APIENTRY glVertexAttribL1ui64vNV (GLuint index, const GLuint64EXT *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL1ui64vNV(GLuint index, GLuint64* v);
        private static TglVertexAttribL1ui64vNV glVertexAttribL1ui64vNV = null;

        // GLAPI void APIENTRY glVertexAttribL2ui64vNV (GLuint index, const GLuint64EXT *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL2ui64vNV(GLuint index, GLuint64* v);
        private static TglVertexAttribL2ui64vNV glVertexAttribL2ui64vNV = null;

        // GLAPI void APIENTRY glVertexAttribL3ui64vNV (GLuint index, const GLuint64EXT *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL3ui64vNV(GLuint index, GLuint64* v);
        private static TglVertexAttribL3ui64vNV glVertexAttribL3ui64vNV = null;

        // GLAPI void APIENTRY glVertexAttribL4ui64vNV (GLuint index, const GLuint64EXT *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL4ui64vNV(GLuint index, GLuint64* v);
        private static TglVertexAttribL4ui64vNV glVertexAttribL4ui64vNV = null;

        // GLAPI void APIENTRY glGetVertexAttribLi64vNV (GLuint index, GLenum pname, GLint64EXT *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribLi64vNV(GLuint index, GLenum pname, GLint64* parameters);
        private static TglGetVertexAttribLi64vNV glGetVertexAttribLi64vNV = null;

        // GLAPI void APIENTRY glGetVertexAttribLui64vNV (GLuint index, GLenum pname, GLuint64EXT *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribLui64vNV(GLuint index, GLenum pname, GLuint64* parameters);
        private static TglGetVertexAttribLui64vNV glGetVertexAttribLui64vNV = null;

        // GLAPI void APIENTRY glVertexAttribLFormatNV (GLuint index, GLint size, GLenum type, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribLFormatNV(GLuint index, GLint size, GLenum type, GLsizei stride);
        private static TglVertexAttribLFormatNV glVertexAttribLFormatNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_multisample_coverage (no function entry point)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vdpau_interop
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glVDPAUInitNV (const GLvoid *vdpDevice, const GLvoid *getProcAddress);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVDPAUInitNV(void* vdpDevice, void* getProcAddress);
        private static TglVDPAUInitNV glVDPAUInitNV = null;

        // GLAPI void APIENTRY glVDPAUFiniNV (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVDPAUFiniNV();
        private static TglVDPAUFiniNV glVDPAUFiniNV = null;

        // GLAPI GLvdpauSurfaceNV APIENTRY glVDPAURegisterVideoSurfaceNV (GLvoid *vdpSurface, GLenum target, GLsizei numTextureNames, const GLuint *textureNames);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLvdpauSurface TglVDPAURegisterVideoSurfaceNV(void* vdpSurface, GLenum target, GLsizei numTextureNames, GLuint* textureNames);
        private static TglVDPAURegisterVideoSurfaceNV glVDPAURegisterVideoSurfaceNV = null;

        // GLAPI GLvdpauSurfaceNV APIENTRY glVDPAURegisterOutputSurfaceNV (GLvoid *vdpSurface, GLenum target, GLsizei numTextureNames, const GLuint *textureNames);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLvdpauSurface TglVDPAURegisterOutputSurfaceNV(void* vdpSurface, GLenum target, GLsizei numTextureNames, GLuint* textureNames);
        private static TglVDPAURegisterOutputSurfaceNV glVDPAURegisterOutputSurfaceNV = null;

        // GLAPI void APIENTRY glVDPAUIsSurfaceNV (GLvdpauSurfaceNV surface);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVDPAUIsSurfaceNV(GLvdpauSurface surface);
        private static TglVDPAUIsSurfaceNV glVDPAUIsSurfaceNV = null;

        // GLAPI void APIENTRY glVDPAUUnregisterSurfaceNV (GLvdpauSurfaceNV surface);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVDPAUUnregisterSurfaceNV(GLvdpauSurface surface);
        private static TglVDPAUUnregisterSurfaceNV glVDPAUUnregisterSurfaceNV = null;

        // GLAPI void APIENTRY glVDPAUGetSurfaceivNV (GLvdpauSurfaceNV surface, GLenum pname, GLsizei bufSize, GLsizei *length, GLint *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVDPAUGetSurfaceivNV(GLvdpauSurface surface, GLenum pname, GLsizei bufSize, GLsizei* length, GLint* values);
        private static TglVDPAUGetSurfaceivNV glVDPAUGetSurfaceivNV = null;

        // GLAPI void APIENTRY glVDPAUSurfaceAccessNV (GLvdpauSurfaceNV surface, GLenum access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVDPAUSurfaceAccessNV(GLvdpauSurface surface, GLenum access);
        private static TglVDPAUSurfaceAccessNV glVDPAUSurfaceAccessNV = null;

        // GLAPI void APIENTRY glVDPAUMapSurfacesNV (GLsizei numSurfaces, const GLvdpauSurfaceNV *surfaces);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVDPAUMapSurfacesNV(GLsizei numSurfaces, GLvdpauSurface* surfaces);
        private static TglVDPAUMapSurfacesNV glVDPAUMapSurfacesNV = null;

        // GLAPI void APIENTRY glVDPAUUnmapSurfacesNV (GLsizei numSurface, const GLvdpauSurfaceNV *surfaces);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVDPAUUnmapSurfacesNV(GLsizei numSurface, GLvdpauSurface* surfaces);
        private static TglVDPAUUnmapSurfacesNV glVDPAUUnmapSurfacesNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_multisample
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexImage2DMultisampleCoverageNV (GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexImage2DMultisampleCoverageNV(GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations);
        private static TglTexImage2DMultisampleCoverageNV glTexImage2DMultisampleCoverageNV = null;

        // GLAPI void APIENTRY glTexImage3DMultisampleCoverageNV (GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexImage3DMultisampleCoverageNV(GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations);
        private static TglTexImage3DMultisampleCoverageNV glTexImage3DMultisampleCoverageNV = null;

        // GLAPI void APIENTRY glTextureImage2DMultisampleNV (GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureImage2DMultisampleNV(GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations);
        private static TglTextureImage2DMultisampleNV glTextureImage2DMultisampleNV = null;

        // GLAPI void APIENTRY glTextureImage3DMultisampleNV (GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureImage3DMultisampleNV(GLuint texture, GLenum target, GLsizei samples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations);
        private static TglTextureImage3DMultisampleNV glTextureImage3DMultisampleNV = null;

        // GLAPI void APIENTRY glTextureImage2DMultisampleCoverageNV (GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureImage2DMultisampleCoverageNV(GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLboolean fixedSampleLocations);
        private static TglTextureImage2DMultisampleCoverageNV glTextureImage2DMultisampleCoverageNV = null;

        // GLAPI void APIENTRY glTextureImage3DMultisampleCoverageNV (GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureImage3DMultisampleCoverageNV(GLuint texture, GLenum target, GLsizei coverageSamples, GLsizei colorSamples, GLint internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedSampleLocations);
        private static TglTextureImage3DMultisampleCoverageNV glTextureImage3DMultisampleCoverageNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_path_rendering
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLuint APIENTRY glGenPathsNV (GLsizei range);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglGenPathsNV(GLsizei range);
        private static TglGenPathsNV glGenPathsNV = null;

        // GLAPI void APIENTRY glDeletePathsNV (GLuint path, GLsizei range);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDeletePathsNV(GLuint path, GLsizei range);
        private static TglDeletePathsNV glDeletePathsNV = null;

        // GLAPI GLboolean APIENTRY glIsPathNV (GLuint path);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsPathNV(GLuint path);
        private static TglIsPathNV glIsPathNV = null;

        // GLAPI void APIENTRY glPathCommandsNV (GLuint path, GLsizei numCommands, const GLubyte *commands, GLsizei numCoords, GLenum coordType, const GLvoid *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPathCommandsNV(GLuint path, GLsizei numCommands, GLubyte* commands, GLsizei numCoords, GLenum coordType, void* coords);
        private static TglPathCommandsNV glPathCommandsNV = null;

        // GLAPI void APIENTRY glPathCoordsNV (GLuint path, GLsizei numCoords, GLenum coordType, const GLvoid *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPathCoordsNV(GLuint path, GLsizei numCoords, GLenum coordType, void* coords);
        private static TglPathCoordsNV glPathCoordsNV = null;

        // GLAPI void APIENTRY glPathSubCommandsNV (GLuint path, GLsizei commandStart, GLsizei commandsToDelete, GLsizei numCommands, const GLubyte *commands, GLsizei numCoords, GLenum coordType, const GLvoid *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPathSubCommandsNV(GLuint path, GLsizei commandStart, GLsizei commandsToDelete, GLsizei numCommands, GLubyte* commands, GLsizei numCoords, GLenum coordType, void* coords);
        private static TglPathSubCommandsNV glPathSubCommandsNV = null;

        // GLAPI void APIENTRY glPathSubCoordsNV (GLuint path, GLsizei coordStart, GLsizei numCoords, GLenum coordType, const GLvoid *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPathSubCoordsNV(GLuint path, GLsizei coordStart, GLsizei numCoords, GLenum coordType, void* coords);
        private static TglPathSubCoordsNV glPathSubCoordsNV = null;

        // GLAPI void APIENTRY glPathStringNV (GLuint path, GLenum format, GLsizei length, const GLvoid *pathString);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPathStringNV(GLuint path, GLenum format, GLsizei length, void* pathString);
        private static TglPathStringNV glPathStringNV = null;

        // GLAPI void APIENTRY glPathGlyphsNV (GLuint firstPathName, GLenum fontTarget, const GLvoid *fontName, GLbitfield fontStyle, GLsizei numGlyphs, GLenum type, const GLvoid *charcodes, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPathGlyphsNV(GLuint firstPathName, GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLsizei numGlyphs, GLenum type, void* charcodes, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale);
        private static TglPathGlyphsNV glPathGlyphsNV = null;

        // GLAPI void APIENTRY glPathGlyphRangeNV (GLuint firstPathName, GLenum fontTarget, const GLvoid *fontName, GLbitfield fontStyle, GLuint firstGlyph, GLsizei numGlyphs, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPathGlyphRangeNV(GLuint firstPathName, GLenum fontTarget, void* fontName, GLbitfield fontStyle, GLuint firstGlyph, GLsizei numGlyphs, GLenum handleMissingGlyphs, GLuint pathParameterTemplate, GLfloat emScale);
        private static TglPathGlyphRangeNV glPathGlyphRangeNV = null;

        // GLAPI void APIENTRY glWeightPathsNV (GLuint resultPath, GLsizei numPaths, const GLuint *paths, const GLfloat *weights);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWeightPathsNV(GLuint resultPath, GLsizei numPaths, GLuint* paths, GLfloat* weights);
        private static TglWeightPathsNV glWeightPathsNV = null;

        // GLAPI void APIENTRY glCopyPathNV (GLuint resultPath, GLuint srcPath);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyPathNV(GLuint resultPath, GLuint srcPath);
        private static TglCopyPathNV glCopyPathNV = null;

        // GLAPI void APIENTRY glInterpolatePathsNV (GLuint resultPath, GLuint pathA, GLuint pathB, GLfloat weight);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglInterpolatePathsNV(GLuint resultPath, GLuint pathA, GLuint pathB, GLfloat weight);
        private static TglInterpolatePathsNV glInterpolatePathsNV = null;

        // GLAPI void APIENTRY glTransformPathNV (GLuint resultPath, GLuint srcPath, GLenum transformType, const GLfloat *transformValues);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTransformPathNV(GLuint resultPath, GLuint srcPath, GLenum transformType, GLfloat* transformValues);
        private static TglTransformPathNV glTransformPathNV = null;

        // GLAPI void APIENTRY glPathParameterivNV (GLuint path, GLenum pname, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPathParameterivNV(GLuint path, GLenum pname, GLint* value);
        private static TglPathParameterivNV glPathParameterivNV = null;

        // GLAPI void APIENTRY glPathParameteriNV (GLuint path, GLenum pname, GLint value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPathParameteriNV(GLuint path, GLenum pname, GLint value);
        private static TglPathParameteriNV glPathParameteriNV = null;

        // GLAPI void APIENTRY glPathParameterfvNV (GLuint path, GLenum pname, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPathParameterfvNV(GLuint path, GLenum pname, GLfloat* value);
        private static TglPathParameterfvNV glPathParameterfvNV = null;

        // GLAPI void APIENTRY glPathParameterfNV (GLuint path, GLenum pname, GLfloat value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPathParameterfNV(GLuint path, GLenum pname, GLfloat value);
        private static TglPathParameterfNV glPathParameterfNV = null;

        // GLAPI void APIENTRY glPathDashArrayNV (GLuint path, GLsizei dashCount, const GLfloat *dashArray);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPathDashArrayNV(GLuint path, GLsizei dashCount, GLfloat* dashArray);
        private static TglPathDashArrayNV glPathDashArrayNV = null;

        // GLAPI void APIENTRY glPathStencilFuncNV (GLenum func, GLint ref, GLuint mask);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPathStencilFuncNV(GLenum func, GLint reference, GLuint mask);
        private static TglPathStencilFuncNV glPathStencilFuncNV = null;

        // GLAPI void APIENTRY glPathStencilDepthOffsetNV (GLfloat factor, GLfloat units);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPathStencilDepthOffsetNV(GLfloat factor, GLfloat units);
        private static TglPathStencilDepthOffsetNV glPathStencilDepthOffsetNV = null;

        // GLAPI void APIENTRY glStencilFillPathNV (GLuint path, GLenum fillMode, GLuint mask);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStencilFillPathNV(GLuint path, GLenum fillMode, GLuint mask);
        private static TglStencilFillPathNV glStencilFillPathNV = null;

        // GLAPI void APIENTRY glStencilStrokePathNV (GLuint path, GLint reference, GLuint mask);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStencilStrokePathNV(GLuint path, GLint reference, GLuint mask);
        private static TglStencilStrokePathNV glStencilStrokePathNV = null;

        // GLAPI void APIENTRY glStencilFillPathInstancedNV (GLsizei numPaths, GLenum pathNameType, const GLvoid *paths, GLuint pathBase, GLenum fillMode, GLuint mask, GLenum transformType, const GLfloat *transformValues);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglStencilFillPathInstancedNV(GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum fillMode, GLuint mask, GLenum transformType, GLfloat* transformValues);
        private static TglStencilFillPathInstancedNV glStencilFillPathInstancedNV = null;

        // GLAPI void APIENTRY glStencilStrokePathInstancedNV (GLsizei numPaths, GLenum pathNameType, const GLvoid *paths, GLuint pathBase, GLint reference, GLuint mask, GLenum transformType, const GLfloat *transformValues);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglStencilStrokePathInstancedNV(GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLint reference, GLuint mask, GLenum transformType, GLfloat* transformValues);
        private static TglStencilStrokePathInstancedNV glStencilStrokePathInstancedNV = null;

        // GLAPI void APIENTRY glPathCoverDepthFuncNV (GLenum func);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPathCoverDepthFuncNV(GLenum func);
        private static TglPathCoverDepthFuncNV glPathCoverDepthFuncNV = null;

        // GLAPI void APIENTRY glPathColorGenNV (GLenum color, GLenum genMode, GLenum colorFormat, const GLfloat *coeffs);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPathColorGenNV(GLenum color, GLenum genMode, GLenum colorFormat, GLfloat* coeffs);
        private static TglPathColorGenNV glPathColorGenNV = null;

        // GLAPI void APIENTRY glPathTexGenNV (GLenum texCoordSet, GLenum genMode, GLint components, const GLfloat *coeffs);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPathTexGenNV(GLenum texCoordSet, GLenum genMode, GLint components, GLfloat* coeffs);
        private static TglPathTexGenNV glPathTexGenNV = null;

        // GLAPI void APIENTRY glPathFogGenNV (GLenum genMode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPathFogGenNV(GLenum genMode);
        private static TglPathFogGenNV glPathFogGenNV = null;

        // GLAPI void APIENTRY glCoverFillPathNV (GLuint path, GLenum coverMode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCoverFillPathNV(GLuint path, GLenum coverMode);
        private static TglCoverFillPathNV glCoverFillPathNV = null;

        // GLAPI void APIENTRY glCoverStrokePathNV (GLuint path, GLenum coverMode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCoverStrokePathNV(GLuint path, GLenum coverMode);
        private static TglCoverStrokePathNV glCoverStrokePathNV = null;

        // GLAPI void APIENTRY glCoverFillPathInstancedNV (GLsizei numPaths, GLenum pathNameType, const GLvoid *paths, GLuint pathBase, GLenum coverMode, GLenum transformType, const GLfloat *transformValues);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCoverFillPathInstancedNV(GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum coverMode, GLenum transformType, GLfloat* transformValues);
        private static TglCoverFillPathInstancedNV glCoverFillPathInstancedNV = null;

        // GLAPI void APIENTRY glCoverStrokePathInstancedNV (GLsizei numPaths, GLenum pathNameType, const GLvoid *paths, GLuint pathBase, GLenum coverMode, GLenum transformType, const GLfloat *transformValues);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCoverStrokePathInstancedNV(GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLenum coverMode, GLenum transformType, GLfloat* transformValues);
        private static TglCoverStrokePathInstancedNV glCoverStrokePathInstancedNV = null;

        // GLAPI void APIENTRY glGetPathParameterivNV (GLuint path, GLenum pname, GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPathParameterivNV(GLuint path, GLenum pname, GLint* value);
        private static TglGetPathParameterivNV glGetPathParameterivNV = null;

        // GLAPI void APIENTRY glGetPathParameterfvNV (GLuint path, GLenum pname, GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPathParameterfvNV(GLuint path, GLenum pname, GLfloat* value);
        private static TglGetPathParameterfvNV glGetPathParameterfvNV = null;

        // GLAPI void APIENTRY glGetPathCommandsNV (GLuint path, GLubyte *commands);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPathCommandsNV(GLuint path, GLubyte* commands);
        private static TglGetPathCommandsNV glGetPathCommandsNV = null;

        // GLAPI void APIENTRY glGetPathCoordsNV (GLuint path, GLfloat *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPathCoordsNV(GLuint path, GLfloat* coords);
        private static TglGetPathCoordsNV glGetPathCoordsNV = null;

        // GLAPI void APIENTRY glGetPathDashArrayNV (GLuint path, GLfloat *dashArray);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPathDashArrayNV(GLuint path, GLfloat* dashArray);
        private static TglGetPathDashArrayNV glGetPathDashArrayNV = null;

        // GLAPI void APIENTRY glGetPathMetricsNV (GLbitfield metricQueryMask, GLsizei numPaths, GLenum pathNameType, const GLvoid *paths, GLuint pathBase, GLsizei stride, GLfloat *metrics);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPathMetricsNV(GLbitfield metricQueryMask, GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLsizei stride, GLfloat* metrics);
        private static TglGetPathMetricsNV glGetPathMetricsNV = null;

        // GLAPI void APIENTRY glGetPathMetricRangeNV (GLbitfield metricQueryMask, GLuint firstPathName, GLsizei numPaths, GLsizei stride, GLfloat *metrics);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPathMetricRangeNV(GLbitfield metricQueryMask, GLuint firstPathName, GLsizei numPaths, GLsizei stride, GLfloat* metrics);
        private static TglGetPathMetricRangeNV glGetPathMetricRangeNV = null;

        // GLAPI void APIENTRY glGetPathSpacingNV (GLenum pathListMode, GLsizei numPaths, GLenum pathNameType, const GLvoid *paths, GLuint pathBase, GLfloat advanceScale, GLfloat kerningScale, GLenum transformType, GLfloat *returnedSpacing);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPathSpacingNV(GLenum pathListMode, GLsizei numPaths, GLenum pathNameType, void* paths, GLuint pathBase, GLfloat advanceScale, GLfloat kerningScale, GLenum transformType, GLfloat* returnedSpacing);
        private static TglGetPathSpacingNV glGetPathSpacingNV = null;

        // GLAPI void APIENTRY glGetPathColorGenivNV (GLenum color, GLenum pname, GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPathColorGenivNV(GLenum color, GLenum pname, GLint* value);
        private static TglGetPathColorGenivNV glGetPathColorGenivNV = null;

        // GLAPI void APIENTRY glGetPathColorGenfvNV (GLenum color, GLenum pname, GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPathColorGenfvNV(GLenum color, GLenum pname, GLfloat* value);
        private static TglGetPathColorGenfvNV glGetPathColorGenfvNV = null;

        // GLAPI void APIENTRY glGetPathTexGenivNV (GLenum texCoordSet, GLenum pname, GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPathTexGenivNV(GLenum texCoordSet, GLenum pname, GLint* value);
        private static TglGetPathTexGenivNV glGetPathTexGenivNV = null;

        // GLAPI void APIENTRY glGetPathTexGenfvNV (GLenum texCoordSet, GLenum pname, GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPathTexGenfvNV(GLenum texCoordSet, GLenum pname, GLfloat* value);
        private static TglGetPathTexGenfvNV glGetPathTexGenfvNV = null;

        // GLAPI GLboolean APIENTRY glIsPointInFillPathNV (GLuint path, GLuint mask, GLfloat x, GLfloat y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsPointInFillPathNV(GLuint path, GLuint mask, GLfloat x, GLfloat y);
        private static TglIsPointInFillPathNV glIsPointInFillPathNV = null;

        // GLAPI GLboolean APIENTRY glIsPointInStrokePathNV (GLuint path, GLfloat x, GLfloat y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsPointInStrokePathNV(GLuint path, GLfloat x, GLfloat y);
        private static TglIsPointInStrokePathNV glIsPointInStrokePathNV = null;

        // GLAPI GLfloat APIENTRY glGetPathLengthNV (GLuint path, GLsizei startSegment, GLsizei numSegments);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLfloat TglGetPathLengthNV(GLuint path, GLsizei startSegment, GLsizei numSegments);
        private static TglGetPathLengthNV glGetPathLengthNV = null;

        // GLAPI GLboolean APIENTRY glPointAlongPathNV (GLuint path, GLsizei startSegment, GLsizei numSegments, GLfloat distance, GLfloat *x, GLfloat *y, GLfloat *tangentX, GLfloat *tangentY);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLboolean TglPointAlongPathNV(GLuint path, GLsizei startSegment, GLsizei numSegments, GLfloat distance, GLfloat* x, GLfloat* y, GLfloat* tangentX, GLfloat* tangentY);
        private static TglPointAlongPathNV glPointAlongPathNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_bindless_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLuint64 APIENTRY glGetTextureHandleNV (GLuint texture);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint64 TglGetTextureHandleNV(GLuint texture);
        private static TglGetTextureHandleNV glGetTextureHandleNV = null;

        // GLAPI GLuint64 APIENTRY glGetTextureSamplerHandleNV (GLuint texture, GLuint sampler);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint64 TglGetTextureSamplerHandleNV(GLuint texture, GLuint sampler);
        private static TglGetTextureSamplerHandleNV glGetTextureSamplerHandleNV = null;

        // GLAPI void APIENTRY glMakeTextureHandleResidentNV (GLuint64 handle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMakeTextureHandleResidentNV(GLuint64 handle);
        private static TglMakeTextureHandleResidentNV glMakeTextureHandleResidentNV = null;

        // GLAPI void APIENTRY glMakeTextureHandleNonResidentNV (GLuint64 handle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMakeTextureHandleNonResidentNV(GLuint64 handle);
        private static TglMakeTextureHandleNonResidentNV glMakeTextureHandleNonResidentNV = null;

        // GLAPI GLuint64 APIENTRY glGetImageHandleNV (GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint64 TglGetImageHandleNV(GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum format);
        private static TglGetImageHandleNV glGetImageHandleNV = null;

        // GLAPI void APIENTRY glMakeImageHandleResidentNV (GLuint64 handle, GLenum access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMakeImageHandleResidentNV(GLuint64 handle, GLenum access);
        private static TglMakeImageHandleResidentNV glMakeImageHandleResidentNV = null;

        // GLAPI void APIENTRY glMakeImageHandleNonResidentNV (GLuint64 handle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMakeImageHandleNonResidentNV(GLuint64 handle);
        private static TglMakeImageHandleNonResidentNV glMakeImageHandleNonResidentNV = null;

        // GLAPI void APIENTRY glUniformHandleui64NV (GLint location, GLuint64 value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniformHandleui64NV(GLint location, GLuint64 value);
        private static TglUniformHandleui64NV glUniformHandleui64NV = null;

        // GLAPI void APIENTRY glUniformHandleui64vNV (GLint location, GLsizei count, const GLuint64 *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformHandleui64vNV(GLint location, GLsizei count, GLuint64* value);
        private static TglUniformHandleui64vNV glUniformHandleui64vNV = null;

        // GLAPI void APIENTRY glProgramUniformHandleui64NV (GLuint program, GLint location, GLuint64 value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniformHandleui64NV(GLuint program, GLint location, GLuint64 value);
        private static TglProgramUniformHandleui64NV glProgramUniformHandleui64NV = null;

        // GLAPI void APIENTRY glProgramUniformHandleui64vNV (GLuint program, GLint location, GLsizei count, const GLuint64 *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformHandleui64vNV(GLuint program, GLint location, GLsizei count, GLuint64* values);
        private static TglProgramUniformHandleui64vNV glProgramUniformHandleui64vNV = null;

        // GLAPI GLboolean APIENTRY glIsTextureHandleResidentNV (GLuint64 handle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsTextureHandleResidentNV(GLuint64 handle);
        private static TglIsTextureHandleResidentNV glIsTextureHandleResidentNV = null;

        // GLAPI GLboolean APIENTRY glIsImageHandleResidentNV (GLuint64 handle);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsImageHandleResidentNV(GLuint64 handle);
        private static TglIsImageHandleResidentNV glIsImageHandleResidentNV = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawArraysIndirectBindlessNV(GLenum mode, void* indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount);
        private static TglMultiDrawArraysIndirectBindlessNV glMultiDrawArraysIndirectBindlessNV = null;

        // GLAPI void APIENTRY glMultiDrawElementsIndirectBindlessNV (GLenum mode, GLenum type, const void *indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawElementsIndirectBindlessNV(GLenum mode, GLenum type, void* indirect, GLsizei drawCount, GLsizei stride, GLint vertexBufferCount);
        private static TglMultiDrawElementsIndirectBindlessNV glMultiDrawElementsIndirectBindlessNV = null;
        
        ///////////////////////////////////////////////////////////////////////
        // GL_NV_blend_equation_advanced
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBlendParameteriNV (GLenum pname, GLint value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendParameteriNV(GLenum pname, GLint value);
        private static TglBlendParameteriNV glBlendParameteriNV = null;

        // GLAPI void APIENTRY glBlendBarrierNV (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendBarrierNV();
        private static TglBlendBarrierNV glBlendBarrierNV = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawTextureNV(GLuint texture, GLuint sampler, GLfloat x0, GLfloat y0, GLfloat x1, GLfloat y1, GLfloat z, GLfloat s0, GLfloat t0, GLfloat s1, GLfloat t1);
        private static TglDrawTextureNV glDrawTextureNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_gpu_program_fp64 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
		// GL_NV_bindless_multi_draw_indirect_count
        ///////////////////////////////////////////////////////////////////////
		// GLAPI void APIENTRY glMultiDrawArraysIndirectBindlessCountNV (GLenum mode, const void *indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawArraysIndirectBindlessCountNV(GLenum mode, void* indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount);
		private static TglMultiDrawArraysIndirectBindlessCountNV glMultiDrawArraysIndirectBindlessCountNV = null;
		
		// GLAPI void APIENTRY glMultiDrawElementsIndirectBindlessCountNV (GLenum mode, GLenum type, const void *indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawElementsIndirectBindlessCountNV(GLenum mode, GLenum type, void* indirect, GLsizei drawCount, GLsizei maxDrawCount, GLsizei stride, GLint vertexBufferCount);
		private static TglMultiDrawElementsIndirectBindlessCountNV glMultiDrawElementsIndirectBindlessCountNV = null;

		///////////////////////////////////////////////////////////////////////
		// GL_NV_command_list
		///////////////////////////////////////////////////////////////////////
		// GLAPI void APIENTRY glCreateStatesNV (GLsizei n, GLuint *states);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCreateStatesNV(GLsizei n, GLuint* states);
		private static TglCreateStatesNV glCreateStatesNV = null;
		
		// GLAPI void APIENTRY glDeleteStatesNV (GLsizei n, const GLuint *states);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteStatesNV(GLsizei n, GLuint* states);
		private static TglDeleteStatesNV glDeleteStatesNV = null;
		
		// GLAPI GLboolean APIENTRY glIsStateNV (GLuint state);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsStateNV(GLuint state);
		private static TglIsStateNV glIsStateNV = null;
		
		// GLAPI void APIENTRY glStateCaptureNV (GLuint state, GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStateCaptureNV(GLuint state, GLenum mode);
		private static TglStateCaptureNV glStateCaptureNV = null;
		
		// GLAPI GLuint APIENTRY glGetCommandHeaderNV (GLenum tokenID, GLuint size);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglGetCommandHeaderNV(GLenum tokenID, GLuint size);
		private static TglGetCommandHeaderNV glGetCommandHeaderNV = null;
		
		// GLAPI GLushort APIENTRY glGetStageIndexNV (GLenum shadertype);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLushort TglGetStageIndexNV(GLenum shadertype);
		private static TglGetStageIndexNV glGetStageIndexNV = null;
		
		// GLAPI void APIENTRY glDrawCommandsNV (GLenum primitiveMode, GLuint buffer, const GLintptr *indirects, const GLsizei *sizes, GLuint count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawCommandsNV(GLenum primitiveMode, GLuint buffer, GLintptr* indirects, GLsizei* sizes, GLuint count);
		private static TglDrawCommandsNV glDrawCommandsNV = null;
		
		// GLAPI void APIENTRY glDrawCommandsAddressNV (GLenum primitiveMode, const GLuint64 *indirects, const GLsizei *sizes, GLuint count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawCommandsAddressNV(GLenum primitiveMode, GLuint64* indirects, GLsizei* sizes, GLuint count);
		private static TglDrawCommandsAddressNV glDrawCommandsAddressNV = null;
		
		// GLAPI void APIENTRY glDrawCommandsStatesNV (GLuint buffer, const GLintptr *indirects, const GLsizei *sizes, const GLuint *states, const GLuint *fbos, GLuint count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawCommandsStatesNV(GLuint buffer, GLintptr* indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count);
		private static TglDrawCommandsStatesNV glDrawCommandsStatesNV = null;
		
		// GLAPI void APIENTRY glDrawCommandsStatesAddressNV (const GLuint64 *indirects, const GLsizei *sizes, const GLuint *states, const GLuint *fbos, GLuint count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawCommandsStatesAddressNV(GLuint64* indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count);
		private static TglDrawCommandsStatesAddressNV glDrawCommandsStatesAddressNV = null;
		
		// GLAPI void APIENTRY glCreateCommandListsNV (GLsizei n, GLuint *lists);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCreateCommandListsNV(GLsizei n, GLuint* lists);
		private static TglCreateCommandListsNV glCreateCommandListsNV = null;
		
		// GLAPI void APIENTRY glDeleteCommandListsNV (GLsizei n, const GLuint *lists);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteCommandListsNV (GLsizei n, GLuint* lists);
		private static TglDeleteCommandListsNV glDeleteCommandListsNV = null;
		
		// GLAPI GLboolean APIENTRY glIsCommandListNV (GLuint list);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsCommandListNV(GLuint list);
		private static TglIsCommandListNV glIsCommandListNV = null;
		
		// GLAPI void APIENTRY glListDrawCommandsStatesClientNV (GLuint list, GLuint segment, const void **indirects, const GLsizei *sizes, const GLuint *states, const GLuint *fbos, GLuint count);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglListDrawCommandsStatesClientNV (GLuint list, GLuint segment, void** indirects, GLsizei* sizes, GLuint* states, GLuint* fbos, GLuint count);
		private static TglListDrawCommandsStatesClientNV glListDrawCommandsStatesClientNV = null;

		// GLAPI void APIENTRY glCommandListSegmentsNV (GLuint list, GLuint segments);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCommandListSegmentsNV(GLuint list, GLuint segments);
		private static TglCommandListSegmentsNV glCommandListSegmentsNV = null;

		// GLAPI void APIENTRY glCompileCommandListNV (GLuint list);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCompileCommandListNV(GLuint list);
		private static TglCompileCommandListNV glCompileCommandListNV = null;
		
		// GLAPI void APIENTRY glCallCommandListNV (GLuint list);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCallCommandListNV(GLuint list);
		private static TglCallCommandListNV glCallCommandListNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_conservative_raster
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glSubpixelPrecisionBiasNV (GLuint xbits, GLuint ybits);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSubpixelPrecisionBiasNV(GLuint xbits, GLuint ybits);
        private static TglSubpixelPrecisionBiasNV glSubpixelPrecisionBiasNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_conservative_raster_dilate
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glConservativeRasterParameterfNV (GLenum pname, GLfloat value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglConservativeRasterParameterfNV(GLenum pname, GLfloat value);
        private static TglConservativeRasterParameterfNV glConservativeRasterParameterfNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fill_rectangle (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fragment_coverage_to_color
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFragmentCoverageColorNV (GLuint color);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFragmentCoverageColorNV(GLuint color);
        private static TglFragmentCoverageColorNV glFragmentCoverageColorNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fragment_shader_interlock (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_framebuffer_mixed_samples
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glCoverageModulationTableNV(GLsizei n, const GLfloat* v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCoverageModulationTableNV(GLsizei n, GLfloat* v);
        private static TglCoverageModulationTableNV glCoverageModulationTableNV = null;

        // GLAPI void APIENTRY glGetCoverageModulationTableNV(GLsizei bufsize, GLfloat* v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetCoverageModulationTableNV(GLsizei bufsize, GLfloat* v);
        private static TglGetCoverageModulationTableNV glGetCoverageModulationTableNV = null;

        // GLAPI void APIENTRY glCoverageModulationNV(GLenum components);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCoverageModulationNV(GLenum components);
        private static TglCoverageModulationNV glCoverageModulationNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_geometry_shader_passthrough (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_internalformat_sample_query
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetInternalformatSampleivNV (GLenum target, GLenum internalformat, GLsizei samples, GLenum pname, GLsizei bufSize, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetInternalformatSampleivNV(GLenum target, GLenum internalformat, GLsizei samples, GLenum pname, GLsizei bufSize, GLint* parameters);
        private static TglGetInternalformatSampleivNV glGetInternalformatSampleivNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_path_rendering_shared_edge (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_sample_locations
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFramebufferSampleLocationsfvNV(GLenum target, GLuint start, GLsizei count, const GLfloat* v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFramebufferSampleLocationsfvNV(GLenum target, GLuint start, GLsizei count, GLfloat* v);
        private static TglFramebufferSampleLocationsfvNV glFramebufferSampleLocationsfvNV = null;

        // GLAPI void APIENTRY glNamedFramebufferSampleLocationsfvNV(GLuint framebuffer, GLuint start, GLsizei count, const GLfloat* v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedFramebufferSampleLocationsfvNV(GLuint framebuffer, GLuint start, GLsizei count, GLfloat* v);
        private static TglNamedFramebufferSampleLocationsfvNV glNamedFramebufferSampleLocationsfvNV = null;

        // GLAPI void APIENTRY glResolveDepthValuesNV(void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglResolveDepthValuesNV();
        private static TglResolveDepthValuesNV glResolveDepthValuesNV = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_sample_mask_override_coverage (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_atomic_fp16_vector (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_atomic_int64 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_thread_group (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_thread_shuffle (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_uniform_buffer_unified_memory (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_viewport_array2 (no function entry points)
        ///////////////////////////////////////////////////////////////////////
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_NVX_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_NVX_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_NVX_gpu_memory_info (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NVX_conditional_render
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glBeginConditionalRenderNVX (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginConditionalRenderNVX(GLuint id);
        private static TglBeginConditionalRenderNVX glBeginConditionalRenderNVX = null;

        // GLAPI void APIENTRY glEndConditionalRenderNVX (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndConditionalRenderNVX();
        private static TglEndConditionalRenderNVX glEndConditionalRenderNVX = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_OES_xxx FUNCTIONS...
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLbitfield TglQueryMatrixxOES(GLfixed* mantissa, GLint* exponent);
        private static TglQueryMatrixxOES glQueryMatrixxOES = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_single_precision
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glClearDepthfOES (GLclampf depth);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearDepthfOES (GLclampf depth);
        private static TglClearDepthfOES glClearDepthfOES = null;

        // GLAPI void APIENTRY glClipPlanefOES (GLenum plane, const GLfloat *equation);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClipPlanefOES(GLenum plane, GLfloat* equation);
        private static TglClipPlanefOES glClipPlanefOES = null;

        // GLAPI void APIENTRY glDepthRangefOES (GLclampf n, GLclampf f);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDepthRangefOES(GLclampf n, GLclampf f);
        private static TglDepthRangefOES glDepthRangefOES = null;

        // GLAPI void APIENTRY glFrustumfOES (GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFrustumfOES(GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);
        private static TglFrustumfOES glFrustumfOES = null;

        // GLAPI void APIENTRY glGetClipPlanefOES (GLenum plane, GLfloat *equation);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetClipPlanefOES(GLenum plane, GLfloat* equation);
        private static TglGetClipPlanefOES glGetClipPlanefOES = null;

        // GLAPI void APIENTRY glOrthofOES (GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglOrthofOES(GLfloat l, GLfloat r, GLfloat b, GLfloat t, GLfloat n, GLfloat f);
        private static TglOrthofOES glOrthofOES = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_byte_coordinates
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMultiTexCoord1bOES (GLenum texture, GLbyte s);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord1bOES(GLenum texture, GLbyte s);
        private static TglMultiTexCoord1bOES glMultiTexCoord1bOES = null;

        // GLAPI void APIENTRY glMultiTexCoord1bvOES (GLenum texture, const GLbyte *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord1bvOES(GLenum texture, GLbyte* coords);
        private static TglMultiTexCoord1bvOES glMultiTexCoord1bvOES = null;

        // GLAPI void APIENTRY glMultiTexCoord2bOES (GLenum texture, GLbyte s, GLbyte t);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord2bOES(GLenum texture, GLbyte s, GLbyte t);
        private static TglMultiTexCoord2bOES glMultiTexCoord2bOES = null;

        // GLAPI void APIENTRY glMultiTexCoord2bvOES (GLenum texture, const GLbyte *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord2bvOES(GLenum texture, GLbyte* coords);
        private static TglMultiTexCoord2bvOES glMultiTexCoord2bvOES = null;

        // GLAPI void APIENTRY glMultiTexCoord3bOES (GLenum texture, GLbyte s, GLbyte t, GLbyte r);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord3bOES(GLenum texture, GLbyte s, GLbyte t, GLbyte r);
        private static TglMultiTexCoord3bOES glMultiTexCoord3bOES = null;

        // GLAPI void APIENTRY glMultiTexCoord3bvOES (GLenum texture, const GLbyte *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord3bvOES(GLenum texture, GLbyte* coords);
        private static TglMultiTexCoord3bvOES glMultiTexCoord3bvOES = null;

        // GLAPI void APIENTRY glMultiTexCoord4bOES (GLenum texture, GLbyte s, GLbyte t, GLbyte r, GLbyte q);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord4bOES(GLenum texture, GLbyte s, GLbyte t, GLbyte r, GLbyte q);
        private static TglMultiTexCoord4bOES glMultiTexCoord4bOES = null;

        // GLAPI void APIENTRY glMultiTexCoord4bvOES (GLenum texture, const GLbyte *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord4bvOES(GLenum texture, GLbyte* coords);
        private static TglMultiTexCoord4bvOES glMultiTexCoord4bvOES = null;

        // GLAPI void APIENTRY glTexCoord1bOES (GLbyte s);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord1bOES(GLbyte s);
        private static TglTexCoord1bOES glTexCoord1bOES = null;
        
        // GLAPI void APIENTRY glTexCoord1bvOES (const GLbyte *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord1bvOES(GLbyte* coords);
        private static TglTexCoord1bvOES glTexCoord1bvOES = null;
        
        // GLAPI void APIENTRY glTexCoord2bOES (GLbyte s, GLbyte t);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord2bOES(GLbyte s, GLbyte t);
        private static TglTexCoord2bOES glTexCoord2bOES = null;

        // GLAPI void APIENTRY glTexCoord2bvOES (const GLbyte *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord2bvOES(GLbyte* coords);
        private static TglTexCoord2bvOES glTexCoord2bvOES = null;

        // GLAPI void APIENTRY glTexCoord3bOES (GLbyte s, GLbyte t, GLbyte r);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord3bOES(GLbyte s, GLbyte t, GLbyte r);
        private static TglTexCoord3bOES glTexCoord3bOES = null;

        // GLAPI void APIENTRY glTexCoord3bvOES (const GLbyte *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord3bvOES(GLbyte* coords);
        private static TglTexCoord3bvOES glTexCoord3bvOES = null;

        // GLAPI void APIENTRY glTexCoord4bOES (GLbyte s, GLbyte t, GLbyte r, GLbyte q);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord4bOES(GLbyte s, GLbyte t, GLbyte r, GLbyte q);
        private static TglTexCoord4bOES glTexCoord4bOES = null;

        // GLAPI void APIENTRY glTexCoord4bvOES (const GLbyte *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord4bvOES(GLbyte* coords);
        private static TglTexCoord4bvOES glTexCoord4bvOES = null;

        // GLAPI void APIENTRY glVertex2bOES (GLbyte x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex2bOES(GLbyte x);
        private static TglVertex2bOES glVertex2bOES = null;

        // GLAPI void APIENTRY glVertex2bvOES (const GLbyte *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex2bvOES(GLbyte* coords);
        private static TglVertex2bvOES glVertex2bvOES = null;

        // GLAPI void APIENTRY glVertex3bOES (GLbyte x, GLbyte y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex3bOES(GLbyte x, GLbyte y);
        private static TglVertex3bOES glVertex3bOES = null;

        // GLAPI void APIENTRY glVertex3bvOES (const GLbyte *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex3bvOES(GLbyte* coords);
        private static TglVertex3bvOES glVertex3bvOES = null;

        // GLAPI void APIENTRY glVertex4bOES (GLbyte x, GLbyte y, GLbyte z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex4bOES(GLbyte x, GLbyte y, GLbyte z);
        private static TglVertex4bOES glVertex4bOES = null;

        // GLAPI void APIENTRY glVertex4bvOES (const GLbyte *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex4bvOES(GLbyte* coords);
        private static TglVertex4bvOES glVertex4bvOES = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_fixed_point
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glAlphaFuncxOES (GLenum func, GLfixed ref);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglAlphaFuncxOES(GLenum func, GLfixed reference);
        private static TglAlphaFuncxOES glAlphaFuncxOES = null;

        // GLAPI void APIENTRY glClearColorxOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearColorxOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
        private static TglClearColorxOES glClearColorxOES = null;

        // GLAPI void APIENTRY glClearDepthxOES (GLfixed depth);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearDepthxOES(GLfixed depth);
        private static TglClearDepthxOES glClearDepthxOES = null;

        // GLAPI void APIENTRY glClipPlanexOES (GLenum plane, const GLfixed *equation);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClipPlanexOES(GLenum plane, GLfixed* equation);
        private static TglClipPlanexOES glClipPlanexOES = null;

        // GLAPI void APIENTRY glColor4xOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor4xOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
        private static TglColor4xOES glColor4xOES = null;

        // GLAPI void APIENTRY glDepthRangexOES (GLfixed n, GLfixed f);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDepthRangexOES(GLfixed n, GLfixed f);
        private static TglDepthRangexOES glDepthRangexOES = null;

        // GLAPI void APIENTRY glFogxOES (GLenum pname, GLfixed param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFogxOES(GLenum pname, GLfixed param);
        private static TglFogxOES glFogxOES = null;

        // GLAPI void APIENTRY glFogxvOES (GLenum pname, const GLfixed *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFogxvOES(GLenum pname, GLfixed* param);
        private static TglFogxvOES glFogxvOES = null;

        // GLAPI void APIENTRY glFrustumxOES (GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFrustumxOES(GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);
        private static TglFrustumxOES glFrustumxOES = null;

        // GLAPI void APIENTRY glGetClipPlanexOES (GLenum plane, GLfixed *equation);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetClipPlanexOES(GLenum plane, GLfixed* equation);
        private static TglGetClipPlanexOES glGetClipPlanexOES = null;

        // GLAPI void APIENTRY glGetFixedvOES (GLenum pname, GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFixedvOES(GLenum pname, GLfixed* parameters);
        private static TglGetFixedvOES glGetFixedvOES = null;

        // GLAPI void APIENTRY glGetTexEnvxvOES (GLenum target, GLenum pname, GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexEnvxvOES(GLenum target, GLenum pname, GLfixed* parameters);
        private static TglGetTexEnvxvOES glGetTexEnvxvOES = null;

        // GLAPI void APIENTRY glGetTexParameterxvOES (GLenum target, GLenum pname, GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexParameterxvOES(GLenum target, GLenum pname, GLfixed* parameters);
        private static TglGetTexParameterxvOES glGetTexParameterxvOES = null;

        // GLAPI void APIENTRY glLightModelxOES (GLenum pname, GLfixed param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLightModelxOES(GLenum pname, GLfixed param);
        private static TglLightModelxOES glLightModelxOES = null;

        // GLAPI void APIENTRY glLightModelxvOES (GLenum pname, const GLfixed *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLightModelxvOES(GLenum pname, GLfixed* param);
        private static TglLightModelxvOES glLightModelxvOES = null;

        // GLAPI void APIENTRY glLightxOES (GLenum light, GLenum pname, GLfixed param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLightxOES(GLenum light, GLenum pname, GLfixed param);
        private static TglLightxOES glLightxOES = null;

        // GLAPI void APIENTRY glLightxvOES (GLenum light, GLenum pname, const GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLightxvOES(GLenum light, GLenum pname, GLfixed* parameters);
        private static TglLightxvOES glLightxvOES = null;

        // GLAPI void APIENTRY glLineWidthxOES (GLfixed width);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLineWidthxOES(GLfixed width);
        private static TglLineWidthxOES glLineWidthxOES = null;

        // GLAPI void APIENTRY glLoadMatrixxOES (const GLfixed *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLoadMatrixxOES(GLfixed* m);
        private static TglLoadMatrixxOES glLoadMatrixxOES = null;

        // GLAPI void APIENTRY glMaterialxOES (GLenum face, GLenum pname, GLfixed param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMaterialxOES(GLenum face, GLenum pname, GLfixed param);
        private static TglMaterialxOES glMaterialxOES = null;

        // GLAPI void APIENTRY glMaterialxvOES (GLenum face, GLenum pname, const GLfixed *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMaterialxvOES(GLenum face, GLenum pname, GLfixed* param);
        private static TglMaterialxvOES glMaterialxvOES = null;

        // GLAPI void APIENTRY glMultMatrixxOES (const GLfixed *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultMatrixxOES(GLfixed* m);
        private static TglMultMatrixxOES glMultMatrixxOES = null;

        // GLAPI void APIENTRY glMultiTexCoord4xOES (GLenum texture, GLfixed s, GLfixed t, GLfixed r, GLfixed q);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord4xOES(GLenum texture, GLfixed s, GLfixed t, GLfixed r, GLfixed q);
        private static TglMultiTexCoord4xOES glMultiTexCoord4xOES = null;

        // GLAPI void APIENTRY glNormal3xOES (GLfixed nx, GLfixed ny, GLfixed nz);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormal3xOES(GLfixed nx, GLfixed ny, GLfixed nz);
        private static TglNormal3xOES glNormal3xOES = null;

        // GLAPI void APIENTRY glOrthoxOES (GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglOrthoxOES(GLfixed l, GLfixed r, GLfixed b, GLfixed t, GLfixed n, GLfixed f);
        private static TglOrthoxOES glOrthoxOES = null;

        // GLAPI void APIENTRY glPointParameterxvOES (GLenum pname, const GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPointParameterxvOES(GLenum pname, GLfixed* parameters);
        private static TglPointParameterxvOES glPointParameterxvOES = null;

        // GLAPI void APIENTRY glPointSizexOES (GLfixed size);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPointSizexOES(GLfixed size);
        private static TglPointSizexOES glPointSizexOES = null;

        // GLAPI void APIENTRY glPolygonOffsetxOES (GLfixed factor, GLfixed units);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPolygonOffsetxOES(GLfixed factor, GLfixed units);
        private static TglPolygonOffsetxOES glPolygonOffsetxOES = null;

        // GLAPI void APIENTRY glRotatexOES (GLfixed angle, GLfixed x, GLfixed y, GLfixed z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRotatexOES(GLfixed angle, GLfixed x, GLfixed y, GLfixed z);
        private static TglRotatexOES glRotatexOES = null;

        // GLAPI void APIENTRY glSampleCoverageOES (GLfixed value, GLboolean invert);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSampleCoverageOES(GLfixed value, GLboolean invert);
        private static TglSampleCoverageOES glSampleCoverageOES = null;

        // GLAPI void APIENTRY glScalexOES (GLfixed x, GLfixed y, GLfixed z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglScalexOES(GLfixed x, GLfixed y, GLfixed z);
	    private static TglScalexOES glScalexOES = null;
	
        // GLAPI void APIENTRY glTexEnvxOES (GLenum target, GLenum pname, GLfixed param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexEnvxOES(GLenum target, GLenum pname, GLfixed param);
	    private static TglTexEnvxOES glTexEnvxOES = null;
	
        // GLAPI void APIENTRY glTexEnvxvOES (GLenum target, GLenum pname, const GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexEnvxvOES(GLenum target, GLenum pname, GLfixed* parameters);
	    private static TglTexEnvxvOES glTexEnvxvOES = null;
	
        // GLAPI void APIENTRY glTexParameterxOES (GLenum target, GLenum pname, GLfixed param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexParameterxOES(GLenum target, GLenum pname, GLfixed param);
	    private static TglTexParameterxOES glTexParameterxOES = null;
	
        // GLAPI void APIENTRY glTexParameterxvOES (GLenum target, GLenum pname, const GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexParameterxvOES(GLenum target, GLenum pname, GLfixed* parameters);
	    private static TglTexParameterxvOES glTexParameterxvOES = null;
	
        // GLAPI void APIENTRY glTranslatexOES (GLfixed x, GLfixed y, GLfixed z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTranslatexOES(GLfixed x, GLfixed y, GLfixed z);
	    private static TglTranslatexOES glTranslatexOES = null;
	
        // GLAPI void APIENTRY glAccumxOES (GLenum op, GLfixed value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglAccumxOES(GLenum op, GLfixed value);
        private static TglAccumxOES glAccumxOES = null;

        // GLAPI void APIENTRY glBitmapxOES (GLsizei width, GLsizei height, GLfixed xorig, GLfixed yorig, GLfixed xmove, GLfixed ymove, const GLubyte *bitmap);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBitmapxOES(GLsizei width, GLsizei height, GLfixed xorig, GLfixed yorig, GLfixed xmove, GLfixed ymove, GLubyte* bitmap);
        private static TglBitmapxOES glBitmapxOES = null;

        // GLAPI void APIENTRY glBlendColorxOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendColorxOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
        private static TglBlendColorxOES glBlendColorxOES = null;

        // GLAPI void APIENTRY glClearAccumxOES (GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearAccumxOES(GLfixed red, GLfixed green, GLfixed blue, GLfixed alpha);
        private static TglClearAccumxOES glClearAccumxOES = null;

        // GLAPI void APIENTRY glColor3xOES (GLfixed red, GLfixed green, GLfixed blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor3xOES(GLfixed red, GLfixed green, GLfixed blue);
        private static TglColor3xOES glColor3xOES = null;

        // GLAPI void APIENTRY glColor3xvOES (const GLfixed *components);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor3xvOES(GLfixed* components);
        private static TglColor3xvOES glColor3xvOES = null;

        // GLAPI void APIENTRY glColor4xvOES (const GLfixed *components);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor4xvOES(GLfixed* components);
        private static TglColor4xvOES glColor4xvOES = null;

        // GLAPI void APIENTRY glConvolutionParameterxOES (GLenum target, GLenum pname, GLfixed param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglConvolutionParameterxOES(GLenum target, GLenum pname, GLfixed param);
        private static TglConvolutionParameterxOES glConvolutionParameterxOES = null;

        // GLAPI void APIENTRY glConvolutionParameterxvOES (GLenum target, GLenum pname, const GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglConvolutionParameterxvOES(GLenum target, GLenum pname, GLfixed* parameters);
        private static TglConvolutionParameterxvOES glConvolutionParameterxvOES = null;

        // GLAPI void APIENTRY glEvalCoord1xOES (GLfixed u);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEvalCoord1xOES(GLfixed u);
        private static TglEvalCoord1xOES glEvalCoord1xOES = null;

        // GLAPI void APIENTRY glEvalCoord1xvOES (const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglEvalCoord1xvOES(GLfixed* coords);
        private static TglEvalCoord1xvOES glEvalCoord1xvOES = null;

        // GLAPI void APIENTRY glEvalCoord2xOES (GLfixed u, GLfixed v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEvalCoord2xOES(GLfixed u, GLfixed v);
        private static TglEvalCoord2xOES glEvalCoord2xOES = null;

        // GLAPI void APIENTRY glEvalCoord2xvOES (const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglEvalCoord2xvOES(GLfixed* coords);
        private static TglEvalCoord2xvOES glEvalCoord2xvOES = null;

        // GLAPI void APIENTRY glFeedbackBufferxOES (GLsizei n, GLenum type, const GLfixed *buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFeedbackBufferxOES(GLsizei n, GLenum type, GLfixed* buffer);
        private static TglFeedbackBufferxOES glFeedbackBufferxOES = null;

        // GLAPI void APIENTRY glGetConvolutionParameterxvOES (GLenum target, GLenum pname, GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetConvolutionParameterxvOES(GLenum target, GLenum pname, GLfixed* parameters);
        private static TglGetConvolutionParameterxvOES glGetConvolutionParameterxvOES = null;

        // GLAPI void APIENTRY glGetHistogramParameterxvOES (GLenum target, GLenum pname, GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetHistogramParameterxvOES(GLenum target, GLenum pname, GLfixed* parameters);
        private static TglGetHistogramParameterxvOES glGetHistogramParameterxvOES = null;

        // GLAPI void APIENTRY glGetLightxOES (GLenum light, GLenum pname, GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetLightxOES(GLenum light, GLenum pname, GLfixed* parameters);
        private static TglGetLightxOES glGetLightxOES = null;

        // GLAPI void APIENTRY glGetMapxvOES (GLenum target, GLenum query, GLfixed *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMapxvOES(GLenum target, GLenum query, GLfixed* v);
        private static TglGetMapxvOES glGetMapxvOES = null;

        // GLAPI void APIENTRY glGetMaterialxOES (GLenum face, GLenum pname, GLfixed param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGetMaterialxOES(GLenum face, GLenum pname, GLfixed param);
        private static TglGetMaterialxOES glGetMaterialxOES = null;

        // GLAPI void APIENTRY glGetPixelMapxv (GLenum map, GLint size, GLfixed *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPixelMapxv(GLenum map, GLint size, GLfixed* values);
        private static TglGetPixelMapxv glGetPixelMapxv = null;

        // GLAPI void APIENTRY glGetTexGenxvOES (GLenum coord, GLenum pname, GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexGenxvOES(GLenum coord, GLenum pname, GLfixed* parameters);
        private static TglGetTexGenxvOES glGetTexGenxvOES = null;

        // GLAPI void APIENTRY glGetTexLevelParameterxvOES (GLenum target, GLint level, GLenum pname, GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexLevelParameterxvOES(GLenum target, GLint level, GLenum pname, GLfixed* parameters);
        private static TglGetTexLevelParameterxvOES glGetTexLevelParameterxvOES = null;

        // GLAPI void APIENTRY glIndexxOES (GLfixed component);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglIndexxOES(GLfixed component);
        private static TglIndexxOES glIndexxOES = null;

        // GLAPI void APIENTRY glIndexxvOES (const GLfixed *component);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglIndexxvOES(GLfixed* component);
        private static TglIndexxvOES glIndexxvOES = null;

        // GLAPI void APIENTRY glLoadTransposeMatrixxOES (const GLfixed *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLoadTransposeMatrixxOES(GLfixed* m);
        private static TglLoadTransposeMatrixxOES glLoadTransposeMatrixxOES = null;

        // GLAPI void APIENTRY glMap1xOES (GLenum target, GLfixed u1, GLfixed u2, GLint stride, GLint order, GLfixed points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMap1xOES(GLenum target, GLfixed u1, GLfixed u2, GLint stride, GLint order, GLfixed points);
        private static TglMap1xOES glMap1xOES = null;

        // GLAPI void APIENTRY glMap2xOES (GLenum target, GLfixed u1, GLfixed u2, GLint ustride, GLint uorder, GLfixed v1, GLfixed v2, GLint vstride, GLint vorder, GLfixed points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMap2xOES(GLenum target, GLfixed u1, GLfixed u2, GLint ustride, GLint uorder, GLfixed v1, GLfixed v2, GLint vstride, GLint vorder, GLfixed points);
        private static TglMap2xOES glMap2xOES = null;

        // GLAPI void APIENTRY glMapGrid1xOES (GLint n, GLfixed u1, GLfixed u2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMapGrid1xOES(GLint n, GLfixed u1, GLfixed u2);
        private static TglMapGrid1xOES glMapGrid1xOES = null;

        // GLAPI void APIENTRY glMapGrid2xOES (GLint n, GLfixed u1, GLfixed u2, GLfixed v1, GLfixed v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMapGrid2xOES(GLint n, GLfixed u1, GLfixed u2, GLfixed v1, GLfixed v2);
        private static TglMapGrid2xOES glMapGrid2xOES = null;

        // GLAPI void APIENTRY glMultTransposeMatrixxOES (const GLfixed *m);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultTransposeMatrixxOES(GLfixed* m);
        private static TglMultTransposeMatrixxOES glMultTransposeMatrixxOES = null;

        // GLAPI void APIENTRY glMultiTexCoord1xOES (GLenum texture, GLfixed s);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord1xOES(GLenum texture, GLfixed s);
        private static TglMultiTexCoord1xOES glMultiTexCoord1xOES = null;

        // GLAPI void APIENTRY glMultiTexCoord1xvOES (GLenum texture, const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord1xvOES(GLenum texture, GLfixed* coords);
        private static TglMultiTexCoord1xvOES glMultiTexCoord1xvOES = null;

        // GLAPI void APIENTRY glMultiTexCoord2xOES (GLenum texture, GLfixed s, GLfixed t);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord2xOES(GLenum texture, GLfixed s, GLfixed t);
        private static TglMultiTexCoord2xOES glMultiTexCoord2xOES = null;

        // GLAPI void APIENTRY glMultiTexCoord2xvOES (GLenum texture, const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord2xvOES(GLenum texture, GLfixed* coords);
        private static TglMultiTexCoord2xvOES glMultiTexCoord2xvOES = null;

        // GLAPI void APIENTRY glMultiTexCoord3xOES (GLenum texture, GLfixed s, GLfixed t, GLfixed r);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord3xOES(GLenum texture, GLfixed s, GLfixed t, GLfixed r);
        private static TglMultiTexCoord3xOES glMultiTexCoord3xOES = null;

        // GLAPI void APIENTRY glMultiTexCoord3xvOES (GLenum texture, const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord3xvOES(GLenum texture, GLfixed* coords);
        private static TglMultiTexCoord3xvOES glMultiTexCoord3xvOES = null;

        // GLAPI void APIENTRY glMultiTexCoord4xvOES (GLenum texture, const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord4xvOES(GLenum texture, GLfixed* coords);
        private static TglMultiTexCoord4xvOES glMultiTexCoord4xvOES = null;

        // GLAPI void APIENTRY glNormal3xvOES (const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormal3xvOES(GLfixed* coords);
        private static TglNormal3xvOES glNormal3xvOES = null;

        // GLAPI void APIENTRY glPassThroughxOES (GLfixed token);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPassThroughxOES(GLfixed token);
        private static TglPassThroughxOES glPassThroughxOES = null;

        // GLAPI void APIENTRY glPixelMapx (GLenum map, GLint size, const GLfixed *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPixelMapx(GLenum map, GLint size, GLfixed* values);
        private static TglPixelMapx glPixelMapx = null;

        // GLAPI void APIENTRY glPixelStorex (GLenum pname, GLfixed param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPixelStorex(GLenum pname, GLfixed param);
        private static TglPixelStorex glPixelStorex = null;

        // GLAPI void APIENTRY glPixelTransferxOES (GLenum pname, GLfixed param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPixelTransferxOES(GLenum pname, GLfixed param);
        private static TglPixelTransferxOES glPixelTransferxOES = null;

        // GLAPI void APIENTRY glPixelZoomxOES (GLfixed xfactor, GLfixed yfactor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPixelZoomxOES(GLfixed xfactor, GLfixed yfactor);
        private static TglPixelZoomxOES glPixelZoomxOES = null;

        // GLAPI void APIENTRY glPrioritizeTexturesxOES (GLsizei n, const GLuint *textures, const GLfixed *priorities);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPrioritizeTexturesxOES(GLsizei n, GLuint* textures, GLfixed* priorities);
        private static TglPrioritizeTexturesxOES glPrioritizeTexturesxOES = null;

        // GLAPI void APIENTRY glRasterPos2xOES (GLfixed x, GLfixed y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos2xOES(GLfixed x, GLfixed y);
        private static TglRasterPos2xOES glRasterPos2xOES = null;

        // GLAPI void APIENTRY glRasterPos2xvOES (const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos2xvOES(GLfixed* coords);
        private static TglRasterPos2xvOES glRasterPos2xvOES = null;

        // GLAPI void APIENTRY glRasterPos3xOES (GLfixed x, GLfixed y, GLfixed z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos3xOES(GLfixed x, GLfixed y, GLfixed z);
        private static TglRasterPos3xOES glRasterPos3xOES = null;

        // GLAPI void APIENTRY glRasterPos3xvOES (const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos3xvOES(GLfixed* coords);
        private static TglRasterPos3xvOES glRasterPos3xvOES = null;

        // GLAPI void APIENTRY glRasterPos4xOES (GLfixed x, GLfixed y, GLfixed z, GLfixed w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos4xOES(GLfixed x, GLfixed y, GLfixed z, GLfixed w);
        private static TglRasterPos4xOES glRasterPos4xOES = null;

        // GLAPI void APIENTRY glRasterPos4xvOES (const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos4xvOES(GLfixed* coords);
        private static TglRasterPos4xvOES glRasterPos4xvOES = null;

        // GLAPI void APIENTRY glRectxOES (GLfixed x1, GLfixed y1, GLfixed x2, GLfixed y2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRectxOES(GLfixed x1, GLfixed y1, GLfixed x2, GLfixed y2);
        private static TglRectxOES glRectxOES = null;

        // GLAPI void APIENTRY glRectxvOES (const GLfixed *v1, const GLfixed *v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRectxvOES(GLfixed* v1, GLfixed* v2);
        private static TglRectxvOES glRectxvOES = null;

        // GLAPI void APIENTRY glTexCoord1xOES (GLfixed s);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord1xOES(GLfixed s);
        private static TglTexCoord1xOES glTexCoord1xOES = null;

        // GLAPI void APIENTRY glTexCoord1xvOES (const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord1xvOES(GLfixed* coords);
        private static TglTexCoord1xvOES glTexCoord1xvOES = null;

        // GLAPI void APIENTRY glTexCoord2xOES (GLfixed s, GLfixed t);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord2xOES(GLfixed s, GLfixed t);
        private static TglTexCoord2xOES glTexCoord2xOES = null;

        // GLAPI void APIENTRY glTexCoord2xvOES (const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord2xvOES(GLfixed* coords);
        private static TglTexCoord2xvOES glTexCoord2xvOES = null;

        // GLAPI void APIENTRY glTexCoord3xOES (GLfixed s, GLfixed t, GLfixed r);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord3xOES(GLfixed s, GLfixed t, GLfixed r);
        private static TglTexCoord3xOES glTexCoord3xOES = null;

        // GLAPI void APIENTRY glTexCoord3xvOES (const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord3xvOES(GLfixed* coords);
        private static TglTexCoord3xvOES glTexCoord3xvOES = null;

        // GLAPI void APIENTRY glTexCoord4xOES (GLfixed s, GLfixed t, GLfixed r, GLfixed q);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord4xOES(GLfixed s, GLfixed t, GLfixed r, GLfixed q);
        private static TglTexCoord4xOES glTexCoord4xOES = null;

        // GLAPI void APIENTRY glTexCoord4xvOES (const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord4xvOES(GLfixed* coords);
        private static TglTexCoord4xvOES glTexCoord4xvOES = null;

        // GLAPI void APIENTRY glTexGenxOES (GLenum coord, GLenum pname, GLfixed param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexGenxOES(GLenum coord, GLenum pname, GLfixed param);
        private static TglTexGenxOES glTexGenxOES = null;

        // GLAPI void APIENTRY glTexGenxvOES (GLenum coord, GLenum pname, const GLfixed *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexGenxvOES(GLenum coord, GLenum pname, GLfixed* parameters);
        private static TglTexGenxvOES glTexGenxvOES = null;

        // GLAPI void APIENTRY glVertex2xOES (GLfixed x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex2xOES(GLfixed x);
        private static TglVertex2xOES glVertex2xOES = null;

        // GLAPI void APIENTRY glVertex2xvOES (const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex2xvOES(GLfixed* coords);
        private static TglVertex2xvOES glVertex2xvOES = null;

        // GLAPI void APIENTRY glVertex3xOES (GLfixed x, GLfixed y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex3xOES(GLfixed x, GLfixed y);
        private static TglVertex3xOES glVertex3xOES = null;

        // GLAPI void APIENTRY glVertex3xvOES (const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex3xvOES(GLfixed* coords);
        private static TglVertex3xvOES glVertex3xvOES = null;

        // GLAPI void APIENTRY glVertex4xOES (GLfixed x, GLfixed y, GLfixed z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex4xOES(GLfixed x, GLfixed y, GLfixed z);
        private static TglVertex4xOES glVertex4xOES = null;

        // GLAPI void APIENTRY glVertex4xvOES (const GLfixed *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex4xvOES(GLfixed* coords);
        private static TglVertex4xvOES glVertex4xvOES = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_OML_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_OML_xxx FUNCTIONS...
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
        // GL_OVR_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_OVR_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_OVR_multiview
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFramebufferTextureMultiviewOVR(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint baseViewIndex, GLsizei numViews);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTextureMultiviewOVR(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint baseViewIndex, GLsizei numViews);
        private static TglFramebufferTextureMultiviewOVR glFramebufferTextureMultiviewOVR = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_OVR_multiview2 (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_PGI_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_PGI_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_PGI_vertex_hints (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_PGI_misc_hints
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glHintPGI (GLenum target, GLint mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglHintPGI(GLenum target, GLint mode);
        private static TglHintPGI glHintPGI = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_REND_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_REND_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_REND_screen_coordinates (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_S3_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_S3_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_S3_s3tc (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SGI_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_color_matrix (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_color_table
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glColorTableSGI (GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, const GLvoid *table);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorTableSGI(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, void* table);
        private static TglColorTableSGI glColorTableSGI = null;

        // GLAPI void APIENTRY glColorTableParameterfvSGI (GLenum target, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorTableParameterfvSGI(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglColorTableParameterfvSGI glColorTableParameterfvSGI = null;

        // GLAPI void APIENTRY glColorTableParameterivSGI (GLenum target, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorTableParameterivSGI(GLenum target, GLenum pname, GLint* parameters);
        private static TglColorTableParameterivSGI glColorTableParameterivSGI = null;

        // GLAPI void APIENTRY glCopyColorTableSGI (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyColorTableSGI(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
        private static TglCopyColorTableSGI glCopyColorTableSGI = null;

        // GLAPI void APIENTRY glGetColorTableSGI (GLenum target, GLenum format, GLenum type, GLvoid *table);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetColorTableSGI(GLenum target, GLenum format, GLenum type, void* table);
        private static TglGetColorTableSGI glGetColorTableSGI = null;

        // GLAPI void APIENTRY glGetColorTableParameterfvSGI (GLenum target, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetColorTableParameterfvSGI(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetColorTableParameterfvSGI glGetColorTableParameterfvSGI = null;

        // GLAPI void APIENTRY glGetColorTableParameterivSGI (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetColorTableParameterivSGI(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetColorTableParameterivSGI glGetColorTableParameterivSGI = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_depth_pass_instrument (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_texture_color_table (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SGIS_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_filter4
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGetTexFilterFuncSGIS (GLenum target, GLenum filter, GLfloat *weights);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexFilterFuncSGIS(GLenum target, GLenum filter, GLfloat* weights);
        private static TglGetTexFilterFuncSGIS glGetTexFilterFuncSGIS = null;

        // GLAPI void APIENTRY glTexFilterFuncSGIS (GLenum target, GLenum filter, GLsizei n, const GLfloat *weights);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexFilterFuncSGIS(GLenum target, GLenum filter, GLsizei n, GLfloat* weights);
        private static TglTexFilterFuncSGIS glTexFilterFuncSGIS = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_pixel_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPixelTexGenParameteriSGIS (GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPixelTexGenParameteriSGIS(GLenum pname, GLint param);
        private static TglPixelTexGenParameteriSGIS glPixelTexGenParameteriSGIS = null;

        // GLAPI void APIENTRY glPixelTexGenParameterivSGIS (GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPixelTexGenParameterivSGIS(GLenum pname, GLint* parameters);
        private static TglPixelTexGenParameterivSGIS glPixelTexGenParameterivSGIS = null;

        // GLAPI void APIENTRY glPixelTexGenParameterfSGIS (GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPixelTexGenParameterfSGIS(GLenum pname, GLfloat param);
        private static TglPixelTexGenParameterfSGIS glPixelTexGenParameterfSGIS = null;

        // GLAPI void APIENTRY glPixelTexGenParameterfvSGIS (GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPixelTexGenParameterfvSGIS(GLenum pname, GLfloat* parameters);
        private static TglPixelTexGenParameterfvSGIS glPixelTexGenParameterfvSGIS = null;

        // GLAPI void APIENTRY glGetPixelTexGenParameterivSGIS (GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPixelTexGenParameterivSGIS(GLenum pname, GLint* parameters);
        private static TglGetPixelTexGenParameterivSGIS glGetPixelTexGenParameterivSGIS = null;

        // GLAPI void APIENTRY glGetPixelTexGenParameterfvSGIS (GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPixelTexGenParameterfvSGIS(GLenum pname, GLfloat* parameters);
        private static TglGetPixelTexGenParameterfvSGIS glGetPixelTexGenParameterfvSGIS = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture4D
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTexImage4DSGIS (GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLint border, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexImage4DSGIS(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLint border, GLenum format, GLenum type, void* pixels);
        private static TglTexImage4DSGIS glTexImage4DSGIS = null;

        // GLAPI void APIENTRY glTexSubImage4DSGIS (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint woffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLenum format, GLenum type, const GLvoid *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexSubImage4DSGIS(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint woffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei size4d, GLenum format, GLenum type, void* pixels);
        private static TglTexSubImage4DSGIS glTexSubImage4DSGIS = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_detail_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDetailTexFuncSGIS (GLenum target, GLsizei n, const GLfloat *points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDetailTexFuncSGIS(GLenum target, GLsizei n, GLfloat* points);
        private static TglDetailTexFuncSGIS glDetailTexFuncSGIS = null;

        // GLAPI void APIENTRY glGetDetailTexFuncSGIS (GLenum target, GLfloat *points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetDetailTexFuncSGIS(GLenum target, GLfloat* points);
        private static TglGetDetailTexFuncSGIS glGetDetailTexFuncSGIS = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_sharpen_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glSharpenTexFuncSGIS (GLenum target, GLsizei n, const GLfloat *points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSharpenTexFuncSGIS(GLenum target, GLsizei n, GLfloat* points);
        private static TglSharpenTexFuncSGIS glSharpenTexFuncSGIS = null;

        // GLAPI void APIENTRY glGetSharpenTexFuncSGIS (GLenum target, GLfloat *points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetSharpenTexFuncSGIS(GLenum target, GLfloat* points);
        private static TglGetSharpenTexFuncSGIS glGetSharpenTexFuncSGIS = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSampleMaskSGIS(GLclampf value, GLboolean invert);
        private static TglSampleMaskSGIS glSampleMaskSGIS = null;

        // GLAPI void APIENTRY glSamplePatternSGIS (GLenum pattern);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSamplePatternSGIS(GLenum pattern);
        private static TglSamplePatternSGIS glSamplePatternSGIS = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFogFuncSGIS(GLsizei n, GLfloat* points);
        private static TglFogFuncSGIS glFogFuncSGIS = null;

        // GLAPI void APIENTRY glGetFogFuncSGIS (GLfloat *points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFogFuncSGIS(GLfloat* points);
        private static TglGetFogFuncSGIS glGetFogFuncSGIS = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_point_parameters
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPointParameterfSGIS (GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPointParameterfSGIS(GLenum pname, GLfloat param);
        private static TglPointParameterfSGIS glPointParameterfSGIS = null;

        // GLAPI void APIENTRY glPointParameterfvSGIS (GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPointParameterfvSGIS(GLenum pname, GLfloat* parameters);
        private static TglPointParameterfvSGIS glPointParameterfvSGIS = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_point_line_texgen (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_color_mask
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTextureColorMaskSGIS (GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureColorMaskSGIS(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);
        private static TglTextureColorMaskSGIS glTextureColorMaskSGIS = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SGIX_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_pixel_texture
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glPixelTexGenSGIX (GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPixelTexGenSGIX(GLenum mode);
        private static TglPixelTexGenSGIX glPixelTexGenSGIX = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSpriteParameterfSGIX(GLenum pname, GLfloat param);
        private static TglSpriteParameterfSGIX glSpriteParameterfSGIX = null;

        // GLAPI void APIENTRY glSpriteParameterfvSGIX (GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSpriteParameterfvSGIX(GLenum pname, GLfloat* parameters);
        private static TglSpriteParameterfvSGIX glSpriteParameterfvSGIX = null;

        // GLAPI void APIENTRY glSpriteParameteriSGIX (GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSpriteParameteriSGIX(GLenum pname, GLint param);
        private static TglSpriteParameteriSGIX glSpriteParameteriSGIX = null;

        // GLAPI void APIENTRY glSpriteParameterivSGIX (GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSpriteParameterivSGIX(GLenum pname, GLint* parameters);
        private static TglSpriteParameterivSGIX glSpriteParameterivSGIX = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_multi_buffer (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_instruments
        ///////////////////////////////////////////////////////////////////////
        // GLAPI GLint APIENTRY glGetInstrumentsSGIX (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLint TglGetInstrumentsSGIX();
        private static TglGetInstrumentsSGIX glGetInstrumentsSGIX = null;

        // GLAPI void APIENTRY glInstrumentsBufferSGIX (GLsizei size, GLint *buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglInstrumentsBufferSGIX(GLsizei size, GLint* buffer);
        private static TglInstrumentsBufferSGIX glInstrumentsBufferSGIX = null;

        // GLAPI GLint APIENTRY glPollInstrumentsSGIX (GLint *marker_p);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLint TglPollInstrumentsSGIX(GLint* marker_p);
        private static TglPollInstrumentsSGIX glPollInstrumentsSGIX = null;

        // GLAPI void APIENTRY glReadInstrumentsSGIX (GLint marker);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReadInstrumentsSGIX(GLint marker);
        private static TglReadInstrumentsSGIX glReadInstrumentsSGIX = null;

        // GLAPI void APIENTRY glStartInstrumentsSGIX (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStartInstrumentsSGIX();
        private static TglStartInstrumentsSGIX glStartInstrumentsSGIX = null;

        // GLAPI void APIENTRY glStopInstrumentsSGIX (GLint marker);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStopInstrumentsSGIX(GLint marker);
        private static TglStopInstrumentsSGIX glStopInstrumentsSGIX = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_scale_bias
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_framezoom
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFrameZoomSGIX (GLint factor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFrameZoomSGIX(GLint factor);
        private static TglFrameZoomSGIX glFrameZoomSGIX = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_tag_sample_buffer
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glTagSampleBufferSGIX (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTagSampleBufferSGIX();
        private static TglTagSampleBufferSGIX glTagSampleBufferSGIX = null;
           
        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_polynomial_ffd
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDeformationMap3dSGIX (GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble w1, GLdouble w2, GLint wstride, GLint worder, const GLdouble *points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeformationMap3dSGIX(GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble w1, GLdouble w2, GLint wstride, GLint worder, GLdouble* points);
        private static TglDeformationMap3dSGIX glDeformationMap3dSGIX = null;

        // GLAPI void APIENTRY glDeformationMap3fSGIX (GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat w1, GLfloat w2, GLint wstride, GLint worder, const GLfloat *points);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeformationMap3fSGIX(GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat w1, GLfloat w2, GLint wstride, GLint worder, GLfloat* points);
        private static TglDeformationMap3fSGIX glDeformationMap3fSGIX = null;

        // GLAPI void APIENTRY glDeformSGIX (GLbitfield mask);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDeformSGIX(GLbitfield mask);
        private static TglDeformSGIX glDeformSGIX = null;

        // GLAPI void APIENTRY glLoadIdentityDeformationMapSGIX (GLbitfield mask);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLoadIdentityDeformationMapSGIX(GLbitfield mask);
        private static TglLoadIdentityDeformationMapSGIX glLoadIdentityDeformationMapSGIX = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_reference_plane
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glReferencePlaneSGIX (const GLdouble *equation);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReferencePlaneSGIX(GLdouble* equation);
        private static TglReferencePlaneSGIX glReferencePlaneSGIX = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_flush_raster
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFlushRasterSGIX (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFlushRasterSGIX();
        private static TglFlushRasterSGIX glFlushRasterSGIX = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetListParameterfvSGIX(GLuint list, GLenum pname, GLfloat* parameters);
        private static TglGetListParameterfvSGIX glGetListParameterfvSGIX = null;

        // GLAPI void APIENTRY glGetListParameterivSGIX (GLuint list, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetListParameterivSGIX(GLuint list, GLenum pname, GLint* parameters);
        private static TglGetListParameterivSGIX glGetListParameterivSGIX = null;

        // GLAPI void APIENTRY glListParameterfSGIX (GLuint list, GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglListParameterfSGIX(GLuint list, GLenum pname, GLfloat param);
        private static TglListParameterfSGIX glListParameterfSGIX = null;

        // GLAPI void APIENTRY glListParameterfvSGIX (GLuint list, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglListParameterfvSGIX(GLuint list, GLenum pname, GLfloat* parameters);
        private static TglListParameterfvSGIX glListParameterfvSGIX = null;

        // GLAPI void APIENTRY glListParameteriSGIX (GLuint list, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglListParameteriSGIX(GLuint list, GLenum pname, GLint param);
        private static TglListParameteriSGIX glListParameteriSGIX = null;

        // GLAPI void APIENTRY glListParameterivSGIX (GLuint list, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglListParameterivSGIX(GLuint list, GLenum pname, GLint* parameters);
        private static TglListParameterivSGIX glListParameterivSGIX = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFragmentColorMaterialSGIX(GLenum face, GLenum mode);
        private static TglFragmentColorMaterialSGIX glFragmentColorMaterialSGIX = null;

        // GLAPI void APIENTRY glFragmentLightfSGIX (GLenum light, GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFragmentLightfSGIX(GLenum light, GLenum pname, GLfloat param);
        private static TglFragmentLightfSGIX glFragmentLightfSGIX = null;

        // GLAPI void APIENTRY glFragmentLightfvSGIX (GLenum light, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFragmentLightfvSGIX(GLenum light, GLenum pname, GLfloat* parameters);
        private static TglFragmentLightfvSGIX glFragmentLightfvSGIX = null;

        // GLAPI void APIENTRY glFragmentLightiSGIX (GLenum light, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFragmentLightiSGIX(GLenum light, GLenum pname, GLint param);
        private static TglFragmentLightiSGIX glFragmentLightiSGIX = null;

        // GLAPI void APIENTRY glFragmentLightivSGIX (GLenum light, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFragmentLightivSGIX(GLenum light, GLenum pname, GLint* parameters);
        private static TglFragmentLightivSGIX glFragmentLightivSGIX = null;

        // GLAPI void APIENTRY glFragmentLightModelfSGIX (GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFragmentLightModelfSGIX(GLenum pname, GLfloat param);
        private static TglFragmentLightModelfSGIX glFragmentLightModelfSGIX = null;

        // GLAPI void APIENTRY glFragmentLightModelfvSGIX (GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFragmentLightModelfvSGIX(GLenum pname, GLfloat* parameters);
        private static TglFragmentLightModelfvSGIX glFragmentLightModelfvSGIX = null;

        // GLAPI void APIENTRY glFragmentLightModeliSGIX (GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFragmentLightModeliSGIX(GLenum pname, GLint param);
        private static TglFragmentLightModeliSGIX glFragmentLightModeliSGIX = null;

        // GLAPI void APIENTRY glFragmentLightModelivSGIX (GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFragmentLightModelivSGIX(GLenum pname, GLint* parameters);
        private static TglFragmentLightModelivSGIX glFragmentLightModelivSGIX = null;

        // GLAPI void APIENTRY glFragmentMaterialfSGIX (GLenum face, GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFragmentMaterialfSGIX(GLenum face, GLenum pname, GLfloat param);
        private static TglFragmentMaterialfSGIX glFragmentMaterialfSGIX = null;

        // GLAPI void APIENTRY glFragmentMaterialfvSGIX (GLenum face, GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFragmentMaterialfvSGIX(GLenum face, GLenum pname, GLfloat* parameters);
        private static TglFragmentMaterialfvSGIX glFragmentMaterialfvSGIX = null;

        // GLAPI void APIENTRY glFragmentMaterialiSGIX (GLenum face, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFragmentMaterialiSGIX(GLenum face, GLenum pname, GLint param);
        private static TglFragmentMaterialiSGIX glFragmentMaterialiSGIX = null;

        // GLAPI void APIENTRY glFragmentMaterialivSGIX (GLenum face, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFragmentMaterialivSGIX(GLenum face, GLenum pname, GLint* parameters);
        private static TglFragmentMaterialivSGIX glFragmentMaterialivSGIX = null;

        // GLAPI void APIENTRY glGetFragmentLightfvSGIX (GLenum light, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFragmentLightfvSGIX(GLenum light, GLenum pname, GLfloat* parameters);
        private static TglGetFragmentLightfvSGIX glGetFragmentLightfvSGIX = null;

        // GLAPI void APIENTRY glGetFragmentLightivSGIX (GLenum light, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFragmentLightivSGIX(GLenum light, GLenum pname, GLint* parameters);
        private static TglGetFragmentLightivSGIX glGetFragmentLightivSGIX = null;

        // GLAPI void APIENTRY glGetFragmentMaterialfvSGIX (GLenum face, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFragmentMaterialfvSGIX(GLenum face, GLenum pname, GLfloat* parameters);
        private static TglGetFragmentMaterialfvSGIX glGetFragmentMaterialfvSGIX = null;

        // GLAPI void APIENTRY glGetFragmentMaterialivSGIX (GLenum face, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFragmentMaterialivSGIX(GLenum face, GLenum pname, GLint* parameters);
        private static TglGetFragmentMaterialivSGIX glGetFragmentMaterialivSGIX = null;

        // GLAPI void APIENTRY glLightEnviSGIX (GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLightEnviSGIX(GLenum pname, GLint param);
        private static TglLightEnviSGIX glLightEnviSGIX = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_blend_alpha_minmax (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_async
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glAsyncMarkerSGIX (GLuint marker);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglAsyncMarkerSGIX(GLuint marker);
        private static TglAsyncMarkerSGIX glAsyncMarkerSGIX = null;

        // GLAPI GLint APIENTRY glFinishAsyncSGIX (GLuint *markerp);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLint TglFinishAsyncSGIX(GLuint* markerp);
        private static TglFinishAsyncSGIX glFinishAsyncSGIX = null;

        // GLAPI GLint APIENTRY glPollAsyncSGIX (GLuint *markerp);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLint TglPollAsyncSGIX(GLuint* markerp);
        private static TglPollAsyncSGIX glPollAsyncSGIX = null;

        // GLAPI GLuint APIENTRY glGenAsyncMarkersSGIX (GLsizei range);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglGenAsyncMarkersSGIX(GLsizei range);
        private static TglGenAsyncMarkersSGIX glGenAsyncMarkersSGIX = null;

        // GLAPI void APIENTRY glDeleteAsyncMarkersSGIX (GLuint marker, GLsizei range);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDeleteAsyncMarkersSGIX(GLuint marker, GLsizei range);
        private static TglDeleteAsyncMarkersSGIX glDeleteAsyncMarkersSGIX = null;

        // GLAPI GLboolean APIENTRY glIsAsyncMarkerSGIX (GLuint marker);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsAsyncMarkerSGIX(GLuint marker);
        private static TglIsAsyncMarkerSGIX glIsAsyncMarkerSGIX = null;

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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglIglooInterfaceSGIX(GLenum pname, void* parameters);
        private static TglIglooInterfaceSGIX glIglooInterfaceSGIX = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SUN_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_multi_draw_arrays
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glMultiDrawArraysSUN (GLenum mode, const GLint *first, const GLsizei *count, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawArraysSUN(GLenum mode, GLint* first, GLsizei* count, GLsizei primcount);
        private static TglMultiDrawArraysSUN glMultiDrawArraysSUN = null;

        // GLAPI void APIENTRY glMultiDrawElementsSUN (GLenum mode, const GLsizei *count, GLenum type, const GLvoid* *indices, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawElementsSUN(GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei primcount);
        private static TglMultiDrawElementsSUN glMultiDrawElementsSUN = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_global_alpha
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glGlobalAlphaFactorbSUN (GLbyte factor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGlobalAlphaFactorbSUN(GLbyte factor);
        private static TglGlobalAlphaFactorbSUN glGlobalAlphaFactorbSUN = null;

        // GLAPI void APIENTRY glGlobalAlphaFactorsSUN (GLshort factor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGlobalAlphaFactorsSUN(GLshort factor);
        private static TglGlobalAlphaFactorsSUN glGlobalAlphaFactorsSUN = null;

        // GLAPI void APIENTRY glGlobalAlphaFactoriSUN (GLint factor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGlobalAlphaFactoriSUN(GLint factor);
        private static TglGlobalAlphaFactoriSUN glGlobalAlphaFactoriSUN = null;

        // GLAPI void APIENTRY glGlobalAlphaFactorfSUN (GLfloat factor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGlobalAlphaFactorfSUN(GLfloat factor);
        private static TglGlobalAlphaFactorfSUN glGlobalAlphaFactorfSUN = null;

        // GLAPI void APIENTRY glGlobalAlphaFactordSUN (GLdouble factor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGlobalAlphaFactordSUN(GLdouble factor);
        private static TglGlobalAlphaFactordSUN glGlobalAlphaFactordSUN = null;

        // GLAPI void APIENTRY glGlobalAlphaFactorubSUN (GLubyte factor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGlobalAlphaFactorubSUN(GLubyte factor);
        private static TglGlobalAlphaFactorubSUN glGlobalAlphaFactorubSUN = null;

        // GLAPI void APIENTRY glGlobalAlphaFactorusSUN (GLushort factor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGlobalAlphaFactorusSUN(GLushort factor);
        private static TglGlobalAlphaFactorusSUN glGlobalAlphaFactorusSUN = null;

        // GLAPI void APIENTRY glGlobalAlphaFactoruiSUN (GLuint factor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGlobalAlphaFactoruiSUN(GLuint factor);
        private static TglGlobalAlphaFactoruiSUN glGlobalAlphaFactoruiSUN = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_triangle_list
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glReplacementCodeuiSUN (GLuint code);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReplacementCodeuiSUN(GLuint code);
        private static TglReplacementCodeuiSUN glReplacementCodeuiSUN = null;

        // GLAPI void APIENTRY glReplacementCodeusSUN (GLushort code);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReplacementCodeusSUN(GLushort code);
        private static TglReplacementCodeusSUN glReplacementCodeusSUN = null;

        // GLAPI void APIENTRY glReplacementCodeubSUN (GLubyte code);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReplacementCodeubSUN(GLubyte code);
        private static TglReplacementCodeubSUN glReplacementCodeubSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuivSUN (const GLuint *code);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReplacementCodeuivSUN(GLuint* code);
        private static TglReplacementCodeuivSUN glReplacementCodeuivSUN = null;

        // GLAPI void APIENTRY glReplacementCodeusvSUN (const GLushort *code);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReplacementCodeusvSUN(GLushort* code);
        private static TglReplacementCodeusvSUN glReplacementCodeusvSUN = null;

        // GLAPI void APIENTRY glReplacementCodeubvSUN (const GLubyte *code);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReplacementCodeubvSUN(GLubyte* code);
        private static TglReplacementCodeubvSUN glReplacementCodeubvSUN = null;

        // GLAPI void APIENTRY glReplacementCodePointerSUN (GLenum type, GLsizei stride, const GLvoid* *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReplacementCodePointerSUN(GLenum type, GLsizei stride, void** pointer);
        private static TglReplacementCodePointerSUN glReplacementCodePointerSUN = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_vertex
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glColor4ubVertex2fSUN (GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor4ubVertex2fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y);
        private static TglColor4ubVertex2fSUN glColor4ubVertex2fSUN = null;

        // GLAPI void APIENTRY glColor4ubVertex2fvSUN (const GLubyte *c, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor4ubVertex2fvSUN(GLubyte* c, GLfloat* v);
        private static TglColor4ubVertex2fvSUN glColor4ubVertex2fvSUN = null;

        // GLAPI void APIENTRY glColor4ubVertex3fSUN (GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor4ubVertex3fSUN(GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        private static TglColor4ubVertex3fSUN glColor4ubVertex3fSUN = null;

        // GLAPI void APIENTRY glColor4ubVertex3fvSUN (const GLubyte *c, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor4ubVertex3fvSUN(GLubyte* c, GLfloat* v);
        private static TglColor4ubVertex3fvSUN glColor4ubVertex3fvSUN = null;

        // GLAPI void APIENTRY glColor3fVertex3fSUN (GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        private static TglColor3fVertex3fSUN glColor3fVertex3fSUN = null;

        // GLAPI void APIENTRY glColor3fVertex3fvSUN (const GLfloat *c, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor3fVertex3fvSUN(GLfloat* c, GLfloat* v);
        private static TglColor3fVertex3fvSUN glColor3fVertex3fvSUN = null;

        // GLAPI void APIENTRY glNormal3fVertex3fSUN (GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormal3fVertex3fSUN(GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        private static TglNormal3fVertex3fSUN glNormal3fVertex3fSUN = null;

        // GLAPI void APIENTRY glNormal3fVertex3fvSUN (const GLfloat *n, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormal3fVertex3fvSUN(GLfloat* n, GLfloat* v);
        private static TglNormal3fVertex3fvSUN glNormal3fVertex3fvSUN = null;

        // GLAPI void APIENTRY glColor4fNormal3fVertex3fSUN (GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor4fNormal3fVertex3fSUN(GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        private static TglColor4fNormal3fVertex3fSUN glColor4fNormal3fVertex3fSUN = null;

        // GLAPI void APIENTRY glColor4fNormal3fVertex3fvSUN (const GLfloat *c, const GLfloat *n, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor4fNormal3fVertex3fvSUN(GLfloat* c, GLfloat* n, GLfloat* v);
        private static TglColor4fNormal3fVertex3fvSUN glColor4fNormal3fVertex3fvSUN = null;

        // GLAPI void APIENTRY glTexCoord2fVertex3fSUN (GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord2fVertex3fSUN(GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);
        private static TglTexCoord2fVertex3fSUN glTexCoord2fVertex3fSUN = null;

        // GLAPI void APIENTRY glTexCoord2fVertex3fvSUN (const GLfloat *tc, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord2fVertex3fvSUN(GLfloat* tc, GLfloat* v);
        private static TglTexCoord2fVertex3fvSUN glTexCoord2fVertex3fvSUN = null;

        // GLAPI void APIENTRY glTexCoord4fVertex4fSUN (GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord4fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglTexCoord4fVertex4fSUN glTexCoord4fVertex4fSUN = null;

        // GLAPI void APIENTRY glTexCoord4fVertex4fvSUN (const GLfloat *tc, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord4fVertex4fvSUN(GLfloat* tc, GLfloat* v);
        private static TglTexCoord4fVertex4fvSUN glTexCoord4fVertex4fvSUN = null;

        // GLAPI void APIENTRY glTexCoord2fColor4ubVertex3fSUN (GLfloat s, GLfloat t, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord2fColor4ubVertex3fSUN(GLfloat s, GLfloat t, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        private static TglTexCoord2fColor4ubVertex3fSUN glTexCoord2fColor4ubVertex3fSUN = null;

        // GLAPI void APIENTRY glTexCoord2fColor4ubVertex3fvSUN (const GLfloat *tc, const GLubyte *c, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord2fColor4ubVertex3fvSUN(GLfloat* tc, GLubyte* c, GLfloat* v);
        private static TglTexCoord2fColor4ubVertex3fvSUN glTexCoord2fColor4ubVertex3fvSUN = null;

        // GLAPI void APIENTRY glTexCoord2fColor3fVertex3fSUN (GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord2fColor3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        private static TglTexCoord2fColor3fVertex3fSUN glTexCoord2fColor3fVertex3fSUN = null;

        // GLAPI void APIENTRY glTexCoord2fColor3fVertex3fvSUN (const GLfloat *tc, const GLfloat *c, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord2fColor3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* v);
        private static TglTexCoord2fColor3fVertex3fvSUN glTexCoord2fColor3fVertex3fvSUN = null;

        // GLAPI void APIENTRY glTexCoord2fNormal3fVertex3fSUN (GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord2fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        private static TglTexCoord2fNormal3fVertex3fSUN glTexCoord2fNormal3fVertex3fSUN = null;

        // GLAPI void APIENTRY glTexCoord2fNormal3fVertex3fvSUN (const GLfloat *tc, const GLfloat *n, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord2fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* n, GLfloat* v);
        private static TglTexCoord2fNormal3fVertex3fvSUN glTexCoord2fNormal3fVertex3fvSUN = null;

        // GLAPI void APIENTRY glTexCoord2fColor4fNormal3fVertex3fSUN (GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord2fColor4fNormal3fVertex3fSUN(GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        private static TglTexCoord2fColor4fNormal3fVertex3fSUN glTexCoord2fColor4fNormal3fVertex3fSUN = null;

        // GLAPI void APIENTRY glTexCoord2fColor4fNormal3fVertex3fvSUN (const GLfloat *tc, const GLfloat *c, const GLfloat *n, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord2fColor4fNormal3fVertex3fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v);
        private static TglTexCoord2fColor4fNormal3fVertex3fvSUN glTexCoord2fColor4fNormal3fVertex3fvSUN = null;

        // GLAPI void APIENTRY glTexCoord4fColor4fNormal3fVertex4fSUN (GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord4fColor4fNormal3fVertex4fSUN(GLfloat s, GLfloat t, GLfloat p, GLfloat q, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglTexCoord4fColor4fNormal3fVertex4fSUN glTexCoord4fColor4fNormal3fVertex4fSUN = null;

        // GLAPI void APIENTRY glTexCoord4fColor4fNormal3fVertex4fvSUN (const GLfloat *tc, const GLfloat *c, const GLfloat *n, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord4fColor4fNormal3fVertex4fvSUN(GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v);
        private static TglTexCoord4fColor4fNormal3fVertex4fvSUN glTexCoord4fColor4fNormal3fVertex4fvSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiVertex3fSUN (GLuint rc, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReplacementCodeuiVertex3fSUN(GLuint rc, GLfloat x, GLfloat y, GLfloat z);
        private static TglReplacementCodeuiVertex3fSUN glReplacementCodeuiVertex3fSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiVertex3fvSUN (const GLuint *rc, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReplacementCodeuiVertex3fvSUN(GLuint* rc, GLfloat* v);
        private static TglReplacementCodeuiVertex3fvSUN glReplacementCodeuiVertex3fvSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiColor4ubVertex3fSUN (GLuint rc, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReplacementCodeuiColor4ubVertex3fSUN(GLuint rc, GLubyte r, GLubyte g, GLubyte b, GLubyte a, GLfloat x, GLfloat y, GLfloat z);
        private static TglReplacementCodeuiColor4ubVertex3fSUN glReplacementCodeuiColor4ubVertex3fSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiColor4ubVertex3fvSUN (const GLuint *rc, const GLubyte *c, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReplacementCodeuiColor4ubVertex3fvSUN(GLuint* rc, GLubyte* c, GLfloat* v);
        private static TglReplacementCodeuiColor4ubVertex3fvSUN glReplacementCodeuiColor4ubVertex3fvSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiColor3fVertex3fSUN (GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReplacementCodeuiColor3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat x, GLfloat y, GLfloat z);
        private static TglReplacementCodeuiColor3fVertex3fSUN glReplacementCodeuiColor3fVertex3fSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiColor3fVertex3fvSUN (const GLuint *rc, const GLfloat *c, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReplacementCodeuiColor3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* v);
        private static TglReplacementCodeuiColor3fVertex3fvSUN glReplacementCodeuiColor3fVertex3fvSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiNormal3fVertex3fSUN (GLuint rc, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReplacementCodeuiNormal3fVertex3fSUN(GLuint rc, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        private static TglReplacementCodeuiNormal3fVertex3fSUN glReplacementCodeuiNormal3fVertex3fSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiNormal3fVertex3fvSUN (const GLuint *rc, const GLfloat *n, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReplacementCodeuiNormal3fVertex3fvSUN(GLuint* rc, GLfloat* n, GLfloat* v);
        private static TglReplacementCodeuiNormal3fVertex3fvSUN glReplacementCodeuiNormal3fVertex3fvSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiColor4fNormal3fVertex3fSUN (GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReplacementCodeuiColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        private static TglReplacementCodeuiColor4fNormal3fVertex3fSUN glReplacementCodeuiColor4fNormal3fVertex3fSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiColor4fNormal3fVertex3fvSUN (const GLuint *rc, const GLfloat *c, const GLfloat *n, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReplacementCodeuiColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* c, GLfloat* n, GLfloat* v);
        private static TglReplacementCodeuiColor4fNormal3fVertex3fvSUN glReplacementCodeuiColor4fNormal3fVertex3fvSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiTexCoord2fVertex3fSUN (GLuint rc, GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReplacementCodeuiTexCoord2fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat x, GLfloat y, GLfloat z);
        private static TglReplacementCodeuiTexCoord2fVertex3fSUN glReplacementCodeuiTexCoord2fVertex3fSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiTexCoord2fVertex3fvSUN (const GLuint *rc, const GLfloat *tc, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReplacementCodeuiTexCoord2fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* v);
        private static TglReplacementCodeuiTexCoord2fVertex3fvSUN glReplacementCodeuiTexCoord2fVertex3fvSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN (GLuint rc, GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        private static TglReplacementCodeuiTexCoord2fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN (const GLuint *rc, const GLfloat *tc, const GLfloat *n, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* n, GLfloat* v);
        private static TglReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN (GLuint rc, GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(GLuint rc, GLfloat s, GLfloat t, GLfloat r, GLfloat g, GLfloat b, GLfloat a, GLfloat nx, GLfloat ny, GLfloat nz, GLfloat x, GLfloat y, GLfloat z);
        private static TglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN = null;

        // GLAPI void APIENTRY glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN (const GLuint *rc, const GLfloat *tc, const GLfloat *c, const GLfloat *n, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(GLuint* rc, GLfloat* tc, GLfloat* c, GLfloat* n, GLfloat* v);
        private static TglReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_convolution_border_modes (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_mesh_array
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glDrawMeshArraysSUN (GLenum mode, GLint first, GLsizei count, GLsizei width);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawMeshArraysSUN(GLenum mode, GLint first, GLsizei count, GLsizei width);
        private static TglDrawMeshArraysSUN glDrawMeshArraysSUN = null;

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_slice_accum (no function entry points)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SUNX_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SUNX_xxx FUNCTIONS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SUNX_constant_data
        ///////////////////////////////////////////////////////////////////////
        // GLAPI void APIENTRY glFinishTextureSUNX (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFinishTextureSUNX();
        private static TglFinishTextureSUNX glFinishTextureSUNX = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_WIN_xxx FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region GL_WIN_xxx FUNCTIONS...
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
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglAddSwapHintRectWIN(GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglAddSwapHintRectWIN glAddSwapHintRectWIN = null;

        #endregion
    }
}
