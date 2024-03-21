using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapCanvas : MonoBehaviour
{
    public bool isOpen = false;
    public GameObject map;
    public GameObject BG;
    public bool work = false;
    public KeyCode keyCode;
    // Start is called before the first frame update
    void Start()
    {
        BG.SetActive(false);
        if (SceneManager.GetActiveScene().buildIndex == 3 && EnterInFortress.lastScene == 4)
        {
            BG.SetActive(true);
            work = true;
        }
        if (SceneManager.GetActiveScene().buildIndex != 3)
        {
            BG.SetActive(true);
            work = true;
        }
        if (gameObject.name == "MapCanvas")
        {
            keyCode = KeyCode.M;
        }
        if (gameObject.name == "PaperCanvas")
        {
            keyCode = KeyCode.X;
        }
        if (gameObject.name == "GlossCanvas")
        {
            BG.SetActive(true);
            work = true;
            keyCode = KeyCode.Q;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!DialogSystem.dialogIsActive && work && gameObject.name == "GlossCanvas")
        {
            if (isOpen && Input.GetKeyDown(keyCode))
            {
                map.SetActive(false);
                BG.SetActive(true);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                isOpen = false;
            }
            else if (!isOpen && Input.GetKeyDown(keyCode))
            {
                map.SetActive(true);
                BG.SetActive(false);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                isOpen = true;
            }
        }
        else if (!DialogSystem.dialogIsActive && work)
        {
            if (isOpen && Input.GetKeyDown(keyCode))
            {
                map.SetActive(false);
                BG.SetActive(true);
                isOpen = false;
            }
            else if (!isOpen && Input.GetKeyDown(keyCode))
            {
                map.SetActive(true);
                BG.SetActive(false);
                isOpen = true;
            }
        }

        
        
    }
}
