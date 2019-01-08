using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public float time = 2f;

    public int spawnee;

    public GameObject[] itemList;
    

    public bool is_Falling = false;

    void Start()
    {
        StartCoroutine(Drop());
    }

    void FixedUpdate()
    {
        spawnee = Random.Range(0, itemList.Length);
        
    }

    void Gun()
    {
        while (is_Falling == false)
        {
            
            Instantiate(itemList[spawnee], transform.position, Quaternion.identity);
            is_Falling = true;
            break;
            
        }
             
    }

    void plzWork()
    {
        is_Falling = false;
    }

    IEnumerator Drop()
    {
        yield return new WaitForSeconds(time);        
        Gun();
        yield return new WaitForSeconds(time);
        plzWork();
        StartCoroutine(Drop());



    }

    

}
