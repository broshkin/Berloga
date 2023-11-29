public class CloseAction : Action
{
    public void activateAction()
    {
        GetComponentInParent<ProgrammingSystem>().interactObject.GetComponent<DoorActions>().ActiveAction = gameObject;
    }
}
