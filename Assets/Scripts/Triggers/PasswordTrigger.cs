public class PasswordTrigger : Trigger
{
    public void activateTrigger()
    {
        var prgSys = GetComponentInParent<ProgrammingSystem>();
        var parameter = prgSys.ActiveParameter;
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Door")
        {
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
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Car")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<CarActions>())
            {
                if (act.id == GetComponentInParent<ProgrammingSystem>().id)
                {
                    act.ActiveTrigger = gameObject;
                    act.ActiveParameter = parameter;
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
                    act.ActiveTrigger = gameObject;
                    act.ActiveParameter = parameter;
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
                    act.ActiveTrigger = gameObject;
                    act.ActiveParameter = parameter;
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
                    act.ActiveTrigger = gameObject;
                    act.ActiveParameter = parameter;
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
                    act.ActiveTrigger = gameObject;
                    act.ActiveParameter = parameter;
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
                    act.ActiveTrigger = gameObject;
                    act.ActiveParameter = parameter;
                    break;
                }
            }
        }
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Poliv")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<PolivActions>())
            {
                if (act.id == GetComponentInParent<ProgrammingSystem>().id)
                {
                    act.ActiveTrigger = gameObject;
                    act.ActiveParameter = parameter;
                    break;
                }
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
