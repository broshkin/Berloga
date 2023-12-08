using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstallWheel : MonoBehaviour
{
    public GameObject wheelCanvas;
    public bool wheelArePicked = false;
    private void OnTriggerEnter(Collider other)
    {
        if (wheelArePicked && other.tag == "Player")
        {
            wheelCanvas.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            wheelCanvas.SetActive(false);
        }
    }
    public void Update()
    {
        if (wheelCanvas.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameObject.Find("Car 4").GetComponent<RoverStates>().AddWheels();
                Destroy(wheelCanvas);
                Destroy(gameObject);
            }
        }
    }
}
