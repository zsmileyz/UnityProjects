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

    void OnTriggerEnter(Collider hit)
    {
        hit.gameObject.GetComponent<Enemy>().TakeDamage(damage);
    }




}
