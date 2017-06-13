// ----------------------------------------------------------------------------
// FILE		: glut.constants.cs
// VERSION	: 1.1.1
// COMMENT	: OpenGL Utility Toolkit (GLUT) library constants.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2017
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;

namespace OpenGLDotNet
{
    public static partial class GLUT
    {
        ///////////////////////////////////////////////////////////////////////
        // GLUT CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        public const uint GLUT_API_VERSION		                    = 3;
        public const uint GLUT_XLIB_IMPLEMENTATION	                = 13;

        /* Display mode bit masks. */
        public const uint GLUT_RGB			                        = 0;
        public const uint GLUT_RGBA			                        = GLUT_RGB;
        public const uint GLUT_INDEX			                    = 1;
        public const uint GLUT_SINGLE			                    = 0;
        public const uint GLUT_DOUBLE			                    = 2;
        public const uint GLUT_ACCUM			                    = 4;
        public const uint GLUT_ALPHA			                    = 8;
        public const uint GLUT_DEPTH			                    = 16;
        public const uint GLUT_STENCIL			                    = 32;
        public const uint GLUT_MULTISAMPLE		                    = 128;
        public const uint GLUT_STEREO			                    = 256;
        public const uint GLUT_LUMINANCE		                    = 512;

        /* Mouse buttons. */
        public const uint GLUT_LEFT_BUTTON		                    = 0;
        public const uint GLUT_MIDDLE_BUTTON	                    = 1;
        public const uint GLUT_RIGHT_BUTTON		                    = 2;

        /* Mouse button  state. */
        public const uint GLUT_DOWN		                            = 0;
        public const uint GLUT_UP				                    = 1;

        /* function keys */
        public const uint GLUT_KEY_F1			                    = 1;
        public const uint GLUT_KEY_F2			                    = 2;
        public const uint GLUT_KEY_F3			                    = 3;
        public const uint GLUT_KEY_F4			                    = 4;
        public const uint GLUT_KEY_F5			                    = 5;
        public const uint GLUT_KEY_F6			                    = 6;
        public const uint GLUT_KEY_F7			                    = 7;
        public const uint GLUT_KEY_F8			                    = 8;
        public const uint GLUT_KEY_F9			                    = 9;
        public const uint GLUT_KEY_F10			                    = 10;
        public const uint GLUT_KEY_F11			                    = 11;
        public const uint GLUT_KEY_F12			                    = 12;
        /* directional keys */
        public const uint GLUT_KEY_LEFT			                    = 100;
        public const uint GLUT_KEY_UP			                    = 101;
        public const uint GLUT_KEY_RIGHT		                    = 102;
        public const uint GLUT_KEY_DOWN			                    = 103;
        public const uint GLUT_KEY_PAGE_UP		                    = 104;
        public const uint GLUT_KEY_PAGE_DOWN	                    = 105;
        public const uint GLUT_KEY_HOME			                    = 106;
        public const uint GLUT_KEY_END			                    = 107;
        public const uint GLUT_KEY_INSERT		                    = 108;

        /* Entry/exit  state. */
        public const uint GLUT_LEFT			                        = 0;
        public const uint GLUT_ENTERED			                    = 1;

        /* Menu usage  state. */
        public const uint GLUT_MENU_NOT_IN_USE	                    = 0;
        public const uint GLUT_MENU_IN_USE		                    = 1;

        /* Visibility  state. */
        public const uint GLUT_NOT_VISIBLE		                    = 0;
        public const uint GLUT_VISIBLE			                    = 1;

        /* Window status  state. */
        public const uint GLUT_HIDDEN			                    = 0;
        public const uint GLUT_FULLY_RETAINED		                = 1;
        public const uint GLUT_PARTIALLY_RETAINED	                = 2;
        public const uint GLUT_FULLY_COVERED		                = 3;

        /* Color index component selection values. */
        public const uint GLUT_RED			                        = 0;
        public const uint GLUT_GREEN	                            = 1;
        public const uint GLUT_BLUE			                        = 2;

        /* glutUseLayer parameters. */
        public const uint GLUT_NORMAL			                    = 0;
        public const uint GLUT_OVERLAY			                    = 1;

        /* Stroke font constants (use these in GLUT program). */
        public const uint GLUT_STROKE_ROMAN		                    = 0;
        public const uint GLUT_STROKE_MONO_ROMAN		            = 1;
        /* Bitmap font constants (use these in GLUT program). */
        public const uint GLUT_BITMAP_9_BY_15		                = 2;
        public const uint GLUT_BITMAP_8_BY_13		                = 3;
        public const uint GLUT_BITMAP_TIMES_ROMAN_10	            = 4;
        public const uint GLUT_BITMAP_TIMES_ROMAN_24	            = 5;
        public const uint GLUT_BITMAP_HELVETICA_10	                = 6;
        public const uint GLUT_BITMAP_HELVETICA_12	                = 7;
        public const uint GLUT_BITMAP_HELVETICA_18	                = 8;

