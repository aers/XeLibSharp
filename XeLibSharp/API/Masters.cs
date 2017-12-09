using System;
using System.Linq;
using XeLib.Internal;

namespace XeLib.API
{
    public static class Masters
    {
        public static void CleanMasters(Handle handle)
        {
            if (!Functions.CleanMasters(handle))
                throw Helpers.GetException($"Failed to clean masters in ${handle}");
        }

        public static void SortMasters(Handle handle)
        {
            if (!Functions.SortMasters(handle))
                throw Helpers.GetException($"Failed to sort masters in ${handle}");
        }

        public static void AddMaster(Handle handle, String filename)
        {
            if (!Functions.AddMaster(handle, filename))
                throw Helpers.GetException($"Failed to add master {filename} to file {handle}");
        }

        public static void AddRequiredMasters(Handle src, Handle file, Boolean asNew = false)
        {
            if (!Functions.AddRequiredMasters(src, file, asNew))
                throw Helpers.GetException($"Failed to add required masters for {src} to {file}");
        }

        public static Handle[] GetMasters(Handle handle)
        {
            if (!Functions.GetMasters(handle, out var len))
                throw Helpers.GetException($"Failed to get masters for {handle}");
            return Helpers.GetHandleArray(len);
        }

        public static Handle[] GetRequiredBy(Handle handle)
        {
            if (!Functions.GetRequiredBy(handle, out var len))
                throw Helpers.GetException($"Failed to get required by for {handle}");
            return Helpers.GetHandleArray(len);
        }

        public static String[] GetMasterNames(Handle handle)
        {
            if (!Functions.GetMasterNames(handle, out var len))
                throw Helpers.GetException($"Failed to get master names for {handle}");
            return Helpers.GetResultStringArray(len);
        }

        public static void AddAllMasters(Handle handle)
        {
            var filename = ElementValues.Name(handle);
            var loadedFiles = Setup.GetLoadedFileNames();
            var fileIndex = Array.IndexOf(loadedFiles, filename);

            for (var i = 0; i < fileIndex; i++)
            {
                if (loadedFiles[i].EndsWith(".Hardcoded.dat")) continue;
                AddMaster(handle, loadedFiles[i]);
            }
        }

        public static String[] GetAvailableMasters(Handle handle)
        {
            var filename = ElementValues.Name(handle);
            var allMasters = Setup.GetLoadedFileNames();
            var currentMasters = GetMasterNames(handle);
            var index = Array.IndexOf(allMasters, filename);
            return allMasters.Take(index).Except(currentMasters).ToArray();
        }
    }
}