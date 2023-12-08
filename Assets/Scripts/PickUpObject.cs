using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public GameObject pickUpCanvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pickUpCanvas.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            pickUpCanvas.SetActive(false);
        }
    }
    private void Update()
    {
        if (pickUpCanvas.activeSelf) 
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameObject.Find("123").GetComponent<InstallWheel>().wheelArePicked = true;
                Destroy(pickUpCanvas);
                Destroy(gameObject);
            }
        }
    }
}
