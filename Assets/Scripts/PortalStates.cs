using UnityEngine;

public class PortalStates : MonoBehaviour
{
    public bool isActive = false;
    public bool Once = true;

    public void Activate()
    {
        if(!isActive)
        {
            isActive = true;
            GetComponent<AudioSource>().Play();
            GetComponent<Animator>().SetBool("activatePortal", true);        
        }
    }
    public void Deactivate()
    {
        if (isActive)
        {
            isActive = false;
            GetComponent<AudioSource>().Play();
            GetComponent<Animator>().SetBool("deactivatePortal", true);
        }
    }
    public void Update()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("activatePortal"))
        {
            GetComponent<Animator>().SetBool("activatePortal", false);
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("deactivatePortal"))
        {
            GetComponent<Animator>().SetBool("deactivatePortal", false);
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("activateStatus") && Once)
        {
            Once = false;
            DialogSystem.dialogNum = 2;
            GameObject.FindGameObjectWithTag("DialogObject").GetComponent<DialogSystem>().ShowMessage();
        }
    }
}
