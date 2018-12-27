using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{

    public float speed = 5f;

    void Start()
    {
        
    }



    void Update()
    {
        beam();
    }

    void beam()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
