public class AliveTrigger : Trigger
{

    public void acivateTrigger()
    {
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Door")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<DoorActions>())
            {
                if (act.id == GetComponentInParent<ProgrammingSystem>().id)
                {
                    act.ActiveTrigger = gameObject;
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
                    break;
                }
            }
        }
    }
}
