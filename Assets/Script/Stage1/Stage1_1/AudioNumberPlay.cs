using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioNumberPlay : MonoBehaviour
{

    private AudioSource theAudio;
    [SerializeField] AudioClip[] clips;
    [SerializeField] string sign;
    [SerializeField] int num;
    [SerializeField] AudioNumManager am;
    // Start is called before the first frame update

    void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }

    public void playAudio()
    {
        int number = am.getAnswerforAudio(sign, num);
        theAudio.clip = clips[number - 1];
        theAudio.Play();
    }
}
