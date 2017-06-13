// ----------------------------------------------------------------------------
// FILE		: gl.corelinker.cs
// VERSION	: 1.1.1
// COMMENT	: OpenGL Core Profile library dynamic linker for low level delegates 
//            and functions.
// WEB      : http://www.taylaninan.com/opengl-dotnet
// AUTHOR   : TAYLAN INAN
// E-MAIL   : info@taylaninan.com
// DATE     : 2014-2017
// LICENSE  : FREE FOR EDUCATIONAL, PERSONAL AND COMMERCIAL USAGE
// ----------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

namespace OpenGLDotNet
{
    public static partial class GL
    {
        private static void LinkLibGLCore()
        {
            ///////////////////////////////////////////////////////////////////
            // OPENGL 1.1 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 1.1 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 1.1 FUNCTIONS...
            if (GL.LinkProcGL("glAccum"))
            {
                GL.glAccum = (TglAccum)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAccum));
            }

            if (GL.LinkProcGL("glAlphaFunc"))
            {
                GL.glAlphaFunc = (TglAlphaFunc)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAlphaFunc));
            }

            if (GL.LinkProcGL("glAreTexturesResident"))
            {
                GL.glAreTexturesResident = (TglAreTexturesResident)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAreTexturesResident));
            }

            if (GL.LinkProcGL("glArrayElement"))
            {
                GL.glArrayElement = (TglArrayElement)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglArrayElement));
            }

            if (GL.LinkProcGL("glBegin"))
            {
                GL.glBegin = (TglBegin)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBegin));
            }

            if (GL.LinkProcGL("glBindTexture"))
            {
                GL.glBindTexture = (TglBindTexture)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindTexture));
            }

            if (GL.LinkProcGL("glBitmap"))
            {
                GL.glBitmap = (TglBitmap)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBitmap));
            }

            if (GL.LinkProcGL("glBlendFunc"))
            {
                GL.glBlendFunc = (TglBlendFunc)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendFunc));
            }

            if (GL.LinkProcGL("glCallList"))
            {
                GL.glCallList = (TglCallList)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCallList));
            }

            if (GL.LinkProcGL("glCallLists"))
            {
                GL.glCallLists = (TglCallLists)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCallLists));
            }

            if (GL.LinkProcGL("glClear"))
            {
                GL.glClear = (TglClear)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClear));
            }

            if (GL.LinkProcGL("glClearAccum"))
            {
                GL.glClearAccum = (TglClearAccum)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearAccum));
            }

            if (GL.LinkProcGL("glClearColor"))
            {
                GL.glClearColor = (TglClearColor)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearColor));
            }

            if (GL.LinkProcGL("glClearDepth"))
            {
                GL.glClearDepth = (TglClearDepth)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearDepth));
            }

            if (GL.LinkProcGL("glClearIndex"))
            {
                GL.glClearIndex = (TglClearIndex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearIndex));
            }

            if (GL.LinkProcGL("glClearStencil"))
            {
                GL.glClearStencil = (TglClearStencil)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearStencil));
            }

            if (GL.LinkProcGL("glClipPlane"))
            {
                GL.glClipPlane = (TglClipPlane)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClipPlane));
            }

            if (GL.LinkProcGL("glColor3b"))
            {
                GL.glColor3b = (TglColor3b)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3b));
            }

            if (GL.LinkProcGL("glColor3bv"))
            {
                GL.glColor3bv = (TglColor3bv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3bv));
            }

            if (GL.LinkProcGL("glColor3d"))
            {
                GL.glColor3d = (TglColor3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3d));
            }

            if (GL.LinkProcGL("glColor3dv"))
            {
                GL.glColor3dv = (TglColor3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3dv));
            }

            if (GL.LinkProcGL("glColor3f"))
            {
                GL.glColor3f = (TglColor3f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3f));
            }

            if (GL.LinkProcGL("glColor3fv"))
            {
                GL.glColor3fv = (TglColor3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3fv));
            }

            if (GL.LinkProcGL("glColor3i"))
            {
                GL.glColor3i = (TglColor3i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3i));
            }

            if (GL.LinkProcGL("glColor3iv"))
            {
                GL.glColor3iv = (TglColor3iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3iv));
            }

            if (GL.LinkProcGL("glColor3s"))
            {
                GL.glColor3s = (TglColor3s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3s));
            }

            if (GL.LinkProcGL("glColor3sv"))
            {
                GL.glColor3sv = (TglColor3sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3sv));
            }

            if (GL.LinkProcGL("glColor3ub"))
            {
                GL.glColor3ub = (TglColor3ub)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3ub));
            }

            if (GL.LinkProcGL("glColor3ubv"))
            {
                GL.glColor3ubv = (TglColor3ubv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3ubv));
            }

            if (GL.LinkProcGL("glColor3ui"))
            {
                GL.glColor3ui = (TglColor3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3ui));
            }

            if (GL.LinkProcGL("glColor3uiv"))
            {
                GL.glColor3uiv = (TglColor3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3uiv));
            }

            if (GL.LinkProcGL("glColor3us"))
            {
                GL.glColor3us = (TglColor3us)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3us));
            }

            if (GL.LinkProcGL("glColor3usv"))
            {
                GL.glColor3usv = (TglColor3usv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor3usv));
            }

            if (GL.LinkProcGL("glColor4b"))
            {
                GL.glColor4b = (TglColor4b)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4b));
            }

            if (GL.LinkProcGL("glColor4bv"))
            {
                GL.glColor4bv = (TglColor4bv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4bv));
            }

            if (GL.LinkProcGL("glColor4d"))
            {
                GL.glColor4d = (TglColor4d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4d));
            }

            if (GL.LinkProcGL("glColor4dv"))
            {
                GL.glColor4dv = (TglColor4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4dv));
            }

            if (GL.LinkProcGL("glColor4f"))
            {
                GL.glColor4f = (TglColor4f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4f));
            }

            if (GL.LinkProcGL("glColor4fv"))
            {
                GL.glColor4fv = (TglColor4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4fv));
            }

            if (GL.LinkProcGL("glColor4i"))
            {
                GL.glColor4i = (TglColor4i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4i));
            }

            if (GL.LinkProcGL("glColor4iv"))
            {
                GL.glColor4iv = (TglColor4iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4iv));
            }

            if (GL.LinkProcGL("glColor4s"))
            {
                GL.glColor4s = (TglColor4s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4s));
            }

            if (GL.LinkProcGL("glColor4sv"))
            {
                GL.glColor4sv = (TglColor4sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4sv));
            }

            if (GL.LinkProcGL("glColor4ub"))
            {
                GL.glColor4ub = (TglColor4ub)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4ub));
            }

            if (GL.LinkProcGL("glColor4ubv"))
            {
                GL.glColor4ubv = (TglColor4ubv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4ubv));
            }

            if (GL.LinkProcGL("glColor4ui"))
            {
                GL.glColor4ui = (TglColor4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4ui));
            }

            if (GL.LinkProcGL("glColor4uiv"))
            {
                GL.glColor4uiv = (TglColor4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4uiv));
            }

            if (GL.LinkProcGL("glColor4us"))
            {
                GL.glColor4us = (TglColor4us)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4us));
            }

            if (GL.LinkProcGL("glColor4usv"))
            {
                GL.glColor4usv = (TglColor4usv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColor4usv));
            }

            if (GL.LinkProcGL("glColorMask"))
            {
                GL.glColorMask = (TglColorMask)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorMask));
            }

            if (GL.LinkProcGL("glColorMaterial"))
            {
                GL.glColorMaterial = (TglColorMaterial)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorMaterial));
            }

            if (GL.LinkProcGL("glColorPointer"))
            {
                GL.glColorPointer = (TglColorPointer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorPointer));
            }

            if (GL.LinkProcGL("glCopyPixels"))
            {
                GL.glCopyPixels = (TglCopyPixels)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyPixels));
            }

            if (GL.LinkProcGL("glCopyTexImage1D"))
            {
                GL.glCopyTexImage1D = (TglCopyTexImage1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTexImage1D));
            }

            if (GL.LinkProcGL("glCopyTexImage2D"))
            {
                GL.glCopyTexImage2D = (TglCopyTexImage2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTexImage2D));
            }

            if (GL.LinkProcGL("glCopyTexSubImage1D"))
            {
                GL.glCopyTexSubImage1D = (TglCopyTexSubImage1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTexSubImage1D));
            }

            if (GL.LinkProcGL("glCopyTexSubImage2D"))
            {
                GL.glCopyTexSubImage2D = (TglCopyTexSubImage2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTexSubImage2D));
            }

            if (GL.LinkProcGL("glCullFace"))
            {
                GL.glCullFace = (TglCullFace)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCullFace));
            }

            if (GL.LinkProcGL("glDeleteLists"))
            {
                GL.glDeleteLists = (TglDeleteLists)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteLists));
            }

            if (GL.LinkProcGL("glDeleteTextures"))
            {
                GL.glDeleteTextures = (TglDeleteTextures)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteTextures));
            }

            if (GL.LinkProcGL("glDepthFunc"))
            {
                GL.glDepthFunc = (TglDepthFunc)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthFunc));
            }

            if (GL.LinkProcGL("glDepthMask"))
            {
                GL.glDepthMask = (TglDepthMask)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthMask));
            }

            if (GL.LinkProcGL("glDepthRange"))
            {
                GL.glDepthRange = (TglDepthRange)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthRange));
            }

            if (GL.LinkProcGL("glDisable"))
            {
                GL.glDisable = (TglDisable)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDisable));
            }

            if (GL.LinkProcGL("glDisableClientState"))
            {
                GL.glDisableClientState = (TglDisableClientState)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDisableClientState));
            }

            if (GL.LinkProcGL("glDrawArrays"))
            {
                GL.glDrawArrays = (TglDrawArrays)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawArrays));
            }

            if (GL.LinkProcGL("glDrawBuffer"))
            {
                GL.glDrawBuffer = (TglDrawBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawBuffer));
            }

            if (GL.LinkProcGL("glDrawElements"))
            {
                GL.glDrawElements = (TglDrawElements)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElements));
            }

            if (GL.LinkProcGL("glDrawPixels"))
            {
                GL.glDrawPixels = (TglDrawPixels)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawPixels));
            }

            if (GL.LinkProcGL("glEdgeFlag"))
            {
                GL.glEdgeFlag = (TglEdgeFlag)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEdgeFlag));
            }

            if (GL.LinkProcGL("glEdgeFlagPointer"))
            {
                GL.glEdgeFlagPointer = (TglEdgeFlagPointer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEdgeFlagPointer));
            }

            if (GL.LinkProcGL("glEdgeFlagv"))
            {
                GL.glEdgeFlagv = (TglEdgeFlagv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEdgeFlagv));
            }

            if (GL.LinkProcGL("glEnable"))
            {
                GL.glEnable = (TglEnable)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEnable));
            }

            if (GL.LinkProcGL("glEnableClientState"))
            {
                GL.glEnableClientState = (TglEnableClientState)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEnableClientState));
            }

            if (GL.LinkProcGL("glEnd"))
            {
                GL.glEnd = (TglEnd)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEnd));
            }

            if (GL.LinkProcGL("glEndList"))
            {
                GL.glEndList = (TglEndList)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndList));
            }

            if (GL.LinkProcGL("glEvalCoord1d"))
            {
                GL.glEvalCoord1d = (TglEvalCoord1d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalCoord1d));
            }

            if (GL.LinkProcGL("glEvalCoord1dv"))
            {
                GL.glEvalCoord1dv = (TglEvalCoord1dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalCoord1dv));
            }

            if (GL.LinkProcGL("glEvalCoord1f"))
            {
                GL.glEvalCoord1f = (TglEvalCoord1f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalCoord1f));
            }

            if (GL.LinkProcGL("glEvalCoord1fv"))
            {
                GL.glEvalCoord1fv = (TglEvalCoord1fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalCoord1fv));
            }

            if (GL.LinkProcGL("glEvalCoord2d"))
            {
                GL.glEvalCoord2d = (TglEvalCoord2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalCoord2d));
            }

            if (GL.LinkProcGL("glEvalCoord2dv"))
            {
                GL.glEvalCoord2dv = (TglEvalCoord2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalCoord2dv));
            }

            if (GL.LinkProcGL("glEvalCoord2f"))
            {
                GL.glEvalCoord2f = (TglEvalCoord2f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalCoord2f));
            }

            if (GL.LinkProcGL("glEvalCoord2fv"))
            {
                GL.glEvalCoord2fv = (TglEvalCoord2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalCoord2fv));
            }

            if (GL.LinkProcGL("glEvalMesh1"))
            {
                GL.glEvalMesh1 = (TglEvalMesh1)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalMesh1));
            }

            if (GL.LinkProcGL("glEvalMesh2"))
            {
                GL.glEvalMesh2 = (TglEvalMesh2)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalMesh2));
            }

            if (GL.LinkProcGL("glEvalPoint1"))
            {
                GL.glEvalPoint1 = (TglEvalPoint1)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalPoint1));
            }

            if (GL.LinkProcGL("glEvalPoint2"))
            {
                GL.glEvalPoint2 = (TglEvalPoint2)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEvalPoint2));
            }

            if (GL.LinkProcGL("glFeedbackBuffer"))
            {
                GL.glFeedbackBuffer = (TglFeedbackBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFeedbackBuffer));
            }

            if (GL.LinkProcGL("glFinish"))
            {
                GL.glFinish = (TglFinish)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFinish));
            }

            if (GL.LinkProcGL("glFlush"))
            {
                GL.glFlush = (TglFlush)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFlush));
            }

            if (GL.LinkProcGL("glFogf"))
            {
                GL.glFogf = (TglFogf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogf));
            }

            if (GL.LinkProcGL("glFogfv"))
            {
                GL.glFogfv = (TglFogfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogfv));
            }

            if (GL.LinkProcGL("glFogi"))
            {
                GL.glFogi = (TglFogi)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogi));
            }

            if (GL.LinkProcGL("glFogiv"))
            {
                GL.glFogiv = (TglFogiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogiv));
            }

            if (GL.LinkProcGL("glFrontFace"))
            {
                GL.glFrontFace = (TglFrontFace)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFrontFace));
            }

            if (GL.LinkProcGL("glFrustum"))
            {
                GL.glFrustum = (TglFrustum)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFrustum));
            }

            if (GL.LinkProcGL("glGenLists"))
            {
                GL.glGenLists = (TglGenLists)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenLists));
            }

            if (GL.LinkProcGL("glGenTextures"))
            {
                GL.glGenTextures = (TglGenTextures)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenTextures));
            }

            if (GL.LinkProcGL("glGetBooleanv"))
            {
                GL.glGetBooleanv = (TglGetBooleanv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetBooleanv));
            }

            if (GL.LinkProcGL("glGetClipPlane"))
            {
                GL.glGetClipPlane = (TglGetClipPlane)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetClipPlane));
            }

            if (GL.LinkProcGL("glGetDoublev"))
            {
                GL.glGetDoublev = (TglGetDoublev)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetDoublev));
            }

            if (GL.LinkProcGL("glGetError"))
            {
                GL.glGetError = (TglGetError)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetError));
            }

            if (GL.LinkProcGL("glGetFloatv"))
            {
                GL.glGetFloatv = (TglGetFloatv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFloatv));
            }

            if (GL.LinkProcGL("glGetIntegerv"))
            {
                GL.glGetIntegerv = (TglGetIntegerv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetIntegerv));
            }

            if (GL.LinkProcGL("glGetLightfv"))
            {
                GL.glGetLightfv = (TglGetLightfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetLightfv));
            }

            if (GL.LinkProcGL("glGetLightiv"))
            {
                GL.glGetLightiv = (TglGetLightiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetLightiv));
            }

            if (GL.LinkProcGL("glGetMapdv"))
            {
                GL.glGetMapdv = (TglGetMapdv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMapdv));
            }

            if (GL.LinkProcGL("glGetMapfv"))
            {
                GL.glGetMapfv = (TglGetMapfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMapfv));
            }

            if (GL.LinkProcGL("glGetMapiv"))
            {
                GL.glGetMapiv = (TglGetMapiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMapiv));
            }

            if (GL.LinkProcGL("glGetMaterialfv"))
            {
                GL.glGetMaterialfv = (TglGetMaterialfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMaterialfv));
            }

            if (GL.LinkProcGL("glGetMaterialiv"))
            {
                GL.glGetMaterialiv = (TglGetMaterialiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMaterialiv));
            }

            if (GL.LinkProcGL("glGetPixelMapfv"))
            {
                GL.glGetPixelMapfv = (TglGetPixelMapfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPixelMapfv));
            }

            if (GL.LinkProcGL("glGetPixelMapuiv"))
            {
                GL.glGetPixelMapuiv = (TglGetPixelMapuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPixelMapuiv));
            }

            if (GL.LinkProcGL("glGetPixelMapusv"))
            {
                GL.glGetPixelMapusv = (TglGetPixelMapusv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPixelMapusv));
            }

            if (GL.LinkProcGL("glGetPointerv"))
            {
                GL.glGetPointerv = (TglGetPointerv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPointerv));
            }

            if (GL.LinkProcGL("glGetPolygonStipple"))
            {
                GL.glGetPolygonStipple = (TglGetPolygonStipple)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetPolygonStipple));
            }

            if (GL.LinkProcGL("glGetString"))
            {
                GL.glGetString = (TglGetString)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetString));
            }

            if (GL.LinkProcGL("glGetTexEnvfv"))
            {
                GL.glGetTexEnvfv = (TglGetTexEnvfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexEnvfv));
            }

            if (GL.LinkProcGL("glGetTexEnviv"))
            {
                GL.glGetTexEnviv = (TglGetTexEnviv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexEnviv));
            }

            if (GL.LinkProcGL("glGetTexGendv"))
            {
                GL.glGetTexGendv = (TglGetTexGendv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexGendv));
            }

            if (GL.LinkProcGL("glGetTexGenfv"))
            {
                GL.glGetTexGenfv = (TglGetTexGenfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexGenfv));
            }

            if (GL.LinkProcGL("glGetTexGeniv"))
            {
                GL.glGetTexGeniv = (TglGetTexGeniv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexGeniv));
            }

            if (GL.LinkProcGL("glGetTexImage"))
            {
                GL.glGetTexImage = (TglGetTexImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexImage));
            }

            if (GL.LinkProcGL("glGetTexLevelParameterfv"))
            {
                GL.glGetTexLevelParameterfv = (TglGetTexLevelParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexLevelParameterfv));
            }

            if (GL.LinkProcGL("glGetTexLevelParameteriv"))
            {
                GL.glGetTexLevelParameteriv = (TglGetTexLevelParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexLevelParameteriv));
            }

            if (GL.LinkProcGL("glGetTexParameterfv"))
            {
                GL.glGetTexParameterfv = (TglGetTexParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexParameterfv));
            }

            if (GL.LinkProcGL("glGetTexParameteriv"))
            {
                GL.glGetTexParameteriv = (TglGetTexParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexParameteriv));
            }

            if (GL.LinkProcGL("glHint"))
            {
                GL.glHint = (TglHint)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglHint));
            }

            if (GL.LinkProcGL("glIndexMask"))
            {
                GL.glIndexMask = (TglIndexMask)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexMask));
            }

            if (GL.LinkProcGL("glIndexPointer"))
            {
                GL.glIndexPointer = (TglIndexPointer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexPointer));
            }

            if (GL.LinkProcGL("glIndexd"))
            {
                GL.glIndexd = (TglIndexd)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexd));
            }

            if (GL.LinkProcGL("glIndexdv"))
            {
                GL.glIndexdv = (TglIndexdv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexdv));
            }

            if (GL.LinkProcGL("glIndexf"))
            {
                GL.glIndexf = (TglIndexf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexf));
            }

            if (GL.LinkProcGL("glIndexfv"))
            {
                GL.glIndexfv = (TglIndexfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexfv));
            }

            if (GL.LinkProcGL("glIndexi"))
            {
                GL.glIndexi = (TglIndexi)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexi));
            }

            if (GL.LinkProcGL("glIndexiv"))
            {
                GL.glIndexiv = (TglIndexiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexiv));
            }

            if (GL.LinkProcGL("glIndexs"))
            {
                GL.glIndexs = (TglIndexs)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexs));
            }

            if (GL.LinkProcGL("glIndexsv"))
            {
                GL.glIndexsv = (TglIndexsv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexsv));
            }

            if (GL.LinkProcGL("glIndexub"))
            {
                GL.glIndexub = (TglIndexub)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexub));
            }

            if (GL.LinkProcGL("glIndexubv"))
            {
                GL.glIndexubv = (TglIndexubv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIndexubv));
            }

            if (GL.LinkProcGL("glInitNames"))
            {
                GL.glInitNames = (TglInitNames)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInitNames));
            }

            if (GL.LinkProcGL("glInterleavedArrays"))
            {
                GL.glInterleavedArrays = (TglInterleavedArrays)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInterleavedArrays));
            }

            if (GL.LinkProcGL("glIsEnabled"))
            {
                GL.glIsEnabled = (TglIsEnabled)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsEnabled));
            }

            if (GL.LinkProcGL("glIsList"))
            {
                GL.glIsList = (TglIsList)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsList));
            }

            if (GL.LinkProcGL("glIsTexture"))
            {
                GL.glIsTexture = (TglIsTexture)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsTexture));
            }

            if (GL.LinkProcGL("glLightModelf"))
            {
                GL.glLightModelf = (TglLightModelf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLightModelf));
            }

            if (GL.LinkProcGL("glLightModelfv"))
            {
                GL.glLightModelfv = (TglLightModelfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLightModelfv));
            }

            if (GL.LinkProcGL("glLightModeli"))
            {
                GL.glLightModeli = (TglLightModeli)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLightModeli));
            }

            if (GL.LinkProcGL("glLightModeliv"))
            {
                GL.glLightModeliv = (TglLightModeliv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLightModeliv));
            }

            if (GL.LinkProcGL("glLightf"))
            {
                GL.glLightf = (TglLightf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLightf));
            }

            if (GL.LinkProcGL("glLightfv"))
            {
                GL.glLightfv = (TglLightfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLightfv));
            }

            if (GL.LinkProcGL("glLighti"))
            {
                GL.glLighti = (TglLighti)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLighti));
            }

            if (GL.LinkProcGL("glLightiv"))
            {
                GL.glLightiv = (TglLightiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLightiv));
            }

            if (GL.LinkProcGL("glLineStipple"))
            {
                GL.glLineStipple = (TglLineStipple)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLineStipple));
            }

            if (GL.LinkProcGL("glLineWidth"))
            {
                GL.glLineWidth = (TglLineWidth)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLineWidth));
            }

            if (GL.LinkProcGL("glListBase"))
            {
                GL.glListBase = (TglListBase)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglListBase));
            }

            if (GL.LinkProcGL("glLoadIdentity"))
            {
                GL.glLoadIdentity = (TglLoadIdentity)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLoadIdentity));
            }

            if (GL.LinkProcGL("glLoadMatrixd"))
            {
                GL.glLoadMatrixd = (TglLoadMatrixd)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLoadMatrixd));
            }

            if (GL.LinkProcGL("glLoadMatrixf"))
            {
                GL.glLoadMatrixf = (TglLoadMatrixf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLoadMatrixf));
            }

            if (GL.LinkProcGL("glLoadName"))
            {
                GL.glLoadName = (TglLoadName)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLoadName));
            }

            if (GL.LinkProcGL("glLogicOp"))
            {
                GL.glLogicOp = (TglLogicOp)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLogicOp));
            }

            if (GL.LinkProcGL("glMap1d"))
            {
                GL.glMap1d = (TglMap1d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMap1d));
            }

            if (GL.LinkProcGL("glMap1f"))
            {
                GL.glMap1f = (TglMap1f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMap1f));
            }

            if (GL.LinkProcGL("glMap2d"))
            {
                GL.glMap2d = (TglMap2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMap2d));
            }

            if (GL.LinkProcGL("glMap2f"))
            {
                GL.glMap2f = (TglMap2f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMap2f));
            }

            if (GL.LinkProcGL("glMapGrid1d"))
            {
                GL.glMapGrid1d = (TglMapGrid1d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapGrid1d));
            }

            if (GL.LinkProcGL("glMapGrid1f"))
            {
                GL.glMapGrid1f = (TglMapGrid1f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapGrid1f));
            }

            if (GL.LinkProcGL("glMapGrid2d"))
            {
                GL.glMapGrid2d = (TglMapGrid2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapGrid2d));
            }

            if (GL.LinkProcGL("glMapGrid2f"))
            {
                GL.glMapGrid2f = (TglMapGrid2f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapGrid2f));
            }

            if (GL.LinkProcGL("glMaterialf"))
            {
                GL.glMaterialf = (TglMaterialf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMaterialf));
            }

            if (GL.LinkProcGL("glMaterialfv"))
            {
                GL.glMaterialfv = (TglMaterialfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMaterialfv));
            }

            if (GL.LinkProcGL("glMateriali"))
            {
                GL.glMateriali = (TglMateriali)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMateriali));
            }

            if (GL.LinkProcGL("glMaterialiv"))
            {
                GL.glMaterialiv = (TglMaterialiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMaterialiv));
            }

            if (GL.LinkProcGL("glMatrixMode"))
            {
                GL.glMatrixMode = (TglMatrixMode)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMatrixMode));
            }

            if (GL.LinkProcGL("glMultMatrixd"))
            {
                GL.glMultMatrixd = (TglMultMatrixd)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultMatrixd));
            }

            if (GL.LinkProcGL("glMultMatrixf"))
            {
                GL.glMultMatrixf = (TglMultMatrixf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultMatrixf));
            }

            if (GL.LinkProcGL("glNewList"))
            {
                GL.glNewList = (TglNewList)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNewList));
            }

            if (GL.LinkProcGL("glNormal3b"))
            {
                GL.glNormal3b = (TglNormal3b)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3b));
            }

            if (GL.LinkProcGL("glNormal3bv"))
            {
                GL.glNormal3bv = (TglNormal3bv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3bv));
            }

            if (GL.LinkProcGL("glNormal3d"))
            {
                GL.glNormal3d = (TglNormal3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3d));
            }

            if (GL.LinkProcGL("glNormal3dv"))
            {
                GL.glNormal3dv = (TglNormal3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3dv));
            }

            if (GL.LinkProcGL("glNormal3f"))
            {
                GL.glNormal3f = (TglNormal3f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3f));
            }

            if (GL.LinkProcGL("glNormal3fv"))
            {
                GL.glNormal3fv = (TglNormal3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3fv));
            }

            if (GL.LinkProcGL("glNormal3i"))
            {
                GL.glNormal3i = (TglNormal3i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3i));
            }

            if (GL.LinkProcGL("glNormal3iv"))
            {
                GL.glNormal3iv = (TglNormal3iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3iv));
            }

            if (GL.LinkProcGL("glNormal3s"))
            {
                GL.glNormal3s = (TglNormal3s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3s));
            }

            if (GL.LinkProcGL("glNormal3sv"))
            {
                GL.glNormal3sv = (TglNormal3sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormal3sv));
            }

            if (GL.LinkProcGL("glNormalPointer"))
            {
                GL.glNormalPointer = (TglNormalPointer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalPointer));
            }

            if (GL.LinkProcGL("glOrtho"))
            {
                GL.glOrtho = (TglOrtho)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglOrtho));
            }

            if (GL.LinkProcGL("glPassThrough"))
            {
                GL.glPassThrough = (TglPassThrough)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPassThrough));
            }

            if (GL.LinkProcGL("glPixelMapfv"))
            {
                GL.glPixelMapfv = (TglPixelMapfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelMapfv));
            }

            if (GL.LinkProcGL("glPixelMapuiv"))
            {
                GL.glPixelMapuiv = (TglPixelMapuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelMapuiv));
            }

            if (GL.LinkProcGL("glPixelMapusv"))
            {
                GL.glPixelMapusv = (TglPixelMapusv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelMapusv));
            }

            if (GL.LinkProcGL("glPixelStoref"))
            {
                GL.glPixelStoref = (TglPixelStoref)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelStoref));
            }

            if (GL.LinkProcGL("glPixelStorei"))
            {
                GL.glPixelStorei = (TglPixelStorei)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelStorei));
            }

            if (GL.LinkProcGL("glPixelTransferf"))
            {
                GL.glPixelTransferf = (TglPixelTransferf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelTransferf));
            }

            if (GL.LinkProcGL("glPixelTransferi"))
            {
                GL.glPixelTransferi = (TglPixelTransferi)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelTransferi));
            }

            if (GL.LinkProcGL("glPixelZoom"))
            {
                GL.glPixelZoom = (TglPixelZoom)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPixelZoom));
            }

            if (GL.LinkProcGL("glPointSize"))
            {
                GL.glPointSize = (TglPointSize)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointSize));
            }

            if (GL.LinkProcGL("glPolygonMode"))
            {
                GL.glPolygonMode = (TglPolygonMode)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPolygonMode));
            }

            if (GL.LinkProcGL("glPolygonOffset"))
            {
                GL.glPolygonOffset = (TglPolygonOffset)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPolygonOffset));
            }

            if (GL.LinkProcGL("glPolygonStipple"))
            {
                GL.glPolygonStipple = (TglPolygonStipple)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPolygonStipple));
            }

            if (GL.LinkProcGL("glPopAttrib"))
            {
                GL.glPopAttrib = (TglPopAttrib)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPopAttrib));
            }

            if (GL.LinkProcGL("glPopClientAttrib"))
            {
                GL.glPopClientAttrib = (TglPopClientAttrib)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPopClientAttrib));
            }

            if (GL.LinkProcGL("glPopMatrix"))
            {
                GL.glPopMatrix = (TglPopMatrix)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPopMatrix));
            }

            if (GL.LinkProcGL("glPopName"))
            {
                GL.glPopName = (TglPopName)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPopName));
            }

            if (GL.LinkProcGL("glPrioritizeTextures"))
            {
                GL.glPrioritizeTextures = (TglPrioritizeTextures)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPrioritizeTextures));
            }

            if (GL.LinkProcGL("glPushAttrib"))
            {
                GL.glPushAttrib = (TglPushAttrib)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPushAttrib));
            }

            if (GL.LinkProcGL("glPushClientAttrib"))
            {
                GL.glPushClientAttrib = (TglPushClientAttrib)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPushClientAttrib));
            }

            if (GL.LinkProcGL("glPushMatrix"))
            {
                GL.glPushMatrix = (TglPushMatrix)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPushMatrix));
            }

            if (GL.LinkProcGL("glPushName"))
            {
                GL.glPushName = (TglPushName)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPushName));
            }

            if (GL.LinkProcGL("glRasterPos2d"))
            {
                GL.glRasterPos2d = (TglRasterPos2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos2d));
            }

            if (GL.LinkProcGL("glRasterPos2dv"))
            {
                GL.glRasterPos2dv = (TglRasterPos2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos2dv));
            }

            if (GL.LinkProcGL("glRasterPos2f"))
            {
                GL.glRasterPos2f = (TglRasterPos2f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos2f));
            }

            if (GL.LinkProcGL("glRasterPos2fv"))
            {
                GL.glRasterPos2fv = (TglRasterPos2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos2fv));
            }

            if (GL.LinkProcGL("glRasterPos2i"))
            {
                GL.glRasterPos2i = (TglRasterPos2i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos2i));
            }

            if (GL.LinkProcGL("glRasterPos2iv"))
            {
                GL.glRasterPos2iv = (TglRasterPos2iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos2iv));
            }

            if (GL.LinkProcGL("glRasterPos2s"))
            {
                GL.glRasterPos2s = (TglRasterPos2s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos2s));
            }

            if (GL.LinkProcGL("glRasterPos2sv"))
            {
                GL.glRasterPos2sv = (TglRasterPos2sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos2sv));
            }

            if (GL.LinkProcGL("glRasterPos3d"))
            {
                GL.glRasterPos3d = (TglRasterPos3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos3d));
            }

            if (GL.LinkProcGL("glRasterPos3dv"))
            {
                GL.glRasterPos3dv = (TglRasterPos3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos3dv));
            }

            if (GL.LinkProcGL("glRasterPos3f"))
            {
                GL.glRasterPos3f = (TglRasterPos3f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos3f));
            }

            if (GL.LinkProcGL("glRasterPos3fv"))
            {
                GL.glRasterPos3fv = (TglRasterPos3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos3fv));
            }

            if (GL.LinkProcGL("glRasterPos3i"))
            {
                GL.glRasterPos3i = (TglRasterPos3i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos3i));
            }

            if (GL.LinkProcGL("glRasterPos3iv"))
            {
                GL.glRasterPos3iv = (TglRasterPos3iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos3iv));
            }

            if (GL.LinkProcGL("glRasterPos3s"))
            {
                GL.glRasterPos3s = (TglRasterPos3s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos3s));
            }

            if (GL.LinkProcGL("glRasterPos3sv"))
            {
                GL.glRasterPos3sv = (TglRasterPos3sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos3sv));
            }

            if (GL.LinkProcGL("glRasterPos4d"))
            {
                GL.glRasterPos4d = (TglRasterPos4d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos4d));
            }

            if (GL.LinkProcGL("glRasterPos4dv"))
            {
                GL.glRasterPos4dv = (TglRasterPos4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos4dv));
            }

            if (GL.LinkProcGL("glRasterPos4f"))
            {
                GL.glRasterPos4f = (TglRasterPos4f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos4f));
            }

            if (GL.LinkProcGL("glRasterPos4fv"))
            {
                GL.glRasterPos4fv = (TglRasterPos4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos4fv));
            }

            if (GL.LinkProcGL("glRasterPos4i"))
            {
                GL.glRasterPos4i = (TglRasterPos4i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos4i));
            }

            if (GL.LinkProcGL("glRasterPos4iv"))
            {
                GL.glRasterPos4iv = (TglRasterPos4iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos4iv));
            }

            if (GL.LinkProcGL("glRasterPos4s"))
            {
                GL.glRasterPos4s = (TglRasterPos4s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos4s));
            }

            if (GL.LinkProcGL("glRasterPos4sv"))
            {
                GL.glRasterPos4sv = (TglRasterPos4sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRasterPos4sv));
            }

            if (GL.LinkProcGL("glReadBuffer"))
            {
                GL.glReadBuffer = (TglReadBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReadBuffer));
            }

            if (GL.LinkProcGL("glReadPixels"))
            {
                GL.glReadPixels = (TglReadPixels)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReadPixels));
            }

            if (GL.LinkProcGL("glRectd"))
            {
                GL.glRectd = (TglRectd)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRectd));
            }

            if (GL.LinkProcGL("glRectdv"))
            {
                GL.glRectdv = (TglRectdv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRectdv));
            }

            if (GL.LinkProcGL("glRectf"))
            {
                GL.glRectf = (TglRectf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRectf));
            }

            if (GL.LinkProcGL("glRectfv"))
            {
                GL.glRectfv = (TglRectfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRectfv));
            }

            if (GL.LinkProcGL("glRecti"))
            {
                GL.glRecti = (TglRecti)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRecti));
            }

            if (GL.LinkProcGL("glRectiv"))
            {
                GL.glRectiv = (TglRectiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRectiv));
            }

            if (GL.LinkProcGL("glRects"))
            {
                GL.glRects = (TglRects)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRects));
            }

            if (GL.LinkProcGL("glRectsv"))
            {
                GL.glRectsv = (TglRectsv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRectsv));
            }

            if (GL.LinkProcGL("glRenderMode"))
            {
                GL.glRenderMode = (TglRenderMode)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRenderMode));
            }

            if (GL.LinkProcGL("glRotated"))
            {
                GL.glRotated = (TglRotated)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRotated));
            }

            if (GL.LinkProcGL("glRotatef"))
            {
                GL.glRotatef = (TglRotatef)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRotatef));
            }

            if (GL.LinkProcGL("glScaled"))
            {
                GL.glScaled = (TglScaled)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglScaled));
            }

            if (GL.LinkProcGL("glScalef"))
            {
                GL.glScalef = (TglScalef)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglScalef));
            }

            if (GL.LinkProcGL("glScissor"))
            {
                GL.glScissor = (TglScissor)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglScissor));
            }

            if (GL.LinkProcGL("glSelectBuffer"))
            {
                GL.glSelectBuffer = (TglSelectBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSelectBuffer));
            }

            if (GL.LinkProcGL("glShadeModel"))
            {
                GL.glShadeModel = (TglShadeModel)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglShadeModel));
            }

            if (GL.LinkProcGL("glStencilFunc"))
            {
                GL.glStencilFunc = (TglStencilFunc)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilFunc));
            }

            if (GL.LinkProcGL("glStencilMask"))
            {
                GL.glStencilMask = (TglStencilMask)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilMask));
            }

            if (GL.LinkProcGL("glStencilOp"))
            {
                GL.glStencilOp = (TglStencilOp)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilOp));
            }

            if (GL.LinkProcGL("glTexCoord1d"))
            {
                GL.glTexCoord1d = (TglTexCoord1d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1d));
            }

            if (GL.LinkProcGL("glTexCoord1dv"))
            {
                GL.glTexCoord1dv = (TglTexCoord1dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1dv));
            }

            if (GL.LinkProcGL("glTexCoord1f"))
            {
                GL.glTexCoord1f = (TglTexCoord1f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1f));
            }

            if (GL.LinkProcGL("glTexCoord1fv"))
            {
                GL.glTexCoord1fv = (TglTexCoord1fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1fv));
            }

            if (GL.LinkProcGL("glTexCoord1i"))
            {
                GL.glTexCoord1i = (TglTexCoord1i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1i));
            }

            if (GL.LinkProcGL("glTexCoord1iv"))
            {
                GL.glTexCoord1iv = (TglTexCoord1iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1iv));
            }

            if (GL.LinkProcGL("glTexCoord1s"))
            {
                GL.glTexCoord1s = (TglTexCoord1s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1s));
            }

            if (GL.LinkProcGL("glTexCoord1sv"))
            {
                GL.glTexCoord1sv = (TglTexCoord1sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord1sv));
            }

            if (GL.LinkProcGL("glTexCoord2d"))
            {
                GL.glTexCoord2d = (TglTexCoord2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2d));
            }

            if (GL.LinkProcGL("glTexCoord2dv"))
            {
                GL.glTexCoord2dv = (TglTexCoord2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2dv));
            }

            if (GL.LinkProcGL("glTexCoord2f"))
            {
                GL.glTexCoord2f = (TglTexCoord2f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2f));
            }

            if (GL.LinkProcGL("glTexCoord2fv"))
            {
                GL.glTexCoord2fv = (TglTexCoord2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2fv));
            }

            if (GL.LinkProcGL("glTexCoord2i"))
            {
                GL.glTexCoord2i = (TglTexCoord2i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2i));
            }

            if (GL.LinkProcGL("glTexCoord2iv"))
            {
                GL.glTexCoord2iv = (TglTexCoord2iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2iv));
            }

            if (GL.LinkProcGL("glTexCoord2s"))
            {
                GL.glTexCoord2s = (TglTexCoord2s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2s));
            }

            if (GL.LinkProcGL("glTexCoord2sv"))
            {
                GL.glTexCoord2sv = (TglTexCoord2sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord2sv));
            }

            if (GL.LinkProcGL("glTexCoord3d"))
            {
                GL.glTexCoord3d = (TglTexCoord3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3d));
            }

            if (GL.LinkProcGL("glTexCoord3dv"))
            {
                GL.glTexCoord3dv = (TglTexCoord3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3dv));
            }

            if (GL.LinkProcGL("glTexCoord3f"))
            {
                GL.glTexCoord3f = (TglTexCoord3f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3f));
            }

            if (GL.LinkProcGL("glTexCoord3fv"))
            {
                GL.glTexCoord3fv = (TglTexCoord3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3fv));
            }

            if (GL.LinkProcGL("glTexCoord3i"))
            {
                GL.glTexCoord3i = (TglTexCoord3i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3i));
            }

            if (GL.LinkProcGL("glTexCoord3iv"))
            {
                GL.glTexCoord3iv = (TglTexCoord3iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3iv));
            }

            if (GL.LinkProcGL("glTexCoord3s"))
            {
                GL.glTexCoord3s = (TglTexCoord3s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3s));
            }

            if (GL.LinkProcGL("glTexCoord3sv"))
            {
                GL.glTexCoord3sv = (TglTexCoord3sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord3sv));
            }

            if (GL.LinkProcGL("glTexCoord4d"))
            {
                GL.glTexCoord4d = (TglTexCoord4d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4d));
            }

            if (GL.LinkProcGL("glTexCoord4dv"))
            {
                GL.glTexCoord4dv = (TglTexCoord4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4dv));
            }

            if (GL.LinkProcGL("glTexCoord4f"))
            {
                GL.glTexCoord4f = (TglTexCoord4f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4f));
            }

            if (GL.LinkProcGL("glTexCoord4fv"))
            {
                GL.glTexCoord4fv = (TglTexCoord4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4fv));
            }

            if (GL.LinkProcGL("glTexCoord4i"))
            {
                GL.glTexCoord4i = (TglTexCoord4i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4i));
            }

            if (GL.LinkProcGL("glTexCoord4iv"))
            {
                GL.glTexCoord4iv = (TglTexCoord4iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4iv));
            }

            if (GL.LinkProcGL("glTexCoord4s"))
            {
                GL.glTexCoord4s = (TglTexCoord4s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4s));
            }

            if (GL.LinkProcGL("glTexCoord4sv"))
            {
                GL.glTexCoord4sv = (TglTexCoord4sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoord4sv));
            }

            if (GL.LinkProcGL("glTexCoordPointer"))
            {
                GL.glTexCoordPointer = (TglTexCoordPointer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordPointer));
            }

            if (GL.LinkProcGL("glTexEnvf"))
            {
                GL.glTexEnvf = (TglTexEnvf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexEnvf));
            }

            if (GL.LinkProcGL("glTexEnvfv"))
            {
                GL.glTexEnvfv = (TglTexEnvfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexEnvfv));
            }

            if (GL.LinkProcGL("glTexEnvi"))
            {
                GL.glTexEnvi = (TglTexEnvi)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexEnvi));
            }

            if (GL.LinkProcGL("glTexEnviv"))
            {
                GL.glTexEnviv = (TglTexEnviv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexEnviv));
            }

            if (GL.LinkProcGL("glTexGend"))
            {
                GL.glTexGend = (TglTexGend)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexGend));
            }

            if (GL.LinkProcGL("glTexGendv"))
            {
                GL.glTexGendv = (TglTexGendv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexGendv));
            }

            if (GL.LinkProcGL("glTexGenf"))
            {
                GL.glTexGenf = (TglTexGenf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexGenf));
            }

            if (GL.LinkProcGL("glTexGenfv"))
            {
                GL.glTexGenfv = (TglTexGenfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexGenfv));
            }

            if (GL.LinkProcGL("glTexGeni"))
            {
                GL.glTexGeni = (TglTexGeni)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexGeni));
            }

            if (GL.LinkProcGL("glTexGeniv"))
            {
                GL.glTexGeniv = (TglTexGeniv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexGeniv));
            }

            if (GL.LinkProcGL("glTexImage1D"))
            {
                GL.glTexImage1D = (TglTexImage1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexImage1D));
            }

            if (GL.LinkProcGL("glTexImage2D"))
            {
                GL.glTexImage2D = (TglTexImage2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexImage2D));
            }

            if (GL.LinkProcGL("glTexParameterf"))
            {
                GL.glTexParameterf = (TglTexParameterf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexParameterf));
            }

            if (GL.LinkProcGL("glTexParameterfv"))
            {
                GL.glTexParameterfv = (TglTexParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexParameterfv));
            }

            if (GL.LinkProcGL("glTexParameteri"))
            {
                GL.glTexParameteri = (TglTexParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexParameteri));
            }

            if (GL.LinkProcGL("glTexParameteriv"))
            {
                GL.glTexParameteriv = (TglTexParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexParameteriv));
            }

            if (GL.LinkProcGL("glTexSubImage1D"))
            {
                GL.glTexSubImage1D = (TglTexSubImage1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexSubImage1D));
            }

            if (GL.LinkProcGL("glTexSubImage2D"))
            {
                GL.glTexSubImage2D = (TglTexSubImage2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexSubImage2D));
            }

            if (GL.LinkProcGL("glTranslated"))
            {
                GL.glTranslated = (TglTranslated)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTranslated));
            }

            if (GL.LinkProcGL("glTranslatef"))
            {
                GL.glTranslatef = (TglTranslatef)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTranslatef));
            }

            if (GL.LinkProcGL("glVertex2d"))
            {
                GL.glVertex2d = (TglVertex2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2d));
            }

            if (GL.LinkProcGL("glVertex2dv"))
            {
                GL.glVertex2dv = (TglVertex2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2dv));
            }

            if (GL.LinkProcGL("glVertex2f"))
            {
                GL.glVertex2f = (TglVertex2f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2f));
            }

            if (GL.LinkProcGL("glVertex2fv"))
            {
                GL.glVertex2fv = (TglVertex2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2fv));
            }

            if (GL.LinkProcGL("glVertex2i"))
            {
                GL.glVertex2i = (TglVertex2i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2i));
            }

            if (GL.LinkProcGL("glVertex2iv"))
            {
                GL.glVertex2iv = (TglVertex2iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2iv));
            }

            if (GL.LinkProcGL("glVertex2s"))
            {
                GL.glVertex2s = (TglVertex2s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2s));
            }

            if (GL.LinkProcGL("glVertex2sv"))
            {
                GL.glVertex2sv = (TglVertex2sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex2sv));
            }

            if (GL.LinkProcGL("glVertex3d"))
            {
                GL.glVertex3d = (TglVertex3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3d));
            }

            if (GL.LinkProcGL("glVertex3dv"))
            {
                GL.glVertex3dv = (TglVertex3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3dv));
            }

            if (GL.LinkProcGL("glVertex3f"))
            {
                GL.glVertex3f = (TglVertex3f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3f));
            }

            if (GL.LinkProcGL("glVertex3fv"))
            {
                GL.glVertex3fv = (TglVertex3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3fv));
            }

            if (GL.LinkProcGL("glVertex3i"))
            {
                GL.glVertex3i = (TglVertex3i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3i));
            }

            if (GL.LinkProcGL("glVertex3iv"))
            {
                GL.glVertex3iv = (TglVertex3iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3iv));
            }

            if (GL.LinkProcGL("glVertex3s"))
            {
                GL.glVertex3s = (TglVertex3s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3s));
            }

            if (GL.LinkProcGL("glVertex3sv"))
            {
                GL.glVertex3sv = (TglVertex3sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex3sv));
            }

            if (GL.LinkProcGL("glVertex4d"))
            {
                GL.glVertex4d = (TglVertex4d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4d));
            }

            if (GL.LinkProcGL("glVertex4dv"))
            {
                GL.glVertex4dv = (TglVertex4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4dv));
            }

            if (GL.LinkProcGL("glVertex4f"))
            {
                GL.glVertex4f = (TglVertex4f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4f));
            }

            if (GL.LinkProcGL("glVertex4fv"))
            {
                GL.glVertex4fv = (TglVertex4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4fv));
            }

            if (GL.LinkProcGL("glVertex4i"))
            {
                GL.glVertex4i = (TglVertex4i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4i));
            }

            if (GL.LinkProcGL("glVertex4iv"))
            {
                GL.glVertex4iv = (TglVertex4iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4iv));
            }

            if (GL.LinkProcGL("glVertex4s"))
            {
                GL.glVertex4s = (TglVertex4s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4s));
            }

            if (GL.LinkProcGL("glVertex4sv"))
            {
                GL.glVertex4sv = (TglVertex4sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertex4sv));
            }

            if (GL.LinkProcGL("glVertexPointer"))
            {
                GL.glVertexPointer = (TglVertexPointer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexPointer));
            }

            if (GL.LinkProcGL("glViewport"))
            {
                GL.glViewport = (TglViewport)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglViewport));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 1.2 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 1.2 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 1.2 FUNCTIONS...
            if (GL.LinkProcGL("glDrawRangeElements"))
            {
                GL.glDrawRangeElements = (TglDrawRangeElements)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawRangeElements));
            }

            if (GL.LinkProcGL("glTexImage3D"))
            {
                GL.glTexImage3D = (TglTexImage3D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexImage3D));
            }

            if (GL.LinkProcGL("glTexSubImage3D"))
            {
                GL.glTexSubImage3D = (TglTexSubImage3D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexSubImage3D));
            }

            if (GL.LinkProcGL("glCopyTexSubImage3D"))
            {
                GL.glCopyTexSubImage3D = (TglCopyTexSubImage3D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTexSubImage3D));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 1.2: GL_ARB_imaging FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 1.2: GL_ARB_imaging functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 1.2: GL_ARB_imaging FUNCTIONS...
            if (GL.LinkProcGL("glBlendColor"))
            {
                GL.glBlendColor = (TglBlendColor)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendColor));
            }

            if (GL.LinkProcGL("glBlendEquation"))
            {
                GL.glBlendEquation = (TglBlendEquation)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendEquation));
            }

            if (GL.LinkProcGL("glColorSubTable"))
            {
                GL.glColorSubTable = (TglColorSubTable)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorSubTable));
            }

            if (GL.LinkProcGL("glCopyColorSubTable"))
            {
                GL.glCopyColorSubTable = (TglCopyColorSubTable)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyColorSubTable));
            }

            if (GL.LinkProcGL("glColorTable"))
            {
                GL.glColorTable = (TglColorTable)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorTable));
            }

            if (GL.LinkProcGL("glCopyColorTable"))
            {
                GL.glCopyColorTable = (TglCopyColorTable)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyColorTable));
            }

            if (GL.LinkProcGL("glColorTableParameteriv"))
            {
                GL.glColorTableParameteriv = (TglColorTableParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorTableParameteriv));
            }

            if (GL.LinkProcGL("glColorTableParameterfv"))
            {
                GL.glColorTableParameterfv = (TglColorTableParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorTableParameterfv));
            }

            if (GL.LinkProcGL("glGetColorTable"))
            {
                GL.glGetColorTable = (TglGetColorTable)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetColorTable));
            }

            if (GL.LinkProcGL("glGetColorTableParameteriv"))
            {
                GL.glGetColorTableParameteriv = (TglGetColorTableParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetColorTableParameteriv));
            }

            if (GL.LinkProcGL("glGetColorTableParameterfv"))
            {
                GL.glGetColorTableParameterfv = (TglGetColorTableParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetColorTableParameterfv));
            }

            if (GL.LinkProcGL("glConvolutionFilter1D"))
            {
                GL.glConvolutionFilter1D = (TglConvolutionFilter1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionFilter1D));
            }

            if (GL.LinkProcGL("glConvolutionFilter2D"))
            {
                GL.glConvolutionFilter2D = (TglConvolutionFilter2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionFilter2D));
            }

            if (GL.LinkProcGL("glCopyConvolutionFilter1D"))
            {
                GL.glCopyConvolutionFilter1D = (TglCopyConvolutionFilter1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyConvolutionFilter1D));
            }

            if (GL.LinkProcGL("glCopyConvolutionFilter2D"))
            {
                GL.glCopyConvolutionFilter2D = (TglCopyConvolutionFilter2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyConvolutionFilter2D));
            }

            if (GL.LinkProcGL("glGetConvolutionFilter"))
            {
                GL.glGetConvolutionFilter = (TglGetConvolutionFilter)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetConvolutionFilter));
            }

            if (GL.LinkProcGL("glSeparableFilter2D"))
            {
                GL.glSeparableFilter2D = (TglSeparableFilter2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSeparableFilter2D));
            }

            if (GL.LinkProcGL("glGetSeparableFilter"))
            {
                GL.glGetSeparableFilter = (TglGetSeparableFilter)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSeparableFilter));
            }

            if (GL.LinkProcGL("glConvolutionParameteri"))
            {
                GL.glConvolutionParameteri = (TglConvolutionParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameteri));
            }

            if (GL.LinkProcGL("glConvolutionParameteriv"))
            {
                GL.glConvolutionParameteriv = (TglConvolutionParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameteriv));
            }

            if (GL.LinkProcGL("glConvolutionParameterf"))
            {
                GL.glConvolutionParameterf = (TglConvolutionParameterf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameterf));
            }

            if (GL.LinkProcGL("glConvolutionParameterfv"))
            {
                GL.glConvolutionParameterfv = (TglConvolutionParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglConvolutionParameterfv));
            }

            if (GL.LinkProcGL("glGetConvolutionParameteriv"))
            {
                GL.glGetConvolutionParameteriv = (TglGetConvolutionParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetConvolutionParameteriv));
            }

            if (GL.LinkProcGL("glGetConvolutionParameterfv"))
            {
                GL.glGetConvolutionParameterfv = (TglGetConvolutionParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetConvolutionParameterfv));
            }

            if (GL.LinkProcGL("glHistogram"))
            {
                GL.glHistogram = (TglHistogram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglHistogram));
            }

            if (GL.LinkProcGL("glResetHistogram"))
            {
                GL.glResetHistogram = (TglResetHistogram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglResetHistogram));
            }

            if (GL.LinkProcGL("glGetHistogram"))
            {
                GL.glGetHistogram = (TglGetHistogram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetHistogram));
            }

            if (GL.LinkProcGL("glGetHistogramParameteriv"))
            {
                GL.glGetHistogramParameteriv = (TglGetHistogramParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetHistogramParameteriv));
            }

            if (GL.LinkProcGL("glGetHistogramParameterfv"))
            {
                GL.glGetHistogramParameterfv = (TglGetHistogramParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetHistogramParameterfv));
            }

            if (GL.LinkProcGL("glMinmax"))
            {
                GL.glMinmax = (TglMinmax)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMinmax));
            }

            if (GL.LinkProcGL("glResetMinmax"))
            {
                GL.glResetMinmax = (TglResetMinmax)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglResetMinmax));
            }

            if (GL.LinkProcGL("glGetMinmax"))
            {
                GL.glGetMinmax = (TglGetMinmax)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMinmax));
            }

            if (GL.LinkProcGL("glGetMinmaxParameteriv"))
            {
                GL.glGetMinmaxParameteriv = (TglGetMinmaxParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMinmaxParameteriv));
            }

            if (GL.LinkProcGL("glGetMinmaxParameterfv"))
            {
                GL.glGetMinmaxParameterfv = (TglGetMinmaxParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMinmaxParameterfv));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 1.3 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 1.3 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 1.3 FUNCTIONS...
            if (GL.LinkProcGL("glActiveTexture"))
            {
                GL.glActiveTexture = (TglActiveTexture)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglActiveTexture));
            }

            if (GL.LinkProcGL("glClientActiveTexture"))
            {
                GL.glClientActiveTexture = (TglClientActiveTexture)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClientActiveTexture));
            }

            if (GL.LinkProcGL("glCompressedTexImage1D"))
            {
                GL.glCompressedTexImage1D = (TglCompressedTexImage1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTexImage1D));
            }

            if (GL.LinkProcGL("glCompressedTexImage2D"))
            {
                GL.glCompressedTexImage2D = (TglCompressedTexImage2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTexImage2D));
            }

            if (GL.LinkProcGL("glCompressedTexImage3D"))
            {
                GL.glCompressedTexImage3D = (TglCompressedTexImage3D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTexImage3D));
            }

            if (GL.LinkProcGL("glCompressedTexSubImage1D"))
            {
                GL.glCompressedTexSubImage1D = (TglCompressedTexSubImage1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTexSubImage1D));
            }

            if (GL.LinkProcGL("glCompressedTexSubImage2D"))
            {
                GL.glCompressedTexSubImage2D = (TglCompressedTexSubImage2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTexSubImage2D));
            }

            if (GL.LinkProcGL("glCompressedTexSubImage3D"))
            {
                GL.glCompressedTexSubImage3D = (TglCompressedTexSubImage3D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTexSubImage3D));
            }

            if (GL.LinkProcGL("glGetCompressedTexImage"))
            {
                GL.glGetCompressedTexImage = (TglGetCompressedTexImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetCompressedTexImage));
            }

            if (GL.LinkProcGL("glMultiTexCoord1d"))
            {
                GL.glMultiTexCoord1d = (TglMultiTexCoord1d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1d));
            }

            if (GL.LinkProcGL("glMultiTexCoord1dv"))
            {
                GL.glMultiTexCoord1dv = (TglMultiTexCoord1dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1dv));
            }

            if (GL.LinkProcGL("glMultiTexCoord1f"))
            {
                GL.glMultiTexCoord1f = (TglMultiTexCoord1f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1f));
            }

            if (GL.LinkProcGL("glMultiTexCoord1fv"))
            {
                GL.glMultiTexCoord1fv = (TglMultiTexCoord1fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1fv));
            }

            if (GL.LinkProcGL("glMultiTexCoord1i"))
            {
                GL.glMultiTexCoord1i = (TglMultiTexCoord1i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1i));
            }

            if (GL.LinkProcGL("glMultiTexCoord1iv"))
            {
                GL.glMultiTexCoord1iv = (TglMultiTexCoord1iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1iv));
            }

            if (GL.LinkProcGL("glMultiTexCoord1s"))
            {
                GL.glMultiTexCoord1s = (TglMultiTexCoord1s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1s));
            }

            if (GL.LinkProcGL("glMultiTexCoord1sv"))
            {
                GL.glMultiTexCoord1sv = (TglMultiTexCoord1sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord1sv));
            }

            if (GL.LinkProcGL("glMultiTexCoord2d"))
            {
                GL.glMultiTexCoord2d = (TglMultiTexCoord2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2d));
            }

            if (GL.LinkProcGL("glMultiTexCoord2dv"))
            {
                GL.glMultiTexCoord2dv = (TglMultiTexCoord2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2dv));
            }

            if (GL.LinkProcGL("glMultiTexCoord2f"))
            {
                GL.glMultiTexCoord2f = (TglMultiTexCoord2f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2f));
            }

            if (GL.LinkProcGL("glMultiTexCoord2fv"))
            {
                GL.glMultiTexCoord2fv = (TglMultiTexCoord2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2fv));
            }

            if (GL.LinkProcGL("glMultiTexCoord2i"))
            {
                GL.glMultiTexCoord2i = (TglMultiTexCoord2i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2i));
            }

            if (GL.LinkProcGL("glMultiTexCoord2iv"))
            {
                GL.glMultiTexCoord2iv = (TglMultiTexCoord2iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2iv));
            }

            if (GL.LinkProcGL("glMultiTexCoord2s"))
            {
                GL.glMultiTexCoord2s = (TglMultiTexCoord2s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2s));
            }

            if (GL.LinkProcGL("glMultiTexCoord2sv"))
            {
                GL.glMultiTexCoord2sv = (TglMultiTexCoord2sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord2sv));
            }

            if (GL.LinkProcGL("glMultiTexCoord3d"))
            {
                GL.glMultiTexCoord3d = (TglMultiTexCoord3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3d));
            }

            if (GL.LinkProcGL("glMultiTexCoord3dv"))
            {
                GL.glMultiTexCoord3dv = (TglMultiTexCoord3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3dv));
            }

            if (GL.LinkProcGL("glMultiTexCoord3f"))
            {
                GL.glMultiTexCoord3f = (TglMultiTexCoord3f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3f));
            }

            if (GL.LinkProcGL("glMultiTexCoord3fv"))
            {
                GL.glMultiTexCoord3fv = (TglMultiTexCoord3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3fv));
            }

            if (GL.LinkProcGL("glMultiTexCoord3i"))
            {
                GL.glMultiTexCoord3i = (TglMultiTexCoord3i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3i));
            }

            if (GL.LinkProcGL("glMultiTexCoord3iv"))
            {
                GL.glMultiTexCoord3iv = (TglMultiTexCoord3iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3iv));
            }

            if (GL.LinkProcGL("glMultiTexCoord3s"))
            {
                GL.glMultiTexCoord3s = (TglMultiTexCoord3s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3s));
            }

            if (GL.LinkProcGL("glMultiTexCoord3sv"))
            {
                GL.glMultiTexCoord3sv = (TglMultiTexCoord3sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord3sv));
            }

            if (GL.LinkProcGL("glMultiTexCoord4d"))
            {
                GL.glMultiTexCoord4d = (TglMultiTexCoord4d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4d));
            }

            if (GL.LinkProcGL("glMultiTexCoord4dv"))
            {
                GL.glMultiTexCoord4dv = (TglMultiTexCoord4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4dv));
            }

            if (GL.LinkProcGL("glMultiTexCoord4f"))
            {
                GL.glMultiTexCoord4f = (TglMultiTexCoord4f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4f));
            }

            if (GL.LinkProcGL("glMultiTexCoord4fv"))
            {
                GL.glMultiTexCoord4fv = (TglMultiTexCoord4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4fv));
            }

            if (GL.LinkProcGL("glMultiTexCoord4i"))
            {
                GL.glMultiTexCoord4i = (TglMultiTexCoord4i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4i));
            }

            if (GL.LinkProcGL("glMultiTexCoord4iv"))
            {
                GL.glMultiTexCoord4iv = (TglMultiTexCoord4iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4iv));
            }

            if (GL.LinkProcGL("glMultiTexCoord4s"))
            {
                GL.glMultiTexCoord4s = (TglMultiTexCoord4s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4s));
            }

            if (GL.LinkProcGL("glMultiTexCoord4sv"))
            {
                GL.glMultiTexCoord4sv = (TglMultiTexCoord4sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoord4sv));
            }

            if (GL.LinkProcGL("glLoadTransposeMatrixd"))
            {
                GL.glLoadTransposeMatrixd = (TglLoadTransposeMatrixd)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLoadTransposeMatrixd));
            }

            if (GL.LinkProcGL("glLoadTransposeMatrixf"))
            {
                GL.glLoadTransposeMatrixf = (TglLoadTransposeMatrixf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLoadTransposeMatrixf));
            }

            if (GL.LinkProcGL("glMultTransposeMatrixd"))
            {
                GL.glMultTransposeMatrixd = (TglMultTransposeMatrixd)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultTransposeMatrixd));
            }

            if (GL.LinkProcGL("glMultTransposeMatrixf"))
            {
                GL.glMultTransposeMatrixf = (TglMultTransposeMatrixf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultTransposeMatrixf));
            }

            if (GL.LinkProcGL("glSampleCoverage"))
            {
                GL.glSampleCoverage = (TglSampleCoverage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSampleCoverage));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 1.4 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 1.4 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 1.4 FUNCTIONS...
            if (GL.LinkProcGL("glBlendFuncSeparate"))
            {
                GL.glBlendFuncSeparate = (TglBlendFuncSeparate)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendFuncSeparate));
            }

            if (GL.LinkProcGL("glMultiDrawArrays"))
            {
                GL.glMultiDrawArrays = (TglMultiDrawArrays)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawArrays));
            }

            if (GL.LinkProcGL("glMultiDrawElements"))
            {
                GL.glMultiDrawElements = (TglMultiDrawElements)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawElements));
            }

            if (GL.LinkProcGL("glPointParameterf"))
            {
                GL.glPointParameterf = (TglPointParameterf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointParameterf));
            }

            if (GL.LinkProcGL("glPointParameterfv"))
            {
                GL.glPointParameterfv = (TglPointParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointParameterfv));
            }

            if (GL.LinkProcGL("glPointParameteri"))
            {
                GL.glPointParameteri = (TglPointParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointParameteri));
            }

            if (GL.LinkProcGL("glPointParameteriv"))
            {
                GL.glPointParameteriv = (TglPointParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPointParameteriv));
            }

            if (GL.LinkProcGL("glFogCoordf"))
            {
                GL.glFogCoordf = (TglFogCoordf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoordf));
            }

            if (GL.LinkProcGL("glFogCoordfv"))
            {
                GL.glFogCoordfv = (TglFogCoordfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoordfv));
            }

            if (GL.LinkProcGL("glFogCoordd"))
            {
                GL.glFogCoordd = (TglFogCoordd)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoordd));
            }

            if (GL.LinkProcGL("glFogCoorddv"))
            {
                GL.glFogCoorddv = (TglFogCoorddv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoorddv));
            }

            if (GL.LinkProcGL("glFogCoordPointer"))
            {
                GL.glFogCoordPointer = (TglFogCoordPointer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFogCoordPointer));
            }

            if (GL.LinkProcGL("glSecondaryColor3b"))
            {
                GL.glSecondaryColor3b = (TglSecondaryColor3b)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3b));
            }

            if (GL.LinkProcGL("glSecondaryColor3bv"))
            {
                GL.glSecondaryColor3bv = (TglSecondaryColor3bv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3bv));
            }

            if (GL.LinkProcGL("glSecondaryColor3d"))
            {
                GL.glSecondaryColor3d = (TglSecondaryColor3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3d));
            }

            if (GL.LinkProcGL("glSecondaryColor3dv"))
            {
                GL.glSecondaryColor3dv = (TglSecondaryColor3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3dv));
            }

            if (GL.LinkProcGL("glSecondaryColor3f"))
            {
                GL.glSecondaryColor3f = (TglSecondaryColor3f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3f));
            }

            if (GL.LinkProcGL("glSecondaryColor3fv"))
            {
                GL.glSecondaryColor3fv = (TglSecondaryColor3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3fv));
            }

            if (GL.LinkProcGL("glSecondaryColor3i"))
            {
                GL.glSecondaryColor3i = (TglSecondaryColor3i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3i));
            }

            if (GL.LinkProcGL("glSecondaryColor3iv"))
            {
                GL.glSecondaryColor3iv = (TglSecondaryColor3iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3iv));
            }

            if (GL.LinkProcGL("glSecondaryColor3s"))
            {
                GL.glSecondaryColor3s = (TglSecondaryColor3s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3s));
            }

            if (GL.LinkProcGL("glSecondaryColor3sv"))
            {
                GL.glSecondaryColor3sv = (TglSecondaryColor3sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3sv));
            }

            if (GL.LinkProcGL("glSecondaryColor3ub"))
            {
                GL.glSecondaryColor3ub = (TglSecondaryColor3ub)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3ub));
            }

            if (GL.LinkProcGL("glSecondaryColor3ubv"))
            {
                GL.glSecondaryColor3ubv = (TglSecondaryColor3ubv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3ubv));
            }

            if (GL.LinkProcGL("glSecondaryColor3ui"))
            {
                GL.glSecondaryColor3ui = (TglSecondaryColor3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3ui));
            }

            if (GL.LinkProcGL("glSecondaryColor3uiv"))
            {
                GL.glSecondaryColor3uiv = (TglSecondaryColor3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3uiv));
            }

            if (GL.LinkProcGL("glSecondaryColor3us"))
            {
                GL.glSecondaryColor3us = (TglSecondaryColor3us)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3us));
            }

            if (GL.LinkProcGL("glSecondaryColor3usv"))
            {
                GL.glSecondaryColor3usv = (TglSecondaryColor3usv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColor3usv));
            }

            if (GL.LinkProcGL("glSecondaryColorPointer"))
            {
                GL.glSecondaryColorPointer = (TglSecondaryColorPointer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColorPointer));
            }

            if (GL.LinkProcGL("glWindowPos2d"))
            {
                GL.glWindowPos2d = (TglWindowPos2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2d));
            }

            if (GL.LinkProcGL("glWindowPos2dv"))
            {
                GL.glWindowPos2dv = (TglWindowPos2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2dv));
            }

            if (GL.LinkProcGL("glWindowPos2f"))
            {
                GL.glWindowPos2f = (TglWindowPos2f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2f));
            }

            if (GL.LinkProcGL("glWindowPos2fv"))
            {
                GL.glWindowPos2fv = (TglWindowPos2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2fv));
            }

            if (GL.LinkProcGL("glWindowPos2i"))
            {
                GL.glWindowPos2i = (TglWindowPos2i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2i));
            }

            if (GL.LinkProcGL("glWindowPos2iv"))
            {
                GL.glWindowPos2iv = (TglWindowPos2iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2iv));
            }

            if (GL.LinkProcGL("glWindowPos2s"))
            {
                GL.glWindowPos2s = (TglWindowPos2s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2s));
            }

            if (GL.LinkProcGL("glWindowPos2sv"))
            {
                GL.glWindowPos2sv = (TglWindowPos2sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos2sv));
            }

            if (GL.LinkProcGL("glWindowPos3d"))
            {
                GL.glWindowPos3d = (TglWindowPos3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3d));
            }

            if (GL.LinkProcGL("glWindowPos3dv"))
            {
                GL.glWindowPos3dv = (TglWindowPos3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3dv));
            }

            if (GL.LinkProcGL("glWindowPos3f"))
            {
                GL.glWindowPos3f = (TglWindowPos3f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3f));
            }

            if (GL.LinkProcGL("glWindowPos3fv"))
            {
                GL.glWindowPos3fv = (TglWindowPos3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3fv));
            }

            if (GL.LinkProcGL("glWindowPos3i"))
            {
                GL.glWindowPos3i = (TglWindowPos3i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3i));
            }

            if (GL.LinkProcGL("glWindowPos3iv"))
            {
                GL.glWindowPos3iv = (TglWindowPos3iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3iv));
            }

            if (GL.LinkProcGL("glWindowPos3s"))
            {
                GL.glWindowPos3s = (TglWindowPos3s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3s));
            }

            if (GL.LinkProcGL("glWindowPos3sv"))
            {
                GL.glWindowPos3sv = (TglWindowPos3sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWindowPos3sv));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 1.5 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 1.5 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 1.5 FUNCTIONS...
            if (GL.LinkProcGL("glGenQueries"))
            {
                GL.glGenQueries = (TglGenQueries)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenQueries));
            }

            if (GL.LinkProcGL("glDeleteQueries"))
            {
                GL.glDeleteQueries = (TglDeleteQueries)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteQueries));
            }

            if (GL.LinkProcGL("glIsQuery"))
            {
                GL.glIsQuery = (TglIsQuery)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsQuery));
            }

            if (GL.LinkProcGL("glBeginQuery"))
            {
                GL.glBeginQuery = (TglBeginQuery)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginQuery));
            }

            if (GL.LinkProcGL("glEndQuery"))
            {
                GL.glEndQuery = (TglEndQuery)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndQuery));
            }

            if (GL.LinkProcGL("glGetQueryiv"))
            {
                GL.glGetQueryiv = (TglGetQueryiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryiv));
            }

            if (GL.LinkProcGL("glGetQueryObjectiv"))
            {
                GL.glGetQueryObjectiv = (TglGetQueryObjectiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryObjectiv));
            }

            if (GL.LinkProcGL("glGetQueryObjectuiv"))
            {
                GL.glGetQueryObjectuiv = (TglGetQueryObjectuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryObjectuiv));
            }

            if (GL.LinkProcGL("glBindBuffer"))
            {
                GL.glBindBuffer = (TglBindBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindBuffer));
            }

            if (GL.LinkProcGL("glDeleteBuffers"))
            {
                GL.glDeleteBuffers = (TglDeleteBuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteBuffers));
            }

            if (GL.LinkProcGL("glGenBuffers"))
            {
                GL.glGenBuffers = (TglGenBuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenBuffers));
            }

            if (GL.LinkProcGL("glIsBuffer"))
            {
                GL.glIsBuffer = (TglIsBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsBuffer));
            }

            if (GL.LinkProcGL("glBufferData"))
            {
                GL.glBufferData = (TglBufferData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBufferData));
            }

            if (GL.LinkProcGL("glBufferSubData"))
            {
                GL.glBufferSubData = (TglBufferSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBufferSubData));
            }

            if (GL.LinkProcGL("glGetBufferSubData"))
            {
                GL.glGetBufferSubData = (TglGetBufferSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetBufferSubData));
            }

            if (GL.LinkProcGL("glMapBuffer"))
            {
                GL.glMapBuffer = (TglMapBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapBuffer));
            }

            if (GL.LinkProcGL("glUnmapBuffer"))
            {
                GL.glUnmapBuffer = (TglUnmapBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUnmapBuffer));
            }

            if (GL.LinkProcGL("glGetBufferParameteriv"))
            {
                GL.glGetBufferParameteriv = (TglGetBufferParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetBufferParameteriv));
            }

            if (GL.LinkProcGL("glGetBufferPointerv"))
            {
                GL.glGetBufferPointerv = (TglGetBufferPointerv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetBufferPointerv));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 2.0 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 2.0 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 2.0 FUNCTIONS...
            if (GL.LinkProcGL("glBlendEquationSeparate"))
            {
                GL.glBlendEquationSeparate = (TglBlendEquationSeparate)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendEquationSeparate));
            }

            if (GL.LinkProcGL("glDrawBuffers"))
            {
                GL.glDrawBuffers = (TglDrawBuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawBuffers));
            }

            if (GL.LinkProcGL("glStencilOpSeparate"))
            {
                GL.glStencilOpSeparate = (TglStencilOpSeparate)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilOpSeparate));
            }

            if (GL.LinkProcGL("glStencilFuncSeparate"))
            {
                GL.glStencilFuncSeparate = (TglStencilFuncSeparate)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilFuncSeparate));
            }

            if (GL.LinkProcGL("glStencilMaskSeparate"))
            {
                GL.glStencilMaskSeparate = (TglStencilMaskSeparate)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglStencilMaskSeparate));
            }

            if (GL.LinkProcGL("glAttachShader"))
            {
                GL.glAttachShader = (TglAttachShader)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglAttachShader));
            }

            if (GL.LinkProcGL("glBindAttribLocation"))
            {
                GL.glBindAttribLocation = (TglBindAttribLocation)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindAttribLocation));
            }

            if (GL.LinkProcGL("glCompileShader"))
            {
                GL.glCompileShader = (TglCompileShader)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompileShader));
            }

            if (GL.LinkProcGL("glCreateProgram"))
            {
                GL.glCreateProgram = (TglCreateProgram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateProgram));
            }

            if (GL.LinkProcGL("glCreateShader"))
            {
                GL.glCreateShader = (TglCreateShader)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateShader));
            }

            if (GL.LinkProcGL("glDeleteProgram"))
            {
                GL.glDeleteProgram = (TglDeleteProgram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteProgram));
            }

            if (GL.LinkProcGL("glDeleteShader"))
            {
                GL.glDeleteShader = (TglDeleteShader)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteShader));
            }

            if (GL.LinkProcGL("glDetachShader"))
            {
                GL.glDetachShader = (TglDetachShader)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDetachShader));
            }

            if (GL.LinkProcGL("glDisableVertexAttribArray"))
            {
                GL.glDisableVertexAttribArray = (TglDisableVertexAttribArray)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDisableVertexAttribArray));
            }

            if (GL.LinkProcGL("glEnableVertexAttribArray"))
            {
                GL.glEnableVertexAttribArray = (TglEnableVertexAttribArray)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEnableVertexAttribArray));
            }

            if (GL.LinkProcGL("glGetActiveAttrib"))
            {
                GL.glGetActiveAttrib = (TglGetActiveAttrib)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveAttrib));
            }

            if (GL.LinkProcGL("glGetActiveUniform"))
            {
                GL.glGetActiveUniform = (TglGetActiveUniform)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveUniform));
            }

            if (GL.LinkProcGL("glGetAttachedShaders"))
            {
                GL.glGetAttachedShaders = (TglGetAttachedShaders)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetAttachedShaders));
            }

            if (GL.LinkProcGL("glGetAttribLocation"))
            {
                GL.glGetAttribLocation = (TglGetAttribLocation)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetAttribLocation));
            }

            if (GL.LinkProcGL("glGetProgramiv"))
            {
                GL.glGetProgramiv = (TglGetProgramiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramiv));
            }

            if (GL.LinkProcGL("glGetProgramInfoLog"))
            {
                GL.glGetProgramInfoLog = (TglGetProgramInfoLog)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramInfoLog));
            }

            if (GL.LinkProcGL("glGetShaderiv"))
            {
                GL.glGetShaderiv = (TglGetShaderiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetShaderiv));
            }

            if (GL.LinkProcGL("glGetShaderInfoLog"))
            {
                GL.glGetShaderInfoLog = (TglGetShaderInfoLog)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetShaderInfoLog));
            }

            if (GL.LinkProcGL("glGetShaderSource"))
            {
                GL.glGetShaderSource = (TglGetShaderSource)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetShaderSource));
            }

            if (GL.LinkProcGL("glGetUniformLocation"))
            {
                GL.glGetUniformLocation = (TglGetUniformLocation)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformLocation));
            }

            if (GL.LinkProcGL("glGetUniformfv"))
            {
                GL.glGetUniformfv = (TglGetUniformfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformfv));
            }

            if (GL.LinkProcGL("glGetUniformiv"))
            {
                GL.glGetUniformiv = (TglGetUniformiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformiv));
            }

            if (GL.LinkProcGL("glGetVertexAttribdv"))
            {
                GL.glGetVertexAttribdv = (TglGetVertexAttribdv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribdv));
            }

            if (GL.LinkProcGL("glGetVertexAttribfv"))
            {
                GL.glGetVertexAttribfv = (TglGetVertexAttribfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribfv));
            }

            if (GL.LinkProcGL("glGetVertexAttribiv"))
            {
                GL.glGetVertexAttribiv = (TglGetVertexAttribiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribiv));
            }

            if (GL.LinkProcGL("glGetVertexAttribPointerv"))
            {
                GL.glGetVertexAttribPointerv = (TglGetVertexAttribPointerv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribPointerv));
            }

            if (GL.LinkProcGL("glIsProgram"))
            {
                GL.glIsProgram = (TglIsProgram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsProgram));
            }

            if (GL.LinkProcGL("glIsShader"))
            {
                GL.glIsShader = (TglIsShader)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsShader));
            }

            if (GL.LinkProcGL("glLinkProgram"))
            {
                GL.glLinkProgram = (TglLinkProgram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglLinkProgram));
            }

            if (GL.LinkProcGL("glShaderSource"))
            {
                GL.glShaderSource = (TglShaderSource)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglShaderSource));
            }

            if (GL.LinkProcGL("glUseProgram"))
            {
                GL.glUseProgram = (TglUseProgram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUseProgram));
            }

            if (GL.LinkProcGL("glUniform1f"))
            {
                GL.glUniform1f = (TglUniform1f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1f));
            }

            if (GL.LinkProcGL("glUniform2f"))
            {
                GL.glUniform2f = (TglUniform2f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2f));
            }

            if (GL.LinkProcGL("glUniform3f"))
            {
                GL.glUniform3f = (TglUniform3f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3f));
            }

            if (GL.LinkProcGL("glUniform4f"))
            {
                GL.glUniform4f = (TglUniform4f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4f));
            }

            if (GL.LinkProcGL("glUniform1i"))
            {
                GL.glUniform1i = (TglUniform1i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1i));
            }

            if (GL.LinkProcGL("glUniform2i"))
            {
                GL.glUniform2i = (TglUniform2i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2i));
            }

            if (GL.LinkProcGL("glUniform3i"))
            {
                GL.glUniform3i = (TglUniform3i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3i));
            }

            if (GL.LinkProcGL("glUniform4i"))
            {
                GL.glUniform4i = (TglUniform4i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4i));
            }

            if (GL.LinkProcGL("glUniform1fv"))
            {
                GL.glUniform1fv = (TglUniform1fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1fv));
            }

            if (GL.LinkProcGL("glUniform2fv"))
            {
                GL.glUniform2fv = (TglUniform2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2fv));
            }

            if (GL.LinkProcGL("glUniform3fv"))
            {
                GL.glUniform3fv = (TglUniform3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3fv));
            }

            if (GL.LinkProcGL("glUniform4fv"))
            {
                GL.glUniform4fv = (TglUniform4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4fv));
            }

            if (GL.LinkProcGL("glUniform1iv"))
            {
                GL.glUniform1iv = (TglUniform1iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1iv));
            }

            if (GL.LinkProcGL("glUniform2iv"))
            {
                GL.glUniform2iv = (TglUniform2iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2iv));
            }

            if (GL.LinkProcGL("glUniform3iv"))
            {
                GL.glUniform3iv = (TglUniform3iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3iv));
            }

            if (GL.LinkProcGL("glUniform4iv"))
            {
                GL.glUniform4iv = (TglUniform4iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4iv));
            }

            if (GL.LinkProcGL("glUniformMatrix2fv"))
            {
                GL.glUniformMatrix2fv = (TglUniformMatrix2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix2fv));
            }

            if (GL.LinkProcGL("glUniformMatrix3fv"))
            {
                GL.glUniformMatrix3fv = (TglUniformMatrix3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix3fv));
            }

            if (GL.LinkProcGL("glUniformMatrix4fv"))
            {
                GL.glUniformMatrix4fv = (TglUniformMatrix4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix4fv));
            }

            if (GL.LinkProcGL("glValidateProgram"))
            {
                GL.glValidateProgram = (TglValidateProgram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglValidateProgram));
            }

            if (GL.LinkProcGL("glVertexAttrib1d"))
            {
                GL.glVertexAttrib1d = (TglVertexAttrib1d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1d));
            }

            if (GL.LinkProcGL("glVertexAttrib1dv"))
            {
                GL.glVertexAttrib1dv = (TglVertexAttrib1dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1dv));
            }

            if (GL.LinkProcGL("glVertexAttrib1f"))
            {
                GL.glVertexAttrib1f = (TglVertexAttrib1f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1f));
            }

            if (GL.LinkProcGL("glVertexAttrib1fv"))
            {
                GL.glVertexAttrib1fv = (TglVertexAttrib1fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1fv));
            }

            if (GL.LinkProcGL("glVertexAttrib1s"))
            {
                GL.glVertexAttrib1s = (TglVertexAttrib1s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1s));
            }

            if (GL.LinkProcGL("glVertexAttrib1sv"))
            {
                GL.glVertexAttrib1sv = (TglVertexAttrib1sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib1sv));
            }

            if (GL.LinkProcGL("glVertexAttrib2d"))
            {
                GL.glVertexAttrib2d = (TglVertexAttrib2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2d));
            }

            if (GL.LinkProcGL("glVertexAttrib2dv"))
            {
                GL.glVertexAttrib2dv = (TglVertexAttrib2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2dv));
            }

            if (GL.LinkProcGL("glVertexAttrib2f"))
            {
                GL.glVertexAttrib2f = (TglVertexAttrib2f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2f));
            }

            if (GL.LinkProcGL("glVertexAttrib2fv"))
            {
                GL.glVertexAttrib2fv = (TglVertexAttrib2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2fv));
            }

            if (GL.LinkProcGL("glVertexAttrib2s"))
            {
                GL.glVertexAttrib2s = (TglVertexAttrib2s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2s));
            }

            if (GL.LinkProcGL("glVertexAttrib2sv"))
            {
                GL.glVertexAttrib2sv = (TglVertexAttrib2sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib2sv));
            }

            if (GL.LinkProcGL("glVertexAttrib3d"))
            {
                GL.glVertexAttrib3d = (TglVertexAttrib3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3d));
            }

            if (GL.LinkProcGL("glVertexAttrib3dv"))
            {
                GL.glVertexAttrib3dv = (TglVertexAttrib3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3dv));
            }

            if (GL.LinkProcGL("glVertexAttrib3f"))
            {
                GL.glVertexAttrib3f = (TglVertexAttrib3f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3f));
            }

            if (GL.LinkProcGL("glVertexAttrib3fv"))
            {
                GL.glVertexAttrib3fv = (TglVertexAttrib3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3fv));
            }

            if (GL.LinkProcGL("glVertexAttrib3s"))
            {
                GL.glVertexAttrib3s = (TglVertexAttrib3s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3s));
            }

            if (GL.LinkProcGL("glVertexAttrib3sv"))
            {
                GL.glVertexAttrib3sv = (TglVertexAttrib3sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib3sv));
            }

            if (GL.LinkProcGL("glVertexAttrib4Nbv"))
            {
                GL.glVertexAttrib4Nbv = (TglVertexAttrib4Nbv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4Nbv));
            }

            if (GL.LinkProcGL("glVertexAttrib4Niv"))
            {
                GL.glVertexAttrib4Niv = (TglVertexAttrib4Niv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4Niv));
            }

            if (GL.LinkProcGL("glVertexAttrib4Nsv"))
            {
                GL.glVertexAttrib4Nsv = (TglVertexAttrib4Nsv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4Nsv));
            }

            if (GL.LinkProcGL("glVertexAttrib4Nub"))
            {
                GL.glVertexAttrib4Nub = (TglVertexAttrib4Nub)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4Nub));
            }

            if (GL.LinkProcGL("glVertexAttrib4Nubv"))
            {
                GL.glVertexAttrib4Nubv = (TglVertexAttrib4Nubv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4Nubv));
            }

            if (GL.LinkProcGL("glVertexAttrib4Nuiv"))
            {
                GL.glVertexAttrib4Nuiv = (TglVertexAttrib4Nuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4Nuiv));
            }

            if (GL.LinkProcGL("glVertexAttrib4Nusv"))
            {
                GL.glVertexAttrib4Nusv = (TglVertexAttrib4Nusv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4Nusv));
            }

            if (GL.LinkProcGL("glVertexAttrib4bv"))
            {
                GL.glVertexAttrib4bv = (TglVertexAttrib4bv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4bv));
            }

            if (GL.LinkProcGL("glVertexAttrib4d"))
            {
                GL.glVertexAttrib4d = (TglVertexAttrib4d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4d));
            }

            if (GL.LinkProcGL("glVertexAttrib4dv"))
            {
                GL.glVertexAttrib4dv = (TglVertexAttrib4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4dv));
            }

            if (GL.LinkProcGL("glVertexAttrib4f"))
            {
                GL.glVertexAttrib4f = (TglVertexAttrib4f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4f));
            }

            if (GL.LinkProcGL("glVertexAttrib4fv"))
            {
                GL.glVertexAttrib4fv = (TglVertexAttrib4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4fv));
            }

            if (GL.LinkProcGL("glVertexAttrib4iv"))
            {
                GL.glVertexAttrib4iv = (TglVertexAttrib4iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4iv));
            }

            if (GL.LinkProcGL("glVertexAttrib4s"))
            {
                GL.glVertexAttrib4s = (TglVertexAttrib4s)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4s));
            }

            if (GL.LinkProcGL("glVertexAttrib4sv"))
            {
                GL.glVertexAttrib4sv = (TglVertexAttrib4sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4sv));
            }

            if (GL.LinkProcGL("glVertexAttrib4ubv"))
            {
                GL.glVertexAttrib4ubv = (TglVertexAttrib4ubv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4ubv));
            }

            if (GL.LinkProcGL("glVertexAttrib4uiv"))
            {
                GL.glVertexAttrib4uiv = (TglVertexAttrib4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4uiv));
            }

            if (GL.LinkProcGL("glVertexAttrib4usv"))
            {
                GL.glVertexAttrib4usv = (TglVertexAttrib4usv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttrib4usv));
            }

            if (GL.LinkProcGL("glVertexAttribPointer"))
            {
                GL.glVertexAttribPointer = (TglVertexAttribPointer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribPointer));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 2.1 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 2.1 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 2.1 FUNCTIONS...
            if (GL.LinkProcGL("glUniformMatrix2x3fv"))
            {
                GL.glUniformMatrix2x3fv = (TglUniformMatrix2x3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix2x3fv));
            }

            if (GL.LinkProcGL("glUniformMatrix3x2fv"))
            {
                GL.glUniformMatrix3x2fv = (TglUniformMatrix3x2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix3x2fv));
            }

            if (GL.LinkProcGL("glUniformMatrix2x4fv"))
            {
                GL.glUniformMatrix2x4fv = (TglUniformMatrix2x4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix2x4fv));
            }

            if (GL.LinkProcGL("glUniformMatrix4x2fv"))
            {
                GL.glUniformMatrix4x2fv = (TglUniformMatrix4x2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix4x2fv));
            }

            if (GL.LinkProcGL("glUniformMatrix3x4fv"))
            {
                GL.glUniformMatrix3x4fv = (TglUniformMatrix3x4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix3x4fv));
            }

            if (GL.LinkProcGL("glUniformMatrix4x3fv"))
            {
                GL.glUniformMatrix4x3fv = (TglUniformMatrix4x3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix4x3fv));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 3.0 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 3.0 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 3.0 FUNCTIONS...
            if (GL.LinkProcGL("glColorMaski"))
            {
                GL.glColorMaski = (TglColorMaski)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorMaski));
            }

            if (GL.LinkProcGL("glGetBooleani_v"))
            {
                GL.glGetBooleani_v = (TglGetBooleani_v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetBooleani_v));
            }

            if (GL.LinkProcGL("glGetIntegeri_v"))
            {
                GL.glGetIntegeri_v = (TglGetIntegeri_v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetIntegeri_v));
            }

            if (GL.LinkProcGL("glEnablei"))
            {
                GL.glEnablei = (TglEnablei)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEnablei));
            }

            if (GL.LinkProcGL("glDisablei"))
            {
                GL.glDisablei = (TglDisablei)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDisablei));
            }

            if (GL.LinkProcGL("glIsEnabledi"))
            {
                GL.glIsEnabledi = (TglIsEnabledi)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsEnabledi));
            }

            if (GL.LinkProcGL("glBeginTransformFeedback"))
            {
                GL.glBeginTransformFeedback = (TglBeginTransformFeedback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginTransformFeedback));
            }

            if (GL.LinkProcGL("glEndTransformFeedback"))
            {
                GL.glEndTransformFeedback = (TglEndTransformFeedback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndTransformFeedback));
            }

            if (GL.LinkProcGL("glBindBufferRange"))
            {
                GL.glBindBufferRange = (TglBindBufferRange)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindBufferRange));
            }

            if (GL.LinkProcGL("glBindBufferBase"))
            {
                GL.glBindBufferBase = (TglBindBufferBase)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindBufferBase));
            }

            if (GL.LinkProcGL("glTransformFeedbackVaryings"))
            {
                GL.glTransformFeedbackVaryings = (TglTransformFeedbackVaryings)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTransformFeedbackVaryings));
            }

            if (GL.LinkProcGL("glGetTransformFeedbackVarying"))
            {
                GL.glGetTransformFeedbackVarying = (TglGetTransformFeedbackVarying)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTransformFeedbackVarying));
            }

            if (GL.LinkProcGL("glClampColor"))
            {
                GL.glClampColor = (TglClampColor)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClampColor));
            }

            if (GL.LinkProcGL("glBeginConditionalRender"))
            {
                GL.glBeginConditionalRender = (TglBeginConditionalRender)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginConditionalRender));
            }

            if (GL.LinkProcGL("glEndConditionalRender"))
            {
                GL.glEndConditionalRender = (TglEndConditionalRender)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndConditionalRender));
            }

            if (GL.LinkProcGL("glVertexAttribIPointer"))
            {
                GL.glVertexAttribIPointer = (TglVertexAttribIPointer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribIPointer));
            }

            if (GL.LinkProcGL("glGetVertexAttribIiv"))
            {
                GL.glGetVertexAttribIiv = (TglGetVertexAttribIiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribIiv));
            }

            if (GL.LinkProcGL("glGetVertexAttribIuiv"))
            {
                GL.glGetVertexAttribIuiv = (TglGetVertexAttribIuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribIuiv));
            }

            if (GL.LinkProcGL("glVertexAttribI1i"))
            {
                GL.glVertexAttribI1i = (TglVertexAttribI1i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI1i));
            }

            if (GL.LinkProcGL("glVertexAttribI2i"))
            {
                GL.glVertexAttribI2i = (TglVertexAttribI2i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI2i));
            }

            if (GL.LinkProcGL("glVertexAttribI3i"))
            {
                GL.glVertexAttribI3i = (TglVertexAttribI3i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI3i));
            }

            if (GL.LinkProcGL("glVertexAttribI4i"))
            {
                GL.glVertexAttribI4i = (TglVertexAttribI4i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4i));
            }

            if (GL.LinkProcGL("glVertexAttribI1ui"))
            {
                GL.glVertexAttribI1ui = (TglVertexAttribI1ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI1ui));
            }

            if (GL.LinkProcGL("glVertexAttribI2ui"))
            {
                GL.glVertexAttribI2ui = (TglVertexAttribI2ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI2ui));
            }

            if (GL.LinkProcGL("glVertexAttribI3ui"))
            {
                GL.glVertexAttribI3ui = (TglVertexAttribI3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI3ui));
            }

            if (GL.LinkProcGL("glVertexAttribI4ui"))
            {
                GL.glVertexAttribI4ui = (TglVertexAttribI4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4ui));
            }

            if (GL.LinkProcGL("glVertexAttribI1iv"))
            {
                GL.glVertexAttribI1iv = (TglVertexAttribI1iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI1iv));
            }

            if (GL.LinkProcGL("glVertexAttribI2iv"))
            {
                GL.glVertexAttribI2iv = (TglVertexAttribI2iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI2iv));
            }

            if (GL.LinkProcGL("glVertexAttribI3iv"))
            {
                GL.glVertexAttribI3iv = (TglVertexAttribI3iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI3iv));
            }

            if (GL.LinkProcGL("glVertexAttribI4iv"))
            {
                GL.glVertexAttribI4iv = (TglVertexAttribI4iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4iv));
            }

            if (GL.LinkProcGL("glVertexAttribI1uiv"))
            {
                GL.glVertexAttribI1uiv = (TglVertexAttribI1uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI1uiv));
            }

            if (GL.LinkProcGL("glVertexAttribI2uiv"))
            {
                GL.glVertexAttribI2uiv = (TglVertexAttribI2uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI2uiv));
            }

            if (GL.LinkProcGL("glVertexAttribI3uiv"))
            {
                GL.glVertexAttribI3uiv = (TglVertexAttribI3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI3uiv));
            }

            if (GL.LinkProcGL("glVertexAttribI4uiv"))
            {
                GL.glVertexAttribI4uiv = (TglVertexAttribI4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4uiv));
            }

            if (GL.LinkProcGL("glVertexAttribI4bv"))
            {
                GL.glVertexAttribI4bv = (TglVertexAttribI4bv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4bv));
            }

            if (GL.LinkProcGL("glVertexAttribI4sv"))
            {
                GL.glVertexAttribI4sv = (TglVertexAttribI4sv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4sv));
            }

            if (GL.LinkProcGL("glVertexAttribI4ubv"))
            {
                GL.glVertexAttribI4ubv = (TglVertexAttribI4ubv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4ubv));
            }

            if (GL.LinkProcGL("glVertexAttribI4usv"))
            {
                GL.glVertexAttribI4usv = (TglVertexAttribI4usv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribI4usv));
            }

            if (GL.LinkProcGL("glGetUniformuiv"))
            {
                GL.glGetUniformuiv = (TglGetUniformuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformuiv));
            }

            if (GL.LinkProcGL("glBindFragDataLocation"))
            {
                GL.glBindFragDataLocation = (TglBindFragDataLocation)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindFragDataLocation));
            }

            if (GL.LinkProcGL("glGetFragDataLocation"))
            {
                GL.glGetFragDataLocation = (TglGetFragDataLocation)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFragDataLocation));
            }

            if (GL.LinkProcGL("glUniform1ui"))
            {
                GL.glUniform1ui = (TglUniform1ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1ui));
            }

            if (GL.LinkProcGL("glUniform2ui"))
            {
                GL.glUniform2ui = (TglUniform2ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2ui));
            }

            if (GL.LinkProcGL("glUniform3ui"))
            {
                GL.glUniform3ui = (TglUniform3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3ui));
            }

            if (GL.LinkProcGL("glUniform4ui"))
            {
                GL.glUniform4ui = (TglUniform4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4ui));
            }

            if (GL.LinkProcGL("glUniform1uiv"))
            {
                GL.glUniform1uiv = (TglUniform1uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1uiv));
            }

            if (GL.LinkProcGL("glUniform2uiv"))
            {
                GL.glUniform2uiv = (TglUniform2uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2uiv));
            }

            if (GL.LinkProcGL("glUniform3uiv"))
            {
                GL.glUniform3uiv = (TglUniform3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3uiv));
            }

            if (GL.LinkProcGL("glUniform4uiv"))
            {
                GL.glUniform4uiv = (TglUniform4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4uiv));
            }

            if (GL.LinkProcGL("glTexParameterIiv"))
            {
                GL.glTexParameterIiv = (TglTexParameterIiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexParameterIiv));
            }

            if (GL.LinkProcGL("glTexParameterIuiv"))
            {
                GL.glTexParameterIuiv = (TglTexParameterIuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexParameterIuiv));
            }

            if (GL.LinkProcGL("glGetTexParameterIiv"))
            {
                GL.glGetTexParameterIiv = (TglGetTexParameterIiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexParameterIiv));
            }

            if (GL.LinkProcGL("glGetTexParameterIuiv"))
            {
                GL.glGetTexParameterIuiv = (TglGetTexParameterIuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTexParameterIuiv));
            }

            if (GL.LinkProcGL("glClearBufferiv"))
            {
                GL.glClearBufferiv = (TglClearBufferiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearBufferiv));
            }

            if (GL.LinkProcGL("glClearBufferuiv"))
            {
                GL.glClearBufferuiv = (TglClearBufferuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearBufferuiv));
            }

            if (GL.LinkProcGL("glClearBufferfv"))
            {
                GL.glClearBufferfv = (TglClearBufferfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearBufferfv));
            }

            if (GL.LinkProcGL("glClearBufferfi"))
            {
                GL.glClearBufferfi = (TglClearBufferfi)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearBufferfi));
            }

            if (GL.LinkProcGL("glGetStringi"))
            {
                GL.glGetStringi = (TglGetStringi)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetStringi));
            }

            if (GL.LinkProcGL("glIsRenderbuffer"))
            {
                GL.glIsRenderbuffer = (TglIsRenderbuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsRenderbuffer));
            }

            if (GL.LinkProcGL("glBindRenderbuffer"))
            {
                GL.glBindRenderbuffer = (TglBindRenderbuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindRenderbuffer));
            }

            if (GL.LinkProcGL("glDeleteRenderbuffers"))
            {
                GL.glDeleteRenderbuffers = (TglDeleteRenderbuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteRenderbuffers));
            }

            if (GL.LinkProcGL("glGenRenderbuffers"))
            {
                GL.glGenRenderbuffers = (TglGenRenderbuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenRenderbuffers));
            }

            if (GL.LinkProcGL("glRenderbufferStorage"))
            {
                GL.glRenderbufferStorage = (TglRenderbufferStorage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRenderbufferStorage));
            }

            if (GL.LinkProcGL("glGetRenderbufferParameteriv"))
            {
                GL.glGetRenderbufferParameteriv = (TglGetRenderbufferParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetRenderbufferParameteriv));
            }

            if (GL.LinkProcGL("glIsFramebuffer"))
            {
                GL.glIsFramebuffer = (TglIsFramebuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsFramebuffer));
            }

            if (GL.LinkProcGL("glBindFramebuffer"))
            {
                GL.glBindFramebuffer = (TglBindFramebuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindFramebuffer));
            }

            if (GL.LinkProcGL("glDeleteFramebuffers"))
            {
                GL.glDeleteFramebuffers = (TglDeleteFramebuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteFramebuffers));
            }

            if (GL.LinkProcGL("glGenFramebuffers"))
            {
                GL.glGenFramebuffers = (TglGenFramebuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenFramebuffers));
            }

            if (GL.LinkProcGL("glCheckFramebufferStatus"))
            {
                GL.glCheckFramebufferStatus = (TglCheckFramebufferStatus)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCheckFramebufferStatus));
            }

            if (GL.LinkProcGL("glFramebufferTexture1D"))
            {
                GL.glFramebufferTexture1D = (TglFramebufferTexture1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTexture1D));
            }

            if (GL.LinkProcGL("glFramebufferTexture2D"))
            {
                GL.glFramebufferTexture2D = (TglFramebufferTexture2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTexture2D));
            }

            if (GL.LinkProcGL("glFramebufferTexture3D"))
            {
                GL.glFramebufferTexture3D = (TglFramebufferTexture3D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTexture3D));
            }

            if (GL.LinkProcGL("glFramebufferRenderbuffer"))
            {
                GL.glFramebufferRenderbuffer = (TglFramebufferRenderbuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferRenderbuffer));
            }

            if (GL.LinkProcGL("glGetFramebufferAttachmentParameteriv"))
            {
                GL.glGetFramebufferAttachmentParameteriv = (TglGetFramebufferAttachmentParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFramebufferAttachmentParameteriv));
            }

            if (GL.LinkProcGL("glGenerateMipmap"))
            {
                GL.glGenerateMipmap = (TglGenerateMipmap)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenerateMipmap));
            }

            if (GL.LinkProcGL("glBlitFramebuffer"))
            {
                GL.glBlitFramebuffer = (TglBlitFramebuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlitFramebuffer));
            }

            if (GL.LinkProcGL("glRenderbufferStorageMultisample"))
            {
                GL.glRenderbufferStorageMultisample = (TglRenderbufferStorageMultisample)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglRenderbufferStorageMultisample));
            }

            if (GL.LinkProcGL("glFramebufferTextureLayer"))
            {
                GL.glFramebufferTextureLayer = (TglFramebufferTextureLayer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTextureLayer));
            }

            if (GL.LinkProcGL("glMapBufferRange"))
            {
                GL.glMapBufferRange = (TglMapBufferRange)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapBufferRange));
            }

            if (GL.LinkProcGL("glFlushMappedBufferRange"))
            {
                GL.glFlushMappedBufferRange = (TglFlushMappedBufferRange)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFlushMappedBufferRange));
            }

            if (GL.LinkProcGL("glBindVertexArray"))
            {
                GL.glBindVertexArray = (TglBindVertexArray)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindVertexArray));
            }

            if (GL.LinkProcGL("glDeleteVertexArrays"))
            {
                GL.glDeleteVertexArrays = (TglDeleteVertexArrays)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteVertexArrays));
            }

            if (GL.LinkProcGL("glGenVertexArrays"))
            {
                GL.glGenVertexArrays = (TglGenVertexArrays)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenVertexArrays));
            }

            if (GL.LinkProcGL("glIsVertexArray"))
            {
                GL.glIsVertexArray = (TglIsVertexArray)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsVertexArray));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 3.1 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 3.1 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 3.1 FUNCTIONS...
            if (GL.LinkProcGL("glDrawArraysInstanced"))
            {
                GL.glDrawArraysInstanced = (TglDrawArraysInstanced)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawArraysInstanced));
            }

            if (GL.LinkProcGL("glDrawElementsInstanced"))
            {
                GL.glDrawElementsInstanced = (TglDrawElementsInstanced)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementsInstanced));
            }

            if (GL.LinkProcGL("glTexBuffer"))
            {
                GL.glTexBuffer = (TglTexBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexBuffer));
            }

            if (GL.LinkProcGL("glCopyBufferSubData"))
            {
                GL.glCopyBufferSubData = (TglCopyBufferSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyBufferSubData));
            }

            if (GL.LinkProcGL("glGetUniformIndices"))
            {
                GL.glGetUniformIndices = (TglGetUniformIndices)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformIndices));
            }

            if (GL.LinkProcGL("glGetActiveUniformsiv"))
            {
                GL.glGetActiveUniformsiv = (TglGetActiveUniformsiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveUniformsiv));
            }

            if (GL.LinkProcGL("glGetActiveUniformName"))
            {
                GL.glGetActiveUniformName = (TglGetActiveUniformName)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveUniformName));
            }

            if (GL.LinkProcGL("glGetUniformBlockIndex"))
            {
                GL.glGetUniformBlockIndex = (TglGetUniformBlockIndex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformBlockIndex));
            }

            if (GL.LinkProcGL("glGetActiveUniformBlockiv"))
            {
                GL.glGetActiveUniformBlockiv = (TglGetActiveUniformBlockiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveUniformBlockiv));
            }

            if (GL.LinkProcGL("glGetActiveUniformBlockName"))
            {
                GL.glGetActiveUniformBlockName = (TglGetActiveUniformBlockName)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveUniformBlockName));
            }

            if (GL.LinkProcGL("glUniformBlockBinding"))
            {
                GL.glUniformBlockBinding = (TglUniformBlockBinding)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformBlockBinding));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 3.2 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 3.2 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 3.2 FUNCTIONS...
            if (GL.LinkProcGL("glGetInteger64i_v"))
            {
                GL.glGetInteger64i_v = (TglGetInteger64i_v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetInteger64i_v));
            }

            if (GL.LinkProcGL("glGetBufferParameteri64v"))
            {
                GL.glGetBufferParameteri64v = (TglGetBufferParameteri64v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetBufferParameteri64v));
            }

            if (GL.LinkProcGL("glFramebufferTexture"))
            {
                GL.glFramebufferTexture = (TglFramebufferTexture)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferTexture));
            }

            if (GL.LinkProcGL("glDrawElementsBaseVertex"))
            {
                GL.glDrawElementsBaseVertex = (TglDrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementsBaseVertex));
            }

            if (GL.LinkProcGL("glDrawRangeElementsBaseVertex"))
            {
                GL.glDrawRangeElementsBaseVertex = (TglDrawRangeElementsBaseVertex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawRangeElementsBaseVertex));
            }

            if (GL.LinkProcGL("glDrawElementsInstancedBaseVertex"))
            {
                GL.glDrawElementsInstancedBaseVertex = (TglDrawElementsInstancedBaseVertex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementsInstancedBaseVertex));
            }

            if (GL.LinkProcGL("glMultiDrawElementsBaseVertex"))
            {
                GL.glMultiDrawElementsBaseVertex = (TglMultiDrawElementsBaseVertex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawElementsBaseVertex));
            }

            if (GL.LinkProcGL("glProvokingVertex"))
            {
                GL.glProvokingVertex = (TglProvokingVertex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProvokingVertex));
            }

            if (GL.LinkProcGL("glFenceSync"))
            {
                GL.glFenceSync = (TglFenceSync)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFenceSync));
            }

            if (GL.LinkProcGL("glIsSync"))
            {
                GL.glIsSync = (TglIsSync)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsSync));
            }

            if (GL.LinkProcGL("glDeleteSync"))
            {
                GL.glDeleteSync = (TglDeleteSync)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteSync));
            }

            if (GL.LinkProcGL("glClientWaitSync"))
            {
                GL.glClientWaitSync = (TglClientWaitSync)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClientWaitSync));
            }

            if (GL.LinkProcGL("glWaitSync"))
            {
                GL.glWaitSync = (TglWaitSync)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglWaitSync));
            }

            if (GL.LinkProcGL("glGetInteger64v"))
            {
                GL.glGetInteger64v = (TglGetInteger64v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetInteger64v));
            }

            if (GL.LinkProcGL("glGetSynciv"))
            {
                GL.glGetSynciv = (TglGetSynciv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSynciv));
            }

            if (GL.LinkProcGL("glTexImage2DMultisample"))
            {
                GL.glTexImage2DMultisample = (TglTexImage2DMultisample)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexImage2DMultisample));
            }

            if (GL.LinkProcGL("glTexImage3DMultisample"))
            {
                GL.glTexImage3DMultisample = (TglTexImage3DMultisample)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexImage3DMultisample));
            }

            if (GL.LinkProcGL("glGetMultisamplefv"))
            {
                GL.glGetMultisamplefv = (TglGetMultisamplefv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetMultisamplefv));
            }

            if (GL.LinkProcGL("glSampleMaski"))
            {
                GL.glSampleMaski = (TglSampleMaski)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSampleMaski));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 3.3 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 3.3 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 3.3 FUNCTIONS...
            if (GL.LinkProcGL("glVertexAttribDivisor"))
            {
                GL.glVertexAttribDivisor = (TglVertexAttribDivisor)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribDivisor));
            }

            if (GL.LinkProcGL("glBindFragDataLocationIndexed"))
            {
                GL.glBindFragDataLocationIndexed = (TglBindFragDataLocationIndexed)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindFragDataLocationIndexed));
            }

            if (GL.LinkProcGL("glGetFragDataIndex"))
            {
                GL.glGetFragDataIndex = (TglGetFragDataIndex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFragDataIndex));
            }

            if (GL.LinkProcGL("glGenSamplers"))
            {
                GL.glGenSamplers = (TglGenSamplers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenSamplers));
            }

            if (GL.LinkProcGL("glDeleteSamplers"))
            {
                GL.glDeleteSamplers = (TglDeleteSamplers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteSamplers));
            }

            if (GL.LinkProcGL("glIsSampler"))
            {
                GL.glIsSampler = (TglIsSampler)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsSampler));
            }

            if (GL.LinkProcGL("glBindSampler"))
            {
                GL.glBindSampler = (TglBindSampler)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindSampler));
            }

            if (GL.LinkProcGL("glSamplerParameteri"))
            {
                GL.glSamplerParameteri = (TglSamplerParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplerParameteri));
            }

            if (GL.LinkProcGL("glSamplerParameteriv"))
            {
                GL.glSamplerParameteriv = (TglSamplerParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplerParameteriv));
            }

            if (GL.LinkProcGL("glSamplerParameterf"))
            {
                GL.glSamplerParameterf = (TglSamplerParameterf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplerParameterf));
            }

            if (GL.LinkProcGL("glSamplerParameterfv"))
            {
                GL.glSamplerParameterfv = (TglSamplerParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplerParameterfv));
            }

            if (GL.LinkProcGL("glSamplerParameterIiv"))
            {
                GL.glSamplerParameterIiv = (TglSamplerParameterIiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplerParameterIiv));
            }

            if (GL.LinkProcGL("glSamplerParameterIuiv"))
            {
                GL.glSamplerParameterIuiv = (TglSamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSamplerParameterIuiv));
            }

            if (GL.LinkProcGL("glGetSamplerParameteriv"))
            {
                GL.glGetSamplerParameteriv = (TglGetSamplerParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSamplerParameteriv));
            }

            if (GL.LinkProcGL("glGetSamplerParameterIiv"))
            {
                GL.glGetSamplerParameterIiv = (TglGetSamplerParameterIiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSamplerParameterIiv));
            }

            if (GL.LinkProcGL("glGetSamplerParameterfv"))
            {
                GL.glGetSamplerParameterfv = (TglGetSamplerParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSamplerParameterfv));
            }

            if (GL.LinkProcGL("glGetSamplerParameterIuiv"))
            {
                GL.glGetSamplerParameterIuiv = (TglGetSamplerParameterIuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSamplerParameterIuiv));
            }

            if (GL.LinkProcGL("glQueryCounter"))
            {
                GL.glQueryCounter = (TglQueryCounter)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglQueryCounter));
            }

            if (GL.LinkProcGL("glGetQueryObjecti64v"))
            {
                GL.glGetQueryObjecti64v = (TglGetQueryObjecti64v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryObjecti64v));
            }

            if (GL.LinkProcGL("glGetQueryObjectui64v"))
            {
                GL.glGetQueryObjectui64v = (TglGetQueryObjectui64v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryObjectui64v));
            }

            if (GL.LinkProcGL("glVertexP2ui"))
            {
                GL.glVertexP2ui = (TglVertexP2ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexP2ui));
            }

            if (GL.LinkProcGL("glVertexP2uiv"))
            {
                GL.glVertexP2uiv = (TglVertexP2uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexP2uiv));
            }

            if (GL.LinkProcGL("glVertexP3ui"))
            {
                GL.glVertexP3ui = (TglVertexP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexP3ui));
            }

            if (GL.LinkProcGL("glVertexP3uiv"))
            {
                GL.glVertexP3uiv = (TglVertexP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexP3uiv));
            }

            if (GL.LinkProcGL("glVertexP4ui"))
            {
                GL.glVertexP4ui = (TglVertexP4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexP4ui));
            }

            if (GL.LinkProcGL("glVertexP4uiv"))
            {
                GL.glVertexP4uiv = (TglVertexP4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexP4uiv));
            }

            if (GL.LinkProcGL("glTexCoordP1ui"))
            {
                GL.glTexCoordP1ui = (TglTexCoordP1ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP1ui));
            }

            if (GL.LinkProcGL("glTexCoordP1uiv"))
            {
                GL.glTexCoordP1uiv = (TglTexCoordP1uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP1uiv));
            }

            if (GL.LinkProcGL("glTexCoordP2ui"))
            {
                GL.glTexCoordP2ui = (TglTexCoordP2ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP2ui));
            }

            if (GL.LinkProcGL("glTexCoordP2uiv"))
            {
                GL.glTexCoordP2uiv = (TglTexCoordP2uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP2uiv));
            }

            if (GL.LinkProcGL("glTexCoordP3ui"))
            {
                GL.glTexCoordP3ui = (TglTexCoordP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP3ui));
            }

            if (GL.LinkProcGL("glTexCoordP3uiv"))
            {
                GL.glTexCoordP3uiv = (TglTexCoordP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP3uiv));
            }

            if (GL.LinkProcGL("glTexCoordP4ui"))
            {
                GL.glTexCoordP4ui = (TglTexCoordP4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP4ui));
            }

            if (GL.LinkProcGL("glTexCoordP4uiv"))
            {
                GL.glTexCoordP4uiv = (TglTexCoordP4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexCoordP4uiv));
            }

            if (GL.LinkProcGL("glMultiTexCoordP1ui"))
            {
                GL.glMultiTexCoordP1ui = (TglMultiTexCoordP1ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP1ui));
            }

            if (GL.LinkProcGL("glMultiTexCoordP1uiv"))
            {
                GL.glMultiTexCoordP1uiv = (TglMultiTexCoordP1uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP1uiv));
            }

            if (GL.LinkProcGL("glMultiTexCoordP2ui"))
            {
                GL.glMultiTexCoordP2ui = (TglMultiTexCoordP2ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP2ui));
            }

            if (GL.LinkProcGL("glMultiTexCoordP2uiv"))
            {
                GL.glMultiTexCoordP2uiv = (TglMultiTexCoordP2uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP2uiv));
            }

            if (GL.LinkProcGL("glMultiTexCoordP3ui"))
            {
                GL.glMultiTexCoordP3ui = (TglMultiTexCoordP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP3ui));
            }

            if (GL.LinkProcGL("glMultiTexCoordP3uiv"))
            {
                GL.glMultiTexCoordP3uiv = (TglMultiTexCoordP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP3uiv));
            }

            if (GL.LinkProcGL("glMultiTexCoordP4ui"))
            {
                GL.glMultiTexCoordP4ui = (TglMultiTexCoordP4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP4ui));
            }

            if (GL.LinkProcGL("glMultiTexCoordP4uiv"))
            {
                GL.glMultiTexCoordP4uiv = (TglMultiTexCoordP4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiTexCoordP4uiv));
            }

            if (GL.LinkProcGL("glNormalP3ui"))
            {
                GL.glNormalP3ui = (TglNormalP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalP3ui));
            }

            if (GL.LinkProcGL("glNormalP3uiv"))
            {
                GL.glNormalP3uiv = (TglNormalP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNormalP3uiv));
            }

            if (GL.LinkProcGL("glColorP3ui"))
            {
                GL.glColorP3ui = (TglColorP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorP3ui));
            }

            if (GL.LinkProcGL("glColorP3uiv"))
            {
                GL.glColorP3uiv = (TglColorP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorP3uiv));
            }

            if (GL.LinkProcGL("glColorP4ui"))
            {
                GL.glColorP4ui = (TglColorP4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorP4ui));
            }

            if (GL.LinkProcGL("glColorP4uiv"))
            {
                GL.glColorP4uiv = (TglColorP4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglColorP4uiv));
            }

            if (GL.LinkProcGL("glSecondaryColorP3ui"))
            {
                GL.glSecondaryColorP3ui = (TglSecondaryColorP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColorP3ui));
            }

            if (GL.LinkProcGL("glSecondaryColorP3uiv"))
            {
                GL.glSecondaryColorP3uiv = (TglSecondaryColorP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglSecondaryColorP3uiv));
            }

            if (GL.LinkProcGL("glVertexAttribP1ui"))
            {
                GL.glVertexAttribP1ui = (TglVertexAttribP1ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP1ui));
            }

            if (GL.LinkProcGL("glVertexAttribP1uiv"))
            {
                GL.glVertexAttribP1uiv = (TglVertexAttribP1uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP1uiv));
            }

            if (GL.LinkProcGL("glVertexAttribP2ui"))
            {
                GL.glVertexAttribP2ui = (TglVertexAttribP2ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP2ui));
            }

            if (GL.LinkProcGL("glVertexAttribP2uiv"))
            {
                GL.glVertexAttribP2uiv = (TglVertexAttribP2uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP2uiv));
            }

            if (GL.LinkProcGL("glVertexAttribP3ui"))
            {
                GL.glVertexAttribP3ui = (TglVertexAttribP3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP3ui));
            }

            if (GL.LinkProcGL("glVertexAttribP3uiv"))
            {
                GL.glVertexAttribP3uiv = (TglVertexAttribP3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP3uiv));
            }

            if (GL.LinkProcGL("glVertexAttribP4ui"))
            {
                GL.glVertexAttribP4ui = (TglVertexAttribP4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP4ui));
            }

            if (GL.LinkProcGL("glVertexAttribP4uiv"))
            {
                GL.glVertexAttribP4uiv = (TglVertexAttribP4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribP4uiv));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 4.0 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 4.0 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 4.0 FUNCTIONS...
            if (GL.LinkProcGL("glMinSampleShading"))
            {
                GL.glMinSampleShading = (TglMinSampleShading)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMinSampleShading));
            }

            if (GL.LinkProcGL("glBlendEquationi"))
            {
                GL.glBlendEquationi = (TglBlendEquationi)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendEquationi));
            }

            if (GL.LinkProcGL("glBlendEquationSeparatei"))
            {
                GL.glBlendEquationSeparatei = (TglBlendEquationSeparatei)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendEquationSeparatei));
            }

            if (GL.LinkProcGL("glBlendFunci"))
            {
                GL.glBlendFunci = (TglBlendFunci)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendFunci));
            }

            if (GL.LinkProcGL("glBlendFuncSeparatei"))
            {
                GL.glBlendFuncSeparatei = (TglBlendFuncSeparatei)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlendFuncSeparatei));
            }

            if (GL.LinkProcGL("glDrawArraysIndirect"))
            {
                GL.glDrawArraysIndirect = (TglDrawArraysIndirect)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawArraysIndirect));
            }

            if (GL.LinkProcGL("glDrawElementsIndirect"))
            {
                GL.glDrawElementsIndirect = (TglDrawElementsIndirect)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementsIndirect));
            }

            if (GL.LinkProcGL("glUniform1d"))
            {
                GL.glUniform1d = (TglUniform1d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1d));
            }

            if (GL.LinkProcGL("glUniform2d"))
            {
                GL.glUniform2d = (TglUniform2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2d));
            }

            if (GL.LinkProcGL("glUniform3d"))
            {
                GL.glUniform3d = (TglUniform3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3d));
            }

            if (GL.LinkProcGL("glUniform4d"))
            {
                GL.glUniform4d = (TglUniform4d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4d));
            }

            if (GL.LinkProcGL("glUniform1dv"))
            {
                GL.glUniform1dv = (TglUniform1dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform1dv));
            }

            if (GL.LinkProcGL("glUniform2dv"))
            {
                GL.glUniform2dv = (TglUniform2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform2dv));
            }

            if (GL.LinkProcGL("glUniform3dv"))
            {
                GL.glUniform3dv = (TglUniform3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform3dv));
            }

            if (GL.LinkProcGL("glUniform4dv"))
            {
                GL.glUniform4dv = (TglUniform4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniform4dv));
            }

            if (GL.LinkProcGL("glUniformMatrix2dv"))
            {
                GL.glUniformMatrix2dv = (TglUniformMatrix2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix2dv));
            }

            if (GL.LinkProcGL("glUniformMatrix3dv"))
            {
                GL.glUniformMatrix3dv = (TglUniformMatrix3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix3dv));
            }

            if (GL.LinkProcGL("glUniformMatrix4dv"))
            {
                GL.glUniformMatrix4dv = (TglUniformMatrix4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix4dv));
            }

            if (GL.LinkProcGL("glUniformMatrix2x3dv"))
            {
                GL.glUniformMatrix2x3dv = (TglUniformMatrix2x3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix2x3dv));
            }

            if (GL.LinkProcGL("glUniformMatrix2x4dv"))
            {
                GL.glUniformMatrix2x4dv = (TglUniformMatrix2x4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix2x4dv));
            }

            if (GL.LinkProcGL("glUniformMatrix3x2dv"))
            {
                GL.glUniformMatrix3x2dv = (TglUniformMatrix3x2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix3x2dv));
            }

            if (GL.LinkProcGL("glUniformMatrix3x4dv"))
            {
                GL.glUniformMatrix3x4dv = (TglUniformMatrix3x4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix3x4dv));
            }

            if (GL.LinkProcGL("glUniformMatrix4x2dv"))
            {
                GL.glUniformMatrix4x2dv = (TglUniformMatrix4x2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix4x2dv));
            }

            if (GL.LinkProcGL("glUniformMatrix4x3dv"))
            {
                GL.glUniformMatrix4x3dv = (TglUniformMatrix4x3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformMatrix4x3dv));
            }

            if (GL.LinkProcGL("glGetUniformdv"))
            {
                GL.glGetUniformdv = (TglGetUniformdv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformdv));
            }

            if (GL.LinkProcGL("glGetSubroutineUniformLocation"))
            {
                GL.glGetSubroutineUniformLocation = (TglGetSubroutineUniformLocation)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSubroutineUniformLocation));
            }

            if (GL.LinkProcGL("glGetSubroutineIndex"))
            {
                GL.glGetSubroutineIndex = (TglGetSubroutineIndex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetSubroutineIndex));
            }

            if (GL.LinkProcGL("glGetActiveSubroutineUniformiv"))
            {
                GL.glGetActiveSubroutineUniformiv = (TglGetActiveSubroutineUniformiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveSubroutineUniformiv));
            }

            if (GL.LinkProcGL("glGetActiveSubroutineUniformName"))
            {
                GL.glGetActiveSubroutineUniformName = (TglGetActiveSubroutineUniformName)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveSubroutineUniformName));
            }

            if (GL.LinkProcGL("glGetActiveSubroutineName"))
            {
                GL.glGetActiveSubroutineName = (TglGetActiveSubroutineName)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveSubroutineName));
            }

            if (GL.LinkProcGL("glUniformSubroutinesuiv"))
            {
                GL.glUniformSubroutinesuiv = (TglUniformSubroutinesuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUniformSubroutinesuiv));
            }

            if (GL.LinkProcGL("glGetUniformSubroutineuiv"))
            {
                GL.glGetUniformSubroutineuiv = (TglGetUniformSubroutineuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetUniformSubroutineuiv));
            }

            if (GL.LinkProcGL("glGetProgramStageiv"))
            {
                GL.glGetProgramStageiv = (TglGetProgramStageiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramStageiv));
            }

            if (GL.LinkProcGL("glPatchParameteri"))
            {
                GL.glPatchParameteri = (TglPatchParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPatchParameteri));
            }

            if (GL.LinkProcGL("glPatchParameterfv"))
            {
                GL.glPatchParameterfv = (TglPatchParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPatchParameterfv));
            }

            if (GL.LinkProcGL("glBindTransformFeedback"))
            {
                GL.glBindTransformFeedback = (TglBindTransformFeedback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindTransformFeedback));
            }

            if (GL.LinkProcGL("glDeleteTransformFeedbacks"))
            {
                GL.glDeleteTransformFeedbacks = (TglDeleteTransformFeedbacks)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteTransformFeedbacks));
            }

            if (GL.LinkProcGL("glGenTransformFeedbacks"))
            {
                GL.glGenTransformFeedbacks = (TglGenTransformFeedbacks)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenTransformFeedbacks));
            }

            if (GL.LinkProcGL("glIsTransformFeedback"))
            {
                GL.glIsTransformFeedback = (TglIsTransformFeedback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsTransformFeedback));
            }

            if (GL.LinkProcGL("glPauseTransformFeedback"))
            {
                GL.glPauseTransformFeedback = (TglPauseTransformFeedback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPauseTransformFeedback));
            }

            if (GL.LinkProcGL("glResumeTransformFeedback"))
            {
                GL.glResumeTransformFeedback = (TglResumeTransformFeedback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglResumeTransformFeedback));
            }

            if (GL.LinkProcGL("glDrawTransformFeedback"))
            {
                GL.glDrawTransformFeedback = (TglDrawTransformFeedback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawTransformFeedback));
            }

            if (GL.LinkProcGL("glDrawTransformFeedbackStream"))
            {
                GL.glDrawTransformFeedbackStream = (TglDrawTransformFeedbackStream)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawTransformFeedbackStream));
            }

            if (GL.LinkProcGL("glBeginQueryIndexed"))
            {
                GL.glBeginQueryIndexed = (TglBeginQueryIndexed)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBeginQueryIndexed));
            }

            if (GL.LinkProcGL("glEndQueryIndexed"))
            {
                GL.glEndQueryIndexed = (TglEndQueryIndexed)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEndQueryIndexed));
            }

            if (GL.LinkProcGL("glGetQueryIndexediv"))
            {
                GL.glGetQueryIndexediv = (TglGetQueryIndexediv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryIndexediv));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 4.1 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 4.1 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 4.1 FUNCTIONS...
            if (GL.LinkProcGL("glReleaseShaderCompiler"))
            {
                GL.glReleaseShaderCompiler = (TglReleaseShaderCompiler)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReleaseShaderCompiler));
            }

            if (GL.LinkProcGL("glShaderBinary"))
            {
                GL.glShaderBinary = (TglShaderBinary)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglShaderBinary));
            }

            if (GL.LinkProcGL("glGetShaderPrecisionFormat"))
            {
                GL.glGetShaderPrecisionFormat = (TglGetShaderPrecisionFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetShaderPrecisionFormat));
            }

            if (GL.LinkProcGL("glDepthRangef"))
            {
                GL.glDepthRangef = (TglDepthRangef)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthRangef));
            }

            if (GL.LinkProcGL("glClearDepthf"))
            {
                GL.glClearDepthf = (TglClearDepthf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearDepthf));
            }

            if (GL.LinkProcGL("glGetProgramBinary"))
            {
                GL.glGetProgramBinary = (TglGetProgramBinary)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramBinary));
            }

            if (GL.LinkProcGL("glProgramBinary"))
            {
                GL.glProgramBinary = (TglProgramBinary)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramBinary));
            }

            if (GL.LinkProcGL("glProgramParameteri"))
            {
                GL.glProgramParameteri = (TglProgramParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramParameteri));
            }

            if (GL.LinkProcGL("glUseProgramStages"))
            {
                GL.glUseProgramStages = (TglUseProgramStages)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUseProgramStages));
            }

            if (GL.LinkProcGL("glActiveShaderProgram"))
            {
                GL.glActiveShaderProgram = (TglActiveShaderProgram)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglActiveShaderProgram));
            }

            if (GL.LinkProcGL("glCreateShaderProgramv"))
            {
                GL.glCreateShaderProgramv = (TglCreateShaderProgramv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateShaderProgramv));
            }

            if (GL.LinkProcGL("glBindProgramPipeline"))
            {
                GL.glBindProgramPipeline = (TglBindProgramPipeline)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindProgramPipeline));
            }

            if (GL.LinkProcGL("glDeleteProgramPipelines"))
            {
                GL.glDeleteProgramPipelines = (TglDeleteProgramPipelines)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDeleteProgramPipelines));
            }

            if (GL.LinkProcGL("glGenProgramPipelines"))
            {
                GL.glGenProgramPipelines = (TglGenProgramPipelines)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenProgramPipelines));
            }

            if (GL.LinkProcGL("glIsProgramPipeline"))
            {
                GL.glIsProgramPipeline = (TglIsProgramPipeline)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglIsProgramPipeline));
            }

            if (GL.LinkProcGL("glGetProgramPipelineiv"))
            {
                GL.glGetProgramPipelineiv = (TglGetProgramPipelineiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramPipelineiv));
            }

            if (GL.LinkProcGL("glProgramUniform1i"))
            {
                GL.glProgramUniform1i = (TglProgramUniform1i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1i));
            }

            if (GL.LinkProcGL("glProgramUniform1iv"))
            {
                GL.glProgramUniform1iv = (TglProgramUniform1iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1iv));
            }

            if (GL.LinkProcGL("glProgramUniform1f"))
            {
                GL.glProgramUniform1f = (TglProgramUniform1f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1f));
            }

            if (GL.LinkProcGL("glProgramUniform1fv"))
            {
                GL.glProgramUniform1fv = (TglProgramUniform1fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1fv));
            }

            if (GL.LinkProcGL("glProgramUniform1d"))
            {
                GL.glProgramUniform1d = (TglProgramUniform1d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1d));
            }

            if (GL.LinkProcGL("glProgramUniform1dv"))
            {
                GL.glProgramUniform1dv = (TglProgramUniform1dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1dv));
            }

            if (GL.LinkProcGL("glProgramUniform1ui"))
            {
                GL.glProgramUniform1ui = (TglProgramUniform1ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1ui));
            }

            if (GL.LinkProcGL("glProgramUniform1uiv"))
            {
                GL.glProgramUniform1uiv = (TglProgramUniform1uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform1uiv));
            }

            if (GL.LinkProcGL("glProgramUniform2i"))
            {
                GL.glProgramUniform2i = (TglProgramUniform2i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2i));
            }

            if (GL.LinkProcGL("glProgramUniform2iv"))
            {
                GL.glProgramUniform2iv = (TglProgramUniform2iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2iv));
            }

            if (GL.LinkProcGL("glProgramUniform2f"))
            {
                GL.glProgramUniform2f = (TglProgramUniform2f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2f));
            }

            if (GL.LinkProcGL("glProgramUniform2fv"))
            {
                GL.glProgramUniform2fv = (TglProgramUniform2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2fv));
            }

            if (GL.LinkProcGL("glProgramUniform2d"))
            {
                GL.glProgramUniform2d = (TglProgramUniform2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2d));
            }

            if (GL.LinkProcGL("glProgramUniform2dv"))
            {
                GL.glProgramUniform2dv = (TglProgramUniform2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2dv));
            }

            if (GL.LinkProcGL("glProgramUniform2ui"))
            {
                GL.glProgramUniform2ui = (TglProgramUniform2ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2ui));
            }

            if (GL.LinkProcGL("glProgramUniform2uiv"))
            {
                GL.glProgramUniform2uiv = (TglProgramUniform2uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform2uiv));
            }

            if (GL.LinkProcGL("glProgramUniform3i"))
            {
                GL.glProgramUniform3i = (TglProgramUniform3i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3i));
            }

            if (GL.LinkProcGL("glProgramUniform3iv"))
            {
                GL.glProgramUniform3iv = (TglProgramUniform3iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3iv));
            }

            if (GL.LinkProcGL("glProgramUniform3f"))
            {
                GL.glProgramUniform3f = (TglProgramUniform3f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3f));
            }

            if (GL.LinkProcGL("glProgramUniform3fv"))
            {
                GL.glProgramUniform3fv = (TglProgramUniform3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3fv));
            }

            if (GL.LinkProcGL("glProgramUniform3d"))
            {
                GL.glProgramUniform3d = (TglProgramUniform3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3d));
            }

            if (GL.LinkProcGL("glProgramUniform3dv"))
            {
                GL.glProgramUniform3dv = (TglProgramUniform3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3dv));
            }

            if (GL.LinkProcGL("glProgramUniform3ui"))
            {
                GL.glProgramUniform3ui = (TglProgramUniform3ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3ui));
            }

            if (GL.LinkProcGL("glProgramUniform3uiv"))
            {
                GL.glProgramUniform3uiv = (TglProgramUniform3uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform3uiv));
            }

            if (GL.LinkProcGL("glProgramUniform4i"))
            {
                GL.glProgramUniform4i = (TglProgramUniform4i)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4i));
            }

            if (GL.LinkProcGL("glProgramUniform4iv"))
            {
                GL.glProgramUniform4iv = (TglProgramUniform4iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4iv));
            }

            if (GL.LinkProcGL("glProgramUniform4f"))
            {
                GL.glProgramUniform4f = (TglProgramUniform4f)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4f));
            }

            if (GL.LinkProcGL("glProgramUniform4fv"))
            {
                GL.glProgramUniform4fv = (TglProgramUniform4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4fv));
            }

            if (GL.LinkProcGL("glProgramUniform4d"))
            {
                GL.glProgramUniform4d = (TglProgramUniform4d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4d));
            }

            if (GL.LinkProcGL("glProgramUniform4dv"))
            {
                GL.glProgramUniform4dv = (TglProgramUniform4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4dv));
            }

            if (GL.LinkProcGL("glProgramUniform4ui"))
            {
                GL.glProgramUniform4ui = (TglProgramUniform4ui)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4ui));
            }

            if (GL.LinkProcGL("glProgramUniform4uiv"))
            {
                GL.glProgramUniform4uiv = (TglProgramUniform4uiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniform4uiv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix2fv"))
            {
                GL.glProgramUniformMatrix2fv = (TglProgramUniformMatrix2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2fv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix3fv"))
            {
                GL.glProgramUniformMatrix3fv = (TglProgramUniformMatrix3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3fv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix4fv"))
            {
                GL.glProgramUniformMatrix4fv = (TglProgramUniformMatrix4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4fv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix2dv"))
            {
                GL.glProgramUniformMatrix2dv = (TglProgramUniformMatrix2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2dv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix3dv"))
            {
                GL.glProgramUniformMatrix3dv = (TglProgramUniformMatrix3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3dv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix4dv"))
            {
                GL.glProgramUniformMatrix4dv = (TglProgramUniformMatrix4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4dv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix2x3fv"))
            {
                GL.glProgramUniformMatrix2x3fv = (TglProgramUniformMatrix2x3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2x3fv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix3x2fv"))
            {
                GL.glProgramUniformMatrix3x2fv = (TglProgramUniformMatrix3x2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3x2fv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix2x4fv"))
            {
                GL.glProgramUniformMatrix2x4fv = (TglProgramUniformMatrix2x4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2x4fv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix4x2fv"))
            {
                GL.glProgramUniformMatrix4x2fv = (TglProgramUniformMatrix4x2fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4x2fv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix3x4fv"))
            {
                GL.glProgramUniformMatrix3x4fv = (TglProgramUniformMatrix3x4fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3x4fv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix4x3fv"))
            {
                GL.glProgramUniformMatrix4x3fv = (TglProgramUniformMatrix4x3fv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4x3fv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix2x3dv"))
            {
                GL.glProgramUniformMatrix2x3dv = (TglProgramUniformMatrix2x3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2x3dv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix3x2dv"))
            {
                GL.glProgramUniformMatrix3x2dv = (TglProgramUniformMatrix3x2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3x2dv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix2x4dv"))
            {
                GL.glProgramUniformMatrix2x4dv = (TglProgramUniformMatrix2x4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix2x4dv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix4x2dv"))
            {
                GL.glProgramUniformMatrix4x2dv = (TglProgramUniformMatrix4x2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4x2dv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix3x4dv"))
            {
                GL.glProgramUniformMatrix3x4dv = (TglProgramUniformMatrix3x4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix3x4dv));
            }

            if (GL.LinkProcGL("glProgramUniformMatrix4x3dv"))
            {
                GL.glProgramUniformMatrix4x3dv = (TglProgramUniformMatrix4x3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglProgramUniformMatrix4x3dv));
            }

            if (GL.LinkProcGL("glValidateProgramPipeline"))
            {
                GL.glValidateProgramPipeline = (TglValidateProgramPipeline)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglValidateProgramPipeline));
            }

            if (GL.LinkProcGL("glGetProgramPipelineInfoLog"))
            {
                GL.glGetProgramPipelineInfoLog = (TglGetProgramPipelineInfoLog)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramPipelineInfoLog));
            }

            if (GL.LinkProcGL("glVertexAttribL1d"))
            {
                GL.glVertexAttribL1d = (TglVertexAttribL1d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL1d));
            }

            if (GL.LinkProcGL("glVertexAttribL2d"))
            {
                GL.glVertexAttribL2d = (TglVertexAttribL2d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL2d));
            }

            if (GL.LinkProcGL("glVertexAttribL3d"))
            {
                GL.glVertexAttribL3d = (TglVertexAttribL3d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL3d));
            }

            if (GL.LinkProcGL("glVertexAttribL4d"))
            {
                GL.glVertexAttribL4d = (TglVertexAttribL4d)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL4d));
            }

            if (GL.LinkProcGL("glVertexAttribL1dv"))
            {
                GL.glVertexAttribL1dv = (TglVertexAttribL1dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL1dv));
            }

            if (GL.LinkProcGL("glVertexAttribL2dv"))
            {
                GL.glVertexAttribL2dv = (TglVertexAttribL2dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL2dv));
            }

            if (GL.LinkProcGL("glVertexAttribL3dv"))
            {
                GL.glVertexAttribL3dv = (TglVertexAttribL3dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL3dv));
            }

            if (GL.LinkProcGL("glVertexAttribL4dv"))
            {
                GL.glVertexAttribL4dv = (TglVertexAttribL4dv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribL4dv));
            }

            if (GL.LinkProcGL("glVertexAttribLPointer"))
            {
                GL.glVertexAttribLPointer = (TglVertexAttribLPointer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribLPointer));
            }

            if (GL.LinkProcGL("glGetVertexAttribLdv"))
            {
                GL.glGetVertexAttribLdv = (TglGetVertexAttribLdv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexAttribLdv));
            }

            if (GL.LinkProcGL("glViewportArrayv"))
            {
                GL.glViewportArrayv = (TglViewportArrayv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglViewportArrayv));
            }

            if (GL.LinkProcGL("glViewportIndexedf"))
            {
                GL.glViewportIndexedf = (TglViewportIndexedf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglViewportIndexedf));
            }

            if (GL.LinkProcGL("glViewportIndexedfv"))
            {
                GL.glViewportIndexedfv = (TglViewportIndexedfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglViewportIndexedfv));
            }

            if (GL.LinkProcGL("glScissorArrayv"))
            {
                GL.glScissorArrayv = (TglScissorArrayv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglScissorArrayv));
            }

            if (GL.LinkProcGL("glScissorIndexed"))
            {
                GL.glScissorIndexed = (TglScissorIndexed)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglScissorIndexed));
            }

            if (GL.LinkProcGL("glScissorIndexedv"))
            {
                GL.glScissorIndexedv = (TglScissorIndexedv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglScissorIndexedv));
            }

            if (GL.LinkProcGL("glDepthRangeArrayv"))
            {
                GL.glDepthRangeArrayv = (TglDepthRangeArrayv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthRangeArrayv));
            }

            if (GL.LinkProcGL("glDepthRangeIndexed"))
            {
                GL.glDepthRangeIndexed = (TglDepthRangeIndexed)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDepthRangeIndexed));
            }

            if (GL.LinkProcGL("glGetFloati_v"))
            {
                GL.glGetFloati_v = (TglGetFloati_v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFloati_v));
            }

            if (GL.LinkProcGL("glGetDoublei_v"))
            {
                GL.glGetDoublei_v = (TglGetDoublei_v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetDoublei_v));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 4.2 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 4.2 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 4.2 FUNCTIONS...
            if (GL.LinkProcGL("glDrawArraysInstancedBaseInstance"))
            {
                GL.glDrawArraysInstancedBaseInstance = (TglDrawArraysInstancedBaseInstance)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawArraysInstancedBaseInstance));
            }

            if (GL.LinkProcGL("glDrawElementsInstancedBaseInstance"))
            {
                GL.glDrawElementsInstancedBaseInstance = (TglDrawElementsInstancedBaseInstance)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementsInstancedBaseInstance));
            }

            if (GL.LinkProcGL("glDrawElementsInstancedBaseVertexBaseInstance"))
            {
                GL.glDrawElementsInstancedBaseVertexBaseInstance = (TglDrawElementsInstancedBaseVertexBaseInstance)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawElementsInstancedBaseVertexBaseInstance));
            }

            if (GL.LinkProcGL("glDrawTransformFeedbackInstanced"))
            {
                GL.glDrawTransformFeedbackInstanced = (TglDrawTransformFeedbackInstanced)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawTransformFeedbackInstanced));
            }

            if (GL.LinkProcGL("glDrawTransformFeedbackStreamInstanced"))
            {
                GL.glDrawTransformFeedbackStreamInstanced = (TglDrawTransformFeedbackStreamInstanced)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDrawTransformFeedbackStreamInstanced));
            }

            if (GL.LinkProcGL("glGetInternalformativ"))
            {
                GL.glGetInternalformativ = (TglGetInternalformativ)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetInternalformativ));
            }

            if (GL.LinkProcGL("glGetActiveAtomicCounterBufferiv"))
            {
                GL.glGetActiveAtomicCounterBufferiv = (TglGetActiveAtomicCounterBufferiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetActiveAtomicCounterBufferiv));
            }

            if (GL.LinkProcGL("glBindImageTexture"))
            {
                GL.glBindImageTexture = (TglBindImageTexture)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindImageTexture));
            }

            if (GL.LinkProcGL("glMemoryBarrier"))
            {
                GL.glMemoryBarrier = (TglMemoryBarrier)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMemoryBarrier));
            }

            if (GL.LinkProcGL("glTexStorage1D"))
            {
                GL.glTexStorage1D = (TglTexStorage1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorage1D));
            }

            if (GL.LinkProcGL("glTexStorage2D"))
            {
                GL.glTexStorage2D = (TglTexStorage2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorage2D));
            }

            if (GL.LinkProcGL("glTexStorage3D"))
            {
                GL.glTexStorage3D = (TglTexStorage3D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorage3D));
            }

            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 4.3 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 4.3 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 4.3 FUNCTIONS...
            if (GL.LinkProcGL("glClearBufferData"))
            {
                GL.glClearBufferData = (TglClearBufferData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearBufferData));
            }

            if (GL.LinkProcGL("glClearBufferSubData"))
            {
                GL.glClearBufferSubData = (TglClearBufferSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearBufferSubData));
            }

            if (GL.LinkProcGL("glClearNamedBufferDataEXT"))
            {
                GL.glClearNamedBufferDataEXT = (TglClearNamedBufferDataEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearNamedBufferDataEXT));
            }

            if (GL.LinkProcGL("glClearNamedBufferSubDataEXT"))
            {
                GL.glClearNamedBufferSubDataEXT = (TglClearNamedBufferSubDataEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearNamedBufferSubDataEXT));
            }

            if (GL.LinkProcGL("glDispatchCompute"))
            {
                GL.glDispatchCompute = (TglDispatchCompute)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDispatchCompute));
            }

            if (GL.LinkProcGL("glDispatchComputeIndirect"))
            {
                GL.glDispatchComputeIndirect = (TglDispatchComputeIndirect)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDispatchComputeIndirect));
            }

            if (GL.LinkProcGL("glCopyImageSubData"))
            {
                GL.glCopyImageSubData = (TglCopyImageSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyImageSubData));
            }

            if (GL.LinkProcGL("glDebugMessageControl"))
            {
                GL.glDebugMessageControl = (TglDebugMessageControl)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageControl));
            }

            if (GL.LinkProcGL("glDebugMessageInsert"))
            {
                GL.glDebugMessageInsert = (TglDebugMessageInsert)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageInsert));
            }

            if (GL.LinkProcGL("glDebugMessageCallback"))
            {
                GL.glDebugMessageCallback = (TglDebugMessageCallback)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDebugMessageCallback));
            }

            if (GL.LinkProcGL("glGetDebugMessageLog"))
            {
                GL.glGetDebugMessageLog = (TglGetDebugMessageLog)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetDebugMessageLog));
            }

            if (GL.LinkProcGL("glPushDebugGroup"))
            {
                GL.glPushDebugGroup = (TglPushDebugGroup)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPushDebugGroup));
            }

            if (GL.LinkProcGL("glPopDebugGroup"))
            {
                GL.glPopDebugGroup = (TglPopDebugGroup)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglPopDebugGroup));
            }

            if (GL.LinkProcGL("glObjectLabel"))
            {
                GL.glObjectLabel = (TglObjectLabel)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglObjectLabel));
            }

            if (GL.LinkProcGL("glGetObjectLabel"))
            {
                GL.glGetObjectLabel = (TglGetObjectLabel)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetObjectLabel));
            }

            if (GL.LinkProcGL("glObjectPtrLabel"))
            {
                GL.glObjectPtrLabel = (TglObjectPtrLabel)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglObjectPtrLabel));
            }

            if (GL.LinkProcGL("glGetObjectPtrLabel"))
            {
                GL.glGetObjectPtrLabel = (TglGetObjectPtrLabel)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetObjectPtrLabel));
            }

            if (GL.LinkProcGL("glFramebufferParameteri"))
            {
                GL.glFramebufferParameteri = (TglFramebufferParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFramebufferParameteri));
            }

            if (GL.LinkProcGL("glGetFramebufferParameteriv"))
            {
                GL.glGetFramebufferParameteriv = (TglGetFramebufferParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetFramebufferParameteriv));
            }

            if (GL.LinkProcGL("glNamedFramebufferParameteriEXT"))
            {
                GL.glNamedFramebufferParameteriEXT = (TglNamedFramebufferParameteriEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferParameteriEXT));
            }

            if (GL.LinkProcGL("glGetNamedFramebufferParameterivEXT"))
            {
                GL.glGetNamedFramebufferParameterivEXT = (TglGetNamedFramebufferParameterivEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedFramebufferParameterivEXT));
            }

            if (GL.LinkProcGL("glGetInternalformati64v"))
            {
                GL.glGetInternalformati64v = (TglGetInternalformati64v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetInternalformati64v));
            }

            if (GL.LinkProcGL("glInvalidateTexSubImage"))
            {
                GL.glInvalidateTexSubImage = (TglInvalidateTexSubImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateTexSubImage));
            }

            if (GL.LinkProcGL("glInvalidateTexImage"))
            {
                GL.glInvalidateTexImage = (TglInvalidateTexImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateTexImage));
            }

            if (GL.LinkProcGL("glInvalidateBufferSubData"))
            {
                GL.glInvalidateBufferSubData = (TglInvalidateBufferSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateBufferSubData));
            }

            if (GL.LinkProcGL("glInvalidateBufferData"))
            {
                GL.glInvalidateBufferData = (TglInvalidateBufferData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateBufferData));
            }

            if (GL.LinkProcGL("glInvalidateFramebuffer"))
            {
                GL.glInvalidateFramebuffer = (TglInvalidateFramebuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateFramebuffer));
            }

            if (GL.LinkProcGL("glInvalidateSubFramebuffer"))
            {
                GL.glInvalidateSubFramebuffer = (TglInvalidateSubFramebuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateSubFramebuffer));
            }

            if (GL.LinkProcGL("glMultiDrawArraysIndirect"))
            {
                GL.glMultiDrawArraysIndirect = (TglMultiDrawArraysIndirect)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawArraysIndirect));
            }

            if (GL.LinkProcGL("glMultiDrawElementsIndirect"))
            {
                GL.glMultiDrawElementsIndirect = (TglMultiDrawElementsIndirect)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMultiDrawElementsIndirect));
            }

            if (GL.LinkProcGL("glGetProgramInterfaceiv"))
            {
                GL.glGetProgramInterfaceiv = (TglGetProgramInterfaceiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramInterfaceiv));
            }

            if (GL.LinkProcGL("glGetProgramResourceIndex"))
            {
                GL.glGetProgramResourceIndex = (TglGetProgramResourceIndex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramResourceIndex));
            }

            if (GL.LinkProcGL("glGetProgramResourceName"))
            {
                GL.glGetProgramResourceName = (TglGetProgramResourceName)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramResourceName));
            }

            if (GL.LinkProcGL("glGetProgramResourceiv"))
            {
                GL.glGetProgramResourceiv = (TglGetProgramResourceiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramResourceiv));
            }

            if (GL.LinkProcGL("glGetProgramResourceLocation"))
            {
                GL.glGetProgramResourceLocation = (TglGetProgramResourceLocation)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramResourceLocation));
            }

            if (GL.LinkProcGL("glGetProgramResourceLocationIndex"))
            {
                GL.glGetProgramResourceLocationIndex = (TglGetProgramResourceLocationIndex)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetProgramResourceLocationIndex));
            }

            if (GL.LinkProcGL("glShaderStorageBlockBinding"))
            {
                GL.glShaderStorageBlockBinding = (TglShaderStorageBlockBinding)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglShaderStorageBlockBinding));
            }

            if (GL.LinkProcGL("glTexBufferRange"))
            {
                GL.glTexBufferRange = (TglTexBufferRange)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexBufferRange));
            }

            if (GL.LinkProcGL("glTextureBufferRangeEXT"))
            {
                GL.glTextureBufferRangeEXT = (TglTextureBufferRangeEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureBufferRangeEXT));
            }

            if (GL.LinkProcGL("glTexStorage2DMultisample"))
            {
                GL.glTexStorage2DMultisample = (TglTexStorage2DMultisample)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorage2DMultisample));
            }

            if (GL.LinkProcGL("glTexStorage3DMultisample"))
            {
                GL.glTexStorage3DMultisample = (TglTexStorage3DMultisample)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTexStorage3DMultisample));
            }

            if (GL.LinkProcGL("glTextureStorage2DMultisampleEXT"))
            {
                GL.glTextureStorage2DMultisampleEXT = (TglTextureStorage2DMultisampleEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureStorage2DMultisampleEXT));
            }

            if (GL.LinkProcGL("glTextureStorage3DMultisampleEXT"))
            {
                GL.glTextureStorage3DMultisampleEXT = (TglTextureStorage3DMultisampleEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureStorage3DMultisampleEXT));
            }

            if (GL.LinkProcGL("glTextureView"))
            {
                GL.glTextureView = (TglTextureView)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureView));
            }

            if (GL.LinkProcGL("glBindVertexBuffer"))
            {
                GL.glBindVertexBuffer = (TglBindVertexBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindVertexBuffer));
            }

            if (GL.LinkProcGL("glVertexAttribFormat"))
            {
                GL.glVertexAttribFormat = (TglVertexAttribFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribFormat));
            }

            if (GL.LinkProcGL("glVertexAttribIFormat"))
            {
                GL.glVertexAttribIFormat = (TglVertexAttribIFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribIFormat));
            }

            if (GL.LinkProcGL("glVertexAttribLFormat"))
            {
                GL.glVertexAttribLFormat = (TglVertexAttribLFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribLFormat));
            }

            if (GL.LinkProcGL("glVertexAttribBinding"))
            {
                GL.glVertexAttribBinding = (TglVertexAttribBinding)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexAttribBinding));
            }

            if (GL.LinkProcGL("glVertexBindingDivisor"))
            {
                GL.glVertexBindingDivisor = (TglVertexBindingDivisor)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexBindingDivisor));
            }

            if (GL.LinkProcGL("glVertexArrayBindVertexBufferEXT"))
            {
                GL.glVertexArrayBindVertexBufferEXT = (TglVertexArrayBindVertexBufferEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayBindVertexBufferEXT));
            }

            if (GL.LinkProcGL("glVertexArrayVertexAttribFormatEXT"))
            {
                GL.glVertexArrayVertexAttribFormatEXT = (TglVertexArrayVertexAttribFormatEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayVertexAttribFormatEXT));
            }

            if (GL.LinkProcGL("glVertexArrayVertexAttribIFormatEXT"))
            {
                GL.glVertexArrayVertexAttribIFormatEXT = (TglVertexArrayVertexAttribIFormatEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayVertexAttribIFormatEXT));
            }

            if (GL.LinkProcGL("glVertexArrayVertexAttribLFormatEXT"))
            {
                GL.glVertexArrayVertexAttribLFormatEXT = (TglVertexArrayVertexAttribLFormatEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayVertexAttribLFormatEXT));
            }

            if (GL.LinkProcGL("glVertexArrayVertexAttribBindingEXT"))
            {
                GL.glVertexArrayVertexAttribBindingEXT = (TglVertexArrayVertexAttribBindingEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayVertexAttribBindingEXT));
            }

            if (GL.LinkProcGL("glVertexArrayVertexBindingDivisorEXT"))
            {
                GL.glVertexArrayVertexBindingDivisorEXT = (TglVertexArrayVertexBindingDivisorEXT)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayVertexBindingDivisorEXT));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 4.4 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 4.4 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 4.4 FUNCTIONS...
            if (GL.LinkProcGL("glBufferStorage"))
            {
                GL.glBufferStorage = (TglBufferStorage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBufferStorage));
            }

            if (GL.LinkProcGL("glClearTexImage"))
            {
                GL.glClearTexImage = (TglClearTexImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearTexImage));
            }

            if (GL.LinkProcGL("glClearTexSubImage"))
            {
                GL.glClearTexSubImage = (TglClearTexSubImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearTexSubImage));
            }

            if (GL.LinkProcGL("glBindBuffersBase"))
            {
                GL.glBindBuffersBase = (TglBindBuffersBase)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindBuffersBase));
            }

            if (GL.LinkProcGL("glBindBuffersRange"))
            {
                GL.glBindBuffersRange = (TglBindBuffersRange)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindBuffersRange));
            }

            if (GL.LinkProcGL("glBindTextures"))
            {
                GL.glBindTextures = (TglBindTextures)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindTextures));
            }

            if (GL.LinkProcGL("glBindSamplers"))
            {
                GL.glBindSamplers = (TglBindSamplers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindSamplers));
            }

            if (GL.LinkProcGL("glBindImageTextures"))
            {
                GL.glBindImageTextures = (TglBindImageTextures)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindImageTextures));
            }

            if (GL.LinkProcGL("glBindVertexBuffers"))
            {
                GL.glBindVertexBuffers = (TglBindVertexBuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindVertexBuffers));
            }
            #endregion

            ///////////////////////////////////////////////////////////////////
            // OPENGL 4.5 FUNCTIONS
            ///////////////////////////////////////////////////////////////////

            GLConfig.LogWriteLine();
            GLConfig.LogWriteLine("Linking OpenGL Core 4.5 functions...");
            GLConfig.LogWriteLine("============================================================");

            #region LINKING OPENGL CORE 4.5 FUNCTIONS...
            if (GL.LinkProcGL("glClipControl"))
            {
                GL.glClipControl = (TglClipControl)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClipControl));
            }

            if (GL.LinkProcGL("glCreateTransformFeedbacks"))
            {
                GL.glCreateTransformFeedbacks = (TglCreateTransformFeedbacks)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateTransformFeedbacks));
            }

            if (GL.LinkProcGL("glTransformFeedbackBufferBase"))
            {
                GL.glTransformFeedbackBufferBase = (TglTransformFeedbackBufferBase)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTransformFeedbackBufferBase));
            }

            if (GL.LinkProcGL("glTransformFeedbackBufferRange"))
            {
                GL.glTransformFeedbackBufferRange = (TglTransformFeedbackBufferRange)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTransformFeedbackBufferRange));
            }

            if (GL.LinkProcGL("glGetTransformFeedbackiv"))
            {
                GL.glGetTransformFeedbackiv = (TglGetTransformFeedbackiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTransformFeedbackiv));
            }

            if (GL.LinkProcGL("glGetTransformFeedbacki_v"))
            {
                GL.glGetTransformFeedbacki_v = (TglGetTransformFeedbacki_v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTransformFeedbacki_v));
            }

            if (GL.LinkProcGL("glGetTransformFeedbacki64_v"))
            {
                GL.glGetTransformFeedbacki64_v = (TglGetTransformFeedbacki64_v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTransformFeedbacki64_v));
            }

            if (GL.LinkProcGL("glCreateBuffers"))
            {
                GL.glCreateBuffers = (TglCreateBuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateBuffers));
            }

            if (GL.LinkProcGL("glNamedBufferStorage"))
            {
                GL.glNamedBufferStorage = (TglNamedBufferStorage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedBufferStorage));
            }

            if (GL.LinkProcGL("glNamedBufferData"))
            {
                GL.glNamedBufferData = (TglNamedBufferData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedBufferData));
            }

            if (GL.LinkProcGL("glNamedBufferSubData"))
            {
                GL.glNamedBufferSubData = (TglNamedBufferSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedBufferSubData));
            }

            if (GL.LinkProcGL("glCopyNamedBufferSubData"))
            {
                GL.glCopyNamedBufferSubData = (TglCopyNamedBufferSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyNamedBufferSubData));
            }

            if (GL.LinkProcGL("glClearNamedBufferData"))
            {
                GL.glClearNamedBufferData = (TglClearNamedBufferData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearNamedBufferData));
            }

            if (GL.LinkProcGL("glClearNamedBufferSubData"))
            {
                GL.glClearNamedBufferSubData = (TglClearNamedBufferSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearNamedBufferSubData));
            }

            if (GL.LinkProcGL("glMapNamedBuffer"))
            {
                GL.glMapNamedBuffer = (TglMapNamedBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapNamedBuffer));
            }

            if (GL.LinkProcGL("glMapNamedBufferRange"))
            {
                GL.glMapNamedBufferRange = (TglMapNamedBufferRange)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMapNamedBufferRange));
            }

            if (GL.LinkProcGL("glUnmapNamedBuffer"))
            {
                GL.glUnmapNamedBuffer = (TglUnmapNamedBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglUnmapNamedBuffer));
            }

            if (GL.LinkProcGL("glFlushMappedNamedBufferRange"))
            {
                GL.glFlushMappedNamedBufferRange = (TglFlushMappedNamedBufferRange)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglFlushMappedNamedBufferRange));
            }

            if (GL.LinkProcGL("glGetNamedBufferParameteriv"))
            {
                GL.glGetNamedBufferParameteriv = (TglGetNamedBufferParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedBufferParameteriv));
            }

            if (GL.LinkProcGL("glGetNamedBufferParameteri64v"))
            {
                GL.glGetNamedBufferParameteri64v = (TglGetNamedBufferParameteri64v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedBufferParameteri64v));
            }

            if (GL.LinkProcGL("glGetNamedBufferPointerv"))
            {
                GL.glGetNamedBufferPointerv = (TglGetNamedBufferPointerv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedBufferPointerv));
            }

            if (GL.LinkProcGL("glGetNamedBufferSubData"))
            {
                GL.glGetNamedBufferSubData = (TglGetNamedBufferSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedBufferSubData));
            }

            if (GL.LinkProcGL("glCreateFramebuffers"))
            {
                GL.glCreateFramebuffers = (TglCreateFramebuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateFramebuffers));
            }

            if (GL.LinkProcGL("glNamedFramebufferRenderbuffer"))
            {
                GL.glNamedFramebufferRenderbuffer = (TglNamedFramebufferRenderbuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferRenderbuffer));
            }

            if (GL.LinkProcGL("glNamedFramebufferParameteri"))
            {
                GL.glNamedFramebufferParameteri = (TglNamedFramebufferParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferParameteri));
            }

            if (GL.LinkProcGL("glNamedFramebufferTexture"))
            {
                GL.glNamedFramebufferTexture = (TglNamedFramebufferTexture)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferTexture));
            }

            if (GL.LinkProcGL("glNamedFramebufferTextureLayer"))
            {
                GL.glNamedFramebufferTextureLayer = (TglNamedFramebufferTextureLayer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferTextureLayer));
            }

            if (GL.LinkProcGL("glNamedFramebufferDrawBuffer"))
            {
                GL.glNamedFramebufferDrawBuffer = (TglNamedFramebufferDrawBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferDrawBuffer));
            }

            if (GL.LinkProcGL("glNamedFramebufferDrawBuffers"))
            {
                GL.glNamedFramebufferDrawBuffers = (TglNamedFramebufferDrawBuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferDrawBuffers));
            }

            if (GL.LinkProcGL("glNamedFramebufferReadBuffer"))
            {
                GL.glNamedFramebufferReadBuffer = (TglNamedFramebufferReadBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedFramebufferReadBuffer));
            }

            if (GL.LinkProcGL("glInvalidateNamedFramebufferData"))
            {
                GL.glInvalidateNamedFramebufferData = (TglInvalidateNamedFramebufferData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateNamedFramebufferData));
            }

            if (GL.LinkProcGL("glInvalidateNamedFramebufferSubData"))
            {
                GL.glInvalidateNamedFramebufferSubData = (TglInvalidateNamedFramebufferSubData)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglInvalidateNamedFramebufferSubData));
            }

            if (GL.LinkProcGL("glClearNamedFramebufferiv"))
            {
                GL.glClearNamedFramebufferiv = (TglClearNamedFramebufferiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearNamedFramebufferiv));
            }

            if (GL.LinkProcGL("glClearNamedFramebufferuiv"))
            {
                GL.glClearNamedFramebufferuiv = (TglClearNamedFramebufferuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearNamedFramebufferuiv));
            }

            if (GL.LinkProcGL("glClearNamedFramebufferfv"))
            {
                GL.glClearNamedFramebufferfv = (TglClearNamedFramebufferfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearNamedFramebufferfv));
            }

            if (GL.LinkProcGL("glClearNamedFramebufferfi"))
            {
                GL.glClearNamedFramebufferfi = (TglClearNamedFramebufferfi)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglClearNamedFramebufferfi));
            }

            if (GL.LinkProcGL("glBlitNamedFramebuffer"))
            {
                GL.glBlitNamedFramebuffer = (TglBlitNamedFramebuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBlitNamedFramebuffer));
            }

            if (GL.LinkProcGL("glCheckNamedFramebufferStatus"))
            {
                GL.glCheckNamedFramebufferStatus = (TglCheckNamedFramebufferStatus)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCheckNamedFramebufferStatus));
            }

            if (GL.LinkProcGL("glGetNamedFramebufferParameteriv"))
            {
                GL.glGetNamedFramebufferParameteriv = (TglGetNamedFramebufferParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedFramebufferParameteriv));
            }

            if (GL.LinkProcGL("glGetNamedFramebufferAttachmentParameteriv"))
            {
                GL.glGetNamedFramebufferAttachmentParameteriv = (TglGetNamedFramebufferAttachmentParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedFramebufferAttachmentParameteriv));
            }

            if (GL.LinkProcGL("glCreateRenderbuffers"))
            {
                GL.glCreateRenderbuffers = (TglCreateRenderbuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateRenderbuffers));
            }

            if (GL.LinkProcGL("glNamedRenderbufferStorage"))
            {
                GL.glNamedRenderbufferStorage = (TglNamedRenderbufferStorage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedRenderbufferStorage));
            }

            if (GL.LinkProcGL("glNamedRenderbufferStorageMultisample"))
            {
                GL.glNamedRenderbufferStorageMultisample = (TglNamedRenderbufferStorageMultisample)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglNamedRenderbufferStorageMultisample));
            }

            if (GL.LinkProcGL("glGetNamedRenderbufferParameteriv"))
            {
                GL.glGetNamedRenderbufferParameteriv = (TglGetNamedRenderbufferParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetNamedRenderbufferParameteriv));
            }

            if (GL.LinkProcGL("glCreateTextures"))
            {
                GL.glCreateTextures = (TglCreateTextures)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateTextures));
            }

            if (GL.LinkProcGL("glTextureBuffer"))
            {
                GL.glTextureBuffer = (TglTextureBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureBuffer));
            }

            if (GL.LinkProcGL("glTextureBufferRange"))
            {
                GL.glTextureBufferRange = (TglTextureBufferRange)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureBufferRange));
            }

            if (GL.LinkProcGL("glTextureStorage1D"))
            {
                GL.glTextureStorage1D = (TglTextureStorage1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureStorage1D));
            }

            if (GL.LinkProcGL("glTextureStorage2D"))
            {
                GL.glTextureStorage2D = (TglTextureStorage2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureStorage2D));
            }

            if (GL.LinkProcGL("glTextureStorage3D"))
            {
                GL.glTextureStorage3D = (TglTextureStorage3D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureStorage3D));
            }

            if (GL.LinkProcGL("glTextureStorage2DMultisample"))
            {
                GL.glTextureStorage2DMultisample = (TglTextureStorage2DMultisample)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureStorage2DMultisample));
            }

            if (GL.LinkProcGL("glTextureStorage3DMultisample"))
            {
                GL.glTextureStorage3DMultisample = (TglTextureStorage3DMultisample)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureStorage3DMultisample));
            }

            if (GL.LinkProcGL("glTextureSubImage1D"))
            {
                GL.glTextureSubImage1D = (TglTextureSubImage1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureSubImage1D));
            }

            if (GL.LinkProcGL("glTextureSubImage2D"))
            {
                GL.glTextureSubImage2D = (TglTextureSubImage2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureSubImage2D));
            }

            if (GL.LinkProcGL("glTextureSubImage3D"))
            {
                GL.glTextureSubImage3D = (TglTextureSubImage3D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureSubImage3D));
            }

            if (GL.LinkProcGL("glCompressedTextureSubImage1D"))
            {
                GL.glCompressedTextureSubImage1D = (TglCompressedTextureSubImage1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTextureSubImage1D));
            }

            if (GL.LinkProcGL("glCompressedTextureSubImage2D"))
            {
                GL.glCompressedTextureSubImage2D = (TglCompressedTextureSubImage2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTextureSubImage2D));
            }

            if (GL.LinkProcGL("glCompressedTextureSubImage3D"))
            {
                GL.glCompressedTextureSubImage3D = (TglCompressedTextureSubImage3D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCompressedTextureSubImage3D));
            }

            if (GL.LinkProcGL("glCopyTextureSubImage1D"))
            {
                GL.glCopyTextureSubImage1D = (TglCopyTextureSubImage1D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTextureSubImage1D));
            }

            if (GL.LinkProcGL("glCopyTextureSubImage2D"))
            {
                GL.glCopyTextureSubImage2D = (TglCopyTextureSubImage2D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTextureSubImage2D));
            }

            if (GL.LinkProcGL("glCopyTextureSubImage3D"))
            {
                GL.glCopyTextureSubImage3D = (TglCopyTextureSubImage3D)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCopyTextureSubImage3D));
            }

            if (GL.LinkProcGL("glTextureParameterf"))
            {
                GL.glTextureParameterf = (TglTextureParameterf)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureParameterf));
            }

            if (GL.LinkProcGL("glTextureParameterfv"))
            {
                GL.glTextureParameterfv = (TglTextureParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureParameterfv));
            }

            if (GL.LinkProcGL("glTextureParameteri"))
            {
                GL.glTextureParameteri = (TglTextureParameteri)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureParameteri));
            }

            if (GL.LinkProcGL("glTextureParameterIiv"))
            {
                GL.glTextureParameterIiv = (TglTextureParameterIiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureParameterIiv));
            }

            if (GL.LinkProcGL("glTextureParameterIuiv"))
            {
                GL.glTextureParameterIuiv = (TglTextureParameterIuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureParameterIuiv));
            }

            if (GL.LinkProcGL("glTextureParameteriv"))
            {
                GL.glTextureParameteriv = (TglTextureParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureParameteriv));
            }

            if (GL.LinkProcGL("glGenerateTextureMipmap"))
            {
                GL.glGenerateTextureMipmap = (TglGenerateTextureMipmap)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGenerateTextureMipmap));
            }

            if (GL.LinkProcGL("glBindTextureUnit"))
            {
                GL.glBindTextureUnit = (TglBindTextureUnit)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglBindTextureUnit));
            }

            if (GL.LinkProcGL("glGetTextureImage"))
            {
                GL.glGetTextureImage = (TglGetTextureImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureImage));
            }

            if (GL.LinkProcGL("glGetCompressedTextureImage"))
            {
                GL.glGetCompressedTextureImage = (TglGetCompressedTextureImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetCompressedTextureImage));
            }

            if (GL.LinkProcGL("glGetTextureLevelParameterfv"))
            {
                GL.glGetTextureLevelParameterfv = (TglGetTextureLevelParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureLevelParameterfv));
            }

            if (GL.LinkProcGL("glGetTextureLevelParameteriv"))
            {
                GL.glGetTextureLevelParameteriv = (TglGetTextureLevelParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureLevelParameteriv));
            }

            if (GL.LinkProcGL("glGetTextureParameterfv"))
            {
                GL.glGetTextureParameterfv = (TglGetTextureParameterfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureParameterfv));
            }

            if (GL.LinkProcGL("glGetTextureParameterIiv"))
            {
                GL.glGetTextureParameterIiv = (TglGetTextureParameterIiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureParameterIiv));
            }

            if (GL.LinkProcGL("glGetTextureParameterIuiv"))
            {
                GL.glGetTextureParameterIuiv = (TglGetTextureParameterIuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureParameterIuiv));
            }

            if (GL.LinkProcGL("glGetTextureParameteriv"))
            {
                GL.glGetTextureParameteriv = (TglGetTextureParameteriv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureParameteriv));
            }

            if (GL.LinkProcGL("glCreateVertexArrays"))
            {
                GL.glCreateVertexArrays = (TglCreateVertexArrays)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateVertexArrays));
            }

            if (GL.LinkProcGL("glDisableVertexArrayAttrib"))
            {
                GL.glDisableVertexArrayAttrib = (TglDisableVertexArrayAttrib)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglDisableVertexArrayAttrib));
            }

            if (GL.LinkProcGL("glEnableVertexArrayAttrib"))
            {
                GL.glEnableVertexArrayAttrib = (TglEnableVertexArrayAttrib)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglEnableVertexArrayAttrib));
            }

            if (GL.LinkProcGL("glVertexArrayElementBuffer"))
            {
                GL.glVertexArrayElementBuffer = (TglVertexArrayElementBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayElementBuffer));
            }

            if (GL.LinkProcGL("glVertexArrayVertexBuffer"))
            {
                GL.glVertexArrayVertexBuffer = (TglVertexArrayVertexBuffer)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayVertexBuffer));
            }

            if (GL.LinkProcGL("glVertexArrayVertexBuffers"))
            {
                GL.glVertexArrayVertexBuffers = (TglVertexArrayVertexBuffers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayVertexBuffers));
            }

            if (GL.LinkProcGL("glVertexArrayAttribBinding"))
            {
                GL.glVertexArrayAttribBinding = (TglVertexArrayAttribBinding)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayAttribBinding));
            }

            if (GL.LinkProcGL("glVertexArrayAttribFormat"))
            {
                GL.glVertexArrayAttribFormat = (TglVertexArrayAttribFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayAttribFormat));
            }

            if (GL.LinkProcGL("glVertexArrayAttribIFormat"))
            {
                GL.glVertexArrayAttribIFormat = (TglVertexArrayAttribIFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayAttribIFormat));
            }

            if (GL.LinkProcGL("glVertexArrayAttribLFormat"))
            {
                GL.glVertexArrayAttribLFormat = (TglVertexArrayAttribLFormat)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayAttribLFormat));
            }

            if (GL.LinkProcGL("glVertexArrayBindingDivisor"))
            {
                GL.glVertexArrayBindingDivisor = (TglVertexArrayBindingDivisor)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglVertexArrayBindingDivisor));
            }

            if (GL.LinkProcGL("glGetVertexArrayiv"))
            {
                GL.glGetVertexArrayiv = (TglGetVertexArrayiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexArrayiv));
            }

            if (GL.LinkProcGL("glGetVertexArrayIndexediv"))
            {
                GL.glGetVertexArrayIndexediv = (TglGetVertexArrayIndexediv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexArrayIndexediv));
            }

            if (GL.LinkProcGL("glGetVertexArrayIndexed64iv"))
            {
                GL.glGetVertexArrayIndexed64iv = (TglGetVertexArrayIndexed64iv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetVertexArrayIndexed64iv));
            }

            if (GL.LinkProcGL("glCreateSamplers"))
            {
                GL.glCreateSamplers = (TglCreateSamplers)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateSamplers));
            }

            if (GL.LinkProcGL("glCreateProgramPipelines"))
            {
                GL.glCreateProgramPipelines = (TglCreateProgramPipelines)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateProgramPipelines));
            }

            if (GL.LinkProcGL("glCreateQueries"))
            {
                GL.glCreateQueries = (TglCreateQueries)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglCreateQueries));
            }

            if (GL.LinkProcGL("glGetQueryBufferObjecti64v"))
            {
                GL.glGetQueryBufferObjecti64v = (TglGetQueryBufferObjecti64v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryBufferObjecti64v));
            }

            if (GL.LinkProcGL("glGetQueryBufferObjectiv"))
            {
                GL.glGetQueryBufferObjectiv = (TglGetQueryBufferObjectiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryBufferObjectiv));
            }

            if (GL.LinkProcGL("glGetQueryBufferObjectui64v"))
            {
                GL.glGetQueryBufferObjectui64v = (TglGetQueryBufferObjectui64v)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryBufferObjectui64v));
            }

            if (GL.LinkProcGL("glGetQueryBufferObjectuiv"))
            {
                GL.glGetQueryBufferObjectuiv = (TglGetQueryBufferObjectuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetQueryBufferObjectuiv));
            }

            if (GL.LinkProcGL("glMemoryBarrierByRegion"))
            {
                GL.glMemoryBarrierByRegion = (TglMemoryBarrierByRegion)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglMemoryBarrierByRegion));
            }

            if (GL.LinkProcGL("glGetTextureSubImage"))
            {
                GL.glGetTextureSubImage = (TglGetTextureSubImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetTextureSubImage));
            }

            if (GL.LinkProcGL("glGetCompressedTextureSubImage"))
            {
                GL.glGetCompressedTextureSubImage = (TglGetCompressedTextureSubImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetCompressedTextureSubImage));
            }

            if (GL.LinkProcGL("glGetGraphicsResetStatus"))
            {
                GL.glGetGraphicsResetStatus = (TglGetGraphicsResetStatus)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetGraphicsResetStatus));
            }

            if (GL.LinkProcGL("glGetnCompressedTexImage"))
            {
                GL.glGetnCompressedTexImage = (TglGetnCompressedTexImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnCompressedTexImage));
            }

            if (GL.LinkProcGL("glGetnTexImage"))
            {
                GL.glGetnTexImage = (TglGetnTexImage)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnTexImage));
            }

            if (GL.LinkProcGL("glGetnUniformdv"))
            {
                GL.glGetnUniformdv = (TglGetnUniformdv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnUniformdv));
            }

            if (GL.LinkProcGL("glGetnUniformfv"))
            {
                GL.glGetnUniformfv = (TglGetnUniformfv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnUniformfv));
            }

            if (GL.LinkProcGL("glGetnUniformiv"))
            {
                GL.glGetnUniformiv = (TglGetnUniformiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnUniformiv));
            }

            if (GL.LinkProcGL("glGetnUniformuiv"))
            {
                GL.glGetnUniformuiv = (TglGetnUniformuiv)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglGetnUniformuiv));
            }

            if (GL.LinkProcGL("glReadnPixels"))
            {
                GL.glReadnPixels = (TglReadnPixels)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglReadnPixels));
            }

            if (GL.LinkProcGL("glTextureBarrier"))
            {
                GL.glTextureBarrier = (TglTextureBarrier)Marshal.GetDelegateForFunctionPointer((IntPtr)GL.glFuncAddr, typeof(TglTextureBarrier));
            }
            #endregion
        }
    }
}
