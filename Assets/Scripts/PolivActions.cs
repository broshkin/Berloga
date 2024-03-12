using UnityEngine;

public class PolivActions : MonoBehaviour
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
            if (ActiveAction.TryGetComponent<PolivAction>(out PolivAction fa) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<PolivStates>().Poliv();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<PolivAction>(out PolivAction fa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<PolivAction>(out PolivAction oa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
                buttonCanvas.GetComponent<ButtonCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<PosevAction>(out PosevAction fa) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<PolivStates>().Posev();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<PosevAction>(out PosevAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<PosevAction>(out PosevAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
                buttonCanvas.GetComponent<ButtonCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<UdobrenieAction>(out UdobrenieAction fa) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<PolivStates>().Udobrenie();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<UdobrenieAction>(out UdobrenieAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<UdobrenieAction>(out UdobrenieAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
                buttonCanvas.GetComponent<ButtonCanvas>().interactObject = gameObject;
            }
        }

        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<VspohatAction>(out VspohatAction fa) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<PolivStates>().Vspohat();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<VspohatAction>(out VspohatAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<VspohatAction>(out VspohatAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
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
            if (ActiveAction.TryGetComponent<PolivAction>(out PolivAction oa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt1))
            {
                GetComponent<PolivStates>().Poliv();
            }
            else if (ActiveAction.TryGetComponent<PosevAction>(out PosevAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt2))
            {
                GetComponent<PolivStates>().Posev();
            }
            else if (ActiveAction.TryGetComponent<UdobrenieAction>(out UdobrenieAction sa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt3))
            {
                GetComponent<PolivStates>().Udobrenie();
            }
            else if (ActiveAction.TryGetComponent<VspohatAction>(out VspohatAction aa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt4))
            {
                GetComponent<PolivStates>().Vspohat();
            }
        }
    }
    public void ButtonAction()
    {
        if (ActiveAction && ActiveTrigger)
        {
            Debug.Log(ActiveAction);
            if (ActiveAction.TryGetComponent<PolivAction>(out PolivAction oa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt1))
            {
                GetComponent<PolivStates>().Poliv();
            }
            else if (ActiveAction.TryGetComponent<PosevAction>(out PosevAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt2))
            {
                GetComponent<PolivStates>().Posev();
            }
            else if (ActiveAction.TryGetComponent<UdobrenieAction>(out UdobrenieAction sa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt3))
            {
                GetComponent<PolivStates>().Udobrenie();
            }
            else if (ActiveAction.TryGetComponent<VspohatAction>(out VspohatAction aa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt4))
            {
                GetComponent<PolivStates>().Vspohat();
            }
        }
    }
}
