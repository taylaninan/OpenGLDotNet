// ----------------------------------------------------------------------------
// FILE		: fg.wrappers.cs
// VERSION	: 1.1.2
// COMMENT	: FREEGLUT library wrappers for low level functions.
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
    public static partial class FG
    {
        ///////////////////////////////////////////////////////////////////////
        // MARSHALING FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        private unsafe static IntPtr BuildStringIntPtrTable(string[] strings)
        {
            IntPtr StrPtrTable = IntPtr.Zero;

            if (strings != null)
            {
                StrPtrTable = Marshal.AllocHGlobal(strings.Length * 4);

                for (int counter = 0; counter < strings.Length; counter++)
                {
                    fixed (char* StrPtr = strings[counter])
                    {
                        IntPtr StrIntPtr = (IntPtr)StrPtr;
                        Marshal.WriteInt32(StrPtrTable, counter * 4, StrIntPtr.ToInt32());
                    }
                }
            }

            return StrPtrTable;
        }

        ///////////////////////////////////////////////////////////////////////
        // FREEGLUT v2.8.1 WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        //---------------------------------------------------------------------
        // Initialization functions, see fglut_init.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutInit( int* pargc, char** argv );
        public unsafe static void Init(int[] pargc, string[] argv)
        {
            IntPtr StrPtrTable = BuildStringIntPtrTable(argv);

            fixed (int* ptr_pargc = pargc)
            {
                glutInit(ptr_pargc, (byte**)StrPtrTable);
            }

            Marshal.FreeHGlobal(StrPtrTable);
        }

        // FGAPI void    FGAPIENTRY glutInitWindowPosition( int x, int y );
        public static void InitWindowPosition(int x, int y)
        {
            glutInitWindowPosition(x, y);
        }

        // FGAPI void    FGAPIENTRY glutInitWindowSize( int width, int height );
        public static void InitWindowSize(int width, int height)
        {
            glutInitWindowSize(width, height);
        }

        // FGAPI void    FGAPIENTRY glutInitDisplayMode( unsigned int displayMode );
        public static void InitDisplayMode(uint displayMode)
        {
            glutInitDisplayMode(displayMode);
        }

        // FGAPI void    FGAPIENTRY glutInitDisplayString( const char* displayMode );
        public static void InitDisplayString(string displayMode)
        {
            glutInitDisplayString(displayMode);
        }

        //---------------------------------------------------------------------
        // Process loop function, see freeglut_main.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutMainLoop( void );
        public static void MainLoop()
        {
            glutMainLoop();
        }

        //---------------------------------------------------------------------
        // Window management functions, see freeglut_window.c
        //---------------------------------------------------------------------
        // FGAPI int     FGAPIENTRY glutCreateWindow( const char* title );
        public static int CreateWindow(string title)
        {
            return glutCreateWindow(title);
        }

        // FGAPI int     FGAPIENTRY glutCreateSubWindow( int window, int x, int y, int width, int height );
        public static int CreateSubWindow(int window, int x, int y, int width, int height)
        {
            return glutCreateSubWindow(window, x, y, width, height);
        }

        // FGAPI void    FGAPIENTRY glutDestroyWindow( int window );
        public static void DestroyWindow(int window)
        {
            glutDestroyWindow(window);
        }

        // FGAPI void    FGAPIENTRY glutSetWindow( int window );
        public static void SetWindow(int window)
        {
            glutSetWindow(window);
        }

        // FGAPI int     FGAPIENTRY glutGetWindow( void );
        public static int GetWindow()
        {
            return glutGetWindow();
        }

        // FGAPI void    FGAPIENTRY glutSetWindowTitle( const char* title );
        public static void SetWindowTitle(string title)
        {
            glutSetWindowTitle(title);
        }

        // FGAPI void    FGAPIENTRY glutSetIconTitle( const char* title );
        public static void SetIconTitle(string title)
        {
            glutSetIconTitle(title);
        }

        // FGAPI void    FGAPIENTRY glutReshapeWindow( int width, int height );
        public static void ReshapeWindow(int width, int height)
        {
            glutReshapeWindow(width, height);
        }

        // FGAPI void    FGAPIENTRY glutPositionWindow( int x, int y );
        public static void PositionWindow(int x, int y)
        {
            glutPositionWindow(x, y);
        }

        // FGAPI void    FGAPIENTRY glutShowWindow( void );
        public static void ShowWindow()
        {
            glutShowWindow();
        }

        // FGAPI void    FGAPIENTRY glutHideWindow( void );
        public static void HideWindow()
        {
            glutHideWindow();
        }

        // FGAPI void    FGAPIENTRY glutIconifyWindow( void );
        public static void IconifyWindow()
        {
            glutIconifyWindow();
        }

        // FGAPI void    FGAPIENTRY glutPushWindow( void );
        public static void PushWindow()
        {
            glutPushWindow();
        }

        // FGAPI void    FGAPIENTRY glutPopWindow( void );
        public static void PopWindow()
        {
            glutPopWindow();
        }

        // FGAPI void    FGAPIENTRY glutFullScreen( void );
        public static void FullScreen()
        {
            glutFullScreen();
        }

        //---------------------------------------------------------------------
        // Display-connected functions, see freeglut_display.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutPostWindowRedisplay( int window );
        public static void PostWindowRedisplay(int window)
        {
            glutPostWindowRedisplay(window);
        }

        // FGAPI void    FGAPIENTRY glutPostRedisplay( void );
        public static void PostRedisplay()
        {
            glutPostRedisplay();
        }

        // FGAPI void    FGAPIENTRY glutSwapBuffers( void );
        public static void SwapBuffers()
        {
            glutSwapBuffers();
        }

        //---------------------------------------------------------------------
        // Mouse cursor functions, see freeglut_cursor.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutWarpPointer( int x, int y );
        public static void WarpPointer(int x, int y)
        {
            glutWarpPointer(x, y);
        }

        // FGAPI void    FGAPIENTRY glutSetCursor( int cursor );
        public static void SetCursor(int cursor)
        {
            glutSetCursor(cursor);
        }

        //---------------------------------------------------------------------
        // Overlay stuff, see freeglut_overlay.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutEstablishOverlay( void );
        public static void EstablishOverlay()
        {
            glutEstablishOverlay();
        }

        // FGAPI void    FGAPIENTRY glutRemoveOverlay( void );
        public static void RemoveOverlay()
        {
            glutRemoveOverlay();
        }

        // FGAPI void    FGAPIENTRY glutUseLayer( GLenum layer );
        public static void UseLayer(GLenum layer)
        {
            glutUseLayer(layer);
        }

        // FGAPI void    FGAPIENTRY glutPostOverlayRedisplay( void );
        public static void PostOverlayRedisplay()
        {
            glutPostOverlayRedisplay();
        }

        // FGAPI void    FGAPIENTRY glutPostWindowOverlayRedisplay( int window );
        public static void PostWindowOverlayRedisplay(int window)
        {
            glutPostWindowOverlayRedisplay(window);
        }

        // FGAPI void    FGAPIENTRY glutShowOverlay( void );
        public static void ShowOverlay()
        {
            glutShowOverlay();
        }

        // FGAPI void    FGAPIENTRY glutHideOverlay( void );
        public static void HideOverlay()
        {
            glutHideOverlay();
        }

        //---------------------------------------------------------------------
        // Menu stuff, see freeglut_menu.c
        //---------------------------------------------------------------------
        // FGAPI int     FGAPIENTRY glutCreateMenu( void (* callback)( int menu ) );
        public static int CreateMenu(TCALLBACKglutCreateMenuProc glutCreateMenuProc)
        {
            return glutCreateMenu(glutCreateMenuProc);
        }

        // FGAPI void    FGAPIENTRY glutDestroyMenu( int menu );
        public static void DestroyMenu(int menu)
        {
            glutDestroyMenu(menu);
        }

        // FGAPI int     FGAPIENTRY glutGetMenu( void );
        public static int GetMenu()
        {
            return glutGetMenu();
        }

        // FGAPI void    FGAPIENTRY glutSetMenu( int menu );
        public static void SetMenu(int menu)
        {
            glutSetMenu(menu);
        }

        // FGAPI void    FGAPIENTRY glutAddMenuEntry( const char* label, int value );
        public static void AddMenuEntry(string label, int value)
        {
            glutAddMenuEntry(label, value);
        }

        // FGAPI void    FGAPIENTRY glutAddSubMenu( const char* label, int subMenu );
        public static void AddSubMenu(string label, int subMenu)
        {
            glutAddSubMenu(label, subMenu);
        }

        // FGAPI void    FGAPIENTRY glutChangeToMenuEntry( int item, const char* label, int value );
        public static void ChangeToMenuEntry(int item, string label, int value)
        {
            glutChangeToMenuEntry(item, label, value);
        }

        // FGAPI void    FGAPIENTRY glutChangeToSubMenu( int item, const char* label, int value );
        public static void ChangeToSubMenu(int item, string label, int value)
        {
            glutChangeToSubMenu(item, label, value);
        }

        // FGAPI void    FGAPIENTRY glutRemoveMenuItem( int item );
        public static void RemoveMenuItem(int item)
        {
            glutRemoveMenuItem(item);
        }

        // FGAPI void    FGAPIENTRY glutAttachMenu( int button );
        public static void AttachMenu(int button)
        {
            glutAttachMenu(button);
        }

        // FGAPI void    FGAPIENTRY glutDetachMenu( int button );
        public static void DetachMenu(int button)
        {
            glutDetachMenu(button);
        }

        //---------------------------------------------------------------------
        // Global callback functions, see freeglut_callbacks.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutTimerFunc( unsigned int time, void (* callback)( int ), int value );
        public static void TimerFunc(uint time, TCALLBACKglutTimerProc glutTimerProc, int value)
        {
            glutTimerFunc(time, glutTimerProc, value);
        }

        // FGAPI void    FGAPIENTRY glutIdleFunc( void (* callback)( void ) );
        public static void IdleFunc(TCALLBACKglutIdleProc glutIdleProc)
        {
            glutIdleFunc(glutIdleProc);
        }

        //---------------------------------------------------------------------
        // Window-specific callback functions, see freeglut_callbacks.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutKeyboardFunc( void (* callback)( unsigned char key, int x, int y) );
        public static void KeyboardFunc(TCALLBACKglutKeyboardProc glutKeyboardProc)
        {
            glutKeyboardFunc(glutKeyboardProc);
        }

        // FGAPI void    FGAPIENTRY glutSpecialFunc( void (* callback)( int key, int x, int y) );
        public static void SpecialFunc(TCALLBACKglutSpecialProc glutSpecialProc)
        {
            glutSpecialFunc(glutSpecialProc);
        }

        // FGAPI void    FGAPIENTRY glutReshapeFunc( void (* callback)( int width, int height) );
        public static void ReshapeFunc(TCALLBACKglutReshapeProc glutReshapeProc)
        {
            glutReshapeFunc(glutReshapeProc);
        }

        // FGAPI void    FGAPIENTRY glutVisibilityFunc( void (* callback)( int state) );
        public static void VisibilityFunc(TCALLBACKglutVisibilityProc glutVisibilityProc)
        {
            glutVisibilityFunc(glutVisibilityProc);
        }

        // FGAPI void    FGAPIENTRY glutDisplayFunc( void (* callback)( void ) );
        public static void DisplayFunc(TCALLBACKglutDisplayProc glutDisplayProc)
        {
            glutDisplayFunc(glutDisplayProc);
        }

        // FGAPI void    FGAPIENTRY glutMouseFunc( void (* callback)( int button, int state, int x, int y) );
        public static void MouseFunc(TCALLBACKglutMouseProc glutMouseProc)
        {
            glutMouseFunc(glutMouseProc);
        }

        // FGAPI void    FGAPIENTRY glutMotionFunc( void (* callback)( int x, int y) );
        public static void MotionFunc(TCALLBACKglutMotionProc glutMotionProc)
        {
            glutMotionFunc(glutMotionProc);
        }

        // FGAPI void    FGAPIENTRY glutPassiveMotionFunc( void (* callback)( int x, int y) );
        public static void PassiveMotionFunc(TCALLBACKglutPassiveMotionProc glutPassiveMotionProc)
        {
            glutPassiveMotionFunc(glutPassiveMotionProc);
        }
        
        // FGAPI void    FGAPIENTRY glutEntryFunc( void (* callback)( int state ) );
        public static void EntryFunc(TCALLBACKglutEntryProc glutEntryProc)
        {
            glutEntryFunc(glutEntryProc);
        }

        // FGAPI void    FGAPIENTRY glutKeyboardUpFunc( void (* callback)( unsigned char key, int x, int y) );
        public static void KeyboardUpFunc(TCALLBACKglutKeyboardUpProc glutKeyboardUpProc)
        {
            glutKeyboardUpFunc(glutKeyboardUpProc);
        }

        // FGAPI void    FGAPIENTRY glutSpecialUpFunc( void (* callback)( int key, int x, int y) );
        public static void SpecialUpFunc(TCALLBACKglutSpecialUpProc glutSpecialUpProc)
        {
            glutSpecialUpFunc(glutSpecialUpProc);
        }

        // FGAPI void    FGAPIENTRY glutJoystickFunc( void (* callback)( unsigned int buttonMask, int x, int y, int z), int pollInterval );
        public static void JoystickFunc(TCALLBACKglutJoystickProc glutJoystickProc, int pollInterval)
        {
            glutJoystickFunc(glutJoystickProc, pollInterval);
        }

        // FGAPI void    FGAPIENTRY glutMenuStateFunc( void (* callback)( int state) );
        public static void MenuStateFunc(TCALLBACKglutMenuStateProc glutMenuStateProc)
        {
            glutMenuStateFunc(glutMenuStateProc);
        }

        // FGAPI void    FGAPIENTRY glutMenuStatusFunc( void (* callback)( int status, int x, int y) );
        public static void MenuStatusFunc(TCALLBACKglutMenuStatusProc glutMenuStatusProc)
        {
            glutMenuStatusFunc(glutMenuStatusProc);
        }

        // FGAPI void    FGAPIENTRY glutOverlayDisplayFunc( void (* callback)( void ) );
        public static void OverlayDisplayFunc(TCALLBACKglutOverlayDisplayProc glutOverlayDisplayProc)
        {
            glutOverlayDisplayFunc(glutOverlayDisplayProc);
        }

        // FGAPI void    FGAPIENTRY glutWindowStatusFunc( void (* callback)( int state) );
        public static void WindowStatusFunc(TCALLBACKglutWindowStatusProc glutWindowStatusProc)
        {
            glutWindowStatusFunc(glutWindowStatusProc);
        }

        // FGAPI void    FGAPIENTRY glutSpaceballMotionFunc( void (* callback)( int x, int y, int z) );
        public static void SpaceballMotionFunc(TCALLBACKglutSpaceballMotionProc glutSpaceballMotionProc)
        {
            glutSpaceballMotionFunc(glutSpaceballMotionProc);
        }

        // FGAPI void    FGAPIENTRY glutSpaceballRotateFunc( void (* callback)( int x, int y, int z) );
        public static void SpaceballRotateFunc(TCALLBACKglutSpaceballRotateProc glutSpaceballRotateProc)
        {
            glutSpaceballRotateFunc(glutSpaceballRotateProc);
        }

        // FGAPI void    FGAPIENTRY glutSpaceballButtonFunc( void (* callback)( int button, int state) );
        public static void SpaceballButtonFunc(TCALLBACKglutSpaceballButtonProc glutSpaceballButtonProc)
        {
            glutSpaceballButtonFunc(glutSpaceballButtonProc);
        }

        // FGAPI void    FGAPIENTRY glutButtonBoxFunc( void (* callback)( int button, int state) );
        public static void ButtonBoxFunc(TCALLBACKglutButtonBoxProc glutButtonBoxProc)
        {
            glutButtonBoxFunc(glutButtonBoxProc);
        }

        // FGAPI void    FGAPIENTRY glutDialsFunc( void (* callback)( int dial, int value) );
        public static void DialsFunc(TCALLBACKglutDialsProc glutDialsProc)
        {
            glutDialsFunc(glutDialsProc);
        }

        // FGAPI void    FGAPIENTRY glutTabletMotionFunc( void (* callback)( int x, int y) );
        public static void TabletMotionFunc(TCALLBACKglutTabletMotionProc glutTabletMotionProc)
        {
            glutTabletMotionFunc(glutTabletMotionProc);
        }

        // FGAPI void    FGAPIENTRY glutTabletButtonFunc( void (* callback)( int button, int state, int x, int y) );
        public static void TabletButtonFunc(TCALLBACKglutTabletButtonProc glutTabletButtonProc)
        {
            glutTabletButtonFunc(glutTabletButtonProc);
        }

        //---------------------------------------------------------------------
        // State setting and retrieval functions, see freeglut_state.c
        //---------------------------------------------------------------------
        // FGAPI int     FGAPIENTRY glutGet( GLenum query );
        public static int Get(GLenum query)
        {
            return glutGet(query);
        }

        // FGAPI int     FGAPIENTRY glutDeviceGet( GLenum query );
        public static int DeviceGet(GLenum query)
        {
            return glutDeviceGet(query);
        }

        // FGAPI int     FGAPIENTRY glutGetModifiers( void );
        public static int GetModifiers()
        {
            return glutGetModifiers();
        }

        // FGAPI int     FGAPIENTRY glutLayerGet( GLenum query );
        public static int LayerGet(GLenum query)
        {
            return glutLayerGet(query);
        }

        //---------------------------------------------------------------------
        // Font stuff, see freeglut_font.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutBitmapCharacter( void* font, int character );
        public static void BitmapCharacter(uint font, int character)
        {
            glutBitmapCharacter(font, character);
        }

        // FGAPI int     FGAPIENTRY glutBitmapWidth( void* font, int character );
        public static int BitmapWidth(uint font, int character)
        {
            return glutBitmapWidth(font, character);
        }

        // FGAPI void    FGAPIENTRY glutStrokeCharacter( void* font, int character );
        public static void StrokeCharacter(uint font, int character)
        {
            glutStrokeCharacter(font, character);
        }

        // FGAPI int     FGAPIENTRY glutStrokeWidth( void* font, int character );
        public static int StrokeWidth(uint font, int character)
        {
            return glutStrokeWidth(font, character);
        }

        // FGAPI int     FGAPIENTRY glutBitmapLength( void* font, const unsigned char* string );
        public static int BitmapLength(uint font, string str)
        {
            return glutBitmapLength(font, str);
        }

        // FGAPI int     FGAPIENTRY glutStrokeLength( void* font, const unsigned char* string );
        public static int StrokeLength(uint font, string str)
        {
            return glutStrokeLength(font, str);
        }

        //---------------------------------------------------------------------
        // Geometry functions, see freeglut_geometry.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutWireCube( GLdouble size );
        public static void WireCube(GLdouble size)
        {
            glutWireCube(size);
        }

        // FGAPI void    FGAPIENTRY glutSolidCube( GLdouble size );
        public static void SolidCube(GLdouble size)
        {
            glutSolidCube(size);
        }

        // FGAPI void    FGAPIENTRY glutWireSphere( GLdouble radius, GLint slices, GLint stacks );
        public static void WireSphere(GLdouble radius, GLint slices, GLint stacks)
        {
            glutWireSphere(radius, slices, stacks);
        }

        // FGAPI void    FGAPIENTRY glutSolidSphere( GLdouble radius, GLint slices, GLint stacks );
        public static void SolidSphere(GLdouble radius, GLint slices, GLint stacks)
        {
            glutSolidSphere(radius, slices, stacks);
        }

        // FGAPI void    FGAPIENTRY glutWireCone( GLdouble base, GLdouble height, GLint slices, GLint stacks );
        public static void WireCone(GLdouble modelbase, GLdouble height, GLint slices, GLint stacks)
        {
            glutWireCone(modelbase, height, slices, stacks);
        }

        // FGAPI void    FGAPIENTRY glutSolidCone( GLdouble base, GLdouble height, GLint slices, GLint stacks );
        public static void SolidCone(GLdouble modelbase, GLdouble height, GLint slices, GLint stacks)
        {
            glutSolidCone(modelbase, height, slices, stacks);
        }

        // FGAPI void    FGAPIENTRY glutWireTorus( GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings );
        public static void WireTorus(GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings)
        {
            glutWireTorus(innerRadius, outerRadius, sides, rings);
        }

        // FGAPI void    FGAPIENTRY glutSolidTorus( GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings );
        public static void SolidTorus(GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings)
        {
            glutSolidTorus(innerRadius, outerRadius, sides, rings);
        }

        // FGAPI void    FGAPIENTRY glutWireDodecahedron( void );
        public static void WireDodecahedron()
        {
            glutWireDodecahedron();
        }

        // FGAPI void    FGAPIENTRY glutSolidDodecahedron( void );
        public static void SolidDodecahedron()
        {
            glutSolidDodecahedron();
        }

        // FGAPI void    FGAPIENTRY glutWireOctahedron( void );
        public static void WireOctahedron()
        {
            glutWireOctahedron();
        }

        // FGAPI void    FGAPIENTRY glutSolidOctahedron( void );
        public static void SolidOctahedron()
        {
            glutSolidOctahedron();
        }

        // FGAPI void    FGAPIENTRY glutWireTetrahedron( void );
        public static void WireTetrahedron()
        {
            glutWireTetrahedron();
        }

        // FGAPI void    FGAPIENTRY glutSolidTetrahedron( void );
        public static void SolidTetrahedron()
        {
            glutSolidTetrahedron();
        }

        // FGAPI void    FGAPIENTRY glutWireIcosahedron( void );
        public static void WireIcosahedron()
        {
            glutWireIcosahedron();
        }

        // FGAPI void    FGAPIENTRY glutSolidIcosahedron( void );
        public static void SolidIcosahedron()
        {
            glutSolidIcosahedron();
        }

        //---------------------------------------------------------------------
        // Teapot rendering functions, found in freeglut_teapot.c
        // NB: front facing polygons have clockwise winding, not counter clockwise
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutWireTeapot( GLdouble size );
        public static void WireTeapot(GLdouble size)
        {
            glutWireTeapot(size);
        }

        // FGAPI void    FGAPIENTRY glutSolidTeapot( GLdouble size );
        public static void SolidTeapot(GLdouble size)
        {
            glutSolidTeapot(size);
        }

        //---------------------------------------------------------------------
        // Game mode functions, see freeglut_gamemode.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutGameModeString( const char* string );
        public static void GameModeString(string str)
        {
            glutGameModeString(str);
        }

        // FGAPI int     FGAPIENTRY glutEnterGameMode( void );
        public static int EnterGameMode()
        {
            return glutEnterGameMode();
        }

        // FGAPI void    FGAPIENTRY glutLeaveGameMode( void );
        public static void LeaveGameMode()
        {
            glutLeaveGameMode();
        }

        // FGAPI int     FGAPIENTRY glutGameModeGet( GLenum query );
        public static int GameModeGet(GLenum query)
        {
            return glutGameModeGet(query);
        }

        //---------------------------------------------------------------------
        // Video resize functions, see freeglut_videoresize.c
        //---------------------------------------------------------------------
        // FGAPI int     FGAPIENTRY glutVideoResizeGet( GLenum query );
        public static int VideoResizeGet(GLenum query)
        {
            return glutVideoResizeGet(query);
        }

        // FGAPI void    FGAPIENTRY glutSetupVideoResizing( void );
        public static void SetupVideoResizing()
        {
            glutSetupVideoResizing();
        }

        // FGAPI void    FGAPIENTRY glutStopVideoResizing( void );
        public static void StopVideoResizing()
        {
            glutStopVideoResizing();
        }

        // FGAPI void    FGAPIENTRY glutVideoResize( int x, int y, int width, int height );
        public static void VideoResize(int x, int y, int width, int height)
        {
            glutVideoResize(x, y, width, height);
        }

        // FGAPI void    FGAPIENTRY glutVideoPan( int x, int y, int width, int height );
        public static void VideoPan(int x, int y, int width, int height)
        {
            glutVideoPan(x, y, width, height);
        }

        //---------------------------------------------------------------------
        // Colormap functions, see freeglut_misc.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutSetColor( int color, GLfloat red, GLfloat green, GLfloat blue );
        public static void SetColor(int color, GLfloat red, GLfloat green, GLfloat blue)
        {
            glutSetColor(color, red, green, blue);
        }

        // FGAPI GLfloat FGAPIENTRY glutGetColor( int color, int component );
        public static GLfloat GetColor(int color, int component)
        {
            return glutGetColor(color, component);
        }

        // FGAPI void    FGAPIENTRY glutCopyColormap( int window );
        public static void CopyColormap(int window)
        {
            glutCopyColormap(window);
        }

        //---------------------------------------------------------------------
        // Misc keyboard and joystick functions, see freeglut_misc.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutIgnoreKeyRepeat( int ignore );
        public static void IgnoreKeyRepeat(int ignore)
        {
            glutIgnoreKeyRepeat(ignore);
        }

        // FGAPI void    FGAPIENTRY glutSetKeyRepeat( int repeatMode );
        public static void SetKeyRepeat(int repeatMode)
        {
            glutSetKeyRepeat(repeatMode);
        }

        // FGAPI void    FGAPIENTRY glutForceJoystickFunc( void );
        public static void ForceJoystickFunc()
        {
            glutForceJoystickFunc();
        }

        //---------------------------------------------------------------------
        // Misc functions, see freeglut_misc.c
        //---------------------------------------------------------------------
        // FGAPI int     FGAPIENTRY glutExtensionSupported( const char* extension );
        public static int ExtensionSupported(string extension)
        {
            return glutExtensionSupported(extension);
        }

        // FGAPI void    FGAPIENTRY glutReportErrors( void );
        public static void ReportErrors()
        {
            glutReportErrors();
        }

        ///////////////////////////////////////////////////////////////////////
        // FREEGLUT v2.8.1 FUNCTIONS (EXTENDED)
        ///////////////////////////////////////////////////////////////////////
        //---------------------------------------------------------------------
        // Process loop function, see freeglut_main.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutMainLoopEvent( void );
        public static void MainLoopEvent()
        {
            glutMainLoopEvent();
        }

        // FGAPI void    FGAPIENTRY glutLeaveMainLoop( void );
        public static void LeaveMainLoop()
        {
            glutLeaveMainLoop();
        }

        // FGAPI void    FGAPIENTRY glutExit         ( void );
        public static void Exit()
        {
            glutExit();
        }

        //---------------------------------------------------------------------
        // Window management functions, see freeglut_window.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutFullScreenToggle( void );
        public static void FullScreenToggle()
        {
            glutFullScreenToggle();
        }

        // FGAPI void    FGAPIENTRY glutLeaveFullScreen( void );
        public static void LeaveFullScreen()
        {
            glutLeaveFullScreen();
        }

        //---------------------------------------------------------------------
        // Window-specific callback functions, see freeglut_callbacks.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutMouseWheelFunc( void (* callback)( int wheel, int direction, int x, int y ) );
        public static void MouseWheelFunc(TCALLBACKglutMouseWheelProc glutMouseWheelProc)
        {
            glutMouseWheelFunc(glutMouseWheelProc);
        }

        // FGAPI void    FGAPIENTRY glutCloseFunc( void (* callback)( void ) );
        public static void CloseFunc(TCALLBACKglutCloseProc glutCloseProc)
        {
            glutCloseFunc(glutCloseProc);
        }

        // FGAPI void    FGAPIENTRY glutWMCloseFunc( void (* callback)( void ) );
        public static void WMCloseFunc(TCALLBACKglutWMCloseProc glutWMCloseProc)
        {
            glutWMCloseFunc(glutWMCloseProc);
        }

        // FGAPI void    FGAPIENTRY glutMenuDestroyFunc( void (* callback)( void ) );
        public static void MenuDestroyFunc(TCALLBACKglutMenuDestroyProc glutMenuDestroyProc)
        {
            glutMenuDestroyFunc(glutMenuDestroyProc);
        }

        //---------------------------------------------------------------------
        // State setting and retrieval functions, see freeglut_state.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutSetOption ( GLenum option_flag, int value );
        public static void SetOption(GLenum option_flag, int value)
        {
            glutSetOption(option_flag, value);
        }

        // FGAPI int *   FGAPIENTRY glutGetModeValues(GLenum mode, int * size);
        public unsafe static int[] GetModeValues(GLenum mode, int[] size)
        {
            int* pint;
           
            fixed (int* ptr_size = size)
            {
                pint = glutGetModeValues(mode, ptr_size);
            }

            int[] aint = new int[size[0]];

            for (int counter = 0; counter < size[0]; counter++)
            {
                aint[counter] = *pint;
                pint++;
            }

            return aint;
        }

        /* A.Donev: User-data manipulation */
        // FGAPI void*   FGAPIENTRY glutGetWindowData( void );
        public unsafe static IntPtr GetWindowData()
        {
            return (IntPtr)glutGetWindowData();
        }

        // FGAPI void    FGAPIENTRY glutSetWindowData(void* data);
        public unsafe static void SetWindowData(IntPtr data)
        {
            glutSetWindowData(data.ToPointer());
        }

        // FGAPI void*   FGAPIENTRY glutGetMenuData( void );
        public unsafe static IntPtr GetMenuData()
        {
            return (IntPtr)glutGetMenuData();
        }

        // FGAPI void    FGAPIENTRY glutSetMenuData(void* data);
        public unsafe static void SetMenuData(IntPtr data)
        {
            glutSetMenuData(data.ToPointer());
        }

        //---------------------------------------------------------------------
        // Font stuff, see freeglut_font.c
        //---------------------------------------------------------------------
        // FGAPI int     FGAPIENTRY glutBitmapHeight( void* font );
        public static int BitmapHeight(uint font)
        {
            return glutBitmapHeight(font);
        }

        // FGAPI GLfloat FGAPIENTRY glutStrokeHeight( void* font );
        public static GLfloat StrokeHeight(uint font)
        {
            return glutStrokeHeight(font);
        }

        // FGAPI void    FGAPIENTRY glutBitmapString( void* font, const unsigned char *string );
        public static void BitmapString(uint font, string str)
        {
            glutBitmapString(font, str);
        }

        // FGAPI void    FGAPIENTRY glutStrokeString( void* font, const unsigned char *string );
        public static void StrokeString(uint font, string str)
        {
            glutStrokeString(font, str);
        }

        //---------------------------------------------------------------------
        // Geometry functions, see freeglut_geometry.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutWireRhombicDodecahedron( void );
        public static void WireRhombicDodecahedron()
        {
            glutWireRhombicDodecahedron();
        }

        // FGAPI void    FGAPIENTRY glutSolidRhombicDodecahedron( void );
        public static void SolidRhombicDodecahedron()
        {
            glutSolidRhombicDodecahedron();
        }

        // FGAPI void    FGAPIENTRY glutWireSierpinskiSponge ( int num_levels, GLdouble offset[3], GLdouble scale );
        public static void WireSierpinskiSponge (int num_levels, GLdouble[] offset, GLdouble scale)
        {
            glutWireSierpinskiSponge (num_levels, offset, scale);
        }

        // FGAPI void    FGAPIENTRY glutSolidSierpinskiSponge ( int num_levels, GLdouble offset[3], GLdouble scale );
        public static void SolidSierpinskiSponge(int num_levels, GLdouble[] offset, GLdouble scale)
        {
            glutSolidSierpinskiSponge(num_levels, offset, scale);
        }

        // FGAPI void    FGAPIENTRY glutWireCylinder( GLdouble radius, GLdouble height, GLint slices, GLint stacks);
        public static void WireCylinder(GLdouble radius, GLdouble height, GLint slices, GLint stacks)
        {
            glutWireCylinder(radius, height, slices, stacks);
        }

        // FGAPI void    FGAPIENTRY glutSolidCylinder( GLdouble radius, GLdouble height, GLint slices, GLint stacks);
        public static void SolidCylinder(GLdouble radius, GLdouble height, GLint slices, GLint stacks)
        {
            glutSolidCylinder(radius, height, slices, stacks);
        }

        //---------------------------------------------------------------------
        // Extension functions, see freeglut_ext.c
        //---------------------------------------------------------------------
        // FGAPI GLUTproc FGAPIENTRY glutGetProcAddress( const char *procName );
        public static TGLUTproc GetProcAddress(string procName)
        {
            return glutGetProcAddress(procName);
        }

        //---------------------------------------------------------------------
        // Initialization functions, see freeglut_init.c
        //---------------------------------------------------------------------
        // FGAPI void    FGAPIENTRY glutInitContextVersion( int majorVersion, int minorVersion );
        public static void InitContextVersion(int majorVersion, int minorVersion)
        {
            glutInitContextVersion(majorVersion, minorVersion);
        }

        // FGAPI void    FGAPIENTRY glutInitContextFlags( int flags );
        public static void InitContextFlags(int flags)
        {
            glutInitContextFlags(flags);
        }

        // FGAPI void    FGAPIENTRY glutInitContextProfile( int profile );
        public static void InitContextProfile(int profile)
        {
            glutInitContextProfile(profile);
        }
    }
}