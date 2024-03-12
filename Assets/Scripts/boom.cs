using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-20, 20), Random.Range(-20, 20), Random.Range(-20, 20)), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
