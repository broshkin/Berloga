using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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
    public void OnClickedAction()
    {
        var prgSys = gameObject.GetComponentInParent<ProgrammingSystem>();
        if (prgSys.ActiveAction != gameObject)
        {
            var actionField = prgSys.ActionField;
            var prefabAction = Instantiate(gameObject, actionField.transform);
            prefabAction.GetComponent<Image>().color = Color.white;
            prefabAction.transform.localScale = Vector3.one / 2 * 1.5f;
            prefabAction.transform.localPosition = new Vector3(30, 10);
            prefabAction.GetComponent<Button>().enabled = false;
            prgSys.isActionFull = true;
            prgSys.ActiveAction = gameObject;
        }
    }

}
