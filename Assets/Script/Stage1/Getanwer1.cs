using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Getanwer1 : MonoBehaviour
{
    [SerializeField] private InputField answer;
    [SerializeField] GameObject go_UI;
    [SerializeField] GameObject next_UI;
    public Text warning;
    public Dice[] dice;
    private int current = 1;


    public void runDice()
    {
        foreach (Dice dices in dice)
        {
            dices.roll();
        }
    }
    public void Multyple()
    {
        if (string.IsNullOrEmpty(answer.text))
        {
            warning.gameObject.SetActive(true);
        }
        else
        {
            foreach (Dice dices in dice)
            {
                current *= dices.diceValue;
            }

            if (int.Parse(answer.text) == current)
            {
                next_UI.SetActive(true);
            }
            else
            {
                go_UI.SetActive(true);
            }
        }

    }
    public void RePlay()
    {
        SceneManager.LoadScene(4);
    }
    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }

    public void NextStage()
    {
        SceneManager.LoadScene(5);
    }
}
