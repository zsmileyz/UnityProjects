using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_4_Drop : MonoBehaviour
{

    float speed = 2;

    void Start()
    {
        
    }


    void Update()
    {
        StartCoroutine(Droptime());
    }

    IEnumerator Droptime()
    {
        yield return new WaitForSeconds(2);
        Drop();
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

    void Drop()
    {
        transform.Translate(0f, -speed * Time.deltaTime, 0f);
    }

}
