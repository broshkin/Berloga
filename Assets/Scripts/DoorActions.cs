using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActions : MonoBehaviour
{
    public bool closeDoorOnAlive = false;
    public bool openDoorOnAlive = false;
    public bool doorIsOpen = false;

    public void Start()
    {
        GetComponent<BoxCollider>().enabled = false;
    }

    public void OpenDoor()
    {
        GetComponent<Animator>().SetBool("OpenDoor", true);
        doorIsOpen = true;
    }
    public void CloseDoor()
    {
        GetComponent<Animator>().SetBool("CloseDoor", true);
        doorIsOpen = false;
    }

    public void Update()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Open"))
        {
            GetComponent<Animator>().SetBool("OpenDoor", false);
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Close"))
        {
            GetComponent<Animator>().SetBool("CloseDoor", false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (openDoorOnAlive && !doorIsOpen)
            {
                OpenDoor();
            }
            if (closeDoorOnAlive && doorIsOpen)
            {
                CloseDoor();
            }
        }
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    if (doorIsOpen)
    //    {
    //        CloseDoor();
    //    }
    //}
}
