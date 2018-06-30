// ----------------------------------------------------------------------------
// FILE		: q2commandmanager.cs
// VERSION	: 1.1.3
// DATE     : 26 April 2018
// COMMENT	: This file is part of Quake 2 Console Demo. The Q2CommandManager
//			  allows of adding and executing console commands. Try writing "help"
//            on console to list available commands and explanations.
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
using NAudio;
using NAudio.Wave;

namespace Quake2DotNet
{
    public delegate void TCALLBACKCommandProc(string[] Parameters);

    public class CommandNode
    {
        public string Name = null;
        public byte ParamCount = 0;
        public string Help = null;
        public TCALLBACKCommandProc CommandProc = null;
    }

    public static class CommandManager
    {
        private static SortedDictionary<string, CommandNode> Commands = new SortedDictionary<string, CommandNode>();
        private static IWavePlayer waveOutDevice;
        private static AudioFileReader audioFileReader;

        public static void Init()
        {
            AddCommand("cmdlist", 0, "Lists available commands", Command_cmdlist);
            AddCommand("help", 0, "Lists available commands", Command_cmdlist);
            AddCommand("exit", 0, "Exits/Quits the Quake2DotNet", Command_exit);
            AddCommand("quit", 0, "Exits/Quits the Quake2DotNet", Command_exit);
            AddCommand("openglinfo", 0, "Displays short OpenGL information", Command_openglinfo);
            AddCommand("cpuinfo", 0, "Displays detailed CPU information", Command_cpuinfo);
            AddCommand("version", 0, "Displays current Quake2DotNet information", Command_version);
            AddCommand("dumpconsole", 1, "Dumps all the information in console to a text file", Command_dumpconsole);
            AddCommand("playmusic", 1, "Plays the specified music file", Command_playmusic);
            AddCommand("stopmusic", 0, "Stops the currently playing music", Command_stopmusic);
            AddCommand("background", 1, "Changes the console background image", Command_background);
			AddCommand("imagelist", 0, "Displays detailed texture information, which are uploaded to the GPU", Command_imagelist);
            AddCommand("demofreeglut", 0, "When console is closed, displays the FREEGLUT demo with simple objects", Command_demofreeglut);
            AddCommand("democubemapping", 0, "When console is closed, displays the CUBEMAPPING demo", Command_democubemapping);
            AddCommand("demogui", 0, "When console is closed, displays the GUI demo", Command_demogui);			
            // Required for audio out and the MP3 stream
            waveOutDevice = new WaveOut();

            //audioFileReader = new AudioFileReader(@"Music\" + ConsoleVarManager.GetValueToString("MusicTrack"));
            //waveOutDevice.Init(audioFileReader);

            //waveOutDevice.Play();
        }

        private static void AddCommand(string CommandName, byte ArgumentCount, string CommandHelp, TCALLBACKCommandProc CommandProc)
        {
            if (!String.IsNullOrEmpty(CommandName))
            {
                string[] CommandWithParameters = Tokenize(CommandName);
                CommandName = CommandWithParameters[0];

                if (!Commands.ContainsKey(CommandName))
                {
                    CommandNode Node = new CommandNode();

                    Node.Name = CommandName;
                    Node.ParamCount = ArgumentCount;
                    Node.Help = CommandHelp;
                    Node.CommandProc = CommandProc;

                    Commands.Add(CommandName, Node);
                }
            }
        }

        public static void ExecuteCommand(string CommandLine)
        {
            CommandLine = CommandStandardization(CommandLine);

            if (!String.IsNullOrEmpty(CommandLine))
            {
                string[] CommandWithParameters = Tokenize(CommandLine);
                string CommandName = CommandWithParameters[0];
                string[] Parameters = null;

                // If the command with its parameters presents
                if (CommandWithParameters.Length > 1)
                {
                    Parameters = new string[CommandWithParameters.Length - 1];

                    for (ushort Counter = 1; Counter < CommandWithParameters.Length; Counter++)
                    {
                        Parameters[Counter - 1] = CommandWithParameters[Counter];
                    }
                }

                if (Commands.ContainsKey(CommandName))
                {
                    CommandNode Node = Commands[CommandName];

                    if (Node.CommandProc != null)
                    {
                        Node.CommandProc(Parameters);
                    }
                    else
                    {
                        ConsoleManager.WriteLine("Error! Command delegate not defined!");
                    }
                }
                else
                {
                    ConsoleManager.WriteLine("Error! Invalid command!");
                }
            }
        }

        private static string CommandStandardization(string Command)
        {
            // Remove console input characters "> " from the beginning
            if (Command.StartsWith("> "))
            {
                Command = Command.Substring(2).Trim();
            }
            if (Command.StartsWith(">"))
            {
                Command = Command.Substring(1).Trim();
            }

            // Remove whitespace
            while (Command.IndexOf("  ") > 0)
            {
                Command = Command.Replace("  ", " ");
            }

            Command = Command.ToLower();

            return Command;
        }

