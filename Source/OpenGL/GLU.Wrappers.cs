// ----------------------------------------------------------------------------
// FILE		: glu.wrappers.cs
// VERSION	: 1.1.3
// DATE     : 26 April 2018
// COMMENT	: OpenGL Utility (GLU) library wrappers for low level functions.
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

/* GLU specific types */
using GLUnurbs = System.IntPtr;
using GLUquadric = System.IntPtr;
using GLUtesselator = System.IntPtr;
/* GLU backwards compatibility */
using GLUnurbsObj = System.IntPtr;
using GLUquadricObj = System.IntPtr;
using GLUtesselatorObj = System.IntPtr;
using GLUtriangulatorObj = System.IntPtr;

namespace OpenGLDotNet
{
    public static partial class GLU
    {
        ///////////////////////////////////////////////////////////////////////
        // GLU WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        // const GLubyte* APIENTRY gluErrorString ( GLenum   errCode);
        public unsafe static string ErrorString(GLenum errCode)
        {
            return new string((sbyte*)gluErrorString(errCode));
        }

        // const wchar_t* APIENTRY gluErrorUnicodeStringEXT ( GLenum   errCode);
        public unsafe static string ErrorUnicodeStringEXT(GLenum errCode)
        {
            return new string((char*)gluErrorUnicodeStringEXT(errCode));
        }

        // const GLubyte* APIENTRY gluGetString ( GLenum   name);
        public unsafe static string GetString(GLenum name)
        {
            return new string((sbyte*)gluGetString(name));
        }

        // void APIENTRY gluOrtho2D (GLdouble left, GLdouble right, GLdouble bottom, GLdouble top);
        public static void Ortho2D(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top)
        {
            gluOrtho2D(left, right, bottom, top);
        }

        // void APIENTRY gluPerspective (GLdouble fovy, GLdouble aspect, GLdouble zNear, GLdouble zFar);
        public static void Perspective(GLdouble fovy, GLdouble aspect, GLdouble zNear, GLdouble zFar)
        {
            gluPerspective(fovy, aspect, zNear, zFar);
        }

        // void APIENTRY gluPickMatrix (GLdouble x, GLdouble y, GLdouble width, GLdouble height, GLint viewport[4]);
        public static void PickMatrix(GLdouble x, GLdouble y, GLdouble width, GLdouble height, GLint[] viewport)
        {
            gluPickMatrix(x, y, width, height, viewport);
        }

        // void APIENTRY gluLookAt (GLdouble eyex, GLdouble eyey, GLdouble eyez, GLdouble centerx, GLdouble centery, GLdouble centerz, GLdouble upx, GLdouble upy, GLdouble upz);
        public static void LookAt(GLdouble eyex, GLdouble eyey, GLdouble eyez, GLdouble centerx, GLdouble centery, GLdouble centerz, GLdouble upx, GLdouble upy, GLdouble upz)
        {
            gluLookAt(eyex, eyey, eyez, centerx, centery, centerz, upx, upy, upz);
        }

        // int APIENTRY gluProject (GLdouble objx, GLdouble objy, GLdouble objz, const GLdouble modelMatrix[16], const GLdouble projMatrix[16], const GLint viewport[4], GLdouble *winx, GLdouble *winy, GLdouble *winz);
        public static int Project(GLdouble objx, GLdouble objy, GLdouble objz, GLdouble[] modelMatrix, GLdouble[] projMatrix, GLint[] viewport, out GLdouble winx, out GLdouble winy, out GLdouble winz)
        {
            return gluProject(objx, objy, objz, modelMatrix, projMatrix, viewport, out winx, out winy, out winz);
        }

        // int APIENTRY gluUnProject (GLdouble winx, GLdouble winy, GLdouble winz, const GLdouble modelMatrix[16], const GLdouble projMatrix[16], const GLint viewport[4], GLdouble *objx, GLdouble *objy, GLdouble *objz);
        public static int UnProject(GLdouble winx, GLdouble winy, GLdouble winz, GLdouble[] modelMatrix, GLdouble[] projMatrix, GLint[] viewport, out GLdouble objx, out GLdouble objy, out GLdouble objz)
        {
            return gluUnproject(winx, winy, winz, modelMatrix, projMatrix, viewport, out objx, out objy, out objz);
        }

