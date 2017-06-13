// ----------------------------------------------------------------------------
// FILE		: cpuglinfo.cs
// VERSION	: 1.1.1
// COMMENT	: This file displays cpu and opengl information of the running system
//            in a very detailed way. At the same time writes a text file containing
//            the information showed.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2017
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;
using OpenGLDotNet;

namespace OpenGLDemos
{
    class OpenGLInfo
    {
        public static void WriteCPUInfo()
        {
            GLConfig.LogWriteLine("Vendor String             : " + CPUInfo.VendorString);
            GLConfig.LogWriteLine("Vendor Company            : " + CPUInfo.VendorCompany);
            GLConfig.LogWriteLine("Processor Name            : " + CPUInfo.CPUName.Trim());
            GLConfig.LogWriteLine("Processor Speed           : " + CPUInfo.CPUSpeed + " Mhz");
            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Processor Type            : " + CPUInfo.CPUType);
            GLConfig.LogWriteLine("Processor Family          : " + CPUInfo.CPUFamily);
            GLConfig.LogWriteLine("Processor Extended Family : " + CPUInfo.CPUExtendedFamily);
            GLConfig.LogWriteLine("Processor Model           : " + CPUInfo.CPUModel);
            GLConfig.LogWriteLine("Processor Extended Model  : " + CPUInfo.CPUExtendedModel);
            GLConfig.LogWriteLine("Processor Stepping ID     : " + CPUInfo.CPUStepping);
            GLConfig.LogWriteLine();

            foreach(var CPUFlag in CPUInfo.FeatureFlags)
            {
                GLConfig.LogWriteLine("Feature " + CPUFlag.Key.PadRight(18, ' ') + " : " + CPUFlag.Value);
            }

            GLConfig.LogWriteLine();

            if (CPUInfo.VendorCompany == CPUInfo.VendorCompanies.Intel)
            {
                GLConfig.LogWriteLine("Intel Cache Descriptors : ");
                GLConfig.LogWriteLine("--------------------------");
                for (byte counter = 0; counter < CPUInfo.IntelCacheDescriptors.Count; counter++)
                {
                    GLConfig.LogWriteLine(CPUInfo.IntelCacheDescriptors[counter]);
                }
            }
        }

        public static void Main(string[] args)
        {
            // First, setup the console window
            Console.Title = "OpenGLDotNet v1.1.1";
            Console.WindowHeight = 50;
            Console.WindowWidth = 100;
            Console.SetBufferSize(100, 1000);

            // Then, write CPU Information
            WriteCPUInfo();

            // After that, setup OpenGL window and OpenGL itself
            GLConfig.Init(0, 0, "OpenGL Info v1.1.1", 25, 25, 1024, 768);
            GL.Init(true);

            // Then, write all Log information
            GLConfig.LogWriteToConsole();
            GLConfig.LogWriteToFile("opengl_info_v111.log");

            Console.WriteLine();
            Console.WriteLine("                            _____ PRESS ANY KEY _____");

            ConsoleKeyInfo key = Console.ReadKey(true);
        }
    }
}
