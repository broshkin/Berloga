using UnityEngine;

public class CraneActions : MonoBehaviour
{
    public int id;

    public GameObject ActiveTrigger = null;
    public GameObject ActiveAction = null;
    public GameObject ActiveParameter = null;

    public GameObject passwordCanvas;
    public GameObject buttonCanvas;

    public string realPassword;
    private float power = 10000;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<MoveUpAction>(out MoveUpAction ma) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<CraneStates>().MoveUp();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<MoveUpAction>(out MoveUpAction ma) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;

            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<MoveUpAction>(out MoveUpAction ma) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
                buttonCanvas.GetComponent<ButtonCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<MoveDownAction>(out MoveDownAction ma) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                GetComponent<CraneStates>().MoveDown();
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<MoveDownAction>(out MoveDownAction ma) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<MoveDownAction>(out MoveDownAction ma) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
            {
                buttonCanvas.SetActive(true);
                buttonCanvas.GetComponent<ButtonCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<MagniteAction>(out MagniteAction fa) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                gameObject.GetComponentInChildren<Animator>().gameObject.GetComponentInChildren<ParticleSystem>().Play();
                foreach (var a in GameObject.FindGameObjectsWithTag("MagniteObject"))
                {
                    a.GetComponent<MagnitePower>().power = power;
                    a.GetComponent<MagnitePower>().enabled = true;
                }
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<MagniteAction>(out MagniteAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                passwordCanvas.SetActive(true);
                passwordCanvas.GetComponent<passwordCanvas>().interactObject = gameObject;
            }
        }
        if (other.gameObject.tag == "Player" && ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<MagniteAction>(out MagniteAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
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
            if (ActiveAction.TryGetComponent<MagniteAction>(out MagniteAction ca) && ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                //gameObject.GetComponentInChildren<Animator>().gameObject.GetComponentInChildren<ParticleSystem>().Stop();
                //foreach (var a in GameObject.FindGameObjectsWithTag("MagniteObject"))
                //{
                //    a.GetComponent<MagnitePower>().power = power;
                //    a.GetComponent<MagnitePower>().enabled = false;
                //}
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
            if (ActiveAction.TryGetComponent<MoveUpAction>(out MoveUpAction oa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt1))
            {
                GetComponent<CraneStates>().MoveUp();
            }
            else if (ActiveAction.TryGetComponent<MoveDownAction>(out MoveDownAction ca) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt2))
            {
                GetComponent<CraneStates>().MoveDown();
            }
            else if (ActiveAction.TryGetComponent<MagniteAction>(out MagniteAction sa) && ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt3))
            {
                gameObject.GetComponentInChildren<Animator>().gameObject.GetComponentInChildren<ParticleSystem>().Play();
                foreach (var a in GameObject.FindGameObjectsWithTag("MagniteObject"))
                {
                    a.GetComponent<MagnitePower>().power = power;
                    a.GetComponent<MagnitePower>().enabled = true;
                }
            }
        }
    }
    public void ButtonAction()
    {
        if (ActiveAction && ActiveTrigger)
        {
            if (ActiveAction.TryGetComponent<MoveUpAction>(out MoveUpAction oa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt1))
            {
                GetComponent<CraneStates>().MoveUp();
            }
            else if (ActiveAction.TryGetComponent<MoveDownAction>(out MoveDownAction ca) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt2))
            {
                GetComponent<CraneStates>().MoveDown();
            }
            else if (ActiveAction.TryGetComponent<MagniteAction>(out MagniteAction sa) && ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt3))
            {
                gameObject.GetComponentInChildren<Animator>().gameObject.GetComponentInChildren<ParticleSystem>().Play();
                foreach (var a in GameObject.FindGameObjectsWithTag("MagniteObject"))
                {
                    a.GetComponent<MagnitePower>().power = power;
                    a.GetComponent<MagnitePower>().enabled = true;
                }
            }
        }
    }
}
