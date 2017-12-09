using System;
using XeLib.Internal;

namespace XeLib.API
{
    public static class Elements
    {
        public enum DefTypes : Byte
        {
            DtRecord = 0,
            DtSubRecord,
            DtSubRecordArray,
            DtSubRecordStruct,
            DtSubRecordUnion,
            DtString,
            DtLString,
            DtLenString,
            DtByteArray,
            DtInteger,
            DtIntegerFormater,
            DtIntegerFormaterUnion,
            DtFlag,
            DtFloat,
            DtArray,
            DtStruct,
            DtUnion,
            DtEmpty,
            DtStructChapter
        }

        public enum ElementTypes : Byte
        {
            EtFile = 0,
            EtMainRecord,
            EtGroupRecord,
            EtSubRecord,
            EtSubRecordStruct,
            EtSubRecordArray,
            EtSubRecordUnion,
            EtArray,
            EtStruct,
            EtValue,
            EtFlag,
            EtStringListTerminator,
            EtUnion,
            EtStructChapter
        }

        public enum SmashTypes : Byte
        {
            StUnknown = 0,
            StRecord,
            StString,
            StInteger,
            StFlag,
            StFloat,
            StStruct,
            StUnsortedArray,
            StUnsortedStructArray,
            StSortedArray,
            StSortedStructArray,
            StByteArray,
            StUnion
        }

        public enum ValueTypes : Byte
        {
            VtUnknown = 0,
            VtBytes,
            VtNumber,
            VtString,
            VtText,
            VtReference,
            VtFlags,
            VtEnum,
            VtColor,
            VtArray,
            VtStruct,
            VtNoValue = 255
        }

        public static Boolean HasElement(Handle handle, String path = "")
        {
            if (!Functions.HasElement(handle, path, out var resBool))
                throw Helpers.GetException($"Failed to check if element exists at {Helpers.ElementContext(handle, path)}");
            return resBool;
        }

        public static Handle GetElement(Handle handle, String path = "")
        {
            Functions.GetElement(handle, path, out var resHandle);
            return resHandle;
        }

        public static Handle GetElementEx(Handle handle, String path = "")
        {
            if (!Functions.GetElement(handle, path, out var resHandle))
                throw Helpers.GetException($"Failed to get element at {Helpers.ElementContext(handle, path)}");
            return resHandle;
        }

        public static Handle AddElement(Handle handle, String path = "")
        {
            if (!Functions.AddElement(handle, path, out var resHandle))
                throw Helpers.GetException($"Failed to create new element at {Helpers.ElementContext(handle, path)}");
            return resHandle;
        }

        public static Handle AddElementValue(Handle handle, String path, String value)
        {
            if (!Functions.AddElementValue(handle, path, value, out var resHandle))
                throw Helpers.GetException(
                    $"Failed to create new element at {Helpers.ElementContext(handle, path)} with value {value}");
            return resHandle;
        }

        public static void RemoveElement(Handle handle, String path = "")
        {
            Functions.RemoveElement(handle, path);
        }

        public static void RemoveElementEx(Handle handle, String path = "")
        {
            if (!Functions.RemoveElement(handle, path))
                throw Helpers.GetException($"Failed to remove element at {Helpers.ElementContext(handle, path)}");
        }

        public static void RemoveElementOrParent(Handle handle)
        {
            if (!Functions.RemoveElementOrParent(handle))
                throw Helpers.GetException($"Failed to remove element {handle}");
        }

        public static void SetElement(Handle src, Handle dest)
        {
            if (!Functions.SetElement(src, dest))
                throw Helpers.GetException($"Failed to set element at {dest} to {src}");
        }

        // We're using UInt32 handle here so we can have a default..
        public static Handle[] GetElements(UInt32 handle = 0, String path = "", Boolean sort = false,
            Boolean filter = false)
        {
            if (!Functions.GetElements(handle, path, sort, filter, out var len))
                throw Helpers.GetException($"Failed to get child elements at {Helpers.ElementContext(handle, path)}");
            return Helpers.GetHandleArray(len);
        }

