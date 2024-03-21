using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Andreys : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject open;
    public GameObject close;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!artefactsManager.getBerry)
        {
            open.SetActive(true);
            close.SetActive(false);
        }
        else
        {
            open.SetActive(false);
            close.SetActive(true);
        }
    }
}
