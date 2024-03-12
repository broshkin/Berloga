using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artefact : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canvas.SetActive(true);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canvas.SetActive(false);
        } 
    }
}
