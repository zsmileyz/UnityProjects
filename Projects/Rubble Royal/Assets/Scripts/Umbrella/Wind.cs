using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{

    public float speed = 5f;

    void Start()
    {
        
    }


    void Update()
    {
        StartCoroutine(End());
        Attack();
    }

    void Attack()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }


    IEnumerator End()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

}
