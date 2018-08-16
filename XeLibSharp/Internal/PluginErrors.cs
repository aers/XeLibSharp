using System;
using System.Runtime.InteropServices;

namespace XeLib.Internal
{
    internal static partial class Functions
    {
        // PLUGIN ERROR METHODS
        //WordBool(__cdecl* CheckForErrors)(Cardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean CheckForErrors(UInt32 handle);

        //WordBool(__cdecl* GetErrorThreadDone)();
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetErrorThreadDone();

        //WordBool(__cdecl* GetErrors)(PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetErrors(out Int32 len);

        //WordBool(__cdecl* RemoveIdenticalRecords)(Cardinal, WordBool, WordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean RemoveIdenticalRecords(UInt32 handle, Boolean removeItms, Boolean removeItpos);
    }
}
