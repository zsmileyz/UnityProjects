using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float speed = 10f;



    public float damage = 10f;



	void Start ()
    {
 
	}
	

	void Update ()
    {
        Moving();
      
    }


    void Moving()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
    }

    private void OnTriggerEnter(Collider hit)
    {
        if(hit.tag == "Enemy")
        {
            Debug.Log("HitEnemy!!");
        }
            
        
    }




}
