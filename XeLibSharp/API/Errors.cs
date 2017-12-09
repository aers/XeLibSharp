using System;
using XeLib.Internal;

namespace XeLib.API
{
    public static class Errors
    {
        public static void CheckForErrors(Handle handle)
        {
            if (!Functions.CheckForErrors(handle))
                throw Helpers.GetException($"Failed to check {handle} for errors");
        }

        public static Boolean GetErrorThreadDone()
        {
            return Functions.GetErrorThreadDone();
        }

        // TODO: Json parse result
        public static String GetErrors()
        {
            if (!Functions.GetErrors(out var len))
                throw Helpers.GetException("Failed to get errors");
            return Helpers.GetResultString(len);

        }

        public static void RemoveIdenticalRecords(Handle handle, Boolean removeItms = true, Boolean removeItpos = true)
        {
            if (!Functions.RemoveIdenticalRecords(handle, removeItms, removeItpos))
                throw Helpers.GetException($"Failed to remove identical errors from {handle}");
        }
    }
}