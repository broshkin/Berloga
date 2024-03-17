using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarArtefacts : MonoBehaviour
{
    public GameObject artefactCanvas;
    // Start is called before the first frame update
    public void Start()
    {
        if (artefactsManager.getBerry)
        {
            GetComponent<BoxCollider>().enabled = true;
        }
        else
        {
            GetComponent<BoxCollider>().enabled = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!artefactCanvas)
        {
            Destroy(gameObject);
        }
        if (other.tag == "Player")
        {
            artefactCanvas.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (!artefactCanvas)
        {
            Destroy(gameObject);
        }
        if (other.tag == "Player")
        {
            artefactCanvas.SetActive(false);
        }
    }
}
