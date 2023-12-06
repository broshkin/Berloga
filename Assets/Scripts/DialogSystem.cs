using Invector.vCharacterController;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogSystem : MonoBehaviour
{
    public int dialogNum = 0;

    public bool dialogIsActive = false;

    public bool isAssistent = false;
    public bool isAdmin = false;
    public bool isArtemiy = false;
    public bool isAndrey = false;

    public GameObject assistent;
    public GameObject admin;
    public GameObject artemiy;
    public GameObject andrey;

    private List<string> messages = new List<string>();

    public TextMeshProUGUI showableText;

    public GameObject player;

    public GameObject openableDoor;

    public GameObject textBG;
    // Start is called before the first frame update
    void Start()
    {
        textBG.SetActive(false);
        messages.Add("��������, ������������! ���� ����� ������, � ����� ��������� ������� ̨�-1103. ��� ������ �������� ���������� � �������� �����!");
        messages.Add("����, ������! ��� ���� ���� ���������, � ��� �� ������� BEAR-2023 �������� ��������, ��� ���������� ��������. �� �� ���������, � ����� ����� ��� ������������� - ������. �� ������ �� ���, � ���� ����� ���� ��������������� ��� �� �������, ������, ����������, ������ ��� ������, � �� �� ������ �� ����� �� ������������. �������!");
        messages.Add("������! � ������, �������������, � ��� �������, �� �����, �� ��� �, ������ � ����� ����� �� ���������� � ������� ���, ����� �� ���� ������� ���� ���������, ���� �������� �� ����������!");
        messages.Add("*��-��-��-��*");
        messages.Add("*�������������� ���� � ������� � ������*");
    }

    // Update is called once per frame
    void Update()
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
        showableText.text = messages[dialogNum].ToString();
    }
    public void AfterClickDialog()
    {
        dialogIsActive = false;
        isAndrey = false;
        isAdmin = false;
        isArtemiy = false;
        isAssistent = false;
        Time.timeScale = 1;
        if (dialogNum == 2)
        {
            openableDoor.GetComponent<DoorStates>().OpenDoor();
        }
        if (dialogNum == 5)
        {
            SceneManager.LoadScene("Demo 1");
        }
        if (dialogNum == 4 || dialogNum == 3)
        {
            ShowMessage();
        }
        else
        {
            textBG.SetActive(false);
        }
    }

}
