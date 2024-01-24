using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MirrorLines : MonoBehaviour
{
    public bool blocked = false;
    public GameObject rayPrefab;
    private GameObject childRay;
    public GameObject lightTarget;
    public Quaternion quat = Quaternion.identity;

    private void Start()
    {
        blocked = false;
        lightTarget = null;
        childRay = null;
    }
    private void Update()
    {
        if (!blocked)
        {
            gameObject.transform.localScale += new Vector3(0, 0.1f, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Ray ray = new Ray(transform.position, transform.up);
        RaycastHit hit;
        if (other.tag != "Light")
        {
            if (other.tag == "Mirror" && other.GetComponent<MirrorBool>().withRay)
            {
                Debug.Log(1);
            }
            else
            {
                Debug.Log(other.name);
                blocked = true;
                if (other.tag == "Mirror" && !other.GetComponent<MirrorBool>().withRay)
                {
                    other.GetComponent<MirrorBool>().withRay = true;
                    lightTarget = other.gameObject;
                    var x = 0f;
                    var z = 0f;
                    if (gameObject.transform.eulerAngles.x - other.transform.eulerAngles.x != 0)
                    {
                        x = -(180 - Math.Abs(gameObject.transform.eulerAngles.x - other.transform.eulerAngles.x) * 2);
                    }
                    if (gameObject.transform.eulerAngles.z - other.transform.eulerAngles.z != 0)
                    {
                        z = -(180 - Math.Abs(gameObject.transform.eulerAngles.z - other.transform.eulerAngles.z) * 2);
                    }
                    quat.eulerAngles = new Vector3(x, 0, z);
                    childRay = Instantiate(rayPrefab, other.transform.position, quat);
                }
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        var x = 0f;
        var z = 0f;
        if (gameObject.transform.eulerAngles.x - other.transform.eulerAngles.x != 0)
        {
            x = -(180 - Math.Abs(gameObject.transform.eulerAngles.x - other.transform.eulerAngles.x) * 2);
        }
        if (gameObject.transform.eulerAngles.z - other.transform.eulerAngles.z != 0)
        {
            z = -(180 - Math.Abs(gameObject.transform.eulerAngles.z - other.transform.eulerAngles.z) * 2);
        }
        quat.eulerAngles = new Vector3(x, 0, z);
        if (other.gameObject == lightTarget)
        {
            childRay.transform.rotation = quat;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        blocked = false;
        if (other.gameObject == lightTarget)
        {
            other.GetComponent<MirrorBool>().withRay = false;
            lightTarget = null;
            Destroy(childRay);
        }
        
    }
}
