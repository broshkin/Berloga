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
            if (transform.position.z > 45)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 45);
            }
            if (transform.position.z < 9)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 9);
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
        if (SceneManager.GetActiveScene().name == "Demo 4")
        {
            if (transform.position.z < -16)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -16);
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 7)
        {

            if (transform.position.x < 13.8719f)
            {
                transform.position = new Vector3(13.8719f, transform.position.y, transform.position.z);
            }

        }
        if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            if (transform.position.z > -23.5f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -23.5f);
            }
        }
        if(SceneManager.GetActiveScene().buildIndex == 6 || SceneManager.GetActiveScene().buildIndex == 8 || SceneManager.GetActiveScene().buildIndex == 10)
        {
            if (transform.position.z > 105.5f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 105.5f);
            }
            if (transform.position.z < 99.42f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 99.42f);
            }
            if (transform.position.x < 268.01f)
            {
                transform.position = new Vector3(268.01f, transform.position.y, transform.position.z);
            }
            if (transform.position.x > 297.17f)
            {
                transform.position = new Vector3(297.17f, transform.position.y, transform.position.z);
            }
        }

    }
}
