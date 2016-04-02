using System;
using System.Runtime.InteropServices;

namespace OpenGLDotNet
{
    public static partial class WGL
    {
        ///////////////////////////////////////////////////////////////////////
        // OPENGL CORE WGL TYPES
        ///////////////////////////////////////////////////////////////////////
        [StructLayout(LayoutKind.Explicit)]
        public struct PIXELFORMATDESCRIPTOR
        {
            [FieldOffset(00)]   public UInt16 nSize;
            [FieldOffset(02)]   public UInt16 nVersion;
            [FieldOffset(04)]   public UInt32 dwFlags;
            [FieldOffset(08)]   public Byte   iPixelType;
            [FieldOffset(09)]   public Byte   cColorBits;
            [FieldOffset(10)]   public Byte   cRedBits;
            [FieldOffset(11)]   public Byte   cRedShift;
            [FieldOffset(12)]   public Byte   cGreenBits;
            [FieldOffset(13)]   public Byte   cGreenShift;
            [FieldOffset(14)]   public Byte   cBlueBits;
            [FieldOffset(15)]   public Byte   cBlueShift;
            [FieldOffset(16)]   public Byte   cAlphaBits;
            [FieldOffset(17)]   public Byte   cAlphaShift;
            [FieldOffset(18)]   public Byte   cAccumBits;
            [FieldOffset(19)]   public Byte   cAccumRedBits;
            [FieldOffset(20)]   public Byte   cAccumGreenBits;
            [FieldOffset(21)]   public Byte   cAccumBlueBits;
            [FieldOffset(22)]   public Byte   cAccumAlphaBits;
            [FieldOffset(23)]   public Byte   cDepthBits;
            [FieldOffset(24)]   public Byte   cStencilBits;
            [FieldOffset(25)]   public Byte   cAuxBuffers;
            [FieldOffset(26)]   public Byte   iLayerType;
            [FieldOffset(27)]   public Byte   bReserved;
            [FieldOffset(28)]   public UInt32 dwLayerMask;
            [FieldOffset(32)]   public UInt32 dwVisibleMask;
            [FieldOffset(36)]   public UInt32 dwDamageMask;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct POINTFLOAT
        {
            [FieldOffset(00)]   public Single x;
            [FieldOffset(04)]   public Single y;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct GLYPHMETRICSFLOAT
        {
            [FieldOffset(00)]   public Single gmfBlackBoxX;
            [FieldOffset(04)]   public Single gmfBlackBoxY;
            [FieldOffset(08)]   public POINTFLOAT gmfptGlyphOrigin;
            [FieldOffset(16)]   public Single gmfCellIncX;
            [FieldOffset(20)]   public Single gmfCellIncY;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct COLORREF
        {
            [FieldOffset(00)]   public UInt32 Value;
            [FieldOffset(00)]   public Byte   R;
            [FieldOffset(01)]   public Byte   G;
            [FieldOffset(02)]   public Byte   B;
            [FieldOffset(03)]   public Byte   A;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct LAYERPLANEDESCRIPTOR
        {
            [FieldOffset(00)]   public UInt16   nSize;
            [FieldOffset(02)]   public UInt16   nVersion;
            [FieldOffset(04)]   public UInt32   dwFlags;
            [FieldOffset(08)]   public Byte     iPixelType;
            [FieldOffset(09)]   public Byte     cColorBits;
            [FieldOffset(10)]   public Byte     cRedBits;
            [FieldOffset(11)]   public Byte     cRedShift;
            [FieldOffset(12)]   public Byte     cGreenBits;
            [FieldOffset(13)]   public Byte     cGreenShift;
            [FieldOffset(14)]   public Byte     cBlueBits;
            [FieldOffset(15)]   public Byte     cBlueShift;
            [FieldOffset(16)]   public Byte     cAlphaBits;
            [FieldOffset(17)]   public Byte     cAlphaShift;
            [FieldOffset(18)]   public Byte     cAccumBits;
            [FieldOffset(19)]   public Byte     cAccumRedBits;
            [FieldOffset(20)]   public Byte     cAccumGreenBits;
            [FieldOffset(21)]   public Byte     cAccumBlueBits;
            [FieldOffset(22)]   public Byte     cAccumAlphaBits;
            [FieldOffset(23)]   public Byte     cDepthBits;
            [FieldOffset(24)]   public Byte     cStencilBits;
            [FieldOffset(25)]   public Byte     cAuxBuffer;
            [FieldOffset(26)]   public Byte     iLayerType;
            [FieldOffset(27)]   public Byte     bReserved;
            [FieldOffset(28)]   public COLORREF crTransparent;
        }
    }
}
