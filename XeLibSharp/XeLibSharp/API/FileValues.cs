using System;

namespace XeLib.API
{
    public static class FileValues
    {
        private const String FileHeaderFlagsPath = @"File Header\Record Header\Record Flags";
        private const String NextObjectIdPath = @"File Header\HEDR\Next Object ID";

        public static Handle GetNextObjectId(Handle handle)
        {
            return ElementValues.GetUIntValue(handle, NextObjectIdPath);
        }

        public static void SetNextObjectId(Handle handle, Handle nextObjectId)
        {
            ElementValues.SetUIntValue(handle, NextObjectIdPath, nextObjectId);
        }

        public static String GetFileName(Handle handle)
        {
            return ElementValues.Name(handle);
        }

        public static String GetFileAuthor(Handle handle)
        {
            return ElementValues.GetValue(handle, @"File Header\CNAM");
        }

        public static void SetFileAuthor(Handle handle, String author)
        {
            ElementValues.SetValue(handle, @"File Header\CNAM", author);
        }

        public static String GetFileDescription(Handle handle)
        {
            return ElementValues.GetValue(handle, @"File Header\SNAM");
        }

        public static void SetFileDescription(Handle handle, String description)
        {
            if (!Elements.HasElement(handle, @"File Header\SNAM"))
                Elements.AddElement(handle, @"File Header\SNAM");
            ElementValues.SetValue(handle, @"File Header\SNAM", description);
        }

        public static Boolean GetIsEsm(Handle handle)
        {
            return ElementValues.GetFlag(handle, FileHeaderFlagsPath, "ESM");
        }

        public static void SetIsEsm(Handle handle, Boolean state)
        {
            ElementValues.SetFlag(handle, FileHeaderFlagsPath, "ESM", state);
        }
    }
}