        public static String[] GetDefNames(Handle handle)
        {
            if (!Functions.GetDefNames(handle, out var len))
                throw Helpers.GetException($"Failed to get def names for {handle}");
            return Helpers.GetResultStringArray(len);
        }

        public static String[] GetAddList(Handle handle)
        {
            if (!Functions.GetAddList(handle, out var len))
                throw Helpers.GetException($"Failed to get add list for {handle}");
            return Helpers.GetResultStringArray(len);
        }

        public static Handle GetLinksTo(Handle handle, String path)
        {
            Functions.GetLinksTo(handle, path, out var resHandle);
            return resHandle;
        }

        public static void SetLinksTo(Handle baseHandle, String path, Handle reference)
        {
            if (!Functions.SetLinksTo(baseHandle, path, reference))
                throw Helpers.GetException($"Failed to set reference at {Helpers.ElementContext(baseHandle, path)}");
        }

        public static Handle GetLinksToEx(Handle handle, String path)
        {
            if (!Functions.GetLinksTo(handle, path, out var resHandle))
                throw Helpers.GetException($"Failed to get reference at {Helpers.ElementContext(handle, path)}");
            return resHandle;
        }

        public static Handle GetContainer(Handle handle)
        {
            Functions.GetContainer(handle, out var resHandle);
            return resHandle;
        }

        public static Handle GetContainerEx(Handle handle)
        {
            if (!Functions.GetContainer(handle, out var resHandle))
                throw Helpers.GetException($"Failed to get container for {handle}");
            return resHandle;
        }

        public static Handle GetElementFile(Handle handle)
        {
            if (!Functions.GetElementFile(handle, out var resHandle))
                throw Helpers.GetException($"Failed to get element file for {handle}");
            return resHandle;
        }

        public static Handle GetElementGroup(Handle handle)
        {
            if (!Functions.GetElementGroup(handle, out var resHandle))
                throw Helpers.GetException($"Failed to get element group for {handle}");
            return resHandle;
        }

        public static Handle GetElementRecord(Handle handle)
        {
            if (!Functions.GetElementRecord(handle, out var resHandle))
                throw Helpers.GetException($"Failed to get element record for {handle}");
            return resHandle;
        }

        public static Int32 ElementCount(Handle handle)
        {
            if (!Functions.ElementCount(handle, out var resInt))
                throw Helpers.GetException($"Failed to get element count for {handle}");
            return resInt;
        }

        public static Boolean ElementEquals(Handle handleOne, Handle handleTwo)
        {
            if (!Functions.ElementEquals(handleOne, handleTwo, out var resBool))
                throw Helpers.GetException($"Failed to check element equality for {handleOne} and {handleTwo}");
            return resBool;
        }

        public static Boolean ElementMatches(Handle handle, String path, String value)
        {
            if (!Functions.ElementMatches(handle, path, value, out var resBool))
                throw Helpers.GetException($"Failed to check element matches for {handle}: {path}, {value}");
            return resBool;
        }

        public static Boolean HasArrayItem(Handle handle, String path, String subpath, String value)
        {
            Functions.HasArrayItem(handle, path, subpath, value, out var resBool);
            return resBool;
        }

        public static Handle GetArrayItem(Handle handle, String path, String subpath, String value)
        {
            Functions.GetArrayItem(handle, path, subpath, value, out var resHandle);
            return resHandle;
        }

        public static Handle AddArrayItem(Handle handle, String path, String subpath, String value)
        {
            if (!Functions.AddArrayItem(handle, path, subpath, value, out var resHandle))
                throw Helpers.GetException($"Failed to add array item to {Helpers.ArrayItemContext(handle, path, subpath, value)}");
            return resHandle;
        }

        public static void RemoveArrayItem(Handle handle, String path, String subpath, String value)
        {
            Functions.RemoveArrayItem(handle, path, subpath, value);
        }

