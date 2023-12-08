using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public string name;
    public Sprite icon;
    public int id;
    public bool withParameters = false;

    public void Start()
    {
        if (gameObject.GetComponent<Button>() == null)
        {
            gameObject.AddComponent<Button>();
        }
        gameObject.GetComponentInChildren<TextMeshProUGUI>().text = name;
        gameObject.GetComponent<Image>().sprite = icon;
    }
    public virtual void OnClickedTrigger()
    {
        var prgSys = gameObject.GetComponentInParent<ProgrammingSystem>();
        if (prgSys.ActiveTrigger != gameObject)
        {
            var triggerField = prgSys.TriggerField;
            Destroy(prgSys.ActiveTrigger);
            prgSys.ActiveTrigger = null;
            Destroy(prgSys.ActiveParameter);
            prgSys.ActiveParameter = null;
            var prefabTrigger = Instantiate(gameObject, triggerField.transform);
            prefabTrigger.GetComponent<Image>().color = Color.white;
            prefabTrigger.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
            prefabTrigger.transform.localScale = Vector3.one / 2 * 1.5f;
            prefabTrigger.transform.localPosition = new Vector3(0, 10);
            prefabTrigger.GetComponent<Button>().enabled = false;
            prgSys.isTriggerFull = true;
            prgSys.ActiveTrigger = prefabTrigger;
        }
    }    
}
