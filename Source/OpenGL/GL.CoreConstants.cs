using System;

namespace OpenGLDotNet
{
    public static partial class GL
    {
        ///////////////////////////////////////////////////////////////////////
        // OPENGL 1.1 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 1.1 CONSTANTS...
        // AccumOp
        public const uint GL_ACCUM = 0x0100;
        public const uint GL_LOAD = 0x0101;
        public const uint GL_RETURN = 0x0102;
        public const uint GL_MULT = 0x0103;
        public const uint GL_ADD = 0x0104;

        // Alpha functions
        public const uint GL_NEVER = 0x0200;
        public const uint GL_LESS = 0x0201;
        public const uint GL_EQUAL = 0x0202;
        public const uint GL_LEQUAL = 0x0203;
        public const uint GL_GREATER = 0x0204;
        public const uint GL_NOTEQUAL = 0x0205;
        public const uint GL_GEQUAL = 0x0206;
        public const uint GL_ALWAYS = 0x0207;

        // AttribMask
        public const uint GL_CURRENT_BIT = 0x00000001;
        public const uint GL_POINT_BIT = 0x00000002;
        public const uint GL_LINE_BIT = 0x00000004;
        public const uint GL_POLYGON_BIT = 0x00000008;
        public const uint GL_POLYGON_STIPPLE_BIT = 0x00000010;
        public const uint GL_PIXEL_MODE_BIT = 0x00000020;
        public const uint GL_LIGHTING_BIT = 0x00000040;
        public const uint GL_FOG_BIT = 0x00000080;
        public const uint GL_DEPTH_BUFFER_BIT = 0x00000100;
        public const uint GL_ACCUM_BUFFER_BIT = 0x00000200;
        public const uint GL_STENCIL_BUFFER_BIT = 0x00000400;
        public const uint GL_VIEWPORT_BIT = 0x00000800;
        public const uint GL_TRANSFORM_BIT = 0x00001000;
        public const uint GL_ENABLE_BIT = 0x00002000;
        public const uint GL_COLOR_BUFFER_BIT = 0x00004000;
        public const uint GL_HINT_BIT = 0x00008000;
        public const uint GL_EVAL_BIT = 0x00010000;
        public const uint GL_LIST_BIT = 0x00020000;
        public const uint GL_TEXTURE_BIT = 0x00040000;
        public const uint GL_SCISSOR_BIT = 0x00080000;
        public const uint GL_ALL_ATTRIB_BITS = 0x000fffff;

        // BeginMode
        public const uint GL_POINTS = 0x0000;
        public const uint GL_LINES = 0x0001;
        public const uint GL_LINE_LOOP = 0x0002;
        public const uint GL_LINE_STRIP = 0x0003;
        public const uint GL_TRIANGLES = 0x0004;
        public const uint GL_TRIANGLE_STRIP = 0x0005;
        public const uint GL_TRIANGLE_FAN = 0x0006;
        public const uint GL_QUADS = 0x0007;
        public const uint GL_QUAD_STRIP = 0x0008;
        public const uint GL_POLYGON = 0x0009;

        // BlendingFactorDest
        public const uint GL_ZERO = 0;
        public const uint GL_ONE = 1;
        public const uint GL_SRC_COLOR = 0x0300;
        public const uint GL_ONE_MINUS_SRC_COLOR = 0x0301;
        public const uint GL_SRC_ALPHA = 0x0302;
        public const uint GL_ONE_MINUS_SRC_ALPHA = 0x0303;
        public const uint GL_DST_ALPHA = 0x0304;
        public const uint GL_ONE_MINUS_DST_ALPHA = 0x0305;

        // BlendingFactorSrc
        public const uint GL_DST_COLOR = 0x0306;
        public const uint GL_ONE_MINUS_DST_COLOR = 0x0307;
        public const uint GL_SRC_ALPHA_SATURATE = 0x0308;

        // Boolean
        public const uint GL_TRUE = 1;
        public const uint GL_FALSE = 0;

        // ClipPlaneName
        public const uint GL_CLIP_PLANE0 = 0x3000;
        public const uint GL_CLIP_PLANE1 = 0x3001;
        public const uint GL_CLIP_PLANE2 = 0x3002;
        public const uint GL_CLIP_PLANE3 = 0x3003;
        public const uint GL_CLIP_PLANE4 = 0x3004;
        public const uint GL_CLIP_PLANE5 = 0x3005;

        // DataType
        public const uint GL_BYTE = 0x1400;
        public const uint GL_UNSIGNED_BYTE = 0x1401;
        public const uint GL_SHORT = 0x1402;
        public const uint GL_UNSIGNED_SHORT = 0x1403;
        public const uint GL_INT = 0x1404;
        public const uint GL_UNSIGNED_INT = 0x1405;
        public const uint GL_FLOAT = 0x1406;
        public const uint GL_2_BYTES = 0x1407;
        public const uint GL_3_BYTES = 0x1408;
        public const uint GL_4_BYTES = 0x1409;
        public const uint GL_DOUBLE = 0x140A;

        // DrawBufferMode
        public const uint GL_NONE = 0;
        public const uint GL_FRONT_LEFT = 0x0400;
        public const uint GL_FRONT_RIGHT = 0x0401;
        public const uint GL_BACK_LEFT = 0x0402;
        public const uint GL_BACK_RIGHT = 0x0403;
        public const uint GL_FRONT = 0x0404;
        public const uint GL_BACK = 0x0405;
        public const uint GL_LEFT = 0x0406;
        public const uint GL_RIGHT = 0x0407;
        public const uint GL_FRONT_AND_BACK = 0x0408;
        public const uint GL_AUX0 = 0x0409;
        public const uint GL_AUX1 = 0x040A;
        public const uint GL_AUX2 = 0x040B;
        public const uint GL_AUX3 = 0x040C;

        // ErrorCode
        public const uint GL_NO_ERROR = 0;
        public const uint GL_INVALID_ENUM = 0x0500;
        public const uint GL_INVALID_VALUE = 0x0501;
        public const uint GL_INVALID_OPERATION = 0x0502;
        public const uint GL_STACK_OVERFLOW = 0x0503;
        public const uint GL_STACK_UNDERFLOW = 0x0504;
        public const uint GL_OUT_OF_MEMORY = 0x0505;

        // FeedBackMode
        public const uint GL_2D = 0x0600;
        public const uint GL_3D = 0x0601;
        public const uint GL_4D_COLOR = 0x0602;
        public const uint GL_3D_COLOR_TEXTURE = 0x0603;
        public const uint GL_4D_COLOR_TEXTURE = 0x0604;

        // FeedBackToken
        public const uint GL_PASS_THROUGH_TOKEN = 0x0700;
        public const uint GL_POINT_TOKEN = 0x0701;
        public const uint GL_LINE_TOKEN = 0x0702;
        public const uint GL_POLYGON_TOKEN = 0x0703;
        public const uint GL_BITMAP_TOKEN = 0x0704;
        public const uint GL_DRAW_PIXEL_TOKEN = 0x0705;
        public const uint GL_COPY_PIXEL_TOKEN = 0x0706;
        public const uint GL_LINE_RESET_TOKEN = 0x0707;

        // FogMode
        public const uint GL_EXP = 0x0800;
        public const uint GL_EXP2 = 0x0801;

        // FrontFaceDirection
        public const uint GL_CW = 0x0900;
        public const uint GL_CCW = 0x0901;

        // GetMapTarget 
        public const uint GL_COEFF = 0x0A00;
        public const uint GL_ORDER = 0x0A01;
        public const uint GL_DOMAIN = 0x0A02;

        // GetTarget
        public const uint GL_CURRENT_COLOR = 0x0B00;
        public const uint GL_CURRENT_INDEX = 0x0B01;
        public const uint GL_CURRENT_NORMAL = 0x0B02;
        public const uint GL_CURRENT_TEXTURE_COORDS = 0x0B03;
        public const uint GL_CURRENT_RASTER_COLOR = 0x0B04;
        public const uint GL_CURRENT_RASTER_INDEX = 0x0B05;
        public const uint GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;
        public const uint GL_CURRENT_RASTER_POSITION = 0x0B07;
        public const uint GL_CURRENT_RASTER_POSITION_VALID = 0x0B08;
        public const uint GL_CURRENT_RASTER_DISTANCE = 0x0B09;
        public const uint GL_POINT_SMOOTH = 0x0B10;
        public const uint GL_POINT_SIZE = 0x0B11;
        public const uint GL_POINT_SIZE_RANGE = 0x0B12;
        public const uint GL_POINT_SIZE_GRANULARITY = 0x0B13;
        public const uint GL_LINE_SMOOTH = 0x0B20;
        public const uint GL_LINE_WIDTH = 0x0B21;
        public const uint GL_LINE_WIDTH_RANGE = 0x0B22;
        public const uint GL_LINE_WIDTH_GRANULARITY = 0x0B23;
        public const uint GL_LINE_STIPPLE = 0x0B24;
        public const uint GL_LINE_STIPPLE_PATTERN = 0x0B25;
        public const uint GL_LINE_STIPPLE_REPEAT = 0x0B26;
        public const uint GL_LIST_MODE = 0x0B30;
        public const uint GL_MAX_LIST_NESTING = 0x0B31;
        public const uint GL_LIST_BASE = 0x0B32;
        public const uint GL_LIST_INDEX = 0x0B33;
        public const uint GL_POLYGON_MODE = 0x0B40;
        public const uint GL_POLYGON_SMOOTH = 0x0B41;
        public const uint GL_POLYGON_STIPPLE = 0x0B42;
        public const uint GL_EDGE_FLAG = 0x0B43;
        public const uint GL_CULL_FACE = 0x0B44;
        public const uint GL_CULL_FACE_MODE = 0x0B45;
        public const uint GL_FRONT_FACE = 0x0B46;
        public const uint GL_LIGHTING = 0x0B50;
        public const uint GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;
        public const uint GL_LIGHT_MODEL_TWO_SIDE = 0x0B52;
        public const uint GL_LIGHT_MODEL_AMBIENT = 0x0B53;
        public const uint GL_SHADE_MODEL = 0x0B54;
        public const uint GL_COLOR_MATERIAL_FACE = 0x0B55;
        public const uint GL_COLOR_MATERIAL_PARAMETER = 0x0B56;
        public const uint GL_COLOR_MATERIAL = 0x0B57;
        public const uint GL_FOG = 0x0B60;
        public const uint GL_FOG_INDEX = 0x0B61;
        public const uint GL_FOG_DENSITY = 0x0B62;
        public const uint GL_FOG_START = 0x0B63;
        public const uint GL_FOG_END = 0x0B64;
        public const uint GL_FOG_MODE = 0x0B65;
        public const uint GL_FOG_COLOR = 0x0B66;
        public const uint GL_DEPTH_RANGE = 0x0B70;
        public const uint GL_DEPTH_TEST = 0x0B71;
        public const uint GL_DEPTH_WRITEMASK = 0x0B72;
        public const uint GL_DEPTH_CLEAR_VALUE = 0x0B73;
        public const uint GL_DEPTH_FUNC = 0x0B74;
        public const uint GL_ACCUM_CLEAR_VALUE = 0x0B80;
        public const uint GL_STENCIL_TEST = 0x0B90;
        public const uint GL_STENCIL_CLEAR_VALUE = 0x0B91;
        public const uint GL_STENCIL_FUNC = 0x0B92;
        public const uint GL_STENCIL_VALUE_MASK = 0x0B93;
        public const uint GL_STENCIL_FAIL = 0x0B94;
        public const uint GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;
        public const uint GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;
        public const uint GL_STENCIL_REF = 0x0B97;
        public const uint GL_STENCIL_WRITEMASK = 0x0B98;
        public const uint GL_MATRIX_MODE = 0x0BA0;
        public const uint GL_NORMALIZE = 0x0BA1;
        public const uint GL_VIEWPORT = 0x0BA2;
        public const uint GL_MODELVIEW_STACK_DEPTH = 0x0BA3;
        public const uint GL_PROJECTION_STACK_DEPTH = 0x0BA4;
        public const uint GL_TEXTURE_STACK_DEPTH = 0x0BA5;
        public const uint GL_MODELVIEW_MATRIX = 0x0BA6;
        public const uint GL_PROJECTION_MATRIX = 0x0BA7;
        public const uint GL_TEXTURE_MATRIX = 0x0BA8;
        public const uint GL_ATTRIB_STACK_DEPTH = 0x0BB0;
        public const uint GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;
        public const uint GL_ALPHA_TEST = 0x0BC0;
        public const uint GL_ALPHA_TEST_FUNC = 0x0BC1;
        public const uint GL_ALPHA_TEST_REF = 0x0BC2;
        public const uint GL_DITHER = 0x0BD0;
        public const uint GL_BLEND_DST = 0x0BE0;
        public const uint GL_BLEND_SRC = 0x0BE1;
        public const uint GL_BLEND = 0x0BE2;
        public const uint GL_LOGIC_OP_MODE = 0x0BF0;
        public const uint GL_INDEX_LOGIC_OP = 0x0BF1;
        public const uint GL_COLOR_LOGIC_OP = 0x0BF2;
        public const uint GL_AUX_BUFFERS = 0x0C00;
        public const uint GL_DRAW_BUFFER = 0x0C01;
        public const uint GL_READ_BUFFER = 0x0C02;
        public const uint GL_SCISSOR_BOX = 0x0C10;
        public const uint GL_SCISSOR_TEST = 0x0C11;
        public const uint GL_INDEX_CLEAR_VALUE = 0x0C20;
        public const uint GL_INDEX_WRITEMASK = 0x0C21;
        public const uint GL_COLOR_CLEAR_VALUE = 0x0C22;
        public const uint GL_COLOR_WRITEMASK = 0x0C23;
        public const uint GL_INDEX_MODE = 0x0C30;
        public const uint GL_RGBA_MODE = 0x0C31;
        public const uint GL_DOUBLEBUFFER = 0x0C32;
        public const uint GL_STEREO = 0x0C33;
        public const uint GL_RENDER_MODE = 0x0C40;
        public const uint GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50;
        public const uint GL_POINT_SMOOTH_HINT = 0x0C51;
        public const uint GL_LINE_SMOOTH_HINT = 0x0C52;
        public const uint GL_POLYGON_SMOOTH_HINT = 0x0C53;
        public const uint GL_FOG_HINT = 0x0C54;
        public const uint GL_TEXTURE_GEN_S = 0x0C60;
        public const uint GL_TEXTURE_GEN_T = 0x0C61;
        public const uint GL_TEXTURE_GEN_R = 0x0C62;
        public const uint GL_TEXTURE_GEN_Q = 0x0C63;
        public const uint GL_PIXEL_MAP_I_TO_I = 0x0C70;
        public const uint GL_PIXEL_MAP_S_TO_S = 0x0C71;
        public const uint GL_PIXEL_MAP_I_TO_R = 0x0C72;
        public const uint GL_PIXEL_MAP_I_TO_G = 0x0C73;
        public const uint GL_PIXEL_MAP_I_TO_B = 0x0C74;
        public const uint GL_PIXEL_MAP_I_TO_A = 0x0C75;
        public const uint GL_PIXEL_MAP_R_TO_R = 0x0C76;
        public const uint GL_PIXEL_MAP_G_TO_G = 0x0C77;
        public const uint GL_PIXEL_MAP_B_TO_B = 0x0C78;
        public const uint GL_PIXEL_MAP_A_TO_A = 0x0C79;
        public const uint GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;
        public const uint GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;
        public const uint GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;
        public const uint GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;
        public const uint GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;
        public const uint GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;
        public const uint GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;
        public const uint GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;
        public const uint GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;
        public const uint GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;
        public const uint GL_UNPACK_SWAP_BYTES = 0x0CF0;
        public const uint GL_UNPACK_LSB_FIRST = 0x0CF1;
        public const uint GL_UNPACK_ROW_LENGTH = 0x0CF2;
        public const uint GL_UNPACK_SKIP_ROWS = 0x0CF3;
        public const uint GL_UNPACK_SKIP_PIXELS = 0x0CF4;
        public const uint GL_UNPACK_ALIGNMENT = 0x0CF5;
        public const uint GL_PACK_SWAP_BYTES = 0x0D00;
        public const uint GL_PACK_LSB_FIRST = 0x0D01;
        public const uint GL_PACK_ROW_LENGTH = 0x0D02;
        public const uint GL_PACK_SKIP_ROWS = 0x0D03;
        public const uint GL_PACK_SKIP_PIXELS = 0x0D04;
        public const uint GL_PACK_ALIGNMENT = 0x0D05;
        public const uint GL_MAP_COLOR = 0x0D10;
        public const uint GL_MAP_STENCIL = 0x0D11;
        public const uint GL_INDEX_SHIFT = 0x0D12;
        public const uint GL_INDEX_OFFSET = 0x0D13;
        public const uint GL_RED_SCALE = 0x0D14;
        public const uint GL_RED_BIAS = 0x0D15;
        public const uint GL_ZOOM_X = 0x0D16;
        public const uint GL_ZOOM_Y = 0x0D17;
        public const uint GL_GREEN_SCALE = 0x0D18;
        public const uint GL_GREEN_BIAS = 0x0D19;
        public const uint GL_BLUE_SCALE = 0x0D1A;
        public const uint GL_BLUE_BIAS = 0x0D1B;
        public const uint GL_ALPHA_SCALE = 0x0D1C;
        public const uint GL_ALPHA_BIAS = 0x0D1D;
        public const uint GL_DEPTH_SCALE = 0x0D1E;
        public const uint GL_DEPTH_BIAS = 0x0D1F;
        public const uint GL_MAX_EVAL_ORDER = 0x0D30;
        public const uint GL_MAX_LIGHTS = 0x0D31;
        public const uint GL_MAX_CLIP_PLANES = 0x0D32;
        public const uint GL_MAX_TEXTURE_SIZE = 0x0D33;
        public const uint GL_MAX_PIXEL_MAP_TABLE = 0x0D34;
        public const uint GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35;
        public const uint GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36;
        public const uint GL_MAX_NAME_STACK_DEPTH = 0x0D37;
        public const uint GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38;
        public const uint GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39;
        public const uint GL_MAX_VIEWPORT_DIMS = 0x0D3A;
        public const uint GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;
        public const uint GL_SUBPIXEL_BITS = 0x0D50;
        public const uint GL_INDEX_BITS = 0x0D51;
        public const uint GL_RED_BITS = 0x0D52;
        public const uint GL_GREEN_BITS = 0x0D53;
        public const uint GL_BLUE_BITS = 0x0D54;
        public const uint GL_ALPHA_BITS = 0x0D55;
        public const uint GL_DEPTH_BITS = 0x0D56;
        public const uint GL_STENCIL_BITS = 0x0D57;
        public const uint GL_ACCUM_RED_BITS = 0x0D58;
        public const uint GL_ACCUM_GREEN_BITS = 0x0D59;
        public const uint GL_ACCUM_BLUE_BITS = 0x0D5A;
        public const uint GL_ACCUM_ALPHA_BITS = 0x0D5B;
        public const uint GL_NAME_STACK_DEPTH = 0x0D70;
        public const uint GL_AUTO_NORMAL = 0x0D80;
        public const uint GL_MAP1_COLOR_4 = 0x0D90;
        public const uint GL_MAP1_INDEX = 0x0D91;
        public const uint GL_MAP1_NORMAL = 0x0D92;
        public const uint GL_MAP1_TEXTURE_COORD_1 = 0x0D93;
        public const uint GL_MAP1_TEXTURE_COORD_2 = 0x0D94;
        public const uint GL_MAP1_TEXTURE_COORD_3 = 0x0D95;
        public const uint GL_MAP1_TEXTURE_COORD_4 = 0x0D96;
        public const uint GL_MAP1_VERTEX_3 = 0x0D97;
        public const uint GL_MAP1_VERTEX_4 = 0x0D98;
        public const uint GL_MAP2_COLOR_4 = 0x0DB0;
        public const uint GL_MAP2_INDEX = 0x0DB1;
        public const uint GL_MAP2_NORMAL = 0x0DB2;
        public const uint GL_MAP2_TEXTURE_COORD_1 = 0x0DB3;
        public const uint GL_MAP2_TEXTURE_COORD_2 = 0x0DB4;
        public const uint GL_MAP2_TEXTURE_COORD_3 = 0x0DB5;
        public const uint GL_MAP2_TEXTURE_COORD_4 = 0x0DB6;
        public const uint GL_MAP2_VERTEX_3 = 0x0DB7;
        public const uint GL_MAP2_VERTEX_4 = 0x0DB8;
        public const uint GL_MAP1_GRID_DOMAIN = 0x0DD0;
        public const uint GL_MAP1_GRID_SEGMENTS = 0x0DD1;
        public const uint GL_MAP2_GRID_DOMAIN = 0x0DD2;
        public const uint GL_MAP2_GRID_SEGMENTS = 0x0DD3;
        public const uint GL_TEXTURE_1D = 0x0DE0;
        public const uint GL_TEXTURE_2D = 0x0DE1;
        public const uint GL_FEEDBACK_BUFFER_POINTER = 0x0DF0;
        public const uint GL_FEEDBACK_BUFFER_SIZE = 0x0DF1;
        public const uint GL_FEEDBACK_BUFFER_TYPE = 0x0DF2;
        public const uint GL_SELECTION_BUFFER_POINTER = 0x0DF3;
        public const uint GL_SELECTION_BUFFER_SIZE = 0x0DF4;

