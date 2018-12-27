using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Umbrella : MonoBehaviour
{

    public Animator m_Animator;
    public GameObject wind;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        Action();
    }

    void Action()
    {
        if (Input.GetKey("f"))
        {
            m_Animator.SetBool("Is_Attacking", true);
            Wind();
        }
        if (Input.GetKeyUp("f"))
        {
            m_Animator.SetBool("Is_Attacking", false);
        }
    }

    void Wind()
    {
        Instantiate(wind, transform.position, Quaternion.identity);
       
        
    }

}
