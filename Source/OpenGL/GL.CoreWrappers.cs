// ----------------------------------------------------------------------------
// FILE		: gl.corewrappers.cs
// VERSION	: 1.1.1
// COMMENT	: OpenGL Core Profile wrappers for low level delegates and functions
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
        // OPENGL v1.1 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v1.1 WRAPPERS...
        // GLproc (void, glAccum, (GLenum op, GLfloat value))
        public static void Accum(GLenum op, GLfloat value)
        {
            if (glAccum != null)
            {
                glAccum(op, value);
            }
        }

        // GLproc (void, glAlphaFunc, (GLenum func, GLclampf ref))
        public static void AlphaFunc(GLenum func, GLclampf reference)
        {
            if (glAlphaFunc != null)
            {
                glAlphaFunc(func, reference);
            }
        }

        // GLproc (GLboolean, glAreTexturesResident, (GLsizei n, const GLuint *textures, GLboolean *residences))
        public unsafe static GLboolean AreTexturesResident(GLsizei n, GLuint[] textures, GLboolean[] residences)
        {
            if (glAreTexturesResident != null)
            {
                fixed (GLuint* ptr_textures = textures)
                {
                    fixed (GLboolean* ptr_residences = residences)
                    {
                        return glAreTexturesResident(n, ptr_textures, ptr_residences);
                    }
                }
            }
            else
            {
                return false;
            }
        }

        // GLproc (void, glArrayElement, (GLint i))
        public static void ArrayElement(GLint i)
        {
            if (glArrayElement != null)
            {
                glArrayElement(i);
            }
        }

        // GLproc (void, glBegin, (GLenum mode))
        public static void Begin(GLenum mode)
        {
            if (glBegin != null)
            {
                glBegin(mode);
            }
        }

        // GLproc (void, glBindTexture, (GLenum target, GLuint texture))
        public static void BindTexture(GLenum target, GLuint texture)
        {
            if (glBindTexture != null)
            {
                glBindTexture(target, texture);
            }
        }

        // GLproc (void, glBitmap, (GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, const GLubyte *bitmap))
        public unsafe static void Bitmap(GLsizei width, GLsizei height, GLfloat xorig, GLfloat yorig, GLfloat xmove, GLfloat ymove, GLubyte[] bitmap)
        {
            if (glBitmap != null)
            {
                fixed (GLubyte* ptr_bitmap = bitmap)
                {
                    glBitmap(width, height, xorig, yorig, xmove, ymove, ptr_bitmap);
                }
            }
        }

        // GLproc (void, glBlendFunc, (GLenum sfactor, GLenum dfactor))
        public static void BlendFunc(GLenum sfactor, GLenum dfactor)
        {
            if (glBlendFunc != null)
            {
                glBlendFunc(sfactor, dfactor);
            }
        }

        // GLproc (void, glCallList, (GLuint list))
        public static void CallList(GLuint list)
        {
            if (glCallList != null)
            {
                glCallList(list);
            }
        }

        // GLproc (void, glCallLists, (GLsizei n, GLenum type, const GLvoid *lists))
        public unsafe static void CallLists(GLsizei n, GLenum type, IntPtr lists)
        {
            if (glCallLists != null)
            {
                glCallLists(n, type, lists.ToPointer());
            }
        }

        // GLproc (void, glClear, (GLbitfield mask))
        public static void Clear(GLbitfield mask)
        {
            if (glClear != null)
            {
                glClear(mask);
            }
        }

        // GLproc (void, glClearAccum, (GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha))
        public static void ClearAccum(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
        {
            if (glClearAccum != null)
            {
                glClearAccum(red, green, blue, alpha);
            }
        }

        // GLproc (void, glClearColor, (GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha))
        public static void ClearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha)
        {
            if (glClearColor != null)
            {
                glClearColor(red, green, blue, alpha);
            }
        }

        // GLproc (void, glClearDepth, (GLclampd depth))
        public static void ClearDepth(GLclampd depth)
        {
            if (glClearDepth != null)
            {
                glClearDepth(depth);
            }
        }

        // GLproc (void, glClearIndex, (GLfloat c))
        public static void ClearIndex(GLfloat c)
        {
            if (glClearIndex != null)
            {
                glClearIndex(c);
            }
        }

        // GLproc (void, glClearStencil, (GLint s))
        public static void ClearStencil(GLint s)
        {
            if (glClearStencil != null)
            {
                glClearStencil(s);
            }
        }

        // GLproc (void, glClipPlane,	(GLenum plane, const GLdouble *equation))
        public unsafe static void ClipPlane(GLenum plane, GLdouble[] equation)
        {
            if (glClipPlane != null)
            {
                fixed (GLdouble* ptr_equation = equation)
                {
                    glClipPlane(plane, ptr_equation);
                }
            }
        }

        // GLproc (void, glColor3b,	(GLbyte red, GLbyte green, GLbyte blue))
        public static void Color3b(GLbyte red, GLbyte green, GLbyte blue)
        {
            if (glColor3b != null)
            {
                glColor3b(red, green, blue);
            }
        }

        // GLproc (void, glColor3bv, (const GLbyte *v))
        public unsafe static void Color3bv(GLbyte[] v)
        {
            if (glColor3bv != null)
            {
                fixed (GLbyte* ptr_v = v)
                {
                    glColor3bv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor3d,	(GLdouble red, GLdouble green, GLdouble blue))
        public static void Color3d(GLdouble red, GLdouble green, GLdouble blue)
        {
            if (glColor3d != null)
            {
                glColor3d(red, green, blue);
            }
        }

        // GLproc (void, glColor3dv, (const GLdouble *v))
        public unsafe static void Color3dv(GLdouble[] v)
        {
            if (glColor3dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glColor3dv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor3f,	(GLfloat red, GLfloat green, GLfloat blue))
        public static void Color3f(GLfloat red, GLfloat green, GLfloat blue)
        {
            if (glColor3f != null)
            {
                glColor3f(red, green, blue);
            }
        }

        // GLproc (void, glColor3fv, (const GLfloat *v))
        public unsafe static void Color3fv(GLfloat[] v)
        {
            if (glColor3fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glColor3fv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor3i,	(GLint red, GLint green, GLint blue))
        public static void Color3i(GLint red, GLint green, GLint blue)
        {
            if (glColor3i != null)
            {
                glColor3i(red, green, blue);
            }
        }

        // GLproc (void, glColor3iv, (const GLint *v))
        public unsafe static void Color3iv(GLint[] v)
        {
            if (glColor3iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glColor3iv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor3s,	(GLshort red, GLshort green, GLshort blue))
        public static void Color3s(GLshort red, GLshort green, GLshort blue)
        {
            if (glColor3s != null)
            {
                glColor3s(red, green, blue);
            }
        }

        // GLproc (void, glColor3sv, (const GLshort *v))
        public unsafe static void Color3sv(GLshort[] v)
        {
            if (glColor3sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glColor3sv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor3ub, (GLubyte red, GLubyte green, GLubyte blue))
        public static void Color3ub(GLubyte red, GLubyte green, GLubyte blue)
        {
            if (glColor3ub != null)
            {
                glColor3ub(red, green, blue);
            }
        }

        // GLproc (void, glColor3ubv, (const GLubyte *v))
        public unsafe static void Color3ubv(GLubyte[] v)
        {
            if (glColor3ubv != null)
            {
                fixed (GLubyte* ptr_v = v)
                {
                    glColor3ubv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor3ui, (GLuint red, GLuint green, GLuint blue))
        public static void Color3ui(GLuint red, GLuint green, GLuint blue)
        {
            if (glColor3ui != null)
            {
                glColor3ui(red, green, blue);
            }
        }

        // GLproc (void, glColor3uiv, (const GLuint *v))
        public unsafe static void Color3uiv(GLuint[] v)
        {
            if (glColor3uiv != null)
            {
                fixed(GLuint* ptr_v = v)
                {
                    glColor3uiv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor3us, (GLushort red, GLushort green, GLushort blue))
        public static void Color3us(GLushort red, GLushort green, GLushort blue)
        {
            if (glColor3us != null)
            {
                glColor3us(red, green, blue);
            }
        }

        // GLproc (void, glColor3usv, (const GLushort *v))
        public unsafe static void Color3usv(GLushort[] v)
        {
            if (glColor3usv != null)
            {
                fixed (GLushort* ptr_v = v)
                {
                    glColor3usv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor4b, (GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha))
        public static void Color4b(GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha)
        {
            if (glColor4b != null)
            {
                glColor4b(red, green, blue, alpha);
            }
        }

        // GLproc (void, glColor4bv, (const GLbyte *v))
        public unsafe static void Color4bv(GLbyte[] v)
        {
            if (glColor4bv != null)
            {
                fixed (GLbyte* ptr_v = v)
                {
                    glColor4bv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor4d,	(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha))
        public static void Color4d(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha)
        {
            if (glColor4d != null)
            {
                glColor4d(red, green, blue, alpha);
            }
        }

        // GLproc (void, glColor4dv, (const GLdouble *v))
        public unsafe static void Color4dv(GLdouble[] v)
        {
            if (glColor4dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glColor4dv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor4f,	(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha))
        public static void Color4f(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha)
        {
            if (glColor4f != null)
            {
                glColor4f(red, green, blue, alpha);
            }
        }

        // GLproc (void, glColor4fv, (const GLfloat *v))
        public unsafe static void Color4fv(GLfloat[] v)
        {
            if (glColor4fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glColor4fv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor4i,	(GLint red, GLint green, GLint blue, GLint alpha))
        public static void Color4i(GLint red, GLint green, GLint blue, GLint alpha)
        {
            if (glColor4i != null)
            {
                glColor4i(red, green, blue, alpha);
            }
        }

        // GLproc (void, glColor4iv, (const GLint *v))
        public unsafe static void Color4iv(GLint[] v)
        {
            if (glColor4iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glColor4iv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor4s,	(GLshort red, GLshort green, GLshort blue, GLshort alpha))
        public static void Color4s(GLshort red, GLshort green, GLshort blue, GLshort alpha)
        {
            if (glColor4s != null)
            {
                glColor4s(red, green, blue, alpha);
            }
        }

        // GLproc (void, glColor4sv, (const GLshort *v))
        public unsafe static void Color4sv(GLshort[] v)
        {
            if (glColor4sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glColor4sv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor4ub, (GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha))
        public static void Color4ub(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha)
        {
            if (glColor4ub != null)
            {
                glColor4ub(red, green, blue, alpha);
            }
        }

        // GLproc (void, glColor4ubv, (const GLubyte *v))
        public unsafe static void Color4ubv(GLubyte[] v)
        {
            if (glColor4ubv != null)
            {
                fixed (GLubyte* ptr_v = v)
                {
                    glColor4ubv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor4ui, (GLuint red, GLuint green, GLuint blue, GLuint alpha))
        public static void Color4ui(GLuint red, GLuint green, GLuint blue, GLuint alpha)
        {
            if (glColor4ui != null)
            {
                glColor4ui(red, green, blue, alpha);
            }
        }

        // GLproc (void, glColor4uiv, (const GLuint *v))
        public unsafe static void Color4uiv(GLuint[] v)
        {
            if (glColor4uiv != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glColor4uiv(ptr_v);
                }
            }
        }

        // GLproc (void, glColor4us, (GLushort red, GLushort green, GLushort blue, GLushort alpha))
        public static void Color4us(GLushort red, GLushort green, GLushort blue, GLushort alpha)
        {
            if (glColor4us != null)
            {
                glColor4us(red, green, blue, alpha);
            }
        }

        // GLproc (void, glColor4usv, (const GLushort *v))
        public unsafe static void Color4usv(GLushort[] v) 
        {
            if (glColor4usv != null)
            {
                fixed (GLushort* ptr_v = v)
                {
                    glColor4usv(ptr_v);
                }
            }
        }

        // GLproc (void, glColorMask, (GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha))
        public static void ColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha)
        {
            if (glColorMask != null)
            {
                glColorMask(red, green, blue, alpha);
            }
        }

        // GLproc (void, glColorMaterial,	(GLenum face, GLenum mode))
        public static void ColorMaterial(GLenum face, GLenum mode)
        {
            if (glColorMaterial != null)
            {
                glColorMaterial(face, mode);
            }
        }

        // GLproc (void, glColorPointer,	(GLint size, GLenum type, GLsizei stride, const GLvoid *pointer))
        public unsafe static void ColorPointer(GLint size, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glColorPointer != null)
            {
                glColorPointer(size, type, stride, pointer.ToPointer());
            }
        }

        // GLproc (void, glCopyPixels, (GLint x, GLint y, GLsizei width, GLsizei height, GLenum type))
        public static void CopyPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum type)
        {
            if (glCopyPixels != null)
            {
                glCopyPixels(x, y, width, height, type);
            }
        }

        // GLproc (void, glCopyTexImage1D, (GLenum target, GLint level, GLenum internalFormat, GLint x, GLint y, GLsizei width, GLint border))
        public static void CopyTexImage1D(GLenum target, GLint level, GLenum internalFormat, GLint x, GLint y, GLsizei width, GLint border)
        {
            if (glCopyTexImage1D != null)
            {
                glCopyTexImage1D(target, level, internalFormat, x, y, width, border);
            }
        }

        // GLproc (void, glCopyTexImage2D, (GLenum target, GLint level, GLenum internalFormat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border))
        public static void CopyTexImage2D(GLenum target, GLint level, GLenum internalFormat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border)
        {
            if (glCopyTexImage2D != null)
            {
                glCopyTexImage2D(target, level, internalFormat, x, y, width, height, border);
            }
        }

        // GLproc (void, glCopyTexSubImage1D, (GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width))
        public static void CopyTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
        {
            if (glCopyTexSubImage1D != null)
            {
                glCopyTexSubImage1D(target, level, xoffset, x, y, width);
            }
        }

        // GLproc (void, glCopyTexSubImage2D, (GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height))
        public static void CopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glCopyTexSubImage2D != null)
            {
                glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
            }
        }

        // GLproc (void, glCullFace,	(GLenum mode))
        public static void CullFace(GLenum mode)
        {
            if (glCullFace != null)
            {
                glCullFace(mode);
            }
        }

        // GLproc (void, glDeleteLists,	(GLuint list, GLsizei range))
        public static void DeleteLists(GLuint list, GLsizei range)
        {
            if (glDeleteLists != null)
            {
                glDeleteLists(list, range);
            }
        }

        // GLproc (void, glDeleteTextures, (GLsizei n, const GLuint *textures))
        public unsafe static void DeleteTextures(GLsizei n, GLuint[] textures)
        {
            if (glDeleteTextures != null)
            {
                fixed (GLuint* ptr_textures = textures)
                {
                    glDeleteTextures(n, ptr_textures);
                }
            }
        }   

        // GLproc (void, glDepthFunc,	(GLenum func))
        public static void DepthFunc(GLenum func)
        {
            if (glDepthFunc != null)
            {
                glDepthFunc(func);
            }
        }

        // GLproc (void, glDepthMask,	(GLboolean flag))
        public static void DepthMask(GLboolean flag)
        {
            if (glDepthMask != null)
            {
                glDepthMask(flag);
            }
        }

        // GLproc (void, glDepthRange, (GLclampd zNear, GLclampd zFar))
        public static void DepthRange(GLclampd zNear, GLclampd zFar)
        {
            if (glDepthRange != null)
            {
                glDepthRange(zNear, zFar);
            }
        }

        // GLproc (void, glDisable,	(GLenum cap))
        public static void Disable(GLenum cap)
        {
            if (glDisable != null)
            {
                glDisable(cap);
            }
        }

        // GLproc (void, glDisableClientState, (GLenum array))
        public static void DisableClientState(GLenum array)
        {
            if (glDisableClientState != null)
            {
                glDisableClientState(array);
            }
        }

        // GLproc (void, glDrawArrays, (GLenum mode, GLint first, GLsizei count))
        public static void DrawArrays(GLenum mode, GLint first, GLsizei count)
        {
            if (glDrawArrays != null)
            {
                glDrawArrays(mode, first, count);
            }
        }

        // GLproc (void, glDrawBuffer, (GLenum mode))
        public static void DrawBuffer(GLenum mode)
        {
            if (glDrawBuffer != null)
            {
                glDrawBuffer(mode);
            }
        }

        // GLproc (void, glDrawElements, (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices))
        public unsafe static void DrawElements(GLenum mode, GLsizei count, GLenum type, IntPtr indices)
        {
            if (glDrawElements != null)
            {
                glDrawElements(mode, count, type, indices.ToPointer());
            }
        }

        // GLproc (void, glDrawPixels,	(GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *pixels))
        public unsafe static void DrawPixels(GLsizei width, GLsizei height, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glDrawPixels != null)
            {
                glDrawPixels(width, height, format, type, pixels.ToPointer());
            }
        }

        // GLproc (void, glEdgeFlag,	(GLboolean flag))
        public static void EdgeFlag(GLboolean flag)
        {
            if (glEdgeFlag != null)
            {
                glEdgeFlag(flag);
            }
        }

        // GLproc (void, glEdgeFlagPointer, (GLsizei stride, const GLvoid *pointer))
        public unsafe static void EdgeFlagPointer(GLsizei stride, IntPtr pointer)
        {
            if (glEdgeFlagPointer != null)
            {
                glEdgeFlagPointer(stride, pointer.ToPointer());
            }
        }

        // GLproc (void, glEdgeFlagv,	(const GLboolean *flag))
        public unsafe static void EdgeFlagv(GLboolean[] flag)
        {
            if (glEdgeFlagv != null)
            {
                fixed (GLboolean* ptr_flag = flag)
                {
                    glEdgeFlagv(ptr_flag);
                }
            }
        }

        // GLproc (void, glEnable,		(GLenum cap))
        public static void Enable(GLenum cap)
        {
            if (glEnable != null)
            {
                glEnable(cap);
            }
        }

        // GLproc (void, glEnableClientState, (GLenum array))
        public static void EnableClientState(GLenum array)
        {
            if (glEnableClientState != null)
            {
                glEnableClientState(array);
            }
        }

        // GLproc (void, glEnd,		(void))
        public static void End()
        {
            if (glEnd != null)
            {
                glEnd();
            }
        }

        // GLproc (void, glEndList,	(void))
        public static void EndList()
        {
            if (glEndList != null)
            {
                glEndList();
            }
        }

        // GLproc (void, glEvalCoord1d,	(GLdouble u))
        public static void EvalCoord1d(GLdouble u)
        {
            if (glEvalCoord1d != null)
            {
                glEvalCoord1d(u);
            }
        }

        // GLproc (void, glEvalCoord1dv,	(const GLdouble *u))
        public unsafe static void EvalCoord1dv(GLdouble[] u)
        {
            if (glEvalCoord1dv != null)
            {
                fixed (GLdouble* ptr_u = u)
                {
                    glEvalCoord1dv(ptr_u);
                }
            }
        }

        // GLproc (void, glEvalCoord1f,	(GLfloat u))
        public static void EvalCoord1f(GLfloat u)
        {
            if (glEvalCoord1f != null)
            {
                glEvalCoord1f(u);
            }
        }

        // GLproc (void, glEvalCoord1fv,	(const GLfloat *u))
        public unsafe static void EvalCoord1fv(GLfloat[] u)
        {
            if (glEvalCoord1fv != null)
            {
                fixed(GLfloat* ptr_u = u)
                {
                    glEvalCoord1fv(ptr_u);
                }
            }
        }

        // GLproc (void, glEvalCoord2d,	(GLdouble u, GLdouble v))
        public static void EvalCoord2d(GLdouble u, GLdouble v)
        {
            if (glEvalCoord2d != null)
            {
                glEvalCoord2d(u, v);
            }
        }

        // GLproc (void, glEvalCoord2dv,	(const GLdouble *u))
        public unsafe static void EvalCoord2dv(GLdouble[] u)
        {
            if (glEvalCoord2dv != null)
            {
                fixed(GLdouble* ptr_u = u)
                {
                    glEvalCoord2dv(ptr_u);
                }
            }
        }

        // GLproc (void, glEvalCoord2f,	(GLfloat u, GLfloat v))
        public static void EvalCoord2f(GLfloat u, GLfloat v)
        {
            if (glEvalCoord2f != null)
            {
                glEvalCoord2f(u, v);
            }
        }

        // GLproc (void, glEvalCoord2fv,	(const GLfloat *u))
        public unsafe static void EvalCoord2fv(GLfloat[] u)
        {
            if (glEvalCoord2fv != null)
            {
                fixed (GLfloat* ptr_u = u)
                {
                    glEvalCoord2fv(ptr_u);
                }
            }
        }

        // GLproc (void, glEvalMesh1,	(GLenum mode, GLint i1, GLint i2))
        public static void EvalMesh1(GLenum mode, GLint i1, GLint i2)
        {
            if (glEvalMesh1 != null)
            {
                glEvalMesh1(mode, i1, i2);
            }
        }

        // GLproc (void, glEvalMesh2,	(GLenum mode, GLint i1, GLint i2, GLint j1, GLint j2))
        public static void EvalMesh2(GLenum mode, GLint i1, GLint i2, GLint j1, GLint j2)
        {
            if (glEvalMesh2 != null)
            {
                glEvalMesh2(mode, i1, i2, j1, j2);
            }
        }

        // GLproc (void, glEvalPoint1, (GLint i))
        public static void EvalPoint1(GLint i)
        {
            if (glEvalPoint1 != null)
            {
                glEvalPoint1(i);
            }
        }

        // GLproc (void, glEvalPoint2, (GLint i, GLint j))
        public static void EvalPoint2(GLint i, GLint j)
        {
            if (glEvalPoint2 != null)
            {
                glEvalPoint2(i, j);
            }
        }

        // GLproc (void, glFeedbackBuffer, (GLsizei size, GLenum type, GLfloat *buffer))
        public unsafe static void FeedbackBuffer(GLsizei size, GLenum type, GLfloat[] buffer)
        {
            if (glFeedbackBuffer != null)
            {
                fixed (GLfloat* ptr_buffer = buffer)
                {
                    glFeedbackBuffer(size, type, ptr_buffer);
                }
            }
        }

        // GLproc (void, glFinish,		(void))
        public static void Finish()
        {
            if (glFinish != null)
            {
                glFinish();
            }
        }

        // GLproc (void, glFlush,		(void))
        public static void Flush()
        {
            if (glFlush != null)
            {
                glFlush();
            }
        }

        // GLproc (void, glFogf,		(GLenum pname, GLfloat param))
        public static void Fogf(GLenum pname, GLfloat param)
        {
            if (glFogf != null)
            {
                glFogf(pname, param);
            }
        }

        // GLproc (void, glFogfv,		(GLenum pname, const GLfloat *params))
        public unsafe static void Fogfv(GLenum pname, GLfloat[] parameters)
        {
            if (glFogfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glFogfv(pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glFogi,		(GLenum pname, GLint param))
        public static void Fogi(GLenum pname, GLint param)
        {
            if (glFogi != null)
            {
                glFogi(pname, param);
            }
        }

        // GLproc (void, glFogiv,		(GLenum pname, const GLint *params))
        public unsafe static void Fogiv(GLenum pname, GLint[] parameters)
        {
            if (glFogiv != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glFogiv(pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glFrontFace,	(GLenum mode))
        public static void FrontFace(GLenum mode)
        {
            if (glFrontFace != null)
            {
                glFrontFace(mode);
            }
        }

        // GLproc (void, glFrustum,	(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar))
        public static void Frustum(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)
        {
            if (glFrustum != null)
            {
                glFrustum(left, right, bottom, top, zNear, zFar);
            }
        }

        // GLproc (GLuint, glGenLists, (GLsizei range))
        public static GLuint GenLists(GLsizei range)
        {
            if (glGenLists != null)
            {
                return glGenLists(range);
            }
            else
            {
                return 0;
            }
        }

        // GLproc (void, glGenTextures, (GLsizei n, GLuint *textures))
        public unsafe static void GenTextures(GLsizei n, GLuint[] textures)
        {
            if (glGenTextures != null)
            {
                fixed (GLuint* ptr_textures = textures)
                {
                    glGenTextures(n, ptr_textures);
                }
            }
        }

        // GLproc (void, glGetBooleanv, (GLenum pname, GLboolean *params))
        public unsafe static void GetBooleanv(GLenum pname, GLboolean[] parameters)
        {
            if (glGetBooleanv != null)
            {
                fixed (GLboolean* ptr_parameters = parameters)
                {
                    glGetBooleanv(pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetClipPlane, (GLenum plane, GLdouble *equation))
        public unsafe static void GetClipPlane(GLenum plane, GLdouble[] equation)
        {
            if (glGetClipPlane != null)
            {
                fixed (GLdouble* ptr_equation = equation)
                {
                    glGetClipPlane(plane, ptr_equation);
                }
            }
        }

        // GLproc (void, glGetDoublev, (GLenum pname, GLdouble *params))
        public unsafe static void GetDoublev(GLenum pname, GLdouble[] parameters)
        {
            if (glGetDoublev != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetDoublev(pname, ptr_parameters);
                }
            }
        }

        // GLproc (GLenum, glGetError, (void))
        public static GLenum GetError()
        {
            if (glGetError != null)
            {
                return glGetError();
            }
            else
            {
                return 0;
            }
        }

        // GLproc (void, glGetFloatv,	(GLenum pname, GLfloat *params))
        public unsafe static void GetFloatv(GLenum pname, GLfloat[] parameters)
        {
            if (glGetFloatv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetFloatv(pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetIntegerv, (GLenum pname, GLint *params))
        public unsafe static void GetIntegerv(GLenum pname, GLint[] parameters)
        {
            if (GL.glGetIntegerv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetIntegerv(pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetLightfv, (GLenum light, GLenum pname, GLfloat *params))
        public unsafe static void GetLightfv(GLenum light, GLenum pname, GLfloat[] parameters)
        {
            if (glGetLightfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetLightfv(light, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetLightiv, (GLenum light, GLenum pname, GLint *params))
        public unsafe static void GetLightiv(GLenum light, GLenum pname, GLint[] parameters)
        {
            if (glGetLightiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetLightiv(light, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetMapdv,	(GLenum target, GLenum query, GLdouble *v))
        public unsafe static void GetMapdv(GLenum target, GLenum query, GLdouble[] v)
        {
            if (glGetMapdv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glGetMapdv(target, query, ptr_v);
                }
            }
        }

        // GLproc (void, glGetMapfv,	(GLenum target, GLenum query, GLfloat *v))
        public unsafe static void GetMapfv(GLenum target, GLenum query, GLfloat[] v)
        {
            if (glGetMapfv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glGetMapfv(target, query, ptr_v);
                }
            }
        }

        // GLproc (void, glGetMapiv,	(GLenum target, GLenum query, GLint *v))
        public unsafe static void GetMapiv(GLenum target, GLenum query, GLint[] v)
        {
            if (glGetMapiv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glGetMapiv(target, query, ptr_v);
                }
            }
        }

        // GLproc (void, glGetMaterialfv, (GLenum face, GLenum pname, GLfloat *params))
        public unsafe static void GetMaterialfv(GLenum face, GLenum pname, GLfloat[] parameters)
        {
            if (glGetMaterialfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetMaterialfv(face, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetMaterialiv, (GLenum face, GLenum pname, GLint *params))
        public unsafe static void GetMaterialiv(GLenum face, GLenum pname, GLint[] parameters)
        {
            if (glGetMaterialiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetMaterialiv(face, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetPixelMapfv, (GLenum map, GLfloat *values))
        public unsafe static void GetPixelMapfv(GLenum map, GLfloat[] values)
        {
            if (glGetPixelMapfv != null)
            {
                fixed (GLfloat* ptr_values = values)
                {
                    glGetPixelMapfv(map, ptr_values);
                }
            }
        }

        // GLproc (void, glGetPixelMapuiv, (GLenum map, GLuint *values))
        public unsafe static void GetPixelMapuiv(GLenum map, GLuint[] values)
        {
            if (glGetPixelMapuiv != null)
            {
                fixed (GLuint* ptr_values = values)
                {
                    glGetPixelMapuiv(map, ptr_values);
                }
            }
        }

        // GLproc (void, glGetPixelMapusv, (GLenum map, GLushort *values))
        public unsafe static void GetPixelMapusv(GLenum map, GLushort[] values)
        {
            if (glGetPixelMapusv != null)
            {
                fixed (GLushort* ptr_values = values)
                {
                    glGetPixelMapusv(map, ptr_values);
                }
            }
        }

        // GLproc (void, glGetPointerv, (GLenum pname, GLvoid* *params))
        public unsafe static void GetPointerv(GLenum pname, IntPtr[] parameters)
        {
            if (glGetPointerv != null)
            {
                fixed (IntPtr* ptr_parameters = parameters)
                {
                    glGetPointerv(pname, (void**)ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetPolygonStipple, (GLubyte *mask))
        public unsafe static void GetPolygonStipple(GLubyte[] mask)
        {
            if (glGetPolygonStipple != null)
            {
                fixed (GLubyte* ptr_mask = mask)
                {
                    glGetPolygonStipple(ptr_mask);
                }
            }
        }

        // GLproc (const GLubyte *, glGetString, (GLenum name))
        public unsafe static string GetString(GLenum name)
        {
            if (glGetString != null)
            {
                return (new string((sbyte*)glGetString(name)));
            }
            else
            {
                return null;
            }
        }

        // GLproc (void, glGetTexEnvfv, (GLenum target, GLenum pname, GLfloat *params))
        public unsafe static void GetTexEnvfv(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetTexEnvfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetTexEnvfv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetTexEnviv, (GLenum target, GLenum pname, GLint *params))
        public unsafe static void GetTexEnviv(GLenum coord, GLenum pname, GLint[] parameters)
        {
            if (glGetTexEnviv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetTexEnviv(coord, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetTexGendv, (GLenum coord, GLenum pname, GLdouble *params))
        public unsafe static void GetTexGendv(GLenum coord, GLenum pname, GLdouble[] parameters)
        {
            if (glGetTexGendv != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetTexGendv(coord, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetTexGenfv, (GLenum coord, GLenum pname, GLfloat *params))
        public unsafe static void GetTexGenfv(GLenum coord, GLenum pname, GLfloat[] parameters)
        {
            if (glGetTexGenfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetTexGenfv(coord, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetTexGeniv, (GLenum coord, GLenum pname, GLint *params))
        public unsafe static void GetTexGeniv(GLenum coord, GLenum pname, GLint[] parameters)
        {
            if (glGetTexGeniv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetTexGeniv(coord, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetTexImage, (GLenum target, GLint level, GLenum format, GLenum type, GLvoid *pixels))
        public unsafe static void GetTexImage(GLenum target, GLint level, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glGetTexImage != null)
            {
                glGetTexImage(target, level, format, type, pixels.ToPointer());
            }
        }

        // GLproc (void, glGetTexLevelParameterfv, (GLenum target, GLint level, GLenum pname, GLfloat *params))
        public unsafe static void GetTexLevelParameterfv(GLenum target, GLint level, GLenum pname, GLfloat[] parameters)
        {
            if (glGetTexLevelParameterfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetTexLevelParameterfv(target, level, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetTexLevelParameteriv, (GLenum target, GLint level, GLenum pname, GLint *params))
        public unsafe static void GetTexLevelParameteriv(GLenum target, GLint level, GLenum pname, GLint[] parameters)
        {
            if (glGetTexLevelParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetTexLevelParameteriv(target, level, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetTexParameterfv, (GLenum target, GLenum pname, GLfloat *params))
        public unsafe static void GetTexParameterfv(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetTexParameterfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetTexParameterfv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetTexParameteriv, (GLenum target, GLenum pname, GLint *params))
        public unsafe static void GetTexParameteriv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetTexParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetTexParameteriv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glHint,		(GLenum target, GLenum mode))
        public static void Hint(GLenum target, GLenum mode)
        {
            if (glHint != null)
            {
                glHint(target, mode);
            }
        }

        // GLproc (void, glIndexMask,	(GLuint mask))
        public static void IndexMask(GLuint mask)
        {
            if (glIndexMask != null)
            {
                glIndexMask(mask);
            }
        }

        // GLproc (void, glIndexPointer, (GLenum type, GLsizei stride, const GLvoid *pointer))
        public unsafe static void IndexPointer(GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glIndexPointer != null)
            {
                glIndexPointer(type, stride, pointer.ToPointer());
            }
        }

        // GLproc (void, glIndexd,		(GLdouble c))
        public static void Indexd(GLdouble c)
        {
            if (glIndexd != null)
            {
                glIndexd(c);
            }
        }

        // GLproc (void, glIndexdv,	(const GLdouble *c))
        public unsafe static void Indexdv(GLdouble[] c)
        {
            if (glIndexdv != null)
            {
                fixed (GLdouble* ptr_c = c)
                {
                    glIndexdv(ptr_c);
                }
            }
        }

        // GLproc (void, glIndexf,		(GLfloat c))
        public static void Indexf(GLfloat c)
        {
            if (glIndexf != null)
            {
                glIndexf(c);
            }
        }

        // GLproc (void, glIndexfv,	(const GLfloat *c))
        public unsafe static void Indexfv(GLfloat[] c)
        {
            if (glIndexfv != null)
            {
                fixed (GLfloat* ptr_c = c)
                {
                    glIndexfv(ptr_c);
                }
            }
        }

        // GLproc (void, glIndexi,		(GLint c))
        public static void Indexi(GLint c)
        {
            if (glIndexi != null)
            {
                glIndexi(c);
            }
        }

        // GLproc (void, glIndexiv,	(const GLint *c))
        public unsafe static void Indexiv(GLint[] c)
        {
            if (glIndexiv != null)
            {
                fixed (GLint* ptr_c = c)
                {
                    glIndexiv(ptr_c);
                }
            }
        }

        // GLproc (void, glIndexs,		(GLshort c))
        public static void Indexs(GLshort c)
        {
            if (glIndexs != null)
            {
                glIndexs(c);
            }
        }

        // GLproc (void, glIndexsv,	(const GLshort *c))
        public unsafe static void Indexsv(GLshort[] c)
        {
            if (glIndexsv != null)
            {
                fixed (GLshort* ptr_c = c)
                {
                    glIndexsv(ptr_c);
                }
            }
        }

        // GLproc (void, glIndexub,	(GLubyte c))
        public static void Indexub(GLubyte c)
        {
            if (glIndexub != null)
            {
                glIndexub(c);
            }
        }

        // GLproc (void, glIndexubv,	(const GLubyte *c))
        public unsafe static void Indexubv(GLubyte[] c)
        {
            if (glIndexubv != null)
            {
                fixed (GLubyte* ptr_c = c)
                {
                    glIndexubv(ptr_c);
                }
            }
        }

        // GLproc (void, glInitNames,	(void))
        public static void InitNames()
        {
            if (glInitNames != null)
            {
                glInitNames();
            }
        }

        // GLproc (void, glInterleavedArrays, (GLenum format, GLsizei stride, const GLvoid *pointer))
        public unsafe static void InterleavedArrays(GLenum format, GLsizei stride, IntPtr pointer)
        {
            if (glInterleavedArrays != null)
            {
                glInterleavedArrays(format, stride, pointer.ToPointer());
            }
        }

        // GLproc (GLboolean, glIsEnabled, (GLenum cap))
        public static GLboolean IsEnabled(GLenum cap)
        {
            if (glIsEnabled != null)
            {
                return glIsEnabled(cap);
            }
            else
            {
                return false;
            }
        }

        // GLproc (GLboolean, glIsList,	(GLuint list))
        public static GLboolean IsList(GLuint list)
        {
            if (glIsList != null)
            {
                return glIsList(list);
            }
            else
            {
                return false;
            }
        }

        // GLproc (GLboolean, glIsTexture, (GLuint texture))
        public static GLboolean IsTexture(GLuint texture)
        {
            if (glIsTexture != null)
            {
                return glIsTexture(texture);
            }
            else
            {
                return false;
            }
        }

        // GLproc (void, glLightModelf,	(GLenum pname, GLfloat param))
        public static void LightModelf(GLenum pname, GLfloat param)
        {
            if (glLightModelf != null)
            {
                glLightModelf(pname, param);
            }
        }

        // GLproc (void, glLightModelfv,	(GLenum pname, const GLfloat *params))
        public unsafe static void LightModelfv(GLenum pname, GLfloat[] parameters)
        {
            if (glLightModelfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glLightModelfv(pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glLightModeli,	(GLenum pname, GLint param))
        public static void LightModeli(GLenum pname, GLint param)
        {
            if (glLightModeli != null)
            {
                glLightModeli(pname, param);
            }
        }

        // GLproc (void, glLightModeliv,	(GLenum pname, const GLint *params))
        public unsafe static void LightModeliv(GLenum pname, GLint[] parameters)
        {
            if (glLightModeliv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glLightModeliv(pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glLightf,			(GLenum light, GLenum pname, GLfloat param))
        public static void Lightf(GLenum light, GLenum pname, GLfloat param)
        {
            if (glLightf != null)
            {
                glLightf(light, pname, param);
            }
        }

        // GLproc (void, glLightfv,		(GLenum light, GLenum pname, const GLfloat *params))
        public unsafe static void Lightfv(GLenum light, GLenum pname, GLfloat[] parameters)
        {
            if (glLightfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glLightfv(light, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glLighti,			(GLenum light, GLenum pname, GLint param))
        public static void Lighti(GLenum light, GLenum pname, GLint param)
        {
            if (glLighti != null)
            {
                glLighti(light, pname, param);
            }
        }

        // GLproc (void, glLightiv,		(GLenum light, GLenum pname, const GLint *params))
        public unsafe static void Lightiv(GLenum light, GLenum pname, GLint[] parameters)
        {
            if (glLightiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glLightiv(light, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glLineStipple,	(GLint factor, GLushort pattern))
        public static void LineStipple(GLint factor, GLushort pattern)
        {
            if (glLineStipple != null)
            {
                glLineStipple(factor, pattern);
            }
        }

        // GLproc (void, glLineWidth,		(GLfloat width))
        public static void LineWidth(GLfloat width)
        {
            if (glLineWidth != null)
            {
                glLineWidth(width);
            }
        }

        // GLproc (void, glListBase,		(GLuint base))
        public static void ListBase(GLuint listbase)
        {
            if (glListBase != null)
            {
                glListBase(listbase);
            }
        }

        // GLproc (void, glLoadIdentity,	(void))
        public unsafe static void LoadIdentity()
        {
            if (glLoadIdentity != null)
            {
                glLoadIdentity();
            }
        }

        // GLproc (void, glLoadMatrixd,	(const GLdouble *m))
        public unsafe static void LoadMatrixd(GLdouble[] m)
        {
            if (glLoadMatrixd != null)
            {
                fixed (GLdouble* ptr_m = m)
                {
                    glLoadMatrixd(ptr_m);
                }
            }
        }

        // GLproc (void, glLoadMatrixf,	(const GLfloat *m))
        public unsafe static void LoadMatrixf(GLfloat[] m)
        {
            if (glLoadMatrixf != null)
            {
                fixed (GLfloat* ptr_m = m)
                {
                    glLoadMatrixf(ptr_m);
                }
            }
        }

        // GLproc (void, glLoadName,		(GLuint name))
        public static void LoadName(GLuint name)
        {
            if (glLoadName != null)
            {
                glLoadName(name);
            }
        }

        // GLproc (void, glLogicOp,		(GLenum opcode))
        public static void LogicOp(GLenum opcode)
        {
            if (glLogicOp != null)
            {
                glLogicOp(opcode);
            }
        }

        // GLproc (void, glMap1d,			(GLenum target, GLdouble u1, GLdouble u2, GLint stride, GLint order, const GLdouble *points))
        public unsafe static void Map1d(GLenum target, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble[] points)
        {
            if (glMap1d != null)
            {
                fixed (GLdouble* ptr_points = points)
                {
                    glMap1d(target, u1, u2, stride, order, ptr_points);
                }
            }
        }

        // GLproc (void, glMap1f,			(GLenum target, GLfloat u1, GLfloat u2, GLint stride, GLint order, const GLfloat *points))
        public unsafe static void Map1f(GLenum target, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat[] points)
        {
            if (glMap1f != null)
            {
                fixed (GLfloat* ptr_points = points)
                {
                    glMap1f(target, u1, u2, stride, order, ptr_points);
                }
            }
        }

        // GLproc (void, glMap2d,			(GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, const GLdouble *points))
        public unsafe static void Map2d(GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble[] points)
        {
            if (glMap2d != null)
            {
                fixed (GLdouble* ptr_points = points)
                {
                    glMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ptr_points);
                }
            }
        }

        // GLproc (void, glMap2f,			(GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, const GLfloat *points))
        public unsafe static void Map2f(GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat[] points)
        {
            if (glMap2f != null)
            {
                fixed (GLfloat* ptr_points = points)
                {
                    glMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ptr_points);
                }
            }
        }

        // GLproc (void, glMapGrid1d,		(GLint un, GLdouble u1, GLdouble u2))
        public static void MapGrid1d(GLint un, GLdouble u1, GLdouble u2)
        {
            if (glMapGrid1d != null)
            {
                glMapGrid1d(un, u1, u2);
            }
        }

        // GLproc (void, glMapGrid1f,		(GLint un, GLfloat u1, GLfloat u2))
        public static void MapGrid1f(GLint un, GLfloat u1, GLfloat u2)
        {
            if (glMapGrid1f != null)
            {
                glMapGrid1f(un, u1, u2);
            }
        }

        // GLproc (void, glMapGrid2d,		(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2))
        public static void MapGrid2d(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2)
        {
            if (glMapGrid2d != null)
            {
                glMapGrid2d(un, u1, u2, vn, v1, v2);
            }
        }

        // GLproc (void, glMapGrid2f,		(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2))
        public static void MapGrid2f(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2)
        {
            if (glMapGrid2f != null)
            {
                glMapGrid2f(un, u1, u2, vn, v1, v2);
            }
        }

        // GLproc (void, glMaterialf,		(GLenum face, GLenum pname, GLfloat param))
        public static void Materialf(GLenum face, GLenum pname, GLfloat param)
        {
            if (glMaterialf != null)
            {
                glMaterialf(face, pname, param);
            }
        }

        // GLproc (void, glMaterialfv,		(GLenum face, GLenum pname, const GLfloat *params))
        public unsafe static void Materialfv(GLenum face, GLenum pname, GLfloat[] parameters)
        {
            if (glMaterialfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glMaterialfv(face, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glMateriali,		(GLenum face, GLenum pname, GLint param))
        public static void Materiali(GLenum face, GLenum pname, GLint param)
        {
            if (glMateriali != null)
            {
                glMateriali(face, pname, param);
            }
        }

        // GLproc (void, glMaterialiv,		(GLenum face, GLenum pname, const GLint *params))
        public unsafe static void Materialiv(GLenum face, GLenum pname, GLint[] parameters)
        {
            if (glMaterialiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glMaterialiv(face, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glMatrixMode,		(GLenum mode))
        public static void MatrixMode(GLenum mode)
        {
            if (glMatrixMode != null)
            {
                glMatrixMode(mode);
            }
        }

        // GLproc (void, glMultMatrixd,	(const GLdouble *m))
        public unsafe static void MultMatrixd(GLdouble[] m)
        {
            if (glMultMatrixd != null)
            {
                fixed (GLdouble* ptr_m = m)
                {
                    glMultMatrixd(ptr_m);
                }
            }
        }

        // GLproc (void, glMultMatrixf,	(const GLfloat *m))
        public unsafe static void MultMatrixf(GLfloat[] m)
        {
            if (glMultMatrixf != null)
            {
                fixed (GLfloat* ptr_m = m)
                {
                    glMultMatrixf(ptr_m);
                }
            }
        }

        // GLproc (void, glNewList,		(GLuint list, GLenum mode))
        public static void NewList(GLuint list, GLenum mode)
        {
            if (glNewList != null)
            {
                glNewList(list, mode);
            }
        }

        // GLproc (void, glNormal3b,		(GLbyte nx, GLbyte ny, GLbyte nz))
        public static void Normal3b(GLbyte nx, GLbyte ny, GLbyte nz)
        {
            if (glNormal3b != null)
            {
                glNormal3b(nx, ny, nz);
            }
        }

        // GLproc (void, glNormal3bv,		(const GLbyte *v))
        public unsafe static void Normal3bv(GLbyte[] v)
        {
            if (glNormal3bv != null)
            {
                fixed (GLbyte* ptr_v = v)
                {
                    glNormal3bv(ptr_v);
                }
            }
        }

        // GLproc (void, glNormal3d,		(GLdouble nx, GLdouble ny, GLdouble nz))
        public static void Normal3d(GLdouble nx, GLdouble ny, GLdouble nz)
        {
            if (glNormal3d != null)
            {
                glNormal3d(nx, ny, nz);
            }
        }

        // GLproc (void, glNormal3dv,		(const GLdouble *v))
        public unsafe static void Normal3dv(GLdouble[] v)
        {
            if (glNormal3dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glNormal3dv(ptr_v);
                }
            }
        }

        // GLproc (void, glNormal3f,		(GLfloat nx, GLfloat ny, GLfloat nz))
        public static void Normal3f(GLfloat nx, GLfloat ny, GLfloat nz)
        {
            if (glNormal3f != null)
            {
                glNormal3f(nx, ny, nz);
            }
        }

        // GLproc (void, glNormal3fv,		(const GLfloat *v))
        public unsafe static void Normal3fv(GLfloat[] v)
        {
            if (glNormal3fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glNormal3fv(ptr_v);
                }
            }
        }

        // GLproc (void, glNormal3i,		(GLint nx, GLint ny, GLint nz))
        public static void Normal3i(GLint nx, GLint ny, GLint nz)
        {
            if (glNormal3i != null)
            {
                glNormal3i(nx, ny, nz);
            }
        }

        // GLproc (void, glNormal3iv,		(const GLint *v))
        public unsafe static void Normal3iv(GLint[] v)
        {
            if (glNormal3iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glNormal3iv(ptr_v);
                }
            }
        }

        // GLproc (void, glNormal3s,		(GLshort nx, GLshort ny, GLshort nz))
        public static void Normal3s(GLshort nx, GLshort ny, GLshort nz)
        {
            if (glNormal3s != null)
            {
                glNormal3s(nx, ny, nz);
            }
        }

        // GLproc (void, glNormal3sv,		(const GLshort *v))
        public unsafe static void Normal3sv(GLshort[] v)
        {
            if (glNormal3sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glNormal3sv(ptr_v);
                }
            }
        }

        // GLproc (void, glNormalPointer,	(GLenum type, GLsizei stride, const GLvoid *pointer))
        public unsafe static void NormalPointer(GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glNormalPointer != null)
            {
                glNormalPointer(type, stride, pointer.ToPointer());
            }
        }

        // GLproc (void, glOrtho,			(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar))
        public static void Ortho(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble zNear, GLdouble zFar)
        {
            if (glOrtho != null)
            {
                glOrtho(left, right, bottom, top, zNear, zFar);
            }
        }

        // GLproc (void, glPassThrough,	(GLfloat token))
        public static void PassThrough(GLfloat token)
        {
            if (glPassThrough != null)
            {
                glPassThrough(token);
            }
        }

        // GLproc (void, glPixelMapfv,		(GLenum map, GLsizei mapsize, const GLfloat *values))
        public unsafe static void PixelMapfv(GLenum map, GLsizei mapsize, GLfloat[] values)
        {
            if (glPixelMapfv != null)
            {
                fixed (GLfloat* ptr_values = values)
                {
                    glPixelMapfv(map, mapsize, ptr_values);
                }
            }
        }

        // GLproc (void, glPixelMapuiv,	(GLenum map, GLsizei mapsize, const GLuint *values))
        public unsafe static void PixelMapuiv(GLenum map, GLsizei mapsize, GLuint[] values)
        {
            if (glPixelMapuiv != null)
            {
                fixed (GLuint* ptr_values = values)
                {
                    glPixelMapuiv(map, mapsize, ptr_values);
                }
            }
        }

        // GLproc (void, glPixelMapusv,	(GLenum map, GLsizei mapsize, const GLushort *values))
        public unsafe static void PixelMapusv(GLenum map, GLsizei mapsize, GLushort[] values)
        {
            if (glPixelMapusv != null)
            {
                fixed (GLushort* ptr_values = values)
                {
                    glPixelMapusv(map, mapsize, ptr_values);
                }
            }
        }

        // GLproc (void, glPixelStoref,	(GLenum pname, GLfloat param))
        public static void PixelStoref(GLenum pname, GLfloat param)
        {
            if (glPixelStoref != null)
            {
                glPixelStoref(pname, param);
            }
        }

        // GLproc (void, glPixelStorei,	(GLenum pname, GLint param))
        public static void PixelStorei(GLenum pname, GLint param)
        {
            if (glPixelStorei != null)
            {
                glPixelStorei(pname, param);
            }
        }

        // GLproc (void, glPixelTransferf, (GLenum pname, GLfloat param))
        public static void PixelTransferf(GLenum pname, GLfloat param)
        {
            if (glPixelTransferf != null)
            {
                glPixelTransferf(pname, param);
            }
        }

        // GLproc (void, glPixelTransferi, (GLenum pname, GLint param))
        public static void PixelTransferi(GLenum pname, GLint param)
        {
            if (glPixelTransferi != null)
            {
                glPixelTransferi(pname, param);
            }
        }

        // GLproc (void, glPixelZoom,		(GLfloat xfactor, GLfloat yfactor))
        public static void PixelZoom(GLfloat xfactor, GLfloat yfactor)
        {
            if (glPixelZoom != null)
            {
                glPixelZoom(xfactor, yfactor);
            }
        }

        // GLproc (void, glPointSize,		(GLfloat size))
        public static void PointSize(GLfloat size)
        {
            if (glPointSize != null)
            {
                glPointSize(size);
            }
        }

        // GLproc (void, glPolygonMode,	(GLenum face, GLenum mode))
        public static void PolygonMode(GLenum face, GLenum mode)
        {
            if (glPolygonMode != null)
            {
                glPolygonMode(face, mode);
            }
        }

        // GLproc (void, glPolygonOffset,	(GLfloat factor, GLfloat units))
        public static void PolygonOffset(GLfloat factor, GLfloat units)
        {
            if (glPolygonOffset != null)
            {
                glPolygonOffset(factor, units);
            }
        }

        // GLproc (void, glPolygonStipple, (const GLubyte *mask))
        public unsafe static void PolygonStipple(GLubyte[] mask)
        {
            if (glPolygonStipple != null)
            {
                fixed (GLubyte* ptr_mask = mask)
                {
                    glPolygonStipple(ptr_mask);
                }
            }
        }

        // GLproc (void, glPopAttrib,		(void))
        public static void PopAttrib()
        {
            if (glPopAttrib != null)
            {
                glPopAttrib();
            }
        }

        // GLproc (void, glPopClientAttrib, (void))
        public static void PopClientAttrib()
        {
            if (glPopClientAttrib != null)
            {
                glPopClientAttrib();
            }
        }

        // GLproc (void, glPopMatrix,		(void))
        public static void PopMatrix()
        {
            if (glPopMatrix != null)
            {
                glPopMatrix();
            }
        }

        // GLproc (void, glPopName,		(void))
        public static void PopName()
        {
            if (glPopName != null)
            {
                glPopName();
            }
        }

        // GLproc (void, glPrioritizeTextures, (GLsizei n, const GLuint *textures, const GLclampf *priorities))
        public unsafe static void PrioritizeTextures(GLsizei n, GLuint[] textures, GLclampf[] priorities)
        {
            if (glPrioritizeTextures != null)
            {
                fixed (GLuint* ptr_textures = textures)
                {
                    fixed (GLclampf* ptr_priorities = priorities)
                    {
                        glPrioritizeTextures(n, ptr_textures, ptr_priorities);
                    }
                }
            }
        }

        // GLproc (void, glPushAttrib,		(GLbitfield mask))
        public static void PushAttrib(GLbitfield mask)
        {
            if (glPushAttrib != null)
            {
                glPushAttrib(mask);
            }
        }

        // GLproc (void, glPushClientAttrib, (GLbitfield mask))
        public static void PushClientAttrib(GLbitfield mask)
        {
            if (glPushClientAttrib != null)
            {
                glPushClientAttrib(mask);
            }
        }

        // GLproc (void, glPushMatrix,		(void))
        public static void PushMatrix()
        {
            if (glPushMatrix != null)
            {
                glPushMatrix();
            }
        }

        // GLproc (void, glPushName,		(GLuint name))
        public static void PushName(GLuint name)
        {
            if (glPushName != null)
            {
                glPushName(name);
            }
        }

        // GLproc (void, glRasterPos2d,	(GLdouble x, GLdouble y))
        public static void RasterPos2d(GLdouble x, GLdouble y)
        {
            if (glRasterPos2d != null)
            {
                glRasterPos2d(x, y);
            }
        }

        // GLproc (void, glRasterPos2dv,	(const GLdouble *v))
        public unsafe static void RasterPos2dv(GLdouble[] v)
        {
            if (glRasterPos2dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glRasterPos2dv(ptr_v);
                }
            }
        }

        // GLproc (void, glRasterPos2f,	(GLfloat x, GLfloat y))
        public static void RasterPos2f(GLfloat x, GLfloat y)
        {
            if (glRasterPos2f != null)
            {
                glRasterPos2f(x, y);
            }
        }

        // GLproc (void, glRasterPos2fv,	(const GLfloat *v))
        public unsafe static void RasterPos2fv(GLfloat[] v)
        {
            if (glRasterPos2fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glRasterPos2fv(ptr_v);
                }
            }
        }

        // GLproc (void, glRasterPos2i,	(GLint x, GLint y))
        public static void RasterPos2i(GLint x, GLint y)
        {
            if (glRasterPos2i != null)
            {
                glRasterPos2i(x, y);
            }
        }

        // GLproc (void, glRasterPos2iv,	(const GLint *v))
        public unsafe static void RasterPos2iv(GLint[] v)
        {
            if (glRasterPos2iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glRasterPos2iv(ptr_v);
                }
            }
        }

        // GLproc (void, glRasterPos2s,	(GLshort x, GLshort y))
        public static void RasterPos2s(GLshort x, GLshort y)
        {
            if (glRasterPos2s != null)
            {
                glRasterPos2s(x, y);
            }
        }

        // GLproc (void, glRasterPos2sv,	(const GLshort *v))
        public unsafe static void RasterPos2sv(GLshort[] v)
        {
            if (glRasterPos2sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glRasterPos2sv(ptr_v);
                }
            }
        }

        // GLproc (void, glRasterPos3d,	(GLdouble x, GLdouble y, GLdouble z))
        public static void RasterPos3d(GLdouble x, GLdouble y, GLdouble z)
        {
            if (glRasterPos3d != null)
            {
                glRasterPos3d(x, y, z);
            }
        }

        // GLproc (void, glRasterPos3dv,	(const GLdouble *v))
        public unsafe static void RasterPos3dv(GLdouble[] v)
        {
            if (glRasterPos3dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glRasterPos3dv(ptr_v);
                }
            }
        }

        // GLproc (void, glRasterPos3f,	(GLfloat x, GLfloat y, GLfloat z))
        public static void RasterPos3f(GLfloat x, GLfloat y, GLfloat z)
        {
            if (glRasterPos3f != null)
            {
                glRasterPos3f(x, y, z);
            }
        }

        // GLproc (void, glRasterPos3fv,	(const GLfloat *v))
        public unsafe static void RasterPos3fv(GLfloat[] v)
        {
            if (glRasterPos3fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glRasterPos3fv(ptr_v);
                }
            }
        }

        // GLproc (void, glRasterPos3i,	(GLint x, GLint y, GLint z))
        public static void RasterPos3i(GLint x, GLint y, GLint z)
        {
            if (glRasterPos3i != null)
            {
                glRasterPos3i(x, y, z);
            }
        }

        // GLproc (void, glRasterPos3iv,	(const GLint *v))
        public unsafe static void RasterPos3iv(GLint[] v)
        {
            if (glRasterPos3iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glRasterPos3iv(ptr_v);
                }
            }
        }

        // GLproc (void, glRasterPos3s,	(GLshort x, GLshort y, GLshort z))
        public static void RasterPos3s(GLshort x, GLshort y, GLshort z)
        {
            if (glRasterPos3s != null)
            {
                glRasterPos3s(x, y, z);
            }
        }

        // GLproc (void, glRasterPos3sv,	(const GLshort *v))
        public unsafe static void RasterPos3sv(GLshort[] v)
        {
            if (glRasterPos3sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glRasterPos3sv(ptr_v);
                }
            }
        }

        // GLproc (void, glRasterPos4d,	(GLdouble x, GLdouble y, GLdouble z, GLdouble w))
        public static void RasterPos4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glRasterPos4d != null)
            {
                glRasterPos4d(x, y, z, w);
            }
        }

        // GLproc (void, glRasterPos4dv,	(const GLdouble *v))
        public unsafe static void RasterPos4dv(GLdouble[] v)
        {
            if (glRasterPos4dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glRasterPos4dv(ptr_v);
                }
            }
        }

        // GLproc (void, glRasterPos4f,	(GLfloat x, GLfloat y, GLfloat z, GLfloat w))
        public static void RasterPos4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glRasterPos4f != null)
            {
                glRasterPos4f(x, y, z, w);
            }
        }

        // GLproc (void, glRasterPos4fv,	(const GLfloat *v))
        public unsafe static void RasterPos4fv(GLfloat[] v)
        {
            if (glRasterPos4fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glRasterPos4fv(ptr_v);
                }
            }
        }

        // GLproc (void, glRasterPos4i,	(GLint x, GLint y, GLint z, GLint w))
        public static void RasterPos4i(GLint x, GLint y, GLint z, GLint w)
        {
            if (glRasterPos4i != null)
            {
                glRasterPos4i(x, y, z, w);
            }
        }

        // GLproc (void, glRasterPos4iv,	(const GLint *v))
        public unsafe static void RasterPos4iv(GLint[] v)
        {
            if (glRasterPos4iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glRasterPos4iv(ptr_v);
                }
            }
        }

        // GLproc (void, glRasterPos4s,	(GLshort x, GLshort y, GLshort z, GLshort w))
        public static void RasterPos4s(GLshort x, GLshort y, GLshort z, GLshort w)
        {
            if (glRasterPos4s != null)
            {
                glRasterPos4s(x, y, z, w);
            }
        }

        // GLproc (void, glRasterPos4sv,	(const GLshort *v))
        public unsafe static void RasterPos4sv(GLshort[] v)
        {
            if (glRasterPos4sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glRasterPos4sv(ptr_v);
                }
            }
        }

        // GLproc (void, glReadBuffer,		(GLenum mode))
        public static void ReadBuffer(GLenum mode)
        {
            if (glReadBuffer != null)
            {
                glReadBuffer(mode);
            }
        }

        // GLproc (void, glReadPixels,		(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid *pixels))
        public unsafe static void ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glReadPixels != null)
            {
                glReadPixels(x, y, width, height, format, type, pixels.ToPointer());
            }
        }

        // GLproc (void, glRectd,			(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2))
        public static void Rectd(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2)
        {
            if (glRectd != null)
            {
                glRectd(x1, y1, x2, y2);
            }
        }

        // GLproc (void, glRectdv,			(const GLdouble *v1, const GLdouble *v2))
        public unsafe static void Rectdv(GLdouble[] v1, GLdouble[] v2)
        {
            if (glRectdv != null)
            {
                fixed (GLdouble* ptr_v1 = v1)
                {
                    fixed (GLdouble* ptr_v2 = v2)
                    {
                        glRectdv(ptr_v1, ptr_v2);
                    }
                }
            }
        }

        // GLproc (void, glRectf,			(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2))
        public static void Rectf(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2)
        {
            if (glRectf != null)
            {
                glRectf(x1, y1, x2, y2);
            }
        }

        // GLproc (void, glRectfv,			(const GLfloat *v1, const GLfloat *v2))
        public unsafe static void Rectfv(GLfloat[] v1, GLfloat[] v2)
        {
            if (glRectfv != null)
            {
                fixed (GLfloat* ptr_v1 = v1)
                {
                    fixed (GLfloat* ptr_v2 = v2)
                    {
                        glRectfv(ptr_v1, ptr_v2);
                    }
                }
            }
        }

        // GLproc (void, glRecti,			(GLint x1, GLint y1, GLint x2, GLint y2))
        public static void Recti(GLint x1, GLint y1, GLint x2, GLint y2)
        {
            if (glRecti != null)
            {
                glRecti(x1, y1, x2, y2);
            }
        }

        // GLproc (void, glRectiv,			(const GLint *v1, const GLint *v2))
        public unsafe static void Rectiv(GLint[] v1, GLint[] v2)
        {
            if (glRectiv != null)
            {
                fixed (GLint* ptr_v1 = v1)
                {
                    fixed (GLint* ptr_v2 = v2)
                    {
                        glRectiv(ptr_v1, ptr_v2);
                    }
                }
            }
        }

        // GLproc (void, glRects,			(GLshort x1, GLshort y1, GLshort x2, GLshort y2))
        public static void Rects(GLshort x1, GLshort y1, GLshort x2, GLshort y2)
        {
            if (glRects != null)
            {
                glRects(x1, y1, x2, y2);
            }
        }

        // GLproc (void, glRectsv,			(const GLshort *v1, const GLshort *v2))
        public unsafe static void Rectsv(GLshort[] v1, GLshort[] v2)
        {
            if (glRectsv != null)
            {
                fixed (GLshort* ptr_v1 = v1)
                {
                    fixed (GLshort* ptr_v2 = v2)
                    {
                        glRectsv(ptr_v1, ptr_v2);
                    }
                }
            }
        }

        // GLproc (GLint, glRenderMode,	(GLenum mode))
        public static void RenderMode(GLenum mode)
        {
            if (glRenderMode != null)
            {
                glRenderMode(mode);
            }
        }

        // GLproc (void, glRotated,		(GLdouble angle, GLdouble x, GLdouble y, GLdouble z))
        public static void Rotated(GLdouble angle, GLdouble x, GLdouble y, GLdouble z)
        {
            if (glRotated != null)
            {
                glRotated(angle, x, y, z);
            }
        }

        // GLproc (void, glRotatef,		(GLfloat angle, GLfloat x, GLfloat y, GLfloat z))
        public static void Rotatef(GLfloat angle, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glRotatef != null)
            {
                glRotatef(angle, x, y, z);
            }
        }

        // GLproc (void, glScaled,			(GLdouble x, GLdouble y, GLdouble z))
        public static void Scaled(GLdouble x, GLdouble y, GLdouble z)
        {
            if (glScaled != null)
            {
                glScaled(x, y, z);
            }
        }

        // GLproc (void, glScalef,			(GLfloat x, GLfloat y, GLfloat z))
        public static void Scalef(GLfloat x, GLfloat y, GLfloat z)
        {
            if (glScalef != null)
            {
                glScalef(x, y, z);
            }
        }

        // GLproc (void, glScissor,		(GLint x, GLint y, GLsizei width, GLsizei height))
        public static void Scissor(GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glScissor != null)
            {
                glScissor(x, y, width, height);
            }
        }

        // GLproc (void, glSelectBuffer,	(GLsizei size, GLuint *buffer))
        public unsafe static void SelectBuffer(GLsizei size, GLuint[] buffer)
        {
            if (glSelectBuffer != null)
            {
                fixed (GLuint* ptr_buffer = buffer)
                {
                    glSelectBuffer(size, ptr_buffer);
                }
            }
        }

        // GLproc (void, glShadeModel,		(GLenum mode))
        public static void ShadeModel(GLenum mode)
        {
            if (glShadeModel != null)
            {
                glShadeModel(mode);
            }
        }

        // GLproc (void, glStencilFunc,	(GLenum func, GLint ref, GLuint mask))
        public static void StencilFunc(GLenum func, GLint reference, GLuint mask)
        {
            if (glStencilFunc != null)
            {
                glStencilFunc(func, reference, mask);
            }
        }

        // GLproc (void, glStencilMask,	(GLuint mask))
        public static void StencilMask(GLuint mask)
        {
            if (glStencilMask != null)
            {
                glStencilMask(mask);
            }
        }

        // GLproc (void, glStencilOp,		(GLenum fail, GLenum zfail, GLenum zpass))
        public static void StencilOp(GLenum fail, GLenum zfail, GLenum zpass)
        {
            if (glStencilOp != null)
            {
                glStencilOp(fail, zfail, zpass);
            }
        }

        // GLproc (void, glTexCoord1d,		(GLdouble s))
        public static void TexCoord1d(GLdouble s)
        {
            if (glTexCoord1d != null)
            {
                glTexCoord1d(s);
            }
        }

        // GLproc (void, glTexCoord1dv,	(const GLdouble *v))
        public unsafe static void TexCoord1dv(GLdouble[] v)
        {
            if (glTexCoord1dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glTexCoord1dv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord1f,		(GLfloat s))
        public static void TexCoord1f(GLfloat s)
        {
            if (glTexCoord1f != null)
            {
                glTexCoord1f(s);
            }
        }

        // GLproc (void, glTexCoord1fv,	(const GLfloat *v))
        public unsafe static void TexCoord1fv(GLfloat[] v)
        {
            if (glTexCoord1fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glTexCoord1fv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord1i,		(GLint s))
        public static void TexCoord1i(GLint s)
        {
            if (glTexCoord1i != null)
            {
                glTexCoord1i(s);
            }
        }

        // GLproc (void, glTexCoord1iv,	(const GLint *v))
        public unsafe static void TexCoord1iv(GLint[] v)
        {
            if (glTexCoord1iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glTexCoord1iv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord1s,		(GLshort s))
        public static void TexCoord1s(GLshort s)
        {
            if (glTexCoord1s != null)
            {
                glTexCoord1s(s);
            }
        }

        // GLproc (void, glTexCoord1sv,	(const GLshort *v))
        public unsafe static void TexCoord1sv(GLshort[] v)
        {
            if (glTexCoord1sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glTexCoord1sv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord2d,		(GLdouble s, GLdouble t))
        public static void TexCoord2d(GLdouble s, GLdouble t)
        {
            if (glTexCoord2d != null)
            {
                glTexCoord2d(s, t);
            }
        }

        // GLproc (void, glTexCoord2dv,	(const GLdouble *v))
        public unsafe static void TexCoord2dv(GLdouble[] v)
        {
            if (glTexCoord2dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glTexCoord2dv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord2f,		(GLfloat s, GLfloat t))
        public static void TexCoord2f(GLfloat s, GLfloat t)
        {
            if (glTexCoord2f != null)
            {
                glTexCoord2f(s, t);
            }
        }

        // GLproc (void, glTexCoord2fv,	(const GLfloat *v))
        public unsafe static void TexCoord2fv(GLfloat[] v)
        {
            if (glTexCoord2fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glTexCoord2fv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord2i,		(GLint s, GLint t))
        public static void TexCoord2i(GLint s, GLint t)
        {
            if (glTexCoord2i != null)
            {
                glTexCoord2i(s, t);
            }
        }

        // GLproc (void, glTexCoord2iv,	(const GLint *v))
        public unsafe static void TexCoord2iv(GLint[] v)
        {
            if (glTexCoord2iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glTexCoord2iv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord2s,		(GLshort s, GLshort t))
        public static void TexCoord2s(GLshort s, GLshort t)
        {
            if (glTexCoord2s != null)
            {
                glTexCoord2s(s, t);
            }
        }

        // GLproc (void, glTexCoord2sv,	(const GLshort *v))
        public unsafe static void TexCoord2sv(GLshort[] v)
        {
            if (glTexCoord2sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glTexCoord2sv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord3d,		(GLdouble s, GLdouble t, GLdouble r))
        public static void TexCoord3d(GLdouble s, GLdouble t, GLdouble r)
        {
            if (glTexCoord3d != null)
            {
                glTexCoord3d(s, t, r);
            }
        }

        // GLproc (void, glTexCoord3dv,	(const GLdouble *v))
        public unsafe static void TexCoord3dv(GLdouble[] v)
        {
            if (glTexCoord3dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glTexCoord3dv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord3f,		(GLfloat s, GLfloat t, GLfloat r))
        public static void TexCoord3f(GLfloat s, GLfloat t, GLfloat r)
        {
            if (glTexCoord3f != null)
            {
                glTexCoord3f(s, t, r);
            }
        }

        // GLproc (void, glTexCoord3fv,	(const GLfloat *v))
        public unsafe static void TexCoord3fv(GLfloat[] v)
        {
            if (glTexCoord3fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glTexCoord3fv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord3i,		(GLint s, GLint t, GLint r))
        public static void TexCoord3i(GLint s, GLint t, GLint r)
        {
            if (glTexCoord3i != null)
            {
                glTexCoord3i(s, t, r);
            }
        }

        // GLproc (void, glTexCoord3iv,	(const GLint *v))
        public unsafe static void TexCoord3iv(GLint[] v)
        {
            if (glTexCoord3iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glTexCoord3iv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord3s,		(GLshort s, GLshort t, GLshort r))
        public static void TexCoord3s(GLshort s, GLshort t, GLshort r)
        {
            if (glTexCoord3s != null)
            {
                glTexCoord3s(s, t, r);
            }
        }

        // GLproc (void, glTexCoord3sv,	(const GLshort *v))
        public unsafe static void TexCoord3sv(GLshort[] v)
        {
            if (glTexCoord3sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glTexCoord3sv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord4d,		(GLdouble s, GLdouble t, GLdouble r, GLdouble q))
        public static void TexCoord4d(GLdouble s, GLdouble t, GLdouble r, GLdouble q)
        {
            if (glTexCoord4d != null)
            {
                glTexCoord4d(s, t, r, q);
            }
        }

        // GLproc (void, glTexCoord4dv,	(const GLdouble *v))
        public unsafe static void TexCoord4dv(GLdouble[] v)
        {
            if (glTexCoord4dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glTexCoord4dv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord4f,		(GLfloat s, GLfloat t, GLfloat r, GLfloat q))
        public static void TexCoord4f(GLfloat s, GLfloat t, GLfloat r, GLfloat q)
        {
            if (glTexCoord4f != null)
            {
                glTexCoord4f(s, t, r, q);
            }
        }

        // GLproc (void, glTexCoord4fv,	(const GLfloat *v))
        public unsafe static void TexCoord4fv(GLfloat[] v)
        {
            if (glTexCoord4fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glTexCoord4fv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord4i,		(GLint s, GLint t, GLint r, GLint q))
        public static void TexCoord4i(GLint s, GLint t, GLint r, GLint q)
        {
            if (glTexCoord4i != null)
            {
                glTexCoord4i(s, t, r, q);
            }
        }

        // GLproc (void, glTexCoord4iv,	(const GLint *v))
        public unsafe static void TexCoord4iv(GLint[] v)
        {
            if (glTexCoord4iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glTexCoord4iv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoord4s,		(GLshort s, GLshort t, GLshort r, GLshort q))
        public static void TexCoord4s(GLshort s, GLshort t, GLshort r, GLshort q)
        {
            if (glTexCoord4s != null)
            {
                glTexCoord4s(s, t, r, q);
            }
        }

        // GLproc (void, glTexCoord4sv,	(const GLshort *v))
        public unsafe static void TexCoord4sv(GLshort[] v)
        {
            if (glTexCoord4sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glTexCoord4sv(ptr_v);
                }
            }
        }

        // GLproc (void, glTexCoordPointer, (GLint size, GLenum type, GLsizei stride, const GLvoid *pointer))
        public unsafe static void TexCoordPointer(GLint size, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glTexCoordPointer != null)
            {
                glTexCoordPointer(size, type, stride, pointer.ToPointer());
            }
        }

        // GLproc (void, glTexEnvf,		(GLenum target, GLenum pname, GLfloat param))
        public static void TexEnvf(GLenum target, GLenum pname, GLfloat param)
        {
            if (glTexEnvf != null)
            {
                glTexEnvf(target, pname, param);
            }
        }

        // GLproc (void, glTexEnvfv,		(GLenum target, GLenum pname, const GLfloat *params))
        public unsafe static void TexEnvfv(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glTexEnvfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glTexEnvfv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glTexEnvi,		(GLenum target, GLenum pname, GLint param))
        public static void TexEnvi(GLenum target, GLenum pname, GLint param)
        {
            if (glTexEnvi != null)
            {
                glTexEnvi(target, pname, param);
            }
        }

        // GLproc (void, glTexEnviv,		(GLenum target, GLenum pname, const GLint *params))
        public unsafe static void TexEnviv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glTexEnviv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glTexEnviv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glTexGend,		(GLenum coord, GLenum pname, GLdouble param))
        public static void TexGend(GLenum coord, GLenum pname, GLdouble param)
        {
            if (glTexGend != null)
            {
                glTexGend(coord, pname, param);
            }
        }

        // GLproc (void, glTexGendv,		(GLenum coord, GLenum pname, const GLdouble *params))
        public unsafe static void TexGendv(GLenum coord, GLenum pname, GLdouble[] parameters)
        {
            if (glTexGendv != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glTexGendv(coord, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glTexGenf,		(GLenum coord, GLenum pname, GLfloat param))
        public static void TexGenf(GLenum coord, GLenum pname, GLfloat param)
        {
            if (glTexGenf != null)
            {
                glTexGenf(coord, pname, param);
            }
        }

        // GLproc (void, glTexGenfv,		(GLenum coord, GLenum pname, const GLfloat *params))
        public unsafe static void TexGenfv(GLenum coord, GLenum pname, GLfloat[] parameters)
        {
            if (glTexGenfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glTexGenfv(coord, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glTexGeni,		(GLenum coord, GLenum pname, GLint param))
        public static void TexGeni(GLenum coord, GLenum pname, GLint param)
        {
            if (glTexGeni != null)
            {
                glTexGeni(coord, pname, param);
            }
        }

        // GLproc (void, glTexGeniv,		(GLenum coord, GLenum pname, const GLint *params))
        public unsafe static void TexGeniv(GLenum coord, GLenum pname, GLint[] parameters)
        {
            if (glTexGeniv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glTexGeniv(coord, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glTexImage1D,		(GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, const GLvoid *pixels))
        public unsafe static void TexImage1D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLint border, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTexImage1D != null)
            {
                glTexImage1D(target, level, internalformat, width, border, format, type, pixels.ToPointer());
            }
        }

        // GLproc (void, glTexImage2D,		(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, const GLvoid *pixels))
        public unsafe static void TexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTexImage2D != null)
            {
                glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels.ToPointer());
            }
        }

        // GLproc (void, glTexParameterf,	(GLenum target, GLenum pname, GLfloat param))
        public static void TexParameterf(GLenum target, GLenum pname, GLfloat param)
        {
            if (glTexParameterf != null)
            {
                glTexParameterf(target, pname, param);
            }
        }

        // GLproc (void, glTexParameterfv, (GLenum target, GLenum pname, const GLfloat *params))
        public unsafe static void TexParameterfv(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glTexParameterfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glTexParameterfv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glTexParameteri,	(GLenum target, GLenum pname, GLint param))
        public static void TexParameteri(GLenum target, GLenum pname, GLint param)
        {
            if (glTexParameteri != null)
            {
                glTexParameteri(target, pname, param);
            }
        }

        // GLproc (void, glTexParameteriv, (GLenum target, GLenum pname, const GLint *params))
        public unsafe static void TexParameteriv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glTexParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glTexParameteriv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glTexSubImage1D,	(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, const GLvoid *pixels))
        public unsafe static void TexSubImage1D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTexSubImage1D != null)
            {
                glTexSubImage1D(target, level, xoffset, width, format, type, pixels.ToPointer());
            }
        }

        // GLproc (void, glTexSubImage2D,	(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *pixels))
        public unsafe static void TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTexSubImage2D != null)
            {
                glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels.ToPointer());
            }
        }

        // GLproc (void, glTranslated,		(GLdouble x, GLdouble y, GLdouble z))
        public static void Translated(GLdouble x, GLdouble y, GLdouble z)
        {
            if (glTranslated != null)
            {
                glTranslated(x, y, z);
            }
        }

        // GLproc (void, glTranslatef,		(GLfloat x, GLfloat y, GLfloat z))
        public static void Translatef(GLfloat x, GLfloat y, GLfloat z)
        {
            if (glTranslatef != null)
            {
                glTranslatef(x, y, z);
            }
        }

        // GLproc (void, glVertex2d,		(GLdouble x, GLdouble y))
        public static void Vertex2d(GLdouble x, GLdouble y)
        {
            if (glVertex2d != null)
            {
                glVertex2d(x, y);
            }
        }

        // GLproc (void, glVertex2dv,		(const GLdouble *v))
        public unsafe static void Vertex2dv(GLdouble[] v)
        {
            if (glVertex2dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertex2dv(ptr_v);
                }
            }
        }

        // GLproc (void, glVertex2f,		(GLfloat x, GLfloat y))
        public static void Vertex2f(GLfloat x, GLfloat y)
        {
            if (glVertex2f != null)
            {
                glVertex2f(x, y);
            }
        }

        // GLproc (void, glVertex2fv,		(const GLfloat *v))
        public unsafe static void Vertex2fv(GLfloat[] v)
        {
            if (glVertex2fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertex2fv(ptr_v);
                }
            }
        }

        // GLproc (void, glVertex2i,		(GLint x, GLint y))
        public static void Vertex2i(GLint x, GLint y)
        {
            if (glVertex2i != null)
            {
                glVertex2i(x, y);
            }
        }

        // GLproc (void, glVertex2iv,		(const GLint *v))
        public unsafe static void Vertex2iv(GLint[] v)
        {
            if (glVertex2iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertex2iv(ptr_v);
                }
            }
        }

        // GLproc (void, glVertex2s,		(GLshort x, GLshort y))
        public static void Vertex2s(GLshort x, GLshort y)
        {
            if (glVertex2s != null)
            {
                glVertex2s(x, y);
            }
        }

        // GLproc (void, glVertex2sv,		(const GLshort *v))
        public unsafe static void Vertex2sv(GLshort[] v)
        {
            if (glVertex2sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertex2sv(ptr_v);
                }
            }
        }

        // GLproc (void, glVertex3d,		(GLdouble x, GLdouble y, GLdouble z))
        public static void Vertex3d(GLdouble x, GLdouble y, GLdouble z)
        {
            if (glVertex3d != null)
            {
                glVertex3d(x, y, z);
            }
        }

        // GLproc (void, glVertex3dv,		(const GLdouble *v))
        public unsafe static void Vertex3dv(GLdouble[] v)
        {
            if (glVertex3dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertex3dv(ptr_v);
                }
            }
        }

        // GLproc (void, glVertex3f,		(GLfloat x, GLfloat y, GLfloat z))
        public static void Vertex3f(GLfloat x, GLfloat y, GLfloat z)
        {
            if (glVertex3f != null)
            {
                glVertex3f(x, y, z);
            }
        }

        // GLproc (void, glVertex3fv,		(const GLfloat *v))
        public unsafe static void Vertex3fv(GLfloat[] v)
        {
            if (glVertex3fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertex3fv(ptr_v);
                }
            }
        }

        // GLproc (void, glVertex3i,		(GLint x, GLint y, GLint z))
        public static void Vertex3i(GLint x, GLint y, GLint z)
        {
            if (glVertex3i != null)
            {
                glVertex3i(x, y, z);
            }
        }

        // GLproc (void, glVertex3iv,		(const GLint *v))
        public unsafe static void Vertex3iv(GLint[] v)
        {
            if (glVertex3iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertex3iv(ptr_v);
                }
            }
        }

        // GLproc (void, glVertex3s,		(GLshort x, GLshort y, GLshort z))
        public static void Vertex3s(GLshort x, GLshort y, GLshort z)
        {
            if (glVertex3s != null)
            {
                glVertex3s(x, y, z);
            }
        }

        // GLproc (void, glVertex3sv,		(const GLshort *v))
        public unsafe static void Vertex3sv(GLshort[] v)
        {
            if (glVertex3sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertex3sv(ptr_v);
                }
            }
        }

        // GLproc (void, glVertex4d,		(GLdouble x, GLdouble y, GLdouble z, GLdouble w))
        public static void Vertex4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glVertex4d != null)
            {
                glVertex4d(x, y, z, w);
            }
        }

        // GLproc (void, glVertex4dv,		(const GLdouble *v))
        public unsafe static void Vertex4dv(GLdouble[] v)
        {
            if (glVertex4dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertex4dv(ptr_v);
                }
            }
        }

        // GLproc (void, glVertex4f,		(GLfloat x, GLfloat y, GLfloat z, GLfloat w))
        public static void Vertex4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glVertex4f != null)
            {
                glVertex4f(x, y, z, w);
            }
        }

        // GLproc (void, glVertex4fv,		(const GLfloat *v))
        public unsafe static void Vertex4fv(GLfloat[] v)
        {
            if (glVertex4fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertex4fv(ptr_v);
                }
            }
        }

        // GLproc (void, glVertex4i,		(GLint x, GLint y, GLint z, GLint w))
        public static void Vertex4i(GLint x, GLint y, GLint z, GLint w)
        {
            if (glVertex4i != null)
            {
                glVertex4i(x, y, z, w);
            }
        }

        // GLproc (void, glVertex4iv,		(const GLint *v))
        public unsafe static void Vertex4iv(GLint[] v)
        {
            if (glVertex4iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertex4iv(ptr_v);
                }
            }
        }

        // GLproc (void, glVertex4s,		(GLshort x, GLshort y, GLshort z, GLshort w))
        public static void Vertex4s(GLshort x, GLshort y, GLshort z, GLshort w)
        {
            if (glVertex4s != null)
            {
                glVertex4s(x, y, z, w);
            }
        }

        // GLproc (void, glVertex4sv,		(const GLshort *v))
        public unsafe static void Vertex4sv(GLshort[] v)
        {
            if (glVertex4sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertex4sv(ptr_v);
                }
            }
        }

        // GLproc (void, glVertexPointer,	(GLint size, GLenum type, GLsizei stride, const GLvoid *pointer))
        public unsafe static void VertexPointer(GLint size, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glVertexPointer != null)
            {
                glVertexPointer(size, type, stride, pointer.ToPointer());
            }
        }

        // GLproc (void, glViewport,		(GLint x, GLint y, GLsizei width, GLsizei height))
        public static void Viewport(GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glViewport != null)
            {
                glViewport(x, y, width, height);
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v1.2 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v1.2 WRAPPERS...
        // --- GL_draw_range_elements
        // GLproc (void, glDrawRangeElements,	(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, const GLvoid *indices))
        public unsafe static void DrawRangeElements(GLenum mode, GLuint start, GLint end, GLsizei count, GLenum type, IntPtr indices)
        {
            if (glDrawRangeElements != null)
            {
                glDrawRangeElements(mode, start, end, count, type, indices.ToPointer());
            }
        }

        // --- GL_texture3D
        // GLproc (void, glTexImage3D,			(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, const GLvoid *pixels))
        public unsafe static void TexImage3D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei depth, GLint border, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTexImage3D != null)
            {
                glTexImage3D(target, level, internalformat, width, depth, border, format, type, pixels.ToPointer());
            }
        }

        // GLproc (void, glTexSubImage3D,		(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const GLvoid *pixels))
        public unsafe static void TexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTexSubImage3D != null)
            {
                glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels.ToPointer());
            }
        }

        // GLproc (void, glCopyTexSubImage3D,	(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height))
        public static void CopyTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glCopyTexSubImage3D != null)
            {
                glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v1.2: GL_ARB_imaging WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v1.2: GL_ARB_imaging WRAPPERS...
        // --- GL_blend_color
        // GLproc (void, glBlendColor,		(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha))
        public static void BlendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha)
        {
            if (glBlendColor != null)
            {
                glBlendColor(red, green, blue, alpha);
            }
        }

        // --- GL_blend_minmax
        // GLproc (void, glBlendEquation,	(GLenum mode))
        public static void BlendEquation(GLenum mode)
        {
            if (glBlendEquation != null)
            {
                glBlendEquation(mode);
            }
        }

        // --- GL_color_subtable
        // GLproc (void, glColorSubTable,	(GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, const GLvoid *data))
        public unsafe static void ColorSubTable(GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, IntPtr data)
        {
            if (glColorSubTable != null)
            {
                glColorSubTable(target, start, count, format, type, data.ToPointer());
            }
        }

        // GLproc (void, glCopyColorSubTable, (GLenum target, GLsizei start, GLint x, GLint y, GLsizei width))
        public static void CopyColorSubTable(GLenum target, GLsizei start, GLint x, GLint y, GLsizei width)
        {
            if (glCopyColorSubTable != null)
            {
                glCopyColorSubTable(target, start, x, y, width);
            }
        }

        // --- GL_color_table
        // GLproc (void, glColorTable,		(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, const GLvoid *table))
        public unsafe static void ColorTable(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, IntPtr table)
        {
            if (glColorTable != null)
            {
                glColorTable(target, internalformat, width, format, type, table.ToPointer());
            }
        }

        // GLproc (void, glCopyColorTable, (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width))
        public static void CopyColorTable(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width)
        {
            if (glCopyColorTable != null)
            {
                glCopyColorTable(target, internalformat, x, y, width);
            }
        }

        // GLproc (void, glColorTableParameteriv, (GLenum target, GLenum pname, const GLint *params))
        public unsafe static void ColorTableParameteriv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glColorTableParameteriv != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glColorTableParameteriv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glColorTableParameterfv, (GLenum target, GLenum pname, const GLfloat *params))
        public unsafe static void ColorTableParameterfv(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glColorTableParameterfv != null)
            {
                fixed(GLfloat* ptr_parameters = parameters)
                {
                    glColorTableParameterfv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetColorTable,	(GLenum target, GLenum format, GLenum type, GLvoid *table))
        public unsafe static void GetColorTable(GLenum target, GLenum format, GLenum type, IntPtr table)
        {
            if (glGetColorTable != null)
            {
                glGetColorTable(target, format, type, table.ToPointer());
            }
        }

        // GLproc (void, glGetColorTableParameteriv, (GLenum target, GLenum pname, GLint *params))
        public unsafe static void GetColorTableParameteriv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetColorTableParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetColorTableParameteriv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetColorTableParameterfv, (GLenum target, GLenum pname, GLfloat *params))
        public unsafe static void GetColorTableParameterfv(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetColorTableParameterfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetColorTableParameterfv(target, pname, ptr_parameters);
                }
            }
        }

        // --- GL_convolution
        // GLproc (void, glConvolutionFilter1D, (GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, const GLvoid *image))
        public unsafe static void ConvolutionFilter1D(GLenum target, GLenum internalformat, GLsizei width, GLenum format, GLenum type, IntPtr image)
        {
            if (glConvolutionFilter1D != null)
            {
                glConvolutionFilter1D(target, internalformat, width, format, type, image.ToPointer());
            }
        }

        // GLproc (void, glConvolutionFilter2D, (GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *image))
        public unsafe static void ConvolutionFilter2D(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, IntPtr image)
        {
            if (glConvolutionFilter2D != null)
            {
                glConvolutionFilter2D(target, internalformat, width, height, format, type, image.ToPointer());
            }
        }

        // GLproc (void, glCopyConvolutionFilter1D, (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width))
        public static void CopyConvolutionFilter1D(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width)
        {
            if (glCopyConvolutionFilter1D != null)
            {
                glCopyConvolutionFilter1D(target, internalformat, x, y, width);
            }
        }

        // GLproc (void, glCopyConvolutionFilter2D, (GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height))
        public static void CopyConvolutionFilter2D(GLenum target, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glCopyConvolutionFilter2D != null)
            {
                glCopyConvolutionFilter2D(target, internalformat, x, y, width, height);
            }
        }

        // GLproc (void, glGetConvolutionFilter, (GLenum target, GLenum format, GLenum type, GLvoid *image))
        public unsafe static void GetConvolutionFilter(GLenum target, GLenum format, GLenum type, IntPtr image)
        {
            if (glGetConvolutionFilter != null)
            {
                glGetConvolutionFilter(target, format, type, image.ToPointer());
            }
        }

        // GLproc (void, glSeparableFilter2D, (GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, const GLvoid *row, const GLvoid *column))
        public unsafe static void SeparableFilter2D(GLenum target, GLenum internalformat, GLsizei width, GLsizei height, GLenum format, GLenum type, IntPtr row, IntPtr column)
        {
            if (glSeparableFilter2D != null)
            {
                glSeparableFilter2D(target, internalformat, width, height, format, type, row.ToPointer(), column.ToPointer());
            }
        }

        // GLproc (void, glGetSeparableFilter, (GLenum target, GLenum format, GLenum type, GLvoid *row, GLvoid *column, GLvoid *span))
        public unsafe static void GetSeparableFilter(GLenum target, GLenum format, GLenum type, IntPtr row, IntPtr column, IntPtr span)
        {
            if (glGetSeparableFilter != null)
            {
                glGetSeparableFilter(target, format, type, row.ToPointer(), column.ToPointer(), span.ToPointer());
            }
        }

        // GLproc (void, glConvolutionParameteri, (GLenum target, GLenum pname, GLint params))
        public static void ConvolutionParameteri(GLenum target, GLenum pname, GLint parameters)
        {
            if (glConvolutionParameteri != null)
            {
                glConvolutionParameteri(target, pname, parameters);
            }
        }

        // GLproc (void, glConvolutionParameteriv, (GLenum target, GLenum pname, const GLint *params))
        public unsafe static void ConvolutionParameteriv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glConvolutionParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glConvolutionParameteriv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glConvolutionParameterf, (GLenum target, GLenum pname, GLfloat params))
        public static void ConvolutionParameterf(GLenum target, GLenum pname, GLfloat parameters)
        {
            if (glConvolutionParameterf != null)
            {
                glConvolutionParameterf(target, pname, parameters);
            }
        }

        // GLproc (void, glConvolutionParameterfv, (GLenum target, GLenum pname, const GLfloat *params))
        public unsafe static void ConvolutionParameterfv(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glConvolutionParameterfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glConvolutionParameterfv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetConvolutionParameteriv, (GLenum target, GLenum pname, GLint *params))
        public unsafe static void GetConvolutionParameteriv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetConvolutionParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetConvolutionParameteriv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetConvolutionParameterfv, (GLenum target, GLenum pname, GLfloat *params))
        public unsafe static void GetConvolutionParameterfv(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetConvolutionParameterfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetConvolutionParameterfv(target, pname, ptr_parameters);
                }
            }
        }

        // --- GL_histogram
        // GLproc (void, glHistogram,		(GLenum target, GLsizei width, GLenum internalformat, GLboolean sink))
        public static void Histogram(GLenum target, GLsizei width, GLenum internalformat, GLboolean sink)
        {
            if (glHistogram != null)
            {
                glHistogram(target, width, internalformat, sink);
            }
        }

        // GLproc (void, glResetHistogram, (GLenum target))
        public static void ResetHistogram(GLenum target)
        {
            if (glResetHistogram != null)
            {
                glResetHistogram(target);
            }
        }

        // GLproc (void, glGetHistogram,	(GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid *values))
        public unsafe static void GetHistogram(GLenum target, GLboolean reset, GLenum format, GLenum type, IntPtr values)
        {
            if (glGetHistogram != null)
            {
                glGetHistogram(target, reset, format, type, values.ToPointer());
            }
        }

        // GLproc (void, glGetHistogramParameteriv, (GLenum target, GLenum pname, GLint *params))
        public unsafe static void GetHistogramParameteriv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetHistogramParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetHistogramParameteriv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetHistogramParameterfv, (GLenum target, GLenum pname, GLfloat *params))
        public unsafe static void GetHistogramParameterfv(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetHistogramParameterfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetHistogramParameterfv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glMinmax,			(GLenum target, GLenum internalformat, GLboolean sink))
        public static void Minmax(GLenum target, GLenum internalformat, GLboolean sink)
        {
            if (glMinmax != null)
            {
                glMinmax(target, internalformat, sink);
            }
        }

        // GLproc (void, glResetMinmax,	(GLenum target))
        public static void ResetMinmax(GLenum target)
        {
            if (glResetMinmax != null)
            {
                glResetMinmax(target);
            }
        }

        // GLproc (void, glGetMinmax,		(GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid *values))
        public unsafe static void GetMinmax(GLenum target, GLboolean reset, GLenum format, GLenum type, IntPtr values)
        {
            if (glGetMinmax != null)
            {
                glGetMinmax(target, reset, format, type, values.ToPointer());
            }
        }

        // GLproc (void, glGetMinmaxParameteriv, (GLenum target, GLenum pname, GLint *params))
        public unsafe static void GetMinmaxParameteriv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetMinmaxParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetMinmaxParameteriv(target, pname, ptr_parameters);
                }
            }
        }

        // GLproc (void, glGetMinmaxParameterfv, (GLenum target, GLenum pname, GLfloat *params))
        public unsafe static void GetMinmaxParameterfv(GLenum target, GLenum pname, GLfloat[] parameters)
        {
            if (glGetMinmaxParameterfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetMinmaxParameterfv(target, pname, ptr_parameters);
                }
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v1.3 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v1.3 WRAPPERS...
        // GLAPI void GLAPIENTRY glActiveTexture( GLenum texture )
        public static void ActiveTexture(GLenum texture)
        {
            if (glActiveTexture != null)
            {
                glActiveTexture(texture);
            }
        }

        // GLAPI void GLAPIENTRY glClientActiveTexture( GLenum texture )
        public static void ClientActiveTexture(GLenum texture)
        {
            if (glClientActiveTexture != null)
            {
                glClientActiveTexture(texture);
            }
        }

        // GLAPI void GLAPIENTRY glCompressedTexImage1D( GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, const GLvoid *data )
        public unsafe static void CompressedTexImage1D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTexImage1D != null)
            {
                glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data.ToPointer());
            }
        }

        // GLAPI void GLAPIENTRY glCompressedTexImage2D( GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, const GLvoid *data )
        public unsafe static void CompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTexImage2D != null)
            {
                glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data.ToPointer());
            }
        }

        // GLAPI void GLAPIENTRY glCompressedTexImage3D( GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, const GLvoid *data )
        public unsafe static void CompressedTexImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTexImage3D != null)
            {
                glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data.ToPointer());
            }
        }

        // GLAPI void GLAPIENTRY glCompressedTexSubImage1D( GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, const GLvoid *data )
        public unsafe static void CompressedTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTexSubImage1D != null)
            {
                glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data.ToPointer());
            }
        }

        // GLAPI void GLAPIENTRY glCompressedTexSubImage2D( GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const GLvoid *data )
        public unsafe static void CompressedTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTexSubImage2D != null)
            {
                glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data.ToPointer());
            }
        }

        // GLAPI void GLAPIENTRY glCompressedTexSubImage3D( GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const GLvoid *data )
        public unsafe static void CompressedTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTexSubImage3D != null)
            {
                glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data.ToPointer());
            }
        }

        // GLAPI void GLAPIENTRY glGetCompressedTexImage( GLenum target, GLint lod, GLvoid *img )
        public unsafe static void GetCompressedTexImage(GLenum target, GLint lod, IntPtr img)
        {
            if (glGetCompressedTexImage != null)
            {
                glGetCompressedTexImage(target, lod, img.ToPointer());
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord1d( GLenum target, GLdouble s )
        public static void MultiTexCoord1d(GLenum target, GLdouble s)
        {
            if (glMultiTexCoord1d != null)
            {
                glMultiTexCoord1d(target, s);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord1dv( GLenum target, const GLdouble *v )
        public unsafe static void MultiTexCoord1dv(GLenum target, GLdouble[] v)
        {
            if (glMultiTexCoord1dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glMultiTexCoord1dv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord1f( GLenum target, GLfloat s )
        public static void MultiTexCoord1f(GLenum target, GLfloat s)
        {
            if (glMultiTexCoord1f != null)
            {
                glMultiTexCoord1f(target, s);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord1fv( GLenum target, const GLfloat *v )
        public unsafe static void MultiTexCoord1fv(GLenum target, GLfloat[] v)
        {
            if (glMultiTexCoord1fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glMultiTexCoord1fv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord1i( GLenum target, GLint s )
        public static void MultiTexCoord1i(GLenum target, GLint s)
        {
            if (glMultiTexCoord1i != null)
            {
                glMultiTexCoord1i(target, s);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord1iv( GLenum target, const GLint *v )
        public unsafe static void MultiTexCoord1iv(GLenum target, GLint[] v)
        {
            if (glMultiTexCoord1iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glMultiTexCoord1iv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord1s( GLenum target, GLshort s )
        public static void MultiTexCoord1s(GLenum target, GLshort s)
        {
            if (glMultiTexCoord1s != null)
            {
                glMultiTexCoord1s(target, s);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord1sv( GLenum target, const GLshort *v )
        public unsafe static void MultiTexCoord1sv(GLenum target, GLshort[] v)
        {
            if (glMultiTexCoord1sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glMultiTexCoord1sv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord2d( GLenum target, GLdouble s, GLdouble t )
        public static void MultiTexCoord2d(GLenum target, GLdouble s, GLdouble t)
        {
            if (glMultiTexCoord2d != null)
            {
                glMultiTexCoord2d(target, s, t);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord2dv( GLenum target, const GLdouble *v )
        public unsafe static void MultiTexCoord2dv(GLenum target, GLdouble[] v)
        {
            if (glMultiTexCoord2dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glMultiTexCoord2dv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord2f( GLenum target, GLfloat s, GLfloat t )
        public static void MultiTexCoord2f(GLenum target, GLfloat s, GLfloat t)
        {
            if (glMultiTexCoord2f != null)
            {
                glMultiTexCoord2f(target, s, t);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord2fv( GLenum target, const GLfloat *v )
        public unsafe static void MultiTexCoord2fv(GLenum target, GLfloat[] v)
        {
            if (glMultiTexCoord2fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glMultiTexCoord2fv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord2i( GLenum target, GLint s, GLint t )
        public static void MultiTexCoord2i(GLenum target, GLint s, GLint t)
        {
            if (glMultiTexCoord2i != null)
            {
                glMultiTexCoord2i(target, s, t);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord2iv( GLenum target, const GLint *v )
        public unsafe static void MultiTexCoord2iv(GLenum target, GLint[] v)
        {
            if (glMultiTexCoord2iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glMultiTexCoord2iv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord2s( GLenum target, GLshort s, GLshort t )
        public static void MultiTexCoord2s(GLenum target, GLshort s, GLshort t)
        {
            if (glMultiTexCoord2s != null)
            {
                glMultiTexCoord2s(target, s, t);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord2sv( GLenum target, const GLshort *v )
        public unsafe static void MultiTexCoord2sv(GLenum target, GLshort[] v)
        {
            if (glMultiTexCoord2sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glMultiTexCoord2sv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord3d( GLenum target, GLdouble s, GLdouble t, GLdouble r )
        public static void MultiTexCoord3d(GLenum target, GLdouble s, GLdouble t, GLdouble r)
        {
            if (glMultiTexCoord3d != null)
            {
                glMultiTexCoord3d(target, s, t, r);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord3dv( GLenum target, const GLdouble *v )
        public unsafe static void MultiTexCoord3dv(GLenum target, GLdouble[] v)
        {
            if (glMultiTexCoord3dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glMultiTexCoord3dv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord3f( GLenum target, GLfloat s, GLfloat t, GLfloat r )
        public static void MultiTexCoord3f(GLenum target, GLfloat s, GLfloat t, GLfloat r)
        {
            if (glMultiTexCoord3f != null)
            {
                glMultiTexCoord3f(target, s, t, r);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord3fv( GLenum target, const GLfloat *v )
        public unsafe static void MultiTexCoord3fv(GLenum target, GLfloat[] v)
        {
            if (glMultiTexCoord3fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glMultiTexCoord3fv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord3i( GLenum target, GLint s, GLint t, GLint r )
        public static void MultiTexCoord3i(GLenum target, GLint s, GLint t, GLint r)
        {
            if (glMultiTexCoord3i != null)
            {
                glMultiTexCoord3i(target, s, t, r);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord3iv( GLenum target, const GLint *v )
        public unsafe static void MultiTexCoord3iv(GLenum target, GLint[] v)
        {
            if (glMultiTexCoord3iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glMultiTexCoord3iv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord3s( GLenum target, GLshort s, GLshort t, GLshort r )
        public static void MultiTexCoord3s(GLenum target, GLshort s, GLshort t, GLshort r)
        {
            if (glMultiTexCoord3s != null)
            {
                glMultiTexCoord3s(target, s, t, r);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord3sv( GLenum target, const GLshort *v )
        public unsafe static void MultiTexCoord3sv(GLenum target, GLshort[] v)
        {
            if (glMultiTexCoord3sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glMultiTexCoord3sv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord4d( GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q )
        public static void MultiTexCoord4d(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q)
        {
            if (glMultiTexCoord4d != null)
            {
                glMultiTexCoord4d(target, s, t, r, q);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord4dv( GLenum target, const GLdouble *v )
        public unsafe static void MultiTexCoord4dv(GLenum target, GLdouble[] v)
        {
            if (glMultiTexCoord4dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glMultiTexCoord4dv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord4f( GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q )
        public static void MultiTexCoord4f(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q)
        {
            if (glMultiTexCoord4f != null)
            {
                glMultiTexCoord4f(target, s, t, r, q);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord4fv( GLenum target, const GLfloat *v )
        public unsafe static void MultiTexCoord4fv(GLenum target, GLfloat[] v)
        {
            if (glMultiTexCoord4fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glMultiTexCoord4fv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord4i( GLenum target, GLint s, GLint t, GLint r, GLint q )
        public static void MultiTexCoord4i(GLenum target, GLint s, GLint t, GLint r, GLint q)
        {
            if (glMultiTexCoord4i != null)
            {
                glMultiTexCoord4i(target, s, t, r, q);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord4iv( GLenum target, const GLint *v )
        public unsafe static void MultiTexCoord4iv(GLenum target, GLint[] v)
        {
            if (glMultiTexCoord4iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glMultiTexCoord4iv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord4s( GLenum target, GLshort s, GLshort t, GLshort r, GLshort q )
        public static void MultiTexCoord4s(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q)
        {
            if (glMultiTexCoord4s != null)
            {
                glMultiTexCoord4s(target, s, t, r, q);
            }
        }

        // GLAPI void GLAPIENTRY glMultiTexCoord4sv( GLenum target, const GLshort *v )
        public unsafe static void MultiTexCoord4sv(GLenum target, GLshort[] v)
        {
            if (glMultiTexCoord4sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glMultiTexCoord4sv(target, ptr_v);
                }
            }
        }

        // GLAPI void GLAPIENTRY glLoadTransposeMatrixd( const GLdouble *m )
        public unsafe static void LoadTransposeMatrixd(GLdouble[] m)
        {
            if (glLoadTransposeMatrixd != null)
            {
                fixed (GLdouble* ptr_m = m)
                {
                    glLoadTransposeMatrixd(ptr_m);
                }
            }
        }

        // GLAPI void GLAPIENTRY glLoadTransposeMatrixf( const GLfloat *m )
        public unsafe static void LoadTransposeMatrixf(GLfloat[] m)
        {
            if (glLoadTransposeMatrixf != null)
            {
                fixed (GLfloat* ptr_m = m)
                {
                    glLoadTransposeMatrixf(ptr_m);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultTransposeMatrixd( const GLdouble *m )
        public unsafe static void MultTransposeMatrixd(GLdouble[] m)
        {
            if (glMultTransposeMatrixd != null)
            {
                fixed (GLdouble* ptr_m = m)
                {
                    glMultTransposeMatrixd(ptr_m);
                }
            }
        }

        // GLAPI void GLAPIENTRY glMultTransposeMatrixf( const GLfloat *m )
        public unsafe static void MultTransposeMatrixf(GLfloat[] m)
        {
            if (glMultTransposeMatrixf != null)
            {
                fixed (GLfloat* ptr_m = m)
                {
                    glMultTransposeMatrixf(ptr_m);
                }
            }
        }

        // GLAPI void GLAPIENTRY glSampleCoverage( GLclampf value, GLboolean invert )
        public static void SampleCoverage(GLclampf value, GLboolean invert)
        {
            if (glSampleCoverage != null)
            {
                glSampleCoverage(value, invert);
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v1.4 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v1.4 WRAPPERS...
        // GLAPI void APIENTRY glBlendFuncSeparate (GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)
        public static void BlendFuncSeparate(GLenum sfactorRGB, GLenum dfactorRGB, GLenum sfactorAlpha, GLenum dfactorAlpha)
        {
            if (glBlendFuncSeparate != null)
            {
                glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
            }
        }

        // GLAPI void APIENTRY glMultiDrawArrays (GLenum mode, const GLint *first, const GLsizei *count, GLsizei primcount)
        public unsafe static void MultiDrawArrays(GLenum mode, GLint[] first, GLsizei[] count, GLsizei primcount)
        {
            if (glMultiDrawArrays != null)
            {
                fixed (GLint* ptr_first = first)
                {
                    fixed (GLsizei* ptr_count = count)
                    {
                        glMultiDrawArrays(mode, ptr_first, ptr_count, primcount);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glMultiDrawElements (GLenum mode, const GLsizei *count, GLenum type, const GLvoid* *indices, GLsizei primcount)
        public unsafe static void MultiDrawElements(GLenum mode, GLsizei[] count, GLenum type, IntPtr[] indices, GLsizei primcount)
        {
            if (glMultiDrawElements != null)
            {
                fixed (GLsizei* ptr_count = count)
                {
                    fixed (IntPtr* ptr_indices = indices)
                    {
                        glMultiDrawElements(mode, ptr_count, type, (void**)ptr_indices, primcount);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glPointParameterf (GLenum pname, GLfloat param)
        public static void PointParameterf(GLenum pname, GLfloat param)
        {
            if (glPointParameterf != null)
            {
                glPointParameterf(pname, param);
            }
        }

        // GLAPI void APIENTRY glPointParameterfv (GLenum pname, const GLfloat *params)
        public unsafe static void PointParameterfv(GLenum pname, GLfloat[] parameters)
        {
            if (glPointParameterfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glPointParameterfv(pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glPointParameteri (GLenum pname, GLint param)
        public static void PointParameteri(GLenum pname, GLint param)
        {
            if (glPointParameteri != null)
            {
                glPointParameteri(pname, param);
            }
        }

        // GLAPI void APIENTRY glPointParameteriv (GLenum pname, const GLint *params)
        public unsafe static void PointParameteriv(GLenum pname, GLint[] parameters)
        {
            if (glPointParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glPointParameteriv(pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glFogCoordf (GLfloat coord)
        public static void FogCoordf(GLfloat coord)
        {
            if (glFogCoordf != null)
            {
                glFogCoordf(coord);
            }
        }

        // GLAPI void APIENTRY glFogCoordfv (const GLfloat *coord)
        public unsafe static void FogCoordfv(GLfloat[] coord)
        {
            if (glFogCoordfv != null)
            {
                fixed (GLfloat* ptr_coord = coord)
                {
                    glFogCoordfv(ptr_coord);
                }
            }
        }

        // GLAPI void APIENTRY glFogCoordd (GLdouble coord)
        public static void FogCoordd(GLdouble coord)
        {
            if (glFogCoordd != null)
            {
                glFogCoordd(coord);
            }
        }

        // GLAPI void APIENTRY glFogCoorddv (const GLdouble *coord)
        public unsafe static void FogCoorddv(GLdouble[] coord)
        {
            if (glFogCoorddv != null)
            {
                fixed(GLdouble* ptr_coord = coord)
                {
                    glFogCoorddv(ptr_coord);
                }
            }
        }

        // GLAPI void APIENTRY glFogCoordPointer (GLenum type, GLsizei stride, const GLvoid *pointer)
        public unsafe static void FogCoordPointer(GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glFogCoordPointer != null)
            {
                glFogCoordPointer(type, stride, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3b (GLbyte red, GLbyte green, GLbyte blue)
        public static void SecondaryColor3b(GLbyte red, GLbyte green, GLbyte blue)
        {
            if (glSecondaryColor3b != null)
            {
                glSecondaryColor3b(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3bv (const GLbyte *v)
        public unsafe static void SecondaryColor3bv(GLbyte[] v)
        {
            if (glSecondaryColor3bv != null)
            {
                fixed (GLbyte* ptr_v = v)
                {
                    glSecondaryColor3bv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3d (GLdouble red, GLdouble green, GLdouble blue)
        public static void SecondaryColor3d(GLdouble red, GLdouble green, GLdouble blue)
        {
            if (glSecondaryColor3d != null)
            {
                glSecondaryColor3d(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3dv (const GLdouble *v)
        public unsafe static void SecondaryColor3dv(GLdouble[] v)
        {
            if (glSecondaryColor3dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glSecondaryColor3dv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3f (GLfloat red, GLfloat green, GLfloat blue)
        public static void SecondaryColor3f(GLfloat red, GLfloat green, GLfloat blue)
        {
            if (glSecondaryColor3f != null)
            {
                glSecondaryColor3f(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3fv (const GLfloat *v)
        public unsafe static void SecondaryColor3fv(GLfloat[] v)
        {
            if (glSecondaryColor3fv != null)
            {
                fixed(GLfloat* ptr_v = v)
                {
                    glSecondaryColor3fv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3i (GLint red, GLint green, GLint blue)
        public static void SecondaryColor3i(GLint red, GLint green, GLint blue)
        {
            if (glSecondaryColor3i != null)
            {
                glSecondaryColor3i(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3iv (const GLint *v)
        public unsafe static void SecondaryColor3iv(GLint[] v)
        {
            if (glSecondaryColor3iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glSecondaryColor3iv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3s (GLshort red, GLshort green, GLshort blue)
        public static void SecondaryColor3s(GLshort red, GLshort green, GLshort blue)
        {
            if (glSecondaryColor3s != null)
            {
                glSecondaryColor3s(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3sv (const GLshort *v)
        public unsafe static void SecondaryColor3sv(GLshort[] v)
        {
            if (glSecondaryColor3sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glSecondaryColor3sv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3ub (GLubyte red, GLubyte green, GLubyte blue)
        public static void SecondaryColor3ub(GLubyte red, GLubyte green, GLubyte blue)
        {
            if (glSecondaryColor3ub != null)
            {
                glSecondaryColor3ub(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3ubv (const GLubyte *v)
        public unsafe static void SecondaryColor3ubv(GLubyte[] v)
        {
            if (glSecondaryColor3ubv != null)
            {
                fixed (GLubyte* ptr_v = v)
                {
                    glSecondaryColor3ubv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3ui (GLuint red, GLuint green, GLuint blue)
        public static void SecondaryColor3ui(GLuint red, GLuint green, GLuint blue)
        {
            if (glSecondaryColor3ui != null)
            {
                glSecondaryColor3ui(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3uiv (const GLuint *v)
        public unsafe static void SecondaryColor3uiv(GLuint[] v)
        {
            if (glSecondaryColor3uiv != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glSecondaryColor3uiv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3us (GLushort red, GLushort green, GLushort blue)
        public static void SecondaryColor3us(GLushort red, GLushort green, GLushort blue)
        {
            if (glSecondaryColor3us != null)
            {
                glSecondaryColor3us(red, green, blue);
            }
        }

        // GLAPI void APIENTRY glSecondaryColor3usv (const GLushort *v)
        public unsafe static void SecondaryColor3usv(GLushort[] v)
        {
            if (glSecondaryColor3usv != null)
            {
                fixed (GLushort* ptr_v = v)
                {
                    glSecondaryColor3usv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColorPointer (GLint size, GLenum type, GLsizei stride, const GLvoid *pointer)
        public unsafe static void SecondaryColorPointer(GLint size, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glSecondaryColorPointer != null)
            {
                glSecondaryColorPointer(size, type, stride, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glWindowPos2d (GLdouble x, GLdouble y)
        public static void WindowPos2d(GLdouble x, GLdouble y)
        {
            if (glWindowPos2d != null)
            {
                glWindowPos2d(x, y);
            }
        }

        // GLAPI void APIENTRY glWindowPos2dv (const GLdouble *v)
        public unsafe static void WindowPos2dv(GLdouble[] v)
        {
            if (glWindowPos2dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glWindowPos2dv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos2f (GLfloat x, GLfloat y)
        public static void WindowPos2f(GLfloat x, GLfloat y)
        {
            if (glWindowPos2f != null)
            {
                glWindowPos2f(x, y);
            }
        }

        // GLAPI void APIENTRY glWindowPos2fv (const GLfloat *v)
        public unsafe static void WindowPos2fv(GLfloat[] v)
        {
            if (glWindowPos2fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glWindowPos2fv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos2i (GLint x, GLint y)
        public static void WindowPos2i(GLint x, GLint y)
        {
            if (glWindowPos2i != null)
            {
                glWindowPos2i(x, y);
            }
        }

        // GLAPI void APIENTRY glWindowPos2iv (const GLint *v)
        public unsafe static void WindowPos2iv(GLint[] v)
        {
            if (glWindowPos2iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glWindowPos2iv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos2s (GLshort x, GLshort y)
        public static void WindowPos2s(GLshort x, GLshort y)
        {
            if (glWindowPos2s != null)
            {
                glWindowPos2s(x, y);
            }
        }

        // GLAPI void APIENTRY glWindowPos2sv (const GLshort *v)
        public unsafe static void WindowPos2sv(GLshort[] v)
        {
            if (glWindowPos2sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glWindowPos2sv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos3d (GLdouble x, GLdouble y, GLdouble z)
        public static void WindowPos3d(GLdouble x, GLdouble y, GLdouble z)
        {
            if (glWindowPos3d != null)
            {
                glWindowPos3d(x, y, z);
            }
        }

        // GLAPI void APIENTRY glWindowPos3dv (const GLdouble *v)
        public unsafe static void WindowPos3dv(GLdouble[] v)
        {
            if (glWindowPos3dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glWindowPos3dv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos3f (GLfloat x, GLfloat y, GLfloat z)
        public static void WindowPos3f(GLfloat x, GLfloat y, GLfloat z)
        {
            if (glWindowPos3f != null)
            {
                glWindowPos3f(x, y, z);
            }
        }

        // GLAPI void APIENTRY glWindowPos3fv (const GLfloat *v)
        public unsafe static void WindowPos3fv(GLfloat[] v)
        {
            if (glWindowPos3fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glWindowPos3fv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos3i (GLint x, GLint y, GLint z)
        public static void WindowPos3i(GLint x, GLint y, GLint z)
        {
            if (glWindowPos3i != null)
            {
                glWindowPos3i(x, y, z);
            }
        }

        // GLAPI void APIENTRY glWindowPos3iv (const GLint *v)
        public unsafe static void WindowPos3iv(GLint[] v)
        {
            if (glWindowPos3iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glWindowPos3iv(ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glWindowPos3s (GLshort x, GLshort y, GLshort z)
        public static void WindowPos3s(GLshort x, GLshort y, GLshort z)
        {
            if (glWindowPos3s != null)
            {
                glWindowPos3s(x, y, z);
            }
        }

        // GLAPI void APIENTRY glWindowPos3sv (const GLshort *v)
        public unsafe static void WindowPos3sv(GLshort[] v)
        {
            if (glWindowPos3sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glWindowPos3sv(ptr_v);
                }
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v1.5 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v1.5 WRAPPERS...
        // GLAPI void APIENTRY glGenQueries (GLsizei n, GLuint *ids)
        public unsafe static void GenQueries(GLsizei n, GLuint[] ids)
        {
            if (glGenQueries != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glGenQueries(n, ptr_ids);
                }
            }
        }

        // GLAPI void APIENTRY glDeleteQueries (GLsizei n, const GLuint *ids)
        public unsafe static void DeleteQueries(GLsizei n, GLuint[] ids)
        {
            if (glDeleteQueries != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glDeleteQueries(n, ptr_ids);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsQuery (GLuint id)
        public static GLboolean IsQuery(GLuint id)
        {
            if (glIsQuery != null)
            {
                return glIsQuery(id);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glBeginQuery (GLenum target, GLuint id)
        public static void BeginQuery(GLenum target, GLuint id)
        {
            if (glBeginQuery != null)
            {
                glBeginQuery(target, id);
            }
        }

        // GLAPI void APIENTRY glEndQuery (GLenum target)
        public static void EndQuery(GLenum target)
        {
            if (glEndQuery != null)
            {
                glEndQuery(target);
            }
        }

        // GLAPI void APIENTRY glGetQueryiv (GLenum target, GLenum pname, GLint *params)
        public unsafe static void GetQueryiv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetQueryiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetQueryiv(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetQueryObjectiv (GLuint id, GLenum pname, GLint *params)
        public unsafe static void GetQueryObjectiv(GLuint id, GLenum pname, GLint[] parameters)
        {
            if (glGetQueryObjectiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetQueryObjectiv(id, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetQueryObjectuiv (GLuint id, GLenum pname, GLuint *params)
        public unsafe static void GetQueryObjectuiv(GLuint id, GLenum pname, GLuint[] parameters)
        {
            if (glGetQueryObjectuiv != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetQueryObjectuiv(id, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glBindBuffer (GLenum target, GLuint buffer)
        public static void BindBuffer(GLenum target, GLuint buffer)
        {
            if (glBindBuffer != null)
            {
                glBindBuffer(target, buffer);
            }
        }

        // GLAPI void APIENTRY glDeleteBuffers (GLsizei n, const GLuint *buffers)
        public unsafe static void DeleteBuffers(GLsizei n, GLuint[] buffers)
        {
            if (glDeleteBuffers != null)
            {
                fixed (GLuint* ptr_buffers = buffers)
                {
                    glDeleteBuffers(n, ptr_buffers);
                }
            }
        }

        // GLAPI void APIENTRY glGenBuffers (GLsizei n, GLuint *buffers)
        public unsafe static void GenBuffers(GLsizei n, GLuint[] buffers)
        {
            if (glGenBuffers != null)
            {
                fixed (GLuint* ptr_buffers = buffers)
                {
                    glGenBuffers(n, ptr_buffers);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsBuffer (GLuint buffer)
        public static GLboolean IsBuffer(GLuint buffer)
        {
            if (glIsBuffer != null)
            {
                return glIsBuffer(buffer);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glBufferData (GLenum target, GLsizeiptr size, const GLvoid *data, GLenum usage)
        public unsafe static void BufferData(GLenum target, GLsizeiptr size, IntPtr data, GLenum usage)
        {
            if (glBufferData != null)
            {
                glBufferData(target, size, data.ToPointer(), usage);
            }
        }

        // GLAPI void APIENTRY glBufferSubData (GLenum target, GLintptr offset, GLsizeiptr size, const GLvoid *data)
        public unsafe static void BufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, IntPtr data)
        {
            if (glBufferSubData != null)
            {
                glBufferSubData(target, offset, size, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetBufferSubData (GLenum target, GLintptr offset, GLsizeiptr size, GLvoid *data)
        public unsafe static void GetBufferSubData(GLenum target, GLintptr offset, GLsizeiptr size, IntPtr data)
        {
            if (glGetBufferSubData != null)
            {
                glGetBufferSubData(target, offset, size, data.ToPointer());
            }
        }

        // GLAPI GLvoid* APIENTRY glMapBuffer (GLenum target, GLenum access)
        public unsafe static IntPtr MapBuffer(GLenum target, GLenum access)
        {
            if (glMapBuffer != null)
            {
                return (IntPtr)glMapBuffer(target, access);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // GLAPI GLboolean APIENTRY glUnmapBuffer (GLenum target)
        public static GLboolean UnmapBuffer(GLenum target)
        {
            if (glUnmapBuffer != null)
            {
                return glUnmapBuffer(target);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glGetBufferParameteriv (GLenum target, GLenum pname, GLint *params)
        public unsafe static void GetBufferParameteriv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetBufferParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetBufferParameteriv(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetBufferPointerv (GLenum target, GLenum pname, GLvoid* *params)
        public unsafe static void GetBufferPointerv(GLenum target, GLenum pname, IntPtr[] parameters)
        {
            if (glGetBufferPointerv != null)
            {
                fixed (IntPtr* ptr_parameters = parameters)
                {
                    glGetBufferPointerv(target, pname, (void**)ptr_parameters);
                }
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v2.0 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v2.0 WRAPPERS...
        // GLAPI void APIENTRY glBlendEquationSeparate (GLenum modeRGB, GLenum modeAlpha)
        public static void BlendEquationSeparate(GLenum modeRGB, GLenum modeAlpha)
        {
            if (glBlendEquationSeparate != null)
            {
                glBlendEquationSeparate(modeRGB, modeAlpha);
            }
        }

        // GLAPI void APIENTRY glDrawBuffers (GLsizei n, const GLenum *bufs)
        public unsafe static void DrawBuffers(GLsizei n, GLenum[] bufs)
        {
            if (glDrawBuffers != null)
            {
                fixed (GLenum* ptr_bufs = bufs)
                {
                    glDrawBuffers(n, ptr_bufs);
                }
            }
        }

        // GLAPI void APIENTRY glStencilOpSeparate (GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass)
        public static void StencilOpSeparate(GLenum face, GLenum sfail, GLenum dpfail, GLenum dppass)
        {
            if (glStencilOpSeparate != null)
            {
                glStencilOpSeparate(face, sfail, dpfail, dppass);
            }
        }

        // GLAPI void APIENTRY glStencilFuncSeparate (GLenum face, GLenum func, GLint ref, GLuint mask)
        public static void StencilFuncSeparate(GLenum face, GLenum func, GLint reference, GLuint mask)
        {
            if (glStencilFuncSeparate != null)
            {
                glStencilFuncSeparate(face, func, reference, mask);
            }
        }

        // GLAPI void APIENTRY glStencilMaskSeparate (GLenum face, GLuint mask)
        public static void StencilMaskSeparate(GLenum face, GLuint mask)
        {
            if (glStencilMaskSeparate != null)
            {
                glStencilMaskSeparate(face, mask);
            }
        }

        // GLAPI void APIENTRY glAttachShader (GLuint program, GLuint shader)
        public static void AttachShader(GLuint program, GLuint shader)
        {
            if (glAttachShader != null)
            {
                glAttachShader(program, shader);
            }
        }

        // GLAPI void APIENTRY glBindAttribLocation (GLuint program, GLuint index, const GLchar *name)
        public static void BindAttribLocation(GLuint program, GLuint index, string name)
        {
            if (glBindAttribLocation != null)
            {
                glBindAttribLocation(program, index, name);
            }
        }

        // GLAPI void APIENTRY glCompileShader (GLuint shader)
        public static void CompileShader(GLuint shader)
        {
            if (glCompileShader != null)
            {
                glCompileShader(shader);
            }
        }

        // GLAPI GLuint APIENTRY glCreateProgram (void)
        public static void CreateProgram()
        {
            if (glCreateProgram != null)
            {
                glCreateProgram();
            }
        }

        // GLAPI GLuint APIENTRY glCreateShader (GLenum type)
        public static void CreateShader(GLenum type)
        {
            if (glCreateShader != null)
            {
                glCreateShader(type);
            }
        }

        // GLAPI void APIENTRY glDeleteProgram (GLuint program)
        public static void DeleteProgram(GLuint program)
        {
            if (glDeleteProgram != null)
            {
                glDeleteProgram(program);
            }
        }

        // GLAPI void APIENTRY glDeleteShader (GLuint shader)
        public static void DeleteShader(GLuint shader)
        {
            if (glDeleteShader != null)
            {
                glDeleteShader(shader);
            }
        }

        // GLAPI void APIENTRY glDetachShader (GLuint program, GLuint shader)
        public static void DetachShader(GLuint program, GLuint shader)
        {
            if (glDetachShader != null)
            {
                glDetachShader(program, shader);
            }
        }

        // GLAPI void APIENTRY glDisableVertexAttribArray (GLuint index)
        public static void DisableVertexAttribArray(GLuint index)
        {
            if (glDisableVertexAttribArray != null)
            {
                glDisableVertexAttribArray(index);
            }
        }

        // GLAPI void APIENTRY glEnableVertexAttribArray (GLuint index)
        public static void EnableVertexAttribArray(GLuint index)
        {
            if (glEnableVertexAttribArray != null)
            {
                glEnableVertexAttribArray(index);
            }
        }

        // GLAPI void APIENTRY glGetActiveAttrib (GLuint program, GLuint index, GLsizei bufSize, GLsizei *length, GLint *size, GLenum *type, GLchar *name)
        public unsafe static void GetActiveAttrib(GLuint program, GLuint index, GLsizei bufSize, GLsizei[] length, GLint[] size, GLenum[] type, GLchar[] name)
        {
            if (glGetActiveAttrib != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLint* ptr_size = size)
                    {
                        fixed (GLenum* ptr_type = type)
                        {
                            fixed (GLchar* ptr_name = name)
                            {
                                glGetActiveAttrib(program, index, bufSize, ptr_length, ptr_size, ptr_type, ptr_name);
                            }
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetActiveUniform (GLuint program, GLuint index, GLsizei bufSize, GLsizei *length, GLint *size, GLenum *type, GLchar *name)
        public unsafe static void GetActiveUniform(GLuint program, GLuint index, GLsizei bufSize, GLsizei[] length, GLint[] size, GLenum[] type, GLchar[] name)
        {
            if (glGetActiveUniform != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLint* ptr_size = size)
                    {
                        fixed (GLenum* ptr_type = type)
                        {
                            fixed (GLchar* ptr_name = name)
                            {
                                glGetActiveUniform(program, index, bufSize, ptr_length, ptr_size, ptr_type, ptr_name);
                            }
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetAttachedShaders (GLuint program, GLsizei maxCount, GLsizei *count, GLuint *obj)
        public unsafe static void GetAttachedShaders(GLuint program, GLsizei maxCount, GLsizei[] count, GLuint[] obj)
        {
            if (glGetAttachedShaders != null)
            {
                fixed (GLsizei* ptr_count = count)
                {
                    fixed (GLuint* ptr_obj = obj)
                    {
                        glGetAttachedShaders(program, maxCount, ptr_count, ptr_obj);
                    }
                }
            }
        }

        // GLAPI GLint APIENTRY glGetAttribLocation (GLuint program, const GLchar *name)
        public static GLint GetAttribLocation(GLuint program, string name)
        {
            if (glGetAttribLocation != null)
            {
                return glGetAttribLocation(program, name);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glGetProgramiv (GLuint program, GLenum pname, GLint *params)
        public unsafe static void GetProgramiv(GLuint program, GLenum pname, GLint[] parameters)
        {
            if (glGetProgramiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetProgramiv(program, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramInfoLog (GLuint program, GLsizei bufSize, GLsizei *length, GLchar *infoLog)
        public unsafe static void GetProgramInfoLog(GLuint program, GLsizei bufSize, GLsizei[] length, GLchar[] infoLog)
        {
            if (glGetProgramInfoLog != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_infolog = infoLog)
                    {
                        glGetProgramInfoLog(program, bufSize, ptr_length, ptr_infolog);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetShaderiv (GLuint shader, GLenum pname, GLint *params)
        public unsafe static void GetShaderiv(GLuint shader, GLenum pname, GLint[] parameters)
        {
            if (glGetShaderiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetShaderiv(shader, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetShaderInfoLog (GLuint shader, GLsizei bufSize, GLsizei *length, GLchar *infoLog)
        public unsafe static void GetShaderInfoLog(GLuint shader, GLsizei bufSize, GLsizei[] length, GLchar[] infoLog)
        {
            if (glGetShaderInfoLog != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_infolog = infoLog)
                    {
                        glGetShaderInfoLog(shader, bufSize, ptr_length, ptr_infolog);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetShaderSource (GLuint shader, GLsizei bufSize, GLsizei *length, GLchar *source)
        public unsafe static void GetShaderSource(GLuint shader, GLsizei bufSize, GLsizei[] length, GLchar[] source)
        {
            if (glGetShaderSource != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_source = source)
                    {
                        glGetShaderSource(shader, bufSize, ptr_length, ptr_source);
                    }
                }
            }
        }

        // GLAPI GLint APIENTRY glGetUniformLocation (GLuint program, const GLchar *name)
        public static GLint GetUniformLocation(GLuint program, string name)
        {
            if (glGetUniformLocation != null)
            {
                return glGetUniformLocation(program, name);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glGetUniformfv (GLuint program, GLint location, GLfloat *params)
        public unsafe static void GetUniformfv(GLuint program, GLint location, GLfloat[] parameters)
        {
            if (glGetUniformfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetUniformfv(program, location, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetUniformiv (GLuint program, GLint location, GLint *params)
        public unsafe static void GetUniformiv(GLuint program, GLint location, GLint[] parameters)
        {
            if (glGetUniformiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetUniformiv(program, location, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribdv (GLuint index, GLenum pname, GLdouble *params)
        public unsafe static void GetVertexAttribdv(GLuint index, GLenum pname, GLdouble[] parameters)
        {
            if (glGetVertexAttribdv != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetVertexAttribdv(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribfv (GLuint index, GLenum pname, GLfloat *params)
        public unsafe static void GetVertexAttribfv(GLuint index, GLenum pname, GLfloat[] parameters)
        {
            if (glGetVertexAttribfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetVertexAttribfv(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribiv (GLuint index, GLenum pname, GLint *params)
        public unsafe static void GetVertexAttribiv(GLuint index, GLenum pname, GLint[] parameters)
        {
            if (glGetVertexAttribiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetVertexAttribiv(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribPointerv (GLuint index, GLenum pname, GLvoid* *pointer)
        public unsafe static void GetVertexAttribPointerv(GLuint index, GLenum pname, IntPtr[] pointer)
        {
            if (glGetVertexAttribPointerv != null)
            {
                fixed (IntPtr* ptr_pointer = pointer)
                {
                    glGetVertexAttribPointerv(index, pname, (void**)ptr_pointer);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsProgram (GLuint program)
        public static GLboolean IsProgram(GLuint program)
        {
            if (glIsProgram != null)
            {
                return glIsProgram(program);
            }
            else
            {
                return false;
            }
        }

        // GLAPI GLboolean APIENTRY glIsShader (GLuint shader)
        public static GLboolean IsShader(GLuint shader)
        {
            if (glIsShader != null)
            {
                return glIsShader(shader);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glLinkProgram (GLuint program)
        public static void LinkProgram(GLuint program)
        {
            if (glLinkProgram != null)
            {
                glLinkProgram(program);
            }
        }

        // GLAPI void APIENTRY glShaderSource (GLuint shader, GLsizei count, const GLchar* *string, const GLint *length)
        public unsafe static void ShaderSource(GLuint shader, GLsizei count, string[] strings, GLint[] length)
        {
            if (glShaderSource != null)
            {
                IntPtr strptrtable = BuildStringIntPtrTable(strings);

                fixed (GLint* ptr_length = length)
                {
                    glShaderSource(shader, count, (GLchar**)strptrtable, ptr_length);
                }

                Marshal.FreeHGlobal(strptrtable);
            }
        }

        // GLAPI void APIENTRY glUseProgram (GLuint program)
        public static void UseProgram(GLuint program)
        {
            if (glUseProgram != null)
            {
                glUseProgram(program);
            }
        }

        // GLAPI void APIENTRY glUniform1f (GLint location, GLfloat v0)
        public static void Uniform1f(GLint location, GLfloat v0)
        {
            if (glUniform1f != null)
            {
                glUniform1f(location, v0);
            }
        }

        // GLAPI void APIENTRY glUniform2f (GLint location, GLfloat v0, GLfloat v1)
        public static void Uniform2f(GLint location, GLfloat v0, GLfloat v1)
        {
            if (glUniform2f != null)
            {
                glUniform2f(location, v0, v1);
            }
        }

        // GLAPI void APIENTRY glUniform3f (GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
        public static void Uniform3f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
        {
            if (glUniform3f != null)
            {
                glUniform3f(location, v0, v1, v2);
            }
        }

        // GLAPI void APIENTRY glUniform4f (GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
        public static void Uniform4f(GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
        {
            if (glUniform4f != null)
            {
                glUniform4f(location, v0, v1, v2, v3);
            }
        }

        // GLAPI void APIENTRY glUniform1i (GLint location, GLint v0)
        public static void Uniform1i(GLint location, GLint v0)
        {
            if (glUniform1i != null)
            {
                glUniform1i(location, v0);
            }
        }

        // GLAPI void APIENTRY glUniform2i (GLint location, GLint v0, GLint v1)
        public static void Uniform2i(GLint location, GLint v0, GLint v1)
        {
            if (glUniform2i != null)
            {
                glUniform2i(location, v0, v1);
            }
        }

        // GLAPI void APIENTRY glUniform3i (GLint location, GLint v0, GLint v1, GLint v2)
        public static void Uniform3i(GLint location, GLint v0, GLint v1, GLint v2)
        {
            if (glUniform3i != null)
            {
                glUniform3i(location, v0, v1, v2);
            }
        }

        // GLAPI void APIENTRY glUniform4i (GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
        public static void Uniform4i(GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
        {
            if (glUniform4i != null)
            {
                glUniform4i(location, v0, v1, v2, v3);
            }
        }

        // GLAPI void APIENTRY glUniform1fv (GLint location, GLsizei count, const GLfloat *value)
        public unsafe static void Uniform1fv(GLint location, GLsizei count, GLfloat[] value)
        {
            if (glUniform1fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniform1fv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform2fv (GLint location, GLsizei count, const GLfloat *value)
        public unsafe static void Uniform2fv(GLint location, GLsizei count, GLfloat[] value)
        {
            if (glUniform2fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniform2fv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform3fv (GLint location, GLsizei count, const GLfloat *value)
        public unsafe static void Uniform3fv(GLint location, GLsizei count, GLfloat[] value)
        {
            if (glUniform3fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniform3fv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform4fv (GLint location, GLsizei count, const GLfloat *value)
        public unsafe static void Uniform4fv(GLint location, GLsizei count, GLfloat[] value)
        {
            if (glUniform4fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniform4fv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform1iv (GLint location, GLsizei count, const GLint *value)
        public unsafe static void Uniform1iv(GLint location, GLsizei count, GLint[] value)
        {
            if (glUniform1iv != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glUniform1iv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform2iv (GLint location, GLsizei count, const GLint *value)
        public unsafe static void Uniform2iv(GLint location, GLsizei count, GLint[] value)
        {
            if (glUniform2iv != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glUniform2iv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform3iv (GLint location, GLsizei count, const GLint *value)
        public unsafe static void Uniform3iv(GLint location, GLsizei count, GLint[] value)
        {
            if (glUniform3iv != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glUniform3iv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform4iv (GLint location, GLsizei count, const GLint *value)
        public unsafe static void Uniform4iv(GLint location, GLsizei count, GLint[] value)
        {
            if (glUniform4iv != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glUniform4iv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix2fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void UniformMatrix2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glUniformMatrix2fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniformMatrix2fv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix3fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void UniformMatrix3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glUniformMatrix3fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniformMatrix3fv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix4fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void UniformMatrix4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glUniformMatrix4fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniformMatrix4fv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glValidateProgram (GLuint program)
        public static void ValidateProgram(GLuint program)
        {
            if (glValidateProgram != null)
            {
                glValidateProgram(program);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1d (GLuint index, GLdouble x)
        public static void VertexAttrib1d(GLuint index, GLdouble x)
        {
            if (glVertexAttrib1d != null)
            {
                glVertexAttrib1d(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1dv (GLuint index, const GLdouble *v)
        public unsafe static void VertexAttrib1dv(GLuint index, GLdouble[] v)
        {
            if (glVertexAttrib1dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttrib1dv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1f (GLuint index, GLfloat x)
        public static void VertexAttrib1f(GLuint index, GLfloat x)
        {
            if (glVertexAttrib1f != null)
            {
                glVertexAttrib1f(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1fv (GLuint index, const GLfloat *v)
        public unsafe static void VertexAttrib1fv(GLuint index, GLfloat[] v)
        {
            if (glVertexAttrib1fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertexAttrib1fv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1s (GLuint index, GLshort x)
        public static void VertexAttrib1s(GLuint index, GLshort x)
        {
            if (glVertexAttrib1s != null)
            {
                glVertexAttrib1s(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib1sv (GLuint index, const GLshort *v)
        public unsafe static void VertexAttrib1sv(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib1sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttrib1sv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2d (GLuint index, GLdouble x, GLdouble y)
        public static void VertexAttrib2d(GLuint index, GLdouble x, GLdouble y)
        {
            if (glVertexAttrib2d != null)
            {
                glVertexAttrib2d(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2dv (GLuint index, const GLdouble *v)
        public unsafe static void VertexAttrib2dv(GLuint index, GLdouble[] v)
        {
            if (glVertexAttrib2dv != null)
            {
                fixed(GLdouble* ptr_v = v)
                {
                    glVertexAttrib2dv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2f (GLuint index, GLfloat x, GLfloat y)
        public static void VertexAttrib2f(GLuint index, GLfloat x, GLfloat y)
        {
            if (glVertexAttrib2f != null)
            {
                glVertexAttrib2f(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2fv (GLuint index, const GLfloat *v)
        public unsafe static void VertexAttrib2fv(GLuint index, GLfloat[] v)
        {
            if (glVertexAttrib2fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertexAttrib2fv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2s (GLuint index, GLshort x, GLshort y)
        public static void VertexAttrib2s(GLuint index, GLshort x, GLshort y)
        {
            if (glVertexAttrib2s != null)
            {
                glVertexAttrib2s(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib2sv (GLuint index, const GLshort *v)
        public unsafe static void VertexAttrib2sv(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib2sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttrib2sv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3d (GLuint index, GLdouble x, GLdouble y, GLdouble z)
        public static void VertexAttrib3d(GLuint index, GLdouble x, GLdouble y, GLdouble z)
        {
            if (glVertexAttrib3d != null)
            {
                glVertexAttrib3d(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3dv (GLuint index, const GLdouble *v)
        public unsafe static void VertexAttrib3dv(GLuint index, GLdouble[] v)
        {
            if (glVertexAttrib3dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttrib3dv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3f (GLuint index, GLfloat x, GLfloat y, GLfloat z)
        public static void VertexAttrib3f(GLuint index, GLfloat x, GLfloat y, GLfloat z)
        {
            if (glVertexAttrib3f != null)
            {
                glVertexAttrib3f(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3fv (GLuint index, const GLfloat *v)
        public unsafe static void VertexAttrib3fv(GLuint index, GLfloat[] v)
        {
            if (glVertexAttrib3fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertexAttrib3fv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3s (GLuint index, GLshort x, GLshort y, GLshort z)
        public static void VertexAttrib3s(GLuint index, GLshort x, GLshort y, GLshort z)
        {
            if (glVertexAttrib3s != null)
            {
                glVertexAttrib3s(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib3sv (GLuint index, const GLshort *v)
        public unsafe static void VertexAttrib3sv(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib3sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttrib3sv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4Nbv (GLuint index, const GLbyte *v)
        public unsafe static void VertexAttrib4Nbv(GLuint index, GLbyte[] v)
        {
            if (glVertexAttrib4Nbv != null)
            {
                fixed (GLbyte* ptr_v = v)
                {
                    glVertexAttrib4Nbv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4Niv (GLuint index, const GLint *v)
        public unsafe static void VertexAttrib4Niv(GLuint index, GLint[] v)
        {
            if (glVertexAttrib4Niv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertexAttrib4Niv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4Nsv (GLuint index, const GLshort *v)
        public unsafe static void VertexAttrib4Nsv(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib4Nsv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttrib4Nsv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4Nub (GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
        public static void VertexAttrib4Nub(GLuint index, GLubyte x, GLubyte y, GLubyte z, GLubyte w)
        {
            if (glVertexAttrib4Nub != null)
            {
                glVertexAttrib4Nub(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4Nubv (GLuint index, const GLubyte *v)
        public unsafe static void VertexAttrib4Nubv(GLuint index, GLubyte[] v)
        {
            if (glVertexAttrib4Nubv != null)
            {
                fixed (GLubyte* ptr_v = v)
                {
                    glVertexAttrib4Nubv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4Nuiv (GLuint index, const GLuint *v)
        public unsafe static void VertexAttrib4Nuiv(GLuint index, GLuint[] v)
        {
            if (glVertexAttrib4Nuiv != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glVertexAttrib4Nuiv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4Nusv (GLuint index, const GLushort *v)
        public unsafe static void VertexAttrib4Nusv(GLuint index, GLushort[] v)
        {
            if (glVertexAttrib4Nusv != null)
            {
                fixed (GLushort* ptr_v = v)
                {
                    glVertexAttrib4Nusv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4bv (GLuint index, const GLbyte *v)
        public unsafe static void VertexAttrib4bv(GLuint index, GLbyte[] v)
        {
            if (glVertexAttrib4bv != null)
            {
                fixed (GLbyte* ptr_v = v)
                {
                    glVertexAttrib4bv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4d (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        public static void VertexAttrib4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glVertexAttrib4d != null)
            {
                glVertexAttrib4d(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4dv (GLuint index, const GLdouble *v)
        public unsafe static void VertexAttrib4dv(GLuint index, GLdouble[] v)
        {
            if (glVertexAttrib4dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttrib4dv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4f (GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        public static void VertexAttrib4f(GLuint index, GLfloat x, GLfloat y, GLfloat z, GLfloat w)
        {
            if (glVertexAttrib4f != null)
            {
                glVertexAttrib4f(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4fv (GLuint index, const GLfloat *v)
        public unsafe static void VertexAttrib4fv(GLuint index, GLfloat[] v)
        {
            if (glVertexAttrib4fv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glVertexAttrib4fv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4iv (GLuint index, const GLint *v)
        public unsafe static void VertexAttrib4iv(GLuint index, GLint[] v)
        {
            if (glVertexAttrib4iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertexAttrib4iv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4s (GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
        public static void VertexAttrib4s(GLuint index, GLshort x, GLshort y, GLshort z, GLshort w)
        {
            if (glVertexAttrib4s != null)
            {
                glVertexAttrib4s(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4sv (GLuint index, const GLshort *v)
        public unsafe static void VertexAttrib4sv(GLuint index, GLshort[] v)
        {
            if (glVertexAttrib4sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttrib4sv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4ubv (GLuint index, const GLubyte *v)
        public unsafe static void VertexAttrib4ubv(GLuint index, GLubyte[] v)
        {
            if (glVertexAttrib4ubv != null)
            {
                fixed (GLubyte* ptr_v = v)
                {
                    glVertexAttrib4ubv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4uiv (GLuint index, const GLuint *v)
        public unsafe static void VertexAttrib4uiv(GLuint index, GLuint[] v)
        {
            if (glVertexAttrib4uiv != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glVertexAttrib4uiv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttrib4usv (GLuint index, const GLushort *v)
        public unsafe static void VertexAttrib4usv(GLuint index, GLushort[] v)
        {
            if (glVertexAttrib4usv != null)
            {
                fixed (GLushort* ptr_v = v)
                {
                    glVertexAttrib4usv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribPointer (GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, const GLvoid *pointer)
        public unsafe static void VertexAttribPointer(GLuint index, GLint size, GLenum type, GLboolean normalized, GLsizei stride, IntPtr pointer)
        {
            if (glVertexAttribPointer != null)
            {
                glVertexAttribPointer(index, size, type, normalized, stride, pointer.ToPointer());
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v2.1 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v2.1 WRAPPERS...
        // GLAPI void APIENTRY glUniformMatrix2x3fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void UniformMatrix2x3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glUniformMatrix2x3fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniformMatrix2x3fv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix3x2fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void UniformMatrix3x2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glUniformMatrix3x2fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniformMatrix3x2fv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix2x4fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void UniformMatrix2x4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glUniformMatrix2x4fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniformMatrix2x4fv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix4x2fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void UniformMatrix4x2fv(GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glUniformMatrix4x2fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniformMatrix4x2fv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix3x4fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void UniformMatrix3x4fv(GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glUniformMatrix3x4fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniformMatrix3x4fv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix4x3fv (GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void UniformMatrix4x3fv(GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glUniformMatrix4x3fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glUniformMatrix4x3fv(location, count, transpose, ptr_value);
                }
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v3.0 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v3.0 WRAPPERS...
        // GLAPI void APIENTRY glColorMaski (GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a)
        public static void ColorMaski(GLuint index, GLboolean r, GLboolean g, GLboolean b, GLboolean a)
        {
            if (glColorMaski != null)
            {
                glColorMaski(index, r, g, b, a);
            }
        }

        // GLAPI void APIENTRY glGetBooleani_v (GLenum target, GLuint index, GLboolean *data)
        public unsafe static void GetBooleani_v(GLenum target, GLuint index, GLboolean[] data)
        {
            if (glGetBooleani_v != null)
            {
                fixed (GLboolean* ptr_data = data)
                {
                    glGetBooleani_v(target, index, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetIntegeri_v (GLenum target, GLuint index, GLint *data)
        public unsafe static void GetIntegeri_v(GLenum target, GLuint index, GLint[] data)
        {
            if (glGetIntegeri_v != null)
            {
                fixed (GLint* ptr_data = data)
                {
                    glGetIntegeri_v(target, index, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glEnablei (GLenum target, GLuint index)
        public static void Enablei(GLenum target, GLuint index)
        {
            if (glEnablei != null)
            {
                glEnablei(target, index);
            }
        }

        // GLAPI void APIENTRY glDisablei (GLenum target, GLuint index)
        public static void Disablei(GLenum target, GLuint index)
        {
            if (glDisablei != null)
            {
                glDisablei(target, index);
            }
        }

        // GLAPI GLboolean APIENTRY glIsEnabledi (GLenum target, GLuint index)
        public static GLboolean IsEnabledi(GLenum target, GLuint index)
        {
            if (glIsEnabledi != null)
            {
                return glIsEnabledi(target, index);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glBeginTransformFeedback (GLenum primitiveMode)
        public static void BeginTransformFeedback(GLenum primitiveMode)
        {
            if (glBeginTransformFeedback != null)
            {
                glBeginTransformFeedback(primitiveMode);
            }
        }

        // GLAPI void APIENTRY glEndTransformFeedback (void)
        public static void EndTransformFeedback()
        {
            if (glEndTransformFeedback != null)
            {
                glEndTransformFeedback();
            }
        }

        // GLAPI void APIENTRY glBindBufferRange (GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
        public static void BindBufferRange(GLenum target, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
        {
            if (glBindBufferRange != null)
            {
                glBindBufferRange(target, index, buffer, offset, size);
            }
        }

        // GLAPI void APIENTRY glBindBufferBase (GLenum target, GLuint index, GLuint buffer)
        public static void BindBufferBase(GLenum target, GLuint index, GLuint buffer)
        {
            if (glBindBufferBase != null)
            {
                glBindBufferBase(target, index, buffer);
            }
        }

        // GLAPI void APIENTRY glTransformFeedbackVaryings (GLuint program, GLsizei count, const GLchar* *varyings, GLenum bufferMode)
        public unsafe static void TransformFeedbackVaryings(GLuint program, GLsizei count, string[] varyings, GLenum bufferMode)
        {
            if (glTransformFeedbackVaryings != null)
            {
                IntPtr strptrtable = BuildStringIntPtrTable(varyings);

                glTransformFeedbackVaryings(program, count, (GLchar**)strptrtable, bufferMode);

                Marshal.FreeHGlobal(strptrtable);
            }
        }

        // GLAPI void APIENTRY glGetTransformFeedbackVarying (GLuint program, GLuint index, GLsizei bufSize, GLsizei *length, GLsizei *size, GLenum *type, GLchar *name)
        public unsafe static void GetTransformFeedbackVarying(GLuint program, GLuint index, GLsizei bufSize, GLsizei[] length, GLsizei[] size, GLenum[] type, GLchar[] name)
        {
            if (glGetTransformFeedbackVarying != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLsizei* ptr_size = size)
                    {
                        fixed (GLenum* ptr_type = type)
                        {
                            fixed (GLchar* ptr_name = name)
                            {
                                glGetTransformFeedbackVarying(program, index, bufSize, ptr_length, ptr_size, ptr_type, ptr_name);
                            }
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glClampColor (GLenum target, GLenum clamp)
        public static void ClampColor(GLenum target, GLenum clamp)
        {
            if (glClampColor != null)
            {
                glClampColor(target, clamp);
            }
        }

        // GLAPI void APIENTRY glBeginConditionalRender (GLuint id, GLenum mode)
        public static void BeginConditionalRender(GLuint id, GLenum mode)
        {
            if (glBeginConditionalRender != null)
            {
                glBeginConditionalRender(id, mode);
            }
        }

        // GLAPI void APIENTRY glEndConditionalRender (void)
        public static void EndConditionalRender()
        {
            if (glEndConditionalRender != null)
            {
                glEndConditionalRender();
            }
        }

        // GLAPI void APIENTRY glVertexAttribIPointer (GLuint index, GLint size, GLenum type, GLsizei stride, const GLvoid *pointer)
        public unsafe static void VertexAttribIPointer(GLuint index, GLint size, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glVertexAttribIPointer != null)
            {
                glVertexAttribIPointer(index, size, type, stride, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribIiv (GLuint index, GLenum pname, GLint *params)
        public unsafe static void GetVertexAttribIiv(GLuint index, GLenum pname, GLint[] parameters)
        {
            if (glGetVertexAttribIiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetVertexAttribIiv(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribIuiv (GLuint index, GLenum pname, GLuint *params)
        public unsafe static void GetVertexAttribIuiv(GLuint index, GLenum pname, GLuint[] parameters)
        {
            if (glGetVertexAttribIuiv != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetVertexAttribIuiv(index, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI1i (GLuint index, GLint x)
        public static void VertexAttribI1i(GLuint index, GLint x)
        {
            if (glVertexAttribI1i != null)
            {
                glVertexAttribI1i(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI2i (GLuint index, GLint x, GLint y)
        public static void VertexAttribI2i(GLuint index, GLint x, GLint y)
        {
            if (glVertexAttribI2i != null)
            {
                glVertexAttribI2i(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI3i (GLuint index, GLint x, GLint y, GLint z)
        public static void VertexAttribI3i(GLuint index, GLint x, GLint y, GLint z)
        {
            if (glVertexAttribI3i != null)
            {
                glVertexAttribI3i(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4i (GLuint index, GLint x, GLint y, GLint z, GLint w)
        public static void VertexAttribI4i(GLuint index, GLint x, GLint y, GLint z, GLint w)
        {
            if (glVertexAttribI4i != null)
            {
                glVertexAttribI4i(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI1ui (GLuint index, GLuint x)
        public static void VertexAttribI1ui(GLuint index, GLuint x)
        {
            if (glVertexAttribI1ui != null)
            {
                glVertexAttribI1ui(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI2ui (GLuint index, GLuint x, GLuint y)
        public static void VertexAttribI2ui(GLuint index, GLuint x, GLuint y)
        {
            if (glVertexAttribI2ui != null)
            {
                glVertexAttribI2ui(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI3ui (GLuint index, GLuint x, GLuint y, GLuint z)
        public static void VertexAttribI3ui(GLuint index, GLuint x, GLuint y, GLuint z)
        {
            if (glVertexAttribI3ui != null)
            {
                glVertexAttribI3ui(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4ui (GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
        public static void VertexAttribI4ui(GLuint index, GLuint x, GLuint y, GLuint z, GLuint w)
        {
            if (glVertexAttribI4ui != null)
            {
                glVertexAttribI4ui(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttribI1iv (GLuint index, const GLint *v)
        public unsafe static void VertexAttribI1iv(GLuint index, GLint[] v)
        {
            if (glVertexAttribI1iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertexAttribI1iv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI2iv (GLuint index, const GLint *v)
        public unsafe static void VertexAttribI2iv(GLuint index, GLint[] v)
        {
            if (glVertexAttribI2iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertexAttribI2iv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI3iv (GLuint index, const GLint *v)
        public unsafe static void VertexAttribI3iv(GLuint index, GLint[] v)
        {
            if (glVertexAttribI3iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertexAttribI3iv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4iv (GLuint index, const GLint *v)
        public unsafe static void VertexAttribI4iv(GLuint index, GLint[] v)
        {
            if (glVertexAttribI4iv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glVertexAttribI4iv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI1uiv (GLuint index, const GLuint *v)
        public unsafe static void VertexAttribI1uiv(GLuint index, GLuint[] v)
        {
            if (glVertexAttribI1uiv != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glVertexAttribI1uiv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI2uiv (GLuint index, const GLuint *v)
        public unsafe static void VertexAttribI2uiv(GLuint index, GLuint[] v)
        {
            if (glVertexAttribI2uiv != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glVertexAttribI2uiv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI3uiv (GLuint index, const GLuint *v)
        public unsafe static void VertexAttribI3uiv(GLuint index, GLuint[] v)
        {
            if (glVertexAttribI3uiv != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glVertexAttribI3uiv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4uiv (GLuint index, const GLuint *v)
        public unsafe static void VertexAttribI4uiv(GLuint index, GLuint[] v)
        {
            if (glVertexAttribI4uiv != null)
            {
                fixed (GLuint* ptr_v = v)
                {
                    glVertexAttribI4uiv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4bv (GLuint index, const GLbyte *v)
        public unsafe static void VertexAttribI4bv(GLuint index, GLbyte[] v)
        {
            if (glVertexAttribI4bv != null)
            {
                fixed (GLbyte* ptr_v = v)
                {
                    glVertexAttribI4bv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4sv (GLuint index, const GLshort *v)
        public unsafe static void VertexAttribI4sv(GLuint index, GLshort[] v)
        {
            if (glVertexAttribI4sv != null)
            {
                fixed (GLshort* ptr_v = v)
                {
                    glVertexAttribI4sv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4ubv (GLuint index, const GLubyte *v)
        public unsafe static void VertexAttribI4ubv(GLuint index, GLubyte[] v)
        {
            if (glVertexAttribI4ubv != null)
            {
                fixed (GLubyte* ptr_v = v)
                {
                    glVertexAttribI4ubv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribI4usv (GLuint index, const GLushort *v)
        public unsafe static void VertexAttribI4usv(GLuint index, GLushort[] v)
        {
            if (glVertexAttribI4usv != null)
            {
                fixed (GLushort* ptr_v = v)
                {
                    glVertexAttribI4usv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glGetUniformuiv (GLuint program, GLint location, GLuint *params)
        public unsafe static void GetUniformuiv(GLuint program, GLint location, GLuint[] parameters)
        {
            if (glGetUniformuiv != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetUniformuiv(program, location, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glBindFragDataLocation (GLuint program, GLuint color, const GLchar *name)
        public unsafe static void BindFragDataLocation(GLuint program, GLuint color, string name)
        {
            if (glBindFragDataLocation != null)
            {
                glBindFragDataLocation(program, color, name);
            }
        }

        // GLAPI GLint APIENTRY glGetFragDataLocation (GLuint program, const GLchar *name)
        public unsafe static GLint GetFragDataLocation(GLuint program, string name)
        {
            if (glGetFragDataLocation != null)
            {
                return glGetFragDataLocation(program, name);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glUniform1ui (GLint location, GLuint v0)
        public static void Uniform1ui(GLint location, GLuint v0)
        {
            if (glUniform1ui != null)
            {
                glUniform1ui(location, v0);
            }
        }

        // GLAPI void APIENTRY glUniform2ui (GLint location, GLuint v0, GLuint v1)
        public static void Uniform2ui(GLint location, GLuint v0, GLuint v1)
        {
            if (glUniform2ui != null)
            {
                glUniform2ui(location, v0, v1);
            }
        }

        // GLAPI void APIENTRY glUniform3ui (GLint location, GLuint v0, GLuint v1, GLuint v2)
        public static void Uniform3ui(GLint location, GLuint v0, GLuint v1, GLuint v2)
        {
            if (glUniform3ui != null)
            {
                glUniform3ui(location, v0, v1, v2);
            }
        }

        // GLAPI void APIENTRY glUniform4ui (GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
        public static void Uniform4ui(GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
        {
            if (glUniform4ui != null)
            {
                glUniform4ui(location, v0, v1, v2, v3);
            }
        }

        // GLAPI void APIENTRY glUniform1uiv (GLint location, GLsizei count, const GLuint *value)
        public unsafe static void Uniform1uiv(GLint location, GLsizei count, GLuint[] value)
        {
            if (glUniform1uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glUniform1uiv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform2uiv (GLint location, GLsizei count, const GLuint *value)
        public unsafe static void Uniform2uiv(GLint location, GLsizei count, GLuint[] value)
        {
            if (glUniform2uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glUniform2uiv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform3uiv (GLint location, GLsizei count, const GLuint *value)
        public unsafe static void Uniform3uiv(GLint location, GLsizei count, GLuint[] value)
        {
            if (glUniform3uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glUniform3uiv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform4uiv (GLint location, GLsizei count, const GLuint *value)
        public unsafe static void Uniform4uiv(GLint location, GLsizei count, GLuint[] value)
        {
            if (glUniform4uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glUniform4uiv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glTexParameterIiv (GLenum target, GLenum pname, const GLint *params)
        public unsafe static void TexParameterIiv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glTexParameterIiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glTexParameterIiv(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glTexParameterIuiv (GLenum target, GLenum pname, const GLuint *params)
        public unsafe static void TexParameterIuiv(GLenum target, GLenum pname, GLuint[] parameters)
        {
            if (glTexParameterIuiv != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glTexParameterIuiv(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTexParameterIiv (GLenum target, GLenum pname, GLint *params)
        public unsafe static void GetTexParameterIiv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetTexParameterIiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetTexParameterIiv(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTexParameterIuiv (GLenum target, GLenum pname, GLuint *params)
        public unsafe static void GetTexParameterIuiv(GLenum target, GLenum pname, GLuint[] parameters)
        {
            if (glGetTexParameterIuiv != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetTexParameterIuiv(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glClearBufferiv (GLenum buffer, GLint drawbuffer, const GLint *value)
        public unsafe static void ClearBufferiv(GLenum buffer, GLint drawbuffer, GLint[] value)
        {
            if (glClearBufferiv != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glClearBufferiv(buffer, drawbuffer, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glClearBufferuiv (GLenum buffer, GLint drawbuffer, const GLuint *value)
        public unsafe static void ClearBufferuiv(GLenum buffer, GLint drawbuffer, GLuint[] value)
        {
            if (glClearBufferuiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glClearBufferuiv(buffer, drawbuffer, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glClearBufferfv (GLenum buffer, GLint drawbuffer, const GLfloat *value)
        public unsafe static void ClearBufferfv(GLenum buffer, GLint drawbuffer, GLfloat[] value)
        {
            if (glClearBufferfv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glClearBufferfv(buffer, drawbuffer, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glClearBufferfi (GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil)
        public static void ClearBufferfi(GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil)
        {
            if (glClearBufferfi != null)
            {
                glClearBufferfi(buffer, drawbuffer, depth, stencil);
            }
        }

        // GLAPI const GLubyte * APIENTRY glGetStringi (GLenum name, GLuint index)
        public unsafe static string GetStringi(GLenum name, GLuint index)
        {
            if (glGetStringi != null)
            {
                return (new string((sbyte*)glGetStringi(name, index)));
            }
            else
            {
                return null;
            }
        }

        /* OpenGL 3.0 also reuses entry points from these extensions: */
        /* ARB_framebuffer_object */
        // GLAPI GLboolean APIENTRY glIsRenderbuffer (GLuint renderbuffer)
        public static GLboolean IsRenderbuffer(GLuint renderbuffer)
        {
            if (glIsRenderbuffer != null)
            {
                return glIsRenderbuffer(renderbuffer);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glBindRenderbuffer (GLenum target, GLuint renderbuffer)
        public static void BindRenderbuffer(GLenum target, GLuint renderbuffer)
        {
            if (glBindRenderbuffer != null)
            {
                glBindRenderbuffer(target, renderbuffer);
            }
        }

        // GLAPI void APIENTRY glDeleteRenderbuffers (GLsizei n, const GLuint *renderbuffers)
        public unsafe static void DeleteRenderbuffers(GLsizei n, GLuint[] renderbuffers)
        {
            if (glDeleteRenderbuffers != null)
            {
                fixed(GLuint* ptr_renderbuffers = renderbuffers)
                {
                    glDeleteRenderbuffers(n, ptr_renderbuffers);
                }
            }
        }

        // GLAPI void APIENTRY glGenRenderbuffers (GLsizei n, GLuint *renderbuffers)
        public unsafe static void GenRenderbuffers(GLsizei n, GLuint[] renderbuffers)
        {
            if (glGenRenderbuffers != null)
            {
                fixed (GLuint* ptr_renderbuffers = renderbuffers)
                {
                    glGenRenderbuffers(n, ptr_renderbuffers);
                }
            }
        }

        // GLAPI void APIENTRY glRenderbufferStorage (GLenum target, GLenum internalformat, GLsizei width, GLsizei height)
        public static void RenderbufferStorage(GLenum target, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glRenderbufferStorage != null)
            {
                glRenderbufferStorage(target, internalformat, width, height);
            }
        }

        // GLAPI void APIENTRY glGetRenderbufferParameteriv (GLenum target, GLenum pname, GLint *params)
        public unsafe static void GetRenderbufferParameteriv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetRenderbufferParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetRenderbufferParameteriv(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsFramebuffer (GLuint framebuffer)
        public static GLboolean IsFramebuffer(GLuint framebuffer)
        {
            if (glIsFramebuffer != null)
            {
                return glIsFramebuffer(framebuffer);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glBindFramebuffer (GLenum target, GLuint framebuffer)
        public static void BindFramebuffer(GLenum target, GLuint framebuffer)
        {
            if (glBindFramebuffer != null)
            {
                glBindFramebuffer(target, framebuffer);
            }
        }

        // GLAPI void APIENTRY glDeleteFramebuffers (GLsizei n, const GLuint *framebuffers)
        public unsafe static void DeleteFramebuffers(GLsizei n, GLuint[] framebuffers)
        {
            if (glDeleteFramebuffers != null)
            {
                fixed (GLuint* ptr_framebuffers = framebuffers)
                {
                    glDeleteFramebuffers(n, ptr_framebuffers);
                }
            }
        }

        // GLAPI void APIENTRY glGenFramebuffers (GLsizei n, GLuint *framebuffers)
        public unsafe static void GenFramebuffers(GLsizei n, GLuint[] framebuffers)
        {
            if (glGenFramebuffers != null)
            {
                fixed (GLuint* ptr_framebuffers = framebuffers)
                {
                    glGenFramebuffers(n, ptr_framebuffers);
                }
            }
        }

        // GLAPI GLenum APIENTRY glCheckFramebufferStatus (GLenum target)
        public static GLenum CheckFramebufferStatus(GLenum target)
        {
            if (glCheckFramebufferStatus != null)
            {
                return glCheckFramebufferStatus(target);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glFramebufferTexture1D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
        public static void FramebufferTexture1D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
        {
            if (glFramebufferTexture1D != null)
            {
                glFramebufferTexture1D(target, attachment, textarget, texture, level);
            }
        }

        // GLAPI void APIENTRY glFramebufferTexture2D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
        public static void FramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level)
        {
            if (glFramebufferTexture2D != null)
            {
                glFramebufferTexture2D(target, attachment, textarget, texture, level);
            }
        }

        // GLAPI void APIENTRY glFramebufferTexture3D (GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset)
        public static void FramebufferTexture3D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level, GLint zoffset)
        {
            if (glFramebufferTexture3D != null)
            {
                glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
            }
        }

        // GLAPI void APIENTRY glFramebufferRenderbuffer (GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)
        public static void FramebufferRenderbuffer(GLenum target, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)
        {
            if (glFramebufferRenderbuffer != null)
            {
                glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
            }
        }

        // GLAPI void APIENTRY glGetFramebufferAttachmentParameteriv (GLenum target, GLenum attachment, GLenum pname, GLint *params)
        public unsafe static void GetFramebufferAttachmentParameteriv(GLenum target, GLenum attachment, GLenum pname, GLint[] parameters)
        {
            if (glGetFramebufferAttachmentParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetFramebufferAttachmentParameteriv(target, attachment, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGenerateMipmap (GLenum target)
        public static void GenerateMipmap(GLenum target)
        {
            if (glGenerateMipmap != null)
            {
                glGenerateMipmap(target);
            }
        }

        // GLAPI void APIENTRY glBlitFramebuffer (GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)
        public static void BlitFramebuffer(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)
        {
            if (glBlitFramebuffer != null)
            {
                glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
            }
        }

        // GLAPI void APIENTRY glRenderbufferStorageMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)
        public static void RenderbufferStorageMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glRenderbufferStorageMultisample != null)
            {
                glRenderbufferStorageMultisample(target, samples, internalformat, width, height);
            }
        }

        // GLAPI void APIENTRY glFramebufferTextureLayer (GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)
        public static void FramebufferTextureLayer(GLenum target, GLenum attachment, GLuint texture, GLint level, GLint layer)
        {
            if (glFramebufferTextureLayer != null)
            {
                glFramebufferTextureLayer(target, attachment, texture, level, layer);
            }
        }

        /* ARB_map_buffer_range */
        // GLAPI GLvoid* APIENTRY glMapBufferRange (GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access)
        public unsafe static IntPtr MapBufferRange(GLenum target, GLintptr offset, GLsizeiptr length, GLbitfield access)
        {
            if (glMapBufferRange != null)
            {
                return (IntPtr)glMapBufferRange(target, offset, length, access);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // GLAPI void APIENTRY glFlushMappedBufferRange (GLenum target, GLintptr offset, GLsizeiptr length)
        public static void FlushMappedBufferRange(GLenum target, GLintptr offset, GLsizeiptr length)
        {
            if (glFlushMappedBufferRange != null)
            {
                glFlushMappedBufferRange(target, offset, length);
            }
        }

        /* ARB_vertex_array_object */
        // GLAPI void APIENTRY glBindVertexArray (GLuint array)
        public static void BindVertexArray(GLuint array)
        {
            if (glBindVertexArray != null)
            {
                glBindVertexArray(array);
            }
        }

        // GLAPI void APIENTRY glDeleteVertexArrays (GLsizei n, const GLuint *arrays)
        public unsafe static void DeleteVertexArrays(GLsizei n, GLuint[] arrays)
        {
            if (glDeleteVertexArrays != null)
            {
                fixed (GLuint* ptr_arrays = arrays)
                {
                    glDeleteVertexArrays(n, ptr_arrays);
                }
            }
        }

        // GLAPI void APIENTRY glGenVertexArrays (GLsizei n, GLuint *arrays)
        public unsafe static void GenVertexArrays(GLsizei n, GLuint[] arrays)
        {
            if (glGenVertexArrays != null)
            {
                fixed (GLuint* ptr_arrays = arrays)
                {
                    glGenVertexArrays(n, ptr_arrays);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsVertexArray (GLuint array)
        public static GLboolean IsVertexArray(GLuint array)
        {
            if (glIsVertexArray != null)
            {
                return glIsVertexArray(array);
            }
            else
            {
                return false;
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v3.1 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v3.1 WRAPPERS...
        // GLAPI void APIENTRY glDrawArraysInstanced (GLenum mode, GLint first, GLsizei count, GLsizei primcount)
        public static void DrawArraysInstanced(GLenum mode, GLint first, GLsizei count, GLsizei primcount)
        {
            if (glDrawArraysInstanced != null)
            {
                glDrawArraysInstanced(mode, first, count, primcount);
            }
        }

        // GLAPI void APIENTRY glDrawElementsInstanced (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLsizei primcount)
        public unsafe static void DrawElementsInstanced(GLenum mode, GLsizei count, GLenum type, IntPtr indices, GLsizei primcount)
        {
            if (glDrawElementsInstanced != null)
            {
                glDrawElementsInstanced(mode, count, type, indices.ToPointer(), primcount);
            }
        }

        // GLAPI void APIENTRY glTexBuffer (GLenum target, GLenum internalformat, GLuint buffer)
        public static void TexBuffer(GLenum target, GLenum internalformat, GLuint buffer)
        {
            if (glTexBuffer != null)
            {
                glTexBuffer(target, internalformat, buffer);
            }
        }

        // GLAPI void APIENTRY glPrimitiveRestartIndex (GLuint index)
        /* OpenGL 3.1 also reuses entry points from these extensions: */
        /* ARB_copy_buffer */
        // GLAPI void APIENTRY glCopyBufferSubData (GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size)
        public static void CopyBufferSubData(GLenum readTarget, GLenum writeTarget, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size)
        {
            if (glCopyBufferSubData != null)
            {
                glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
            }
        }

        /* ARB_uniform_buffer_object */
        // GLAPI void APIENTRY glGetUniformIndices (GLuint program, GLsizei uniformCount, const GLchar* *uniformNames, GLuint *uniformIndices)
        public unsafe static void GetUniformIndices(GLuint program, GLsizei uniformCount, string[] uniformNames, GLuint[] uniformIndices)
        {
            IntPtr strptrtable = BuildStringIntPtrTable(uniformNames);

            fixed (GLuint* ptr_uniformIndices = uniformIndices)
            {
                glGetUniformIndices(program, uniformCount, (GLchar**)strptrtable, ptr_uniformIndices);
            }

            Marshal.FreeHGlobal(strptrtable);
        }

        // GLAPI void APIENTRY glGetActiveUniformsiv (GLuint program, GLsizei uniformCount, const GLuint *uniformIndices, GLenum pname, GLint *params)
        public unsafe static void GetActiveUniformsiv(GLuint program, GLsizei uniformCount, GLuint[] uniformIndices, GLenum pname, GLint[] parameters)
        {
            if (glGetActiveUniformsiv != null)
            {
                fixed (GLuint* ptr_indices = uniformIndices)
                {
                    fixed (GLint* ptr_parameters = parameters)
                    {
                        glGetActiveUniformsiv(program, uniformCount, ptr_indices, pname, ptr_parameters);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetActiveUniformName (GLuint program, GLuint uniformIndex, GLsizei bufSize, GLsizei *length, GLchar *uniformName)
        public unsafe static void GetActiveUniformName(GLuint program, GLuint uniformIndex, GLsizei bufSize, GLsizei[] length, GLchar[] uniformName)
        {
            if (glGetActiveUniformName != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_name = uniformName)
                    {
                        glGetActiveUniformName(program, uniformIndex, bufSize, ptr_length, ptr_name);
                    }
                }
            }
        }

        // GLAPI GLuint APIENTRY glGetUniformBlockIndex (GLuint program, const GLchar *uniformBlockName)
        public unsafe static void GetUniformBlockIndex(GLuint program, string uniformBlockName)
        {
            if (glGetUniformBlockIndex != null)
            {
                glGetUniformBlockIndex(program, uniformBlockName);
            }
        }

        // GLAPI void APIENTRY glGetActiveUniformBlockiv (GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint *params)
        public unsafe static void GetActiveUniformBlockiv(GLuint program, GLuint uniformBlockIndex, GLenum pname, GLint[] parameters)
        {
            if (glGetActiveUniformBlockiv != null)
            {
                fixed(GLint* ptr_parameters = parameters)
                {
                    glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetActiveUniformBlockName (GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei *length, GLchar *uniformBlockName)
        public unsafe static void GetActiveUniformBlockName(GLuint program, GLuint uniformBlockIndex, GLsizei bufSize, GLsizei[] length, GLchar[] uniformBlockName)
        {
            if (glGetActiveUniformBlockName != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_name = uniformBlockName)
                    {
                        glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, ptr_length, ptr_name);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glUniformBlockBinding (GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding)
        public static void UniformBlockBinding(GLuint program, GLuint uniformBlockIndex, GLuint uniformBlockBinding)
        {
            if (glUniformBlockBinding != null)
            {
                glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v3.2 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v3.2 WRAPPERS...
        // GLAPI void APIENTRY glGetInteger64i_v (GLenum target, GLuint index, GLint64 *data)
        public unsafe static void GetInteger64i_v(GLenum target, GLuint index, GLint64[] data)
        {
            if (glGetInteger64i_v != null)
            {
                fixed (GLint64* ptr_data = data)
                {
                    glGetInteger64i_v(target, index, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetBufferParameteri64v (GLenum target, GLenum pname, GLint64 *params)
        public unsafe static void GetBufferParameteri64v(GLenum target, GLenum pname, GLint64[] parameters)
        {
            if (glGetBufferParameteri64v != null)
            {
                fixed (GLint64* ptr_parameters = parameters)
                {
                    glGetBufferParameteri64v(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glFramebufferTexture (GLenum target, GLenum attachment, GLuint texture, GLint level)
        public static void FramebufferTexture(GLenum target, GLenum attachment, GLuint texture, GLint level)
        {
            if (glFramebufferTexture != null)
            {
                glFramebufferTexture(target, attachment, texture, level);
            }
        }

        /* OpenGL 3.2 also reuses entry points from these extensions: */
        /* ARB_draw_elements_base_vertex */
        // GLAPI void APIENTRY glDrawElementsBaseVertex (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLint basevertex)
        public unsafe static void DrawElementsBaseVertex(GLenum mode, GLsizei count, GLenum type, IntPtr indices, GLint basevertex)
        {
            if (glDrawElementsBaseVertex != null)
            {
                glDrawElementsBaseVertex(mode, count, type, indices.ToPointer(), basevertex);
            }
        }

        // GLAPI void APIENTRY glDrawRangeElementsBaseVertex (GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, const GLvoid *indices, GLint basevertex)
        public unsafe static void DrawRangeElementsBaseVertex(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, IntPtr indices, GLint basevertex)
        {
            if (glDrawRangeElementsBaseVertex != null)
            {
                glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices.ToPointer(), basevertex);
            }
        }

        // GLAPI void APIENTRY glDrawElementsInstancedBaseVertex (GLenum mode, GLsizei count, GLenum type, const GLvoid *indices, GLsizei primcount, GLint basevertex)
        public unsafe static void DrawElementsInstancedBaseVertex(GLenum mode, GLsizei count, GLenum type, IntPtr indices, GLsizei primcount, GLint basevertex)
        {
            if (glDrawElementsInstancedBaseVertex != null)
            {
                glDrawElementsInstancedBaseVertex(mode, count, type, indices.ToPointer(), primcount, basevertex);
            }
        }

        // GLAPI void APIENTRY glMultiDrawElementsBaseVertex (GLenum mode, const GLsizei *count, GLenum type, const GLvoid* *indices, GLsizei primcount, const GLint *basevertex)
        public unsafe static void MultiDrawElementsBaseVertex(GLenum mode, GLsizei[] count, GLenum type, IntPtr[] indices, GLsizei primcount, GLint[] basevertex)
        {
            if (glMultiDrawElementsBaseVertex != null)
            {
                fixed (GLsizei* ptr_count = count)
                {
                    fixed (IntPtr* ptr_indices = indices)
                    {
                        fixed (GLint* ptr_basevertex = basevertex)
                        {
                            glMultiDrawElementsBaseVertex(mode, ptr_count, type, (void**)ptr_indices, primcount, ptr_basevertex);
                        }
                    }
                }
            }
        }

        /* ARB_provoking_vertex */
        // GLAPI void APIENTRY glProvokingVertex (GLenum mode)
        public static void ProvokingVertex(GLenum mode)
        {
            if (glProvokingVertex != null)
            {
                glProvokingVertex(mode);
            }
        }

        /* ARB_sync */
        // GLAPI GLsync APIENTRY glFenceSync (GLenum condition, GLbitfield flags)
        public static GLsync FenceSync(GLenum condition, GLbitfield flags)
        {
            if (glFenceSync != null)
            {
                return glFenceSync(condition, flags);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLboolean APIENTRY glIsSync (GLsync sync)
        public static GLboolean IsSync(GLsync sync)
        {
            if (glIsSync != null)
            {
                return glIsSync(sync);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glDeleteSync (GLsync sync)
        public static void DeleteSync(GLsync sync)
        {
            if (glDeleteSync != null)
            {
                glDeleteSync(sync);
            }
        }

        // GLAPI GLenum APIENTRY glClientWaitSync (GLsync sync, GLbitfield flags, GLuint64 timeout)
        public static GLenum ClientWaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout)
        {
            if (glClientWaitSync != null)
            {
                return glClientWaitSync(sync, flags, timeout);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glWaitSync (GLsync sync, GLbitfield flags, GLuint64 timeout)
        public static void WaitSync(GLsync sync, GLbitfield flags, GLuint64 timeout)
        {
            if (glWaitSync != null)
            {
                glWaitSync(sync, flags, timeout);
            }
        }

        // GLAPI void APIENTRY glGetInteger64v (GLenum pname, GLint64 *params)
        public unsafe static void GetInteger64v(GLenum pname, GLint64[] parameters)
        {
            if (glGetInteger64v != null)
            {
                fixed (GLint64* ptr_parameters = parameters)
                {
                    glGetInteger64v(pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetSynciv (GLsync sync, GLenum pname, GLsizei bufSize, GLsizei *length, GLint *values)
        public unsafe static void GetSynciv(GLsync sync, GLenum pname, GLsizei bufSize, GLsizei[] length, GLint[] values)
        {
            if (glGetSynciv != null)
            {
                fixed(GLsizei* ptr_length = length)
                {
                    fixed (GLint* ptr_values = values)
                    {
                        glGetSynciv(sync, pname, bufSize, ptr_length, ptr_values);
                    }
                }
            }
        }

        /* ARB_texture_multisample */
        // GLAPI void APIENTRY glTexImage2DMultisample (GLenum target, GLsizei samples, GLint internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
        public static void TexImage2DMultisample(GLenum target, GLsizei samples, GLint internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
        {
            if (glTexImage2DMultisample != null)
            {
                glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
            }
        }

        // GLAPI void APIENTRY glTexImage3DMultisample (GLenum target, GLsizei samples, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
        public static void TexImage3DMultisample(GLenum target, GLsizei samples, GLint internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
        {
            if (glTexImage3DMultisample != null)
            {
                glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
            }
        }

        // GLAPI void APIENTRY glGetMultisamplefv (GLenum pname, GLuint index, GLfloat *val)
        public unsafe static void GetMultisamplefv(GLenum pname, GLuint index, GLfloat[] val)
        {
            if (glGetMultisamplefv != null)
            {
                fixed (GLfloat* ptr_val = val)
                {
                    glGetMultisamplefv(pname, index, ptr_val);
                }
            }
        }

        // GLAPI void APIENTRY glSampleMaski (GLuint index, GLbitfield mask)
        public static void SampleMaski(GLuint index, GLbitfield mask)
        {
            if (glSampleMaski != null)
            {
                glSampleMaski(index, mask);
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v3.3 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v3.3 WRAPPERS...
        // GLAPI void APIENTRY glVertexAttribDivisor (GLuint index, GLuint divisor)
        public static void VertexAttribDivisor(GLuint index, GLuint divisor)
        {
            if (glVertexAttribDivisor != null)
            {
                glVertexAttribDivisor(index, divisor);
            }
        }

        /* OpenGL 3.3 also reuses entry points from these extensions: */
        /* ARB_blend_func_extended */
        // GLAPI void APIENTRY glBindFragDataLocationIndexed (GLuint program, GLuint colorNumber, GLuint index, const GLchar *name)
        public static void BindFragDataLocationIndexed(GLuint program, GLuint colorNumber, GLuint index, string name)
        {
            if (glBindFragDataLocationIndexed != null)
            {
                glBindFragDataLocationIndexed(program, colorNumber, index, name);
            }
        }

        // GLAPI GLint APIENTRY glGetFragDataIndex (GLuint program, const GLchar *name)
        public static GLint GetFragDataIndex(GLuint program, string name)
        {
            if (glGetFragDataIndex != null)
            {
                return glGetFragDataIndex(program, name);
            }
            else
            {
                return 0;
            }
        }

        /* ARB_sampler_objects */
        // GLAPI void APIENTRY glGenSamplers (GLsizei count, GLuint *samplers)
        public unsafe static void GenSamplers(GLsizei count, GLuint[] samplers)
        {
            if (glGenSamplers != null)
            {
                fixed (GLuint* ptr_samplers = samplers)
                {
                    glGenSamplers(count, ptr_samplers);
                }
            }
        }

        // GLAPI void APIENTRY glDeleteSamplers (GLsizei count, const GLuint *samplers)
        public unsafe static void DeleteSamplers(GLsizei count, GLuint[] samplers)
        {
            if (glDeleteSamplers != null)
            {
                fixed (GLuint* ptr_samplers = samplers)
                {
                    glDeleteSamplers(count, ptr_samplers);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsSampler (GLuint sampler)
        public static GLboolean IsSampler(GLuint sampler)
        {
            if (glIsSampler != null)
            {
                return glIsSampler(sampler);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glBindSampler (GLuint unit, GLuint sampler)
        public static void BindSampler(GLuint unit, GLuint sampler)
        {
            if (glBindSampler != null)
            {
                glBindSampler(unit, sampler);
            }
        }

        // GLAPI void APIENTRY glSamplerParameteri (GLuint sampler, GLenum pname, GLint param)
        public static void SamplerParameteri(GLuint sampler, GLenum pname, GLint param)
        {
            if (glSamplerParameteri != null)
            {
                glSamplerParameteri(sampler, pname, param);
            }
        }

        // GLAPI void APIENTRY glSamplerParameteriv (GLuint sampler, GLenum pname, const GLint *param)
        public unsafe static void SamplerParameteriv(GLuint sampler, GLenum pname, GLint[] param)
        {
            if (glSamplerParameteriv != null)
            {
                fixed (GLint* ptr_param = param)
                {
                    glSamplerParameteriv(sampler, pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glSamplerParameterf (GLuint sampler, GLenum pname, GLfloat param)
        public static void SamplerParameterf(GLuint sampler, GLenum pname, GLfloat param)
        {
            if (glSamplerParameterf != null)
            {
                glSamplerParameterf(sampler, pname, param);
            }
        }

        // GLAPI void APIENTRY glSamplerParameterfv (GLuint sampler, GLenum pname, const GLfloat *param)
        public unsafe static void SamplerParameterfv(GLuint sampler, GLenum pname, GLfloat[] param)
        {
            if (glSamplerParameterfv != null)
            {
                fixed (GLfloat* ptr_param = param)
                {
                    glSamplerParameterfv(sampler, pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glSamplerParameterIiv (GLuint sampler, GLenum pname, const GLint *param)
        public unsafe static void SamplerParameterIiv(GLuint sampler, GLenum pname, GLint[] param)
        {
            if (glSamplerParameterIiv != null)
            {
                fixed (GLint* ptr_param = param)
                {
                    glSamplerParameterIiv(sampler, pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glSamplerParameterIuiv (GLuint sampler, GLenum pname, const GLuint *param)
        public unsafe static void SamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint[] param)
        {
            if (glSamplerParameterIuiv != null)
            {
                fixed (GLuint* ptr_param = param)
                {
                    glSamplerParameterIuiv(sampler, pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glGetSamplerParameteriv (GLuint sampler, GLenum pname, GLint *params)
        public unsafe static void GetSamplerParameteriv(GLuint sampler, GLenum pname, GLint[] parameters)
        {
            if (glGetSamplerParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetSamplerParameteriv(sampler, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetSamplerParameterIiv (GLuint sampler, GLenum pname, GLint *params)
        public unsafe static void GetSamplerParameterIiv(GLuint sampler, GLenum pname, GLint[] parameters)
        {
            if (glGetSamplerParameterIiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetSamplerParameterIiv(sampler, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetSamplerParameterfv (GLuint sampler, GLenum pname, GLfloat *params)
        public unsafe static void GetSamplerParameterfv(GLuint sampler, GLenum pname, GLfloat[] parameters)
        {
            if (glGetSamplerParameterfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetSamplerParameterfv(sampler, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetSamplerParameterIuiv (GLuint sampler, GLenum pname, GLuint *params)
        public unsafe static void GetSamplerParameterIuiv(GLuint sampler, GLenum pname, GLuint[] parameters)
        {
            if (glGetSamplerParameterIuiv != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetSamplerParameterIuiv(sampler, pname, ptr_parameters);
                }
            }
        }

        /* ARB_explicit_attrib_location (no entry points) */
        /* ARB_occlusion_query2 (no entry points) */
        /* ARB_shader_bit_encoding (no entry points) */
        /* ARB_texture_rgb10_a2ui (no entry points) */
        /* ARB_texture_swizzle (no entry points) */
        /* ARB_timer_query */
        // GLAPI void APIENTRY glQueryCounter (GLuint id, GLenum target)
        public static void QueryCounter(GLuint id, GLenum target)
        {
            if (glQueryCounter != null)
            {
                glQueryCounter(id, target);
            }
        }

        // GLAPI void APIENTRY glGetQueryObjecti64v (GLuint id, GLenum pname, GLint64 *params)
        public unsafe static void GetQueryObjecti64v(GLuint id, GLenum pname, GLint64[] parameters)
        {
            if (glGetQueryObjecti64v != null)
            {
                fixed (GLint64* ptr_parameters = parameters)
                {
                    glGetQueryObjecti64v(id, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetQueryObjectui64v (GLuint id, GLenum pname, GLuint64 *params)
        public unsafe static void GetQueryObjectui64v(GLuint id, GLenum pname, GLuint64[] parameters)
        {
            if (glGetQueryObjectui64v != null)
            {
                fixed (GLuint64* ptr_parameters = parameters)
                {
                    glGetQueryObjectui64v(id, pname, ptr_parameters);
                }
            }
        }

        /* ARB_vertex_type_2_10_10_10_rev */
        // GLAPI void APIENTRY glVertexP2ui (GLenum type, GLuint value)
        public static void VertexP2ui(GLenum type, GLuint value)
        {
            if (glVertexP2ui != null)
            {
                glVertexP2ui(type, value);
            }
        }

        // GLAPI void APIENTRY glVertexP2uiv (GLenum type, const GLuint *value)
        public unsafe static void VertexP2uiv(GLenum type, GLuint[] value)
        {
            if (glVertexP2uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glVertexP2uiv(type, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glVertexP3ui (GLenum type, GLuint value)
        public static void VertexP3ui(GLenum type, GLuint value)
        {
            if (glVertexP3ui != null)
            {
                glVertexP3ui(type, value);
            }
        }

        // GLAPI void APIENTRY glVertexP3uiv (GLenum type, const GLuint *value)
        public unsafe static void VertexP3uiv(GLenum type, GLuint[] value)
        {
            if (glVertexP3uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glVertexP3uiv(type, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glVertexP4ui (GLenum type, GLuint value)
        public static void VertexP4ui(GLenum type, GLuint value)
        {
            if (glVertexP4ui != null)
            {
                glVertexP4ui(type, value);
            }
        }

        // GLAPI void APIENTRY glVertexP4uiv (GLenum type, const GLuint *value)
        public unsafe static void VertexP4uiv(GLenum type, GLuint[] value)
        {
            if (glVertexP4uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glVertexP4uiv(type, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoordP1ui (GLenum type, GLuint coords)
        public static void TexCoordP1ui(GLenum type, GLuint coords)
        {
            if (glTexCoordP1ui != null)
            {
                glTexCoordP1ui(type, coords);
            }
        }

        // GLAPI void APIENTRY glTexCoordP1uiv (GLenum type, const GLuint *coords)
        public unsafe static void TexCoordP1uiv(GLenum type, GLuint[] coords)
        {
            if (glTexCoordP1uiv != null)
            {
                fixed (GLuint* ptr_coords = coords)
                {
                    glTexCoordP1uiv(type, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoordP2ui (GLenum type, GLuint coords)
        public static void TexCoordP2ui(GLenum type, GLuint coords)
        {
            if (glTexCoordP2ui != null)
            {
                glTexCoordP2ui(type, coords);
            }
        }

        // GLAPI void APIENTRY glTexCoordP2uiv (GLenum type, const GLuint *coords)
        public unsafe static void TexCoordP2uiv(GLenum type, GLuint[] coords)
        {
            if (glTexCoordP2uiv != null)
            {
                fixed (GLuint* ptr_coords = coords)
                {
                    glTexCoordP2uiv(type, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoordP3ui (GLenum type, GLuint coords)
        public static void TexCoordP3ui(GLenum type, GLuint coords)
        {
            if (glTexCoordP3ui != null)
            {
                glTexCoordP3ui(type, coords);
            }
        }

        // GLAPI void APIENTRY glTexCoordP3uiv (GLenum type, const GLuint *coords)
        public unsafe static void TexCoordP3uiv(GLenum type, GLuint[] coords)
        {
            if (glTexCoordP3uiv != null)
            {
                fixed (GLuint* ptr_coords = coords)
                {
                    glTexCoordP3uiv(type, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glTexCoordP4ui (GLenum type, GLuint coords)
        public static void TexCoordP4ui(GLenum type, GLuint coords)
        {
            if (glTexCoordP4ui != null)
            {
                glTexCoordP4ui(type, coords);
            }
        }

        // GLAPI void APIENTRY glTexCoordP4uiv (GLenum type, const GLuint *coords)
        public unsafe static void TexCoordP4uiv(GLenum type, GLuint[] coords)
        {
            if (glTexCoordP4uiv != null)
            {
                fixed (GLuint* ptr_coords = coords)
                {
                    glTexCoordP4uiv(type, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoordP1ui (GLenum texture, GLenum type, GLuint coords)
        public static void MultiTexCoordP1ui(GLenum texture, GLenum type, GLuint coords)
        {
            if (glMultiTexCoordP1ui != null)
            {
                glMultiTexCoordP1ui(texture, type, coords);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoordP1uiv (GLenum texture, GLenum type, const GLuint *coords)
        public unsafe static void MultiTexCoordP1uiv(GLenum texture, GLenum type, GLuint[] coords)
        {
            if (glMultiTexCoordP1uiv != null)
            {
                fixed (GLuint* ptr_coords = coords)
                {
                    glMultiTexCoordP1uiv(texture, type, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoordP2ui (GLenum texture, GLenum type, GLuint coords)
        public static void MultiTexCoordP2ui(GLenum texture, GLenum type, GLuint coords)
        {
            if (glMultiTexCoordP2ui != null)
            {
                glMultiTexCoordP2ui(texture, type, coords);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoordP2uiv (GLenum texture, GLenum type, const GLuint *coords)
        public unsafe static void MultiTexCoordP2uiv(GLenum texture, GLenum type, GLuint[] coords)
        {
            if (glMultiTexCoordP2uiv != null)
            {
                fixed (GLuint* ptr_coords = coords)
                {
                    glMultiTexCoordP2uiv(texture, type, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoordP3ui (GLenum texture, GLenum type, GLuint coords)
        public static void MultiTexCoordP3ui(GLenum texture, GLenum type, GLuint coords)
        {
            if (glMultiTexCoordP3ui != null)
            {
                glMultiTexCoordP3ui(texture, type, coords);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoordP3uiv (GLenum texture, GLenum type, const GLuint *coords)
        public unsafe static void MultiTexCoordP3uiv(GLenum texture, GLenum type, GLuint[] coords)
        {
            if (glMultiTexCoordP3uiv != null)
            {
                fixed (GLuint* ptr_coords = coords)
                {
                    glMultiTexCoordP3uiv(texture, type, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glMultiTexCoordP4ui (GLenum texture, GLenum type, GLuint coords)
        public static void MultiTexCoordP4ui(GLenum texture, GLenum type, GLuint coords)
        {
            if (glMultiTexCoordP4ui != null)
            {
                glMultiTexCoordP4ui(texture, type, coords);
            }
        }

        // GLAPI void APIENTRY glMultiTexCoordP4uiv (GLenum texture, GLenum type, const GLuint *coords)
        public unsafe static void MultiTexCoordP4uiv(GLenum texture, GLenum type, GLuint[] coords)
        {
            if (glMultiTexCoordP4uiv != null)
            {
                fixed (GLuint* ptr_coords = coords)
                {
                    glMultiTexCoordP4uiv(texture, type, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glNormalP3ui (GLenum type, GLuint coords)
        public static void NormalP3ui(GLenum type, GLuint coords)
        {
            if (glNormalP3ui != null)
            {
                glNormalP3ui(type, coords);
            }
        }

        // GLAPI void APIENTRY glNormalP3uiv (GLenum type, const GLuint *coords)
        public unsafe static void NormalP3uiv(GLenum type, GLuint[] coords)
        {
            if (glNormalP3uiv != null)
            {
                fixed (GLuint* ptr_coords = coords)
                {
                    glNormalP3uiv(type, ptr_coords);
                }
            }
        }

        // GLAPI void APIENTRY glColorP3ui (GLenum type, GLuint color)
        public static void ColorP3ui(GLenum type, GLuint color)
        {
            if (glColorP3ui != null)
            {
                glColorP3ui(type, color);
            }
        }

        // GLAPI void APIENTRY glColorP3uiv (GLenum type, const GLuint *color)
        public unsafe static void ColorP3uiv(GLenum type, GLuint[] color)
        {
            if (glColorP3uiv != null)
            {
                fixed (GLuint* ptr_color = color)
                {
                    glColorP3uiv(type, ptr_color);
                }
            }
        }

        // GLAPI void APIENTRY glColorP4ui (GLenum type, GLuint color)
        public static void ColorP4ui(GLenum type, GLuint color)
        {
            if (glColorP4ui != null)
            {
                glColorP4ui(type, color);
            }
        }

        // GLAPI void APIENTRY glColorP4uiv (GLenum type, const GLuint *color)
        public unsafe static void ColorP4uiv(GLenum type, GLuint[] color)
        {
            if (glColorP4uiv != null)
            {
                fixed (GLuint* ptr_color = color)
                {
                    glColorP4uiv(type, ptr_color);
                }
            }
        }

        // GLAPI void APIENTRY glSecondaryColorP3ui (GLenum type, GLuint color)
        public static void SecondaryColorP3ui(GLenum type, GLuint color)
        {
            if (glSecondaryColorP3ui != null)
            {
                glSecondaryColorP3ui(type, color);
            }
        }

        // GLAPI void APIENTRY glSecondaryColorP3uiv (GLenum type, const GLuint *color)
        public unsafe static void SecondaryColorP3uiv(GLenum type, GLuint[] color)
        {
            if (glSecondaryColorP3uiv != null)
            {
                fixed (GLuint* ptr_color = color)
                {
                    glSecondaryColorP3uiv(type, ptr_color);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribP1ui (GLuint index, GLenum type, GLboolean normalized, GLuint value)
        public static void VertexAttribP1ui(GLuint index, GLenum type, GLboolean normalized, GLuint value)
        {
            if (glVertexAttribP1ui != null)
            {
                glVertexAttribP1ui(index, type, normalized, value);
            }
        }

        // GLAPI void APIENTRY glVertexAttribP1uiv (GLuint index, GLenum type, GLboolean normalized, const GLuint *value)
        public unsafe static void VertexAttribP1uiv(GLuint index, GLenum type, GLboolean normalized, GLuint[] value)
        {
            if (glVertexAttribP1uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glVertexAttribP1uiv(index, type, normalized, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribP2ui (GLuint index, GLenum type, GLboolean normalized, GLuint value)
        public static void VertexAttribP2ui(GLuint index, GLenum type, GLboolean normalized, GLuint value)
        {
            if (glVertexAttribP2ui != null)
            {
                glVertexAttribP2ui(index, type, normalized, value);
            }
        }

        // GLAPI void APIENTRY glVertexAttribP2uiv (GLuint index, GLenum type, GLboolean normalized, const GLuint *value)
        public unsafe static void VertexAttribP2uiv(GLuint index, GLenum type, GLboolean normalized, GLuint[] value)
        {
            if (glVertexAttribP2uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glVertexAttribP2uiv(index, type, normalized, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribP3ui (GLuint index, GLenum type, GLboolean normalized, GLuint value)
        public static void VertexAttribP3ui(GLuint index, GLenum type, GLboolean normalized, GLuint value)
        {
            if (glVertexAttribP3ui != null)
            {
                glVertexAttribP3ui(index, type, normalized, value);
            }
        }

        // GLAPI void APIENTRY glVertexAttribP3uiv (GLuint index, GLenum type, GLboolean normalized, const GLuint *value)
        public unsafe static void VertexAttribP3uiv(GLuint index, GLenum type, GLboolean normalized, GLuint[] value)
        {
            if (glVertexAttribP3uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glVertexAttribP3uiv(index, type, normalized, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribP4ui (GLuint index, GLenum type, GLboolean normalized, GLuint value)
        public static void VertexAttribP4ui(GLuint index, GLenum type, GLboolean normalized, GLuint value)
        {
            if (glVertexAttribP4ui != null)
            {
                glVertexAttribP4ui(index, type, normalized, value);
            }
        }

        // GLAPI void APIENTRY glVertexAttribP4uiv (GLuint index, GLenum type, GLboolean normalized, const GLuint *value)
        public unsafe static void VertexAttribP4uiv(GLuint index, GLenum type, GLboolean normalized, GLuint[] value)
        {
            if (glVertexAttribP4uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glVertexAttribP4uiv(index, type, normalized, ptr_value);
                }
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v4.0 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v4.0 WRAPPERS...
        // GLAPI void APIENTRY glMinSampleShading (GLclampf value)
        public static void MinSampleShading(GLclampf value)
        {
            if (glMinSampleShading != null)
            {
                glMinSampleShading(value);
            }
        }

        // GLAPI void APIENTRY glBlendEquationi (GLuint buf, GLenum mode)
        public static void BlendEquationi(GLuint buf, GLenum mode)
        {
            if (glBlendEquationi != null)
            {
                glBlendEquationi(buf, mode);
            }
        }

        // GLAPI void APIENTRY glBlendEquationSeparatei (GLuint buf, GLenum modeRGB, GLenum modeAlpha)
        public static void BlendEquationSeparatei(GLuint buf, GLenum modeRGB, GLenum modeAlpha)
        {
            if (glBlendEquationSeparatei != null)
            {
                glBlendEquationSeparatei(buf, modeRGB, modeAlpha);
            }
        }

        // GLAPI void APIENTRY glBlendFunci (GLuint buf, GLenum src, GLenum dst)
        public static void BlendFunci(GLuint buf, GLenum src, GLenum dst)
        {
            if (glBlendFunci != null)
            {
                glBlendFunci(buf, src, dst);
            }
        }

        // GLAPI void APIENTRY glBlendFuncSeparatei (GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha)
        public static void BlendFuncSeparatei(GLuint buf, GLenum srcRGB, GLenum dstRGB, GLenum srcAlpha, GLenum dstAlpha)
        {
            if (glBlendFuncSeparatei != null)
            {
                glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
            }
        }

        /* OpenGL 4.0 also reuses entry points from these extensions: */
        /* ARB_texture_query_lod (no entry points) */
        /* ARB_draw_indirect */
        // GLAPI void APIENTRY glDrawArraysIndirect (GLenum mode, const GLvoid *indirect)
        public unsafe static void DrawArraysIndirect(GLenum mode, IntPtr indirect)
        {
            if (glDrawArraysIndirect != null)
            {
                glDrawArraysIndirect(mode, indirect.ToPointer());
            }
        }

        // GLAPI void APIENTRY glDrawElementsIndirect (GLenum mode, GLenum type, const GLvoid *indirect)
        public unsafe static void DrawElementsIndirect(GLenum mode, GLenum type, IntPtr indirect)
        {
            if (glDrawElementsIndirect != null)
            {
                glDrawElementsIndirect(mode, type, indirect.ToPointer());
            }
        }

        /* ARB_gpu_shader5 (no entry points) */
        /* ARB_gpu_shader_fp64 */
        // GLAPI void APIENTRY glUniform1d (GLint location, GLdouble x)
        public static void Uniform1d(GLint location, GLdouble x)
        {
            if (glUniform1d != null)
            {
                glUniform1d(location, x);
            }
        }

        // GLAPI void APIENTRY glUniform2d (GLint location, GLdouble x, GLdouble y)
        public static void Uniform2d(GLint location, GLdouble x, GLdouble y)
        {
            if (glUniform2d != null)
            {
                glUniform2d(location, x, y);
            }
        }

        // GLAPI void APIENTRY glUniform3d (GLint location, GLdouble x, GLdouble y, GLdouble z)
        public static void Uniform3d(GLint location, GLdouble x, GLdouble y, GLdouble z)
        {
            if (glUniform3d != null)
            {
                glUniform3d(location, x, y, z);
            }
        }

        // GLAPI void APIENTRY glUniform4d (GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        public static void Uniform4d(GLint location, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glUniform4d != null)
            {
                glUniform4d(location, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glUniform1dv (GLint location, GLsizei count, const GLdouble *value)
        public unsafe static void Uniform1dv(GLint location, GLsizei count, GLdouble[] value)
        {
            if (glUniform1dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glUniform1dv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform2dv (GLint location, GLsizei count, const GLdouble *value)
        public unsafe static void Uniform2dv(GLint location, GLsizei count, GLdouble[] value)
        {
            if (glUniform2dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glUniform2dv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform3dv (GLint location, GLsizei count, const GLdouble *value)
        public unsafe static void Uniform3dv(GLint location, GLsizei count, GLdouble[] value)
        {
            if (glUniform3dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glUniform3dv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniform4dv (GLint location, GLsizei count, const GLdouble *value)
        public unsafe static void Uniform4dv(GLint location, GLsizei count, GLdouble[] value)
        {
            if (glUniform4dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glUniform4dv(location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix2dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void UniformMatrix2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glUniformMatrix2dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glUniformMatrix2dv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix3dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void UniformMatrix3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glUniformMatrix3dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glUniformMatrix3dv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix4dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void UniformMatrix4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glUniformMatrix4dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glUniformMatrix4dv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix2x3dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void UniformMatrix2x3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glUniformMatrix2x3dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glUniformMatrix2x3dv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix2x4dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void UniformMatrix2x4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glUniformMatrix2x4dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glUniformMatrix2x4dv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix3x2dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void UniformMatrix3x2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glUniformMatrix3x2dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glUniformMatrix3x2dv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix3x4dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void UniformMatrix3x4dv(GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glUniformMatrix3x4dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glUniformMatrix3x4dv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix4x2dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void UniformMatrix4x2dv(GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glUniformMatrix4x2dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glUniformMatrix4x2dv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glUniformMatrix4x3dv (GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void UniformMatrix4x3dv(GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glUniformMatrix4x3dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glUniformMatrix4x3dv(location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glGetUniformdv (GLuint program, GLint location, GLdouble *params)
        public unsafe static void GetUniformdv(GLuint program, GLint location, GLdouble[] parameters)
        {
            if (glGetUniformdv != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetUniformdv(program, location, ptr_parameters);
                }
            }
        }

        /* ARB_shader_subroutine */
        // GLAPI GLint APIENTRY glGetSubroutineUniformLocation (GLuint program, GLenum shadertype, const GLchar *name)
        public static GLint GetSubroutineUniformLocation(GLuint program, GLenum shadertype, string name)
        {
            if (glGetSubroutineUniformLocation != null)
            {
                return glGetSubroutineUniformLocation(program, shadertype, name);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLuint APIENTRY glGetSubroutineIndex (GLuint program, GLenum shadertype, const GLchar *name)
        public static GLuint GetSubroutineIndex(GLuint program, GLenum shadertype, string name)
        {
            if (glGetSubroutineIndex != null)
            {
                return glGetSubroutineIndex(program, shadertype, name);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glGetActiveSubroutineUniformiv (GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint *values)
        public unsafe static void GetActiveSubroutineUniformiv(GLuint program, GLenum shadertype, GLuint index, GLenum pname, GLint[] values)
        {
            if (glGetActiveSubroutineUniformiv != null)
            {
                fixed (GLint* ptr_values = values)
                {
                    glGetActiveSubroutineUniformiv(program, shadertype, index, pname, ptr_values);
                }
            }
        }

        // GLAPI void APIENTRY glGetActiveSubroutineUniformName (GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei *length, GLchar *name)
        public unsafe static void GetActiveSubroutineUniformName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei[] length, GLchar[] name)
        {
            if (glGetActiveSubroutineUniformName != null)
            {
                fixed(GLsizei* ptr_length = length)
                {
                    fixed(GLchar* ptr_name = name)
                    {
                        glGetActiveSubroutineUniformName(program, shadertype, index, bufsize, ptr_length, ptr_name);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetActiveSubroutineName (GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei *length, GLchar *name)
        public unsafe static void GetActiveSubroutineName(GLuint program, GLenum shadertype, GLuint index, GLsizei bufsize, GLsizei[] length, GLchar[] name)
        {
            if (glGetActiveSubroutineName != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_name = name)
                    {
                        glGetActiveSubroutineName(program, shadertype, index, bufsize, ptr_length, ptr_name);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glUniformSubroutinesuiv (GLenum shadertype, GLsizei count, const GLuint *indices)
        public unsafe static void UniformSubroutinesuiv(GLenum shadertype, GLsizei count, GLuint[] indices)
        {
            if (glUniformSubroutinesuiv != null)
            {
                fixed (GLuint* ptr_indices = indices)
                {
                    glUniformSubroutinesuiv(shadertype, count, ptr_indices);
                }
            }
        }

        // GLAPI void APIENTRY glGetUniformSubroutineuiv (GLenum shadertype, GLint location, GLuint *params)
        public unsafe static void GetUniformSubroutineuiv(GLenum shadertype, GLint location, GLuint[] parameters)
        {
            if (glGetUniformSubroutineuiv != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetUniformSubroutineuiv(shadertype, location, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramStageiv (GLuint program, GLenum shadertype, GLenum pname, GLint *values)
        public unsafe static void GetProgramStageiv(GLuint program, GLenum shadertype, GLenum pname, GLint[] values)
        {
            if (glGetProgramStageiv != null)
            {
                fixed (GLint* ptr_values = values)
                {
                    glGetProgramStageiv(program, shadertype, pname, ptr_values);
                }
            }
        }

        /* ARB_tessellation_shader */
        // GLAPI void APIENTRY glPatchParameteri (GLenum pname, GLint value)
        public static void PatchParameteri(GLenum pname, GLint value)
        {
            if (glPatchParameteri != null)
            {
                glPatchParameteri(pname, value);
            }
        }

        // GLAPI void APIENTRY glPatchParameterfv (GLenum pname, const GLfloat *values)
        public unsafe static void PatchParameterfv(GLenum pname, GLfloat[] values)
        {
            if (glPatchParameterfv != null)
            {
                fixed(GLfloat* ptr_values = values)
                {
                    glPatchParameterfv(pname, ptr_values);
                }
            }
        }

        /* ARB_texture_buffer_object_rgb32 (no entry points) */
        /* ARB_texture_cube_map_array (no entry points) */
        /* ARB_texture_gather (no entry points) */
        /* ARB_transform_feedback2 */
        // GLAPI void APIENTRY glBindTransformFeedback (GLenum target, GLuint id)
        public static void BindTransformFeedback(GLenum target, GLuint id)
        {
            if (glBindTransformFeedback != null)
            {
                glBindTransformFeedback(target, id);
            }
        }

        // GLAPI void APIENTRY glDeleteTransformFeedbacks (GLsizei n, const GLuint *ids)
        public unsafe static void DeleteTransformFeedbacks(GLsizei n, GLuint[] ids)
        {
            if (glDeleteTransformFeedbacks != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glDeleteTransformFeedbacks(n, ptr_ids);
                }
            }
        }

        // GLAPI void APIENTRY glGenTransformFeedbacks (GLsizei n, GLuint *ids)
        public unsafe static void GenTransformFeedbacks(GLsizei n, GLuint[] ids)
        {
            if (glGenTransformFeedbacks != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glGenTransformFeedbacks(n, ptr_ids);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsTransformFeedback (GLuint id)
        public static GLboolean IsTransformFeedback(GLuint id)
        {
            if (glIsTransformFeedback != null)
            {
                return glIsTransformFeedback(id);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glPauseTransformFeedback (void)
        public static void PauseTransformFeedback()
        {
            if (glPauseTransformFeedback != null)
            {
                glPauseTransformFeedback();
            }
        }

        // GLAPI void APIENTRY glResumeTransformFeedback (void)
        public static void ResumeTransformFeedback()
        {
            if (glResumeTransformFeedback != null)
            {
                glResumeTransformFeedback();
            }
        }

        // GLAPI void APIENTRY glDrawTransformFeedback (GLenum mode, GLuint id)
        public static void DrawTransformFeedback(GLenum mode, GLuint id)
        {
            if (glDrawTransformFeedback != null)
            {
                glDrawTransformFeedback(mode, id);
            }
        }

        /* ARB_transform_feedback3 */
        // GLAPI void APIENTRY glDrawTransformFeedbackStream (GLenum mode, GLuint id, GLuint stream)
        public static void DrawTransformFeedbackStream(GLenum mode, GLuint id, GLuint stream)
        {
            if (glDrawTransformFeedbackStream != null)
            {
                glDrawTransformFeedbackStream(mode, id, stream);
            }
        }

        // GLAPI void APIENTRY glBeginQueryIndexed (GLenum target, GLuint index, GLuint id)
        public static void BeginQueryIndexed(GLenum target, GLuint index, GLuint id)
        {
            if (glBeginQueryIndexed != null)
            {
                glBeginQueryIndexed(target, index, id);
            }
        }

        // GLAPI void APIENTRY glEndQueryIndexed (GLenum target, GLuint index)
        public static void EndQueryIndexed(GLenum target, GLuint index)
        {
            if (glEndQueryIndexed != null)
            {
                glEndQueryIndexed(target, index);
            }
        }

        // GLAPI void APIENTRY glGetQueryIndexediv (GLenum target, GLuint index, GLenum pname, GLint *params)
        public unsafe static void GetQueryIndexediv(GLenum target, GLuint index, GLenum pname, GLint[] parameters)
        {
            if (glGetQueryIndexediv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetQueryIndexediv(target, index, pname, ptr_parameters);
                }
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v4.1 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v4.1 WRAPPERS...
        /* OpenGL 4.1 reuses entry points from these extensions: */
        /* ARB_ES2_compatibility */
        // GLAPI void APIENTRY glReleaseShaderCompiler (void)
        public static void ReleaseShaderCompiler()
        {
            if (glReleaseShaderCompiler != null)
            {
                glReleaseShaderCompiler();
            }
        }

        // GLAPI void APIENTRY glShaderBinary (GLsizei count, const GLuint *shaders, GLenum binaryformat, const GLvoid *binary, GLsizei length)
        public unsafe static void ShaderBinary(GLsizei count, GLuint[] shaders, GLenum binaryformat, IntPtr binary, GLsizei length)
        {
            if (glShaderBinary != null)
            {
                fixed (GLuint* ptr_shaders = shaders)
                {
                    glShaderBinary(count, ptr_shaders, binaryformat, binary.ToPointer(), length);
                }
            }
        }

        // GLAPI void APIENTRY glGetShaderPrecisionFormat (GLenum shadertype, GLenum precisiontype, GLint *range, GLint *precision)
        public unsafe static void GetShaderPrecisionFormat(GLenum shadertype, GLenum precisiontype, GLint[] range, GLint[] precision)
        {
            if (glGetShaderPrecisionFormat != null)
            {
                fixed (GLint* ptr_range = range)
                {
                    fixed (GLint* ptr_precision = precision)
                    {
                        glGetShaderPrecisionFormat(shadertype, precisiontype, ptr_range, ptr_precision);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glDepthRangef (GLclampf n, GLclampf f)
        public static void DepthRangef(GLclampf n, GLclampf f)
        {
            if (glDepthRangef != null)
            {
                glDepthRangef(n, f);
            }
        }

        // GLAPI void APIENTRY glClearDepthf (GLclampf d)
        public static void ClearDepthf(GLclampf d)
        {
            if (glClearDepthf != null)
            {
                glClearDepthf(d);
            }
        }

        /* ARB_get_program_binary */
        // GLAPI void APIENTRY glGetProgramBinary (GLuint program, GLsizei bufSize, GLsizei *length, GLenum *binaryFormat, GLvoid *binary)
        public unsafe static void GetProgramBinary(GLuint program, GLsizei bufSize, GLsizei[] length, GLenum[] binaryFormat, IntPtr binary)
        {
            if (glGetProgramBinary != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLenum* ptr_binaryformat = binaryFormat)
                    {
                        glGetProgramBinary(program, bufSize, ptr_length, ptr_binaryformat, binary.ToPointer());
                    }
                }
            }
        }

        // GLAPI void APIENTRY glProgramBinary (GLuint program, GLenum binaryFormat, const GLvoid *binary, GLsizei length)
        public unsafe static void ProgramBinary(GLuint program, GLenum binaryFormat, IntPtr binary, GLsizei length)
        {
            if (glProgramBinary != null)
            {
                glProgramBinary(program, binaryFormat, binary.ToPointer(), length);
            }
        }

        // GLAPI void APIENTRY glProgramParameteri (GLuint program, GLenum pname, GLint value)
        public static void ProgramParameteri(GLuint program, GLenum pname, GLint value)
        {
            if (glProgramParameteri != null)
            {
                glProgramParameteri(program, pname, value);
            }
        }

        /* ARB_separate_shader_objects */
        // GLAPI void APIENTRY glUseProgramStages (GLuint pipeline, GLbitfield stages, GLuint program)
        public static void UseProgramStages(GLuint pipeline, GLbitfield stages, GLuint program)
        {
            if (glUseProgramStages != null)
            {
                glUseProgramStages(pipeline, stages, program);
            }
        }

        // GLAPI void APIENTRY glActiveShaderProgram (GLuint pipeline, GLuint program)
        public static void ActiveShaderProgram(GLuint pipeline, GLuint program)
        {
            if (glActiveShaderProgram != null)
            {
                glActiveShaderProgram(pipeline, program);
            }
        }

        // GLAPI GLuint APIENTRY glCreateShaderProgramv (GLenum type, GLsizei count, const GLchar* *strings)
        public unsafe static GLuint CreateShaderProgramv(GLenum type, GLsizei count, string[] strings)
        {
            if (glCreateShaderProgramv != null)
            {
                IntPtr strptrtable = BuildStringIntPtrTable(strings);

                GLuint result = glCreateShaderProgramv(type, count, (GLchar**)strptrtable);
                
                Marshal.FreeHGlobal(strptrtable);

                return result;
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glBindProgramPipeline (GLuint pipeline)
        public static void BindProgramPipeline(GLuint pipeline)
        {
            if (glBindProgramPipeline != null)
            {
                glBindProgramPipeline(pipeline);
            }
        }

        // GLAPI void APIENTRY glDeleteProgramPipelines (GLsizei n, const GLuint *pipelines)
        public unsafe static void DeleteProgramPipelines(GLsizei n, GLuint[] pipelines)
        {
            if (glDeleteProgramPipelines != null)
            {
                fixed (GLuint* ptr_pipelines = pipelines)
                {
                    glDeleteProgramPipelines(n, ptr_pipelines);
                }
            }
        }

        // GLAPI void APIENTRY glGenProgramPipelines (GLsizei n, GLuint *pipelines)
        public unsafe static void GenProgramPipelines(GLsizei n, GLuint[] pipelines)
        {
            if (glGenProgramPipelines != null)
            {
                fixed (GLuint* ptr_pipelines = pipelines)
                {
                    glGenProgramPipelines(n, ptr_pipelines);
                }
            }
        }

        // GLAPI GLboolean APIENTRY glIsProgramPipeline (GLuint pipeline)
        public static GLboolean IsProgramPipeline(GLuint pipeline)
        {
            if (glIsProgramPipeline != null)
            {
                return glIsProgramPipeline(pipeline);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glGetProgramPipelineiv (GLuint pipeline, GLenum pname, GLint *params)
        public unsafe static void GetProgramPipelineiv(GLuint pipeline, GLenum pname, GLint[] parameters)
        {
            if (glGetProgramPipelineiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetProgramPipelineiv(pipeline, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform1i (GLuint program, GLint location, GLint v0)
        public static void ProgramUniform1i(GLuint program, GLint location, GLint v0)
        {
            if (glProgramUniform1i != null)
            {
                glProgramUniform1i(program, location, v0);
            }
        }

        // GLAPI void APIENTRY glProgramUniform1iv (GLuint program, GLint location, GLsizei count, const GLint *value)
        public unsafe static void ProgramUniform1iv(GLuint program, GLint location, GLsizei count, GLint[] value)
        {
            if (glProgramUniform1iv != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glProgramUniform1iv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform1f (GLuint program, GLint location, GLfloat v0)
        public static void ProgramUniform1f(GLuint program, GLint location, GLfloat v0)
        {
            if (glProgramUniform1f != null)
            {
                glProgramUniform1f(program, location, v0);
            }
        }

        // GLAPI void APIENTRY glProgramUniform1fv (GLuint program, GLint location, GLsizei count, const GLfloat *value)
        public unsafe static void ProgramUniform1fv(GLuint program, GLint location, GLsizei count, GLfloat[] value)
        {
            if (glProgramUniform1fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniform1fv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform1d (GLuint program, GLint location, GLdouble v0)
        public static void ProgramUniform1d(GLuint program, GLint location, GLdouble v0)
        {
            if (glProgramUniform1d != null)
            {
                glProgramUniform1d(program, location, v0);
            }
        }

        // GLAPI void APIENTRY glProgramUniform1dv (GLuint program, GLint location, GLsizei count, const GLdouble *value)
        public unsafe static void ProgramUniform1dv(GLuint program, GLint location, GLsizei count, GLdouble[] value)
        {
            if (glProgramUniform1dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniform1dv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform1ui (GLuint program, GLint location, GLuint v0)
        public static void ProgramUniform1ui(GLuint program, GLint location, GLuint v0)
        {
            if (glProgramUniform1ui != null)
            {
                glProgramUniform1ui(program, location, v0);
            }
        }

        // GLAPI void APIENTRY glProgramUniform1uiv (GLuint program, GLint location, GLsizei count, const GLuint *value)
        public unsafe static void ProgramUniform1uiv(GLuint program, GLint location, GLsizei count, GLuint[] value)
        {
            if (glProgramUniform1uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glProgramUniform1uiv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform2i (GLuint program, GLint location, GLint v0, GLint v1)
        public static void ProgramUniform2i(GLuint program, GLint location, GLint v0, GLint v1)
        {
            if (glProgramUniform2i != null)
            {
                glProgramUniform2i(program, location, v0, v1);
            }
        }

        // GLAPI void APIENTRY glProgramUniform2iv (GLuint program, GLint location, GLsizei count, const GLint *value)
        public unsafe static void ProgramUniform2iv(GLuint program, GLint location, GLsizei count, GLint[] value)
        {
            if (glProgramUniform2iv != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glProgramUniform2iv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform2f (GLuint program, GLint location, GLfloat v0, GLfloat v1)
        public static void ProgramUniform2f(GLuint program, GLint location, GLfloat v0, GLfloat v1)
        {
            if (glProgramUniform2f != null)
            {
                glProgramUniform2f(program, location, v0, v1);
            }
        }

        // GLAPI void APIENTRY glProgramUniform2fv (GLuint program, GLint location, GLsizei count, const GLfloat *value)
        public unsafe static void ProgramUniform2fv(GLuint program, GLint location, GLsizei count, GLfloat[] value)
        {
            if (glProgramUniform2fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniform2fv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform2d (GLuint program, GLint location, GLdouble v0, GLdouble v1)
        public static void ProgramUniform2d(GLuint program, GLint location, GLdouble v0, GLdouble v1)
        {
            if (glProgramUniform2d != null)
            {
                glProgramUniform2d(program, location, v0, v1);
            }
        }

        // GLAPI void APIENTRY glProgramUniform2dv (GLuint program, GLint location, GLsizei count, const GLdouble *value)
        public unsafe static void ProgramUniform2dv(GLuint program, GLint location, GLsizei count, GLdouble[] value)
        {
            if (glProgramUniform2dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniform2dv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform2ui (GLuint program, GLint location, GLuint v0, GLuint v1)
        public static void ProgramUniform2ui(GLuint program, GLint location, GLuint v0, GLuint v1)
        {
            if (glProgramUniform2ui != null)
            {
                glProgramUniform2ui(program, location, v0, v1);
            }
        }

        // GLAPI void APIENTRY glProgramUniform2uiv (GLuint program, GLint location, GLsizei count, const GLuint *value)
        public unsafe static void ProgramUniform2uiv(GLuint program, GLint location, GLsizei count, GLuint[] value)
        {
            if (glProgramUniform2uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glProgramUniform2uiv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform3i (GLuint program, GLint location, GLint v0, GLint v1, GLint v2)
        public static void ProgramUniform3i(GLuint program, GLint location, GLint v0, GLint v1, GLint v2)
        {
            if (glProgramUniform3i != null)
            {
                glProgramUniform3i(program, location, v0, v1, v2);
            }
        }

        // GLAPI void APIENTRY glProgramUniform3iv (GLuint program, GLint location, GLsizei count, const GLint *value)
        public unsafe static void ProgramUniform3iv(GLuint program, GLint location, GLsizei count, GLint[] value)
        {
            if (glProgramUniform3iv != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glProgramUniform3iv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform3f (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
        public static void ProgramUniform3f(GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2)
        {
            if (glProgramUniform3f != null)
            {
                glProgramUniform3f(program, location, v0, v1, v2);
            }
        }

        // GLAPI void APIENTRY glProgramUniform3fv (GLuint program, GLint location, GLsizei count, const GLfloat *value)
        public unsafe static void ProgramUniform3fv(GLuint program, GLint location, GLsizei count, GLfloat[] value)
        {
            if (glProgramUniform3fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniform3fv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform3d (GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2)
        public static void ProgramUniform3d(GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2)
        {
            if (glProgramUniform3d != null)
            {
                glProgramUniform3d(program, location, v0, v1, v2);
            }
        }

        // GLAPI void APIENTRY glProgramUniform3dv (GLuint program, GLint location, GLsizei count, const GLdouble *value)
        public unsafe static void ProgramUniform3dv(GLuint program, GLint location, GLsizei count, GLdouble[] value)
        {
            if (glProgramUniform3dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniform3dv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform3ui (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2)
        public static void ProgramUniform3ui(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2)
        {
            if (glProgramUniform3ui != null)
            {
                glProgramUniform3ui(program, location, v0, v1, v2);
            }
        }

        // GLAPI void APIENTRY glProgramUniform3uiv (GLuint program, GLint location, GLsizei count, const GLuint *value)
        public unsafe static void ProgramUniform3uiv(GLuint program, GLint location, GLsizei count, GLuint[] value)
        {
            if (glProgramUniform3uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glProgramUniform3uiv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform4i (GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
        public static void ProgramUniform4i(GLuint program, GLint location, GLint v0, GLint v1, GLint v2, GLint v3)
        {
            if (glProgramUniform4i != null)
            {
                glProgramUniform4i(program, location, v0, v1, v2, v3);
            }
        }

        // GLAPI void APIENTRY glProgramUniform4iv (GLuint program, GLint location, GLsizei count, const GLint *value)
        public unsafe static void ProgramUniform4iv(GLuint program, GLint location, GLsizei count, GLint[] value)
        {
            if (glProgramUniform4iv != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glProgramUniform4iv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform4f (GLuint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
        public static void ProgramUniform4f(GLint program, GLint location, GLfloat v0, GLfloat v1, GLfloat v2, GLfloat v3)
        {
            if (glProgramUniform4f != null)
            {
                glProgramUniform4f(program, location, v0, v1, v2, v3);
            }
        }

        // GLAPI void APIENTRY glProgramUniform4fv (GLuint program, GLint location, GLsizei count, const GLfloat *value)
        public unsafe static void ProgramUniform4fv(GLuint program, GLint location, GLsizei count, GLfloat[] value)
        {
            if (glProgramUniform4fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniform4fv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform4d (GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2, GLdouble v3)
        public static void ProgramUniform4d(GLuint program, GLint location, GLdouble v0, GLdouble v1, GLdouble v2, GLdouble v3)
        {
            if (glProgramUniform4d != null)
            {
                glProgramUniform4d(program, location, v0, v1, v2, v3);
            }
        }

        // GLAPI void APIENTRY glProgramUniform4dv (GLuint program, GLint location, GLsizei count, const GLdouble *value)
        public unsafe static void ProgramUniform4dv(GLuint program, GLint location, GLsizei count, GLdouble[] value)
        {
            if (glProgramUniform4dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniform4dv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniform4ui (GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
        public static void ProgramUniform4ui(GLuint program, GLint location, GLuint v0, GLuint v1, GLuint v2, GLuint v3)
        {
            if (glProgramUniform4ui != null)
            {
                glProgramUniform4ui(program, location, v0, v1, v2, v3);
            }
        }

        // GLAPI void APIENTRY glProgramUniform4uiv (GLuint program, GLint location, GLsizei count, const GLuint *value)
        public unsafe static void ProgramUniform4uiv(GLuint program, GLint location, GLsizei count, GLuint[] value)
        {
            if (glProgramUniform4uiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glProgramUniform4uiv(program, location, count, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void ProgramUniformMatrix2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix2fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix2fv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void ProgramUniformMatrix3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix3fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix3fv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void ProgramUniformMatrix4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix4fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix4fv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void ProgramUniformMatrix2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix2dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix2dv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void ProgramUniformMatrix3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix3dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix3dv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void ProgramUniformMatrix4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix4dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix4dv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix2x3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void ProgramUniformMatrix2x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix2x3fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix2x3fv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix3x2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void ProgramUniformMatrix3x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix3x2fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix3x2fv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix2x4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void ProgramUniformMatrix2x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix2x4fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix2x4fv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix4x2fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void ProgramUniformMatrix4x2fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix4x2fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix4x2fv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix3x4fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void ProgramUniformMatrix3x4fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix3x4fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix3x4fv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix4x3fv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLfloat *value)
        public unsafe static void ProgramUniformMatrix4x3fv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLfloat[] value)
        {
            if (glProgramUniformMatrix4x3fv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glProgramUniformMatrix4x3fv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix2x3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void ProgramUniformMatrix2x3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix2x3dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix2x3dv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix3x2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void ProgramUniformMatrix3x2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix3x2dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix3x2dv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix2x4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void ProgramUniformMatrix2x4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix2x4dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix2x4dv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix4x2dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void ProgramUniformMatrix4x2dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix4x2dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix4x2dv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix3x4dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void ProgramUniformMatrix3x4dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix3x4dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix3x4dv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glProgramUniformMatrix4x3dv (GLuint program, GLint location, GLsizei count, GLboolean transpose, const GLdouble *value)
        public unsafe static void ProgramUniformMatrix4x3dv(GLuint program, GLint location, GLsizei count, GLboolean transpose, GLdouble[] value)
        {
            if (glProgramUniformMatrix4x3dv != null)
            {
                fixed (GLdouble* ptr_value = value)
                {
                    glProgramUniformMatrix4x3dv(program, location, count, transpose, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glValidateProgramPipeline (GLuint pipeline)
        public static void ValidateProgramPipeline(GLuint pipeline)
        {
            if (glValidateProgramPipeline != null)
            {
                glValidateProgramPipeline(pipeline);
            }
        }

        // GLAPI void APIENTRY glGetProgramPipelineInfoLog (GLuint pipeline, GLsizei bufSize, GLsizei *length, GLchar *infoLog)
        public unsafe static void GetProgramPipelineInfoLog(GLuint pipeline, GLsizei bufSize, GLsizei[] length, GLchar[] infoLog)
        {
            if (glGetProgramPipelineInfoLog != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_infolog = infoLog)
                    {
                        glGetProgramPipelineInfoLog(pipeline, bufSize, ptr_length, ptr_infolog);
                    }
                }
            }
        }

        /* ARB_shader_precision (no entry points) */
        /* ARB_vertex_attrib_64bit */
        // GLAPI void APIENTRY glVertexAttribL1d (GLuint index, GLdouble x)
        public static void VertexAttribL1d(GLuint index, GLdouble x)
        {
            if (glVertexAttribL1d != null)
            {
                glVertexAttribL1d(index, x);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL2d (GLuint index, GLdouble x, GLdouble y)
        public static void VertexAttribL2d(GLuint index, GLdouble x, GLdouble y)
        {
            if (glVertexAttribL2d != null)
            {
                glVertexAttribL2d(index, x, y);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL3d (GLuint index, GLdouble x, GLdouble y, GLdouble z)
        public static void VertexAttribL3d(GLuint index, GLdouble x, GLdouble y, GLdouble z)
        {
            if (glVertexAttribL3d != null)
            {
                glVertexAttribL3d(index, x, y, z);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL4d (GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        public static void VertexAttribL4d(GLuint index, GLdouble x, GLdouble y, GLdouble z, GLdouble w)
        {
            if (glVertexAttribL4d != null)
            {
                glVertexAttribL4d(index, x, y, z, w);
            }
        }

        // GLAPI void APIENTRY glVertexAttribL1dv (GLuint index, const GLdouble *v)
        public unsafe static void VertexAttribL1dv(GLuint index, GLdouble[] v)
        {
            if (glVertexAttribL1dv != null)
            {
                fixed(GLdouble* ptr_v = v)
                {
                    glVertexAttribL1dv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribL2dv (GLuint index, const GLdouble *v)
        public unsafe static void VertexAttribL2dv(GLuint index, GLdouble[] v)
        {
            if (glVertexAttribL2dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttribL2dv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribL3dv (GLuint index, const GLdouble *v)
        public unsafe static void VertexAttribL3dv(GLuint index, GLdouble[] v)
        {
            if (glVertexAttribL3dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttribL3dv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribL4dv (GLuint index, const GLdouble *v)
        public unsafe static void VertexAttribL4dv(GLuint index, GLdouble[] v)
        {
            if (glVertexAttribL4dv != null)
            {
                fixed (GLdouble* ptr_v = v)
                {
                    glVertexAttribL4dv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glVertexAttribLPointer (GLuint index, GLint size, GLenum type, GLsizei stride, const GLvoid *pointer)
        public unsafe static void VertexAttribLPointer(GLuint index, GLint size, GLenum type, GLsizei stride, IntPtr pointer)
        {
            if (glVertexAttribLPointer != null)
            {
                glVertexAttribLPointer(index, size, type, stride, pointer.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetVertexAttribLdv (GLuint index, GLenum pname, GLdouble *params)
        public unsafe static void GetVertexAttribLdv(GLuint index, GLenum pname, GLdouble[] parameters)
        {
            if (glGetVertexAttribLdv != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetVertexAttribLdv(index, pname, ptr_parameters);
                }
            }
        }

        /* ARB_viewport_array */
        // GLAPI void APIENTRY glViewportArrayv (GLuint first, GLsizei count, const GLfloat *v)
        public unsafe static void ViewportArrayv(GLuint first, GLsizei count, GLfloat[] v)
        {
            if (glViewportArrayv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glViewportArrayv(first, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glViewportIndexedf (GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h)
        public static void ViewportIndexedf(GLuint index, GLfloat x, GLfloat y, GLfloat w, GLfloat h)
        {
            if (glViewportIndexedf != null)
            {
                glViewportIndexedf(index, x, y, w, h);
            }
        }

        // GLAPI void APIENTRY glViewportIndexedfv (GLuint index, const GLfloat *v)
        public unsafe static void ViewportIndexedfv(GLuint index, GLfloat[] v)
        {
            if (glViewportIndexedfv != null)
            {
                fixed (GLfloat* ptr_v = v)
                {
                    glViewportIndexedfv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glScissorArrayv (GLuint first, GLsizei count, const GLint *v)
        public unsafe static void ScissorArrayv(GLuint first, GLsizei count, GLint[] v)
        {
            if (glScissorArrayv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glScissorArrayv(first, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glScissorIndexed (GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height)
        public static void ScissorIndexed(GLuint index, GLint left, GLint bottom, GLsizei width, GLsizei height)
        {
            if (glScissorIndexed != null)
            {
                glScissorIndexed(index, left, bottom, width, height);
            }
        }

        // GLAPI void APIENTRY glScissorIndexedv (GLuint index, const GLint *v)
        public unsafe static void ScissorIndexedv(GLuint index, GLint[] v)
        {
            if (glScissorIndexedv != null)
            {
                fixed (GLint* ptr_v = v)
                {
                    glScissorIndexedv(index, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glDepthRangeArrayv (GLuint first, GLsizei count, const GLclampd *v)
        public unsafe static void DepthRangeArrayv(GLuint first, GLsizei count, GLclampd[] v)
        {
            if (glDepthRangeArrayv != null)
            {
                fixed (GLclampd* ptr_v = v)
                {
                    glDepthRangeArrayv(first, count, ptr_v);
                }
            }
        }

        // GLAPI void APIENTRY glDepthRangeIndexed (GLuint index, GLclampd n, GLclampd f)
        public static void DepthRangeIndexed(GLuint index, GLclampd n, GLclampd f)
        {
            if (glDepthRangeIndexed != null)
            {
                glDepthRangeIndexed(index, n, f);
            }
        }

        // GLAPI void APIENTRY glGetFloati_v (GLenum target, GLuint index, GLfloat *data)
        public unsafe static void GetFloati_v(GLenum target, GLuint index, GLfloat[] data)
        {
            if (glGetFloati_v != null)
            {
                fixed (GLfloat* ptr_data = data)
                {
                    glGetFloati_v(target, index, ptr_data);
                }
            }
        }

        // GLAPI void APIENTRY glGetDoublei_v (GLenum target, GLuint index, GLdouble *data)
        public unsafe static void GetDoublei_v(GLenum target, GLuint index, GLdouble[] data)
        {
            if (glGetDoublei_v != null)
            {
                fixed (GLdouble* ptr_data = data)
                {
                    glGetDoublei_v(target, index, ptr_data);
                }
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v4.2 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v4.2 WRAPPERS...
        /* OpenGL 4.2 reuses entry points from these extensions: */
        /* ARB_base_instance */
        // GLAPI void APIENTRY glDrawArraysInstancedBaseInstance (GLenum mode, GLint first, GLsizei count, GLsizei primcount, GLuint baseinstance)
        public static void DrawArraysInstancedBaseInstance(GLenum mode, GLint first, GLsizei count, GLsizei primcount, GLuint baseinstance)
        {
            if (glDrawArraysInstancedBaseInstance != null)
            {
                glDrawArraysInstancedBaseInstance(mode, first, count, primcount, baseinstance);
            }
        }

        // GLAPI void APIENTRY glDrawElementsInstancedBaseInstance (GLenum mode, GLsizei count, GLenum type, const void *indices, GLsizei primcount, GLuint baseinstance)
        public unsafe static void DrawElementsInstancedBaseInstance(GLenum mode, GLsizei count, GLenum type, IntPtr indices, GLsizei primcount, GLuint baseinstance)
        {
            if (glDrawElementsInstancedBaseInstance != null)
            {
                glDrawElementsInstancedBaseInstance(mode, count, type, indices.ToPointer(), primcount, baseinstance);
            }
        }

        // GLAPI void APIENTRY glDrawElementsInstancedBaseVertexBaseInstance (GLenum mode, GLsizei count, GLenum type, const void *indices, GLsizei primcount, GLint basevertex, GLuint baseinstance)
        public unsafe static void DrawElementsInstancedBaseVertexBaseInstance(GLenum mode, GLsizei count, GLenum type, IntPtr indices, GLsizei primcount, GLint basevertex, GLuint baseinstance)
        {
            if (glDrawElementsInstancedBaseVertexBaseInstance != null)
            {
                glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices.ToPointer(), primcount, basevertex, baseinstance);
            }
        }

        /* ARB_shading_language_420pack (no entry points) */
        /* ARB_transform_feedback_instanced */
        // GLAPI void APIENTRY glDrawTransformFeedbackInstanced (GLenum mode, GLuint id, GLsizei primcount)
        public static void DrawTransformFeedbackInstanced(GLenum mode, GLuint id, GLsizei primcount)
        {
            if (glDrawTransformFeedbackInstanced != null)
            {
                glDrawTransformFeedbackInstanced(mode, id, primcount);
            }
        }

        // GLAPI void APIENTRY glDrawTransformFeedbackStreamInstanced (GLenum mode, GLuint id, GLuint stream, GLsizei primcount)
        public static void DrawTransformFeedbackStreamInstanced(GLenum mode, GLuint id, GLuint stream, GLsizei primcount)
        {
            if (glDrawTransformFeedbackStreamInstanced != null)
            {
                glDrawTransformFeedbackStreamInstanced(mode, id, stream, primcount);
            }
        }

        /* ARB_compressed_texture_pixel_storage (no entry points) */
        /* ARB_conservative_depth (no entry points) */
        /* ARB_internalformat_query */
        // GLAPI void APIENTRY glGetInternalformativ (GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint *params)
        public unsafe static void GetInternalformativ(GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint[] parameters)
        {
            if (glGetInternalformativ != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetInternalformativ(target, internalformat, pname, bufSize, ptr_parameters);
                }
            }
        }

        /* ARB_map_buffer_alignment (no entry points) */
        /* ARB_shader_atomic_counters */
        // GLAPI void APIENTRY glGetActiveAtomicCounterBufferiv (GLuint program, GLuint bufferIndex, GLenum pname, GLint *params)
        public unsafe static void GetActiveAtomicCounterBufferiv(GLuint program, GLuint bufferIndex, GLenum pname, GLint[] parameters)
        {
            if (glGetActiveAtomicCounterBufferiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, ptr_parameters);
                }
            }
        }

        /* ARB_shader_image_load_store */
        // GLAPI void APIENTRY glBindImageTexture (GLuint unit, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLenum format)
        public static void BindImageTexture(GLuint unit, GLuint texture, GLint level, GLboolean layered, GLint layer, GLenum access, GLenum format)
        {
            if (glBindImageTexture != null)
            {
                glBindImageTexture(unit, texture, level, layered, layer, access, format);
            }
        }

        // GLAPI void APIENTRY glMemoryBarrier (GLbitfield barriers)
        public static void MemoryBarrier(GLbitfield barriers)
        {
            if (glMemoryBarrier != null)
            {
                glMemoryBarrier(barriers);
            }
        }

        /* ARB_shading_language_packing (no entry points) */
        /* ARB_texture_storage */
        // GLAPI void APIENTRY glTexStorage1D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width)
        public static void TexStorage1D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width)
        {
            if (glTexStorage1D != null)
            {
                glTexStorage1D(target, levels, internalformat, width);
            }
        }

        // GLAPI void APIENTRY glTexStorage2D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)
        public static void TexStorage2D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glTexStorage2D != null)
            {
                glTexStorage2D(target, levels, internalformat, width, height);
            }
        }

        // GLAPI void APIENTRY glTexStorage3D (GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)
        public static void TexStorage3D(GLenum target, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)
        {
            if (glTexStorage3D != null)
            {
                glTexStorage3D(target, levels, internalformat, width, height, depth);
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v4.3 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v4.3 WRAPPERS...
        /* OpenGL 4.3 reuses entry points from these extensions: */
        /* ARB_arrays_of_arrays (no entry points, GLSL only) */
        /* ARB_fragment_layer_viewport (no entry points, GLSL only) */
        /* ARB_shader_image_size (no entry points, GLSL only) */
        /* ARB_ES3_compatibility (no entry points) */
        /* ARB_clear_buffer_object */
        // GLAPI void APIENTRY glClearBufferData (GLenum target, GLenum internalformat, GLenum format, GLenum type, const void *data)
        public unsafe static void ClearBufferData(GLenum target, GLenum internalformat, GLenum format, GLenum type, IntPtr data)
        {
            if (glClearBufferData != null)
            {
                glClearBufferData(target, internalformat, format, type, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glClearBufferSubData (GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, const void *data)
        public unsafe static void ClearBufferSubData(GLenum target, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, IntPtr data)
        {
            if (glClearBufferSubData != null)
            {
                glClearBufferSubData(target, internalformat, offset, size, format, type, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glClearNamedBufferDataEXT (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, const void *data)
        public unsafe static void ClearNamedBufferDataEXT(GLuint buffer, GLenum internalformat, GLenum format, GLenum type, IntPtr data)
        {
            if (glClearNamedBufferDataEXT != null)
            {
                glClearNamedBufferDataEXT(buffer, internalformat, format, type, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glClearNamedBufferSubDataEXT (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, GLsizeiptr offset, GLsizeiptr size, const void *data)
        public unsafe static void ClearNamedBufferSubDataEXT(GLuint buffer, GLenum internalformat, GLenum format, GLenum type, GLsizeiptr offset, GLsizeiptr size, IntPtr data)
        {
            if (glClearNamedBufferSubDataEXT != null)
            {
                glClearNamedBufferSubDataEXT(buffer, internalformat, format, type, offset, size, data.ToPointer());
            }
        }

        /* ARB_compute_shader */
        // GLAPI void APIENTRY glDispatchCompute (GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z)
        public static void DispatchCompute(GLuint num_groups_x, GLuint num_groups_y, GLuint num_groups_z)
        {
            if (glDispatchCompute != null)
            {
                glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
            }
        }

        // GLAPI void APIENTRY glDispatchComputeIndirect (GLintptr indirect)
        public static void DispatchComputeIndirect(GLintptr indirect)
        {
            if (glDispatchComputeIndirect != null)
            {
                glDispatchComputeIndirect(indirect);
            }
        }

        /* ARB_copy_image */
        // GLAPI void APIENTRY glCopyImageSubData (GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth)
        public static void CopyImageSubData(GLuint srcName, GLenum srcTarget, GLint srcLevel, GLint srcX, GLint srcY, GLint srcZ, GLuint dstName, GLenum dstTarget, GLint dstLevel, GLint dstX, GLint dstY, GLint dstZ, GLsizei srcWidth, GLsizei srcHeight, GLsizei srcDepth)
        {
            if (glCopyImageSubData != null)
            {
                glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
            }
        }

        /* KHR_debug (includes ARB_debug_output commands promoted to KHR without suffixes) */
        // GLAPI void APIENTRY glDebugMessageControl (GLenum source, GLenum type, GLenum severity, GLsizei count, const GLuint *ids, GLboolean enabled);
        public unsafe static void DebugMessageControl(GLenum source, GLenum type, GLenum severity, GLsizei count, GLuint[] ids, GLboolean enabled)
        {
            if (glDebugMessageControl != null)
            {
                fixed(GLuint* ptr = ids)
                {
                    glDebugMessageControl(source, type, severity, count, ptr, enabled);
                }
            }
        }

        // GLAPI void APIENTRY glDebugMessageInsert (GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, const GLchar *buf);
        public static void DebugMessageInsert(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, string buf)
        {
            if (glDebugMessageInsert != null)
            {
                glDebugMessageInsert(source, type, id, severity, length, buf);
            }
        }

        // GLAPI void APIENTRY glDebugMessageCallback (GLDEBUGPROC callback, const void *userParam);
        public unsafe static void DebugMessageCallback(TCALLBACKglDebugProc callback, IntPtr userParam)
        {
            if (glDebugMessageCallback != null)
            {
                glDebugMessageCallback(callback, userParam.ToPointer());
            }
        }

        // GLAPI GLuint APIENTRY glGetDebugMessageLog (GLuint count, GLsizei bufsize, GLenum *sources, GLenum *types, GLuint *ids, GLenum *severities, GLsizei *lengths, GLchar *messageLog);
        public unsafe static GLuint GetDebugMessageLog(GLuint count, GLsizei bufsize, GLenum[] sources, GLenum[] types, GLuint[] ids, GLenum[] severities, GLsizei[] lengths, GLchar[] messageLog)
        {
            if (glGetDebugMessageLog != null)
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
                                    fixed (GLchar* ptr_message = messageLog)
                                    {
                                        return glGetDebugMessageLog(count, bufsize, ptr_sources, ptr_types, ptr_ids, ptr_severities, ptr_lengths, ptr_message);
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

        // GLAPI void APIENTRY glPushDebugGroup (GLenum source, GLuint id, GLsizei length, const GLchar *message);
        public static void PushDebugGroup(GLenum source, GLuint id, GLsizei length, string message)
        {
            if (glPushDebugGroup != null)
            {
                glPushDebugGroup(source, id, length, message);
            }
        }

        // GLAPI void APIENTRY glPopDebugGroup (void);
        public static void PopDebugGroup()
        {
            if (glPopDebugGroup != null)
            {
                glPopDebugGroup();
            }
        }

        // GLAPI void APIENTRY glObjectLabel (GLenum identifier, GLuint name, GLsizei length, const GLchar *label);
        public static void ObjectLabel(GLenum identifier, GLuint name, GLsizei length, string label)
        {
            if (glObjectLabel != null)
            {
                glObjectLabel(identifier, name, length, label);
            }
        }

        // GLAPI void APIENTRY glGetObjectLabel (GLenum identifier, GLuint name, GLsizei bufSize, GLsizei *length, GLchar *label);
        public unsafe static void GetObjectLabel(GLenum identifier, GLuint name, GLsizei bufSize, GLsizei[] length, GLchar[] label)
        {
            if (glGetObjectLabel != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed(GLchar* ptr_label = label)
                    {
                        glGetObjectLabel(identifier, name, bufSize, ptr_length, ptr_label);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glObjectPtrLabel (const void *ptr, GLsizei length, const GLchar *label);
        public unsafe static void ObjectPtrLabel(IntPtr ptr, GLsizei length, string label)
        {
            if (glObjectPtrLabel != null)
            {
                glObjectPtrLabel(ptr.ToPointer(), length, label);
            }
        }

        // GLAPI void APIENTRY glGetObjectPtrLabel (const void *ptr, GLsizei bufSize, GLsizei *length, GLchar *label);
        public unsafe static void GetObjectPtrLabel(IntPtr ptr, GLsizei bufSize, GLsizei[] length, GLchar[] label)
        {
            if (glGetObjectPtrLabel != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_label = label)
                    {
                        glGetObjectPtrLabel(ptr.ToPointer(), bufSize, ptr_length, ptr_label);
                    }
                }
            }
        }

        /* ARB_explicit_uniform_location (no entry points) */
        /* ARB_framebuffer_no_attachments */
        // GLAPI void APIENTRY glFramebufferParameteri (GLenum target, GLenum pname, GLint param)
        public static void FramebufferParameteri(GLenum target, GLenum pname, GLint param)
        {
            if (glFramebufferParameteri != null)
            {
                glFramebufferParameteri(target, pname, param);
            }
        }

        // GLAPI void APIENTRY glGetFramebufferParameteriv (GLenum target, GLenum pname, GLint *params)
        public unsafe static void GetFramebufferParameteriv(GLenum target, GLenum pname, GLint[] parameters)
        {
            if (glGetFramebufferParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetFramebufferParameteriv(target, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferParameteriEXT (GLuint framebuffer, GLenum pname, GLint param)
        public static void NamedFramebufferParameteriEXT(GLuint framebuffer, GLenum pname, GLint param)
        {
            if (glNamedFramebufferParameteriEXT != null)
            {
                glNamedFramebufferParameteriEXT(framebuffer, pname, param);
            }
        }

        // GLAPI void APIENTRY glGetNamedFramebufferParameterivEXT (GLuint framebuffer, GLenum pname, GLint *params)
        public unsafe static void GetNamedFramebufferParameterivEXT(GLuint framebuffer, GLenum pname, GLint[] parameters)
        {
            if (glGetNamedFramebufferParameterivEXT != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetNamedFramebufferParameterivEXT(framebuffer, pname, ptr_parameters);
                }
            }
        }

        /* ARB_internalformat_query2 */
        // GLAPI void APIENTRY glGetInternalformati64v (GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint64 *params)
        public unsafe static void GetInternalformati64v(GLenum target, GLenum internalformat, GLenum pname, GLsizei bufSize, GLint64[] parameters)
        {
            if (glGetInternalformati64v != null)
            {
                fixed (GLint64* ptr_parameters = parameters)
                {
                    glGetInternalformati64v(target, internalformat, pname, bufSize, ptr_parameters);
                }
            }
        }

        /* ARB_invalidate_subdata */
        // GLAPI void APIENTRY glInvalidateTexSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth)
        public static void InvalidateTexSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth)
        {
            if (glInvalidateTexSubImage != null)
            {
                glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
            }
        }

        // GLAPI void APIENTRY glInvalidateTexImage (GLuint texture, GLint level)
        public static void InvalidateTexImage(GLuint texture, GLint level)
        {
            if (glInvalidateTexImage != null)
            {
                glInvalidateTexImage(texture, level);
            }
        }

        // GLAPI void APIENTRY glInvalidateBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr length)
        public static void InvalidateBufferSubData(GLuint buffer, GLintptr offset, GLsizeiptr length)
        {
            if (glInvalidateBufferSubData != null)
            {
                glInvalidateBufferSubData(buffer, offset, length);
            }
        }

        // GLAPI void APIENTRY glInvalidateBufferData (GLuint buffer)
        public static void InvalidateBufferData(GLuint buffer)
        {
            if (glInvalidateBufferData != null)
            {
                glInvalidateBufferData(buffer);
            }
        }

        // GLAPI void APIENTRY glInvalidateFramebuffer (GLenum target, GLsizei numAttachments, const GLenum *attachments)
        public unsafe static void InvalidateFramebuffer(GLenum target, GLsizei numAttachments, GLenum[] attachments)
        {
            if (glInvalidateFramebuffer != null)
            {
                fixed (GLenum* ptr_attachments = attachments)
                {
                    glInvalidateFramebuffer(target, numAttachments, ptr_attachments);
                }
            }
        }

        // GLAPI void APIENTRY glInvalidateSubFramebuffer (GLenum target, GLsizei numAttachments, const GLenum *attachments, GLint x, GLint y, GLsizei width, GLsizei height)
        public unsafe static void InvalidateSubFramebuffer(GLenum target, GLsizei numAttachments, GLenum[] attachments, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glInvalidateSubFramebuffer != null)
            {
                fixed (GLenum* ptr_attachments = attachments)
                {
                    glInvalidateSubFramebuffer(target, numAttachments, ptr_attachments, x, y, width, height);
                }
            }
        }

        /* ARB_multi_draw_indirect */
        // GLAPI void APIENTRY glMultiDrawArraysIndirect (GLenum mode, const void *indirect, GLsizei drawcount, GLsizei stride)
        public unsafe static void MultiDrawArraysIndirect(GLenum mode, IntPtr indirect, GLsizei drawcount, GLsizei stride)
        {
            if (glMultiDrawArraysIndirect != null)
            {
                glMultiDrawArraysIndirect(mode, indirect.ToPointer(), drawcount, stride);
            }
        }

        // GLAPI void APIENTRY glMultiDrawElementsIndirect (GLenum mode, GLenum type, const void *indirect, GLsizei drawcount, GLsizei stride)
        public unsafe static void MultiDrawElementsIndirect(GLenum mode, GLenum type, IntPtr indirect, GLsizei drawcount, GLsizei stride)
        {
            if (glMultiDrawElementsIndirect != null)
            {
                glMultiDrawElementsIndirect(mode, type, indirect.ToPointer(), drawcount, stride);
            }
        }

        /* ARB_program_interface_query */
        // GLAPI void APIENTRY glGetProgramInterfaceiv (GLuint program, GLenum programInterface, GLenum pname, GLint *params)
        public unsafe static void GetProgramInterfaceiv(GLuint program, GLenum programInterface, GLenum pname, GLint[] parameters)
        {
            if (glGetProgramInterfaceiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetProgramInterfaceiv(program, programInterface, pname, ptr_parameters);
                }
            }
        }

        // GLAPI GLuint APIENTRY glGetProgramResourceIndex (GLuint program, GLenum programInterface, const GLchar *name)
        public static GLuint GetProgramResourceIndex(GLuint program, GLenum programInterface, string name)
        {
            if (glGetProgramResourceIndex != null)
            {
                return glGetProgramResourceIndex(program, programInterface, name);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glGetProgramResourceName (GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei *length, GLchar *name)
        public unsafe static void GetProgramResourceName(GLuint program, GLenum programInterface, GLuint index, GLsizei bufSize, GLsizei[] length, GLchar[] name)
        {
            if (glGetProgramResourceName != null)
            {
                fixed (GLsizei* ptr_length = length)
                {
                    fixed (GLchar* ptr_name = name)
                    {
                        glGetProgramResourceName(program, programInterface, index, bufSize, ptr_length, ptr_name);
                    }
                }
            }
        }

        // GLAPI void APIENTRY glGetProgramResourceiv (GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, const GLenum *props, GLsizei bufSize, GLsizei *length, GLint *params)
        public unsafe static void GetProgramResourceiv(GLuint program, GLenum programInterface, GLuint index, GLsizei propCount, GLenum[] props, GLsizei bufSize, GLsizei[] length, GLint[] parameters)
        {
            if (glGetProgramResourceiv != null)
            {
                fixed (GLenum* ptr_props = props)
                {
                    fixed (GLsizei* ptr_length = length)
                    {
                        fixed (GLint* ptr_params = parameters)
                        {
                            glGetProgramResourceiv(program, programInterface, index, propCount, ptr_props, bufSize, ptr_length, ptr_params);
                        }
                    }
                }
            }
        }

        // GLAPI GLint APIENTRY glGetProgramResourceLocation (GLuint program, GLenum programInterface, const GLchar *name)
        public static GLint GetProgramResourceLocation(GLuint program, GLenum programInterface, string name)
        {
            if (glGetProgramResourceLocation != null)
            {
                return glGetProgramResourceLocation(program, programInterface, name);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI GLint APIENTRY glGetProgramResourceLocationIndex (GLuint program, GLenum programInterface, const GLchar *name)
        public static GLint GetProgramResourceLocationIndex(GLuint program, GLenum programInterface, string name)
        {
            if (glGetProgramResourceLocationIndex != null)
            {
                return glGetProgramResourceLocationIndex(program, programInterface, name);
            }
            else
            {
                return 0;
            }
        }

        /* ARB_robust_buffer_access_behavior (no entry points) */
        /* ARB_shader_storage_buffer_object */
        // GLAPI void APIENTRY glShaderStorageBlockBinding (GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding)
        public static void ShaderStorageBlockBinding(GLuint program, GLuint storageBlockIndex, GLuint storageBlockBinding)
        {
            if (glShaderStorageBlockBinding != null)
            {
                glShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
            }
        }

        /* ARB_stencil_texturing (no entry points) */
        /* ARB_texture_buffer_range */
        // GLAPI void APIENTRY glTexBufferRange (GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size)
        public static void TexBufferRange(GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size)
        {
            if (glTexBufferRange != null)
            {
                glTexBufferRange(target, internalformat, buffer, offset, size);
            }
        }

        // GLAPI void APIENTRY glTextureBufferRangeEXT (GLuint texture, GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size)
        public static void TextureBufferRangeEXT(GLuint texture, GLenum target, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size)
        {
            if (glTextureBufferRangeEXT != null)
            {
                glTextureBufferRangeEXT(texture, target, internalformat, buffer, offset, size);
            }
        }

        /* ARB_texture_query_levels (no entry points) */
        /* ARB_texture_storage_multisample */
        // GLAPI void APIENTRY glTexStorage2DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
        public static void TexStorage2DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
        {
            if (glTexStorage2DMultisample != null)
            {
                glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
            }
        }

        // GLAPI void APIENTRY glTexStorage3DMultisample (GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
        public static void TexStorage3DMultisample(GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
        {
            if (glTexStorage3DMultisample != null)
            {
                glTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
            }
        }

        // GLAPI void APIENTRY glTextureStorage2DMultisampleEXT (GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
        public static void TextureStorage2DMultisampleEXT(GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
        {
            if (glTextureStorage2DMultisampleEXT != null)
            {
                glTextureStorage2DMultisampleEXT(texture, target, samples, internalformat, width, height, fixedsamplelocations);
            }
        }

        // GLAPI void APIENTRY glTextureStorage3DMultisampleEXT (GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
        public static void TextureStorage3DMultisampleEXT(GLuint texture, GLenum target, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
        {
            if (glTextureStorage3DMultisampleEXT != null)
            {
                glTextureStorage3DMultisampleEXT(texture, target, samples, internalformat, width, height, depth, fixedsamplelocations);
            }
        }

        /* ARB_texture_view */
        // GLAPI void APIENTRY glTextureView (GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers)
        public static void TextureView(GLuint texture, GLenum target, GLuint origtexture, GLenum internalformat, GLuint minlevel, GLuint numlevels, GLuint minlayer, GLuint numlayers)
        {
            if (glTextureView != null)
            {
                glTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
            }
        }

        /* ARB_vertex_attrib_binding */
        // GLAPI void APIENTRY glBindVertexBuffer (GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride)
        public static void BindVertexBuffer(GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride)
        {
            if (glBindVertexBuffer != null)
            {
                glBindVertexBuffer(bindingindex, buffer, offset, stride);
            }
        }

        // GLAPI void APIENTRY glVertexAttribFormat (GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset)
        public static void VertexAttribFormat(GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset)
        {
            if (glVertexAttribFormat != null)
            {
                glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
            }
        }

        // GLAPI void APIENTRY glVertexAttribIFormat (GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
        public static void VertexAttribIFormat(GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
        {
            if (glVertexAttribIFormat != null)
            {
                glVertexAttribIFormat(attribindex, size, type, relativeoffset);
            }
        }

        // GLAPI void APIENTRY glVertexAttribLFormat (GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
        public static void VertexAttribLFormat(GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
        {
            if (glVertexAttribLFormat != null)
            {
                glVertexAttribLFormat(attribindex, size, type, relativeoffset);
            }
        }

        // GLAPI void APIENTRY glVertexAttribBinding (GLuint attribindex, GLuint bindingindex)
        public static void VertexAttribBinding(GLuint attribindex, GLuint bindingindex)
        {
            if (glVertexAttribBinding != null)
            {
                glVertexAttribBinding(attribindex, bindingindex);
            }
        }

        // GLAPI void APIENTRY glVertexBindingDivisor (GLuint bindingindex, GLuint divisor)
        public static void VertexBindingDivisor(GLuint bindingindex, GLuint divisor)
        {
            if (glVertexBindingDivisor != null)
            {
                glVertexBindingDivisor(bindingindex, divisor);
            }
        }

        // GLAPI void APIENTRY glVertexArrayBindVertexBufferEXT (GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride)
        public static void VertexArrayBindVertexBufferEXT(GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride)
        {
            if (glVertexArrayBindVertexBufferEXT != null)
            {
                glVertexArrayBindVertexBufferEXT(vaobj, bindingindex, buffer, offset, stride);
            }
        }

        // GLAPI void APIENTRY glVertexArrayVertexAttribFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset)
        public static void VertexArrayVertexAttribFormatEXT(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset)
        {
            if (glVertexArrayVertexAttribFormatEXT != null)
            {
                glVertexArrayVertexAttribFormatEXT(vaobj, attribindex, size, type, normalized, relativeoffset);
            }
        }

        // GLAPI void APIENTRY glVertexArrayVertexAttribIFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
        public static void VertexArrayVertexAttribIFormatEXT(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
        {
            if (glVertexArrayVertexAttribIFormatEXT != null)
            {
                glVertexArrayVertexAttribIFormatEXT(vaobj, attribindex, size, type, relativeoffset);
            }
        }

        // GLAPI void APIENTRY glVertexArrayVertexAttribLFormatEXT (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
        public static void VertexArrayVertexAttribLFormatEXT(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
        {
            if (glVertexArrayVertexAttribLFormatEXT != null)
            {
                glVertexArrayVertexAttribLFormatEXT(vaobj, attribindex, size, type, relativeoffset);
            }
        }

        // GLAPI void APIENTRY glVertexArrayVertexAttribBindingEXT (GLuint vaobj, GLuint attribindex, GLuint bindingindex)
        public static void VertexArrayVertexAttribBindingEXT(GLuint vaobj, GLuint attribindex, GLuint bindingindex)
        {
            if (glVertexArrayVertexAttribBindingEXT != null)
            {
                glVertexArrayVertexAttribBindingEXT(vaobj, attribindex, bindingindex);
            }
        }

        // GLAPI void APIENTRY glVertexArrayVertexBindingDivisorEXT (GLuint vaobj, GLuint bindingindex, GLuint divisor)
        public static void VertexArrayVertexBindingDivisorEXT(GLuint vaobj, GLuint bindingindex, GLuint divisor)
        {
            if (glVertexArrayVertexBindingDivisorEXT != null)
            {
                glVertexArrayVertexBindingDivisorEXT(vaobj, bindingindex, divisor);
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v4.4 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v4.4 WRAPPERS...
        // GLAPI void APIENTRY glBufferStorage (GLenum target, GLsizeiptr size, const void *data, GLbitfield flags);
        public unsafe static void BufferStorage(GLenum target, GLsizeiptr size, IntPtr data, GLbitfield flags)
        {
            if (glBufferStorage != null)
            {
                glBufferStorage(target, size, data.ToPointer(), flags);
            }
        }

        // GLAPI void APIENTRY glClearTexImage (GLuint texture, GLint level, GLenum format, GLenum type, const void *data);
        public unsafe static void ClearTexImage(GLuint texture, GLint level, GLenum format, GLenum type, IntPtr data)
        {
            if (glClearTexImage != null)
            {
                glClearTexImage(texture, level, format, type, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glClearTexSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const void *data);
        public unsafe static void ClearTexSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, IntPtr data)
        {
            if (glClearTexSubImage != null)
            {
                glClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glBindBuffersBase (GLenum target, GLuint first, GLsizei count, const GLuint *buffers);
        public unsafe static void BindBuffersBase (GLenum target, GLuint first, GLsizei count, GLuint[] buffers)
        {
            if (glBindBuffersBase != null)
            {
                fixed (GLuint* ptr_buffers = buffers)
                {
                    glBindBuffersBase(target, first, count, ptr_buffers);
                }
            }
        }

        // GLAPI void APIENTRY glBindBuffersRange (GLenum target, GLuint first, GLsizei count, const GLuint *buffers, const GLintptr *offsets, const GLsizeiptr *sizes);
        public unsafe static void BindBuffersRange(GLenum target, GLuint first, GLsizei count, GLuint[] buffers, GLintptr[] offsets, GLsizeiptr[] sizes)
        {
            if (glBindBuffersRange != null)
            {
                fixed (GLuint* ptr_buffers = buffers)
                {
                    fixed (GLintptr* ptr_offsets = offsets)
                    {
                        fixed (GLsizeiptr* ptr_sizes = sizes)
                        {
                            glBindBuffersRange(target, first, count, ptr_buffers, ptr_offsets, ptr_sizes);
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glBindTextures (GLuint first, GLsizei count, const GLuint *textures);
        public unsafe static void BindTextures(GLuint first, GLsizei count, GLuint[] textures)
        {
            if (glBindTextures != null)
            {
                fixed (GLuint* ptr_textures = textures)
                {
                    glBindTextures(first, count, ptr_textures);
                }
            }
        }

        // GLAPI void APIENTRY glBindSamplers (GLuint first, GLsizei count, const GLuint *samplers);
        public unsafe static void BindSamplers(GLuint first, GLsizei count, GLuint[] samplers)
        {
            if (glBindSamplers != null)
            {
                fixed (GLuint* ptr_samplers = samplers)
                {
                    glBindSamplers(first, count, ptr_samplers);
                }
            }
        }

        // GLAPI void APIENTRY glBindImageTextures (GLuint first, GLsizei count, const GLuint *textures);
        public unsafe static void BindImageTextures(GLuint first, GLsizei count, GLuint[] textures)
        {
            if (glBindImageTextures != null)
            {
                fixed (GLuint* ptr_textures = textures)
                {
                    glBindImageTextures(first, count, ptr_textures);
                }
            }
        }

        // GLAPI void APIENTRY glBindVertexBuffers (GLuint first, GLsizei count, const GLuint *buffers, const GLintptr *offsets, const GLsizei *strides);
        public unsafe static void BindVertexBuffers(GLuint first, GLsizei count, GLuint[] buffers, GLintptr[] offsets, GLsizei[] strides)
        {
            if (glBindVertexBuffers != null)
            {
                fixed (GLuint* ptr_buffers = buffers)
                {
                    fixed (GLintptr* ptr_offsets = offsets)
                    {
                        fixed (GLsizei* ptr_strides = strides)
                        {
                            glBindVertexBuffers(first, count, ptr_buffers, ptr_offsets, ptr_strides);
                        }
                    }
                }
            }
        }

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL v4.5 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL v4.5 WRAPPERS...
        // GLAPI void APIENTRY glClipControl (GLenum origin, GLenum depth);
        public static void ClipControl(GLenum origin, GLenum depth)
        {
            if (glClipControl != null)
            {
                glClipControl(origin, depth);
            }
        }

        // GLAPI void APIENTRY glCreateTransformFeedbacks (GLsizei n, GLuint *ids);
        public unsafe static void CreateTransformFeedbacks(GLsizei n, GLuint[] ids)
        {
            if (glCreateTransformFeedbacks != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glCreateTransformFeedbacks(n, ptr_ids);
                }
            }
        }

        // GLAPI void APIENTRY glTransformFeedbackBufferBase (GLuint xfb, GLuint index, GLuint buffer);
        public static void TransformFeedbackBufferBase(GLuint xfb, GLuint index, GLuint buffer)
        {
            if (glTransformFeedbackBufferBase != null)
            {
                glTransformFeedbackBufferBase(xfb, index, buffer);
            }
        }

        // GLAPI void APIENTRY glTransformFeedbackBufferRange (GLuint xfb, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size);
        public static void TransformFeedbackBufferRange(GLuint xfb, GLuint index, GLuint buffer, GLintptr offset, GLsizeiptr size)
        {
            if (glTransformFeedbackBufferRange != null)
            {
                glTransformFeedbackBufferRange(xfb, index, buffer, offset, size);
            }
        }

        // GLAPI void APIENTRY glGetTransformFeedbackiv (GLuint xfb, GLenum pname, GLint *param);
        public unsafe static void GetTransformFeedbackiv(GLuint xfb, GLenum pname, GLint[] param)
        {
            if (glGetTransformFeedbackiv != null)
            {
                fixed (GLint* ptr_param = param)
                {
                    glGetTransformFeedbackiv(xfb, pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glGetTransformFeedbacki_v (GLuint xfb, GLenum pname, GLuint index, GLint *param);
        public unsafe static void GetTransformFeedbacki_v(GLuint xfb, GLenum pname, GLuint index, GLint[] param)
        {
            if (glGetTransformFeedbacki_v != null)
            {
                fixed (GLint* ptr_param = param)
                {
                    glGetTransformFeedbacki_v(xfb, pname, index, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glGetTransformFeedbacki64_v (GLuint xfb, GLenum pname, GLuint index, GLint64 *param);
        public unsafe static void GetTransformFeedbacki64_v(GLuint xfb, GLenum pname, GLuint index, GLint64[] param)
        {
            if (glGetTransformFeedbacki64_v != null)
            {
                fixed (GLint64* ptr_param = param)
                {
                    glGetTransformFeedbacki64_v(xfb, pname, index, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glCreateBuffers (GLsizei n, GLuint *buffers);
        public unsafe static void CreateBuffers(GLsizei n, GLuint[] buffers)
        {
            if (glCreateBuffers != null)
            {
                fixed (GLuint* ptr_buffers = buffers)
                {
                    glCreateBuffers(n, ptr_buffers);
                }
            }
        }

        // GLAPI void APIENTRY glNamedBufferStorage (GLuint buffer, GLsizeiptr size, const void *data, GLbitfield flags);
        public unsafe static void NamedBufferStorage(GLuint buffer, GLsizeiptr size, IntPtr data, GLbitfield flags)
        {
            if (glNamedBufferStorage != null)
            {
                glNamedBufferStorage(buffer, size, data.ToPointer(), flags);
            }
        }

        // GLAPI void APIENTRY glNamedBufferData (GLuint buffer, GLsizeiptr size, const void *data, GLenum usage);
        public unsafe static void NamedBufferData(GLuint buffer, GLsizeiptr size, IntPtr data, GLenum usage)
        {
            if (glNamedBufferData != null)
            {
                glNamedBufferData(buffer, size, data.ToPointer(), usage);
            }
        }

        // GLAPI void APIENTRY glNamedBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr size, const void *data);
        public unsafe static void NamedBufferSubData(GLuint buffer, GLintptr offset, GLsizeiptr size, IntPtr data)
        {
            if (glNamedBufferSubData != null)
            {
                glNamedBufferSubData(buffer, offset, size, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCopyNamedBufferSubData (GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size);
        public static void CopyNamedBufferSubData(GLuint readBuffer, GLuint writeBuffer, GLintptr readOffset, GLintptr writeOffset, GLsizeiptr size)
        {
            if (glCopyNamedBufferSubData != null)
            {
                glCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
            }
        }

        // GLAPI void APIENTRY glClearNamedBufferData (GLuint buffer, GLenum internalformat, GLenum format, GLenum type, const void *data);
        public unsafe static void ClearNamedBufferData(GLuint buffer, GLenum internalformat, GLenum format, GLenum type, IntPtr data)
        {
            if (glClearNamedBufferData != null)
            {
                glClearNamedBufferData(buffer, internalformat, format, type, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glClearNamedBufferSubData (GLuint buffer, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, const void *data);
        public unsafe static void ClearNamedBufferSubData(GLuint buffer, GLenum internalformat, GLintptr offset, GLsizeiptr size, GLenum format, GLenum type, IntPtr data)
        {
            if (glClearNamedBufferSubData != null)
            {
                glClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data.ToPointer());
            }
        }

        // GLAPI void *APIENTRY glMapNamedBuffer (GLuint buffer, GLenum access);
        public unsafe static IntPtr MapNamedBuffer(GLuint buffer, GLenum access)
        {
            if (glMapNamedBuffer != null)
            {
                return (IntPtr)glMapNamedBuffer(buffer, access);
            }
            else
            {
                return IntPtr.Zero;
            }
        }

        // GLAPI void *APIENTRY glMapNamedBufferRange (GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access);
        public unsafe static IntPtr MapNamedBufferRange(GLuint buffer, GLintptr offset, GLsizeiptr length, GLbitfield access)
        {
            if (glMapNamedBufferRange != null)
            {
                return (IntPtr)glMapNamedBufferRange(buffer, offset, length, access);
            }
            else
            {
                return IntPtr.Zero;
            }
        }
        
        // GLAPI GLboolean APIENTRY glUnmapNamedBuffer (GLuint buffer);
        public static GLboolean UnmapNamedBuffer(GLuint buffer)
        {
            if (glUnmapNamedBuffer != null)
            {
                return glUnmapNamedBuffer(buffer);
            }
            else
            {
                return false;
            }
        }

        // GLAPI void APIENTRY glFlushMappedNamedBufferRange (GLuint buffer, GLintptr offset, GLsizeiptr length);
        public static void FlushMappedNamedBufferRange(GLuint buffer, GLintptr offset, GLsizeiptr length)
        {
            if (glFlushMappedNamedBufferRange != null)
            {
                glFlushMappedNamedBufferRange(buffer, offset, length);
            }
        }

        // GLAPI void APIENTRY glGetNamedBufferParameteriv (GLuint buffer, GLenum pname, GLint *params);
        public unsafe static void GetNamedBufferParameteriv(GLuint buffer, GLenum pname, GLint[] parameters)
        {
            if (glGetNamedBufferParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetNamedBufferParameteriv(buffer, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetNamedBufferParameteri64v (GLuint buffer, GLenum pname, GLint64 *params);
        public unsafe static void GetNamedBufferParameteri64v(GLuint buffer, GLenum pname, GLint64[] parameters)
        {
            if (glGetNamedBufferParameteri64v != null)
            {
                fixed (GLint64* ptr_parameters = parameters)
                {
                    glGetNamedBufferParameteri64v(buffer, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetNamedBufferPointerv (GLuint buffer, GLenum pname, void **params);
        public unsafe static void GetNamedBufferPointerv (GLuint buffer, GLenum pname, IntPtr[] parameters)
        {
            if (glGetNamedBufferPointerv != null)
            {
                fixed (IntPtr* ptr_parameters = parameters)
                {
                    glGetNamedBufferPointerv(buffer, pname, (void**)ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetNamedBufferSubData (GLuint buffer, GLintptr offset, GLsizeiptr size, void *data);
        public unsafe static void GetNamedBufferSubData(GLuint buffer, GLintptr offset, GLsizeiptr size, IntPtr data)
        {
            if (glGetNamedBufferSubData != null)
            {
                glGetNamedBufferSubData(buffer, offset, size, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCreateFramebuffers (GLsizei n, GLuint *framebuffers);
        public unsafe static void CreateFramebuffers(GLsizei n, GLuint[] framebuffers)
        {
            if (glCreateFramebuffers != null)
            {
                fixed (GLuint* ptr_framebuffers = framebuffers)
                {
                    glCreateFramebuffers(n, ptr_framebuffers);
                }
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferRenderbuffer (GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer);
        public static void NamedFramebufferRenderbuffer(GLuint framebuffer, GLenum attachment, GLenum renderbuffertarget, GLuint renderbuffer)
        {
            if (glNamedFramebufferRenderbuffer != null)
            {
                glNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferParameteri (GLuint framebuffer, GLenum pname, GLint param);
        public static void NamedFramebufferParameteri(GLuint framebuffer, GLenum pname, GLint param)
        {
            if (glNamedFramebufferParameteri != null)
            {
                glNamedFramebufferParameteri(framebuffer, pname, param);
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferTexture (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level);
        public static void NamedFramebufferTexture(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level)
        {
            if (glNamedFramebufferTexture != null)
            {
                glNamedFramebufferTexture(framebuffer, attachment, texture, level);
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferTextureLayer (GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer);
        public static void NamedFramebufferTextureLayer(GLuint framebuffer, GLenum attachment, GLuint texture, GLint level, GLint layer)
        {
            if (glNamedFramebufferTextureLayer != null)
            {
                glNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferDrawBuffer (GLuint framebuffer, GLenum buf);
        public static void NamedFramebufferDrawBuffer(GLuint framebuffer, GLenum buf)
        {
            if (glNamedFramebufferDrawBuffer != null)
            {
                glNamedFramebufferDrawBuffer(framebuffer, buf);
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferDrawBuffers (GLuint framebuffer, GLsizei n, const GLenum *bufs);
        public unsafe static void NamedFramebufferDrawBuffers(GLuint framebuffer, GLsizei n, GLenum[] bufs)
        {
            if (glNamedFramebufferDrawBuffers != null)
            {
                fixed (GLenum* ptr_bufs = bufs)
                {
                    glNamedFramebufferDrawBuffers(framebuffer, n, ptr_bufs);
                }
            }
        }

        // GLAPI void APIENTRY glNamedFramebufferReadBuffer (GLuint framebuffer, GLenum src);
        public static void NamedFramebufferReadBuffer(GLuint framebuffer, GLenum src)
        {
            if (glNamedFramebufferReadBuffer != null)
            {
                glNamedFramebufferReadBuffer(framebuffer, src);
            }
        }

        // GLAPI void APIENTRY glInvalidateNamedFramebufferData (GLuint framebuffer, GLsizei numAttachments, const GLenum *attachments);
        public unsafe static void InvalidateNamedFramebufferData(GLuint framebuffer, GLsizei numAttachments, GLenum[] attachments)
        {
            if (glInvalidateNamedFramebufferData != null)
            {
                fixed (GLenum* ptr_attachments = attachments)
                {
                    glInvalidateNamedFramebufferData(framebuffer, numAttachments, ptr_attachments);
                }
            }
        }

        // GLAPI void APIENTRY glInvalidateNamedFramebufferSubData (GLuint framebuffer, GLsizei numAttachments, const GLenum *attachments, GLint x, GLint y, GLsizei width, GLsizei height);
        public unsafe static void InvalidateNamedFramebufferSubData(GLuint framebuffer, GLsizei numAttachments, GLenum[] attachments, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glInvalidateNamedFramebufferSubData != null)
            {
                fixed (GLenum* ptr_attachments = attachments)
                {
                    glInvalidateNamedFramebufferSubData(framebuffer, numAttachments, ptr_attachments, x, y, width, height);
                }
            }
        }

        // GLAPI void APIENTRY glClearNamedFramebufferiv (GLuint framebuffer, GLenum buffer, GLint drawbuffer, const GLint *value);
        public unsafe static void ClearNamedFramebufferiv(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLint[] value)
        {
            if (glClearNamedFramebufferiv != null)
            {
                fixed (GLint* ptr_value = value)
                {
                    glClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glClearNamedFramebufferuiv (GLuint framebuffer, GLenum buffer, GLint drawbuffer, const GLuint *value);
        public unsafe static void ClearNamedFramebufferuiv(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLuint[] value)
        {
            if (glClearNamedFramebufferuiv != null)
            {
                fixed (GLuint* ptr_value = value)
                {
                    glClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glClearNamedFramebufferfv (GLuint framebuffer, GLenum buffer, GLint drawbuffer, const GLfloat *value);
        public unsafe static void ClearNamedFramebufferfv(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat[] value)
        {
            if (glClearNamedFramebufferfv != null)
            {
                fixed (GLfloat* ptr_value = value)
                {
                    glClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, ptr_value);
                }
            }
        }

        // GLAPI void APIENTRY glClearNamedFramebufferfi (GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil);
        public static void ClearNamedFramebufferfi(GLuint framebuffer, GLenum buffer, GLint drawbuffer, GLfloat depth, GLint stencil)
        {
            if (glClearNamedFramebufferfi != null)
            {
                glClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);
            }
        }

        // GLAPI void APIENTRY glBlitNamedFramebuffer (GLuint readFramebuffer, GLuint drawFramebuffer, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter);
        public static void BlitNamedFramebuffer(GLuint readFramebuffer, GLuint drawFramebuffer, GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter)
        {
            if (glBlitNamedFramebuffer != null)
            {
                glBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
            }
        }

        // GLAPI GLenum APIENTRY glCheckNamedFramebufferStatus (GLuint framebuffer, GLenum target);
        public static GLenum CheckNamedFramebufferStatus(GLuint framebuffer, GLenum target)
        {
            if (glCheckNamedFramebufferStatus != null)
            {
                return glCheckNamedFramebufferStatus(framebuffer, target);
            }
            else
            {
                return 0;
            }
        }

        // GLAPI void APIENTRY glGetNamedFramebufferParameteriv (GLuint framebuffer, GLenum pname, GLint *param);
        public unsafe static void GetNamedFramebufferParameteriv(GLuint framebuffer, GLenum pname, GLint[] param)
        {
            if (glGetNamedFramebufferParameteriv != null)
            {
                fixed (GLint* ptr_param = param)
                {
                    glGetNamedFramebufferParameteriv(framebuffer, pname, ptr_param);
                }
            }
        }
        
        // GLAPI void APIENTRY glGetNamedFramebufferAttachmentParameteriv (GLuint framebuffer, GLenum attachment, GLenum pname, GLint *params);
        public unsafe static void GetNamedFramebufferAttachmentParameteriv(GLuint framebuffer, GLenum attachment, GLenum pname, GLint[] parameters)
        {
            if (glGetNamedFramebufferAttachmentParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glCreateRenderbuffers (GLsizei n, GLuint *renderbuffers);
        public unsafe static void CreateRenderbuffers(GLsizei n, GLuint[] renderbuffers)
        {
            if (glCreateRenderbuffers != null)
            {
                fixed (GLuint* ptr_renderbuffers = renderbuffers)
                {
                    glCreateRenderbuffers(n, ptr_renderbuffers);
                }
            }
        }

        // GLAPI void APIENTRY glNamedRenderbufferStorage (GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height);
        public static void NamedRenderbufferStorage(GLuint renderbuffer, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glNamedRenderbufferStorage != null)
            {
                glNamedRenderbufferStorage(renderbuffer, internalformat, width, height);
            }
        }

        // GLAPI void APIENTRY glNamedRenderbufferStorageMultisample (GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height);
        public static void NamedRenderbufferStorageMultisample(GLuint renderbuffer, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glNamedRenderbufferStorageMultisample != null)
            {
                glNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
            }
        }

        // GLAPI void APIENTRY glGetNamedRenderbufferParameteriv (GLuint renderbuffer, GLenum pname, GLint *params);
        public unsafe static void GetNamedRenderbufferParameteriv(GLuint renderbuffer, GLenum pname, GLint[] parameters)
        {
            if (glGetNamedRenderbufferParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetNamedRenderbufferParameteriv(renderbuffer, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glCreateTextures (GLenum target, GLsizei n, GLuint *textures);
        public unsafe static void CreateTextures(GLenum target, GLsizei n, GLuint[] textures)
        {
            if (glCreateTextures != null)
            {
                fixed (GLuint* ptr_textures = textures)
                {
                    glCreateTextures(target, n, ptr_textures);
                }
            }
        }

        // GLAPI void APIENTRY glTextureBuffer (GLuint texture, GLenum internalformat, GLuint buffer);
        public static void TextureBuffer(GLuint texture, GLenum internalformat, GLuint buffer)
        {
            if (glTextureBuffer != null)
            {
                glTextureBuffer(texture, internalformat, buffer);
            }
        }

        // GLAPI void APIENTRY glTextureBufferRange (GLuint texture, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size);
        public static void TextureBufferRange(GLuint texture, GLenum internalformat, GLuint buffer, GLintptr offset, GLsizeiptr size)
        {
            if (glTextureBufferRange != null)
            {
                glTextureBufferRange(texture, internalformat, buffer, offset, size);
            }
        }

        // GLAPI void APIENTRY glTextureStorage1D (GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width);
        public static void TextureStorage1D(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width)
        {
            if (glTextureStorage1D != null)
            {
                glTextureStorage1D(texture, levels, internalformat, width);
            }
        }

        // GLAPI void APIENTRY glTextureStorage2D (GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height);
        public static void TextureStorage2D(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height)
        {
            if (glTextureStorage2D != null)
            {
                glTextureStorage2D(texture, levels, internalformat, width, height);
            }
        }

        // GLAPI void APIENTRY glTextureStorage3D (GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth);
        public static void TextureStorage3D(GLuint texture, GLsizei levels, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth)
        {
            if (glTextureStorage3D != null)
            {
                glTextureStorage3D(texture, levels, internalformat, width, height, depth);
            }
        }

        // GLAPI void APIENTRY glTextureStorage2DMultisample (GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations);
        public static void TextureStorage2DMultisample(GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLboolean fixedsamplelocations)
        {
            if (glTextureStorage2DMultisample != null)
            {
                glTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
            }
        }

        // GLAPI void APIENTRY glTextureStorage3DMultisample (GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations);
        public static void TextureStorage3DMultisample(GLuint texture, GLsizei samples, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLboolean fixedsamplelocations)
        {
            if (glTextureStorage3DMultisample != null)
            {
                glTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
            }
        }

        // GLAPI void APIENTRY glTextureSubImage1D (GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, const void *pixels);
        public unsafe static void TextureSubImage1D(GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTextureSubImage1D != null)
            {
                glTextureSubImage1D(texture, level, xoffset, width, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glTextureSubImage2D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, const void *pixels);
        public unsafe static void TextureSubImage2D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTextureSubImage2D != null)
            {
                glTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glTextureSubImage3D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, const void *pixels);
        public unsafe static void TextureSubImage3D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, IntPtr pixels)
        {
            if (glTextureSubImage3D != null)
            {
                glTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedTextureSubImage1D (GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, const void *data);
        public unsafe static void CompressedTextureSubImage1D(GLuint texture, GLint level, GLint xoffset, GLsizei width, GLenum format, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTextureSubImage1D != null)
            {
                glCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedTextureSubImage2D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, const void *data);
        public unsafe static void CompressedTextureSubImage2D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLsizei width, GLsizei height, GLenum format, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTextureSubImage2D != null)
            {
                glCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCompressedTextureSubImage3D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, const void *data);
        public unsafe static void CompressedTextureSubImage3D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLsizei imageSize, IntPtr data)
        {
            if (glCompressedTextureSubImage3D != null)
            {
                glCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glCopyTextureSubImage1D (GLuint texture, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);
        public static void CopyTextureSubImage1D(GLuint texture, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width)
        {
            if (glCopyTextureSubImage1D != null)
            {
                glCopyTextureSubImage1D(texture, level, xoffset, x, y, width);
            }
        }

        // GLAPI void APIENTRY glCopyTextureSubImage2D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        public static void CopyTextureSubImage2D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glCopyTextureSubImage2D != null)
            {
                glCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
            }
        }

        // GLAPI void APIENTRY glCopyTextureSubImage3D (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);
        public static void CopyTextureSubImage3D(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height)
        {
            if (glCopyTextureSubImage3D != null)
            {
                glCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
            }
        }

        // GLAPI void APIENTRY glTextureParameterf (GLuint texture, GLenum pname, GLfloat param);
        public static void TextureParameterf(GLuint texture, GLenum pname, GLfloat param)
        {
            if (glTextureParameterf != null)
            {
                glTextureParameterf(texture, pname, param);
            }
        }

        // GLAPI void APIENTRY glTextureParameterfv (GLuint texture, GLenum pname, const GLfloat *param);
        public unsafe static void TextureParameterfv(GLuint texture, GLenum pname, GLfloat[] param)
        {
            if (glTextureParameterfv != null)
            {
                fixed (GLfloat* ptr_param = param)
                {
                    glTextureParameterfv(texture, pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glTextureParameteri (GLuint texture, GLenum pname, GLint param);
        public static void TextureParameteri(GLuint texture, GLenum pname, GLint param)
        {
            if (glTextureParameteri != null)
            {
                glTextureParameteri(texture, pname, param);
            }
        }

        // GLAPI void APIENTRY glTextureParameterIiv (GLuint texture, GLenum pname, const GLint *params);
        public unsafe static void TextureParameterIiv(GLuint texture, GLenum pname, GLint[] parameters)
        {
            if (glTextureParameterIiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glTextureParameterIiv(texture, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glTextureParameterIuiv (GLuint texture, GLenum pname, const GLuint *params);
        public unsafe static void TextureParameterIuiv(GLuint texture, GLenum pname, GLuint[] parameters)
        {
            if (glTextureParameterIuiv != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glTextureParameterIuiv(texture, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glTextureParameteriv (GLuint texture, GLenum pname, const GLint *param);
        public unsafe static void TextureParameteriv(GLuint texture, GLenum pname, GLint[] param)
        {
            if (glTextureParameteriv != null)
            {
                fixed (GLint* ptr_param = param)
                {
                    glTextureParameteriv(texture, pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glGenerateTextureMipmap (GLuint texture);
        public static void GenerateTextureMipmap(GLuint texture)
        {
            if (glGenerateTextureMipmap != null)
            {
                glGenerateTextureMipmap(texture);
            }
        }

        // GLAPI void APIENTRY glBindTextureUnit (GLuint unit, GLuint texture);
        public static void BindTextureUnit(GLuint unit, GLuint texture)
        {
            if (glBindTextureUnit != null)
            {
                glBindTextureUnit(unit, texture);
            }
        }

        // GLAPI void APIENTRY glGetTextureImage (GLuint texture, GLint level, GLenum format, GLenum type, GLsizei bufSize, void *pixels);
        public unsafe static void GetTextureImage(GLuint texture, GLint level, GLenum format, GLenum type, GLsizei bufSize, IntPtr pixels)
        {
            if (glGetTextureImage != null)
            {
                glGetTextureImage(texture, level, format, type, bufSize, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetCompressedTextureImage (GLuint texture, GLint level, GLsizei bufSize, void *pixels);
        public unsafe static void GetCompressedTextureImage(GLuint texture, GLint level, GLsizei bufSize, IntPtr pixels)
        {
            if (glGetCompressedTextureImage != null)
            {
                glGetCompressedTextureImage(texture, level, bufSize, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetTextureLevelParameterfv (GLuint texture, GLint level, GLenum pname, GLfloat *params);
        public unsafe static void GetTextureLevelParameterfv(GLuint texture, GLint level, GLenum pname, GLfloat[] parameters)
        {
            if (glGetTextureLevelParameterfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetTextureLevelParameterfv(texture, level, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTextureLevelParameteriv (GLuint texture, GLint level, GLenum pname, GLint *params);
        public unsafe static void GetTextureLevelParameteriv(GLuint texture, GLint level, GLenum pname, GLint[] parameters)
        {
            if (glGetTextureLevelParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetTextureLevelParameteriv(texture, level, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTextureParameterfv (GLuint texture, GLenum pname, GLfloat *params);
        public unsafe static void GetTextureParameterfv(GLuint texture, GLenum pname, GLfloat[] parameters)
        {
            if (glGetTextureParameterfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetTextureParameterfv(texture, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTextureParameterIiv (GLuint texture, GLenum pname, GLint *params);
        public unsafe static void GetTextureParameterIiv(GLuint texture, GLenum pname, GLint[] parameters)
        {
            if (glGetTextureParameterIiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetTextureParameterIiv(texture, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTextureParameterIuiv (GLuint texture, GLenum pname, GLuint *params);
        public unsafe static void GetTextureParameterIuiv(GLuint texture, GLenum pname, GLuint[] parameters)
        {
            if (glGetTextureParameterIuiv != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetTextureParameterIuiv(texture, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetTextureParameteriv (GLuint texture, GLenum pname, GLint *params);
        public unsafe static void GetTextureParameteriv(GLuint texture, GLenum pname, GLint[] parameters)
        {
            if (glGetTextureParameteriv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetTextureParameteriv(texture, pname, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glCreateVertexArrays (GLsizei n, GLuint *arrays);
        public unsafe static void CreateVertexArrays(GLsizei n, GLuint[] arrays)
        {
            if (glCreateVertexArrays != null)
            {
                fixed (GLuint* ptr_arrays = arrays)
                {
                    glCreateVertexArrays(n, ptr_arrays);
                }
            }
        }

        // GLAPI void APIENTRY glDisableVertexArrayAttrib (GLuint vaobj, GLuint index);
        public static void DisableVertexArrayAttrib(GLuint vaobj, GLuint index)
        {
            if (glDisableVertexArrayAttrib != null)
            {
                glDisableVertexArrayAttrib(vaobj, index);
            }
        }

        // GLAPI void APIENTRY glEnableVertexArrayAttrib (GLuint vaobj, GLuint index);
        public static void EnableVertexArrayAttrib(GLuint vaobj, GLuint index)
        {
            if (glEnableVertexArrayAttrib != null)
            {
                glEnableVertexArrayAttrib(vaobj, index);
            }
        }

        // GLAPI void APIENTRY glVertexArrayElementBuffer (GLuint vaobj, GLuint buffer);
        public static void VertexArrayElementBuffer(GLuint vaobj, GLuint buffer)
        {
            if (glVertexArrayElementBuffer != null)
            {
                glVertexArrayElementBuffer(vaobj, buffer);
            }
        }

        // GLAPI void APIENTRY glVertexArrayVertexBuffer (GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride);
        public static void VertexArrayVertexBuffer(GLuint vaobj, GLuint bindingindex, GLuint buffer, GLintptr offset, GLsizei stride)
        {
            if (glVertexArrayVertexBuffer != null)
            {
                glVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
            }
        }

        // GLAPI void APIENTRY glVertexArrayVertexBuffers (GLuint vaobj, GLuint first, GLsizei count, const GLuint *buffers, const GLintptr *offsets, const GLsizei *strides);
        public unsafe static void VertexArrayVertexBuffers(GLuint vaobj, GLuint first, GLsizei count, GLuint[] buffers, GLintptr[] offsets, GLsizei[] strides)
        {
            if (glVertexArrayVertexBuffers != null)
            {
                fixed (GLuint* ptr_buffers = buffers)
                {
                    fixed (GLintptr* ptr_offsets = offsets)
                    {
                        fixed (GLsizei* ptr_strides = strides)
                        {
                            glVertexArrayVertexBuffers(vaobj, first, count, ptr_buffers, ptr_offsets, ptr_strides);
                        }
                    }
                }
            }
        }

        // GLAPI void APIENTRY glVertexArrayAttribBinding (GLuint vaobj, GLuint attribindex, GLuint bindingindex);
        public static void VertexArrayAttribBinding(GLuint vaobj, GLuint attribindex, GLuint bindingindex)
        {
            if (glVertexArrayAttribBinding != null)
            {
                glVertexArrayAttribBinding(vaobj, attribindex, bindingindex);
            }
        }

        // GLAPI void APIENTRY glVertexArrayAttribFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset);
        public static void VertexArrayAttribFormat(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLboolean normalized, GLuint relativeoffset)
        {
            if (glVertexArrayAttribFormat != null)
            {
                glVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
            }
        }

        // GLAPI void APIENTRY glVertexArrayAttribIFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        public static void VertexArrayAttribIFormat(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
        {
            if (glVertexArrayAttribIFormat != null)
            {
                glVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
            }
        }

        // GLAPI void APIENTRY glVertexArrayAttribLFormat (GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset);
        public static void VertexArrayAttribLFormat(GLuint vaobj, GLuint attribindex, GLint size, GLenum type, GLuint relativeoffset)
        {
            if (glVertexArrayAttribLFormat != null)
            {
                glVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
            }
        }

        // GLAPI void APIENTRY glVertexArrayBindingDivisor (GLuint vaobj, GLuint bindingindex, GLuint divisor);
        public static void VertexArrayBindingDivisor(GLuint vaobj, GLuint bindingindex, GLuint divisor)
        {
            if (glVertexArrayBindingDivisor != null)
            {
                glVertexArrayBindingDivisor(vaobj, bindingindex, divisor);
            }
        }

        // GLAPI void APIENTRY glGetVertexArrayiv (GLuint vaobj, GLenum pname, GLint *param);
        public unsafe static void GetVertexArrayiv(GLuint vaobj, GLenum pname, GLint[] param)
        {
            if (glGetVertexArrayiv != null)
            {
                fixed (GLint* ptr_param = param)
                {
                    glGetVertexArrayiv(vaobj, pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexArrayIndexediv (GLuint vaobj, GLuint index, GLenum pname, GLint *param);
        public unsafe static void GetVertexArrayIndexediv(GLuint vaobj, GLuint index, GLenum pname, GLint[] param)
        {
            if (glGetVertexArrayIndexediv != null)
            {
                fixed (GLint* ptr_param = param)
                {
                    glGetVertexArrayIndexediv(vaobj, index, pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glGetVertexArrayIndexed64iv (GLuint vaobj, GLuint index, GLenum pname, GLint64 *param);
        public unsafe static void GetVertexArrayIndexed64iv(GLuint vaobj, GLuint index, GLenum pname, GLint64[] param)
        {
            if (glGetVertexArrayIndexed64iv != null)
            {
                fixed (GLint64* ptr_param = param)
                {
                    glGetVertexArrayIndexed64iv(vaobj, index, pname, ptr_param);
                }
            }
        }

        // GLAPI void APIENTRY glCreateSamplers (GLsizei n, GLuint *samplers);
        public unsafe static void CreateSamplers(GLsizei n, GLuint[] samplers)
        {
            if (glCreateSamplers != null)
            {
                fixed (GLuint* ptr_samplers = samplers)
                {
                    glCreateSamplers(n, ptr_samplers);
                }
            }
        }

        // GLAPI void APIENTRY glCreateProgramPipelines (GLsizei n, GLuint *pipelines);
        public unsafe static void CreateProgramPipelines(GLsizei n, GLuint[] pipelines)
        {
            if (glCreateProgramPipelines != null)
            {
                fixed (GLuint* ptr_pipelines = pipelines)
                {
                    glCreateProgramPipelines(n, ptr_pipelines);
                }
            }
        }

        // GLAPI void APIENTRY glCreateQueries (GLenum target, GLsizei n, GLuint *ids);
        public unsafe static void CreateQueries(GLenum target, GLsizei n, GLuint[] ids)
        {
            if (glCreateQueries != null)
            {
                fixed (GLuint* ptr_ids = ids)
                {
                    glCreateQueries(target, n, ptr_ids);
                }
            }
        }

        // GLAPI void APIENTRY glGetQueryBufferObjecti64v (GLuint id, GLuint buffer, GLenum pname, GLintptr offset);
        public static void GetQueryBufferObjecti64v(GLuint id, GLuint buffer, GLenum pname, GLintptr offset)
        {
            if (glGetQueryBufferObjecti64v != null)
            {
                glGetQueryBufferObjecti64v(id, buffer, pname, offset);
            }
        }

        // GLAPI void APIENTRY glGetQueryBufferObjectiv (GLuint id, GLuint buffer, GLenum pname, GLintptr offset);
        public static void GetQueryBufferObjectiv(GLuint id, GLuint buffer, GLenum pname, GLintptr offset)
        {
            if (glGetQueryBufferObjectiv != null)
            {
                glGetQueryBufferObjectiv(id, buffer, pname, offset);
            }
        }

        // GLAPI void APIENTRY glGetQueryBufferObjectui64v (GLuint id, GLuint buffer, GLenum pname, GLintptr offset);
        public static void GetQueryBufferObjectui64v(GLuint id, GLuint buffer, GLenum pname, GLintptr offset)
        {
            if (glGetQueryBufferObjectui64v != null)
            {
                glGetQueryBufferObjectui64v(id, buffer, pname, offset);
            }
        }

        // GLAPI void APIENTRY glGetQueryBufferObjectuiv (GLuint id, GLuint buffer, GLenum pname, GLintptr offset);
        public static void GetQueryBufferObjectuiv(GLuint id, GLuint buffer, GLenum pname, GLintptr offset)
        {
            if (glGetQueryBufferObjectuiv != null)
            {
                glGetQueryBufferObjectuiv(id, buffer, pname, offset);
            }
        }

        // GLAPI void APIENTRY glMemoryBarrierByRegion (GLbitfield barriers);
        public static void MemoryBarrierByRegion(GLbitfield barriers)
        {
            if (glMemoryBarrierByRegion != null)
            {
                glMemoryBarrierByRegion(barriers);
            }
        }

        // GLAPI void APIENTRY glGetTextureSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, GLsizei bufSize, void *pixels);
        public unsafe static void GetTextureSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, GLsizei bufSize, IntPtr pixels)
        {
            if (glGetTextureSubImage != null)
            {
                glGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetCompressedTextureSubImage (GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei bufSize, void *pixels);
        public unsafe static void GetCompressedTextureSubImage(GLuint texture, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLsizei bufSize, IntPtr pixels)
        {
            if (glGetCompressedTextureSubImage != null)
            {
                glGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels.ToPointer());
            }
        }

        // GLAPI GLenum APIENTRY glGetGraphicsResetStatus (void);
        public static GLenum GetGraphicsResetStatus()
        {
            if (glGetGraphicsResetStatus != null)
            {
                return glGetGraphicsResetStatus();
            }
            else
            {
                return 0;
            }
        }
        // GLAPI void APIENTRY glGetnCompressedTexImage (GLenum target, GLint lod, GLsizei bufSize, void *pixels);
        public unsafe static void GetnCompressedTexImage(GLenum target, GLint lod, GLsizei bufSize, IntPtr pixels)
        {
            if (glGetnCompressedTexImage != null)
            {
                glGetnCompressedTexImage(target, lod, bufSize, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetnTexImage (GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, void *pixels);
        public unsafe static void GetnTexImage(GLenum target, GLint level, GLenum format, GLenum type, GLsizei bufSize, IntPtr pixels)
        {
            if (glGetnTexImage != null)
            {
                glGetnTexImage(target, level, format, type, bufSize, pixels.ToPointer());
            }
        }

        // GLAPI void APIENTRY glGetnUniformdv (GLuint program, GLint location, GLsizei bufSize, GLdouble *params);
        public unsafe static void GetnUniformdv(GLuint program, GLint location, GLsizei bufSize, GLdouble[] parameters)
        {
            if (glGetnUniformdv != null)
            {
                fixed (GLdouble* ptr_parameters = parameters)
                {
                    glGetnUniformdv(program, location, bufSize, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetnUniformfv (GLuint program, GLint location, GLsizei bufSize, GLfloat *params);
        public unsafe static void GetnUniformfv(GLuint program, GLint location, GLsizei bufSize, GLfloat[] parameters)
        {
            if (glGetnUniformfv != null)
            {
                fixed (GLfloat* ptr_parameters = parameters)
                {
                    glGetnUniformfv(program, location, bufSize, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetnUniformiv (GLuint program, GLint location, GLsizei bufSize, GLint *params);
        public unsafe static void GetnUniformiv(GLuint program, GLint location, GLsizei bufSize, GLint[] parameters)
        {
            if (glGetnUniformiv != null)
            {
                fixed (GLint* ptr_parameters = parameters)
                {
                    glGetnUniformiv(program, location, bufSize, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glGetnUniformuiv (GLuint program, GLint location, GLsizei bufSize, GLuint *params);
        public unsafe static void GetnUniformuiv(GLuint program, GLint location, GLsizei bufSize, GLuint[] parameters)
        {
            if (glGetnUniformuiv != null)
            {
                fixed (GLuint* ptr_parameters = parameters)
                {
                    glGetnUniformuiv(program, location, bufSize, ptr_parameters);
                }
            }
        }

        // GLAPI void APIENTRY glReadnPixels (GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, void *data);
        public unsafe static void ReadnPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLsizei bufSize, IntPtr data)
        {
            if (glReadnPixels != null)
            {
                glReadnPixels(x, y, width, height, format, type, bufSize, data.ToPointer());
            }
        }

        // GLAPI void APIENTRY glTextureBarrier (void);
        public static void TextureBarrier()
        {
            if (glTextureBarrier != null)
            {
                glTextureBarrier();
            }
        }

        #endregion
    }
}