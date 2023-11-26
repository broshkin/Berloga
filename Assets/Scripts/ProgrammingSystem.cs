using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProgrammingSystem : MonoBehaviour
{
    public bool isTriggerActive = false;
    public bool isActionActive = false;
    public bool isParameterActive = false;
    public GameObject TriggersView;
    public GameObject ActionsView;
    public GameObject ParametersView;
    // Start is called before the first frame update
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
        ParametersView.SetActive(isParameterActive);
    }    
}
