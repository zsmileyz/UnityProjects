using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ESC_Menu : MonoBehaviour
{
    public GameObject esc_Menu;


    public void Quit()
    {
        SceneManager.LoadScene(0);
    }

    public void Back()
    {
        esc_Menu.SetActive(false);
    }


}
