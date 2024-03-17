using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtefactActivate : MonoBehaviour
{
    public GameObject[] artefacts;
    public GameObject portal;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            foreach (var a in artefacts)
            {
                a.SetActive(true);
            }
            portal.GetComponent<Animator>().enabled = true;
            portal.GetComponentInParent<AudioSource>().Play();
            portal.GetComponent<BoxCollider>().enabled = true;
            Destroy(gameObject);
        }
    }
}
