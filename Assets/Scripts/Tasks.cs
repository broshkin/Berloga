using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Tasks : MonoBehaviour
{
    public TextMeshProUGUI task;
    public List<string> tasks = new List<string>();
    public static int index;
    // Start is called before the first frame update
    void Start()
    {
        tasks.Add("Найти колёса");
        tasks.Add("Установить колёса на ось");
        tasks.Add("Найти Андрея");
        tasks.Add("Оправиться к вездеходу");
        tasks.Add("Добыть медоракт");
        tasks.Add("Направить луч на кристалл");
        tasks.Add("Отправиться к вездеходу");
        tasks.Add("Добыть серебряную рыбку");
        tasks.Add("Пройти лабиринт");
        tasks.Add("Отправиться к вездеходу");
        tasks.Add("Добыть веточку ягод");
        tasks.Add("Вырастить дерево");
        tasks.Add("Отправиться к вездеходу");
        tasks.Add("Установить артефакты");
        tasks.Add("Вернитесь на станцию");
        tasks.Add("Эвакуируйтесь");
    }
    public void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3 && DialogSystem.onceInFortress && !artefactsManager.getBerry)
        {
            index = 2;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3 && !DialogSystem.onceInFortress && !artefactsManager.getBerry)
        {
            index = 3;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4 && DialogSystem.onceInFortress && !artefactsManager.getBerry)
        {
            index = 2;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4 && !DialogSystem.onceInFortress && !artefactsManager.getBerry)
        {
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3 && artefactsManager.getBerry)
        {
            index = 13;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 4 && artefactsManager.getBerry)
        {
            index = 13;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5 && !artefactsManager.getBerry)
        {
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 5 && artefactsManager.getBerry)
        {
            index = 13;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 6 && !artefactsManager.getMedorakt)
        {
            index = 4;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 7 && !artefactsManager.getMedorakt)
        {
            index = 5;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 7 && artefactsManager.getMedorakt)
        {
            index = 6;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 6 && artefactsManager.getMedorakt)
        {
            index = 6;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 8 && !artefactsManager.getFish)
        {
            index = 7;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 9 && !artefactsManager.getFish)
        {
            index = 8;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 9 && artefactsManager.getFish)
        {
            index = 9;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 8 && artefactsManager.getFish)
        {
            index = 9;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 10 && !artefactsManager.getBerry)
        {
            index = 10;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 11 && !artefactsManager.getBerry)
        {
            index = 11;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 11 && artefactsManager.getBerry)
        {
            index = 12;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 10 && artefactsManager.getBerry)
        {
            index = 12;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            index = 14;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
        else
        {
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
    }

    public void SetTask()
    {
        Debug.Log(index);
        task.text = tasks[index];
    }
}
