using System;
using System.Globalization;

namespace XeLib.API
{
    public static class Common
    {
        public static Boolean HasKeyword(Handle handle, String value)
        {
            return Elements.HasArrayItem(handle, "Keywords", "", value);
        }

        public static void AddKeyword(Handle handle, String value)
        {
            Elements.AddArrayItem(handle, "Keywords", "", value);
        }

        public static void RemoveKeyword(Handle handle, String value)
        {
            Elements.RemoveArrayItem(handle, "Keywords", "", value);
        }

        public static Boolean HasFormId(Handle handle, String value)
        {
            return Elements.HasArrayItem(handle, "FormIDs", "", value);
        }

        public static void AddFormId(Handle handle, String value)
        {
            Elements.AddArrayItem(handle, "FormIDs", "", value);
        }

        public static void RemoveFormId(Handle handle, String value)
        {
            Elements.RemoveArrayItem(handle, "FormIDs", "", value);
        }

        public static Boolean HasMusicTrack(Handle handle, String value)
        {
            return Elements.HasArrayItem(handle, "Music Tracks", "", value);
        }

        public static void AddMusicTrack(Handle handle, String value)
        {
            Elements.AddArrayItem(handle, "Music Tracks", "", value);
        }

        public static void RemoveMusicTrack(Handle handle, String value)
        {
            Elements.RemoveArrayItem(handle, "Music Tracks", "", value);
        }

        public static Boolean HasFootstep(Handle handle, String value)
        {
            return Elements.HasArrayItem(handle, "Footstep Sets", "", value);
        }

        public static void AddFootstep(Handle handle, String value)
        {
            Elements.AddArrayItem(handle, "Footstep Sets", "", value);
        }

        public static void RemoveFootstep(Handle handle, String value)
        {
            Elements.RemoveArrayItem(handle, "Footstep Sets", "", value);
        }

        public static Boolean HasAdditionalRace(Handle handle, String value)
        {
            return Elements.HasArrayItem(handle, "Additional Races", "", value);
        }

        public static void AddAdditionalRace(Handle handle, String value)
        {
            Elements.AddArrayItem(handle, "Additional Races", "", value);
        }

        public static void RemoveAdditionalRace(Handle handle, String value)
        {
            Elements.RemoveArrayItem(handle, "Additional Races", "", value);
        }

        public static Boolean HasEffect(Handle handle, String value)
        {
            return Elements.HasArrayItem(handle, "Effects", "EFID - Base Effect", value);
        }

        public static Handle GetEffect(Handle handle, String value)
        {
            return Elements.GetArrayItem(handle, "Effects", "EFID - Base Effect", value);
        }

        public static void AddEffect(Handle handle, String value, String magnitude, String area, String duration)
        {
            var newItem = Elements.AddArrayItem(handle, "Effects", "EFID - Base Effect", value);
            ElementValues.SetValue(newItem, @"EFIT\Magnitude", magnitude);
            ElementValues.SetValue(newItem, @"EFIT\Area", area);
            ElementValues.SetValue(newItem, @"EFIT\Duration", duration);
        }

        public static void RemoveEffect(Handle handle, String value)
        {
            Elements.RemoveArrayItem(handle, "Effects", "EFID - Base Effect", value);
        }

        public static Boolean HasItem(Handle handle, String value)
        {
            return Elements.HasArrayItem(handle, "Items", @"CNTO\Item", value);
        }

        public static Handle GetItem(Handle handle, String value)
        {
            return Elements.GetArrayItem(handle, "Items", @"CNTO\Item", value);
        }

        public static void AddItem(Handle handle, String value, String count)
        {
            var newItem = Elements.AddArrayItem(handle, "Items", @"CNTO\Item", value);
            ElementValues.SetValue(newItem, @"CNTO\Count", count);
        }

        public static void RemoveItem(Handle handle, String value)
        {
            Elements.RemoveArrayItem(handle, "Items", @"CNTO\Item", value);
        }

        public static Boolean HasLeveledEntry(Handle handle, String value)
        {
            return Elements.HasArrayItem(handle, "Leveled List Entries", @"LVLO\Reference", value);
        }

        public static Handle GetLeveledEntry(Handle handle, String value)
        {
            return Elements.GetArrayItem(handle, "Leveled List Entries", @"LVLO\Reference", value);
        }

        public static void AddLeveledEntry(Handle handle, String value, String level, String count)
        {
            var newItem = Elements.AddArrayItem(handle, "Leveled List Entries", @"LVLO\Reference", value);
            ElementValues.SetValue(newItem, @"LVLO\Level", level);
            ElementValues.SetValue(newItem, @"LVLO\Count", count);
        }

        public static void RemoveLeveledEntry(Handle handle, String value)
        {
            Elements.RemoveArrayItem(handle, "Leveled List Entries", @"LVLO\Reference", value);
        }

