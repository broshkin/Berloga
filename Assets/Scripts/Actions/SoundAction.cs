public class SoundAction : Action
{
    public void activateAction()
    {
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Car")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<CarActions>())
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
