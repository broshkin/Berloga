using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShipStates : MonoBehaviour
{
    public float speed = 10;
    public bool moving = false;
    public bool rotating = false;
    public float duration = 0.5f;
    public List<int> requests;
    public bool isFinished = false;
    public Vector3 startPos;

    public void Start()
    {
        startPos = transform.position;
    }

    IEnumerator MoveForward()
    {
        if (moving) yield return null;
        moving = true;
        var curPos = transform.position;
        var newPos = curPos + transform.right * 1.0625f * 2;
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime / duration;
            transform.position = Vector3.Lerp(curPos, newPos, t);
            yield return null;
        }
        moving = false;

    }
    IEnumerator RotateLeft()
    {
        if (rotating) yield return null;
        rotating = true;
        var curPos = transform.eulerAngles;
        var newPos = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z - 90);
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime / duration;
            transform.eulerAngles = Vector3.Lerp(curPos, newPos, t);
            yield return null;
        }
        rotating = false;
    }
    IEnumerator RotateRight()
    {
        if (rotating) yield return null;
        rotating = true;
        var curPos = transform.eulerAngles;
        var newPos = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + 90);
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime / duration;
            transform.eulerAngles = Vector3.Lerp(curPos, newPos, t);
            yield return null;
        }
        rotating = false;
    }

    IEnumerator DefaultCoroutine()
    {    
        foreach(var a in requests)
        {
            if (a == 0)
            {
                yield return StartCoroutine(MoveForward());
            }
            else if (a == 1)
            {
                yield return StartCoroutine(RotateRight());
            }
            else if (a == 2)
            {
                yield return StartCoroutine(RotateLeft());
            }
        }
        isFinished = true;
        requests.Clear();
    }

    public void ActivateMoving()
    {
        StartCoroutine(DefaultCoroutine());
    }
}
