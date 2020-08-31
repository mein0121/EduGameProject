using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFlag : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    bool move = true;
    [SerializeField] FlagManager fm;
    [SerializeField] int num;
    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
        fm.audioPlay(num);
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
        string stateName = gameObject.name;
        if(other.name == stateName + "A")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            move = false;
            fm.countFlag();
        }
    }

}
