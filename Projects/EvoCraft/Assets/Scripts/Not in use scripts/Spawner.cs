using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawner;

    public GameObject spawnee;

    public float spawnTimer = 5f;
    public float spawnDelay = 5f;



    void Start()
    {
        spawn();
        invoke();


    }

    private void FixedUpdate()
    {
        
    }

    void spawn()
    {
        GameObject enemyShip = Instantiate(spawnee, transform.position, Quaternion.identity);
        Destroy(enemyShip, 4f);       
    }

    void invoke()
    {
        InvokeRepeating("spawn", spawnTimer, spawnDelay);
    }
}
