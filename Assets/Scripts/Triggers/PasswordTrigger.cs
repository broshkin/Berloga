using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordTrigger : Trigger
{
    public void activateTrigger()
    {
        var prgSys = GetComponentInParent<ProgrammingSystem>();
        var parameter = prgSys.ActiveParameter;
        foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<DoorActions>())
        {
            if (act.id == GetComponentInParent<ProgrammingSystem>().id)
            {
                act.ActiveTrigger = gameObject;
                act.ActiveParameter = parameter;
                break;
            }
        }
    }
    public override void OnClickedTrigger()
    {
        base.OnClickedTrigger();
        GetComponentInParent<ProgrammingSystem>().ActiveParameter = Instantiate(GetComponentInParent<ProgrammingSystem>().passwordParameter, GetComponentInParent<ProgrammingSystem>().ParameterField.transform);
        GetComponentInParent<ProgrammingSystem>().ActiveParameter.SetActive(true);
    }
}
