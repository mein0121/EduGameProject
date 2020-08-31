using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    [SerializeField] BoxNum[] boxes;

    public Dice dice;
    private int dicenum = 0;
    public void lightBoxes()
    { 
        dicenum = dice.diceValue;
        for (int i = 0; i < dicenum; i++) {
            boxes[i].gameObject.SetActive(true);
        }
    }

    public void resetLight()
    {
        for(int i =0; i<boxes.Length; i++)
        {
            boxes[i].gameObject.SetActive(false);
        }
    }
}