        /* glutGet parameters. */
        public const uint GLUT_WINDOW_X			                    = 100;
        public const uint GLUT_WINDOW_Y			                    = 101;
        public const uint GLUT_WINDOW_WIDTH		                    = 102;
        public const uint GLUT_WINDOW_HEIGHT		                = 103;
        public const uint GLUT_WINDOW_BUFFER_SIZE		            = 104;
        public const uint GLUT_WINDOW_STENCIL_SIZE	                = 105;
        public const uint GLUT_WINDOW_DEPTH_SIZE		            = 106;
        public const uint GLUT_WINDOW_RED_SIZE		                = 107;
        public const uint GLUT_WINDOW_GREEN_SIZE		            = 108;
        public const uint GLUT_WINDOW_BLUE_SIZE		                = 109;
        public const uint GLUT_WINDOW_ALPHA_SIZE		            = 110;
        public const uint GLUT_WINDOW_ACCUM_RED_SIZE	            = 111;
        public const uint GLUT_WINDOW_ACCUM_GREEN_SIZE	            = 112;
        public const uint GLUT_WINDOW_ACCUM_BLUE_SIZE	            = 113;
        public const uint GLUT_WINDOW_ACCUM_ALPHA_SIZE	            = 114;
        public const uint GLUT_WINDOW_DOUBLEBUFFER	                = 115;
        public const uint GLUT_WINDOW_RGBA		                    = 116;
        public const uint GLUT_WINDOW_PARENT		                = 117;
        public const uint GLUT_WINDOW_NUM_CHILDREN	                = 118;
        public const uint GLUT_WINDOW_COLORMAP_SIZE	                = 119;
        public const uint GLUT_WINDOW_NUM_SAMPLES		            = 120;
        public const uint GLUT_WINDOW_STEREO		                = 121;
        public const uint GLUT_WINDOW_CURSOR		                = 122;
        public const uint GLUT_SCREEN_WIDTH		                    = 200;
        public const uint GLUT_SCREEN_HEIGHT		                = 201;
        public const uint GLUT_SCREEN_WIDTH_MM		                = 202;
        public const uint GLUT_SCREEN_HEIGHT_MM		                = 203;
        public const uint GLUT_MENU_NUM_ITEMS		                = 300;
        public const uint GLUT_DISPLAY_MODE_POSSIBLE	            = 400;
        public const uint GLUT_INIT_WINDOW_X		                = 500;
        public const uint GLUT_INIT_WINDOW_Y		                = 501;
        public const uint GLUT_INIT_WINDOW_WIDTH		            = 502;
        public const uint GLUT_INIT_WINDOW_HEIGHT		            = 503;
        public const uint GLUT_INIT_DISPLAY_MODE		            = 504;
        public const uint GLUT_ELAPSED_TIME		                    = 700;
        public const uint GLUT_WINDOW_FORMAT_ID		                = 123;

        /* glutDeviceGet parameters. */
        public const uint GLUT_HAS_KEYBOARD		                    = 600;
        public const uint GLUT_HAS_MOUSE			                = 601;
        public const uint GLUT_HAS_SPACEBALL		                = 602;
        public const uint GLUT_HAS_DIAL_AND_BUTTON_BOX	            = 603;
        public const uint GLUT_HAS_TABLET			                = 604;
        public const uint GLUT_NUM_MOUSE_BUTTONS		            = 605;
        public const uint GLUT_NUM_SPACEBALL_BUTTONS	            = 606;
        public const uint GLUT_NUM_BUTTON_BOX_BUTTONS	            = 607;
        public const uint GLUT_NUM_DIALS			                = 608;
        public const uint GLUT_NUM_TABLET_BUTTONS		            = 609;
        public const uint GLUT_DEVICE_IGNORE_KEY_REPEAT             = 610;
        public const uint GLUT_DEVICE_KEY_REPEAT                    = 611;
        public const uint GLUT_HAS_JOYSTICK		                    = 612;
        public const uint GLUT_OWNS_JOYSTICK		                = 613;
        public const uint GLUT_JOYSTICK_BUTTONS		                = 614;
        public const uint GLUT_JOYSTICK_AXES		                = 615;
        public const uint GLUT_JOYSTICK_POLL_RATE		            = 616;

        /* glutLayerGet parameters. */
        public const uint GLUT_OVERLAY_POSSIBLE                     = 800;
        public const uint GLUT_LAYER_IN_USE		                    = 801;
        public const uint GLUT_HAS_OVERLAY		                    = 802;
        public const uint GLUT_TRANSPARENT_INDEX		            = 803;
        public const uint GLUT_NORMAL_DAMAGED		                = 804;
        public const uint GLUT_OVERLAY_DAMAGED		                = 805;

