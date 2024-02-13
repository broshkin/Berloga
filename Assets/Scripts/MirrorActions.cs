using UnityEngine;

public class MirrorActions : MonoBehaviour
{
    public int id;

    public GameObject ActiveTrigger = null;
    public GameObject ActiveAction = null;
    public GameObject ActiveParameter = null;

    public GameObject passwordCanvas;
    public GameObject buttonCanvas;

    public string realPassword;

    public AudioSource soundSignal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<RotateMirrorPlusXAction>(out RotateMirrorPlusXAction rmpx) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<MirrorStates>().RotateToPlusX();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<RotateMirrorPlusXAction>(out RotateMirrorPlusXAction fa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<RotateMirrorPlusXAction>(out RotateMirrorPlusXAction oa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
                buttonCanvas.GetComponent<ButtonCanvas>().interactObject = gameObject;
            }
        }

        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<RotateMirrorMinusXAction>(out RotateMirrorMinusXAction fa) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<MirrorStates>().RotateToMinusX();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<RotateMirrorMinusXAction>(out RotateMirrorMinusXAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<RotateMirrorMinusXAction>(out RotateMirrorMinusXAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
                buttonCanvas.GetComponent<ButtonCanvas>().interactObject = gameObject;
            }
        }

        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<RotateMirrorPlusYAction>(out RotateMirrorPlusYAction fa) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<MirrorStates>().RotateToPlusY();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<RotateMirrorPlusYAction>(out RotateMirrorPlusYAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<RotateMirrorPlusYAction>(out RotateMirrorPlusYAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
                buttonCanvas.GetComponent<ButtonCanvas>().interactObject = gameObject;
            }
        }

        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<RotateMirrorMinusYAction>(out RotateMirrorMinusYAction fa) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<MirrorStates>().RotateToMinusY();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<RotateMirrorMinusYAction>(out RotateMirrorMinusYAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<RotateMirrorMinusYAction>(out RotateMirrorMinusYAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
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
            if (ActiveAction.TryGetComponent<CloseAction>(out CloseAction ca) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {

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
            if (ActiveAction.TryGetComponent<RotateMirrorPlusXAction>(out RotateMirrorPlusXAction oa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt1))
            {
                GetComponent<MirrorStates>().RotateToPlusX();
            }
            else if (ActiveAction.TryGetComponent<RotateMirrorMinusXAction>(out RotateMirrorMinusXAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt2))
            {
                GetComponent<MirrorStates>().RotateToMinusX();
            }
            else if (ActiveAction.TryGetComponent<RotateMirrorPlusYAction>(out RotateMirrorPlusYAction sa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt3))
            {
                GetComponent<MirrorStates>().RotateToPlusY();
            }
            else if (ActiveAction.TryGetComponent<RotateMirrorMinusYAction>(out RotateMirrorMinusYAction aa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt4))
            {
                GetComponent<MirrorStates>().RotateToMinusY();
            }
        }
    }
    public void ButtonAction()
    {
        if (ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<RotateMirrorPlusXAction>(out RotateMirrorPlusXAction oa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt1))
            {
                GetComponent<MirrorStates>().RotateToPlusX();
            }
            else if (ActiveAction.TryGetComponent<RotateMirrorMinusXAction>(out RotateMirrorMinusXAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt2))
            {
                GetComponent<MirrorStates>().RotateToMinusX();
            }
            else if (ActiveAction.TryGetComponent<RotateMirrorPlusYAction>(out RotateMirrorPlusYAction sa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt3))
            {
                GetComponent<MirrorStates>().RotateToPlusY();
            }
            else if (ActiveAction.TryGetComponent<RotateMirrorMinusYAction>(out RotateMirrorMinusYAction aa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt4))
            {
                GetComponent<MirrorStates>().RotateToMinusY();
            }
        }
    }
}
