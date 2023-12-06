using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStates : MonoBehaviour
{
    public bool doorIsOpen = false;

    public void Start()
    {
        GetComponent<BoxCollider>().enabled = true;
    }

    public void OpenDoor()
    {
        GetComponent<Animator>().SetBool("OpenDoor", true);
        doorIsOpen = true;
        GetComponent<AudioSource>().Play();
    }
    public void CloseDoor()
    {
        GetComponent<Animator>().SetBool("CloseDoor", true);
        doorIsOpen = false;
        GetComponent<AudioSource>().Play();
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
}
