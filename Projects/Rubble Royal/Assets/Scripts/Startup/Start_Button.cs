using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour
{
    public class Control : MonoBehaviour
    {

        public void LoadScene(Scene.Battle)
        {
            Application.LoadLevel(2);
        }



    }
}
