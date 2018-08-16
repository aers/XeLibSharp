using System;
using System.Runtime.InteropServices;

namespace XeLib.Internal
{
    internal static partial class Functions
    {
        // RECORD HANDLING METHODS
        //WordBool(__cdecl* GetFormID)(Cardinal, PCardinal, WordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetFormID(UInt32 element, out UInt32 res, Boolean native);

        //WordBool(__cdecl* SetFormID)(Cardinal, Cardinal, WordBool, WordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetFormID(UInt32 element, UInt32 formId, Boolean native, Boolean fixouts);

        //WordBool(__cdecl* GetRecord)(Cardinal, Cardinal, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetRecord(UInt32 element, UInt32 formId, out UInt32 res);

        //WordBool(__cdecl* GetRecords)(Cardinal, PWChar, WordBool, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetRecords(UInt32 element, String search, Boolean includeOverrides, out Int32 len);

        //WordBool(__cdecl* GetOverrides)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetOverrides(UInt32 element, out Int32 len);

        //WordBool(__cdecl* GetReferencedBy)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetReferencedBy(UInt32 element, out Int32 len);

        //WordBool(__cdecl* GetMasterRecord)(Cardinal, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetMasterRecord(UInt32 element, out UInt32 res);

        //WordBool(__cdecl* GetPreviousOverride)(Cardinal, Cardinal, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetPreviousOverride(UInt32 elementOne, UInt32 elementTwo, out UInt32 res);

        //WordBool(__cdecl* GetWinningOverride)(Cardinal, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetWinningOverride(UInt32 element, out UInt32 res);

        //WordBool(__cdecl* FindNextRecord)(Cardinal, PWChar, WordBool, WordBool, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean FindNextRecord(UInt32 element, String search, Boolean byEdId, Boolean byName,
            out UInt32 res);

        //WordBool(__cdecl* FindPreviousRecord)(Cardinal, PWChar, WordBool, WordBool, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean FindPreviousRecord(UInt32 element, String search, Boolean byEdId, Boolean byName,
            out UInt32 res);

        //WordBool(__cdecl* FindValidReferences)(Cardinal, PWChar, PWChar, Integer, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean FindValidReferences(UInt32 element, String signature, String search, Int32 limitTo,
            out Int32 len);

        //WordBool(__cdecl* ExchangeReferences)(Cardinal, Cardinal, Cardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ExchangeReferences(UInt32 element, UInt32 oldFormId, UInt32 newFormId);

        //WordBool(__cdecl* IsMaster)(Cardinal, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean IsMaster(UInt32 element, out Boolean res);

        //WordBool(__cdecl* IsInjected)(Cardinal, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean IsInjected(UInt32 element, out Boolean res);

        //WordBool(__cdecl* IsOverride)(Cardinal, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean IsOverride(UInt32 element, out Boolean res);

        //WordBool(__cdecl* IsWinningOverride)(Cardinal, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean IsWinningOverride(UInt32 element, out Boolean res);

        //WordBool(__cdecl* GetNodes)(Cardinal, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetNodes(UInt32 element, out UInt32 res);

        //WordBool(__cdecl* GetConflictData)(Cardinal, Cardinal, PByte, PByte);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetConflictData(UInt32 elementOne, UInt32 elementTwo, out Byte resOne,
            out Byte resTwo);

        //WordBool(__cdecl* GetNodeElements)(Cardinal, Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetNodeElements(UInt32 nodes, UInt32 element, out Int32 res);

        // FILTERING METHODS
        //WordBool(__cdecl* FilterRecord)(Cardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean FilterRecord(UInt32 handle);

        //WordBool(__cdecl* ResetFilter)();
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ResetFilter();
    }
}
