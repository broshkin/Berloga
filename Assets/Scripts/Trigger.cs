using Mono.CompilerServices.SymbolWriter;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public string name;
    public Sprite icon;
    public int id;
    public bool isActive = false;

    public void Start()
    {
        if (gameObject.GetComponent<Button>() == null)
        {
            gameObject.AddComponent<Button>();
        }
        gameObject.GetComponentInChildren<TextMeshProUGUI>().text = name;
        gameObject.GetComponent<Image>().sprite = icon;
    }
    public void OnClickedTrigger()
    {
        isActive = true;
        var prgSys = gameObject.GetComponentInParent<ProgrammingSystem>();
        var triggerField = prgSys.TriggerField;
        var prefabTrigger = Instantiate(gameObject, triggerField.transform);
        prefabTrigger.GetComponent<Image>().color = Color.white;
        prefabTrigger.transform.localScale = Vector3.one / 2;
        prgSys.isTriggerFull = true;
    }    
}
