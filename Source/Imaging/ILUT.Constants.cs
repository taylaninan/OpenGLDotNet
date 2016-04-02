using System;

namespace OpenGLDotNet
{
    public static partial class ILUT
    {
        ///////////////////////////////////////////////////////////////////////
        // DevIL/ILUT v1.7.8 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        // Version & Vendor Information
        public const byte ILUT_VERSION_1_7_8                        = 1;
        public const byte ILUT_VERSION                              = 178;

        public const uint ILUT_VERSION_NUM                          = IL.IL_VERSION_NUM;
        public const uint ILUT_VENDOR                               = IL.IL_VENDOR;

        // Attribute Bits
        public const uint ILUT_OPENGL_BIT                           = 0x00000001;
        public const uint ILUT_D3D_BIT                              = 0x00000002;
        public const uint ILUT_ALL_ATTRIB_BITS                      = 0x000FFFFF;

        // Error Types
        public const uint ILUT_INVALID_ENUM                         = 0x0501;
        public const uint ILUT_OUT_OF_MEMORY                        = 0x0502;
        public const uint ILUT_INVALID_VALUE                        = 0x0505;
        public const uint ILUT_ILLEGAL_OPERATION                    = 0x0506;
        public const uint ILUT_INVALID_PARAM                        = 0x0509;
        public const uint ILUT_COULD_NOT_OPEN_FILE                  = 0x050A;
        public const uint ILUT_STACK_OVERFLOW                       = 0x050E;
        public const uint ILUT_STACK_UNDERFLOW                      = 0x050F;
        public const uint ILUT_BAD_DIMENSIONS                       = 0x0511;
        public const uint ILUT_NOT_SUPPORTED                        = 0x0550;

        // State Definitions
        public const uint ILUT_PALETTE_MODE                         = 0x0600;
        public const uint ILUT_OPENGL_CONV                          = 0x0610;
        public const uint ILUT_D3D_MIPLEVELS                        = 0x0620;
        public const uint ILUT_MAXTEX_WIDTH                         = 0x0630;
        public const uint ILUT_MAXTEX_HEIGHT                        = 0x0631;
        public const uint ILUT_MAXTEX_DEPTH                         = 0x0632;
        public const uint ILUT_GL_USE_S3TC                          = 0x0634;
        public const uint ILUT_D3D_USE_DXTC                         = 0x0634;
        public const uint ILUT_GL_GEN_S3TC                          = 0x0635;
        public const uint ILUT_D3D_GEN_DXTC                         = 0x0635;
        public const uint ILUT_S3TC_FORMAT                          = 0x0705;
        public const uint ILUT_DXTC_FORMAT                          = 0x0705;
        public const uint ILUT_D3D_POOL                             = 0x0706;
        public const uint ILUT_D3D_ALPHA_KEY_COLOR                  = 0x0707;
        public const uint ILUT_D3D_ALPHA_KEY_COLOUR                 = 0x0707;
        public const uint ILUT_FORCE_INTEGER_FORMAT                 = 0x0636;

        // This new state does automatic texture target detection
        // if enabled. Currently, only cubemap detection is supported.
        // if the current image is no cubemap, the 2d texture is chosen.
        public const uint ILUT_GL_AUTODETECT_TEXTURE_TARGET         = 0x0807;

        // The different rendering api's...
        // IMPORTANT NOTE: Only OPENGL and WIN32 rendering targets are supported by this C# library
        public const uint ILUT_OPENGL                               = 0;
        public const uint ILUT_ALLEGRO                              = 1;
        public const uint ILUT_WIN32                                = 2;
        public const uint ILUT_DIRECT3D8                            = 3;
        public const uint ILUT_DIRECT3D9                            = 4;
        public const uint ILUT_X11                                  = 5;
        public const uint ILUT_DIRECT3D10                           = 6;
    }
}
