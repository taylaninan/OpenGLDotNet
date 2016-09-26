// ----------------------------------------------------------------------------
// FILE		: q2consolemanager.cs
// VERSION	: 1.1.0
// COMMENT	: This file is part of Quake 2 Console Demo. The Q2ConsoleManager
//			  shows the background picture, blends the text written on it, logs
//            input text and command output texts; also reads the font picture
//            from disk and writes letters on the background picture.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2016
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using Common;
using OpenGLDotNet;
using OpenGLDotNet.Math;

namespace Quake2DotNet
{
    ///////////////////////////////////////////////////////////////////////////
    // CONSOLE MANAGER
    ///////////////////////////////////////////////////////////////////////////
    public static class ConsoleManager
    {
        private static ushort _ScreenWidth = 0;
        private static ushort _ScreenHeight = 0;
        private static ushort _CharsPerLine = 0;
        private static ushort _LinesPerScreen = 0;
        private static uint _TopLineIndex = 1;
        private static uint _BottomLineIndex = 0;

        private static TextureNode _ConsoleBackground = null;
        private static TextureNode _ConsoleChars = null;

        private static ushort _CursorPosX = 0;
        private static ushort _CursorPosY = 0;

        private static bool _IsOpen = true;

        public static bool IsOpen
        {
            get
            {
                return _IsOpen;
            }
        }

        public static void Init()
        {
            _ScreenWidth = ConsoleVarManager.GetValueToUShort("ScreenWidth");
            _ScreenHeight = ConsoleVarManager.GetValueToUShort("ScreenHeight");

            _CharsPerLine = (ushort)(_ScreenWidth >> 3);                // division by 8
            _LinesPerScreen = (ushort)((_ScreenHeight >> 3) - 1);       // division by 8; last line is console input line

            _ConsoleBackground = TextureManager.LoadTexture(ConsoleVarManager.GetValueToString("ConsoleBackground"));
            _ConsoleChars = TextureManager.LoadTexture(ConsoleVarManager.GetValueToString("ConsoleCharacters"));
        }

        public static void WriteLine(string Line)
        {
            ConsoleLogManager.WriteLine(Line);

            if (ConsoleLogManager.Count <= _LinesPerScreen)
            {
                _TopLineIndex = 1;
                _BottomLineIndex = _TopLineIndex + ConsoleLogManager.Count - 1;
            }
            else
            {
                _TopLineIndex++;
                _BottomLineIndex = _TopLineIndex + _LinesPerScreen - 1;
            }
        }

        public static void WriteLine()
        {
            ConsoleLogManager.WriteLine();

            if (ConsoleLogManager.Count <= _LinesPerScreen)
            {
                _TopLineIndex = 1;
                _BottomLineIndex = _TopLineIndex + ConsoleLogManager.Count - 1;
            }
            else
            {
                _TopLineIndex++;
                _BottomLineIndex = _TopLineIndex + _LinesPerScreen - 1;
            }
        }

        public static void Write(string Line)
        {
            ConsoleLogManager.Write(Line);

            // Set the cursor position for text input
            _CursorPosX = (ushort)ConsoleLogManager.GetBufferLength();
            _CursorPosY = _LinesPerScreen;
        }

        public static void Open()
        {
            _IsOpen = true;

            // Change to 2D Mode
            GL.MatrixMode(GL.GL_PROJECTION);
            GL.LoadIdentity();
            GL.Ortho(0, _ScreenWidth, _ScreenHeight, 0, -4096, 4096);

            GL.MatrixMode(GL.GL_MODELVIEW);
            GL.LoadIdentity();

            GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);

            Draw();

            FG.SwapBuffers();
        }

        private static void Draw()
        {
            // Draw console background
            GL.BindTexture(GL.GL_TEXTURE_2D, _ConsoleBackground.GLTextureNumber);
            GL.Begin(GL.GL_QUADS);
            GL.Color4f(0.0f, 0.0f, 0.0f, 0.0f);         // Black, transparent
            GL.TexCoord2f(0.0f, 0.0f); GL.Vertex2f(0.0f, 0.0f);
            GL.TexCoord2f(0.0f, 1.0f); GL.Vertex2f(0.0f, _ScreenHeight);
            GL.TexCoord2f(1.0f, 1.0f); GL.Vertex2f(_ScreenWidth, _ScreenHeight);
            GL.TexCoord2f(1.0f, 0.0f); GL.Vertex2f(_ScreenWidth, 0.0f);
            GL.End();

            // Draw text lines
            DrawLines(_TopLineIndex, _BottomLineIndex);

            // Write the console input character
            if (String.IsNullOrEmpty(ConsoleLogManager.ReadBuffer()))
            {
                Write("> ");
            }

            // Draw text input line, because we have initially a long OpenGL loading log, the cursor is always at the last line
            DrawLine((uint)(_LinesPerScreen * 8), ConsoleLogManager.ReadBuffer());

            // Set the cursor position for text input
            _CursorPosX = (ushort)ConsoleLogManager.GetBufferLength();
            _CursorPosY = _LinesPerScreen;
        }