        // GetTextureParameter
        public const uint GL_TEXTURE_WIDTH = 0x1000;
        public const uint GL_TEXTURE_HEIGHT = 0x1001;
        public const uint GL_TEXTURE_INTERNAL_FORMAT = 0x1003;
        public const uint GL_TEXTURE_BORDER_COLOR = 0x1004;
        public const uint GL_TEXTURE_BORDER = 0x1005;

        // HintMode
        public const uint GL_DONT_CARE = 0x1100;
        public const uint GL_FASTEST = 0x1101;
        public const uint GL_NICEST = 0x1102;

        // LightName
        public const uint GL_LIGHT0 = 0x4000;
        public const uint GL_LIGHT1 = 0x4001;
        public const uint GL_LIGHT2 = 0x4002;
        public const uint GL_LIGHT3 = 0x4003;
        public const uint GL_LIGHT4 = 0x4004;
        public const uint GL_LIGHT5 = 0x4005;
        public const uint GL_LIGHT6 = 0x4006;
        public const uint GL_LIGHT7 = 0x4007;

        // LightParameter
        public const uint GL_AMBIENT = 0x1200;
        public const uint GL_DIFFUSE = 0x1201;
        public const uint GL_SPECULAR = 0x1202;
        public const uint GL_POSITION = 0x1203;
        public const uint GL_SPOT_DIRECTION = 0x1204;
        public const uint GL_SPOT_EXPONENT = 0x1205;
        public const uint GL_SPOT_CUTOFF = 0x1206;
        public const uint GL_CONSTANT_ATTENUATION = 0x1207;
        public const uint GL_LINEAR_ATTENUATION = 0x1208;
        public const uint GL_QUADRATIC_ATTENUATION = 0x1209;

        // ListMode
        public const uint GL_COMPILE = 0x1300;
        public const uint GL_COMPILE_AND_EXECUTE = 0x1301;

        // LogicOp
        public const uint GL_CLEAR = 0x1500;
        public const uint GL_AND = 0x1501;
        public const uint GL_AND_REVERSE = 0x1502;
        public const uint GL_COPY = 0x1503;
        public const uint GL_AND_INVERTED = 0x1504;
        public const uint GL_NOOP = 0x1505;
        public const uint GL_XOR = 0x1506;
        public const uint GL_OR = 0x1507;
        public const uint GL_NOR = 0x1508;
        public const uint GL_EQUIV = 0x1509;
        public const uint GL_INVERT = 0x150A;
        public const uint GL_OR_REVERSE = 0x150B;
        public const uint GL_COPY_INVERTED = 0x150C;
        public const uint GL_OR_INVERTED = 0x150D;
        public const uint GL_NAND = 0x150E;
        public const uint GL_SET = 0x150F;

        // MaterialParameter
        public const uint GL_EMISSION = 0x1600;
        public const uint GL_SHININESS = 0x1601;
        public const uint GL_AMBIENT_AND_DIFFUSE = 0x1602;
        public const uint GL_COLOR_INDEXES = 0x1603;

        // MatrixMode
        public const uint GL_MODELVIEW = 0x1700;
        public const uint GL_PROJECTION = 0x1701;
        public const uint GL_TEXTURE = 0x1702;

        // PixelCopyType
        public const uint GL_COLOR = 0x1800;
        public const uint GL_DEPTH = 0x1801;
        public const uint GL_STENCIL = 0x1802;

        // PixelFormat
        public const uint GL_COLOR_INDEX = 0x1900;
        public const uint GL_STENCIL_INDEX = 0x1901;
        public const uint GL_DEPTH_COMPONENT = 0x1902;
        public const uint GL_RED = 0x1903;
        public const uint GL_GREEN = 0x1904;
        public const uint GL_BLUE = 0x1905;
        public const uint GL_ALPHA = 0x1906;
        public const uint GL_RGB = 0x1907;
        public const uint GL_RGBA = 0x1908;
        public const uint GL_LUMINANCE = 0x1909;
        public const uint GL_LUMINANCE_ALPHA = 0x190A;

        // PixelType
        public const uint GL_BITMAP = 0x1A00;

        // PolygonMode
        public const uint GL_POINT = 0x1B00;
        public const uint GL_LINE = 0x1B01;
        public const uint GL_FILL = 0x1B02;

        // RenderingMode 
        public const uint GL_RENDER = 0x1C00;
        public const uint GL_FEEDBACK = 0x1C01;
        public const uint GL_SELECT = 0x1C02;

        // ShadingModel
        public const uint GL_FLAT = 0x1D00;
        public const uint GL_SMOOTH = 0x1D01;

        // StencilOp	
        public const uint GL_KEEP = 0x1E00;
        public const uint GL_REPLACE = 0x1E01;
        public const uint GL_INCR = 0x1E02;
        public const uint GL_DECR = 0x1E03;

        // StringName
        public const uint GL_VENDOR = 0x1F00;
        public const uint GL_RENDERER = 0x1F01;
        public const uint GL_VERSION = 0x1F02;
        public const uint GL_EXTENSIONS = 0x1F03;

        // TextureCoordName
        public const uint GL_S = 0x2000;
        public const uint GL_T = 0x2001;
        public const uint GL_R = 0x2002;
        public const uint GL_Q = 0x2003;

        // TextureEnvMode
        public const uint GL_MODULATE = 0x2100;
        public const uint GL_DECAL = 0x2101;

        // TextureEnvParameter
        public const uint GL_TEXTURE_ENV_MODE = 0x2200;
        public const uint GL_TEXTURE_ENV_COLOR = 0x2201;

        // TextureEnvTarget
        public const uint GL_TEXTURE_ENV = 0x2300;

        // TextureGenMode 
        public const uint GL_EYE_LINEAR = 0x2400;
        public const uint GL_OBJECT_LINEAR = 0x2401;
        public const uint GL_SPHERE_MAP = 0x2402;

        // TextureGenParameter
        public const uint GL_TEXTURE_GEN_MODE = 0x2500;
        public const uint GL_OBJECT_PLANE = 0x2501;
        public const uint GL_EYE_PLANE = 0x2502;

        // TextureMagFilter
        public const uint GL_NEAREST = 0x2600;
        public const uint GL_LINEAR = 0x2601;

        // TextureMinFilter 
        public const uint GL_NEAREST_MIPMAP_NEAREST = 0x2700;
        public const uint GL_LINEAR_MIPMAP_NEAREST = 0x2701;
        public const uint GL_NEAREST_MIPMAP_LINEAR = 0x2702;
        public const uint GL_LINEAR_MIPMAP_LINEAR = 0x2703;

        // TextureParameterName
        public const uint GL_TEXTURE_MAG_FILTER = 0x2800;
        public const uint GL_TEXTURE_MIN_FILTER = 0x2801;
        public const uint GL_TEXTURE_WRAP_S = 0x2802;
        public const uint GL_TEXTURE_WRAP_T = 0x2803;

        // TextureWrapMode
        public const uint GL_CLAMP = 0x2900;
        public const uint GL_REPEAT = 0x2901;

        // ClientAttribMask
        public const uint GL_CLIENT_PIXEL_STORE_BIT = 0x00000001;
        public const uint GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002;
        public const uint GL_CLIENT_ALL_ATTRIB_BITS = 0xffffffff;

        // Polygon Offset
        public const uint GL_POLYGON_OFFSET_FACTOR = 0x8038;
        public const uint GL_POLYGON_OFFSET_UNITS = 0x2A00;
        public const uint GL_POLYGON_OFFSET_POINT = 0x2A01;
        public const uint GL_POLYGON_OFFSET_LINE = 0x2A02;
        public const uint GL_POLYGON_OFFSET_FILL = 0x8037;

        // Texture 
        public const uint GL_ALPHA4 = 0x803B;
        public const uint GL_ALPHA8 = 0x803C;
        public const uint GL_ALPHA12 = 0x803D;
        public const uint GL_ALPHA16 = 0x803E;
        public const uint GL_LUMINANCE4 = 0x803F;
        public const uint GL_LUMINANCE8 = 0x8040;
        public const uint GL_LUMINANCE12 = 0x8041;
        public const uint GL_LUMINANCE16 = 0x8042;
        public const uint GL_LUMINANCE4_ALPHA4 = 0x8043;
        public const uint GL_LUMINANCE6_ALPHA2 = 0x8044;
        public const uint GL_LUMINANCE8_ALPHA8 = 0x8045;
        public const uint GL_LUMINANCE12_ALPHA4 = 0x8046;
        public const uint GL_LUMINANCE12_ALPHA12 = 0x8047;
        public const uint GL_LUMINANCE16_ALPHA16 = 0x8048;
        public const uint GL_INTENSITY = 0x8049;
        public const uint GL_INTENSITY4 = 0x804A;
        public const uint GL_INTENSITY8 = 0x804B;
        public const uint GL_INTENSITY12 = 0x804C;
        public const uint GL_INTENSITY16 = 0x804D;
        public const uint GL_R3_G3_B2 = 0x2A10;
        public const uint GL_RGB4 = 0x804F;
        public const uint GL_RGB5 = 0x8050;
        public const uint GL_RGB8 = 0x8051;
        public const uint GL_RGB10 = 0x8052;
        public const uint GL_RGB12 = 0x8053;
        public const uint GL_RGB16 = 0x8054;
        public const uint GL_RGBA2 = 0x8055;
        public const uint GL_RGBA4 = 0x8056;
        public const uint GL_RGB5_A1 = 0x8057;
        public const uint GL_RGBA8 = 0x8058;
        public const uint GL_RGB10_A2 = 0x8059;
        public const uint GL_RGBA12 = 0x805A;
        public const uint GL_RGBA16 = 0x805B;
        public const uint GL_TEXTURE_RED_SIZE = 0x805C;
        public const uint GL_TEXTURE_GREEN_SIZE = 0x805D;
        public const uint GL_TEXTURE_BLUE_SIZE = 0x805E;
        public const uint GL_TEXTURE_ALPHA_SIZE = 0x805F;
        public const uint GL_TEXTURE_LUMINANCE_SIZE = 0x8060;
        public const uint GL_TEXTURE_INTENSITY_SIZE = 0x8061;
        public const uint GL_PROXY_TEXTURE_1D = 0x8063;
        public const uint GL_PROXY_TEXTURE_2D = 0x8064;

        // Texture object
        public const uint GL_TEXTURE_PRIORITY = 0x8066;
        public const uint GL_TEXTURE_RESIDENT = 0x8067;
        public const uint GL_TEXTURE_BINDING_1D = 0x8068;
        public const uint GL_TEXTURE_BINDING_2D = 0x8069;

