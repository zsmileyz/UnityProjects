using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Firing : MonoBehaviour
{
    public GameObject beam;
    private float cooldown = 0;
    private const float ShootInterval = 0f;

    void Start()
    {
        
    }


    void Update()
    {
        Shoot();
        cooldown -= Time.deltaTime;
    }

    void Action()
    {
        if(Input.GetKeyDown("f"))
        {
            Instantiate(beam, transform.position, Quaternion.identity);
        }
    }

    void Shoot()
    {
        if (cooldown > 0)
            return;

        Action();
        cooldown = ShootInterval;
    }
}
