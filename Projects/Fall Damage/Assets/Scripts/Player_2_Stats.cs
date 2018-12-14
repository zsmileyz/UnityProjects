using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_Stats : MonoBehaviour 
{
    public float hitForce = 0.5f ;


	void Start () 
	{
		
	}
	
	void Update () 
	{
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pit")
        {
            Destroy(gameObject);
            Debug.Log("death");
        }
    }

}
