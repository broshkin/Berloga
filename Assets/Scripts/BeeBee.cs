using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeBee : MonoBehaviour
{
    public GameObject firstBee;
    public GameObject secondBee;
    public GameObject firstDialog;
    public GameObject secondDialog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (artefactsManager.getBerry)
        {
            firstBee.SetActive(false);
            firstDialog.SetActive(false);
            secondBee.SetActive(true);
            secondDialog.SetActive(true);
        }
        else
        {
            firstBee.SetActive(true);
            firstDialog.SetActive(true);
            secondBee.SetActive(false);
            secondDialog.SetActive(false);
        }
    }
}
