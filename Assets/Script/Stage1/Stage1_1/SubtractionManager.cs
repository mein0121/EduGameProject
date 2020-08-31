using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SubtractionManager : MonoBehaviour
{
    private const int V = 6, X = 3;
    public int[] array = new int[6];
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

    public void SubtractionStart()
    {
        menu.gameObject.SetActive(false);
        currentUI.gameObject.SetActive(true);

        for (int i = 0; i < 6; i++)
        {
            number = Random.Range(1, 11);
            array[i] = number;
        }

        for (int i = 0; i < 6; i++)
        {
            if (i % 2 == 0)
            {
                if (array[i] < array[i + 1])
                {
                    int swap = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = swap;
                }
                generateItem(array[i], x, 0.8f - i * 0.7f);
                generateItem(array[i + 1], y, 0.8f - i * 0.7f);
            }

        }
        display();
    }

    public int returnArray(int num)
    {
        int number = array[num];
        return number;
    }


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

    public void getAnswer1()
    {
        if (string.IsNullOrEmpty(inputs[0].text))
        {
            Debug.Log("");
        }
        else
        {
            if (int.Parse(inputs[0].text) == array[0] - array[1])
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
            if (int.Parse(inputs[1].text) == array[2] - array[3])
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
            if (int.Parse(inputs[2].text) == array[4] - array[5])
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
