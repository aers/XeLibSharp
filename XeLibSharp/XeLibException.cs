using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace XeLib
{
    [Serializable]
    public sealed class XeLibException : Exception
    {
        public XeLibException()
        {
            XeditLibExceptionMessage = "";
        }

        public XeLibException(String message) : base(message)
        {
            XeditLibExceptionMessage = "";
        }

        public XeLibException(String message, String xeMessage) : base(message)
        {
            XeditLibExceptionMessage = xeMessage;
        }

        public XeLibException(String message, Exception innerException) : base(message, innerException)
        {
            XeditLibExceptionMessage = "";
        }

        public XeLibException(String message, String xeMessage, Exception innerException) : base(message, innerException)
        {
            XeditLibExceptionMessage = xeMessage;
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        private XeLibException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            XeditLibExceptionMessage = info.GetString("XeditLibExceptionMessage");
        }

        public String XeditLibExceptionMessage { get; }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException(nameof(info));
            }
            info.AddValue("XeditLibExceptionMessage", XeditLibExceptionMessage);
            base.GetObjectData(info, context);
        }

        public override String ToString()
        {
            return base.ToString() + "\r\n" + XeditLibExceptionMessage;
        }
    }
}