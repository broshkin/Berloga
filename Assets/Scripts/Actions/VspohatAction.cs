using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VspohatAction : Action
{
    public void activateAction()
    {
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Poliv")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<PolivActions>())
            {
                if (act.id == GetComponentInParent<ProgrammingSystem>().id)
                {
                    act.ActiveAction = gameObject;
                    break;
                }
            }
        }
    }
}

