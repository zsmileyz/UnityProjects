﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
