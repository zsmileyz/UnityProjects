using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Player_1_Controller : MonoBehaviour
{
    public GameObject Gun;
    public GameObject Umbrella;
    public float speed = 5;
    public GameObject esc_Menu;
    

    void Start()
    {
        
    }


    void Update()
    {
        Controller();
        
    }





    void Controller()
    {
        if (Input.GetKey("s"))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
        if (Input.GetKey("space"))
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 10;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            esc_Menu.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pit")
        {
            Destroy(gameObject);
            Debug.Log("Player1 Death!");
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Gun")
        {
            if (Input.GetKeyDown("e"))
            {
                Destroy(other.gameObject);
                Gun.SetActive(true);
            }
        }
        if (other.tag == "Umbrella")
        {
            if (Input.GetKeyDown("e"))
            {
                Destroy(other.gameObject);
                Umbrella.SetActive(true);
            }
        }
    }


}
