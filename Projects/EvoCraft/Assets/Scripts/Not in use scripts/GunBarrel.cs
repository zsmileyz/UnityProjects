using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBarrel : MonoBehaviour
{
    public GameObject spawnee;

    public float nextFire;

    public float fireRate = 1f;

    


	void Start ()
    {
		
	}
	

	void Update ()
    {
        Shooting();

    }

    void Shooting()
    {
        if(Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject Shot = Instantiate(spawnee, transform.position, Quaternion.identity);

            Destroy(Shot, 4f);
        }



    }

    private void OnTriggerEnter(Collider hit)
    {
        if(hit.gameObject.tag == "Enemy")
        {
            Player.health -= 1f;
            Debug.Log("HitPlayer");
        }
    }
}
