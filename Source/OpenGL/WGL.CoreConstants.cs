// ----------------------------------------------------------------------------
// FILE		: wgl.coreconstants.cs
// VERSION	: 1.1.0
// COMMENT	: "Windows" specific OpenGL Core constants.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2016
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;

namespace OpenGLDotNet
{
    public static partial class WGL
    {
        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE WGL CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        // Pixel Types
        public const byte PFD_TYPE_RGBA             = 0;
        public const byte PFD_TYPE_COLORINDEX       = 1;

        // PIXELFORMATDESCRIPTOR flags
        public const uint PFD_DOUBLEBUFFER          = 0x00000001;
        public const uint PFD_STEREO                = 0x00000002;
        public const uint PFD_DRAW_TO_WINDOW        = 0x00000004;
        public const uint PFD_DRAW_TO_BITMAP        = 0x00000008;
        public const uint PFD_SUPPORT_GDI           = 0x00000010;
        public const uint PFD_SUPPORT_OPENGL        = 0x00000020;
        public const uint PFD_GENERIC_FORMAT        = 0x00000040;
        public const uint PFD_NEED_PALETTE          = 0x00000080;
        public const uint PFD_NEED_SYSTEM_PALETTE   = 0x00000100;
        public const uint PFD_SWAP_EXCHANGE         = 0x00000200;
        public const uint PFD_SWAP_COPY             = 0x00000400;
        public const uint PFD_SWAP_LAYER_BUFFERS    = 0x00000800;
        public const uint PFD_GENERIC_ACCELERATED   = 0x00001000;
        public const uint PFD_SUPPORT_DIRECTDRAW    = 0x00002000;
        public const uint PFD_DIRECT3D_ACCELERATED  = 0x00004000;
        public const uint PFD_SUPPORT_COMPOSITION   = 0x00008000;

        // Layer Types
        public const sbyte PFD_MAIN_PLANE           = 0;
        public const sbyte PFD_OVERLAY_PLANE        = 1;
        public const sbyte PFD_UNDERLAY_PLANE       = -1;

        // PIXELFORMATDESCRIPTOR flags for use in ChoosePixelFormat only
        public const uint PFD_DEPTH_DONTCARE        = 0x20000000;
        public const uint PFD_DOUBLEBUFFER_DONTCARE = 0x40000000;
        public const uint PFD_STEREO_DONTCARE       = 0x80000000;

        // LAYERPLANEDESCRIPTOR
        public const uint LPD_TYPE_RGBA             = 0;
        public const uint LPD_TYPE_COLORINDEX       = 1;

        // LAYERPLANEDESCRIPTOR flags
        public const uint LPD_DOUBLEBUFFER          = 0x00000001;
        public const uint LPD_STEREO                = 0x00000002;
        public const uint LPD_SUPPORT_GDI           = 0x00000010;
        public const uint LPD_SUPPORT_OPENGL        = 0x00000020;
        public const uint LPD_SHARE_DEPTH           = 0x00000040;
        public const uint LPD_SHARE_STENCIL         = 0x00000080;
        public const uint LPD_SHARE_ACCUM           = 0x00000100;
        public const uint LPD_SWAP_EXCHANGE         = 0x00000200;
        public const uint LPD_SWAP_COPY             = 0x00000400;
        public const uint LPD_TRANSPARENT           = 0x00001000;
    }
}
