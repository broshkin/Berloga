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
            foreach (var da in interactObject.GetComponents<DoorActions>())
            {
                da.ButtonAction();
            }
            gameObject.SetActive(false);
        }
    }
}
