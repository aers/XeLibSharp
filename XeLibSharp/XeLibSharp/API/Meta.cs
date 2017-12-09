using System;
using XeLib.Internal;

namespace XeLib.API
{
    public static class Meta
    {
        public enum SortBy : Byte
        {
            None = 0,
            FormId = 1,
            EditorId = 2,
            Name = 3
        }

        public static void Initialize()
        {
            Functions.InitXEdit();
        }

        public static void Close()
        {
            Functions.CloseXEdit();
        }

        public static String GetGlobal(String key)
        {
            if (!Functions.GetGlobal(key, out var len))
                throw Helpers.GetException("GetGlobal failed");
            return Helpers.GetResultString(len);
        }

        public static String GetGlobals()
        {
            if (!Functions.GetGlobals(out var len))
                throw Helpers.GetException("GetGlobals failed");
            return Helpers.GetResultString(len);
        }

        public static void SetSortMode(SortBy mode, Boolean reverse)
        {
            if (!Functions.SetSortMode(Convert.ToByte(mode), reverse))
                throw Helpers.GetException(
                    $"Failed to set sort mode to {mode:G} {(reverse ? "ASC" : "DESC")}");
        }

        public static void Release(Handle handle)
        {
            Functions.Release(handle);
        }

        public static void ReleaseNodes(Handle handle)
        {
            Functions.ReleaseNodes(handle);
        }

        public static void Switch(Handle handleOne, Handle handleTwo)
        {
            if (!Functions.Switch(handleOne, handleOne))
                throw Helpers.GetException($"Failed to switch interfaces {handleOne} and {handleTwo}");
        }

        public static Handle[] GetDuplicateHandles(Handle handle)
        {
            if (!Functions.GetDuplicateHandles(handle, out var len))
                throw Helpers.GetException($"Failed to get duplicate handles for {handle}");
            return Helpers.GetHandleArray(len);
        }

        public static void ResetStore()
        {
            if (!Functions.ResetStore())
                throw Helpers.GetException("Failed to reset interface store");
        }
    }
}