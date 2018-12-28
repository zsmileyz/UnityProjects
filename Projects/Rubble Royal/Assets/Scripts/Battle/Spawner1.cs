using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{

    public GameObject gun;
    public float time = 5f;

    void Start()
    {
        StartCoroutine(Drop());
    }

    void Update()
    {
        
    }

    void Gun()
    {
        Instantiate(gun,transform.position,Quaternion.identity);
    }

    IEnumerator Drop()
    {
        yield return new WaitForSeconds(time);
        Gun();
        Debug.Log("drop!");
    }
}
