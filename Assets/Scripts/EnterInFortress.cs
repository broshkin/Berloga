using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EnterInFortress : MonoBehaviour
{
    public GameObject canvas;
    public static int lastScene;
    public bool inZone = false;
    private void Start()
    {
        canvas.SetActive(false);   
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            inZone = true;
            if (gameObject.tag == "FortressEnter")
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "Войти в подземелье\nНажмите клавишу 'E'";
                canvas.SetActive(true);
            }
            if (gameObject.tag == "FortressExit")
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "Выйти из подземелья\nНажмите клавишу 'E'";
                canvas.SetActive(true);
            }
            if (gameObject.tag == "AltarEnter")
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "Войти в алтарь\nНажмите клавишу 'E'";
                canvas.SetActive(true);
            }
            if (gameObject.tag == "AltarExit")
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "Выйти из алтаря\nНажмите клавишу 'E'";
                canvas.SetActive(true);
            }
            if (SceneManager.GetActiveScene().buildIndex == 6 && !artefactsManager.getMedorakt)
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "Войти в подземелье\nНажмите клавишу 'E'";
                canvas.SetActive(true);
            }
            if (SceneManager.GetActiveScene().buildIndex == 7)
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "Выйти из подземелья\nНажмите клавишу 'E'";
                canvas.SetActive(true);
            }
            if (SceneManager.GetActiveScene().buildIndex == 8 && !artefactsManager.getFish)
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "Войти в подземелье\nНажмите клавишу 'E'";
                canvas.SetActive(true);
            }
            if (SceneManager.GetActiveScene().buildIndex == 9)
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "Выйти из подземелья\nНажмите клавишу 'E'";
                canvas.SetActive(true);
            }
            if (SceneManager.GetActiveScene().buildIndex == 10 && !artefactsManager.getBerry)
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "Войти в подземелье\nНажмите клавишу 'E'";
                canvas.SetActive(true);
            }
            if (SceneManager.GetActiveScene().buildIndex == 11)
            {
                canvas.GetComponentInChildren<TextMeshProUGUI>().text = "Выйти из подземелья\nНажмите клавишу 'E'";
                canvas.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inZone = false;
            canvas.SetActive(false);
        }
    }
    private void Update()
    {
        if (canvas.activeSelf)
        {    
            if (Input.GetKeyDown(KeyCode.E) && inZone)
            {
                if (gameObject.tag == "FortressEnter")
                {
                    lastScene = 3;
                    SceneManager.LoadScene(4);
                }
                if (gameObject.tag == "FortressExit")
                {
                    lastScene = 4;
                    SceneManager.LoadScene(3);
                }
                if (gameObject.tag == "AltarEnter")
                {
                    SceneManager.LoadScene(5);
                }
                if (gameObject.tag == "AltarExit")
                {
                    lastScene = 5;
                    SceneManager.LoadScene(4);
                }
                if (SceneManager.GetActiveScene().buildIndex == 6 && !artefactsManager.getMedorakt)
                {
                    lastScene = 6;
                    SceneManager.LoadScene(7);
                }
                if (SceneManager.GetActiveScene().buildIndex == 7)
                {
                    lastScene = 7;
                    SceneManager.LoadScene(6);
                }
                if (SceneManager.GetActiveScene().buildIndex == 8 && !artefactsManager.getFish)
                {
                    lastScene = 8;
                    SceneManager.LoadScene(9);
                }
                if (SceneManager.GetActiveScene().buildIndex == 9)
                {
                    lastScene = 9;
                    SceneManager.LoadScene(8);
                }
                if (SceneManager.GetActiveScene().buildIndex == 10 && !artefactsManager.getBerry)
                {
                    lastScene = 10;
                    SceneManager.LoadScene(11);
                }
                if (SceneManager.GetActiveScene().buildIndex == 11)
                {
                    lastScene = 11;
                    SceneManager.LoadScene(10);
                }
            }
        }
    }
}
