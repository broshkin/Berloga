using UnityEngine;
using UnityEngine.SceneManagement;

public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            if (transform.position.x < 150)
            {
                if (transform.position.z > -0.5f)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, -0.5f);
                }
            }
            if (transform.position.z < -10)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -10);
            }
        }
        if (SceneManager.GetActiveScene().name == "Demo 1")
        {
            if (transform.position.z > 30)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 30);
            }
            if (transform.position.z < 12)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 12);
            }
            if (transform.position.x < -30)
            {
                transform.position = new Vector3(-30, transform.position.y, transform.position.z);
            }
            if (transform.position.x > 25)
            {
                transform.position = new Vector3(25, transform.position.y, transform.position.z);
            }
        }
        if (SceneManager.GetActiveScene().name == "Demo 2")
        {
            if (transform.position.z > 100)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 100);
            }
            if (transform.position.z < 85)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 85);
            }
            if (transform.position.x < 267)
            {
                transform.position = new Vector3(267, transform.position.y, transform.position.z);
            }
            if (transform.position.x > 367)
            {
                transform.position = new Vector3(367, transform.position.y, transform.position.z);
            }
        }
        if (SceneManager.GetActiveScene().name == "Demo 3")
        {
            if (transform.position.z > 2)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 2);
            }
            if (transform.position.z < -8)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -8);
            }
            if (transform.position.x < -8)
            {
                transform.position = new Vector3(-8, transform.position.y, transform.position.z);
            }
            if (transform.position.x > 2)
            {
                transform.position = new Vector3(2, transform.position.y, transform.position.z);
            }
        }

    }
}
