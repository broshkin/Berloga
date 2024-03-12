using TMPro;
using UnityEngine;

public class passwordCanvas : MonoBehaviour
{
    public string getpw;
    public GameObject interactObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    public void OnClicked()
    {
        getpw = GetComponentInChildren<TMP_InputField>().text;
        if (interactObject.tag == "Door")
        {
            foreach (var da in interactObject.GetComponents<DoorActions>())
            {
                da.PasswordAction(getpw);
            }
        }
        if (interactObject.tag == "Car")
        {
            foreach (var da in interactObject.GetComponents<CarActions>())
            {
                da.PasswordAction(getpw);
            }
        }
        if (interactObject.tag == "Crane")
        {
            foreach (var da in interactObject.GetComponents<CraneActions>())
            {
                da.PasswordAction(getpw);
            }
        }
        if (interactObject.tag == "Portal")
        {
            foreach (var da in interactObject.GetComponents<PortalActions>())
            {
                da.PasswordAction(getpw);
            }
        }
        if (interactObject.tag == "Rover")
        {
            foreach (var da in interactObject.GetComponents<RoverActions>())
            {
                da.PasswordAction(getpw);
            }
        }
        if (interactObject.tag == "Mirror")
        {
            foreach (var da in interactObject.GetComponents<MirrorActions>())
            {
                da.PasswordAction(getpw);
            }
        }
        if (interactObject.tag == "Poliv")
        {
            foreach (var da in interactObject.GetComponents<PolivActions>())
            {
                da.PasswordAction(getpw);
            }
            interactObject.GetComponent<PolivStates>().CoroutineActivating();
        }
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
