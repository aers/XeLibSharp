using System;
using System.Runtime.InteropServices;

namespace XeLib.Internal
{
    internal static partial class Functions
    {
        // LOADING AND SET UP METHODS
        //WordBool(__cdecl* SetGamePath)(PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetGamePath(String gamePath);

        //WordBool(__cdecl* SetLanguage)(PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetLanguage(String language);

        //WordBool(__cdecl* SetBackupPath)(PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetBackupPath(String backupPath);

        //WordBool(__cdecl* SetGameMode)(Integer);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetGameMode(Int32 gameMode);

        //WordBool(__cdecl* GetGamePath)(Integer, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetGamePath(Int32 gameMode, out Int32 len);

        //WordBool(__cdecl* GetLoadOrder)(PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetLoadOrder(out Int32 len);

        //WordBool(__cdecl* GetActivePlugins)(PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetActivePlugins(out Int32 len);

        //WordBool(__cdecl* LoadPlugins)(PWChar, WordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean LoadPlugins(String plugins, Boolean smartLoad);

        //WordBool(__cdecl* LoadPlugin)(PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean LoadPlugin(String filename);

        //WordBool(__cdecl* LoadPluginHeader)(PWChar, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean LoadPluginHeader(String filename, out UInt32 handle);

        //WordBool(__cdecl* BuildReferences)(Cardinal, WordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean BuildReferences(UInt32 handle, Boolean sync);

        //WordBool(__cdecl* GetLoaderStatus)(PByte);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetLoaderStatus(out Byte state);

        //WordBool(__cdecl* UnloadPlugin)(Cardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean UnloadPlugin(UInt32 handle);
    }
}
