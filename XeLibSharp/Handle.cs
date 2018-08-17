using System;
using XeLib.API;

namespace XeLib
{
    public class Handle : IDisposable, IEquatable<Handle>
    {
        public static Handle BaseHandle = new Handle(0);

        public Handle(UInt32 h)
        {
            Value = h;
        }

        public UInt32 Value { get; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(Boolean disposing)
        {
            if (disposing)
                Meta.Release(Value);
        }

        public static implicit operator UInt32(Handle h)
        {
            return h.Value;
        }

        public static implicit operator Handle(UInt32 u)
        {
            return new Handle(u);
        }

        public override Int32 GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override Boolean Equals(Object obj)
        {
            if (obj is null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;

            return obj.GetType() == GetType() && Equals((Handle) obj);
        }

        public override String ToString()
        {
            return $"Handle({Value})";
        }

        public Boolean Equals(Handle other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value == other.Value;
        }
    }
}