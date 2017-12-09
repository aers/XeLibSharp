using System;

namespace XeLib.API
{
    public static class Groups
    {
        public static Boolean HasGroup(Handle handle, String signature)
        {
            return Elements.HasElement(handle, signature);
        }

        public static void AddGroup(Handle handle, String signature)
        {
            Elements.AddElement(handle, signature);
        }

        public static Handle GetChildGroup(Handle handle)
        {
            return Elements.GetElement(handle, "Child Group");
        }
    }
}