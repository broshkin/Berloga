using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class CamZone : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera virtualCamera = null;
    // Start is called before the first frame update
    void Start()
    {
        virtualCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            virtualCamera.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            virtualCamera.enabled = false;
        }
    }
    private void OnValidate()
    {
        GetComponent<Collider>().isTrigger = true;
    }
}