        // int APIENTRY gluScaleImage (GLenum format, GLint widthin, GLint heightin, GLenum typein, const void *datain, GLint widthout, GLint heightout, GLenum typeout, void *dataout);
        public unsafe static int ScaleImage(GLenum format, GLint widthin, GLint heightin, GLenum typein, IntPtr datain, GLint widthout, GLint heightout, GLenum typeout, IntPtr dataout)
        {
            return gluScaleImage(format, widthin, heightin, typein, datain.ToPointer(), widthout, heightout, typeout, dataout.ToPointer());
        }

        // int APIENTRY gluBuild1DMipmaps (GLenum target, GLint components, GLint width, GLenum format, GLenum type, const void  *data);
        public unsafe static int Build1DMipmaps(GLenum target, GLint components, GLint width, GLenum format, GLenum type, IntPtr data)
        {
            return gluBuild1DMipmaps(target, components, width, format, type, data.ToPointer());
        }

        // int APIENTRY gluBuild2DMipmaps (GLenum target, GLint components, GLint width, GLint height, GLenum format, GLenum type, const void  *data);
        public unsafe static int Build2DMipmaps(GLenum target, GLint components, GLint width, GLint height, GLenum format, GLenum type, IntPtr data)
        {
            return gluBuild2DMipmaps(target, components, width, height, format, type, data.ToPointer());
        }

        ///////////////////////////////////////////////////////////////////////
        // GLU QUADRIC FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        // GLUquadric* APIENTRY gluNewQuadric (void);
        public static GLUquadric NewQuadric()
        {
            return gluNewQuadric();
        }

        // void APIENTRY gluDeleteQuadric (GLUquadric *state);
        public static void DeleteQuadric(GLUquadric state)
        {
            gluDeleteQuadric(state);
        }

        // void APIENTRY gluQuadricNormals (GLUquadric *quadObject, GLenum normals);
        public static void QuadricNormals(GLUquadric quadObject, GLenum normals)
        {
            gluQuadricNormals(quadObject, normals);
        }

        // void APIENTRY gluQuadricTexture (GLUquadric *quadObject, GLboolean textureCoords);
        public static void QuadricTexture(GLUquadric quadObject, GLboolean textureCoords)
        {
            gluQuadricTexture(quadObject, textureCoords);
        }

        // void APIENTRY gluQuadricOrientation (GLUquadric *quadObject, GLenum orientation);
        public static void QuadricOrientation(GLUquadric quadObject, GLenum orientation)
        {
            gluQuadricOrientation(quadObject, orientation);
        }

        // void APIENTRY gluQuadricDrawStyle (GLUquadric *quadObject, GLenum drawStyle);
        public static void QuadricDrawStyle(GLUquadric quadObject, GLenum drawStyle)
        {
            gluQuadricDrawStyle(quadObject, drawStyle);
        }

        // void APIENTRY gluCylinder (GLUquadric *qobj, GLdouble baseRadius, GLdouble topRadius, GLdouble height, GLint slices, GLint stacks);
        public static void Cylinder(GLUquadric qobj, GLdouble baseRadius, GLdouble topRadius, GLdouble height, GLint slices, GLint stacks)
        {
            gluCylinder(qobj, baseRadius, topRadius, height, slices, stacks);
        }

        // void APIENTRY gluDisk (GLUquadric *qobj, GLdouble innerRadius, GLdouble outerRadius, GLint slices, GLint loops);
        public static void Disk(GLUquadric qobj, GLdouble innerRadius, GLdouble outerRadius, GLint slices, GLint loops)
        {
            gluDisk (qobj, innerRadius, outerRadius, slices, loops);
        }

        // void APIENTRY gluPartialDisk (GLUquadric *qobj, GLdouble innerRadius, GLdouble outerRadius, GLint slices, GLint loops, GLdouble startAngle, GLdouble sweepAngle);
        public static void PartialDisk(GLUquadric qobj, GLdouble innerRadius, GLdouble outerRadius, GLint slices, GLint loops, GLdouble startAngle, GLdouble sweepAngle)
        {
            gluPartialDisk(qobj, innerRadius, outerRadius, slices, loops, startAngle, sweepAngle);
        }

