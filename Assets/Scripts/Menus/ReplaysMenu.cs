using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaysMenu : Menu
{
    public static ReplaysMenu instance = null;

    private void Start()
    {
        if (instance)
        {
            Debug.LogError("Trying to create more than one ReplaysMenu!");
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    // TODO: implement replay system and actual values

    public void OnBackButton()
    {
        TurnOff(true);
    }
}

