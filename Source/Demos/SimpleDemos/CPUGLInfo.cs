// ----------------------------------------------------------------------------
// FILE		: cpuglinfo.cs
// VERSION	: 1.1.0
// COMMENT	: This file displays cpu and opengl information of the running system
//            in a very detailed way. At the same time writes a text file containing
//            the information showed.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2016
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

            GLConfig.LogWriteLine("Feature ACPI        : " + CPUInfo.flagACPI);
            GLConfig.LogWriteLine("Feature AES         : " + CPUInfo.flagAES);
            GLConfig.LogWriteLine("Feature APIC        : " + CPUInfo.flagAPIC);
            GLConfig.LogWriteLine("Feature AVX         : " + CPUInfo.flagAVX);
            GLConfig.LogWriteLine("Feature CLFSH       : " + CPUInfo.flagCLFSH);
            GLConfig.LogWriteLine("Feature CMOV        : " + CPUInfo.flagCMOV);
            GLConfig.LogWriteLine("Feature CNXTID      : " + CPUInfo.flagCNXTID);
            GLConfig.LogWriteLine("Feature CX16        : " + CPUInfo.flagCX16);
            GLConfig.LogWriteLine("Feature CX8         : " + CPUInfo.flagCX8);
            GLConfig.LogWriteLine("Feature DCA         : " + CPUInfo.flagDCA);
            GLConfig.LogWriteLine("Feature DE          : " + CPUInfo.flagDE);
            GLConfig.LogWriteLine("Feature DS          : " + CPUInfo.flagDS);
            GLConfig.LogWriteLine("Feature DS64        : " + CPUInfo.flagDS64);
            GLConfig.LogWriteLine("Feature DSCPL       : " + CPUInfo.flagDSCPL);
            GLConfig.LogWriteLine("Feature ESS         : " + CPUInfo.flagESS);
            GLConfig.LogWriteLine("Feature F16C        : " + CPUInfo.flagF16C);
            GLConfig.LogWriteLine("Feature FMA         : " + CPUInfo.flagFMA);
            GLConfig.LogWriteLine("Feature FPU         : " + CPUInfo.flagFPU);
            GLConfig.LogWriteLine("Feature FSC         : " + CPUInfo.flagFSC);
            GLConfig.LogWriteLine("Feature FXSR        : " + CPUInfo.flagFXSR);
            GLConfig.LogWriteLine("Feature HTT         : " + CPUInfo.flagHTT);
            GLConfig.LogWriteLine("Feature IA64        : " + CPUInfo.flagIA64);
            GLConfig.LogWriteLine("Feature MCA         : " + CPUInfo.flagMCA);
            GLConfig.LogWriteLine("Feature MCE         : " + CPUInfo.flagMCE);
            GLConfig.LogWriteLine("Feature MMX         : " + CPUInfo.flagMMX);
            GLConfig.LogWriteLine("Feature MONITOR     : " + CPUInfo.flagMONITOR);
            GLConfig.LogWriteLine("Feature MOVBE       : " + CPUInfo.flagMOVBE);
            GLConfig.LogWriteLine("Feature MSR         : " + CPUInfo.flagMSR);
            GLConfig.LogWriteLine("Feature MTRR        : " + CPUInfo.flagMTRR);
            GLConfig.LogWriteLine("Feature OSXSAVE     : " + CPUInfo.flagOSXSAVE);
            GLConfig.LogWriteLine("Feature PAE         : " + CPUInfo.flagPAE);
            GLConfig.LogWriteLine("Feature PAT         : " + CPUInfo.flagPAT);
            GLConfig.LogWriteLine("Feature PCID        : " + CPUInfo.flagPCID);
            GLConfig.LogWriteLine("Feature PCLMULQDQ   : " + CPUInfo.flagPCLMULQDQ);
            GLConfig.LogWriteLine("Feature PDCM        : " + CPUInfo.flagPDCM);
            GLConfig.LogWriteLine("Feature PGE         : " + CPUInfo.flagPGE);
            GLConfig.LogWriteLine("Feature POPCNT      : " + CPUInfo.flagPOPCNT);
            GLConfig.LogWriteLine("Feature PSE         : " + CPUInfo.flagPSE);
            GLConfig.LogWriteLine("Feature PSE36       : " + CPUInfo.flagPSE36);
            GLConfig.LogWriteLine("Feature SBF         : " + CPUInfo.flagSBF);
            GLConfig.LogWriteLine("Feature SERIAL      : " + CPUInfo.flagSERIAL);
            GLConfig.LogWriteLine("Feature SMX         : " + CPUInfo.flagSMX);
            GLConfig.LogWriteLine("Feature SS          : " + CPUInfo.flagSS);
            GLConfig.LogWriteLine("Feature SSE         : " + CPUInfo.flagSSE);
            GLConfig.LogWriteLine("Feature SSE2        : " + CPUInfo.flagSSE2);
            GLConfig.LogWriteLine("Feature SSE3        : " + CPUInfo.flagSSE3);
            GLConfig.LogWriteLine("Feature SSE4.1      : " + CPUInfo.flagSSE4_1);
            GLConfig.LogWriteLine("Feature SSE4.2      : " + CPUInfo.flagSSE4_2);
            GLConfig.LogWriteLine("Feature SSSE3       : " + CPUInfo.flagSSSE3);
            GLConfig.LogWriteLine("Feature TM          : " + CPUInfo.flagTM);
            GLConfig.LogWriteLine("Feature TM2         : " + CPUInfo.flagTM2);
            GLConfig.LogWriteLine("Feature TSC         : " + CPUInfo.flagTSC);
            GLConfig.LogWriteLine("Feature TSCDEADLINE : " + CPUInfo.flagTSCDEADLINE);
            GLConfig.LogWriteLine("Feature VME         : " + CPUInfo.flagVME);
            GLConfig.LogWriteLine("Feature VMX         : " + CPUInfo.flagVMX);
            GLConfig.LogWriteLine("Feature X2APIC      : " + CPUInfo.flagX2APIC);
            GLConfig.LogWriteLine("Feature XSAVE       : " + CPUInfo.flagXSAVE);
            GLConfig.LogWriteLine("Feature XTPR        : " + CPUInfo.flagXTPR);
            GLConfig.LogWriteLine();

            if (CPUInfo.VendorCompany == CPUInfo.VendorCompanies.AMD)
            {
                GLConfig.LogWriteLine("Feature SYSCALLSYSRET : " + CPUInfo.flagSYSCALLSYSRET);
                GLConfig.LogWriteLine("Feature NX            : " + CPUInfo.flagNX);
                GLConfig.LogWriteLine("Feature MMXEXT        : " + CPUInfo.flagMMXEXT);
                GLConfig.LogWriteLine("Feature FFXSR         : " + CPUInfo.flagFFXSR);
                GLConfig.LogWriteLine("Feature PAGE1GB       : " + CPUInfo.flagPAGE1GB);
                GLConfig.LogWriteLine("Feature RDTSCP        : " + CPUInfo.flagRDTSCP);
                GLConfig.LogWriteLine("Feature LM            : " + CPUInfo.flagLM);
                GLConfig.LogWriteLine("Feature 3DNOW         : " + CPUInfo.flag3DNOW);
                GLConfig.LogWriteLine("Feature 3DNOWEXT      : " + CPUInfo.flag3DNOWEXT);
                GLConfig.LogWriteLine("Feature LAHFSAHF      : " + CPUInfo.flagLAHFSAHF);
                GLConfig.LogWriteLine("Feature CMPLEGACY     : " + CPUInfo.flagCMPLEGACY);
                GLConfig.LogWriteLine("Feature SVM           : " + CPUInfo.flagSVM);
                GLConfig.LogWriteLine("Feature EXTAPICSPACE  : " + CPUInfo.flagEXTAPICSPACE);
                GLConfig.LogWriteLine("Feature ALTMOVCR8     : " + CPUInfo.flagALTMOVCR8);
                GLConfig.LogWriteLine("Feature ABM           : " + CPUInfo.flagABM);
                GLConfig.LogWriteLine("Feature SSE4A         : " + CPUInfo.flagSSE4A);
                GLConfig.LogWriteLine("Feature MISALIGNSSE   : " + CPUInfo.flagMISALIGNSSE);
                GLConfig.LogWriteLine("Feature 3DNOWPREFETCH : " + CPUInfo.flag3DNOWPREFETCH);
                GLConfig.LogWriteLine("Feature OSVW          : " + CPUInfo.flagOSVW);
                GLConfig.LogWriteLine("Feature IBS           : " + CPUInfo.flagIBS);
                GLConfig.LogWriteLine("Feature XOP           : " + CPUInfo.flagXOP);
                GLConfig.LogWriteLine("Feature SKINIT        : " + CPUInfo.flagSKINIT);
                GLConfig.LogWriteLine("Feature WDT           : " + CPUInfo.flagWDT);
                GLConfig.LogWriteLine("Feature LWP           : " + CPUInfo.flagLWP);
                GLConfig.LogWriteLine("Feature FMA4          : " + CPUInfo.flagFMA4);
                GLConfig.LogWriteLine("Feature NODEID        : " + CPUInfo.flagNODEID);
                GLConfig.LogWriteLine("Feature TBM           : " + CPUInfo.flagTBM);
                GLConfig.LogWriteLine("Feature TOPOLOGYEXT   : " + CPUInfo.flagTOPOLOGYEXT);
                GLConfig.LogWriteLine();
            }

            if (CPUInfo.VendorCompany == CPUInfo.VendorCompanies.Intel)
            {
                GLConfig.LogWriteLine("Feature SYSCALLSYSRET : " + CPUInfo.flagSYSCALLSYSRET);
                GLConfig.LogWriteLine("Feature NX            : " + CPUInfo.flagNX);
                GLConfig.LogWriteLine("Feature PAGE1GB       : " + CPUInfo.flagPAGE1GB);
                GLConfig.LogWriteLine("Feature RDTSCP        : " + CPUInfo.flagRDTSCP);
                GLConfig.LogWriteLine("Feature INTEL64       : " + CPUInfo.flagINTEL64);
                GLConfig.LogWriteLine("Feature LAHFSAHF      : " + CPUInfo.flagLAHFSAHF);
                GLConfig.LogWriteLine();
            }

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
            Console.Title = "OpenGLDotNet v1.1.0";
            Console.WindowHeight = 50;
            Console.WindowWidth = 100;
            Console.SetBufferSize(100, 1000);

            // Then, write CPU Information
            WriteCPUInfo();

            // After that, setup OpenGL window and OpenGL itself
            GLConfig.Init(0, 0, "OpenGL Info v1.1.0", 25, 25, 1024, 768);
            GL.Init(true);

            // Then, write all Log information
            GLConfig.LogWriteToConsole();
            GLConfig.LogWriteToFile("opengl_info_v110.txt");

            Console.WriteLine();
            Console.WriteLine("                            _____ PRESS ANY KEY _____");

            ConsoleKeyInfo key = Console.ReadKey(true);
        }
    }
}

