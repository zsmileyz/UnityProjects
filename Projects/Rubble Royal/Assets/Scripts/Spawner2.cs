using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject umbrella;

    void Start()
    {
        StartCoroutine(Drop());
    }

    void Update()
    {

    }

    void Umbrella()
    {
        Instantiate(umbrella, transform.position, Quaternion.identity);
    }

    IEnumerator Drop()
    {
        yield return new WaitForSeconds(5);
        Umbrella();
        Debug.Log("drop!");
    }
}
