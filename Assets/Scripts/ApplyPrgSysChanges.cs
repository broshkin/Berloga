using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyPrgSysChanges : MonoBehaviour
{
    public ProgrammingSystem[] programmingSystems = null;

    public void OnClicked()
    {
        foreach (var programmingSystem in programmingSystems)
        {
            programmingSystem.gameObject.SetActive(true);
        }
        ApplyChanges();
    }
    public void ApplyChanges()
    {
        foreach (var prg in programmingSystems)
        {
            if (prg.ActiveAction && prg.ActiveTrigger)
            {
                if (prg.ActiveParameter)
                {
                    if (prg.ActiveParameter.TryGetComponent<PasswordParameter>(out PasswordParameter pp))
                    {
                        pp.activateParameter();
                    }
                    if (prg.ActiveParameter.TryGetComponent<ButtonParameter>(out ButtonParameter bp))
                    {
                        bp.activateParameter();
                    }
                }
                if (prg.ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
                {
                    at.acivateTrigger();
                }
                if (prg.ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
                {
                    pt.activateTrigger();
                }
                if (prg.ActiveTrigger.TryGetComponent<ButtonTrigger>(out ButtonTrigger bt))
                {
                    bt.activateTrigger();
                }
                if (prg.ActiveAction.TryGetComponent<OpenAction>(out OpenAction oa))
                {
                    oa.activateAction();
                }
                if (prg.ActiveAction.TryGetComponent<CloseAction>(out CloseAction ca))
                {
                    ca.activateAction();
                }
            }
        }
        
    }
}
