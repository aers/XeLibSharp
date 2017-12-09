using System;
using XeLib.Internal;

namespace XeLib.API
{
    public static class Serialization
    {
        public static String ElementToJson(Handle handle)
        {
            if (!Functions.ElementToJson(handle, out var len))
                throw Helpers.GetException("Failed to serialize element {handle} to JSON");
            return Helpers.GetResultString(len);
        }
    }
}