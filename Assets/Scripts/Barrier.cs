using UnityEngine;
using UnityEngine.SceneManagement;

public class Barrier : MonoBehaviour
{
    private GameObject menu;
    private GameObject settings;
    private Vector3 startPos;
    public static bool progIsOn = false;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        menu = GameObject.Find("PAPA").transform.GetChild(0).gameObject;
        settings = GameObject.Find("PAPA").transform.GetChild(1).gameObject;
        menu.SetActive(false);
    }
    

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape) && !menu.activeSelf && !progIsOn && !settings.activeSelf && !DialogSystem.dialogIsActive)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            menu.SetActive(true);
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && (menu.activeSelf || settings.activeSelf))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            menu.SetActive(false);
            settings.SetActive(false);
            Time.timeScale = 1;
        }

        if (transform.position.y < -20)
        {
            transform.position = startPos;
        }

        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            if (transform.position.x < 150)
            {
                if (transform.position.z > -0.5f)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, -0.5f);
                }
            }
            if (transform.position.z < -10)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -10);
            }
        }
        if (SceneManager.GetActiveScene().name == "SampleScene 1")
        {
            if (transform.position.x > 150)
            {
                if (transform.position.z < -12f)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, -12f);
                }
            }
            if (transform.position.z < -20)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -20);
            }
        }
        if (SceneManager.GetActiveScene().name == "Demo 1")
        {
            if (transform.position.z > 45)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 45);
            }
            if (transform.position.z < 9)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 9);
            }
        }
        if (SceneManager.GetActiveScene().name == "Demo 2")
        {
            if (transform.position.z > 100)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 100);
            }
            if (transform.position.z < 54.66f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 54.66f);
            }
            if (transform.position.x < 267)
            {
                transform.position = new Vector3(267, transform.position.y, transform.position.z);
            }
            if (transform.position.x > 367)
            {
                transform.position = new Vector3(367, transform.position.y, transform.position.z);
            }
        }
        if (SceneManager.GetActiveScene().name == "Demo 3")
        {
            if (transform.position.z > 2)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 2);
            }
            if (transform.position.z < -8)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -8);
            }
            if (transform.position.x < -8)
            {
                transform.position = new Vector3(-8, transform.position.y, transform.position.z);
            }
            if (transform.position.x > 2)
            {
                transform.position = new Vector3(2, transform.position.y, transform.position.z);
            }
        }
        if (SceneManager.GetActiveScene().name == "Demo 4")
        {
            if (transform.position.z < -16)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -16);
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 7)
        {

            if (transform.position.x < 13.8719f)
            {
                transform.position = new Vector3(13.8719f, transform.position.y, transform.position.z);
            }

        }
        if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            if (transform.position.z > -23.5f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -23.5f);
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 6 || SceneManager.GetActiveScene().buildIndex == 8 || SceneManager.GetActiveScene().buildIndex == 10)
        {
            if (transform.position.z > 105.5f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 105.5f);
            }
            if (transform.position.z < 99.42f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 99.42f);
            }
            if (transform.position.x < 268.01f)
            {
                transform.position = new Vector3(268.01f, transform.position.y, transform.position.z);
            }
            if (transform.position.x > 297.17f)
            {
                transform.position = new Vector3(297.17f, transform.position.y, transform.position.z);
            }
        }

    }
}
