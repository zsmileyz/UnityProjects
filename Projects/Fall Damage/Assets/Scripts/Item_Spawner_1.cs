using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Spawner_1 : MonoBehaviour
{

    public GameObject fan;
    

    void Start()
    {
        Spawner();
    }


    void Update()
    {
        
    }

    void Spawner()
    {
        Instantiate(fan, transform.position, Quaternion.identity);
    }

}
