using System;
using System.Runtime.InteropServices;

namespace OpenGLDotNet
{
    public static class Windows
    {
        ///////////////////////////////////////////////////////////////////////
        // FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "LoadLibraryW")]
        public static extern uint LoadLibrary(string LibraryName);

        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool FreeLibrary(uint LibraryHandle);

        [DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern uint GetProcAddress(uint LibraryHandle, string ProcedureName);
    }
}