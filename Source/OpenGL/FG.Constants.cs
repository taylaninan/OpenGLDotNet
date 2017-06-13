// ----------------------------------------------------------------------------
// FILE		: fg.constants.cs
// VERSION	: 1.1.1
// COMMENT	: FREEGLUT library constants.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2017
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;

namespace OpenGLDotNet
{
    public static partial class FG
    {
        ///////////////////////////////////////////////////////////////////////
        // FREEGLUT v2.8.1 CONSTANTS (STANDARD)
        ///////////////////////////////////////////////////////////////////////
        /* The freeglut and GLUT API versions */
        public const uint FREEGLUT                                  = 1;
        public const uint GLUT_API_VERSION                          = 4;
        public const uint GLUT_XLIB_IMPLEMENTATION                  = 13;
        /* Deprecated */
        public const uint FREEGLUT_VERSION_2_0                      = 1;

        /* GLUT API macro definitions -- the special key codes: */
        public const uint GLUT_KEY_F1                               = 0x0001;
        public const uint GLUT_KEY_F2                               = 0x0002;
        public const uint GLUT_KEY_F3                               = 0x0003;
        public const uint GLUT_KEY_F4                               = 0x0004;
        public const uint GLUT_KEY_F5                               = 0x0005;
        public const uint GLUT_KEY_F6                               = 0x0006;
        public const uint GLUT_KEY_F7                               = 0x0007;
        public const uint GLUT_KEY_F8                               = 0x0008;
        public const uint GLUT_KEY_F9                               = 0x0009;
        public const uint GLUT_KEY_F10                              = 0x000A;
        public const uint GLUT_KEY_F11                              = 0x000B;
        public const uint GLUT_KEY_F12                              = 0x000C;
        public const uint GLUT_KEY_LEFT                             = 0x0064;
        public const uint GLUT_KEY_UP                               = 0x0065;
        public const uint GLUT_KEY_RIGHT                            = 0x0066;
        public const uint GLUT_KEY_DOWN                             = 0x0067;
        public const uint GLUT_KEY_PAGE_UP                          = 0x0068;
        public const uint GLUT_KEY_PAGE_DOWN                        = 0x0069;
        public const uint GLUT_KEY_HOME                             = 0x006A;
        public const uint GLUT_KEY_END                              = 0x006B;
        public const uint GLUT_KEY_INSERT                           = 0x006C;

        /* GLUT API macro definitions -- mouse state definitions */
        public const uint GLUT_LEFT_BUTTON                          = 0x0000;
        public const uint GLUT_MIDDLE_BUTTON                        = 0x0001;
        public const uint GLUT_RIGHT_BUTTON                         = 0x0002;
        public const uint GLUT_DOWN                                 = 0x0000;
        public const uint GLUT_UP                                   = 0x0001;
        public const uint GLUT_LEFT                                 = 0x0000;
        public const uint GLUT_ENTERED                              = 0x0001;

        /* GLUT API macro definitions -- the display mode definitions */
        public const uint GLUT_RGB                                  = 0x0000;
        public const uint GLUT_RGBA                                 = 0x0000;
        public const uint GLUT_INDEX                                = 0x0001;
        public const uint GLUT_SINGLE                               = 0x0000;
        public const uint GLUT_DOUBLE                               = 0x0002;
        public const uint GLUT_ACCUM                                = 0x0004;
        public const uint GLUT_ALPHA                                = 0x0008;
        public const uint GLUT_DEPTH                                = 0x0010;
        public const uint GLUT_STENCIL                              = 0x0020;
        public const uint GLUT_MULTISAMPLE                          = 0x0080;
        public const uint GLUT_STEREO                               = 0x0100;
        public const uint GLUT_LUMINANCE                            = 0x0200;

