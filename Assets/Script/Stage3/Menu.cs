using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject menuUi;
    public void ShowMenu()
    {
        menuUi.gameObject.SetActive(true);
    }

    public void selection(int num)
    {
        SceneManager.LoadScene(num);
    }
}