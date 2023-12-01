public class CloseAction : Action
{
    public void activateAction()
    {
        foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<DoorActions>())
        {
            if (act.id == GetComponentInParent<ProgrammingSystem>().id)
            {
                act.ActiveAction = gameObject;
                break;
            }
        }
        
    }
}
