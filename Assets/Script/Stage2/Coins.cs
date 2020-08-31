using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coins : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rigid;
    [SerializeField] int coin;
    [SerializeField] Text CoinValueText;
    [SerializeField] Text maintext;
    private AudioSource theAudio;
    [SerializeField] AudioClip[] clips;
    private int num;
    bool haslanded;
    private void Awake()
    {
        haslanded = false;
        rigid = GetComponent<Rigidbody>();
        theAudio = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if(haslanded == false)
        {
            rigid.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            rigid.AddTorque(Random.Range(0, 500), Random.Range(0, 500), Random.Range(0, 500));
            GameObject.Find("Main Camera").transform.position = new Vector3(0, 9.9f, 6.5f);
            maintext.gameObject.SetActive(false);
            DisplayValue();
            haslanded = true;
        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            haslanded = false;
        }
    }

    void DisplayValue()
    {
        switch (coin)
        {
            case 0:
                CoinValueText.text = "It's a Penny, value of this coin is 1 cent";
                num = Random.Range(6, 8);
                theAudio.clip = clips[num];
                theAudio.Play();
                break;
            case 1:
                CoinValueText.text = "It's Nickel, value of this coin is 5 cents";
                num = Random.Range(4, 6);
                theAudio.clip = clips[num];
                theAudio.Play();
                break;
            case 2:
                CoinValueText.text = "It's Dime, value of this coin is 10 cents";
                num = Random.Range(2, 4);
                theAudio.clip = clips[num];
                theAudio.Play();
                break;
            case 3:
                CoinValueText.text = "It's Quarter, value of this coin is 25 cents";
                num = Random.Range(0, 2);
                theAudio.clip = clips[num];
                theAudio.Play();
                break;
        }
    }

}