        // Vertex array
        public const uint GL_VERTEX_ARRAY = 0x8074;
        public const uint GL_NORMAL_ARRAY = 0x8075;
        public const uint GL_COLOR_ARRAY = 0x8076;
        public const uint GL_INDEX_ARRAY = 0x8077;
        public const uint GL_TEXTURE_COORD_ARRAY = 0x8078;
        public const uint GL_EDGE_FLAG_ARRAY = 0x8079;
        public const uint GL_VERTEX_ARRAY_SIZE = 0x807A;
        public const uint GL_VERTEX_ARRAY_TYPE = 0x807B;
        public const uint GL_VERTEX_ARRAY_STRIDE = 0x807C;
        public const uint GL_NORMAL_ARRAY_TYPE = 0x807E;
        public const uint GL_NORMAL_ARRAY_STRIDE = 0x807F;
        public const uint GL_COLOR_ARRAY_SIZE = 0x8081;
        public const uint GL_COLOR_ARRAY_TYPE = 0x8082;
        public const uint GL_COLOR_ARRAY_STRIDE = 0x8083;
        public const uint GL_INDEX_ARRAY_TYPE = 0x8085;
        public const uint GL_INDEX_ARRAY_STRIDE = 0x8086;
        public const uint GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088;
        public const uint GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089;
        public const uint GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A;
        public const uint GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C;
        public const uint GL_VERTEX_ARRAY_POINTER = 0x808E;
        public const uint GL_NORMAL_ARRAY_POINTER = 0x808F;
        public const uint GL_COLOR_ARRAY_POINTER = 0x8090;
        public const uint GL_INDEX_ARRAY_POINTER = 0x8091;
        public const uint GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092;
        public const uint GL_EDGE_FLAG_ARRAY_POINTER = 0x8093;
        public const uint GL_V2F = 0x2A20;
        public const uint GL_V3F = 0x2A21;
        public const uint GL_C4UB_V2F = 0x2A22;
        public const uint GL_C4UB_V3F = 0x2A23;
        public const uint GL_C3F_V3F = 0x2A24;
        public const uint GL_N3F_V3F = 0x2A25;
        public const uint GL_C4F_N3F_V3F = 0x2A26;
        public const uint GL_T2F_V3F = 0x2A27;
        public const uint GL_T4F_V4F = 0x2A28;
        public const uint GL_T2F_C4UB_V3F = 0x2A29;
        public const uint GL_T2F_C3F_V3F = 0x2A2A;
        public const uint GL_T2F_N3F_V3F = 0x2A2B;
        public const uint GL_T2F_C4F_N3F_V3F = 0x2A2C;
        public const uint GL_T4F_C4F_N3F_V4F = 0x2A2D;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 1.2 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 1.2 CONSTANTS...
        public const uint GL_RESCALE_NORMAL = 0x803A;
        public const uint GL_CLAMP_TO_EDGE = 0x812F;
        public const uint GL_MAX_ELEMENTS_VERTICES = 0x80E8;
        public const uint GL_MAX_ELEMENTS_INDICES = 0x80E9;
        public const uint GL_BGR = 0x80E0;
        public const uint GL_BGRA = 0x80E1;
        public const uint GL_UNSIGNED_BYTE_3_3_2 = 0x8032;
        public const uint GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362;
        public const uint GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
        public const uint GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364;
        public const uint GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
        public const uint GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
        public const uint GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
        public const uint GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
        public const uint GL_UNSIGNED_INT_8_8_8_8 = 0x8035;
        public const uint GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367;
        public const uint GL_UNSIGNED_INT_10_10_10_2 = 0x8036;
        public const uint GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
        public const uint GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8;
        public const uint GL_SINGLE_COLOR = 0x81F9;
        public const uint GL_SEPARATE_SPECULAR_COLOR = 0x81FA;
        public const uint GL_TEXTURE_MIN_LOD = 0x813A;
        public const uint GL_TEXTURE_MAX_LOD = 0x813B;
        public const uint GL_TEXTURE_BASE_LEVEL = 0x813C;
        public const uint GL_TEXTURE_MAX_LEVEL = 0x813D;
        public const uint GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12;
        public const uint GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
        public const uint GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
        public const uint GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
        public const uint GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
        public const uint GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
        public const uint GL_PACK_SKIP_IMAGES = 0x806B;
        public const uint GL_PACK_IMAGE_HEIGHT = 0x806C;
        public const uint GL_UNPACK_SKIP_IMAGES = 0x806D;
        public const uint GL_UNPACK_IMAGE_HEIGHT = 0x806E;
        public const uint GL_TEXTURE_3D = 0x806F;
        public const uint GL_PROXY_TEXTURE_3D = 0x8070;
        public const uint GL_TEXTURE_DEPTH = 0x8071;
        public const uint GL_TEXTURE_WRAP_R = 0x8072;
        public const uint GL_MAX_3D_TEXTURE_SIZE = 0x8073;
        public const uint GL_TEXTURE_BINDING_3D = 0x806A;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 1.2: GL_ARB_imaging CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 1.2: GL_ARB_imaging CONSTANTS...
        public const uint GL_CONSTANT_COLOR = 0x8001;
        public const uint GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
        public const uint GL_CONSTANT_ALPHA = 0x8003;
        public const uint GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
        public const uint GL_COLOR_TABLE = 0x80D0;
        public const uint GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1;
        public const uint GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;
        public const uint GL_PROXY_COLOR_TABLE = 0x80D3;
        public const uint GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;
        public const uint GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;
        public const uint GL_COLOR_TABLE_SCALE = 0x80D6;
        public const uint GL_COLOR_TABLE_BIAS = 0x80D7;
        public const uint GL_COLOR_TABLE_FORMAT = 0x80D8;
        public const uint GL_COLOR_TABLE_WIDTH = 0x80D9;
        public const uint GL_COLOR_TABLE_RED_SIZE = 0x80DA;
        public const uint GL_COLOR_TABLE_GREEN_SIZE = 0x80DB;
        public const uint GL_COLOR_TABLE_BLUE_SIZE = 0x80DC;
        public const uint GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD;
        public const uint GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;
        public const uint GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF;
        public const uint GL_CONVOLUTION_1D = 0x8010;
        public const uint GL_CONVOLUTION_2D = 0x8011;
        public const uint GL_SEPARABLE_2D = 0x8012;
        public const uint GL_CONVOLUTION_BORDER_MODE = 0x8013;
        public const uint GL_CONVOLUTION_FILTER_SCALE = 0x8014;
        public const uint GL_CONVOLUTION_FILTER_BIAS = 0x8015;
        public const uint GL_REDUCE = 0x8016;
        public const uint GL_CONVOLUTION_FORMAT = 0x8017;
        public const uint GL_CONVOLUTION_WIDTH = 0x8018;
        public const uint GL_CONVOLUTION_HEIGHT = 0x8019;
        public const uint GL_MAX_CONVOLUTION_WIDTH = 0x801A;
        public const uint GL_MAX_CONVOLUTION_HEIGHT = 0x801B;
        public const uint GL_POST_CONVOLUTION_RED_SCALE = 0x801C;
        public const uint GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D;
        public const uint GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E;
        public const uint GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F;
        public const uint GL_POST_CONVOLUTION_RED_BIAS = 0x8020;
        public const uint GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021;
        public const uint GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022;
        public const uint GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023;
        public const uint GL_CONSTANT_BORDER = 0x8151;
        public const uint GL_REPLICATE_BORDER = 0x8153;
        public const uint GL_CONVOLUTION_BORDER_COLOR = 0x8154;
        public const uint GL_COLOR_MATRIX = 0x80B1;
        public const uint GL_COLOR_MATRIX_STACK_DEPTH = 0x80B2;
        public const uint GL_MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;
        public const uint GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4;
        public const uint GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;
        public const uint GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;
        public const uint GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;
        public const uint GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8;
        public const uint GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;
        public const uint GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;
        public const uint GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;
        public const uint GL_HISTOGRAM = 0x8024;
        public const uint GL_PROXY_HISTOGRAM = 0x8025;
        public const uint GL_HISTOGRAM_WIDTH = 0x8026;
        public const uint GL_HISTOGRAM_FORMAT = 0x8027;
        public const uint GL_HISTOGRAM_RED_SIZE = 0x8028;
        public const uint GL_HISTOGRAM_GREEN_SIZE = 0x8029;
        public const uint GL_HISTOGRAM_BLUE_SIZE = 0x802A;
        public const uint GL_HISTOGRAM_ALPHA_SIZE = 0x802B;
        public const uint GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C;
        public const uint GL_HISTOGRAM_SINK = 0x802D;
        public const uint GL_MINMAX = 0x802E;
        public const uint GL_MINMAX_FORMAT = 0x802F;
        public const uint GL_MINMAX_SINK = 0x8030;
        public const uint GL_TABLE_TOO_LARGE = 0x8031;
        public const uint GL_BLEND_EQUATION = 0x8009;
        public const uint GL_MIN = 0x8007;
        public const uint GL_MAX = 0x8008;
        public const uint GL_FUNC_ADD = 0x8006;
        public const uint GL_FUNC_SUBTRACT = 0x800A;
        public const uint GL_FUNC_REVERSE_SUBTRACT = 0x800B;
        public const uint GL_BLEND_COLOR = 0x8005;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 1.3 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 1.3 CONSTANTS...
        /* multitexture */
        public const uint GL_TEXTURE0 = 0x84C0;
        public const uint GL_TEXTURE1 = 0x84C1;
        public const uint GL_TEXTURE2 = 0x84C2;
        public const uint GL_TEXTURE3 = 0x84C3;
        public const uint GL_TEXTURE4 = 0x84C4;
        public const uint GL_TEXTURE5 = 0x84C5;
        public const uint GL_TEXTURE6 = 0x84C6;
        public const uint GL_TEXTURE7 = 0x84C7;
        public const uint GL_TEXTURE8 = 0x84C8;
        public const uint GL_TEXTURE9 = 0x84C9;
        public const uint GL_TEXTURE10 = 0x84CA;
        public const uint GL_TEXTURE11 = 0x84CB;
        public const uint GL_TEXTURE12 = 0x84CC;
        public const uint GL_TEXTURE13 = 0x84CD;
        public const uint GL_TEXTURE14 = 0x84CE;
        public const uint GL_TEXTURE15 = 0x84CF;
        public const uint GL_TEXTURE16 = 0x84D0;
        public const uint GL_TEXTURE17 = 0x84D1;
        public const uint GL_TEXTURE18 = 0x84D2;
        public const uint GL_TEXTURE19 = 0x84D3;
        public const uint GL_TEXTURE20 = 0x84D4;
        public const uint GL_TEXTURE21 = 0x84D5;
        public const uint GL_TEXTURE22 = 0x84D6;
        public const uint GL_TEXTURE23 = 0x84D7;
        public const uint GL_TEXTURE24 = 0x84D8;
        public const uint GL_TEXTURE25 = 0x84D9;
        public const uint GL_TEXTURE26 = 0x84DA;
        public const uint GL_TEXTURE27 = 0x84DB;
        public const uint GL_TEXTURE28 = 0x84DC;
        public const uint GL_TEXTURE29 = 0x84DD;
        public const uint GL_TEXTURE30 = 0x84DE;
        public const uint GL_TEXTURE31 = 0x84DF;
        public const uint GL_ACTIVE_TEXTURE = 0x84E0;
        public const uint GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;
        public const uint GL_MAX_TEXTURE_UNITS = 0x84E2;
        /* texture_cube_map */
        public const uint GL_NORMAL_MAP = 0x8511;
        public const uint GL_REFLECTION_MAP = 0x8512;
        public const uint GL_TEXTURE_CUBE_MAP = 0x8513;
        public const uint GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
        public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
        public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
        public const uint GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;
        public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
        /* texture_compression */
        public const uint GL_COMPRESSED_ALPHA = 0x84E9;
        public const uint GL_COMPRESSED_LUMINANCE = 0x84EA;
        public const uint GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB;
        public const uint GL_COMPRESSED_INTENSITY = 0x84EC;
        public const uint GL_COMPRESSED_RGB = 0x84ED;
        public const uint GL_COMPRESSED_RGBA = 0x84EE;
        public const uint GL_TEXTURE_COMPRESSION_HINT = 0x84EF;
        public const uint GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
        public const uint GL_TEXTURE_COMPRESSED = 0x86A1;
        public const uint GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
        public const uint GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
        /* multisample */
        public const uint GL_MULTISAMPLE = 0x809D;
        public const uint GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
        public const uint GL_SAMPLE_ALPHA_TO_ONE = 0x809F;
        public const uint GL_SAMPLE_COVERAGE = 0x80A0;
        public const uint GL_SAMPLE_BUFFERS = 0x80A8;
        public const uint GL_SAMPLES = 0x80A9;
        public const uint GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
        public const uint GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
        public const uint GL_MULTISAMPLE_BIT = 0x20000000;
        /* transpose_matrix */
        public const uint GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;
        public const uint GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4;
        public const uint GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5;
        public const uint GL_TRANSPOSE_COLOR_MATRIX = 0x84E6;
        /* texture_env_combine */
        public const uint GL_COMBINE = 0x8570;
        public const uint GL_COMBINE_RGB = 0x8571;
        public const uint GL_COMBINE_ALPHA = 0x8572;
        public const uint GL_SOURCE0_RGB = 0x8580;
        public const uint GL_SOURCE1_RGB = 0x8581;
        public const uint GL_SOURCE2_RGB = 0x8582;
        public const uint GL_SOURCE0_ALPHA = 0x8588;
        public const uint GL_SOURCE1_ALPHA = 0x8589;
        public const uint GL_SOURCE2_ALPHA = 0x858A;
        public const uint GL_OPERAND0_RGB = 0x8590;
        public const uint GL_OPERAND1_RGB = 0x8591;
        public const uint GL_OPERAND2_RGB = 0x8592;
        public const uint GL_OPERAND0_ALPHA = 0x8598;
        public const uint GL_OPERAND1_ALPHA = 0x8599;
        public const uint GL_OPERAND2_ALPHA = 0x859A;
        public const uint GL_RGB_SCALE = 0x8573;
        public const uint GL_ADD_SIGNED = 0x8574;
        public const uint GL_INTERPOLATE = 0x8575;
        public const uint GL_SUBTRACT = 0x84E7;
        public const uint GL_CONSTANT = 0x8576;
        public const uint GL_PRIMARY_COLOR = 0x8577;
        public const uint GL_PREVIOUS = 0x8578;
        /* texture_env_dot3 */
        public const uint GL_DOT3_RGB = 0x86AE;
        public const uint GL_DOT3_RGBA = 0x86AF;
        /* texture_border_clamp */
        public const uint GL_CLAMP_TO_BORDER = 0x812D;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 1.4 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 1.4 CONSTANTS...
        public const uint GL_BLEND_DST_RGB                  = 0x80C8;
        public const uint GL_BLEND_SRC_RGB                  = 0x80C9;
        public const uint GL_BLEND_DST_ALPHA                = 0x80CA;
        public const uint GL_BLEND_SRC_ALPHA                = 0x80CB;
        public const uint GL_POINT_FADE_THRESHOLD_SIZE      = 0x8128;
        public const uint GL_DEPTH_COMPONENT16              = 0x81A5;
        public const uint GL_DEPTH_COMPONENT24              = 0x81A6;
        public const uint GL_DEPTH_COMPONENT32              = 0x81A7;
        public const uint GL_MIRRORED_REPEAT                = 0x8370;
        public const uint GL_MAX_TEXTURE_LOD_BIAS           = 0x84FD;
        public const uint GL_TEXTURE_LOD_BIAS               = 0x8501;
        public const uint GL_INCR_WRAP                      = 0x8507;
        public const uint GL_DECR_WRAP                      = 0x8508;
        public const uint GL_TEXTURE_DEPTH_SIZE             = 0x884A;
        public const uint GL_TEXTURE_COMPARE_MODE           = 0x884C;
        public const uint GL_TEXTURE_COMPARE_FUNC           = 0x884D;
        public const uint GL_POINT_SIZE_MIN                 = 0x8126;
        public const uint GL_POINT_SIZE_MAX                 = 0x8127;
        public const uint GL_POINT_DISTANCE_ATTENUATION     = 0x8129;
        public const uint GL_GENERATE_MIPMAP                = 0x8191;
        public const uint GL_GENERATE_MIPMAP_HINT           = 0x8192;
        public const uint GL_FOG_COORDINATE_SOURCE          = 0x8450;
        public const uint GL_FOG_COORDINATE                 = 0x8451;
        public const uint GL_FRAGMENT_DEPTH                 = 0x8452;
        public const uint GL_CURRENT_FOG_COORDINATE         = 0x8453;
        public const uint GL_FOG_COORDINATE_ARRAY_TYPE      = 0x8454;
        public const uint GL_FOG_COORDINATE_ARRAY_STRIDE    = 0x8455;
        public const uint GL_FOG_COORDINATE_ARRAY_POINTER   = 0x8456;
        public const uint GL_FOG_COORDINATE_ARRAY           = 0x8457;
        public const uint GL_COLOR_SUM                      = 0x8458;
        public const uint GL_CURRENT_SECONDARY_COLOR        = 0x8459;
        public const uint GL_SECONDARY_COLOR_ARRAY_SIZE     = 0x845A;
        public const uint GL_SECONDARY_COLOR_ARRAY_TYPE     = 0x845B;
        public const uint GL_SECONDARY_COLOR_ARRAY_STRIDE   = 0x845C;
        public const uint GL_SECONDARY_COLOR_ARRAY_POINTER  = 0x845D;
        public const uint GL_SECONDARY_COLOR_ARRAY          = 0x845E;
        public const uint GL_TEXTURE_FILTER_CONTROL         = 0x8500;
        public const uint GL_DEPTH_TEXTURE_MODE             = 0x884B;
        public const uint GL_COMPARE_R_TO_TEXTURE           = 0x884E;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 1.5 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 1.5 CONSTANTS...
        public const uint GL_BUFFER_SIZE                             = 0x8764;
        public const uint GL_BUFFER_USAGE                            = 0x8765;
        public const uint GL_QUERY_COUNTER_BITS                      = 0x8864;
        public const uint GL_CURRENT_QUERY                           = 0x8865;
        public const uint GL_QUERY_RESULT                            = 0x8866;
        public const uint GL_QUERY_RESULT_AVAILABLE                  = 0x8867;
        public const uint GL_ARRAY_BUFFER                            = 0x8892;
        public const uint GL_ELEMENT_ARRAY_BUFFER                    = 0x8893;
        public const uint GL_ARRAY_BUFFER_BINDING                    = 0x8894;
        public const uint GL_ELEMENT_ARRAY_BUFFER_BINDING            = 0x8895;
        public const uint GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING      = 0x889F;
        public const uint GL_READ_ONLY                               = 0x88B8;
        public const uint GL_WRITE_ONLY                              = 0x88B9;
        public const uint GL_READ_WRITE                              = 0x88BA;
        public const uint GL_BUFFER_ACCESS                           = 0x88BB;
        public const uint GL_BUFFER_MAPPED                           = 0x88BC;
        public const uint GL_BUFFER_MAP_POINTER                      = 0x88BD;
        public const uint GL_STREAM_DRAW                             = 0x88E0;
        public const uint GL_STREAM_READ                             = 0x88E1;
        public const uint GL_STREAM_COPY                             = 0x88E2;
        public const uint GL_STATIC_DRAW                             = 0x88E4;
        public const uint GL_STATIC_READ                             = 0x88E5;
        public const uint GL_STATIC_COPY                             = 0x88E6;
        public const uint GL_DYNAMIC_DRAW                            = 0x88E8;
        public const uint GL_DYNAMIC_READ                            = 0x88E9;
        public const uint GL_DYNAMIC_COPY                            = 0x88EA;
        public const uint GL_SAMPLES_PASSED                          = 0x8914;
        public const uint GL_VERTEX_ARRAY_BUFFER_BINDING             = 0x8896;
        public const uint GL_NORMAL_ARRAY_BUFFER_BINDING             = 0x8897;
        public const uint GL_COLOR_ARRAY_BUFFER_BINDING              = 0x8898;
        public const uint GL_INDEX_ARRAY_BUFFER_BINDING              = 0x8899;
        public const uint GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING      = 0x889A;
        public const uint GL_EDGE_FLAG_ARRAY_BUFFER_BINDING          = 0x889B;
        public const uint GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING    = 0x889C;
        public const uint GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING     = 0x889D;
        public const uint GL_WEIGHT_ARRAY_BUFFER_BINDING             = 0x889E;
        public const uint GL_FOG_COORD_SRC                           = 0x8450;
        public const uint GL_FOG_COORD                               = 0x8451;
        public const uint GL_CURRENT_FOG_COORD                       = 0x8453;
        public const uint GL_FOG_COORD_ARRAY_TYPE                    = 0x8454;
        public const uint GL_FOG_COORD_ARRAY_STRIDE                  = 0x8455;
        public const uint GL_FOG_COORD_ARRAY_POINTER                 = 0x8456;
        public const uint GL_FOG_COORD_ARRAY                         = 0x8457;
        public const uint GL_FOG_COORD_ARRAY_BUFFER_BINDING          = 0x889D;
        public const uint GL_SRC0_RGB                                = 0x8580;
        public const uint GL_SRC1_RGB                                = 0x8581;
        public const uint GL_SRC2_RGB                                = 0x8582;
        public const uint GL_SRC0_ALPHA                              = 0x8588;
        public const uint GL_SRC1_ALPHA                              = 0x8589;
        public const uint GL_SRC2_ALPHA                              = 0x858A;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 2.0 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 2.0 CONSTANTS...
        public const uint GL_BLEND_EQUATION_RGB               = 0x8009;
        public const uint GL_VERTEX_ATTRIB_ARRAY_ENABLED      = 0x8622;
        public const uint GL_VERTEX_ATTRIB_ARRAY_SIZE         = 0x8623;
        public const uint GL_VERTEX_ATTRIB_ARRAY_STRIDE       = 0x8624;
        public const uint GL_VERTEX_ATTRIB_ARRAY_TYPE         = 0x8625;
        public const uint GL_CURRENT_VERTEX_ATTRIB            = 0x8626;
        public const uint GL_VERTEX_PROGRAM_POINT_SIZE        = 0x8642;
        public const uint GL_VERTEX_ATTRIB_ARRAY_POINTER      = 0x8645;
        public const uint GL_STENCIL_BACK_FUNC                = 0x8800;
        public const uint GL_STENCIL_BACK_FAIL                = 0x8801;
        public const uint GL_STENCIL_BACK_PASS_DEPTH_FAIL     = 0x8802;
        public const uint GL_STENCIL_BACK_PASS_DEPTH_PASS     = 0x8803;
        public const uint GL_MAX_DRAW_BUFFERS                 = 0x8824;
        public const uint GL_DRAW_BUFFER0                     = 0x8825;
        public const uint GL_DRAW_BUFFER1                     = 0x8826;
        public const uint GL_DRAW_BUFFER2                     = 0x8827;
        public const uint GL_DRAW_BUFFER3                     = 0x8828;
        public const uint GL_DRAW_BUFFER4                     = 0x8829;
        public const uint GL_DRAW_BUFFER5                     = 0x882A;
        public const uint GL_DRAW_BUFFER6                     = 0x882B;
        public const uint GL_DRAW_BUFFER7                     = 0x882C;
        public const uint GL_DRAW_BUFFER8                     = 0x882D;
        public const uint GL_DRAW_BUFFER9                     = 0x882E;
        public const uint GL_DRAW_BUFFER10                    = 0x882F;
        public const uint GL_DRAW_BUFFER11                    = 0x8830;
        public const uint GL_DRAW_BUFFER12                    = 0x8831;
        public const uint GL_DRAW_BUFFER13                    = 0x8832;
        public const uint GL_DRAW_BUFFER14                    = 0x8833;
        public const uint GL_DRAW_BUFFER15                    = 0x8834;
        public const uint GL_BLEND_EQUATION_ALPHA             = 0x883D;
        public const uint GL_MAX_VERTEX_ATTRIBS               = 0x8869;
        public const uint GL_VERTEX_ATTRIB_ARRAY_NORMALIZED   = 0x886A;
        public const uint GL_MAX_TEXTURE_IMAGE_UNITS          = 0x8872;
        public const uint GL_FRAGMENT_SHADER                  = 0x8B30;
        public const uint GL_VERTEX_SHADER                    = 0x8B31;
        public const uint GL_MAX_FRAGMENT_UNIFORM_COMPONENTS  = 0x8B49;
        public const uint GL_MAX_VERTEX_UNIFORM_COMPONENTS    = 0x8B4A;
        public const uint GL_MAX_VARYING_FLOATS               = 0x8B4B;
        public const uint GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS   = 0x8B4C;
        public const uint GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
        public const uint GL_SHADER_TYPE                      = 0x8B4F;
        public const uint GL_FLOAT_VEC2                       = 0x8B50;
        public const uint GL_FLOAT_VEC3                       = 0x8B51;
        public const uint GL_FLOAT_VEC4                       = 0x8B52;
        public const uint GL_INT_VEC2                         = 0x8B53;
        public const uint GL_INT_VEC3                         = 0x8B54;
        public const uint GL_INT_VEC4                         = 0x8B55;
        public const uint GL_BOOL                             = 0x8B56;
        public const uint GL_BOOL_VEC2                        = 0x8B57;
        public const uint GL_BOOL_VEC3                        = 0x8B58;
        public const uint GL_BOOL_VEC4                        = 0x8B59;
        public const uint GL_FLOAT_MAT2                       = 0x8B5A;
        public const uint GL_FLOAT_MAT3                       = 0x8B5B;
        public const uint GL_FLOAT_MAT4                       = 0x8B5C;
        public const uint GL_SAMPLER_1D                       = 0x8B5D;
        public const uint GL_SAMPLER_2D                       = 0x8B5E;
        public const uint GL_SAMPLER_3D                       = 0x8B5F;
        public const uint GL_SAMPLER_CUBE                     = 0x8B60;
        public const uint GL_SAMPLER_1D_SHADOW                = 0x8B61;
        public const uint GL_SAMPLER_2D_SHADOW                = 0x8B62;
        public const uint GL_DELETE_STATUS                    = 0x8B80;
        public const uint GL_COMPILE_STATUS                   = 0x8B81;
        public const uint GL_LINK_STATUS                      = 0x8B82;
        public const uint GL_VALIDATE_STATUS                  = 0x8B83;
        public const uint GL_INFO_LOG_LENGTH                  = 0x8B84;
        public const uint GL_ATTACHED_SHADERS                 = 0x8B85;
        public const uint GL_ACTIVE_UNIFORMS                  = 0x8B86;
        public const uint GL_ACTIVE_UNIFORM_MAX_LENGTH        = 0x8B87;
        public const uint GL_SHADER_SOURCE_LENGTH             = 0x8B88;
        public const uint GL_ACTIVE_ATTRIBUTES                = 0x8B89;
        public const uint GL_ACTIVE_ATTRIBUTE_MAX_LENGTH      = 0x8B8A;
        public const uint GL_FRAGMENT_SHADER_DERIVATIVE_HINT  = 0x8B8B;
        public const uint GL_SHADING_LANGUAGE_VERSION         = 0x8B8C;
        public const uint GL_CURRENT_PROGRAM                  = 0x8B8D;
        public const uint GL_POINT_SPRITE_COORD_ORIGIN        = 0x8CA0;
        public const uint GL_LOWER_LEFT                       = 0x8CA1;
        public const uint GL_UPPER_LEFT                       = 0x8CA2;
        public const uint GL_STENCIL_BACK_REF                 = 0x8CA3;
        public const uint GL_STENCIL_BACK_VALUE_MASK          = 0x8CA4;
        public const uint GL_STENCIL_BACK_WRITEMASK           = 0x8CA5;
        public const uint GL_VERTEX_PROGRAM_TWO_SIDE          = 0x8643;
        public const uint GL_POINT_SPRITE                     = 0x8861;
        public const uint GL_COORD_REPLACE                    = 0x8862;
        public const uint GL_MAX_TEXTURE_COORDS               = 0x8871;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 2.1 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 2.1 CONSTANTS...
        public const uint GL_PIXEL_PACK_BUFFER = 0x88EB;
        public const uint GL_PIXEL_UNPACK_BUFFER = 0x88EC;
        public const uint GL_PIXEL_PACK_BUFFER_BINDING = 0x88ED;
        public const uint GL_PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
        public const uint GL_FLOAT_MAT2x3 = 0x8B65;
        public const uint GL_FLOAT_MAT2x4 = 0x8B66;
        public const uint GL_FLOAT_MAT3x2 = 0x8B67;
        public const uint GL_FLOAT_MAT3x4 = 0x8B68;
        public const uint GL_FLOAT_MAT4x2 = 0x8B69;
        public const uint GL_FLOAT_MAT4x3 = 0x8B6A;
        public const uint GL_SRGB = 0x8C40;
        public const uint GL_SRGB8 = 0x8C41;
        public const uint GL_SRGB_ALPHA = 0x8C42;
        public const uint GL_SRGB8_ALPHA8 = 0x8C43;
        public const uint GL_COMPRESSED_SRGB = 0x8C48;
        public const uint GL_COMPRESSED_SRGB_ALPHA = 0x8C49;
        public const uint GL_CURRENT_RASTER_SECONDARY_COLOR = 0x845F;
        public const uint GL_SLUMINANCE_ALPHA = 0x8C44;
        public const uint GL_SLUMINANCE8_ALPHA8 = 0x8C45;
        public const uint GL_SLUMINANCE = 0x8C46;
        public const uint GL_SLUMINANCE8 = 0x8C47;
        public const uint GL_COMPRESSED_SLUMINANCE = 0x8C4A;
        public const uint GL_COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 3.0 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 3.0 CONSTANTS...
        public const uint GL_COMPARE_REF_TO_TEXTURE                         = 0x884E;
        public const uint GL_CLIP_DISTANCE0                                 = 0x3000;
        public const uint GL_CLIP_DISTANCE1                                 = 0x3001;
        public const uint GL_CLIP_DISTANCE2                                 = 0x3002;
        public const uint GL_CLIP_DISTANCE3                                 = 0x3003;
        public const uint GL_CLIP_DISTANCE4                                 = 0x3004;
        public const uint GL_CLIP_DISTANCE5                                 = 0x3005;
        public const uint GL_CLIP_DISTANCE6                                 = 0x3006;
        public const uint GL_CLIP_DISTANCE7                                 = 0x3007;
        public const uint GL_MAX_CLIP_DISTANCES                             = 0x0D32;
        public const uint GL_MAJOR_VERSION                                  = 0x821B;
        public const uint GL_MINOR_VERSION                                  = 0x821C;
        public const uint GL_NUM_EXTENSIONS                                 = 0x821D;
        public const uint GL_CONTEXT_FLAGS                                  = 0x821E;
        public const uint GL_DEPTH_BUFFER                                   = 0x8223;
        public const uint GL_STENCIL_BUFFER                                 = 0x8224;
        public const uint GL_COMPRESSED_RED                                 = 0x8225;
        public const uint GL_COMPRESSED_RG                                  = 0x8226;
        public const uint GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT            = 0x0001;
        public const uint GL_RGBA32F                                        = 0x8814;
        public const uint GL_RGB32F                                         = 0x8815;
        public const uint GL_RGBA16F                                        = 0x881A;
        public const uint GL_RGB16F                                         = 0x881B;
        public const uint GL_VERTEX_ATTRIB_ARRAY_INTEGER                    = 0x88FD;
        public const uint GL_MAX_ARRAY_TEXTURE_LAYERS                       = 0x88FF;
        public const uint GL_MIN_PROGRAM_TEXEL_OFFSET                       = 0x8904;
        public const uint GL_MAX_PROGRAM_TEXEL_OFFSET                       = 0x8905;
        public const uint GL_CLAMP_READ_COLOR                               = 0x891C;
        public const uint GL_FIXED_ONLY                                     = 0x891D;
        public const uint GL_MAX_VARYING_COMPONENTS                         = 0x8B4B;
        public const uint GL_TEXTURE_1D_ARRAY                               = 0x8C18;
        public const uint GL_PROXY_TEXTURE_1D_ARRAY                         = 0x8C19;
        public const uint GL_TEXTURE_2D_ARRAY                               = 0x8C1A;
        public const uint GL_PROXY_TEXTURE_2D_ARRAY                         = 0x8C1B;
        public const uint GL_TEXTURE_BINDING_1D_ARRAY                       = 0x8C1C;
        public const uint GL_TEXTURE_BINDING_2D_ARRAY                       = 0x8C1D;
        public const uint GL_R11F_G11F_B10F                                 = 0x8C3A;
        public const uint GL_UNSIGNED_INT_10F_11F_11F_REV                   = 0x8C3B;
        public const uint GL_RGB9_E5                                        = 0x8C3D;
        public const uint GL_UNSIGNED_INT_5_9_9_9_REV                       = 0x8C3E;
        public const uint GL_TEXTURE_SHARED_SIZE                            = 0x8C3F;
        public const uint GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH          = 0x8C76;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_MODE                 = 0x8C7F;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS     = 0x8C80;
        public const uint GL_TRANSFORM_FEEDBACK_VARYINGS                    = 0x8C83;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_START                = 0x8C84;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_SIZE                 = 0x8C85;
        public const uint GL_PRIMITIVES_GENERATED                           = 0x8C87;
        public const uint GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN          = 0x8C88;
        public const uint GL_RASTERIZER_DISCARD                             = 0x8C89;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS  = 0x8C8A;
        public const uint GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS        = 0x8C8B;
        public const uint GL_INTERLEAVED_ATTRIBS                            = 0x8C8C;
        public const uint GL_SEPARATE_ATTRIBS                               = 0x8C8D;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER                      = 0x8C8E;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_BINDING              = 0x8C8F;
        public const uint GL_RGBA32UI                                       = 0x8D70;
        public const uint GL_RGB32UI                                        = 0x8D71;
        public const uint GL_RGBA16UI                                       = 0x8D76;
        public const uint GL_RGB16UI                                        = 0x8D77;
        public const uint GL_RGBA8UI                                        = 0x8D7C;
        public const uint GL_RGB8UI                                         = 0x8D7D;
        public const uint GL_RGBA32I                                        = 0x8D82;
        public const uint GL_RGB32I                                         = 0x8D83;
        public const uint GL_RGBA16I                                        = 0x8D88;
        public const uint GL_RGB16I                                         = 0x8D89;
        public const uint GL_RGBA8I                                         = 0x8D8E;
        public const uint GL_RGB8I                                          = 0x8D8F;
        public const uint GL_RED_INTEGER                                    = 0x8D94;
        public const uint GL_GREEN_INTEGER                                  = 0x8D95;
        public const uint GL_BLUE_INTEGER                                   = 0x8D96;
        public const uint GL_RGB_INTEGER                                    = 0x8D98;
        public const uint GL_RGBA_INTEGER                                   = 0x8D99;
        public const uint GL_BGR_INTEGER                                    = 0x8D9A;
        public const uint GL_BGRA_INTEGER                                   = 0x8D9B;
        public const uint GL_SAMPLER_1D_ARRAY                               = 0x8DC0;
        public const uint GL_SAMPLER_2D_ARRAY                               = 0x8DC1;
        public const uint GL_SAMPLER_1D_ARRAY_SHADOW                        = 0x8DC3;
        public const uint GL_SAMPLER_2D_ARRAY_SHADOW                        = 0x8DC4;
        public const uint GL_SAMPLER_CUBE_SHADOW                            = 0x8DC5;
        public const uint GL_UNSIGNED_INT_VEC2                              = 0x8DC6;
        public const uint GL_UNSIGNED_INT_VEC3                              = 0x8DC7;
        public const uint GL_UNSIGNED_INT_VEC4                              = 0x8DC8;
        public const uint GL_INT_SAMPLER_1D                                 = 0x8DC9;
        public const uint GL_INT_SAMPLER_2D                                 = 0x8DCA;
        public const uint GL_INT_SAMPLER_3D                                 = 0x8DCB;
        public const uint GL_INT_SAMPLER_CUBE                               = 0x8DCC;
        public const uint GL_INT_SAMPLER_1D_ARRAY                           = 0x8DCE;
        public const uint GL_INT_SAMPLER_2D_ARRAY                           = 0x8DCF;
        public const uint GL_UNSIGNED_INT_SAMPLER_1D                        = 0x8DD1;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D                        = 0x8DD2;
        public const uint GL_UNSIGNED_INT_SAMPLER_3D                        = 0x8DD3;
        public const uint GL_UNSIGNED_INT_SAMPLER_CUBE                      = 0x8DD4;
        public const uint GL_UNSIGNED_INT_SAMPLER_1D_ARRAY                  = 0x8DD6;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_ARRAY                  = 0x8DD7;
        public const uint GL_QUERY_WAIT                                     = 0x8E13;
        public const uint GL_QUERY_NO_WAIT                                  = 0x8E14;
        public const uint GL_QUERY_BY_REGION_WAIT                           = 0x8E15;
        public const uint GL_QUERY_BY_REGION_NO_WAIT                        = 0x8E16;
        public const uint GL_BUFFER_ACCESS_FLAGS                            = 0x911F;
        public const uint GL_BUFFER_MAP_LENGTH                              = 0x9120;
        public const uint GL_BUFFER_MAP_OFFSET                              = 0x9121;
        /* Reuse tokens from ARB_depth_buffer_float */
        public const uint GL_DEPTH_COMPONENT32F                             = 0x8CAC;
        public const uint GL_DEPTH32F_STENCIL8                              = 0x8CAD;
        public const uint GL_FLOAT_32_UNSIGNED_INT_24_8_REV                 = 0x8DAD;
        /* Reuse tokens from ARB_framebuffer_object */
        public const uint GL_INVALID_FRAMEBUFFER_OPERATION                  = 0x0506;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING          = 0x8210;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE          = 0x8211;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE                = 0x8212;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE              = 0x8213;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE               = 0x8214;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE              = 0x8215;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE              = 0x8216;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE            = 0x8217;
        public const uint GL_FRAMEBUFFER_DEFAULT                            = 0x8218;
        public const uint GL_FRAMEBUFFER_UNDEFINED                          = 0x8219;
        public const uint GL_DEPTH_STENCIL_ATTACHMENT                       = 0x821A;
        public const uint GL_MAX_RENDERBUFFER_SIZE                          = 0x84E8;
        public const uint GL_DEPTH_STENCIL                                  = 0x84F9;
        public const uint GL_UNSIGNED_INT_24_8                              = 0x84FA;
        public const uint GL_DEPTH24_STENCIL8                               = 0x88F0;
        public const uint GL_TEXTURE_STENCIL_SIZE                           = 0x88F1;
        public const uint GL_TEXTURE_RED_TYPE                               = 0x8C10;
        public const uint GL_TEXTURE_GREEN_TYPE                             = 0x8C11;
        public const uint GL_TEXTURE_BLUE_TYPE                              = 0x8C12;
        public const uint GL_TEXTURE_ALPHA_TYPE                             = 0x8C13;
        public const uint GL_TEXTURE_DEPTH_TYPE                             = 0x8C16;
        public const uint GL_UNSIGNED_NORMALIZED                            = 0x8C17;
        public const uint GL_FRAMEBUFFER_BINDING                            = 0x8CA6;
        public const uint GL_DRAW_FRAMEBUFFER_BINDING                       = GL_FRAMEBUFFER_BINDING;
        public const uint GL_RENDERBUFFER_BINDING                           = 0x8CA7;
        public const uint GL_READ_FRAMEBUFFER                               = 0x8CA8;
        public const uint GL_DRAW_FRAMEBUFFER                               = 0x8CA9;
        public const uint GL_READ_FRAMEBUFFER_BINDING                       = 0x8CAA;
        public const uint GL_RENDERBUFFER_SAMPLES                           = 0x8CAB;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE             = 0x8CD0;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME             = 0x8CD1;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL           = 0x8CD2;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE   = 0x8CD3;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER           = 0x8CD4;
        public const uint GL_FRAMEBUFFER_COMPLETE                           = 0x8CD5;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT              = 0x8CD6;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT      = 0x8CD7;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER             = 0x8CDB;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER             = 0x8CDC;
        public const uint GL_FRAMEBUFFER_UNSUPPORTED                        = 0x8CDD;
        public const uint GL_MAX_COLOR_ATTACHMENTS                          = 0x8CDF;
        public const uint GL_COLOR_ATTACHMENT0                              = 0x8CE0;
        public const uint GL_COLOR_ATTACHMENT1                              = 0x8CE1;
        public const uint GL_COLOR_ATTACHMENT2                              = 0x8CE2;
        public const uint GL_COLOR_ATTACHMENT3                              = 0x8CE3;
        public const uint GL_COLOR_ATTACHMENT4                              = 0x8CE4;
        public const uint GL_COLOR_ATTACHMENT5                              = 0x8CE5;
        public const uint GL_COLOR_ATTACHMENT6                              = 0x8CE6;
        public const uint GL_COLOR_ATTACHMENT7                              = 0x8CE7;
        public const uint GL_COLOR_ATTACHMENT8                              = 0x8CE8;
        public const uint GL_COLOR_ATTACHMENT9                              = 0x8CE9;
        public const uint GL_COLOR_ATTACHMENT10                             = 0x8CEA;
        public const uint GL_COLOR_ATTACHMENT11                             = 0x8CEB;
        public const uint GL_COLOR_ATTACHMENT12                             = 0x8CEC;
        public const uint GL_COLOR_ATTACHMENT13                             = 0x8CED;
        public const uint GL_COLOR_ATTACHMENT14                             = 0x8CEE;
        public const uint GL_COLOR_ATTACHMENT15                             = 0x8CEF;
        public const uint GL_DEPTH_ATTACHMENT                               = 0x8D00;
        public const uint GL_STENCIL_ATTACHMENT                             = 0x8D20;
        public const uint GL_FRAMEBUFFER                                    = 0x8D40;
        public const uint GL_RENDERBUFFER                                   = 0x8D41;
        public const uint GL_RENDERBUFFER_WIDTH                             = 0x8D42;
        public const uint GL_RENDERBUFFER_HEIGHT                            = 0x8D43;
        public const uint GL_RENDERBUFFER_INTERNAL_FORMAT                   = 0x8D44;
        public const uint GL_STENCIL_INDEX1                                 = 0x8D46;
        public const uint GL_STENCIL_INDEX4                                 = 0x8D47;
        public const uint GL_STENCIL_INDEX8                                 = 0x8D48;
        public const uint GL_STENCIL_INDEX16                                = 0x8D49;
        public const uint GL_RENDERBUFFER_RED_SIZE                          = 0x8D50;
        public const uint GL_RENDERBUFFER_GREEN_SIZE                        = 0x8D51;
        public const uint GL_RENDERBUFFER_BLUE_SIZE                         = 0x8D52;
        public const uint GL_RENDERBUFFER_ALPHA_SIZE                        = 0x8D53;
        public const uint GL_RENDERBUFFER_DEPTH_SIZE                        = 0x8D54;
        public const uint GL_RENDERBUFFER_STENCIL_SIZE                      = 0x8D55;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE             = 0x8D56;
        public const uint GL_MAX_SAMPLES                                    = 0x8D57;
        public const uint GL_INDEX                                          = 0x8222;
        public const uint GL_TEXTURE_LUMINANCE_TYPE                         = 0x8C14;
        public const uint GL_TEXTURE_INTENSITY_TYPE                         = 0x8C15;
        /* Reuse tokens from ARB_framebuffer_sRGB */
        public const uint GL_FRAMEBUFFER_SRGB                               = 0x8DB9;
        /* Reuse tokens from ARB_half_float_vertex */
        public const uint GL_HALF_FLOAT                                     = 0x140B;
        /* Reuse tokens from ARB_map_buffer_range */
        public const uint GL_MAP_READ_BIT                                   = 0x0001;
        public const uint GL_MAP_WRITE_BIT                                  = 0x0002;
        public const uint GL_MAP_INVALIDATE_RANGE_BIT                       = 0x0004;
        public const uint GL_MAP_INVALIDATE_BUFFER_BIT                      = 0x0008;
        public const uint GL_MAP_FLUSH_EXPLICIT_BIT                         = 0x0010;
        public const uint GL_MAP_UNSYNCHRONIZED_BIT                         = 0x0020;
        /* Reuse tokens from ARB_texture_compression_rgtc */
        public const uint GL_COMPRESSED_RED_RGTC1                           = 0x8DBB;
        public const uint GL_COMPRESSED_SIGNED_RED_RGTC1                    = 0x8DBC;
        public const uint GL_COMPRESSED_RG_RGTC2                            = 0x8DBD;
        public const uint GL_COMPRESSED_SIGNED_RG_RGTC2                     = 0x8DBE;
        /* Reuse tokens from ARB_texture_rg */
        public const uint GL_RG                                             = 0x8227;
        public const uint GL_RG_INTEGER                                     = 0x8228;
        public const uint GL_R8                                             = 0x8229;
        public const uint GL_R16                                            = 0x822A;
        public const uint GL_RG8                                            = 0x822B;
        public const uint GL_RG16                                           = 0x822C;
        public const uint GL_R16F                                           = 0x822D;
        public const uint GL_R32F                                           = 0x822E;
        public const uint GL_RG16F                                          = 0x822F;
        public const uint GL_RG32F                                          = 0x8230;
        public const uint GL_R8I                                            = 0x8231;
        public const uint GL_R8UI                                           = 0x8232;
        public const uint GL_R16I                                           = 0x8233;
        public const uint GL_R16UI                                          = 0x8234;
        public const uint GL_R32I                                           = 0x8235;
        public const uint GL_R32UI                                          = 0x8236;
        public const uint GL_RG8I                                           = 0x8237;
        public const uint GL_RG8UI                                          = 0x8238;
        public const uint GL_RG16I                                          = 0x8239;
        public const uint GL_RG16UI                                         = 0x823A;
        public const uint GL_RG32I                                          = 0x823B;
        public const uint GL_RG32UI                                         = 0x823C;
        /* Reuse tokens from ARB_vertex_array_object */
        public const uint GL_VERTEX_ARRAY_BINDING                           = 0x85B5;
        /* GL_VERSION_3_0_DEPRECATED */
        public const uint GL_CLAMP_VERTEX_COLOR                             = 0x891A;
        public const uint GL_CLAMP_FRAGMENT_COLOR                           = 0x891B;
        public const uint GL_ALPHA_INTEGER                                  = 0x8D97;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 3.1 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 3.1 CONSTANTS...
        public const uint GL_SAMPLER_2D_RECT                                = 0x8B63;
        public const uint GL_SAMPLER_2D_RECT_SHADOW                         = 0x8B64;
        public const uint GL_SAMPLER_BUFFER                                 = 0x8DC2;
        public const uint GL_INT_SAMPLER_2D_RECT                            = 0x8DCD;
        public const uint GL_INT_SAMPLER_BUFFER                             = 0x8DD0;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_RECT                   = 0x8DD5;
        public const uint GL_UNSIGNED_INT_SAMPLER_BUFFER                    = 0x8DD8;
        public const uint GL_TEXTURE_BUFFER                                 = 0x8C2A;
        public const uint GL_MAX_TEXTURE_BUFFER_SIZE                        = 0x8C2B;
        public const uint GL_TEXTURE_BINDING_BUFFER                         = 0x8C2C;
        public const uint GL_TEXTURE_BUFFER_DATA_STORE_BINDING              = 0x8C2D;
        public const uint GL_TEXTURE_BUFFER_FORMAT                          = 0x8C2E;
        public const uint GL_TEXTURE_RECTANGLE                              = 0x84F5;
        public const uint GL_TEXTURE_BINDING_RECTANGLE                      = 0x84F6;
        public const uint GL_PROXY_TEXTURE_RECTANGLE                        = 0x84F7;
        public const uint GL_MAX_RECTANGLE_TEXTURE_SIZE                     = 0x84F8;
        public const uint GL_RED_SNORM                                      = 0x8F90;
        public const uint GL_RG_SNORM                                       = 0x8F91;
        public const uint GL_RGB_SNORM                                      = 0x8F92;
        public const uint GL_RGBA_SNORM                                     = 0x8F93;
        public const uint GL_R8_SNORM                                       = 0x8F94;
        public const uint GL_RG8_SNORM                                      = 0x8F95;
        public const uint GL_RGB8_SNORM                                     = 0x8F96;
        public const uint GL_RGBA8_SNORM                                    = 0x8F97;
        public const uint GL_R16_SNORM                                      = 0x8F98;
        public const uint GL_RG16_SNORM                                     = 0x8F99;
        public const uint GL_RGB16_SNORM                                    = 0x8F9A;
        public const uint GL_RGBA16_SNORM                                   = 0x8F9B;
        public const uint GL_SIGNED_NORMALIZED                              = 0x8F9C;
        public const uint GL_PRIMITIVE_RESTART                              = 0x8F9D;
        public const uint GL_PRIMITIVE_RESTART_INDEX                        = 0x8F9E;
        /* Reuse tokens from ARB_copy_buffer */
        public const uint GL_COPY_READ_BUFFER                               = 0x8F36;
        public const uint GL_COPY_WRITE_BUFFER                              = 0x8F37;
        /* Reuse tokens from ARB_draw_instanced (none) */
        /* Reuse tokens from ARB_uniform_buffer_object */
        public const uint GL_UNIFORM_BUFFER                                 = 0x8A11;
        public const uint GL_UNIFORM_BUFFER_BINDING                         = 0x8A28;
        public const uint GL_UNIFORM_BUFFER_START                           = 0x8A29;
        public const uint GL_UNIFORM_BUFFER_SIZE                            = 0x8A2A;
        public const uint GL_MAX_VERTEX_UNIFORM_BLOCKS                      = 0x8A2B;
        public const uint GL_MAX_GEOMETRY_UNIFORM_BLOCKS                    = 0x8A2C;
        public const uint GL_MAX_FRAGMENT_UNIFORM_BLOCKS                    = 0x8A2D;
        public const uint GL_MAX_COMBINED_UNIFORM_BLOCKS                    = 0x8A2E;
        public const uint GL_MAX_UNIFORM_BUFFER_BINDINGS                    = 0x8A2F;
        public const uint GL_MAX_UNIFORM_BLOCK_SIZE                         = 0x8A30;
        public const uint GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS         = 0x8A31;
        public const uint GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS       = 0x8A32;
        public const uint GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS       = 0x8A33;
        public const uint GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT                = 0x8A34;
        public const uint GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH           = 0x8A35;
        public const uint GL_ACTIVE_UNIFORM_BLOCKS                          = 0x8A36;
        public const uint GL_UNIFORM_TYPE                                   = 0x8A37;
        public const uint GL_UNIFORM_SIZE                                   = 0x8A38;
        public const uint GL_UNIFORM_NAME_LENGTH                            = 0x8A39;
        public const uint GL_UNIFORM_BLOCK_INDEX                            = 0x8A3A;
        public const uint GL_UNIFORM_OFFSET                                 = 0x8A3B;
        public const uint GL_UNIFORM_ARRAY_STRIDE                           = 0x8A3C;
        public const uint GL_UNIFORM_MATRIX_STRIDE                          = 0x8A3D;
        public const uint GL_UNIFORM_IS_ROW_MAJOR                           = 0x8A3E;
        public const uint GL_UNIFORM_BLOCK_BINDING                          = 0x8A3F;
        public const uint GL_UNIFORM_BLOCK_DATA_SIZE                        = 0x8A40;
        public const uint GL_UNIFORM_BLOCK_NAME_LENGTH                      = 0x8A41;
        public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS                  = 0x8A42;
        public const uint GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES           = 0x8A43;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER      = 0x8A44;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER    = 0x8A45;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER    = 0x8A46;
        public const uint GL_INVALID_INDEX                                  = 0xFFFFFFFF;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 3.2 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 3.2 CONSTANTS...
        public const uint GL_CONTEXT_CORE_PROFILE_BIT                   = 0x00000001;
        public const uint GL_CONTEXT_COMPATIBILITY_PROFILE_BIT          = 0x00000002;
        public const uint GL_LINES_ADJACENCY                            = 0x000A;
        public const uint GL_LINE_STRIP_ADJACENCY                       = 0x000B;
        public const uint GL_TRIANGLES_ADJACENCY                        = 0x000C;
        public const uint GL_TRIANGLE_STRIP_ADJACENCY                   = 0x000D;
        public const uint GL_PROGRAM_POINT_SIZE                         = 0x8642;
        public const uint GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS           = 0x8C29;
        public const uint GL_FRAMEBUFFER_ATTACHMENT_LAYERED             = 0x8DA7;
        public const uint GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS       = 0x8DA8;
        public const uint GL_GEOMETRY_SHADER                            = 0x8DD9;
        public const uint GL_GEOMETRY_VERTICES_OUT                      = 0x8916;
        public const uint GL_GEOMETRY_INPUT_TYPE                        = 0x8917;
        public const uint GL_GEOMETRY_OUTPUT_TYPE                       = 0x8918;
        public const uint GL_MAX_GEOMETRY_UNIFORM_COMPONENTS            = 0x8DDF;
        public const uint GL_MAX_GEOMETRY_OUTPUT_VERTICES               = 0x8DE0;
        public const uint GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS       = 0x8DE1;
        public const uint GL_MAX_VERTEX_OUTPUT_COMPONENTS               = 0x9122;
        public const uint GL_MAX_GEOMETRY_INPUT_COMPONENTS              = 0x9123;
        public const uint GL_MAX_GEOMETRY_OUTPUT_COMPONENTS             = 0x9124;
        public const uint GL_MAX_FRAGMENT_INPUT_COMPONENTS              = 0x9125;
        public const uint GL_CONTEXT_PROFILE_MASK                       = 0x9126;
        /* reuse GL_MAX_VARYING_COMPONENTS */
        /* reuse GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER */
        /* Reuse tokens from ARB_depth_clamp */
        public const uint GL_DEPTH_CLAMP                                = 0x864F;
        /* Reuse tokens from ARB_draw_elements_base_vertex (none) */
        /* Reuse tokens from ARB_fragment_coord_conventions (none) */
        /* Reuse tokens from ARB_provoking_vertex */
        public const uint GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION   = 0x8E4C;
        public const uint GL_FIRST_VERTEX_CONVENTION                    = 0x8E4D;
        public const uint GL_LAST_VERTEX_CONVENTION                     = 0x8E4E;
        public const uint GL_PROVOKING_VERTEX                           = 0x8E4F;
        /* Reuse tokens from ARB_seamless_cube_map */
        public const uint GL_TEXTURE_CUBE_MAP_SEAMLESS                  = 0x884F;
        /* Reuse tokens from ARB_sync */
        public const uint GL_MAX_SERVER_WAIT_TIMEOUT                    = 0x9111;
        public const uint GL_OBJECT_TYPE                                = 0x9112;
        public const uint GL_SYNC_CONDITION                             = 0x9113;
        public const uint GL_SYNC_STATUS                                = 0x9114;
        public const uint GL_SYNC_FLAGS                                 = 0x9115;
        public const uint GL_SYNC_FENCE                                 = 0x9116;
        public const uint GL_SYNC_GPU_COMMANDS_COMPLETE                 = 0x9117;
        public const uint GL_UNSIGNALED                                 = 0x9118;
        public const uint GL_SIGNALED                                   = 0x9119;
        public const uint GL_ALREADY_SIGNALED                           = 0x911A;
        public const uint GL_TIMEOUT_EXPIRED                            = 0x911B;
        public const uint GL_CONDITION_SATISFIED                        = 0x911C;
        public const uint GL_WAIT_FAILED                                = 0x911D;
        public const uint GL_SYNC_FLUSH_COMMANDS_BIT                    = 0x00000001;
        public const ulong GL_TIMEOUT_IGNORED                           = 0xFFFFFFFFFFFFFFFF;
        /* Reuse tokens from ARB_texture_multisample */
        public const uint GL_SAMPLE_POSITION                            = 0x8E50;
        public const uint GL_SAMPLE_MASK                                = 0x8E51;
        public const uint GL_SAMPLE_MASK_VALUE                          = 0x8E52;
        public const uint GL_MAX_SAMPLE_MASK_WORDS                      = 0x8E59;
        public const uint GL_TEXTURE_2D_MULTISAMPLE                     = 0x9100;
        public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE               = 0x9101;
        public const uint GL_TEXTURE_2D_MULTISAMPLE_ARRAY               = 0x9102;
        public const uint GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY         = 0x9103;
        public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE             = 0x9104;
        public const uint GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY       = 0x9105;
        public const uint GL_TEXTURE_SAMPLES                            = 0x9106;
        public const uint GL_TEXTURE_FIXED_SAMPLE_LOCATIONS             = 0x9107;
        public const uint GL_SAMPLER_2D_MULTISAMPLE                     = 0x9108;
        public const uint GL_INT_SAMPLER_2D_MULTISAMPLE                 = 0x9109;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE        = 0x910A;
        public const uint GL_SAMPLER_2D_MULTISAMPLE_ARRAY               = 0x910B;
        public const uint GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY           = 0x910C;
        public const uint GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY  = 0x910D;
        public const uint GL_MAX_COLOR_TEXTURE_SAMPLES                  = 0x910E;
        public const uint GL_MAX_DEPTH_TEXTURE_SAMPLES                  = 0x910F;
        public const uint GL_MAX_INTEGER_SAMPLES                        = 0x9110;
        /* Don't need to reuse tokens from ARB_vertex_array_bgra since they're already in 1.2 core */
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 3.3 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 3.3 CONSTANTS...
        public const uint GL_VERTEX_ATTRIB_ARRAY_DIVISOR    = 0x88FE;
        /* Reuse tokens from ARB_blend_func_extended */
        public const uint GL_SRC1_COLOR                     = 0x88F9;
        /* reuse GL_SRC1_ALPHA (defined in OpenGL v1.5) */
        public const uint GL_ONE_MINUS_SRC1_COLOR           = 0x88FA;
        public const uint GL_ONE_MINUS_SRC1_ALPHA           = 0x88FB;
        public const uint GL_MAX_DUAL_SOURCE_DRAW_BUFFERS   = 0x88FC;
        /* Reuse tokens from ARB_explicit_attrib_location (none) */
        /* Reuse tokens from ARB_occlusion_query2 */
        public const uint GL_ANY_SAMPLES_PASSED             = 0x8C2F;
        /* Reuse tokens from ARB_sampler_objects */
        public const uint GL_SAMPLER_BINDING                = 0x8919;
        /* Reuse tokens from ARB_shader_bit_encoding (none) */
        /* Reuse tokens from ARB_texture_rgb10_a2ui */
        public const uint GL_RGB10_A2UI                     = 0x906F;
        /* Reuse tokens from ARB_texture_swizzle */
        public const uint GL_TEXTURE_SWIZZLE_R              = 0x8E42;
        public const uint GL_TEXTURE_SWIZZLE_G              = 0x8E43;
        public const uint GL_TEXTURE_SWIZZLE_B              = 0x8E44;
        public const uint GL_TEXTURE_SWIZZLE_A              = 0x8E45;
        public const uint GL_TEXTURE_SWIZZLE_RGBA           = 0x8E46;
        /* Reuse tokens from ARB_timer_query */
        public const uint GL_TIME_ELAPSED                   = 0x88BF;
        public const uint GL_TIMESTAMP                      = 0x8E28;
        /* Reuse tokens from ARB_vertex_type_2_10_10_10_rev */
        /* reuse GL_UNSIGNED_INT_2_10_10_10_REV (defined in OPENGL v1.2) */
        public const uint GL_INT_2_10_10_10_REV             = 0x8D9F;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 4.0 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 4.0 CONSTANTS...
        public const uint GL_SAMPLE_SHADING                                         = 0x8C36;
        public const uint GL_MIN_SAMPLE_SHADING_VALUE                               = 0x8C37;
        public const uint GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET                      = 0x8E5E;
        public const uint GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET                      = 0x8E5F;
        public const uint GL_TEXTURE_CUBE_MAP_ARRAY                                 = 0x9009;
        public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARRAY                         = 0x900A;
        public const uint GL_PROXY_TEXTURE_CUBE_MAP_ARRAY                           = 0x900B;
        public const uint GL_SAMPLER_CUBE_MAP_ARRAY                                 = 0x900C;
        public const uint GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW                          = 0x900D;
        public const uint GL_INT_SAMPLER_CUBE_MAP_ARRAY                             = 0x900E;
        public const uint GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY                    = 0x900F;
        /* Reuse tokens from ARB_texture_query_lod (none) */
        /* Reuse tokens from ARB_draw_buffers_blend (none) */
        /* Reuse tokens from ARB_draw_indirect */
        public const uint GL_DRAW_INDIRECT_BUFFER                                   = 0x8F3F;
        public const uint GL_DRAW_INDIRECT_BUFFER_BINDING                           = 0x8F43;
        /* Reuse tokens from ARB_gpu_shader5 */
        public const uint GL_GEOMETRY_SHADER_INVOCATIONS                            = 0x887F;
        public const uint GL_MAX_GEOMETRY_SHADER_INVOCATIONS                        = 0x8E5A;
        public const uint GL_MIN_FRAGMENT_INTERPOLATION_OFFSET                      = 0x8E5B;
        public const uint GL_MAX_FRAGMENT_INTERPOLATION_OFFSET                      = 0x8E5C;
        public const uint GL_FRAGMENT_INTERPOLATION_OFFSET_BITS                     = 0x8E5D;
        /* Reuse tokens from ARB_gpu_shader_fp64 */
        /* reuse GL_DOUBLE (defined in OPENGL v1.1) */
        public const uint GL_DOUBLE_VEC2                                            = 0x8FFC;
        public const uint GL_DOUBLE_VEC3                                            = 0x8FFD;
        public const uint GL_DOUBLE_VEC4                                            = 0x8FFE;
        public const uint GL_DOUBLE_MAT2                                            = 0x8F46;
        public const uint GL_DOUBLE_MAT3                                            = 0x8F47;
        public const uint GL_DOUBLE_MAT4                                            = 0x8F48;
        public const uint GL_DOUBLE_MAT2x3                                          = 0x8F49;
        public const uint GL_DOUBLE_MAT2x4                                          = 0x8F4A;
        public const uint GL_DOUBLE_MAT3x2                                          = 0x8F4B;
        public const uint GL_DOUBLE_MAT3x4                                          = 0x8F4C;
        public const uint GL_DOUBLE_MAT4x2                                          = 0x8F4D;
        public const uint GL_DOUBLE_MAT4x3                                          = 0x8F4E;
        /* Reuse tokens from ARB_shader_subroutine */
        public const uint GL_ACTIVE_SUBROUTINES                                     = 0x8DE5;
        public const uint GL_ACTIVE_SUBROUTINE_UNIFORMS                             = 0x8DE6;
        public const uint GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS                    = 0x8E47;
        public const uint GL_ACTIVE_SUBROUTINE_MAX_LENGTH                           = 0x8E48;
        public const uint GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH                   = 0x8E49;
        public const uint GL_MAX_SUBROUTINES                                        = 0x8DE7;
        public const uint GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS                       = 0x8DE8;
        public const uint GL_NUM_COMPATIBLE_SUBROUTINES                             = 0x8E4A;
        public const uint GL_COMPATIBLE_SUBROUTINES                                 = 0x8E4B;
        /* reuse GL_UNIFORM_SIZE (defined in OpenGL 3.1) */
        /* reuse GL_UNIFORM_NAME_LENGTH (defined in OpenGL 3.1) */
        /* Reuse tokens from ARB_tessellation_shader */
        public const uint GL_PATCHES                                                = 0x000E;
        public const uint GL_PATCH_VERTICES                                         = 0x8E72;
        public const uint GL_PATCH_DEFAULT_INNER_LEVEL                              = 0x8E73;
        public const uint GL_PATCH_DEFAULT_OUTER_LEVEL                              = 0x8E74;
        public const uint GL_TESS_CONTROL_OUTPUT_VERTICES                           = 0x8E75;
        public const uint GL_TESS_GEN_MODE                                          = 0x8E76;
        public const uint GL_TESS_GEN_SPACING                                       = 0x8E77;
        public const uint GL_TESS_GEN_VERTEX_ORDER                                  = 0x8E78;
        public const uint GL_TESS_GEN_POINT_MODE                                    = 0x8E79;
        /* reuse GL_TRIANGLES (defined in OpenGL v1.1) */
        /* reuse GL_QUADS (defined in OpenGL v1.1) */
        public const uint GL_ISOLINES                                               = 0x8E7A;
        /* reuse GL_EQUAL (defined in OpenGL v1.1) */
        public const uint GL_FRACTIONAL_ODD                                         = 0x8E7B;
        public const uint GL_FRACTIONAL_EVEN                                        = 0x8E7C;
        /* reuse GL_CCW (defined in OpenGL v1.1) */
        /* reuse GL_CW (defined in OpenGL v1.1) */
        public const uint GL_MAX_PATCH_VERTICES                                     = 0x8E7D;
        public const uint GL_MAX_TESS_GEN_LEVEL                                     = 0x8E7E;
        public const uint GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS                    = 0x8E7F;
        public const uint GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS                 = 0x8E80;
        public const uint GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS                   = 0x8E81;
        public const uint GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS                = 0x8E82;
        public const uint GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS                     = 0x8E83;
        public const uint GL_MAX_TESS_PATCH_COMPONENTS                              = 0x8E84;
        public const uint GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS               = 0x8E85;
        public const uint GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS                  = 0x8E86;
        public const uint GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS                        = 0x8E89;
        public const uint GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS                     = 0x8E8A;
        public const uint GL_MAX_TESS_CONTROL_INPUT_COMPONENTS                      = 0x886C;
        public const uint GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS                   = 0x886D;
        public const uint GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS           = 0x8E1E;
        public const uint GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS        = 0x8E1F;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER        = 0x84F0;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER     = 0x84F1;
        public const uint GL_TESS_EVALUATION_SHADER                                 = 0x8E87;
        public const uint GL_TESS_CONTROL_SHADER                                    = 0x8E88;
        /* Reuse tokens from ARB_texture_buffer_object_rgb32 (none) */
        /* Reuse tokens from ARB_transform_feedback2 */
        public const uint GL_TRANSFORM_FEEDBACK                                     = 0x8E22;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED                       = 0x8E23;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE                       = 0x8E24;
        public const uint GL_TRANSFORM_FEEDBACK_BINDING                             = 0x8E25;
        /* Reuse tokens from ARB_transform_feedback3 */
        public const uint GL_MAX_TRANSFORM_FEEDBACK_BUFFERS                         = 0x8E70;
        public const uint GL_MAX_VERTEX_STREAMS                                     = 0x8E71;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 4.1 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 4.1 CONSTANTS...
        /* Reuse tokens from ARB_ES2_compatibility */
        public const uint GL_FIXED                              = 0x140C;
        public const uint GL_IMPLEMENTATION_COLOR_READ_TYPE     = 0x8B9A;
        public const uint GL_IMPLEMENTATION_COLOR_READ_FORMAT   = 0x8B9B;
        public const uint GL_LOW_FLOAT                          = 0x8DF0;
        public const uint GL_MEDIUM_FLOAT                       = 0x8DF1;
        public const uint GL_HIGH_FLOAT                         = 0x8DF2;
        public const uint GL_LOW_INT                            = 0x8DF3;
        public const uint GL_MEDIUM_INT                         = 0x8DF4;
        public const uint GL_HIGH_INT                           = 0x8DF5;
        public const uint GL_SHADER_COMPILER                    = 0x8DFA;
        public const uint GL_NUM_SHADER_BINARY_FORMATS          = 0x8DF9;
        public const uint GL_MAX_VERTEX_UNIFORM_VECTORS         = 0x8DFB;
        public const uint GL_MAX_VARYING_VECTORS                = 0x8DFC;
        public const uint GL_MAX_FRAGMENT_UNIFORM_VECTORS       = 0x8DFD;
        /* Reuse tokens from ARB_get_program_binary */
        public const uint GL_PROGRAM_BINARY_RETRIEVABLE_HINT    = 0x8257;
        public const uint GL_PROGRAM_BINARY_LENGTH              = 0x8741;
        public const uint GL_NUM_PROGRAM_BINARY_FORMATS         = 0x87FE;
        public const uint GL_PROGRAM_BINARY_FORMATS             = 0x87FF;
        /* Reuse tokens from ARB_separate_shader_objects */
        public const uint GL_VERTEX_SHADER_BIT                  = 0x00000001;
        public const uint GL_FRAGMENT_SHADER_BIT                = 0x00000002;
        public const uint GL_GEOMETRY_SHADER_BIT                = 0x00000004;
        public const uint GL_TESS_CONTROL_SHADER_BIT            = 0x00000008;
        public const uint GL_TESS_EVALUATION_SHADER_BIT         = 0x00000010;
        public const uint GL_ALL_SHADER_BITS                    = 0xFFFFFFFF;
        public const uint GL_PROGRAM_SEPARABLE                  = 0x8258;
        public const uint GL_ACTIVE_PROGRAM                     = 0x8259;
        public const uint GL_PROGRAM_PIPELINE_BINDING           = 0x825A;
        /* Reuse tokens from ARB_shader_precision (none) */
        /* Reuse tokens from ARB_vertex_attrib_64bit - all are in GL 3.0 and 4.0 already */
        /* Reuse tokens from ARB_viewport_array */
        /* reuse GL_SCISSOR_BOX (defined in OpenGL 1.1) */
        /* reuse GL_VIEWPORT (defined in OpenGL 1.1) */
        /* reuse GL_DEPTH_RANGE (defined in OpenGL 1.1) */
        /* reuse GL_SCISSOR_TEST (defined in OpenGL 1.1) */
        public const uint GL_MAX_VIEWPORTS                      = 0x825B;
        public const uint GL_VIEWPORT_SUBPIXEL_BITS             = 0x825C;
        public const uint GL_VIEWPORT_BOUNDS_RANGE              = 0x825D;
        public const uint GL_LAYER_PROVOKING_VERTEX             = 0x825E;
        public const uint GL_VIEWPORT_INDEX_PROVOKING_VERTEX    = 0x825F;
        public const uint GL_UNDEFINED_VERTEX                   = 0x8260;
        /* reuse GL_FIRST_VERTEX_CONVENTION (defined in OpenGL 3.2) */
        /* reuse GL_LAST_VERTEX_CONVENTION (defined in OpenGL 3.2) */
        /* reuse GL_PROVOKING_VERTEX (defined in OpenGL 3.2) */
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 4.2 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 4.2 CONSTANTS...
        /* Reuse tokens from ARB_base_instance (none) */
        /* Reuse tokens from ARB_shading_language_420pack (none) */
        /* Reuse tokens from ARB_transform_feedback_instanced (none) */
        /* Reuse tokens from ARB_compressed_texture_pixel_storage */
        public const uint GL_UNPACK_COMPRESSED_BLOCK_WIDTH                                  = 0x9127;
        public const uint GL_UNPACK_COMPRESSED_BLOCK_HEIGHT                                 = 0x9128;
        public const uint GL_UNPACK_COMPRESSED_BLOCK_DEPTH                                  = 0x9129;
        public const uint GL_UNPACK_COMPRESSED_BLOCK_SIZE                                   = 0x912A;
        public const uint GL_PACK_COMPRESSED_BLOCK_WIDTH                                    = 0x912B;
        public const uint GL_PACK_COMPRESSED_BLOCK_HEIGHT                                   = 0x912C;
        public const uint GL_PACK_COMPRESSED_BLOCK_DEPTH                                    = 0x912D;
        public const uint GL_PACK_COMPRESSED_BLOCK_SIZE                                     = 0x912E;
        /* Reuse tokens from ARB_conservative_depth (none) */
        /* Reuse tokens from ARB_internalformat_query */
        public const uint GL_NUM_SAMPLE_COUNTS                                              = 0x9380;
        /* Reuse tokens from ARB_map_buffer_alignment */
        public const uint GL_MIN_MAP_BUFFER_ALIGNMENT                                       = 0x90BC;
        /* Reuse tokens from ARB_shader_atomic_counters */
        public const uint GL_ATOMIC_COUNTER_BUFFER                                          = 0x92C0;
        public const uint GL_ATOMIC_COUNTER_BUFFER_BINDING                                  = 0x92C1;
        public const uint GL_ATOMIC_COUNTER_BUFFER_START                                    = 0x92C2;
        public const uint GL_ATOMIC_COUNTER_BUFFER_SIZE                                     = 0x92C3;
        public const uint GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE                                = 0x92C4;
        public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS                   = 0x92C5;
        public const uint GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES            = 0x92C6;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER              = 0x92C7;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER        = 0x92C8;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER     = 0x92C9;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER            = 0x92CA;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER            = 0x92CB;
        public const uint GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS                              = 0x92CC;
        public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS                        = 0x92CD;
        public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS                     = 0x92CE;
        public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS                            = 0x92CF;
        public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS                            = 0x92D0;
        public const uint GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS                            = 0x92D1;
        public const uint GL_MAX_VERTEX_ATOMIC_COUNTERS                                     = 0x92D2;
        public const uint GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS                               = 0x92D3;
        public const uint GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS                            = 0x92D4;
        public const uint GL_MAX_GEOMETRY_ATOMIC_COUNTERS                                   = 0x92D5;
        public const uint GL_MAX_FRAGMENT_ATOMIC_COUNTERS                                   = 0x92D6;
        public const uint GL_MAX_COMBINED_ATOMIC_COUNTERS                                   = 0x92D7;
        public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE                                 = 0x92D8;
        public const uint GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS                             = 0x92DC;
        public const uint GL_ACTIVE_ATOMIC_COUNTER_BUFFERS                                  = 0x92D9;
        public const uint GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX                            = 0x92DA;
        public const uint GL_UNSIGNED_INT_ATOMIC_COUNTER                                    = 0x92DB;
        /* Reuse tokens from ARB_shader_image_load_store */
        public const uint GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT                                = 0x00000001;
        public const uint GL_ELEMENT_ARRAY_BARRIER_BIT                                      = 0x00000002;
        public const uint GL_UNIFORM_BARRIER_BIT                                            = 0x00000004;
        public const uint GL_TEXTURE_FETCH_BARRIER_BIT                                      = 0x00000008;
        public const uint GL_SHADER_IMAGE_ACCESS_BARRIER_BIT                                = 0x00000020;
        public const uint GL_COMMAND_BARRIER_BIT                                            = 0x00000040;
        public const uint GL_PIXEL_BUFFER_BARRIER_BIT                                       = 0x00000080;
        public const uint GL_TEXTURE_UPDATE_BARRIER_BIT                                     = 0x00000100;
        public const uint GL_BUFFER_UPDATE_BARRIER_BIT                                      = 0x00000200;
        public const uint GL_FRAMEBUFFER_BARRIER_BIT                                        = 0x00000400;
        public const uint GL_TRANSFORM_FEEDBACK_BARRIER_BIT                                 = 0x00000800;
        public const uint GL_ATOMIC_COUNTER_BARRIER_BIT                                     = 0x00001000;
        public const uint GL_ALL_BARRIER_BITS                                               = 0xFFFFFFFF;
        public const uint GL_MAX_IMAGE_UNITS                                                = 0x8F38;
        public const uint GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS                  = 0x8F39;
        public const uint GL_IMAGE_BINDING_NAME                                             = 0x8F3A;
        public const uint GL_IMAGE_BINDING_LEVEL                                            = 0x8F3B;
        public const uint GL_IMAGE_BINDING_LAYERED                                          = 0x8F3C;
        public const uint GL_IMAGE_BINDING_LAYER                                            = 0x8F3D;
        public const uint GL_IMAGE_BINDING_ACCESS                                           = 0x8F3E;
        public const uint GL_IMAGE_1D                                                       = 0x904C;
        public const uint GL_IMAGE_2D                                                       = 0x904D;
        public const uint GL_IMAGE_3D                                                       = 0x904E;
        public const uint GL_IMAGE_2D_RECT                                                  = 0x904F;
        public const uint GL_IMAGE_CUBE                                                     = 0x9050;
        public const uint GL_IMAGE_BUFFER                                                   = 0x9051;
        public const uint GL_IMAGE_1D_ARRAY                                                 = 0x9052;
        public const uint GL_IMAGE_2D_ARRAY                                                 = 0x9053;
        public const uint GL_IMAGE_CUBE_MAP_ARRAY                                           = 0x9054;
        public const uint GL_IMAGE_2D_MULTISAMPLE                                           = 0x9055;
        public const uint GL_IMAGE_2D_MULTISAMPLE_ARRAY                                     = 0x9056;
        public const uint GL_INT_IMAGE_1D                                                   = 0x9057;
        public const uint GL_INT_IMAGE_2D                                                   = 0x9058;
        public const uint GL_INT_IMAGE_3D                                                   = 0x9059;
        public const uint GL_INT_IMAGE_2D_RECT                                              = 0x905A;
        public const uint GL_INT_IMAGE_CUBE                                                 = 0x905B;
        public const uint GL_INT_IMAGE_BUFFER                                               = 0x905C;
        public const uint GL_INT_IMAGE_1D_ARRAY                                             = 0x905D;
        public const uint GL_INT_IMAGE_2D_ARRAY                                             = 0x905E;
        public const uint GL_INT_IMAGE_CUBE_MAP_ARRAY                                       = 0x905F;
        public const uint GL_INT_IMAGE_2D_MULTISAMPLE                                       = 0x9060;
        public const uint GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY                                 = 0x9061;
        public const uint GL_UNSIGNED_INT_IMAGE_1D                                          = 0x9062;
        public const uint GL_UNSIGNED_INT_IMAGE_2D                                          = 0x9063;
        public const uint GL_UNSIGNED_INT_IMAGE_3D                                          = 0x9064;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_RECT                                     = 0x9065;
        public const uint GL_UNSIGNED_INT_IMAGE_CUBE                                        = 0x9066;
        public const uint GL_UNSIGNED_INT_IMAGE_BUFFER                                      = 0x9067;
        public const uint GL_UNSIGNED_INT_IMAGE_1D_ARRAY                                    = 0x9068;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_ARRAY                                    = 0x9069;
        public const uint GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY                              = 0x906A;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE                              = 0x906B;
        public const uint GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY                        = 0x906C;
        public const uint GL_MAX_IMAGE_SAMPLES                                              = 0x906D;
        public const uint GL_IMAGE_BINDING_FORMAT                                           = 0x906E;
        public const uint GL_IMAGE_FORMAT_COMPATIBILITY_TYPE                                = 0x90C7;
        public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE                             = 0x90C8;
        public const uint GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS                            = 0x90C9;
        public const uint GL_MAX_VERTEX_IMAGE_UNIFORMS                                      = 0x90CA;
        public const uint GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS                                = 0x90CB;
        public const uint GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS                             = 0x90CC;
        public const uint GL_MAX_GEOMETRY_IMAGE_UNIFORMS                                    = 0x90CD;
        public const uint GL_MAX_FRAGMENT_IMAGE_UNIFORMS                                    = 0x90CE;
        public const uint GL_MAX_COMBINED_IMAGE_UNIFORMS                                    = 0x90CF;
        /* Reuse tokens from ARB_shading_language_packing (none) */
        /* Reuse tokens from ARB_texture_storage */
        public const uint GL_TEXTURE_IMMUTABLE_FORMAT                                       = 0x912F;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 4.3 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 4.3 CONSTANTS...
        public const uint GL_NUM_SHADING_LANGUAGE_VERSIONS                        = 0x82E9;
        public const uint GL_VERTEX_ATTRIB_ARRAY_LONG                             = 0x874E;
        /* Reuse tokens from ARB_arrays_of_arrays (none, GLSL only) */
        /* Reuse tokens from ARB_fragment_layer_viewport (none, GLSL only) */
        /* Reuse tokens from ARB_shader_image_size (none, GLSL only) */
        /* Reuse tokens from ARB_ES3_compatibility */
        public const uint GL_COMPRESSED_RGB8_ETC2                                 = 0x9274;
        public const uint GL_COMPRESSED_SRGB8_ETC2                                = 0x9275;
        public const uint GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2             = 0x9276;
        public const uint GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2            = 0x9277;
        public const uint GL_COMPRESSED_RGBA8_ETC2_EAC                            = 0x9278;
        public const uint GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC                     = 0x9279;
        public const uint GL_COMPRESSED_R11_EAC                                   = 0x9270;
        public const uint GL_COMPRESSED_SIGNED_R11_EAC                            = 0x9271;
        public const uint GL_COMPRESSED_RG11_EAC                                  = 0x9272;
        public const uint GL_COMPRESSED_SIGNED_RG11_EAC                           = 0x9273;
        public const uint GL_PRIMITIVE_RESTART_FIXED_INDEX                        = 0x8D69;
        public const uint GL_ANY_SAMPLES_PASSED_CONSERVATIVE                      = 0x8D6A;
        public const uint GL_MAX_ELEMENT_INDEX                                    = 0x8D6B;
        /* Reuse tokens from ARB_clear_buffer_object (none) */
        /* Reuse tokens from ARB_compute_shader */
        public const uint GL_COMPUTE_SHADER                                       = 0x91B9;
        public const uint GL_MAX_COMPUTE_UNIFORM_BLOCKS                           = 0x91BB;
        public const uint GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS                      = 0x91BC;
        public const uint GL_MAX_COMPUTE_IMAGE_UNIFORMS                           = 0x91BD;
        public const uint GL_MAX_COMPUTE_SHARED_MEMORY_SIZE                       = 0x8262;
        public const uint GL_MAX_COMPUTE_UNIFORM_COMPONENTS                       = 0x8263;
        public const uint GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS                   = 0x8264;
        public const uint GL_MAX_COMPUTE_ATOMIC_COUNTERS                          = 0x8265;
        public const uint GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS              = 0x8266;
        public const uint GL_MAX_COMPUTE_LOCAL_INVOCATIONS                        = 0x90EB;
        public const uint GL_MAX_COMPUTE_WORK_GROUP_COUNT                         = 0x91BE;
        public const uint GL_MAX_COMPUTE_WORK_GROUP_SIZE                          = 0x91BF;
        public const uint GL_COMPUTE_LOCAL_WORK_SIZE                              = 0x8267;
        public const uint GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER           = 0x90EC;
        public const uint GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER   = 0x90ED;
        public const uint GL_DISPATCH_INDIRECT_BUFFER                             = 0x90EE;
        public const uint GL_DISPATCH_INDIRECT_BUFFER_BINDING                     = 0x90EF;
        public const uint GL_COMPUTE_SHADER_BIT                                   = 0x00000020;
        /* Reuse tokens from ARB_copy_image (none) */
        /* Reuse tokens from KHR_debug */
        public const uint GL_DEBUG_OUTPUT_SYNCHRONOUS                             = 0x8242;
        public const uint GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH                     = 0x8243;
        public const uint GL_DEBUG_CALLBACK_FUNCTION                              = 0x8244;
        public const uint GL_DEBUG_CALLBACK_USER_PARAM                            = 0x8245;
        public const uint GL_DEBUG_SOURCE_API                                     = 0x8246;
        public const uint GL_DEBUG_SOURCE_WINDOW_SYSTEM                           = 0x8247;
        public const uint GL_DEBUG_SOURCE_SHADER_COMPILER                         = 0x8248;
        public const uint GL_DEBUG_SOURCE_THIRD_PARTY                             = 0x8249;
        public const uint GL_DEBUG_SOURCE_APPLICATION                             = 0x824A;
        public const uint GL_DEBUG_SOURCE_OTHER                                   = 0x824B;
        public const uint GL_DEBUG_TYPE_ERROR                                     = 0x824C;
        public const uint GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR                       = 0x824D;
        public const uint GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR                        = 0x824E;
        public const uint GL_DEBUG_TYPE_PORTABILITY                               = 0x824F;
        public const uint GL_DEBUG_TYPE_PERFORMANCE                               = 0x8250;
        public const uint GL_DEBUG_TYPE_OTHER                                     = 0x8251;
        public const uint GL_DEBUG_TYPE_MARKER                                    = 0x8268;
        public const uint GL_DEBUG_TYPE_PUSH_GROUP                                = 0x8269;
        public const uint GL_DEBUG_TYPE_POP_GROUP                                 = 0x826A;
        public const uint GL_DEBUG_SEVERITY_NOTIFICATION                          = 0x826B;
        public const uint GL_MAX_DEBUG_GROUP_STACK_DEPTH                          = 0x826C;
        public const uint GL_DEBUG_GROUP_STACK_DEPTH                              = 0x826D;
        public const uint GL_BUFFER                                               = 0x82E0;
        public const uint GL_SHADER                                               = 0x82E1;
        public const uint GL_PROGRAM                                              = 0x82E2;
        public const uint GL_QUERY                                                = 0x82E3;
        public const uint GL_PROGRAM_PIPELINE                                     = 0x82E4;
        public const uint GL_SAMPLER                                              = 0x82E6;
        public const uint GL_DISPLAY_LIST                                         = 0x82E7;
        /* DISPLAY_LIST used in compatibility profile only */
        public const uint GL_MAX_LABEL_LENGTH                                     = 0x82E8;
        public const uint GL_MAX_DEBUG_MESSAGE_LENGTH                             = 0x9143;
        public const uint GL_MAX_DEBUG_LOGGED_MESSAGES                            = 0x9144;
        public const uint GL_DEBUG_LOGGED_MESSAGES                                = 0x9145;
        public const uint GL_DEBUG_SEVERITY_HIGH                                  = 0x9146;
        public const uint GL_DEBUG_SEVERITY_MEDIUM                                = 0x9147;
        public const uint GL_DEBUG_SEVERITY_LOW                                   = 0x9148;
        public const uint GL_DEBUG_OUTPUT                                         = 0x92E0;
        public const uint GL_CONTEXT_FLAG_DEBUG_BIT                               = 0x00000002;
        /* reuse GL_STACK_UNDERFLOW (defined in OpenGL 1.1) */
        /* reuse GL_STACK_OVERFLOW (defined in OpenGL 1.1) */
        /* Reuse tokens from ARB_explicit_uniform_location */
        public const uint GL_MAX_UNIFORM_LOCATIONS                                = 0x826E;
        /* Reuse tokens from ARB_framebuffer_no_attachments */
        public const uint GL_FRAMEBUFFER_DEFAULT_WIDTH                            = 0x9310;
        public const uint GL_FRAMEBUFFER_DEFAULT_HEIGHT                           = 0x9311;
        public const uint GL_FRAMEBUFFER_DEFAULT_LAYERS                           = 0x9312;
        public const uint GL_FRAMEBUFFER_DEFAULT_SAMPLES                          = 0x9313;
        public const uint GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS           = 0x9314;
        public const uint GL_MAX_FRAMEBUFFER_WIDTH                                = 0x9315;
        public const uint GL_MAX_FRAMEBUFFER_HEIGHT                               = 0x9316;
        public const uint GL_MAX_FRAMEBUFFER_LAYERS                               = 0x9317;
        public const uint GL_MAX_FRAMEBUFFER_SAMPLES                              = 0x9318;
        /* Reuse tokens from ARB_internalformat_query2 */
        /* reuse GL_IMAGE_FORMAT_COMPATIBILITY_TYPE (defined in OpenGL 4.2) */
        /* reuse GL_NUM_SAMPLE_COUNTS (defined in OpenGL 4.2) */
        /* reuse GL_RENDERBUFFER (defined in OpenGL 3.0) */
        /* reuse GL_SAMPLES (defined in OpenGL 1.3) */
        /* reuse GL_TEXTURE_1D (defined in OpenGL 1.1) */
        /* reuse GL_TEXTURE_1D_ARRAY (defined in OpenGL 3.0) */
        /* reuse GL_TEXTURE_2D (defined in OpenGL 1.1) */
        /* reuse GL_TEXTURE_2D_ARRAY (defined in OpenGL 3.0) */
        /* reuse GL_TEXTURE_3D (defined in OpenGL 1.2) */
        /* reuse GL_TEXTURE_CUBE_MAP defined in OpenGL 1.3) */
        /* reuse GL_TEXTURE_CUBE_MAP_ARRAY (defined in OpenGL 4.0) */
        /* reuse GL_TEXTURE_RECTANGLE (defined in OpenGL 3.1) */
        /* reuse GL_TEXTURE_BUFFER (defined in OpenGL 3.1) */
        /* reuse GL_TEXTURE_2D_MULTISAMPLE (defined in OpenGL 3.2) */
        /* reuse GL_TEXTURE_2D_MULTISAMPLE_ARRAY (defined in OpenGL 3.2) */
        /* reuse GL_TEXTURE_COMPRESSED (defined in OpenGL 1.3) */
        public const uint GL_INTERNALFORMAT_SUPPORTED                             = 0x826F;
        public const uint GL_INTERNALFORMAT_PREFERRED                             = 0x8270;
        public const uint GL_INTERNALFORMAT_RED_SIZE                              = 0x8271;
        public const uint GL_INTERNALFORMAT_GREEN_SIZE                            = 0x8272;
        public const uint GL_INTERNALFORMAT_BLUE_SIZE                             = 0x8273;
        public const uint GL_INTERNALFORMAT_ALPHA_SIZE                            = 0x8274;
        public const uint GL_INTERNALFORMAT_DEPTH_SIZE                            = 0x8275;
        public const uint GL_INTERNALFORMAT_STENCIL_SIZE                          = 0x8276;
        public const uint GL_INTERNALFORMAT_SHARED_SIZE                           = 0x8277;
        public const uint GL_INTERNALFORMAT_RED_TYPE                              = 0x8278;
        public const uint GL_INTERNALFORMAT_GREEN_TYPE                            = 0x8279;
        public const uint GL_INTERNALFORMAT_BLUE_TYPE                             = 0x827A;
        public const uint GL_INTERNALFORMAT_ALPHA_TYPE                            = 0x827B;
        public const uint GL_INTERNALFORMAT_DEPTH_TYPE                            = 0x827C;
        public const uint GL_INTERNALFORMAT_STENCIL_TYPE                          = 0x827D;
        public const uint GL_MAX_WIDTH                                            = 0x827E;
        public const uint GL_MAX_HEIGHT                                           = 0x827F;
        public const uint GL_MAX_DEPTH                                            = 0x8280;
        public const uint GL_MAX_LAYERS                                           = 0x8281;
        public const uint GL_MAX_COMBINED_DIMENSIONS                              = 0x8282;
        public const uint GL_COLOR_COMPONENTS                                     = 0x8283;
        public const uint GL_DEPTH_COMPONENTS                                     = 0x8284;
        public const uint GL_STENCIL_COMPONENTS                                   = 0x8285;
        public const uint GL_COLOR_RENDERABLE                                     = 0x8286;
        public const uint GL_DEPTH_RENDERABLE                                     = 0x8287;
        public const uint GL_STENCIL_RENDERABLE                                   = 0x8288;
        public const uint GL_FRAMEBUFFER_RENDERABLE                               = 0x8289;
        public const uint GL_FRAMEBUFFER_RENDERABLE_LAYERED                       = 0x828A;
        public const uint GL_FRAMEBUFFER_BLEND                                    = 0x828B;
        public const uint GL_READ_PIXELS                                          = 0x828C;
        public const uint GL_READ_PIXELS_FORMAT                                   = 0x828D;
        public const uint GL_READ_PIXELS_TYPE                                     = 0x828E;
        public const uint GL_TEXTURE_IMAGE_FORMAT                                 = 0x828F;
        public const uint GL_TEXTURE_IMAGE_TYPE                                   = 0x8290;
        public const uint GL_GET_TEXTURE_IMAGE_FORMAT                             = 0x8291;
        public const uint GL_GET_TEXTURE_IMAGE_TYPE                               = 0x8292;
        public const uint GL_MIPMAP                                               = 0x8293;
        public const uint GL_MANUAL_GENERATE_MIPMAP                               = 0x8294;
        public const uint GL_AUTO_GENERATE_MIPMAP                                 = 0x8295;
        public const uint GL_COLOR_ENCODING                                       = 0x8296;
        public const uint GL_SRGB_READ                                            = 0x8297;
        public const uint GL_SRGB_WRITE                                           = 0x8298;
        public const uint GL_SRGB_DECODE_ARB                                      = 0x8299;
        public const uint GL_FILTER                                               = 0x829A;
        public const uint GL_VERTEX_TEXTURE                                       = 0x829B;
        public const uint GL_TESS_CONTROL_TEXTURE                                 = 0x829C;
        public const uint GL_TESS_EVALUATION_TEXTURE                              = 0x829D;
        public const uint GL_GEOMETRY_TEXTURE                                     = 0x829E;
        public const uint GL_FRAGMENT_TEXTURE                                     = 0x829F;
        public const uint GL_COMPUTE_TEXTURE                                      = 0x82A0;
        public const uint GL_TEXTURE_SHADOW                                       = 0x82A1;
        public const uint GL_TEXTURE_GATHER                                       = 0x82A2;
        public const uint GL_TEXTURE_GATHER_SHADOW                                = 0x82A3;
        public const uint GL_SHADER_IMAGE_LOAD                                    = 0x82A4;
        public const uint GL_SHADER_IMAGE_STORE                                   = 0x82A5;
        public const uint GL_SHADER_IMAGE_ATOMIC                                  = 0x82A6;
        public const uint GL_IMAGE_TEXEL_SIZE                                     = 0x82A7;
        public const uint GL_IMAGE_COMPATIBILITY_CLASS                            = 0x82A8;
        public const uint GL_IMAGE_PIXEL_FORMAT                                   = 0x82A9;
        public const uint GL_IMAGE_PIXEL_TYPE                                     = 0x82AA;
        public const uint GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST                  = 0x82AC;
        public const uint GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST                = 0x82AD;
        public const uint GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE                 = 0x82AE;
        public const uint GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE               = 0x82AF;
        public const uint GL_TEXTURE_COMPRESSED_BLOCK_WIDTH                       = 0x82B1;
        public const uint GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT                      = 0x82B2;
        public const uint GL_TEXTURE_COMPRESSED_BLOCK_SIZE                        = 0x82B3;
        public const uint GL_CLEAR_BUFFER                                         = 0x82B4;
        public const uint GL_TEXTURE_VIEW                                         = 0x82B5;
        public const uint GL_VIEW_COMPATIBILITY_CLASS                             = 0x82B6;
        public const uint GL_FULL_SUPPORT                                         = 0x82B7;
        public const uint GL_CAVEAT_SUPPORT                                       = 0x82B8;
        public const uint GL_IMAGE_CLASS_4_X_32                                   = 0x82B9;
        public const uint GL_IMAGE_CLASS_2_X_32                                   = 0x82BA;
        public const uint GL_IMAGE_CLASS_1_X_32                                   = 0x82BB;
        public const uint GL_IMAGE_CLASS_4_X_16                                   = 0x82BC;
        public const uint GL_IMAGE_CLASS_2_X_16                                   = 0x82BD;
        public const uint GL_IMAGE_CLASS_1_X_16                                   = 0x82BE;
        public const uint GL_IMAGE_CLASS_4_X_8                                    = 0x82BF;
        public const uint GL_IMAGE_CLASS_2_X_8                                    = 0x82C0;
        public const uint GL_IMAGE_CLASS_1_X_8                                    = 0x82C1;
        public const uint GL_IMAGE_CLASS_11_11_10                                 = 0x82C2;
        public const uint GL_IMAGE_CLASS_10_10_10_2                               = 0x82C3;
        public const uint GL_VIEW_CLASS_128_BITS                                  = 0x82C4;
        public const uint GL_VIEW_CLASS_96_BITS                                   = 0x82C5;
        public const uint GL_VIEW_CLASS_64_BITS                                   = 0x82C6;
        public const uint GL_VIEW_CLASS_48_BITS                                   = 0x82C7;
        public const uint GL_VIEW_CLASS_32_BITS                                   = 0x82C8;
        public const uint GL_VIEW_CLASS_24_BITS                                   = 0x82C9;
        public const uint GL_VIEW_CLASS_16_BITS                                   = 0x82CA;
        public const uint GL_VIEW_CLASS_8_BITS                                    = 0x82CB;
        public const uint GL_VIEW_CLASS_S3TC_DXT1_RGB                             = 0x82CC;
        public const uint GL_VIEW_CLASS_S3TC_DXT1_RGBA                            = 0x82CD;
        public const uint GL_VIEW_CLASS_S3TC_DXT3_RGBA                            = 0x82CE;
        public const uint GL_VIEW_CLASS_S3TC_DXT5_RGBA                            = 0x82CF;
        public const uint GL_VIEW_CLASS_RGTC1_RED                                 = 0x82D0;
        public const uint GL_VIEW_CLASS_RGTC2_RG                                  = 0x82D1;
        public const uint GL_VIEW_CLASS_BPTC_UNORM                                = 0x82D2;
        public const uint GL_VIEW_CLASS_BPTC_FLOAT                                = 0x82D3;
        /* Reuse tokens from ARB_invalidate_subdata (none) */
        /* Reuse tokens from ARB_multi_draw_indirect (none) */
        /* Reuse tokens from ARB_program_interface_query */
        public const uint GL_UNIFORM                                              = 0x92E1;
        public const uint GL_UNIFORM_BLOCK                                        = 0x92E2;
        public const uint GL_PROGRAM_INPUT                                        = 0x92E3;
        public const uint GL_PROGRAM_OUTPUT                                       = 0x92E4;
        public const uint GL_BUFFER_VARIABLE                                      = 0x92E5;
        public const uint GL_SHADER_STORAGE_BLOCK                                 = 0x92E6;
        /* reuse GL_ATOMIC_COUNTER_BUFFER (defined in OpenGL 4.2) */
        public const uint GL_VERTEX_SUBROUTINE                                    = 0x92E8;
        public const uint GL_TESS_CONTROL_SUBROUTINE                              = 0x92E9;
        public const uint GL_TESS_EVALUATION_SUBROUTINE                           = 0x92EA;
        public const uint GL_GEOMETRY_SUBROUTINE                                  = 0x92EB;
        public const uint GL_FRAGMENT_SUBROUTINE                                  = 0x92EC;
        public const uint GL_COMPUTE_SUBROUTINE                                   = 0x92ED;
        public const uint GL_VERTEX_SUBROUTINE_UNIFORM                            = 0x92EE;
        public const uint GL_TESS_CONTROL_SUBROUTINE_UNIFORM                      = 0x92EF;
        public const uint GL_TESS_EVALUATION_SUBROUTINE_UNIFORM                   = 0x92F0;
        public const uint GL_GEOMETRY_SUBROUTINE_UNIFORM                          = 0x92F1;
        public const uint GL_FRAGMENT_SUBROUTINE_UNIFORM                          = 0x92F2;
        public const uint GL_COMPUTE_SUBROUTINE_UNIFORM                           = 0x92F3;
        public const uint GL_TRANSFORM_FEEDBACK_VARYING                           = 0x92F4;
        public const uint GL_ACTIVE_RESOURCES                                     = 0x92F5;
        public const uint GL_MAX_NAME_LENGTH                                      = 0x92F6;
        public const uint GL_MAX_NUM_ACTIVE_VARIABLES                             = 0x92F7;
        public const uint GL_MAX_NUM_COMPATIBLE_SUBROUTINES                       = 0x92F8;
        public const uint GL_NAME_LENGTH                                          = 0x92F9;
        public const uint GL_TYPE                                                 = 0x92FA;
        public const uint GL_ARRAY_SIZE                                           = 0x92FB;
        public const uint GL_OFFSET                                               = 0x92FC;
        public const uint GL_BLOCK_INDEX                                          = 0x92FD;
        public const uint GL_ARRAY_STRIDE                                         = 0x92FE;
        public const uint GL_MATRIX_STRIDE                                        = 0x92FF;
        public const uint GL_IS_ROW_MAJOR                                         = 0x9300;
        public const uint GL_ATOMIC_COUNTER_BUFFER_INDEX                          = 0x9301;
        public const uint GL_BUFFER_BINDING                                       = 0x9302;
        public const uint GL_BUFFER_DATA_SIZE                                     = 0x9303;
        public const uint GL_NUM_ACTIVE_VARIABLES                                 = 0x9304;
        public const uint GL_ACTIVE_VARIABLES                                     = 0x9305;
        public const uint GL_REFERENCED_BY_VERTEX_SHADER                          = 0x9306;
        public const uint GL_REFERENCED_BY_TESS_CONTROL_SHADER                    = 0x9307;
        public const uint GL_REFERENCED_BY_TESS_EVALUATION_SHADER                 = 0x9308;
        public const uint GL_REFERENCED_BY_GEOMETRY_SHADER                        = 0x9309;
        public const uint GL_REFERENCED_BY_FRAGMENT_SHADER                        = 0x930A;
        public const uint GL_REFERENCED_BY_COMPUTE_SHADER                         = 0x930B;
        public const uint GL_TOP_LEVEL_ARRAY_SIZE                                 = 0x930C;
        public const uint GL_TOP_LEVEL_ARRAY_STRIDE                               = 0x930D;
        public const uint GL_LOCATION                                             = 0x930E;
        public const uint GL_LOCATION_INDEX                                       = 0x930F;
        public const uint GL_IS_PER_PATCH                                         = 0x92E7;
        /* reuse GL_NUM_COMPATIBLE_SUBROUTINES (defined in OpenGL 4.0) */
        /* reuse GL_COMPATIBLE_SUBROUTINES (defined in OpenGL 4.0) */
        /* Reuse tokens from ARB_robust_buffer_access_behavior (none) */
        /* Reuse tokens from ARB_shader_storage_buffer_object */
        public const uint GL_SHADER_STORAGE_BUFFER                                = 0x90D2;
        public const uint GL_SHADER_STORAGE_BUFFER_BINDING                        = 0x90D3;
        public const uint GL_SHADER_STORAGE_BUFFER_START                          = 0x90D4;
        public const uint GL_SHADER_STORAGE_BUFFER_SIZE                           = 0x90D5;
        public const uint GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS                     = 0x90D6;
        public const uint GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS                   = 0x90D7;
        public const uint GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS               = 0x90D8;
        public const uint GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS            = 0x90D9;
        public const uint GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS                   = 0x90DA;
        public const uint GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS                    = 0x90DB;
        public const uint GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS                   = 0x90DC;
        public const uint GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS                   = 0x90DD;
        public const uint GL_MAX_SHADER_STORAGE_BLOCK_SIZE                        = 0x90DE;
        public const uint GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT               = 0x90DF;
        public const uint GL_SHADER_STORAGE_BARRIER_BIT                           = 0x2000;
        public const uint GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES                 = GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS;
        /* reuse GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS (defined in OpenGL 4.2) */
        /* Reuse tokens from ARB_stencil_texturing */
        public const uint GL_DEPTH_STENCIL_TEXTURE_MODE                           = 0x90EA;
        /* Reuse tokens from ARB_texture_buffer_range */
        public const uint GL_TEXTURE_BUFFER_OFFSET                                = 0x919D;
        public const uint GL_TEXTURE_BUFFER_SIZE                                  = 0x919E;
        public const uint GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT                      = 0x919F;
        /* Reuse tokens from ARB_texture_query_levels (none) */
        /* Reuse tokens from ARB_texture_storage_multisample (none) */
        /* Reuse tokens from ARB_texture_view */
        public const uint GL_TEXTURE_VIEW_MIN_LEVEL                               = 0x82DB;
        public const uint GL_TEXTURE_VIEW_NUM_LEVELS                              = 0x82DC;
        public const uint GL_TEXTURE_VIEW_MIN_LAYER                               = 0x82DD;
        public const uint GL_TEXTURE_VIEW_NUM_LAYERS                              = 0x82DE;
        public const uint GL_TEXTURE_IMMUTABLE_LEVELS                             = 0x82DF;
        /* Reuse tokens from ARB_vertex_attrib_binding */
        public const uint GL_VERTEX_ATTRIB_BINDING                                = 0x82D4;
        public const uint GL_VERTEX_ATTRIB_RELATIVE_OFFSET                        = 0x82D5;
        public const uint GL_VERTEX_BINDING_DIVISOR                               = 0x82D6;
        public const uint GL_VERTEX_BINDING_OFFSET                                = 0x82D7;
        public const uint GL_VERTEX_BINDING_STRIDE                                = 0x82D8;
        public const uint GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET                    = 0x82D9;
        public const uint GL_MAX_VERTEX_ATTRIB_BINDINGS                           = 0x82DA;
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 4.4 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 4.4 CONSTANTS...
        public const uint GL_MAX_VERTEX_ATTRIB_STRIDE                   = 0x82E5;
        public const uint GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED    = 0x8221;
        public const uint GL_TEXTURE_BUFFER_BINDING                     = 0x8C2A;
        public const uint GL_MAP_PERSISTENT_BIT                         = 0x0040;
        public const uint GL_MAP_COHERENT_BIT                           = 0x0080;
        public const uint GL_DYNAMIC_STORAGE_BIT                        = 0x0100;
        public const uint GL_CLIENT_STORAGE_BIT                         = 0x0200;
        public const uint GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT           = 0x00004000;
        public const uint GL_BUFFER_IMMUTABLE_STORAGE                   = 0x821F;
        public const uint GL_BUFFER_STORAGE_FLAGS                       = 0x8220;
        public const uint GL_CLEAR_TEXTURE                              = 0x9365;
        public const uint GL_LOCATION_COMPONENT                         = 0x934A;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_INDEX            = 0x934B;
        public const uint GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE           = 0x934C;
        public const uint GL_QUERY_BUFFER                               = 0x9192;
        public const uint GL_QUERY_BUFFER_BARRIER_BIT                   = 0x00008000;
        public const uint GL_QUERY_BUFFER_BINDING                       = 0x9193;
        public const uint GL_QUERY_RESULT_NO_WAIT                       = 0x9194;
        public const uint GL_MIRROR_CLAMP_TO_EDGE                       = 0x8743;       
        #endregion

