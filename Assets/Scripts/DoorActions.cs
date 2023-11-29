using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActions : MonoBehaviour
{
    public int id;

    public bool doorIsOpen = false;

    public GameObject ActiveTrigger = null;
    public GameObject ActiveAction = null;
    public GameObject ActiveParameter = null;

    public GameObject passwordCanvas;

    public string realPassword;

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
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<OpenAction>(out OpenAction oa) && !doorIsOpen && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                OpenDoor();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<OpenAction>(out OpenAction oa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<CloseAction>(out CloseAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<CloseAction>(out CloseAction ca) && doorIsOpen && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                CloseDoor();
            }
        }
        if (other.gameObject.tag == "Player")
        {
            passwordCanvas.SetActive(false);
        }

    }
    public void PasswordAction(string password)
    {
        if (realPassword == password && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<OpenAction>(out OpenAction oa) && !doorIsOpen && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt1))
            {
                OpenDoor();
            }
            if (ActiveAction.TryGetComponent<CloseAction>(out CloseAction ca) && doorIsOpen && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt2))
            {
                CloseDoor();
            }
        }
    }
}
