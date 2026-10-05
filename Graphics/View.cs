using System;
using System.Collections.Generic;
using System.Text;
using SDL;
using System.Runtime.InteropServices;


namespace MaddiesBasicLib
{
    public static partial class Graphics
    {
        [DllImport(Dll, EntryPoint = "SDL_Delay", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void Delay(UInt32 ms);
    }
}
