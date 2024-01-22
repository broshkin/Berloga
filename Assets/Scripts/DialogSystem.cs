using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogSystem : MonoBehaviour
{
    public static int dialogNum = 0;

    public static bool dialogIsActive = false;

    public static bool isAssistent = false;
    public static bool isAdmin = false;
    public static bool isArtemiy = false;
    public static bool isAndrey = false;
    public static bool isSecondAndrey = false;
    public static bool isMain = false;
    public static bool onceInFortress = true;

    public GameObject assistent;
    public GameObject admin;
    public GameObject artemiy;
    public GameObject andrey;
    public GameObject secondAndrey;
    public GameObject main;

    private static List<string> messages = new List<string>();

    public TextMeshProUGUI showableText;

    public GameObject player;

    public GameObject openableDoor;

    public GameObject textBG;
    // Start is called before the first frame update
    public void Start()
    {
        textBG.SetActive(false);
        messages.Add("Григорий, здравствуйте! Меня зовут Полина, я новый ассистент станции МЁД-1103. Вас срочно вызывает начальство к аппарату связи!");
        messages.Add("Гриш, привет! Тут одно дело появилось, у нас на планете BEAR-2023 сломался вездеход, его необходимо починить. Ты не переживай, с тобой будет наш первопроходец - Андрей. Он сходит за ним, а тебе всего лишь отремонтировать его на станции, только, пожалуйста, включи ему портал, а то он совсем не умеет им пользоваться. Спасибо!");
        messages.Add("Привет! Я Андрей, первопроходец, я так полагаю, ты Гриша, ну что ж, сейчас я мигом схожу за вездеходом и принесу его, благо на этой планете есть атмосфера, даже скафандр не пригодится!");
        messages.Add("*Хе-хе-хе-хе*");
        messages.Add("*Подкрадывается сзаде и толкает в портал*");
        messages.Add("Где я? Кто меня сюда толкнул? Куда делся Андрей? Что вообще случилось? Вездеход почти целый, кто его успел восстановить? Так, осталось найти колёса и срочно искать Андрея!");
        messages.Add("А вот и колёса! Почему они так аккуратно укрыты? Ладно, сейчас надо действовать. Осталось закрепить их на передней оси вездехода.");
        messages.Add("Вот мы и снова увиделись...");
        messages.Add("Я думал, что ко мне уже никто не придёт...");
        messages.Add("Я уже больше года ошиваюсь на этой планете и пытаюсь найти выход отсюда. В следующей комнате находится портал, через него можно вернуться на станцию.");
        messages.Add("Но для его работы необходимо добыть три артефакта.");
        messages.Add("Вот карта с их местоположениями. Всё это время я составлял её.");
        messages.Add("Отправляйся в путь и найди их. Я верю в тебя");
    }

    // Update is called once per frame
    public void Update()
    {               
        if (isAssistent)
        {           
            assistent.SetActive(true);
        }
        else
        {
            assistent.SetActive(false);
        }
        if (isAdmin)
        {
            admin.SetActive(true);
        }
        else
        {
            admin.SetActive(false);
        }
        if (isArtemiy)
        {
            artemiy.SetActive(true);
        }
        else
        {
            artemiy.SetActive(false);
        }
        if (isAndrey)
        {
            andrey.SetActive(true);
        }
        else
        {
            andrey.SetActive(false);
        }
        if (isSecondAndrey)
        {
            secondAndrey.SetActive(true);
        }
        else
        {
            secondAndrey.SetActive(false);
        }
        if (isMain)
        {
            main.SetActive(true);
        }
        else
        {
            main.SetActive(false);
        }
        if (dialogIsActive && Input.GetMouseButtonDown(0))
        {
            dialogNum++;
            AfterClickDialog();
        }
    }
    public void ShowMessage()
    {
        dialogIsActive = true;
        textBG.SetActive(true);
        Time.timeScale = 0;
        if (dialogNum == 0)
        {
            isAssistent = true;
        }
        if (dialogNum == 1)
        {
            isAdmin = true;
        }
        if (dialogNum == 2)
        {
            isAndrey = true;
        }
        if (dialogNum == 3 || dialogNum == 4)
        {
            isArtemiy = true;
        }
        if (dialogNum == 5 || dialogNum == 6)
        {
            isMain = true;
        }
        if (dialogNum >= 7 && dialogNum <= 12)
        {
            isSecondAndrey = true;
        }
        if (dialogNum == 12)
        {
            onceInFortress = false;
        }
        showableText.text = messages[dialogNum].ToString();
    }
    public void AfterClickDialog()
    {
        dialogIsActive = false;
        isAndrey = false;
        isAdmin = false;
        isArtemiy = false;
        isAssistent = false;
        isSecondAndrey = false;
        isMain = false;
        Time.timeScale = 1;
        if (dialogNum == 2)
        {
            openableDoor.GetComponent<DoorStates>().OpenDoor();
            textBG.SetActive(false);
        }
        else if (dialogNum == 5)
        {
            SceneManager.LoadScene("Demo 1");
            textBG.SetActive(false);
        }
        else if (dialogNum == 4 || dialogNum == 3)
        {
            ShowMessage();
        }
        else if (dialogNum >= 7 && dialogNum <= 12 && onceInFortress)
        {
            ShowMessage();
        }
        else
        {
            textBG.SetActive(false);
        }
    }

}
