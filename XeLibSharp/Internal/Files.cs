using System;
using System.Runtime.InteropServices;

namespace XeLib.Internal
{
    internal static partial class Functions
    {
        // FILE HANDLING METHODS
        //WordBool(__cdecl* AddFile)(PWChar, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean AddFile(String filename, out UInt32 handle);

        //WordBool(__cdecl* FileByIndex)(Integer, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean FileByIndex(Int32 index, out UInt32 handle);

        //WordBool(__cdecl* FileByLoadOrder)(Integer, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean FileByLoadOrder(Int32 loadOrder, out UInt32 handle);

        //WordBool(__cdecl* FileByName)(PWChar, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean FileByName(String filename, out UInt32 handle);

        //WordBool(__cdecl* FileByAuthor)(PWChar, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean FileByAuthor(String author, out UInt32 handle);

        //WordBool(__cdecl* NukeFile)(Cardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean NukeFile(UInt32 handle);

        //WordBool(__cdecl* RenameFile)(Cardinal, PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean RenameFile(UInt32 handle, String filename);

        //WordBool(__cdecl* SaveFile)(Cardinal, PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SaveFile(UInt32 handle, String filename);

        //WordBool(__cdecl* GetRecordCount)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetRecordCount(UInt32 handle, out Int32 count);

        //WordBool(__cdecl* GetOverrideRecordCount)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetOverrideRecordCount(UInt32 handle, out Int32 count);

        //WordBool(__cdecl* MD5Hash)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean MD5Hash(UInt32 handle, out Int32 len);

        //WordBool(__cdecl* CRCHash)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean CRCHash(UInt32 handle, out Int32 len);

        //WordBool(__cdecl* SortEditorIDs)(Cardinal, PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SortEditorIDs(UInt32 handle, String signature);

        //WordBool(__cdecl* SortNames)(Cardinal, PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SortNames(UInt32 handle, String signature);

        //WordBool(__cdecl* GetFileLoadOrder)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetFileLoadOrder(UInt32 handle, out Int32 loadOrder);
    }
}
