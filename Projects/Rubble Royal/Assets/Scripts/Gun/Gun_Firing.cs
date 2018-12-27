using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Firing : MonoBehaviour
{

    public GameObject beam;

    void Start()
    {
        
    }


    void Update()
    {
        Action();
    }

    void Action()
    {
        if(Input.GetKey("f"))
        {
            Firing();
        }
    }

    void Firing()
    {
        Instantiate(beam, transform.position, Quaternion.identity);
    }
}
