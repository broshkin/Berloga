using UnityEngine;

public class CarActions : MonoBehaviour
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
            if (ActiveAction.TryGetComponent<ForwardAction>(out ForwardAction fa) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<CarStates>().MoveForward();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<ForwardAction>(out ForwardAction fa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<ForwardAction>(out ForwardAction oa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
                buttonCanvas.GetComponent<ButtonCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<BackAction>(out BackAction fa) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<CarStates>().MoveBackward();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<BackAction>(out BackAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<BackAction>(out BackAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
                buttonCanvas.GetComponent<ButtonCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<SoundAction>(out SoundAction fa) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                soundSignal.Play();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<SoundAction>(out SoundAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<SoundAction>(out SoundAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
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
            if (ActiveAction.TryGetComponent<ForwardAction>(out ForwardAction oa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt1))
            {
                GetComponent<CarStates>().MoveForward();
            }
            else if (ActiveAction.TryGetComponent<BackAction>(out BackAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt2))
            {
                GetComponent<CarStates>().MoveBackward();
            }
            else if (ActiveAction.TryGetComponent<SoundAction>(out SoundAction sa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt3))
            {
                soundSignal.Play();
            }
        }
    }
    public void ButtonAction()
    {
        if (ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<ForwardAction>(out ForwardAction oa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt1))
            {
                GetComponent<CarStates>().MoveForward();
            }
            else if (ActiveAction.TryGetComponent<BackAction>(out BackAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt2))
            {
                GetComponent<CarStates>().MoveBackward();
            }
            else if (ActiveAction.TryGetComponent<SoundAction>(out SoundAction sa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt3))
            {
                soundSignal.Play();
            }
        }
    }
}
