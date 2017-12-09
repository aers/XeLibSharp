using System;

namespace XeLib.API
{
    public static class RecordValues
    {
        public static String GetEditorId(Handle handle)
        {
            return ElementValues.GetValue(handle, "EDID");
        }

        public static String GetFullName(Handle handle)
        {
            return ElementValues.GetValue(handle, "FULL");
        }

        public static void Translate(Handle handle, Double x = 0, Double y = 0, Double z = 0)
        {
            var position = Elements.GetElement(handle, @"DATA\Position");
            ElementValues.SetFloatValue(position, "X", ElementValues.GetFloatValue(position, "X") + x);
            ElementValues.SetFloatValue(position, "Y", ElementValues.GetFloatValue(position, "Y") + y);
            ElementValues.SetFloatValue(position, "Z", ElementValues.GetFloatValue(position, "Z") + z);
        }

        public static void Rotate(Handle handle, Double x = 0, Double y = 0, Double z = 0)
        {
            var rotation = Elements.GetElement(handle, @"DATA\Rotation");
            ElementValues.SetFloatValue(rotation, "X", ElementValues.GetFloatValue(rotation, "X") + x);
            ElementValues.SetFloatValue(rotation, "Y", ElementValues.GetFloatValue(rotation, "Y") + y);
            ElementValues.SetFloatValue(rotation, "Z", ElementValues.GetFloatValue(rotation, "Z") + z);
        }

        public static Boolean GetRecordFlag(Handle handle, String name)
        {
            return ElementValues.GetFlag(handle, @"Record Header\Record Flags", name);
        }

        public static void SetRecordFlag(Handle handle, String name, Boolean state)
        {
            ElementValues.SetFlag(handle, @"Record Header\Record Flags", name, state);
        }
    }
}