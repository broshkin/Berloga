using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapCanvas : MonoBehaviour
{
    public bool isOpen = false;
    public GameObject map;
    public GameObject mapBG;
    public GameObject BG;
    public bool work = false;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (!DialogSystem.dialogIsActive && work)
        {
            if (isOpen && Input.GetKeyDown(KeyCode.M))
            {
                map.SetActive(false);
                mapBG.SetActive(false);
                BG.SetActive(true);
                isOpen = false;
            }
            else if (!isOpen && Input.GetKeyDown(KeyCode.M))
            {
                map.SetActive(true);
                mapBG.SetActive(true);
                BG.SetActive(false);
                isOpen = true;
            }
        }
        
        
    }
}
