using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterInFortress : MonoBehaviour
{
    public GameObject canvas;
    private void Start()
    {
        canvas.SetActive(false);   
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canvas.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canvas.SetActive(false);
        }
    }
    private void Update()
    {
        if (canvas.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("Demo 3");
            }
        }
    }
}
