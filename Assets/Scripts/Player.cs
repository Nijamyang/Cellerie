using System;
using UnityEngine;

public class Player : Character
{
    private void Awake()
    {
        type = Type.player;
        moveDestination = Camera.main.transform;
        
    }

    private void Start()
    {
        GameManager.Instance.uiController.canvasGame.lifeBar.Initialize(maxHealth);
    }

    void Update()
    {
        Move();
    }
}
