using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawner;

    public GameObject spawnee;

    //public float spawnTimer;


    void Start()
    {

            Instantiate(spawnee, transform.position, Quaternion.identity);

    }

	  void Update ()
    {

	}
}
