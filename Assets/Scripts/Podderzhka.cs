using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Podderzhka : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(random());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator random()
    {
        yield return new WaitForSeconds(Random.Range(30, 70));
        if (!DialogSystem.dialogIsActive)
        {
            DialogSystem.dialogNum = Random.Range(39, 42);
            GameObject.FindGameObjectWithTag("DialogObject").GetComponent<DialogSystem>().ShowMessage();
        }
        StartCoroutine(random());
    }
}
