using System.Collections;
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
    public static bool isMisha = false;
    public static bool onceInFortress = true;

    public GameObject assistent;
    public GameObject admin;
    public GameObject artemiy;
    public GameObject andrey;
    public GameObject secondAndrey;
    public GameObject main;
    public GameObject misha;

    private static List<string> messages = new List<string>();

    public TextMeshProUGUI showableText;

    public GameObject player;

    public GameObject openableDoor;

    public GameObject textBG;

    public AudioSource bear;

    public bool once = true;

    public GameObject tasks;
    // Start is called before the first frame update
    public void Start()
    {
        textBG.SetActive(false);
        messages.Add("��������, ������������!");
        messages.Add("���� ����� ������, � ����� ��������� ������� ̨�-1103.");
        messages.Add("��� ������ �������� ���������� � �������� �����!");
        messages.Add("����, ������! ��� ���� ���� ���������...");
        messages.Add("�� ������� BEAR-2023 �������� ��������, ��� ���� ��������.");
        messages.Add("�� �� ���������, � ����� ����� ��� ������������� - ������.");
        messages.Add("�� ��������� ���������� ����������.");
        messages.Add("�������!");
        messages.Add("������! � ������, �������������.");
        messages.Add("� ��� �������, �� �����.");
        messages.Add("������ � ������� ������� � ����� �����������."); 
        messages.Add("����� �� ������� ���� ���������, ���� �������� �� ����������!");
        messages.Add("*��-��-��-��*");
        messages.Add("*�������������� ����� � ������� � ������*");
        messages.Add("��� ��?");
        messages.Add("��� ��� ���� �������?");
        messages.Add("���� ����� ������?");
        messages.Add("��� ������ ���������?");
        messages.Add("�������� ����� �����, ��� ��� ����� ������������?");
        messages.Add("���, ��� ����� ������ ����� ����� � ����������� ������ ������!");
        messages.Add("� ��� � �����! ������ ��� ��� ��������� ������?");
        messages.Add("�����, ������ ���� �����������.");
        messages.Add("�������� ��������� �� �� �������� ��� ���������.");
        messages.Add("��� ��� ����?");
        messages.Add("� ������ ��� ������ �� �����.");
        messages.Add("��� ������?");
        messages.Add("��� ���� ���� �������� �����������...");
        messages.Add("��� �� � ����� ���������...");
        messages.Add("� �����, ��� �� ��� ��� ����� �� �����...");
        messages.Add("� ��� ����� �������� �� ���� �������...");
        messages.Add("����� �� ���� ����� ����� ������...");
        messages.Add("� �������� ������� ���� ������.");
        messages.Add("����� ���� ����� ��������� �� �������.");
        messages.Add("�� ��� ��� ������ ���������� ������ ��� ���������.");
        messages.Add("��� ����� � �� ����������������. �� ��� ����� � ��������� �.");
        messages.Add("����� ������� ��������, ����� �����, � ����� �������.");
        messages.Add("����������� � ���� � ����� ��. � ���� � ����.");
        messages.Add("���, ���� ����� ������?");
        messages.Add("�������� ������� �������� � ������������������: ��������, ���������, �����, �����");
        messages.Add("���, �� �������, �� ����� ����������!");
        messages.Add("���, �� �� ����!");
        messages.Add("�����, ���, ��� �������!");
        messages.Add("���, �� ������� ����� ��������!");
        messages.Add("����� �������������, �� ����� ����, ��������� ������� WASD.");
        messages.Add("�������! ������ ������� � ����� � �������� �.");
        messages.Add("������� ������ �������!");
        messages.Add("����� ���������� ������� � ��������, � ����� ����� �� ������� ��������� ������� ��� ������� ESCAPE.");
        messages.Add("�� �� ����! �������� �����! ��������� ��� ����� ����� SHIFT.");
        messages.Add("����� ���������! ��������� ������!");
        messages.Add("�������� ��������� ����� ��������� ��������.");
        messages.Add("��� ����� ��������� ��������������� ������ ������.");
        messages.Add("�������! ������ �� ����� �� ���� ����������! �� � ���� ���, � ������ ������!");

        for (int i = 0; i < messages.Count; i++)
        {
            if (messages[i][0] != '"')
            {
                messages[i] = '"' + messages[i] + '"';
            }   
        }
    }



    // Update is called once per frame
    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "Demo 1")
        {
            if (bear.isPlaying && once)
            {
                once = false;
                StartCoroutine(WaitForEndBearSound());
            }
        }

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
        if (isMisha)
        {
            misha.SetActive(true);
        }
        else
        {
            misha.SetActive(false);
        }
        if (dialogIsActive && Input.GetMouseButtonDown(0) && dialogNum != 37)
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
        if (dialogNum >= 14 && dialogNum <= 18)
        {
            isMain = true;
        }
        if (dialogNum >= 20 && dialogNum <= 26)
        {
            isMain = true;
        }
        if (dialogNum == 19)
        {
            isMisha = true;
        }
        if (dialogNum >= 27 && dialogNum <= 36 && onceInFortress)
        {
            isSecondAndrey = true;
        }
        if (dialogNum == 36)
        {
            onceInFortress = false;
        }
        if (dialogNum >= 37)
        {
            isMisha = true;
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
        isMisha = false;
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
        else if (dialogNum > 8 && dialogNum <= 11)
        {
            ShowMessage();
        }
        else if (dialogNum > 14 && dialogNum <= 19)
        {
            ShowMessage();
        }
        else if (dialogNum > 20 && dialogNum <= 22)
        {
            ShowMessage();
        }
        else if (dialogNum > 23 && dialogNum <= 25)
        {
            ShowMessage();
        }
        else if (dialogNum > 26 && dialogNum <= 26)
        {
            ShowMessage();
        }
        else if (dialogNum > 27 && dialogNum <= 36 && onceInFortress)
        {
            ShowMessage();
        }
        else if (dialogNum > 42 && dialogNum <= 43)
        {
            ShowMessage();
        }
        else if (dialogNum > 45 && dialogNum <= 46)
        {
            ShowMessage();
        }
        else if (dialogNum > 49 && dialogNum <= 50)
        {
            ShowMessage();
        }
        else
        {
            textBG.SetActive(false);
        }
        if (dialogNum == 20)
        {
            tasks.transform.GetChild(0).gameObject.SetActive(true);
            Tasks.index = 0;
            tasks.GetComponent<Tasks>().SetTask();
        }
        if (dialogNum == 37)
        {
            Tasks.index = 3;
            GameObject.Find("TaskCanvas").GetComponent<Tasks>().SetTask();
        }
    }

    IEnumerator WaitForEndBearSound()
    {
        yield return new WaitWhile(() => bear.isPlaying);
        dialogNum = 23;
        ShowMessage();
    }

}
