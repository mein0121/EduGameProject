using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FlagManager : MonoBehaviour
{
    [SerializeField] Text countF;
    [SerializeField] GameObject sign;
    [SerializeField] GameObject menuUI;
    private int num;
    private AudioSource theAudio;
    [SerializeField] AudioClip[] clips;
    [SerializeField] AudioClip great;
    // Start is called before the first frame update
    private void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        countF.text =  num.ToString() + " / 15";
        if(num == 15)
        {
            sign.SetActive(true);
        }
    }

    public void audioPlay(int num)
    {
        theAudio.clip = clips[num];
        theAudio.Play();
    }

    public void countFlag()
    {
        num++;
        theAudio.clip = great;
        theAudio.Play();

    }

    public void MenuButton()
    {
        menuUI.SetActive(true);
    }

    public void selection(int num)
    {
        SceneManager.LoadScene(num);
    }
}
