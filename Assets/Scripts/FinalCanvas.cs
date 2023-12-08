using UnityEngine;

public class FinalCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void OnClick()
    {
        Application.Quit();
    }
}
