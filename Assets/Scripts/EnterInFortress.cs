using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EnterInFortress : MonoBehaviour
{
    public GameObject canvas;
    private void Start()
    {
        canvas.SetActive(false);   
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canvas.SetActive(true);
            if (gameObject.tag == "FortressEnter")
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "����� � ����������\n������� ������� 'E'";
            }
            if (gameObject.tag == "FortressExit")
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "����� �� ����������\n������� ������� 'E'";
            }
            if (gameObject.tag == "AltarEnter")
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "����� � ������\n������� ������� 'E'";
            }
            if (gameObject.tag == "AltarExit")
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "����� �� ������\n������� ������� 'E'";
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canvas.SetActive(false);
        }
    }
    private void Update()
    {
        if (canvas.activeSelf)
        {    
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (gameObject.tag == "FortressEnter")
                {
                    SceneManager.LoadScene(4);
                }
                if (gameObject.tag == "FortressExit")
                {
                    SceneManager.LoadScene(3);
                }
                if (gameObject.tag == "AltarEnter")
                {
                    SceneManager.LoadScene(5);
                }
                if (gameObject.tag == "AltarExit")
                {
                    SceneManager.LoadScene(4);
                }
            }
        }
    }
}
