// ----------------------------------------------------------------------------
// FILE		: windows.cs
// VERSION	: 1.1.3
// DATE     : 26 April 2018
// COMMENT	: Defines and imports "Windows" specific Library (*.dll) functionality
//            from kernel32.dll.
// WEB      : https://github.com/carmack78/opengldotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : taylaninan@yahoo.com 
// DATE     : 2014-2018
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

namespace OpenGLDotNet
{
    public static class Windows
    {
        private const string LIBKERNEL = "kernel32.dll";

        ///////////////////////////////////////////////////////////////////////
        // FUNCTIONS
        ///////////////////////////////////////////////////////////////////////
        [DllImport(LIBKERNEL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "LoadLibraryW")]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        public static extern uint LoadLibrary(string LibraryName);

        [DllImport(LIBKERNEL, CallingConvention = CallingConvention.StdCall)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        public static extern bool FreeLibrary(uint LibraryHandle);

        [DllImport(LIBKERNEL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [System.Security.SuppressUnmanagedCodeSecurity()]
        public static extern uint GetProcAddress(uint LibraryHandle, string ProcedureName);
    }
}