        private static string[] Tokenize(string Command)
        {
            string[] Tokens = CommandStandardization(Command).Split(' ');

            for (ushort Counter = 0; Counter < Tokens.Length; Counter++)
            {
                Tokens[Counter] = Tokens[Counter].Trim();
            }

            return Tokens;
        }

        private static void Command_cmdlist(string[] parameters)
        {
            ConsoleManager.WriteLine();
            ConsoleManager.WriteLine("Listing available commands...");
            ConsoleManager.WriteLine("================================================================================");

            foreach (CommandNode Node in Commands.Values)
            {
                ConsoleManager.WriteLine(Node.Name.PadRight(16, ' ') + " --> " + Node.Help);
            }
        }

        private static void Command_exit(string[] parameters)
        {
            FG.LeaveMainLoop();            
        }

        private static void Command_openglinfo(string[] parameters)
        {
            string vendor = GL.GetString(GL.GL_VENDOR).Trim();
            string version = GL.GetString(GL.GL_VERSION).Trim();
            string renderer = GL.GetString(GL.GL_RENDERER).Trim();
            string shader = GL.GetString(GL.GL_SHADING_LANGUAGE_VERSION).Trim();

            ConsoleManager.WriteLine();
            ConsoleManager.WriteLine("OpenGL information...");
            ConsoleManager.WriteLine("================================================================================");
            ConsoleManager.WriteLine("VENDOR          : " + vendor);
            ConsoleManager.WriteLine("VERSION         : " + version);
            ConsoleManager.WriteLine("RENDERER        : " + renderer);
            ConsoleManager.WriteLine("SHADER LANGUAGE : " + shader);
        }

        private static void Command_cpuinfo(string[] parameters)
        {
            ConsoleManager.WriteLine();
            ConsoleManager.WriteLine("CPU information...");
            ConsoleManager.WriteLine("================================================================================");
            ConsoleManager.WriteLine("Vendor String             : " + CPUInfo.VendorString);
            ConsoleManager.WriteLine("Vendor Company            : " + CPUInfo.VendorCompany);
            ConsoleManager.WriteLine("Processor Name            : " + CPUInfo.CPUName.Trim());
            ConsoleManager.WriteLine("Processor Speed           : " + CPUInfo.CPUSpeed + " Mhz");

            ConsoleManager.WriteLine();
            ConsoleManager.WriteLine("Processor Type            : " + CPUInfo.CPUType);
            ConsoleManager.WriteLine("Processor Family          : " + CPUInfo.CPUFamily);
            ConsoleManager.WriteLine("Processor Extended Family : " + CPUInfo.CPUExtendedFamily);
            ConsoleManager.WriteLine("Processor Model           : " + CPUInfo.CPUModel);
            ConsoleManager.WriteLine("Processor Extended Model  : " + CPUInfo.CPUExtendedModel);
            ConsoleManager.WriteLine("Processor Stepping ID     : " + CPUInfo.CPUStepping);

            ConsoleManager.WriteLine();
            ConsoleManager.WriteLine("CPU features...");
            ConsoleManager.WriteLine("================================================================================");

            uint Counter = 0;
            string FlagBuffer = null;

            foreach (var CPUFlag in CPUInfo.FeatureFlags)
            {
                if (CPUFlag.Value)
                {
                    Counter++;

                    if ((Counter % 4) == 0)
                    {
                        FlagBuffer += CPUFlag.Key.PadRight(20, ' ');

                        ConsoleManager.WriteLine(FlagBuffer);

                        FlagBuffer = null;
                    }
                    else
                    {
                        FlagBuffer += CPUFlag.Key.PadRight(20, ' ');
                    }
                }
            }

            ConsoleManager.WriteLine(FlagBuffer);

            if (CPUInfo.VendorCompany == CPUInfo.VendorCompanies.Intel)
            {
                ConsoleManager.WriteLine();
                ConsoleManager.WriteLine("CPU cache descriptors... (Intel)");
                ConsoleManager.WriteLine("================================================================================");

                for (byte counter = 0; counter < CPUInfo.IntelCacheDescriptors.Count; counter++)
                {
                    ConsoleManager.WriteLine(CPUInfo.IntelCacheDescriptors[counter]);
                }
            }
        }

        private static void Command_version(string[] parameters)
        {
            ConsoleManager.WriteLine(ConsoleVarManager.GetValueToString("VersionLong"));
        }

        private static void Command_dumpconsole(string[] parameters)
        {
            if (parameters == null || parameters.Length != 1)
            {
                ConsoleManager.WriteLine("HELP: dumpconsole <textfilename>.txt");
            }
            else
            {
                ConsoleLogManager.DumpToFile(parameters[0]);
            }
        }

        private static void Command_stopmusic(string[] parameters)
        {
            waveOutDevice.Stop();
        }

