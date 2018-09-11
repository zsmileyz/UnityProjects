using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float health = 3;
    public bool isDead = false;
    public bool damaged = false;



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

    private void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Enemy")
        {
            health -= 1f;
            Debug.Log("hit");
        }
        if (health <= 0)
        {
            Die();
            Debug.Log("DEAD!");
        }
    }

    
    void Die()
    {
        Destroy(gameObject);
    }


}

