using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetArtefactCanvas : MonoBehaviour
{
    public GameObject artefact;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (artefact.name == "Cube")
            {
                artefactsManager.getMedorakt = true;
            }
            if (artefact.name == "untitled.blenduuuuu")
            {
                artefactsManager.getBerry = true;
            }
            artefact.GetComponent<Artefact>().canvas.SetActive(false);
            Destroy(artefact);
        }
    }
}
