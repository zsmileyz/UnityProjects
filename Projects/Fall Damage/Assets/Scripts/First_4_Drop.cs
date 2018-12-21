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
        Debug.Log("test");
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
        Debug.Log("death cube");
    }

    void Drop()
    {
        transform.Translate(0f, -speed * Time.deltaTime, 0f);
    }

}
