public class ActivatePortalAction : Action
{
    public void activateAction()
    {
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Portal")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<PortalActions>())
            {
                if (act.id == GetComponentInParent<ProgrammingSystem>().id)
                {
                    act.ActiveAction = gameObject;
                    break;
                }
            }
        }
    }
}
