using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind_Spawner : MonoBehaviour
{

    public GameObject wind;
    public float coolDownPeriodInSeconds = 10;
    private float timeStamp;

    void Start()
    {
        timeStamp = Time.time + coolDownPeriodInSeconds;
    }


    void Update()
    {
        Wind();
    }

    void Wind()
    {
        if (timeStamp <= Time.time)
        {
            if (Input.GetKey("f"))
            {
                Instantiate(wind, transform.position, Quaternion.identity);

            }
        }
    }

}
