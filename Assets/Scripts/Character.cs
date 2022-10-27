using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class Character : MonoBehaviour
{
    public int maxHealth;
    public int health;
    public float speed;
    public Gun gun;
    public Type type;
    public GameObject goSprite;
    public Transform moveDestination;
    public Vector2 moveDirection;
    
    public enum Type
    {
        none, player, enemy
    }

    private void Awake()
    {
        gun.owner = type;
    }

    protected void Move()
    {
        moveDirection = (moveDestination.position-transform.position).normalized;
        goSprite.transform.up = moveDirection;
        transform.position = Vector2.MoveTowards(transform.position, 
            moveDestination.position, speed * Time.deltaTime);
    }

    void UseWeapon()
    {
        gun.Shoot();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Projectile projectile = other.GetComponent<Projectile>();
        if (projectile)
        {
            HitByProjectile(projectile);
        }
    }

    void HitByProjectile(Projectile projectile)
    {
        if(projectile.owner == type)
            return;
        
        health -= projectile.damage;

        if (health <= 0)
        {
            Death();
        }
        
        Destroy(projectile.gameObject);
    }

    protected virtual void Death()
    {
        
    }
}
