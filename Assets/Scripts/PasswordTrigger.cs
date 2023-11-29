using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordTrigger : Trigger
{
    public void activateTrigger()
    {
        var prgSys = GetComponentInParent<ProgrammingSystem>();
        var parameter = prgSys.ActiveParameter;
        prgSys.interactObject.GetComponent<DoorActions>().ActiveTrigger = gameObject;
        prgSys.interactObject.GetComponent<DoorActions>().ActiveParameter = parameter;
    }
    public override void OnClickedTrigger()
    {
        base.OnClickedTrigger();
        GetComponentInParent<ProgrammingSystem>().ActiveParameter = Instantiate(GetComponentInParent<ProgrammingSystem>().passwordParameter, GetComponentInParent<ProgrammingSystem>().ParameterField.transform);
        GetComponentInParent<ProgrammingSystem>().ActiveParameter.SetActive(true);
    }
}
