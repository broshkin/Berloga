using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplyPrgSysChanges : MonoBehaviour
{
    public ProgrammingSystem[] programmingSystems = null;
    public List<string> actionComponents = null;

    public void OnClicked()
    {
        foreach (var programmingSystem in programmingSystems)
        {
            programmingSystem.gameObject.SetActive(true);
        }
        ApplyChanges();
        foreach (var programmingSystem in programmingSystems)
        {
            programmingSystem.gameObject.SetActive(false);
        }
    }
    public void ApplyActions()
    {
        foreach (var programmingSystem in  programmingSystems)
        {
            if (programmingSystem.ActiveAction != null)
            {
                actionComponents.Add(programmingSystem.ActiveAction.name.Split('(')[0]);
            }
            
        }
        foreach (var programmingSystem in programmingSystems)
        {
            var a = programmingSystem.ActionsView.transform.GetChild(0).transform.GetChild(0).transform.childCount;
            for (int i = 0; i < a; i++)
            {
                foreach (var aa in actionComponents)
                {
                    if (programmingSystem.ActionsView.transform.GetChild(0).transform.GetChild(0).transform.GetChild(i).GetComponent(aa))
                    {
                        programmingSystem.ActionsView.transform.GetChild(0).transform.GetChild(0).transform.GetChild(i).GetComponent<Image>().color = Color.gray;
                        programmingSystem.ActionsView.transform.GetChild(0).transform.GetChild(0).transform.GetChild(i).GetComponent<Button>().enabled = false;
                    }
                }
                
            }
        }
        actionComponents.Clear();
    }
    public void ResetActions(string name)
    {
        foreach (var programmingSystem in programmingSystems)
        {
            var a = programmingSystem.ActionsView.transform.GetChild(0).transform.GetChild(0).transform.childCount;
            for (int i = 0; i < a; i++)
            {
                if (programmingSystem.ActionsView.transform.GetChild(0).transform.GetChild(0).transform.GetChild(i).GetComponent(name))
                {
                    programmingSystem.ActionsView.transform.GetChild(0).transform.GetChild(0).transform.GetChild(i).GetComponent<Image>().color = Color.white;
                    programmingSystem.ActionsView.transform.GetChild(0).transform.GetChild(0).transform.GetChild(i).GetComponent<Button>().enabled = true;
                }
            }
        }
    }
    public void ApplyChanges()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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
                if (prg.ActiveAction.TryGetComponent<ForwardAction>(out ForwardAction fa))
                {
                    fa.activateAction();
                }
                if (prg.ActiveAction.TryGetComponent<BackAction>(out BackAction ba))
                {
                    ba.activateAction();
                }
                if (prg.ActiveAction.TryGetComponent<SoundAction>(out SoundAction sa))
                {
                    sa.activateAction();
                }
                if (prg.ActiveAction.TryGetComponent<MoveUpAction>(out MoveUpAction mua))
                {
                    mua.activateAction();
                }
                if (prg.ActiveAction.TryGetComponent<MoveDownAction>(out MoveDownAction mda))
                {
                    mda.activateAction();
                }
                if (prg.ActiveAction.TryGetComponent<MagniteAction>(out MagniteAction ma))
                {
                    ma.activateAction();
                }
                if (prg.ActiveAction.TryGetComponent<ActivatePortalAction>(out ActivatePortalAction apa))
                {
                    apa.activateAction();
                }
                if (prg.ActiveAction.TryGetComponent<DeactivatePortalAction>(out DeactivatePortalAction dpa))
                {
                    dpa.activateAction();
                }
                if (prg.ActiveAction.TryGetComponent<ActivateEngineAction>(out ActivateEngineAction aea))
                {
                    aea.activateAction();
                }
                if (prg.ActiveAction.TryGetComponent<DeactivateEngineAction>(out DeactivateEngineAction dea))
                {
                    dea.activateAction();
                }
            }
        }
        
    }
}