        /* GLUT API macro definitions -- windows and menu related definitions */
        public const uint GLUT_MENU_NOT_IN_USE                      = 0x0000;
        public const uint GLUT_MENU_IN_USE                          = 0x0001;
        public const uint GLUT_NOT_VISIBLE                          = 0x0000;
        public const uint GLUT_VISIBLE                              = 0x0001;
        public const uint GLUT_HIDDEN                               = 0x0000;
        public const uint GLUT_FULLY_RETAINED                       = 0x0001;
        public const uint GLUT_PARTIALLY_RETAINED                   = 0x0002;
        public const uint GLUT_FULLY_COVERED                        = 0x0003;

        /* GLUT API macro definitions -- fonts definitions */
        public const uint GLUT_STROKE_ROMAN                         = 0x0000;
        public const uint GLUT_STROKE_MONO_ROMAN                    = 0x0001;
        public const uint GLUT_BITMAP_9_BY_15                       = 0x0002;
        public const uint GLUT_BITMAP_8_BY_13                       = 0x0003;
        public const uint GLUT_BITMAP_TIMES_ROMAN_10                = 0x0004;
        public const uint GLUT_BITMAP_TIMES_ROMAN_24                = 0x0005;
        public const uint GLUT_BITMAP_HELVETICA_10                  = 0x0006;
        public const uint GLUT_BITMAP_HELVETICA_12                  = 0x0007;
        public const uint GLUT_BITMAP_HELVETICA_18                  = 0x0008;

        /* GLUT API macro definitions -- the glutGet parameters */
        public const uint GLUT_WINDOW_X                             = 0x0064;
        public const uint GLUT_WINDOW_Y                             = 0x0065;
        public const uint GLUT_WINDOW_WIDTH                         = 0x0066;
        public const uint GLUT_WINDOW_HEIGHT                        = 0x0067;
        public const uint GLUT_WINDOW_BUFFER_SIZE                   = 0x0068;
        public const uint GLUT_WINDOW_STENCIL_SIZE                  = 0x0069;
        public const uint GLUT_WINDOW_DEPTH_SIZE                    = 0x006A;
        public const uint GLUT_WINDOW_RED_SIZE                      = 0x006B;
        public const uint GLUT_WINDOW_GREEN_SIZE                    = 0x006C;
        public const uint GLUT_WINDOW_BLUE_SIZE                     = 0x006D;
        public const uint GLUT_WINDOW_ALPHA_SIZE                    = 0x006E;
        public const uint GLUT_WINDOW_ACCUM_RED_SIZE                = 0x006F;
        public const uint GLUT_WINDOW_ACCUM_GREEN_SIZE              = 0x0070;
        public const uint GLUT_WINDOW_ACCUM_BLUE_SIZE               = 0x0071;
        public const uint GLUT_WINDOW_ACCUM_ALPHA_SIZE              = 0x0072;
        public const uint GLUT_WINDOW_DOUBLEBUFFER                  = 0x0073;
        public const uint GLUT_WINDOW_RGBA                          = 0x0074;
        public const uint GLUT_WINDOW_PARENT                        = 0x0075;
        public const uint GLUT_WINDOW_NUM_CHILDREN                  = 0x0076;
        public const uint GLUT_WINDOW_COLORMAP_SIZE                 = 0x0077;
        public const uint GLUT_WINDOW_NUM_SAMPLES                   = 0x0078;
        public const uint GLUT_WINDOW_STEREO                        = 0x0079;
        public const uint GLUT_WINDOW_CURSOR                        = 0x007A;

        public const uint GLUT_SCREEN_WIDTH                         = 0x00C8;
        public const uint GLUT_SCREEN_HEIGHT                        = 0x00C9;
        public const uint GLUT_SCREEN_WIDTH_MM                      = 0x00CA;
        public const uint GLUT_SCREEN_HEIGHT_MM                     = 0x00CB;
        public const uint GLUT_MENU_NUM_ITEMS                       = 0x012C;
        public const uint GLUT_DISPLAY_MODE_POSSIBLE                = 0x0190;
        public const uint GLUT_INIT_WINDOW_X                        = 0x01F4;
        public const uint GLUT_INIT_WINDOW_Y                        = 0x01F5;
        public const uint GLUT_INIT_WINDOW_WIDTH                    = 0x01F6;
        public const uint GLUT_INIT_WINDOW_HEIGHT                   = 0x01F7;
        public const uint GLUT_INIT_DISPLAY_MODE                    = 0x01F8;
        public const uint GLUT_ELAPSED_TIME                         = 0x02BC;
        public const uint GLUT_WINDOW_FORMAT_ID                     = 0x007B;

