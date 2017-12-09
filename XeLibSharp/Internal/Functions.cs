using System;
using System.Runtime.InteropServices;

namespace XeLib.Internal
{
    internal static class Functions
    {
        private const String DllPath = @"XEditLib.dll";

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

        //WordBool(__cdecl* ResetStore)();
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ResetStore();

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
        public static extern Boolean GetOverrideRecountCount(UInt32 handle, out Int32 count);

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

        //WordBool(__cdecl* GetAllowedSignatures)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetAllowedSignatures(UInt32 element, out Int32 len);

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

        // SERIALIZATION METHODS
        //WordBool(__cdecl* ElementToJson)(Cardinal, PInteger);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ElementToJson(UInt32 handle, out Int32 len);

        //WordBool(__cdecl* ElementFromJson)(Cardinal, PWChar, PWChar);
        [DllImport(DllPath, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean ElementFromJson(UInt32 handle, String path, String json);

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