using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MinusManager : MonoBehaviour
{
    private const int V = 6, X = 3;
    public int[] array = new int[3];
    int number;
    public GameObject item;
    GameObject cloneItem;
    [SerializeField] InputField[] inputs = new InputField[V];
    [SerializeField] Text[] texts = new Text[X];
    [SerializeField] GameObject menuUI;
    [SerializeField] GameObject currentUI;
    [SerializeField] GameObject[] signs = new GameObject[X];
    private AudioSource theAudio;
    [SerializeField] AudioClip clip;

    private void Start()
    {
        theAudio = GetComponent<AudioSource>();
        theAudio.clip = clip;
    }
    // Start is called before the first frame update
    public void SubtractionStart()
    {
        currentUI.gameObject.SetActive(true);
        menuUI.gameObject.SetActive(false);


        for (int i = 0; i < array.Length; i++)
        {
            number = Random.Range(2, 11);
            array[i] = number;
            texts[i].text = array[i].ToString();
            itemGenerator(array[i], 2.6f, 0.8f - i * 1.4f);
        }
    }


    void itemGenerator(int num, float cord, float cord1)
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

    public void checkValue(int num)
    {
        if (string.IsNullOrEmpty(inputs[num].text) || string.IsNullOrEmpty(inputs[num + 3].text) || int.Parse(inputs[num].text) < 0 || int.Parse(inputs[num + 3].text) < 0)
        {
            Debug.Log("");
        }
        else
        {
            if (array[num] == int.Parse(inputs[num].text) - int.Parse(inputs[num + 3].text))
            {
                signs[num].gameObject.SetActive(true);
                theAudio.Play();
            }
            else
            {
                signs[num].gameObject.SetActive(false);
            }
        }
    }

    public int returnArray(int num)
    {
        int number = array[num];
        return number;
    }
    public void menuButton()
    {
        SceneManager.LoadScene(2);
    }
}
