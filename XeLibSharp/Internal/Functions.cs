using System;
using System.Runtime.InteropServices;

namespace XeLib.Internal
{
    /// <summary>
    /// This is the base definition for the Functions class.
    /// The functions of the dll are linked in other partial classes.
    /// Files containing the functions are grouped by category (e.g. Files for 
    /// functions handling files)
    /// </summary>
    internal static partial class Functions
    {
        private const String DllPath = @"XEditLib.dll";
    }
}