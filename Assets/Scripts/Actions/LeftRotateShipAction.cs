public class LeftRotateShipAction : Action
{
    public void activateAction()
    {
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Ship")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<ShipActions>())
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
