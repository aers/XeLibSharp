using XeLib.Internal;

namespace XeLib.API
{
    public static class Filters
    {
        public static void FilterRecord(Handle handle)
        {
            if (!Functions.FilterRecord(handle))
                throw Helpers.GetException($"Failed to filter record {ElementValues.Name(handle)}");
        }

        public static void ResetFilter()
        {
            if (!Functions.ResetFilter())
                throw Helpers.GetException("Failed to reset filter");
        }
    }
}