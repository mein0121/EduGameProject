using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateName : MonoBehaviour
{
    [SerializeField] FlagManager fm;
    [SerializeField] int number;
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        
        fm.audioPlay(number);
    }
}
