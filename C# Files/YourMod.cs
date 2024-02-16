using Dunhero;
using Dunhero.Creatures;
using Dunhero.DevelopmentTools;
using MelonLoader;
using System;
using UnityEngine;

namespace SampleMod
{
    public class YourMod : MelonMod
    {
        // Refer to: https://melonwiki.xyz/#/modders/quickstart?id=melon-callbacks
        public override void OnInitializeMelon()
        {
            // From this file ONLY!
            LoggerInstance.Msg("Hello World from Main File");
            // From every file!
            Melon<Krnl>.Logger.Msg("Hello World from Any File!");
        }

        // LEAVE THIS VARIABLE
        public WhichScene whichScene = WhichScene.MAIN_MENU;

        public override void OnFixedUpdate()
        {
            
        }

        // Check the scene

        // Don't change.
        public string MainMenuName = "MainMenu";
        public string LoadingSceneName = "Loading Scene";
        public string MainGameplayName = "MainGameplay";

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            // LEAVE THOSE IF'S, or change to switch-case idc, just leave it present
            if(sceneName == MainMenuName) {
                whichScene = WhichScene.MAIN_MENU;
            } else if(sceneName == LoadingSceneName) {
                whichScene = WhichScene.LOADING_SCREEN;
            } else if(sceneName == MainGameplayName) {
                whichScene = WhichScene.MAIN_GAMEPLAY;
            } else {
                whichScene = WhichScene.SOME_OTHER;
            }
        }
    }
}
