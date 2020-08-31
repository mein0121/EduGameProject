using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateSelection : MonoBehaviour
{
    [SerializeField] ShowInfo showinfo;
    [SerializeField] int stateNum;



    public void SelectionButton()
    {
        string state = gameObject.name;
        showinfo.DisplayInfo(state, stateNum);
    }

    
}
