using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind_Spawner : MonoBehaviour
{
    public GameObject wind;

    public float reloadTime = 5f;
    public float ammo = 4;

    bool reloading = false;

    void Start()
    {

    }


    void FixedUpdate()
    {
        StartCoroutine(Shoot());
        Action();
    }

    void Action()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (reloading != true && (ammo != 0))
            {
                Instantiate(wind, transform.position, Quaternion.identity);
                ammo -= 1f;

            }
            if (ammo == 0)
            {
                reloading = true;
            }
        }
    }

    IEnumerator Shoot()
    {
        if (reloading == true)
        {            
            yield return new WaitForSeconds(reloadTime);
            ammo = 4f;
            reloading = false;
        }
    }

}
