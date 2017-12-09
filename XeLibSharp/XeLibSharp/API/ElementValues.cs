using System;
using System.Collections.Generic;
using System.Diagnostics;
using XeLib.Internal;

namespace XeLib.API
{
    public static class ElementValues
    {
        public static String Name(Handle handle)
        {
            Functions.Name(handle, out var len);
            return Helpers.GetResultString(len);
        }

        public static String LongName(Handle handle)
        {
            Functions.LongName(handle, out var len);
            return Helpers.GetResultString(len);
        }

        public static String DisplayName(Handle handle)
        {
            Functions.DisplayName(handle, out var len);
            return Helpers.GetResultString(len);
        }

        public static String PlacementName(Handle handle)
        {
            if (!Elements.HasElement(handle, "NAME"))
                return null;

            String result;
            using (var h = Elements.GetLinksTo(handle, "NAME"))
            {
                result = $"Places {Name(h)}";
            }

            return result;
        }

        public static String Path(Handle handle)
        {
            if (!Functions.Path(handle, true, false, out var len))
                throw Helpers.GetException($"Path failed on {handle}");
            return Helpers.GetResultString(len);
        }

        public static String LongPath(Handle handle)
        {
            if (!Functions.Path(handle, false, false, out var len))
                throw Helpers.GetException($"Long path failed on {handle}");
            return Helpers.GetResultString(len);
        }

        public static String LocalPath(Handle handle)
        {
            if (!Functions.Path(handle, false, true, out var len))
                throw Helpers.GetException($"Local path failed on {handle}");
            return Helpers.GetResultString(len);
        }

        public static String Signature(Handle handle)
        {
            Functions.Signature(handle, out var len);
            return Helpers.GetResultString(len);
        }

        public static String SortKey(Handle handle)
        {
            Functions.SortKey(handle, out var len);
            return Helpers.GetResultString(len);
        }

        public static String GetValue(Handle handle, String path = "")
        {
            Functions.GetValue(handle, path, out var len);
            return Helpers.GetResultString(len);
        }

        public static String GetValueEx(Handle handle, String path = "")
        {
            if (!Functions.GetValue(handle, path, out var len))
                throw Helpers.GetException($"Failed to get element value at {Helpers.ElementContext(handle, path)}");
            return Helpers.GetResultString(len);
        }

        public static void SetValue(Handle handle, String value)
        {
            SetValue(handle, "", value);
        }

        public static void SetValue(Handle handle, String path, String value)
        {
            if (!Functions.SetValue(handle, path, value))
                throw Helpers.GetException($"Failed to set element value at {Helpers.ElementContext(handle, path)} to {value}");
        }

        public static Int32 GetIntValue(Handle handle, String path = "")
        {
            Functions.GetIntValue(handle, path, out var resInt);
            return resInt;
        }

        public static Int32 GetIntValueEx(Handle handle, String path = "")
        {
            if (!Functions.GetIntValue(handle, path, out var resInt))
                throw Helpers.GetException($"Failed to get integer value at {Helpers.ElementContext(handle, path)}");
            return resInt;
        }

        public static void SetIntValue(Handle handle, Int32 value)
        {
            SetIntValue(handle, "", value);
        }

        public static void SetIntValue(Handle handle, String path, Int32 value)
        {
            if (!Functions.SetIntValue(handle, path, value))
                throw Helpers.GetException($"Failed to set integer value at {Helpers.ElementContext(handle, path)} to {value}");
        }

        public static UInt32 GetUIntValue(Handle handle, String path = "")
        {
            Functions.GetUIntValue(handle, path, out var resInt);
            return resInt;
        }

        public static UInt32 GetUIntValueEx(Handle handle, String path = "")
        {
            if (!Functions.GetUIntValue(handle, path, out var resInt))
                throw Helpers.GetException($"Failed to get unsigned integer value at {Helpers.ElementContext(handle, path)}");
            return resInt;
        }

        public static void SetUIntValue(Handle handle, Handle value)
        {
            SetUIntValue(handle, "", value);
        }

        public static void SetUIntValue(Handle handle, String path, Handle value)
        {
            if (!Functions.SetUIntValue(handle, path, value))
                throw Helpers.GetException(
                    $"Failed to set unsigned integer value at {Helpers.ElementContext(handle, path)} to {value}");
        }

        public static Double GetFloatValue(Handle handle, String path = "")
        {
            Functions.GetFloatValue(handle, path, out var resDouble);
            return resDouble;
        }

        public static Double GetFloatValueEx(Handle handle, String path = "")
        {
            if (!Functions.GetFloatValue(handle, path, out var resDouble))
                throw Helpers.GetException($"Failed to get float value at {Helpers.ElementContext(handle, path)}");
            return resDouble;
        }

        public static void SetFloatValue(Handle handle, Double value)
        {
            SetFloatValue(handle, "", value);
        }

        public static void SetFloatValue(Handle handle, String path, Double value)
        {
            if (!Functions.SetFloatValue(handle, path, value))
                throw Helpers.GetException($"Failed to set float integer value at {Helpers.ElementContext(handle, path)} to {value}");
        }

        public static Boolean GetFlag(Handle handle, String path, String name)
        {
            if (!Functions.GetFlag(handle, path, name, out var resBool))
                throw Helpers.GetException($"Failed to get flag value at {Helpers.FlagContext(handle, path, name)}");
            return resBool;
        }

        public static void SetFlag(Handle handle, String path, String name, Boolean state)
        {
            if (!Functions.SetFlag(handle, path, name, state))
                throw Helpers.GetException($"Failed to set flag value at {Helpers.FlagContext(handle, path, name)} to {state}");
        }

        public static String[] GetEnabledFlags(Handle handle, String path = "")
        {
            if (!Functions.GetEnabledFlags(handle, path, out var len))
                throw Helpers.GetException($"Failed to get enabled flags at {Helpers.ElementContext(handle, path)}");
            return Helpers.GetResultString(len).Split(',');
        }

        public static void SetEnabledFlags(Handle handle, String path, String[] flags)
        {
            if (!Functions.SetEnabledFlags(handle, path, String.Join(",", flags)))
                throw Helpers.GetException($"Failed to set enabled flags at {Helpers.ElementContext(handle, path)}");
        }

        public static String[] GetAllFlags(Handle handle, String path = "")
        {
            if (!Functions.GetAllFlags(handle, path, out var len))
                throw Helpers.GetException($"Failed to get all flags at {Helpers.ElementContext(handle, path)}");
            return Helpers.GetResultString(len).Split(',');
        }

        public static String[] GetEnumOption(Handle handle, String path = "")
        {
            if (!Functions.GetEnumOptions(handle, path, out var len))
                throw Helpers.GetException($"Failed to get enum options at {Helpers.ElementContext(handle, path)}");
            return Helpers.GetResultString(len).Split(',');
        }

        public static String SignatureFromName(String name)
        {
            if (!Functions.SignatureFromName(name, out var len))
                throw Helpers.GetException($"Failed to get signature from name {name}");
            return Helpers.GetResultString(len);
        }

        public static String NameFromSignature(String sig)
        {
            if (!Functions.NameFromSignature(sig, out var len))
                throw Helpers.GetException($"Failed to get name from signature {sig}");
            return Helpers.GetResultString(len);
        }

        public static Dictionary<String, String> GetSignatureNameMap()
        {
            if (!Functions.GetSignatureNameMap(out var len))
                throw Helpers.GetException("Failed to get signature name map");
            return Helpers.ToDictionary(Helpers.GetResultString(len));
        }
    }
}