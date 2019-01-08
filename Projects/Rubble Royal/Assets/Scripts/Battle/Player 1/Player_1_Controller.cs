using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class Player_1_Controller : MonoBehaviour
{
    public float speed = 5;
    public float blue = 0;
    public float win = 5;

    public GameObject Gun;
    public GameObject Umbrella;
    public GameObject esc_Menu;

    public Text score;

    public bool is_Dead = false;

    [SerializeField] private Transform playerlocation;
    [SerializeField] private Transform player_1_respawner;

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
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pit")
        {
            StartCoroutine(respawner());
            if (blue >= win)
            {
                score.text = "You Win!";
                Destroy(gameObject);
                Time.timeScale = 0;
            }

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

    IEnumerator respawner()
    {
        yield return new WaitForSeconds(2f);
        blue += 1;
        score.text = blue.ToString();
        is_Dead = true;
        playerlocation.transform.position = player_1_respawner.transform.position;
        is_Dead = false;
        
    }


}
