using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpUs : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mirror1;
    public GameObject mirror2;

    void Start()
    {
        StartCoroutine(Help());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Help()
    {
        yield return new WaitForSeconds(120);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        DialogSystem.dialogNum = 37;
        GameObject.Find("DialogCanvas").GetComponent<DialogSystem>().ShowMessage();
    }
    public void PressYesOnMirrors()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        mirror1.transform.rotation = Quaternion.Euler(new Vector3(315, 0, 180));
        mirror2.transform.rotation = Quaternion.Euler(new Vector3(10, 225, 0));
        GameObject.Find("DialogCanvas").GetComponent<DialogSystem>().AfterClickDialog();
    }
    public void PressNoOnMirrors()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameObject.Find("DialogCanvas").GetComponent<DialogSystem>().AfterClickDialog();
        StartCoroutine(Help());
    }
    public void PressYesOnFish()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameObject.Find("Ship").GetComponent<ShipStates>().startPos = new Vector3(48.875f, 3.375f, -34.7290001f);
        GameObject.Find("Ship").transform.position = GameObject.Find("Ship").GetComponent<ShipStates>().startPos;
        GameObject.Find("Ship").transform.rotation = new Quaternion(0, 0, 0, 1);
        GameObject.Find("DialogCanvas").GetComponent<DialogSystem>().AfterClickDialog();
    }
    public void PressNoOnFish()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameObject.Find("DialogCanvas").GetComponent<DialogSystem>().AfterClickDialog();
        StartCoroutine(Help());
    }
    public void PressYesOnBerry()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        DialogSystem.dialogNum = 38;
        GameObject.Find("DialogCanvas").GetComponent<DialogSystem>().ShowMessage();
        
    }
    public void PressNoOnBerry()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameObject.Find("DialogCanvas").GetComponent<DialogSystem>().AfterClickDialog();
        StartCoroutine(Help());
    }
}
