using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;


	void Start ()
    {
		
	}
	

	void Update ()
    {
        Controller();      
    }

        void Controller()
        {
         if (Input.GetKey("d"))
         {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
         }

         if (Input.GetKey("a"))
         {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
         }

         if (Input.GetKey("w"))
         {
            transform.Translate(0f,speed * Time.deltaTime, 0f);
         }

         if (Input.GetKey("s"))
         {
            transform.Translate(0f, -speed * Time.deltaTime, 0f);
         }
        }
    

    







}
