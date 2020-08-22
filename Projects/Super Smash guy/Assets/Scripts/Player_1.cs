using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour
{

    float Movementspeed = 10f;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Controller();
    }

    void Controller()
    {
        if (Input.GetKey("s"))
        {
            transform.Translate(Movementspeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(-Movementspeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(0, Movementspeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(0, -Movementspeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("space"))
        {
            transform.Translate(0, 0, Movementspeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Movementspeed = 20f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Movementspeed = 10f;
        }
    }







}
