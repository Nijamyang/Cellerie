using UnityEngine;

public class Enemy : Character
{
    private void Awake()
    {
        moveDestination = GameManager.Instance.player.transform;
    }

    protected override void Death()
    {
        base.Death();
        Destroy(gameObject);
    }
    
    void Update()
    {
        Move();
    }
}
