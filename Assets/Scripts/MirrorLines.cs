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
        if (other.tag != "Light")
        {
            if (other.tag == "Mirror" && other.GetComponent<MirrorBool>().withRay)
            {

            }
            else
            {
                blocked = true;
                if (other.tag == "Mirror" && !other.GetComponent<MirrorBool>().withRay)
                {
                    lightTarget = other.gameObject;
                    other.GetComponent<MirrorBool>().withRay = true;
                    var heading = other.transform.position - transform.position;
                    var distance = heading.magnitude;
                    var direction = heading / distance;
                    var reflVec = Vector3.Reflect(direction, other.transform.up);
                    childRay = Instantiate(rayPrefab, other.transform.position, Quaternion.LookRotation(reflVec) * Quaternion.Euler(90, 0, 0));
                    childRay.transform.localScale = new Vector3(1, 0.1f, 1);
                }
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag != "Light")
        {
            if (other.gameObject == lightTarget)
            {
                var heading = other.transform.position - transform.position;
                var distance = heading.magnitude;
                var direction = heading / distance;
                var reflVec = Vector3.Reflect(direction, other.transform.up);
                childRay.transform.rotation = Quaternion.LookRotation(reflVec) * Quaternion.Euler(-90, 0, 0);
            }
        }
            
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "Light")
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
}
