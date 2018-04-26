// ----------------------------------------------------------------------------
// FILE		: q2texturemanager.cs
// VERSION	: 1.1.3
// DATE     : 26 April 2018
// COMMENT	: This file is part of Quake 2 Console Demo. The Q2TextureManager
//            provides FilePath normalization, Texture reading from disk, holding
//            the textures in the computer memory and uploading them to the GPU
//            services.
// WEB      : https://github.com/carmack78/opengldotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : taylaninan@yahoo.com 
// DATE     : 2014-2018
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using OpenGLDotNet;

namespace Quake2DotNet
{
    public class TextureNode
    {
        public string FilePath = null;
        public uint GLTextureNumber = 0;
        public uint GLImageFormat = 0;
        public uint GLImageType = 0;
        public uint Width = 0;
        public uint Height = 0;
        public uint Depth = 0;                  // Quake2 does not seem to use 3D textures, but anyway here it goes...
        public uint DataSize = 0;
    }

    public static class TextureManager
    {
        // Texture Manager (TM), PreProcess (PP) Bit Flags
        public const byte TM_PP_NONE         = 0x00;
        public const byte TM_PP_FLIP_IMAGE   = 0x01;
        public const byte TM_PP_MIRROR_IMAGE = 0x02;

        private static SortedList<string, TextureNode> Textures = new SortedList<string, TextureNode>();          // <FilePath, TextureNode>

