using System;
using XeLib.Internal;

namespace XeLib.API
{
    public static class Records
    {
        public enum ConflictAll : Byte
        {
            None = 0,
            CaUnknown = 1,
            CaOnlyOne,
            CaNoConflict,
            CaConflictBenign,
            CaOverride,
            CaConflict,
            CaConflictCritical
        }

        public enum ConflictThis : Byte
        {
            None = 0,
            CtUnknown = 1,
            CtIgnored,
            CtNotDefined,
            CtIdenticalToMaster,
            CtOnlyOne,
            CtHiddenByModGroup,
            CtMaster,
            CtConflictBenign,
            CtOverride,
            CtIdenticalToMasterWinsConflict,
            CtConflictWins,
            CtConflictLoses
        }

        public static UInt32 GetFormId(Handle handle, Boolean native = false, Boolean local = false)
        {
            if (!Functions.GetFormID(handle, out var id, native))
                throw Helpers.GetException($"Failed to get FormID for {handle}");
            return local ? id & 0xFFFFFF : id;
        }

        public static String GetHexFormId(Handle handle, Boolean native = false, Boolean local = false)
        {
            return Helpers.Hex(GetFormId(handle, native, local), local ? 6 : 8);
        }

        public static void SetFormId(Handle handle, UInt32 newFormId, Boolean native = false,
            Boolean fixReferences = true)
        {
            if (!Functions.SetFormID(handle, newFormId, native, fixReferences))
                throw Helpers.GetException($"Failed to set FormID on {handle} to {newFormId}");
        }

        public static Handle GetRecord(Handle handle, UInt32 formId)
        {
            if (!Functions.GetRecord(handle, formId, out var resHandle))
                throw Helpers.GetException($"Failed to get record at {handle}, {formId}");
            return resHandle;
        }

        public static Handle[] GetRecords(Handle handle, String search, Boolean includeOverrides = false)
        {
            if (!Functions.GetRecords(handle, search, includeOverrides, out var len))
                throw Helpers.GetException($"Failed to get records from {Helpers.ElementContext(handle, search)}");
            return Helpers.GetHandleArray(len);
        }

        public static Handle[] GetOverrides(Handle handle)
        {
            if (!Functions.GetOverrides(handle, out var len))
                throw Helpers.GetException($"Failed to get overrides for {handle}");
            return Helpers.GetHandleArray(len);
        }

        public static Handle GetMasterRecord(Handle handle)
        {
            if (!Functions.GetMasterRecord(handle, out var resHandle))
                throw Helpers.GetException("Failed to get master record for {handle}");
            return resHandle;
        }

        public static Handle GetPreviousOverride(Handle handle, Handle file)
        {
            if (!Functions.GetPreviousOverride(handle, file, out var resHandle))
                throw Helpers.GetException($"Failed to get previous override record for {handle} targeting file {file}");
            return resHandle;
        }

        public static Handle GetWinningOverride(Handle handle)
        {
            if (!Functions.GetWinningOverride(handle, out var resHandle))
                throw Helpers.GetException($"Failed to get winning override record for {handle}");
            return resHandle;
        }

        public static Handle FindNextRecord(Handle handle, String search, Boolean byEdId, Boolean byName)
        {
            Functions.FindNextRecord(handle, search, byEdId, byName, out var resHandle);
            return resHandle;
        }

        public static Handle FindPreviousRecord(Handle handle, String search, Boolean byEdId, Boolean byName)
        {
            Functions.FindPreviousRecord(handle, search, byEdId, byName, out var resHandle);
            return resHandle;
        }

        public static String[] FindValidReferences(Handle handle, String signature, String search, Int32 limitTo)
        {
            if (!Functions.FindValidReferences(handle, signature, search, limitTo, out var len))
                throw Helpers.GetException(
                    $"Failed to find valid {signature} out varerences on {handle} searching for {search}");
            return Helpers.GetResultStringArray(len);
        }

        public static Handle[] GetReferencedBy(Handle handle)
        {
            if (!Functions.GetReferencedBy(handle, out var len))
                throw Helpers.GetException($"Failed to get out varerenced by for {handle}");
            return Helpers.GetHandleArray(len);
        }

        public static void ExchangeReferences(Handle handle, UInt32 oldFormId, UInt32 newFormId)
        {
            if (!Functions.ExchangeReferences(handle, oldFormId, newFormId))
                throw Helpers.GetException($"Failed to exchange out varerences on {handle} from {oldFormId} to {newFormId}");
        }

        public static Boolean IsMaster(Handle handle)
        {
            Functions.IsMaster(handle, out var resBool);
            return resBool;
        }

        public static Boolean IsInjected(Handle handle)
        {
            Functions.IsInjected(handle, out var resBool);
            return resBool;
        }

        public static Boolean IsOverride(Handle handle)
        {
            Functions.IsOverride(handle, out var resBool);
            return resBool;
        }

        public static Boolean IsWinningOverride(Handle handle)
        {
            Functions.IsWinningOverride(handle, out var resBool);
            return resBool;
        }

        public static Handle GetNodes(Handle handle)
        {
            if (!Functions.GetNodes(handle, out var resHandle))
                throw Helpers.GetException($"Failed to get nodes for {handle}");
            return resHandle;
        }

        public static ConflictData GetConflictData(Handle nodes, Handle handle)
        {
            return !Functions.GetConflictData(nodes, handle, out var resOne, out var resTwo) ? new ConflictData(0, 0) : new ConflictData(resOne, resTwo);
        }

        public static ConflictData GetConflictDataEx(Handle nodes, Handle handle)
        {
            if (!Functions.GetConflictData(nodes, handle, out var resOne, out var resTwo))
                throw Helpers.GetException($"GetConflictData failed on {nodes}, {handle}");

            return new ConflictData(resOne, resTwo);
        }

        public static ConflictData GetRecordConflictData(Handle handle)
        {
            var nodes = GetNodes(handle);
            try
            {
                return GetConflictDataEx(nodes, handle);
            }
            finally
            {
                Meta.ReleaseNodes(nodes);
            }
        }

        public static Handle[] GetNodeElements(Handle nodes, Handle handle)
        {
            if (!Functions.GetNodeElements(nodes, handle, out var len))
                throw Helpers.GetException($"GetNodeElements failed on {nodes}, {handle}");
            return Helpers.GetHandleArray(len);
        }

        public struct ConflictData
        {
            public ConflictAll CAll { get; }
            public ConflictThis CThis { get; }

            public ConflictData(Byte cAll, Byte cThis)
            {
                CAll = (ConflictAll)cAll;
                CThis = (ConflictThis)cThis;
            }
        }
    }
}