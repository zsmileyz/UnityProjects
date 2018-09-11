using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBarrel : MonoBehaviour
{
    public GameObject spawnee;
    float decay = 100f;

	void Start ()
    {
		
	}
	

	void Update ()
    {
        Shooting();

    }

    void Shooting()
    {
        if(Input.GetButton("Fire1"))
        {
            GameObject Shot = Instantiate(spawnee, transform.position, Quaternion.identity);
            Destroy(Shot, 4f);
        }



    }

}
