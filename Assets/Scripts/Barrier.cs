using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 150)
        {
            if (transform.position.z > -0.5f)
            {
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, -0.5f);
                }
            }
        }
        if (transform.position.z < -10)
        {
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -10);
            }
        }

    }
}
