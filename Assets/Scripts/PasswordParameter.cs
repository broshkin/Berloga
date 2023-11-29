using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PasswordParameter : MonoBehaviour
{
    public void activateParameter()
    {
        var currentPsw = gameObject.GetComponentInChildren<TMP_InputField>().text;
        GetComponentInParent<ProgrammingSystem>().interactObject.GetComponent<DoorActions>().realPassword = currentPsw;
    }
}
