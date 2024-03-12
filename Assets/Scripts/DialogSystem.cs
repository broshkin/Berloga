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
        messages.Add("Григорий, здравствуйте!");
        messages.Add("Меня зовут Полина, я новый ассистент станции МЁД-1103.");
        messages.Add("Вас срочно вызывает начальство к аппарату связи!");
        messages.Add("Гриш, привет! Тут одно дело появилось...");
        messages.Add("На планете BEAR-2023 сломался вездеход, его надо починить.");
        messages.Add("Ты не переживай, с тобой будет наш первопроходец - Андрей.");
        messages.Add("Он обеспечит безопасное пребывание.");
        messages.Add("Спасибо!");
        messages.Add("Привет! Я Андрей, первопроходец.");
        messages.Add("Я так полагаю, ты Гриша.");
        messages.Add("Сейчас я осмотрю планету и можно выдвигаться."); 
        messages.Add("Благо на планете есть атмосфера, даже скафандр не пригодится!");
        messages.Add("*Хе-хе-хе-хе*");
        messages.Add("*Подкрадывается сзади и толкает в портал*");
        messages.Add("Где я?");
        messages.Add("Кто меня сюда толкнул?");
        messages.Add("Куда делся Андрей?");
        messages.Add("Что вообще случилось?");
        messages.Add("Вездеход почти целый, кто его успел восстановить?");
        messages.Add("Так, осталось найти колёса и срочно искать Андрея!");
        messages.Add("А вот и колёса! Почему они так аккуратно укрыты?");
        messages.Add("Ладно, сейчас надо действовать.");
        messages.Add("Осталось закрепить их на передней оси вездехода.");
        messages.Add("Вот мы и снова увиделись...");
        messages.Add("Я думал, что ко мне уже никто не придёт...");
        messages.Add("Я уже долго ошиваюсь на этой планете...");
        messages.Add("Никак не могу найти выход отсюда...");
        messages.Add("В соседней комнате есть портал.");
        messages.Add("Через него можно вернуться на станцию.");
        messages.Add("Но для его работы необходимо добыть три артефакта.");
        messages.Add("Вот карта с их местоположениями. Всё это время я составлял её.");
        messages.Add("Найди сначала Медоракт, потом Рыбку, а затем Веточку.");
        messages.Add("Отправляйся в путь и найди их. Я верю в тебя.");
        for (int i = 0; i < messages.Count; i++)
        {
            messages[i] = '"' + messages[i] + '"';
        }
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
        if (dialogNum >= 0 && dialogNum <= 2)
        {
            isAssistent = true;
        }
        if (dialogNum >= 3 && dialogNum <= 7)
        {
            isAdmin = true;
        }
        if (dialogNum >= 8 && dialogNum <= 11)
        {
            isAndrey = true;
        }
        if (dialogNum == 12 || dialogNum == 13)
        {
            isArtemiy = true;
        }
        if (dialogNum >= 14 && dialogNum <= 22)
        {
            isMain = true;
        }
        if (dialogNum >= 23 && dialogNum <= 32 && onceInFortress)
        {
            isSecondAndrey = true;
        }
        if (dialogNum == 32)
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
        if (dialogNum == 8)
        {
            openableDoor.GetComponent<DoorStates>().OpenDoor();
            textBG.SetActive(false);
        }
        else if (dialogNum == 14)
        {
            SceneManager.LoadScene("Demo 1");
            textBG.SetActive(false);
        }
        else if (dialogNum > 0 && dialogNum <= 2)
        {
            ShowMessage();
        }
        else if (dialogNum > 3 && dialogNum <= 7)
        {
            ShowMessage();
        }
        else if (dialogNum > 8 && dialogNum <= 13)
        {
            ShowMessage();
        }
        else if (dialogNum > 14 && dialogNum <= 18)
        {
            ShowMessage();
        }
        else if (dialogNum > 20 && dialogNum <= 22)
        {
            ShowMessage();
        }
        else if (dialogNum > 23 && dialogNum <= 32 && onceInFortress)
        {
            ShowMessage();
        }
        else
        {
            textBG.SetActive(false);
        }
    }

}
