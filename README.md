# XeLibSharp
Quick C# port of mator's Javascript wrapper [xelib](https://github.com/matortheeternal/xelib) for [xedit-lib](https://github.com/matortheeternal/xedit-lib) for my own use. Has all the same methods implemented.

The original xelib throws exceptions when xedit-lib returns exceptions; this library does the same for now, but probably won't forever.

## Docs
There's no documentation yet (possibly ever), but zedit has xelib docs [here](https://github.com/matortheeternal/zedit/tree/master/app/docs/development/apis/xelib) if you want more detail on what a specific method does.

## Usage

The same example from xelib:

```cs
using XeLib;
using XeLib.API;

// Initialize XEditLib
Meta.Initialize();
// Set game mode to Skyrim SE
Setup.SetGameMode(Setup.GameMode.SSE);
// Load plugins seperated by newlines
Setup.LoadPlugins("Skyrim.esm\nUpdate.esm");
// Wait on loader
var state = Setup.GetLoaderStatus();
while (state != Setup.LoaderState.IsDone && state != Setup.LoaderState.HasError)
    state = Setup.GetLoaderStatus();

// Get an element
// In this case we're passing the base handle (0), which represents the top of XEditLib's element tree.
// This returns a handle to the Iron Gauntlets armor record with form ID 00012E46
var armorIronGauntlets = Elements.GetElement(Handle.BaseHandle, "Skyrim.esm\\00012E46");

// Get the value of the "FULL" element inside the Iron Gauntlets record.
var fullName = ElementValues.GetValue(armorIronGauntlets, "FULL");

// Prints "Iron Gauntlets"
Console.WriteLine(fullName);
```

There's a more complicated example app in the ExampleApp project.