        public static void Close()
        {
            _IsOpen = false;

            GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);
            FG.SwapBuffers();
        }

        private static void DrawLines(uint FirstLine, uint LastLine)
        {
            for (uint Counter = FirstLine; Counter <= LastLine; Counter++)
            {
                string Line = ConsoleLogManager.GetLineByNumber(Counter);
                uint LinePosY = (Counter - FirstLine) * 8;

                DrawLine(LinePosY, Line);
            }
        }

        private static void DrawLine(uint LinePosY, string Line)
        {
            if (Line != null)
            {
                for (uint Counter = 0; Counter < Line.Length; Counter++)
                {
                    DrawChar(Counter * 8, LinePosY, Line[(int)Counter]);
                }
            }
        }

        private static void DrawChar(uint CharPosX, uint CharPosY, char Chr)
        {
            Point2i CharPos = MapCharToImage(Chr);

            float TexCharSize = 1.0f / 16.0f;                     // There are 16x16 characters (each having 8x8 pixels) in the image

            if (CharPos != null)
            {
                float TexPosX = TexCharSize * (float)CharPos.X;
                float TexPosY = TexCharSize * (float)CharPos.Y;

                GL.BindTexture(GL.GL_TEXTURE_2D, _ConsoleChars.GLTextureNumber);
                GL.Begin(GL.GL_QUADS);
                GL.Color4f(0.0f, 0.0f, 0.0f, 0.0f);
                GL.TexCoord2f(TexPosX, TexPosY); 
                GL.Vertex2f(CharPosX, CharPosY);
                GL.TexCoord2f(TexPosX + TexCharSize, TexPosY); 
                GL.Vertex2f(CharPosX + 8, CharPosY);
                GL.TexCoord2f(TexPosX + TexCharSize, TexPosY + TexCharSize); 
                GL.Vertex2f(CharPosX + 8, CharPosY + 8);
                GL.TexCoord2f(TexPosX, TexPosY + TexCharSize); 
                GL.Vertex2f(CharPosX, CharPosY + 8);
                GL.End();
            }
        }

        private static void DrawChar(uint CharPosX, uint CharPosY, byte CharNumber)
        {
            Point2i CharPos = MapCharNumberToImage(CharNumber);

            float TexCharSize = 1.0f / 16.0f;                     // There are 16x16 characters (each having 8x8 pixels) in the image
            float TexPosX = TexCharSize * (float)CharPos.X;
            float TexPosY = TexCharSize * (float)CharPos.Y;

            if (CharPos != null)
            {
                GL.BindTexture(GL.GL_TEXTURE_2D, _ConsoleChars.GLTextureNumber);
                GL.Begin(GL.GL_QUADS);
                GL.Color4f(0.0f, 0.0f, 0.0f, 0.0f);
                GL.TexCoord2f(TexPosX, TexPosY);
                GL.Vertex2f(CharPosX, CharPosY);
                GL.TexCoord2f(TexPosX + TexCharSize, TexPosY);
                GL.Vertex2f(CharPosX + 8, CharPosY);
                GL.TexCoord2f(TexPosX + TexCharSize, TexPosY + TexCharSize);
                GL.Vertex2f(CharPosX + 8, CharPosY + 8);
                GL.TexCoord2f(TexPosX, TexPosY + TexCharSize);
                GL.Vertex2f(CharPosX, CharPosY + 8);
                GL.End();
            }
        }

        private static Point2i MapCharToImage(char Chr)
        {
            Point2i Result = new Point2i();

            switch (Chr)
            {
                // First 2 lines of image contains graphic drawing characters

                // Line 3:
                case ' ': Result.MoveTo(00, 02); break;
                case '!': Result.MoveTo(01, 02); break;
                case '"': Result.MoveTo(02, 02); break;
                case '#': Result.MoveTo(03, 02); break;
                case '$': Result.MoveTo(04, 02); break;
                case '%': Result.MoveTo(05, 02); break;
                case '&': Result.MoveTo(06, 02); break;
                case '\'': Result.MoveTo(07, 02); break;
                case '(': Result.MoveTo(08, 02); break;
                case ')': Result.MoveTo(09, 02); break;
                case '*': Result.MoveTo(10, 02); break;
                case '+': Result.MoveTo(11, 02); break;
                case ',': Result.MoveTo(12, 02); break;
                case '-': Result.MoveTo(13, 02); break;
                case '.': Result.MoveTo(14, 02); break;
                case '/': Result.MoveTo(15, 02); break;
                
                // Line 4:
                case '0': Result.MoveTo(00, 03); break;
                case '1': Result.MoveTo(01, 03); break;
                case '2': Result.MoveTo(02, 03); break;
                case '3': Result.MoveTo(03, 03); break;
                case '4': Result.MoveTo(04, 03); break;
                case '5': Result.MoveTo(05, 03); break;
                case '6': Result.MoveTo(06, 03); break;
                case '7': Result.MoveTo(07, 03); break;
                case '8': Result.MoveTo(08, 03); break;
                case '9': Result.MoveTo(09, 03); break;
                case ':': Result.MoveTo(10, 03); break;
                case ';': Result.MoveTo(11, 03); break;
                case '<': Result.MoveTo(12, 03); break;
                case '=': Result.MoveTo(13, 03); break;
                case '>': Result.MoveTo(14, 03); break;
                case '?': Result.MoveTo(15, 03); break;
                
                // Line 5:
                case '@': Result.MoveTo(00, 04); break;
                case 'A': Result.MoveTo(01, 04); break;
                case 'B': Result.MoveTo(02, 04); break;
                case 'C': Result.MoveTo(03, 04); break;
                case 'D': Result.MoveTo(04, 04); break;
                case 'E': Result.MoveTo(05, 04); break;
                case 'F': Result.MoveTo(06, 04); break;
                case 'G': Result.MoveTo(07, 04); break;
                case 'H': Result.MoveTo(08, 04); break;
                case 'I': Result.MoveTo(09, 04); break;
                case 'J': Result.MoveTo(10, 04); break;
                case 'K': Result.MoveTo(11, 04); break;
                case 'L': Result.MoveTo(12, 04); break;
                case 'M': Result.MoveTo(13, 04); break;
                case 'N': Result.MoveTo(14, 04); break;
                case 'O': Result.MoveTo(15, 04); break;
                
                // Line 6:
                case 'P': Result.MoveTo(00, 05); break;
                case 'Q': Result.MoveTo(01, 05); break;
                case 'R': Result.MoveTo(02, 05); break;
                case 'S': Result.MoveTo(03, 05); break;
                case 'T': Result.MoveTo(04, 05); break;
                case 'U': Result.MoveTo(05, 05); break;
                case 'V': Result.MoveTo(06, 05); break;
                case 'W': Result.MoveTo(07, 05); break;
                case 'X': Result.MoveTo(08, 05); break;
                case 'Y': Result.MoveTo(09, 05); break;
                case 'Z': Result.MoveTo(10, 05); break;
                case '[': Result.MoveTo(11, 05); break;
                case '\\': Result.MoveTo(12, 05); break;
                case ']': Result.MoveTo(13, 05); break;
                case '^': Result.MoveTo(14, 05); break;
                case '_': Result.MoveTo(15, 05); break;
                
                // Line 7:
                //case '\'': Result.MoveTo(00, 06); break;      // we already have this character. Why?!?
                case 'a': Result.MoveTo(01, 06); break;
                case 'b': Result.MoveTo(02, 06); break;
                case 'c': Result.MoveTo(03, 06); break;
                case 'd': Result.MoveTo(04, 06); break;
                case 'e': Result.MoveTo(05, 06); break;
                case 'f': Result.MoveTo(06, 06); break;
                case 'g': Result.MoveTo(07, 06); break;
                case 'h': Result.MoveTo(08, 06); break;
                case 'i': Result.MoveTo(09, 06); break;
                case 'j': Result.MoveTo(10, 06); break;
                case 'k': Result.MoveTo(11, 06); break;
                case 'l': Result.MoveTo(12, 06); break;
                case 'm': Result.MoveTo(13, 06); break;
                case 'n': Result.MoveTo(14, 06); break;
                case 'o': Result.MoveTo(15, 06); break;
                
                // Line 8:
                case 'p': Result.MoveTo(00, 07); break;
                case 'q': Result.MoveTo(01, 07); break;
                case 'r': Result.MoveTo(02, 07); break;
                case 's': Result.MoveTo(03, 07); break;
                case 't': Result.MoveTo(04, 07); break;
                case 'u': Result.MoveTo(05, 07); break;
                case 'v': Result.MoveTo(06, 07); break;
                case 'w': Result.MoveTo(07, 07); break;
                case 'x': Result.MoveTo(08, 07); break;
                case 'y': Result.MoveTo(09, 07); break;
                case 'z': Result.MoveTo(10, 07); break;
                case '{': Result.MoveTo(11, 07); break;
                case '|': Result.MoveTo(12, 07); break;
                case '}': Result.MoveTo(13, 07); break;
                // The new 2 characters don't exists on keyboard :)
                
                // The next 2 lines are graphic drawing characters
                // The next 6 lines are the same characters in yellow/green

                // We don't have an image for this character
                default : Result = null; break;
            }

            return Result;
        }

        private static Point2i MapCharNumberToImage(byte CharNumber)
        {
            Point2i Result = new Point2i();

            byte CharPosX = (byte)(CharNumber % 16);
            byte CharPosY = (byte)(CharNumber / 16);

            Result.MoveTo(CharPosX, CharPosY);

            return Result;
        }

        public static void AnimateCursor()
        {
            GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);

            Draw();

            ulong Random = CPUInfo.ReadTSC() % (CPUInfo.CPUSpeed * 1000000);
            bool DrawCursor = (Random <= CPUInfo.CPUSpeed * 500000);

            if (DrawCursor)
            {
                GL.Begin(GL.GL_QUADS);
                GL.Color4f(1.0f, 1.0f, 1.0f, 1.0f);         // opaque white, not transparent
                GL.Vertex2f(_CursorPosX * 8, _CursorPosY * 8);
                GL.Vertex2f(_CursorPosX * 8, _CursorPosY * 8 + 8);
                GL.Vertex2f(_CursorPosX * 8 + 8, _CursorPosY * 8 + 8);
                GL.Vertex2f(_CursorPosX * 8 + 8, _CursorPosY * 8);
                GL.End();
            }

            FG.SwapBuffers();
        }
    }

    ///////////////////////////////////////////////////////////////////////////
    // CONSOLE LOG MANAGER
    ///////////////////////////////////////////////////////////////////////////

    public class ConsoleLogNode
    {
        public uint LineNumber = 0;
        public DateTime LineTime = DateTime.Now;
        public string Line = null;
    }

    public static class ConsoleLogManager
    {
        private static List<ConsoleLogNode> Log = new List<ConsoleLogNode>();
        private static ConsoleLogNode LineBuffer = new ConsoleLogNode();

        public static void WriteLine()
        {
            if (LineBuffer.Line == null)
            {
                ConsoleLogNode Node = new ConsoleLogNode();

                Node.LineTime = DateTime.Now;
                Node.Line = "";

                Log.Add(Node);

                Node.LineNumber = (uint)Log.Count;
            }
            else
            {
                Log.Add(LineBuffer);

                LineBuffer.LineNumber = (uint)Log.Count;

                LineBuffer = new ConsoleLogNode();
            }
        }

        public static void WriteLine(string Line)
        {
            if (LineBuffer.Line == null)
            {
                ConsoleLogNode Node = new ConsoleLogNode();

                Node.LineTime = DateTime.Now;
                Node.Line = Line;

                Log.Add(Node);

                Node.LineNumber = (uint)Log.Count;
            }
            else
            {
                LineBuffer.Line += Line;

                Log.Add(LineBuffer);

                LineBuffer.LineNumber = (uint)Log.Count;

                LineBuffer = new ConsoleLogNode();
            }
        }

        public static void Write(string Line)
        {
            if (LineBuffer.Line == null)
            {
                LineBuffer.LineTime = DateTime.Now;
                LineBuffer.Line = Line;
            }
            else
            {
                LineBuffer.Line += Line;
            }
        }

        public static string ReadBuffer()
        {
            return LineBuffer.Line;
        }

        public static uint GetBufferLength()
        {
            if (LineBuffer.Line != null)
            {
                return (uint)LineBuffer.Line.Length;
            }
            else
            {
                return 0;
            }
        }

        public static void DeleteBufferChar()
        {
            if (LineBuffer.Line != null)
            {
                if (LineBuffer.Line.Length > 2)
                {
                    LineBuffer.Line = LineBuffer.Line.Substring(0, LineBuffer.Line.Length - 1);
                }
            }
        }

        public static void DumpToFile(string LogFileName)
        {
            LogFileName += ".txt";

            if (File.Exists(LogFileName))
            {
                File.Delete(LogFileName);
            }

            StreamWriter LogFile = File.CreateText(LogFileName);
            
            foreach (ConsoleLogNode Node in Log)
            {
                LogFile.WriteLine("[{0}] {1}", Node.LineTime, Node.Line);
            }

            LogFile.Close();
        }

        public static uint Count
        {
            get
            {
                return (uint)Log.Count;
            }
        }

        public static string GetLineByNumber(uint LineNumber)
        {
            if (LineNumber <= (uint)Log.Count)
            {
                return Log[(int)LineNumber-1].Line;
            }
            else
            {
                return null;
            }
        }
    }
}
