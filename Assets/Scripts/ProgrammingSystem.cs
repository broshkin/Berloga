using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProgrammingSystem : MonoBehaviour
{
    public int id;

    public bool isTriggerActive = false;
    public GameObject ActiveTrigger = null;
    public bool isActionActive = false;
    public GameObject ActiveAction = null;
    public bool isParameterActive = false;
    public GameObject ActiveParameter = null;
    public bool isTriggerFull = false;
    public bool isActionFull = false;
    public bool isParameterFull = false;

    public GameObject TriggersView;

    public GameObject ActionsView;

    public GameObject ParametersView;

    public GameObject TriggerField;
    public GameObject ActionField;
    public GameObject ParameterField;

    public GameObject interactObject;

    public GameObject passwordParameter;

    public void Start()
    {
        TriggersView.SetActive(false); ActionsView.SetActive(false); passwordParameter.SetActive(false);
    }
    public  void OnTriggerClicked()
    {
        isTriggerActive = true;
        isActionActive = false;
        isParameterActive = false;
        SetViews();
    }
    public void OnActionClicked()
    {
        isTriggerActive = false;
        isActionActive = true;
        isParameterActive = false;
        SetViews();
    }
    public void OnParameterClicked()
    {
        isTriggerActive = false;
        isActionActive = false;
        isParameterActive = true;
        SetViews();
    }
    public void SetViews()
    {
        TriggersView.SetActive(isTriggerActive);
        ActionsView.SetActive(isActionActive);
        //ParametersView.SetActive(isParameterActive);
    }
    public void ApplyChanges()
    {
        if (ActiveAction && ActiveTrigger)
        {
            if (ActiveParameter)
            {
                if (ActiveParameter.TryGetComponent<PasswordParameter>(out PasswordParameter pp))
                {
                    pp.activateParameter();
                }
            }
            if (ActiveTrigger.TryGetComponent<AliveTrigger>(out AliveTrigger at))
            {
                at.acivateTrigger();
            }
            if (ActiveTrigger.TryGetComponent<PasswordTrigger>(out PasswordTrigger pt))
            {
                pt.activateTrigger();
            }
            if (ActiveAction.TryGetComponent<OpenAction>(out OpenAction oa))
            {
                oa.activateAction();
            }
            if (ActiveAction.TryGetComponent<CloseAction>(out CloseAction ca))
            {
                ca.activateAction();
            }
        }
    }
    public void ResetButton()
    {
        Destroy(ActiveTrigger);
        ActiveTrigger = null;
        Destroy(ActiveAction);
        ActiveAction = null;
        Destroy(ActiveParameter);
        ActiveParameter = null;
        interactObject.GetComponent<DoorActions>().ActiveTrigger = null;
        interactObject.GetComponent<DoorActions>().ActiveAction = null;
        interactObject.GetComponent<DoorActions>().ActiveParameter = null;
    }
}