        private static string FilePathStandardization(string FilePath)
        {
            // Build a standard "data\" beginning FilePath
            string FilePathShort = FilePath.ToLower().Replace("/", @"\");

            if (!FilePathShort.StartsWith(@"\data\") && !FilePathShort.StartsWith(@"data\") && !FilePathShort.StartsWith("data"))
            {
                FilePathShort = @"data\" + FilePathShort;
                FilePathShort = FilePathShort.Replace(@"\\", @"\");
            }

            return FilePathShort;
        }

        public static TextureNode FindTexture(string FilePath)
        {
            FilePath = FilePathStandardization(FilePath);

            if (Textures.ContainsKey(FilePath))
            {
                return Textures[FilePath];
            }
            else
            {
                return null;
            }
        }

        public static uint FindTextureNumber(string FilePath)
        {
            FilePath = FilePathStandardization(FilePath);

            if (Textures.ContainsKey(FilePath))
            {
                return Textures[FilePath].GLTextureNumber;
            }
            else
            {
                return 0;
            }
        }

        public static TextureNode LoadTexture(string FilePath, uint GLTarget, byte ImagePreProcess)
        {
            string FilePathShort = FilePathStandardization(FilePath);

            // Is it already loaded?
            if (FindTexture(FilePathShort) != null)
            {
                return FindTexture(FilePathShort);
            }
            // Texture not found, load it into the memory
            else
            {
                // Add the current working directory of OpenGLDotNet
                string currentDirName = System.IO.Directory.GetCurrentDirectory();
                string FilePathLong = currentDirName + @"\" + FilePathShort;
                FilePathLong = FilePathLong.Replace(@"\\", @"\");

                // Generate a new image number from DevIL
                uint ILTextureNumber = IL.GenImage();
                IL.BindImage(ILTextureNumber);

                // Load it into the memory with DevIL
                if (IL.LoadImage(FilePathLong))
                {
                    // Preprocess Check
                    if ((ImagePreProcess & TM_PP_FLIP_IMAGE) > 0)
                    {
                        ILU.FlipImage();
                    }
                    if ((ImagePreProcess & TM_PP_MIRROR_IMAGE) > 0)
                    {
                        ILU.Mirror();
                    }

                    // Create a new TextureNode
                    TextureNode Node = new TextureNode();

                    Node.FilePath = FilePathShort;
                    Node.Width = (uint)IL.GetInteger(IL.IL_IMAGE_WIDTH);
                    Node.Height = (uint)IL.GetInteger(IL.IL_IMAGE_HEIGHT);
                    Node.Depth = (uint)IL.GetInteger(IL.IL_IMAGE_DEPTH);
                    Node.GLImageFormat = (uint)IL.GetInteger(IL.IL_IMAGE_FORMAT);
                    Node.GLImageType = (uint)IL.GetInteger(IL.IL_IMAGE_TYPE);
                    Node.DataSize = (uint)IL.GetInteger(IL.IL_IMAGE_SIZE_OF_DATA);

                    // Generate a new texture number from OpenGL
                    uint[] GLTextureNumber = new uint[1];
                    GL.GenTextures(1, GLTextureNumber);
                    // Assign the new number to node
                    Node.GLTextureNumber = GLTextureNumber[0];

                    GL.BindTexture(GLTarget, Node.GLTextureNumber);
                    GL.TexImage2D(GLTarget, 0, (int)Node.GLImageFormat, (int)Node.Width, (int)Node.Height, 0, Node.GLImageFormat, Node.GLImageType, IL.GetData());

                    GL.TexParameteri(GLTarget, GL.GL_TEXTURE_WRAP_S, (int)GL.GL_CLAMP_TO_EDGE);
                    GL.TexParameteri(GLTarget, GL.GL_TEXTURE_WRAP_T, (int)GL.GL_CLAMP_TO_EDGE);
                    GL.TexParameteri(GLTarget, GL.GL_TEXTURE_WRAP_R, (int)GL.GL_CLAMP_TO_EDGE);
                    GL.TexParameteri(GLTarget, GL.GL_TEXTURE_MAG_FILTER, (int)GL.GL_LINEAR);
                    GL.TexParameteri(GLTarget, GL.GL_TEXTURE_MIN_FILTER, (int)GL.GL_LINEAR);

                    // We are done uploading the image, free up memory from DevIL
                    IL.DeleteImage(ILTextureNumber);

                    Textures.Add(FilePathShort, Node);

                    return Node;
                }
                // Texture couldn't be loaded, return null
                else
                {
                    return null;
                }
            }
        }

        public static TextureNode LoadCubemapTexture(string FilePath, uint GLTarget, byte ImagePreProcess)
        {
            string FilePathShort = FilePathStandardization(FilePath);

            // Is it already loaded?
            if (FindTexture(FilePathShort) != null)
            {
                return FindTexture(FilePathShort);
            }
            // Texture not found, load it into the memory
            else
            {
                // Add the current working directory of OpenGLDotNet
                string currentDirName = System.IO.Directory.GetCurrentDirectory();
                string FilePathLong = currentDirName + @"\" + FilePathShort;
                FilePathLong = FilePathLong.Replace(@"\\", @"\");

                // Generate a new image number from DevIL
                uint ILTextureNumber = IL.GenImage();
                IL.BindImage(ILTextureNumber);

                // Load it into the memory with DevIL
                if (IL.LoadImage(FilePathLong))
                {
                    // Preprocess Check
                    if ((ImagePreProcess & TM_PP_FLIP_IMAGE) > 0)
                    {
                        ILU.FlipImage();
                    }
                    if ((ImagePreProcess & TM_PP_MIRROR_IMAGE) > 0)
                    {
                        ILU.Mirror();
                    }

                    // Create a new TextureNode
                    TextureNode Node = new TextureNode();

                    Node.FilePath = FilePathShort;
                    Node.Width = (uint)IL.GetInteger(IL.IL_IMAGE_WIDTH);
                    Node.Height = (uint)IL.GetInteger(IL.IL_IMAGE_HEIGHT);
                    Node.Depth = (uint)IL.GetInteger(IL.IL_IMAGE_DEPTH);
                    Node.GLImageFormat = (uint)IL.GetInteger(IL.IL_IMAGE_FORMAT);
                    Node.GLImageType = (uint)IL.GetInteger(IL.IL_IMAGE_TYPE);
                    Node.DataSize = (uint)IL.GetInteger(IL.IL_IMAGE_SIZE_OF_DATA);

                    // Generate a new texture number from OpenGL
                    uint[] GLTextureNumber = new uint[1];
                    GL.GenTextures(1, GLTextureNumber);
                    // Assign the new number to node
                    Node.GLTextureNumber = GLTextureNumber[0];

                    GL.BindTexture(GLTarget, Node.GLTextureNumber);
                    GL.TexImage2D(GLTarget, 0, (int)Node.GLImageFormat, (int)Node.Width, (int)Node.Height, 0, Node.GLImageFormat, Node.GLImageType, IL.GetData());

                    GL.TexParameteri(GL.GL_TEXTURE_CUBE_MAP, GL.GL_TEXTURE_WRAP_S, (int)GL.GL_CLAMP_TO_EDGE);
                    GL.TexParameteri(GL.GL_TEXTURE_CUBE_MAP, GL.GL_TEXTURE_WRAP_T, (int)GL.GL_CLAMP_TO_EDGE);
                    GL.TexParameteri(GL.GL_TEXTURE_CUBE_MAP, GL.GL_TEXTURE_WRAP_R, (int)GL.GL_CLAMP_TO_EDGE);
                    GL.TexParameteri(GL.GL_TEXTURE_CUBE_MAP, GL.GL_TEXTURE_MAG_FILTER, (int)GL.GL_LINEAR);
                    GL.TexParameteri(GL.GL_TEXTURE_CUBE_MAP, GL.GL_TEXTURE_MIN_FILTER, (int)GL.GL_LINEAR);

                    // We are done uploading the image, free up memory from DevIL
                    IL.DeleteImage(ILTextureNumber);

                    Textures.Add(FilePathShort, Node);

                    return Node;
                }
                // Texture couldn't be loaded, return null
                else
                {
                    return null;
                }
            }
        }

        public static void DeleteTexture(string FilePath)
        {
            string FilePathShort = FilePathStandardization(FilePath);

            // Is it already loaded?
            TextureNode Node = FindTexture(FilePathShort);

            if (Node != null)
            {
                uint[] GLTextureNumber = new uint[1];
                GLTextureNumber[0] = Node.GLTextureNumber;

                GL.DeleteTextures(1, GLTextureNumber);

                Textures.Remove(FilePathShort);
            }
        }

        public static void DeleteTexture(TextureNode Node)
        {
            if (Node != null)
            {
                DeleteTexture(Node.FilePath);
            }
        }
		
		public static IList<TextureNode> GetValues
        {
            get
            {
                return Textures.Values;
            }
        }
    }
}
