// ----------------------------------------------------------------------------
// FILE		: glu.functions.cs
// VERSION	: 1.1.2
// COMMENT	: OpenGL Utility (GLU) library low level functions.
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
        // GLU FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        // const GLubyte* APIENTRY gluErrorString ( GLenum   errCode);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern GLubyte* gluErrorString(GLenum errCode);

        // const wchar_t* APIENTRY gluErrorUnicodeStringEXT ( GLenum   errCode);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern char* gluErrorUnicodeStringEXT(GLenum errCode);

        // const GLubyte* APIENTRY gluGetString ( GLenum   name);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern GLubyte* gluGetString(GLenum name);

        // void APIENTRY gluOrtho2D (GLdouble left, GLdouble right, GLdouble bottom, GLdouble top);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluOrtho2D (GLdouble left, GLdouble right, GLdouble bottom, GLdouble top);

        // void APIENTRY gluPerspective (GLdouble fovy, GLdouble aspect, GLdouble zNear, GLdouble zFar);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluPerspective (GLdouble fovy, GLdouble aspect, GLdouble zNear, GLdouble zFar);

        // void APIENTRY gluPickMatrix (GLdouble x, GLdouble y, GLdouble width, GLdouble height, GLint viewport[4]);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern void gluPickMatrix (GLdouble x, GLdouble y, GLdouble width, GLdouble height, GLint[] viewport);

        // void APIENTRY gluLookAt (GLdouble eyex, GLdouble eyey, GLdouble eyez, GLdouble centerx, GLdouble centery, GLdouble centerz, GLdouble upx, GLdouble upy, GLdouble upz);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluLookAt (GLdouble eyex, GLdouble eyey, GLdouble eyez, GLdouble centerx, GLdouble centery, GLdouble centerz, GLdouble upx, GLdouble upy, GLdouble upz);
        
        // int APIENTRY gluProject (GLdouble objx, GLdouble objy, GLdouble objz, const GLdouble modelMatrix[16], const GLdouble projMatrix[16], const GLint viewport[4], GLdouble *winx, GLdouble *winy, GLdouble *winz);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern int gluProject (GLdouble objx, GLdouble objy, GLdouble objz, GLdouble[] modelMatrix, GLdouble[] projMatrix, GLint[] viewport, out GLdouble winx, out GLdouble winy, out GLdouble winz);
        
        // int APIENTRY gluUnProject (GLdouble winx, GLdouble winy, GLdouble winz, const GLdouble modelMatrix[16], const GLdouble projMatrix[16], const GLint viewport[4], GLdouble *objx, GLdouble *objy, GLdouble *objz);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern int gluUnproject (GLdouble winx, GLdouble winy, GLdouble winz, GLdouble[] modelMatrix, GLdouble[] projMatrix, GLint[] viewport, out GLdouble objx, out GLdouble objy, out GLdouble objz);

        // int APIENTRY gluScaleImage (GLenum format, GLint widthin, GLint heightin, GLenum typein, const void *datain, GLint widthout, GLint heightout, GLenum typeout, void *dataout);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern int gluScaleImage (GLenum format, GLint widthin, GLint heightin, GLenum typein, void* datain, GLint widthout, GLint heightout, GLenum typeout, void* dataout);
        
        // int APIENTRY gluBuild1DMipmaps (GLenum target, GLint components, GLint width, GLenum format, GLenum type, const void  *data);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern int gluBuild1DMipmaps (GLenum target, GLint components, GLint width, GLenum format, GLenum type, void* data);

        // int APIENTRY gluBuild2DMipmaps (GLenum target, GLint components, GLint width, GLint height, GLenum format, GLenum type, const void  *data);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern int gluBuild2DMipmaps(GLenum target, GLint components, GLint width, GLint height, GLenum format, GLenum type, void* data);

        ///////////////////////////////////////////////////////////////////////
        // GLU QUADRIC FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        // void (CALLBACK* fn)()
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKfn ();

        // GLUquadric* APIENTRY gluNewQuadric (void);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern GLUquadric gluNewQuadric();

        // void APIENTRY gluDeleteQuadric (GLUquadric *state);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluDeleteQuadric (GLUquadric state);

        // void APIENTRY gluQuadricNormals (GLUquadric *quadObject, GLenum normals);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluQuadricNormals(GLUquadric quadObject, GLenum normals);
        
        // void APIENTRY gluQuadricTexture (GLUquadric *quadObject, GLboolean textureCoords);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluQuadricTexture(GLUquadric quadObject, GLboolean textureCoords);

        // void APIENTRY gluQuadricOrientation (GLUquadric *quadObject, GLenum orientation);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluQuadricOrientation (GLUquadric quadObject, GLenum orientation);

        // void APIENTRY gluQuadricDrawStyle (GLUquadric *quadObject, GLenum drawStyle);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluQuadricDrawStyle (GLUquadric quadObject, GLenum drawStyle);

        // void APIENTRY gluCylinder (GLUquadric *qobj, GLdouble baseRadius, GLdouble topRadius, GLdouble height, GLint slices, GLint stacks);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluCylinder (GLUquadric qobj, GLdouble baseRadius, GLdouble topRadius, GLdouble height, GLint slices, GLint stacks);

        // void APIENTRY gluDisk (GLUquadric *qobj, GLdouble innerRadius, GLdouble outerRadius, GLint slices, GLint loops);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluDisk (GLUquadric qobj, GLdouble innerRadius, GLdouble outerRadius, GLint slices, GLint loops);

        // void APIENTRY gluPartialDisk (GLUquadric *qobj, GLdouble innerRadius, GLdouble outerRadius, GLint slices, GLint loops, GLdouble startAngle, GLdouble sweepAngle);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluPartialDisk (GLUquadric qobj, GLdouble innerRadius, GLdouble outerRadius, GLint slices, GLint loops, GLdouble startAngle, GLdouble sweepAngle);

        // void APIENTRY gluSphere (GLUquadric *qobj, GLdouble radius, GLint slices, GLint stacks);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluSphere (GLUquadric qobj, GLdouble radius, GLint slices, GLint stacks);

        // void APIENTRY gluQuadricCallback (GLUquadric *qobj, GLenum which, void (CALLBACK* fn)());
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluQuadricCallback (GLUquadric qobj, GLenum which, TCALLBACKfn fn);

        ///////////////////////////////////////////////////////////////////////
        // GLU TESSELATOR FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        // GLUtesselator* APIENTRY  gluNewTess( void );
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern GLUtesselator gluNewTess ();

        // void APIENTRY  gluDeleteTess(GLUtesselator *tess);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluDeleteTess (GLUtesselator tess);

        // void APIENTRY  gluTessBeginPolygon(GLUtesselator *tess, void *polygon_data);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern void gluTessBeginPolygon (GLUtesselator tess, void* polygon_data);

        // void APIENTRY  gluTessBeginContour(GLUtesselator *tess);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluTessBeginContour (GLUtesselator tess);

        // void APIENTRY  gluTessVertex(GLUtesselator *tess, GLdouble coords[3], void *data);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern void gluTessVertex (GLUtesselator tess, GLdouble[] coords, void* data);
 
        // void APIENTRY  gluTessEndContour(GLUtesselator *tess);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluTessEndContour (GLUtesselator tess);

        // void APIENTRY  gluTessEndPolygon(GLUtesselator *tess);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluTessEndPolygon (GLUtesselator tess);

        // void APIENTRY  gluTessProperty(GLUtesselator *tess, GLenum which, GLdouble value);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluTessProperty (GLUtesselator tess, GLenum which, GLdouble value);
        
        // void APIENTRY  gluTessNormal(GLUtesselator *tess, GLdouble x, GLdouble y, GLdouble z);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluTessNormal (GLUtesselator tess, GLdouble x, GLdouble y, GLdouble z);

        // void APIENTRY  gluTessCallback(GLUtesselator *tess, GLenum which, void (CALLBACK *fn)());
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluTessCallback (GLUtesselator tess, GLenum which, TCALLBACKfn fn);

        // void APIENTRY  gluGetTessProperty(GLUtesselator *tess, GLenum which, GLdouble *value);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluGetTessProperty (GLUtesselator tess, GLenum which, out GLdouble value);

        ///////////////////////////////////////////////////////////////////////
        // GLU NURBS FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        // GLUnurbs* APIENTRY gluNewNurbsRenderer (void);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern GLUnurbs gluNewNurbsRenderer ();

        // void APIENTRY gluDeleteNurbsRenderer (GLUnurbs *nobj);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluDeleteNurbsRenderer (GLUnurbs nobj);

        // void APIENTRY gluBeginSurface (GLUnurbs *nobj);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluBeginSurface (GLUnurbs nobj);

        // void APIENTRY gluBeginCurve (GLUnurbs *nobj);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluBeginCurve (GLUnurbs nobj);

        // void APIENTRY gluEndCurve (GLUnurbs *nobj);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluEndCurve (GLUnurbs nobj);

        // void APIENTRY gluEndSurface (GLUnurbs *nobj);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluEndSurface (GLUnurbs nobj);

        // void APIENTRY gluBeginTrim (GLUnurbs *nobj);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluBeginTrim (GLUnurbs nobj);

        // void APIENTRY gluEndTrim (GLUnurbs *nobj);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluEndTrim (GLUnurbs nobj);

        // void APIENTRY gluPwlCurve (GLUnurbs *nobj, GLint count, GLfloat *array, GLint stride, GLenum type);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern void gluPwlCurve (GLUnurbs nobj, GLint count, GLfloat* array, GLint stride, GLenum type);

        // void APIENTRY gluNurbsCurve (GLUnurbs *nobj, GLint nknots, GLfloat *knot, GLint stride, GLfloat *ctlarray, GLint order, GLenum type);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern void gluNurbsCurve (GLUnurbs nobj, GLint nknots, GLfloat* knot, GLint stride, GLfloat* ctlarray, GLint order, GLenum type);

        // void APIENTRY gluNurbsSurface(GLUnurbs *nobj, GLint sknot_count, GLfloat *sknot, GLint tknot_count, GLfloat *tknot, GLint s_stride, GLint t_stride, GLfloat *ctlarray, GLint sorder, GLint torder, GLenum type);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe static extern void gluNurbsSurface (GLUnurbs nobj, GLint sknot_count, GLfloat* sknot, GLint tknot_count, GLfloat* tknot, GLint s_stride, GLint t_stride, GLfloat* ctlarray, GLint sorder, GLint torder, GLenum type);

        // void APIENTRY gluLoadSamplingMatrices (GLUnurbs *nobj, const GLfloat modelMatrix[16], const GLfloat projMatrix[16], const GLint viewport[4]);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluLoadSamplingMatrices (GLUnurbs nobj, GLfloat[] modelMatrix, GLfloat[] projMatrix, GLint[] viewport); 
        
        // void APIENTRY gluNurbsProperty (GLUnurbs *nobj, GLenum property, GLfloat value);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluNurbsProperty (GLUnurbs nobj, GLenum property, GLfloat value);

        // void APIENTRY gluGetNurbsProperty (GLUnurbs *nobj, GLenum property, GLfloat *value);
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluGetNurbsProperty (GLUnurbs nobj, GLenum property, out GLfloat value);

        // void APIENTRY gluNurbsCallback (GLUnurbs *nobj, GLenum which, void (CALLBACK* fn)());
        [DllImport("glu32.dll", CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void gluNurbsCallback (GLUnurbs nobj, GLenum which, TCALLBACKfn fn);
    }
}
