using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeBee : MonoBehaviour
{
    public GameObject firstBee;
    public GameObject secondBee;
    public GameObject firstDialog;
    // Start is called before the first frame update
    void Start()
    {
        if (DialogSystem.onceInFortress)
        {
            if (firstDialog)
            {
                firstDialog.SetActive(true);
            }
        }
        else
        {
            Destroy(firstDialog);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (artefactsManager.getBerry)
        {
            firstBee.SetActive(false);
            
            secondBee.SetActive(true);

        }     
        else
        {
            firstBee.SetActive(true);
            
            secondBee.SetActive(false);

        }
        if (DialogSystem.onceInFortress)
        {
            if (firstDialog)
            {
                firstDialog.SetActive(true);
            }
        }
        else
        {
            Destroy(firstDialog);
        }
    }
}
