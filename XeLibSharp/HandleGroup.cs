using System;
using System.Collections.Generic;

namespace XeLib
{
    public class HandleGroup : IDisposable
    {
        public HandleGroup()
        {
            Values = new HashSet<Handle>();
        }

        public HandleGroup(Handle[] array)
        {
            Values = new HashSet<Handle>(array);
        }

        public HashSet<Handle> Values { get; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(Boolean disposing)
        {
            if (!disposing) return;
            foreach (var h in Values)
                h.Dispose();
        }

        public Handle AddHandle(Handle h)
        {
            Values.Add(h);
            return h;
        }

        public void RemoveHandle(Handle h)
        {
            Values.Remove(h);
        }

        public Handle[] AddHandles(Handle[] array)
        {
            Values.UnionWith(array);
            return array;
        }

        public void RemoveHandles(Handle[] array)
        {
            Values.ExceptWith(array);
        }

        public override String ToString()
        {
            return $"HandleGroup({String.Join(", ", Values)})";
        }
    }
}