        /* glutVideoResizeGet parameters. */
        public const uint GLUT_VIDEO_RESIZE_POSSIBLE                = 900;
        public const uint GLUT_VIDEO_RESIZE_IN_USE	                = 901;
        public const uint GLUT_VIDEO_RESIZE_X_DELTA	                = 902;
        public const uint GLUT_VIDEO_RESIZE_Y_DELTA	                = 903;
        public const uint GLUT_VIDEO_RESIZE_WIDTH_DELTA	            = 904;
        public const uint GLUT_VIDEO_RESIZE_HEIGHT_DELTA	        = 905;
        public const uint GLUT_VIDEO_RESIZE_X		                = 906;
        public const uint GLUT_VIDEO_RESIZE_Y		                = 907;
        public const uint GLUT_VIDEO_RESIZE_WIDTH		            = 908;
        public const uint GLUT_VIDEO_RESIZE_HEIGHT	                = 909;

        /* glutGetModifiers return mask. */
        public const uint GLUT_ACTIVE_SHIFT                         = 1;
        public const uint GLUT_ACTIVE_CTRL                          = 2;
        public const uint GLUT_ACTIVE_ALT                           = 4;

        /* glutSetCursor parameters. */
        /* Basic arrows. */
        public const uint GLUT_CURSOR_RIGHT_ARROW		            = 0;
        public const uint GLUT_CURSOR_LEFT_ARROW		            = 1;
        /* Symbolic cursor shapes. */
        public const uint GLUT_CURSOR_INFO		                    = 2;
        public const uint GLUT_CURSOR_DESTROY		                = 3;
        public const uint GLUT_CURSOR_HELP		                    = 4;
        public const uint GLUT_CURSOR_CYCLE		                    = 5;
        public const uint GLUT_CURSOR_SPRAY		                    = 6;
        public const uint GLUT_CURSOR_WAIT		                    = 7;
        public const uint GLUT_CURSOR_TEXT		                    = 8;
        public const uint GLUT_CURSOR_CROSSHAIR		                = 9;
        /* Directional cursors. */
        public const uint GLUT_CURSOR_UP_DOWN		                = 10;
        public const uint GLUT_CURSOR_LEFT_RIGHT		            = 11;
        /* Sizing cursors. */
        public const uint GLUT_CURSOR_TOP_SIDE		                = 12;
        public const uint GLUT_CURSOR_BOTTOM_SIDE		            = 13;
        public const uint GLUT_CURSOR_LEFT_SIDE		                = 14;
        public const uint GLUT_CURSOR_RIGHT_SIDE		            = 15;
        public const uint GLUT_CURSOR_TOP_LEFT_CORNER	            = 16;
        public const uint GLUT_CURSOR_TOP_RIGHT_CORNER	            = 17;
        public const uint GLUT_CURSOR_BOTTOM_RIGHT_CORNER	        = 18;
        public const uint GLUT_CURSOR_BOTTOM_LEFT_CORNER	        = 19;
        /* Inherit from parent window. */
        public const uint GLUT_CURSOR_INHERIT		                = 100;
        /* Blank cursor. */
        public const uint GLUT_CURSOR_NONE		                    = 101;
        /* Fullscreen crosshair (if available). */
        public const uint GLUT_CURSOR_FULL_CROSSHAIR	            = 102;

        /* GLUT device control sub-API. */
        /* glutSetKeyRepeat modes. */
        public const uint GLUT_KEY_REPEAT_OFF		                = 0;
        public const uint GLUT_KEY_REPEAT_ON		                = 1;
        public const uint GLUT_KEY_REPEAT_DEFAULT		            = 2;

        /* Joystick button masks. */
        public const uint GLUT_JOYSTICK_BUTTON_A		            = 1;
        public const uint GLUT_JOYSTICK_BUTTON_B		            = 2;
        public const uint GLUT_JOYSTICK_BUTTON_C		            = 4;
        public const uint GLUT_JOYSTICK_BUTTON_D		            = 8;

        /* GLUT game mode sub-API. */
        /* glutGameModeGet. */
        public const uint GLUT_GAME_MODE_ACTIVE                     = 0;
        public const uint GLUT_GAME_MODE_POSSIBLE                   = 1;
        public const uint GLUT_GAME_MODE_WIDTH                      = 2;
        public const uint GLUT_GAME_MODE_HEIGHT                     = 3;
        public const uint GLUT_GAME_MODE_PIXEL_DEPTH                = 4;
        public const uint GLUT_GAME_MODE_REFRESH_RATE               = 5;
        public const uint GLUT_GAME_MODE_DISPLAY_CHANGED            = 6;
    }
}
