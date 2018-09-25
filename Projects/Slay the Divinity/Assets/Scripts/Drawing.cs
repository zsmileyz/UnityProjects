using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour 
{
    public GameObject card;
    public GameObject card1;


	void Start () 
	{
        StartCoroutine("StartingDraw");
    }
	
	void Update () 
	{

        
    }



    IEnumerator StartingDraw()
    {
        Instantiate(card,transform,transform.parent);
        yield return new WaitForSeconds(0.5f);
        Instantiate(card1, transform, transform.parent);
        yield return new WaitForSeconds(0.5f);
        Instantiate(card, transform, transform.parent);
        yield return new WaitForSeconds(0.5f);
        Instantiate(card1, transform, transform.parent);
        yield return new WaitForSeconds(0.5f);
        Instantiate(card, transform, transform.parent);
        Debug.Log("Drawing Complete!!");
    }    
	
}
