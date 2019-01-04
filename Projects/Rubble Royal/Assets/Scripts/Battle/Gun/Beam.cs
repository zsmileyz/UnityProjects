using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public float speed = 5f;

    public GameObject hit;

    public GameObject player_1;



    void Start()
    {
        
    }



    void Update()
    {
        beam();
        StartCoroutine(Blast());
    }

    void beam()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }

    IEnumerator Blast()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

    void OntriggerEnter(Collider beam)
    {
        if(beam.CompareTag("Player"))
        {
 

            Destroy(gameObject);
        }
    }
}
