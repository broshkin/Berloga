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

    }
}
