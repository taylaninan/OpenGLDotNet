// ----------------------------------------------------------------------------
// FILE		: gl.base.cs
// VERSION	: 1.1.1
// COMMENT	: OpenGL initting, configuration and extension loading and management
//            base functions
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2017
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USE
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;

namespace OpenGLDotNet
{
    public static class GLConfig
    {
        ///////////////////////////////////////////////////////////////////////
        // CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        private const uint GL_CONFIG_VENDOR                                 = 0x1F00;
        private const uint GL_CONFIG_RENDERER                               = 0x1F01;
        private const uint GL_CONFIG_VERSION                                = 0x1F02;
        private const uint GL_CONFIG_EXTENSIONS                             = 0x1F03;
        private const uint GL_CONFIG_SHADING_LANGUAGE_VERSION               = 0x8B8C;

        private const uint GL_CONFIG_MAJOR_VERSION                          = 0x821B;
        private const uint GL_CONFIG_MINOR_VERSION                          = 0x821C;
        private const uint GL_CONFIG_NUM_EXTENSIONS                         = 0x821D;

        private const uint WGL_CONFIG_CONTEXT_DEBUG_BIT_ARB                 = 0x00000001;
        private const uint WGL_CONFIG_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB    = 0x00000002;
        private const uint WGL_CONFIG_CONTEXT_MAJOR_VERSION_ARB             = 0x2091;
        private const uint WGL_CONFIG_CONTEXT_MINOR_VERSION_ARB             = 0x2092;
        private const uint WGL_CONFIG_CONTEXT_LAYER_PLANE_ARB               = 0x2093;
        private const uint WGL_CONFIG_CONTEXT_FLAGS_ARB                     = 0x2094;
        private const uint WGL_CONFIG_ERROR_INVALID_VERSION_ARB             = 0x2095;

        ///////////////////////////////////////////////////////////////////////
        // VARIABLES
        ///////////////////////////////////////////////////////////////////////
        private static uint glLib = 0;
        private static uint glFuncAddr = 0;

