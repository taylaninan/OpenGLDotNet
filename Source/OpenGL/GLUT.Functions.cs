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
    public static partial class GLUT
    {
        ///////////////////////////////////////////////////////////////////////
        // GLUT FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        //---------------------------------------------------------------------
        // GLUT initialization sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutInit(int *argcp, char **argv);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern void glutInit(int* argcp, byte** argv);

        // GLUTAPI void APIENTRY glutInitDisplayMode(unsigned int mode);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutInitDisplayMode(uint mode);

        // GLUTAPI void APIENTRY glutInitDisplayString(const char *string);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutInitDisplayString (string str);

        // GLUTAPI void APIENTRY glutInitWindowPosition(int x, int y);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutInitWindowPosition(int x, int y);

        // GLUTAPI void APIENTRY glutInitWindowSize(int width, int height);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutInitWindowSize(int width, int height);

        // GLUTAPI void APIENTRY glutMainLoop(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutMainLoop();

        //---------------------------------------------------------------------
        // GLUT window sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI int APIENTRY glutCreateWindow(const char *title);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int glutCreateWindow(string title);

        // GLUTAPI int APIENTRY glutCreateSubWindow(int win, int x, int y, int width, int height);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutCreateSubWindow(int win, int x, int y, int width, int height);

        // GLUTAPI void APIENTRY glutDestroyWindow(int win);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutDestroyWindow(int win);

        // GLUTAPI void APIENTRY glutPostRedisplay(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPostRedisplay();

        // GLUTAPI void APIENTRY glutPostWindowRedisplay(int win);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPostWindowRedisplay(int win);

        // GLUTAPI void APIENTRY glutSwapBuffers(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSwapBuffers();

        // GLUTAPI int APIENTRY glutGetWindow(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutGetWindow();

        // GLUTAPI void APIENTRY glutSetWindow(int win);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSetWindow(int win);

        // GLUTAPI void APIENTRY glutSetWindowTitle(const char *title);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutSetWindowTitle(string title);

        // GLUTAPI void APIENTRY glutSetIconTitle(const char *title);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutSetIconTitle(string title);

        // GLUTAPI void APIENTRY glutPositionWindow(int x, int y);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPositionWindow(int x, int y);

        // GLUTAPI void APIENTRY glutReshapeWindow(int width, int height);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutReshapeWindow(int width, int height);

        // GLUTAPI void APIENTRY glutPopWindow(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPopWindow();

        // GLUTAPI void APIENTRY glutPushWindow(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPushWindow();

        // GLUTAPI void APIENTRY glutIconifyWindow(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutIconifyWindow();

        // GLUTAPI void APIENTRY glutShowWindow(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutShowWindow();

        // GLUTAPI void APIENTRY glutHideWindow(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutHideWindow();

        // GLUTAPI void APIENTRY glutFullScreen(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutFullScreen();

        // GLUTAPI void APIENTRY glutSetCursor(int cursor);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSetCursor(int cursor);

        // GLUTAPI void APIENTRY glutWarpPointer(int x, int y);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWarpPointer(int x, int y);

        //---------------------------------------------------------------------
        // GLUT overlay sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutEstablishOverlay(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutEstablishOverlay();

        // GLUTAPI void APIENTRY glutRemoveOverlay(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutRemoveOverlay();

        // GLUTAPI void APIENTRY glutUseLayer(GLenum layer);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutUseLayer(GLenum layer);

        // GLUTAPI void APIENTRY glutPostOverlayRedisplay(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPostOverlayRedisplay();

        // GLUTAPI void APIENTRY glutPostWindowOverlayRedisplay(int win);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPostWindowOverlayRedisplay(int win);

        // GLUTAPI void APIENTRY glutShowOverlay(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutShowOverlay();

        // GLUTAPI void APIENTRY glutHideOverlay(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutHideOverlay();

        //---------------------------------------------------------------------
        // GLUT menu sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI int APIENTRY glutCreateMenu( void (* callback)( int menu ) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutCreateMenuProc(int menu);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutCreateMenu(TCALLBACKglutCreateMenuProc glutCreateMenuProc);

        // GLUTAPI void APIENTRY glutDestroyMenu(int menu);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutDestroyMenu(int menu);

        // GLUTAPI int APIENTRY glutGetMenu(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutGetMenu();

        // GLUTAPI void APIENTRY glutSetMenu(int menu);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSetMenu(int menu);

        // GLUTAPI void APIENTRY glutAddMenuEntry(const char *label, int value);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutAddMenuEntry(string label, int value);

        // GLUTAPI void APIENTRY glutAddSubMenu(const char *label, int submenu);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutAddSubMenu(string level, int submenu);

        // GLUTAPI void APIENTRY glutChangeToMenuEntry(int item, const char *label, int value);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutChangeToMenuEntry(int item, string label, int value);

        // GLUTAPI void APIENTRY glutChangeToSubMenu(int item, const char *label, int submenu);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutChangeToSubMenu(int item, string label, int submenu);

        // GLUTAPI void APIENTRY glutRemoveMenuItem(int item);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutRemoveMenuItem(int item);

        // GLUTAPI void APIENTRY glutAttachMenu(int button);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutAttachMenu(int button);

        // GLUTAPI void APIENTRY glutDetachMenu(int button);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutDetachMenu(int button);

        //---------------------------------------------------------------------
        // GLUT window callback sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutDisplayFunc(void (GLUTCALLBACK *func)(void));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutDisplayProc();
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutDisplayFunc(TCALLBACKglutDisplayProc glutDisplayProc);

        // GLUTAPI void APIENTRY glutReshapeFunc(void (GLUTCALLBACK *func)(int width, int height));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutReshapeProc(int width, int height);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutReshapeFunc(TCALLBACKglutReshapeProc glutReshapeProc);

        // GLUTAPI void APIENTRY glutKeyboardFunc(void (GLUTCALLBACK *func)(unsigned char key, int x, int y));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutKeyboardProc(byte key, int x, int y);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutKeyboardFunc(TCALLBACKglutKeyboardProc glutKeyboardProc);

        // GLUTAPI void APIENTRY glutMouseFunc(void (GLUTCALLBACK *func)(int button, int state, int x, int y));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutMouseProc(int button, int state, int x, int y);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutMouseFunc(TCALLBACKglutMouseProc glutMouseProc);

        // GLUTAPI void APIENTRY glutMotionFunc(void (GLUTCALLBACK *func)(int x, int y));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutMotionProc(int x, int y);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutMotionFunc(TCALLBACKglutMotionProc glutMotionProc);

        // GLUTAPI void APIENTRY glutPassiveMotionFunc(void (GLUTCALLBACK *func)(int x, int y));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutPassiveMotionProc(int x, int y);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPassiveMotionFunc(TCALLBACKglutPassiveMotionProc glutPassiveMotionProc);

        // GLUTAPI void APIENTRY glutEntryFunc(void (GLUTCALLBACK *func)(int state));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutEntryProc(int state);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutEntryFunc(TCALLBACKglutEntryProc glutEntryProc);

        // GLUTAPI void APIENTRY glutVisibilityFunc(void (GLUTCALLBACK *func)(int state));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutVisibilityProc(int state);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutVisibilityFunc(TCALLBACKglutVisibilityProc glutVisibilityProc);

        // GLUTAPI void APIENTRY glutIdleFunc(void (GLUTCALLBACK *func)(void));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutIdleProc();
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutIdleFunc(TCALLBACKglutIdleProc glutIdleProc);

        // GLUTAPI void APIENTRY glutTimerFunc(unsigned int millis, void (GLUTCALLBACK *func)(int value), int value);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutTimerProc(int value);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutTimerFunc(uint millis, TCALLBACKglutTimerProc glutTimerProc, int value);

        // GLUTAPI void APIENTRY glutMenuStateFunc(void (GLUTCALLBACK *func)(int state));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutMenuStateProc(int state);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutMenuStateFunc(TCALLBACKglutMenuStateProc glutMenuStateProc);

        // GLUTAPI void APIENTRY glutSpecialFunc(void (GLUTCALLBACK *func)(int key, int x, int y));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutSpecialProc(int key, int x, int y);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSpecialFunc(TCALLBACKglutSpecialProc glutSpecialProc);

        // GLUTAPI void APIENTRY glutSpaceballMotionFunc(void (GLUTCALLBACK *func)(int x, int y, int z));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutSpaceballMotionProc(int x, int y, int z);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSpaceballMotionFunc(TCALLBACKglutSpaceballMotionProc glutSpaceballMotionProc);

        // GLUTAPI void APIENTRY glutSpaceballRotateFunc(void (GLUTCALLBACK *func)(int x, int y, int z));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutSpaceballRotateProc(int x, int y, int z);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSpaceballRotateFunc(TCALLBACKglutSpaceballRotateProc glutSpaceballRotateProc);

        // GLUTAPI void APIENTRY glutSpaceballButtonFunc(void (GLUTCALLBACK *func)(int button, int state));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutSpaceballButtonProc(int button, int state);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSpaceballButtonFunc(TCALLBACKglutSpaceballButtonProc glutSpaceballButtonProc);

        // GLUTAPI void APIENTRY glutButtonBoxFunc(void (GLUTCALLBACK *func)(int button, int state));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutButtonBoxProc(int button, int state);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutButtonBoxFunc(TCALLBACKglutButtonBoxProc glutButtonBoxProc);

        // GLUTAPI void APIENTRY glutDialsFunc(void (GLUTCALLBACK *func)(int dial, int value));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutDialsProc(int dial, int value);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutDialsFunc(TCALLBACKglutDialsProc glutDialsProc);

        // GLUTAPI void APIENTRY glutTabletMotionFunc(void (GLUTCALLBACK *func)(int x, int y));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutTabletMotionProc(int x, int y);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutTabletMotionFunc(TCALLBACKglutTabletMotionProc glutTabletMotionProc);

        // GLUTAPI void APIENTRY glutTabletButtonFunc(void (GLUTCALLBACK *func)(int button, int state, int x, int y));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutTabletButtonProc(int button, int state, int x, int y);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutTabletButtonFunc(TCALLBACKglutTabletButtonProc glutTabletButtonProc);

        // GLUTAPI void APIENTRY glutMenuStatusFunc(void (GLUTCALLBACK *func)(int status, int x, int y));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutMenuStatusProc(int status, int x, int y);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutMenuStatusFunc(TCALLBACKglutMenuStatusProc glutMenuStatusProc);

        // GLUTAPI void APIENTRY glutOverlayDisplayFunc(void (GLUTCALLBACK *func)(void));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutOverlayDisplayProc();
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutOverlayDisplayFunc(TCALLBACKglutOverlayDisplayProc glutOverlayDisplayProc);

        // GLUTAPI void APIENTRY glutWindowStatusFunc(void (*func)(int state));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutWindowStatusProc(int state);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWindowStatusFunc(TCALLBACKglutWindowStatusProc glutWindowStatusProc);

        // GLUTAPI void APIENTRY glutKeyboardUpFunc(void (*func)(unsigned char key, int x, int y));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutKeyboardUpProc(byte key, int x, int y);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutKeyboardUpFunc(TCALLBACKglutKeyboardUpProc glutKeyboardUpProc);

        // GLUTAPI void APIENTRY glutSpecialUpFunc(void (*func)(int key, int x, int y));
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutSpecialUpProc(int key, int x, int y);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSpecialUpFunc(TCALLBACKglutSpecialUpProc glutSpecialUpProc);

        // GLUTAPI void APIENTRY glutJoystickFunc(void (*func)(unsigned int buttonMask, int x, int y, int z), int pollInterval);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutJoystickProc(uint buttonMask, int x, int y, int z);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutJoystickFunc(TCALLBACKglutJoystickProc glutJoystickProc, int pollInterval);

        //---------------------------------------------------------------------
        // GLUT color index sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutSetColor(int ndx, GLfloat red, GLfloat green, GLfloat blue);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSetColor(int ndx, GLfloat red, GLfloat green, GLfloat blue);

        // GLUTAPI GLfloat APIENTRY glutGetColor(int ndx, int component);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern GLfloat glutGetColor(int ndx, int component);

        // GLUTAPI void APIENTRY glutCopyColormap(int win);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutCopyColormap(int win);

        //---------------------------------------------------------------------
        // GLUT state retrieval sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI int APIENTRY glutGet(GLenum type);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutGet(GLenum type);

        // GLUTAPI int APIENTRY glutDeviceGet(GLenum type);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutDeviceGet(GLenum type);

        //---------------------------------------------------------------------
        // GLUT extension support sub-API
        //---------------------------------------------------------------------
        // GLUTAPI int APIENTRY glutExtensionSupported(const char *name);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int glutExtensionSupported(string name);

        // GLUTAPI int APIENTRY glutGetModifiers(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutGetModifiers();

        // GLUTAPI int APIENTRY glutLayerGet(GLenum type);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutLayerGet(GLenum type);

        //---------------------------------------------------------------------
        // GLUT font sub-API 
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutBitmapCharacter(void *font, int character);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutBitmapCharacter(uint font, int character);

        // GLUTAPI int APIENTRY glutBitmapWidth(void *font, int character);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutBitmapWidth(uint font, int character);

        // GLUTAPI void APIENTRY glutStrokeCharacter(void *font, int character);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutStrokeCharacter(uint font, int character);

        // GLUTAPI int APIENTRY glutStrokeWidth(void *font, int character);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutStrokeWidth(uint font, int character);

        // GLUTAPI int APIENTRY glutBitmapLength(void *font, const unsigned char *string);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int glutBitmapLength(uint font, string str);

        // GLUTAPI int APIENTRY glutStrokeLength(void *font, const unsigned char *string);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int glutStrokeLength(uint font, string str);

        //---------------------------------------------------------------------
        // GLUT pre-built models sub-API
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutWireSphere(GLdouble radius, GLint slices, GLint stacks);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireSphere(GLdouble radius, GLint slices, GLint stacks);

        // GLUTAPI void APIENTRY glutSolidSphere(GLdouble radius, GLint slices, GLint stacks);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidSphere(GLdouble radius, GLint slices, GLint stacks);

        // GLUTAPI void APIENTRY glutWireCone(GLdouble base, GLdouble height, GLint slices, GLint stacks);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireCone(GLdouble modelbase, GLdouble height, GLint slices, GLint stacks);

        // GLUTAPI void APIENTRY glutSolidCone(GLdouble base, GLdouble height, GLint slices, GLint stacks);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidCone(GLdouble modelbase, GLdouble height, GLint slices, GLint stacks);

        // GLUTAPI void APIENTRY glutWireCube(GLdouble size);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireCube(GLdouble size);

        // GLUTAPI void APIENTRY glutSolidCube(GLdouble size);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidCube(GLdouble size);

        // GLUTAPI void APIENTRY glutWireTorus(GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireTorus(GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings);

        // GLUTAPI void APIENTRY glutSolidTorus(GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidTorus(GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings);

        // GLUTAPI void APIENTRY glutWireDodecahedron(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireDodecahedron();

        // GLUTAPI void APIENTRY glutSolidDodecahedron(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidDodecahedron();

        // GLUTAPI void APIENTRY glutWireTeapot(GLdouble size);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireTeapot(GLdouble size);

        // GLUTAPI void APIENTRY glutSolidTeapot(GLdouble size);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidTeapot(GLdouble size);

        // GLUTAPI void APIENTRY glutWireOctahedron(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireOctahedron();

        // GLUTAPI void APIENTRY glutSolidOctahedron(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidOctahedron();

        // GLUTAPI void APIENTRY glutWireTetrahedron(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireTetrahedron();

        // GLUTAPI void APIENTRY glutSolidTetrahedron(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidTetrahedron();

        // GLUTAPI void APIENTRY glutWireIcosahedron(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireIcosahedron();

        // GLUTAPI void APIENTRY glutSolidIcosahedron(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidIcosahedron();

        //---------------------------------------------------------------------
        // GLUT video resize sub-API
        //---------------------------------------------------------------------
        // GLUTAPI int APIENTRY glutVideoResizeGet(GLenum param);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutVideoResizeGet(GLenum param);

        // GLUTAPI void APIENTRY glutSetupVideoResizing(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSetupVideoResizing();

        // GLUTAPI void APIENTRY glutStopVideoResizing(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutStopVideoResizing();

        // GLUTAPI void APIENTRY glutVideoResize(int x, int y, int width, int height);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutVideoResize(int x, int y, int width, int height);

        // GLUTAPI void APIENTRY glutVideoPan(int x, int y, int width, int height);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutVideoPan(int x, int y, int width, int height);

        //---------------------------------------------------------------------
        // GLUT device control sub-API
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutIgnoreKeyRepeat(int ignore);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutIgnoreKeyRepeat(int ignore);

        // GLUTAPI void APIENTRY glutSetKeyRepeat(int repeatMode);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSetKeyRepeat(int repeatMode);

        // GLUTAPI void APIENTRY glutForceJoystickFunc(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutForceJoystickFunc();

        //---------------------------------------------------------------------
        // GLUT game mode sub-API
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutGameModeString(const char *string);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutGameModeString(string str);

        // GLUTAPI int APIENTRY glutEnterGameMode(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutEnterGameMode();

        // GLUTAPI void APIENTRY glutLeaveGameMode(void);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutLeaveGameMode();

        // GLUTAPI int APIENTRY glutGameModeGet(GLenum mode);
        [DllImport("glut32.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutGameModeGet(GLenum mode);
    }
}
