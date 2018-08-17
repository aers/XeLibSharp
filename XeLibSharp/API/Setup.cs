using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using XeLib.Internal;

namespace XeLib.API
{
    public static class Setup
    {
        public enum GameMode
        {
            FNV = 0,
            FO3 = 1,
            TES4 = 2,
            TES5 = 3,
            SSE = 4,
            FO4 = 5
        }

        public enum LoaderState : Byte
        {
            IsInactive = 0,
            IsActive = 1,
            IsDone = 2,
            HasError = 3
        }

        public static readonly IList<GameInfo> Games = new ReadOnlyCollection<GameInfo>(
            new[]
            {
                new GameInfo("Fallout NV", "FalloutNV", GameMode.FNV, "FalloutNV.exe"),
                new GameInfo("Fallout 3", "Fallout3", GameMode.FO3, "Fallout3.exe"),
                new GameInfo("Oblivion", "Oblivion", GameMode.TES4, "Oblivion.exe"),
                new GameInfo("Skyrim", "Skyrim", GameMode.TES5, "TESV.exe"),
                new GameInfo("Skyrim SE", "Skyrim", GameMode.SSE, "SkyrimSE.exe"),
                new GameInfo("Fallout 4", "Fallout4", GameMode.FO4, "Fallout4.exe")
            });

        public static void SetGamePath(String gamePath)
        {
            if (!Functions.SetGamePath(gamePath))
                throw Helpers.GetException($"Failed to set game path to ${gamePath}");
        }

        public static void SetLanguage(String language)
        {
            if (!Functions.SetLanguage(language))
                throw Helpers.GetException($"Failed to set language to ${language}");
        }

        public static void SetGameMode(GameMode mode)
        {
            if (!Functions.SetGameMode(Convert.ToInt32(mode)))
                throw Helpers.GetException($"Failed to set game mode to ${mode:G}");
        }

        public static String GetLoadOrder()
        {
            if (!Functions.GetLoadOrder(out var len))
                throw Helpers.GetException("Failed to get load order");
            return Helpers.GetResultString(len);

        }

        public static String GetActivePlugins()
        {
            if (!Functions.GetActivePlugins(out var len))
                throw Helpers.GetException("Failed to get active plugins");
            return Helpers.GetResultString(len);

        }

        public static void LoadPlugins(String loadOrder, Boolean smartLoad = true)
        {
            if (!Functions.LoadPlugins(loadOrder, smartLoad))
                throw Helpers.GetException("Failed to load plugins");
        }

        public static void LoadPlugin(String filename)
        {
            if (!Functions.LoadPlugin(filename))
                throw Helpers.GetException($"Failed to load plugin {filename}");
        }

        public static Handle LoadPluginHeader(String filename)
        {
            if (!Functions.LoadPluginHeader(filename, out var handle))
                throw Helpers.GetException($"Failed to load plugin header for {filename}");
            return handle;
        }

        public static void BuildReferences(Handle handle, Boolean sync = true)
        {
            if (!Functions.BuildReferences(handle, sync))
                throw Helpers.GetException($"Failed to build outerences for {handle}");
        }

        public static void UnloadPlugin(Handle handle)
        {
            if (!Functions.UnloadPlugin(handle))
                throw Helpers.GetException($"Failed to unload plugin {handle}");
        }

        public static LoaderState GetLoaderStatus()
        {
            Functions.GetLoaderStatus(out var state);
            return (LoaderState)state;
        }

        public static String GetGamePath(GameMode mode)
        {
            Functions.GetGamePath(Convert.ToInt32(mode), out var len);
            return Helpers.GetResultString(len);
        }

        public static String[] GetLoadedFileNames(Boolean excludeHardcoded = true)
        {
            String[] fileNames;

            using (var g = new HandleGroup(Elements.GetElements()))
            {
                fileNames = g.Values.Select(ElementValues.Name).ToArray();
            }

            if (excludeHardcoded)
                fileNames = Array.FindAll(fileNames, f => !f.EndsWith(".Hardcoded.dat"));

            return fileNames;
        }

        public struct GameInfo
        {
            public readonly String Name;
            public readonly String ShortName;
            public readonly GameMode Mode;
            public readonly String ExeName;

            public GameInfo(String name, String shortName, GameMode mode, String exeName)
            {
                Name = name;
                ShortName = shortName;
                Mode = mode;
                ExeName = exeName;
            }
        }
    }
}