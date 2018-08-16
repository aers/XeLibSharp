using System;
using System.Runtime.InteropServices;

namespace XeLib.Internal
{
    internal static partial class Functions
    {
        // MESSAGE METHODS
        //void (__cdecl* GetMessagesLength) (PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetMessagesLength(out Int32 len);

        //WordBool(__cdecl* GetMessages)(PWChar, Integer);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetMessages(Byte[] result, Int32 len);

        //void (__cdecl* ClearMessages) ();
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void ClearMessages();

        //void (__cdecl* GetExceptionMessageLength) (PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetExceptionMessageLength(out Int32 len);

        //WordBool(__cdecl* GetExceptionMessage)(PWChar, Integer);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetExceptionMessage(Byte[] result, Int32 len);

        //void *(__cdecl* GetExceptionStackLength)(PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetExceptionStackLength(out Int32 len);

        //WordBool(__cdecl* GetExceptionStack)(PWChar, Integer)
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetExceptionStack(Byte[] result, Int32 len);
    }
}
