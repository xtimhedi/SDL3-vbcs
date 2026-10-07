using SDL;
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



    public interface ISdlHandle { }

    // The reusable, zero-overhead pointer wrapper
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct SdlHandle<T> : IEquatable<SdlHandle<T>> where T : ISdlHandle
    {
        public readonly IntPtr Handle;

        public SdlHandle(IntPtr handle) => Handle = handle;

        public static SdlHandle<T> Null => new SdlHandle<T>(IntPtr.Zero);
        public bool IsNull => Handle == IntPtr.Zero;

        // Equality Implementation
        public bool Equals(SdlHandle<T> other) => Handle == other.Handle;
        public override bool Equals(object? obj) => obj is SdlHandle<T> other && Equals(other);
        public override int GetHashCode() => Handle.GetHashCode();
        public static bool operator ==(SdlHandle<T> left, SdlHandle<T> right) => left.Equals(right);
        public static bool operator !=(SdlHandle<T> left, SdlHandle<T> right) => !left.Equals(right);
    }


    public class Graphics
    {
        // constants
        public const string Dll = "SDL3.dll";

        // Lifecycle
        [DllImport(Dll, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "SDL_Init")]
        public static extern bool Init(InitFlags flags);

        [DllImport(Dll, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "SDL_Quit")]
        public static extern void Quit();

        [DllImport(Dll, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "SDL_InitSubsystem")]
        public static extern bool InitSubsystem(InitFlags flags);

        [DllImport(Dll, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "SDL_GetError")]
        public static extern string GetError();

        [DllImport(Dll, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi, EntryPoint = "SDL_ClearError")]
        public static extern bool ClearError();






    }
}
