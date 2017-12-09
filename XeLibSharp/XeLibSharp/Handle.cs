using System;
using XeLib.API;

namespace XeLib
{
    /// <summary>
    /// Represents a UInt32 handle returned from XEditLib with a disposable wrapper class.
    /// Comparing a Handle with another Handle will compare the internal handle value.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public class Handle : IDisposable, IEquatable<Handle>
    {
        /// <summary>
        /// Handle 0 represents the base of the XEdit element tree and always exists.
        /// </summary>
        public static Handle BaseHandle = new Handle(0);

        /// <summary>
        /// Initializes a new instance of the <see cref="Handle"/> class.
        /// </summary>
        /// <param name="h">The handle's value.</param>
        public Handle(UInt32 h)
        {
            Value = h;
        }

        /// <summary>
        /// Gets the internal handle value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public UInt32 Value { get; }

        /// <summary>
        /// Releases the XEditLib internal handle associated with this Handle.
        /// You cannot use this handle after calling this function.
        /// </summary>
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

        /// <summary>
        /// Performs an implicit conversion from <see cref="Handle"/> to <see cref="UInt32"/>.
        /// </summary>
        /// <param name="h">The handle.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator UInt32(Handle h)
        {
            return h.Value;
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="UInt32"/> to <see cref="Handle"/>.
        /// </summary>
        /// <param name="u">The handle value.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        public static implicit operator Handle(UInt32 u)
        {
            return new Handle(u);
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>
        /// A hash code for the current object.
        /// </returns>
        public override Int32 GetHashCode()
        {
            return Value.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>
        ///   <see langword="true" /> if the specified object  is equal to the current object; otherwise, <see langword="false" />.
        /// </returns>
        public override Boolean Equals(Object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Handle) obj);
        }


        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override String ToString()
        {
            return $"Handle({Value})";
        }

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// Compares the internal handle value.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.
        /// </returns>
        public Boolean Equals(Handle other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value == other.Value;
        }
    }
}