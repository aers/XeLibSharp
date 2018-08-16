using System;
using System.Runtime.InteropServices;

namespace XeLib.Internal
{
    internal static partial class Functions
    {
        // SERIALIZATION METHODS
        //WordBool(__cdecl* ElementToJson)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ElementToJson(UInt32 handle, out Int32 len);

        //WordBool(__cdecl* ElementFromJson)(Cardinal, PWChar, PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ElementFromJson(UInt32 handle, String path, String json);
    }
}
