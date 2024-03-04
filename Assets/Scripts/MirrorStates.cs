using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorStates : MonoBehaviour
{
    public float turnTime = 50f;

    public void RotateToMinusY()
    {
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x - 5, transform.eulerAngles.y, transform.eulerAngles.z);
    }
    public void RotateToPlusY()
    {
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x + 5, transform.eulerAngles.y, transform.eulerAngles.z);
    }
    public void RotateToPlusX()
    {
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y + 5, transform.eulerAngles.z);
    }
    public void RotateToMinusX()
    {
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y - 5, transform.eulerAngles.z);
    }
}
