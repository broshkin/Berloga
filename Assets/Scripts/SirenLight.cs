using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SirenLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LightChanger());
    }

    // Update is called once per frame
    IEnumerator LightChanger()
    {
        yield return new WaitForSeconds(1);
        GetComponentInChildren<Light>().enabled = false;
        GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
        yield return new WaitForSeconds(1);
        GetComponentInChildren<Light>().enabled = true;
        GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
        StartCoroutine(LightChanger());
    }
}
