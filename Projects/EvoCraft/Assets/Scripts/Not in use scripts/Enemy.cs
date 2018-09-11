using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    public float damage = 10f;

    public float health = 1f;




    void Start ()
    {
       

    }
	

	void Update ()
    {
        Moving();
	}



    void Moving()
    {
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        
    }

    private void OnTriggerEnter(Collider hit)
    {
        if(hit.tag == "laser")
        {
            health -= 1f;
            if(health <= 0)
            {
                Die();
            }
        }
    }

    IEnumerable Die()
    {
        yield return new WaitForSeconds(1f);

        Destroy(gameObject);
        Debug.Log("DEAD");
    }

}