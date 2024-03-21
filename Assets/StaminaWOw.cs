using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaWOw : MonoBehaviour
{
    public GameObject stamina;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (stamina.GetComponent<Slider>().value == 200)
        {
            StartCoroutine(staminchik());
        }
    }
    IEnumerator staminchik()
    {
        stamina.transform.localScale = new Vector3(0, 0, 0);
        yield return new WaitWhile(() => stamina.GetComponent<Slider>().value == 200);
        stamina.transform.localScale = new Vector3(2.5f, 5, 5);
    }
}
