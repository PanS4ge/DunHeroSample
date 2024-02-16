# Mod Tutorial
## C# files prepared for the MelonLoader Mod development
### dnSpy with Assembly_CSharp.cs loaded, and a https://github.com/sinai-dev/UnityExplorer mod installed is essential

## Already prepared Project
### Just load Project Files directory lol

## Self creating a Project
### Because I'm bad at making the VS ready project

- First, let's get MelonLoader installed on DunHero. This will give us the necessary DLLs.
- Now, create a new project using Class Library in C# __.NET Standard 2.1.__
We need to reference several DLLs:

- From MelonLoader/net6:
> MelonLoader.dll
> 0Harmony.dll (you'll need this for HarmonyLib)
- From DunHero_Data/Managed:
> UnityEngine.dll
> Assembly-CSharp.dll
> Unity.Netcode.Runtime.dll
> UnityEngine.CoreModule.dll
> (and any other UnityEngine DLLs you require)

- Rename Class1.cs to match your mod's name (just make sure it's different from the namespace).
- Copy Program.cs to your project folder (unfortunately, dragging and dropping directly into the IDE won't work).
- Adjust the MelonInfo variables to your preferences (don't forget to update the typeof argument to match your renamed Class1.cs).
- Copy DunUtils.cs and WhichScene.cs into your project (and remember to update the namespace/class as needed).
- Now, it's time to write your mod's code in the renamed Class1.cs!

### Every other dependencies place in the UserLibs folder in game directory

## How to use it?
### Check the Sample Functions folder, it's a pseudocode that is put together as a reference

## Any Docs
nope, it's in the progress.

DunHero is a Steam Game made by Dev Kacper
Join it's discord here: https://discord.gg/kXxh4p5cX6