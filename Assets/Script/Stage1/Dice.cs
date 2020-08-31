using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dice : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rigid;
    bool hasLanded = false;
    bool thrown = false;
    public float throwpower= 10;
    public int diceValue; // dice value after throw
    public Boxes boxes;
    public DiceSide[] DiceSides;
    public Text dvalue;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.useGravity = false;
        boxes.resetLight();
    }

    void Update()
    {
        if (rigid.IsSleeping() && !hasLanded && thrown) 
        {

            hasLanded = true;
            rigid.useGravity = false;
            SideValueCheck();
            rigid.isKinematic = true;
        }
        else if (rigid.IsSleeping() && hasLanded && diceValue == 0)
        {
            RollAgain();
        }

    }

    public void roll()
    {
        RollDice();
        boxes.resetLight();
        dvalue.text = "0";
    }
    void RollDice()
    {
        if (!thrown && !hasLanded)
        {
            thrown = true;
            rigid.useGravity = true;
            rigid.AddForce(Vector3.up * throwpower, ForceMode.Impulse);
            rigid.AddTorque(Random.Range(0, 500), Random.Range(0, 500), Random.Range(0, 500));
        }
        else if (thrown && hasLanded)
        {
            Reset();
        }
    }

    void Reset()
    {
        thrown = false;
        hasLanded = false;
        rigid.useGravity = false;
        rigid.isKinematic = false;
    }
    void RollAgain()
    {
        Reset();
        thrown = true;
        rigid.useGravity = true;
        rigid.AddForce(Vector3.up * throwpower, ForceMode.Impulse);
        rigid.AddTorque(Random.Range(0, 500), Random.Range(0, 500), Random.Range(0, 500));
    }

    void SideValueCheck()
    {
        diceValue = 0;
        foreach (DiceSide side in DiceSides)
        {
            if (side.OnGround())
            {
                diceValue = side.sideValue;
            }
        }
        dvalue.text = diceValue.ToString();
        boxes.lightBoxes();
    }

}