        ///////////////////////////////////////////////////////////////////////
        // OPENGL 4.5 CONSTANTS
        ///////////////////////////////////////////////////////////////////////
        #region OPENGL 4.5 CONSTANTS...
        public const uint GL_CONTEXT_LOST                               = 0x0507;
        public const uint GL_NEGATIVE_ONE_TO_ONE                        = 0x935E;
        public const uint GL_ZERO_TO_ONE                                = 0x935F;
        public const uint GL_CLIP_ORIGIN                                = 0x935C;
        public const uint GL_CLIP_DEPTH_MODE                            = 0x935D;
        public const uint GL_QUERY_WAIT_INVERTED                        = 0x8E17;
        public const uint GL_QUERY_NO_WAIT_INVERTED                     = 0x8E18;
        public const uint GL_QUERY_BY_REGION_WAIT_INVERTED              = 0x8E19;
        public const uint GL_QUERY_BY_REGION_NO_WAIT_INVERTED           = 0x8E1A;
        public const uint GL_MAX_CULL_DISTANCES                         = 0x82F9;
        public const uint GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES       = 0x82FA;
        public const uint GL_TEXTURE_TARGET                             = 0x1006;
        public const uint GL_QUERY_TARGET                               = 0x82EA;
        public const uint GL_GUILTY_CONTEXT_RESET                       = 0x8253;
        public const uint GL_INNOCENT_CONTEXT_RESET                     = 0x8254;
        public const uint GL_UNKNOWN_CONTEXT_RESET                      = 0x8255;
        public const uint GL_RESET_NOTIFICATION_STRATEGY                = 0x8256;
        public const uint GL_LOSE_CONTEXT_ON_RESET                      = 0x8252;
        public const uint GL_NO_RESET_NOTIFICATION                      = 0x8261;
        public const uint GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT             = 0x00000004;
        public const uint GL_CONTEXT_RELEASE_BEHAVIOR                   = 0x82FB;
        public const uint GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH             = 0x82FC;
        #endregion
    }
}
