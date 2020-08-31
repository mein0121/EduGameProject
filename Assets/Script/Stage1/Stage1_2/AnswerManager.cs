using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerManager : MonoBehaviour
{
    [SerializeField] PlusManager pm;
    [SerializeField] MinusManager mm;
    [SerializeField] MultipleManager multiple;
    [SerializeField] DiviManager dm;
    // Start is called before the first frame update

    // Update is called once per frame

    public int getAnswerforAudio(string name, int num)
    {
        int ans = 0;
        switch (name)
        {
            case "plus":
                ans = pm.returnArray(num);
                break;

            case "minus":
                ans = mm.returnArray(num);
                break;

            case "divide":
                ans = dm.returnArray(num);
                break;
            case "multiple":
                ans = multiple.returnArray(num);
                break;
        }
        return ans;
    }
}
