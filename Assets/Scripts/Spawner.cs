using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject preEnemy;
    void Start()
    {
        InvokeRepeating("Spawn",3,3);
    }

    void Spawn()
    {
        Instantiate(preEnemy, RandomPosition(), Quaternion.identity);
    }

    Vector2 RandomPosition()
    {
        Vector2 randomPos = Vector2.zero;
        //random right, left, top, down
        int direction = Random.Range(0, 3);
        const float distanceToCameraBorder = 0.1f;
        switch (direction)
        {
            case 0:
                //right
                randomPos = new Vector2(1 + distanceToCameraBorder, Random.Range(0, 1));
                break;
            case 1:
                //left
                randomPos = new Vector2(0 - distanceToCameraBorder, Random.Range(0, 1));
                break;
            case 2:
                //top
                randomPos = new Vector2(Random.Range(0, 1), 1 + distanceToCameraBorder);
                break;
            case 3:
                //down
                randomPos = new Vector2(Random.Range(0, 1), 0 - distanceToCameraBorder);
                break;
        }
        return Camera.main.ViewportToWorldPoint(randomPos);
    }
}
