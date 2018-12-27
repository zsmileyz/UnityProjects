using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject umbrella;
    public float time = 5f;

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
        yield return new WaitForSeconds(time);
        Umbrella();
        Debug.Log("drop!");
    }
}
