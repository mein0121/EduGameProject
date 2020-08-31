using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumberAudio : MonoBehaviour
{
    private AudioSource theAudio;
    [SerializeField] AudioClip[] clips;
    [SerializeField] int num;
    [SerializeField] AnswerManager am;
    [SerializeField] string sign;
    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }

    public void playAudio()
    {
        int number = am.getAnswerforAudio(sign, num);
        theAudio.clip = clips[number-1];
        theAudio.Play();
    }

    // Update is called once per frame



}
