using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinValueChecker : MonoBehaviour
{

    public float valueCheck;
    public float itemPrice;
    public Text valueChecker;
    public Text displayItemprice;
    [SerializeField] GameObject menuUI;
    [SerializeField] GameObject sign;
    private int num;
    private AudioSource theAudio;
    [SerializeField] AudioClip[] clips;

    private void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        valueChecker.text = "Current payment is "+valueCheck.ToString("N2");
        displayItemprice.text = "The Item price is "+itemPrice.ToString("N2");

        if (Mathf.Round(valueCheck * 100) * 0.01f == Mathf.Round(itemPrice * 100) * 0.01f && itemPrice != 0)
        {
            sign.gameObject.SetActive(true);
        }
        else
        {
            sign.gameObject.SetActive(false);
        }
    }

    public void soundPlay(string name)
    {
        switch (name)
        {
            case "Quarter":
                num = Random.Range(6, 8);
                theAudio.clip = clips[num];
                theAudio.Play();
                break;
            case "dime":
                num = Random.Range(4, 6);
                theAudio.clip = clips[num];
                theAudio.Play();
                break;
            case "nickel":
                num = Random.Range(2, 4);
                theAudio.clip = clips[num];
                theAudio.Play();
                break;
            case "penny":
                num = Random.Range(0, 2);
                theAudio.clip = clips[num];
                theAudio.Play();
                break;
        }
    }


    public void menuButton()
    {
        menuUI.gameObject.SetActive(true);
    }
    public void menuSelection(int num)
    {
        SceneManager.LoadScene(num);
    }
}
