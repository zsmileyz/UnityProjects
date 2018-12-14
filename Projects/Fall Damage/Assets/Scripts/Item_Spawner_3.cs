using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Spawner_3 : MonoBehaviour
{

    public GameObject umbrella;

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
        Instantiate(umbrella, transform.position, Quaternion.identity);
    }

}
