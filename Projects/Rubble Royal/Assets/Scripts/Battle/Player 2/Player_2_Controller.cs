﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_2_Controller : MonoBehaviour
{
    public float red = 0;
    public float win = 5;

    public Text Score;
    public Text player1_Wins;

    public bool is_Dead = false;

    [SerializeField] private Transform playerStartingPoint;
    [SerializeField] private Transform respawnPoint;

    void Start()
    {
        
    }


    void Update()
    {
       
    }
    
    IEnumerator respawner()
    {
        yield return new WaitForSeconds(2f);
        red += 1;
        Score.text = red.ToString();
        is_Dead = true;
        playerStartingPoint.transform.position = respawnPoint.transform.position;
        is_Dead = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pit"))
        {
            StartCoroutine(respawner());                     
        }
        if (red >= win)
        {
            player1_Wins.enabled = true;
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
