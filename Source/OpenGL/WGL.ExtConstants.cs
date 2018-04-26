// ----------------------------------------------------------------------------
// FILE		: wgl.extconstants.cs
// VERSION	: 1.1.3
// DATE     : 26 April 2018
// COMMENT	: "Windows" specific OpenGL Extension constants.
// WEB      : https://github.com/carmack78/opengldotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : taylaninan@yahoo.com 
// DATE     : 2014-2018
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;

namespace OpenGLDotNet
{
    public static partial class WGL
    {
        ///////////////////////////////////////////////////////////////////////
        // WGL EXTENSION CONSTANTS
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_3DFX_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_3DFX_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_3DFX_multisample
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_SAMPLE_BUFFERS_3DFX                   = 0x2060;
        public const uint WGL_SAMPLES_3DFX                          = 0x2061;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_3DL_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_3DL_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_3DL_stereo_control
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_STEREO_EMITTER_ENABLE_3DL             = 0x2055;
        public const uint WGL_STEREO_EMITTER_DISABLE_3DL            = 0x2056;
        public const uint WGL_STEREO_POLARITY_NORMAL_3DL            = 0x2057;
        public const uint WGL_STEREO_POLARITY_INVERT_3DL            = 0x2058;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_AMD_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_AMD_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_AMD_gpu_association
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_GPU_VENDOR_AMD                        = 0x1F00;
        public const uint WGL_GPU_RENDERER_STRING_AMD               = 0x1F01;
        public const uint WGL_GPU_OPENGL_VERSION_STRING_AMD         = 0x1F02;
        public const uint WGL_GPU_FASTEST_TARGET_GPUS_AMD           = 0x21A2;
        public const uint WGL_GPU_RAM_AMD                           = 0x21A3;
        public const uint WGL_GPU_CLOCK_AMD                         = 0x21A4;
        public const uint WGL_GPU_NUM_PIPES_AMD                     = 0x21A5;
        public const uint WGL_GPU_NUM_SIMD_AMD                      = 0x21A6;
        public const uint WGL_GPU_NUM_RB_AMD                        = 0x21A7;
        public const uint WGL_GPU_NUM_SPI_AMD                       = 0x21A8;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_ARB_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_buffer_region
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_FRONT_COLOR_BUFFER_BIT_ARB            = 0x00000001;
        public const uint WGL_BACK_COLOR_BUFFER_BIT_ARB             = 0x00000002;
        public const uint WGL_DEPTH_BUFFER_BIT_ARB                  = 0x00000004;
        public const uint WGL_STENCIL_BUFFER_BIT_ARB                = 0x00000008;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_context_flush_control
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_CONTEXT_RELEASE_BEHAVIOR_ARB          = 0x2097;
        public const uint WGL_CONTEXT_RELEASE_BEHAVIOR_NONE_ARB     = 0x0000;
        public const uint WGL_CONTEXT_RELEASE_BEHAVIOR_FLUSH_ARB    = 0x2098;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_create_context
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_CONTEXT_DEBUG_BIT_ARB                 = 0x00000001;
        public const uint WGL_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB    = 0x00000002;
        public const uint WGL_CONTEXT_MAJOR_VERSION_ARB             = 0x2091;
        public const uint WGL_CONTEXT_MINOR_VERSION_ARB             = 0x2092;
        public const uint WGL_CONTEXT_LAYER_PLANE_ARB               = 0x2093;
        public const uint WGL_CONTEXT_FLAGS_ARB                     = 0x2094;
        public const uint ERROR_INVALID_VERSION_ARB                 = 0x2095;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_create_context_profile
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_CONTEXT_PROFILE_MASK_ARB              = 0x9126;
        public const uint WGL_CONTEXT_CORE_PROFILE_BIT_ARB          = 0x00000001;
        public const uint WGL_CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB = 0x00000002;
        public const uint ERROR_INVALID_PROFILE_ARB                 = 0x2096;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_create_context_robustness
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_CONTEXT_ROBUST_ACCESS_BIT_ARB             = 0x00000004;
        public const uint WGL_LOSE_CONTEXT_ON_RESET_ARB                 = 0x8252;
        public const uint WGL_CONTEXT_RESET_NOTIFICATION_STRATEGY_ARB   = 0x8256;
        public const uint WGL_NO_RESET_NOTIFICATION_ARB                 = 0x8261;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_extensions_string (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_framebuffer_sRGB
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_FRAMEBUFFER_SRGB_CAPABLE_ARB          = 0x20A9;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_make_current_read
        ///////////////////////////////////////////////////////////////////////
        public const uint ERROR_INVALID_PIXEL_TYPE_ARB              = 0x2043;
        public const uint ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB    = 0x2054;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_multisample
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_SAMPLE_BUFFERS_ARB                    = 0x2041;
        public const uint WGL_SAMPLES_ARB                           = 0x2042;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_pbuffer
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_DRAW_TO_PBUFFER_ARB                   = 0x202D;
        public const uint WGL_MAX_PBUFFER_PIXELS_ARB                = 0x202E;
        public const uint WGL_MAX_PBUFFER_WIDTH_ARB                 = 0x202F;
        public const uint WGL_MAX_PBUFFER_HEIGHT_ARB                = 0x2030;
        public const uint WGL_PBUFFER_LARGEST_ARB                   = 0x2033;
        public const uint WGL_PBUFFER_WIDTH_ARB                     = 0x2034;
        public const uint WGL_PBUFFER_HEIGHT_ARB                    = 0x2035;
        public const uint WGL_PBUFFER_LOST_ARB                      = 0x2036;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_pixel_format
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_NUMBER_PIXEL_FORMATS_ARB              = 0x2000;
        public const uint WGL_DRAW_TO_WINDOW_ARB                    = 0x2001;
        public const uint WGL_DRAW_TO_BITMAP_ARB                    = 0x2002;
        public const uint WGL_ACCELERATION_ARB                      = 0x2003;
        public const uint WGL_NEED_PALETTE_ARB                      = 0x2004;
        public const uint WGL_NEED_SYSTEM_PALETTE_ARB               = 0x2005;
        public const uint WGL_SWAP_LAYER_BUFFERS_ARB                = 0x2006;
        public const uint WGL_SWAP_METHOD_ARB                       = 0x2007;
        public const uint WGL_NUMBER_OVERLAYS_ARB                   = 0x2008;
        public const uint WGL_NUMBER_UNDERLAYS_ARB                  = 0x2009;
        public const uint WGL_TRANSPARENT_ARB                       = 0x200A;
        public const uint WGL_TRANSPARENT_RED_VALUE_ARB             = 0x2037;
        public const uint WGL_TRANSPARENT_GREEN_VALUE_ARB           = 0x2038;
        public const uint WGL_TRANSPARENT_BLUE_VALUE_ARB            = 0x2039;
        public const uint WGL_TRANSPARENT_ALPHA_VALUE_ARB           = 0x203A;
        public const uint WGL_TRANSPARENT_INDEX_VALUE_ARB           = 0x203B;
        public const uint WGL_SHARE_DEPTH_ARB                       = 0x200C;
        public const uint WGL_SHARE_STENCIL_ARB                     = 0x200D;
        public const uint WGL_SHARE_ACCUM_ARB                       = 0x200E;
        public const uint WGL_SUPPORT_GDI_ARB                       = 0x200F;
        public const uint WGL_SUPPORT_OPENGL_ARB                    = 0x2010;
        public const uint WGL_DOUBLE_BUFFER_ARB                     = 0x2011;
        public const uint WGL_STEREO_ARB                            = 0x2012;
        public const uint WGL_PIXEL_TYPE_ARB                        = 0x2013;
        public const uint WGL_COLOR_BITS_ARB                        = 0x2014;
        public const uint WGL_RED_BITS_ARB                          = 0x2015;
        public const uint WGL_RED_SHIFT_ARB                         = 0x2016;
        public const uint WGL_GREEN_BITS_ARB                        = 0x2017;
        public const uint WGL_GREEN_SHIFT_ARB                       = 0x2018;
        public const uint WGL_BLUE_BITS_ARB                         = 0x2019;
        public const uint WGL_BLUE_SHIFT_ARB                        = 0x201A;
        public const uint WGL_ALPHA_BITS_ARB                        = 0x201B;
        public const uint WGL_ALPHA_SHIFT_ARB                       = 0x201C;
        public const uint WGL_ACCUM_BITS_ARB                        = 0x201D;
        public const uint WGL_ACCUM_RED_BITS_ARB                    = 0x201E;
        public const uint WGL_ACCUM_GREEN_BITS_ARB                  = 0x201F;
        public const uint WGL_ACCUM_BLUE_BITS_ARB                   = 0x2020;
        public const uint WGL_ACCUM_ALPHA_BITS_ARB                  = 0x2021;
        public const uint WGL_DEPTH_BITS_ARB                        = 0x2022;
        public const uint WGL_STENCIL_BITS_ARB                      = 0x2023;
        public const uint WGL_AUX_BUFFERS_ARB                       = 0x2024;
        public const uint WGL_NO_ACCELERATION_ARB                   = 0x2025;
        public const uint WGL_GENERIC_ACCELERATION_ARB              = 0x2026;
        public const uint WGL_FULL_ACCELERATION_ARB                 = 0x2027;
        public const uint WGL_SWAP_EXCHANGE_ARB                     = 0x2028;
        public const uint WGL_SWAP_COPY_ARB                         = 0x2029;
        public const uint WGL_SWAP_UNDEFINED_ARB                    = 0x202A;
        public const uint WGL_TYPE_RGBA_ARB                         = 0x202B;
        public const uint WGL_TYPE_COLORINDEX_ARB                   = 0x202C;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_pixel_format_float
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_TYPE_RGBA_FLOAT_ARB                   = 0x21A0;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_render_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_BIND_TO_TEXTURE_RGB_ARB               = 0x2070;
        public const uint WGL_BIND_TO_TEXTURE_RGBA_ARB              = 0x2071;
        public const uint WGL_TEXTURE_FORMAT_ARB                    = 0x2072;
        public const uint WGL_TEXTURE_TARGET_ARB                    = 0x2073;
        public const uint WGL_MIPMAP_TEXTURE_ARB                    = 0x2074;
        public const uint WGL_TEXTURE_RGB_ARB                       = 0x2075;
        public const uint WGL_TEXTURE_RGBA_ARB                      = 0x2076;
        public const uint WGL_NO_TEXTURE_ARB                        = 0x2077;
        public const uint WGL_TEXTURE_CUBE_MAP_ARB                  = 0x2078;
        public const uint WGL_TEXTURE_1D_ARB                        = 0x2079;
        public const uint WGL_TEXTURE_2D_ARB                        = 0x207A;
        public const uint WGL_MIPMAP_LEVEL_ARB                      = 0x207B;
        public const uint WGL_CUBE_MAP_FACE_ARB                     = 0x207C;
        public const uint WGL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB       = 0x207D;
        public const uint WGL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB       = 0x207E;
        public const uint WGL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB       = 0x207F;
        public const uint WGL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB       = 0x2080;
        public const uint WGL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB       = 0x2081;
        public const uint WGL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB       = 0x2082;
        public const uint WGL_FRONT_LEFT_ARB                        = 0x2083;
        public const uint WGL_FRONT_RIGHT_ARB                       = 0x2084;
        public const uint WGL_BACK_LEFT_ARB                         = 0x2085;
        public const uint WGL_BACK_RIGHT_ARB                        = 0x2086;
        public const uint WGL_AUX0_ARB                              = 0x2087;
        public const uint WGL_AUX1_ARB                              = 0x2088;
        public const uint WGL_AUX2_ARB                              = 0x2089;
        public const uint WGL_AUX3_ARB                              = 0x208A;
        public const uint WGL_AUX4_ARB                              = 0x208B;
        public const uint WGL_AUX5_ARB                              = 0x208C;
        public const uint WGL_AUX6_ARB                              = 0x208D;
        public const uint WGL_AUX7_ARB                              = 0x208E;
        public const uint WGL_AUX8_ARB                              = 0x208F;
        public const uint WGL_AUX9_ARB                              = 0x2090;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_robustness_application_isolation
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_CONTEXT_RESET_ISOLATION_BIT_ARB       = 0x00000008;

        ///////////////////////////////////////////////////////////////////////
        // WGL_ARB_robustness_share_group_isolation (no constants)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_ATI_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_ATI_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_ATI_pixel_format_float
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_TYPE_RGBA_FLOAT_ATI                   = 0x21A0;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_EXT_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_create_context_es_profile
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_CONTEXT_ES_PROFILE_BIT_EXT            = 0x00000004;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_create_context_es2_profile
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_CONTEXT_ES2_PROFILE_BIT_EXT           = 0x00000004;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_depth_float
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_DEPTH_FLOAT_EXT                       = 0x2040;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_display_color_table (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_extensions_string (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_framebuffer_sRGB
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_FRAMEBUFFER_SRGB_CAPABLE_EXT          = 0x20A9;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_make_current_read
        ///////////////////////////////////////////////////////////////////////
        public const uint ERROR_INVALID_PIXEL_TYPE_EXT              = 0x2043;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_multisample
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_SAMPLE_BUFFERS_EXT                    = 0x2041;
        public const uint WGL_SAMPLES_EXT                           = 0x2042;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_pbuffer
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_DRAW_TO_PBUFFER_EXT                   = 0x202D;
        public const uint WGL_MAX_PBUFFER_PIXELS_EXT                = 0x202E;
        public const uint WGL_MAX_PBUFFER_WIDTH_EXT                 = 0x202F;
        public const uint WGL_MAX_PBUFFER_HEIGHT_EXT                = 0x2030;
        public const uint WGL_OPTIMAL_PBUFFER_WIDTH_EXT             = 0x2031;
        public const uint WGL_OPTIMAL_PBUFFER_HEIGHT_EXT            = 0x2032;
        public const uint WGL_PBUFFER_LARGEST_EXT                   = 0x2033;
        public const uint WGL_PBUFFER_WIDTH_EXT                     = 0x2034;
        public const uint WGL_PBUFFER_HEIGHT_EXT                    = 0x2035;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_pixel_format
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_NUMBER_PIXEL_FORMATS_EXT              = 0x2000;
        public const uint WGL_DRAW_TO_WINDOW_EXT                    = 0x2001;
        public const uint WGL_DRAW_TO_BITMAP_EXT                    = 0x2002;
        public const uint WGL_ACCELERATION_EXT                      = 0x2003;
        public const uint WGL_NEED_PALETTE_EXT                      = 0x2004;
        public const uint WGL_NEED_SYSTEM_PALETTE_EXT               = 0x2005;
        public const uint WGL_SWAP_LAYER_BUFFERS_EXT                = 0x2006;
        public const uint WGL_SWAP_METHOD_EXT                       = 0x2007;
        public const uint WGL_NUMBER_OVERLAYS_EXT                   = 0x2008;
        public const uint WGL_NUMBER_UNDERLAYS_EXT                  = 0x2009;
        public const uint WGL_TRANSPARENT_EXT                       = 0x200A;
        public const uint WGL_TRANSPARENT_VALUE_EXT                 = 0x200B;
        public const uint WGL_SHARE_DEPTH_EXT                       = 0x200C;
        public const uint WGL_SHARE_STENCIL_EXT                     = 0x200D;
        public const uint WGL_SHARE_ACCUM_EXT                       = 0x200E;
        public const uint WGL_SUPPORT_GDI_EXT                       = 0x200F;
        public const uint WGL_SUPPORT_OPENGL_EXT                    = 0x2010;
        public const uint WGL_DOUBLE_BUFFER_EXT                     = 0x2011;
        public const uint WGL_STEREO_EXT                            = 0x2012;
        public const uint WGL_PIXEL_TYPE_EXT                        = 0x2013;
        public const uint WGL_COLOR_BITS_EXT                        = 0x2014;
        public const uint WGL_RED_BITS_EXT                          = 0x2015;
        public const uint WGL_RED_SHIFT_EXT                         = 0x2016;
        public const uint WGL_GREEN_BITS_EXT                        = 0x2017;
        public const uint WGL_GREEN_SHIFT_EXT                       = 0x2018;
        public const uint WGL_BLUE_BITS_EXT                         = 0x2019;
        public const uint WGL_BLUE_SHIFT_EXT                        = 0x201A;
        public const uint WGL_ALPHA_BITS_EXT                        = 0x201B;
        public const uint WGL_ALPHA_SHIFT_EXT                       = 0x201C;
        public const uint WGL_ACCUM_BITS_EXT                        = 0x201D;
        public const uint WGL_ACCUM_RED_BITS_EXT                    = 0x201E;
        public const uint WGL_ACCUM_GREEN_BITS_EXT                  = 0x201F;
        public const uint WGL_ACCUM_BLUE_BITS_EXT                   = 0x2020;
        public const uint WGL_ACCUM_ALPHA_BITS_EXT                  = 0x2021;
        public const uint WGL_DEPTH_BITS_EXT                        = 0x2022;
        public const uint WGL_STENCIL_BITS_EXT                      = 0x2023;
        public const uint WGL_AUX_BUFFERS_EXT                       = 0x2024;
        public const uint WGL_NO_ACCELERATION_EXT                   = 0x2025;
        public const uint WGL_GENERIC_ACCELERATION_EXT              = 0x2026;
        public const uint WGL_FULL_ACCELERATION_EXT                 = 0x2027;
        public const uint WGL_SWAP_EXCHANGE_EXT                     = 0x2028;
        public const uint WGL_SWAP_COPY_EXT                         = 0x2029;
        public const uint WGL_SWAP_UNDEFINED_EXT                    = 0x202A;
        public const uint WGL_TYPE_RGBA_EXT                         = 0x202B;
        public const uint WGL_TYPE_COLORINDEX_EXT                   = 0x202C;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_pixel_format_packed_float
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_TYPE_RGBA_UNSIGNED_FLOAT_EXT          = 0x20A8;

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_swap_control (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_EXT_swap_control_tear (no constants)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_I3D_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_digital_video_control
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D    = 0x2050;
        public const uint WGL_DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D          = 0x2051;
        public const uint WGL_DIGITAL_VIDEO_CURSOR_INCLUDED_I3D             = 0x2052;
        public const uint WGL_DIGITAL_VIDEO_GAMMA_CORRECTED_I3D             = 0x2053;

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_gamma
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_GAMMA_TABLE_SIZE_I3D                  = 0x204E;
        public const uint WGL_GAMMA_EXCLUDE_DESKTOP_I3D             = 0x204F;

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_genlock
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_GENLOCK_SOURCE_MULTIVIEW_I3D          = 0x2044;
        public const uint WGL_GENLOCK_SOURCE_EXTERNAL_SYNC_I3D      = 0x2045;
        public const uint WGL_GENLOCK_SOURCE_EXTERNAL_FIELD_I3D     = 0x2046;
        public const uint WGL_GENLOCK_SOURCE_EXTERNAL_TTL_I3D       = 0x2047;
        public const uint WGL_GENLOCK_SOURCE_DIGITAL_SYNC_I3D       = 0x2048;
        public const uint WGL_GENLOCK_SOURCE_DIGITAL_FIELD_I3D      = 0x2049;
        public const uint WGL_GENLOCK_SOURCE_EDGE_FALLING_I3D       = 0x204A;
        public const uint WGL_GENLOCK_SOURCE_EDGE_RISING_I3D        = 0x204B;
        public const uint WGL_GENLOCK_SOURCE_EDGE_BOTH_I3D          = 0x204C;

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_image_buffer
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_IMAGE_BUFFER_MIN_ACCESS_I3D           = 0x00000001;
        public const uint WGL_IMAGE_BUFFER_LOCK_I3D                 = 0x00000002;

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_swap_frame_lock (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_I3D_swap_frame_usage (no constants)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_NV_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_copy_image (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_delay_before_swap (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_DX_interop
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_ACCESS_READ_ONLY_NV                   = 0x00000000;
        public const uint WGL_ACCESS_READ_WRITE_NV                  = 0x00000001;
        public const uint WGL_ACCESS_WRITE_DISCARD_NV               = 0x00000002;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_DX_interop2 (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_float_buffer
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_FLOAT_COMPONENTS_NV                       = 0x20B0;
        public const uint WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV      = 0x20B1;
        public const uint WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV     = 0x20B2;
        public const uint WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV    = 0x20B3;
        public const uint WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV   = 0x20B4;
        public const uint WGL_TEXTURE_FLOAT_R_NV                        = 0x20B5;
        public const uint WGL_TEXTURE_FLOAT_RG_NV                       = 0x20B6;
        public const uint WGL_TEXTURE_FLOAT_RGB_NV                      = 0x20B7;
        public const uint WGL_TEXTURE_FLOAT_RGBA_NV                     = 0x20B8;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_gpu_affinity
        ///////////////////////////////////////////////////////////////////////
        public const uint ERROR_INCOMPATIBLE_AFFINITY_MASKS_NV          = 0x20D0;
        public const uint ERROR_MISSING_AFFINITY_MASK_NV                = 0x20D1;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_multisample_coverage
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_COVERAGE_SAMPLES_NV                       = 0x2042;
        public const uint WGL_COLOR_SAMPLES_NV                          = 0x20B9;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_present_video
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_NUM_VIDEO_SLOTS_NV                        = 0x20F0;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_render_depth_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_BIND_TO_TEXTURE_DEPTH_NV                  = 0x20A3;
        public const uint WGL_BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV        = 0x20A4;
        public const uint WGL_DEPTH_TEXTURE_FORMAT_NV                   = 0x20A5;
        public const uint WGL_TEXTURE_DEPTH_COMPONENT_NV                = 0x20A6;
        public const uint WGL_DEPTH_COMPONENT_NV                        = 0x20A7;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_render_texture_rectangle
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_BIND_TO_TEXTURE_RECTANGLE_RGB_NV          = 0x20A0;
        public const uint WGL_BIND_TO_TEXTURE_RECTANGLE_RGBA_NV         = 0x20A1;
        public const uint WGL_TEXTURE_RECTANGLE_NV                      = 0x20A2;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_swap_group (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_vertex_array_range (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_video_capture
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_UNIQUE_ID_NV                              = 0x20CE;
        public const uint WGL_NUM_VIDEO_CAPTURE_SLOTS_NV                = 0x20CF;

        ///////////////////////////////////////////////////////////////////////
        // WGL_NV_video_output
        ///////////////////////////////////////////////////////////////////////
        public const uint WGL_BIND_TO_VIDEO_RGB_NV                      = 0x20C0;
        public const uint WGL_BIND_TO_VIDEO_RGBA_NV                     = 0x20C1;
        public const uint WGL_BIND_TO_VIDEO_RGB_AND_DEPTH_NV            = 0x20C2;
        public const uint WGL_VIDEO_OUT_COLOR_NV                        = 0x20C3;
        public const uint WGL_VIDEO_OUT_ALPHA_NV                        = 0x20C4;
        public const uint WGL_VIDEO_OUT_DEPTH_NV                        = 0x20C5;
        public const uint WGL_VIDEO_OUT_COLOR_AND_ALPHA_NV              = 0x20C6;
        public const uint WGL_VIDEO_OUT_COLOR_AND_DEPTH_NV              = 0x20C7;
        public const uint WGL_VIDEO_OUT_FRAME                           = 0x20C8;
        public const uint WGL_VIDEO_OUT_FIELD_1                         = 0x20C9;
        public const uint WGL_VIDEO_OUT_FIELD_2                         = 0x20CA;
        public const uint WGL_VIDEO_OUT_STACKED_FIELDS_1_2              = 0x20CB;
        public const uint WGL_VIDEO_OUT_STACKED_FIELDS_2_1              = 0x20CC;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // WGL_OML_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region WGL_OML_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // WGL_OML_sync_control (no constants)
        ///////////////////////////////////////////////////////////////////////

        #endregion
    }
}