using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundCoin : MonoBehaviour
{
    [SerializeField] ValueCal val;


    private void OnMouseDown()
    {
        string coinName = gameObject.tag;
        val.audioValue(coinName);
    }

}
