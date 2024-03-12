using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var a = Random.Range(0.1f, 0.7f);
        transform.localScale = new Vector3(a, a, a);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
