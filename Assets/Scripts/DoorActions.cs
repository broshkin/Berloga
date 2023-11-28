using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActions : MonoBehaviour
{
    public bool closeDoorOnAlive = false;
    public bool openDoorOnAlivew = false;
    public bool doorIsOpen = false;

    public GameObject ActiveTrigger;
    public GameObject ActiveAction;
    public GameObject ActiveParameter;

    public string currentPassword;

    public void Start()
    {
        GetComponent<BoxCollider>().enabled = true;
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
            if (ActiveAction.TryGetComponent<OpenAction>(out OpenAction oa) && !doorIsOpen)
            {
                OpenDoor();
            }
        }
        if (other.gameObject.tag == "Player")
        {
            if (ActiveAction.TryGetComponent<OpenAction>(out OpenAction oa) && !doorIsOpen)
            {
                OpenDoor();
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (ActiveAction.TryGetComponent<CloseAction>(out CloseAction ca) && doorIsOpen)
            {
                CloseDoor();
            }
        }
    }
    public void PasswordAction(string password)
    {
        if (currentPassword == password)
        {
            if (ActiveAction.TryGetComponent<OpenAction>(out OpenAction oa) && !doorIsOpen)
            {
                OpenDoor();
            }
            if (ActiveAction.TryGetComponent<CloseAction>(out CloseAction ca) && doorIsOpen)
            {
                CloseDoor();
            }
        }
    }
}
