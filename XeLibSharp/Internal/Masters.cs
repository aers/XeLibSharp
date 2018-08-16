using System;
using System.Runtime.InteropServices;

namespace XeLib.Internal
{
    internal static partial class Functions
    {
        // MASTER HANDLING METHODS
        //WordBool(__cdecl* CleanMasters)(Cardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean CleanMasters(UInt32 handle);

        //WordBool(__cdecl* SortMasters)(Cardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SortMasters(UInt32 handle);

        //WordBool(__cdecl* AddMaster)(Cardinal, PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean AddMaster(UInt32 handle, String filename);

        //WordBool(__cdecl* AddMasters)(Cardinal, PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean AddMasters(UInt32 handle, String masters);

        //WordBool(__cdecl* AddRequiredMasters)(Cardinal, Cardinal, WordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean AddRequiredMasters(UInt32 handleOne, UInt32 handleTwo, Boolean asNew);

        //WordBool(__cdecl* GetMasters)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetMasters(UInt32 handle, out Int32 len);

        //WordBool(__cdecl* GetRequiredBy)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetRequiredBy(UInt32 handle, out Int32 len);

        //WordBool(__cdecl* GetMasterNames)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetMasterNames(UInt32 handle, out Int32 len);
    }
}