        public static Boolean HasScript(Handle handle, String value)
        {
            return Elements.HasArrayItem(handle, @"VMAD\Scripts", "scriptName", value);
        }

        public static Handle GetScript(Handle handle, String value)
        {
            return Elements.GetArrayItem(handle, @"VMAD\Scripts", "scriptName", value);
        }

        public static void AddScript(Handle handle, String value, String name)
        {
            var newItem = Elements.AddArrayItem(handle, @"VMAD\Scripts", "scriptName", value);
            ElementValues.SetValue(newItem, "Flags", name);
        }

        public static void RemoveScript(Handle handle, String value)
        {
            Elements.RemoveArrayItem(handle, @"VMAD\Scripts", "scriptName", value);
        }

        public static Boolean HasScriptProperty(Handle handle, String value)
        {
            return Elements.HasArrayItem(handle, "Properties", "propertyName", value);
        }

        public static Handle GetScriptProperty(Handle handle, String value)
        {
            return Elements.GetArrayItem(handle, "Properties", "propertyName", value);
        }

        public static void AddScriptProperty(Handle handle, String value, String type, String flags)
        {
            var newItem = Elements.AddArrayItem(handle, "Properties", "propertyName", value);
            ElementValues.SetValue(newItem, "Type", type);
            ElementValues.SetValue(newItem, "Flags", flags);
        }

        public static void RemoveScriptProperty(Handle handle, String value)
        {
            Elements.RemoveArrayItem(handle, "Properties", "propertyName", value);
        }

        public static Boolean HasCondition(Handle handle, String value)
        {
            return Elements.HasArrayItem(handle, "Conditions", @"CTDA\Function", value);
        }

        public static Handle GetCondition(Handle handle, String value)
        {
            return Elements.GetArrayItem(handle, "Conditions", @"CTDA\Function", value);
        }

        public static void AddCondition(Handle handle, String value, String type, String comparisonValue,
            String parameterOne)
        {
            var newItem = Elements.AddArrayItem(handle, "Conditions", @"CTDA\Function", value);
            ElementValues.SetValue(newItem, @"CTDA\Type", type);
            ElementValues.SetValue(newItem, @"CTDA\Comparison Value", comparisonValue);
            ElementValues.SetValue(newItem, @"CTDA\Parameter #1", parameterOne);
        }

        public static void RemoveCondition(Handle handle, String value)
        {
            Elements.RemoveArrayItem(handle, "Conditions", @"CTDA\Function", value);
        }

        public static Double GetGoldValue(Handle handle)
        {
            return Double.Parse(ElementValues.GetValue(handle, @"DATA\Value"));
        }

        public static void SetGoldValue(Handle handle, Double value)
        {
            ElementValues.SetValue(handle, @"DATA\Value", value.ToString(CultureInfo.InvariantCulture));
        }

        public static Double GetWeight(Handle handle)
        {
            return Double.Parse(ElementValues.GetValue(handle, @"DATA\Weight"));
        }

        public static void SetWeight(Handle handle, Double value)
        {
            ElementValues.SetValue(handle, @"DATA\Weight", value.ToString(CultureInfo.InvariantCulture));
        }

        public static Double GetDamage(Handle handle)
        {
            return Double.Parse(ElementValues.GetValue(handle, @"DATA\Damage"));
        }

        public static void SetDamage(Handle handle, Double value)
        {
            ElementValues.SetValue(handle, @"DATA\Damage", value.ToString(CultureInfo.InvariantCulture));
        }

        public static Double GetArmorRating(Handle handle)
        {
            return Double.Parse(ElementValues.GetValue(handle, "DNAM"));
        }

        public static void SetArmorRating(Handle handle, Double value)
        {
            ElementValues.SetValue(handle, "DNAM", value.ToString(CultureInfo.InvariantCulture));
        }

        public static Boolean GetIsFemale(Handle handle)
        {
            return ElementValues.GetFlag(handle, @"ACBS\Flags", "Female");
        }

        public static void SetIsFemale(Handle handle, Boolean state)
        {
            ElementValues.SetFlag(handle, @"ACBS\Flags", "Female", state);
        }

        public static Boolean GetIsEssential(Handle handle)
        {
            return ElementValues.GetFlag(handle, @"ACBS\Flags", "Essential");
        }

        public static void SetIsEssential(Handle handle, Boolean state)
        {
            ElementValues.SetFlag(handle, @"ACBS\Flags", "Essential", state);
        }

        public static Boolean GetIsUnique(Handle handle)
        {
            return ElementValues.GetFlag(handle, @"ACBS\Flags", "Unique");
        }

        public static void SetIsUnique(Handle handle, Boolean state)
        {
            ElementValues.SetFlag(handle, @"ACBS\Flags", "Unique", state);
        }
    }
}