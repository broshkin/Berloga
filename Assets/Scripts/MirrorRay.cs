using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MirrorRay : MonoBehaviour
{
    public GameObject rayObject;
    public GameObject nextRay;
    public Quaternion quat = Quaternion.identity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.up);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawLine(transform.position, hit.transform.position, Color.green);
            if (hit.collider.gameObject.tag == "Mirror")
            {
                hit.collider.gameObject.AddComponent<MirrorRay>();

            }
        }
    }
}