        /* GLUT API macro definitions -- the glutDeviceGet parameters */
        public const uint GLUT_HAS_KEYBOARD                         = 0x0258;
        public const uint GLUT_HAS_MOUSE                            = 0x0259;
        public const uint GLUT_HAS_SPACEBALL                        = 0x025A;
        public const uint GLUT_HAS_DIAL_AND_BUTTON_BOX              = 0x025B;
        public const uint GLUT_HAS_TABLET                           = 0x025C;
        public const uint GLUT_NUM_MOUSE_BUTTONS                    = 0x025D;
        public const uint GLUT_NUM_SPACEBALL_BUTTONS                = 0x025E;
        public const uint GLUT_NUM_BUTTON_BOX_BUTTONS               = 0x025F;
        public const uint GLUT_NUM_DIALS                            = 0x0260;
        public const uint GLUT_NUM_TABLET_BUTTONS                   = 0x0261;
        public const uint GLUT_DEVICE_IGNORE_KEY_REPEAT             = 0x0262;
        public const uint GLUT_DEVICE_KEY_REPEAT                    = 0x0263;
        public const uint GLUT_HAS_JOYSTICK                         = 0x0264;
        public const uint GLUT_OWNS_JOYSTICK                        = 0x0265;
        public const uint GLUT_JOYSTICK_BUTTONS                     = 0x0266;
        public const uint GLUT_JOYSTICK_AXES                        = 0x0267;
        public const uint GLUT_JOYSTICK_POLL_RATE                   = 0x0268;

        /* GLUT API macro definitions -- the glutLayerGet parameters */
        public const uint GLUT_OVERLAY_POSSIBLE                     = 0x0320;
        public const uint GLUT_LAYER_IN_USE                         = 0x0321;
        public const uint GLUT_HAS_OVERLAY                          = 0x0322;
        public const uint GLUT_TRANSPARENT_INDEX                    = 0x0323;
        public const uint GLUT_NORMAL_DAMAGED                       = 0x0324;
        public const uint GLUT_OVERLAY_DAMAGED                      = 0x0325;

        /* GLUT API macro definitions -- the glutVideoResizeGet parameters */
        public const uint GLUT_VIDEO_RESIZE_POSSIBLE                = 0x0384;
        public const uint GLUT_VIDEO_RESIZE_IN_USE                  = 0x0385;
        public const uint GLUT_VIDEO_RESIZE_X_DELTA                 = 0x0386;
        public const uint GLUT_VIDEO_RESIZE_Y_DELTA                 = 0x0387;
        public const uint GLUT_VIDEO_RESIZE_WIDTH_DELTA             = 0x0388;
        public const uint GLUT_VIDEO_RESIZE_HEIGHT_DELTA            = 0x0389;
        public const uint GLUT_VIDEO_RESIZE_X                       = 0x038A;
        public const uint GLUT_VIDEO_RESIZE_Y                       = 0x038B;
        public const uint GLUT_VIDEO_RESIZE_WIDTH                   = 0x038C;
        public const uint GLUT_VIDEO_RESIZE_HEIGHT                  = 0x038D;

        /* GLUT API macro definitions -- the glutUseLayer parameters */
        public const uint GLUT_NORMAL                               = 0x0000;
        public const uint GLUT_OVERLAY                              = 0x0001;

        /* GLUT API macro definitions -- the glutGetModifiers parameters */
        public const uint GLUT_ACTIVE_SHIFT                         = 0x0001;
        public const uint GLUT_ACTIVE_CTRL                          = 0x0002;
        public const uint GLUT_ACTIVE_ALT                           = 0x0004;

