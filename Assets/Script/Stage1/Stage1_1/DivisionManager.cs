using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DivisionManager : MonoBehaviour
{
    private const int V = 6, X = 3;
    int[] array = new int[6];
    int number;
    public GameObject item;
    GameObject cloneItem;
    float x = -24, y = -20;
    [SerializeField] Text[] displayValue = new Text[V];
    [SerializeField] InputField[] inputs = new InputField[X];
    [SerializeField] GameObject menu;
    [SerializeField] GameObject currentUI;
    public GameObject[] signs = new GameObject[6];
    private AudioSource theAudio;
    [SerializeField] AudioClip clip;

    private void Start()
    {
        theAudio = GetComponent<AudioSource>();
        theAudio.clip = clip;
    }

    public void DivisionStart()
    {
        menu.gameObject.SetActive(false);
        currentUI.gameObject.SetActive(true);

        for (int i = 0; i < 6; i++)
        {
            if (i%2==0)
            {
                number = Random.Range(3, 11);
                array[i] = number;
                generateItem(array[i], x, 0.8f - i * 0.7f);
            }
            else
            {
                number = Random.Range(1,4);
                array[i] = number;
                generateItem(array[i], y, 1.5f - i * 0.7f);
            }
        }

        display();
    }


    // Update is called once per frame

    void generateItem(int num, float cord, float cord1)
    {
        if (num <= 5)
        {
            for (int i = 0; i < num; i++)
            {
                cloneItem = GameObject.Instantiate(item as GameObject);
                cloneItem.transform.position = new Vector3(cord + 0.3f * i, cord1, 0);
            }
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                cloneItem = GameObject.Instantiate(item as GameObject);
                cloneItem.transform.position = new Vector3(cord + 0.3f * i, cord1, 0);
            }
            for (int i = 5; i < num; i++)
            {
                cloneItem = GameObject.Instantiate(item as GameObject);
                cloneItem.transform.position = new Vector3(cord - 1.5f + 0.3f * i, -0.3f + cord1, 0);
            }
        }
    }

    void display()
    {
        for (int i = 0; i < 6; i++)
        {
            displayValue[i].text = array[i].ToString();

        }
    }

    public int returnArray(int num)
    {

        int number = array[num];
        return number;

    }
    public void getAnswer1()
    {
        if (string.IsNullOrEmpty(inputs[0].text))
        {
            Debug.Log("");
        }
        else
        {
            if (float.Parse(inputs[0].text).ToString("N2") == ((float)array[0] / (float)array[1]).ToString("N2"))
            {
                signs[0].SetActive(true);
                signs[1].SetActive(false);
                theAudio.Play();
            }
            else
            {
                signs[0].SetActive(false);
                signs[1].SetActive(true);
            }
        }
    }
    public void getAnswer2()
    {
        if (string.IsNullOrEmpty(inputs[1].text))
        {
            Debug.Log("");
        }
        else
        {
            if (float.Parse(inputs[1].text).ToString("N2") == ((float)array[2] / (float)array[3]).ToString("N2"))
            {
                signs[2].SetActive(true);
                signs[3].SetActive(false);
                theAudio.Play();
            }

            else
            {
                signs[2].SetActive(false);
                signs[3].SetActive(true);
            }
        }


    }
    public void getAnswer3()
    {
        if (string.IsNullOrEmpty(inputs[2].text))
        {
            Debug.Log("");
        }
        else
        {
            if (float.Parse(inputs[2].text).ToString("N2") == ((float)array[4] / (float)array[5]).ToString("N2"))
            {
                signs[4].SetActive(true);
                signs[5].SetActive(false);
                theAudio.Play();
            }
            else
            {
                signs[4].SetActive(false);
                signs[5].SetActive(true);
            }
        }
    }

    public void menuButton()
    {
        SceneManager.LoadScene(1);
    }
}
