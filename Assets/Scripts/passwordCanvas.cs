using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
        }
    }
    public void OnClicked()
    {
        getpw = GetComponentInChildren<TMP_InputField>().text;
        interactObject.GetComponent<DoorActions>().PasswordAction(getpw);
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
    }
}