        /* GLUT API macro definitions -- the glutSetCursor parameters */
        public const uint GLUT_CURSOR_RIGHT_ARROW                   = 0x0000;
        public const uint GLUT_CURSOR_LEFT_ARROW                    = 0x0001;
        public const uint GLUT_CURSOR_INFO                          = 0x0002;
        public const uint GLUT_CURSOR_DESTROY                       = 0x0003;
        public const uint GLUT_CURSOR_HELP                          = 0x0004;
        public const uint GLUT_CURSOR_CYCLE                         = 0x0005;
        public const uint GLUT_CURSOR_SPRAY                         = 0x0006;
        public const uint GLUT_CURSOR_WAIT                          = 0x0007;
        public const uint GLUT_CURSOR_TEXT                          = 0x0008;
        public const uint GLUT_CURSOR_CROSSHAIR                     = 0x0009;
        public const uint GLUT_CURSOR_UP_DOWN                       = 0x000A;
        public const uint GLUT_CURSOR_LEFT_RIGHT                    = 0x000B;
        public const uint GLUT_CURSOR_TOP_SIDE                      = 0x000C;
        public const uint GLUT_CURSOR_BOTTOM_SIDE                   = 0x000D;
        public const uint GLUT_CURSOR_LEFT_SIDE                     = 0x000E;
        public const uint GLUT_CURSOR_RIGHT_SIDE                    = 0x000F;
        public const uint GLUT_CURSOR_TOP_LEFT_CORNER               = 0x0010;
        public const uint GLUT_CURSOR_TOP_RIGHT_CORNER              = 0x0011;
        public const uint GLUT_CURSOR_BOTTOM_RIGHT_CORNER           = 0x0012;
        public const uint GLUT_CURSOR_BOTTOM_LEFT_CORNER            = 0x0013;
        public const uint GLUT_CURSOR_INHERIT                       = 0x0064;
        public const uint GLUT_CURSOR_NONE                          = 0x0065;
        public const uint GLUT_CURSOR_FULL_CROSSHAIR                = 0x0066;

        /* GLUT API macro definitions -- RGB color component specification definitions */
        public const uint GLUT_RED                                  = 0x0000;
        public const uint GLUT_GREEN                                = 0x0001;
        public const uint GLUT_BLUE                                 = 0x0002;

        /* GLUT API macro definitions -- additional keyboard and joystick definitions */
        public const uint GLUT_KEY_REPEAT_OFF                       = 0x0000;
        public const uint GLUT_KEY_REPEAT_ON                        = 0x0001;
        public const uint GLUT_KEY_REPEAT_DEFAULT                   = 0x0002;

        public const uint GLUT_JOYSTICK_BUTTON_A                    = 0x0001;
        public const uint GLUT_JOYSTICK_BUTTON_B                    = 0x0002;
        public const uint GLUT_JOYSTICK_BUTTON_C                    = 0x0004;
        public const uint GLUT_JOYSTICK_BUTTON_D                    = 0x0008;

        /* GLUT API macro definitions -- game mode definitions */
        public const uint GLUT_GAME_MODE_ACTIVE                     = 0x0000;
        public const uint GLUT_GAME_MODE_POSSIBLE                   = 0x0001;
        public const uint GLUT_GAME_MODE_WIDTH                      = 0x0002;
        public const uint GLUT_GAME_MODE_HEIGHT                     = 0x0003;
        public const uint GLUT_GAME_MODE_PIXEL_DEPTH                = 0x0004;
        public const uint GLUT_GAME_MODE_REFRESH_RATE               = 0x0005;
        public const uint GLUT_GAME_MODE_DISPLAY_CHANGED            = 0x0006;

        ///////////////////////////////////////////////////////////////////////
        // FREEGLUT v2.8.1 CONSTANTS (EXTENDED)
        ///////////////////////////////////////////////////////////////////////
        /* Additional GLUT Key definitions for the Special key function */
        public const uint GLUT_KEY_NUM_LOCK                         = 0x006D;
        public const uint GLUT_KEY_BEGIN                            = 0x006E;
        public const uint GLUT_KEY_DELETE                           = 0x006F;
        public const uint GLUT_KEY_SHIFT_L                          = 0x0070;
        public const uint GLUT_KEY_SHIFT_R                          = 0x0071;
        public const uint GLUT_KEY_CTRL_L                           = 0x0072;
        public const uint GLUT_KEY_CTRL_R                           = 0x0073;
        public const uint GLUT_KEY_ALT_L                            = 0x0074;
        public const uint GLUT_KEY_ALT_R                            = 0x0075;

