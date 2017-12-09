using System;
using XeLib;
using XeLib.API;

namespace ExampleApp
{
    class PrintIronGauntlets
    {
        private static void PrintNodes(Handle baseHandle, HandleGroup g)
        {
            var defNames = Elements.GetDefNames(baseHandle);
            var virtualNodes = g.AddHandle(Records.GetNodes(baseHandle));
            var elementArray = g.AddHandles(Records.GetNodeElements(virtualNodes, baseHandle));
            PrintStructNodes(virtualNodes, 0, defNames, elementArray, g);
        }

        private static void PrintStructNodes(Handle virtualNodes, Int32 depth, String[] defNames, Handle[] elementArray, HandleGroup g)
        {
            for (var i = 0; i < defNames.Length; i++)
            {
                var doesntExist = elementArray[i] == 0;
                var valueType = doesntExist ? Elements.ValueTypes.VtNoValue : Elements.ValueType(elementArray[i]);
                var isFlags = valueType == Elements.ValueTypes.VtFlags;
                var canExpand = !doesntExist && !isFlags && Elements.ElementCount(elementArray[i]) > 0;
                Console.WriteLine($"{new String(' ', depth * 4)}{defNames[i]} - {valueType:G}");
                if (valueType == Elements.ValueTypes.VtFlags)
                {
                    Console.WriteLine(
                        $"{new String(' ', depth * 4)}{defNames[i]} type is : {Elements.DefType(elementArray[i]):G} and value is : {String.Join(", ", ElementValues.GetEnabledFlags(elementArray[i]))}");
                    Console.WriteLine(
                        $"{new String(' ', depth * 4)}All possible flag values are : {String.Join(", ", ElementValues.GetAllFlags(elementArray[i]))}");
                }
                else if (!canExpand && !doesntExist)
                    Console.WriteLine(
                        $"{new String(' ', depth * 4)}{defNames[i]} type is: {Elements.DefType(elementArray[i]):G} and value is : {ElementValues.GetValue(elementArray[i])}");
                else if (canExpand)
                {
                    var expandDefNames = Elements.GetDefNames(elementArray[i]);
                    var expandElementArray = g.AddHandles(Records.GetNodeElements(virtualNodes, elementArray[i]));
                    if (valueType == Elements.ValueTypes.VtArray)
                        PrintArrayNodes(virtualNodes, depth + 1, expandDefNames, expandElementArray, g);
                    else
                        PrintStructNodes(virtualNodes, depth + 1, expandDefNames, expandElementArray, g);
                }
            }
        }

        private static void PrintArrayNodes(Handle virtualNodes, Int32 depth, String[] defNames, Handle[] elementArray, HandleGroup g)
        {
            foreach (var t in elementArray)
            {
                var doesntExist = t == 0;
                var valueType = doesntExist ? Elements.ValueTypes.VtNoValue : Elements.ValueType(t);
                var isFlags = valueType == Elements.ValueTypes.VtFlags;
                var canExpand = !doesntExist && !isFlags && Elements.ElementCount(t) > 0;
                Console.WriteLine($"{new String(' ', depth * 4)}{defNames[0]} - {valueType:G}");
                if (valueType == Elements.ValueTypes.VtFlags)
                {
                    Console.WriteLine(
                        $"{new String(' ', depth * 4)}{defNames[0]} type is : {Elements.DefType(t):G} and value is : {String.Join(", ", ElementValues.GetEnabledFlags(t))}");
                    Console.WriteLine(
                        $"{new String(' ', depth * 4)}All possible flag values are : {String.Join(", ", ElementValues.GetAllFlags(t))}");
                }
                else if (!canExpand && !doesntExist)
                    Console.WriteLine(
                        $"{new String(' ', depth * 4)}{defNames[0]} type is : {Elements.DefType(t):G} and value is : {ElementValues.GetValue(t)}");
                else if (canExpand)
                {
                    var expandDefNames = Elements.GetDefNames(t);
                    var expandElementArray = g.AddHandles(Records.GetNodeElements(virtualNodes, t));
                    if (valueType == Elements.ValueTypes.VtArray)
                        PrintArrayNodes(virtualNodes, depth + 1, expandDefNames, expandElementArray, g);
                    else
                        PrintStructNodes(virtualNodes, depth + 1, expandDefNames, expandElementArray, g);
                }
            }
        }

        public static void Main()
        {
            try
            {
                Console.WriteLine("Initializing XEditLib");
                Meta.Initialize();
                Console.WriteLine("Setting game mode to Skyrim SE");
                Setup.SetGameMode(Setup.GameMode.GmSse);
                Console.WriteLine("Loading plugins Skyrim.esm & Update.esm");
                Setup.LoadPlugins("Skyrim.esm\nUpdate.esm");
                Console.WriteLine("Waiting for loader to finish");
                var state = Setup.LoaderState.IsInactive;
                while (state != Setup.LoaderState.IsDone && state != Setup.LoaderState.IsError)
                    state = Setup.GetLoaderStatus();
                Console.WriteLine("Loader finished, printing XEditLib output");
                Console.WriteLine(Messages.GetMessages());
                Messages.ClearMessages();
                Console.WriteLine("Printing info on Iron Gauntlets");
                using (var g = new HandleGroup())
                {
                    Console.WriteLine("Printing all nodes from the Form ID 00012E46 in Skyrim.esm");
                    var armorIronGauntlets = Elements.GetElement(Handle.BaseHandle, "Skyrim.esm\\00012E46");
                    var isOverride = Records.IsOverride(armorIronGauntlets);
                    Console.WriteLine($"Record is override: {isOverride}");
                    if (isOverride)
                    {
                        var master = g.AddHandle(Records.GetMasterRecord(armorIronGauntlets));
                        var masterFile = g.AddHandle(Elements.GetElementFile(master));
                        var masterFileName = FileValues.GetFileName(masterFile);
                        Console.WriteLine($"Record overrides master from {masterFileName}");
                    }
                    PrintNodes(armorIronGauntlets, g);
                }
            }
            catch (XeLibException e)
            {
                Console.WriteLine("XEditLib threw an exception");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
