using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorStates : MonoBehaviour
{
    public float turnTime = 50f;
    public void RotateToPlusX()
    {
        Quaternion target = Quaternion.Euler(transform.eulerAngles.x + 15, transform.eulerAngles.y, transform.eulerAngles.z);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target, turnTime * Time.deltaTime);
    }
    public void RotateToMinusX()
    {
        Quaternion target = Quaternion.Euler(transform.eulerAngles.x - 15, transform.eulerAngles.y, transform.eulerAngles.z);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target, turnTime * Time.deltaTime);
    }
    public void RotateToPlusY()
    {
        Quaternion target = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y + 15, transform.eulerAngles.z);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target, turnTime * Time.deltaTime);
    }
    public void RotateToMinusY()
    {
        Quaternion target = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y - 15, transform.eulerAngles.z);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, target, turnTime * Time.deltaTime);
    }
}
