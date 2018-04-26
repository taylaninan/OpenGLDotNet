// ----------------------------------------------------------------------------
// FILE		: ilu.constants.cs
// VERSION	: 1.1.3
// DATE     : 26 April 2018
// COMMENT	: Image Library Utility (ILU). This "imported header" (from C/C++) 
//            defines required constants for use with ILU.
// WEB      : https://github.com/carmack78/opengldotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : taylaninan@yahoo.com 
// DATE     : 2014-2018
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;

namespace OpenGLDotNet
{
    public static partial class ILU
    {
        ///////////////////////////////////////////////////////////////////////
        // DevIL/ILU v1.7.8 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        public const byte ILU_VERSION_1_7_8                         = 1;
        public const byte ILU_VERSION                               = 178;

        public const uint ILU_VERSION_NUM                           = IL.IL_VERSION_NUM;
        public const uint ILU_VENDOR                                = IL.IL_VENDOR;

        // Scaling Filters
        public const uint ILU_FILTER                                = 0x2600;
        public const uint ILU_NEAREST                               = 0x2601;
        public const uint ILU_LINEAR                                = 0x2602;
        public const uint ILU_BILINEAR                              = 0x2603;
        public const uint ILU_SCALE_BOX                             = 0x2604;
        public const uint ILU_SCALE_TRIANGLE                        = 0x2605;
        public const uint ILU_SCALE_BELL                            = 0x2606;
        public const uint ILU_SCALE_BSPLINE                         = 0x2607;
        public const uint ILU_SCALE_LANCZOS3                        = 0x2608;
        public const uint ILU_SCALE_MITCHELL                        = 0x2609;

        // Error types
        public const uint ILU_INVALID_ENUM                          = 0x0501;
        public const uint ILU_OUT_OF_MEMORY                         = 0x0502;
        public const uint ILU_INTERNAL_ERROR                        = 0x0504;
        public const uint ILU_INVALID_VALUE                         = 0x0505;
        public const uint ILU_ILLEGAL_OPERATION                     = 0x0506;
        public const uint ILU_INVALID_PARAM                         = 0x0509;

        // Values
        public const uint ILU_PLACEMENT                             = 0x0700;
        public const uint ILU_LOWER_LEFT                            = 0x0701;
        public const uint ILU_LOWER_RIGHT                           = 0x0702;
        public const uint ILU_UPPER_LEFT                            = 0x0703;
        public const uint ILU_UPPER_RIGHT                           = 0x0704;
        public const uint ILU_CENTER                                = 0x0705;
        public const uint ILU_CONVOLUTION_MATRIX                    = 0x0710;
  
        // Languages
        public const uint ILU_ENGLISH                               = 0x0800;
        public const uint ILU_ARABIC                                = 0x0801;
        public const uint ILU_DUTCH                                 = 0x0802;
        public const uint ILU_JAPANESE                              = 0x0803;
        public const uint ILU_SPANISH                               = 0x0804;
        public const uint ILU_GERMAN                                = 0x0805;
        public const uint ILU_FRENCH                                = 0x0806;
    }
}
