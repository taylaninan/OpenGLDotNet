// ----------------------------------------------------------------------------
// FILE		: cpuinfo.cs
// VERSION	: 1.1.1
// COMMENT	: Defines functionality for displaying detailed information about the
//            computer CPU. Makes use of "assembler.dll", which is written in "C"
//            and "Assembler commands" (source code included).
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2017
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

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
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void __cpuid(uint function);

        [DllImport("assembler.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "_rdtsc")]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern void __rdtsc();

        [DllImport("assembler.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "_reg_eax")]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern uint __reg_eax();

        [DllImport("assembler.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "_reg_ebx")]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern uint __reg_ebx();

        [DllImport("assembler.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "_reg_ecx")]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        private static extern uint __reg_ecx();
		
        [DllImport("assembler.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "_reg_edx")]
        [System.Security.SuppressUnmanagedCodeSecurity()]
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
        private enum StandardFlags1_EDX : uint
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
        private enum StandardFlags1_ECX : uint
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
            F16C = ValueX.Bits.Bit29,                   // Bit 29 = Half-Precision Convert
            RDRAND = ValueX.Bits.Bit30,					// Bit 30 = Read Random Number
            HV = ValueX.Bits.Bit31						// Bit 31 = HyperVisor Present (and intercepting this bit, to advertise its presence)
        }

		// Returned by CPUID(7).EBX; Information taken from http://sandpile.org/x86/cpuid.htm
        private enum StandardFlags7_EBX : uint
        {
			FSGSBASE   = ValueX.Bits.Bit00,
			TSC_ADJUST = ValueX.Bits.Bit01,
			SGX        = ValueX.Bits.Bit02,
			BMI1       = ValueX.Bits.Bit03,
			HLE        = ValueX.Bits.Bit04,
			AVX2       = ValueX.Bits.Bit05,
			FPDP       = ValueX.Bits.Bit06,
			SMEP       = ValueX.Bits.Bit07,
			BMI2       = ValueX.Bits.Bit08,
			ERMS       = ValueX.Bits.Bit09,
			INVPCID    = ValueX.Bits.Bit10,
			RTM	       = ValueX.Bits.Bit11,
			PQM        = ValueX.Bits.Bit12,
			FPCSDS     = ValueX.Bits.Bit13,
			MPX        = ValueX.Bits.Bit14,
			PQE        = ValueX.Bits.Bit15,
			AVX512F    = ValueX.Bits.Bit16,
			AVX512DQ   = ValueX.Bits.Bit17,
			RDSEED     = ValueX.Bits.Bit18,
			ADX        = ValueX.Bits.Bit19,
			SMAP       = ValueX.Bits.Bit20,
			AVX512IFMA = ValueX.Bits.Bit21,
			PCOMMIT    = ValueX.Bits.Bit22,
			CLFLUSHOPT = ValueX.Bits.Bit23,
			CLWB       = ValueX.Bits.Bit24,
			PT         = ValueX.Bits.Bit25,
			AVX512PF   = ValueX.Bits.Bit26,
			AVX512ER   = ValueX.Bits.Bit27,
			AVX512CD   = ValueX.Bits.Bit28,
			SHA        = ValueX.Bits.Bit29,
			AVX512BW   = ValueX.Bits.Bit30,
			AVX512VL   = ValueX.Bits.Bit31
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
			{0x00, "null descriptor (unused descriptor)"},
			{0x01, "code TLB, 4K pages, 4 ways, 32 entries"},
			{0x02, "code TLB, 4M pages, fully, 2 entries"},
			{0x03, "data TLB, 4K pages, 4 ways, 64 entries"},
			{0x04, "data TLB, 4M pages, 4 ways, 8 entries"},
			{0x05, "data TLB, 4M pages, 4 ways, 32 entries"},
			{0x06, "code L1 cache, 8 KB, 4 ways, 32 byte lines"},
			{0x08, "code L1 cache, 16 KB, 4 ways, 32 byte lines"},
			{0x09, "code L1 cache, 32 KB, 4 ways, 64 byte lines"},
			{0x0A, "data L1 cache, 8 KB, 2 ways, 32 byte lines"},
			{0x0B, "code TLB, 4M pages, 4 ways, 4 entries"},
			{0x0C, "data L1 cache, 16 KB, 4 ways, 32 byte lines"},
			{0x0D, "data L1 cache, 16 KB, 4 ways, 64 byte lines (ECC)"},
			{0x0E, "data L1 cache, 24 KB, 6 ways, 64 byte lines"},
			{0x10, "data L1 cache, 16 KB, 4 ways, 32 byte lines (IA-64)"},
			{0x15, "code L1 cache, 16 KB, 4 ways, 32 byte lines (IA-64)"},
			{0x1A, "code and data L2 cache, 96 KB, 6 ways, 64 byte lines (IA-64)"},
			{0x1D, "code and data L2 cache, 128 KB, 2 ways, 64 byte lines"},
			{0x21, "code and data L2 cache, 256 KB, 8 ways, 64 byte lines"},
			{0x22, "code and data L3 cache, 512 KB, 4 ways, 64 byte lines, dual-sectored"},
			{0x23, "code and data L3 cache, 1024 KB, 8 ways, 64 byte lines, dual-sectored"},
			{0x24, "code and data L2 cache, 1024 KB, 16 ways, 64 byte lines"},
			{0x25, "code and data L3 cache, 2048 KB, 8 ways, 64 byte lines, dual-sectored"},
			{0x29, "code and data L3 cache, 4096 KB, 8 ways, 64 byte lines, dual-sectored"},
			{0x2C, "data L1 cache, 32 KB, 8 ways, 64 byte lines"},
			{0x30, "code L1 cache, 32 KB, 8 ways, 64 byte lines"},
			{0x39, "code and data L2 cache, 128 KB, 4 ways, 64 byte lines, sectored"},
			{0x3A, "code and data L2 cache, 192 KB, 6 ways, 64 byte lines, sectored"},
			{0x3B, "code and data L2 cache, 128 KB, 2 ways, 64 byte lines, sectored"},
			{0x3C, "code and data L2 cache, 256 KB, 4 ways, 64 byte lines, sectored"},
			{0x3D, "code and data L2 cache, 384 KB, 6 ways, 64 byte lines, sectored"},
			{0x3E, "code and data L2 cache, 512 KB, 4 ways, 64 byte lines, sectored"},
			{0x40, "no integrated L2 cache (P6 core) or L3 cache (P4 core)"},
			{0x41, "code and data L2 cache, 128 KB, 4 ways, 32 byte lines"},
			{0x42, "code and data L2 cache, 256 KB, 4 ways, 32 byte lines"},
			{0x43, "code and data L2 cache, 512 KB, 4 ways, 32 byte lines"},
			{0x44, "code and data L2 cache, 1024 KB, 4 ways, 32 byte lines"},
			{0x45, "code and data L2 cache, 2048 KB, 4 ways, 32 byte lines"},
			{0x46, "code and data L3 cache, 4096 KB, 4 ways, 64 byte lines"},
			{0x47, "code and data L3 cache, 8192 KB, 8 ways, 64 byte lines"},
			{0x48, "code and data L2 cache, 3072 KB, 12 ways, 64 byte lines"},
			{0x49, "code and data L3 cache, 4096 KB, 16 ways, 64 byte lines (P4) or code and data L2 cache, 4096 KB, 16 ways, 64 byte lines (Core 2)"},
			{0x4A, "code and data L3 cache, 6144 KB, 12 ways, 64 byte lines"},
			{0x4B, "code and data L3 cache, 8192 KB, 16 ways, 64 byte lines"},
			{0x4C, "code and data L3 cache, 12288 KB, 12 ways, 64 byte lines"},
			{0x4D, "code and data L3 cache, 16384 KB, 16 ways, 64 byte lines"},
			{0x4E, "code and data L2 cache, 6144 KB, 24 ways, 64 byte lines"},
			{0x4F, "code TLB, 4K pages, ???, 32 entries"},
			{0x50, "code TLB, 4K/4M/2M pages, fully, 64 entries"},
			{0x51, "code TLB, 4K/4M/2M pages, fully, 128 entries"},
			{0x52, "code TLB, 4K/4M/2M pages, fully, 256 entries"},
			{0x55, "code TLB, 2M/4M, fully, 7 entries"},
			{0x56, "L0 data TLB, 4M pages, 4 ways, 16 entries"},
			{0x57, "L0 data TLB, 4K pages, 4 ways, 16 entries"},
			{0x59, "L0 data TLB, 4K pages, fully, 16 entries"},
			{0x5A, "L0 data TLB, 2M/4M, 4 ways, 32 entries"},
			{0x5B, "data TLB, 4K/4M pages, fully, 64 entries"},
			{0x5C, "data TLB, 4K/4M pages, fully, 128 entries"},
			{0x5D, "data TLB, 4K/4M pages, fully, 256 entries"},
			{0x60, "data L1 cache, 16 KB, 8 ways, 64 byte lines, sectored"},
			{0x61, "code TLB, 4K pages, fully, 48 entries"},
			{0x63, "data TLB, 2M/4M pages, 4-way, 32-entries, and data TLB, 1G pages, 4-way, 4 entries"},
			{0x64, "data TLB, 4K pages, 4-way, 512 entries"},
			{0x66, "data L1 cache, 8 KB, 4 ways, 64 byte lines, sectored"},
			{0x67, "data L1 cache, 16 KB, 4 ways, 64 byte lines, sectored"},
			{0x68, "data L1 cache, 32 KB, 4 ways, 64 byte lines, sectored"},
			{0x6A, "L0 data TLB, 4K pages, 8-way, 64 entries"},
			{0x6B, "data TLB, 4K pages, 8-way, 256 entries"},
			{0x6C, "data TLB, 2M/4M pages, 8-way, 126 entries"},
			{0x6D, "data TLB, 1G pages, fully, 16 entries"},
			{0x70, "trace L1 cache, 12 KµOPs, 8 ways"},
			{0x71, "trace L1 cache, 16 KµOPs, 8 ways"},
			{0x72, "trace L1 cache, 32 KµOPs, 8 ways"},
			{0x73, "trace L1 cache, 64 KµOPs, 8 ways"},
			{0x76, "code TLB, 2M/4M pages, fully, 8 entries"},
			{0x77, "code L1 cache, 16 KB, 4 ways, 64 byte lines, sectored (IA-64)"},
			{0x78, "code and data L2 cache, 1024 KB, 4 ways, 64 byte lines"},
			{0x79, "code and data L2 cache, 128 KB, 8 ways, 64 byte lines, dual-sectored"},
			{0x7A, "code and data L2 cache, 256 KB, 8 ways, 64 byte lines, dual-sectored"},
			{0x7B, "code and data L2 cache, 512 KB, 8 ways, 64 byte lines, dual-sectored"},
			{0x7C, "code and data L2 cache, 1024 KB, 8 ways, 64 byte lines, dual-sectored"},
			{0x7D, "code and data L2 cache, 2048 KB, 8 ways, 64 byte lines"},
			{0x7E, "code and data L2 cache, 256 KB, 8 ways, 128 byte lines, sect. (IA-64)"},
			{0x7F, "code and data L2 cache, 512 KB, 2 ways, 64 byte lines"},
			{0x80, "code and data L2 cache, 512 KB, 8 ways, 64 byte lines"},
			{0x81, "code and data L2 cache, 128 KB, 8 ways, 32 byte lines"},
			{0x82, "code and data L2 cache, 256 KB, 8 ways, 32 byte lines"},
			{0x83, "code and data L2 cache, 512 KB, 8 ways, 32 byte lines"},
			{0x84, "code and data L2 cache, 1024 KB, 8 ways, 32 byte lines"},
			{0x85, "code and data L2 cache, 2048 KB, 8 ways, 32 byte lines"},
			{0x86, "code and data L2 cache, 512 KB, 4 ways, 64 byte lines"},
			{0x87, "code and data L2 cache, 1024 KB, 8 ways, 64 byte lines"},
			{0x88, "code and data L3 cache, 2048 KB, 4 ways, 64 byte lines (IA-64)"},
			{0x89, "code and data L3 cache, 4096 KB, 4 ways, 64 byte lines (IA-64)"},
			{0x8A, "code and data L3 cache, 8192 KB, 4 ways, 64 byte lines (IA-64)"},
			{0x8D, "code and data L3 cache, 3072 KB, 12 ways, 128 byte lines (IA-64)"},
			{0x90, "code TLB, 4K...256M pages, fully, 64 entries (IA-64)"},
			{0x96, "data L1 TLB, 4K...256M pages, fully, 32 entries (IA-64)"},
			{0x9B, "data L2 TLB, 4K...256M pages, fully, 96 entries (IA-64)"},
			{0xA0, "data TLB, 4K pages, fully, 32 entries"},
			{0xB0, "code TLB, 4K pages, 4 ways, 128 entries"},
			{0xB1, "code TLB, 4M pages, 4 ways, 4 entries and code TLB, 2M pages, 4 ways, 8 entries"},
			{0xB2, "code TLB, 4K pages, 4 ways, 64 entries"},
			{0xB3, "data TLB, 4K pages, 4 ways, 128 entries"},
			{0xB4, "data TLB, 4K pages, 4 ways, 256 entries"},
			{0xB5, "code TLB, 4K pages, 8 ways, 64 entries"},
			{0xB6, "code TLB, 4K pages, 8 ways, 128 entries"},
			{0xBA, "data TLB, 4K pages, 4 ways, 64 entries"},
			{0xC0, "data TLB, 4K/4M pages, 4 ways, 8 entries"},
			{0xC1, "L2 code and data TLB, 4K/2M pages, 8 ways, 1024 entries"},
			{0xC2, "data TLB, 2M/4M pages, 4 ways, 16 entries"},
			{0xC3, "L2 code and data TLB, 4K/2M pages, 6 ways, 1536 entries and L2 code and data TLB, 1G pages, 4 ways, 16 entries"},
			{0xC4, "data TLB, 2M/4M pages, 4-way, 32 entries"},
			{0xCA, "L2 code and data TLB, 4K pages, 4 ways, 512 entries"},
			{0xD0, "code and data L3 cache, 512-kb, 4 ways, 64 byte lines"},
			{0xD1, "code and data L3 cache, 1024-kb, 4 ways, 64 byte lines"},
			{0xD2, "code and data L3 cache, 2048-kb, 4 ways, 64 byte lines"},
			{0xD6, "code and data L3 cache, 1024-kb, 8 ways, 64 byte lines"},
			{0xD7, "code and data L3 cache, 2048-kb, 8 ways, 64 byte lines"},
			{0xD8, "code and data L3 cache, 4096-kb, 8 ways, 64 byte lines"},
			{0xDC, "code and data L3 cache, 1536-kb, 12 ways, 64 byte lines"},
			{0xDD, "code and data L3 cache, 3072-kb, 12 ways, 64 byte lines"},
			{0xDE, "code and data L3 cache, 6144-kb, 12 ways, 64 byte lines"},
			{0xE2, "code and data L3 cache, 2048-kb, 16 ways, 64 byte lines"},
			{0xE3, "code and data L3 cache, 4096-kb, 16 ways, 64 byte lines"},
			{0xE4, "code and data L3 cache, 8192-kb, 16 ways, 64 byte lines"},
			{0xEA, "code and data L3 cache, 12288-kb, 24 ways, 64 byte lines"},
			{0xEB, "code and data L3 cache, 18432-kb, 24 ways, 64 byte lines"},
			{0xEC, "code and data L3 cache, 24576-kb, 24 ways, 64 byte lines"},
			{0xF0, "64 byte prefetching"},
			{0xF1, "128 byte prefetching"}
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
		public static bool flagRDRAND = false;
		public static bool flagHV = false;

        // Returned in CPUID:0x00000007.EBX
        public static bool flagFSGSBASE = false;
        public static bool flagTSC_ADJUST = false;
        public static bool flagSGX = false;
        public static bool flagBMI1 = false;
        public static bool flagHLE = false;
        public static bool flagAVX2 = false;
        public static bool flagFPDP = false;
        public static bool flagSMEP = false;
        public static bool flagBMI2 = false;
        public static bool flagERMS = false;
        public static bool flagINVPCID = false;
        public static bool flagRTM = false;
        public static bool flagPQM = false;
        public static bool flagFPCSDS = false;
        public static bool flagMPX = false;
        public static bool flagPQE = false;
        public static bool flagAVX512F = false;
        public static bool flagAVX512DQ = false;
        public static bool flagRDSEED = false;
        public static bool flagADX = false;
        public static bool flagSMAP = false;
        public static bool flagAVX512IFMA = false;
        public static bool flagPCOMMIT = false;
        public static bool flagCLFLUSHOPT = false;
        public static bool flagCLWB = false;
        public static bool flagPT = false;
        public static bool flagAVX512PF = false;
        public static bool flagAVX512ER = false;
        public static bool flagAVX512CD = false;
        public static bool flagSHA = false;
        public static bool flagAVX512BW = false;
        public static bool flagAVX512VL = false;

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

        private static uint StandardCPUID1_EDX
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

        private static uint StandardCPUID1_ECX
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

        private static uint StandardCPUID7_EBX
        {
            get
            {
                if (MaxStandardFunction >= 0x07)
                {
                    __cpuid(7);
                    return __reg_ebx();
                }
                else
                {
                    return 0;
                }
            }
        }

        private static uint ExtendedCPUID1_EDX
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

        private static uint ExtendedCPUID1_ECX
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

                uint _edx = StandardCPUID1_EDX;

                flagFPU = ((_edx & (uint)StandardFlags1_EDX.FPU) > 0);
                flagVME = ((_edx & (uint)StandardFlags1_EDX.VME) > 0);
                flagDE = ((_edx & (uint)StandardFlags1_EDX.DE) > 0);
                flagPSE = ((_edx & (uint)StandardFlags1_EDX.PSE) > 0);
                flagTSC = ((_edx & (uint)StandardFlags1_EDX.TSC) > 0);
                flagMSR = ((_edx & (uint)StandardFlags1_EDX.MSR) > 0);
                flagPAE = ((_edx & (uint)StandardFlags1_EDX.PAE) > 0);
                flagMCE = ((_edx & (uint)StandardFlags1_EDX.MCE) > 0);
                flagCX8 = ((_edx & (uint)StandardFlags1_EDX.CX8) > 0);
                flagAPIC = ((_edx & (uint)StandardFlags1_EDX.APIC) > 0);
                flagFSC = ((_edx & (uint)StandardFlags1_EDX.FSC) > 0);
                flagMTRR = ((_edx & (uint)StandardFlags1_EDX.MTRR) > 0);
                flagPGE = ((_edx & (uint)StandardFlags1_EDX.PGE) > 0);
                flagMCA = ((_edx & (uint)StandardFlags1_EDX.MCA) > 0);
                flagCMOV = ((_edx & (uint)StandardFlags1_EDX.CMOV) > 0);
                flagPAT = ((_edx & (uint)StandardFlags1_EDX.PAT) > 0);
                flagPSE36 = ((_edx & (uint)StandardFlags1_EDX.PSE36) > 0);
                flagSERIAL = ((_edx & (uint)StandardFlags1_EDX.SERIAL) > 0);
                flagCLFSH = ((_edx & (uint)StandardFlags1_EDX.CLFSH) > 0);
                flagDS = ((_edx & (uint)StandardFlags1_EDX.DS) > 0);
                flagACPI = ((_edx & (uint)StandardFlags1_EDX.ACPI) > 0);
                flagMMX = ((_edx & (uint)StandardFlags1_EDX.MMX) > 0);
                flagFXSR = ((_edx & (uint)StandardFlags1_EDX.FXSR) > 0);
                flagSSE = ((_edx & (uint)StandardFlags1_EDX.SSE) > 0);
                flagSSE2 = ((_edx & (uint)StandardFlags1_EDX.SSE2) > 0);
                flagSS = ((_edx & (uint)StandardFlags1_EDX.SS) > 0);
                flagHTT = ((_edx & (uint)StandardFlags1_EDX.HTT) > 0);
                flagTM = ((_edx & (uint)StandardFlags1_EDX.TM) > 0);
                flagIA64 = ((_edx & (uint)StandardFlags1_EDX.IA64) > 0);
                flagSBF = ((_edx & (uint)StandardFlags1_EDX.SBF) > 0);

                uint _ecx = StandardCPUID1_ECX;

                flagSSE3 = ((_ecx & (uint)StandardFlags1_ECX.SSE3) > 0);
                flagPCLMULQDQ = ((_ecx & (uint)StandardFlags1_ECX.PCLMULQDQ) > 0);
                flagDS64 = ((_ecx & (uint)StandardFlags1_ECX.DS64) > 0);
                flagMONITOR = ((_ecx & (uint)StandardFlags1_ECX.MONITOR) > 0);
                flagDSCPL = ((_ecx & (uint)StandardFlags1_ECX.DSCPL) > 0);
                flagVMX = ((_ecx & (uint)StandardFlags1_ECX.VMX) > 0);
                flagSMX = ((_ecx & (uint)StandardFlags1_ECX.SMX) > 0);
                flagESS = ((_ecx & (uint)StandardFlags1_ECX.ESS) > 0);
                flagTM2 = ((_ecx & (uint)StandardFlags1_ECX.TM2) > 0);
                flagSSSE3 = ((_ecx & (uint)StandardFlags1_ECX.SSSE3) > 0);
                flagCNXTID = ((_ecx & (uint)StandardFlags1_ECX.CNXTID) > 0);
                flagFMA = ((_ecx & (uint)StandardFlags1_ECX.FMA) > 0);
                flagCX16 = ((_ecx & (uint)StandardFlags1_ECX.CX16) > 0);
                flagXTPR = ((_ecx & (uint)StandardFlags1_ECX.XTPR) > 0);
                flagPDCM = ((_ecx & (uint)StandardFlags1_ECX.PDCM) > 0);
                flagPCID = ((_ecx & (uint)StandardFlags1_ECX.PCID) > 0);
                flagDCA = ((_ecx & (uint)StandardFlags1_ECX.DCA) > 0);
                flagSSE4_1 = ((_ecx & (uint)StandardFlags1_ECX.SSE4_1) > 0);
                flagSSE4_2 = ((_ecx & (uint)StandardFlags1_ECX.SSE4_2) > 0);
                flagX2APIC = ((_ecx & (uint)StandardFlags1_ECX.X2APIC) > 0);
                flagMOVBE = ((_ecx & (uint)StandardFlags1_ECX.MOVBE) > 0);
                flagPOPCNT = ((_ecx & (uint)StandardFlags1_ECX.POPCNT) > 0);
                flagTSCDEADLINE = ((_ecx & (uint)StandardFlags1_ECX.TSCDEADLINE) > 0);
                flagAES = ((_ecx & (uint)StandardFlags1_ECX.AES) > 0);
                flagXSAVE = ((_ecx & (uint)StandardFlags1_ECX.XSAVE) > 0);
                flagOSXSAVE = ((_ecx & (uint)StandardFlags1_ECX.OSXSAVE) > 0);
                flagAVX = ((_ecx & (uint)StandardFlags1_ECX.AVX) > 0);
                flagF16C = ((_ecx & (uint)StandardFlags1_ECX.F16C) > 0);
				flagRDRAND = ((_ecx & (uint)StandardFlags1_ECX.RDRAND) > 0);
				flagHV = ((_ecx & (uint)StandardFlags1_ECX.HV) > 0);

                uint _ebx = StandardCPUID7_EBX;

                flagFSGSBASE = ((_ebx & (uint)StandardFlags7_EBX.FSGSBASE) > 0);
                flagTSC_ADJUST = ((_ebx & (uint)StandardFlags7_EBX.TSC_ADJUST) > 0);
                flagSGX = ((_ebx & (uint)StandardFlags7_EBX.SGX) > 0);
                flagBMI1 = ((_ebx & (uint)StandardFlags7_EBX.BMI1) > 0);
                flagHLE = ((_ebx & (uint)StandardFlags7_EBX.HLE) > 0);
                flagAVX2 = ((_ebx & (uint)StandardFlags7_EBX.AVX2) > 0);
                flagFPDP = ((_ebx & (uint)StandardFlags7_EBX.FPDP) > 0);
                flagSMEP = ((_ebx & (uint)StandardFlags7_EBX.SMEP) > 0);
                flagBMI2 = ((_ebx & (uint)StandardFlags7_EBX.BMI2) > 0);
                flagERMS = ((_ebx & (uint)StandardFlags7_EBX.ERMS) > 0);
                flagINVPCID = ((_ebx & (uint)StandardFlags7_EBX.INVPCID) > 0);
                flagRTM = ((_ebx & (uint)StandardFlags7_EBX.RTM) > 0);
                flagPQM = ((_ebx & (uint)StandardFlags7_EBX.PQM) > 0);
                flagFPCSDS = ((_ebx & (uint)StandardFlags7_EBX.FPCSDS) > 0);
                flagMPX = ((_ebx & (uint)StandardFlags7_EBX.MPX) > 0);
                flagPQE = ((_ebx & (uint)StandardFlags7_EBX.PQE) > 0);
                flagAVX512F = ((_ebx & (uint)StandardFlags7_EBX.AVX512F) > 0);
                flagAVX512DQ = ((_ebx & (uint)StandardFlags7_EBX.AVX512DQ) > 0);
                flagRDSEED = ((_ebx & (uint)StandardFlags7_EBX.RDSEED) > 0);
                flagADX = ((_ebx & (uint)StandardFlags7_EBX.ADX) > 0);
                flagSMAP = ((_ebx & (uint)StandardFlags7_EBX.SMAP) > 0);
                flagAVX512IFMA = ((_ebx & (uint)StandardFlags7_EBX.AVX512IFMA) > 0);
                flagPCOMMIT = ((_ebx & (uint)StandardFlags7_EBX.PCOMMIT) > 0);
                flagCLFLUSHOPT = ((_ebx & (uint)StandardFlags7_EBX.CLFLUSHOPT) > 0);
                flagCLWB = ((_ebx & (uint)StandardFlags7_EBX.CLWB) > 0);
                flagPT = ((_ebx & (uint)StandardFlags7_EBX.PT) > 0);
                flagAVX512PF = ((_ebx & (uint)StandardFlags7_EBX.AVX512PF) > 0);
                flagAVX512ER = ((_ebx & (uint)StandardFlags7_EBX.AVX512ER) > 0);
                flagAVX512CD = ((_ebx & (uint)StandardFlags7_EBX.AVX512CD) > 0);
                flagSHA = ((_ebx & (uint)StandardFlags7_EBX.SHA) > 0);
                flagAVX512BW = ((_ebx & (uint)StandardFlags7_EBX.AVX512BW) > 0);
                flagAVX512VL = ((_ebx & (uint)StandardFlags7_EBX.AVX512VL) > 0);
            }

            if (_vendorcompany == VendorCompanies.Intel)
            {
                uint _extfeatureflags1 = ExtendedCPUID1_EDX;

                flagSYSCALLSYSRET = ((_extfeatureflags1 & (uint)IntelExtendedFeatureFlags1.SYSCALLSYSRET) > 0);
                flagNX = ((_extfeatureflags1 & (uint)IntelExtendedFeatureFlags1.NX) > 0);
                flagPAGE1GB = ((_extfeatureflags1 & (uint)IntelExtendedFeatureFlags1.PAGE1GB) > 0);
                flagRDTSCP = ((_extfeatureflags1 & (uint)IntelExtendedFeatureFlags1.RDTSCP) > 0);
                flagINTEL64 = ((_extfeatureflags1 & (uint)IntelExtendedFeatureFlags1.INTEL64) > 0);

                uint _extfeatureflags2 = ExtendedCPUID1_ECX;

                flagLAHFSAHF = ((_extfeatureflags2 & (uint)IntelExtendedFeatureFlags2.LAHFSAHF) > 0);

            }

            if (_vendorcompany == VendorCompanies.AMD)
            {
                uint _extfeatureflags1 = ExtendedCPUID1_EDX;

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

                uint _extfeatureflags2 = ExtendedCPUID1_ECX;
                
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

            if (_vendorcompany == VendorCompanies.Intel)
            {
                if (MaxStandardFunction >= 0x02)
                {
                    __cpuid(0x02);
                    uint _eax = __reg_eax();
                    uint _ebx = __reg_ebx();
                    uint _ecx = __reg_ecx();
                    uint _edx = __reg_edx();

                    byte _cachedescriptor = 0;
					byte _nroftimestoreadall = 0;
					
					_nroftimestoreadall = (byte)((_eax >> 00) & 0xFF);
					
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
