using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveTrigger : Trigger
{

    public void acivateTrigger()
    {
        GetComponentInParent<ProgrammingSystem>().interactObject.GetComponent<BoxCollider>().enabled = true;
    }
}
