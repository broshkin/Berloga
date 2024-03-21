using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonSpeak : MonoBehaviour
{
    public bool once = true;
    // Start is called before the first frame update
    void Start()
    {
        DialogSystem.dialogNum = 42;
        GameObject.FindGameObjectWithTag("DialogObject").GetComponent<DialogSystem>().ShowMessage();
    }

    // Update is called once per frame
    void Update()
    {
        if (once && (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)))
        {
            once = false;
            DialogSystem.dialogNum = 44;
            GameObject.FindGameObjectWithTag("DialogObject").GetComponent<DialogSystem>().ShowMessage();
        }
        
    }
}
