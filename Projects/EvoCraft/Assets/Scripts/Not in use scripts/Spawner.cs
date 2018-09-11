using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawner;

    public GameObject spawnee;

    public float spawnerTimer;


    void Start()
    {
        StartCoroutine(spawn());


    }

    private void FixedUpdate()
    {
        
    }

    IEnumerator spawn()
    {
        yield return new WaitForSeconds(spawnerTimer);


        GameObject enemyShip = Instantiate(spawnee, transform.position, Quaternion.identity);
        Destroy(enemyShip, 4f);

        
    }
}
