// ----------------------------------------------------------------------------
// FILE		: gl.coredelegates.cs
// VERSION	: 1.1.1
// COMMENT	: OpenGL Core Profile library low level delegates and functions.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2017
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
        // OPENGL CORE v1.1 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v1.1 FUNCTIONS...
        // GLproc (void, glAccum, (GLenum op, GLfloat value))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglAccum(GLenum op, GLfloat value);
        private static TglAccum glAccum = null;

        // GLproc (void, glAlphaFunc, (GLenum func, GLclampf ref))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglAlphaFunc(GLenum func, GLclampf reference);
        private static TglAlphaFunc glAlphaFunc = null;

        // GLproc (GLboolean, glAreTexturesResident, (GLsizei n, const GLuint *textures, GLboolean *residences))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate bool TglAreTexturesResident(GLsizei n, GLuint* textures, GLboolean* residences);
        private static TglAreTexturesResident glAreTexturesResident = null;

        // GLproc (void, glArrayElement, (GLint i))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglArrayElement(GLint i);
        private static TglArrayElement glArrayElement = null;

        // GLproc (void, glBegin, (GLenum mode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBegin(GLenum mode);
        private static TglBegin glBegin = null;

        // GLproc (void, glBindTexture, (GLenum target, GLuint texture))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindTexture(GLenum target, GLuint texture);
        private static TglBindTexture glBindTexture = null;

        // GLproc (void, glBitmap, (GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, const GLubyte *bitmap))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBitmap(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, GLubyte* bitmap);
        private static TglBitmap glBitmap = null;

        // GLproc (void, glBlendFunc, (GLenum sfactor, GLenum dfactor))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendFunc(GLenum sfactor, GLenum dfactor);
        private static TglBlendFunc glBlendFunc = null;

        // GLproc (void, glCallList, (GLuint list))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCallList(GLuint list);
        private static TglCallList glCallList = null;

        // GLproc (void, glCallLists, (GLsizei n, GLenum type, const GLvoid *lists))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCallLists(GLsizei n, GLenum type, void* lists);
        private static TglCallLists glCallLists = null;

        // GLproc (void, glClear, (GLbitfield mask))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClear(GLbitfield mask);
        private static TglClear glClear = null;

        // GLproc (void, glClearAccum, (GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearAccum(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
        private static TglClearAccum glClearAccum = null;

        // GLproc (void, glClearColor, (GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
        private static TglClearColor glClearColor = null;

        // GLproc (void, glClearDepth, (GLclampd depth))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearDepth(GLclampd depth);
        private static TglClearDepth glClearDepth = null;

        // GLproc (void, glClearIndex, (GLfloat c))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearIndex(GLfloat c);
        private static TglClearIndex glClearIndex = null;

        // GLproc (void, glClearStencil, (GLint s))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearStencil(GLint s);
        private static TglClearStencil glClearStencil = null;

        // GLproc (void, glClipPlane,	(GLenum plane, const GLdouble *equation))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClipPlane(GLenum plane, GLdouble* equation);
        private static TglClipPlane glClipPlane = null;

        // GLproc (void, glColor3b,	(GLbyte red, GLbyte green, GLbyte blue))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor3b(GLbyte red, GLbyte green, GLbyte blue);
        private static TglColor3b glColor3b = null;

        // GLproc (void, glColor3bv, (const GLbyte *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor3bv(GLbyte* v);
        private static TglColor3bv glColor3bv = null;

        // GLproc (void, glColor3d,	(GLdouble red, GLdouble green, GLdouble blue))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor3d(GLdouble red, GLdouble green, GLdouble blue);
        private static TglColor3d glColor3d = null;

        // GLproc (void, glColor3dv, (const GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor3dv(GLdouble* v);
        private static TglColor3dv glColor3dv = null;

        // GLproc (void, glColor3f,	(GLfloat red, GLfloat green, GLfloat blue))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor3f(GLfloat red, GLfloat green, GLfloat blue);
        private static TglColor3f glColor3f = null;

        // GLproc (void, glColor3fv, (const GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor3fv(GLfloat* v);
        private static TglColor3fv glColor3fv = null;

        // GLproc (void, glColor3i,	(GLint red, GLint green, GLint blue))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor3i(GLint red, GLint green, GLint blue);
        private static TglColor3i glColor3i = null;

        // GLproc (void, glColor3iv, (const GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor3iv(GLint* v);
        private static TglColor3iv glColor3iv = null;

        // GLproc (void, glColor3s,	(GLshort red, GLshort green, GLshort blue))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor3s(GLshort red, GLshort green, GLshort blue);
        private static TglColor3s glColor3s = null;

        // GLproc (void, glColor3sv, (const GLshort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor3sv(GLshort* v);
        private static TglColor3sv glColor3sv = null;

        // GLproc (void, glColor3ub, (GLubyte red, GLubyte green, GLubyte blue))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor3ub(GLubyte red, GLubyte green, GLubyte blue);
        private static TglColor3ub glColor3ub = null;

        // GLproc (void, glColor3ubv, (const GLubyte *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor3ubv(GLubyte* v);
        private static TglColor3ubv glColor3ubv = null;

        // GLproc (void, glColor3ui, (GLuint red, GLuint green, GLuint blue))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor3ui(GLuint red, GLuint green, GLuint blue);
        private static TglColor3ui glColor3ui = null;

        // GLproc (void, glColor3uiv, (const GLuint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor3uiv(GLuint* v);
        private static TglColor3uiv glColor3uiv = null;

        // GLproc (void, glColor3us, (GLushort red, GLushort green, GLushort blue))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor3us(GLushort red, GLushort green, GLushort blue);
        private static TglColor3us glColor3us = null;

        // GLproc (void, glColor3usv, (const GLushort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor3usv(GLushort* v);
        private static TglColor3usv glColor3usv = null;

        // GLproc (void, glColor4b, (GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor4b(GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha);
        private static TglColor4b glColor4b = null;

        // GLproc (void, glColor4bv, (const GLbyte *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor4bv(GLbyte* v);
        private static TglColor4bv glColor4bv = null;

        // GLproc (void, glColor4d,	(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor4d(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha);
        private static TglColor4d glColor4d = null;

        // GLproc (void, glColor4dv, (const GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor4dv(GLdouble* v);
        private static TglColor4dv glColor4dv = null;

        // GLproc (void, glColor4f,	(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor4f(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);
        private static TglColor4f glColor4f = null;

        // GLproc (void, glColor4fv, (const GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor4fv(GLfloat* v);
        private static TglColor4fv glColor4fv = null;

        // GLproc (void, glColor4i,	(GLint red, GLint green, GLint blue, GLint alpha))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor4i(GLint red, GLint green, GLint blue, GLint alpha);
        private static TglColor4i glColor4i = null;

        // GLproc (void, glColor4iv, (const GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor4iv(GLint* v);
        private static TglColor4iv glColor4iv = null;

        // GLproc (void, glColor4s,	(GLshort red, GLshort green, GLshort blue, GLshort alpha))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor4s(GLshort red, GLshort green, GLshort blue, GLshort alpha);
        private static TglColor4s glColor4s = null;

        // GLproc (void, glColor4sv, (const GLshort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor4sv(GLshort* v);
        private static TglColor4sv glColor4sv = null;

        // GLproc (void, glColor4ub, (GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor4ub(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha);
        private static TglColor4ub glColor4ub = null;

        // GLproc (void, glColor4ubv, (const GLubyte *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor4ubv(GLubyte* v);
        private static TglColor4ubv glColor4ubv = null;

        // GLproc (void, glColor4ui, (GLuint red, GLuint green, GLuint blue, GLuint alpha))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor4ui(GLuint red, GLuint green, GLuint blue, GLuint alpha);
        private static TglColor4ui glColor4ui = null;

        // GLproc (void, glColor4uiv, (const GLuint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor4uiv(GLuint* v);
        private static TglColor4uiv glColor4uiv = null;

        // GLproc (void, glColor4us, (GLushort red, GLushort green, GLushort blue, GLushort alpha))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColor4us(GLushort red, GLushort green, GLushort blue, GLushort alpha);
        private static TglColor4us glColor4us = null;

        // GLproc (void, glColor4usv, (const GLushort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColor4usv(GLushort* v);
        private static TglColor4usv glColor4usv = null;

        // GLproc (void, glColorMask, (GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);
        private static TglColorMask glColorMask = null;

        // GLproc (void, glColorMaterial,	(GLenum face, GLenum mode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColorMaterial(GLenum face, GLenum mode);
        private static TglColorMaterial glColorMaterial = null;

        // GLproc (void, glColorPointer,	(GLint size, GLenum type, GLsizei stride, const GLvoid *pointer))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorPointer(GLint size, GLenum type, GLsizei stride, void* pointer);
        private static TglColorPointer glColorPointer = null;

        // GLproc (void, glCopyPixels, (GLint x, GLint y, GLsizei width, GLsizei height, GLenum type))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum type);
        private static TglCopyPixels glCopyPixels = null;

        // GLproc (void, glCopyTexImage1D, (GLenum target, GLint level, GLenum internalFormat, GLint x, GLint y, GLsizei width, GLint border))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTexImage1D(GLenum target, GLint level, GLenum internalFormat, GLint x, GLint y, GLsizei width, GLint border);
        private static TglCopyTexImage1D glCopyTexImage1D = null;

        // GLproc (void, glCopyTexImage2D, (GLenum target, GLint level, GLenum internalFormat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTexImage2D(GLenum target, GLint level, GLenum internalFormat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);
        private static TglCopyTexImage2D glCopyTexImage2D = null;

        // GLproc (void, glCopyTexSubImage1D, (GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        private static TglCopyTexSubImage1D glCopyTexSubImage1D = null;

        // GLproc (void, glCopyTexSubImage2D, (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglCopyTexSubImage2D glCopyTexSubImage2D = null;

        // GLproc (void, glCullFace,	(GLenum mode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCullFace(GLenum mode);
        private static TglCullFace glCullFace = null;

        // GLproc (void, glDeleteLists,	(GLuint list, GLsizei range))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDeleteLists(GLuint list, GLsizei range);
        private static TglDeleteLists glDeleteLists = null;

        // GLproc (void, glDeleteTextures, (GLsizei n, const GLuint *textures))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteTextures(GLsizei n, GLuint* textures);
        private static TglDeleteTextures glDeleteTextures = null;

        // GLproc (void, glDepthFunc,	(GLenum func))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDepthFunc(GLenum func);
        private static TglDepthFunc glDepthFunc = null;

        // GLproc (void, glDepthMask,	(GLboolean flag))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDepthMask(GLboolean flag);
        private static TglDepthMask glDepthMask = null;

        // GLproc (void, glDepthRange, (GLclampd zNear, GLclampd zFar))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDepthRange(GLclampd zNear, GLclampd zFar);
        private static TglDepthRange glDepthRange = null;

        // GLproc (void, glDisable,	(GLenum cap))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDisable(GLenum cap);
        private static TglDisable glDisable = null;

        // GLproc (void, glDisableClientState, (GLenum array))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDisableClientState(GLenum array);
        private static TglDisableClientState glDisableClientState = null;

        // GLproc (void, glDrawArrays, (GLenum mode, GLint first, GLsizei count))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawArrays(GLenum mode, GLint first, GLsizei count);
        private static TglDrawArrays glDrawArrays = null;

        // GLproc (void, glDrawBuffer, (GLenum mode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawBuffer(GLenum mode);
        private static TglDrawBuffer glDrawBuffer = null;

        // GLproc (void, glDrawElements, (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawElements(GLenum mode, GLsizei count, GLenum type, void* indices);
        private static TglDrawElements glDrawElements = null;

        // GLproc (void, glDrawPixels,	(GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *pixels))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawPixels(GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);
        private static TglDrawPixels glDrawPixels = null;

        // GLproc (void, glEdgeFlag,	(GLboolean flag))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEdgeFlag(GLboolean flag);
        private static TglEdgeFlag glEdgeFlag = null;

        // GLproc (void, glEdgeFlagPointer, (GLsizei stride, const GLvoid *pointer))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglEdgeFlagPointer(GLsizei stride, void* pointer);
        private static TglEdgeFlagPointer glEdgeFlagPointer = null;

        // GLproc (void, glEdgeFlagv,	(const GLboolean *flag))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglEdgeFlagv(GLboolean* flag);
        private static TglEdgeFlagv glEdgeFlagv = null;

        // GLproc (void, glEnable,		(GLenum cap))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEnable(GLenum cap);
        private static TglEnable glEnable = null;

        // GLproc (void, glEnableClientState, (GLenum array))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEnableClientState(GLenum array);
        private static TglEnableClientState glEnableClientState = null;

        // GLproc (void, glEnd,		(void))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEnd();
        private static TglEnd glEnd = null;

        // GLproc (void, glEndList,	(void))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndList();
        private static TglEndList glEndList = null;

        // GLproc (void, glEvalCoord1d,	(GLdouble u))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEvalCoord1d(GLdouble u);
        private static TglEvalCoord1d glEvalCoord1d = null;

        // GLproc (void, glEvalCoord1dv,	(const GLdouble *u))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglEvalCoord1dv(GLdouble* u);
        private static TglEvalCoord1dv glEvalCoord1dv = null;

        // GLproc (void, glEvalCoord1f,	(GLfloat u))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEvalCoord1f(GLfloat u);
        private static TglEvalCoord1f glEvalCoord1f = null;

        // GLproc (void, glEvalCoord1fv,	(const GLfloat *u))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglEvalCoord1fv(GLfloat* u);
        private static TglEvalCoord1fv glEvalCoord1fv = null;

        // GLproc (void, glEvalCoord2d,	(GLdouble u, GLdouble v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEvalCoord2d(GLdouble u, GLdouble v);
        private static TglEvalCoord2d glEvalCoord2d = null;

        // GLproc (void, glEvalCoord2dv,	(const GLdouble *u))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglEvalCoord2dv(GLdouble* u);
        private static TglEvalCoord2dv glEvalCoord2dv = null;

        // GLproc (void, glEvalCoord2f,	(GLfloat u, GLfloat v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEvalCoord2f(GLfloat u, GLfloat v);
        private static TglEvalCoord2f glEvalCoord2f = null;

        // GLproc (void, glEvalCoord2fv,	(const GLfloat *u))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglEvalCoord2fv(GLfloat* u);
        private static TglEvalCoord2fv glEvalCoord2fv = null;

        // GLproc (void, glEvalMesh1,	(GLenum mode, GLint i1, GLint i2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEvalMesh1(GLenum mode, GLint i1, GLint i2);
        private static TglEvalMesh1 glEvalMesh1 = null;

        // GLproc (void, glEvalMesh2,	(GLenum mode, GLint i1, GLint i2, GLint j1, GLint j2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEvalMesh2(GLenum mode, GLint i1, GLint i2, GLint j1, GLint j2);
        private static TglEvalMesh2 glEvalMesh2 = null;

        // GLproc (void, glEvalPoint1, (GLint i))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEvalPoint1(GLint i);
        private static TglEvalPoint1 glEvalPoint1 = null;

        // GLproc (void, glEvalPoint2, (GLint i, GLint j))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEvalPoint2(GLint i, GLint j);
        private static TglEvalPoint2 glEvalPoint2 = null;

        // GLproc (void, glFeedbackBuffer, (GLsizei size, GLenum type, GLfloat *buffer))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFeedbackBuffer(GLsizei size, GLenum type, GLfloat* buffer);
        private static TglFeedbackBuffer glFeedbackBuffer = null;

        // GLproc (void, glFinish,		(void))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFinish();
        private static TglFinish glFinish = null;

        // GLproc (void, glFlush,		(void))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFlush();
        private static TglFlush glFlush = null;

        // GLproc (void, glFogf,		(GLenum pname, GLfloat param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFogf(GLenum pname, GLfloat param);
        private static TglFogf glFogf = null;

        // GLproc (void, glFogfv,		(GLenum pname, const GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFogfv(GLenum pname, GLfloat* parameters);
        private static TglFogfv glFogfv = null;

        // GLproc (void, glFogi,		(GLenum pname, GLint param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFogi(GLenum pname, GLint param);
        private static TglFogi glFogi = null;

        // GLproc (void, glFogiv,		(GLenum pname, const GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFogiv(GLenum pname, GLint* parameters);
        private static TglFogiv glFogiv = null;

        // GLproc (void, glFrontFace,	(GLenum mode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFrontFace(GLenum mode);
        private static TglFrontFace glFrontFace = null;

        // GLproc (void, glFrustum,	(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFrustum(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
        private static TglFrustum glFrustum = null;

        // GLproc (GLuint, glGenLists, (GLsizei range))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglGenLists(GLsizei range);
        private static TglGenLists glGenLists;

        // GLproc (void, glGenTextures, (GLsizei n, GLuint *textures))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenTextures(GLsizei n, GLuint* textures);
        private static TglGenTextures glGenTextures = null;

        // GLproc (void, glGetBooleanv, (GLenum pname, GLboolean *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetBooleanv(GLenum pname, GLboolean* parameters);
        private static TglGetBooleanv glGetBooleanv = null;

        // GLproc (void, glGetClipPlane, (GLenum plane, GLdouble *equation))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetClipPlane(GLenum plane, GLdouble* equation);
        private static TglGetClipPlane glGetClipPlane = null;

        // GLproc (void, glGetDoublev, (GLenum pname, GLdouble *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetDoublev(GLenum pname, GLdouble* parameters);
        private static TglGetDoublev glGetDoublev = null;

        // GLproc (GLenum, glGetError, (void))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLenum TglGetError();
        private static TglGetError glGetError = null;

        // GLproc (void, glGetFloatv,	(GLenum pname, GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFloatv (GLenum pname, GLfloat* parameters);
        private static TglGetFloatv glGetFloatv = null;

        // GLproc (void, glGetIntegerv, (GLenum pname, GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetIntegerv(GLenum pname, GLint* parameters);
        private static TglGetIntegerv glGetIntegerv = null;

        // GLproc (void, glGetLightfv, (GLenum light, GLenum pname, GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetLightfv(GLenum light, GLenum pname, GLfloat* parameters);
        private static TglGetLightfv glGetLightfv = null;

        // GLproc (void, glGetLightiv, (GLenum light, GLenum pname, GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetLightiv(GLenum light, GLenum pname, GLint* parameters);
        private static TglGetLightiv glGetLightiv = null;

        // GLproc (void, glGetMapdv,	(GLenum target, GLenum query, GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMapdv(GLenum target, GLenum query, GLdouble* v);
        private static TglGetMapdv glGetMapdv = null;

        // GLproc (void, glGetMapfv,	(GLenum target, GLenum query, GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMapfv(GLenum target, GLenum query, GLfloat* v);
        private static TglGetMapfv glGetMapfv = null;

        // GLproc (void, glGetMapiv,	(GLenum target, GLenum query, GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMapiv (GLenum target, GLenum query, GLint* v);
        private static TglGetMapiv glGetMapiv = null;

        // GLproc (void, glGetMaterialfv, (GLenum face, GLenum pname, GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMaterialfv (GLenum face, GLenum pname, GLfloat* parameters);
        private static TglGetMaterialfv glGetMaterialfv = null;
        
        // GLproc (void, glGetMaterialiv, (GLenum face, GLenum pname, GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMaterialiv (GLenum face, GLenum pname, GLint* parameters);
        private static TglGetMaterialiv glGetMaterialiv = null;
        
        // GLproc (void, glGetPixelMapfv, (GLenum map, GLfloat *values))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPixelMapfv (GLenum map, GLfloat* values);
        private static TglGetPixelMapfv glGetPixelMapfv = null;
        
        // GLproc (void, glGetPixelMapuiv, (GLenum map, GLuint *values))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPixelMapuiv (GLenum map, GLuint* values);
        private static TglGetPixelMapuiv glGetPixelMapuiv = null;
        
        // GLproc (void, glGetPixelMapusv, (GLenum map, GLushort *values))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPixelMapusv (GLenum map, GLushort* values);
        private static TglGetPixelMapusv glGetPixelMapusv = null;
        
        // GLproc (void, glGetPointerv, (GLenum pname, GLvoid* *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPointerv (GLenum pname, void* *parameters);
        private static TglGetPointerv glGetPointerv = null;
        
        // GLproc (void, glGetPolygonStipple, (GLubyte *mask))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetPolygonStipple(GLubyte* mask);
        private static TglGetPolygonStipple glGetPolygonStipple = null;
        
        // GLproc (const GLubyte *, glGetString, (GLenum name))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLubyte* TglGetString(GLenum name);
        private static TglGetString glGetString = null;

        // GLproc (void, glGetTexEnvfv, (GLenum target, GLenum pname, GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexEnvfv(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetTexEnvfv glGetTexEnvfv = null;

        // GLproc (void, glGetTexEnviv, (GLenum target, GLenum pname, GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexEnviv(GLenum coord, GLenum pname, GLint* parameters);
        private static TglGetTexEnviv glGetTexEnviv = null;

        // GLproc (void, glGetTexGendv, (GLenum coord, GLenum pname, GLdouble *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexGendv(GLenum coord, GLenum pname, GLdouble* parameters);
        private static TglGetTexGendv glGetTexGendv = null;

        // GLproc (void, glGetTexGenfv, (GLenum coord, GLenum pname, GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexGenfv(GLenum coord, GLenum pname, GLfloat* parameters);
        private static TglGetTexGenfv glGetTexGenfv = null;

        // GLproc (void, glGetTexGeniv, (GLenum coord, GLenum pname, GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexGeniv(GLenum coord, GLenum pname, GLint* parameters);
        private static TglGetTexGeniv glGetTexGeniv = null;

        // GLproc (void, glGetTexImage, (GLenum target, GLint level, GLenum format, GLenum type, GLvoid *pixels))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexImage(GLenum target, GLint level, GLenum format, GLenum type, void* pixels);
        private static TglGetTexImage glGetTexImage = null;

        // GLproc (void, glGetTexLevelParameterfv, (GLenum target, GLint level, GLenum pname, GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexLevelParameterfv(GLenum target, GLint level, GLenum pname, GLfloat* parameters);
        private static TglGetTexLevelParameterfv glGetTexLevelParameterfv = null;

        // GLproc (void, glGetTexLevelParameteriv, (GLenum target, GLint level, GLenum pname, GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexLevelParameteriv(GLenum target, GLint level, GLenum pname, GLint* parameters);
        private static TglGetTexLevelParameteriv glGetTexLevelParameteriv = null;

        // GLproc (void, glGetTexParameterfv, (GLenum target, GLenum pname, GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexParameterfv(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetTexParameterfv glGetTexParameterfv = null;

        // GLproc (void, glGetTexParameteriv, (GLenum target, GLenum pname, GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexParameteriv(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetTexParameteriv glGetTexParameteriv = null;

        // GLproc (void, glHint,		(GLenum target, GLenum mode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglHint(GLenum target, GLenum mode);
        private static TglHint glHint = null;

        // GLproc (void, glIndexMask,	(GLuint mask))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglIndexMask(GLuint mask);
        private static TglIndexMask glIndexMask = null;

        // GLproc (void, glIndexPointer, (GLenum type, GLsizei stride, const GLvoid *pointer))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglIndexPointer(GLenum type, GLsizei stride, void* pointer);
        private static TglIndexPointer glIndexPointer = null;

        // GLproc (void, glIndexd,		(GLdouble c))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglIndexd(GLdouble c);
        private static TglIndexd glIndexd = null;

        // GLproc (void, glIndexdv,	(const GLdouble *c))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglIndexdv (GLdouble* c);
        private static TglIndexdv glIndexdv = null;

        // GLproc (void, glIndexf,		(GLfloat c))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglIndexf(GLfloat c);
        private static TglIndexf glIndexf = null;

        // GLproc (void, glIndexfv,	(const GLfloat *c))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglIndexfv(GLfloat* c);
        private static TglIndexfv glIndexfv = null;

        // GLproc (void, glIndexi,		(GLint c))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglIndexi(GLint c);
        private static TglIndexi glIndexi = null;

        // GLproc (void, glIndexiv,	(const GLint *c))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglIndexiv(GLint* c);
        private static TglIndexiv glIndexiv = null;

        // GLproc (void, glIndexs,		(GLshort c))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglIndexs(GLshort c);
        private static TglIndexs glIndexs = null;

        // GLproc (void, glIndexsv,	(const GLshort *c))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglIndexsv(GLshort* c);
        private static TglIndexsv glIndexsv = null;

        // GLproc (void, glIndexub,	(GLubyte c))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglIndexub(GLubyte c);
        private static TglIndexub glIndexub = null;

        // GLproc (void, glIndexubv,	(const GLubyte *c))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglIndexubv(GLubyte* c);
        private static TglIndexubv glIndexubv = null;

        // GLproc (void, glInitNames,	(void))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglInitNames();
        private static TglInitNames glInitNames = null;

        // GLproc (void, glInterleavedArrays, (GLenum format, GLsizei stride, const GLvoid *pointer))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglInterleavedArrays(GLenum format, GLsizei stride, void* pointer);
        private static TglInterleavedArrays glInterleavedArrays = null;

        // GLproc (GLboolean, glIsEnabled, (GLenum cap))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsEnabled(GLenum cap);
        private static TglIsEnabled glIsEnabled = null;

        // GLproc (GLboolean, glIsList,	(GLuint list))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsList(GLuint list);
        private static TglIsList glIsList = null;

        // GLproc (GLboolean, glIsTexture, (GLuint texture))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsTexture(GLuint texture);
        private static TglIsTexture glIsTexture = null;

        // GLproc (void, glLightModelf,	(GLenum pname, GLfloat param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLightModelf(GLenum pname, GLfloat param);
        private static TglLightModelf glLightModelf = null;

        // GLproc (void, glLightModelfv,	(GLenum pname, const GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLightModelfv(GLenum pname, GLfloat* parameters);
        private static TglLightModelfv glLightModelfv = null;

        // GLproc (void, glLightModeli,	(GLenum pname, GLint param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLightModeli(GLenum pname, GLint param);
        private static TglLightModeli glLightModeli = null;

        // GLproc (void, glLightModeliv,	(GLenum pname, const GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLightModeliv(GLenum pname, GLint* parameters);
        private static TglLightModeliv glLightModeliv = null;

        // GLproc (void, glLightf,			(GLenum light, GLenum pname, GLfloat param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLightf(GLenum light, GLenum pname, GLfloat param);
        private static TglLightf glLightf = null;

        // GLproc (void, glLightfv,		(GLenum light, GLenum pname, const GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLightfv(GLenum light, GLenum pname, GLfloat* parameters);
        private static TglLightfv glLightfv = null;

        // GLproc (void, glLighti,			(GLenum light, GLenum pname, GLint param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLighti(GLenum light, GLenum pname, GLint param);
        private static TglLighti glLighti = null;

        // GLproc (void, glLightiv,		(GLenum light, GLenum pname, const GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLightiv(GLenum light, GLenum pname, GLint* parameters);
        private static TglLightiv glLightiv = null;

        // GLproc (void, glLineStipple,	(GLint factor, GLushort pattern))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLineStipple(GLint factor, GLushort pattern);
        private static TglLineStipple glLineStipple = null;

        // GLproc (void, glLineWidth,		(GLfloat width))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLineWidth(GLfloat width);
        private static TglLineWidth glLineWidth = null;

        // GLproc (void, glListBase,		(GLuint base))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglListBase (GLuint listbase);
        private static TglListBase glListBase = null;

        // GLproc (void, glLoadIdentity,	(void))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLoadIdentity();
        private static TglLoadIdentity glLoadIdentity = null;

        // GLproc (void, glLoadMatrixd,	(const GLdouble *m))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLoadMatrixd(GLdouble* m);
        private static TglLoadMatrixd glLoadMatrixd = null;

        // GLproc (void, glLoadMatrixf,	(const GLfloat *m))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLoadMatrixf(GLfloat* m);
        private static TglLoadMatrixf glLoadMatrixf = null;

        // GLproc (void, glLoadName,		(GLuint name))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLoadName(GLuint name);
        private static TglLoadName glLoadName = null;

        // GLproc (void, glLogicOp,		(GLenum opcode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLogicOp(GLenum opcode);
        private static TglLogicOp glLogicOp = null;

        // GLproc (void, glMap1d,			(GLenum target, GLdouble u1, GLdouble u2, GLint stride, GLint order, const GLdouble *points))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMap1d(GLenum target, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble* points);
        private static TglMap1d glMap1d = null;

        // GLproc (void, glMap1f,			(GLenum target, GLfloat u1, GLfloat u2, GLint stride, GLint order, const GLfloat *points))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMap1f(GLenum target, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat* points);
        private static TglMap1f glMap1f = null;

        // GLproc (void, glMap2d,			(GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, const GLdouble *points))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMap2d(GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble* points);
        private static TglMap2d glMap2d = null;

        // GLproc (void, glMap2f,			(GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, const GLfloat *points))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMap2f(GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat* points);
        private static TglMap2f glMap2f = null;

        // GLproc (void, glMapGrid1d,		(GLint un, GLdouble u1, GLdouble u2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMapGrid1d(GLint un, GLdouble u1, GLdouble u2);
        private static TglMapGrid1d glMapGrid1d = null;

        // GLproc (void, glMapGrid1f,		(GLint un, GLfloat u1, GLfloat u2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMapGrid1f(GLint un, GLfloat u1, GLfloat u2);
        private static TglMapGrid1f glMapGrid1f = null;

        // GLproc (void, glMapGrid2d,		(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMapGrid2d(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2);
        private static TglMapGrid2d glMapGrid2d = null;

        // GLproc (void, glMapGrid2f,		(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMapGrid2f(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2);
        private static TglMapGrid2f glMapGrid2f = null;

        // GLproc (void, glMaterialf,		(GLenum face, GLenum pname, GLfloat param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMaterialf(GLenum face, GLenum pname, GLfloat param);
        private static TglMaterialf glMaterialf = null;

        // GLproc (void, glMaterialfv,		(GLenum face, GLenum pname, const GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMaterialfv(GLenum face, GLenum pname, GLfloat* parameters);
        private static TglMaterialfv glMaterialfv = null;

        // GLproc (void, glMateriali,		(GLenum face, GLenum pname, GLint param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMateriali(GLenum face, GLenum pname, GLint param);
        private static TglMateriali glMateriali = null;

        // GLproc (void, glMaterialiv,		(GLenum face, GLenum pname, const GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMaterialiv(GLenum face, GLenum pname, GLint* parameters);
        private static TglMaterialiv glMaterialiv = null;

        // GLproc (void, glMatrixMode,		(GLenum mode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMatrixMode(GLenum mode);
        private static TglMatrixMode glMatrixMode = null;

        // GLproc (void, glMultMatrixd,	(const GLdouble *m))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultMatrixd(GLdouble* m);
        private static TglMultMatrixd glMultMatrixd = null;

        // GLproc (void, glMultMatrixf,	(const GLfloat *m))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultMatrixf(GLfloat* m);
        private static TglMultMatrixf glMultMatrixf = null;

        // GLproc (void, glNewList,		(GLuint list, GLenum mode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNewList(GLuint list, GLenum mode);
        private static TglNewList glNewList = null;

        // GLproc (void, glNormal3b,		(GLbyte nx, GLbyte ny, GLbyte nz))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormal3b(GLbyte nx, GLbyte ny, GLbyte nz);
        private static TglNormal3b glNormal3b = null;

        // GLproc (void, glNormal3bv,		(const GLbyte *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormal3bv(GLbyte* v);
        private static TglNormal3bv glNormal3bv = null;

        // GLproc (void, glNormal3d,		(GLdouble nx, GLdouble ny, GLdouble nz))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormal3d(GLdouble nx, GLdouble ny, GLdouble nz);
        private static TglNormal3d glNormal3d = null;

        // GLproc (void, glNormal3dv,		(const GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormal3dv(GLdouble* v);
        private static TglNormal3dv glNormal3dv = null;

        // GLproc (void, glNormal3f,		(GLfloat nx, GLfloat ny, GLfloat nz))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormal3f(GLfloat nx, GLfloat ny, GLfloat nz);
        private static TglNormal3f glNormal3f = null;

        // GLproc (void, glNormal3fv,		(const GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormal3fv(GLfloat* v);
        private static TglNormal3fv glNormal3fv = null;

        // GLproc (void, glNormal3i,		(GLint nx, GLint ny, GLint nz))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormal3i(GLint nx, GLint ny, GLint nz);
        private static TglNormal3i glNormal3i = null;

        // GLproc (void, glNormal3iv,		(const GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormal3iv(GLint* v);
        private static TglNormal3iv glNormal3iv = null;

        // GLproc (void, glNormal3s,		(GLshort nx, GLshort ny, GLshort nz))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormal3s(GLshort nx, GLshort ny, GLshort nz);
        private static TglNormal3s glNormal3s = null;

        // GLproc (void, glNormal3sv,		(const GLshort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormal3sv(GLshort* v);
        private static TglNormal3sv glNormal3sv = null;

        // GLproc (void, glNormalPointer,	(GLenum type, GLsizei stride, const GLvoid *pointer))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormalPointer(GLenum type, GLsizei stride, void* pointer);
        private static TglNormalPointer glNormalPointer = null;

        // GLproc (void, glOrtho,			(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglOrtho(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar);
        private static TglOrtho glOrtho = null;

        // GLproc (void, glPassThrough,	(GLfloat token))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPassThrough(GLfloat token);
        private static TglPassThrough glPassThrough = null;

        // GLproc (void, glPixelMapfv,		(GLenum map, GLsizei mapsize, const GLfloat *values))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPixelMapfv(GLenum map, GLsizei mapsize, GLfloat* values);
        private static TglPixelMapfv glPixelMapfv = null;

        // GLproc (void, glPixelMapuiv,	(GLenum map, GLsizei mapsize, const GLuint *values))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPixelMapuiv(GLenum map, GLsizei mapsize, GLuint* values);
        private static TglPixelMapuiv glPixelMapuiv = null;

        // GLproc (void, glPixelMapusv,	(GLenum map, GLsizei mapsize, const GLushort *values))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPixelMapusv(GLenum map, GLsizei mapsize, GLushort* values);
        private static TglPixelMapusv glPixelMapusv = null;

        // GLproc (void, glPixelStoref,	(GLenum pname, GLfloat param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPixelStoref(GLenum pname, GLfloat param);
        private static TglPixelStoref glPixelStoref = null;

        // GLproc (void, glPixelStorei,	(GLenum pname, GLint param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPixelStorei(GLenum pname, GLint param);
        private static TglPixelStorei glPixelStorei = null;

        // GLproc (void, glPixelTransferf, (GLenum pname, GLfloat param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPixelTransferf(GLenum pname, GLfloat param);
        private static TglPixelTransferf glPixelTransferf = null;

        // GLproc (void, glPixelTransferi, (GLenum pname, GLint param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPixelTransferi(GLenum pname, GLint param);
        private static TglPixelTransferi glPixelTransferi = null;

        // GLproc (void, glPixelZoom,		(GLfloat xfactor, GLfloat yfactor))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPixelZoom(GLfloat xfactor, GLfloat yfactor);
        private static TglPixelZoom glPixelZoom = null;

        // GLproc (void, glPointSize,		(GLfloat size))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPointSize(GLfloat size);
        private static TglPointSize glPointSize = null;

        // GLproc (void, glPolygonMode,	(GLenum face, GLenum mode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPolygonMode(GLenum face, GLenum mode);
        private static TglPolygonMode glPolygonMode = null;

        // GLproc (void, glPolygonOffset,	(GLfloat factor, GLfloat units))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPolygonOffset(GLfloat factor, GLfloat units);
        private static TglPolygonOffset glPolygonOffset = null;

        // GLproc (void, glPolygonStipple, (const GLubyte *mask))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPolygonStipple(GLubyte* mask);
        private static TglPolygonStipple glPolygonStipple = null;

        // GLproc (void, glPopAttrib,		(void))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPopAttrib();
        private static TglPopAttrib glPopAttrib = null;

        // GLproc (void, glPopClientAttrib, (void))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPopClientAttrib();
        private static TglPopClientAttrib glPopClientAttrib = null;

        // GLproc (void, glPopMatrix,		(void))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPopMatrix();
        private static TglPopMatrix glPopMatrix = null;

        // GLproc (void, glPopName,		(void))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPopName();
        private static TglPopName glPopName = null;

        // GLproc (void, glPrioritizeTextures, (GLsizei n, const GLuint *textures, const GLclampf *priorities))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPrioritizeTextures(GLsizei n, GLuint* textures, GLclampf* priorities);
        private static TglPrioritizeTextures glPrioritizeTextures = null;

        // GLproc (void, glPushAttrib,		(GLbitfield mask))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPushAttrib(GLbitfield mask);
        private static TglPushAttrib glPushAttrib = null;

        // GLproc (void, glPushClientAttrib, (GLbitfield mask))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPushClientAttrib(GLbitfield mask);
        private static TglPushClientAttrib glPushClientAttrib = null;

        // GLproc (void, glPushMatrix,		(void))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPushMatrix();
        private static TglPushMatrix glPushMatrix = null;

        // GLproc (void, glPushName,		(GLuint name))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPushName(GLuint name);
        private static TglPushName glPushName = null;

        // GLproc (void, glRasterPos2d,	(GLdouble x, GLdouble y))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos2d(GLdouble x, GLdouble y);
        private static TglRasterPos2d glRasterPos2d = null;

        // GLproc (void, glRasterPos2dv,	(const GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos2dv(GLdouble* v);
        private static TglRasterPos2dv glRasterPos2dv = null;

        // GLproc (void, glRasterPos2f,	(GLfloat x, GLfloat y))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos2f(GLfloat x, GLfloat y);
        private static TglRasterPos2f glRasterPos2f = null;

        // GLproc (void, glRasterPos2fv,	(const GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos2fv(GLfloat* v);
        private static TglRasterPos2fv glRasterPos2fv = null;

        // GLproc (void, glRasterPos2i,	(GLint x, GLint y))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos2i(GLint x, GLint y);
        private static TglRasterPos2i glRasterPos2i = null;

        // GLproc (void, glRasterPos2iv,	(const GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos2iv(GLint* v);
        private static TglRasterPos2iv glRasterPos2iv = null;

        // GLproc (void, glRasterPos2s,	(GLshort x, GLshort y))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos2s(GLshort x, GLshort y);
        private static TglRasterPos2s glRasterPos2s = null;

        // GLproc (void, glRasterPos2sv,	(const GLshort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos2sv(GLshort* v);
        private static TglRasterPos2sv glRasterPos2sv = null;

        // GLproc (void, glRasterPos3d,	(GLdouble x, GLdouble y, GLdouble z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos3d(GLdouble x, GLdouble y, GLdouble z);
        private static TglRasterPos3d glRasterPos3d = null;

        // GLproc (void, glRasterPos3dv,	(const GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos3dv(GLdouble* v);
        private static TglRasterPos3dv glRasterPos3dv = null;

        // GLproc (void, glRasterPos3f,	(GLfloat x, GLfloat y, GLfloat z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos3f(GLfloat x, GLfloat y, GLfloat z);
        private static TglRasterPos3f glRasterPos3f = null;

        // GLproc (void, glRasterPos3fv,	(const GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos3fv(GLfloat* v);
        private static TglRasterPos3fv glRasterPos3fv = null;

        // GLproc (void, glRasterPos3i,	(GLint x, GLint y, GLint z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos3i(GLint x, GLint y, GLint z);
        private static TglRasterPos3i glRasterPos3i = null;

        // GLproc (void, glRasterPos3iv,	(const GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos3iv(GLint* v);
        private static TglRasterPos3iv glRasterPos3iv = null;

        // GLproc (void, glRasterPos3s,	(GLshort x, GLshort y, GLshort z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos3s(GLshort x, GLshort y, GLshort z);
        private static TglRasterPos3s glRasterPos3s = null;

        // GLproc (void, glRasterPos3sv,	(const GLshort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos3sv(GLshort* v);
        private static TglRasterPos3sv glRasterPos3sv = null;

        // GLproc (void, glRasterPos4d,	(GLdouble x, GLdouble y, GLdouble z, GLdouble w))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglRasterPos4d glRasterPos4d = null;

        // GLproc (void, glRasterPos4dv,	(const GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos4dv(GLdouble* v);
        private static TglRasterPos4dv glRasterPos4dv = null;

        // GLproc (void, glRasterPos4f,	(GLfloat x, GLfloat y, GLfloat z, GLfloat w))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglRasterPos4f glRasterPos4f = null;

        // GLproc (void, glRasterPos4fv,	(const GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos4fv(GLfloat* v);
        private static TglRasterPos4fv glRasterPos4fv = null;

        // GLproc (void, glRasterPos4i,	(GLint x, GLint y, GLint z, GLint w))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos4i(GLint x, GLint y, GLint z, GLint w);
        private static TglRasterPos4i glRasterPos4i = null;

        // GLproc (void, glRasterPos4iv,	(const GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos4iv(GLint* v);
        private static TglRasterPos4iv glRasterPos4iv = null;

        // GLproc (void, glRasterPos4s,	(GLshort x, GLshort y, GLshort z, GLshort w))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRasterPos4s(GLshort x, GLshort y, GLshort z, GLshort w);
        private static TglRasterPos4s glRasterPos4s = null;

        // GLproc (void, glRasterPos4sv,	(const GLshort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRasterPos4sv(GLshort* v);
        private static TglRasterPos4sv glRasterPos4sv = null;

        // GLproc (void, glReadBuffer,		(GLenum mode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReadBuffer(GLenum mode);
        private static TglReadBuffer glReadBuffer = null;

        // GLproc (void, glReadPixels,		(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid *pixels))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);
        private static TglReadPixels glReadPixels = null;

        // GLproc (void, glRectd,			(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRectd(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2);
        private static TglRectd glRectd = null;

        // GLproc (void, glRectdv,			(const GLdouble *v1, const GLdouble *v2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRectdv(GLdouble* v1, GLdouble* v2);
        private static TglRectdv glRectdv = null;

        // GLproc (void, glRectf,			(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRectf(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2);
        private static TglRectf glRectf = null;

        // GLproc (void, glRectfv,			(const GLfloat *v1, const GLfloat *v2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRectfv(GLfloat* v1, GLfloat* v2);
        private static TglRectfv glRectfv = null;

        // GLproc (void, glRecti,			(GLint x1, GLint y1, GLint x2, GLint y2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRecti(GLint x1, GLint y1, GLint x2, GLint y2);
        private static TglRecti glRecti = null;

        // GLproc (void, glRectiv,			(const GLint *v1, const GLint *v2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRectiv(GLint* v1, GLint* v2);
        private static TglRectiv glRectiv = null;

        // GLproc (void, glRects,			(GLshort x1, GLshort y1, GLshort x2, GLshort y2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRects(GLshort x1, GLshort y1, GLshort x2, GLshort y2);
        private static TglRects glRects = null;

        // GLproc (void, glRectsv,			(const GLshort *v1, const GLshort *v2))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglRectsv(GLshort* v1, GLshort* v2);
        private static TglRectsv glRectsv = null;

        // GLproc (GLint, glRenderMode,	(GLenum mode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRenderMode(GLenum mode);
        private static TglRenderMode glRenderMode = null;

        // GLproc (void, glRotated,		(GLdouble angle, GLdouble x, GLdouble y, GLdouble z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRotated(GLdouble angle, GLdouble x, GLdouble y, GLdouble z);
        private static TglRotated glRotated = null;

        // GLproc (void, glRotatef,		(GLfloat angle, GLfloat x, GLfloat y, GLfloat z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRotatef(GLfloat angle, GLfloat x, GLfloat y, GLfloat z);
        private static TglRotatef glRotatef = null;

        // GLproc (void, glScaled,			(GLdouble x, GLdouble y, GLdouble z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglScaled(GLdouble x, GLdouble y, GLdouble z);
        private static TglScaled glScaled = null;

        // GLproc (void, glScalef,			(GLfloat x, GLfloat y, GLfloat z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglScalef(GLfloat x, GLfloat y, GLfloat z);
        private static TglScalef glScalef = null;

        // GLproc (void, glScissor,		(GLint x, GLint y, GLsizei width, GLsizei height))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglScissor(GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglScissor glScissor = null;

        // GLproc (void, glSelectBuffer,	(GLsizei size, GLuint *buffer))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSelectBuffer(GLsizei size, GLuint* buffer);
        private static TglSelectBuffer glSelectBuffer = null;

        // GLproc (void, glShadeModel,		(GLenum mode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglShadeModel(GLenum mode);
        private static TglShadeModel glShadeModel = null;

        // GLproc (void, glStencilFunc,	(GLenum func, GLint ref, GLuint mask))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStencilFunc(GLenum func, GLint reference, GLuint mask);
        private static TglStencilFunc glStencilFunc = null;

        // GLproc (void, glStencilMask,	(GLuint mask))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStencilMask(GLuint mask);
        private static TglStencilMask glStencilMask = null;

        // GLproc (void, glStencilOp,		(GLenum fail, GLenum zfail, GLenum zpass))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStencilOp(GLenum fail, GLenum zfail, GLenum zpass);
        private static TglStencilOp glStencilOp = null;

        // GLproc (void, glTexCoord1d,		(GLdouble s))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord1d(GLdouble s);
        private static TglTexCoord1d glTexCoord1d = null;

        // GLproc (void, glTexCoord1dv,	(const GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord1dv(GLdouble* v);
        private static TglTexCoord1dv glTexCoord1dv = null;

        // GLproc (void, glTexCoord1f,		(GLfloat s))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord1f(GLfloat s);
        private static TglTexCoord1f glTexCoord1f = null;

        // GLproc (void, glTexCoord1fv,	(const GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord1fv(GLfloat* v);
        private static TglTexCoord1fv glTexCoord1fv = null;

        // GLproc (void, glTexCoord1i,		(GLint s))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord1i(GLint s);
        private static TglTexCoord1i glTexCoord1i = null;

        // GLproc (void, glTexCoord1iv,	(const GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord1iv(GLint* v);
        private static TglTexCoord1iv glTexCoord1iv = null;

        // GLproc (void, glTexCoord1s,		(GLshort s))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord1s(GLshort s);
        private static TglTexCoord1s glTexCoord1s = null;

        // GLproc (void, glTexCoord1sv,	(const GLshort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord1sv(GLshort* v);
        private static TglTexCoord1sv glTexCoord1sv = null;

        // GLproc (void, glTexCoord2d,		(GLdouble s, GLdouble t))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord2d(GLdouble s, GLdouble t);
        private static TglTexCoord2d glTexCoord2d = null;

        // GLproc (void, glTexCoord2dv,	(const GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord2dv(GLdouble* v);
        private static TglTexCoord2dv glTexCoord2dv = null;

        // GLproc (void, glTexCoord2f,		(GLfloat s, GLfloat t))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord2f(GLfloat s, GLfloat t);
        private static TglTexCoord2f glTexCoord2f = null;

        // GLproc (void, glTexCoord2fv,	(const GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord2fv(GLfloat* v);
        private static TglTexCoord2fv glTexCoord2fv = null;

        // GLproc (void, glTexCoord2i,		(GLint s, GLint t))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord2i(GLint s, GLint t);
        private static TglTexCoord2i glTexCoord2i = null;

        // GLproc (void, glTexCoord2iv,	(const GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord2iv(GLint* v);
        private static TglTexCoord2iv glTexCoord2iv = null;

        // GLproc (void, glTexCoord2s,		(GLshort s, GLshort t))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord2s(GLshort s, GLshort t);
        private static TglTexCoord2s glTexCoord2s = null;

        // GLproc (void, glTexCoord2sv,	(const GLshort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord2sv(GLshort* v);
        private static TglTexCoord2sv glTexCoord2sv = null;

        // GLproc (void, glTexCoord3d,		(GLdouble s, GLdouble t, GLdouble r))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord3d(GLdouble s, GLdouble t, GLdouble r);
        private static TglTexCoord3d glTexCoord3d = null;

        // GLproc (void, glTexCoord3dv,	(const GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord3dv(GLdouble* v);
        private static TglTexCoord3dv glTexCoord3dv = null;

        // GLproc (void, glTexCoord3f,		(GLfloat s, GLfloat t, GLfloat r))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord3f(GLfloat s, GLfloat t, GLfloat r);
        private static TglTexCoord3f glTexCoord3f = null;

        // GLproc (void, glTexCoord3fv,	(const GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord3fv(GLfloat* v);
        private static TglTexCoord3fv glTexCoord3fv = null;

        // GLproc (void, glTexCoord3i,		(GLint s, GLint t, GLint r))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord3i(GLint s, GLint t, GLint r);
        private static TglTexCoord3i glTexCoord3i = null;

        // GLproc (void, glTexCoord3iv,	(const GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord3iv(GLint* v);
        private static TglTexCoord3iv glTexCoord3iv = null;

        // GLproc (void, glTexCoord3s,		(GLshort s, GLshort t, GLshort r))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord3s(GLshort s, GLshort t, GLshort r);
        private static TglTexCoord3s glTexCoord3s = null;

        // GLproc (void, glTexCoord3sv,	(const GLshort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord3sv(GLshort* v);
        private static TglTexCoord3sv glTexCoord3sv = null;

        // GLproc (void, glTexCoord4d,		(GLdouble s, GLdouble t, GLdouble r, GLdouble q))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord4d(GLdouble s, GLdouble t, GLdouble r, GLdouble q);
        private static TglTexCoord4d glTexCoord4d = null;

        // GLproc (void, glTexCoord4dv,	(const GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord4dv(GLdouble* v);
        private static TglTexCoord4dv glTexCoord4dv = null;

        // GLproc (void, glTexCoord4f,		(GLfloat s, GLfloat t, GLfloat r, GLfloat q))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord4f(GLfloat s, GLfloat t, GLfloat r, GLfloat q);
        private static TglTexCoord4f glTexCoord4f = null;

        // GLproc (void, glTexCoord4fv,	(const GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord4fv(GLfloat* v);
        private static TglTexCoord4fv glTexCoord4fv = null;

        // GLproc (void, glTexCoord4i,		(GLint s, GLint t, GLint r, GLint q))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord4i(GLint s, GLint t, GLint r, GLint q);
        private static TglTexCoord4i glTexCoord4i = null;

        // GLproc (void, glTexCoord4iv,	(const GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord4iv(GLint* v);
        private static TglTexCoord4iv glTexCoord4iv = null;

        // GLproc (void, glTexCoord4s,		(GLshort s, GLshort t, GLshort r, GLshort q))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoord4s(GLshort s, GLshort t, GLshort r, GLshort q);
        private static TglTexCoord4s glTexCoord4s = null;

        // GLproc (void, glTexCoord4sv,	(const GLshort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoord4sv(GLshort* v);
        private static TglTexCoord4sv glTexCoord4sv = null;

        // GLproc (void, glTexCoordPointer, (GLint size, GLenum type, GLsizei stride, const GLvoid *pointer))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoordPointer(GLint size, GLenum type, GLsizei stride, void* pointer);
        private static TglTexCoordPointer glTexCoordPointer = null;

        // GLproc (void, glTexEnvf,		(GLenum target, GLenum pname, GLfloat param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexEnvf(GLenum target, GLenum pname, GLfloat param);
        private static TglTexEnvf glTexEnvf = null;

        // GLproc (void, glTexEnvfv,		(GLenum target, GLenum pname, const GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexEnvfv(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglTexEnvfv glTexEnvfv = null;

        // GLproc (void, glTexEnvi,		(GLenum target, GLenum pname, GLint param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexEnvi(GLenum target, GLenum pname, GLint param);
        private static TglTexEnvi glTexEnvi = null;

        // GLproc (void, glTexEnviv,		(GLenum target, GLenum pname, const GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexEnviv(GLenum target, GLenum pname, GLint* parameters);
        private static TglTexEnviv glTexEnviv = null;

        // GLproc (void, glTexGend,		(GLenum coord, GLenum pname, GLdouble param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexGend(GLenum coord, GLenum pname, GLdouble param);
        private static TglTexGend glTexGend = null;

        // GLproc (void, glTexGendv,		(GLenum coord, GLenum pname, const GLdouble *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexGendv(GLenum coord, GLenum pname, GLdouble* parameters);
        private static TglTexGendv glTexGendv = null;

        // GLproc (void, glTexGenf,		(GLenum coord, GLenum pname, GLfloat param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexGenf(GLenum coord, GLenum pname, GLfloat param);
        private static TglTexGenf glTexGenf = null;

        // GLproc (void, glTexGenfv,		(GLenum coord, GLenum pname, const GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexGenfv(GLenum coord, GLenum pname, GLfloat* parameters);
        private static TglTexGenfv glTexGenfv = null;

        // GLproc (void, glTexGeni,		(GLenum coord, GLenum pname, GLint param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexGeni(GLenum coord, GLenum pname, GLint param);
        private static TglTexGeni glTexGeni = null;

        // GLproc (void, glTexGeniv,		(GLenum coord, GLenum pname, const GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexGeniv(GLenum coord, GLenum pname, GLint* parameters);
        private static TglTexGeniv glTexGeniv = null;

        // GLproc (void, glTexImage1D,		(GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, const GLvoid *pixels))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexImage1D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, void* pixels);
        private static TglTexImage1D glTexImage1D = null;

        // GLproc (void, glTexImage2D,		(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, const GLvoid *pixels))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, void* pixels);
        private static TglTexImage2D glTexImage2D = null;

        // GLproc (void, glTexParameterf,	(GLenum target, GLenum pname, GLfloat param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexParameterf(GLenum target, GLenum pname, GLfloat param);
        private static TglTexParameterf glTexParameterf = null;

        // GLproc (void, glTexParameterfv, (GLenum target, GLenum pname, const GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexParameterfv(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglTexParameterfv glTexParameterfv = null;

        // GLproc (void, glTexParameteri,	(GLenum target, GLenum pname, GLint param))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexParameteri(GLenum target, GLenum pname, GLint param);
        private static TglTexParameteri glTexParameteri = null;

        // GLproc (void, glTexParameteriv, (GLenum target, GLenum pname, const GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexParameteriv(GLenum target, GLenum pname, GLint* parameters);
        private static TglTexParameteriv glTexParameteriv = null;

        // GLproc (void, glTexSubImage1D,	(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, const GLvoid *pixels))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);
        private static TglTexSubImage1D glTexSubImage1D = null;

        // GLproc (void, glTexSubImage2D,	(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *pixels))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);
        private static TglTexSubImage2D glTexSubImage2D = null;

        // GLproc (void, glTranslated,		(GLdouble x, GLdouble y, GLdouble z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTranslated(GLdouble x, GLdouble y, GLdouble z);
        private static TglTranslated glTranslated = null;

        // GLproc (void, glTranslatef,		(GLfloat x, GLfloat y, GLfloat z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTranslatef(GLfloat x, GLfloat y, GLfloat z);
        private static TglTranslatef glTranslatef = null;

        // GLproc (void, glVertex2d,		(GLdouble x, GLdouble y))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex2d(GLdouble x, GLdouble y);
        private static TglVertex2d glVertex2d = null;

        // GLproc (void, glVertex2dv,		(const GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex2dv(GLdouble* v);
        private static TglVertex2dv glVertex2dv = null;

        // GLproc (void, glVertex2f,		(GLfloat x, GLfloat y))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex2f(GLfloat x, GLfloat y);
        private static TglVertex2f glVertex2f = null;

        // GLproc (void, glVertex2fv,		(const GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex2fv(GLfloat* v);
        private static TglVertex2fv glVertex2fv = null;

        // GLproc (void, glVertex2i,		(GLint x, GLint y))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex2i(GLint x, GLint y);
        private static TglVertex2i glVertex2i = null;

        // GLproc (void, glVertex2iv,		(const GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex2iv(GLint* v);
        private static TglVertex2iv glVertex2iv = null;

        // GLproc (void, glVertex2s,		(GLshort x, GLshort y))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex2s(GLshort x, GLshort y);
        private static TglVertex2s glVertex2s = null;

        // GLproc (void, glVertex2sv,		(const GLshort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex2sv(GLshort* v);
        private static TglVertex2sv glVertex2sv = null;

        // GLproc (void, glVertex3d,		(GLdouble x, GLdouble y, GLdouble z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex3d(GLdouble x, GLdouble y, GLdouble z);
        private static TglVertex3d glVertex3d = null;

        // GLproc (void, glVertex3dv,		(const GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex3dv(GLdouble* v);
        private static TglVertex3dv glVertex3dv = null;

        // GLproc (void, glVertex3f,		(GLfloat x, GLfloat y, GLfloat z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex3f(GLfloat x, GLfloat y, GLfloat z);
        private static TglVertex3f glVertex3f = null;

        // GLproc (void, glVertex3fv,		(const GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex3fv(GLfloat* v);
        private static TglVertex3fv glVertex3fv = null;

        // GLproc (void, glVertex3i,		(GLint x, GLint y, GLint z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex3i(GLint x, GLint y, GLint z);
        private static TglVertex3i glVertex3i = null;

        // GLproc (void, glVertex3iv,		(const GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex3iv(GLint* v);
        private static TglVertex3iv glVertex3iv = null;

        // GLproc (void, glVertex3s,		(GLshort x, GLshort y, GLshort z))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex3s(GLshort x, GLshort y, GLshort z);
        private static TglVertex3s glVertex3s = null;

        // GLproc (void, glVertex3sv,		(const GLshort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex3sv(GLshort* v);
        private static TglVertex3sv glVertex3sv = null;

        // GLproc (void, glVertex4d,		(GLdouble x, GLdouble y, GLdouble z, GLdouble w))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglVertex4d glVertex4d = null;

        // GLproc (void, glVertex4dv,		(const GLdouble *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex4dv(GLdouble* v);
        private static TglVertex4dv glVertex4dv = null;

        // GLproc (void, glVertex4f,		(GLfloat x, GLfloat y, GLfloat z, GLfloat w))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglVertex4f glVertex4f = null;

        // GLproc (void, glVertex4fv,		(const GLfloat *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex4fv(GLfloat* v);
        private static TglVertex4fv glVertex4fv = null;

        // GLproc (void, glVertex4i,		(GLint x, GLint y, GLint z, GLint w))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex4i(GLint x, GLint y, GLint z, GLint w);
        private static TglVertex4i glVertex4i = null;

        // GLproc (void, glVertex4iv,		(const GLint *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex4iv(GLint* v);
        private static TglVertex4iv glVertex4iv = null;

        // GLproc (void, glVertex4s,		(GLshort x, GLshort y, GLshort z, GLshort w))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertex4s(GLshort x, GLshort y, GLshort z, GLshort w);
        private static TglVertex4s glVertex4s = null;

        // GLproc (void, glVertex4sv,		(const GLshort *v))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertex4sv(GLshort* v);
        private static TglVertex4sv glVertex4sv = null;

        // GLproc (void, glVertexPointer,	(GLint size, GLenum type, GLsizei stride, const GLvoid *pointer))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexPointer(GLint size, GLenum type, GLsizei stride, void* pointer);
        private static TglVertexPointer glVertexPointer = null;

        // GLproc (void, glViewport,		(GLint x, GLint y, GLsizei width, GLsizei height))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglViewport(GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglViewport glViewport = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v1.2 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v1.2 FUNCTIONS...
        // --- GL_draw_range_elements
        // GLproc (void, glDrawRangeElements,	(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, const GLvoid *indices))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawRangeElements(GLenum mode, GLuint start, GLint end, GLsizei count, GLenum type, void* indices);
        private static TglDrawRangeElements glDrawRangeElements = null;

        // --- GL_texture3D
        // GLproc (void, glTexImage3D,			(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, const GLvoid *pixels))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexImage3D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei depth, GLint border, GLenum format, GLenum type, void* pixels);
        private static TglTexImage3D glTexImage3D = null;

        // GLproc (void, glTexSubImage3D,		(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const GLvoid *pixels))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels);
        private static TglTexSubImage3D glTexSubImage3D = null;

        // GLproc (void, glCopyTexSubImage3D,	(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglCopyTexSubImage3D glCopyTexSubImage3D = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v1.2: GL_ARB_imaging FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v1.2: GL_ARB_imaging FUNCTIONS...
        // --- GL_blend_color
        // GLproc (void, glBlendColor,		(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);
        private static TglBlendColor glBlendColor = null;

        // --- GL_blend_minmax
        // GLproc (void, glBlendEquation,	(GLenum mode))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendEquation(GLenum mode);
        private static TglBlendEquation glBlendEquation = null;

        // --- GL_color_subtable
        // GLproc (void, glColorSubTable,	(GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, const GLvoid *data))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorSubTable(GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, void* data);
        private static TglColorSubTable glColorSubTable = null;

        // GLproc (void, glCopyColorSubTable, (GLenum target, GLsizei start, GLint x, GLint y, GLsizei width))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyColorSubTable(GLenum target, GLsizei start, GLint x, GLint y, GLsizei width);
        private static TglCopyColorSubTable glCopyColorSubTable = null;

        // --- GL_color_table
        // GLproc (void, glColorTable,		(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, const GLvoid *table))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorTable(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, void* table);
        private static TglColorTable glColorTable = null;

        // GLproc (void, glCopyColorTable, (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyColorTable(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
        private static TglCopyColorTable glCopyColorTable = null;

        // GLproc (void, glColorTableParameteriv, (GLenum target, GLenum pname, const GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorTableParameteriv(GLenum target, GLenum pname, GLint* parameters);
        private static TglColorTableParameteriv glColorTableParameteriv = null;

        // GLproc (void, glColorTableParameterfv, (GLenum target, GLenum pname, const GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorTableParameterfv(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglColorTableParameterfv glColorTableParameterfv = null;

        // GLproc (void, glGetColorTable,	(GLenum target, GLenum format, GLenum type, GLvoid *table))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetColorTable(GLenum target, GLenum format, GLenum type, void* table);
        private static TglGetColorTable glGetColorTable = null;

        // GLproc (void, glGetColorTableParameteriv, (GLenum target, GLenum pname, GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetColorTableParameteriv(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetColorTableParameteriv glGetColorTableParameteriv = null;

        // GLproc (void, glGetColorTableParameterfv, (GLenum target, GLenum pname, GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetColorTableParameterfv(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetColorTableParameterfv glGetColorTableParameterfv = null;

        // --- GL_convolution
        // GLproc (void, glConvolutionFilter1D, (GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, const GLvoid *image))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglConvolutionFilter1D(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, void* image);
        private static TglConvolutionFilter1D glConvolutionFilter1D = null;

        // GLproc (void, glConvolutionFilter2D, (GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *image))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglConvolutionFilter2D(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, void* image);
        private static TglConvolutionFilter2D glConvolutionFilter2D = null;

        // GLproc (void, glCopyConvolutionFilter1D, (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyConvolutionFilter1D(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width);
        private static TglCopyConvolutionFilter1D glCopyConvolutionFilter1D = null;

        // GLproc (void, glCopyConvolutionFilter2D, (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyConvolutionFilter2D(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglCopyConvolutionFilter2D glCopyConvolutionFilter2D = null;

        // GLproc (void, glGetConvolutionFilter, (GLenum target, GLenum format, GLenum type, GLvoid *image))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetConvolutionFilter(GLenum target, GLenum format, GLenum type, void* image);
        private static TglGetConvolutionFilter glGetConvolutionFilter = null;

        // GLproc (void, glSeparableFilter2D, (GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *row, const GLvoid *column))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSeparableFilter2D(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, void* row, void* column);
        private static TglSeparableFilter2D glSeparableFilter2D = null;

        // GLproc (void, glGetSeparableFilter, (GLenum target, GLenum format, GLenum type, GLvoid *row, GLvoid *column, GLvoid *span))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetSeparableFilter(GLenum target, GLenum format, GLenum type, void* row, void* column, void* span);
        private static TglGetSeparableFilter glGetSeparableFilter = null;

        // GLproc (void, glConvolutionParameteri, (GLenum target, GLenum pname, GLint params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglConvolutionParameteri(GLenum target, GLenum pname, GLint parameters);
        private static TglConvolutionParameteri glConvolutionParameteri = null;

        // GLproc (void, glConvolutionParameteriv, (GLenum target, GLenum pname, const GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglConvolutionParameteriv(GLenum target, GLenum pname, GLint* parameters);
        private static TglConvolutionParameteriv glConvolutionParameteriv = null;

        // GLproc (void, glConvolutionParameterf, (GLenum target, GLenum pname, GLfloat params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglConvolutionParameterf(GLenum target, GLenum pname, GLfloat parameters);
        private static TglConvolutionParameterf glConvolutionParameterf = null;

        // GLproc (void, glConvolutionParameterfv, (GLenum target, GLenum pname, const GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglConvolutionParameterfv(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglConvolutionParameterfv glConvolutionParameterfv = null;

        // GLproc (void, glGetConvolutionParameteriv, (GLenum target, GLenum pname, GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetConvolutionParameteriv(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetConvolutionParameteriv glGetConvolutionParameteriv = null;

        // GLproc (void, glGetConvolutionParameterfv, (GLenum target, GLenum pname, GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetConvolutionParameterfv(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetConvolutionParameterfv glGetConvolutionParameterfv = null;

        // --- GL_histogram
        // GLproc (void, glHistogram,		(GLenum target, GLsizei width, GLenum internalformat, GLboolean sink))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglHistogram(GLenum target, GLsizei width, GLenum internalformat, GLboolean sink);
        private static TglHistogram glHistogram = null;

        // GLproc (void, glResetHistogram, (GLenum target))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglResetHistogram(GLenum target);
        private static TglResetHistogram glResetHistogram = null;

        // GLproc (void, glGetHistogram,	(GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid *values))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetHistogram(GLenum target, GLboolean reset, GLenum format, GLenum type, void* values);
        private static TglGetHistogram glGetHistogram = null;

        // GLproc (void, glGetHistogramParameteriv, (GLenum target, GLenum pname, GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetHistogramParameteriv(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetHistogramParameteriv glGetHistogramParameteriv = null;

        // GLproc (void, glGetHistogramParameterfv, (GLenum target, GLenum pname, GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetHistogramParameterfv(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetHistogramParameterfv glGetHistogramParameterfv = null;

        // GLproc (void, glMinmax,			(GLenum target, GLenum internalformat, GLboolean sink))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMinmax(GLenum target, GLenum internalformat, GLboolean sink);
        private static TglMinmax glMinmax = null;

        // GLproc (void, glResetMinmax,	(GLenum target))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglResetMinmax(GLenum target);
        private static TglResetMinmax glResetMinmax = null;

        // GLproc (void, glGetMinmax,		(GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid *values))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMinmax(GLenum target, GLboolean reset, GLenum format, GLenum type, void* values);
        private static TglGetMinmax glGetMinmax = null;

        // GLproc (void, glGetMinmaxParameteriv, (GLenum target, GLenum pname, GLint *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMinmaxParameteriv(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetMinmaxParameteriv glGetMinmaxParameteriv = null;

        // GLproc (void, glGetMinmaxParameterfv, (GLenum target, GLenum pname, GLfloat *params))
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMinmaxParameterfv(GLenum target, GLenum pname, GLfloat* parameters);
        private static TglGetMinmaxParameterfv glGetMinmaxParameterfv = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v1.3 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v1.3 FUNCTIONS...
        // GLAPI void GLAPIENTRY glActiveTexture( GLenum texture );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglActiveTexture(GLenum texture);
        private static TglActiveTexture glActiveTexture = null;

        // GLAPI void GLAPIENTRY glClientActiveTexture( GLenum texture );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClientActiveTexture(GLenum texture);
        private static TglClientActiveTexture glClientActiveTexture = null;

        // GLAPI void GLAPIENTRY glCompressedTexImage1D( GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, const GLvoid *data );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTexImage1D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, void* data);
        private static TglCompressedTexImage1D glCompressedTexImage1D = null;

        // GLAPI void GLAPIENTRY glCompressedTexImage2D( GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, const GLvoid *data );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, void* data);
        private static TglCompressedTexImage2D glCompressedTexImage2D = null;

        // GLAPI void GLAPIENTRY glCompressedTexImage3D( GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, const GLvoid *data );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTexImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, void* data);
        private static TglCompressedTexImage3D glCompressedTexImage3D = null;

        // GLAPI void GLAPIENTRY glCompressedTexSubImage1D( GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, const GLvoid *data );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data);
        private static TglCompressedTexSubImage1D glCompressedTexSubImage1D = null;

        // GLAPI void GLAPIENTRY glCompressedTexSubImage2D( GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const GLvoid *data );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data);
        private static TglCompressedTexSubImage2D glCompressedTexSubImage2D = null;

        // GLAPI void GLAPIENTRY glCompressedTexSubImage3D( GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const GLvoid *data );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data);
        private static TglCompressedTexSubImage3D glCompressedTexSubImage3D = null;

        // GLAPI void GLAPIENTRY glGetCompressedTexImage( GLenum target, GLint lod, GLvoid *img );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetCompressedTexImage(GLenum target, GLint lod, void* img);
        private static TglGetCompressedTexImage glGetCompressedTexImage = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord1d( GLenum target, GLdouble s );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord1d(GLenum target, GLdouble s);
        private static TglMultiTexCoord1d glMultiTexCoord1d = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord1dv( GLenum target, const GLdouble *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord1dv(GLenum target, GLdouble* v);
        private static TglMultiTexCoord1dv glMultiTexCoord1dv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord1f( GLenum target, GLfloat s );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord1f(GLenum target, GLfloat s);
        private static TglMultiTexCoord1f glMultiTexCoord1f = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord1fv( GLenum target, const GLfloat *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord1fv(GLenum target, GLfloat* v);
        private static TglMultiTexCoord1fv glMultiTexCoord1fv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord1i( GLenum target, GLint s );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord1i(GLenum target, GLint s);
        private static TglMultiTexCoord1i glMultiTexCoord1i = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord1iv( GLenum target, const GLint *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord1iv(GLenum target, GLint* v);
        private static TglMultiTexCoord1iv glMultiTexCoord1iv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord1s( GLenum target, GLshort s );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord1s(GLenum target, GLshort s);
        private static TglMultiTexCoord1s glMultiTexCoord1s = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord1sv( GLenum target, const GLshort *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord1sv(GLenum target, GLshort* v);
        private static TglMultiTexCoord1sv glMultiTexCoord1sv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord2d( GLenum target, GLdouble s, GLdouble t );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord2d(GLenum target, GLdouble s, GLdouble t);
        private static TglMultiTexCoord2d glMultiTexCoord2d = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord2dv( GLenum target, const GLdouble *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord2dv(GLenum target, GLdouble* v);
        private static TglMultiTexCoord2dv glMultiTexCoord2dv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord2f( GLenum target, GLfloat s, GLfloat t );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord2f(GLenum target, GLfloat s, GLfloat t);
        private static TglMultiTexCoord2f glMultiTexCoord2f = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord2fv( GLenum target, const GLfloat *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord2fv (GLenum target, GLfloat* v);
        private static TglMultiTexCoord2fv glMultiTexCoord2fv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord2i( GLenum target, GLint s, GLint t );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord2i(GLenum target, GLint s, GLint t);
        private static TglMultiTexCoord2i glMultiTexCoord2i = null;
        
        // GLAPI void GLAPIENTRY glMultiTexCoord2iv( GLenum target, const GLint *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord2iv(GLenum target, GLint* v);
        private static TglMultiTexCoord2iv glMultiTexCoord2iv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord2s( GLenum target, GLshort s, GLshort t );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord2s(GLenum target, GLshort s, GLshort t);
        private static TglMultiTexCoord2s glMultiTexCoord2s = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord2sv( GLenum target, const GLshort *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord2sv(GLenum target, GLshort* v);
        private static TglMultiTexCoord2sv glMultiTexCoord2sv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord3d( GLenum target, GLdouble s, GLdouble t, GLdouble r );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord3d(GLenum target, GLdouble s, GLdouble t, GLdouble r);
        private static TglMultiTexCoord3d glMultiTexCoord3d = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord3dv( GLenum target, const GLdouble *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord3dv(GLenum target, GLdouble* v);
        private static TglMultiTexCoord3dv glMultiTexCoord3dv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord3f( GLenum target, GLfloat s, GLfloat t, GLfloat r );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord3f(GLenum target, GLfloat s, GLfloat t, GLfloat r);
        private static TglMultiTexCoord3f glMultiTexCoord3f = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord3fv( GLenum target, const GLfloat *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord3fv(GLenum target, GLfloat* v);
        private static TglMultiTexCoord3fv glMultiTexCoord3fv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord3i( GLenum target, GLint s, GLint t, GLint r );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord3i(GLenum target, GLint s, GLint t, GLint r);
        private static TglMultiTexCoord3i glMultiTexCoord3i = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord3iv( GLenum target, const GLint *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord3iv(GLenum target, GLint* v);
        private static TglMultiTexCoord3iv glMultiTexCoord3iv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord3s( GLenum target, GLshort s, GLshort t, GLshort r );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord3s(GLenum target, GLshort s, GLshort t, GLshort r);
        private static TglMultiTexCoord3s glMultiTexCoord3s = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord3sv( GLenum target, const GLshort *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord3sv(GLenum target, GLshort* v);
        private static TglMultiTexCoord3sv glMultiTexCoord3sv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord4d( GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord4d(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);
        private static TglMultiTexCoord4d glMultiTexCoord4d = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord4dv( GLenum target, const GLdouble *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord4dv(GLenum target, GLdouble* v);
        private static TglMultiTexCoord4dv glMultiTexCoord4dv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord4f( GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord4f(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);
        private static TglMultiTexCoord4f glMultiTexCoord4f = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord4fv( GLenum target, const GLfloat *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord4fv(GLenum target, GLfloat* v);
        private static TglMultiTexCoord4fv glMultiTexCoord4fv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord4i( GLenum target, GLint s, GLint t, GLint r, GLint q );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord4i(GLenum target, GLint s, GLint t, GLint r, GLint q);
        private static TglMultiTexCoord4i glMultiTexCoord4i = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord4iv( GLenum target, const GLint *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord4iv(GLenum target, GLint* v);
        private static TglMultiTexCoord4iv glMultiTexCoord4iv = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord4s( GLenum target, GLshort s, GLshort t, GLshort r, GLshort q );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoord4s(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);
        private static TglMultiTexCoord4s glMultiTexCoord4s = null;

        // GLAPI void GLAPIENTRY glMultiTexCoord4sv( GLenum target, const GLshort *v );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoord4sv(GLenum target, GLshort* v);
        private static TglMultiTexCoord4sv glMultiTexCoord4sv = null;

        // GLAPI void GLAPIENTRY glLoadTransposeMatrixd( const GLdouble *m );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLoadTransposeMatrixd(GLdouble* m);
        private static TglLoadTransposeMatrixd glLoadTransposeMatrixd = null;

        // GLAPI void GLAPIENTRY glLoadTransposeMatrixf( const GLfloat *m );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglLoadTransposeMatrixf(GLfloat* m);
        private static TglLoadTransposeMatrixf glLoadTransposeMatrixf = null;

        // GLAPI void GLAPIENTRY glMultTransposeMatrixd( const GLdouble *m );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultTransposeMatrixd(GLdouble* m);
        private static TglMultTransposeMatrixd glMultTransposeMatrixd = null;

        // GLAPI void GLAPIENTRY glMultTransposeMatrixf( const GLfloat *m );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultTransposeMatrixf(GLfloat* m);
        private static TglMultTransposeMatrixf glMultTransposeMatrixf = null;

        // GLAPI void GLAPIENTRY glSampleCoverage( GLclampf value, GLboolean invert );
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSampleCoverage(GLclampf value, GLboolean invert);
        private static TglSampleCoverage glSampleCoverage = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v1.4 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v1.4 FUNCTIONS...
        // GLAPI void APIENTRY glBlendFuncSeparate (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendFuncSeparate(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha);
        private static TglBlendFuncSeparate glBlendFuncSeparate = null;

        // GLAPI void APIENTRY glMultiDrawArrays (GLenum mode, const GLint *first, const GLsizei *count, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawArrays(GLenum mode, GLint* first, GLsizei* count, GLsizei primcount);
        private static TglMultiDrawArrays glMultiDrawArrays = null;

        // GLAPI void APIENTRY glMultiDrawElements (GLenum mode, const GLsizei *count, GLenum type, const GLvoid* *indices, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawElements(GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei primcount);
        private static TglMultiDrawElements glMultiDrawElements = null;

        // GLAPI void APIENTRY glPointParameterf (GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPointParameterf(GLenum pname, GLfloat param);
        private static TglPointParameterf glPointParameterf = null;

        // GLAPI void APIENTRY glPointParameterfv (GLenum pname, const GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPointParameterfv(GLenum pname, GLfloat* parameters);
        private static TglPointParameterfv glPointParameterfv = null;

        // GLAPI void APIENTRY glPointParameteri (GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPointParameteri(GLenum pname, GLint param);
        private static TglPointParameteri glPointParameteri = null;

        // GLAPI void APIENTRY glPointParameteriv (GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPointParameteriv(GLenum pname, GLint* parameters);
        private static TglPointParameteriv glPointParameteriv = null;

        // GLAPI void APIENTRY glFogCoordf (GLfloat coord);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFogCoordf(GLfloat coord);
        private static TglFogCoordf glFogCoordf = null;

        // GLAPI void APIENTRY glFogCoordfv (const GLfloat *coord);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFogCoordfv(GLfloat* coord);
        private static TglFogCoordfv glFogCoordfv = null;

        // GLAPI void APIENTRY glFogCoordd (GLdouble coord);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFogCoordd(GLdouble coord);
        private static TglFogCoordd glFogCoordd = null;

        // GLAPI void APIENTRY glFogCoorddv (const GLdouble *coord);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFogCoorddv(GLdouble* coord);
        private static TglFogCoorddv glFogCoorddv = null;

        // GLAPI void APIENTRY glFogCoordPointer (GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglFogCoordPointer(GLenum type, GLsizei stride, void* pointer);
        private static TglFogCoordPointer glFogCoordPointer = null;

        // GLAPI void APIENTRY glSecondaryColor3b (GLbyte red, GLbyte green, GLbyte blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3b(GLbyte red, GLbyte green, GLbyte blue);
        private static TglSecondaryColor3b glSecondaryColor3b = null;

        // GLAPI void APIENTRY glSecondaryColor3bv (const GLbyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3bv(GLbyte* v);
        private static TglSecondaryColor3bv glSecondaryColor3bv = null;

        // GLAPI void APIENTRY glSecondaryColor3d (GLdouble red, GLdouble green, GLdouble blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3d(GLdouble red, GLdouble green, GLdouble blue);
        private static TglSecondaryColor3d glSecondaryColor3d = null;

        // GLAPI void APIENTRY glSecondaryColor3dv (const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3dv(GLdouble* v);
        private static TglSecondaryColor3dv glSecondaryColor3dv = null;

        // GLAPI void APIENTRY glSecondaryColor3f (GLfloat red, GLfloat green, GLfloat blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3f(GLfloat red, GLfloat green, GLfloat blue);
        private static TglSecondaryColor3f glSecondaryColor3f = null;

        // GLAPI void APIENTRY glSecondaryColor3fv (const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3fv(GLfloat* v);
        private static TglSecondaryColor3fv glSecondaryColor3fv = null;

        // GLAPI void APIENTRY glSecondaryColor3i (GLint red, GLint green, GLint blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3i(GLint red, GLint green, GLint blue);
        private static TglSecondaryColor3i glSecondaryColor3i = null;

        // GLAPI void APIENTRY glSecondaryColor3iv (const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3iv(GLint* v);
        private static TglSecondaryColor3iv glSecondaryColor3iv = null;

        // GLAPI void APIENTRY glSecondaryColor3s (GLshort red, GLshort green, GLshort blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3s(GLshort red, GLshort green, GLshort blue);
        private static TglSecondaryColor3s glSecondaryColor3s = null;

        // GLAPI void APIENTRY glSecondaryColor3sv (const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3sv(GLshort* v);
        private static TglSecondaryColor3sv glSecondaryColor3sv = null;

        // GLAPI void APIENTRY glSecondaryColor3ub (GLubyte red, GLubyte green, GLubyte blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3ub(GLubyte red, GLubyte green, GLubyte blue);
        private static TglSecondaryColor3ub glSecondaryColor3ub = null;

        // GLAPI void APIENTRY glSecondaryColor3ubv (const GLubyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3ubv(GLubyte* v);
        private static TglSecondaryColor3ubv glSecondaryColor3ubv = null;

        // GLAPI void APIENTRY glSecondaryColor3ui (GLuint red, GLuint green, GLuint blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3ui(GLuint red, GLuint green, GLuint blue);
        private static TglSecondaryColor3ui glSecondaryColor3ui = null;

        // GLAPI void APIENTRY glSecondaryColor3uiv (const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3uiv(GLuint* v);
        private static TglSecondaryColor3uiv glSecondaryColor3uiv = null;

        // GLAPI void APIENTRY glSecondaryColor3us (GLushort red, GLushort green, GLushort blue);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColor3us(GLushort red, GLushort green, GLushort blue);
        private static TglSecondaryColor3us glSecondaryColor3us = null;

        // GLAPI void APIENTRY glSecondaryColor3usv (const GLushort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColor3usv(GLushort* v);
        private static TglSecondaryColor3usv glSecondaryColor3usv = null;

        // GLAPI void APIENTRY glSecondaryColorPointer (GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColorPointer(GLint size, GLenum type, GLsizei stride, void* pointer);
        private static TglSecondaryColorPointer glSecondaryColorPointer = null;

        // GLAPI void APIENTRY glWindowPos2d (GLdouble x, GLdouble y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos2d(GLdouble x, GLdouble y);
        private static TglWindowPos2d glWindowPos2d = null;

        // GLAPI void APIENTRY glWindowPos2dv (const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos2dv(GLdouble* v);
        private static TglWindowPos2dv glWindowPos2dv = null;

        // GLAPI void APIENTRY glWindowPos2f (GLfloat x, GLfloat y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos2f(GLfloat x, GLfloat y);
        private static TglWindowPos2f glWindowPos2f = null;

        // GLAPI void APIENTRY glWindowPos2fv (const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos2fv(GLfloat* v);
        private static TglWindowPos2fv glWindowPos2fv = null;

        // GLAPI void APIENTRY glWindowPos2i (GLint x, GLint y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos2i(GLint x, GLint y);
        private static TglWindowPos2i glWindowPos2i = null;

        // GLAPI void APIENTRY glWindowPos2iv (const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos2iv(GLint* v);
        private static TglWindowPos2iv glWindowPos2iv = null;

        // GLAPI void APIENTRY glWindowPos2s (GLshort x, GLshort y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos2s(GLshort x, GLshort y);
        private static TglWindowPos2s glWindowPos2s = null;

        // GLAPI void APIENTRY glWindowPos2sv (const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos2sv(GLshort* v);
        private static TglWindowPos2sv glWindowPos2sv = null;

        // GLAPI void APIENTRY glWindowPos3d (GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos3d(GLdouble x, GLdouble y, GLdouble z);
        private static TglWindowPos3d glWindowPos3d = null;

        // GLAPI void APIENTRY glWindowPos3dv (const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos3dv(GLdouble* v);
        private static TglWindowPos3dv glWindowPos3dv = null;

        // GLAPI void APIENTRY glWindowPos3f (GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos3f(GLfloat x, GLfloat y, GLfloat z);
        private static TglWindowPos3f glWindowPos3f = null;

        // GLAPI void APIENTRY glWindowPos3fv (const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos3fv(GLfloat* v);
        private static TglWindowPos3fv glWindowPos3fv = null;

        // GLAPI void APIENTRY glWindowPos3i (GLint x, GLint y, GLint z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos3i(GLint x, GLint y, GLint z);
        private static TglWindowPos3i glWindowPos3i = null;

        // GLAPI void APIENTRY glWindowPos3iv (const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos3iv(GLint* v);
        private static TglWindowPos3iv glWindowPos3iv = null;

        // GLAPI void APIENTRY glWindowPos3s (GLshort x, GLshort y, GLshort z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWindowPos3s(GLshort x, GLshort y, GLshort z);
        private static TglWindowPos3s glWindowPos3s = null;

        // GLAPI void APIENTRY glWindowPos3sv (const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglWindowPos3sv(GLshort* v);
        private static TglWindowPos3sv glWindowPos3sv = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v1.5 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v1.5 FUNCTIONS...
        // GLAPI void APIENTRY glGenQueries (GLsizei n, GLuint *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenQueries(GLsizei n, GLuint* ids);
        private static TglGenQueries glGenQueries = null;

        // GLAPI void APIENTRY glDeleteQueries (GLsizei n, const GLuint *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteQueries(GLsizei n, GLuint* ids);
        private static TglDeleteQueries glDeleteQueries = null;

        // GLAPI GLboolean APIENTRY glIsQuery (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsQuery(GLuint id);
        private static TglIsQuery glIsQuery = null;

        // GLAPI void APIENTRY glBeginQuery (GLenum target, GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginQuery(GLenum target, GLuint id);
        private static TglBeginQuery glBeginQuery = null;

        // GLAPI void APIENTRY glEndQuery (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndQuery(GLenum target);
        private static TglEndQuery glEndQuery = null;

        // GLAPI void APIENTRY glGetQueryiv (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetQueryiv(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetQueryiv glGetQueryiv = null;

        // GLAPI void APIENTRY glGetQueryObjectiv (GLuint id, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetQueryObjectiv(GLuint id, GLenum pname, GLint* parameters);
        private static TglGetQueryObjectiv glGetQueryObjectiv = null;

        // GLAPI void APIENTRY glGetQueryObjectuiv (GLuint id, GLenum pname, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetQueryObjectuiv(GLuint id, GLenum pname, GLuint* parameters);
        private static TglGetQueryObjectuiv glGetQueryObjectuiv = null;

        // GLAPI void APIENTRY glBindBuffer (GLenum target, GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindBuffer(GLenum target, GLuint buffer);
        private static TglBindBuffer glBindBuffer = null;

        // GLAPI void APIENTRY glDeleteBuffers (GLsizei n, const GLuint *buffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteBuffers(GLsizei n, GLuint* buffers);
        private static TglDeleteBuffers glDeleteBuffers = null;

        // GLAPI void APIENTRY glGenBuffers (GLsizei n, GLuint *buffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenBuffers(GLsizei n, GLuint* buffers);
        private static TglGenBuffers glGenBuffers = null;

        // GLAPI GLboolean APIENTRY glIsBuffer (GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsBuffer(GLuint buffer);
        private static TglIsBuffer glIsBuffer = null;

        // GLAPI void APIENTRY glBufferData (GLenum target, GLsizeiptr size, const GLvoid *data, GLenum usage);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBufferData(GLenum target, GLsizeiptr size, void* data, GLenum usage);
        private static TglBufferData glBufferData = null;

        // GLAPI void APIENTRY glBufferSubData (GLenum target, GLintptr offset, GLsizeiptr size, const GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, void* data);
        private static TglBufferSubData glBufferSubData = null;

        // GLAPI void APIENTRY glGetBufferSubData (GLenum target, GLintptr offset, GLsizeiptr size, GLvoid *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, void* data);
        private static TglGetBufferSubData glGetBufferSubData = null;

        // GLAPI GLvoid* APIENTRY glMapBuffer (GLenum target, GLenum access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void* TglMapBuffer(GLenum target, GLenum access);
        private static TglMapBuffer glMapBuffer = null;

        // GLAPI GLboolean APIENTRY glUnmapBuffer (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglUnmapBuffer(GLenum target);
        private static TglUnmapBuffer glUnmapBuffer = null;

        // GLAPI void APIENTRY glGetBufferParameteriv (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetBufferParameteriv(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetBufferParameteriv glGetBufferParameteriv = null;

        // GLAPI void APIENTRY glGetBufferPointerv (GLenum target, GLenum pname, GLvoid* *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetBufferPointerv(GLenum target, GLenum pname, void** parameters);
        private static TglGetBufferPointerv glGetBufferPointerv = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v2.0 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v2.0 FUNCTIONS...
        // GLAPI void APIENTRY glBlendEquationSeparate (GLenum modeRGB, GLenum modeAlpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha);
        private static TglBlendEquationSeparate glBlendEquationSeparate = null;

        // GLAPI void APIENTRY glDrawBuffers (GLsizei n, const GLenum *bufs);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawBuffers(GLsizei n, GLenum* bufs);
        private static TglDrawBuffers glDrawBuffers = null;

        // GLAPI void APIENTRY glStencilOpSeparate (GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStencilOpSeparate(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass);
        private static TglStencilOpSeparate glStencilOpSeparate = null;

        // GLAPI void APIENTRY glStencilFuncSeparate (GLenum face, GLenum func, GLint ref, GLuint mask);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStencilFuncSeparate(GLenum face, GLenum func, GLint reference, GLuint mask);
        private static TglStencilFuncSeparate glStencilFuncSeparate = null;

        // GLAPI void APIENTRY glStencilMaskSeparate (GLenum face, GLuint mask);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglStencilMaskSeparate(GLenum face, GLuint mask);
        private static TglStencilMaskSeparate glStencilMaskSeparate = null;

        // GLAPI void APIENTRY glAttachShader (GLuint program, GLuint shader);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglAttachShader(GLuint program, GLuint shader);
        private static TglAttachShader glAttachShader = null;

        // GLAPI void APIENTRY glBindAttribLocation (GLuint program, GLuint index, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindAttribLocation(GLuint program, GLuint index, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglBindAttribLocation glBindAttribLocation = null;

        // GLAPI void APIENTRY glCompileShader (GLuint shader);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCompileShader(GLuint shader);
        private static TglCompileShader glCompileShader = null;

        // GLAPI GLuint APIENTRY glCreateProgram (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCreateProgram();
        private static TglCreateProgram glCreateProgram = null;

        // GLAPI GLuint APIENTRY glCreateShader (GLenum type);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCreateShader(GLenum type);
        private static TglCreateShader glCreateShader = null;

        // GLAPI void APIENTRY glDeleteProgram (GLuint program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDeleteProgram(GLuint program);
        private static TglDeleteProgram glDeleteProgram = null;

        // GLAPI void APIENTRY glDeleteShader (GLuint shader);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDeleteShader(GLuint shader);
        private static TglDeleteShader glDeleteShader = null;

        // GLAPI void APIENTRY glDetachShader (GLuint program, GLuint shader);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDetachShader(GLuint program, GLuint shader);
        private static TglDetachShader glDetachShader = null;

        // GLAPI void APIENTRY glDisableVertexAttribArray (GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDisableVertexAttribArray(GLuint index);
        private static TglDisableVertexAttribArray glDisableVertexAttribArray = null;

        // GLAPI void APIENTRY glEnableVertexAttribArray (GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEnableVertexAttribArray(GLuint index);
        private static TglEnableVertexAttribArray glEnableVertexAttribArray = null;

        // GLAPI void APIENTRY glGetActiveAttrib (GLuint program, GLuint index, GLsizei bufSize, GLsizei *length, GLint *size, GLenum *type, GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetActiveAttrib(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name);
        private static TglGetActiveAttrib glGetActiveAttrib = null;

        // GLAPI void APIENTRY glGetActiveUniform (GLuint program, GLuint index, GLsizei bufSize, GLsizei *length, GLint *size, GLenum *type, GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetActiveUniform(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLint* size, GLenum* type, GLchar* name);
        private static TglGetActiveUniform glGetActiveUniform = null;

        // GLAPI void APIENTRY glGetAttachedShaders (GLuint program, GLsizei maxCount, GLsizei *count, GLuint *obj);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetAttachedShaders(GLuint program, GLsizei maxCount, GLsizei* count, GLuint* obj);
        private static TglGetAttachedShaders glGetAttachedShaders = null;

        // GLAPI GLint APIENTRY glGetAttribLocation (GLuint program, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLint TglGetAttribLocation(GLuint program, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglGetAttribLocation glGetAttribLocation = null;

        // GLAPI void APIENTRY glGetProgramiv (GLuint program, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramiv(GLuint program, GLenum pname, GLint* parameters);
        private static TglGetProgramiv glGetProgramiv = null;

        // GLAPI void APIENTRY glGetProgramInfoLog (GLuint program, GLsizei bufSize, GLsizei *length, GLchar *infoLog);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramInfoLog(GLuint program, GLsizei bufSize, GLsizei* length, GLchar* infoLog);
        private static TglGetProgramInfoLog glGetProgramInfoLog = null;

        // GLAPI void APIENTRY glGetShaderiv (GLuint shader, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetShaderiv(GLuint shader, GLenum pname, GLint* parameters);
        private static TglGetShaderiv glGetShaderiv = null;

        // GLAPI void APIENTRY glGetShaderInfoLog (GLuint shader, GLsizei bufSize, GLsizei *length, GLchar *infoLog);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetShaderInfoLog(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* infoLog);
        private static TglGetShaderInfoLog glGetShaderInfoLog = null;

        // GLAPI void APIENTRY glGetShaderSource (GLuint shader, GLsizei bufSize, GLsizei *length, GLchar *source);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetShaderSource(GLuint shader, GLsizei bufSize, GLsizei* length, GLchar* source);
        private static TglGetShaderSource glGetShaderSource = null;

        // GLAPI GLint APIENTRY glGetUniformLocation (GLuint program, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLint TglGetUniformLocation(GLuint program, [MarshalAs(UnmanagedType.LPStr)]string name);
        private static TglGetUniformLocation glGetUniformLocation = null;

        // GLAPI void APIENTRY glGetUniformfv (GLuint program, GLint location, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformfv(GLuint program, GLint location, GLfloat* parameters);
        private static TglGetUniformfv glGetUniformfv = null;

        // GLAPI void APIENTRY glGetUniformiv (GLuint program, GLint location, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformiv(GLuint program, GLint location, GLint* parameters);
        private static TglGetUniformiv glGetUniformiv = null;

        // GLAPI void APIENTRY glGetVertexAttribdv (GLuint index, GLenum pname, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribdv(GLuint index, GLenum pname, GLdouble* parameters);
        private static TglGetVertexAttribdv glGetVertexAttribdv = null;

        // GLAPI void APIENTRY glGetVertexAttribfv (GLuint index, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribfv(GLuint index, GLenum pname, GLfloat* parameters);
        private static TglGetVertexAttribfv glGetVertexAttribfv = null;

        // GLAPI void APIENTRY glGetVertexAttribiv (GLuint index, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribiv(GLuint index, GLenum pname, GLint* parameters);
        private static TglGetVertexAttribiv glGetVertexAttribiv = null;

        // GLAPI void APIENTRY glGetVertexAttribPointerv (GLuint index, GLenum pname, GLvoid* *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribPointerv(GLuint index, GLenum pname, void** pointer);
        private static TglGetVertexAttribPointerv glGetVertexAttribPointerv = null;

        // GLAPI GLboolean APIENTRY glIsProgram (GLuint program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsProgram(GLuint program);
        private static TglIsProgram glIsProgram = null;

        // GLAPI GLboolean APIENTRY glIsShader (GLuint shader);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsShader(GLuint shader);
        private static TglIsShader glIsShader = null;

        // GLAPI void APIENTRY glLinkProgram (GLuint program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglLinkProgram(GLuint program);
        private static TglLinkProgram glLinkProgram = null;

        // GLAPI void APIENTRY glShaderSource (GLuint shader, GLsizei count, const GLchar* *string, const GLint *length);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglShaderSource(GLuint shader, GLsizei count, GLchar** strings, GLint* length);
        private static TglShaderSource glShaderSource = null;

        // GLAPI void APIENTRY glUseProgram (GLuint program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUseProgram(GLuint program);
        private static TglUseProgram glUseProgram = null;

        // GLAPI void APIENTRY glUniform1f (GLint location, GLfloat v0);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform1f(GLint location, GLfloat v0);
        private static TglUniform1f glUniform1f = null;

        // GLAPI void APIENTRY glUniform2f (GLint location, GLfloat v0, GLfloat v1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform2f(GLint location, GLfloat v0, GLfloat v1);
        private static TglUniform2f glUniform2f = null;

        // GLAPI void APIENTRY glUniform3f (GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        private static TglUniform3f glUniform3f = null;

        // GLAPI void APIENTRY glUniform4f (GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        private static TglUniform4f glUniform4f = null;

        // GLAPI void APIENTRY glUniform1i (GLint location, GLint v0);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform1i(GLint location, GLint v0);
        private static TglUniform1i glUniform1i = null;

        // GLAPI void APIENTRY glUniform2i (GLint location, GLint v0, GLint v1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform2i(GLint location, GLint v0, GLint v1);
        private static TglUniform2i glUniform2i = null;

        // GLAPI void APIENTRY glUniform3i (GLint location, GLint v0, GLint v1, GLint v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform3i(GLint location, GLint v0, GLint v1, GLint v2);
        private static TglUniform3i glUniform3i = null;

        // GLAPI void APIENTRY glUniform4i (GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        private static TglUniform4i glUniform4i = null;

        // GLAPI void APIENTRY glUniform1fv (GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform1fv(GLint location, GLsizei count, GLfloat* value);
        private static TglUniform1fv glUniform1fv = null;

        // GLAPI void APIENTRY glUniform2fv (GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform2fv(GLint location, GLsizei count, GLfloat* value);
        private static TglUniform2fv glUniform2fv = null;

        // GLAPI void APIENTRY glUniform3fv (GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform3fv(GLint location, GLsizei count, GLfloat* value);
        private static TglUniform3fv glUniform3fv = null;

        // GLAPI void APIENTRY glUniform4fv (GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform4fv(GLint location, GLsizei count, GLfloat* value);
        private static TglUniform4fv glUniform4fv = null;

        // GLAPI void APIENTRY glUniform1iv (GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform1iv(GLint location, GLsizei count, GLint* value);
        private static TglUniform1iv glUniform1iv = null;

        // GLAPI void APIENTRY glUniform2iv (GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform2iv(GLint location, GLsizei count, GLint* value);
        private static TglUniform2iv glUniform2iv = null;

        // GLAPI void APIENTRY glUniform3iv (GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform3iv(GLint location, GLsizei count, GLint* value);
        private static TglUniform3iv glUniform3iv = null;

        // GLAPI void APIENTRY glUniform4iv (GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform4iv(GLint location, GLsizei count, GLint* value);
        private static TglUniform4iv glUniform4iv = null;

        // GLAPI void APIENTRY glUniformMatrix2fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglUniformMatrix2fv glUniformMatrix2fv = null;

        // GLAPI void APIENTRY glUniformMatrix3fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglUniformMatrix3fv glUniformMatrix3fv = null;

        // GLAPI void APIENTRY glUniformMatrix4fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglUniformMatrix4fv glUniformMatrix4fv = null;

        // GLAPI void APIENTRY glValidateProgram (GLuint program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglValidateProgram(GLuint program);
        private static TglValidateProgram glValidateProgram = null;

        // GLAPI void APIENTRY glVertexAttrib1d (GLuint index, GLdouble x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib1d(GLuint index, GLdouble x);
        private static TglVertexAttrib1d glVertexAttrib1d = null;

        // GLAPI void APIENTRY glVertexAttrib1dv (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib1dv(GLuint index, GLdouble* v);
        private static TglVertexAttrib1dv glVertexAttrib1dv = null;

        // GLAPI void APIENTRY glVertexAttrib1f (GLuint index, GLfloat x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib1f(GLuint index, GLfloat x);
        private static TglVertexAttrib1f glVertexAttrib1f = null;

        // GLAPI void APIENTRY glVertexAttrib1fv (GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib1fv(GLuint index, GLfloat* v);
        private static TglVertexAttrib1fv glVertexAttrib1fv = null;

        // GLAPI void APIENTRY glVertexAttrib1s (GLuint index, GLshort x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib1s(GLuint index, GLshort x);
        private static TglVertexAttrib1s glVertexAttrib1s = null;

        // GLAPI void APIENTRY glVertexAttrib1sv (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib1sv(GLuint index, GLshort* v);
        private static TglVertexAttrib1sv glVertexAttrib1sv = null;

        // GLAPI void APIENTRY glVertexAttrib2d (GLuint index, GLdouble x, GLdouble y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib2d(GLuint index, GLdouble x, GLdouble y);
        private static TglVertexAttrib2d glVertexAttrib2d = null;

        // GLAPI void APIENTRY glVertexAttrib2dv (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib2dv(GLuint index, GLdouble* v);
        private static TglVertexAttrib2dv glVertexAttrib2dv = null;

        // GLAPI void APIENTRY glVertexAttrib2f (GLuint index, GLfloat x, GLfloat y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib2f(GLuint index, GLfloat x, GLfloat y);
        private static TglVertexAttrib2f glVertexAttrib2f = null;

        // GLAPI void APIENTRY glVertexAttrib2fv (GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib2fv(GLuint index, GLfloat* v);
        private static TglVertexAttrib2fv glVertexAttrib2fv = null;

        // GLAPI void APIENTRY glVertexAttrib2s (GLuint index, GLshort x, GLshort y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib2s(GLuint index, GLshort x, GLshort y);
        private static TglVertexAttrib2s glVertexAttrib2s = null;

        // GLAPI void APIENTRY glVertexAttrib2sv (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib2sv(GLuint index, GLshort* v);
        private static TglVertexAttrib2sv glVertexAttrib2sv = null;

        // GLAPI void APIENTRY glVertexAttrib3d (GLuint index, GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib3d(GLuint index, GLdouble x, GLdouble y, GLdouble z);
        private static TglVertexAttrib3d glVertexAttrib3d = null;

        // GLAPI void APIENTRY glVertexAttrib3dv (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib3dv(GLuint index, GLdouble* v);
        private static TglVertexAttrib3dv glVertexAttrib3dv = null;

        // GLAPI void APIENTRY glVertexAttrib3f (GLuint index, GLfloat x, GLfloat y, GLfloat z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z);
        private static TglVertexAttrib3f glVertexAttrib3f = null;

        // GLAPI void APIENTRY glVertexAttrib3fv (GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib3fv(GLuint index, GLfloat* v);
        private static TglVertexAttrib3fv glVertexAttrib3fv = null;

        // GLAPI void APIENTRY glVertexAttrib3s (GLuint index, GLshort x, GLshort y, GLshort z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib3s(GLuint index, GLshort x, GLshort y, GLshort z);
        private static TglVertexAttrib3s glVertexAttrib3s = null;

        // GLAPI void APIENTRY glVertexAttrib3sv (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib3sv(GLuint index, GLshort* v);
        private static TglVertexAttrib3sv glVertexAttrib3sv = null;

        // GLAPI void APIENTRY glVertexAttrib4Nbv (GLuint index, const GLbyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4Nbv(GLuint index, GLbyte* v);
        private static TglVertexAttrib4Nbv glVertexAttrib4Nbv = null;

        // GLAPI void APIENTRY glVertexAttrib4Niv (GLuint index, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4Niv(GLuint index, GLint* v);
        private static TglVertexAttrib4Niv glVertexAttrib4Niv = null;

        // GLAPI void APIENTRY glVertexAttrib4Nsv (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4Nsv(GLuint index, GLshort* v);
        private static TglVertexAttrib4Nsv glVertexAttrib4Nsv = null;

        // GLAPI void APIENTRY glVertexAttrib4Nub (GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib4Nub(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w);
        private static TglVertexAttrib4Nub glVertexAttrib4Nub = null;

        // GLAPI void APIENTRY glVertexAttrib4Nubv (GLuint index, const GLubyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4Nubv(GLuint index, GLubyte* v);
        private static TglVertexAttrib4Nubv glVertexAttrib4Nubv = null;

        // GLAPI void APIENTRY glVertexAttrib4Nuiv (GLuint index, const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4Nuiv(GLuint index, GLuint* v);
        private static TglVertexAttrib4Nuiv glVertexAttrib4Nuiv = null;

        // GLAPI void APIENTRY glVertexAttrib4Nusv (GLuint index, const GLushort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4Nusv(GLuint index, GLushort* v);
        private static TglVertexAttrib4Nusv glVertexAttrib4Nusv = null;

        // GLAPI void APIENTRY glVertexAttrib4bv (GLuint index, const GLbyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4bv(GLuint index, GLbyte* v);
        private static TglVertexAttrib4bv glVertexAttrib4bv = null;

        // GLAPI void APIENTRY glVertexAttrib4d (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglVertexAttrib4d glVertexAttrib4d = null;

        // GLAPI void APIENTRY glVertexAttrib4dv (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4dv(GLuint index, GLdouble* v);
        private static TglVertexAttrib4dv glVertexAttrib4dv = null;

        // GLAPI void APIENTRY glVertexAttrib4f (GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w);
        private static TglVertexAttrib4f glVertexAttrib4f = null;

        // GLAPI void APIENTRY glVertexAttrib4fv (GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4fv(GLuint index, GLfloat* v);
        private static TglVertexAttrib4fv glVertexAttrib4fv = null;

        // GLAPI void APIENTRY glVertexAttrib4iv (GLuint index, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4iv(GLuint index, GLint* v);
        private static TglVertexAttrib4iv glVertexAttrib4iv = null;

        // GLAPI void APIENTRY glVertexAttrib4s (GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttrib4s(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w);
        private static TglVertexAttrib4s glVertexAttrib4s = null;

        // GLAPI void APIENTRY glVertexAttrib4sv (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4sv(GLuint index, GLshort* v);
        private static TglVertexAttrib4sv glVertexAttrib4sv = null;

        // GLAPI void APIENTRY glVertexAttrib4ubv (GLuint index, const GLubyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4ubv(GLuint index, GLubyte* v);
        private static TglVertexAttrib4ubv glVertexAttrib4ubv = null;

        // GLAPI void APIENTRY glVertexAttrib4uiv (GLuint index, const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4uiv(GLuint index, GLuint* v);
        private static TglVertexAttrib4uiv glVertexAttrib4uiv = null;

        // GLAPI void APIENTRY glVertexAttrib4usv (GLuint index, const GLushort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttrib4usv(GLuint index, GLushort* v);
        private static TglVertexAttrib4usv glVertexAttrib4usv = null;

        // GLAPI void APIENTRY glVertexAttribPointer (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribPointer(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, void* pointer);
        private static TglVertexAttribPointer glVertexAttribPointer = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v2.1 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v2.1 FUNCTIONS...
        // GLAPI void APIENTRY glUniformMatrix2x3fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix2x3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglUniformMatrix2x3fv glUniformMatrix2x3fv = null;

        // GLAPI void APIENTRY glUniformMatrix3x2fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix3x2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglUniformMatrix3x2fv glUniformMatrix3x2fv = null;

        // GLAPI void APIENTRY glUniformMatrix2x4fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix2x4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglUniformMatrix2x4fv glUniformMatrix2x4fv = null;

        // GLAPI void APIENTRY glUniformMatrix4x2fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix4x2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglUniformMatrix4x2fv glUniformMatrix4x2fv = null;

        // GLAPI void APIENTRY glUniformMatrix3x4fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix3x4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglUniformMatrix3x4fv glUniformMatrix3x4fv = null;

        // GLAPI void APIENTRY glUniformMatrix4x3fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix4x3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglUniformMatrix4x3fv glUniformMatrix4x3fv = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v3.0 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v3.0 FUNCTIONS...
        // GLAPI void APIENTRY glColorMaski (GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColorMaski(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a);
        private static TglColorMaski glColorMaski = null;

        // GLAPI void APIENTRY glGetBooleani_v (GLenum target, GLuint index, GLboolean *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetBooleani_v(GLenum target, GLuint index, GLboolean* data);
        private static TglGetBooleani_v glGetBooleani_v = null;

        // GLAPI void APIENTRY glGetIntegeri_v (GLenum target, GLuint index, GLint *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetIntegeri_v(GLenum target, GLuint index, GLint* data);
        private static TglGetIntegeri_v glGetIntegeri_v = null;

        // GLAPI void APIENTRY glEnablei (GLenum target, GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEnablei(GLenum target, GLuint index);
        private static TglEnablei glEnablei = null;

        // GLAPI void APIENTRY glDisablei (GLenum target, GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDisablei(GLenum target, GLuint index);
        private static TglDisablei glDisablei = null;

        // GLAPI GLboolean APIENTRY glIsEnabledi (GLenum target, GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsEnabledi(GLenum target, GLuint index);
        private static TglIsEnabledi glIsEnabledi = null;

        // GLAPI void APIENTRY glBeginTransformFeedback (GLenum primitiveMode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginTransformFeedback(GLenum primitiveMode);
        private static TglBeginTransformFeedback glBeginTransformFeedback = null;

        // GLAPI void APIENTRY glEndTransformFeedback (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndTransformFeedback();
        private static TglEndTransformFeedback glEndTransformFeedback = null;

        // GLAPI void APIENTRY glBindBufferRange (GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindBufferRange(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
        private static TglBindBufferRange glBindBufferRange = null;

        // GLAPI void APIENTRY glBindBufferBase (GLenum target, GLuint index, GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindBufferBase(GLenum target, GLuint index, GLuint buffer);
        private static TglBindBufferBase glBindBufferBase = null;

        // GLAPI void APIENTRY glTransformFeedbackVaryings (GLuint program, GLsizei count, const GLchar* *varyings, GLenum bufferMode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTransformFeedbackVaryings(GLuint program, GLsizei count, GLchar** varyings, GLenum bufferMode);
        private static TglTransformFeedbackVaryings glTransformFeedbackVaryings = null;
        
        // GLAPI void APIENTRY glGetTransformFeedbackVarying (GLuint program, GLuint index, GLsizei bufSize, GLsizei *length, GLsizei *size, GLenum *type, GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTransformFeedbackVarying(GLuint program, GLuint index, GLsizei bufSize, GLsizei* length, GLsizei* size, GLenum* type, GLchar* name);
        private static TglGetTransformFeedbackVarying glGetTransformFeedbackVarying = null;

        // GLAPI void APIENTRY glClampColor (GLenum target, GLenum clamp);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClampColor(GLenum target, GLenum clamp);
        private static TglClampColor glClampColor = null;

        // GLAPI void APIENTRY glBeginConditionalRender (GLuint id, GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginConditionalRender(GLuint id, GLenum mode);
        private static TglBeginConditionalRender glBeginConditionalRender = null;

        // GLAPI void APIENTRY glEndConditionalRender (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndConditionalRender();
        private static TglEndConditionalRender glEndConditionalRender = null;

        // GLAPI void APIENTRY glVertexAttribIPointer (GLuint index, GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribIPointer(GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer);
        private static TglVertexAttribIPointer glVertexAttribIPointer = null;

        // GLAPI void APIENTRY glGetVertexAttribIiv (GLuint index, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribIiv(GLuint index, GLenum pname, GLint* parameters);
        private static TglGetVertexAttribIiv glGetVertexAttribIiv = null;

        // GLAPI void APIENTRY glGetVertexAttribIuiv (GLuint index, GLenum pname, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribIuiv(GLuint index, GLenum pname, GLuint* parameters);
        private static TglGetVertexAttribIuiv glGetVertexAttribIuiv = null;

        // GLAPI void APIENTRY glVertexAttribI1i (GLuint index, GLint x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI1i(GLuint index, GLint x);
        private static TglVertexAttribI1i glVertexAttribI1i = null;

        // GLAPI void APIENTRY glVertexAttribI2i (GLuint index, GLint x, GLint y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI2i(GLuint index, GLint x, GLint y);
        private static TglVertexAttribI2i glVertexAttribI2i = null;

        // GLAPI void APIENTRY glVertexAttribI3i (GLuint index, GLint x, GLint y, GLint z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI3i(GLuint index, GLint x, GLint y, GLint z);
        private static TglVertexAttribI3i glVertexAttribI3i = null;

        // GLAPI void APIENTRY glVertexAttribI4i (GLuint index, GLint x, GLint y, GLint z, GLint w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI4i(GLuint index, GLint x, GLint y, GLint z, GLint w);
        private static TglVertexAttribI4i glVertexAttribI4i = null;

        // GLAPI void APIENTRY glVertexAttribI1ui (GLuint index, GLuint x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI1ui(GLuint index, GLuint x);
        private static TglVertexAttribI1ui glVertexAttribI1ui = null;

        // GLAPI void APIENTRY glVertexAttribI2ui (GLuint index, GLuint x, GLuint y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI2ui(GLuint index, GLuint x, GLuint y);
        private static TglVertexAttribI2ui glVertexAttribI2ui = null;

        // GLAPI void APIENTRY glVertexAttribI3ui (GLuint index, GLuint x, GLuint y, GLuint z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI3ui(GLuint index, GLuint x, GLuint y, GLuint z);
        private static TglVertexAttribI3ui glVertexAttribI3ui = null;

        // GLAPI void APIENTRY glVertexAttribI4ui (GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribI4ui(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w);
        private static TglVertexAttribI4ui glVertexAttribI4ui = null;

        // GLAPI void APIENTRY glVertexAttribI1iv (GLuint index, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI1iv(GLuint index, GLint* v);
        private static TglVertexAttribI1iv glVertexAttribI1iv = null;

        // GLAPI void APIENTRY glVertexAttribI2iv (GLuint index, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI2iv(GLuint index, GLint* v);
        private static TglVertexAttribI2iv glVertexAttribI2iv = null;

        // GLAPI void APIENTRY glVertexAttribI3iv (GLuint index, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI3iv(GLuint index, GLint* v);
        private static TglVertexAttribI3iv glVertexAttribI3iv = null;

        // GLAPI void APIENTRY glVertexAttribI4iv (GLuint index, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI4iv(GLuint index, GLint* v);
        private static TglVertexAttribI4iv glVertexAttribI4iv = null;

        // GLAPI void APIENTRY glVertexAttribI1uiv (GLuint index, const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI1uiv(GLuint index, GLuint* v);
        private static TglVertexAttribI1uiv glVertexAttribI1uiv = null;

        // GLAPI void APIENTRY glVertexAttribI2uiv (GLuint index, const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI2uiv(GLuint index, GLuint* v);
        private static TglVertexAttribI2uiv glVertexAttribI2uiv = null;

        // GLAPI void APIENTRY glVertexAttribI3uiv (GLuint index, const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI3uiv(GLuint index, GLuint* v);
        private static TglVertexAttribI3uiv glVertexAttribI3uiv = null;

        // GLAPI void APIENTRY glVertexAttribI4uiv (GLuint index, const GLuint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI4uiv(GLuint index, GLuint* v);
        private static TglVertexAttribI4uiv glVertexAttribI4uiv = null;

        // GLAPI void APIENTRY glVertexAttribI4bv (GLuint index, const GLbyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI4bv(GLuint index, GLbyte* v);
        private static TglVertexAttribI4bv glVertexAttribI4bv = null;

        // GLAPI void APIENTRY glVertexAttribI4sv (GLuint index, const GLshort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI4sv(GLuint index, GLshort* v);
        private static TglVertexAttribI4sv glVertexAttribI4sv = null;

        // GLAPI void APIENTRY glVertexAttribI4ubv (GLuint index, const GLubyte *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI4ubv(GLuint index, GLubyte* v);
        private static TglVertexAttribI4ubv glVertexAttribI4ubv = null;

        // GLAPI void APIENTRY glVertexAttribI4usv (GLuint index, const GLushort *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribI4usv(GLuint index, GLushort* v);
        private static TglVertexAttribI4usv glVertexAttribI4usv = null;

        // GLAPI void APIENTRY glGetUniformuiv (GLuint program, GLint location, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformuiv(GLuint program, GLint location, GLuint* parameters);
        private static TglGetUniformuiv glGetUniformuiv = null;

        // GLAPI void APIENTRY glBindFragDataLocation (GLuint program, GLuint color, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBindFragDataLocation(GLuint program, GLuint color, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglBindFragDataLocation glBindFragDataLocation = null;

        // GLAPI GLint APIENTRY glGetFragDataLocation (GLuint program, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLint TglGetFragDataLocation(GLuint program, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglGetFragDataLocation glGetFragDataLocation = null;

        // GLAPI void APIENTRY glUniform1ui (GLint location, GLuint v0);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform1ui(GLint location, GLuint v0);
        private static TglUniform1ui glUniform1ui = null;

        // GLAPI void APIENTRY glUniform2ui (GLint location, GLuint v0, GLuint v1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform2ui(GLint location, GLuint v0, GLuint v1);
        private static TglUniform2ui glUniform2ui = null;

        // GLAPI void APIENTRY glUniform3ui (GLint location, GLuint v0, GLuint v1, GLuint v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform3ui(GLint location, GLuint v0, GLuint v1, GLuint v2);
        private static TglUniform3ui glUniform3ui = null;

        // GLAPI void APIENTRY glUniform4ui (GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform4ui(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
        private static TglUniform4ui glUniform4ui = null;

        // GLAPI void APIENTRY glUniform1uiv (GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform1uiv(GLint location, GLsizei count, GLuint* value);
        private static TglUniform1uiv glUniform1uiv = null;

        // GLAPI void APIENTRY glUniform2uiv (GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform2uiv(GLint location, GLsizei count, GLuint* value);
        private static TglUniform2uiv glUniform2uiv = null;

        // GLAPI void APIENTRY glUniform3uiv (GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform3uiv(GLint location, GLsizei count, GLuint* value);
        private static TglUniform3uiv glUniform3uiv = null;

        // GLAPI void APIENTRY glUniform4uiv (GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform4uiv(GLint location, GLsizei count, GLuint* value);
        private static TglUniform4uiv glUniform4uiv = null;

        // GLAPI void APIENTRY glTexParameterIiv (GLenum target, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexParameterIiv(GLenum target, GLenum pname, GLint* parameters);
        private static TglTexParameterIiv glTexParameterIiv = null;

        // GLAPI void APIENTRY glTexParameterIuiv (GLenum target, GLenum pname, const GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexParameterIuiv(GLenum target, GLenum pname, GLuint* parameters);
        private static TglTexParameterIuiv glTexParameterIuiv = null;

        // GLAPI void APIENTRY glGetTexParameterIiv (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexParameterIiv(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetTexParameterIiv glGetTexParameterIiv = null;

        // GLAPI void APIENTRY glGetTexParameterIuiv (GLenum target, GLenum pname, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTexParameterIuiv(GLenum target, GLenum pname, GLuint* parameters);
        private static TglGetTexParameterIuiv glGetTexParameterIuiv = null;

        // GLAPI void APIENTRY glClearBufferiv (GLenum buffer, GLint drawbuffer, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearBufferiv(GLenum buffer, GLint drawbuffer, GLint* value);
        private static TglClearBufferiv glClearBufferiv = null;

        // GLAPI void APIENTRY glClearBufferuiv (GLenum buffer, GLint drawbuffer, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearBufferuiv(GLenum buffer, GLint drawbuffer, GLuint* value);
        private static TglClearBufferuiv glClearBufferuiv = null;

        // GLAPI void APIENTRY glClearBufferfv (GLenum buffer, GLint drawbuffer, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearBufferfv(GLenum buffer, GLint drawbuffer, GLfloat* value);
        private static TglClearBufferfv glClearBufferfv = null;

        // GLAPI void APIENTRY glClearBufferfi (GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearBufferfi(GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil);
        private static TglClearBufferfi glClearBufferfi = null;

        // GLAPI const GLubyte * APIENTRY glGetStringi (GLenum name, GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLubyte* TglGetStringi(GLenum name, GLuint index);
        private static TglGetStringi glGetStringi = null;

        /* OpenGL 3.0 also reuses entry points from these extensions: */
        /* ARB_framebuffer_object */
        // GLAPI GLboolean APIENTRY glIsRenderbuffer (GLuint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsRenderbuffer(GLuint renderbuffer);
        private static TglIsRenderbuffer glIsRenderbuffer = null;

        // GLAPI void APIENTRY glBindRenderbuffer (GLenum target, GLuint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindRenderbuffer(GLenum target, GLuint renderbuffer);
        private static TglBindRenderbuffer glBindRenderbuffer = null;

        // GLAPI void APIENTRY glDeleteRenderbuffers (GLsizei n, const GLuint *renderbuffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteRenderbuffers(GLsizei n, GLuint* renderbuffers);
        private static TglDeleteRenderbuffers glDeleteRenderbuffers = null;

        // GLAPI void APIENTRY glGenRenderbuffers (GLsizei n, GLuint *renderbuffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenRenderbuffers(GLsizei n, GLuint* renderbuffers);
        private static TglGenRenderbuffers glGenRenderbuffers = null;

        // GLAPI void APIENTRY glRenderbufferStorage (GLenum target, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglRenderbufferStorage glRenderbufferStorage = null;

        // GLAPI void APIENTRY glGetRenderbufferParameteriv (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetRenderbufferParameteriv(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetRenderbufferParameteriv glGetRenderbufferParameteriv = null;

        // GLAPI GLboolean APIENTRY glIsFramebuffer (GLuint framebuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsFramebuffer(GLuint framebuffer);
        private static TglIsFramebuffer glIsFramebuffer = null;

        // GLAPI void APIENTRY glBindFramebuffer (GLenum target, GLuint framebuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindFramebuffer(GLenum target, GLuint framebuffer);
        private static TglBindFramebuffer glBindFramebuffer = null;

        // GLAPI void APIENTRY glDeleteFramebuffers (GLsizei n, const GLuint *framebuffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteFramebuffers(GLsizei n, GLuint* framebuffers);
        private static TglDeleteFramebuffers glDeleteFramebuffers = null;

        // GLAPI void APIENTRY glGenFramebuffers (GLsizei n, GLuint *framebuffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenFramebuffers(GLsizei n, GLuint* framebuffers);
        private static TglGenFramebuffers glGenFramebuffers = null;

        // GLAPI GLenum APIENTRY glCheckFramebufferStatus (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLenum TglCheckFramebufferStatus(GLenum target);
        private static TglCheckFramebufferStatus glCheckFramebufferStatus = null;

        // GLAPI void APIENTRY glFramebufferTexture1D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTexture1D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        private static TglFramebufferTexture1D glFramebufferTexture1D = null;

        // GLAPI void APIENTRY glFramebufferTexture2D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level);
        private static TglFramebufferTexture2D glFramebufferTexture2D = null;

        // GLAPI void APIENTRY glFramebufferTexture3D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTexture3D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset);
        private static TglFramebufferTexture3D glFramebufferTexture3D = null;

        // GLAPI void APIENTRY glFramebufferRenderbuffer (GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
        private static TglFramebufferRenderbuffer glFramebufferRenderbuffer = null;

        // GLAPI void APIENTRY glGetFramebufferAttachmentParameteriv (GLenum target, GLenum attachment, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFramebufferAttachmentParameteriv(GLenum target, GLenum attachment, GLenum pname, GLint* parameters);
        private static TglGetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv = null;

        // GLAPI void APIENTRY glGenerateMipmap (GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGenerateMipmap(GLenum target);
        private static TglGenerateMipmap glGenerateMipmap = null;

        // GLAPI void APIENTRY glBlitFramebuffer (GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlitFramebuffer(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);
        private static TglBlitFramebuffer glBlitFramebuffer = null;

        // GLAPI void APIENTRY glRenderbufferStorageMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglRenderbufferStorageMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglRenderbufferStorageMultisample glRenderbufferStorageMultisample = null;

        // GLAPI void APIENTRY glFramebufferTextureLayer (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTextureLayer(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer);
        private static TglFramebufferTextureLayer glFramebufferTextureLayer = null;
        
        /* ARB_map_buffer_range */
        // GLAPI GLvoid* APIENTRY glMapBufferRange (GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void* TglMapBufferRange(GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access);
        private static TglMapBufferRange glMapBufferRange = null;

        // GLAPI void APIENTRY glFlushMappedBufferRange (GLenum target, GLintptr offset, GLsizeiptr length);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFlushMappedBufferRange(GLenum target, GLintptr offset, GLsizeiptr length);
        private static TglFlushMappedBufferRange glFlushMappedBufferRange = null;

        /* ARB_vertex_array_object */
        // GLAPI void APIENTRY glBindVertexArray (GLuint array);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindVertexArray(GLuint array);
        private static TglBindVertexArray glBindVertexArray = null;

        // GLAPI void APIENTRY glDeleteVertexArrays (GLsizei n, const GLuint *arrays);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteVertexArrays(GLsizei n, GLuint* arrays);
        private static TglDeleteVertexArrays glDeleteVertexArrays = null;

        // GLAPI void APIENTRY glGenVertexArrays (GLsizei n, GLuint *arrays);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenVertexArrays(GLsizei n, GLuint* arrays);
        private static TglGenVertexArrays glGenVertexArrays = null;

        // GLAPI GLboolean APIENTRY glIsVertexArray (GLuint array);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsVertexArray(GLuint array);
        private static TglIsVertexArray glIsVertexArray = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v3.1 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v3.1 FUNCTIONS...
        // GLAPI void APIENTRY glDrawArraysInstanced (GLenum mode, GLint first, GLsizei count, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawArraysInstanced(GLenum mode, GLint first, GLsizei count, GLsizei primcount);
        private static TglDrawArraysInstanced glDrawArraysInstanced = null;

        // GLAPI void APIENTRY glDrawElementsInstanced (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawElementsInstanced(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount);
        private static TglDrawElementsInstanced glDrawElementsInstanced = null;

        // GLAPI void APIENTRY glTexBuffer (GLenum target, GLenum internalformat, GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexBuffer(GLenum target, GLenum internalformat, GLuint buffer);
        private static TglTexBuffer glTexBuffer = null;

        // GLAPI void APIENTRY glPrimitiveRestartIndex (GLuint index);
        /* OpenGL 3.1 also reuses entry points from these extensions: */
        /* ARB_copy_buffer */
        // GLAPI void APIENTRY glCopyBufferSubData (GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyBufferSubData(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);
        private static TglCopyBufferSubData glCopyBufferSubData = null;

        /* ARB_uniform_buffer_object */
        // GLAPI void APIENTRY glGetUniformIndices (GLuint program, GLsizei uniformCount, const GLchar* *uniformNames, GLuint *uniformIndices);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformIndices(GLuint program, GLsizei uniformCount, GLchar** uniformNames, GLuint* uniformIndices);
        private static TglGetUniformIndices glGetUniformIndices = null;

        // GLAPI void APIENTRY glGetActiveUniformsiv (GLuint program, GLsizei uniformCount, const GLuint *uniformIndices, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetActiveUniformsiv(GLuint program, GLsizei uniformCount, GLuint* uniformIndices, GLenum pname, GLint* parameters);
        private static TglGetActiveUniformsiv glGetActiveUniformsiv = null;

        // GLAPI void APIENTRY glGetActiveUniformName (GLuint program, GLuint uniformIndex, GLsizei bufSize, GLsizei *length, GLchar *uniformName);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetActiveUniformName(GLuint program, GLuint uniformIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformName);
        private static TglGetActiveUniformName glGetActiveUniformName = null;

        // GLAPI GLuint APIENTRY glGetUniformBlockIndex (GLuint program, const GLchar *uniformBlockName);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformBlockIndex(GLuint program, [MarshalAs(UnmanagedType.LPStr)] string uniformBlockName);
        private static TglGetUniformBlockIndex glGetUniformBlockIndex = null;

        // GLAPI void APIENTRY glGetActiveUniformBlockiv (GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetActiveUniformBlockiv(GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint* parameters);
        private static TglGetActiveUniformBlockiv glGetActiveUniformBlockiv = null;

        // GLAPI void APIENTRY glGetActiveUniformBlockName (GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei *length, GLchar *uniformBlockName);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetActiveUniformBlockName(GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei* length, GLchar* uniformBlockName);
        private static TglGetActiveUniformBlockName glGetActiveUniformBlockName = null;

        // GLAPI void APIENTRY glUniformBlockBinding (GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniformBlockBinding(GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding);
        private static TglUniformBlockBinding glUniformBlockBinding = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v3.2 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v3.2 FUNCTIONS...
        // GLAPI void APIENTRY glGetInteger64i_v (GLenum target, GLuint index, GLint64 *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetInteger64i_v(GLenum target, GLuint index, GLint64* data);
        private static TglGetInteger64i_v glGetInteger64i_v = null;

        // GLAPI void APIENTRY glGetBufferParameteri64v (GLenum target, GLenum pname, GLint64 *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetBufferParameteri64v(GLenum target, GLenum pname, GLint64* parameters);
        private static TglGetBufferParameteri64v glGetBufferParameteri64v = null;

        // GLAPI void APIENTRY glFramebufferTexture (GLenum target, GLenum attachment, GLuint texture, GLint level);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferTexture(GLenum target, GLenum attachment, GLuint texture, GLint level);
        private static TglFramebufferTexture glFramebufferTexture = null;

        /* OpenGL 3.2 also reuses entry points from these extensions: */
        /* ARB_draw_elements_base_vertex */
        // GLAPI void APIENTRY glDrawElementsBaseVertex (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLint basevertex);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawElementsBaseVertex(GLenum mode, GLsizei count, GLenum type, void* indices, GLint basevertex);
        private static TglDrawElementsBaseVertex glDrawElementsBaseVertex = null;

        // GLAPI void APIENTRY glDrawRangeElementsBaseVertex (GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, const GLvoid *indices, GLint basevertex);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawRangeElementsBaseVertex(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices, GLint basevertex);
        private static TglDrawRangeElementsBaseVertex glDrawRangeElementsBaseVertex = null;

        // GLAPI void APIENTRY glDrawElementsInstancedBaseVertex (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLsizei primcount, GLint basevertex);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawElementsInstancedBaseVertex(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount, GLint basevertex);
        private static TglDrawElementsInstancedBaseVertex glDrawElementsInstancedBaseVertex = null;

        // GLAPI void APIENTRY glMultiDrawElementsBaseVertex (GLenum mode, const GLsizei *count, GLenum type, const GLvoid* *indices, GLsizei primcount, const GLint *basevertex);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawElementsBaseVertex(GLenum mode, GLsizei* count, GLenum type, void** indices, GLsizei primcount, GLint* basevertex);
        private static TglMultiDrawElementsBaseVertex glMultiDrawElementsBaseVertex = null;
        
        /* ARB_provoking_vertex */
        // GLAPI void APIENTRY glProvokingVertex (GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProvokingVertex(GLenum mode);
        private static TglProvokingVertex glProvokingVertex = null;

        /* ARB_sync */
        // GLAPI GLsync APIENTRY glFenceSync (GLenum condition, GLbitfield flags);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLsync TglFenceSync(GLenum condition, GLbitfield flags);
        private static TglFenceSync glFenceSync = null;

        // GLAPI GLboolean APIENTRY glIsSync (GLsync sync);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsSync(GLsync sync);
        private static TglIsSync glIsSync = null;

        // GLAPI void APIENTRY glDeleteSync (GLsync sync);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDeleteSync(GLsync sync);
        private static TglDeleteSync glDeleteSync = null;

        // GLAPI GLenum APIENTRY glClientWaitSync (GLsync sync, GLbitfield flags, GLuint64 timeout);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLenum TglClientWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);
        private static TglClientWaitSync glClientWaitSync = null;

        // GLAPI void APIENTRY glWaitSync (GLsync sync, GLbitfield flags, GLuint64 timeout);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout);
        private static TglWaitSync glWaitSync = null;

        // GLAPI void APIENTRY glGetInteger64v (GLenum pname, GLint64 *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetInteger64v(GLenum pname, GLint64* parameters);
        private static TglGetInteger64v glGetInteger64v = null;
        
        // GLAPI void APIENTRY glGetSynciv (GLsync sync, GLenum pname, GLsizei bufSize, GLsizei *length, GLint *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetSynciv(GLsync sync, GLenum pname, GLsizei bufSize, GLsizei* length, GLint* values);
        private static TglGetSynciv glGetSynciv = null;

        /* ARB_texture_multisample */
        // GLAPI void APIENTRY glTexImage2DMultisample (GLenum target, GLsizei samples, GLint internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexImage2DMultisample(GLenum target, GLsizei samples, GLint internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);
        private static TglTexImage2DMultisample glTexImage2DMultisample = null;

        // GLAPI void APIENTRY glTexImage3DMultisample (GLenum target, GLsizei samples, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexImage3DMultisample(GLenum target, GLsizei samples, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);
        private static TglTexImage3DMultisample glTexImage3DMultisample = null;

        // GLAPI void APIENTRY glGetMultisamplefv (GLenum pname, GLuint index, GLfloat *val);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetMultisamplefv(GLenum pname, GLuint index, GLfloat* val);
        private static TglGetMultisamplefv glGetMultisamplefv = null;

        // GLAPI void APIENTRY glSampleMaski (GLuint index, GLbitfield mask);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSampleMaski(GLuint index, GLbitfield mask);
        private static TglSampleMaski glSampleMaski = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v3.3 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v3.3 FUNCTIONS...
        // GLAPI void APIENTRY glVertexAttribDivisor (GLuint index, GLuint divisor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribDivisor(GLuint index, GLuint divisor);
        private static TglVertexAttribDivisor glVertexAttribDivisor = null;

        /* OpenGL 3.3 also reuses entry points from these extensions: */
        /* ARB_blend_func_extended */
        // GLAPI void APIENTRY glBindFragDataLocationIndexed (GLuint program, GLuint colorNumber, GLuint index, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindFragDataLocationIndexed(GLuint program, GLuint colorNumber, GLuint index, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglBindFragDataLocationIndexed glBindFragDataLocationIndexed = null;
        
        // GLAPI GLint APIENTRY glGetFragDataIndex (GLuint program, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLint TglGetFragDataIndex(GLuint program, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglGetFragDataIndex glGetFragDataIndex = null;

        /* ARB_sampler_objects */
        // GLAPI void APIENTRY glGenSamplers (GLsizei count, GLuint *samplers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenSamplers(GLsizei count, GLuint* samplers);
        private static TglGenSamplers glGenSamplers = null;

        // GLAPI void APIENTRY glDeleteSamplers (GLsizei count, const GLuint *samplers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteSamplers(GLsizei count, GLuint* samplers);
        private static TglDeleteSamplers glDeleteSamplers = null;

        // GLAPI GLboolean APIENTRY glIsSampler (GLuint sampler);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsSampler(GLuint sampler);
        private static TglIsSampler glIsSampler = null;

        // GLAPI void APIENTRY glBindSampler (GLuint unit, GLuint sampler);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindSampler(GLuint unit, GLuint sampler);
        private static TglBindSampler glBindSampler = null;

        // GLAPI void APIENTRY glSamplerParameteri (GLuint sampler, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSamplerParameteri(GLuint sampler, GLenum pname, GLint param);
        private static TglSamplerParameteri glSamplerParameteri = null;

        // GLAPI void APIENTRY glSamplerParameteriv (GLuint sampler, GLenum pname, const GLint *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSamplerParameteriv(GLuint sampler, GLenum pname, GLint* param);
        private static TglSamplerParameteriv glSamplerParameteriv = null;

        // GLAPI void APIENTRY glSamplerParameterf (GLuint sampler, GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSamplerParameterf(GLuint sampler, GLenum pname, GLfloat param);
        private static TglSamplerParameterf glSamplerParameterf = null;

        // GLAPI void APIENTRY glSamplerParameterfv (GLuint sampler, GLenum pname, const GLfloat *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* param);
        private static TglSamplerParameterfv glSamplerParameterfv = null;

        // GLAPI void APIENTRY glSamplerParameterIiv (GLuint sampler, GLenum pname, const GLint *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* param);
        private static TglSamplerParameterIiv glSamplerParameterIiv = null;

        // GLAPI void APIENTRY glSamplerParameterIuiv (GLuint sampler, GLenum pname, const GLuint *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* param);
        private static TglSamplerParameterIuiv glSamplerParameterIuiv = null;

        // GLAPI void APIENTRY glGetSamplerParameteriv (GLuint sampler, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetSamplerParameteriv(GLuint sampler, GLenum pname, GLint* parameters);
        private static TglGetSamplerParameteriv glGetSamplerParameteriv = null;

        // GLAPI void APIENTRY glGetSamplerParameterIiv (GLuint sampler, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetSamplerParameterIiv(GLuint sampler, GLenum pname, GLint* parameters);
        private static TglGetSamplerParameterIiv glGetSamplerParameterIiv = null;

        // GLAPI void APIENTRY glGetSamplerParameterfv (GLuint sampler, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat* parameters);
        private static TglGetSamplerParameterfv glGetSamplerParameterfv = null;

        // GLAPI void APIENTRY glGetSamplerParameterIuiv (GLuint sampler, GLenum pname, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint* parameters);
        private static TglGetSamplerParameterIuiv glGetSamplerParameterIuiv = null;

        /* ARB_explicit_attrib_location (no entry points) */
        /* ARB_occlusion_query2 (no entry points) */
        /* ARB_shader_bit_encoding (no entry points) */
        /* ARB_texture_rgb10_a2ui (no entry points) */
        /* ARB_texture_swizzle (no entry points) */
        /* ARB_timer_query */
        // GLAPI void APIENTRY glQueryCounter (GLuint id, GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglQueryCounter(GLuint id, GLenum target);
        private static TglQueryCounter glQueryCounter = null;

        // GLAPI void APIENTRY glGetQueryObjecti64v (GLuint id, GLenum pname, GLint64 *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetQueryObjecti64v(GLuint id, GLenum pname, GLint64* parameters);
        private static TglGetQueryObjecti64v glGetQueryObjecti64v = null;

        // GLAPI void APIENTRY glGetQueryObjectui64v (GLuint id, GLenum pname, GLuint64 *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetQueryObjectui64v(GLuint id, GLenum pname, GLuint64* parameters);
        private static TglGetQueryObjectui64v glGetQueryObjectui64v = null;

        /* ARB_vertex_type_2_10_10_10_rev */
        // GLAPI void APIENTRY glVertexP2ui (GLenum type, GLuint value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexP2ui(GLenum type, GLuint value);
        private static TglVertexP2ui glVertexP2ui = null;

        // GLAPI void APIENTRY glVertexP2uiv (GLenum type, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexP2uiv(GLenum type, GLuint* value);
        private static TglVertexP2uiv glVertexP2uiv = null;

        // GLAPI void APIENTRY glVertexP3ui (GLenum type, GLuint value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexP3ui(GLenum type, GLuint value);
        private static TglVertexP3ui glVertexP3ui = null;

        // GLAPI void APIENTRY glVertexP3uiv (GLenum type, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexP3uiv(GLenum type, GLuint* value);
        private static TglVertexP3uiv glVertexP3uiv = null;

        // GLAPI void APIENTRY glVertexP4ui (GLenum type, GLuint value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexP4ui(GLenum type, GLuint value);
        private static TglVertexP4ui glVertexP4ui = null;

        // GLAPI void APIENTRY glVertexP4uiv (GLenum type, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexP4uiv(GLenum type, GLuint* value);
        private static TglVertexP4uiv glVertexP4uiv = null;

        // GLAPI void APIENTRY glTexCoordP1ui (GLenum type, GLuint coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoordP1ui(GLenum type, GLuint coords);
        private static TglTexCoordP1ui glTexCoordP1ui = null;

        // GLAPI void APIENTRY glTexCoordP1uiv (GLenum type, const GLuint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoordP1uiv(GLenum type, GLuint* coords);
        private static TglTexCoordP1uiv glTexCoordP1uiv = null;

        // GLAPI void APIENTRY glTexCoordP2ui (GLenum type, GLuint coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoordP2ui(GLenum type, GLuint coords);
        private static TglTexCoordP2ui glTexCoordP2ui = null;

        // GLAPI void APIENTRY glTexCoordP2uiv (GLenum type, const GLuint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoordP2uiv(GLenum type, GLuint* coords);
        private static TglTexCoordP2uiv glTexCoordP2uiv = null;

        // GLAPI void APIENTRY glTexCoordP3ui (GLenum type, GLuint coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoordP3ui(GLenum type, GLuint coords);
        private static TglTexCoordP3ui glTexCoordP3ui = null;

        // GLAPI void APIENTRY glTexCoordP3uiv (GLenum type, const GLuint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoordP3uiv(GLenum type, GLuint* coords);
        private static TglTexCoordP3uiv glTexCoordP3uiv = null;

        // GLAPI void APIENTRY glTexCoordP4ui (GLenum type, GLuint coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexCoordP4ui(GLenum type, GLuint coords);
        private static TglTexCoordP4ui glTexCoordP4ui = null;

        // GLAPI void APIENTRY glTexCoordP4uiv (GLenum type, const GLuint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTexCoordP4uiv(GLenum type, GLuint* coords);
        private static TglTexCoordP4uiv glTexCoordP4uiv = null;

        // GLAPI void APIENTRY glMultiTexCoordP1ui (GLenum texture, GLenum type, GLuint coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoordP1ui(GLenum texture, GLenum type, GLuint coords);
        private static TglMultiTexCoordP1ui glMultiTexCoordP1ui = null;

        // GLAPI void APIENTRY glMultiTexCoordP1uiv (GLenum texture, GLenum type, const GLuint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoordP1uiv(GLenum texture, GLenum type, GLuint* coords);
        private static TglMultiTexCoordP1uiv glMultiTexCoordP1uiv = null;

        // GLAPI void APIENTRY glMultiTexCoordP2ui (GLenum texture, GLenum type, GLuint coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoordP2ui(GLenum texture, GLenum type, GLuint coords);
        private static TglMultiTexCoordP2ui glMultiTexCoordP2ui = null;

        // GLAPI void APIENTRY glMultiTexCoordP2uiv (GLenum texture, GLenum type, const GLuint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoordP2uiv(GLenum texture, GLenum type, GLuint* coords);
        private static TglMultiTexCoordP2uiv glMultiTexCoordP2uiv = null;

        // GLAPI void APIENTRY glMultiTexCoordP3ui (GLenum texture, GLenum type, GLuint coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoordP3ui(GLenum texture, GLenum type, GLuint coords);
        private static TglMultiTexCoordP3ui glMultiTexCoordP3ui = null;

        // GLAPI void APIENTRY glMultiTexCoordP3uiv (GLenum texture, GLenum type, const GLuint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoordP3uiv(GLenum texture, GLenum type, GLuint* coords);
        private static TglMultiTexCoordP3uiv glMultiTexCoordP3uiv = null;

        // GLAPI void APIENTRY glMultiTexCoordP4ui (GLenum texture, GLenum type, GLuint coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMultiTexCoordP4ui(GLenum texture, GLenum type, GLuint coords);
        private static TglMultiTexCoordP4ui glMultiTexCoordP4ui = null;

        // GLAPI void APIENTRY glMultiTexCoordP4uiv (GLenum texture, GLenum type, const GLuint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiTexCoordP4uiv(GLenum texture, GLenum type, GLuint* coords);
        private static TglMultiTexCoordP4uiv glMultiTexCoordP4uiv = null;

        // GLAPI void APIENTRY glNormalP3ui (GLenum type, GLuint coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNormalP3ui(GLenum type, GLuint coords);
        private static TglNormalP3ui glNormalP3ui = null;

        // GLAPI void APIENTRY glNormalP3uiv (GLenum type, const GLuint *coords);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNormalP3uiv(GLenum type, GLuint* coords);
        private static TglNormalP3uiv glNormalP3uiv = null;
        
        // GLAPI void APIENTRY glColorP3ui (GLenum type, GLuint color);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColorP3ui(GLenum type, GLuint color);
        private static TglColorP3ui glColorP3ui = null;

        // GLAPI void APIENTRY glColorP3uiv (GLenum type, const GLuint *color);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorP3uiv(GLenum type, GLuint* color);
        private static TglColorP3uiv glColorP3uiv = null;

        // GLAPI void APIENTRY glColorP4ui (GLenum type, GLuint color);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglColorP4ui(GLenum type, GLuint color);
        private static TglColorP4ui glColorP4ui = null;

        // GLAPI void APIENTRY glColorP4uiv (GLenum type, const GLuint *color);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglColorP4uiv(GLenum type, GLuint* color);
        private static TglColorP4uiv glColorP4uiv = null;

        // GLAPI void APIENTRY glSecondaryColorP3ui (GLenum type, GLuint color);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglSecondaryColorP3ui(GLenum type, GLuint color);
        private static TglSecondaryColorP3ui glSecondaryColorP3ui = null;

        // GLAPI void APIENTRY glSecondaryColorP3uiv (GLenum type, const GLuint *color);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglSecondaryColorP3uiv(GLenum type, GLuint* color);
        private static TglSecondaryColorP3uiv glSecondaryColorP3uiv = null;

        // GLAPI void APIENTRY glVertexAttribP1ui (GLuint index, GLenum type, GLboolean normalized, GLuint value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribP1ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);
        private static TglVertexAttribP1ui glVertexAttribP1ui = null;

        // GLAPI void APIENTRY glVertexAttribP1uiv (GLuint index, GLenum type, GLboolean normalized, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribP1uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);
        private static TglVertexAttribP1uiv glVertexAttribP1uiv = null;

        // GLAPI void APIENTRY glVertexAttribP2ui (GLuint index, GLenum type, GLboolean normalized, GLuint value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribP2ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);
        private static TglVertexAttribP2ui glVertexAttribP2ui = null;

        // GLAPI void APIENTRY glVertexAttribP2uiv (GLuint index, GLenum type, GLboolean normalized, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribP2uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);
        private static TglVertexAttribP2uiv glVertexAttribP2uiv = null;

        // GLAPI void APIENTRY glVertexAttribP3ui (GLuint index, GLenum type, GLboolean normalized, GLuint value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribP3ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);
        private static TglVertexAttribP3ui glVertexAttribP3ui = null;

        // GLAPI void APIENTRY glVertexAttribP3uiv (GLuint index, GLenum type, GLboolean normalized, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribP3uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);
        private static TglVertexAttribP3uiv glVertexAttribP3uiv = null;

        // GLAPI void APIENTRY glVertexAttribP4ui (GLuint index, GLenum type, GLboolean normalized, GLuint value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribP4ui(GLuint index, GLenum type, GLboolean normalized, GLuint value);
        private static TglVertexAttribP4ui glVertexAttribP4ui = null;

        // GLAPI void APIENTRY glVertexAttribP4uiv (GLuint index, GLenum type, GLboolean normalized, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribP4uiv(GLuint index, GLenum type, GLboolean normalized, GLuint* value);
        private static TglVertexAttribP4uiv glVertexAttribP4uiv = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v4.0 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v4.0 FUNCTIONS...
        // GLAPI void APIENTRY glMinSampleShading (GLclampf value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMinSampleShading(GLclampf value);
        private static TglMinSampleShading glMinSampleShading = null;

        // GLAPI void APIENTRY glBlendEquationi (GLuint buf, GLenum mode);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendEquationi(GLuint buf, GLenum mode);
        private static TglBlendEquationi glBlendEquationi = null;

        // GLAPI void APIENTRY glBlendEquationSeparatei (GLuint buf, GLenum modeRGB, GLenum modeAlpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendEquationSeparatei(GLuint buf, GLenum modeRGB, GLenum modeAlpha);
        private static TglBlendEquationSeparatei glBlendEquationSeparatei = null;

        // GLAPI void APIENTRY glBlendFunci (GLuint buf, GLenum src, GLenum dst);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendFunci(GLuint buf, GLenum src, GLenum dst);
        private static TglBlendFunci glBlendFunci = null;

        // GLAPI void APIENTRY glBlendFuncSeparatei (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlendFuncSeparatei(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha);
        private static TglBlendFuncSeparatei glBlendFuncSeparatei = null;

        /* OpenGL 4.0 also reuses entry points from these extensions: */
        /* ARB_texture_query_lod (no entry points) */
        /* ARB_draw_indirect */
        // GLAPI void APIENTRY glDrawArraysIndirect (GLenum mode, const GLvoid *indirect);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawArraysIndirect(GLenum mode, void* indirect);
        private static TglDrawArraysIndirect glDrawArraysIndirect = null;

        // GLAPI void APIENTRY glDrawElementsIndirect (GLenum mode, GLenum type, const GLvoid *indirect);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawElementsIndirect(GLenum mode, GLenum type, void* indirect);
        private static TglDrawElementsIndirect glDrawElementsIndirect = null;

        /* ARB_gpu_shader5 (no entry points) */
        /* ARB_gpu_shader_fp64 */
        // GLAPI void APIENTRY glUniform1d (GLint location, GLdouble x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform1d(GLint location, GLdouble x);
        private static TglUniform1d glUniform1d = null;

        // GLAPI void APIENTRY glUniform2d (GLint location, GLdouble x, GLdouble y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform2d(GLint location, GLdouble x, GLdouble y);
        private static TglUniform2d glUniform2d = null;

        // GLAPI void APIENTRY glUniform3d (GLint location, GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform3d(GLint location, GLdouble x, GLdouble y, GLdouble z);
        private static TglUniform3d glUniform3d = null;

        // GLAPI void APIENTRY glUniform4d (GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUniform4d(GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglUniform4d glUniform4d = null;

        // GLAPI void APIENTRY glUniform1dv (GLint location, GLsizei count, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform1dv(GLint location, GLsizei count, GLdouble* value);
        private static TglUniform1dv glUniform1dv = null;

        // GLAPI void APIENTRY glUniform2dv (GLint location, GLsizei count, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform2dv(GLint location, GLsizei count, GLdouble* value);
        private static TglUniform2dv glUniform2dv = null;

        // GLAPI void APIENTRY glUniform3dv (GLint location, GLsizei count, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform3dv(GLint location, GLsizei count, GLdouble* value);
        private static TglUniform3dv glUniform3dv = null;

        // GLAPI void APIENTRY glUniform4dv (GLint location, GLsizei count, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniform4dv(GLint location, GLsizei count, GLdouble* value);
        private static TglUniform4dv glUniform4dv = null;

        // GLAPI void APIENTRY glUniformMatrix2dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglUniformMatrix2dv glUniformMatrix2dv = null;

        // GLAPI void APIENTRY glUniformMatrix3dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglUniformMatrix3dv glUniformMatrix3dv = null;

        // GLAPI void APIENTRY glUniformMatrix4dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglUniformMatrix4dv glUniformMatrix4dv = null;

        // GLAPI void APIENTRY glUniformMatrix2x3dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix2x3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglUniformMatrix2x3dv glUniformMatrix2x3dv = null;

        // GLAPI void APIENTRY glUniformMatrix2x4dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix2x4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglUniformMatrix2x4dv glUniformMatrix2x4dv = null;

        // GLAPI void APIENTRY glUniformMatrix3x2dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix3x2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglUniformMatrix3x2dv glUniformMatrix3x2dv = null;

        // GLAPI void APIENTRY glUniformMatrix3x4dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix3x4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglUniformMatrix3x4dv glUniformMatrix3x4dv = null;

        // GLAPI void APIENTRY glUniformMatrix4x2dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix4x2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglUniformMatrix4x2dv glUniformMatrix4x2dv = null;

        // GLAPI void APIENTRY glUniformMatrix4x3dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformMatrix4x3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglUniformMatrix4x3dv glUniformMatrix4x3dv = null;

        // GLAPI void APIENTRY glGetUniformdv (GLuint program, GLint location, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformdv(GLuint program, GLint location, GLdouble* parameters);
        private static TglGetUniformdv glGetUniformdv = null;
        
        /* ARB_shader_subroutine */
        // GLAPI GLint APIENTRY glGetSubroutineUniformLocation (GLuint program, GLenum shadertype, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLint TglGetSubroutineUniformLocation(GLuint program, GLenum shadertype, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglGetSubroutineUniformLocation glGetSubroutineUniformLocation = null;

        // GLAPI GLuint APIENTRY glGetSubroutineIndex (GLuint program, GLenum shadertype, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglGetSubroutineIndex(GLuint program, GLenum shadertype, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglGetSubroutineIndex glGetSubroutineIndex = null;

        // GLAPI void APIENTRY glGetActiveSubroutineUniformiv (GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetActiveSubroutineUniformiv(GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint* values);
        private static TglGetActiveSubroutineUniformiv glGetActiveSubroutineUniformiv = null;

        // GLAPI void APIENTRY glGetActiveSubroutineUniformName (GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei *length, GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetActiveSubroutineUniformName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei* length, GLchar* name);
        private static TglGetActiveSubroutineUniformName glGetActiveSubroutineUniformName = null;

        // GLAPI void APIENTRY glGetActiveSubroutineName (GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei *length, GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetActiveSubroutineName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei* length, GLchar* name);
        private static TglGetActiveSubroutineName glGetActiveSubroutineName = null;

        // GLAPI void APIENTRY glUniformSubroutinesuiv (GLenum shadertype, GLsizei count, const GLuint *indices);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglUniformSubroutinesuiv(GLenum shadertype, GLsizei count, GLuint* indices);
        private static TglUniformSubroutinesuiv glUniformSubroutinesuiv = null;

        // GLAPI void APIENTRY glGetUniformSubroutineuiv (GLenum shadertype, GLint location, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetUniformSubroutineuiv(GLenum shadertype, GLint location, GLuint* parameters);
        private static TglGetUniformSubroutineuiv glGetUniformSubroutineuiv = null;

        // GLAPI void APIENTRY glGetProgramStageiv (GLuint program, GLenum shadertype, GLenum pname, GLint *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramStageiv(GLuint program, GLenum shadertype, GLenum pname, GLint* values);
        private static TglGetProgramStageiv glGetProgramStageiv = null;
        
        /* ARB_tessellation_shader */
        // GLAPI void APIENTRY glPatchParameteri (GLenum pname, GLint value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPatchParameteri(GLenum pname, GLint value);
        private static TglPatchParameteri glPatchParameteri = null;

        // GLAPI void APIENTRY glPatchParameterfv (GLenum pname, const GLfloat *values);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglPatchParameterfv(GLenum pname, GLfloat* values);
        private static TglPatchParameterfv glPatchParameterfv = null;

        /* ARB_texture_buffer_object_rgb32 (no entry points) */
        /* ARB_texture_cube_map_array (no entry points) */
        /* ARB_texture_gather (no entry points) */
        /* ARB_transform_feedback2 */
        // GLAPI void APIENTRY glBindTransformFeedback (GLenum target, GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindTransformFeedback(GLenum target, GLuint id);
        private static TglBindTransformFeedback glBindTransformFeedback = null;

        // GLAPI void APIENTRY glDeleteTransformFeedbacks (GLsizei n, const GLuint *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteTransformFeedbacks(GLsizei n, GLuint* ids);
        private static TglDeleteTransformFeedbacks glDeleteTransformFeedbacks = null;

        // GLAPI void APIENTRY glGenTransformFeedbacks (GLsizei n, GLuint *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenTransformFeedbacks(GLsizei n, GLuint* ids);
        private static TglGenTransformFeedbacks glGenTransformFeedbacks = null;

        // GLAPI GLboolean APIENTRY glIsTransformFeedback (GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsTransformFeedback(GLuint id);
        private static TglIsTransformFeedback glIsTransformFeedback = null;

        // GLAPI void APIENTRY glPauseTransformFeedback (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPauseTransformFeedback();
        private static TglPauseTransformFeedback glPauseTransformFeedback = null;

        // GLAPI void APIENTRY glResumeTransformFeedback (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglResumeTransformFeedback();
        private static TglResumeTransformFeedback glResumeTransformFeedback = null;

        // GLAPI void APIENTRY glDrawTransformFeedback (GLenum mode, GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawTransformFeedback(GLenum mode, GLuint id);
        private static TglDrawTransformFeedback glDrawTransformFeedback = null;

        /* ARB_transform_feedback3 */
        // GLAPI void APIENTRY glDrawTransformFeedbackStream (GLenum mode, GLuint id, GLuint stream);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawTransformFeedbackStream(GLenum mode, GLuint id, GLuint stream);
        private static TglDrawTransformFeedbackStream glDrawTransformFeedbackStream = null;

        // GLAPI void APIENTRY glBeginQueryIndexed (GLenum target, GLuint index, GLuint id);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBeginQueryIndexed(GLenum target, GLuint index, GLuint id);
        private static TglBeginQueryIndexed glBeginQueryIndexed = null;

        // GLAPI void APIENTRY glEndQueryIndexed (GLenum target, GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEndQueryIndexed(GLenum target, GLuint index);
        private static TglEndQueryIndexed glEndQueryIndexed = null;

        // GLAPI void APIENTRY glGetQueryIndexediv (GLenum target, GLuint index, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetQueryIndexediv(GLenum target, GLuint index, GLenum pname, GLint* parameters);
        private static TglGetQueryIndexediv glGetQueryIndexediv = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v4.1 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v4.1 FUNCTIONS...
        /* OpenGL 4.1 reuses entry points from these extensions: */
        /* ARB_ES2_compatibility */
        // GLAPI void APIENTRY glReleaseShaderCompiler (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglReleaseShaderCompiler();
        private static TglReleaseShaderCompiler glReleaseShaderCompiler = null;

        // GLAPI void APIENTRY glShaderBinary (GLsizei count, const GLuint *shaders, GLenum binaryformat, const GLvoid *binary, GLsizei length);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglShaderBinary(GLsizei count, GLuint* shaders, GLenum binaryformat, void* binary, GLsizei length);
        private static TglShaderBinary glShaderBinary = null;

        // GLAPI void APIENTRY glGetShaderPrecisionFormat (GLenum shadertype, GLenum precisiontype, GLint *range, GLint *precision);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, GLint* range, GLint* precision);
        private static TglGetShaderPrecisionFormat glGetShaderPrecisionFormat = null;

        // GLAPI void APIENTRY glDepthRangef (GLclampf n, GLclampf f);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDepthRangef(GLclampf n, GLclampf f);
        private static TglDepthRangef glDepthRangef = null;

        // GLAPI void APIENTRY glClearDepthf (GLclampf d);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearDepthf(GLclampf d);
        private static TglClearDepthf glClearDepthf = null;

        /* ARB_get_program_binary */
        // GLAPI void APIENTRY glGetProgramBinary (GLuint program, GLsizei bufSize, GLsizei *length, GLenum *binaryFormat, GLvoid *binary);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramBinary(GLuint program, GLsizei bufSize, GLsizei* length, GLenum* binaryFormat, void* binary);
        private static TglGetProgramBinary glGetProgramBinary = null;

        // GLAPI void APIENTRY glProgramBinary (GLuint program, GLenum binaryFormat, const GLvoid *binary, GLsizei length);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramBinary(GLuint program, GLenum binaryFormat, void* binary, GLsizei length);
        private static TglProgramBinary glProgramBinary = null;

        // GLAPI void APIENTRY glProgramParameteri (GLuint program, GLenum pname, GLint value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramParameteri(GLuint program, GLenum pname, GLint value);
        private static TglProgramParameteri glProgramParameteri = null;

        /* ARB_separate_shader_objects */
        // GLAPI void APIENTRY glUseProgramStages (GLuint pipeline, GLbitfield stages, GLuint program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglUseProgramStages(GLuint pipeline, GLbitfield stages, GLuint program);
        private static TglUseProgramStages glUseProgramStages = null;

        // GLAPI void APIENTRY glActiveShaderProgram (GLuint pipeline, GLuint program);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglActiveShaderProgram(GLuint pipeline, GLuint program);
        private static TglActiveShaderProgram glActiveShaderProgram = null;

        // GLAPI GLuint APIENTRY glCreateShaderProgramv (GLenum type, GLsizei count, const GLchar* *strings);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLuint TglCreateShaderProgramv(GLenum type, GLsizei count, GLchar** strings);
        private static TglCreateShaderProgramv glCreateShaderProgramv = null;

        // GLAPI void APIENTRY glBindProgramPipeline (GLuint pipeline);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindProgramPipeline(GLuint pipeline);
        private static TglBindProgramPipeline glBindProgramPipeline = null;

        // GLAPI void APIENTRY glDeleteProgramPipelines (GLsizei n, const GLuint *pipelines);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDeleteProgramPipelines(GLsizei n, GLuint* pipelines);
        private static TglDeleteProgramPipelines glDeleteProgramPipelines = null;

        // GLAPI void APIENTRY glGenProgramPipelines (GLsizei n, GLuint *pipelines);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGenProgramPipelines(GLsizei n, GLuint* pipelines);
        private static TglGenProgramPipelines glGenProgramPipelines = null;

        // GLAPI GLboolean APIENTRY glIsProgramPipeline (GLuint pipeline);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglIsProgramPipeline(GLuint pipeline);
        private static TglIsProgramPipeline glIsProgramPipeline = null;

        // GLAPI void APIENTRY glGetProgramPipelineiv (GLuint pipeline, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramPipelineiv(GLuint pipeline, GLenum pname, GLint* parameters);
        private static TglGetProgramPipelineiv glGetProgramPipelineiv = null;

        // GLAPI void APIENTRY glProgramUniform1i (GLuint program, GLint location, GLint v0);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform1i(GLuint program, GLint location, GLint v0);
        private static TglProgramUniform1i glProgramUniform1i = null;

        // GLAPI void APIENTRY glProgramUniform1iv (GLuint program, GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform1iv(GLuint program, GLint location, GLsizei count, GLint* value);
        private static TglProgramUniform1iv glProgramUniform1iv = null;

        // GLAPI void APIENTRY glProgramUniform1f (GLuint program, GLint location, GLfloat v0);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform1f(GLuint program, GLint location, GLfloat v0);
        private static TglProgramUniform1f glProgramUniform1f = null;

        // GLAPI void APIENTRY glProgramUniform1fv (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform1fv(GLuint program, GLint location, GLsizei count, GLfloat* value);
        private static TglProgramUniform1fv glProgramUniform1fv = null;

        // GLAPI void APIENTRY glProgramUniform1d (GLuint program, GLint location, GLdouble v0);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform1d(GLuint program, GLint location, GLdouble v0);
        private static TglProgramUniform1d glProgramUniform1d = null;

        // GLAPI void APIENTRY glProgramUniform1dv (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform1dv(GLuint program, GLint location, GLsizei count, GLdouble* value);
        private static TglProgramUniform1dv glProgramUniform1dv = null;

        // GLAPI void APIENTRY glProgramUniform1ui (GLuint program, GLint location, GLuint v0);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform1ui(GLuint program, GLint location, GLuint v0);
        private static TglProgramUniform1ui glProgramUniform1ui = null;

        // GLAPI void APIENTRY glProgramUniform1uiv (GLuint program, GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform1uiv(GLuint program, GLint location, GLsizei count, GLuint* value);
        private static TglProgramUniform1uiv glProgramUniform1uiv = null;

        // GLAPI void APIENTRY glProgramUniform2i (GLuint program, GLint location, GLint v0, GLint v1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform2i(GLuint program, GLint location, GLint v0, GLint v1);
        private static TglProgramUniform2i glProgramUniform2i = null;

        // GLAPI void APIENTRY glProgramUniform2iv (GLuint program, GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform2iv(GLuint program, GLint location, GLsizei count, GLint* value);
        private static TglProgramUniform2iv glProgramUniform2iv = null;

        // GLAPI void APIENTRY glProgramUniform2f (GLuint program, GLint location, GLfloat v0, GLfloat v1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform2f(GLuint program, GLint location, GLfloat v0, GLfloat v1);
        private static TglProgramUniform2f glProgramUniform2f = null;

        // GLAPI void APIENTRY glProgramUniform2fv (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform2fv(GLuint program, GLint location, GLsizei count, GLfloat* value);
        private static TglProgramUniform2fv glProgramUniform2fv = null;

        // GLAPI void APIENTRY glProgramUniform2d (GLuint program, GLint location, GLdouble v0, GLdouble v1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform2d(GLuint program, GLint location, GLdouble v0, GLdouble v1);
        private static TglProgramUniform2d glProgramUniform2d = null;

        // GLAPI void APIENTRY glProgramUniform2dv (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform2dv(GLuint program, GLint location, GLsizei count, GLdouble* value);
        private static TglProgramUniform2dv glProgramUniform2dv = null;

        // GLAPI void APIENTRY glProgramUniform2ui (GLuint program, GLint location, GLuint v0, GLuint v1);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform2ui(GLuint program, GLint location, GLuint v0, GLuint v1);
        private static TglProgramUniform2ui glProgramUniform2ui = null;

        // GLAPI void APIENTRY glProgramUniform2uiv (GLuint program, GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform2uiv(GLuint program, GLint location, GLsizei count, GLuint* value);
        private static TglProgramUniform2uiv glProgramUniform2uiv = null;

        // GLAPI void APIENTRY glProgramUniform3i (GLuint program, GLint location, GLint v0, GLint v1, GLint v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform3i(GLuint program, GLint location, GLint v0, GLint v1, GLint v2);
        private static TglProgramUniform3i glProgramUniform3i = null;

        // GLAPI void APIENTRY glProgramUniform3iv (GLuint program, GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform3iv(GLuint program, GLint location, GLsizei count, GLint* value);
        private static TglProgramUniform3iv glProgramUniform3iv = null;

        // GLAPI void APIENTRY glProgramUniform3f (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform3f(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2);
        private static TglProgramUniform3f glProgramUniform3f = null;

        // GLAPI void APIENTRY glProgramUniform3fv (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform3fv(GLuint program, GLint location, GLsizei count, GLfloat* value);
        private static TglProgramUniform3fv glProgramUniform3fv = null;

        // GLAPI void APIENTRY glProgramUniform3d (GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform3d(GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2);
        private static TglProgramUniform3d glProgramUniform3d = null;

        // GLAPI void APIENTRY glProgramUniform3dv (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform3dv(GLuint program, GLint location, GLsizei count, GLdouble* value);
        private static TglProgramUniform3dv glProgramUniform3dv = null;

        // GLAPI void APIENTRY glProgramUniform3ui (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform3ui(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2);
        private static TglProgramUniform3ui glProgramUniform3ui = null;

        // GLAPI void APIENTRY glProgramUniform3uiv (GLuint program, GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform3uiv(GLuint program, GLint location, GLsizei count, GLuint* value);
        private static TglProgramUniform3uiv glProgramUniform3uiv = null;

        // GLAPI void APIENTRY glProgramUniform4i (GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform4i(GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3);
        private static TglProgramUniform4i glProgramUniform4i = null;

        // GLAPI void APIENTRY glProgramUniform4iv (GLuint program, GLint location, GLsizei count, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform4iv(GLuint program, GLint location, GLsizei count, GLint* value);
        private static TglProgramUniform4iv glProgramUniform4iv = null;

        // GLAPI void APIENTRY glProgramUniform4f (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform4f(GLint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3);
        private static TglProgramUniform4f glProgramUniform4f = null;

        // GLAPI void APIENTRY glProgramUniform4fv (GLuint program, GLint location, GLsizei count, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform4fv(GLuint program, GLint location, GLsizei count, GLfloat* value);
        private static TglProgramUniform4fv glProgramUniform4fv = null;

        // GLAPI void APIENTRY glProgramUniform4d (GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2, GLdouble v3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform4d(GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2, GLdouble v3);
        private static TglProgramUniform4d glProgramUniform4d = null;

        // GLAPI void APIENTRY glProgramUniform4dv (GLuint program, GLint location, GLsizei count, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform4dv(GLuint program, GLint location, GLsizei count, GLdouble* value);
        private static TglProgramUniform4dv glProgramUniform4dv = null;

        // GLAPI void APIENTRY glProgramUniform4ui (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglProgramUniform4ui(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3);
        private static TglProgramUniform4ui glProgramUniform4ui = null;

        // GLAPI void APIENTRY glProgramUniform4uiv (GLuint program, GLint location, GLsizei count, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniform4uiv(GLuint program, GLint location, GLsizei count, GLuint* value);
        private static TglProgramUniform4uiv glProgramUniform4uiv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix2fv glProgramUniformMatrix2fv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix3fv glProgramUniformMatrix3fv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix4fv glProgramUniformMatrix4fv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix2dv glProgramUniformMatrix2dv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix3dv glProgramUniformMatrix3dv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix4dv glProgramUniformMatrix4dv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix2x3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix2x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix2x3fv glProgramUniformMatrix2x3fv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix3x2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix3x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix3x2fv glProgramUniformMatrix3x2fv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix2x4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix2x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix2x4fv glProgramUniformMatrix2x4fv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix4x2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix4x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix4x2fv glProgramUniformMatrix4x2fv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix3x4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix3x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix3x4fv glProgramUniformMatrix3x4fv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix4x3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix4x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat* value);
        private static TglProgramUniformMatrix4x3fv glProgramUniformMatrix4x3fv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix2x3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix2x3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix2x3dv glProgramUniformMatrix2x3dv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix3x2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix3x2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix3x2dv glProgramUniformMatrix3x2dv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix2x4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix2x4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix2x4dv glProgramUniformMatrix2x4dv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix4x2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix4x2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix4x2dv glProgramUniformMatrix4x2dv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix3x4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix3x4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix3x4dv glProgramUniformMatrix3x4dv = null;

        // GLAPI void APIENTRY glProgramUniformMatrix4x3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglProgramUniformMatrix4x3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble* value);
        private static TglProgramUniformMatrix4x3dv glProgramUniformMatrix4x3dv = null;

        // GLAPI void APIENTRY glValidateProgramPipeline (GLuint pipeline);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglValidateProgramPipeline(GLuint pipeline);
        private static TglValidateProgramPipeline glValidateProgramPipeline = null;

        // GLAPI void APIENTRY glGetProgramPipelineInfoLog (GLuint pipeline, GLsizei bufSize, GLsizei *length, GLchar *infoLog);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramPipelineInfoLog(GLuint pipeline, GLsizei bufSize, GLsizei* length, GLchar* infoLog);
        private static TglGetProgramPipelineInfoLog glGetProgramPipelineInfoLog = null;
        
        /* ARB_shader_precision (no entry points) */
        /* ARB_vertex_attrib_64bit */
        // GLAPI void APIENTRY glVertexAttribL1d (GLuint index, GLdouble x);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL1d(GLuint index, GLdouble x);
        private static TglVertexAttribL1d glVertexAttribL1d = null;

        // GLAPI void APIENTRY glVertexAttribL2d (GLuint index, GLdouble x, GLdouble y);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL2d(GLuint index, GLdouble x, GLdouble y);
        private static TglVertexAttribL2d glVertexAttribL2d = null;

        // GLAPI void APIENTRY glVertexAttribL3d (GLuint index, GLdouble x, GLdouble y, GLdouble z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL3d(GLuint index, GLdouble x, GLdouble y, GLdouble z);
        private static TglVertexAttribL3d glVertexAttribL3d = null;

        // GLAPI void APIENTRY glVertexAttribL4d (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribL4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w);
        private static TglVertexAttribL4d glVertexAttribL4d = null;

        // GLAPI void APIENTRY glVertexAttribL1dv (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL1dv(GLuint index, GLdouble* v);
        private static TglVertexAttribL1dv glVertexAttribL1dv = null;

        // GLAPI void APIENTRY glVertexAttribL2dv (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL2dv(GLuint index, GLdouble* v);
        private static TglVertexAttribL2dv glVertexAttribL2dv = null;

        // GLAPI void APIENTRY glVertexAttribL3dv (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL3dv(GLuint index, GLdouble* v);
        private static TglVertexAttribL3dv glVertexAttribL3dv = null;

        // GLAPI void APIENTRY glVertexAttribL4dv (GLuint index, const GLdouble *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribL4dv(GLuint index, GLdouble* v);
        private static TglVertexAttribL4dv glVertexAttribL4dv = null;

        // GLAPI void APIENTRY glVertexAttribLPointer (GLuint index, GLint size, GLenum type, GLsizei stride, const GLvoid *pointer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexAttribLPointer(GLuint index, GLint size, GLenum type, GLsizei stride, void* pointer);
        private static TglVertexAttribLPointer glVertexAttribLPointer = null;

        // GLAPI void APIENTRY glGetVertexAttribLdv (GLuint index, GLenum pname, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexAttribLdv(GLuint index, GLenum pname, GLdouble* parameters);
        private static TglGetVertexAttribLdv glGetVertexAttribLdv = null;

        /* ARB_viewport_array */
        // GLAPI void APIENTRY glViewportArrayv (GLuint first, GLsizei count, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglViewportArrayv(GLuint first, GLsizei count, GLfloat* v);
        private static TglViewportArrayv glViewportArrayv = null;

        // GLAPI void APIENTRY glViewportIndexedf (GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglViewportIndexedf(GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h);
        private static TglViewportIndexedf glViewportIndexedf = null;

        // GLAPI void APIENTRY glViewportIndexedfv (GLuint index, const GLfloat *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglViewportIndexedfv(GLuint index, GLfloat* v);
        private static TglViewportIndexedfv glViewportIndexedfv = null;

        // GLAPI void APIENTRY glScissorArrayv (GLuint first, GLsizei count, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglScissorArrayv(GLuint first, GLsizei count, GLint* v);
        private static TglScissorArrayv glScissorArrayv = null;

        // GLAPI void APIENTRY glScissorIndexed (GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglScissorIndexed(GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height);
        private static TglScissorIndexed glScissorIndexed = null;

        // GLAPI void APIENTRY glScissorIndexedv (GLuint index, const GLint *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglScissorIndexedv(GLuint index, GLint* v);
        private static TglScissorIndexedv glScissorIndexedv = null;

        // GLAPI void APIENTRY glDepthRangeArrayv (GLuint first, GLsizei count, const GLclampd *v);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDepthRangeArrayv(GLuint first, GLsizei count, GLclampd* v);
        private static TglDepthRangeArrayv glDepthRangeArrayv = null;

        // GLAPI void APIENTRY glDepthRangeIndexed (GLuint index, GLclampd n, GLclampd f);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDepthRangeIndexed(GLuint index, GLclampd n, GLclampd f);
        private static TglDepthRangeIndexed glDepthRangeIndexed = null;

        // GLAPI void APIENTRY glGetFloati_v (GLenum target, GLuint index, GLfloat *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFloati_v(GLenum target, GLuint index, GLfloat* data);
        private static TglGetFloati_v glGetFloati_v = null;

        // GLAPI void APIENTRY glGetDoublei_v (GLenum target, GLuint index, GLdouble *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetDoublei_v(GLenum target, GLuint index, GLdouble* data);
        private static TglGetDoublei_v glGetDoublei_v = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v4.2 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v4.2 FUNCTIONS...
        /* OpenGL 4.2 reuses entry points from these extensions: */
        /* ARB_base_instance */
        // GLAPI void APIENTRY glDrawArraysInstancedBaseInstance (GLenum mode, GLint first, GLsizei count, GLsizei primcount, GLuint baseinstance);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawArraysInstancedBaseInstance(GLenum mode, GLint first, GLsizei count, GLsizei primcount, GLuint baseinstance);
        private static TglDrawArraysInstancedBaseInstance glDrawArraysInstancedBaseInstance = null;

        // GLAPI void APIENTRY glDrawElementsInstancedBaseInstance (GLenum mode, GLsizei count, GLenum type, const void *indices, GLsizei primcount, GLuint baseinstance);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawElementsInstancedBaseInstance(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount, GLuint baseinstance);
        private static TglDrawElementsInstancedBaseInstance glDrawElementsInstancedBaseInstance = null;

        // GLAPI void APIENTRY glDrawElementsInstancedBaseVertexBaseInstance (GLenum mode, GLsizei count, GLenum type, const void *indices, GLsizei primcount, GLint basevertex, GLuint baseinstance);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDrawElementsInstancedBaseVertexBaseInstance(GLenum mode, GLsizei count, GLenum type, void* indices, GLsizei primcount, GLint basevertex, GLuint baseinstance);
        private static TglDrawElementsInstancedBaseVertexBaseInstance glDrawElementsInstancedBaseVertexBaseInstance = null;

        /* ARB_shading_language_420pack (no entry points) */
        /* ARB_transform_feedback_instanced */
        // GLAPI void APIENTRY glDrawTransformFeedbackInstanced (GLenum mode, GLuint id, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawTransformFeedbackInstanced(GLenum mode, GLuint id, GLsizei primcount);
        private static TglDrawTransformFeedbackInstanced glDrawTransformFeedbackInstanced = null;

        // GLAPI void APIENTRY glDrawTransformFeedbackStreamInstanced (GLenum mode, GLuint id, GLuint stream, GLsizei primcount);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDrawTransformFeedbackStreamInstanced(GLenum mode, GLuint id, GLuint stream, GLsizei primcount);
        private static TglDrawTransformFeedbackStreamInstanced glDrawTransformFeedbackStreamInstanced = null;

        /* ARB_compressed_texture_pixel_storage (no entry points) */
        /* ARB_conservative_depth (no entry points) */
        /* ARB_internalformat_query */
        // GLAPI void APIENTRY glGetInternalformativ (GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetInternalformativ(GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint* parameters);
        private static TglGetInternalformativ glGetInternalformativ = null;

        /* ARB_map_buffer_alignment (no entry points) */
        /* ARB_shader_atomic_counters */
        // GLAPI void APIENTRY glGetActiveAtomicCounterBufferiv (GLuint program, GLuint bufferIndex, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetActiveAtomicCounterBufferiv(GLuint program, GLuint bufferIndex, GLenum pname, GLint* parameters);
        private static TglGetActiveAtomicCounterBufferiv glGetActiveAtomicCounterBufferiv = null;

        /* ARB_shader_image_load_store */
        // GLAPI void APIENTRY glBindImageTexture (GLuint unit, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLenum format);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindImageTexture(GLuint unit, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLenum format);
        private static TglBindImageTexture glBindImageTexture = null;

        // GLAPI void APIENTRY glMemoryBarrier (GLbitfield barriers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMemoryBarrier(GLbitfield barriers);
        private static TglMemoryBarrier glMemoryBarrier = null;

        /* ARB_shading_language_packing (no entry points) */
        /* ARB_texture_storage */
        // GLAPI void APIENTRY glTexStorage1D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexStorage1D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width);
        private static TglTexStorage1D glTexStorage1D = null;

        // GLAPI void APIENTRY glTexStorage2D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexStorage2D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglTexStorage2D glTexStorage2D = null;

        // GLAPI void APIENTRY glTexStorage3D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexStorage3D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
        private static TglTexStorage3D glTexStorage3D = null;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v4.3 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v4.3 FUNCTIONS...
        /* OpenGL 4.3 reuses entry points from these extensions: */
        /* ARB_arrays_of_arrays (no entry points, GLSL only) */
        /* ARB_fragment_layer_viewport (no entry points, GLSL only) */
        /* ARB_shader_image_size (no entry points, GLSL only) */
        /* ARB_ES3_compatibility (no entry points) */
        /* ARB_clear_buffer_object */
        // GLAPI void APIENTRY glClearBufferData (GLenum target, GLenum internalformat, GLenum format, GLenum type, const void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearBufferData(GLenum target, GLenum internalformat, GLenum format, GLenum type, void* data);
        private static TglClearBufferData glClearBufferData = null;

        // GLAPI void APIENTRY glClearBufferSubData (GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, const void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearBufferSubData(GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data);
        private static TglClearBufferSubData glClearBufferSubData = null;

        // GLAPI void APIENTRY glClearNamedBufferDataEXT (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, const void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearNamedBufferDataEXT(GLuint buffer, GLenum internalformat, GLenum format, GLenum type, void* data);
        private static TglClearNamedBufferDataEXT glClearNamedBufferDataEXT = null;

        // GLAPI void APIENTRY glClearNamedBufferSubDataEXT (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, GLsizeiptr offset, GLsizeiptr size, const void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearNamedBufferSubDataEXT(GLuint buffer, GLenum internalformat, GLenum format, GLenum type, GLsizeiptr offset, GLsizeiptr size, void* data);
        private static TglClearNamedBufferSubDataEXT glClearNamedBufferSubDataEXT = null;
        
        /* ARB_compute_shader */
        // GLAPI void APIENTRY glDispatchCompute (GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDispatchCompute(GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z);
        private static TglDispatchCompute glDispatchCompute = null;

        // GLAPI void APIENTRY glDispatchComputeIndirect (GLintptr indirect);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDispatchComputeIndirect(GLintptr indirect);
        private static TglDispatchComputeIndirect glDispatchComputeIndirect = null;

        /* ARB_copy_image */
        // GLAPI void APIENTRY glCopyImageSubData (GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyImageSubData(GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth);
        private static TglCopyImageSubData glCopyImageSubData = null; 

        /* KHR_debug (includes ARB_debug_output commands promoted to KHR without suffixes) */
        // typedef void (APIENTRY *GLDEBUGPROC)(GLenum source,GLenum type,GLuint id,GLenum severity,GLsizei length,const GLchar *message,GLvoid *userParam);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void TCALLBACKglDebugProc(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string message, void* userParam);

        // GLAPI void APIENTRY glDebugMessageControl (GLenum source, GLenum type, GLenum severity, GLsizei count, const GLuint *ids, GLboolean enabled);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDebugMessageControl(GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint* ids, GLboolean enabled);
        private static TglDebugMessageControl glDebugMessageControl = null;

        // GLAPI void APIENTRY glDebugMessageInsert (GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, const GLchar *buf);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDebugMessageInsert(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string buf);
        private static TglDebugMessageInsert glDebugMessageInsert = null;

        // GLAPI void APIENTRY glDebugMessageCallback (GLDEBUGPROC callback, const void *userParam);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglDebugMessageCallback(TCALLBACKglDebugProc callback, void* userParam);
        private static TglDebugMessageCallback glDebugMessageCallback = null;

        // GLAPI GLuint APIENTRY glGetDebugMessageLog (GLuint count, GLsizei bufsize, GLenum *sources, GLenum *types, GLuint *ids, GLenum *severities, GLsizei *lengths, GLchar *messageLog);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate GLuint TglGetDebugMessageLog(GLuint count, GLsizei bufsize, GLenum* sources, GLenum* types, GLuint* ids, GLenum* severities, GLsizei* lengths, GLchar* messageLog);
        private static TglGetDebugMessageLog glGetDebugMessageLog = null;

        // GLAPI void APIENTRY glPushDebugGroup (GLenum source, GLuint id, GLsizei length, const GLchar *message);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPushDebugGroup(GLenum source, GLuint id, GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string message);
        private static TglPushDebugGroup glPushDebugGroup = null;

        // GLAPI void APIENTRY glPopDebugGroup (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglPopDebugGroup();
        private static TglPopDebugGroup glPopDebugGroup = null;

        // GLAPI void APIENTRY glObjectLabel (GLenum identifier, GLuint name, GLsizei length, const GLchar *label);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglObjectLabel(GLenum identifier, GLuint name, GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string label);
        private static TglObjectLabel glObjectLabel = null;

        // GLAPI void APIENTRY glGetObjectLabel (GLenum identifier, GLuint name, GLsizei bufSize, GLsizei *length, GLchar *label);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetObjectLabel(GLenum identifier, GLuint name, GLsizei bufSize, GLsizei* length, GLchar* label);
        private static TglGetObjectLabel glGetObjectLabel = null;

        // GLAPI void APIENTRY glObjectPtrLabel (const void *ptr, GLsizei length, const GLchar *label);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglObjectPtrLabel(void* ptr, GLsizei length, [MarshalAs(UnmanagedType.LPStr)] string label);
        private static TglObjectPtrLabel glObjectPtrLabel = null;

        // GLAPI void APIENTRY glGetObjectPtrLabel (const void *ptr, GLsizei bufSize, GLsizei *length, GLchar *label);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetObjectPtrLabel(void* ptr, GLsizei bufSize, GLsizei* length, GLchar* label);
        private static TglGetObjectPtrLabel glGetObjectPtrLabel = null;

        /* ARB_explicit_uniform_location (no entry points) */
        /* ARB_framebuffer_no_attachments */
        // GLAPI void APIENTRY glFramebufferParameteri (GLenum target, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFramebufferParameteri(GLenum target, GLenum pname, GLint param);
        private static TglFramebufferParameteri glFramebufferParameteri = null;

        // GLAPI void APIENTRY glGetFramebufferParameteriv (GLenum target, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetFramebufferParameteriv(GLenum target, GLenum pname, GLint* parameters);
        private static TglGetFramebufferParameteriv glGetFramebufferParameteriv = null;

        // GLAPI void APIENTRY glNamedFramebufferParameteriEXT (GLuint framebuffer, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferParameteriEXT(GLuint framebuffer, GLenum pname, GLint param);
        private static TglNamedFramebufferParameteriEXT glNamedFramebufferParameteriEXT = null;

        // GLAPI void APIENTRY glGetNamedFramebufferParameterivEXT (GLuint framebuffer, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedFramebufferParameterivEXT(GLuint framebuffer, GLenum pname, GLint* parameters);
        private static TglGetNamedFramebufferParameterivEXT glGetNamedFramebufferParameterivEXT = null;
        
        /* ARB_internalformat_query2 */
        // GLAPI void APIENTRY glGetInternalformati64v (GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint64 *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetInternalformati64v(GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint64* parameters);
        private static TglGetInternalformati64v glGetInternalformati64v = null;

        /* ARB_invalidate_subdata */
        // GLAPI void APIENTRY glInvalidateTexSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglInvalidateTexSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth);
        private static TglInvalidateTexSubImage glInvalidateTexSubImage = null;

        // GLAPI void APIENTRY glInvalidateTexImage (GLuint texture, GLint level);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglInvalidateTexImage(GLuint texture, GLint level);
        private static TglInvalidateTexImage glInvalidateTexImage = null;

        // GLAPI void APIENTRY glInvalidateBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr length);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglInvalidateBufferSubData(GLuint buffer, GLintptr offset, GLsizeiptr length);
        private static TglInvalidateBufferSubData glInvalidateBufferSubData = null;

        // GLAPI void APIENTRY glInvalidateBufferData (GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglInvalidateBufferData(GLuint buffer);
        private static TglInvalidateBufferData glInvalidateBufferData = null;

        // GLAPI void APIENTRY glInvalidateFramebuffer (GLenum target, GLsizei numAttachments, const GLenum *attachments);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglInvalidateFramebuffer(GLenum target, GLsizei numAttachments, GLenum* attachments);
        private static TglInvalidateFramebuffer glInvalidateFramebuffer = null;

        // GLAPI void APIENTRY glInvalidateSubFramebuffer (GLenum target, GLsizei numAttachments, const GLenum *attachments, GLint x, GLint y, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglInvalidateSubFramebuffer(GLenum target, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglInvalidateSubFramebuffer glInvalidateSubFramebuffer = null;

        /* ARB_multi_draw_indirect */
        // GLAPI void APIENTRY glMultiDrawArraysIndirect (GLenum mode, const void *indirect, GLsizei drawcount, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawArraysIndirect(GLenum mode, void* indirect, GLsizei drawcount, GLsizei stride);
        private static TglMultiDrawArraysIndirect glMultiDrawArraysIndirect = null;

        // GLAPI void APIENTRY glMultiDrawElementsIndirect (GLenum mode, GLenum type, const void *indirect, GLsizei drawcount, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglMultiDrawElementsIndirect(GLenum mode, GLenum type, void* indirect, GLsizei drawcount, GLsizei stride);
        private static TglMultiDrawElementsIndirect glMultiDrawElementsIndirect = null;

        /* ARB_program_interface_query */
        // GLAPI void APIENTRY glGetProgramInterfaceiv (GLuint program, GLenum programInterface, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramInterfaceiv(GLuint program, GLenum programInterface, GLenum pname, GLint* parameters);
        private static TglGetProgramInterfaceiv glGetProgramInterfaceiv = null;

        // GLAPI GLuint APIENTRY glGetProgramResourceIndex (GLuint program, GLenum programInterface, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLuint TglGetProgramResourceIndex(GLuint program, GLenum programInterface, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglGetProgramResourceIndex glGetProgramResourceIndex = null;

        // GLAPI void APIENTRY glGetProgramResourceName (GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei *length, GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramResourceName(GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei* length, GLchar* name);
        private static TglGetProgramResourceName glGetProgramResourceName = null;

        // GLAPI void APIENTRY glGetProgramResourceiv (GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, const GLenum *props, GLsizei bufSize, GLsizei *length, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetProgramResourceiv(GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, GLenum* props, GLsizei bufSize, GLsizei* length, GLint* parameters);
        private static TglGetProgramResourceiv glGetProgramResourceiv = null;

        // GLAPI GLint APIENTRY glGetProgramResourceLocation (GLuint program, GLenum programInterface, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLint TglGetProgramResourceLocation(GLuint program, GLenum programInterface, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglGetProgramResourceLocation glGetProgramResourceLocation = null;

        // GLAPI GLint APIENTRY glGetProgramResourceLocationIndex (GLuint program, GLenum programInterface, const GLchar *name);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLint TglGetProgramResourceLocationIndex(GLuint program, GLenum programInterface, [MarshalAs(UnmanagedType.LPStr)] string name);
        private static TglGetProgramResourceLocationIndex glGetProgramResourceLocationIndex = null;

        /* ARB_robust_buffer_access_behavior (no entry points) */
        /* ARB_shader_storage_buffer_object */
        // GLAPI void APIENTRY glShaderStorageBlockBinding (GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglShaderStorageBlockBinding(GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding);
        private static TglShaderStorageBlockBinding glShaderStorageBlockBinding = null;

        /* ARB_stencil_texturing (no entry points) */
        /* ARB_texture_buffer_range */
        // GLAPI void APIENTRY glTexBufferRange (GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexBufferRange(GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);
        private static TglTexBufferRange glTexBufferRange = null;

        // GLAPI void APIENTRY glTextureBufferRangeEXT (GLuint texture, GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureBufferRangeEXT(GLuint texture, GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);
        private static TglTextureBufferRangeEXT glTextureBufferRangeEXT = null;

        /* ARB_texture_query_levels (no entry points) */
        /* ARB_texture_storage_multisample */
        // GLAPI void APIENTRY glTexStorage2DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexStorage2DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);
        private static TglTexStorage2DMultisample glTexStorage2DMultisample = null;

        // GLAPI void APIENTRY glTexStorage3DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTexStorage3DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);
        private static TglTexStorage3DMultisample glTexStorage3DMultisample = null;

        // GLAPI void APIENTRY glTextureStorage2DMultisampleEXT (GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureStorage2DMultisampleEXT(GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);
        private static TglTextureStorage2DMultisampleEXT glTextureStorage2DMultisampleEXT = null;

        // GLAPI void APIENTRY glTextureStorage3DMultisampleEXT (GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureStorage3DMultisampleEXT(GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);
        private static TglTextureStorage3DMultisampleEXT glTextureStorage3DMultisampleEXT = null;
        
        /* ARB_texture_view */
        // GLAPI void APIENTRY glTextureView (GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureView(GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers);
        private static TglTextureView glTextureView = null;
        
        /* ARB_vertex_attrib_binding */
        // GLAPI void APIENTRY glBindVertexBuffer (GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindVertexBuffer(GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);
        private static TglBindVertexBuffer glBindVertexBuffer = null;

        // GLAPI void APIENTRY glVertexAttribFormat (GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribFormat(GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);
        private static TglVertexAttribFormat glVertexAttribFormat = null;

        // GLAPI void APIENTRY glVertexAttribIFormat (GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribIFormat(GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        private static TglVertexAttribIFormat glVertexAttribIFormat = null;

        // GLAPI void APIENTRY glVertexAttribLFormat (GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribLFormat(GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        private static TglVertexAttribLFormat glVertexAttribLFormat = null;

        // GLAPI void APIENTRY glVertexAttribBinding (GLuint attribindex, GLuint bindingindex);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexAttribBinding(GLuint attribindex, GLuint bindingindex);
        private static TglVertexAttribBinding glVertexAttribBinding = null;

        // GLAPI void APIENTRY glVertexBindingDivisor (GLuint bindingindex, GLuint divisor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexBindingDivisor(GLuint bindingindex, GLuint divisor);
        private static TglVertexBindingDivisor glVertexBindingDivisor = null;

        // GLAPI void APIENTRY glVertexArrayBindVertexBufferEXT (GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayBindVertexBufferEXT(GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);
        private static TglVertexArrayBindVertexBufferEXT glVertexArrayBindVertexBufferEXT = null;

        // GLAPI void APIENTRY glVertexArrayVertexAttribFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayVertexAttribFormatEXT(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);
        private static TglVertexArrayVertexAttribFormatEXT glVertexArrayVertexAttribFormatEXT = null;

        // GLAPI void APIENTRY glVertexArrayVertexAttribIFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayVertexAttribIFormatEXT(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        private static TglVertexArrayVertexAttribIFormatEXT glVertexArrayVertexAttribIFormatEXT = null;

        // GLAPI void APIENTRY glVertexArrayVertexAttribLFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayVertexAttribLFormatEXT(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        private static TglVertexArrayVertexAttribLFormatEXT glVertexArrayVertexAttribLFormatEXT = null;

        // GLAPI void APIENTRY glVertexArrayVertexAttribBindingEXT (GLuint vaobj, GLuint attribindex, GLuint bindingindex);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayVertexAttribBindingEXT(GLuint vaobj, GLuint attribindex, GLuint bindingindex);
        private static TglVertexArrayVertexAttribBindingEXT glVertexArrayVertexAttribBindingEXT = null;

        // GLAPI void APIENTRY glVertexArrayVertexBindingDivisorEXT (GLuint vaobj, GLuint bindingindex, GLuint divisor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayVertexBindingDivisorEXT(GLuint vaobj, GLuint bindingindex, GLuint divisor);
        private static TglVertexArrayVertexBindingDivisorEXT glVertexArrayVertexBindingDivisorEXT = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v4.4 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v4.4 FUNCTIONS...
        // GLAPI void APIENTRY glBufferStorage (GLenum target, GLsizeiptr size, const void *data, GLbitfield flags);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBufferStorage(GLenum target, GLsizeiptr size, void* data, GLbitfield flags);
        private static TglBufferStorage glBufferStorage = null;

        // GLAPI void APIENTRY glClearTexImage (GLuint texture, GLint level, GLenum format, GLenum type, const void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearTexImage(GLuint texture, GLint level, GLenum format, GLenum type, void* data);
        private static TglClearTexImage glClearTexImage = null;

        // GLAPI void APIENTRY glClearTexSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearTexSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* data);
        private static TglClearTexSubImage glClearTexSubImage = null;

        // GLAPI void APIENTRY glBindBuffersBase (GLenum target, GLuint first, GLsizei count, const GLuint *buffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBindBuffersBase(GLenum target, GLuint first, GLsizei count, GLuint* buffers);
        private static TglBindBuffersBase glBindBuffersBase = null;

        // GLAPI void APIENTRY glBindBuffersRange (GLenum target, GLuint first, GLsizei count, const GLuint *buffers, const GLintptr *offsets, const GLsizeiptr *sizes);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBindBuffersRange(GLenum target, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizeiptr* sizes);
        private static TglBindBuffersRange glBindBuffersRange = null;

        // GLAPI void APIENTRY glBindTextures (GLuint first, GLsizei count, const GLuint *textures);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBindTextures(GLuint first, GLsizei count, GLuint* textures);
        private static TglBindTextures glBindTextures = null;

        // GLAPI void APIENTRY glBindSamplers (GLuint first, GLsizei count, const GLuint *samplers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBindSamplers(GLuint first, GLsizei count, GLuint* samplers);
        private static TglBindSamplers glBindSamplers = null;

        // GLAPI void APIENTRY glBindImageTextures (GLuint first, GLsizei count, const GLuint *textures);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBindImageTextures(GLuint first, GLsizei count, GLuint* textures);
        private static TglBindImageTextures glBindImageTextures = null;

        // GLAPI void APIENTRY glBindVertexBuffers (GLuint first, GLsizei count, const GLuint *buffers, const GLintptr *offsets, const GLsizei *strides);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglBindVertexBuffers(GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizei* strides);
        private static TglBindVertexBuffers glBindVertexBuffers = null;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE v4.5 FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL CORE v4.5 FUNCTIONS...
        // GLAPI void APIENTRY glClipControl (GLenum origin, GLenum depth);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClipControl(GLenum origin, GLenum depth);
        private static TglClipControl glClipControl = null;

        // GLAPI void APIENTRY glCreateTransformFeedbacks (GLsizei n, GLuint *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCreateTransformFeedbacks(GLsizei n, GLuint* ids);
        private static TglCreateTransformFeedbacks glCreateTransformFeedbacks = null;

        // GLAPI void APIENTRY glTransformFeedbackBufferBase (GLuint xfb, GLuint index, GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTransformFeedbackBufferBase(GLuint xfb, GLuint index, GLuint buffer);
        private static TglTransformFeedbackBufferBase glTransformFeedbackBufferBase = null;

        // GLAPI void APIENTRY glTransformFeedbackBufferRange (GLuint xfb, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTransformFeedbackBufferRange(GLuint xfb, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
        private static TglTransformFeedbackBufferRange glTransformFeedbackBufferRange = null;

        // GLAPI void APIENTRY glGetTransformFeedbackiv (GLuint xfb, GLenum pname, GLint *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTransformFeedbackiv(GLuint xfb, GLenum pname, GLint* param);
        private static TglGetTransformFeedbackiv glGetTransformFeedbackiv = null;

        // GLAPI void APIENTRY glGetTransformFeedbacki_v (GLuint xfb, GLenum pname, GLuint index, GLint *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTransformFeedbacki_v(GLuint xfb, GLenum pname, GLuint index, GLint* param);
        private static TglGetTransformFeedbacki_v glGetTransformFeedbacki_v = null;

        // GLAPI void APIENTRY glGetTransformFeedbacki64_v (GLuint xfb, GLenum pname, GLuint index, GLint64 *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTransformFeedbacki64_v(GLuint xfb, GLenum pname, GLuint index, GLint64* param);
        private static TglGetTransformFeedbacki64_v glGetTransformFeedbacki64_v = null;

        // GLAPI void APIENTRY glCreateBuffers (GLsizei n, GLuint *buffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCreateBuffers(GLsizei n, GLuint* buffers);
        private static TglCreateBuffers glCreateBuffers = null;

        // GLAPI void APIENTRY glNamedBufferStorage (GLuint buffer, GLsizeiptr size, const void *data, GLbitfield flags);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedBufferStorage(GLuint buffer, GLsizeiptr size, void* data, GLbitfield flags);
        private static TglNamedBufferStorage glNamedBufferStorage = null;

        // GLAPI void APIENTRY glNamedBufferData (GLuint buffer, GLsizeiptr size, const void *data, GLenum usage);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedBufferData(GLuint buffer, GLsizeiptr size, void* data, GLenum usage);
        private static TglNamedBufferData glNamedBufferData = null;

        // GLAPI void APIENTRY glNamedBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr size, const void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedBufferSubData(GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);
        private static TglNamedBufferSubData glNamedBufferSubData = null;

        // GLAPI void APIENTRY glCopyNamedBufferSubData (GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyNamedBufferSubData(GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);
        private static TglCopyNamedBufferSubData glCopyNamedBufferSubData = null;

        // GLAPI void APIENTRY glClearNamedBufferData (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, const void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearNamedBufferData(GLuint buffer, GLenum internalformat, GLenum format, GLenum type, void* data);
        private static TglClearNamedBufferData glClearNamedBufferData = null;

        // GLAPI void APIENTRY glClearNamedBufferSubData (GLuint buffer, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, const void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearNamedBufferSubData(GLuint buffer, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, void* data);
        private static TglClearNamedBufferSubData glClearNamedBufferSubData = null;

        // GLAPI void *APIENTRY glMapNamedBuffer (GLuint buffer, GLenum access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void* TglMapNamedBuffer(GLuint buffer, GLenum access);
        private static TglMapNamedBuffer glMapNamedBuffer = null;
        
        // GLAPI void *APIENTRY glMapNamedBufferRange (GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void* TglMapNamedBufferRange(GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access);
        private static TglMapNamedBufferRange glMapNamedBufferRange = null;

        // GLAPI GLboolean APIENTRY glUnmapNamedBuffer (GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLboolean TglUnmapNamedBuffer(GLuint buffer);
        private static TglUnmapNamedBuffer glUnmapNamedBuffer = null;

        // GLAPI void APIENTRY glFlushMappedNamedBufferRange (GLuint buffer, GLintptr offset, GLsizeiptr length);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglFlushMappedNamedBufferRange(GLuint buffer, GLintptr offset, GLsizeiptr length);
        private static TglFlushMappedNamedBufferRange glFlushMappedNamedBufferRange = null;

        // GLAPI void APIENTRY glGetNamedBufferParameteriv (GLuint buffer, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedBufferParameteriv(GLuint buffer, GLenum pname, GLint* parameters);
        private static TglGetNamedBufferParameteriv glGetNamedBufferParameteriv = null;

        // GLAPI void APIENTRY glGetNamedBufferParameteri64v (GLuint buffer, GLenum pname, GLint64 *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedBufferParameteri64v(GLuint buffer, GLenum pname, GLint64* parameters);
        private static TglGetNamedBufferParameteri64v glGetNamedBufferParameteri64v = null;

        // GLAPI void APIENTRY glGetNamedBufferPointerv (GLuint buffer, GLenum pname, void **params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedBufferPointerv(GLuint buffer, GLenum pname, void** parameters);
        private static TglGetNamedBufferPointerv glGetNamedBufferPointerv = null;

        // GLAPI void APIENTRY glGetNamedBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr size, void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedBufferSubData(GLuint buffer, GLintptr offset, GLsizeiptr size, void* data);
        private static TglGetNamedBufferSubData glGetNamedBufferSubData = null;

        // GLAPI void APIENTRY glCreateFramebuffers (GLsizei n, GLuint *framebuffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCreateFramebuffers(GLsizei n, GLuint* framebuffers);
        private static TglCreateFramebuffers glCreateFramebuffers = null;

        // GLAPI void APIENTRY glNamedFramebufferRenderbuffer (GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferRenderbuffer(GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
        private static TglNamedFramebufferRenderbuffer glNamedFramebufferRenderbuffer = null;

        // GLAPI void APIENTRY glNamedFramebufferParameteri (GLuint framebuffer, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferParameteri(GLuint framebuffer, GLenum pname, GLint param);
        private static TglNamedFramebufferParameteri glNamedFramebufferParameteri = null;

        // GLAPI void APIENTRY glNamedFramebufferTexture (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferTexture(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level);
        private static TglNamedFramebufferTexture glNamedFramebufferTexture = null;

        // GLAPI void APIENTRY glNamedFramebufferTextureLayer (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferTextureLayer(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer);
        private static TglNamedFramebufferTextureLayer glNamedFramebufferTextureLayer = null;

        // GLAPI void APIENTRY glNamedFramebufferDrawBuffer (GLuint framebuffer, GLenum buf);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferDrawBuffer(GLuint framebuffer, GLenum buf);
        private static TglNamedFramebufferDrawBuffer glNamedFramebufferDrawBuffer = null;

        // GLAPI void APIENTRY glNamedFramebufferDrawBuffers (GLuint framebuffer, GLsizei n, const GLenum *bufs);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglNamedFramebufferDrawBuffers(GLuint framebuffer, GLsizei n, GLenum* bufs);
        private static TglNamedFramebufferDrawBuffers glNamedFramebufferDrawBuffers = null;

        // GLAPI void APIENTRY glNamedFramebufferReadBuffer (GLuint framebuffer, GLenum src);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedFramebufferReadBuffer(GLuint framebuffer, GLenum src);
        private static TglNamedFramebufferReadBuffer glNamedFramebufferReadBuffer = null;

        // GLAPI void APIENTRY glInvalidateNamedFramebufferData (GLuint framebuffer, GLsizei numAttachments, const GLenum *attachments);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglInvalidateNamedFramebufferData(GLuint framebuffer, GLsizei numAttachments, GLenum* attachments);
        private static TglInvalidateNamedFramebufferData glInvalidateNamedFramebufferData = null;

        // GLAPI void APIENTRY glInvalidateNamedFramebufferSubData (GLuint framebuffer, GLsizei numAttachments, const GLenum *attachments, GLint x, GLint y, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglInvalidateNamedFramebufferSubData(GLuint framebuffer, GLsizei numAttachments, GLenum* attachments, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglInvalidateNamedFramebufferSubData glInvalidateNamedFramebufferSubData = null;

        // GLAPI void APIENTRY glClearNamedFramebufferiv (GLuint framebuffer, GLenum buffer, GLint drawbuffer, const GLint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearNamedFramebufferiv(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLint* value);
        private static TglClearNamedFramebufferiv glClearNamedFramebufferiv = null;

        // GLAPI void APIENTRY glClearNamedFramebufferuiv (GLuint framebuffer, GLenum buffer, GLint drawbuffer, const GLuint *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearNamedFramebufferuiv(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLuint* value);
        private static TglClearNamedFramebufferuiv glClearNamedFramebufferuiv = null;

        // GLAPI void APIENTRY glClearNamedFramebufferfv (GLuint framebuffer, GLenum buffer, GLint drawbuffer, const GLfloat *value);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglClearNamedFramebufferfv(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat* value);
        private static TglClearNamedFramebufferfv glClearNamedFramebufferfv = null;

        // GLAPI void APIENTRY glClearNamedFramebufferfi (GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglClearNamedFramebufferfi(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil);
        private static TglClearNamedFramebufferfi glClearNamedFramebufferfi = null;

        // GLAPI void APIENTRY glBlitNamedFramebuffer (GLuint readFramebuffer, GLuint drawFramebuffer, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBlitNamedFramebuffer(GLuint readFramebuffer, GLuint drawFramebuffer, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);
        private static TglBlitNamedFramebuffer glBlitNamedFramebuffer = null;

        // GLAPI GLenum APIENTRY glCheckNamedFramebufferStatus (GLuint framebuffer, GLenum target);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLenum TglCheckNamedFramebufferStatus(GLuint framebuffer, GLenum target);
        private static TglCheckNamedFramebufferStatus glCheckNamedFramebufferStatus = null;

        // GLAPI void APIENTRY glGetNamedFramebufferParameteriv (GLuint framebuffer, GLenum pname, GLint *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedFramebufferParameteriv(GLuint framebuffer, GLenum pname, GLint* param);
        private static TglGetNamedFramebufferParameteriv glGetNamedFramebufferParameteriv = null;

        // GLAPI void APIENTRY glGetNamedFramebufferAttachmentParameteriv (GLuint framebuffer, GLenum attachment, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedFramebufferAttachmentParameteriv(GLuint framebuffer, GLenum attachment, GLenum pname, GLint* parameters);
        private static TglGetNamedFramebufferAttachmentParameteriv glGetNamedFramebufferAttachmentParameteriv = null;

        // GLAPI void APIENTRY glCreateRenderbuffers (GLsizei n, GLuint *renderbuffers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCreateRenderbuffers(GLsizei n, GLuint* renderbuffers);
        private static TglCreateRenderbuffers glCreateRenderbuffers = null;

        // GLAPI void APIENTRY glNamedRenderbufferStorage (GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedRenderbufferStorage(GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglNamedRenderbufferStorage glNamedRenderbufferStorage = null;

        // GLAPI void APIENTRY glNamedRenderbufferStorageMultisample (GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglNamedRenderbufferStorageMultisample(GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglNamedRenderbufferStorageMultisample glNamedRenderbufferStorageMultisample = null;

        // GLAPI void APIENTRY glGetNamedRenderbufferParameteriv (GLuint renderbuffer, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetNamedRenderbufferParameteriv(GLuint renderbuffer, GLenum pname, GLint* parameters);
        private static TglGetNamedRenderbufferParameteriv glGetNamedRenderbufferParameteriv = null;

        // GLAPI void APIENTRY glCreateTextures (GLenum target, GLsizei n, GLuint *textures);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCreateTextures(GLenum target, GLsizei n, GLuint* textures);
        private static TglCreateTextures glCreateTextures = null;

        // GLAPI void APIENTRY glTextureBuffer (GLuint texture, GLenum internalformat, GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureBuffer(GLuint texture, GLenum internalformat, GLuint buffer);
        private static TglTextureBuffer glTextureBuffer = null;

        // GLAPI void APIENTRY glTextureBufferRange (GLuint texture, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureBufferRange(GLuint texture, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);
        private static TglTextureBufferRange glTextureBufferRange = null;

        // GLAPI void APIENTRY glTextureStorage1D (GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureStorage1D(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width);
        private static TglTextureStorage1D glTextureStorage1D = null;

        // GLAPI void APIENTRY glTextureStorage2D (GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureStorage2D(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        private static TglTextureStorage2D glTextureStorage2D = null;

        // GLAPI void APIENTRY glTextureStorage3D (GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureStorage3D(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
        private static TglTextureStorage3D glTextureStorage3D = null;

        // GLAPI void APIENTRY glTextureStorage2DMultisample (GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureStorage2DMultisample(GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);
        private static TglTextureStorage2DMultisample glTextureStorage2DMultisample = null;

        // GLAPI void APIENTRY glTextureStorage3DMultisample (GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureStorage3DMultisample(GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);
        private static TglTextureStorage3DMultisample glTextureStorage3DMultisample = null;

        // GLAPI void APIENTRY glTextureSubImage1D (GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, const void *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureSubImage1D(GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, void* pixels);
        private static TglTextureSubImage1D glTextureSubImage1D = null;

        // GLAPI void APIENTRY glTextureSubImage2D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const void *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureSubImage2D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, void* pixels);
        private static TglTextureSubImage2D glTextureSubImage2D = null;

        // GLAPI void APIENTRY glTextureSubImage3D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const void *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureSubImage3D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, void* pixels);
        private static TglTextureSubImage3D glTextureSubImage3D = null;

        // GLAPI void APIENTRY glCompressedTextureSubImage1D (GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, const void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTextureSubImage1D(GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, void* data);
        private static TglCompressedTextureSubImage1D glCompressedTextureSubImage1D = null;

        // GLAPI void APIENTRY glCompressedTextureSubImage2D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTextureSubImage2D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, void* data);
        private static TglCompressedTextureSubImage2D glCompressedTextureSubImage2D = null;

        // GLAPI void APIENTRY glCompressedTextureSubImage3D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCompressedTextureSubImage3D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, void* data);
        private static TglCompressedTextureSubImage3D glCompressedTextureSubImage3D = null;

        // GLAPI void APIENTRY glCopyTextureSubImage1D (GLuint texture, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTextureSubImage1D(GLuint texture, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        private static TglCopyTextureSubImage1D glCopyTextureSubImage1D = null;

        // GLAPI void APIENTRY glCopyTextureSubImage2D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTextureSubImage2D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglCopyTextureSubImage2D glCopyTextureSubImage2D = null;

        // GLAPI void APIENTRY glCopyTextureSubImage3D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglCopyTextureSubImage3D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        private static TglCopyTextureSubImage3D glCopyTextureSubImage3D = null;

        // GLAPI void APIENTRY glTextureParameterf (GLuint texture, GLenum pname, GLfloat param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureParameterf(GLuint texture, GLenum pname, GLfloat param);
        private static TglTextureParameterf glTextureParameterf = null;

        // GLAPI void APIENTRY glTextureParameterfv (GLuint texture, GLenum pname, const GLfloat *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureParameterfv(GLuint texture, GLenum pname, GLfloat* param);
        private static TglTextureParameterfv glTextureParameterfv = null;

        // GLAPI void APIENTRY glTextureParameteri (GLuint texture, GLenum pname, GLint param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureParameteri(GLuint texture, GLenum pname, GLint param);
        private static TglTextureParameteri glTextureParameteri = null;

        // GLAPI void APIENTRY glTextureParameterIiv (GLuint texture, GLenum pname, const GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureParameterIiv(GLuint texture, GLenum pname, GLint* parameters);
        private static TglTextureParameterIiv glTextureParameterIiv = null;

        // GLAPI void APIENTRY glTextureParameterIuiv (GLuint texture, GLenum pname, const GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureParameterIuiv(GLuint texture, GLenum pname, GLuint* parameters);
        private static TglTextureParameterIuiv glTextureParameterIuiv = null;

        // GLAPI void APIENTRY glTextureParameteriv (GLuint texture, GLenum pname, const GLint *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglTextureParameteriv(GLuint texture, GLenum pname, GLint* param);
        private static TglTextureParameteriv glTextureParameteriv = null;

        // GLAPI void APIENTRY glGenerateTextureMipmap (GLuint texture);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGenerateTextureMipmap(GLuint texture);
        private static TglGenerateTextureMipmap glGenerateTextureMipmap = null;

        // GLAPI void APIENTRY glBindTextureUnit (GLuint unit, GLuint texture);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglBindTextureUnit(GLuint unit, GLuint texture);
        private static TglBindTextureUnit glBindTextureUnit = null;

        // GLAPI void APIENTRY glGetTextureImage (GLuint texture, GLint level, GLenum format, GLenum type, GLsizei bufSize, void *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureImage(GLuint texture, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* pixels);
        private static TglGetTextureImage glGetTextureImage = null;

        // GLAPI void APIENTRY glGetCompressedTextureImage (GLuint texture, GLint level, GLsizei bufSize, void *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetCompressedTextureImage(GLuint texture, GLint level, GLsizei bufSize, void* pixels);
        private static TglGetCompressedTextureImage glGetCompressedTextureImage = null;

        // GLAPI void APIENTRY glGetTextureLevelParameterfv (GLuint texture, GLint level, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureLevelParameterfv(GLuint texture, GLint level, GLenum pname, GLfloat* parameters);
        private static TglGetTextureLevelParameterfv glGetTextureLevelParameterfv = null;

        // GLAPI void APIENTRY glGetTextureLevelParameteriv (GLuint texture, GLint level, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureLevelParameteriv(GLuint texture, GLint level, GLenum pname, GLint* parameters);
        private static TglGetTextureLevelParameteriv glGetTextureLevelParameteriv = null;

        // GLAPI void APIENTRY glGetTextureParameterfv (GLuint texture, GLenum pname, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureParameterfv (GLuint texture, GLenum pname, GLfloat* parameters);
        private static TglGetTextureParameterfv glGetTextureParameterfv = null;

        // GLAPI void APIENTRY glGetTextureParameterIiv (GLuint texture, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureParameterIiv (GLuint texture, GLenum pname, GLint* parameters);
        private static TglGetTextureParameterIiv glGetTextureParameterIiv = null;

        // GLAPI void APIENTRY glGetTextureParameterIuiv (GLuint texture, GLenum pname, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureParameterIuiv (GLuint texture, GLenum pname, GLuint* parameters);
        private static TglGetTextureParameterIuiv glGetTextureParameterIuiv = null;

        // GLAPI void APIENTRY glGetTextureParameteriv (GLuint texture, GLenum pname, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureParameteriv (GLuint texture, GLenum pname, GLint* parameters);
        private static TglGetTextureParameteriv glGetTextureParameteriv = null;

        // GLAPI void APIENTRY glCreateVertexArrays (GLsizei n, GLuint *arrays);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCreateVertexArrays(GLsizei n, GLuint* arrays);
        private static TglCreateVertexArrays glCreateVertexArrays = null;

        // GLAPI void APIENTRY glDisableVertexArrayAttrib (GLuint vaobj, GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglDisableVertexArrayAttrib (GLuint vaobj, GLuint index);
        private static TglDisableVertexArrayAttrib glDisableVertexArrayAttrib = null;

        // GLAPI void APIENTRY glEnableVertexArrayAttrib (GLuint vaobj, GLuint index);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglEnableVertexArrayAttrib (GLuint vaobj, GLuint index);
        private static TglEnableVertexArrayAttrib glEnableVertexArrayAttrib = null;

        // GLAPI void APIENTRY glVertexArrayElementBuffer (GLuint vaobj, GLuint buffer);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayElementBuffer (GLuint vaobj, GLuint buffer);
        private static TglVertexArrayElementBuffer glVertexArrayElementBuffer = null;

        // GLAPI void APIENTRY glVertexArrayVertexBuffer (GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayVertexBuffer (GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);
        private static TglVertexArrayVertexBuffer glVertexArrayVertexBuffer = null;

        // GLAPI void APIENTRY glVertexArrayVertexBuffers (GLuint vaobj, GLuint first, GLsizei count, const GLuint *buffers, const GLintptr *offsets, const GLsizei *strides);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglVertexArrayVertexBuffers (GLuint vaobj, GLuint first, GLsizei count, GLuint* buffers, GLintptr* offsets, GLsizei* strides);
        private static TglVertexArrayVertexBuffers glVertexArrayVertexBuffers = null;

        // GLAPI void APIENTRY glVertexArrayAttribBinding (GLuint vaobj, GLuint attribindex, GLuint bindingindex);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayAttribBinding (GLuint vaobj, GLuint attribindex, GLuint bindingindex);
        private static TglVertexArrayAttribBinding glVertexArrayAttribBinding = null;

        // GLAPI void APIENTRY glVertexArrayAttribFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayAttribFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);
        private static TglVertexArrayAttribFormat glVertexArrayAttribFormat = null;

        // GLAPI void APIENTRY glVertexArrayAttribIFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayAttribIFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        private static TglVertexArrayAttribIFormat glVertexArrayAttribIFormat = null;

        // GLAPI void APIENTRY glVertexArrayAttribLFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayAttribLFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        private static TglVertexArrayAttribLFormat glVertexArrayAttribLFormat = null;

        // GLAPI void APIENTRY glVertexArrayBindingDivisor (GLuint vaobj, GLuint bindingindex, GLuint divisor);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglVertexArrayBindingDivisor (GLuint vaobj, GLuint bindingindex, GLuint divisor);
        private static TglVertexArrayBindingDivisor glVertexArrayBindingDivisor = null;

        // GLAPI void APIENTRY glGetVertexArrayiv (GLuint vaobj, GLenum pname, GLint *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexArrayiv(GLuint vaobj, GLenum pname, GLint* param);
        private static TglGetVertexArrayiv glGetVertexArrayiv = null;

        // GLAPI void APIENTRY glGetVertexArrayIndexediv (GLuint vaobj, GLuint index, GLenum pname, GLint *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexArrayIndexediv(GLuint vaobj, GLuint index, GLenum pname, GLint* param);
        private static TglGetVertexArrayIndexediv glGetVertexArrayIndexediv = null;

        // GLAPI void APIENTRY glGetVertexArrayIndexed64iv (GLuint vaobj, GLuint index, GLenum pname, GLint64 *param);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetVertexArrayIndexed64iv(GLuint vaobj, GLuint index, GLenum pname, GLint64* param);
        private static TglGetVertexArrayIndexed64iv glGetVertexArrayIndexed64iv = null;

        // GLAPI void APIENTRY glCreateSamplers (GLsizei n, GLuint *samplers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCreateSamplers(GLsizei n, GLuint* samplers);
        private static TglCreateSamplers glCreateSamplers = null;

        // GLAPI void APIENTRY glCreateProgramPipelines (GLsizei n, GLuint *pipelines);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCreateProgramPipelines(GLsizei n, GLuint* pipelines);
        private static TglCreateProgramPipelines glCreateProgramPipelines = null;

        // GLAPI void APIENTRY glCreateQueries (GLenum target, GLsizei n, GLuint *ids);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglCreateQueries(GLenum target, GLsizei n, GLuint* ids);
        private static TglCreateQueries glCreateQueries = null;

        // GLAPI void APIENTRY glGetQueryBufferObjecti64v (GLuint id, GLuint buffer, GLenum pname, GLintptr offset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGetQueryBufferObjecti64v (GLuint id, GLuint buffer, GLenum pname, GLintptr offset);
        private static TglGetQueryBufferObjecti64v glGetQueryBufferObjecti64v = null;

        // GLAPI void APIENTRY glGetQueryBufferObjectiv (GLuint id, GLuint buffer, GLenum pname, GLintptr offset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGetQueryBufferObjectiv (GLuint id, GLuint buffer, GLenum pname, GLintptr offset);
        private static TglGetQueryBufferObjectiv glGetQueryBufferObjectiv = null;

        // GLAPI void APIENTRY glGetQueryBufferObjectui64v (GLuint id, GLuint buffer, GLenum pname, GLintptr offset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGetQueryBufferObjectui64v (GLuint id, GLuint buffer, GLenum pname, GLintptr offset);
        private static TglGetQueryBufferObjectui64v glGetQueryBufferObjectui64v = null;

        // GLAPI void APIENTRY glGetQueryBufferObjectuiv (GLuint id, GLuint buffer, GLenum pname, GLintptr offset);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglGetQueryBufferObjectuiv (GLuint id, GLuint buffer, GLenum pname, GLintptr offset);
        private static TglGetQueryBufferObjectuiv glGetQueryBufferObjectuiv = null;

        // GLAPI void APIENTRY glMemoryBarrierByRegion (GLbitfield barriers);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglMemoryBarrierByRegion (GLbitfield barriers);
        private static TglMemoryBarrierByRegion glMemoryBarrierByRegion = null;

        // GLAPI void APIENTRY glGetTextureSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, GLsizei bufSize, void *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetTextureSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, GLsizei bufSize, void* pixels);
        private static TglGetTextureSubImage glGetTextureSubImage = null;

        // GLAPI void APIENTRY glGetCompressedTextureSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei bufSize, void *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetCompressedTextureSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei bufSize, void* pixels);
        private static TglGetCompressedTextureSubImage glGetCompressedTextureSubImage = null;

        // GLAPI GLenum APIENTRY glGetGraphicsResetStatus (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate GLenum TglGetGraphicsResetStatus ();
        private static TglGetGraphicsResetStatus glGetGraphicsResetStatus = null;

        // GLAPI void APIENTRY glGetnCompressedTexImage (GLenum target, GLint lod, GLsizei bufSize, void *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnCompressedTexImage(GLenum target, GLint lod, GLsizei bufSize, void* pixels);
        private static TglGetnCompressedTexImage glGetnCompressedTexImage = null;

        // GLAPI void APIENTRY glGetnTexImage (GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, void *pixels);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnTexImage(GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, void* pixels);
        private static TglGetnTexImage glGetnTexImage = null;

        // GLAPI void APIENTRY glGetnUniformdv (GLuint program, GLint location, GLsizei bufSize, GLdouble *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnUniformdv(GLuint program, GLint location, GLsizei bufSize, GLdouble* parameters);
        private static TglGetnUniformdv glGetnUniformdv = null;

        // GLAPI void APIENTRY glGetnUniformfv (GLuint program, GLint location, GLsizei bufSize, GLfloat *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnUniformfv(GLuint program, GLint location, GLsizei bufSize, GLfloat* parameters);
        private static TglGetnUniformfv glGetnUniformfv = null;

        // GLAPI void APIENTRY glGetnUniformiv (GLuint program, GLint location, GLsizei bufSize, GLint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnUniformiv(GLuint program, GLint location, GLsizei bufSize, GLint* parameters);
        private static TglGetnUniformiv glGetnUniformiv = null;

        // GLAPI void APIENTRY glGetnUniformuiv (GLuint program, GLint location, GLsizei bufSize, GLuint *params);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetnUniformuiv(GLuint program, GLint location, GLsizei bufSize, GLuint* parameters);
        private static TglGetnUniformuiv glGetnUniformuiv = null;

        // GLAPI void APIENTRY glReadnPixels (GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void *data);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglReadnPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void* data);
        private static TglReadnPixels glReadnPixels = null;

        // GLAPI void APIENTRY glTextureBarrier (void);
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate void TglTextureBarrier ();
        private static TglTextureBarrier glTextureBarrier = null;
        #endregion
    }
}
