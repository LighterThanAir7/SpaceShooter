using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    public GameObject gameManagerPrefab = null;

    public enum GameMode
    {
        INVALID,
        Menus,
        Gameplay
    }

    public GameMode gameMode;

    private bool menuLoaded = false;

    void Start()
    {
        if (GameManager.instance == null)
        {
            if (gameManagerPrefab)
                Instantiate(gameManagerPrefab);
            else
                Debug.LogError("gameManagerPrefab isn't set");
        }
    }

    void Update()
    {
        if (!menuLoaded)
        {
            switch (gameMode)
            {
                case GameMode.Menus:
                    MenuManager.instance.SwitchToMainMenuMenus();
                    break;
                case GameMode.Gameplay:
                    MenuManager.instance.SwitchToGameplayMenus();
                    break;
            };
            menuLoaded = true;
        }
    }
}
