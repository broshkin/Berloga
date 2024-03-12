using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MoveToArtefacts : MonoBehaviour
{
    public GameObject text;
    public int buildIndexToMove;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<BoxCollider>().enabled = false;
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (EnterInFortress.lastScene == 4 && SceneManager.GetActiveScene().buildIndex == 3)
        {
            text.GetComponent<TextMeshProUGUI>().text = "Отправиться за медорактом\nНажмите клавишу 'E'";
            gameObject.GetComponent<BoxCollider>().enabled = true;
            buildIndexToMove = 6;
        }
        if (artefactsManager.getMedorakt && SceneManager.GetActiveScene().buildIndex == 6)
        {
            text.GetComponent<TextMeshProUGUI>().text = "Отправиться за серебряной рыбкой\nНажмите клавишу 'E'";
            gameObject.GetComponent<BoxCollider>().enabled = true;
            buildIndexToMove = 8;
        }
        if (artefactsManager.getFish && SceneManager.GetActiveScene().buildIndex == 8)
        {
            text.GetComponent<TextMeshProUGUI>().text = "Отправиться за веточкой ягод\nНажмите клавишу 'E'";
            gameObject.GetComponent<BoxCollider>().enabled = true;
            buildIndexToMove = 10;
        }
        if (artefactsManager.getBerry && SceneManager.GetActiveScene().buildIndex == 10)
        {
            text.GetComponent<TextMeshProUGUI>().text = "Отправиться на базу\nНажмите клавишу 'E'";
            gameObject.GetComponent<BoxCollider>().enabled = true;
            buildIndexToMove = 3;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        canvas.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        canvas.SetActive(false);
    }
}
