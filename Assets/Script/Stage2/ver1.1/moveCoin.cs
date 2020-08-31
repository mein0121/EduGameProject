using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCoin : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    [SerializeField] float coinValue;
    bool move = true;
    public ValueCal valueChecker;


    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
        string coinName = gameObject.tag;
        valueChecker.audioValue(coinName);
    }


    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        if(move == true)
        {
            transform.position = GetMouseAsWorldPoint() + mOffset;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        string coinName = gameObject.name;
        if(other.name == coinName + "A")
        {
            valueChecker.valueCheck += coinValue;
            move = false;
            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            string cor = "correct";
            valueChecker.audioValue(cor);
        }
    }
}
