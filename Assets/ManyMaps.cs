using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManyMaps : MonoBehaviour
{
    public GameObject[] maps;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            foreach (var a in maps)
            {
                if (a.name == "MapCanvas")
                {
                    a.transform.GetChild(0).gameObject.SetActive(!a.transform.GetChild(0).gameObject.activeSelf);
                    a.transform.GetChild(1).gameObject.SetActive(!a.transform.GetChild(0).gameObject.activeSelf);
                }
                else
                {
                    a.transform.GetChild(0).gameObject.SetActive(false);
                    a.transform.GetChild(1).gameObject.SetActive(true);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            foreach (var a in maps)
            {
                if (a.name == "PaperCanvas")
                {
                    a.transform.GetChild(0).gameObject.SetActive(!a.transform.GetChild(0).gameObject.activeSelf);
                    a.transform.GetChild(1).gameObject.SetActive(!a.transform.GetChild(0).gameObject.activeSelf);
                }
                else
                {
                    a.transform.GetChild(0).gameObject.SetActive(false);
                    a.transform.GetChild(1).gameObject.SetActive(true);
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach (var a in maps)
            {
                if (a.name == "GlossCanvas")
                {
                    if (a.transform.GetChild(0).gameObject.activeSelf)
                    {
                        Cursor.lockState = CursorLockMode.Locked;
                        Cursor.visible = false;
                    }
                    else
                    {
                        Cursor.lockState = CursorLockMode.None;
                        Cursor.visible = true;
                    }
                    
                    a.transform.GetChild(0).gameObject.SetActive(!a.transform.GetChild(0).gameObject.activeSelf);
                    a.transform.GetChild(1).gameObject.SetActive(!a.transform.GetChild(0).gameObject.activeSelf);
                }
                else
                {
                    a.transform.GetChild(0).gameObject.SetActive(false);
                    a.transform.GetChild(1).gameObject.SetActive(true);
                }
            }
        }
    }
}
