using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Data.Common;

public class PasswordParameter : MonoBehaviour
{
    public void activateParameter()
    {
        var currentPsw = gameObject.GetComponentInChildren<TMP_InputField>().text;
        foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<DoorActions>())
        {
            if (act.id == GetComponentInParent<ProgrammingSystem>().id)
            {
                act.realPassword = currentPsw;
                break;
            }
        }
    }
}
