using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectItem : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float itemPrice;
    public CoinValueChecker valueChecker;


    // Update is called once per frame

    private void OnMouseDown()
    {
        GameObject.Find("Main Camera").transform.position = new Vector3(0, 10, -0.5f);
        Camera.main.transform.rotation = Quaternion.Euler(90, 0, 0);
        activateText();
        valueChecker.itemPrice = itemPrice;
    }

    void activateText()
    {
        valueChecker.valueChecker.gameObject.SetActive(true);
        valueChecker.displayItemprice.gameObject.SetActive(true);
    }
}
