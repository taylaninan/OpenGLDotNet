# OpenGLDotNet v1.1.0 
# C# Language Bindings for OpenGL 4.5

OpenGL DotNet is a set of libraries and wrappers especially written for C# in order to make 3D OpenGL programming much easier. It is a base consisting of several libraries; on top of these libraries you can build your own 3D game engine and/or make much simpler 3D demos.

OpenGL DotNet supports OpenGL version up to 4.5 (latest version as of March 2016), and over 550+ OpenGL extensions.

OpenGL DotNet consists of several C# classes, C# libraries and C# wrappers for existing projects written in C/C++. It is completely written from scratch in over 2 months with OpenGL in mind with extensive research and painfully attention given to the details. As far as I know it is the first C# project for OpenGL, which supports over 550+ extensions. Technically you can write Battle Field 4 (or 5) with that much features in C#, but the C#’s performance can suffer compared to pure C/C++ implementations. The main goal of this project is to help you get started quickly with OpenGL programming with a feature-rich, robust, clean framework.

# Overview
The following classes/libraries/wrappers can be found in OpenGLDotNet namespace:

OpenGL/GLConfig	:	Helps you initialize the OpenGL rendering context with version selection (backwards- or forward-compatible or core-profile) and builds a text log while initializing. Also keeps track of supported OpenGL Extensions.
 
OpenGL/GL & WGL	:	They are the main classes for dynamically loading, linking and using of OpenGL Core and Extension functions starting with “gl” and “wgl” respectively.	[for example: “glBegin(GL_QUADS);” is written as “GL.Begin(GL.GL_QUADS);” the same applies for WGL functions]
 
OpenGL/GLU	:	Open(GL) (U)tility is included in Windows as default and is supported by OpenGL Dotnet with a wrapper library.
 
OpenGL/GLUT & FREEGLUT	:	Open(GL) (U)tility (T)oolkit (which is actually very useful, but old) and free and more-update version of it, FREEGLUT, is also supported by OpenGL DotNet with a wrapper library.
 
Math/OpenGLDotNet.Math	:	Is a set of object-oriented classes, which help you with Vector and Matrix operations along with other primitives like Point, Rectangle, Circle, Sphere etc…
 
Assembler	:	Is a simple, short C/C++ source code showing how to use assembler to write functions in a DLL (mostly for CPUID instruction, which gives detailed information about the processor) and after that importing and using these functions in C#.
 
Platform/CPUInfo	:	Is a class with the aim of giving detailed CPU Information (Processor Vendor, Speed, Name, supported instruction sets and features etc…), so that use of necessary optimizations (mostly instruction sets like SSE2 or SSE3) can be decided later at run-time.
 
Imaging/DevIL	:	Is the main imaging DLL written in C/C++ for speed. DevIL is a acronym for “Developer's Image Library”. The original project website can be found here. It allows loading and saving of a lot different picture/image types and uploading them as textures to the OpenGL.
 
Imaging/ILU & ILUT	:	ILU is (I)mage (L)ibrary Utility and ILUT is (I)mage (L)ibrary (U)tility (T)oolkit of DevIL, the Developer's Image Library.
