using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumBoxes : MonoBehaviour
{
    [SerializeField] BoxNum[] boxes;
    public Dice[] dices;
    private int sum=0;

    public void LightSumBoxes()
    {
        resetSumBoxes();
            foreach (Dice dice in dices)
            {
                sum += dice.diceValue;
            }

            for (int i = 0; i < sum; i++)
            {
                boxes[i].gameObject.SetActive(true);
            }
    }
    
    public void resetSumBoxes()
    {
        for(int i = 0; i<12; i++)
        {
            boxes[i].gameObject.SetActive(false);
        }
    }
}