        ///////////////////////////////////////////////////////////////////////
        // DELEGATES
        ///////////////////////////////////////////////////////////////////////
        // glGetIntegerv
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate void TglGetIntegerv(uint pname, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)] int[] parameters);
        private static TglGetIntegerv glGetIntegerv = null;

        // glGetString
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate byte* TglGetString(uint name);
        private static TglGetString glGetString = null;

        // glGetStringi
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate byte* TglGetStringi(uint name, uint index);
        private static TglGetStringi glGetStringi = null;

        // wglGetProcAddress
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate IntPtr TwglGetProcAddress(string procname);
        private static TwglGetProcAddress wglGetProcAddress = null;

        // wglGetCurrentDC
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate IntPtr TwglGetCurrentDC();
        private static TwglGetCurrentDC wglGetCurrentDC = null;

        // wglMakeCurrent
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private delegate bool TwglMakeCurrent(IntPtr hdc, IntPtr hglrc);
        private static TwglMakeCurrent wglMakeCurrent = null;

        // wglGetExtensionsStringARB
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate byte* TwglGetExtensionsStringARB(IntPtr hDC);
        private static TwglGetExtensionsStringARB wglGetExtensionsStringARB = null;

        // wglCreateContextAttribsARB
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private unsafe delegate IntPtr TwglCreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)] int[] attribList);
        private static TwglCreateContextAttribsARB wglCreateContextAttribsARB = null;

        ///////////////////////////////////////////////////////////////////////
        // OPENGL LOGS
        ///////////////////////////////////////////////////////////////////////
        private static List<string> Log = new List<string>(); 

        ///////////////////////////////////////////////////////////////////////
        // OPENGL VERSIONS SUPPORTED
        ///////////////////////////////////////////////////////////////////////
        // Initially set to "0", determined at the first run
        public static byte GL_VERSION = 0;
        // Initially set to "false", determined at the first run
        public static bool GL_VERSION_1_1 = false;
        public static bool GL_VERSION_1_2 = false;
        public static bool GL_VERSION_1_3 = false;
        public static bool GL_VERSION_1_4 = false;
        public static bool GL_VERSION_1_5 = false;
        public static bool GL_VERSION_2_0 = false;
        public static bool GL_VERSION_2_1 = false;
        public static bool GL_VERSION_3_0 = false;
        public static bool GL_VERSION_3_1 = false;
        public static bool GL_VERSION_3_2 = false;
        public static bool GL_VERSION_3_3 = false;
        public static bool GL_VERSION_4_0 = false;
        public static bool GL_VERSION_4_1 = false;
        public static bool GL_VERSION_4_2 = false;
        public static bool GL_VERSION_4_3 = false;
        public static bool GL_VERSION_4_4 = false;
        public static bool GL_VERSION_4_5 = false;

        ///////////////////////////////////////////////////////////////////////
        // OPENGL EXTENSIONS SUPPORTED
        ///////////////////////////////////////////////////////////////////////
        // Unified Extensions List (GPU + OpenGL Wrapper Library)
        private static SortedDictionary<string, byte> ExtensionsALL = new SortedDictionary<string, byte>();
        private static byte SupportBitLIB = 0x01;
        private static byte SupportBitGPU = 0x02;

        // Extensions reported by graphic card (GPU)
        private static List<string> ExtensionsGPU = new List<string>();

        // Extensions supported by this C# OpenGL Wrapper project. "true" means that the extension is supported.
        private static SortedDictionary<string, bool> ExtensionsLIB = new SortedDictionary<string, bool>()
        {   
            {"GL_3DFX_multisample", true},							// Added: 2014
            {"GL_3DFX_tbuffer", true},								// Added: 2014
            {"GL_3DFX_texture_compression_FXT1", true},				// Added: 2014
            {"GL_AMD_blend_minmax_factor", true},					// Added: 2014
            {"GL_AMD_conservative_depth", true},					// Added: 2014
            {"GL_AMD_debug_output", true},							// Added: 2014
            {"GL_AMD_depth_clamp_separate", true},					// Added: 2014
            {"GL_AMD_draw_buffers_blend", true},					// Added: 2014
            {"GL_AMD_gcn_shader", true},							// Added: 2016
            {"GL_AMD_gpu_shader_int64", true},						// Added: 2016
            {"GL_AMD_interleaved_elements", true},					// Added: 2014
            {"GL_AMD_multi_draw_indirect", true},					// Added: 2014
            {"GL_AMD_name_gen_delete", true},						// Added: 2014
            {"GL_AMD_occlusion_query_event", true},					// Added: 2014
            {"GL_AMD_performance_monitor", true},					// Added: 2014
            {"GL_AMD_pinned_memory", true},							// Added: 2014
            {"GL_AMD_query_buffer_object", true},					// Added: 2014
            {"GL_AMD_sample_positions", true},						// Added: 2014
            {"GL_AMD_seamless_cubemap_per_texture", true},			// Added: 2014
            {"GL_AMD_shader_atomic_counter_ops", true},				// Added: 2014
            {"GL_AMD_shader_stencil_export", true},					// Added: 2014
            {"GL_AMD_shader_trinary_minmax", true},					// Added: 2014
            {"GL_AMD_sparse_texture", true},						// Added: 2014
            {"GL_AMD_stencil_operation_extended", true},			// Added: 2014
            {"GL_AMD_texture_cube_map_array", false},     			// Added: 2014 // ATI/AMD GPUs report to support this; no internet search results; similar to GL_ARB_texture_cube_map_array
            {"GL_AMD_texture_texture4", true},						// Added: 2014 
            {"GL_AMD_transform_feedback3_lines_triangles", true},	// Added: 2014 
            {"GL_AMD_transform_feedback4", true},					// Added: 2016 
            {"GL_AMD_vertex_shader_layer", true},					// Added: 2014 
            {"GL_AMD_vertex_shader_tessellator", true},				// Added: 2014 
            {"GL_AMD_vertex_shader_viewport_index", true},			// Added: 2014 
            {"GL_AMDX_debug_output", true},                         // Added: 2014 // ATI/AMD GPUs report to support this; only renated to GL_AMD_debug_output
            {"GL_AMDX_vertex_shader_tessellator", true},            // Added: 2014 // ATI/AMD GPUs report to support this; only renamed to GL_AMD_vertex_shader_tessellator
            {"GL_APPLE_aux_depth_stencil", true},					// Added: 2014 
            {"GL_APPLE_client_storage", true},						// Added: 2014 
            {"GL_APPLE_element_array", true},						// Added: 2014 
            {"GL_APPLE_fence", true},								// Added: 2014 
            {"GL_APPLE_float_pixels", true},						// Added: 2014 
            {"GL_APPLE_flush_buffer_range", true},					// Added: 2014 
            {"GL_APPLE_object_purgeable", true},					// Added: 2014 
            {"GL_APPLE_rgb_422", true},								// Added: 2014 
            {"GL_APPLE_row_bytes", true},							// Added: 2014 
            {"GL_APPLE_specular_vector", true},						// Added: 2014 
            {"GL_APPLE_texture_range", true},						// Added: 2014 
            {"GL_APPLE_transform_hint", true},						// Added: 2014 
            {"GL_APPLE_vertex_array_object", true},					// Added: 2014 
            {"GL_APPLE_vertex_array_range", true},					// Added: 2014 
            {"GL_APPLE_vertex_program_evaluators", true},			// Added: 2014 
            {"GL_APPLE_ycbcr_422", true},							// Added: 2014 
            {"GL_ARB_arrays_of_arrays", true},						// Added: 2014 
            {"GL_ARB_base_instance", true},							// Added: 2014 
            {"GL_ARB_bindless_texture", true},						// Added: 2014 
            {"GL_ARB_blend_func_extended", true},					// Added: 2014 
            {"GL_ARB_buffer_storage", true},						// Added: 2014 
            {"GL_ARB_cl_event", true},								// Added: 2014 
            {"GL_ARB_clear_buffer_object", true},					// Added: 2014 
            {"GL_ARB_clear_texture", true},							// Added: 2014 
            {"GL_ARB_clip_control", true},							// Added: 2014 
            {"GL_ARB_color_buffer_float", true},					// Added: 2014 
            {"GL_ARB_compatibility", true},							// Added: 2014 
            {"GL_ARB_compressed_texture_pixel_storage", true},		// Added: 2014 
            {"GL_ARB_compute_shader", true},						// Added: 2014 
            {"GL_ARB_compute_variable_group_size", true},			// Added: 2014 
            {"GL_ARB_conditional_render_inverted", true},			// Added: 2014 
            {"GL_ARB_conservative_depth", true},					// Added: 2014 
            {"GL_ARB_copy_buffer", true},							// Added: 2014 
            {"GL_ARB_copy_image", true},							// Added: 2014 
            {"GL_ARB_cull_distance", true},							// Added: 2014 
            {"GL_ARB_debug_output", true},							// Added: 2014 
            {"GL_ARB_depth_buffer_float", true},					// Added: 2014 
            {"GL_ARB_depth_clamp", true},							// Added: 2014 
            {"GL_ARB_depth_texture", true},							// Added: 2014 
            {"GL_ARB_derivative_control", true},					// Added: 2014 
            {"GL_ARB_direct_state_access", true},					// Added: 2014 
            {"GL_ARB_draw_buffers", true},							// Added: 2014 
            {"GL_ARB_draw_buffers_blend", true},					// Added: 2014 
            {"GL_ARB_draw_elements_base_vertex", true},				// Added: 2014 
            {"GL_ARB_draw_indirect", true},							// Added: 2014 
            {"GL_ARB_draw_instanced", true},						// Added: 2014 
            {"GL_ARB_enhanced_layouts", true},                     	// Added: 2014
            {"GL_ARB_ES2_compatibility", true},						// Added: 2014 
            {"GL_ARB_ES3_compatibility", true},						// Added: 2014 
            {"GL_ARB_ES3_1_compatibility", true},					// Added: 2014 
            {"GL_ARB_ES3_2_compatibility", true},					// Added: 2016
            {"GL_ARB_explicit_attrib_location", true},				// Added: 2014 
            {"GL_ARB_explicit_uniform_location", true},				// Added: 2014 
            {"GL_ARB_fragment_coord_conventions", true},			// Added: 2014 
            {"GL_ARB_fragment_layer_viewport", true},				// Added: 2014 
            {"GL_ARB_fragment_program", true},						// Added: 2014 
            {"GL_ARB_fragment_program_shadow", true},				// Added: 2014 
            {"GL_ARB_fragment_shader", true},						// Added: 2014 
            {"GL_ARB_fragment_shader_interlock", true},				// Added: 2016 
            {"GL_ARB_framebuffer_no_attachments", true},			// Added: 2014 
            {"GL_ARB_framebuffer_object", true},					// Added: 2014 
            {"GL_ARB_framebuffer_sRGB", true},						// Added: 2014 
            {"GL_ARB_geometry_shader4", true},						// Added: 2014 
            {"GL_ARB_get_program_binary", true},					// Added: 2014 
            {"GL_ARB_get_texture_sub_image", true},					// Added: 2014 
            {"GL_ARB_gpu_shader_fp64", true},						// Added: 2014 
            {"GL_ARB_gpu_shader_int64", true},						// Added: 2016
            {"GL_ARB_gpu_shader5", true},							// Added: 2014 
            {"GL_ARB_half_float_pixel", true},						// Added: 2014 
            {"GL_ARB_half_float_vertex", true},						// Added: 2014 
            {"GL_ARB_imaging", true},								// Added: 2014 
            {"GL_ARB_indirect_parameters", true},					// Added: 2014 
            {"GL_ARB_instanced_arrays", true},						// Added: 2014 
            {"GL_ARB_internalformat_query", true},					// Added: 2014 
            {"GL_ARB_internalformat_query2", true},					// Added: 2014 
            {"GL_ARB_invalidate_subdata", true},					// Added: 2014 
            {"GL_ARB_map_buffer_alignment", true},					// Added: 2014 
            {"GL_ARB_map_buffer_range", true},						// Added: 2014 
            {"GL_ARB_matrix_palette", true},						// Added: 2014 
            {"GL_ARB_multi_bind", true},							// Added: 2014 
            {"GL_ARB_multi_draw_indirect", true},					// Added: 2014 
            {"GL_ARB_multisample", true},							// Added: 2014 
            {"GL_ARB_multitexture", true},							// Added: 2014 
            {"GL_ARB_occlusion_query", true},						// Added: 2014 
            {"GL_ARB_occlusion_query2", true},						// Added: 2014 
            {"GL_ARB_parallel_shader_compile", true},				// Added: 2016 
            {"GL_ARB_pipeline_statistics_query", true},				// Added: 2014 
            {"GL_ARB_pixel_buffer_object", true},					// Added: 2014 
            {"GL_ARB_point_parameters", true},						// Added: 2014 
            {"GL_ARB_point_sprite", true},							// Added: 2014 
            {"GL_ARB_post_depth_coverage", true},					// Added: 2016 
            {"GL_ARB_program_interface_query", true},				// Added: 2014 
            {"GL_ARB_provoking_vertex", true},						// Added: 2014 
            {"GL_ARB_query_buffer_object", true},					// Added: 2014 
            {"GL_ARB_robust_buffer_access_behavior", true},			// Added: 2014 
            {"GL_ARB_robustness", true},							// Added: 2014 
            {"GL_ARB_robustness_isolation", true},					// Added: 2014 
            {"GL_ARB_sample_locations", true},						// Added: 2016 
            {"GL_ARB_sample_shading", true},						// Added: 2014 
            {"GL_ARB_sampler_objects", true},						// Added: 2014 
            {"GL_ARB_seamless_cube_map", true},						// Added: 2014 
            {"GL_ARB_seamless_cubemap_per_texture", true},			// Added: 2014 
            {"GL_ARB_separate_shader_objects", true},				// Added: 2014 
            {"GL_ARB_shader_atomic_counter_ops", true},				// Added: 2016 
            {"GL_ARB_shader_atomic_counters", true},				// Added: 2014 
            {"GL_ARB_shader_ballot", true},							// Added: 2016 
            {"GL_ARB_shader_bit_encoding", true},					// Added: 2014 
            {"GL_ARB_shader_clock", true},							// Added: 2016 
            {"GL_ARB_shader_draw_parameters", true},				// Added: 2014 
            {"GL_ARB_shader_group_vote", true},						// Added: 2014 
            {"GL_ARB_shader_image_load_store", true},				// Added: 2014 
            {"GL_ARB_shader_image_size", true},						// Added: 2014 
            {"GL_ARB_shader_objects", true},						// Added: 2014 
            {"GL_ARB_shader_precision", true},						// Added: 2014 
            {"GL_ARB_shader_stencil_export", true},					// Added: 2014 
            {"GL_ARB_shader_storage_buffer_object", true},			// Added: 2014 
            {"GL_ARB_shader_subroutine", true},						// Added: 2014 
            {"GL_ARB_shader_texture_image_samples", true},			// Added: 2014 
            {"GL_ARB_shader_texture_lod", true},					// Added: 2014 
            {"GL_ARB_shader_viewport_layer_array", true},			// Added: 2016
            {"GL_ARB_shading_language_100", true},					// Added: 2014 
            {"GL_ARB_shading_language_420pack", true},				// Added: 2014 
            {"GL_ARB_shading_language_include", true},				// Added: 2014 
            {"GL_ARB_shading_language_packing", true},				// Added: 2014 
            {"GL_ARB_shadow", true},								// Added: 2014 
            {"GL_ARB_shadow_ambient", true},						// Added: 2014 
            {"GL_ARB_sparse_buffer", true},							// Added: 2016
            {"GL_ARB_sparse_texture", true},						// Added: 2014 
            {"GL_ARB_sparse_texture2", true},						// Added: 2016 
            {"GL_ARB_sparse_texture_clamp", true},					// Added: 2016 
            {"GL_ARB_stencil_texturing", true},						// Added: 2014 
            {"GL_ARB_sync", true},									// Added: 2014 
            {"GL_ARB_tessellation_shader", true},					// Added: 2014 
            {"GL_ARB_texture_barrier", true},						// Added: 2016 
            {"GL_ARB_texture_border_clamp", true},					// Added: 2014 
            {"GL_ARB_texture_buffer_object", true},					// Added: 2014 
            {"GL_ARB_texture_buffer_object_rgb32", true},			// Added: 2014 
            {"GL_ARB_texture_buffer_range", true},					// Added: 2014 
            {"GL_ARB_texture_compression", true},					// Added: 2014 
            {"GL_ARB_texture_compression_bptc", true},				// Added: 2014 
            {"GL_ARB_texture_compression_rgtc", true},				// Added: 2014 
            {"GL_ARB_texture_cube_map", true},						// Added: 2014 
            {"GL_ARB_texture_cube_map_array", true},				// Added: 2014 
            {"GL_ARB_texture_env_add", true},						// Added: 2014 
            {"GL_ARB_texture_env_combine", true},					// Added: 2014 
            {"GL_ARB_texture_env_crossbar", true},					// Added: 2014 
            {"GL_ARB_texture_env_dot3", true},						// Added: 2014 
            {"GL_ARB_texture_filter_minmax", true},					// Added: 2016 
            {"GL_ARB_texture_float", true},							// Added: 2014 
            {"GL_ARB_texture_gather", true},						// Added: 2014 
            {"GL_ARB_texture_mirror_clamp_to_edge", true},			// Added: 2014 
            {"GL_ARB_texture_mirrored_repeat", true},				// Added: 2014 
            {"GL_ARB_texture_multisample", true},					// Added: 2014 
            {"GL_ARB_texture_non_power_of_two", true},				// Added: 2014 
            {"GL_ARB_texture_query_levels", true},					// Added: 2014 
            {"GL_ARB_texture_query_lod", true},						// Added: 2014 
            {"GL_ARB_texture_rectangle", true},						// Added: 2014 
            {"GL_ARB_texture_rg", true},							// Added: 2014 
            {"GL_ARB_texture_rgb10_a2ui", true},					// Added: 2014 
            {"GL_ARB_texture_snorm", false},                        // Added: 2014 // ATI/AMD GPUs report to support this; similar to GL_EXT_texture_snorm
            {"GL_ARB_texture_stencil8", true},                     	// Added: 2014 
            {"GL_ARB_texture_storage", true},						// Added: 2014 
            {"GL_ARB_texture_storage_multisample", true},			// Added: 2014 
            {"GL_ARB_texture_swizzle", true},						// Added: 2014 
            {"GL_ARB_texture_view", true},							// Added: 2014 
            {"GL_ARB_timer_query", true},							// Added: 2014 
            {"GL_ARB_transform_feedback_instanced", true},			// Added: 2014 
            {"GL_ARB_transform_feedback_overflow_query", true},		// Added: 2016 
            {"GL_ARB_transform_feedback2", true},					// Added: 2014 
            {"GL_ARB_transform_feedback3", true},					// Added: 2014 
            {"GL_ARB_transpose_matrix", true},						// Added: 2014 
            {"GL_ARB_uniform_buffer_object", true},					// Added: 2014 
            {"GL_ARB_vertex_array_bgra", true},						// Added: 2014 
            {"GL_ARB_vertex_array_object", true},					// Added: 2014 
            {"GL_ARB_vertex_attrib_64bit", true},					// Added: 2014 
            {"GL_ARB_vertex_attrib_binding", true},					// Added: 2014 
            {"GL_ARB_vertex_blend", true},							// Added: 2014 
            {"GL_ARB_vertex_buffer_object", true},					// Added: 2014 
            {"GL_ARB_vertex_program", true},						// Added: 2014 
            {"GL_ARB_vertex_shader", true},							// Added: 2014 
            {"GL_ARB_vertex_type_10f_11f_11f_rev", true},          	// Added: 2014 
            {"GL_ARB_vertex_type_2_10_10_10_rev", true},			// Added: 2014 
            {"GL_ARB_viewport_array", true},						// Added: 2014 
            {"GL_ARB_window_pos", true},							// Added: 2014 
            {"GL_ATI_draw_buffers", true},							// Added: 2014 
            {"GL_ATI_element_array", true},							// Added: 2014 
            {"GL_ATI_envmap_bumpmap", true},						// Added: 2014 
            {"GL_ATI_fragment_shader", true},						// Added: 2014 
            {"GL_ATI_map_object_buffer", true},						// Added: 2014 
            {"GL_ATI_meminfo", true},								// Added: 2014 
            {"GL_ATI_pixel_format_float", true},					// Added: 2014 
            {"GL_ATI_pn_triangles", true},							// Added: 2014 
            {"GL_ATI_separate_stencil", true},						// Added: 2014 
            {"GL_ATI_text_fragment_shader", true},					// Added: 2014 
            {"GL_ATI_texture_compression_3dc", true},              	// Added: 2014 // ATI/AMD GPUs report to support this; undocumented; http://sourceforge.net/p/glew/patches/2/
            {"GL_ATI_texture_env_combine3", true},					// Added: 2014 
            {"GL_ATI_texture_float", true},							// Added: 2014 
            {"GL_ATI_texture_mirror_once", true},					// Added: 2014 
            {"GL_ATI_vertex_array_object", true},					// Added: 2014 
            {"GL_ATI_vertex_attrib_array_object", true},			// Added: 2014 
            {"GL_ATI_vertex_streams", true},						// Added: 2014 
            {"GL_EXT_422_pixels", true},							// Added: 2014 
            {"GL_EXT_abgr", true},									// Added: 2014 
            {"GL_EXT_bgra", true},									// Added: 2014 
            {"GL_EXT_bindable_uniform", true},						// Added: 2014 
            {"GL_EXT_blend_color", true},							// Added: 2014 
            {"GL_EXT_blend_equation_separate", true},				// Added: 2014 
            {"GL_EXT_blend_func_separate", true},					// Added: 2014 
            {"GL_EXT_blend_logic_op", true},						// Added: 2014 
            {"GL_EXT_blend_minmax", true},							// Added: 2014 
            {"GL_EXT_blend_subtract", true},						// Added: 2014 
            {"GL_EXT_Cg_shader", true},                             // Added: 2014 // NVIDIA GPUs report to support this; http://developer.download.nvidia.com/opengl/specs/GL_EXT_Cg_shader.txt
            {"GL_EXT_clip_volume_hint", true},						// Added: 2014 
            {"GL_EXT_cmyka", true},									// Added: 2014 
            {"GL_EXT_color_subtable", true},						// Added: 2014 
            {"GL_EXT_compiled_vertex_array", true},					// Added: 2014 
            {"GL_EXT_convolution", true},							// Added: 2014 
            {"GL_EXT_coordinate_frame", true},						// Added: 2014 
            {"GL_EXT_copy_buffer", false},                          // Added: 2014 // ATI/AMD GPUs report to support this; no internet search results; undocumented
            {"GL_EXT_copy_texture", true},							// Added: 2014 
            {"GL_EXT_cull_vertex", true},							// Added: 2014 
            {"GL_EXT_debug_label", true},							// Added: 2014 
            {"GL_EXT_debug_marker", true},							// Added: 2014 
            {"GL_EXT_depth_bounds_test", true},						// Added: 2014 
            {"GL_EXT_direct_state_access", true},					// Added: 2014 
            {"GL_EXT_draw_buffers2", true},							// Added: 2014 
            {"GL_EXT_draw_instanced", true},						// Added: 2014 
            {"GL_EXT_draw_range_elements", true},					// Added: 2014 
            {"GL_EXT_fog_coord", true},								// Added: 2014 
            {"GL_EXT_framebuffer_blit", true},						// Added: 2014 
            {"GL_EXT_framebuffer_multisample", true},				// Added: 2014 
            {"GL_EXT_framebuffer_multisample_blit_scaled", true},	// Added: 2014 
            {"GL_EXT_framebuffer_object", true},					// Added: 2014 
            {"GL_EXT_framebuffer_sRGB", true},						// Added: 2014 
            {"GL_EXT_geometry_shader4", true},						// Added: 2014 
            {"GL_EXT_gpu_program_parameters", true},				// Added: 2014 
            {"GL_EXT_gpu_shader4", true},							// Added: 2014 
            {"GL_EXT_histogram", true},								// Added: 2014 
            {"GL_EXT_import_sync_object", false},                   // Added: 2014 // NVIDIA GPUs report to support this; no internet search results; undocumented
            {"GL_EXT_index_array_formats", true},					// Added: 2014 
            {"GL_EXT_index_func", true},							// Added: 2014 
            {"GL_EXT_index_material", true},						// Added: 2014 
            {"GL_EXT_index_texture", true},							// Added: 2014 
            {"GL_EXT_light_texture", true},							// Added: 2014 
            {"GL_EXT_misc_attribute", true},						// Added: 2014 
            {"GL_EXT_multi_draw_arrays", true},						// Added: 2014 
            {"GL_EXT_multisample", true},							// Added: 2014 
            {"GL_EXT_packed_depth_stencil", true},					// Added: 2014 
            {"GL_EXT_packed_float", true},							// Added: 2014 
            {"GL_EXT_packed_pixels", true},							// Added: 2014 
            {"GL_EXT_paletted_texture", true},						// Added: 2014 
            {"GL_EXT_pixel_buffer_object", true},					// Added: 2014 
            {"GL_EXT_pixel_transform", true},						// Added: 2014 
            {"GL_EXT_pixel_transform_color_table", true},			// Added: 2014 
            {"GL_EXT_point_parameters", true},						// Added: 2014 
            {"GL_EXT_polygon_offset", true},						// Added: 2014 
            {"GL_EXT_polygon_offset_clamp", true},					// Added: 2016
            {"GL_EXT_post_depth_coverage", true},					// Added: 2016 
            {"GL_EXT_provoking_vertex", true},						// Added: 2014 
            {"GL_EXT_raster_multisample", true},					// Added: 2016 
            {"GL_EXT_rescale_normal", true},						// Added: 2014 
            {"GL_EXT_secondary_color", true},						// Added: 2014 
            {"GL_EXT_separate_shader_objects", true},				// Added: 2014 
            {"GL_EXT_separate_specular_color", true},				// Added: 2014 
            {"GL_EXT_shader_image_load_formatted", true},			// Added: 2016 
            {"GL_EXT_shader_image_load_store", true},				// Added: 2014 
            {"GL_EXT_shader_integer_mix", true},					// Added: 2014 
            {"GL_EXT_shadow_funcs", true},							// Added: 2014 
            {"GL_EXT_shared_texture_palette", true},				// Added: 2014 
            {"GL_EXT_sparse_texture2", true},						// Added: 2016 
            {"GL_EXT_stencil_clear_tag", true},						// Added: 2014 
            {"GL_EXT_stencil_two_side", true},						// Added: 2014 
            {"GL_EXT_stencil_wrap", true},							// Added: 2014 
            {"GL_EXT_subtexture", true},							// Added: 2014 
            {"GL_EXT_texgen_reflection", false},                    // Added: 2014 // ATI/AMD GPUs report to support this; no internet search results; undocumented; similar to GL_NV_texgen_reflection
            {"GL_EXT_texture", true},								// Added: 2014 
            {"GL_EXT_texture_array", true},							// Added: 2014 
            {"GL_EXT_texture_buffer_object", true},					// Added: 2014 
            {"GL_EXT_texture_compression_dxt1", true},				// Added: 2014 
            {"GL_EXT_texture_compression_latc", true},				// Added: 2014 
            {"GL_EXT_texture_compression_rgtc", true},				// Added: 2014 
            {"GL_EXT_texture_compression_s3tc", true},				// Added: 2014 
            {"GL_EXT_texture_cube_map", true},						// Added: 2014 
            {"GL_EXT_texture_edge_clamp", true},                    // Added: 2014 // ATI/AMD/NVIDIA GPUs report to support this; http://developer.download.nvidia.com/opengl/specs/GL_EXT_texture_edge_clamp.txt
            {"GL_EXT_texture_env_add", true},						// Added: 2014 
            {"GL_EXT_texture_env_combine", true},					// Added: 2014 
            {"GL_EXT_texture_env_dot3", true},						// Added: 2014 
            {"GL_EXT_texture_filter_anisotropic", true},			// Added: 2014 
            {"GL_EXT_texture_filter_minmax", true},					// Added: 2016 
            {"GL_EXT_texture_format_BGRA8888", true},				// Added: 2014 
            {"GL_EXT_texture_integer", true},						// Added: 2014 
            {"GL_EXT_texture_lod", false},                          // Added: 2014 // ATI/AMD/NVIDIA GPUs report to support this; no internet search results; undocumented; similar to GL_SGIS_texture_lod
            {"GL_EXT_texture_lod_bias", true},						// Added: 2014 
            {"GL_EXT_texture_mirror_clamp", true},					// Added: 2014 
            {"GL_EXT_texture_object", true},						// Added: 2014 
            {"GL_EXT_texture_perturb_normal", true},				// Added: 2014 
            {"GL_EXT_texture_rectangle", true},                     // Added: 2014 // ATI/AMD GPUs report to support this; https://developer.apple.com/opengl/extensions/ext_texture_rectangle.html
            {"GL_EXT_texture_shared_exponent", true},				// Added: 2014 
            {"GL_EXT_texture_snorm", true},							// Added: 2014 
            {"GL_EXT_texture_sRGB", true},							// Added: 2014 
            {"GL_EXT_texture_sRGB_decode", true},					// Added: 2014 
            {"GL_EXT_texture_storage", true},                       // Added: 2014 // ATI/AMD/NVIDIA GPUs report to support this; http://www.khronos.org/registry/gles/extensions/EXT/EXT_texture_storage.txt
            {"GL_EXT_texture_swizzle", true},						// Added: 2014 
            {"GL_EXT_texture_type_2_10_10_10_REV", true},			// Added: 2014 
            {"GL_EXT_texture3D", true},								// Added: 2014 
            {"GL_EXT_timer_query", true},							// Added: 2014 
            {"GL_EXT_transform_feedback", true},					// Added: 2014 
            {"GL_EXT_transform_feedback2", true},                   // Added: 2014 // NVIDIA GPUs report to support this; http://developer.download.nvidia.com/opengl/specs/GL_EXT_transform_feedback2.txt
            {"GL_EXT_vertex_array", true},							// Added: 2014 
            {"GL_EXT_vertex_array_bgra", true},						// Added: 2014 
            {"GL_EXT_vertex_attrib_64bit", true},					// Added: 2014 
            {"GL_EXT_vertex_shader", true},							// Added: 2014 
            {"GL_EXT_vertex_weighting", true},						// Added: 2014 
            {"GL_EXT_x11_sync_object", true},						// Added: 2014 
            {"GL_EXTX_framebuffer_mixed_formats", false},           // Added: 2014 // NVIDIA GPUs report to support this; no internet search results; undocumented
            {"GL_FfdMaskSGIX", true},								// Added: 2014 
            {"GL_GREMEDY_frame_terminator", true},					// Added: 2014 
            {"GL_GREMEDY_string_marker", true},						// Added: 2014 
            {"GL_HP_convolution_border_modes", true},				// Added: 2014 
            {"GL_HP_image_transform", true},						// Added: 2014 
            {"GL_HP_occlusion_test", true},							// Added: 2014 
            {"GL_HP_texture_lighting", true},						// Added: 2014 
            {"GL_IBM_cull_vertex", true},							// Added: 2014 
            {"GL_IBM_multimode_draw_arrays", true},					// Added: 2014 
            {"GL_IBM_rasterpos_clip", true},						// Added: 2014 
            {"GL_IBM_static_data", true},							// Added: 2016 
            {"GL_IBM_texture_mirrored_repeat", true},				// Added: 2014 
            {"GL_IBM_vertex_array_lists", true},					// Added: 2014 
            {"GL_INGR_blend_func_separate", true},					// Added: 2014 
            {"GL_INGR_color_clamp", true},							// Added: 2014 
            {"GL_INGR_interlace_read", true},						// Added: 2014 
            {"GL_INGR_palette_buffer", true},						// Added: 2014 
            {"GL_INTEL_fragment_shader_ordering", true},			// Added: 2014 
            {"GL_INTEL_framebuffer_CMAA", true},					// Added: 2016 
            {"GL_INTEL_map_texture", true},							// Added: 2014 
            {"GL_INTEL_parallel_arrays", true},						// Added: 2014 
            {"GL_INTEL_performance_query", true},					// Added: 2014 
            {"GL_KHR_blend_equation_advanced", true},				// Added: 2016 
            {"GL_KHR_blend_equation_advanced_coherent", true},		// Added: 2016 
            {"GL_KHR_context_flush_control", true},					// Added: 2016 
            {"GL_KHR_debug", true},									// Added: 2014 
            {"GL_KHR_no_error", true},								// Added: 2016 
            {"GL_KHR_robust_buffer_access_behavior", true},			// Added: 2016 
            {"GL_KHR_robustness", true},							// Added: 2016 
            {"GL_KHR_texture_compression_astc_hdr", true},			// Added: 2014 
            {"GL_KHR_texture_compression_astc_ldr", true},			// Added: 2014 
            {"GL_KHR_texture_compression_astc_sliced_3d", true},	// Added: 2016 
            {"GL_KTX_buffer_region", true},                         // Added: 2014 // AMD/ATI/NVIDIA GPUs report to support this; Definitions taken from GLEW v1.10.0 source code
            {"GL_MESA_pack_invert", true},							// Added: 2014 
            {"GL_MESA_resize_buffers", true},						// Added: 2014 
            {"GL_MESA_window_pos", true},							// Added: 2014 
            {"GL_MESA_ycbcr_texture", true},						// Added: 2014 
            {"GL_MESAX_texture_stack", true},						// Added: 2014 
            {"GL_NV_bindless_multi_draw_indirect", true},			// Added: 2014 
            {"GL_NV_bindless_multi_draw_indirect_count", true},		// Added: 2016 
            {"GL_NV_bindless_texture", true},						// Added: 2014 
            {"GL_NV_blend_equation_advanced", true},				// Added: 2014 
            {"GL_NV_blend_equation_advanced_coherent", true},		// Added: 2014 
            {"GL_NV_blend_square", true},							// Added: 2014 
            {"GL_NV_command_list", true},							// Added: 2016 
            {"GL_NV_compute_program5", true},						// Added: 2014 
            {"GL_NV_conditional_render", true},						// Added: 2014 
            {"GL_NV_conservative_raster", true},					// Added: 2016 
            {"GL_NV_conservative_raster_dilate", true},				// Added: 2016 
            {"GL_NV_copy_depth_to_color", true},					// Added: 2014 
            {"GL_NV_copy_image", true},								// Added: 2014 
            {"GL_NV_deep_texture3D", true},							// Added: 2014 
            {"GL_NV_depth_buffer_float", true},						// Added: 2014 
            {"GL_NV_depth_clamp", true},							// Added: 2014 
            {"GL_NV_draw_texture", true},							// Added: 2014 
            {"GL_NV_ES1_1_compatibility", false},                   // Added: 2014 // NVIDIA GPUs report to support this; no internet search results; undocumented
            {"GL_NV_evaluators", true},								// Added: 2014 
            {"GL_NV_explicit_multisample", true},					// Added: 2014 
            {"GL_NV_fbo_color_attachments", true},					// Added: 2014 
            {"GL_NV_fence", true},									// Added: 2014 
            {"GL_NV_fill_rectangle", true},							// Added: 2016 
            {"GL_NV_float_buffer", true},							// Added: 2014 
            {"GL_NV_fog_distance", true},							// Added: 2014 
            {"GL_NV_fragment_coverage_to_color", true},				// Added: 2016 
            {"GL_NV_fragment_program", true},						// Added: 2014 
            {"GL_NV_fragment_program2", true},						// Added: 2014 
            {"GL_NV_fragment_program4", true},						// Added: 2014 
            {"GL_NV_fragment_program_option", true},				// Added: 2014 
            {"GL_NV_fragment_shader_interlock", true},				// Added: 2016 
            {"GL_NV_framebuffer_mixed_samples", true},				// Added: 2016 
            {"GL_NV_framebuffer_multisample_coverage", true},		// Added: 2014 
            {"GL_NV_geometry_program4", true},						// Added: 2014 
            {"GL_NV_geometry_shader4", true},						// Added: 2014 
            {"GL_NV_geometry_shader_passthrough", true},			// Added: 2016 
            {"GL_NV_gpu_program_fp64", true},                       // Added: 2014 // NVIDIA GPUs report to support this; Definitions taken from GLEW 1.10.0 source code
            {"GL_NV_gpu_program4", true},							// Added: 2014 
            {"GL_NV_gpu_program4_1", false},                        // Added: 2014 // NVIDIA GPUs report to support this; no internet search results; undocumented;
            {"GL_NV_gpu_program5", true},							// Added: 2014 
            {"GL_NV_gpu_program5_mem_extended", true},				// Added: 2014 
            {"GL_NV_gpu_shader5", true},							// Added: 2014 
            {"GL_NV_half_float", true},								// Added: 2014 
            {"GL_NV_internalformat_sample_query", true},			// Added: 2016 
            {"GL_NV_light_max_exponent", true},						// Added: 2014 
            {"GL_NV_multisample_coverage", true},					// Added: 2014 
            {"GL_NV_multisample_filter_hint", true},				// Added: 2014 
            {"GL_NV_occlusion_query", true},						// Added: 2014 
            {"GL_NV_packed_depth_stencil", true},					// Added: 2014 
            {"GL_NV_parameter_buffer_object", true},				// Added: 2014 
            {"GL_NV_parameter_buffer_object2", true},				// Added: 2014 
            {"GL_NV_path_rendering", true},							// Added: 2014 
            {"GL_NV_path_rendering_shared_edge", true},				// Added: 2016 
            {"GL_NV_pixel_data_range", true},						// Added: 2014 
            {"GL_NV_point_sprite", true},							// Added: 2014 
            {"GL_NV_present_video", true},							// Added: 2014 
            {"GL_NV_primitive_restart", true},						// Added: 2014 
            {"GL_NV_register_combiners", true},						// Added: 2014 
            {"GL_NV_register_combiners2", true},					// Added: 2014 
            {"GL_NV_sample_locations", true},						// Added: 2016 
            {"GL_NV_sample_mask_override_coverage", true},			// Added: 2016 
            {"GL_NV_shader_atomic_counters", true}, 				// Added: 2014 
            {"GL_NV_shader_atomic_float", true},					// Added: 2014 
            {"GL_NV_shader_atomic_fp16_vector", true},				// Added: 2016 
            {"GL_NV_shader_atomic_int64", true},					// Added: 2016 
            {"GL_NV_shader_buffer_load", true},						// Added: 2014 
            {"GL_NV_shader_buffer_store", true},					// Added: 2014 
            {"GL_NV_shader_storage_buffer_object", true},			// Added: 2014 
            {"GL_NV_shader_thread_group", true},					// Added: 2016 
            {"GL_NV_shader_thread_shuffle", true},					// Added: 2016 
            {"GL_NV_tessellation_program5", true},					// Added: 2014 
            {"GL_NV_texgen_emboss", true},							// Added: 2014 
            {"GL_NV_texgen_reflection", true},						// Added: 2014 
            {"GL_NV_texture_barrier", true},						// Added: 2014 
            {"GL_NV_texture_compression_vtc", true},				// Added: 2014 
            {"GL_NV_texture_env_combine4", true},					// Added: 2014 
            {"GL_NV_texture_expand_normal", true},					// Added: 2014 
            {"GL_NV_texture_multisample", true},					// Added: 2014 
            {"GL_NV_texture_rectangle", true},  					// Added: 2014 
            {"GL_NV_texture_shader", true},							// Added: 2014 
            {"GL_NV_texture_shader2", true},						// Added: 2014 
            {"GL_NV_texture_shader3", true},						// Added: 2014 
            {"GL_NV_transform_feedback", true},						// Added: 2014 
            {"GL_NV_transform_feedback2", true},					// Added: 2014 
            {"GL_NV_uniform_buffer_unified_memory", true},			// Added: 2016 
            {"GL_NV_vdpau_interop", true},							// Added: 2014 
            {"GL_NV_vertex_array_range", true},						// Added: 2014 
            {"GL_NV_vertex_array_range2", true},					// Added: 2014 
            {"GL_NV_vertex_attrib_integer_64bit", true},			// Added: 2014 
            {"GL_NV_vertex_buffer_unified_memory", true},			// Added: 2014 
            {"GL_NV_vertex_program", true},							// Added: 2014 
            {"GL_NV_vertex_program1_1", true},						// Added: 2014 
            {"GL_NV_vertex_program2", true},						// Added: 2014 
            {"GL_NV_vertex_program2_option", true},					// Added: 2014 
            {"GL_NV_vertex_program3", true},						// Added: 2014 
            {"GL_NV_vertex_program4", true},						// Added: 2014 
            {"GL_NV_video_capture", true},							// Added: 2014 
            {"GL_NV_viewport_array2", true},						// Added: 2016 
            {"GL_NVX_conditional_render", true},					// Added: 2014 
            {"GL_NVX_gpu_memory_info", true},						// Added: 2014 
            {"GL_OES_byte_coordinates", true},						// Added: 2014 
            {"GL_OES_compressed_paletted_texture", true},			// Added: 2014 
            {"GL_OES_fixed_point", true},							// Added: 2014 
            {"GL_OES_query_matrix", true},							// Added: 2014 
            {"GL_OES_read_format", true},							// Added: 2014 
            {"GL_OES_single_precision", true},						// Added: 2014 
            {"GL_OML_interlace", true},								// Added: 2014 
            {"GL_OML_resample", true},								// Added: 2014 
            {"GL_OML_subsample", true},								// Added: 2014 
            {"GL_OVR_multiview", true},								// Added: 2016 
            {"GL_OVR_multiview2", true},							// Added: 2016 
            {"GL_PGI_misc_hints", true},							// Added: 2014 
            {"GL_PGI_vertex_hints", true},							// Added: 2014 
            {"GL_REND_screen_coordinates", true},					// Added: 2014 
            {"GL_S3_s3tc", true},									// Added: 2014 
            {"GL_SGI_color_matrix", true},							// Added: 2014 
            {"GL_SGI_color_table", true},							// Added: 2014 
            {"GL_SGI_depth_pass_instrument", true},					// Added: 2014 
            {"GL_SGI_texture_color_table", true},					// Added: 2014 
            {"GL_SGIS_detail_texture", true},						// Added: 2014 
            {"GL_SGIS_fog_function", true},							// Added: 2014 
            {"GL_SGIS_generate_mipmap", true},						// Added: 2014 
            {"GL_SGIS_multisample", true},							// Added: 2014 
            {"GL_SGIS_pixel_texture", true},						// Added: 2014 
            {"GL_SGIS_point_line_texgen", true},					// Added: 2014 
            {"GL_SGIS_point_parameters", true},						// Added: 2014 
            {"GL_SGIS_sharpen_texture", true},						// Added: 2014 
            {"GL_SGIS_texture4D", true},							// Added: 2014 
            {"GL_SGIS_texture_border_clamp", true},					// Added: 2014 
            {"GL_SGIS_texture_color_mask", true},					// Added: 2014 
            {"GL_SGIS_texture_edge_clamp", true},					// Added: 2014 
            {"GL_SGIS_texture_filter4", true},						// Added: 2014 
            {"GL_SGIS_texture_lod", true},							// Added: 2014 
            {"GL_SGIS_texture_select", true},						// Added: 2014 
            {"GL_SGIX_async", true},								// Added: 2014 
            {"GL_SGIX_async_histogram", true},						// Added: 2014 
            {"GL_SGIX_async_pixel", true},							// Added: 2014 
            {"GL_SGIX_blend_alpha_minmax", true},					// Added: 2014 
            {"GL_SGIX_calligraphic_fragment", true},				// Added: 2014 
            {"GL_SGIX_clipmap", true},								// Added: 2014 
            {"GL_SGIX_convolution_accuracy", true},					// Added: 2014 
            {"GL_SGIX_depth_pass_instrument", true},				// Added: 2014 
            {"GL_SGIX_depth_texture", true},						// Added: 2014 
            {"GL_SGIX_flush_raster", true},							// Added: 2014 
            {"GL_SGIX_fog_offset", true},							// Added: 2014 
            {"GL_SGIX_fog_scale", true},							// Added: 2014 
            {"GL_SGIX_fragment_lighting", true},					// Added: 2014 
            {"GL_SGIX_framezoom", true},							// Added: 2014 
            {"GL_SGIX_igloo_interface", true},						// Added: 2014 
            {"GL_SGIX_impact_pixel_texture", true},					// Added: 2014 
            {"GL_SGIX_instruments", true},							// Added: 2014 
            {"GL_SGIX_interlace", true},							// Added: 2014 
            {"GL_SGIX_ir_instrument1", true},						// Added: 2014 
            {"GL_SGIX_list_priority", true},						// Added: 2014 
            {"GL_SGIX_pixel_texture", true},						// Added: 2014 
            {"GL_SGIX_pixel_tiles", true},							// Added: 2014 
            {"GL_SGIX_polynomial_ffd", true},						// Added: 2014 
            {"GL_SGIX_reference_plane", true},						// Added: 2014 
            {"GL_SGIX_resample", true},								// Added: 2014 
            {"GL_SGIX_scalebias_hint", true},						// Added: 2014 
            {"GL_SGIX_shadow", true},								// Added: 2014 
            {"GL_SGIX_shadow_ambient", true},						// Added: 2014 
            {"GL_SGIX_sprite", true},								// Added: 2014 
            {"GL_SGIX_subsample", true},							// Added: 2014 
            {"GL_SGIX_tag_sample_buffer", true},					// Added: 2014 
            {"GL_SGIX_texture_add_env", true},						// Added: 2014 
            {"GL_SGIX_texture_coordinate_clamp", true},				// Added: 2014 
            {"GL_SGIX_texture_lod_bias", true},						// Added: 2014 
            {"GL_SGIX_texture_multi_buffer", true},					// Added: 2014 
            {"GL_SGIX_texture_scale_bias", true},					// Added: 2014 
            {"GL_SGIX_texture_select", true},						// Added: 2014 
            {"GL_SGIX_vertex_preclip", true},						// Added: 2014 
            {"GL_SGIX_ycrcb", true},								// Added: 2014 
            {"GL_SGIX_ycrcb_subsample", true},						// Added: 2014 
            {"GL_SGIX_ycrcba", true},								// Added: 2014 
            {"GL_SUN_convolution_border_modes", true},				// Added: 2014 
            {"GL_SUN_global_alpha", true},							// Added: 2014
            {"GL_SUN_mesh_array", true},							// Added: 2014 
            {"GL_SUN_multi_draw_arrays", true},						// Added: 2014 
            {"GL_SUN_slice_accum", true},							// Added: 2014 
            {"GL_SUN_triangle_list", true},							// Added: 2014 
            {"GL_SUN_vertex", true},								// Added: 2014 
            {"GL_SUNX_constant_data", true},						// Added: 2014 
            {"GL_WIN_phong_shading", true},							// Added: 2014 
            {"GL_WIN_specular_fog", true},							// Added: 2014 
            {"GL_WIN_swap_hint", true},                            	// Added: 2014 
            {"WGL_3DFX_multisample", true},							// Added: 2014 
            {"WGL_3DL_stereo_control", true},						// Added: 2014 
            {"WGL_AMD_gpu_association", true},						// Added: 2014 
            {"WGL_AMDX_gpu_association", false},                    // Added: 2014 // ATI/AMD GPUs report to support this
            {"WGL_ARB_buffer_region", true},						// Added: 2014 
            {"WGL_ARB_context_flush_control", true},				// Added: 2014                         
            {"WGL_ARB_create_context", true},						// Added: 2014 
            {"WGL_ARB_create_context_profile", true},       		// Added: 2014 
            {"WGL_ARB_create_context_robustness", true},           	// Added: 2014 
            {"WGL_ARB_extensions_string", true},                    // Added: 2014 
            {"WGL_ARB_framebuffer_sRGB", true},						// Added: 2014 
            {"WGL_ARB_make_current_read", true},					// Added: 2014 
            {"WGL_ARB_multisample", true},							// Added: 2014 
            {"WGL_ARB_pbuffer", true},								// Added: 2014 
            {"WGL_ARB_pixel_format", true},							// Added: 2014 
            {"WGL_ARB_pixel_format_float", true},					// Added: 2014 
            {"WGL_ARB_render_texture", true},						// Added: 2014 
            {"WGL_ARB_robustness_application_isolation", true},		// Added: 2014 
            {"WGL_ARB_robustness_share_group_isolation", true},		// Added: 2014 
            {"WGL_ATI_pixel_format_float", true},					// Added: 2014 
            {"WGL_ATI_render_texture_rectangle", false},            // Added: 2014 // ATI/AMD GPUs report to support this
            {"WGL_EXT_create_context_es_profile", true },			// Added: 2014 
            {"WGL_EXT_create_context_es2_profile",true},			// Added: 2014 
            {"WGL_EXT_depth_float", true},							// Added: 2014 
            {"WGL_EXT_display_color_table", true},					// Added: 2014 
            {"WGL_EXT_extensions_string", true},					// Added: 2014 
            {"WGL_EXT_framebuffer_sRGB", true},						// Added: 2014 
            {"WGL_EXT_make_current_read", true},					// Added: 2014 
            {"WGL_EXT_multisample", true},							// Added: 2014 
            {"WGL_EXT_pbuffer", true},								// Added: 2014 
            {"WGL_EXT_pixel_format", true},							// Added: 2014 
            {"WGL_EXT_pixel_format_packed_float", true},			// Added: 2014 
            {"WGL_EXT_swap_control", true},							// Added: 2014 
            {"WGL_EXT_swap_control_tear", true},					// Added: 2014 
            {"WGL_I3D_digital_video_control", true},				// Added: 2014 
            {"WGL_I3D_gamma", true},								// Added: 2014 
            {"WGL_I3D_genlock", true},								// Added: 2014 
            {"WGL_I3D_image_buffer", true},							// Added: 2014 
            {"WGL_I3D_swap_frame_lock", true},						// Added: 2014 
            {"WGL_I3D_swap_frame_usage", true},						// Added: 2014 
            {"WGL_NV_copy_image", true},							// Added: 2014 
            {"WGL_NV_delay_before_swap", true},						// Added: 2014 
            {"WGL_NV_DX_interop", true},                           	// Added: 2014 
            {"WGL_NV_DX_interop2", true},                          	// Added: 2014 
            {"WGL_NV_float_buffer", true},                         	// Added: 2014 
            {"WGL_NV_gpu_affinity", false},                         // Added: 2014 // TODO: SKIPPED FOR NOW!!!
            {"WGL_NV_multisample_coverage", true},                 	// Added: 2014 
            {"WGL_NV_present_video", true},                        	// Added: 2014 
            {"WGL_NV_render_depth_texture", true},                 	// Added: 2014 
            {"WGL_NV_render_texture_rectangle", true},             	// Added: 2014 
            {"WGL_NV_swap_group", true},                           	// Added: 2014 
            {"WGL_NV_vertex_array_range", true},                   	// Added: 2014 
            {"WGL_NV_video_capture", true},                        	// Added: 2014 
            {"WGL_NV_video_output", true},                         	// Added: 2014 
            {"WGL_NVX_DX_interop", false},                          // Added: 2014 // NVIDIA GPUs report to support this
            {"WGL_OML_sync_control", true}                         	// Added: 2014 
        };

        ///////////////////////////////////////////////////////////////////////
        // OPENGL INIT
        ///////////////////////////////////////////////////////////////////////
        public unsafe static void Init(byte ReqGLVersionMajor, byte ReqGLVersionMinor, string WindowName, int WindowPosX, int WindowPosY, int WindowSizeX, int WindowSizeY)
        {
            glLib = Windows.LoadLibrary("opengl32.dll");

            if (glLib != 0)
            {
                // First, create a backward-compatible (2.1 or older), old-style OpenGL context
                GLUT.InitDisplayMode(GLUT.GLUT_RGBA | GLUT.GLUT_DOUBLE | GLUT.GLUT_DEPTH);
                GLUT.InitWindowPosition(WindowPosX, WindowPosY);
                GLUT.InitWindowSize(WindowSizeX, WindowSizeY);
                int hWindow = GLUT.CreateWindow(WindowName);

                // Get addresses of OpenGL functions
                glFuncAddr = Windows.GetProcAddress(glLib, "glGetString");
                if (glFuncAddr != 0)
                {
				    glGetString = (TglGetString)Marshal.GetDelegateForFunctionPointer((IntPtr)glFuncAddr, typeof(TglGetString));
                }

                glFuncAddr = Windows.GetProcAddress(glLib, "glGetIntegerv");
				if (glFuncAddr != 0)
				{
                    glGetIntegerv = (TglGetIntegerv)Marshal.GetDelegateForFunctionPointer((IntPtr)glFuncAddr, typeof(TglGetIntegerv));
				}

                glFuncAddr = Windows.GetProcAddress(glLib, "wglGetProcAddress");
				if (glFuncAddr != 0)
				{
                    wglGetProcAddress = (TwglGetProcAddress)Marshal.GetDelegateForFunctionPointer((IntPtr)glFuncAddr, typeof(TwglGetProcAddress));
				}

                glFuncAddr = Windows.GetProcAddress(glLib, "wglGetCurrentDC");
				if (glFuncAddr != 0)
				{
                    wglGetCurrentDC = (TwglGetCurrentDC)Marshal.GetDelegateForFunctionPointer((IntPtr)glFuncAddr, typeof(TwglGetCurrentDC));
				}
				
                glFuncAddr = Windows.GetProcAddress(glLib, "wglMakeCurrent");
				if (glFuncAddr != 0)
				{
					wglMakeCurrent = (TwglMakeCurrent)Marshal.GetDelegateForFunctionPointer((IntPtr)glFuncAddr, typeof(TwglMakeCurrent));
				}
				
                glFuncAddr = (uint)wglGetProcAddress("glGetStringi");
                if (glFuncAddr != 0)
                {
                    glGetStringi = (TglGetStringi)Marshal.GetDelegateForFunctionPointer((IntPtr)glFuncAddr, typeof(TglGetStringi));
                }

                glFuncAddr = (uint)wglGetProcAddress("wglGetExtensionsStringARB");
                if (glFuncAddr != 0)
                {
                    wglGetExtensionsStringARB = (TwglGetExtensionsStringARB)Marshal.GetDelegateForFunctionPointer((IntPtr)glFuncAddr, typeof(TwglGetExtensionsStringARB));
                }

                glFuncAddr = (uint)wglGetProcAddress("wglCreateContextAttribsARB");
                if (glFuncAddr != 0)
                {
                    wglCreateContextAttribsARB = (TwglCreateContextAttribsARB)Marshal.GetDelegateForFunctionPointer((IntPtr)glFuncAddr, typeof(TwglCreateContextAttribsARB));
                }

                IntPtr hDC = wglGetCurrentDC();
                IntPtr hRC = IntPtr.Zero;
                int[] integerv = new int[1];

                if (ReqGLVersionMajor == 0 || (ReqGLVersionMajor == 0 && ReqGLVersionMinor == 0))
                {
                    // Try to create forward-compatible OpenGL context with highest possible version
                    glGetIntegerv(GL_CONFIG_MAJOR_VERSION, integerv);
                    ReqGLVersionMajor = (byte)integerv[0];
                    glGetIntegerv(GL_CONFIG_MINOR_VERSION, integerv);
                    ReqGLVersionMinor = (byte)integerv[0];
                }

                int[] attribList =
                {
                    (int)WGL_CONFIG_CONTEXT_MAJOR_VERSION_ARB, ReqGLVersionMajor,
                    (int)WGL_CONFIG_CONTEXT_MINOR_VERSION_ARB, ReqGLVersionMinor,
                    (int)WGL_CONFIG_CONTEXT_FLAGS_ARB, (int)WGL_CONFIG_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB,
                    0x0, 0x0
                };

                if (wglCreateContextAttribsARB != null)
                {
                    hRC = wglCreateContextAttribsARB(hDC, IntPtr.Zero, attribList);
                }

                if (hRC != IntPtr.Zero)
                {
                    if (wglMakeCurrent(hDC, hRC))
                    {
                        GLConfig.LogWriteLine();
                        GLConfig.LogWriteLine("[ INFO  ] Created OpenGL forward-compatible context");
                    }
                    else
                    {
                        GLConfig.LogWriteLine();
                        GLConfig.LogWriteLine("[WARNING] Couldn't create OpenGL forward-compatible context");
                        GLConfig.LogWriteLine("[ INFO  ] Created OpenGL backward-compatible context");
                    }
                }
                else
                {
                    GLConfig.LogWriteLine();
                    GLConfig.LogWriteLine("[WARNING] Couldn't create OpenGL forward-compatible context");
                    GLConfig.LogWriteLine("[ INFO  ] Created OpenGL backward-compatible context");
                }

                // First setup library supported OpenGL versions
                GL_VERSION = (byte)(ReqGLVersionMajor * 10 + ReqGLVersionMinor);
                if (GL_VERSION >= 11) { GL_VERSION_1_1 = true; }
                if (GL_VERSION >= 12) { GL_VERSION_1_2 = true; }
                if (GL_VERSION >= 13) { GL_VERSION_1_3 = true; }
                if (GL_VERSION >= 14) { GL_VERSION_1_4 = true; }
                if (GL_VERSION >= 15) { GL_VERSION_1_5 = true; }
                if (GL_VERSION >= 20) { GL_VERSION_2_0 = true; }
                if (GL_VERSION >= 21) { GL_VERSION_2_1 = true; }
                if (GL_VERSION >= 30) { GL_VERSION_3_0 = true; }
                if (GL_VERSION >= 31) { GL_VERSION_3_1 = true; }
                if (GL_VERSION >= 32) { GL_VERSION_3_2 = true; }
                if (GL_VERSION >= 33) { GL_VERSION_3_3 = true; }
                if (GL_VERSION >= 40) { GL_VERSION_4_0 = true; }
                if (GL_VERSION >= 41) { GL_VERSION_4_1 = true; }
                if (GL_VERSION >= 42) { GL_VERSION_4_2 = true; }
                if (GL_VERSION >= 43) { GL_VERSION_4_3 = true; }
                if (GL_VERSION >= 44) { GL_VERSION_4_4 = true; }
				if (GL_VERSION >= 45) { GL_VERSION_4_5 = true; }
				
                // Add the standard extensions to the ExtensionsGPU list
                string ExtStringStd = String.Empty;

                if (glGetString != null)
                {
                    ExtStringStd = new string((sbyte*)glGetString(GL_CONFIG_EXTENSIONS)).Trim();

                    foreach (string extension in ExtStringStd.Split(' '))
                    {
                        if (!ExtensionsGPU.Contains(extension) && !String.IsNullOrEmpty(extension))
                        {
                            ExtensionsGPU.Add(extension);
                        }
                    }
                }

                // Add the ARB extensions to the ExtensionsGPU list
                string ExtStringARB = String.Empty;

                if (wglGetExtensionsStringARB != null)
                {
                    ExtStringARB = new string((sbyte*)wglGetExtensionsStringARB(hDC)).Trim();

                    foreach (string extension in ExtStringARB.Split(' '))
                    {
                        if (!ExtensionsGPU.Contains(extension) && !String.IsNullOrEmpty(extension))
                        {
                            ExtensionsGPU.Add(extension);
                        }
                    }
                }

                // Nvidia drivers return an empty string in the standard glGetString function...
                // Use the new way to get the extension strings. Supported on OpenGL 3.0 or higher.
                // Add the indexed extensions to the ExtensionsGPU list
                string ExtStringIndexed = String.Empty;
                string extensionIndexed = String.Empty;

                if (ReqGLVersionMajor >= 3)
                {
                    glGetIntegerv(GL_CONFIG_NUM_EXTENSIONS, integerv);
                    int num_extensions = integerv[0];

                    for (uint counter = 0; counter < num_extensions; counter++)
                    {
                        extensionIndexed = new string((sbyte*)glGetStringi(GL_CONFIG_EXTENSIONS, counter)).Trim();

                        if (!ExtensionsGPU.Contains(extensionIndexed) && !String.IsNullOrEmpty(extensionIndexed))
                        {
                            ExtensionsGPU.Add(extensionIndexed);
                        }
                    }
                }

                // Transfer C# library supported functions to the unified list
                foreach (string extension in ExtensionsLIB.Keys)
                {
                    if (!String.IsNullOrEmpty(extension))
                    {
                        if (!ExtensionsALL.ContainsKey(extension))
                        {
                            // If extension is supported by this C# library, add to the unified list with lib_support_bit enabled
                            if (ExtensionsLIB[extension])
                            {
                                ExtensionsALL.Add(extension, SupportBitLIB);
                            }
                            else
                            {
                                ExtensionsALL.Add(extension, 0);
                            }
                        }
                    }
                }

                // Transfer GPU supported extensions to the unified list
                foreach (string extension in ExtensionsGPU)
                {
                    if (!String.IsNullOrEmpty(extension))
                    {
                        if (ExtensionsALL.ContainsKey(extension))
                        {
                            ExtensionsALL[extension] |= SupportBitGPU;
                        }
                        else
                        {
                            ExtensionsALL.Add(extension, SupportBitGPU);
                        }
                    }
                }

                GLConfig.LogWriteLine();
                GLConfig.LogWriteLine("OpenGL Extensions Supported...");
                GLConfig.LogWriteLine("============================================================");

                int counter_extension = 0;
                string line = "";

                foreach (string extension in ExtensionsALL.Keys)
                {
                    counter_extension++;

                    line = "[" + counter_extension.ToString().PadLeft(3, '0') + "]";

                    if ((ExtensionsALL[extension] & SupportBitGPU) > 0)
                    {
                        line += " [GPU ";
                    }
                    else
                    {
                        line += " [    ";
                    }

                    if ((ExtensionsALL[extension] & SupportBitLIB) > 0)
                    {
                        line += " LIB] ";
                    }
                    else
                    {
                        line += "    ] ";
                    }

                    line += extension;

                    GLConfig.LogWriteLine(line);
                }

                string vendor = new string((sbyte*)glGetString(GL_CONFIG_VENDOR)).Trim();
                string version = new string((sbyte*)glGetString(GL_CONFIG_VERSION)).Trim();
                string renderer = new string((sbyte*)glGetString(GL_CONFIG_RENDERER)).Trim();
                string shader = new string((sbyte*)glGetString(GL_CONFIG_SHADING_LANGUAGE_VERSION)).Trim();

                GLConfig.LogWriteLine();
                GLConfig.LogWriteLine("OpenGL Vendor                   : " + vendor);
                GLConfig.LogWriteLine("OpenGL Version                  : " + version);
                GLConfig.LogWriteLine("OpenGL Renderer                 : " + renderer);
                GLConfig.LogWriteLine("OpenGL Shading Language Version : " + shader);
            }
            else
            {
                Console.WriteLine("[ERROR] 'OPENGL32.DLL' not found!");
            }
        }

        ///////////////////////////////////////////////////////////////////////
        // CLASS CONSTRUCTOR
        ///////////////////////////////////////////////////////////////////////
        static GLConfig()
        {
            // Just call INIT function of GLConfig class...
        }

        public static bool IsExtensionSupported(string ExtensionName)
        {
            if (ExtensionsALL.ContainsKey(ExtensionName))
            {
                return (ExtensionsALL[ExtensionName] == (SupportBitGPU | SupportBitLIB));
            }
            else
            {
                return false;
            }
        }

        public static void DisableExtension(string ExtensionName)
        {
            if (ExtensionsALL.ContainsKey(ExtensionName))
            {
                ExtensionsALL[ExtensionName] &= (byte)~SupportBitLIB;
            }
        }

        public static void LogWriteLine(string LogLine = "")
        {
            Log.Add(LogLine);
        }

        public static void LogWriteToConsole()
        {
            foreach (string line in Log)
            {
                Console.WriteLine(line);
            }
        }

        public static void LogWriteToFile(string LogFileName)
        {
            if (File.Exists(LogFileName))
            {
                File.Delete(LogFileName);
            }

            StreamWriter LogFile = File.CreateText(LogFileName);

            LogFile.WriteLine("### REPORT TIME: " + DateTime.Now + " ###");
            LogFile.WriteLine();

            foreach (string line in Log)
            {
                LogFile.WriteLine(line);
            }
            
            LogFile.Close();
        }

        public static string[] LogDumpToString()
        {
            string[] dummy = new string[Log.Count];

            for (int counter = 0; counter < Log.Count; counter++)
            {
                dummy[counter] = Log[counter];
            }

            return dummy;
        }
    }

    public static partial class GL
    {
        ///////////////////////////////////////////////////////////////////////
        // VARIABLES
        ///////////////////////////////////////////////////////////////////////
        private static uint   glLib                 = 0;
        private static uint   glFuncAddr            = 0;
        private static string glFuncName            = null;
        private static string glLastExtName         = null;
        private static bool   glDisableExtensions   = true;

        ///////////////////////////////////////////////////////////////////////
        // DELEGATES
        ///////////////////////////////////////////////////////////////////////
        // wglGetProcAddress
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private delegate IntPtr TwglGetProcAddress(string procname);
        private static TwglGetProcAddress wglGetProcAddress = null;

        ///////////////////////////////////////////////////////////////////////
        // CLASS CONSTRUCTOR
        ///////////////////////////////////////////////////////////////////////
        static GL()
        {
        }

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
        // INIT
        ///////////////////////////////////////////////////////////////////////
        public unsafe static void Init(bool DisableExtensionsWhichHaveMissingFunctions = true)
        {
            glLib = Windows.LoadLibrary("opengl32.dll");

            if (glLib == 0)
            {
                GLConfig.LogWriteLine("[ERROR] 'OPENGL32.DLL' not found!");
            }
            else
            {
                glDisableExtensions = DisableExtensionsWhichHaveMissingFunctions;

                glFuncAddr = Windows.GetProcAddress(glLib, "wglGetProcAddress");
                GL.wglGetProcAddress = (TwglGetProcAddress)Marshal.GetDelegateForFunctionPointer((IntPtr)glFuncAddr, typeof(TwglGetProcAddress));
                
                // Link OpenGL Core Functions
                GL.LinkLibGLCore();

                // Link OpenGL Extensions
                GL.LinkLibGLEXT();

                // Link OpenGL WGL Core and Extension Functions
                WGL.Init(DisableExtensionsWhichHaveMissingFunctions);
            }
        }

        private static bool LinkProcGL(string FunctionName)
        {
            GL.glFuncName = FunctionName;
            GL.glFuncAddr = Windows.GetProcAddress(GL.glLib, GL.glFuncName);

            if (GL.glFuncAddr == 0 && GL.wglGetProcAddress != null)
            {
                GL.glFuncAddr = (uint)GL.wglGetProcAddress(GL.glFuncName);
            }

            if (GL.glFuncAddr == 0)
            {
                GLConfig.LogWriteLine("[WARNING] OpenGL function missing: " + GL.glFuncName);
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool LinkProcGLEXT(string FunctionName)
        {
            GL.glFuncName = FunctionName;
            GL.glFuncAddr = (uint)GL.wglGetProcAddress(GL.glFuncName);

            if (GL.glFuncAddr == 0)
            {
                if (glDisableExtensions && GLConfig.IsExtensionSupported(GL.glLastExtName))
                {
                    GLConfig.LogWriteLine("[ INFO  ] Disabling Extension       : " + GL.glLastExtName);
                    GLConfig.DisableExtension(GL.glLastExtName);
                }

                GLConfig.LogWriteLine("[WARNING] Extension function missing: " + GL.glFuncName);

                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool LinkGLEXT(string ExtensionName)
        {
            GL.glLastExtName = ExtensionName.Trim();

            if (GLConfig.IsExtensionSupported(GL.glLastExtName))
            {
                return true;
            }
            else
            {
                GL.glLastExtName = null;
                return false;
            }
        }
    }
}
