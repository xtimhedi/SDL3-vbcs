using System;
using System.Collections.Generic;
using System.Text;
using SDL;
using System.Runtime.InteropServices;


namespace MaddiesBasicLib
{
    [Flags]
    public enum InitFlags : uint
    {
        Timer = 0x00000001,
        Audio = 0x00000010,
        Video = 0x00000020, // Usually what you need for a window
        Joystick = 0x00000200,
        Haptic = 0x00001000,
        GameController = 0x00002000,
        Events = 0x00004000,
        Everything = Timer | Audio | Video | Events | Joystick | Haptic | GameController
    }

    public static partial class Graphics
    {
        [DllImport(Dll, EntryPoint = "SDL_Init", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void Init(InitFlags initFlags);
    }
}
