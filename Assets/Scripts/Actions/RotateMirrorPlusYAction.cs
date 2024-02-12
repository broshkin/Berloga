public class RotateMirrorPlusYAction : Action
{
    public void activateAction()
    {
        if (GetComponentInParent<ProgrammingSystem>().interactObject.tag == "Mirror")
        {
            foreach (var act in GetComponentInParent<ProgrammingSystem>().interactObject.GetComponents<MirrorActions>())
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
