using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Spawner2 : MonoBehaviour
{
    public GameObject player_2;
    Player_2_Controller player2;

    void Start()
    {
        
    }



    void Update()
    {
        //StartCoroutine(Timer());
    }

    void Respawn()
    {
        Instantiate(player_2, transform.position, Quaternion.identity);
    }

    /*IEnumerator Timer()
    {
        if (player2.is_Dead == true)
        {
            Debug.Log("Waiting");
            yield return new WaitForSeconds(5f);
            Respawn();
            player2.is_Dead = false;
        }




    }
    */
}
