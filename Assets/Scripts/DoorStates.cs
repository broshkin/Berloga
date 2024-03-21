using UnityEngine;

public class DoorStates : MonoBehaviour
{
    public bool doorIsOpen = false;
    public bool once = true;
    public bool twice = true;
    public bool triple = true;
    public bool quadro = true;

    public void Start()
    {
        GetComponent<BoxCollider>().enabled = true;
        if (gameObject.name == "Future_Door_Final (2)" || gameObject.name == "Future_Door_Final (3)")
        {
            once = false;
            twice = false;
            triple = false;
            quadro = false;
        }
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
        if (doorIsOpen && twice)
        {
            DialogSystem.dialogNum = 47;
            GameObject.FindGameObjectWithTag("DialogObject").GetComponent<DialogSystem>().ShowMessage();
            twice = false;
        }
        if (!twice && triple && Input.GetKeyDown(KeyCode.LeftShift))
        {
            DialogSystem.dialogNum = 48;
            GameObject.FindGameObjectWithTag("DialogObject").GetComponent<DialogSystem>().ShowMessage();
            triple = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && once)
        {
            DialogSystem.dialogNum = 45;
            GameObject.FindGameObjectWithTag("DialogObject").GetComponent<DialogSystem>().ShowMessage();
            once = false;
        }
    }
}
