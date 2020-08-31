using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    private AudioSource theAudio;
    [SerializeField] AudioClip[] clips;
    [SerializeField] Dice dices;

    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }

    public void numSound()
    {
        int value = 0;
        value = dices.diceValue;
        theAudio.clip = clips[value];
        theAudio.Play();
    }
}
