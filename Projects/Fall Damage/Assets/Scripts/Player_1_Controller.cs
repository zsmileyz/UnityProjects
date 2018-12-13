using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1_Controller : MonoBehaviour 
{

    public float speed = 5f;

	void Start () 
	{
		
	}
	
	void Update () 
	{
        Controller();
	}

    void Controller()
    {
        if (Input.GetKey("l"))
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey("j"))
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey("i"))
        {
            transform.Translate(0f, speed * Time.deltaTime, 0f);
        }

        if (Input.GetKey("k"))
        {
            transform.Translate(0f, -speed * Time.deltaTime, 0f);
        }
    }

}
