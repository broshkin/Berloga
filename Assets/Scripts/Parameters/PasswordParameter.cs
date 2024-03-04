using TMPro;
using UnityEngine;

public class PasswordParameter : MonoBehaviour
{
    public void activateParameter()
    {
        var currentPsw = gameObject.GetComponentInChildren<TMP_InputField>().text;
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Door")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<DoorActions>())
            {
                if (act.id == GetComponentInParent<ProgrammingSystem>().id)
                {
                    act.realPassword = currentPsw;
                    break;
                }
            }
        }
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Car")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<CarActions>())
            {
                if (act.id == GetComponentInParent<ProgrammingSystem>().id)
                {
                    act.realPassword = currentPsw;
                    break;
                }
            }
        }
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Crane")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<CraneActions>())
            {
                if (act.id == GetComponentInParent<ProgrammingSystem>().id)
                {
                    act.realPassword = currentPsw;
                    break;
                }
            }
        }
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Portal")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<PortalActions>())
            {
                if (act.id == GetComponentInParent<ProgrammingSystem>().id)
                {
                    act.realPassword = currentPsw;
                    break;
                }
            }
        }
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Rover")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<RoverActions>())
            {
                if (act.id == GetComponentInParent<ProgrammingSystem>().id)
                {
                    act.realPassword = currentPsw;
                    break;
                }
            }
        }
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Mirror")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<MirrorActions>())
            {
                if (act.id == GetComponentInParent<ProgrammingSystem>().id)
                {
                    act.realPassword = currentPsw;
                    break;
                }
            }
        }
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Ship")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<ShipActions>())
            {
                if (act.id == GetComponentInParent<ProgrammingSystem>().id)
                {
                    act.realPassword = currentPsw;
                    break;
                }
            }
        }
    }
}