        /* GLUT API Extension macro definitions -- behaviour when the user clicks on an "x" to close a window */
        public const uint GLUT_ACTION_EXIT                          = 0;
        public const uint GLUT_ACTION_GLUTMAINLOOP_RETURNS          = 1;
        public const uint GLUT_ACTION_CONTINUE_EXECUTION            = 2;

        /* Create a new rendering context when the user opens a new window? */
        public const uint GLUT_CREATE_NEW_CONTEXT                   = 0;
        public const uint GLUT_USE_CURRENT_CONTEXT                  = 1;

        /* Direct/Indirect rendering context options (has meaning only in Unix/X11) */
        public const uint GLUT_FORCE_INDIRECT_CONTEXT               = 0;
        public const uint GLUT_ALLOW_DIRECT_CONTEXT                 = 1;
        public const uint GLUT_TRY_DIRECT_CONTEXT                   = 2;
        public const uint GLUT_FORCE_DIRECT_CONTEXT                 = 3;

        /* GLUT API Extension macro definitions -- the glutGet parameters */
        public const uint GLUT_INIT_STATE                           = 0x007C;

        public const uint GLUT_ACTION_ON_WINDOW_CLOSE               = 0x01F9;

        public const uint GLUT_WINDOW_BORDER_WIDTH                  = 0x01FA;
        public const uint GLUT_WINDOW_BORDER_HEIGHT                 = 0x01FB;
        public const uint GLUT_WINDOW_HEADER_HEIGHT                 = 0x01FB; /* Docs say it should always have been GLUT_WINDOW_BORDER_HEIGHT, keep this for backward compatibility */

        public const uint GLUT_VERSION                              = 0x01FC;

        public const uint GLUT_RENDERING_CONTEXT                    = 0x01FD;
        public const uint GLUT_DIRECT_RENDERING                     = 0x01FE;

        public const uint GLUT_FULL_SCREEN                          = 0x01FF;

        public const uint GLUT_SKIP_STALE_MOTION_EVENTS             = 0x0204;

        /* New tokens for glutInitDisplayMode. Only one GLUT_AUXn bit may be used at a time. Value 0x0400 is defined in OpenGLUT. */
        public const uint GLUT_AUX                                  = 0x1000;

        public const uint GLUT_AUX1                                 = 0x1000;
        public const uint GLUT_AUX2                                 = 0x2000;
        public const uint GLUT_AUX3                                 = 0x4000;
        public const uint GLUT_AUX4                                 = 0x8000;

        /* Context-related flags, see freeglut_state.c */
        public const uint GLUT_INIT_MAJOR_VERSION                   = 0x0200;
        public const uint GLUT_INIT_MINOR_VERSION                   = 0x0201;
        public const uint GLUT_INIT_FLAGS                           = 0x0202;
        public const uint GLUT_INIT_PROFILE                         = 0x0203;

        /* Flags for glutInitContextFlags, see freeglut_init.c */
        public const uint GLUT_DEBUG                                = 0x0001;
        public const uint GLUT_FORWARD_COMPATIBLE                   = 0x0002;

        /* Flags for glutInitContextProfile, see freeglut_init.c */
        public const uint GLUT_CORE_PROFILE                         = 0x0001;
        public const uint GLUT_COMPATIBILITY_PROFILE                = 0x0002;

        /* GLUT API macro definitions -- the display mode definitions */
        public const uint GLUT_CAPTIONLESS                          = 0x0400;
        public const uint GLUT_BORDERLESS                           = 0x0800;
        public const uint GLUT_SRGB                                 = 0x1000;
    }
}
