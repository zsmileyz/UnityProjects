using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Small_Monster : MonoBehaviour
{
    public float captureChance = 0;



    


     public void CaptureChance()
    {
        if(captureChance == 0)
        {
            Destroy(gameObject, 5f);
        }
            
    }


}
