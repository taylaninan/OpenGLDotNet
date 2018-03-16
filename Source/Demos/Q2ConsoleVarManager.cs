// ----------------------------------------------------------------------------
// FILE		: q2consolevarmanager.cs
// VERSION	: 1.1.2
// COMMENT	: This file is part of Quake 2 Console Demo. The Q2ConsoleVarManager
//            (Quake 2 Console Variable Manager) actually holds (creates, reads
//            and changes) the internal variables used by Quake 2 Console.
// WEB      : https://github.com/carmack78/opengldotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : taylaninan@yahoo.com 
// DATE     : 2014-2018
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Common;

namespace Quake2DotNet
{
    ///////////////////////////////////////////////////////////////////////////
    // CONSOLE VARIABLE MANAGER
    ///////////////////////////////////////////////////////////////////////////
    public class ConsoleVarNode
    {
        public string Name;
        public string Value;
        public uint   Flags;
    }

    public static class ConsoleVarManager
    {
        private static Dictionary<string, ConsoleVarNode> ConsoleVars = new Dictionary<string, ConsoleVarNode>();

        public static void Init()
        {
            Create("Q2ConsoleInit", "true", 0);					// When TRUE, Quake 2 Console MUST be initiated.
            Create("VersionLong", "OpenGLDotNet v1.1.2 Demos", 0);
            Create("VersionShort", "v1.1.2", 0);
            Create("ScreenWidth", "1024", 0);
            Create("ScreenHeight", "768", 0);
            Create("ConsoleBackground", "conback2.jpg", 0);
            Create("ConsoleCharacters", "conchars.png", 0);
			Create("DemoFreeglut", "0", 0);
			Create("DemoCubemapping", "0", 0);
			
            Random RandomTrack = new Random();
            int TrackNumber = RandomTrack.Next(1, 10);
            string TrackString = "track" + TrackNumber.ToString().PadLeft(2, '0') + ".mp3";
            Create("MusicTrack", TrackString, 0);
        }

        public static ConsoleVarNode FindVar(string Name)
        {
            if (ConsoleVars.ContainsKey(Name))
            {
                return ConsoleVars[Name];
            }
            else
            {
                return null;
            }
        }

        public static string GetValueToString(string Name)
        {
            ConsoleVarNode Node = FindVar(Name);

            if (Node != null)
            {
                return Node.Value;
            }
            else
            {
                return "";
            }
        }

        public static uint GetValueToUInt(string Name)
        {
            ConsoleVarNode Node = FindVar(Name);

            if (Node != null)
            {
                return ConvertX.ToUInt(Node.Value, 0, "", "trim", 0);
            }
            else
            {
                return 0;
            }
        }

        public static ushort GetValueToUShort(string Name)
        {
            ConsoleVarNode Node = FindVar(Name);

            if (Node != null)
            {
                return ConvertX.ToUShort(Node.Value, 0, "", "trim", 0);
            }
            else
            {
                return 0;
            }
        }

        public static byte GetValueToByte (string Name)
        {
            ConsoleVarNode Node = FindVar(Name);

            if (Node != null)
            {
                return ConvertX.ToByte(Node.Value, 0, "", "trim", 0);
            }
            else
            {
                return 0;
            }
        }
		
        public static ConsoleVarNode Create(string var_name, string var_value, uint flags)
        {
            ConsoleVarNode Result = FindVar(var_name);

            // If the variable not found, then add a new one.
            if (Result == null)
            {
                ConsoleVarNode Node = new ConsoleVarNode();

                Node.Name = var_name;
                Node.Value = var_value;
                Node.Flags = flags;

                ConsoleVars.Add(var_name, Node);

                Result = Node;
            }

            return Result;
        }

        // With flags
        public static ConsoleVarNode Set(string var_name, string var_value, uint flags)
        {
            ConsoleVarNode Result = FindVar(var_name);

            if (Result != null)
            {
                Result.Name = var_name;
                Result.Value = var_value;
                Result.Flags = flags;
            }

            return Result;
        }

        // Without flags
        public static ConsoleVarNode Set(string var_name, string var_value)
        {
            ConsoleVarNode Result = FindVar(var_name);

            if (Result != null)
            {
                Result.Name = var_name;
                Result.Value = var_value;
            }

            return Result;
        }

        public static ConsoleVarNode SetOrCreate(string var_name, string var_value, uint flags)
        {
            ConsoleVarNode Result = FindVar(var_name);

            if (Result == null)
            {
                Result = Create(var_name, var_value, flags);
            }
            else
            {
                Result = Set(var_name, var_value, flags);
            }

            return Result;
        }
    }
}
