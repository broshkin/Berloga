using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolivStates : MonoBehaviour
{
    public bool isActive = false;
    public string code;
    public GameObject first_step;
    public GameObject second_step;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Poliv()
    {
        code += '0';
    }
    public void Udobrenie()
    {
        code += '1';
    }
    public void Posev()
    {
        code += '2';
    }
    public void Vspohat()
    {
        code += '3';
    }
    public void FirstStep()
    {
        if (code.Contains("312"))
        {
            first_step.SetActive(true);
            second_step.SetActive(false);
        }
    }
    public void SecondStep()
    {
        if (code.Contains("3120"))
        {
            first_step.SetActive(false);
            second_step.SetActive(true);
        }   
    }
    IEnumerator StartAnimations()
    {
        foreach (var a in code)
        {
            Debug.Log(a);
            if (a == '0')
            {
                GetComponent<Animator>().SetBool("poliv", true);
                yield return new WaitUntil(() => GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("poliv"));
            }
            if (a == '1')
            {
                GetComponent<Animator>().SetBool("udobrenie", true);
                yield return new WaitUntil(() => GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("udobrenie"));
            }
            if (a == '2')
            {
                GetComponent<Animator>().SetBool("posev", true);
                yield return new WaitUntil(() => GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("posev"));
            }
            if (a == '3')
            {
                GetComponent<Animator>().SetBool("vspohat", true);
                yield return new WaitUntil(() => GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("vspohat"));
            }
            
        }
        if (code != "3120")
        {
            code = "";
        }
    }

    public void CoroutineActivating()
    {
        StartCoroutine(StartAnimations());
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("poliv"))
        {
            GetComponent<Animator>().SetBool("poliv", false);
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("udobrenie"))
        {
            GetComponent<Animator>().SetBool("udobrenie", false);
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("posev"))
        {
            GetComponent<Animator>().SetBool("posev", false);
        }
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("vspohat"))
        {
            GetComponent<Animator>().SetBool("vspohat", false);
        }
    }
}
