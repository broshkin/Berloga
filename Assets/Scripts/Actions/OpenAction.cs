public class OpenAction : Action
{
    public void activateAction()
    {
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Door")
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
}
