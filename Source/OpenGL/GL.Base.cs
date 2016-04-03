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
        private unsafe delegate void TglGetIntegerv(uint pname, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)] int[] parameters);
        private static TglGetIntegerv glGetIntegerv = null;

        // glGetString
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate byte* TglGetString(uint name);
        private static TglGetString glGetString = null;

        // glGetStringi
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate byte* TglGetStringi(uint name, uint index);
        private static TglGetStringi glGetStringi = null;

        // wglGetProcAddress
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        private delegate IntPtr TwglGetProcAddress(string procname);
        private static TwglGetProcAddress wglGetProcAddress = null;

        // wglGetCurrentDC
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr TwglGetCurrentDC();
        private static TwglGetCurrentDC wglGetCurrentDC = null;

        // wglMakeCurrent
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool TwglMakeCurrent(IntPtr hdc, IntPtr hglrc);
        private static TwglMakeCurrent wglMakeCurrent = null;

        // wglGetExtensionsStringARB
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate byte* TwglGetExtensionsStringARB(IntPtr hDC);
        private static TwglGetExtensionsStringARB wglGetExtensionsStringARB = null;

        // wglCreateContextAttribsARB
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
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
            {"GL_3DFX_multisample", true},
            {"GL_3DFX_tbuffer", true},
            {"GL_3DFX_texture_compression_FXT1", true},
            {"GL_AMD_blend_minmax_factor", true},
            {"GL_AMD_conservative_depth", true},
            {"GL_AMD_debug_output", true},
            {"GL_AMD_depth_clamp_separate", true},
            {"GL_AMD_draw_buffers_blend", true},
            {"GL_AMD_interleaved_elements", true},
            {"GL_AMD_multi_draw_indirect", true},
            {"GL_AMD_name_gen_delete", true},
            {"GL_AMD_occlusion_query_event", true},
            {"GL_AMD_performance_monitor", true},
            {"GL_AMD_pinned_memory", true},
            {"GL_AMD_query_buffer_object", true},
            {"GL_AMD_sample_positions", true},
            {"GL_AMD_seamless_cubemap_per_texture", true},
            {"GL_AMD_shader_atomic_counter_ops", true},
            {"GL_AMD_shader_stencil_export", true},
            {"GL_AMD_shader_trinary_minmax", true},
            {"GL_AMD_sparse_texture", true},
            {"GL_AMD_stencil_operation_extended", true},
            {"GL_AMD_texture_cube_map_array", false},               // ATI/AMD GPUs report to support this; no internet search results; similar to GL_ARB_texture_cube_map_array
            {"GL_AMD_texture_texture4", true},
            {"GL_AMD_transform_feedback3_lines_triangles", true},
            {"GL_AMD_vertex_shader_layer", true},
            {"GL_AMD_vertex_shader_tessellator", true},
            {"GL_AMD_vertex_shader_viewport_index", true},
            {"GL_AMDX_debug_output", true},                         // ATI/AMD GPUs report to support this; only renated to GL_AMD_debug_output
            {"GL_AMDX_vertex_shader_tessellator", true},            // ATI/AMD GPUs report to support this; only renamed to GL_AMD_vertex_shader_tessellator
            {"GL_APPLE_aux_depth_stencil", true},
            {"GL_APPLE_client_storage", true},
            {"GL_APPLE_element_array", true},
            {"GL_APPLE_fence", true},
            {"GL_APPLE_float_pixels", true},
            {"GL_APPLE_flush_buffer_range", true},
            {"GL_APPLE_object_purgeable", true},
            {"GL_APPLE_rgb_422", true},
            {"GL_APPLE_row_bytes", true},
            {"GL_APPLE_specular_vector", true},
            {"GL_APPLE_texture_range", true},
            {"GL_APPLE_transform_hint", true},
            {"GL_APPLE_vertex_array_object", true},
            {"GL_APPLE_vertex_array_range", true},
            {"GL_APPLE_vertex_program_evaluators", true},
            {"GL_APPLE_ycbcr_422", true},
            {"GL_ARB_arrays_of_arrays", true},
            {"GL_ARB_base_instance", true},
            {"GL_ARB_bindless_texture", true},
            {"GL_ARB_blend_func_extended", true},
            {"GL_ARB_buffer_storage", true},
            {"GL_ARB_cl_event", true},
            {"GL_ARB_clear_buffer_object", true},
            {"GL_ARB_clear_texture", true},
            {"GL_ARB_clip_control", true},
            {"GL_ARB_color_buffer_float", true},
            {"GL_ARB_compatibility", true},
            {"GL_ARB_compressed_texture_pixel_storage", true},
            {"GL_ARB_compute_shader", true},
            {"GL_ARB_compute_variable_group_size", true},
            {"GL_ARB_conditional_render_inverted", true},
            {"GL_ARB_conservative_depth", true},
            {"GL_ARB_copy_buffer", true},
            {"GL_ARB_copy_image", true},
            {"GL_ARB_cull_distance", true},
            {"GL_ARB_debug_output", true},
            {"GL_ARB_depth_buffer_float", true},
            {"GL_ARB_depth_clamp", true},
            {"GL_ARB_depth_texture", true},
            {"GL_ARB_derivative_control", true},
            {"GL_ARB_direct_state_access", true},
            {"GL_ARB_draw_buffers", true},
            {"GL_ARB_draw_buffers_blend", true},
            {"GL_ARB_draw_elements_base_vertex", true},
            {"GL_ARB_draw_indirect", true},
            {"GL_ARB_draw_instanced", true},
            {"GL_ARB_enhanced_layouts", true},                     // http://www.opengl.org/registry/specs/ARB/enhanced_layouts.txt
            {"GL_ARB_ES2_compatibility", true},
            {"GL_ARB_ES3_compatibility", true},
            {"GL_ARB_ES3_1_compatibility", true},
            {"GL_ARB_explicit_attrib_location", true},
            {"GL_ARB_explicit_uniform_location", true},
            {"GL_ARB_fragment_coord_conventions", true},
            {"GL_ARB_fragment_layer_viewport", true},
            {"GL_ARB_fragment_program", true},
            {"GL_ARB_fragment_program_shadow", true},
            {"GL_ARB_fragment_shader", true},
            {"GL_ARB_framebuffer_no_attachments", true},
            {"GL_ARB_framebuffer_object", true},
            {"GL_ARB_framebuffer_sRGB", true},
            {"GL_ARB_geometry_shader4", true},
            {"GL_ARB_get_program_binary", true},
            {"GL_ARB_get_texture_sub_image", true},
            {"GL_ARB_gpu_shader_fp64", true},
            {"GL_ARB_gpu_shader5", true},
            {"GL_ARB_half_float_pixel", true},
            {"GL_ARB_half_float_vertex", true},
            {"GL_ARB_imaging", true},
            {"GL_ARB_indirect_parameters", true},
            {"GL_ARB_instanced_arrays", true},
            {"GL_ARB_internalformat_query", true},
            {"GL_ARB_internalformat_query2", true},
            {"GL_ARB_invalidate_subdata", true},
            {"GL_ARB_map_buffer_alignment", true},
            {"GL_ARB_map_buffer_range", true},
            {"GL_ARB_matrix_palette", true},
            {"GL_ARB_multi_bind", true},
            {"GL_ARB_multi_draw_indirect", true},
            {"GL_ARB_multisample", true},
            {"GL_ARB_multitexture", true},
            {"GL_ARB_occlusion_query", true},
            {"GL_ARB_occlusion_query2", true},
            {"GL_ARB_pipeline_statistics_query", true},
            {"GL_ARB_pixel_buffer_object", true},
            {"GL_ARB_point_parameters", true},
            {"GL_ARB_point_sprite", true},
            {"GL_ARB_program_interface_query", true},
            {"GL_ARB_provoking_vertex", true},
            {"GL_ARB_query_buffer_object", true},
            {"GL_ARB_robust_buffer_access_behavior", true},
            {"GL_ARB_robustness", true},
            {"GL_ARB_robustness_isolation", true},
            {"GL_ARB_sample_shading", true},
            {"GL_ARB_sampler_objects", true},
            {"GL_ARB_seamless_cube_map", true},
            {"GL_ARB_seamless_cubemap_per_texture", true},
            {"GL_ARB_separate_shader_objects", true},
            {"GL_ARB_shader_atomic_counters", true},
            {"GL_ARB_shader_bit_encoding", true},
            {"GL_ARB_shader_draw_parameters", true},
            {"GL_ARB_shader_group_vote", true},
            {"GL_ARB_shader_image_load_store", true},
            {"GL_ARB_shader_image_size", true},
            {"GL_ARB_shader_objects", true},
            {"GL_ARB_shader_precision", true},
            {"GL_ARB_shader_stencil_export", true},
            {"GL_ARB_shader_storage_buffer_object", true},
            {"GL_ARB_shader_subroutine", true},
            {"GL_ARB_shader_texture_image_samples", true},
            {"GL_ARB_shader_texture_lod", true},
            {"GL_ARB_shading_language_100", true},
            {"GL_ARB_shading_language_420pack", true},
            {"GL_ARB_shading_language_include", true},
            {"GL_ARB_shading_language_packing", true},
            {"GL_ARB_shadow", true},
            {"GL_ARB_shadow_ambient", true},
            {"GL_ARB_sparse_texture", true},
            {"GL_ARB_stencil_texturing", true},
            {"GL_ARB_sync", true},
            {"GL_ARB_tessellation_shader", true},
            {"GL_ARB_texture_border_clamp", true},
            {"GL_ARB_texture_buffer_object", true},
            {"GL_ARB_texture_buffer_object_rgb32", true},
            {"GL_ARB_texture_buffer_range", true},
            {"GL_ARB_texture_compression", true},
            {"GL_ARB_texture_compression_bptc", true},
            {"GL_ARB_texture_compression_rgtc", true},
            {"GL_ARB_texture_cube_map", true},
            {"GL_ARB_texture_cube_map_array", true},
            {"GL_ARB_texture_env_add", true},
            {"GL_ARB_texture_env_combine", true},
            {"GL_ARB_texture_env_crossbar", true},
            {"GL_ARB_texture_env_dot3", true},
            {"GL_ARB_texture_float", true},
            {"GL_ARB_texture_gather", true},
            {"GL_ARB_texture_mirror_clamp_to_edge", true},
            {"GL_ARB_texture_mirrored_repeat", true},
            {"GL_ARB_texture_multisample", true},
            {"GL_ARB_texture_non_power_of_two", true},
            {"GL_ARB_texture_query_levels", true},
            {"GL_ARB_texture_query_lod", true},
            {"GL_ARB_texture_rectangle", true},
            {"GL_ARB_texture_rg", true},
            {"GL_ARB_texture_rgb10_a2ui", true},
            {"GL_ARB_texture_snorm", false},                        // ATI/AMD GPUs report to support this; similar to GL_EXT_texture_snorm
            {"GL_ARB_texture_stencil8", true},                     
            {"GL_ARB_texture_storage", true},
            {"GL_ARB_texture_storage_multisample", true},
            {"GL_ARB_texture_swizzle", true},
            {"GL_ARB_texture_view", true},
            {"GL_ARB_timer_query", true},
            {"GL_ARB_transform_feedback_instanced", true},
            {"GL_ARB_transform_feedback2", true},
            {"GL_ARB_transform_feedback3", true},
            {"GL_ARB_transpose_matrix", true},
            {"GL_ARB_uniform_buffer_object", true},
            {"GL_ARB_vertex_array_bgra", true},
            {"GL_ARB_vertex_array_object", true},
            {"GL_ARB_vertex_attrib_64bit", true},
            {"GL_ARB_vertex_attrib_binding", true},
            {"GL_ARB_vertex_blend", true},
            {"GL_ARB_vertex_buffer_object", true},
            {"GL_ARB_vertex_program", true},
            {"GL_ARB_vertex_shader", true},
            {"GL_ARB_vertex_type_10f_11f_11f_rev", true},          
            {"GL_ARB_vertex_type_2_10_10_10_rev", true},
            {"GL_ARB_viewport_array", true},
            {"GL_ARB_window_pos", true},
            {"GL_ATI_draw_buffers", true},
            {"GL_ATI_element_array", true},
            {"GL_ATI_envmap_bumpmap", true},
            {"GL_ATI_fragment_shader", true},
            {"GL_ATI_map_object_buffer", true},
            {"GL_ATI_meminfo", true},
            {"GL_ATI_pixel_format_float", true},
            {"GL_ATI_pn_triangles", true},
            {"GL_ATI_separate_stencil", true},
            {"GL_ATI_text_fragment_shader", true},
            {"GL_ATI_texture_compression_3dc", true},              // ATI/AMD GPUs report to support this; undocumented; http://sourceforge.net/p/glew/patches/2/
            {"GL_ATI_texture_env_combine3", true},
            {"GL_ATI_texture_float", true},
            {"GL_ATI_texture_mirror_once", true},
            {"GL_ATI_vertex_array_object", true},
            {"GL_ATI_vertex_attrib_array_object", true},
            {"GL_ATI_vertex_streams", true},
            {"GL_EXT_422_pixels", true},
            {"GL_EXT_abgr", true},
            {"GL_EXT_bgra", true},
            {"GL_EXT_bindable_uniform", true},
            {"GL_EXT_blend_color", true},
            {"GL_EXT_blend_equation_separate", true},
            {"GL_EXT_blend_func_separate", true},
            {"GL_EXT_blend_logic_op", true},
            {"GL_EXT_blend_minmax", true},
            {"GL_EXT_blend_subtract", true},
            {"GL_EXT_Cg_shader", true},                             // NVIDIA GPUs report to support this; http://developer.download.nvidia.com/opengl/specs/GL_EXT_Cg_shader.txt
            {"GL_EXT_clip_volume_hint", true},
            {"GL_EXT_cmyka", true},
            {"GL_EXT_color_subtable", true},
            {"GL_EXT_compiled_vertex_array", true},
            {"GL_EXT_convolution", true},
            {"GL_EXT_coordinate_frame", true},
            {"GL_EXT_copy_buffer", false},                          // ATI/AMD GPUs report to support this; no internet search results; undocumented
            {"GL_EXT_copy_texture", true},
            {"GL_EXT_cull_vertex", true},
            {"GL_EXT_debug_label", true},
            {"GL_EXT_debug_marker", true},
            {"GL_EXT_depth_bounds_test", true},
            {"GL_EXT_direct_state_access", true},
            {"GL_EXT_draw_buffers2", true},
            {"GL_EXT_draw_instanced", true},
            {"GL_EXT_draw_range_elements", true},
            {"GL_EXT_fog_coord", true},
            {"GL_EXT_framebuffer_blit", true},
            {"GL_EXT_framebuffer_multisample", true},
            {"GL_EXT_framebuffer_multisample_blit_scaled", true},
            {"GL_EXT_framebuffer_object", true},
            {"GL_EXT_framebuffer_sRGB", true},
            {"GL_EXT_geometry_shader4", true},
            {"GL_EXT_gpu_program_parameters", true},
            {"GL_EXT_gpu_shader4", true},
            {"GL_EXT_histogram", true},
            {"GL_EXT_import_sync_object", false},                   // NVIDIA GPUs report to support this; no internet search results; undocumented
            {"GL_EXT_index_array_formats", true},
            {"GL_EXT_index_func", true},
            {"GL_EXT_index_material", true},
            {"GL_EXT_index_texture", true},
            {"GL_EXT_light_texture", true},
            {"GL_EXT_misc_attribute", true},
            {"GL_EXT_multi_draw_arrays", true},
            {"GL_EXT_multisample", true},
            {"GL_EXT_packed_depth_stencil", true},
            {"GL_EXT_packed_float", true},
            {"GL_EXT_packed_pixels", true},
            {"GL_EXT_paletted_texture", true},
            {"GL_EXT_pixel_buffer_object", true},
            {"GL_EXT_pixel_transform", true},
            {"GL_EXT_pixel_transform_color_table", true},
            {"GL_EXT_point_parameters", true},
            {"GL_EXT_polygon_offset", true},
            {"GL_EXT_provoking_vertex", true},
            {"GL_EXT_rescale_normal", true},
            {"GL_EXT_secondary_color", true},
            {"GL_EXT_separate_shader_objects", true},
            {"GL_EXT_separate_specular_color", true},
            {"GL_EXT_shader_image_load_store", true},
            {"GL_EXT_shader_integer_mix", true},
            {"GL_EXT_shadow_funcs", true},
            {"GL_EXT_shared_texture_palette", true},
            {"GL_EXT_stencil_clear_tag", true},
            {"GL_EXT_stencil_two_side", true},
            {"GL_EXT_stencil_wrap", true},
            {"GL_EXT_subtexture", true},
            {"GL_EXT_texgen_reflection", false},                    // ATI/AMD GPUs report to support this; no internet search results; undocumented; similar to GL_NV_texgen_reflection
            {"GL_EXT_texture", true},
            {"GL_EXT_texture_array", true},
            {"GL_EXT_texture_buffer_object", true},
            {"GL_EXT_texture_compression_dxt1", true},
            {"GL_EXT_texture_compression_latc", true},
            {"GL_EXT_texture_compression_rgtc", true},
            {"GL_EXT_texture_compression_s3tc", true},
            {"GL_EXT_texture_cube_map", true},
            {"GL_EXT_texture_edge_clamp", true},                    // ATI/AMD/NVIDIA GPUs report to support this; http://developer.download.nvidia.com/opengl/specs/GL_EXT_texture_edge_clamp.txt
            {"GL_EXT_texture_env_add", true},
            {"GL_EXT_texture_env_combine", true},
            {"GL_EXT_texture_env_dot3", true},
            {"GL_EXT_texture_filter_anisotropic", true},
            {"GL_EXT_texture_format_BGRA8888", true},
            {"GL_EXT_texture_integer", true},
            {"GL_EXT_texture_lod", false},                          // ATI/AMD/NVIDIA GPUs report to support this; no internet search results; undocumented; similar to GL_SGIS_texture_lod
            {"GL_EXT_texture_lod_bias", true},
            {"GL_EXT_texture_mirror_clamp", true},
            {"GL_EXT_texture_object", true},
            {"GL_EXT_texture_perturb_normal", true},
            {"GL_EXT_texture_rectangle", true},                     // ATI/AMD GPUs report to support this; https://developer.apple.com/opengl/extensions/ext_texture_rectangle.html
            {"GL_EXT_texture_shared_exponent", true},
            {"GL_EXT_texture_snorm", true},
            {"GL_EXT_texture_sRGB", true},
            {"GL_EXT_texture_sRGB_decode", true},
            {"GL_EXT_texture_storage", true},                       // ATI/AMD/NVIDIA GPUs report to support this; http://www.khronos.org/registry/gles/extensions/EXT/EXT_texture_storage.txt
            {"GL_EXT_texture_swizzle", true},
            {"GL_EXT_texture_type_2_10_10_10_REV", true},
            {"GL_EXT_texture3D", true},
            {"GL_EXT_timer_query", true},
            {"GL_EXT_transform_feedback", true},
            {"GL_EXT_transform_feedback2", true},                   // NVIDIA GPUs report to support this; http://developer.download.nvidia.com/opengl/specs/GL_EXT_transform_feedback2.txt
            {"GL_EXT_vertex_array", true},
            {"GL_EXT_vertex_array_bgra", true},
            {"GL_EXT_vertex_attrib_64bit", true},
            {"GL_EXT_vertex_shader", true},
            {"GL_EXT_vertex_weighting", true},
            {"GL_EXT_x11_sync_object", true},
            {"GL_EXTX_framebuffer_mixed_formats", false},           // NVIDIA GPUs report to support this; no internet search results; undocumented
            {"GL_FfdMaskSGIX", true},
            {"GL_GREMEDY_frame_terminator", true},
            {"GL_GREMEDY_string_marker", true},
            {"GL_HP_convolution_border_modes", true},
            {"GL_HP_image_transform", true},
            {"GL_HP_occlusion_test", true},
            {"GL_HP_texture_lighting", true},
            {"GL_IBM_cull_vertex", true},
            {"GL_IBM_multimode_draw_arrays", true},
            {"GL_IBM_rasterpos_clip", true},
            {"GL_IBM_texture_mirrored_repeat", true},
            {"GL_IBM_vertex_array_lists", true},
            {"GL_INGR_blend_func_separate", true},
            {"GL_INGR_color_clamp", true},
            {"GL_INGR_interlace_read", true},
            {"GL_INGR_palette_buffer", true},
            {"GL_INTEL_fragment_shader_ordering", true},
            {"GL_INTEL_map_texture", true},
            {"GL_INTEL_parallel_arrays", true},
            {"GL_INTEL_performance_query", true}, 
            {"GL_KHR_debug", true},
            {"GL_KHR_texture_compression_astc_hdr", true},
            {"GL_KHR_texture_compression_astc_ldr", true},
            {"GL_KTX_buffer_region", true},                         // AMD/ATI/NVIDIA GPUs report to support this; Definitions taken from GLEW v1.10.0 source code
            {"GL_MESA_pack_invert", true},
            {"GL_MESA_resize_buffers", true},
            {"GL_MESA_window_pos", true},
            {"GL_MESA_ycbcr_texture", true},
            {"GL_MESAX_texture_stack", true},
            {"GL_NV_bindless_multi_draw_indirect", true},
            {"GL_NV_bindless_texture", true},
            {"GL_NV_blend_equation_advanced", true},
            {"GL_NV_blend_equation_advanced_coherent", true},
            {"GL_NV_blend_square", true},
            {"GL_NV_compute_program5", true},
            {"GL_NV_conditional_render", true},
            {"GL_NV_copy_depth_to_color", true},
            {"GL_NV_copy_image", true},
            {"GL_NV_deep_texture3D", true},
            {"GL_NV_depth_buffer_float", true},
            {"GL_NV_depth_clamp", true},
            {"GL_NV_draw_texture", true},
            {"GL_NV_ES1_1_compatibility", false},                   // NVIDIA GPUs report to support this; no internet search results; undocumented
            {"GL_NV_evaluators", true},
            {"GL_NV_explicit_multisample", true},
            {"GL_NV_fbo_color_attachments", true},
            {"GL_NV_fence", true},
            {"GL_NV_float_buffer", true},
            {"GL_NV_fog_distance", true},
            {"GL_NV_fragment_program", true},
            {"GL_NV_fragment_program_option", true},
            {"GL_NV_fragment_program2", true},
            {"GL_NV_fragment_program4", true},
            {"GL_NV_framebuffer_multisample_coverage", true},
            {"GL_NV_geometry_program4", true},
            {"GL_NV_geometry_shader4", true},
            {"GL_NV_gpu_program_fp64", true},                       // NVIDIA GPUs report to support this; Definitions taken from GLEW 1.10.0 source code
            {"GL_NV_gpu_program4", true},
            {"GL_NV_gpu_program4_1", false},                        // NVIDIA GPUs report to support this; no internet search results; undocumented;
            {"GL_NV_gpu_program5", true},
            {"GL_NV_gpu_program5_mem_extended", true},
            {"GL_NV_gpu_shader5", true},
            {"GL_NV_half_float", true},
            {"GL_NV_light_max_exponent", true},
            {"GL_NV_multisample_coverage", true},
            {"GL_NV_multisample_filter_hint", true},
            {"GL_NV_occlusion_query", true},
            {"GL_NV_packed_depth_stencil", true},
            {"GL_NV_parameter_buffer_object", true},
            {"GL_NV_parameter_buffer_object2", true},
            {"GL_NV_path_rendering", true},
            {"GL_NV_pixel_data_range", true},
            {"GL_NV_point_sprite", true},
            {"GL_NV_present_video", true},
            {"GL_NV_primitive_restart", true},
            {"GL_NV_register_combiners", true},
            {"GL_NV_register_combiners2", true},
            {"GL_NV_shader_atomic_counters", true}, 
            {"GL_NV_shader_atomic_float", true},
            {"GL_NV_shader_buffer_load", true},
            {"GL_NV_shader_buffer_store", true},
            {"GL_NV_shader_storage_buffer_object", true},
            {"GL_NV_tessellation_program5", true},
            {"GL_NV_texgen_emboss", true},
            {"GL_NV_texgen_reflection", true},
            {"GL_NV_texture_barrier", true},
            {"GL_NV_texture_compression_vtc", true},
            {"GL_NV_texture_env_combine4", true},
            {"GL_NV_texture_expand_normal", true},
            {"GL_NV_texture_multisample", true},
            {"GL_NV_texture_rectangle", true},  
            {"GL_NV_texture_shader", true},
            {"GL_NV_texture_shader2", true},
            {"GL_NV_texture_shader3", true},
            {"GL_NV_transform_feedback", true},
            {"GL_NV_transform_feedback2", true},
            {"GL_NV_vdpau_interop", true},
            {"GL_NV_vertex_array_range", true},
            {"GL_NV_vertex_array_range2", true},
            {"GL_NV_vertex_attrib_integer_64bit", true},
            {"GL_NV_vertex_buffer_unified_memory", true},
            {"GL_NV_vertex_program", true},
            {"GL_NV_vertex_program1_1", true},
            {"GL_NV_vertex_program2", true},
            {"GL_NV_vertex_program2_option", true},
            {"GL_NV_vertex_program3", true},
            {"GL_NV_vertex_program4", true},
            {"GL_NV_video_capture", true},
            {"GL_NVX_conditional_render", true},
            {"GL_NVX_gpu_memory_info", true},
            {"GL_OES_byte_coordinates", true},
            {"GL_OES_compressed_paletted_texture", true},
            {"GL_OES_fixed_point", true},
            {"GL_OES_query_matrix", true},
            {"GL_OES_read_format", true},
            {"GL_OES_single_precision", true},
            {"GL_OML_interlace", true},
            {"GL_OML_resample", true},
            {"GL_OML_subsample", true},
            {"GL_PGI_misc_hints", true},
            {"GL_PGI_vertex_hints", true},
            {"GL_REND_screen_coordinates", true},
            {"GL_S3_s3tc", true},
            {"GL_SGI_color_matrix", true},
            {"GL_SGI_color_table", true},
            {"GL_SGI_depth_pass_instrument", true},
            {"GL_SGI_texture_color_table", true},
            {"GL_SGIS_detail_texture", true},
            {"GL_SGIS_fog_function", true},
            {"GL_SGIS_generate_mipmap", true},
            {"GL_SGIS_multisample", true},
            {"GL_SGIS_pixel_texture", true},
            {"GL_SGIS_point_line_texgen", true},
            {"GL_SGIS_point_parameters", true},
            {"GL_SGIS_sharpen_texture", true},
            {"GL_SGIS_texture_border_clamp", true},
            {"GL_SGIS_texture_color_mask", true},
            {"GL_SGIS_texture_edge_clamp", true},
            {"GL_SGIS_texture_filter4", true},
            {"GL_SGIS_texture_lod", true},
            {"GL_SGIS_texture_select", true},
            {"GL_SGIS_texture4D", true},
            {"GL_SGIX_async", true},
            {"GL_SGIX_async_histogram", true},
            {"GL_SGIX_async_pixel", true},
            {"GL_SGIX_blend_alpha_minmax", true},
            {"GL_SGIX_calligraphic_fragment", true},
            {"GL_SGIX_clipmap", true},
            {"GL_SGIX_convolution_accuracy", true},
            {"GL_SGIX_depth_pass_instrument", true},
            {"GL_SGIX_depth_texture", true},
            {"GL_SGIX_flush_raster", true},
            {"GL_SGIX_fog_offset", true},
            {"GL_SGIX_fog_scale", true},
            {"GL_SGIX_fragment_lighting", true},
            {"GL_SGIX_framezoom", true},
            {"GL_SGIX_igloo_interface", true},
            {"GL_SGIX_impact_pixel_texture", true},
            {"GL_SGIX_instruments", true},
            {"GL_SGIX_interlace", true},
            {"GL_SGIX_ir_instrument1", true},
            {"GL_SGIX_list_priority", true},
            {"GL_SGIX_pixel_texture", true},
            {"GL_SGIX_pixel_tiles", true},
            {"GL_SGIX_polynomial_ffd", true},
            {"GL_SGIX_reference_plane", true},
            {"GL_SGIX_resample", true},
            {"GL_SGIX_scalebias_hint", true},
            {"GL_SGIX_shadow", true},
            {"GL_SGIX_shadow_ambient", true},
            {"GL_SGIX_sprite", true},
            {"GL_SGIX_subsample", true},
            {"GL_SGIX_tag_sample_buffer", true},
            {"GL_SGIX_texture_add_env", true},
            {"GL_SGIX_texture_coordinate_clamp", true},
            {"GL_SGIX_texture_lod_bias", true},
            {"GL_SGIX_texture_multi_buffer", true},
            {"GL_SGIX_texture_scale_bias", true},
            {"GL_SGIX_texture_select", true},
            {"GL_SGIX_vertex_preclip", true},
            {"GL_SGIX_ycrcb", true},
            {"GL_SGIX_ycrcb_subsample", true},
            {"GL_SGIX_ycrcba", true},
            {"GL_SUN_convolution_border_modes", true},
            {"GL_SUN_global_alpha", true},
            {"GL_SUN_mesh_array", true},
            {"GL_SUN_multi_draw_arrays", true},
            {"GL_SUN_slice_accum", true},
            {"GL_SUN_triangle_list", true},
            {"GL_SUN_vertex", true},
            {"GL_SUNX_constant_data", true},
            {"GL_WIN_phong_shading", true},
            {"GL_WIN_specular_fog", true},
            {"GL_WIN_swap_hint", true},                            
            {"WGL_3DFX_multisample", true},
            {"WGL_3DL_stereo_control", true},
            {"WGL_AMD_gpu_association", true},
            {"WGL_AMDX_gpu_association", false},                    // ATI/AMD GPUs report to support this
            {"WGL_ARB_buffer_region", true},
            {"WGL_ARB_context_flush_control", true},                        
            {"WGL_ARB_create_context", true},
            {"WGL_ARB_create_context_profile", true},       
            {"WGL_ARB_create_context_robustness", true},           
            {"WGL_ARB_extensions_string", true},                    
            {"WGL_ARB_framebuffer_sRGB", true},
            {"WGL_ARB_make_current_read", true},
            {"WGL_ARB_multisample", true},
            {"WGL_ARB_pbuffer", true},
            {"WGL_ARB_pixel_format", true},
            {"WGL_ARB_pixel_format_float", true},
            {"WGL_ARB_render_texture", true},
            {"WGL_ARB_robustness_application_isolation", true},
            {"WGL_ARB_robustness_share_group_isolation", true},
            {"WGL_ATI_pixel_format_float", true},
            {"WGL_ATI_render_texture_rectangle", false},            // ATI/AMD GPUs report to support this
            {"WGL_EXT_create_context_es_profile", true },
            {"WGL_EXT_create_context_es2_profile",true},
            {"WGL_EXT_depth_float", true},
            {"WGL_EXT_display_color_table", true},
            {"WGL_EXT_extensions_string", true},
            {"WGL_EXT_framebuffer_sRGB", true},
            {"WGL_EXT_make_current_read", true},
            {"WGL_EXT_multisample", true},
            {"WGL_EXT_pbuffer", true},
            {"WGL_EXT_pixel_format", true},
            {"WGL_EXT_pixel_format_packed_float", true},
            {"WGL_EXT_swap_control", true},
            {"WGL_EXT_swap_control_tear", true},
            {"WGL_I3D_digital_video_control", true},
            {"WGL_I3D_gamma", true},
            {"WGL_I3D_genlock", true},
            {"WGL_I3D_image_buffer", true},
            {"WGL_I3D_swap_frame_lock", true},
            {"WGL_I3D_swap_frame_usage", true},
            {"WGL_NV_copy_image", true},
            {"WGL_NV_delay_before_swap", true},
            {"WGL_NV_DX_interop", true},                           
            {"WGL_NV_DX_interop2", true},                          
            {"WGL_NV_float_buffer", true},                         
            {"WGL_NV_gpu_affinity", false},                         // TODO: SKIPPED FOR NOW!!!
            {"WGL_NV_multisample_coverage", true},                 
            {"WGL_NV_present_video", true},                        
            {"WGL_NV_render_depth_texture", true},                 
            {"WGL_NV_render_texture_rectangle", true},             
            {"WGL_NV_swap_group", true},                           
            {"WGL_NV_vertex_array_range", true},                   
            {"WGL_NV_video_capture", true},                        
            {"WGL_NV_video_output", true},                         
            {"WGL_NVX_DX_interop", false},                          // NVIDIA GPUs report to support this
            {"WGL_OML_sync_control", true}                         
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
