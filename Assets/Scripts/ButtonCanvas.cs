using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonCanvas : MonoBehaviour
{
    public GameObject interactObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (interactObject.tag == "Door")
            {
                foreach (var da in interactObject.GetComponents<DoorActions>())
                {
                    da.ButtonAction();
                }
            }
            if (interactObject.tag == "Car")
            {
                foreach (var ca in interactObject.GetComponents<CarActions>())
                {
                    ca.ButtonAction();
                }
            }
            if (interactObject.tag == "Crane")
            {
                foreach (var cra in interactObject.GetComponents<CraneActions>())
                {
                    cra.ButtonAction();
                }
            }
            if (interactObject.tag == "Portal")
            {
                foreach (var pa in interactObject.GetComponents<PortalActions>())
                {
                    pa.ButtonAction();
                }
            }
            gameObject.SetActive(false);
        }
    }
}
