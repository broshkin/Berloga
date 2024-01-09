using UnityEngine;
using UnityEngine.SceneManagement;

public class RoverStates : MonoBehaviour
{
    public bool isAddWheels = false;
    public bool Once = true;
    public bool isEngineActive = false;
    public GameObject finishCanvas;
    public GameObject finalCanvas;

    public void AddWheels()
    {
        if (!isAddWheels)
        {
            isAddWheels = true;
            GetComponent<Animator>().SetBool("addWheels", true);
        }
    }
    public void ActivateEngine()
    {
        GetComponent<AudioSource>().Play();
        isEngineActive = true;
        finishCanvas.SetActive(true);
    }
    public void DeactivateEngine()
    {
        GetComponent<AudioSource>().Stop();
        isEngineActive = false;
        finishCanvas.SetActive(false);
    }
    public void Update()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("roverAddWheels"))
        {
            GetComponent<Animator>().SetBool("addWheels", false);
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("roverWithWheelState") && Once)
        {
            Once = false;
            gameObject.GetComponent<BoxCollider>().enabled = true;
        }
        if (finishCanvas.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                SceneManager.LoadScene(3);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && isEngineActive)
        {
            finishCanvas.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && isEngineActive)
        {
            finishCanvas.SetActive(false);
        }
    }
}
