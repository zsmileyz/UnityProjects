using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    public float health = 10f;




    void Start ()
    {
       

    }
	

	void Update ()
    {
        Moving();
	}

    void isHit()
    {

    }


    void Moving()
    {
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
    }

    void Die()
    {
        Destroy(this);
    }

}