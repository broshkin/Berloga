public class OpenAction : Action
{
    public void activateAction()
    {
        GetComponentInParent<ProgrammingSystem>().interactObject.GetComponent<DoorActions>().openDoorOnAlive = true;
    }
}