        // void APIENTRY gluSphere (GLUquadric *qobj, GLdouble radius, GLint slices, GLint stacks);
        public static void Sphere(GLUquadric qobj, GLdouble radius, GLint slices, GLint stacks)
        {
            gluSphere(qobj, radius, slices, stacks);
        }

        // void APIENTRY gluQuadricCallback (GLUquadric *qobj, GLenum which, void (CALLBACK* fn)());
        public static void QuadricCallback(GLUquadric qobj, GLenum which, TCALLBACKfn fn)
        {
            gluQuadricCallback(qobj, which, fn);
        }

        ///////////////////////////////////////////////////////////////////////
        // GLU TESSELATOR FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        // GLUtesselator* APIENTRY  gluNewTess( void );
        public static GLUtesselator NewTess()
        {
            return gluNewTess();
        }

        // void APIENTRY  gluDeleteTess(GLUtesselator *tess);
        public static void DeleteTess(GLUtesselator tess)
        {
            gluDeleteTess(tess);
        }

        // void APIENTRY  gluTessBeginPolygon(GLUtesselator *tess, void *polygon_data);
        public unsafe static void TessBeginPolygon(GLUtesselator tess, IntPtr polygon_data)
        {
            gluTessBeginPolygon(tess, polygon_data.ToPointer());
        }

        // void APIENTRY  gluTessBeginContour(GLUtesselator *tess);
        public static void TessBeginContour(GLUtesselator tess)
        {
            gluTessBeginContour(tess);
        }

        // void APIENTRY  gluTessVertex(GLUtesselator *tess, GLdouble coords[3], void *data);
        public unsafe static void TessVertex(GLUtesselator tess, GLdouble[] coords, IntPtr data)
        {
            gluTessVertex(tess, coords, data.ToPointer());
        }

        // void APIENTRY  gluTessEndContour(GLUtesselator *tess);
        public static void TessEndContour(GLUtesselator tess)
        {
            gluTessEndContour(tess);
        }

        // void APIENTRY  gluTessEndPolygon(GLUtesselator *tess);
        public static void TessEndPolygon(GLUtesselator tess)
        {
            gluTessEndPolygon(tess);
        }

        // void APIENTRY  gluTessProperty(GLUtesselator *tess, GLenum which, GLdouble value);
        public static void TessProperty(GLUtesselator tess, GLenum which, GLdouble value)
        {
            gluTessProperty(tess, which, value);
        }

        // void APIENTRY  gluTessNormal(GLUtesselator *tess, GLdouble x, GLdouble y, GLdouble z);
        public static void TessNormal(GLUtesselator tess, GLdouble x, GLdouble y, GLdouble z)
        {
            gluTessNormal(tess, x, y, z);
        }

        // void APIENTRY  gluTessCallback(GLUtesselator *tess, GLenum which, void (CALLBACK *fn)());
        public static void TessCallback(GLUtesselator tess, GLenum which, TCALLBACKfn fn)
        {
            gluTessCallback(tess, which, fn);
        }

        // void APIENTRY  gluGetTessProperty(GLUtesselator *tess, GLenum which, GLdouble *value);
        public static void GetTessProperty(GLUtesselator tess, GLenum which, out GLdouble value)
        {
            gluGetTessProperty(tess, which, out value);
        }

        ///////////////////////////////////////////////////////////////////////
        // GLU NURBS FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        // GLUnurbs* APIENTRY gluNewNurbsRenderer (void);
        public static GLUnurbs NewNurbsRenderer()
        {
            return gluNewNurbsRenderer();
        }

        // void APIENTRY gluDeleteNurbsRenderer (GLUnurbs *nobj);
        public static void DeleteNurbsRenderer(GLUnurbs nobj)
        {
            gluDeleteNurbsRenderer(nobj);
        }

        // void APIENTRY gluBeginSurface (GLUnurbs *nobj);
        public static void BeginSurface(GLUnurbs nobj)
        {
            gluBeginSurface(nobj);
        }

        // void APIENTRY gluBeginCurve (GLUnurbs *nobj);
        public static void BeginCurve(GLUnurbs nobj)
        {
            gluBeginCurve(nobj);
        }

