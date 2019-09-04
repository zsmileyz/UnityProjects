using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement : MonoBehaviour
{
    public float movementSpeed = 3;
    public float jumpHeight = 130f;
    public float sprintSpeed = 5.2f;

    public bool grounded = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Controller();
        Jump();
    }

    private void FixedUpdate()
    {

    }

    void Controller()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
            
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            movementSpeed = sprintSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            movementSpeed = 3f;
        }


    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            if(grounded == true)
            {
                transform.position += Vector3.up * jumpHeight * Time.deltaTime;
                grounded = false;
            }
                  
            if(grounded == false)
            {
                return;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D ground)
    {
        if(ground.gameObject)
        {
            grounded = true;
        }
    }
}
