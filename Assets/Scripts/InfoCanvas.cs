using UnityEngine;

public class InfoCanvas : MonoBehaviour
{
    public bool isActive = false;
    public GameObject programmingSystem;
    public GameObject infoCanvas;

    public void Start()
    {
        programmingSystem.SetActive(false);
        infoCanvas.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log(other.gameObject.name);
            infoCanvas.SetActive(true);
            isActive = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            infoCanvas.SetActive(false);
            programmingSystem.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            isActive = false;
        }
    }

    public void Update()
    {
        if (isActive)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                programmingSystem.SetActive(true);
                Barrier.progIsOn = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}
