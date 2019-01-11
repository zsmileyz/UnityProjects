using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class Player_1_Controller : MonoBehaviour
{
    public float speed = 5;

    //public GameObject esc_Menu;

    public bool is_Dead = false;


    void Start()
    {
        
    }


    void Update()
    {
        Controller();
        
    }





    void Controller()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        if (Input.GetKey("space"))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 10;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5;
        }
    }






}
