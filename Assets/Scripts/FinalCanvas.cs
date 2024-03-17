using UnityEngine;

public class FinalCanvas : MonoBehaviour
{
    public GameObject[] images;
    public int index = 0;
    public GameObject leftButton;
    public GameObject rightButton;
    public GameObject leaveButton;
    // Start is called before the first frame update
    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        foreach (var a in images)
        {
            a.SetActive(false);
        }
        images[index].SetActive(true);
    }
    private void Update()
    {
        if (index == 0)
        {
            leftButton.SetActive(false);
            rightButton.SetActive(true);
            leaveButton.SetActive(false);
        }
        else if (index == images.Length - 1)
        {
            leftButton.SetActive(true);
            rightButton.SetActive(false);
            leaveButton.SetActive(true);
        }
        else
        {
            leftButton.SetActive(true);
            rightButton.SetActive(true);
            leaveButton.SetActive(false);
        }
    }
    public void OnClick()
    {
        Application.Quit();
    }
    public void MoveRight()
    {
        index++;
        foreach (var a in images)
        {
            a.SetActive(false);
        }
        images[index].SetActive(true);
    }
    public void MoveLeft()
    {
        index--;
        foreach (var a in images)
        {
            a.SetActive(false);
        }
        images[index].SetActive(true);
    }
}
