using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory: MonoBehaviour
{
    public GameObject inventory;
    // Start is called before the first frame update

    // Update is called once per frame
    public void Update()
    {
        if (DialogSystem.dialogIsActive)
        {
            inventory.SetActive(false);
        }
        else
        {
            inventory.SetActive(true);
        }
    }
    public void AddObject(GameObject obj)
    {
        foreach (var a in inventory.transform.GetComponentsInChildren<InventorySlot>())
        {
            if (a.isFree)
            {
                var b = Instantiate(obj, a.gameObject.transform);
                break;
            }
        }
    }
    public void RemoveObject()
    {
        foreach (var a in inventory.transform.GetComponentsInChildren<InventorySlot>())
        {
            if (!a.isFree)
            {
                Destroy(a.transform.GetChild(0));
                break;
            }
        }
        
    }
}
