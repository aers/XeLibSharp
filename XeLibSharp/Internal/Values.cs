using System;
using System.Runtime.InteropServices;

namespace XeLib.Internal
{
    internal static partial class Functions
    {
        // ELEMENT VALUE METHODS
        //WordBool(__cdecl* Name)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Name(UInt32 element, out Int32 len);

        //WordBool(__cdecl* LongName)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean LongName(UInt32 element, out Int32 len);

        //WordBool(__cdecl* DisplayName)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean DisplayName(UInt32 element, out Int32 len);

        //WordBool(__cdecl* Path)(Cardinal, WordBool, WordBool, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Path(UInt32 element, Boolean _short, Boolean local, out Int32 len);

        //WordBool(__cdecl* Signature)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Signature(UInt32 element, out Int32 len);

        //WordBool(__cdecl* GetValue)(Cardinal, PWChar, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetValue(UInt32 element, String path, out Int32 len);

        //WordBool(__cdecl* SetValue)(Cardinal, PWChar, PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetValue(UInt32 element, String path, String value);

        //WordBool(__cdecl* GetIntValue)(Cardinal, PWChar, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetIntValue(UInt32 element, String path, out Int32 res);

        //WordBool(__cdecl* SetIntValue)(Cardinal, PWChar, Integer);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetIntValue(UInt32 element, String path, Int32 value);

        //WordBool(__cdecl* GetUIntValue)(Cardinal, PWChar, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetUIntValue(UInt32 element, String path, out UInt32 res);

        //WordBool(__cdecl* SetUIntValue)(Cardinal, PWChar, Cardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetUIntValue(UInt32 element, String path, UInt32 value);

        //WordBool(__cdecl* GetFloatValue)(Cardinal, PWChar, PDouble);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetFloatValue(UInt32 element, String path, out Double res);

        //WordBool(__cdecl* SetFloatValue)(Cardinal, PWChar, double);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetFloatValue(UInt32 element, String path, Double value);

        //WordBool(__cdecl* GetFlag)(Cardinal, PWChar, PWChar, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetFlag(UInt32 element, String path, String flagName, out Boolean res);

        //WordBool(__cdecl* SetFlag)(Cardinal, PWChar, PWChar, WordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetFlag(UInt32 element, String path, String flagName, Boolean value);

        //WordBool(__cdecl* GetEnabledFlags)(Cardinal, PWChar, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetEnabledFlags(UInt32 element, String path, out Int32 len);

        //WordBool(__cdecl* SetEnabledFlags)(Cardinal, PWChar, PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetEnabledFlags(UInt32 element, String path, String value);

        //WordBool(__cdecl* GetAllFlags)(Cardinal, PWChar, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetAllFlags(UInt32 element, String path, out Int32 len);

        //WordBool(__cdecl* GetEnumOptions)(Cardinal, PWChar, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetEnumOptions(UInt32 element, String path, out Int32 len);

        //WordBool(__cdecl* SignatureFromName)(PWChar, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SignatureFromName(String name, out Int32 len);

        //WordBool(__cdecl* NameFromSignature)(PWChar, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean NameFromSignature(String signature, out Int32 len);

        //WordBool(__cdecl* GetSignatureNameMap)(PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetSignatureNameMap(out Int32 len);


    }
}
