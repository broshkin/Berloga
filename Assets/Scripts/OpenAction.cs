using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAction : Action
{
    public void activateAction()
    {
        GetComponentInParent<ProgrammingSystem>().interactObject.GetComponent<DoorActions>().openDoorOnAlive = true;
    }
}