        public static void MoveArrayItem(Handle handle, Int32 index)
        {
            if (!Functions.MoveArrayItem(handle, index))
                throw Helpers.GetException($"Failed to move array item {handle} to {index}");
        }

        public static Handle CopyElement(Handle src, Handle dstContainer, Boolean asNew = false)
        {
            if (!Functions.CopyElement(src, dstContainer, asNew, out var resHandle))
                throw Helpers.GetException($"Failed to copy element {src} to {dstContainer}");
            return resHandle;
        }

        public static Handle FindNextElement(Handle handle, String search, Boolean byPath, Boolean byValue)
        {
            Functions.FindNextElement(handle, search, byPath, byValue, out var resHandle);
            return resHandle;
        }

        public static Handle FindPreviousElement(Handle handle, String search, Boolean byPath, Boolean byValue)
        {
            Functions.FindPreviousElement(handle, search, byPath, byValue, out var resHandle);
            return resHandle;
        }

        public static Boolean GetSignatureAllowed(Handle handle, String signature)
        {
            if (!Functions.GetSignatureAllowed(handle, signature, out var resBool))
                throw Helpers.GetException($"Failed to check if signature {signature} is allowed on {handle}");
            return resBool;
        }

        public static String[] GetAllowedSignatures(Handle handle)
        {
            if (!Functions.GetAllowedSignatures(handle, out var len))
                throw Helpers.GetException($"Failed to get allowed signatures for {handle}");
            return Helpers.GetResultStringArray(len);
        }

        public static Boolean GetIsModified(Handle handle)
        {
            if (!Functions.GetIsModified(handle, out var resBool))
                throw Helpers.GetException($"Failed to get is modified for {handle}");
            return resBool;
        }

        public static Boolean GetIsEditable(Handle handle)
        {
            if (!Functions.GetIsEditable(handle, out var resBool))
                throw Helpers.GetException($"Failed to get is editable for {handle}");
            return resBool;
        }

        public static void SetIsEditable(Handle handle, Boolean isEditable)
        {
            if (!Functions.SetIsEditable(handle, isEditable))
                throw Helpers.GetException($"Failed to set is editable for {handle} to {isEditable}");
        }

        public static Boolean GetIsRemoveable(Handle handle)
        {
            if (!Functions.GetIsRemoveable(handle, out var resBool))
                throw Helpers.GetException($"Failed to get is removeable for {handle}");
            return resBool;
        }

        public static Boolean GetCanAdd(Handle handle)
        {
            if (!Functions.GetCanAdd(handle, out var resBool))
                throw Helpers.GetException($"Failed to get can add for {handle}");
            return resBool;
        }

        public static ElementTypes ElementType(Handle handle)
        {
            if (!Functions.ElementType(handle, out var resByte))
                throw Helpers.GetException($"Failed to get element type for {handle}");
            return (ElementTypes)resByte;
        }

        public static DefTypes DefType(Handle handle)
        {
            if (!Functions.DefType(handle, out var resByte))
                throw Helpers.GetException($"Failed to get def type for {handle}");
            return (DefTypes)resByte;
        }

        public static SmashTypes SmashType(Handle handle)
        {
            if (!Functions.SmashType(handle, out var resByte))
                throw Helpers.GetException($"Failed to get smash type for {handle}");
            return (SmashTypes)resByte;
        }

        public static ValueTypes ValueType(Handle handle)
        {
            if (!Functions.ValueType(handle, out var resByte))
                throw Helpers.GetException($"Failed to get value type for {handle}");
            return (ValueTypes)resByte;
        }

        public static Boolean IsSorted(Handle handle)
        {
            if (!Functions.IsSorted(handle, out var resBool))
                throw Helpers.GetException($"Failed to get is sorted for {handle}");
            return resBool;
        }

        public static Boolean IsFlags(Handle handle)
        {
            return ValueType(handle) == ValueTypes.VtFlags;
        }
    }
}