﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Title : MonoBehaviour
{

    public void SelectStage(int num)
    {

        SceneManager.LoadScene(num);

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
