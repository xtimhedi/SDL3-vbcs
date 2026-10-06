using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;

namespace MaddiesBasicLib
{
    [Flags]
    public enum InitFlags : uint
    {
        INIT_AUDIO = 0x00000010u,
        INIT_VIDEO = 0x00000020u,
        INIT_JOYSTICK = 0x00000200u,
        INIT_HAPTIC = 0x00000010,
        INIT_GAMEPAD = 0x00002000u,
        INIT_EVENTS = 0x00004000u,
        INIT_SENSOR = 0x00008000u,
        INIT_CAMERA = 0x00010000u
    }
    public class Graphics
    {
        // constants
        public const string Dll = "SDL3.dll";

        // Lifecycle
        [DllImport(Dll, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "SDL_Init")]
        public static extern bool Init(InitFlags flags);
    }
}