        // void APIENTRY gluEndCurve (GLUnurbs *nobj);
        public static void EndCurve(GLUnurbs nobj)
        {
            gluEndCurve(nobj);
        }

        // void APIENTRY gluEndSurface (GLUnurbs *nobj);
        public static void EndSurface(GLUnurbs nobj)
        {
            gluEndSurface(nobj);
        }

        // void APIENTRY gluBeginTrim (GLUnurbs *nobj);
        public static void BeginTrim(GLUnurbs nobj)
        {
            gluBeginTrim(nobj);
        }

        // void APIENTRY gluEndTrim (GLUnurbs *nobj);
        public static void EndTrim(GLUnurbs nobj)
        {
            gluEndTrim(nobj);
        }

        // void APIENTRY gluPwlCurve (GLUnurbs *nobj, GLint count, GLfloat *array, GLint stride, GLenum type);
        public unsafe static void PwlCurve(GLUnurbs nobj, GLint count, GLfloat[] array, GLint stride, GLenum type)
        {
            fixed (GLfloat* ptr_array = array)
            {
                gluPwlCurve(nobj, count, ptr_array, stride, type);
            }
        }

        // void APIENTRY gluNurbsCurve (GLUnurbs *nobj, GLint nknots, GLfloat *knot, GLint stride, GLfloat *ctlarray, GLint order, GLenum type);
        public unsafe static void NurbsCurve(GLUnurbs nobj, GLint nknots, GLfloat[] knot, GLint stride, GLfloat[] ctlarray, GLint order, GLenum type)
        {
            fixed (GLfloat* ptr_knot = knot)
            {
                fixed (GLfloat* ptr_ctlarray = ctlarray)
                {
                    gluNurbsCurve(nobj, nknots, ptr_knot, stride, ptr_ctlarray, order, type);
                }
            }
        }

        // void APIENTRY gluNurbsSurface(GLUnurbs *nobj, GLint sknot_count, GLfloat *sknot, GLint tknot_count, GLfloat *tknot, GLint s_stride, GLint t_stride, GLfloat *ctlarray, GLint sorder, GLint torder, GLenum type);
        public unsafe static void NurbsSurface(GLUnurbs nobj, GLint sknot_count, GLfloat[] sknot, GLint tknot_count, GLfloat[] tknot, GLint s_stride, GLint t_stride, GLfloat[] ctlarray, GLint sorder, GLint torder, GLenum type)
        {
            fixed (GLfloat* ptr_sknot = sknot)
            {
                fixed (GLfloat* ptr_tknot = tknot)
                {
                    fixed (GLfloat* ptr_ctlarray = ctlarray)
                    {
                        gluNurbsSurface(nobj, sknot_count, ptr_sknot, tknot_count, ptr_tknot, s_stride, t_stride, ptr_ctlarray, sorder, torder, type);
                    }
                }
            }
        }

        // void APIENTRY gluLoadSamplingMatrices (GLUnurbs *nobj, const GLfloat modelMatrix[16], const GLfloat projMatrix[16], const GLint viewport[4]);
        public static void LoadSamplingMatrices(GLUnurbs nobj, GLfloat[] modelMatrix, GLfloat[] projMatrix, GLint[] viewport)
        {
            gluLoadSamplingMatrices(nobj, modelMatrix, projMatrix, viewport);
        }

        // void APIENTRY gluNurbsProperty (GLUnurbs *nobj, GLenum property, GLfloat value);
        public static void NurbsProperty(GLUnurbs nobj, GLenum property, GLfloat value)
        {
            gluNurbsProperty(nobj, property, value);
        }

        // void APIENTRY gluGetNurbsProperty (GLUnurbs *nobj, GLenum property, GLfloat *value);
        public static void GetNurbsProperty(GLUnurbs nobj, GLenum property, out GLfloat value)
        {
            gluGetNurbsProperty(nobj, property, out value);
        }

        // void APIENTRY gluNurbsCallback (GLUnurbs *nobj, GLenum which, void (CALLBACK* fn)());
        public static void NurbsCallback(GLUnurbs nobj, GLenum which, TCALLBACKfn fn)
        {
            gluNurbsCallback(nobj, which, fn);
        }
    }
}
