using System;
using System.Runtime.InteropServices;

namespace XeLib.Internal
{
    internal static partial class Functions {
        // META METHODS
        //void (__cdecl* InitXEdit) ();
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void InitXEdit();

        //void (__cdecl* CloseXEdit) ();
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void CloseXEdit();

        //WordBool(__cdecl* GetResultString)(PWChar, Integer);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetResultString(Byte[] result, Int32 len);

        //WordBool(__cdecl* GetResultArray)(PCardinal, Integer);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetResultArray(UInt32[] result, Int32 len);

        //WordBool(__cdecl* GetGlobal)(PWChar, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetGlobal(String key, out Int32 len);

        //WordBool(__cdecl* GetGlobals)(PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetGlobals(out Int32 len);

        //WordBool(__cdecl* SetSortMode)(Byte, WordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetSortMode(Byte mode, Boolean reverse);

        //WordBool(__cdecl* Release)(Cardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Release(UInt32 handle);

        //WordBool(__cdecl* ReleaseNodes)(Cardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ReleaseNodes(UInt32 handle);

        //WordBool(__cdecl* Switch)(Cardinal, Cardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Switch(UInt32 handleOne, UInt32 handleTwo);

        //WordBool(__cdecl* GetDuplicateHandles)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetDuplicateHandles(UInt32 handle, out Int32 len);

        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean CleanStore();

        //WordBool(__cdecl* ResetStore)();
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ResetStore();
    }
}
