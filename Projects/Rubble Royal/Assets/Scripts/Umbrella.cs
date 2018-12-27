using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Umbrella : MonoBehaviour
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
            m_Animator.SetBool("Is_Attacking", true);
        }
        if (Input.GetKeyUp("f"))
        {
            m_Animator.SetBool("Is_Attacking", false);
        }
    }

}
