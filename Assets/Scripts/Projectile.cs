using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
     public float speed;
     public Character.Type owner;
     public int damage;
     private void Update()
     {
          transform.Translate(Vector3.up * (Time.deltaTime* speed), Space.Self);
     }
     

}
