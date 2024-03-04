using UnityEngine;

public class ShipActions : MonoBehaviour
{
    public int id;

    public GameObject ActiveTrigger = null;
    public GameObject ActiveAction = null;
    public GameObject ActiveParameter = null;

    public GameObject passwordCanvas;
    public GameObject buttonCanvas;

    public string realPassword;

    public void PushAction()
    {
        if (ActiveAction)
        {
            if (ActiveAction.TryGetComponent<ForwardMoveShipAction>(out ForwardMoveShipAction rmpx))
            {
                GetComponent<ShipStates>().requests.Add(0);
            }
        }
        if (ActiveAction)
        {
            if (ActiveAction.TryGetComponent<RightRotateShipAction>(out RightRotateShipAction fa))
            {
                GetComponent<ShipStates>().requests.Add(1);
            }
        }
        if (ActiveAction)
        {
            if (ActiveAction.TryGetComponent<LeftRotateShipAction>(out LeftRotateShipAction oa))
            {
                GetComponent<ShipStates>().requests.Add(2);
            }
        }

    }
}
