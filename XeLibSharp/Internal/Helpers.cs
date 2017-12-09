using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using XeLib.API;

namespace XeLib.Internal
{
    internal class Helpers
    {
        public static XeLibException GetException(String message)
        {
            return new XeLibException(message, Messages.GetExceptionMessage());
        }

        public static String ElementContext(UInt32 handle, String path)
        {
            return $"{handle}, \"{path}\"";
        }

        public static String ArrayItemContext(UInt32 handle, String path, String subpath, String value)
        {
            return $"{handle}: {path}, {subpath}, {value}";
        }

        public static String FlagContext(UInt32 handle, String path, String name)
        {
            return $"{handle}, \"{path}\\{name}\"";
        }

        public static String GetExceptionMessageString(Int32 len)
        {
            if (len < 1) return "";
            var bytes = new Byte[len * 2];
            if (!Functions.GetExceptionMessage(bytes, len))
                throw GetException("GetExceptionMessage failed");
            return Encoding.Unicode.GetString(bytes, 0, len * 2);
        }

        public static String GetMessageString(Int32 len)
        {
            if (len < 1) return "";
            var bytes = new Byte[len * 2];
            if (!Functions.GetMessages(bytes, len))
                throw GetException("GetMessages failed");
            return Encoding.Unicode.GetString(bytes, 0, len * 2);
        }

        public static String GetResultString(Int32 len)
        {
            if (len < 1) return "";
            var bytes = new Byte[len * 2];
            if (!Functions.GetResultString(bytes, len))
                throw GetException("GetResultString failed");
            return Encoding.Unicode.GetString(bytes, 0, len*2);
        }

        public static String[] GetResultStringArray(Int32 len)
        {
            return GetResultString(len).Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static Handle[] GetHandleArray(Int32 len)
        {
            if (len < 1) return new Handle[0];
            var array = new UInt32[len];
            if (!Functions.GetResultArray(array, len))
                throw GetException("GetResultArray failed");
            return Array.ConvertAll(array, a => new Handle(a));
        }

        public static Dictionary<String, String> ToDictionary(String input)
        {
            var dict =
                input.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(part => part.Split(new[] { '=' }, 2))
                    .ToDictionary(sp => sp[0], sp => sp[1]);
            return dict;
        }

        public static String Hex(UInt32 val, Int32 padding)
        {
            return val.ToString($"X{padding}");
        }
    }
}
