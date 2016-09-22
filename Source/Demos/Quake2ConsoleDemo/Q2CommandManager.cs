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
            AddCommand("stopmusic", 0, "Stops the currently playing music", Command_stopmusic);
            AddCommand("playmusic", 1, "Plays the specified music file", Command_playmusic);
            AddCommand("background", 1, "Changes the console background image", Command_background);

            // Required for audio out and the MP3 stream
            waveOutDevice = new WaveOut();
            audioFileReader = new AudioFileReader(@"Music\" + ConsoleVarManager.GetValueToString("MusicTrack"));

            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
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
            string shader = GL.GetString(GL.GL_SHADING_LANGUAGE_VERSION);

            ConsoleManager.WriteLine("OpenGL information...");
            ConsoleManager.WriteLine("================================================================================");
            ConsoleManager.WriteLine("VENDOR          : " + vendor);
            ConsoleManager.WriteLine("VERSION         : " + version);
            ConsoleManager.WriteLine("RENDERER        : " + renderer);
            ConsoleManager.WriteLine("SHADER LANGUAGE : " + shader);
        }

        private static void Command_cpuinfo(string[] parameters)
        {
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

            ConsoleManager.WriteLine("Feature ACPI        : " + CPUInfo.flagACPI);
            ConsoleManager.WriteLine("Feature AES         : " + CPUInfo.flagAES);
            ConsoleManager.WriteLine("Feature APIC        : " + CPUInfo.flagAPIC);
            ConsoleManager.WriteLine("Feature AVX         : " + CPUInfo.flagAVX);
            ConsoleManager.WriteLine("Feature CLFSH       : " + CPUInfo.flagCLFSH);
            ConsoleManager.WriteLine("Feature CMOV        : " + CPUInfo.flagCMOV);
            ConsoleManager.WriteLine("Feature CNXTID      : " + CPUInfo.flagCNXTID);
            ConsoleManager.WriteLine("Feature CX16        : " + CPUInfo.flagCX16);
            ConsoleManager.WriteLine("Feature CX8         : " + CPUInfo.flagCX8);
            ConsoleManager.WriteLine("Feature DCA         : " + CPUInfo.flagDCA);
            ConsoleManager.WriteLine("Feature DE          : " + CPUInfo.flagDE);
            ConsoleManager.WriteLine("Feature DS          : " + CPUInfo.flagDS);
            ConsoleManager.WriteLine("Feature DS64        : " + CPUInfo.flagDS64);
            ConsoleManager.WriteLine("Feature DSCPL       : " + CPUInfo.flagDSCPL);
            ConsoleManager.WriteLine("Feature ESS         : " + CPUInfo.flagESS);
            ConsoleManager.WriteLine("Feature F16C        : " + CPUInfo.flagF16C);
            ConsoleManager.WriteLine("Feature FMA         : " + CPUInfo.flagFMA);
            ConsoleManager.WriteLine("Feature FPU         : " + CPUInfo.flagFPU);
            ConsoleManager.WriteLine("Feature FSC         : " + CPUInfo.flagFSC);
            ConsoleManager.WriteLine("Feature FXSR        : " + CPUInfo.flagFXSR);
            ConsoleManager.WriteLine("Feature HTT         : " + CPUInfo.flagHTT);
            ConsoleManager.WriteLine("Feature IA64        : " + CPUInfo.flagIA64);
            ConsoleManager.WriteLine("Feature MCA         : " + CPUInfo.flagMCA);
            ConsoleManager.WriteLine("Feature MCE         : " + CPUInfo.flagMCE);
            ConsoleManager.WriteLine("Feature MMX         : " + CPUInfo.flagMMX);
            ConsoleManager.WriteLine("Feature MONITOR     : " + CPUInfo.flagMONITOR);
            ConsoleManager.WriteLine("Feature MOVBE       : " + CPUInfo.flagMOVBE);
            ConsoleManager.WriteLine("Feature MSR         : " + CPUInfo.flagMSR);
            ConsoleManager.WriteLine("Feature MTRR        : " + CPUInfo.flagMTRR);
            ConsoleManager.WriteLine("Feature OSXSAVE     : " + CPUInfo.flagOSXSAVE);
            ConsoleManager.WriteLine("Feature PAE         : " + CPUInfo.flagPAE);
            ConsoleManager.WriteLine("Feature PAT         : " + CPUInfo.flagPAT);
            ConsoleManager.WriteLine("Feature PCID        : " + CPUInfo.flagPCID);
            ConsoleManager.WriteLine("Feature PCLMULQDQ   : " + CPUInfo.flagPCLMULQDQ);
            ConsoleManager.WriteLine("Feature PDCM        : " + CPUInfo.flagPDCM);
            ConsoleManager.WriteLine("Feature PGE         : " + CPUInfo.flagPGE);
            ConsoleManager.WriteLine("Feature POPCNT      : " + CPUInfo.flagPOPCNT);
            ConsoleManager.WriteLine("Feature PSE         : " + CPUInfo.flagPSE);
            ConsoleManager.WriteLine("Feature PSE36       : " + CPUInfo.flagPSE36);
            ConsoleManager.WriteLine("Feature SBF         : " + CPUInfo.flagSBF);
            ConsoleManager.WriteLine("Feature SERIAL      : " + CPUInfo.flagSERIAL);
            ConsoleManager.WriteLine("Feature SMX         : " + CPUInfo.flagSMX);
            ConsoleManager.WriteLine("Feature SS          : " + CPUInfo.flagSS);
            ConsoleManager.WriteLine("Feature SSE         : " + CPUInfo.flagSSE);
            ConsoleManager.WriteLine("Feature SSE2        : " + CPUInfo.flagSSE2);
            ConsoleManager.WriteLine("Feature SSE3        : " + CPUInfo.flagSSE3);
            ConsoleManager.WriteLine("Feature SSE4.1      : " + CPUInfo.flagSSE4_1);
            ConsoleManager.WriteLine("Feature SSE4.2      : " + CPUInfo.flagSSE4_2);
            ConsoleManager.WriteLine("Feature SSSE3       : " + CPUInfo.flagSSSE3);
            ConsoleManager.WriteLine("Feature TM          : " + CPUInfo.flagTM);
            ConsoleManager.WriteLine("Feature TM2         : " + CPUInfo.flagTM2);
            ConsoleManager.WriteLine("Feature TSC         : " + CPUInfo.flagTSC);
            ConsoleManager.WriteLine("Feature TSCDEADLINE : " + CPUInfo.flagTSCDEADLINE);
            ConsoleManager.WriteLine("Feature VME         : " + CPUInfo.flagVME);
            ConsoleManager.WriteLine("Feature VMX         : " + CPUInfo.flagVMX);
            ConsoleManager.WriteLine("Feature X2APIC      : " + CPUInfo.flagX2APIC);
            ConsoleManager.WriteLine("Feature XSAVE       : " + CPUInfo.flagXSAVE);
            ConsoleManager.WriteLine("Feature XTPR        : " + CPUInfo.flagXTPR);
            ConsoleManager.WriteLine();

            if (CPUInfo.VendorCompany == CPUInfo.VendorCompanies.AMD)
            {
                ConsoleManager.WriteLine("Feature SYSCALLSYSRET : " + CPUInfo.flagSYSCALLSYSRET);
                ConsoleManager.WriteLine("Feature NX            : " + CPUInfo.flagNX);
                ConsoleManager.WriteLine("Feature MMXEXT        : " + CPUInfo.flagMMXEXT);
                ConsoleManager.WriteLine("Feature FFXSR         : " + CPUInfo.flagFFXSR);
                ConsoleManager.WriteLine("Feature PAGE1GB       : " + CPUInfo.flagPAGE1GB);
                ConsoleManager.WriteLine("Feature RDTSCP        : " + CPUInfo.flagRDTSCP);
                ConsoleManager.WriteLine("Feature LM            : " + CPUInfo.flagLM);
                ConsoleManager.WriteLine("Feature 3DNOW         : " + CPUInfo.flag3DNOW);
                ConsoleManager.WriteLine("Feature 3DNOWEXT      : " + CPUInfo.flag3DNOWEXT);
                ConsoleManager.WriteLine("Feature LAHFSAHF      : " + CPUInfo.flagLAHFSAHF);
                ConsoleManager.WriteLine("Feature CMPLEGACY     : " + CPUInfo.flagCMPLEGACY);
                ConsoleManager.WriteLine("Feature SVM           : " + CPUInfo.flagSVM);
                ConsoleManager.WriteLine("Feature EXTAPICSPACE  : " + CPUInfo.flagEXTAPICSPACE);
                ConsoleManager.WriteLine("Feature ALTMOVCR8     : " + CPUInfo.flagALTMOVCR8);
                ConsoleManager.WriteLine("Feature ABM           : " + CPUInfo.flagABM);
                ConsoleManager.WriteLine("Feature SSE4A         : " + CPUInfo.flagSSE4A);
                ConsoleManager.WriteLine("Feature MISALIGNSSE   : " + CPUInfo.flagMISALIGNSSE);
                ConsoleManager.WriteLine("Feature 3DNOWPREFETCH : " + CPUInfo.flag3DNOWPREFETCH);
                ConsoleManager.WriteLine("Feature OSVW          : " + CPUInfo.flagOSVW);
                ConsoleManager.WriteLine("Feature IBS           : " + CPUInfo.flagIBS);
                ConsoleManager.WriteLine("Feature XOP           : " + CPUInfo.flagXOP);
                ConsoleManager.WriteLine("Feature SKINIT        : " + CPUInfo.flagSKINIT);
                ConsoleManager.WriteLine("Feature WDT           : " + CPUInfo.flagWDT);
                ConsoleManager.WriteLine("Feature LWP           : " + CPUInfo.flagLWP);
                ConsoleManager.WriteLine("Feature FMA4          : " + CPUInfo.flagFMA4);
                ConsoleManager.WriteLine("Feature NODEID        : " + CPUInfo.flagNODEID);
                ConsoleManager.WriteLine("Feature TBM           : " + CPUInfo.flagTBM);
                ConsoleManager.WriteLine("Feature TOPOLOGYEXT   : " + CPUInfo.flagTOPOLOGYEXT);
                ConsoleManager.WriteLine();
            }

            if (CPUInfo.VendorCompany == CPUInfo.VendorCompanies.Intel)
            {
                ConsoleManager.WriteLine("Feature SYSCALLSYSRET : " + CPUInfo.flagSYSCALLSYSRET);
                ConsoleManager.WriteLine("Feature NX            : " + CPUInfo.flagNX);
                ConsoleManager.WriteLine("Feature PAGE1GB       : " + CPUInfo.flagPAGE1GB);
                ConsoleManager.WriteLine("Feature RDTSCP        : " + CPUInfo.flagRDTSCP);
                ConsoleManager.WriteLine("Feature INTEL64       : " + CPUInfo.flagINTEL64);
                ConsoleManager.WriteLine("Feature LAHFSAHF      : " + CPUInfo.flagLAHFSAHF);
                ConsoleManager.WriteLine();
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
                string ImageFileName = @"data\pics\" + parameters[0];

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
    }
}
