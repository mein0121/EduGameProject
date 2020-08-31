using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField] GameObject MenuUi;
    public void ShowMenu()
    {
        MenuUi.gameObject.SetActive(true);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }

    public void BactToStage1()
    {
        SceneManager.LoadScene(1);
    }

    public void ViewCoins()
    {
        SceneManager.LoadScene(5);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(6);
    }
}
