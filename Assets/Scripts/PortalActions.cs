using UnityEngine;

public class PortalActions : MonoBehaviour
{
    public int id;

    public GameObject ActiveTrigger = null;
    public GameObject ActiveAction = null;
    public GameObject ActiveParameter = null;

    public GameObject passwordCanvas;
    public GameObject buttonCanvas;

    public string realPassword;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<ActivatePortalAction>(out ActivatePortalAction ma) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<PortalStates>().Activate();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<ActivatePortalAction>(out ActivatePortalAction ma) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<ActivatePortalAction>(out ActivatePortalAction ma) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
                buttonCanvas.GetComponent<ButtonCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<DeactivatePortalAction>(out DeactivatePortalAction ma) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<PortalStates>().Deactivate();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<DeactivatePortalAction>(out DeactivatePortalAction ma) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<DeactivatePortalAction>(out DeactivatePortalAction ma) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
                buttonCanvas.GetComponent<ButtonCanvas>().interactObject = gameObject;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<DeactivatePortalAction>(out DeactivatePortalAction ca) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<PortalStates>().Deactivate();
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
            if (ActiveAction.TryGetComponent<ActivatePortalAction>(out ActivatePortalAction oa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt1))
            {
                GetComponent<PortalStates>().Activate();
            }
            else if (ActiveAction.TryGetComponent<DeactivatePortalAction>(out DeactivatePortalAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt2))
            {
                GetComponent<PortalStates>().Deactivate();
            }
        }
    }
    public void ButtonAction()
    {
        if (ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<ActivatePortalAction>(out ActivatePortalAction oa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt1))
            {
                GetComponent<PortalStates>().Activate();
            }
            else if (ActiveAction.TryGetComponent<DeactivatePortalAction>(out DeactivatePortalAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt2))
            {
                GetComponent<PortalStates>().Deactivate();
            }
        }
    }
}
