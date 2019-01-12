using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass_Spawner : MonoBehaviour
{
    public float spawnee = 5;

    public GameObject monster;


    void Start()
    {
        Spawn();
    }

    void Update()
    {
        
    }

    void Spawn()
    {
        Instantiate(monster, transform.position, Quaternion.identity);
    }

}
