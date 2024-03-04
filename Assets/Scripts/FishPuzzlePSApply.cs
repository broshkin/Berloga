using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FishPuzzlePSApply : MonoBehaviour
{
    public GameObject shipCanvasGameObject;
    public GameObject progSysPrefab;
    public GameObject ship;
    public GameObject buttonPrefab;
    public GameObject contentObject;
    public GameObject shipCanvas;

    void Start()
    {
        for (int i = 1; i < 36; i++)
        {
            var a = Instantiate(progSysPrefab, shipCanvasGameObject.transform);
            a.GetComponent<ProgrammingSystem>().id = i;
            a.GetComponent<ProgrammingSystem>().numText.text = i.ToString();
            a.GetComponent<ProgrammingSystem>().interactObject = ship;
            shipCanvas.GetComponent<ApplyPrgSysChanges>().programmingSystems.Add(a.GetComponent<ProgrammingSystem>());
            var b = ship.AddComponent<ShipActions>();
            b.id = i;
        }

        for (int i = 1; i < 36; i++)
        {
            var a = Instantiate(buttonPrefab, contentObject.transform);
            a.transform.position = new Vector3(a.transform.position.x + 120 * (i - 1), a.transform.position.y, a.transform.position.z);
            a.GetComponentInChildren<TextMeshProUGUI>().text = i.ToString();
            foreach (var b in shipCanvas.GetComponent<ApplyPrgSysChanges>().programmingSystems)
            {
                if (i != Convert.ToInt32(b.id))
                {
                    a.GetComponent<Button>().onClick.AddListener(delegate { DeactivateObject(b); });
                }
                else
                {
                    a.GetComponent<Button>().onClick.AddListener(delegate { ActivateObject(b); });
                }
            }
        }
    }

    void DeactivateObject(ProgrammingSystem ab)
    {
        ab.gameObject.SetActive(false);
    }
    void ActivateObject(ProgrammingSystem ab)
    {
        ab.gameObject.SetActive(true);
    }
}
