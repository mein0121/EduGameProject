using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class symbolSound : MonoBehaviour
{
    private AudioSource theAudio;
    [SerializeField] AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame

    public void symbolPlay()
    {
        theAudio.clip = clip;
        theAudio.Play();
    }
}
