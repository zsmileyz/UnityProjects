using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_2_Controller : MonoBehaviour
{
    public float red = 0;
    public float win = 5;

    public Text Score;

    public bool is_Dead = false;

    void Start()
    {
        
    }


    void Update()
    {
       
    }

    

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Pit"))
        {
            red += 1;
            Score.text = red.ToString();
            is_Dead = true;     
            Destroy(gameObject);
            Debug.Log(red);
        }
        if (red >= win)
        {
            Score.text = "You Win!";
        }
    }
}
