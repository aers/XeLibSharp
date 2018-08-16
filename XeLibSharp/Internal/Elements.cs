using System;
using System.Runtime.InteropServices;

namespace XeLib.Internal
{
    internal static partial class Functions
    {
       // ELEMENT HANDLING METHODS
        //WordBool(__cdecl* HasElement)(Cardinal, PWChar, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean HasElement(UInt32 element, String path, out Boolean res);

        //WordBool(__cdecl* GetElement)(Cardinal, PWChar, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetElement(UInt32 element, String path, out UInt32 res);

        //WordBool(__cdecl* AddElement)(Cardinal, PWChar, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean AddElement(UInt32 element, String path, out UInt32 res);

        //WordBool(__cdecl* AddElementValue)(Cardinal, PWChar, PWChar, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean AddElementValue(UInt32 element, String path, String value, out UInt32 res);

        //WordBool(__cdecl* RemoveElement)(Cardinal, PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean RemoveElement(UInt32 element, String path);

        //WordBool(__cdecl* RemoveElementOrParent)(Cardinal, PWChar);
        // ORIGINAL ERROR: No path
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean RemoveElementOrParent(UInt32 element);

        //WordBool(__cdecl* SetElement)(Cardinal, Cardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetElement(UInt32 elementOne, UInt32 elementTwo);

        //WordBool(__cdecl* GetElements)(Cardinal, PWChar, WordBool, WordBool, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetElements(UInt32 element, String path, Boolean sort, Boolean filter,
            out Int32 len);

        //WordBool(__cdecl* GetDefNames)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetDefNames(UInt32 element, out Int32 len);

        //WordBool(__cdecl* GetAddList)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetAddList(UInt32 element, out Int32 len);

        //WordBool(__cdecl* GetContainer)(Cardinal, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetContainer(UInt32 element, out UInt32 res);

        //WordBool(__cdecl* GetElementFile)(Cardinal, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetElementFile(UInt32 element, out UInt32 res);

        // ORIGINAL ERROR: missing
        //WordBool(__cdecl* GetElementGroup)(Cardinal, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetElementGroup(UInt32 element, out UInt32 res);

        //WordBool(__cdecl* GetElementRecord)(Cardinal, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetElementRecord(UInt32 element, out UInt32 res);

        //WordBool(__cdecl* GetLinksTo)(Cardinal, PWChar, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetLinksTo(UInt32 element, String path, out UInt32 res);

        //WordBool(__cdecl* SetLinksTo)(Cardinal, PWChar, Cardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetLinksTo(UInt32 elementOne, String path, UInt32 elementTwo);

        //WordBool(__cdecl* ElementCount)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ElementCount(UInt32 element, out Int32 count);

        //WordBool(__cdecl* ElementEquals)(Cardinal, Cardinal, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ElementEquals(UInt32 elementOne, UInt32 elementTwo, out Boolean res);

        //WordBool(__cdecl* ElementMatches)(Cardinal, PWChar, PWChar, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ElementMatches(UInt32 element, String path, String value, out Boolean res);

        //WordBool(__cdecl* HasArrayItem)(Cardinal, PWChar, PWChar, PWChar, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean HasArrayItem(UInt32 element, String path, String subpath, String value,
            out Boolean res);

        //WordBool(__cdecl* GetArrayItem)(Cardinal, PWChar, PWChar, PWChar, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetArrayItem(UInt32 element, String path, String subpath, String value,
            out UInt32 res);

        //WordBool(__cdecl* AddArrayItem)(Cardinal, PWChar, PWChar, PWChar, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean AddArrayItem(UInt32 element, String path, String subpath, String value,
            out UInt32 res);

        //WordBool(__cdecl* RemoveArrayItem)(Cardinal, PWChar, PWChar, PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean RemoveArrayItem(UInt32 element, String path, String subpath, String value);

        //WordBool(__cdecl* MoveArrayItem)(Cardinal, Integer);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean MoveArrayItem(UInt32 element, Int32 value);

        //WordBool(__cdecl* CopyElement)(Cardinal, Cardinal, WordBool, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean CopyElement(UInt32 elementOne, UInt32 elementTwo, Boolean asNew, out UInt32 res);

        //WordBool(__cdecl* FindNextElement)(Cardinal, PWChar, WordBool, WordBool, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean FindNextElement(UInt32 element, String search, Boolean byPath, Boolean byValue,
            out UInt32 res);

        //WordBool(__cdecl* FindPreviousElement)(Cardinal, PWChar, WordBool, WordBool, PCardinal);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean FindPreviousElement(UInt32 element, String search, Boolean byPath, Boolean byValue,
            out UInt32 res);

        //WordBool(__cdecl* GetSignatureAllowed)(Cardinal, PWChar, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetSignatureAllowed(UInt32 element, String signature, out Boolean res);

        //WordBool(__cdecl* GetSignaturesAllowed)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetSignaturesAllowed(UInt32 element, out Int32 len);

        //WordBool(__cdecl* GetIsModified)(Cardinal, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetIsModified(UInt32 element, out Boolean res);

        //WordBool(__cdecl* GetIsEditable)(Cardinal, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetIsEditable(UInt32 element, out Boolean res);

        // ORIGINAL ERROR: Missing
        //WordBool(__cdecl* SetIsEditable)(Cardinal, WordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SetIsEditable(UInt32 element, Boolean isEditable);

        //WordBool(__cdecl* GetIsRemoveable)(Cardinal, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetIsRemoveable(UInt32 element, out Boolean res);

        //WordBool(__cdecl* GetCanAdd)(Cardinal, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetCanAdd(UInt32 element, out Boolean res);

        //WordBool(__cdecl* SortKey)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SortKey(UInt32 element, out Int32 len);

        //WordBool(__cdecl* ElementType)(Cardinal, PByte);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ElementType(UInt32 element, out Byte res);

        //WordBool(__cdecl* DefType)(Cardinal, PByte);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean DefType(UInt32 element, out Byte res);

        //WordBool(__cdecl* SmashType)(Cardinal, PByte);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean SmashType(UInt32 element, out Byte res);

        //WordBool(__cdecl* ValueType)(Cardinal, PByte);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ValueType(UInt32 element, out Byte res);

        //WordBool(__cdecl* IsSorted)(Cardinal, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean IsSorted(UInt32 element, out Boolean res);

        //WordBool(__cdecl* IsFixed)(Cardinal, PWordBool);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean IsFixed(UInt32 element, out Boolean res);


    }
}
