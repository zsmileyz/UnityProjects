using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class Player_1_Controller : MonoBehaviour
{
    public float speed = 5;

    public Camera player;

    public bool is_Dead = false;

    public GameObject pokeBall;


    void Start()
    {
        
    }


    void Update()
    {
        Controller();
        Capture();
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

    void Capture()
    {
        RaycastHit hit;      
        Ray ray = player.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, 100.0f))
        {
            if(hit.transform != null)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    Debug.Log(hit.transform.name);
                    Small_Monster smallM = hit.transform.GetComponent<Small_Monster>();
                    if (smallM != null)
                    {
                        GameObject newitem = Instantiate(pokeBall,hit.point,Quaternion.LookRotation(hit.normal));
                        smallM.CaptureChance();
                        Destroy(newitem, 5f);
                        hit.rigidbody.AddForce(-hit.normal * 30f);
                    }
                }
                
            }
        }
    }




}
