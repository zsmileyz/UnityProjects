using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour
{
    public GameObject fan;
    public float time = 5f;

    void Start()
    {
        StartCoroutine(Drop());
    }

    void Update()
    {

    }

    void Fan()
    {
        Instantiate(fan, transform.position, Quaternion.identity);
    }

    IEnumerator Drop()
    {
        yield return new WaitForSeconds(time);
        Fan();
        Debug.Log("drop!");
    }
}
