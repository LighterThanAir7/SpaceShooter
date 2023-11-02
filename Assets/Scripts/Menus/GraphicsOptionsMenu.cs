using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicsOptionsMenu : Menu
{
    public static GraphicsOptionsMenu instance = null;

    private void Start()
    {
        if (instance)
        {
            Debug.LogError("Trying to create more than one GraphicsOptionsMenu!");
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    public void OnFullscreenButton()
    {
        
    }

    public void OnV_SyncButton()
    {

    }

    public void OnApplyButton()
    {

    }

    public void OnBackButton()
    {
        TurnOff(true);
    }
}
