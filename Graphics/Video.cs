using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MaddiesBasicLib
{
    public static partial class Graphics
    {
        [DllImport(Dll, EntryPoint = "SDL_CreateWindow", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern IntPtr CreateWindow(string title, int w, int h, ulong flags);



        [DllImport(Dll, EntryPoint = "SDL_DestroyWindow", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void DestroyWindow(IntPtr window);
    }
}
