// Activating Useless Dev Console (Yet to be patched)
public override void OnFixedUpdate()
{
    // Remember about this IF statement (all of the managers are only on MainGameplay)
    if (whichScene != WhichScene.MAIN_GAMEPLAY) return;
    // Check above
  
    CheatManager? cheatManager = DunUtils.GetCheatManager();
    if (cheatManager == null) return;
    DunUtils.SetPrivateVariable<CheatManager, bool>(typeof(CheatManager), cheatManager, "_isActive", true);
    GameObject? consoleObject = (GameObject?)DunUtils.GetPrivateVariable<CheatManager>(typeof(CheatManager), cheatManager, "_consoleObject");
    if(consoleObject == null) return;
    consoleObject.SetActive(true);
}



// 1 HP Challenge
public override void OnFixedUpdate()
{
    // Remember about this IF statement (all of the managers are only on MainGameplay)
    if (whichScene != WhichScene.MAIN_GAMEPLAY) return;
    // Check above
  
    GameManager? gameManager = DunUtils.GetGameManager();
    if (gameManager == null) return;
    foreach(Player p in gameManager.Players)
    {
        p.HealthSystem.SetHealth(1);
        p.HealthSystem.ChangeMaxHealth(1);
    }
}
