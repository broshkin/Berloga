using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Action : MonoBehaviour
{
    public string name;
    public Sprite icon;
    public int id;

    public void Start()
    {
        if (gameObject.GetComponent<Button>() == null)
        {
            gameObject.AddComponent<Button>();
        }
        gameObject.GetComponentInChildren<TextMeshProUGUI>().text = name;
        gameObject.GetComponent<Image>().sprite = icon;
    }
    public virtual void OnClickedAction()
    {
        var prgSys = gameObject.GetComponentInParent<ProgrammingSystem>();
        if (prgSys.ActiveAction != null)
        {
            GetComponentInParent<ApplyPrgSysChanges>().ResetActions(prgSys.ActiveAction.name.Split('(')[0]);
        }
        if (prgSys.ActiveAction != gameObject)
        {
            var actionField = prgSys.ActionField;
            Destroy(prgSys.ActiveAction);
            prgSys.ActiveAction = null;
            var prefabAction = Instantiate(gameObject, actionField.transform);
            prefabAction.GetComponent<Image>().color = Color.white;
            prefabAction.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
            prefabAction.transform.localScale = Vector3.one / 2 * 1.5f;
            prefabAction.transform.localPosition = new Vector3(0, 10);
            prefabAction.GetComponent<Button>().enabled = false;
            prgSys.isActionFull = true;
            prgSys.ActiveAction = prefabAction;
            GetComponentInParent<ApplyPrgSysChanges>().ApplyActions();
        }
    }

}
