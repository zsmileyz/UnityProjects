using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    public float health = 10;




    void Start ()
    {
       

    }
	

	void Update ()
    {
        Moving();
        EnemyHealth();
	}

    void EnemyHealth()
    {
       if (health <= 0)
        {
            Destroy(this);
        }

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
        health = -amount;
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(this);
    }

}