typedef unsigned int uint32;

uint32 _eax = 0;
uint32 _ebx = 0;
uint32 _ecx = 0;
uint32 _edx = 0;

__declspec(dllexport) void __stdcall _cpuid (uint32 function)
{
	__asm
	{
		pusha
		mov		eax, function
		cpuid
		mov		_eax, eax
		mov		_ebx, ebx
		mov		_ecx, ecx
		mov		_edx, edx
		popa
	};
}

__declspec(dllexport) void __stdcall _rdtsc ()
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