        private static void Command_playmusic(string[] parameters)
        {
            if (parameters == null || parameters.Length != 1)
            {
                ConsoleManager.WriteLine("HELP: playmusic <trackname>.mp3");
            }
            else
            {
                string MP3FileName = @"Music\" + parameters[0] + ".mp3";
                
                if (File.Exists(MP3FileName))
                {
                    if (waveOutDevice.PlaybackState == PlaybackState.Playing || waveOutDevice.PlaybackState == PlaybackState.Paused)
                    {
                        waveOutDevice.Stop();
                    }

                    audioFileReader = new AudioFileReader(@"Music\" + parameters[0] + ".mp3");
                    waveOutDevice.Init(audioFileReader);

                    waveOutDevice.Play();
                }
                else
                {
                    ConsoleManager.WriteLine("Error! The specified music track not found!");
                }
            }
        }

        private static void Command_background(string[] parameters)
        {
            if (parameters == null || parameters.Length != 1)
            {
                ConsoleManager.WriteLine("HELP: background <imagefilename>");
            }
            else
            {
                string ImageFileName = @"data\" + parameters[0];

                if (File.Exists(ImageFileName))
                {
                    ConsoleVarManager.Set("ConsoleBackground", ImageFileName);
                    ConsoleManager.Init();
                }
                else
                {
                    ConsoleManager.WriteLine("Error! The specified background image not found!");
                }
            }
        }
		
		private static void Command_imagelist(string[] parameters)
		{
            uint MemoryUsage = 0;

            foreach (var Node in TextureManager.GetValues)
            {
                MemoryUsage += Node.DataSize;

                ConsoleManager.WriteLine(Node.FilePath.PadRight(32) + Node.DataSize.ToString().PadLeft(12) + " bytes.");
            }

            ConsoleManager.WriteLine("TOTAL MEMORY USAGE".PadRight(32) + MemoryUsage.ToString().PadLeft(12) + " bytes.");
		}

        private static void Command_demofreeglut(string[] parameters)
        {
            byte DemoFreeglut = ConsoleVarManager.GetValueToByte("DemoFreeglut");

            if (DemoFreeglut == 0)
            {   // Start demo; Make sure that the other demos are stopped
                ConsoleVarManager.SetOrCreate("DemoFreeglut", "1", 0);
                ConsoleVarManager.SetOrCreate("DemoCubemapping", "0", 0);
                ConsoleVarManager.SetOrCreate("DemoGUI", "0", 0);

                ConsoleManager.WriteLine("Starting demo FREEGLUT...");
            }
            else
            {   // Stop demo;
                ConsoleVarManager.SetOrCreate("DemoFreeglut", "0", 0);
                ConsoleVarManager.SetOrCreate("DemoCubemapping", "0", 0);
                ConsoleVarManager.SetOrCreate("DemoGUI", "0", 0);

                ConsoleManager.WriteLine("Stopping demo FREEGLUT...");
            }
        }

        private static void Command_democubemapping(string[] parameters)
        {
            byte DemoCubemapping = ConsoleVarManager.GetValueToByte("DemoCubemapping");

            if (DemoCubemapping == 0)
            {   // Start demo; Make sure that the other demos are stopped
                ConsoleVarManager.SetOrCreate("DemoFreeglut", "0", 0);
                ConsoleVarManager.SetOrCreate("DemoCubemapping", "1", 0);
                ConsoleVarManager.SetOrCreate("DemoGUI", "0", 0);
                ConsoleManager.WriteLine("Starting demo CUBEMAPPING...");
            }
            else
            {   // Stop demo;
                ConsoleVarManager.SetOrCreate("DemoFreeglut", "0", 0);
                ConsoleVarManager.SetOrCreate("DemoCubemapping", "0", 0);
                ConsoleVarManager.SetOrCreate("DemoGUI", "0", 0);

                ConsoleManager.WriteLine("Stopping demo CUBEMAPPING...");
            }
        }

        private static void Command_demogui(string[] parameters)
        {
            byte DemoGUI = ConsoleVarManager.GetValueToByte("DemoGUI");

            if (DemoGUI == 0)
            {   // Start demo; Make sure that the other demos are stopped
                ConsoleVarManager.SetOrCreate("DemoFreeglut", "0", 0);
                ConsoleVarManager.SetOrCreate("DemoCubemapping", "0", 0);
                ConsoleVarManager.SetOrCreate("DemoGUI", "1", 0);

                ConsoleManager.WriteLine("Starting demo GUI...");
            }
            else
            {   // Stop demo;
                ConsoleVarManager.SetOrCreate("DemoCubemapping", "0", 0);
                ConsoleVarManager.SetOrCreate("DemoFreeglut", "0", 0);
                ConsoleVarManager.SetOrCreate("DemoGUI", "0", 0);

                ConsoleManager.WriteLine("Stopping demo GUI...");
            }
        }
    }
}
