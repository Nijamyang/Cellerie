using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject preProjectile;
    public Character.Type owner;

    public void Start()
    {
        InvokeRepeating("Shoot",0.5f,0.5f);
    }

    public void Shoot()
    {
        GameObject goProjectile = Instantiate(preProjectile,transform.position, transform.rotation);
        goProjectile.GetComponent<Projectile>().owner = owner;
    }
}
