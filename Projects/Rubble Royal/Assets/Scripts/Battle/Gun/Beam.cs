﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    public float speed = 5f;


    public GameObject player_1;

    public float force = 5f;

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

    
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("hit!");

            //addforce

            Destroy(gameObject);
        }
    }
}
