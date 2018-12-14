using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Spawner_2 : MonoBehaviour
{

    public GameObject gun;

    // Start is called before the first frame update
    void Start()
    {
        Spawner();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawner()
    {
        Instantiate(gun, transform.position, Quaternion.identity);
    }
}
