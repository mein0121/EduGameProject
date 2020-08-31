using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    public GameObject Coin;
    GameObject coinClone;
    Vector3 iniPosition;
    [SerializeField] float coinValue;

    public CoinValueChecker valueChecker;

    private void Start()
    {
        iniPosition = transform.position;
    }
    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
        string coinName = gameObject.tag;
        valueChecker.soundPlay(coinName);
        cloning();
    }

    private void cloning()
    {
        coinClone = GameObject.Instantiate(Coin as GameObject);
        coinClone.transform.position = iniPosition;
    }

    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "coincounter")
        {
            valueChecker.valueCheck += coinValue;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "coincounter")
        {
            valueChecker.valueCheck -= coinValue;
        }
    }
}
