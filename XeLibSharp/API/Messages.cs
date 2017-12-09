using System;
using XeLib.Internal;

namespace XeLib.API
{
    public static class Messages
    {
        public static String GetMessages()
        {
            Functions.GetMessagesLength(out var len);
            return Helpers.GetMessageString(len);
        }

        public static void ClearMessages()
        {
            Functions.ClearMessages();
        }

        public static String GetExceptionMessage()
        {
            Functions.GetExceptionMessageLength(out var len);
            return Helpers.GetExceptionMessageString(len);
        }
    }
}