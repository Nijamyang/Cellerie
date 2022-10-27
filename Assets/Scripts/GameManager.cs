using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [HideInInspector] public static GameManager Instance { get; private set; }
    
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        else if (this != Instance)
        {
            Destroy(gameObject);
        }
        
        DontDestroyOnLoad(this);
    }

    public UiController uiController;
    public Player player;
}
