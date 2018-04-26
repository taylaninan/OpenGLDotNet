// ----------------------------------------------------------------------------
// FILE		: glut.wrappers.cs
// VERSION	: 1.1.3
// DATE     : 26 April 2018
// COMMENT	: OpenGL Utility Toolkit (GLUT) library wrappers for low level functions.
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
    public static partial class GLUT
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
        // GLUT WRAPPERS
        ///////////////////////////////////////////////////////////////////////
        //---------------------------------------------------------------------
        // GLUT initialization sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutInit(int *argcp, char **argv);
        public unsafe static void Init(int[] argcp, string[] argv)
        {
            IntPtr StrPtrTable = BuildStringIntPtrTable(argv);

            fixed (int* ptr_argcp = argcp)
            {
                glutInit(ptr_argcp, (byte**)StrPtrTable);
            }

            Marshal.FreeHGlobal(StrPtrTable);
        }

        // GLUTAPI void APIENTRY glutInitDisplayMode(unsigned int mode);
        public static void InitDisplayMode(uint mode)
        {
            glutInitDisplayMode(mode);
        }

        // GLUTAPI void APIENTRY glutInitDisplayString(const char *string);
        public static void InitDisplayString(string str)
        {
            glutInitDisplayString(str);
        }

        // GLUTAPI void APIENTRY glutInitWindowPosition(int x, int y);
        public static void InitWindowPosition(int x, int y)
        {
            glutInitWindowPosition(x, y);
        }

        // GLUTAPI void APIENTRY glutInitWindowSize(int width, int height);
        public static void InitWindowSize(int width, int height)
        {
            glutInitWindowSize(width, height);
        }

        // GLUTAPI void APIENTRY glutMainLoop(void);
        public static void MainLoop()
        {
            glutMainLoop();
        }

        //---------------------------------------------------------------------
        // GLUT window sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI int APIENTRY glutCreateWindow(const char *title);
        public unsafe static int CreateWindow(string title)
        {
            return glutCreateWindow(title);
        }

        // GLUTAPI int APIENTRY glutCreateSubWindow(int win, int x, int y, int width, int height);
        public static int CreateSubWindow(int win, int x, int y, int width, int height)
        {
            return glutCreateSubWindow(win, x, y, width, height);
        }

        // GLUTAPI void APIENTRY glutDestroyWindow(int win);
        public static void DestroyWindow(int win)
        {
            glutDestroyWindow(win);
        }

        // GLUTAPI void APIENTRY glutPostRedisplay(void);
        public static void PostRedisplay()
        {
            glutPostRedisplay();
        }

        // GLUTAPI void APIENTRY glutPostWindowRedisplay(int win);
        public static void PostWindowRedisplay(int win)
        {
            glutPostWindowRedisplay(win);
        }

        // GLUTAPI void APIENTRY glutSwapBuffers(void);
        public static void SwapBuffers()
        {
            glutSwapBuffers();
        }

        // GLUTAPI int APIENTRY glutGetWindow(void);
        public static int GetWindow()
        {
            return glutGetWindow();
        }

        // GLUTAPI void APIENTRY glutSetWindow(int win);
        public static void SetWindow(int win)
        {
            glutSetWindow(win);
        }

        // GLUTAPI void APIENTRY glutSetWindowTitle(const char *title);
        public static void SetWindowTitle(string title)
        {
            glutSetWindowTitle(title);
        }

        // GLUTAPI void APIENTRY glutSetIconTitle(const char *title);
        public static void SetIconTitle(string title)
        {
            glutSetIconTitle(title);
        }

        // GLUTAPI void APIENTRY glutPositionWindow(int x, int y);
        public static void PositionWindow(int x, int y)
        {
            glutPositionWindow(x, y);
        }

        // GLUTAPI void APIENTRY glutReshapeWindow(int width, int height);
        public static void ReshapeWindow(int width, int height)
        {
            glutReshapeWindow(width, height);
        }

        // GLUTAPI void APIENTRY glutPopWindow(void);
        public static void PopWindow()
        {
            glutPopWindow();
        }

        // GLUTAPI void APIENTRY glutPushWindow(void);
        public static void PushWindow()
        {
            glutPushWindow();
        }

        // GLUTAPI void APIENTRY glutIconifyWindow(void);
        public static void IconifyWindow()
        {
            glutIconifyWindow();
        }

        // GLUTAPI void APIENTRY glutShowWindow(void);
        public static void ShowWindow()
        {
            glutShowWindow();
        }

        // GLUTAPI void APIENTRY glutHideWindow(void);
        public static void HideWindow()
        {
            glutHideWindow();
        }

        // GLUTAPI void APIENTRY glutFullScreen(void);
        public static void FullScreen()
        {
            glutFullScreen();
        }

        // GLUTAPI void APIENTRY glutSetCursor(int cursor);
        public static void SetCursor(int cursor)
        {
            glutSetCursor(cursor);
        }

        // GLUTAPI void APIENTRY glutWarpPointer(int x, int y);
        public static void WarpPointer(int x, int y)
        {
            glutWarpPointer(x, y);
        }

        //---------------------------------------------------------------------
        // GLUT overlay sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutEstablishOverlay(void);
        public static void EstablishOverlay()
        {
            glutEstablishOverlay();
        }

        // GLUTAPI void APIENTRY glutRemoveOverlay(void);
        public static void RemoveOverlay()
        {
            glutRemoveOverlay();
        }

        // GLUTAPI void APIENTRY glutUseLayer(GLenum layer);
        public static void UseLayer(GLenum layer)
        {
            glutUseLayer(layer);
        }

        // GLUTAPI void APIENTRY glutPostOverlayRedisplay(void);
        public static void PostOverlayRedisplay()
        {
            glutPostOverlayRedisplay();
        }

        // GLUTAPI void APIENTRY glutPostWindowOverlayRedisplay(int win);
        public static void PostWindowOverlayRedisplay(int win)
        {
            glutPostWindowOverlayRedisplay(win);
        }

        // GLUTAPI void APIENTRY glutShowOverlay(void);
        public static void ShowOverlay()
        {
            glutShowOverlay();
        }

        // GLUTAPI void APIENTRY glutHideOverlay(void);
        public static void HideOverlay()
        {
            glutHideOverlay();
        }

        //---------------------------------------------------------------------
        // GLUT menu sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutDestroyMenu(int menu);
        public static void DestroyMenu(int menu)
        {
            glutDestroyMenu(menu);
        }

        // GLUTAPI int APIENTRY glutGetMenu(void);
        public static int GetMenu()
        {
            return glutGetMenu();
        }

        // GLUTAPI void APIENTRY glutSetMenu(int menu);
        public static void SetMenu(int menu)
        {
            glutSetMenu(menu);
        }

        // GLUTAPI void APIENTRY glutAddMenuEntry(const char *label, int value);
        public static void AddMenuEntry(string label, int value)
        {
            glutAddMenuEntry(label, value);
        }

        // GLUTAPI void APIENTRY glutAddSubMenu(const char *label, int submenu);
        public static void AddSubMenu(string level, int submenu)
        {
            glutAddSubMenu(level, submenu);
        }

        // GLUTAPI void APIENTRY glutChangeToMenuEntry(int item, const char *label, int value);
        public static void ChangeToMenuEntry(int item, string label, int value)
        {
            glutChangeToMenuEntry(item, label, value);
        }

        // GLUTAPI void APIENTRY glutChangeToSubMenu(int item, const char *label, int submenu);
        public static void ChangeToSubMenu(int item, string label, int submenu)
        {
            glutChangeToSubMenu(item, label, submenu);
        }

        // GLUTAPI void APIENTRY glutRemoveMenuItem(int item);
        public static void RemoveMenuItem(int item)
        {
            glutRemoveMenuItem(item);
        }

        // GLUTAPI void APIENTRY glutAttachMenu(int button);
        public static void AttachMenu(int button)
        {
            glutAttachMenu(button);
        }

        // GLUTAPI void APIENTRY glutDetachMenu(int button);
        public static void DetachMenu(int button)
        {
            glutDetachMenu(button);
        }

        //---------------------------------------------------------------------
        // GLUT window callback sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutDisplayFunc(void (GLUTCALLBACK *func)(void));
        public static void DisplayFunc(TCALLBACKglutDisplayProc glutDisplayProc)
        {
            glutDisplayFunc(glutDisplayProc);
        }

        // GLUTAPI void APIENTRY glutReshapeFunc(void (GLUTCALLBACK *func)(int width, int height));
        public static void ReshapeFunc(TCALLBACKglutReshapeProc glutReshapeProc)
        {
            glutReshapeFunc(glutReshapeProc);
        }

        // GLUTAPI void APIENTRY glutKeyboardFunc(void (GLUTCALLBACK *func)(unsigned char key, int x, int y));
        public static void KeyboardFunc(TCALLBACKglutKeyboardProc glutKeyboardProc)
        {
            glutKeyboardFunc(glutKeyboardProc);
        }

        // GLUTAPI void APIENTRY glutMouseFunc(void (GLUTCALLBACK *func)(int button, int state, int x, int y));
        public static void MouseFunc(TCALLBACKglutMouseProc glutMouseProc)
        {
            glutMouseFunc(glutMouseProc);
        }

        // GLUTAPI void APIENTRY glutMotionFunc(void (GLUTCALLBACK *func)(int x, int y));
        public static void MotionFunc(TCALLBACKglutMotionProc glutMotionProc)
        {
            glutMotionFunc(glutMotionProc);
        }

        // GLUTAPI void APIENTRY glutPassiveMotionFunc(void (GLUTCALLBACK *func)(int x, int y));
        public static void PassiveMotionFunc(TCALLBACKglutPassiveMotionProc glutPassiveMotionProc)
        {
            glutPassiveMotionFunc(glutPassiveMotionProc);
        }

        // GLUTAPI void APIENTRY glutEntryFunc(void (GLUTCALLBACK *func)(int state));
        public static void EntryFunc(TCALLBACKglutEntryProc glutEntryProc)
        {
            glutEntryFunc(glutEntryProc);
        }

        // GLUTAPI void APIENTRY glutVisibilityFunc(void (GLUTCALLBACK *func)(int state));
        public static void VisibilityFunc(TCALLBACKglutVisibilityProc glutVisibilityProc)
        {
            glutVisibilityFunc(glutVisibilityProc);
        }

        // GLUTAPI void APIENTRY glutIdleFunc(void (GLUTCALLBACK *func)(void));
        public static void IdleFunc(TCALLBACKglutIdleProc glutIdleProc)
        {
            glutIdleFunc(glutIdleProc);
        }

        // GLUTAPI void APIENTRY glutTimerFunc(unsigned int millis, void (GLUTCALLBACK *func)(int value), int value);
        public static void TimerFunc(uint millis, TCALLBACKglutTimerProc glutTimerProc, int value)
        {
            glutTimerFunc(millis, glutTimerProc, value);
        }

        // GLUTAPI void APIENTRY glutMenuStateFunc(void (GLUTCALLBACK *func)(int state));
        public static void MenuStateFunc(TCALLBACKglutMenuStateProc glutMenuStateProc)
        {
            glutMenuStateFunc(glutMenuStateProc);
        }

        // GLUTAPI void APIENTRY glutSpecialFunc(void (GLUTCALLBACK *func)(int key, int x, int y));
        public static void SpecialFunc(TCALLBACKglutSpecialProc glutSpecialProc)
        {
            glutSpecialFunc(glutSpecialProc);
        }

        // GLUTAPI void APIENTRY glutSpaceballMotionFunc(void (GLUTCALLBACK *func)(int x, int y, int z));
        public static void SpaceballMotionFunc(TCALLBACKglutSpaceballMotionProc glutSpaceballMotionProc)
        {
            glutSpaceballMotionFunc(glutSpaceballMotionProc);
        }

        // GLUTAPI void APIENTRY glutSpaceballRotateFunc(void (GLUTCALLBACK *func)(int x, int y, int z));
        public static void SpaceballRotateFunc(TCALLBACKglutSpaceballRotateProc glutSpaceballRotateProc)
        {
            glutSpaceballRotateFunc(glutSpaceballRotateProc);
        }

        // GLUTAPI void APIENTRY glutSpaceballButtonFunc(void (GLUTCALLBACK *func)(int button, int state));
        public static void SpaceballButtonFunc(TCALLBACKglutSpaceballButtonProc glutSpaceballButtonProc)
        {
            glutSpaceballButtonFunc(glutSpaceballButtonProc);
        }

        // GLUTAPI void APIENTRY glutButtonBoxFunc(void (GLUTCALLBACK *func)(int button, int state));
        public static void ButtonBoxFunc(TCALLBACKglutButtonBoxProc glutButtonBoxProc)
        {
            glutButtonBoxFunc(glutButtonBoxProc);
        }

        // GLUTAPI void APIENTRY glutDialsFunc(void (GLUTCALLBACK *func)(int dial, int value));
        public static void DialsFunc(TCALLBACKglutDialsProc glutDialsProc)
        {
            glutDialsFunc(glutDialsProc);
        }

        // GLUTAPI void APIENTRY glutTabletMotionFunc(void (GLUTCALLBACK *func)(int x, int y));
        public static void TabletMotionFunc(TCALLBACKglutTabletMotionProc glutTabletMotionProc)
        {
            glutTabletMotionFunc(glutTabletMotionProc);
        }

        // GLUTAPI void APIENTRY glutTabletButtonFunc(void (GLUTCALLBACK *func)(int button, int state, int x, int y));
        public static void TabletButtonFunc(TCALLBACKglutTabletButtonProc glutTabletButtonProc)
        {
            glutTabletButtonFunc(glutTabletButtonProc);
        }

        // GLUTAPI void APIENTRY glutMenuStatusFunc(void (GLUTCALLBACK *func)(int status, int x, int y));
        public static void MenuStatusFunc(TCALLBACKglutMenuStatusProc glutMenuStatusProc)
        {
            glutMenuStatusFunc(glutMenuStatusProc);
        }

        // GLUTAPI void APIENTRY glutOverlayDisplayFunc(void (GLUTCALLBACK *func)(void));
        public static void OverlayDisplayFunc(TCALLBACKglutOverlayDisplayProc glutOverlayDisplayProc)
        {
            glutOverlayDisplayFunc(glutOverlayDisplayProc);
        }

        // GLUTAPI void APIENTRY glutWindowStatusFunc(void (*func)(int state));
        public static void WindowStatusFunc(TCALLBACKglutWindowStatusProc glutWindowStatusProc)
        {
            glutWindowStatusFunc(glutWindowStatusProc);
        }

        // GLUTAPI void APIENTRY glutKeyboardUpFunc(void (*func)(unsigned char key, int x, int y));
        public static void KeyboardUpFunc(TCALLBACKglutKeyboardUpProc glutKeyboardUpProc)
        {
            glutKeyboardUpFunc(glutKeyboardUpProc);
        }

        // GLUTAPI void APIENTRY glutSpecialUpFunc(void (*func)(int key, int x, int y));
        public static void SpecialUpFunc(TCALLBACKglutSpecialUpProc glutSpecialUpProc)
        {
            glutSpecialUpFunc(glutSpecialUpProc);
        }

        // GLUTAPI void APIENTRY glutJoystickFunc(void (*func)(unsigned int buttonMask, int x, int y, int z), int pollInterval);
        public static void JoystickFunc(TCALLBACKglutJoystickProc glutJoystickProc, int pollInterval)
        {
            glutJoystickFunc(glutJoystickProc, pollInterval);
        }

        //---------------------------------------------------------------------
        // GLUT color index sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutSetColor(int, GLfloat red, GLfloat green, GLfloat blue);
        public static void SetColor(int ndx, GLfloat red, GLfloat green, GLfloat blue)
        {
            glutSetColor(ndx, red, green, blue);
        }

        // GLUTAPI GLfloat APIENTRY glutGetColor(int ndx, int component);
        public static GLfloat GetColor(int ndx, int component)
        {
            return glutGetColor(ndx, component);
        }

        // GLUTAPI void APIENTRY glutCopyColormap(int win);
        public static void CopyColormap(int win)
        {
            glutCopyColormap(win);
        }

        //---------------------------------------------------------------------
        // GLUT state retrieval sub-API.
        //---------------------------------------------------------------------
        // GLUTAPI int APIENTRY glutGet(GLenum type);
        public static int Get(GLenum type)
        {
            return glutGet(type);
        }

        // GLUTAPI int APIENTRY glutDeviceGet(GLenum type);
        public static int DeviceGet(GLenum type)
        {
            return glutDeviceGet(type);
        }

        //---------------------------------------------------------------------
        // GLUT extension support sub-API
        //---------------------------------------------------------------------
        // GLUTAPI int APIENTRY glutExtensionSupported(const char *name);
        public static int ExtensionSupported(string name)
        {
            return glutExtensionSupported(name);
        }

        // GLUTAPI int APIENTRY glutGetModifiers(void);
        public static int GetModifiers()
        {
            return glutGetModifiers();
        }

        // GLUTAPI int APIENTRY glutLayerGet(GLenum type);
        public static int LayerGet(GLenum type)
        {
            return glutLayerGet(type);
        }

        //---------------------------------------------------------------------
        // GLUT font sub-API 
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutBitmapCharacter(void *font, int character);
        public static void BitmapCharacter(uint font, int character)
        {
            glutBitmapCharacter(font, character);
        }

        // GLUTAPI int APIENTRY glutBitmapWidth(void *font, int character);
        public static int BitmapWidth(uint font, int character)
        {
            return glutBitmapWidth(font, character);
        }

        // GLUTAPI void APIENTRY glutStrokeCharacter(void *font, int character);
        public static void StrokeCharacter(uint font, int character)
        {
            glutStrokeCharacter(font, character);
        }

        // GLUTAPI int APIENTRY glutStrokeWidth(void *font, int character);
        public static int StrokeWidth(uint font, int character)
        {
            return glutStrokeWidth(font, character);
        }

        // GLUTAPI int APIENTRY glutBitmapLength(void *font, const unsigned char *string);
        public static int BitmapLength(uint font, string str)
        {
            return glutBitmapLength(font, str);
        }

        // GLUTAPI int APIENTRY glutStrokeLength(void *font, const unsigned char *string);
        public static int StrokeLength(uint font, string str)
        {
            return glutStrokeLength(font, str);
        }

        //---------------------------------------------------------------------
        // GLUT pre-built models sub-API
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutWireSphere(GLdouble radius, GLint slices, GLint stacks);
        public static void WireSphere(GLdouble radius, GLint slices, GLint stacks)
        {
            glutWireSphere(radius, slices, stacks);
        }

        // GLUTAPI void APIENTRY glutSolidSphere(GLdouble radius, GLint slices, GLint stacks);
        public static void SolidSphere(GLdouble radius, GLint slices, GLint stacks)
        {
            glutSolidSphere(radius, slices, stacks);
        }

        // GLUTAPI void APIENTRY glutWireCone(GLdouble base, GLdouble height, GLint slices, GLint stacks);
        public static void WireCone(GLdouble modelbase, GLdouble height, GLint slices, GLint stacks)
        {
            glutWireCone(modelbase, height, slices, stacks);
        }

        // GLUTAPI void APIENTRY glutSolidCone(GLdouble base, GLdouble height, GLint slices, GLint stacks);
        public static void SolidCone(GLdouble modelbase, GLdouble height, GLint slices, GLint stacks)
        {
            glutSolidCone(modelbase, height, slices, stacks);
        }

        // GLUTAPI void APIENTRY glutWireCube(GLdouble size);
        public static void WireCube(GLdouble size)
        {
            glutWireCube(size);
        }

        // GLUTAPI void APIENTRY glutSolidCube(GLdouble size);
        public static void SolidCube(GLdouble size)
        {
            glutSolidCube(size);
        }

        // GLUTAPI void APIENTRY glutWireTorus(GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings);
        public static void WireTorus(GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings)
        {
            glutWireTorus(innerRadius, outerRadius, sides, rings);
        }

        // GLUTAPI void APIENTRY glutSolidTorus(GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings);
        public static void SolidTorus(GLdouble innerRadius, GLdouble outerRadius, GLint sides, GLint rings)
        {
            glutWireTorus(innerRadius, outerRadius, sides, rings);
        }

        // GLUTAPI void APIENTRY glutWireDodecahedron(void);
        public static void WireDodecahedron()
        {
            glutWireDodecahedron();
        }

        // GLUTAPI void APIENTRY glutSolidDodecahedron(void);
        public static void SolidDodecahedron()
        {
            glutWireDodecahedron();
        }

        // GLUTAPI void APIENTRY glutWireTeapot(GLdouble size);
        public static void WireTeapot(GLdouble size)
        {
            glutWireTeapot(size);
        }

        // GLUTAPI void APIENTRY glutSolidTeapot(GLdouble size);
        public static void SolidTeapot(GLdouble size)
        {
            glutSolidTeapot(size);
        }

        // GLUTAPI void APIENTRY glutWireOctahedron(void);
        public static void WireOctahedron()
        {
            glutWireOctahedron();
        }

        // GLUTAPI void APIENTRY glutSolidOctahedron(void);
        public static void SolidOctahedron()
        {
            glutSolidOctahedron();
        }

        // GLUTAPI void APIENTRY glutWireTetrahedron(void);
        public static void WireTetrahedron()
        {
            glutWireTetrahedron();
        }

        // GLUTAPI void APIENTRY glutSolidTetrahedron(void);
        public static void SolidTetrahedron()
        {
            glutSolidTetrahedron();
        }

        // GLUTAPI void APIENTRY glutWireIcosahedron(void);
        public static void WireIcosahedron()
        {
            glutWireIcosahedron();
        }

        // GLUTAPI void APIENTRY glutSolidIcosahedron(void);
        public static void SolidIcosahedron()
        {
            glutSolidIcosahedron();
        }

        //---------------------------------------------------------------------
        // GLUT video resize sub-API
        //---------------------------------------------------------------------
        // GLUTAPI int APIENTRY glutVideoResizeGet(GLenum param);
        public static int VideoResizeGet(GLenum param)
        {
            return glutVideoResizeGet(param);
        }

        // GLUTAPI void APIENTRY glutSetupVideoResizing(void);
        public static void SetupVideoResizing()
        {
            glutSetupVideoResizing();
        }

        // GLUTAPI void APIENTRY glutStopVideoResizing(void);
        public static void StopVideoResizing()
        {
            glutStopVideoResizing();
        }

        // GLUTAPI void APIENTRY glutVideoResize(int x, int y, int width, int height);
        public static void VideoResize(int x, int y, int width, int height)
        {
            glutVideoResize(x, y, width, height);
        }

        // GLUTAPI void APIENTRY glutVideoPan(int x, int y, int width, int height);
        public static void VideoPan(int x, int y, int width, int height)
        {
            glutVideoPan(x, y, width, height);
        }

        //---------------------------------------------------------------------
        // GLUT device control sub-API
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutIgnoreKeyRepeat(int ignore);
        public static void IgnoreKeyRepeat(int ignore)
        {
            glutIgnoreKeyRepeat(ignore);
        }

        // GLUTAPI void APIENTRY glutSetKeyRepeat(int repeatMode);
        public static void SetKeyRepeat(int repeatMode)
        {
            glutSetKeyRepeat(repeatMode);
        }

        // GLUTAPI void APIENTRY glutForceJoystickFunc(void);
        public static void ForceJoystickFunc()
        {
            glutForceJoystickFunc();
        }

        //---------------------------------------------------------------------
        // GLUT game mode sub-API
        //---------------------------------------------------------------------
        // GLUTAPI void APIENTRY glutGameModeString(const char *string);
        public static void GameModeString(string str)
        {
            glutGameModeString(str);
        }

        // GLUTAPI int APIENTRY glutEnterGameMode(void);
        public static int EnterGameMode()
        {
            return glutEnterGameMode();
        }

        // GLUTAPI void APIENTRY glutLeaveGameMode(void);
        public static void LeaveGameMode()
        {
            glutLeaveGameMode();
        }

        // GLUTAPI int APIENTRY glutGameModeGet(GLenum mode);
        public static int GameModeGet(GLenum mode)
        {
            return glutGameModeGet(mode);
        }
    }
}
