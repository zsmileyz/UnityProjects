using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public static float health = 3;
    public bool isDead = false;
    public bool damaged = false;


    private void Awake()
    {

    }


    void Start ()
    {
        
	}
	

	void Update ()
    {
        Controller();
        Die();
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



    void Die()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
        
    }


}

