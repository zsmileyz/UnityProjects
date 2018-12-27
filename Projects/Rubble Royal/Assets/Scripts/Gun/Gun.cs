using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public Animator m_Animator;

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
        if (Input.GetKeyDown("f"))
        {
            m_Animator.SetBool("If_Firing", true);
        }
        if (Input.GetKeyUp("f"))
        {
            m_Animator.SetBool("If_Firing", false);
        }
    }

}
