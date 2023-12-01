using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActions : MonoBehaviour
{
    public int id;


    public GameObject ActiveTrigger = null;
    public GameObject ActiveAction = null;
    public GameObject ActiveParameter = null;

    public GameObject passwordCanvas;
    public GameObject buttonCanvas;

    public string realPassword;

    public void Start()
    {
        passwordCanvas.SetActive(false);
        buttonCanvas.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<OpenAction>(out OpenAction oa) && !GetComponent<DoorStates>().doorIsOpen && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<DoorStates>().OpenDoor();
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
            if (ActiveAction.TryGetComponent<OpenAction>(out OpenAction oa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<CloseAction>(out CloseAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<CloseAction>(out CloseAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<CloseAction>(out CloseAction ca) && GetComponent<DoorStates>().doorIsOpen && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<DoorStates>().CloseDoor();
            }
        }
        if (other.gameObject.tag == "Player")
        {
            passwordCanvas.SetActive(false);
            buttonCanvas.SetActive(false);
        }

    }
    public void PasswordAction(string password)
    {
        if (realPassword == password && ActiveAction && ActiveTrigger)
        {   
            if (ActiveAction.TryGetComponent<OpenAction>(out OpenAction oa) && !GetComponent<DoorStates>().doorIsOpen && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt1))
            {
                GetComponent<DoorStates>().OpenDoor();
            }
            else if (ActiveAction.TryGetComponent<CloseAction>(out CloseAction ca) && GetComponent<DoorStates>().doorIsOpen && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt2))
            {
                GetComponent<DoorStates>().CloseDoor();
            }
        }
    }
    public void ButtonAction()
    {
        if (ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<OpenAction>(out OpenAction oa) && !GetComponent<DoorStates>().doorIsOpen && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt1))
            {
                GetComponent<DoorStates>().OpenDoor();
            }
            else if (ActiveAction.TryGetComponent<CloseAction>(out CloseAction ca) && GetComponent<DoorStates>().doorIsOpen && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt2))
            {
                GetComponent<DoorStates>().CloseDoor();
            }
        }
    }
}
