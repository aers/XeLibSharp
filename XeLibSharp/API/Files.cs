using System;
using XeLib.Internal;

namespace XeLib.API
{
    public static class Files
    {
        public static Handle AddFile(String filename)
        {
            if (!Functions.AddFile(filename, out var handle))
                throw Helpers.GetException($"Failed to add new file {filename}");
            return handle;
        }

        public static Handle FileByIndex(Int32 index)
        {
            Functions.FileByIndex(index, out var handle);
            return handle;
        }

        public static Handle FileByLoadOrder(Int32 loadOrder)
        {
            Functions.FileByLoadOrder(loadOrder, out var handle);
            return handle;
        }

        public static Handle FileByName(String filename)
        {
            Functions.FileByName(filename, out var handle);
            return handle;
        }

        public static Handle FileByAuthor(String author)
        {
            Functions.FileByAuthor(author, out var handle);
            return handle;
        }

        public static void NukeFile(Handle handle)
        {
            if (!Functions.NukeFile(handle))
                throw Helpers.GetException($"Failed to nuke file {handle}");
        }

        public static void RenameFile(Handle handle, String newFilename)
        {
            if (!Functions.RenameFile(handle, newFilename))
                throw Helpers.GetException($"Failed to rename file to ${newFilename}");
        }

        public static void SaveFile(Handle handle, String filePath = "")
        {
            if (!Functions.SaveFile(handle, filePath))
                throw Helpers.GetException($"Failed to save file ${handle}");
        }

        public static Int32 GetRecordCount(Handle handle)
        {
            if (!Functions.GetRecordCount(handle, out var resInt))
                throw Helpers.GetException($"Failed to get record count for ${handle}");
            return resInt;
        }

        public static Int32 GetOverrideRecordCount(Handle handle)
        {
            if (!Functions.GetOverrideRecordCount(handle, out var resInt))
                throw Helpers.GetException($"Failed to get override record count for ${handle}");
            return resInt;
        }

        public static String Md5Hash(Handle handle)
        {
            if (!Functions.MD5Hash(handle, out var len))
                throw Helpers.GetException($"Failed to get MD5 hash for ${handle}");
            return Helpers.GetResultString(len);
        }

        public static String CrcHash(Handle handle)
        {
            if (!Functions.CRCHash(handle, out var len))
                throw Helpers.GetException($"Failed to get CRC hash for ${handle}");
            return Helpers.GetResultString(len);
        }

        public static Int32 GetFileLoadOrder(Handle handle)
        {
            if (!Functions.GetFileLoadOrder(handle, out var resInt))
                throw Helpers.GetException($"Failed to get file load order for ${handle}");
            return resInt;
        }

        public static Handle GetFileHeader(Handle handle)
        {
            return Elements.GetElement(handle, "File Header");
        }

        public static void SortEditorIDs(Handle handle, String signature)
        {
            if (!Functions.SortEditorIDs(handle, signature))
                throw Helpers.GetException($"Failed to sort {signature} EditorIDs for {handle}");
        }

        public static void SortNames(Handle handle, String signature)
        {
            if (!Functions.SortNames(handle, signature))
                throw Helpers.GetException($"Failed to sort {signature} Names for {handle}");
        }
    }
}