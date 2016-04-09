using System;

namespace OpenGLDotNet
{
    public static partial class GL
    {
        ///////////////////////////////////////////////////////////////////////
        // GL_3DFX_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_3DFX_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_3DFX_multisample
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MULTISAMPLE_3DFX               = 0x86B2;
        public const uint GL_SAMPLE_BUFFERS_3DFX            = 0x86B3;
        public const uint GL_SAMPLES_3DFX                   = 0x86B4;
        public const uint GL_MULTISAMPLE_BIT_3DFX           = 0x20000000;

        ///////////////////////////////////////////////////////////////////////
        // GL_3DFX_tbuffer (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_3DFX_texture_compression_FXT1
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COMPRESSED_RGB_FXT1_3DFX       = 0x86B0;
        public const uint GL_COMPRESSED_RGBA_FXT1_3DFX      = 0x86B1;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_AMD_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_blend_minmax_factor
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FACTOR_MIN_AMD                 = 0x901C;
        public const uint GL_FACTOR_MAX_AMD                 = 0x901D;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_conservative_depth (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_debug_output
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_DEBUG_LOGGED_MESSAGES_AMD          = 0x9144;
        public const uint GL_DEBUG_LOGGED_MESSAGES_AMD              = 0x9145;
        public const uint GL_DEBUG_SEVERITY_HIGH_AMD                = 0x9146;
        public const uint GL_DEBUG_SEVERITY_MEDIUM_AMD              = 0x9147;
        public const uint GL_DEBUG_SEVERITY_LOW_AMD                 = 0x9148;
        public const uint GL_DEBUG_CATEGORY_API_ERROR_AMD           = 0x9149;
        public const uint GL_DEBUG_CATEGORY_WINDOW_SYSTEM_AMD       = 0x914A;
        public const uint GL_DEBUG_CATEGORY_DEPRECATION_AMD         = 0x914B;
        public const uint GL_DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD  = 0x914C;
        public const uint GL_DEBUG_CATEGORY_PERFORMANCE_AMD         = 0x914D;
        public const uint GL_DEBUG_CATEGORY_SHADER_COMPILER_AMD     = 0x914E;
        public const uint GL_DEBUG_CATEGORY_APPLICATION_AMD         = 0x914F;
        public const uint GL_DEBUG_CATEGORY_OTHER_AMD               = 0x9150;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_depth_clamp_separate
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DEPTH_CLAMP_NEAR_AMD           = 0x901E;
        public const uint GL_DEPTH_CLAMP_FAR_AMD            = 0x901F;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_draw_buffers_blend (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_multi_draw_indirect (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_name_gen_delete
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DATA_BUFFER_AMD                = 0x9151;
        public const uint GL_PERFORMANCE_MONITOR_AMD        = 0x9152;
        public const uint GL_QUERY_OBJECT_AMD               = 0x9153;
        public const uint GL_VERTEX_ARRAY_OBJECT_AMD        = 0x9154;
        public const uint GL_SAMPLER_OBJECT_AMD             = 0x9155;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_performance_monitor
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COUNTER_TYPE_AMD               = 0x8BC0;
        public const uint GL_COUNTER_RANGE_AMD              = 0x8BC1;
        public const uint GL_UNSIGNED_INT64_AMD             = 0x8BC2;
        public const uint GL_PERCENTAGE_AMD                 = 0x8BC3;
        public const uint GL_PERFMON_RESULT_AVAILABLE_AMD   = 0x8BC4;
        public const uint GL_PERFMON_RESULT_SIZE_AMD        = 0x8BC5;
        public const uint GL_PERFMON_RESULT_AMD             = 0x8BC6;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_pinned_memory
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_EXTERNAL_VIRTUAL_MEMORY_BUFFER_AMD = 0x9160;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_query_buffer_object
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_QUERY_BUFFER_AMD               = 0x9192;
        public const uint GL_QUERY_BUFFER_BINDING_AMD       = 0x9193;
        public const uint GL_QUERY_RESULT_NO_WAIT_AMD       = 0x9194;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_sample_positions
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SUBSAMPLE_DISTANCE_AMD         = 0x883F;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_seamless_cubemap_per_texture
        ///////////////////////////////////////////////////////////////////////
        /* reuse GL_TEXTURE_CUBE_MAP_SEAMLESS */

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_shader_stencil_export (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_stencil_operation_extended
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SET_AMD                        = 0x874A;
        public const uint GL_REPLACE_VALUE_AMD              = 0x874B;
        public const uint GL_STENCIL_OP_VALUE_AMD           = 0x874C;
        public const uint GL_STENCIL_BACK_OP_VALUE_AMD      = 0x874D;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_texture_texture4 (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_transform_feedback3_lines_triangles (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_vertex_shader_layer (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_vertex_shader_tessellator
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SAMPLER_BUFFER_AMD                 = 0x9001;
        public const uint GL_INT_SAMPLER_BUFFER_AMD             = 0x9002;
        public const uint GL_UNSIGNED_INT_SAMPLER_BUFFER_AMD    = 0x9003;
        public const uint GL_TESSELLATION_MODE_AMD              = 0x9004;
        public const uint GL_TESSELLATION_FACTOR_AMD            = 0x9005;
        public const uint GL_DISCRETE_AMD                       = 0x9006;
        public const uint GL_CONTINUOUS_AMD                     = 0x9007;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_vertex_shader_viewport_index (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_sparse_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VIRTUAL_PAGE_SIZE_X_AMD            = 0x9195;
        public const uint GL_VIRTUAL_PAGE_SIZE_Y_AMD            = 0x9196;
        public const uint GL_VIRTUAL_PAGE_SIZE_Z_AMD            = 0x9197;
        public const uint GL_MAX_SPARSE_TEXTURE_SIZE_AMD        = 0x9198;
        public const uint GL_MAX_SPARSE_3D_TEXTURE_SIZE_AMD     = 0x9199;
        public const uint GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS    = 0x919A;
        public const uint GL_MIN_SPARSE_LEVEL_AMD               = 0x919B;
        public const uint GL_MIN_LOD_WARNING_AMD                = 0x919C;
        public const uint GL_TEXTURE_STORAGE_SPARSE_BIT_AMD     = 0x00000001;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_shader_atomic_counter_ops (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_shader_trinary_minmax (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_interleaved_elements
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_ELEMENT_SWIZZLE_AMD         = 0x91A4;
        public const uint GL_VERTEX_ID_SWIZZLE_AMD              = 0x91A5;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMD_occlusion_query_event
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_OCCLUSION_QUERY_EVENT_MASK_AMD         = 0x874F;
        public const uint GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD         = 0x00000001;
        public const uint GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD         = 0x00000002;
        public const uint GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD       = 0x00000004;
        public const uint GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD  = 0x00000008;
        public const uint GL_QUERY_ALL_EVENT_BITS_AMD               = 0xFFFFFFFF;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_AMDX_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_AMDX_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_AMDX_vertex_shader_tessellator
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SAMPLER_BUFFER_AMDX                    = 0x9001;
        public const uint GL_INT_SAMPLER_BUFFER_AMDX                = 0x9002;
        public const uint GL_UNSIGNED_INT_SAMPLER_BUFFER_AMDX       = 0x9003;
        public const uint GL_TESSELLATION_MODE_AMDX                 = 0x9004;
        public const uint GL_TESSELLATION_FACTOR_AMDX               = 0x9005;
        public const uint GL_DISCRETE_AMDX                          = 0x9006;
        public const uint GL_CONTINUOUS_AMDX                        = 0x9007;

        ///////////////////////////////////////////////////////////////////////
        // GL_AMDX_debug_output
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_DEBUG_LOGGED_MESSAGES_AMDX         = 0x9144;
        public const uint GL_DEBUG_LOGGED_MESSAGES_AMDX             = 0x9145;
        public const uint GL_DEBUG_SEVERITY_HIGH_AMDX               = 0x9146;
        public const uint GL_DEBUG_SEVERITY_MEDIUM_AMDX             = 0x9147;
        public const uint GL_DEBUG_SEVERITY_LOW_AMDX                = 0x9148;
        public const uint GL_DEBUG_CATEGORY_API_ERROR_AMDX          = 0x9149;
        public const uint GL_DEBUG_CATEGORY_WINDOW_SYSTEM_AMDX      = 0x914A;
        public const uint GL_DEBUG_CATEGORY_DEPRECATION_AMDX        = 0x914B;
        public const uint GL_DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMDX = 0x914C;
        public const uint GL_DEBUG_CATEGORY_PERFORMANCE_AMDX        = 0x914D;
        public const uint GL_DEBUG_CATEGORY_SHADER_COMPILER_AMDX    = 0x914E;
        public const uint GL_DEBUG_CATEGORY_APPLICATION_AMDX        = 0x914F;
        public const uint GL_DEBUG_CATEGORY_OTHER_AMDX              = 0x9150;
        
        #endregion
        
        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_APPLE_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_aux_depth_stencil
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_AUX_DEPTH_STENCIL_APPLE        = 0x8A14;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_client_storage
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_UNPACK_CLIENT_STORAGE_APPLE    = 0x85B2;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_element_array
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_ELEMENT_ARRAY_APPLE            = 0x8A0C;
        public const uint GL_ELEMENT_ARRAY_TYPE_APPLE       = 0x8A0D;
        public const uint GL_ELEMENT_ARRAY_POINTER_APPLE    = 0x8A0E;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_fence
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DRAW_PIXELS_APPLE              = 0x8A0A;
        public const uint GL_FENCE_APPLE                    = 0x8A0B;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_float_pixels
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_HALF_APPLE                     = 0x140B;
        public const uint GL_RGBA_FLOAT32_APPLE             = 0x8814;
        public const uint GL_RGB_FLOAT32_APPLE              = 0x8815;
        public const uint GL_ALPHA_FLOAT32_APPLE            = 0x8816;
        public const uint GL_INTENSITY_FLOAT32_APPLE        = 0x8817;
        public const uint GL_LUMINANCE_FLOAT32_APPLE        = 0x8818;
        public const uint GL_LUMINANCE_ALPHA_FLOAT32_APPLE  = 0x8819;
        public const uint GL_RGBA_FLOAT16_APPLE             = 0x881A;
        public const uint GL_RGB_FLOAT16_APPLE              = 0x881B;
        public const uint GL_ALPHA_FLOAT16_APPLE            = 0x881C;
        public const uint GL_INTENSITY_FLOAT16_APPLE        = 0x881D;
        public const uint GL_LUMINANCE_FLOAT16_APPLE        = 0x881E;
        public const uint GL_LUMINANCE_ALPHA_FLOAT16_APPLE  = 0x881F;
        public const uint GL_COLOR_FLOAT_APPLE              = 0x8A0F;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_flush_buffer_range
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_BUFFER_SERIALIZED_MODIFY_APPLE = 0x8A12;
        public const uint GL_BUFFER_FLUSHING_UNMAP_APPLE    = 0x8A13;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_object_purgeable
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_BUFFER_OBJECT_APPLE            = 0x85B3;
        public const uint GL_RELEASED_APPLE                 = 0x8A19;
        public const uint GL_VOLATILE_APPLE                 = 0x8A1A;
        public const uint GL_RETAINED_APPLE                 = 0x8A1B;
        public const uint GL_UNDEFINED_APPLE                = 0x8A1C;
        public const uint GL_PURGEABLE_APPLE                = 0x8A1D;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_rgb_422
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_RGB_422_APPLE                  = 0x8A1F;
        /* reuse GL_UNSIGNED_SHORT_8_8_APPLE */
        /* reuse GL_UNSIGNED_SHORT_8_8_REV_APPLE */

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_row_bytes
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PACK_ROW_BYTES_APPLE           = 0x8A15;
        public const uint GL_UNPACK_ROW_BYTES_APPLE         = 0x8A16;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_specular_vector
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_LIGHT_MODEL_SPECULAR_VECTOR_APPLE = 0x85B0;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_texture_range
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_RANGE_LENGTH_APPLE     = 0x85B7;
        public const uint GL_TEXTURE_RANGE_POINTER_APPLE    = 0x85B8;
        public const uint GL_TEXTURE_STORAGE_HINT_APPLE     = 0x85BC;
        public const uint GL_STORAGE_PRIVATE_APPLE          = 0x85BD;
        /* reuse GL_STORAGE_CACHED_APPLE */
        /* reuse GL_STORAGE_SHARED_APPLE */

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_transform_hint
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TRANSFORM_HINT_APPLE           = 0x85B1;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_vertex_array_object
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_ARRAY_BINDING_APPLE     = 0x85B5;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_vertex_array_range
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_ARRAY_RANGE_APPLE           = 0x851D;
        public const uint GL_VERTEX_ARRAY_RANGE_LENGTH_APPLE    = 0x851E;
        public const uint GL_VERTEX_ARRAY_STORAGE_HINT_APPLE    = 0x851F;
        public const uint GL_VERTEX_ARRAY_RANGE_POINTER_APPLE   = 0x8521;
        public const uint GL_STORAGE_CLIENT_APPLE               = 0x85B4;
        public const uint GL_STORAGE_CACHED_APPLE               = 0x85BE;
        public const uint GL_STORAGE_SHARED_APPLE               = 0x85BF;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_vertex_program_evaluators
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_ATTRIB_MAP1_APPLE           = 0x8A00;
        public const uint GL_VERTEX_ATTRIB_MAP2_APPLE           = 0x8A01;
        public const uint GL_VERTEX_ATTRIB_MAP1_SIZE_APPLE      = 0x8A02;
        public const uint GL_VERTEX_ATTRIB_MAP1_COEFF_APPLE     = 0x8A03;
        public const uint GL_VERTEX_ATTRIB_MAP1_ORDER_APPLE     = 0x8A04;
        public const uint GL_VERTEX_ATTRIB_MAP1_DOMAIN_APPLE    = 0x8A05;
        public const uint GL_VERTEX_ATTRIB_MAP2_SIZE_APPLE      = 0x8A06;
        public const uint GL_VERTEX_ATTRIB_MAP2_COEFF_APPLE     = 0x8A07;
        public const uint GL_VERTEX_ATTRIB_MAP2_ORDER_APPLE     = 0x8A08;
        public const uint GL_VERTEX_ATTRIB_MAP2_DOMAIN_APPLE    = 0x8A09;

        ///////////////////////////////////////////////////////////////////////
        // GL_APPLE_ycbcr_422
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_YCBCR_422_APPLE                    = 0x85B9;
        public const uint GL_UNSIGNED_SHORT_8_8_APPLE           = 0x85BA;
        public const uint GL_UNSIGNED_SHORT_8_8_REV_APPLE       = 0x85BB;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_ARB_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_arrays_of_arrays (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_base_instance (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_blend_func_extended
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3
        public const uint GL_SRC1_COLOR                     = 0x88F9;
        reuse GL_SRC1_ALPHA
        public const uint GL_ONE_MINUS_SRC1_COLOR           = 0x88FA;
        public const uint GL_ONE_MINUS_SRC1_ALPHA           = 0x88FB;
        public const uint GL_MAX_DUAL_SOURCE_DRAW_BUFFERS   = 0x88FC;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_cl_event
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SYNC_CL_EVENT_ARB              = 0x8240;
        public const uint GL_SYNC_CL_EVENT_COMPLETE_ARB     = 0x8241;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_clear_buffer_object (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_color_buffer_float
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_RGBA_FLOAT_MODE_ARB = 0x8820;
        public const uint GL_CLAMP_VERTEX_COLOR_ARB = 0x891A;
        public const uint GL_CLAMP_FRAGMENT_COLOR_ARB = 0x891B;
        public const uint GL_CLAMP_READ_COLOR_ARB = 0x891C;
        public const uint GL_FIXED_ONLY_ARB = 0x891D;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_compatibility
        ///////////////////////////////////////////////////////////////////////
        /* ARB_compatibility just defines tokens from core 3.0 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_compressed_texture_pixel_storage
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2
        public const uint GL_UNPACK_COMPRESSED_BLOCK_WIDTH  = 0x9127;
        public const uint GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
        public const uint GL_UNPACK_COMPRESSED_BLOCK_DEPTH  = 0x9129;
        public const uint GL_UNPACK_COMPRESSED_BLOCK_SIZE   = 0x912A;
        public const uint GL_PACK_COMPRESSED_BLOCK_WIDTH    = 0x912B;
        public const uint GL_PACK_COMPRESSED_BLOCK_HEIGHT   = 0x912C;
        public const uint GL_PACK_COMPRESSED_BLOCK_DEPTH    = 0x912D;
        public const uint GL_PACK_COMPRESSED_BLOCK_SIZE     = 0x912E;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_compute_shader
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3
        public const uint GL_COMPUTE_SHADER                 = 0x91B9;
        public const uint GL_MAX_COMPUTE_UNIFORM_BLOCKS     = 0x91BB;
        public const uint GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
        public const uint GL_MAX_COMPUTE_IMAGE_UNIFORMS     = 0x91BD;
        public const uint GL_MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
        public const uint GL_MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
        public const uint GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
        public const uint GL_MAX_COMPUTE_ATOMIC_COUNTERS    = 0x8265;
        public const uint GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
        public const uint GL_MAX_COMPUTE_LOCAL_INVOCATIONS  = 0x90EB;
        public const uint GL_MAX_COMPUTE_WORK_GROUP_COUNT   = 0x91BE;
        public const uint GL_MAX_COMPUTE_WORK_GROUP_SIZE    = 0x91BF;
        public const uint GL_COMPUTE_LOCAL_WORK_SIZE        = 0x8267;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
        public const uint GL_DISPATCH_INDIRECT_BUFFER       = 0x90EE;
        public const uint GL_DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
        public const uint GL_COMPUTE_SHADER_BIT             = 0x00000020;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_conservative_depth (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_copy_buffer
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COPY_READ_BUFFER_BINDING = 0x8F36;
        public const uint GL_COPY_WRITE_BUFFER_BINDING = 0x8F37;
        /* Defined in OpenGL 3.1
        public const uint GL_COPY_READ_BUFFER               = GL_COPY_READ_BUFFER_BINDING;
        public const uint GL_COPY_WRITE_BUFFER              = GL_COPY_WRITE_BUFFER_BINDING;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_copy_image (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_imaging
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 1.2: GL_ARB_imaging
        public const uint GL_CONSTANT_COLOR                 = 0x8001;
        public const uint GL_ONE_MINUS_CONSTANT_COLOR       = 0x8002;
        public const uint GL_CONSTANT_ALPHA                 = 0x8003;
        public const uint GL_ONE_MINUS_CONSTANT_ALPHA       = 0x8004;
        public const uint GL_BLEND_COLOR                    = 0x8005;
        public const uint GL_FUNC_ADD                       = 0x8006;
        public const uint GL_MIN                            = 0x8007;
        public const uint GL_MAX                            = 0x8008;
        public const uint GL_BLEND_EQUATION                 = 0x8009;
        public const uint GL_FUNC_SUBTRACT                  = 0x800A;
        public const uint GL_FUNC_REVERSE_SUBTRACT          = 0x800B;
        public const uint GL_CONVOLUTION_1D                 = 0x8010;
        public const uint GL_CONVOLUTION_2D                 = 0x8011;
        public const uint GL_SEPARABLE_2D                   = 0x8012;
        public const uint GL_CONVOLUTION_BORDER_MODE        = 0x8013;
        public const uint GL_CONVOLUTION_FILTER_SCALE       = 0x8014;
        public const uint GL_CONVOLUTION_FILTER_BIAS        = 0x8015;
        public const uint GL_REDUCE                         = 0x8016;
        public const uint GL_CONVOLUTION_FORMAT             = 0x8017;
        public const uint GL_CONVOLUTION_WIDTH              = 0x8018;
        public const uint GL_CONVOLUTION_HEIGHT             = 0x8019;
        public const uint GL_MAX_CONVOLUTION_WIDTH          = 0x801A;
        public const uint GL_MAX_CONVOLUTION_HEIGHT         = 0x801B;
        public const uint GL_POST_CONVOLUTION_RED_SCALE     = 0x801C;
        public const uint GL_POST_CONVOLUTION_GREEN_SCALE   = 0x801D;
        public const uint GL_POST_CONVOLUTION_BLUE_SCALE    = 0x801E;
        public const uint GL_POST_CONVOLUTION_ALPHA_SCALE   = 0x801F;
        public const uint GL_POST_CONVOLUTION_RED_BIAS      = 0x8020;
        public const uint GL_POST_CONVOLUTION_GREEN_BIAS    = 0x8021;
        public const uint GL_POST_CONVOLUTION_BLUE_BIAS     = 0x8022;
        public const uint GL_POST_CONVOLUTION_ALPHA_BIAS    = 0x8023;
        public const uint GL_HISTOGRAM                      = 0x8024;
        public const uint GL_PROXY_HISTOGRAM                = 0x8025;
        public const uint GL_HISTOGRAM_WIDTH                = 0x8026;
        public const uint GL_HISTOGRAM_FORMAT               = 0x8027;
        public const uint GL_HISTOGRAM_RED_SIZE             = 0x8028;
        public const uint GL_HISTOGRAM_GREEN_SIZE           = 0x8029;
        public const uint GL_HISTOGRAM_BLUE_SIZE            = 0x802A;
        public const uint GL_HISTOGRAM_ALPHA_SIZE           = 0x802B;
        public const uint GL_HISTOGRAM_LUMINANCE_SIZE       = 0x802C;
        public const uint GL_HISTOGRAM_SINK                 = 0x802D;
        public const uint GL_MINMAX                         = 0x802E;
        public const uint GL_MINMAX_FORMAT                  = 0x802F;
        public const uint GL_MINMAX_SINK                    = 0x8030;
        public const uint GL_TABLE_TOO_LARGE                = 0x8031;
        public const uint GL_COLOR_MATRIX                   = 0x80B1;
        public const uint GL_COLOR_MATRIX_STACK_DEPTH       = 0x80B2;
        public const uint GL_MAX_COLOR_MATRIX_STACK_DEPTH   = 0x80B3;
        public const uint GL_POST_COLOR_MATRIX_RED_SCALE    = 0x80B4;
        public const uint GL_POST_COLOR_MATRIX_GREEN_SCALE  = 0x80B5;
        public const uint GL_POST_COLOR_MATRIX_BLUE_SCALE   = 0x80B6;
        public const uint GL_POST_COLOR_MATRIX_ALPHA_SCALE  = 0x80B7;
        public const uint GL_POST_COLOR_MATRIX_RED_BIAS     = 0x80B8;
        public const uint GL_POST_COLOR_MATRIX_GREEN_BIAS   = 0x80B9;
        public const uint GL_POST_COLOR_MATRIX_BLUE_BIAS    = 0x80BA;
        public const uint GL_POST_COLOR_MATRIX_ALPHA_BIAS   = 0x80BB;
        public const uint GL_COLOR_TABLE                    = 0x80D0;
        public const uint GL_POST_CONVOLUTION_COLOR_TABLE   = 0x80D1;
        public const uint GL_POST_COLOR_MATRIX_COLOR_TABLE  = 0x80D2;
        public const uint GL_PROXY_COLOR_TABLE              = 0x80D3;
        public const uint GL_PROXY_POST_CONVOLUTION_COLOR_TABLE   = 0x80D4;
        public const uint GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE  = 0x80D5;
        public const uint GL_COLOR_TABLE_SCALE              = 0x80D6;
        public const uint GL_COLOR_TABLE_BIAS               = 0x80D7;
        public const uint GL_COLOR_TABLE_FORMAT             = 0x80D8;
        public const uint GL_COLOR_TABLE_WIDTH              = 0x80D9;
        public const uint GL_COLOR_TABLE_RED_SIZE           = 0x80DA;
        public const uint GL_COLOR_TABLE_GREEN_SIZE         = 0x80DB;
        public const uint GL_COLOR_TABLE_BLUE_SIZE          = 0x80DC;
        public const uint GL_COLOR_TABLE_ALPHA_SIZE         = 0x80DD;
        public const uint GL_COLOR_TABLE_LUMINANCE_SIZE     = 0x80DE;
        public const uint GL_COLOR_TABLE_INTENSITY_SIZE     = 0x80DF;
        public const uint GL_CONSTANT_BORDER                = 0x8151;
        public const uint GL_REPLICATE_BORDER               = 0x8153;
        public const uint GL_CONVOLUTION_BORDER_COLOR       = 0x8154;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_multitexture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE0_ARB = 0x84C0;
        public const uint GL_TEXTURE1_ARB = 0x84C1;
        public const uint GL_TEXTURE2_ARB = 0x84C2;
        public const uint GL_TEXTURE3_ARB = 0x84C3;
        public const uint GL_TEXTURE4_ARB = 0x84C4;
        public const uint GL_TEXTURE5_ARB = 0x84C5;
        public const uint GL_TEXTURE6_ARB = 0x84C6;
        public const uint GL_TEXTURE7_ARB = 0x84C7;
        public const uint GL_TEXTURE8_ARB = 0x84C8;
        public const uint GL_TEXTURE9_ARB = 0x84C9;
        public const uint GL_TEXTURE10_ARB = 0x84CA;
        public const uint GL_TEXTURE11_ARB = 0x84CB;
        public const uint GL_TEXTURE12_ARB = 0x84CC;
        public const uint GL_TEXTURE13_ARB = 0x84CD;
        public const uint GL_TEXTURE14_ARB = 0x84CE;
        public const uint GL_TEXTURE15_ARB = 0x84CF;
        public const uint GL_TEXTURE16_ARB = 0x84D0;
        public const uint GL_TEXTURE17_ARB = 0x84D1;
        public const uint GL_TEXTURE18_ARB = 0x84D2;
        public const uint GL_TEXTURE19_ARB = 0x84D3;
        public const uint GL_TEXTURE20_ARB = 0x84D4;
        public const uint GL_TEXTURE21_ARB = 0x84D5;
        public const uint GL_TEXTURE22_ARB = 0x84D6;
        public const uint GL_TEXTURE23_ARB = 0x84D7;
        public const uint GL_TEXTURE24_ARB = 0x84D8;
        public const uint GL_TEXTURE25_ARB = 0x84D9;
        public const uint GL_TEXTURE26_ARB = 0x84DA;
        public const uint GL_TEXTURE27_ARB = 0x84DB;
        public const uint GL_TEXTURE28_ARB = 0x84DC;
        public const uint GL_TEXTURE29_ARB = 0x84DD;
        public const uint GL_TEXTURE30_ARB = 0x84DE;
        public const uint GL_TEXTURE31_ARB = 0x84DF;
        public const uint GL_ACTIVE_TEXTURE_ARB = 0x84E0;
        public const uint GL_CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1;
        public const uint GL_MAX_TEXTURE_UNITS_ARB = 0x84E2;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_transpose_matrix
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3;
        public const uint GL_TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4;
        public const uint GL_TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5;
        public const uint GL_TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_multisample
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MULTISAMPLE_ARB = 0x809D;
        public const uint GL_SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E;
        public const uint GL_SAMPLE_ALPHA_TO_ONE_ARB = 0x809F;
        public const uint GL_SAMPLE_COVERAGE_ARB = 0x80A0;
        public const uint GL_SAMPLE_BUFFERS_ARB = 0x80A8;
        public const uint GL_SAMPLES_ARB = 0x80A9;
        public const uint GL_SAMPLE_COVERAGE_VALUE_ARB = 0x80AA;
        public const uint GL_SAMPLE_COVERAGE_INVERT_ARB = 0x80AB;
        public const uint GL_MULTISAMPLE_BIT_ARB = 0x20000000;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_env_add (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_cube_map
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_NORMAL_MAP_ARB = 0x8511;
        public const uint GL_REFLECTION_MAP_ARB = 0x8512;
        public const uint GL_TEXTURE_CUBE_MAP_ARB = 0x8513;
        public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARB = 0x8514;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB = 0x8515;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = 0x8516;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = 0x8517;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = 0x8518;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = 0x8519;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = 0x851A;
        public const uint GL_PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B;
        public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB = 0x851C;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_compression
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COMPRESSED_ALPHA_ARB = 0x84E9;
        public const uint GL_COMPRESSED_LUMINANCE_ARB = 0x84EA;
        public const uint GL_COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB;
        public const uint GL_COMPRESSED_INTENSITY_ARB = 0x84EC;
        public const uint GL_COMPRESSED_RGB_ARB = 0x84ED;
        public const uint GL_COMPRESSED_RGBA_ARB = 0x84EE;
        public const uint GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF;
        public const uint GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB = 0x86A0;
        public const uint GL_TEXTURE_COMPRESSED_ARB = 0x86A1;
        public const uint GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2;
        public const uint GL_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_border_clamp
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CLAMP_TO_BORDER_ARB = 0x812D;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_point_parameters
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_POINT_SIZE_MIN_ARB = 0x8126;
        public const uint GL_POINT_SIZE_MAX_ARB = 0x8127;
        public const uint GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128;
        public const uint GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_blend
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_VERTEX_UNITS_ARB = 0x86A4;
        public const uint GL_ACTIVE_VERTEX_UNITS_ARB = 0x86A5;
        public const uint GL_WEIGHT_SUM_UNITY_ARB = 0x86A6;
        public const uint GL_VERTEX_BLEND_ARB = 0x86A7;
        public const uint GL_CURRENT_WEIGHT_ARB = 0x86A8;
        public const uint GL_WEIGHT_ARRAY_TYPE_ARB = 0x86A9;
        public const uint GL_WEIGHT_ARRAY_STRIDE_ARB = 0x86AA;
        public const uint GL_WEIGHT_ARRAY_SIZE_ARB = 0x86AB;
        public const uint GL_WEIGHT_ARRAY_POINTER_ARB = 0x86AC;
        public const uint GL_WEIGHT_ARRAY_ARB = 0x86AD;
        public const uint GL_MODELVIEW0_ARB = 0x1700;
        public const uint GL_MODELVIEW1_ARB = 0x850A;
        public const uint GL_MODELVIEW2_ARB = 0x8722;
        public const uint GL_MODELVIEW3_ARB = 0x8723;
        public const uint GL_MODELVIEW4_ARB = 0x8724;
        public const uint GL_MODELVIEW5_ARB = 0x8725;
        public const uint GL_MODELVIEW6_ARB = 0x8726;
        public const uint GL_MODELVIEW7_ARB = 0x8727;
        public const uint GL_MODELVIEW8_ARB = 0x8728;
        public const uint GL_MODELVIEW9_ARB = 0x8729;
        public const uint GL_MODELVIEW10_ARB = 0x872A;
        public const uint GL_MODELVIEW11_ARB = 0x872B;
        public const uint GL_MODELVIEW12_ARB = 0x872C;
        public const uint GL_MODELVIEW13_ARB = 0x872D;
        public const uint GL_MODELVIEW14_ARB = 0x872E;
        public const uint GL_MODELVIEW15_ARB = 0x872F;
        public const uint GL_MODELVIEW16_ARB = 0x8730;
        public const uint GL_MODELVIEW17_ARB = 0x8731;
        public const uint GL_MODELVIEW18_ARB = 0x8732;
        public const uint GL_MODELVIEW19_ARB = 0x8733;
        public const uint GL_MODELVIEW20_ARB = 0x8734;
        public const uint GL_MODELVIEW21_ARB = 0x8735;
        public const uint GL_MODELVIEW22_ARB = 0x8736;
        public const uint GL_MODELVIEW23_ARB = 0x8737;
        public const uint GL_MODELVIEW24_ARB = 0x8738;
        public const uint GL_MODELVIEW25_ARB = 0x8739;
        public const uint GL_MODELVIEW26_ARB = 0x873A;
        public const uint GL_MODELVIEW27_ARB = 0x873B;
        public const uint GL_MODELVIEW28_ARB = 0x873C;
        public const uint GL_MODELVIEW29_ARB = 0x873D;
        public const uint GL_MODELVIEW30_ARB = 0x873E;
        public const uint GL_MODELVIEW31_ARB = 0x873F;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_matrix_palette
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MATRIX_PALETTE_ARB = 0x8840;
        public const uint GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841;
        public const uint GL_MAX_PALETTE_MATRICES_ARB = 0x8842;
        public const uint GL_CURRENT_PALETTE_MATRIX_ARB = 0x8843;
        public const uint GL_MATRIX_INDEX_ARRAY_ARB = 0x8844;
        public const uint GL_CURRENT_MATRIX_INDEX_ARB = 0x8845;
        public const uint GL_MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846;
        public const uint GL_MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847;
        public const uint GL_MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848;
        public const uint GL_MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_env_combine
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COMBINE_ARB = 0x8570;
        public const uint GL_COMBINE_RGB_ARB = 0x8571;
        public const uint GL_COMBINE_ALPHA_ARB = 0x8572;
        public const uint GL_SOURCE0_RGB_ARB = 0x8580;
        public const uint GL_SOURCE1_RGB_ARB = 0x8581;
        public const uint GL_SOURCE2_RGB_ARB = 0x8582;
        public const uint GL_SOURCE0_ALPHA_ARB = 0x8588;
        public const uint GL_SOURCE1_ALPHA_ARB = 0x8589;
        public const uint GL_SOURCE2_ALPHA_ARB = 0x858A;
        public const uint GL_OPERAND0_RGB_ARB = 0x8590;
        public const uint GL_OPERAND1_RGB_ARB = 0x8591;
        public const uint GL_OPERAND2_RGB_ARB = 0x8592;
        public const uint GL_OPERAND0_ALPHA_ARB = 0x8598;
        public const uint GL_OPERAND1_ALPHA_ARB = 0x8599;
        public const uint GL_OPERAND2_ALPHA_ARB = 0x859A;
        public const uint GL_RGB_SCALE_ARB = 0x8573;
        public const uint GL_ADD_SIGNED_ARB = 0x8574;
        public const uint GL_INTERPOLATE_ARB = 0x8575;
        public const uint GL_SUBTRACT_ARB = 0x84E7;
        public const uint GL_CONSTANT_ARB = 0x8576;
        public const uint GL_PRIMARY_COLOR_ARB = 0x8577;
        public const uint GL_PREVIOUS_ARB = 0x8578;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_env_crossbar (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_env_dot3
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DOT3_RGB_ARB = 0x86AE;
        public const uint GL_DOT3_RGBA_ARB = 0x86AF;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_mirrored_repeat
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MIRRORED_REPEAT_ARB = 0x8370;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_depth_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DEPTH_COMPONENT16_ARB = 0x81A5;
        public const uint GL_DEPTH_COMPONENT24_ARB = 0x81A6;
        public const uint GL_DEPTH_COMPONENT32_ARB = 0x81A7;
        public const uint GL_TEXTURE_DEPTH_SIZE_ARB = 0x884A;
        public const uint GL_DEPTH_TEXTURE_MODE_ARB = 0x884B;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shadow
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_COMPARE_MODE_ARB = 0x884C;
        public const uint GL_TEXTURE_COMPARE_FUNC_ARB = 0x884D;
        public const uint GL_COMPARE_R_TO_TEXTURE_ARB = 0x884E;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shadow_ambient
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_COMPARE_FAIL_VALUE_ARB = 0x80BF;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_window_pos (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_program
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COLOR_SUM_ARB = 0x8458;
        public const uint GL_VERTEX_PROGRAM_ARB = 0x8620;
        public const uint GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB = 0x8622;
        public const uint GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB = 0x8623;
        public const uint GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB = 0x8624;
        public const uint GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB = 0x8625;
        public const uint GL_CURRENT_VERTEX_ATTRIB_ARB = 0x8626;
        public const uint GL_PROGRAM_LENGTH_ARB = 0x8627;
        public const uint GL_PROGRAM_STRING_ARB = 0x8628;
        public const uint GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E;
        public const uint GL_MAX_PROGRAM_MATRICES_ARB = 0x862F;
        public const uint GL_CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640;
        public const uint GL_CURRENT_MATRIX_ARB = 0x8641;
        public const uint GL_VERTEX_PROGRAM_POINT_SIZE_ARB = 0x8642;
        public const uint GL_VERTEX_PROGRAM_TWO_SIDE_ARB = 0x8643;
        public const uint GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB = 0x8645;
        public const uint GL_PROGRAM_ERROR_POSITION_ARB = 0x864B;
        public const uint GL_PROGRAM_BINDING_ARB = 0x8677;
        public const uint GL_MAX_VERTEX_ATTRIBS_ARB = 0x8869;
        public const uint GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB = 0x886A;
        public const uint GL_PROGRAM_ERROR_STRING_ARB = 0x8874;
        public const uint GL_PROGRAM_FORMAT_ASCII_ARB = 0x8875;
        public const uint GL_PROGRAM_FORMAT_ARB = 0x8876;
        public const uint GL_PROGRAM_INSTRUCTIONS_ARB = 0x88A0;
        public const uint GL_MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1;
        public const uint GL_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2;
        public const uint GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3;
        public const uint GL_PROGRAM_TEMPORARIES_ARB = 0x88A4;
        public const uint GL_MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5;
        public const uint GL_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6;
        public const uint GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7;
        public const uint GL_PROGRAM_PARAMETERS_ARB = 0x88A8;
        public const uint GL_MAX_PROGRAM_PARAMETERS_ARB = 0x88A9;
        public const uint GL_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA;
        public const uint GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB;
        public const uint GL_PROGRAM_ATTRIBS_ARB = 0x88AC;
        public const uint GL_MAX_PROGRAM_ATTRIBS_ARB = 0x88AD;
        public const uint GL_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE;
        public const uint GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF;
        public const uint GL_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B0;
        public const uint GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB = 0x88B1;
        public const uint GL_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B2;
        public const uint GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB = 0x88B3;
        public const uint GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4;
        public const uint GL_MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5;
        public const uint GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6;
        public const uint GL_TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7;
        public const uint GL_MATRIX0_ARB = 0x88C0;
        public const uint GL_MATRIX1_ARB = 0x88C1;
        public const uint GL_MATRIX2_ARB = 0x88C2;
        public const uint GL_MATRIX3_ARB = 0x88C3;
        public const uint GL_MATRIX4_ARB = 0x88C4;
        public const uint GL_MATRIX5_ARB = 0x88C5;
        public const uint GL_MATRIX6_ARB = 0x88C6;
        public const uint GL_MATRIX7_ARB = 0x88C7;
        public const uint GL_MATRIX8_ARB = 0x88C8;
        public const uint GL_MATRIX9_ARB = 0x88C9;
        public const uint GL_MATRIX10_ARB = 0x88CA;
        public const uint GL_MATRIX11_ARB = 0x88CB;
        public const uint GL_MATRIX12_ARB = 0x88CC;
        public const uint GL_MATRIX13_ARB = 0x88CD;
        public const uint GL_MATRIX14_ARB = 0x88CE;
        public const uint GL_MATRIX15_ARB = 0x88CF;
        public const uint GL_MATRIX16_ARB = 0x88D0;
        public const uint GL_MATRIX17_ARB = 0x88D1;
        public const uint GL_MATRIX18_ARB = 0x88D2;
        public const uint GL_MATRIX19_ARB = 0x88D3;
        public const uint GL_MATRIX20_ARB = 0x88D4;
        public const uint GL_MATRIX21_ARB = 0x88D5;
        public const uint GL_MATRIX22_ARB = 0x88D6;
        public const uint GL_MATRIX23_ARB = 0x88D7;
        public const uint GL_MATRIX24_ARB = 0x88D8;
        public const uint GL_MATRIX25_ARB = 0x88D9;
        public const uint GL_MATRIX26_ARB = 0x88DA;
        public const uint GL_MATRIX27_ARB = 0x88DB;
        public const uint GL_MATRIX28_ARB = 0x88DC;
        public const uint GL_MATRIX29_ARB = 0x88DD;
        public const uint GL_MATRIX30_ARB = 0x88DE;
        public const uint GL_MATRIX31_ARB = 0x88DF;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_program
        ///////////////////////////////////////////////////////////////////////
        public const uint FRAGMENT_PROGRAM_ARB = 0x8804;
        public const uint PROGRAM_FORMAT_ASCII_ARB = 0x8875;
        public const uint PROGRAM_LENGTH_ARB = 0x8627;
        public const uint PROGRAM_FORMAT_ARB = 0x8876;
        public const uint PROGRAM_BINDING_ARB = 0x8677;
        public const uint PROGRAM_INSTRUCTIONS_ARB = 0x88A0;
        public const uint MAX_PROGRAM_INSTRUCTIONS_ARB = 0x88A1;
        public const uint PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A2;
        public const uint MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB = 0x88A3;
        public const uint PROGRAM_TEMPORARIES_ARB = 0x88A4;
        public const uint MAX_PROGRAM_TEMPORARIES_ARB = 0x88A5;
        public const uint PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A6;
        public const uint MAX_PROGRAM_NATIVE_TEMPORARIES_ARB = 0x88A7;
        public const uint PROGRAM_PARAMETERS_ARB = 0x88A8;
        public const uint MAX_PROGRAM_PARAMETERS_ARB = 0x88A9;
        public const uint PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AA;
        public const uint MAX_PROGRAM_NATIVE_PARAMETERS_ARB = 0x88AB;
        public const uint PROGRAM_ATTRIBS_ARB = 0x88AC;
        public const uint MAX_PROGRAM_ATTRIBS_ARB = 0x88AD;
        public const uint PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AE;
        public const uint MAX_PROGRAM_NATIVE_ATTRIBS_ARB = 0x88AF;
        public const uint MAX_PROGRAM_LOCAL_PARAMETERS_ARB = 0x88B4;
        public const uint MAX_PROGRAM_ENV_PARAMETERS_ARB = 0x88B5;
        public const uint PROGRAM_UNDER_NATIVE_LIMITS_ARB = 0x88B6;
        public const uint PROGRAM_ALU_INSTRUCTIONS_ARB = 0x8805;
        public const uint PROGRAM_TEX_INSTRUCTIONS_ARB = 0x8806;
        public const uint PROGRAM_TEX_INDIRECTIONS_ARB = 0x8807;
        public const uint PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x8808;
        public const uint PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x8809;
        public const uint PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x880A;
        public const uint MAX_PROGRAM_ALU_INSTRUCTIONS_ARB = 0x880B;
        public const uint MAX_PROGRAM_TEX_INSTRUCTIONS_ARB = 0x880C;
        public const uint MAX_PROGRAM_TEX_INDIRECTIONS_ARB = 0x880D;
        public const uint MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB = 0x880E;
        public const uint MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB = 0x880F;
        public const uint MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB = 0x8810;
        public const uint PROGRAM_STRING_ARB = 0x8628;
        public const uint PROGRAM_ERROR_POSITION_ARB = 0x864B;
        public const uint CURRENT_MATRIX_ARB = 0x8641;
        public const uint TRANSPOSE_CURRENT_MATRIX_ARB = 0x88B7;
        public const uint CURRENT_MATRIX_STACK_DEPTH_ARB = 0x8640;
        public const uint MAX_PROGRAM_MATRICES_ARB = 0x862F;
        public const uint MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB = 0x862E;
        public const uint MAX_TEXTURE_COORDS_ARB = 0x8871;
        public const uint MAX_TEXTURE_IMAGE_UNITS_ARB = 0x8872;
        public const uint PROGRAM_ERROR_STRING_ARB = 0x8874;
        public const uint MATRIX0_ARB = 0x88C0;
        public const uint MATRIX1_ARB = 0x88C1;
        public const uint MATRIX2_ARB = 0x88C2;
        public const uint MATRIX3_ARB = 0x88C3;
        public const uint MATRIX4_ARB = 0x88C4;
        public const uint MATRIX5_ARB = 0x88C5;
        public const uint MATRIX6_ARB = 0x88C6;
        public const uint MATRIX7_ARB = 0x88C7;
        public const uint MATRIX8_ARB = 0x88C8;
        public const uint MATRIX9_ARB = 0x88C9;
        public const uint MATRIX10_ARB = 0x88CA;
        public const uint MATRIX11_ARB = 0x88CB;
        public const uint MATRIX12_ARB = 0x88CC;
        public const uint MATRIX13_ARB = 0x88CD;
        public const uint MATRIX14_ARB = 0x88CE;
        public const uint MATRIX15_ARB = 0x88CF;
        public const uint MATRIX16_ARB = 0x88D0;
        public const uint MATRIX17_ARB = 0x88D1;
        public const uint MATRIX18_ARB = 0x88D2;
        public const uint MATRIX19_ARB = 0x88D3;
        public const uint MATRIX20_ARB = 0x88D4;
        public const uint MATRIX21_ARB = 0x88D5;
        public const uint MATRIX22_ARB = 0x88D6;
        public const uint MATRIX23_ARB = 0x88D7;
        public const uint MATRIX24_ARB = 0x88D8;
        public const uint MATRIX25_ARB = 0x88D9;
        public const uint MATRIX26_ARB = 0x88DA;
        public const uint MATRIX27_ARB = 0x88DB;
        public const uint MATRIX28_ARB = 0x88DC;
        public const uint MATRIX29_ARB = 0x88DD;
        public const uint MATRIX30_ARB = 0x88DE;
        public const uint MATRIX31_ARB = 0x88DF;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_buffer_object
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_BUFFER_SIZE_ARB = 0x8764;
        public const uint GL_BUFFER_USAGE_ARB = 0x8765;
        public const uint GL_ARRAY_BUFFER_ARB = 0x8892;
        public const uint GL_ELEMENT_ARRAY_BUFFER_ARB = 0x8893;
        public const uint GL_ARRAY_BUFFER_BINDING_ARB = 0x8894;
        public const uint GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB = 0x8895;
        public const uint GL_VERTEX_ARRAY_BUFFER_BINDING_ARB = 0x8896;
        public const uint GL_NORMAL_ARRAY_BUFFER_BINDING_ARB = 0x8897;
        public const uint GL_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x8898;
        public const uint GL_INDEX_ARRAY_BUFFER_BINDING_ARB = 0x8899;
        public const uint GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB = 0x889A;
        public const uint GL_EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB = 0x889B;
        public const uint GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x889C;
        public const uint GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB = 0x889D;
        public const uint GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB = 0x889E;
        public const uint GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB = 0x889F;
        public const uint GL_READ_ONLY_ARB = 0x88B8;
        public const uint GL_WRITE_ONLY_ARB = 0x88B9;
        public const uint GL_READ_WRITE_ARB = 0x88BA;
        public const uint GL_BUFFER_ACCESS_ARB = 0x88BB;
        public const uint GL_BUFFER_MAPPED_ARB = 0x88BC;
        public const uint GL_BUFFER_MAP_POINTER_ARB = 0x88BD;
        public const uint GL_STREAM_DRAW_ARB = 0x88E0;
        public const uint GL_STREAM_READ_ARB = 0x88E1;
        public const uint GL_STREAM_COPY_ARB = 0x88E2;
        public const uint GL_STATIC_DRAW_ARB = 0x88E4;
        public const uint GL_STATIC_READ_ARB = 0x88E5;
        public const uint GL_STATIC_COPY_ARB = 0x88E6;
        public const uint GL_DYNAMIC_DRAW_ARB = 0x88E8;
        public const uint GL_DYNAMIC_READ_ARB = 0x88E9;
        public const uint GL_DYNAMIC_COPY_ARB = 0x88EA;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_occlusion_query
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_QUERY_COUNTER_BITS_ARB = 0x8864;
        public const uint GL_CURRENT_QUERY_ARB = 0x8865;
        public const uint GL_QUERY_RESULT_ARB = 0x8866;
        public const uint GL_QUERY_RESULT_AVAILABLE_ARB = 0x8867;
        public const uint GL_SAMPLES_PASSED_ARB = 0x8914;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_objects
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PROGRAM_OBJECT_ARB = 0x8B40;
        public const uint GL_SHADER_OBJECT_ARB = 0x8B48;
        public const uint GL_OBJECT_TYPE_ARB = 0x8B4E;
        public const uint GL_OBJECT_SUBTYPE_ARB = 0x8B4F;
        public const uint GL_FLOAT_VEC2_ARB = 0x8B50;
        public const uint GL_FLOAT_VEC3_ARB = 0x8B51;
        public const uint GL_FLOAT_VEC4_ARB = 0x8B52;
        public const uint GL_INT_VEC2_ARB = 0x8B53;
        public const uint GL_INT_VEC3_ARB = 0x8B54;
        public const uint GL_INT_VEC4_ARB = 0x8B55;
        public const uint GL_BOOL_ARB = 0x8B56;
        public const uint GL_BOOL_VEC2_ARB = 0x8B57;
        public const uint GL_BOOL_VEC3_ARB = 0x8B58;
        public const uint GL_BOOL_VEC4_ARB = 0x8B59;
        public const uint GL_FLOAT_MAT2_ARB = 0x8B5A;
        public const uint GL_FLOAT_MAT3_ARB = 0x8B5B;
        public const uint GL_FLOAT_MAT4_ARB = 0x8B5C;
        public const uint GL_SAMPLER_1D_ARB = 0x8B5D;
        public const uint GL_SAMPLER_2D_ARB = 0x8B5E;
        public const uint GL_SAMPLER_3D_ARB = 0x8B5F;
        public const uint GL_SAMPLER_CUBE_ARB = 0x8B60;
        public const uint GL_SAMPLER_1D_SHADOW_ARB = 0x8B61;
        public const uint GL_SAMPLER_2D_SHADOW_ARB = 0x8B62;
        public const uint GL_SAMPLER_2D_RECT_ARB = 0x8B63;
        public const uint GL_SAMPLER_2D_RECT_SHADOW_ARB = 0x8B64;
        public const uint GL_OBJECT_DELETE_STATUS_ARB = 0x8B80;
        public const uint GL_OBJECT_COMPILE_STATUS_ARB = 0x8B81;
        public const uint GL_OBJECT_LINK_STATUS_ARB = 0x8B82;
        public const uint GL_OBJECT_VALIDATE_STATUS_ARB = 0x8B83;
        public const uint GL_OBJECT_INFO_LOG_LENGTH_ARB = 0x8B84;
        public const uint GL_OBJECT_ATTACHED_OBJECTS_ARB = 0x8B85;
        public const uint GL_OBJECT_ACTIVE_UNIFORMS_ARB = 0x8B86;
        public const uint GL_OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB = 0x8B87;
        public const uint GL_OBJECT_SHADER_SOURCE_LENGTH_ARB = 0x8B88;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_shader
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_SHADER_ARB = 0x8B31;
        public const uint GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB = 0x8B4A;
        public const uint GL_MAX_VARYING_FLOATS_ARB = 0x8B4B;
        public const uint GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C;
        public const uint GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB = 0x8B4D;
        public const uint GL_OBJECT_ACTIVE_ATTRIBUTES_ARB = 0x8B89;
        public const uint GL_OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB = 0x8B8A;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_shader
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FRAGMENT_SHADER_ARB = 0x8B30;
        public const uint GL_MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB = 0x8B49;
        public const uint GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shading_language_100
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SHADING_LANGUAGE_VERSION_ARB = 0x8B8C;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_non_power_of_two (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_point_sprite
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_POINT_SPRITE_ARB = 0x8861;
        public const uint GL_COORD_REPLACE_ARB = 0x8862;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_program_shadow (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_draw_buffers
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_DRAW_BUFFERS_ARB = 0x8824;
        public const uint GL_DRAW_BUFFER0_ARB = 0x8825;
        public const uint GL_DRAW_BUFFER1_ARB = 0x8826;
        public const uint GL_DRAW_BUFFER2_ARB = 0x8827;
        public const uint GL_DRAW_BUFFER3_ARB = 0x8828;
        public const uint GL_DRAW_BUFFER4_ARB = 0x8829;
        public const uint GL_DRAW_BUFFER5_ARB = 0x882A;
        public const uint GL_DRAW_BUFFER6_ARB = 0x882B;
        public const uint GL_DRAW_BUFFER7_ARB = 0x882C;
        public const uint GL_DRAW_BUFFER8_ARB = 0x882D;
        public const uint GL_DRAW_BUFFER9_ARB = 0x882E;
        public const uint GL_DRAW_BUFFER10_ARB = 0x882F;
        public const uint GL_DRAW_BUFFER11_ARB = 0x8830;
        public const uint GL_DRAW_BUFFER12_ARB = 0x8831;
        public const uint GL_DRAW_BUFFER13_ARB = 0x8832;
        public const uint GL_DRAW_BUFFER14_ARB = 0x8833;
        public const uint GL_DRAW_BUFFER15_ARB = 0x8834;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_rectangle
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_RECTANGLE_ARB = 0x84F5;
        public const uint GL_TEXTURE_BINDING_RECTANGLE_ARB = 0x84F6;
        public const uint GL_PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7;
        public const uint GL_MAX_RECTANGLE_TEXTURE_SIZE_ARB = 0x84F8;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_half_float_pixel
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_HALF_FLOAT_ARB = 0x140B;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_float
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_RED_TYPE_ARB = 0x8C10;
        public const uint GL_TEXTURE_GREEN_TYPE_ARB = 0x8C11;
        public const uint GL_TEXTURE_BLUE_TYPE_ARB = 0x8C12;
        public const uint GL_TEXTURE_ALPHA_TYPE_ARB = 0x8C13;
        public const uint GL_TEXTURE_LUMINANCE_TYPE_ARB = 0x8C14;
        public const uint GL_TEXTURE_INTENSITY_TYPE_ARB = 0x8C15;
        public const uint GL_TEXTURE_DEPTH_TYPE_ARB = 0x8C16;
        public const uint GL_UNSIGNED_NORMALIZED_ARB = 0x8C17;
        public const uint GL_RGBA32F_ARB = 0x8814;
        public const uint GL_RGB32F_ARB = 0x8815;
        public const uint GL_ALPHA32F_ARB = 0x8816;
        public const uint GL_INTENSITY32F_ARB = 0x8817;
        public const uint GL_LUMINANCE32F_ARB = 0x8818;
        public const uint GL_LUMINANCE_ALPHA32F_ARB = 0x8819;
        public const uint GL_RGBA16F_ARB = 0x881A;
        public const uint GL_RGB16F_ARB = 0x881B;
        public const uint GL_ALPHA16F_ARB = 0x881C;
        public const uint GL_INTENSITY16F_ARB = 0x881D;
        public const uint GL_LUMINANCE16F_ARB = 0x881E;
        public const uint GL_LUMINANCE_ALPHA16F_ARB = 0x881F;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_pixel_buffer_object
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PIXEL_PACK_BUFFER_ARB = 0x88EB;
        public const uint GL_PIXEL_UNPACK_BUFFER_ARB = 0x88EC;
        public const uint GL_PIXEL_PACK_BUFFER_BINDING_ARB = 0x88ED;
        public const uint GL_PIXEL_UNPACK_BUFFER_BINDING_ARB = 0x88EF;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_depth_buffer_float
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.0
        public const uint GL_DEPTH_COMPONENT32F             = 0x8CAC;
        public const uint GL_DEPTH32F_STENCIL8              = 0x8CAD;
        public const uint GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_draw_instanced (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.1 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_framebuffer_object
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.0
        public const uint GL_INVALID_FRAMEBUFFER_OPERATION  = 0x0506;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
        public const uint GL_FRAMEBUFFER_DEFAULT            = 0x8218;
        public const uint GL_FRAMEBUFFER_UNDEFINED          = 0x8219;
        public const uint GL_DEPTH_STENCIL_ATTACHMENT       = 0x821A;
        public const uint GL_MAX_RENDERBUFFER_SIZE          = 0x84E8;
        public const uint GL_DEPTH_STENCIL                  = 0x84F9;
        public const uint GL_UNSIGNED_INT_24_8              = 0x84FA;
        public const uint GL_DEPTH24_STENCIL8               = 0x88F0;
        public const uint GL_TEXTURE_STENCIL_SIZE           = 0x88F1;
        public const uint GL_TEXTURE_RED_TYPE               = 0x8C10;
        public const uint GL_TEXTURE_GREEN_TYPE             = 0x8C11;
        public const uint GL_TEXTURE_BLUE_TYPE              = 0x8C12;
        public const uint GL_TEXTURE_ALPHA_TYPE             = 0x8C13;
        public const uint GL_TEXTURE_DEPTH_TYPE             = 0x8C16;
        public const uint GL_UNSIGNED_NORMALIZED            = 0x8C17;
        public const uint GL_FRAMEBUFFER_BINDING            = 0x8CA6;
        public const uint GL_DRAW_FRAMEBUFFER_BINDING       = GL_FRAMEBUFFER_BINDING;
        public const uint GL_RENDERBUFFER_BINDING           = 0x8CA7;
        public const uint GL_READ_FRAMEBUFFER               = 0x8CA8;
        public const uint GL_DRAW_FRAMEBUFFER               = 0x8CA9;
        public const uint GL_READ_FRAMEBUFFER_BINDING       = 0x8CAA;
        public const uint GL_RENDERBUFFER_SAMPLES           = 0x8CAB;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
        public const uint GL_FRAMEBUFFER_COMPLETE           = 0x8CD5;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
        public const uint GL_FRAMEBUFFER_UNSUPPORTED        = 0x8CDD;
        public const uint GL_MAX_COLOR_ATTACHMENTS          = 0x8CDF;
        public const uint GL_COLOR_ATTACHMENT0              = 0x8CE0;
        public const uint GL_COLOR_ATTACHMENT1              = 0x8CE1;
        public const uint GL_COLOR_ATTACHMENT2              = 0x8CE2;
        public const uint GL_COLOR_ATTACHMENT3              = 0x8CE3;
        public const uint GL_COLOR_ATTACHMENT4              = 0x8CE4;
        public const uint GL_COLOR_ATTACHMENT5              = 0x8CE5;
        public const uint GL_COLOR_ATTACHMENT6              = 0x8CE6;
        public const uint GL_COLOR_ATTACHMENT7              = 0x8CE7;
        public const uint GL_COLOR_ATTACHMENT8              = 0x8CE8;
        public const uint GL_COLOR_ATTACHMENT9              = 0x8CE9;
        public const uint GL_COLOR_ATTACHMENT10             = 0x8CEA;
        public const uint GL_COLOR_ATTACHMENT11             = 0x8CEB;
        public const uint GL_COLOR_ATTACHMENT12             = 0x8CEC;
        public const uint GL_COLOR_ATTACHMENT13             = 0x8CED;
        public const uint GL_COLOR_ATTACHMENT14             = 0x8CEE;
        public const uint GL_COLOR_ATTACHMENT15             = 0x8CEF;
        public const uint GL_DEPTH_ATTACHMENT               = 0x8D00;
        public const uint GL_STENCIL_ATTACHMENT             = 0x8D20;
        public const uint GL_FRAMEBUFFER                    = 0x8D40;
        public const uint GL_RENDERBUFFER                   = 0x8D41;
        public const uint GL_RENDERBUFFER_WIDTH             = 0x8D42;
        public const uint GL_RENDERBUFFER_HEIGHT            = 0x8D43;
        public const uint GL_RENDERBUFFER_INTERNAL_FORMAT   = 0x8D44;
        public const uint GL_STENCIL_INDEX1                 = 0x8D46;
        public const uint GL_STENCIL_INDEX4                 = 0x8D47;
        public const uint GL_STENCIL_INDEX8                 = 0x8D48;
        public const uint GL_STENCIL_INDEX16                = 0x8D49;
        public const uint GL_RENDERBUFFER_RED_SIZE          = 0x8D50;
        public const uint GL_RENDERBUFFER_GREEN_SIZE        = 0x8D51;
        public const uint GL_RENDERBUFFER_BLUE_SIZE         = 0x8D52;
        public const uint GL_RENDERBUFFER_ALPHA_SIZE        = 0x8D53;
        public const uint GL_RENDERBUFFER_DEPTH_SIZE        = 0x8D54;
        public const uint GL_RENDERBUFFER_STENCIL_SIZE      = 0x8D55;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
        public const uint GL_MAX_SAMPLES                    = 0x8D57;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_framebuffer_object (deprecated)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.0
        public const uint GL_INDEX                          = 0x8222;
        public const uint GL_TEXTURE_LUMINANCE_TYPE         = 0x8C14;
        public const uint GL_TEXTURE_INTENSITY_TYPE         = 0x8C15;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_framebuffer_sRGB
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.0
        public const uint GL_FRAMEBUFFER_SRGB               = 0x8DB9;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_geometry_shader4
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_LINES_ADJACENCY_ARB = 0x000A;
        public const uint GL_LINE_STRIP_ADJACENCY_ARB = 0x000B;
        public const uint GL_TRIANGLES_ADJACENCY_ARB = 0x000C;
        public const uint GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D;
        public const uint GL_PROGRAM_POINT_SIZE_ARB = 0x8642;
        public const uint GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB = 0x8C29;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB = 0x8DA7;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB = 0x8DA8;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9;
        public const uint GL_GEOMETRY_SHADER_ARB = 0x8DD9;
        public const uint GL_GEOMETRY_VERTICES_OUT_ARB = 0x8DDA;
        public const uint GL_GEOMETRY_INPUT_TYPE_ARB = 0x8DDB;
        public const uint GL_GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC;
        public const uint GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD;
        public const uint GL_MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE;
        public const uint GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB = 0x8DDF;
        public const uint GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB = 0x8DE0;
        public const uint GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB = 0x8DE1;
        /* reuse GL_MAX_VARYING_COMPONENTS */
        /* reuse GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_half_float_vertex
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.0
        public const uint GL_HALF_FLOAT                     = 0x140B;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_instanced_arrays
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ARB = 0x88FE;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_map_buffer_range
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.0
        public const uint GL_MAP_READ_BIT                   = 0x0001;
        public const uint GL_MAP_WRITE_BIT                  = 0x0002;
        public const uint GL_MAP_INVALIDATE_RANGE_BIT       = 0x0004;
        public const uint GL_MAP_INVALIDATE_BUFFER_BIT      = 0x0008;
        public const uint GL_MAP_FLUSH_EXPLICIT_BIT         = 0x0010;
        public const uint GL_MAP_UNSYNCHRONIZED_BIT         = 0x0020;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_buffer_object
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_BUFFER_ARB = 0x8C2A;
        public const uint GL_MAX_TEXTURE_BUFFER_SIZE_ARB = 0x8C2B;
        public const uint GL_TEXTURE_BINDING_BUFFER_ARB = 0x8C2C;
        public const uint GL_TEXTURE_BUFFER_DATA_STORE_BINDING_ARB = 0x8C2D;
        public const uint GL_TEXTURE_BUFFER_FORMAT_ARB = 0x8C2E;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_compression_rgtc
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.0
        public const uint GL_COMPRESSED_RED_RGTC1           = 0x8DBB;
        public const uint GL_COMPRESSED_SIGNED_RED_RGTC1    = 0x8DBC;
        public const uint GL_COMPRESSED_RG_RGTC2            = 0x8DBD;
        public const uint GL_COMPRESSED_SIGNED_RG_RGTC2     = 0x8DBE;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_rg
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.0
        public const uint GL_RG                             = 0x8227;
        public const uint GL_RG_INTEGER                     = 0x8228;
        public const uint GL_R8                             = 0x8229;
        public const uint GL_R16                            = 0x822A;
        public const uint GL_RG8                            = 0x822B;
        public const uint GL_RG16                           = 0x822C;
        public const uint GL_R16F                           = 0x822D;
        public const uint GL_R32F                           = 0x822E;
        public const uint GL_RG16F                          = 0x822F;
        public const uint GL_RG32F                          = 0x8230;
        public const uint GL_R8I                            = 0x8231;
        public const uint GL_R8UI                           = 0x8232;
        public const uint GL_R16I                           = 0x8233;
        public const uint GL_R16UI                          = 0x8234;
        public const uint GL_R32I                           = 0x8235;
        public const uint GL_R32UI                          = 0x8236;
        public const uint GL_RG8I                           = 0x8237;
        public const uint GL_RG8UI                          = 0x8238;
        public const uint GL_RG16I                          = 0x8239;
        public const uint GL_RG16UI                         = 0x823A;
        public const uint GL_RG32I                          = 0x823B;
        public const uint GL_RG32UI                         = 0x823C;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_array_object
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.0
        public const uint GL_VERTEX_ARRAY_BINDING           = 0x85B5;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_uniform_buffer_object
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.1
        public const uint GL_UNIFORM_BUFFER                 = 0x8A11;
        public const uint GL_UNIFORM_BUFFER_BINDING         = 0x8A28;
        public const uint GL_UNIFORM_BUFFER_START           = 0x8A29;
        public const uint GL_UNIFORM_BUFFER_SIZE            = 0x8A2A;
        public const uint GL_MAX_VERTEX_UNIFORM_BLOCKS      = 0x8A2B;
        public const uint GL_MAX_GEOMETRY_UNIFORM_BLOCKS    = 0x8A2C;
        public const uint GL_MAX_FRAGMENT_UNIFORM_BLOCKS    = 0x8A2D;
        public const uint GL_MAX_COMBINED_UNIFORM_BLOCKS    = 0x8A2E;
        public const uint GL_MAX_UNIFORM_BUFFER_BINDINGS    = 0x8A2F;
        public const uint GL_MAX_UNIFORM_BLOCK_SIZE         = 0x8A30;
        public const uint GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
        public const uint GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
        public const uint GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
        public const uint GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
        public const uint GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
        public const uint GL_ACTIVE_UNIFORM_BLOCKS          = 0x8A36;
        public const uint GL_UNIFORM_TYPE                   = 0x8A37;
        public const uint GL_UNIFORM_SIZE                   = 0x8A38;
        public const uint GL_UNIFORM_NAME_LENGTH            = 0x8A39;
        public const uint GL_UNIFORM_BLOCK_INDEX            = 0x8A3A;
        public const uint GL_UNIFORM_OFFSET                 = 0x8A3B;
        public const uint GL_UNIFORM_ARRAY_STRIDE           = 0x8A3C;
        public const uint GL_UNIFORM_MATRIX_STRIDE          = 0x8A3D;
        public const uint GL_UNIFORM_IS_ROW_MAJOR           = 0x8A3E;
        public const uint GL_UNIFORM_BLOCK_BINDING          = 0x8A3F;
        public const uint GL_UNIFORM_BLOCK_DATA_SIZE        = 0x8A40;
        public const uint GL_UNIFORM_BLOCK_NAME_LENGTH      = 0x8A41;
        public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS  = 0x8A42;
        public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
        public const uint GL_INVALID_INDEX                  = 0xFFFFFFFF;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_texture_lod (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_depth_clamp
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.2
        public const uint GL_DEPTH_CLAMP                    = 0x864F;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_draw_elements_base_vertex (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.2 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_coord_conventions (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.2 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_provoking_vertex
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.2
        public const uint GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
        public const uint GL_FIRST_VERTEX_CONVENTION        = 0x8E4D;
        public const uint GL_LAST_VERTEX_CONVENTION         = 0x8E4E;
        public const uint GL_PROVOKING_VERTEX               = 0x8E4F;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_seamless_cube_map
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.2
        public const uint GL_TEXTURE_CUBE_MAP_SEAMLESS      = 0x884F;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sync
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.2
        public const uint GL_MAX_SERVER_WAIT_TIMEOUT        = 0x9111;
        public const uint GL_OBJECT_TYPE                    = 0x9112;
        public const uint GL_SYNC_CONDITION                 = 0x9113;
        public const uint GL_SYNC_STATUS                    = 0x9114;
        public const uint GL_SYNC_FLAGS                     = 0x9115;
        public const uint GL_SYNC_FENCE                     = 0x9116;
        public const uint GL_SYNC_GPU_COMMANDS_COMPLETE     = 0x9117;
        public const uint GL_UNSIGNALED                     = 0x9118;
        public const uint GL_SIGNALED                       = 0x9119;
        public const uint GL_ALREADY_SIGNALED               = 0x911A;
        public const uint GL_TIMEOUT_EXPIRED                = 0x911B;
        public const uint GL_CONDITION_SATISFIED            = 0x911C;
        public const uint GL_WAIT_FAILED                    = 0x911D;
        public const uint GL_SYNC_FLUSH_COMMANDS_BIT        = 0x00000001;
        public const ulong GL_TIMEOUT_IGNORED               = 0xFFFFFFFFFFFFFFFF;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_multisample
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.2
        public const uint GL_SAMPLE_POSITION                = 0x8E50;
        public const uint GL_SAMPLE_MASK                    = 0x8E51;
        public const uint GL_SAMPLE_MASK_VALUE              = 0x8E52;
        public const uint GL_MAX_SAMPLE_MASK_WORDS          = 0x8E59;
        public const uint GL_TEXTURE_2D_MULTISAMPLE         = 0x9100;
        public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE   = 0x9101;
        public const uint GL_TEXTURE_2D_MULTISAMPLE_ARRAY   = 0x9102;
        public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
        public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
        public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
        public const uint GL_TEXTURE_SAMPLES                = 0x9106;
        public const uint GL_TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
        public const uint GL_SAMPLER_2D_MULTISAMPLE         = 0x9108;
        public const uint GL_INT_SAMPLER_2D_MULTISAMPLE     = 0x9109;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
        public const uint GL_SAMPLER_2D_MULTISAMPLE_ARRAY   = 0x910B;
        public const uint GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
        public const uint GL_MAX_COLOR_TEXTURE_SAMPLES      = 0x910E;
        public const uint GL_MAX_DEPTH_TEXTURE_SAMPLES      = 0x910F;
        public const uint GL_MAX_INTEGER_SAMPLES            = 0x9110;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_array_bgra
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.2
        reuse GL_BGRA (defined in OpenGL 1.2) 
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_draw_buffers_blend (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sample_shading
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SAMPLE_SHADING_ARB = 0x8C36;
        public const uint GL_MIN_SAMPLE_SHADING_VALUE_ARB = 0x8C37;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_cube_map_array
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_CUBE_MAP_ARRAY_ARB                 = 0x9009;
        public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB         = 0x900A;
        public const uint GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB           = 0x900B;
        public const uint GL_SAMPLER_CUBE_MAP_ARRAY_ARB                 = 0x900C;
        public const uint GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB          = 0x900D;
        public const uint GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB             = 0x900E;
        public const uint GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB    = 0x900F;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_gather
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB      = 0x8E5E;
        public const uint GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB      = 0x8E5F;
        public const uint GL_MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB  = 0x8F9F;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_query_lod (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shading_language_include
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SHADER_INCLUDE_ARB = 0x8DAE;
        public const uint GL_NAMED_STRING_LENGTH_ARB = 0x8DE9;
        public const uint GL_NAMED_STRING_TYPE_ARB = 0x8DEA;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_compression_bptc
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COMPRESSED_RGBA_BPTC_UNORM_ARB = 0x8E8C;
        public const uint GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB = 0x8E8D;
        public const uint GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB = 0x8E8E;
        public const uint GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB = 0x8E8F;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_explicit_attrib_location (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_occlusion_query2
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3
        public const uint GL_ANY_SAMPLES_PASSED             = 0x8C2F;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sampler_objects
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3
        public const uint GL_SAMPLER_BINDING                = 0x8919;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_bit_encoding (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_rgb10_a2ui
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3
        public const uint GL_RGB10_A2UI                     = 0x906F;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_swizzle
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3
        public const uint GL_TEXTURE_SWIZZLE_R              = 0x8E42;
        public const uint GL_TEXTURE_SWIZZLE_G              = 0x8E43;
        public const uint GL_TEXTURE_SWIZZLE_B              = 0x8E44;
        public const uint GL_TEXTURE_SWIZZLE_A              = 0x8E45;
        public const uint GL_TEXTURE_SWIZZLE_RGBA           = 0x8E46;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_timer_query
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3
        public const uint GL_TIME_ELAPSED                   = 0x88BF;
        public const uint GL_TIMESTAMP                      = 0x8E28;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_type_2_10_10_10_rev
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 3.3
        reuse GL_UNSIGNED_INT_2_10_10_10_REV
        public const uint GL_INT_2_10_10_10_REV             = 0x8D9F; 
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_draw_indirect
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0
        public const uint GL_DRAW_INDIRECT_BUFFER           = 0x8F3F;
        public const uint GL_DRAW_INDIRECT_BUFFER_BINDING   = 0x8F43;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_gpu_shader5
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0
        public const uint GL_GEOMETRY_SHADER_INVOCATIONS    = 0x887F;
        public const uint GL_MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
        public const uint GL_MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
        public const uint GL_MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
        public const uint GL_FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
        reuse GL_MAX_VERTEX_STREAMS
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_gpu_shader_fp64
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0
        reuse GL_DOUBLE
        public const uint GL_DOUBLE_VEC2                    = 0x8FFC;
        public const uint GL_DOUBLE_VEC3                    = 0x8FFD;
        public const uint GL_DOUBLE_VEC4                    = 0x8FFE;
        public const uint GL_DOUBLE_MAT2                    = 0x8F46;
        public const uint GL_DOUBLE_MAT3                    = 0x8F47;
        public const uint GL_DOUBLE_MAT4                    = 0x8F48;
        public const uint GL_DOUBLE_MAT2x3                  = 0x8F49;
        public const uint GL_DOUBLE_MAT2x4                  = 0x8F4A;
        public const uint GL_DOUBLE_MAT3x2                  = 0x8F4B;
        public const uint GL_DOUBLE_MAT3x4                  = 0x8F4C;
        public const uint GL_DOUBLE_MAT4x2                  = 0x8F4D;
        public const uint GL_DOUBLE_MAT4x3                  = 0x8F4E;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_subroutine
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0
        public const uint GL_ACTIVE_SUBROUTINES             = 0x8DE5;
        public const uint GL_ACTIVE_SUBROUTINE_UNIFORMS     = 0x8DE6;
        public const uint GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
        public const uint GL_ACTIVE_SUBROUTINE_MAX_LENGTH   = 0x8E48;
        public const uint GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
        public const uint GL_MAX_SUBROUTINES                = 0x8DE7;
        public const uint GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
        public const uint GL_NUM_COMPATIBLE_SUBROUTINES     = 0x8E4A;
        public const uint GL_COMPATIBLE_SUBROUTINES         = 0x8E4B;
        reuse GL_UNIFORM_SIZE
        reuse GL_UNIFORM_NAME_LENGTH
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_tessellation_shader
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0
        public const uint GL_PATCHES                        = 0x000E;
        public const uint GL_PATCH_VERTICES                 = 0x8E72;
        public const uint GL_PATCH_DEFAULT_INNER_LEVEL      = 0x8E73;
        public const uint GL_PATCH_DEFAULT_OUTER_LEVEL      = 0x8E74;
        public const uint GL_TESS_CONTROL_OUTPUT_VERTICES   = 0x8E75;
        public const uint GL_TESS_GEN_MODE                  = 0x8E76;
        public const uint GL_TESS_GEN_SPACING               = 0x8E77;
        public const uint GL_TESS_GEN_VERTEX_ORDER          = 0x8E78;
        public const uint GL_TESS_GEN_POINT_MODE            = 0x8E79;
        reuse GL_TRIANGLES
        reuse GL_QUADS
        public const uint GL_ISOLINES                       = 0x8E7A;
        reuse GL_EQUAL
        public const uint GL_FRACTIONAL_ODD                 = 0x8E7B;
        public const uint GL_FRACTIONAL_EVEN                = 0x8E7C;
        reuse GL_CCW 
        reuse GL_CW 
        public const uint GL_MAX_PATCH_VERTICES             = 0x8E7D;
        public const uint GL_MAX_TESS_GEN_LEVEL             = 0x8E7E;
        public const uint GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
        public const uint GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
        public const uint GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
        public const uint GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
        public const uint GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
        public const uint GL_MAX_TESS_PATCH_COMPONENTS      = 0x8E84;
        public const uint GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
        public const uint GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
        public const uint GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
        public const uint GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
        public const uint GL_MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
        public const uint GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
        public const uint GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
        public const uint GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
        public const uint GL_TESS_EVALUATION_SHADER         = 0x8E87;
        public const uint GL_TESS_CONTROL_SHADER            = 0x8E88;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_buffer_object_rgb32
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0
        reuse GL_RGB32F
        reuse GL_RGB32UI
        reuse GL_RGB32I 
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_transform_feedback2
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0
        public const uint GL_TRANSFORM_FEEDBACK             = 0x8E22;
        */
        public const uint GL_TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
        public const uint GL_TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
        /*
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED = GL_TRANSFORM_FEEDBACK_PAUSED;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE = GL_TRANSFORM_FEEDBACK_ACTIVE;
        public const uint GL_TRANSFORM_FEEDBACK_BINDING     = 0x8E25;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_transform_feedback3
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.0
        public const uint GL_MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
        public const uint GL_MAX_VERTEX_STREAMS             = 0x8E71;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_ES2_compatibility
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1
        public const uint GL_FIXED                          = 0x140C;
        public const uint GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
        public const uint GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
        public const uint GL_LOW_FLOAT                      = 0x8DF0;
        public const uint GL_MEDIUM_FLOAT                   = 0x8DF1;
        public const uint GL_HIGH_FLOAT                     = 0x8DF2;
        public const uint GL_LOW_INT                        = 0x8DF3;
        public const uint GL_MEDIUM_INT                     = 0x8DF4;
        public const uint GL_HIGH_INT                       = 0x8DF5;
        public const uint GL_SHADER_COMPILER                = 0x8DFA;
        public const uint GL_NUM_SHADER_BINARY_FORMATS      = 0x8DF9;
        public const uint GL_MAX_VERTEX_UNIFORM_VECTORS     = 0x8DFB;
        public const uint GL_MAX_VARYING_VECTORS            = 0x8DFC;
        public const uint GL_MAX_FRAGMENT_UNIFORM_VECTORS   = 0x8DFD;
        */
        public const uint GL_RGB565 = 0x8D62;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_get_program_binary
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1
        public const uint GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
        public const uint GL_PROGRAM_BINARY_LENGTH          = 0x8741;
        public const uint GL_NUM_PROGRAM_BINARY_FORMATS     = 0x87FE;
        public const uint GL_PROGRAM_BINARY_FORMATS         = 0x87FF;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_separate_shader_objects
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1
        public const uint GL_VERTEX_SHADER_BIT              = 0x00000001;
        public const uint GL_FRAGMENT_SHADER_BIT            = 0x00000002;
        public const uint GL_GEOMETRY_SHADER_BIT            = 0x00000004;
        public const uint GL_TESS_CONTROL_SHADER_BIT        = 0x00000008;
        public const uint GL_TESS_EVALUATION_SHADER_BIT     = 0x00000010;
        public const uint GL_ALL_SHADER_BITS                = 0xFFFFFFFF;
        public const uint GL_PROGRAM_SEPARABLE              = 0x8258;
        public const uint GL_ACTIVE_PROGRAM                 = 0x8259;
        public const uint GL_PROGRAM_PIPELINE_BINDING       = 0x825A;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_precision (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_attrib_64bit
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1 (all are in OpenGL 3.0 & 4.0 already)
        reuse GL_RGB32I
        reuse GL_DOUBLE_VEC2
        reuse GL_DOUBLE_VEC3
        reuse GL_DOUBLE_VEC4
        reuse GL_DOUBLE_MAT2
        reuse GL_DOUBLE_MAT3
        reuse GL_DOUBLE_MAT4
        reuse GL_DOUBLE_MAT2x3
        reuse GL_DOUBLE_MAT2x4
        reuse GL_DOUBLE_MAT3x2
        reuse GL_DOUBLE_MAT3x4
        reuse GL_DOUBLE_MAT4x2
        reuse GL_DOUBLE_MAT4x3
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_viewport_array
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.1
        reuse GL_SCISSOR_BOX
        reuse GL_VIEWPORT
        reuse GL_DEPTH_RANGE
        reuse GL_SCISSOR_TEST
        public const uint GL_MAX_VIEWPORTS                  = 0x825B;
        public const uint GL_VIEWPORT_SUBPIXEL_BITS         = 0x825C;
        public const uint GL_VIEWPORT_BOUNDS_RANGE          = 0x825D;
        public const uint GL_LAYER_PROVOKING_VERTEX         = 0x825E;
        public const uint GL_VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
        public const uint GL_UNDEFINED_VERTEX               = 0x8260;
        reuse GL_FIRST_VERTEX_CONVENTION
        reuse GL_LAST_VERTEX_CONVENTION
        reuse GL_PROVOKING_VERTEX
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_debug_output
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB           = 0x8242;
        public const uint GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB   = 0x8243;
        public const uint GL_DEBUG_CALLBACK_FUNCTION_ARB            = 0x8244;
        public const uint GL_DEBUG_CALLBACK_USER_PARAM_ARB          = 0x8245;
        public const uint GL_DEBUG_SOURCE_API_ARB                   = 0x8246;
        public const uint GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB         = 0x8247;
        public const uint GL_DEBUG_SOURCE_SHADER_COMPILER_ARB       = 0x8248;
        public const uint GL_DEBUG_SOURCE_THIRD_PARTY_ARB           = 0x8249;
        public const uint GL_DEBUG_SOURCE_APPLICATION_ARB           = 0x824A;
        public const uint GL_DEBUG_SOURCE_OTHER_ARB                 = 0x824B;
        public const uint GL_DEBUG_TYPE_ERROR_ARB                   = 0x824C;
        public const uint GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB     = 0x824D;
        public const uint GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB      = 0x824E;
        public const uint GL_DEBUG_TYPE_PORTABILITY_ARB             = 0x824F;
        public const uint GL_DEBUG_TYPE_PERFORMANCE_ARB             = 0x8250;
        public const uint GL_DEBUG_TYPE_OTHER_ARB                   = 0x8251;
        public const uint GL_MAX_DEBUG_MESSAGE_LENGTH_ARB           = 0x9143;
        public const uint GL_MAX_DEBUG_LOGGED_MESSAGES_ARB          = 0x9144;
        public const uint GL_DEBUG_LOGGED_MESSAGES_ARB              = 0x9145;
        public const uint GL_DEBUG_SEVERITY_HIGH_ARB                = 0x9146;
        public const uint GL_DEBUG_SEVERITY_MEDIUM_ARB              = 0x9147;
        public const uint GL_DEBUG_SEVERITY_LOW_ARB                 = 0x9148;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_robustness
        ///////////////////////////////////////////////////////////////////////
        /* reuse GL_NO_ERROR */
        public const uint GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB     = 0x00000004;
        public const uint GL_LOSE_CONTEXT_ON_RESET_ARB              = 0x8252;
        public const uint GL_GUILTY_CONTEXT_RESET_ARB               = 0x8253;
        public const uint GL_INNOCENT_CONTEXT_RESET_ARB             = 0x8254;
        public const uint GL_UNKNOWN_CONTEXT_RESET_ARB              = 0x8255;
        public const uint GL_RESET_NOTIFICATION_STRATEGY_ARB        = 0x8256;
        public const uint GL_NO_RESET_NOTIFICATION_ARB              = 0x8261;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_stencil_export (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shading_language_420pack (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_transform_feedback_instanced (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_internalformat_query
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2
        public const uint GL_NUM_SAMPLE_COUNTS              = 0x9380;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_map_buffer_alignment
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2
        public const uint GL_MIN_MAP_BUFFER_ALIGNMENT       = 0x90BC;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_atomic_counters
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2
        public const uint GL_ATOMIC_COUNTER_BUFFER          = 0x92C0;
        public const uint GL_ATOMIC_COUNTER_BUFFER_BINDING  = 0x92C1;
        public const uint GL_ATOMIC_COUNTER_BUFFER_START    = 0x92C2;
        public const uint GL_ATOMIC_COUNTER_BUFFER_SIZE     = 0x92C3;
        public const uint GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
        public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
        public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;
        public const uint GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
        public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
        public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
        public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
        public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
        public const uint GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
        public const uint GL_MAX_VERTEX_ATOMIC_COUNTERS     = 0x92D2;
        public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
        public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
        public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTERS   = 0x92D5;
        public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTERS   = 0x92D6;
        public const uint GL_MAX_COMBINED_ATOMIC_COUNTERS   = 0x92D7;
        public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
        public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
        public const uint GL_ACTIVE_ATOMIC_COUNTER_BUFFERS  = 0x92D9;
        public const uint GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;
        public const uint GL_UNSIGNED_INT_ATOMIC_COUNTER    = 0x92DB;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_image_load_store
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2
        public const uint GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
        public const uint GL_ELEMENT_ARRAY_BARRIER_BIT      = 0x00000002;
        public const uint GL_UNIFORM_BARRIER_BIT            = 0x00000004;
        public const uint GL_TEXTURE_FETCH_BARRIER_BIT      = 0x00000008;
        public const uint GL_SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
        public const uint GL_COMMAND_BARRIER_BIT            = 0x00000040;
        public const uint GL_PIXEL_BUFFER_BARRIER_BIT       = 0x00000080;
        public const uint GL_TEXTURE_UPDATE_BARRIER_BIT     = 0x00000100;
        public const uint GL_BUFFER_UPDATE_BARRIER_BIT      = 0x00000200;
        public const uint GL_FRAMEBUFFER_BARRIER_BIT        = 0x00000400;
        public const uint GL_TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
        public const uint GL_ATOMIC_COUNTER_BARRIER_BIT     = 0x00001000;
        public const uint GL_ALL_BARRIER_BITS               = 0xFFFFFFFF;
        public const uint GL_MAX_IMAGE_UNITS                = 0x8F38;
        public const uint GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
        public const uint GL_IMAGE_BINDING_NAME             = 0x8F3A;
        public const uint GL_IMAGE_BINDING_LEVEL            = 0x8F3B;
        public const uint GL_IMAGE_BINDING_LAYERED          = 0x8F3C;
        public const uint GL_IMAGE_BINDING_LAYER            = 0x8F3D;
        public const uint GL_IMAGE_BINDING_ACCESS           = 0x8F3E;
        public const uint GL_IMAGE_1D                       = 0x904C;
        public const uint GL_IMAGE_2D                       = 0x904D;
        public const uint GL_IMAGE_3D                       = 0x904E;
        public const uint GL_IMAGE_2D_RECT                  = 0x904F;
        public const uint GL_IMAGE_CUBE                     = 0x9050;
        public const uint GL_IMAGE_BUFFER                   = 0x9051;
        public const uint GL_IMAGE_1D_ARRAY                 = 0x9052;
        public const uint GL_IMAGE_2D_ARRAY                 = 0x9053;
        public const uint GL_IMAGE_CUBE_MAP_ARRAY           = 0x9054;
        public const uint GL_IMAGE_2D_MULTISAMPLE           = 0x9055;
        public const uint GL_IMAGE_2D_MULTISAMPLE_ARRAY     = 0x9056;
        public const uint GL_INT_IMAGE_1D                   = 0x9057;
        public const uint GL_INT_IMAGE_2D                   = 0x9058;
        public const uint GL_INT_IMAGE_3D                   = 0x9059;
        public const uint GL_INT_IMAGE_2D_RECT              = 0x905A;
        public const uint GL_INT_IMAGE_CUBE                 = 0x905B;
        public const uint GL_INT_IMAGE_BUFFER               = 0x905C;
        public const uint GL_INT_IMAGE_1D_ARRAY             = 0x905D;
        public const uint GL_INT_IMAGE_2D_ARRAY             = 0x905E;
        public const uint GL_INT_IMAGE_CUBE_MAP_ARRAY       = 0x905F;
        public const uint GL_INT_IMAGE_2D_MULTISAMPLE       = 0x9060;
        public const uint GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
        public const uint GL_UNSIGNED_INT_IMAGE_1D          = 0x9062;
        public const uint GL_UNSIGNED_INT_IMAGE_2D          = 0x9063;
        public const uint GL_UNSIGNED_INT_IMAGE_3D          = 0x9064;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_RECT     = 0x9065;
        public const uint GL_UNSIGNED_INT_IMAGE_CUBE        = 0x9066;
        public const uint GL_UNSIGNED_INT_IMAGE_BUFFER      = 0x9067;
        public const uint GL_UNSIGNED_INT_IMAGE_1D_ARRAY    = 0x9068;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_ARRAY    = 0x9069;
        public const uint GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
        public const uint GL_MAX_IMAGE_SAMPLES              = 0x906D;
        public const uint GL_IMAGE_BINDING_FORMAT           = 0x906E;
        public const uint GL_IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
        public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
        public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
        public const uint GL_MAX_VERTEX_IMAGE_UNIFORMS      = 0x90CA;
        public const uint GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
        public const uint GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
        public const uint GL_MAX_GEOMETRY_IMAGE_UNIFORMS    = 0x90CD;
        public const uint GL_MAX_FRAGMENT_IMAGE_UNIFORMS    = 0x90CE;
        public const uint GL_MAX_COMBINED_IMAGE_UNIFORMS    = 0x90CF;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shading_language_packing (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_storage
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.2
        public const uint GL_TEXTURE_IMMUTABLE_FORMAT       = 0x912F;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_view
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3
        public const uint GL_TEXTURE_VIEW_MIN_LEVEL         = 0x82DB;
        public const uint GL_TEXTURE_VIEW_NUM_LEVELS        = 0x82DC;
        public const uint GL_TEXTURE_VIEW_MIN_LAYER         = 0x82DD;
        public const uint GL_TEXTURE_VIEW_NUM_LAYERS        = 0x82DE;
        public const uint GL_TEXTURE_IMMUTABLE_LEVELS       = 0x82DF;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_attrib_binding
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3
        public const uint GL_VERTEX_ATTRIB_BINDING          = 0x82D4;
        public const uint GL_VERTEX_ATTRIB_RELATIVE_OFFSET  = 0x82D5;
        public const uint GL_VERTEX_BINDING_DIVISOR         = 0x82D6;
        public const uint GL_VERTEX_BINDING_OFFSET          = 0x82D7;
        public const uint GL_VERTEX_BINDING_STRIDE          = 0x82D8;
        public const uint GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
        public const uint GL_MAX_VERTEX_ATTRIB_BINDINGS     = 0x82DA;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_robustness_isolation (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_ES3_compatibility
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3
        public const uint GL_COMPRESSED_RGB8_ETC2                       = 0x9274;
        public const uint GL_COMPRESSED_SRGB8_ETC2                      = 0x9275;
        public const uint GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2   = 0x9276;
        public const uint GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2  = 0x9277;
        public const uint GL_COMPRESSED_RGBA8_ETC2_EAC                  = 0x9278;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC           = 0x9279;
        public const uint GL_COMPRESSED_R11_EAC                         = 0x9270;
        public const uint GL_COMPRESSED_SIGNED_R11_EAC                  = 0x9271;
        public const uint GL_COMPRESSED_RG11_EAC                        = 0x9272;
        public const uint GL_COMPRESSED_SIGNED_RG11_EAC                 = 0x9273;
        public const uint GL_PRIMITIVE_RESTART_FIXED_INDEX              = 0x8D69;
        public const uint GL_ANY_SAMPLES_PASSED_CONSERVATIVE            = 0x8D6A;
        public const uint GL_MAX_ELEMENT_INDEX                          = 0x8D6B;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_explicit_uniform_location
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3
        public const uint GL_MAX_UNIFORM_LOCATIONS          = 0x826E;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_layer_viewport (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_framebuffer_no_attachments
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3
        public const uint GL_FRAMEBUFFER_DEFAULT_WIDTH      = 0x9310;
        public const uint GL_FRAMEBUFFER_DEFAULT_HEIGHT     = 0x9311;
        public const uint GL_FRAMEBUFFER_DEFAULT_LAYERS     = 0x9312;
        public const uint GL_FRAMEBUFFER_DEFAULT_SAMPLES    = 0x9313;
        public const uint GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
        public const uint GL_MAX_FRAMEBUFFER_WIDTH          = 0x9315;
        public const uint GL_MAX_FRAMEBUFFER_HEIGHT         = 0x9316;
        public const uint GL_MAX_FRAMEBUFFER_LAYERS         = 0x9317;
        public const uint GL_MAX_FRAMEBUFFER_SAMPLES        = 0x9318;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_internalformat_query2
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3
        reuse GL_IMAGE_FORMAT_COMPATIBILITY_TYPE
        reuse GL_NUM_SAMPLE_COUNTS
        reuse GL_RENDERBUFFER
        reuse GL_SAMPLES
        reuse GL_TEXTURE_1D
        reuse GL_TEXTURE_1D_ARRAY
        reuse GL_TEXTURE_2D
        reuse GL_TEXTURE_2D_ARRAY
        reuse GL_TEXTURE_3D
        reuse GL_TEXTURE_CUBE_MAP
        reuse GL_TEXTURE_CUBE_MAP_ARRAY
        reuse GL_TEXTURE_RECTANGLE
        reuse GL_TEXTURE_BUFFER
        reuse GL_TEXTURE_2D_MULTISAMPLE
        reuse GL_TEXTURE_2D_MULTISAMPLE_ARRAY
        reuse GL_TEXTURE_COMPRESSED
        public const uint GL_INTERNALFORMAT_SUPPORTED       = 0x826F;
        public const uint GL_INTERNALFORMAT_PREFERRED       = 0x8270;
        public const uint GL_INTERNALFORMAT_RED_SIZE        = 0x8271;
        public const uint GL_INTERNALFORMAT_GREEN_SIZE      = 0x8272;
        public const uint GL_INTERNALFORMAT_BLUE_SIZE       = 0x8273;
        public const uint GL_INTERNALFORMAT_ALPHA_SIZE      = 0x8274;
        public const uint GL_INTERNALFORMAT_DEPTH_SIZE      = 0x8275;
        public const uint GL_INTERNALFORMAT_STENCIL_SIZE    = 0x8276;
        public const uint GL_INTERNALFORMAT_SHARED_SIZE     = 0x8277;
        public const uint GL_INTERNALFORMAT_RED_TYPE        = 0x8278;
        public const uint GL_INTERNALFORMAT_GREEN_TYPE      = 0x8279;
        public const uint GL_INTERNALFORMAT_BLUE_TYPE       = 0x827A;
        public const uint GL_INTERNALFORMAT_ALPHA_TYPE      = 0x827B;
        public const uint GL_INTERNALFORMAT_DEPTH_TYPE      = 0x827C;
        public const uint GL_INTERNALFORMAT_STENCIL_TYPE    = 0x827D;
        public const uint GL_MAX_WIDTH                      = 0x827E;
        public const uint GL_MAX_HEIGHT                     = 0x827F;
        public const uint GL_MAX_DEPTH                      = 0x8280;
        public const uint GL_MAX_LAYERS                     = 0x8281;
        public const uint GL_MAX_COMBINED_DIMENSIONS        = 0x8282;
        public const uint GL_COLOR_COMPONENTS               = 0x8283;
        public const uint GL_DEPTH_COMPONENTS               = 0x8284;
        public const uint GL_STENCIL_COMPONENTS             = 0x8285;
        public const uint GL_COLOR_RENDERABLE               = 0x8286;
        public const uint GL_DEPTH_RENDERABLE               = 0x8287;
        public const uint GL_STENCIL_RENDERABLE             = 0x8288;
        public const uint GL_FRAMEBUFFER_RENDERABLE         = 0x8289;
        public const uint GL_FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
        public const uint GL_FRAMEBUFFER_BLEND              = 0x828B;
        public const uint GL_READ_PIXELS                    = 0x828C;
        public const uint GL_READ_PIXELS_FORMAT             = 0x828D;
        public const uint GL_READ_PIXELS_TYPE               = 0x828E;
        public const uint GL_TEXTURE_IMAGE_FORMAT           = 0x828F;
        public const uint GL_TEXTURE_IMAGE_TYPE             = 0x8290;
        public const uint GL_GET_TEXTURE_IMAGE_FORMAT       = 0x8291;
        public const uint GL_GET_TEXTURE_IMAGE_TYPE         = 0x8292;
        public const uint GL_MIPMAP                         = 0x8293;
        public const uint GL_MANUAL_GENERATE_MIPMAP         = 0x8294;
        public const uint GL_AUTO_GENERATE_MIPMAP           = 0x8295;
        public const uint GL_COLOR_ENCODING                 = 0x8296;
        public const uint GL_SRGB_READ                      = 0x8297;
        public const uint GL_SRGB_WRITE                     = 0x8298;
        public const uint GL_SRGB_DECODE_ARB                = 0x8299; 
        public const uint GL_FILTER                         = 0x829A;
        public const uint GL_VERTEX_TEXTURE                 = 0x829B;
        public const uint GL_TESS_CONTROL_TEXTURE           = 0x829C;
        public const uint GL_TESS_EVALUATION_TEXTURE        = 0x829D;
        public const uint GL_GEOMETRY_TEXTURE               = 0x829E;
        public const uint GL_FRAGMENT_TEXTURE               = 0x829F;
        public const uint GL_COMPUTE_TEXTURE                = 0x82A0;
        public const uint GL_TEXTURE_SHADOW                 = 0x82A1;
        public const uint GL_TEXTURE_GATHER                 = 0x82A2;
        public const uint GL_TEXTURE_GATHER_SHADOW          = 0x82A3;
        public const uint GL_SHADER_IMAGE_LOAD              = 0x82A4;
        public const uint GL_SHADER_IMAGE_STORE             = 0x82A5;
        public const uint GL_SHADER_IMAGE_ATOMIC            = 0x82A6;
        public const uint GL_IMAGE_TEXEL_SIZE               = 0x82A7;
        public const uint GL_IMAGE_COMPATIBILITY_CLASS      = 0x82A8;
        public const uint GL_IMAGE_PIXEL_FORMAT             = 0x82A9;
        public const uint GL_IMAGE_PIXEL_TYPE               = 0x82AA;
        public const uint GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
        public const uint GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
        public const uint GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
        public const uint GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
        public const uint GL_TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
        public const uint GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
        public const uint GL_TEXTURE_COMPRESSED_BLOCK_SIZE  = 0x82B3;
        public const uint GL_CLEAR_BUFFER                   = 0x82B4;
        public const uint GL_TEXTURE_VIEW                   = 0x82B5;
        public const uint GL_VIEW_COMPATIBILITY_CLASS       = 0x82B6;
        public const uint GL_FULL_SUPPORT                   = 0x82B7;
        public const uint GL_CAVEAT_SUPPORT                 = 0x82B8;
        public const uint GL_IMAGE_CLASS_4_X_32             = 0x82B9;
        public const uint GL_IMAGE_CLASS_2_X_32             = 0x82BA;
        public const uint GL_IMAGE_CLASS_1_X_32             = 0x82BB;
        public const uint GL_IMAGE_CLASS_4_X_16             = 0x82BC;
        public const uint GL_IMAGE_CLASS_2_X_16             = 0x82BD;
        public const uint GL_IMAGE_CLASS_1_X_16             = 0x82BE;
        public const uint GL_IMAGE_CLASS_4_X_8              = 0x82BF;
        public const uint GL_IMAGE_CLASS_2_X_8              = 0x82C0;
        public const uint GL_IMAGE_CLASS_1_X_8              = 0x82C1;
        public const uint GL_IMAGE_CLASS_11_11_10           = 0x82C2;
        public const uint GL_IMAGE_CLASS_10_10_10_2         = 0x82C3;
        public const uint GL_VIEW_CLASS_128_BITS            = 0x82C4;
        public const uint GL_VIEW_CLASS_96_BITS             = 0x82C5;
        public const uint GL_VIEW_CLASS_64_BITS             = 0x82C6;
        public const uint GL_VIEW_CLASS_48_BITS             = 0x82C7;
        public const uint GL_VIEW_CLASS_32_BITS             = 0x82C8;
        public const uint GL_VIEW_CLASS_24_BITS             = 0x82C9;
        public const uint GL_VIEW_CLASS_16_BITS             = 0x82CA;
        public const uint GL_VIEW_CLASS_8_BITS              = 0x82CB;
        public const uint GL_VIEW_CLASS_S3TC_DXT1_RGB       = 0x82CC;
        public const uint GL_VIEW_CLASS_S3TC_DXT1_RGBA      = 0x82CD;
        public const uint GL_VIEW_CLASS_S3TC_DXT3_RGBA      = 0x82CE;
        public const uint GL_VIEW_CLASS_S3TC_DXT5_RGBA      = 0x82CF;
        public const uint GL_VIEW_CLASS_RGTC1_RED           = 0x82D0;
        public const uint GL_VIEW_CLASS_RGTC2_RG            = 0x82D1;
        public const uint GL_VIEW_CLASS_BPTC_UNORM          = 0x82D2;
        public const uint GL_VIEW_CLASS_BPTC_FLOAT          = 0x82D3;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_invalidate_subdata (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_multi_draw_indirect (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_program_interface_query
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3
        public const uint GL_UNIFORM                        = 0x92E1;
        public const uint GL_UNIFORM_BLOCK                  = 0x92E2;
        public const uint GL_PROGRAM_INPUT                  = 0x92E3;
        public const uint GL_PROGRAM_OUTPUT                 = 0x92E4;
        public const uint GL_BUFFER_VARIABLE                = 0x92E5;
        public const uint GL_SHADER_STORAGE_BLOCK           = 0x92E6;
        reuse GL_ATOMIC_COUNTER_BUFFER
        public const uint GL_VERTEX_SUBROUTINE              = 0x92E8;
        public const uint GL_TESS_CONTROL_SUBROUTINE        = 0x92E9;
        public const uint GL_TESS_EVALUATION_SUBROUTINE     = 0x92EA;
        public const uint GL_GEOMETRY_SUBROUTINE            = 0x92EB;
        public const uint GL_FRAGMENT_SUBROUTINE            = 0x92EC;
        public const uint GL_COMPUTE_SUBROUTINE             = 0x92ED;
        public const uint GL_VERTEX_SUBROUTINE_UNIFORM      = 0x92EE;
        public const uint GL_TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
        public const uint GL_TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
        public const uint GL_GEOMETRY_SUBROUTINE_UNIFORM    = 0x92F1;
        public const uint GL_FRAGMENT_SUBROUTINE_UNIFORM    = 0x92F2;
        public const uint GL_COMPUTE_SUBROUTINE_UNIFORM     = 0x92F3;
        public const uint GL_TRANSFORM_FEEDBACK_VARYING     = 0x92F4;
        public const uint GL_ACTIVE_RESOURCES               = 0x92F5;
        public const uint GL_MAX_NAME_LENGTH                = 0x92F6;
        public const uint GL_MAX_NUM_ACTIVE_VARIABLES       = 0x92F7;
        public const uint GL_MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
        public const uint GL_NAME_LENGTH                    = 0x92F9;
        public const uint GL_TYPE                           = 0x92FA;
        public const uint GL_ARRAY_SIZE                     = 0x92FB;
        public const uint GL_OFFSET                         = 0x92FC;
        public const uint GL_BLOCK_INDEX                    = 0x92FD;
        public const uint GL_ARRAY_STRIDE                   = 0x92FE;
        public const uint GL_MATRIX_STRIDE                  = 0x92FF;
        public const uint GL_IS_ROW_MAJOR                   = 0x9300;
        public const uint GL_ATOMIC_COUNTER_BUFFER_INDEX    = 0x9301;
        public const uint GL_BUFFER_BINDING                 = 0x9302;
        public const uint GL_BUFFER_DATA_SIZE               = 0x9303;
        public const uint GL_NUM_ACTIVE_VARIABLES           = 0x9304;
        public const uint GL_ACTIVE_VARIABLES               = 0x9305;
        public const uint GL_REFERENCED_BY_VERTEX_SHADER    = 0x9306;
        public const uint GL_REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
        public const uint GL_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
        public const uint GL_REFERENCED_BY_GEOMETRY_SHADER  = 0x9309;
        public const uint GL_REFERENCED_BY_FRAGMENT_SHADER  = 0x930A;
        public const uint GL_REFERENCED_BY_COMPUTE_SHADER   = 0x930B;
        public const uint GL_TOP_LEVEL_ARRAY_SIZE           = 0x930C;
        public const uint GL_TOP_LEVEL_ARRAY_STRIDE         = 0x930D;
        public const uint GL_LOCATION                       = 0x930E;
        public const uint GL_LOCATION_INDEX                 = 0x930F;
        public const uint GL_IS_PER_PATCH                   = 0x92E7;
        reuse GL_NUM_COMPATIBLE_SUBROUTINES
        reuse GL_COMPATIBLE_SUBROUTINES
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_robust_buffer_access_behavior (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_image_size (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_storage_buffer_object
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3
        public const uint GL_SHADER_STORAGE_BUFFER          = 0x90D2;
        public const uint GL_SHADER_STORAGE_BUFFER_BINDING  = 0x90D3;
        public const uint GL_SHADER_STORAGE_BUFFER_START    = 0x90D4;
        public const uint GL_SHADER_STORAGE_BUFFER_SIZE     = 0x90D5;
        public const uint GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
        public const uint GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
        public const uint GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
        public const uint GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
        public const uint GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
        public const uint GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
        public const uint GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
        public const uint GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
        public const uint GL_MAX_SHADER_STORAGE_BLOCK_SIZE  = 0x90DE;
        public const uint GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
        public const uint GL_SHADER_STORAGE_BARRIER_BIT     = 0x2000;
        public const uint GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES = GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS;
        reuse GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS 
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_stencil_texturing
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3
        public const uint GL_DEPTH_STENCIL_TEXTURE_MODE     = 0x90EA;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_buffer_range
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3
        public const uint GL_TEXTURE_BUFFER_OFFSET          = 0x919D;
        public const uint GL_TEXTURE_BUFFER_SIZE            = 0x919E;
        public const uint GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_query_levels (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_storage_multisample (no constants)
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3 */

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_buffer_storage (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_clear_texture (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_multi_bind (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_query_buffer_object (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_seamless_cubemap_per_texture (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_draw_parameters (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_group_vote (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_mirror_clamp_to_edge (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_stencil8 (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_vertex_type_10f_11f_11f_rev (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_bindless_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_UNSIGNED_INT64_ARB                         = 0x140F;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_compute_variable_group_size
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB = 0x9344;
        public const uint GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB    = 0x90EB;
        public const uint GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB        = 0x9345;
        public const uint GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB           = 0x91BF;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_indirect_parameters
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PARAMETER_BUFFER_ARB                       = 0x80EE;
        public const uint GL_PARAMETER_BUFFER_BINDING_ARB               = 0x80EF;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sparse_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_SPARSE_ARB                         = 0x91A6;
        public const uint GL_VIRTUAL_PAGE_SIZE_INDEX_ARB                = 0x91A7;
        public const uint GL_MIN_SPARSE_LEVEL_ARB                       = 0x919B;
        public const uint GL_NUM_VIRTUAL_PAGE_SIZES_ARB                 = 0x91A8;
        public const uint GL_NUM_SPARSE_LEVELS_ARB                      = 0x91AA;
        public const uint GL_VIRTUAL_PAGE_SIZE_X_ARB                    = 0x9195;
        public const uint GL_VIRTUAL_PAGE_SIZE_Y_ARB                    = 0x9196;
        public const uint GL_VIRTUAL_PAGE_SIZE_Z_ARB                    = 0x9197;
        public const uint GL_MAX_SPARSE_TEXTURE_SIZE_ARB                = 0x9198;
        public const uint GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB             = 0x9199;
        public const uint GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB        = 0x919A;
        public const uint GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB = 0x91A9;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_enhanced_layouts
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_LOCATION_COMPONENT_ARB                     = 0x934A;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_INDEX_ARB        = 0x934B;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE_ARB       = 0x934C;
        // Reuse GL_TRANSFORM_FEEDBACK_BUFFER (defined in OpenGL 3.0)

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_ES3_1_compatibility (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_clip_control (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_conditional_render_inverted (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_cull_distance (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_derivative_control (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_direct_state_access (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_get_texture_sub_image (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_pipeline_statistics_query
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTICES_SUBMITTED_ARB                     = 0x82EE;
        public const uint GL_PRIMITIVES_SUBMITTED_ARB                   = 0x82EF;
        public const uint GL_VERTEX_SHADER_INVOCATIONS_ARB              = 0x82F0;
        public const uint GL_TESS_CONTROL_SHADER_PATCHES_ARB            = 0x82F1;
        public const uint GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB     = 0x82F2;
        public const uint GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB     = 0x82F3;
        public const uint GL_FRAGMENT_SHADER_INVOCATIONS_ARB            = 0x82F4;
        public const uint GL_COMPUTE_SHADER_INVOCATIONS_ARB             = 0x82F5;
        public const uint GL_CLIPPING_INPUT_PRIMITIVES_ARB              = 0x82F6;
        public const uint GL_CLIPPING_OUTPUT_PRIMITIVES_ARB             = 0x82F7;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_shader_texture_image_samples (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_sparse_buffer
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SPARSE_STORAGE_BIT_ARB                     = 0x0400;
        public const uint GL_SPARSE_BUFFER_PAGE_SIZE_ARB                = 0x82F8;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_texture_barrier (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_transform_feedback_overflow_query
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TRANSFORM_FEEDBACK_OVERFLOW_ARB            = 0x82EC;
        public const uint GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW_ARB     = 0x82ED;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_ES3_2_compatibility
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PRIMITIVE_BOUNDING_BOX_ARB                 = 0x92BE;
        public const uint GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB           = 0x9381;
        public const uint GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB     = 0x9382;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_fragment_shader_interlock (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_gpu_shader_int64
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_INT64_ARB                                  = 0x140E;
        public const uint GL_INT64_VEC2_ARB                             = 0x8FE9;
        public const uint GL_INT64_VEC3_ARB                             = 0x8FEA;
        public const uint GL_INT64_VEC4_ARB                             = 0x8FEB;
        public const uint GL_UNSIGNED_INT64_VEC2_ARB                    = 0x8FF5;
        public const uint GL_UNSIGNED_INT64_VEC3_ARB                    = 0x8FF6;
        public const uint GL_UNSIGNED_INT64_VEC4_ARB                    = 0x8FF7;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_parallel_shader_compile
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_SHADER_COMPILER_THREADS_ARB            = 0x91B0;
        public const uint GL_COMPLETION_STATUS_ARB                      = 0x91B1;

        ///////////////////////////////////////////////////////////////////////
        // GL_ARB_post_depth_coverage (no constants)
        ///////////////////////////////////////////////////////////////////////
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_ATI_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_texture_mirror_once
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MIRROR_CLAMP_ATI               = 0x8742;
        public const uint GL_MIRROR_CLAMP_TO_EDGE_ATI       = 0x8743;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_envmap_bumpmap
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_BUMP_ROT_MATRIX_ATI            = 0x8775;
        public const uint GL_BUMP_ROT_MATRIX_SIZE_ATI       = 0x8776;
        public const uint GL_BUMP_NUM_TEX_UNITS_ATI         = 0x8777;
        public const uint GL_BUMP_TEX_UNITS_ATI             = 0x8778;
        public const uint GL_DUDV_ATI                       = 0x8779;
        public const uint GL_DU8DV8_ATI                     = 0x877A;
        public const uint GL_BUMP_ENVMAP_ATI                = 0x877B;
        public const uint GL_BUMP_TARGET_ATI                = 0x877C;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_fragment_shader
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FRAGMENT_SHADER_ATI            = 0x8920;
        public const uint GL_REG_0_ATI                      = 0x8921;
        public const uint GL_REG_1_ATI                      = 0x8922;
        public const uint GL_REG_2_ATI                      = 0x8923;
        public const uint GL_REG_3_ATI                      = 0x8924;
        public const uint GL_REG_4_ATI                      = 0x8925;
        public const uint GL_REG_5_ATI                      = 0x8926;
        public const uint GL_REG_6_ATI                      = 0x8927;
        public const uint GL_REG_7_ATI                      = 0x8928;
        public const uint GL_REG_8_ATI                      = 0x8929;
        public const uint GL_REG_9_ATI                      = 0x892A;
        public const uint GL_REG_10_ATI                     = 0x892B;
        public const uint GL_REG_11_ATI                     = 0x892C;
        public const uint GL_REG_12_ATI                     = 0x892D;
        public const uint GL_REG_13_ATI                     = 0x892E;
        public const uint GL_REG_14_ATI                     = 0x892F;
        public const uint GL_REG_15_ATI                     = 0x8930;
        public const uint GL_REG_16_ATI                     = 0x8931;
        public const uint GL_REG_17_ATI                     = 0x8932;
        public const uint GL_REG_18_ATI                     = 0x8933;
        public const uint GL_REG_19_ATI                     = 0x8934;
        public const uint GL_REG_20_ATI                     = 0x8935;
        public const uint GL_REG_21_ATI                     = 0x8936;
        public const uint GL_REG_22_ATI                     = 0x8937;
        public const uint GL_REG_23_ATI                     = 0x8938;
        public const uint GL_REG_24_ATI                     = 0x8939;
        public const uint GL_REG_25_ATI                     = 0x893A;
        public const uint GL_REG_26_ATI                     = 0x893B;
        public const uint GL_REG_27_ATI                     = 0x893C;
        public const uint GL_REG_28_ATI                     = 0x893D;
        public const uint GL_REG_29_ATI                     = 0x893E;
        public const uint GL_REG_30_ATI                     = 0x893F;
        public const uint GL_REG_31_ATI                     = 0x8940;
        public const uint GL_CON_0_ATI                      = 0x8941;
        public const uint GL_CON_1_ATI                      = 0x8942;
        public const uint GL_CON_2_ATI                      = 0x8943;
        public const uint GL_CON_3_ATI                      = 0x8944;
        public const uint GL_CON_4_ATI                      = 0x8945;
        public const uint GL_CON_5_ATI                      = 0x8946;
        public const uint GL_CON_6_ATI                      = 0x8947;
        public const uint GL_CON_7_ATI                      = 0x8948;
        public const uint GL_CON_8_ATI                      = 0x8949;
        public const uint GL_CON_9_ATI                      = 0x894A;
        public const uint GL_CON_10_ATI                     = 0x894B;
        public const uint GL_CON_11_ATI                     = 0x894C;
        public const uint GL_CON_12_ATI                     = 0x894D;
        public const uint GL_CON_13_ATI                     = 0x894E;
        public const uint GL_CON_14_ATI                     = 0x894F;
        public const uint GL_CON_15_ATI                     = 0x8950;
        public const uint GL_CON_16_ATI                     = 0x8951;
        public const uint GL_CON_17_ATI                     = 0x8952;
        public const uint GL_CON_18_ATI                     = 0x8953;
        public const uint GL_CON_19_ATI                     = 0x8954;
        public const uint GL_CON_20_ATI                     = 0x8955;
        public const uint GL_CON_21_ATI                     = 0x8956;
        public const uint GL_CON_22_ATI                     = 0x8957;
        public const uint GL_CON_23_ATI                     = 0x8958;
        public const uint GL_CON_24_ATI                     = 0x8959;
        public const uint GL_CON_25_ATI                     = 0x895A;
        public const uint GL_CON_26_ATI                     = 0x895B;
        public const uint GL_CON_27_ATI                     = 0x895C;
        public const uint GL_CON_28_ATI                     = 0x895D;
        public const uint GL_CON_29_ATI                     = 0x895E;
        public const uint GL_CON_30_ATI                     = 0x895F;
        public const uint GL_CON_31_ATI                     = 0x8960;
        public const uint GL_MOV_ATI                        = 0x8961;
        public const uint GL_ADD_ATI                        = 0x8963;
        public const uint GL_MUL_ATI                        = 0x8964;
        public const uint GL_SUB_ATI                        = 0x8965;
        public const uint GL_DOT3_ATI                       = 0x8966;
        public const uint GL_DOT4_ATI                       = 0x8967;
        public const uint GL_MAD_ATI                        = 0x8968;
        public const uint GL_LERP_ATI                       = 0x8969;
        public const uint GL_CND_ATI                        = 0x896A;
        public const uint GL_CND0_ATI                       = 0x896B;
        public const uint GL_DOT2_ADD_ATI                   = 0x896C;
        public const uint GL_SECONDARY_INTERPOLATOR_ATI     = 0x896D;
        public const uint GL_NUM_FRAGMENT_REGISTERS_ATI     = 0x896E;
        public const uint GL_NUM_FRAGMENT_CONSTANTS_ATI     = 0x896F;
        public const uint GL_NUM_PASSES_ATI                 = 0x8970;
        public const uint GL_NUM_INSTRUCTIONS_PER_PASS_ATI  = 0x8971;
        public const uint GL_NUM_INSTRUCTIONS_TOTAL_ATI     = 0x8972;
        public const uint GL_NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI = 0x8973;
        public const uint GL_NUM_LOOPBACK_COMPONENTS_ATI    = 0x8974;
        public const uint GL_COLOR_ALPHA_PAIRING_ATI        = 0x8975;
        public const uint GL_SWIZZLE_STR_ATI                = 0x8976;
        public const uint GL_SWIZZLE_STQ_ATI                = 0x8977;
        public const uint GL_SWIZZLE_STR_DR_ATI             = 0x8978;
        public const uint GL_SWIZZLE_STQ_DQ_ATI             = 0x8979;
        public const uint GL_SWIZZLE_STRQ_ATI               = 0x897A;
        public const uint GL_SWIZZLE_STRQ_DQ_ATI            = 0x897B;
        public const uint GL_RED_BIT_ATI                    = 0x00000001;
        public const uint GL_GREEN_BIT_ATI                  = 0x00000002;
        public const uint GL_BLUE_BIT_ATI                   = 0x00000004;
        public const uint GL_2X_BIT_ATI                     = 0x00000001;
        public const uint GL_4X_BIT_ATI                     = 0x00000002;
        public const uint GL_8X_BIT_ATI                     = 0x00000004;
        public const uint GL_HALF_BIT_ATI                   = 0x00000008;
        public const uint GL_QUARTER_BIT_ATI                = 0x00000010;
        public const uint GL_EIGHTH_BIT_ATI                 = 0x00000020;
        public const uint GL_SATURATE_BIT_ATI               = 0x00000040;
        public const uint GL_COMP_BIT_ATI                   = 0x00000002;
        public const uint GL_NEGATE_BIT_ATI                 = 0x00000004;
        public const uint GL_BIAS_BIT_ATI                   = 0x00000008;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_pn_triangles
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PN_TRIANGLES_ATI                       = 0x87F0;
        public const uint GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F1;
        public const uint GL_PN_TRIANGLES_POINT_MODE_ATI            = 0x87F2;
        public const uint GL_PN_TRIANGLES_NORMAL_MODE_ATI           = 0x87F3;
        public const uint GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI     = 0x87F4;
        public const uint GL_PN_TRIANGLES_POINT_MODE_LINEAR_ATI     = 0x87F5;
        public const uint GL_PN_TRIANGLES_POINT_MODE_CUBIC_ATI      = 0x87F6;
        public const uint GL_PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI    = 0x87F7;
        public const uint GL_PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI = 0x87F8;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_vertex_array_object
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_STATIC_ATI                             = 0x8760;
        public const uint GL_DYNAMIC_ATI                            = 0x8761;
        public const uint GL_PRESERVE_ATI                           = 0x8762;
        public const uint GL_DISCARD_ATI                            = 0x8763;
        public const uint GL_OBJECT_BUFFER_SIZE_ATI                 = 0x8764;
        public const uint GL_OBJECT_BUFFER_USAGE_ATI                = 0x8765;
        public const uint GL_ARRAY_OBJECT_BUFFER_ATI                = 0x8766;
        public const uint GL_ARRAY_OBJECT_OFFSET_ATI                = 0x8767;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_vertex_streams
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_VERTEX_STREAMS_ATI                 = 0x876B;
        public const uint GL_VERTEX_STREAM0_ATI                     = 0x876C;
        public const uint GL_VERTEX_STREAM1_ATI                     = 0x876D;
        public const uint GL_VERTEX_STREAM2_ATI                     = 0x876E;
        public const uint GL_VERTEX_STREAM3_ATI                     = 0x876F;
        public const uint GL_VERTEX_STREAM4_ATI                     = 0x8770;
        public const uint GL_VERTEX_STREAM5_ATI                     = 0x8771;
        public const uint GL_VERTEX_STREAM6_ATI                     = 0x8772;
        public const uint GL_VERTEX_STREAM7_ATI                     = 0x8773;
        public const uint GL_VERTEX_SOURCE_ATI                      = 0x8774;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_element_array
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_ELEMENT_ARRAY_ATI                      = 0x8768;
        public const uint GL_ELEMENT_ARRAY_TYPE_ATI                 = 0x8769;
        public const uint GL_ELEMENT_ARRAY_POINTER_ATI              = 0x876A;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_text_fragment_shader
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXT_FRAGMENT_SHADER_ATI               = 0x8200;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_draw_buffers
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_DRAW_BUFFERS_ATI                   = 0x8824;
        public const uint GL_DRAW_BUFFER0_ATI                       = 0x8825;
        public const uint GL_DRAW_BUFFER1_ATI                       = 0x8826;
        public const uint GL_DRAW_BUFFER2_ATI                       = 0x8827;
        public const uint GL_DRAW_BUFFER3_ATI                       = 0x8828;
        public const uint GL_DRAW_BUFFER4_ATI                       = 0x8829;
        public const uint GL_DRAW_BUFFER5_ATI                       = 0x882A;
        public const uint GL_DRAW_BUFFER6_ATI                       = 0x882B;
        public const uint GL_DRAW_BUFFER7_ATI                       = 0x882C;
        public const uint GL_DRAW_BUFFER8_ATI                       = 0x882D;
        public const uint GL_DRAW_BUFFER9_ATI                       = 0x882E;
        public const uint GL_DRAW_BUFFER10_ATI                      = 0x882F;
        public const uint GL_DRAW_BUFFER11_ATI                      = 0x8830;
        public const uint GL_DRAW_BUFFER12_ATI                      = 0x8831;
        public const uint GL_DRAW_BUFFER13_ATI                      = 0x8832;
        public const uint GL_DRAW_BUFFER14_ATI                      = 0x8833;
        public const uint GL_DRAW_BUFFER15_ATI                      = 0x8834;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_pixel_format_float
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TYPE_RGBA_FLOAT_ATI                    = 0x8820;
        public const uint GL_COLOR_CLEAR_UNCLAMPED_VALUE_ATI        = 0x8835;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_texture_env_combine3
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MODULATE_ADD_ATI                       = 0x8744;
        public const uint GL_MODULATE_SIGNED_ADD_ATI                = 0x8745;
        public const uint GL_MODULATE_SUBTRACT_ATI                  = 0x8746;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_texture_float
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_RGBA_FLOAT32_ATI                       = 0x8814;
        public const uint GL_RGB_FLOAT32_ATI                        = 0x8815;
        public const uint GL_ALPHA_FLOAT32_ATI                      = 0x8816;
        public const uint GL_INTENSITY_FLOAT32_ATI                  = 0x8817;
        public const uint GL_LUMINANCE_FLOAT32_ATI                  = 0x8818;
        public const uint GL_LUMINANCE_ALPHA_FLOAT32_ATI            = 0x8819;
        public const uint GL_RGBA_FLOAT16_ATI                       = 0x881A;
        public const uint GL_RGB_FLOAT16_ATI                        = 0x881B;
        public const uint GL_ALPHA_FLOAT16_ATI                      = 0x881C;
        public const uint GL_INTENSITY_FLOAT16_ATI                  = 0x881D;
        public const uint GL_LUMINANCE_FLOAT16_ATI                  = 0x881E;
        public const uint GL_LUMINANCE_ALPHA_FLOAT16_ATI            = 0x881F;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_map_object_buffer (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_separate_stencil
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_STENCIL_BACK_FUNC_ATI                  = 0x8800;
        public const uint GL_STENCIL_BACK_FAIL_ATI                  = 0x8801;
        public const uint GL_STENCIL_BACK_PASS_DEPTH_FAIL_ATI       = 0x8802;
        public const uint GL_STENCIL_BACK_PASS_DEPTH_PASS_ATI       = 0x8803;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_vertex_attrib_array_object (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_meminfo
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VBO_FREE_MEMORY_ATI                    = 0x87FB;
        public const uint GL_TEXTURE_FREE_MEMORY_ATI                = 0x87FC;
        public const uint GL_RENDERBUFFER_FREE_MEMORY_ATI           = 0x87FD;

        ///////////////////////////////////////////////////////////////////////
        // GL_ATI_texture_compression_3dc
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COMPRESSED_RGB_3DC_ATI                 = 0x8837;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_EXT_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_abgr
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_ABGR_EXT                       = 0x8000;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_color
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CONSTANT_COLOR_EXT             = 0x8001;
        public const uint GL_ONE_MINUS_CONSTANT_COLOR_EXT   = 0x8002;
        public const uint GL_CONSTANT_ALPHA_EXT             = 0x8003;
        public const uint GL_ONE_MINUS_CONSTANT_ALPHA_EXT   = 0x8004;
        public const uint GL_BLEND_COLOR_EXT                = 0x8005;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_polygon_offset
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_POLYGON_OFFSET_EXT             = 0x8037;
        public const uint GL_POLYGON_OFFSET_FACTOR_EXT      = 0x8038;
        public const uint GL_POLYGON_OFFSET_BIAS_EXT        = 0x8039;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_ALPHA4_EXT                     = 0x803B;
        public const uint GL_ALPHA8_EXT                     = 0x803C;
        public const uint GL_ALPHA12_EXT                    = 0x803D;
        public const uint GL_ALPHA16_EXT                    = 0x803E;
        public const uint GL_LUMINANCE4_EXT                 = 0x803F;
        public const uint GL_LUMINANCE8_EXT                 = 0x8040;
        public const uint GL_LUMINANCE12_EXT                = 0x8041;
        public const uint GL_LUMINANCE16_EXT                = 0x8042;
        public const uint GL_LUMINANCE4_ALPHA4_EXT          = 0x8043;
        public const uint GL_LUMINANCE6_ALPHA2_EXT          = 0x8044;
        public const uint GL_LUMINANCE8_ALPHA8_EXT          = 0x8045;
        public const uint GL_LUMINANCE12_ALPHA4_EXT         = 0x8046;
        public const uint GL_LUMINANCE12_ALPHA12_EXT        = 0x8047;
        public const uint GL_LUMINANCE16_ALPHA16_EXT        = 0x8048;
        public const uint GL_INTENSITY_EXT                  = 0x8049;
        public const uint GL_INTENSITY4_EXT                 = 0x804A;
        public const uint GL_INTENSITY8_EXT                 = 0x804B;
        public const uint GL_INTENSITY12_EXT                = 0x804C;
        public const uint GL_INTENSITY16_EXT                = 0x804D;
        public const uint GL_RGB2_EXT                       = 0x804E;
        public const uint GL_RGB4_EXT                       = 0x804F;
        public const uint GL_RGB5_EXT                       = 0x8050;
        public const uint GL_RGB8_EXT                       = 0x8051;
        public const uint GL_RGB10_EXT                      = 0x8052;
        public const uint GL_RGB12_EXT                      = 0x8053;
        public const uint GL_RGB16_EXT                      = 0x8054;
        public const uint GL_RGBA2_EXT                      = 0x8055;
        public const uint GL_RGBA4_EXT                      = 0x8056;
        public const uint GL_RGB5_A1_EXT                    = 0x8057;
        public const uint GL_RGBA8_EXT                      = 0x8058;
        public const uint GL_RGB10_A2_EXT                   = 0x8059;
        public const uint GL_RGBA12_EXT                     = 0x805A;
        public const uint GL_RGBA16_EXT                     = 0x805B;
        public const uint GL_TEXTURE_RED_SIZE_EXT           = 0x805C;
        public const uint GL_TEXTURE_GREEN_SIZE_EXT         = 0x805D;
        public const uint GL_TEXTURE_BLUE_SIZE_EXT          = 0x805E;
        public const uint GL_TEXTURE_ALPHA_SIZE_EXT         = 0x805F;
        public const uint GL_TEXTURE_LUMINANCE_SIZE_EXT     = 0x8060;
        public const uint GL_TEXTURE_INTENSITY_SIZE_EXT     = 0x8061;
        public const uint GL_REPLACE_EXT                    = 0x8062;
        public const uint GL_PROXY_TEXTURE_1D_EXT           = 0x8063;
        public const uint GL_PROXY_TEXTURE_2D_EXT           = 0x8064;
        public const uint GL_TEXTURE_TOO_LARGE_EXT          = 0x8065;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture3D
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PACK_SKIP_IMAGES_EXT           = 0x806B;
        public const uint GL_PACK_IMAGE_HEIGHT_EXT          = 0x806C;
        public const uint GL_UNPACK_SKIP_IMAGES_EXT         = 0x806D;
        public const uint GL_UNPACK_IMAGE_HEIGHT_EXT        = 0x806E;
        public const uint GL_TEXTURE_3D_EXT                 = 0x806F;
        public const uint GL_PROXY_TEXTURE_3D_EXT           = 0x8070;
        public const uint GL_TEXTURE_DEPTH_EXT              = 0x8071;
        public const uint GL_TEXTURE_WRAP_R_EXT             = 0x8072;
        public const uint GL_MAX_3D_TEXTURE_SIZE_EXT        = 0x8073;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_subtexture (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_copy_texture (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_histogram
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_HISTOGRAM_EXT                  = 0x8024;
        public const uint GL_PROXY_HISTOGRAM_EXT            = 0x8025;
        public const uint GL_HISTOGRAM_WIDTH_EXT            = 0x8026;
        public const uint GL_HISTOGRAM_FORMAT_EXT           = 0x8027;
        public const uint GL_HISTOGRAM_RED_SIZE_EXT         = 0x8028;
        public const uint GL_HISTOGRAM_GREEN_SIZE_EXT       = 0x8029;
        public const uint GL_HISTOGRAM_BLUE_SIZE_EXT        = 0x802A;
        public const uint GL_HISTOGRAM_ALPHA_SIZE_EXT       = 0x802B;
        public const uint GL_HISTOGRAM_LUMINANCE_SIZE_EXT   = 0x802C;
        public const uint GL_HISTOGRAM_SINK_EXT             = 0x802D;
        public const uint GL_MINMAX_EXT                     = 0x802E;
        public const uint GL_MINMAX_FORMAT_EXT              = 0x802F;
        public const uint GL_MINMAX_SINK_EXT                = 0x8030;
        public const uint GL_TABLE_TOO_LARGE_EXT            = 0x8031;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_convolution
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CONVOLUTION_1D_EXT             = 0x8010;
        public const uint GL_CONVOLUTION_2D_EXT             = 0x8011;
        public const uint GL_SEPARABLE_2D_EXT               = 0x8012;
        public const uint GL_CONVOLUTION_BORDER_MODE_EXT    = 0x8013;
        public const uint GL_CONVOLUTION_FILTER_SCALE_EXT   = 0x8014;
        public const uint GL_CONVOLUTION_FILTER_BIAS_EXT    = 0x8015;
        public const uint GL_REDUCE_EXT                     = 0x8016;
        public const uint GL_CONVOLUTION_FORMAT_EXT         = 0x8017;
        public const uint GL_CONVOLUTION_WIDTH_EXT          = 0x8018;
        public const uint GL_CONVOLUTION_HEIGHT_EXT         = 0x8019;
        public const uint GL_MAX_CONVOLUTION_WIDTH_EXT      = 0x801A;
        public const uint GL_MAX_CONVOLUTION_HEIGHT_EXT     = 0x801B;
        public const uint GL_POST_CONVOLUTION_RED_SCALE_EXT = 0x801C;
        public const uint GL_POST_CONVOLUTION_GREEN_SCALE_EXT = 0x801D;
        public const uint GL_POST_CONVOLUTION_BLUE_SCALE_EXT = 0x801E;
        public const uint GL_POST_CONVOLUTION_ALPHA_SCALE_EXT = 0x801F;
        public const uint GL_POST_CONVOLUTION_RED_BIAS_EXT  = 0x8020;
        public const uint GL_POST_CONVOLUTION_GREEN_BIAS_EXT = 0x8021;
        public const uint GL_POST_CONVOLUTION_BLUE_BIAS_EXT = 0x8022;
        public const uint GL_POST_CONVOLUTION_ALPHA_BIAS_EXT = 0x8023;
        
        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_cmyka
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CMYK_EXT                       = 0x800C;
        public const uint GL_CMYKA_EXT                      = 0x800D;
        public const uint GL_PACK_CMYK_HINT_EXT             = 0x800E;
        public const uint GL_UNPACK_CMYK_HINT_EXT           = 0x800F;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_object
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_PRIORITY_EXT           = 0x8066;
        public const uint GL_TEXTURE_RESIDENT_EXT           = 0x8067;
        public const uint GL_TEXTURE_1D_BINDING_EXT         = 0x8068;
        public const uint GL_TEXTURE_2D_BINDING_EXT         = 0x8069;
        public const uint GL_TEXTURE_3D_BINDING_EXT         = 0x806A;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_packed_pixels
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_UNSIGNED_BYTE_3_3_2_EXT        = 0x8032;
        public const uint GL_UNSIGNED_SHORT_4_4_4_4_EXT     = 0x8033;
        public const uint GL_UNSIGNED_SHORT_5_5_5_1_EXT     = 0x8034;
        public const uint GL_UNSIGNED_INT_8_8_8_8_EXT       = 0x8035;
        public const uint GL_UNSIGNED_INT_10_10_10_2_EXT    = 0x8036;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_rescale_normal
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_RESCALE_NORMAL_EXT             = 0x803A;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_vertex_array
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_ARRAY_EXT               = 0x8074;
        public const uint GL_NORMAL_ARRAY_EXT               = 0x8075;
        public const uint GL_COLOR_ARRAY_EXT                = 0x8076;
        public const uint GL_INDEX_ARRAY_EXT                = 0x8077;
        public const uint GL_TEXTURE_COORD_ARRAY_EXT        = 0x8078;
        public const uint GL_EDGE_FLAG_ARRAY_EXT            = 0x8079;
        public const uint GL_VERTEX_ARRAY_SIZE_EXT          = 0x807A;
        public const uint GL_VERTEX_ARRAY_TYPE_EXT          = 0x807B;
        public const uint GL_VERTEX_ARRAY_STRIDE_EXT        = 0x807C;
        public const uint GL_VERTEX_ARRAY_COUNT_EXT         = 0x807D;
        public const uint GL_NORMAL_ARRAY_TYPE_EXT          = 0x807E;
        public const uint GL_NORMAL_ARRAY_STRIDE_EXT        = 0x807F;
        public const uint GL_NORMAL_ARRAY_COUNT_EXT         = 0x8080;
        public const uint GL_COLOR_ARRAY_SIZE_EXT           = 0x8081;
        public const uint GL_COLOR_ARRAY_TYPE_EXT           = 0x8082;
        public const uint GL_COLOR_ARRAY_STRIDE_EXT         = 0x8083;
        public const uint GL_COLOR_ARRAY_COUNT_EXT          = 0x8084;
        public const uint GL_INDEX_ARRAY_TYPE_EXT           = 0x8085;
        public const uint GL_INDEX_ARRAY_STRIDE_EXT         = 0x8086;
        public const uint GL_INDEX_ARRAY_COUNT_EXT          = 0x8087;
        public const uint GL_TEXTURE_COORD_ARRAY_SIZE_EXT   = 0x8088;
        public const uint GL_TEXTURE_COORD_ARRAY_TYPE_EXT   = 0x8089;
        public const uint GL_TEXTURE_COORD_ARRAY_STRIDE_EXT = 0x808A;
        public const uint GL_TEXTURE_COORD_ARRAY_COUNT_EXT  = 0x808B;
        public const uint GL_EDGE_FLAG_ARRAY_STRIDE_EXT     = 0x808C;
        public const uint GL_EDGE_FLAG_ARRAY_COUNT_EXT      = 0x808D;
        public const uint GL_VERTEX_ARRAY_POINTER_EXT       = 0x808E;
        public const uint GL_NORMAL_ARRAY_POINTER_EXT       = 0x808F;
        public const uint GL_COLOR_ARRAY_POINTER_EXT        = 0x8090;
        public const uint GL_INDEX_ARRAY_POINTER_EXT        = 0x8091;
        public const uint GL_TEXTURE_COORD_ARRAY_POINTER_EXT = 0x8092;
        public const uint GL_EDGE_FLAG_ARRAY_POINTER_EXT    = 0x8093;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_misc_attribute (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_minmax
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FUNC_ADD_EXT                   = 0x8006;
        public const uint GL_MIN_EXT                        = 0x8007;
        public const uint GL_MAX_EXT                        = 0x8008;
        public const uint GL_BLEND_EQUATION_EXT             = 0x8009;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_subtract
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FUNC_SUBTRACT_EXT              = 0x800A;
        public const uint GL_FUNC_REVERSE_SUBTRACT_EXT      = 0x800B;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_logic_op (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_point_parameters
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_POINT_SIZE_MIN_EXT             = 0x8126;
        public const uint GL_POINT_SIZE_MAX_EXT             = 0x8127;
        public const uint GL_POINT_FADE_THRESHOLD_SIZE_EXT  = 0x8128;
        public const uint GL_DISTANCE_ATTENUATION_EXT       = 0x8129;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_color_subtable (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_paletted_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COLOR_INDEX1_EXT               = 0x80E2;
        public const uint GL_COLOR_INDEX2_EXT               = 0x80E3;
        public const uint GL_COLOR_INDEX4_EXT               = 0x80E4;
        public const uint GL_COLOR_INDEX8_EXT               = 0x80E5;
        public const uint GL_COLOR_INDEX12_EXT              = 0x80E6;
        public const uint GL_COLOR_INDEX16_EXT              = 0x80E7;
        public const uint GL_TEXTURE_INDEX_SIZE_EXT         = 0x80ED;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_clip_volume_hint
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CLIP_VOLUME_CLIPPING_HINT_EXT  = 0x80F0;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_index_texture (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_index_material
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_INDEX_MATERIAL_EXT             = 0x81B8;
        public const uint GL_INDEX_MATERIAL_PARAMETER_EXT   = 0x81B9;
        public const uint GL_INDEX_MATERIAL_FACE_EXT        = 0x81BA;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_index_func
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_INDEX_TEST_EXT                 = 0x81B5;
        public const uint GL_INDEX_TEST_FUNC_EXT            = 0x81B6;
        public const uint GL_INDEX_TEST_REF_EXT             = 0x81B7;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_index_array_formats
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_IUI_V2F_EXT                    = 0x81AD;
        public const uint GL_IUI_V3F_EXT                    = 0x81AE;
        public const uint GL_IUI_N3F_V2F_EXT                = 0x81AF;
        public const uint GL_IUI_N3F_V3F_EXT                = 0x81B0;
        public const uint GL_T2F_IUI_V2F_EXT                = 0x81B1;
        public const uint GL_T2F_IUI_V3F_EXT                = 0x81B2;
        public const uint GL_T2F_IUI_N3F_V2F_EXT            = 0x81B3;
        public const uint GL_T2F_IUI_N3F_V3F_EXT            = 0x81B4;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_compiled_vertex_array
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_ARRAY_ELEMENT_LOCK_FIRST_EXT   = 0x81A8;
        public const uint GL_ARRAY_ELEMENT_LOCK_COUNT_EXT   = 0x81A9;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_cull_vertex
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CULL_VERTEX_EXT                    = 0x81AA;
        public const uint GL_CULL_VERTEX_EYE_POSITION_EXT       = 0x81AB;
        public const uint GL_CULL_VERTEX_OBJECT_POSITION_EXT    = 0x81AC;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_draw_range_elements
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_ELEMENTS_VERTICES_EXT      = 0x80E8;
        public const uint GL_MAX_ELEMENTS_INDICES_EXT       = 0x80E9;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_light_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FRAGMENT_MATERIAL_EXT          = 0x8349;
        public const uint GL_FRAGMENT_NORMAL_EXT            = 0x834A;
        public const uint GL_FRAGMENT_COLOR_EXT             = 0x834C;
        public const uint GL_ATTENUATION_EXT                = 0x834D;
        public const uint GL_SHADOW_ATTENUATION_EXT         = 0x834E;
        public const uint GL_TEXTURE_APPLICATION_MODE_EXT   = 0x834F;
        public const uint GL_TEXTURE_LIGHT_EXT              = 0x8350;
        public const uint GL_TEXTURE_MATERIAL_FACE_EXT      = 0x8351;
        public const uint GL_TEXTURE_MATERIAL_PARAMETER_EXT = 0x8352;
        /* reuse GL_FRAGMENT_DEPTH_EXT */

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_bgra
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_BGR_EXT = 0x80E0;
        public const uint GL_BGRA_EXT = 0x80E1;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_format_BGRA8888
        ///////////////////////////////////////////////////////////////////////
        /* Defined in GL_EXT_bgra
        public const uint GL_BGR_EXT = 0x80E0;
        public const uint GL_BGRA_EXT = 0x80E1;
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_pixel_transform
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PIXEL_TRANSFORM_2D_EXT         = 0x8330;
        public const uint GL_PIXEL_MAG_FILTER_EXT           = 0x8331;
        public const uint GL_PIXEL_MIN_FILTER_EXT           = 0x8332;
        public const uint GL_PIXEL_CUBIC_WEIGHT_EXT         = 0x8333;
        public const uint GL_CUBIC_EXT                      = 0x8334;
        public const uint GL_AVERAGE_EXT                    = 0x8335;
        public const uint GL_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8336;
        public const uint GL_MAX_PIXEL_TRANSFORM_2D_STACK_DEPTH_EXT = 0x8337;
        public const uint GL_PIXEL_TRANSFORM_2D_MATRIX_EXT  = 0x8338;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_pixel_transform_color_table (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_shared_texture_palette
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SHARED_TEXTURE_PALETTE_EXT     = 0x81FB;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_separate_specular_color
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_LIGHT_MODEL_COLOR_CONTROL_EXT  = 0x81F8;
        public const uint GL_SINGLE_COLOR_EXT               = 0x81F9;
        public const uint GL_SEPARATE_SPECULAR_COLOR_EXT    = 0x81FA;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_secondary_color
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COLOR_SUM_EXT                  = 0x8458;
        public const uint GL_CURRENT_SECONDARY_COLOR_EXT    = 0x8459;
        public const uint GL_SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A;
        public const uint GL_SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B;
        public const uint GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C;
        public const uint GL_SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D;
        public const uint GL_SECONDARY_COLOR_ARRAY_EXT      = 0x845E;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_perturb_normal
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PERTURB_EXT                    = 0x85AE;
        public const uint GL_TEXTURE_NORMAL_EXT             = 0x85AF;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_multi_draw_arrays (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_fog_coord
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FOG_COORDINATE_SOURCE_EXT      = 0x8450;
        public const uint GL_FOG_COORDINATE_EXT             = 0x8451;
        public const uint GL_FRAGMENT_DEPTH_EXT             = 0x8452;
        public const uint GL_CURRENT_FOG_COORDINATE_EXT     = 0x8453;
        public const uint GL_FOG_COORDINATE_ARRAY_TYPE_EXT  = 0x8454;
        public const uint GL_FOG_COORDINATE_ARRAY_STRIDE_EXT = 0x8455;
        public const uint GL_FOG_COORDINATE_ARRAY_POINTER_EXT = 0x8456;
        public const uint GL_FOG_COORDINATE_ARRAY_EXT       = 0x8457;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_coordinate_frame
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TANGENT_ARRAY_EXT              = 0x8439;
        public const uint GL_BINORMAL_ARRAY_EXT             = 0x843A;
        public const uint GL_CURRENT_TANGENT_EXT            = 0x843B;
        public const uint GL_CURRENT_BINORMAL_EXT           = 0x843C;
        public const uint GL_TANGENT_ARRAY_TYPE_EXT         = 0x843E;
        public const uint GL_TANGENT_ARRAY_STRIDE_EXT       = 0x843F;
        public const uint GL_BINORMAL_ARRAY_TYPE_EXT        = 0x8440;
        public const uint GL_BINORMAL_ARRAY_STRIDE_EXT      = 0x8441;
        public const uint GL_TANGENT_ARRAY_POINTER_EXT      = 0x8442;
        public const uint GL_BINORMAL_ARRAY_POINTER_EXT     = 0x8443;
        public const uint GL_MAP1_TANGENT_EXT               = 0x8444;
        public const uint GL_MAP2_TANGENT_EXT               = 0x8445;
        public const uint GL_MAP1_BINORMAL_EXT              = 0x8446;
        public const uint GL_MAP2_BINORMAL_EXT              = 0x8447;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_env_combine
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COMBINE_EXT                    = 0x8570;
        public const uint GL_COMBINE_RGB_EXT                = 0x8571;
        public const uint GL_COMBINE_ALPHA_EXT              = 0x8572;
        public const uint GL_RGB_SCALE_EXT                  = 0x8573;
        public const uint GL_ADD_SIGNED_EXT                 = 0x8574;
        public const uint GL_INTERPOLATE_EXT                = 0x8575;
        public const uint GL_CONSTANT_EXT                   = 0x8576;
        public const uint GL_PRIMARY_COLOR_EXT              = 0x8577;
        public const uint GL_PREVIOUS_EXT                   = 0x8578;
        public const uint GL_SOURCE0_RGB_EXT                = 0x8580;
        public const uint GL_SOURCE1_RGB_EXT                = 0x8581;
        public const uint GL_SOURCE2_RGB_EXT                = 0x8582;
        public const uint GL_SOURCE0_ALPHA_EXT              = 0x8588;
        public const uint GL_SOURCE1_ALPHA_EXT              = 0x8589;
        public const uint GL_SOURCE2_ALPHA_EXT              = 0x858A;
        public const uint GL_OPERAND0_RGB_EXT               = 0x8590;
        public const uint GL_OPERAND1_RGB_EXT               = 0x8591;
        public const uint GL_OPERAND2_RGB_EXT               = 0x8592;
        public const uint GL_OPERAND0_ALPHA_EXT             = 0x8598;
        public const uint GL_OPERAND1_ALPHA_EXT             = 0x8599;
        public const uint GL_OPERAND2_ALPHA_EXT             = 0x859A;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_func_separate
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_BLEND_DST_RGB_EXT              = 0x80C8;
        public const uint GL_BLEND_SRC_RGB_EXT              = 0x80C9;
        public const uint GL_BLEND_DST_ALPHA_EXT            = 0x80CA;
        public const uint GL_BLEND_SRC_ALPHA_EXT            = 0x80CB;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_stencil_wrap
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_INCR_WRAP_EXT                  = 0x8507;
        public const uint GL_DECR_WRAP_EXT                  = 0x8508;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_422_pixels
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_422_EXT                        = 0x80CC;
        public const uint GL_422_REV_EXT                    = 0x80CD;
        public const uint GL_422_AVERAGE_EXT                = 0x80CE;
        public const uint GL_422_REV_AVERAGE_EXT            = 0x80CF;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_cube_map
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_NORMAL_MAP_EXT                 = 0x8511;
        public const uint GL_REFLECTION_MAP_EXT             = 0x8512;
        public const uint GL_TEXTURE_CUBE_MAP_EXT           = 0x8513;
        public const uint GL_TEXTURE_BINDING_CUBE_MAP_EXT   = 0x8514;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X_EXT = 0x8515;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X_EXT = 0x8516;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y_EXT = 0x8517;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_EXT = 0x8518;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z_EXT = 0x8519;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_EXT = 0x851A;
        public const uint GL_PROXY_TEXTURE_CUBE_MAP_EXT     = 0x851B;
        public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE_EXT  = 0x851C;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_env_add (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_lod_bias
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_TEXTURE_LOD_BIAS_EXT       = 0x84FD;
        public const uint GL_TEXTURE_FILTER_CONTROL_EXT     = 0x8500;
        public const uint GL_TEXTURE_LOD_BIAS_EXT           = 0x8501;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_filter_anisotropic
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_MAX_ANISOTROPY_EXT     = 0x84FE;
        public const uint GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_vertex_weighting
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MODELVIEW0_STACK_DEPTH_EXT     = GL_MODELVIEW_STACK_DEPTH;
        public const uint GL_MODELVIEW1_STACK_DEPTH_EXT     = 0x8502;
        public const uint GL_MODELVIEW0_MATRIX_EXT          = GL_MODELVIEW_MATRIX;
        public const uint GL_MODELVIEW1_MATRIX_EXT          = 0x8506;
        public const uint GL_VERTEX_WEIGHTING_EXT           = 0x8509;
        public const uint GL_MODELVIEW0_EXT                 = GL_MODELVIEW;
        public const uint GL_MODELVIEW1_EXT                 = 0x850A;
        public const uint GL_CURRENT_VERTEX_WEIGHT_EXT      = 0x850B;
        public const uint GL_VERTEX_WEIGHT_ARRAY_EXT        = 0x850C;
        public const uint GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT   = 0x850D;
        public const uint GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT   = 0x850E;
        public const uint GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT = 0x850F;
        public const uint GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT = 0x8510;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_compression_dxt1
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COMPRESSED_RGB_S3TC_DXT1_EXT   = 0x83F0;
        public const uint GL_COMPRESSED_RGBA_S3TC_DXT1_EXT  = 0x83F1;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_compression_s3tc
        ///////////////////////////////////////////////////////////////////////
        /* Defined in GL_EXT_texture_compression_dxt1
        public const uint GL_COMPRESSED_RGB_S3TC_DXT1_EXT   = 0x83F0;
        public const uint GL_COMPRESSED_RGBA_S3TC_DXT1_EXT  = 0x83F1;
        */
        public const uint GL_COMPRESSED_RGBA_S3TC_DXT3_EXT  = 0x83F2;
        public const uint GL_COMPRESSED_RGBA_S3TC_DXT5_EXT  = 0x83F3;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_multisample
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MULTISAMPLE_EXT                = 0x809D;
        public const uint GL_SAMPLE_ALPHA_TO_MASK_EXT       = 0x809E;
        public const uint GL_SAMPLE_ALPHA_TO_ONE_EXT        = 0x809F;
        public const uint GL_SAMPLE_MASK_EXT                = 0x80A0;
        public const uint GL_1PASS_EXT                      = 0x80A1;
        public const uint GL_2PASS_0_EXT                    = 0x80A2;
        public const uint GL_2PASS_1_EXT                    = 0x80A3;
        public const uint GL_4PASS_0_EXT                    = 0x80A4;
        public const uint GL_4PASS_1_EXT                    = 0x80A5;
        public const uint GL_4PASS_2_EXT                    = 0x80A6;
        public const uint GL_4PASS_3_EXT                    = 0x80A7;
        public const uint GL_SAMPLE_BUFFERS_EXT             = 0x80A8;
        public const uint GL_SAMPLES_EXT                    = 0x80A9;
        public const uint GL_SAMPLE_MASK_VALUE_EXT          = 0x80AA;
        public const uint GL_SAMPLE_MASK_INVERT_EXT         = 0x80AB;
        public const uint GL_SAMPLE_PATTERN_EXT             = 0x80AC;
        public const uint GL_MULTISAMPLE_BIT_EXT            = 0x20000000;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_env_dot3
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DOT3_RGB_EXT                   = 0x8740;
        public const uint GL_DOT3_RGBA_EXT                  = 0x8741;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_vertex_shader
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_SHADER_EXT              = 0x8780;
        public const uint GL_VERTEX_SHADER_BINDING_EXT      = 0x8781;
        public const uint GL_OP_INDEX_EXT                   = 0x8782;
        public const uint GL_OP_NEGATE_EXT                  = 0x8783;
        public const uint GL_OP_DOT3_EXT                    = 0x8784;
        public const uint GL_OP_DOT4_EXT                    = 0x8785;
        public const uint GL_OP_MUL_EXT                     = 0x8786;
        public const uint GL_OP_ADD_EXT                     = 0x8787;
        public const uint GL_OP_MADD_EXT                    = 0x8788;
        public const uint GL_OP_FRAC_EXT                    = 0x8789;
        public const uint GL_OP_MAX_EXT                     = 0x878A;
        public const uint GL_OP_MIN_EXT                     = 0x878B;
        public const uint GL_OP_SET_GE_EXT                  = 0x878C;
        public const uint GL_OP_SET_LT_EXT                  = 0x878D;
        public const uint GL_OP_CLAMP_EXT                   = 0x878E;
        public const uint GL_OP_FLOOR_EXT                   = 0x878F;
        public const uint GL_OP_ROUND_EXT                   = 0x8790;
        public const uint GL_OP_EXP_BASE_2_EXT              = 0x8791;
        public const uint GL_OP_LOG_BASE_2_EXT              = 0x8792;
        public const uint GL_OP_POWER_EXT                   = 0x8793;
        public const uint GL_OP_RECIP_EXT                   = 0x8794;
        public const uint GL_OP_RECIP_SQRT_EXT              = 0x8795;
        public const uint GL_OP_SUB_EXT                     = 0x8796;
        public const uint GL_OP_CROSS_PRODUCT_EXT           = 0x8797;
        public const uint GL_OP_MULTIPLY_MATRIX_EXT         = 0x8798;
        public const uint GL_OP_MOV_EXT                     = 0x8799;
        public const uint GL_OUTPUT_VERTEX_EXT              = 0x879A;
        public const uint GL_OUTPUT_COLOR0_EXT              = 0x879B;
        public const uint GL_OUTPUT_COLOR1_EXT              = 0x879C;
        public const uint GL_OUTPUT_TEXTURE_COORD0_EXT      = 0x879D;
        public const uint GL_OUTPUT_TEXTURE_COORD1_EXT      = 0x879E;
        public const uint GL_OUTPUT_TEXTURE_COORD2_EXT      = 0x879F;
        public const uint GL_OUTPUT_TEXTURE_COORD3_EXT      = 0x87A0;
        public const uint GL_OUTPUT_TEXTURE_COORD4_EXT      = 0x87A1;
        public const uint GL_OUTPUT_TEXTURE_COORD5_EXT      = 0x87A2;
        public const uint GL_OUTPUT_TEXTURE_COORD6_EXT      = 0x87A3;
        public const uint GL_OUTPUT_TEXTURE_COORD7_EXT      = 0x87A4;
        public const uint GL_OUTPUT_TEXTURE_COORD8_EXT      = 0x87A5;
        public const uint GL_OUTPUT_TEXTURE_COORD9_EXT      = 0x87A6;
        public const uint GL_OUTPUT_TEXTURE_COORD10_EXT     = 0x87A7;
        public const uint GL_OUTPUT_TEXTURE_COORD11_EXT     = 0x87A8;
        public const uint GL_OUTPUT_TEXTURE_COORD12_EXT     = 0x87A9;
        public const uint GL_OUTPUT_TEXTURE_COORD13_EXT     = 0x87AA;
        public const uint GL_OUTPUT_TEXTURE_COORD14_EXT     = 0x87AB;
        public const uint GL_OUTPUT_TEXTURE_COORD15_EXT     = 0x87AC;
        public const uint GL_OUTPUT_TEXTURE_COORD16_EXT     = 0x87AD;
        public const uint GL_OUTPUT_TEXTURE_COORD17_EXT     = 0x87AE;
        public const uint GL_OUTPUT_TEXTURE_COORD18_EXT     = 0x87AF;
        public const uint GL_OUTPUT_TEXTURE_COORD19_EXT     = 0x87B0;
        public const uint GL_OUTPUT_TEXTURE_COORD20_EXT     = 0x87B1;
        public const uint GL_OUTPUT_TEXTURE_COORD21_EXT     = 0x87B2;
        public const uint GL_OUTPUT_TEXTURE_COORD22_EXT     = 0x87B3;
        public const uint GL_OUTPUT_TEXTURE_COORD23_EXT     = 0x87B4;
        public const uint GL_OUTPUT_TEXTURE_COORD24_EXT     = 0x87B5;
        public const uint GL_OUTPUT_TEXTURE_COORD25_EXT     = 0x87B6;
        public const uint GL_OUTPUT_TEXTURE_COORD26_EXT     = 0x87B7;
        public const uint GL_OUTPUT_TEXTURE_COORD27_EXT     = 0x87B8;
        public const uint GL_OUTPUT_TEXTURE_COORD28_EXT     = 0x87B9;
        public const uint GL_OUTPUT_TEXTURE_COORD29_EXT     = 0x87BA;
        public const uint GL_OUTPUT_TEXTURE_COORD30_EXT     = 0x87BB;
        public const uint GL_OUTPUT_TEXTURE_COORD31_EXT     = 0x87BC;
        public const uint GL_OUTPUT_FOG_EXT                 = 0x87BD;
        public const uint GL_SCALAR_EXT                     = 0x87BE;
        public const uint GL_VECTOR_EXT                     = 0x87BF;
        public const uint GL_MATRIX_EXT                     = 0x87C0;
        public const uint GL_VARIANT_EXT                    = 0x87C1;
        public const uint GL_INVARIANT_EXT                  = 0x87C2;
        public const uint GL_LOCAL_CONSTANT_EXT             = 0x87C3;
        public const uint GL_LOCAL_EXT                      = 0x87C4;
        public const uint GL_MAX_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87C5;
        public const uint GL_MAX_VERTEX_SHADER_VARIANTS_EXT = 0x87C6;
        public const uint GL_MAX_VERTEX_SHADER_INVARIANTS_EXT = 0x87C7;
        public const uint GL_MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87C8;
        public const uint GL_MAX_VERTEX_SHADER_LOCALS_EXT   = 0x87C9;
        public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CA;
        public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT = 0x87CB;
        public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87CC;
        public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT = 0x87CD;
        public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT = 0x87CE;
        public const uint GL_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CF;
        public const uint GL_VERTEX_SHADER_VARIANTS_EXT     = 0x87D0;
        public const uint GL_VERTEX_SHADER_INVARIANTS_EXT   = 0x87D1;
        public const uint GL_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87D2;
        public const uint GL_VERTEX_SHADER_LOCALS_EXT       = 0x87D3;
        public const uint GL_VERTEX_SHADER_OPTIMIZED_EXT    = 0x87D4;
        public const uint GL_X_EXT                          = 0x87D5;
        public const uint GL_Y_EXT                          = 0x87D6;
        public const uint GL_Z_EXT                          = 0x87D7;
        public const uint GL_W_EXT                          = 0x87D8;
        public const uint GL_NEGATIVE_X_EXT                 = 0x87D9;
        public const uint GL_NEGATIVE_Y_EXT                 = 0x87DA;
        public const uint GL_NEGATIVE_Z_EXT                 = 0x87DB;
        public const uint GL_NEGATIVE_W_EXT                 = 0x87DC;
        public const uint GL_ZERO_EXT                       = 0x87DD;
        public const uint GL_ONE_EXT                        = 0x87DE;
        public const uint GL_NEGATIVE_ONE_EXT               = 0x87DF;
        public const uint GL_NORMALIZED_RANGE_EXT           = 0x87E0;
        public const uint GL_FULL_RANGE_EXT                 = 0x87E1;
        public const uint GL_CURRENT_VERTEX_EXT             = 0x87E2;
        public const uint GL_MVP_MATRIX_EXT                 = 0x87E3;
        public const uint GL_VARIANT_VALUE_EXT              = 0x87E4;
        public const uint GL_VARIANT_DATATYPE_EXT           = 0x87E5;
        public const uint GL_VARIANT_ARRAY_STRIDE_EXT       = 0x87E6;
        public const uint GL_VARIANT_ARRAY_TYPE_EXT         = 0x87E7;
        public const uint GL_VARIANT_ARRAY_EXT              = 0x87E8;
        public const uint GL_VARIANT_ARRAY_POINTER_EXT      = 0x87E9;
        public const uint GL_INVARIANT_VALUE_EXT            = 0x87EA;
        public const uint GL_INVARIANT_DATATYPE_EXT         = 0x87EB;
        public const uint GL_LOCAL_CONSTANT_VALUE_EXT       = 0x87EC;
        public const uint GL_LOCAL_CONSTANT_DATATYPE_EXT    = 0x87ED;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_shadow_funcs (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_stencil_two_side
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_STENCIL_TEST_TWO_SIDE_EXT      = 0x8910;
        public const uint GL_ACTIVE_STENCIL_FACE_EXT        = 0x8911;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_depth_bounds_test
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DEPTH_BOUNDS_TEST_EXT          = 0x8890;
        public const uint GL_DEPTH_BOUNDS_EXT               = 0x8891;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_mirror_clamp
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MIRROR_CLAMP_EXT               = 0x8742;
        public const uint GL_MIRROR_CLAMP_TO_EDGE_EXT       = 0x8743;
        public const uint GL_MIRROR_CLAMP_TO_BORDER_EXT     = 0x8912;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_blend_equation_separate
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_BLEND_EQUATION_RGB_EXT         = 0x8009;
        public const uint GL_BLEND_EQUATION_ALPHA_EXT       = 0x883D;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_pixel_buffer_object
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PIXEL_PACK_BUFFER_EXT              = 0x88EB;
        public const uint GL_PIXEL_UNPACK_BUFFER_EXT            = 0x88EC;
        public const uint GL_PIXEL_PACK_BUFFER_BINDING_EXT      = 0x88ED;
        public const uint GL_PIXEL_UNPACK_BUFFER_BINDING_EXT    = 0x88EF;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_framebuffer_object
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506;
        public const uint GL_MAX_RENDERBUFFER_SIZE_EXT      = 0x84E8;
        public const uint GL_FRAMEBUFFER_BINDING_EXT        = 0x8CA6;
        public const uint GL_RENDERBUFFER_BINDING_EXT       = 0x8CA7;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT = 0x8CD0;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT = 0x8CD1;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT = 0x8CD2;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT = 0x8CD3;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_EXT = 0x8CD4;
        public const uint GL_FRAMEBUFFER_COMPLETE_EXT       = 0x8CD5;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT = 0x8CD6;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT = 0x8CD7;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT = 0x8CD9;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT = 0x8CDB;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT = 0x8CDC;
        public const uint GL_FRAMEBUFFER_UNSUPPORTED_EXT    = 0x8CDD;
        public const uint GL_MAX_COLOR_ATTACHMENTS_EXT      = 0x8CDF;
        public const uint GL_COLOR_ATTACHMENT0_EXT          = 0x8CE0;
        public const uint GL_COLOR_ATTACHMENT1_EXT          = 0x8CE1;
        public const uint GL_COLOR_ATTACHMENT2_EXT          = 0x8CE2;
        public const uint GL_COLOR_ATTACHMENT3_EXT          = 0x8CE3;
        public const uint GL_COLOR_ATTACHMENT4_EXT          = 0x8CE4;
        public const uint GL_COLOR_ATTACHMENT5_EXT          = 0x8CE5;
        public const uint GL_COLOR_ATTACHMENT6_EXT          = 0x8CE6;
        public const uint GL_COLOR_ATTACHMENT7_EXT          = 0x8CE7;
        public const uint GL_COLOR_ATTACHMENT8_EXT          = 0x8CE8;
        public const uint GL_COLOR_ATTACHMENT9_EXT          = 0x8CE9;
        public const uint GL_COLOR_ATTACHMENT10_EXT         = 0x8CEA;
        public const uint GL_COLOR_ATTACHMENT11_EXT         = 0x8CEB;
        public const uint GL_COLOR_ATTACHMENT12_EXT         = 0x8CEC;
        public const uint GL_COLOR_ATTACHMENT13_EXT         = 0x8CED;
        public const uint GL_COLOR_ATTACHMENT14_EXT         = 0x8CEE;
        public const uint GL_COLOR_ATTACHMENT15_EXT         = 0x8CEF;
        public const uint GL_DEPTH_ATTACHMENT_EXT           = 0x8D00;
        public const uint GL_STENCIL_ATTACHMENT_EXT         = 0x8D20;
        public const uint GL_FRAMEBUFFER_EXT                = 0x8D40;
        public const uint GL_RENDERBUFFER_EXT               = 0x8D41;
        public const uint GL_RENDERBUFFER_WIDTH_EXT         = 0x8D42;
        public const uint GL_RENDERBUFFER_HEIGHT_EXT        = 0x8D43;
        public const uint GL_RENDERBUFFER_INTERNAL_FORMAT_EXT = 0x8D44;
        public const uint GL_STENCIL_INDEX1_EXT             = 0x8D46;
        public const uint GL_STENCIL_INDEX4_EXT             = 0x8D47;
        public const uint GL_STENCIL_INDEX8_EXT             = 0x8D48;
        public const uint GL_STENCIL_INDEX16_EXT            = 0x8D49;
        public const uint GL_RENDERBUFFER_RED_SIZE_EXT      = 0x8D50;
        public const uint GL_RENDERBUFFER_GREEN_SIZE_EXT    = 0x8D51;
        public const uint GL_RENDERBUFFER_BLUE_SIZE_EXT     = 0x8D52;
        public const uint GL_RENDERBUFFER_ALPHA_SIZE_EXT    = 0x8D53;
        public const uint GL_RENDERBUFFER_DEPTH_SIZE_EXT    = 0x8D54;
        public const uint GL_RENDERBUFFER_STENCIL_SIZE_EXT  = 0x8D55;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_packed_depth_stencil
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DEPTH_STENCIL_EXT              = 0x84F9;
        public const uint GL_UNSIGNED_INT_24_8_EXT          = 0x84FA;
        public const uint GL_DEPTH24_STENCIL8_EXT           = 0x88F0;
        public const uint GL_TEXTURE_STENCIL_SIZE_EXT       = 0x88F1;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_stencil_clear_tag
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_STENCIL_TAG_BITS_EXT           = 0x88F2;
        public const uint GL_STENCIL_CLEAR_TAG_VALUE_EXT    = 0x88F3;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_sRGB
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SRGB_EXT                       = 0x8C40;
        public const uint GL_SRGB8_EXT                      = 0x8C41;
        public const uint GL_SRGB_ALPHA_EXT                 = 0x8C42;
        public const uint GL_SRGB8_ALPHA8_EXT               = 0x8C43;
        public const uint GL_SLUMINANCE_ALPHA_EXT           = 0x8C44;
        public const uint GL_SLUMINANCE8_ALPHA8_EXT         = 0x8C45;
        public const uint GL_SLUMINANCE_EXT                 = 0x8C46;
        public const uint GL_SLUMINANCE8_EXT                = 0x8C47;
        public const uint GL_COMPRESSED_SRGB_EXT            = 0x8C48;
        public const uint GL_COMPRESSED_SRGB_ALPHA_EXT      = 0x8C49;
        public const uint GL_COMPRESSED_SLUMINANCE_EXT      = 0x8C4A;
        public const uint GL_COMPRESSED_SLUMINANCE_ALPHA_EXT = 0x8C4B;
        public const uint GL_COMPRESSED_SRGB_S3TC_DXT1_EXT  = 0x8C4C;
        public const uint GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D;
        public const uint GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E;
        public const uint GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_framebuffer_blit
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_READ_FRAMEBUFFER_EXT           = 0x8CA8;
        public const uint GL_DRAW_FRAMEBUFFER_EXT           = 0x8CA9;
        public const uint GL_DRAW_FRAMEBUFFER_BINDING_EXT   = GL_FRAMEBUFFER_BINDING_EXT;
        public const uint GL_READ_FRAMEBUFFER_BINDING_EXT   = 0x8CAA;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_framebuffer_multisample
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_RENDERBUFFER_SAMPLES_EXT       = 0x8CAB;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56;
        public const uint GL_MAX_SAMPLES_EXT                = 0x8D57;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_timer_query
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TIME_ELAPSED_EXT               = 0x88BF;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_gpu_program_parameters (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_geometry_shader4
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_GEOMETRY_SHADER_EXT            = 0x8DD9;
        /* reuse GL_GEOMETRY_VERTICES_OUT_EXT */
        /* reuse GL_GEOMETRY_INPUT_TYPE_EXT */
        /* reuse GL_GEOMETRY_OUTPUT_TYPE_EXT */
        /* reuse GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT */
        public const uint GL_MAX_GEOMETRY_VARYING_COMPONENTS_EXT = 0x8DDD;
        public const uint GL_MAX_VERTEX_VARYING_COMPONENTS_EXT = 0x8DDE;
        public const uint GL_MAX_VARYING_COMPONENTS_EXT     = 0x8B4B;
        public const uint GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_EXT = 0x8DDF;
        public const uint GL_MAX_GEOMETRY_OUTPUT_VERTICES_EXT = 0x8DE0;
        public const uint GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_EXT = 0x8DE1;
        /* reuse GL_LINES_ADJACENCY_EXT */
        /* reuse GL_LINE_STRIP_ADJACENCY_EXT */
        /* reuse GL_TRIANGLES_ADJACENCY_EXT */
        /* reuse GL_TRIANGLE_STRIP_ADJACENCY_EXT */
        /* reuse GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT */
        /* reuse GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT */
        /* reuse GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT */
        /* reuse GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT */
        /* reuse GL_PROGRAM_POINT_SIZE_EXT */

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_gpu_shader4
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SAMPLER_1D_ARRAY_EXT           = 0x8DC0;
        public const uint GL_SAMPLER_2D_ARRAY_EXT           = 0x8DC1;
        public const uint GL_SAMPLER_BUFFER_EXT             = 0x8DC2;
        public const uint GL_SAMPLER_1D_ARRAY_SHADOW_EXT    = 0x8DC3;
        public const uint GL_SAMPLER_2D_ARRAY_SHADOW_EXT    = 0x8DC4;
        public const uint GL_SAMPLER_CUBE_SHADOW_EXT        = 0x8DC5;
        public const uint GL_UNSIGNED_INT_VEC2_EXT          = 0x8DC6;
        public const uint GL_UNSIGNED_INT_VEC3_EXT          = 0x8DC7;
        public const uint GL_UNSIGNED_INT_VEC4_EXT          = 0x8DC8;
        public const uint GL_INT_SAMPLER_1D_EXT             = 0x8DC9;
        public const uint GL_INT_SAMPLER_2D_EXT             = 0x8DCA;
        public const uint GL_INT_SAMPLER_3D_EXT             = 0x8DCB;
        public const uint GL_INT_SAMPLER_CUBE_EXT           = 0x8DCC;
        public const uint GL_INT_SAMPLER_2D_RECT_EXT        = 0x8DCD;
        public const uint GL_INT_SAMPLER_1D_ARRAY_EXT       = 0x8DCE;
        public const uint GL_INT_SAMPLER_2D_ARRAY_EXT       = 0x8DCF;
        public const uint GL_INT_SAMPLER_BUFFER_EXT         = 0x8DD0;
        public const uint GL_UNSIGNED_INT_SAMPLER_1D_EXT    = 0x8DD1;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_EXT    = 0x8DD2;
        public const uint GL_UNSIGNED_INT_SAMPLER_3D_EXT    = 0x8DD3;
        public const uint GL_UNSIGNED_INT_SAMPLER_CUBE_EXT  = 0x8DD4;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_RECT_EXT = 0x8DD5;
        public const uint GL_UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT = 0x8DD6;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT = 0x8DD7;
        public const uint GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT = 0x8DD8;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_draw_instanced (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_packed_float
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_R11F_G11F_B10F_EXT             = 0x8C3A;
        public const uint GL_UNSIGNED_INT_10F_11F_11F_REV_EXT = 0x8C3B;
        public const uint GL_RGBA_SIGNED_COMPONENTS_EXT     = 0x8C3C;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_array
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_1D_ARRAY_EXT           = 0x8C18;
        public const uint GL_PROXY_TEXTURE_1D_ARRAY_EXT     = 0x8C19;
        public const uint GL_TEXTURE_2D_ARRAY_EXT           = 0x8C1A;
        public const uint GL_PROXY_TEXTURE_2D_ARRAY_EXT     = 0x8C1B;
        public const uint GL_TEXTURE_BINDING_1D_ARRAY_EXT   = 0x8C1C;
        public const uint GL_TEXTURE_BINDING_2D_ARRAY_EXT   = 0x8C1D;
        public const uint GL_MAX_ARRAY_TEXTURE_LAYERS_EXT   = 0x88FF;
        public const uint GL_COMPARE_REF_DEPTH_TO_TEXTURE_EXT = 0x884E;
        /* reuse GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT */

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_buffer_object
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_BUFFER_EXT             = 0x8C2A;
        public const uint GL_MAX_TEXTURE_BUFFER_SIZE_EXT    = 0x8C2B;
        public const uint GL_TEXTURE_BINDING_BUFFER_EXT     = 0x8C2C;
        public const uint GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT = 0x8C2D;
        public const uint GL_TEXTURE_BUFFER_FORMAT_EXT      = 0x8C2E;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_compression_latc
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COMPRESSED_LUMINANCE_LATC1_EXT = 0x8C70;
        public const uint GL_COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT = 0x8C71;
        public const uint GL_COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C72;
        public const uint GL_COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C73;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_compression_rgtc
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COMPRESSED_RED_RGTC1_EXT       = 0x8DBB;
        public const uint GL_COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC;
        public const uint GL_COMPRESSED_RED_GREEN_RGTC2_EXT = 0x8DBD;
        public const uint GL_COMPRESSED_SIGNED_RED_GREEN_RGTC2_EXT = 0x8DBE;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_shared_exponent
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_RGB9_E5_EXT                    = 0x8C3D;
        public const uint GL_UNSIGNED_INT_5_9_9_9_REV_EXT   = 0x8C3E;
        public const uint GL_TEXTURE_SHARED_SIZE_EXT        = 0x8C3F;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_framebuffer_sRGB
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FRAMEBUFFER_SRGB_EXT           = 0x8DB9;
        public const uint GL_FRAMEBUFFER_SRGB_CAPABLE_EXT   = 0x8DBA;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_draw_buffers2 (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_bindable_uniform
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT = 0x8DE2;
        public const uint GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT = 0x8DE3;
        public const uint GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT = 0x8DE4;
        public const uint GL_MAX_BINDABLE_UNIFORM_SIZE_EXT  = 0x8DED;
        public const uint GL_UNIFORM_BUFFER_EXT             = 0x8DEE;
        public const uint GL_UNIFORM_BUFFER_BINDING_EXT     = 0x8DEF;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_integer
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_RGBA32UI_EXT                   = 0x8D70;
        public const uint GL_RGB32UI_EXT                    = 0x8D71;
        public const uint GL_ALPHA32UI_EXT                  = 0x8D72;
        public const uint GL_INTENSITY32UI_EXT              = 0x8D73;
        public const uint GL_LUMINANCE32UI_EXT              = 0x8D74;
        public const uint GL_LUMINANCE_ALPHA32UI_EXT        = 0x8D75;
        public const uint GL_RGBA16UI_EXT                   = 0x8D76;
        public const uint GL_RGB16UI_EXT                    = 0x8D77;
        public const uint GL_ALPHA16UI_EXT                  = 0x8D78;
        public const uint GL_INTENSITY16UI_EXT              = 0x8D79;
        public const uint GL_LUMINANCE16UI_EXT              = 0x8D7A;
        public const uint GL_LUMINANCE_ALPHA16UI_EXT        = 0x8D7B;
        public const uint GL_RGBA8UI_EXT                    = 0x8D7C;
        public const uint GL_RGB8UI_EXT                     = 0x8D7D;
        public const uint GL_ALPHA8UI_EXT                   = 0x8D7E;
        public const uint GL_INTENSITY8UI_EXT               = 0x8D7F;
        public const uint GL_LUMINANCE8UI_EXT               = 0x8D80;
        public const uint GL_LUMINANCE_ALPHA8UI_EXT         = 0x8D81;
        public const uint GL_RGBA32I_EXT                    = 0x8D82;
        public const uint GL_RGB32I_EXT                     = 0x8D83;
        public const uint GL_ALPHA32I_EXT                   = 0x8D84;
        public const uint GL_INTENSITY32I_EXT               = 0x8D85;
        public const uint GL_LUMINANCE32I_EXT               = 0x8D86;
        public const uint GL_LUMINANCE_ALPHA32I_EXT         = 0x8D87;
        public const uint GL_RGBA16I_EXT                    = 0x8D88;
        public const uint GL_RGB16I_EXT                     = 0x8D89;
        public const uint GL_ALPHA16I_EXT                   = 0x8D8A;
        public const uint GL_INTENSITY16I_EXT               = 0x8D8B;
        public const uint GL_LUMINANCE16I_EXT               = 0x8D8C;
        public const uint GL_LUMINANCE_ALPHA16I_EXT         = 0x8D8D;
        public const uint GL_RGBA8I_EXT                     = 0x8D8E;
        public const uint GL_RGB8I_EXT                      = 0x8D8F;
        public const uint GL_ALPHA8I_EXT                    = 0x8D90;
        public const uint GL_INTENSITY8I_EXT                = 0x8D91;
        public const uint GL_LUMINANCE8I_EXT                = 0x8D92;
        public const uint GL_LUMINANCE_ALPHA8I_EXT          = 0x8D93;
        public const uint GL_RED_INTEGER_EXT                = 0x8D94;
        public const uint GL_GREEN_INTEGER_EXT              = 0x8D95;
        public const uint GL_BLUE_INTEGER_EXT               = 0x8D96;
        public const uint GL_ALPHA_INTEGER_EXT              = 0x8D97;
        public const uint GL_RGB_INTEGER_EXT                = 0x8D98;
        public const uint GL_RGBA_INTEGER_EXT               = 0x8D99;
        public const uint GL_BGR_INTEGER_EXT                = 0x8D9A;
        public const uint GL_BGRA_INTEGER_EXT               = 0x8D9B;
        public const uint GL_LUMINANCE_INTEGER_EXT          = 0x8D9C;
        public const uint GL_LUMINANCE_ALPHA_INTEGER_EXT    = 0x8D9D;
        public const uint GL_RGBA_INTEGER_MODE_EXT          = 0x8D9E;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_transform_feedback
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_EXT  = 0x8C8E;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_START_EXT = 0x8C84;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT = 0x8C85;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT = 0x8C8F;
        public const uint GL_INTERLEAVED_ATTRIBS_EXT        = 0x8C8C;
        public const uint GL_SEPARATE_ATTRIBS_EXT           = 0x8C8D;
        public const uint GL_PRIMITIVES_GENERATED_EXT       = 0x8C87;
        public const uint GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT = 0x8C88;
        public const uint GL_RASTERIZER_DISCARD_EXT         = 0x8C89;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT = 0x8C8A;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT = 0x8C8B;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT = 0x8C80;
        public const uint GL_TRANSFORM_FEEDBACK_VARYINGS_EXT = 0x8C83;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_MODE_EXT = 0x8C7F;
        public const uint GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT = 0x8C76;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_direct_state_access
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PROGRAM_MATRIX_EXT             = 0x8E2D;
        public const uint GL_TRANSPOSE_PROGRAM_MATRIX_EXT   = 0x8E2E;
        public const uint GL_PROGRAM_MATRIX_STACK_DEPTH_EXT = 0x8E2F;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_vertex_array_bgra
        ///////////////////////////////////////////////////////////////////////
        /* reuse GL_BGRA */

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_swizzle
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_SWIZZLE_R_EXT          = 0x8E42;
        public const uint GL_TEXTURE_SWIZZLE_G_EXT          = 0x8E43;
        public const uint GL_TEXTURE_SWIZZLE_B_EXT          = 0x8E44;
        public const uint GL_TEXTURE_SWIZZLE_A_EXT          = 0x8E45;
        public const uint GL_TEXTURE_SWIZZLE_RGBA_EXT       = 0x8E46;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_type_2_10_10_10_REV
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_UNSIGNED_INT_2_10_10_10_REV_EXT    = 0x8368;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_provoking_vertex
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT = 0x8E4C;
        public const uint GL_FIRST_VERTEX_CONVENTION_EXT    = 0x8E4D;
        public const uint GL_LAST_VERTEX_CONVENTION_EXT     = 0x8E4E;
        public const uint GL_PROVOKING_VERTEX_EXT           = 0x8E4F;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_snorm
        ///////////////////////////////////////////////////////////////////////
        /* reuse GL_RED_SNORM (defined in OpenGL 3.1) */
        /* reuse GL_RG_SNORM (defined in OpenGL 3.1) */
        /* reuse GL_RGB_SNORM (defined in OpenGL 3.1) */
        /* reuse GL_RGBA_SNORM (defined in OpenGL 3.1) */
        public const uint GL_ALPHA_SNORM                    = 0x9010;
        public const uint GL_LUMINANCE_SNORM                = 0x9011;
        public const uint GL_LUMINANCE_ALPHA_SNORM          = 0x9012;
        public const uint GL_INTENSITY_SNORM                = 0x9013;
        /* reuse GL_R8_SNORM (defined in OpenGL 3.1) */
        /* reuse GL_RG8_SNORM (defined in OpenGL 3.1) */
        /* reuse GL_RGB8_SNORM (defined in OpenGL 3.1) */
        /* reuse GL_RGBA8_SNORM (defined in OpenGL 3.1) */
        public const uint GL_ALPHA8_SNORM                   = 0x9014;
        public const uint GL_LUMINANCE8_SNORM               = 0x9015;
        public const uint GL_LUMINANCE8_ALPHA8_SNORM        = 0x9016;
        public const uint GL_INTENSITY8_SNORM               = 0x9017;
        /* reuse GL_R16_SNORM (defined in OpenGL 3.1) */
        /* reuse GL_RG16_SNORM (defined in OpenGL 3.1) */
        /* reuse GL_RGB16_SNORM (defined in OpenGL 3.1) */
        /* reuse GL_RGBA16_SNORM (defined in OpenGL 3.1) */
        public const uint GL_ALPHA16_SNORM                  = 0x9018;
        public const uint GL_LUMINANCE16_SNORM              = 0x9019;
        public const uint GL_LUMINANCE16_ALPHA16_SNORM      = 0x901A;
        public const uint GL_INTENSITY16_SNORM              = 0x901B;
        /* reuse GL_SIGNED_NORMALIZED (defined in OpenGL 3.1) */

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_separate_shader_objects
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_ACTIVE_PROGRAM_EXT = 0x8B8D;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_shader_image_load_store
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_IMAGE_UNITS_EXT            = 0x8F38;
        public const uint GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT = 0x8F39;
        public const uint GL_IMAGE_BINDING_NAME_EXT         = 0x8F3A;
        public const uint GL_IMAGE_BINDING_LEVEL_EXT        = 0x8F3B;
        public const uint GL_IMAGE_BINDING_LAYERED_EXT      = 0x8F3C;
        public const uint GL_IMAGE_BINDING_LAYER_EXT        = 0x8F3D;
        public const uint GL_IMAGE_BINDING_ACCESS_EXT       = 0x8F3E;
        public const uint GL_IMAGE_1D_EXT                   = 0x904C;
        public const uint GL_IMAGE_2D_EXT                   = 0x904D;
        public const uint GL_IMAGE_3D_EXT                   = 0x904E;
        public const uint GL_IMAGE_2D_RECT_EXT              = 0x904F;
        public const uint GL_IMAGE_CUBE_EXT                 = 0x9050;
        public const uint GL_IMAGE_BUFFER_EXT               = 0x9051;
        public const uint GL_IMAGE_1D_ARRAY_EXT             = 0x9052;
        public const uint GL_IMAGE_2D_ARRAY_EXT             = 0x9053;
        public const uint GL_IMAGE_CUBE_MAP_ARRAY_EXT       = 0x9054;
        public const uint GL_IMAGE_2D_MULTISAMPLE_EXT       = 0x9055;
        public const uint GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9056;
        public const uint GL_INT_IMAGE_1D_EXT               = 0x9057;
        public const uint GL_INT_IMAGE_2D_EXT               = 0x9058;
        public const uint GL_INT_IMAGE_3D_EXT               = 0x9059;
        public const uint GL_INT_IMAGE_2D_RECT_EXT          = 0x905A;
        public const uint GL_INT_IMAGE_CUBE_EXT             = 0x905B;
        public const uint GL_INT_IMAGE_BUFFER_EXT           = 0x905C;
        public const uint GL_INT_IMAGE_1D_ARRAY_EXT         = 0x905D;
        public const uint GL_INT_IMAGE_2D_ARRAY_EXT         = 0x905E;
        public const uint GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT   = 0x905F;
        public const uint GL_INT_IMAGE_2D_MULTISAMPLE_EXT   = 0x9060;
        public const uint GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9061;
        public const uint GL_UNSIGNED_INT_IMAGE_1D_EXT      = 0x9062;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_EXT      = 0x9063;
        public const uint GL_UNSIGNED_INT_IMAGE_3D_EXT      = 0x9064;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT = 0x9065;
        public const uint GL_UNSIGNED_INT_IMAGE_CUBE_EXT    = 0x9066;
        public const uint GL_UNSIGNED_INT_IMAGE_BUFFER_EXT  = 0x9067;
        public const uint GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT = 0x9068;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT = 0x9069;
        public const uint GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x906B;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x906C;
        public const uint GL_MAX_IMAGE_SAMPLES_EXT          = 0x906D;
        public const uint GL_IMAGE_BINDING_FORMAT_EXT       = 0x906E;
        public const uint GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001;
        public const uint GL_ELEMENT_ARRAY_BARRIER_BIT_EXT  = 0x00000002;
        public const uint GL_UNIFORM_BARRIER_BIT_EXT        = 0x00000004;
        public const uint GL_TEXTURE_FETCH_BARRIER_BIT_EXT  = 0x00000008;
        public const uint GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020;
        public const uint GL_COMMAND_BARRIER_BIT_EXT        = 0x00000040;
        public const uint GL_PIXEL_BUFFER_BARRIER_BIT_EXT   = 0x00000080;
        public const uint GL_TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100;
        public const uint GL_BUFFER_UPDATE_BARRIER_BIT_EXT  = 0x00000200;
        public const uint GL_FRAMEBUFFER_BARRIER_BIT_EXT    = 0x00000400;
        public const uint GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800;
        public const uint GL_ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000;
        public const uint GL_ALL_BARRIER_BITS_EXT           = 0xFFFFFFFF;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_vertex_attrib_64bit
        ///////////////////////////////////////////////////////////////////////
        /* reuse GL_DOUBLE */
        public const uint GL_DOUBLE_VEC2_EXT                = 0x8FFC;
        public const uint GL_DOUBLE_VEC3_EXT                = 0x8FFD;
        public const uint GL_DOUBLE_VEC4_EXT                = 0x8FFE;
        public const uint GL_DOUBLE_MAT2_EXT                = 0x8F46;
        public const uint GL_DOUBLE_MAT3_EXT                = 0x8F47;
        public const uint GL_DOUBLE_MAT4_EXT                = 0x8F48;
        public const uint GL_DOUBLE_MAT2x3_EXT              = 0x8F49;
        public const uint GL_DOUBLE_MAT2x4_EXT              = 0x8F4A;
        public const uint GL_DOUBLE_MAT3x2_EXT              = 0x8F4B;
        public const uint GL_DOUBLE_MAT3x4_EXT              = 0x8F4C;
        public const uint GL_DOUBLE_MAT4x2_EXT              = 0x8F4D;
        public const uint GL_DOUBLE_MAT4x3_EXT              = 0x8F4E;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_sRGB_decode
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_SRGB_DECODE_EXT        = 0x8A48;
        public const uint GL_DECODE_EXT                     = 0x8A49;
        public const uint GL_SKIP_DECODE_EXT                = 0x8A4A;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_x11_sync_object
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SYNC_X11_FENCE_EXT             = 0x90E1;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_framebuffer_multisample_blit_scaled
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SCALED_RESOLVE_FASTEST_EXT     = 0x90BA;
        public const uint GL_SCALED_RESOLVE_NICEST_EXT      = 0x90BB;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_shader_integer_mix (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_debug_label
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PROGRAM_PIPELINE_OBJECT_EXT    = 0x8A4F;
        public const uint GL_PROGRAM_OBJECT_EXT             = 0x8B40;
        public const uint GL_SHADER_OBJECT_EXT              = 0x8B48;
        public const uint GL_BUFFER_OBJECT_EXT              = 0x9151;
        public const uint GL_QUERY_OBJECT_EXT               = 0x9153;
        public const uint GL_VERTEX_ARRAY_OBJECT_EXT        = 0x9154;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_debug_marker (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_Cg_shader
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CG_VERTEX_SHADER_EXT                   = 0x890E;
        public const uint GL_CG_FRAGMENT_SHADER_EXT                 = 0x890F;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_edge_clamp
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CLAMP_TO_EDGE_EXT                      = 0x812F;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_rectangle
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_RECTANGLE_EXT                  = 0x84F5;
        public const uint GL_TEXTURE_BINDING_RECTANGLE_EXT          = 0x84F6;
        public const uint GL_PROXY_TEXTURE_RECTANGLE_EXT            = 0x84F7;
        public const uint GL_MAX_RECTANGLE_TEXTURE_SIZE_EXT         = 0x84F8;
        
        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_texture_storage
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_IMMUTABLE_FORMAT_EXT           = 0x912F;

        ///////////////////////////////////////////////////////////////////////
        // GL_EXT_transform_feedback2 
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TRANSFORM_FEEDBACK_EXT                 = 0x8E22;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_EXT   = 0x8E23;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_EXT   = 0x8E24;
        public const uint GL_TRANSFORM_FEEDBACK_BINDING_EXT         = 0x8E25;

        #endregion
        
        ///////////////////////////////////////////////////////////////////////
        // GL_GREMEDY_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_GREMEDY_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_GREMEDY_string_marker (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_GREMEDY_frame_terminator (no constants)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_HP_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_HP_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_HP_image_transform
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_IMAGE_SCALE_X_HP               = 0x8155;
        public const uint GL_IMAGE_SCALE_Y_HP               = 0x8156;
        public const uint GL_IMAGE_TRANSLATE_X_HP           = 0x8157;
        public const uint GL_IMAGE_TRANSLATE_Y_HP           = 0x8158;
        public const uint GL_IMAGE_ROTATE_ANGLE_HP          = 0x8159;
        public const uint GL_IMAGE_ROTATE_ORIGIN_X_HP       = 0x815A;
        public const uint GL_IMAGE_ROTATE_ORIGIN_Y_HP       = 0x815B;
        public const uint GL_IMAGE_MAG_FILTER_HP            = 0x815C;
        public const uint GL_IMAGE_MIN_FILTER_HP            = 0x815D;
        public const uint GL_IMAGE_CUBIC_WEIGHT_HP          = 0x815E;
        public const uint GL_CUBIC_HP                       = 0x815F;
        public const uint GL_AVERAGE_HP                     = 0x8160;
        public const uint GL_IMAGE_TRANSFORM_2D_HP          = 0x8161;
        public const uint GL_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8162;
        public const uint GL_PROXY_POST_IMAGE_TRANSFORM_COLOR_TABLE_HP = 0x8163;

        ///////////////////////////////////////////////////////////////////////
        // GL_HP_convolution_border_modes
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_IGNORE_BORDER_HP               = 0x8150;
        public const uint GL_CONSTANT_BORDER_HP             = 0x8151;
        public const uint GL_REPLICATE_BORDER_HP            = 0x8153;
        public const uint GL_CONVOLUTION_BORDER_COLOR_HP    = 0x8154;

        ///////////////////////////////////////////////////////////////////////
        // GL_HP_texture_lighting
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_LIGHTING_MODE_HP       = 0x8167;
        public const uint GL_TEXTURE_POST_SPECULAR_HP       = 0x8168;
        public const uint GL_TEXTURE_PRE_SPECULAR_HP        = 0x8169;

        ///////////////////////////////////////////////////////////////////////
        // GL_HP_occlusion_test
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_OCCLUSION_TEST_HP              = 0x8165;
        public const uint GL_OCCLUSION_TEST_RESULT_HP       = 0x8166;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_IBM_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_rasterpos_clip
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_RASTER_POSITION_UNCLIPPED_IBM  = 0x19262;

        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_cull_vertex
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CULL_VERTEX_IBM                = 103050;

        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_multimode_draw_arrays (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_vertex_array_lists
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_ARRAY_LIST_IBM          = 103070;
        public const uint GL_NORMAL_ARRAY_LIST_IBM          = 103071;
        public const uint GL_COLOR_ARRAY_LIST_IBM           = 103072;
        public const uint GL_INDEX_ARRAY_LIST_IBM           = 103073;
        public const uint GL_TEXTURE_COORD_ARRAY_LIST_IBM   = 103074;
        public const uint GL_EDGE_FLAG_ARRAY_LIST_IBM       = 103075;
        public const uint GL_FOG_COORDINATE_ARRAY_LIST_IBM  = 103076;
        public const uint GL_SECONDARY_COLOR_ARRAY_LIST_IBM = 103077;
        public const uint GL_VERTEX_ARRAY_LIST_STRIDE_IBM   = 103080;
        public const uint GL_NORMAL_ARRAY_LIST_STRIDE_IBM   = 103081;
        public const uint GL_COLOR_ARRAY_LIST_STRIDE_IBM    = 103082;
        public const uint GL_INDEX_ARRAY_LIST_STRIDE_IBM    = 103083;
        public const uint GL_TEXTURE_COORD_ARRAY_LIST_STRIDE_IBM = 103084;
        public const uint GL_EDGE_FLAG_ARRAY_LIST_STRIDE_IBM = 103085;
        public const uint GL_FOG_COORDINATE_ARRAY_LIST_STRIDE_IBM = 103086;
        public const uint GL_SECONDARY_COLOR_ARRAY_LIST_STRIDE_IBM = 103087;

        ///////////////////////////////////////////////////////////////////////
        // GL_IBM_texture_mirrored_repeat
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MIRRORED_REPEAT_IBM = 0x8370;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_INGR_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_INGR_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_INGR_blend_func_separate (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_INGR_color_clamp
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_RED_MIN_CLAMP_INGR             = 0x8560;
        public const uint GL_GREEN_MIN_CLAMP_INGR           = 0x8561;
        public const uint GL_BLUE_MIN_CLAMP_INGR            = 0x8562;
        public const uint GL_ALPHA_MIN_CLAMP_INGR           = 0x8563;
        public const uint GL_RED_MAX_CLAMP_INGR             = 0x8564;
        public const uint GL_GREEN_MAX_CLAMP_INGR           = 0x8565;
        public const uint GL_BLUE_MAX_CLAMP_INGR            = 0x8566;
        public const uint GL_ALPHA_MAX_CLAMP_INGR           = 0x8567;

        ///////////////////////////////////////////////////////////////////////
        // GL_INGR_interlace_read
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_INTERLACE_READ_INGR            = 0x8568;

        ///////////////////////////////////////////////////////////////////////
        // GL_INGR_palette_buffer (no constants)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_INTEL_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_parallel_arrays
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PARALLEL_ARRAYS_INTEL                          = 0x83F4;
        public const uint GL_VERTEX_ARRAY_PARALLEL_POINTERS_INTEL           = 0x83F5;
        public const uint GL_NORMAL_ARRAY_PARALLEL_POINTERS_INTEL           = 0x83F6;
        public const uint GL_COLOR_ARRAY_PARALLEL_POINTERS_INTEL            = 0x83F7;
        public const uint GL_TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL    = 0x83F8;

        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_fragment_shader_ordering (no constants)
        ///////////////////////////////////////////////////////////////////////
        
        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_map_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_MEMORY_LAYOUT_INTEL                    = 0x83FF;
        public const uint GL_LAYOUT_DEFAULT_INTEL                           = 0;
        public const uint GL_LAYOUT_LINEAR_INTEL                            = 1;
        public const uint GL_LAYOUT_LINEAR_CPU_CACHED_INTEL                 = 2;

        ///////////////////////////////////////////////////////////////////////
        // GL_INTEL_performance_query
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PERFQUERY_SINGLE_CONTEXT_INTEL                 = 0x00000000;
        public const uint GL_PERFQUERY_GLOBAL_CONTEXT_INTEL                 = 0x00000001;
        public const uint GL_PERFQUERY_WAIT_INTEL                           = 0x83FB;
        public const uint GL_PERFQUERY_FLUSH_INTEL                          = 0x83FA;
        public const uint GL_PERFQUERY_DONOT_FLUSH_INTEL                    = 0x83F9;
        public const uint GL_PERFQUERY_COUNTER_EVENT_INTEL                  = 0x94F0;
        public const uint GL_PERFQUERY_COUNTER_DURATION_NORM_INTEL          = 0x94F1;
        public const uint GL_PERFQUERY_COUNTER_DURATION_RAW_INTEL           = 0x94F2;
        public const uint GL_PERFQUERY_COUNTER_THROUGHPUT_INTEL             = 0x94F3;
        public const uint GL_PERFQUERY_COUNTER_RAW_INTEL                    = 0x94F4;
        public const uint GL_PERFQUERY_COUNTER_TIMESTAMP_INTEL              = 0x94F5;
        public const uint GL_PERFQUERY_COUNTER_DATA_UINT32_INTEL            = 0x94F8;
        public const uint GL_PERFQUERY_COUNTER_DATA_UINT64_INTEL            = 0x94F9;
        public const uint GL_PERFQUERY_COUNTER_DATA_FLOAT_INTEL             = 0x94FA;
        public const uint GL_PERFQUERY_COUNTER_DATA_DOUBLE_INTEL            = 0x94FB;
        public const uint GL_PERFQUERY_COUNTER_DATA_BOOL32_INTEL            = 0x94FC;
        public const uint GL_PERFQUERY_QUERY_NAME_LENGTH_MAX_INTEL          = 0x94FD;
        public const uint GL_PERFQUERY_COUNTER_NAME_LENGTH_MAX_INTEL        = 0x94FE;
        public const uint GL_PERFQUERY_COUNTER_DESC_LENGTH_MAX_INTEL        = 0x94FF;
        public const uint GL_PERFQUERY_GPA_EXTENDED_COUNTERS_INTEL          = 0x9500;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_KHR_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_context_flush_control (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_texture_compression_astc_ldr
        ///////////////////////////////////////////////////////////////////////
        // Constants reused from GL_KHR_texture_compression_astc_hdr

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_texture_compression_astc_hdr
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COMPRESSED_RGBA_ASTC_4x4_KHR           = 0x93B0;
        public const uint GL_COMPRESSED_RGBA_ASTC_5x4_KHR           = 0x93B1;
        public const uint GL_COMPRESSED_RGBA_ASTC_5x5_KHR           = 0x93B2;
        public const uint GL_COMPRESSED_RGBA_ASTC_6x5_KHR           = 0x93B3;
        public const uint GL_COMPRESSED_RGBA_ASTC_6x6_KHR           = 0x93B4;
        public const uint GL_COMPRESSED_RGBA_ASTC_8x5_KHR           = 0x93B5;
        public const uint GL_COMPRESSED_RGBA_ASTC_8x6_KHR           = 0x93B6;
        public const uint GL_COMPRESSED_RGBA_ASTC_8x8_KHR           = 0x93B7;
        public const uint GL_COMPRESSED_RGBA_ASTC_10x5_KHR          = 0x93B8;
        public const uint GL_COMPRESSED_RGBA_ASTC_10x6_KHR          = 0x93B9;
        public const uint GL_COMPRESSED_RGBA_ASTC_10x8_KHR          = 0x93BA;
        public const uint GL_COMPRESSED_RGBA_ASTC_10x10_KHR         = 0x93BB;
        public const uint GL_COMPRESSED_RGBA_ASTC_12x10_KHR         = 0x93BC;
        public const uint GL_COMPRESSED_RGBA_ASTC_12x12_KHR         = 0x93BD;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR   = 0x93D0;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR   = 0x93D1;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR   = 0x93D2;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR   = 0x93D3;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR   = 0x93D4;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR   = 0x93D5;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR   = 0x93D6;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR   = 0x93D7;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR  = 0x93D8;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR  = 0x93D9;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR  = 0x93DA;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR = 0x93DB;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR = 0x93DC;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR = 0x93DD;

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_debug
        ///////////////////////////////////////////////////////////////////////
        /* Defined in OpenGL 4.3
        public const uint GL_DEBUG_OUTPUT_SYNCHRONOUS       = 0x8242;
        public const uint GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
        public const uint GL_DEBUG_CALLBACK_FUNCTION        = 0x8244;
        public const uint GL_DEBUG_CALLBACK_USER_PARAM      = 0x8245;
        public const uint GL_DEBUG_SOURCE_API               = 0x8246;
        public const uint GL_DEBUG_SOURCE_WINDOW_SYSTEM     = 0x8247;
        public const uint GL_DEBUG_SOURCE_SHADER_COMPILER   = 0x8248;
        public const uint GL_DEBUG_SOURCE_THIRD_PARTY       = 0x8249;
        public const uint GL_DEBUG_SOURCE_APPLICATION       = 0x824A;
        public const uint GL_DEBUG_SOURCE_OTHER             = 0x824B;
        public const uint GL_DEBUG_TYPE_ERROR               = 0x824C;
        public const uint GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
        public const uint GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR  = 0x824E;
        public const uint GL_DEBUG_TYPE_PORTABILITY         = 0x824F;
        public const uint GL_DEBUG_TYPE_PERFORMANCE         = 0x8250;
        public const uint GL_DEBUG_TYPE_OTHER               = 0x8251;
        public const uint GL_DEBUG_TYPE_MARKER              = 0x8268;
        public const uint GL_DEBUG_TYPE_PUSH_GROUP          = 0x8269;
        public const uint GL_DEBUG_TYPE_POP_GROUP           = 0x826A;
        public const uint GL_DEBUG_SEVERITY_NOTIFICATION    = 0x826B;
        public const uint GL_MAX_DEBUG_GROUP_STACK_DEPTH    = 0x826C;
        public const uint GL_DEBUG_GROUP_STACK_DEPTH        = 0x826D;
        public const uint GL_BUFFER                         = 0x82E0;
        public const uint GL_SHADER                         = 0x82E1;
        public const uint GL_PROGRAM                        = 0x82E2;
        public const uint GL_QUERY                          = 0x82E3;
        public const uint GL_PROGRAM_PIPELINE               = 0x82E4;
        public const uint GL_SAMPLER                        = 0x82E6;
        public const uint GL_DISPLAY_LIST                   = 0x82E7;
        // DISPLAY_LIST used in compatibility profile only
        public const uint GL_MAX_LABEL_LENGTH               = 0x82E8;
        public const uint GL_MAX_DEBUG_MESSAGE_LENGTH       = 0x9143;
        public const uint GL_MAX_DEBUG_LOGGED_MESSAGES      = 0x9144;
        public const uint GL_DEBUG_LOGGED_MESSAGES          = 0x9145;
        public const uint GL_DEBUG_SEVERITY_HIGH            = 0x9146;
        public const uint GL_DEBUG_SEVERITY_MEDIUM          = 0x9147;
        public const uint GL_DEBUG_SEVERITY_LOW             = 0x9148;
        public const uint GL_DEBUG_OUTPUT                   = 0x92E0;
        public const uint GL_CONTEXT_FLAG_DEBUG_BIT         = 0x00000002;
        reuse GL_STACK_UNDERFLOW
        reuse GL_STACK_OVERFLOW 
        */

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_no_error
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CONTEXT_FLAG_NO_ERROR_BIT_KHR              = 0x00000008;

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_robust_buffer_access_behavior (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_robustness
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CONTEXT_ROBUST_ACCESS                      = 0x90F3;

        ///////////////////////////////////////////////////////////////////////
        // GL_KHR_texture_compression_astc_sliced_3d (no constants)
        ///////////////////////////////////////////////////////////////////////
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_KTX_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_KTX_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_KTX_buffer_region
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_KTX_FRONT_REGION                       = 0x0;
        public const uint GL_KTX_BACK_REGION                        = 0x1;
        public const uint GL_KTX_Z_REGION                           = 0x2;
        public const uint GL_KTX_STENCIL_REGION                     = 0x3;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_MESA_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_resize_buffers (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_window_pos (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_pack_invert
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PACK_INVERT_MESA = 0x8758;

        ///////////////////////////////////////////////////////////////////////
        // GL_MESA_ycbcr_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_UNSIGNED_SHORT_8_8_MESA = 0x85BA;
        public const uint GL_UNSIGNED_SHORT_8_8_REV_MESA = 0x85BB;
        public const uint GL_YCBCR_MESA = 0x8757;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_MESAX_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_MESAX_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_MESAX_texture_stack
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_1D_STACK_MESAX         = 0x8759;
        public const uint GL_TEXTURE_2D_STACK_MESAX         = 0x875A;
        public const uint GL_PROXY_TEXTURE_1D_STACK_MESAX   = 0x875B;
        public const uint GL_PROXY_TEXTURE_2D_STACK_MESAX   = 0x875C;
        public const uint GL_TEXTURE_1D_STACK_BINDING_MESAX = 0x875D;
        public const uint GL_TEXTURE_2D_STACK_BINDING_MESAX = 0x875E;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_NV_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texgen_reflection
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_NORMAL_MAP_NV                  = 0x8511;
        public const uint GL_REFLECTION_MAP_NV              = 0x8512;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_light_max_exponent
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_SHININESS_NV               = 0x8504;
        public const uint GL_MAX_SPOT_EXPONENT_NV           = 0x8505;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_array_range
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_ARRAY_RANGE_NV          = 0x851D;
        public const uint GL_VERTEX_ARRAY_RANGE_LENGTH_NV   = 0x851E;
        public const uint GL_VERTEX_ARRAY_RANGE_VALID_NV    = 0x851F;
        public const uint GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520;
        public const uint GL_VERTEX_ARRAY_RANGE_POINTER_NV  = 0x8521;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_register_combiners
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_REGISTER_COMBINERS_NV          = 0x8522;
        public const uint GL_VARIABLE_A_NV                  = 0x8523;
        public const uint GL_VARIABLE_B_NV                  = 0x8524;
        public const uint GL_VARIABLE_C_NV                  = 0x8525;
        public const uint GL_VARIABLE_D_NV                  = 0x8526;
        public const uint GL_VARIABLE_E_NV                  = 0x8527;
        public const uint GL_VARIABLE_F_NV                  = 0x8528;
        public const uint GL_VARIABLE_G_NV                  = 0x8529;
        public const uint GL_CONSTANT_COLOR0_NV             = 0x852A;
        public const uint GL_CONSTANT_COLOR1_NV             = 0x852B;
        public const uint GL_PRIMARY_COLOR_NV               = 0x852C;
        public const uint GL_SECONDARY_COLOR_NV             = 0x852D;
        public const uint GL_SPARE0_NV                      = 0x852E;
        public const uint GL_SPARE1_NV                      = 0x852F;
        public const uint GL_DISCARD_NV                     = 0x8530;
        public const uint GL_E_TIMES_F_NV                   = 0x8531;
        public const uint GL_SPARE0_PLUS_SECONDARY_COLOR_NV = 0x8532;
        public const uint GL_UNSIGNED_IDENTITY_NV           = 0x8536;
        public const uint GL_UNSIGNED_INVERT_NV             = 0x8537;
        public const uint GL_EXPAND_NORMAL_NV               = 0x8538;
        public const uint GL_EXPAND_NEGATE_NV               = 0x8539;
        public const uint GL_HALF_BIAS_NORMAL_NV            = 0x853A;
        public const uint GL_HALF_BIAS_NEGATE_NV            = 0x853B;
        public const uint GL_SIGNED_IDENTITY_NV             = 0x853C;
        public const uint GL_SIGNED_NEGATE_NV               = 0x853D;
        public const uint GL_SCALE_BY_TWO_NV                = 0x853E;
        public const uint GL_SCALE_BY_FOUR_NV               = 0x853F;
        public const uint GL_SCALE_BY_ONE_HALF_NV           = 0x8540;
        public const uint GL_BIAS_BY_NEGATIVE_ONE_HALF_NV   = 0x8541;
        public const uint GL_COMBINER_INPUT_NV              = 0x8542;
        public const uint GL_COMBINER_MAPPING_NV            = 0x8543;
        public const uint GL_COMBINER_COMPONENT_USAGE_NV    = 0x8544;
        public const uint GL_COMBINER_AB_DOT_PRODUCT_NV     = 0x8545;
        public const uint GL_COMBINER_CD_DOT_PRODUCT_NV     = 0x8546;
        public const uint GL_COMBINER_MUX_SUM_NV            = 0x8547;
        public const uint GL_COMBINER_SCALE_NV              = 0x8548;
        public const uint GL_COMBINER_BIAS_NV               = 0x8549;
        public const uint GL_COMBINER_AB_OUTPUT_NV          = 0x854A;
        public const uint GL_COMBINER_CD_OUTPUT_NV          = 0x854B;
        public const uint GL_COMBINER_SUM_OUTPUT_NV         = 0x854C;
        public const uint GL_MAX_GENERAL_COMBINERS_NV       = 0x854D;
        public const uint GL_NUM_GENERAL_COMBINERS_NV       = 0x854E;
        public const uint GL_COLOR_SUM_CLAMP_NV             = 0x854F;
        public const uint GL_COMBINER0_NV                   = 0x8550;
        public const uint GL_COMBINER1_NV                   = 0x8551;
        public const uint GL_COMBINER2_NV                   = 0x8552;
        public const uint GL_COMBINER3_NV                   = 0x8553;
        public const uint GL_COMBINER4_NV                   = 0x8554;
        public const uint GL_COMBINER5_NV                   = 0x8555;
        public const uint GL_COMBINER6_NV                   = 0x8556;
        public const uint GL_COMBINER7_NV                   = 0x8557;
        /* reuse GL_TEXTURE0_ARB */
        /* reuse GL_TEXTURE1_ARB */
        /* reuse GL_ZERO */
        /* reuse GL_NONE */
        /* reuse GL_FOG */

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fog_distance
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FOG_DISTANCE_MODE_NV           = 0x855A;
        public const uint GL_EYE_RADIAL_NV                  = 0x855B;
        public const uint GL_EYE_PLANE_ABSOLUTE_NV          = 0x855C;
        /* reuse GL_EYE_PLANE */

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texgen_emboss
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_EMBOSS_LIGHT_NV                = 0x855D;
        public const uint GL_EMBOSS_CONSTANT_NV             = 0x855E;
        public const uint GL_EMBOSS_MAP_NV                  = 0x855F;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_blend_square (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_env_combine4
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COMBINE4_NV                    = 0x8503;
        public const uint GL_SOURCE3_RGB_NV                 = 0x8583;
        public const uint GL_SOURCE3_ALPHA_NV               = 0x858B;
        public const uint GL_OPERAND3_RGB_NV                = 0x8593;
        public const uint GL_OPERAND3_ALPHA_NV              = 0x859B;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fbo_color_attachments
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COLOR_ATTACHMENT0_NV           = 0x8CE0;
        public const uint GL_COLOR_ATTACHMENT1_NV           = 0x8CE1;
        public const uint GL_COLOR_ATTACHMENT2_NV           = 0x8CE2;
        public const uint GL_COLOR_ATTACHMENT3_NV           = 0x8CE3;
        public const uint GL_COLOR_ATTACHMENT4_NV           = 0x8CE4;
        public const uint GL_COLOR_ATTACHMENT5_NV           = 0x8CE5;
        public const uint GL_COLOR_ATTACHMENT6_NV           = 0x8CE6;
        public const uint GL_COLOR_ATTACHMENT7_NV           = 0x8CE7;
        public const uint GL_COLOR_ATTACHMENT8_NV           = 0x8CE8;
        public const uint GL_COLOR_ATTACHMENT9_NV           = 0x8CE9;
        public const uint GL_COLOR_ATTACHMENT10_NV          = 0x8CEA;
        public const uint GL_COLOR_ATTACHMENT11_NV          = 0x8CEB;
        public const uint GL_COLOR_ATTACHMENT12_NV          = 0x8CEC;
        public const uint GL_COLOR_ATTACHMENT13_NV          = 0x8CED;
        public const uint GL_COLOR_ATTACHMENT14_NV          = 0x8CEE;
        public const uint GL_COLOR_ATTACHMENT15_NV          = 0x8CEF;
        public const uint GL_MAX_COLOR_ATTACHMENTS_NV       = 0x8CDF;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fence
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_ALL_COMPLETED_NV               = 0x84F2;
        public const uint GL_FENCE_STATUS_NV                = 0x84F3;
        public const uint GL_FENCE_CONDITION_NV             = 0x84F4;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_evaluators
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_EVAL_2D_NV                     = 0x86C0;
        public const uint GL_EVAL_TRIANGULAR_2D_NV          = 0x86C1;
        public const uint GL_MAP_TESSELLATION_NV            = 0x86C2;
        public const uint GL_MAP_ATTRIB_U_ORDER_NV          = 0x86C3;
        public const uint GL_MAP_ATTRIB_V_ORDER_NV          = 0x86C4;
        public const uint GL_EVAL_FRACTIONAL_TESSELLATION_NV = 0x86C5;
        public const uint GL_EVAL_VERTEX_ATTRIB0_NV         = 0x86C6;
        public const uint GL_EVAL_VERTEX_ATTRIB1_NV         = 0x86C7;
        public const uint GL_EVAL_VERTEX_ATTRIB2_NV         = 0x86C8;
        public const uint GL_EVAL_VERTEX_ATTRIB3_NV         = 0x86C9;
        public const uint GL_EVAL_VERTEX_ATTRIB4_NV         = 0x86CA;
        public const uint GL_EVAL_VERTEX_ATTRIB5_NV         = 0x86CB;
        public const uint GL_EVAL_VERTEX_ATTRIB6_NV         = 0x86CC;
        public const uint GL_EVAL_VERTEX_ATTRIB7_NV         = 0x86CD;
        public const uint GL_EVAL_VERTEX_ATTRIB8_NV         = 0x86CE;
        public const uint GL_EVAL_VERTEX_ATTRIB9_NV         = 0x86CF;
        public const uint GL_EVAL_VERTEX_ATTRIB10_NV        = 0x86D0;
        public const uint GL_EVAL_VERTEX_ATTRIB11_NV        = 0x86D1;
        public const uint GL_EVAL_VERTEX_ATTRIB12_NV        = 0x86D2;
        public const uint GL_EVAL_VERTEX_ATTRIB13_NV        = 0x86D3;
        public const uint GL_EVAL_VERTEX_ATTRIB14_NV        = 0x86D4;
        public const uint GL_EVAL_VERTEX_ATTRIB15_NV        = 0x86D5;
        public const uint GL_MAX_MAP_TESSELLATION_NV        = 0x86D6;
        public const uint GL_MAX_RATIONAL_EVAL_ORDER_NV     = 0x86D7;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_packed_depth_stencil
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DEPTH_STENCIL_NV               = 0x84F9;
        public const uint GL_UNSIGNED_INT_24_8_NV           = 0x84FA;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_register_combiners2
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PER_STAGE_CONSTANTS_NV         = 0x8535;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_compression_vtc (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_rectangle
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_RECTANGLE_NV           = 0x84F5;
        public const uint GL_TEXTURE_BINDING_RECTANGLE_NV   = 0x84F6;
        public const uint GL_PROXY_TEXTURE_RECTANGLE_NV     = 0x84F7;
        public const uint GL_MAX_RECTANGLE_TEXTURE_SIZE_NV  = 0x84F8;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_shader
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_OFFSET_TEXTURE_RECTANGLE_NV    = 0x864C;
        public const uint GL_OFFSET_TEXTURE_RECTANGLE_SCALE_NV = 0x864D;
        public const uint GL_DOT_PRODUCT_TEXTURE_RECTANGLE_NV = 0x864E;
        public const uint GL_RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV = 0x86D9;
        public const uint GL_UNSIGNED_INT_S8_S8_8_8_NV      = 0x86DA;
        public const uint GL_UNSIGNED_INT_8_8_S8_S8_REV_NV  = 0x86DB;
        public const uint GL_DSDT_MAG_INTENSITY_NV          = 0x86DC;
        public const uint GL_SHADER_CONSISTENT_NV           = 0x86DD;
        public const uint GL_TEXTURE_SHADER_NV              = 0x86DE;
        public const uint GL_SHADER_OPERATION_NV            = 0x86DF;
        public const uint GL_CULL_MODES_NV                  = 0x86E0;
        public const uint GL_OFFSET_TEXTURE_MATRIX_NV       = 0x86E1;
        public const uint GL_OFFSET_TEXTURE_SCALE_NV        = 0x86E2;
        public const uint GL_OFFSET_TEXTURE_BIAS_NV         = 0x86E3;
        public const uint GL_OFFSET_TEXTURE_2D_MATRIX_NV    = GL_OFFSET_TEXTURE_MATRIX_NV;
        public const uint GL_OFFSET_TEXTURE_2D_SCALE_NV     = GL_OFFSET_TEXTURE_SCALE_NV;
        public const uint GL_OFFSET_TEXTURE_2D_BIAS_NV      = GL_OFFSET_TEXTURE_BIAS_NV;
        public const uint GL_PREVIOUS_TEXTURE_INPUT_NV      = 0x86E4;
        public const uint GL_CONST_EYE_NV                   = 0x86E5;
        public const uint GL_PASS_THROUGH_NV                = 0x86E6;
        public const uint GL_CULL_FRAGMENT_NV               = 0x86E7;
        public const uint GL_OFFSET_TEXTURE_2D_NV           = 0x86E8;
        public const uint GL_DEPENDENT_AR_TEXTURE_2D_NV     = 0x86E9;
        public const uint GL_DEPENDENT_GB_TEXTURE_2D_NV     = 0x86EA;
        public const uint GL_DOT_PRODUCT_NV                 = 0x86EC;
        public const uint GL_DOT_PRODUCT_DEPTH_REPLACE_NV   = 0x86ED;
        public const uint GL_DOT_PRODUCT_TEXTURE_2D_NV      = 0x86EE;
        public const uint GL_DOT_PRODUCT_TEXTURE_CUBE_MAP_NV = 0x86F0;
        public const uint GL_DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV = 0x86F1;
        public const uint GL_DOT_PRODUCT_REFLECT_CUBE_MAP_NV = 0x86F2;
        public const uint GL_DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV = 0x86F3;
        public const uint GL_HILO_NV                        = 0x86F4;
        public const uint GL_DSDT_NV                        = 0x86F5;
        public const uint GL_DSDT_MAG_NV                    = 0x86F6;
        public const uint GL_DSDT_MAG_VIB_NV                = 0x86F7;
        public const uint GL_HILO16_NV                      = 0x86F8;
        public const uint GL_SIGNED_HILO_NV                 = 0x86F9;
        public const uint GL_SIGNED_HILO16_NV               = 0x86FA;
        public const uint GL_SIGNED_RGBA_NV                 = 0x86FB;
        public const uint GL_SIGNED_RGBA8_NV                = 0x86FC;
        public const uint GL_SIGNED_RGB_NV                  = 0x86FE;
        public const uint GL_SIGNED_RGB8_NV                 = 0x86FF;
        public const uint GL_SIGNED_LUMINANCE_NV            = 0x8701;
        public const uint GL_SIGNED_LUMINANCE8_NV           = 0x8702;
        public const uint GL_SIGNED_LUMINANCE_ALPHA_NV      = 0x8703;
        public const uint GL_SIGNED_LUMINANCE8_ALPHA8_NV    = 0x8704;
        public const uint GL_SIGNED_ALPHA_NV                = 0x8705;
        public const uint GL_SIGNED_ALPHA8_NV               = 0x8706;
        public const uint GL_SIGNED_INTENSITY_NV            = 0x8707;
        public const uint GL_SIGNED_INTENSITY8_NV           = 0x8708;
        public const uint GL_DSDT8_NV                       = 0x8709;
        public const uint GL_DSDT8_MAG8_NV                  = 0x870A;
        public const uint GL_DSDT8_MAG8_INTENSITY8_NV       = 0x870B;
        public const uint GL_SIGNED_RGB_UNSIGNED_ALPHA_NV   = 0x870C;
        public const uint GL_SIGNED_RGB8_UNSIGNED_ALPHA8_NV = 0x870D;
        public const uint GL_HI_SCALE_NV                    = 0x870E;
        public const uint GL_LO_SCALE_NV                    = 0x870F;
        public const uint GL_DS_SCALE_NV                    = 0x8710;
        public const uint GL_DT_SCALE_NV                    = 0x8711;
        public const uint GL_MAGNITUDE_SCALE_NV             = 0x8712;
        public const uint GL_VIBRANCE_SCALE_NV              = 0x8713;
        public const uint GL_HI_BIAS_NV                     = 0x8714;
        public const uint GL_LO_BIAS_NV                     = 0x8715;
        public const uint GL_DS_BIAS_NV                     = 0x8716;
        public const uint GL_DT_BIAS_NV                     = 0x8717;
        public const uint GL_MAGNITUDE_BIAS_NV              = 0x8718;
        public const uint GL_VIBRANCE_BIAS_NV               = 0x8719;
        public const uint GL_TEXTURE_BORDER_VALUES_NV       = 0x871A;
        public const uint GL_TEXTURE_HI_SIZE_NV             = 0x871B;
        public const uint GL_TEXTURE_LO_SIZE_NV             = 0x871C;
        public const uint GL_TEXTURE_DS_SIZE_NV             = 0x871D;
        public const uint GL_TEXTURE_DT_SIZE_NV             = 0x871E;
        public const uint GL_TEXTURE_MAG_SIZE_NV            = 0x871F;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_shader2
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DOT_PRODUCT_TEXTURE_3D_NV      = 0x86EF;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_array_range2
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV = 0x8533;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_program
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_PROGRAM_NV              = 0x8620;
        public const uint GL_VERTEX_STATE_PROGRAM_NV        = 0x8621;
        public const uint GL_ATTRIB_ARRAY_SIZE_NV           = 0x8623;
        public const uint GL_ATTRIB_ARRAY_STRIDE_NV         = 0x8624;
        public const uint GL_ATTRIB_ARRAY_TYPE_NV           = 0x8625;
        public const uint GL_CURRENT_ATTRIB_NV              = 0x8626;
        public const uint GL_PROGRAM_LENGTH_NV              = 0x8627;
        public const uint GL_PROGRAM_STRING_NV              = 0x8628;
        public const uint GL_MODELVIEW_PROJECTION_NV        = 0x8629;
        public const uint GL_IDENTITY_NV                    = 0x862A;
        public const uint GL_INVERSE_NV                     = 0x862B;
        public const uint GL_TRANSPOSE_NV                   = 0x862C;
        public const uint GL_INVERSE_TRANSPOSE_NV           = 0x862D;
        public const uint GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV = 0x862E;
        public const uint GL_MAX_TRACK_MATRICES_NV          = 0x862F;
        public const uint GL_MATRIX0_NV                     = 0x8630;
        public const uint GL_MATRIX1_NV                     = 0x8631;
        public const uint GL_MATRIX2_NV                     = 0x8632;
        public const uint GL_MATRIX3_NV                     = 0x8633;
        public const uint GL_MATRIX4_NV                     = 0x8634;
        public const uint GL_MATRIX5_NV                     = 0x8635;
        public const uint GL_MATRIX6_NV                     = 0x8636;
        public const uint GL_MATRIX7_NV                     = 0x8637;
        public const uint GL_CURRENT_MATRIX_STACK_DEPTH_NV  = 0x8640;
        public const uint GL_CURRENT_MATRIX_NV              = 0x8641;
        public const uint GL_VERTEX_PROGRAM_POINT_SIZE_NV   = 0x8642;
        public const uint GL_VERTEX_PROGRAM_TWO_SIDE_NV     = 0x8643;
        public const uint GL_PROGRAM_PARAMETER_NV           = 0x8644;
        public const uint GL_ATTRIB_ARRAY_POINTER_NV        = 0x8645;
        public const uint GL_PROGRAM_TARGET_NV              = 0x8646;
        public const uint GL_PROGRAM_RESIDENT_NV            = 0x8647;
        public const uint GL_TRACK_MATRIX_NV                = 0x8648;
        public const uint GL_TRACK_MATRIX_TRANSFORM_NV      = 0x8649;
        public const uint GL_VERTEX_PROGRAM_BINDING_NV      = 0x864A;
        public const uint GL_PROGRAM_ERROR_POSITION_NV      = 0x864B;
        public const uint GL_VERTEX_ATTRIB_ARRAY0_NV        = 0x8650;
        public const uint GL_VERTEX_ATTRIB_ARRAY1_NV        = 0x8651;
        public const uint GL_VERTEX_ATTRIB_ARRAY2_NV        = 0x8652;
        public const uint GL_VERTEX_ATTRIB_ARRAY3_NV        = 0x8653;
        public const uint GL_VERTEX_ATTRIB_ARRAY4_NV        = 0x8654;
        public const uint GL_VERTEX_ATTRIB_ARRAY5_NV        = 0x8655;
        public const uint GL_VERTEX_ATTRIB_ARRAY6_NV        = 0x8656;
        public const uint GL_VERTEX_ATTRIB_ARRAY7_NV        = 0x8657;
        public const uint GL_VERTEX_ATTRIB_ARRAY8_NV        = 0x8658;
        public const uint GL_VERTEX_ATTRIB_ARRAY9_NV        = 0x8659;
        public const uint GL_VERTEX_ATTRIB_ARRAY10_NV       = 0x865A;
        public const uint GL_VERTEX_ATTRIB_ARRAY11_NV       = 0x865B;
        public const uint GL_VERTEX_ATTRIB_ARRAY12_NV       = 0x865C;
        public const uint GL_VERTEX_ATTRIB_ARRAY13_NV       = 0x865D;
        public const uint GL_VERTEX_ATTRIB_ARRAY14_NV       = 0x865E;
        public const uint GL_VERTEX_ATTRIB_ARRAY15_NV       = 0x865F;
        public const uint GL_MAP1_VERTEX_ATTRIB0_4_NV       = 0x8660;
        public const uint GL_MAP1_VERTEX_ATTRIB1_4_NV       = 0x8661;
        public const uint GL_MAP1_VERTEX_ATTRIB2_4_NV       = 0x8662;
        public const uint GL_MAP1_VERTEX_ATTRIB3_4_NV       = 0x8663;
        public const uint GL_MAP1_VERTEX_ATTRIB4_4_NV       = 0x8664;
        public const uint GL_MAP1_VERTEX_ATTRIB5_4_NV       = 0x8665;
        public const uint GL_MAP1_VERTEX_ATTRIB6_4_NV       = 0x8666;
        public const uint GL_MAP1_VERTEX_ATTRIB7_4_NV       = 0x8667;
        public const uint GL_MAP1_VERTEX_ATTRIB8_4_NV       = 0x8668;
        public const uint GL_MAP1_VERTEX_ATTRIB9_4_NV       = 0x8669;
        public const uint GL_MAP1_VERTEX_ATTRIB10_4_NV      = 0x866A;
        public const uint GL_MAP1_VERTEX_ATTRIB11_4_NV      = 0x866B;
        public const uint GL_MAP1_VERTEX_ATTRIB12_4_NV      = 0x866C;
        public const uint GL_MAP1_VERTEX_ATTRIB13_4_NV      = 0x866D;
        public const uint GL_MAP1_VERTEX_ATTRIB14_4_NV      = 0x866E;
        public const uint GL_MAP1_VERTEX_ATTRIB15_4_NV      = 0x866F;
        public const uint GL_MAP2_VERTEX_ATTRIB0_4_NV       = 0x8670;
        public const uint GL_MAP2_VERTEX_ATTRIB1_4_NV       = 0x8671;
        public const uint GL_MAP2_VERTEX_ATTRIB2_4_NV       = 0x8672;
        public const uint GL_MAP2_VERTEX_ATTRIB3_4_NV       = 0x8673;
        public const uint GL_MAP2_VERTEX_ATTRIB4_4_NV       = 0x8674;
        public const uint GL_MAP2_VERTEX_ATTRIB5_4_NV       = 0x8675;
        public const uint GL_MAP2_VERTEX_ATTRIB6_4_NV       = 0x8676;
        public const uint GL_MAP2_VERTEX_ATTRIB7_4_NV       = 0x8677;
        public const uint GL_MAP2_VERTEX_ATTRIB8_4_NV       = 0x8678;
        public const uint GL_MAP2_VERTEX_ATTRIB9_4_NV       = 0x8679;
        public const uint GL_MAP2_VERTEX_ATTRIB10_4_NV      = 0x867A;
        public const uint GL_MAP2_VERTEX_ATTRIB11_4_NV      = 0x867B;
        public const uint GL_MAP2_VERTEX_ATTRIB12_4_NV      = 0x867C;
        public const uint GL_MAP2_VERTEX_ATTRIB13_4_NV      = 0x867D;
        public const uint GL_MAP2_VERTEX_ATTRIB14_4_NV      = 0x867E;
        public const uint GL_MAP2_VERTEX_ATTRIB15_4_NV      = 0x867F;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_copy_depth_to_color
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DEPTH_STENCIL_TO_RGBA_NV       = 0x886E;
        public const uint GL_DEPTH_STENCIL_TO_BGRA_NV       = 0x886F;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_multisample_filter_hint
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MULTISAMPLE_FILTER_HINT_NV     = 0x8534;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_depth_clamp
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DEPTH_CLAMP_NV                 = 0x864F;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_occlusion_query
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PIXEL_COUNTER_BITS_NV          = 0x8864;
        public const uint GL_CURRENT_OCCLUSION_QUERY_ID_NV  = 0x8865;
        public const uint GL_PIXEL_COUNT_NV                 = 0x8866;
        public const uint GL_PIXEL_COUNT_AVAILABLE_NV       = 0x8867;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_point_sprite
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_POINT_SPRITE_NV                = 0x8861;
        public const uint GL_COORD_REPLACE_NV               = 0x8862;
        public const uint GL_POINT_SPRITE_R_MODE_NV         = 0x8863;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_shader3
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_OFFSET_PROJECTIVE_TEXTURE_2D_NV = 0x8850;
        public const uint GL_OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV = 0x8851;
        public const uint GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8852;
        public const uint GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV = 0x8853;
        public const uint GL_OFFSET_HILO_TEXTURE_2D_NV      = 0x8854;
        public const uint GL_OFFSET_HILO_TEXTURE_RECTANGLE_NV = 0x8855;
        public const uint GL_OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV = 0x8856;
        public const uint GL_OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8857;
        public const uint GL_DEPENDENT_HILO_TEXTURE_2D_NV   = 0x8858;
        public const uint GL_DEPENDENT_RGB_TEXTURE_3D_NV    = 0x8859;
        public const uint GL_DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV = 0x885A;
        public const uint GL_DOT_PRODUCT_PASS_THROUGH_NV    = 0x885B;
        public const uint GL_DOT_PRODUCT_TEXTURE_1D_NV      = 0x885C;
        public const uint GL_DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV = 0x885D;
        public const uint GL_HILO8_NV                       = 0x885E;
        public const uint GL_SIGNED_HILO8_NV                = 0x885F;
        public const uint GL_FORCE_BLUE_TO_ONE_NV           = 0x8860;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_program1_1 (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_float_buffer
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FLOAT_R_NV                     = 0x8880;
        public const uint GL_FLOAT_RG_NV                    = 0x8881;
        public const uint GL_FLOAT_RGB_NV                   = 0x8882;
        public const uint GL_FLOAT_RGBA_NV                  = 0x8883;
        public const uint GL_FLOAT_R16_NV                   = 0x8884;
        public const uint GL_FLOAT_R32_NV                   = 0x8885;
        public const uint GL_FLOAT_RG16_NV                  = 0x8886;
        public const uint GL_FLOAT_RG32_NV                  = 0x8887;
        public const uint GL_FLOAT_RGB16_NV                 = 0x8888;
        public const uint GL_FLOAT_RGB32_NV                 = 0x8889;
        public const uint GL_FLOAT_RGBA16_NV                = 0x888A;
        public const uint GL_FLOAT_RGBA32_NV                = 0x888B;
        public const uint GL_TEXTURE_FLOAT_COMPONENTS_NV    = 0x888C;
        public const uint GL_FLOAT_CLEAR_COLOR_VALUE_NV     = 0x888D;
        public const uint GL_FLOAT_RGBA_MODE_NV             = 0x888E;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fragment_program
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_FRAGMENT_PROGRAM_LOCAL_PARAMETERS_NV = 0x8868;
        public const uint GL_FRAGMENT_PROGRAM_NV            = 0x8870;
        public const uint GL_MAX_TEXTURE_COORDS_NV          = 0x8871;
        public const uint GL_MAX_TEXTURE_IMAGE_UNITS_NV     = 0x8872;
        public const uint GL_FRAGMENT_PROGRAM_BINDING_NV    = 0x8873;
        public const uint GL_PROGRAM_ERROR_STRING_NV        = 0x8874;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_half_float
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_HALF_FLOAT_NV                  = 0x140B;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_pixel_data_range
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_WRITE_PIXEL_DATA_RANGE_NV      = 0x8878;
        public const uint GL_READ_PIXEL_DATA_RANGE_NV       = 0x8879;
        public const uint GL_WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A;
        public const uint GL_READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B;
        public const uint GL_WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C;
        public const uint GL_READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_primitive_restart
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PRIMITIVE_RESTART_NV           = 0x8558;
        public const uint GL_PRIMITIVE_RESTART_INDEX_NV     = 0x8559;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_expand_normal
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_UNSIGNED_REMAP_MODE_NV = 0x888F;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_program2 (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fragment_program_option (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fragment_program2
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV = 0x88F4;
        public const uint GL_MAX_PROGRAM_CALL_DEPTH_NV      = 0x88F5;
        public const uint GL_MAX_PROGRAM_IF_DEPTH_NV        = 0x88F6;
        public const uint GL_MAX_PROGRAM_LOOP_DEPTH_NV      = 0x88F7;
        public const uint GL_MAX_PROGRAM_LOOP_COUNT_NV      = 0x88F8;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_program2_option
        ///////////////////////////////////////////////////////////////////////
        /* reuse GL_MAX_PROGRAM_EXEC_INSTRUCTIONS_NV */
        /* reuse GL_MAX_PROGRAM_CALL_DEPTH_NV */

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_program3
        ///////////////////////////////////////////////////////////////////////
        /* reuse GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB */
        
        ///////////////////////////////////////////////////////////////////////
        // GL_NV_gpu_program4
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MIN_PROGRAM_TEXEL_OFFSET_NV    = 0x8904;
        public const uint GL_MAX_PROGRAM_TEXEL_OFFSET_NV    = 0x8905;
        public const uint GL_PROGRAM_ATTRIB_COMPONENTS_NV   = 0x8906;
        public const uint GL_PROGRAM_RESULT_COMPONENTS_NV   = 0x8907;
        public const uint GL_MAX_PROGRAM_ATTRIB_COMPONENTS_NV = 0x8908;
        public const uint GL_MAX_PROGRAM_RESULT_COMPONENTS_NV = 0x8909;
        public const uint GL_MAX_PROGRAM_GENERIC_ATTRIBS_NV = 0x8DA5;
        public const uint GL_MAX_PROGRAM_GENERIC_RESULTS_NV = 0x8DA6;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_geometry_program4
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_LINES_ADJACENCY_EXT            = 0x000A;
        public const uint GL_LINE_STRIP_ADJACENCY_EXT       = 0x000B;
        public const uint GL_TRIANGLES_ADJACENCY_EXT        = 0x000C;
        public const uint GL_TRIANGLE_STRIP_ADJACENCY_EXT   = 0x000D;
        public const uint GL_GEOMETRY_PROGRAM_NV            = 0x8C26;
        public const uint GL_MAX_PROGRAM_OUTPUT_VERTICES_NV = 0x8C27;
        public const uint GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV = 0x8C28;
        public const uint GL_GEOMETRY_VERTICES_OUT_EXT      = 0x8DDA;
        public const uint GL_GEOMETRY_INPUT_TYPE_EXT        = 0x8DDB;
        public const uint GL_GEOMETRY_OUTPUT_TYPE_EXT       = 0x8DDC;
        public const uint GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT = 0x8C29;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT = 0x8DA7;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT = 0x8DA8;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT = 0x8DA9;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4;
        public const uint GL_PROGRAM_POINT_SIZE_EXT         = 0x8642;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_program4
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_ATTRIB_ARRAY_INTEGER_NV = 0x88FD;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_depth_buffer_float
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DEPTH_COMPONENT32F_NV          = 0x8DAB;
        public const uint GL_DEPTH32F_STENCIL8_NV           = 0x8DAC;
        public const uint GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV = 0x8DAD;
        public const uint GL_DEPTH_BUFFER_FLOAT_MODE_NV     = 0x8DAF;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_fragment_program4 (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_framebuffer_multisample_coverage
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB;
        public const uint GL_RENDERBUFFER_COLOR_SAMPLES_NV  = 0x8E10;
        public const uint GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E11;
        public const uint GL_MULTISAMPLE_COVERAGE_MODES_NV  = 0x8E12;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_geometry_shader4
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_parameter_buffer_object
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV = 0x8DA0;
        public const uint GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV = 0x8DA1;
        public const uint GL_VERTEX_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA2;
        public const uint GL_GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA3;
        public const uint GL_FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA4;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_transform_feedback
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_BACK_PRIMARY_COLOR_NV          = 0x8C77;
        public const uint GL_BACK_SECONDARY_COLOR_NV        = 0x8C78;
        public const uint GL_TEXTURE_COORD_NV               = 0x8C79;
        public const uint GL_CLIP_DISTANCE_NV               = 0x8C7A;
        public const uint GL_VERTEX_ID_NV                   = 0x8C7B;
        public const uint GL_PRIMITIVE_ID_NV                = 0x8C7C;
        public const uint GL_GENERIC_ATTRIB_NV              = 0x8C7D;
        public const uint GL_TRANSFORM_FEEDBACK_ATTRIBS_NV  = 0x8C7E;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_MODE_NV = 0x8C7F;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV = 0x8C80;
        public const uint GL_ACTIVE_VARYINGS_NV             = 0x8C81;
        public const uint GL_ACTIVE_VARYING_MAX_LENGTH_NV   = 0x8C82;
        public const uint GL_TRANSFORM_FEEDBACK_VARYINGS_NV = 0x8C83;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_START_NV = 0x8C84;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_NV = 0x8C85;
        public const uint GL_TRANSFORM_FEEDBACK_RECORD_NV   = 0x8C86;
        public const uint GL_PRIMITIVES_GENERATED_NV        = 0x8C87;
        public const uint GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV = 0x8C88;
        public const uint GL_RASTERIZER_DISCARD_NV          = 0x8C89;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_ATTRIBS_NV = 0x8C8A;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV = 0x8C8B;
        public const uint GL_INTERLEAVED_ATTRIBS_NV         = 0x8C8C;
        public const uint GL_SEPARATE_ATTRIBS_NV            = 0x8C8D;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_NV   = 0x8C8E;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_NV = 0x8C8F;
        public const uint GL_LAYER_NV                       = 0x8DAA;
        public const  int GL_NEXT_BUFFER_NV                 = -2;
        public const  int GL_SKIP_COMPONENTS4_NV            = -3;
        public const  int GL_SKIP_COMPONENTS3_NV            = -4;
        public const  int GL_SKIP_COMPONENTS2_NV            = -5;
        public const  int GL_SKIP_COMPONENTS1_NV            = -6;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_conditional_render
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_QUERY_WAIT_NV                  = 0x8E13;
        public const uint GL_QUERY_NO_WAIT_NV               = 0x8E14;
        public const uint GL_QUERY_BY_REGION_WAIT_NV        = 0x8E15;
        public const uint GL_QUERY_BY_REGION_NO_WAIT_NV     = 0x8E16;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_present_video
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FRAME_NV                       = 0x8E26;
        public const uint GL_FIELDS_NV                      = 0x8E27;
        public const uint GL_CURRENT_TIME_NV                = 0x8E28;
        public const uint GL_NUM_FILL_STREAMS_NV            = 0x8E29;
        public const uint GL_PRESENT_TIME_NV                = 0x8E2A;
        public const uint GL_PRESENT_DURATION_NV            = 0x8E2B;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_explicit_multisample
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SAMPLE_POSITION_NV             = 0x8E50;
        public const uint GL_SAMPLE_MASK_NV                 = 0x8E51;
        public const uint GL_SAMPLE_MASK_VALUE_NV           = 0x8E52;
        public const uint GL_TEXTURE_BINDING_RENDERBUFFER_NV = 0x8E53;
        public const uint GL_TEXTURE_RENDERBUFFER_DATA_STORE_BINDING_NV = 0x8E54;
        public const uint GL_TEXTURE_RENDERBUFFER_NV        = 0x8E55;
        public const uint GL_SAMPLER_RENDERBUFFER_NV        = 0x8E56;
        public const uint GL_INT_SAMPLER_RENDERBUFFER_NV    = 0x8E57;
        public const uint GL_UNSIGNED_INT_SAMPLER_RENDERBUFFER_NV = 0x8E58;
        public const uint GL_MAX_SAMPLE_MASK_WORDS_NV       = 0x8E59;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_transform_feedback2
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TRANSFORM_FEEDBACK_NV          = 0x8E22;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED_NV = 0x8E23;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE_NV = 0x8E24;
        public const uint GL_TRANSFORM_FEEDBACK_BINDING_NV  = 0x8E25;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_video_capture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VIDEO_BUFFER_NV                = 0x9020;
        public const uint GL_VIDEO_BUFFER_BINDING_NV        = 0x9021;
        public const uint GL_FIELD_UPPER_NV                 = 0x9022;
        public const uint GL_FIELD_LOWER_NV                 = 0x9023;
        public const uint GL_NUM_VIDEO_CAPTURE_STREAMS_NV   = 0x9024;
        public const uint GL_NEXT_VIDEO_CAPTURE_BUFFER_STATUS_NV = 0x9025;
        public const uint GL_VIDEO_CAPTURE_TO_422_SUPPORTED_NV = 0x9026;
        public const uint GL_LAST_VIDEO_CAPTURE_STATUS_NV   = 0x9027;
        public const uint GL_VIDEO_BUFFER_PITCH_NV          = 0x9028;
        public const uint GL_VIDEO_COLOR_CONVERSION_MATRIX_NV = 0x9029;
        public const uint GL_VIDEO_COLOR_CONVERSION_MAX_NV  = 0x902A;
        public const uint GL_VIDEO_COLOR_CONVERSION_MIN_NV  = 0x902B;
        public const uint GL_VIDEO_COLOR_CONVERSION_OFFSET_NV = 0x902C;
        public const uint GL_VIDEO_BUFFER_INTERNAL_FORMAT_NV = 0x902D;
        public const uint GL_PARTIAL_SUCCESS_NV             = 0x902E;
        public const uint GL_SUCCESS_NV                     = 0x902F;
        public const uint GL_FAILURE_NV                     = 0x9030;
        public const uint GL_YCBYCR8_422_NV                 = 0x9031;
        public const uint GL_YCBAYCR8A_4224_NV              = 0x9032;
        public const uint GL_Z6Y10Z6CB10Z6Y10Z6CR10_422_NV  = 0x9033;
        public const uint GL_Z6Y10Z6CB10Z6A10Z6Y10Z6CR10Z6A10_4224_NV = 0x9034;
        public const uint GL_Z4Y12Z4CB12Z4Y12Z4CR12_422_NV  = 0x9035;
        public const uint GL_Z4Y12Z4CB12Z4A12Z4Y12Z4CR12Z4A12_4224_NV = 0x9036;
        public const uint GL_Z4Y12Z4CB12Z4CR12_444_NV       = 0x9037;
        public const uint GL_VIDEO_CAPTURE_FRAME_WIDTH_NV   = 0x9038;
        public const uint GL_VIDEO_CAPTURE_FRAME_HEIGHT_NV  = 0x9039;
        public const uint GL_VIDEO_CAPTURE_FIELD_UPPER_HEIGHT_NV = 0x903A;
        public const uint GL_VIDEO_CAPTURE_FIELD_LOWER_HEIGHT_NV = 0x903B;
        public const uint GL_VIDEO_CAPTURE_SURFACE_ORIGIN_NV = 0x903C;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_copy_image (no constants)
        ///////////////////////////////////////////////////////////////////////
 
        ///////////////////////////////////////////////////////////////////////
        // GL_NV_parameter_buffer_object2
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_buffer_load
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_BUFFER_GPU_ADDRESS_NV          = 0x8F1D;
        public const uint GL_GPU_ADDRESS_NV                 = 0x8F34;
        public const uint GL_MAX_SHADER_BUFFER_ADDRESS_NV   = 0x8F35;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_buffer_unified_memory
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_ATTRIB_ARRAY_UNIFIED_NV = 0x8F1E;
        public const uint GL_ELEMENT_ARRAY_UNIFIED_NV       = 0x8F1F;
        public const uint GL_VERTEX_ATTRIB_ARRAY_ADDRESS_NV = 0x8F20;
        public const uint GL_VERTEX_ARRAY_ADDRESS_NV        = 0x8F21;
        public const uint GL_NORMAL_ARRAY_ADDRESS_NV        = 0x8F22;
        public const uint GL_COLOR_ARRAY_ADDRESS_NV         = 0x8F23;
        public const uint GL_INDEX_ARRAY_ADDRESS_NV         = 0x8F24;
        public const uint GL_TEXTURE_COORD_ARRAY_ADDRESS_NV = 0x8F25;
        public const uint GL_EDGE_FLAG_ARRAY_ADDRESS_NV     = 0x8F26;
        public const uint GL_SECONDARY_COLOR_ARRAY_ADDRESS_NV = 0x8F27;
        public const uint GL_FOG_COORD_ARRAY_ADDRESS_NV     = 0x8F28;
        public const uint GL_ELEMENT_ARRAY_ADDRESS_NV       = 0x8F29;
        public const uint GL_VERTEX_ATTRIB_ARRAY_LENGTH_NV  = 0x8F2A;
        public const uint GL_VERTEX_ARRAY_LENGTH_NV         = 0x8F2B;
        public const uint GL_NORMAL_ARRAY_LENGTH_NV         = 0x8F2C;
        public const uint GL_COLOR_ARRAY_LENGTH_NV          = 0x8F2D;
        public const uint GL_INDEX_ARRAY_LENGTH_NV          = 0x8F2E;
        public const uint GL_TEXTURE_COORD_ARRAY_LENGTH_NV  = 0x8F2F;
        public const uint GL_EDGE_FLAG_ARRAY_LENGTH_NV      = 0x8F30;
        public const uint GL_SECONDARY_COLOR_ARRAY_LENGTH_NV = 0x8F31;
        public const uint GL_FOG_COORD_ARRAY_LENGTH_NV      = 0x8F32;
        public const uint GL_ELEMENT_ARRAY_LENGTH_NV        = 0x8F33;
        public const uint GL_DRAW_INDIRECT_UNIFIED_NV       = 0x8F40;
        public const uint GL_DRAW_INDIRECT_ADDRESS_NV       = 0x8F41;
        public const uint GL_DRAW_INDIRECT_LENGTH_NV        = 0x8F42;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_barrier (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_gpu_program5
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_GEOMETRY_PROGRAM_INVOCATIONS_NV = 0x8E5A;
        public const uint GL_MIN_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5B;
        public const uint GL_MAX_FRAGMENT_INTERPOLATION_OFFSET_NV = 0x8E5C;
        public const uint GL_FRAGMENT_PROGRAM_INTERPOLATION_OFFSET_BITS_NV = 0x8E5D;
        public const uint GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5E;
        public const uint GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_NV = 0x8E5F;
        public const uint GL_MAX_PROGRAM_SUBROUTINE_PARAMETERS_NV = 0x8F44;
        public const uint GL_MAX_PROGRAM_SUBROUTINE_NUM_NV  = 0x8F45;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_gpu_shader5
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_INT64_NV                       = 0x140E;
        public const uint GL_UNSIGNED_INT64_NV              = 0x140F;
        public const uint GL_INT8_NV                        = 0x8FE0;
        public const uint GL_INT8_VEC2_NV                   = 0x8FE1;
        public const uint GL_INT8_VEC3_NV                   = 0x8FE2;
        public const uint GL_INT8_VEC4_NV                   = 0x8FE3;
        public const uint GL_INT16_NV                       = 0x8FE4;
        public const uint GL_INT16_VEC2_NV                  = 0x8FE5;
        public const uint GL_INT16_VEC3_NV                  = 0x8FE6;
        public const uint GL_INT16_VEC4_NV                  = 0x8FE7;
        public const uint GL_INT64_VEC2_NV                  = 0x8FE9;
        public const uint GL_INT64_VEC3_NV                  = 0x8FEA;
        public const uint GL_INT64_VEC4_NV                  = 0x8FEB;
        public const uint GL_UNSIGNED_INT8_NV               = 0x8FEC;
        public const uint GL_UNSIGNED_INT8_VEC2_NV          = 0x8FED;
        public const uint GL_UNSIGNED_INT8_VEC3_NV          = 0x8FEE;
        public const uint GL_UNSIGNED_INT8_VEC4_NV          = 0x8FEF;
        public const uint GL_UNSIGNED_INT16_NV              = 0x8FF0;
        public const uint GL_UNSIGNED_INT16_VEC2_NV         = 0x8FF1;
        public const uint GL_UNSIGNED_INT16_VEC3_NV         = 0x8FF2;
        public const uint GL_UNSIGNED_INT16_VEC4_NV         = 0x8FF3;
        public const uint GL_UNSIGNED_INT64_VEC2_NV         = 0x8FF5;
        public const uint GL_UNSIGNED_INT64_VEC3_NV         = 0x8FF6;
        public const uint GL_UNSIGNED_INT64_VEC4_NV         = 0x8FF7;
        public const uint GL_FLOAT16_NV                     = 0x8FF8;
        public const uint GL_FLOAT16_VEC2_NV                = 0x8FF9;
        public const uint GL_FLOAT16_VEC3_NV                = 0x8FFA;
        public const uint GL_FLOAT16_VEC4_NV                = 0x8FFB;
        /* reuse GL_PATCHES */

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_buffer_store
        ///////////////////////////////////////////////////////////////////////
 
        public const uint GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV = 0x00000010;
        /* reuse GL_READ_WRITE */
        /* reuse GL_WRITE_ONLY */

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_tessellation_program5
        ///////////////////////////////////////////////////////////////////////
 
        public const uint GL_MAX_PROGRAM_PATCH_ATTRIBS_NV   = 0x86D8;
        public const uint GL_TESS_CONTROL_PROGRAM_NV        = 0x891E;
        public const uint GL_TESS_EVALUATION_PROGRAM_NV     = 0x891F;
        public const uint GL_TESS_CONTROL_PROGRAM_PARAMETER_BUFFER_NV = 0x8C74;
        public const uint GL_TESS_EVALUATION_PROGRAM_PARAMETER_BUFFER_NV = 0x8C75;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vertex_attrib_integer_64bit
        ///////////////////////////////////////////////////////////////////////
        /* reuse GL_INT64_NV */
        /* reuse GL_UNSIGNED_INT64_NV */

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_multisample_coverage
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COVERAGE_SAMPLES_NV            = 0x80A9;
        public const uint GL_COLOR_SAMPLES_NV               = 0x8E20;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_vdpau_interop
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SURFACE_STATE_NV               = 0x86EB;
        public const uint GL_SURFACE_REGISTERED_NV          = 0x86FD;
        public const uint GL_SURFACE_MAPPED_NV              = 0x8700;
        public const uint GL_WRITE_DISCARD_NV               = 0x88BE;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_texture_multisample
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_COVERAGE_SAMPLES_NV    = 0x9045;
        public const uint GL_TEXTURE_COLOR_SAMPLES_NV       = 0x9046;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_path_rendering
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PATH_FORMAT_SVG_NV             = 0x9070;
        public const uint GL_PATH_FORMAT_PS_NV              = 0x9071;
        public const uint GL_STANDARD_FONT_NAME_NV          = 0x9072;
        public const uint GL_SYSTEM_FONT_NAME_NV            = 0x9073;
        public const uint GL_FILE_NAME_NV                   = 0x9074;
        public const uint GL_PATH_STROKE_WIDTH_NV           = 0x9075;
        public const uint GL_PATH_END_CAPS_NV               = 0x9076;
        public const uint GL_PATH_INITIAL_END_CAP_NV        = 0x9077;
        public const uint GL_PATH_TERMINAL_END_CAP_NV       = 0x9078;
        public const uint GL_PATH_JOIN_STYLE_NV             = 0x9079;
        public const uint GL_PATH_MITER_LIMIT_NV            = 0x907A;
        public const uint GL_PATH_DASH_CAPS_NV              = 0x907B;
        public const uint GL_PATH_INITIAL_DASH_CAP_NV       = 0x907C;
        public const uint GL_PATH_TERMINAL_DASH_CAP_NV      = 0x907D;
        public const uint GL_PATH_DASH_OFFSET_NV            = 0x907E;
        public const uint GL_PATH_CLIENT_LENGTH_NV          = 0x907F;
        public const uint GL_PATH_FILL_MODE_NV              = 0x9080;
        public const uint GL_PATH_FILL_MASK_NV              = 0x9081;
        public const uint GL_PATH_FILL_COVER_MODE_NV        = 0x9082;
        public const uint GL_PATH_STROKE_COVER_MODE_NV      = 0x9083;
        public const uint GL_PATH_STROKE_MASK_NV            = 0x9084;
        public const uint GL_PATH_SAMPLE_QUALITY_NV         = 0x9085;
        public const uint GL_PATH_STROKE_BOUND_NV           = 0x9086;
        public const uint GL_PATH_STROKE_OVERSAMPLE_COUNT_NV = 0x9087;
        public const uint GL_COUNT_UP_NV                    = 0x9088;
        public const uint GL_COUNT_DOWN_NV                  = 0x9089;
        public const uint GL_PATH_OBJECT_BOUNDING_BOX_NV    = 0x908A;
        public const uint GL_CONVEX_HULL_NV                 = 0x908B;
        public const uint GL_MULTI_HULLS_NV                 = 0x908C;
        public const uint GL_BOUNDING_BOX_NV                = 0x908D;
        public const uint GL_TRANSLATE_X_NV                 = 0x908E;
        public const uint GL_TRANSLATE_Y_NV                 = 0x908F;
        public const uint GL_TRANSLATE_2D_NV                = 0x9090;
        public const uint GL_TRANSLATE_3D_NV                = 0x9091;
        public const uint GL_AFFINE_2D_NV                   = 0x9092;
        public const uint GL_PROJECTIVE_2D_NV               = 0x9093;
        public const uint GL_AFFINE_3D_NV                   = 0x9094;
        public const uint GL_PROJECTIVE_3D_NV               = 0x9095;
        public const uint GL_TRANSPOSE_AFFINE_2D_NV         = 0x9096;
        public const uint GL_TRANSPOSE_PROJECTIVE_2D_NV     = 0x9097;
        public const uint GL_TRANSPOSE_AFFINE_3D_NV         = 0x9098;
        public const uint GL_TRANSPOSE_PROJECTIVE_3D_NV     = 0x9099;
        public const uint GL_UTF8_NV                        = 0x909A;
        public const uint GL_UTF16_NV                       = 0x909B;
        public const uint GL_BOUNDING_BOX_OF_BOUNDING_BOXES_NV = 0x909C;
        public const uint GL_PATH_COMMAND_COUNT_NV          = 0x909D;
        public const uint GL_PATH_COORD_COUNT_NV            = 0x909E;
        public const uint GL_PATH_DASH_ARRAY_COUNT_NV       = 0x909F;
        public const uint GL_PATH_COMPUTED_LENGTH_NV        = 0x90A0;
        public const uint GL_PATH_FILL_BOUNDING_BOX_NV      = 0x90A1;
        public const uint GL_PATH_STROKE_BOUNDING_BOX_NV    = 0x90A2;
        public const uint GL_SQUARE_NV                      = 0x90A3;
        public const uint GL_ROUND_NV                       = 0x90A4;
        public const uint GL_TRIANGULAR_NV                  = 0x90A5;
        public const uint GL_BEVEL_NV                       = 0x90A6;
        public const uint GL_MITER_REVERT_NV                = 0x90A7;
        public const uint GL_MITER_TRUNCATE_NV              = 0x90A8;
        public const uint GL_SKIP_MISSING_GLYPH_NV          = 0x90A9;
        public const uint GL_USE_MISSING_GLYPH_NV           = 0x90AA;
        public const uint GL_PATH_ERROR_POSITION_NV         = 0x90AB;
        public const uint GL_PATH_FOG_GEN_MODE_NV           = 0x90AC;
        public const uint GL_ACCUM_ADJACENT_PAIRS_NV        = 0x90AD;
        public const uint GL_ADJACENT_PAIRS_NV              = 0x90AE;
        public const uint GL_FIRST_TO_REST_NV               = 0x90AF;
        public const uint GL_PATH_GEN_MODE_NV               = 0x90B0;
        public const uint GL_PATH_GEN_COEFF_NV              = 0x90B1;
        public const uint GL_PATH_GEN_COLOR_FORMAT_NV       = 0x90B2;
        public const uint GL_PATH_GEN_COMPONENTS_NV         = 0x90B3;
        public const uint GL_PATH_STENCIL_FUNC_NV           = 0x90B7;
        public const uint GL_PATH_STENCIL_REF_NV            = 0x90B8;
        public const uint GL_PATH_STENCIL_VALUE_MASK_NV     = 0x90B9;
        public const uint GL_PATH_STENCIL_DEPTH_OFFSET_FACTOR_NV = 0x90BD;
        public const uint GL_PATH_STENCIL_DEPTH_OFFSET_UNITS_NV = 0x90BE;
        public const uint GL_PATH_COVER_DEPTH_FUNC_NV       = 0x90BF;
        public const uint GL_PATH_DASH_OFFSET_RESET_NV      = 0x90B4;
        public const uint GL_MOVE_TO_RESETS_NV              = 0x90B5;
        public const uint GL_MOVE_TO_CONTINUES_NV           = 0x90B6;
        public const uint GL_CLOSE_PATH_NV                  = 0x00;
        public const uint GL_MOVE_TO_NV                     = 0x02;
        public const uint GL_RELATIVE_MOVE_TO_NV            = 0x03;
        public const uint GL_LINE_TO_NV                     = 0x04;
        public const uint GL_RELATIVE_LINE_TO_NV            = 0x05;
        public const uint GL_HORIZONTAL_LINE_TO_NV          = 0x06;
        public const uint GL_RELATIVE_HORIZONTAL_LINE_TO_NV = 0x07;
        public const uint GL_VERTICAL_LINE_TO_NV            = 0x08;
        public const uint GL_RELATIVE_VERTICAL_LINE_TO_NV   = 0x09;
        public const uint GL_QUADRATIC_CURVE_TO_NV          = 0x0A;
        public const uint GL_RELATIVE_QUADRATIC_CURVE_TO_NV = 0x0B;
        public const uint GL_CUBIC_CURVE_TO_NV              = 0x0C;
        public const uint GL_RELATIVE_CUBIC_CURVE_TO_NV     = 0x0D;
        public const uint GL_SMOOTH_QUADRATIC_CURVE_TO_NV   = 0x0E;
        public const uint GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV = 0x0F;
        public const uint GL_SMOOTH_CUBIC_CURVE_TO_NV       = 0x10;
        public const uint GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV = 0x11;
        public const uint GL_SMALL_CCW_ARC_TO_NV            = 0x12;
        public const uint GL_RELATIVE_SMALL_CCW_ARC_TO_NV   = 0x13;
        public const uint GL_SMALL_CW_ARC_TO_NV             = 0x14;
        public const uint GL_RELATIVE_SMALL_CW_ARC_TO_NV    = 0x15;
        public const uint GL_LARGE_CCW_ARC_TO_NV            = 0x16;
        public const uint GL_RELATIVE_LARGE_CCW_ARC_TO_NV   = 0x17;
        public const uint GL_LARGE_CW_ARC_TO_NV             = 0x18;
        public const uint GL_RELATIVE_LARGE_CW_ARC_TO_NV    = 0x19;
        public const uint GL_RESTART_PATH_NV                = 0xF0;
        public const uint GL_DUP_FIRST_CUBIC_CURVE_TO_NV    = 0xF2;
        public const uint GL_DUP_LAST_CUBIC_CURVE_TO_NV     = 0xF4;
        public const uint GL_RECT_NV                        = 0xF6;
        public const uint GL_CIRCULAR_CCW_ARC_TO_NV         = 0xF8;
        public const uint GL_CIRCULAR_CW_ARC_TO_NV          = 0xFA;
        public const uint GL_CIRCULAR_TANGENT_ARC_TO_NV     = 0xFC;
        public const uint GL_ARC_TO_NV                      = 0xFE;
        public const uint GL_RELATIVE_ARC_TO_NV             = 0xFF;
        public const uint GL_BOLD_BIT_NV                    = 0x01;
        public const uint GL_ITALIC_BIT_NV                  = 0x02;
        public const uint GL_GLYPH_WIDTH_BIT_NV             = 0x01;
        public const uint GL_GLYPH_HEIGHT_BIT_NV            = 0x02;
        public const uint GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV = 0x04;
        public const uint GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV = 0x08;
        public const uint GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV = 0x10;
        public const uint GL_GLYPH_VERTICAL_BEARING_X_BIT_NV = 0x20;
        public const uint GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV = 0x40;
        public const uint GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV = 0x80;
        public const uint GL_GLYPH_HAS_KERNING_NV           = 0x100;
        public const uint GL_FONT_X_MIN_BOUNDS_NV           = 0x00010000;
        public const uint GL_FONT_Y_MIN_BOUNDS_NV           = 0x00020000;
        public const uint GL_FONT_X_MAX_BOUNDS_NV           = 0x00040000;
        public const uint GL_FONT_Y_MAX_BOUNDS_NV           = 0x00080000;
        public const uint GL_FONT_UNITS_PER_EM_NV           = 0x00100000;
        public const uint GL_FONT_ASCENDER_NV               = 0x00200000;
        public const uint GL_FONT_DESCENDER_NV              = 0x00400000;
        public const uint GL_FONT_HEIGHT_NV                 = 0x00800000;
        public const uint GL_FONT_MAX_ADVANCE_WIDTH_NV      = 0x01000000;
        public const uint GL_FONT_MAX_ADVANCE_HEIGHT_NV     = 0x02000000;
        public const uint GL_FONT_UNDERLINE_POSITION_NV     = 0x04000000;
        public const uint GL_FONT_UNDERLINE_THICKNESS_NV    = 0x08000000;
        public const uint GL_FONT_HAS_KERNING_NV            = 0x10000000;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_bindless_texture (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_atomic_float (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_gpu_program5_mem_extended (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_atomic_counters (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_shader_storage_buffer_object (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_bindless_multi_draw_indirect (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_blend_equation_advanced
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_BLEND_OVERLAP_NV               = 0x9281;
        public const uint GL_BLEND_PREMULTIPLIED_SRC_NV     = 0x9280;
        public const uint GL_BLUE_NV                        = 0x1905;
        public const uint GL_COLORBURN_NV                   = 0x929A;
        public const uint GL_COLORDODGE_NV                  = 0x9299;
        public const uint GL_CONJOINT_NV                    = 0x9284;
        public const uint GL_CONTRAST_NV                    = 0x92A1;
        public const uint GL_DARKEN_NV                      = 0x9297;
        public const uint GL_DIFFERENCE_NV                  = 0x929E;
        public const uint GL_DISJOINT_NV                    = 0x9283;
        public const uint GL_DST_ATOP_NV                    = 0x928F;
        public const uint GL_DST_IN_NV                      = 0x928B;
        public const uint GL_DST_NV                         = 0x9287;
        public const uint GL_DST_OUT_NV                     = 0x928D;
        public const uint GL_DST_OVER_NV                    = 0x9289;
        public const uint GL_EXCLUSION_NV                   = 0x92A0;
        public const uint GL_GREEN_NV                       = 0x1904;
        public const uint GL_HARDLIGHT_NV                   = 0x929B;
        public const uint GL_HARDMIX_NV                     = 0x92A9;
        public const uint GL_HSL_COLOR_NV                   = 0x92AF;
        public const uint GL_HSL_HUE_NV                     = 0x92AD;
        public const uint GL_HSL_LUMINOSITY_NV              = 0x92B0;
        public const uint GL_HSL_SATURATION_NV              = 0x92AE;
        public const uint GL_INVERT_OVG_NV                  = 0x92B4;
        public const uint GL_INVERT_RGB_NV                  = 0x92A3;
        public const uint GL_LIGHTEN_NV                     = 0x9298;
        public const uint GL_LINEARBURN_NV                  = 0x92A5;
        public const uint GL_LINEARDODGE_NV                 = 0x92A4;
        public const uint GL_LINEARLIGHT_NV                 = 0x92A7;
        public const uint GL_MINUS_CLAMPED_NV               = 0x92B3;
        public const uint GL_MINUS_NV                       = 0x929F;
        public const uint GL_MULTIPLY_NV                    = 0x9294;
        public const uint GL_OVERLAY_NV                     = 0x9296;
        public const uint GL_PINLIGHT_NV                    = 0x92A8;
        public const uint GL_PLUS_CLAMPED_ALPHA_NV          = 0x92B2;
        public const uint GL_PLUS_CLAMPED_NV                = 0x92B1;
        public const uint GL_PLUS_DARKER_NV                 = 0x9292;
        public const uint GL_PLUS_NV                        = 0x9291;
        public const uint GL_RED_NV                         = 0x1903;
        public const uint GL_SCREEN_NV                      = 0x9295;
        public const uint GL_SOFTLIGHT_NV                   = 0x929C;
        public const uint GL_SRC_ATOP_NV                    = 0x928E;
        public const uint GL_SRC_IN_NV                      = 0x928A;
        public const uint GL_SRC_NV                         = 0x9286;
        public const uint GL_SRC_OUT_NV                     = 0x928C;
        public const uint GL_SRC_OVER_NV                    = 0x9288;
        public const uint GL_UNCORRELATED_NV                = 0x9282;
        public const uint GL_VIVIDLIGHT_NV                  = 0x92A6;
        public const uint GL_XOR_NV                         = 0x1506;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_blend_equation_advanced_coherent
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_BLEND_ADVANCED_COHERENT_NV     = 0x9285;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_compute_program5
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COMPUTE_PROGRAM_NV                     = 0x90FB;
        public const uint GL_COMPUTE_PROGRAM_PARAMETER_BUFFER_NV    = 0x90FC;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_deep_texture3D
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MAX_DEEP_3D_TEXTURE_WIDTH_HEIGHT_NV    = 0x90D0;
        public const uint GL_MAX_DEEP_3D_TEXTURE_DEPTH_NV           = 0x90D1;

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_draw_texture (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_NV_gpu_program_fp64 (no constants)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_NVX_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_NVX_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_NVX_gpu_memory_info
        ///////////////////////////////////////////////////////////////////////
        public const uint GPU_MEMORY_INFO_DEDICATED_VIDMEM_NVX = 0x9047;
        public const uint GPU_MEMORY_INFO_TOTAL_AVAILABLE_MEMORY_NVX = 0x9048;
        public const uint GPU_MEMORY_INFO_CURRENT_AVAILABLE_VIDMEM_NVX = 0x9049;
        public const uint GPU_MEMORY_INFO_EVICTION_COUNT_NVX = 0x904A;
        public const uint GPU_MEMORY_INFO_EVICTED_MEMORY_NVX = 0x904B;

        ///////////////////////////////////////////////////////////////////////
        // GL_NVX_conditional_render (no constants)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_OES_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_OES_compressed_paletted_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PALETTE4_RGB8_OES                      = 0x8B90;
        public const uint GL_PALETTE4_RGBA8_OES                     = 0x8B91;
        public const uint GL_PALETTE4_R5_G6_B5_OES                  = 0x8B92;
        public const uint GL_PALETTE4_RGBA4_OES                     = 0x8B93;
        public const uint GL_PALETTE4_RGB5_A1_OES                   = 0x8B94;
        public const uint GL_PALETTE8_RGB8_OES                      = 0x8B95;
        public const uint GL_PALETTE8_RGBA8_OES                     = 0x8B96;
        public const uint GL_PALETTE8_R5_G6_B5_OES                  = 0x8B97;
        public const uint GL_PALETTE8_RGBA4_OES                     = 0x8B98;
        public const uint GL_PALETTE8_RGB5_A1_OES                   = 0x8B99;

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_read_format
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_IMPLEMENTATION_COLOR_READ_TYPE_OES     = 0x8B9A;
        public const uint GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES   = 0x8B9B;

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_query_matrix (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_single_precision (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_byte_coordinates (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_OES_fixed_point
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FIXED_OES                              = 0x140C;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_OML_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_OML_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_OML_interlace
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_INTERLACE_OML = 0x8980;
        public const uint GL_INTERLACE_READ_OML = 0x8981;

        ///////////////////////////////////////////////////////////////////////
        // GL_OML_subsample
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FORMAT_SUBSAMPLE_24_24_OML = 0x8982;
        public const uint GL_FORMAT_SUBSAMPLE_244_244_OML = 0x8983;

        ///////////////////////////////////////////////////////////////////////
        // GL_OML_resample
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PACK_RESAMPLE_OML = 0x8984;
        public const uint GL_UNPACK_RESAMPLE_OML = 0x8985;
        public const uint GL_RESAMPLE_REPLICATE_OML = 0x8986;
        public const uint GL_RESAMPLE_ZERO_FILL_OML = 0x8987;
        public const uint GL_RESAMPLE_AVERAGE_OML = 0x8988;
        public const uint GL_RESAMPLE_DECIMATE_OML = 0x8989;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_PGI_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_PGI_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_PGI_vertex_hints
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_DATA_HINT_PGI           = 0x1A22A;
        public const uint GL_VERTEX_CONSISTENT_HINT_PGI     = 0x1A22B;
        public const uint GL_MATERIAL_SIDE_HINT_PGI         = 0x1A22C;
        public const uint GL_MAX_VERTEX_HINT_PGI            = 0x1A22D;
        public const uint GL_COLOR3_BIT_PGI                 = 0x00010000;
        public const uint GL_COLOR4_BIT_PGI                 = 0x00020000;
        public const uint GL_EDGEFLAG_BIT_PGI               = 0x00040000;
        public const uint GL_INDEX_BIT_PGI                  = 0x00080000;
        public const uint GL_MAT_AMBIENT_BIT_PGI            = 0x00100000;
        public const uint GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI = 0x00200000;
        public const uint GL_MAT_DIFFUSE_BIT_PGI            = 0x00400000;
        public const uint GL_MAT_EMISSION_BIT_PGI           = 0x00800000;
        public const uint GL_MAT_COLOR_INDEXES_BIT_PGI      = 0x01000000;
        public const uint GL_MAT_SHININESS_BIT_PGI          = 0x02000000;
        public const uint GL_MAT_SPECULAR_BIT_PGI           = 0x04000000;
        public const uint GL_NORMAL_BIT_PGI                 = 0x08000000;
        public const uint GL_TEXCOORD1_BIT_PGI              = 0x10000000;
        public const uint GL_TEXCOORD2_BIT_PGI              = 0x20000000;
        public const uint GL_TEXCOORD3_BIT_PGI              = 0x40000000;
        public const uint GL_TEXCOORD4_BIT_PGI              = 0x80000000;
        public const uint GL_VERTEX23_BIT_PGI               = 0x00000004;
        public const uint GL_VERTEX4_BIT_PGI                = 0x00000008;

        ///////////////////////////////////////////////////////////////////////
        // GL_PGI_misc_hints
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PREFER_DOUBLEBUFFER_HINT_PGI   = 0x1A1F8;
        public const uint GL_CONSERVE_MEMORY_HINT_PGI       = 0x1A1FD;
        public const uint GL_RECLAIM_MEMORY_HINT_PGI        = 0x1A1FE;
        public const uint GL_NATIVE_GRAPHICS_HANDLE_PGI     = 0x1A202;
        public const uint GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203;
        public const uint GL_NATIVE_GRAPHICS_END_HINT_PGI   = 0x1A204;
        public const uint GL_ALWAYS_FAST_HINT_PGI           = 0x1A20C;
        public const uint GL_ALWAYS_SOFT_HINT_PGI           = 0x1A20D;
        public const uint GL_ALLOW_DRAW_OBJ_HINT_PGI        = 0x1A20E;
        public const uint GL_ALLOW_DRAW_WIN_HINT_PGI        = 0x1A20F;
        public const uint GL_ALLOW_DRAW_FRG_HINT_PGI        = 0x1A210;
        public const uint GL_ALLOW_DRAW_MEM_HINT_PGI        = 0x1A211;
        public const uint GL_STRICT_DEPTHFUNC_HINT_PGI      = 0x1A216;
        public const uint GL_STRICT_LIGHTING_HINT_PGI       = 0x1A217;
        public const uint GL_STRICT_SCISSOR_HINT_PGI        = 0x1A218;
        public const uint GL_FULL_STIPPLE_HINT_PGI          = 0x1A219;
        public const uint GL_CLIP_NEAR_HINT_PGI             = 0x1A220;
        public const uint GL_CLIP_FAR_HINT_PGI              = 0x1A221;
        public const uint GL_WIDE_LINE_HINT_PGI             = 0x1A222;
        public const uint GL_BACK_NORMALS_HINT_PGI          = 0x1A223;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_REND_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_REND_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_REND_screen_coordinates
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SCREEN_COORDINATES_REND        = 0x8490;
        public const uint GL_INVERTED_SCREEN_W_REND         = 0x8491;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_S3_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_S3_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_S3_s3tc
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_RGB_S3TC                       = 0x83A0;
        public const uint GL_RGB4_S3TC                      = 0x83A1;
        public const uint GL_RGBA_S3TC                      = 0x83A2;
        public const uint GL_RGBA4_S3TC                     = 0x83A3;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SGI_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_color_matrix
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COLOR_MATRIX_SGI               = 0x80B1;
        public const uint GL_COLOR_MATRIX_STACK_DEPTH_SGI   = 0x80B2;
        public const uint GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3;
        public const uint GL_POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4;
        public const uint GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5;
        public const uint GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6;
        public const uint GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7;
        public const uint GL_POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8;
        public const uint GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9;
        public const uint GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA;
        public const uint GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_color_table
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_COLOR_TABLE_SGI                            = 0x80D0;
        public const uint GL_POST_CONVOLUTION_COLOR_TABLE_SGI           = 0x80D1;
        public const uint GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI          = 0x80D2;
        public const uint GL_PROXY_COLOR_TABLE_SGI                      = 0x80D3;
        public const uint GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI     = 0x80D4;
        public const uint GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI    = 0x80D5;
        public const uint GL_COLOR_TABLE_SCALE_SGI                      = 0x80D6;
        public const uint GL_COLOR_TABLE_BIAS_SGI                       = 0x80D7;
        public const uint GL_COLOR_TABLE_FORMAT_SGI                     = 0x80D8;
        public const uint GL_COLOR_TABLE_WIDTH_SGI                      = 0x80D9;
        public const uint GL_COLOR_TABLE_RED_SIZE_SGI                   = 0x80DA;
        public const uint GL_COLOR_TABLE_GREEN_SIZE_SGI                 = 0x80DB;
        public const uint GL_COLOR_TABLE_BLUE_SIZE_SGI                  = 0x80DC;
        public const uint GL_COLOR_TABLE_ALPHA_SIZE_SGI                 = 0x80DD;
        public const uint GL_COLOR_TABLE_LUMINANCE_SIZE_SGI             = 0x80DE;
        public const uint GL_COLOR_TABLE_INTENSITY_SIZE_SGI             = 0x80DF;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_texture_color_table
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_COLOR_TABLE_SGI                    = 0x80BC;
        public const uint GL_PROXY_TEXTURE_COLOR_TABLE_SGI              = 0x80BD;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGI_depth_pass_instrument
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DEPTH_PASS_INSTRUMENT_SGI                  = 0x8310;
        public const uint GL_DEPTH_PASS_INSTRUMENT_COUNTERS_SGI         = 0x8311;
        public const uint GL_DEPTH_PASS_INSTRUMENT_MAX_SGI              = 0x8312;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SGIS_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_filter4
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FILTER4_SGIS                   = 0x8146;
        public const uint GL_TEXTURE_FILTER4_SIZE_SGIS      = 0x8147;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_pixel_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PIXEL_TEXTURE_SGIS             = 0x8353;
        public const uint GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354;
        public const uint GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355;
        public const uint GL_PIXEL_GROUP_COLOR_SGIS         = 0x8356;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture4D
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PACK_SKIP_VOLUMES_SGIS         = 0x8130;
        public const uint GL_PACK_IMAGE_DEPTH_SGIS          = 0x8131;
        public const uint GL_UNPACK_SKIP_VOLUMES_SGIS       = 0x8132;
        public const uint GL_UNPACK_IMAGE_DEPTH_SGIS        = 0x8133;
        public const uint GL_TEXTURE_4D_SGIS                = 0x8134;
        public const uint GL_PROXY_TEXTURE_4D_SGIS          = 0x8135;
        public const uint GL_TEXTURE_4DSIZE_SGIS            = 0x8136;
        public const uint GL_TEXTURE_WRAP_Q_SGIS            = 0x8137;
        public const uint GL_MAX_4D_TEXTURE_SIZE_SGIS       = 0x8138;
        public const uint GL_TEXTURE_4D_BINDING_SGIS        = 0x814F;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_detail_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DETAIL_TEXTURE_2D_SGIS         = 0x8095;
        public const uint GL_DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096;
        public const uint GL_LINEAR_DETAIL_SGIS             = 0x8097;
        public const uint GL_LINEAR_DETAIL_ALPHA_SGIS       = 0x8098;
        public const uint GL_LINEAR_DETAIL_COLOR_SGIS       = 0x8099;
        public const uint GL_DETAIL_TEXTURE_LEVEL_SGIS      = 0x809A;
        public const uint GL_DETAIL_TEXTURE_MODE_SGIS       = 0x809B;
        public const uint GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_sharpen_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_LINEAR_SHARPEN_SGIS            = 0x80AD;
        public const uint GL_LINEAR_SHARPEN_ALPHA_SGIS      = 0x80AE;
        public const uint GL_LINEAR_SHARPEN_COLOR_SGIS      = 0x80AF;
        public const uint GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_lod
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_MIN_LOD_SGIS           = 0x813A;
        public const uint GL_TEXTURE_MAX_LOD_SGIS           = 0x813B;
        public const uint GL_TEXTURE_BASE_LEVEL_SGIS        = 0x813C;
        public const uint GL_TEXTURE_MAX_LEVEL_SGIS         = 0x813D;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_multisample
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_MULTISAMPLE_SGIS               = 0x809D;
        public const uint GL_SAMPLE_ALPHA_TO_MASK_SGIS      = 0x809E;
        public const uint GL_SAMPLE_ALPHA_TO_ONE_SGIS       = 0x809F;
        public const uint GL_SAMPLE_MASK_SGIS               = 0x80A0;
        public const uint GL_1PASS_SGIS                     = 0x80A1;
        public const uint GL_2PASS_0_SGIS                   = 0x80A2;
        public const uint GL_2PASS_1_SGIS                   = 0x80A3;
        public const uint GL_4PASS_0_SGIS                   = 0x80A4;
        public const uint GL_4PASS_1_SGIS                   = 0x80A5;
        public const uint GL_4PASS_2_SGIS                   = 0x80A6;
        public const uint GL_4PASS_3_SGIS                   = 0x80A7;
        public const uint GL_SAMPLE_BUFFERS_SGIS            = 0x80A8;
        public const uint GL_SAMPLES_SGIS                   = 0x80A9;
        public const uint GL_SAMPLE_MASK_VALUE_SGIS         = 0x80AA;
        public const uint GL_SAMPLE_MASK_INVERT_SGIS        = 0x80AB;
        public const uint GL_SAMPLE_PATTERN_SGIS            = 0x80AC;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_generate_mipmap
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_GENERATE_MIPMAP_SGIS           = 0x8191;
        public const uint GL_GENERATE_MIPMAP_HINT_SGIS      = 0x8192;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_edge_clamp
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CLAMP_TO_EDGE_SGIS             = 0x812F;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_border_clamp
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CLAMP_TO_BORDER_SGIS           = 0x812D;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_select
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DUAL_ALPHA4_SGIS               = 0x8110;
        public const uint GL_DUAL_ALPHA8_SGIS               = 0x8111;
        public const uint GL_DUAL_ALPHA12_SGIS              = 0x8112;
        public const uint GL_DUAL_ALPHA16_SGIS              = 0x8113;
        public const uint GL_DUAL_LUMINANCE4_SGIS           = 0x8114;
        public const uint GL_DUAL_LUMINANCE8_SGIS           = 0x8115;
        public const uint GL_DUAL_LUMINANCE12_SGIS          = 0x8116;
        public const uint GL_DUAL_LUMINANCE16_SGIS          = 0x8117;
        public const uint GL_DUAL_INTENSITY4_SGIS           = 0x8118;
        public const uint GL_DUAL_INTENSITY8_SGIS           = 0x8119;
        public const uint GL_DUAL_INTENSITY12_SGIS          = 0x811A;
        public const uint GL_DUAL_INTENSITY16_SGIS          = 0x811B;
        public const uint GL_DUAL_LUMINANCE_ALPHA4_SGIS     = 0x811C;
        public const uint GL_DUAL_LUMINANCE_ALPHA8_SGIS     = 0x811D;
        public const uint GL_QUAD_ALPHA4_SGIS               = 0x811E;
        public const uint GL_QUAD_ALPHA8_SGIS               = 0x811F;
        public const uint GL_QUAD_LUMINANCE4_SGIS           = 0x8120;
        public const uint GL_QUAD_LUMINANCE8_SGIS           = 0x8121;
        public const uint GL_QUAD_INTENSITY4_SGIS           = 0x8122;
        public const uint GL_QUAD_INTENSITY8_SGIS           = 0x8123;
        public const uint GL_DUAL_TEXTURE_SELECT_SGIS       = 0x8124;
        public const uint GL_QUAD_TEXTURE_SELECT_SGIS       = 0x8125;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_point_parameters
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_POINT_SIZE_MIN_SGIS            = 0x8126;
        public const uint GL_POINT_SIZE_MAX_SGIS            = 0x8127;
        public const uint GL_POINT_FADE_THRESHOLD_SIZE_SGIS = 0x8128;
        public const uint GL_DISTANCE_ATTENUATION_SGIS      = 0x8129;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_fog_function
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FOG_FUNC_SGIS                  = 0x812A;
        public const uint GL_FOG_FUNC_POINTS_SGIS           = 0x812B;
        public const uint GL_MAX_FOG_FUNC_POINTS_SGIS       = 0x812C;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_point_line_texgen
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_EYE_DISTANCE_TO_POINT_SGIS     = 0x81F0;
        public const uint GL_OBJECT_DISTANCE_TO_POINT_SGIS  = 0x81F1;
        public const uint GL_EYE_DISTANCE_TO_LINE_SGIS      = 0x81F2;
        public const uint GL_OBJECT_DISTANCE_TO_LINE_SGIS   = 0x81F3;
        public const uint GL_EYE_POINT_SGIS                 = 0x81F4;
        public const uint GL_OBJECT_POINT_SGIS              = 0x81F5;
        public const uint GL_EYE_LINE_SGIS                  = 0x81F6;
        public const uint GL_OBJECT_LINE_SGIS               = 0x81F7;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIS_texture_color_mask
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_COLOR_WRITEMASK_SGIS   = 0x81EF;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SGIX_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_pixel_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PIXEL_TEX_GEN_SGIX             = 0x8139;
        public const uint GL_PIXEL_TEX_GEN_MODE_SGIX        = 0x832B;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_clipmap
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_LINEAR_CLIPMAP_LINEAR_SGIX     = 0x8170;
        public const uint GL_TEXTURE_CLIPMAP_CENTER_SGIX    = 0x8171;
        public const uint GL_TEXTURE_CLIPMAP_FRAME_SGIX     = 0x8172;
        public const uint GL_TEXTURE_CLIPMAP_OFFSET_SGIX    = 0x8173;
        public const uint GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174;
        public const uint GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175;
        public const uint GL_TEXTURE_CLIPMAP_DEPTH_SGIX     = 0x8176;
        public const uint GL_MAX_CLIPMAP_DEPTH_SGIX         = 0x8177;
        public const uint GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178;
        public const uint GL_NEAREST_CLIPMAP_NEAREST_SGIX   = 0x844D;
        public const uint GL_NEAREST_CLIPMAP_LINEAR_SGIX    = 0x844E;
        public const uint GL_LINEAR_CLIPMAP_NEAREST_SGIX    = 0x844F;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_shadow
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_COMPARE_SGIX           = 0x819A;
        public const uint GL_TEXTURE_COMPARE_OPERATOR_SGIX  = 0x819B;
        public const uint GL_TEXTURE_LEQUAL_R_SGIX          = 0x819C;
        public const uint GL_TEXTURE_GEQUAL_R_SGIX          = 0x819D;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_interlace
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_INTERLACE_SGIX                 = 0x8094;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_pixel_tiles
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E;
        public const uint GL_PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F;
        public const uint GL_PIXEL_TILE_WIDTH_SGIX          = 0x8140;
        public const uint GL_PIXEL_TILE_HEIGHT_SGIX         = 0x8141;
        public const uint GL_PIXEL_TILE_GRID_WIDTH_SGIX     = 0x8142;
        public const uint GL_PIXEL_TILE_GRID_HEIGHT_SGIX    = 0x8143;
        public const uint GL_PIXEL_TILE_GRID_DEPTH_SGIX     = 0x8144;
        public const uint GL_PIXEL_TILE_CACHE_SIZE_SGIX     = 0x8145;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_select (no constants??? Reuse from GL_SGIS_texture_select)
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DUAL_ALPHA4_SGIX               = 0x8110;
        public const uint GL_DUAL_ALPHA8_SGIX               = 0x8111;
        public const uint GL_DUAL_ALPHA12_SGIX              = 0x8112;
        public const uint GL_DUAL_ALPHA16_SGIX              = 0x8113;
        public const uint GL_DUAL_LUMINANCE4_SGIX           = 0x8114;
        public const uint GL_DUAL_LUMINANCE8_SGIX           = 0x8115;
        public const uint GL_DUAL_LUMINANCE12_SGIX          = 0x8116;
        public const uint GL_DUAL_LUMINANCE16_SGIX          = 0x8117;
        public const uint GL_DUAL_INTENSITY4_SGIX           = 0x8118;
        public const uint GL_DUAL_INTENSITY8_SGIX           = 0x8119;
        public const uint GL_DUAL_INTENSITY12_SGIX          = 0x811A;
        public const uint GL_DUAL_INTENSITY16_SGIX          = 0x811B;
        public const uint GL_DUAL_LUMINANCE_ALPHA4_SGIX     = 0x811C;
        public const uint GL_DUAL_LUMINANCE_ALPHA8_SGIX     = 0x811D;
        public const uint GL_QUAD_ALPHA4_SGIX               = 0x811E;
        public const uint GL_QUAD_ALPHA8_SGIX               = 0x811F;
        public const uint GL_QUAD_LUMINANCE4_SGIX           = 0x8120;
        public const uint GL_QUAD_LUMINANCE8_SGIX           = 0x8121;
        public const uint GL_QUAD_INTENSITY4_SGIX           = 0x8122;
        public const uint GL_QUAD_INTENSITY8_SGIX           = 0x8123;
        public const uint GL_DUAL_TEXTURE_SELECT_SGIX       = 0x8124;
        public const uint GL_QUAD_TEXTURE_SELECT_SGIX       = 0x8125;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_sprite
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SPRITE_SGIX                    = 0x8148;
        public const uint GL_SPRITE_MODE_SGIX               = 0x8149;
        public const uint GL_SPRITE_AXIS_SGIX               = 0x814A;
        public const uint GL_SPRITE_TRANSLATION_SGIX        = 0x814B;
        public const uint GL_SPRITE_AXIAL_SGIX              = 0x814C;
        public const uint GL_SPRITE_OBJECT_ALIGNED_SGIX     = 0x814D;
        public const uint GL_SPRITE_EYE_ALIGNED_SGIX        = 0x814E;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_multi_buffer
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_instruments
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_INSTRUMENT_BUFFER_POINTER_SGIX = 0x8180;
        public const uint GL_INSTRUMENT_MEASUREMENTS_SGIX   = 0x8181;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_scale_bias
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_POST_TEXTURE_FILTER_BIAS_SGIX  = 0x8179;
        public const uint GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A;
        public const uint GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B;
        public const uint GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_framezoom
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FRAMEZOOM_SGIX                 = 0x818B;
        public const uint GL_FRAMEZOOM_FACTOR_SGIX          = 0x818C;
        public const uint GL_MAX_FRAMEZOOM_FACTOR_SGIX      = 0x818D;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_tag_sample_buffer (no constants)
        ///////////////////////////////////////////////////////////////////////
 
        ///////////////////////////////////////////////////////////////////////
        // GL_FfdMaskSGIX
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_DEFORMATION_BIT_SGIX   = 0x00000001;
        public const uint GL_GEOMETRY_DEFORMATION_BIT_SGIX  = 0x00000002;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_polynomial_ffd
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_GEOMETRY_DEFORMATION_SGIX      = 0x8194;
        public const uint GL_TEXTURE_DEFORMATION_SGIX       = 0x8195;
        public const uint GL_DEFORMATIONS_MASK_SGIX         = 0x8196;
        public const uint GL_MAX_DEFORMATION_ORDER_SGIX     = 0x8197;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_reference_plane
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_REFERENCE_PLANE_SGIX           = 0x817D;
        public const uint GL_REFERENCE_PLANE_EQUATION_SGIX  = 0x817E;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_flush_raster (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_depth_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DEPTH_COMPONENT16_SGIX         = 0x81A5;
        public const uint GL_DEPTH_COMPONENT24_SGIX         = 0x81A6;
        public const uint GL_DEPTH_COMPONENT32_SGIX         = 0x81A7;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_fog_offset
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FOG_OFFSET_SGIX                = 0x8198;
        public const uint GL_FOG_OFFSET_VALUE_SGIX          = 0x8199;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_add_env
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_ENV_BIAS_SGIX          = 0x80BE;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_list_priority
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_LIST_PRIORITY_SGIX             = 0x8182;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_ir_instrument1
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_IR_INSTRUMENT1_SGIX            = 0x817F;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_calligraphic_fragment
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CALLIGRAPHIC_FRAGMENT_SGIX     = 0x8183;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_lod_bias
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_LOD_BIAS_S_SGIX        = 0x818E;
        public const uint GL_TEXTURE_LOD_BIAS_T_SGIX        = 0x818F;
        public const uint GL_TEXTURE_LOD_BIAS_R_SGIX        = 0x8190;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_shadow_ambient
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SHADOW_AMBIENT_SGIX            = 0x80BF;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_ycrcb
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_YCRCB_422_SGIX                 = 0x81BB;
        public const uint GL_YCRCB_444_SGIX                 = 0x81BC;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_fragment_lighting
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FRAGMENT_LIGHTING_SGIX         = 0x8400;
        public const uint GL_FRAGMENT_COLOR_MATERIAL_SGIX   = 0x8401;
        public const uint GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX = 0x8402;
        public const uint GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX = 0x8403;
        public const uint GL_MAX_FRAGMENT_LIGHTS_SGIX       = 0x8404;
        public const uint GL_MAX_ACTIVE_LIGHTS_SGIX         = 0x8405;
        public const uint GL_CURRENT_RASTER_NORMAL_SGIX     = 0x8406;
        public const uint GL_LIGHT_ENV_MODE_SGIX            = 0x8407;
        public const uint GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX = 0x8408;
        public const uint GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX = 0x8409;
        public const uint GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX = 0x840A;
        public const uint GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX = 0x840B;
        public const uint GL_FRAGMENT_LIGHT0_SGIX           = 0x840C;
        public const uint GL_FRAGMENT_LIGHT1_SGIX           = 0x840D;
        public const uint GL_FRAGMENT_LIGHT2_SGIX           = 0x840E;
        public const uint GL_FRAGMENT_LIGHT3_SGIX           = 0x840F;
        public const uint GL_FRAGMENT_LIGHT4_SGIX           = 0x8410;
        public const uint GL_FRAGMENT_LIGHT5_SGIX           = 0x8411;
        public const uint GL_FRAGMENT_LIGHT6_SGIX           = 0x8412;
        public const uint GL_FRAGMENT_LIGHT7_SGIX           = 0x8413;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_blend_alpha_minmax
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_ALPHA_MIN_SGIX                 = 0x8320;
        public const uint GL_ALPHA_MAX_SGIX                 = 0x8321;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_impact_pixel_texture
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PIXEL_TEX_GEN_Q_CEILING_SGIX   = 0x8184;
        public const uint GL_PIXEL_TEX_GEN_Q_ROUND_SGIX     = 0x8185;
        public const uint GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX     = 0x8186;
        public const uint GL_PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX = 0x8187;
        public const uint GL_PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX = 0x8188;
        public const uint GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX    = 0x8189;
        public const uint GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX    = 0x818A;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_async
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_ASYNC_MARKER_SGIX              = 0x8329;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_async_pixel
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_ASYNC_TEX_IMAGE_SGIX           = 0x835C;
        public const uint GL_ASYNC_DRAW_PIXELS_SGIX         = 0x835D;
        public const uint GL_ASYNC_READ_PIXELS_SGIX         = 0x835E;
        public const uint GL_MAX_ASYNC_TEX_IMAGE_SGIX       = 0x835F;
        public const uint GL_MAX_ASYNC_DRAW_PIXELS_SGIX     = 0x8360;
        public const uint GL_MAX_ASYNC_READ_PIXELS_SGIX     = 0x8361;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_async_histogram
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_ASYNC_HISTOGRAM_SGIX           = 0x832C;
        public const uint GL_MAX_ASYNC_HISTOGRAM_SGIX       = 0x832D;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_fog_scale
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FOG_SCALE_SGIX                 = 0x81FC;
        public const uint GL_FOG_SCALE_VALUE_SGIX           = 0x81FD;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_subsample
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PACK_SUBSAMPLE_RATE_SGIX       = 0x85A0;
        public const uint GL_UNPACK_SUBSAMPLE_RATE_SGIX     = 0x85A1;
        public const uint GL_PIXEL_SUBSAMPLE_4444_SGIX      = 0x85A2;
        public const uint GL_PIXEL_SUBSAMPLE_2424_SGIX      = 0x85A3;
        public const uint GL_PIXEL_SUBSAMPLE_4242_SGIX      = 0x85A4;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_ycrcb_subsample (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_ycrcba
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_YCRCB_SGIX                     = 0x8318;
        public const uint GL_YCRCBA_SGIX                    = 0x8319;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_depth_pass_instrument (no constants??? Reuse from GL_SGI_depth_pass_instrument)
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_DEPTH_PASS_INSTRUMENT_SGIX             = 0x8310;
        public const uint GL_DEPTH_PASS_INSTRUMENT_COUNTERS_SGIX    = 0x8311;
        public const uint GL_DEPTH_PASS_INSTRUMENT_MAX_SGIX         = 0x8312;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_vertex_preclip
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_VERTEX_PRECLIP_SGIX            = 0x83EE;
        public const uint GL_VERTEX_PRECLIP_HINT_SGIX       = 0x83EF;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_convolution_accuracy
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_CONVOLUTION_HINT_SGIX          = 0x8316;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_resample
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PACK_RESAMPLE_SGIX             = 0x842C;
        public const uint GL_UNPACK_RESAMPLE_SGIX           = 0x842D;
        public const uint GL_RESAMPLE_REPLICATE_SGIX        = 0x842E;
        public const uint GL_RESAMPLE_ZERO_FILL_SGIX        = 0x842F;
        public const uint GL_RESAMPLE_DECIMATE_SGIX         = 0x8430;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_texture_coordinate_clamp
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_TEXTURE_MAX_CLAMP_S_SGIX       = 0x8369;
        public const uint GL_TEXTURE_MAX_CLAMP_T_SGIX       = 0x836A;
        public const uint GL_TEXTURE_MAX_CLAMP_R_SGIX       = 0x836B;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_scalebias_hint
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SCALEBIAS_HINT_SGIX            = 0x8322;

        ///////////////////////////////////////////////////////////////////////
        // GL_SGIX_igloo_interface (no constants)
        ///////////////////////////////////////////////////////////////////////

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SUN_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_multi_draw_arrays (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_global_alpha
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_GLOBAL_ALPHA_SUN               = 0x81D9;
        public const uint GL_GLOBAL_ALPHA_FACTOR_SUN        = 0x81DA;

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_triangle_list
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_RESTART_SUN                    = 0x0001;
        public const uint GL_REPLACE_MIDDLE_SUN             = 0x0002;
        public const uint GL_REPLACE_OLDEST_SUN             = 0x0003;
        public const uint GL_TRIANGLE_LIST_SUN              = 0x81D7;
        public const uint GL_REPLACEMENT_CODE_SUN           = 0x81D8;
        public const uint GL_REPLACEMENT_CODE_ARRAY_SUN     = 0x85C0;
        public const uint GL_REPLACEMENT_CODE_ARRAY_TYPE_SUN = 0x85C1;
        public const uint GL_REPLACEMENT_CODE_ARRAY_STRIDE_SUN = 0x85C2;
        public const uint GL_REPLACEMENT_CODE_ARRAY_POINTER_SUN = 0x85C3;
        public const uint GL_R1UI_V3F_SUN                   = 0x85C4;
        public const uint GL_R1UI_C4UB_V3F_SUN              = 0x85C5;
        public const uint GL_R1UI_C3F_V3F_SUN               = 0x85C6;
        public const uint GL_R1UI_N3F_V3F_SUN               = 0x85C7;
        public const uint GL_R1UI_C4F_N3F_V3F_SUN           = 0x85C8;
        public const uint GL_R1UI_T2F_V3F_SUN               = 0x85C9;
        public const uint GL_R1UI_T2F_N3F_V3F_SUN           = 0x85CA;
        public const uint GL_R1UI_T2F_C4F_N3F_V3F_SUN       = 0x85CB;

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_vertex (no constants)
        ///////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_convolution_border_modes
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_WRAP_BORDER_SUN                = 0x81D4;

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_mesh_array
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_QUAD_MESH_SUN                  = 0x8614;
        public const uint GL_TRIANGLE_MESH_SUN              = 0x8615;

        ///////////////////////////////////////////////////////////////////////
        // GL_SUN_slice_accum
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_SLICE_ACCUM_SUN                = 0x85CC;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_SUNX_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_SUNX_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_SUNX_constant_data
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_UNPACK_CONSTANT_DATA_SUNX      = 0x81D5;
        public const uint GL_TEXTURE_CONSTANT_DATA_SUNX     = 0x81D6;

        #endregion

        ///////////////////////////////////////////////////////////////////////
        // GL_WIN_xxx CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region GL_WIN_xxx CONSTANTS...
        ///////////////////////////////////////////////////////////////////////
        // GL_WIN_phong_shading
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_PHONG_WIN                      = 0x80EA;
        public const uint GL_PHONG_HINT_WIN                 = 0x80EB;

        ///////////////////////////////////////////////////////////////////////
        // GL_WIN_specular_fog
        ///////////////////////////////////////////////////////////////////////
        public const uint GL_FOG_SPECULAR_TEXTURE_WIN       = 0x80EC;

        ///////////////////////////////////////////////////////////////////////
        // GL_WIN_swap_hint (no constants)
        ///////////////////////////////////////////////////////////////////////

        #endregion
    }
}
