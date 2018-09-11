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
	

	void FixedUpdate ()
    {
        Moving();
        StartCoroutine("Die");
    }



    void Moving()
    {
        if(health != 0)
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }        
        if(health <= 0)
        {
            transform.Translate(5f * Time.deltaTime, -1f * Time.deltaTime, 0f);
        }
        
    }

    private void OnTriggerEnter(Collider hit)
    {
        if(hit.tag == "laser")
        {
            health -= 1f;
            
        }
    }
   
    IEnumerator Die()
    {
        if (health <= 0)
        {

            yield return new WaitForSeconds(1f);
            Destroy(gameObject);
            Debug.Log("DEAD");
        }
    }

}