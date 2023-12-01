using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliveTrigger : Trigger
{

    public void acivateTrigger()
    {
        foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<DoorActions>())
        {
            if (act.id == GetComponentInParent<ProgrammingSystem>().id)
            {
                act.ActiveTrigger = gameObject;
                break;
            }
        }
    }
}
