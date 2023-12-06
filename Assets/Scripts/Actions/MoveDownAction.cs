using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownAction : Action
{
    public void activateAction()
    {
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Crane")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<CraneActions>())
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
