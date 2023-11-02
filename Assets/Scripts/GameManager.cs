using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public bool twoPlayer = false;
    
    void Start()
    {
        // If already exists, don't create
        if (instance)
        {
            Debug.LogError("Trying to create another instance of GameManager, while it already exists!");
            Destroy(gameObject);
            return;
        }

        // Doesn't exist
        instance = this;
        DontDestroyOnLoad(gameObject);
        Debug.Log("GameManager Created.");
    }
}