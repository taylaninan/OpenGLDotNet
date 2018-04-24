// ----------------------------------------------------------------------------
// FILE		: assembler.c
// VERSION	: 1.1.2
// COMMENT	: All assembler routines are written in this file and imported and 
//            used by the CSharp functions later.
// WEB      : https://github.com/carmack78/opengldotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : taylaninan@yahoo.com 
// DATE     : 2014-2018
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

#include "types.h"

uint32 _eax = 0;
uint32 _ebx = 0;
uint32 _ecx = 0;
uint32 _edx = 0;

__declspec(dllexport) void __stdcall _cpuid(uint32 function, uint32 subfunction)
{
	__asm
	{
		pusha
		mov		eax, function
		mov     ecx, subfunction
		cpuid
		mov		_eax, eax
		mov		_ebx, ebx
		mov		_ecx, ecx
		mov		_edx, edx
		popa
	};
}

// Return 64bit counter in EDX:EAX
__declspec(dllexport) void __stdcall _rdtsc()
{
	__asm
	{
		pusha
		rdtsc
		mov		_edx, edx
		mov     _eax, eax
		popa
	}
}

__declspec(dllexport) uint32 __stdcall _reg_eax()
{
	return _eax;
}

__declspec(dllexport) uint32 __stdcall _reg_ebx()
{
	return _ebx;
}

__declspec(dllexport) uint32 __stdcall _reg_ecx()
{
	return _ecx;
}

__declspec(dllexport) uint32 __stdcall _reg_edx()
{
	return _edx;
}
