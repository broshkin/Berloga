using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    public GameObject pickUpCanvas;
    public GameObject diskCanvas;
    public AudioSource bear;
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
                if (gameObject.tag == "Wheel")
                {
                    GameObject.Find("123").GetComponent<InstallWheel>().wheelArePicked = true;
                    bear.GetComponent<BearAudioPlay>().StartPlayCoroutine();
                }
                if (gameObject.tag == "Disk")
                {
                    diskCanvas.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }
                Destroy(pickUpCanvas);
                Destroy(gameObject);
            }
        }
    }
    
}
