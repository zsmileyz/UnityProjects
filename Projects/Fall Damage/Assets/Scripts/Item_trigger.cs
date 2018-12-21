using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_trigger : MonoBehaviour
{



    void Start()
    {
        
    }


    void Update()
    {
        
    }





    private void OnTrigger(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            Destroy(other.gameObject);
            Debug.Log("FAN!");
        }

    }

}
