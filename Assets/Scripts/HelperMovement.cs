using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperMovement : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.5F;
    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        var lookPos = target.position - transform.position;
        lookPos.y = -1;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 2);
        transform.position = Vector3.SmoothDamp(transform.position, target.position + new Vector3(-0.62f, 1.812f, -1.153f), ref velocity, smoothTime);
    }

}
