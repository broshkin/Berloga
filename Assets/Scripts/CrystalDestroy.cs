using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalDestroy : MonoBehaviour
{
    private Material crystalMat;
    private float crystalIntensive = 0f;
    // Start is called before the first frame update
    void Start()
    {
        crystalMat = GetComponent<MeshRenderer>().material;
        crystalMat.SetColor("_EmissionColor", crystalMat.color * 0);
    }

    // Update is called once per frame
    public void AddLight()
    {
        crystalIntensive += 0.1f;
    }
    private void FixedUpdate()
    {
        if (crystalIntensive > 0)
        {
            crystalIntensive -= 0.05f;
        }
        crystalMat.SetColor("_EmissionColor", crystalMat.color * crystalIntensive);
        if (crystalIntensive >= 20)
        {
            Destroy(gameObject);
        }
    }
}
