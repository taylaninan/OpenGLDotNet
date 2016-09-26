// ----------------------------------------------------------------------------
// FILE		: fg.functions.cs
// VERSION	: 1.1.0
// COMMENT	: FREEGLUT library low level functions.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2016
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
    public static partial class FG
    {
        ///////////////////////////////////////////////////////////////////////
        // FREEGLUT v2.8.1 FUNCTIONS (STANDARD)
        ///////////////////////////////////////////////////////////////////////
        //---------------------------------------------------------------------
        // Initialization functions, see fglut_init.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutInit( int* pargc, char** argv );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern void glutInit(int* pargc, byte** argv);

        // FGAPI void    FGAPIENTRY glutInitWindowPosition( int x, int y );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutInitWindowPosition(int x, int y);

        // FGAPI void    FGAPIENTRY glutInitWindowSize( int width, int height );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutInitWindowSize(int width, int height);

        // FGAPI void    FGAPIENTRY glutInitDisplayMode( unsigned int displayMode );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutInitDisplayMode(uint displayMode);

        // FGAPI void    FGAPIENTRY glutInitDisplayString( const char* displayMode );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutInitDisplayString(string displayMode);

        //---------------------------------------------------------------------
        // Process loop function, see freeglut_main.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutMainLoop( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutMainLoop();

        //---------------------------------------------------------------------
        // Window management functions, see freeglut_window.c
        //---------------------------------------------------------------------
        // FGAPI int     FGAPIENTRY glutCreateWindow( const char* title );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int glutCreateWindow(string title);

        // FGAPI int     FGAPIENTRY glutCreateSubWindow( int window, int x, int y, int width, int height );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutCreateSubWindow(int window, int x, int y, int width, int height);

        // FGAPI void    FGAPIENTRY glutDestroyWindow( int window );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutDestroyWindow(int window);

        // FGAPI void    FGAPIENTRY glutSetWindow( int window );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSetWindow(int window);

        // FGAPI int     FGAPIENTRY glutGetWindow( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutGetWindow();

        // FGAPI void    FGAPIENTRY glutSetWindowTitle( const char* title );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutSetWindowTitle(string title);

        // FGAPI void    FGAPIENTRY glutSetIconTitle( const char* title );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutSetIconTitle(string title);

        // FGAPI void    FGAPIENTRY glutReshapeWindow( int width, int height );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutReshapeWindow(int width, int height);

        // FGAPI void    FGAPIENTRY glutPositionWindow( int x, int y );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPositionWindow(int x, int y);

        // FGAPI void    FGAPIENTRY glutShowWindow( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutShowWindow();

        // FGAPI void    FGAPIENTRY glutHideWindow( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutHideWindow();

        // FGAPI void    FGAPIENTRY glutIconifyWindow( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutIconifyWindow();

        // FGAPI void    FGAPIENTRY glutPushWindow( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPushWindow();

        // FGAPI void    FGAPIENTRY glutPopWindow( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPopWindow();

        // FGAPI void    FGAPIENTRY glutFullScreen( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutFullScreen();

        //---------------------------------------------------------------------
        // Display-connected functions, see freeglut_display.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutPostWindowRedisplay( int window );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPostWindowRedisplay(int window);

        // FGAPI void    FGAPIENTRY glutPostRedisplay( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPostRedisplay();

        // FGAPI void    FGAPIENTRY glutSwapBuffers( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSwapBuffers();

        //---------------------------------------------------------------------
        // Mouse cursor functions, see freeglut_cursor.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutWarpPointer( int x, int y );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWarpPointer(int x, int y);

        // FGAPI void    FGAPIENTRY glutSetCursor( int cursor );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSetCursor(int cursor);

        //---------------------------------------------------------------------
        // Overlay stuff, see freeglut_overlay.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutEstablishOverlay( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutEstablishOverlay();

        // FGAPI void    FGAPIENTRY glutRemoveOverlay( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutRemoveOverlay();

        // FGAPI void    FGAPIENTRY glutUseLayer( GLenum layer );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutUseLayer(GLenum layer);

        // FGAPI void    FGAPIENTRY glutPostOverlayRedisplay( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPostOverlayRedisplay();

        // FGAPI void    FGAPIENTRY glutPostWindowOverlayRedisplay( int window );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPostWindowOverlayRedisplay(int window);

        // FGAPI void    FGAPIENTRY glutShowOverlay( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutShowOverlay();

        // FGAPI void    FGAPIENTRY glutHideOverlay( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutHideOverlay();

        //---------------------------------------------------------------------
        // Menu stuff, see freeglut_menu.c
        //---------------------------------------------------------------------
        // FGAPI int     FGAPIENTRY glutCreateMenu( void (* callback)( int menu ) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutCreateMenuProc(int menu);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutCreateMenu(TCALLBACKglutCreateMenuProc glutCreateMenuProc);

        // FGAPI void    FGAPIENTRY glutDestroyMenu( int menu );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutDestroyMenu(int menu);

        // FGAPI int     FGAPIENTRY glutGetMenu( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutGetMenu();

        // FGAPI void    FGAPIENTRY glutSetMenu( int menu );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSetMenu(int menu);

        // FGAPI void    FGAPIENTRY glutAddMenuEntry( const char* label, int value );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutAddMenuEntry(string label, int value);

        // FGAPI void    FGAPIENTRY glutAddSubMenu( const char* label, int subMenu );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutAddSubMenu(string label, int subMenu);

        // FGAPI void    FGAPIENTRY glutChangeToMenuEntry( int item, const char* label, int value );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutChangeToMenuEntry(int item, string label, int value);

        // FGAPI void    FGAPIENTRY glutChangeToSubMenu( int item, const char* label, int value );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutChangeToSubMenu(int item, string label, int value);

        // FGAPI void    FGAPIENTRY glutRemoveMenuItem( int item );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutRemoveMenuItem(int item);

        // FGAPI void    FGAPIENTRY glutAttachMenu( int button );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutAttachMenu(int button);

        // FGAPI void    FGAPIENTRY glutDetachMenu( int button );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutDetachMenu(int button);

        //---------------------------------------------------------------------
        // Global callback functions, see freeglut_callbacks.c */
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutTimerFunc( unsigned int time, void (* callback)( int value), int value );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutTimerProc(int value);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutTimerFunc(uint time, TCALLBACKglutTimerProc glutTimerProc, int value);

        // FGAPI void    FGAPIENTRY glutIdleFunc( void (* callback)( void ) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutIdleProc();
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutIdleFunc(TCALLBACKglutIdleProc glutIdleProc);

        //---------------------------------------------------------------------
        // Window-specific callback functions, see freeglut_callbacks.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutKeyboardFunc( void (* callback)( unsigned char key, int x, int y) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutKeyboardProc(byte key, int x, int y);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutKeyboardFunc(TCALLBACKglutKeyboardProc glutKeyboardProc);
        
        // FGAPI void    FGAPIENTRY glutSpecialFunc( void (* callback)( int key, int x, int y) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutSpecialProc(int key, int x, int y);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSpecialFunc(TCALLBACKglutSpecialProc glutSpecialProc);

        // FGAPI void    FGAPIENTRY glutReshapeFunc( void (* callback)( int width, int height) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutReshapeProc(int width, int height);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutReshapeFunc(TCALLBACKglutReshapeProc glutReshapeProc);

        // FGAPI void    FGAPIENTRY glutVisibilityFunc( void (* callback)( int state) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutVisibilityProc(int state);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutVisibilityFunc(TCALLBACKglutVisibilityProc glutVisibilityProc);

        // FGAPI void    FGAPIENTRY glutDisplayFunc( void (* callback)( void ) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutDisplayProc();
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutDisplayFunc(TCALLBACKglutDisplayProc glutDisplayProc);
        
        // FGAPI void    FGAPIENTRY glutMouseFunc( void (* callback)( int button, int state, int x, int y) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutMouseProc(int button, int state, int x, int y);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutMouseFunc(TCALLBACKglutMouseProc glutMouseProc);

        // FGAPI void    FGAPIENTRY glutMotionFunc( void (* callback)( int x, int y) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutMotionProc(int x, int y);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutMotionFunc(TCALLBACKglutMotionProc glutMotionProc);

        // FGAPI void    FGAPIENTRY glutPassiveMotionFunc( void (* callback)( int x, int y) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutPassiveMotionProc(int x, int y);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutPassiveMotionFunc(TCALLBACKglutPassiveMotionProc glutPassiveMotionProc);

        // FGAPI void    FGAPIENTRY glutEntryFunc( void (* callback)( int state ) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutEntryProc(int state);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutEntryFunc(TCALLBACKglutEntryProc glutEntryProc);

        // FGAPI void    FGAPIENTRY glutKeyboardUpFunc( void (* callback)( unsigned char key, int x, int y) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutKeyboardUpProc(byte key, int x, int y);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutKeyboardUpFunc(TCALLBACKglutKeyboardUpProc glutKeyboardUpProc);

        // FGAPI void    FGAPIENTRY glutSpecialUpFunc( void (* callback)( int key, int x, int y) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutSpecialUpProc(int key, int x, int y);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSpecialUpFunc(TCALLBACKglutSpecialUpProc glutSpecialUpProc);

        // FGAPI void    FGAPIENTRY glutJoystickFunc( void (* callback)( unsigned int buttonMask, int x, int y, int z), int pollInterval );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutJoystickProc(uint buttonMask, int x, int y, int z);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutJoystickFunc(TCALLBACKglutJoystickProc glutJoystickProc, int pollInterval);

        // FGAPI void    FGAPIENTRY glutMenuStateFunc( void (* callback)( int state) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutMenuStateProc(int state);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutMenuStateFunc(TCALLBACKglutMenuStateProc glutMenuStateProc);

        // FGAPI void    FGAPIENTRY glutMenuStatusFunc( void (* callback)( int status, int x, int y) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutMenuStatusProc(int status, int x, int y);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutMenuStatusFunc(TCALLBACKglutMenuStatusProc glutMenuStatusProc);

        // FGAPI void    FGAPIENTRY glutOverlayDisplayFunc( void (* callback)( void ) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutOverlayDisplayProc();
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutOverlayDisplayFunc(TCALLBACKglutOverlayDisplayProc glutOverlayDisplayProc);

        // FGAPI void    FGAPIENTRY glutWindowStatusFunc( void (* callback)( int state) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutWindowStatusProc(int state);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWindowStatusFunc(TCALLBACKglutWindowStatusProc glutWindowStatusProc);

        // FGAPI void    FGAPIENTRY glutSpaceballMotionFunc( void (* callback)( int x, int y, int z) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutSpaceballMotionProc(int x, int y, int z);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSpaceballMotionFunc(TCALLBACKglutSpaceballMotionProc glutSpaceballMotionProc);

        // FGAPI void    FGAPIENTRY glutSpaceballRotateFunc( void (* callback)( int x, int y, int z) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutSpaceballRotateProc(int x, int y, int z);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSpaceballRotateFunc(TCALLBACKglutSpaceballRotateProc glutSpaceballRotateProc);

        // FGAPI void    FGAPIENTRY glutSpaceballButtonFunc( void (* callback)( int button, int state) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutSpaceballButtonProc(int button, int state);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSpaceballButtonFunc(TCALLBACKglutSpaceballButtonProc glutSpaceballButtonProc);

        // FGAPI void    FGAPIENTRY glutButtonBoxFunc( void (* callback)( int button, int state) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutButtonBoxProc(int button, int state);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutButtonBoxFunc(TCALLBACKglutButtonBoxProc glutButtonBoxProc);

        // FGAPI void    FGAPIENTRY glutDialsFunc( void (* callback)( int dial, int value) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutDialsProc(int dial, int value);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutDialsFunc(TCALLBACKglutDialsProc glutDialsProc);

        // FGAPI void    FGAPIENTRY glutTabletMotionFunc( void (* callback)( int x, int y) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutTabletMotionProc(int x, int y);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutTabletMotionFunc(TCALLBACKglutTabletMotionProc glutTabletMotionProc);

        // FGAPI void    FGAPIENTRY glutTabletButtonFunc( void (* callback)( int button, int state, int x, int y) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutTabletButtonProc(int button, int state, int x, int y);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutTabletButtonFunc(TCALLBACKglutTabletButtonProc glutTabletButtonProc);

        //---------------------------------------------------------------------
        // State setting and retrieval functions, see freeglut_state.c
        //---------------------------------------------------------------------
        // FGAPI int     FGAPIENTRY glutGet( GLenum query );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutGet(GLenum query);

        // FGAPI int     FGAPIENTRY glutDeviceGet( GLenum query );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutDeviceGet(GLenum query);

        // FGAPI int     FGAPIENTRY glutGetModifiers( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutGetModifiers();

        // FGAPI int     FGAPIENTRY glutLayerGet( GLenum query );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutLayerGet(GLenum query);

        //---------------------------------------------------------------------
        // Font stuff, see freeglut_font.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutBitmapCharacter( void* font, int character );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutBitmapCharacter(uint font, int character);

        // FGAPI int     FGAPIENTRY glutBitmapWidth( void* font, int character );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutBitmapWidth(uint font, int character);

        // FGAPI void    FGAPIENTRY glutStrokeCharacter( void* font, int character );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutStrokeCharacter(uint font, int character);

        // FGAPI int     FGAPIENTRY glutStrokeWidth( void* font, int character );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutStrokeWidth(uint font, int character);

        // FGAPI int     FGAPIENTRY glutBitmapLength( void* font, const unsigned char* string );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int glutBitmapLength(uint font, string str);
        
        // FGAPI int     FGAPIENTRY glutStrokeLength( void* font, const unsigned char* string );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int glutStrokeLength(uint font, string str);

        //---------------------------------------------------------------------
        // Geometry functions, see freeglut_geometry.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutWireCube( GLdouble size );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireCube(GLdouble size);

        // FGAPI void    FGAPIENTRY glutSolidCube( GLdouble size );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidCube(GLdouble size);

        // FGAPI void    FGAPIENTRY glutWireSphere( GLdouble radius, GLint slices, GLint stacks );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireSphere(GLdouble radius, GLint slices, GLint stacks);

        // FGAPI void    FGAPIENTRY glutSolidSphere( GLdouble radius, GLint slices, GLint stacks );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidSphere(GLdouble radius, GLint slices, GLint stacks);

        // FGAPI void    FGAPIENTRY glutWireCone( GLdouble base, GLdouble height, GLint slices, GLint stacks );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireCone(GLdouble modelbase, GLdouble height, GLint slices, GLint stacks);
 
        // FGAPI void    FGAPIENTRY glutSolidCone( GLdouble base, GLdouble height, GLint slices, GLint stacks );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidCone(GLdouble modelbase, GLdouble height, GLint slices, GLint stacks);

        // FGAPI void    FGAPIENTRY glutWireTorus( GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireTorus(GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings);
        
        // FGAPI void    FGAPIENTRY glutSolidTorus( GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidTorus(GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings);

        // FGAPI void    FGAPIENTRY glutWireDodecahedron( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireDodecahedron();

        // FGAPI void    FGAPIENTRY glutSolidDodecahedron( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidDodecahedron();

        // FGAPI void    FGAPIENTRY glutWireOctahedron( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireOctahedron();

        // FGAPI void    FGAPIENTRY glutSolidOctahedron( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidOctahedron();

        // FGAPI void    FGAPIENTRY glutWireTetrahedron( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireTetrahedron();
        
        // FGAPI void    FGAPIENTRY glutSolidTetrahedron( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidTetrahedron();

        // FGAPI void    FGAPIENTRY glutWireIcosahedron( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireIcosahedron();

        // FGAPI void    FGAPIENTRY glutSolidIcosahedron( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidIcosahedron();

        //---------------------------------------------------------------------
        // Teapot rendering functions, found in freeglut_teapot.c
        // NB: front facing polygons have clockwise winding, not counter clockwise
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutWireTeapot( GLdouble size );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireTeapot(GLdouble size);

        // FGAPI void    FGAPIENTRY glutSolidTeapot( GLdouble size );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidTeapot(GLdouble size);

        //---------------------------------------------------------------------
        // Game mode functions, see freeglut_gamemode.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutGameModeString( const char* string );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutGameModeString(string str);

        // FGAPI int     FGAPIENTRY glutEnterGameMode( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutEnterGameMode();

        // FGAPI void    FGAPIENTRY glutLeaveGameMode( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutLeaveGameMode();

        // FGAPI int     FGAPIENTRY glutGameModeGet( GLenum query );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutGameModeGet(GLenum query);

        //---------------------------------------------------------------------
        // Video resize functions, see freeglut_videoresize.c
        //---------------------------------------------------------------------
        // FGAPI int     FGAPIENTRY glutVideoResizeGet( GLenum query );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutVideoResizeGet(GLenum query);

        // FGAPI void    FGAPIENTRY glutSetupVideoResizing( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSetupVideoResizing();

        // FGAPI void    FGAPIENTRY glutStopVideoResizing( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutStopVideoResizing();

        // FGAPI void    FGAPIENTRY glutVideoResize( int x, int y, int width, int height );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutVideoResize(int x, int y, int width, int height);

        // FGAPI void    FGAPIENTRY glutVideoPan( int x, int y, int width, int height );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutVideoPan(int x, int y, int width, int height);

        //---------------------------------------------------------------------
        // Colormap functions, see freeglut_misc.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutSetColor( int color, GLfloat red, GLfloat green, GLfloat blue );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSetColor(int color, GLfloat red, GLfloat green, GLfloat blue);

        // FGAPI GLfloat FGAPIENTRY glutGetColor( int color, int component );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern GLfloat glutGetColor(int color, int component);

        // FGAPI void    FGAPIENTRY glutCopyColormap( int window );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutCopyColormap(int window);

        //---------------------------------------------------------------------
        // Misc keyboard and joystick functions, see freeglut_misc.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutIgnoreKeyRepeat( int ignore );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutIgnoreKeyRepeat(int ignore);

        // FGAPI void    FGAPIENTRY glutSetKeyRepeat( int repeatMode );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSetKeyRepeat(int repeatMode);

        // FGAPI void    FGAPIENTRY glutForceJoystickFunc( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutForceJoystickFunc();

        //---------------------------------------------------------------------
        // Misc functions, see freeglut_misc.c
        //---------------------------------------------------------------------
        // FGAPI int     FGAPIENTRY glutExtensionSupported( const char* extension );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern int glutExtensionSupported(string extension);

        // FGAPI void    FGAPIENTRY glutReportErrors( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutReportErrors();

        ///////////////////////////////////////////////////////////////////////
        // FREEGLUT v2.8.1 FUNCTIONS (EXTENDED)
        ///////////////////////////////////////////////////////////////////////
        //---------------------------------------------------------------------
        // Process loop function, see freeglut_main.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutMainLoopEvent( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutMainLoopEvent();

        // FGAPI void    FGAPIENTRY glutLeaveMainLoop( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutLeaveMainLoop();

        // FGAPI void    FGAPIENTRY glutExit         ( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutExit();

        //---------------------------------------------------------------------
        // Window management functions, see freeglut_window.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutFullScreenToggle( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutFullScreenToggle();

        // FGAPI void    FGAPIENTRY glutLeaveFullScreen( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutLeaveFullScreen();

        //---------------------------------------------------------------------
        // Window-specific callback functions, see freeglut_callbacks.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutMouseWheelFunc( void (* callback)( int wheel, int direction, int x, int y ) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutMouseWheelProc(int wheel, int direction, int x, int y);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutMouseWheelFunc(TCALLBACKglutMouseWheelProc glutMouseWheelProc);

        // FGAPI void    FGAPIENTRY glutCloseFunc( void (* callback)( void ) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutCloseProc();
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutCloseFunc(TCALLBACKglutCloseProc glutCloseProc);

        // FGAPI void    FGAPIENTRY glutWMCloseFunc( void (* callback)( void ) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutWMCloseProc();
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWMCloseFunc(TCALLBACKglutWMCloseProc glutWMCloseProc);

        // FGAPI void    FGAPIENTRY glutMenuDestroyFunc( void (* callback)( void ) );
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TCALLBACKglutMenuDestroyProc();
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutMenuDestroyFunc(TCALLBACKglutMenuDestroyProc glutMenuDestroyProc);

        //---------------------------------------------------------------------
        // State setting and retrieval functions, see freeglut_state.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutSetOption ( GLenum option_flag, int value );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSetOption(GLenum option_flag, int value);
        
        // FGAPI int *   FGAPIENTRY glutGetModeValues(GLenum mode, int * size);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern int* glutGetModeValues(GLenum mode, int* size);
        
        /* A.Donev: User-data manipulation */
        // FGAPI void*   FGAPIENTRY glutGetWindowData( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern void* glutGetWindowData();
        
        // FGAPI void    FGAPIENTRY glutSetWindowData(void* data);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern void glutSetWindowData(void* data);
        
        // FGAPI void*   FGAPIENTRY glutGetMenuData( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern void* glutGetMenuData();

        // FGAPI void    FGAPIENTRY glutSetMenuData(void* data);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern void glutSetMenuData(void* data);

        //---------------------------------------------------------------------
        // Font stuff, see freeglut_font.c
        //---------------------------------------------------------------------
        // FGAPI int     FGAPIENTRY glutBitmapHeight( void* font );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int glutBitmapHeight(uint font);

        // FGAPI GLfloat FGAPIENTRY glutStrokeHeight( void* font );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern GLfloat glutStrokeHeight(uint font);

        // FGAPI void    FGAPIENTRY glutBitmapString( void* font, const unsigned char *string );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutBitmapString(uint font, string str);

        // FGAPI void    FGAPIENTRY glutStrokeString( void* font, const unsigned char *string );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern void glutStrokeString(uint font, string str);

        //---------------------------------------------------------------------
        // Geometry functions, see freeglut_geometry.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutWireRhombicDodecahedron( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireRhombicDodecahedron();

        // FGAPI void    FGAPIENTRY glutSolidRhombicDodecahedron( void );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidRhombicDodecahedron();

        // FGAPI void    FGAPIENTRY glutWireSierpinskiSponge ( int num_levels, GLdouble offset[3], GLdouble scale );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireSierpinskiSponge(int num_levels, GLdouble[] offset, GLdouble scale);

        // FGAPI void    FGAPIENTRY glutSolidSierpinskiSponge ( int num_levels, GLdouble offset[3], GLdouble scale );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidSierpinskiSponge(int num_levels, GLdouble[] offset, GLdouble scale);

        // FGAPI void    FGAPIENTRY glutWireCylinder( GLdouble radius, GLdouble height, GLint slices, GLint stacks);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutWireCylinder(GLdouble radius, GLdouble height, GLint slices, GLint stacks);

        // FGAPI void    FGAPIENTRY glutSolidCylinder( GLdouble radius, GLdouble height, GLint slices, GLint stacks);
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutSolidCylinder(GLdouble radius, GLdouble height, GLint slices, GLint stacks);

        //---------------------------------------------------------------------
        // Extension functions, see freeglut_ext.c
        //---------------------------------------------------------------------
        // typedef void (*GLUTproc)();
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TGLUTproc();

        // FGAPI GLUTproc FGAPIENTRY glutGetProcAddress( const char *procName );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private static extern TGLUTproc glutGetProcAddress(string procName);

        //---------------------------------------------------------------------
        // Initialization functions, see freeglut_init.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutInitContextVersion( int majorVersion, int minorVersion );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutInitContextVersion(int majorVersion, int minorVersion);

        // FGAPI void    FGAPIENTRY glutInitContextFlags( int flags );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutInitContextFlags(int flags);

        // FGAPI void    FGAPIENTRY glutInitContextProfile( int profile );
        [DllImport("freeglut.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern void glutInitContextProfile(int profile);
    }
}
