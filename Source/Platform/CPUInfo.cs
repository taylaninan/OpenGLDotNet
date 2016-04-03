using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Microsoft.Win32;
using Common;

namespace OpenGLDotNet
{
    public static class CPUInfo
    {
        [DllImport("assembler.dll", CallingConvention = CallingConvention.StdCall, EntryPoint="_cpuid")]
        private static extern void __cpuid(uint function);
        [DllImport("assembler.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "_rdtsc")]
        private static extern void __rdtsc();
        [DllImport("assembler.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "_reg_eax")]
        private static extern uint __reg_eax();
        [DllImport("assembler.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "_reg_ebx")]
        private static extern uint __reg_ebx();
        [DllImport("assembler.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "_reg_ecx")]
        private static extern uint __reg_ecx();
        [DllImport("assembler.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "_reg_edx")]
        private static extern uint __reg_edx();

        public enum VendorCompanies : byte
        {
            Unknown = 0,
            AMD = 1,
            Centaur = 2,
            Cyrix = 3,
            Intel = 4,
            NationalSemiconductor = 5,
            NexGen = 6,
            Rise = 7,
            SiS = 8,
            Transmeta = 9,
            UMC = 10,
            VIA = 11,
            Vortex = 12
        }

        // Returned in CPUID(1).EDX
        private enum IntelFeatureFlags1 : uint
        {
            FPU = ValueX.Bits.Bit00,			        // Bit 00 = Floating point on chip
            VME = ValueX.Bits.Bit01,			        // Bit 01 = Virtual Mode Extension
            DE = ValueX.Bits.Bit02,		                // Bit 02 = Debugging Extension
            PSE = ValueX.Bits.Bit03,			        // Bit 03 = Page Size Extension
            TSC = ValueX.Bits.Bit04,			        // Bit 04 = Time Stamp Counter
            MSR = ValueX.Bits.Bit05,			        // Bit 05 = Model Specific Registers
            PAE = ValueX.Bits.Bit06,			        // Bit 06 = Physical Address Extension
            MCE = ValueX.Bits.Bit07,			        // Bit 07 = Machine Check Exception
            CX8 = ValueX.Bits.Bit08,			        // Bit 08 = CMPXCHG8 Instruction Support
            APIC = ValueX.Bits.Bit09,		            // Bit 09 = APIC Support
            // Bit 10 = Reserved
            FSC = ValueX.Bits.Bit11,			        // Bit 11 = Fast System Call
            MTRR = ValueX.Bits.Bit12,		            // Bit 12 = Memory Type Range Registers
            PGE = ValueX.Bits.Bit13,			        // Bit 13 = Page Global Enable
            MCA = ValueX.Bits.Bit14,			        // Bit 14 = Machine Check Architecture
            CMOV = ValueX.Bits.Bit15,		            // Bit 15 = Conditional Move Instruction Support
            PAT = ValueX.Bits.Bit16,			        // Bit 16 = Page Attribute Table
            PSE36 = ValueX.Bits.Bit17,		            // Bit 17 = 36bit Page Size Extension
            SERIAL = ValueX.Bits.Bit18,		            // Bit 18 = Processor Serial Number
            CLFSH = ValueX.Bits.Bit19,                  // Bit 19 = CLFLUSH Instruction Support
            // Bit 20 = Reserved
            DS = ValueX.Bits.Bit21,			            // Bit 21 = Debug Store
            ACPI = ValueX.Bits.Bit22,		            // Bit 22 = CPU Thermal and Speed Control
            MMX = ValueX.Bits.Bit23,			        // Bit 23 = MMX Support
            FXSR = ValueX.Bits.Bit24,		            // Bit 24 = Fast Floating Point Save and Restore
            SSE = ValueX.Bits.Bit25,			        // Bit 25 = Streaming SIMD Support
            SSE2 = ValueX.Bits.Bit26,		            // Bit 26 = Streaming SIMD 2 Support
            SS = ValueX.Bits.Bit27,			            // Bit 27 = Self-Snoop
            HTT = ValueX.Bits.Bit28,			        // Bit 28 = Hyper-Threading Technology
            TM = ValueX.Bits.Bit29,			            // Bit 29 = Thermal Monitor
            IA64 = ValueX.Bits.Bit30,                   // Bit 30 = IA64 Processor Emulating x86
            SBF = ValueX.Bits.Bit31		                // Bit 31 = Signal Break on FERR
        }

        // Returned by CPUID(1).ECX
        private enum IntelFeatureFlags2 : uint
        {
            SSE3 = ValueX.Bits.Bit00,                   // Bit 00 = SSE3
            PCLMULQDQ = ValueX.Bits.Bit01,              // Bit 01 = PCLMULQDQ Support
            DS64 = ValueX.Bits.Bit02,                   // Bit 02 = Debug Store 64bit
            MONITOR = ValueX.Bits.Bit03,                // Bit 03 = MONITOR and MWAIT instructions
            DSCPL = ValueX.Bits.Bit04,                  // Bit 04 = Debug Store CPL Qualified
            VMX = ValueX.Bits.Bit05,                    // Bit 05 = Virtual Machine eXtensions
            SMX = ValueX.Bits.Bit06,                    // Bit 06 = Safer Mode Extensions
            ESS = ValueX.Bits.Bit07,                    // Bit 07 = Enhanced SpeedStep
            TM2 = ValueX.Bits.Bit08,                    // Bit 08 = Thermal Monitor 2
            SSSE3 = ValueX.Bits.Bit09,                  // Bit 09 = Supplemental SSE3
            CNXTID = ValueX.Bits.Bit10,                 // Bit 10 = L1 Context ID
            // Bit 11 = Reserved
            FMA = ValueX.Bits.Bit12,                    // Bit 12 = Fused Multiply Add
            CX16 = ValueX.Bits.Bit13,                   // Bit 13 = CMPXCHG16B
            XTPR = ValueX.Bits.Bit14,                   // Bit 14 = XTPR Update Control
            PDCM = ValueX.Bits.Bit15,                   // Bit 15 = Perfmon and Debug Capability
            // Bit 16 = Reserved
            PCID = ValueX.Bits.Bit17,                   // Bit 17 = Process Context Identifiers
            DCA = ValueX.Bits.Bit18,                    // Bit 18 = Direct Cache Access
            SSE4_1 = ValueX.Bits.Bit19,                 // Bit 19 = SSE4.1
            SSE4_2 = ValueX.Bits.Bit20,                 // Bit 20 = SSE4.2
            X2APIC = ValueX.Bits.Bit21,                 // Bit 21 = Extended xAPIC Support
            MOVBE = ValueX.Bits.Bit22,                  // Bit 22 = MOVBE Instruction
            POPCNT = ValueX.Bits.Bit23,                 // Bit 23 = POPCNT Instruction
            TSCDEADLINE = ValueX.Bits.Bit24,            // Bit 24 = Time Stamp Counter Deadline
            AES = ValueX.Bits.Bit25,                    // Bit 25 = AES Instruction Extensions
            XSAVE = ValueX.Bits.Bit26,                  // Bit 26 = XSAVE/XSTOR States
            OSXSAVE = ValueX.Bits.Bit27,                // Bit 27 = OS-Enabled Extended State Management
            AVX = ValueX.Bits.Bit28,                    // Bit 28 = Advanced Vector Extensions
            F16C = ValueX.Bits.Bit29                    // Bit 29 = Half-Precision Convert
            // Bit 30 = Reserved
            // Bit 31 = Not Used
        }

        // Returned in CPUID(0x80000001).EDX (Intel)
        private enum IntelExtendedFeatureFlags1 : uint
        {
            // Bits 00-10 = Reserved
            SYSCALLSYSRET = ValueX.Bits.Bit11,          // Bit 11 = The processor supports the SYSCALL and SYSRET instructions
            // Bits 12-19 = Reserved
            NX = ValueX.Bits.Bit20,                     // Bit 20 = Execution Disable Bit
            // Bits 21-25 = Reserved
            PAGE1GB = ValueX.Bits.Bit26,                // Bit 26 = The processor supports 1-GB pages
            RDTSCP = ValueX.Bits.Bit27,                 // Bit 27 = The processor supports RDTSCP and IA32_TSC_AUX
            // Bit 28 = Reserved
            INTEL64 = ValueX.Bits.Bit29,                // Bit 29 = The processor supports Intel® 64 Architecture extensions to the IA-32 Architecture
            // Bit 30 = Reserved
            // Bit 31 = Reserved
        }

        // Returned in CPUID(0x80000001).ECX (Intel)
        private enum IntelExtendedFeatureFlags2 : uint
        {
            LAHFSAHF = ValueX.Bits.Bit00,               // Bit 00 = LAHF and SAHF instruction support
            // Bits 01-31 = Reserved
        }

        // Returned in CPUID(0x80000001).EDX (AMD)
        private enum AMDExtendedFeatureFlags1 : uint
        {
            // Bit 00 = FPU, same as CPUID(1).EDX
            // Bit 01 = VME, same as CPUID(1).EDX
            // Bit 02 = DE, same as CPUID(1).EDX
            // Bit 03 = PSE, same as CPUID(1).EDX
            // Bit 04 = TSC, same as CPUID(1).EDX
            // Bit 05 = MSR, same as CPUID(1).EDX
            // Bit 06 = PAE, same as CPUID(1).EDX
            // Bit 07 = MCE, same as CPUID(1).EDX
            // Bit 08 = CMPXCHG8B, same as CPUID(1).EDX
            // Bit 09 = APIC, same as CPUID(1).EDX
            // Bit 10 = Reserved
            SYSCALLSYSRET = ValueX.Bits.Bit11,          // Bit 11 = SYSCALL and SYSRET instructions
            // Bit 12 = MTRR, same as CPUID(1).EDX
            // Bit 13 = PGE, same as CPUID(1).EDX
            // Bit 14 = MCA, same as CPUID(1).EDX
            // Bit 15 = CMOV, same as CPUID(1).EDX
            // Bit 16 = PAT, same as CPUID(1).EDX
            // Bit 17 = PSE36, same as CPUID(1).EDX
            // Bit 18 = Reserved
            // Bit 19 = Reserved
            NX = ValueX.Bits.Bit20,                     // Bit 20 = No Execute page protection
            // Bit 21 = Reserved
            MMXEXT = ValueX.Bits.Bit22,                 // Bit 22 = AMD MMX Extensions
            // Bit 23 = MMX, same as CPUID(1).EDX
            // Bit 24 = FXSR, same as CPUID(1).EDX
            FFXSR = ValueX.Bits.Bit25,                  // Bit 25 = Fast FXSR
            PAGE1GB = ValueX.Bits.Bit26,                // Bit 26 = 1 GB large page support
            RDTSCP = ValueX.Bits.Bit27,                 // Bit 27 = RDTSCP instruction support
            // Bit 28 = Reserved
            LM = ValueX.Bits.Bit29,                     // Bit 29 = Long Mode
            THREEDNOWEXT = ValueX.Bits.Bit30,           // Bit 30 = 3DNOW! Extension Instructions
            THREEDNOW = ValueX.Bits.Bit31               // Bit 31 = 3DNOW! Instructions
        }

        // Returned in CPUID(0x80000001).ECX (AMD)
        private enum AMDExtendedFeatureFlags2 : uint
        {
            LAHFSAHF = ValueX.Bits.Bit00,               // Bit 00 = LAHF and SAHF instruction support in 64-bit mode
            CMPLEGACY = ValueX.Bits.Bit01,              // Bit 01 = Core multi-processing legacy mode
            SVM = ValueX.Bits.Bit02,                    // Bit 02 = Secure Virtual Machine
            EXTAPICSPACE = ValueX.Bits.Bit03,           // Bit 03 = extended APIC space
            ALTMOVCR8 = ValueX.Bits.Bit04,              // Bit 04 = LOCK MOV CR0 means MOV CR8
            ABM = ValueX.Bits.Bit05,                    // Bit 05 = advanced bit manipulation. LZCNT instruction support
            SSE4A = ValueX.Bits.Bit06,                  // Bit 06 = EXTRQ, INSERTQ, MOVNTSS, and MOVNTSD instruction support
            MISALIGNSSE = ValueX.Bits.Bit07,            // Bit 07 = misaligned SSE mode
            THREEDNOWPREFETCH = ValueX.Bits.Bit08,      // Bit 08 = 3DNowPrefetch
            OSVW = ValueX.Bits.Bit09,                   // Bit 09 = OS visible workaround
            IBS = ValueX.Bits.Bit10,                    // Bit 10 = instruction based sampling
            XOP = ValueX.Bits.Bit11,                    // Bit 11 = extended operation support
            SKINIT = ValueX.Bits.Bit12,                 // Bit 12 = SKINIT and STGI are supported
            WDT = ValueX.Bits.Bit13,                    // Bit 13 = watchdog timer support
            // Bit 14 = Reserved
            LWP = ValueX.Bits.Bit15,                    // Bit 15 = lightweight profiling support
            FMA4 = ValueX.Bits.Bit16,                   // Bit 16 = 4-operand FMA instruction support
            // Bit 17 = Reserved
            // Bit 18 = Reserved
            NODEID = ValueX.Bits.Bit19,                 // Bit 19 = Indicates support for MSRC001_100C[NodeId, NodesPerProcessor]
            // Bit 20 = Reserved
            TBM = ValueX.Bits.Bit21,                    // Bit 21 = trailing bit manipulation instruction
            TOPOLOGYEXT = ValueX.Bits.Bit22             // Bit 22 = topology extensions support
            // Bit 23 = Reserved
            // Bit 24 = Reserved
            // Bit 25 = Reserved
            // Bit 26 = Reserved
            // Bit 27 = Reserved
            // Bit 28 = Reserved
            // Bit 29 = Reserved
            // Bit 30 = Reserved
            // Bit 31 = Reserved
        }

        private static Dictionary<byte, string> IntelCacheDefinitions = new Dictionary<byte, string>() 
        { 
            {0x00, "Null Descriptor, this byte contains no information"},
            {0x01, "Instruction TLB: 4-KB Pages, 4-way set associative, 32 entries"},
            {0x02, "Instruction TLB: 4-MB Pages, fully associative, 2 entries"},
            {0x03, "Data TLB: 4-KB Pages, 4-way set associative, 64 entries"},
            {0x04, "Data TLB: 4-MB Pages, 4-way set associative, 8 entries"},
            {0x05, "Data TLB: 4-MB Pages, 4-way set associative, 32 entries"},
            {0x06, "1st-level instruction cache: 8-KB, 4-way set associative, 32-byte line size"},
            {0x08, "1st-level instruction cache: 16-KB, 4-way set associative, 32-byte line size"},
            {0x09, "1st-level Instruction Cache: 32-KB, 4-way set associative, 64-byte line size"},
            {0x0A, "1st-level data cache: 8-KB, 2-way set associative, 32-byte line size"},
            {0x0B, "Instruction TLB: 4-MB pages, 4-way set associative, 4 entries"},
            {0x0C, "1st-level data cache: 16-KB, 4-way set associative, 32-byte line size"},
            {0x0D, "1st-level Data Cache: 16-KB, 4-way set associative, 64-byte line size, ECC"},
            {0x0E, "1st-level Data Cache: 24-KB, 6-way set associative, 64-byte line size, ECC"},
            {0x21, "2nd-level cache: 256-KB, 8-way set associative, 64-byte line size"},
            {0x22, "3rd-level cache: 512-KB, 4-way set associative, sectored cache, 64-byte line size"},
            {0x23, "3rd-level cache: 1-MB, 8-way set associative, sectored cache, 64-byte line size"},
            {0x25, "3rd-level cache: 2-MB, 8-way set associative, sectored cache, 64-byte line size"},
            {0x29, "3rd-level cache: 4-MB, 8-way set associative, sectored cache, 64-byte line size"},
            {0x2C, "1st-level data cache: 32-KB, 8-way set associative, 64-byte line size"},
            {0x30, "1st-level instruction cache: 32-KB, 8-way set associative, 64-byte line size"},
            {0x40, "No 2nd-level cache or, if processor contains a valid 2nd-level cache, no 3rd-level cache"},
            {0x41, "2nd-level cache: 128-KB, 4-way set associative, 32-byte line size"},
            {0x42, "2nd-level cache: 256-KB, 4-way set associative, 32-byte line size"},
            {0x43, "2nd-level cache: 512-KB, 4-way set associative, 32-byte line size"},
            {0x44, "2nd-level cache: 1-MB, 4-way set associative, 32-byte line size"},
            {0x45, "2nd-level cache: 2-MB, 4-way set associative, 32-byte line size"},
            {0x46, "3rd-level cache: 4-MB, 4-way set associative, 64-byte line size"},
            {0x47, "3rd-level cache: 8-MB, 8-way set associative, 64-byte line size"},
            {0x48, "2nd-level cache: 3-MB, 12-way set associative, 64-byte line size, unified on-die"},
            {0x49, "2nd-level cache: 4-MB, 16-way set associative, 64-byte line size"},
            {0x4A, "3rd-level cache: 6-MB, 12-way set associative, 64-byte line size"},
            {0x4B, "3rd-level cache: 8-MB, 16-way set associative, 64-byte line size"},
            {0x4C, "3rd-level cache: 12-MB, 12-way set associative, 64-byte line size"},
            {0x4D, "3rd-level cache: 16-MB, 16-way set associative, 64-byte line size"},
            {0x4E, "2nd-level cache: 6-MB, 24-way set associative, 64-byte line size"},
            {0x4F, "Instruction TLB: 4-KB pages, 32 entries"},
            {0x50, "Instruction TLB: 4-KB, 2-MB or 4-MB pages, fully associative, 64 entries"},
            {0x51, "Instruction TLB: 4-KB, 2-MB or 4-MB pages, fully associative, 128 entries"},
            {0x52, "Instruction TLB: 4-KB, 2-MB or 4-MB pages, fully associative, 256 entries"},
            {0x55, "Instruction TLB: 2-MB or 4-MB pages, fully associative, 7 entries"},
            {0x56, "L1 Data TLB: 4-MB pages, 4-way set associative, 16 entries"},
            {0x57, "L1 Data TLB: 4-KB pages, 4-way set associative, 16 entries"},
            {0x59, "Data TLB: 4-KB pages, fully associative, 16 entries"},
            {0x5A, "Data TLB: 2-MB or 4-MB pages, 4-way associative, 32 entries"},
            {0x5B, "Data TLB: 4-KB or 4-MB pages, fully associative, 64 entries"},
            {0x5C, "Data TLB: 4-KB or 4-MB pages, fully associative, 128 entries"},
            {0x5D, "Data TLB: 4-KB or 4-MB pages, fully associative, 256 entries"},
            {0x60, "1st-level data cache: 16-KB, 8-way set associative, sectored cache, 64-byte line size"},
            {0x66, "1st-level data cache: 8-KB, 4-way set associative, sectored cache, 64-byte line size"},
            {0x67, "1st-level data cache: 16-KB, 4-way set associative, sectored cache, 64-byte line size"},
            {0x68, "1st-level data cache: 32-KB, 4 way set associative, sectored cache, 64-byte line size"},
            {0x70, "Trace cache: 12K-uops, 8-way set associative"},
            {0x71, "Trace cache: 16K-uops, 8-way set associative"},
            {0x72, "Trace cache: 32K-uops, 8-way set associative"},
            {0x76, "2nd-level cache: 1-MB, 4-way set associative, 64-byte line size"},
            {0x78, "2nd-level cache: 1-MB, 4-way set associative, 64-byte line size"},
            {0x79, "2nd-level cache: 128-KB, 8-way set associative, sectored cache, 64-byte line size"},
            {0x7A, "2nd-level cache: 256-KB, 8-way set associative, sectored cache, 64-byte line size"},
            {0x7B, "2nd-level cache: 512-KB, 8-way set associative, sectored cache, 64-byte line size"},
            {0x7C, "2nd-level cache: 1-MB, 8-way set associative, sectored cache, 64-byte line size"},
            {0x7D, "2nd-level cache: 2-MB, 8-way set associative, 64-byte line size"},
            {0x7F, "2nd-level cache: 512-KB, 2-way set associative, 64-byte line size"},
            {0x80, "2nd-level cache: 512-KB, 8-way set associative, 64-byte line size"},
            {0x82, "2nd-level cache: 256-KB, 8-way set associative, 32-byte line size"},
            {0x83, "2nd-level cache: 512-KB, 8-way set associative, 32-byte line size"},
            {0x84, "2nd-level cache: 1-MB, 8-way set associative, 32-byte line size"},
            {0x85, "2nd-level cache: 2-MB, 8-way set associative, 32-byte line size"},
            {0x86, "2nd-level cache: 512-KB, 4-way set associative, 64-byte line size"},
            {0x87, "2nd-level cache: 1-MB, 8-way set associative, 64-byte line size"},
            {0xB0, "Instruction TLB: 4-KB Pages, 4-way set associative, 128 entries"},
            {0xB1, "Instruction TLB: 2-MB pages, 4-way, 8 entries or 4M pages, 4-way, 4 entries"},
            {0xB2, "Instruction TLB: 4-KB pages, 4-way set associative, 64 entries"},
            {0xB3, "Data TLB: 4-KB Pages, 4-way set associative, 128 entries"},
            {0xB4, "Data TLB: 4-KB Pages, 4-way set associative, 256 entries"},
            {0xBA, "Data TLB: 4-KB Pages, 4-way set associative, 64 entries"},
            {0xC0, "Data TLB: 4-KB or 4-MB Pages, 4-way set associative, 8 entries"},
            {0xCA, "Shared 2nd-level TLB: 4 KB pages, 4-way set associative, 512 entries"},
            {0xD0, "3rd-level cache: 512-kB, 4-way set associative, 64-byte line size"},
            {0xD1, "3rd-level cache: 1-MB, 4-way set associative, 64-byte line size"},
            {0xD2, "3rd-level cache: 2-MB, 4-way set associative, 64-byte line size"},
            {0xD6, "3rd-level cache: 1-MB, 8-way set associative, 64-byte line size"},
            {0xD7, "3rd-level cache: 2-MB, 8-way set associative, 64-byte line size"},
            {0xD8, "3rd-level cache: 4-MB, 8-way set associative, 64-byte line size"},
            {0xDC, "3rd-level cache: 1.5-MB, 12-way set associative, 64-byte line size"},
            {0xDD, "3rd-level cache: 3-MB, 12-way set associative, 64-byte line size"},
            {0xDE, "3rd-level cache: 6-MB, 12-way set associative, 64-byte line size"},
            {0xE2, "3rd-level cache: 2-MB, 16-way set associative, 64-byte line size"},
            {0xE3, "3rd-level cache: 4-MB, 16-way set associative, 64-byte line size"},
            {0xE4, "3rd-level cache: 8-MB, 16-way set associative, 64-byte line size"},
            {0xEA, "3rd-level cache: 12-MB, 24-way set associative, 64-byte line size"},
            {0xEB, "3rd-level cache: 18-MB, 24-way set associative, 64-byte line size"},
            {0xEC, "3rd-level cache: 24-MB, 24-way set associative, 64-byte line size"},
            {0xF0, "64-byte Prefetching"},
            {0xF1, "128-byte Prefetching"}
        };

        public static byte CPUType = 0;
        public static byte CPUFamily = 0;
        public static byte CPUExtendedFamily = 0;
        public static byte CPUModel = 0;
        public static byte CPUExtendedModel = 0;
        public static byte CPUStepping = 0;

        public static uint CPUSpeed = 0;                // in Mhz.

        // Returned in CPUID:0x00000001.EDX
        public static bool flagFPU = false;
        public static bool flagVME = false;
        public static bool flagDE = false;
        public static bool flagPSE = false;
        public static bool flagTSC = false;
        public static bool flagMSR = false;
        public static bool flagPAE = false;
        public static bool flagMCE = false;
        public static bool flagCX8 = false;
        public static bool flagAPIC = false;
        public static bool flagFSC = false;
        public static bool flagMTRR = false;
        public static bool flagPGE = false;
        public static bool flagMCA = false;
        public static bool flagCMOV = false;
        public static bool flagPAT = false;
        public static bool flagPSE36 = false;
        public static bool flagSERIAL = false;
        public static bool flagCLFSH = false;
        public static bool flagDS = false;
        public static bool flagACPI = false;
        public static bool flagMMX = false;
        public static bool flagFXSR = false;
        public static bool flagSSE = false;
        public static bool flagSSE2 = false;
        public static bool flagSS = false;
        public static bool flagHTT = false;
        public static bool flagTM = false;
        public static bool flagIA64 = false;
        public static bool flagSBF = false;

        // Returned in CPUID:0x00000001.ECX
        public static bool flagSSE3 = false;
        public static bool flagPCLMULQDQ = false;
        public static bool flagDS64 = false;
        public static bool flagMONITOR = false;
        public static bool flagDSCPL = false;
        public static bool flagVMX = false;
        public static bool flagSMX = false;
        public static bool flagESS = false;
        public static bool flagTM2 = false;
        public static bool flagSSSE3 = false;
        public static bool flagCNXTID = false;
        public static bool flagFMA = false;
        public static bool flagCX16 = false;
        public static bool flagXTPR = false;
        public static bool flagPDCM = false;
        public static bool flagPCID = false;
        public static bool flagDCA = false;
        public static bool flagSSE4_1 = false;
        public static bool flagSSE4_2 = false;
        public static bool flagX2APIC = false;
        public static bool flagMOVBE = false;
        public static bool flagPOPCNT = false;
        public static bool flagTSCDEADLINE = false;
        public static bool flagAES = false;
        public static bool flagXSAVE = false;
        public static bool flagOSXSAVE = false;
        public static bool flagAVX = false;
        public static bool flagF16C = false;

        // Returned in CPUID:0x80000001.EDX (Intel)
        public static bool flagINTEL64 = false;

        // Returned in CPUID:0x80000001.ECX (Intel)

        // Returned in CPUID:0x80000001.EDX (AMD)
        public static bool flagSYSCALLSYSRET = false;
        public static bool flagNX = false;
        public static bool flagMMXEXT = false;
        public static bool flagFFXSR = false;
        public static bool flagPAGE1GB = false;
        public static bool flagRDTSCP = false;
        public static bool flagLM = false;
        public static bool flag3DNOW = false;
        public static bool flag3DNOWEXT = false;

        // Returned in CPUID:0x80000001.ECX (AMD)
        public static bool flagLAHFSAHF = false;
        public static bool flagCMPLEGACY = false;
        public static bool flagSVM = false;
        public static bool flagEXTAPICSPACE = false;
        public static bool flagALTMOVCR8 = false;
        public static bool flagABM = false;
        public static bool flagSSE4A = false;
        public static bool flagMISALIGNSSE = false;
        public static bool flag3DNOWPREFETCH = false;
        public static bool flagOSVW = false;
        public static bool flagIBS = false;
        public static bool flagXOP = false;
        public static bool flagSKINIT = false;
        public static bool flagWDT = false;
        public static bool flagLWP = false;
        public static bool flagFMA4 = false;
        public static bool flagNODEID = false;
        public static bool flagTBM = false;
        public static bool flagTOPOLOGYEXT = false;

        public static List<string> IntelCacheDescriptors = new List<string>();

        public static ulong ReadTSC()
        {
            uint edx = 0;
            uint eax = 0;

            __rdtsc();
            edx = __reg_edx();
            eax = __reg_eax();

            return ((ulong)edx << 32 | eax);
        }        

        private static uint MaxStandardFunction
        {
            get
            {
                __cpuid(0);
                return __reg_eax();
            }
        }

        private static uint MaxExtendedFunction
        {
            get
            {
                __cpuid(0x80000000);
                return __reg_eax();
            }
        }

        public static string VendorString
        {
            get
            {
                uint _ebx, _ecx, _edx;

                __cpuid(0);
                _ebx = __reg_ebx();
                _ecx = __reg_ecx();
                _edx = __reg_edx();

                return ToolsX.Value2String(_ebx, true) +
                       ToolsX.Value2String(_edx, true) +
                       ToolsX.Value2String(_ecx, true);
            }
        }

        public static VendorCompanies VendorCompany
        {
            get
            {
                switch (VendorString)
                {
                    case "AMDisbetter!":
                        return VendorCompanies.AMD;
                    case "AuthenticAMD":
                        return VendorCompanies.AMD;
                    case "CentaurHauls":
                        return VendorCompanies.Centaur;
                    case "CyrixInstead":
                        return VendorCompanies.Cyrix;
                    case "GenuineIntel":
                        return VendorCompanies.Intel;
                    case "TransmetaCPU":
                        return VendorCompanies.Transmeta;
                    case "GenuineTMx86":
                        return VendorCompanies.Transmeta;
                    case "Geode by NSC":
                        return VendorCompanies.NationalSemiconductor;
                    case "NexGenDriven":
                        return VendorCompanies.NexGen;
                    case "RiseRiseRise":
                        return VendorCompanies.Rise;
                    case "SiS SiS SiS ":
                        return VendorCompanies.SiS;
                    case "UMC UMC UMC ":
                        return VendorCompanies.UMC;
                    case "VIA VIA VIA ":
                        return VendorCompanies.VIA;
                    case "Vortex86 SoC":
                        return VendorCompanies.Vortex;
                    default:
                        return VendorCompanies.Unknown;

                }
            }
        }

        public static string CPUName
        {
            get
            {
                if (MaxExtendedFunction >= 0x80000004)
                {
                    uint _eax;
                    uint _ebx;
                    uint _ecx;
                    uint _edx;
                    string _cpuname;

                    __cpuid(0x80000002);
                    _eax = __reg_eax();
                    _ebx = __reg_ebx();
                    _ecx = __reg_ecx();
                    _edx = __reg_edx();
                    _cpuname = ToolsX.Value2String(_eax, true) +
                               ToolsX.Value2String(_ebx, true) +
                               ToolsX.Value2String(_ecx, true) +
                               ToolsX.Value2String(_edx, true);

                    __cpuid(0x80000003);
                    _eax = __reg_eax();
                    _ebx = __reg_ebx();
                    _ecx = __reg_ecx();
                    _edx = __reg_edx();
                    _cpuname += ToolsX.Value2String(_eax, true) +
                                ToolsX.Value2String(_ebx, true) +
                                ToolsX.Value2String(_ecx, true) +
                                ToolsX.Value2String(_edx, true);

                    __cpuid(0x80000004);
                    _eax = __reg_eax();
                    _ebx = __reg_ebx();
                    _ecx = __reg_ecx();
                    _edx = __reg_edx();
                    _cpuname += ToolsX.Value2String(_eax, true) +
                                ToolsX.Value2String(_ebx, true) +
                                ToolsX.Value2String(_ecx, true) +
                                ToolsX.Value2String(_edx, true);
                    
                    return _cpuname;
                }
                else
                {
                    return "";
                }
            }
        }

        private static uint ProcessorSignature
        {
            get
            {
                if (MaxStandardFunction >= 0x01)
                {
                    __cpuid(1);
                    return __reg_eax();
                }
                else
                {
                    return 0;
                }
            }
        }

        private static uint FeatureSet1
        {
            get
            {
                if (MaxStandardFunction >= 0x01)
                {
                    __cpuid(1);
                    return __reg_edx();
                }
                else
                {
                    return 0;
                }
            }
        }

        private static uint FeatureSet2
        {
            get
            {
                if (MaxStandardFunction >= 0x01)
                {
                    __cpuid(1);
                    return __reg_ecx();
                }
                else
                {
                    return 0;
                }
            }
        }

        private static uint ExtendedFeatureSet1
        {
            get
            {
                if (MaxExtendedFunction >= 0x80000001)
                {
                    __cpuid(0x80000001);
                    return __reg_edx();
                }
                else
                {
                    return 0;
                }
            }
        }

        private static uint ExtendedFeatureSet2
        {
            get
            {
                if (MaxExtendedFunction >= 0x80000001)
                {
                    __cpuid(0x80000001);
                    return __reg_ecx();
                }
                else
                {
                    return 0;
                }
            }
        }

        static CPUInfo()
        {
            VendorCompanies _vendorcompany = VendorCompany;

            if (_vendorcompany == VendorCompanies.Intel || _vendorcompany == VendorCompanies.AMD)
            {
                RegistryKey RKey = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor\0");
                CPUSpeed = ConvertX.ToUInt(RKey.GetValue("~MHz").ToString(), 0, "", "", 0);
                RKey.Close();
                                
                uint _processorSignature = ProcessorSignature;

                CPUStepping = (byte)((_processorSignature >> 0) & 0x0F);
                CPUModel = (byte)((_processorSignature >> 4) & 0x0F);
                CPUFamily = (byte)((_processorSignature >> 8) & 0x0F);
                CPUType = (byte)((_processorSignature >> 12) & 0x03);
                CPUExtendedModel = (byte)((_processorSignature >> 16) & 0x0F);
                CPUExtendedFamily = (byte)((_processorSignature >> 20) & 0xFF);

                uint _featureflags1 = FeatureSet1;

                flagFPU = ((_featureflags1 & (uint)IntelFeatureFlags1.FPU) > 0);
                flagVME = ((_featureflags1 & (uint)IntelFeatureFlags1.VME) > 0);
                flagDE = ((_featureflags1 & (uint)IntelFeatureFlags1.DE) > 0);
                flagPSE = ((_featureflags1 & (uint)IntelFeatureFlags1.PSE) > 0);
                flagTSC = ((_featureflags1 & (uint)IntelFeatureFlags1.TSC) > 0);
                flagMSR = ((_featureflags1 & (uint)IntelFeatureFlags1.MSR) > 0);
                flagPAE = ((_featureflags1 & (uint)IntelFeatureFlags1.PAE) > 0);
                flagMCE = ((_featureflags1 & (uint)IntelFeatureFlags1.MCE) > 0);
                flagCX8 = ((_featureflags1 & (uint)IntelFeatureFlags1.CX8) > 0);
                flagAPIC = ((_featureflags1 & (uint)IntelFeatureFlags1.APIC) > 0);
                flagFSC = ((_featureflags1 & (uint)IntelFeatureFlags1.FSC) > 0);
                flagMTRR = ((_featureflags1 & (uint)IntelFeatureFlags1.MTRR) > 0);
                flagPGE = ((_featureflags1 & (uint)IntelFeatureFlags1.PGE) > 0);
                flagMCA = ((_featureflags1 & (uint)IntelFeatureFlags1.MCA) > 0);
                flagCMOV = ((_featureflags1 & (uint)IntelFeatureFlags1.CMOV) > 0);
                flagPAT = ((_featureflags1 & (uint)IntelFeatureFlags1.PAT) > 0);
                flagPSE36 = ((_featureflags1 & (uint)IntelFeatureFlags1.PSE36) > 0);
                flagSERIAL = ((_featureflags1 & (uint)IntelFeatureFlags1.SERIAL) > 0);
                flagCLFSH = ((_featureflags1 & (uint)IntelFeatureFlags1.CLFSH) > 0);
                flagDS = ((_featureflags1 & (uint)IntelFeatureFlags1.DS) > 0);
                flagACPI = ((_featureflags1 & (uint)IntelFeatureFlags1.ACPI) > 0);
                flagMMX = ((_featureflags1 & (uint)IntelFeatureFlags1.MMX) > 0);
                flagFXSR = ((_featureflags1 & (uint)IntelFeatureFlags1.FXSR) > 0);
                flagSSE = ((_featureflags1 & (uint)IntelFeatureFlags1.SSE) > 0);
                flagSSE2 = ((_featureflags1 & (uint)IntelFeatureFlags1.SSE2) > 0);
                flagSS = ((_featureflags1 & (uint)IntelFeatureFlags1.SS) > 0);
                flagHTT = ((_featureflags1 & (uint)IntelFeatureFlags1.HTT) > 0);
                flagTM = ((_featureflags1 & (uint)IntelFeatureFlags1.TM) > 0);
                flagIA64 = ((_featureflags1 & (uint)IntelFeatureFlags1.IA64) > 0);
                flagSBF = ((_featureflags1 & (uint)IntelFeatureFlags1.SBF) > 0);

                uint _featureflags2 = FeatureSet2;

                flagSSE3 = ((_featureflags2 & (uint)IntelFeatureFlags2.SSE3) > 0);
                flagPCLMULQDQ = ((_featureflags2 & (uint)IntelFeatureFlags2.PCLMULQDQ) > 0);
                flagDS64 = ((_featureflags2 & (uint)IntelFeatureFlags2.DS64) > 0);
                flagMONITOR = ((_featureflags2 & (uint)IntelFeatureFlags2.MONITOR) > 0);
                flagDSCPL = ((_featureflags2 & (uint)IntelFeatureFlags2.DSCPL) > 0);
                flagVMX = ((_featureflags2 & (uint)IntelFeatureFlags2.VMX) > 0);
                flagSMX = ((_featureflags2 & (uint)IntelFeatureFlags2.SMX) > 0);
                flagESS = ((_featureflags2 & (uint)IntelFeatureFlags2.ESS) > 0);
                flagTM2 = ((_featureflags2 & (uint)IntelFeatureFlags2.TM2) > 0);
                flagSSSE3 = ((_featureflags2 & (uint)IntelFeatureFlags2.SSSE3) > 0);
                flagCNXTID = ((_featureflags2 & (uint)IntelFeatureFlags2.CNXTID) > 0);
                flagFMA = ((_featureflags2 & (uint)IntelFeatureFlags2.FMA) > 0);
                flagCX16 = ((_featureflags2 & (uint)IntelFeatureFlags2.CX16) > 0);
                flagXTPR = ((_featureflags2 & (uint)IntelFeatureFlags2.XTPR) > 0);
                flagPDCM = ((_featureflags2 & (uint)IntelFeatureFlags2.PDCM) > 0);
                flagPCID = ((_featureflags2 & (uint)IntelFeatureFlags2.PCID) > 0);
                flagDCA = ((_featureflags2 & (uint)IntelFeatureFlags2.DCA) > 0);
                flagSSE4_1 = ((_featureflags2 & (uint)IntelFeatureFlags2.SSE4_1) > 0);
                flagSSE4_2 = ((_featureflags2 & (uint)IntelFeatureFlags2.SSE4_2) > 0);
                flagX2APIC = ((_featureflags2 & (uint)IntelFeatureFlags2.X2APIC) > 0);
                flagMOVBE = ((_featureflags2 & (uint)IntelFeatureFlags2.MOVBE) > 0);
                flagPOPCNT = ((_featureflags2 & (uint)IntelFeatureFlags2.POPCNT) > 0);
                flagTSCDEADLINE = ((_featureflags2 & (uint)IntelFeatureFlags2.TSCDEADLINE) > 0);
                flagAES = ((_featureflags2 & (uint)IntelFeatureFlags2.AES) > 0);
                flagXSAVE = ((_featureflags2 & (uint)IntelFeatureFlags2.XSAVE) > 0);
                flagOSXSAVE = ((_featureflags2 & (uint)IntelFeatureFlags2.OSXSAVE) > 0);
                flagAVX = ((_featureflags2 & (uint)IntelFeatureFlags2.AVX) > 0);
                flagF16C = ((_featureflags2 & (uint)IntelFeatureFlags2.F16C) > 0);
            }

            if (_vendorcompany == VendorCompanies.Intel)
            {
                uint _extfeatureflags1 = ExtendedFeatureSet1;

                flagSYSCALLSYSRET = ((_extfeatureflags1 & (uint)IntelExtendedFeatureFlags1.SYSCALLSYSRET) > 0);
                flagNX = ((_extfeatureflags1 & (uint)IntelExtendedFeatureFlags1.NX) > 0);
                flagPAGE1GB = ((_extfeatureflags1 & (uint)IntelExtendedFeatureFlags1.PAGE1GB) > 0);
                flagRDTSCP = ((_extfeatureflags1 & (uint)IntelExtendedFeatureFlags1.RDTSCP) > 0);
                flagINTEL64 = ((_extfeatureflags1 & (uint)IntelExtendedFeatureFlags1.INTEL64) > 0);

                uint _extfeatureflags2 = ExtendedFeatureSet2;

                flagLAHFSAHF = ((_extfeatureflags2 & (uint)IntelExtendedFeatureFlags2.LAHFSAHF) > 0);

            }

            if (_vendorcompany == VendorCompanies.AMD)
            {
                uint _extfeatureflags1 = ExtendedFeatureSet1;

                // Returned in CPUID:0x80000001.EDX (AMD)
                flagSYSCALLSYSRET = ((_extfeatureflags1 & (uint)AMDExtendedFeatureFlags1.SYSCALLSYSRET) > 0);
                flagNX = ((_extfeatureflags1 & (uint)AMDExtendedFeatureFlags1.NX) > 0);
                flagMMXEXT = ((_extfeatureflags1 & (uint)AMDExtendedFeatureFlags1.MMXEXT) > 0);
                flagFFXSR = ((_extfeatureflags1 & (uint)AMDExtendedFeatureFlags1.FFXSR) > 0);
                flagPAGE1GB = ((_extfeatureflags1 & (uint)AMDExtendedFeatureFlags1.PAGE1GB) > 0);
                flagRDTSCP = ((_extfeatureflags1 & (uint)AMDExtendedFeatureFlags1.RDTSCP) > 0);
                flagLM = ((_extfeatureflags1 & (uint)AMDExtendedFeatureFlags1.LM) > 0);
                flag3DNOW = ((_extfeatureflags1 & (uint)AMDExtendedFeatureFlags1.THREEDNOW) > 0);
                flag3DNOWEXT = ((_extfeatureflags1 & (uint)AMDExtendedFeatureFlags1.THREEDNOWEXT) > 0);

                uint _extfeatureflags2 = ExtendedFeatureSet2;
                
                // Returned in CPUID:0x80000001.ECX (AMD)
                flagLAHFSAHF = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.LAHFSAHF) > 0);
                flagCMPLEGACY = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.CMPLEGACY) > 0);
                flagSVM = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.SVM) > 0);
                flagEXTAPICSPACE = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.EXTAPICSPACE) > 0);
                flagALTMOVCR8 = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.ALTMOVCR8) > 0);
                flagABM = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.ABM) > 0);
                flagSSE4A = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.SSE4A) > 0);
                flagMISALIGNSSE = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.MISALIGNSSE) > 0);
                flag3DNOWPREFETCH = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.THREEDNOWPREFETCH) > 0);
                flagOSVW = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.OSVW) > 0);
                flagIBS = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.IBS) > 0);
                flagXOP = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.XOP) > 0);
                flagSKINIT = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.SKINIT) > 0);
                flagWDT = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.WDT) > 0);
                flagLWP = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.LWP) > 0);
                flagFMA4 = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.FMA4) > 0);
                flagNODEID = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.NODEID) > 0);
                flagTBM = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.TBM) > 0);
                flagTOPOLOGYEXT = ((_extfeatureflags2 & (uint)AMDExtendedFeatureFlags2.TOPOLOGYEXT) > 0);
            }

            if (_vendorcompany == VendorCompanies.Intel || _vendorcompany == VendorCompanies.AMD)
            {
                if (flagTSC)        // if we have TimeStampCounter on the cpu
                {
                }
                else
                {
                    CPUSpeed = 0;
                }
            }

            if (_vendorcompany == VendorCompanies.Intel)
            {
                if (MaxStandardFunction >= 0x02)
                {
                    __cpuid(0x02);
                    uint _eax = __reg_eax();
                    uint _ebx = __reg_ebx();
                    uint _ecx = __reg_ecx();
                    uint _edx = __reg_edx();

                    byte _cachedescriptor;

                    // Check if _eax is a valid descriptor
                    if (((_eax >> 31) & 0x01) == 0)
                    {
                        _cachedescriptor = (byte)((_eax >> 08) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                        _cachedescriptor = (byte)((_eax >> 16) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                        _cachedescriptor = (byte)((_eax >> 24) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                    }

                    // Check if _ebx is a valid descriptor
                    if (((_ebx >> 31) & 0x01) == 0)
                    {
                        _cachedescriptor = (byte)((_ebx >> 00) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                        _cachedescriptor = (byte)((_ebx >> 08) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                        _cachedescriptor = (byte)((_ebx >> 16) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                        _cachedescriptor = (byte)((_ebx >> 24) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                    }

                    // Check if _ecx is a valid descriptor
                    if (((_ecx >> 31) & 0x01) == 0)
                    {
                        _cachedescriptor = (byte)((_ecx >> 00) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                        _cachedescriptor = (byte)((_ecx >> 08) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                        _cachedescriptor = (byte)((_ecx >> 16) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                        _cachedescriptor = (byte)((_ecx >> 24) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                    }

                    // Check if _edx is a valid descriptor
                    if (((_edx >> 31) & 0x01) == 0)
                    {
                        _cachedescriptor = (byte)((_edx >> 00) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                        _cachedescriptor = (byte)((_edx >> 08) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                        _cachedescriptor = (byte)((_edx >> 16) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                        _cachedescriptor = (byte)((_edx >> 24) & 0xFF);
                        AddCacheDescriptor(_cachedescriptor);
                    }
                }
            }
        }

        private static void AddCacheDescriptor(byte CacheDescriptor)
        {
            if (CacheDescriptor > 0x00)
            {
                if (IntelCacheDefinitions.ContainsKey(CacheDescriptor))
                {
                    IntelCacheDescriptors.Add(IntelCacheDefinitions[CacheDescriptor]);
                }
                else
                {
                    IntelCacheDescriptors.Add(String.Format("0x{0:x} : Unknown Cache Descriptor", CacheDescriptor));
                }
            }
        }
    }
}
