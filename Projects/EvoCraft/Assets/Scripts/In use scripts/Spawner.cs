using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawner;

    public GameObject spawnee;

    


    void Start()
    {
        GameObject enemyShip = Instantiate(spawnee, transform.position, Quaternion.identity);
        Destroy(enemyShip, 4f);

    }

    private void FixedUpdate()
    {

    }
}
